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

    public partial class Register : Form
    {
               public new Form ParentForm { get; set; }
        public Register(Form parentForm)
        {
            InitializeComponent();
            ParentForm = parentForm;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            backtoParent();
        }
        private void backtoParent()
        {
            Hide();
            ParentForm.Show();
        }

            

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var Valid = ValidInput();
   
           if (Valid == true)
            {
                var _email = textBoxEmail.Text.Trim();
                var _firstName = textBoxFirstName.Text.Trim();
                var _lastName = textBoxLastName.Text.Trim();
                var _password = textBoxPassword.Text.Trim();
                var _confirm = textBoxCfmPassword.Text.Trim();
                var _userType = "";
                if (checkBoxTutor.Checked == true)
                {
                    _userType = "Tutor";
                }
                else
                {
                    _userType = "Student";
                }


                using (var entity = new Session1Entitiess())
                {
                    entity.Users.Add(new User
                    {
                        email = _email,
                        first_name = _firstName,
                        last_name = _lastName,
                        password = _password,
                        user_type = _userType

                    });

                    entity.SaveChanges();
                }
                MessageBox.Show($"User {_email} has succesfully registered.Please Log in");
                var Loggin = new Login(this);
                Loggin.ParentForm = this;
                Hide();
                Loggin.ShowDialog();
                Show();
            }
           
        }
        public bool ValidInput()
        {
            if (textBoxFirstName.TextLength == 0 || textBoxLastName.TextLength == 0 ||textBoxPassword.TextLength==0)
            {
                MessageBox.Show("Please fill in the form");
                return false;
            }
            if (textBoxEmail.Text.Contains('@') == false)
            {
                MessageBox.Show("Please use a valid email");
                return false;
            }
            if (textBoxPassword.Text != textBoxCfmPassword.Text)
            {
                MessageBox.Show("Passwords must match");
                return false;
            }
            using (var entity = new Session1Entitiess())
            {
                var EmailDuplicates = entity.Users.Any(user => user.email == textBoxEmail.Text);
                if (EmailDuplicates == true)
                {
                    MessageBox.Show("Email in use, please login");
                    return false;
                }
                return true;

            };
            

        }
        
    }

}
