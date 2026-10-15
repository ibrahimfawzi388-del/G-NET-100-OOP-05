using oop_05;
using System.Threading.Channels;

namespace oop_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DeliveryUtilities.PrintSystemTitle();

            Shipment Express =new ExpressShipment("SH001","cairo");

            Shipment Standard =new StandardShipment("SH001","cairo");

            Shipment International =new InternationalShipment("SH001","Cairo");
            DeliveryCenter deliveryCenter = new DeliveryCenter();
            deliveryCenter.AddShipment(Express);
            deliveryCenter.AddShipment(Standard);
            deliveryCenter.AddShipment(International);

            Console.WriteLine(Shipment.GetTotalShipmentsCreated());

            Console.WriteLine("=======================");
            Console.WriteLine("Object Copying");
            Console.WriteLine("=======================");

            Shipment Object = Standard;
            Object.trackingcode = "SH002";
            Object.Destination.City = "Giza";
            Console.WriteLine(Object.trackingcode);
            Console.WriteLine(Object.Destination.City);
            Console.WriteLine(Standard.trackingcode);
            Console.WriteLine(Standard.Destination.City);

            Console.WriteLine("=======================");
            Console.WriteLine("Shallow Copy");
            Console.WriteLine("=======================");

            Shipment shallow = Express.ShallowCopy();
            shallow.trackingcode = "SH002";
            shallow.Destination.City = "Giza";
            Console.WriteLine(shallow.trackingcode);
            Console.WriteLine(shallow.Destination.City);
            Console.WriteLine(Express.trackingcode);
            Console.WriteLine(Express.Destination.City);

            Console.WriteLine("=======================");
            Console.WriteLine("Deep Copy");
            Console.WriteLine("=======================");

            Shipment deep = International.ShallowCopy();
            deep.trackingcode = "SH002";
            deep.Destination.City = "Giza";
            Console.WriteLine(deep.trackingcode);
            Console.WriteLine(deep.Destination.City);
            Console.WriteLine(International.trackingcode);
            Console.WriteLine(International.Destination.City);
            Console.WriteLine("=======================");
            Console.WriteLine("Tracking Status");
            Console.WriteLine("=======================");
            Express.UpdateTrackingStatus("Delivered");
            Console.WriteLine("=======================");
            Console.WriteLine("Extension Methods");
            Console.WriteLine("=======================");
            Console.WriteLine(Express.GetSummary());
            Console.Write($"{Express.trackingcode} is Delivered ");
            if(Express.IsDelivered()) Console.WriteLine("yes");
            else Console.WriteLine("NO");
        }
    }
}
