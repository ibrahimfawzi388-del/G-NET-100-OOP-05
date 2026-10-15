using System;
using System.Collections.Generic;
using System.Text;

namespace oop_05
{
    public class DeliveryCenter
    {
        private Shipment[]? Shipments;
        private bool[] position;
        public string CenterName;
        public DeliveryCenter()
        {
            Shipments = new Shipment[20];
            position = new bool[20];
        }
        public Shipment this[int index]
        {
            get
            {
                if (index >= 0 && index < 20 && position[index])
                {
                    return Shipments[index];
                }
                return default;
            }
            set
            {
                if (index >= 0 && index < 20 && position[index])
                {
                    Shipments[index] = value;
                }
            }
        }
        public Shipment this[string code]
        {
            get
            {
                for (int i = 0; i < 20; i++)
                {
                    if (Shipments[i].trackingcode == code)
                    {
                        return Shipments[i];
                    }
                }
                return default;
            }
        }
        public bool AddShipment(Shipment shipment)
        {
            for (int i = 0; i < 20; i++)
            {
                if (!position[i])
                {
                    Shipments[i] = shipment;
                    position[i] = true;

                    Console.WriteLine("shipment added Successfully");

                    return true;
                }
            }
            return false;
        }

        public bool RemoveShipment(string code)
        {
            for (int i = 0; i < 20; i++)
            {
                if (Shipments[i].trackingcode == code)
                {
                    Shipments[i] = default;
                    position[i] = false;
                    return true;
                }
            }
            return false;
        }
        public void PrintTrackingStatuses()
        {
            for (int i = 0; i < 20; i++)
            {
                if (position[i])
                {
                    Console.WriteLine(Shipments[i].GetTrackingStatus());
                }
            }
        }
        public void PrintTrackingInsurance()
        {
            for (int i = 0; i < 20; i++)
            {
                if (position[i])
                {
                    Console.WriteLine(Shipments[i].CalculateInsurance());
                }
            }
        }
        public void PrintAllShipments()
        {
            Console.WriteLine($"Delivery Center : {CenterName}");
            for (int i = 0; i < 20; i++)
            {
                if (position[i])
                {
                    Shipments[i].PrintShipment();
                }
            }
        }
    }
}
