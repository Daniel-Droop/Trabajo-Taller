using System;
using System.ComponentModel;

namespace Algoritmo_4
{
    class Program
    {
        private static string entrada;

        static void Main(string[] args)
        {
            int NAlum;
            int NNotas;
            int Cont = 0;
            double ContR;
            int K = 0;
            


            Console.WriteLine("Digite la cantidad de estudiantes: ");
            entrada = Console.ReadLine();
            NAlum = Convert.ToInt32(entrada);
            Console.WriteLine("");

            Console.WriteLine("Digite la cantidad de notas por estudiante: ");
            entrada = Console.ReadLine();
            NNotas = Convert.ToInt32(entrada);
            Console.WriteLine("");

            for (int i = 0; i < NAlum; i++)
            {
                
                for (int j = 0; j < NNotas; j++)
                {
                    Console.WriteLine("Calificacion: ");
                    entrada = Console.ReadLine();
                    K = Convert.ToInt32(entrada);
                    Cont = (Cont + K);

                }
                Console.WriteLine("Siguentes notas");
                Console.WriteLine("");
            }
            ContR = (Cont / NNotas);
            Console.WriteLine("La media es de: {0}", ContR);

        }
    }
}