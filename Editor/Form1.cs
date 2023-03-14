using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Task - Create text editor with features using Toolbar menu 
namespace Editor
{
    public partial class Form1 : Form
    {
        public string copiedText { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        // change font
        private void ChangeFontToolStripMenuItemClick(object sender, EventArgs e)
        {
            FontDialog dialog = new();

            dialog.Font = textBox1.Font;

            if (dialog.ShowDialog() == DialogResult.OK)
                textBox1.Font = dialog.Font;
        }

        // text color
        private void ChangeColorToolStripMenuItemClick(object sender, EventArgs e)
        {
            ColorDialog dialog = new();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.ForeColor = dialog.Color;
            }
        }

        // background
        private void ChangeBackgroundToolStripMenuItemClick(object sender, EventArgs e)
        {
            ColorDialog dialog = new();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.BackColor = dialog.Color;
            }
        }

        // copy text
        private void CopyToolStripMenuItemClick(object sender, EventArgs e)
        {
            copiedText = textBox1.Text;
        }

        // paste text
        private void PasteToolStripMenuItemClick(object sender, EventArgs e)
        {
            textBox1.Text = copiedText;
        }

        // select all text
        private void SelectAllToolStripMenuItemClick(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

        // deselect all text
        private void UnselectAllToolStripMenuItemClick(object sender, EventArgs e)
        {
            textBox1.DeselectAll();
        }

        // save text
        private void SaveToolStripMenuItemClick(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            SaveFileDialog dialogue = new();
            dialogue.DefaultExt = ".txt";

            if (dialogue.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(dialogue.FileName, text);
            }
        }

        // load text
        private void LoadToolStripMenuItemClick(object sender, EventArgs e)
        {
            OpenFileDialog dialogue = new();

            if (dialogue.ShowDialog() == DialogResult.OK)
            {
                string text = File.ReadAllText(dialogue.FileName);
                textBox1.Text = text;
            }
        }

        // exit application
        private void ExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
