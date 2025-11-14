using OPMBL.Interfaces;
using OPMBL.Model;
using OPMBL.Model.Order;

namespace OPMBL.Managers
{
    public class OrderManager
    {
        private readonly List<Order> _orders = new List<Order>();
        private readonly OrderKostBerekenen _kostBerekenen = new OrderKostBerekenen();
        private IOrderRepository _repo;

        public OrderManager(IOrderRepository repo)
        {
            _repo = repo;
        }


        public double BerekenTotaleKost(Order order, double prijsTicket)
        {
            return _kostBerekenen.BerekenKost(order, prijsTicket);
        }
        

        public Order bestelVoorMemberEnEvent(Member member, Event @event, int aantalTickets)
        {
            var createdOrder = OrderFactory.createOrder(member, @event, aantalTickets);
            createdOrder.Prijs = _kostBerekenen.BerekenKost(createdOrder, @event.Kostprijs);
            _repo.SaveOrder(createdOrder);
            return createdOrder;
        }
        public List<Order> GetOrders()
        {
            return _repo.GetOrders();
        }
    }
}
