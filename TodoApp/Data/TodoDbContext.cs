using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;
using System;
using TodoApp.Models;
using TodoApp.Data.ModelTableMapping;
using static System.Net.Mime.MediaTypeNames;

namespace TodoApp.Data
{
    public class TodoDbContext : DbContext
    {
        //manage and define the database and structure of the database

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //where DB SERVER?
            //Connection string -> db server connection details
            //optionsBuilder.UseSqlServer();
            

            string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=TodoDb;Integrated Security=True";
            optionsBuilder.UseSqlServer(connectionString);
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modification of model
            //fluent API
            modelBuilder.UserModel();

            //seed basic data
            //administrator user in user table
          

            modelBuilder.Entity<Todo>().HasData(
                new Todo(1, "Shopping", "For Birthday", false, DateTime.Now.AddDays(1)),
                new Todo(2, "Learn C#", "In Jump Trainin", false, DateTime.Now.AddDays(2)),
                new Todo(3, "Learn MSSQL", "In Jump Trainin", false, DateTime.Now.AddDays(2))
            );



            base.OnModelCreating(modelBuilder);

        }
        public DbSet<Todo> Todos { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
