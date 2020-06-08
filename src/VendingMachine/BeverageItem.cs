using System;

class BeverageItem : VendableItem
{

    private bool is_liquid = true;

    public BeverageItem (string name, double price, double[] dimensions, string CatalogCode) 
        : base(name, )
    {
        this.name = name;
        this.CatalogCode = CatalogCode;
    }

    public override string CatalogCode { 
        get { return CatalogCode; }
        set { 
            if (value[0] != 'B')
            {
                throw new ArgumentException("All beverage items must begin their code with `B`");
            }
            else
            {
                CatalogCode = value;
            }
         }
}