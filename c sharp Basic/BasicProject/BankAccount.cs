using System;
using System.Collections.Generic;
using System.Linq;

namespace BankingApp
{
    // Account class to hold account data
    public class BankAccount
    {
        public string AccountNumber { get; private set; }
        public string AccountHolder { get; set; }
        public string Pin { get; private set; }
        public decimal Balance { get; private set; }
        public List<Transaction> Transactions { get; private set; }
        public string AccountType { get; set; } // "Checking" or "Savings"

        public BankAccount(string accountHolder, string pin, string accountType, decimal initialDeposit = 0)
        {
            AccountNumber = GenerateAccountNumber();
            AccountHolder = accountHolder;
            Pin = pin;
            AccountType = accountType;
            Balance = initialDeposit;
            Transactions = new List<Transaction>();

            if (initialDeposit > 0)
            {
                AddTransaction("Initial Deposit", initialDeposit);
            }
        }

        private string GenerateAccountNumber()
        {
            Random random = new Random();
            return random.Next(10000000, 99999999).ToString();
        }

        public bool Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Amount must be positive");
                return false;
            }

            Balance += amount;
            AddTransaction("Deposit", amount);
            Console.WriteLine($"Successfully deposited ${amount}. New balance: ${Balance}");
            return true;
        }

        public bool Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Amount must be positive");
                return false;
            }

            if (amount > Balance)
            {
                Console.WriteLine("Insufficient funds");
                return false;
            }

            Balance -= amount;
            AddTransaction("Withdrawal", -amount);
            Console.WriteLine($"Successfully withdrew ${amount}. New balance: ${Balance}");
            return true;
        }

        public bool Transfer(BankAccount toAccount, decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Amount must be positive");
                return false;
            }

            if (amount > Balance)
            {
                Console.WriteLine("Insufficient funds for transfer");
                return false;
            }

            Balance -= amount;
            toAccount.Balance += amount;

            AddTransaction($"Transfer to {toAccount.AccountNumber}", -amount);
            toAccount.AddTransaction($"Transfer from {AccountNumber}", amount);

            Console.WriteLine($"Successfully transferred ${amount} to account {toAccount.AccountNumber}");
            return true;
        }

        private void AddTransaction(string description, decimal amount)
        {
            Transactions.Add(new Transaction
            {
                Date = DateTime.Now,
                Description = description,
                Amount = amount,
                Balance = Balance
            });
        }

        public void ShowTransactionHistory()
        {
            Console.WriteLine($"\nTransaction History for {AccountHolder} ({AccountNumber})");
            Console.WriteLine("------------------------------------------------");
            foreach (var transaction in Transactions)
            {
                Console.WriteLine($"{transaction.Date:yyyy-MM-dd HH:mm} | {transaction.Description,-20} | ${transaction.Amount,10:F2} | Balance: ${transaction.Balance,10:F2}");
            }
        }

        public void ShowAccountInfo()
        {
            Console.WriteLine($"\nAccount Information:");
            Console.WriteLine($"Holder: {AccountHolder}");
            Console.WriteLine($"Account Number: {AccountNumber}");
            Console.WriteLine($"Type: {AccountType}");
            Console.WriteLine($"Balance: ${Balance:F2}");
        }

        public bool VerifyPin(string pin)
        {
            return Pin == pin;
        }
    }
    public class Transaction
    {
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public decimal Balance { get; set; }
    }

    class Program
    {
        private static Dictionary<string, BankAccount> accounts = new Dictionary<string, BankAccount>();
        private static BankAccount currentUser = null;

        static void Main(string[] args)
        {
            Console.Title = "Banking System";
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Welcome to Simple Banking System");
            Console.ResetColor();

            // Create some demo accounts
            CreateDemoAccounts();

            bool running = true;
            while (running)
            {
                if (currentUser == null)
                {
                    ShowMainMenu();
                }
                else
                {
                    ShowUserMenu();
                }
            }
        }

        static void CreateDemoAccounts()
        {
            var account1 = new BankAccount("John Doe", "1234", "Checking", 1000);
            var account2 = new BankAccount("Jane Smith", "5678", "Savings", 5000);
            accounts.Add(account1.AccountNumber, account1);
            accounts.Add(account2.AccountNumber, account2);
        }

        static void ShowMainMenu()
        {
            Console.WriteLine("\n=== MAIN MENU ===");
            Console.WriteLine("1. Login");
            Console.WriteLine("2. Create New Account");
            Console.WriteLine("3. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Login();
                    break;
                case "2":
                    CreateAccount();
                    break;
                case "3":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
        }

    }
}