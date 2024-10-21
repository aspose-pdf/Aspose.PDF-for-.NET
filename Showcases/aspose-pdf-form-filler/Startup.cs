using System;
using System.IO;
using System.Reflection;
using Aspose.App.Controllers;
using Aspose.App.Diagnostics;
using Aspose.App.UI.Utils;
using Aspose.PDF.RazorShared.Config;
using Aspose.PDF.RazorShared.Diagnostics;
using Aspose.PDF.RazorShared.Extensions;
using Aspose.PDF.Shared.Config;
using Aspose.PDF.Shared.Controllers;
using Elastic.Apm.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
// using Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Logging;
using Serilog;
using IHostApplicationLifetime = Microsoft.Extensions.Hosting.IHostApplicationLifetime;

namespace Aspose.PDF.FormFiller
{
    public class Startup
    {
        private static ProductApplications applications = ProductApplications.FormFiller;
        internal static string AppName
        {
            get { return applications.ToString(); }
        }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IAsposePdfBaseController, AsposePdfFormFillerController>();

            // add product license
            using (Stream lic = Shared.Helpers.LicenseProvider.LicenseStream())
            {
                lic.Seek(0, SeekOrigin.Begin);
                new Aspose.Pdf.License().SetLicense(lic);
            }
            using (Stream lic = Shared.Helpers.LicenseProvider.LicenseStream())
            {
                lic.Seek(0, SeekOrigin.Begin);
                new Aspose.Words.License().SetLicense(lic);
            }

            services.AddSharedConfigParams("FormFiller", Configuration);
            // services.AddRazorPages();
            // services.Configure<MvcRazorRuntimeCompilationOptions>(options =>
            // {
            //    var libraryPath = Path.GetFullPath("/Users/yelnur/Documents/aspose/webappsnats/apps/Aspose.PDF.RazorShared");
            //    options.FileProviders.Add(new PhysicalFileProvider(libraryPath));
            // });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IHostApplicationLifetime lifetime = null, ILogger<Startup> logger = null)
        {
            if(env.ContentRootPath.Contains("Aspose.PDF.WebApp.Common") || env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
                //app.UseElasticApm(Configuration);
            }
            app.UseMetricsService();

            app.UseSharedConfig(applications.ToRouteName(), env);

            if (!env.ContentRootPath.Contains("Aspose.PDF.UI.Tests") && env.IsProduction())
            {
                app.UseSerilogRequestLogging();
            }

            //app.UseStaticFiles();
            //app.UseCookiePolicy();
            app.UseRouting();
            app.UseSession();

            var staticResources = "";
            if (System.Environment.GetEnvironmentVariable("DOTNET_RUNNING_IN_CONTAINER") != null)
                //for Windows container
                staticResources = "/src/apps/Aspose.PDF.RazorShared/resources";
            else if (env.ContentRootPath.EndsWith("Common"))
                //for Common test execute
                staticResources = Path.Combine(env.ContentRootPath, "../apps/Aspose.PDF.RazorShared/resources");
            else if (env.ContentRootPath.Contains("Aspose.PDF.UI.Tests"))
                staticResources = Path.Combine(env.ContentRootPath, "../../../../../apps/Aspose.PDF.RazorShared/resources");
            else
                //for this app runtime
                staticResources = Path.GetFullPath("../Aspose.PDF.RazorShared/resources");
            var options = new StaticFileOptions
            {
                FileProvider = new PhysicalFileProvider(staticResources),
                RequestPath = "/pdf/" + applications.ToRouteName() + "/content",
                HttpsCompression = Microsoft.AspNetCore.Http.Features.HttpsCompressionMode.Compress,
                OnPrepareResponse = (context) =>
                {
                    var headers = context.Context.Response.GetTypedHeaders();
                    headers.CacheControl = new Microsoft.Net.Http.Headers.CacheControlHeaderValue
                    {
                        Public = true,
                        MaxAge = TimeSpan.FromDays(30)
                    };
                }
            };
            //This is required for asp-append-version
            env.WebRootFileProvider = new CompositeFileWithOptionsProvider(env.WebRootFileProvider, options);
            app.UseStaticFiles(options);

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync($"Healthy. Release {File.GetCreationTime(Assembly.GetExecutingAssembly().Location).ToString("yyyy-MM-dd HH:mm")}");
                });
            });

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapControllerRoute(AppName, "pdf/" + applications.ToRouteName(),
            //        new { controller = AppName, action = AppName });
            //});
            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapControllerRoute(AppName, "pdf/{locale}/" + applications.ToRouteName(),
            //        new { controller = AppName, action = AppName, locale = "en" });
            //});

            //foreach(var form in Aspose.App.Shared.Config.Configuration.SitemapFormFillerFormats)
            //{
            //    app.UseEndpoints(endpoints =>
            //    {
            //        endpoints.MapControllerRoute(AppName, "pdf/" + applications.ToRouteName() + "/" + form,
            //            new { controller = "Form", action = form.ToString() });
            //    });
            //    app.UseEndpoints(endpoints =>
            //    {
            //        endpoints.MapControllerRoute(AppName, "pdf/{locale}/" + applications.ToRouteName() + "/" + form,
            //            new { controller = "Form", action = form.ToString(), locale = "en" });
            //    });
            //}

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("AsposePdfDownload", "pdf/" + applications.ToRouteName() + "/api/{action}/{id}",
                    new { controller = "Download", action = "Download", id = "" });
            });
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("AsposePdfFeedback", "pdf/" + applications.ToRouteName() + "/sendfeedback",
                    new { controller = AppName, action = "SendFeedback" });
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("AsposePdfFeedback", "pdf/" + applications.ToRouteName() + "/sendemail",
                    new { controller = AppName, action = "SendEmail" });
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("AsposePdfFormFiller", "pdf/" + applications.ToRouteName() + "/api/{action}",
                    new { controller = "AsposePdfFormFiller", action = "" });
            });

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapControllerRoute(AppName, "pdf/" + AppName + "/Routes",
            //        new { controller = AppName, action = "Routes" });
            //});

            ApplicationLifetimeLogger.Register(lifetime, logger);
        }
    }
}
