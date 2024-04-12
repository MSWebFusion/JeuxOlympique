namespace JeuxOlympique.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class midifPhoto : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Offres", "Photo", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Offres", "Photo");
        }
    }
}
