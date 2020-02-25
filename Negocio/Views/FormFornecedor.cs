using Negocio.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Negocio
{
    public partial class FormFornecedor : Form
    {
        public FormFornecedor(Fornecedor fornecedor)
        {
            InitializeComponent();

            mskCnpj.Text = fornecedor.Cnpj;
            txtRazaoSocial.Text = fornecedor.RazaoSocial;
        }

        public FormFornecedor()
        {
            InitializeComponent();
            LimparControles();
        }

        private void FormFornecedor_Load(object sender, EventArgs e)
        {

        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            try
            {
                string _fornecedorCnpj = Convert.ToString(value: mskCnpj.Text);
                var fornecedorCnpj = Fornecedor.BuscarTodos().FirstOrDefault(f => f.Cnpj == _fornecedorCnpj);
                if (fornecedorCnpj == null)
                {
                    Fornecedor fornecedor = new Fornecedor
                    {
                        Cnpj = mskCnpj.Text,
                        RazaoSocial = txtRazaoSocial.Text
                    };
                    fornecedor.Salvar();
                    LimparControles();
                }
                else if (fornecedorCnpj.Cnpj.ToString() == _fornecedorCnpj)
                {
                    MessageBox.Show("Já existe um fornecedor com o CNPJ: " + fornecedorCnpj.Cnpj.ToString());
                    //Fecha o formulario atual
                    Dispose();
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                string _fornecedorCnpj = Convert.ToString(value: mskCnpj.Text);
                Fornecedor fornecedor = Fornecedor.BuscarTodos().FirstOrDefault(f => f.Cnpj == _fornecedorCnpj);
                if (fornecedor == null)
                {
                    MessageBox.Show("Não Existe nenhum Fornecedor com o CNPJ: " + _fornecedorCnpj);
                    //Fecha o formulario atual
                    Dispose();
                    return;
                }
                else if (fornecedor.Cnpj.ToString() == _fornecedorCnpj)
                {
                    fornecedor.Cnpj = mskCnpj.Text;
                    fornecedor.RazaoSocial = txtRazaoSocial.Text;
                    fornecedor.Atualizar(fornecedor);
                    LimparControles();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                string _fornecedorCnpj = Convert.ToString(value: mskCnpj.Text);
                Fornecedor fornecedor = Fornecedor.BuscarTodos().FirstOrDefault(f => f.Cnpj == _fornecedorCnpj);
                if (fornecedor == null)
                {
                    MessageBox.Show("Não Existe nenhum Fornecedor com o CNPJ: " + _fornecedorCnpj);
                    //Fecha o formulario atual
                    Dispose();
                    return;
                }
                else if (fornecedor.Cnpj.ToString() == _fornecedorCnpj)
                {
                    if (MessageBox.Show("Ao excluir um registro, \ntodos os registros associados a ele serão excluidos! \n" +
                        "Tem certeza que deseja excluir?", "Exclusão", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        fornecedor.Deletar(fornecedor.FornecedorId);
                        LimparControles();

                        //Rotina para exclusão
                        MessageBox.Show("Registro excluído com sucesso", "Sucesso");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LimparControles()
        {
            mskCnpj.Clear();
            txtRazaoSocial.Clear();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparControles();
        }
    }
}
