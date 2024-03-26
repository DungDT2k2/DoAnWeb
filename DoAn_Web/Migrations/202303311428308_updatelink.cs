namespace DoAn_Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatelink : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_Catetgory", "Link", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.tb_Catetgory", "Link");
        }
    }
}
