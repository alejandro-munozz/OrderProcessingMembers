using OPMBL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPMUI_WPF.ModelUI
{
    public class AdresUI : INotifyPropertyChanged
    {
        public AdresUI(string straat, string postcode, string gemeente)
        {
            Straat = straat;
            Postcode = postcode;
            Gemeente = gemeente;
        }

        public AdresUI(Adres adres)
         : this(adres.Straat, adres.Postcode, adres.Gemeente)
        {
        }

        private string _straat;
        public string Straat
        {
            get
            {
                return _straat;
            }
            set
            {
                _straat = value;
                OnPropertyChanged(nameof(Straat));
            }
        }
        private string _postcode;
        public string Postcode
        {
            get
            {
                return _postcode;
            }
            set
            {
                _postcode = value;
                OnPropertyChanged(nameof(Postcode));
            }
        }
        private string _gemeente;
        public string Gemeente
        {
            get
            {
                return _gemeente;
            }
            set
            {
                _gemeente = value;
                OnPropertyChanged(nameof(Gemeente));
            }
        }
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
