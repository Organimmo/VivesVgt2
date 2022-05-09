using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Organimmo.UI.Blazor;
using Organimmo.UI.Blazor.Extensions;
namespace Organimmo.UI.Blazor
{
 public class Program
 {
    public static async Task Main(string[] args)
    {
        var builder = WebAssemblyHostBuilder.CreateDefault(args);
        builder.RootComponents.Add<App>("#app");
        builder.RootComponents.Add<HeadOutlet>("head::after");
        builder.Services.AddLocalization();
        builder.Services.AddBlazoredLocalStorage();
        builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

        var host = builder.Build();
        await host.SetDefaultCulture();     
        await host.RunAsync();
    }
 }
}
