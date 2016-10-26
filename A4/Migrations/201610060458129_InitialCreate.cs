namespace A4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Characters",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CharacterName = c.String(),
                        ReleaseDate = c.DateTime(nullable: false),
                        ComicName = c.String(),
                        Weight = c.Int(nullable: false),
                        Height = c.Int(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Characters");
        }
    }
}
