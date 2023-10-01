using System.ComponentModel.DataAnnotations;

namespace TwitterAppGabriel.Entities
{
    public class User
    {
        public int UserId { get; set; }

        [Required, MaxLength(20, ErrorMessage = "Name cannot have more then 20 characters")]
        public string Name { get; set; }

        [EmailAddress]
        [Required, MaxLength(40)]
        public string EmailAddress { get; set; }

        [Required, MaxLength(100, ErrorMessage = "Bio cannot have more then 100 characters")]
        public string Bio { get; set; }

        [Required, MaxLength(100, ErrorMessage = "Tweet cannot have more then 20 characters")]
        public string Tweet { get; set; }

        [Required, MaxLength(100, ErrorMessage = "Comment cannot have more then 20 characters")]
        public string Comment { get; set; }
    }
}