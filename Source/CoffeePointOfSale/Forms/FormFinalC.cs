﻿using CoffeePointOfSale.Configuration;
using CoffeePointOfSale.Forms.Base;
using CoffeePointOfSale.Services.Customer;
using CoffeePointOfSale.Services.FormFactory;
using CoffeePointOfSale.Services.DrinkMenu;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CoffeePointOfSale.Forms
{
    public partial class FormFinalC : FormNoCloseBase
    {
        private readonly ICustomerService _customerService;
        public string customerCard;
        public FormFinalC(IAppSettings appSettings, ICustomerService customerService): base(appSettings)
        {
            _customerService = customerService;
            InitializeComponent();
            /*
           - for adding a customer order at the end
           - use label in order instead
            foreach(Customer elem in _customerService.Customers.List)
            {
                if(elem.Name == FormCustomerList.customerName)
                {
                    customerCard = elem.
                }

            }
            */
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
    }
}
