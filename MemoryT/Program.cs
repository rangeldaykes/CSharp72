using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace MemoryT
{
    class Program
    {
        private static async Task Main(string[] args)
        {
            Console.WriteLine("MemoryT");

            Memory<byte> memory = new Memory<byte>(new byte[50]);
            int count = await ReadFromUrlAsync("https://www.microsoft.com/pt-br/", memory).ConfigureAwait(false);
            Console.WriteLine("Bytes written: {0}", count);

            Console.ReadLine();
        }

        private static async ValueTask<int> ReadFromUrlAsync(string url, Memory<byte> memory)
        {
            using (HttpClient client = new HttpClient())
            {
                Stream stream = await client.GetStreamAsync(new Uri(url)).ConfigureAwait(false);
                return await stream.ReadAsync(memory).ConfigureAwait(false);
            }
        }
    }
}
