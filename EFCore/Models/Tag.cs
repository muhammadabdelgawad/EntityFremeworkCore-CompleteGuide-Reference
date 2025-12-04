namespace EFCore.Models
{
    public class Tag
    {
        public int TagId { get; set; }

        /// Navigation Property -- EFCore will create a new table StoryTag to represent the many-to-many relationship between Story and Tag
        public ICollection<Story> Stories { get; set; } // Many-to-Many Relationship

       // public List<StoryTag> StoryTags { get; set; } //-- To add New Table Manually

           
       
    }

    /// -- Add Third Table Manually 
    //public class StoryTag
    //{
    //    public int TagId { get; set; }

    //    public Tag Tag { get; set; }
    //    public Story Story { get; set; }
    //    public int StoryId { get; set; }
    //    public DateTime AddedOn { get; set; }

    //}
}
