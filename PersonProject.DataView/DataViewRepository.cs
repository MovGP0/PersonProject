using System;
using System.Collections.Generic;
using AutoMapper;
using PersonProject.DataView.PersonService;
using Person = PersonProject.Model.Person;

namespace PersonProject.DataView
{
    public class DataViewRepository : IDisposable
    {
        public DataViewRepository()
        {
            Service = new personServiceClient();
            Service.Open();
        }

        private personServiceClient Service { get; set; }

        private bool _isDesposed;
        public void Dispose()
        {
            if (_isDesposed || Service == null) return;

            Service.Close();
            _isDesposed = true;
        }

        public IEnumerable<Person> GetAll()
        {
            return Mapper.Map<IEnumerable<Person>>(Service.getAll());
        }

        public Person GetById(long id)
        {
            return Mapper.Map<Person>(Service.getById(id));
        }
    }
}
