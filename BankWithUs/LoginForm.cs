using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankWithUs
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome!");
            AccountForm form = new AccountForm();
            form.ShowDialog();
        }

        private void regBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please enter your information on the next page to register");
            RegisterForm regForm = new RegisterForm();
            regForm.ShowDialog();
        }
    }
}
