using EmailStatistics.MailSettings;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace EmailStatistics.Entities
{
    /// <summary>
    /// Статический класс с методами для сериализации и десериализации
    /// </summary>
    public static class Serializing
    {
        public static void Serialize(string pathToFile, object graph)
        {
            using (FileStream file = new FileStream(pathToFile, FileMode.Create))
            {
                BinaryFormatter binFormat = new BinaryFormatter();
                binFormat.Serialize(file, graph);
            }
        }

        public static void Deserialize<T>(string pathToFile, ref T obj)
        {
            using (FileStream file = new FileStream(pathToFile, FileMode.Open))
            {
                BinaryFormatter binFormat = new BinaryFormatter();
                obj = (T)binFormat.Deserialize(file);
            }
        }
    }
}
