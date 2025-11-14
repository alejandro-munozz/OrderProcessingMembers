using OPMBL;
using OPMBL.Interfaces;
using OPMBL.Managers;
using OPMBL.Model;
using OPMBL.Model.Order;
using OPMDL;
using OPMUI_WPF.Mapper;
using OPMUI_WPF.ModelUI;
using OPMUtils;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OPMUI_WPF;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private ObservableCollection<EventUI> events;
    private ObservableCollection<OrderUI> orders;
    private EventsManager eventManager;
    private OrderManager orderManager;
    private MemberUI _member;
    
    public MainWindow(MemberUI member)
    {
        InitializeComponent();
        orderManager = new OrderManager(new MemoryOrderRepository());
        eventManager = new(OPMRepositoryMemoryFactory.GetOPMRepositoryMemory());
        events = new ObservableCollection<EventUI>(eventManager.GetEvents().Select(x=>EventMapper.MapFromDomain(x)));
        orders = new ObservableCollection<OrderUI>(orderManager.GetOrders().Select(x => OrderMapper.MapFromDomain(x)));
        EventsOverviewDataGrid.ItemsSource = events;
        OrderOverviewDataGrid.ItemsSource = orders;
        _member = member;
    }

    private void BuyTicket_Click(object sender, RoutedEventArgs e)
    {
        var selectedEvent = EventsOverviewDataGrid.SelectedItem as EventUI;
        BuyTicketWindow tW = new BuyTicketWindow(_member, selectedEvent, (ticketCount) =>
        {

            var member = OPMRepositoryMemoryFactory.GetOPMRepositoryMemory().GetMemberById(_member.Id);
            var evt = eventManager.GetEventById(selectedEvent.Id);
            orderManager.bestelVoorMemberEnEvent(member, evt,ticketCount);
            RefreshOrders();
        }); 
        tW.ShowDialog();

    }
    private void RefreshOrders()
    {
        OrderOverviewDataGrid.ItemsSource = orderManager.GetOrders().Select(x => OrderMapper.MapFromDomain(x));
    }
}