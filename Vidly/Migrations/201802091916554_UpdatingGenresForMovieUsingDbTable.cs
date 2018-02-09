namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatingGenresForMovieUsingDbTable : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Movies SET GenreId = 6 WHERE Name = 'Star Wars I'");
            Sql("UPDATE Movies SET GenreId = 6 WHERE Name = 'Star Wars II'");
            Sql("UPDATE Movies SET GenreId = 6 WHERE Name = 'Star Wars III'");
            Sql("UPDATE Movies SET GenreId = 7 WHERE Name = 'Harry Potter and the Half-Blood Prince'");
        }
        
        public override void Down()
        {
        }
    }
}
