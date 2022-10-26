using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            string opc;
            do
            {
                Console.Clear();
                int lado1, lado2, lado3;
                Console.WriteLine("        Problemática : Supuesto triangulo");
                Console.WriteLine("");
                Console.WriteLine("Ingrese el valor del lado 1: ");
                lado1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el valor del lado 2: ");
                lado2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el valor del lado 3: ");
                lado3 = int.Parse(Console.ReadLine());
                if (lado1 > 0 && lado2 > 0 && lado3 > 0)
                    if (lado1 == lado2 && lado2 == lado3)
                        Console.WriteLine("DATOS CORRECTOS, Tipo de triángulo: Equilatero");
                    else if (lado1 == lado2 || lado2 == lado3 || lado3 == lado1)
                        Console.WriteLine("DATOS CORRECTOS, Tipo de triángulo: Isósceles");
                    else Console.WriteLine("DATOS CORRECTOS, Tipo de triángulo: Escaleno");
                else Console.WriteLine("DATOS INCORRECTOS");

                Console.WriteLine("Desea volver a ejecutar el programa[si/no]: ");
                opc = Console.ReadLine();
            } while (opc == "SI" || opc == "si");
            Console.ReadKey();
        }
    }
}
