using System;
using System.Collections.Generic;
using System.Linq;
using PersonProject.Database;
using Person = PersonProject.Model.Person;

namespace PersonProject.DataView
{
    public class DataViewRepository : IDisposable
    {
        private readonly PeopleEntities _context;

        public DataViewRepository()
        {
            _context = new PeopleEntities();
        }

        public DataViewRepository(PeopleEntities context)
        {
            _context = context;
        }

        public IEnumerable<Person> GetAll()
        {
            var peoples = _context.People.ToList();
            return peoples.Select(p => new Person(p.Id, p.FirstName, p.LastName));
        }

        public Person GetById(long id)
        {
            return _context.GetPersonById(id)
                .Select(p => new Person(id, p.FirstName, p.LastName))
                .DefaultIfEmpty(new Person())
                .SingleOrDefault();
        }

        public void Dispose()
        {
            if (_context == null)
            {
                return;
            }

            _context.Dispose();
        }
    }
}
