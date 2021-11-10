using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WindowsFormsClass_2
{
    public static class Serialization<T> // решил пoэкcпepимeнтиpoвaть и создать шаблонные методы сериализации/десериализации!
    {
        // Сериализация (Soap/Xml/Bin)
        public static void Serializ(string NameFile, T obj, string TypeSerial = "soap")
        {
            if (TypeSerial == "bin")
            {
                BinaryFormatter bin = new BinaryFormatter();
                using (Stream stream = File.Create(NameFile + ".bin"))
                {
                    bin.Serialize(stream, obj);
                }
            }
            else if (TypeSerial == "xml")
            {
                XmlSerializer xml = new XmlSerializer(typeof(T));
                using (Stream stream = File.Create(NameFile + ".xml"))
                {
                    xml.Serialize(stream, obj);
                }
            }
            else
            {
                SoapFormatter soap = new SoapFormatter();
                using (Stream stream = File.Create(NameFile + ".soap"))
                {
                    soap.Serialize(stream, obj);
                }
            }
        }
        // Десериазация (Soap/Xml/Bin) 
        public static T DeSerializ(string NameFile, string TypeSerial = "soap")
        {
            object obj = null;
            if (TypeSerial == "bin")
            {
                BinaryFormatter bin = new BinaryFormatter();
                using (Stream stream = File.OpenRead(NameFile + ".bin"))
                {
                    obj = (T)bin.Deserialize(stream);
                }
            }
            else if (TypeSerial == "xml")
            {
                XmlSerializer xml = new XmlSerializer(typeof(T));
                using (Stream stream = File.OpenRead(NameFile + ".xml"))
                {
                    obj = (T)xml.Deserialize(stream);
                }
            }
            else
            {
                SoapFormatter soap = new SoapFormatter();
                using (Stream stream = File.OpenRead(NameFile + ".soap"))
                {
                    obj = (T)soap.Deserialize(stream);
                }
            }
            return (T)obj;
        }
    }
}

