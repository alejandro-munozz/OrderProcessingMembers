using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPMBL.Model.Services
{
    public abstract class Service
    {
        public string Name { get; }
        protected Service(string name)
        {
            Name = name;
        }
    }
}
