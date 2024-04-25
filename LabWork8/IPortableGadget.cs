namespace LabWork8;

public interface IPortableGadget
{
    public bool HasLTEModule { get; }
    
    public int BatteryCapacityInMAh { get; }
}