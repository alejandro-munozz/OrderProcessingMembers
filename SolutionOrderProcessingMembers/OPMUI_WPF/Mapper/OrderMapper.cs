using OPMBL;
using OPMBL.Model.Order;
using OPMUI_WPF.ModelUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPMUI_WPF.Mapper
{
    public static class OrderMapper
    {
        public static OrderUI MapFromDomain(Order order)
        {


            return new OrderUI(order.Tickets.Count,MemberMapper.MapFromDomain(order.Member),EventMapper.MapFromDomain(order.Event),order.DeliveryType,order.Dinner,order.NamePlate,order.PickupService,order.WelcomePacket);
        }
       
    }
}
