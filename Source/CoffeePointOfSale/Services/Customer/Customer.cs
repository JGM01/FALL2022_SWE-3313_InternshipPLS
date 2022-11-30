using Newtonsoft.Json;
using System;
using CoffeePointOfSale.Services.DrinkMenu;

namespace CoffeePointOfSale.Services.Customer;

public class Customer
{
    public const string AnonymousCustomerId = "anonymous";


    private string _phone = ""; //backing field for Phone property. only needed because the setter has logic to handle nulls and trimming spaces.
    private int _rewardPoints;
    private string _name = "";
    
    public virtual string Phone
    {
        get => _phone;
        set
        {
            if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Phone cannot be empty or null");
            _phone = value.Trim(); //trim to remove leading or trailing spaces that might mess up the lookup function
        }
    }

    public virtual int RewardPoints

    {
        get => _rewardPoints;
        set
        {
            if (IsAnonymous) return; //you cannot set reward points for the anonymous customer record
            _rewardPoints = value;
        }
    }
   
    public virtual string Name
    {
        get => _name;
        set
        {
            if (IsAnonymous)
            {
                _name = "Anonymous";
            }//if the customer is Anonymous thier name will be set to Anonymous
            _name = value;
        }
    }


    [JsonIgnore]
    public virtual bool IsAnonymous => Phone == AnonymousCustomerId;

    public override string ToString()
    {
        return IsAnonymous  
            ? "Anonymous Customer - No Reward Points"
            : $"{Phone},{Name}, Reward Points: {RewardPoints}";
    }
    public List<Order> Orders { get; set; } = new();

}
public class Order
{
    public string Date { get; set; }
    public string Subtotal { get; set; }
    public string Tax { get; set; }
    public string Total { get; set; }
    public string PointsEarned { get; set; }
    public string Card { get; set; }
    public string Drinks { get; set; }

    public override string ToString()
    {
           
        //join all of the drinks together using the Drink ToString method
        return string.Join(" | ", Drinks);
    }

}