using System.ComponentModel.DataAnnotations;

namespace TestApi.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string FullName 
        {
            get
            {
                return FirstName + " " + LastName ; 
            }
        }
        [Required]
        public int Age { get; set; }
        public ICollection<Enrollment>? enrollments { get; set; }
    }
}
