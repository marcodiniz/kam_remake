using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kam.Domain.Base
{
    public interface IEntityBase
    {
        long Id { get; set; }
        string ConcurrencyStamp { get; set; }
        Type GetEntityType();
    }

    public abstract class EntityBase : IEntityBase
    {
        public long Id { get; set; }
        public virtual string ConcurrencyStamp { get; set; }

        public abstract Type GetEntityType();
    }

    public class EntityBase<T> : EntityBase where T:EntityBase<T>
    {
        public override Type GetEntityType()
        {
            return typeof (T);
        }
    }
}
