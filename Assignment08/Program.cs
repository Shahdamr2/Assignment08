namespace Assignment09;
using Assignment08.Entities;
using Assignment08.Inheritance;
using Assignment08.Interfaces;
using Assignment08.Reports;


    internal class Program
    {
        static void Main(string[] args)
        {
        #region Question 1

        // Abstraction means hiding implementation details
        // and showing only the important features of an object

        // It helps reduce complexity and focuses on what the object does
        // instead of how it does it

        #endregion
        #region Question 2

        // a) An abstract class can contain fields, properties, constructors,
        // normal methods, and abstract methods
        // An interface is mainly used to define a contract

        // b) We use an interface when different classes need
        // to follow the same contract

        // c) A class can inherit from only one abstract class,
        // but it can implement multiple interfaces

        #endregion
        
        #region Practical Question 8

        DeliveryAddress address =
            new DeliveryAddress(
                "Cairo",
                "Tahrir Street",
                15);

        DeliveryCenter center =
            new DeliveryCenter("Delivery Center");

        StandardShipment standardShipment =
            new StandardShipment(
                "SH001",
                "Laptop",
                3,
                80,
                address);

        ExpressShipment expressShipment =
            new ExpressShipment(
                "SH002",
                "Mobile",
                2,
                60,
                address,
                30);

        InternationalShipment internationalShipment =
            new InternationalShipment(
                "SH003",
                "Medical Equipment",
                4,
                100,
                address,
                "Germany",
                140);

        center.AddShipment(standardShipment);
        center.AddShipment(expressShipment);
        center.AddShipment(internationalShipment);

        Console.WriteLine("==========================================");
        Console.WriteLine("Delivery Center");
        Console.WriteLine("==========================================");
        Console.WriteLine();

        center.PrintAllShipments();

        Console.WriteLine("==========================================");
        Console.WriteLine("Tracking Status");
        Console.WriteLine();

        center.PrintTrackingStatuses();

        Console.WriteLine("==========================================");
        Console.WriteLine("Insurance");
        Console.WriteLine();

        DeliveryReport report =
            new DeliveryReport();

        IInsurable[] insurableShipments =
        {
            standardShipment,
            expressShipment,
            internationalShipment
        };

        foreach (IInsurable shipment in insurableShipments)
        {
            report.PrintInsurance(shipment);
        }

        Console.WriteLine();

        Console.WriteLine("==========================================");
        Console.WriteLine();

        ITrackable[] trackableShipments =
        {
            standardShipment,
            expressShipment,
            internationalShipment
        };

        foreach (ITrackable shipment in trackableShipments)
        {
            shipment.GetTrackingStatus();
        }

        Console.WriteLine("Interface Polymorphism Demonstrated Successfully.");

        #endregion
        

    }
}

