using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using Common;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Client");

            Uri baseUri = new Uri("http://127.0.0.1:9999");

            HttpClient client = new HttpClient { BaseAddress = baseUri };
            var contacts = client.GetAsync("/api/contacts").Result.Content.ReadAsAsync<IEnumerable<Contact>>().Result;

            contacts.ToList().ForEach(_ => { Console.WriteLine(_.Email); });

            Console.ReadKey(true);
        }
    }
}
