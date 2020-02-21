using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain
{
    public abstract class AggregateRoot : Entity
    {
        private readonly ISet<IEvent> _events = new HashSet<IEvent>();
        public virtual IEnumerable<IEvent> Events => _events;

        protected void AddEvent(IEvent @event) => _events.Add(@event);

        protected AggregateRoot() { }

        protected AggregateRoot(Guid id) : base(id)
        {

        }
    }
}
