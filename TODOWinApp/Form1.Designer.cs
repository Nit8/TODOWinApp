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
            textBoxTask.Location = new System.Drawing.Point(14, 28);
            textBoxTask.Name = "textBoxTask";
            textBoxTask.Size = new System.Drawing.Size(431, 22);
            textBoxTask.TabIndex = 0;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new System.Drawing.Point(471, 13);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new System.Drawing.Size(86, 25);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "Add Task";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += new System.EventHandler(buttonAdd_Click);  
            // Event handler added
            // 
            // listBoxTasks
            // 
            listBoxTasks.FormattingEnabled = true;
            listBoxTasks.ItemHeight = 16;
            listBoxTasks.Location = new System.Drawing.Point(14, 92);
            listBoxTasks.Name = "listBoxTasks";
            listBoxTasks.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            listBoxTasks.Size = new System.Drawing.Size(543, 292);
            listBoxTasks.TabIndex = 2;
            // 
            // buttonMarkAs
            // 
            buttonMarkAs.Location = new System.Drawing.Point(14, 397);
            buttonMarkAs.Name = "buttonMarkAs";
            buttonMarkAs.Size = new System.Drawing.Size(86, 25);
            buttonMarkAs.TabIndex = 3;
            buttonMarkAs.Text = "Mark as";
            buttonMarkAs.UseVisualStyleBackColor = true;
            buttonMarkAs.Click += new System.EventHandler(buttonMarkAs_Click);  
            // Event handler added
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new System.Drawing.Point(471, 397);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new System.Drawing.Size(86, 25);
            buttonDelete.TabIndex = 4;
            buttonDelete.Text = "Delete Task";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += new System.EventHandler(buttonDelete_Click);  
            // Event handler added
            // 
            // contextMenuMarkAs
            // 
            contextMenuMarkAs.ImageScalingSize = new System.Drawing.Size(20, 20);
            contextMenuMarkAs.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
        doneToolStripMenuItem,
        undoneToolStripMenuItem});
            contextMenuMarkAs.Name = "contextMenuMarkAs";
            contextMenuMarkAs.Size = new System.Drawing.Size(131, 52);
            // 
            // doneToolStripMenuItem
            // 
            doneToolStripMenuItem.Name = "doneToolStripMenuItem";
            doneToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            doneToolStripMenuItem.Text = "Done";
            doneToolStripMenuItem.Click += new System.EventHandler(doneToolStripMenuItem_Click);  
            // Event handler added
            // 
            // undoneToolStripMenuItem
            // 
            undoneToolStripMenuItem.Name = "undoneToolStripMenuItem";
            undoneToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            undoneToolStripMenuItem.Text = "Undone";
            undoneToolStripMenuItem.Click += new System.EventHandler(undoneToolStripMenuItem_Click);  
            // Event handler added
            // 
            // buttonSelectAll
            // 
            buttonSelectAll.Location = new System.Drawing.Point(471, 44);
            buttonSelectAll.Name = "buttonSelectAll";
            buttonSelectAll.Size = new System.Drawing.Size(86, 25);
            buttonSelectAll.TabIndex = 5;
            buttonSelectAll.Text = "Select All";
            buttonSelectAll.UseVisualStyleBackColor = true;
            buttonSelectAll.Click += new System.EventHandler(buttonSelectAll_Click);  
            // Event handler added
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(569, 434);
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

