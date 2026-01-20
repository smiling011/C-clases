using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opradores_Logicos
{
    class Program
    {
        static void Main(string[] args)
        {
            //funcionalidades logicas

            //&& and
            //|| or
            //!
            //^

            //declaracion normal

            //bool valor1 = true;
            //bool valor2 = false;
            //bool valor3 = true;

            //declaracion doble
            var (valor1, valor2, valor3) = (true, true, false);


            bool resultAnd = valor1 && valor2 && valor3;
            Console.WriteLine(resultAnd);

            bool resultOr = valor1 || valor2 || valor3;
            Console.WriteLine(resultOr);

            bool resultAndOr = (valor1 && valor2) || valor3;
            Console.WriteLine(resultAndOr);

            bool resultNot = !valor1;
            Console.WriteLine(resultNot);

            bool resultXor = (valor1 ^ valor2) ^ valor3;
            Console.WriteLine(resultXor);

            Console.ReadKey();


        }
    }
}
