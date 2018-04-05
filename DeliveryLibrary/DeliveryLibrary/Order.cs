using System.Collections.Generic;

namespace DeliveryLibrary
{
    public class Order
    {
        Supplier supplier;
        List<string> items;
        bool isDelivered;

        public Order(List<string> items, Supplier supplier)
        {
            Supplier = supplier;
            Items = items;
            IsDelivered = false;
        }

        public List<string> Items { get => items; set
            {
                if (value.TrueForAll(x => supplier.Items.Exists(y => y == x)))
                    items = value;
                else
                    items = new List<string>();
            }
        }
        public bool IsDelivered { get => isDelivered; set => isDelivered = value; }
        public Supplier Supplier { get => supplier; set => supplier = value; }
    }
}
