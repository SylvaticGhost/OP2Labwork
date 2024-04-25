using System.Text;

namespace LabWork8;

public abstract record Gadget
{
    public Guid Id { get; }
    public string Brand { get;  }
    public string Model { get;  }
    public decimal Price { get;  }
    
    protected Gadget(string brand, string model, decimal price)
    {
        if(string.IsNullOrWhiteSpace(brand))
            throw new ArgumentException("Brand argument cannot be null or empty", nameof(brand));
        
        if(string.IsNullOrWhiteSpace(model))
            throw new ArgumentException("Model argument cannot be null or empty", nameof(model));

        if (price <= 0)
            throw new ArgumentException("Price argument must be greater than 0", nameof(price));
        
        Id = Guid.NewGuid();
        Brand = brand;
        Model = model;
        Price = price;
    }

    public override string ToString() => $"Id: {Id}\n {GetInfoAboutGadget()}\n";
    
    public abstract string GetGadgetType();
    
    
    public virtual string GetInfoAboutGadget() => 
        $"Brand: {Brand}, Model: {Model}, Price: {Price}";

    public abstract Gadget Rename(string newBrand, string newModel);
    
    public abstract Gadget GadgetChangePrice(decimal newPrice);
}