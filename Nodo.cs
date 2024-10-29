using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto__Pila_ElBueno
{
    internal class Nodo
    {
        private int valor;
        private Nodo sig;

        public int Valor { get => valor; set => Valor = value; }
        internal Nodo Sig { get => sig; set => sig = value; }

        public Nodo(int valor)
        {
            Valor = valor;
            Sig = null;
        }
    }
}
