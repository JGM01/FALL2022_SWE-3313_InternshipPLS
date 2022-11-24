using CoffeePointOfSale.Configuration;

namespace CoffeePointOfSale.Forms.Base;

public class FormBase : Form
{
    public FormBase()
    {
        //this constructor is ONLY for design time layout. Do NOT put anything else here.
    }

    public FormBase(IAppSettings appSettings) : this()
    {
        AppSettings = appSettings;
        InitializeComponent();
    }

    protected IAppSettings AppSettings { get; init; } = new AppSettings();

    protected virtual void OnLoad(object sender, EventArgs e)
    {
        ConfigureWindow(); //sets window to proper size and position - all forms should all this at start of OnLoad
        SetTitle();
    }

    protected void ConfigureWindow()
    {
        ClientSize = new Size(1348, 721); //equal to 1366x768 - a very common screen size
        StartPosition = FormStartPosition.CenterScreen;
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MinimizeBox = false;
        MaximizeBox = false;
    }

    private void InitializeComponent()
    {
            this.SuspendLayout();
            // 
            // FormBase
            // 
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Name = "FormBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormBase_Load);
            this.ResumeLayout(false);

    }

    /// <summary>
    ///     Helper method to set the form title
    /// </summary>
    /// <param name="title"></param>
    protected void SetTitle(string title = "")
    {
        Text = string.IsNullOrWhiteSpace(title)
            ? AppSettings.App.Name
            : $"{title} | {AppSettings.App.Name}";
    }

    private void FormBase_Load(object sender, EventArgs e)
    {

    }
}