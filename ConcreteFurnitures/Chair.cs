using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Ass2.ConcreteFurnitures
{
    public class Chair : Furniture
    {
        public int Qty { get; set; }

        public Chair(Room wrappee, int qty) : base(wrappee)
        {
            Qty = qty;
        }
        public Chair(Room wrappee) : base(wrappee)
        {
        }
        public override string Visualize()
        {
            return String.Format("" + wrappee.Visualize() + " " + Qty + " Chair,");
        }
        public override double TotalCost()
        {
            return wrappee.TotalCost() + 0.50 * Qty;
        }
    }
}
