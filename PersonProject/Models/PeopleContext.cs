using System.Data.Common;
using System.Data.Entity;
using PersonProject.Model;

namespace PersonProject.Models
{
    public class PeopleContext : DbContext
    {
        public PeopleContext() : base("name=People")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<PeopleContext>());
        }

        public PeopleContext(IDatabaseInitializer<PeopleContext> strategy, DbConnection existingConnection, bool contextOwnsConection)
            : base (existingConnection, contextOwnsConection)
        {
            Database.SetInitializer(strategy);
        }
        
        public virtual IDbSet<Person> People { get; set; }
    }
}