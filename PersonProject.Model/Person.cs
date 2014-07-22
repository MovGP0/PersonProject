using System.ComponentModel.DataAnnotations;

namespace PersonProject.Model
{
    public class Person
    {
        public Person()
        {
            Id = -1;
            FirstName = string.Empty;
            LastName = string.Empty;
        }

        public Person(long id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }

        [Range(0, long.MaxValue)]
        public long Id { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(255)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required, MinLength(2), MaxLength(255)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
    }
}
