using System;
using System.Collections.Generic;
using System.Text;

namespace oop_05
{
    internal class ExpressShipment : Shipment
    {
        private decimal ExtraFee;

        public decimal extraFee
        {
            set
            {
                ExtraFee = value >= 0 ? value : ExtraFee;
            }
            get
            {
                return ExtraFee;
            }
        }
        public override decimal EstimatedCost
        {
            get => base.deliveryfee + (base.weight * 5) + extraFee;
        }
        public ExpressShipment() : base()
        {
            extraFee = default;
        }

        public override decimal? CalculateInsurance()
        {
            return EstimatedCost * .08M;
        }
        public override string? GetTrackingStatus()
        {
            return "Out for Delivery";
        }

        public override void PrintShipment()
        {
            Console.WriteLine();
            Console.WriteLine("Express Shipment");
            Console.WriteLine();
            Console.WriteLine($"Extra Fee is : {extraFee}");
            Console.WriteLine($"Tracking Code is : {trackingcode} " +
                $"\nDescription is : {description}" +
                $"\n Weight is : {weight}" +
                $"\nDelivery Fee is : {deliveryfee}" +
                $"\nEstimated Cost is : {EstimatedCost}");
        }
    }
}
