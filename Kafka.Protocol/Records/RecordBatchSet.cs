using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.IO.Pipelines;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Log.It;

namespace Kafka.Protocol.Records
{
    public class RecordBatchSet : RecordBatchSetBase
    {
        internal static RecordBatchSet Default => new RecordBatchSet();
        
        internal static ValueTask<RecordBatchSet> FromReaderAsync(
            PipeReader reader,
            bool asCompact,
            CancellationToken cancellationToken = default) =>
            FromReaderAsync(new RecordBatchSet(), reader,
                asCompact, cancellationToken);

        public RecordBatchSet()
        {
        }

        public RecordBatchSet(RecordBatchSetBase set) : base(set)
        {
        }
    }
    
    public abstract class RecordBatchSetBase: ISerialize
    {
        private static readonly ILogger _logger =
            LogFactory.Create<RecordBatchSetBase>();
        
        public int Size { get; private set; }

        protected RecordBatchSetBase()
        {
        }

        protected RecordBatchSetBase(RecordBatchSetBase set)
        {
            Size = set.Size;
            Batches = set.Batches;
        }

        public IList<RecordBatch> Batches { get; private set; } =
            new List<RecordBatch>();
        
        ValueTask ISerialize.WriteToAsync(Stream writer, bool asCompact,
            CancellationToken cancellationToken)
        {
            return WriteToAsync(writer, asCompact, cancellationToken);
        }
        
        internal ValueTask WriteToAsync(Stream writer, bool asCompact,
            CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        int ISerialize.GetSize(bool asCompact) => GetSize(asCompact);

        internal int GetSize(bool asCompact)
        {
            var size = 0/*asCompact
                ? UVarInt.From((uint)Size)
                    .GetSize(true)
                : Int32.From(Size).GetSize(false)*/;
            foreach (var batch in Batches)
            {
                size += batch.GetSize(asCompact);
            }

            return size;
        }

        internal static async ValueTask<T> FromReaderAsync<T>(
            T batchArray,
            PipeReader reader,
            bool asCompact,
            CancellationToken cancellationToken = default) where T : RecordBatchSetBase
        {
            batchArray.Size = asCompact
                ? (int)(await UVarInt
                    .FromReaderAsync(reader, true, cancellationToken)
                    .ConfigureAwait(false)).Value - 1
                : (int)await Int32.FromReaderAsync(reader, false, cancellationToken)
                    .ConfigureAwait(false);
            _logger.Debug("Batch set size: {@size}", batchArray.Size);
            var batchArraySize = 0;
            for (int remainder; (remainder = batchArray.Size - batchArraySize) > 0;)
            {
                _logger.Debug("Batch set remainder: {@remainder}", remainder);
                var batch = await RecordBatch.FromReaderAsync(reader, asCompact, remainder, cancellationToken).ConfigureAwait(false);
                if (batch == null)
                {
                    _logger.Debug("Incomplete batch, ignored.");
                    break;
                }
                
                batchArray.Batches.Add(batch);
                batchArraySize += batch.GetSize(asCompact);
            }

            _logger.Debug("Batch set actual size: {@size}", batchArray.GetSize(asCompact));

            return batchArray;
        }
    }

    public class NullableRecordBatchSet : RecordBatchSetBase
    {
        
        public NullableRecordBatchSet()
        {
        }

        public NullableRecordBatchSet(RecordBatchSetBase set) : base(set)
        {
        }
        
        internal static RecordBatchSet Default => new RecordBatchSet();
        
        internal static ValueTask<NullableRecordBatchSet> FromReaderAsync(
            PipeReader reader,
            bool asCompact,
            CancellationToken cancellationToken = default) =>
            FromReaderAsync(new NullableRecordBatchSet(), reader,
                asCompact, cancellationToken);
        
        public static implicit operator RecordBatchSet?(NullableRecordBatchSet recordBatch) =>
            new RecordBatchSet(recordBatch);

        public static implicit operator NullableRecordBatchSet(RecordBatchSet? recordBatch) =>
            new NullableRecordBatchSet(recordBatch);
    }
}