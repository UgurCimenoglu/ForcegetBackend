using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace Forceget.DataAccess.Extensions
{
    static class Configuration
    {
        public static string ConnectionString
        {
            get
            {
                ConfigurationManager configurationManager = new();
                try
                {
                    configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Forceget.WebAPI"));
                    configurationManager.AddJsonFile("appsettings.json");
                    return configurationManager.GetConnectionString("ForcegetDb");
                }
                catch
                {
                    configurationManager.AddJsonFile("appsettings.Production.json");
                    Console.WriteLine(Path.Combine(Directory.GetCurrentDirectory(), "../Forceget.WebAPI"));
                }
                return configurationManager.GetConnectionString("ForcegetDb");
            }
        }
    }
}
