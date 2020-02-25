namespace Negocio
{
    partial class FormPedido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.lblData = new System.Windows.Forms.Label();
            this.lblDesconto = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.dgvDadosPedido = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxItens = new System.Windows.Forms.GroupBox();
            this.numericUpDownQuant = new System.Windows.Forms.NumericUpDown();
            this.lblValorItem = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.txtValorItem = new System.Windows.Forms.TextBox();
            this.cboProduto = new System.Windows.Forms.ComboBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtIdPedido = new System.Windows.Forms.TextBox();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosPedido)).BeginInit();
            this.groupBoxItens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuant)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpData
            // 
            this.dtpData.CalendarFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpData.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(353, 11);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(111, 26);
            this.dtpData.TabIndex = 2;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(295, 15);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(50, 19);
            this.lblData.TabIndex = 3;
            this.lblData.Text = "Data:";
            // 
            // lblDesconto
            // 
            this.lblDesconto.AutoSize = true;
            this.lblDesconto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesconto.Location = new System.Drawing.Point(42, 64);
            this.lblDesconto.Name = "lblDesconto";
            this.lblDesconto.Size = new System.Drawing.Size(89, 19);
            this.lblDesconto.TabIndex = 4;
            this.lblDesconto.Text = "Desconto:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(295, 64);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(52, 19);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total:";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(353, 60);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 26);
            this.txtTotal.TabIndex = 5;
            // 
            // btnIncluir
            // 
            this.btnIncluir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluir.Location = new System.Drawing.Point(648, 14);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(89, 31);
            this.btnIncluir.TabIndex = 6;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // dgvDadosPedido
            // 
            this.dgvDadosPedido.AllowUserToAddRows = false;
            this.dgvDadosPedido.AllowUserToDeleteRows = false;
            this.dgvDadosPedido.AllowUserToResizeColumns = false;
            this.dgvDadosPedido.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvDadosPedido.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDadosPedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDadosPedido.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDadosPedido.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDadosPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDadosPedido.ColumnHeadersVisible = false;
            this.dgvDadosPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.descricao,
            this.quantidade,
            this.valorUnit,
            this.valorTotal});
            this.dgvDadosPedido.EnableHeadersVisualStyles = false;
            this.dgvDadosPedido.Location = new System.Drawing.Point(6, 58);
            this.dgvDadosPedido.Name = "dgvDadosPedido";
            this.dgvDadosPedido.ReadOnly = true;
            this.dgvDadosPedido.RowHeadersVisible = false;
            this.dgvDadosPedido.Size = new System.Drawing.Size(728, 250);
            this.dgvDadosPedido.TabIndex = 7;
            this.dgvDadosPedido.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvDadosPedido_CellFormatting);
            // 
            // id
            // 
            this.id.DataPropertyName = "Produto.ProdutoId";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // descricao
            // 
            this.descricao.DataPropertyName = "Produto.Descricao";
            this.descricao.HeaderText = "Descrição";
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            // 
            // quantidade
            // 
            this.quantidade.DataPropertyName = "Quantidade";
            this.quantidade.HeaderText = "Quantidade";
            this.quantidade.Name = "quantidade";
            this.quantidade.ReadOnly = true;
            // 
            // valorUnit
            // 
            this.valorUnit.DataPropertyName = "ValorUnitDoItem";
            this.valorUnit.HeaderText = "Valor Unit.";
            this.valorUnit.Name = "valorUnit";
            this.valorUnit.ReadOnly = true;
            // 
            // valorTotal
            // 
            this.valorTotal.DataPropertyName = "ValorTotalDoItem";
            this.valorTotal.HeaderText = "Valor Total";
            this.valorTotal.Name = "valorTotal";
            this.valorTotal.ReadOnly = true;
            // 
            // groupBoxItens
            // 
            this.groupBoxItens.Controls.Add(this.numericUpDownQuant);
            this.groupBoxItens.Controls.Add(this.lblValorItem);
            this.groupBoxItens.Controls.Add(this.lblQuantidade);
            this.groupBoxItens.Controls.Add(this.lblItem);
            this.groupBoxItens.Controls.Add(this.txtValorItem);
            this.groupBoxItens.Controls.Add(this.btnIncluir);
            this.groupBoxItens.Controls.Add(this.cboProduto);
            this.groupBoxItens.Controls.Add(this.dgvDadosPedido);
            this.groupBoxItens.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxItens.Location = new System.Drawing.Point(12, 120);
            this.groupBoxItens.Name = "groupBoxItens";
            this.groupBoxItens.Size = new System.Drawing.Size(743, 314);
            this.groupBoxItens.TabIndex = 8;
            this.groupBoxItens.TabStop = false;
            this.groupBoxItens.Text = "Itens";
            // 
            // numericUpDownQuant
            // 
            this.numericUpDownQuant.Location = new System.Drawing.Point(584, 17);
            this.numericUpDownQuant.Name = "numericUpDownQuant";
            this.numericUpDownQuant.Size = new System.Drawing.Size(52, 26);
            this.numericUpDownQuant.TabIndex = 10;
            // 
            // lblValorItem
            // 
            this.lblValorItem.AutoSize = true;
            this.lblValorItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorItem.Location = new System.Drawing.Point(390, 20);
            this.lblValorItem.Name = "lblValorItem";
            this.lblValorItem.Size = new System.Drawing.Size(54, 19);
            this.lblValorItem.TabIndex = 9;
            this.lblValorItem.Text = "Valor:";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.Location = new System.Drawing.Point(535, 19);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(42, 19);
            this.lblQuantidade.TabIndex = 9;
            this.lblQuantidade.Text = "Qtd:";
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem.Location = new System.Drawing.Point(15, 20);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(77, 19);
            this.lblItem.TabIndex = 9;
            this.lblItem.Text = "Produto:";
            // 
            // txtValorItem
            // 
            this.txtValorItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorItem.Location = new System.Drawing.Point(448, 17);
            this.txtValorItem.Name = "txtValorItem";
            this.txtValorItem.ReadOnly = true;
            this.txtValorItem.Size = new System.Drawing.Size(81, 26);
            this.txtValorItem.TabIndex = 5;
            // 
            // cboProduto
            // 
            this.cboProduto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProduto.FormattingEnabled = true;
            this.cboProduto.Location = new System.Drawing.Point(98, 16);
            this.cboProduto.Name = "cboProduto";
            this.cboProduto.Size = new System.Drawing.Size(286, 26);
            this.cboProduto.TabIndex = 8;
            this.cboProduto.SelectedIndexChanged += new System.EventHandler(this.cboProduto_SelectedIndexChanged);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(55, 15);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(76, 19);
            this.lblId.TabIndex = 4;
            this.lblId.Text = "Número:";
            // 
            // txtIdPedido
            // 
            this.txtIdPedido.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdPedido.Location = new System.Drawing.Point(137, 11);
            this.txtIdPedido.Name = "txtIdPedido";
            this.txtIdPedido.ReadOnly = true;
            this.txtIdPedido.Size = new System.Drawing.Size(100, 26);
            this.txtIdPedido.TabIndex = 5;
            // 
            // txtDesconto
            // 
            this.txtDesconto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesconto.Location = new System.Drawing.Point(137, 57);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(100, 26);
            this.txtDesconto.TabIndex = 5;
            this.txtDesconto.TextChanged += new System.EventHandler(this.txtDesconto_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(18, 440);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 32);
            this.button1.TabIndex = 6;
            this.button1.Text = "Finalizar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(657, 441);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 31);
            this.button2.TabIndex = 6;
            this.button2.Text = "Remover";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FormPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 489);
            this.Controls.Add(this.groupBoxItens);
            this.Controls.Add(this.txtIdPedido);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtDesconto);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblDesconto);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.dtpData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedido";
            this.Load += new System.EventHandler(this.FormPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosPedido)).EndInit();
            this.groupBoxItens.ResumeLayout(false);
            this.groupBoxItens.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblDesconto;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.DataGridView dgvDadosPedido;
        private System.Windows.Forms.GroupBox groupBoxItens;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.ComboBox cboProduto;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtIdPedido;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblValorItem;
        private System.Windows.Forms.TextBox txtValorItem;
        private System.Windows.Forms.NumericUpDown numericUpDownQuant;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorTotal;
    }
}