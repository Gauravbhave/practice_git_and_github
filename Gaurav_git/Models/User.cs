using System.ComponentModel.DataAnnotations;

namespace Gaurav_git.Models
{
    public class User
    {
        [Key]
        public int user_id { get; set; }

        [Required]
        public string user_name { get; set; }

    }
}
