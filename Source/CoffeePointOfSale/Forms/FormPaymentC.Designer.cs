namespace CoffeePointOfSale.Forms
{
    partial class FormPaymentC
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cardBtn = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.labelTotalV = new System.Windows.Forms.Label();
            this.labelTaxV = new System.Windows.Forms.Label();
            this.labelSubtotalV = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelTax = new System.Windows.Forms.Label();
            this.labelSubtotal = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(718, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(535, 27);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cardBtn
            // 
            this.cardBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(63)))), ((int)(((byte)(75)))));
            this.cardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cardBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cardBtn.ForeColor = System.Drawing.Color.White;
            this.cardBtn.Location = new System.Drawing.Point(718, 144);
            this.cardBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cardBtn.Name = "cardBtn";
            this.cardBtn.Size = new System.Drawing.Size(535, 100);
            this.cardBtn.TabIndex = 2;
            this.cardBtn.Text = "Pay With Card";
            this.cardBtn.UseVisualStyleBackColor = false;
            this.cardBtn.Click += new System.EventHandler(this.cardBtn_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(63)))), ((int)(((byte)(75)))));
            this.BtnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnBack.ForeColor = System.Drawing.Color.White;
            this.BtnBack.Location = new System.Drawing.Point(718, 437);
            this.BtnBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(535, 100);
            this.BtnBack.TabIndex = 3;
            this.BtnBack.Text = "Cancel Order";
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(63)))), ((int)(((byte)(75)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(718, 295);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(535, 100);
            this.button2.TabIndex = 4;
            this.button2.Text = "Pay With Rewards";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelTotalV
            // 
            this.labelTotalV.AutoSize = true;
            this.labelTotalV.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTotalV.Location = new System.Drawing.Point(479, 507);
            this.labelTotalV.Name = "labelTotalV";
            this.labelTotalV.Size = new System.Drawing.Size(119, 33);
            this.labelTotalV.TabIndex = 17;
            this.labelTotalV.Text = "             ";
            this.labelTotalV.Click += new System.EventHandler(this.labelTotalV_Click);
            // 
            // labelTaxV
            // 
            this.labelTaxV.AutoSize = true;
            this.labelTaxV.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTaxV.Location = new System.Drawing.Point(479, 456);
            this.labelTaxV.Name = "labelTaxV";
            this.labelTaxV.Size = new System.Drawing.Size(119, 33);
            this.labelTaxV.TabIndex = 16;
            this.labelTaxV.Text = "             ";
            this.labelTaxV.Click += new System.EventHandler(this.labelTaxV_Click);
            // 
            // labelSubtotalV
            // 
            this.labelSubtotalV.AutoSize = true;
            this.labelSubtotalV.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSubtotalV.Location = new System.Drawing.Point(479, 409);
            this.labelSubtotalV.Name = "labelSubtotalV";
            this.labelSubtotalV.Size = new System.Drawing.Size(119, 33);
            this.labelSubtotalV.TabIndex = 15;
            this.labelSubtotalV.Text = "             ";
            this.labelSubtotalV.Click += new System.EventHandler(this.labelSubtotalV_Click);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTotal.Location = new System.Drawing.Point(54, 507);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(88, 33);
            this.labelTotal.TabIndex = 14;
            this.labelTotal.Text = "Total:";
            this.labelTotal.Click += new System.EventHandler(this.labelTotal_Click);
            // 
            // labelTax
            // 
            this.labelTax.AutoSize = true;
            this.labelTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTax.Location = new System.Drawing.Point(54, 456);
            this.labelTax.Name = "labelTax";
            this.labelTax.Size = new System.Drawing.Size(72, 33);
            this.labelTax.TabIndex = 13;
            this.labelTax.Text = "Tax:";
            this.labelTax.Click += new System.EventHandler(this.labelTax_Click);
            // 
            // labelSubtotal
            // 
            this.labelSubtotal.AutoSize = true;
            this.labelSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSubtotal.Location = new System.Drawing.Point(54, 409);
            this.labelSubtotal.Name = "labelSubtotal";
            this.labelSubtotal.Size = new System.Drawing.Size(129, 33);
            this.labelSubtotal.TabIndex = 12;
            this.labelSubtotal.Text = "Subtotal:";
            this.labelSubtotal.Click += new System.EventHandler(this.labelSubtotal_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(63)))), ((int)(((byte)(75)))));
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(-2, 40);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(664, 355);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // FormPaymentC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(118)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1330, 674);
            this.Controls.Add(this.labelTotalV);
            this.Controls.Add(this.labelTaxV);
            this.Controls.Add(this.labelSubtotalV);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelTax);
            this.Controls.Add(this.labelSubtotal);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.cardBtn);
            this.Controls.Add(this.textBox1);
            this.Name = "FormPaymentC";
            this.Text = "FormPaymentC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private Button cardBtn;
        private Button BtnBack;
        private Button button2;
        private Label labelTotalV;
        private Label labelTaxV;
        private Label labelSubtotalV;
        private Label labelTotal;
        private Label labelTax;
        private Label labelSubtotal;
        private RichTextBox richTextBox1;
    }
}