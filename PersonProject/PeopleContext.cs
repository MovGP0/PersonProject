using PersonProject.Model;

namespace PersonProject
{
    using System.Data.Entity;

    public class PeopleContext : DbContext
    {
        public PeopleContext() : base("name=People")
        {
        }

        public virtual IDbSet<Person> People { get; set; }
    }
}