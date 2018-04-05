using System;
using System.Collections.Generic;

namespace DeliveryLibrary
{
    public class Client
    {
        string name;
        List<Order> orders;

        public Client(string name)
        {
            Name = name;
            Orders = new List<Order>();
        }

        public Client(string name, List<Order> orders)
        {
            Name = name;
            Orders = orders;
        }

        public string Name { get => name; set => name = value; }
        public List<Order> Orders { get => orders; set => orders = value; }
      
        public void GetNotification(Order order) //заказ клиента доставлен
        {

        }
    }
}
