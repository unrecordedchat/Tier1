using Grpc.Core;
using Grpc.Net.Client;

namespace GrpcService.Services
{
    public class FriendshipClient
    {
        private readonly FriendshipService.FriendshipServiceClient _client;
        private readonly ILogger<FriendshipClient> _logger;

        public FriendshipClient(GrpcChannel channel, ILogger<FriendshipClient> logger)
        {
            _client = new FriendshipService.FriendshipServiceClient(channel);
            _logger = logger;
        }

        private ResponseStatus HandleRpcException(RpcException ex, string action)
        {
            _logger.LogError(ex, $"Error during {action}: {ex.Status.Detail}");
            return new ResponseStatus
            {
                Success = false,
                Message = $"Error during {action}: {ex.Status.Detail}"
            };
        }

        // Create a new friendship
        public async Task<ResponseStatus> CreateFriendshipAsync(string userId1, string userId2, string status)
        {
            try
            {
                var request = new FriendshipStatusRequest
                {
                    UserId1 = userId1,
                    UserId2 = userId2,
                    Status = status
                };

                var grpcResponse = await _client.CreateFriendshipAsync(request);

                return new ResponseStatus
                {
                    Success = grpcResponse.Success,
                    Message = grpcResponse.Message
                };
            }
            catch (RpcException ex)
            {
                return HandleRpcException(ex, "creating friendship");
            }
        }

        // Get a friendship between two users
        public async Task<FriendshipDTO> GetFriendshipAsync(string userId1, string userId2)
        {
            try
            {
                var request = new FriendshipRequest
                {
                    UserId1 = userId1,
                    UserId2 = userId2
                };

                return await _client.GetFriendshipAsync(request);
            }
            catch (RpcException ex)
            {
                _logger.LogError(ex, "Error during fetching friendship.");
                throw new Exception($"Error during fetching friendship: {ex.Status.Detail}");
            }
        }

        // Get all friendships for a specific user
        public async Task<List<FriendshipDTO>> GetAllFriendshipsAsync(string userId)
        {
            try
            {
                var request = new FriendshipUserIdRequest
                {
                    UserId = userId
                };

                var grpcResponse = await _client.GetAllFriendshipsAsync(request);

                return grpcResponse.Friendships.ToList();
            }
            catch (RpcException ex)
            {
                _logger.LogError(ex, "Error during fetching all friendships.");
                throw new Exception($"Error during fetching all friendships: {ex.Status.Detail}");
            }
        }

        // Update a friendship's status
        public async Task<ResponseStatus> UpdateFriendshipStatusAsync(string userId1, string userId2, string newStatus)
        {
            try
            {
                var request = new FriendshipStatusRequest
                {
                    UserId1 = userId1,
                    UserId2 = userId2,
                    Status = newStatus
                };

                var grpcResponse = await _client.UpdateFriendshipStatusAsync(request);

                return new ResponseStatus
                {
                    Success = grpcResponse.Success,
                    Message = grpcResponse.Message
                };
            }
            catch (RpcException ex)
            {
                return HandleRpcException(ex, "updating friendship status");
            }
        }

        // Delete a friendship
        public async Task<ResponseStatus> DeleteFriendshipAsync(string userId1, string userId2)
        {
            try
            {
                var request = new FriendshipRequest
                {
                    UserId1 = userId1,
                    UserId2 = userId2
                };

                var grpcResponse = await _client.DeleteFriendshipAsync(request);

                return new ResponseStatus
                {
                    Success = grpcResponse.Success,
                    Message = grpcResponse.Message
                };
            }
            catch (RpcException ex)
            {
                return HandleRpcException(ex, "deleting friendship");
            }
        }
    }

    // Helper class to standardize response status for all client methods
    public class ResponseStatus
    {
        public bool Success { get; set; }
        public string Message { get; set; }
    }
}