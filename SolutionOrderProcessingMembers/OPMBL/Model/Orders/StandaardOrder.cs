using OPMBL.Interfaces;
using OPMBL.Model.Deliveries;
using OPMBL.Model.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPMBL.Model.Orders
{
    public class StandaardOrder : Order.Order
    {
        public StandaardOrder(Member member, Event @event, int aantalTickets) : base(member, @event, aantalTickets) 
        {
            DeliveryType = new StandardDelivery();
        }

        public override double BerekenKost(double prijsTicket)
        {
            return prijsTicket;
        }
    }
}
