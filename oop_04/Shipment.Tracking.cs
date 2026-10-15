
namespace oop_05
{
    public abstract partial class Shipment : IInsurable, ITrackable
    {
        public string statue;
        public virtual decimal? CalculateInsurance()
        {
            return default;
        }
        public string GetTrackingStatus()
        {
            return statue;
        }
        public void UpdateDeliveryFee(decimal newFee)
        {
            deliveryfee = newFee;
        }

        public virtual void PrintShipment()
        {

        }

        public void updateWeight(decimal newWeight)
        {
            weight = newWeight;
        }
        public void updateWeight(decimal newWeight, decimal extraPackingWeight)
        {
            weight = newWeight + extraPackingWeight;
        }
        public static int GetTotalShipmentsCreated()
        {
            return TotalShipmentsCreated;
        }

        public partial void OnTrackingStatusChanged(string newStatus)
        {
            Console.WriteLine($"Tracking status changed to: {newStatus}");
        }
    }
}
