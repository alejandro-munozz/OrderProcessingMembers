using OPMBL.Model;
using OPMBL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace OPMUI_WPF.ModelUI
{
    public class EventUI : INotifyPropertyChanged
    {
        public EventUI(int id, string name, AdresUI adres, DateTime date, double kostprijs)
        {
            Id = id;
            Name = name;
            Adres = adres;
            Date = date;
            Kostprijs = kostprijs;
        }

        public EventUI(string name, AdresUI adres, DateTime date, double kostprijs)
        {
            Name = name;
            Adres = adres;
            Date = date;
            Kostprijs = kostprijs;
        }
        private int _id;
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
                OnPropertyChanged(nameof(Id));
            }
        }
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }
        private AdresUI _adres;
        public AdresUI Adres
        {
            get
            {
                return _adres;
            }
            set
            {
                _adres = value;
                OnPropertyChanged(nameof(Adres));
            }
        }
        private DateTime _date;
        public DateTime Date
        {
            get
            {
                return _date;
            }
            set
            {
                _date = value;
                OnPropertyChanged(nameof(Date));
            }
        }
        private double _kostprijs;
        public double Kostprijs
        {
            get
            {
                return _kostprijs;
            }
            set
            {
                _kostprijs = value;

                OnPropertyChanged(nameof(Kostprijs));
            }
        }
        private List<Member> member = new();
        public IReadOnlyList<Member> Members { get { return member; } }
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public event PropertyChangedEventHandler? PropertyChanged;

        public override string ToString()
        {
            return Name;
        }
    }
}
