using System.ComponentModel.DataAnnotations;

namespace EFCore.Models
{
    public class Author
    {
        public int Id { get; set; }

        [Required ,MaxLength(50)]
        public string FirstName { get; set; }

        [Required ,MaxLength(50)]
        public string LastName { get; set; }
    }
}
