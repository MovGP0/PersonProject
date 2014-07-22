using PersonProject.Cqrs.DomainEvents;
using PersonProject.Database;
using SimpleCqrs.Eventing;

namespace PersonProject.Cqrs.DomainEventHandler
{
    public class CreatePersonDomainEventHandler : IHandleDomainEvents<PersonCreatedEvent>
    {
        public void Handle(PersonCreatedEvent domainEvent)
        {
            using (var context = new PeopleEntities())
            {
                context.CreatePerson(domainEvent.FirstName, domainEvent.LastName);
            }
        }
    }
}