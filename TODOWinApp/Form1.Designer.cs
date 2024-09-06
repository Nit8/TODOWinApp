using System.Drawing;
using System.Windows.Forms;

namespace TODOWinApp
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
            components = new System.ComponentModel.Container();
            textBoxTask = new TextBox();
            buttonAdd = new Button();
            listBoxTasks = new ListBox();
            buttonMarkAs = new Button();
            buttonDelete = new Button();
            contextMenuMarkAs = new ContextMenuStrip(components);
            doneToolStripMenuItem = new ToolStripMenuItem();
            undoneToolStripMenuItem = new ToolStripMenuItem();
            buttonSelectAll = new Button();
            contextMenuMarkAs.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxTask
            // 
            textBoxTask.Location = new Point(12, 12);
            textBoxTask.Name = "textBoxTask";
            textBoxTask.Size = new Size(200, 23);
            textBoxTask.TabIndex = 0;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(218, 11);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 23);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "Add Task";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // listBoxTasks
            // 
            listBoxTasks.FormattingEnabled = true;
            listBoxTasks.ItemHeight = 15;
            listBoxTasks.Location = new Point(12, 41);
            listBoxTasks.Name = "listBoxTasks";
            listBoxTasks.SelectionMode = SelectionMode.MultiExtended;
            listBoxTasks.Size = new Size(280, 154);
            listBoxTasks.TabIndex = 2;
            // 
            // buttonMarkAs
            // 
            buttonMarkAs.Location = new Point(12, 201);
            buttonMarkAs.Name = "buttonMarkAs";
            buttonMarkAs.Size = new Size(75, 23);
            buttonMarkAs.TabIndex = 3;
            buttonMarkAs.Text = "Mark as";
            buttonMarkAs.UseVisualStyleBackColor = true;
            buttonMarkAs.Click += buttonMarkAs_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(217, 201);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(75, 23);
            buttonDelete.TabIndex = 4;
            buttonDelete.Text = "Delete Task";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // contextMenuMarkAs
            // 
            contextMenuMarkAs.Items.AddRange(new ToolStripItem[] { doneToolStripMenuItem, undoneToolStripMenuItem });
            contextMenuMarkAs.Name = "contextMenuMarkAs";
            contextMenuMarkAs.Size = new Size(117, 48);
            // 
            // doneToolStripMenuItem
            // 
            doneToolStripMenuItem.Name = "doneToolStripMenuItem";
            doneToolStripMenuItem.Size = new Size(116, 22);
            doneToolStripMenuItem.Text = "Done";
            doneToolStripMenuItem.Click += doneToolStripMenuItem_Click;
            // 
            // undoneToolStripMenuItem
            // 
            undoneToolStripMenuItem.Name = "undoneToolStripMenuItem";
            undoneToolStripMenuItem.Size = new Size(116, 22);
            undoneToolStripMenuItem.Text = "Undone";
            undoneToolStripMenuItem.Click += undoneToolStripMenuItem_Click;
            // 
            // buttonSelectAll
            // 
            buttonSelectAll.Location = new Point(93, 201);
            buttonSelectAll.Name = "buttonSelectAll";
            buttonSelectAll.Size = new Size(75, 23);
            buttonSelectAll.TabIndex = 5;
            buttonSelectAll.Text = "Select All";
            buttonSelectAll.UseVisualStyleBackColor = true;
            buttonSelectAll.Click += buttonSelectAll_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 241);
            Controls.Add(buttonSelectAll);
            Controls.Add(buttonDelete);
            Controls.Add(buttonMarkAs);
            Controls.Add(listBoxTasks);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxTask);
            Name = "Form1";
            Text = "TODO App";
            contextMenuMarkAs.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxTask;
        private Button buttonAdd;
        private ListBox listBoxTasks;
        private Button buttonMarkAs;
        private Button buttonDelete;
        private ContextMenuStrip contextMenuMarkAs;
        private ToolStripMenuItem doneToolStripMenuItem;
        private ToolStripMenuItem undoneToolStripMenuItem;
        private Button buttonSelectAll;
    }
}

