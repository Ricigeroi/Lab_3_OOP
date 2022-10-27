using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Taxi_depot
{
    public class Order
    {
        public Trip trip { get; set; }
        private int id_order;
        private string type;
        private int distance;
        private int fare;
        private int id_car { get; set; }
        private int id_driver { get; set; }
        private int id_client { get; set; }
        public int progress { get; set; }
        public static List<Order> Orders = new List<Order>();

        public Order(string type, int distance, int fare = 0, int id_order = 0, int id_car = 0, int id_driver = 0, int id_client = 0, int progress = 0, Trip trip = null)
        {
            this.id_order = Orders.Count() + 1;
            this.type = type;
            this.distance = distance;
            if (type.ToUpper() == "ECONOM")
            {
                this.fare = distance * Fare.GetFareEconom();
            }
            if (type.ToUpper() == "COMFORT")
            {
                this.fare = distance * Fare.GetFareComfort();
            }
            Orders.Add(this);
            this.id_car = id_car;
            this.id_driver = id_driver;
            this.id_client = id_client;
            this.progress = progress;
            this.trip = new Trip(id_order, distance);
        }
        public int GetDistance()
        {
            return this.distance;
        }
        public string GetClass()
        {
            return this.type.ToUpper();
        }
        public int GetId()
        {
            return id_order;
        }
        public int GetFare()
        {
            return this.fare;
        }
        public string Describe()
        {
            return GetClass().ToUpper() + " class. Distance = " + GetDistance() + ". Cost = " + GetFare() + " Progress: " + Progress() + "%";
        }
        public string inform()
        {
            return GetClass().ToUpper() + " class. Distance = " + GetDistance() + ". Cost = " + GetFare();
        }
        public int move()
        {
            return trip.move();
        }
        public int Progress()
        {
            progress = move();
            return progress;
        }

    }
}
