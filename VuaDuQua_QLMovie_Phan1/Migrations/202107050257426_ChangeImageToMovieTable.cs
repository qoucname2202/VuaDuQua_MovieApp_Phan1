namespace VuaDuQua_QLMovie_Phan1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeImageToMovieTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Image", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "Image");
        }
    }
}
