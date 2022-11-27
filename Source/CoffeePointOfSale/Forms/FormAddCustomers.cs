using CoffeePointOfSale.Configuration;
using CoffeePointOfSale.Forms;
using CoffeePointOfSale.Forms.Base;
using CoffeePointOfSale.Services.Customer;
using CoffeePointOfSale.Services.FormFactory;


public partial class FormAddCustomers : FormNoCloseBase
{
    private readonly ICustomerService _customerService;
    public FormAddCustomers(IAppSettings appSettings, ICustomerService customerService) : base(appSettings)
    {

        _customerService = customerService;
        InitializeComponent();
    }
        
    private void InitializeComponent()
    {
            this.RegisterButton = new System.Windows.Forms.Button();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.Customerlabel = new System.Windows.Forms.Label();
            this.LastNameText = new System.Windows.Forms.TextBox();
            this.FirstNameText = new System.Windows.Forms.TextBox();
            this.PhoneText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // RegisterButton
            // 
            this.RegisterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(63)))), ((int)(((byte)(75)))));
            this.RegisterButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RegisterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.RegisterButton.ForeColor = System.Drawing.Color.White;
            this.RegisterButton.Location = new System.Drawing.Point(426, 365);
            this.RegisterButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(535, 100);
            this.RegisterButton.TabIndex = 4;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = false;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // ReturnButton
            // 
            this.ReturnButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(63)))), ((int)(((byte)(75)))));
            this.ReturnButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ReturnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ReturnButton.ForeColor = System.Drawing.Color.White;
            this.ReturnButton.Location = new System.Drawing.Point(426, 529);
            this.ReturnButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(535, 100);
            this.ReturnButton.TabIndex = 5;
            this.ReturnButton.Text = "Return to main menu";
            this.ReturnButton.UseVisualStyleBackColor = false;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // Customerlabel
            // 
            this.Customerlabel.AutoSize = true;
            this.Customerlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Customerlabel.ForeColor = System.Drawing.Color.White;
            this.Customerlabel.Location = new System.Drawing.Point(273, 45);
            this.Customerlabel.Name = "Customerlabel";
            this.Customerlabel.Size = new System.Drawing.Size(879, 95);
            this.Customerlabel.TabIndex = 9;
            this.Customerlabel.Text = "Customer Registration";
            this.Customerlabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // LastNameText
            // 
            this.LastNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LastNameText.Location = new System.Drawing.Point(506, 223);
            this.LastNameText.MaximumSize = new System.Drawing.Size(1000, 1000000);
            this.LastNameText.Name = "LastNameText";
            this.LastNameText.PlaceholderText = "Last Name";
            this.LastNameText.Size = new System.Drawing.Size(368, 53);
            this.LastNameText.TabIndex = 10;
            this.LastNameText.TextChanged += new System.EventHandler(this.LastNameText_TextChanged);
            // 
            // FirstNameText
            // 
            this.FirstNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FirstNameText.Location = new System.Drawing.Point(50, 223);
            this.FirstNameText.MaximumSize = new System.Drawing.Size(1000, 1000000);
            this.FirstNameText.Name = "FirstNameText";
            this.FirstNameText.PlaceholderText = "First Name";
            this.FirstNameText.Size = new System.Drawing.Size(368, 53);
            this.FirstNameText.TabIndex = 11;
            this.FirstNameText.TextChanged += new System.EventHandler(this.FirstNameText_TextChanged);
            // 
            // PhoneText
            // 
            this.PhoneText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PhoneText.Location = new System.Drawing.Point(950, 223);
            this.PhoneText.MaximumSize = new System.Drawing.Size(1000, 1000000);
            this.PhoneText.Name = "PhoneText";
            this.PhoneText.PlaceholderText = "Phone Number";
            this.PhoneText.Size = new System.Drawing.Size(368, 53);
            this.PhoneText.TabIndex = 12;
            this.PhoneText.TextChanged += new System.EventHandler(this.PhoneText_TextChanged);
            // 
            // FormAddCustomers
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(118)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1330, 674);
            this.Controls.Add(this.PhoneText);
            this.Controls.Add(this.FirstNameText);
            this.Controls.Add(this.LastNameText);
            this.Controls.Add(this.Customerlabel);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.RegisterButton);
            this.Name = "FormAddCustomers";
            this.Load += new System.EventHandler(this.FormAddCustomers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    private void FormAddCustomers_Load(object sender, EventArgs e)
    {

    }

    private Button RegisterButton;
    private Button ReturnButton;
    private Label Customerlabel;

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private TextBox LastNameText;
    private TextBox FirstNameText;
    private TextBox PhoneText;

    private void RegisterButton_Click(object sender, EventArgs e)
    {
        Close(); //closes this form
        FormFactory.Get<FormOrder>().Show(); //re-opens the main form
    }

    private void ReturnButton_Click(object sender, EventArgs e)
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

    private void FirstNameText_TextChanged(object sender, EventArgs e)
    {

    }

    private void LastNameText_TextChanged(object sender, EventArgs e)
    {

    }

    private void PhoneText_TextChanged(object sender, EventArgs e)
    {

    }
}

