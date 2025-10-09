using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5.Bank_Account
{
    public partial class Form1 : Form
    {
        private SavingsAccount myAccount;

        public Form1()
        {
            InitializeComponent();

            myAccount = new SavingsAccount(0);
            lblStatus.Text = "Account created. Current Balance: 0.00";

        }

        private void buttonDeposit_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(numericUpDownAmount.Text, out decimal depositAmount) && depositAmount > 0)
            {
                myAccount.Deposit(depositAmount);
                decimal interestAdded = myAccount.AddInterest();
                lblStatus.Text = $"Deposited {depositAmount:C0} and added interest {interestAdded:C2}.\n" +
                             $"New Balance: {myAccount.Balance:C2}";
                numericUpDownAmount.Value = 0;
            }
            else
            {
                MessageBox.Show("Please enter a valid positive amount to deposit.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonBalance_Click(object sender, EventArgs e)
        {
            lblStatus.Text = $"Current Balance: {myAccount.Balance:C2}";
        }
    }
}
