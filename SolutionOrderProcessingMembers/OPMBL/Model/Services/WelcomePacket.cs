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

        public WelcomePacket ( string name)
        {
           
            this.name = name;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
