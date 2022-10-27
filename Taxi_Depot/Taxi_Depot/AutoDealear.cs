using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi_depot.Adder;
using Taxi_depot.Meniu;

namespace Taxi_depot
{
    public class AutoDealear : Company
    {
        int balance;
        public AutoDealear(int balance)
        {
            this.balance = balance;
        }
        
        public static void buyPrius(MenuItem menuItem)
        {
            Console.Clear();
            Console.Write("Select color: ");
            string input = Console.ReadLine();
            AddTaxiCar.buyCar("Toyota", "Prius", input, 2012);
            Console.Clear();
            Company.CompanyList[0].spendMoney(10000);
        }
        public static void buyCorolla(MenuItem menuItem)
        {
            Console.Clear();
            Console.Write("Select color: ");
            string input = Console.ReadLine();
            AddTaxiCar.buyCar("Toyota", "Corolla", input, 2007);
            Console.Clear();
            Company.CompanyList[0].spendMoney(5000);
        }
        public static void buyE190(MenuItem menuItem)
        {
            Console.Clear();
            Console.Write("Select color: ");
            string input = Console.ReadLine();
            AddTaxiCar.buyCar("Mercedes", "E190", input, 1989);
            Console.Clear();
            Company.CompanyList[0].spendMoney(3000);
        }
    }
}
