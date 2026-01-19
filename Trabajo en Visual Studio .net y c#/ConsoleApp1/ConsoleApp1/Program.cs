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
            int ladoA;
            int ladoB;
            int resultado;

            Console.WriteLine("Calcula  el area de un rectangulo");
            Console.WriteLine("Ingrese el valero del lado A");
            ladoA = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el valor del lado B");
            ladoB = Convert.ToInt32(Console.ReadLine());

            resultado = ladoA * ladoB;
            Console.WriteLine(resultado);






            // para mntener consola de copilacion abierta
            Console.ReadKey();


        }
    }
}
