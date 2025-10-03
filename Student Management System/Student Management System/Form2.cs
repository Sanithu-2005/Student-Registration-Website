using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_System
{
    public partial class Form2 : Form
    {

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void LoadStudentRegNos()
        {
            string connectionString = @"Data Source=DESKTOP-LHEPBPR;Initial Catalog=Student;Integrated Security=True;TrustServerCertificate=True";

            using (var con = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand("SELECT regNo FROM Registration", con))
            {
                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    cmbRegNo.Items.Clear();
                    while (reader.Read())
                    {
                        cmbRegNo.Items.Add(reader["regNo"].ToString());
                    }
                }
            }

            cmbRegNo.SelectedIndex = -1; 
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadStudentRegNos();
        }

        public Form2()
        {
            InitializeComponent();
            this.Load += Form2_Load;
            cmbRegNo.SelectedIndexChanged += cmbRegNo_SelectedIndexChanged;
        }

        private void cmbRegNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.TryParse(cmbRegNo.SelectedItem?.ToString(), out int regNo))
            {
                LoadStudentData(regNo);
            }
        }

        private void LoadStudentData(int regNo)
        {
            string connectionString = @"Data Source=DESKTOP-LHEPBPR;Initial Catalog=Student;Integrated Security=True;TrustServerCertificate=True";

            using (var con = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand("SELECT * FROM Registration WHERE regNo = @regNo", con))
            {
                cmd.Parameters.Add("@regNo", SqlDbType.Int).Value = regNo;

                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        txtFirstName.Text = reader["firstName"].ToString();
                        txtLastName.Text = reader["lastName"].ToString();
                        dtpDOB.Value = Convert.ToDateTime(reader["dateOfBirth"]);
                        txtAddress.Text = reader["address"].ToString();
                        txtEmail.Text = reader["email"].ToString();
                        txtMobile.Text = reader["mobilePhone"].ToString();
                        txtHome.Text = reader["homePhone"].ToString();
                        txtParent.Text = reader["parentName"].ToString();
                        txtNIC.Text = reader["nic"].ToString();
                        txtContact.Text = reader["contactNo"].ToString();

                        string gender = reader["gender"].ToString();
                        rbMale.Checked = gender == "Male";
                        rbFemale.Checked = gender == "Female";
                    }
                    else
                    {
                        MessageBox.Show("Student record not found.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void Register_Click(object sender, EventArgs e)
        {
            int regNo = Convert.ToInt32(cmbRegNo.SelectedItem);
            string gender;
            if (rbMale.Checked)
                gender = "Male";
            else if (rbFemale.Checked)
                gender = "Female";
            else
            {
                MessageBox.Show("Please select a gender.");
                return;
            }
            string connectionString = @"Data Source=DESKTOP-LHEPBPR;Initial Catalog=Student;Integrated Security=True;TrustServerCertificate=True";

            try
            {
                using (var con = new SqlConnection(connectionString))
                using (var cmd = con.CreateCommand())
                {
                    cmd.CommandText = @"
INSERT INTO [Registration]
([regNo],[firstName],[lastName],[dateOfBirth],[gender],[address],[email],
 [mobilePhone],[homePhone],[parentName],[nic],[contactNo])
VALUES
(@regNo,@firstName,@lastName,@dateOfBirth,@gender,@address,@email,
 @mobilePhone,@homePhone,@parentName,@nic,@contactNo);";

                    cmd.Parameters.Add("@regNo", SqlDbType.Int).Value = regNo;
                    cmd.Parameters.Add("@firstName", SqlDbType.VarChar, 50).Value = txtFirstName.Text.Trim();
                    cmd.Parameters.Add("@lastName", SqlDbType.VarChar, 50).Value = txtLastName.Text.Trim();
                    cmd.Parameters.Add("@dateOfBirth", SqlDbType.DateTime).Value = dtpDOB.Value;
                    cmd.Parameters.Add("@gender", SqlDbType.VarChar, 50).Value = gender;
                    cmd.Parameters.Add("@address", SqlDbType.VarChar, 50).Value = txtAddress.Text.Trim();
                    cmd.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = txtEmail.Text.Trim();
                    cmd.Parameters.Add("@mobilePhone", SqlDbType.VarChar, 15).Value = txtMobile.Text.Trim();
                    cmd.Parameters.Add("@homePhone", SqlDbType.VarChar, 15).Value = txtHome.Text.Trim();
                    cmd.Parameters.Add("@parentName", SqlDbType.VarChar, 50).Value = txtParent.Text.Trim();
                    cmd.Parameters.Add("@nic", SqlDbType.VarChar, 50).Value = txtNIC.Text.Trim();
                    cmd.Parameters.Add("@contactNo", SqlDbType.VarChar, 15).Value = txtContact.Text.Trim();

                    con.Open();
                    cmd.ExecuteNonQuery();
                }


                MessageBox.Show("Record Added Successfully", "Register Student",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message, "Register Student",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Update_Click(object sender, EventArgs e)
        {
            string gender;
            if (rbMale.Checked)
                gender = "Male";
            else if (rbFemale.Checked)
                gender = "Female";
            else
            {
                MessageBox.Show("Please select a gender.");
                return;
            }

            int regNo;
            if (!int.TryParse(cmbRegNo.SelectedItem?.ToString(), out regNo))
            {
                MessageBox.Show("Please select a valid student.", "Update Student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = @"Data Source=DESKTOP-LHEPBPR;Initial Catalog=Student;Integrated Security=True;TrustServerCertificate=True";

            try
            {
                using (var con = new SqlConnection(connectionString))
                using (var cmd = con.CreateCommand())
                {
                    cmd.CommandText = @"
UPDATE [Registration]
SET [firstName] = @firstName,
    [lastName] = @lastName,
    [dateOfBirth] = @dateOfBirth,
    [gender] = @gender,
    [address] = @address,
    [email] = @email,
    [mobilePhone] = @mobilePhone,
    [homePhone] = @homePhone,
    [parentName] = @parentName,
    [nic] = @nic,
    [contactNo] = @contactNo
WHERE [regNo] = @regNo;";

                    cmd.Parameters.Add("@regNo", SqlDbType.Int).Value = regNo;
                    cmd.Parameters.Add("@firstName", SqlDbType.VarChar, 50).Value = txtFirstName.Text.Trim();
                    cmd.Parameters.Add("@lastName", SqlDbType.VarChar, 50).Value = txtLastName.Text.Trim();
                    cmd.Parameters.Add("@dateOfBirth", SqlDbType.DateTime).Value = dtpDOB.Value;
                    cmd.Parameters.Add("@gender", SqlDbType.VarChar, 6).Value = gender;
                    cmd.Parameters.Add("@address", SqlDbType.VarChar, 50).Value = txtAddress.Text.Trim();
                    cmd.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = txtEmail.Text.Trim();
                    cmd.Parameters.Add("@mobilePhone", SqlDbType.VarChar, 15).Value = txtMobile.Text.Trim();
                    cmd.Parameters.Add("@homePhone", SqlDbType.VarChar, 15).Value = txtHome.Text.Trim();
                    cmd.Parameters.Add("@parentName", SqlDbType.VarChar, 50).Value = txtParent.Text.Trim();
                    cmd.Parameters.Add("@nic", SqlDbType.VarChar, 50).Value = txtNIC.Text.Trim();
                    cmd.Parameters.Add("@contactNo", SqlDbType.VarChar, 15).Value = txtContact.Text.Trim();

                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                        MessageBox.Show("Record Updated Successfully", "Update Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("No record found with the given RegNo.", "Update Student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Update Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Delete_Click(object sender, EventArgs e)
        {

            if (!int.TryParse(cmbRegNo.SelectedItem?.ToString(), out int regNo))
            {
                MessageBox.Show("Please select a valid student to delete.", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            DialogResult result = MessageBox.Show(
                "Are you sure, Do you really want to Delete this Record...?",
                "Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                DeleteStudent(regNo);
            }

        }
        private void DeleteStudent(int regNo)
        {
            string connectionString = @"Data Source=DESKTOP-LHEPBPR;Initial Catalog=Student;Integrated Security=True;TrustServerCertificate=True";

            using (var con = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand("DELETE FROM Registration WHERE regNo = @regNo", con))
            {
                cmd.Parameters.Add("@regNo", SqlDbType.Int).Value = regNo;

                try
                {
                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Record Deleted Successfully", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ClearForm();           
                        LoadStudentRegNos();   
                    }
                    else
                    {
                        MessageBox.Show("No matching record found.", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
              
            }
        }
        private void ClearForm()
        {
            cmbRegNo.SelectedIndex = -1;
            txtFirstName.Clear();
            txtLastName.Clear();
            txtAddress.Clear();
            txtEmail.Clear();
            txtMobile.Clear();
            txtHome.Clear();
            txtParent.Clear();
            txtNIC.Clear();
            txtContact.Clear();
            dtpDOB.Value = DateTime.Today;
            rbMale.Checked = false;
            rbFemale.Checked = false;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            
            cmbRegNo.SelectedIndex = -1;
            cmbRegNo.Text = "";


            txtFirstName.Clear();
            txtLastName.Clear();
            txtAddress.Clear();
            txtEmail.Clear();
            txtMobile.Clear();
            txtHome.Clear();
            txtParent.Clear();
            txtNIC.Clear();
            txtContact.Clear();

            
            dtpDOB.Value = DateTime.Today;

            
            rbMale.Checked = false;
            rbFemale.Checked = false;
        }

        private void Exit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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

        private void Logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Hide();
        }

    }
}

