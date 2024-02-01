using Aspose.Pdf.Translate.Helper;
using Aspose.Pdf.Translate.Services.Interface;
using Aspose.Pdf.Translate.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddControllers(options => options.Filters.Add(typeof(ApiErrorsFilter)));
builder.Services.AddRouting(options =>
{
    options.LowercaseUrls = true;
    options.LowercaseQueryStrings = true;
});

// Add business logic
builder.Services.AddSingleton<IGroupdocsService, GroupdocsService>();
builder.Services.AddSingleton<IStorageService, StorageService>();
builder.Services.AddSingleton<IStatusStorage, StatusStorage>();
builder.Services.AddSingleton<ITranslateService, TranslateService>();


builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");

app.UseAuthorization();

app.MapRazorPages();

app.UseSwagger();
app.UseSwaggerUI();

app.Run();
