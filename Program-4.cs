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
                int calif;
                Console.Clear();
                Console.WriteLine("        Problemática: Calificación");
                Console.WriteLine("");
                Console.WriteLine("Ingrese su calificación[6-10]: ");
                calif = int.Parse(Console.ReadLine());
                switch (calif)
                {
                    case 6:
                        Console.WriteLine("Calificación reprobatoria, estudia más para la proxima =(");
                        break;
                    case 7:
                        Console.WriteLine("Calificación deficiente, esfuerzate más para la proxima =(");
                        break;
                    case 8:
                        Console.WriteLine("Calificación aprobatoria");
                        break;
                    case 9:
                        Console.WriteLine("Calificación aprobatorio, muy bien, sigue así");
                        break;
                    case 10:
                        Console.WriteLine("Calificación aprobatorio, Excelente, sigue así");
                        break;
                    default:
                        Console.WriteLine("La calificación ingresada no se encuentra dentro del rango");
                        break;
                }

                Console.WriteLine("Desea volver a ejecutar el programa[si/no]: ");
                opc = Console.ReadLine();
            } while (opc == "SI" || opc == "si");
            Console.ReadKey();
        }
    }
}