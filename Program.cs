using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto__Pila_ElBueno
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int max = 0;
            Pila nuevaPila = new Pila(max);
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
                    Console.WriteLine("Ingresa el tamaño:");
                    int tamaño = int.Parse(Console.ReadLine());
                    max = tamaño;
                }
                else if (opc == 2)
                {
                    Console.WriteLine("Ingresa el valor a agregar: ");
                    int nuevoValor = int.Parse(Console.ReadLine());
                    Console.WriteLine(nuevaPila.Push(nuevoValor));
                }
                else if (opc == 3)
                {

                }
                else if (opc == 4)
                {
                    Console.WriteLine("Elementos de la pila: ");
                    nuevaPila.PrintStack();
                }
                else if (opc == 5)
                {

                }

            }

        }
    }
}
