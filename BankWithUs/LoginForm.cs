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
            BankContext account = new BankContext();

            if( debitNum.Text != "" || pinNum.Text != "")
            {
                //FirstOrDefault checks for the first match of a(is like saying this)
                //Searches DataBase for if it exists
                Account userExist = account.Accounts.FirstOrDefault(a => a.DebitNum == debitNum.Text);

                //If a user with that debit card number DOES exist 
                if (doesUserExist(userExist) == true)
                {
                    //If that user with the same debit card also matches the password on file 
                    if (doesUserPinMatch(userExist, pinNum.Text) == true)
                    {
                        debitNum.Text = "";
                        pinNum.Text = "";

                        //Display a welcome message with their name
                        MessageBox.Show($"Welcome {userExist.FirstName} {userExist.LastName}");

                        AccountForm accForm = new AccountForm(userExist);
                        accForm.ShowDialog();

                    }
                }

            }
            else
            {
                MessageBox.Show("You must enter a debit number and pin to login");
            }

        }

        //bool to show if the pin matches
        private bool doesUserPinMatch(Account userExist, string text)
        {
            if (pinNum.Text.Length > 4)
            {
                MessageBox.Show("This pin is too long, it must be four digits");
            }
            if (userExist.AccountPin == pinNum.Text)
            {
                return true;
            }
            MessageBox.Show("Pin does not match");
            return false;
        }

        //Boolean to show if user exists
        private bool doesUserExist(Account userExist)
        {
            if (userExist != null)
            {
                return true;
            }
            MessageBox.Show("Account doesn't exist");
            return false;
        }

        private void regBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please enter your information on the next page to register");
            RegisterForm regForm = new RegisterForm();
            regForm.ShowDialog();
        }
    }
}
