using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2CL.Furnitures
{
    public class Bathtub : Furniture
    {
        public Bathtub(Room wrappee) : base(wrappee)
        {
            Name = "Bathtub";
        }
        public override string Visualize()
        {
            return wrappee.Visualize() + Name + ",\n";
        }
        public override double TotalCost()
        {
            return wrappee.TotalCost() + 2.00;
        }
    }
}
