using OPMBL;
using OPMBL.Managers;
using OPMBL.Model;
using OPMBL.Model.Order;
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
    private ObservableCollection<Event> events;
    private ObservableCollection<Order> orders;
    private EventsManager eventManager;
    private Member _member;
    
    public MainWindow(Member member)
    {
        InitializeComponent();
        eventManager = new(OPMRepositoryMemoryFactory.GetOPMRepositoryMemory());
        events = new ObservableCollection<Event>(eventManager.GetEvents());
        EventsOverviewDataGrid.ItemsSource = events;
        _member = member;
    }

    private void BuyTicket_Click(object sender, RoutedEventArgs e)
    {
        var item = EventsOverviewDataGrid.SelectedItem;
        BuyTicketWindow tW = new();
        tW.ShowDialog();
    }
}