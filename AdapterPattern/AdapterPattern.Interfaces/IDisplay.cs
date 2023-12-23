using System.Xml;

namespace AdapterPattern.AdapterPattern.Interfaces;

public interface IDisplay
{
    public void DisplayError(XmlDocument xmlDocument);
}