﻿using CoffeePointOfSale.Configuration;
using CoffeePointOfSale.Forms.Base;
using CoffeePointOfSale.Services.Customer;
using CoffeePointOfSale.Services.FormFactory;
using CoffeePointOfSale.Services.DrinkMenu;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;

namespace CoffeePointOfSale.Forms
{
    public partial class FormPaymentA : FormNoCloseBase
    {
        public static String card;
        public FormPaymentA()
        {
            InitializeComponent();
            richTextBox1.Clear();
            richTextBox1.Text = FormOrder.finalReceipt;
            labelSubtotalV.Text = FormOrder.finalSubtotal;
            labelTaxV.Text = FormOrder.finalTax;
            labelTotalV.Text = FormOrder.finalTotal;
            string totalOrderValue = labelTotalV.Text;
            cardBtn.Enabled = false;
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


        private void cardBtn_Click_1(object sender, EventArgs e)
        {
            card = textBox1.Text;
            Close(); //closes this form
            FormFactory.Get<FormFinalC>().Show();
        }

        private void BtnBack_Click_1(object sender, EventArgs e)
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

        private void FormPaymentA_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            {
                if (!checkLuhn(textBox1.Text))
                {
                    cardBtn.Enabled = false;
                }
                else
                {
                    cardBtn.Enabled = true;
                }
                static bool checkLuhn(String cardNo)
                {
                    int nDigits = cardNo.Length;

                    int nSum = 0;
                    bool isSecond = false;
                    for (int i = nDigits - 1; i >= 0; i--)
                    {

                        int d = cardNo[i] - '0';

                        if (isSecond == true)
                            d = d * 2;

                        // We add two digits to handle
                        // cases that make two digits
                        // after doubling
                        nSum += d / 10;
                        nSum += d % 10;

                        isSecond = !isSecond;
                    }
                    return (nSum % 10 == 0);
                }


            }
        }
    }
}
