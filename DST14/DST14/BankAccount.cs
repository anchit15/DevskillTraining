using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DST14
{
    //Publisher class. Event publisher
    internal class BankAccount
    {
        public delegate void AccountDelegate();
        public event AccountDelegate AccountEvent;

        public void WithdrawFromBankAccount(int amount)
        {
            AccountEvent();     //Invoke Event. throws the event and all methods inside works with this command
            Console.WriteLine("Withdrawn successfull");
            
        }
    }
}
