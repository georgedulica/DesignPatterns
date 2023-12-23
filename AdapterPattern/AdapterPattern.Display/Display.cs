using AdapterPattern.AdapterPattern.Interfaces;
using AdapterPattern.AdapterPattern.Serivices;
using Newtonsoft.Json;
using System.Xml;

namespace AdapterPattern.AdapterPattern.Display;

public class Display : IDisplay
{
    private readonly DisplayService displayService;

    public Display(DisplayService displayService)
    {
        this.displayService = displayService;    
    }

    public void DisplayError(XmlDocument xmlDocument)
    {
        var json = JsonConvert.SerializeXmlNode(xmlDocument, Newtonsoft.Json.Formatting.None, true);
        displayService.DisplayError(json);
    }
}