namespace JeuxOlympique.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modiffOffres : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Offres", "Photo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Offres", "Photo", c => c.String());
        }
    }
}
