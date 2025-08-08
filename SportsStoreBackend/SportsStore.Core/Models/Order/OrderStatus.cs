using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsStore.Core.Models.Order
{
    public enum OrderStatus
    {
        Pending,    
        Paid,       
        Shipped,    
        Delivered,  
        Cancelled
    }
}
