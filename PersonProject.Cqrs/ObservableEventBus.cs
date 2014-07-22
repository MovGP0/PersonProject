using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Reactive.Disposables;
using Microsoft.Practices.ObjectBuilder2;
using SimpleCqrs.Eventing;

namespace PersonProject.Cqrs
{
    public class ObservableEventBus : IEventBus, IObservable<DomainEvent>
    {
        private ImmutableList<IObserver<DomainEvent>> _observers = ImmutableList<IObserver<DomainEvent>>.Empty;

        public void PublishEvent(DomainEvent domainEvent)
        {
            _observers.ForEach(observer => observer.OnNext(domainEvent));
        }

        public void PublishEvents(IEnumerable<DomainEvent> domainEvents)
        {
            _observers.AsParallel().ForEach(observer =>
            {
                foreach (var domainEvent in domainEvents)
                {
                    observer.OnNext(domainEvent);
                }
            });
        }

        public IDisposable Subscribe(IObserver<DomainEvent> observer)
        {
            _observers = _observers.Add(observer);
            return Disposable.Create(() => _observers = _observers.Remove(observer));
        }
    }
}