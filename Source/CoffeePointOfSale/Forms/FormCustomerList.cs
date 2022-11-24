using CoffeePointOfSale.Configuration;
using CoffeePointOfSale.Forms.Base;
using CoffeePointOfSale.Services.Customer;
using CoffeePointOfSale.Services.FormFactory;

namespace CoffeePointOfSale.Forms;

public partial class FormCustomerList : FormNoCloseBase
{
    private readonly ICustomerService _customerService;
    public FormCustomerList(IAppSettings appSettings, ICustomerService customerService) : base(appSettings)
        
            {
            _customerService = customerService;
            InitializeComponent();
      
        foreach (Customer elem in _customerService.Customers.List)
        {
           
            customerBindingSource.Add(elem);

        }
    }

        private void FormCustomerList_Load(object sender, EventArgs e)
        {
       
        
    }

    private void button1_Click(object sender, EventArgs e)
    {
        Close(); //closes this form
        FormFactory.Get<FormMain>().Show(); //re-opens the main form
    }

 

    private void AddCustomerBtn_Click(object sender, EventArgs e)
    {
        Close(); //closes this form
        FormFactory.Get<FormAddCustomers>().Show();
    }

    private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
    {

    }
}


