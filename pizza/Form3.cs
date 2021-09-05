using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pizza
{
    public partial class Form3 : Form
    {
        public Cliente c; 
        public Pedido p = new Pedido();
        public Form3(Cliente c)
        {
            InitializeComponent();
            this.c = c;
            
        }
        //- IdPedido: int
        //- Descricao: sring
        //- ValorTotal: double

      private void buttonSalvar_Click(object sender, EventArgs e)
        {
            int id = 0;
            id++;
            p.IdPedido = id;
            p.Descricao = textDescricao.Text;
          
            if (textDescricao.Text == "1")
            {
                textTotal.Text = "R$50,00";
            }

            if (textDescricao.Text == "2")
            {
                textTotal.Text = "R$50,00";
            }
            if (textDescricao.Text == "3")
            {
                textTotal.Text = "R$48,00";
            }

            if (textDescricao.Text == "4")
            {
                textTotal.Text = "R$45,00";
            }

            if (textDescricao.Text == "5")
            {
                textTotal.Text = "R$50,00";
            }

            if (textDescricao.Text == "6")
            {
                textTotal.Text = "R$52,00";
            }
            p.ValorTotal = textTotal.Text;


        }

        private void buttonInformacao_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(c, p);
            form2.Show();
            this.Hide();

        }
    }
}
