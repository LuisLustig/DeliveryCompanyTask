using System.Collections.Generic;
using System.Linq;

namespace DeliveryLibrary
{
    public static class DeliveryTask
    {
        public static Dictionary<string, List<string>> Agregate(List<Client> clients)
        {
            List<string> list;
            Dictionary<string, List<string>> orders = new Dictionary<string, List<string>>();
            foreach (Client client in clients)
            {
                foreach (Order order in client.Orders)
                {
                    
                    if (orders.TryGetValue(order.Supplier.SupplierName, out list))
                    {
                        list = list.Union(order.Items).ToList<string>();
                        orders.Remove(order.Supplier.SupplierName);
                        orders.Add(order.Supplier.SupplierName, list);
                    }
                    else
                    {
                        orders.Add(order.Supplier.SupplierName, order.Items);
                    }
                }
            }
            return orders;
        }

        public static void Recieve(List<Client> clients, string supplier, List<string> items) //обработка доставленного
        {
            foreach(Client client in clients)
            {
                Order order = client.Orders.Find(x => x.Supplier.SupplierName == supplier);
                if(order!=null)
                {
                    if(order.Items.TrueForAll(x => items.Contains(x)))
                    {
                        if (order.IsDelivered == false)
                        {
                            order.IsDelivered = true;
                            client.GetNotification(order); //оповещение клиента
                        }
                    }
                }
            }
        }
    }
}
