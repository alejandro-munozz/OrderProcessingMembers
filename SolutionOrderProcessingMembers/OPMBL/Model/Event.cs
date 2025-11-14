namespace OPMBL.Model
{
    public class Event
    {
        public Event(int id, string name, Adres adres, DateTime date, double kostprijs)
        {
            Id = id;
            Name = name;
            Adres = adres;
            Date = date;
            Kostprijs = kostprijs;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public Adres Adres { get; set; }
        public DateTime Date { get; set; }
        public double Kostprijs { get; set; }
        private List<Member> member = new();
        public IReadOnlyList<Member> Members { get { return member; } }
        //Deze staan momenteel in commentary om een werkende WPF te krijgen
        //private List<Member> member = new();
        //public IReadOnlyList<Member> Members { get { return member; } }
    }
}
