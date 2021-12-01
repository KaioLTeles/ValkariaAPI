namespace Valkaria.Core.Entities
{
    public abstract class BaseEntity
    {
        protected BaseEntity()
        {
        }

        public int Id { get; private set; }
        public DateTime CreatedAt { get; set; }
    }
}
