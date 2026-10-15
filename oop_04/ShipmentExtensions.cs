
namespace oop_05
{
    public static class ShipmentExtensions
    {
        public static string GetSummary(this Shipment shipment)
        {
            return $"{shipment.trackingcode} | {shipment.GetType().Name} | " +
                   $"{shipment.weight} KG | {shipment.GetTrackingStatus()}";
        }

        public static bool IsDelivered(this Shipment shipment)
        {
            return shipment.GetTrackingStatus() == "Delivered";
        }
    }
}
