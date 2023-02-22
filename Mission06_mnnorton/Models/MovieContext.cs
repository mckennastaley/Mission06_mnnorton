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

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<ApplicationResponse>().HasData(

                new ApplicationResponse
                {
                    MovieID = 1,
                    MovieTitle = "Legally Blonde",
                    Rating= "PG-13",
                    Edited = false,
                    LentTo = null,
                    Notes = "This one makes me want to be a girl boss."
                },
                new ApplicationResponse
                {
                    MovieID = 2,
                    MovieTitle = "Cars",
                    Rating = "G",
                    Edited = false,
                    LentTo = null,
                    Notes = null
                },
                new ApplicationResponse
                {
                    MovieID = 3,
                    MovieTitle = "How to Lose a Guy in Ten Days",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = null,
                    Notes = "Caleb likes this one too."
                }
             );
        }

    }
}
