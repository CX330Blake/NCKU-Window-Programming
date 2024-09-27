using System.Linq;

public class HW2_1
{
    public static bool close = false;
    public static bool alert = false;
    public static int NumOfGoods;
    public static string[] GoodsName; // 商品名稱陣列
    public static int[] GoodsPrice; // 商品價格陣列
    public static int[] GoodsRemain; // 商品庫存陣列
    public static int[] GoodsSelled; // 商品售出陣列
    public static int Income = 0;
    public static void Main()
    {
        while (!close) { Menu(); }
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
        int choice = int.Parse(Console.ReadLine());
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
        Console.Write("請輸入今日總共有幾種商品要販售: ");
        NumOfGoods = int.Parse(Console.ReadLine());
        GoodsRemain = new int[NumOfGoods];
        GoodsName = new string[NumOfGoods];
        GoodsPrice = new int[NumOfGoods];
        GoodsSelled = new int[NumOfGoods];
        Console.Write("請依序輸入每一種商品的名稱: ");

        string input = Console.ReadLine();
        GoodsName = input.Split(' ');
        Console.Write("接下來，請你依序輸入每一個商品的價格: ");
        input = Console.ReadLine();
        GoodsPrice = input.Split(' ').Select(int.Parse).ToArray();
        Console.Write("\n輸入完成! 每一種商品的價格依序為: \n");
        for (int i = 0; i < NumOfGoods; i++)
        {
            Console.WriteLine(GoodsName[i] + " : " + GoodsPrice[i]);
        }
        Console.Write("\n最後，請你依序輸入每一個商品目前的庫存數量: ");
        GoodsRemain = new int[NumOfGoods];
        input = Console.ReadLine();
        GoodsRemain = input.Split(' ').Select(int.Parse).ToArray();
        Console.Write("\n輸入完成! 每一種商品的庫存數量依序為: \n");
        for (int i = 0; i < NumOfGoods; i++)
        {
            Console.WriteLine(GoodsName[i] + " : " + GoodsRemain[i]);
            if (GoodsRemain[i] <= 5)
            {
                alert = true;
            }
        }
        Console.WriteLine("\n開店程序完成，已開店\n");
    }
    public static void AddOrder()
    {
        Console.Write("請依序輸入此訂單每一種類的商品各需要買幾個: ");
        int[] NumToBuy = new int[NumOfGoods];
        NumToBuy = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int Cost = 0;

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
        Console.WriteLine("\n訂單成立!，總金額為: " + Cost);
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
            else if (Payment < Cost)
            {
                Console.Write("\n付款金額不足，請再輸入一次 (或輸入 -1 直接取消此筆訂單): ");
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
                        alert = true;
                    }
                }
                PaySuccess = true;
                Income += Cost;
            }
        }
    }
    public static void CheckStock()
    {
        if (alert)
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
        int[] temp = (int[])GoodsSelled.Clone();
        for (int i = 0; i < NumOfGoods; i++)
        {
            int Rank = i + 1;
            int MaxSelled = temp.Max();
            int idx = Array.IndexOf(temp, MaxSelled);
            Console.WriteLine("第 " + Rank + " 名" + GoodsName[idx] + " 共售出 " + MaxSelled + " 件");
            temp[idx] = -1;
        }
    }
    public static void CloseShop()
    {
        close = true;
    }
}