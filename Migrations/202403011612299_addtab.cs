namespace JeuxOlympique.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addtab : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        ReservationID = c.Int(nullable: false, identity: true),
                        DateReservation = c.DateTime(nullable: false),
                        StatutReservation = c.String(),
                        Offre_OffreID = c.Int(),
                        Utilisateur_UtilisateurID = c.Int(),
                    })
                .PrimaryKey(t => t.ReservationID)
                .ForeignKey("dbo.Offres", t => t.Offre_OffreID)
                .ForeignKey("dbo.Utilisateurs", t => t.Utilisateur_UtilisateurID)
                .Index(t => t.Offre_OffreID)
                .Index(t => t.Utilisateur_UtilisateurID);
            
            CreateTable(
                "dbo.Utilisateurs",
                c => new
                    {
                        UtilisateurID = c.Int(nullable: false, identity: true),
                        AspnetusersID = c.Int(nullable: false),
                        Nom = c.String(),
                        Prénom = c.String(),
                        AdresseEmail = c.String(),
                    })
                .PrimaryKey(t => t.UtilisateurID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reservations", "Utilisateur_UtilisateurID", "dbo.Utilisateurs");
            DropForeignKey("dbo.Reservations", "Offre_OffreID", "dbo.Offres");
            DropIndex("dbo.Reservations", new[] { "Utilisateur_UtilisateurID" });
            DropIndex("dbo.Reservations", new[] { "Offre_OffreID" });
            DropTable("dbo.Utilisateurs");
            DropTable("dbo.Reservations");
        }
    }
}
