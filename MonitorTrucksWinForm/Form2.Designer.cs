namespace WindowsFormsAppTest
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabUser = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.ckcActive = new System.Windows.Forms.CheckBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewUser = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Active = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabCustomer = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.dataGridViewCustomer = new System.Windows.Forms.DataGridView();
            this.idCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createDateCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifyDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActiveCustomer = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idMongoDB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ckcActiveCustomer = new System.Windows.Forms.CheckBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.tabOrderTruck = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idOrderTruck = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.completedDateOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifyDateOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnDeleteOrderTruck = new System.Windows.Forms.Button();
            this.btnUpdateOrderTruck = new System.Windows.Forms.Button();
            this.btnAddOrderTruck = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.cbbMaterialType = new System.Windows.Forms.ComboBox();
            this.lblMaterialType = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.cbbCustomer = new System.Windows.Forms.ComboBox();
            this.tabTruck = new System.Windows.Forms.TabPage();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tabControl.SuspendLayout();
            this.tabUser.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).BeginInit();
            this.tabCustomer.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tabOrderTruck.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabUser);
            this.tabControl.Controls.Add(this.tabCustomer);
            this.tabControl.Controls.Add(this.tabOrderTruck);
            this.tabControl.Controls.Add(this.tabTruck);
            this.tabControl.Location = new System.Drawing.Point(-2, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1060, 599);
            this.tabControl.TabIndex = 0;
            // 
            // tabUser
            // 
            this.tabUser.Controls.Add(this.groupBox2);
            this.tabUser.Controls.Add(this.groupBox1);
            this.tabUser.Controls.Add(this.dataGridViewUser);
            this.tabUser.Location = new System.Drawing.Point(4, 22);
            this.tabUser.Name = "tabUser";
            this.tabUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabUser.Size = new System.Drawing.Size(1052, 573);
            this.tabUser.TabIndex = 0;
            this.tabUser.Text = "User";
            this.tabUser.UseVisualStyleBackColor = true;
            this.tabUser.Click += new System.EventHandler(this.userPage_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAddUser);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Location = new System.Drawing.Point(23, 155);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(744, 82);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Actions";
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(28, 19);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(140, 40);
            this.btnAddUser.TabIndex = 1;
            this.btnAddUser.Text = "Add";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(254, 19);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(140, 40);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(482, 19);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(140, 40);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblUsername);
            this.groupBox1.Controls.Add(this.ckcActive);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtUserName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(23, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(744, 143);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(58, 35);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(60, 13);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "User Name";
            this.lblUsername.Click += new System.EventHandler(this.lblUsername_Click);
            // 
            // ckcActive
            // 
            this.ckcActive.AutoSize = true;
            this.ckcActive.Location = new System.Drawing.Point(338, 77);
            this.ckcActive.Name = "ckcActive";
            this.ckcActive.Size = new System.Drawing.Size(56, 17);
            this.ckcActive.TabIndex = 5;
            this.ckcActive.Text = "Active";
            this.ckcActive.UseVisualStyleBackColor = true;
            this.ckcActive.CheckedChanged += new System.EventHandler(this.ckcActive_CheckedChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(154, 74);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 8;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(154, 28);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(100, 20);
            this.txtUserName.TabIndex = 6;
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Password";
            // 
            // dataGridViewUser
            // 
            this.dataGridViewUser.AllowUserToDeleteRows = false;
            this.dataGridViewUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.UserName,
            this.Password,
            this.CreateDate,
            this.Active});
            this.dataGridViewUser.Location = new System.Drawing.Point(23, 243);
            this.dataGridViewUser.Name = "dataGridViewUser";
            this.dataGridViewUser.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUser.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewUser.Size = new System.Drawing.Size(876, 287);
            this.dataGridViewUser.TabIndex = 0;
            this.dataGridViewUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUser_CellClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 220;
            // 
            // UserName
            // 
            this.UserName.HeaderText = "UserName";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            this.UserName.Width = 220;
            // 
            // Password
            // 
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            this.Password.Visible = false;
            // 
            // CreateDate
            // 
            this.CreateDate.HeaderText = "CreateDate";
            this.CreateDate.Name = "CreateDate";
            this.CreateDate.ReadOnly = true;
            this.CreateDate.Width = 220;
            // 
            // Active
            // 
            this.Active.HeaderText = "Active";
            this.Active.Name = "Active";
            this.Active.ReadOnly = true;
            // 
            // tabCustomer
            // 
            this.tabCustomer.Controls.Add(this.groupBox4);
            this.tabCustomer.Controls.Add(this.dataGridViewCustomer);
            this.tabCustomer.Controls.Add(this.groupBox3);
            this.tabCustomer.Location = new System.Drawing.Point(4, 22);
            this.tabCustomer.Name = "tabCustomer";
            this.tabCustomer.Padding = new System.Windows.Forms.Padding(3);
            this.tabCustomer.Size = new System.Drawing.Size(1052, 573);
            this.tabCustomer.TabIndex = 1;
            this.tabCustomer.Text = "Customers";
            this.tabCustomer.UseVisualStyleBackColor = true;
            this.tabCustomer.Click += new System.EventHandler(this.customerPage_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnDeleteCustomer);
            this.groupBox4.Controls.Add(this.btnUpdateCustomer);
            this.groupBox4.Controls.Add(this.btnAddCustomer);
            this.groupBox4.Location = new System.Drawing.Point(21, 177);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(884, 92);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Actions";
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Location = new System.Drawing.Point(529, 19);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(140, 40);
            this.btnDeleteCustomer.TabIndex = 2;
            this.btnDeleteCustomer.Text = "DELETE";
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.Location = new System.Drawing.Point(293, 19);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(140, 40);
            this.btnUpdateCustomer.TabIndex = 1;
            this.btnUpdateCustomer.Text = "UPDATE";
            this.btnUpdateCustomer.UseVisualStyleBackColor = true;
            this.btnUpdateCustomer.Click += new System.EventHandler(this.btnUpdateCustomer_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(40, 19);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(140, 40);
            this.btnAddCustomer.TabIndex = 0;
            this.btnAddCustomer.Text = "ADD";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // dataGridViewCustomer
            // 
            this.dataGridViewCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCustomer,
            this.customerName,
            this.phoneNumber,
            this.address,
            this.createDateCustomer,
            this.modifyDate,
            this.isActiveCustomer,
            this.idMongoDB});
            this.dataGridViewCustomer.Location = new System.Drawing.Point(21, 320);
            this.dataGridViewCustomer.Name = "dataGridViewCustomer";
            this.dataGridViewCustomer.Size = new System.Drawing.Size(975, 250);
            this.dataGridViewCustomer.TabIndex = 1;
            this.dataGridViewCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCustomer_CellClick);
            // 
            // idCustomer
            // 
            this.idCustomer.Frozen = true;
            this.idCustomer.HeaderText = "ID";
            this.idCustomer.Name = "idCustomer";
            this.idCustomer.ReadOnly = true;
            this.idCustomer.Width = 80;
            // 
            // customerName
            // 
            this.customerName.Frozen = true;
            this.customerName.HeaderText = "Name";
            this.customerName.Name = "customerName";
            this.customerName.ReadOnly = true;
            // 
            // phoneNumber
            // 
            this.phoneNumber.Frozen = true;
            this.phoneNumber.HeaderText = "Phone Number";
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.ReadOnly = true;
            this.phoneNumber.Width = 150;
            // 
            // address
            // 
            this.address.Frozen = true;
            this.address.HeaderText = "Address";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            this.address.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.address.Width = 200;
            // 
            // createDateCustomer
            // 
            this.createDateCustomer.Frozen = true;
            this.createDateCustomer.HeaderText = "CreateDate";
            this.createDateCustomer.Name = "createDateCustomer";
            this.createDateCustomer.ReadOnly = true;
            this.createDateCustomer.Width = 150;
            // 
            // modifyDate
            // 
            this.modifyDate.Frozen = true;
            this.modifyDate.HeaderText = "ModifyDate";
            this.modifyDate.Name = "modifyDate";
            this.modifyDate.ReadOnly = true;
            this.modifyDate.Width = 150;
            // 
            // isActiveCustomer
            // 
            this.isActiveCustomer.Frozen = true;
            this.isActiveCustomer.HeaderText = "Active";
            this.isActiveCustomer.Name = "isActiveCustomer";
            this.isActiveCustomer.ReadOnly = true;
            this.isActiveCustomer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // idMongoDB
            // 
            this.idMongoDB.Frozen = true;
            this.idMongoDB.HeaderText = "idMongoDB";
            this.idMongoDB.Name = "idMongoDB";
            this.idMongoDB.ReadOnly = true;
            this.idMongoDB.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ckcActiveCustomer);
            this.groupBox3.Controls.Add(this.txtAddress);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtPhoneNumber);
            this.groupBox3.Controls.Add(this.txtName);
            this.groupBox3.Location = new System.Drawing.Point(21, 17);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(884, 154);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Customer";
            // 
            // ckcActiveCustomer
            // 
            this.ckcActiveCustomer.AutoSize = true;
            this.ckcActiveCustomer.Location = new System.Drawing.Point(389, 78);
            this.ckcActiveCustomer.Name = "ckcActiveCustomer";
            this.ckcActiveCustomer.Size = new System.Drawing.Size(56, 17);
            this.ckcActiveCustomer.TabIndex = 6;
            this.ckcActiveCustomer.Text = "Active";
            this.ckcActiveCustomer.UseVisualStyleBackColor = true;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(103, 109);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(342, 20);
            this.txtAddress.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Phone Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(103, 72);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(125, 20);
            this.txtPhoneNumber.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(103, 31);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(125, 20);
            this.txtName.TabIndex = 0;
            // 
            // tabOrderTruck
            // 
            this.tabOrderTruck.Controls.Add(this.groupBox7);
            this.tabOrderTruck.Controls.Add(this.dataGridView1);
            this.tabOrderTruck.Controls.Add(this.groupBox6);
            this.tabOrderTruck.Controls.Add(this.groupBox5);
            this.tabOrderTruck.Location = new System.Drawing.Point(4, 22);
            this.tabOrderTruck.Name = "tabOrderTruck";
            this.tabOrderTruck.Padding = new System.Windows.Forms.Padding(3);
            this.tabOrderTruck.Size = new System.Drawing.Size(1052, 573);
            this.tabOrderTruck.TabIndex = 2;
            this.tabOrderTruck.Text = "OrderTrucks";
            this.tabOrderTruck.UseVisualStyleBackColor = true;
            this.tabOrderTruck.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.checkBox1);
            this.groupBox7.Location = new System.Drawing.Point(10, 271);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(905, 50);
            this.groupBox7.TabIndex = 3;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Search";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Checked = false;
            this.dateTimePicker.Location = new System.Drawing.Point(455, 108);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 9;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idOrderTruck,
            this.customer,
            this.materialType,
            this.note,
            this.subTotal,
            this.completedDateOrder,
            this.modifyDateOrder});
            this.dataGridView1.Location = new System.Drawing.Point(10, 327);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1014, 201);
            this.dataGridView1.TabIndex = 2;
            // 
            // idOrderTruck
            // 
            this.idOrderTruck.HeaderText = "ID";
            this.idOrderTruck.Name = "idOrderTruck";
            this.idOrderTruck.ReadOnly = true;
            this.idOrderTruck.Width = 80;
            // 
            // customer
            // 
            this.customer.HeaderText = "Customer";
            this.customer.Name = "customer";
            this.customer.Width = 150;
            // 
            // materialType
            // 
            this.materialType.HeaderText = "Material Types";
            this.materialType.Name = "materialType";
            this.materialType.ReadOnly = true;
            this.materialType.Width = 120;
            // 
            // note
            // 
            this.note.HeaderText = "Note";
            this.note.Name = "note";
            this.note.Width = 200;
            // 
            // subTotal
            // 
            this.subTotal.HeaderText = "SubTotal";
            this.subTotal.Name = "subTotal";
            this.subTotal.ReadOnly = true;
            this.subTotal.Width = 120;
            // 
            // completedDateOrder
            // 
            this.completedDateOrder.HeaderText = "Completed Date";
            this.completedDateOrder.Name = "completedDateOrder";
            this.completedDateOrder.ReadOnly = true;
            this.completedDateOrder.Width = 150;
            // 
            // modifyDateOrder
            // 
            this.modifyDateOrder.HeaderText = "ModifyDate";
            this.modifyDateOrder.Name = "modifyDateOrder";
            this.modifyDateOrder.ReadOnly = true;
            this.modifyDateOrder.Width = 150;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnDeleteOrderTruck);
            this.groupBox6.Controls.Add(this.btnUpdateOrderTruck);
            this.groupBox6.Controls.Add(this.btnAddOrderTruck);
            this.groupBox6.Location = new System.Drawing.Point(10, 180);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(905, 74);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Actions";
            // 
            // btnDeleteOrderTruck
            // 
            this.btnDeleteOrderTruck.Location = new System.Drawing.Point(628, 19);
            this.btnDeleteOrderTruck.Name = "btnDeleteOrderTruck";
            this.btnDeleteOrderTruck.Size = new System.Drawing.Size(140, 40);
            this.btnDeleteOrderTruck.TabIndex = 2;
            this.btnDeleteOrderTruck.Text = "DELETE";
            this.btnDeleteOrderTruck.UseVisualStyleBackColor = true;
            // 
            // btnUpdateOrderTruck
            // 
            this.btnUpdateOrderTruck.Location = new System.Drawing.Point(322, 19);
            this.btnUpdateOrderTruck.Name = "btnUpdateOrderTruck";
            this.btnUpdateOrderTruck.Size = new System.Drawing.Size(140, 40);
            this.btnUpdateOrderTruck.TabIndex = 1;
            this.btnUpdateOrderTruck.Text = "UPDATE";
            this.btnUpdateOrderTruck.UseVisualStyleBackColor = true;
            // 
            // btnAddOrderTruck
            // 
            this.btnAddOrderTruck.Location = new System.Drawing.Point(43, 19);
            this.btnAddOrderTruck.Name = "btnAddOrderTruck";
            this.btnAddOrderTruck.Size = new System.Drawing.Size(140, 40);
            this.btnAddOrderTruck.TabIndex = 0;
            this.btnAddOrderTruck.Text = "ADD";
            this.btnAddOrderTruck.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.dateTimePicker);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.txtSubTotal);
            this.groupBox5.Controls.Add(this.lblSubTotal);
            this.groupBox5.Controls.Add(this.txtNote);
            this.groupBox5.Controls.Add(this.lblNote);
            this.groupBox5.Controls.Add(this.cbbMaterialType);
            this.groupBox5.Controls.Add(this.lblMaterialType);
            this.groupBox5.Controls.Add(this.lblCustomerName);
            this.groupBox5.Controls.Add(this.cbbCustomer);
            this.groupBox5.Location = new System.Drawing.Point(10, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(758, 141);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Orders Truck";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(561, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "VND";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(342, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Completed Date";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Location = new System.Drawing.Point(455, 34);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(100, 20);
            this.txtSubTotal.TabIndex = 7;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Location = new System.Drawing.Point(347, 42);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(50, 13);
            this.lblSubTotal.TabIndex = 6;
            this.lblSubTotal.Text = "SubTotal";
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(133, 107);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(121, 20);
            this.txtNote.TabIndex = 5;
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Location = new System.Drawing.Point(21, 107);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(30, 13);
            this.lblNote.TabIndex = 4;
            this.lblNote.Text = "Note";
            this.lblNote.Click += new System.EventHandler(this.label5_Click);
            // 
            // cbbMaterialType
            // 
            this.cbbMaterialType.FormattingEnabled = true;
            this.cbbMaterialType.Location = new System.Drawing.Point(133, 70);
            this.cbbMaterialType.Name = "cbbMaterialType";
            this.cbbMaterialType.Size = new System.Drawing.Size(121, 21);
            this.cbbMaterialType.TabIndex = 3;
            // 
            // lblMaterialType
            // 
            this.lblMaterialType.AutoSize = true;
            this.lblMaterialType.Location = new System.Drawing.Point(21, 73);
            this.lblMaterialType.Name = "lblMaterialType";
            this.lblMaterialType.Size = new System.Drawing.Size(71, 13);
            this.lblMaterialType.TabIndex = 2;
            this.lblMaterialType.Text = "Material Type";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(21, 42);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(89, 13);
            this.lblCustomerName.TabIndex = 1;
            this.lblCustomerName.Text = "Customer\'s Name";
            // 
            // cbbCustomer
            // 
            this.cbbCustomer.FormattingEnabled = true;
            this.cbbCustomer.Location = new System.Drawing.Point(133, 34);
            this.cbbCustomer.Name = "cbbCustomer";
            this.cbbCustomer.Size = new System.Drawing.Size(121, 21);
            this.cbbCustomer.TabIndex = 0;
            this.cbbCustomer.SelectedIndexChanged += new System.EventHandler(this.cbbCustomer_SelectedIndexChanged);
            // 
            // tabTruck
            // 
            this.tabTruck.Location = new System.Drawing.Point(4, 22);
            this.tabTruck.Name = "tabTruck";
            this.tabTruck.Padding = new System.Windows.Forms.Padding(3);
            this.tabTruck.Size = new System.Drawing.Size(1052, 573);
            this.tabTruck.TabIndex = 3;
            this.tabTruck.Text = "tabPage4";
            this.tabTruck.UseVisualStyleBackColor = true;
            this.tabTruck.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(475, 19);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 600);
            this.Controls.Add(this.tabControl);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tabControl.ResumeLayout(false);
            this.tabUser.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).EndInit();
            this.tabCustomer.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabOrderTruck.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabUser;
        private System.Windows.Forms.TabPage tabCustomer;
        private System.Windows.Forms.TabPage tabOrderTruck;
        private System.Windows.Forms.TabPage tabTruck;
        private System.Windows.Forms.DataGridView dataGridViewUser;
        private System.Windows.Forms.CheckBox ckcActive;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateDate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Active;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ckcActiveCustomer;
        private System.Windows.Forms.DataGridView dataGridViewCustomer;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.Button btnUpdateCustomer;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn createDateCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn modifyDate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isActiveCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMongoDB;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cbbCustomer;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.ComboBox cbbMaterialType;
        private System.Windows.Forms.Label lblMaterialType;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Button btnDeleteOrderTruck;
        private System.Windows.Forms.Button btnUpdateOrderTruck;
        private System.Windows.Forms.Button btnAddOrderTruck;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOrderTruck;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialType;
        private System.Windows.Forms.DataGridViewTextBoxColumn note;
        private System.Windows.Forms.DataGridViewTextBoxColumn subTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn completedDateOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn modifyDateOrder;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}