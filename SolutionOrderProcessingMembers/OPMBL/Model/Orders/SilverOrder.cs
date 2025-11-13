using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using OPMBL.Interfaces;
using OPMBL.Model.Deliveries;
using OPMBL.Model.Order;
using OPMBL.Model.Services;

namespace OPMBL.Model.Status
{
    public class SilverOrder : Order.Order
    {
       
        private const int PRIJSVERMENIGVULDIGING = 2;

        public SilverOrder(Member member, Event @event, int aantalTickets) : base(member, @event, aantalTickets) 
        {
            WelcomePacket = new WelcomePacket("SilverkomPakket");
            NamePlate = new NamePlate(member.Name);
            Dinner = new Dinner("kaas");
            DeliveryType = new ExpressDelivery();
        }

        public override double BerekenKost(double prijsTicket)
        {
            return prijsTicket * PRIJSVERMENIGVULDIGING;
        }
    }
}
