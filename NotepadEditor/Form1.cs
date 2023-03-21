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

// Task - Create Notepad-type text editor

namespace NotepadEditor
{
    public partial class Form1 : Form
    {
        public string copiedText { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        // Change font and bakcground color
        private void ChangeBackColorBtnClick(object sender, EventArgs e)
        {
            ColorDialog dialog = new();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.BackColor = dialog.Color;
            }
        }
        private void ChangeColorBtnClick(object sender, EventArgs e)
        {
            ColorDialog dialog = new();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.ForeColor = dialog.Color;
            }
        }

        // Bullet
        private void AddBulletBtnClick(object sender, EventArgs e)
        {
            richTextBox1.SelectionBullet = !richTextBox1.SelectionBullet;
        }

        // Change alignment
        private void RigthAlignmentBtnClick(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void CenterAlignmentBtnClick(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void LeftAlignmentBtnClick(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        // Change font
        private void ChangeFontBtnClick(object sender, EventArgs e)
        {
            FontDialog dialogue = new();

            dialogue.Font = richTextBox1.SelectionFont;

            if (dialogue.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = dialogue.Font;
            }
        }

        // Save and Load using RTF method
        private void SaveBtnClick(object sender, EventArgs e)
        {
            SaveFileDialog dialogue = new()
            { 
                Filter = "RTF Files|*.rtf" 
            };

            if (dialogue.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(dialogue.FileName);
            }
        }
        private void LoadBtnClick(object sender, EventArgs e)
        {
            OpenFileDialog dialogue = new()
            {
                Filter = "RTF Files|*.rtf"
            };

            if (dialogue.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.LoadFile(dialogue.FileName);
            }
        }

        // Count amount of letters and lines
        private void ProgressBarSizeChanged(object sender, EventArgs e)
        {
            richTextBox1.MaxLength = progressBar1.Maximum;
        }

        private void RichTextBoxTextChanged(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength <= progressBar1.Maximum)
            {
                progressBar1.Value = richTextBox1.TextLength;
            }

            // words count
            lengthLabel.Text = richTextBox1.TextLength.ToString();
            // lines count
            linesLabel.Text = richTextBox1.Lines.Length.ToString();
        }

        // Copy/cut/paste text
        private void CopyToolStripClick(object sender, EventArgs e)
        {
            copiedText = richTextBox1.Text;
        }
        private void CutToolStripClick(object sender, EventArgs e)
        {
            copiedText = richTextBox1.Text;
            richTextBox1.SelectedText = " ";
        }
        private void PasteToolStripClick(object sender, EventArgs e)
        {
            richTextBox1.Text = copiedText;
        }

        // Select/deselect
        private void SelectToolStripClick(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }
        private void DeselectToolStripClick(object sender, EventArgs e)
        {
            richTextBox1.DeselectAll();
        }

        // Delete text
        private void DeleteToolStripClick(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = " ";
        }

        // Exit
        private void ExitBtnClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
