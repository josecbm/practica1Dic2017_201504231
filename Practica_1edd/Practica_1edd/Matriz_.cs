using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_1edd
{
    public class Matriz_
    {
        nodoMatriz raiz = new nodoMatriz(0, 0, 0);
        int x, y;
        String dot;
        public Matriz_ crearMatriz(int tamX, int tamY)
        {
            int contadorX = 1, contadorY = 0;
            x = tamX;
            y = tamY;
            nodoMatriz nodoAux = raiz;
            nodoMatriz tempAuxX = raiz;
            nodoMatriz auxiliar = raiz;
            while (contadorY < tamY)
            {
                while (contadorX < tamX)
                {
                    nodoMatriz nuevoNodo = new nodoMatriz(0, contadorX, contadorY);
                    tempAuxX.right = nuevoNodo;
                    nuevoNodo.left = tempAuxX;
                    tempAuxX = nuevoNodo;
                    if (contadorY > 0)
                    {
                        auxiliar = auxiliar.right;
                        nuevoNodo.up = auxiliar;
                        auxiliar.down = nuevoNodo;
                    }
                  //  MessageBox.Show("Insertando X: " + Convert.ToString(contadorX) + ", Y: " + Convert.ToString(contadorY));
                    contadorX++;
                }

                if ((contadorY + 1) != tamY)
                {
                    contadorX = 0;
                    contadorY++;
                    auxiliar = nodoAux;
                    nodoMatriz nuevoY = new nodoMatriz(0, contadorX, contadorY);
                    nodoAux.down = nuevoY;
                    nuevoY.up = nodoAux;
                    nodoAux = nuevoY;
                    tempAuxX = nodoAux;
                  //  MessageBox.Show("Insertando X: " + Convert.ToString(contadorX) + ", Y: " + Convert.ToString(contadorY));
                    contadorX = 1;
                }
                else
                {
                    contadorY++;
                }
            }
            return this;
        }
        public int getX()
        {
            return x;
        }
        public int getY()
        {
            return y;
        }
        public int getValor()
        {
            nodoMatriz auxX = raiz;
            nodoMatriz auxY = raiz;
            int valor = 0;
            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    valor = valor + auxX.numero;
                    auxX = auxX.right;
                }
                auxY = auxY.down;
                auxX = auxY;
            }
            return valor;
        }
        
        public nodoMatriz buscar(int fila, int columna)
        {
            nodoMatriz auxX = raiz;
            nodoMatriz auxY = raiz;

            
            for (int i = 0; i < fila; i++)
            {
                for (int j = 0; j < columna; j++)
                {
                    
                    auxX = auxX.right;
                    auxY = auxX;
                }
                auxY = auxY.down;
            }


            return auxY;
        }
        public void asignar(int x , int y , int dato)
        {

            nodoMatriz aux = raiz;
            int contx = 0;
            int conty = 0;
            while(conty < y)
            {
                while (contx < x)
                {
                    aux = aux.right;
                    contx++;
                }
                aux = aux.down;
                conty++;
            }
            aux.numero = dato;
           
        }
        public int getValor(int fila, int columna)
        {
            nodoMatriz cabeza = raiz;
            while (cabeza.up != null)
            {
                cabeza = cabeza.up;
            }
            for (int i = 0; i < fila; i++)
            {
                cabeza = cabeza.down;
            }

            for (int i = 0; i < columna; i++)
            {
                cabeza = cabeza.right;
            }
            return cabeza.numero;
        }
        public void grafica(String nombreArchivo)
        {
            dot = "digraph lista{ \n";
            dot += "rankdir = TB; \n";
            dot += "node [shape = record];\n";
            dot += "Matriz[shape = record,label=\"{";
            for (int i = 0; i < x - 1; i++)
            {
                dot += "{";
                for (int j = 0; j < x - 1; j++)
                {
                    dot += "{" + getValor(i, j) + "}|";
                }
                dot += "{" + getValor(i, x - 1) + "}";
                dot += "}|";
            }
            dot += "{";
            for (int j = 0; j < x - 1; j++)
            {
                dot += "{" + getValor(y - 1, j) + "}|";
            }
            dot += "{" + getValor(x - 1, y - 1) + "}";
            dot += "}";
            dot += "}\"]; \n";
            dot += "}";
            StreamWriter fichero = null;
            try
            {
                fichero = new StreamWriter(nombreArchivo + ".dot");
                fichero.Write(dot);
            }
            catch (Exception e) { }
            finally
            {
                try
                {
                    if (null != fichero)
                        fichero.Close();
                }
                catch (Exception e2) { }
            }
            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo(@"C:\Program Files (x86)\Graphviz2.38\bin\dot.exe");
                startInfo.Arguments = "-Tpng  " + nombreArchivo + ".dot  -o  " + nombreArchivo + ".png ";
                Process.Start(startInfo);
                Thread.Sleep(1000);
                Process.Start(nombreArchivo + ".png ");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en generar archivo dot " + ex.ToString());
            }
        }

    }
        public class nodoMatriz
        {
            public int numero, x, y;
            public nodoMatriz up, down, left, right;

            public nodoMatriz(int dato, int posX, int posY)
            {
                numero = dato;
                x = posX;
                y = posY;
            }

            public int getDato()
            {
                return numero;
            }

            public int getX()
            {
                return x;
            }

            public int getY()
            {
                return y;
            }
        }
    }
