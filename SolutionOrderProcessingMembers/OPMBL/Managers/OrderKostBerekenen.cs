using OPMBL.Model.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPMBL.Managers
{
    public class OrderKostBerekenen
    {
        public double BerekenKost(Order order, double prijsTicket)
        {
            return order.BerekenKost(prijsTicket);
        }
    }
}
