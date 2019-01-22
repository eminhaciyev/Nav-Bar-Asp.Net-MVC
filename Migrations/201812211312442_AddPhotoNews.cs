namespace NavBarOtherMethod.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPhotoNews : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.News", "Photo", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.News", "Photo");
        }
    }
}
