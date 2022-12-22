using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.ConcreteRooms
{
    public class Kitchen : Room
    {
        public Kitchen()
        {
            Color = "";
            Style = "";
            Area = 0.00;
        }
        public Kitchen(string color, string style, double area)
        {
            Color = color;
            Style = style;
            Area = area;
        }
        public override string Visualize()
        {
            return "Kitchen with Color: " + Color + ", Style: " + Style + ", Area: " + Area + "m2";
        }
        public override double TotalCost()
        {
            return 24.00 * Area;
        }
        public override string Suggestion()
        {
            return "SYSTEM SUGGESTION - Kitchen: 1 Door, 1 Table, 4 Chairs, 0 Bathtub, 1 Fan\n" +
                "Do you want to use this suggestion? (y/n)";
        }
    }
}
