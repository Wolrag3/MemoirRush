using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Windows.Forms;

namespace MemoirRush
{
    public partial class SignUp : Form
    {
        private string jsonfile;

        public SignUp(string jsonfile)
        {
            InitializeComponent();
            //JSON PASSED
            this.jsonfile = jsonfile;
        }

        //public void data_list()
        //{
        //  string name = _nameTextboxsignup.Text;
        //string email = _emailTextboxsignup.Text;
        //string password = _passwordTextboxsignup.Text;
        //}

        // SERIALIZATION -> ARRAY CREATED OF VARIABLES -> 1. CREATE A DICTIONARY USE KEYS AND VALUES

        /*
        
         
        public void json_serialization()
        {
        KeysAndValues{strings,strings} = 
        }

        */

        /*
        public void userinputs()
        {
            string Name = string.Empty;
            string Email = string.Empty;
            string Password = string.Empty;

            List<string> userinputs = new List<string>();
            List<string> Values = new List<string>();


            userinputs = [_nameTextboxsignup.Text,_emailTextboxsignup.Text,_passwordTextboxsignup.Text];
            Values = [Name, Email, Password];

            Dictionary<List<string>,List<string>> keyValuePairs = new Dictionary<List<string>,List<string>>();

            keyValuePairs.Add(Values, userinputs);

            JObject jsonObject = new JObject();
            JArray userins = new JArray();

            string json = JsonConvert.SerializeObject(keyValuePairs);
            File.WriteAllText(jsonfile, json);
        }

        */

        public void json_serialization()
        {
            string[] stringsToWrite = new[] {
        _nameTextboxsignup.Text,
        _emailTextboxsignup.Text,
        _passwordTextboxsignup.Text
    };

            JObject jsonObject = new JObject();
            JArray names = new JArray();
            foreach (string s in stringsToWrite)
            {
                JObject nameObject = new JObject();
                nameObject["name"] = s;
                names.Add(nameObject);
            }
            jsonObject.Add("names", names);

            string jsonString = JsonConvert.SerializeObject(jsonObject, Formatting.Indented);
            File.WriteAllText(jsonfile, jsonString);
            MessageBox.Show("Data saved successfully.");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>



        private void _SignupButton_Click(object sender, EventArgs e)
        {
            json_serialization();
            this.Hide();
            Login form = new Login();
            form.Show();
        }

        private void _nameTextboxsignup_TextChanged(object sender, EventArgs e)
        {

        }

        private void _nameTextboxsignup_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Login_page_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
    }
}
