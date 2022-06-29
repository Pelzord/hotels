using Microsoft.EntityFrameworkCore;

namespace hotels.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {

        }
       
        public DbSet<Country> Countries { get; set; }
        public DbSet<Hotel> Hotels { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "Germany",
                    ShortName = "GRM"
                },
                new Country
                {
                    Id = 2,
                    Name = "France",
                    ShortName = "FRN"
                },
                new Country
                {
                    Id = 3,
                    Name = "Canada",
                    ShortName = "CAN"
                }
            );

            builder.Entity<Hotel>().HasData(
               new Hotel
               {
                   Id = 1,
                   Name = "Ritz Carlton",
                   Address = "Hamburg",
                   CountryId = 1,
                   Rating = 4.5
               },
               new Hotel
               {
                   Id = 2,
                   Name = "Marriott",
                   Address = "Paris",
                   CountryId = 2,
                   Rating = 4
               },
               new Hotel
               {
                   Id = 3,
                   Name = "Four Seasons",
                   Address = "Toronto",
                   CountryId = 3,
                   Rating = 5
               }
           );
        }

    }
}
