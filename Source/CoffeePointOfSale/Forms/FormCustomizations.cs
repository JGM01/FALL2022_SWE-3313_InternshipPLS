using CoffeePointOfSale.Configuration;
using CoffeePointOfSale.Forms.Base;
using CoffeePointOfSale.Services.DrinkMenu;
using CoffeePointOfSale.Services.FormFactory;
using System.Collections;
using System.Windows.Forms.VisualStyles;

namespace CoffeePointOfSale.Forms;


    public partial class FormCustomizations : FormBase
    {
    public List<Customization> addToOrder = new List<Customization>();
    public static List<String> addToRecipt = new List<String>();
    public static decimal subTotal;
    public FormCustomizations(IAppSettings appSettings) : base(appSettings)
    {
        InitializeComponent();
        Drinks _drinkMenuService = new Drinks();
        label1.Text = _drinkMenuService.initDrinks()[FormOrder.chosenDrink].Name;
        subTotal += decimal.Parse(_drinkMenuService.initDrinks()[FormOrder.chosenDrink].ToString());
        addToRecipt.Add(label1.Text.ToUpper());
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
        Drinks drink = new Drinks();
     foreach (String s in checkedListBox1.CheckedItems)
        {
            addToRecipt.Add(s);
            foreach (Customization elem in drink.initDrinks()[FormOrder.chosenDrink].Customizations)
            {
               if( s.Split(',')[0] == elem.Name)
                {
                    subTotal += decimal.Parse(elem.Price.ToString());
                }
            }
            
        }
       Close(); //closes this form
        FormFactory.Get<FormOrder>().Show(); //re-opens the main form
    }

    private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
      
    }
}


