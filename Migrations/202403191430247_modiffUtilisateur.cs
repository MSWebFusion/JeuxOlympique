namespace JeuxOlympique.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modiffUtilisateur : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Utilisateurs", "AspnetusersID", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Utilisateurs", "AspnetusersID", c => c.Int(nullable: false));
        }
    }
}
