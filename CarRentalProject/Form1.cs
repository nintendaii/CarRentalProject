using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalProject
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            if (tbLogin.Text=="1" && tbPassword.Text=="1")
            {
                this.Hide();
                MessageBox.Show("Ласкаво просимо!");
                mf.Show();
            }
            else
            {
                MessageBox.Show("Логін або пароль введено неправильно. Спробуйте ще раз");
            }
        }
    }
}
