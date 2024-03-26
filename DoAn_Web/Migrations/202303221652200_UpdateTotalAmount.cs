namespace DoAn_Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateTotalAmount : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tb_Order", "TotalAmount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tb_Order", "TotalAmount", c => c.String());
        }
    }
}
