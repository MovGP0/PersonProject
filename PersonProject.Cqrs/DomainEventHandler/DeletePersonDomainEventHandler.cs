using PersonProject.Cqrs.DomainEvents;
using PersonProject.Database;
using SimpleCqrs.Eventing;

namespace PersonProject.Cqrs.DomainEventHandler
{
    public class DeletePersonDomainEventHandler : IHandleDomainEvents<PersonDeletedEvent>
    {
        public void Handle(PersonDeletedEvent domainEvent)
        {
            using (var context = new PeopleEntities())
            {
                context.DeletePerson(domainEvent.Id);
            }
        }
    }
}