using System.Runtime.InteropServices;
using Microsoft.Extensions.FileProviders;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.Net.Http.Headers;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Builder;
using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Razor;
using System.Text.Json;
using Aspose.PDF.Editor.Helpers;
using Aspose.PDF.Editor.Services.Interface;
using Aspose.PDF.Editor.Services;
using System.IO.Abstractions;

namespace Aspose.PDF.Editor
{
    public class Startup
    {
        private const string resourceRoutePath = "/pdf/editor/content";
        private const string staticResources = "/resources";
        private const string apiRoutePath = "pdf/editor/api/{action}";
        private const string _workingDirectoryWin = "c:\\temp\\";
        private const string _workingDirectoryLinux = "./temp/";

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews()
             .AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix)
             .AddDataAnnotationsLocalization()
             .AddJsonOptions(opts =>
             {
                 opts.JsonSerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
             });
            services.AddLocalization(options => options.ResourcesPath = "AppResources/Editor");
            services.AddControllers(options => options.Filters.Add(typeof(ApiErrorsFilter)));
            services.AddRouting(options =>
            {
                options.LowercaseUrls = true;
                options.LowercaseQueryStrings = true;
            });
            // Add business logic
            services.AddSingleton<IFileSystem, FileSystem>();
            services.AddSingleton<IDocumentServicecs, DocumentServicecs>();
            services.AddSingleton<IStorageService, StorageService>();
            services.AddSingleton<IImageService, ImageService>();
        }

        /// <summary>
        /// Get Working Directory
        /// </summary>
        public static string WorkingDirectory => RuntimeInformation.IsOSPlatform(OSPlatform.Windows) ?
                                                    _workingDirectoryWin :
                                                    _workingDirectoryLinux;


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(
            IApplicationBuilder app,
            //TODO: host environment is obsolete
            Microsoft.AspNetCore.Hosting.IHostingEnvironment env)
        {
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseStatusCodePages();
            app.UseRouting();
            app.UseStaticFiles();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}");
            });
        }
    }
}
