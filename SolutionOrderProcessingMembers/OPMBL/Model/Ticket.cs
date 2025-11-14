using OPMBL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPMBL.Model
{
    public class Ticket
    {
        private int id;
        
        public Ticket(int id)
        {
            Id = id;
            
        }

        public int Id { get; set; }
    }
}
