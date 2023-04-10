using System.ComponentModel.DataAnnotations;

namespace TestApi.Models
{
    public class Enrollment
    {
        public int Id { get; set; }
        [Required]
        public int StudentId { get; set; }
        [Required]
        public int ModuleId { get; set; }

        [DataType(DataType.Date)]
        public DateTime EnrollmentDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime? FinalDate { get; set; }

        public double? Results { get; set; }
        [DataType(DataType.Date)]
        public Module? module { get; set; }
        public Student? student { get; set; }
    }
}
