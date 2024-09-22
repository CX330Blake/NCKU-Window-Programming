﻿using System;

public class Program
{
    static bool Exit = false;
    static bool Login = false;
    static int CurrentAccountIndex = 0; // Account num - 10000
    static int AccountCount = 0;
    static int[] RegisteredAccounts = new int[90000]; // 99999 - 10000 + 1
    static int[] AccountBalances = Enumerable.Repeat(10000, 90000).ToArray();
    static int Balance = AccountBalances[CurrentAccountIndex];
    static int TotalDonation = 0;
    static int LovePoints = 0;
    static List<int> History = new List<int>();

    public static void Main(string[] args)
    {
        InitAccounts();
        while (!Exit)
        {
            while (!Login)
            {
                Console.WriteLine("Please enter your account number: ");
                int Account = Str2Int(Console.ReadLine());
                if (Register(Account))
                {
                    Login = true;
                    CurrentAccountIndex = Account - 10000;
                }
            }
            Menu();
        }
    }

    public static void Menu()
    {
        Console.WriteLine("\n==== MENU ====");
        Console.WriteLine("[0] View balance");
        Console.WriteLine("[1] Withdraw");
        Console.WriteLine("[2] Deposit");
        Console.WriteLine("[3] Transfer");
        Console.WriteLine("[4] Donate");
        Console.WriteLine("[5] Trade history");
        Console.WriteLine("[8] Exit");
        Console.Write("> Enter your option: ");

        int option = -1;
        try
        {
            option = Str2Int(Console.ReadLine());
            Console.WriteLine("\n");
        }
        catch (FormatException)
        {
            Console.WriteLine("> Invalid input. Please enter a valid number.");
            return;
        }
        switch (option)
        {
            case 0:
                ViewBalance();
                break;
            case 1:
                Withdraw();
                break;
            case 2:
                Deposit();
                break;
            case 3:
                Transfer();
                break;
            case 4:
                Donate();
                break;
            case 5:
                TradeHistory();
                break;
            case 8:
                Exit = true;
                Console.WriteLine("> Thank you for using our service.");
                break;
            case 65304:
                SecretOption();
                break;
            default:
                Console.WriteLine("> Invalid option. Please enter a valid number.");
                break;
        }
    }

    public static void ViewBalance() { Console.WriteLine("> Your balance is " + Balance); }
    public static void Withdraw()
    {
        History.Add(1);
        Console.WriteLine("> Please enter the amount you want to withdraw: ");
        int Amount = Str2Int(Console.ReadLine());

        if (ValidAmount(Amount))
        {
            Balance -= Amount;
            Console.WriteLine("> Withdraw successful. Your new balance is: " + Balance);
            History.Add(Balance);
        }
        else
        {
            return;
        }


    }
    public static void Deposit()
    {
        History.Add(2);
        Console.WriteLine("> Please enter the amount you want to deposit: ");
        int Amount = Str2Int(Console.ReadLine());
        if (ValidAmount(Amount))
        {
            Balance += Amount;
            Console.WriteLine("> Deposit successful. Your new balance is: " + Balance);
            History.Add(Balance);
        }
        else
        {
            return;
        }

    }
    public static void Transfer()
    {
        History.Add(3);
        Console.WriteLine("> Please enter the account you want to transfer: ");
        int account = Str2Int(Console.ReadLine());
        if (ValidAccount(account))
        {
            Console.WriteLine("> Please enter the amount you want to transfer: ");
            int Amount = Str2Int(Console.ReadLine());

            if (ValidAmount(Amount))
            {
                int Fee = (int)Math.Floor(Amount * 0.1);
                int Total = Amount + Fee;
                Console.WriteLine("> Total (including fee)" + Total);
                if (ValidAmount(Total))
                {
                    Balance -= Total;
                    Console.WriteLine("> Transfer successful. Your new balance is: " + Balance);
                    History.Add(Balance);
                }
                else
                {
                    Console.WriteLine("> Insufficient balance. Please deposit more.");
                }
            }
            else
            {
                return;
            }
        }

    }

    public static void Donate()
    {
        History.Add(4);
        Console.WriteLine("> Please enter the amount you want to donate: ");
        int Amount = Str2Int(Console.ReadLine());
        if (ValidAmount(Amount))
        {
            TotalDonation += Amount;
            Balance -= Amount;
            Console.WriteLine("> Donation successful. Your new balance is: " + Balance);
            LovePoints += TotalDonation / 1000;
            TotalDonation = TotalDonation % 1000;
            Console.WriteLine("> You have " + LovePoints + " love points now.");
            History.Add(Balance);
        }
        else
        {
            return;
        }
    }
    public static void TradeHistory()
    {
        Console.WriteLine("> Your trade history:");
        for (int i = 0; i < History.Count; i += 2)
        {
            Console.WriteLine(History[i] + " - " + History[i + 1]);
        }
    }
    public static bool ValidAmount(int Amount)
    {
        if (0 > Amount || Amount > 100000 || Amount > Balance)
        {
            Console.WriteLine("> Invalid input. Please enter a number between 0 to 100000.");
            return false;
        }
        else
        {
            return true;
        }
    }
    public static bool ValidAccount(int Account)
    {
        if (0 > Account || Account > 100000)
        {
            Console.WriteLine("> Invalid input. Please enter a number between 0 to 100000.");
            return false;
        }
        else
        {
            return true;
        }
    }
    public static int Str2Int(string str)
    {
        try
        {
            return int.Parse(str);
        }
        catch (FormatException)
        {
            Console.WriteLine("> Invalid input. Please enter a valid number.");
            return -1;
        }
    }

    public static bool AccountExists(int Account)
    {
        int index = Array.IndexOf(RegisteredAccounts, Account);
        if (index == -1)
        {
            return false;
        }
        else
        {
            Console.WriteLine("> Account already exists. Please enter a different account number.");
            return true;
        }
    }


    public static void InitAccounts()
    {
        for (int i = 10; i < 20; i++)
        {
            Register(i * 1000);
        }
    }
    public static bool Register(int Account)
    {
        if (ValidAccount(Account) && !AccountExists(Account))
        {
            RegisteredAccounts[AccountCount] = Account;
            AccountCount++;
            return true;
        }
        return false;
    }

    public static void SecretOption()
    {
        for (int i = 0; i < 90000; i++)
        {

        }
    }
}