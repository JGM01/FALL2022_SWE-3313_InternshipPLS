using Newtonsoft.Json;

namespace CoffeePointOfSale.Services.DrinkMenu;

public class DrinkMenu
{
    

    private string _name = ""; 
    private int _BasePrice;
    

    public virtual string Name
    {
        get => _name;
        set
        {
            _ = value;
        }
    }

    public virtual int BasePrice
    {
        get => BasePrice;
        set
        {
            _BasePrice = value;
        }
    }


   

    public override string ToString()
    {
        return $"{_BasePrice},{_name}";
    }
}