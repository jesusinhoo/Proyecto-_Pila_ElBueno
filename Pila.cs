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

        public void PrintStack()
        {
            //Imprime la lista
            if (Empty())
            {
                Console.WriteLine("La pila esta vacia.");
            }

            Nodo current = Inicio;
            Console.WriteLine("Elementos en la pila:");

            while (current != null)
            {
                Console.WriteLine(current.Valor);
                current = current.Sig;
            }

            Console.ReadKey();
        }

        public bool Push(int num)
        {
            if (this.Full())
            {
                return false;
            }

            Nodo nuevo = new Nodo(num);

            if (Inicio == null)
            {
                Inicio = nuevo;
                Tope++;
            }
            else
            {
                Nodo act = Inicio;
                while (act.Sig != null)
                    act = act.Sig;
                act.Sig = nuevo;

            }
            return false;

        }
        public void Pop()
        {
            //Regresa el número sacado de la pila
            //Si la pila está vacía regresa -1

        }
    }
}

