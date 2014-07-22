using SimpleCqrs.Commanding;

namespace PersonProject.Cqrs.Commands
{
    public class CreatePersonCommand : ICommand
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public CreatePersonCommand(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}