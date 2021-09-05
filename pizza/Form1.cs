using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pizza
{
    public partial class Form1 : Form
    {
        /*Criar um sistema de uma pizzaria, utilizando Form, classes e métodos
        O sistema deve ser capaz de cadastrar, atualizar e excluir, cliente e
        pedidos (Pode usar um cardápio fixo) e mostrar total a pagar.
        Obs. Como ainda não trabalhamos com banco de dados, vocês devem pesquisar
        DataGridView (segue um vídeo para inspiração....rs (https://youtu.be/-1CmD1DFacM) ).
        A entrega deve ser via portal, vocês devem subir o projeto para o git,
        me convidar para o projeto, e depois postar a url do projeto na área
        de entrega do projeto. Obs. Caso você ache que precisa de mais atributos 
        (propriedade das classes) fique a vontade para inserir novos atributos.
        */
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonContinuar_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente();
            int id = 0;
            id++;
            c.TelefoneCliente = id.ToString();
            c.NomeCliente = (textBoxNomeCliente.Text);
            c.TelefoneCliente = (textBoxTelefoneCliente.Text);
            
            
            Form3 form3 = new Form3(c);
            form3.Show();
            this.Hide();

        }
    }
}
