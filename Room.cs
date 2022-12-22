using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public abstract class Room
    {
        public string Color { get; set; }
        public string Style { get; set; }
        public double Area { get; set; }
        public Room()
        {

        }
        public Room(string color, string style, double area)
        {
            Color = color;
            Style = style;
            Area = area;
        }

        public abstract string Suggestion();
        public abstract string Visualize();
        public abstract double TotalCost();


    }
}
