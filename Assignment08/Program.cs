using Assignment08.Entities;
using Assignment08.Inheritance;

namespace Assignment08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1

            // a) Overloading means using the same method name with different parameters
            // Overriding means changing the implementation of a method in the child class

            // b) Static Binding is decided at compile time
            // Dynamic Binding is decided at runtime depending on the actual object

            #endregion
            #region Question 2

            // a) A sealed class cannot be inherited by another class

            // b) A sealed class prevents inheritance.
            // A sealed method prevents further overriding of a method

            // c) No, a sealed method cannot be overridden because
            // it stops further overriding in derived classes

            #endregion
            #region Question 3

            //Shipment shipment =
            //    new Shipment(
            //        "SH001",
            //        "Laptop",
            //        3,
            //        80,
            //        new DeliveryAddress("Cairo", "Tahrir Street", 15));

            //shipment.PrintShipment();

            //Console.WriteLine();

            //shipment.UpdateWeight(4);

            //Console.WriteLine("After updating weight:");

            //shipment.PrintShipment();

            //Console.WriteLine();

            //shipment.UpdateWeight(5, 1);

            //Console.WriteLine("After adding packing weight:");

            //shipment.PrintShipment();

            #endregion
            #region Question 4

            DeliveryAddress address =
                new DeliveryAddress("Cairo", "Tahrir Street", 15);

            StandardShipment standardShipment =
                new StandardShipment(
                    "SH101",
                    "Laptop",
                    3,
                    80,
                    address);

            ExpressShipment expressShipment =
                new ExpressShipment(
                    "SH102",
                    "Mobile",
                    2,
                    100,
                    address,
                    50);

            InternationalShipment internationalShipment =
                new InternationalShipment(
                    "SH103",
                    "Tablet",
                    4,
                    120,
                    address,
                    "USA",
                    70);

            standardShipment.PrintShipment();

            Console.WriteLine();

            expressShipment.PrintShipment();

            Console.WriteLine();

            internationalShipment.PrintShipment();

            #endregion
        }
    }
}
