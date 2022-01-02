namespace NtpAutomation
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.lblUserName2 = new System.Windows.Forms.Label();
            this.lblPassword2 = new System.Windows.Forms.Label();
            this.lblPassword3 = new System.Windows.Forms.Label();
            this.tbxUserName2 = new System.Windows.Forms.TextBox();
            this.tbxPassword2 = new System.Windows.Forms.TextBox();
            this.tbxPassword3 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSignUp2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUserName2
            // 
            this.lblUserName2.AutoSize = true;
            this.lblUserName2.Location = new System.Drawing.Point(51, 46);
            this.lblUserName2.Name = "lblUserName2";
            this.lblUserName2.Size = new System.Drawing.Size(178, 35);
            this.lblUserName2.TabIndex = 1;
            this.lblUserName2.Text = "Kullanıcı Adı :";
            // 
            // lblPassword2
            // 
            this.lblPassword2.AutoSize = true;
            this.lblPassword2.Location = new System.Drawing.Point(144, 114);
            this.lblPassword2.Name = "lblPassword2";
            this.lblPassword2.Size = new System.Drawing.Size(85, 35);
            this.lblPassword2.TabIndex = 2;
            this.lblPassword2.Text = "Şifre :";
            // 
            // lblPassword3
            // 
            this.lblPassword3.AutoSize = true;
            this.lblPassword3.Location = new System.Drawing.Point(57, 182);
            this.lblPassword3.Name = "lblPassword3";
            this.lblPassword3.Size = new System.Drawing.Size(172, 35);
            this.lblPassword3.TabIndex = 3;
            this.lblPassword3.Text = "Şifre Tekrarı :";
            // 
            // tbxUserName2
            // 
            this.tbxUserName2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbxUserName2.Location = new System.Drawing.Point(246, 43);
            this.tbxUserName2.Name = "tbxUserName2";
            this.tbxUserName2.Size = new System.Drawing.Size(338, 40);
            this.tbxUserName2.TabIndex = 1;
            // 
            // tbxPassword2
            // 
            this.tbxPassword2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbxPassword2.Location = new System.Drawing.Point(246, 108);
            this.tbxPassword2.Name = "tbxPassword2";
            this.tbxPassword2.Size = new System.Drawing.Size(338, 40);
            this.tbxPassword2.TabIndex = 2;
            this.tbxPassword2.UseSystemPasswordChar = true;
            // 
            // tbxPassword3
            // 
            this.tbxPassword3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbxPassword3.Location = new System.Drawing.Point(246, 173);
            this.tbxPassword3.Name = "tbxPassword3";
            this.tbxPassword3.Size = new System.Drawing.Size(338, 40);
            this.tbxPassword3.TabIndex = 3;
            this.tbxPassword3.UseSystemPasswordChar = true;
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnSignUp2);
            this.panel1.Controls.Add(this.lblUserName2);
            this.panel1.Controls.Add(this.tbxPassword3);
            this.panel1.Controls.Add(this.lblPassword2);
            this.panel1.Controls.Add(this.tbxPassword2);
            this.panel1.Controls.Add(this.lblPassword3);
            this.panel1.Controls.Add(this.tbxUserName2);
            this.panel1.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(699, 346);
            this.panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(644, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // btnSignUp2
            // 
            this.btnSignUp2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSignUp2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignUp2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSignUp2.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSignUp2.Location = new System.Drawing.Point(435, 237);
            this.btnSignUp2.Name = "btnSignUp2";
            this.btnSignUp2.Size = new System.Drawing.Size(149, 53);
            this.btnSignUp2.TabIndex = 4;
            this.btnSignUp2.Text = "Üye Ol";
            this.btnSignUp2.UseVisualStyleBackColor = false;
            this.btnSignUp2.Click += new System.EventHandler(this.btnSignUp2_Click);
            this.btnSignUp2.MouseLeave += new System.EventHandler(this.btnSignUp2_MouseLeave);
            this.btnSignUp2.MouseHover += new System.EventHandler(this.btnSignUp2_MouseHover);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 347);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblUserName2;
        private System.Windows.Forms.Label lblPassword2;
        private System.Windows.Forms.Label lblPassword3;
        private System.Windows.Forms.TextBox tbxUserName2;
        private System.Windows.Forms.TextBox tbxPassword2;
        private System.Windows.Forms.TextBox tbxPassword3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSignUp2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}