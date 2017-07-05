
using System;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace PlainTV.Configuration
{
    class Program
    {
        static void Main(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .AddUserSecrets<Program>()
                .AddEnvironmentVariables()
                .Build();

            Console.WriteLine(configuration["Data:ConnectionString"]);
            Console.Read();
        }
    }
}
