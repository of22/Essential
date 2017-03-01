﻿namespace Article
{
    using System;

    class Program
    {

        // Создать класс Article, содержащий следующие закрытые поля: 
        //• название товара; 
        //• название магазина, в котором продается товар; 
        //• стоимость товара в гривнах.
        //Создать класс Store, содержащий закрытый массив элементов типа Article.  
        //Обеспечить следующие возможности: 
        //• вывод информации о товаре по номеру с помощью индекса; 
        //• вывод на экран информации о товаре, название которого введено с клавиатуры, если таких товаров нет, выдать соответствующее сообщение; 
        //Написать программу, вывода на экран информацию о товаре.

        static void Main()
        {
            Store store = new Store(100);

            store.AddArticle("Laptop", "Comfy", 2.200);
            store.AddArticle("PC", "Foxtrot", 3.200);
            store.AddArticle("Laptop", "Rozetka", 2.200);

            Console.Write("Enter your article name: ");
            Console.WriteLine( store[Console.ReadLine()]);

            Console.Write("Enter your article index: ");
            Console.WriteLine(store[Convert.ToInt32(Console.ReadLine())]);

            Console.ReadLine();
        }
    }
}
