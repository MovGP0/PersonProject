using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonProject.Model
{
    [Table("People")]
    public class Person
    {
        [Obsolete]
        public Person()
        {
        }

        public Person(int id, string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
        }

        [Key]
        public int Id { get; set; }

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
