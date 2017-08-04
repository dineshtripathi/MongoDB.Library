using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MongoDB.PublishSubscribe.EventAggregator
{
    public class EventAggregator:IEventAggregator
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Guid EventAggregatorId { get; set; }
        public event EventHandler<MessageHubErrorEventArgs> OnError;
        public async Task RegisterGlobalHandler(Action<Type, object> onMessage, CancellationToken cancellationToken)
        {
            await Task.FromResult(new NotImplementedException());
        }

        public async Task Publish<T>(T message,CancellationToken cancellationToken)
        {
            await Task.FromResult(new NotImplementedException());
        }

        public async Task<Guid> Subscribe<T>(Action<T> action, CancellationToken cancellationToken)
        {
            return await Task.FromResult(new Guid());
        }

        public async Task<Guid> Subscribe<T>(Action<T> action, TimeSpan throttleBy, CancellationToken cancellationToken)
        {
            return await Task.FromResult(new Guid());
        }

        public async Task UnSubscribe(Guid token, CancellationToken cancellationToken)
        {
             await Task.FromResult(new Guid());
        }

        public async Task<bool> IsSubscribed(Guid token, CancellationToken cancellationToken)
        {
            return await Task.FromResult(false);
        }

        public async Task ClearSubscriptions( CancellationToken cancellationToken)
        {
             await Task.FromResult(new Guid());
        }
    }
}
