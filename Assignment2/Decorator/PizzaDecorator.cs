using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Decorator
{
    internal class PizzaDecorator : Pizza
    {
        protected Pizza _pizza;
        public PizzaDecorator(Pizza pizza)
        {
            _pizza = pizza;
        }
        public override string GetDescription()
        {
            return _pizza.GetDescription();
        }
        public override double CalculateCost()
        {
            return _pizza.CalculateCost();
        }
    }
}
