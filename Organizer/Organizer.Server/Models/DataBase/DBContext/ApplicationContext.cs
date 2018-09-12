using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Organizer.Server.Models.DataBase.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Organizer.Server.Models.DataBase.DBContext
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options, IConfiguration configuration)
            : base(options)
        {
            Configuration = configuration;
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
