using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.ConcreteRooms
{
    public class Bathroom : Room
    {
        public Bathroom()
        {

        }
        public Bathroom(string color, string style, double area)
        {
            Color = color;
            Style = style;
            Area = area;
        }
        public override string Visualize()
        {
            return "Bathroom with Color: " + Color + ", Style: " + Style + ", Area: " + Area + "m2";
        }
        public override double TotalCost()
        {
            return 24.00 * Area;
        }
        public override string Suggestion()
        {
            return "SYSTEM SUGGESTION - Bathroom: 1 Door, 0 Table, 0 Chairs, 1 Bathtub, 0 Fan\n" +
                "Do you want to use this suggestion? (y/n)";
        }
    }
}
