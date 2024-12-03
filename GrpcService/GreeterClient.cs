using Grpc.Net.Client;

namespace GrpcService;

public class GreeterClient
{
    private GreeterProtoService.GreeterProtoServiceClient _client;

    public GreeterClient(GrpcChannel channel)
    {
        _client = new GreeterProtoService.GreeterProtoServiceClient(channel);
    }
    
    public string SayHelloAsync(string name)
    {
        Console.WriteLine("Sending request");
        
        var request = new HelloRequest
        {
            Name = name
        };
        var response =  _client.SayHello(request);
        return response.Message;
    }
}