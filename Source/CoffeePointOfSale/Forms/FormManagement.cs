using CoffeePointOfSale.Configuration;
using CoffeePointOfSale.Forms.Base;
using CoffeePointOfSale.Services.CsvExtract;
using CoffeePointOfSale.Services.Customer;
using CoffeePointOfSale.Services.FormFactory;

namespace CoffeePointOfSale.Forms;

public partial class FormManagement : FormNoCloseBase
{
    private readonly ICustomerService _customerService;
    private readonly IAppSettings _appSettings;
    private ICsvExtract _csvExtract;

    public FormManagement(IAppSettings appSettings, ICustomerService customerService, ICsvExtract csvExtract) : base(appSettings)
    {
        _customerService = customerService;
        _appSettings = appSettings;
        _csvExtract = csvExtract;
        InitializeComponent();
    }

    private void OnClickBtnClose(object sender, EventArgs e)
    {
        Close(); //closes this form
        FormFactory.Get<FormMain>().Show(); //re-opens the main form
    }

  
    
    private void button1_Click(object sender, EventArgs e)
    {
        CsvExtract csvFile = new CsvExtract(_customerService);
        csvFile.Extract();
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }
}