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
        public String idSelectCustomer;
        public Form2()
        {
            InitializeComponent();
            Console.WriteLine(dataGridViewUser.ColumnCount);
           this.displayDataTableUser(dataGridViewUser);
           this.displayDataTableCustomer(dataGridViewCustomer);
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Open form 2");
        }
        private void userPage_Click(object sender, EventArgs e)
        {
            this.displayDataTableUser(dataGridViewUser);
        }

        private void customerPage_Click(object sender, EventArgs e)
        {
            this.displayDataTableCustomer(dataGridViewCustomer);
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
        
        public void displayDataTableUser(DataGridView dataGridView)
        {
            User userData = new User();
            MongoDBConnection mongoDBConnection = MongoDBConnection.getMongoConnection;
            List<User> listUsers = userData.getListAllUsers(mongoDBConnection.getMongoData());
            dataGridView.Rows.Clear();
            dataGridView.Refresh();
            for (int i = 0; i < listUsers.Count; i++)
            {
               dataGridView.Rows.Add(new object[] { i + 1, listUsers[i].userName, listUsers[i].passWord, listUsers[i].createDate.ToLocalTime(), listUsers[i].active });
            }
        }
        public void displayDataTableCustomer (DataGridView dataGridView)
        {
            Customer customerData = new Customer();
            MongoDBConnection mongoDBConnection = MongoDBConnection.getMongoConnection;
            List<Customer> listCustomers = customerData.getAllCustomers(mongoDBConnection.getMongoData());
            dataGridViewCustomer.Rows.Clear();
            dataGridViewCustomer.Refresh();
            for (int i = 0; i <listCustomers.Count; i++)
            {
                dataGridViewCustomer.Rows.Add(new object[] { i + 1, listCustomers[i].name, listCustomers[i].phoneNumber, listCustomers[i].address,
                listCustomers[i].createDate.ToLocalTime(), listCustomers[i].modifyDate.ToLocalTime(), listCustomers[i].isActive, listCustomers[i]._id });
            }
            Console.WriteLine(dataGridViewCustomer.ColumnCount);
        }

        private void dataGridViewUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                var girdUser = dataGridViewUser.Rows[e.RowIndex];
                txtUserName.Text = girdUser.Cells[1].Value.ToString();
                txtPassword.Text = girdUser.Cells[2].Value.ToString();
                ckcActive.Checked = Convert.ToBoolean(girdUser.Cells[4].Value.ToString());
                txtUserName.Enabled = false;
            }
        }
        private void dataGridViewCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var gridCustomer = dataGridViewCustomer.Rows[e.RowIndex];
                txtName.Text = gridCustomer.Cells[1].Value.ToString();
                txtPhoneNumber.Text = gridCustomer.Cells[2].Value.ToString();
                txtAddress.Text = gridCustomer.Cells[3].Value.ToString();
                ckcActiveCustomer.Checked = Convert.ToBoolean(gridCustomer.Cells[6].Value.ToString());
                idSelectCustomer = gridCustomer.Cells[7].Value.ToString();
                Console.WriteLine(idSelectCustomer);
            }
        }

   

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '\u25CF';
        }

        private void ckcActive_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtUserName.Text.Trim()))
            {

                DialogResult dr = MessageBox.Show("Do you want to update this user?", "Confirmed Message", MessageBoxButtons.YesNoCancel,
                  MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                {
                    MongoDBConnection mongoDBConnection = MongoDBConnection.getMongoConnection;
                    User deleteUser = new User();
                    try
                    {
                        deleteUser.deleteByUsername(mongoDBConnection.getMongoData(), txtUserName.Text.Trim());
                        MessageBox.Show("The user is deleted successfully.", "Message");
                        txtUserName.Clear();
                        txtPassword.Clear();
                        if (ckcActive.Checked)
                        {
                            ckcActive.Checked = false;
                        }
                        txtUserName.Enabled = true;
                        this.displayDataTableUser(dataGridViewUser);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Failed to delete this user. Please try again.", "Message");
                    }
                }
               
            } else
            {
                MessageBox.Show("Please select the user to delete.", "Message");
            }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            String username = txtUserName.Text.Trim();
            String password = txtPassword.Text.Trim();
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
            } else
            {
                DialogResult dr = MessageBox.Show("Do you want to update this user?", "Confirmed Message", MessageBoxButtons.YesNoCancel,
                  MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                {
                    MongoDBConnection mongoDBConnection = MongoDBConnection.getMongoConnection;
                    User currentUser = new User();
                    try
                    {

                        currentUser = currentUser.findUserByName(username, mongoDBConnection.getMongoData());
                        User newUser = new User();
                        newUser.passWord = password;
                        newUser.active = ckcActive.Checked;
                        currentUser.updateUser(mongoDBConnection.getMongoData(), currentUser, newUser);
                        MessageBox.Show("The user is updated successfully.", "Message");
                        txtUserName.Clear();
                        txtPassword.Clear();
                        if (ckcActive.Checked)
                        {
                            ckcActive.Checked = false;
                        }
                        txtUserName.Enabled = true;
                        this.displayDataTableUser(dataGridViewUser);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Failed to update this user. Please try again.", "Message");
                    }
                }
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            String name = txtName.Text.Trim();
            String phoneNumber = txtPhoneNumber.Text.Trim();
            String address = txtAddress.Text.Trim();
            bool isActive = ckcActiveCustomer.Checked;
            Customer newCustomer = new Customer();
            newCustomer.name = name;
            newCustomer.phoneNumber = phoneNumber;
            newCustomer.address = address;
            newCustomer.isActive = ckcActiveCustomer.Checked;
            newCustomer.createDate = DateTime.Now.ToUniversalTime();
            newCustomer.modifyDate = DateTime.Now.ToUniversalTime();
            
            if (String.IsNullOrEmpty(name) && String.IsNullOrEmpty(phoneNumber))
            {
                MessageBox.Show("Please enter name and phone number.", "Message");
            } else if (String.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter name field.", "Message");
            } else if (String.IsNullOrEmpty(phoneNumber))
            {
                MessageBox.Show("Please enter phone number field.", "Message");
            } else
            {
                try
                {
                    MongoDBConnection mongoDBConnection = MongoDBConnection.getMongoConnection;
                    newCustomer.addCustomer(mongoDBConnection.getMongoData(), newCustomer);
                    MessageBox.Show("New Customer is added successfully.", "Message");
                    txtName.Clear();
                    txtPhoneNumber.Clear();
                    txtAddress.Clear();
                    if (ckcActiveCustomer.Checked)
                    {
                        ckcActiveCustomer.Checked = false;
                    }
                    this.displayDataTableCustomer(dataGridViewCustomer);
                }
                catch (Exception)
                {
                    MessageBox.Show("Failed to add new customer. Please try again.", "Message");
                }
            }
           
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            String username = txtUserName.Text.Trim();
            String password = txtPassword.Text.Trim();

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
                User newUser = new User();
                newUser.userName = username;
                newUser.passWord = newUser.getMD5(password);
                newUser.createDate = DateTime.Now.ToUniversalTime();
                newUser.active = ckcActive.Checked;
                try
                {
                    MongoDBConnection mongoDBConnection = MongoDBConnection.getMongoConnection;
                    newUser.addUser(mongoDBConnection.getMongoData(), newUser);
                    MessageBox.Show("New user is added successfully.", "Message");
                    txtUserName.Clear();
                    txtPassword.Clear();
                    if (ckcActive.Checked)
                    {
                        ckcActive.Checked = false;
                    }
                    this.displayDataTableUser(dataGridViewUser);
                }
                catch (Exception)
                {
                    MessageBox.Show("Failed to add new user. Please try again.", "Message");
                }
            }

        }
    }
}
