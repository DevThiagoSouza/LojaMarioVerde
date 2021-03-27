using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Mario_verdeL_App
{
    public partial class CarinhoControl : UserControl
    {
        public class Produtos
        {
            public string Nome;
            public double Preco;


            public Produtos(string nome, double preco)
            {
                Nome = nome;
                Preco = preco;
            }

            public override bool Equals(object obj)      //vai comparar os valores se nao esta com o mesmo nome
            {
                Produtos outro = (Produtos)obj;
                bool MesmoNome = Nome == outro.Nome;
                bool MesmoPreco = Preco == outro.Preco;
                return MesmoNome && MesmoPreco;
            }

            public override int GetHashCode()    //vai agrupara um con jumto de dados como um banco de dados e vai filtrar os dados
            {
                return Nome.Length;
            }

        }

        public CarinhoControl()
        {
            InitializeComponent();
        }

        private void CarinhoControl_Load(object sender, EventArgs e)
        {
            var games = new Produtos("promocao ", 150.00);

            var carrinho = new List<Produtos>();
            carrinho.Add(games);


            var combo = new List<Produtos>()
            {
                new Produtos("controle" , 150.00),
                new Produtos("xboxCombo" , 150.00)
            };

            carrinho.AddRange(combo);   //vai adicionar o combo do xbox no carinho

            foreach(Produtos produto in carrinho)
            {
               
            }
        }
    }
}
