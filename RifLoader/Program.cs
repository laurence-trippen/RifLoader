using System.Text;

namespace RifLoader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string rifLocation = @"C:\\Games\\GOG\\AvP Classic\\avp_rifs";
            string testRif = "derelict.rif";

            if (!Directory.Exists(rifLocation))
            {
                Console.WriteLine("Couldn't find RIF path!");
                Environment.Exit(1);
            }

            string targetRif = Path.Combine(rifLocation, testRif);
            Console.WriteLine(targetRif);

            FileInfo fileInfo = new FileInfo(targetRif);
            Console.WriteLine(fileInfo.Length);

            FileChunk rifChunk = new FileChunk(targetRif);

            Console.ReadKey();
        }
    }
}
