namespace DoAn_Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateProductCategory1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_ProductCategory", "CreateBy", c => c.String());
            AddColumn("dbo.tb_ProductCategory", "CreateDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.tb_ProductCategory", "ModifiedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.tb_ProductCategory", "ModifiedBy", c => c.String());
            DropColumn("dbo.tb_ProductCategory", "Order");
            DropColumn("dbo.tb_ProductCategory", "TypeName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tb_ProductCategory", "TypeName", c => c.String());
            AddColumn("dbo.tb_ProductCategory", "Order", c => c.Int(nullable: false));
            DropColumn("dbo.tb_ProductCategory", "ModifiedBy");
            DropColumn("dbo.tb_ProductCategory", "ModifiedDate");
            DropColumn("dbo.tb_ProductCategory", "CreateDate");
            DropColumn("dbo.tb_ProductCategory", "CreateBy");
        }
    }
}
