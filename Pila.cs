using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto__Pila_ElBueno
{
    internal class Pila
    {
        private int Max;
        private int Tope = 0;
        private Nodo Inicio;

        public Pila(int max)
        {
            Max = max;
            Inicio = null;
        }

        public bool Empty()
        {
            if (Inicio == null)
                return true;
            else
                return false;
        }

        public bool Full()
        {
            if (Tope == Max)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool Print()
        {
            //Imprime la lista
            if (Empty())
            {
                Console.WriteLine("La pila esta vacia.");
                return false;
            }

            Nodo current = Inicio;
            Console.WriteLine("Elementos en la pila:");

            while (current != null)
            {
                Console.WriteLine(current.Valor);
                current = current.Sig;
            }

            Console.ReadKey();
            return true;
        }

        public bool Push(int num)
        {
            if (!Full())
            {
                Nodo nuevo = new Nodo(num);
                nuevo.Sig = Inicio;  
                Inicio = nuevo;      
                Tope++;              
                return true;
            }
            else
            {
                Console.WriteLine("La pila esta llena.");
                return false;
            }
        }
        public int Pop()
        {
            if (Empty())
            {
                Console.WriteLine("La pila está vacía.");
                return -1; 
            }

            int valor = Inicio.Valor;
            Inicio = Inicio.Sig; 
            Tope--;              
            return valor;
        }
    }
}

