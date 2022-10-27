using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi_depot.Remover;
using Taxi_depot.Viewer;

namespace Taxi_depot
{
    public class AssignOrder
    {
        public static void assign()
        {
            if (Order.Orders.Count == 0)
            {
                Console.Clear();
                Console.WriteLine("There are no orders to assign :( ");
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                foreach (Order order in Order.Orders)
                {
                    Console.Clear();
                    if (order.GetClass() == "ECONOM")
                    {
                        Taxi car = Taxi.Taxis.Find(car => (2022 - car.year_of_issue) >= 10 && car.GetStatus() == "free");
                        if ( (car != null) && (car.GetStatus() == "free" ))
                        {
                            Driver driver = Driver.Drivers.Find(item => item.id_order == 0);
                            driver.id_order = order.GetId();
                            Console.WriteLine("Your car is " + car.info());
                            Console.WriteLine("Your driver is " + driver.Describe());
                            Console.ReadKey();
                            car.status = Convert.ToString(order.GetId());
                            Client client = Client.Clients.Find(item => item.order_status == 0);
                            client.order_status = order.GetId();
                            client.SpendMoney(order.GetFare());
                            Company.CompanyList[0].AddMoney(order.GetFare());

                        }
                        else
                        {
                            Console.WriteLine("There are no econom cars available :(");
                            Console.Clear();
                        }
                    }
                }
                ViewOrders.viewOrders();
                Console.Clear();
            }
        }
    }
}
