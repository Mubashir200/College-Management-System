using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;
using Newtonsoft.Json.Linq;
using System.Linq;

namespace CollageManagementSystem
{

    public partial class ChatBot : Form
    {
        private bool isDarkMode = false; // Track the theme state

        public ChatBot()
        {
            InitializeComponent();
            txtChatOutput.ReadOnly = true;  // Prevent manual editing
            txtChatOutput.Multiline = true; // Enable multiple lines

            // Attach the KeyDown event to detect Enter key
            txtUserInput.KeyDown += TxtUserInput_KeyDown;

            // Add Theme Toggle Button
            Button btnToggleTheme = new Button
            {
                Text = "Toggle Theme",
                Location = new Point(10, 10), // Adjust position as needed
                AutoSize = true
            };
            btnToggleTheme.Click += BtnToggleTheme_Click;
            this.Controls.Add(btnToggleTheme);
        }

        private void TxtUserInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Prevents the "ding" sound when pressing Enter
                btnSend_Click(sender, e); // Trigger send button click
            }
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            string userInput = txtUserInput.Text.Trim();
            if (string.IsNullOrEmpty(userInput))
            {
                MessageBox.Show("Please enter a message.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            AppendMessage("You", userInput, true);
            txtUserInput.Clear();

            // Predefined responses for specific questions
            string lowerInput = userInput.ToLower();

            if (lowerInput.Contains("who created you") || lowerInput.Contains("your creator") || lowerInput.Contains("who made you"))
            {
                AppendMessage("Bot", "Mohammed Mubashir created me!", false);
                return;
            }
           if (lowerInput.Contains("who is sahin") || lowerInput.Contains("sahin") || lowerInput.Contains("sahin kilu"))
            {
                 AppendMessage("Bot", "Sahin is the most beautiful girl and special for Mubashir!", false);
                 return;
            }

            // Show "Bot is thinking..."
            string thinkingText = "thinking...";
            int thinkingIndex = AppendMessage("Bot", thinkingText, false);

            await Task.Delay(15); // Simulate thinking delay

            // Fetch response from AI
            string botResponse = await Task.Run(() => GetChatbotResponse(userInput));

            // Remove "thinking..." before adding actual response
            RemoveMessageAt(thinkingIndex);

            // Append actual response
            AppendMessage("Bot", botResponse, false);
        }

        private bool IsAskingWhoCreatedBot(string input)
        {
            string[] variations = {
                "who created you", "who made you", "who is your creator", "who built you",
                "who designed you", "who developed you", "who invented you", "who coded you",
                "who programmed you", "who is behind your creation", "who’s your maker",
                "who’s the mastermind behind you", "who gave you life","Mubashir","Mubashir created you",
                "who is mubashir"
            };

            return variations.Any(variation => input.ToLower().Contains(variation));
        }


        private string GetChatbotResponse(string prompt)
        {
            var client = new RestClient();
            var request = new RestRequest("http://localhost:11434/api/generate", Method.Post);

            request.AddHeader("Content-Type", "application/json");

            var requestBody = new
            {
                model = "mistral",
                prompt = prompt,
                stream = false
            };

            request.AddJsonBody(requestBody);
            var response = client.Execute(request);

            if (response.IsSuccessful)
            {
                JObject jsonResponse = JObject.Parse(response.Content);
                return jsonResponse["response"]?.ToString().Trim() ?? "Sorry, I couldn't process that request.";
            }
            else
            {
                return "Error: Unable to connect to Ollama.";
            }
        }

        private int AppendMessage(string sender, string message, bool isUser)
        {
            int startIndex = txtChatOutput.TextLength;
            txtChatOutput.SelectionStart = txtChatOutput.TextLength;
            txtChatOutput.SelectionLength = 0;

            txtChatOutput.SelectionColor = isUser ? Color.Blue : Color.Green;

            txtChatOutput.AppendText($"{sender}: {message}\n");

            txtChatOutput.SelectionColor = txtChatOutput.ForeColor;
            txtChatOutput.ScrollToCaret();

            return startIndex; // Return the index to track message position
        }

        private void RemoveMessageAt(int index)
        {
            if (index >= 0 && index < txtChatOutput.TextLength)
            {
                txtChatOutput.Text = txtChatOutput.Text.Remove(index);
            }
        }

        private void txtChatOutput_TextChanged(object sender, EventArgs e)
        {
            txtChatOutput.ScrollToCaret();
        }

        private void BtnToggleTheme_Click(object sender, EventArgs e)
        {
            isDarkMode = !isDarkMode; // Toggle the theme

            if (isDarkMode)
            {
                this.BackColor = Color.FromArgb(30, 30, 30); // Dark Gray
                txtChatOutput.BackColor = Color.FromArgb(45, 45, 45);
                txtChatOutput.ForeColor = Color.White;
                txtUserInput.BackColor = Color.FromArgb(45, 45, 45);
                txtUserInput.ForeColor = Color.White;
            }
            else
            {
                this.BackColor = Color.White;
                txtChatOutput.BackColor = Color.White;
                txtChatOutput.ForeColor = Color.Black;
                txtUserInput.BackColor = Color.White;
                txtUserInput.ForeColor = Color.Black;
            }
        }
    }
}