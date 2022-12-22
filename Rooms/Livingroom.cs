using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2CL.Rooms
{
    public class Livingroom : Room
    {
        public Livingroom()
        {
            Name = "Livingroom";
            Color = "";
            Style = "";
            Area = 0.00;
        }
        public Livingroom(string color, string style, double area)
        {
            Name = "Livingrooom";
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
            return "SYSTEM SUGGESTION - Livingroom: 4 Doors, 2 Tables, 8 Chairs, 0 Bathtub, 2 Fans\n" +
                "Do you want to use this suggestion? (y/n)";
        }
    }
}
