using IndexerTask.Models;

namespace IndexerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Cities = { "baki", "Quba", "Sheki" };
            StringList CityList = new StringList(Cities);
            int index = CityList["Quba"];
            Console.WriteLine(index);
        }
    }
}

