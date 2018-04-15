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
            String userName = txtUserName.Text;
            String passWord = txtPassword.Text;

            if (String.IsNullOrEmpty(userName) && String.IsNullOrEmpty(passWord))
            {
                MessageBox.Show("Please enter your username and passowrd.", "Message");
            }
            else if (String.IsNullOrEmpty(userName))
            {
                MessageBox.Show("Please enter your username.", "Message");
            }
            else if (String.IsNullOrEmpty(passWord))
            {
                MessageBox.Show("Please enter your passowrd.", "Message");
            }
            else
            {
                MongoDBConnection mongoDBConnection = MongoDBConnection.getMongoConnection;
                var connectionString = "mongodb://danangxp:danang123@ds143099.mlab.com:43099/truckmonitoring";
                var mongoClient = mongoDBConnection.getMongoClient(connectionString);
                var database = mongoClient.GetDatabase("truckmonitoring");
                var collection = database.GetCollection<User>("users");
                User loginUser = new User();
                loginUser.username = userName;
                loginUser.password = passWord;
                //  var dbUser =  collection.Find(user => user.username, loginUser.username);
                Console.WriteLine(loginUser.username);
                var list = collection.Find(x => x.username == loginUser.username).FirstOrDefault();
                Console.WriteLine(list.createDate);

                Console.WriteLine("THANHF CONF");
                this.Hide();
                var form = new Form2();
                form.Show();

            }
            //MongoDBConnection mongoDBConnection = MongoDBConnection.getMongoConnection;
            //var connectionString = "mongodb://danangxp:danang123@ds143099.mlab.com:43099/truckmonitoring";
            //var mongoClient = mongoDBConnection.getMongoClient(connectionString);
            //var database = mongoClient.GetDatabase("truckmonitoring");
            //User user = new User()
            //{
            //    userName = "QA",
            //    password = "123456",
            //    createDate = DateTime.UtcNow.ToString("yyyyMMdd-HHMMss"),
               
            //};
            //user.password = user.getMD5("123456");
            //var collection = database.GetCollection<User>("users");
            //collection.InsertOne(user);
            //Console.WriteLine(database);
            
            //if (txtUserName.Text.Equals("QA") && txtPassword.Text.Equals("123456"))
            //{
            //    Console.WriteLine("THANHF CONF");
            //    this.Hide();
            //    var form = new Form2();
            //    form.Show();
               
            //} else if (txtUserName.Text.Equals("") && txtPassword.Text.Equals("")){
            //    MessageBox.Show("Please enter your username and passowrd","Message");
            //} else if (txtUserName.Text.Equals("")) {

            //} else if (txtPassword.Text.Equals("")){

            //}
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
