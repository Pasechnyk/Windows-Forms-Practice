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
using Microsoft.VisualBasic;

// Task - Create Finder (Directory Viewer) using TreeView and ListView

namespace DirectoryViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            treeView1.Nodes.Clear();

            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            LoadDirectories(documentsPath, treeView1.Nodes);
        }

        // Show directories
        private void LoadDirectories(string root, TreeNodeCollection nodes)
        {
            try
            {
                var dirInfo = new DirectoryInfo(root);

                foreach (var d in dirInfo.GetDirectories())
                {
                    TreeNode node = new TreeNode(d.Name);
                    node.Tag = d.FullName;

                    LoadDirectories(d.FullName, node.Nodes);
                    nodes.Add(node);
                }
            }
            catch { }
        }

        // View after selection
        private void ViewDirectoriesAfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView1.SelectedNode == null) return;

            var node = treeView1.SelectedNode;

            if (node.Tag == null) return;

            DirectoryInfo dir = new(node.Tag.ToString());

            listView1.Items.Clear();
            foreach (var f in dir.GetFiles())
            {
                ListViewItem item = new(f.Name, 0);

                item.SubItems.Add(Path.GetExtension(f.Name));
                item.SubItems.Add($"{Math.Round(f.Length / 1024.0, 2, MidpointRounding.ToEven)} KB");

                item.Tag = f.FullName;
                listView1.Items.Add(item);
            }
        }
        private void ListSelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;

            var path = listView1.SelectedItems[0].Tag.ToString();

            MessageBox.Show(path);
        }

        // Types of views
        private void DetailsToolStripMenuItemClick(object sender, EventArgs e)
        {
            listView1.View = View.Details;
        }
        private void ListToolStripMenuItemClick(object sender, EventArgs e)
        {
            listView1.View = View.List;
        }
        private void TileToolStripMenuItemClick(object sender, EventArgs e)
        {
            listView1.View = View.Tile;
        }
        private void SmallIconsToolStripMenuItemClick(object sender, EventArgs e)
        {
            listView1.View = View.SmallIcon;
        }
        private void BigIconsToolStripMenuItemClick(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;
        }

        // Add new directory
        private void AddDirectoryToolStripItemClick(object sender, EventArgs e)
        {
            SaveFileDialog dialogue = new();

            if (dialogue.ShowDialog() == DialogResult.OK)
            {
                Directory.CreateDirectory(dialogue.FileName);
            }
        }

        // Rename directory/file
        private void RenameDirectoryToolStripItemClick(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode == null) return;
            else
            {
                string folderName = treeView1.SelectedNode.Text;
                string newFolderName = textBox1.Text;

                if (!string.IsNullOrEmpty(newFolderName))
                {
                    string name = Path.GetFileName(folderName);
                    string newFilePath = folderName.Replace(name, newFolderName);

                    System.IO.File.Move(folderName, newFilePath);
                    treeView1.SelectedNode.Text = newFilePath;
                }
            }
        }
        private void RenameFileToolStripItemClick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;
            else
            {
                string fileName = listView1.SelectedItems[0].Tag.ToString();
                string newFileName = textBox1.Text;

                if (!string.IsNullOrEmpty(newFileName))
                {
                    string name = Path.GetFileName(fileName);
                    string newFilePath = fileName.Replace(name, newFileName);

                    System.IO.File.Move(fileName, newFilePath);
                    listView1.SelectedItems[0].Tag = newFilePath;
                }
            }
        }

        // Remove file
        private void RemoveFileToolStripItemClick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;
            var item = listView1.SelectedItems[0];

            File.Delete(item.Tag.ToString());
            listView1.Items.Remove(item);
        }

        // Copy file
        private void CopyFileToolStripItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;
            var path = listView1.SelectedItems[0].Tag.ToString();
            var file = new FileInfo(path);

            File.Move(file.Name, "Copy" + file.Name);
        }

        // Exit 
        private void ExitToolStripItemClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
