using System.Collections.Generic;

namespace Sortie
{
    partial class Index
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.welcomeMsg = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderSelection = new System.Windows.Forms.TextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.selectFolder = new System.Windows.Forms.Button();
            this.filesCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.fileCount = new System.Windows.Forms.Label();
            this.selectAll = new System.Windows.Forms.Button();
            this.deselectAll = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.next = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.selectExtension = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // welcomeMsg
            // 
            this.welcomeMsg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.welcomeMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeMsg.Location = new System.Drawing.Point(3, 0);
            this.welcomeMsg.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.welcomeMsg.Name = "welcomeMsg";
            this.welcomeMsg.Size = new System.Drawing.Size(378, 50);
            this.welcomeMsg.TabIndex = 0;
            this.welcomeMsg.Text = "Welcome to Sortie!";
            this.welcomeMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // folderSelection
            // 
            this.folderSelection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.folderSelection.Enabled = false;
            this.folderSelection.Location = new System.Drawing.Point(3, 73);
            this.folderSelection.Name = "folderSelection";
            this.folderSelection.ReadOnly = true;
            this.folderSelection.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.folderSelection.Size = new System.Drawing.Size(378, 20);
            this.folderSelection.TabIndex = 1;
            this.folderSelection.Text = "To begin, select a folder that you would like to sort.";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // selectFolder
            // 
            this.selectFolder.AutoSize = true;
            this.selectFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectFolder.Location = new System.Drawing.Point(3, 99);
            this.selectFolder.MaximumSize = new System.Drawing.Size(0, 23);
            this.selectFolder.Name = "selectFolder";
            this.selectFolder.Size = new System.Drawing.Size(378, 23);
            this.selectFolder.TabIndex = 3;
            this.selectFolder.Text = "Select Folder";
            this.selectFolder.UseVisualStyleBackColor = true;
            this.selectFolder.Click += new System.EventHandler(this.folder_Click);
            // 
            // filesCheckedListBox
            // 
            this.filesCheckedListBox.CheckOnClick = true;
            this.filesCheckedListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filesCheckedListBox.FormattingEnabled = true;
            this.filesCheckedListBox.Location = new System.Drawing.Point(3, 141);
            this.filesCheckedListBox.MultiColumn = true;
            this.filesCheckedListBox.Name = "filesCheckedListBox";
            this.filesCheckedListBox.Size = new System.Drawing.Size(378, 319);
            this.filesCheckedListBox.TabIndex = 5;
            this.filesCheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.filesCheckedListBox_ItemCheck);
            this.filesCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.filesCheckedListBox_SelectedIndexChanged);
            // 
            // fileCount
            // 
            this.fileCount.AutoSize = true;
            this.fileCount.Dock = System.Windows.Forms.DockStyle.Top;
            this.fileCount.Location = new System.Drawing.Point(3, 125);
            this.fileCount.Name = "fileCount";
            this.fileCount.Size = new System.Drawing.Size(378, 13);
            this.fileCount.TabIndex = 8;
            this.fileCount.Text = "No folder selected.";
            // 
            // selectAll
            // 
            this.selectAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectAll.Enabled = false;
            this.selectAll.Location = new System.Drawing.Point(3, 3);
            this.selectAll.Name = "selectAll";
            this.selectAll.Size = new System.Drawing.Size(88, 26);
            this.selectAll.TabIndex = 9;
            this.selectAll.Text = "Select All";
            this.selectAll.UseVisualStyleBackColor = true;
            this.selectAll.Click += new System.EventHandler(this.selectAll_Click);
            // 
            // deselectAll
            // 
            this.deselectAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deselectAll.Enabled = false;
            this.deselectAll.Location = new System.Drawing.Point(191, 3);
            this.deselectAll.Name = "deselectAll";
            this.deselectAll.Size = new System.Drawing.Size(88, 26);
            this.deselectAll.TabIndex = 10;
            this.deselectAll.Text = "Deselect All";
            this.deselectAll.UseVisualStyleBackColor = true;
            this.deselectAll.Click += new System.EventHandler(this.deselectAll_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(384, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // next
            // 
            this.next.Dock = System.Windows.Forms.DockStyle.Fill;
            this.next.Enabled = false;
            this.next.Location = new System.Drawing.Point(285, 3);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(90, 26);
            this.next.TabIndex = 12;
            this.next.Text = "Next";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.welcomeMsg, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.folderSelection, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.selectFolder, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.filesCheckedListBox, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.fileCount, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(384, 521);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.selectAll, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.next, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.selectExtension, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.deselectAll, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 466);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(378, 32);
            this.tableLayoutPanel2.TabIndex = 16;
            // 
            // selectExtension
            // 
            this.selectExtension.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectExtension.Enabled = false;
            this.selectExtension.Location = new System.Drawing.Point(97, 3);
            this.selectExtension.Name = "selectExtension";
            this.selectExtension.Size = new System.Drawing.Size(88, 26);
            this.selectExtension.TabIndex = 13;
            this.selectExtension.Text = "Select All .zip";
            this.selectExtension.UseVisualStyleBackColor = true;
            this.selectExtension.Click += new System.EventHandler(this.selectExtension_Click);
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(384, 525);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MinimumSize = new System.Drawing.Size(400, 545);
            this.Name = "Index";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sortie";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeMsg;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button selectFolder;
        private System.Windows.Forms.CheckedListBox filesCheckedListBox;
        private System.Windows.Forms.Label fileCount;
        private System.Windows.Forms.Button selectAll;
        private System.Windows.Forms.Button deselectAll;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox folderSelection;
        private System.Windows.Forms.Button selectExtension;
    }
}

