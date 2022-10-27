using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using Taxi_depot.Adder;
using Taxi_depot.Remover;
using Taxi_depot.Meniu;
using static System.Reflection.Metadata.BlobBuilder;
using Taxi_depot.Viewer;

namespace Taxi_depot
{
    class Program
    {
        public static void Main(string[] args)
        {
            Points points = new Points(50);
            MenuCategory main = new MenuCategory("Menu: ", new MenuItem[]
            {
                new MenuAction("Points", newDay),
                new MenuAction("View balance", viewBalance),
                new MenuCategory("Taxi cars", new MenuItem[]
                {
                    new MenuAction("View taxi cars", ViewTaxis.viewTaxi),

                    new MenuCategory("Buy car", new MenuItem[]
                    {
                        new MenuAction("Toyota Prius30 2012     10.000$", AutoDealear.buyPrius),
                        new MenuAction("Toyota Corolla 2007      5.000$", AutoDealear.buyCorolla),
                        new MenuAction("Mercedes E190 1989       3.000$", AutoDealear.buyE190),
                        new MenuBack()
                    }),

                    new MenuAction("Add taxi car", AddTaxiCar.AddTaxi),
                    new MenuAction("Remove taxi car", RemoveTaxis.RemoveTaxi),
                    new MenuBack()
                }),
                new MenuCategory("Drivers", new MenuItem[]
                {
                    new MenuAction("View drivers", ViewDrivers.viewDrivers),
                    new MenuAction("Add driver", AddNewDriver.AddDriver),

                    new MenuCategory("Hire drivers", new MenuItem[]
                    {
                        new MenuAction("Dominic Toretto     300$ + 40$/action point", RecruitmentAgency.hireToretto),
                        new MenuAction("Brian O'Conner      300$ + 20$/action point", RecruitmentAgency.hireBrian),
                        new MenuAction("Jasom Statham       300$ + 30$/ation point", RecruitmentAgency.hireStatham),
                    new MenuBack()
                    }),

                    new MenuAction("Remove driver", RemoveDrivers.RemoveDriver),
                    new MenuBack()
                }),
                new MenuCategory("Clients", new MenuItem[]
                {
                    new MenuAction("View clients", ViewClients.viewClients),
                    new MenuAction("Add client", AddNewCLient.AddClient),
                    new MenuAction("Remove client", RemoveClients.RemoveClient),
                    new MenuAction("Generate clients", AddClients),
                    new MenuBack()
                }),
                new MenuCategory("Orders", new MenuItem[]
                {
                    new MenuAction("View orders", ViewOrders.viewOrders),
                    new MenuAction("Add order", AddNewOrder.AddOrder),
                    new MenuAction("Remove order", RemoveOrders.RemoveOrder),
                    new MenuBack()
                }),
                new MenuAction("Clear all data", RemoveAll.Remove),
                new MenuAction("Assign orders", DefineOrder),
                new MenuAction("Generate orders", GenerateOrders),
                new MenuBack("Exit")
            });
            Company company = new Company();
            company.AddMoney(50000);
            Menu menu = new Menu(main);
            menu.Run();

            Console.WriteLine("Выход из приложения, нажмите любую клавишу...");
            Console.ReadKey();

        }
        private static void SomeActionMethod(MenuItem menuItem)
        {
            Console.WriteLine($"Вы нажали: {menuItem.Name}");
        }

        private static void AddClients(MenuItem menuItem)
        {
            
            List<string> names = new List<string>() { "Andrei", "Ecaterina", "Egor", "Alina", "Danila", "Alisa", "Pavel", "Anna" };
            List<string> surnames = new List<string>() { "Bardier", "Racicovscii", "Mocrenco", "Zacatov", "Cojuhari", "Nedelcev", "Gordeev" };

            for (int i = 0; i < 10; i++)
            {
                Client client = new Client(names[new Random().Next(names.Count())], surnames[new Random().Next(surnames.Count())], new Random().Next(16, 70), new Random().Next(1000, 25000));
            }
      
        }

        private static void GenerateOrders(MenuItem menuItem)
        {

            int x = new Random().Next(0, 100);
            string order_type;
            if (x < 200)
            {
                order_type = "ECONOM";
            }
            else
            {
                order_type = "COMFORT";
            }
            Order order = new Order(order_type, new Random().Next(3,5));


        }

        private static void DefineOrder(MenuItem menuItem)
        {
            AssignOrder.assign();
        }

        private static void newDay(MenuItem menuItem)
        {
            Console.Clear();
            Console.WriteLine(Points.Actions[0].amount + " available points!");
            Console.ReadKey();
            Console.Clear();
        }
        private static void viewBalance(MenuItem menuItem)
        {
            Console.WriteLine("Your balance is " + Company.CompanyList[0].GetBalance() + "$");
        }    }
}
            

