﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem
{
    interface Item
    {
        string getName();
        Packing getPack();
        int getPrice();
    }
}
