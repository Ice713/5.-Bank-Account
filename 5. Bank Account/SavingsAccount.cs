using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5.Bank_Account
{
    internal class SavingsAccount : Account
    {
        private const decimal InterestRate = 0.05m;

        public SavingsAccount(decimal initialBalance = 0) : base(initialBalance)
        {
        }

        public decimal AddInterest()
        {
            decimal interest = Balance * InterestRate;
            Deposit(interest);
            MessageBox.Show($"Interest of {interest:C} added. New balance is {Balance:C}.", "Interest Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return interest;
        }
    }
}
