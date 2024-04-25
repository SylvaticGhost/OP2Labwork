using System.Text;

namespace LabWork8;

public record Tablet : Gadget, IPortableGadget
{
    public bool HasLTEModule { get; }
    public int BatteryCapacityInMAh { get; }
    public int RearCameraResolutionInMP { get; }
    
    public Tablet(string brand, string model, decimal price, bool hasLteModule, int batteryCapacityInMAh, int rearCameraResolutionInMp) : base(brand, model, price)
    {
        HasLTEModule = hasLteModule;
        
        BatteryCapacityInMAh = batteryCapacityInMAh > 0? batteryCapacityInMAh 
            : throw new ArgumentException("Battery capacity must be greater than 0", nameof(batteryCapacityInMAh));
        
        RearCameraResolutionInMP = rearCameraResolutionInMp > 0? rearCameraResolutionInMp 
            : throw new ArgumentException("Rear camera resolution must be greater than 0", nameof(rearCameraResolutionInMp));
    }

    public override string GetGadgetType() => "Tablet";

    public override string GetInfoAboutGadget()
    {
        StringBuilder sb = new();
        sb.AppendLine(base.GetInfoAboutGadget());
        sb.AppendLine("Has LTE Module: " + HasLTEModule);
        sb.AppendLine("Battery Capacity: " + BatteryCapacityInMAh + " mAh");
        sb.AppendLine("Rear Camera Resolution: " + RearCameraResolutionInMP + " MP");
        return sb.ToString();
    }

    public override string ToString() =>$"Id: {Id}\n {GetInfoAboutGadget()}\n";

    public override Tablet Rename(string newBrand, string newModel)
    {
        if(string.IsNullOrWhiteSpace(newBrand))
            throw new ArgumentException("Brand argument cannot be null or empty", nameof(newBrand));
        
        if(string.IsNullOrWhiteSpace(newModel))
            throw new ArgumentException("Model argument cannot be null or empty", nameof(newModel));
        
        return new Tablet(newBrand, newModel, Price, HasLTEModule, BatteryCapacityInMAh, RearCameraResolutionInMP);
    }
    
    
    public override Tablet GadgetChangePrice(decimal newPrice)
    {
        if (newPrice <= 0)
            throw new ArgumentException("Price argument must be greater than 0", nameof(newPrice));
        
        return new Tablet(Brand, Model, newPrice, HasLTEModule, BatteryCapacityInMAh, RearCameraResolutionInMP);
    }
    
    
    public Tablet ChangeBatteryCapacity(int newBatteryCapacityInMAh)
    {
        if(newBatteryCapacityInMAh <= 0)
            throw new ArgumentException("Battery capacity must be greater than 0", nameof(newBatteryCapacityInMAh));
        
        return new Tablet(Brand, Model, Price, HasLTEModule, newBatteryCapacityInMAh, RearCameraResolutionInMP);
    }
}