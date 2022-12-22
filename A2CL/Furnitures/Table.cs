using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2CL.Furnitures
{
    public class Table : Furniture
    {
        int qty;
        public Table(Room wrappee) : base(wrappee)
        {
            Name = "Table";
        }
        public Table(Room wrappee, int qty) : base(wrappee)
        {
            Name = "Table";
            this.qty = qty;
        }
        public override string Visualize()
        {
            return wrappee.Visualize() + Name + ",\n";
        }
        public override double TotalCost()
        {
            return wrappee.TotalCost() + 1.50;
        }
        public override int getQty()
        {
            return wrappee.getQty() + qty;
        }
    }
}
