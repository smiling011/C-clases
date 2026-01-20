using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //hola mundo en visual studio
            Console.WriteLine("Hello, World!");

            //programa para calcular el area de un rectangulo

            //declaracion de variables dos tipos de declarar:

            //tipo implicito

            var ladoA = 1.1;
            var ladoB = 1.1;
            var resultado = 1.1;


            //declaracion sin valor inicial

            //int ladoA;
            //int ladoB;
            //int resultado;

            Console.WriteLine("Calcula  el area de un rectangulo");
            Console.WriteLine("Ingrese el valero del lado A");
            ladoA = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el valor del lado B");
            ladoB = Convert.ToInt32(Console.ReadLine());

            resultado = ladoA * ladoB;
            Console.WriteLine("El lado a es: " +ladoA + " El lado B es: "+ladoB + " El resultados es : " +resultado);






            // para mntener consola de copilacion abierta
            Console.ReadKey();


        }
    }
}
