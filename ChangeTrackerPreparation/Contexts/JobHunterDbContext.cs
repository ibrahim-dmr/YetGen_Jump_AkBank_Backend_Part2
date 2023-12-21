using ChangeTrackerPreparation.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeTrackerPreparation.Contexts
{
    internal class JobHunterDbContext : DbContext
    {
        public DbSet<JobPost> JobPosts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=localhost:5432;Port=5432;Database=JobHunter;User Id=postgres;Password=admin;");
        }
    }
}
