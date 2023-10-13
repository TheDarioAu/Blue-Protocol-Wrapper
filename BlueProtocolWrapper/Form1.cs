using System;
using System.Windows.Forms;
using System.Net.Http;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace BlueProtocolWrapper
{
    public partial class Form1 : Form
    {
        private Process? gameProcess;
        private const string japanLocationCode = "\"country\": \"JP\"";

        public Form1()
        {
            InitializeComponent();
        }

        private async Task CheckLocation()
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync("https://ipinfo.io");
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();

                    if (responseBody.Contains(japanLocationCode))
                    {
                        DialogResult result = MessageBox.Show("Your location is in Japan. Do you want to open the game?", "Location Check", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            gameProcess = Process.Start(txtExecutablePath.Text);
                        }
                    } 
                    else
                    {
                        MessageBox.Show("You are not in Japan, please use a VPN or change locations!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while checking location: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private async void LoadedApp(object sender, EventArgs e)
        {
            this.Icon = new Icon("BlueProtocolWrapper.ico");
            if (System.IO.File.Exists("path.txt"))
            {
                string path = System.IO.File.ReadAllText("path.txt");
                txtExecutablePath.Text = path;
            }
            await CheckLocation();
        }
        private void ClosedApp(object sender, EventArgs e)
        {
            if (gameProcess != null)
            {
                gameProcess.Kill();
            }
        }
        private async void Confirm(object sender, EventArgs e)
        {
            await CheckLocation();
        }
        private void SavePath(object sender, EventArgs e)
        {
            string path = txtExecutablePath.Text;
            // Save the path to a configuration file or any preferred storage method
            // Example: Save it to a text file
            System.IO.File.WriteAllText("path.txt", path);
        }
        private void LoadPath(object sender, EventArgs e)
        {
            // Load the saved path from the configuration file or any preferred storage method
            // Example: Load it from a text file
            if (System.IO.File.Exists("path.txt"))
            {
                string path = System.IO.File.ReadAllText("path.txt");
                txtExecutablePath.Text = path;
            }
        }
    }
}