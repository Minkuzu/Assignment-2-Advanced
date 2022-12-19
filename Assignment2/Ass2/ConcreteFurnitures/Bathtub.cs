using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Ass2.ConcreteFurnitures
{
    public class Bathtub : Furniture
    {
        public int Qty { get; set; }

        public Bathtub(Room wrappee, int qty) : base(wrappee)
        {
            Qty = qty;
        }
        public Bathtub(Room wrappee) : base(wrappee)
        {
        }
        public override string Visualize()
        {
            return String.Format("" + wrappee.Visualize() + " " + Qty + " Bathtub");
        }
        public override double TotalCost()
        {
            return wrappee.TotalCost() + 2.00 * Qty;
        }
    }
}
