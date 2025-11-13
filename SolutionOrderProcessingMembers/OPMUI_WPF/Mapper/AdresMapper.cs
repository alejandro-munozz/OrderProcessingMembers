using OPMBL.Model;
using OPMUI_WPF.ModelUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPMUI_WPF.Mapper
{
    public static class AdresMapper
    {
        public static AdresUI MapFromDomain(Adres adres)
        {
            return new AdresUI(adres.Straat, adres.Postcode, adres.Gemeente);
        }
        public static Adres MapToDomain(AdresUI adres)
        {
            return new Adres(adres.Straat, adres.Postcode, adres.Gemeente);
        }
    }
}
