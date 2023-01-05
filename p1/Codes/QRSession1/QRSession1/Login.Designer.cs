namespace QRSession1
{
    partial class Login
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnGoRegister = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxEmailLogin = new System.Windows.Forms.TextBox();
            this.textBoxPasswordLogin = new System.Windows.Forms.TextBox();
            this.btnBackLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLogin.Location = new System.Drawing.Point(319, 367);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(338, 47);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Log In";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnGoRegister
            // 
            this.btnGoRegister.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGoRegister.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGoRegister.Location = new System.Drawing.Point(319, 496);
            this.btnGoRegister.Name = "btnGoRegister";
            this.btnGoRegister.Size = new System.Drawing.Size(338, 47);
            this.btnGoRegister.TabIndex = 1;
            this.btnGoRegister.Text = "Register";
            this.btnGoRegister.UseVisualStyleBackColor = false;
            this.btnGoRegister.Click += new System.EventHandler(this.btnGoRegister_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(315, 417);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Forget Password.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(315, 473);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(360, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Not registered? Click on the resigter button below.";
            // 
            // textBoxEmailLogin
            // 
            this.textBoxEmailLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxEmailLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmailLogin.Location = new System.Drawing.Point(321, 178);
            this.textBoxEmailLogin.Name = "textBoxEmailLogin";
            this.textBoxEmailLogin.Size = new System.Drawing.Size(338, 41);
            this.textBoxEmailLogin.TabIndex = 6;
            // 
            // textBoxPasswordLogin
            // 
            this.textBoxPasswordLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPasswordLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPasswordLogin.Location = new System.Drawing.Point(321, 262);
            this.textBoxPasswordLogin.Name = "textBoxPasswordLogin";
            this.textBoxPasswordLogin.Size = new System.Drawing.Size(338, 41);
            this.textBoxPasswordLogin.TabIndex = 7;
            // 
            // btnBackLogin
            // 
            this.btnBackLogin.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnBackLogin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBackLogin.Location = new System.Drawing.Point(12, 12);
            this.btnBackLogin.Name = "btnBackLogin";
            this.btnBackLogin.Size = new System.Drawing.Size(108, 55);
            this.btnBackLogin.TabIndex = 8;
            this.btnBackLogin.Text = "Back";
            this.btnBackLogin.UseVisualStyleBackColor = false;
            this.btnBackLogin.Click += new System.EventHandler(this.btnBackLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Email";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 1024);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBackLogin);
            this.Controls.Add(this.textBoxPasswordLogin);
            this.Controls.Add(this.textBoxEmailLogin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGoRegister);
            this.Controls.Add(this.btnLogin);
            this.Name = "Login";
            this.Text = "LoginScrn";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnGoRegister;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxEmailLogin;
        private System.Windows.Forms.TextBox textBoxPasswordLogin;
        private System.Windows.Forms.Button btnBackLogin;
        private System.Windows.Forms.Label label1;
    }
}