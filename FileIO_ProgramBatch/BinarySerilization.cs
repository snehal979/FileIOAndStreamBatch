using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace FileIO_ProgramBatch
{
    [Serializable]
    public class Demo
    {
        public string ApplicationName { get; set; } = "Binary Serialization";
        public int ApplicationId { get; set; } = 10001;
    }
    public class BinarySerilization
    {
        /// <summary>
        /// Serialization - object convert to binary lang.
        /// </summary>
        /// <param name="filepath"></param>
        public void Serialization(string bfilepath)
        {
            Demo sample = new Demo();
            FileStream fileStream = new FileStream(bfilepath, FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fileStream, sample);
        }
        /// <summary>
        /// DeSerialization binnary code convrt to human readable 
        /// </summary>
        /// <param name="filepath"></param>
        public void DeSerialization(string bfilepath)
        {
            FileStream fileStream = new FileStream(bfilepath, FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();
            Demo deserializationSample = (Demo)formatter.Deserialize(fileStream);
            Console.WriteLine($"ApplicationName :{deserializationSample.ApplicationName}---ApplicationId  {deserializationSample.ApplicationId}");

        }
    }
}
