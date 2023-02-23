using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_mnnorton.Models
{
    public class MovieContext : DbContext 
    {
        //constructor
        public MovieContext (DbContextOptions<MovieContext> options) : base (options)
        {
            //leave blank for  now
        }

        public DbSet<ApplicationResponse> Responses { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {

            mb.Entity<Category>().HasData(
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Comedy"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Family"
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "Horror"
                },
                new Category
                {
                    CategoryID = 4,
                    CategoryName = "Action"
                },
                new Category
                {
                    CategoryID = 5,
                    CategoryName = "Drama"
                },
                new Category
                {
                    CategoryID = 6,
                    CategoryName = "Adventure"
                }
                );


            mb.Entity<ApplicationResponse>().HasData(

                new ApplicationResponse
                {
                    MovieID = 1,
                    MovieTitle = "Legally Blonde",
                    Rating= "PG-13",
                    Edited = false,
                    LentTo = null,
                    Notes = "This one makes me want to be a girl boss.",
                    CategoryID = 1,
                    YearRelease = 2007,
                    Director = null
                },
                new ApplicationResponse
                {
                    MovieID = 2,
                    MovieTitle = "Cars",
                    Rating = "G",
                    Edited = false,
                    LentTo = null,
                    Notes = null,
                    CategoryID = 2,
                    YearRelease = 2003,
                    Director = null
                },
                new ApplicationResponse
                {
                    MovieID = 3,
                    MovieTitle = "How to Lose a Guy in Ten Days",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = null,
                    Notes = "Caleb likes this one too.",
                    CategoryID = 1,
                    YearRelease = 2007,
                    Director = null
                }
             );
        }

    }
}
