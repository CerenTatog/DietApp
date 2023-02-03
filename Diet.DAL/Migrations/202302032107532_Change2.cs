namespace Diet.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Change2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Foods", "Portion", c => c.Int(nullable: false));
            DropColumn("dbo.Foods", "QuantityType");
            DropColumn("dbo.Foods", "FoodPicture");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Foods", "FoodPicture", c => c.String());
            AddColumn("dbo.Foods", "QuantityType", c => c.Int(nullable: false));
            DropColumn("dbo.Foods", "Portion");
        }
    }
}
