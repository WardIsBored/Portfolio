using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace EclipsusAurora
{

    public partial class EclipsusAurora : Form
    {

        public class GeoData
        {
            public string ip { get; set; }
            public string city { get; set; }
            public string region { get; set; }
            public string country { get; set; }
            public string loc { get; set; }
            public string timezone { get; set; }
        }
        public EclipsusAurora()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialize the label with a default value
            UpdateModeLabel();

        }

        public void ExecuteCommand(string command, string arguments)
        {
            try
            {

                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = command,
                    Arguments = arguments,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                using (Process process = Process.Start(startInfo))
                {
                    if (process != null)
                    {
                        string output = process.StandardOutput.ReadToEnd();
                        string error = process.StandardError.ReadToEnd();
                        process.WaitForExit();

                        if (!string.IsNullOrEmpty(output))
                            ConsoleOBJ.Text += ("Output: " + output);
                        if (!string.IsNullOrEmpty(error))
                            ConsoleOBJ.ForeColor = Color.Red;
                        ConsoleOBJ.Text += ("Error: " + error);
                        ConsoleOBJ.ForeColor = Color.White;
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex.Message != null)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
            }
        }


        private void UpdateModeLabel()
        {
            // Safely retrieve the Tag value and update the label
            Mode.Text = $"Current Mode: {Mode.Tag?.ToString() ?? "Unknown"}";

            // Fixing the CS0411 error by directly appending the text to ConsoleOBJ.Text
            ConsoleOBJ.Text += $"Mode set to: {Mode.Tag?.ToString() ?? "Unknown"}\n";
            if (Mode.Tag?.ToString() == "Geolocate")
            {
                PrimaryLabel.Text = "Put an IP here!";
                SecondaryLabel.Text = "No Action Needed!";
            }
            else if (Mode.Tag?.ToString() == "Ip Sniff")
            {
                PrimaryLabel.Text = "1) Arp-a 2) Netstat";
                SecondaryLabel.Text = "No Action Needed!";
            }
            else if (Mode.Tag?.ToString() == "DNS Dump")
            {
                PrimaryLabel.Text = "Put a Domain Name here!";
                SecondaryLabel.Text = "No Action Needed!";
            }
            else if (Mode.Tag?.ToString() == "Scan Open Ports")
            {
                PrimaryLabel.Text = "Put an IP or Domain Name here!";
                SecondaryLabel.Text = "Put Ports Here!!";
            }
            else if (Mode.Tag?.ToString() == "Wifi Passwords")
            {
                PrimaryLabel.Text = "No Action Needed!";
                SecondaryLabel.Text = "No Action Needed!";
            }
            else if (Mode.Tag?.ToString() == "Pinger")
            {
                PrimaryLabel.Text = "Put an ip!";
                SecondaryLabel.Text = "No Action Needed!";
            }
            else
            {
                PrimaryLabel.Text = "No Action Needed!";
                SecondaryLabel.Text = "No Action Needed!";
            }
        }


        private async Task Geolocate()
        {

            string ip = Primary.Text;
            ConsoleOBJ.Text += $"Attempting to geolocate IP: {ip}\n";
            try
            {


                string url = $"https://ipinfo.io/{ip}/json";
                HttpResponseMessage response = await new HttpClient().GetAsync(url);
                string responseData = await response.Content.ReadAsStringAsync();
                Primary.Text = string.Empty;
                Seconday.Text = string.Empty;
                GeoData ipInfo = JsonConvert.DeserializeObject<GeoData>(responseData);
                ConsoleOBJ.Text = string.Empty;
                ConsoleOBJ.Text += $"IP: {ipInfo.ip}\n";
                ConsoleOBJ.Text += $"City: {ipInfo.city}\n";
                ConsoleOBJ.Text += $"Region: {ipInfo.region}\n";
                ConsoleOBJ.Text += $"Country: {ipInfo.country}\n";
                ConsoleOBJ.Text += $"Location: {ipInfo.loc}\n";
                ConsoleOBJ.Text += $"Timezone: {ipInfo.timezone}\n";
            }
            catch
            {

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void Geo_Click(object sender, EventArgs e)
        {
            if (Mode.Tag?.ToString() == "Geolocate")
            {
                return;
            }
            else
            {
                Mode.Tag = "Geolocate";
            }
            UpdateModeLabel();
            showerthing.Height = Geo.Height;
            showerthing.Top = Geo.Top;
            showerthing.Left = Geo.Left;
        }

        private void Ip_Click(object sender, EventArgs e)
        {
            if (Mode.Tag?.ToString() == "Ip Sniff")
            {
                return;
            }
            else
            {
                Mode.Tag = "Ip Sniff";
            }
            UpdateModeLabel();
            showerthing.Height = Ip.Height;
            showerthing.Top = Ip.Top;
            showerthing.Left = Ip.Left;
        }

        private void DNS_Click(object sender, EventArgs e)
        {
            if (Mode.Tag?.ToString() == "DNS Dump")
            {
                return;
            }
            else
            {
                Mode.Tag = "DNS Dump";
            }
            UpdateModeLabel();
            showerthing.Height = DNS.Height;
            showerthing.Top = DNS.Top;
            showerthing.Left = DNS.Left;
        }

        private void Ports_Click(object sender, EventArgs e)
        {
            if (Mode.Tag?.ToString() == "Scan Open Ports")
            {
                return;
            }
            else
            {
                Mode.Tag = "Scan Open Ports";
            }
            UpdateModeLabel();
            showerthing.Height = Ports.Height;
            showerthing.Top = Ports.Top;
            showerthing.Left = Ports.Left;
        }

        private void ClearConsole_Click(object sender, EventArgs e)
        {
            ConsoleOBJ.Text = string.Empty;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Primary_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private async void EnterOBJ_Click(object sender, EventArgs e)
        {
            if (Mode.Tag?.ToString() == "Geolocate")
            {
                await Geolocate();
            }
            else if (Mode.Tag?.ToString() == "Ip Sniff")
            {
                if (Primary.Text == "1")
                {
                    ExecuteCommand("cmd.exe", "/c arp -a");
                }
                else
                {
                    ExecuteCommand("cmd.exe", "/c netstat -ano");
                }
            }
            else if (Mode.Tag?.ToString() == "DNS Dump")
            {
                ExecuteCommand("cmd.exe", $"/c nslookup {Primary.Text}");
            }
            if (Mode.Tag?.ToString() == "Scan Open Ports")
            {
                string target = Primary.Text;
                var ports = Seconday.Text
                    .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(p => int.TryParse(p, out var x) ? x : -1)
                    .Where(p => p > 0)
                    .ToList();

                if (!ports.Any())
                {
                    ConsoleOBJ.AppendText("No valid ports specified.\n");
                    return;
                }

                EnterOBJ.Enabled = false;
                await ScanPortsAsync(target, ports, 500);
                EnterOBJ.Enabled = true;
            }
            else if (Mode.Tag?.ToString() == "Pinger")
            {
                string ip = Primary.Text;
                if (string.IsNullOrWhiteSpace(ip))
                {
                    ConsoleOBJ.AppendText("Please enter a valid IP address.\n");
                    return;
                }
                ConsoleOBJ.Clear();
                ConsoleOBJ.AppendText($"Pinging {ip}...\n");
                try
                {
                    using (Ping ping = new Ping())
                    {
                        PingReply reply = await ping.SendPingAsync(ip, 1000);
                        if (reply.Status == IPStatus.Success)
                        {
                            ConsoleOBJ.AppendText($"Reply from {reply.Address}: bytes={reply.Buffer.Length} time={reply.RoundtripTime}ms TTL={reply.Options.Ttl}\n");
                        }
                        else
                        {
                            ConsoleOBJ.AppendText($"Ping failed: {reply.Status}\n");
                        }
                    }
                }
                catch (Exception ex)
                {
                    ConsoleOBJ.AppendText($"Error: {ex.Message}\n");
                }
            }
            else if (Mode.Tag?.ToString() == "Wifi Passwords")
            {
                ConsoleOBJ.Clear();
                ConsoleOBJ.AppendText("🔐 Retrieving saved Wi‑Fi profiles and passwords:\r\n\r\n");

                // Step 1: List all profiles
                string allProfilesOut = RunCommand("netsh", "wlan show profiles");
                var profiles = allProfilesOut
                    .Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries)
                    .Where(l => l.Contains("All User Profile"))
                    .Select(line => line.Split(':')[1].Trim())
                    .ToList();

                if (!profiles.Any())
                {
                    ConsoleOBJ.AppendText("No Wi‑Fi profiles found.\r\n");
                }
                else
                {
                    foreach (string ssid in profiles)
                    {
                        string detail = RunCommand("netsh", $"wlan show profile name=\"{ssid}\" key=clear");
                        string pwd = detail
                            .Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries)
                            .FirstOrDefault(l => l.Contains("Key Content"));
                        string password = pwd != null
                            ? pwd.Split(':')[1].Trim()
                            : "(no password shown)";

                        ConsoleOBJ.AppendText($"SSID: {ssid}    Password: {password}\r\n");
                    }

                }
            }

            else
            {
                return;
            }
        }


        // Fix for CS1061: Ensure the Progress class is properly instantiated and used
        private async Task ScanPortsAsync(string host, List<int> ports, int timeoutMs)
        {
            var progress = new Progress<(int Port, bool IsOpen)>(report =>
            {
                // runs on UI thread
                var (port, isOpen) = report;
                ConsoleOBJ.AppendText($"Port {port} is {(isOpen ? "OPEN" : "CLOSED")}\n");
            });

            await Task.Run(async () =>
            {
                foreach (int port in ports)
                {
                    bool open = await IsPortOpenAsync(host, port, timeoutMs);
                    ((IProgress<(int Port, bool IsOpen)>)progress).Report((port, open)); // Explicitly cast to IProgress to access Report
                }
            });
        }



        private void button5_Click(object sender, EventArgs e)
        {
            if (MoreSection.Tag == null || MoreSection.Tag.ToString() != "Enabled")
            {
                MoreSection.Tag = "Enabled";
                MoreSection.Show();
            }
            else
            {
                MoreSection.Tag = "Disabled";
                MoreSection.Hide();

            }
        }

        private void MyIp_Click(object sender, EventArgs e)
        {
            string url2 = "https://api.ipify.org?format=json";
            try
            {
                HttpClient client = new HttpClient();
                string response = client.GetStringAsync(url2).Result;


                // Fixing CS0029: ExecuteCommand does not return a value, so we cannot assign it to a string.
                ConsoleOBJ.Text = $"Public IP: {response}";
                ExecuteCommand("cmd.exe", "/c ipconfig | findstr /i \"IPv4\"\n");

            }
            catch (Exception ex)
            {
                ConsoleOBJ.Text = $"Error retrieving IP: {ex.Message}";
            }
            showerthing.Height = MyIp.Height;
            showerthing.Top = MyIp.Top;
            showerthing.Left = MyIp.Left;
        }

        private void RExecute_Click(object sender, EventArgs e)
        {
            ConsoleOBJ.Text = string.Empty;
            ConsoleOBJ.Text += "Please proceed to open a roblox client";

        }
        private async Task<bool> IsPortOpenAsync(string host, int port, int timeoutMs)
        {
            using (var tcpClient = new System.Net.Sockets.TcpClient())
            {
                try
                {
                    var connectTask = tcpClient.ConnectAsync(host, port);
                    var timeoutTask = Task.Delay(timeoutMs);

                    var completedTask = await Task.WhenAny(connectTask, timeoutTask);
                    if (completedTask == connectTask)
                    {
                        await connectTask; // Ensure any exceptions are observed
                        return tcpClient.Connected;
                    }
                    else
                    {
                        return false; // Timed out
                    }
                }
                catch
                {
                    return false; // Connection failed
                }
            }
        }

        private void ConsoleOBJ_TextChanged(object sender, EventArgs e)
        {

        }

        private void Geo_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Run ping and extract Average time
                string pingOutput = RunCommand("ping", "-n 3 8.8.8.8");
                string avgPing = ParsePingAverage(pingOutput);

                // 2. Run netsh wlan show interface once (we’ll parse all values from this)
                string wlanOutput = RunCommand("netsh", "wlan show interface");

                string ssid = ParseWlanOutput(wlanOutput, "SSID");
                string desc = ParseWlanOutput(wlanOutput, "Description");
                string state = ParseWlanOutput(wlanOutput, "State");
                string signal = ParseWlanOutput(wlanOutput, "Signal");

                // Display results
                ConsoleOBJ.Clear();
                ConsoleOBJ.AppendText("Network:\n");
                ConsoleOBJ.AppendText("------------\n");
                ConsoleOBJ.AppendText($"Name: {ssid}\n");
                ConsoleOBJ.AppendText($"Adapter: {desc}\n");
                ConsoleOBJ.AppendText($"State: {state}\n");
                ConsoleOBJ.AppendText($"Signal: {signal}\n\n");
                ConsoleOBJ.AppendText("Speed:\n");
                ConsoleOBJ.AppendText("------------\n");
                ConsoleOBJ.AppendText($"Ping: {avgPing}\n");
            }
            catch (Exception ex)
            {
                ConsoleOBJ.AppendText($"Error: {ex.Message}\n");
            }
        }

        private string RunCommand(string fileName, string arguments)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = fileName,
                Arguments = arguments,
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using (Process process = Process.Start(startInfo))
            {
                string output = process.StandardOutput.ReadToEnd();
                process.WaitForExit();
                return output;
            }
        }

        private string ParsePingAverage(string pingOutput)
        {
            // Example line: "    Minimum = 14ms, Maximum = 16ms, Average = 15ms"
            string line = pingOutput.Split('\n')
                .FirstOrDefault(l => l.Contains("Average"));

            if (line == null)
                return "N/A";

            // Find "Average = XXXms"
            int avgIndex = line.IndexOf("Average =");
            if (avgIndex < 0)
                return "N/A";

            string afterAvg = line.Substring(avgIndex + "Average =".Length).Trim();
            // afterAvg should be something like "15ms"

            return afterAvg;
        }

        private string ParseWlanOutput(string wlanOutput, string field)
        {
            // Split output lines, try to find line starting with field
            // For SSID, ignore "BSSID"
            var lines = wlanOutput.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string line in lines)
            {
                string trimmed = line.Trim();
                if (field == "SSID")
                {
                    // Exclude lines containing "BSSID"
                    if (trimmed.StartsWith("SSID", StringComparison.OrdinalIgnoreCase) && !trimmed.Contains("BSSID"))
                    {
                        // Example: SSID                   : MyNetwork
                        int colonIndex = trimmed.IndexOf(':');
                        if (colonIndex >= 0)
                        {
                            return trimmed.Substring(colonIndex + 1).Trim();
                        }
                    }
                }
                else
                {
                    if (trimmed.StartsWith(field, StringComparison.OrdinalIgnoreCase))
                    {
                        int colonIndex = trimmed.IndexOf(':');
                        if (colonIndex >= 0)
                        {
                            return trimmed.Substring(colonIndex + 1).Trim();
                        }
                    }
                }
            }

            return "N/A";
        }

        private void WifiPasswords_Click(object sender, EventArgs e)
        {
            Mode.Tag = "Wifi Passwords";
            UpdateModeLabel();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Mode.Tag = "Pinger";
            UpdateModeLabel();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            // Replace this line in button1_Click_2:
            // ConsoleOBJ.Text += new RandomNumberGenerator(20, 125);

            // With the following code to generate a random number between 20 and 125:
            Random rnd = new Random();
            int randomValue = rnd.Next(20, 126); // upper bound is exclusive

            ConsoleOBJ.Text += $"Port: {randomValue.ToString()} \n";
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

    }
}