using System;
using Aspose.App.Shared.Config;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Serilog;
using Serilog.Formatting.Elasticsearch;
using Serilog.Sinks.Elasticsearch;

namespace Aspose.PDF.FormFiller
{
    public class Program
    {
        private static string appId = string.Concat("pdf-", Startup.AppName, "-app");


        private static readonly string[] crashEmails = { "evgeny.pirogov@aspose.com", "fuad.fataliyev@aspose.com" };

        public static void Main(string[] args)
        {
            var logger = Log.Logger;
            try
            {
                var host = CreateHostBuilder(args).Build();
                //logger.ApplicationVersion(Environment.GetEnvironmentVariable("BUILD_VERSION"));
                logger.Information("Started at: " + DateTime.Now);
                logger.Information(Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT"));
                host.Run();
            }
            catch (Exception ex)
            {
                try
                {
                    foreach (var crashEmail in crashEmails)
                    {
                        EmailManager.SendEmail(crashEmail, Configuration.FromEmailAddress, appId + " not stated, rollover strategy stay with previous build", ex.ToString(), "", null);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
                logger.Fatal(appId, ex);
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .UseSerilog((context, loggerConfiguration) =>
                {
                    loggerConfiguration = loggerConfiguration.ReadFrom.Configuration(context.Configuration);
                    if (context.HostingEnvironment.IsStaging() ||
                        context.HostingEnvironment.IsProduction())
                    {
                        loggerConfiguration
                        .MinimumLevel.Error()
                        .WriteTo.Elasticsearch(
                            new ElasticsearchSinkOptions(new Uri(Environment.GetEnvironmentVariable("ES_URL")))
                            {
                                IndexFormat = string.Concat(appId, "-{0:yyyy.MM.dd}"),
                                AutoRegisterTemplate = true,
                                CustomFormatter = new ExceptionAsObjectJsonFormatter(renderMessage: true),
                                FailureCallback = e => Console.WriteLine("Unable to submit event " + e.MessageTemplate),
                                EmitEventFailure = EmitEventFailureHandling.WriteToSelfLog |
                                                   EmitEventFailureHandling.RaiseCallback |
                                                   EmitEventFailureHandling.ThrowException,
                                ModifyConnectionSettings = x => x.BasicAuthentication(
                                    Environment.GetEnvironmentVariable("ES_LOGIN"),
                                    Environment.GetEnvironmentVariable("ES_PASSWORD")),
                            });
                    }
                    else
                    {
                        loggerConfiguration.WriteTo.Console();
                    }
                })
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
