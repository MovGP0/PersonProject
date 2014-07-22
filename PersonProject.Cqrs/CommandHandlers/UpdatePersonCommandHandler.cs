using PersonProject.Cqrs.Commands;
using SimpleCqrs.Commanding;
using SimpleCqrs.Domain;

namespace PersonProject.Cqrs.CommandHandlers
{
    public class UpdatePersonCommandHandler : CommandHandler<UpdatePersonCommand>
    {
        private readonly IDomainRepository _domainRepository;

        public UpdatePersonCommandHandler(IDomainRepository domainRepository)
        {
            _domainRepository = domainRepository;
        }

        public override void Handle(UpdatePersonCommand command)
        {
            var aggregate = new PersonAggregate();
            aggregate.UpdatePerson(command.Id, command.NewFirstName, command.NewLastName);
            _domainRepository.Save(aggregate);
        }
    }
}