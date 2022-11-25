using CoffeePointOfSale.Configuration;
using CoffeePointOfSale.Forms.Base;
using CoffeePointOfSale.Services.DrinkMenu;
using CoffeePointOfSale.Services.FormFactory;

namespace CoffeePointOfSale.Forms;

    public partial class FormCustomizations : FormBase
    {
    public FormCustomizations(IAppSettings appSettings) : base(appSettings)
    {
        InitializeComponent();
        Drinks _drinkMenuService = new Drinks();
        label1.Text = _drinkMenuService.initDrinks()[FormOrder.chosenDrink].Name;
        foreach (Customization elem in _drinkMenuService.initDrinks()[FormOrder.chosenDrink].Customizations)
        {
            checkedListBox1.Items.Add(elem.Name+", "+elem.Price);
        }
    }

    private void FormCustomizations_Load(object sender, EventArgs e)
        {

        }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void ReturnBtn_Click(object sender, EventArgs e)
    {
        Close(); //closes this form
        FormFactory.Get<FormMain>().Show(); //re-opens the main form
    }

    private void orderBtn_Click(object sender, EventArgs e)
    {
        Close(); //closes this form
        FormFactory.Get<FormOrder>().Show(); //re-opens the main form
    }

    private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
       
    }
}


