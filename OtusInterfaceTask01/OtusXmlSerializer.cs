using System.IO;
using System.Xml;
using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;

namespace OtusInterfaceTask01
{
    public class OtusXmlSerializer<T> : ISerializer<T>
    {
        private static readonly XmlWriterSettings XmlWriterSettings;

        static OtusXmlSerializer()
        {
            XmlWriterSettings = new XmlWriterSettings {Indent = true};
        }

        public string Serialize<T>(T item)
        {
            IExtendedXmlSerializer serializer = new ConfigurationContainer()
                .UseAutoFormatting()
                .UseOptimizedNamespaces()
                .EnableImplicitTyping(typeof(T))
                .Create();

            return serializer.Serialize(XmlWriterSettings, item);
        }

        public T Deserialize<T>(Stream stream)
        {
            throw new System.NotImplementedException();
        }
    }
}