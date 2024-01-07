using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem
{
    public class Bottle : Packing
    {
        public string getPackingType()
        {
            return "Bottle";
        }
    }
}
