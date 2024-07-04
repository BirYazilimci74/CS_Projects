using System;
using System.Text;

namespace CurrencyAppWithXML
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Operations operations = new Operations();

            Console.WriteLine("Select the operation you want to do:");
            Console.WriteLine("1 - List Currencies");
            Console.WriteLine("2 - Current Currencies");
            Console.WriteLine("3 - Buy Currency");
            Console.WriteLine("4 - Sell Currency");
            Console.WriteLine("5 - List Currency Buying");
            Console.WriteLine("6 - List Currency Selling");
            Console.WriteLine("7 - Update Currency Data");
            Console.WriteLine("8 - Quit");
            Console.WriteLine();
            Console.Write("Operation:");
            
            int choose = Convert.ToInt32(Console.ReadLine());
            switch (choose)
            {
                case 1:
                    operations.CurrencyList();
                    break;
                case 2:
                    operations.CurrentCurrency();
                    break;
                case 3:
                    operations.BuyMenu();
                    break;
                case 4:
                    operations.SellMenu();
                    break;
                case 5:
                    operations.ListBuyings();
                    break;
                case 6:
                    operations.ListSells();
                    break;
                case 7:
                    operations.GetAllCurrency();
                    Console.WriteLine("Currencies updated successfuly!!!");
                    break;
                case 8:
                    Environment.Exit(1);
                    break;

            }
            Console.ReadLine();
        }
    }
}
