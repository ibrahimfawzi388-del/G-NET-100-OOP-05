using System;
using System.Collections.Generic;
using System.Text;

namespace oop_05
{
    public abstract partial class Shipment : IInsurable, ITrackable
    {
        string TrackingCode;
        string Description;
        decimal Weight;
        decimal DeliveryFee;
        public static int TotalShipmentsCreated ;
        public DeliveryAddress Destination;

        
        public string trackingcode
        {
            get => TrackingCode;

            set
            {
                TrackingCode = !string.IsNullOrWhiteSpace(value) ? value : TrackingCode;
            }
        }

        public string description
        {
            get => Description;

            set
            {
                Description = !string.IsNullOrWhiteSpace(value) ? value : Description;
            }
        }

        public decimal weight
        {
            get => Weight;

            set
            {
                Weight = value > 0 ? value : Weight;
            }
        }
        public decimal deliveryfee
        {
            get => DeliveryFee;

            set
            {
                DeliveryFee = value > 0 ? value : DeliveryFee;
            }
        }

        public virtual decimal EstimatedCost { get; }

        public Shipment()
        {
            weight = default;
            description = default;
            deliveryfee = default;
            Destination = default;
            trackingcode = default;
        }
        public Shipment(string TrackingCode)
        {
            trackingcode = TrackingCode;
            description = "Unknown";
            weight = 1;
            deliveryfee = 50;
            Destination = new DeliveryAddress();
        }

        public Shipment(string trackingcode, string description, decimal weight, decimal deliveryfree, DeliveryAddress destination)
        {
            this.trackingcode = trackingcode;
            this.description = description;
            this.weight = weight;
            this.deliveryfee = deliveryfree;
            this.Destination = destination;
        }

        


        

        public Shipment ShallowCopy()
        {
            return (Shipment)MemberwiseClone();
        }

        public Shipment DeepCopy()
        {
            Shipment shipment = (Shipment)MemberwiseClone();
            shipment.Destination =new DeliveryAddress(this.Destination.Street,this.Destination.City,this.Destination.BuildingNumber);
            return shipment;
        }

        static Shipment()
        {
            TotalShipmentsCreated = 0;
            Console.WriteLine("Shipment System Initialized");
        }

        public partial void OnTrackingStatusChanged(string newStatus);

        public void UpdateTrackingStatus(string newStatus)
        {
            statue = newStatus;
            OnTrackingStatusChanged(newStatus);
        }
    }
}
