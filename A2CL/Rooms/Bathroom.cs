using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2CL.Rooms
{
    public class Bathroom : Room
    {
        public Bathroom()
        {
            Name = "Bathroom";
            Color = "";
            Style = "";
            Area = 0.00;
        }
        public Bathroom(string color, string style, double area)
        {
            Name = "Bathroom";
            Color = color;
            Style = style;
            Area = area;
        }
        public string getColor()
        {
            return Color;
        }
        public string getStyle()
        {
            return Style;
        }
        public double getArea()
        {
            return Area;
        }
        public override string Visualize()
        {
            return Name + " with Color: " + Color + ", Style: " + Style + ", Area: " + Area + "m2 and with these decorators:\n";
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
