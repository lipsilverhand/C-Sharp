using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues
{
    internal class Order
    {
        public int ID {  get; set; }
        public int ORDERQUANLITY { get; set; }
        public Order(int id, int orderQuanlity) 
        {
            this.ID = id;
            this.ORDERQUANLITY = orderQuanlity;
        }

        public void ProcessOrder () 
        {
            Console.WriteLine($"Order {ID} processed!");
        }
    }
}
