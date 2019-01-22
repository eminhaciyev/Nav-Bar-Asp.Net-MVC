namespace NavBarOtherMethod.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Menus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Url = c.String(nullable: false, maxLength: 50),
                        IsVisible = c.Boolean(nullable: false),
                        Order = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.News",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 1000),
                        Body = c.String(nullable: false, maxLength: 1000),
                        IsVisible = c.Boolean(nullable: false),
                        Order = c.Int(nullable: false),
                        MenuCategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Menus", t => t.MenuCategoryId, cascadeDelete: true)
                .Index(t => t.MenuCategoryId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.News", "MenuCategoryId", "dbo.Menus");
            DropIndex("dbo.News", new[] { "MenuCategoryId" });
            DropTable("dbo.News");
            DropTable("dbo.Menus");
        }
    }
}
