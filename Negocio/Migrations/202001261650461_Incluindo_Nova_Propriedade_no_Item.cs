namespace Negocio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Incluindo_Nova_Propriedade_no_Item : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Item", "ValorUnitDoItem", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Item", "ValorUnitDoItem");
        }
    }
}
