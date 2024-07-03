﻿// WARNING! THIS FILE IS AUTO-GENERATED! DO NOT EDIT.
using System.IO.Pipelines;
using System.Threading;
using System.Threading.Tasks;

namespace Kafka.Protocol
{
    public static partial class Messages
    {
        public static ValueTask<Message> CreateRequestMessageFromReaderAsync(Int16 apiKey, Int16 version, PipeReader reader, CancellationToken cancellationToken = default)
        {
            if (AddOffsetsToTxnRequest.ApiKey == apiKey)
                return AddOffsetsToTxnRequest.FromReaderAsync(version, reader, cancellationToken);
            if (AddPartitionsToTxnRequest.ApiKey == apiKey)
                return AddPartitionsToTxnRequest.FromReaderAsync(version, reader, cancellationToken);
            if (AddRaftVoterRequest.ApiKey == apiKey)
                return AddRaftVoterRequest.FromReaderAsync(version, reader, cancellationToken);
            if (AllocateProducerIdsRequest.ApiKey == apiKey)
                return AllocateProducerIdsRequest.FromReaderAsync(version, reader, cancellationToken);
            if (AlterClientQuotasRequest.ApiKey == apiKey)
                return AlterClientQuotasRequest.FromReaderAsync(version, reader, cancellationToken);
            if (AlterConfigsRequest.ApiKey == apiKey)
                return AlterConfigsRequest.FromReaderAsync(version, reader, cancellationToken);
            if (AlterPartitionReassignmentsRequest.ApiKey == apiKey)
                return AlterPartitionReassignmentsRequest.FromReaderAsync(version, reader, cancellationToken);
            if (AlterPartitionRequest.ApiKey == apiKey)
                return AlterPartitionRequest.FromReaderAsync(version, reader, cancellationToken);
            if (AlterReplicaLogDirsRequest.ApiKey == apiKey)
                return AlterReplicaLogDirsRequest.FromReaderAsync(version, reader, cancellationToken);
            if (AlterUserScramCredentialsRequest.ApiKey == apiKey)
                return AlterUserScramCredentialsRequest.FromReaderAsync(version, reader, cancellationToken);
            if (ApiVersionsRequest.ApiKey == apiKey)
                return ApiVersionsRequest.FromReaderAsync(version, reader, cancellationToken);
            if (AssignReplicasToDirsRequest.ApiKey == apiKey)
                return AssignReplicasToDirsRequest.FromReaderAsync(version, reader, cancellationToken);
            if (BeginQuorumEpochRequest.ApiKey == apiKey)
                return BeginQuorumEpochRequest.FromReaderAsync(version, reader, cancellationToken);
            if (BrokerHeartbeatRequest.ApiKey == apiKey)
                return BrokerHeartbeatRequest.FromReaderAsync(version, reader, cancellationToken);
            if (BrokerRegistrationRequest.ApiKey == apiKey)
                return BrokerRegistrationRequest.FromReaderAsync(version, reader, cancellationToken);
            if (ConsumerGroupDescribeRequest.ApiKey == apiKey)
                return ConsumerGroupDescribeRequest.FromReaderAsync(version, reader, cancellationToken);
            if (ConsumerGroupHeartbeatRequest.ApiKey == apiKey)
                return ConsumerGroupHeartbeatRequest.FromReaderAsync(version, reader, cancellationToken);
            if (ControlledShutdownRequest.ApiKey == apiKey)
                return ControlledShutdownRequest.FromReaderAsync(version, reader, cancellationToken);
            if (ControllerRegistrationRequest.ApiKey == apiKey)
                return ControllerRegistrationRequest.FromReaderAsync(version, reader, cancellationToken);
            if (CreateAclsRequest.ApiKey == apiKey)
                return CreateAclsRequest.FromReaderAsync(version, reader, cancellationToken);
            if (CreateDelegationTokenRequest.ApiKey == apiKey)
                return CreateDelegationTokenRequest.FromReaderAsync(version, reader, cancellationToken);
            if (CreatePartitionsRequest.ApiKey == apiKey)
                return CreatePartitionsRequest.FromReaderAsync(version, reader, cancellationToken);
            if (CreateTopicsRequest.ApiKey == apiKey)
                return CreateTopicsRequest.FromReaderAsync(version, reader, cancellationToken);
            if (DeleteAclsRequest.ApiKey == apiKey)
                return DeleteAclsRequest.FromReaderAsync(version, reader, cancellationToken);
            if (DeleteGroupsRequest.ApiKey == apiKey)
                return DeleteGroupsRequest.FromReaderAsync(version, reader, cancellationToken);
            if (DeleteRecordsRequest.ApiKey == apiKey)
                return DeleteRecordsRequest.FromReaderAsync(version, reader, cancellationToken);
            if (DeleteShareGroupStateRequest.ApiKey == apiKey)
                return DeleteShareGroupStateRequest.FromReaderAsync(version, reader, cancellationToken);
            if (DeleteTopicsRequest.ApiKey == apiKey)
                return DeleteTopicsRequest.FromReaderAsync(version, reader, cancellationToken);
            if (DescribeAclsRequest.ApiKey == apiKey)
                return DescribeAclsRequest.FromReaderAsync(version, reader, cancellationToken);
            if (DescribeClientQuotasRequest.ApiKey == apiKey)
                return DescribeClientQuotasRequest.FromReaderAsync(version, reader, cancellationToken);
            if (DescribeClusterRequest.ApiKey == apiKey)
                return DescribeClusterRequest.FromReaderAsync(version, reader, cancellationToken);
            if (DescribeConfigsRequest.ApiKey == apiKey)
                return DescribeConfigsRequest.FromReaderAsync(version, reader, cancellationToken);
            if (DescribeDelegationTokenRequest.ApiKey == apiKey)
                return DescribeDelegationTokenRequest.FromReaderAsync(version, reader, cancellationToken);
            if (DescribeGroupsRequest.ApiKey == apiKey)
                return DescribeGroupsRequest.FromReaderAsync(version, reader, cancellationToken);
            if (DescribeLogDirsRequest.ApiKey == apiKey)
                return DescribeLogDirsRequest.FromReaderAsync(version, reader, cancellationToken);
            if (DescribeProducersRequest.ApiKey == apiKey)
                return DescribeProducersRequest.FromReaderAsync(version, reader, cancellationToken);
            if (DescribeQuorumRequest.ApiKey == apiKey)
                return DescribeQuorumRequest.FromReaderAsync(version, reader, cancellationToken);
            if (DescribeTopicPartitionsRequest.ApiKey == apiKey)
                return DescribeTopicPartitionsRequest.FromReaderAsync(version, reader, cancellationToken);
            if (DescribeTransactionsRequest.ApiKey == apiKey)
                return DescribeTransactionsRequest.FromReaderAsync(version, reader, cancellationToken);
            if (DescribeUserScramCredentialsRequest.ApiKey == apiKey)
                return DescribeUserScramCredentialsRequest.FromReaderAsync(version, reader, cancellationToken);
            if (ElectLeadersRequest.ApiKey == apiKey)
                return ElectLeadersRequest.FromReaderAsync(version, reader, cancellationToken);
            if (EndQuorumEpochRequest.ApiKey == apiKey)
                return EndQuorumEpochRequest.FromReaderAsync(version, reader, cancellationToken);
            if (EndTxnRequest.ApiKey == apiKey)
                return EndTxnRequest.FromReaderAsync(version, reader, cancellationToken);
            if (EnvelopeRequest.ApiKey == apiKey)
                return EnvelopeRequest.FromReaderAsync(version, reader, cancellationToken);
            if (ExpireDelegationTokenRequest.ApiKey == apiKey)
                return ExpireDelegationTokenRequest.FromReaderAsync(version, reader, cancellationToken);
            if (FetchRequest.ApiKey == apiKey)
                return FetchRequest.FromReaderAsync(version, reader, cancellationToken);
            if (FetchSnapshotRequest.ApiKey == apiKey)
                return FetchSnapshotRequest.FromReaderAsync(version, reader, cancellationToken);
            if (FindCoordinatorRequest.ApiKey == apiKey)
                return FindCoordinatorRequest.FromReaderAsync(version, reader, cancellationToken);
            if (GetTelemetrySubscriptionsRequest.ApiKey == apiKey)
                return GetTelemetrySubscriptionsRequest.FromReaderAsync(version, reader, cancellationToken);
            if (HeartbeatRequest.ApiKey == apiKey)
                return HeartbeatRequest.FromReaderAsync(version, reader, cancellationToken);
            if (IncrementalAlterConfigsRequest.ApiKey == apiKey)
                return IncrementalAlterConfigsRequest.FromReaderAsync(version, reader, cancellationToken);
            if (InitializeShareGroupStateRequest.ApiKey == apiKey)
                return InitializeShareGroupStateRequest.FromReaderAsync(version, reader, cancellationToken);
            if (InitProducerIdRequest.ApiKey == apiKey)
                return InitProducerIdRequest.FromReaderAsync(version, reader, cancellationToken);
            if (JoinGroupRequest.ApiKey == apiKey)
                return JoinGroupRequest.FromReaderAsync(version, reader, cancellationToken);
            if (LeaderAndIsrRequest.ApiKey == apiKey)
                return LeaderAndIsrRequest.FromReaderAsync(version, reader, cancellationToken);
            if (LeaveGroupRequest.ApiKey == apiKey)
                return LeaveGroupRequest.FromReaderAsync(version, reader, cancellationToken);
            if (ListClientMetricsResourcesRequest.ApiKey == apiKey)
                return ListClientMetricsResourcesRequest.FromReaderAsync(version, reader, cancellationToken);
            if (ListGroupsRequest.ApiKey == apiKey)
                return ListGroupsRequest.FromReaderAsync(version, reader, cancellationToken);
            if (ListOffsetsRequest.ApiKey == apiKey)
                return ListOffsetsRequest.FromReaderAsync(version, reader, cancellationToken);
            if (ListPartitionReassignmentsRequest.ApiKey == apiKey)
                return ListPartitionReassignmentsRequest.FromReaderAsync(version, reader, cancellationToken);
            if (ListTransactionsRequest.ApiKey == apiKey)
                return ListTransactionsRequest.FromReaderAsync(version, reader, cancellationToken);
            if (MetadataRequest.ApiKey == apiKey)
                return MetadataRequest.FromReaderAsync(version, reader, cancellationToken);
            if (OffsetCommitRequest.ApiKey == apiKey)
                return OffsetCommitRequest.FromReaderAsync(version, reader, cancellationToken);
            if (OffsetDeleteRequest.ApiKey == apiKey)
                return OffsetDeleteRequest.FromReaderAsync(version, reader, cancellationToken);
            if (OffsetFetchRequest.ApiKey == apiKey)
                return OffsetFetchRequest.FromReaderAsync(version, reader, cancellationToken);
            if (OffsetForLeaderEpochRequest.ApiKey == apiKey)
                return OffsetForLeaderEpochRequest.FromReaderAsync(version, reader, cancellationToken);
            if (ProduceRequest.ApiKey == apiKey)
                return ProduceRequest.FromReaderAsync(version, reader, cancellationToken);
            if (PushTelemetryRequest.ApiKey == apiKey)
                return PushTelemetryRequest.FromReaderAsync(version, reader, cancellationToken);
            if (ReadShareGroupStateRequest.ApiKey == apiKey)
                return ReadShareGroupStateRequest.FromReaderAsync(version, reader, cancellationToken);
            if (ReadShareGroupStateSummaryRequest.ApiKey == apiKey)
                return ReadShareGroupStateSummaryRequest.FromReaderAsync(version, reader, cancellationToken);
            if (RemoveRaftVoterRequest.ApiKey == apiKey)
                return RemoveRaftVoterRequest.FromReaderAsync(version, reader, cancellationToken);
            if (RenewDelegationTokenRequest.ApiKey == apiKey)
                return RenewDelegationTokenRequest.FromReaderAsync(version, reader, cancellationToken);
            if (SaslAuthenticateRequest.ApiKey == apiKey)
                return SaslAuthenticateRequest.FromReaderAsync(version, reader, cancellationToken);
            if (SaslHandshakeRequest.ApiKey == apiKey)
                return SaslHandshakeRequest.FromReaderAsync(version, reader, cancellationToken);
            if (ShareAcknowledgeRequest.ApiKey == apiKey)
                return ShareAcknowledgeRequest.FromReaderAsync(version, reader, cancellationToken);
            if (ShareFetchRequest.ApiKey == apiKey)
                return ShareFetchRequest.FromReaderAsync(version, reader, cancellationToken);
            if (ShareGroupDescribeRequest.ApiKey == apiKey)
                return ShareGroupDescribeRequest.FromReaderAsync(version, reader, cancellationToken);
            if (ShareGroupHeartbeatRequest.ApiKey == apiKey)
                return ShareGroupHeartbeatRequest.FromReaderAsync(version, reader, cancellationToken);
            if (StopReplicaRequest.ApiKey == apiKey)
                return StopReplicaRequest.FromReaderAsync(version, reader, cancellationToken);
            if (SyncGroupRequest.ApiKey == apiKey)
                return SyncGroupRequest.FromReaderAsync(version, reader, cancellationToken);
            if (TxnOffsetCommitRequest.ApiKey == apiKey)
                return TxnOffsetCommitRequest.FromReaderAsync(version, reader, cancellationToken);
            if (UnregisterBrokerRequest.ApiKey == apiKey)
                return UnregisterBrokerRequest.FromReaderAsync(version, reader, cancellationToken);
            if (UpdateFeaturesRequest.ApiKey == apiKey)
                return UpdateFeaturesRequest.FromReaderAsync(version, reader, cancellationToken);
            if (UpdateMetadataRequest.ApiKey == apiKey)
                return UpdateMetadataRequest.FromReaderAsync(version, reader, cancellationToken);
            if (UpdateRaftVoterRequest.ApiKey == apiKey)
                return UpdateRaftVoterRequest.FromReaderAsync(version, reader, cancellationToken);
            if (VoteRequest.ApiKey == apiKey)
                return VoteRequest.FromReaderAsync(version, reader, cancellationToken);
            if (WriteShareGroupStateRequest.ApiKey == apiKey)
                return WriteShareGroupStateRequest.FromReaderAsync(version, reader, cancellationToken);
            if (WriteTxnMarkersRequest.ApiKey == apiKey)
                return WriteTxnMarkersRequest.FromReaderAsync(version, reader, cancellationToken);
            throw new ArgumentException($"There is no request message with api key {apiKey}");
        }
    }
}
