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
        public String selectedCustomer;
        public String selectedOrderTruck;
        public Form2()
        {
            InitializeComponent();
            this.displayDataTableUser(dataGridViewUser);
            this.displayDataTableCustomer(dataGridViewCustomer);
            this.displayDataTableOrderTruck(dataGridViewOrderTruck);
            dateTPCompletedDay.CustomFormat = " ";
            dateTPCompletedDay.Format = DateTimePickerFormat.Custom;
            dateTPStartDay.CustomFormat = " ";
            dateTPStartDay.Format = DateTimePickerFormat.Custom;
            dateTPEnday.CustomFormat = " ";
            dateTPEnday.Format = DateTimePickerFormat.Custom;
            Console.WriteLine("QQQQQQQQQQ");
            DateTime d = new DateTime();
            d = dateTPCompletedDay.Value;
            Console.WriteLine(d.ToUniversalTime());
            this.loadValueCustomerCombobox(cbbCustomer);
            this.loadValueMaterialTypeCombobox(cbbMaterialType);

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
        public void displayDataTableCustomer(DataGridView dataGridView)
        {
            Customer customerData = new Customer();
            MongoDBConnection mongoDBConnection = MongoDBConnection.getMongoConnection;
            List<Customer> listCustomers = customerData.getAllCustomers(mongoDBConnection.getMongoData());
            dataGridViewCustomer.Rows.Clear();
            dataGridViewCustomer.Refresh();
            for (int i = 0; i < listCustomers.Count; i++)
            {
                dataGridViewCustomer.Rows.Add(new object[] { i + 1, listCustomers[i].name, listCustomers[i].phoneNumber, listCustomers[i].address,
                listCustomers[i].createDate.ToLocalTime(), listCustomers[i].modifyDate.ToLocalTime(), listCustomers[i].isActive, listCustomers[i]._id });
            }
            Console.WriteLine(dataGridViewCustomer.ColumnCount);
        }
        public void displayDataTableOrderTruck(DataGridView dataGridView)
        {
            OrderTruck orderTruckData = new OrderTruck();
            MongoDBConnection mongoDBConnection = MongoDBConnection.getMongoConnection;
            List<OrderTruck> listOrderTrucks = orderTruckData.getAllOrderTrucks(mongoDBConnection.getMongoData());
            dataGridView.Rows.Clear();
            dataGridView.Refresh();
            for (int i = 0; i < listOrderTrucks.Count; i++)
            {
                dataGridView.Rows.Add(new object[] { i + 1, listOrderTrucks[i].customer.name, listOrderTrucks[i].materialType, listOrderTrucks[i].note,
                    listOrderTrucks[i].subtotal,listOrderTrucks[i].completedDate.ToLocalTime(),listOrderTrucks[i].modifyDate.ToLocalTime(), listOrderTrucks[i].isPaid,listOrderTrucks[i]._id});
            }
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
                selectedCustomer = gridCustomer.Cells[7].Value.ToString();
                Console.WriteLine(selectedCustomer);
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

            }
            else
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
            }
            else
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
            }
            else if (String.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter name field.", "Message");
            }
            else if (String.IsNullOrEmpty(phoneNumber))
            {
                MessageBox.Show("Please enter phone number field.", "Message");
            }
            else
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
                    this.loadValueCustomerCombobox(cbbCustomer);
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

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            Customer currentUser = new Customer();
            String updateName = txtName.Text.Trim();
            String updatePhoneNumber = txtPhoneNumber.Text.Trim();
            String updateAddress = txtAddress.Text.Trim();
            bool updateIsActive = ckcActiveCustomer.Checked;

            if (!String.IsNullOrEmpty(selectedCustomer))
            {
                MongoDBConnection mongoDBConnection = MongoDBConnection.getMongoConnection;
                currentUser = currentUser.findCustomerByID(mongoDBConnection.getMongoData(), selectedCustomer);
                Customer updateCustomer = new Customer();
                if (String.IsNullOrEmpty(txtName.Text) && String.IsNullOrEmpty(txtPhoneNumber.Text))
                {
                    MessageBox.Show("Please enter name and phone number.", "Message");
                }
                else if (String.IsNullOrEmpty(txtName.Text))
                {
                    MessageBox.Show("Please enter name field.", "Message");
                }
                else if (String.IsNullOrEmpty(txtPhoneNumber.Text))
                {
                    MessageBox.Show("Please enter phone number field.", "Message");
                } else
                {
                    updateCustomer.name = updateName;
                    updateCustomer.phoneNumber = updatePhoneNumber;
                    updateCustomer.address = updateAddress;
                    updateCustomer.isActive = updateIsActive;
                    updateCustomer.modifyDate = DateTime.Now.ToUniversalTime();

                    currentUser.updateCustomer(mongoDBConnection.getMongoData(), currentUser, updateCustomer);
                    MessageBox.Show("The customer is updated successfully.", "Message");
                    txtName.Clear();
                    txtPhoneNumber.Clear();
                    txtAddress.Clear();
                    if (ckcActiveCustomer.Checked)
                    {
                        ckcActiveCustomer.Checked = false;
                    }
                    this.displayDataTableCustomer(dataGridViewCustomer);
                    this.loadValueCustomerCombobox(cbbCustomer);
                }
            } else
            {
                MessageBox.Show("Please select the customer to delete.", "Message");
            }
           
            
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(selectedCustomer))
            {

                if (String.IsNullOrEmpty(txtName.Text) || String.IsNullOrEmpty(txtPhoneNumber.Text) || String.IsNullOrEmpty(txtAddress.Text))
                {
                    MessageBox.Show("Please select the customer to delete.", "Message");
                }
                else
                {
                    try
                    {
                        MongoDBConnection mongoDBConnection = MongoDBConnection.getMongoConnection;
                        Customer deleteCustomer = new Customer();
                        deleteCustomer.deleteCustomer(mongoDBConnection.getMongoData(), selectedCustomer);
                        MessageBox.Show("Customer is deleted successfully . Please try again.", "Message");
                        txtName.Clear();
                        txtPhoneNumber.Clear();
                        txtAddress.Clear();
                        if (ckcActiveCustomer.Checked)
                        {
                            ckcActiveCustomer.Checked = false;
                        }
                        this.displayDataTableCustomer(dataGridViewCustomer);
                        this.loadValueCustomerCombobox(cbbCustomer);
                    } catch (Exception)
                    {
                        MessageBox.Show("Failed to delete the customer. Please try again.", "Message");
                    }
                   
                }
            }
            else
            {
                MessageBox.Show("Please select the customer to delete.", "Message");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cbbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
           // this.loadValueCustomerCombobox(cbbCustomer);
            Console.WriteLine(cbbCustomer.SelectedItem.ToString());
           
        }

        private void tabOrderTruck_Click(object sender, EventArgs e)
        {
            this.loadValueCustomerCombobox(cbbCustomer);
        }
        public void loadValueCustomerCombobox (ComboBox customerCombobox)
        {
            MongoDBConnection mongoDBConnection = MongoDBConnection.getMongoConnection;
            Customer customer = new Customer();
            List<Customer> listCustomers = customer.getAllActiveCustomers(mongoDBConnection.getMongoData());
            cbbCustomer.Items.Clear();
            cbbCustomer.ResetText();
            foreach(Customer customer1 in listCustomers)
            {
                cbbCustomer.Items.Add(customer1.name);
            }
        }
        public void loadValueMaterialTypeCombobox (ComboBox materialTypeCombobox)
        {
            cbbMaterialType.Items.Add("Cát");
            cbbMaterialType.Items.Add("Đá");
            cbbMaterialType.Items.Add("Gạch");
            cbbMaterialType.Items.Add("Xà Bần");
            cbbMaterialType.Items.Add("Đất");
        }

        private void btnAddOrderTruck_Click(object sender, EventArgs e)
        {
            String customerName = "";
            String materialType = "";
            String note = txtNote.Text.Trim();
            if (cbbCustomer.SelectedIndex < 0)
            {
                MessageBox.Show("Please select the customer's name.", "Message");
            }
            else if (cbbMaterialType.SelectedIndex < 0)
            {
                MessageBox.Show("Please select the material type.", "Message");
            } else if(String.IsNullOrEmpty(txtSubTotal.Text.Trim()))
            {
                MessageBox.Show("Please input the subtotal.", "Message");
            } else if (dateTPCompletedDay.CustomFormat == " ")
            {
                MessageBox.Show("Please select the completed day.", "Message");
            } else
            {
                customerName = cbbCustomer.SelectedItem.ToString().Trim();
                materialType = cbbMaterialType.SelectedItem.ToString().Trim();
                MongoDBConnection mongoDBConnection = MongoDBConnection.getMongoConnection;
                Customer selectedCustomer = new Customer();
                selectedCustomer = selectedCustomer.findCustomerByName(customerName, mongoDBConnection.getMongoData());
                DateTime completedDay = dateTPCompletedDay.Value.ToUniversalTime();
                OrderTruck newOrderTruck = new OrderTruck();
                newOrderTruck.customer = selectedCustomer;
                newOrderTruck.materialType = materialType;
                newOrderTruck.subtotal = int.Parse(txtSubTotal.Text.Trim());
                newOrderTruck.note = txtNote.Text.Trim();
                newOrderTruck.completedDate = completedDay;
                newOrderTruck.createDate = DateTime.Now.ToUniversalTime();
                newOrderTruck.modifyDate = DateTime.Now.ToUniversalTime();
                newOrderTruck.isPaid = ckcIsPaid.Checked;
                this.clearOrderTruckTab();
                try
                {
                    newOrderTruck.addOrderTruck(mongoDBConnection.getMongoData(), newOrderTruck);
                    MessageBox.Show("New order truck is add successfully.", "Message");
                    this.clearOrderTruckTab();
                    this.displayDataTableOrderTruck(dataGridViewOrderTruck);
                } catch(Exception)
                {
                    MessageBox.Show("Failed to add new order truck. Please try again.", "Message");
                }
            }
        }
        public void clearOrderTruckTab()
        {
            cbbCustomer.ResetText();
            cbbMaterialType.ResetText();
            txtNote.Clear();
            txtSubTotal.Clear();
            dateTPCompletedDay.CustomFormat = " ";
            dateTPCompletedDay.Format = DateTimePickerFormat.Custom;
            if (ckcIsPaid.Checked)
            {
                ckcIsPaid.Checked = false;
            }
        }

        private void btnUpdateOrderTruck_Click(object sender, EventArgs e)
        {
            this.clearOrderTruckTab();
        }

        private void btnDeleteOrderTruck_Click(object sender, EventArgs e)
        {
            this.clearOrderTruckTab();
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void ckcIsPaid_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dateTPStartDay_ValueChanged(object sender, EventArgs e)
        {
            dateTPStartDay.CustomFormat = "dd/MM/yyyy";
        }

        private void dateTPEnday_ValueChanged(object sender, EventArgs e)
        {
            // DateTime date = DateTime.ParseExact(dateTPEnday.Value.ToString("dd/MM/yyyy"), "dd/MM/yyyy", null);
            // Console.WriteLine(date.ToUniversalTime().ToString());
            dateTPEnday.CustomFormat = "dd/MM/yyyy";
        }

        private void dataGridViewOrderTruck_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var gridOrderTruck = dataGridViewOrderTruck.Rows[e.RowIndex];
                cbbCustomer.Text = gridOrderTruck.Cells[1].Value.ToString();
                cbbMaterialType.Text = gridOrderTruck.Cells[2].Value.ToString();
                txtNote.Text = gridOrderTruck.Cells[3].Value.ToString();
                txtSubTotal.Text = gridOrderTruck.Cells[4].Value.ToString();
                //dateTPCompletedDay.Value = gridOrderTruck.Cells[5].Value.ToString();
                ckcPaid.Checked = Convert.ToBoolean(gridOrderTruck.Cells[7].Value.ToString());
                selectedCustomer = gridOrderTruck.Cells[8].Value.ToString();
                Console.WriteLine(selectedCustomer);
            }
        }

        private void dateTPCompletedDay_ValueChanged(object sender, EventArgs e)
        {
            dateTPCompletedDay.CustomFormat = "dd/MM/yyyy";
        }
    }
}
