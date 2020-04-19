using System;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var networkInterface = NetworkInterface.GetAllNetworkInterfaces().FirstOrDefault();
            var addressBytes = networkInterface.GetPhysicalAddress().GetAddressBytes();

            var binaryDate = DateTime.Now.Date.ToBinary();
            var dateBytes = BitConverter.GetBytes(binaryDate);

            var length = addressBytes.Length >= dateBytes.Length ? dateBytes.Length : addressBytes.Length;
            var generatedKey = new StringBuilder();

            for (int i = 0; i < length; i++)
            {
                // we have addressBytes && dateBytes
                // different array sizes
                
                var keyPart = (addressBytes[i] ^ dateBytes[i]) * 10;

                generatedKey.Append(keyPart);
                if (i < length - 1)
                {
                    generatedKey.Append("-");
                }
            }

            Console.WriteLine($"Your generated key: {generatedKey}");
            Console.ReadLine();
        }
    }
}
