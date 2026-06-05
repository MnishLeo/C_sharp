using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace c_sharp_Basic.BasicProject
{
    public class BankAccount
    {
        private String AccountNumber { get; set;}
        public string AccountHolder { get; set; }
        public string Pin { get; private set; }
        public decimal Balance { get; private set; }
        public List<Transaction> Transactions { get; private set; }
        public string AccountType { get; set; }

        public BankAccount(string accountHolder , string pin, decimal initialBalance, string accountType)
        {
            AccountNumber = GenerateAccountNumber();
            AccountHolder = accountHolder;
            Pin = pin;
            Balance = initialBalance;
            AccountType = accountType;
            Transactions = new List<Transaction>();
        }


    }
}
