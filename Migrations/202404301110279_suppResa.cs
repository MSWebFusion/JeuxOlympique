namespace JeuxOlympique.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class suppResa : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Reservations", "Offre_OffreID", "dbo.Offres");
            DropIndex("dbo.Reservations", new[] { "Offre_OffreID" });
            DropTable("dbo.Reservations");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        ReservationID = c.Int(nullable: false, identity: true),
                        DateReservation = c.DateTime(nullable: false),
                        StatutReservation = c.String(),
                        Offre_OffreID = c.Int(),
                    })
                .PrimaryKey(t => t.ReservationID);
            
            CreateIndex("dbo.Reservations", "Offre_OffreID");
            AddForeignKey("dbo.Reservations", "Offre_OffreID", "dbo.Offres", "OffreID");
        }
    }
}
