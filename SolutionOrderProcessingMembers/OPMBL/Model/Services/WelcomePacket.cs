using OPMBL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPMBL.Model.Services
{
    public class WelcomePacket
    {
        public IDeliveryType delivery { get; }
        private string name;

        public WelcomePacket (IDeliveryType delivery, string name)
        {
            this.delivery = delivery;
            this.name = name;
        }
    }
}
