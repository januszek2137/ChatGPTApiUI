using System;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace ChatGPTApiUI {

    public partial class frm_apikey : Form {

        public frm_apikey() {
            InitializeComponent();
        }

        private bool validateApiKey(string key, out string errorMessage) {
            if(string.IsNullOrWhiteSpace(key)) {
                errorMessage = "API Key cannot be empty.";
                return false;
            }

            if(key.Length < 100 || key.Length > 200) {
                errorMessage = "API Key must be between 100 and 200 characters long.";
                return false;
            }

            if(!System.Text.RegularExpressions.Regex.IsMatch(key, @"^[A-Za-z0-9\-_]+$")) {
                errorMessage = "API Key contains invalid characters. Only alphanumeric, hyphen, and underscore are allowed.";
                return false;
            }

            errorMessage = null;
            return true;
        }

        private void btn_apikey_Click(object sender, EventArgs e) {
            string apiKeyText = txtbox_apikey.Text;

            if(!validateApiKey(apiKeyText, out string errorMessage)) {
                txtbox_apikey.Clear();
                MessageBox.Show($"Invalid API Key. {errorMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var apiKeyData = new { ApiKey = apiKeyText };
            string json = JsonSerializer.Serialize(apiKeyData, new JsonSerializerOptions { WriteIndented = true });

            string appDataDir = "AppData";
            string filePath = Path.Combine(appDataDir, "apikey.json");

            try {
                Directory.CreateDirectory(appDataDir);
                File.WriteAllText(filePath, json);
                MessageBox.Show("API Key saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch(Exception ex) {
                MessageBox.Show($"Error saving API Key: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } finally {
                txtbox_apikey.Clear();
                this.Hide();
                using(var frm_main = new frm_main()) {
                    frm_main.ShowDialog();
                }
                this.Close();
            }
        }
    }
}