using OPMBL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPMBL.Interfaces
{
    public interface IOPMRepositoryMemory
    {
        Dictionary<string, Member> GetEmailToMember();
        List<Event> GetEvents();
        Dictionary<string, Member> GetNameToMember();

        Member GetMemberById(int id);
        Event GetEventById(int id);
    }
}
