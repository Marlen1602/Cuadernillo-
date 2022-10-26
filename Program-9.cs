using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPCION
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char opcion;
            double x, e, Resultado, R1, R2, R3, R4, R5, R6, R7, R8, R9, R10;
            Console.WriteLine("OPCION MULTIPLE:");
            Console.WriteLine("1- TABLA DE MULTIPLICAR");
            Console.WriteLine("2-EXPONENCIACION");
            Console.WriteLine("3-RAIZ CUADRADA");
            opcion = char.Parse(Console.ReadLine());
            if (!((opcion == '1') || (opcion == '2') || (opcion == '3')))
                Console.WriteLine("La ocion no existe");
            else

            if (opcion == '1')
            {
                Console.WriteLine("Ingresa un numero:");
                x = double.Parse(Console.ReadLine());
                Console.WriteLine("ELresultado es");
                R1 = x * 1;
                Console.WriteLine(+R1);
                R2 = x * 2;
                Console.WriteLine(+R2);
                R3 = x * 3;
                Console.WriteLine(+R3);
                R4 = x * 4;
                Console.WriteLine(+R4);
                R5 = x * 5;
                Console.WriteLine(+R5);
                R6 = x * 6;
                Console.WriteLine(+R6);
                R7 = x * 7;
                Console.WriteLine(+R7);
                R8 = x * 8;
                Console.WriteLine(+R8);
                R9 = x * 9;
                Console.WriteLine(+R9);
                R10 = x * 10;
                Console.WriteLine(+R10);
            }
            if (opcion == '2')
            {
                Console.WriteLine("Ingrese el primer dato:");
                x = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo dato:");
                e = double.Parse(Console.ReadLine());
                Resultado = Math.Pow(x, e);
                Console.WriteLine("El resultado es:" + Resultado);
            }
            if (opcion == '3')
            {
                Console.WriteLine("Ingresa el numero:");
                x = double.Parse(Console.ReadLine());
                Resultado = Math.Sqrt(x);
                Console.WriteLine("El resultado es:" + Resultado);
            }
            Console.ReadKey();
        }
    }
}
