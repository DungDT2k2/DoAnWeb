namespace DoAn_Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateData1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_News", "Detail", c => c.String());
            AddColumn("dbo.tb_Posts", "Detail", c => c.String());
            AddColumn("dbo.tb_Product", "Detail", c => c.String());
            AddColumn("dbo.tb_ProductCategory", "Detail", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.tb_ProductCategory", "Detail");
            DropColumn("dbo.tb_Product", "Detail");
            DropColumn("dbo.tb_Posts", "Detail");
            DropColumn("dbo.tb_News", "Detail");
        }
    }
}
