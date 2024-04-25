namespace JeuxOlympique.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class estpaye : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.paniers", "paye", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.paniers", "paye");
        }
    }
}
