﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
