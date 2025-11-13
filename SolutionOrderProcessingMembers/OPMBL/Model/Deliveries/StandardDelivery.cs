using OPMBL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPMBL.Model.Deliveries
{
    public class StandardDelivery : IDeliveryType
    {
        public string deliveryType()
        {
            return "StandardDelivery";
        }
    }
}
