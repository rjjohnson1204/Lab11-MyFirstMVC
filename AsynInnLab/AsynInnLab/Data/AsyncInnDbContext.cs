using AsynInnLab.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsynInnLab.Data
{
    public class AsyncInnDbContext : DbContext
    {
        public AsyncInnDbContext(DbContextOptions<AsyncInnDbContext>options): base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //add our composite key associations
        }

        public DbSet<Amenities> Amenities { get; set; }
        public DbSet<Hotel> Hotel { get; set; }
        public DbSet<HotelRoom> HotelRoom { get; set; }
        public DbSet<Room> Room { get; set; }
        public DbSet<RoomAmenities> RoomAmenities { get; set; }



    }

}
