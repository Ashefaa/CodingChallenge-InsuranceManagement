﻿using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance_Management.Utility
{
    internal class DBConnection
    {
        
            private static IConfiguration iconfiguration;
            static DBConnection()
            {
                GetAppSettingsFile();
            }

            private static void GetAppSettingsFile()
            {
                var builder = new ConfigurationBuilder()
                         .SetBasePath(Directory.GetCurrentDirectory())
                         .AddJsonFile("appsettings.json");
                iconfiguration = builder.Build();
            }

            public static string GetConnectionString()
            {
                return iconfiguration.GetConnectionString("LocalConnectionString");
            }
        }
    
}
