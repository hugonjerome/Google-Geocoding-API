using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GoogleGeocodingAPI;

namespace ConsoleCalls
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Console application to call Google geocode API.");
            Console.WriteLine();

            string address = string.Empty;
            while (string.IsNullOrEmpty(address))
            {
                Console.WriteLine("Enter the address: ");
                address = Console.ReadLine();
            }

            Console.WriteLine("Enter the region (optionnal): ");
            string region = Console.ReadLine();
            if (region == string.Empty) region = null;

            Console.WriteLine("Enter the language (optionnal): ");
            string language = Console.ReadLine();
            if (language == string.Empty) language = null;

            string useHttps = string.Empty;
            while (useHttps != "Y" && useHttps != "N")
            {
                Console.WriteLine("Use HTTPS (Y = Yes | N = No): ");
                useHttps = Console.ReadLine();
            }

            Response r = Request.Send(
                address,
                null,
                null,
                region,
                language,
                false,
                useHttps == "Y" ? true : false);

            Console.WriteLine();
            Console.WriteLine("RESULT:");
            ObjectDumper.Write(r, 10);

            Console.WriteLine();
            Console.WriteLine("Press any key to quit...");
            Console.ReadLine();
        }
    }
}
