// Root myDeserializedClass = JsonConvert.DeserializeObject<List<Root>>(myJsonResponse);
namespace CoffeePointOfSale.Services.DrinkMenu;
using System.Text.Json.Serialization;
using CoffeePointOfSale.Services.Drink;
using Newtonsoft.Json;

public class Customization
{
    [JsonProperty("Name")]
    public string Name { get; set; }
    [JsonProperty("Price")]
    public double Price { get; set; }
    public override string ToString()
    {
        return $"{Name}";
    }
}

public class Drinks
{
    private readonly IDrinkMenuService _drinkMenuService;

    [JsonProperty("Name")]
    public string Name { get; set; }
    
 
    [JsonProperty("BasePrice")]
    public double BasePrice { get; set; }
    public List<Customization> Customizations = new();
    public Drinks[] initDrinks()
        
    {
        string json = File.ReadAllText("C:\\Users\\Richardo\\FALL2022_SWE-3313_InternshipPLS\\Source\\CoffeePointOfSale\\JsonStorage\\DrinkMenu.json");
        return JsonConvert.DeserializeObject<Drinks[]>(json);
    }
    public List<Drinks> customerDrinks(string phone)
    {
        string json = File.ReadAllText("C:\\Users\\Richardo\\FALL2022_SWE-3313_InternshipPLS\\Source\\CoffeePointOfSale\\JsonStorage\\Customers.json");
        dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject(json);
        List<Drinks> temp = JsonConvert.DeserializeObject<Drinks>(jsonObj["Customers"][phone]["Orders"]);
        return temp;
    }
    public override string ToString()
    {
        return $"{BasePrice}";
    }
}
