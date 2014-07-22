using System;
using SimpleCqrs.Commanding;

namespace PersonProject.Cqrs.Commands
{
    public class UpdatePersonCommand : ICommand
    {
        public long Id { get; private set; }
        public string NewFirstName { get; private set; }
        public string NewLastName { get; private set; }

        public UpdatePersonCommand(long id, string newFirstName, string newLastName)
        {
            if (id <= 0)
            {
                var message = string.Format("Must be larger than 0, but was {0}.", id);
                throw new ArgumentOutOfRangeException("id", message);
            }

            Id = id;
            NewFirstName = newFirstName;
            NewLastName = newLastName;
        }
    }
}