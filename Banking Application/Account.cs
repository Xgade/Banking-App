using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_Application
{
    internal class Account
    {
        List<Account> accounts = new List<Account>();
        public int accountNum;
        public string accountOwner; // Person class

        // constructor
        public Account(int accountNum, string accountOwner)
        {
            this.accountNum = accountNum;
            this.accountOwner = accountOwner;
        }
    }
}
