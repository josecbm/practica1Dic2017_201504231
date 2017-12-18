using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_1edd
{
    public partial class Img : Form
    {
        
        public Img(String tipo)
        {
            InitializeComponent();
            if (tipo.Equals("pila"))
            {
                pictureBox1.Image = Image.FromFile(@"C:\imagenes\pila.jpg");
            }
            if (tipo.Equals("cola"))
            {
                pictureBox1.Image = Image.FromFile(@"C:\imagenes\cola.jpg");
            }
            if (tipo.Equals("usuario"))
            {
                pictureBox1.Image = Image.FromFile(@"C:\imagenes\lista.jpg");
            }
        }
        
    }
}
