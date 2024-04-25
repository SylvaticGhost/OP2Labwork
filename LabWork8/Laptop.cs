using System.Text;

namespace LabWork8;

public record Laptop : Gadget, IComputerGadget, IPortableGadget
{
    public bool HasVideoCard { get; }
    public int DiskSlots { get; }
    public bool HasLTEModule { get; }
    public int BatteryCapacityInMAh { get; }
    public bool HasBacklight { get; }
    
    public Laptop(string brand, string model, decimal price, bool hasVideoCard, bool hasLteModule, bool hasBacklight,
        int batteryCapacityInMAh, int diskSlots) : base(brand, model, price)
    {
        HasVideoCard = hasVideoCard;
        HasLTEModule = hasLteModule;
        HasBacklight = hasBacklight;
        
        BatteryCapacityInMAh = batteryCapacityInMAh > 0? batteryCapacityInMAh 
            : throw new ArgumentException("Battery capacity must be greater than 0", nameof(batteryCapacityInMAh));
        
        DiskSlots = diskSlots > 0? diskSlots 
            : throw new ArgumentException("Disk slots must be greater than 0", nameof(diskSlots));
    }

    public override string GetGadgetType() => "Laptop";
    
    public override string GetInfoAboutGadget()
    {
        StringBuilder sb = new();
        sb.AppendLine(base.GetInfoAboutGadget());
        sb.AppendLine("Has Video Card: " + HasVideoCard);
        sb.AppendLine("Has LTE Module: " + HasLTEModule);
        sb.AppendLine("Has Backlight: " + HasBacklight);
        sb.AppendLine("Battery Capacity: " + BatteryCapacityInMAh + " mAh");
        sb.AppendLine("Disk Slots: " + DiskSlots);
        return sb.ToString();
    }
    
    
    public override string ToString() => $"Id: {Id}\n {GetInfoAboutGadget()}\n";
    
    
    public Laptop AddVideoCard()
    {
        if(HasVideoCard)
            throw new InvalidOperationException("This laptop already has a video card");
        
        return new Laptop(Brand, Model, Price, true, HasLTEModule, HasBacklight, BatteryCapacityInMAh, DiskSlots);
    }
    
    
    public Laptop RemoveVideoCard()
    {
        if(!HasVideoCard)
            throw new InvalidOperationException("This laptop does not have a video card");
        
        return new Laptop(Brand, Model, Price, false, HasLTEModule, HasBacklight, BatteryCapacityInMAh, DiskSlots);
    }
    
    
    public override Laptop Rename(string newBrand, string newModel)
    {
        if(string.IsNullOrWhiteSpace(newBrand))
            throw new ArgumentException("Brand argument cannot be null or empty", nameof(newBrand));
        
        if(string.IsNullOrWhiteSpace(newModel))
            throw new ArgumentException("Model argument cannot be null or empty", nameof(newModel));
        
        return new Laptop(newBrand, newModel, Price, HasVideoCard, HasLTEModule, HasBacklight, BatteryCapacityInMAh, DiskSlots);
    }
    
    
    public override Laptop GadgetChangePrice(decimal newPrice)
    {
        if (newPrice <= 0)
            throw new ArgumentException("Price argument must be greater than 0", nameof(newPrice));
        
        return new Laptop(Brand, Model, newPrice, HasVideoCard, HasLTEModule, HasBacklight, BatteryCapacityInMAh, DiskSlots);
    }
    
    
    /// <param name="newBatteryCapacity">Capacity of new battery in mAh</param>
    public Laptop ChangeBatteryCapacity(int newBatteryCapacity)
    {
        if (newBatteryCapacity <= 0)
            throw new ArgumentException("Battery capacity must be greater than 0", nameof(newBatteryCapacity));
        
        return new Laptop(Brand, Model, Price, HasVideoCard, HasLTEModule, HasBacklight, newBatteryCapacity, DiskSlots);
    }
    
}