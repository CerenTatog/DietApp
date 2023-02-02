namespace Diet.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ua_f_ud_table_column_changes : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserActivities", "StepCount", c => c.Int());
            AddColumn("dbo.Foods", "QuantityType", c => c.Int(nullable: false));
            AddColumn("dbo.UserDetails", "TargetWeight", c => c.Double());
        }
        
        public override void Down()
        {
            DropColumn("dbo.UserDetails", "TargetWeight");
            DropColumn("dbo.Foods", "QuantityType");
            DropColumn("dbo.UserActivities", "StepCount");
        }
    }
}
