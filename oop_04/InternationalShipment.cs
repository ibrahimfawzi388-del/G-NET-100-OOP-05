using System;
using System.Collections.Generic;
using System.Text;

namespace oop_05
{
    public class InternationalShipment : Shipment
    {
        string DestinationCountry;
        decimal CustomsFee;

        public string destinationcountry
        {
            set
            {
                DestinationCountry = !string.IsNullOrWhiteSpace(value) ? value : DestinationCountry;
            }
            get => DestinationCountry;
        }
        public decimal customsfee
        {
            set
            {
                CustomsFee = value >= 0 ? value : CustomsFee;
            }
            get => CustomsFee;
        }
        public override decimal EstimatedCost
        {
            get => base.deliveryfee + (base.weight * 5) + customsfee;
        }
        public override decimal? CalculateInsurance()
        {
            return EstimatedCost * .12M;
        }
        public InternationalShipment() : base()
        {
            destinationcountry = default;
            customsfee = default;
        }
        public InternationalShipment(string code ,string city) : base()
        {
            destinationcountry = default;
            customsfee = default;
            trackingcode = code;
            Destination.City = city;
        }
        public override void PrintShipment()
        {
            Console.WriteLine();
            Console.WriteLine("International Shipment");
            Console.WriteLine();
            Console.WriteLine($"Destion Country : {destinationcountry}");
            Console.WriteLine($"Customs Fee : {customsfee}");
            Console.WriteLine($"Tracking Code is : {trackingcode} " +
                $"\nDescription is : {description}" +
                $"\n Weight is : {weight}" +
                $"\nDelivery Fee is : {deliveryfee}" +
                $"\nEstimated Cost is : {EstimatedCost}");
        }

        public virtual void GenerateCustomsReport() { }
    }
}
