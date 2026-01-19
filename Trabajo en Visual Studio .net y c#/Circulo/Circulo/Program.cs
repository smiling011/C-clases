using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circulo
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables declaradas
            var radio = 0d;
            var resultado = 0d;

            //constante 
            //const double Pi = 3.14;

            //print del mensaje al user
            Console.WriteLine("Bienvenido a Calculadora circulo");

            //Mensaje al userque lee lo que ingrasa 
            Console.WriteLine("ingrese el valor del radio");
            radio = Convert.ToDouble(Console.ReadLine());

            //proceso que hace para calcular el problema
            resultado = Math.PI * (radio * radio);

            //imprime el resultado
            Console.WriteLine("El area de tu circulo es de: "+resultado);

            Console.ReadKey();
        }
    }
}
