using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Bankomat.Banc_namespace;
using Bankomat.Account_namespace;

namespace Bankomat.Client_namespace
{
    class Client
    {
        Banc bank;
        Account account;

        public Client(Banc bank)
        {
            this.bank = bank;
            account = new Account();
            bank.AddAccount(account.number);
            Console.WriteLine($"Account created successfully!");
            Console.WriteLine(account);
            Console.WriteLine($"Your password - {account.GetPassword()}");
        }

        public void UseATM()
        {
            Console.WriteLine("Enter your password:");
            int attempts = 3;

            while (attempts > 0)
            {
                int inputPassword = int.Parse(Console.ReadLine());
                if (account.CheckPassword(inputPassword))
                {
                    Console.WriteLine("Access granted!");
                    ShowMenu();
                    return;
                }
                else
                {
                    attempts--;
                    Console.WriteLine($"Wrong password! Attempts remaining: {attempts}");
                }
            }
            Console.WriteLine("Access denied. Please contact the bank.");
        }

        private void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine("\n--- ATM Menu ---");
                Console.WriteLine("1. Check Balance");
                Console.WriteLine("2. Deposit Money");
                Console.WriteLine("3. Withdraw Money");
                Console.WriteLine("4. Exit");
                Console.Write("Select an option: ");
                string choice = Console.ReadLine();
                int amount;

                switch (choice)
                {
                    case "1":
                        int balance = bank.GetMoney(account.number);
                        if (balance >= 0)
                            Console.WriteLine($"Your current balance is: {balance} UAH");
                        else
                            Console.WriteLine("Error retrieving balance.");
                        break;
                    case "2":
                        Console.Write("Enter the amount to deposit: ");
                        amount = int.Parse(Console.ReadLine());
                        if (amount > 0)
                        {
                            bank.AddMoney(account.number, amount);
                            Console.WriteLine($"Successfully deposited {amount} UAH.");
                        }
                        else
                        {
                            Console.WriteLine("Invalid amount.");
                        }
                        break;
                    case "3":
                        Console.Write("Enter the amount to withdraw: ");
                        amount = int.Parse(Console.ReadLine());
                        if (amount > 0)
                        {
                            bool success = bank.MinusMoney(account.number, amount);
                            if (success)
                            {
                                Console.WriteLine($"Successfully withdrew {amount} UAH.");
                            }
                            else
                            {
                                Console.WriteLine("Insufficient funds or error processing transaction.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid amount.");
                        }
                        break;
                    case "4":
                        Console.WriteLine("Thank you for using our ATM. Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

    }
}
