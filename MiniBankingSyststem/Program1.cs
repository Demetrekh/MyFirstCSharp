using System;
using System.Collections.Generic;
<<<<<<< HEAD
using MiniBankingSyststem;
public class Bankaccount
{
    private string accountNumber;
    private string ownerName;
    private double balance;

    // Constructor to initialize the bank account
    public Bankaccount(String accountNumber, String ownerName, double initialBalance)
    {
        this.accountNumber = accountNumber;
        this.ownerName = ownerName;
        this.balance = initialBalance;
        BankingSystem.accounts.Add(accountNumber, this);
    }

    // Method to deposit money into the account
    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine($"You deposited {amount} dollars, new balance: {balance}");
        }
        else
        {
            Console.WriteLine("Amount should be positive");
        }
    }

    // Method to withdraw money from the account
    public void withdraw(double amount)
    {
        if (amount < balance && balance > 0)
        {
            balance -= amount;
            Console.WriteLine($"You withdrew {amount} dollars, new balance: {balance}");
        }
        else if (amount > balance)
        {
            Console.WriteLine("withdrawal impossible!");
        }
        else
        {
            Console.WriteLine("Amount should be positive");
        }
    }

    //Check balance
    public void getBalance() { Console.WriteLine("your balance is {0}", balance); }

    //Show account details
    public void displayInfo() { 
        Console.WriteLine($"Account Number: {accountNumber}, Owner Name: {ownerName}, Balance: {balance}");
    }

    // Get the owner's name
    public string getOwnerName() {return ownerName; }
=======

namespace ADS
{
    class UnionFind
    {
        static Dictionary<int, TE> nodes = new Dictionary<int, TE>();

        static void Main1(string[] args)
        {
            int[] A = { 1, 2, 3, 4, 5, 6, 7, 8 };
            Treefy(A);

            Union(nodes[1], nodes[2]);

            Console.WriteLine(Find(nodes[1]).x);
        }
        static void Treefy(int[] A)
        {
            foreach (int x in A)
                MakeSet(x);

        }

        public static TE MakeSet(int x)
        {
            TE tr = new TE(x);
            tr.p = tr;
            tr.r = 0;
            nodes[x] = tr;
            return tr;
        }

        public static TE Find(TE x)
        {
            while (x.p != x)
                x = x.p;
            return x;
        }

        //path compression version
        public static TE FindWithCompression(TE x)
        {
            if (x.p != x)
                x.p = FindWithCompression(x.p);
            return x.p;
        }

        public static void Link(TE x, TE y)
        {
            if (x.r < y.r)
                x.p = y;
            else if (x.r > y.r)
                y.p = x;
            else
            {
                x.p = y;
                y.r++;
            }
        }

        public static void Union(TE x, TE y)
        {
            Link(Find(x), Find(y));
        }
    }

    class TE
     {
            public int x;
            public TE p;
            public int r;

            public TE(int x)
            {
                this.x = x;
            }
     }
    
>>>>>>> e6664d58eb9f999769188edbe2c6d9d1123caca6
}