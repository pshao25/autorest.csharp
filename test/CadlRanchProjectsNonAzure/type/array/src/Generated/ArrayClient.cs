// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Threading;

namespace Scm._Type._Array
{
    // Data plane generated client.
    /// <summary> The Array service client. </summary>
    public partial class ArrayClient
    {
        private readonly ClientPipeline _pipeline;
        private readonly Uri _endpoint;

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual ClientPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of ArrayClient. </summary>
        public ArrayClient() : this(new Uri("http://localhost:3000"), new ArrayClientOptions())
        {
        }

        /// <summary> Initializes a new instance of ArrayClient. </summary>
        /// <param name="endpoint"> TestServer endpoint. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> is null. </exception>
        public ArrayClient(Uri endpoint, ArrayClientOptions options)
        {
            Argument.AssertNotNull(endpoint, nameof(endpoint));
            options ??= new ArrayClientOptions();

            _pipeline = ClientPipeline.Create(options, Array.Empty<PipelinePolicy>(), Array.Empty<PipelinePolicy>(), Array.Empty<PipelinePolicy>());
            _endpoint = endpoint;
        }

        private Int32Value _cachedInt32Value;
        private Int64Value _cachedInt64Value;
        private BooleanValue _cachedBooleanValue;
        private StringValue _cachedStringValue;
        private Float32Value _cachedFloat32Value;
        private DatetimeValue _cachedDatetimeValue;
        private DurationValue _cachedDurationValue;
        private UnknownValue _cachedUnknownValue;
        private ModelValue _cachedModelValue;
        private NullableFloatValue _cachedNullableFloatValue;

        /// <summary> Initializes a new instance of Int32Value. </summary>
        public virtual Int32Value GetInt32ValueClient()
        {
            return Volatile.Read(ref _cachedInt32Value) ?? Interlocked.CompareExchange(ref _cachedInt32Value, new Int32Value(_pipeline, _endpoint), null) ?? _cachedInt32Value;
        }

        /// <summary> Initializes a new instance of Int64Value. </summary>
        public virtual Int64Value GetInt64ValueClient()
        {
            return Volatile.Read(ref _cachedInt64Value) ?? Interlocked.CompareExchange(ref _cachedInt64Value, new Int64Value(_pipeline, _endpoint), null) ?? _cachedInt64Value;
        }

        /// <summary> Initializes a new instance of BooleanValue. </summary>
        public virtual BooleanValue GetBooleanValueClient()
        {
            return Volatile.Read(ref _cachedBooleanValue) ?? Interlocked.CompareExchange(ref _cachedBooleanValue, new BooleanValue(_pipeline, _endpoint), null) ?? _cachedBooleanValue;
        }

        /// <summary> Initializes a new instance of StringValue. </summary>
        public virtual StringValue GetStringValueClient()
        {
            return Volatile.Read(ref _cachedStringValue) ?? Interlocked.CompareExchange(ref _cachedStringValue, new StringValue(_pipeline, _endpoint), null) ?? _cachedStringValue;
        }

        /// <summary> Initializes a new instance of Float32Value. </summary>
        public virtual Float32Value GetFloat32ValueClient()
        {
            return Volatile.Read(ref _cachedFloat32Value) ?? Interlocked.CompareExchange(ref _cachedFloat32Value, new Float32Value(_pipeline, _endpoint), null) ?? _cachedFloat32Value;
        }

        /// <summary> Initializes a new instance of DatetimeValue. </summary>
        public virtual DatetimeValue GetDatetimeValueClient()
        {
            return Volatile.Read(ref _cachedDatetimeValue) ?? Interlocked.CompareExchange(ref _cachedDatetimeValue, new DatetimeValue(_pipeline, _endpoint), null) ?? _cachedDatetimeValue;
        }

        /// <summary> Initializes a new instance of DurationValue. </summary>
        public virtual DurationValue GetDurationValueClient()
        {
            return Volatile.Read(ref _cachedDurationValue) ?? Interlocked.CompareExchange(ref _cachedDurationValue, new DurationValue(_pipeline, _endpoint), null) ?? _cachedDurationValue;
        }

        /// <summary> Initializes a new instance of UnknownValue. </summary>
        public virtual UnknownValue GetUnknownValueClient()
        {
            return Volatile.Read(ref _cachedUnknownValue) ?? Interlocked.CompareExchange(ref _cachedUnknownValue, new UnknownValue(_pipeline, _endpoint), null) ?? _cachedUnknownValue;
        }

        /// <summary> Initializes a new instance of ModelValue. </summary>
        public virtual ModelValue GetModelValueClient()
        {
            return Volatile.Read(ref _cachedModelValue) ?? Interlocked.CompareExchange(ref _cachedModelValue, new ModelValue(_pipeline, _endpoint), null) ?? _cachedModelValue;
        }

        /// <summary> Initializes a new instance of NullableFloatValue. </summary>
        public virtual NullableFloatValue GetNullableFloatValueClient()
        {
            return Volatile.Read(ref _cachedNullableFloatValue) ?? Interlocked.CompareExchange(ref _cachedNullableFloatValue, new NullableFloatValue(_pipeline, _endpoint), null) ?? _cachedNullableFloatValue;
        }
    }
}
