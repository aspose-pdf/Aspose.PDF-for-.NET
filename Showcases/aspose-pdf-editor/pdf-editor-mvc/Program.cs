using Aspose.PDF.Editor.Services.Interface;
using Aspose.PDF.Editor.Services;
using System.IO.Abstractions;
using Aspose.PDF.Editor.Helpers;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc.Razor;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews()
    .AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix)
    .AddDataAnnotationsLocalization()
    .AddJsonOptions(opts =>
    {
        opts.JsonSerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
    });

builder.Services.AddLocalization(options => options.ResourcesPath = "AppResources/Editor");

builder.Services.AddControllers(options =>options.Filters.Add(typeof(ApiErrorsFilter)));
builder.Services.AddRouting(options =>
{
    options.LowercaseUrls = true;
    options.LowercaseQueryStrings = true;
});

builder.Services.AddProblemDetails(
    config =>
        config.CustomizeProblemDetails =
            ctx =>
                ctx.ProblemDetails.Extensions.Add("request_host", ctx.HttpContext.Request.Host.Value));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add business logic
builder.Services.AddSingleton<IFileSystem, FileSystem>();
builder.Services.AddSingleton<IDocumentServicecs, DocumentServicecs>();
builder.Services.AddSingleton<IStorageService, StorageService>();
builder.Services.AddSingleton<IImageService, ImageService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseStatusCodePages();
app.UseRouting();

app.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");

app.UseSwagger();
app.UseSwaggerUI();

app.Run();
