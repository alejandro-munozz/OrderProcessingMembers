using OPMBL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPMBL.Managers
{
    public class MemberManager
    {
        private IOPMRepositoryMemory repo;

        public MemberManager(IOPMRepositoryMemory repo)
        {
            this.repo = repo;
        }

        public Dictionary<string, Member>? GetEmailToMember()
        {
            return repo.GetEmailToMember();
        }

        public Dictionary<string, Member>? GetNameToMember()
        {
            return repo.GetNameToMember();
        }
        public Member GetMemberById(int id)
        {
            return repo.GetMemberById(id);
        }
    }
}
