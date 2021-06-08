using System;
using XmlSerialization;

namespace ReadXml
{
    class Program
    {
        public static void Main()
        {
            // Read and write purchase orders.
            XMLGenerate t = new XMLGenerate();
            
            t.CreatePO("po.xml");
            t.ReadPO("po.xml");
            Console.ReadLine();

        }

       
    }
}
