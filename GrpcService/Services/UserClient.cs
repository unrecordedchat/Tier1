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
        public async Task LoginUserAsync(string username, string password)
        {
            await _client.LoginUserAsync(new LoginRequest
            {
                Username = username,
                Password = password
            });
        }
        public async Task LoginUserByEmailAsync(string email, string password)
        {
            await _client.LoginUserByEmailAsync(new LoginRequest
            {
                Email = email,
                Password = password
            });
        }
    }
}