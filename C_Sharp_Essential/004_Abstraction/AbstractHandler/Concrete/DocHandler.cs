namespace AbstractHandler.Concrete
{
    using System;
    using Abstract;

    class DocHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Document file openeded");
        }

        public override void Create()
        {
            Console.WriteLine("Document file created");
        }

        public override void Change()
        {
            Console.WriteLine("Document file changed");
        }

        public override void Save()
        {
            Console.WriteLine("Document file openeded");
        }


    }
}
