namespace Negocio
{
    partial class FormCadastro
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblUnidade = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.dgvDadosProduto = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnIncluir = new System.Windows.Forms.Button();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtUnidade = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.cboFornecedor = new System.Windows.Forms.ComboBox();
            this.linkLblFornecedor = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(25, 50);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(92, 19);
            this.lblDescricao.TabIndex = 0;
            this.lblDescricao.Text = "Descrição:";
            // 
            // lblUnidade
            // 
            this.lblUnidade.AutoSize = true;
            this.lblUnidade.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidade.Location = new System.Drawing.Point(38, 90);
            this.lblUnidade.Name = "lblUnidade";
            this.lblUnidade.Size = new System.Drawing.Size(79, 19);
            this.lblUnidade.TabIndex = 1;
            this.lblUnidade.Text = "Unidade:";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(63, 130);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(54, 19);
            this.lblValor.TabIndex = 2;
            this.lblValor.Text = "Valor:";
            // 
            // dgvDadosProduto
            // 
            this.dgvDadosProduto.AllowUserToAddRows = false;
            this.dgvDadosProduto.AllowUserToDeleteRows = false;
            this.dgvDadosProduto.AllowUserToResizeColumns = false;
            this.dgvDadosProduto.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvDadosProduto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDadosProduto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDadosProduto.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDadosProduto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDadosProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDadosProduto.ColumnHeadersVisible = false;
            this.dgvDadosProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.descricao,
            this.valor,
            this.unidade,
            this.fornecedor});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDadosProduto.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDadosProduto.EnableHeadersVisualStyles = false;
            this.dgvDadosProduto.Location = new System.Drawing.Point(12, 220);
            this.dgvDadosProduto.Name = "dgvDadosProduto";
            this.dgvDadosProduto.ReadOnly = true;
            this.dgvDadosProduto.RowHeadersVisible = false;
            this.dgvDadosProduto.Size = new System.Drawing.Size(776, 218);
            this.dgvDadosProduto.TabIndex = 3;
            this.dgvDadosProduto.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDados_CellDoubleClick);
            this.dgvDadosProduto.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvDadosProduto_CellFormatting);
            // 
            // id
            // 
            this.id.DataPropertyName = "ProdutoId";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // descricao
            // 
            this.descricao.DataPropertyName = "Descricao";
            this.descricao.HeaderText = "Descrição";
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            // 
            // valor
            // 
            this.valor.DataPropertyName = "Valor";
            this.valor.HeaderText = "Valor";
            this.valor.Name = "valor";
            this.valor.ReadOnly = true;
            // 
            // unidade
            // 
            this.unidade.DataPropertyName = "UnidadeMedida";
            this.unidade.HeaderText = "Unidade";
            this.unidade.Name = "unidade";
            this.unidade.ReadOnly = true;
            // 
            // fornecedor
            // 
            this.fornecedor.DataPropertyName = "Fornecedor.RazaoSocial";
            this.fornecedor.HeaderText = "Fornecedor";
            this.fornecedor.Name = "fornecedor";
            this.fornecedor.ReadOnly = true;
            // 
            // BtnIncluir
            // 
            this.BtnIncluir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIncluir.Location = new System.Drawing.Point(28, 175);
            this.BtnIncluir.Name = "BtnIncluir";
            this.BtnIncluir.Size = new System.Drawing.Size(89, 31);
            this.BtnIncluir.TabIndex = 4;
            this.BtnIncluir.Text = "Incluir";
            this.BtnIncluir.UseVisualStyleBackColor = true;
            this.BtnIncluir.Click += new System.EventHandler(this.BtnIncluir_Click);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(132, 47);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(242, 26);
            this.txtDescricao.TabIndex = 5;
            // 
            // txtUnidade
            // 
            this.txtUnidade.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnidade.Location = new System.Drawing.Point(132, 87);
            this.txtUnidade.Name = "txtUnidade";
            this.txtUnidade.Size = new System.Drawing.Size(100, 26);
            this.txtUnidade.TabIndex = 6;
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(132, 127);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 26);
            this.txtValor.TabIndex = 7;
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFornecedor.Location = new System.Drawing.Point(431, 50);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(104, 19);
            this.lblFornecedor.TabIndex = 0;
            this.lblFornecedor.Text = "Fornecedor:";
            // 
            // cboFornecedor
            // 
            this.cboFornecedor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFornecedor.FormattingEnabled = true;
            this.cboFornecedor.Location = new System.Drawing.Point(542, 47);
            this.cboFornecedor.Name = "cboFornecedor";
            this.cboFornecedor.Size = new System.Drawing.Size(163, 26);
            this.cboFornecedor.TabIndex = 8;
            this.cboFornecedor.Click += new System.EventHandler(this.cboFornecedor_Click);
            // 
            // linkLblFornecedor
            // 
            this.linkLblFornecedor.AutoSize = true;
            this.linkLblFornecedor.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.linkLblFornecedor.Location = new System.Drawing.Point(542, 87);
            this.linkLblFornecedor.Name = "linkLblFornecedor";
            this.linkLblFornecedor.Size = new System.Drawing.Size(163, 16);
            this.linkLblFornecedor.TabIndex = 9;
            this.linkLblFornecedor.TabStop = true;
            this.linkLblFornecedor.Text = "Cadastrar Fornecedor";
            this.linkLblFornecedor.Visible = false;
            this.linkLblFornecedor.Click += new System.EventHandler(this.linkLblFornecedor_Click);
            // 
            // FormCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLblFornecedor);
            this.Controls.Add(this.cboFornecedor);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtUnidade);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.BtnIncluir);
            this.Controls.Add(this.dgvDadosProduto);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblUnidade);
            this.Controls.Add(this.lblFornecedor);
            this.Controls.Add(this.lblDescricao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastrar";
            this.Load += new System.EventHandler(this.FormCadastrar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblUnidade;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.DataGridView dgvDadosProduto;
        private System.Windows.Forms.Button BtnIncluir;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtUnidade;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.ComboBox cboFornecedor;
        private System.Windows.Forms.LinkLabel linkLblFornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn fornecedor;
    }
}