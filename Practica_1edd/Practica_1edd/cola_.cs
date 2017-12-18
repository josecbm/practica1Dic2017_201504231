using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_1edd
{
    class cola_
    {
        nodoCola primero;
        nodoCola nodoAux;

        public cola_()
        {
            primero = null;
        }
        public void encolar(Matriz_ matriz)
        {
            nodoCola nuevo = new nodoCola(matriz);
            if (primero == null)
            {

                primero = nuevo;
            }
            else
            {
                nodoAux = primero;
                while (nodoAux.siguiente != null)
                {
                    nodoAux = nodoAux.siguiente;
                }
                nodoAux.siguiente = nuevo;
            }
        }
        public Matriz_ desencolar()
        {
            nodoAux = primero;

            if (nodoAux == null)
            {
                primero = primero.siguiente;
                return nodoAux.matriz_;
            }
            else
            {
                Console.WriteLine("la cola esta vacia");
            }
            return null;
        }
        public void mostrar()
        {
            nodoAux = primero;
            string col = "";
            if (nodoAux == null)
            {
                MessageBox.Show("la cola esta vacia");
            }
            else
            {
                while (nodoAux.siguiente != null)
                {
                    col += nodoAux.matriz_.getValor() + "->";
                    Console.Write(col + "   ");


                    nodoAux = nodoAux.siguiente;

                }
                col += nodoAux.matriz_.getValor();
            }
            Grafica grafi = new Grafica();
            grafi.textoCola(col);
            grafi.dibujarcola("imagenes\\cola.txt", "C:\\");

        }
        public class nodoCola
        {
            public nodoCola siguiente;
            public Matriz_ matriz_;

            public nodoCola(Matriz_ valor)
            {
                siguiente = null;
                matriz_ = valor;
            }
        }
    }
}
