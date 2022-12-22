using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2CL.Furnitures
{
    public class Chair : Furniture
    {
        int qty;
        public Chair(Room wrappee) : base(wrappee)
        {
            Name = "Chair";
        }
        public Chair(Room wrappee, int qty) : base(wrappee)
        {
            Name = "Chair";
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
