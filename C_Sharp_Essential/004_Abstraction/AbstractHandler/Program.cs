namespace AbstractHandler
{
    using System;
    using Abstract;

    class Program
    {
        //Создайте класс AbstractHandler.
        //В теле класса создать методы void Open(), void Create(), void Chenge(), void Save(). 
        //Создать производные классы XMLHandler, TXTHandler, DOCHandler от базового класса AbstractHandler.
        //Написать программу, которая будет выполнять определение документа и для каждого формата должны быть методы открытия, создания, редактирования, сохранения определенного формата документа.  

        static void Main()
        {

            Editor editor = new Editor();

            AbstractHandler doc = editor.IdentifyDoc("document.xml");

            doc.Create();
            doc.Change();
            doc.Open();
            doc.Save();

            Console.ReadLine();

        }
    }
}
