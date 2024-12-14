using System.Xml;
using DesignPatterns.Structural.Adapter.Legacy;
using Newtonsoft.Json;

namespace DesignPatterns.Structural.Adapter.Modern;

public class Convertor : XmlApp, IJsonApp
{
    public string GetJsonData()
    {
        string data = GetXmlData();
        
        XmlDocument document = new XmlDocument();
        document.LoadXml(data);
        
        return JsonConvert.SerializeXmlNode(document);
    }
}