using System.Text;

namespace LabWork8;

public record PersonalComputer : Gadget, IComputerGadget
{
    public bool HasVideoCard { get; }
    
    public int DiskSlots { get; }
    
    public PersonalComputer(string brand, string model, decimal price, bool hasVideoCard, int diskSlots) : base(brand, model, price)
    {
        HasVideoCard = hasVideoCard;
        DiskSlots = diskSlots > 0? diskSlots 
            : throw new ArgumentException("Disk slots must be greater than 0", nameof(diskSlots));
    }

    public override string GetGadgetType() => "Personal Computer";

    public override string GetInfoAboutGadget() =>
        $"{base.GetInfoAboutGadget()}\nHas Video Card: {HasVideoCard}\nDisk Slots: {DiskSlots}";

    public override string ToString() =>
        $"{base.ToString()}\nHas Video Card: {HasVideoCard}\nDisk Slots: {DiskSlots}";
    
    
    public PersonalComputer AddVideoCard()
    {
        if(HasVideoCard)
            throw new InvalidOperationException("This computer already has a video card");
        
        return new PersonalComputer(Brand, Model, Price, true, DiskSlots);
    }
    
    public PersonalComputer RemoveVideoCard()
    {
        if(!HasVideoCard)
            throw new InvalidOperationException("This computer does not have a video card");
        
        return new PersonalComputer(Brand, Model, Price, false, DiskSlots);
    }
    
    
    public override PersonalComputer Rename(string newBrand, string newModel)
    {
        if(string.IsNullOrWhiteSpace(newBrand))
            throw new ArgumentException("Brand argument cannot be null or empty", nameof(newBrand));
        
        if(string.IsNullOrWhiteSpace(newModel))
            throw new ArgumentException("Model argument cannot be null or empty", nameof(newModel));
        
        return new PersonalComputer(newBrand, newModel, Price, HasVideoCard, DiskSlots);
    }
    
    
    public override PersonalComputer GadgetChangePrice(decimal newPrice)
    {
        if (newPrice <= 0)
            throw new ArgumentException("Price argument must be greater than 0", nameof(newPrice));
        
        return new PersonalComputer(Brand, Model, newPrice, HasVideoCard, DiskSlots);
    }
}