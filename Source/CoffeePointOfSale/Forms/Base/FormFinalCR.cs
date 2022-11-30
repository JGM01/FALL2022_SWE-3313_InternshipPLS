using CoffeePointOfSale.Services.Customer;
using CoffeePointOfSale.Configuration;
using CoffeePointOfSale.Forms.Base;
using CoffeePointOfSale.Services.Customer;
using CoffeePointOfSale.Services.FormFactory;
using CoffeePointOfSale.Services.DrinkMenu;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;

namespace CoffeePointOfSale.Forms.Base
{
    public partial class FormFinalCR : FormNoCloseBase
    {
        private readonly ICustomerService _customerService;
        public static int spentPoints = (int) Math.Ceiling(Decimal.Parse(FormOrder.finalTotal));
        public FormFinalCR(IAppSettings appSettings, ICustomerService customerService) : base(appSettings)
        {
            _customerService = customerService;
            InitializeComponent();


            
            
            richTextBox1.Text = FormOrder.finalReceipt;
            labelSubtotalV.Text = FormOrder.finalSubtotal;
            labelTaxV.Text = FormOrder.finalTax;
            labelTotalV.Text = FormOrder.finalTotal;
            labelRewardsV.Text = spentPoints.ToString();
            FormCustomerList.cCustomer.RewardPoints = (FormCustomerList.cCustomer.RewardPoints - spentPoints);

            foreach (Customer elem in _customerService.Customers.List)
            {
                if (elem.Name == FormCustomerList.customerName)
                {
                    labelRemainingPointsV.Text = elem.RewardPoints.ToString();
                }

            }

        }

        private void labelRemainingPoints_Click(object sender, EventArgs e)
        {

        }

        private void labelRemainingPointsV_Click(object sender, EventArgs e)
        {

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {

            var getNewCust = _customerService.Customers[FormCustomerList.cCustomer.Phone];
            getNewCust.Orders.Add(new Order()
            {
                Date = $"{DateTime.Now.ToString()}",
                Subtotal = $"{FormOrder.finalSubtotal}",
                Tax = $"{FormOrder.finalTax}",
                Total = $"{FormOrder.finalTotal}",
                PointsEarned = FormOrder.pointsEarnd.ToString(),
                Drinks = FormOrder._drinksDict
            });
            _customerService.Write();

            FormOrder.subtotal = 0;
            FormOrder.finalReceipt = "";
            FormCustomizations.subTotal = 0;
            FormCustomerList.customerName = "";
            FormCustomizations.addToRecipt.Clear();
            FormCustomerList.customerName = "Anonymous";
            Close(); //closes this form
            FormFactory.Get<FormMain>().Show();

        }

        private void labelSubtotal_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelSubtotalV_Click(object sender, EventArgs e)
        {

        }

        private void labelTotal_Click(object sender, EventArgs e)
        {

        }

        private void labelRewardsV_Click(object sender, EventArgs e)
        {

        }

        private void labelRewards_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelTotalV_Click(object sender, EventArgs e)
        {

        }

        private void labelTaxV_Click(object sender, EventArgs e)
        {

        }

        private void labelTax_Click(object sender, EventArgs e)
        {

        }
    }
}
