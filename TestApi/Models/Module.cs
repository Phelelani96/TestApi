using System.ComponentModel.DataAnnotations;

namespace TestApi.Models
{
    public class Module
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public ICollection<Enrollment>? enrollments { get; set; }

    }
}
