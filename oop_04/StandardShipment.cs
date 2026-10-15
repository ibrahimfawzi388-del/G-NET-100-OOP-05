using System;
using System.Collections.Generic;
using System.Text;

namespace oop_05
{
    public class StandardShipment : Shipment
    {
        public StandardShipment() : base() { }
        public StandardShipment(string code,string city) : base()
        {
            trackingcode = code;
            Destination.City = city;
        }
        public override decimal EstimatedCost
        {
            get => base.deliveryfee + (base.weight * 5);
        }
        public override decimal? CalculateInsurance()
        {
            return EstimatedCost * .05M;
        }
        public override void PrintShipment()
        {
            Console.WriteLine();
            Console.WriteLine("Standard Shipment");
            Console.WriteLine();
            Console.WriteLine($"Tracking Code is : {trackingcode} " +
                $"\nDescription is : {description}" +
                $"\n Weight is : {weight}" +
                $"\nDelivery Fee is : {deliveryfee}" +
                $"\nEstimated Cost is : {EstimatedCost}");
        }
    }
}
