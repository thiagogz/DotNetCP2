using System.ComponentModel.DataAnnotations;

namespace DotNetCP2.DTOs
{
    public class LoginDTO
    {
        [Required]
        [EmailAddress]
        public string UserEmail { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string UserPassword { get; set; }
    }
}
