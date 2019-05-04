﻿using Dalion.WebAppTemplate.Configuration;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Dalion.WebAppTemplate.Startup {
    internal static class Composition {
        public static void ConfigureServices(
            IServiceCollection services,
            IHostingEnvironment hostingEnv,
            IConfiguration configuration,
            BootstrapperSettings bootstrapperSettings) {
            // Configuration
            var authSettings = services.ConfigureSettings<AuthenticationSettings>(configuration.GetSection("Authentication"));
            var networkSettings = services.ConfigureSettings<NetworkSettings>(configuration.GetSection("Network"));

            // Features and services
            services
                .AddFileProviders()
                .AddHttpsRedirection(options => {
                    options.RedirectStatusCode = StatusCodes.Status307TemporaryRedirect;
                    options.HttpsPort = networkSettings.HttpsPort;
                })
                .AddAzureAdAuthentication(authSettings)
                .AddSwagger(bootstrapperSettings, authSettings)
                .AddSerilog(configuration)
                .AddPreconfiguredJsonSerializer()
                .AddApplicationInfo()
                .AddAllLinksCreators()
                .ConfigureCookiePolicy();
        }
    }
}