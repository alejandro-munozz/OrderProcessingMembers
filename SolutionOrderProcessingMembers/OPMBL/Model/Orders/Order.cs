using OPMBL.Interfaces;
using OPMBL.Model.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPMBL.Model.Order
{
    public abstract class Order
    {
    

       
        public Order(Member member, Event @event, int aantalTickets)
        {
            Member = member;
            Event = @event;

            Tickets = new List<Ticket>();

            for(int i = 0; i < aantalTickets; i++)
            {
                Tickets.Add(new Ticket(i));
            }
        
        }



        /* dit voldoet niet aan het principe “A class should only have one reason to change”
        public virtual double BerekenKost(double prijsTicket)
        {
          return prijsTicket;
        }
        */
        public Member Member { get; set; }
        public Event Event { get; set; }
        public IDeliveryType DeliveryType { get; set; }
        public List<Ticket> Tickets { get; set; }
        public Dinner Dinner { get; set; }
        public NamePlate NamePlate { get; set; }
        public PickupService PickupService { get; set; }
        public WelcomePacket WelcomePacket { get; set; }

        public double Prijs { get; set; }
        public abstract double BerekenKost(double prijsTicket);
    }
}
