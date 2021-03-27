using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Mario_verdeL_App
{
    public partial class tela_principal : Form
    {
        class Produtos
        {
            public string Nome;
            public double Preco;
        }

        List<Produtos> ListaProdutos;
        List<Produtos> ListaCompras;

        public tela_principal()
        {
            InitializeComponent();
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button3.Height;
            SidePanel.Top = button3.Top;
            carinhoControl1.BringToFront();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button5.Height;
            SidePanel.Top = button5.Top;
            suporteControl1.BringToFront();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            button1_Click(null, e);
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
           
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            telaInicialControl11.BringToFront();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;
            ofertaControl1.BringToFront();
           
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)      //Link Facebook
        {
            System.Diagnostics.Process.Start("https://facebook.com/");
        }
           

        private void button8_Click(object sender, EventArgs e)            //Link Intagram
        {
            System.Diagnostics.Process.Start("chrome", "https://pt-br.facebook.com/");
        }

        private void button9_Click(object sender, EventArgs e)             //Link Gmail
        {
            System.Diagnostics.Process.Start("chrome", "http://www.gmail.com");
        }


            private void button4_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button4.Height;
            SidePanel.Top = button4.Top;
            homeControl11.BringToFront();
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button6.Height;
            SidePanel.Top = button6.Top;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Hora.Text = DateTime.Now.ToShortTimeString();
            Data.Text = DateTime.Now.ToLongDateString();
        }

        private void tela_principal_Load(object sender, EventArgs e)
        {
            
        }

        private void telaInicialControl11_Load(object sender, EventArgs e)
        {
            telaInicialControl11.BringToFront();
        }


        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
    
}
    
    

