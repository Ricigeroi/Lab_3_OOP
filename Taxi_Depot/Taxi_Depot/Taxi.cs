using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Taxi_depot.Meniu;

namespace Taxi_depot
{
    class Taxi : Car
    {
        public string status { get; set; }
        public static List<Taxi> Taxis = new List<Taxi>();
        public Taxi(string make, string model, string color, int year_of_issue, string status = "free", int id_car = 0) 
            : base(make, model, color, year_of_issue, id_car)
        {
            this.id_car = base.id_car;
            this.make = base.make;
            this.model = base.model;
            this.color = base.color;
            this.year_of_issue = base.year_of_issue;
            this.status = status;
            Taxis.Add(this);
        }
        
        public override string Describe()
        {
            return id_car + " " + color.ToLower() + " " + make.ToUpper() + ' ' + model.ToUpper() + ' ' + year_of_issue + " Order: " + status;
        }
        public string info()
        {
            return color.ToUpper() + " " + make.ToUpper() + " " + model.ToUpper() + ' ' + year_of_issue;
        }
 
        public string GetStatus()
        {
            return status;
        }

        public int GetId()
        {
            return id_car;
        }

    }
}
