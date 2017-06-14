namespace myTrack.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class myTrackTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CatId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        User_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.CatId)
                .ForeignKey("dbo.AspNetUsers", t => t.User_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Subcategories",
                c => new
                    {
                        SubcatId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        Category_CatId = c.Int(),
                    })
                .PrimaryKey(t => t.SubcatId)
                .ForeignKey("dbo.Categories", t => t.Category_CatId)
                .Index(t => t.Category_CatId);
            
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        ItemId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Status = c.Boolean(nullable: false),
                        Disciption = c.String(),
                        Frequency = c.String(),
                        NextDate = c.DateTime(nullable: false),
                        Subcategory_SubcatId = c.Int(),
                    })
                .PrimaryKey(t => t.ItemId)
                .ForeignKey("dbo.Subcategories", t => t.Subcategory_SubcatId)
                .Index(t => t.Subcategory_SubcatId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Categories", "User_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Subcategories", "Category_CatId", "dbo.Categories");
            DropForeignKey("dbo.Items", "Subcategory_SubcatId", "dbo.Subcategories");
            DropIndex("dbo.Items", new[] { "Subcategory_SubcatId" });
            DropIndex("dbo.Subcategories", new[] { "Category_CatId" });
            DropIndex("dbo.Categories", new[] { "User_Id" });
            DropTable("dbo.Items");
            DropTable("dbo.Subcategories");
            DropTable("dbo.Categories");
        }
    }
}
