using System.ComponentModel.DataAnnotations;

namespace DotNetCP2.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        public string UserName { get; set; }

        public string UserEmail { get; set; }

        public string UserPassword { get; set; }
    }
}
