namespace DoAn_Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateCategory : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tb_Catetgory", "Title", c => c.String(nullable: false, maxLength: 150));
            AlterColumn("dbo.tb_Catetgory", "SeoTitle", c => c.String(maxLength: 150));
            AlterColumn("dbo.tb_Catetgory", "SeoDescription", c => c.String(maxLength: 250));
            AlterColumn("dbo.tb_Catetgory", "SeoKeywords", c => c.String(maxLength: 150));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tb_Catetgory", "SeoKeywords", c => c.String());
            AlterColumn("dbo.tb_Catetgory", "SeoDescription", c => c.String());
            AlterColumn("dbo.tb_Catetgory", "SeoTitle", c => c.String());
            AlterColumn("dbo.tb_Catetgory", "Title", c => c.String());
        }
    }
}
