namespace DoAn_Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateSystemSetting : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tb_SystemSetting", "SettingValue", c => c.String(maxLength: 4000));
            AlterColumn("dbo.tb_SystemSetting", "SettingDescription", c => c.String(maxLength: 4000));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tb_SystemSetting", "SettingDescription", c => c.String());
            AlterColumn("dbo.tb_SystemSetting", "SettingValue", c => c.String());
        }
    }
}
