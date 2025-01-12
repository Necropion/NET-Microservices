using System.ComponentModel.DataAnnotations;

namespace Authentication.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Password { get; set; }
    }
}

