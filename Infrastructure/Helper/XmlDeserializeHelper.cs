using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Infrastructure.Helper
{
    public class XmlDeserializeHelper<T>
    {
        public T XmlDeserialize(string xmlUrl) {

            XmlSerializer deserializer = new XmlSerializer(typeof(T));
            XmlReader reader = XmlReader.Create(xmlUrl);

            object obj = deserializer.Deserialize(reader);
            T XmlData = (T)obj;
            reader.Close();

            return XmlData;
        }
    }
}
