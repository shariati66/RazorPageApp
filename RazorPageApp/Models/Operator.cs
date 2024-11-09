using System.ComponentModel.DataAnnotations;

namespace RazorPageApp.Models
{
    public class Operator
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}





