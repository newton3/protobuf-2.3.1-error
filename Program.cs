using System.IO;
using Newtonsoft.Json;
using ProtoBuf;

namespace protobuf
{
    class Program
    {
        static void Main(string[] args)
        {
            //var itemJson = File.ReadAllText("item.2.json");
            //var item = JsonConvert.DeserializeObject<Item>(itemJson);

            //using (var stream = new FileStream("item.2.1.0-13.bin", FileMode.OpenOrCreate))
            //{
            //    Serializer.Serialize(stream, item);
            //}

            using (var stream = new FileStream("item.2.1.0-13.bin", FileMode.Open))
            {
                var obj = Serializer.Deserialize<Item>(stream);
                File.WriteAllText("item.2.1.0-13-to-2.3.1-13.json", JsonConvert.SerializeObject(obj));
            }
        }
    }
}
