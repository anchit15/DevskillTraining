using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DST05
{
    internal class BankAccount
    {
        public string AccountName;
        public string AccountNumber;
        //private double AccountBalance=0;
        private double _Balance;

        //public double AccountBalance { get; set;}  //prop tab
        public double AccountBalance
        {
            get
            {
                return _Balance;
            }
            set
            {
                _Balance = value;
            }
        }
        //public double AccountBalance { get; private set;}

        /*public void SetAccountBalance(double amount)
        {
            AccountBalance+= amount;
            //Deposit Notification/SMS
        }*/

        /*public double GetAccountBalance()
        {
            return AccountBalance;
        }*/
    }
}
