namespace Practica_1edd
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLogin = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnAceptarJSON = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.graficasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graficarUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graficarMatrizToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graficarPilaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graficarColaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operarMatricesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renderGraficaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(49, 295);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(207, 129);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(297, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 129);
            this.button1.TabIndex = 1;
            this.button1.Text = "New user";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(185, 112);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(337, 38);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(185, 191);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '?';
            this.textBox2.Size = new System.Drawing.Size(337, 38);
            this.textBox2.TabIndex = 3;
            this.textBox2.UseSystemPasswordChar = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1500, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(336, 120);
            this.button2.TabIndex = 4;
            this.button2.Text = "Reporte";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1056, 30);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(336, 120);
            this.button3.TabIndex = 5;
            this.button3.Text = "Cargar archivo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "password";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(800, 208);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(953, 456);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            this.richTextBox1.Visible = false;
            // 
            // btnAceptarJSON
            // 
            this.btnAceptarJSON.Location = new System.Drawing.Point(1117, 697);
            this.btnAceptarJSON.Name = "btnAceptarJSON";
            this.btnAceptarJSON.Size = new System.Drawing.Size(275, 76);
            this.btnAceptarJSON.TabIndex = 9;
            this.btnAceptarJSON.Text = "Cargar datos";
            this.btnAceptarJSON.UseVisualStyleBackColor = true;
            this.btnAceptarJSON.Visible = false;
            this.btnAceptarJSON.Click += new System.EventHandler(this.btnAceptarJSON_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.graficasToolStripMenuItem,
            this.eliminarUsuarioToolStripMenuItem,
            this.operarMatricesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1868, 52);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // graficasToolStripMenuItem
            // 
            this.graficasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.graficarUsuariosToolStripMenuItem,
            this.graficarMatrizToolStripMenuItem,
            this.graficarPilaToolStripMenuItem,
            this.graficarColaToolStripMenuItem});
            this.graficasToolStripMenuItem.Name = "graficasToolStripMenuItem";
            this.graficasToolStripMenuItem.Size = new System.Drawing.Size(134, 48);
            this.graficasToolStripMenuItem.Text = "Graficas";
            // 
            // graficarUsuariosToolStripMenuItem
            // 
            this.graficarUsuariosToolStripMenuItem.Name = "graficarUsuariosToolStripMenuItem";
            this.graficarUsuariosToolStripMenuItem.Size = new System.Drawing.Size(355, 46);
            this.graficarUsuariosToolStripMenuItem.Text = "Graficar Usuarios";
            this.graficarUsuariosToolStripMenuItem.Click += new System.EventHandler(this.graficarUsuariosToolStripMenuItem_Click);
            // 
            // graficarMatrizToolStripMenuItem
            // 
            this.graficarMatrizToolStripMenuItem.Name = "graficarMatrizToolStripMenuItem";
            this.graficarMatrizToolStripMenuItem.Size = new System.Drawing.Size(355, 46);
            this.graficarMatrizToolStripMenuItem.Text = "Graficar matriz";
            this.graficarMatrizToolStripMenuItem.Click += new System.EventHandler(this.graficarMatrizToolStripMenuItem_Click);
            // 
            // graficarPilaToolStripMenuItem
            // 
            this.graficarPilaToolStripMenuItem.Name = "graficarPilaToolStripMenuItem";
            this.graficarPilaToolStripMenuItem.Size = new System.Drawing.Size(355, 46);
            this.graficarPilaToolStripMenuItem.Text = "Graficar pila";
            this.graficarPilaToolStripMenuItem.Click += new System.EventHandler(this.graficarPilaToolStripMenuItem_Click);
            // 
            // graficarColaToolStripMenuItem
            // 
            this.graficarColaToolStripMenuItem.Name = "graficarColaToolStripMenuItem";
            this.graficarColaToolStripMenuItem.Size = new System.Drawing.Size(355, 46);
            this.graficarColaToolStripMenuItem.Text = "Graficar Cola";
            this.graficarColaToolStripMenuItem.Click += new System.EventHandler(this.graficarColaToolStripMenuItem_Click);
            // 
            // eliminarUsuarioToolStripMenuItem
            // 
            this.eliminarUsuarioToolStripMenuItem.Name = "eliminarUsuarioToolStripMenuItem";
            this.eliminarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(243, 48);
            this.eliminarUsuarioToolStripMenuItem.Text = "Eliminar Usuario";
            this.eliminarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.eliminarUsuarioToolStripMenuItem_Click);
            // 
            // operarMatricesToolStripMenuItem
            // 
            this.operarMatricesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.renderGraficaToolStripMenuItem});
            this.operarMatricesToolStripMenuItem.Name = "operarMatricesToolStripMenuItem";
            this.operarMatricesToolStripMenuItem.Size = new System.Drawing.Size(236, 48);
            this.operarMatricesToolStripMenuItem.Text = "operar matrices";
            this.operarMatricesToolStripMenuItem.Click += new System.EventHandler(this.operarMatricesToolStripMenuItem_Click);
            // 
            // renderGraficaToolStripMenuItem
            // 
            this.renderGraficaToolStripMenuItem.Name = "renderGraficaToolStripMenuItem";
            this.renderGraficaToolStripMenuItem.Size = new System.Drawing.Size(326, 46);
            this.renderGraficaToolStripMenuItem.Text = "Render grafica";
            this.renderGraficaToolStripMenuItem.Click += new System.EventHandler(this.renderGraficaToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1868, 785);
            this.Controls.Add(this.btnAceptarJSON);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button button3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnAceptarJSON;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem graficasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graficarUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graficarMatrizToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graficarPilaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graficarColaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarUsuarioToolStripMenuItem;
        public System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ToolStripMenuItem operarMatricesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renderGraficaToolStripMenuItem;
    }
}

