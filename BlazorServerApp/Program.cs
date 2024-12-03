using BlazorServerApp.Components;
using Grpc.Net.Client;
using GrpcService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddSingleton(provider =>
{
    var channel = GrpcChannel.ForAddress("https://localhost:7268"); // Replace with your gRPC server URL
    return channel;
});

// Register GreeterClient, which now needs a GrpcChannel
builder.Services.AddSingleton<GreeterClient>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();