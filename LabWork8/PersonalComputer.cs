using System.Text;

namespace LabWork8;

public class PersonalComputer : Gadget, IComputer
{
    public int GPU { get; init; }
    
    

    public PersonalComputer()
    {
        
    }

    public PersonalComputer AddDisk(int diskSpace)
    {
        return new PersonalComputer()
        {
            Name = Name,
            Dimensions = Dimensions,
            Cors = Cors,
            RAM = RAM,
            Storage = Storage + diskSpace,
            OS = OS,
            GPU = GPU
        };
    }


    public PersonalComputer ChangeOs(string os)
    {
        return new PersonalComputer
        {
            Name = Name,
            Dimensions = Dimensions,
            Cors = Cors,
            RAM = RAM,
            Storage = Storage,
            OS = os,
            GPU = GPU
        };
    }
    
    
    public override string ToString()
    {
        StringBuilder stringBuilder = new();
        
        stringBuilder.AppendLine(base.ToString());
        stringBuilder.AppendLine($"GPU: {GPU}");
        
        return stringBuilder.ToString();
    }
    
    
    public override bool Equals(object? obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        PersonalComputer personalComputer = (PersonalComputer) obj;
        
        return Name == personalComputer.Name && Dimensions == personalComputer.Dimensions && Cors == personalComputer.Cors && RAM == personalComputer.RAM && Storage == personalComputer.Storage && OS == personalComputer.OS && GPU == personalComputer.GPU;
    }
}