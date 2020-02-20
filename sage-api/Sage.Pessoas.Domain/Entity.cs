
using System;

namespace Sage.Pessoas.Domain
{
    public abstract class Entity
    {
        public Guid Id { get; protected set; }
    }
}
