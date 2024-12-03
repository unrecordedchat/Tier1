// using GrpcService.Services;

using Grpc.Net.Client;
using GrpcService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddGrpc();
builder.Services.AddSingleton<GrpcChannel>();
builder.Services.AddSingleton(services => GrpcChannel.ForAddress("https://localhost:7268"));
builder.Services.AddScoped<GreeterClient>();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.MapGet("/",
    () =>
        "Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");

app.Run();