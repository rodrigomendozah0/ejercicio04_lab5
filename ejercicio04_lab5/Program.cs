using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio04_lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int limite;
            int opcion;
            float factorial = 1;
            Console.Write("Ingrese el número limite: ");
            limite = int.Parse(Console.ReadLine());
            Console.WriteLine("Escoga una opción: ");
            Console.WriteLine("1: Números pares");
            Console.WriteLine("2: Números impares");
            Console.WriteLine("3: Factorial");
            opcion = int.Parse(Console.ReadLine());
            
            switch (opcion)
            {
                case 1:
                    for (int i = 1; i <= limite; i++)
                    {
                        if (i % 2 == 0)
                        {
                            Console.Write(i + ", ");
                        }
                    }
                    break;
                case 2:
                    for (int i = 1; i <= limite; i++)
                    {
                        if (i % 2 != 0)
                        {
                            Console.Write(i + ", ");
                        }
                    }
                    break;
                case 3:
                    for (int i = 1; i <= limite; i++)
                    {
                        factorial = factorial * i;
                    }
                    Console.Write("El factorial es: " + factorial);
                    break;
            }
            Console.ReadKey();
        }
    }
}
