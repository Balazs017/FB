using System;
 
class Rep1
{
    static int N = 80;
    static int[] magas = new int[N];
   
    static void Kiir(){
        Console.SetCursorPosition(0,0);
        Console.WriteLine(' ');
        for (int i = 0; i < N; i++)
        {
            Console.Write(i % 10);
        }
        Console.SetCursorPosition(0,34);
        Console.WriteLine(' ');
        for (int i = 0; i < N; i++)
        {
            Console.Write(i % 10);
        }
        for (int y = 33; y >= 1; y--)
        {
            Console.SetCursorPosition(0,y);
            Console.Write((33-y)% 10);
            Console.SetCursorPosition(N-1, y);
            Console.Write((33-y) % 10);
        }
        for (int x = 0; x < N; x++)
        {
            for (int y = 33; y >= 33-magas[x]; y--)
            {
                Console.SetCursorPosition(x+1,y);
                Console.Write('█');
            }
        }
 
    }
   
    static void Main(){
        Console.SetWindowSize(N+2,60);
        Console.Clear();
 
        int szint = 10;
 
        Random rnd = new Random();
        magas[0] = szint;
        for (int i = 1; i < N; i++)
        {
            magas[i] = magas[i -1] + rnd.Next(-2,3);
        }
        for (int i = 0; i < N; i++)
        {
            if (magas[i] < 0)
            {
                magas[i] = 0;
            }
        }
        Kiir();
    }
}
 