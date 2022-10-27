using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi_depot.Meniu;

namespace Taxi_depot.Viewer
{
    internal class ViewOrders
    {
        public static void viewOrders(MenuItem menuItem)
        {

            if (Order.Orders.Count() != 0)
            {
                foreach (Order item in Order.Orders)
                {
                    Console.WriteLine(item.inform());
                }
            }
            else
            {
                Console.WriteLine("There are no orders yet!");

            }
        }
        public static void viewOrders()
        {
            while (Points.Actions[0].amount > 0 && Order.Orders.Exists(item => item.progress < 100))
            {
                Console.Clear();
                if (Order.Orders.Count() != 0)
                {
                    foreach (Order item in Order.Orders)
                    {
                        Console.WriteLine(item.Describe());
                    }
                    Points.Actions[0].spend();
                    System.Threading.Thread.Sleep(500);
                }
                else
                {
                    Console.WriteLine("There are no orders yet!");
                    break;
                }
            }
            if (Points.Actions[0].amount == 0)
            {
                Console.Clear();
                Console.WriteLine("You have no actions points.");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
