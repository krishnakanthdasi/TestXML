using System;
using System.IO;
using System.Xml.Serialization;

namespace TestApp
{
    class Program
    {
        public static void Main()
        {
            // Read and write purchase orders.
            TestXML.Test t = new TestXML.Test();
            
            t.CreatePO("po.xml");
            t.ReadPO("po.xml");
            Console.ReadLine();

        }

       
    }
}
