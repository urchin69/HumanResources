using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HumanResources
{
    public class HelperAddEdit<T> where T : new()
    {
        private string _filePath;

        public HelperAddEdit(string filePath)//kontruktor
        {
            _filePath = filePath;
        }
        public void SerializeToFile(T workers)
        {
            var serializer = new XmlSerializer(typeof(T));
            using (var streamWriter = new StreamWriter(_filePath))
            {
                serializer.Serialize(streamWriter, workers);//przekazujemy obiekty
                streamWriter.Close(); //zamykamy strumień
            }
        }

        public T DeserializeFromFile()
        {
            if (!File.Exists(_filePath))
                return new T();

            var serializer = new XmlSerializer(typeof(T));

            using (var streamReader = new StreamReader(_filePath))
            {
                var workers = (T)serializer.Deserialize(streamReader);//ta metoda zwraca object dlatego musimy rzutować na listę studentów
                streamReader.Close();
                //stream.Dispose() zawsze zostanie wykonane dzięki metodzie using
                return workers;
            }
        }

    }

}

