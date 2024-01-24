using System.Text.Json;
namespace SerializeToJSON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // initialize list
            List<Group> groups = new List<Group>() 
            { 
                new Group() {Name="Storage", DeviceCount=3},
                new Group() {Name="Production", DeviceCount=15},
                new Group() {Name="Depot", DeviceCount=23}
            };

            var jstring = JsonSerializer.Serialize(groups);
            
            string folder = Directory.GetCurrentDirectory();
            string fileName = "groups.json";

            File.WriteAllText(folder +"\\"+fileName, jstring);
            Console.WriteLine("Write to file done!");

            var data = File.ReadAllText(folder +"\\"+fileName);

            List<Group> groupData = new List<Group>();
            groupData = JsonSerializer.Deserialize<List<Group>>(data);

            Console.WriteLine("Read from file done!");

        }
    }
}
