using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System.Globalization;
using System.Threading.Tasks;

namespace Organimmo.UI.Blazor.Extensions
{
    public static class WebAssemblyHostExtension
    {
        public async static Task SetDefaultCulture(this WebAssemblyHost host)
        {
            var localstorage = host.Services.GetRequiredService<ILocalStorageService>();
            var cultureFromLS = await localstorage.GetItemAsync<string>("culture");

            CultureInfo culture;

            if(cultureFromLS != null)
            {
                // remembers what language was used last time before exit application
                culture =  new CultureInfo(cultureFromLS);
            }
            else
            {
                culture = new CultureInfo("nl-NL");
            }

            CultureInfo.DefaultThreadCurrentCulture = culture;
            CultureInfo.DefaultThreadCurrentUICulture = culture;
        }
    }
}
