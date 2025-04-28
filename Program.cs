namespace Munka0428

{

    internal class Program

    {

        static int[] hosszak(string[] szovegek)

        {

            int[] hok = new int[szovegek.Length];

            for (int i = 0; i < szovegek.Length; i++)

            {

                hok[i] = szovegek[i].Length;

            }

            return hok;

        }

        static double szamol(double a, double b)

        {

            if (a >= 0 && b >= 0)
            {

                return a * b;

            }

            else if (a < 0 && b < 0)
            {

                return a / b;

            }

            else { return 0; }

        }

        static int el_par(List<int> a)

        {

            int szam = 0;

            for (int i = 0; i < a.Count; i++)

            {

                if (a[i] % 2 != 0)

                {

                    szam = i;

                    break;

                }

            }

            return szam;

        }



        static void Main(string[] args)

        {

            //Console.WriteLine("Kérem a szövegeket:");

            //string bemenet = Console.ReadLine();

            //string[] bem_feld = bemenet.Split(',');

            //int[] ahosszak = hosszak(bem_feld);

            //Console.Write("az eredmeny: ");

            //for (int i = 0; i < ahosszak.Length; i++)

            //{

            //    Console.Write(ahosszak[i]);

            //    if (i < ahosszak.Length - 1)

            //        Console.Write(',');

            //    else

            //        Console.WriteLine();

            //}

            //Console.WriteLine("elso szam:");

            //double a = double.Parse(Console.ReadLine());

            //Console.WriteLine("masodik szam:");

            //double b = double.Parse(Console.ReadLine());

            //Console.WriteLine("eredmeny: "+szamol(a, b));

            //Console.WriteLine("Kérem a szamokat:");

            //string bemenet = Console.ReadLine();

            //string[] bemenetfeld = bemenet.Split(',');

            //int[] tomb = new int[bemenetfeld.Length];

            //for (int i = 0; i < bemenetfeld.Length; i++) {

            //    tomb[i] = int.Parse(bemenetfeld[i]);

            //} 

            //Console.WriteLine("eredmeny: " + el_par(tomb.ToList()));



        }

    }

}

