
namespace BookRoom
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
            this.label2 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.surnameBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.contactMaskedBox = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.amountNumericBox = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.typeBox = new System.Windows.Forms.GroupBox();
            this.suiteRadioBtn = new System.Windows.Forms.RadioButton();
            this.standardRadioBtn = new System.Windows.Forms.RadioButton();
            this.economRadioBtn = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.recommendationBox = new System.Windows.Forms.TextBox();
            this.agreeCheckBox = new System.Windows.Forms.CheckBox();
            this.bookBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.loadBtn = new System.Windows.Forms.Button();
            this.dateCalendar = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericBox)).BeginInit();
            this.typeBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(165, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Booking Manager";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(96, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(165, 69);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(293, 27);
            this.nameBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(76, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Surname";
            // 
            // surnameBox
            // 
            this.surnameBox.Location = new System.Drawing.Point(165, 108);
            this.surnameBox.Name = "surnameBox";
            this.surnameBox.Size = new System.Drawing.Size(293, 27);
            this.surnameBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(26, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Contact Number";
            // 
            // contactMaskedBox
            // 
            this.contactMaskedBox.Location = new System.Drawing.Point(165, 152);
            this.contactMaskedBox.Mask = "+38 (000) 000-0000";
            this.contactMaskedBox.Name = "contactMaskedBox";
            this.contactMaskedBox.Size = new System.Drawing.Size(293, 27);
            this.contactMaskedBox.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(41, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Person Count";
            // 
            // amountNumericBox
            // 
            this.amountNumericBox.Location = new System.Drawing.Point(165, 193);
            this.amountNumericBox.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.amountNumericBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.amountNumericBox.Name = "amountNumericBox";
            this.amountNumericBox.Size = new System.Drawing.Size(66, 27);
            this.amountNumericBox.TabIndex = 8;
            this.amountNumericBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(96, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 23);
            this.label6.TabIndex = 9;
            this.label6.Text = "Room";
            // 
            // typeBox
            // 
            this.typeBox.Controls.Add(this.suiteRadioBtn);
            this.typeBox.Controls.Add(this.standardRadioBtn);
            this.typeBox.Controls.Add(this.economRadioBtn);
            this.typeBox.Location = new System.Drawing.Point(165, 234);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(293, 54);
            this.typeBox.TabIndex = 10;
            this.typeBox.TabStop = false;
            this.typeBox.Text = "Choose type:";
            // 
            // suiteRadioBtn
            // 
            this.suiteRadioBtn.AutoSize = true;
            this.suiteRadioBtn.Location = new System.Drawing.Point(206, 24);
            this.suiteRadioBtn.Name = "suiteRadioBtn";
            this.suiteRadioBtn.Size = new System.Drawing.Size(63, 24);
            this.suiteRadioBtn.TabIndex = 2;
            this.suiteRadioBtn.TabStop = true;
            this.suiteRadioBtn.Text = "Suite";
            this.suiteRadioBtn.UseVisualStyleBackColor = true;
            // 
            // standardRadioBtn
            // 
            this.standardRadioBtn.AutoSize = true;
            this.standardRadioBtn.Location = new System.Drawing.Point(110, 24);
            this.standardRadioBtn.Name = "standardRadioBtn";
            this.standardRadioBtn.Size = new System.Drawing.Size(90, 24);
            this.standardRadioBtn.TabIndex = 1;
            this.standardRadioBtn.TabStop = true;
            this.standardRadioBtn.Text = "Standard";
            this.standardRadioBtn.UseVisualStyleBackColor = true;
            // 
            // economRadioBtn
            // 
            this.economRadioBtn.AutoSize = true;
            this.economRadioBtn.Location = new System.Drawing.Point(20, 24);
            this.economRadioBtn.Name = "economRadioBtn";
            this.economRadioBtn.Size = new System.Drawing.Size(84, 24);
            this.economRadioBtn.TabIndex = 0;
            this.economRadioBtn.TabStop = true;
            this.economRadioBtn.Text = "Econom";
            this.economRadioBtn.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(24, 295);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 23);
            this.label7.TabIndex = 11;
            this.label7.Text = "Date of Holiday";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(12, 350);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(230, 23);
            this.label8.TabIndex = 13;
            this.label8.Text = "Additional Recommendations:";
            // 
            // recommendationBox
            // 
            this.recommendationBox.Location = new System.Drawing.Point(165, 385);
            this.recommendationBox.Multiline = true;
            this.recommendationBox.Name = "recommendationBox";
            this.recommendationBox.Size = new System.Drawing.Size(293, 103);
            this.recommendationBox.TabIndex = 14;
            // 
            // agreeCheckBox
            // 
            this.agreeCheckBox.AutoSize = true;
            this.agreeCheckBox.Location = new System.Drawing.Point(10, 535);
            this.agreeCheckBox.Name = "agreeCheckBox";
            this.agreeCheckBox.Size = new System.Drawing.Size(232, 24);
            this.agreeCheckBox.TabIndex = 15;
            this.agreeCheckBox.Text = "I agree to the Terms of Service";
            this.agreeCheckBox.UseVisualStyleBackColor = true;
            this.agreeCheckBox.CheckedChanged += new System.EventHandler(this.AgreeBoxCheckedChanged);
            // 
            // bookBtn
            // 
            this.bookBtn.BackColor = System.Drawing.Color.LemonChiffon;
            this.bookBtn.Location = new System.Drawing.Point(62, 578);
            this.bookBtn.Name = "bookBtn";
            this.bookBtn.Size = new System.Drawing.Size(207, 55);
            this.bookBtn.TabIndex = 16;
            this.bookBtn.Text = "Book Vacation";
            this.bookBtn.UseVisualStyleBackColor = false;
            this.bookBtn.Click += new System.EventHandler(this.BookRoomBtnClick);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.White;
            this.cancelBtn.Location = new System.Drawing.Point(292, 578);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(207, 55);
            this.cancelBtn.TabIndex = 17;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.CancelBtnClick);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.GreenYellow;
            this.saveBtn.Location = new System.Drawing.Point(62, 639);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(207, 55);
            this.saveBtn.TabIndex = 18;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.SaveBtnClick);
            // 
            // loadBtn
            // 
            this.loadBtn.BackColor = System.Drawing.Color.LightBlue;
            this.loadBtn.Location = new System.Drawing.Point(292, 639);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(207, 55);
            this.loadBtn.TabIndex = 19;
            this.loadBtn.Text = "Load";
            this.loadBtn.UseVisualStyleBackColor = false;
            this.loadBtn.Click += new System.EventHandler(this.LoadBtnClick);
            // 
            // dateCalendar
            // 
            this.dateCalendar.Location = new System.Drawing.Point(165, 295);
            this.dateCalendar.Name = "dateCalendar";
            this.dateCalendar.Size = new System.Drawing.Size(250, 27);
            this.dateCalendar.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(575, 705);
            this.Controls.Add(this.dateCalendar);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.bookBtn);
            this.Controls.Add(this.agreeCheckBox);
            this.Controls.Add(this.recommendationBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.typeBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.amountNumericBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.contactMaskedBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.surnameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericBox)).EndInit();
            this.typeBox.ResumeLayout(false);
            this.typeBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox surnameBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox contactMaskedBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown amountNumericBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox typeBox;
        private System.Windows.Forms.RadioButton suiteRadioBtn;
        private System.Windows.Forms.RadioButton standardRadioBtn;
        private System.Windows.Forms.RadioButton economRadioBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox recommendationBox;
        private System.Windows.Forms.CheckBox agreeCheckBox;
        private System.Windows.Forms.Button bookBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.DateTimePicker dateCalendar;
    }
}

