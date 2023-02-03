namespace Diet.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Change3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Foods", "FoodPicture", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Foods", "FoodPicture");
        }
    }
}
