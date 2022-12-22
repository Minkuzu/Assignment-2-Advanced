using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2CL.Furnitures
{
    public class Door : Furniture
    {
        int qty;
        public Door(Room wrappee) : base(wrappee)
        {
            Name = "Door";
        }
        public Door(Room wrappee, int qty) : base(wrappee)
        {
            Name = "Door";
            this.qty = qty;
        }
        public override string Visualize()
        {
            return wrappee.Visualize() + Name + ",\n";
        }
        public override double TotalCost()
        {
            return wrappee.TotalCost() + 3.00;
        }
        public override int getQty()
        {
            return wrappee.getQty() + qty;
        }
    }
}
