namespace MovieRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixedManyToMany : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.GenreMovies", "Genre_GenreId", "dbo.Genres");
            DropForeignKey("dbo.GenreMovies", "Movie_MovieId", "dbo.Movies");
            DropIndex("dbo.GenreMovies", new[] { "Genre_GenreId" });
            DropIndex("dbo.GenreMovies", new[] { "Movie_MovieId" });
            DropTable("dbo.GenreMovies");
            CreateTable(
                "dbo.GenreMovies",
                c => new
                    {
                        GenreMoviesId = c.Int(nullable: false, identity: true),
                        MovieId = c.Int(nullable: false),
                        GenreId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.GenreMoviesId)
                .ForeignKey("dbo.Genres", t => t.GenreId, cascadeDelete: true)
                .ForeignKey("dbo.Movies", t => t.MovieId, cascadeDelete: true)
                .Index(t => t.MovieId)
                .Index(t => t.GenreId);
            
          
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.GenreMovies",
                c => new
                    {
                        Genre_GenreId = c.Int(nullable: false),
                        Movie_MovieId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Genre_GenreId, t.Movie_MovieId });
            
            DropForeignKey("dbo.GenreMovies", "MovieId", "dbo.Movies");
            DropForeignKey("dbo.GenreMovies", "GenreId", "dbo.Genres");
            DropIndex("dbo.GenreMovies", new[] { "GenreId" });
            DropIndex("dbo.GenreMovies", new[] { "MovieId" });
            DropTable("dbo.GenreMovies");
            CreateIndex("dbo.GenreMovies", "Movie_MovieId");
            CreateIndex("dbo.GenreMovies", "Genre_GenreId");
            AddForeignKey("dbo.GenreMovies", "Movie_MovieId", "dbo.Movies", "MovieId", cascadeDelete: true);
            AddForeignKey("dbo.GenreMovies", "Genre_GenreId", "dbo.Genres", "GenreId", cascadeDelete: true);
        }
    }
}
