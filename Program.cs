using BlazorPokeApi;
using BlazorPokeApi.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// HttpClient da PokeAPI
builder.Services.AddScoped(sp =>
    new HttpClient
    {
        BaseAddress = new Uri("https://pokeapi.co/api/v2/")
    });

// Registro do serviço
builder.Services.AddScoped<PokemonService>();

await builder.Build().RunAsync();