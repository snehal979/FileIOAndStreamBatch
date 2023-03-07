using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FileIO_ProgramBatch
{
    public class JsonSerializationDeserialization
    {
        public void JsonSerialize()
        {
            DataBook dataBook = new DataBook()
            {
                Name ="Snehal",
                Description = "Welcome to Home"
            };
            //converting Blogsites object to json string format
            string jsonData = JsonConvert.SerializeObject(dataBook);
            Console.WriteLine(jsonData);
        }
        public void JsonDeserialization()
        {
            string json = @"{
                'Name' :'Snehal',
                'Description' :'Welcome to Home'
            
            }";
            DataBook dataBook = JsonConvert.DeserializeObject<DataBook>(json);
            Console.WriteLine(dataBook.Name);
        }
    }
    [DataContract]
    public class DataBook
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Description { get; set; }
    }
}
