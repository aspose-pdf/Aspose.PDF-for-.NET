using Aspose.PDF.Editor.Services.Interface;
using Aspose.PDF.Editor.Services;
using System.IO.Abstractions;
using Aspose.PDF.Editor.Helpers;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc.Razor;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<IFileSystem, FileSystem>();
builder.Services.AddSingleton<IStorageService, StorageService>();
builder.Services.AddControllersWithViews();

builder.Services.AddControllers(options =>options.Filters.Add(typeof(ApiErrorsFilter)));

builder.Services.AddMvc(option => option.EnableEndpointRouting = false)
    .AddJsonOptions(opts =>
    {
        opts.JsonSerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
    })
    .AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix)
    .AddDataAnnotationsLocalization();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddProblemDetails(
    config =>
        config.CustomizeProblemDetails =
            ctx =>
                ctx.ProblemDetails.Extensions.Add("request_host", ctx.HttpContext.Request.Host.Value));

builder.Services.AddLocalization(options => options.ResourcesPath = "AppResources/Editor");

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseStatusCodePages();
app.UseMvc();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
