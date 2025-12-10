
/*
 * Anthony Spano
 * CS3020
 * Fall 2025
 * Class for the main form of the todo app.
 */
using System.Diagnostics;
using System.IO;
using System.Text.Json;

namespace CS3020
{
    public partial class Form1 : Form
    {
        string path = "C:\\Users\\adspa\\Documents\\TodoData.json";

        public Form1()
        {
            InitializeComponent();

            // load json data
            if(File.Exists(path))
            {
                Debug.WriteLine("JSON FILE SUCCESSFULLY LOADED!");
                string jsonString = File.ReadAllText(path);

                List<string> data = JsonSerializer.Deserialize<List<string>>(jsonString);

                // data is loaded, need to create tasks in app that show!
                foreach (string d in data)
                {
                    // create entry
                    if (!string.IsNullOrWhiteSpace(d))
                    {
                        // Add task to Checked List Box
                        clbTasks.Items.Add(d, false);

                        // Add task to custom list
                        tasks.Add(d);
                    }
                }

            }

        }

        public void JSONWrite()
        {
            // create/write file 
            var options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(clbTasks.Items, options);
            File.WriteAllText(path, json);

        }

        List<String> tasks = new List<string>();

        // button click callback
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Don't run anything if textbox is not empty
            if (!string.IsNullOrWhiteSpace(txtNewTask.Text))
            {
                // Add task to Checked List Box
                clbTasks.Items.Add(txtNewTask.Text, false);

                // Add task to custom list
                tasks.Add(txtNewTask.Text);

                // Add task to JSON
                JSONWrite();

                // Clear textbox
                txtNewTask.Clear();

                // Set focus back to textbox
                txtNewTask.Focus();
            }
            else
            {
                MessageBox.Show("Please enter a task.", "Empty Task",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        // Allow pressing Enter in textbox to add a task
        private void txtNewTask_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnAdd_Click(sender, e);
                e.Handled = true; // Prevents the "ding" sound
            }
        }



        // Remove checked items from the list
        private void btnRemove_Click_1(object sender, EventArgs e)
        {
            // Iterate backwards to avoid index issues
            for (int i = clbTasks.Items.Count - 1; i >= 0; i--)
            {
                if (clbTasks.GetItemChecked(i))
                {
                    clbTasks.Items.RemoveAt(i);

                    // write to json reflecting current changes
                    JSONWrite();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
