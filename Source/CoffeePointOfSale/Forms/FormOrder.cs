using CoffeePointOfSale.Configuration;
using CoffeePointOfSale.Forms.Base;
using CoffeePointOfSale.Services.Customer;
using CoffeePointOfSale.Services.FormFactory;
using CoffeePointOfSale.Services.DrinkMenu;

namespace CoffeePointOfSale.Forms
{
    public partial class FormOrder : FormNoCloseBase
    {

        private readonly ICustomerService _customerService;


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



        }

        protected override void OnLoad(object sender, EventArgs e)
        {
            base.OnLoad(sender, e);

            

        }

        private void onClickBtnBack(object sender, EventArgs e)
        {
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



        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_3(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
