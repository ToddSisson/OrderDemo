using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Order[] orders = new Order[3];

            for (int i = 0; i < orders.Length; i++)
            {
                Console.Write("Enter an order ID: ");
                int orderID = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter a name: ");
                string customerName = Console.ReadLine();
                Console.Write("Enter a quantity ordered: ");
                int quantityOrdered = Convert.ToInt32(Console.ReadLine());
                
                orders[i] = new Order(orderID, customerName, quantityOrdered);

            }

            for (int i = 0; i < orders.Length; i++)
            {
                for (int x = 0; x < orders.Length; x++)
                {
                   while (orders[x].Equals(orders[i]) && orders[x] != orders[i])
                    {
                        Console.WriteLine("Order numbers must be unique. Enter a new one");
                        orders[i].OrderNumber = Convert.ToInt32(Console.ReadLine());
                    } 
                }

                Console.WriteLine(orders[i].ToString());
            }
        }
    }
}
