using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2CL
{
    public abstract class Room
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public string Style { get; set; }
        public double Area { get; set; }
        public int Qty { get; set; }
        public Room()
        {

        }
        public Room(string color, string style, double area)
        {
            Color = color;
            Style = style;
            Area = area;
        }
        public Room(string color, string style, double area, int qty)
        {
            Color = color;
            Style = style;
            Area = area;
            Qty = 0;
        }

        public abstract string Suggestion();
        public abstract string Visualize();
        public abstract double TotalCost();
        public abstract int getQty();


    }
}
