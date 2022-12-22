using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2CL.Furnitures
{
    public class Bathtub : Furniture
    {
        int qty;
        public Bathtub(Room wrappee) : base(wrappee)
        {
            Name = "Bathtub";
        }
        public Bathtub(Room wrappee, int qty) : base(wrappee)
        {
            Name = "Bathtub";
            this.qty = qty;
        }
        public override string Visualize()
        {
            return wrappee.Visualize() + Name + ",\n";
        }
        public override double TotalCost()
        {
            return wrappee.TotalCost() + 2.00;
        }
        public override int getQty()
        {
            return wrappee.getQty() + qty;
        }
    }
}
