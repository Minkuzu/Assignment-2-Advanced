using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Furniture : Room
    {
        protected Room wrappee;
        public Furniture()
        {
        }
        public Furniture(Room wrappee)        {
            this.wrappee = wrappee;
        }

        public override string Visualize()
        {
            return wrappee.Visualize();
        }
        public override double TotalCost()
        {
            return wrappee.TotalCost();
        }
        public override string Suggestion()
        {
            return wrappee.Suggestion();
        }
    }
}
