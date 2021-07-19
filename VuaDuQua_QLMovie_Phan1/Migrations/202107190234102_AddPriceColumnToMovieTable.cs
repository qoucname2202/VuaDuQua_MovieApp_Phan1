namespace VuaDuQua_QLMovie_Phan1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPriceColumnToMovieTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Price", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "Price");
        }
    }
}
