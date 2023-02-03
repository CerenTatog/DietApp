namespace Diet.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class user_water_table : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserWaters",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        Quantity = c.Double(nullable: false),
                        DrinkTime = c.DateTime(nullable: false),
                        CreatedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Users", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserWaters", "UserID", "dbo.Users");
            DropIndex("dbo.UserWaters", new[] { "UserID" });
            DropTable("dbo.UserWaters");
        }
    }
}
