namespace CoffeePointOfSale.Forms
{
    partial class FormFinalC
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
            this.BtnBack = new System.Windows.Forms.Button();
            this.labelTotalV = new System.Windows.Forms.Label();
            this.labelTaxV = new System.Windows.Forms.Label();
            this.labelSubtotalV = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelTax = new System.Windows.Forms.Label();
            this.labelSubtotal = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCard = new System.Windows.Forms.Label();
            this.labelCardV = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(63)))), ((int)(((byte)(75)))));
            this.BtnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnBack.ForeColor = System.Drawing.Color.White;
            this.BtnBack.Location = new System.Drawing.Point(754, 299);
            this.BtnBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(535, 100);
            this.BtnBack.TabIndex = 4;
            this.BtnBack.Text = "Return to Main Menu";
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // labelTotalV
            // 
            this.labelTotalV.AutoSize = true;
            this.labelTotalV.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTotalV.Location = new System.Drawing.Point(481, 543);
            this.labelTotalV.Name = "labelTotalV";
            this.labelTotalV.Size = new System.Drawing.Size(119, 33);
            this.labelTotalV.TabIndex = 24;
            this.labelTotalV.Text = "             ";
            this.labelTotalV.Click += new System.EventHandler(this.labelTotalV_Click);
            // 
            // labelTaxV
            // 
            this.labelTaxV.AutoSize = true;
            this.labelTaxV.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTaxV.Location = new System.Drawing.Point(481, 492);
            this.labelTaxV.Name = "labelTaxV";
            this.labelTaxV.Size = new System.Drawing.Size(119, 33);
            this.labelTaxV.TabIndex = 23;
            this.labelTaxV.Text = "             ";
            this.labelTaxV.Click += new System.EventHandler(this.labelTaxV_Click);
            // 
            // labelSubtotalV
            // 
            this.labelSubtotalV.AutoSize = true;
            this.labelSubtotalV.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSubtotalV.Location = new System.Drawing.Point(481, 445);
            this.labelSubtotalV.Name = "labelSubtotalV";
            this.labelSubtotalV.Size = new System.Drawing.Size(119, 33);
            this.labelSubtotalV.TabIndex = 22;
            this.labelSubtotalV.Text = "             ";
            this.labelSubtotalV.Click += new System.EventHandler(this.labelSubtotalV_Click);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTotal.Location = new System.Drawing.Point(56, 543);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(88, 33);
            this.labelTotal.TabIndex = 21;
            this.labelTotal.Text = "Total:";
            this.labelTotal.Click += new System.EventHandler(this.labelTotal_Click);
            // 
            // labelTax
            // 
            this.labelTax.AutoSize = true;
            this.labelTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTax.Location = new System.Drawing.Point(56, 492);
            this.labelTax.Name = "labelTax";
            this.labelTax.Size = new System.Drawing.Size(72, 33);
            this.labelTax.TabIndex = 20;
            this.labelTax.Text = "Tax:";
            this.labelTax.Click += new System.EventHandler(this.labelTax_Click);
            // 
            // labelSubtotal
            // 
            this.labelSubtotal.AutoSize = true;
            this.labelSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSubtotal.Location = new System.Drawing.Point(56, 445);
            this.labelSubtotal.Name = "labelSubtotal";
            this.labelSubtotal.Size = new System.Drawing.Size(129, 33);
            this.labelSubtotal.TabIndex = 19;
            this.labelSubtotal.Text = "Subtotal:";
            this.labelSubtotal.Click += new System.EventHandler(this.labelSubtotal_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(63)))), ((int)(((byte)(75)))));
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(0, 76);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(664, 355);
            this.richTextBox1.TabIndex = 18;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(57, 593);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 33);
            this.label1.TabIndex = 25;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelCard
            // 
            this.labelCard.AutoSize = true;
            this.labelCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCard.Location = new System.Drawing.Point(56, 593);
            this.labelCard.Name = "labelCard";
            this.labelCard.Size = new System.Drawing.Size(218, 33);
            this.labelCard.TabIndex = 26;
            this.labelCard.Text = "Paid With Card:";
            this.labelCard.Click += new System.EventHandler(this.labelCard_Click);
            // 
            // labelCardV
            // 
            this.labelCardV.AutoSize = true;
            this.labelCardV.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCardV.Location = new System.Drawing.Point(481, 593);
            this.labelCardV.Name = "labelCardV";
            this.labelCardV.Size = new System.Drawing.Size(119, 33);
            this.labelCardV.TabIndex = 27;
            this.labelCardV.Text = "             ";
            this.labelCardV.Click += new System.EventHandler(this.labelCardV_Click);
            // 
            // FormFinalC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(118)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1330, 674);
            this.Controls.Add(this.labelCardV);
            this.Controls.Add(this.labelCard);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTotalV);
            this.Controls.Add(this.labelTaxV);
            this.Controls.Add(this.labelSubtotalV);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelTax);
            this.Controls.Add(this.labelSubtotal);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.BtnBack);
            this.Name = "FormFinalC";
            this.Text = "FormFinalC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnBack;
        private Label labelTotalV;
        private Label labelTaxV;
        private Label labelSubtotalV;
        private Label labelTotal;
        private Label labelTax;
        private Label labelSubtotal;
        private RichTextBox richTextBox1;
        private Label label1;
        private Label labelCard;
        private Label labelCardV;
    }
}