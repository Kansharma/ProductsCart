using System;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Linq;
using Apttus.Assignment.ProductLibrary;

namespace Apttus.Assignment.Products_Cart
{
    class ProductsMainClass : ReaderXML
    {

        static void Main(string[] args)
        {
            ReaderXML xml = new ReaderXML();
            xml.ReadXml();
            Console.WriteLine("Please select products");
        }

    }
}