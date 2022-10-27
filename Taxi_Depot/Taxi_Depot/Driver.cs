using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi_depot
{
    class Driver : Person
    {
        int years_driving;
        int rating;
        int id_car;
        public int id_order { get; set; }
        public static List<Driver> Drivers = new List<Driver>();
        public Driver(string name, string surname, int age, int years_driving, int rating = 0, int id = 0, int id_car = 0, int id_order = 0)
            : base(id, name, surname, age)
        {
            this.id = base.id;
            this.years_driving = years_driving;
            this.rating = rating;
            this.id_car = id_car;
            Drivers.Add(this);
            this.id_order = id_order;
        }

        public override string Describe()
        {
            return "Driver " + id + " " + surname + " " + name + " " + age + " years old, " + years_driving + " years pro. Rating: " + rating;
        }
        public int GetId()
        {
            return id;
        }
    }
}
