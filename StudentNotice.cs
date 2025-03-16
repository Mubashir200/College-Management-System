using System;
using System.Windows.Forms;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace CollageManagementSystem
{
    public partial class StudentNotice : Form
    {
        public StudentNotice()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                // Twilio Credentials
                string accountSid = "ACd970ff18b3a4704dd759762b3710306d";
                string authToken = "c4af609c7c52cfa7903c8d3550bbe027";
                string fromNumber = "whatsapp:+14155238886"; // Twilio Sandbox Number

                // Get recipient number & message from text boxes
                string recipientNumber = txtPhoneNumber.Text.Trim();
                string messageText = txtMessage.Text.Trim();

                // Validate inputs
                if (string.IsNullOrEmpty(recipientNumber) || string.IsNullOrEmpty(messageText))
                {
                    MessageBox.Show("Please enter both recipient number and message.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Ensure recipient number has correct format
                if (!recipientNumber.StartsWith("+"))
                {
                    recipientNumber = "+91" + recipientNumber;  // Assuming Indian number (modify as needed)
                }

                string toNumber = "whatsapp:" + recipientNumber;

                // Initialize Twilio Client
                TwilioClient.Init(accountSid, authToken);

                // Send WhatsApp Message
                var message = MessageResource.Create(
                    body: messageText,
                    from: new PhoneNumber(fromNumber),
                    to: new PhoneNumber(toNumber)
                );

                MessageBox.Show("WhatsApp Notice Sent Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to send WhatsApp notice.\nError: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtMessage_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
