using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice
{
    //Создать класс Invoice.
    //В теле класса создать три поля int Account, string Customer, string Provider которые должны быть проинициализированы один раз(при создании экземпляра данного класса) без возможности их дальнейшего изменения.
    //В теле класса создать два закрытых поля string article, int quantity
    //Создать метод расчета стоимости заказа с НДС и без НДС.
    //Написать программу, которая выводит на экран сумму оплаты заказанного товара с НДС или без НДС.


    class Invoice
    {
        public readonly int Account;
        public readonly string Customer;
        public readonly string Provider;

        public string Article { get; set; }
        public int Quantity { get; set; }

        public Invoice(int account, string customer, string provider)
        {
            Account = account;
            Customer = customer;
            Provider = provider;
        }

        public void CalculatePrice(bool includeTax)
        {
            double cost;
            
            switch (Article)
            {
                case "laptop":
                    cost = 12500.50;
                    break;
                case "freezer":
                    cost = 10000;
                    break;
                case "TV":
                    cost = 20000;
                    break;
                default:
                    Console.WriteLine("Can't recognize such Article");
                    return;
            }

            if (includeTax)
            {
                cost = cost + cost/10 ;
            }

            Console.WriteLine("Cost "+ (includeTax?"with included tax ":"without tax ") + "and quantity of " + Quantity + " device(devices) = " + cost * Quantity);      
        }


    }
}
