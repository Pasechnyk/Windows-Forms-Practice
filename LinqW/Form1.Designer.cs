
namespace LinqW
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
            this.combinedList = new System.Windows.Forms.ListBox();
            this.sortByAscendingBtn = new System.Windows.Forms.Button();
            this.avgBtn = new System.Windows.Forms.Button();
            this.evenValuebtn = new System.Windows.Forms.Button();
            this.leapYearBtn = new System.Windows.Forms.Button();
            this.exMarkBtn = new System.Windows.Forms.Button();
            this.findSymbolBtn = new System.Windows.Forms.Button();
            this.groupByCountBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboList
            // 
            this.combinedList.FormattingEnabled = true;
            this.combinedList.ItemHeight = 20;
            this.combinedList.Location = new System.Drawing.Point(368, 37);
            this.combinedList.Name = "comboList";
            this.combinedList.Size = new System.Drawing.Size(379, 364);
            this.combinedList.TabIndex = 0;
            // 
            // sortByAscendingBtn
            // 
            this.sortByAscendingBtn.Location = new System.Drawing.Point(71, 37);
            this.sortByAscendingBtn.Name = "sortByAscendingBtn";
            this.sortByAscendingBtn.Size = new System.Drawing.Size(232, 36);
            this.sortByAscendingBtn.TabIndex = 1;
            this.sortByAscendingBtn.Text = "Positive and Ascending";
            this.sortByAscendingBtn.UseVisualStyleBackColor = true;
            this.sortByAscendingBtn.Click += new System.EventHandler(this.SortByAscBtnClick);
            // 
            // avgBtn
            // 
            this.avgBtn.Location = new System.Drawing.Point(71, 88);
            this.avgBtn.Name = "avgBtn";
            this.avgBtn.Size = new System.Drawing.Size(232, 36);
            this.avgBtn.TabIndex = 2;
            this.avgBtn.Text = "Average of 2-digit Numbers";
            this.avgBtn.UseVisualStyleBackColor = true;
            this.avgBtn.Click += new System.EventHandler(this.AverageCountBtnClick);
            // 
            // evenValuebtn
            // 
            this.evenValuebtn.Location = new System.Drawing.Point(71, 139);
            this.evenValuebtn.Name = "evenValuebtn";
            this.evenValuebtn.Size = new System.Drawing.Size(232, 36);
            this.evenValuebtn.TabIndex = 3;
            this.evenValuebtn.Text = "Max Even Value";
            this.evenValuebtn.UseVisualStyleBackColor = true;
            this.evenValuebtn.Click += new System.EventHandler(this.EvenValueBtnClick);
            // 
            // leapYearBtn
            // 
            this.leapYearBtn.Location = new System.Drawing.Point(71, 192);
            this.leapYearBtn.Name = "leapYearBtn";
            this.leapYearBtn.Size = new System.Drawing.Size(232, 33);
            this.leapYearBtn.TabIndex = 4;
            this.leapYearBtn.Text = "Show Leap Years";
            this.leapYearBtn.UseVisualStyleBackColor = true;
            this.leapYearBtn.Click += new System.EventHandler(this.LeapYearBtnClick);
            // 
            // exMarkBtn
            // 
            this.exMarkBtn.Location = new System.Drawing.Point(71, 242);
            this.exMarkBtn.Name = "exMarkBtn";
            this.exMarkBtn.Size = new System.Drawing.Size(232, 33);
            this.exMarkBtn.TabIndex = 5;
            this.exMarkBtn.Text = "Add Exclamation Mark To String";
            this.exMarkBtn.UseVisualStyleBackColor = true;
            this.exMarkBtn.Click += new System.EventHandler(this.ExclMarkBtnClick);
            // 
            // findSymbolBtn
            // 
            this.findSymbolBtn.Location = new System.Drawing.Point(71, 291);
            this.findSymbolBtn.Name = "findSymbolBtn";
            this.findSymbolBtn.Size = new System.Drawing.Size(232, 33);
            this.findSymbolBtn.TabIndex = 6;
            this.findSymbolBtn.Text = "Find Symbol in String";
            this.findSymbolBtn.UseVisualStyleBackColor = true;
            this.findSymbolBtn.Click += new System.EventHandler(this.FindSymbolBtnClick);
            // 
            // groupByCountBtn
            // 
            this.groupByCountBtn.Location = new System.Drawing.Point(71, 341);
            this.groupByCountBtn.Name = "groupByCountBtn";
            this.groupByCountBtn.Size = new System.Drawing.Size(232, 33);
            this.groupByCountBtn.TabIndex = 7;
            this.groupByCountBtn.Text = "Group By Amount of Symbols";
            this.groupByCountBtn.UseVisualStyleBackColor = true;
            this.groupByCountBtn.Click += new System.EventHandler(this.GroupByCountBtnClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupByCountBtn);
            this.Controls.Add(this.findSymbolBtn);
            this.Controls.Add(this.exMarkBtn);
            this.Controls.Add(this.leapYearBtn);
            this.Controls.Add(this.evenValuebtn);
            this.Controls.Add(this.avgBtn);
            this.Controls.Add(this.sortByAscendingBtn);
            this.Controls.Add(this.combinedList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox combinedList;
        private System.Windows.Forms.Button sortByAscendingBtn;
        private System.Windows.Forms.Button avgBtn;
        private System.Windows.Forms.Button evenValuebtn;
        private System.Windows.Forms.Button leapYearBtn;
        private System.Windows.Forms.Button exMarkBtn;
        private System.Windows.Forms.Button findSymbolBtn;
        private System.Windows.Forms.Button groupByCountBtn;
    }
}

