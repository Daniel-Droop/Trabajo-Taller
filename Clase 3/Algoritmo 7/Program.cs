using System;

namespace Algoritmo_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = null;
            do
            {
                int Al = 0, P = 0, M4 = 0, Ms4 = 0, Ms5 = 0, Ms6 = 0;

                Console.WriteLine("Digete la cantidad de alumnos");
                Al = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < Al; i++)
                {
                    Console.WriteLine("Cual es tu pero 1: menos de 40kg, 2:entre 40 y 50kg, 3: mas de 50 y menos de 60kg, 4: mas o igual a 60kg");
                    P = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("");
                    switch (P)
                    {
                        case 1:
                            Console.WriteLine("elegiste menos de 40kg");
                            M4++;
                            break;
                        case 2:
                            Console.WriteLine("elegiste entre 40 y 50kg");
                            Ms4++;
                            break;
                        case 3:
                            Console.WriteLine("elegiste  mas de 50 y menos de 60kg");
                            Ms5++;
                            break;
                        case 4:
                            Console.WriteLine("elegiste mas o igual a 60kg");
                            Ms6++;
                            break;
                    }
                }
                Console.WriteLine("la cantidad de alumnos que pesan menos de 40kg son: {0}", M4);
                Console.WriteLine("la cantidad de alumnos que pesan entre 40 y 50kg: {0}",  Ms4);
                Console.WriteLine("la cantidad de alumnos que pesan mas de 50 y menos de 60kg: {0}", Ms5);
                Console.WriteLine("la cantidad de alumnos que pesan mas o igual a 60kg: {0}", Ms6);

                Console.WriteLine("deseas continual ejecutando la aplicacion? (s/n)");
                s1 = Console.ReadLine();
            } while (s1 == "s");
        }
    }
}
