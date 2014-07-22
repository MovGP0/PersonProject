using System;
using SimpleCqrs.Commanding;

namespace PersonProject.Cqrs
{
    public class CqrsRepository : IDisposable
    {
        private bool _isDisposed;
        private readonly CqrsRuntime _runtime;
        private readonly ICommandBus _commandBus;

        public CqrsRepository()
        {
            _runtime = SetupRuntime();
            _commandBus = _runtime.ServiceLocator.Resolve<ICommandBus>();
        }

        public void Send(ICommand command)
        {
            _commandBus.Send(command);
        }

        public void Dispose()
        {
            if (_isDisposed || _runtime == null)
            {
                return;
            }

            _runtime.Shutdown();
            _runtime.Dispose();
            _isDisposed = true;
        }

        private static CqrsRuntime SetupRuntime()
        {
            var runtime = new CqrsRuntime();
            runtime.Start();
            return runtime;
        }

        
    }
}
