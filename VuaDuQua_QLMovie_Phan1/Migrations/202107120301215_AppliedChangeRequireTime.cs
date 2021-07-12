namespace VuaDuQua_QLMovie_Phan1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AppliedChangeRequireTime : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ShowTimes", "Time", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ShowTimes", "Time", c => c.String());
        }
    }
}
