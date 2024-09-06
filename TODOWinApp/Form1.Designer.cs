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
        private TextBox textBoxTask;
        private Button buttonAdd;
        private ListBox listBoxTasks;
        private Button buttonMarkAs;
        private Button buttonDelete;
        private ContextMenuStrip contextMenuMarkAs;
        private ToolStripMenuItem doneToolStripMenuItem;
        private ToolStripMenuItem undoneToolStripMenuItem;
        private Button buttonSelectAll;
        private SaveFileDialog saveFileDialog;

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
            components = new System.ComponentModel.Container();
            menuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            textBoxTask = new TextBox();
            buttonAdd = new Button();
            listBoxTasks = new ListBox();
            buttonMarkAs = new Button();
            buttonDelete = new Button();
            contextMenuMarkAs = new ContextMenuStrip(components);
            doneToolStripMenuItem = new ToolStripMenuItem();
            undoneToolStripMenuItem = new ToolStripMenuItem();
            buttonSelectAll = new Button();
            saveFileDialog = new SaveFileDialog();
            menuStrip.SuspendLayout();
            contextMenuMarkAs.SuspendLayout();
            SuspendLayout();

            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] {
                fileToolStripMenuItem
            });
            menuStrip.Location = new System.Drawing.Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new System.Drawing.Size(569, 28);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip";

            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
                newToolStripMenuItem,
                openToolStripMenuItem,
                saveToolStripMenuItem,
                exitToolStripMenuItem
            });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            fileToolStripMenuItem.Text = "File";

            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            newToolStripMenuItem.Text = "New";
            newToolStripMenuItem.Click += new EventHandler(newToolStripMenuItem_Click);

            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += new EventHandler(openToolStripMenuItem_Click);

            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += new EventHandler(saveToolStripMenuItem_Click);

            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += new EventHandler(exitToolStripMenuItem_Click);

            // 
            // textBoxTask
            // 
            textBoxTask.Location = new System.Drawing.Point(14, 40);
            textBoxTask.Name = "textBoxTask";
            textBoxTask.Size = new System.Drawing.Size(431, 22);
            textBoxTask.TabIndex = 1;

            // 
            // buttonAdd
            // 
            buttonAdd.Location = new System.Drawing.Point(471, 35);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new System.Drawing.Size(86, 25);
            buttonAdd.TabIndex = 2;
            buttonAdd.Text = "Add Task";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += new EventHandler(buttonAdd_Click);

            // 
            // listBoxTasks
            // 
            listBoxTasks.FormattingEnabled = true;
            listBoxTasks.ItemHeight = 16;
            listBoxTasks.Location = new System.Drawing.Point(14, 80);
            listBoxTasks.Name = "listBoxTasks";
            listBoxTasks.SelectionMode = SelectionMode.MultiExtended;
            listBoxTasks.Size = new System.Drawing.Size(543, 292);
            listBoxTasks.TabIndex = 3;

            // 
            // buttonMarkAs
            // 
            buttonMarkAs.Location = new System.Drawing.Point(14, 397);
            buttonMarkAs.Name = "buttonMarkAs";
            buttonMarkAs.Size = new System.Drawing.Size(86, 25);
            buttonMarkAs.TabIndex = 4;
            buttonMarkAs.Text = "Mark as";
            buttonMarkAs.UseVisualStyleBackColor = true;
            buttonMarkAs.Click += new EventHandler(buttonMarkAs_Click);

            // 
            // buttonDelete
            // 
            buttonDelete.Location = new System.Drawing.Point(471, 397);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new System.Drawing.Size(86, 25);
            buttonDelete.TabIndex = 5;
            buttonDelete.Text = "Delete Task";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += new EventHandler(buttonDelete_Click);

            // 
            // contextMenuMarkAs
            // 
            contextMenuMarkAs.ImageScalingSize = new System.Drawing.Size(20, 20);
            contextMenuMarkAs.Items.AddRange(new ToolStripItem[] {
                doneToolStripMenuItem,
                undoneToolStripMenuItem
            });
            contextMenuMarkAs.Name = "contextMenuMarkAs";
            contextMenuMarkAs.Size = new System.Drawing.Size(131, 52);

            // 
            // doneToolStripMenuItem
            // 
            doneToolStripMenuItem.Name = "doneToolStripMenuItem";
            doneToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            doneToolStripMenuItem.Text = "Done";
            doneToolStripMenuItem.Click += new EventHandler(doneToolStripMenuItem_Click);

            // 
            // undoneToolStripMenuItem
            // 
            undoneToolStripMenuItem.Name = "undoneToolStripMenuItem";
            undoneToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            undoneToolStripMenuItem.Text = "Undone";
            undoneToolStripMenuItem.Click += new EventHandler(undoneToolStripMenuItem_Click);

            // 
            // buttonSelectAll
            // 
            buttonSelectAll.Location = new System.Drawing.Point(471, 65);
            buttonSelectAll.Name = "buttonSelectAll";
            buttonSelectAll.Size = new System.Drawing.Size(86, 25);
            buttonSelectAll.TabIndex = 6;
            buttonSelectAll.Text = "Select All";
            buttonSelectAll.UseVisualStyleBackColor = true;
            buttonSelectAll.Click += new EventHandler(buttonSelectAll_Click);

            // 
            // saveFileDialog
            // 
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.Title = "Save TODO List As";

            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(569, 434);
            Controls.Add(buttonSelectAll);
            Controls.Add(buttonDelete);
            Controls.Add(buttonMarkAs);
            Controls.Add(listBoxTasks);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxTask);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "Form1";
            Text = "TODO App";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            contextMenuMarkAs.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        #endregion
        }
    }
}

