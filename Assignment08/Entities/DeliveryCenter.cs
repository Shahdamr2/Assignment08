using System;

namespace Assignment08.Entities
{
    public class DeliveryCenter
    {
        private Shipment?[] shipments;
        private int count;

        public string Name { get; set; }

        public DeliveryCenter(string name)
        {
            Name = name;
            shipments = new Shipment?[20];
            count = 0;
        }

        public Shipment? this[int index]
        {
            get
            {
                if (index >= 0 && index < shipments.Length)
                {
                    return shipments[index];
                }

                return null;
            }
        }

        public void AddShipment(Shipment shipment)
        {
            if (shipment != null && count < shipments.Length)
            {
                shipments[count] = shipment;
                count++;
            }
        }

        public bool RemoveShipment(string trackingCode)
        {
            for (int i = 0; i < count; i++)
            {
                if (shipments[i] != null &&
                    shipments[i].TrackingCode == trackingCode)
                {
                    for (int j = i; j < count - 1; j++)
                    {
                        shipments[j] = shipments[j + 1];
                    }

                    shipments[count - 1] = null;
                    count--;

                    return true;
                }
            }

            return false;
        }

        public void PrintAllShipments()
        {
            for (int i = 0; i < count; i++)
            {
                if (shipments[i] != null)
                {
                    shipments[i].PrintShipment();
                    Console.WriteLine();
                }
            }
        }
    }
}