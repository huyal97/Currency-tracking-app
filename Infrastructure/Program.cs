using Infrastructure.Entities;
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
            XmlSerializer deserializer = new XmlSerializer(typeof(Tarih_Date));
            XmlReader reader = XmlReader.Create(URLString); 
            object obj = deserializer.Deserialize(reader);
            Tarih_Date XmlData = (Tarih_Date)obj;
            reader.Close();
        }
    }
}
