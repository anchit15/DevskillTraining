using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DST14
{
    //Subscriber class
    internal class Transaction
    {
        private BankAccount _account;
        public Transaction()
        {
            _account = new BankAccount();
        }

        public void SendEmail()
        {
            Console.WriteLine("Email Sent");
        }
        public void SendSms()
        {
            Console.WriteLine("SMS Sent");
        }

        public void WithdrawTransaction(int amount)
        {
            //_account.WithdrawFromBankAccount(amount);
            _account.AccountEvent += SendEmail;     //subscribing method to event
            _account.AccountEvent += SendSms;
            _account.WithdrawFromBankAccount(amount);
        }
    }
}
