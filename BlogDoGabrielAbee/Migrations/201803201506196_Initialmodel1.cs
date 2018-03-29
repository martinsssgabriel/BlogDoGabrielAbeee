namespace BlogDoGabrielAbee.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initialmodel1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        title = c.String(nullable: false, maxLength: 500),
                        DateAdded = c.DateTime(nullable: false),
                        DateUpdated = c.DateTime(nullable: false),
                        PostingBody = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Posts");
        }
    }
}
