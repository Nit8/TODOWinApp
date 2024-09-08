using MaterialSkin;
using System;
using System.Drawing;
using System.Net.Http;
using System.Windows.Forms;
using MaterialSkin.Controls;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace TODOWinApp
{
    public partial class Form1 : MaterialForm
    {
        //private const string versionUrl = "https://drive.google.com/uc?export=download&id=1-OuXxtetNfmtGzKSpKmx--k4X4nx8rYj";
        private readonly string versionUrl;
        
        private MaterialSkinManager materialSkinManager;
        private readonly string todoFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "TodoList.txt");

        public Form1()
        {
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT; // or .DARK
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue600, Primary.Blue700,
                Primary.Blue200, Accent.LightBlue200,
                TextShade.WHITE);

            var configuration = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .Build();

            versionUrl = configuration["VersionUrl"];

            InitializeComponent();
                CheckForUpdates();
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
            listBoxTasks.Items.Clear();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    listBoxTasks.Items.Clear();
                    string[] tasks = File.ReadAllLines(openFileDialog.FileName);
                    listBoxTasks.Items.AddRange(tasks);
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (var writer = new StreamWriter(saveFileDialog.FileName))
                    {
                        foreach (var item in listBoxTasks.Items)
                        {
                            writer.WriteLine(item.ToString());
                        }
                    }
                    MessageBox.Show("TODO list saved successfully.", "Save Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while saving the TODO list: {ex.Message}", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveTodoList();
            Application.Exit();
        }

        private void LoadTodoList()
        {
            if (File.Exists(todoFilePath))
            {
                string[] tasks = File.ReadAllLines(todoFilePath);
                listBoxTasks.Items.AddRange(tasks);
            }
        }

        private void SaveTodoList()
        {
            using (StreamWriter writer = new StreamWriter(todoFilePath))
            {
                foreach (var item in listBoxTasks.Items)
                {
                    writer.WriteLine(item.ToString());
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveTodoList();
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
                            System.Diagnostics.Process.Start("https://drive.google.com/drive/folders/1-P9d9NE6xQNCizT-WmaMRVkyupDyNEwf?usp=sharing");
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
            latestVersion = latestVersion.Trim();
            Version localVersion = new Version(currentVersion);
            Version onlineVersion = new Version(latestVersion);

            return onlineVersion > localVersion;
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Application Version: {Application.ProductVersion}", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
