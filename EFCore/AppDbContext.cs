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


            #region AnOther Way to Apply Configuration One by One [ Not Recommended ]

            // new BlogConfiguration().Configure(modelBuilder.Entity<Blog>()); 

            #endregion

            #region Ignore AuditEntry from mapping will not create table in DataBase

            // modelBuilder.Ignore<AuditEntry>(); 

            #endregion

            #region Exclude AuditEntry from Migrations, AuditEntry will create table in DataBase but will not be tracked in Migrations

            //modelBuilder.Entity<AuditEntry>().ToTable("AuditEntries", a => a.ExcludeFromMigrations());

            #endregion

            #region Rename Table Using Fluent API

            //modelBuilder.Entity<AuditEntry>().ToTable("AuditEntriesForTestRename"); 

            #endregion

            #region  Change Default Schema for All Tables

            //  modelBuilder.HasDefaultSchema("TestNewSchema"); 

            #endregion

            #region  EFCore View =>  supports read-only entities that are mapped to database views
            // modelBuilder.Entity<Employee>().ToView("EmployeesView");  
            #endregion

            #region Add Computed Column
            //modelBuilder.Entity<Author>().Property(a => a.DisplayName)
            //                                 .HasComputedColumnSql("[FirstName] + ' ' + [LastName]");
            #endregion

            #region another way to configure the primary Default Value if isnot int value key with identity using Fluent API
           
            //modelBuilder.Entity<Category>()
            //             .Property(c => c.Id)
            //             .ValueGeneratedOnAdd();

            #endregion





        }
        /// -- Add DbSet for Each Entity
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<AuditEntry> AuditEntries { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
