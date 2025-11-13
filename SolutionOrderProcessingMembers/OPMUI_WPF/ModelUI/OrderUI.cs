using OPMBL.Model;
using OPMBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OPMBL.Interfaces;
using OPMBL.Model.Services;

namespace OPMUI_WPF.ModelUI
{
    public class OrderUI
    {
        protected MemberUI _member;
        protected EventUI _event;
        public OrderUI(int aantalTickes, MemberUI member, EventUI @event, IDeliveryType deliveryType, Dinner dinner, NamePlate namePlate, PickupService pickupService, WelcomePacket welcomePacket)
        {
            AantalTickets = aantalTickes;
            Member = member;
            Event = @event;
            DeliveryType = deliveryType;
            Dinner = dinner;
            NamePlate = namePlate;
            PickupService = pickupService;
            WelcomePacket = welcomePacket;
            //Services = services;
        }
        public MemberUI Member { get; }
        public EventUI Event { get; }
        public IDeliveryType DeliveryType { get; }
        public List<Service> Services { get; }
        public int AantalTickets { get; set; }
        public Dinner Dinner { get; set; }
        public NamePlate NamePlate { get; set; }
        public PickupService PickupService { get; set; }
        public WelcomePacket WelcomePacket { get; set; }

       // public abstract double BerekenKost(double prijsTicket);
    }
}
