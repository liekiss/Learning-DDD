using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public abstract class EntityBaseGuid : EntityBase<Guid>
    {
        protected EntityBaseGuid(Guid id)
            : base(id)
        {

        }
    }
}
