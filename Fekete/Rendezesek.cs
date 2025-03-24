using System;
class Rendezesek
{
    static void Main()
    {
        Random rnd = new ();
        int szam = rnd.Next(150,360);
        System.Console.WriteLine("Erre a számra gondoltam: " +szam);
        int masik = rnd.Next(150,360);
        System.Console.WriteLine("És másik szám: " +masik);

        System.Console.Write("A két szám közös osztói: "); 


        for ( int i = 1; i< Math.Min(szam, masik); i++)
        {
                if ( szam % i == 0 && masik % i == 0){
                    System.Console.Write(i + " ");
                }
        }
    }

}


