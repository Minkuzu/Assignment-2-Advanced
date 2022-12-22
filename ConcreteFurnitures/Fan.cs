using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Ass2.ConcreteFurnitures
{
    public class Fan : Furniture
    {
        public int Qty { get; set; }

        public Fan(Room wrappee, int qty) : base(wrappee)
        {
            Qty = qty;
        }
        public Fan(Room wrappee) : base(wrappee)
        {
        }
        public override string Visualize()
        {
            return String.Format("" + wrappee.Visualize() + " " + Qty + " Fan,");
        }
        public override double TotalCost()
        {
            return wrappee.TotalCost() + 0.50 * Qty;
        }
    }
}
