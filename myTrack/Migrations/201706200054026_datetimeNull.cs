namespace myTrack.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class datetimeNull : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Items", "NextDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Items", "NextDate", c => c.DateTime(nullable: false));
        }
    }
}
