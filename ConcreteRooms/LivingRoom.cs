using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.ConcreteRooms
{
    public class LivingRoom : Room
    {
        public LivingRoom()
        {
            Color = "";
            Style = "";
            Area = 0.00;
        }
        public LivingRoom(string color, string style, double area)
        {
            Color = color;
            Style = style;
            Area = area;
        }
        public override string Visualize()
        {
            return "Livingroom with Color: " + Color + ", Style: " + Style + ", Area: " + Area + "m2";
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
