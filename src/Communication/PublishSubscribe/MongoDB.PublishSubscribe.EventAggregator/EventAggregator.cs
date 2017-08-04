using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongoDB.PublishSubscribe.EventAggregator
{
    public class EventAggregator:IEventAggregator
    {
        public EventAggregator()
        {
        }

        public Guid EventAggregatorId { get; set; }
    }
}
