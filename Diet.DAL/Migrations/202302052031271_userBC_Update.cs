namespace Diet.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class userBC_Update : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserBCs", "Weight", c => c.Double(nullable: false));
            AddColumn("dbo.UserBCs", "Height", c => c.Double(nullable: false));
            AddColumn("dbo.UserBCs", "ActivityStatus", c => c.Int(nullable: false));
            DropColumn("dbo.UserBCs", "BodyCharacteristicType");
            DropColumn("dbo.UserBCs", "MeasurementValue");
            DropColumn("dbo.UserBCs", "MeasureType");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UserBCs", "MeasureType", c => c.Int(nullable: false));
            AddColumn("dbo.UserBCs", "MeasurementValue", c => c.Double(nullable: false));
            AddColumn("dbo.UserBCs", "BodyCharacteristicType", c => c.Int(nullable: false));
            DropColumn("dbo.UserBCs", "ActivityStatus");
            DropColumn("dbo.UserBCs", "Height");
            DropColumn("dbo.UserBCs", "Weight");
        }
    }
}
