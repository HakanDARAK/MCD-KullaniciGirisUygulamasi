using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCD_KullaniciGirisUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string _userName = txtUserName.Text;
            string _password = txtPassword.Text;

            User userFound = VirtualDataBase.Users.Find(i => i.userName == _userName && i.password == _password);
            if (userFound != null)
            {
                MainForm _mainForm = new MainForm(userFound);
                _mainForm.Show();


            }
            else
            {
                MessageBox.Show("Incorrect User information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtUserName_Enter(object sender, EventArgs e)
        {
            TextBox T1 = (TextBox)sender;
            T1.BackColor = Color.YellowGreen;
        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            TextBox T1 = (TextBox)sender;
            T1.BackColor = Color.White;
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            TextBox T1 = (TextBox)sender;
            T1.BackColor = Color.YellowGreen;
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            TextBox T1 = (TextBox)sender;
            T1.BackColor = Color.White;
        }
    }
}
