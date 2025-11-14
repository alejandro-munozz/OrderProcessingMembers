using OPMBL.Model;
using OPMUI_WPF.ModelUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPMUI_WPF.Mapper
{
    public static class EventMapper
    {
        public static EventUI MapFromDomain(Event @event)
        {
            return new EventUI(@event.Id, @event.Name, AdresMapper.MapFromDomain(@event.Adres), @event.Date, @event.Kostprijs);
        }
        public static Event MapToDomain(EventUI @event)
        {
            return new Event(@event.Id, @event.Name, AdresMapper.MapToDomain(@event.Adres), @event.Date, @event.Kostprijs);
        }
    }
}
