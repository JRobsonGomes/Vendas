namespace Negocio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigracaoInicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Fornecedor",
                c => new
                    {
                        FornecedorId = c.Int(nullable: false, identity: true),
                        Cnpj = c.String(nullable: false, maxLength: 20),
                        RazaoSocial = c.String(nullable: false, maxLength: 200),
                    })
                .PrimaryKey(t => t.FornecedorId);
            
            CreateTable(
                "dbo.Item",
                c => new
                    {
                        ItemId = c.Int(nullable: false, identity: true),
                        Quantidade = c.Int(nullable: false),
                        ValorTotalDoItem = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ProdutoId = c.Int(nullable: false),
                        PedidoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ItemId)
                .ForeignKey("dbo.Pedido", t => t.PedidoId, cascadeDelete: true)
                .ForeignKey("dbo.Produto", t => t.ProdutoId, cascadeDelete: true)
                .Index(t => t.ProdutoId)
                .Index(t => t.PedidoId);
            
            CreateTable(
                "dbo.Pedido",
                c => new
                    {
                        PedidoId = c.Int(nullable: false, identity: true),
                        DataPedido = c.DateTime(nullable: false),
                        Desconto = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ValorTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.PedidoId);
            
            CreateTable(
                "dbo.Produto",
                c => new
                    {
                        ProdutoId = c.Int(nullable: false, identity: true),
                        Descricao = c.String(nullable: false, maxLength: 100),
                        UnidadeMedida = c.String(nullable: false, maxLength: 10),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        FornecedorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProdutoId)
                .ForeignKey("dbo.Fornecedor", t => t.FornecedorId, cascadeDelete: true)
                .Index(t => t.FornecedorId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Item", "ProdutoId", "dbo.Produto");
            DropForeignKey("dbo.Produto", "FornecedorId", "dbo.Fornecedor");
            DropForeignKey("dbo.Item", "PedidoId", "dbo.Pedido");
            DropIndex("dbo.Produto", new[] { "FornecedorId" });
            DropIndex("dbo.Item", new[] { "PedidoId" });
            DropIndex("dbo.Item", new[] { "ProdutoId" });
            DropTable("dbo.Produto");
            DropTable("dbo.Pedido");
            DropTable("dbo.Item");
            DropTable("dbo.Fornecedor");
        }
    }
}
