using System;
using System.Threading;
using System.Threading.Tasks;

namespace MongoDB.PublishSubscribe.EventAggregator
{
    public interface IEventAggregator : IDisposable
    {
        /// <summary>
        /// To keep track on messages based on their message id
        /// </summary>
        Guid EventAggregatorId { get; set; }
        /// <summary>
        /// Invoked if an error occurs when publishing the message to a subscriber.
        /// </summary>
        event EventHandler<MessageHubErrorEventArgs> OnError;

        /// <summary>
        /// Registers a callback which is invoked on every message published by the <see cref="IMessageHub"/>.
        /// <remarks>Invoking this method with a new <paramref name="onMessage"/>overwrites the previous one.</remarks>
        /// </summary>
        /// <param name="onMessage">
        /// The callback to invoke on every message
        /// <remarks>The callback receives the type of the message and the message as arguments</remarks>
        /// </param>
        Task RegisterGlobalHandler(Action<Type, object> onMessage, CancellationToken cancellationToken);

        /// <summary>
        /// Publishes the <paramref name="message"/> on the <see cref="IMessageHub"/>.
        /// </summary>
        /// <param name="message">The message to published</param>
        Task Publish<T>(T message, CancellationToken cancellationToken);

        /// <summary>
        /// Subscribes a callback against the <see cref="IMessageHub"/> for a specific type of message.
        /// </summary>
        /// <typeparam name="T">The type of message to subscribe to</typeparam>
        /// <param name="action">The callback to be invoked once the message is published on the <see cref="IMessageHub"/></param>
        /// <returns>The token representing the subscription</returns>
        Task<Guid> Subscribe<T>(Action<T> action, CancellationToken cancellationToken);

        /// <summary>
        /// Subscribes a callback against the <see cref="MessageHub"/> for a specific type of message.
        /// </summary>
        /// <typeparam name="T">The type of message to subscribe to</typeparam>
        /// <param name="action">The callback to be invoked once the message is published on the <see cref="MessageHub"/></param>
        /// <param name="throttleBy">The <see cref="TimeSpan"/> specifying the rate at which subscription is throttled</param>
        /// <returns>The token representing the subscription</returns>
        Task<Guid> Subscribe<T>(Action<T> action, TimeSpan throttleBy, CancellationToken cancellationToken);

        /// <summary>
        /// Un-Subscribes a subscription from the <see cref="IMessageHub"/>.
        /// </summary>
        /// <param name="token">The token representing the subscription</param>
        Task UnSubscribe(Guid token, CancellationToken cancellationToken);

        /// <summary>
        /// Checks if a specific subscription is active on the <see cref="IMessageHub"/>.
        /// </summary>
        /// <param name="token">The token representing the subscription</param>
        /// <returns><c>True</c> if the subscription is active otherwise <c>False</c></returns>
        Task<bool> IsSubscribed(Guid token, CancellationToken cancellationToken);

        /// <summary>
        /// Clears all the subscriptions from the <see cref="IMessageHub"/>.
        /// <remarks>The global handler and the <see cref="OnError"/> are not affected</remarks>
        /// </summary>
        Task ClearSubscriptions( CancellationToken cancellationToken);
    }
}