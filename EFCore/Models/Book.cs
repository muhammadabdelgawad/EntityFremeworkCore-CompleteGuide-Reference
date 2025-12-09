using System.ComponentModel.DataAnnotations;

namespace EFCore.Models
{
    public class Book
    {
        /// -- Specify Primary Key Using Data Annotations
        //[Key]
        public int Id { get; set; } // If you don't specify, EF Core will treat 'Id' Or 'BookId' as the primary key by convention
        public string Name { get; set; }
        public string Author { get; set; }
    }
}
