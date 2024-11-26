using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

class Program
{
    public static void Main (string[] args)
    {
        try
        {
            var filename = @"C:\Users\alexa\source\repos\COPE\COPE\Laptops.xml";

            XElement storeXML = XElement.Load(filename);

            var Laptops = from lector in storeXML.Element("Laptops").Elements("Laptop")
                          select lector;

            foreach (var leer in Laptops)
            {
                Console.WriteLine(leer.Value);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}