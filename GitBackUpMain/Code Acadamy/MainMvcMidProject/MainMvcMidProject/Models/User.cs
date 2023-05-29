using System.ComponentModel.DataAnnotations;

namespace MainMvcMidProject.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? UserName { get; set; }
        [Required]
        public string? Info { get; set; }

    }
}
