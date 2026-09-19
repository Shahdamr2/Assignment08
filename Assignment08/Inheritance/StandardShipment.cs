using Assignment08.Entities;

namespace Assignment08.Inheritance
{
    public class StandardShipment : Shipment
    {
        public StandardShipment(
            string trackingCode,
            string description,
            decimal weight,
            decimal deliveryFee,
            DeliveryAddress destination)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
        }
    }
}