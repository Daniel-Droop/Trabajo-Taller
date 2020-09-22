using System;

namespace Algoritmo_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, P = 0, IM = 0;

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("digite el numero entero");
                N = Convert.ToInt32(Console.ReadLine());

                if ((N % 2) == 0)
                {
                    P = P + N;
                }
                else
                {
                    IM = IM + N;
                }
            }
            Console.WriteLine("la suma de los numeros impares es de: {0}", IM);
            Console.WriteLine("la suma de numeros pares es de: {0}", P);
        }
    }
}
