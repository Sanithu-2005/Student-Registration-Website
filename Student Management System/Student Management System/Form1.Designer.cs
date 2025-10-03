namespace Student_Management_System
{
    partial class Form1
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
            this.SKILLS_INTERNATIONAL = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Login = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.textpassword = new System.Windows.Forms.TextBox();
            this.textusername = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SKILLS_INTERNATIONAL
            // 
            this.SKILLS_INTERNATIONAL.AutoSize = true;
            this.SKILLS_INTERNATIONAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SKILLS_INTERNATIONAL.Location = new System.Drawing.Point(47, 195);
            this.SKILLS_INTERNATIONAL.Name = "SKILLS_INTERNATIONAL";
            this.SKILLS_INTERNATIONAL.Size = new System.Drawing.Size(418, 38);
            this.SKILLS_INTERNATIONAL.TabIndex = 1;
            this.SKILLS_INTERNATIONAL.Text = "SKILLS INTERNATIONAL";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Login);
            this.groupBox1.Controls.Add(this.Clear);
            this.groupBox1.Controls.Add(this.textpassword);
            this.groupBox1.Controls.Add(this.textusername);
            this.groupBox1.Controls.Add(this.Password);
            this.groupBox1.Controls.Add(this.Username);
            this.groupBox1.Location = new System.Drawing.Point(54, 266);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 167);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.Location = new System.Drawing.Point(280, 124);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(75, 37);
            this.Login.TabIndex = 5;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = false;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.Location = new System.Drawing.Point(61, 124);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(72, 37);
            this.Clear.TabIndex = 4;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // textpassword
            // 
            this.textpassword.Location = new System.Drawing.Point(161, 83);
            this.textpassword.Name = "textpassword";
            this.textpassword.Size = new System.Drawing.Size(194, 22);
            this.textpassword.TabIndex = 3;
            // 
            // textusername
            // 
            this.textusername.Location = new System.Drawing.Point(164, 34);
            this.textusername.Name = "textusername";
            this.textusername.Size = new System.Drawing.Size(191, 22);
            this.textusername.TabIndex = 2;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(56, 81);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(98, 25);
            this.Password.TabIndex = 1;
            this.Password.Text = "Password";
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(56, 30);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(102, 25);
            this.Username.TabIndex = 0;
            this.Username.Text = "Username";
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Exit.Location = new System.Drawing.Point(12, 496);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 37);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Student_Management_System.Properties.Resources.skills_in;
            this.pictureBox1.Location = new System.Drawing.Point(177, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 167);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(532, 545);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SKILLS_INTERNATIONAL);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Login-Skill International";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label SKILLS_INTERNATIONAL;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.TextBox textpassword;
        private System.Windows.Forms.TextBox textusername;
        private System.Windows.Forms.Button Exit;
    }
}

