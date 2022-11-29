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
    public static Drinks _drinkMenuService = new Drinks();

    public FormCustomizations(IAppSettings appSettings) : base(appSettings)
    {
        InitializeComponent();
        
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
        FormCustomizations.addToRecipt.Clear();
        FormOrder.subtotal = 0;
        FormOrder.finalReceipt = "";
        FormCustomizations.subTotal = 0;
        FormCustomerList.customerName = "";
        FormCustomizations.addToRecipt.Clear();
        FormCustomerList.customerName = "Anonymous";
        Close(); //closes this form
        FormFactory.Get<FormMain>().Show();
    }

    private void orderBtn_Click(object sender, EventArgs e)
    {
        //adds drinks to drinks list _ndrinks list
     
        Drinks drink = new Drinks();
        int i = 0;
     foreach (String s in checkedListBox1.CheckedItems)
        {
            addToRecipt.Add(s);
            Customization temp = new Customization();
            temp.Name = _drinkMenuService.initDrinks()[FormOrder.chosenDrink].Customizations[i].Name;
            temp.Price = _drinkMenuService.initDrinks()[FormOrder.chosenDrink].Customizations[i].Price;
            addToOrder.Add(temp);
            foreach (Customization elem in drink.initDrinks()[FormOrder.chosenDrink].Customizations)
            {
               if( s.Split(',')[0] == elem.Name)
                {
                    subTotal += decimal.Parse(elem.Price.ToString());
                }
            }
            
        }
        Drinks nDrink = new Drinks();
        nDrink.Name = _drinkMenuService.initDrinks()[FormOrder.chosenDrink].Name;
        nDrink.BasePrice = _drinkMenuService.initDrinks()[FormOrder.chosenDrink].BasePrice;
        foreach (Customization elem in addToOrder)
        {
            nDrink.Customizations.Add(elem);
        }
        FormOrder._drinksDict.Add(nDrink);
        Close(); //closes this form
        FormFactory.Get<FormOrder>().Show(); //re-opens the main form
    }

    private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
      
    }
}


