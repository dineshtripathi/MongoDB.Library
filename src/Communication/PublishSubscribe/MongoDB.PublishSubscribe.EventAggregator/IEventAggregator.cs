using System;

namespace MongoDB.PublishSubscribe.EventAggregator
{
    public interface IEventAggregator
    {
        Guid EventAggregatorId { get; set; }
    }
}