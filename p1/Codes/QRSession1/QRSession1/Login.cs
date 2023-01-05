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
    public partial class Login : Form
    {
        public new Form ParentForm { get; set; }
        public Login(Form parentForm)
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
        
        private void backtoParent()
        {
            Hide();
            ParentForm.Show();
        }
        private void btnGoRegister_Click(object sender, EventArgs e)
        {
            var Registerr = new Register(this);
            Registerr.ParentForm = this;
            Hide();
            Registerr.ShowDialog();
            Show();
        }

        private void btnBackLogin_Click(object sender, EventArgs e)
        {
            backtoParent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (textBoxEmailLogin.TextLength == 0 || textBoxPasswordLogin.TextLength == 0)
            {
                MessageBox.Show("Please fill in your email and password");
            };
            using (var entity = new Session1Entitiess())
            {
                var UserEmail = entity.Users.Any(user_Email => user_Email.email == textBoxEmailLogin.Text);
                if (UserEmail == true)
                {
                    var userPass = entity.Users.Any(user_Pass => user_Pass.password == textBoxPasswordLogin.Text);
                    if (userPass == true)
                    {
                        var userType = entity.Users.Where(User => User.email== textBoxEmailLogin.Text)
                                .Select(User => User.user_type)  
                                .FirstOrDefault();
                        if (userType == "Tutor")
                        {
                       
                            MessageBox.Show("Tutor Login");
                            var TutDash = new tutorDashboardScreen(this,textBoxEmailLogin.Text);
                            TutDash.ParentForm = this;
                            Hide();
                            TutDash.ShowDialog();
                            Show();
                        }
                        else
                        {
                            MessageBox.Show("Stu login");
                            var stuDash = new studentDashScreen(this, textBoxEmailLogin.Text);
                            stuDash.ParentForm = this;
                            Hide();
                            stuDash.ShowDialog();
                            Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password and email does not match");
                    }
                    
                }
                else
                {
                    MessageBox.Show("Email not found, please register or try again");
                }

            };
        }
    }
}
