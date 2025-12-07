using EFCore.Configurations;
using EFCore.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
namespace EFCore
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder/*.UseLazyLoadingProxies()*/ //  Enable Lazy Loading   
            .UseSqlServer(@"Server = MUHAMMAD\SQLEXPRESS;Database=EFCore;Trusted_Connection=True;TrustServerCertificate=True;" // Add your connection string here 
             /*,o => o.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery)*/); // Enable SplitQuery for all queries "Make It Default Behavior for EF Core"  

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());


            #region AnOther Way to Apply Configuration One by One [ Not Recommended ]
            ///-- Apply Configuration For Each Entity Separately In Seperate Class File "Best practice"
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

            #region Configure One-To-Many Relationship 

            //************************* First Way *********************************************
            //Between Blog and Post Using Fluent API

            //modelBuilder.Entity<Post>()
            //            .HasOne(p => p.Blog)     // Each Post has one Blog
            //            .WithMany(b => b.Posts); // Each Blog has many Posts

            //************************* Another Way *********************************************
            /// Another Way If Navigation Property is Missing
            // modelBuilder.Entity<Post>().HasOne<Blog>()
            //             .WithMany()
            //             .HasForeignKey(p => p.Blog)
            //             .HasConstraintName("FK_Posts_Test"); // To specify custom foreign key Name 


            //************************* Between Car and RecordOfSale Using Fluent API *********************************************

            //modelBuilder.Entity<RecordOfSale>()
            //            .HasOne(s=>s.Car)
            //            .WithMany(c=>c.SaleHistory)
            //            .HasForeignKey(s=>s.CarLicensePlate) 
            //            .HasPrincipalKey(c=>c.LicensePlate);

            #endregion

            #region Configure Many-To-Many Relationship Manually "To Create New Table"

            //modelBuilder.Entity<Story>()
            //    .HasMany(s => s.Tags)
            //    .WithMany(t => t.Stories)
            //    .UsingEntity(x => x.ToTable("StoryTagTest"));


            /// -- Configure many-to-many RelationShip with Creat Third Table Manually
            //modelBuilder.Entity<Story>()
            //    .HasMany(s => s.Tags)
            //    .WithMany(t => t.Stories)
            //    .UsingEntity<StoryTag>(
            //    x => x.HasOne(st => st.Tag)
            //         .WithMany(t => t.StoryTags)
            //         .HasForeignKey(st => st.TagId),

            //    x => x.HasOne(st => st.Story)
            //         .WithMany(s => s.StoryTags)
            //         .HasForeignKey(st => st.StoryId),
            //    x =>
            //    {
            //        x.Property(st => st.AddedOn).HasDefaultValueSql("GETDATE()");
            //        x.HasKey(s=> new { s.TagId ,s.StoryId});
            //    }
            //   );

            #endregion

            #region Configure Sequence Using Fluent API

            //modelBuilder.HasSequence<int>("OrderNumber");

            //modelBuilder.Entity<Order>()
            //    .Property(o => o.OrderNo)
            //    .HasDefaultValueSql("NEXT VALUE FOR OrderNumber"); // will get the next value from the sequence
            #endregion

            #region Data Seeding Using Fluent API

            //modelBuilder.Entity<Blog>().HasData(
            //    new Blog { Id = 5, Url = "https://example.com/blog1" },
            //    new Blog { Id = 6, Url = "https://example.com/blog2" },
            //    new Blog { Id = 7, Url = "https://example.com/blog3" },
            //    new Blog { Id = 8, Url = "https://example.com/blog4" },
            //    new Blog { Id = 9, Url = "https://example.com/blog5" }
            //);

            #endregion

            #region Global Query Filter

            modelBuilder.Entity<Order>().HasQueryFilter(o => !o.IsDeleted); // Global Query Filter to Exclude Soft Deleted Records

            #endregion      

        }
            /// -- Add DbSet for Each Entity 
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogImage> BlogImages { get; set; }
        public DbSet<AuditEntry> AuditEntries { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Stock> Stocks { get; set; }
    }
}
