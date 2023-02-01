namespace Diet.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dietapp_v2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.FoodDetails", "FoodID", "dbo.Foods");
            DropIndex("dbo.FoodDetails", new[] { "FoodID" });
            CreateTable(
                "dbo.UserNotifications",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        Message = c.String(),
                        State = c.Int(nullable: false),
                        IsRead = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Users", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID);
            
            AddColumn("dbo.Activities", "CreatedDate", c => c.DateTime());
            AddColumn("dbo.UserActivities", "CreatedDate", c => c.DateTime());
            AddColumn("dbo.Users", "CreatedDate", c => c.DateTime());
            AddColumn("dbo.Meals", "CreatedDate", c => c.DateTime());
            AddColumn("dbo.MealFoods", "Quantity", c => c.Double(nullable: false));
            AddColumn("dbo.MealFoods", "CreatedDate", c => c.DateTime());
            AddColumn("dbo.Foods", "Carbonhydrate", c => c.Double(nullable: false));
            AddColumn("dbo.Foods", "Fat", c => c.Double(nullable: false));
            AddColumn("dbo.Foods", "Protein", c => c.Double(nullable: false));
            AddColumn("dbo.Foods", "CreatedDate", c => c.DateTime());
            AddColumn("dbo.Categories", "CreatedDate", c => c.DateTime());
            AddColumn("dbo.UserBCs", "CreatedDate", c => c.DateTime());
            AddColumn("dbo.UserDetails", "CreatedDate", c => c.DateTime());
            DropTable("dbo.FoodDetails");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.FoodDetails",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CalculateCalorie = c.Double(nullable: false),
                        Quantity = c.Double(nullable: false),
                        Carbonhydrate = c.Double(nullable: false),
                        Fat = c.Double(nullable: false),
                        Protein = c.Double(nullable: false),
                        FoodID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            DropForeignKey("dbo.UserNotifications", "UserID", "dbo.Users");
            DropIndex("dbo.UserNotifications", new[] { "UserID" });
            DropColumn("dbo.UserDetails", "CreatedDate");
            DropColumn("dbo.UserBCs", "CreatedDate");
            DropColumn("dbo.Categories", "CreatedDate");
            DropColumn("dbo.Foods", "CreatedDate");
            DropColumn("dbo.Foods", "Protein");
            DropColumn("dbo.Foods", "Fat");
            DropColumn("dbo.Foods", "Carbonhydrate");
            DropColumn("dbo.MealFoods", "CreatedDate");
            DropColumn("dbo.MealFoods", "Quantity");
            DropColumn("dbo.Meals", "CreatedDate");
            DropColumn("dbo.Users", "CreatedDate");
            DropColumn("dbo.UserActivities", "CreatedDate");
            DropColumn("dbo.Activities", "CreatedDate");
            DropTable("dbo.UserNotifications");
            CreateIndex("dbo.FoodDetails", "FoodID");
            AddForeignKey("dbo.FoodDetails", "FoodID", "dbo.Foods", "ID", cascadeDelete: true);
        }
    }
}
