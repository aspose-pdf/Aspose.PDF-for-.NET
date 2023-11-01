using System.Runtime.InteropServices;
using Microsoft.Extensions.FileProviders;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.Net.Http.Headers;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Builder;
using System;
using Microsoft.AspNetCore.Http;

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
            app.UseRouting();

            app.UseStaticFiles();
        }
    }
}
