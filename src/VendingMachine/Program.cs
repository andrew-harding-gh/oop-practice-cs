using System;

class Program
{
    static void Main ()
    {
        BeverageItem[] beverages = {
            new BeverageItem ("coke", 1.2, "B69"),
            new BeverageItem ("mexican coke", 1.5, "B690")
        };
        foreach (var b in beverages)
        {
            System.Console.WriteLine (b);
        }
    }
}