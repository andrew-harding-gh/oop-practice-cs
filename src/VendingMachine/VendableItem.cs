using System;

abstract class VendableItem
{
    private string name;
    private bool is_liquid;
    private double _price;

    public VendableItem (string name, double price)
    {
        this.name = name;
        Price = price;
    }

    public virtual string CatalogCode { get; set; }
    public double Price
    {
        get { return _price; }
        set
        {
            if (value >= 0 && value <= 99.99)
            {
                _price = value;
            }
            else
            {
                throw new Exception ("Price can only be a value between 0 and 99.99");
            }
        }
    }
}