using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace QuizManagerClientHosted.Client
{
  public class Program
  {
    public static async Task Main(string[] args)
    {
      var builder = WebAssemblyHostBuilder.CreateDefault(args);
      builder.RootComponents.Add<App>("app");

      builder.Services.AddTransient(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

      builder.Services.AddOidcAuthentication(options =>
      {
        options.ProviderOptions.PostLogoutRedirectUri = "/";
        options.ProviderOptions.ResponseType = "code";
        builder.Configuration.Bind("Auth0", options.ProviderOptions);
      });

      await builder.Build().RunAsync();
    }
  }
}
