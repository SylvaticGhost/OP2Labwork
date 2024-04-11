using System.Text;

namespace LabWork8;

public class Tablet : Gadget , IPortable
{
    public int Battery { get; init; }
    public int Weight { get; init; }
    public int FrontCameraPixels { get; init; }
    
    public bool HasSimCardSlot { get; init; }
    
    public bool HasFastCharge { get; init; }
    
    public Tablet ChangeOs(string os)
    {
        return new Tablet
        {
            Name = Name,
            Dimensions = Dimensions,
            Cors = Cors,
            RAM = RAM,
            Storage = Storage,
            OS = os,
            Battery = Battery,
            Weight = Weight,
            FrontCameraPixels = FrontCameraPixels
        };
    }
    
    public Tablet ChangeBattery(int battery)
    {
        return new Tablet
        {
            Name = Name,
            Dimensions = Dimensions,
            Cors = Cors,
            RAM = RAM,
            Storage = Storage,
            OS = OS,
            Battery = battery,
            Weight = Weight,
            FrontCameraPixels = FrontCameraPixels
        };
    }
    
    public Tablet AddOrRemoveSimCardSlot()
    {
        return new Tablet
        {
            Name = Name,
            Dimensions = Dimensions,
            Cors = Cors,
            RAM = RAM,
            Storage = Storage,
            OS = OS,
            Battery = Battery,
            Weight = Weight,
            FrontCameraPixels = FrontCameraPixels,
            HasSimCardSlot = !HasSimCardSlot
        };
    }


    public override string ToString()
    {
        StringBuilder stringBuilder = new();
        
        stringBuilder.AppendLine(base.ToString());
        stringBuilder.AppendLine($"Battery: {Battery}");
        stringBuilder.AppendLine($"Weight: {Weight}");
        stringBuilder.AppendLine($"Front Camera Pixels: {FrontCameraPixels}");
        stringBuilder.AppendLine($"Has Sim Card Slot: {HasSimCardSlot}");
        stringBuilder.AppendLine($"Has Fast Charge: {HasFastCharge}");
        
        return stringBuilder.ToString();
    }


    public override bool Equals(object? obj)
    {
        if(typeof(object) != typeof(Tablet))
        {
            return false;
        }
        
        Tablet tablet = (obj as Tablet)!;
        
        int size1 = Dimensions.Item1 * Dimensions.Item2;
        int size2 = tablet.Dimensions.Item1 * tablet.Dimensions.Item2;
        
        return size1 == size2 && Name == tablet.Name && Cors == tablet.Cors && RAM == tablet.RAM && Storage == tablet.Storage
               && OS == tablet.OS && Battery == tablet.Battery && Weight == tablet.Weight && FrontCameraPixels == tablet.FrontCameraPixels && HasSimCardSlot == tablet.HasSimCardSlot && HasFastCharge == tablet.HasFastCharge;
    }
}