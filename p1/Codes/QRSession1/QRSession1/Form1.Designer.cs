namespace QRSession1
{
    partial class MainMenu
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
            this.labelTpSkills = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnResgister = new System.Windows.Forms.Button();
            this.labelMainMenu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTpSkills
            // 
            this.labelTpSkills.AutoSize = true;
            this.labelTpSkills.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTpSkills.Location = new System.Drawing.Point(12, 9);
            this.labelTpSkills.Name = "labelTpSkills";
            this.labelTpSkills.Size = new System.Drawing.Size(144, 22);
            this.labelTpSkills.TabIndex = 0;
            this.labelTpSkills.Text = "TP SKILLS 2023";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnLogin.Location = new System.Drawing.Point(396, 414);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(282, 62);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Log in";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnResgister
            // 
            this.btnResgister.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnResgister.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnResgister.Location = new System.Drawing.Point(396, 345);
            this.btnResgister.Name = "btnResgister";
            this.btnResgister.Size = new System.Drawing.Size(282, 63);
            this.btnResgister.TabIndex = 3;
            this.btnResgister.Text = "Register";
            this.btnResgister.UseVisualStyleBackColor = false;
            this.btnResgister.Click += new System.EventHandler(this.btnResgister_Click);
            // 
            // labelMainMenu
            // 
            this.labelMainMenu.AutoSize = true;
            this.labelMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMainMenu.Location = new System.Drawing.Point(949, 9);
            this.labelMainMenu.Name = "labelMainMenu";
            this.labelMainMenu.Size = new System.Drawing.Size(97, 22);
            this.labelMainMenu.TabIndex = 4;
            this.labelMainMenu.Text = "Main Menu";
            // 
            // MainMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1058, 924);
            this.Controls.Add(this.labelMainMenu);
            this.Controls.Add(this.btnResgister);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.labelTpSkills);
            this.Name = "MainMenu";
            this.Text = "Main Screen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTpSkills;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnResgister;
        private System.Windows.Forms.Label labelMainMenu;
    }
}

