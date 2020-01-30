namespace MovieRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BorrowHistories",
                c => new
                    {
                        BorrowHistoryId = c.Int(nullable: false, identity: true),
                        BorrowDate = c.DateTime(nullable: false),
                        UserId = c.Int(nullable: false),
                        MovieId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BorrowHistoryId)
                .ForeignKey("dbo.Movies", t => t.MovieId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.MovieId);
            
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        MovieId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Director = c.String(),
                        Rating = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Year = c.Int(nullable: false),
                        Duration = c.Int(nullable: false),
                        Synopsis = c.String(),
                        ImageURL = c.String(),
                    })
                .PrimaryKey(t => t.MovieId);
            
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        GenreId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.GenreId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                        Phone = c.String(),
                    })
                .PrimaryKey(t => t.UserId);
            
            CreateTable(
                "dbo.GenreMovies",
                c => new
                    {
                        Genre_GenreId = c.Int(nullable: false),
                        Movie_MovieId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Genre_GenreId, t.Movie_MovieId })
                .ForeignKey("dbo.Genres", t => t.Genre_GenreId, cascadeDelete: true)
                .ForeignKey("dbo.Movies", t => t.Movie_MovieId, cascadeDelete: true)
                .Index(t => t.Genre_GenreId)
                .Index(t => t.Movie_MovieId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BorrowHistories", "UserId", "dbo.Users");
            DropForeignKey("dbo.GenreMovies", "Movie_MovieId", "dbo.Movies");
            DropForeignKey("dbo.GenreMovies", "Genre_GenreId", "dbo.Genres");
            DropForeignKey("dbo.BorrowHistories", "MovieId", "dbo.Movies");
            DropIndex("dbo.GenreMovies", new[] { "Movie_MovieId" });
            DropIndex("dbo.GenreMovies", new[] { "Genre_GenreId" });
            DropIndex("dbo.BorrowHistories", new[] { "MovieId" });
            DropIndex("dbo.BorrowHistories", new[] { "UserId" });
            DropTable("dbo.GenreMovies");
            DropTable("dbo.Users");
            DropTable("dbo.Genres");
            DropTable("dbo.Movies");
            DropTable("dbo.BorrowHistories");
        }
    }
}
