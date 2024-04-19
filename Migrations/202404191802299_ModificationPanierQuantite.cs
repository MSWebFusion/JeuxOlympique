namespace JeuxOlympique.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModificationPanierQuantite : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.paniers", "Quantite", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.paniers", "Quantite");
        }
    }
}
