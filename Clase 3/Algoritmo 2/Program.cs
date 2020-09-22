using System;

namespace Algoritmo_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 0, CP = 0, CI = 0, SP = 0, SI = 0, Ar = 0;

            Console.WriteLine("Digite 10 números: ");
            Console.WriteLine("");

            for (int a = 1; a <= 10; a++)
            {
                Console.Write("digite un número: ");
                N = int.Parse(Console.ReadLine());

                if (N % 2 == 0)
                {
                    CP = CP + 1;
                    SP = SP + N;
                }
                else
                {
                    CI = CI + 1;
                    SI = SI + N;
                }
                Ar = SI / CI;
                Console.WriteLine("");
                Console.WriteLine(" la cantidad de números pares digitas es: {0}, por ello la suma de los pares es: {1}", CP, SP);
                Console.WriteLine("");
                Console.WriteLine(" la media aritmetica de los números impares es: {0}", Ar);
            }
        }
    }
}
