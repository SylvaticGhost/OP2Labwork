using System.Text;

namespace LabWork8;

public sealed class Laptop : Gadget, IPortable, IComputer
{
    public int Battery { get; init; }
    
    public int Weight { get; init; }
    
    public int GPU { get; init; }
    
    public Laptop ChangeOs(string os)
    {
        return new Laptop
        {
            Name = Name,
            Dimensions = Dimensions,
            Cors = Cors,
            RAM = RAM,
            Storage = Storage,
            OS = os,
            Battery = Battery,
            Weight = Weight,
            GPU = GPU
            
        };
    }
    
    
    public  Laptop ChangeBattery(int battery)
    {
        return new Laptop
        {
            Name = Name,
            Dimensions = Dimensions,
            Cors = Cors,
            RAM = RAM,
            Storage = Storage,
            OS = OS,
            Battery = battery,
            Weight = Weight,
            GPU = GPU
        };
    }

    public override string ToString()
    {
        StringBuilder stringBuilder = new();
        
        stringBuilder.AppendLine(base.ToString());
        stringBuilder.AppendLine($"Battery: {Battery}");
        stringBuilder.AppendLine($"Weight: {Weight}");
        stringBuilder.AppendLine($"GPU: {GPU}");
        
        return stringBuilder.ToString();
    }


    public override bool Equals(object? obj)
    {
        if(typeof(object) != typeof(Laptop))
        {
            return false;
        }
        
        Laptop laptop = (Laptop)obj;
        
        return Name == laptop.Name && Dimensions == laptop.Dimensions && Cors == laptop.Cors && RAM == laptop.RAM && 
               Storage == laptop.Storage && OS == laptop.OS && Battery == laptop.Battery && Weight == laptop.Weight && GPU == laptop.GPU;
    }
}
