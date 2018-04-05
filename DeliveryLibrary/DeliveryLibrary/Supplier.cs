using System.Collections.Generic;

namespace DeliveryLibrary
{
    public class Supplier
    {
        string supplierName;
        List<string> items;

        public Supplier(string supplierName, List<string> items)
        {
            this.supplierName = supplierName;
            this.items = new List<string>(items);
        }

        public string SupplierName { get => supplierName; set => supplierName = value; }
        public List<string> Items { get => items; set => items = value; }
    }
}
