using CurrencyAppWithXML.Model;
using System;
using System.Linq;

namespace CurrencyAppWithXML
{
    public class Operations
    {
        DBCurrencyAppEntities db = new DBCurrencyAppEntities();

        public void GetAllCurrency()
        {
            GetCurrency getCurrency = new GetCurrency();
            getCurrency.SaveCurrencyDollar();
            getCurrency.SaveCurrencyEuro();
            getCurrency.SaveCurrencyPound();
        }

        public void CurrencyList()
        {
            var currencies = db.Currencies.ToList();

            Console.Clear();
            Console.WriteLine("List of Currencies:");
            foreach (var currency in currencies)
            {
                Console.WriteLine($"{currency.ID} - {currency.CurrencyName} - {currency.CurrencySymbol}");
            }
        }

        public void CurrentCurrency()
        {
            var currencyValues = db.CurrencyValues.ToList();

            Console.Clear();
            Console.WriteLine("Current Currencies:");
            foreach (var currencyValue in currencyValues)
            {
                Console.WriteLine($"Currency: {currencyValue.Currency.CurrencyName.Trim().PadRight(10)} Buy: {currencyValue.Buying} Sell: {currencyValue.Selling}");
            }
        }

        public void SellMenu()
        {
            Sale sale = new Sale();

            Console.Clear();
            Console.Write("CustomerName: ");
            string customerName = Console.ReadLine();

            int currencyCode;
            do
            {
                Console.WriteLine("1 - Dolar");
                Console.WriteLine("2 - Euro");
                Console.WriteLine("4 - Puond");
                Console.Write("CurrencyCode: ");
                currencyCode = Convert.ToInt32(Console.ReadLine());
            }
            while (!(currencyCode == 1 || currencyCode == 2 || currencyCode == 4));
            
            Console.WriteLine("Opetarion Type: Sell");
            string operaitonType = "Sell";
            
            CurrencyValue currencyValue = db.CurrencyValues.FirstOrDefault(x => x.CurrencyID == currencyCode);
            decimal currentCurrency = Convert.ToDecimal(currencyValue.Selling);
            Console.WriteLine($"Current Currency Value: {currentCurrency}");
            
            Console.Write("Amount: ");
            decimal amount = Convert.ToDecimal(Console.ReadLine());

            sale.MakeSale(customerName, currencyCode, operaitonType, currentCurrency, amount);
        }

        public void BuyMenu()
        {
            Buy buy = new Buy();

            Console.Clear();
            Console.Write("CustomerName: ");
            string customerName = Console.ReadLine();

            int currencyCode;
            do
            {
                Console.WriteLine("1 - Dolar");
                Console.WriteLine("2 - Euro");
                Console.WriteLine("4 - Puond");
                Console.Write("CurrencyCode: ");
                currencyCode = Convert.ToInt32(Console.ReadLine());
            }
            while (!(currencyCode == 1 || currencyCode == 2 || currencyCode == 4));

            Console.WriteLine("Opetarion Type: Buy");
            string operaitonType = "Buy";

            CurrencyValue currencyValue = db.CurrencyValues.FirstOrDefault(x => x.CurrencyID == currencyCode);
            decimal currentCurrency = Convert.ToDecimal(currencyValue.Buying);
            Console.WriteLine($"Current Currency Value: {currentCurrency}");

            Console.Write("Amount: ");
            decimal amount = Convert.ToDecimal(Console.ReadLine());

            buy.MakeBuy(customerName, currencyCode, operaitonType, currentCurrency, amount);
        }

        public void ListBuyings()
        {
            var buyings = db.Operations.Where(operations => operations.OperationType.Equals("Buy")).ToList();

            Console.Clear();
            foreach (var operation in buyings)
            { 
                Console.WriteLine(  $"{operation.CustomerName} - " +
                                    $"{operation.Currency.CurrencyName} - " +
                                    $"{operation.CurrentCurrencyValue} - " +
                                    $"{operation.Amout} - " +
                                    $"{operation.TotalPrice} - " +
                                    $"{operation.Date}");
            }
        }

        public void ListSells()
        {
            var sells = db.Operations.Where(operations => operations.OperationType.Equals("Sell")).ToList();

            Console.Clear();
            foreach (var operation in sells)
            {
                Console.WriteLine($"{operation.CustomerName} - " +
                                    $"{operation.Currency.CurrencyName} - " +
                                    $"{operation.CurrentCurrencyValue} - " +
                                    $"{operation.Amout} - " +
                                    $"{operation.TotalPrice} - " +
                                    $"{operation.Date}");
            }
        }

    }
}
