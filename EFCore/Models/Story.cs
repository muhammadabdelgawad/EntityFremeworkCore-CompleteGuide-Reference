namespace EFCore.Models
{
    public class Story
    {
        public int Id { get; set; }
        public string Title { get; set; }

        /// Navigation Property -- EFCore will create a new table StoryTag to represent the many-to-many relationship between Story and Tag
        public ICollection<Tag> Tags { get; set; } /// Many to many RelationShip 

        //public List<StoryTag> StoryTags { get; set; } //-- To add New Table Manually
    }
}
