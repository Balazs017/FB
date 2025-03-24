using System;

 struct Szampar{public int ossze, csere;} 

class Rendezesek
{   static int [] tomb;

    const  int N =30;
    static void Kiir(){
        for (int i=0; i<N; i++)
            System.Console.WriteLine(tomb[i]+ " ");
        System.Console.WriteLine();
    }
    static void Csere(int k, int m){
        int ment = tomb[k];
        tomb[k] = tomb[m];
        tomb[m] = ment;

    }
    static Szampar MinKivRend()
    {
        Szampar szp = new ();
        szp.csere =0;
        szp.ossze = 0;
        for(int hova= 0 ; hova<=N-2; hova++){
            int melyik = hova;
            for( int marad = melyik+1; marad<N; marad++)
            {
                if ( tomb[marad] < tomb[melyik])
                melyik = marad;
                szp.ossze++;
            }
            if(hova != melyik) {Csere(hova,melyik);
            szp.csere++;}
        }
        return szp;
    }
    static void Main()
    {

        Random rnd = new ();
        
        tomb = new int [N];

        for(int i = 0 ; i <N; i++)
            tomb[i] = rnd.Next(1000,10000);
        Kiir();
        Szampar ocs = MinKivRend();
        Kiir();
        System.Console.WriteLine("Összehasonlítás:" + ocs.ossze+"\tCsere:" +ocs.csere);
    }

}
