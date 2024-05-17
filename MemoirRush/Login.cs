using Newtonsoft.Json;
using System;
using System.IO; // For File.Exists and File.ReadAllText
using System.Windows.Forms;

namespace MemoirRush
{
    public partial class Login : Form
    {
        private string jsonfile = "Dat.json";

        public Login()
        {
            InitializeComponent();
        }

        private void _loginButton_Click(object sender, EventArgs e)
        {
            if (File.Exists(jsonfile))
            {
                bool user_found = false;
                bool pass_found = false;

                // Read JSON file content
                var User_json = File.ReadAllText(jsonfile);
                string username = _usernameTextbox.Text;
                string password = _passwordTextbox.Text;

                // Deserialize JSON content to User object
                User user = JsonConvert.DeserializeObject<User>(User_json);

                // Check if the entered username matches the one in the User object
                if (user.username == username)
                {
                    user_found = true;
                }

                // Check if the entered password matches the one in the User object
                if (user.password == password)
                {
                    pass_found = true;
                }

                // If both username and password are correct, navigate to the Todo form
                if (user_found && pass_found)
                {
                    this.Hide();
                    Todo todo = new Todo();
                    todo.Show();
                }
                else
                {
                    MessageBox.Show("Login failed");
                }
            }
            else
            {
                MessageBox.Show("Data file not found!");
            }
        }

        private void _SignUP_button_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp(jsonfile);
            this.Hide();
            signUp.Show();
        }
    }
}
