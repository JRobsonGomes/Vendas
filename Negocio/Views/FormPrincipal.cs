using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Negocio.Views
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Abre um novo formulario
            FormCadastro formCadastro = new FormCadastro();
            formCadastro.ShowDialog();
        }

        private void pedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Abre um novo formulario
            FormPedido formPedido = new FormPedido();
            formPedido.ShowDialog();
        }

        private void sairSubMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fornecedorSubMenuItem_Click(object sender, EventArgs e)
        {
            //Abre um novo formulario
            FormFornecedor formFornecedor = new FormFornecedor();
            formFornecedor.ShowDialog();
        }
    }
}
