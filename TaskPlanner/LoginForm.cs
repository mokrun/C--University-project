using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskPlanner
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void buttonLogin_Click(object sender, EventArgs e)
        {

            if (IsValid() == true) //password is not empty
             {
                int _passwordEntered = 0;
                try {_passwordEntered = Convert.ToInt32(PasswordTextbox.Text); }
                catch (Exception exception) { MessageBox.Show(exception.Message); }
             if (CheckPass(_passwordEntered) == true) //password checker allowed access
             {
                DialogResult = DialogResult.OK;
                    this.Close();
                }      
            }
        }

        private bool CheckPass(int enteringPass)
        {
            switch(enteringPass)
            {
                case 1:            //dad pass check
                    UserDatabase.SetActive(0);
                    return true;
                case 2:        //mom pass check
                    UserDatabase.SetActive(1);
                    return true;
                case 3:        //boy pass check
                    UserDatabase.SetActive(2);
                    return true;
                case 4:        //girl pass check
                    UserDatabase.SetActive(3);
                    return true;
                default:
                    MessageBox.Show("Incorrect password. Try again.");
                    return false;
            }
                
        }

        private bool IsValid() //empty field check
        {
            if (PasswordTextbox.Text == string.Empty)
            {
                MessageBox.Show("Password can't be empty");
                return false;
            }
            return true;
        }
    }
}
