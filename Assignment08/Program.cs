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

            //DeliveryAddress address =
            //    new DeliveryAddress("Cairo", "Tahrir Street", 15);

            //StandardShipment standardShipment =
            //    new StandardShipment(
            //        "SH101",
            //        "Laptop",
            //        3,
            //        80,
            //        address);

            //ExpressShipment expressShipment =
            //    new ExpressShipment(
            //        "SH102",
            //        "Mobile",
            //        2,
            //        100,
            //        address,
            //        50);

            //InternationalShipment internationalShipment =
            //    new InternationalShipment(
            //        "SH103",
            //        "Tablet",
            //        4,
            //        120,
            //        address,
            //        "USA",
            //        70);

            //standardShipment.PrintShipment();

            //Console.WriteLine();

            //expressShipment.PrintShipment();

            //Console.WriteLine();

            //internationalShipment.PrintShipment();

            #endregion
            #region Question 5

            //DeliveryAddress address =
            //    new DeliveryAddress("Cairo", "Tahrir Street", 15);

            //StandardShipment standardShipment =
            //    new StandardShipment(
            //        "SH101",
            //        "Laptop",
            //        3,
            //        80,
            //        address);

            //ExpressShipment expressShipment =
            //    new ExpressShipment(
            //        "SH102",
            //        "Mobile",
            //        2,
            //        100,
            //        address,
            //        50);

            //InternationalShipment internationalShipment =
            //    new InternationalShipment(
            //        "SH103",
            //        "Tablet",
            //        4,
            //        120,
            //        address,
            //        "USA",
            //        70);

            //Console.WriteLine($"Standard Estimated Cost: {standardShipment.EstimatedCost} EGP");

            //Console.WriteLine($"Express Estimated Cost: {expressShipment.EstimatedCost} EGP");

            //Console.WriteLine($"International Estimated Cost: {internationalShipment.EstimatedCost} EGP");

            #endregion
            #region Question 6

            //DeliveryAddress address =
            //    new DeliveryAddress("Cairo", "Tahrir Street", 15);

            //StandardShipment standardShipment =
            //    new StandardShipment(
            //        "SH101",
            //        "Laptop",
            //        3,
            //        80,
            //        address);

            //ExpressShipment expressShipment =
            //    new ExpressShipment(
            //        "SH102",
            //        "Mobile",
            //        2,
            //        100,
            //        address,
            //        50);

            //InternationalShipment internationalShipment =
            //    new InternationalShipment(
            //        "SH103",
            //        "Tablet",
            //        4,
            //        120,
            //        address,
            //        "USA",
            //        70);

            //standardShipment.PrintShipment();

            //Console.WriteLine();

            //expressShipment.PrintShipment();

            //Console.WriteLine();

            //internationalShipment.PrintShipment();

            #endregion
            #region Question 7

            //DeliveryCenter center =
            //    new DeliveryCenter("Main Delivery Center");

            //DeliveryAddress address =
            //    new DeliveryAddress("Cairo", "Tahrir Street", 15);

            //StandardShipment standardShipment =
            //    new StandardShipment(
            //        "SH101",
            //        "Laptop",
            //        3,
            //        80,
            //        address);

            //ExpressShipment expressShipment =
            //    new ExpressShipment(
            //        "SH102",
            //        "Mobile",
            //        2,
            //        100,
            //        address,
            //        50);

            //InternationalShipment internationalShipment =
            //    new InternationalShipment(
            //        "SH103",
            //        "Tablet",
            //        4,
            //        120,
            //        address,
            //        "USA",
            //        70);

            //center.AddShipment(standardShipment);
            //center.AddShipment(expressShipment);
            //center.AddShipment(internationalShipment);

            //center.PrintAllShipments();

            #endregion
            #region Question 8

            //DeliveryAddress address =
            //    new DeliveryAddress("Cairo", "Tahrir Street", 15);

            //StandardShipment standardShipment =
            //    new StandardShipment(
            //        "SH101",
            //        "Laptop",
            //        3,
            //        80,
            //        address);

            //ExpressShipment expressShipment =
            //    new ExpressShipment(
            //        "SH102",
            //        "Mobile",
            //        2,
            //        100,
            //        address,
            //        50);

            //InternationalShipment internationalShipment =
            //    new InternationalShipment(
            //        "SH103",
            //        "Tablet",
            //        4,
            //        120,
            //        address,
            //        "USA",
            //        70);

            //DeliveryHelper.PrintShipmentDetails(standardShipment);

            //Console.WriteLine();

            //DeliveryHelper.PrintShipmentDetails(expressShipment);

            //Console.WriteLine();

            //DeliveryHelper.PrintShipmentDetails(internationalShipment);

            #endregion
            #region Question 9

            //DeliveryAddress address =
            //    new DeliveryAddress("Cairo", "Tahrir Street", 15);

            //CompletedShipment completedShipment =
            //    new CompletedShipment(
            //        "SH104",
            //        "Computer",
            //        5,
            //        150,
            //        address);

            //completedShipment.PrintShipment();

            #endregion
            #region Question 10

            //DeliveryAddress address =
            //    new DeliveryAddress("Cairo", "Tahrir Street", 15);

            //PriorityInternationalShipment priorityShipment =
            //    new PriorityInternationalShipment(
            //        "SH105",
            //        "Medical Equipment",
            //        6,
            //        200,
            //        address,
            //        "Germany",
            //        100);

            //priorityShipment.GenerateCustomsReport();

            #endregion
            #region Question 11

            DeliveryCenter center =
                new DeliveryCenter("Main Delivery Center");

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

            center.AddShipment(standardShipment);
            center.AddShipment(expressShipment);
            center.AddShipment(internationalShipment);

            Console.WriteLine("All Shipments:");
            Console.WriteLine();

            center.PrintAllShipments();

            Console.WriteLine("Using DeliveryHelper:");
            Console.WriteLine();

            DeliveryHelper.PrintShipmentDetails(expressShipment);

            Console.WriteLine();

            Console.WriteLine("Updating Weight:");

            standardShipment.UpdateWeight(4);
            standardShipment.PrintShipment();

            Console.WriteLine();

            standardShipment.UpdateWeight(5, 1);
            standardShipment.PrintShipment();

            Console.WriteLine();

            Console.WriteLine("Polymorphism:");

            Shipment[] shipments =
            {
    standardShipment,
    expressShipment,
    internationalShipment
};

            foreach (Shipment shipment in shipments)
            {
                shipment.PrintShipment();
                Console.WriteLine();
            }

            Console.WriteLine("Sealed Class:");

            CompletedShipment completedShipment =
                new CompletedShipment(
                    "SH104",
                    "Computer",
                    5,
                    150,
                    address);

            completedShipment.PrintShipment();

            Console.WriteLine();

            Console.WriteLine("Sealed Method:");

            PriorityInternationalShipment priorityShipment =
                new PriorityInternationalShipment(
                    "SH105",
                    "Medical Equipment",
                    6,
                    200,
                    address,
                    "Germany",
                    100);

            priorityShipment.GenerateCustomsReport();

            #endregion
        }
    }
}
