namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMovies : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Genre = c.String(),
                        NumberInStock = c.Int(nullable: false),
                        AddedToDatabaseDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            Sql("INSERT INTO Movies (Name, Genre, NumberInStock, AddedToDatabaseDate) VALUES ('Star Wars I', 'Space Opera', 5, GETDATE())");
            Sql("INSERT INTO Movies (Name, Genre, NumberInStock, AddedToDatabaseDate) VALUES ('Star Wars II', 'Space Opera', 2, GETDATE())");
            Sql("INSERT INTO Movies (Name, Genre, NumberInStock, AddedToDatabaseDate) VALUES ('Star Wars III', 'Space Opera', 10, GETDATE())");
            Sql("INSERT INTO Movies (Name, Genre, NumberInStock, AddedToDatabaseDate) VALUES ('Harry Potter and the Half-Blood Prince', 'Fantasy', 1, GETDATE())");

        }
        
        public override void Down()
        {
            DropTable("dbo.Movies");
        }
    }
}
