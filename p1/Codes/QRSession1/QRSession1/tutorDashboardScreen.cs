using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QRSession1
{
    public partial class tutorDashboardScreen : Form
    {
        string usrEmail;
 
        public new Form ParentForm { get; set; }
        public tutorDashboardScreen(Form parentForm, string UserEmail)
        {
            InitializeComponent();
            usrEmail = UserEmail;
            labelWelTut.Text = "Welcome " +UserEmail;
            UpdateGridView();
        }
   
        private void tutDash_Load()
        {
            
            tutDash_Load();
          
        }
       
        private void backtoParent()
        {
            Hide();
            ParentForm.Show();
        }

        private void btnBackTut_Click(object sender, EventArgs e)
        {
            backtoParent();
        }
        public void UpdateGridView()
        {
            using (var entity = new Session1Entitiess())
            {
                dataGridView1.DataSource = entity.Subjects.ToList();
            }
        }
    }
}
