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
using static Sortie.Index;

namespace Sortie
{
    public partial class Sort : Form
    {
        private static int totalFiles = 0;
        private static int skippedFiles = 0;
        bool toggle = false;
        public Sort ()
        {
            InitializeComponent();
            getNextFile();
        }

        private void delete_CheckedChanged (object sender, EventArgs e)
        {
            if (move.Checked == true)
            if (move.Checked == true)
            {
                delete.Checked = false;
            }
        }

        private void move_CheckedChanged (object sender, EventArgs e)
        {
            if (delete.Checked == true)
            {
                move.Checked = false;
            }
        }

        private void applyAll_CheckedChanged (object sender, EventArgs e) { }

        private void sortFile_Click (object sender, EventArgs e)
        {
            Files currentFile = getCurrentFile();
            if (currentFile != null)
            {
                string option;

                if (move.Checked == true)
                {
                    option = "Move";
                }
                else
                {
                    option = "Delete";
                }
                if (applyAll.Checked == true)
                {
                    string message = "This will " + option.ToLower() + " all other files that have the " + currentFile.Extension + " extension. Are you sure?";
                    string title = option + " All?";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.Yes)
                    {
                        Task task = beginSort(currentFile);
                    }
                    else if (result == DialogResult.No)
                    {
                        applyAll.Checked = false;
                    }

                }
                else
                {
                    Task task = beginSort(currentFile);
                }
            }
            
        }

