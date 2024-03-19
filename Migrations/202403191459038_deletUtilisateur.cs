namespace JeuxOlympique.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deletUtilisateur : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Reservations", "Utilisateur_UtilisateurID", "dbo.Utilisateurs");
            DropIndex("dbo.Reservations", new[] { "Utilisateur_UtilisateurID" });
            DropColumn("dbo.Reservations", "Utilisateur_UtilisateurID");
            DropTable("dbo.Utilisateurs");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Utilisateurs",
                c => new
                    {
                        UtilisateurID = c.Int(nullable: false, identity: true),
                        AspnetusersID = c.String(),
                        Nom = c.String(),
                        Prénom = c.String(),
                        AdresseEmail = c.String(),
                    })
                .PrimaryKey(t => t.UtilisateurID);
            
            AddColumn("dbo.Reservations", "Utilisateur_UtilisateurID", c => c.Int());
            CreateIndex("dbo.Reservations", "Utilisateur_UtilisateurID");
            AddForeignKey("dbo.Reservations", "Utilisateur_UtilisateurID", "dbo.Utilisateurs", "UtilisateurID");
        }
    }
}
