namespace QRSession1
{
    partial class studentDashScreen
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
            this.btnBackStu = new System.Windows.Forms.Button();
            this.labelWelStu = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBackStu
            // 
            this.btnBackStu.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBackStu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBackStu.Location = new System.Drawing.Point(12, 12);
            this.btnBackStu.Name = "btnBackStu";
            this.btnBackStu.Size = new System.Drawing.Size(88, 41);
            this.btnBackStu.TabIndex = 0;
            this.btnBackStu.Text = "Back";
            this.btnBackStu.UseVisualStyleBackColor = false;
            this.btnBackStu.Click += new System.EventHandler(this.btnBackStu_Click);
            // 
            // labelWelStu
            // 
            this.labelWelStu.AutoSize = true;
            this.labelWelStu.Location = new System.Drawing.Point(106, 86);
            this.labelWelStu.Name = "labelWelStu";
            this.labelWelStu.Size = new System.Drawing.Size(42, 20);
            this.labelWelStu.TabIndex = 1;
            this.labelWelStu.Text = "label";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "TP SKILLS 2023";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(742, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Student Dashboard Screen";
            // 
            // studentDashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 1024);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelWelStu);
            this.Controls.Add(this.btnBackStu);
            this.Name = "studentDashScreen";
            this.Text = "studentDashScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBackStu;
        private System.Windows.Forms.Label labelWelStu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}