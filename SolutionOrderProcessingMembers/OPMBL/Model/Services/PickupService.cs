using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OPMBL.Interfaces;

namespace OPMBL.Model.Services
{
    public class PickupService
    {
        private Adres adresMember;
        private string nameMember;
        private Adres adresEvent;

        public PickupService(Adres adresMember, string nameMember, Adres adresEvent)
        {
            this.adresMember = adresMember;
            this.nameMember = nameMember;
            this.adresEvent = adresEvent;
        }
    }
}
