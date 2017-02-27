namespace AbstractHandler
{
    using System;
    using System.Linq;
    using Abstract;
    using Concrete;

    class Editor
    {
        public AbstractHandler IdentifyDoc(string fileName)
        {
            string format = fileName.Split('.').Last();
            AbstractHandler abstractHandler = null;
            switch (format)
            {
                case "txt":
                    abstractHandler = new TxtHandler();
                    break;
                case "doc":
                    abstractHandler = new DocHandler();
                    break;
                case "xml":
                    abstractHandler = new XmlHandler();
                    break;
                default:
                    Console.WriteLine("Unidentified format");
                    break;
            }
            return abstractHandler;
        }

    }
}
