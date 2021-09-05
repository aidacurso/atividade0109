using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pizza
{
    public partial class Form2 : Form
    {
        public Form2(Cliente c, Pedido p)
        {
            InitializeComponent();
            dataInformacoes.Rows.Add(new object[] {c.IdCliente, c.NomeCliente, c.TelefoneCliente});
            dataPedido.Rows.Add(new object[] { p.IdPedido, p.Descricao, p.ValorTotal });

        }

       
    }
}
