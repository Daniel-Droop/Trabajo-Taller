using System;
using System.Collections;
using System.Collections.Generic;

//Escriba una rutina que reciba una Pila P de números enteros y devuelva una copia exacta
//de la misma. Es de destacar que la Pila P no debe sufrir ningún tipo de cambio o alteración.

namespace Ejercicios_pilas_Nu5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crearemos 2 pilas par aasi poder copearlas y asi mostrarlas por pantalla
            Stack Pnum1 = new Stack();
            Stack Pnum2 = new Stack();
            Stack Pnum3 = new Stack();

            //declaramos las variables las cuales seran copeadas 
            Pnum1.Push(2);
            Pnum1.Push(5);
            Pnum1.Push(8);
            Pnum1.Push(20);
            Pnum1.Push(30);

            //Aqui llamamos el static el cual el el metodo que nos guarda y permite llamar a las tres pilas las cuales copeamos
            Console.WriteLine("La pila copeada es: ");
            copia(Pnum1, Pnum2, Pnum3);
            Console.ReadKey();
        }
        static void copia(Stack n, Stack n1, Stack n2)
        {
            //Con este proceso transportaremos las variavles copenadolas como lo pidio el ejercicio
            //con el waw almacenamos nuestras variables y las transportamos a otra junto con el cout lo cual nos va a ir almacenando las variables asi al irla
            //transportando van generando una copia la cual llamamos mas atras y asi mostrar la copia de la pila 
            while (n.Count > 0)
                n1.Push(n.Pop());
            while (n1.Count > 0)
                n2.Push(n1.Pop());
            while (n2.Count > 0)
                Console.WriteLine("{0}", n2.Pop());
        }
    }
}