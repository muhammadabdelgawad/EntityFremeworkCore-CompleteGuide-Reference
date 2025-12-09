namespace EFCore.Models
{
    public class BlogImage
    {
        public int Id { get; set; }
        public byte[] Image { get; set; }
        public string Caption { get; set; }

        // Foreign Key to Blog
        public int BlogId { get; set; }
        public Blog Blog { get; set; } // Navigation property
    }
}
