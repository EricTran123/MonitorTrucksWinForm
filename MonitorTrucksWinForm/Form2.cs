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

namespace WindowsFormsAppTest
{
    public partial class Form2 : Form
    {
        public string username { get; set; }
        public string password { get; set; }

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(string username, string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Open form 2");
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

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
        public void displayDataTableUser()
        {
            User userData = new User();
            DataTable dataTable = new DataTable();
            dataTable = userData.getListAllUsers()
        }
    }
}
