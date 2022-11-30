
using CoffeePointOfSale.Services.DrinkMenu;
using CoffeePointOfSale.Services.Storage;
using Newtonsoft.Json;

namespace CoffeePointOfSale.Services.Drink;

public class DrinkMenuService : IDrinkMenuService
{
    private readonly IStorageService _storageService;

    public DrinkMenuService(IStorageService storageService)
    {
        _storageService = storageService;
        Drinks = _storageService.Read<Drinks>();
    }

    public Drinks Drinks { get; set; }
}