namespace LegacyEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedHolidayRequestStatus : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.HolidayRequests", "Status", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.HolidayRequests", "Status");
        }
    }
}
