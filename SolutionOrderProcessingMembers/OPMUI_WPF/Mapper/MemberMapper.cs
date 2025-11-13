using OPMBL;
using OPMUI_WPF.ModelUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPMUI_WPF.Mapper
{
    public static class MemberMapper
    {
        public static MemberUI MapFromDomain(Member member)
        {
            return new MemberUI(member.Id, member.Name, member.Email, AdresMapper.MapFromDomain(member.Adres), member.Status);
        }
        public static Member MapToDomain(MemberUI member)
        {
            return new Member(member.Id, member.Name, member.Email, AdresMapper.MapToDomain(member.Adres), member.Status);
        }
    }
}
