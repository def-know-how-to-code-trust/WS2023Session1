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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var Loggin = new Login(this);
            Loggin.ParentForm = this;
            Hide();
            Loggin.ShowDialog();
            Show();

        }

        private void btnResgister_Click(object sender, EventArgs e)
        {
            
            var Registerr = new Register(this);
            Registerr.ParentForm= this;
            Hide();
            Registerr.ShowDialog();
            Show();
        }

        
    }
}
