namespace QRSession1
{
    partial class tutorDashboardScreen
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnBackTut = new System.Windows.Forms.Button();
            this.btnCreSubj = new System.Windows.Forms.Button();
            this.labelWelTut = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(54, 175);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(778, 348);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnBackTut
            // 
            this.btnBackTut.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBackTut.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBackTut.Location = new System.Drawing.Point(12, 12);
            this.btnBackTut.Name = "btnBackTut";
            this.btnBackTut.Size = new System.Drawing.Size(94, 38);
            this.btnBackTut.TabIndex = 1;
            this.btnBackTut.Text = "Back";
            this.btnBackTut.UseVisualStyleBackColor = false;
            this.btnBackTut.Click += new System.EventHandler(this.btnBackTut_Click);
            // 
            // btnCreSubj
            // 
            this.btnCreSubj.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCreSubj.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCreSubj.Location = new System.Drawing.Point(53, 122);
            this.btnCreSubj.Name = "btnCreSubj";
            this.btnCreSubj.Size = new System.Drawing.Size(192, 47);
            this.btnCreSubj.TabIndex = 2;
            this.btnCreSubj.Text = "Create Subject";
            this.btnCreSubj.UseVisualStyleBackColor = false;
            // 
            // labelWelTut
            // 
            this.labelWelTut.AutoSize = true;
            this.labelWelTut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelTut.Location = new System.Drawing.Point(49, 85);
            this.labelWelTut.Name = "labelWelTut";
            this.labelWelTut.Size = new System.Drawing.Size(72, 29);
            this.labelWelTut.TabIndex = 3;
            this.labelWelTut.Text = " label";
            // 
            // tutorDashboardScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 1024);
            this.Controls.Add(this.labelWelTut);
            this.Controls.Add(this.btnCreSubj);
            this.Controls.Add(this.btnBackTut);
            this.Controls.Add(this.dataGridView1);
            this.Name = "tutorDashboardScreen";
            this.Text = "tutorDashboardScreen";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnBackTut;
        private System.Windows.Forms.Button btnCreSubj;
        private System.Windows.Forms.Label labelWelTut;
    }
}