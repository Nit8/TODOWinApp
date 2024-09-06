using System;
using System.Drawing;
using System.Net.Http;
using System.Windows.Forms;

namespace TODOWinApp
{
    public partial class Form1 : Form
    {
        private const string versionUrl = "https://drive.google.com/uc?export=download&id=1e3frzVtaNFedqvNVRDnydvi5D9Q480k1";
        public Form1()
        {
            CheckForUpdates();
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
            MarkTasks("");
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
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Code to create a new task or clear the current list
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Code to open a file dialog and load tasks
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open the SaveFileDialog to allow the user to choose where to save the file
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Create a StreamWriter to write to the selected file
                    using (var writer = new System.IO.StreamWriter(saveFileDialog.FileName))
                    {
                        // Iterate through the items in the ListBox and write each item to the file
                        foreach (var item in listBoxTasks.Items)
                        {
                            writer.WriteLine(item.ToString());
                        }
                    }

                    // Notify the user that the file was saved successfully
                    MessageBox.Show("TODO list saved successfully.", "Save Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    // Handle any exceptions that occur during the file write operation
                    MessageBox.Show($"An error occurred while saving the TODO list: {ex.Message}", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void CheckForUpdates()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string latestVersion = await client.GetStringAsync(versionUrl);
                    string currentVersion = Application.ProductVersion;

                    if (IsNewVersionAvailable(currentVersion, latestVersion))
                    {
                        DialogResult result = MessageBox.Show(
                            "A new version is available. Do you want to download it?",
                            "Update Available",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Information);

                        if (result == DialogResult.Yes)
                        {
                            System.Diagnostics.Process.Start("https://github.com/Nit8/TODOWinApp"); // Replace with your download link
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to check for updates. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsNewVersionAvailable(string currentVersion, string latestVersion)
        {
            // Remove extra whitespace and newline characters
            latestVersion = latestVersion.Trim();

            // Compare the versions
            Version localVersion = new Version(currentVersion);
            Version onlineVersion = new Version(latestVersion);

            return onlineVersion > localVersion;
        }

    }
}
