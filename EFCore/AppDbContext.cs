using EFCore.Configurations;
using EFCore.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
namespace EFCore
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer(@"Server = MUHAMMAD\SQLEXPRESS;Database=EFCore;Trusted_Connection=True;TrustServerCertificate=True;");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            
            /// --AnOther Way to Apply Configuration One by One [ Not Recommended ]
            // new BlogConfiguration().Configure(modelBuilder.Entity<Blog>()); 
           
            /// -- Ignore AuditEntry from mapping will not create table in DataBase
            // modelBuilder.Ignore<AuditEntry>(); 

            /// -- Exclude AuditEntry from Migrations, AuditEntry will create table in DataBase but will not be tracked in Migrations
            //modelBuilder.Entity<AuditEntry>().ToTable("AuditEntries", a => a.ExcludeFromMigrations());
            
            /// -- Rename Table Using Fluent API
            //modelBuilder.Entity<AuditEntry>().ToTable("AuditEntriesForTestRename");


        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<AuditEntry> AuditEntries { get; set; }
        public DbSet<Post> Posts { get; set; }

    }
}
