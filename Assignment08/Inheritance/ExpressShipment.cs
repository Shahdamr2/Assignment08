using Assignment08.Entities;

namespace Assignment08.Inheritance
{
    public class ExpressShipment : Shipment
    {
        public decimal ExtraFee { get; set; }

        public ExpressShipment(
            string trackingCode,
            string description,
            decimal weight,
            decimal deliveryFee,
            DeliveryAddress destination,
            decimal extraFee)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
            ExtraFee = extraFee;
        }

        public override decimal EstimatedCost
        {
            get { return base.EstimatedCost + ExtraFee; }
        }
    }
}