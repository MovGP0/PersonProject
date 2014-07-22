using System;
using SimpleCqrs.Eventing;

namespace PersonProject.Cqrs.DomainEvents
{
    public class PersonUpdatedEvent : DomainEvent
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public PersonUpdatedEvent(Guid aggregateRootId, long id, string newFirstName, string newLastName)
        {
            AggregateRootId = aggregateRootId;
            Sequence = 0;
            EventDate = DateTime.UtcNow;

            Id = id;
            FirstName = newFirstName;
            LastName = newLastName;
        }
    }
}