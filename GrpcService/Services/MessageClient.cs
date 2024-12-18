using Grpc.Net.Client;
using Grpc.Core;

namespace GrpcService.Services
{
    public class MessageClient(GrpcChannel channel, ILogger<MessageClient> logger)
    {
        private readonly MessageService.MessageServiceClient _client = new(channel);

        private ResponseStatus HandleRpcException(RpcException ex, string action)
        {
            logger.LogError(ex, $"Error during {action}: {ex.Status.Detail}");
            return new ResponseStatus
            {
                Success = false,
                Message = $"Error during {action}: {ex.Status.Detail}"
            };
        }

        // Create a new message
        public async Task<ResponseStatus> CreateMessageAsync(MessageDTO message)
        {
            try
            {
                var request = new CreateMessageRequest { Message = message };
                await _client.CreateMessageAsync(request);
                return new ResponseStatus { Success = true, Message = "Message created successfully." };
            }
            catch (RpcException ex)
            {
                return HandleRpcException(ex, "creating message");
            }
        }

        // Get messages between two users
        public async Task<MessageListResponse> GetMessagesBetweenUsersAsync(string senderId, string recipientId)
        {
            if (string.IsNullOrWhiteSpace(senderId) || string.IsNullOrWhiteSpace(recipientId))
                throw new ArgumentException("SenderId and RecipientId cannot be null or empty.");

            try
            {
                var request = new GetMessagesBetweenUsersRequest
                {
                    SenderId = senderId,
                    RecipientId = recipientId
                };
                return await _client.GetMessagesBetweenUsersAsync(request);
            }
            catch (RpcException ex)
            {
                logger.LogError(ex, "Error during retrieving messages between users.");
                throw new Exception($"Error during retrieving messages: {ex.Status.Detail}");
            }
        }

        // Get messages for a specific group
        public async Task<MessageListResponse> GetMessagesForGroupAsync(string groupId)
        {
            if (string.IsNullOrWhiteSpace(groupId))
                throw new ArgumentException("GroupId cannot be null or empty.");

            try
            {
                var request = new GetMessagesForGroupRequest { GroupId = groupId };
                return await _client.GetMessagesForGroupAsync(request);
            }
            catch (RpcException ex)
            {
                logger.LogError(ex, "Error during retrieving group messages.");
                throw new Exception($"Error during retrieving group messages: {ex.Status.Detail}");
            }
        }

        // Update a message's content
        public async Task<ResponseStatus> UpdateMessageContentAsync(string messageId, string newContentEncrypted)
        {
            if (string.IsNullOrWhiteSpace(messageId) || string.IsNullOrWhiteSpace(newContentEncrypted))
                throw new ArgumentException("MessageId and new content cannot be null or empty.");

            try
            {
                var request = new UpdateMessageContentRequest
                {
                    MessageId = messageId,
                    NewContentEncrypted = newContentEncrypted
                };
                await _client.UpdateMessageContentAsync(request);
                return new ResponseStatus { Success = true, Message = "Message content updated successfully." };
            }
            catch (RpcException ex)
            {
                return HandleRpcException(ex, "updating message content");
            }
        }

        // Delete a message permanently
        public async Task<ResponseStatus> DeleteMessageAsync(string messageId)
        {
            if (string.IsNullOrWhiteSpace(messageId))
                throw new ArgumentException("MessageId cannot be null or empty.");

            try
            {
                var request = new DeleteMessageRequest { MessageId = messageId };
                await _client.DeleteMessageAsync(request);
                return new ResponseStatus { Success = true, Message = "Message deleted successfully." };
            }
            catch (RpcException ex)
            {
                return HandleRpcException(ex, "deleting message");
            }
        }

        // Soft delete a message
        public async Task<ResponseStatus> SoftDeleteMessageAsync(string messageId)
        {
            if (string.IsNullOrWhiteSpace(messageId))
                throw new ArgumentException("MessageId cannot be null or empty.");

            try
            {
                var request = new SoftDeleteMessageRequest { MessageId = messageId };
                await _client.SoftDeleteMessageAsync(request);
                return new ResponseStatus { Success = true, Message = "Message soft-deleted successfully." };
            }
            catch (RpcException ex)
            {
                return HandleRpcException(ex, "soft-deleting message");
            }
        }
    }
}
