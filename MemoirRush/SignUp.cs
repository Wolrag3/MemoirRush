using Newtonsoft.Json;
using System;
using System.IO;
using System.Windows.Forms;

namespace MemoirRush
{
    public class User
    {
        public string username { get; set; }
        public string password { get; set; }
        public string email { get; set; }
    }

    public partial class SignUp : Form
    {
        private string jsonfile;

        public SignUp(string jsonfile)
        {
            InitializeComponent();
            // JSON file path passed from the Login form
            this.jsonfile = jsonfile;
        }

        private void serialization()
        {
            User user = new User
            {
                username = _nameTextboxsignup.Text,
                password = _passwordTextboxsignup.Text,
                email = _emailTextboxsignup.Text
            };

            try
            {
                // Serialize the User object to JSON format
                string jsonserialize = JsonConvert.SerializeObject(user, Formatting.Indented);

                // Write the serialized JSON to the file (overwriting the existing content)
                File.WriteAllText(jsonfile, jsonserialize);

                MessageBox.Show("User saved successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving user: " + ex.Message);
            }
        }

        private void _SignupButton_Click(object sender, EventArgs e)
        {
            serialization();
            this.Hide();
            Login form = new Login();
            form.Show();
        }

        // Other event handlers for text changes and button clicks
        private void _nameTextboxsignup_TextChanged(object sender, EventArgs e)
        {
            // Logic for handling text changes (if needed)
        }

        private void _nameTextboxsignup_TextChanged_1(object sender, EventArgs e)
        {
            // Logic for handling text changes (if needed)
        }

        private void Login_page_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
    }
}
