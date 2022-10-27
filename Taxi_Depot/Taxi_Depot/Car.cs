using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi_depot
{
    public class Car
    {
        protected int id_car;
        protected string make;
        protected string model;
        protected string color;
        public int year_of_issue { get; set; }
        public static List<Car> Cars = new List<Car>();
        public Car(string make, string model, string color, int year_of_issue, int id_car)
        {
            this.id_car = Cars.Count() + 1;
            this.make = make;
            this.model = model;
            this.color = color;
            this.year_of_issue = year_of_issue;
            Cars.Add(this);
        }
        public virtual string Describe()
        {
            return id_car + " " + color.ToLower() + " " + make.ToUpper() + ' ' + model.ToUpper() + ' ' + year_of_issue;
        }
    }
}
