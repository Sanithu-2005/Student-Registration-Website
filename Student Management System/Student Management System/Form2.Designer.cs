namespace Student_Management_System
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
            this.Logout = new System.Windows.Forms.LinkLabel();
            this.Skills_International = new System.Windows.Forms.Label();
            this.Student_Registration = new System.Windows.Forms.GroupBox();
            this.Delete = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Register = new System.Windows.Forms.Button();
            this.Parent_Details = new System.Windows.Forms.GroupBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtNIC = new System.Windows.Forms.TextBox();
            this.txtParent = new System.Windows.Forms.TextBox();
            this.Contact_Number = new System.Windows.Forms.Label();
            this.NIC = new System.Windows.Forms.Label();
            this.Parent_Name = new System.Windows.Forms.Label();
            this.Contact_Details = new System.Windows.Forms.GroupBox();
            this.txtHome = new System.Windows.Forms.TextBox();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.Home_Phone = new System.Windows.Forms.Label();
            this.Mobile_Phone = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.Label();
            this.Basic_Details = new System.Windows.Forms.GroupBox();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.Gender = new System.Windows.Forms.Label();
            this.Date_of_Birth = new System.Windows.Forms.Label();
            this.Last_Name = new System.Windows.Forms.Label();
            this.First_Name = new System.Windows.Forms.Label();
            this.cmbRegNo = new System.Windows.Forms.ComboBox();
            this.Reg_No = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.LinkLabel();
            this.Student_Registration.SuspendLayout();
            this.Parent_Details.SuspendLayout();
            this.Contact_Details.SuspendLayout();
            this.Basic_Details.SuspendLayout();
            this.SuspendLayout();
            // 
            // Logout
            // 
            this.Logout.AutoSize = true;
            this.Logout.Location = new System.Drawing.Point(13, 4);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(48, 16);
            this.Logout.TabIndex = 0;
            this.Logout.TabStop = true;
            this.Logout.Text = "Logout";
            this.Logout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Logout_LinkClicked);
            // 
            // Skills_International
            // 
            this.Skills_International.AutoSize = true;
            this.Skills_International.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Skills_International.Location = new System.Drawing.Point(104, 9);
            this.Skills_International.Name = "Skills_International";
            this.Skills_International.Size = new System.Drawing.Size(300, 38);
            this.Skills_International.TabIndex = 1;
            this.Skills_International.Text = "Skills International";
            // 
            // Student_Registration
            // 
            this.Student_Registration.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Student_Registration.Controls.Add(this.Delete);
            this.Student_Registration.Controls.Add(this.Clear);
            this.Student_Registration.Controls.Add(this.Update);
            this.Student_Registration.Controls.Add(this.Register);
            this.Student_Registration.Controls.Add(this.Parent_Details);
            this.Student_Registration.Controls.Add(this.Contact_Details);
            this.Student_Registration.Controls.Add(this.Basic_Details);
            this.Student_Registration.Controls.Add(this.cmbRegNo);
            this.Student_Registration.Controls.Add(this.Reg_No);
            this.Student_Registration.Location = new System.Drawing.Point(16, 51);
            this.Student_Registration.Name = "Student_Registration";
            this.Student_Registration.Size = new System.Drawing.Size(497, 538);
            this.Student_Registration.TabIndex = 2;
            this.Student_Registration.TabStop = false;
            this.Student_Registration.Text = "Student Registration";
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(409, 489);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 40);
            this.Delete.TabIndex = 8;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(328, 489);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 40);
            this.Clear.TabIndex = 7;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(114, 489);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(75, 40);
            this.Update.TabIndex = 6;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Register
            // 
            this.Register.Location = new System.Drawing.Point(33, 489);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(75, 40);
            this.Register.TabIndex = 5;
            this.Register.Text = "Register";
            this.Register.UseVisualStyleBackColor = true;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // Parent_Details
            // 
            this.Parent_Details.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Parent_Details.Controls.Add(this.txtContact);
            this.Parent_Details.Controls.Add(this.txtNIC);
            this.Parent_Details.Controls.Add(this.txtParent);
            this.Parent_Details.Controls.Add(this.Contact_Number);
            this.Parent_Details.Controls.Add(this.NIC);
            this.Parent_Details.Controls.Add(this.Parent_Name);
            this.Parent_Details.Location = new System.Drawing.Point(33, 362);
            this.Parent_Details.Name = "Parent_Details";
            this.Parent_Details.Size = new System.Drawing.Size(451, 121);
            this.Parent_Details.TabIndex = 4;
            this.Parent_Details.TabStop = false;
            this.Parent_Details.Text = "Parent Details";
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(115, 91);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(100, 22);
            this.txtContact.TabIndex = 5;
            // 
            // txtNIC
            // 
            this.txtNIC.Location = new System.Drawing.Point(115, 63);
            this.txtNIC.Name = "txtNIC";
            this.txtNIC.Size = new System.Drawing.Size(100, 22);
            this.txtNIC.TabIndex = 4;
            // 
            // txtParent
            // 
            this.txtParent.Location = new System.Drawing.Point(115, 35);
            this.txtParent.Name = "txtParent";
            this.txtParent.Size = new System.Drawing.Size(329, 22);
            this.txtParent.TabIndex = 3;
            // 
            // Contact_Number
            // 
            this.Contact_Number.AutoSize = true;
            this.Contact_Number.Location = new System.Drawing.Point(6, 91);
            this.Contact_Number.Name = "Contact_Number";
            this.Contact_Number.Size = new System.Drawing.Size(103, 16);
            this.Contact_Number.TabIndex = 2;
            this.Contact_Number.Text = "Contact Number";
            // 
            // NIC
            // 
            this.NIC.AutoSize = true;
            this.NIC.Location = new System.Drawing.Point(12, 63);
            this.NIC.Name = "NIC";
            this.NIC.Size = new System.Drawing.Size(29, 16);
            this.NIC.TabIndex = 1;
            this.NIC.Text = "NIC";
            // 
            // Parent_Name
            // 
            this.Parent_Name.AutoSize = true;
            this.Parent_Name.Location = new System.Drawing.Point(11, 34);
            this.Parent_Name.Name = "Parent_Name";
            this.Parent_Name.Size = new System.Drawing.Size(86, 16);
            this.Parent_Name.TabIndex = 0;
            this.Parent_Name.Text = "Parent Name";
            // 
            // Contact_Details
            // 
            this.Contact_Details.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Contact_Details.Controls.Add(this.txtHome);
            this.Contact_Details.Controls.Add(this.txtMobile);
            this.Contact_Details.Controls.Add(this.txtEmail);
            this.Contact_Details.Controls.Add(this.txtAddress);
            this.Contact_Details.Controls.Add(this.Home_Phone);
            this.Contact_Details.Controls.Add(this.Mobile_Phone);
            this.Contact_Details.Controls.Add(this.Email);
            this.Contact_Details.Controls.Add(this.Address);
            this.Contact_Details.Location = new System.Drawing.Point(33, 222);
            this.Contact_Details.Name = "Contact_Details";
            this.Contact_Details.Size = new System.Drawing.Size(451, 134);
            this.Contact_Details.TabIndex = 3;
            this.Contact_Details.TabStop = false;
            this.Contact_Details.Text = "Contact Details";
            // 
            // txtHome
            // 
            this.txtHome.Location = new System.Drawing.Point(336, 90);
            this.txtHome.Name = "txtHome";
            this.txtHome.Size = new System.Drawing.Size(100, 22);
            this.txtHome.TabIndex = 7;
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(115, 90);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(100, 22);
            this.txtMobile.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(115, 56);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(329, 22);
            this.txtEmail.TabIndex = 5;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(116, 21);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(329, 22);
            this.txtAddress.TabIndex = 4;
            // 
            // Home_Phone
            // 
            this.Home_Phone.AutoSize = true;
            this.Home_Phone.Location = new System.Drawing.Point(244, 90);
            this.Home_Phone.Name = "Home_Phone";
            this.Home_Phone.Size = new System.Drawing.Size(86, 16);
            this.Home_Phone.TabIndex = 3;
            this.Home_Phone.Text = "Home Phone";
            // 
            // Mobile_Phone
            // 
            this.Mobile_Phone.AutoSize = true;
            this.Mobile_Phone.Location = new System.Drawing.Point(11, 91);
            this.Mobile_Phone.Name = "Mobile_Phone";
            this.Mobile_Phone.Size = new System.Drawing.Size(90, 16);
            this.Mobile_Phone.TabIndex = 2;
            this.Mobile_Phone.Text = "Mobile Phone";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(11, 56);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(41, 16);
            this.Email.TabIndex = 1;
            this.Email.Text = "Email";
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Location = new System.Drawing.Point(11, 22);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(58, 16);
            this.Address.TabIndex = 0;
            this.Address.Text = "Address";
            // 
            // Basic_Details
            // 
            this.Basic_Details.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Basic_Details.Controls.Add(this.rbFemale);
            this.Basic_Details.Controls.Add(this.rbMale);
            this.Basic_Details.Controls.Add(this.dtpDOB);
            this.Basic_Details.Controls.Add(this.txtLastName);
            this.Basic_Details.Controls.Add(this.txtFirstName);
            this.Basic_Details.Controls.Add(this.Gender);
            this.Basic_Details.Controls.Add(this.Date_of_Birth);
            this.Basic_Details.Controls.Add(this.Last_Name);
            this.Basic_Details.Controls.Add(this.First_Name);
            this.Basic_Details.Location = new System.Drawing.Point(33, 72);
            this.Basic_Details.Name = "Basic_Details";
            this.Basic_Details.Size = new System.Drawing.Size(451, 144);
            this.Basic_Details.TabIndex = 2;
            this.Basic_Details.TabStop = false;
            this.Basic_Details.Text = "Basic Details";
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(227, 105);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(74, 20);
            this.rbFemale.TabIndex = 8;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(116, 105);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(58, 20);
            this.rbMale.TabIndex = 7;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(115, 77);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(230, 22);
            this.dtpDOB.TabIndex = 6;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(115, 47);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 22);
            this.txtLastName.TabIndex = 5;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(115, 21);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 22);
            this.txtFirstName.TabIndex = 4;
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.Location = new System.Drawing.Point(11, 105);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(52, 16);
            this.Gender.TabIndex = 3;
            this.Gender.Text = "Gender";
            // 
            // Date_of_Birth
            // 
            this.Date_of_Birth.AutoSize = true;
            this.Date_of_Birth.Location = new System.Drawing.Point(11, 76);
            this.Date_of_Birth.Name = "Date_of_Birth";
            this.Date_of_Birth.Size = new System.Drawing.Size(79, 16);
            this.Date_of_Birth.TabIndex = 2;
            this.Date_of_Birth.Text = "Date of Birth";
            this.Date_of_Birth.Click += new System.EventHandler(this.label3_Click);
            // 
            // Last_Name
            // 
            this.Last_Name.AutoSize = true;
            this.Last_Name.Location = new System.Drawing.Point(11, 47);
            this.Last_Name.Name = "Last_Name";
            this.Last_Name.Size = new System.Drawing.Size(72, 16);
            this.Last_Name.TabIndex = 1;
            this.Last_Name.Text = "Last Name";
            // 
            // First_Name
            // 
            this.First_Name.AutoSize = true;
            this.First_Name.Location = new System.Drawing.Point(11, 18);
            this.First_Name.Name = "First_Name";
            this.First_Name.Size = new System.Drawing.Size(72, 16);
            this.First_Name.TabIndex = 0;
            this.First_Name.Text = "First Name";
            // 
            // cmbRegNo
            // 
            this.cmbRegNo.FormattingEnabled = true;
            this.cmbRegNo.Location = new System.Drawing.Point(148, 31);
            this.cmbRegNo.Name = "cmbRegNo";
            this.cmbRegNo.Size = new System.Drawing.Size(121, 24);
            this.cmbRegNo.TabIndex = 1;
            // 
            // Reg_No
            // 
            this.Reg_No.AutoSize = true;
            this.Reg_No.Location = new System.Drawing.Point(45, 34);
            this.Reg_No.Name = "Reg_No";
            this.Reg_No.Size = new System.Drawing.Size(54, 16);
            this.Reg_No.TabIndex = 0;
            this.Reg_No.Text = "Reg No";
            // 
            // Exit
            // 
            this.Exit.AutoSize = true;
            this.Exit.Location = new System.Drawing.Point(485, 592);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(28, 16);
            this.Exit.TabIndex = 3;
            this.Exit.TabStop = true;
            this.Exit.Text = "Exit";
            this.Exit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Exit_LinkClicked);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(541, 615);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Student_Registration);
            this.Controls.Add(this.Skills_International);
            this.Controls.Add(this.Logout);
            this.Name = "Form2";
            this.Text = "Student Registration - Skills International";
            this.Student_Registration.ResumeLayout(false);
            this.Student_Registration.PerformLayout();
            this.Parent_Details.ResumeLayout(false);
            this.Parent_Details.PerformLayout();
            this.Contact_Details.ResumeLayout(false);
            this.Contact_Details.PerformLayout();
            this.Basic_Details.ResumeLayout(false);
            this.Basic_Details.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel Logout;
        private System.Windows.Forms.Label Skills_International;
        private System.Windows.Forms.GroupBox Student_Registration;
        private System.Windows.Forms.GroupBox Parent_Details;
        private System.Windows.Forms.GroupBox Contact_Details;
        private System.Windows.Forms.GroupBox Basic_Details;
        private System.Windows.Forms.ComboBox cmbRegNo;
        private System.Windows.Forms.Label Reg_No;
        private System.Windows.Forms.Label Date_of_Birth;
        private System.Windows.Forms.Label Last_Name;
        private System.Windows.Forms.Label First_Name;
        private System.Windows.Forms.Label Home_Phone;
        private System.Windows.Forms.Label Mobile_Phone;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.Label Gender;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Register;
        private System.Windows.Forms.Label Contact_Number;
        private System.Windows.Forms.Label NIC;
        private System.Windows.Forms.Label Parent_Name;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtNIC;
        private System.Windows.Forms.TextBox txtParent;
        private System.Windows.Forms.TextBox txtHome;
        private System.Windows.Forms.LinkLabel Exit;
    }
}