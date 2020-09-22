using System;

namespace Algoritmo_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = null;
            do
            {
                int HM = 0, Mas = 0, HE = 0, HEm = 0, ME = 0, Fe = 0;
                int Es, Sal;
                int EM = 5;
                int P = 0, Ho = 0;
                int Acomu = 0;

                for (int i = 0; i < EM; i++)
                {

                    Console.WriteLine("Digite su sexo Hombre o Mujer");
                    string sexo = Console.ReadLine();
                    Console.WriteLine("");
                    switch (sexo)
                    {
                        case ("Hombre"):

                            Mas++;
                            Console.WriteLine("Introdusca su edad: ");
                            Ho = Convert.ToInt32(Console.ReadLine());

                            Acomu = Acomu + Ho;

                            Console.WriteLine("");
                            Console.WriteLine("elija su estado civil (1:soltero, 2:casado, 3:viudo)");
                            Es = Convert.ToInt16(Console.ReadLine());
                            Console.WriteLine("");
                            switch (Es)
                            {
                                case 1:
                                    Console.WriteLine("");
                                    Console.WriteLine("elija su salario (1: menos de 600 Bs.F., 2: entre 600 y 1000Bs.F., 3: Mas de 1000Bs)");
                                    Sal = Convert.ToInt16(Console.ReadLine());
                                    Console.WriteLine("");
                                    switch (Sal)
                                    {
                                        case 1:
                                            Console.WriteLine("usted a digitado menos de 600 Bs.F.");
                                            break;
                                        case 2:
                                            Console.WriteLine("Usted digito entre 600 y 1000Bs.F.");
                                            break;
                                        case 3:
                                            Console.WriteLine("Usted digito Mas de 1000Bs");
                                            break;
                                    }
                                    break;
                                case 2:
                                    Console.WriteLine("");
                                    Console.WriteLine("elija su salario (1:menos de 600 Bs.F., 2:entre 600 y 1000Bs.F., 3:Mas de 1000Bs)");
                                    Sal = Convert.ToInt16(Console.ReadLine());
                                    Console.WriteLine("");
                                    switch (Sal)
                                    {
                                        case 1:
                                            Console.WriteLine("usted a digitado menos de 600 Bs.F.");
                                            HM++;
                                            break;
                                        case 2:
                                            Console.WriteLine("Usted digito entre 600 y 1000Bs.F.");
                                            HE++;
                                            break;
                                        case 3:
                                            Console.WriteLine("Usted digito Mas de 1000Bs");
                                            HEm++;
                                            break;
                                    }
                                    break;
                                case 3:
                                    Console.WriteLine("");
                                    Console.WriteLine("Escoja su salario (1: menos de 600 Bs.F., 2: entre 600 y 1000Bs.F., 3: Mas de 1000Bs)");
                                    Sal = Convert.ToInt16(Console.ReadLine());
                                    Console.WriteLine("");
                                    switch (Sal)
                                    {
                                        case 1:
                                            Console.WriteLine("usted a digitado menos de 600 Bs.F.");
                                            break;
                                        case 2:
                                            Console.WriteLine("Usted digito entre 600 y 1000Bs.F.");
                                            break;
                                        case 3:
                                            Console.WriteLine("Usted digito Mas de 1000Bs");
                                            break;
                                    }
                                    break;
                            }
                            break;
                        case ("mujer"):
                            Fe++;
                            Console.WriteLine("digite su edad");
                            int mujeedad = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("");
                            Console.WriteLine("elija su estado civil (1: soltera, 2: casada, 3: viuda)");
                            Es = Convert.ToInt16(Console.ReadLine());
                            Console.WriteLine("");
                            switch (Es)
                            {
                                case 1:
                                    Console.WriteLine("");
                                    Console.WriteLine("elija su salario (1: menos de 600 Bs.F., 2: entre 600 y 1000Bs.F., 3: Mas de 1000Bs)");
                                    Sal = Convert.ToInt16(Console.ReadLine());
                                    Console.WriteLine("");
                                    switch (Sal)
                                    {
                                        case 1:
                                            Console.WriteLine("usted a digitado menos de 600 Bs.F.");
                                            break;
                                        case 2:
                                            Console.WriteLine("Usted digito entre 600 y 1000Bs.F.");
                                            break;
                                        case 3:
                                            Console.WriteLine("Usted digito Mas de 1000Bs");
                                            break;
                                    }
                                    break;
                                case 2:
                                    Console.WriteLine("");
                                    Console.WriteLine("elija su salario (1:menos de 600 Bs.F., 2:entre 600 y 1000Bs.F., 3:Mas de 1000Bs)");
                                    Sal = Convert.ToInt16(Console.ReadLine());
                                    Console.WriteLine("");
                                    switch (Sal)
                                    {
                                        case 1:
                                            Console.WriteLine("usted a digitado menos de 600 Bs.F.");
                                            break;
                                        case 2:
                                            Console.WriteLine("Usted digito entre 600 y 1000Bs.F.");
                                            break;
                                        case 3:
                                            Console.WriteLine("Usted digito Mas de 1000Bs");
                                            break;
                                    }
                                    break;
                                case 3:
                                    Console.WriteLine("");
                                    Console.WriteLine("elija su salario (1:menos de 600 Bs.F., 2:entre 600 y 1000Bs.F., 3:Mas de 1000Bs)");
                                    Sal = Convert.ToInt16(Console.ReadLine());
                                    Console.WriteLine("");
                                    switch (Sal)
                                    {
                                        case 1:
                                            Console.WriteLine("usted a digitado menos de 600 Bs.F.");
                                            break;
                                        case 2:
                                            Console.WriteLine("Usted digito entre 600 y 1000Bs.F.");
                                            ME++;
                                            break;
                                        case 3:
                                            Console.WriteLine("Usted digito Mas de 1000Bs");
                                            break;
                                    }
                                    break;
                            }
                            break;
                    }
                }
                P = Acomu / Mas;

                Console.WriteLine("El total del personal mujer es de: " + Fe);
                Console.WriteLine("");
                Console.WriteLine("El total de hombres casados que ganan más de 1000 Bs.F. : " + HEm);
                Console.WriteLine("");
                Console.WriteLine("Total de mujeres viudas que ganan más de 600 Bs: " + ME);
                Console.WriteLine("");
                Console.WriteLine("el promedio de edad de los hombre es de: " + P);


                Console.WriteLine("deseas continuar ejecutando la aplicacion? (s/n)");
                s1 = Console.ReadLine();

            } while (s1 == "s");
            Console.WriteLine();
        }
    }
}
			

		
