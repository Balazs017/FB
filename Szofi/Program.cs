using System;
using System.IO;
using System.Text;

class BeKi{
    static void Egybe(string fileNev )
    {
        System.Console.WriteLine("File egyben beolvasva");
        string egesz = File.ReadAllText(fileNev);
        System.Console.WriteLine(egesz);
    }
    static void EgybeSorokba(string fileNev){
        System.Console.WriteLine("File egyben es sorokat kapok");
        string[] sorok = File.ReadAllLines(fileNev);
        for (int i = 0; i < sorok.Length; i++)
        {
            System.Console.WriteLine(sorok[i]);   
        }
    }
    static void SoronkentOlvasva(string fileNev)
    {
        StreamReader sr = new StreamReader(fileNev);
        List<string> sorokLista = new List<string>();
        string sor = sr.ReadLine();
        while (sor!= null)
        {   
            sorokLista.Add(sor);
            sor = sr.ReadLine();
        }
        string[] sorok = sorokLista.ToArray();
         for (int i = 0; i < sorok.Length; i++)
        {
            System.Console.WriteLine(sorok[i]);   
        }
    
        sr.Close();
    }
    static void SoronkentFeldolgozva(string fileNev)
    {
        StreamReader sr = new(fileNev);
        List<string> nevek = [];
        List<int> evszamok = [];
        List<int> pontok = [];
        string? sor = sr.ReadLine();
        while(sor !=null)
        {
            sor = sor.Trim();
            if(sor!="")
            {
                string[] darabok = sor.Split(';');
                nevek.Add(darabok[0]);
                evszamok.Add(int.Parse(darabok[1]));
                pontok.Add(int.Parse(darabok[2]));

            }
            sor=sr.ReadLine();
        }
        sr.Close();
        System.Console.WriteLine("Név\t\tSzületett\t");
        for( int i =0; i <nevek.Count; i++)
        {
            System.Console.WriteLine($"{nevek[i]}\t{evszamok[i]}\t{pontok[i]}");
        }
    }
    static void Main()
    {
        Egybe("..\\..\\..\\bemenet1.txt");
        EgybeSorokba(@"..\..\..\bemenet1.txt");
        SoronkentOlvasva(@"..\..\..\bemenet1.txt");
    }
}