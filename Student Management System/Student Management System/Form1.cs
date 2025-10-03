using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            string username = textusername.Text;
            string password = textpassword.Text;

            if (username == "Admin" && password == "Skills@123")
            {
                MessageBox.Show("Login Successful!");
                this.Hide();

                Form2 secondForm = new Form2();
                secondForm.Show();
            }
            else
            {
                MessageBox.Show("Invalid Login credentials, please check Username and Password and try again");
            }

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textusername.Clear();
            textpassword.Clear();

            textusername.Focus();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            {
                DialogResult result = MessageBox.Show(
                    "Are you sure, Do you really want to Exit...?",
                    "Exit",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    Application.Exit(); 
                }
                else
                {
                }
            }
        }
    }
}
