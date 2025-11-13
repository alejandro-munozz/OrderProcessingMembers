using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPMBL.Model
{
    public class Adres
    {
        public Adres(string straat, string postcode, string gemeente)
        {
            Straat = straat;
            Postcode = postcode;
            Gemeente = gemeente;
        }

        public string Straat { get; set; }
        public string Postcode { get; set; }
        public string Gemeente { get; set; }
    }
}
