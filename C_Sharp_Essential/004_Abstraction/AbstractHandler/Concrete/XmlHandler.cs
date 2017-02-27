namespace AbstractHandler.Concrete
{
    using System;
    using Abstract;

    class XmlHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Xml file openeded");
        }

        public override void Create()
        {
            Console.WriteLine("Xml file created");
        }

        public override void Change()
        {
            Console.WriteLine("Xml file changed");
        }

        public override void Save()
        {
            Console.WriteLine("Xml file openeded");
        }
    }
}
