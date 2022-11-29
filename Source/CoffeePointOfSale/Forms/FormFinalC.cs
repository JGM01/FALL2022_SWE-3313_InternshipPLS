using CoffeePointOfSale.Configuration;
using CoffeePointOfSale.Forms.Base;
using CoffeePointOfSale.Services.Customer;
using CoffeePointOfSale.Services.FormFactory;
using CoffeePointOfSale.Services.DrinkMenu;
using System.Windows.Forms;

using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Newtonsoft.Json.Linq;
using System.Text.Json;
using Newtonsoft.Json;

namespace CoffeePointOfSale.Forms
{

    public partial class FormFinalC : FormNoCloseBase
    {
        private readonly ICustomerService _customerService;
        public string customerCard;
        public Customer temp;
        public string finalFour = "";

        public FormFinalC(IAppSettings appSettings, ICustomerService customerService): base(appSettings)
        {
            _customerService = customerService;
            InitializeComponent();
     
            foreach(Customer elem in _customerService.Customers.List)
            {
                if(elem.Name == FormCustomerList.customerName)
                {
                    temp = elem;
                }

            }

            
            richTextBox1.Text = FormOrder.finalReceipt;
            labelSubtotalV.Text = FormOrder.finalSubtotal;
            labelTaxV.Text = FormOrder.finalTax;
            labelTotalV.Text = FormOrder.finalTotal;
            if (FormMain.isCustomer)
            {
                labelCardV.Text = FormPaymentA.card;

            }
            else
            {
                labelCardV.Text = FormPaymentC.card;
            }
            String reversedCard  = (labelCardV.Text);
            for(int i = 0; i < 4; i++)
            {
                finalFour = finalFour + reversedCard[i];
                    
            }
            labelCardV.Text = finalFour;

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelSubtotalV_Click(object sender, EventArgs e)
        {

        }

        private void labelTotalV_Click(object sender, EventArgs e)
        {

        }

        private void labelTaxV_Click(object sender, EventArgs e)
        {

        }

        private void labelCardV_Click(object sender, EventArgs e)
        {

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {//this can be used to write to the json come back when you have a drinks object and a customer name
           
            
            var getNewCust = _customerService.Customers[FormCustomerList.cCustomer.Phone];
            getNewCust.Orders.Add(new Order()
            {
                Date = $"{DateTime.Now.ToString()}",
                Subtotal = $"{FormOrder.finalSubtotal}",
                Tax = $"{FormOrder.finalTax}",
                Total = $"{FormOrder.finalTotal}",
                PointsEarned = FormOrder.pointsEarnd.ToString(),
                Card = Reverse(finalFour),
                Drinks = JsonConvert.SerializeObject(FormOrder._drinksDict)
            });
            _customerService.Write();

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

        private void labelTotal_Click(object sender, EventArgs e)
        {

        }

        private void labelTax_Click(object sender, EventArgs e)
        {

        }

        private void labelSubtotal_Click(object sender, EventArgs e)
        {

        }

        private void labelCard_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
