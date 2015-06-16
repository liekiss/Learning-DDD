using System.ComponentModel.DataAnnotations;


namespace Domain
{
    public abstract class EntityBase<TKey>
    {
        protected EntityBase(TKey id)
        {
            Id = id;
        }

        [Required]
        public TKey Id { get; private set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (!(obj is EntityBase<TKey>))
                return false;
            return this == (EntityBase<TKey>)obj;
        }

        /// <summary>
        /// 根据实体标识Id获取hash
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        /// <summary>
        /// 相等比较
        /// </summary>
        /// <param name="entity1">领域实体1</param>
        /// <param name="entity2">领域实体2</param>
        public static bool operator ==(EntityBase<TKey> entity1, EntityBase<TKey> entity2)
        {
            if ((object)entity1 == null && (object)entity2 == null)
                return true;
            if ((object)entity1 == null || (object)entity2 == null)
                return false;
            if (entity1.Id == null)
                return false;
            if (entity1.Id.Equals(default(TKey)))
                return false;
            return entity1.Id.Equals(entity2.Id);
        }

        /// <summary>
        /// 不相等比较
        /// </summary>
        /// <param name="entity1">领域实体1</param>
        /// <param name="entity2">领域实体2</param>
        public static bool operator !=(EntityBase<TKey> entity1, EntityBase<TKey> entity2)
        {
            return !(entity1 == entity2);
        }
    }
}
