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

        string Straat {  get; set; }

        string Postcode { get; set; }

        string Gemeente { get; set; } 
    }
}