        private async Task beginSort (Files currentFile)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            // Handle moving files
            if (move.Checked)
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    await Task.Run(() =>
                    {
                        // Move all is selected
                        if (applyAll.Checked)
                        {
                            for (int i = 0; i < FilesList.files.Count; i++)
                            {
                                Files file = FilesList.files[i];
                                bool readyForSort = !file.IsSorted && file.IsChecked;
                                bool extensionMatch = file.Extension.ToLower() == currentFile.Extension.ToLower();
                                if (readyForSort && extensionMatch)
                                {
                                    string newLoc = fbd.SelectedPath + "/" + file.Name;

                                    try
                                    {
                                        File.Move(file.Path, newLoc);
                                    }
                                    catch
                                    {                                        
                                        skippedFiles++;                                        
                                    }
                                    finally
                                    {
                                        updateFileCount();
                                        Task task = updateFile(newLoc, file);
                                    }
                                }                             
                            }
                        }
                        // Move all is not selected
                        else
                        {
                            string newLoc = fbd.SelectedPath + "/" + currentFile.Name;
                            try
                            {

                                File.Move(currentFile.Path, newLoc);
                            }
                            catch (IOException e)
                            {
                                string message = "The file " + currentFile.Name + " already exists in " + fbd.SelectedPath + ". Overwrite? This will create a backup.";
                                string title = "Overwrite file?";
                                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                                DialogResult result = MessageBox.Show(message, title, buttons);
                                if (result == DialogResult.Yes)
                                {
                                    File.Replace(currentFile.Path, fbd.SelectedPath + "/" + currentFile.Name, fbd.SelectedPath + "/" + currentFile.Name + ".backup");
                                }
                            }
                            finally
                            {
                                Task task = updateFile(newLoc, currentFile);
                                
                            }

                        }
                    });
                    getNextFile();
                }
            }
            // Handle deleting files
            if (delete.Checked)
            {          
                await Task.Run(() =>
                {
                    // Delete all is selected
                    if (applyAll.Checked)
                    {
                        for (int i = 0; i < FilesList.files.Count; i++)
                        {
                            Files file = FilesList.files[i];
                            bool readyForSort = !file.IsSorted && file.IsChecked;
                            bool extensionMatch = file.Extension.ToLower() == currentFile.Extension.ToLower();
                            if (readyForSort && extensionMatch)
                            {
                                try
                                {
                                    File.Delete(file.Path);
                                }
                                catch
                                {
                                    skippedFiles++;
                                }
                                finally
                                {
                                    
                                    updateFileCount();
                                }
                            }
                        }
                    }
                    // Delete all is not selected
                    else
                    {
                        try
                        {
                            File.Delete(currentFile.Path);
                        }
                        catch 
                        {
                            skippedFiles++;
                        }
                        finally {
                            Task task = updateFile(currentFile.Path, currentFile);
                            updateFileCount(); 
                        }

                    }
                });
                getNextFile();
            }
        }

        private Files getNextFile()
        {
            updateFileCount();
            Files result = FilesList.files.Find(f => f.IsChecked && !f.IsSorted);
            if (result == null)
            {
                return result;
            }
            else
            {
                result.IsCurrent = true;
                fileName.Text = result.Name;
                applyAll.Text = "Apply to all " + result.Extension + " files";
                try
                {
                    Icon icon = System.Drawing.Icon.ExtractAssociatedIcon(result.Path);                    
                    Image image = Bitmap.FromHicon(icon.Handle);
                    Bitmap resized = new Bitmap(image, new Size(50,50));

                    pictureBox1.Image = resized;
                }
                catch
                {
                    // Do nothing
                }

                pushUpdate(result);
                return result;
            }            
        }

        private Files getCurrentFile()
        {
            Files result = FilesList.files.Find(f => f.IsCurrent);
            return result;
        }

        private async Task updateFile(string newLoc, Files file)
        {
            await Task.Run(() =>
            {
                file.IsSorted = true;
                file.IsCurrent = false;
                file.Path = newLoc;
                pushUpdate(file);
            });            
        }

        private void pushUpdate(Files file)
        {
            int index = FilesList.files.FindIndex(f => f.ID == file.ID);
            if (index != -1)
            {
                FilesList.files[index] = file;
            }
        }


        private string extender(string s)
        {
            if (s.Length < 50)
            {
                var builder = new StringBuilder();
                foreach (var c in s)
                {
                    builder.Append(c);
                }
                for (int i = 0; i < (50 - s.Length); i++)
                {
                    builder.Append(" ");
                }
                s = builder.ToString();
                return s;
            }
            return s;
        }

        private void debug_Click (object sender, EventArgs e)
        {
            foreach (var file in FilesList.files)
            {
                string name = "Name: " + file.Name;
                string ischecked = " Checked: " + file.IsChecked;
                string sorted = " Sorted: " + file.IsSorted;
                string current = " Current: " + file.IsCurrent;
                name = extender(name);
                ischecked = extender(ischecked);
                sorted = extender(sorted);
                current = extender(current);
                Console.WriteLine(name + ischecked + sorted + current);
            }
            Console.WriteLine("\n");
        }

        private int getFileCount()
        {
            int count = 0;
            for (int i = 0; i < FilesList.files.Count;i++)
            {
                if (FilesList.files[i].IsChecked && !FilesList.files[i].IsSorted)
                {
                    count++;
                }
            }
            return count;
        }

        delegate void updateFileCountCallback();
        private void updateFileCount()
        {
            int count = getFileCount();
            
            if (!toggle)
            {
                totalFiles = count;
                toggle = true;
            }
            if (count != 0)
            {
                if (this.InvokeRequired)
                {
                    updateFileCountCallback d = new updateFileCountCallback(updateFileCount);
                    this.Invoke(d);
                }
                else
                {
                    /*this.status.Text = count + append;*/
                    double percent = (((double)totalFiles-(double)count) / (double)totalFiles) * 100;
                    Console.WriteLine(progress.Value);
                    progress.Value = ((int)percent);                    
                }
            }
            else
            {
                endSort();
            }
        }

        private void endSort ()
        {          
            progress.Value = 100;
            int sorted = totalFiles - skippedFiles;
            string message = sorted + " files sorted. " + skippedFiles + " files skipped.";
            string title = "Sortie Complete!";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.OK)
            {
                Index indexForm = new Index();
                this.Hide();
                indexForm.Show();
            }
        }
    }
}