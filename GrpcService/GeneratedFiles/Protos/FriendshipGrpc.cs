// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/friendship.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981, 0612
#region Designer generated code

using grpc = global::Grpc.Core;

namespace GrpcService {
  public static partial class FriendshipService
  {
    static readonly string __ServiceName = "FriendshipService";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GrpcService.FriendshipStatusRequest> __Marshaller_FriendshipStatusRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcService.FriendshipStatusRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GrpcService.FriendshipResponseStatus> __Marshaller_FriendshipResponseStatus = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcService.FriendshipResponseStatus.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GrpcService.FriendshipRequest> __Marshaller_FriendshipRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcService.FriendshipRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GrpcService.FriendshipDTO> __Marshaller_FriendshipDTO = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcService.FriendshipDTO.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GrpcService.FriendshipUserIdRequest> __Marshaller_FriendshipUserIdRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcService.FriendshipUserIdRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GrpcService.FriendshipListResponse> __Marshaller_FriendshipListResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcService.FriendshipListResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::GrpcService.FriendshipStatusRequest, global::GrpcService.FriendshipResponseStatus> __Method_CreateFriendship = new grpc::Method<global::GrpcService.FriendshipStatusRequest, global::GrpcService.FriendshipResponseStatus>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateFriendship",
        __Marshaller_FriendshipStatusRequest,
        __Marshaller_FriendshipResponseStatus);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::GrpcService.FriendshipRequest, global::GrpcService.FriendshipDTO> __Method_GetFriendship = new grpc::Method<global::GrpcService.FriendshipRequest, global::GrpcService.FriendshipDTO>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetFriendship",
        __Marshaller_FriendshipRequest,
        __Marshaller_FriendshipDTO);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::GrpcService.FriendshipUserIdRequest, global::GrpcService.FriendshipListResponse> __Method_GetAllFriendships = new grpc::Method<global::GrpcService.FriendshipUserIdRequest, global::GrpcService.FriendshipListResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetAllFriendships",
        __Marshaller_FriendshipUserIdRequest,
        __Marshaller_FriendshipListResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::GrpcService.FriendshipStatusRequest, global::GrpcService.FriendshipResponseStatus> __Method_UpdateFriendshipStatus = new grpc::Method<global::GrpcService.FriendshipStatusRequest, global::GrpcService.FriendshipResponseStatus>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateFriendshipStatus",
        __Marshaller_FriendshipStatusRequest,
        __Marshaller_FriendshipResponseStatus);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::GrpcService.FriendshipRequest, global::GrpcService.FriendshipResponseStatus> __Method_DeleteFriendship = new grpc::Method<global::GrpcService.FriendshipRequest, global::GrpcService.FriendshipResponseStatus>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteFriendship",
        __Marshaller_FriendshipRequest,
        __Marshaller_FriendshipResponseStatus);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::GrpcService.FriendshipReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of FriendshipService</summary>
    [grpc::BindServiceMethod(typeof(FriendshipService), "BindService")]
    public abstract partial class FriendshipServiceBase
    {
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::GrpcService.FriendshipResponseStatus> CreateFriendship(global::GrpcService.FriendshipStatusRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::GrpcService.FriendshipDTO> GetFriendship(global::GrpcService.FriendshipRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::GrpcService.FriendshipListResponse> GetAllFriendships(global::GrpcService.FriendshipUserIdRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::GrpcService.FriendshipResponseStatus> UpdateFriendshipStatus(global::GrpcService.FriendshipStatusRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::GrpcService.FriendshipResponseStatus> DeleteFriendship(global::GrpcService.FriendshipRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for FriendshipService</summary>
    public partial class FriendshipServiceClient : grpc::ClientBase<FriendshipServiceClient>
    {
      /// <summary>Creates a new client for FriendshipService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public FriendshipServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for FriendshipService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public FriendshipServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected FriendshipServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected FriendshipServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::GrpcService.FriendshipResponseStatus CreateFriendship(global::GrpcService.FriendshipStatusRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateFriendship(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::GrpcService.FriendshipResponseStatus CreateFriendship(global::GrpcService.FriendshipStatusRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CreateFriendship, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::GrpcService.FriendshipResponseStatus> CreateFriendshipAsync(global::GrpcService.FriendshipStatusRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateFriendshipAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::GrpcService.FriendshipResponseStatus> CreateFriendshipAsync(global::GrpcService.FriendshipStatusRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CreateFriendship, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::GrpcService.FriendshipDTO GetFriendship(global::GrpcService.FriendshipRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetFriendship(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::GrpcService.FriendshipDTO GetFriendship(global::GrpcService.FriendshipRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetFriendship, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::GrpcService.FriendshipDTO> GetFriendshipAsync(global::GrpcService.FriendshipRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetFriendshipAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::GrpcService.FriendshipDTO> GetFriendshipAsync(global::GrpcService.FriendshipRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetFriendship, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::GrpcService.FriendshipListResponse GetAllFriendships(global::GrpcService.FriendshipUserIdRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAllFriendships(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::GrpcService.FriendshipListResponse GetAllFriendships(global::GrpcService.FriendshipUserIdRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetAllFriendships, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::GrpcService.FriendshipListResponse> GetAllFriendshipsAsync(global::GrpcService.FriendshipUserIdRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAllFriendshipsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::GrpcService.FriendshipListResponse> GetAllFriendshipsAsync(global::GrpcService.FriendshipUserIdRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetAllFriendships, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::GrpcService.FriendshipResponseStatus UpdateFriendshipStatus(global::GrpcService.FriendshipStatusRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateFriendshipStatus(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::GrpcService.FriendshipResponseStatus UpdateFriendshipStatus(global::GrpcService.FriendshipStatusRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_UpdateFriendshipStatus, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::GrpcService.FriendshipResponseStatus> UpdateFriendshipStatusAsync(global::GrpcService.FriendshipStatusRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateFriendshipStatusAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::GrpcService.FriendshipResponseStatus> UpdateFriendshipStatusAsync(global::GrpcService.FriendshipStatusRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_UpdateFriendshipStatus, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::GrpcService.FriendshipResponseStatus DeleteFriendship(global::GrpcService.FriendshipRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteFriendship(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::GrpcService.FriendshipResponseStatus DeleteFriendship(global::GrpcService.FriendshipRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DeleteFriendship, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::GrpcService.FriendshipResponseStatus> DeleteFriendshipAsync(global::GrpcService.FriendshipRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteFriendshipAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::GrpcService.FriendshipResponseStatus> DeleteFriendshipAsync(global::GrpcService.FriendshipRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DeleteFriendship, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override FriendshipServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new FriendshipServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(FriendshipServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_CreateFriendship, serviceImpl.CreateFriendship)
          .AddMethod(__Method_GetFriendship, serviceImpl.GetFriendship)
          .AddMethod(__Method_GetAllFriendships, serviceImpl.GetAllFriendships)
          .AddMethod(__Method_UpdateFriendshipStatus, serviceImpl.UpdateFriendshipStatus)
          .AddMethod(__Method_DeleteFriendship, serviceImpl.DeleteFriendship).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, FriendshipServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_CreateFriendship, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcService.FriendshipStatusRequest, global::GrpcService.FriendshipResponseStatus>(serviceImpl.CreateFriendship));
      serviceBinder.AddMethod(__Method_GetFriendship, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcService.FriendshipRequest, global::GrpcService.FriendshipDTO>(serviceImpl.GetFriendship));
      serviceBinder.AddMethod(__Method_GetAllFriendships, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcService.FriendshipUserIdRequest, global::GrpcService.FriendshipListResponse>(serviceImpl.GetAllFriendships));
      serviceBinder.AddMethod(__Method_UpdateFriendshipStatus, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcService.FriendshipStatusRequest, global::GrpcService.FriendshipResponseStatus>(serviceImpl.UpdateFriendshipStatus));
      serviceBinder.AddMethod(__Method_DeleteFriendship, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcService.FriendshipRequest, global::GrpcService.FriendshipResponseStatus>(serviceImpl.DeleteFriendship));
    }

  }
}
#endregion
