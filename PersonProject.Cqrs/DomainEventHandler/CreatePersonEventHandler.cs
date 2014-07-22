using PersonProject.Cqrs.DomainEvents;
using PersonProject.Database;
using SimpleCqrs.Eventing;

namespace PersonProject.Cqrs.DomainEventHandler
{
    public class UpdatePersonDomainEventHandler : IHandleDomainEvents<PersonUpdatedEvent>
    {
        public void Handle(PersonUpdatedEvent domainEvent)
        {
            using (var context = new PeopleEntities())
            {
                context.UpdatePerson(domainEvent.Id, domainEvent.FirstName, domainEvent.LastName);
            }
        }
    }
}