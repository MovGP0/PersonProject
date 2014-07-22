using System;
using SimpleCqrs.Eventing;

namespace PersonProject.Cqrs.DomainEvents
{
    public class PersonDeletedEvent : DomainEvent
    {
        public long Id { get; set; }

        public PersonDeletedEvent(Guid aggregateRootId, long id )
        {
            AggregateRootId = aggregateRootId;
            Sequence = 0;
            EventDate = DateTime.UtcNow;

            Id = id;
        }
    }
}