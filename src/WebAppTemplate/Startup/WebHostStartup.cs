﻿using System;
using Dalion.WebAppTemplate.Api.Controllers;
using Dalion.WebAppTemplate.Configuration;
using Dalion.WebAppTemplate.Serialization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Dalion.WebAppTemplate.Startup {
    public class WebHostStartup : IStartup {
        private readonly IHostingEnvironment _environment;

        public WebHostStartup(IHostingEnvironment environment) {
            _environment = environment ?? throw new ArgumentNullException(nameof(environment));
        }

        public IServiceProvider ConfigureServices(IServiceCollection services) {
            // General
            services.TryAddSingleton(_environment);

            // Mvc
            services
                .AddApiVersioning()
                .AddVersionedApiExplorer( options => options.GroupNameFormat = "'v'VVV" )
                .AddRouting(options => options.LowercaseUrls = true)
                .AddMvc()
                .AddJsonOptions(config => PreConfiguredJsonSerializerSettings.Apply(config.SerializerSettings))
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_2)
                .AddApplicationPart(typeof(DefaultController).Assembly)
                .AddControllersAsServices();

            // Compose
            return services.BuildServiceProvider();
        }

        public void Configure(IApplicationBuilder app) {
            app = _environment.IsDevelopmentOrDebug()
                ? app.UseDeveloperExceptionPage()
                : app.UseExceptionHandler("/error");

            app
                .UseUnhandledExceptionLogging()
                .UseHttpsRedirection()
                .UseStatusCodePagesWithReExecute("/error/{0}") // When response is between 400 and 599, and there is no response content, the catch-all error endpoint will be invoked
                .UseAuthentication() // Very important that this is called before anything that will require authentication
                .UseCookiePolicy()
                .UseMvc()
                .UseStaticFiles()
                .UseSwagger(
                    app.ApplicationServices.GetRequiredService<AuthenticationSettings>(), 
                    app.ApplicationServices.GetRequiredService<IApiVersionDescriptionProvider>())
                .UseApiVersioning();
        }
    }
}