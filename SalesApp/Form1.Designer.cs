
namespace SalesApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.salesBtn = new System.Windows.Forms.Button();
            this.sellersBtn = new System.Windows.Forms.Button();
            this.customersBtn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(147, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose Table To Update Information";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 202);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 29;
            this.dataGridView.Size = new System.Drawing.Size(679, 236);
            this.dataGridView.TabIndex = 1;
            // 
            // salesBtn
            // 
            this.salesBtn.Location = new System.Drawing.Point(70, 86);
            this.salesBtn.Name = "salesBtn";
            this.salesBtn.Size = new System.Drawing.Size(168, 45);
            this.salesBtn.TabIndex = 2;
            this.salesBtn.Text = "Sales";
            this.salesBtn.UseVisualStyleBackColor = true;
            this.salesBtn.Click += new System.EventHandler(this.ShowSalesBtnClick);
            // 
            // sellersBtn
            // 
            this.sellersBtn.Location = new System.Drawing.Point(262, 86);
            this.sellersBtn.Name = "sellersBtn";
            this.sellersBtn.Size = new System.Drawing.Size(168, 45);
            this.sellersBtn.TabIndex = 3;
            this.sellersBtn.Text = "Sellers";
            this.sellersBtn.UseVisualStyleBackColor = true;
            this.sellersBtn.Click += new System.EventHandler(this.ShowSellersBtnClick);
            // 
            // customersBtn
            // 
            this.customersBtn.Location = new System.Drawing.Point(454, 86);
            this.customersBtn.Name = "customersBtn";
            this.customersBtn.Size = new System.Drawing.Size(168, 45);
            this.customersBtn.TabIndex = 4;
            this.customersBtn.Text = "Customers";
            this.customersBtn.UseVisualStyleBackColor = true;
            this.customersBtn.Click += new System.EventHandler(this.ShowCustomersBtnClick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(289, 149);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(119, 35);
            this.button4.TabIndex = 5;
            this.button4.Text = "Update";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.UpdateBtnClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.customersBtn);
            this.Controls.Add(this.sellersBtn);
            this.Controls.Add(this.salesBtn);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Sales Manager App";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button salesBtn;
        private System.Windows.Forms.Button sellersBtn;
        private System.Windows.Forms.Button customersBtn;
        private System.Windows.Forms.Button button4;
    }
}

