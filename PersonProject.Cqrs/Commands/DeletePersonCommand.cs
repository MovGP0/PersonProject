using SimpleCqrs.Commanding;

namespace PersonProject.Cqrs.Commands
{
    public class DeletePersonCommand : ICommand
    {
        public long Id { get; private set; }

        public DeletePersonCommand(long id)
        {
            Id = id;
        }
    }
}