using PersonProject.Cqrs.Commands;
using SimpleCqrs.Commanding;
using SimpleCqrs.Domain;

namespace PersonProject.Cqrs.CommandHandlers
{
    public class DeletePersonCommandHandler : CommandHandler<DeletePersonCommand>
    {
        private readonly IDomainRepository _domainRepository;

        public DeletePersonCommandHandler(IDomainRepository domainRepository)
        {
            _domainRepository = domainRepository;
        }

        public override void Handle(DeletePersonCommand command)
        {
            var aggregate = new PersonAggregate();
            aggregate.DeletePerson(command.Id);
            _domainRepository.Save(aggregate);
        }
    }
}