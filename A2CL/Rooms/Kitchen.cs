using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2CL.Rooms
{
    public class Kitchen : Room
    {
        public Kitchen()
        {
            Name = "Kitchen";
            Color = "";
            Style = "";
            Area = 0.00;
        }
        public Kitchen(string color, string style, double area)
        {
            Name = "Kitchen";
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
            return "SYSTEM SUGGESTION - Kitchen: 1 Door, 1 Table, 4 Chairs, 0 Bathtub, 1 Fan\n" +
                "Do you want to use this suggestion? (y/n)";
        }
    }
}
