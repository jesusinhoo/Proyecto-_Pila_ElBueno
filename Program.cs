using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto__Pila_ElBueno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pila nuevaPila = null;
            int wh = 5;

            while (wh == 5)
            {
                Console.Clear();
                Console.WriteLine("________________________");
                Console.WriteLine("|      MENU PILAS      |");
                Console.WriteLine("------------------------");
                Console.WriteLine("|1.- Establecer tamaño |");
                Console.WriteLine("|2.- Push.             |");
                Console.WriteLine("|3.- Pop.              |");
                Console.WriteLine("|4.- Imprimir.         |");
                Console.WriteLine("|5.- Salir.            |");
                Console.WriteLine("------------------------");
                Console.WriteLine("|Elige una opcion:     |");
                int opc = int.Parse(Console.ReadLine());
                Console.WriteLine("|----------------------|");

                if (opc == 1)
                {
                    Console.Clear();
                    if (nuevaPila == null)
                    {
                        Console.WriteLine("Ingresa el tamaño:");
                        int tamaño = int.Parse(Console.ReadLine());
                        nuevaPila = new Pila(tamaño);
                    }
                    else
                    {
                        Console.WriteLine("Tamaño de la pila ya establecido.");
                    }
                    Console.ReadKey();
                }
                else if (opc == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Ingresa el valor a agregar: ");
                    int nuevoValor = int.Parse(Console.ReadLine());
                    nuevaPila.Push(nuevoValor);
                }
                else if (opc == 3)
                {
                    Console.Clear();
                    nuevaPila.Pop();
                    Console.ReadKey();
                }
                else if (opc == 4)
                {
                    Console.Clear();
                    nuevaPila.Print();
                    Console.ReadKey();
                }
                else if (opc == 5)
                {
                    Console.Clear();
                    Console.WriteLine("Saliendo...");
                    Console.WriteLine("Presiona enter...");
                    wh = 0;
                    Console.ReadKey();
                }

            }

        }
    }
}
