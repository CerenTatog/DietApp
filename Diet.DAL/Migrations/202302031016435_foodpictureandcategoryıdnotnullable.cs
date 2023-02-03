namespace Diet.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class foodpictureandcategoryıdnotnullable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Foods", "CategoryID", "dbo.Categories");
            DropIndex("dbo.Foods", new[] { "CategoryID" });
            AddColumn("dbo.Foods", "FoodPicture", c => c.String());
            AlterColumn("dbo.Foods", "CategoryID", c => c.Int(nullable: false));
            CreateIndex("dbo.Foods", "CategoryID");
            AddForeignKey("dbo.Foods", "CategoryID", "dbo.Categories", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Foods", "CategoryID", "dbo.Categories");
            DropIndex("dbo.Foods", new[] { "CategoryID" });
            AlterColumn("dbo.Foods", "CategoryID", c => c.Int());
            DropColumn("dbo.Foods", "FoodPicture");
            CreateIndex("dbo.Foods", "CategoryID");
            AddForeignKey("dbo.Foods", "CategoryID", "dbo.Categories", "ID");
        }
    }
}
