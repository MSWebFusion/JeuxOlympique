namespace JeuxOlympique.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModificationPanier : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.paniers", "Offre_OffreID", c => c.Int());
            CreateIndex("dbo.paniers", "Offre_OffreID");
            AddForeignKey("dbo.paniers", "Offre_OffreID", "dbo.Offres", "OffreID");
            DropColumn("dbo.paniers", "OffreId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.paniers", "OffreId", c => c.String());
            DropForeignKey("dbo.paniers", "Offre_OffreID", "dbo.Offres");
            DropIndex("dbo.paniers", new[] { "Offre_OffreID" });
            DropColumn("dbo.paniers", "Offre_OffreID");
        }
    }
}
