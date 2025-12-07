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

        [Required, MaxLength(100)]
        public string DisplayName { get; set; }

        public Nationality? Nationality { get; set; }

        public int? NationalityId { get; set; }
    }
}
