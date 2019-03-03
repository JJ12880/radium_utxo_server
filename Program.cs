using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace Radium_utxo_server
{
    public class Program
    {
        public static string[] accept_urls = { "http://localhost:6001", "http://localhost:6000" };
        public static void Main(string[] args)
        {
            accept_urls[0] = Vars.config.lookup("listen_url");
            Vars.SyncThread.Start();
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
               .UseUrls(urls: accept_urls);
    }
}
