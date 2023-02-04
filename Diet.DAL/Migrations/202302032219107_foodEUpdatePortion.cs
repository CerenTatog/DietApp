namespace Diet.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class foodEUpdatePortion : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Foods", "PortionQuantity", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Foods", "PortionQuantity");
        }
    }
}
