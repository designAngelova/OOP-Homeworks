using System;
using System.Collections.Generic;

namespace CustomerApp
{
    public class Tester
    {
        public static void Main()
        {
            Customer c1 = new Customer("Stefan", "Canev", "Ivanov", "8712929211", "Krasna Polqna 11, Sofia",
                "0882737632", "asoto11@abv.bg", CustomerType.Regular);

            c1.Payments.Add(new Payment("Verizon", 11.90m));

            Customer c2 = c1.Clone();

            //c2.Payments.Clear(); // doesn`t clear c1`s payments - we`ve got a deep copy
            c2.Payments.Add(new Payment("Dedepof", 90.00m));
            //c1.Payments.Clear();
            c1.Payments[0].Price = 12345.6m;

            foreach (var payment in c1.Payments)
            {
                Console.WriteLine(payment);
            }

            foreach (var payment in c2.Payments)
            {
                Console.WriteLine(payment);
            }

            // Testing IComparable implementation
            Customer customer1 = new Customer("Stefan", "Canev", "Ivanov", "8712929211", "Krasna Polqna 11, Sofia",
                "0882737632", "asoto11@abv.bg", CustomerType.Regular);
            Customer customer2 = new Customer("Ivan", "Dobrev", "Zlatinov", "1119021121", "Krasna Polqna 11, Sofia",
                "0882737632", "asoto11@abv.bg", CustomerType.Regular);
            Customer customer3 = new Customer("Stefan", "Canev", "Ivanov", "1123411223", "Krasna Polqna 11, Sofia",
                "0882737632", "asoto11@abv.bg", CustomerType.Regular);

            List<Customer> customers = new List<Customer>();

            customers.Add(customer1);
            customers.Add(customer2);
            customers.Add(customer3);
            
            customers.Sort();

            foreach (var customer in customers)
            {
                Console.WriteLine(customer);
            }
        }
    }
}
