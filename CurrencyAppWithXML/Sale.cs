using CurrencyAppWithXML.Model;
using System;

namespace CurrencyAppWithXML
{
    public class Sale
    {
        DBCurrencyAppEntities db = new DBCurrencyAppEntities();
        public void MakeSale(string customerName, int currencyID, string operationType, decimal currentCurrencyValue, decimal amount)
        {
            Operation operation = new Operation();

            operation.CustomerName = customerName;
            operation.CurrencyID = currencyID;
            operation.OperationType = operationType;
            operation.CurrentCurrencyValue = currentCurrencyValue;
            operation.Amout = amount;
            operation.TotalPrice = currentCurrencyValue * amount;
            operation.Date = DateTime.Parse(DateTime.Now.ToShortDateString());

            db.Operations.Add(operation);
            db.SaveChanges();

            Console.WriteLine("Selling Successfully Done!!");
        }
    }
}
