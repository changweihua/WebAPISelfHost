using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Http;
using System.Web.Http.SelfHost;

namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Host");

            HttpSelfHostConfiguration config = new HttpSelfHostConfiguration("http://127.0.0.1:9999");

            config.Routes.MapHttpRoute("API Default", "api/{controller}/{id}", new { id = RouteParameter.Optional });

            using (HttpSelfHostServer server = new HttpSelfHostServer(config))
            {
                server.OpenAsync().Wait();
                Console.WriteLine("按任意键关闭");
                Console.ReadKey(true);
            }

        }
    }
}
