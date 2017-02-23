namespace Invoice
{
    using System;

    class Program
    {
        //Создать класс Invoice.
        //В теле класса создать три поля int Account, string Customer, string Provider которые должны быть проинициализированы один раз(при создании экземпляра данного класса) без возможности их дальнейшего изменения.
        //В теле класса создать два закрытых поля string article, int quantity
        //Создать метод расчета стоимости заказа с НДС и без НДС.
        //Написать программу, которая выводит на экран сумму оплаты заказанного товара с НДС или без НДС.

        static void Main()
        {
            Invoice invoice = new Invoice(1, "Vasiliy", "HP") {Article = "laptop", Quantity = 2};

            invoice.CalculatePrice(true);

            invoice.CalculatePrice(false);

            Console.ReadLine();
        }
    }
}
