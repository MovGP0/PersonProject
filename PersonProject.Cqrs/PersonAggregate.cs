using System;
using PersonProject.Cqrs.DomainEvents;
using SimpleCqrs.Domain;

namespace PersonProject.Cqrs
{
    public class PersonAggregate : AggregateRoot
    {
        public void CreatePerson(string firstName, string lastName)
        {
            var personEvent = new PersonCreatedEvent(Guid.NewGuid(), firstName, lastName);
            Apply(personEvent);
        }

        public void DeletePerson(long id)
        {
            var personEvent = new PersonDeletedEvent(Guid.NewGuid(), id);
            Apply(personEvent);
        }

        public void UpdatePerson(long id, string newFirstName, string newLastName)
        {
            var personEvent = new PersonUpdatedEvent(Guid.NewGuid(), id, newFirstName, newLastName);
            Apply(personEvent);
        }
    }
}