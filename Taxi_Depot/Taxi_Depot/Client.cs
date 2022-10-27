using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Taxi_depot
{
    class Client : Person
    {
        int money { get; set; }
        public int order_status { get; set; }
        public static List<Client> Clients = new List<Client>();

        public Client(string name, string surname, int age, int money, int id = 0, int order_status = 0)
            : base(id, name, surname, age)
        {
            this.id = base.id;
            this.money = money;
            this.order_status = order_status;
            Clients.Add(this);
        }

        public override string Describe()
        {
            return "Client " + id + " " + surname + " " + name + " " + age + " years old. Amount of money: " + money + ". Order: " + order_status;
        }
        public int GetId()
        {
            return id;
        }
        public int SpendMoney(int cost)
        {
            return this.money -= cost;
        }
    }
}
