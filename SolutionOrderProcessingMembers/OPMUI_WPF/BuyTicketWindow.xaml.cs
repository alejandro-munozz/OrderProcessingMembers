using OPMUI_WPF.ModelUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace OPMUI_WPF
{
    /// <summary>
    /// Interaction logic for BuyTicketWindow.xaml
    /// </summary>
    public partial class BuyTicketWindow : Window
    {
        private MemberUI _memberUI;
        private EventUI _eventUI;
        private Action<int> _onTicketsConfirmed;
        public BuyTicketWindow(MemberUI member, EventUI ev, Action<int> onTicketsConfirmed)
        {
            InitializeComponent();
            _memberUI = member;
            _eventUI = ev;
            _onTicketsConfirmed = onTicketsConfirmed;
        }

        private void TicketsPurchase_Click(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(NumberOfTicketsTextBox.Text, out int ticketCount) || ticketCount <= 0)
            {
                MessageBox.Show("Voer een geldig aantal tickets in.", "Ongeldig aantal", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            _onTicketsConfirmed?.Invoke(ticketCount);
            this.Close();
        }
    }
}
