using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace Apttus.Assignment.ProductLibrary
{
    public class ReaderXML
    {
        public void ReadXml()
        {
            List<string> proList = new List<string>();
            Console.WriteLine("--------List of products-------");
            IEnumerable<string> productDetails = from Product in XDocument.Load("Products_List.xml")
                                                           .Descendants("Product")
                                                 where (int)Product.Attribute("Price") > 0 && (string)Product.Attribute("DisplayName") != null
                                                 select Product.Attribute("DisplayName").Value;

            foreach (string p in productDetails)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine("Do you want to select product? y/n");
            string ans = "y";
            while (ans == "y")
            {
                string choice = Console.ReadLine();
                if (choice == "y")
                {
                    Console.WriteLine("Please enter name of product:- ");
                    string name = Console.ReadLine();
                    proList.Add(name);
                    for (int i = 0; i < proList.Count; i++)
                    {
                        Console.WriteLine("Products selected: " + proList[i]);
                    }
                    Console.WriteLine("Do you want to select more products? y/n");
                }
                else if (choice == "n")
                {
                    Console.WriteLine("No selection");
                    Console.WriteLine("You are exited");
                }
            }

            Dictionary<string, Product> dictionary = new Dictionary<string, Product>();

        }
    }
}