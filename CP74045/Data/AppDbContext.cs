using CP74045.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CP74045.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {


        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client_Project>()
                .HasOne(c => c.Client)
                .WithMany(cp => cp.Client_Projects)
                .HasForeignKey(ci => ci.ClientId);

            modelBuilder.Entity<Client_Project>()
                .HasOne(c => c.Project)
                .WithMany(cp => cp.Client_Projects)
                .HasForeignKey(ci => ci.ProjectId);
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Project> Projects { get; set; }

        public DbSet<Client_Project> Client_Projects { get; set; }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Team> Teams { get; set; }

        public DbSet<Project_Team> Project_Teams { get; set; }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Agreement> Agreements { get; set; }

        public DbSet<Asset> Assets { get; set; }
    }
}
