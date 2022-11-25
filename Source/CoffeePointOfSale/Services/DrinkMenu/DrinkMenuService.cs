
using CoffeePointOfSale.Services.DrinkMenu;
using CoffeePointOfSale.Services.Storage;

namespace CoffeePointOfSale.Services.Drink;

public class DrinkMenuService : IDrinkMenuService
{
    private readonly IStorageService _storageService;

    public DrinkMenuService(IStorageService storageService)
    {
        
    }

}