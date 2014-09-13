using System;
using System.Collections.Generic;
using System.Linq;
using PersonProject.Database.Service.Model;

namespace PersonProject.Database.Service.Myservice.V1
{
    public class PersonService : IPersonService
    {
        private static readonly Lazy<PeopleEntities> Context = new Lazy<PeopleEntities>();

        public IEnumerable<Model.Person> GetAll()
        {
            var peoples = Context.Value.People.ToList();
            return peoples.Select(p => new Model.Person(p.Id, p.FirstName, p.LastName));
        }

        public Model.Person GetById(long id)
        {
            return Context.Value.GetPersonById(id)
                .Select(p => new Model.Person(id, p.FirstName, p.LastName) )
                .DefaultIfEmpty(new Model.Person())
                .SingleOrDefault();
        }
    }
}
