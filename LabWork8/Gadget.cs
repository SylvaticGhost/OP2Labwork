using System.Text;

namespace LabWork8;

public abstract class Gadget
{
    public string Name { get; init; }
    
    public (int, int) Dimensions { get; init; }
    
    public virtual int Cors { get; init; }
    
    public int RAM { get; init; }
    
    public int Storage { get; init; }
    
    public string OS { get; init; }
    
    
    public override string ToString()
    {
        StringBuilder stringBuilder = new();
        
        stringBuilder.AppendLine($"Name: {Name}");
        stringBuilder.AppendLine($"Dimensions: {Dimensions.Item1}x{Dimensions.Item2}");
        stringBuilder.AppendLine($"Cors: {Cors}");
        stringBuilder.AppendLine($"RAM: {RAM}");
        stringBuilder.AppendLine($"Storage: {Storage}");
        stringBuilder.AppendLine($"OS: {OS}");
        
        return stringBuilder.ToString();
    }
    
}

