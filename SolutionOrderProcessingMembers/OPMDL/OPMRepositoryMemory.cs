using OPMBL;
using OPMBL.Interfaces;
using OPMBL.Model;

namespace OPMDL
{
    public class OPMRepositoryMemory : IOPMRepositoryMemory
    {
        private Dictionary<string, Member> nameToMember = new();
        private Dictionary<string, Member> emailToMember = new();
        private List<Event> Events = new();
        private Dictionary<Member, Event> MemberEvent = new();
        private int memberId = 1;
        private int eventId = 1;
        public OPMRepositoryMemory()
        {
            Member m1 = new Member(memberId, "Saiah", "Saiah@gmail.com", new Adres("Boelarestraat", "9001", "Ninove"), MemberStatus.Silver);
            nameToMember.Add(m1.Name, m1); memberId++;
            emailToMember.Add(m1.Email, m1);

            Member m2 = new Member(memberId, "Sarah", "Sarah@gmail.com", new Adres("Gentstraat", "9000", "Gent"), MemberStatus.Standaard);
            nameToMember.Add(m2.Name, m2); memberId++;
            emailToMember.Add(m2.Email, m2);

            Member m3 = new Member(memberId, "Lukas", "Lukas@gmail.com", new Adres("Mercatorstraat", "9000", "Gent"), MemberStatus.Standaard);
            nameToMember.Add(m3.Name, m3); memberId++;
            emailToMember.Add(m3.Email, m3);

            Member m4 = new Member(memberId, "Miko", "Miko@gmail.com", new Adres("Verbrandhofstraat", "9500", "Geraardsbergen"), MemberStatus.Bronze);
            nameToMember.Add(m4.Name, m4); memberId++;
            emailToMember.Add(m4.Email, m4);

            Member m5 = new Member(memberId, "Alejandro", "Alejandro@gmail.com", new Adres("Bigbangstraat", "9000", "Gent"), MemberStatus.Gold);
            nameToMember.Add(m5.Name, m5); memberId++;
            emailToMember.Add(m5.Email, m5);

            Events.Add(new Event(eventId, "Giving Hope", new Adres("Givinghopestreet", "07008", "New York"), new DateTime(2026, 12, 12), 150.50)); eventId++;
            Events.Add(new Event(eventId, "Helping Hands", new Adres("HelpingHandsstraat", "9500", "Geraardsbergen"), new DateTime(2026, 12, 12), 150.50)); eventId++;
            Events.Add(new Event(eventId, "Charity Champions", new Adres("Charityroad", "88901", "Las Vegas"), new DateTime(2026, 12, 12), 150.50)); eventId++;
            Events.Add(new Event(eventId, "Freedom Fundraiser", new Adres("Freedomstraat", "9500", "Gent"), new DateTime(2026, 12, 12), 150.50)); eventId++;
            Events.Add(new Event(eventId, "Hope Delivers", new Adres("Abdijstraat", "9000", "Gent"), new DateTime(2026, 12, 12), 150.50)); eventId++;
        }

        public Dictionary<string, Member> GetEmailToMember()
        {
            return emailToMember;
        }

        public List<Event> GetEvents()
        {
            return Events;
        }

        public Dictionary<string, Member> GetNameToMember()
        {
            return nameToMember;
        }

        public Member GetMemberById(int id)
        {
            return nameToMember.Values.Where(x=>x.Id == id).First();
        }
        public Event GetEventById(int id)
        {
            return Events.Where(x => x.Id == id).First();
        }
    }
}
