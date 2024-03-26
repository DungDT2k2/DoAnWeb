namespace DoAn_Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateSubcribe : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tb_Subcscribe", "Email", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tb_Subcscribe", "Email", c => c.String());
        }
    }
}
