using PersonProject.Cqrs.Commands;
using SimpleCqrs.Commanding;
using SimpleCqrs.Domain;

namespace PersonProject.Cqrs.CommandHandlers
{
    public class CreatePersonCommandHandler : CommandHandler<CreatePersonCommand>
    {
        private readonly IDomainRepository _domainRepository;

        public CreatePersonCommandHandler(IDomainRepository domainRepository)
        {
            _domainRepository = domainRepository;
        }

        public override void Handle(CreatePersonCommand command)
        {
            var aggregate = new PersonAggregate();
            aggregate.CreatePerson(command.FirstName, command.LastName);
            _domainRepository.Save(aggregate); // events in aggregate are published on save
        }
    }
}
