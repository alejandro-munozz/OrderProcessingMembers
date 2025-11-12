using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OPMBL.Interfaces;
using OPMBL.Model.Order;
using OPMBL.Model.Services;

namespace OPMBL.Model.Status
{
    public class GoldOrder : Order.Order
    {
        //Expresslevering ticket
        //Welkomspakket
        private WelcomePacket _welcomePacket;
        //Expresslevering welkomspakket
        //Naamplaatjes
        private NamePlate _namePlate;
        //Diner
        private Dinner _dinner;
        //Afhaalservice
        private PickupService _pickup;

        private const int PRIJSVERMENIGVULDIGING = 3;

        public override double BerekenKost(double prijsTicket)
        {
            return prijsTicket * PRIJSVERMENIGVULDIGING;
        }
    }
}
