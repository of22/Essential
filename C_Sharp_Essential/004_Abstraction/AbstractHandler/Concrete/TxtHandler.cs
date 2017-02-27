namespace AbstractHandler.Concrete
{
    using System;
    using Abstract;

    class TxtHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Text file openeded");
        }

        public override void Create()
        {
            Console.WriteLine("Text file created");
        }

        public override void Change()
        {
            Console.WriteLine("Text file changed");
        }

        public override void Save()
        {
            Console.WriteLine("Text file openeded");
        }
    }
}
