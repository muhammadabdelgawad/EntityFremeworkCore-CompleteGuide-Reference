using System.ComponentModel.DataAnnotations;

namespace EFCore.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required,MaxLength(100)]
        public string Name { get; set; }
    }
}
