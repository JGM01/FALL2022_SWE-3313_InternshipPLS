﻿// Root myDeserializedClass = JsonConvert.DeserializeObject<List<Root>>(myJsonResponse);
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
        return JsonConvert.DeserializeObject<Drinks[]>("[\r\n    {\r\n        \"Name\": \"Latte\",\r\n        \"BaseDescription\": \"Medium, Hot, 2% Milk, 2 Shots, Unsweetened\",\r\n        \"Image\": \"latte.png\",\r\n        \"BasePrice\": 4.00,\r\n        \"Customizations\": [\r\n            { \"Name\": \"Foam B | Lots of Foam\", \"Price\": 0.00 },\r\n            { \"Name\": \"Foam A | No Foam\", \"Price\": 0.00 },\r\n            { \"Name\": \"Size C | Mega\", \"Price\": 2.00 },\r\n            { \"Name\": \"Size B | Large\", \"Price\": 1.00 },\r\n            { \"Name\": \"Size A | Small\", \"Price\": -1.00 },\r\n            { \"Name\": \"Creamer E | Soy Milk\", \"Price\": 1.50 },\r\n            { \"Name\": \"Creamer D | Almond Milk\", \"Price\": 1.50 },\r\n            { \"Name\": \"Creamer C | Oat Milk\", \"Price\": 1.50 },\r\n            { \"Name\": \"Creamer B | Whole Milk\", \"Price\": 0.00 },\r\n            { \"Name\": \"Creamer A | Non-Fat Milk\", \"Price\": 0.00 },\r\n            { \"Name\": \"Espresso | 1 Extra Shot\", \"Price\": 1.25 },\r\n            { \"Name\": \"Caffeine | Decaffeinated\", \"Price\": 0.00 },\r\n            { \"Name\": \"Sweetener C | 1 Sweet'N Low'\", \"Price\": 0.00 },\r\n            { \"Name\": \"Sweetener B | 1 Stevia\", \"Price\": 0.00 },\r\n            { \"Name\": \"Sweetener A | 1 Sugar\", \"Price\": 0.00 },\r\n            { \"Name\": \"Temperature B | Very Hot\", \"Price\": 0.00 },\r\n            { \"Name\": \"Temperature A | Less Hot\", \"Price\": 0.00 }\r\n        ]\r\n    },\r\n    {\r\n        \"Name\": \"Iced Latte\",\r\n        \"BaseDescription\": \"Medium, Cold, 2% Milk, 2 Shots, Unsweetened\",\r\n        \"BasePrice\": 5.25,\r\n        \"Image\": \"iced-latte.png\",\r\n        \"Customizations\": [\r\n            { \"Name\": \"Size A | Large\", \"Price\": 1.00 },\r\n            { \"Name\": \"Creamer E | Soy Milk\", \"Price\": 1.50 },\r\n            { \"Name\": \"Creamer D | Almond Milk\", \"Price\": 1.50 },\r\n            { \"Name\": \"Creamer C | Oat Milk\", \"Price\": 1.50 },\r\n            { \"Name\": \"Creamer B | Whole Milk\", \"Price\": 0.00 },\r\n            { \"Name\": \"Creamer A | Non-Fat Milk\", \"Price\": 0.00 },\r\n            { \"Name\": \"Espresso | 1 Extra Shot\", \"Price\": 1.25 },\r\n            { \"Name\": \"Caffeine | Decaffeinated\", \"Price\": 0.00 },\r\n            { \"Name\": \"Sweetener C | 1 Sweet'N Low'\", \"Price\": 0.00 },\r\n            { \"Name\": \"Sweetener B | 1 Stevia\", \"Price\": 0.00 },\r\n            { \"Name\": \"Sweetener A | 1 Sugar\", \"Price\": 0.00 },\r\n            { \"Name\": \"Ice B | Extra Ice\", \"Price\": 0.00 },\r\n            { \"Name\": \"Ice A | No Ice\", \"Price\": 0.00 }\r\n        ]\r\n    },\r\n    {\r\n        \"Name\": \"Iced Matcha Green Tea Latte\",\r\n        \"BaseDescription\": \"Medium, Hot, 2% Milk, 2 Shots\",\r\n        \"BasePrice\": 4.00,\r\n        \"Image\": \"iced-matcha-latte.png\",\r\n        \"Customizations\": [\r\n            { \"Name\": \"Size A | Large\", \"Price\": 1.00 },\r\n            { \"Name\": \"Creamer E | Soy Milk\", \"Price\": 1.50 },\r\n            { \"Name\": \"Creamer D | Almond Milk\", \"Price\": 1.50 },\r\n            { \"Name\": \"Creamer C | Oat Milk\", \"Price\": 1.50 },\r\n            { \"Name\": \"Creamer B | Whole Milk\", \"Price\": 0.00 },\r\n            { \"Name\": \"Creamer A | Non-Fat Milk\", \"Price\": 0.00 },\r\n            { \"Name\": \"Matcha | 1 Extra Dose\", \"Price\": 2.50 },\r\n            { \"Name\": \"Sweetener C | 1 Sweet'N Low'\", \"Price\": 0.00 },\r\n            { \"Name\": \"Sweetener B | 1 Stevia\", \"Price\": 0.00 },\r\n            { \"Name\": \"Sweetener A | 1 Sugar\", \"Price\": 0.00 },\r\n            { \"Name\": \"Ice B | Extra Ice\", \"Price\": 0.00 },\r\n            { \"Name\": \"Ice A | No Ice\", \"Price\": 0.00 }\r\n        ]\r\n    },\r\n    {\r\n        \"Name\": \"Coffee\",\r\n        \"BaseDescription\": \"Medium Brewed Coffee, Hot, Unsweetened\",\r\n        \"BasePrice\": 2.50,\r\n        \"Image\": \"coffee.png\",\r\n        \"Customizations\": [\r\n            { \"Name\": \"Size C | Mega\", \"Price\": 2.00 },\r\n            { \"Name\": \"Size B | Large\", \"Price\": 1.00 },\r\n            { \"Name\": \"Size A | Small\", \"Price\": -0.50 },\r\n            { \"Name\": \"Creamer F | Soy Milk\", \"Price\": 1.50 },\r\n            { \"Name\": \"Creamer E | Almond Milk\", \"Price\": 1.50 },\r\n            { \"Name\": \"Creamer D | Oat Milk\", \"Price\": 1.50 },\r\n            { \"Name\": \"Creamer C | Whole Milk\", \"Price\": 0.00 },\r\n            { \"Name\": \"Creamer B | Non-Fat Milk\", \"Price\": 0.00 },\r\n            { \"Name\": \"Creamer A | Room for Cream\", \"Price\": 0.00 },\r\n            { \"Name\": \"Espresso | 1 Extra Shot\", \"Price\": 1.25 },\r\n            { \"Name\": \"Sweetener C | 1 Sweet'N Low'\", \"Price\": 0.00 },\r\n            { \"Name\": \"Sweetener B | 1 Stevia\", \"Price\": 0.00 },\r\n            { \"Name\": \"Sweetener A | 1 Sugar\", \"Price\": 0.00 },\r\n            { \"Name\": \"Temperature B | Very Hot\", \"Price\": 0.00 },\r\n            { \"Name\": \"Temperature A | Less Hot\", \"Price\": 0.00 }\r\n        ]\r\n    },\r\n    {\r\n        \"Name\": \"Iced Water\",\r\n        \"BaseDescription\": \"Small Ice Water\",\r\n        \"BasePrice\": 0.00,\r\n        \"Image\": \"iced-water.png\",\r\n        \"Customizations\": [ ]\r\n    },\r\n    {\r\n        \"Name\": \"Espresso\",\r\n        \"BaseDescription\": \"Espresso Shot, Hot, Unsweetened\",\r\n        \"BasePrice\": 2.50,\r\n        \"Image\": \"espresso.png\",\r\n        \"Customizations\": [ \r\n            { \"Name\": \"Espresso | 1 Extra Shot\", \"Price\": 1.25 }\r\n        ]\r\n    }\r\n]");
    }
    public override string ToString()
    {
        return $"{BasePrice}";
    }
}
