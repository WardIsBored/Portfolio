using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetworkTools
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string ExecuteCommandWithOutput(string command, string arguments)
        {
            try
            {
                var startInfo = new ProcessStartInfo
                {
                    FileName = command,
                    Arguments = arguments,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true
                };

                using (var process = Process.Start(startInfo))
                {
                    if (process != null)
                    {
                        // Read everything before waiting to exit
                        string output = process.StandardOutput.ReadToEnd();
                        string error = process.StandardError.ReadToEnd();
                        process.WaitForExit();

                        if (!string.IsNullOrEmpty(error))
                            output += "\nError: " + error;

                        return output;
                    }
                }
            }
            catch (Exception ex)
            {
                return "An error occurred: " + ex.Message;
            }

            return string.Empty;
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
                            TBConsole.Text += ("Output: " + output);
                        if (!string.IsNullOrEmpty(error))
                            TBConsole.ForeColor = Color.Red;
                        TBConsole.Text += ("Error: " + error);
                        TBLogs.Text += ("Executed command: " + command + " " + arguments + "\n");
                        TBConsole.ForeColor = Color.White;
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex.Message != null)
                {
                    TBConsole.Text += "An error occurred: " + ex.Message;
                }
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TBLogs_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Corrected the string escaping and quoting for the command arguments
            ExecuteCommand("cmd.exe", "/c start \"\" msedge \"https://github.com/WardIsBored/\" \n");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnPacketSniff_Click(object sender, EventArgs e)
        {
            ExecuteCommand("cmd.exe", "/c netstat -ano");
        }

        private void BtnIpSniff_Click(object sender, EventArgs e)
        {
            ExecuteCommand("cmd.exe", "/c arp -a");
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TBConsole.Text = string.Empty;
        }

        private void BtnConnections_Click(object sender, EventArgs e)
        {
            ExecuteCommand("cmd.exe", "/c netsh wlan show profiles");
        }

        private void BtnStatus_Click(object sender, EventArgs e)
        {
            try
            {
                TBLogs.AppendText("Retrieving network status...\r\n");
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
                TBConsole.Clear();
                TBConsole.AppendText("Network:\n");
                TBConsole.AppendText("------------\n");
                TBConsole.AppendText($"Name: {ssid}\n");
                TBConsole.AppendText($"Adapter: {desc}\n");
                TBConsole.AppendText($"State: {state}\n");
                TBConsole.AppendText($"Signal: {signal}\n\n");
                TBConsole.AppendText("Speed:\n");
                TBConsole.AppendText("------------\n");
                TBConsole.AppendText($"Ping: {avgPing}\n");
            }
            catch (Exception ex)
            {
                TBConsole.AppendText($"Error: {ex.Message}\n");
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


        private void BtnPasswords_Click(object sender, EventArgs e)
        {
            TBConsole.Clear();
            TBConsole.AppendText("🔐 Retrieving saved Wi‑Fi profiles and passwords:\r\n\r\n");

            string allProfilesOut = ExecuteCommandWithOutput("cmd.exe", "/c netsh wlan show profiles");
            var profiles = allProfilesOut
                .Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries)
                .Where(l => l.Contains("All User Profile"))
                .Select(line => line.Split(':')[1].Trim())
                .ToList();

            if (!profiles.Any())
            {
                TBConsole.AppendText("No Wi‑Fi profiles found.\r\n");
                return;
            }

            foreach (var profile in profiles)
            {
                TBConsole.AppendText($"— {profile} —\r\n");
                TBLogs.AppendText($"Retrieving password for profile: {profile}\r\n");
                string cmd = $"netsh wlan show profile name=\"{profile}\" key=clear";
                string output = ExecuteCommandWithOutput("cmd.exe", "/c " + cmd);

                string password = "N/A";
                foreach (var line in output.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    if (line.Trim().StartsWith("Key Content"))
                    {
                        var parts = line.Split(':');
                        if (parts.Length > 1)
                            password = parts[1].Trim();
                        break;
                    }
                }

                TBConsole.AppendText($"Password: {password}\r\n\r\n");
            }
        }

        private void BtnClear2_Click(object sender, EventArgs e)
        {
            TBLogs.Text = string.Empty;
        }
    }
}
