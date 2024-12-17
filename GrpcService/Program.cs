// using GrpcService.Services;

using Grpc.Net.Client;
using GrpcService;
using GrpcService.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddGrpc();
builder.Services.AddSingleton<GrpcChannel>();
builder.Services.AddSingleton(services => GrpcChannel.ForAddress("https://localhost:5195"));
builder.Services.AddScoped<UserClient>();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.MapGet("/",
    () =>
        "Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");

app.Run();