using HomeClothing.Model.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeClothing.Data
{
    public class HomeClothingContext : DbContext
    {
        public HomeClothingContext(DbContextOptions<HomeClothingContext> options)
            : base(options) { }


        public DbSet<User> Users { get; set; }
    }
}
