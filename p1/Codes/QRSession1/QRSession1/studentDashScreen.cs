using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QRSession1
{
    public partial class studentDashScreen : Form
    {
        public new Form ParentForm { get; set; }
        public studentDashScreen(Form parentForm,string UserEmail)
        {
            InitializeComponent();
            labelWelStu.Text = "Welcome " + UserEmail;
        }

        private void btnBackStu_Click(object sender, EventArgs e)
        {
            backtoParent();
        }
        private void backtoParent()
        {
            Hide();
            ParentForm.Show();
        }
    }
}
