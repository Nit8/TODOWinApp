using MaterialSkin;
using System;
using System.Drawing;
using System.Net.Http;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace TODOWinApp
{
    public partial class Form1 : MaterialForm
    {
        private const string versionUrl = "https://drive.google.com/uc?export=download&id=1-OuXxtetNfmtGzKSpKmx--k4X4nx8rYj";
        private MaterialSkin.MaterialSkinManager materialSkinManager;
        public Form1()
        {
            // Initialize the MaterialSkinManager and set the form's skin properties
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT; // or .DARK
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(
                MaterialSkin.Primary.Blue600, MaterialSkin.Primary.Blue700,
                MaterialSkin.Primary.Blue200, MaterialSkin.Accent.LightBlue200,
                MaterialSkin.TextShade.WHITE);

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
            // Check if any task is selected in the ListBox
            if (listBoxTasks.SelectedIndices.Count > 0)
            {
                // Show context menu for marking tasks as done/undone
                contextMenuMarkAs.Show(buttonMarkAs, new Point(0, buttonMarkAs.Height));
            }
            else
            {
                // Display a warning message if no task is selected
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
                            System.Diagnostics.Process.Start("https://drive.google.com/drive/folders/1-P9d9NE6xQNCizT-WmaMRVkyupDyNEwf?usp=sharing"); // Replace with your download link
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
