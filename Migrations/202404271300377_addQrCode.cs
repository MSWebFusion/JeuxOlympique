namespace JeuxOlympique.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addQrCode : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.paniers", "TokenPrivate", c => c.String());
            AddColumn("dbo.paniers", "QrCode", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.paniers", "QrCode");
            DropColumn("dbo.paniers", "TokenPrivate");
        }
    }
}
