using OPMBL;
using OPMBL.Model;
using OPMBL.Model.Order;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPMUI_WPF.ModelUI
{
    public class MemberUI : INotifyPropertyChanged
    {
        public MemberUI()
        {
        }
        public MemberUI(Member member)
            : this( member.Id,member.Name, member.Email,new AdresUI(member.Adres), member.Status)
        {
        }
        public MemberUI(int id, string name, string email, AdresUI adres, MemberStatus status)
        {
            Id = id;
            Name = name;
            Email = email;
            Adres = adres;
            Status = status;
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
        private string _email;
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
                OnPropertyChanged(nameof(Email));
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
        public MemberStatus Status { get; set; }
        public Order Order { get; set; }
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public event PropertyChangedEventHandler? PropertyChanged;

        public override string ToString()
        {
            return $"{Name}, ID: {Id}, Status: {Status}";
        }
    }
}
