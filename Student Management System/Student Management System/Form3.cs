﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_System
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Head_To_Login_Click(object sender, EventArgs e)
        {
            
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Hide();
        }

    }
}
}
