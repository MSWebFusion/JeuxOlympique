namespace JeuxOlympique.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modifmanage : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Nom", c => c.String());
            AddColumn("dbo.AspNetUsers", "Prénom", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Prénom");
            DropColumn("dbo.AspNetUsers", "Nom");
        }
    }
}
