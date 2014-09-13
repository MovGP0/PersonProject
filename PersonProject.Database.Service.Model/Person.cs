using System.Runtime.Serialization;

namespace PersonProject.Database.Service.Model
{
    [DataContract(Name = "person", Namespace = Constants.Namespace)]
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

        [DataMember]
        public long Id { get; set; }

        [DataMember(IsRequired = true, Name="firstName")]
        public string FirstName { get; set; }

        [DataMember(IsRequired = true, Name = "lastName")]
        public string LastName { get; set; }
    }
}
