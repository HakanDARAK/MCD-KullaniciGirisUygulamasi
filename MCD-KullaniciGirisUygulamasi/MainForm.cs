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
    public partial class MainForm : Form
    {
        public MainForm(User userFound)
        {
            InitializeComponent();
            txtName.Text = userFound.name;
            txtLastName.Text = userFound.lastName;
            txtUserName.Text = userFound.userName;
            txtPassword.Text = userFound.password;
            txtPassword.Text = userFound.password;
            txtExplanation.Text = userFound.explanation;
            txtId.Text = userFound.id.ToString();
            txtId.Visible = false;
        }

        public void btnUpdate_Click(object sender, EventArgs e)
        {
            int _id = Convert.ToInt32(txtId.Text);
            int index = VirtualDataBase.Users.FindIndex(i => i.id == _id);
            VirtualDataBase.Users[index].name = txtName.Text;
            VirtualDataBase.Users[index].lastName = txtLastName.Text;
            VirtualDataBase.Users[index].userName = txtUserName.Text;
            VirtualDataBase.Users[index].password = txtPassword.Text;
            VirtualDataBase.Users[index].explanation = txtExplanation.Text;

            MessageBox.Show("Successfully Updated", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    }
}
