using System;
using System.Collections.Generic;
using System.Text;

namespace MiniBankingSyststem
{
    internal class BankingSystem
    {
        public static Dictionary<string, Bankaccount> accounts = new Dictionary<string, Bankaccount>();
        public static void Main() {
            Bankaccount account1 = new Bankaccount("123456789", "John Doe", 1000);
            Bankaccount account2 = new Bankaccount("987654321", "Jane Smith", 500);
            Bankaccount account3 = new Bankaccount("555555555", "Alice Johnson", 2000);

            int choice;
            String accountNumber;
            Console.WriteLine("\n---Mini Banking System Menu!---");

            Console.WriteLine("Enter your Account Number: ");
            Start:
            accountNumber = Console.ReadLine();
            if (accounts.ContainsKey(accountNumber))
            {
                Console.WriteLine("Welcome, " + accounts[accountNumber].getOwnerName() + "!");
                do
                {

                    Console.WriteLine("1. Check Balance");
                    Console.WriteLine("2. Deposit");
                    Console.WriteLine("3. Withdraw");
                    Console.WriteLine("4. Display Account Information");
                    Console.WriteLine("5. Exit");
                    Console.WriteLine("Enter your choice");
                    choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Check Balance selected.");
                            accounts[accountNumber].getBalance();
                            break;
                        case 2:

                            Console.WriteLine("Enter amount to deposit: ");
                            double amount = double.Parse(Console.ReadLine());
                            accounts[accountNumber].Deposit(amount);
                            break;
                        case 3:
                            Console.WriteLine("Enter amount to withdraw: ");
                            double withdrawAmount = double.Parse(Console.ReadLine());
                            accounts[accountNumber].withdraw(withdrawAmount);
                            break;
                        case 4:
                            Console.WriteLine("Display Account Information selected.");
                            accounts[accountNumber].displayInfo();
                            break;
                        case 5:
                            Console.WriteLine("Thank you for using our banking system.Goodbye!");
                            break;
                    }
                } while (choice != 5);
            }
            else
            {
                Console.WriteLine("Account not found. Please try again.");
                goto Start;
            }

            

    {

            }
        }
    }
}
