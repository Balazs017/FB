using System;

class Kivetelek
{
      public static void Main()
      {

            try
            {
                  System.Console.Write("Kérek egy egész számot:");
                  string sor1 = Console.ReadLine()!;
                  int szam1 = int.Parse(sor1);

                  System.Console.Write("Kérek egy másik egész számot: ");
                  string sor2 = Console.ReadLine()!;
                  int szam2 = int.Parse(sor2);


                  System.Console.WriteLine("Mi legyen a művelet (+,-,*,/,%):");
                  char muvelet = Console.ReadLine()![0];


                  int eredmeny; switch (muvelet)
                  {
                        case '+': eredmeny = szam1 + szam2; break;
                        case '-': eredmeny = szam1 - szam2; break;
                        case '*': eredmeny = szam1 * szam2; break;
                        case '/': eredmeny = szam1 / szam2; break;
                        case '%': eredmeny = szam1 % szam2; break;
                        default: throw new IndexOutOfRangeException(); 
                  }

                  System.Console.WriteLine($"Az eredmény: {eredmeny}");
            }


            catch (ArgumentNullException)
            {
                  Console.WriteLine("HIBA: nincs bemeneti érték!");
            }
            catch (FormatException)
            {
                  System.Console.WriteLine("HIBA: nem egész számérték!");
            }
            catch (DivideByZeroException)
            {
                  System.Console.WriteLine("HIBA: nem oszthatunk nullával!");
            }
            catch (IndexOutOfRangeException)
            {
                  System.Console.WriteLine("HIBA: nem megfelelő művelet");
            }
      }
}