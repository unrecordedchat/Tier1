using Grpc.Net.Client;

namespace GrpcService.Services
{
    public class UserClient
    {
        private readonly UserService.UserServiceClient _client;

        public UserClient(GrpcChannel channel)
        {
            _client = new UserService.UserServiceClient(channel);
        }

        public async Task CreateUserAsync(UserEntity user)
        {
            await _client.CreateUserAsync(user);
        }
    }
}