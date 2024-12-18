using Grpc.Net.Client;
using Grpc.Core;

namespace GrpcService.Services
{
    public class UserClient(GrpcChannel channel, ILogger<UserClient> logger)
    {
        private readonly UserService.UserServiceClient _client = new(channel);

        private ResponseStatus HandleRpcException(RpcException ex, string action)
        {
            logger.LogError(ex, $"Error during {action}: {ex.Status.Detail}");
            return new ResponseStatus
            {
                Success = false,
                Message = $"Error during {action}: {ex.Status.Detail}"
            };
        }

        // Create a new user
        public async Task<ResponseStatus> CreateUserAsync(UserDTO user)
        {
            try
            {
                var grpcResponse = await _client.CreateUserAsync(user);
                return new ResponseStatus
                {
                    Success = grpcResponse.Success,
                    Message = grpcResponse.Message
                };
            }
            catch (RpcException ex)
            {
                return HandleRpcException(ex, "creating user");
            }
        }

        // Get a user by their username
        public async Task<UserDTO> GetUserByUsernameAsync(string username)
        {
            if (string.IsNullOrWhiteSpace(username))
                throw new ArgumentException("Username cannot be null or empty.");

            try
            {
                return await _client.GetUserByUsernameAsync(new UsernameRequest { Username = username });
            }
            catch (RpcException ex)
            {
                logger.LogError(ex, "Error during retrieving user by username.");
                throw new Exception($"Error during retrieving user by username: {ex.Status.Detail}");
            }
        }

        // Update a username
        public async Task<ResponseStatus> UpdateUsernameAsync(string id, string newUsername)
        {
            if (string.IsNullOrWhiteSpace(id) || string.IsNullOrWhiteSpace(newUsername))
                throw new ArgumentException("ID and new username cannot be null or empty.");

            try
            {
                var grpcResponse = await _client.UpdateUsernameAsync(new UpdateUsernameRequest { Id = id, Username = newUsername });
                return new ResponseStatus
                {
                    Success = grpcResponse.Success,
                    Message = grpcResponse.Message
                };
            }
            catch (RpcException ex)
            {
                return HandleRpcException(ex, "updating username");
            }
        }

        // Update email
        public async Task<ResponseStatus> UpdateEmailAsync(string id, string newEmail)
        {
            if (string.IsNullOrWhiteSpace(id) || string.IsNullOrWhiteSpace(newEmail))
                throw new ArgumentException("ID and new email cannot be null or empty.");

            try
            {
                var grpcResponse = await _client.UpdateEmailAsync(new UpdateEmailRequest { Id = id, Email = newEmail });
                return new ResponseStatus
                {
                    Success = grpcResponse.Success,
                    Message = grpcResponse.Message
                };
            }
            catch (RpcException ex)
            {
                return HandleRpcException(ex, "updating email");
            }
        }

        // Update password
        public async Task<ResponseStatus> UpdatePasswordAsync(string id, string newPassword)
        {
            if (string.IsNullOrWhiteSpace(id) || string.IsNullOrWhiteSpace(newPassword))
                throw new ArgumentException("ID and new password cannot be null or empty.");

            try
            {
                var grpcResponse = await _client.UpdatePasswordAsync(new UpdatePasswordRequest { Id = id, Password = newPassword });
                return new ResponseStatus
                {
                    Success = grpcResponse.Success,
                    Message = grpcResponse.Message
                };
            }
            catch (RpcException ex)
            {
                return HandleRpcException(ex, "updating password");
            }
        }

        // Delete a user
        public async Task<ResponseStatus> DeleteUserAsync(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
                throw new ArgumentException("ID cannot be null or empty.");

            try
            {
                var grpcResponse = await _client.DeleteUserAsync(new UserIdRequest { Id = id });
                return new ResponseStatus
                {
                    Success = grpcResponse.Success,
                    Message = grpcResponse.Message
                };
            }
            catch (RpcException ex)
            {
                return HandleRpcException(ex, "deleting user");
            }
        }

        // Log in a user
        public async Task<LoginResponse> LoginUserAsync(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                throw new ArgumentException("Username and password cannot be null or empty.");

            try
            {
                return await _client.LoginUserAsync(new LoginRequest { Username = username, Password = password });
            }
            catch (RpcException ex)
            {
                logger.LogError(ex, "Error during user login.");
                throw new Exception($"Error during user login: {ex.Status.Detail}");
            }
        }

        // Log out a user
        public async Task<ResponseStatus> LogoutUserAsync(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
                throw new ArgumentException("ID cannot be null or empty.");

            try
            {
                var grpcResponse = await _client.LogoutUserAsync(new UserIdRequest { Id = id });
                return new ResponseStatus
                {
                    Success = grpcResponse.Success,
                    Message = grpcResponse.Message
                };
            }
            catch (RpcException ex)
            {
                return HandleRpcException(ex, "logging out user");
            }
        }
    }
}
