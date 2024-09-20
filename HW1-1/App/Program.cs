using System;

public class Program
{
    static bool Exit = false;
    static int Balance = 10000;
    public static void Main(string[] args)
    {
        while (!Exit)
        {
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
        Console.WriteLine("[8] Exit");
        Console.Write("> Enter your option: ");

        int option = -1;
        try
        {
            option = int.Parse(Console.ReadLine());
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
            case 8:
                Exit = true;
                Console.WriteLine("> Thank you for using our service.");
                break;
            default:
                Console.WriteLine("> Invalid option. Please enter a valid number.");
                break;
        }
    }

    public static void ViewBalance() { Console.WriteLine("> Your balance is " + Balance); }
    public static void Withdraw()
    {
        Console.WriteLine("> Please enter the amount you want to withdraw: ");
        int Amount = int.Parse(Console.ReadLine());

        if (ValidAmount(Amount))
        {
            Balance -= Amount;
            Console.WriteLine("> Withdraw successful. Your new balance is: " + Balance);
        }
        else
        {
            return;
        }
    }
    public static void Deposit()
    {
        Console.WriteLine("> Please enter the amount you want to deposit: ");
        int Amount = int.Parse(Console.ReadLine());
        if (ValidAmount(Amount))
        {
            Balance += Amount;
            Console.WriteLine("> Deposit successful. Your new balance is: " + Balance);
        }
        else
        {
            return;
        }

    }
    public static void Transfer()
    {
        Console.WriteLine("> Please enter the account you want to transfer: ");
        int account = int.Parse(Console.ReadLine());
        if (ValidAccount(account))
        {
            Console.WriteLine("> Please enter the amount you want to transfer: ");
            int Amount = int.Parse(Console.ReadLine());

            if (ValidAmount(Amount))
            {
                int Fee = (int)Math.Floor(Amount * 0.1);
                int Total = Amount + Fee;
                Console.WriteLine("> Total (including fee)" + Total);
                if (ValidAmount(Total))
                {
                    Balance -= Total;
                    Console.WriteLine("> Transfer successful. Your new balance is: " + Balance);

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
}