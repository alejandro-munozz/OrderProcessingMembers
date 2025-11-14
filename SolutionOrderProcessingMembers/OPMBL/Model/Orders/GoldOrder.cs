using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OPMBL.Interfaces;
using OPMBL.Model.Deliveries;
using OPMBL.Model.Order;
using OPMBL.Model.Services;

namespace OPMBL.Model.Status
{
    public class GoldOrder : Order.Order
    {
   
        private const int PRIJSVERMENIGVULDIGING = 3;


        public GoldOrder(Member member, Event @event, int aantalTickets) : base(member, @event, aantalTickets)
        {
            WelcomePacket = new WelcomePacket("GoldwelkomPakket");
            NamePlate = new NamePlate(member.Name);
            Dinner = new Dinner(member.Name);
            PickupService = new PickupService(member.Adres, member.Name, @event.Adres);
            DeliveryType = new ExpressDelivery();

        }

        public override double BerekenKost(double prijsTicket)
        {
            return prijsTicket * PRIJSVERMENIGVULDIGING;
        }
    }
}
