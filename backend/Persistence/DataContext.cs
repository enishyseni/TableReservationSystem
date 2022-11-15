using System;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Presistence
{

    public class DataContext : DbContext
     {

            public DataContext(DbContextOptions options) :base(options)
            {

            }

         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        optionsBuilder
        .UseSqlServer(
            "DefaultConnection",
            options => options.EnableRetryOnFailure());
    }

        
        
        public DbSet<Reservation>Reservations{get; set;}

        public DbSet<Restaurant>Restaurants{get; set;}

        public DbSet<User>Users{get; set;}

        


        


     }

}