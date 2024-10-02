using System.Linq;
using System.Text.RegularExpressions;


public class HW2_1
{
    public static bool Open = false;
    public static bool Close = false;
    public static bool Alert = false;
    public static int NumOfGoods;
    public static string[] GoodsName; // 商品名稱陣列
    public static int[] GoodsPrice; // 商品價格陣列
    public static int[] GoodsRemain; // 商品庫存陣列
    public static int[] GoodsSelled; // 商品售出陣列
    public static int Income = 0;
    public static Dictionary<string, List<int>> CustomerOrdersHistory = new Dictionary<string, List<int>>(); // 客戶訂單
    public static void Main()
    {
        while (!Close) { Menu(); }
    }
    public static void Menu()
    {
        Console.WriteLine("歡迎來到 NCKU 卡比商店交易系統");
        Console.WriteLine("======================================");
        Console.WriteLine("(1) 開店");
        Console.WriteLine("(2) 新增訂單");
        Console.WriteLine("(3) 查詢庫存");
        Console.WriteLine("(4) 查詢總收入");
        Console.WriteLine("(5) 計算人氣商品排名");
        Console.WriteLine("(6) 關店");
        Console.WriteLine("======================================");
        Console.Write("請輸入您現在想要進行的操作: ");
        int choice;
        try
        {
            choice = int.Parse(Console.ReadLine());

        }
        catch (FormatException)
        {
            Console.WriteLine("無效的輸入，請重新輸入");
            return;
        }
        if (!Open && choice != 1 && choice != 6)
        {
            Console.WriteLine("店尚未開啟，請先開店再執行其他操作");
            return;
        }
        switch (choice)
        {
            case 1:
                OpenShop();
                break;
            case 2:
                AddOrder();
                break;
            case 3:
                CheckStock();
                break;
            case 4:
                CheckIncome();
                break;
            case 5:
                Rank();
                break;
            case 6:
                CloseShop();
                break;
            default:
                Console.WriteLine("無效的選擇，請重新輸入");
                break;
        }
    }
    public static void OpenShop()
    {
        bool InputSuccess = false;
        while (!InputSuccess)
        {
            Console.Write("請輸入今日總共有幾種商品要販售: ");
            try
            {
                NumOfGoods = int.Parse(Console.ReadLine());
                InputSuccess = true;
            }
            catch
            {
                Console.WriteLine("請輸入合法的數字。");
            }
        }
        InputSuccess = false;


        GoodsRemain = new int[NumOfGoods];
        GoodsName = new string[NumOfGoods];
        GoodsPrice = new int[NumOfGoods];
        GoodsSelled = new int[NumOfGoods];

        while (!InputSuccess)
        {
            Console.Write("請依序輸入每一種商品的名稱，以空格隔開: ");
            try
            {
                string InputGoodsName = Console.ReadLine();
                GoodsName = InputGoodsName.Split(' ');
                if (GoodsName.Length != NumOfGoods)
                {
                    Console.WriteLine("商品總數與先前輸入的不符，請重新輸入。");
                    continue;
                }
                else
                {
                    InputSuccess = true;
                }
            }
            catch
            {
                Console.WriteLine("請輸入合法的字串，並用空格隔開。");
            }

        }
        InputSuccess = false;

        while (!InputSuccess)
        {
            Console.Write("接下來，請你依序輸入每一個商品的價格: ");
            try
            {
                string InputCosts = Console.ReadLine();
                GoodsPrice = InputCosts.Split(' ').Select(int.Parse).ToArray();
                if (GoodsPrice.Length != NumOfGoods)
                {
                    Console.WriteLine("商品總數與先前輸入的不符，請重新輸入。");
                    continue;
                }
                else
                {
                    InputSuccess = true;
                }
            }
            catch
            {
                Console.WriteLine("請輸入合法的數字，並用空格隔開。");
            }

        }
        InputSuccess = false;
        Console.Write("\n輸入完成! 每一種商品的價格依序為: \n");
        for (int i = 0; i < NumOfGoods; i++)
        {
            Console.WriteLine(GoodsName[i] + " : " + GoodsPrice[i]);
        }

        GoodsRemain = new int[NumOfGoods];

        while (!InputSuccess)
        {
            Console.Write("\n最後，請你依序輸入每一個商品目前的庫存數量: ");
            try
            {
                String InputCount = Console.ReadLine();
                GoodsRemain = InputCount.Split(' ').Select(int.Parse).ToArray();
                if (GoodsRemain.Length != NumOfGoods)
                {
                    Console.WriteLine("商品總數與先前輸入的不符，請重新輸入。");
                    continue;
                }
                else { InputSuccess = true; }
            }
            catch
            {
                Console.WriteLine("請輸入合法的數字，並用空格隔開。");
            }
        }

        Console.Write("\n輸入完成! 每一種商品的庫存數量依序為: \n");
        for (int i = 0; i < NumOfGoods; i++)
        {
            Console.WriteLine(GoodsName[i] + " : " + GoodsRemain[i]);
            if (GoodsRemain[i] <= 5)
            {
                Alert = true;
            }
        }
        Console.WriteLine("\n開店程序完成，已開店\n");
        Open = true;
    }
    public static void AddOrder()
    {
        bool OrderSuccess = false;
        int[] NumToBuy = new int[NumOfGoods];
        int Cost = 0;
        bool FirstWrong = true;
        while (!OrderSuccess)
        {
            Console.Write("請依序輸入此訂單每一種類的商品各需要買幾個: ");
            NumToBuy = new int[NumOfGoods];
            NumToBuy = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            if (NumToBuy[0] == -1 && !FirstWrong)
            {
                Console.WriteLine("訂單取消\n");
                return;
            }

            if (NumToBuy.Length != NumOfGoods)
            {
                Console.WriteLine("商品數量不正確，請重新輸入 (或輸入 -1 直接取消此筆訂單)");
                FirstWrong = false;
            }
            else if (NumToBuy.Any(x => x < 0))
            {
                Console.WriteLine("商品數量不能為負值，請重新輸入 (或輸入 -1 直接取消此筆訂單)");
                FirstWrong = false;
            }
            else
            {
                for (int i = 0; i < NumOfGoods; i++)
                {
                    if (NumToBuy[i] > GoodsRemain[i])
                    {
                        Console.WriteLine("\n庫存不足，此筆訂單不成立\n");
                        return;
                    }
                    else
                    {
                        Cost += GoodsPrice[i] * NumToBuy[i];
                    }
                }
                OrderSuccess = true;
            }
        }

        Console.WriteLine("\n訂單成立!，總金額為: " + Cost);
        if (Cost >= 1000)
        {
            Random random = new Random();
            int Discount = random.Next(1, 9);
            Cost = (int)(Cost * (Discount / 10.0));
            Console.WriteLine("消費滿千元，優惠折扣為 " + Discount + " 折，總金額為: " + Cost);
        }
        Console.Write("請輸入消費者付款金額: ");

        int Payment;
        bool PaySuccess = false;

        while (!PaySuccess)
        {
            Payment = int.Parse(Console.ReadLine());
            if (Payment == -1)
            {
                Console.WriteLine("訂單取消\n");
                return;
            }
            else if (Payment < 0)
            {
                Console.Write("付款金額不能為負值，請重新輸入 (或輸入 -1 直接取消此筆訂單): ");
                FirstWrong = false;
                continue;
            }

            if (Payment < Cost)
            {
                Console.Write("\n付款金額不足，請再輸入一次 (或輸入 -1 直接取消此筆訂單): ");
                FirstWrong = false;
            }
            else
            {
                int Change = Payment - Cost;
                Console.WriteLine("\n付款完成! 請找零消費者共 " + Change);
                for (int i = 0; i < NumOfGoods; i++)
                {
                    GoodsRemain[i] -= NumToBuy[i];
                    GoodsSelled[i] += NumToBuy[i];
                    if (GoodsRemain[i] <= 5)
                    {
                        Alert = true;
                    }
                }
                PaySuccess = true;
                Income += Cost;
            }
        }
        bool InputNameSuccess = false;
        string Name = "";
        while (!InputNameSuccess)
        {
            Console.Write("請輸入您的姓名: ");
            Name = Console.ReadLine();
            // 判斷姓名是否為英文字符及空格
            if (Regex.IsMatch(Name, @"^[a-zA-Z\s]+$"))
            {
                AddCustomerOrder(Name, Cost);
                InputNameSuccess = true;
            }
            else
            {
                Console.WriteLine("姓名只能包含英文字符及空格。");
            }
        }
    }
    public static void CheckStock()
    {
        if (Alert)
        {
            Console.WriteLine("有商品的庫存量不足！！");
        }
        else
        {
            for (int i = 0; i < NumOfGoods; i++)
            {
                Console.WriteLine(GoodsName[i] + ": " + GoodsRemain[i]);
            }
        }
    }
    public static void CheckIncome()
    {
        Console.WriteLine("總收入為: " + Income);
    }
    public static void Rank()
    {
        int[] Temp = (int[])GoodsSelled.Clone();
        for (int i = 0; i < NumOfGoods; i++)
        {
            int Rank = i + 1;
            int MaxSelled = Temp.Max();
            int idx = Array.IndexOf(Temp, MaxSelled);
            Console.WriteLine("第 " + Rank + " 名" + GoodsName[idx] + " 共售出 " + MaxSelled + " 件");
            Temp[idx] = -1;
        }
    }
    public static void CloseShop()
    {
        Close = true;
    }

    public static void AddCustomerOrder(string Name, int Cost)
    {
        if (!CustomerOrdersHistory.ContainsKey(Name))
        {
            CustomerOrdersHistory[Name] = new List<int>();
        }
        CustomerOrdersHistory[Name].Add(Cost);
        int MaxOrder = CustomerOrdersHistory[Name].Max();
        Console.WriteLine(Name + "歷史最大訂單金額為 " + MaxOrder);
        var RecentOrders = CustomerOrdersHistory[Name].TakeLast(3).Reverse().ToList();
        if (RecentOrders.Count < 3)
        {
            RecentOrders.Add(0);
            RecentOrders.Add(0);
            RecentOrders.Add(0);
        }
        Console.WriteLine("最近三筆交易紀錄: ");
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("第" + (i + 1) + "筆: " + RecentOrders[i]);
        }
    }
}