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
    [JsonProperty("Name")]
    public string Name { get; set; }
    public string BaseDescription { get; set; }
    public string Image { get; set; }
    [JsonProperty("BasePrice")]
    public double BasePrice { get; set; }
    public List<Customization> Customizations { get; set; }
    public Drinks[] initDrinks()
        
    {

        //Dont Forget to change the string to a file path later
        string json = File.ReadAllText("C:\\Users\\Richardo\\FALL2022_SWE-3313_InternshipPLS\\Source\\CoffeePointOfSale\\JsonStorage\\DrinkMenu.json");
        return JsonConvert.DeserializeObject<Drinks[]>(json);
    }
    public override string ToString()
    {
        return $"{BasePrice}";
    }
}
