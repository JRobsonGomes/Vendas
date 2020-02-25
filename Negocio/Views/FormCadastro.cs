using Negocio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Negocio
{
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();

            //DataGridViwer
            dgvDadosProduto.AutoGenerateColumns = false;
        }

        public void Carregar()
        {
            CarregaComboBoxFornecedor();

            // Exibe os dados no carregamento (ESTUDO - não ficou bom)
            /*var produto = from prod in context.Produtos
                          select prod;
            dgvDados.DataSource = produto.ToList();

            // Exibe os dados no carregamento
            var produto = (from prod in context.Produtos
                           join f in context.Fornecedores on prod.FornecedorId equals f.FornecedorId
                           select new
                           {
                               ID = prod.ProdutoId,
                               Descrição = prod.Descricao,
                               prod.Valor,
                               Unidade = prod.UnidadeMedida,
                               Fornecedor = f.RazaoSocial
                           }).ToList();*/

            //Muda exibição das celulas do DataGridView
            dgvDadosProduto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            //Torna visivel as colunas do DataGridView
            dgvDadosProduto.ColumnHeadersVisible = true;

            //Atribui nulo ao DataSource
            dgvDadosProduto.DataSource = null;

            //Atribui ao DataSource os Itens do pedido
            dgvDadosProduto.DataSource = Produto.BuscarTodos();

            //Atualiza o DataGridView
            dgvDadosProduto.Update();

            //Recarrega o DataGridView
            dgvDadosProduto.Refresh();

            /*foreach (DataGridViewColumn column in dgvDados.Columns)
            {
                if (column.DataPropertyName == "ProdutoId")
                {
                    column.Width = 100; //tamanho fixo da primeira coluna
                }

                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }*/

            // Inicializar e adicionar um texto na coluna.
            /*DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "ProdutoId";
            column.Name = "ID";
            dgvDados.Columns.Add(column);*/
        }

        private void CarregaComboBoxFornecedor()
        {
            cboFornecedor.DataSource = null;
            cboFornecedor.ValueMember = "FornecedorId";
            cboFornecedor.DisplayMember = "RazaoSocial";
            cboFornecedor.DataSource = Fornecedor.BuscarTodos();// Exibe os dados de fornecedores no combobox no carregamento
            cboFornecedor.Refresh();
        }

        // Metodo para formatar celulas com propriedade aninhadas
        // Deve ser acompanhado pelo evento CellFormatting
        private string BindProperty(object property, string propertyName)
        {
            try
            {
                string retValue = "";
                if (propertyName.Contains("."))
                {
                    PropertyInfo[] arrayProperties;
                    string leftPropertyName;
                    leftPropertyName = propertyName.Substring(0, propertyName.IndexOf("."));
                    if (property != null)
                    {
                        arrayProperties = property.GetType().GetProperties();
                        foreach (PropertyInfo propertyInfo in arrayProperties)
                        {
                            if (propertyInfo.Name == leftPropertyName)
                            {
                                retValue = BindProperty(
                                  propertyInfo.GetValue(property, null),
                                  propertyName.Substring(propertyName.IndexOf(".") + 1));
                                break;
                            }
                        }
                    }
                }
                else
                {
                    Type propertyType;
                    PropertyInfo propertyInfo;
                    if (property != null)
                    {
                        propertyType = property.GetType();
                        propertyInfo = propertyType.GetProperty(propertyName);
                        retValue = propertyInfo.GetValue(property, null).ToString();
                    }
                }
                return retValue;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        // Chama o metodo para formatar celula com propridedes aninhadas
        private void dgvDadosProduto_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if ((dgvDadosProduto.Rows[e.RowIndex].DataBoundItem != null) && dgvDadosProduto.Columns[e.ColumnIndex].DataPropertyName.Contains("."))
                {
                    e.Value = BindProperty(dgvDadosProduto.Rows[e.RowIndex].DataBoundItem, dgvDadosProduto.Columns[e.ColumnIndex].DataPropertyName);
                }

                //ToolTip
                DataGridViewCell cell = this.dgvDadosProduto.Rows[e.RowIndex].Cells[e.ColumnIndex];
                cell.ToolTipText = "Duplo clique para editar";
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.Message);
            }
        }

        private void BtnIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                // Variavel que busca o valor no ComboBox e converte em inteiro
                int _fornecedorId = Convert.ToInt32(cboFornecedor.SelectedValue);

                Produto produto = new Produto
                {
                    Descricao = txtDescricao.Text,
                    UnidadeMedida = txtUnidade.Text,
                    Valor = Convert.ToDecimal(txtValor.Text),
                    //FornecedorId = Fornecedor.BuscarTodos().First(f => f.FornecedorId == _fornecedorId).FornecedorId //Esse metodo preenche somente o id do fornecedor
                    //Fornecedor = Fornecedor.BuscarTodos().First(f => f.FornecedorId == _fornecedorId) //Esse metodo adiciona um novo fornecedor
                };
                produto.SalvarProduto(_fornecedorId);

                //Carrega os controles novamente
                Carregar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void FormCadastrar_Load(object sender, EventArgs e)
        {
            Carregar();
        }

        //Metodo para chamar o formulario fornecedor
        private void DgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Metodos para trabalhar com celulas e colunas
                /*string _fornecedor = Convert.ToString(dgvDados["Fornecedor", e.RowIndex].Value);
                string _fornecedor = Convert.ToString(dgvDados.CurrentCell[0].Value);
                string _fornecedor = Convert.ToString(dgvDados.CurrentCell.Value);

                foreach (DataGridViewColumn coluna in dgvDadosProduto.Columns)
                {
                    MessageBox.Show(coluna.HeaderText);
                }

                //Cria uma lista com o nome das colunas
                List<String> colunasValidas = new List<string>();

                //Obtem nome das colunas
                foreach (DataGridViewColumn col in dgvDadosProduto.Columns)
                {
                    colunasValidas.Add(col.HeaderText);
                }*/

                //Obtem o nome da coluna da celula 2click
                string nomeColuna = dgvDadosProduto.Columns[e.ColumnIndex].HeaderText;

                switch (nomeColuna)
                {
                    case "Descrição":
                        MessageBox.Show(nomeColuna + " a ser implentado");
                        break;
                    case "Unidade":
                        MessageBox.Show(nomeColuna + " a ser implentado");
                        break;
                    case "Fornecedor":
                        //Busca o valor da celula da coluna selecionada
                        string _fornecedor = Convert.ToString(dgvDadosProduto.Rows[e.RowIndex].Cells[nomeColuna].FormattedValue);

                        //Cria um variavel do tipo fornecedor e busca pelo nome (Razão Social)
                        var fornecedor = Fornecedor.BuscarTodos().First(f => f.RazaoSocial == _fornecedor);
                        var form = new FormFornecedor(fornecedor);
                        form.ShowDialog();
                        Carregar();
                        break;
                    default:
                        MessageBox.Show("Nada a exibir");
                        break;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Menssagem de Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboFornecedor_Click(object sender, EventArgs e)
        {
            //int selectedIndex = cboFornecedor.SelectedIndex;
            Object selectedItem = cboFornecedor.SelectedItem;

            if (selectedItem == null && cboFornecedor.DataSource == null)
            {
                linkLblFornecedor.Visible = true;
            }
        }

        private void linkLblFornecedor_Click(object sender, EventArgs e)
        {
            //Abre um novo formulario
            FormFornecedor formFornecedor = new FormFornecedor();
            formFornecedor.ShowDialog();
        }
    }
}
