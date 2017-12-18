using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1edd
{
    class Grafica
    {
        public void textoPila(string inicio)
        {
            System.IO.StreamWriter ruta = new System.IO.StreamWriter("C:\\imagenes\\pila.txt", false);
            ruta.Write("digraph lista{ rankdir=TB;node[shape = box, style = filled, color = gray]; ");
            ruta.Write(inicio);
            ruta.Write("}");
            ruta.Close();
        }
        public void textoCola(string inicio)
        {
            System.IO.StreamWriter ruta = new System.IO.StreamWriter("C:\\imagenes\\cola.txt", false);
            ruta.Write("digraph lista{ rankdir=LR;node[shape = box, style = filled, color = gray]; ");
            ruta.Write(inicio);
            ruta.Write("}");
            ruta.Close();
        }
        public void textoLista(string inicio)
        {
            System.IO.StreamWriter ruta = new System.IO.StreamWriter("C:\\imagenes\\lista.txt", false);
            ruta.Write("digraph lista{ rankdir=LR;node[shape = box, style = filled, color = gray]; ");
            ruta.Write(inicio);
            ruta.Write("}");
            ruta.Close();
        }
        public void dibujarcola(string archivo, string path)
        {
            try
            {
                var comando = string.Format("dot.exe -Tjpg {0} -o {1}", Path.Combine(path, archivo), Path.Combine(path, archivo.Replace(".txt", ".jpg")));
                var procesarInfo = new System.Diagnostics.ProcessStartInfo("cmd", "/C " + comando);
                procesarInfo.UseShellExecute = false;
                var procesar = new System.Diagnostics.Process();

                procesar.StartInfo = procesarInfo;
                procesar.Start();
                procesar.WaitForExit();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.InnerException);
            }
        }
        public void dibujarLista(string archivo, string path)
        {
            try
            {
                var comando = string.Format("dot.exe -Tjpg {0} -o {1}", Path.Combine(path, archivo), Path.Combine(path, archivo.Replace(".txt", ".jpg")));
                var procesarInfo = new System.Diagnostics.ProcessStartInfo("cmd", "/C " + comando);
                procesarInfo.UseShellExecute = false;
                var procesar = new System.Diagnostics.Process();

                procesar.StartInfo = procesarInfo;
                procesar.Start();
                procesar.WaitForExit();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.InnerException);
            }
        }
        public void dibujar(string archivo, string path)
        {
            try
            {
                var comando = string.Format("dot.exe -Tjpg {0} -o {1}", Path.Combine(path, archivo), Path.Combine(path, archivo.Replace(".txt", ".jpg")));
                var procesarInfo = new System.Diagnostics.ProcessStartInfo("cmd", "/C " + comando);
                procesarInfo.UseShellExecute = false;
                var procesar = new System.Diagnostics.Process();

                procesar.StartInfo = procesarInfo;
                procesar.Start();
                procesar.WaitForExit();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.InnerException);
            }
        }
    }
}
