
namespace CarCollection
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
            this.modelComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.titleComboBox = new System.Windows.Forms.ComboBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.yearNumeric = new System.Windows.Forms.NumericUpDown();
            this.stateNumberMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.vinNumberTextBox = new System.Windows.Forms.TextBox();
            this.colourTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.carCollection = new System.Windows.Forms.ListBox();
            this.carComboBox = new System.Windows.Forms.ComboBox();
            this.showBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.yearNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // modelComboBox
            // 
            this.modelComboBox.FormattingEnabled = true;
            this.modelComboBox.Location = new System.Drawing.Point(377, 149);
            this.modelComboBox.Name = "modelComboBox";
            this.modelComboBox.Size = new System.Drawing.Size(151, 28);
            this.modelComboBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(272, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Car Database";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Colour";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Year";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(177, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "State Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(176, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "VIN Number";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(178, 114);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(48, 20);
            this.title.TabIndex = 11;
            this.title.Text = "Brand";
            // 
            // titleComboBox
            // 
            this.titleComboBox.FormattingEnabled = true;
            this.titleComboBox.Location = new System.Drawing.Point(377, 111);
            this.titleComboBox.Name = "titleComboBox";
            this.titleComboBox.Size = new System.Drawing.Size(151, 28);
            this.titleComboBox.TabIndex = 12;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(259, 359);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(179, 29);
            this.addBtn.TabIndex = 13;
            this.addBtn.Text = "Add New Car";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.AddCarBtnClick);
            // 
            // yearNumeric
            // 
            this.yearNumeric.Location = new System.Drawing.Point(377, 226);
            this.yearNumeric.Name = "yearNumeric";
            this.yearNumeric.Size = new System.Drawing.Size(150, 27);
            this.yearNumeric.TabIndex = 14;
            // 
            // stateNumberMaskedTextBox
            // 
            this.stateNumberMaskedTextBox.Location = new System.Drawing.Point(377, 263);
            this.stateNumberMaskedTextBox.Mask = "АА0000АА";
            this.stateNumberMaskedTextBox.Name = "stateNumberMaskedTextBox";
            this.stateNumberMaskedTextBox.Size = new System.Drawing.Size(151, 27);
            this.stateNumberMaskedTextBox.TabIndex = 15;
            // 
            // vinNumberTextBox
            // 
            this.vinNumberTextBox.Location = new System.Drawing.Point(377, 302);
            this.vinNumberTextBox.Name = "vinNumberTextBox";
            this.vinNumberTextBox.Size = new System.Drawing.Size(150, 27);
            this.vinNumberTextBox.TabIndex = 16;
            // 
            // colourTextBox
            // 
            this.colourTextBox.Location = new System.Drawing.Point(377, 189);
            this.colourTextBox.Name = "colourTextBox";
            this.colourTextBox.Size = new System.Drawing.Size(150, 27);
            this.colourTextBox.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(414, 540);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 29);
            this.button1.TabIndex = 18;
            this.button1.Text = "Delete Car";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.DeleteCarBtn);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(132, 434);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Car List:";
            // 
            // carCollection
            // 
            this.carCollection.FormattingEnabled = true;
            this.carCollection.ItemHeight = 20;
            this.carCollection.Location = new System.Drawing.Point(203, 434);
            this.carCollection.Name = "carCollection";
            this.carCollection.Size = new System.Drawing.Size(343, 44);
            this.carCollection.TabIndex = 20;
            this.carCollection.SelectedIndexChanged += new System.EventHandler(this.DeleteCarBtn);
            // 
            // carComboBox
            // 
            this.carComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.carComboBox.FormattingEnabled = true;
            this.carComboBox.Location = new System.Drawing.Point(203, 506);
            this.carComboBox.Name = "carComboBox";
            this.carComboBox.Size = new System.Drawing.Size(187, 28);
            this.carComboBox.TabIndex = 21;
            this.carComboBox.SelectedIndexChanged += new System.EventHandler(this.ShowCarByClueBtn);
            // 
            // showBtn
            // 
            this.showBtn.Location = new System.Drawing.Point(414, 505);
            this.showBtn.Name = "showBtn";
            this.showBtn.Size = new System.Drawing.Size(146, 29);
            this.showBtn.TabIndex = 23;
            this.showBtn.Text = "Show Car Info";
            this.showBtn.UseVisualStyleBackColor = true;
            this.showBtn.Click += new System.EventHandler(this.ShowCarByClueBtn);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(79, 510);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "Search by clues:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(692, 606);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.showBtn);
            this.Controls.Add(this.carComboBox);
            this.Controls.Add(this.carCollection);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.colourTextBox);
            this.Controls.Add(this.vinNumberTextBox);
            this.Controls.Add(this.stateNumberMaskedTextBox);
            this.Controls.Add(this.yearNumeric);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.titleComboBox);
            this.Controls.Add(this.title);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.modelComboBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.yearNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox modelComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.ComboBox titleComboBox;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.NumericUpDown yearNumeric;
        private System.Windows.Forms.MaskedTextBox stateNumberMaskedTextBox;
        private System.Windows.Forms.TextBox vinNumberTextBox;
        private System.Windows.Forms.TextBox colourTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox carCollection;
        private System.Windows.Forms.ComboBox carComboBox;
        private System.Windows.Forms.Button showBtn;
        private System.Windows.Forms.Label label8;
    }
}

