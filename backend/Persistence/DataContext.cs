using System;
using Domain;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Reservation> Reservations { get; set; }

        public DbSet<Restaurant> Restaurants { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Media> Medias { get; set; }
    }
}
