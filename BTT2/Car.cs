using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTT2
{
    class Car:Vehicle
    {
        public string Color { get; set; }

        public Car() { }

        public Car(string make, string model, int year, decimal price, string color) : base(make, model, year, price)
        {
            Color = color;
        }

        public override string ToString()
        {
            return base.ToString() + $", Màu xe: {Color}";
        }
    }
}
