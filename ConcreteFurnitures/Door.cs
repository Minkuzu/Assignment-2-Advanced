using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.ConcreteFurnitures
{
    public class Door : Furniture
    {
        public int Qty { get; set; }

        public Door(Room wrappee, int qty) : base(wrappee)
        {
            Qty = qty;
        }
        public Door(Room wrappee) : base(wrappee)
        {
        }
        public override string Visualize()
        {
            return String.Format("You wanted a " + wrappee.Visualize() + " and " + Qty + " Door,");
        }
        public override double TotalCost()
        {
            return wrappee.TotalCost() + 3.00 * Qty;
        }
    }
}
