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

        private String GenerateAccountNumber()
        {
            Random random = new Random();
            return random.Next(10000000, 99999999).ToString();
        }

        public bool deposit(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Amount must be greater than zero.");
                return false;
            }
            Balance += amount;
            AddTransaction("Deposit", amount);
            Console.WriteLine($"Successfully deposited ${amount}. New balance: ${Balance}");
            return true;
        }

        public bool withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Amount must be greater than zero.");
                return false;
            }
            if (amount > Balance)
            {
                Console.WriteLine("Insufficient funds.");
                return false;
            }
            Balance -= amount;
            AddTransaction("Withdrawal", amount);
            Console.WriteLine($"Successfully withdrew ${amount}. New balance: ${Balance}");
            return true;
        }
    }
}
