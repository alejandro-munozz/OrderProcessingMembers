using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OPMBL.Interfaces;

namespace OPMBL.Model.Services
{
    public class NamePlate
    {
        public IDeliveryType delivery { get; }
        private string name;

        public NamePlate( string name)
        {
            this.delivery = delivery;
            this.name = name;
        }
    }
}
