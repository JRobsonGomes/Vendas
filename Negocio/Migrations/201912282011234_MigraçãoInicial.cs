namespace Negocio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigraçãoInicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Fornecedor",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Cnpj = c.String(nullable: false, maxLength: 20),
                        RazaoSocial = c.String(nullable: false, maxLength: 200),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Item",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Quantidade = c.Int(nullable: false),
                        ValorTotalDoItem = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Pedido_Id = c.Int(),
                        Produto_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Pedido", t => t.Pedido_Id)
                .ForeignKey("dbo.Produto", t => t.Produto_Id)
                .Index(t => t.Pedido_Id)
                .Index(t => t.Produto_Id);
            
            CreateTable(
                "dbo.Pedido",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DataPedido = c.DateTime(nullable: false),
                        Desconto = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ValorTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Produto",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(nullable: false, maxLength: 100),
                        UnidadeMedida = c.String(nullable: false, maxLength: 10),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Fornecedor_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Fornecedor", t => t.Fornecedor_Id)
                .Index(t => t.Fornecedor_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Item", "Produto_Id", "dbo.Produto");
            DropForeignKey("dbo.Produto", "Fornecedor_Id", "dbo.Fornecedor");
            DropForeignKey("dbo.Item", "Pedido_Id", "dbo.Pedido");
            DropIndex("dbo.Produto", new[] { "Fornecedor_Id" });
            DropIndex("dbo.Item", new[] { "Produto_Id" });
            DropIndex("dbo.Item", new[] { "Pedido_Id" });
            DropTable("dbo.Produto");
            DropTable("dbo.Pedido");
            DropTable("dbo.Item");
            DropTable("dbo.Fornecedor");
        }
    }
}
