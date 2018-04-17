using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppTest.Model;
using MongoDB.Driver;
using WindowsFormsAppTest.Database;

namespace WindowsFormsAppTest
{
    public partial class Form2 : Form
    {
       

        public Form2()
        {
            InitializeComponent();
            Console.WriteLine(dataGridViewUser.ColumnCount);
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Open form 2");
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            // this.displayDataTableUser(dataGridViewUser);
            Console.WriteLine(dataGridViewUser.ColumnCount);

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void displayDataTableUser(DataGridView dataGridView)
        {
            User userData = new User();
            DataTable dataTable = new DataTable();
            MongoDBConnection mongoDBConnection = MongoDBConnection.getMongoConnection;
            List<User> listUsers = userData.getListAllUsers(mongoDBConnection.getMongoData());
 
            for (int i = 1; i < listUsers.Count() + 1; i++)
            {
                
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
