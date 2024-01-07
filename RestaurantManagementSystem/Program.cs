using Microsoft.SqlServer.Server;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RestaurantManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Username: ");
            string userName = Console.ReadLine();
            Console.Write("Password: ");
            string password = Console.ReadLine();
            Console.Write("Secret Key: ");
            string secretKey = Console.ReadLine();

            ProxyLogin proxyLogin = new ProxyLogin(userName, password, secretKey);
            bool isTrue = proxyLogin.performLogin();

            if (isTrue)
            {
                Console.WriteLine("========================================");
                Console.WriteLine("\t LOGIN SUCCESSFULL");

                Console.WriteLine("========================================");
                Console.WriteLine("\t LIST OF EMPLOYEES");
                Console.WriteLine("========================================");

                Employee restaurantManager = new Employee();
                restaurantManager.name = "Restaurant Manager";

                Employee shiftManager1 = new Employee();
                shiftManager1.name = "Shift Manager # 1";

                Employee shiftManager2 = new Employee();
                shiftManager2.name = "Shift Manager # 2";

                Employee chef1 = new Employee();
                chef1.name = "Chinese Chef";

                Employee chef2 = new Employee();
                chef2.name = "Italian Chef";

                Employee waiterHead = new Employee();
                waiterHead.name = "Waiter Head";

                Employee valetHead = new Employee();
                valetHead.name = "Valet Head";

                Employee waiter1 = new Employee();
                waiter1.name = "Morning Waiter";

                Employee waiter2 = new Employee();
                waiter2.name = "Night Waiter";

                Employee valet1 = new Employee();
                valet1.name = "Valet # 1";

                Employee valet2 = new Employee();
                valet2.name = "Valet # 2";

                restaurantManager.subOrdinates.Add(shiftManager1);
                restaurantManager.subOrdinates.Add(shiftManager2);
                shiftManager1.subOrdinates.Add(chef1);
                shiftManager1.subOrdinates.Add(chef2);
                shiftManager2.subOrdinates.Add(waiterHead);
                shiftManager2.subOrdinates.Add(valetHead);
                waiterHead.subOrdinates.Add(waiter1);
                waiterHead.subOrdinates.Add(waiter2);
                valetHead.subOrdinates.Add(valet1);
                valetHead.subOrdinates.Add(valet2);

                Employee.record(restaurantManager);

                Console.WriteLine("========================================");
                Console.WriteLine("\t\t VENDORS");
                Console.WriteLine("========================================");
                VendorFactory vf = new VendorFactory();

                Vendor v1 = vf.getVendor("Manufacturers");
                v1.get();
                Vendor v2 = vf.getVendor("Retailers");
                v2.get();
                Vendor v3 = vf.getVendor("Wholesalers");
                v3.get();
                Vendor v4 = vf.getVendor("Service");
                v4.get();

                Console.WriteLine("========================================");
                Console.WriteLine("\t\t DEALS");
                Console.WriteLine("========================================");
                MealBuilder mealBuilder = new MealBuilder();

                Console.WriteLine("DEAL # 1");
                Meal meal1 = mealBuilder.Deal1();
                meal1.print();
                Console.WriteLine();
                Console.WriteLine("DEAL # 2");
                Meal meal2 = mealBuilder.Deal2();
                meal2.print();


                Console.WriteLine("========================================");
                Console.WriteLine("\t\t PAY");
                Console.WriteLine("========================================");

                Discounter s = new Discounter();

                s.setDiscount(new Cash());
                s.operate(1200);
                Console.WriteLine();

                s.setDiscount(new Card());
                s.operate(1000);
            }
            else
            {
                Console.WriteLine("INVALID LOGIN");
            }
        }
    }
}