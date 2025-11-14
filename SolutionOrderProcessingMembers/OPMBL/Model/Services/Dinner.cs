using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OPMBL.Interfaces;

namespace OPMBL.Model.Services
{
    public class Dinner
    {
        private string name;

        public Dinner(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return $"Dinner reserved for {name}";
        }
    }
}
