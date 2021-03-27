using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Mario_verdeL_App
{
    public partial class Form1 : Form
    {
        Thread Inicio;     

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "thiago")
            {
                MessageBox.Show("seja bem vindo");
            }
            else
            {
                MessageBox.Show("erro");
            }

            //chama a tela principal
            this.Close();
            Inicio = new Thread(abrirJanela);
            Inicio.SetApartmentState(ApartmentState.STA);
            Inicio.Start();
        }  

        private void abrirJanela(object obj)
        {
            Application.Run(new tela_principal());
        }
    }
}
