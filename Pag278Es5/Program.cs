using System;

namespace Pag278Es5
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Quanti biglietti vuoi acquistare?");
            int biglietti = int.Parse(Console.ReadLine());
            int max = 6;
            Random r = new Random();
            int[] ArrayBiglietti = new int[biglietti];
            for(int i = 0;i < ArrayBiglietti.Length; i++)
            {
                ArrayBiglietti[i] = r.Next(0, 999999);
                Console.WriteLine($"{ArrayBiglietti[i]}");

            }
        }
    }
}
