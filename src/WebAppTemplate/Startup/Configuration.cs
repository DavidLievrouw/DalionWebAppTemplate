﻿using System.IO;
using Microsoft.Extensions.Configuration;

namespace Dalion.WebAppTemplate.Startup {
    internal static class Configuration {
        public static IConfigurationRoot BuildConfiguration(BootstrapperSettings settings, string[] args) {
            return new ConfigurationBuilder()
                .SetBasePath(Path.GetDirectoryName(settings.EntryAssembly.Location))
                .AddJsonFile("appsettings.json", false, true)
                .AddJsonFile($"appsettings.{settings.EnvironmentName}.json", true, true)
                .AddCommandLine(args)
                .AddEnvironmentVariables()
                .Build();
        }
    }
}