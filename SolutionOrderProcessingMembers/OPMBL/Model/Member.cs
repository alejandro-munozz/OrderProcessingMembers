using OPMBL.Interfaces;
using OPMBL.Model;
using OPMBL.Model.Order;

namespace OPMBL
{
    public class Member
    {
        public Member(int id, string name, string email, Adres adres)
        {
            Id = id;
            Name = name;
            Email = email;
            Adres = adres;  
        }
        public string Name {get; set;}
        public int Id {get; set;}
        public string Email {get; set;}
        public Adres Adres {get; set;}
        public Order Order {get; set;}

        private List<Event> events = new();
        public IReadOnlyList<Event> Events { get { return events; } }
        // Ordertype met enum bronz,silver,gold
    }
}