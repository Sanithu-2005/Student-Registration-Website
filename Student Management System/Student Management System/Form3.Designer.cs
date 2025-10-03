namespace Student_Management_System
{
    partial class Form3
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
            this.WELCOME = new System.Windows.Forms.Label();
            this.Head_To_Login = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // WELCOME
            // 
            this.WELCOME.AutoSize = true;
            this.WELCOME.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WELCOME.Location = new System.Drawing.Point(368, 60);
            this.WELCOME.Name = "WELCOME";
            this.WELCOME.Size = new System.Drawing.Size(256, 52);
            this.WELCOME.TabIndex = 0;
            this.WELCOME.Text = "WELCOME";
            // 
            // Head_To_Login
            // 
            this.Head_To_Login.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Head_To_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Head_To_Login.Location = new System.Drawing.Point(420, 372);
            this.Head_To_Login.Name = "Head_To_Login";
            this.Head_To_Login.Size = new System.Drawing.Size(154, 63);
            this.Head_To_Login.TabIndex = 1;
            this.Head_To_Login.Text = "Head to Login";
            this.Head_To_Login.UseVisualStyleBackColor = false;
            this.Head_To_Login.Click += new System.EventHandler(this.Head_To_Login_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Student_Management_System.Properties.Resources.Art;
            this.pictureBox1.Location = new System.Drawing.Point(273, 144);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(446, 197);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1020, 517);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Head_To_Login);
            this.Controls.Add(this.WELCOME);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WELCOME;
        private System.Windows.Forms.Button Head_To_Login;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}