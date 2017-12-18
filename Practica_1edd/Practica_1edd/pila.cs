using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_1edd
{
    public class pila
    {
        nodoPila primero;
        nodoPila temp;
       
        public pila()
        {
            primero = null;
        }
        public void push(Matriz_ matriz)
        {
            nodoPila nuevoNodo = new nodoPila(matriz);
            if (primero == null)
            {
                primero = nuevoNodo;
            }
            else
            {
                nuevoNodo.siguiente = primero;
                primero = nuevoNodo;

            }
        }
        public Matriz_ pop()
        {
            nodoPila temp;
            if (primero != null)
            {
                temp = primero;
                primero = primero.siguiente;
                return temp.matriz;
            }
            return null;
        }
        public void show()
        {
            temp = primero;
            string pila = "";
            if (temp == null)
            {
                MessageBox.Show("la pila esta vacia");
            }
            else
            {
                while (temp.siguiente != null)
                {
                    pila += temp.matriz.getValor() + "->";

                    Console.Write(pila + "    ");

                    temp = temp.siguiente;

                }
                pila += temp.matriz.getValor();
            }

            Grafica grafi = new Grafica();
            grafi.textoPila(pila);
            grafi.dibujar("imagenes\\pila.txt", "C:\\");

        }
    }
    public class nodoPila
    {
        public Matriz_ matriz;
        public nodoPila siguiente;
        public nodoPila(Matriz_ dato)
        {
            matriz = dato;
            siguiente = null;

        }


    }
}
