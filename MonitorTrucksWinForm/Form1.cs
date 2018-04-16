using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using WindowsFormsAppTest.Database;
using WindowsFormsAppTest.Model;

namespace WindowsFormsAppTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Open form 1");

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {

            String username = txtUserName.Text;
            String password = txtPassword.Text;

            if (String.IsNullOrEmpty(username) && String.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter your username and passowrd.", "Message");
            }
            else if (String.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please enter your username.", "Message");

            }
            else if (String.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter your passowrd.", "Message");
            }
            else
            {
                MongoDBConnection mongoDBConnection = MongoDBConnection.getMongoConnection;
                var connectionString = "mongodb://danangxp:danang123@ds143099.mlab.com:43099/truckmonitoring";
                var mongoClient = mongoDBConnection.getMongoClient(connectionString);
                var database = mongoClient.GetDatabase("truckmonitoring");
                
                User loginUser = new User();
                loginUser = loginUser.findUserByName(username, database);
                if (null != loginUser)
                {
                    if (loginUser.passWord.Equals(loginUser.getMD5(password)))
                    {
                        Console.WriteLine(loginUser.userName);
                        this.Hide();
                        var form = new Form2();
                        form.Show();
                    }
                    else
                    {
                        MessageBox.Show("Your password is incorrect. Please try again.", "Message");
                        txtPassword.Clear();
                        var collection = database.GetCollection<User>("users");
                    }
                }
                else { MessageBox.Show("Your username is incorrect. Please try again.", "Message");
                    txtUserName.Clear();
                    txtPassword.Clear();
                };
            }

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void groupLogin_Enter(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();

        }
    }
}
