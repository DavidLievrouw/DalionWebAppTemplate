﻿using Dalion.WebAppTemplate.Configuration;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Logging;

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
                .AddAzureAdAuthentication(authSettings)
                .AddSwagger(bootstrapperSettings, authSettings)
                .AddSerilog(configuration)
                .AddPreconfiguredJsonSerializer()
                .AddApplicationInfo()
                .AddAllLinksCreators()
                .ConfigureCookiePolicy();

            if (!bootstrapperSettings.DisableHttpsRedirection) {
                services.AddHttpsRedirection(options => {
                    options.RedirectStatusCode = StatusCodes.Status307TemporaryRedirect;
                    options.HttpsPort = networkSettings.HttpsPort;
                });
            }

            // Development configuration
            if (hostingEnv.IsDevelopmentOrDebug()) {
                IdentityModelEventSource.ShowPII = true;
            }
        }
    }
}