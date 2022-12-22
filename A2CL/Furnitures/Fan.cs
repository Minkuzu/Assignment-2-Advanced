using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2CL.Furnitures
{
    public class Fan : Furniture
    {
        int qty;
        public Fan(Room wrappee) : base(wrappee)
        {
            Name = "Fan";
        }
        public Fan(Room wrappee, int qty) : base(wrappee)
        {
            Name = "Fan";
            this.qty = qty;
        }
        public override string Visualize()
        {
            return wrappee.Visualize() + Name + ",\n";
        }
        public override double TotalCost()
        {
            return wrappee.TotalCost() + 0.50;
        }
        public override int getQty()
        {
            return wrappee.getQty() + qty;
        }
    }
}
