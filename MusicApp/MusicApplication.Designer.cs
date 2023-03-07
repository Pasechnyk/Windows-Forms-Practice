
namespace MusicApp
{
    partial class MusicApplication
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
            this.playlistBox = new System.Windows.Forms.ListBox();
            this.addPlBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(110, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Music Database Application";
            // 
            // playlistBox
            // 
            this.playlistBox.FormattingEnabled = true;
            this.playlistBox.ItemHeight = 20;
            this.playlistBox.Location = new System.Drawing.Point(31, 169);
            this.playlistBox.Name = "playlistBox";
            this.playlistBox.Size = new System.Drawing.Size(452, 204);
            this.playlistBox.TabIndex = 1;
            this.playlistBox.SelectedIndexChanged += new System.EventHandler(this.PlaylistBoxSelectedIndexChanged);
            // 
            // addPlBtn
            // 
            this.addPlBtn.Location = new System.Drawing.Point(166, 102);
            this.addPlBtn.Name = "addPlBtn";
            this.addPlBtn.Size = new System.Drawing.Size(177, 40);
            this.addPlBtn.TabIndex = 2;
            this.addPlBtn.Text = "Add Playlist";
            this.addPlBtn.UseVisualStyleBackColor = true;
            this.addPlBtn.Click += new System.EventHandler(this.AddPlBtnClick);
            // 
            // MusicApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 402);
            this.Controls.Add(this.addPlBtn);
            this.Controls.Add(this.playlistBox);
            this.Controls.Add(this.label1);
            this.Name = "MusicApplication";
            this.Text = "Music App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox playlistBox;
        private System.Windows.Forms.Button addPlBtn;
    }
}

