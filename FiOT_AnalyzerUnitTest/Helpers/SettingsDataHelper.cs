using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FiOT_AnalyzerUnitTest.Helpers
{
    public class SettingsDataHelper<T> where T : new()
    {
        private string _filePath;

        public SettingsDataHelper(string filePath)
        {
            _filePath = filePath;
        }

        public void SerializeToFile(T models)
        {
            var serializer = new XmlSerializer(typeof(T));

            using (var streamWriter = new StreamWriter(_filePath))
            {
                serializer.Serialize(streamWriter, models);
            }
        }

        public T DeserializeFromFile()
        {
            if (!File.Exists(_filePath))
                return new T();

            var serializer = new XmlSerializer(typeof(T));

            using (var streamReader = new StreamReader(_filePath))
            {
                return (T)serializer.Deserialize(streamReader);
            }
        }
    }
}
