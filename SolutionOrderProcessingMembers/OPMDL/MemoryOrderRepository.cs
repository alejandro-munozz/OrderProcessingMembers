using OPMBL.Interfaces;
using OPMBL.Model;
using OPMBL.Model.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPMDL
{
    public class MemoryOrderRepository: IOrderRepository
    {
        private List<Order> Orders = new();
       
        public List<Order> GetOrders()
        {
            return Orders;
        }
        public Order SaveOrder(Order order)
        {
            Orders.Add(order);
            return order;
        }
    }
}
