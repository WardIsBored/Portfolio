using Newtonsoft.Json;
using System.Net.Http;


namespace Discord_Messager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ChangeMode()
        {
            TxtMode.Text = $"Mode: {TxtMode.Tag}";
            TxtbConsole.Text += $"Changed mode to: {TxtMode.Tag} \n";
            if (TxtMode.Tag.ToString() == "SendMsg")
            {
                TxtPrimary.Text = "Message to send:";
                TxtSecondary.Text = "Webhook ID:";
            }
            if (TxtMode.Tag.ToString() == "Nuke")
            {
                TxtPrimary.Text = "Message to send:";
                TxtSecondary.Text = "Webhook ID:";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            TxtMode.Tag = "SendMsg";
            ChangeMode();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            if (TxtMode.Tag.ToString() == "SendMsg")
            {
                string webhookId = TxtbSecondary.Text;
                string message = TxtbPrimary.Text;
                SendMessage(webhookId, message);
                TxtbConsole.Text += $"Message sent: {message} to Webhook ID: {webhookId} \n";
            }
            else
            {
                if (TxtMode.Tag.ToString() == "Nuke")
                {
                    string webhookId = TxtbSecondary.Text;
                    string message = TxtbPrimary.Text;
                    while (true) // Infinite loop for Nuke mode
                    {
                        try
                        {
                            SendMessage(webhookId, message);
                            TxtbConsole.Text += $"Message sent: {message} to Webhook ID: {webhookId} \n";
                            timer1.Start(); // Wait for 1 second before sending the next message
                        }
                        catch (Exception ex)
                        {
                            TxtbConsole.Text += $"Error sending message: {ex.Message}\n";
                            break; // Exit loop on error
                        }
                    }
                }
                else
                    TxtbConsole.Text += "Unknown mode selected. \n";
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtbConsole.Text = string.Empty;
        }
        private void SendMessage(string webhookId, string message)
        {
            using (var client = new HttpClient())
            {
                var payload = new { content = message };
                var jsonPayload = JsonConvert.SerializeObject(payload);
                var content = new StringContent(jsonPayload, System.Text.Encoding.UTF8, "application/json");
                var response = client.PostAsync($"{webhookId}", content).Result;

                if (response.IsSuccessStatusCode)
                {
                    TxtbConsole.Text += $"Message sent successfully to {webhookId}.\n";
                }
                else
                {
                    TxtbConsole.Text += $"Failed to send message. Status code: {response.StatusCode}\n";
                }
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            TxtMode.Tag = "Nuke";
            ChangeMode();
        }
    }
}
