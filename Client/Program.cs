using CloudNimble.BlazorEssentials;
using CloudNimble.EasyAF.Configuration;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Radzen;
using RadzenGridProblem.Client;
using RadzenGridProblem.Client.Models;
using RadzenGridProblem.Client.ViewModels;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#kt_app_body");
//builder.RootComponents.Add<HeadOutlet>("head::after");

builder.AddBlazorEssentials<ConfigurationBase, AdminAppState>("Admin");
builder.Services.AddSingleton<IndexViewModel>();

builder.Services.AddSingleton<DialogService>();
builder.Services.AddSingleton<NotificationService>();
builder.Services.AddSingleton<TooltipService>();
builder.Services.AddSingleton<ContextMenuService>();

await builder.Build().RunAsync();
