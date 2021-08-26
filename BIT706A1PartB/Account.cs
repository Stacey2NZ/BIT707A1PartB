using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIT706A1PartB
{
    class Account
    {
        private double balance;
        private string accountName;
        private double depositAmount;
        private double withdraAmount;
        private int accountID;
        private double interestRate;
        private double failFee;

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

    }
}
