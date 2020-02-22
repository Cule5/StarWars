using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain
{
    public abstract class AggregateRoot : Entity
    {
        protected AggregateRoot() { }

        protected AggregateRoot(Guid id) : base(id)
        {

        }
    }
}
