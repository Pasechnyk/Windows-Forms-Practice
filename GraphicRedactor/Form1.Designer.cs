
namespace GraphicRedactor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.paintMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lightRedBtn = new System.Windows.Forms.Button();
            this.redBtn = new System.Windows.Forms.Button();
            this.lightPurpleBtn = new System.Windows.Forms.Button();
            this.purpleBtn = new System.Windows.Forms.Button();
            this.lightBlueBtn = new System.Windows.Forms.Button();
            this.blueBtn = new System.Windows.Forms.Button();
            this.cyanBtn = new System.Windows.Forms.Button();
            this.tealBtn = new System.Windows.Forms.Button();
            this.lightGreenBtn = new System.Windows.Forms.Button();
            this.greenBtn = new System.Windows.Forms.Button();
            this.lightYellowBtn = new System.Windows.Forms.Button();
            this.yellowBtn = new System.Windows.Forms.Button();
            this.lightOrangeBtn = new System.Windows.Forms.Button();
            this.orangeBtn = new System.Windows.Forms.Button();
            this.indianBtn = new System.Windows.Forms.Button();
            this.maroonBtn = new System.Windows.Forms.Button();
            this.silverBtn = new System.Windows.Forms.Button();
            this.grayBtn = new System.Windows.Forms.Button();
            this.whiteBtn = new System.Windows.Forms.Button();
            this.blackBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chosenPictureBox = new System.Windows.Forms.PictureBox();
            this.pickColorBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.eraseBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.shapeTypeBox = new System.Windows.Forms.ComboBox();
            this.sizeTrackBar = new System.Windows.Forms.TrackBar();
            this.enabledCheckBox = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.fillBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.paintMenuStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chosenPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // paintMenuStrip
            // 
            this.paintMenuStrip.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.paintMenuStrip.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.paintMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.paintMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.clearAllToolStripMenuItem});
            this.paintMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.paintMenuStrip.Name = "paintMenuStrip";
            this.paintMenuStrip.Size = new System.Drawing.Size(1148, 31);
            this.paintMenuStrip.TabIndex = 0;
            this.paintMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.loadToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(49, 27);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 28);
            this.saveToolStripMenuItem.Text = "Save As";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItemClick);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 28);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("loadToolStripMenuItem.Image")));
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(152, 28);
            this.loadToolStripMenuItem.Text = "Load ";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.LoadPictureToolStripMenuItemClick);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(104, 27);
            this.viewToolStripMenuItem.Text = "Main Page";
            // 
            // clearAllToolStripMenuItem
            // 
            this.clearAllToolStripMenuItem.Name = "clearAllToolStripMenuItem";
            this.clearAllToolStripMenuItem.Size = new System.Drawing.Size(87, 27);
            this.clearAllToolStripMenuItem.Text = "Clear All";
            this.clearAllToolStripMenuItem.Click += new System.EventHandler(this.ClearAllToolStripMenuItemClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lightRedBtn);
            this.panel1.Controls.Add(this.redBtn);
            this.panel1.Controls.Add(this.lightPurpleBtn);
            this.panel1.Controls.Add(this.purpleBtn);
            this.panel1.Controls.Add(this.lightBlueBtn);
            this.panel1.Controls.Add(this.blueBtn);
            this.panel1.Controls.Add(this.cyanBtn);
            this.panel1.Controls.Add(this.tealBtn);
            this.panel1.Controls.Add(this.lightGreenBtn);
            this.panel1.Controls.Add(this.greenBtn);
            this.panel1.Controls.Add(this.lightYellowBtn);
            this.panel1.Controls.Add(this.yellowBtn);
            this.panel1.Controls.Add(this.lightOrangeBtn);
            this.panel1.Controls.Add(this.orangeBtn);
            this.panel1.Controls.Add(this.indianBtn);
            this.panel1.Controls.Add(this.maroonBtn);
            this.panel1.Controls.Add(this.silverBtn);
            this.panel1.Controls.Add(this.grayBtn);
            this.panel1.Controls.Add(this.whiteBtn);
            this.panel1.Controls.Add(this.blackBtn);
            this.panel1.Location = new System.Drawing.Point(93, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 49);
            this.panel1.TabIndex = 3;
            // 
            // lightRedBtn
            // 
            this.lightRedBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lightRedBtn.Location = new System.Drawing.Point(309, 24);
            this.lightRedBtn.Name = "lightRedBtn";
            this.lightRedBtn.Size = new System.Drawing.Size(28, 25);
            this.lightRedBtn.TabIndex = 19;
            this.lightRedBtn.UseVisualStyleBackColor = false;
            this.lightRedBtn.Click += new System.EventHandler(this.ChooseColorClick);
            // 
            // redBtn
            // 
            this.redBtn.BackColor = System.Drawing.Color.Red;
            this.redBtn.Location = new System.Drawing.Point(309, 0);
            this.redBtn.Name = "redBtn";
            this.redBtn.Size = new System.Drawing.Size(28, 25);
            this.redBtn.TabIndex = 18;
            this.redBtn.UseVisualStyleBackColor = false;
            this.redBtn.Click += new System.EventHandler(this.ChooseColorClick);
            // 
            // lightPurpleBtn
            // 
            this.lightPurpleBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lightPurpleBtn.Location = new System.Drawing.Point(275, 24);
            this.lightPurpleBtn.Name = "lightPurpleBtn";
            this.lightPurpleBtn.Size = new System.Drawing.Size(28, 25);
            this.lightPurpleBtn.TabIndex = 17;
            this.lightPurpleBtn.UseVisualStyleBackColor = false;
            this.lightPurpleBtn.Click += new System.EventHandler(this.ChooseColorClick);
            // 
            // purpleBtn
            // 
            this.purpleBtn.BackColor = System.Drawing.Color.Purple;
            this.purpleBtn.Location = new System.Drawing.Point(275, 0);
            this.purpleBtn.Name = "purpleBtn";
            this.purpleBtn.Size = new System.Drawing.Size(28, 25);
            this.purpleBtn.TabIndex = 16;
            this.purpleBtn.UseVisualStyleBackColor = false;
            this.purpleBtn.Click += new System.EventHandler(this.ChooseColorClick);
            // 
            // lightBlueBtn
            // 
            this.lightBlueBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lightBlueBtn.Location = new System.Drawing.Point(241, 24);
            this.lightBlueBtn.Name = "lightBlueBtn";
            this.lightBlueBtn.Size = new System.Drawing.Size(28, 25);
            this.lightBlueBtn.TabIndex = 15;
            this.lightBlueBtn.UseVisualStyleBackColor = false;
            this.lightBlueBtn.Click += new System.EventHandler(this.ChooseColorClick);
            // 
            // blueBtn
            // 
            this.blueBtn.BackColor = System.Drawing.Color.Blue;
            this.blueBtn.Location = new System.Drawing.Point(241, 0);
            this.blueBtn.Name = "blueBtn";
            this.blueBtn.Size = new System.Drawing.Size(28, 25);
            this.blueBtn.TabIndex = 14;
            this.blueBtn.UseVisualStyleBackColor = false;
            this.blueBtn.Click += new System.EventHandler(this.ChooseColorClick);
            // 
            // cyanBtn
            // 
            this.cyanBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cyanBtn.Location = new System.Drawing.Point(207, 24);
            this.cyanBtn.Name = "cyanBtn";
            this.cyanBtn.Size = new System.Drawing.Size(28, 25);
            this.cyanBtn.TabIndex = 13;
            this.cyanBtn.UseVisualStyleBackColor = false;
            this.cyanBtn.Click += new System.EventHandler(this.ChooseColorClick);
            // 
            // tealBtn
            // 
            this.tealBtn.BackColor = System.Drawing.Color.Teal;
            this.tealBtn.Location = new System.Drawing.Point(207, 0);
            this.tealBtn.Name = "tealBtn";
            this.tealBtn.Size = new System.Drawing.Size(28, 25);
            this.tealBtn.TabIndex = 12;
            this.tealBtn.UseVisualStyleBackColor = false;
            this.tealBtn.Click += new System.EventHandler(this.ChooseColorClick);
            // 
            // lightGreenBtn
            // 
            this.lightGreenBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lightGreenBtn.Location = new System.Drawing.Point(173, 24);
            this.lightGreenBtn.Name = "lightGreenBtn";
            this.lightGreenBtn.Size = new System.Drawing.Size(28, 25);
            this.lightGreenBtn.TabIndex = 11;
            this.lightGreenBtn.UseVisualStyleBackColor = false;
            this.lightGreenBtn.Click += new System.EventHandler(this.ChooseColorClick);
            // 
            // greenBtn
            // 
            this.greenBtn.BackColor = System.Drawing.Color.Green;
            this.greenBtn.Location = new System.Drawing.Point(173, 0);
            this.greenBtn.Name = "greenBtn";
            this.greenBtn.Size = new System.Drawing.Size(28, 25);
            this.greenBtn.TabIndex = 10;
            this.greenBtn.UseVisualStyleBackColor = false;
            this.greenBtn.Click += new System.EventHandler(this.ChooseColorClick);
            // 
            // lightYellowBtn
            // 
            this.lightYellowBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lightYellowBtn.Location = new System.Drawing.Point(139, 24);
            this.lightYellowBtn.Name = "lightYellowBtn";
            this.lightYellowBtn.Size = new System.Drawing.Size(28, 25);
            this.lightYellowBtn.TabIndex = 9;
            this.lightYellowBtn.UseVisualStyleBackColor = false;
            this.lightYellowBtn.Click += new System.EventHandler(this.ChooseColorClick);
            // 
            // yellowBtn
            // 
            this.yellowBtn.BackColor = System.Drawing.Color.Yellow;
            this.yellowBtn.Location = new System.Drawing.Point(139, 0);
            this.yellowBtn.Name = "yellowBtn";
            this.yellowBtn.Size = new System.Drawing.Size(28, 25);
            this.yellowBtn.TabIndex = 8;
            this.yellowBtn.UseVisualStyleBackColor = false;
            this.yellowBtn.Click += new System.EventHandler(this.ChooseColorClick);
            // 
            // lightOrangeBtn
            // 
            this.lightOrangeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lightOrangeBtn.Location = new System.Drawing.Point(105, 24);
            this.lightOrangeBtn.Name = "lightOrangeBtn";
            this.lightOrangeBtn.Size = new System.Drawing.Size(28, 25);
            this.lightOrangeBtn.TabIndex = 7;
            this.lightOrangeBtn.UseVisualStyleBackColor = false;
            this.lightOrangeBtn.Click += new System.EventHandler(this.ChooseColorClick);
            // 
            // orangeBtn
            // 
            this.orangeBtn.BackColor = System.Drawing.Color.Orange;
            this.orangeBtn.Location = new System.Drawing.Point(105, 0);
            this.orangeBtn.Name = "orangeBtn";
            this.orangeBtn.Size = new System.Drawing.Size(28, 25);
            this.orangeBtn.TabIndex = 6;
            this.orangeBtn.UseVisualStyleBackColor = false;
            this.orangeBtn.Click += new System.EventHandler(this.ChooseColorClick);
            // 
            // indianBtn
            // 
            this.indianBtn.BackColor = System.Drawing.Color.IndianRed;
            this.indianBtn.Location = new System.Drawing.Point(71, 24);
            this.indianBtn.Name = "indianBtn";
            this.indianBtn.Size = new System.Drawing.Size(28, 25);
            this.indianBtn.TabIndex = 5;
            this.indianBtn.UseVisualStyleBackColor = false;
            this.indianBtn.Click += new System.EventHandler(this.ChooseColorClick);
            // 
            // maroonBtn
            // 
            this.maroonBtn.BackColor = System.Drawing.Color.Maroon;
            this.maroonBtn.Location = new System.Drawing.Point(71, 0);
            this.maroonBtn.Name = "maroonBtn";
            this.maroonBtn.Size = new System.Drawing.Size(28, 25);
            this.maroonBtn.TabIndex = 4;
            this.maroonBtn.UseVisualStyleBackColor = false;
            this.maroonBtn.Click += new System.EventHandler(this.ChooseColorClick);
            // 
            // silverBtn
            // 
            this.silverBtn.BackColor = System.Drawing.Color.Silver;
            this.silverBtn.Location = new System.Drawing.Point(37, 24);
            this.silverBtn.Name = "silverBtn";
            this.silverBtn.Size = new System.Drawing.Size(28, 25);
            this.silverBtn.TabIndex = 3;
            this.silverBtn.UseVisualStyleBackColor = false;
            this.silverBtn.Click += new System.EventHandler(this.ChooseColorClick);
            // 
            // grayBtn
            // 
            this.grayBtn.BackColor = System.Drawing.Color.Gray;
            this.grayBtn.Location = new System.Drawing.Point(37, 0);
            this.grayBtn.Name = "grayBtn";
            this.grayBtn.Size = new System.Drawing.Size(28, 25);
            this.grayBtn.TabIndex = 2;
            this.grayBtn.UseVisualStyleBackColor = false;
            this.grayBtn.Click += new System.EventHandler(this.ChooseColorClick);
            // 
            // whiteBtn
            // 
            this.whiteBtn.BackColor = System.Drawing.Color.White;
            this.whiteBtn.Location = new System.Drawing.Point(3, 24);
            this.whiteBtn.Name = "whiteBtn";
            this.whiteBtn.Size = new System.Drawing.Size(28, 25);
            this.whiteBtn.TabIndex = 1;
            this.whiteBtn.UseVisualStyleBackColor = false;
            this.whiteBtn.Click += new System.EventHandler(this.ChooseColorClick);
            // 
            // blackBtn
            // 
            this.blackBtn.BackColor = System.Drawing.Color.Black;
            this.blackBtn.Location = new System.Drawing.Point(3, 0);
            this.blackBtn.Name = "blackBtn";
            this.blackBtn.Size = new System.Drawing.Size(28, 25);
            this.blackBtn.TabIndex = 0;
            this.blackBtn.Text = "d";
            this.blackBtn.UseVisualStyleBackColor = false;
            this.blackBtn.Click += new System.EventHandler(this.ChooseColorClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chosen color";
            // 
            // chosenPictureBox
            // 
            this.chosenPictureBox.BackColor = System.Drawing.Color.Black;
            this.chosenPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chosenPictureBox.Location = new System.Drawing.Point(21, 47);
            this.chosenPictureBox.Name = "chosenPictureBox";
            this.chosenPictureBox.Size = new System.Drawing.Size(51, 43);
            this.chosenPictureBox.TabIndex = 0;
            this.chosenPictureBox.TabStop = false;
            // 
            // pickColorBtn
            // 
            this.pickColorBtn.Image = ((System.Drawing.Image)(resources.GetObject("pickColorBtn.Image")));
            this.pickColorBtn.Location = new System.Drawing.Point(458, 48);
            this.pickColorBtn.Name = "pickColorBtn";
            this.pickColorBtn.Size = new System.Drawing.Size(60, 47);
            this.pickColorBtn.TabIndex = 5;
            this.pickColorBtn.UseVisualStyleBackColor = true;
            this.pickColorBtn.Click += new System.EventHandler(this.ChooseColorBtnClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(436, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Specific color...";
            // 
            // eraseBtn
            // 
            this.eraseBtn.Image = ((System.Drawing.Image)(resources.GetObject("eraseBtn.Image")));
            this.eraseBtn.Location = new System.Drawing.Point(560, 48);
            this.eraseBtn.Name = "eraseBtn";
            this.eraseBtn.Size = new System.Drawing.Size(59, 47);
            this.eraseBtn.TabIndex = 9;
            this.eraseBtn.UseVisualStyleBackColor = true;
            this.eraseBtn.Click += new System.EventHandler(this.EraseBtnClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(857, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Brush size";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(565, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Eraser";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(994, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Print figures:";
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.Location = new System.Drawing.Point(0, 135);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1148, 589);
            this.pictureBox.TabIndex = 14;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PictureBoxMouseClick);
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PicturePanelMouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PicturePanelMouseMove);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PicturePanelMouseUp);
            // 
            // shapeTypeBox
            // 
            this.shapeTypeBox.FormattingEnabled = true;
            this.shapeTypeBox.Location = new System.Drawing.Point(994, 70);
            this.shapeTypeBox.Name = "shapeTypeBox";
            this.shapeTypeBox.Size = new System.Drawing.Size(125, 28);
            this.shapeTypeBox.TabIndex = 15;
            this.shapeTypeBox.SelectedIndexChanged += new System.EventHandler(this.ShapeTypeComboBoxSelectedIndexChanged);
            // 
            // sizeTrackBar
            // 
            this.sizeTrackBar.Location = new System.Drawing.Point(835, 70);
            this.sizeTrackBar.Minimum = 1;
            this.sizeTrackBar.Name = "sizeTrackBar";
            this.sizeTrackBar.Size = new System.Drawing.Size(120, 56);
            this.sizeTrackBar.TabIndex = 12;
            this.sizeTrackBar.Value = 1;
            this.sizeTrackBar.ValueChanged += new System.EventHandler(this.BrushSizeTrackBarVisibleChanged);
            // 
            // enabledCheckBox
            // 
            this.enabledCheckBox.AutoSize = true;
            this.enabledCheckBox.Location = new System.Drawing.Point(911, 104);
            this.enabledCheckBox.Name = "enabledCheckBox";
            this.enabledCheckBox.Size = new System.Drawing.Size(85, 24);
            this.enabledCheckBox.TabIndex = 18;
            this.enabledCheckBox.Text = "Enabled";
            this.enabledCheckBox.UseVisualStyleBackColor = true;
            this.enabledCheckBox.CheckedChanged += new System.EventHandler(this.EnableSmoothingCheckBoxChecked);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(800, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Smooth touch:";
            // 
            // fillBtn
            // 
            this.fillBtn.Image = ((System.Drawing.Image)(resources.GetObject("fillBtn.Image")));
            this.fillBtn.Location = new System.Drawing.Point(664, 48);
            this.fillBtn.Name = "fillBtn";
            this.fillBtn.Size = new System.Drawing.Size(59, 47);
            this.fillBtn.TabIndex = 20;
            this.fillBtn.UseVisualStyleBackColor = true;
            this.fillBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FillBtnMouseClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(626, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Fill space with color";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 724);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.fillBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.enabledCheckBox);
            this.Controls.Add(this.sizeTrackBar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.shapeTypeBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.eraseBtn);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pickColorBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chosenPictureBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.paintMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.paintMenuStrip;
            this.Name = "Form1";
            this.Text = "Graphic Designer";
            this.paintMenuStrip.ResumeLayout(false);
            this.paintMenuStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chosenPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip paintMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button lightRedBtn;
        private System.Windows.Forms.Button redBtn;
        private System.Windows.Forms.Button lightPurpleBtn;
        private System.Windows.Forms.Button purpleBtn;
        private System.Windows.Forms.Button lightBlueBtn;
        private System.Windows.Forms.Button blueBtn;
        private System.Windows.Forms.Button cyanBtn;
        private System.Windows.Forms.Button tealBtn;
        private System.Windows.Forms.Button lightGreenBtn;
        private System.Windows.Forms.Button greenBtn;
        private System.Windows.Forms.Button lightYellowBtn;
        private System.Windows.Forms.Button yellowBtn;
        private System.Windows.Forms.Button lightOrangeBtn;
        private System.Windows.Forms.Button orangeBtn;
        private System.Windows.Forms.Button indianBtn;
        private System.Windows.Forms.Button maroonBtn;
        private System.Windows.Forms.Button silverBtn;
        private System.Windows.Forms.Button grayBtn;
        private System.Windows.Forms.Button whiteBtn;
        private System.Windows.Forms.Button blackBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox chosenPictureBox;
        private System.Windows.Forms.Button pickColorBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button eraseBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ComboBox shapeTypeBox;
        private System.Windows.Forms.TrackBar sizeTrackBar;
        private System.Windows.Forms.CheckBox enabledCheckBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripMenuItem clearAllToolStripMenuItem;
        private System.Windows.Forms.Button fillBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
    }
}

