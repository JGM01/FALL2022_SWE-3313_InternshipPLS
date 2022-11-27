using CoffeePointOfSale.Configuration;
using CoffeePointOfSale.Forms.Base;
using CoffeePointOfSale.Services.Customer;
using CoffeePointOfSale.Services.FormFactory;
using CoffeePointOfSale.Services.DrinkMenu;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;

namespace CoffeePointOfSale.Forms
{
    public partial class FormPaymentC : FormNoCloseBase
    {
        public static String card;
        public FormPaymentC()
        {
            InitializeComponent();
            richTextBox1.Clear();
            richTextBox1.Text = FormOrder.finalReceipt;
            labelSubtotalV.Text = FormOrder.finalSubtotal;
            labelTaxV.Text = FormOrder.finalTax;
            labelTotalV.Text = FormOrder.finalTotal;
        }

        private void BtnBack_Click(object sender, EventArgs e)
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

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelSubtotalV_Click(object sender, EventArgs e)
        {

        }

        private void labelTaxV_Click(object sender, EventArgs e)
        {

        }

        private void labelTotalV_Click(object sender, EventArgs e)
        {

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

        private void cardBtn_Click(object sender, EventArgs e)
        {
            card = textBox1.Text;
            Close(); //closes this form
            FormFactory.Get<FormFinalC>().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            Close(); //closes this form
            FormFactory.Get<FormFinalCR>().Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
