using blazor_todo_list_app.Entities.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Context
{
    public class ToDoContext : DbContext
    {
        #region constructor
        public ToDoContext(DbContextOptions<ToDoContext> options)
     : base(options)
        {

        }
        #endregion

        #region overriden methods
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("sqlconnection");
            optionsBuilder.UseSqlServer(connectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Comment>()
                .HasOne(c => c.User)
                .WithMany(u => u.Comments)
                .HasForeignKey(c => c.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Task_>()
                .HasOne(a => a.Comment)
                .WithOne(b => b.Task)
                .HasForeignKey<Comment>(e => e.Id);

            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ToDoContext).Assembly);
        }
        #endregion

        #region entities
        public DbSet<User> Users { get; set; }
        public DbSet<Task_> Tasks { get; set; }
        public DbSet<SubTask> SubTasks { get; set; }
        public DbSet<Comment> Comments { get; set; }
        #endregion
    }
}