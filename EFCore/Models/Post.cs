namespace EFCore.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }


        // EF Core Will Create A Foreign Key  BlogId Automatically -- Shadow Property
        public Blog Blog { get; set; }

       
    }
}
