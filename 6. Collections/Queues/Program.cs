using System;
using System.Collections;

namespace Queues
{
    class Program
    {
        public static void Main(string[] args) 
        {
            Queue<Order> orderQueue = new Queue<Order>();
            foreach (Order o in ReceiveOrder1()) 
            {
                orderQueue.Enqueue(o);
            }

            foreach (Order o in ReceiveOrder2())
            {
                orderQueue.Enqueue(o);
            }

            while (orderQueue.Count > 0)
            {
                Order currentOrder = orderQueue.Dequeue();
                currentOrder.ProcessOrder();
            }
        }

        public static Order[] ReceiveOrder1() 
        {
            Order[] orders = new Order[]
            {
                new Order(1,5),
                new Order(2, 4),
                new Order(5, 8),
            };
            return orders;
        }

        public static Order[] ReceiveOrder2()
        {
            Order[] orders = new Order[]
            {
                new Order(3,5),
                new Order(4, 4),
                new Order(6, 8),
            };
            return orders;
        }

    }
}