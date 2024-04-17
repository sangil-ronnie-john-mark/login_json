using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
namespace JSON
{
    public partial class Form1 : Form
    {
        public string file_name = "user.json";
        List<dynamic> userData = new List<dynamic>();
        
        public Form1()
        {
            InitializeComponent();
       
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            var credentials = new
            {
                username = txtUsername.Text,
                password = txtPassword.Text,
            };

     
            userData.Add(credentials);
            var json = JsonConvert.SerializeObject(userData);
            File.WriteAllText(file_name, json);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            var jsons = File.ReadAllText(file_name);
            userData = JsonConvert.DeserializeObject<List<dynamic>>(jsons);

            foreach (var credentials in userData)
            {
                string username = credentials["username"];
                string password = credentials["password"];

                if (txtUsername.Text == username && txtPassword.Text == password)
                {
                    MessageBox.Show("Login!");
                    return;
                } else
                {
                   
                }
              
            }
            MessageBox.Show("Invalid Username or Password");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var jsons = File.ReadAllText(file_name);
            userData = JsonConvert.DeserializeObject<List<dynamic>>(jsons);

            dgvData.DataSource = userData;
        }
    }
}
