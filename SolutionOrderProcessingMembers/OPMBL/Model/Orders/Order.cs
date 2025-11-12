using OPMBL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPMBL.Model.Order
{
    public class Order
    {
        protected Member _member;
        protected Event _event;
        protected List<Ticket> _tickets;

        public virtual double BerekenKost(double prijsTicket)
        {
            return prijsTicket;
        }

        public Member Member { get; set; }

        public Event Event { get; set; }
    }
}
