using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Sortie
{
    public partial class Index : Form
    {
        public class FilesList
        {
            public static List<Files> files = new List<Files>();
        }

        public Index ()
        {
            InitializeComponent();
        }

        private void folder_Click (object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                selectAll.Enabled = true;
                selectExtension.Enabled = true;
                deselectAll.Enabled = true;
                folderSelection.Text = fbd.SelectedPath;
                var dirPath = fbd.SelectedPath;
                string[] directories = null;

                if (Directory.Exists(dirPath))
                {
                    filesCheckedListBox.Items.Clear();
                    directories = Directory.GetFiles(dirPath, "*", SearchOption.AllDirectories);

                    for (int i = 0; i < directories.Length; i++)
                    {
                        var fileName = Path.GetFileName(directories[i]);
                        if (fileName != "desktop.ini")
                        {
                            var extension = Path.GetExtension(directories[i]);

                            var file = new Files(i, fileName, directories[i], extension, false, false, false);
                            FilesList.files.Add(file);
                            filesCheckedListBox.Items.Add(file.Name);
                        }
                    }
                }
                fileCount.Text = filesCheckedListBox.Items.Count + " files found.";
            }
            else
            {
                folderSelection.Text = "You didn't select a folder!";
                selectAll.Enabled = false;
                selectExtension.Enabled = false;
                deselectAll.Enabled = false;
                fileCount.Text = "No folder selected.";
                filesCheckedListBox.Items.Clear();
            }
        }

        private void selectAll_Click (object sender, EventArgs e)
        {
            for (int i = 0; i < filesCheckedListBox.Items.Count; i++)
            {
                filesCheckedListBox.SetItemChecked(i, true);
            }
        }

        private void deselectAll_Click (object sender, EventArgs e)
        {
            for (int i = 0; i < filesCheckedListBox.Items.Count; i++)
            {
                filesCheckedListBox.SetItemChecked(i, false);
            }
        }

        private void exitToolStripMenuItem_Click (object sender, EventArgs e)
        {
            this.Close();
        }

        private void next_Click (object sender, EventArgs e)
        {
            for (int i = 0; i < (filesCheckedListBox.Items.Count); i++)
            {
                if (filesCheckedListBox.GetItemChecked(i))
                {
                    foreach (Files file in FilesList.files)
                    {
                        if (file.Name.Equals(filesCheckedListBox.Items[i].ToString()))
                        {
                            file.IsChecked = true;
                        }

                    }
                }
            }
            Sort sortForm = new Sort();

            this.Hide();
            sortForm.Show();
        }

        private void filesCheckedListBox_ItemCheck (object sender, ItemCheckEventArgs e)
        {
            if (this.filesCheckedListBox.CheckedItems.Count == 1)
            {
                if (e.NewValue == CheckState.Unchecked)
                {
                    this.next.Enabled = false;
                }
            }
            else
            {
                this.next.Enabled = true;
            }
        }

        private void filesCheckedListBox_SelectedIndexChanged (object sender, EventArgs e)
        {
            string fileName = filesCheckedListBox.SelectedItem.ToString();
            Files file = FilesList.files.Find(f => f.Name == fileName);
            selectExtension.Text = "Select All " + file.Extension;
        }

        private void selectExtension_Click (object sender, EventArgs e)
        {
            string fileName = filesCheckedListBox.SelectedItem.ToString();
            Files file = FilesList.files.Find(f => f.Name == fileName);
            string extension = file.Extension;
            for (int i = 0; i < filesCheckedListBox.Items.Count; i++)
            {
                string item = filesCheckedListBox.Items[i].ToString();
                string[] itemExtension = item.Split('.');
                itemExtension[itemExtension.Length-1] = itemExtension[itemExtension.Length - 1].Insert(0, ".");
                
                if (itemExtension[itemExtension.Length -1] == extension)
                {
                    filesCheckedListBox.SetItemChecked(i, true);
                }
                
            }
        }
    }
}