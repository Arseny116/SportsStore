using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportsStore.Core.Models.ProductM;

namespace SportsStore.Core.Models.Order
{
    public class Order
    {
        public Guid Id { get; }

        public List<Product> Basket{ get; } = new List<Product>();

        public OrderStatus Status { get; }

        public string Email { get; } = string.Empty;


    }
}
