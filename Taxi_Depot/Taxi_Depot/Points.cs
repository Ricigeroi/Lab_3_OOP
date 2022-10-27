using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi_depot
{
    public class Points
    {
        public int amount { get; set; }
        public static List<Points> Actions = new List<Points>();
        public Points(int amount)
        {
            this.amount = amount;
            Actions.Add(this);
        }
        public int spend()
        {
            amount -= 1;
            return amount;
        }
    }
}
