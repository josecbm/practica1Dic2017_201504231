using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Practica_1edd
{
    public partial class Form1 : Form
    {
        lista_dob_enlazada lista = new lista_dob_enlazada();
        nodolista nodoUsuario;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lista.agregar(textBox1.Text, textBox2.Text);
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (lista.login(textBox1.Text, textBox2.Text)!=null)
            {
                nodoUsuario = lista.login(textBox1.Text, textBox2.Text);

                MessageBox.Show("Existe usuario");
                button3.Visible= true;
                button2.Visible = true;
                richTextBox1.Visible = true;
                btnAceptarJSON.Visible = true;
                menuStrip1.Visible = true;
            }
            else { MessageBox.Show("No existe usuario"); }
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "JSON Files|*.json";
            openFileDialog1.Title = "Select a Cursor File json";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamReader sr = new
                   System.IO.StreamReader(openFileDialog1.FileName);
                richTextBox1.Text = sr.ReadToEnd();
                sr.Close();
            }
        }

        private void btnAceptarJSON_Click(object sender, EventArgs e)
        {
            archivoJson atjson = new archivoJson();
            archivoJson output = JsonConvert.DeserializeObject<archivoJson>(richTextBox1.Text.ToString());
            foreach(Matriz x in output.archivo.pila.matrices.matriz){
                Console.WriteLine("matriz pila");
                Console.WriteLine("tamano x " + x.size_x);
                Console.WriteLine("tamano y " + x.size_y);
                Matriz_ matrizNueva = new Matriz_();
                matrizNueva.crearMatriz(Convert.ToInt32(x.size_x), Convert.ToInt32(x.size_y));
                
               foreach(Valor val in x.valores.valor)
                {
                    matrizNueva.asignar(Convert.ToInt32(val.pos_x), Convert.ToInt32(val.pos_y), Convert.ToInt32(val.dato));
                   
                    Console.WriteLine("dato a guardar en pila");
                    Console.WriteLine("coordenada x " + val.pos_x);
                    Console.WriteLine("coordenada y " + val.pos_y);
                    Console.WriteLine("coordenada dato " + val.dato);
                }
                nodoUsuario.getPila().push(matrizNueva);
            }
            foreach(Matriz1 y in output.archivo.cola.matrices.matriz)
            {
                Matriz_ matrizNueva = new Matriz_();
                matrizNueva.crearMatriz(Convert.ToInt32(y.size_x), Convert.ToInt32(y.size_y));
                Console.WriteLine("matriz cola");
                Console.WriteLine("tamano en x "+y.size_x);
                Console.WriteLine("tamano en y " + y.size_y);
               
                foreach (Valor1 val2 in y.valores.valor)
                {
                    matrizNueva.asignar(Convert.ToInt32(val2.pos_x), Convert.ToInt32(val2.pos_y), Convert.ToInt32(val2.dato));
                    Console.WriteLine("dato a guardar en cola");
                    Console.WriteLine("coordenada x " + val2.pos_x);
                    Console.WriteLine("coordenada x " + val2.pos_y);
                    Console.WriteLine("dato " + val2.dato);
                   
                }
                nodoUsuario.getCola().encolar(matrizNueva);

            }
            
        }
        public void operarMatrices()
        {

            Matriz_ matrizResultante = new Matriz_();
            Matriz_ matCola = nodoUsuario.getCola().desencolar();
            Matriz_ matPila = nodoUsuario.getPila().pop();
            int valorOperado;
           
            if (matPila.getX() == matCola.getX() && matPila.getY() == matCola.getY())
            {
                matrizResultante.crearMatriz(matCola.getX(), matPila.getY());
                for(int y =0; y < matPila.getY(); y++)
                {
                    for(int x = 0; x < matCola.getX(); x++)
                    {
                        valorOperado = matCola.getValor(x,y)*matPila.getValor(y,x);
                        matrizResultante.asignar(x, y, valorOperado);
                    }
                }
            }
            matrizResultante.grafica("matrizResultante");

           
        }

        private void graficarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Img i = new Img("usuario");
            i.Show();
        }

        private void graficarMatrizToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Img i = new Img("matriz");
            i.Show();
        }

        private void graficarPilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Img i = new Img("pila");
            
            i.Show();
           
            
        }

        private void graficarColaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Img i = new Img("cola");
            i.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void eliminarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void operarMatricesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            operarMatrices();
        }

        private void renderGraficaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nodoUsuario.getPila().show();
            nodoUsuario.getCola().mostrar();
            lista.recorrerUsuarios();
        }
    }
    [Serializable]
    public class archivoJson
    {
        public Archivo archivo { get; set; }
    }

    public class Archivo
    {
        public Pila pila { get; set; }
        public Cola cola { get; set; }
    }

    public class Pila
    {
        public Matrices matrices { get; set; }
    }

    public class Matrices
    {
        public Matriz[] matriz { get; set; }
    }

    public class Matriz
    {
        public string size_x { get; set; }
        public string size_y { get; set; }
        public Valores valores { get; set; }
    }

    public class Valores
    {
        public Valor[] valor { get; set; }
    }

    public class Valor
    {
        public string pos_x { get; set; }
        public string pos_y { get; set; }
        public string dato { get; set; }
    }

    public class Cola
    {
        public Matrices1 matrices { get; set; }
    }

    public class Matrices1
    {
        public Matriz1[] matriz { get; set; }
    }

    public class Matriz1
    {
        public string size_x { get; set; }
        public string size_y { get; set; }
        public Valores1 valores { get; set; }
    }

    public class Valores1
    {
        public Valor1[] valor { get; set; }
    }

    public class Valor1
    {
        public string pos_x { get; set; }
        public string pos_y { get; set; }
        public string dato { get; set; }
    }


}
