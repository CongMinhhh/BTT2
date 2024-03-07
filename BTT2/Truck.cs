using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTT2
{
    class Truck:Vehicle
    {
        public int EngineCapacity { get; set; }

        public Truck() { }

        public Truck(string make, string model, int year, decimal price, int engineCapacity) : base(make, model, year, price)
        {
            EngineCapacity = engineCapacity;
        }

        public override string ToString()
        {
            return base.ToString() + $", Công suất máy: {EngineCapacity}";
        }
    }
}
