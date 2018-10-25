using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Organizer.Server.DAL.Attributes;
using Organizer.Server.Models.DataBase.Entities;
using Organizer.Server.Models.DataBase.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Organizer.Server.Models.DataBase.DBContext
{
    [ApplicationService]
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Meeting>()
                .Property(b => b.Type)
                .HasDefaultValue(EntityType.Meeting);

            modelBuilder.Entity<Note>()
                .Property(b => b.Type)
                .HasDefaultValue(EntityType.Note);

            modelBuilder.Entity<Task>()
                .Property(b => b.Type)
                .HasDefaultValue(EntityType.Task);
        }

        private IConfiguration Configuration { get; }

        public DbSet<Meeting> Meetings { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<Task> Tasks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            var connection = Configuration["ConnectionStrings:DefaultConnection"];
            builder.UseSqlServer(connection);
        }
    }
}
