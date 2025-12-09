using System.ComponentModel.DataAnnotations.Schema;

namespace EFCore.Models
{

    public class Blog
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public int Rating { get; set; }

        // Navigation property for one-to-one relationship with BlogImage
        // Each blog can have exactly one associated image
        public BlogImage BlogImage { get; set; } 

        public List<Post> Posts { get; set; }
    }
}
