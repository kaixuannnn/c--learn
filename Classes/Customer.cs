using System.Collections.Generic;

namespace Classes
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;

        public Customer()
        {
           this.Orders = new List<Order>();
        }

        public Customer(int id)
               :this()
        {
            this.Id = Id;
        }

        public Customer(int id,string name)
            :this(id)
        {
            this.Name = name;
        }


    }
}
