using System;
using System.ServiceModel;

namespace SummatorServiceHost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var host = new ServiceHost(typeof(SummatorService.SummatorService)))
            {
                host.Open();

                Console.WriteLine($"Host started...");
                Console.WriteLine("Press [ENTER] to close connection");
                Console.ReadLine();

                host.Close();
            }
        }
    }
}