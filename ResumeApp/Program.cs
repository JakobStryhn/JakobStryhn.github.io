using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using ResumeApp;
using ResumeApp.Services;
using ResumeApp.Services.Interfaces;
using System.Globalization;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");


// Note : Scoped and Singleton behave nearly identical on a Static WASM Application
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

// Note : Transient should work as expected on a static WASM Application
builder.Services.AddTransient<IImageResizer, ImageResizer>();

// Blazored for using local browser storage
builder.Services.AddBlazoredLocalStorage();

// Localization
builder.Services.AddLocalization();

// Build the application
var application = builder.Build();

// More localization
var localStorage = application.Services.GetRequiredService<ILocalStorageService>();
var culture = await localStorage.GetItemAsync<string>("culture");

// If local culture item found
if (!string.IsNullOrEmpty(culture))
{
    var cultureInfo = new CultureInfo(culture);
    CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
    CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;
}
// Else create new one as fallback
else
{
    CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-GB");
    CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("en-GB");
    await localStorage.SetItemAsync("culture", "en-GB");
}

// Run the application
await application.RunAsync();
