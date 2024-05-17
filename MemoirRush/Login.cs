using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO; // Added for File.Exists and File.ReadAllText
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
                string jsonString = File.ReadAllText(jsonfile);
                try
                {
                    JObject jsonObject = JObject.Parse(jsonString);
                    JArray names = (JArray)jsonObject["names"];

                    bool found = false;

                    foreach (JObject name in names.Children<JObject>())
                    {
                        if ((string)name["name"] == _usernameTextbox.Text)
                        {
                            found = true;
                            Todo logged_In = new Todo();
                            this.Hide();
                            logged_In.Show();
                        }
                    }

                    if (!found)
                    {
                        MessageBox.Show("User Not Found!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
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
