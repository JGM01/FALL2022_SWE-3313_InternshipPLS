using CoffeePointOfSale.Configuration;
using CoffeePointOfSale.Forms.Base;
using CoffeePointOfSale.Services.Customer;
using CoffeePointOfSale.Services.FormFactory;
using CoffeePointOfSale.Services.DrinkMenu;
using System.Windows.Forms;
using System.Text.Json;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace CoffeePointOfSale.Forms
{
    public partial class FormOrder : FormNoCloseBase
    {
        public static int chosenDrink;
        private readonly ICustomerService _customerService;
        public static decimal subtotal = 0;
        public decimal tax = .06M;
        public static string finalReceipt;
        public static string finalTax;
        public static string finalSubtotal;
        public static string finalTotal;
        public static int pointsEarnd;
        public static readonly List<Drinks> _drinksDict = new();
        public static string customerName;


        public FormOrder(IAppSettings appSettings, ICustomerService customerService) : base(appSettings)
        {
            _customerService = customerService;
            Drinks _drinkMenuService = new Drinks();

            InitializeComponent();
            if (!FormMain.isCustomer)
            {



            if (!String.IsNullOrEmpty(FormCustomerList.cCustomer.Name))
                {
                    label1.Text = FormCustomerList.cCustomer.Name;


                }
            }

            foreach (Drinks elem in _drinkMenuService.initDrinks())
            {

                drinksBindingSource.Add(elem);

            }
            if(_drinksDict.Count == 0)
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
            foreach(String elem in FormCustomizations.addToRecipt)
            {
               
                finalReceipt += "\r\n" + elem;



            }
            if(FormCustomizations.subTotal != null)
            {
                subtotal += FormCustomizations.subTotal;
            }
            richTextBox1.Text = finalReceipt;

            labelSubtotalV.Text = subtotal.ToString("0.00");
            labelTaxV.Text = (subtotal * tax).ToString("0.00");
            labelTotalV.Text = ((subtotal * tax) + subtotal).ToString("0.00");
            pointsEarnd =(int) Math.Floor((((subtotal * tax) + subtotal)/10));
            FormCustomizations.subTotal = 0;
        }

        protected override void OnLoad(object sender, EventArgs e)
        {
            base.OnLoad(sender, e);

            

        }

        private void onClickBtnBack(object sender, EventArgs e)
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

        private void FormOrder_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            finalSubtotal = labelSubtotalV.Text;
            finalTax = labelTaxV.Text;
            finalTotal = labelTotalV.Text;
         

            //i want to pass in _drinks
        
            if (FormMain.isCustomer)
            {
                Close(); //closes this form
                FormFactory.Get<FormPaymentA>().Show();

            }
            else
            {
                
                Close(); //closes this form
                FormFactory.Get<FormPaymentC>().Show();
            }
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public string LabelText
        {
            get
            {
                return this.label1.Text;
            }
            set
            {
                this.label1.Text = value;
            }
        }

        private void dataGridView1_CellContentClick_3(object sender, DataGridViewCellEventArgs e)
        {
            chosenDrink = e.RowIndex;
            Close(); //closes this form
            FormFactory.Get<FormCustomizations>().Show();
        }

     

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
     
    }
}
