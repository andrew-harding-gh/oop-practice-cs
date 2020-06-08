using System;

abstract class VendableItem
{
    private string name;
    private double price;
    private bool is_liquid;
    
    public VendableItem (string name, double price)
    {
        this.name = name;
        Price = price;
    }

    public abstract string CatalogCode { get; set; }

    public double Price
    {
        get { return price; }
        set
        {
            if (value >= 0 && value <= 99.99)
            {
                price = value;
            }
            else
            {
                throw new Exception ("Price can only be a value between 0 and 99.99");
            }
        }
    }

    public override string ToString ()
    {
        return $"{this.name.ToUpper()} -- {Price:N2}";
    }
}