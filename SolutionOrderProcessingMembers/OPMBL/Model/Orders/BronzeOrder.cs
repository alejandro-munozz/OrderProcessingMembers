using OPMBL.Interfaces;
using OPMBL.Model.Deliveries;
using OPMBL.Model.Order;
using OPMBL.Model.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPMBL.Model.Status
{
    public class BronzeOrder : Order.Order
    {
        private NamePlate _namePlate;
        
        private IDeliveryType _deliveryType;
        private const int PRIJSVERHOGING = 100;
        public BronzeOrder(Member member, Event @event, int aantalTickets) : base(member, @event, aantalTickets)
        {
            NamePlate = new NamePlate(member.Name);
            DeliveryType = new StandardDelivery();
        }
        public override double BerekenKost(double prijsTicket)
        {
            return prijsTicket + PRIJSVERHOGING;
        }
    }
}
