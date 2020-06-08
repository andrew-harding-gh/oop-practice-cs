using System;

abstract class VendableItem
{
    private string _catalog_code;
    private double _dimx;
    private double _dimy;
    private double _dimz;
    public bool liquid { get; set; }
    public string name { get; set; }

    private double _price;
    public double price
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

    public double dim_x
    {
        get { return _dimx; }
        set { _dimx = dim_check (value); }

    }
    public double dim_y
    {
        get { return _dimy; }
        set { _dimy = dim_check (value); }

    }
    public double dim_z
    {
        get { return _dimz; }
        set { _dimz = dim_check (value); }

    }

    private static double dim_check (double dim)
    {
        if (dim > 0)
        {
            return dim;
        }
        else
        {
            throw new Exception ("Item can only have a positive nonzero dimensions!");
        }
    }

}