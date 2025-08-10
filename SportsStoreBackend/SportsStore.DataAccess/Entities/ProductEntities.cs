using SportsStore.Core.Models.ProductM;

namespace SportsStore.DataAccess.Entities
{
    public class ProductEntities
    {
        public const int MAX_LENGTH = 100;
        public Guid Id { get; set; }

        public string Name { get; private set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public Money? Price { get; set; }

        public OrderEntities? Order { get; set; }


        public Guid OrderId { get; set; }

    }
}
