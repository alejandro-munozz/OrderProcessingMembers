using OPMBL;
using OPMBL.Model;

namespace OPMDL
{
    public class OPMRepositoryMemory
    {
        private Dictionary<string, Member> Members = new();
        private Dictionary<int, Event> Events = new();
        private Dictionary<Member, Event> MemberEvent = new();
        private int memberId = 1;
        private int eventId = 1;
        public OPMRepositoryMemory()
        {
            Member m1 = new Member(memberId, "Saiah", "Saiah@gmail.com", new Adres("Boelarestraat", "9001", "Ninove"));
            Members.Add(m1.Name, m1); memberId++;

            Member m2 = new Member(memberId, "Sarah", "Sarah@gmail.com", new Adres("Gentstraat", "9000", "Gent"));
            Members.Add(m1.Name, m1); memberId++;

            Member m3 = new Member(memberId, "Lukas", "Lukas@gmail.com", new Adres("Mercatorstraat", "9000", "Gent"));
            Members.Add(m1.Name, m1); memberId++;

            Member m4 = new Member(memberId, "Miko", "Miko@gmail.com", new Adres("Verbrandhofstraat", "9500", "Geraardsbergen"));
            Members.Add(m1.Name, m1); memberId++;

            Member m5 = new Member(memberId, "Alejandro", "Alejandro@gmail.com", new Adres("Bigbangstraat", "9000", "Gent"));
            Members.Add(m1.Name, m1); memberId++;

            //Ik zal die events nog objecten maken zodat we die kunnen toevoegen aan MemberEvent 
            Events.Add(new Event(eventId, "Giving Hope", new Adres("Givinghopestreet", "07008", "New York"), new DateTime(12, 12, 2026), 150.50)); eventId++;
            Events.Add(new Event(eventId, "Helping Hands", new Adres("HelpingHandsstraat", "9500", "Geraardsbergen"), new DateTime(12, 12, 2026), 150.50)); eventId++;
            Events.Add(new Event(eventId, "Charity Champions", new Adres("Charityroad", "88901", "Las Vegas"), new DateTime(12, 12, 2026), 150.50)); eventId++;
            Events.Add(new Event(eventId, "Freedom Fundraiser", new Adres("Freedomstraat", "9500", "Gent"), new DateTime(12, 12, 2026), 150.50)); eventId++;
            Events.Add(new Event(eventId, "Hope Delivers", new Adres("Abdijstraat", "9000", "Gent"), new DateTime(12, 12, 2026), 150.50)); eventId++;
            MemberEvent.Add(m1,);
        }
    }
}
