namespace Negocio.Views
{
    partial class FormPrincipal
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
            this.menuPricipal = new System.Windows.Forms.MenuStrip();
            this.homeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairSubMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoSubMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidoSubMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedorSubMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPricipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPricipal
            // 
            this.menuPricipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeMenuItem,
            this.cadastroMenuItem});
            this.menuPricipal.Location = new System.Drawing.Point(0, 0);
            this.menuPricipal.Name = "menuPricipal";
            this.menuPricipal.Size = new System.Drawing.Size(1240, 24);
            this.menuPricipal.TabIndex = 1;
            this.menuPricipal.Text = "menuStrip1";
            // 
            // homeMenuItem
            // 
            this.homeMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairSubMenuItem});
            this.homeMenuItem.Name = "homeMenuItem";
            this.homeMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeMenuItem.Text = "Home";
            // 
            // sairSubMenuItem
            // 
            this.sairSubMenuItem.Name = "sairSubMenuItem";
            this.sairSubMenuItem.Size = new System.Drawing.Size(93, 22);
            this.sairSubMenuItem.Text = "Sair";
            this.sairSubMenuItem.Click += new System.EventHandler(this.sairSubMenuItem_Click);
            // 
            // cadastroMenuItem
            // 
            this.cadastroMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtoSubMenuItem,
            this.pedidoSubMenuItem,
            this.fornecedorSubMenuItem});
            this.cadastroMenuItem.Name = "cadastroMenuItem";
            this.cadastroMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroMenuItem.Text = "Cadastro";
            // 
            // produtoSubMenuItem
            // 
            this.produtoSubMenuItem.Name = "produtoSubMenuItem";
            this.produtoSubMenuItem.Size = new System.Drawing.Size(180, 22);
            this.produtoSubMenuItem.Text = "Produto";
            this.produtoSubMenuItem.Click += new System.EventHandler(this.produtoToolStripMenuItem_Click);
            // 
            // pedidoSubMenuItem
            // 
            this.pedidoSubMenuItem.Name = "pedidoSubMenuItem";
            this.pedidoSubMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pedidoSubMenuItem.Text = "Pedido";
            this.pedidoSubMenuItem.Click += new System.EventHandler(this.pedidoToolStripMenuItem_Click);
            // 
            // fornecedorSubMenuItem
            // 
            this.fornecedorSubMenuItem.Name = "fornecedorSubMenuItem";
            this.fornecedorSubMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fornecedorSubMenuItem.Text = "Fornecedor";
            this.fornecedorSubMenuItem.Click += new System.EventHandler(this.fornecedorSubMenuItem_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 727);
            this.Controls.Add(this.menuPricipal);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuPricipal;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuPricipal.ResumeLayout(false);
            this.menuPricipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPricipal;
        private System.Windows.Forms.ToolStripMenuItem homeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtoSubMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidoSubMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairSubMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedorSubMenuItem;
    }
}