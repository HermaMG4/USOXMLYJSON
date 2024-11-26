using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

class Program
{
    public static void Main (string[] args)
    {
        var filename = @"C:\Users\alexa\source\repos\COPE\COPE\store.xml";

        XElement laptopsXML = XElement.Load(filename);

        var Laptops = from lector in laptopsXML.Element("Laptops").Elements("Laptop")
                      select lector;

        foreach (var leer in Laptops)
        {
            Console.WriteLine(Laptops);
        }
    }
}