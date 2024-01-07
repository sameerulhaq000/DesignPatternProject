using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem
{
    class Employee
    {
        public string name;
        public List<Employee> subOrdinates = new List<Employee>();

        public static void record(Employee n)
        {
            if (n.subOrdinates.Count == 0)
            {
                return;
            }
            else
            {
                foreach (Employee item in n.subOrdinates)
                {
                    Console.WriteLine(item.name);
                    Console.WriteLine("---");
                    record(item);
                    Console.WriteLine("end");
                }
            }
        }
    }
}
