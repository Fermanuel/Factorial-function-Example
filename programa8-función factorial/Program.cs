using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace programa8_función_factorial
{
    internal class Program
    {
        public class factorial
        {
            public long calcularFuncion(int n)
            {
                if (n == 1)
                {
                    return 1;
                }
                else
                {
                    return n * calcularFuncion(n - 1);
                }                   
            }
        }
        static void Main(string[] args)
        {
            Console.Title = "programa8 - Función Factorial";
            int op=0;

            factorial f = new factorial();
            Stopwatch sw = new Stopwatch(); 
            GC.Collect();
            do
            {
                Console.Clear();
                Console.WriteLine("MENU FACTORIAL");
                Console.WriteLine("\n1.- Calcular Función.");
                Console.WriteLine("2.- Salir del Programa.");
                Console.Write("\nOPCION: ");

                try
                {
                    op = int.Parse(Console.ReadLine());

                    switch (op)
                    {
                        case 1:

                            Console.Clear();
                            Console.WriteLine("MEMMORIA USADA: {0:N0}",GC.GetTotalMemory(false));
                            Console.Write("\nIngrese Numero: ");

                            int a = int.Parse(Console.ReadLine());

                            Console.WriteLine("\nSu factorial es: {0}", f.calcularFuncion(a));
                            Console.ReadKey();

                            break;
                            case 2:

                            sw.Start();
                            Console.WriteLine("\nPresione <ENTER> para Salir...");
                            Console.WriteLine("\nTIEMPO: {0}ms",sw.ElapsedMilliseconds);
                            Console.WriteLine("\nMEMORIA QUE SE USO: {0:N0}",GC.GetTotalMemory(true));
                            sw.Stop();
                            Console.ReadKey();
                            
                            break;
                        default:
                            Console.WriteLine("\nOPCION INVALIDAD");
                            Console.ReadKey();
                            break;
                    }
                }
                catch (FormatException a)
                {
                    Console.WriteLine("\nERROR {0}", a.Message);
                    Console.ReadKey();
                }

            } while (op!=2);
            
        }
    }
}
