using Assignment08.Entities;

namespace Assignment08.Inheritance
{
    public class InternationalShipment : Shipment
    {
        public string DestinationCountry { get; set; }
        public decimal CustomsFee { get; set; }

        public InternationalShipment(
            string trackingCode,
            string description,
            decimal weight,
            decimal deliveryFee,
            DeliveryAddress destination,
            string destinationCountry,
            decimal customsFee)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
            DestinationCountry = destinationCountry;
            CustomsFee = customsFee;
        }

        public override decimal EstimatedCost
        {
            get { return base.EstimatedCost + CustomsFee; }
        }

        public override void PrintShipment()
        {
            base.PrintShipment();
            Console.WriteLine($"Destination Country: {DestinationCountry}");
            Console.WriteLine($"Customs Fee        : {CustomsFee} EGP");
            Console.WriteLine("Shipment Type: International");
        }

        public virtual void GenerateCustomsReport()
        {
            Console.WriteLine($"Customs Report for {DestinationCountry}");
        }
    }
}