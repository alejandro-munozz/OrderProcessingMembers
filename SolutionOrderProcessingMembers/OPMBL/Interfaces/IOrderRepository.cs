using OPMBL.Model.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPMBL.Interfaces
{
    public interface IOrderRepository
    {
        List<Order> GetOrders();
        Order SaveOrder(Order order);
    }
}
