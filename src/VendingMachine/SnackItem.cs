using System;

class SnackItem : VendableItem
{

    private bool is_liquid = false;
    private string catalog_code;

    public SnackItem (string name, double price, string code) : base (name, price)
    {
        CatalogCode = code;
    }

    public override string CatalogCode
    {
        get { return this.catalog_code; }
        set
        {
            if (value[0] != 'S')
            {
                throw new ArgumentException ("All food items must begin their code with `S`");
            }
            else
            {
                this.catalog_code = value;
            }
        }
    }
}