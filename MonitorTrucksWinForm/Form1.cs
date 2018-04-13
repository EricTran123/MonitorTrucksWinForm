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
using MongoDB.Bson;
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

            var mongoClient = new MongoClient("mongodb://danangxp:danang123@ds143099.mlab.com:43099/truckmonitoring");
            var database = mongoClient.GetDatabase("truckmonitoring");
            Customer customer = new Customer
            {
                name = "Quy Tran",
                address = "Da Nang",
                createDate = DateTime.UtcNow.ToString("yyyyMMdd-HHMMss"),
                phoneNumber = "+84902746644",
                active = true
            };
            var collection = database.GetCollection<Customer>("customers");
            collection.InsertOne(customer);
            Console.WriteLine(database);
            
            if (txtUserName.Text.Equals("QA") && txtPassword.Text.Equals("123456"))
            {
                Console.WriteLine("THANHF CONF");
                this.Hide();
                var form = new Form2();
                form.Show();
               
            } else if (txtUserName.Text.Equals("") && txtPassword.Text.Equals("")){
                MessageBox.Show("Please enter your username and passowrd","Message");
            } else if (txtUserName.Text.Equals("")) {

            } else if (txtPassword.Text.Equals("")){

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
