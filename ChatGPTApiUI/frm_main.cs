using OpenAI.Chat;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace ChatGPTApiUI {

    public partial class frm_main : Form {

        public frm_main() {
            InitializeComponent();
        }

        private void btn_prompt_send_Click(object sender, System.EventArgs e) {
            var path = Path.Combine("AppData", "apikey.json");
            if(!File.Exists(path)) {
                MessageBox.Show("API Key file not found. Please set your API Key first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string json = File.ReadAllText(path);
            var doc = JsonDocument.Parse(json);
            var apikey = doc.RootElement.GetProperty("ApiKey").GetString();

            ChatClient client = new ChatClient(
            model: "gpt-3.5-turbo",
            apiKey: apikey);

            if(rchtxtbox_prompt.Text.Length == 0) {
                MessageBox.Show("Please enter a prompt before sending.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ChatCompletion completion = client.CompleteChat(rchtxtbox_prompt.Text);

            rchtxtbox_response.Text = completion.Content[0].Text;
        }
    }
}