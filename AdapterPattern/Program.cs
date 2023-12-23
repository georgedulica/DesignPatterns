using AdapterPattern.AdapterPattern.Display;
using AdapterPattern.AdapterPattern.Serivices;
using System.Xml;

public class Program
{
    static void Main()
    {
        string xmlFilePath = "XMLFILES\\XML-File.xml";
        var xmlDoc = new XmlDocument();
        
        try
        {
            xmlDoc.Load(xmlFilePath);
        }
        catch(Exception ex)
        {
            Console.WriteLine($"Reading XML file from {xmlFilePath} failed\n"); 
            Console.WriteLine(ex);
            return;
        }

        var displayService = new DisplayService();
        var display = new Display(displayService);
        display.DisplayError(xmlDoc);
    }
}