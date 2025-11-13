using OPMBL.Interfaces;
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
        //Naamplaatjes
        private NamePlate _namePlate;

        private const int PRIJSVERHOGING = 100;

        //public BronzeOrder(Member member, Event event, List<Ticket> tickets, NamePlate namePlate)
        //{
        //    _member = member;
        //    _event = event;
        //_tickets = tickets;
        //_
        //}


        public override double BerekenKost(double prijsTicket)
        {
            return prijsTicket + PRIJSVERHOGING;
        }
    }
}
