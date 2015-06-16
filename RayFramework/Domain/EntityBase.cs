using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Domain
{
    public abstract class EntityBase<TKey>
    {
        protected EntityBase(TKey id)
        {
            this.Id = id;
        }

        [Required]
        public TKey Id { get; private set; }
    }
}
