
namespace Shop
{
    partial class ProductForm
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
            this.productLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.priceNumeric = new System.Windows.Forms.NumericUpDown();
            this.countryComboBox = new System.Windows.Forms.ComboBox();
            this.amountNumeric = new System.Windows.Forms.NumericUpDown();
            this.discountNumeric = new System.Windows.Forms.NumericUpDown();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.registerBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.discountNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // productLabel
            // 
            this.productLabel.AutoSize = true;
            this.productLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.productLabel.Location = new System.Drawing.Point(146, 35);
            this.productLabel.Name = "productLabel";
            this.productLabel.Size = new System.Drawing.Size(160, 31);
            this.productLabel.TabIndex = 0;
            this.productLabel.Text = "Add a Product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(132, 89);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(196, 27);
            this.nameTextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Country";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Amount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "DIscount";
            // 
            // priceNumeric
            // 
            this.priceNumeric.Location = new System.Drawing.Point(132, 136);
            this.priceNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.priceNumeric.Name = "priceNumeric";
            this.priceNumeric.Size = new System.Drawing.Size(150, 27);
            this.priceNumeric.TabIndex = 7;
            this.priceNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // countryComboBox
            // 
            this.countryComboBox.FormattingEnabled = true;
            this.countryComboBox.Location = new System.Drawing.Point(132, 182);
            this.countryComboBox.Name = "countryComboBox";
            this.countryComboBox.Size = new System.Drawing.Size(151, 28);
            this.countryComboBox.TabIndex = 8;
            // 
            // amountNumeric
            // 
            this.amountNumeric.Location = new System.Drawing.Point(132, 226);
            this.amountNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.amountNumeric.Name = "amountNumeric";
            this.amountNumeric.Size = new System.Drawing.Size(150, 27);
            this.amountNumeric.TabIndex = 9;
            this.amountNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // discountNumeric
            // 
            this.discountNumeric.Location = new System.Drawing.Point(133, 269);
            this.discountNumeric.Name = "discountNumeric";
            this.discountNumeric.Size = new System.Drawing.Size(150, 27);
            this.discountNumeric.TabIndex = 10;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(255, 350);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(126, 44);
            this.cancelBtn.TabIndex = 12;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.CancelBtnClick);
            // 
            // registerBtn
            // 
            this.registerBtn.Location = new System.Drawing.Point(72, 350);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(126, 44);
            this.registerBtn.TabIndex = 13;
            this.registerBtn.Text = "Register";
            this.registerBtn.UseVisualStyleBackColor = true;
            this.registerBtn.Click += new System.EventHandler(this.RegisterBtnClick);
            // 
            // ProductForm
            // 
            this.AcceptButton = this.registerBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelBtn;
            this.ClientSize = new System.Drawing.Size(448, 450);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.discountNumeric);
            this.Controls.Add(this.amountNumeric);
            this.Controls.Add(this.countryComboBox);
            this.Controls.Add(this.priceNumeric);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.productLabel);
            this.Name = "ProductForm";
            this.Text = "Product Form";
            ((System.ComponentModel.ISupportInitialize)(this.priceNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.discountNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label productLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown priceNumeric;
        private System.Windows.Forms.ComboBox countryComboBox;
        private System.Windows.Forms.NumericUpDown amountNumeric;
        private System.Windows.Forms.NumericUpDown discountNumeric;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button registerBtn;
    }
}