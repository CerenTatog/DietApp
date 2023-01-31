namespace Diet.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_tables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Activities",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ActivityName = c.String(nullable: false, maxLength: 50),
                        LostCalorie = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.UserActivities",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        ActivityID = c.Int(nullable: false),
                        ActivityTime = c.DateTime(nullable: false),
                        Duration = c.Double(nullable: false),
                        CalculatedCalorie = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Activities", t => t.ActivityID, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID)
                .Index(t => t.ActivityID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false, maxLength: 50),
                        UserSurname = c.String(),
                        Password = c.String(nullable: false, maxLength: 128),
                        Email = c.String(nullable: false, maxLength: 80),
                        UserType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Meals",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        MealType = c.Int(nullable: false),
                        MealDate = c.DateTime(nullable: false),
                        UserID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Users", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.MealFoods",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        MealID = c.Int(nullable: false),
                        FoodID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Foods", t => t.FoodID, cascadeDelete: true)
                .ForeignKey("dbo.Meals", t => t.MealID, cascadeDelete: true)
                .Index(t => t.MealID)
                .Index(t => t.FoodID);
            
            CreateTable(
                "dbo.Foods",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FoodName = c.String(nullable: false, maxLength: 120),
                        Calorie = c.Double(nullable: false),
                        CategoryID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Categories", t => t.CategoryID)
                .Index(t => t.CategoryID);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(nullable: false, maxLength: 60),
                        Description = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.ID);
            
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
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Foods", t => t.FoodID, cascadeDelete: true)
                .Index(t => t.FoodID);
            
            CreateTable(
                "dbo.UserBCs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        BodyCharacteristicType = c.Int(nullable: false),
                        MeasurementValue = c.Double(nullable: false),
                        MeasuredDate = c.DateTime(nullable: false),
                        MeasureType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Users", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.UserDetails",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Weight = c.Double(nullable: false),
                        Height = c.Double(nullable: false),
                        Gender = c.Int(nullable: false),
                        Age = c.Int(nullable: false),
                        ActivityStatus = c.Int(nullable: false),
                        UserID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Users", t => t.UserID)
                .Index(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserDetails", "UserID", "dbo.Users");
            DropForeignKey("dbo.UserBCs", "UserID", "dbo.Users");
            DropForeignKey("dbo.UserActivities", "UserID", "dbo.Users");
            DropForeignKey("dbo.Meals", "UserID", "dbo.Users");
            DropForeignKey("dbo.MealFoods", "MealID", "dbo.Meals");
            DropForeignKey("dbo.MealFoods", "FoodID", "dbo.Foods");
            DropForeignKey("dbo.FoodDetails", "FoodID", "dbo.Foods");
            DropForeignKey("dbo.Foods", "CategoryID", "dbo.Categories");
            DropForeignKey("dbo.UserActivities", "ActivityID", "dbo.Activities");
            DropIndex("dbo.UserDetails", new[] { "UserID" });
            DropIndex("dbo.UserBCs", new[] { "UserID" });
            DropIndex("dbo.FoodDetails", new[] { "FoodID" });
            DropIndex("dbo.Foods", new[] { "CategoryID" });
            DropIndex("dbo.MealFoods", new[] { "FoodID" });
            DropIndex("dbo.MealFoods", new[] { "MealID" });
            DropIndex("dbo.Meals", new[] { "UserID" });
            DropIndex("dbo.UserActivities", new[] { "ActivityID" });
            DropIndex("dbo.UserActivities", new[] { "UserID" });
            DropTable("dbo.UserDetails");
            DropTable("dbo.UserBCs");
            DropTable("dbo.FoodDetails");
            DropTable("dbo.Categories");
            DropTable("dbo.Foods");
            DropTable("dbo.MealFoods");
            DropTable("dbo.Meals");
            DropTable("dbo.Users");
            DropTable("dbo.UserActivities");
            DropTable("dbo.Activities");
        }
    }
}
