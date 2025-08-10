using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportsStore.Core.Models.Order;
using SportsStore.Core.Models.ProductM;

namespace SportsStore.DataAccess.Entities
{
    public class OrderEntities
    {
        public Guid Id { get; }

        public List<ProductEntities> Products { get; } = new List<ProductEntities>();

        public OrderStatus Status { get; }


        public string Email { get; } = string.Empty;
    }
}
