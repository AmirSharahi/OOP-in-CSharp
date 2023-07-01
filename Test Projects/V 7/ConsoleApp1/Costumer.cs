using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Costumer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;

        public Costumer()
        {
            Orders = new List<Order>();
        }

        public Costumer(int id)
            : this()
        {
            this.Id = id;
        }

        public Costumer(int id , string name)
            : this(id)
        {
            this.Name = name;
        }
    }
}