using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MATERIAS_POR_DIA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dia;

            Console.WriteLine("Lista de materias por dia" + "\nL:Lunes \nM:Martes \nT:Miercoles \nJ:Jueves \nV:Viernes");
            Console.WriteLine("Ingrese el dia\n:");
            dia = Convert.ToChar(Console.ReadLine());
            switch (dia)
            {
                case 'L':
                case 'l':
                    Console.WriteLine("LUNES:");
                    Console.WriteLine("Fundamentos de TI");
                    Console.WriteLine("Tutoria");
                    Console.WriteLine("Exprecion Oral y Escrita 1");
                    Console.WriteLine("Ingles 1");
                    break;

                case 'M':
                case 'm':
                    Console.WriteLine("MARTES:");
                    Console.WriteLine("Ingles 1");
                    Console.WriteLine("Formacion Sociocultural 1");
                    Console.WriteLine("Metodoligia de la informacion");
                    Console.WriteLine("Fundamentos de Redes 1");
                    break;

                case 'T':
                case 't':
                    Console.WriteLine("MIERCOLES:");
                    Console.WriteLine("Fundamentos de TI");
                    Console.WriteLine("Agebra Lineal");
                    Console.WriteLine("DHP Logico");
                    break;

                case 'J':
                case 'j':
                    Console.WriteLine("JUEVES:");
                    Console.WriteLine("Algebra Lineal");
                    Console.WriteLine("Metodologia de la Programacion");
                    Console.WriteLine("Fundamento de Redes");
                    break;

                case 'V':
                case 'v':
                    Console.WriteLine("VIERNES:");
                    Console.WriteLine("Fundamento de Redes");
                    Console.WriteLine("DHP Logico");
                    Console.WriteLine("Algebra Lineal");
                    Console.WriteLine("Fundamentos de TI");
                    break;
                default:
                    Console.WriteLine("NO EXISTE EL DIA NI LAS MATERIAS");
                    break;
            }
            Console.ReadKey();
        }
    }
}