namespace myTrack.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class itemDescriptionFix : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Items", "Description", c => c.String());
            DropColumn("dbo.Items", "Disciption");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Items", "Disciption", c => c.String());
            DropColumn("dbo.Items", "Description");
        }
    }
}
