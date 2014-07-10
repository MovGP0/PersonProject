using System.Data.Entity;

namespace PersonProject.Model
{
  
    public class PeopleContext : DbContext
    {
        public PeopleContext() : base("name=People")
        {
        }

        public virtual IDbSet<Person> People { get; set; }
    }
}