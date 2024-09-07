using System;
using System.Drawing;
using System.Windows.Forms;

namespace TODOWinApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private MenuStrip menuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;

        /// <summary>
        /// Normal Winform
        /// </summary>
        //private TextBox textBoxTask;
        //private Button buttonAdd;
        private ListBox listBoxTasks;
        //private Button buttonMarkAs;
        //private Button buttonDelete;
        //private ContextMenuStrip contextMenuMarkAs;
        //private ToolStripMenuItem doneToolStripMenuItem;
        //private ToolStripMenuItem undoneToolStripMenuItem;
        //private Button buttonSelectAll;

        private SaveFileDialog saveFileDialog;
        private MaterialSkin.Controls.MaterialTextBox textBoxTask;
        private MaterialSkin.Controls.MaterialButton buttonAdd;
        //private MaterialSkin.Controls.MaterialListBox listBoxTasks;
        private MaterialSkin.Controls.MaterialButton buttonMarkAs;
        private MaterialSkin.Controls.MaterialButton buttonDelete;
        private MaterialSkin.Controls.MaterialContextMenuStrip contextMenuMarkAs;
        private System.Windows.Forms.ToolStripMenuItem doneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoneToolStripMenuItem;
        private MaterialSkin.Controls.MaterialButton buttonSelectAll;

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

        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxTask = new MaterialSkin.Controls.MaterialTextBox();
            this.buttonAdd = new MaterialSkin.Controls.MaterialButton();
            this.listBoxTasks = new System.Windows.Forms.ListBox();
            this.buttonMarkAs = new MaterialSkin.Controls.MaterialButton();
            this.buttonDelete = new MaterialSkin.Controls.MaterialButton();
            this.contextMenuMarkAs = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.doneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonSelectAll = new MaterialSkin.Controls.MaterialButton();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip.SuspendLayout();
            this.contextMenuMarkAs.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(3, 64);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(759, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // textBoxTask
            // 
            this.textBoxTask.AnimateReadOnly = false;
            this.textBoxTask.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask.Depth = 0;
            this.textBoxTask.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxTask.Hint = "Enter a task";
            this.textBoxTask.LeadingIcon = null;
            this.textBoxTask.Location = new System.Drawing.Point(55, 98);
            this.textBoxTask.MaxLength = 50;
            this.textBoxTask.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxTask.Multiline = false;
            this.textBoxTask.Name = "textBoxTask";
            this.textBoxTask.Size = new System.Drawing.Size(518, 50);
            this.textBoxTask.TabIndex = 1;
            this.textBoxTask.Text = "";
            this.textBoxTask.TrailingIcon = null;
            // 
            // buttonAdd
            // 
            this.buttonAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonAdd.Depth = 0;
            this.buttonAdd.HighEmphasis = true;
            this.buttonAdd.Icon = null;
            this.buttonAdd.Location = new System.Drawing.Point(613, 91);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonAdd.Size = new System.Drawing.Size(91, 36);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Add Task";
            this.buttonAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonAdd.UseAccentColor = false;
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // listBoxTasks
            // 
            this.listBoxTasks.FormattingEnabled = true;
            this.listBoxTasks.ItemHeight = 16;
            this.listBoxTasks.Location = new System.Drawing.Point(39, 184);
            this.listBoxTasks.Name = "listBoxTasks";
            this.listBoxTasks.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxTasks.Size = new System.Drawing.Size(690, 292);
            this.listBoxTasks.TabIndex = 3;
            // 
            // buttonMarkAs
            // 
            this.buttonMarkAs.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonMarkAs.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonMarkAs.Depth = 0;
            this.buttonMarkAs.HighEmphasis = true;
            this.buttonMarkAs.Icon = null;
            this.buttonMarkAs.Location = new System.Drawing.Point(7, 485);
            this.buttonMarkAs.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonMarkAs.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonMarkAs.Name = "buttonMarkAs";
            this.buttonMarkAs.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonMarkAs.Size = new System.Drawing.Size(84, 36);
            this.buttonMarkAs.TabIndex = 4;
            this.buttonMarkAs.Text = "Mark as";
            this.buttonMarkAs.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonMarkAs.UseAccentColor = false;
            this.buttonMarkAs.UseVisualStyleBackColor = true;
            this.buttonMarkAs.Click += new System.EventHandler(this.buttonMarkAs_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonDelete.Depth = 0;
            this.buttonDelete.HighEmphasis = true;
            this.buttonDelete.Icon = null;
            this.buttonDelete.Location = new System.Drawing.Point(601, 485);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonDelete.Size = new System.Drawing.Size(114, 36);
            this.buttonDelete.TabIndex = 5;
            this.buttonDelete.Text = "Delete Task";
            this.buttonDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonDelete.UseAccentColor = false;
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // contextMenuMarkAs
            // 
            this.contextMenuMarkAs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.contextMenuMarkAs.Depth = 0;
            this.contextMenuMarkAs.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuMarkAs.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doneToolStripMenuItem,
            this.undoneToolStripMenuItem});
            this.contextMenuMarkAs.MouseState = MaterialSkin.MouseState.HOVER;
            this.contextMenuMarkAs.Name = "contextMenuMarkAs";
            this.contextMenuMarkAs.Size = new System.Drawing.Size(131, 52);
            // 
            // doneToolStripMenuItem
            // 
            this.doneToolStripMenuItem.Name = "doneToolStripMenuItem";
            this.doneToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.doneToolStripMenuItem.Text = "Done";
            this.doneToolStripMenuItem.Click += new System.EventHandler(this.doneToolStripMenuItem_Click);
            // 
            // undoneToolStripMenuItem
            // 
            this.undoneToolStripMenuItem.Name = "undoneToolStripMenuItem";
            this.undoneToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.undoneToolStripMenuItem.Text = "Undone";
            this.undoneToolStripMenuItem.Click += new System.EventHandler(this.undoneToolStripMenuItem_Click);
            // 
            // buttonSelectAll
            // 
            this.buttonSelectAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSelectAll.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonSelectAll.Depth = 0;
            this.buttonSelectAll.HighEmphasis = true;
            this.buttonSelectAll.Icon = null;
            this.buttonSelectAll.Location = new System.Drawing.Point(601, 139);
            this.buttonSelectAll.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonSelectAll.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonSelectAll.Name = "buttonSelectAll";
            this.buttonSelectAll.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonSelectAll.Size = new System.Drawing.Size(103, 36);
            this.buttonSelectAll.TabIndex = 6;
            this.buttonSelectAll.Text = "Select All";
            this.buttonSelectAll.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonSelectAll.UseAccentColor = false;
            this.buttonSelectAll.UseVisualStyleBackColor = true;
            this.buttonSelectAll.Click += new System.EventHandler(this.buttonSelectAll_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            this.saveFileDialog.Title = "Save TODO List As";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 530);
            this.Controls.Add(this.buttonSelectAll);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonMarkAs);
            this.Controls.Add(this.listBoxTasks);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxTask);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.Text = "TODO App";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.contextMenuMarkAs.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
            #endregion
        }
    }
}

