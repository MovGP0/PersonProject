using System;
using SimpleCqrs.Eventing;

namespace PersonProject.Cqrs.DomainEvents
{
    public class PersonCreatedEvent : DomainEvent
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public PersonCreatedEvent(Guid aggregateRootId, string firstName, string lastName)
        {
            AggregateRootId = aggregateRootId;
            Sequence = 0;
            EventDate = DateTime.UtcNow;

            FirstName = firstName;
            LastName = lastName;
        }
    }
}