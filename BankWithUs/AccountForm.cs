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
    public partial class AccountForm : Form
    {
        // Field
        private Account _user;

        public AccountForm(Account userExist)
        {
            InitializeComponent();
            _user = userExist;
        }

        private void DepositBtn_Click(object sender, EventArgs e)
        {
            DepositForm depositForm = new DepositForm();
            depositForm.Show();
        }

        private void TransferBtn_Click(object sender, EventArgs e)
        {
            TransferForm transferForm = new TransferForm();
            transferForm.Show();
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            string logoutMsg = "Are you sure you want to logout?";

            DialogResult result = MessageBox.Show(caption: "Logout?",
                                                  text: logoutMsg,
                                                  buttons: MessageBoxButtons.YesNo,
                                                  icon: MessageBoxIcon.Question);

            if(result == DialogResult.Yes)
            {
                string thankYou = "Thank you for banking with us!";

                DialogResult exit = MessageBox.Show(caption: thankYou,
                                                    text: thankYou,
                                                    buttons: MessageBoxButtons.OK);

                Close();

            }
        }

        private void AccountForm_Load(object sender, EventArgs e)
        {
            double totalBal = _user.CheckingAmount + _user.SavingsAmount;

            AccountHolderInfoLbl.Text = _user.FirstName;
            AccountNumLbl.Text = _user.DebitNum;
            CheckingBalanceLbl.Text = _user.CheckingAmount.ToString();
            SavingsBalanceLbl.Text = _user.SavingsAmount.ToString();
            
            TotalBalanceLbl.Text = totalBal.ToString();
        }
    }
}
