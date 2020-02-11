using System;

namespace Ternary_and_Access_Modifiers {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine(Customer.PrintNextID());
            Console.WriteLine($"The cube of 17 is {Cubed(17)}");

            var cust1 = new Customer ( "Max Technical Training" );
            var cust2 = new Customer("Amazon");
            var cust3 = new Customer("Target");
            cust1.NationalAccount("yes");

            var order1 = new Order { ID = 1, Amount = 1000, Customer = cust1 };

        }

        static int Cubed(int nbr) {
            return nbr * nbr * nbr;
        }

    }
}
