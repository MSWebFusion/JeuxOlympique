namespace JeuxOlympique.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adddescriptionoffre : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Offres", "description", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Offres", "description");
        }
    }
}
