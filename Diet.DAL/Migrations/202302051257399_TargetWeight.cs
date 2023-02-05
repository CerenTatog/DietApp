namespace Diet.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TargetWeight : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.UserDetails", "TargetWeight", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.UserDetails", "TargetWeight", c => c.Double());
        }
    }
}
