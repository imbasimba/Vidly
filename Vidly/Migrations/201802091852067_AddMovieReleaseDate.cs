namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMovieReleaseDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "ReleaseDate", c => c.DateTime(nullable: false));
            Sql("UPDATE Movies SET ReleaseDate = '9/19/1999' WHERE Name = 'Star Wars I'");
            Sql("UPDATE Movies SET ReleaseDate = '12/1/2001' WHERE Name = 'Star Wars II'");
            Sql("UPDATE Movies SET ReleaseDate = '1/12/1999' WHERE Name = 'Star Wars III'");
            Sql("UPDATE Movies SET ReleaseDate = '9/2/2010' WHERE Name = 'Harry Potter and the Half-Blood Prince'");

        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "ReleaseDate");
        }
    }
}
