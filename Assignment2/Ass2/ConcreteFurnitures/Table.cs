using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.ConcreteFurnitures
{
    public class Table : Furniture
    {
        public int Qty { get; set; }

        public Table(Room wrappee, int qty) : base(wrappee)
        {
            Qty = qty;
        }
        public Table(Room wrappee) : base(wrappee)
        {
        }
        public override string Visualize()
        {
            return String.Format("" + wrappee.Visualize() + " " + Qty + " Table,");
        }
        public override double TotalCost()
        {
            return wrappee.TotalCost() + 1.50 * Qty;
        }
    }
}
