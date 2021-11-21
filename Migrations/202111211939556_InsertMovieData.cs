namespace MovieRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class InsertMovieData : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('The Beginning', '2015-07-10', '2015-07-12', 5,1)");
            Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('Moana', '2012-05-11', '2015-07-10', 5,4)");
            Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('House Of Gucci', '2021-11-10', '2021-11-12', 7,2)");
            Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('Miss Americana', '2020-07-20', '2020-08-20', 15,5)");
            Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('Cobar', '2015-02-10', '2015-06-12', 4,4)");
        }

        public override void Down()
        {
        }
    }
}
