using Negocio.Models;
using System;
using System.Reflection;
using System.Windows.Forms;

namespace Negocio
{
    public partial class FormPedido : Form
    {
        Pedido novoPedido = Pedido.GetPedido();

        public FormPedido()
        {
            InitializeComponent();
            dgvDadosPedido.AutoGenerateColumns = false;
        }

        private void FormPedido_Load(object sender, EventArgs e)
        {
            Carregar();
        }

        private void Carregar()
        {
            try
            {
                cboProduto.ValueMember = "ProdutoId";
                cboProduto.DisplayMember = "Descricao";
                cboProduto.DataSource = Produto.BuscarTodos();// Exibe os items de produtos no combobox no carregamento
                numericUpDownQuant.Value = 1;
                txtTotal.Text = "0";
                txtDesconto.Text = "";
                //cboProduto.SelectedIndex = -1;
                //cboProduto.SelectedItem = null;

                // Exibe os dados para teste
                //novoPedido.PedidoId = 26;
                /*var itens = novoPedido.GetPedidoItens();

                //Codigo abaixo serve para adicionar linhas individualmente
                // Cria as colunas
                dgvDadosPedido.Columns.Add("id", "ID");
                dgvDadosPedido.Columns.Add("descricao", "Descrição");
                dgvDadosPedido.Columns.Add("quantidade", "Quantidade");
                dgvDadosPedido.Columns.Add("valorUnit", "Valor Unit.");
                dgvDadosPedido.Columns.Add("valorTotal", "Valor Total");

                // Preenche as linhas
                for (int i = 0; i < itens.Count; i++)
                {
                    // Cria uma linha
                    DataGridViewRow linhaItem = new DataGridViewRow();
                    linhaItem.CreateCells(dgvDadosPedido);
                    // Seta os valores
                    linhaItem.Cells[0].Value = itens[i].ProdutoId;
                    linhaItem.Cells[1].Value = itens[i].Produto.Descricao;
                    linhaItem.Cells[2].Value = itens[i].Quantidade;
                    linhaItem.Cells[3].Value = itens[i].ValorUnitDoItem;
                    linhaItem.Cells[4].Value = itens[i].ValorTotalDoItem;
                    // Adiciona na grid
                    dgvDadosPedido.Rows.Add(linhaItem);
                }

                dgvDadosPedido.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                dgvDadosPedido.ColumnHeadersVisible = true;
                dgvDadosPedido.DataSource = itens;// Exibe os dados no carregamento
                dgvDadosPedido.Refresh();*/
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
        private void dgvDadosPedido_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if ((dgvDadosPedido.Rows[e.RowIndex].DataBoundItem != null) && (dgvDadosPedido.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
                {
                    e.Value = BindProperty(dgvDadosPedido.Rows[e.RowIndex].DataBoundItem, dgvDadosPedido.Columns[e.ColumnIndex].DataPropertyName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cboProduto_Click(object sender, EventArgs e)
        {
            try
            {
                Object selectedItem = cboProduto.SelectedItem;

                if (selectedItem != null && cboProduto.DataSource != null)
                {
                    int id = Convert.ToInt32(cboProduto.SelectedValue);
                    txtValorItem.Text = Convert.ToString(Produto.Buscar(id).Valor);
                }
                else
                    txtValorItem.Text = "0";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void btnIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                int idProduto = Convert.ToInt32(cboProduto.SelectedValue);
                int quantItem = Convert.ToInt32(numericUpDownQuant.Value);
                novoPedido.DataPedido = dtpData.Value;
                novoPedido.Desconto = txtDesconto.Text == "" ? 0 : Convert.ToDecimal(txtDesconto.Text);
                novoPedido.ValorTotal = Convert.ToDecimal(txtTotal.Text);

                // Adicionar Item no Pedido
                novoPedido.AdicionarItem(idProduto, quantItem);

                //Atribui ao pedido o valor total atualizado
                novoPedido.ValorTotal = novoPedido.GetPedidoTotal();

                //Salva o pedido como o valor total atualizado
                novoPedido.Salvar();
                txtTotal.Text = Convert.ToString(novoPedido.ValorTotal);
                txtIdPedido.Text = Convert.ToString(novoPedido.PedidoId);

                //AdicionarItem(produto, quantItem, valorItem * quantItem, valorItem);
                //Item pedidoItem = novoPedido.GetPedidoItens().FindLast(i => i.Produto.ProdutoId == produto.ProdutoId);

                // Exibe os dados de forma anonimas
                /*var item = (from it in context.Itens
                            where it.PedidoId == novoPedido.PedidoId
                            select new
                            {
                                ID = it.ProdutoId,
                                Descrição = it.Produto.Descricao,
                                it.Quantidade,
                                Valor_Unit = it.ValorUnitDoItem,
                                Valor_Total = it.ValorTotalDoItem
                            }).ToList();*/

                //Busca itens no pedido
                var itens = novoPedido.GetPedidoItens();

                //Muda exibição das celulas do DataGridView
                dgvDadosPedido.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

                //Torna visivel as colunas do DataGridView
                dgvDadosPedido.ColumnHeadersVisible = true;

                //Atribui nulo ao DataSource
                dgvDadosPedido.DataSource = null;

                //Atribui ao DataSource os Itens do pedido
                dgvDadosPedido.DataSource = itens;

                //Atualiza o DataGridView
                dgvDadosPedido.Update();

                //Recarrega o DataGridView
                dgvDadosPedido.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cboProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Object selectedItem = cboProduto.SelectedItem;

                if (selectedItem != null && cboProduto.DataSource != null)
                {
                    int id = Convert.ToInt32(cboProduto.SelectedValue);
                    txtValorItem.Text = Convert.ToString(Produto.Buscar(id).Valor);
                }
                else
                    txtValorItem.Text = "0";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtDesconto_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string originalText = null;

                /*Verifique se a alteração feita não retorna o valor
                controle ao seu estado original */
                if (originalText != txtDesconto.Text)
                {
                    // Set the Modified property to true to reflect the change.
                    txtDesconto.Modified = true;

                    novoPedido.Desconto = Convert.ToDecimal(txtDesconto.Text);

                    //Atribui ao pedido o valor total atualizado
                    novoPedido.ValorTotal = novoPedido.GetPedidoTotal();

                    //Salva o pedido como o valor total atualizado
                    novoPedido.Salvar();
                    //Atualiza o TextBox Total do Pedido
                    txtTotal.Text = Convert.ToString(novoPedido.ValorTotal);
                    txtTotal.Refresh();
                }
                else
                    // Contents of textBox1 have not changed, reset the Modified property.
                    txtDesconto.Modified = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /*public void AdicionarItem(Produto produto, int quantidade, decimal valorTotalDoItem, decimal valorUnitDoItem)
        {
            //var ultimoPedido = context.Pedidos.SingleOrDefault(s => s.PedidoId == context.Pedidos.Max(i => i.PedidoId));
            //var ultimoProduto = context.Itens.SingleOrDefault(s => s.Produto.ProdutoId == context.Itens.Max(i => i.ProdutoId));

           var pedidoItem = context.Itens.SingleOrDefault(
                s => s.Produto.ProdutoId == produto.ProdutoId && s.Pedido.PedidoId == novoPedido.PedidoId);

            if (pedidoItem == null)
            {
                pedidoItem = new Item()
                {
                    ValorTotalDoItem = valorTotalDoItem,
                    ValorUnitDoItem = valorUnitDoItem,
                    Pedido = novoPedido,
                    ProdutoId = produto.ProdutoId,
                    Quantidade = quantidade
                };

                context.Itens.Add(pedidoItem);
            }
            else
            {
                pedidoItem.Quantidade += quantidade;
            }
            context.SaveChanges();
        }*/
    }
}
