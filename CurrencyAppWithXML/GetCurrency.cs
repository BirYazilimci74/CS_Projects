using CurrencyAppWithXML.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CurrencyAppWithXML
{
    public class GetCurrency
    {
        DBCurrencyAppEntities db = new DBCurrencyAppEntities();
        CurrencyValue currencyValue = new CurrencyValue();

        string today = "https://www.tcmb.gov.tr/kurlar/today.xml";
        XmlDocument xmlDoc = new XmlDocument();
        
        public void SaveCurrencyDollar()
        {
            xmlDoc.Load(today);
            
            string dollarBuy = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteBuying").InnerXml;
            string dollarSell = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;

            currencyValue.CurrencyID = 1;
            currencyValue.Buying = Convert.ToDecimal(dollarBuy);
            currencyValue.Selling = Convert.ToDecimal(dollarSell);
            currencyValue.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            
            db.CurrencyValues.Add(currencyValue);
            db.SaveChanges();
        }

        public void SaveCurrencyEuro()
        {
            xmlDoc.Load(today);

            string euroBuy = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteBuying").InnerXml;
            string euroSell = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;

            currencyValue.CurrencyID = 2;
            currencyValue.Buying = Convert.ToDecimal(euroBuy);
            currencyValue.Selling = Convert.ToDecimal(euroSell);
            currencyValue.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            
            db.CurrencyValues.Add(currencyValue);
            db.SaveChanges();
        }

        public void SaveCurrencyPound()
        {
            xmlDoc.Load(today);

            string poundBuy = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='GBP']/BanknoteBuying").InnerXml;
            string poundSell = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='GBP']/BanknoteSelling").InnerXml;

            currencyValue.CurrencyID = 4;
            currencyValue.Buying = Convert.ToDecimal(poundBuy);
            currencyValue.Selling = Convert.ToDecimal(poundSell);
            currencyValue.Date = DateTime.Parse(DateTime.Now.ToShortDateString());

            db.CurrencyValues.Add(currencyValue);
            db.SaveChanges();
        }
    }
}
