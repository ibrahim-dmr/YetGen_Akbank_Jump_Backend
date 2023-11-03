using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFCore_InMemoryExercises.Entities;
using Microsoft.EntityFrameworkCore;

namespace EFCore_InMemoryExercises.Persistence
{
    public class DataDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("DataDbContext");
        }
    }
}
