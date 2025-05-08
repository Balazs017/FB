using System;

class Ipv6
{
      const string ipbe = @"..\..\..\..\ip.txt";
      const string ipki = "..\\..\\..\\..\\ipv6egysz.txt";



      static string vezNullElh(string cim)
      {
            string[] nyolcas = cim.Split(':');

            for (int i = 0; i < nyolcas.Length; i++)
            {
                  nyolcas[i] = nyolcas[i].TrimStart('0');
                  if (string.IsNullOrEmpty(nyolcas[i]))
                  {
                        nyolcas[i] = "0";
                  }
            }

            string vnnCim = String.Join(":", nyolcas);

            return vnnCim;
      }


      static string legHnullaElh(string cim)
      {
            string[] nyolcas = cim.Split(':');
            for (int i = 0; i < nyolcas.Length; i++)
            {
                  nyolcas[i] = nyolcas[i].TrimStart('0');
                  if (nyolcas[i] == "") nyolcas[i] = "0";
            }
            return string.Join(":", nyolcas);
      }

      static string LegHnullaElh(string cim)
      {
            string[] nyolcas = cim.Split(':');
            int max0sz = 0;
            int max0index = -1;
            int jelen0sz = 0;
            int jelen0s = -1;

            for (int i = 0; i < nyolcas.Length; i++)
            {
                  if (nyolcas[i] == "0")
                  {
                        if (jelen0sz == 0) jelen0s = i;
                        jelen0sz++;
                  }
                  else
                  {
                        if (jelen0sz > max0sz)
                        {
                              max0sz = jelen0sz;
                              max0index = jelen0s;
                        }
                        jelen0sz = 0;
                  }
            }

            if (jelen0sz > max0sz)
            {
                  max0sz = jelen0sz;
                  max0index = jelen0s;
            }

            if (max0sz > 1)
            {
                  List<string> lista = new List<string>();
                  int i = 0;
                  while (i < nyolcas.Length)
                  {
                        if (i == max0index)
                        {
                              lista.Add("");
                              i += max0sz;
                              if (i >= nyolcas.Length) lista.Add("");
                        }
                        else
                        {
                              lista.Add(nyolcas[i]);
                              i++;
                        }
                  }
                  return string.Join(":", lista).Replace(":::", "::");
            }
            else
            {
                  return string.Join(":", nyolcas);
            }
      }

      public static void Main(String[] args)
      {
            Console.WriteLine("IP v6 címek átalakítása!");

            StreamReader be = null!;
            StreamWriter ki = null!;
            try
            {
                  be = new StreamReader(ipbe);
                  ki = new StreamWriter(ipki);

                  string? sor = be.ReadLine();
                  while (sor != null)
                  {
                        Console.Write(sor);
                        ki.Write(sor);

                        try
                        {
                              sor = vezNullElh(sor);
                              sor = LegHnullaElh(sor);
                        }
                        catch (IndexOutOfRangeException)
                        {
                              sor = "Hibás indexelés";
                        }
                        finally
                        {
                              ki.WriteLine($" --> {sor}");
                              sor = be.ReadLine();
                        }
                  }
            }
            catch (FileNotFoundException)
            {
                  Console.WriteLine("A bemeneti fájl nem található!");
            }
            catch (DirectoryNotFoundException)
            {
                  Console.WriteLine("A kimeneti állomány nem létrehozható, nincs ilyen mappa");
            }
            catch (Exception ex)
            {
                  Console.WriteLine($"HIBA: {ex.Message}");
            }
            finally
            {
                  if (be != null) be.Close();
                  if (ki != null) ki.Close();
            }
      }

}
