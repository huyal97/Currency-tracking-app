using Infrastructure.Entities;
using Infrastructure.Helper;
using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Infrastructure
{
    class Program
    {
        static void Main(string[] args)
        {
            String URLString = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var deserializer = new XmlDeserializeHelper<Currencies>();
            var deserializeData = deserializer.XmlDeserialize(URLString);
        }
    }
}
