using EFCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace EFCore.Configurations
{
    public class BlogConfiguration : IEntityTypeConfiguration<Blog>
    {
        public void Configure(EntityTypeBuilder<Blog> builder)
        {
            #region Required
            //builder.Property(b => b.Url)
            //    .IsRequired(); 
            #endregion

            #region  change the default schema using Fluent API 

            // builder.ToTable("Blogs", "TestNewSchema");

            #endregion

            #region Change Column Name & Type By Fluent Api

            // builder.Property(b => b.Url).HasColumnName("NewChangeNameOfColumn")
            //                             .HasColumnType("nvarchar(200)");

            #endregion

            #region HasMaxLength 

            //builder.Property(b => b.Url).HasMaxLength(50);

            #endregion

            #region Add Comment to Table and Column Using Fluent API

            // builder.Property(b => b.Url).HasComment("This is the URL of the blog");

            #endregion

            #region Specify Primary and change Key Name  Using  Fluent API

            //builder.HasKey(b => b.Id).HasName("NewNameOfPrimaryKey");

            #endregion

            #region Set Composite Key Using Fluent API

            //builder.HasKey(b => new { b.Id, b.Url });

            #endregion

            #region Set Default Value & HasDefaultValueSql  Using Fluent API

            // builder.Property(b => b.Rating).HasDefaultValue(3).HasDefaultValueSql("GETDATE()");

            #endregion


            #region Configure One-to-One Relationship Between Blog and BlogImage Using Fluent API

            //builder.HasOne(b => b.BlogImage)
            //       .WithOne(bi => bi.Blog)
            //       .HasForeignKey<BlogImage>(b => b.BlogId);

            #endregion


            #region Configure One-To-Many Relationship Between Blog and Post Using Fluent API

            //builder.HasMany(b => b.Posts)
            //       .WithOne();


            #endregion

            #region  Create Index on Url column Using Fluent API

            // builder.HasIndex(b => b.Url); 

            // builder.HasIndex(b => new { b.Url, b.Rating }); // Composite Index

            // builder.HasIndex(b => b.Url).HasDatabaseName("Index_Test"); // Custom Index Name

            // builder.HasIndex(b => b.Url).HasFilter("[Url IS NOT NULL"); // Filtered Index 

           // builder.HasIndex(b => b.Url).IsUnique(); // Unique Index

            //builder.HasIndex(b => b.Url)
            //       .IsUnique()
            //       .HasFilter(null); // Unique Index without filter
            #endregion








        }
    }
}
