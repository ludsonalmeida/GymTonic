namespace GymTonicWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class versao1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Usuarios", "Altura", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Usuarios", "Altura", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
