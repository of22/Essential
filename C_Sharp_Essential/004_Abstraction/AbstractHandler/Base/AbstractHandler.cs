namespace AbstractHandler.Abstract
{
    using System;

    //Создайте класс AbstractHandler.
    //В теле класса создать методы void Open(), void Create(), void Chenge(), void Save(). 
    //Создать производные классы XMLHandler, TXTHandler, DOCHandler от базового класса AbstractHandler.
    //Написать программу, которая будет выполнять определение документа и для каждого формата должны быть методы открытия, создания, редактирования, сохранения определенного формата документа.  

    class AbstractHandler
    {
        public virtual void Open()
        {
            Console.WriteLine("Abstract file openeded");
        }

        public virtual void Create()
        {
            Console.WriteLine("Abstract file created");
        }

        public virtual void Change()
        {
            Console.WriteLine("Abstract file changed");
        }

        public virtual void Save()
        {
            Console.WriteLine("Abstract file openeded");
        }
    }
}
