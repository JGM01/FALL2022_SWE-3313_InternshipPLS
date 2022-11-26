using CoffeePointOfSale.Configuration;
using CoffeePointOfSale.Forms.Base;
using CoffeePointOfSale.Services.Customer;
using CoffeePointOfSale.Services.FormFactory;
using CoffeePointOfSale.Services.DrinkMenu;
using System.Windows.Forms;

namespace CoffeePointOfSale.Forms
{
    public partial class FormOrder : FormNoCloseBase
    {
        public static int chosenDrink;
        private readonly ICustomerService _customerService;
        public static decimal subtotal = 0;
        public decimal tax = .06M;
        

        public FormOrder(IAppSettings appSettings, ICustomerService customerService) : base(appSettings)
        {
            _customerService = customerService;
            Drinks _drinkMenuService = new Drinks();

            InitializeComponent();
            if (!String.IsNullOrEmpty(FormCustomerList.customerName))
            {
                label1.Text = FormCustomerList.customerName;
             

            }


            foreach (Drinks elem in _drinkMenuService.initDrinks())
            {

                drinksBindingSource.Add(elem);

            }
            foreach(String elem in FormCustomizations.addToRecipt)
            {
                richTextBox1.Text += "\r\n"+elem;
                
            }
            if(FormCustomizations.subTotal != null)
            {
                subtotal += FormCustomizations.subTotal;
            }
            
            labelSubtotalV.Text = subtotal.ToString();
            labelTaxV.Text = (subtotal * tax).ToString();
            labelTotalV.Text = ((subtotal * tax) + subtotal).ToString();
            FormCustomizations.subTotal = 0;
        }

        protected override void OnLoad(object sender, EventArgs e)
        {
            base.OnLoad(sender, e);

            

        }

        private void onClickBtnBack(object sender, EventArgs e)
        {
            subtotal = 0;
            richTextBox1.Clear();
            label1.Text = "Anonymous";
            FormCustomerList.customerName = "";
            Close(); //closes this form
            FormFactory.Get<FormMain>().Show(); //re-opens the main form
        }

        private void FormOrder_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

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
