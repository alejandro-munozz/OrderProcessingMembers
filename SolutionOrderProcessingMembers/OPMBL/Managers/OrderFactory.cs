using OPMBL.Interfaces;
using OPMBL.Model.Order;
using OPMBL.Model.Services;
using OPMBL.Model.Status;
using OPMBL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OPMBL.Model.Orders;

namespace OPMBL.Managers
{
    public class OrderFactory
    {
        public static Order createOrder(Member member, Event @event,int aantalTickets)
        {

            return member.Status switch
            {
                MemberStatus.Gold => new GoldOrder( member, @event, aantalTickets),
                MemberStatus.Silver => new SilverOrder(member, @event, aantalTickets),
                MemberStatus.Bronze => new BronzeOrder(member, @event, aantalTickets),
                _ => new StandaardOrder(member, @event, aantalTickets)
            };
        }
    }
}
