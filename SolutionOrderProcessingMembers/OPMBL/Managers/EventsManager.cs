using OPMBL.Interfaces;
using OPMBL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPMBL.Managers
{
    public class EventsManager
    {
        private IOPMRepositoryMemory repo;

        public EventsManager(IOPMRepositoryMemory repo)
        {
            this.repo = repo;
        }

        public List<Event> GetEvents()
        {
            return repo.GetEvents();
        }
    }
}
