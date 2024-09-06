using System;
using System.Drawing;
using System.Windows.Forms;

namespace TODOWinApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxTask.Text))
            {
                listBoxTasks.Items.Add(textBoxTask.Text);
                textBoxTask.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a task.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonMarkAs_Click(object sender, EventArgs e)
        {
            if (listBoxTasks.SelectedIndices.Count > 0)
            {
                contextMenuMarkAs.Show(buttonMarkAs, new Point(0, buttonMarkAs.Height));
            }
            else
            {
                MessageBox.Show("Please select at least one task to mark.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void doneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MarkTasks("(Done)");
        }

        private void undoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MarkTasks("(Undone)");
        }

        private void MarkTasks(string status)
        {
            ListBox.SelectedIndexCollection selectedIndices = listBoxTasks.SelectedIndices;
            for (int i = selectedIndices.Count - 1; i >= 0; i--)
            {
                int index = selectedIndices[i];
                string task = listBoxTasks.Items[index].ToString();

                // Remove any existing status
                task = task.Replace("(Done)", "").Replace("(Undone)", "").Trim();

                listBoxTasks.Items[index] = $"{task} {status}";
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxTasks.SelectedIndices.Count > 0)
            {
                for (int i = listBoxTasks.SelectedIndices.Count - 1; i >= 0; i--)
                {
                    listBoxTasks.Items.RemoveAt(listBoxTasks.SelectedIndices[i]);
                }
            }
            else
            {
                MessageBox.Show("Please select at least one task to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonSelectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBoxTasks.Items.Count; i++)
            {
                listBoxTasks.SetSelected(i, true);
            }
        }
    }
}
