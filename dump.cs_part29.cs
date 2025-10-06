	public string Environment { get; }
	public string IpAddress { get; }
	public string UserAgent { get; }
	public int ErrorCount { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x482990 Offset: 0x481B90 VA: 0x180482990 Slot: 4
	public SentryId get_Id() { }

	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90 Slot: 5
	public string get_DistinctId() { }

	[CompilerGenerated]
	// RVA: 0x3F6C80 Offset: 0x3F5E80 VA: 0x1803F6C80 Slot: 6
	public DateTimeOffset get_StartTimestamp() { }

	[NullableContext(1)]
	[CompilerGenerated]
	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30 Slot: 7
	public string get_Release() { }

	[CompilerGenerated]
	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0 Slot: 8
	public string get_Environment() { }

	[CompilerGenerated]
	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0 Slot: 9
	public string get_IpAddress() { }

	[CompilerGenerated]
	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0 Slot: 10
	public string get_UserAgent() { }

	// RVA: 0x4EDB20 Offset: 0x4ECD20 VA: 0x1804EDB20 Slot: 11
	public int get_ErrorCount() { }

	// RVA: 0x1C69320 Offset: 0x1C68520 VA: 0x181C69320
	internal void .ctor(SentryId id, string distinctId, DateTimeOffset startTimestamp, string release, string environment, string ipAddress, string userAgent) { }

	// RVA: 0x1C693A0 Offset: 0x1C685A0 VA: 0x181C693A0
	public void .ctor(string distinctId, string release, string environment) { }

	// RVA: 0x1C69310 Offset: 0x1C68510 VA: 0x181C69310
	public void ReportError() { }

	[NullableContext(1)]
	// RVA: 0x1C69260 Offset: 0x1C68460 VA: 0x181C69260
	internal SessionUpdate CreateUpdate(bool isInitial, DateTimeOffset timestamp, Nullable<SessionEndStatus> endStatus) { }
}

// Namespace: Sentry
public enum SessionEndStatus // TypeDefIndex: 13486
{
	// Fields
	public int value__; // 0x0
	public const SessionEndStatus Exited = 0;
	public const SessionEndStatus Crashed = 1;
	public const SessionEndStatus Abnormal = 2;
}

// Namespace: 
[CompilerGenerated]
private static class SessionUpdate.<>O // TypeDefIndex: 13487
{
	// Fields
	[Nullable(0)]
	public static Func<string, SentryId> <0>__Parse; // 0x0
}

// Namespace: Sentry
[Nullable(0)]
[NullableContext(2)]
public class SessionUpdate : ISession, IJsonSerializable // TypeDefIndex: 13488
{
	// Fields
	[CompilerGenerated]
	private readonly SentryId <Id>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly string <DistinctId>k__BackingField; // 0x20
	[CompilerGenerated]
	private readonly DateTimeOffset <StartTimestamp>k__BackingField; // 0x28
	[CompilerGenerated]
	[Nullable(1)]
	private readonly string <Release>k__BackingField; // 0x38
	[CompilerGenerated]
	private readonly string <Environment>k__BackingField; // 0x40
	[CompilerGenerated]
	private readonly string <IpAddress>k__BackingField; // 0x48
	[CompilerGenerated]
	private readonly string <UserAgent>k__BackingField; // 0x50
	[CompilerGenerated]
	private readonly int <ErrorCount>k__BackingField; // 0x58
	[CompilerGenerated]
	private readonly bool <IsInitial>k__BackingField; // 0x5C
	[CompilerGenerated]
	private readonly DateTimeOffset <Timestamp>k__BackingField; // 0x60
	[CompilerGenerated]
	private readonly int <SequenceNumber>k__BackingField; // 0x70
	[CompilerGenerated]
	private readonly Nullable<SessionEndStatus> <EndStatus>k__BackingField; // 0x74

	// Properties
	public SentryId Id { get; }
	public string DistinctId { get; }
	public DateTimeOffset StartTimestamp { get; }
	[Nullable(1)]
	public string Release { get; }
	public string Environment { get; }
	public string IpAddress { get; }
	public string UserAgent { get; }
	public int ErrorCount { get; }
	public bool IsInitial { get; }
	public DateTimeOffset Timestamp { get; }
	public int SequenceNumber { get; }
	public TimeSpan Duration { get; }
	public Nullable<SessionEndStatus> EndStatus { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x482990 Offset: 0x481B90 VA: 0x180482990 Slot: 4
	public SentryId get_Id() { }

	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90 Slot: 5
	public string get_DistinctId() { }

	[CompilerGenerated]
	// RVA: 0x3F6C80 Offset: 0x3F5E80 VA: 0x1803F6C80 Slot: 6
	public DateTimeOffset get_StartTimestamp() { }

	[NullableContext(1)]
	[CompilerGenerated]
	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30 Slot: 7
	public string get_Release() { }

	[CompilerGenerated]
	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0 Slot: 8
	public string get_Environment() { }

	[CompilerGenerated]
	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0 Slot: 9
	public string get_IpAddress() { }

	[CompilerGenerated]
	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0 Slot: 10
	public string get_UserAgent() { }

	[CompilerGenerated]
	// RVA: 0x4EDB20 Offset: 0x4ECD20 VA: 0x1804EDB20 Slot: 11
	public int get_ErrorCount() { }

	[CompilerGenerated]
	// RVA: 0x526D00 Offset: 0x525F00 VA: 0x180526D00
	public bool get_IsInitial() { }

	[CompilerGenerated]
	// RVA: 0x12DC690 Offset: 0x12DB890 VA: 0x1812DC690
	public DateTimeOffset get_Timestamp() { }

	[CompilerGenerated]
	// RVA: 0x526CC0 Offset: 0x525EC0 VA: 0x180526CC0
	public int get_SequenceNumber() { }

	// RVA: 0x1C691D0 Offset: 0x1C683D0 VA: 0x181C691D0
	public TimeSpan get_Duration() { }

	[CompilerGenerated]
	// RVA: 0x1C69250 Offset: 0x1C68450 VA: 0x181C69250
	public Nullable<SessionEndStatus> get_EndStatus() { }

	// RVA: 0x1C69120 Offset: 0x1C68320 VA: 0x181C69120
	public void .ctor(SentryId id, string distinctId, DateTimeOffset startTimestamp, string release, string environment, string ipAddress, string userAgent, int errorCount, bool isInitial, DateTimeOffset timestamp, int sequenceNumber, Nullable<SessionEndStatus> endStatus) { }

	[NullableContext(1)]
	// RVA: 0x1C68E40 Offset: 0x1C68040 VA: 0x181C68E40
	public void .ctor(ISession session, bool isInitial, DateTimeOffset timestamp, int sequenceNumber, Nullable<SessionEndStatus> endStatus) { }

	[NullableContext(1)]
	// RVA: 0x1C690E0 Offset: 0x1C682E0 VA: 0x181C690E0
	public void .ctor(SessionUpdate sessionUpdate, bool isInitial, Nullable<SessionEndStatus> endStatus) { }

	[NullableContext(1)]
	// RVA: 0x1C68E00 Offset: 0x1C68000 VA: 0x181C68E00
	public void .ctor(SessionUpdate sessionUpdate, bool isInitial) { }

	[NullableContext(1)]
	// RVA: 0x1C68A10 Offset: 0x1C67C10 VA: 0x181C68A10 Slot: 12
	public void WriteTo(Utf8JsonWriter writer, IDiagnosticLogger logger) { }

	[NullableContext(1)]
	// RVA: 0x1C68320 Offset: 0x1C67520 VA: 0x181C68320
	public static SessionUpdate FromJson(JsonElement json) { }
}

// Namespace: 
[CompilerGenerated]
private static class Span.<>O // TypeDefIndex: 13489
{
	// Fields
	[Nullable(0)]
	public static Func<JsonElement, SpanId> <0>__FromJson; // 0x0
	[Nullable(0)]
	public static Func<JsonElement, SentryId> <1>__FromJson; // 0x8
}

// Namespace: Sentry
[Nullable(0)]
[NullableContext(1)]
public class Span : ISpanData, ISpanContext, ITraceContext, IHasTags, IHasExtra, IJsonSerializable // TypeDefIndex: 13490
{
	// Fields
	[CompilerGenerated]
	private SpanId <SpanId>k__BackingField; // 0x10
	[CompilerGenerated]
	private Nullable<SpanId> <ParentSpanId>k__BackingField; // 0x18
	[CompilerGenerated]
	private SentryId <TraceId>k__BackingField; // 0x28
	[CompilerGenerated]
	private DateTimeOffset <StartTimestamp>k__BackingField; // 0x38
	[CompilerGenerated]
	private Nullable<DateTimeOffset> <EndTimestamp>k__BackingField; // 0x48
	[CompilerGenerated]
	private string <Operation>k__BackingField; // 0x60
	[CompilerGenerated]
	[Nullable(2)]
	private string <Description>k__BackingField; // 0x68
	[CompilerGenerated]
	private Nullable<SpanStatus> <Status>k__BackingField; // 0x70
	[CompilerGenerated]
	private Nullable<bool> <IsSampled>k__BackingField; // 0x78
	[Nullable(new[] { 2, 1, 1 })]
	private Dictionary<string, string> _tags; // 0x80
	[Nullable(new[] { 2, 1, 2 })]
	private Dictionary<string, object> _extra; // 0x88

	// Properties
	public SpanId SpanId { get; set; }
	public Nullable<SpanId> ParentSpanId { get; set; }
	public SentryId TraceId { get; set; }
	public DateTimeOffset StartTimestamp { get; set; }
	public Nullable<DateTimeOffset> EndTimestamp { get; set; }
	public bool IsFinished { get; }
	public string Operation { get; set; }
	[Nullable(2)]
	public string Description { get; set; }
	public Nullable<SpanStatus> Status { get; set; }
	public Nullable<bool> IsSampled { get; set; }
	public IReadOnlyDictionary<string, string> Tags { get; }
	[Nullable(new[] { 1, 1, 2 })]
	public IReadOnlyDictionary<string, object> Extra { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0 Slot: 8
	public SpanId get_SpanId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	private void set_SpanId(SpanId value) { }

	[CompilerGenerated]
	// RVA: 0x42D820 Offset: 0x42CA20 VA: 0x18042D820 Slot: 9
	public Nullable<SpanId> get_ParentSpanId() { }

	[CompilerGenerated]
	// RVA: 0x42D8A0 Offset: 0x42CAA0 VA: 0x18042D8A0
	private void set_ParentSpanId(Nullable<SpanId> value) { }

	[CompilerGenerated]
	// RVA: 0x3F6C80 Offset: 0x3F5E80 VA: 0x1803F6C80 Slot: 10
	public SentryId get_TraceId() { }

	[CompilerGenerated]
	// RVA: 0x3F6CA0 Offset: 0x3F5EA0 VA: 0x1803F6CA0
	private void set_TraceId(SentryId value) { }

	[CompilerGenerated]
	// RVA: 0x526C40 Offset: 0x525E40 VA: 0x180526C40 Slot: 4
	public DateTimeOffset get_StartTimestamp() { }

	[CompilerGenerated]
	// RVA: 0x526D50 Offset: 0x525F50 VA: 0x180526D50
	private void set_StartTimestamp(DateTimeOffset value) { }

	[CompilerGenerated]
	// RVA: 0x19B2C50 Offset: 0x19B1E50 VA: 0x1819B2C50 Slot: 5
	public Nullable<DateTimeOffset> get_EndTimestamp() { }

	[CompilerGenerated]
	// RVA: 0x1C6C830 Offset: 0x1C6BA30 VA: 0x181C6C830
	private void set_EndTimestamp(Nullable<DateTimeOffset> value) { }

	// RVA: 0x1C6C770 Offset: 0x1C6B970 VA: 0x181C6C770 Slot: 6
	public bool get_IsFinished() { }

	[CompilerGenerated]
	// RVA: 0x542860 Offset: 0x541A60 VA: 0x180542860 Slot: 11
	public string get_Operation() { }

	[CompilerGenerated]
	// RVA: 0x542AA0 Offset: 0x541CA0 VA: 0x180542AA0
	public void set_Operation(string value) { }

	[CompilerGenerated]
	[NullableContext(2)]
	// RVA: 0x4EDB00 Offset: 0x4ECD00 VA: 0x1804EDB00 Slot: 12
	public string get_Description() { }

	[CompilerGenerated]
	[NullableContext(2)]
	// RVA: 0x4EDE80 Offset: 0x4ED080 VA: 0x1804EDE80
	public void set_Description(string value) { }

	[CompilerGenerated]
	// RVA: 0x4ED980 Offset: 0x4ECB80 VA: 0x1804ED980 Slot: 13
	public Nullable<SpanStatus> get_Status() { }

	[CompilerGenerated]
	// RVA: 0x4EDD30 Offset: 0x4ECF30 VA: 0x1804EDD30
	public void set_Status(Nullable<SpanStatus> value) { }

	[CompilerGenerated]
	// RVA: 0x1B7DB10 Offset: 0x1B7CD10 VA: 0x181B7DB10 Slot: 14
	public Nullable<bool> get_IsSampled() { }

	[CompilerGenerated]
	// RVA: 0x1C6C850 Offset: 0x1C6BA50 VA: 0x181C6C850
	internal void set_IsSampled(Nullable<bool> value) { }

	// RVA: 0x1C6C7B0 Offset: 0x1C6B9B0 VA: 0x181C6C7B0 Slot: 15
	public IReadOnlyDictionary<string, string> get_Tags() { }

	// RVA: 0x1C6BDB0 Offset: 0x1C6AFB0 VA: 0x181C6BDB0 Slot: 16
	public void SetTag(string key, string value) { }

	// RVA: 0x1C6BE70 Offset: 0x1C6B070 VA: 0x181C6BE70 Slot: 17
	public void UnsetTag(string key) { }

	// RVA: 0x1C6C6F0 Offset: 0x1C6B8F0 VA: 0x181C6C6F0 Slot: 18
	public IReadOnlyDictionary<string, object> get_Extra() { }

	// RVA: 0x1C6BCF0 Offset: 0x1C6AEF0 VA: 0x181C6BCF0 Slot: 19
	public void SetExtra(string key, object value) { }

	// RVA: 0x1C6C250 Offset: 0x1C6B450 VA: 0x181C6C250
	public void .ctor(Nullable<SpanId> parentSpanId, string operation) { }

	// RVA: 0x1C6C340 Offset: 0x1C6B540 VA: 0x181C6C340
	public void .ctor(ISpan tracer) { }

	// RVA: 0x1C6BBF0 Offset: 0x1C6ADF0 VA: 0x181C6BBF0 Slot: 7
	public SentryTraceHeader GetTraceHeader() { }

	// RVA: 0x1C6BF20 Offset: 0x1C6B120 VA: 0x181C6BF20 Slot: 20
	public void WriteTo(Utf8JsonWriter writer, IDiagnosticLogger logger) { }

	// RVA: 0x1C6B240 Offset: 0x1C6A440 VA: 0x181C6B240
	public static Span FromJson(JsonElement json) { }

	// RVA: 0x1C6BC70 Offset: 0x1C6AE70 VA: 0x181C6BC70
	internal void Redact() { }
}

// Namespace: Sentry
[Nullable(0)]
[NullableContext(1)]
public class SpanContext : ISpanContext, ITraceContext // TypeDefIndex: 13491
{
	// Fields
	[CompilerGenerated]
	private readonly SpanId <SpanId>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly Nullable<SpanId> <ParentSpanId>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly SentryId <TraceId>k__BackingField; // 0x28
	[CompilerGenerated]
	private string <Operation>k__BackingField; // 0x38
	[CompilerGenerated]
	[Nullable(2)]
	private readonly string <Description>k__BackingField; // 0x40
	[CompilerGenerated]
	private readonly Nullable<SpanStatus> <Status>k__BackingField; // 0x48
	[CompilerGenerated]
	private readonly Nullable<bool> <IsSampled>k__BackingField; // 0x50
	[CompilerGenerated]
	private Instrumenter <Instrumenter>k__BackingField; // 0x54

	// Properties
	public SpanId SpanId { get; }
	public Nullable<SpanId> ParentSpanId { get; }
	public SentryId TraceId { get; }
	public string Operation { get; set; }
	[Nullable(2)]
	public string Description { get; }
	public Nullable<SpanStatus> Status { get; }
	public Nullable<bool> IsSampled { get; }
	public Instrumenter Instrumenter { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0 Slot: 4
	public SpanId get_SpanId() { }

	[CompilerGenerated]
	// RVA: 0x42D820 Offset: 0x42CA20 VA: 0x18042D820 Slot: 5
	public Nullable<SpanId> get_ParentSpanId() { }

	[CompilerGenerated]
	// RVA: 0x3F6C80 Offset: 0x3F5E80 VA: 0x1803F6C80 Slot: 6
	public SentryId get_TraceId() { }

	[CompilerGenerated]
	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30 Slot: 7
	public string get_Operation() { }

	[CompilerGenerated]
	// RVA: 0x40EC50 Offset: 0x40DE50 VA: 0x18040EC50
	public void set_Operation(string value) { }

	[NullableContext(2)]
	[CompilerGenerated]
	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0 Slot: 8
	public string get_Description() { }

	[CompilerGenerated]
	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0 Slot: 9
	public Nullable<SpanStatus> get_Status() { }

	[CompilerGenerated]
	// RVA: 0x1C69510 Offset: 0x1C68710 VA: 0x181C69510 Slot: 10
	public Nullable<bool> get_IsSampled() { }

	[CompilerGenerated]
	// RVA: 0x4D1A40 Offset: 0x4D0C40 VA: 0x1804D1A40
	public Instrumenter get_Instrumenter() { }

	[CompilerGenerated]
	// RVA: 0x4D1A80 Offset: 0x4D0C80 VA: 0x1804D1A80
	internal void set_Instrumenter(Instrumenter value) { }

	// RVA: 0x1C69490 Offset: 0x1C68690 VA: 0x181C69490
	public void .ctor(SpanId spanId, Nullable<SpanId> parentSpanId, SentryId traceId, string operation, string description, Nullable<SpanStatus> status, Nullable<bool> isSampled) { }
}

// Namespace: Sentry
[IsReadOnly]
[Nullable(0)]
[NullableContext(1)]
public struct SpanId : IEquatable<SpanId>, IJsonSerializable // TypeDefIndex: 13492
{
	// Fields
	private static readonly char[] HexChars; // 0x0
	private static readonly RandomValuesFactory Random; // 0x8
	private readonly long _value; // 0x0
	public static readonly SpanId Empty; // 0x10

	// Methods

	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	private long GetValue() { }

	// RVA: 0x1C69E10 Offset: 0x1C69010 VA: 0x181C69E10
	public void .ctor(string value) { }

	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void .ctor(long value) { }

	// RVA: 0x1C696B0 Offset: 0x1C688B0 VA: 0x181C696B0 Slot: 4
	public bool Equals(SpanId other) { }

	[NullableContext(2)]
	// RVA: 0x1C695C0 Offset: 0x1C687C0 VA: 0x181C695C0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1C697E0 Offset: 0x1C689E0 VA: 0x181C697E0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1C698E0 Offset: 0x1C68AE0 VA: 0x181C698E0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1C69520 Offset: 0x1C68720 VA: 0x181C69520
	public static SpanId Create() { }

	// RVA: 0x1C69930 Offset: 0x1C68B30 VA: 0x181C69930 Slot: 5
	public void WriteTo(Utf8JsonWriter writer, IDiagnosticLogger _) { }

	// RVA: 0x1C698B0 Offset: 0x1C68AB0 VA: 0x181C698B0
	public static SpanId Parse(string value) { }

	// RVA: 0x1C69720 Offset: 0x1C68920 VA: 0x181C69720
	public static SpanId FromJson(JsonElement json) { }

	// RVA: 0x1C69E40 Offset: 0x1C69040 VA: 0x181C69E40
	public static bool op_Equality(SpanId left, SpanId right) { }

	// RVA: 0x1C69F60 Offset: 0x1C69160 VA: 0x181C69F60
	public static bool op_Inequality(SpanId left, SpanId right) { }

	// RVA: 0x1C69EE0 Offset: 0x1C690E0 VA: 0x181C69EE0
	public static string op_Implicit(SpanId id) { }

	// RVA: 0x1C69D40 Offset: 0x1C68F40 VA: 0x181C69D40
	private static void .cctor() { }
}

// Namespace: Sentry
public enum SpanStatus // TypeDefIndex: 13493
{
	// Fields
	public int value__; // 0x0
	public const SpanStatus Ok = 0;
	public const SpanStatus DeadlineExceeded = 1;
	public const SpanStatus Unauthenticated = 2;
	public const SpanStatus PermissionDenied = 3;
	public const SpanStatus NotFound = 4;
	public const SpanStatus ResourceExhausted = 5;
	public const SpanStatus InvalidArgument = 6;
	public const SpanStatus Unimplemented = 7;
	public const SpanStatus Unavailable = 8;
	public const SpanStatus InternalError = 9;
	public const SpanStatus UnknownError = 10;
	public const SpanStatus Cancelled = 11;
	public const SpanStatus AlreadyExists = 12;
	public const SpanStatus FailedPrecondition = 13;
	public const SpanStatus Aborted = 14;
	public const SpanStatus OutOfRange = 15;
	public const SpanStatus DataLoss = 16;
}

// Namespace: Sentry
internal static class SpanStatusConverter // TypeDefIndex: 13494
{
	// Methods

	[NullableContext(1)]
	// RVA: 0x1C6A030 Offset: 0x1C69230 VA: 0x181C6A030
	public static SpanStatus FromException(Exception exception) { }

	// RVA: 0x1C6A400 Offset: 0x1C69600 VA: 0x181C6A400
	public static SpanStatus FromHttpStatusCode(int code) { }

	// RVA: 0x1C6A400 Offset: 0x1C69600 VA: 0x181C6A400
	public static SpanStatus FromHttpStatusCode(HttpStatusCode code) { }

	// RVA: 0x1C6A330 Offset: 0x1C69530 VA: 0x181C6A330
	public static SpanStatus FromGrpcStatusCode(int code) { }
}

// Namespace: Sentry
[NullableContext(1)]
[Nullable(0)]
public class SpanTracer : ISpan, ISpanData, ISpanContext, ITraceContext, IHasTags, IHasExtra // TypeDefIndex: 13495
{
	// Fields
	private readonly IHub _hub; // 0x10
	private readonly SentryStopwatch _stopwatch; // 0x18
	[CompilerGenerated]
	private readonly TransactionTracer <Transaction>k__BackingField; // 0x30
	[CompilerGenerated]
	private SpanId <SpanId>k__BackingField; // 0x38
	[CompilerGenerated]
	private readonly Nullable<SpanId> <ParentSpanId>k__BackingField; // 0x40
	[CompilerGenerated]
	private readonly SentryId <TraceId>k__BackingField; // 0x50
	[CompilerGenerated]
	private DateTimeOffset <StartTimestamp>k__BackingField; // 0x60
	[CompilerGenerated]
	private Nullable<DateTimeOffset> <EndTimestamp>k__BackingField; // 0x70
	[CompilerGenerated]
	private string <Operation>k__BackingField; // 0x88
	[CompilerGenerated]
	[Nullable(2)]
	private string <Description>k__BackingField; // 0x90
	[CompilerGenerated]
	private Nullable<SpanStatus> <Status>k__BackingField; // 0x98
	[CompilerGenerated]
	private bool <IsSentryRequest>k__BackingField; // 0xA0
	[CompilerGenerated]
	private Nullable<bool> <IsSampled>k__BackingField; // 0xA1
	[Nullable(new[] { 2, 1, 1 })]
	[CompilerGenerated]
	private ConcurrentDictionary<string, string> <InternalTags>k__BackingField; // 0xA8
	[Nullable(new[] { 1, 1, 2 })]
	private readonly ConcurrentDictionary<string, object> _data; // 0xB0

	// Properties
	internal TransactionTracer Transaction { get; }
	public SpanId SpanId { get; set; }
	public Nullable<SpanId> ParentSpanId { get; }
	public SentryId TraceId { get; }
	public DateTimeOffset StartTimestamp { get; set; }
	public Nullable<DateTimeOffset> EndTimestamp { get; set; }
	public bool IsFinished { get; }
	public string Operation { get; set; }
	[Nullable(2)]
	public string Description { get; set; }
	public Nullable<SpanStatus> Status { get; set; }
	internal bool IsSentryRequest { get; set; }
	public Nullable<bool> IsSampled { get; set; }
	[Nullable(new[] { 2, 1, 1 })]
	internal ConcurrentDictionary<string, string> InternalTags { get; set; }
	public IReadOnlyDictionary<string, string> Tags { get; }
	[Nullable(new[] { 1, 1, 2 })]
	public IReadOnlyDictionary<string, object> Extra { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	internal TransactionTracer get_Transaction() { }

	[CompilerGenerated]
	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30 Slot: 19
	public SpanId get_SpanId() { }

	[CompilerGenerated]
	// RVA: 0x40EC50 Offset: 0x40DE50 VA: 0x18040EC50
	internal void set_SpanId(SpanId value) { }

	[CompilerGenerated]
	// RVA: 0x4D1A20 Offset: 0x4D0C20 VA: 0x1804D1A20 Slot: 20
	public Nullable<SpanId> get_ParentSpanId() { }

	[CompilerGenerated]
	// RVA: 0xC5DC80 Offset: 0xC5CE80 VA: 0x180C5DC80 Slot: 21
	public SentryId get_TraceId() { }

	[CompilerGenerated]
	// RVA: 0x12DC690 Offset: 0x12DB890 VA: 0x1812DC690 Slot: 15
	public DateTimeOffset get_StartTimestamp() { }

	[CompilerGenerated]
	// RVA: 0x12DC6D0 Offset: 0x12DB8D0 VA: 0x1812DC6D0
	internal void set_StartTimestamp(DateTimeOffset value) { }

	[CompilerGenerated]
	// RVA: 0x1C6B120 Offset: 0x1C6A320 VA: 0x181C6B120 Slot: 16
	public Nullable<DateTimeOffset> get_EndTimestamp() { }

	[CompilerGenerated]
	// RVA: 0x1C6B210 Offset: 0x1C6A410 VA: 0x181C6B210
	internal void set_EndTimestamp(Nullable<DateTimeOffset> value) { }

	// RVA: 0x1C6B140 Offset: 0x1C6A340 VA: 0x181C6B140 Slot: 17
	public bool get_IsFinished() { }

	[CompilerGenerated]
	// RVA: 0x42D870 Offset: 0x42CA70 VA: 0x18042D870 Slot: 22
	public string get_Operation() { }

	[CompilerGenerated]
	// RVA: 0x42D8E0 Offset: 0x42CAE0 VA: 0x18042D8E0 Slot: 7
	public void set_Operation(string value) { }

	[NullableContext(2)]
	[CompilerGenerated]
	// RVA: 0x43B560 Offset: 0x43A760 VA: 0x18043B560 Slot: 23
	public string get_Description() { }

	[NullableContext(2)]
	[CompilerGenerated]
	// RVA: 0x43B590 Offset: 0x43A790 VA: 0x18043B590 Slot: 5
	public void set_Description(string value) { }

	[CompilerGenerated]
	// RVA: 0x6DCF50 Offset: 0x6DC150 VA: 0x1806DCF50 Slot: 24
	public Nullable<SpanStatus> get_Status() { }

	[CompilerGenerated]
	// RVA: 0x834540 Offset: 0x833740 VA: 0x180834540 Slot: 9
	public void set_Status(Nullable<SpanStatus> value) { }

	[CompilerGenerated]
	// RVA: 0x1200DC0 Offset: 0x11FFFC0 VA: 0x181200DC0
	internal bool get_IsSentryRequest() { }

	[CompilerGenerated]
	// RVA: 0x1200DD0 Offset: 0x11FFFD0 VA: 0x181200DD0
	internal void set_IsSentryRequest(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1C6B180 Offset: 0x1C6A380 VA: 0x181C6B180 Slot: 25
	public Nullable<bool> get_IsSampled() { }

	[CompilerGenerated]
	// RVA: 0x1C6B230 Offset: 0x1C6A430 VA: 0x181C6B230
	internal void set_IsSampled(Nullable<bool> value) { }

	[CompilerGenerated]
	// RVA: 0x7960B0 Offset: 0x7952B0 VA: 0x1807960B0
	internal ConcurrentDictionary<string, string> get_InternalTags() { }

	[CompilerGenerated]
	// RVA: 0xB83400 Offset: 0xB82600 VA: 0x180B83400
	private void set_InternalTags(ConcurrentDictionary<string, string> value) { }

	// RVA: 0x1C6B190 Offset: 0x1C6A390 VA: 0x181C6B190 Slot: 26
	public IReadOnlyDictionary<string, string> get_Tags() { }

	// RVA: 0x1C6ACC0 Offset: 0x1C69EC0 VA: 0x181C6ACC0 Slot: 27
	public void SetTag(string key, string value) { }

	// RVA: 0x1C6AE00 Offset: 0x1C6A000 VA: 0x181C6AE00 Slot: 28
	public void UnsetTag(string key) { }

	// RVA: 0x796070 Offset: 0x795270 VA: 0x180796070 Slot: 29
	public IReadOnlyDictionary<string, object> get_Extra() { }

	// RVA: 0x1C6AC50 Offset: 0x1C69E50 VA: 0x181C6AC50 Slot: 30
	public void SetExtra(string key, object value) { }

	// RVA: 0x1C6AEC0 Offset: 0x1C6A0C0 VA: 0x181C6AEC0
	public void .ctor(IHub hub, TransactionTracer transaction, Nullable<SpanId> parentSpanId, SentryId traceId, string operation) { }

	// RVA: 0x1C6B000 Offset: 0x1C6A200 VA: 0x181C6B000
	internal void .ctor(IHub hub, TransactionTracer transaction, SpanId spanId, Nullable<SpanId> parentSpanId, SentryId traceId, string operation) { }

	// RVA: 0x1C6AD80 Offset: 0x1C69F80 VA: 0x181C6AD80 Slot: 10
	public ISpan StartChild(string operation) { }

	// RVA: 0x1C6ADD0 Offset: 0x1C69FD0 VA: 0x181C6ADD0
	internal void Unfinish() { }

	// RVA: 0x1C6A8D0 Offset: 0x1C69AD0 VA: 0x181C6A8D0 Slot: 11
	public void Finish() { }

	// RVA: 0x1C6AA20 Offset: 0x1C69C20 VA: 0x181C6AA20 Slot: 12
	public void Finish(SpanStatus status) { }

	// RVA: 0x1C6A6D0 Offset: 0x1C698D0 VA: 0x181C6A6D0 Slot: 13
	public void Finish(Exception exception, SpanStatus status) { }

	// RVA: 0x1C6A4C0 Offset: 0x1C696C0 VA: 0x181C6A4C0 Slot: 14
	public void Finish(Exception exception) { }

	// RVA: 0x1C6ABD0 Offset: 0x1C69DD0 VA: 0x181C6ABD0 Slot: 18
	public SentryTraceHeader GetTraceHeader() { }
}

// Namespace: Sentry
public enum StackTraceMode // TypeDefIndex: 13496
{
	// Fields
	public int value__; // 0x0
	public const StackTraceMode Original = 0;
	public const StackTraceMode Enhanced = 1;
}

// Namespace: Sentry
public enum StartupTimeDetectionMode // TypeDefIndex: 13497
{
	// Fields
	public int value__; // 0x0
	public const StartupTimeDetectionMode None = 0;
	public const StartupTimeDetectionMode Fast = 1;
	public const StartupTimeDetectionMode Best = 2;
}

// Namespace: Sentry
[Nullable(0)]
[NullableContext(1)]
public class StreamAttachmentContent : IAttachmentContent // TypeDefIndex: 13498
{
	// Fields
	private readonly Stream _stream; // 0x10

	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	public void .ctor(Stream stream) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0 Slot: 4
	public Stream GetStream() { }
}

// Namespace: Sentry
[Nullable(0)]
[TypeConverter(typeof(SubstringOrRegexPatternTypeConverter))]
[NullableContext(1)]
public class SubstringOrRegexPattern // TypeDefIndex: 13499
{
	// Fields
	[Nullable(2)]
	private readonly Regex _regex; // 0x10
	[Nullable(2)]
	private readonly string _substring; // 0x18
	private readonly StringComparison _stringComparison; // 0x20

	// Methods

	// RVA: 0x1C6CD20 Offset: 0x1C6BF20 VA: 0x181C6CD20
	public void .ctor(string substringOrRegexPattern, StringComparison comparison = 5) { }

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	public void .ctor(Regex regex) { }

	// RVA: 0x1C6CD70 Offset: 0x1C6BF70 VA: 0x181C6CD70
	public static SubstringOrRegexPattern op_Implicit(string substringOrRegexPattern) { }

	// RVA: 0x1C6CC10 Offset: 0x1C6BE10 VA: 0x181C6CC10 Slot: 3
	public override string ToString() { }

	[NullableContext(2)]
	// RVA: 0x1C6CA60 Offset: 0x1C6BC60 VA: 0x181C6CA60 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x407CA0 Offset: 0x406EA0 VA: 0x180407CA0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1C6CB30 Offset: 0x1C6BD30 VA: 0x181C6CB30
	internal bool IsMatch(string str) { }

	// RVA: 0x1C6CC70 Offset: 0x1C6BE70 VA: 0x181C6CC70
	private static Regex TryParseRegex(string pattern, StringComparison comparison) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class SubstringOrRegexPatternExtensions.<>c__1<T> // TypeDefIndex: 13500
{
	// Fields
	[Nullable(0)]
	public static readonly SubstringOrRegexPatternExtensions.<>c__1<T> <>9; // 0x0
	[Nullable(0)]
	public static Predicate<T> <>9__1_0; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB08330 Offset: 0xB07530 VA: 0x180B08330
	|-SubstringOrRegexPatternExtensions.<>c__1<object>..cctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	|-SubstringOrRegexPatternExtensions.<>c__1<object>..ctor
	*/

	[NullableContext(0)]
	// RVA: -1 Offset: -1
	internal bool <SetWithConfigBinding>b__1_0(T t) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB08750 Offset: 0xB07950 VA: 0x180B08750
	|-SubstringOrRegexPatternExtensions.<>c__1<object>.<SetWithConfigBinding>b__1_0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class SubstringOrRegexPatternExtensions.<>c__DisplayClass0_0 // TypeDefIndex: 13501
{
	// Fields
	[Nullable(0)]
	public string str; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	[NullableContext(0)]
	// RVA: 0x1C70FA0 Offset: 0x1C701A0 VA: 0x181C70FA0
	internal bool <ContainsMatch>b__0(SubstringOrRegexPattern t) { }
}

// Namespace: Sentry
[Extension]
[NullableContext(1)]
[Nullable(0)]
internal static class SubstringOrRegexPatternExtensions // TypeDefIndex: 13502
{
	// Methods

	[Extension]
	// RVA: 0x1C6C860 Offset: 0x1C6BA60 VA: 0x181C6C860
	public static bool ContainsMatch(IEnumerable<SubstringOrRegexPattern> targets, string str) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static IList<T> SetWithConfigBinding<T>(IList<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA816F0 Offset: 0xA808F0 VA: 0x180A816F0
	|-SubstringOrRegexPatternExtensions.SetWithConfigBinding<object>
	*/
}

// Namespace: Sentry
[NullableContext(1)]
[Nullable(0)]
internal class SubstringOrRegexPatternTypeConverter : TypeConverter // TypeDefIndex: 13503
{
	// Methods

	// RVA: 0x1C6C930 Offset: 0x1C6BB30 VA: 0x181C6C930 Slot: 4
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x1C6C9B0 Offset: 0x1C6BBB0 VA: 0x181C6C9B0 Slot: 6
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: Sentry
[TypeConverter(typeof(TracePropagationTargetTypeConverter))]
[Nullable(0)]
[NullableContext(1)]
public class TracePropagationTarget : SubstringOrRegexPattern // TypeDefIndex: 13504
{
	// Methods

	// RVA: 0x1C6CD20 Offset: 0x1C6BF20 VA: 0x181C6CD20
	public void .ctor(string substringOrRegexPattern, StringComparison comparison = 5) { }

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	public void .ctor(Regex regex) { }
}

// Namespace: Sentry
[NullableContext(1)]
[Nullable(0)]
internal class TracePropagationTargetTypeConverter : TypeConverter // TypeDefIndex: 13505
{
	// Methods

	// RVA: 0x1C6CDE0 Offset: 0x1C6BFE0 VA: 0x181C6CDE0 Slot: 4
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x1C6CE60 Offset: 0x1C6C060 VA: 0x181C6CE60 Slot: 6
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private static class Transaction.<>O // TypeDefIndex: 13506
{
	// Fields
	[Nullable(0)]
	public static Func<JsonElement, SentryId> <0>__FromJson; // 0x0
	[Nullable(0)]
	public static Func<JsonElement, Request> <1>__FromJson; // 0x8
	[Nullable(0)]
	public static Func<JsonElement, Contexts> <2>__FromJson; // 0x10
	[Nullable(0)]
	public static Func<JsonElement, User> <3>__FromJson; // 0x18
	[Nullable(0)]
	public static Func<JsonElement, SdkVersion> <4>__FromJson; // 0x20
	[Nullable(0)]
	public static Func<JsonElement, Breadcrumb> <5>__FromJson; // 0x28
	[Nullable(0)]
	public static Func<JsonElement, Measurement> <6>__FromJson; // 0x30
	[Nullable(0)]
	public static Func<JsonElement, Span> <7>__FromJson; // 0x38
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class Transaction.<>c // TypeDefIndex: 13507
{
	// Fields
	[Nullable(0)]
	public static readonly Transaction.<>c <>9; // 0x0
	[Nullable(0)]
	public static Func<ISpan, bool> <>9__119_0; // 0x8
	[Nullable(0)]
	public static Func<ISpan, Span> <>9__119_1; // 0x10
	[Nullable(0)]
	public static Func<JsonElement, string> <>9__128_0; // 0x18

	// Methods

	// RVA: 0x1C862E0 Offset: 0x1C854E0 VA: 0x181C862E0
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	[NullableContext(0)]
	// RVA: 0x1C861F0 Offset: 0x1C853F0 VA: 0x181C861F0
	internal bool <.ctor>b__119_0(ISpan s) { }

	[NullableContext(0)]
	// RVA: 0x1C86280 Offset: 0x1C85480 VA: 0x181C86280
	internal Span <.ctor>b__119_1(ISpan s) { }

	[NullableContext(0)]
	// RVA: 0x1C70C70 Offset: 0x1C6FE70 VA: 0x181C70C70
	internal string <FromJson>b__128_0(JsonElement j) { }
}

// Namespace: Sentry
[Nullable(0)]
[NullableContext(1)]
public class Transaction : ITransactionData, ISpanData, ISpanContext, ITraceContext, IHasTags, IHasExtra, ITransactionContext, IEventLike, IHasBreadcrumbs, IJsonSerializable, IHasDistribution, IHasTransactionNameSource, IHasMeasurements // TypeDefIndex: 13508
{
	// Fields
	[CompilerGenerated]
	private SentryId <EventId>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <Name>k__BackingField; // 0x20
	[CompilerGenerated]
	private readonly TransactionNameSource <NameSource>k__BackingField; // 0x28
	[CompilerGenerated]
	private Nullable<bool> <IsParentSampled>k__BackingField; // 0x2C
	[CompilerGenerated]
	[Nullable(2)]
	private string <Platform>k__BackingField; // 0x30
	[Nullable(2)]
	[CompilerGenerated]
	private string <Release>k__BackingField; // 0x38
	[Nullable(2)]
	[CompilerGenerated]
	private string <Distribution>k__BackingField; // 0x40
	[CompilerGenerated]
	private DateTimeOffset <StartTimestamp>k__BackingField; // 0x48
	[CompilerGenerated]
	private Nullable<DateTimeOffset> <EndTimestamp>k__BackingField; // 0x58
	[CompilerGenerated]
	private Nullable<double> <SampleRate>k__BackingField; // 0x70
	[CompilerGenerated]
	private Nullable<SentryLevel> <Level>k__BackingField; // 0x80
	[Nullable(2)]
	private Request _request; // 0x88
	private readonly Contexts _contexts; // 0x90
	[Nullable(2)]
	private User _user; // 0x98
	[Nullable(2)]
	[CompilerGenerated]
	private string <Environment>k__BackingField; // 0xA0
	[CompilerGenerated]
	private SdkVersion <Sdk>k__BackingField; // 0xA8
	[Nullable(new[] { 2, 1 })]
	private IReadOnlyList<string> _fingerprint; // 0xB0
	private List<Breadcrumb> _breadcrumbs; // 0xB8
	[Nullable(new[] { 1, 1, 2 })]
	private Dictionary<string, object> _extra; // 0xC0
	private Dictionary<string, string> _tags; // 0xC8
	private Span[] _spans; // 0xD0
	private Dictionary<string, Measurement> _measurements; // 0xD8
	[CompilerGenerated]
	[Nullable(2)]
	private DynamicSamplingContext <DynamicSamplingContext>k__BackingField; // 0xE0
	[CompilerGenerated]
	[Nullable(2)]
	private ITransactionProfiler <TransactionProfiler>k__BackingField; // 0xE8

	// Properties
	public SentryId EventId { get; set; }
	public SpanId SpanId { get; set; }
	public Nullable<SpanId> ParentSpanId { get; set; }
	public SentryId TraceId { get; set; }
	public string Name { get; set; }
	public TransactionNameSource NameSource { get; }
	public Nullable<bool> IsParentSampled { get; set; }
	[Nullable(2)]
	public string Platform { get; set; }
	[Nullable(2)]
	public string Release { get; set; }
	[Nullable(2)]
	public string Distribution { get; set; }
	public DateTimeOffset StartTimestamp { get; set; }
	public Nullable<DateTimeOffset> EndTimestamp { get; set; }
	public string Operation { get; set; }
	[Nullable(2)]
	public string Description { get; set; }
	public Nullable<SpanStatus> Status { get; set; }
	public Nullable<bool> IsSampled { get; set; }
	public Nullable<double> SampleRate { get; set; }
	public Nullable<SentryLevel> Level { get; set; }
	public Request Request { get; set; }
	public Contexts Contexts { get; set; }
	public User User { get; set; }
	[Nullable(2)]
	public string Environment { get; set; }
	[Nullable(2)]
	private string Sentry.IEventLike.TransactionName { get; set; }
	public SdkVersion Sdk { get; set; }
	public IReadOnlyList<string> Fingerprint { get; set; }
	public IReadOnlyCollection<Breadcrumb> Breadcrumbs { get; }
	[Nullable(new[] { 1, 1, 2 })]
	public IReadOnlyDictionary<string, object> Extra { get; }
	public IReadOnlyDictionary<string, string> Tags { get; }
	public IReadOnlyCollection<Span> Spans { get; }
	public IReadOnlyDictionary<string, Measurement> Measurements { get; }
	public bool IsFinished { get; }
	[Nullable(2)]
	internal DynamicSamplingContext DynamicSamplingContext { get; set; }
	[Nullable(2)]
	internal ITransactionProfiler TransactionProfiler { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x482990 Offset: 0x481B90 VA: 0x180482990
	public SentryId get_EventId() { }

	[CompilerGenerated]
	// RVA: 0x4829A0 Offset: 0x481BA0 VA: 0x1804829A0
	private void set_EventId(SentryId value) { }

	// RVA: 0x1C702D0 Offset: 0x1C6F4D0 VA: 0x181C702D0 Slot: 8
	public SpanId get_SpanId() { }

	// RVA: 0x1C705E0 Offset: 0x1C6F7E0 VA: 0x181C705E0
	private void set_SpanId(SpanId value) { }

	// RVA: 0x1C70210 Offset: 0x1C6F410 VA: 0x181C70210 Slot: 9
	public Nullable<SpanId> get_ParentSpanId() { }

	// RVA: 0x1C70590 Offset: 0x1C6F790 VA: 0x181C70590
	private void set_ParentSpanId(Nullable<SpanId> value) { }

	// RVA: 0x1C70330 Offset: 0x1C6F530 VA: 0x181C70330 Slot: 10
	public SentryId get_TraceId() { }

	// RVA: 0x1C70660 Offset: 0x1C6F860 VA: 0x181C70660
	private void set_TraceId(SentryId value) { }

	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90 Slot: 20
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	private void set_Name(string value) { }

	[CompilerGenerated]
	// RVA: 0x3DA050 Offset: 0x3D9250 VA: 0x1803DA050 Slot: 46
	public TransactionNameSource get_NameSource() { }

	[CompilerGenerated]
	// RVA: 0x1B6EF90 Offset: 0x1B6E190 VA: 0x181B6EF90 Slot: 21
	public Nullable<bool> get_IsParentSampled() { }

	[CompilerGenerated]
	// RVA: 0x1B6EF50 Offset: 0x1B6E150 VA: 0x181B6EF50
	public void set_IsParentSampled(Nullable<bool> value) { }

	[CompilerGenerated]
	[NullableContext(2)]
	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620 Slot: 30
	public string get_Platform() { }

	[CompilerGenerated]
	[NullableContext(2)]
	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370 Slot: 31
	public void set_Platform(string value) { }

	[CompilerGenerated]
	[NullableContext(2)]
	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30 Slot: 32
	public string get_Release() { }

	[NullableContext(2)]
	[CompilerGenerated]
	// RVA: 0x40EC50 Offset: 0x40DE50 VA: 0x18040EC50 Slot: 33
	public void set_Release(string value) { }

	[CompilerGenerated]
	[NullableContext(2)]
	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0 Slot: 44
	public string get_Distribution() { }

	[CompilerGenerated]
	[NullableContext(2)]
	// RVA: 0x415820 Offset: 0x414A20 VA: 0x180415820 Slot: 45
	public void set_Distribution(string value) { }

	[CompilerGenerated]
	// RVA: 0x528FE0 Offset: 0x5281E0 VA: 0x180528FE0 Slot: 4
	public DateTimeOffset get_StartTimestamp() { }

	[CompilerGenerated]
	// RVA: 0x528FF0 Offset: 0x5281F0 VA: 0x180528FF0
	private void set_StartTimestamp(DateTimeOffset value) { }

	[CompilerGenerated]
	// RVA: 0x1C70100 Offset: 0x1C6F300 VA: 0x181C70100 Slot: 5
	public Nullable<DateTimeOffset> get_EndTimestamp() { }

	[CompilerGenerated]
	// RVA: 0x1C70450 Offset: 0x1C6F650 VA: 0x181C70450
	internal void set_EndTimestamp(Nullable<DateTimeOffset> value) { }

	// RVA: 0x1C701E0 Offset: 0x1C6F3E0 VA: 0x181C701E0 Slot: 11
	public string get_Operation() { }

	// RVA: 0x1C70550 Offset: 0x1C6F750 VA: 0x181C70550
	private void set_Operation(string value) { }

	[NullableContext(2)]
	// RVA: 0x1C700D0 Offset: 0x1C6F2D0 VA: 0x181C700D0 Slot: 12
	public string get_Description() { }

	[NullableContext(2)]
	// RVA: 0x1C70410 Offset: 0x1C6F610 VA: 0x181C70410
	public void set_Description(string value) { }

	// RVA: 0x1C70300 Offset: 0x1C6F500 VA: 0x181C70300 Slot: 13
	public Nullable<SpanStatus> get_Status() { }

	// RVA: 0x1C70620 Offset: 0x1C6F820 VA: 0x181C70620
	private void set_Status(Nullable<SpanStatus> value) { }

	// RVA: 0x1C701B0 Offset: 0x1C6F3B0 VA: 0x181C701B0 Slot: 14
	public Nullable<bool> get_IsSampled() { }

	// RVA: 0x1C70470 Offset: 0x1C6F670 VA: 0x181C70470
	internal void set_IsSampled(Nullable<bool> value) { }

	[CompilerGenerated]
	// RVA: 0x1C702C0 Offset: 0x1C6F4C0 VA: 0x181C702C0
	public Nullable<double> get_SampleRate() { }

	[CompilerGenerated]
	// RVA: 0x1C705D0 Offset: 0x1C6F7D0 VA: 0x181C705D0
	internal void set_SampleRate(Nullable<double> value) { }

	[CompilerGenerated]
	// RVA: 0x1A6BA60 Offset: 0x1A6AC60 VA: 0x181A6BA60 Slot: 22
	public Nullable<SentryLevel> get_Level() { }

	[CompilerGenerated]
	// RVA: 0x1A6BA80 Offset: 0x1A6AC80 VA: 0x181A6BA80 Slot: 23
	public void set_Level(Nullable<SentryLevel> value) { }

	// RVA: 0x1C70250 Offset: 0x1C6F450 VA: 0x181C70250 Slot: 24
	public Request get_Request() { }

	// RVA: 0x42D8E0 Offset: 0x42CAE0 VA: 0x18042D8E0 Slot: 25
	public void set_Request(Request value) { }

	// RVA: 0x43B560 Offset: 0x43A760 VA: 0x18043B560 Slot: 26
	public Contexts get_Contexts() { }

	// RVA: 0x1C703E0 Offset: 0x1C6F5E0 VA: 0x181C703E0 Slot: 27
	public void set_Contexts(Contexts value) { }

	// RVA: 0x1C70370 Offset: 0x1C6F570 VA: 0x181C70370 Slot: 28
	public User get_User() { }

	// RVA: 0x834540 Offset: 0x833740 VA: 0x180834540 Slot: 29
	public void set_User(User value) { }

	[NullableContext(2)]
	[CompilerGenerated]
	// RVA: 0x5C4FC0 Offset: 0x5C41C0 VA: 0x1805C4FC0 Slot: 34
	public string get_Environment() { }

	[NullableContext(2)]
	[CompilerGenerated]
	// RVA: 0xB8FC20 Offset: 0xB8EE20 VA: 0x180B8FC20 Slot: 35
	public void set_Environment(string value) { }

	[NullableContext(2)]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90 Slot: 36
	private string Sentry.IEventLike.get_TransactionName() { }

	[NullableContext(2)]
	// RVA: 0x1C6E9B0 Offset: 0x1C6DBB0 VA: 0x181C6E9B0 Slot: 37
	private void Sentry.IEventLike.set_TransactionName(string value) { }

	[CompilerGenerated]
	// RVA: 0x7960B0 Offset: 0x7952B0 VA: 0x1807960B0 Slot: 38
	public SdkVersion get_Sdk() { }

	[CompilerGenerated]
	// RVA: 0xB83400 Offset: 0xB82600 VA: 0x180B83400
	internal void set_Sdk(SdkVersion value) { }

	// RVA: 0x1C70120 Offset: 0x1C6F320 VA: 0x181C70120 Slot: 39
	public IReadOnlyList<string> get_Fingerprint() { }

	// RVA: 0x88DF00 Offset: 0x88D100 VA: 0x18088DF00 Slot: 40
	public void set_Fingerprint(IReadOnlyList<string> value) { }

	// RVA: 0x796080 Offset: 0x795280 VA: 0x180796080 Slot: 41
	public IReadOnlyCollection<Breadcrumb> get_Breadcrumbs() { }

	// RVA: 0x7381F0 Offset: 0x7373F0 VA: 0x1807381F0 Slot: 18
	public IReadOnlyDictionary<string, object> get_Extra() { }

	// RVA: 0x738340 Offset: 0x737540 VA: 0x180738340 Slot: 15
	public IReadOnlyDictionary<string, string> get_Tags() { }

	// RVA: 0x599C50 Offset: 0x598E50 VA: 0x180599C50
	public IReadOnlyCollection<Span> get_Spans() { }

	// RVA: 0x599C40 Offset: 0x598E40 VA: 0x180599C40 Slot: 47
	public IReadOnlyDictionary<string, Measurement> get_Measurements() { }

	// RVA: 0x1C70170 Offset: 0x1C6F370 VA: 0x181C70170 Slot: 6
	public bool get_IsFinished() { }

	[NullableContext(2)]
	[CompilerGenerated]
	// RVA: 0x794D80 Offset: 0x793F80 VA: 0x180794D80
	internal DynamicSamplingContext get_DynamicSamplingContext() { }

	[NullableContext(2)]
	[CompilerGenerated]
	// RVA: 0x8A5A60 Offset: 0x8A4C60 VA: 0x1808A5A60
	internal void set_DynamicSamplingContext(DynamicSamplingContext value) { }

	[NullableContext(2)]
	[CompilerGenerated]
	// RVA: 0x796090 Offset: 0x795290 VA: 0x180796090
	internal ITransactionProfiler get_TransactionProfiler() { }

	[CompilerGenerated]
	[NullableContext(2)]
	// RVA: 0x7960E0 Offset: 0x7952E0 VA: 0x1807960E0
	internal void set_TransactionProfiler(ITransactionProfiler value) { }

	// RVA: 0x1C6FE80 Offset: 0x1C6F080 VA: 0x181C6FE80
	private void .ctor(string name, TransactionNameSource nameSource) { }

	// RVA: 0x1C6F250 Offset: 0x1C6E450 VA: 0x181C6F250
	public void .ctor(string name, string operation) { }

	// RVA: 0x1C6F130 Offset: 0x1C6E330 VA: 0x181C6F130
	public void .ctor(string name, string operation, TransactionNameSource nameSource) { }

	// RVA: 0x1C6F360 Offset: 0x1C6E560 VA: 0x181C6F360
	public void .ctor(ITransaction tracer) { }

	// RVA: 0x1C6CF10 Offset: 0x1C6C110 VA: 0x181C6CF10 Slot: 42
	public void AddBreadcrumb(Breadcrumb breadcrumb) { }

	// RVA: 0x1C6EA10 Offset: 0x1C6DC10 VA: 0x181C6EA10 Slot: 19
	public void SetExtra(string key, object value) { }

	// RVA: 0x1C6EAF0 Offset: 0x1C6DCF0 VA: 0x181C6EAF0 Slot: 16
	public void SetTag(string key, string value) { }

	// RVA: 0x1C6EB60 Offset: 0x1C6DD60 VA: 0x181C6EB60 Slot: 17
	public void UnsetTag(string key) { }

	[EditorBrowsable(1)]
	// RVA: 0x1C6EA80 Offset: 0x1C6DC80 VA: 0x181C6EA80 Slot: 48
	public void SetMeasurement(string name, Measurement measurement) { }

	// RVA: 0x1C6E450 Offset: 0x1C6D650 VA: 0x181C6E450 Slot: 7
	public SentryTraceHeader GetTraceHeader() { }

	// RVA: 0x1C6E530 Offset: 0x1C6D730 VA: 0x181C6E530
	internal void Redact() { }

	// RVA: 0x1C6EBC0 Offset: 0x1C6DDC0 VA: 0x181C6EBC0 Slot: 43
	public void WriteTo(Utf8JsonWriter writer, IDiagnosticLogger logger) { }

	// RVA: 0x1C6CFB0 Offset: 0x1C6C1B0 VA: 0x181C6CFB0
	public static Transaction FromJson(JsonElement json) { }
}

// Namespace: Sentry
[NullableContext(1)]
[Nullable(0)]
public class TransactionContext : SpanContext, ITransactionContext, ISpanContext, ITraceContext, IHasTransactionNameSource // TypeDefIndex: 13509
{
	// Fields
	[CompilerGenerated]
	private string <Name>k__BackingField; // 0x58
	[CompilerGenerated]
	private TransactionNameSource <NameSource>k__BackingField; // 0x60
	[CompilerGenerated]
	private readonly Nullable<bool> <IsParentSampled>k__BackingField; // 0x64

	// Properties
	public string Name { get; set; }
	public TransactionNameSource NameSource { get; set; }
	public Nullable<bool> IsParentSampled { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x405090 Offset: 0x404290 VA: 0x180405090 Slot: 11
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x4050B0 Offset: 0x4042B0 VA: 0x1804050B0
	public void set_Name(string value) { }

	[CompilerGenerated]
	// RVA: 0x42D890 Offset: 0x42CA90 VA: 0x18042D890 Slot: 13
	public TransactionNameSource get_NameSource() { }

	[CompilerGenerated]
	// RVA: 0x42D900 Offset: 0x42CB00 VA: 0x18042D900
	public void set_NameSource(TransactionNameSource value) { }

	[CompilerGenerated]
	// RVA: 0x1C80CD0 Offset: 0x1C7FED0 VA: 0x181C80CD0 Slot: 12
	public Nullable<bool> get_IsParentSampled() { }

	// RVA: 0x1C80B50 Offset: 0x1C7FD50 VA: 0x181C80B50
	public void .ctor(SpanId spanId, Nullable<SpanId> parentSpanId, SentryId traceId, string name, string operation, string description, Nullable<SpanStatus> status, Nullable<bool> isSampled, Nullable<bool> isParentSampled, TransactionNameSource nameSource) { }

	// RVA: 0x1C80AC0 Offset: 0x1C7FCC0 VA: 0x181C80AC0
	public void .ctor(SpanId spanId, Nullable<SpanId> parentSpanId, SentryId traceId, string name, string operation, string description, Nullable<SpanStatus> status, Nullable<bool> isSampled, Nullable<bool> isParentSampled) { }

	// RVA: 0x1C80BE0 Offset: 0x1C7FDE0 VA: 0x181C80BE0
	public void .ctor(Nullable<SpanId> parentSpanId, SentryId traceId, string name, string operation, Nullable<bool> isParentSampled) { }

	// RVA: 0x1C80630 Offset: 0x1C7F830 VA: 0x181C80630
	public void .ctor(string name, string operation, Nullable<bool> isSampled) { }

	// RVA: 0x1C804F0 Offset: 0x1C7F6F0 VA: 0x181C804F0
	public void .ctor(string name, string operation, SentryTraceHeader traceHeader) { }

	// RVA: 0x1C80750 Offset: 0x1C7F950 VA: 0x181C80750
	public void .ctor(string name, string operation, SentryTraceHeader traceHeader, TransactionNameSource nameSource) { }

	// RVA: 0x1C80880 Offset: 0x1C7FA80 VA: 0x181C80880
	public void .ctor(string name, string operation) { }

	// RVA: 0x1C809A0 Offset: 0x1C7FBA0 VA: 0x181C809A0
	public void .ctor(string name, string operation, TransactionNameSource nameSource) { }
}

// Namespace: Sentry
public enum TransactionNameSource // TypeDefIndex: 13510
{
	// Fields
	public int value__; // 0x0
	public const TransactionNameSource Custom = 0;
	public const TransactionNameSource Url = 1;
	public const TransactionNameSource Route = 2;
	public const TransactionNameSource View = 3;
	public const TransactionNameSource Component = 4;
	public const TransactionNameSource Task = 5;
}

// Namespace: Sentry
[Extension]
internal static class TransactionNameSourceExtensions // TypeDefIndex: 13511
{
	// Methods

	[Extension]
	// RVA: 0x1C80CE0 Offset: 0x1C7FEE0 VA: 0x181C80CE0
	public static bool IsHighQuality(TransactionNameSource transactionNameSource) { }
}

// Namespace: Sentry
[NullableContext(1)]
[Nullable(0)]
public class TransactionSamplingContext // TypeDefIndex: 13512
{
	// Fields
	[CompilerGenerated]
	private readonly ITransactionContext <TransactionContext>k__BackingField; // 0x10
	[Nullable(new[] { 1, 1, 2 })]
	[CompilerGenerated]
	private readonly IReadOnlyDictionary<string, object> <CustomSamplingContext>k__BackingField; // 0x18

	// Properties
	public ITransactionContext TransactionContext { get; }
	[Nullable(new[] { 1, 1, 2 })]
	public IReadOnlyDictionary<string, object> CustomSamplingContext { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public ITransactionContext get_TransactionContext() { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public IReadOnlyDictionary<string, object> get_CustomSamplingContext() { }

	// RVA: 0x441CC0 Offset: 0x440EC0 VA: 0x180441CC0
	public void .ctor(ITransactionContext transactionContext, IReadOnlyDictionary<string, object> customSamplingContext) { }
}

// Namespace: 
[Nullable(0)]
private class TransactionTracer.LastActiveSpanTracker // TypeDefIndex: 13513
{
	// Fields
	private readonly object _lock; // 0x10
	private readonly Lazy<Stack<ISpan>> _trackedSpans; // 0x18

	// Properties
	private Stack<ISpan> TrackedSpans { get; }

	// Methods

	// RVA: 0x1C7B2E0 Offset: 0x1C7A4E0 VA: 0x181C7B2E0
	private Stack<ISpan> get_TrackedSpans() { }

	// RVA: 0x1C7B130 Offset: 0x1C7A330 VA: 0x181C7B130
	public void Push(ISpan span) { }

	[NullableContext(2)]
	// RVA: 0x1C7AF30 Offset: 0x1C7A130 VA: 0x181C7AF30
	public ISpan PeekActive() { }

	// RVA: 0x1C7B240 Offset: 0x1C7A440 VA: 0x181C7B240
	public void .ctor() { }
}

// Namespace: Sentry
[Nullable(0)]
[NullableContext(1)]
public class TransactionTracer : ITransaction, ITransactionData, ISpanData, ISpanContext, ITraceContext, IHasTags, IHasExtra, ITransactionContext, IEventLike, IHasBreadcrumbs, ISpan, IHasDistribution, IHasTransactionNameSource, IHasMeasurements // TypeDefIndex: 13514
{
	// Fields
	private readonly IHub _hub; // 0x10
	[Nullable(2)]
	private readonly SentryOptions _options; // 0x18
	[Nullable(2)]
	private readonly Timer _idleTimer; // 0x20
	private long _cancelIdleTimeout; // 0x28
	private readonly SentryStopwatch _stopwatch; // 0x30
	private readonly Instrumenter _instrumenter; // 0x48
	[CompilerGenerated]
	private readonly Nullable<SpanId> <ParentSpanId>k__BackingField; // 0x50
	[CompilerGenerated]
	private string <Name>k__BackingField; // 0x60
	[CompilerGenerated]
	private TransactionNameSource <NameSource>k__BackingField; // 0x68
	[CompilerGenerated]
	private Nullable<bool> <IsParentSampled>k__BackingField; // 0x6C
	[CompilerGenerated]
	[Nullable(2)]
	private string <Platform>k__BackingField; // 0x70
	[CompilerGenerated]
	[Nullable(2)]
	private string <Release>k__BackingField; // 0x78
	[CompilerGenerated]
	[Nullable(2)]
	private string <Distribution>k__BackingField; // 0x80
	[CompilerGenerated]
	private DateTimeOffset <StartTimestamp>k__BackingField; // 0x88
	[CompilerGenerated]
	private Nullable<DateTimeOffset> <EndTimestamp>k__BackingField; // 0x98
	[Nullable(2)]
	[CompilerGenerated]
	private string <Description>k__BackingField; // 0xB0
	[CompilerGenerated]
	private Nullable<double> <SampleRate>k__BackingField; // 0xB8
	[CompilerGenerated]
	private Nullable<SentryLevel> <Level>k__BackingField; // 0xC8
	[Nullable(2)]
	private Request _request; // 0xD0
	private readonly Contexts _contexts; // 0xD8
	[Nullable(2)]
	private User _user; // 0xE0
	[Nullable(2)]
	[CompilerGenerated]
	private string <Environment>k__BackingField; // 0xE8
	[CompilerGenerated]
	private SdkVersion <Sdk>k__BackingField; // 0xF0
	[Nullable(new[] { 2, 1 })]
	private IReadOnlyList<string> _fingerprint; // 0xF8
	private readonly ConcurrentBag<Breadcrumb> _breadcrumbs; // 0x100
	[Nullable(new[] { 1, 1, 2 })]
	private readonly ConcurrentDictionary<string, object> _extra; // 0x108
	private readonly ConcurrentDictionary<string, string> _tags; // 0x110
	private readonly ConcurrentBag<SpanTracer> _spans; // 0x118
	private readonly ConcurrentDictionary<string, Measurement> _measurements; // 0x120
	[Nullable(2)]
	[CompilerGenerated]
	private DynamicSamplingContext <DynamicSamplingContext>k__BackingField; // 0x128
	[CompilerGenerated]
	[Nullable(2)]
	private ITransactionProfiler <TransactionProfiler>k__BackingField; // 0x130
	[CompilerGenerated]
	private bool <IsSentryRequest>k__BackingField; // 0x138
	private readonly TransactionTracer.LastActiveSpanTracker _activeSpanTracker; // 0x140

	// Properties
	public SpanId SpanId { get; set; }
	public Nullable<SpanId> ParentSpanId { get; }
	public SentryId TraceId { get; set; }
	public string Name { get; set; }
	public TransactionNameSource NameSource { get; set; }
	public Nullable<bool> IsParentSampled { get; set; }
	[Nullable(2)]
	public string Platform { get; set; }
	[Nullable(2)]
	public string Release { get; set; }
	[Nullable(2)]
	public string Distribution { get; set; }
	public DateTimeOffset StartTimestamp { get; set; }
	public Nullable<DateTimeOffset> EndTimestamp { get; set; }
	public string Operation { get; set; }
	[Nullable(2)]
	public string Description { get; set; }
	public Nullable<SpanStatus> Status { get; set; }
	public Nullable<bool> IsSampled { get; set; }
	public Nullable<double> SampleRate { get; set; }
	public Nullable<SentryLevel> Level { get; set; }
	public Request Request { get; set; }
	public Contexts Contexts { get; set; }
	public User User { get; set; }
	[Nullable(2)]
	public string Environment { get; set; }
	[Nullable(2)]
	private string Sentry.IEventLike.TransactionName { get; set; }
	public SdkVersion Sdk { get; set; }
	public IReadOnlyList<string> Fingerprint { get; set; }
	public IReadOnlyCollection<Breadcrumb> Breadcrumbs { get; }
	[Nullable(new[] { 1, 1, 2 })]
	public IReadOnlyDictionary<string, object> Extra { get; }
	public IReadOnlyDictionary<string, string> Tags { get; }
	public IReadOnlyCollection<ISpan> Spans { get; }
	public IReadOnlyDictionary<string, Measurement> Measurements { get; }
	public bool IsFinished { get; }
	[Nullable(2)]
	internal DynamicSamplingContext DynamicSamplingContext { get; set; }
	[Nullable(2)]
	internal ITransactionProfiler TransactionProfiler { get; set; }
	internal bool IsSentryRequest { get; set; }

	// Methods

	// RVA: 0x1C82F00 Offset: 0x1C82100 VA: 0x181C82F00 Slot: 14
	public SpanId get_SpanId() { }

	// RVA: 0x1C831C0 Offset: 0x1C823C0 VA: 0x181C831C0
	private void set_SpanId(SpanId value) { }

	[CompilerGenerated]
	// RVA: 0xC5DC80 Offset: 0xC5CE80 VA: 0x180C5DC80 Slot: 15
	public Nullable<SpanId> get_ParentSpanId() { }

	// RVA: 0x1C82F60 Offset: 0x1C82160 VA: 0x181C82F60 Slot: 16
	public SentryId get_TraceId() { }

	// RVA: 0x1C83240 Offset: 0x1C82440 VA: 0x181C83240
	private void set_TraceId(SentryId value) { }

	[CompilerGenerated]
	// RVA: 0x542860 Offset: 0x541A60 VA: 0x180542860 Slot: 26
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x542AA0 Offset: 0x541CA0 VA: 0x180542AA0 Slot: 5
	public void set_Name(string value) { }

	[CompilerGenerated]
	// RVA: 0x6DDF80 Offset: 0x6DD180 VA: 0x1806DDF80 Slot: 62
	public TransactionNameSource get_NameSource() { }

	[CompilerGenerated]
	// RVA: 0x42D810 Offset: 0x42CA10 VA: 0x18042D810
	public void set_NameSource(TransactionNameSource value) { }

	[CompilerGenerated]
	// RVA: 0x1C7AED0 Offset: 0x1C7A0D0 VA: 0x181C7AED0 Slot: 27
	public Nullable<bool> get_IsParentSampled() { }

	[CompilerGenerated]
	// RVA: 0x1C7AF00 Offset: 0x1C7A100 VA: 0x181C7AF00 Slot: 7
	public void set_IsParentSampled(Nullable<bool> value) { }

	[NullableContext(2)]
	[CompilerGenerated]
	// RVA: 0x4ED980 Offset: 0x4ECB80 VA: 0x1804ED980 Slot: 36
	public string get_Platform() { }

	[CompilerGenerated]
	[NullableContext(2)]
	// RVA: 0x4EDD30 Offset: 0x4ECF30 VA: 0x1804EDD30 Slot: 37
	public void set_Platform(string value) { }

	[CompilerGenerated]
	[NullableContext(2)]
	// RVA: 0x794CB0 Offset: 0x793EB0 VA: 0x180794CB0 Slot: 38
	public string get_Release() { }

	[NullableContext(2)]
	[CompilerGenerated]
	// RVA: 0x1862F40 Offset: 0x1862140 VA: 0x181862F40 Slot: 39
	public void set_Release(string value) { }

	[CompilerGenerated]
	[NullableContext(2)]
	// RVA: 0x42D830 Offset: 0x42CA30 VA: 0x18042D830 Slot: 60
	public string get_Distribution() { }

	[CompilerGenerated]
	[NullableContext(2)]
	// RVA: 0x42D780 Offset: 0x42C980 VA: 0x18042D780 Slot: 61
	public void set_Distribution(string value) { }

	[CompilerGenerated]
	// RVA: 0x454B20 Offset: 0x453D20 VA: 0x180454B20 Slot: 10
	public DateTimeOffset get_StartTimestamp() { }

	[CompilerGenerated]
	// RVA: 0x454B30 Offset: 0x453D30 VA: 0x180454B30
	internal void set_StartTimestamp(DateTimeOffset value) { }

	[CompilerGenerated]
	// RVA: 0x1C82D10 Offset: 0x1C81F10 VA: 0x181C82D10 Slot: 11
	public Nullable<DateTimeOffset> get_EndTimestamp() { }

	[CompilerGenerated]
	// RVA: 0x1C83040 Offset: 0x1C82240 VA: 0x181C83040
	internal void set_EndTimestamp(Nullable<DateTimeOffset> value) { }

	// RVA: 0x1C82E50 Offset: 0x1C82050 VA: 0x181C82E50 Slot: 51
	public string get_Operation() { }

	// RVA: 0x1C83170 Offset: 0x1C82370 VA: 0x181C83170 Slot: 52
	public void set_Operation(string value) { }

	[CompilerGenerated]
	[NullableContext(2)]
	// RVA: 0x796070 Offset: 0x795270 VA: 0x180796070 Slot: 49
	public string get_Description() { }

	[CompilerGenerated]
	[NullableContext(2)]
	// RVA: 0x88DF00 Offset: 0x88D100 VA: 0x18088DF00 Slot: 50
	public void set_Description(string value) { }

	// RVA: 0x1C82F30 Offset: 0x1C82130 VA: 0x181C82F30 Slot: 53
	public Nullable<SpanStatus> get_Status() { }

	// RVA: 0x1C83200 Offset: 0x1C82400 VA: 0x181C83200 Slot: 54
	public void set_Status(Nullable<SpanStatus> value) { }

	// RVA: 0x1C82E10 Offset: 0x1C82010 VA: 0x181C82E10 Slot: 20
	public Nullable<bool> get_IsSampled() { }

	// RVA: 0x1C83060 Offset: 0x1C82260 VA: 0x181C83060
	internal void set_IsSampled(Nullable<bool> value) { }

	[CompilerGenerated]
	// RVA: 0x1C82EF0 Offset: 0x1C820F0 VA: 0x181C82EF0
	public Nullable<double> get_SampleRate() { }

	[CompilerGenerated]
	// RVA: 0x1C831B0 Offset: 0x1C823B0 VA: 0x181C831B0
	internal void set_SampleRate(Nullable<double> value) { }

	[CompilerGenerated]
	// RVA: 0x170E920 Offset: 0x170DB20 VA: 0x18170E920 Slot: 28
	public Nullable<SentryLevel> get_Level() { }

	[CompilerGenerated]
	// RVA: 0x1C83160 Offset: 0x1C82360 VA: 0x181C83160 Slot: 29
	public void set_Level(Nullable<SentryLevel> value) { }

	// RVA: 0x1C82E80 Offset: 0x1C82080 VA: 0x181C82E80 Slot: 30
	public Request get_Request() { }

	// RVA: 0x599C80 Offset: 0x598E80 VA: 0x180599C80 Slot: 31
	public void set_Request(Request value) { }

	// RVA: 0x599C40 Offset: 0x598E40 VA: 0x180599C40 Slot: 32
	public Contexts get_Contexts() { }

	// RVA: 0x1C83010 Offset: 0x1C82210 VA: 0x181C83010 Slot: 33
	public void set_Contexts(Contexts value) { }

	// RVA: 0x1C82FA0 Offset: 0x1C821A0 VA: 0x181C82FA0 Slot: 34
	public User get_User() { }

	// RVA: 0x8A5A60 Offset: 0x8A4C60 VA: 0x1808A5A60 Slot: 35
	public void set_User(User value) { }

	[CompilerGenerated]
	[NullableContext(2)]
	// RVA: 0x796090 Offset: 0x795290 VA: 0x180796090 Slot: 40
	public string get_Environment() { }

	[NullableContext(2)]
	[CompilerGenerated]
	// RVA: 0x7960E0 Offset: 0x7952E0 VA: 0x1807960E0 Slot: 41
	public void set_Environment(string value) { }

	[NullableContext(2)]
	// RVA: 0x542860 Offset: 0x541A60 VA: 0x180542860 Slot: 42
	private string Sentry.IEventLike.get_TransactionName() { }

	[NullableContext(2)]
	// RVA: 0x1C81930 Offset: 0x1C80B30 VA: 0x181C81930 Slot: 43
	private void Sentry.IEventLike.set_TransactionName(string value) { }

	[CompilerGenerated]
	// RVA: 0x794CF0 Offset: 0x793EF0 VA: 0x180794CF0 Slot: 44
	public SdkVersion get_Sdk() { }

	[CompilerGenerated]
	// RVA: 0x7960C0 Offset: 0x7952C0 VA: 0x1807960C0
	internal void set_Sdk(SdkVersion value) { }

	// RVA: 0x1C82D30 Offset: 0x1C81F30 VA: 0x181C82D30 Slot: 45
	public IReadOnlyList<string> get_Fingerprint() { }

	// RVA: 0x7960D0 Offset: 0x7952D0 VA: 0x1807960D0 Slot: 46
	public void set_Fingerprint(IReadOnlyList<string> value) { }

	// RVA: 0x7960A0 Offset: 0x7952A0 VA: 0x1807960A0 Slot: 47
	public IReadOnlyCollection<Breadcrumb> get_Breadcrumbs() { }

	// RVA: 0x789810 Offset: 0x788A10 VA: 0x180789810 Slot: 24
	public IReadOnlyDictionary<string, object> get_Extra() { }

	// RVA: 0x6ED520 Offset: 0x6EC720 VA: 0x1806ED520 Slot: 21
	public IReadOnlyDictionary<string, string> get_Tags() { }

	// RVA: 0x6ED510 Offset: 0x6EC710 VA: 0x1806ED510 Slot: 8
	public IReadOnlyCollection<ISpan> get_Spans() { }

	// RVA: 0x53DA70 Offset: 0x53CC70 VA: 0x18053DA70 Slot: 63
	public IReadOnlyDictionary<string, Measurement> get_Measurements() { }

	// RVA: 0x1C82DD0 Offset: 0x1C81FD0 VA: 0x181C82DD0 Slot: 12
	public bool get_IsFinished() { }

	[NullableContext(2)]
	[CompilerGenerated]
	// RVA: 0x6ED530 Offset: 0x6EC730 VA: 0x1806ED530
	internal DynamicSamplingContext get_DynamicSamplingContext() { }

	[CompilerGenerated]
	[NullableContext(2)]
	// RVA: 0x5405B0 Offset: 0x53F7B0 VA: 0x1805405B0
	internal void set_DynamicSamplingContext(DynamicSamplingContext value) { }

	[NullableContext(2)]
	[CompilerGenerated]
	// RVA: 0x19A2F10 Offset: 0x19A2110 VA: 0x1819A2F10
	internal ITransactionProfiler get_TransactionProfiler() { }

	[NullableContext(2)]
	[CompilerGenerated]
	// RVA: 0x1C75790 Offset: 0x1C74990 VA: 0x181C75790
	internal void set_TransactionProfiler(ITransactionProfiler value) { }

	[CompilerGenerated]
	// RVA: 0x1C82E40 Offset: 0x1C82040 VA: 0x181C82E40
	internal bool get_IsSentryRequest() { }

	[CompilerGenerated]
	// RVA: 0x1C83150 Offset: 0x1C82350 VA: 0x181C83150
	internal void set_IsSentryRequest(bool value) { }

	// RVA: 0x1C823C0 Offset: 0x1C815C0 VA: 0x181C823C0
	public void .ctor(IHub hub, string name, string operation) { }

	// RVA: 0x1C81FF0 Offset: 0x1C811F0 VA: 0x181C81FF0
	public void .ctor(IHub hub, string name, string operation, TransactionNameSource nameSource) { }

	// RVA: 0x1C82CE0 Offset: 0x1C81EE0 VA: 0x181C82CE0
	public void .ctor(IHub hub, ITransactionContext context) { }

	// RVA: 0x1C823E0 Offset: 0x1C815E0 VA: 0x181C823E0
	internal void .ctor(IHub hub, ITransactionContext context, Nullable<TimeSpan> idleTimeout) { }

	// RVA: 0x1C80CF0 Offset: 0x1C7FEF0 VA: 0x181C80CF0 Slot: 48
	public void AddBreadcrumb(Breadcrumb breadcrumb) { }

	// RVA: 0x1C81990 Offset: 0x1C80B90 VA: 0x181C81990 Slot: 25
	public void SetExtra(string key, object value) { }

	// RVA: 0x1C81A70 Offset: 0x1C80C70 VA: 0x181C81A70 Slot: 22
	public void SetTag(string key, string value) { }

	// RVA: 0x1C81F80 Offset: 0x1C81180 VA: 0x181C81F80 Slot: 23
	public void UnsetTag(string key) { }

	[EditorBrowsable(1)]
	// RVA: 0x1C81A00 Offset: 0x1C80C00 VA: 0x181C81A00 Slot: 64
	public void SetMeasurement(string name, Measurement measurement) { }

	// RVA: 0x1C81AE0 Offset: 0x1C80CE0 VA: 0x181C81AE0 Slot: 55
	public ISpan StartChild(string operation) { }

	// RVA: 0x1C81B50 Offset: 0x1C80D50 VA: 0x181C81B50
	internal ISpan StartChild(Nullable<SpanId> spanId, SpanId parentSpanId, string operation, Instrumenter instrumenter = 0) { }

	// RVA: 0x1C80D50 Offset: 0x1C7FF50 VA: 0x181C80D50
	private void AddChildSpan(SpanTracer span) { }

	[NullableContext(2)]
	// RVA: 0x1C81820 Offset: 0x1C80A20 VA: 0x181C81820 Slot: 9
	public ISpan GetLastActiveSpan() { }

	// RVA: 0x1C810D0 Offset: 0x1C802D0 VA: 0x181C810D0 Slot: 56
	public void Finish() { }

	// RVA: 0x1C81040 Offset: 0x1C80240 VA: 0x181C81040 Slot: 57
	public void Finish(SpanStatus status) { }

	// RVA: 0x1C80F50 Offset: 0x1C80150 VA: 0x181C80F50 Slot: 58
	public void Finish(Exception exception, SpanStatus status) { }

	// RVA: 0x1C80E60 Offset: 0x1C80060 VA: 0x181C80E60 Slot: 59
	public void Finish(Exception exception) { }

	// RVA: 0x1C81850 Offset: 0x1C80A50 VA: 0x181C81850 Slot: 13
	public SentryTraceHeader GetTraceHeader() { }

	[CompilerGenerated]
	[NullableContext(0)]
	// RVA: 0x1C81E80 Offset: 0x1C81080 VA: 0x181C81E80
	private void <.ctor>b__127_0(object state) { }

	[CompilerGenerated]
	// RVA: 0x1C81E50 Offset: 0x1C81050 VA: 0x181C81E50
	private void <Finish>b__139_0(Scope scope) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class User.<>c // TypeDefIndex: 13515
{
	// Fields
	[Nullable(0)]
	public static readonly User.<>c <>9; // 0x0
	[Nullable(0)]
	public static Func<KeyValuePair<string, string>, string> <>9__29_0; // 0x8
	[Nullable(0)]
	public static Func<KeyValuePair<string, string>, string> <>9__29_1; // 0x10

	// Methods

	// RVA: 0x1C86340 Offset: 0x1C85540 VA: 0x181C86340
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	[NullableContext(0)]
	// RVA: 0x1C86170 Offset: 0x1C85370 VA: 0x181C86170
	internal string <CopyTo>b__29_0(KeyValuePair<string, string> entry) { }

	[NullableContext(0)]
	// RVA: 0x1C861B0 Offset: 0x1C853B0 VA: 0x181C861B0
	internal string <CopyTo>b__29_1(KeyValuePair<string, string> entry) { }
}

// Namespace: Sentry
[NullableContext(2)]
[Nullable(0)]
public sealed class User : IJsonSerializable // TypeDefIndex: 13516
{
	// Fields
	[Nullable(new[] { 2, 1 })]
	[CompilerGenerated]
	private Action<User> <PropertyChanged>k__BackingField; // 0x10
	private string _id; // 0x18
	private string _username; // 0x20
	private string _email; // 0x28
	private string _ipAddress; // 0x30
	private string _segment; // 0x38
	[Nullable(new[] { 2, 1, 1 })]
	private IDictionary<string, string> _other; // 0x40

	// Properties
	[Nullable(new[] { 2, 1 })]
	internal Action<User> PropertyChanged { get; set; }
	public string Id { get; set; }
	public string Username { get; set; }
	public string Email { get; set; }
	public string IpAddress { get; set; }
	public string Segment { get; set; }
	[Nullable(1)]
	public IDictionary<string, string> Other { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	internal Action<User> get_PropertyChanged() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	internal void set_PropertyChanged(Action<User> value) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_Id() { }

	// RVA: 0x1C87290 Offset: 0x1C86490 VA: 0x181C87290
	public void set_Id(string value) { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public string get_Username() { }

	// RVA: 0x1C87350 Offset: 0x1C86550 VA: 0x181C87350
	public void set_Username(string value) { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public string get_Email() { }

	// RVA: 0x1C87260 Offset: 0x1C86460 VA: 0x181C87260
	public void set_Email(string value) { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public string get_IpAddress() { }

	// RVA: 0x1C872C0 Offset: 0x1C864C0 VA: 0x181C872C0
	public void set_IpAddress(string value) { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public string get_Segment() { }

	// RVA: 0x1C87320 Offset: 0x1C86520 VA: 0x181C87320
	public void set_Segment(string value) { }

	[NullableContext(1)]
	// RVA: 0x1C871F0 Offset: 0x1C863F0 VA: 0x181C871F0
	public IDictionary<string, string> get_Other() { }

	[NullableContext(1)]
	// RVA: 0x1C872F0 Offset: 0x1C864F0 VA: 0x181C872F0
	public void set_Other(IDictionary<string, string> value) { }

	[NullableContext(1)]
	// RVA: 0x1C868B0 Offset: 0x1C85AB0 VA: 0x181C868B0
	public User Clone() { }

	// RVA: 0x1C86910 Offset: 0x1C85B10 VA: 0x181C86910
	internal void CopyTo(User user) { }

	// RVA: 0x1C87020 Offset: 0x1C86220 VA: 0x181C87020
	internal bool HasAnyData() { }

	[NullableContext(1)]
	// RVA: 0x1C870A0 Offset: 0x1C862A0 VA: 0x181C870A0 Slot: 4
	public void WriteTo(Utf8JsonWriter writer, IDiagnosticLogger _) { }

	[NullableContext(1)]
	// RVA: 0x1C86BA0 Offset: 0x1C85DA0 VA: 0x181C86BA0
	public static User FromJson(JsonElement json) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private static class UserFeedback.<>O // TypeDefIndex: 13517
{
	// Fields
	[Nullable(0)]
	public static Func<JsonElement, SentryId> <0>__FromJson; // 0x0
}

// Namespace: Sentry
[Nullable(0)]
[NullableContext(2)]
public sealed class UserFeedback : IJsonSerializable // TypeDefIndex: 13518
{
	// Fields
	[CompilerGenerated]
	private readonly SentryId <EventId>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly string <Name>k__BackingField; // 0x20
	[CompilerGenerated]
	private readonly string <Email>k__BackingField; // 0x28
	[CompilerGenerated]
	private readonly string <Comments>k__BackingField; // 0x30

	// Properties
	public SentryId EventId { get; }
	public string Name { get; }
	public string Email { get; }
	public string Comments { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x482990 Offset: 0x481B90 VA: 0x180482990
	public SentryId get_EventId() { }

	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public string get_Email() { }

	[CompilerGenerated]
	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public string get_Comments() { }

	// RVA: 0x1C86850 Offset: 0x1C85A50 VA: 0x181C86850
	public void .ctor(SentryId eventId, string name, string email, string comments) { }

	[NullableContext(1)]
	// RVA: 0x1C86710 Offset: 0x1C85910 VA: 0x181C86710 Slot: 4
	public void WriteTo(Utf8JsonWriter writer, IDiagnosticLogger logger) { }

	[NullableContext(1)]
	// RVA: 0x1C863A0 Offset: 0x1C855A0 VA: 0x181C863A0
	public static UserFeedback FromJson(JsonElement json) { }
}

// Namespace: Sentry
[NullableContext(1)]
[Nullable(0)]
public sealed class ViewHierarchy : IJsonSerializable // TypeDefIndex: 13519
{
	// Fields
	[CompilerGenerated]
	private string <RenderingSystem>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly List<ViewHierarchyNode> <Windows>k__BackingField; // 0x18

	// Properties
	public string RenderingSystem { get; set; }
	public List<ViewHierarchyNode> Windows { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_RenderingSystem() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_RenderingSystem(string value) { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public List<ViewHierarchyNode> get_Windows() { }

	// RVA: 0x1C87840 Offset: 0x1C86A40 VA: 0x181C87840
	public void .ctor(string renderingSystem) { }

	// RVA: 0x1C87680 Offset: 0x1C86880 VA: 0x181C87680 Slot: 4
	public void WriteTo(Utf8JsonWriter writer, IDiagnosticLogger logger) { }
}

// Namespace: Sentry
public class ViewHierarchyAttachment : Attachment // TypeDefIndex: 13520
{
	// Methods

	[NullableContext(1)]
	// RVA: 0x1C87380 Offset: 0x1C86580 VA: 0x181C87380
	public void .ctor(IAttachmentContent content) { }
}

// Namespace: Sentry
[Nullable(0)]
[NullableContext(1)]
public abstract class ViewHierarchyNode : IJsonSerializable // TypeDefIndex: 13521
{
	// Fields
	[Nullable(new[] { 2, 1 })]
	private List<ViewHierarchyNode> _children; // 0x10
	[CompilerGenerated]
	private string <Type>k__BackingField; // 0x18

	// Properties
	public string Type { get; set; }
	public List<ViewHierarchyNode> Children { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_Type() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_Type(string value) { }

	// RVA: 0x1C87610 Offset: 0x1C86810 VA: 0x181C87610
	public List<ViewHierarchyNode> get_Children() { }

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_Children(List<ViewHierarchyNode> value) { }

	// RVA: 0x81DA00 Offset: 0x81CC00 VA: 0x18081DA00
	protected void .ctor(string type) { }

	// RVA: 0x1C873F0 Offset: 0x1C865F0 VA: 0x181C873F0 Slot: 4
	public void WriteTo(Utf8JsonWriter writer, IDiagnosticLogger logger) { }

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract void WriteAdditionalProperties(Utf8JsonWriter writer, IDiagnosticLogger logger);
}

// Namespace: Sentry.Reflection
[NullableContext(1)]
[Extension]
[EditorBrowsable(1)]
[Obsolete("Should not be public. This method will be removed in version 4.")]
[Nullable(0)]
public static class AssemblyExtensions // TypeDefIndex: 13522
{
	// Methods

	[Extension]
	// RVA: 0x1C724B0 Offset: 0x1C716B0 VA: 0x181C724B0
	public static SdkVersion GetNameAndVersion(Assembly asm) { }

	[Extension]
	// RVA: 0x1C72550 Offset: 0x1C71750 VA: 0x181C72550
	internal static string GetVersion(Assembly assembly) { }
}

// Namespace: Sentry.Protocol
[Nullable(0)]
[NullableContext(2)]
public sealed class App : IJsonSerializable, ICloneable<App>, IUpdatable<App>, IUpdatable // TypeDefIndex: 13523
{
	// Fields
	[Nullable(1)]
	public const string Type = "app";
	[CompilerGenerated]
	private string <Identifier>k__BackingField; // 0x10
	[CompilerGenerated]
	private Nullable<DateTimeOffset> <StartTime>k__BackingField; // 0x18
	[CompilerGenerated]
	private string <Hash>k__BackingField; // 0x30
	[CompilerGenerated]
	private string <BuildType>k__BackingField; // 0x38
	[CompilerGenerated]
	private string <Name>k__BackingField; // 0x40
	[CompilerGenerated]
	private string <Version>k__BackingField; // 0x48
	[CompilerGenerated]
	private string <Build>k__BackingField; // 0x50

	// Properties
	public string Identifier { get; set; }
	public Nullable<DateTimeOffset> StartTime { get; set; }
	public string Hash { get; set; }
	public string BuildType { get; set; }
	public string Name { get; set; }
	public string Version { get; set; }
	public string Build { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_Identifier() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_Identifier(string value) { }

	[CompilerGenerated]
	// RVA: 0x426510 Offset: 0x425710 VA: 0x180426510
	public Nullable<DateTimeOffset> get_StartTime() { }

	[CompilerGenerated]
	// RVA: 0x426540 Offset: 0x425740 VA: 0x180426540
	public void set_StartTime(Nullable<DateTimeOffset> value) { }

	[CompilerGenerated]
	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public string get_Hash() { }

	[CompilerGenerated]
	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	public void set_Hash(string value) { }

	[CompilerGenerated]
	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public string get_BuildType() { }

	[CompilerGenerated]
	// RVA: 0x40EC50 Offset: 0x40DE50 VA: 0x18040EC50
	public void set_BuildType(string value) { }

	[CompilerGenerated]
	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x415820 Offset: 0x414A20 VA: 0x180415820
	public void set_Name(string value) { }

	[CompilerGenerated]
	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0
	public string get_Version() { }

	[CompilerGenerated]
	// RVA: 0x41A200 Offset: 0x419400 VA: 0x18041A200
	public void set_Version(string value) { }

	[CompilerGenerated]
	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0
	public string get_Build() { }

	[CompilerGenerated]
	// RVA: 0x4050C0 Offset: 0x4042C0 VA: 0x1804050C0
	public void set_Build(string value) { }

	[NullableContext(1)]
	// RVA: 0x1C71B90 Offset: 0x1C70D90 VA: 0x181C71B90
	internal App Clone() { }

	[NullableContext(1)]
	// RVA: 0x1C720C0 Offset: 0x1C712C0 VA: 0x181C720C0 Slot: 5
	private App Sentry.Internal.ICloneable<Sentry.Protocol.App>.Clone() { }

	[NullableContext(1)]
	// RVA: 0x1C722B0 Offset: 0x1C714B0 VA: 0x181C722B0
	internal void UpdateFrom(App source) { }

	[NullableContext(1)]
	// RVA: 0x1C72240 Offset: 0x1C71440 VA: 0x181C72240 Slot: 7
	private void Sentry.Internal.IUpdatable.UpdateFrom(object source) { }

	[NullableContext(1)]
	// RVA: 0x1C72160 Offset: 0x1C71360 VA: 0x181C72160 Slot: 6
	private void Sentry.Internal.IUpdatable<Sentry.Protocol.App>.UpdateFrom(App source) { }

	[NullableContext(1)]
	// RVA: 0x1C72300 Offset: 0x1C71500 VA: 0x181C72300 Slot: 4
	public void WriteTo(Utf8JsonWriter writer, IDiagnosticLogger _) { }

	[NullableContext(1)]
	// RVA: 0x1C71C40 Offset: 0x1C70E40 VA: 0x181C71C40
	public static App FromJson(JsonElement json) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: Sentry.Protocol
[NullableContext(1)]
[Nullable(0)]
public sealed class Browser : IJsonSerializable, ICloneable<Browser>, IUpdatable<Browser>, IUpdatable // TypeDefIndex: 13524
{
	// Fields
	public const string Type = "browser";
	[Nullable(2)]
	[CompilerGenerated]
	private string <Name>k__BackingField; // 0x10
	[Nullable(2)]
	[CompilerGenerated]
	private string <Version>k__BackingField; // 0x18

	// Properties
	[Nullable(2)]
	public string Name { get; set; }
	[Nullable(2)]
	public string Version { get; set; }

	// Methods

	[CompilerGenerated]
	[NullableContext(2)]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_Name() { }

	[CompilerGenerated]
	[NullableContext(2)]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_Name(string value) { }

	[CompilerGenerated]
	[NullableContext(2)]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_Version() { }

	[CompilerGenerated]
	[NullableContext(2)]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_Version(string value) { }

	// RVA: 0x1C72890 Offset: 0x1C71A90 VA: 0x181C72890
	internal Browser Clone() { }

	// RVA: 0x1C72AE0 Offset: 0x1C71CE0 VA: 0x181C72AE0 Slot: 5
	private Browser Sentry.Internal.ICloneable<Sentry.Protocol.Browser>.Clone() { }

	// RVA: 0x1C72C00 Offset: 0x1C71E00 VA: 0x181C72C00
	internal void UpdateFrom(Browser source) { }

	// RVA: 0x1C72B90 Offset: 0x1C71D90 VA: 0x181C72B90 Slot: 7
	private void Sentry.Internal.IUpdatable.UpdateFrom(object source) { }

	// RVA: 0x1C72B50 Offset: 0x1C71D50 VA: 0x181C72B50 Slot: 6
	private void Sentry.Internal.IUpdatable<Sentry.Protocol.Browser>.UpdateFrom(Browser source) { }

	// RVA: 0x1C72C50 Offset: 0x1C71E50 VA: 0x181C72C50 Slot: 4
	public void WriteTo(Utf8JsonWriter writer, IDiagnosticLogger _) { }

	// RVA: 0x1C72940 Offset: 0x1C71B40 VA: 0x181C72940
	public static Browser FromJson(JsonElement json) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: Sentry.Protocol
[NullableContext(2)]
[Nullable(0)]
public sealed class Device : IJsonSerializable, ICloneable<Device>, IUpdatable<Device>, IUpdatable // TypeDefIndex: 13525
{
	// Fields
	[Nullable(1)]
	public const string Type = "device";
	[CompilerGenerated]
	private TimeZoneInfo <Timezone>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <Name>k__BackingField; // 0x18
	[CompilerGenerated]
	private string <Manufacturer>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <Brand>k__BackingField; // 0x28
	[CompilerGenerated]
	private string <Family>k__BackingField; // 0x30
	[CompilerGenerated]
	private string <Model>k__BackingField; // 0x38
	[CompilerGenerated]
	private string <ModelId>k__BackingField; // 0x40
	[CompilerGenerated]
	private string <Architecture>k__BackingField; // 0x48
	[CompilerGenerated]
	private Nullable<short> <BatteryLevel>k__BackingField; // 0x50
	[CompilerGenerated]
	private Nullable<bool> <IsCharging>k__BackingField; // 0x54
	[CompilerGenerated]
	private Nullable<bool> <IsOnline>k__BackingField; // 0x56
	[CompilerGenerated]
	private Nullable<DeviceOrientation> <Orientation>k__BackingField; // 0x58
	[CompilerGenerated]
	private Nullable<bool> <Simulator>k__BackingField; // 0x60
	[CompilerGenerated]
	private Nullable<long> <MemorySize>k__BackingField; // 0x68
	[CompilerGenerated]
	private Nullable<long> <FreeMemory>k__BackingField; // 0x78
	[CompilerGenerated]
	private Nullable<long> <UsableMemory>k__BackingField; // 0x88
	[CompilerGenerated]
	private Nullable<bool> <LowMemory>k__BackingField; // 0x98
	[CompilerGenerated]
	private Nullable<long> <StorageSize>k__BackingField; // 0xA0
	[CompilerGenerated]
	private Nullable<long> <FreeStorage>k__BackingField; // 0xB0
	[CompilerGenerated]
	private Nullable<long> <ExternalStorageSize>k__BackingField; // 0xC0
	[CompilerGenerated]
	private Nullable<long> <ExternalFreeStorage>k__BackingField; // 0xD0
	[CompilerGenerated]
	private string <ScreenResolution>k__BackingField; // 0xE0
	[CompilerGenerated]
	private Nullable<float> <ScreenDensity>k__BackingField; // 0xE8
	[CompilerGenerated]
	private Nullable<int> <ScreenDpi>k__BackingField; // 0xF0
	[CompilerGenerated]
	private Nullable<DateTimeOffset> <BootTime>k__BackingField; // 0xF8
	[CompilerGenerated]
	private Nullable<int> <ProcessorCount>k__BackingField; // 0x110
	[CompilerGenerated]
	private string <CpuDescription>k__BackingField; // 0x118
	[CompilerGenerated]
	private Nullable<int> <ProcessorFrequency>k__BackingField; // 0x120
	[CompilerGenerated]
	private string <DeviceType>k__BackingField; // 0x128
	[CompilerGenerated]
	private string <BatteryStatus>k__BackingField; // 0x130
	[CompilerGenerated]
	private string <DeviceUniqueIdentifier>k__BackingField; // 0x138
	[CompilerGenerated]
	private Nullable<bool> <SupportsVibration>k__BackingField; // 0x140
	[CompilerGenerated]
	private Nullable<bool> <SupportsAccelerometer>k__BackingField; // 0x142
	[CompilerGenerated]
	private Nullable<bool> <SupportsGyroscope>k__BackingField; // 0x144
	[CompilerGenerated]
	private Nullable<bool> <SupportsAudio>k__BackingField; // 0x146
	[CompilerGenerated]
	private Nullable<bool> <SupportsLocationService>k__BackingField; // 0x148

	// Properties
	public TimeZoneInfo Timezone { get; set; }
	public string Name { get; set; }
	public string Manufacturer { get; set; }
	public string Brand { get; set; }
	public string Family { get; set; }
	public string Model { get; set; }
	public string ModelId { get; set; }
	public string Architecture { get; set; }
	public Nullable<short> BatteryLevel { get; set; }
	public Nullable<bool> IsCharging { get; set; }
	public Nullable<bool> IsOnline { get; set; }
	public Nullable<DeviceOrientation> Orientation { get; set; }
	public Nullable<bool> Simulator { get; set; }
	public Nullable<long> MemorySize { get; set; }
	public Nullable<long> FreeMemory { get; set; }
	public Nullable<long> UsableMemory { get; set; }
	public Nullable<bool> LowMemory { get; set; }
	public Nullable<long> StorageSize { get; set; }
	public Nullable<long> FreeStorage { get; set; }
	public Nullable<long> ExternalStorageSize { get; set; }
	public Nullable<long> ExternalFreeStorage { get; set; }
	public string ScreenResolution { get; set; }
	public Nullable<float> ScreenDensity { get; set; }
	public Nullable<int> ScreenDpi { get; set; }
	public Nullable<DateTimeOffset> BootTime { get; set; }
	public Nullable<int> ProcessorCount { get; set; }
	public string CpuDescription { get; set; }
	public Nullable<int> ProcessorFrequency { get; set; }
	public string DeviceType { get; set; }
	public string BatteryStatus { get; set; }
	public string DeviceUniqueIdentifier { get; set; }
	public Nullable<bool> SupportsVibration { get; set; }
	public Nullable<bool> SupportsAccelerometer { get; set; }
	public Nullable<bool> SupportsGyroscope { get; set; }
	public Nullable<bool> SupportsAudio { get; set; }
	public Nullable<bool> SupportsLocationService { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public TimeZoneInfo get_Timezone() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_Timezone(TimeZoneInfo value) { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_Name(string value) { }

	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public string get_Manufacturer() { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_Manufacturer(string value) { }

	[CompilerGenerated]
	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public string get_Brand() { }

	[CompilerGenerated]
	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	public void set_Brand(string value) { }

	[CompilerGenerated]
	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public string get_Family() { }

	[CompilerGenerated]
	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	public void set_Family(string value) { }

	[CompilerGenerated]
	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public string get_Model() { }

	[CompilerGenerated]
	// RVA: 0x40EC50 Offset: 0x40DE50 VA: 0x18040EC50
	public void set_Model(string value) { }

	[CompilerGenerated]
	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	public string get_ModelId() { }

	[CompilerGenerated]
	// RVA: 0x415820 Offset: 0x414A20 VA: 0x180415820
	public void set_ModelId(string value) { }

	[CompilerGenerated]
	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0
	public string get_Architecture() { }

	[CompilerGenerated]
	// RVA: 0x41A200 Offset: 0x419400 VA: 0x18041A200
	public void set_Architecture(string value) { }

	[CompilerGenerated]
	// RVA: 0x430410 Offset: 0x42F610 VA: 0x180430410
	public Nullable<short> get_BatteryLevel() { }

	[CompilerGenerated]
	// RVA: 0x430630 Offset: 0x42F830 VA: 0x180430630
	public void set_BatteryLevel(Nullable<short> value) { }

	[CompilerGenerated]
	// RVA: 0x1C75710 Offset: 0x1C74910 VA: 0x181C75710
	public Nullable<bool> get_IsCharging() { }

	[CompilerGenerated]
	// RVA: 0x1C757F0 Offset: 0x1C749F0 VA: 0x181C757F0
	public void set_IsCharging(Nullable<bool> value) { }

	[CompilerGenerated]
	// RVA: 0x1C75720 Offset: 0x1C74920 VA: 0x181C75720
	public Nullable<bool> get_IsOnline() { }

	[CompilerGenerated]
	// RVA: 0x1C75800 Offset: 0x1C74A00 VA: 0x181C75800
	public void set_IsOnline(Nullable<bool> value) { }

	[CompilerGenerated]
	// RVA: 0x405090 Offset: 0x404290 VA: 0x180405090
	public Nullable<DeviceOrientation> get_Orientation() { }

	[CompilerGenerated]
	// RVA: 0x4050B0 Offset: 0x4042B0 VA: 0x1804050B0
	public void set_Orientation(Nullable<DeviceOrientation> value) { }

	[CompilerGenerated]
	// RVA: 0x12DC6A0 Offset: 0x12DB8A0 VA: 0x1812DC6A0
	public Nullable<bool> get_Simulator() { }

	[CompilerGenerated]
	// RVA: 0x12DC6C0 Offset: 0x12DB8C0 VA: 0x1812DC6C0
	public void set_Simulator(Nullable<bool> value) { }

	[CompilerGenerated]
	// RVA: 0x1C75730 Offset: 0x1C74930 VA: 0x181C75730
	public Nullable<long> get_MemorySize() { }

	[CompilerGenerated]
	// RVA: 0x1C75820 Offset: 0x1C74A20 VA: 0x181C75820
	public void set_MemorySize(Nullable<long> value) { }

	[CompilerGenerated]
	// RVA: 0x1C75700 Offset: 0x1C74900 VA: 0x181C75700
	public Nullable<long> get_FreeMemory() { }

	[CompilerGenerated]
	// RVA: 0x1C757E0 Offset: 0x1C749E0 VA: 0x181C757E0
	public void set_FreeMemory(Nullable<long> value) { }

	[CompilerGenerated]
	// RVA: 0x454B20 Offset: 0x453D20 VA: 0x180454B20
	public Nullable<long> get_UsableMemory() { }

	[CompilerGenerated]
	// RVA: 0x454B30 Offset: 0x453D30 VA: 0x180454B30
	public void set_UsableMemory(Nullable<long> value) { }

	[CompilerGenerated]
	// RVA: 0x1B8B2D0 Offset: 0x1B8A4D0 VA: 0x181B8B2D0
	public Nullable<bool> get_LowMemory() { }

	[CompilerGenerated]
	// RVA: 0x1C75810 Offset: 0x1C74A10 VA: 0x181C75810
	public void set_LowMemory(Nullable<bool> value) { }

	[CompilerGenerated]
	// RVA: 0x1BDDD30 Offset: 0x1BDCF30 VA: 0x181BDDD30
	public Nullable<long> get_StorageSize() { }

	[CompilerGenerated]
	// RVA: 0x1BE86E0 Offset: 0x1BE78E0 VA: 0x181BE86E0
	public void set_StorageSize(Nullable<long> value) { }

	[CompilerGenerated]
	// RVA: 0x1BDDD20 Offset: 0x1BDCF20 VA: 0x181BDDD20
	public Nullable<long> get_FreeStorage() { }

	[CompilerGenerated]
	// RVA: 0x1BE86D0 Offset: 0x1BE78D0 VA: 0x181BE86D0
	public void set_FreeStorage(Nullable<long> value) { }

	[CompilerGenerated]
	// RVA: 0x1C756F0 Offset: 0x1C748F0 VA: 0x181C756F0
	public Nullable<long> get_ExternalStorageSize() { }

	[CompilerGenerated]
	// RVA: 0x1C757D0 Offset: 0x1C749D0 VA: 0x181C757D0
	public void set_ExternalStorageSize(Nullable<long> value) { }

	[CompilerGenerated]
	// RVA: 0x1C756E0 Offset: 0x1C748E0 VA: 0x181C756E0
	public Nullable<long> get_ExternalFreeStorage() { }

	[CompilerGenerated]
	// RVA: 0x1C757C0 Offset: 0x1C749C0 VA: 0x181C757C0
	public void set_ExternalFreeStorage(Nullable<long> value) { }

	[CompilerGenerated]
	// RVA: 0x794D80 Offset: 0x793F80 VA: 0x180794D80
	public string get_ScreenResolution() { }

	[CompilerGenerated]
	// RVA: 0x8A5A60 Offset: 0x8A4C60 VA: 0x1808A5A60
	public void set_ScreenResolution(string value) { }

	[CompilerGenerated]
	// RVA: 0x796090 Offset: 0x795290 VA: 0x180796090
	public Nullable<float> get_ScreenDensity() { }

	[CompilerGenerated]
	// RVA: 0x7960E0 Offset: 0x7952E0 VA: 0x1807960E0
	public void set_ScreenDensity(Nullable<float> value) { }

	[CompilerGenerated]
	// RVA: 0x794CF0 Offset: 0x793EF0 VA: 0x180794CF0
	public Nullable<int> get_ScreenDpi() { }

	[CompilerGenerated]
	// RVA: 0x7960C0 Offset: 0x7952C0 VA: 0x1807960C0
	public void set_ScreenDpi(Nullable<int> value) { }

	[CompilerGenerated]
	// RVA: 0x1C756C0 Offset: 0x1C748C0 VA: 0x181C756C0
	public Nullable<DateTimeOffset> get_BootTime() { }

	[CompilerGenerated]
	// RVA: 0x1C757A0 Offset: 0x1C749A0 VA: 0x181C757A0
	public void set_BootTime(Nullable<DateTimeOffset> value) { }

	[CompilerGenerated]
	// RVA: 0x6ED520 Offset: 0x6EC720 VA: 0x1806ED520
	public Nullable<int> get_ProcessorCount() { }

	[CompilerGenerated]
	// RVA: 0x6ED6D0 Offset: 0x6EC8D0 VA: 0x1806ED6D0
	public void set_ProcessorCount(Nullable<int> value) { }

	[CompilerGenerated]
	// RVA: 0x6ED510 Offset: 0x6EC710 VA: 0x1806ED510
	public string get_CpuDescription() { }

	[CompilerGenerated]
	// RVA: 0x6ED6C0 Offset: 0x6EC8C0 VA: 0x1806ED6C0
	public void set_CpuDescription(string value) { }

	[CompilerGenerated]
	// RVA: 0x53DA70 Offset: 0x53CC70 VA: 0x18053DA70
	public Nullable<int> get_ProcessorFrequency() { }

	[CompilerGenerated]
	// RVA: 0x6ED6F0 Offset: 0x6EC8F0 VA: 0x1806ED6F0
	public void set_ProcessorFrequency(Nullable<int> value) { }

	[CompilerGenerated]
	// RVA: 0x6ED530 Offset: 0x6EC730 VA: 0x1806ED530
	public string get_DeviceType() { }

	[CompilerGenerated]
	// RVA: 0x5405B0 Offset: 0x53F7B0 VA: 0x1805405B0
	public void set_DeviceType(string value) { }

	[CompilerGenerated]
	// RVA: 0x19A2F10 Offset: 0x19A2110 VA: 0x1819A2F10
	public string get_BatteryStatus() { }

	[CompilerGenerated]
	// RVA: 0x1C75790 Offset: 0x1C74990 VA: 0x181C75790
	public void set_BatteryStatus(string value) { }

	[CompilerGenerated]
	// RVA: 0x794CA0 Offset: 0x793EA0 VA: 0x180794CA0
	public string get_DeviceUniqueIdentifier() { }

	[CompilerGenerated]
	// RVA: 0x1C62530 Offset: 0x1C61730 VA: 0x181C62530
	public void set_DeviceUniqueIdentifier(string value) { }

	[CompilerGenerated]
	// RVA: 0x1C75780 Offset: 0x1C74980 VA: 0x181C75780
	public Nullable<bool> get_SupportsVibration() { }

	[CompilerGenerated]
	// RVA: 0x1C75870 Offset: 0x1C74A70 VA: 0x181C75870
	public void set_SupportsVibration(Nullable<bool> value) { }

	[CompilerGenerated]
	// RVA: 0x1C75740 Offset: 0x1C74940 VA: 0x181C75740
	public Nullable<bool> get_SupportsAccelerometer() { }

	[CompilerGenerated]
	// RVA: 0x1C75830 Offset: 0x1C74A30 VA: 0x181C75830
	public void set_SupportsAccelerometer(Nullable<bool> value) { }

	[CompilerGenerated]
	// RVA: 0x1C75760 Offset: 0x1C74960 VA: 0x181C75760
	public Nullable<bool> get_SupportsGyroscope() { }

	[CompilerGenerated]
	// RVA: 0x1C75850 Offset: 0x1C74A50 VA: 0x181C75850
	public void set_SupportsGyroscope(Nullable<bool> value) { }

	[CompilerGenerated]
	// RVA: 0x1C75750 Offset: 0x1C74950 VA: 0x181C75750
	public Nullable<bool> get_SupportsAudio() { }

	[CompilerGenerated]
	// RVA: 0x1C75840 Offset: 0x1C74A40 VA: 0x181C75840
	public void set_SupportsAudio(Nullable<bool> value) { }

	[CompilerGenerated]
	// RVA: 0x1C75770 Offset: 0x1C74970 VA: 0x181C75770
	public Nullable<bool> get_SupportsLocationService() { }

	[CompilerGenerated]
	// RVA: 0x1C75860 Offset: 0x1C74A60 VA: 0x181C75860
	public void set_SupportsLocationService(Nullable<bool> value) { }

	[NullableContext(1)]
	// RVA: 0x1C72D40 Offset: 0x1C71F40 VA: 0x181C72D40
	internal Device Clone() { }

	[NullableContext(1)]
	// RVA: 0x1C745B0 Offset: 0x1C737B0 VA: 0x181C745B0 Slot: 5
	private Device Sentry.Internal.ICloneable<Sentry.Protocol.Device>.Clone() { }

	[NullableContext(1)]
	// RVA: 0x1C74EF0 Offset: 0x1C740F0 VA: 0x181C74EF0
	internal void UpdateFrom(Device source) { }

	[NullableContext(1)]
	// RVA: 0x1C74C50 Offset: 0x1C73E50 VA: 0x181C74C50 Slot: 7
	private void Sentry.Internal.IUpdatable.UpdateFrom(object source) { }

	[NullableContext(1)]
	// RVA: 0x1C747C0 Offset: 0x1C739C0 VA: 0x181C747C0 Slot: 6
	private void Sentry.Internal.IUpdatable<Sentry.Protocol.Device>.UpdateFrom(Device source) { }

	[NullableContext(1)]
	// RVA: 0x1C74F40 Offset: 0x1C74140 VA: 0x181C74F40 Slot: 4
	public void WriteTo(Utf8JsonWriter writer, IDiagnosticLogger _) { }

	// RVA: 0x1C74CC0 Offset: 0x1C73EC0 VA: 0x181C74CC0
	private static TimeZoneInfo TryParseTimezone(JsonElement json) { }

	[NullableContext(1)]
	// RVA: 0x1C72DF0 Offset: 0x1C71FF0 VA: 0x181C72DF0
	public static Device FromJson(JsonElement json) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: Sentry.Protocol
public enum DeviceOrientation // TypeDefIndex: 13526
{
	// Fields
	public int value__; // 0x0
	[EnumMember(Value = "portrait")]
	public const DeviceOrientation Portrait = 0;
	[EnumMember(Value = "landscape")]
	public const DeviceOrientation Landscape = 1;
}

// Namespace: Sentry.Protocol
[Nullable(0)]
[NullableContext(2)]
public sealed class Gpu : IJsonSerializable, ICloneable<Gpu>, IUpdatable<Gpu>, IUpdatable // TypeDefIndex: 13527
{
	// Fields
	[Nullable(1)]
	public const string Type = "gpu";
	[CompilerGenerated]
	private string <Name>k__BackingField; // 0x10
	[CompilerGenerated]
	private Nullable<int> <Id>k__BackingField; // 0x18
	[CompilerGenerated]
	private string <VendorId>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <VendorName>k__BackingField; // 0x28
	[CompilerGenerated]
	private Nullable<int> <MemorySize>k__BackingField; // 0x30
	[CompilerGenerated]
	private string <ApiType>k__BackingField; // 0x38
	[CompilerGenerated]
	private Nullable<bool> <MultiThreadedRendering>k__BackingField; // 0x40
	[CompilerGenerated]
	private string <Version>k__BackingField; // 0x48
	[CompilerGenerated]
	private string <NpotSupport>k__BackingField; // 0x50
	[CompilerGenerated]
	private Nullable<int> <MaxTextureSize>k__BackingField; // 0x58
	[CompilerGenerated]
	private string <GraphicsShaderLevel>k__BackingField; // 0x60
	[CompilerGenerated]
	private Nullable<bool> <SupportsDrawCallInstancing>k__BackingField; // 0x68
	[CompilerGenerated]
	private Nullable<bool> <SupportsRayTracing>k__BackingField; // 0x6A
	[CompilerGenerated]
	private Nullable<bool> <SupportsComputeShaders>k__BackingField; // 0x6C
	[CompilerGenerated]
	private Nullable<bool> <SupportsGeometryShaders>k__BackingField; // 0x6E

	// Properties
	public string Name { get; set; }
	public Nullable<int> Id { get; set; }
	public string VendorId { get; set; }
	public string VendorName { get; set; }
	public Nullable<int> MemorySize { get; set; }
	public string ApiType { get; set; }
	public Nullable<bool> MultiThreadedRendering { get; set; }
	public string Version { get; set; }
	public string NpotSupport { get; set; }
	public Nullable<int> MaxTextureSize { get; set; }
	public string GraphicsShaderLevel { get; set; }
	public Nullable<bool> SupportsDrawCallInstancing { get; set; }
	public Nullable<bool> SupportsRayTracing { get; set; }
	public Nullable<bool> SupportsComputeShaders { get; set; }
	public Nullable<bool> SupportsGeometryShaders { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_Name(string value) { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public Nullable<int> get_Id() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_Id(Nullable<int> value) { }

	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public string get_VendorId() { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_VendorId(string value) { }

	[CompilerGenerated]
	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public string get_VendorName() { }

	[CompilerGenerated]
	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	public void set_VendorName(string value) { }

	[CompilerGenerated]
	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public Nullable<int> get_MemorySize() { }

	[CompilerGenerated]
	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	public void set_MemorySize(Nullable<int> value) { }

	[CompilerGenerated]
	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public string get_ApiType() { }

	[CompilerGenerated]
	// RVA: 0x40EC50 Offset: 0x40DE50 VA: 0x18040EC50
	public void set_ApiType(string value) { }

	[CompilerGenerated]
	// RVA: 0x8CA290 Offset: 0x8C9490 VA: 0x1808CA290
	public Nullable<bool> get_MultiThreadedRendering() { }

	[CompilerGenerated]
	// RVA: 0x1C51A50 Offset: 0x1C50C50 VA: 0x181C51A50
	public void set_MultiThreadedRendering(Nullable<bool> value) { }

	[CompilerGenerated]
	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0
	public string get_Version() { }

	[CompilerGenerated]
	// RVA: 0x41A200 Offset: 0x419400 VA: 0x18041A200
	public void set_Version(string value) { }

	[CompilerGenerated]
	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0
	public string get_NpotSupport() { }

	[CompilerGenerated]
	// RVA: 0x4050C0 Offset: 0x4042C0 VA: 0x1804050C0
	public void set_NpotSupport(string value) { }

	[CompilerGenerated]
	// RVA: 0x405090 Offset: 0x404290 VA: 0x180405090
	public Nullable<int> get_MaxTextureSize() { }

	[CompilerGenerated]
	// RVA: 0x4050B0 Offset: 0x4042B0 VA: 0x1804050B0
	public void set_MaxTextureSize(Nullable<int> value) { }

	[CompilerGenerated]
	// RVA: 0x542860 Offset: 0x541A60 VA: 0x180542860
	public string get_GraphicsShaderLevel() { }

	[CompilerGenerated]
	// RVA: 0x542AA0 Offset: 0x541CA0 VA: 0x180542AA0
	public void set_GraphicsShaderLevel(string value) { }

	[CompilerGenerated]
	// RVA: 0x1862C20 Offset: 0x1861E20 VA: 0x181862C20
	public Nullable<bool> get_SupportsDrawCallInstancing() { }

	[CompilerGenerated]
	// RVA: 0x1862F50 Offset: 0x1862150 VA: 0x181862F50
	public void set_SupportsDrawCallInstancing(Nullable<bool> value) { }

	[CompilerGenerated]
	// RVA: 0x1C7AEF0 Offset: 0x1C7A0F0 VA: 0x181C7AEF0
	public Nullable<bool> get_SupportsRayTracing() { }

	[CompilerGenerated]
	// RVA: 0x1C7AF20 Offset: 0x1C7A120 VA: 0x181C7AF20
	public void set_SupportsRayTracing(Nullable<bool> value) { }

	[CompilerGenerated]
	// RVA: 0x1C7AED0 Offset: 0x1C7A0D0 VA: 0x181C7AED0
	public Nullable<bool> get_SupportsComputeShaders() { }

	[CompilerGenerated]
	// RVA: 0x1C7AF00 Offset: 0x1C7A100 VA: 0x181C7AF00
	public void set_SupportsComputeShaders(Nullable<bool> value) { }

	[CompilerGenerated]
	// RVA: 0x1C7AEE0 Offset: 0x1C7A0E0 VA: 0x181C7AEE0
	public Nullable<bool> get_SupportsGeometryShaders() { }

	[CompilerGenerated]
	// RVA: 0x1C7AF10 Offset: 0x1C7A110 VA: 0x181C7AF10
	public void set_SupportsGeometryShaders(Nullable<bool> value) { }

	[NullableContext(1)]
	// RVA: 0x1C79EF0 Offset: 0x1C790F0 VA: 0x181C79EF0
	internal Gpu Clone() { }

	[NullableContext(1)]
	// RVA: 0x1C7A8D0 Offset: 0x1C79AD0 VA: 0x181C7A8D0 Slot: 5
	private Gpu Sentry.Internal.ICloneable<Sentry.Protocol.Gpu>.Clone() { }

	[NullableContext(1)]
	// RVA: 0x1C7ABC0 Offset: 0x1C79DC0 VA: 0x181C7ABC0
	internal void UpdateFrom(Gpu source) { }

	[NullableContext(1)]
	// RVA: 0x1C7AB50 Offset: 0x1C79D50 VA: 0x181C7AB50 Slot: 7
	private void Sentry.Internal.IUpdatable.UpdateFrom(object source) { }

	[NullableContext(1)]
	// RVA: 0x1C7A9B0 Offset: 0x1C79BB0 VA: 0x181C7A9B0 Slot: 6
	private void Sentry.Internal.IUpdatable<Sentry.Protocol.Gpu>.UpdateFrom(Gpu source) { }

	[NullableContext(1)]
	// RVA: 0x1C7AC10 Offset: 0x1C79E10 VA: 0x181C7AC10 Slot: 4
	public void WriteTo(Utf8JsonWriter writer, IDiagnosticLogger _) { }

	[NullableContext(1)]
	// RVA: 0x1C79FA0 Offset: 0x1C791A0 VA: 0x181C79FA0
	public static Gpu FromJson(JsonElement json) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: Sentry.Protocol
[NullableContext(1)]
public interface ITraceContext // TypeDefIndex: 13528
{
	// Properties
	public abstract SpanId SpanId { get; }
	public abstract Nullable<SpanId> ParentSpanId { get; }
	public abstract SentryId TraceId { get; }
	public abstract string Operation { get; }
	[Nullable(2)]
	public abstract string Description { get; }
	public abstract Nullable<SpanStatus> Status { get; }
	public abstract Nullable<bool> IsSampled { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract SpanId get_SpanId();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract Nullable<SpanId> get_ParentSpanId();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract SentryId get_TraceId();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract string get_Operation();

	[NullableContext(2)]
	// RVA: -1 Offset: -1 Slot: 4
	public abstract string get_Description();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract Nullable<SpanStatus> get_Status();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract Nullable<bool> get_IsSampled();
}

// Namespace: Sentry.Protocol
[NullableContext(1)]
[Nullable(0)]
public sealed class Measurement : IJsonSerializable // TypeDefIndex: 13529
{
	// Fields
	[CompilerGenerated]
	private readonly object <Value>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly MeasurementUnit <Unit>k__BackingField; // 0x18

	// Properties
	public object Value { get; }
	public MeasurementUnit Unit { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public object get_Value() { }

	[CompilerGenerated]
	// RVA: 0x42D820 Offset: 0x42CA20 VA: 0x18042D820
	public MeasurementUnit get_Unit() { }

	// RVA: 0xCC89D0 Offset: 0xCC7BD0 VA: 0x180CC89D0
	private void .ctor(object value, MeasurementUnit unit) { }

	// RVA: 0x1C7B860 Offset: 0x1C7AA60 VA: 0x181C7B860
	internal void .ctor(int value, MeasurementUnit unit) { }

	// RVA: 0x1C7B780 Offset: 0x1C7A980 VA: 0x181C7B780
	internal void .ctor(long value, MeasurementUnit unit) { }

	// RVA: 0x1C7B7F0 Offset: 0x1C7A9F0 VA: 0x181C7B7F0
	internal void .ctor(ulong value, MeasurementUnit unit) { }

	// RVA: 0x1C7B710 Offset: 0x1C7A910 VA: 0x181C7B710
	internal void .ctor(double value, MeasurementUnit unit) { }

	// RVA: 0x1C7B4B0 Offset: 0x1C7A6B0 VA: 0x181C7B4B0 Slot: 4
	public void WriteTo(Utf8JsonWriter writer, IDiagnosticLogger logger) { }

	// RVA: 0x1C7B330 Offset: 0x1C7A530 VA: 0x181C7B330
	public static Measurement FromJson(JsonElement json) { }
}

// Namespace: Sentry.Protocol
[NullableContext(1)]
[Nullable(0)]
public sealed class Mechanism : IJsonSerializable // TypeDefIndex: 13530
{
	// Fields
	public static readonly string HandledKey; // 0x0
	public static readonly string MechanismKey; // 0x8
	public static readonly string DescriptionKey; // 0x10
	[Nullable(new[] { 2, 1, 1 })]
	[CompilerGenerated]
	private Dictionary<string, object> <InternalData>k__BackingField; // 0x10
	[CompilerGenerated]
	[Nullable(new[] { 2, 1, 1 })]
	private Dictionary<string, object> <InternalMeta>k__BackingField; // 0x18
	private const string DefaultType = "generic";
	private string _type; // 0x20
	[CompilerGenerated]
	[Nullable(2)]
	private string <Description>k__BackingField; // 0x28
	[Nullable(2)]
	[CompilerGenerated]
	private string <Source>k__BackingField; // 0x30
	[CompilerGenerated]
	[Nullable(2)]
	private string <HelpLink>k__BackingField; // 0x38
	[CompilerGenerated]
	private Nullable<bool> <Handled>k__BackingField; // 0x40
	[CompilerGenerated]
	private bool <Synthetic>k__BackingField; // 0x42
	[CompilerGenerated]
	private bool <IsExceptionGroup>k__BackingField; // 0x43
	[CompilerGenerated]
	private Nullable<int> <ExceptionId>k__BackingField; // 0x44
	[CompilerGenerated]
	private Nullable<int> <ParentId>k__BackingField; // 0x4C

	// Properties
	[Nullable(new[] { 2, 1, 1 })]
	internal Dictionary<string, object> InternalData { get; set; }
	[Nullable(new[] { 2, 1, 1 })]
	internal Dictionary<string, object> InternalMeta { get; set; }
	public string Type { get; set; }
	[Nullable(2)]
	public string Description { get; set; }
	[Nullable(2)]
	public string Source { get; set; }
	[Nullable(2)]
	public string HelpLink { get; set; }
	public Nullable<bool> Handled { get; set; }
	public bool Synthetic { get; set; }
	public bool IsExceptionGroup { get; set; }
	public Nullable<int> ExceptionId { get; set; }
	public Nullable<int> ParentId { get; set; }
	public IDictionary<string, object> Meta { get; }
	public IDictionary<string, object> Data { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	internal Dictionary<string, object> get_InternalData() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	private void set_InternalData(Dictionary<string, object> value) { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	internal Dictionary<string, object> get_InternalMeta() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	private void set_InternalMeta(Dictionary<string, object> value) { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public string get_Type() { }

	// RVA: 0x1C7C550 Offset: 0x1C7B750 VA: 0x181C7C550
	public void set_Type(string value) { }

	[NullableContext(2)]
	[CompilerGenerated]
	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public string get_Description() { }

	[NullableContext(2)]
	[CompilerGenerated]
	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	public void set_Description(string value) { }

	[NullableContext(2)]
	[CompilerGenerated]
	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public string get_Source() { }

	[NullableContext(2)]
	[CompilerGenerated]
	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	public void set_Source(string value) { }

	[CompilerGenerated]
	[NullableContext(2)]
	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public string get_HelpLink() { }

	[NullableContext(2)]
	[CompilerGenerated]
	// RVA: 0x40EC50 Offset: 0x40DE50 VA: 0x18040EC50
	public void set_HelpLink(string value) { }

	[CompilerGenerated]
	// RVA: 0x8CA290 Offset: 0x8C9490 VA: 0x1808CA290
	public Nullable<bool> get_Handled() { }

	[CompilerGenerated]
	// RVA: 0x1C51A50 Offset: 0x1C50C50 VA: 0x181C51A50
	public void set_Handled(Nullable<bool> value) { }

	[CompilerGenerated]
	// RVA: 0x6F90C0 Offset: 0x6F82C0 VA: 0x1806F90C0
	public bool get_Synthetic() { }

	[CompilerGenerated]
	// RVA: 0x1C44C00 Offset: 0x1C43E00 VA: 0x181C44C00
	public void set_Synthetic(bool value) { }

	[CompilerGenerated]
	// RVA: 0x772500 Offset: 0x771700 VA: 0x180772500
	public bool get_IsExceptionGroup() { }

	[CompilerGenerated]
	// RVA: 0x1C44C20 Offset: 0x1C43E20 VA: 0x181C44C20
	public void set_IsExceptionGroup(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1C7C4D0 Offset: 0x1C7B6D0 VA: 0x181C7C4D0
	public Nullable<int> get_ExceptionId() { }

	[CompilerGenerated]
	// RVA: 0x5BABD0 Offset: 0x5B9DD0 VA: 0x1805BABD0
	public void set_ExceptionId(Nullable<int> value) { }

	[CompilerGenerated]
	// RVA: 0x1826C60 Offset: 0x1825E60 VA: 0x181826C60
	public Nullable<int> get_ParentId() { }

	[CompilerGenerated]
	// RVA: 0x5BABE0 Offset: 0x5B9DE0 VA: 0x1805BABE0
	public void set_ParentId(Nullable<int> value) { }

	// RVA: 0x1C7C4E0 Offset: 0x1C7B6E0 VA: 0x181C7C4E0
	public IDictionary<string, object> get_Meta() { }

	// RVA: 0x1C7C460 Offset: 0x1C7B660 VA: 0x181C7C460
	public IDictionary<string, object> get_Data() { }

	// RVA: 0x1C7C120 Offset: 0x1C7B320 VA: 0x181C7C120 Slot: 4
	public void WriteTo(Utf8JsonWriter writer, IDiagnosticLogger logger) { }

	// RVA: 0x1C7B8D0 Offset: 0x1C7AAD0 VA: 0x181C7B8D0
	public static Mechanism FromJson(JsonElement json) { }

	// RVA: 0x1C7C000 Offset: 0x1C7B200 VA: 0x181C7C000
	internal bool IsDefaultOrEmpty() { }

	// RVA: 0x1C7C420 Offset: 0x1C7B620 VA: 0x181C7C420
	public void .ctor() { }

	// RVA: 0x1C7C380 Offset: 0x1C7B580 VA: 0x181C7C380
	private static void .cctor() { }
}

// Namespace: Sentry.Protocol
[NullableContext(2)]
[Nullable(0)]
public sealed class OperatingSystem : IJsonSerializable, ICloneable<OperatingSystem>, IUpdatable<OperatingSystem>, IUpdatable // TypeDefIndex: 13531
{
	// Fields
	[Nullable(1)]
	public const string Type = "os";
	[CompilerGenerated]
	private string <Name>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <Version>k__BackingField; // 0x18
	[CompilerGenerated]
	private string <RawDescription>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <Build>k__BackingField; // 0x28
	[CompilerGenerated]
	private string <KernelVersion>k__BackingField; // 0x30
	[CompilerGenerated]
	private Nullable<bool> <Rooted>k__BackingField; // 0x38

	// Properties
	public string Name { get; set; }
	public string Version { get; set; }
	public string RawDescription { get; set; }
	public string Build { get; set; }
	public string KernelVersion { get; set; }
	public Nullable<bool> Rooted { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_Name(string value) { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_Version() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_Version(string value) { }

	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public string get_RawDescription() { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_RawDescription(string value) { }

	[CompilerGenerated]
	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public string get_Build() { }

	[CompilerGenerated]
	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	public void set_Build(string value) { }

	[CompilerGenerated]
	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public string get_KernelVersion() { }

	[CompilerGenerated]
	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	public void set_KernelVersion(string value) { }

	[CompilerGenerated]
	// RVA: 0x1C7CDB0 Offset: 0x1C7BFB0 VA: 0x181C7CDB0
	public Nullable<bool> get_Rooted() { }

	[CompilerGenerated]
	// RVA: 0x1B6EF70 Offset: 0x1B6E170 VA: 0x181B6EF70
	public void set_Rooted(Nullable<bool> value) { }

	[NullableContext(1)]
	// RVA: 0x1C7C5B0 Offset: 0x1C7B7B0 VA: 0x181C7C5B0
	internal OperatingSystem Clone() { }

	[NullableContext(1)]
	// RVA: 0x1C7CA20 Offset: 0x1C7BC20 VA: 0x181C7CA20 Slot: 5
	private OperatingSystem Sentry.Internal.ICloneable<Sentry.Protocol.OperatingSystem>.Clone() { }

	[NullableContext(1)]
	// RVA: 0x1C7CBE0 Offset: 0x1C7BDE0 VA: 0x181C7CBE0
	internal void UpdateFrom(OperatingSystem source) { }

	[NullableContext(1)]
	// RVA: 0x1C7CB70 Offset: 0x1C7BD70 VA: 0x181C7CB70 Slot: 7
	private void Sentry.Internal.IUpdatable.UpdateFrom(object source) { }

	[NullableContext(1)]
	// RVA: 0x1C7CAB0 Offset: 0x1C7BCB0 VA: 0x181C7CAB0 Slot: 6
	private void Sentry.Internal.IUpdatable<Sentry.Protocol.OperatingSystem>.UpdateFrom(OperatingSystem source) { }

	[NullableContext(1)]
	// RVA: 0x1C7CC30 Offset: 0x1C7BE30 VA: 0x181C7CC30 Slot: 4
	public void WriteTo(Utf8JsonWriter writer, IDiagnosticLogger _) { }

	[NullableContext(1)]
	// RVA: 0x1C7C660 Offset: 0x1C7B860 VA: 0x181C7C660
	public static OperatingSystem FromJson(JsonElement json) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: Sentry.Protocol
[Nullable(0)]
[NullableContext(2)]
internal sealed class ProfileInfo : IJsonSerializable // TypeDefIndex: 13532
{
	// Fields
	[CompilerGenerated]
	private SentryId <EventId>k__BackingField; // 0x10
	[Nullable(1)]
	[CompilerGenerated]
	private DebugMeta <DebugMeta>k__BackingField; // 0x20
	[Nullable(1)]
	private readonly Contexts _contexts; // 0x28
	[Nullable(1)]
	[CompilerGenerated]
	private SampleProfile <Profile>k__BackingField; // 0x30
	[CompilerGenerated]
	private DateTimeOffset <StartTimestamp>k__BackingField; // 0x38
	[CompilerGenerated]
	private string <Environment>k__BackingField; // 0x48
	[CompilerGenerated]
	private string <Platform>k__BackingField; // 0x50
	[CompilerGenerated]
	private string <Release>k__BackingField; // 0x58
	[CompilerGenerated]
	private Transaction <Transaction>k__BackingField; // 0x60

	// Properties
	public SentryId EventId { get; set; }
	[Nullable(1)]
	public DebugMeta DebugMeta { get; set; }
	[Nullable(1)]
	public Contexts Contexts { get; set; }
	[Nullable(1)]
	public SampleProfile Profile { get; set; }
	public DateTimeOffset StartTimestamp { get; set; }
	public string Environment { get; set; }
	public string Platform { get; set; }
	public string Release { get; set; }
	public Transaction Transaction { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x482990 Offset: 0x481B90 VA: 0x180482990
	public SentryId get_EventId() { }

	[CompilerGenerated]
	// RVA: 0x4829A0 Offset: 0x481BA0 VA: 0x1804829A0
	private void set_EventId(SentryId value) { }

	[CompilerGenerated]
	[NullableContext(1)]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public DebugMeta get_DebugMeta() { }

	[CompilerGenerated]
	[NullableContext(1)]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_DebugMeta(DebugMeta value) { }

	[NullableContext(1)]
	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public Contexts get_Contexts() { }

	[NullableContext(1)]
	// RVA: 0x1C7D6F0 Offset: 0x1C7C8F0 VA: 0x181C7D6F0
	public void set_Contexts(Contexts value) { }

	[NullableContext(1)]
	[CompilerGenerated]
	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public SampleProfile get_Profile() { }

	[NullableContext(1)]
	[CompilerGenerated]
	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	public void set_Profile(SampleProfile value) { }

	[CompilerGenerated]
	// RVA: 0x526C40 Offset: 0x525E40 VA: 0x180526C40
	public DateTimeOffset get_StartTimestamp() { }

	[CompilerGenerated]
	// RVA: 0x526D50 Offset: 0x525F50 VA: 0x180526D50
	public void set_StartTimestamp(DateTimeOffset value) { }

	[CompilerGenerated]
	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0
	public string get_Environment() { }

	[CompilerGenerated]
	// RVA: 0x41A200 Offset: 0x419400 VA: 0x18041A200
	public void set_Environment(string value) { }

	[CompilerGenerated]
	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0
	public string get_Platform() { }

	[CompilerGenerated]
	// RVA: 0x4050C0 Offset: 0x4042C0 VA: 0x1804050C0
	public void set_Platform(string value) { }

	[CompilerGenerated]
	// RVA: 0x405090 Offset: 0x404290 VA: 0x180405090
	public string get_Release() { }

	[CompilerGenerated]
	// RVA: 0x4050B0 Offset: 0x4042B0 VA: 0x1804050B0
	public void set_Release(string value) { }

	[CompilerGenerated]
	// RVA: 0x542860 Offset: 0x541A60 VA: 0x180542860
	public Transaction get_Transaction() { }

	[CompilerGenerated]
	// RVA: 0x542AA0 Offset: 0x541CA0 VA: 0x180542AA0
	public void set_Transaction(Transaction value) { }

	[NullableContext(1)]
	// RVA: 0x1C7CDC0 Offset: 0x1C7BFC0 VA: 0x181C7CDC0 Slot: 4
	public void WriteTo(Utf8JsonWriter writer, IDiagnosticLogger logger) { }

	// RVA: 0x1C7D480 Offset: 0x1C7C680 VA: 0x181C7D480
	public void .ctor() { }
}

// Namespace: Sentry.Protocol
[Nullable(0)]
[NullableContext(1)]
public sealed class Response : IJsonSerializable, ICloneable<Response>, IUpdatable<Response>, IUpdatable // TypeDefIndex: 13533
{
	// Fields
	public const string Type = "response";
	[CompilerGenerated]
	[Nullable(new[] { 2, 1, 1 })]
	private Dictionary<string, string> <InternalHeaders>k__BackingField; // 0x10
	[CompilerGenerated]
	private Nullable<long> <BodySize>k__BackingField; // 0x18
	[CompilerGenerated]
	[Nullable(2)]
	private string <Cookies>k__BackingField; // 0x28
	[Nullable(2)]
	[CompilerGenerated]
	private object <Data>k__BackingField; // 0x30
	[CompilerGenerated]
	private Nullable<short> <StatusCode>k__BackingField; // 0x38

	// Properties
	[Nullable(new[] { 2, 1, 1 })]
	internal Dictionary<string, string> InternalHeaders { get; set; }
	public Nullable<long> BodySize { get; set; }
	[Nullable(2)]
	public string Cookies { get; set; }
	[Nullable(2)]
	public object Data { get; set; }
	public IDictionary<string, string> Headers { get; }
	public Nullable<short> StatusCode { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	internal Dictionary<string, string> get_InternalHeaders() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	private void set_InternalHeaders(Dictionary<string, string> value) { }

	[CompilerGenerated]
	// RVA: 0x42D820 Offset: 0x42CA20 VA: 0x18042D820
	public Nullable<long> get_BodySize() { }

	[CompilerGenerated]
	// RVA: 0x42D8A0 Offset: 0x42CAA0 VA: 0x18042D8A0
	public void set_BodySize(Nullable<long> value) { }

	[CompilerGenerated]
	[NullableContext(2)]
	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public string get_Cookies() { }

	[CompilerGenerated]
	[NullableContext(2)]
	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	public void set_Cookies(string value) { }

	[CompilerGenerated]
	[NullableContext(2)]
	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public object get_Data() { }

	[CompilerGenerated]
	[NullableContext(2)]
	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	public void set_Data(object value) { }

	// RVA: 0x1C7E240 Offset: 0x1C7D440 VA: 0x181C7E240
	public IDictionary<string, string> get_Headers() { }

	[CompilerGenerated]
	// RVA: 0x4232F0 Offset: 0x4224F0 VA: 0x1804232F0
	public Nullable<short> get_StatusCode() { }

	[CompilerGenerated]
	// RVA: 0x423300 Offset: 0x422500 VA: 0x180423300
	public void set_StatusCode(Nullable<short> value) { }

	// RVA: 0x1C7D710 Offset: 0x1C7C910 VA: 0x181C7D710
	internal void AddHeaders(IEnumerable<KeyValuePair<string, IEnumerable<string>>> headers) { }

	// RVA: 0x1C7DA10 Offset: 0x1C7CC10 VA: 0x181C7DA10 Slot: 5
	public Response Clone() { }

	// RVA: 0x1C7DEF0 Offset: 0x1C7D0F0 VA: 0x181C7DEF0 Slot: 6
	public void UpdateFrom(Response source) { }

	// RVA: 0x1C7DFC0 Offset: 0x1C7D1C0 VA: 0x181C7DFC0 Slot: 7
	public void UpdateFrom(object source) { }

	// RVA: 0x1C7E0C0 Offset: 0x1C7D2C0 VA: 0x181C7E0C0 Slot: 4
	public void WriteTo(Utf8JsonWriter writer, IDiagnosticLogger logger) { }

	// RVA: 0x1C7DB20 Offset: 0x1C7CD20 VA: 0x181C7DB20
	public static Response FromJson(JsonElement json) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: Sentry.Protocol
[Nullable(0)]
[NullableContext(2)]
public sealed class Runtime : IJsonSerializable, ICloneable<Runtime>, IUpdatable<Runtime>, IUpdatable // TypeDefIndex: 13534
{
	// Fields
	[Nullable(1)]
	public const string Type = "runtime";
	[CompilerGenerated]
	private string <Name>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <Version>k__BackingField; // 0x18
	[CompilerGenerated]
	private string <RawDescription>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <Identifier>k__BackingField; // 0x28
	[CompilerGenerated]
	private string <Build>k__BackingField; // 0x30

	// Properties
	public string Name { get; set; }
	public string Version { get; set; }
	public string RawDescription { get; set; }
	public string Identifier { get; set; }
	public string Build { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_Name(string value) { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_Version() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_Version(string value) { }

	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public string get_RawDescription() { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_RawDescription(string value) { }

	[CompilerGenerated]
	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public string get_Identifier() { }

	[CompilerGenerated]
	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	public void set_Identifier(string value) { }

	[CompilerGenerated]
	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public string get_Build() { }

	[CompilerGenerated]
	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	public void set_Build(string value) { }

	[Obsolete("This method will be made internal in a future version.")]
	[NullableContext(1)]
	// RVA: 0x1C7E2B0 Offset: 0x1C7D4B0 VA: 0x181C7E2B0
	public Runtime Clone() { }

	[NullableContext(1)]
	// RVA: 0x1C7E670 Offset: 0x1C7D870 VA: 0x181C7E670 Slot: 5
	private Runtime Sentry.Internal.ICloneable<Sentry.Protocol.Runtime>.Clone() { }

	[NullableContext(1)]
	// RVA: 0x1C7E7F0 Offset: 0x1C7D9F0 VA: 0x181C7E7F0
	internal void UpdateFrom(Runtime source) { }

	[NullableContext(1)]
	// RVA: 0x1C7E780 Offset: 0x1C7D980 VA: 0x181C7E780 Slot: 7
	private void Sentry.Internal.IUpdatable.UpdateFrom(object source) { }

	[NullableContext(1)]
	// RVA: 0x1C7E700 Offset: 0x1C7D900 VA: 0x181C7E700 Slot: 6
	private void Sentry.Internal.IUpdatable<Sentry.Protocol.Runtime>.UpdateFrom(Runtime source) { }

	[NullableContext(1)]
	// RVA: 0x1C7E840 Offset: 0x1C7DA40 VA: 0x181C7E840 Slot: 4
	public void WriteTo(Utf8JsonWriter writer, IDiagnosticLogger _) { }

	[NullableContext(1)]
	// RVA: 0x1C7E360 Offset: 0x1C7D560 VA: 0x181C7E360
	public static Runtime FromJson(JsonElement json) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
public class SampleProfile.Sample : IJsonSerializable // TypeDefIndex: 13535
{
	// Fields
	public ulong Timestamp; // 0x10
	public int ThreadId; // 0x18
	public int StackId; // 0x1C

	// Methods

	[NullableContext(1)]
	// RVA: 0x1C7ED60 Offset: 0x1C7DF60 VA: 0x181C7ED60 Slot: 4
	public void WriteTo(Utf8JsonWriter writer, IDiagnosticLogger logger) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: Sentry.Protocol
internal sealed class SampleProfile : IJsonSerializable // TypeDefIndex: 13536
{
	// Fields
	[Nullable(new[] { 0, 1 })]
	internal GrowableArray<SampleProfile.Sample> Samples; // 0x10
	[Nullable(new[] { 0, 1 })]
	internal GrowableArray<SentryStackFrame> Frames; // 0x20
	internal GrowableArray<GrowableArray<int>> Stacks; // 0x30
	[Nullable(1)]
	internal List<SentryThread> Threads; // 0x40

	// Methods

	[NullableContext(1)]
	// RVA: 0x1C7E9A0 Offset: 0x1C7DBA0 VA: 0x181C7E9A0 Slot: 4
	public void WriteTo(Utf8JsonWriter writer, IDiagnosticLogger logger) { }

	// RVA: 0x1C7EC50 Offset: 0x1C7DE50 VA: 0x181C7EC50
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private static class SentryException.<>O // TypeDefIndex: 13537
{
	// Fields
	[Nullable(0)]
	public static Func<JsonElement, SentryStackTrace> <0>__FromJson; // 0x0
	[Nullable(0)]
	public static Func<JsonElement, Mechanism> <1>__FromJson; // 0x8
}

// Namespace: Sentry.Protocol
[Nullable(0)]
[NullableContext(2)]
public sealed class SentryException : IJsonSerializable // TypeDefIndex: 13538
{
	// Fields
	[CompilerGenerated]
	private string <Type>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <Value>k__BackingField; // 0x18
	[CompilerGenerated]
	private string <Module>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <ThreadId>k__BackingField; // 0x28
	[CompilerGenerated]
	private SentryStackTrace <Stacktrace>k__BackingField; // 0x30
	[CompilerGenerated]
	private Mechanism <Mechanism>k__BackingField; // 0x38
	[Nullable(new[] { 1, 1, 2 })]
	[CompilerGenerated]
	private readonly IDictionary<string, object> <Data>k__BackingField; // 0x40

	// Properties
	public string Type { get; set; }
	public string Value { get; set; }
	public string Module { get; set; }
	public int ThreadId { get; set; }
	public SentryStackTrace Stacktrace { get; set; }
	public Mechanism Mechanism { get; set; }
	[Obsolete("Use SentryException.Mechanism.Data instead. This property will be removed in a future version.")]
	[Nullable(new[] { 1, 1, 2 })]
	public IDictionary<string, object> Data { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_Type() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_Type(string value) { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_Value() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_Value(string value) { }

	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public string get_Module() { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_Module(string value) { }

	[CompilerGenerated]
	// RVA: 0x3DA050 Offset: 0x3D9250 VA: 0x1803DA050
	public int get_ThreadId() { }

	[CompilerGenerated]
	// RVA: 0x3DA200 Offset: 0x3D9400 VA: 0x1803DA200
	public void set_ThreadId(int value) { }

	[CompilerGenerated]
	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public SentryStackTrace get_Stacktrace() { }

	[CompilerGenerated]
	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	public void set_Stacktrace(SentryStackTrace value) { }

	[CompilerGenerated]
	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public Mechanism get_Mechanism() { }

	[CompilerGenerated]
	// RVA: 0x40EC50 Offset: 0x40DE50 VA: 0x18040EC50
	public void set_Mechanism(Mechanism value) { }

	[CompilerGenerated]
	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	public IDictionary<string, object> get_Data() { }

	[NullableContext(1)]
	// RVA: 0x1C7F380 Offset: 0x1C7E580 VA: 0x181C7F380 Slot: 4
	public void WriteTo(Utf8JsonWriter writer, IDiagnosticLogger logger) { }

	[NullableContext(1)]
	// RVA: 0x1C7EE10 Offset: 0x1C7E010 VA: 0x181C7EE10
	public static SentryException FromJson(JsonElement json) { }

	// RVA: 0x1C7F550 Offset: 0x1C7E750 VA: 0x181C7F550
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private static class Trace.<>O // TypeDefIndex: 13539
{
	// Fields
	[Nullable(0)]
	public static Func<JsonElement, SpanId> <0>__FromJson; // 0x0
	[Nullable(0)]
	public static Func<JsonElement, SentryId> <1>__FromJson; // 0x8
}

// Namespace: Sentry.Protocol
[Nullable(0)]
[NullableContext(1)]
public class Trace : ITraceContext, IJsonSerializable, ICloneable<Trace>, IUpdatable<Trace>, IUpdatable // TypeDefIndex: 13540
{
	// Fields
	public const string Type = "trace";
	[CompilerGenerated]
	private SpanId <SpanId>k__BackingField; // 0x10
	[CompilerGenerated]
	private Nullable<SpanId> <ParentSpanId>k__BackingField; // 0x18
	[CompilerGenerated]
	private SentryId <TraceId>k__BackingField; // 0x28
	[CompilerGenerated]
	private string <Operation>k__BackingField; // 0x38
	[Nullable(2)]
	[CompilerGenerated]
	private string <Description>k__BackingField; // 0x40
	[CompilerGenerated]
	private Nullable<SpanStatus> <Status>k__BackingField; // 0x48
	[CompilerGenerated]
	private Nullable<bool> <IsSampled>k__BackingField; // 0x50

	// Properties
	public SpanId SpanId { get; set; }
	public Nullable<SpanId> ParentSpanId { get; set; }
	public SentryId TraceId { get; set; }
	public string Operation { get; set; }
	[Nullable(2)]
	public string Description { get; set; }
	public Nullable<SpanStatus> Status { get; set; }
	public Nullable<bool> IsSampled { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0 Slot: 4
	public SpanId get_SpanId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_SpanId(SpanId value) { }

	[CompilerGenerated]
	// RVA: 0x42D820 Offset: 0x42CA20 VA: 0x18042D820 Slot: 5
	public Nullable<SpanId> get_ParentSpanId() { }

	[CompilerGenerated]
	// RVA: 0x42D8A0 Offset: 0x42CAA0 VA: 0x18042D8A0
	public void set_ParentSpanId(Nullable<SpanId> value) { }

	[CompilerGenerated]
	// RVA: 0x3F6C80 Offset: 0x3F5E80 VA: 0x1803F6C80 Slot: 6
	public SentryId get_TraceId() { }

	[CompilerGenerated]
	// RVA: 0x3F6CA0 Offset: 0x3F5EA0 VA: 0x1803F6CA0
	public void set_TraceId(SentryId value) { }

	[CompilerGenerated]
	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30 Slot: 7
	public string get_Operation() { }

	[CompilerGenerated]
	// RVA: 0x40EC50 Offset: 0x40DE50 VA: 0x18040EC50
	public void set_Operation(string value) { }

	[NullableContext(2)]
	[CompilerGenerated]
	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0 Slot: 8
	public string get_Description() { }

	[NullableContext(2)]
	[CompilerGenerated]
	// RVA: 0x415820 Offset: 0x414A20 VA: 0x180415820
	public void set_Description(string value) { }

	[CompilerGenerated]
	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0 Slot: 9
	public Nullable<SpanStatus> get_Status() { }

	[CompilerGenerated]
	// RVA: 0x41A200 Offset: 0x419400 VA: 0x18041A200
	public void set_Status(Nullable<SpanStatus> value) { }

	[CompilerGenerated]
	// RVA: 0x1C69510 Offset: 0x1C68710 VA: 0x181C69510 Slot: 10
	public Nullable<bool> get_IsSampled() { }

	[CompilerGenerated]
	// RVA: 0x1C804E0 Offset: 0x1C7F6E0 VA: 0x181C804E0
	internal void set_IsSampled(Nullable<bool> value) { }

	// RVA: 0x1C7F630 Offset: 0x1C7E830 VA: 0x181C7F630
	internal Trace Clone() { }

	// RVA: 0x1C7FDD0 Offset: 0x1C7EFD0 VA: 0x181C7FDD0 Slot: 12
	private Trace Sentry.Internal.ICloneable<Sentry.Protocol.Trace>.Clone() { }

	// RVA: 0x1C800A0 Offset: 0x1C7F2A0 VA: 0x181C800A0
	internal void UpdateFrom(Trace source) { }

	// RVA: 0x1C80000 Offset: 0x1C7F200 VA: 0x181C80000 Slot: 14
	private void Sentry.Internal.IUpdatable.UpdateFrom(object source) { }

	// RVA: 0x1C7FE80 Offset: 0x1C7F080 VA: 0x181C7FE80 Slot: 13
	private void Sentry.Internal.IUpdatable<Sentry.Protocol.Trace>.UpdateFrom(Trace source) { }

	// RVA: 0x1C800F0 Offset: 0x1C7F2F0 VA: 0x181C800F0 Slot: 11
	public void WriteTo(Utf8JsonWriter writer, IDiagnosticLogger logger) { }

	// RVA: 0x1C7F6E0 Offset: 0x1C7E8E0 VA: 0x181C7F6E0
	public static Trace FromJson(JsonElement json) { }

	// RVA: 0x1C804A0 Offset: 0x1C7F6A0 VA: 0x181C804A0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class AsyncJsonSerializable.<>c__3<T> // TypeDefIndex: 13541
{
	// Fields
	[Nullable(0)]
	public static readonly AsyncJsonSerializable.<>c__3<T> <>9; // 0x0
	[Nullable(new[] { 0, 0, 1, 0 })]
	public static Func<Task<T>, IJsonSerializable> <>9__3_0; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB08330 Offset: 0xB07530 VA: 0x180B08330
	|-AsyncJsonSerializable.<>c__3<object>..cctor
	|
	|-RVA: 0xB08640 Offset: 0xB07840 VA: 0x180B08640
	|-AsyncJsonSerializable.<>c__3<__Il2CppFullySharedGenericType>..cctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	|-AsyncJsonSerializable.<>c__3<object>..ctor
	|-AsyncJsonSerializable.<>c__3<__Il2CppFullySharedGenericType>..ctor
	*/

	[NullableContext(0)]
	// RVA: -1 Offset: -1
	internal IJsonSerializable <CreateFrom>b__3_0(Task<T> t) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB08AC0 Offset: 0xB07CC0 VA: 0x180B08AC0
	|-AsyncJsonSerializable.<>c__3<object>.<CreateFrom>b__3_0
	|
	|-RVA: 0xB08AF0 Offset: 0xB07CF0 VA: 0x180B08AF0
	|-AsyncJsonSerializable.<>c__3<__Il2CppFullySharedGenericType>.<CreateFrom>b__3_0
	*/
}

// Namespace: 
[CompilerGenerated]
private struct AsyncJsonSerializable.<SerializeAsync>d__5 : IAsyncStateMachine // TypeDefIndex: 13542
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	[Nullable(0)]
	public AsyncJsonSerializable <>4__this; // 0x20
	[Nullable(0)]
	public Stream stream; // 0x28
	[Nullable(0)]
	public IDiagnosticLogger logger; // 0x30
	public CancellationToken cancellationToken; // 0x38
	[Nullable(new[] { 0, 1 })]
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<IJsonSerializable> <>u__1; // 0x40
	private ConfiguredAsyncDisposable <>7__wrap1; // 0x50
	[Nullable(0)]
	private object <>7__wrap2; // 0x60
	private int <>7__wrap3; // 0x68
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2; // 0x70
	private ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter <>u__3; // 0x80

	// Methods

	// RVA: 0x1C85580 Offset: 0x1C84780 VA: 0x181C85580 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1C85AD0 Offset: 0x1C84CD0 VA: 0x181C85AD0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: Sentry.Protocol.Envelopes
[Nullable(0)]
[NullableContext(1)]
internal sealed class AsyncJsonSerializable : ISerializable // TypeDefIndex: 13543
{
	// Fields
	[CompilerGenerated]
	private readonly Task<IJsonSerializable> <Source>k__BackingField; // 0x10

	// Properties
	public Task<IJsonSerializable> Source { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Task<IJsonSerializable> get_Source() { }

	// RVA: -1 Offset: -1
	public static AsyncJsonSerializable CreateFrom<T>(Task<T> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x93BF60 Offset: 0x93B160 VA: 0x18093BF60
	|-AsyncJsonSerializable.CreateFrom<object>
	|
	|-RVA: 0x93BDB0 Offset: 0x93AFB0 VA: 0x18093BDB0
	|-AsyncJsonSerializable.CreateFrom<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	private void .ctor(Task<IJsonSerializable> source) { }

	[AsyncStateMachine(typeof(AsyncJsonSerializable.<SerializeAsync>d__5))]
	// RVA: 0x1C72600 Offset: 0x1C71800 VA: 0x181C72600 Slot: 4
	public Task SerializeAsync(Stream stream, IDiagnosticLogger logger, CancellationToken cancellationToken) { }

	// RVA: 0x1C72720 Offset: 0x1C71920 VA: 0x181C72720 Slot: 5
	public void Serialize(Stream stream, IDiagnosticLogger logger) { }
}

// Namespace: 
[CompilerGenerated]
private static class Envelope.<>O // TypeDefIndex: 13544
{
	// Fields
	[Nullable(0)]
	public static Func<JsonElement, Dictionary<string, object>> <0>__GetDictionaryOrNull; // 0x0
}

// Namespace: 
[CompilerGenerated]
private struct Envelope.<DeserializeAsync>d__28 : IAsyncStateMachine // TypeDefIndex: 13545
{
	// Fields
	public int <>1__state; // 0x0
	[Nullable(0)]
	public AsyncTaskMethodBuilder<Envelope> <>t__builder; // 0x8
	[Nullable(0)]
	public Stream stream; // 0x20
	public CancellationToken cancellationToken; // 0x28
	[Nullable(new[] { 0, 1, 2 })]
	private IReadOnlyDictionary<string, object> <header>5__2; // 0x30
	[Nullable(new[] { 0, 1 })]
	private List<EnvelopeItem> <items>5__3; // 0x38
	[Nullable(new[] { 0, 1, 1, 2 })]
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<IReadOnlyDictionary<string, object>> <>u__1; // 0x40
	[Nullable(new[] { 0, 1 })]
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<EnvelopeItem> <>u__2; // 0x50

	// Methods

	// RVA: 0x1C835E0 Offset: 0x1C827E0 VA: 0x181C835E0 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1C83C70 Offset: 0x1C82E70 VA: 0x181C83C70 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct Envelope.<DeserializeHeaderAsync>d__27 : IAsyncStateMachine // TypeDefIndex: 13546
{
	// Fields
	public int <>1__state; // 0x0
	[Nullable(new[] { 0, 0, 1, 2 })]
	public AsyncTaskMethodBuilder<IReadOnlyDictionary<string, object>> <>t__builder; // 0x8
	[Nullable(0)]
	public Stream stream; // 0x20
	public CancellationToken cancellationToken; // 0x28
	[Nullable(new[] { 0, 1 })]
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<byte[]> <>u__1; // 0x30

	// Methods

	// RVA: 0x1C84370 Offset: 0x1C83570 VA: 0x181C84370 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1C84690 Offset: 0x1C83890 VA: 0x181C84690 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct Envelope.<SerializeAsync>d__14 : IAsyncStateMachine // TypeDefIndex: 13547
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	[Nullable(0)]
	public Envelope <>4__this; // 0x20
	[Nullable(0)]
	public Stream stream; // 0x28
	[Nullable(0)]
	public IDiagnosticLogger logger; // 0x30
	[Nullable(0)]
	public ISystemClock clock; // 0x38
	public CancellationToken cancellationToken; // 0x40
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x48
	[Nullable(new[] { 0, 1 })]
	private IEnumerator<EnvelopeItem> <>7__wrap1; // 0x58

	// Methods

	// RVA: 0x1C84A60 Offset: 0x1C83C60 VA: 0x181C84A60 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1C85520 Offset: 0x1C84720 VA: 0x181C85520 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct Envelope.<SerializeHeaderAsync>d__11 : IAsyncStateMachine // TypeDefIndex: 13548
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	[Nullable(0)]
	public Stream stream; // 0x20
	[Nullable(0)]
	public Envelope <>4__this; // 0x28
	[Nullable(0)]
	public ISystemClock clock; // 0x30
	[Nullable(0)]
	public IDiagnosticLogger logger; // 0x38
	public CancellationToken cancellationToken; // 0x40
	[Nullable(0)]
	private Utf8JsonWriter <>7__wrap1; // 0x48
	[Nullable(0)]
	private object <>7__wrap2; // 0x50
	private int <>7__wrap3; // 0x58
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x60
	private ValueTaskAwaiter <>u__2; // 0x70

	// Methods

	// RVA: 0x1C85B30 Offset: 0x1C84D30 VA: 0x181C85B30 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1C86110 Offset: 0x1C85310 VA: 0x181C86110 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: Sentry.Protocol.Envelopes
[Nullable(0)]
[NullableContext(1)]
public sealed class Envelope : ISerializable, IDisposable // TypeDefIndex: 13549
{
	// Fields
	private Nullable<SentryId> _eventId; // 0x10
	[Nullable(new[] { 1, 1, 2 })]
	[CompilerGenerated]
	private readonly IReadOnlyDictionary<string, object> <Header>k__BackingField; // 0x28
	[CompilerGenerated]
	private readonly IReadOnlyList<EnvelopeItem> <Items>k__BackingField; // 0x30
	[Nullable(new[] { 1, 1, 2 })]
	private static readonly IReadOnlyDictionary<string, string> SdkHeader; // 0x0
	[Nullable(new[] { 1, 1, 2 })]
	private static readonly IReadOnlyDictionary<string, object> DefaultHeader; // 0x8

	// Properties
	[Nullable(new[] { 1, 1, 2 })]
	public IReadOnlyDictionary<string, object> Header { get; }
	public IReadOnlyList<EnvelopeItem> Items { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public IReadOnlyDictionary<string, object> get_Header() { }

	[CompilerGenerated]
	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public IReadOnlyList<EnvelopeItem> get_Items() { }

	// RVA: 0x1C79E40 Offset: 0x1C79040 VA: 0x181C79E40
	public void .ctor(IReadOnlyDictionary<string, object> header, IReadOnlyList<EnvelopeItem> items) { }

	// RVA: 0x1C79E90 Offset: 0x1C79090 VA: 0x181C79E90
	private void .ctor(Nullable<SentryId> eventId, IReadOnlyDictionary<string, object> header, IReadOnlyList<EnvelopeItem> items) { }

	// RVA: 0x1C796D0 Offset: 0x1C788D0 VA: 0x181C796D0
	public Nullable<SentryId> TryGetEventId() { }

	[NullableContext(2)]
	// RVA: 0x1C79760 Offset: 0x1C78960 VA: 0x181C79760
	internal Nullable<SentryId> TryGetEventId(IDiagnosticLogger logger) { }

	[AsyncStateMachine(typeof(Envelope.<SerializeHeaderAsync>d__11))]
	// RVA: 0x1C79060 Offset: 0x1C78260 VA: 0x181C79060
	private Task SerializeHeaderAsync(Stream stream, IDiagnosticLogger logger, ISystemClock clock, CancellationToken cancellationToken) { }

	// RVA: 0x1C79180 Offset: 0x1C78380 VA: 0x181C79180
	private void SerializeHeader(Stream stream, IDiagnosticLogger logger, ISystemClock clock) { }

	// RVA: 0x1C78DF0 Offset: 0x1C77FF0 VA: 0x181C78DF0 Slot: 4
	public Task SerializeAsync(Stream stream, IDiagnosticLogger logger, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(Envelope.<SerializeAsync>d__14))]
	// RVA: 0x1C78F50 Offset: 0x1C78150 VA: 0x181C78F50
	internal Task SerializeAsync(Stream stream, IDiagnosticLogger logger, ISystemClock clock, CancellationToken cancellationToken) { }

	// RVA: 0x1C79400 Offset: 0x1C78600 VA: 0x181C79400 Slot: 5
	public void Serialize(Stream stream, IDiagnosticLogger logger) { }

	// RVA: 0x1C79490 Offset: 0x1C78690 VA: 0x181C79490
	internal void Serialize(Stream stream, IDiagnosticLogger logger, ISystemClock clock) { }

	// RVA: 0x1C77A00 Offset: 0x1C76C00 VA: 0x181C77A00 Slot: 6
	public void Dispose() { }

	// RVA: 0x1C77670 Offset: 0x1C76870 VA: 0x181C77670
	private static Dictionary<string, object> CreateHeader(SentryId eventId, int extraCapacity = 0) { }

	[NullableContext(2)]
	// RVA: 0x1C77590 Offset: 0x1C76790 VA: 0x181C77590
	private static Dictionary<string, object> CreateHeader(SentryId eventId, DynamicSamplingContext dsc) { }

	// RVA: 0x1C77C50 Offset: 0x1C76E50 VA: 0x181C77C50
	public static Envelope FromEvent(SentryEvent event, IDiagnosticLogger logger, IReadOnlyCollection<Attachment> attachments, SessionUpdate sessionUpdate) { }

	// RVA: 0x1C78B20 Offset: 0x1C77D20 VA: 0x181C78B20
	public static Envelope FromUserFeedback(UserFeedback sentryUserFeedback) { }

	// RVA: 0x1C78510 Offset: 0x1C77710 VA: 0x181C78510
	public static Envelope FromTransaction(Transaction transaction) { }

	// RVA: 0x1C78420 Offset: 0x1C77620 VA: 0x181C78420
	public static Envelope FromSession(SessionUpdate sessionUpdate) { }

	// RVA: 0x1C77A10 Offset: 0x1C76C10 VA: 0x181C77A10
	internal static Envelope FromClientReport(ClientReport clientReport) { }

	[AsyncStateMachine(typeof(Envelope.<DeserializeHeaderAsync>d__27))]
	// RVA: 0x1C77910 Offset: 0x1C76B10 VA: 0x181C77910
	private static Task<IReadOnlyDictionary<string, object>> DeserializeHeaderAsync(Stream stream, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(Envelope.<DeserializeAsync>d__28))]
	// RVA: 0x1C77810 Offset: 0x1C76A10 VA: 0x181C77810
	public static Task<Envelope> DeserializeAsync(Stream stream, CancellationToken cancellationToken) { }

	// RVA: 0x1C79A80 Offset: 0x1C78C80 VA: 0x181C79A80
	internal Envelope WithItem(EnvelopeItem item) { }

	// RVA: 0x1C79BA0 Offset: 0x1C78DA0 VA: 0x181C79BA0
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
private static class EnvelopeItem.<>O // TypeDefIndex: 13550
{
	// Fields
	[Nullable(0)]
	public static Func<JsonElement, Dictionary<string, object>> <0>__GetDictionaryOrNull; // 0x0
	[Nullable(0)]
	public static Func<JsonElement, SentryEvent> <1>__FromJson; // 0x8
	[Nullable(0)]
	public static Func<JsonElement, UserFeedback> <2>__FromJson; // 0x10
	[Nullable(0)]
	public static Func<JsonElement, Transaction> <3>__FromJson; // 0x18
	[Nullable(0)]
	public static Func<JsonElement, SessionUpdate> <4>__FromJson; // 0x20
	[Nullable(0)]
	public static Func<JsonElement, ClientReport> <5>__FromJson; // 0x28
}

// Namespace: 
[CompilerGenerated]
private struct EnvelopeItem.<BufferPayloadAsync>d__22 : IAsyncStateMachine // TypeDefIndex: 13551
{
	// Fields
	public int <>1__state; // 0x0
	[Nullable(0)]
	public AsyncTaskMethodBuilder<MemoryStream> <>t__builder; // 0x8
	[Nullable(0)]
	public EnvelopeItem <>4__this; // 0x20
	[Nullable(0)]
	public IDiagnosticLogger logger; // 0x28
	public CancellationToken cancellationToken; // 0x30
	[Nullable(0)]
	private MemoryStream <buffer>5__2; // 0x38
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x40

	// Methods

	// RVA: 0x1C83280 Offset: 0x1C82480 VA: 0x181C83280 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1C83570 Offset: 0x1C82770 VA: 0x181C83570 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct EnvelopeItem.<DeserializeAsync>d__39 : IAsyncStateMachine // TypeDefIndex: 13552
{
	// Fields
	public int <>1__state; // 0x0
	[Nullable(0)]
	public AsyncTaskMethodBuilder<EnvelopeItem> <>t__builder; // 0x8
	[Nullable(0)]
	public Stream stream; // 0x20
	public CancellationToken cancellationToken; // 0x28
	[Nullable(new[] { 0, 1, 2 })]
	private Dictionary<string, object> <header>5__2; // 0x30
	[Nullable(0)]
	private ISerializable <payload>5__3; // 0x38
	[Nullable(new[] { 0, 1, 1, 2 })]
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Dictionary<string, object>> <>u__1; // 0x40
	[Nullable(new[] { 0, 1 })]
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ISerializable> <>u__2; // 0x50
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__3; // 0x60

	// Methods

	// RVA: 0x1C83CE0 Offset: 0x1C82EE0 VA: 0x181C83CE0 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1C84300 Offset: 0x1C83500 VA: 0x181C84300 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct EnvelopeItem.<DeserializeHeaderAsync>d__37 : IAsyncStateMachine // TypeDefIndex: 13553
{
	// Fields
	public int <>1__state; // 0x0
	[Nullable(new[] { 0, 0, 1, 2 })]
	public AsyncTaskMethodBuilder<Dictionary<string, object>> <>t__builder; // 0x8
	[Nullable(0)]
	public Stream stream; // 0x20
	public CancellationToken cancellationToken; // 0x28
	[Nullable(new[] { 0, 1 })]
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<byte[]> <>u__1; // 0x30

	// Methods

	// RVA: 0x1C84700 Offset: 0x1C83900 VA: 0x181C84700 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1C849F0 Offset: 0x1C83BF0 VA: 0x181C849F0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct EnvelopeItem.<DeserializePayloadAsync>d__38 : IAsyncStateMachine // TypeDefIndex: 13554
{
	// Fields
	public int <>1__state; // 0x0
	[Nullable(0)]
	public AsyncTaskMethodBuilder<ISerializable> <>t__builder; // 0x8
	[Nullable(new[] { 0, 1, 2 })]
	public IReadOnlyDictionary<string, object> header; // 0x20
	[Nullable(0)]
	public Stream stream; // 0x28
	public CancellationToken cancellationToken; // 0x30
	[Nullable(new[] { 0, 1 })]
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<byte[]> <>u__1; // 0x38

	// Methods

	// RVA: 0x1C9A7D0 Offset: 0x1C999D0 VA: 0x181C9A7D0 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1C9B590 Offset: 0x1C9A790 VA: 0x181C9B590 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct EnvelopeItem.<SerializeAsync>d__26 : IAsyncStateMachine // TypeDefIndex: 13555
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	[Nullable(0)]
	public EnvelopeItem <>4__this; // 0x20
	[Nullable(0)]
	public IDiagnosticLogger logger; // 0x28
	public CancellationToken cancellationToken; // 0x30
	[Nullable(0)]
	public Stream stream; // 0x38
	[Nullable(0)]
	private MemoryStream <payloadBuffer>5__2; // 0x40
	[Nullable(new[] { 0, 1 })]
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<MemoryStream> <>u__1; // 0x48
	[Nullable(0)]
	private MemoryStream <>7__wrap2; // 0x58
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2; // 0x60

	// Methods

	// RVA: 0x1C9E9C0 Offset: 0x1C9DBC0 VA: 0x181C9E9C0 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1C9F1E0 Offset: 0x1C9E3E0 VA: 0x181C9F1E0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct EnvelopeItem.<SerializeHeaderAsync>d__24 : IAsyncStateMachine // TypeDefIndex: 13556
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	[Nullable(0)]
	public Stream stream; // 0x20
	[Nullable(new[] { 0, 1, 2 })]
	public IReadOnlyDictionary<string, object> header; // 0x28
	[Nullable(0)]
	public IDiagnosticLogger logger; // 0x30
	public CancellationToken cancellationToken; // 0x38
	private ConfiguredAsyncDisposable <>7__wrap1; // 0x40
	[Nullable(0)]
	private object <>7__wrap2; // 0x50
	private int <>7__wrap3; // 0x58
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x60
	private ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter <>u__2; // 0x70

	// Methods

	// RVA: 0x1C9F650 Offset: 0x1C9E850 VA: 0x181C9F650 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1C9F9F0 Offset: 0x1C9EBF0 VA: 0x181C9F9F0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: Sentry.Protocol.Envelopes
[NullableContext(1)]
[Nullable(0)]
public sealed class EnvelopeItem : ISerializable, IDisposable // TypeDefIndex: 13557
{
	// Fields
	private const string TypeKey = "type";
	private const string TypeValueEvent = "event";
	private const string TypeValueUserReport = "user_report";
	private const string TypeValueTransaction = "transaction";
	private const string TypeValueSession = "session";
	private const string TypeValueAttachment = "attachment";
	private const string TypeValueClientReport = "client_report";
	private const string TypeValueProfile = "profile";
	private const string LengthKey = "length";
	private const string FileNameKey = "filename";
	[CompilerGenerated]
	[Nullable(new[] { 1, 1, 2 })]
	private readonly IReadOnlyDictionary<string, object> <Header>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly ISerializable <Payload>k__BackingField; // 0x18

	// Properties
	[Nullable(new[] { 1, 1, 2 })]
	public IReadOnlyDictionary<string, object> Header { get; }
	public ISerializable Payload { get; }
	internal DataCategory DataCategory { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public IReadOnlyDictionary<string, object> get_Header() { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public ISerializable get_Payload() { }

	// RVA: 0x1C77320 Offset: 0x1C76520 VA: 0x181C77320
	internal DataCategory get_DataCategory() { }

	// RVA: 0x441CC0 Offset: 0x440EC0 VA: 0x180441CC0
	public void .ctor(IReadOnlyDictionary<string, object> header, ISerializable payload) { }

	[NullableContext(2)]
	// RVA: 0x1C77280 Offset: 0x1C76480 VA: 0x181C77280
	public string TryGetType() { }

	// RVA: 0x1C77180 Offset: 0x1C76380 VA: 0x181C77180
	public Nullable<long> TryGetLength() { }

	[NullableContext(2)]
	// RVA: 0x1C770E0 Offset: 0x1C762E0 VA: 0x181C770E0
	public string TryGetFileName() { }

	[AsyncStateMachine(typeof(EnvelopeItem.<BufferPayloadAsync>d__22))]
	// RVA: 0x1C75880 Offset: 0x1C74A80 VA: 0x181C75880
	private Task<MemoryStream> BufferPayloadAsync(IDiagnosticLogger logger, CancellationToken cancellationToken) { }

	// RVA: 0x1C75980 Offset: 0x1C74B80 VA: 0x181C75980
	private MemoryStream BufferPayload(IDiagnosticLogger logger) { }

	[AsyncStateMachine(typeof(EnvelopeItem.<SerializeHeaderAsync>d__24))]
	// RVA: 0x1C76BE0 Offset: 0x1C75DE0 VA: 0x181C76BE0
	private static Task SerializeHeaderAsync(Stream stream, IReadOnlyDictionary<string, object> header, IDiagnosticLogger logger, CancellationToken cancellationToken) { }

	// RVA: 0x1C76CF0 Offset: 0x1C75EF0 VA: 0x181C76CF0
	private static void SerializeHeader(Stream stream, IReadOnlyDictionary<string, object> header, IDiagnosticLogger logger) { }

	[AsyncStateMachine(typeof(EnvelopeItem.<SerializeAsync>d__26))]
	// RVA: 0x1C76AD0 Offset: 0x1C75CD0 VA: 0x181C76AD0 Slot: 4
	public Task SerializeAsync(Stream stream, IDiagnosticLogger logger, CancellationToken cancellationToken) { }

	// RVA: 0x1C76E30 Offset: 0x1C76030 VA: 0x181C76E30 Slot: 5
	public void Serialize(Stream stream, IDiagnosticLogger logger) { }

	// RVA: 0x1C75DA0 Offset: 0x1C74FA0 VA: 0x181C75DA0 Slot: 6
	public void Dispose() { }

	// RVA: 0x1C76320 Offset: 0x1C75520 VA: 0x181C76320
	public static EnvelopeItem FromEvent(SentryEvent event) { }

	// RVA: 0x1C76940 Offset: 0x1C75B40 VA: 0x181C76940
	public static EnvelopeItem FromUserFeedback(UserFeedback sentryUserFeedback) { }

	// RVA: 0x1C767B0 Offset: 0x1C759B0 VA: 0x181C767B0
	public static EnvelopeItem FromTransaction(Transaction transaction) { }

	// RVA: 0x1C764B0 Offset: 0x1C756B0 VA: 0x181C764B0
	internal static EnvelopeItem FromProfileInfo(Task<ProfileInfo> source) { }

	// RVA: 0x1C76620 Offset: 0x1C75820 VA: 0x181C76620
	public static EnvelopeItem FromSession(SessionUpdate sessionUpdate) { }

	// RVA: 0x1C76130 Offset: 0x1C75330 VA: 0x181C76130
	public static EnvelopeItem FromAttachment(Attachment attachment) { }

	// RVA: 0x1C75E00 Offset: 0x1C75000 VA: 0x181C75E00
	internal static EnvelopeItem FromAttachment(Attachment attachment, Stream stream) { }

	// RVA: 0x1C76190 Offset: 0x1C75390 VA: 0x181C76190
	internal static EnvelopeItem FromClientReport(ClientReport report) { }

	[AsyncStateMachine(typeof(EnvelopeItem.<DeserializeHeaderAsync>d__37))]
	// RVA: 0x1C75BB0 Offset: 0x1C74DB0 VA: 0x181C75BB0
	private static Task<Dictionary<string, object>> DeserializeHeaderAsync(Stream stream, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(EnvelopeItem.<DeserializePayloadAsync>d__38))]
	// RVA: 0x1C75CA0 Offset: 0x1C74EA0 VA: 0x181C75CA0
	private static Task<ISerializable> DeserializePayloadAsync(Stream stream, IReadOnlyDictionary<string, object> header, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(EnvelopeItem.<DeserializeAsync>d__39))]
	// RVA: 0x1C75AA0 Offset: 0x1C74CA0 VA: 0x181C75AA0
	public static Task<EnvelopeItem> DeserializeAsync(Stream stream, CancellationToken cancellationToken) { }
}

// Namespace: Sentry.Protocol.Envelopes
[NullableContext(1)]
public interface ISerializable // TypeDefIndex: 13558
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Task SerializeAsync(Stream stream, IDiagnosticLogger logger, CancellationToken cancellationToken);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Serialize(Stream stream, IDiagnosticLogger logger);
}

// Namespace: 
[CompilerGenerated]
private struct JsonSerializable.<SerializeAsync>d__4 : IAsyncStateMachine // TypeDefIndex: 13559
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	[Nullable(0)]
	public Stream stream; // 0x20
	[Nullable(0)]
	public JsonSerializable <>4__this; // 0x28
	[Nullable(0)]
	public IDiagnosticLogger logger; // 0x30
	public CancellationToken cancellationToken; // 0x38
	private ConfiguredAsyncDisposable <>7__wrap1; // 0x40
	[Nullable(0)]
	private object <>7__wrap2; // 0x50
	private int <>7__wrap3; // 0x58
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x60
	private ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter <>u__2; // 0x70

	// Methods

	// RVA: 0x1C9F240 Offset: 0x1C9E440 VA: 0x181C9F240 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1C9F5F0 Offset: 0x1C9E7F0 VA: 0x181C9F5F0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: Sentry.Protocol.Envelopes
[NullableContext(1)]
[Nullable(0)]
internal sealed class JsonSerializable : ISerializable // TypeDefIndex: 13560
{
	// Fields
	[CompilerGenerated]
	private readonly IJsonSerializable <Source>k__BackingField; // 0x10

	// Properties
	public IJsonSerializable Source { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public IJsonSerializable get_Source() { }

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	public void .ctor(IJsonSerializable source) { }

	[AsyncStateMachine(typeof(JsonSerializable.<SerializeAsync>d__4))]
	// RVA: 0x1C91B40 Offset: 0x1C90D40 VA: 0x181C91B40 Slot: 4
	public Task SerializeAsync(Stream stream, IDiagnosticLogger logger, CancellationToken cancellationToken) { }

	// RVA: 0x1C91C50 Offset: 0x1C90E50 VA: 0x181C91C50 Slot: 5
	public void Serialize(Stream stream, IDiagnosticLogger logger) { }
}

// Namespace: Sentry.Protocol.Envelopes
[NullableContext(1)]
[Nullable(0)]
internal sealed class StreamSerializable : ISerializable, IDisposable // TypeDefIndex: 13561
{
	// Fields
	[CompilerGenerated]
	private readonly Stream <Source>k__BackingField; // 0x10

	// Properties
	public Stream Source { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Stream get_Source() { }

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	public void .ctor(Stream source) { }

	// RVA: 0x1C99720 Offset: 0x1C98920 VA: 0x181C99720 Slot: 4
	public Task SerializeAsync(Stream stream, IDiagnosticLogger logger, CancellationToken cancellationToken) { }

	// RVA: 0x1C99790 Offset: 0x1C98990 VA: 0x181C99790 Slot: 5
	public void Serialize(Stream stream, IDiagnosticLogger logger) { }

	// RVA: 0x1C99700 Offset: 0x1C98900 VA: 0x181C99700 Slot: 6
	public void Dispose() { }
}

// Namespace: Sentry.PlatformAbstractions
internal static class DeviceInfo // TypeDefIndex: 13562
{}

// Namespace: Sentry.PlatformAbstractions
[Nullable(0)]
[NullableContext(1)]
public static class FrameworkInfo // TypeDefIndex: 13563
{
	// Fields
	[CompilerGenerated]
	private static readonly IReadOnlyDictionary<int, string> <NetFxReleaseVersionMap>k__BackingField; // 0x0

	// Properties
	public static IReadOnlyDictionary<int, string> NetFxReleaseVersionMap { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1C8DE40 Offset: 0x1C8D040 VA: 0x181C8DE40
	public static IReadOnlyDictionary<int, string> get_NetFxReleaseVersionMap() { }

	[NullableContext(2)]
	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0
	public static FrameworkInstallation GetLatest(int clr) { }

	// RVA: 0x1C8DA20 Offset: 0x1C8CC20 VA: 0x181C8DA20
	public static IEnumerable<FrameworkInstallation> GetInstallations() { }

	// RVA: 0x1C8DAC0 Offset: 0x1C8CCC0 VA: 0x181C8DAC0
	private static void .cctor() { }
}

// Namespace: Sentry.PlatformAbstractions
[Nullable(0)]
[NullableContext(2)]
public class FrameworkInstallation // TypeDefIndex: 13564
{
	// Fields
	[CompilerGenerated]
	private string <ShortName>k__BackingField; // 0x10
	[CompilerGenerated]
	private Version <Version>k__BackingField; // 0x18
	[CompilerGenerated]
	private Nullable<int> <ServicePack>k__BackingField; // 0x20
	[CompilerGenerated]
	private Nullable<FrameworkProfile> <Profile>k__BackingField; // 0x28
	[CompilerGenerated]
	private Nullable<int> <Release>k__BackingField; // 0x30

	// Properties
	public string ShortName { get; set; }
	public Version Version { get; set; }
	public Nullable<int> ServicePack { get; set; }
	public Nullable<FrameworkProfile> Profile { get; set; }
	public Nullable<int> Release { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_ShortName() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_ShortName(string value) { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public Version get_Version() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_Version(Version value) { }

	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public Nullable<int> get_ServicePack() { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_ServicePack(Nullable<int> value) { }

	[CompilerGenerated]
	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public Nullable<FrameworkProfile> get_Profile() { }

	[CompilerGenerated]
	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	public void set_Profile(Nullable<FrameworkProfile> value) { }

	[CompilerGenerated]
	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public Nullable<int> get_Release() { }

	[CompilerGenerated]
	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	public void set_Release(Nullable<int> value) { }

	[NullableContext(1)]
	// RVA: 0x1C8DF10 Offset: 0x1C8D110 VA: 0x181C8DF10 Slot: 3
	public override string ToString() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: Sentry.PlatformAbstractions
public enum FrameworkProfile // TypeDefIndex: 13565
{
	// Fields
	public int value__; // 0x0
	public const FrameworkProfile Client = 0;
	public const FrameworkProfile Full = 1;
}

// Namespace: Sentry.PlatformAbstractions
[Extension]
internal static class FrameworkInstallationExtensions // TypeDefIndex: 13566
{
	// Methods

	[NullableContext(2)]
	[Extension]
	// RVA: 0x1C8DE90 Offset: 0x1C8D090 VA: 0x181C8DE90
	internal static string GetVersionNumber(FrameworkInstallation frameworkInstall) { }
}

// Namespace: Sentry.PlatformAbstractions
[NullableContext(2)]
[Nullable(0)]
public class Runtime : IEquatable<Runtime> // TypeDefIndex: 13567
{
	// Fields
	[Nullable(1)]
	private static Lazy<Runtime> _currentRuntime; // 0x0
	[CompilerGenerated]
	private readonly string <Name>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly string <Version>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly string <Raw>k__BackingField; // 0x20
	private readonly string _identifier; // 0x28

	// Properties
	[Nullable(1)]
	public static Runtime Current { get; }
	public string Name { get; }
	public string Version { get; }
	public string Raw { get; }
	public string Identifier { get; set; }

	// Methods

	[NullableContext(1)]
	// RVA: 0x1C97530 Offset: 0x1C96730 VA: 0x181C97530
	public static Runtime get_Current() { }

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_Version() { }

	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public string get_Raw() { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public string get_Identifier() { }

	[Obsolete("This setter is nonfunctional, and will be removed in a future version.")]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	public void set_Identifier(string value) { }

	// RVA: 0x1808FD0 Offset: 0x18081D0 VA: 0x181808FD0
	public void .ctor(string name, string version, string raw, string identifier) { }

	// RVA: 0x1C973E0 Offset: 0x1C965E0 VA: 0x181C973E0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1C97270 Offset: 0x1C96470 VA: 0x181C97270 Slot: 4
	public bool Equals(Runtime other) { }

	// RVA: 0x1C97100 Offset: 0x1C96300 VA: 0x181C97100 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1C97300 Offset: 0x1C96500 VA: 0x181C97300 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1C97470 Offset: 0x1C96670 VA: 0x181C97470
	private static void .cctor() { }
}

// Namespace: Sentry.PlatformAbstractions
[EditorBrowsable(1)]
[Extension]
[Nullable(0)]
[NullableContext(1)]
public static class RuntimeExtensions // TypeDefIndex: 13568
{
	// Methods

	[Extension]
	// RVA: 0x1C96330 Offset: 0x1C95530 VA: 0x181C96330
	public static bool IsNetFx(Runtime runtime) { }

	[Extension]
	// RVA: 0x1C96290 Offset: 0x1C95490 VA: 0x181C96290
	public static bool IsNetCore(Runtime runtime) { }

	[Extension]
	// RVA: 0x1C96250 Offset: 0x1C95450 VA: 0x181C96250
	public static bool IsMono(Runtime runtime) { }

	[Extension]
	// RVA: 0x1C96200 Offset: 0x1C95400 VA: 0x181C96200
	internal static bool IsBrowserWasm(Runtime runtime) { }

	[Extension]
	// RVA: 0x1C96370 Offset: 0x1C95570 VA: 0x181C96370
	private static bool StartsWith(Runtime runtime, string runtimeName) { }
}

// Namespace: Sentry.PlatformAbstractions
[Extension]
[NullableContext(1)]
[Nullable(0)]
internal static class RuntimeInfo // TypeDefIndex: 13569
{
	// Fields
	private static readonly Regex RuntimeParseRegex; // 0x0

	// Methods

	// RVA: 0x1C96960 Offset: 0x1C95B60 VA: 0x181C96960
	internal static Runtime GetRuntime() { }

	[Extension]
	// RVA: 0x1C96FB0 Offset: 0x1C961B0 VA: 0x181C96FB0
	internal static Runtime WithAdditionalProperties(Runtime runtime) { }

	[NullableContext(2)]
	// RVA: 0x1C96CB0 Offset: 0x1C95EB0 VA: 0x181C96CB0
	internal static Runtime Parse(string rawRuntimeDescription, string name) { }

	// RVA: 0x1C96770 Offset: 0x1C95970 VA: 0x181C96770
	private static string GetNetCoreVersion(Runtime runtime) { }

	[NullableContext(2)]
	// RVA: 0x1C966F0 Offset: 0x1C958F0 VA: 0x181C966F0
	private static Runtime GetFromRuntimeInformation() { }

	[NullableContext(2)]
	// RVA: 0x1C965B0 Offset: 0x1C957B0 VA: 0x181C965B0
	private static Runtime GetFromMonoRuntime() { }

	// RVA: 0x1C96490 Offset: 0x1C95690 VA: 0x181C96490
	private static Runtime GetFromEnvironmentVariable() { }

	// RVA: 0x1C97080 Offset: 0x1C96280 VA: 0x181C97080
	private static void .cctor() { }
}

// Namespace: Sentry.Internal
[NullableContext(1)]
internal interface IAppDomain // TypeDefIndex: 13570
{
	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 0
	public abstract void add_UnhandledException(UnhandledExceptionEventHandler value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 1
	public abstract void remove_UnhandledException(UnhandledExceptionEventHandler value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 2
	public abstract void add_ProcessExit(EventHandler value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 3
	public abstract void remove_ProcessExit(EventHandler value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 4
	public abstract void add_UnobservedTaskException(EventHandler<UnobservedTaskExceptionEventArgs> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 5
	public abstract void remove_UnobservedTaskException(EventHandler<UnobservedTaskExceptionEventArgs> value);
}

// Namespace: Sentry.Internal
[Nullable(0)]
[NullableContext(1)]
internal sealed class AppDomainAdapter : IAppDomain // TypeDefIndex: 13571
{
	// Fields
	[CompilerGenerated]
	private static readonly AppDomainAdapter <Instance>k__BackingField; // 0x0
	[Nullable(2)]
	[CompilerGenerated]
	private UnhandledExceptionEventHandler UnhandledException; // 0x10
	[CompilerGenerated]
	[Nullable(2)]
	private EventHandler ProcessExit; // 0x18
	[Nullable(new[] { 2, 1 })]
	[CompilerGenerated]
	private EventHandler<UnobservedTaskExceptionEventArgs> UnobservedTaskException; // 0x20

	// Properties
	public static AppDomainAdapter Instance { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1C88230 Offset: 0x1C87430 VA: 0x181C88230
	public static AppDomainAdapter get_Instance() { }

	// RVA: 0x1C87EE0 Offset: 0x1C870E0 VA: 0x181C87EE0
	private void .ctor() { }

	[NullableContext(2)]
	[CompilerGenerated]
	// RVA: 0x1C880E0 Offset: 0x1C872E0 VA: 0x181C880E0 Slot: 4
	public void add_UnhandledException(UnhandledExceptionEventHandler value) { }

	[NullableContext(2)]
	[CompilerGenerated]
	// RVA: 0x1C88320 Offset: 0x1C87520 VA: 0x181C88320 Slot: 5
	public void remove_UnhandledException(UnhandledExceptionEventHandler value) { }

	[CompilerGenerated]
	[NullableContext(2)]
	// RVA: 0x1C88040 Offset: 0x1C87240 VA: 0x181C88040 Slot: 6
	public void add_ProcessExit(EventHandler value) { }

	[NullableContext(2)]
	[CompilerGenerated]
	// RVA: 0x1C88280 Offset: 0x1C87480 VA: 0x181C88280 Slot: 7
	public void remove_ProcessExit(EventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x1C88180 Offset: 0x1C87380 VA: 0x181C88180 Slot: 8
	public void add_UnobservedTaskException(EventHandler<UnobservedTaskExceptionEventArgs> value) { }

	[CompilerGenerated]
	// RVA: 0x1C883C0 Offset: 0x1C875C0 VA: 0x181C883C0 Slot: 9
	public void remove_UnobservedTaskException(EventHandler<UnobservedTaskExceptionEventArgs> value) { }

	// RVA: 0x1C87CE0 Offset: 0x1C86EE0 VA: 0x181C87CE0
	private void OnProcessExit(object sender, EventArgs e) { }

	[HandleProcessCorruptedStateExceptions]
	// RVA: 0x1C87D00 Offset: 0x1C86F00 VA: 0x181C87D00
	private void OnUnhandledException(object sender, UnhandledExceptionEventArgs e) { }

	[HandleProcessCorruptedStateExceptions]
	// RVA: 0x1C87D20 Offset: 0x1C86F20 VA: 0x181C87D20
	private void OnUnobservedTaskException(object sender, UnobservedTaskExceptionEventArgs e) { }

	// RVA: 0x1C87D40 Offset: 0x1C86F40 VA: 0x181C87D40
	private static void .cctor() { }
}

// Namespace: Sentry.Internal
internal static class ApplicationVersionLocator // TypeDefIndex: 13572
{
	// Methods

	[NullableContext(2)]
	// RVA: 0x1C88470 Offset: 0x1C87670 VA: 0x181C88470
	internal static string GetCurrent(Assembly asm) { }
}

// Namespace: Sentry.Internal
[Nullable(0)]
[DefaultMember("Item")]
[NullableContext(1)]
internal class AutoClearingList<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable // TypeDefIndex: 13573
{
	// Fields
	private readonly IList<T> _list; // 0x0
	private bool _clearOnNextAdd; // 0x0

	// Properties
	public int Count { get; }
	public bool IsReadOnly { get; }
	public T Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IEnumerable<T> initialItems, bool clearOnNextAdd) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE97C70 Offset: 0xE96E70 VA: 0x180E97C70
	|-AutoClearingList<object>..ctor
	|
	|-RVA: 0xE97C10 Offset: 0xE96E10 VA: 0x180E97C10
	|-AutoClearingList<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE97040 Offset: 0xE96240 VA: 0x180E97040
	|-AutoClearingList<object>.Add
	|
	|-RVA: 0xE97170 Offset: 0xE96370 VA: 0x180E97170
	|-AutoClearingList<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public IEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD12140 Offset: 0xD11340 VA: 0x180D12140
	|-AutoClearingList<object>.GetEnumerator
	|-AutoClearingList<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE97B70 Offset: 0xE96D70 VA: 0x180E97B70
	|-AutoClearingList<object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xE97BC0 Offset: 0xE96DC0 VA: 0x180E97BC0
	|-AutoClearingList<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE97300 Offset: 0xE96500 VA: 0x180E97300
	|-AutoClearingList<object>.Clear
	|-AutoClearingList<__Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE97350 Offset: 0xE96550 VA: 0x180E97350
	|-AutoClearingList<object>.Contains
	|
	|-RVA: 0xE973B0 Offset: 0xE965B0 VA: 0x180E973B0
	|-AutoClearingList<__Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public void CopyTo(T[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE974A0 Offset: 0xE966A0 VA: 0x180E974A0
	|-AutoClearingList<object>.CopyTo
	|-AutoClearingList<__Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public bool Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE97B10 Offset: 0xE96D10 VA: 0x180E97B10
	|-AutoClearingList<object>.Remove
	|
	|-RVA: 0xE97A20 Offset: 0xE96C20 VA: 0x180E97A20
	|-AutoClearingList<__Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF7DD0 Offset: 0xCF6FD0 VA: 0x180CF7DD0
	|-AutoClearingList<object>.get_Count
	|-AutoClearingList<__Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public bool get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE97CD0 Offset: 0xE96ED0 VA: 0x180E97CD0
	|-AutoClearingList<object>.get_IsReadOnly
	|-AutoClearingList<__Il2CppFullySharedGenericType>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public int IndexOf(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE97570 Offset: 0xE96770 VA: 0x180E97570
	|-AutoClearingList<object>.IndexOf
	|
	|-RVA: 0xE97640 Offset: 0xE96840 VA: 0x180E97640
	|-AutoClearingList<__Il2CppFullySharedGenericType>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void Insert(int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE978E0 Offset: 0xE96AE0 VA: 0x180E978E0
	|-AutoClearingList<object>.Insert
	|
	|-RVA: 0xE977B0 Offset: 0xE969B0 VA: 0x180E977B0
	|-AutoClearingList<__Il2CppFullySharedGenericType>.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE979C0 Offset: 0xE96BC0 VA: 0x180E979C0
	|-AutoClearingList<object>.RemoveAt
	|-AutoClearingList<__Il2CppFullySharedGenericType>.RemoveAt
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE97D20 Offset: 0xE96F20 VA: 0x180E97D20
	|-AutoClearingList<object>.get_Item
	|
	|-RVA: 0xE97DE0 Offset: 0xE96FE0 VA: 0x180E97DE0
	|-AutoClearingList<__Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE98020 Offset: 0xE97220 VA: 0x180E98020
	|-AutoClearingList<object>.set_Item
	|
	|-RVA: 0xE97F20 Offset: 0xE97120 VA: 0x180E97F20
	|-AutoClearingList<__Il2CppFullySharedGenericType>.set_Item
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class BackgroundWorker.<>c__DisplayClass22_0 // TypeDefIndex: 13574
{
	// Fields
	[Nullable(0)]
	public TaskCompletionSource<bool> completionSource; // 0x10
	public int counter; // 0x18
	public int depth; // 0x1C
	[Nullable(0)]
	public BackgroundWorker <>4__this; // 0x20

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1CA0B20 Offset: 0x1C9FD20 VA: 0x181CA0B20
	internal void <DoFlushAsync>b__0() { }

	// RVA: 0x1CA0B70 Offset: 0x1C9FD70 VA: 0x181CA0B70
	internal void <DoFlushAsync>g__EventFlushedCallback|1(object _, EventArgs __) { }
}

// Namespace: 
[CompilerGenerated]
private struct BackgroundWorker.<DoFlushAsync>d__22 : IAsyncStateMachine // TypeDefIndex: 13575
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	[Nullable(0)]
	public BackgroundWorker <>4__this; // 0x20
	public CancellationToken cancellationToken; // 0x28
	[Nullable(0)]
	private BackgroundWorker.<>c__DisplayClass22_0 <>8__1; // 0x30
	[Nullable(0)]
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool> <>u__1; // 0x38
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2; // 0x48

	// Methods

	// RVA: 0x1C9B600 Offset: 0x1C9A800 VA: 0x181C9B600 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1C9BEF0 Offset: 0x1C9B0F0 VA: 0x181C9BEF0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct BackgroundWorker.<DoWorkAsync>d__20 : IAsyncStateMachine // TypeDefIndex: 13576
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	[Nullable(0)]
	public BackgroundWorker <>4__this; // 0x20
	[Nullable(0)]
	private CancellationTokenSource <shutdownTimeout>5__2; // 0x28
	private bool <shutdownRequested>5__3; // 0x30
	[Nullable(0)]
	private Envelope <envelope>5__4; // 0x38
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x40
	private Nullable<SentryId> <eventId>5__5; // 0x50
	[Nullable(0)]
	private Envelope <_>5__6; // 0x68

	// Methods

	// RVA: 0x1C9BF50 Offset: 0x1C9B150 VA: 0x181C9BF50 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1C9CEA0 Offset: 0x1C9C0A0 VA: 0x181C9CEA0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct BackgroundWorker.<FlushAsync>d__21 : IAsyncStateMachine // TypeDefIndex: 13577
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	[Nullable(0)]
	public BackgroundWorker <>4__this; // 0x20
	public TimeSpan timeout; // 0x28
	[Nullable(0)]
	private CancellationTokenSource <timeoutSource>5__2; // 0x30
	[Nullable(0)]
	private CancellationTokenSource <timeoutWithShutdown>5__3; // 0x38
	[Nullable(0)]
	private object <>7__wrap3; // 0x40
	private int <>7__wrap4; // 0x48
	[Nullable(0)]
	private Stopwatch <stopwatch>5__6; // 0x50
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x58

	// Methods

	// RVA: 0x1C9CF00 Offset: 0x1C9C100 VA: 0x181C9CF00 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1C9DB70 Offset: 0x1C9CD70 VA: 0x181C9DB70 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct BackgroundWorker.<SendFinalClientReportAsync>d__23 : IAsyncStateMachine // TypeDefIndex: 13578
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	[Nullable(0)]
	public BackgroundWorker <>4__this; // 0x20
	public CancellationToken cancellationToken; // 0x28
	[Nullable(0)]
	private Envelope <envelope>5__2; // 0x30
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x38

	// Methods

	// RVA: 0x1C9E410 Offset: 0x1C9D610 VA: 0x181C9E410 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1C9E960 Offset: 0x1C9DB60 VA: 0x181C9E960 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: Sentry.Internal
[NullableContext(1)]
[Nullable(0)]
internal class BackgroundWorker : IBackgroundWorker, IDisposable // TypeDefIndex: 13579
{
	// Fields
	private readonly ITransport _transport; // 0x10
	private readonly SentryOptions _options; // 0x18
	private readonly ConcurrentQueue<Envelope> _queue; // 0x20
	private readonly int _maxItems; // 0x28
	private readonly CancellationTokenSource _shutdownSource; // 0x30
	private readonly SemaphoreSlim _queuedEnvelopeSemaphore; // 0x38
	private bool _disposed; // 0x40
	private int _currentItems; // 0x44
	[CompilerGenerated]
	[Nullable(2)]
	private EventHandler OnFlushObjectReceived; // 0x48
	[CompilerGenerated]
	private readonly Task <WorkerTask>k__BackingField; // 0x50

	// Properties
	internal Task WorkerTask { get; }
	public int QueuedItems { get; }

	// Methods

	[NullableContext(2)]
	[CompilerGenerated]
	// RVA: 0x1C88ED0 Offset: 0x1C880D0 VA: 0x181C88ED0
	private void add_OnFlushObjectReceived(EventHandler value) { }

	[CompilerGenerated]
	[NullableContext(2)]
	// RVA: 0x1C88FC0 Offset: 0x1C881C0 VA: 0x181C88FC0
	private void remove_OnFlushObjectReceived(EventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0
	internal Task get_WorkerTask() { }

	// RVA: 0x1C88F70 Offset: 0x1C88170 VA: 0x181C88F70 Slot: 6
	public int get_QueuedItems() { }

	// RVA: 0x1C88D30 Offset: 0x1C87F30 VA: 0x181C88D30
	public void .ctor(ITransport transport, SentryOptions options, CancellationTokenSource shutdownSource, ConcurrentQueue<Envelope> queue) { }

	// RVA: 0x1C88B30 Offset: 0x1C87D30 VA: 0x181C88B30 Slot: 4
	public bool EnqueueEnvelope(Envelope envelope) { }

	// RVA: 0x1C88900 Offset: 0x1C87B00 VA: 0x181C88900
	public bool EnqueueEnvelope(Envelope envelope, bool process) { }

	// RVA: 0x1C88C30 Offset: 0x1C87E30 VA: 0x181C88C30
	public void ProcessQueuedItems(int count) { }

	[AsyncStateMachine(typeof(BackgroundWorker.<DoWorkAsync>d__20))]
	// RVA: 0x1C88830 Offset: 0x1C87A30 VA: 0x181C88830
	private Task DoWorkAsync() { }

	[AsyncStateMachine(typeof(BackgroundWorker.<FlushAsync>d__21))]
	// RVA: 0x1C88B40 Offset: 0x1C87D40 VA: 0x181C88B40 Slot: 5
	public Task FlushAsync(TimeSpan timeout) { }

	[AsyncStateMachine(typeof(BackgroundWorker.<DoFlushAsync>d__22))]
	// RVA: 0x1C88750 Offset: 0x1C87950 VA: 0x181C88750
	private Task DoFlushAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(BackgroundWorker.<SendFinalClientReportAsync>d__23))]
	// RVA: 0x1C88C50 Offset: 0x1C87E50 VA: 0x181C88C50
	private Task SendFinalClientReportAsync(CancellationToken cancellationToken) { }

	// RVA: 0x1C88570 Offset: 0x1C87770 VA: 0x181C88570 Slot: 7
	public void Dispose() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class ClientReport.<>c // TypeDefIndex: 13580
{
	// Fields
	[Nullable(0)]
	public static readonly ClientReport.<>c <>9; // 0x0
	[Nullable(0)]
	public static Func<KeyValuePair<DiscardReasonWithCategory, int>, bool> <>9__7_0; // 0x8
	[Nullable(0)]
	public static Func<KeyValuePair<DiscardReasonWithCategory, int>, DiscardReason> <>9__7_1; // 0x10
	[Nullable(0)]
	public static Func<KeyValuePair<DiscardReasonWithCategory, int>, DataCategory> <>9__7_2; // 0x18
	[Nullable(0)]
	public static Func<JsonElement, <>f__AnonymousType0<string, string, int>> <>9__8_0; // 0x20
	[Nullable(0)]
	public static Func<<>f__AnonymousType0<string, string, int>, DiscardReasonWithCategory> <>9__8_1; // 0x28
	[Nullable(0)]
	public static Func<<>f__AnonymousType0<string, string, int>, int> <>9__8_2; // 0x30

	// Methods

	// RVA: 0x1CA0E40 Offset: 0x1CA0040 VA: 0x181CA0E40
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	[NullableContext(0)]
	// RVA: 0x1CA0640 Offset: 0x1C9F840 VA: 0x181CA0640
	internal bool <WriteTo>b__7_0(KeyValuePair<DiscardReasonWithCategory, int> x) { }

	[NullableContext(0)]
	// RVA: 0x1CA0680 Offset: 0x1C9F880 VA: 0x181CA0680
	internal DiscardReason <WriteTo>b__7_1(KeyValuePair<DiscardReasonWithCategory, int> x) { }

	[NullableContext(0)]
	// RVA: 0x1CA06C0 Offset: 0x1C9F8C0 VA: 0x181CA06C0
	internal DataCategory <WriteTo>b__7_2(KeyValuePair<DiscardReasonWithCategory, int> x) { }

	[NullableContext(0)]
	// RVA: 0x1CA0380 Offset: 0x1C9F580 VA: 0x181CA0380
	internal <>f__AnonymousType0<string, string, int> <FromJson>b__8_0(JsonElement x) { }

	[NullableContext(0)]
	// RVA: 0x1CA04C0 Offset: 0x1C9F6C0 VA: 0x181CA04C0
	internal DiscardReasonWithCategory <FromJson>b__8_1(<>f__AnonymousType0<string, string, int> x) { }

	[NullableContext(0)]
	// RVA: 0x1CA0520 Offset: 0x1C9F720 VA: 0x181CA0520
	internal int <FromJson>b__8_2(<>f__AnonymousType0<string, string, int> x) { }
}

// Namespace: Sentry.Internal
[Nullable(0)]
[NullableContext(1)]
internal class ClientReport : IJsonSerializable // TypeDefIndex: 13581
{
	// Fields
	[CompilerGenerated]
	private readonly DateTimeOffset <Timestamp>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly IReadOnlyDictionary<DiscardReasonWithCategory, int> <DiscardedEvents>k__BackingField; // 0x20

	// Properties
	public DateTimeOffset Timestamp { get; }
	public IReadOnlyDictionary<DiscardReasonWithCategory, int> DiscardedEvents { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x482990 Offset: 0x481B90 VA: 0x180482990
	public DateTimeOffset get_Timestamp() { }

	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public IReadOnlyDictionary<DiscardReasonWithCategory, int> get_DiscardedEvents() { }

	// RVA: 0xCC8990 Offset: 0xCC7B90 VA: 0x180CC8990
	public void .ctor(DateTimeOffset timestamp, IReadOnlyDictionary<DiscardReasonWithCategory, int> discardedEvents) { }

	// RVA: 0x1C89940 Offset: 0x1C88B40 VA: 0x181C89940 Slot: 4
	public void WriteTo(Utf8JsonWriter writer, IDiagnosticLogger logger) { }

	// RVA: 0x1C895E0 Offset: 0x1C887E0 VA: 0x181C895E0
	public static ClientReport FromJson(JsonElement json) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class ClientReportRecorder.<>c // TypeDefIndex: 13582
{
	// Fields
	[Nullable(0)]
	public static readonly ClientReportRecorder.<>c <>9; // 0x0
	[Nullable(0)]
	public static Func<KeyValuePair<DiscardReasonWithCategory, int>, bool> <>9__7_0; // 0x8

	// Methods

	// RVA: 0x1CA0D20 Offset: 0x1C9FF20 VA: 0x181CA0D20
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	[NullableContext(0)]
	// RVA: 0x1CA0560 Offset: 0x1C9F760 VA: 0x181CA0560
	internal bool <GenerateClientReport>b__7_0(KeyValuePair<DiscardReasonWithCategory, int> x) { }
}

// Namespace: Sentry.Internal
[NullableContext(1)]
[Nullable(0)]
internal class ClientReportRecorder : IClientReportRecorder // TypeDefIndex: 13583
{
	// Fields
	private readonly SentryOptions _options; // 0x10
	private readonly ISystemClock _clock; // 0x18
	private readonly ThreadsafeCounterDictionary<DiscardReasonWithCategory> _discardedEvents; // 0x20

	// Properties
	internal IReadOnlyDictionary<DiscardReasonWithCategory, int> DiscardedEvents { get; }

	// Methods

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	internal IReadOnlyDictionary<DiscardReasonWithCategory, int> get_DiscardedEvents() { }

	// RVA: 0x1C89510 Offset: 0x1C88710 VA: 0x181C89510
	public void .ctor(SentryOptions options, ISystemClock clock) { }

	// RVA: 0x1C89460 Offset: 0x1C88660 VA: 0x181C89460 Slot: 4
	public void RecordDiscardedEvent(DiscardReason reason, DataCategory category) { }

	[NullableContext(2)]
	// RVA: 0x1C89060 Offset: 0x1C88260 VA: 0x181C89060 Slot: 5
	public ClientReport GenerateClientReport() { }

	// RVA: 0x1C89230 Offset: 0x1C88430 VA: 0x181C89230 Slot: 6
	public void Load(ClientReport clientReport) { }
}

// Namespace: Sentry.Internal
[NullableContext(1)]
[Nullable(0)]
internal static class Constants // TypeDefIndex: 13584
{
	// Fields
	public const string DsnEnvironmentVariable = "SENTRY_DSN";
	public const string ReleaseEnvironmentVariable = "SENTRY_RELEASE";
	public const string EnvironmentEnvironmentVariable = "SENTRY_ENVIRONMENT";
	public const string ProductionEnvironmentSetting = "production";
	public const string StagingEnvironmentSetting = "staging";
	public const string DevelopmentEnvironmentSetting = "development";
	public const string DebugEnvironmentSetting = "debug";
	public const string SdkName = "sentry.dotnet";
}

// Namespace: Sentry.Internal
[IsReadOnly]
internal struct DataCategory : IEnumeration<DataCategory>, IEquatable<DataCategory>, IComparable<DataCategory>, IEnumeration, IComparable // TypeDefIndex: 13585
{
	// Fields
	public static DataCategory Attachment; // 0x0
	public static DataCategory Default; // 0x8
	public static DataCategory Error; // 0x10
	public static DataCategory Internal; // 0x18
	public static DataCategory Security; // 0x20
	public static DataCategory Session; // 0x28
	public static DataCategory Transaction; // 0x30
	public static DataCategory Profile; // 0x38
	[Nullable(1)]
	private readonly string _value; // 0x0

	// Properties
	[Nullable(1)]
	private string Sentry.Internal.IEnumeration.Value { get; }

	// Methods

	[NullableContext(1)]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410 Slot: 6
	private string Sentry.Internal.IEnumeration.get_Value() { }

	[NullableContext(1)]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void .ctor(string value) { }

	// RVA: 0x1C89EE0 Offset: 0x1C890E0 VA: 0x181C89EE0 Slot: 5
	public int CompareTo(DataCategory other) { }

	[NullableContext(2)]
	// RVA: 0x1C89F00 Offset: 0x1C89100 VA: 0x181C89F00 Slot: 7
	public int CompareTo(object obj) { }

	// RVA: 0x15E5160 Offset: 0x15E4360 VA: 0x1815E5160 Slot: 4
	public bool Equals(DataCategory other) { }

	[NullableContext(2)]
	// RVA: 0x1C8A000 Offset: 0x1C89200 VA: 0x181C8A000 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1C8A0A0 Offset: 0x1C892A0 VA: 0x181C8A0A0 Slot: 2
	public override int GetHashCode() { }

	[NullableContext(1)]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410 Slot: 3
	public override string ToString() { }

	// RVA: 0x1C8A0D0 Offset: 0x1C892D0 VA: 0x181C8A0D0
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class DebugStackTrace.<>c // TypeDefIndex: 13586
{
	// Fields
	[Nullable(0)]
	public static readonly DebugStackTrace.<>c <>9; // 0x0
	[Nullable(0)]
	public static Func<EnhancedStackFrame, StackFrame> <>9__13_0; // 0x8

	// Methods

	// RVA: 0x1CA0CC0 Offset: 0x1C9FEC0 VA: 0x181CA0CC0
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	[NullableContext(0)]
	// RVA: 0x70E580 Offset: 0x70D780 VA: 0x18070E580
	internal StackFrame <CreateFrames>b__13_0(EnhancedStackFrame p) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class DebugStackTrace.<CreateFrames>d__13 : IEnumerable<SentryStackFrame>, IEnumerable, IEnumerator<SentryStackFrame>, IEnumerator, IDisposable // TypeDefIndex: 13587
{
	// Fields
	private int <>1__state; // 0x10
	private SentryStackFrame <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	[Nullable(0)]
	public DebugStackTrace <>4__this; // 0x28
	[Nullable(0)]
	private StackTrace stackTrace; // 0x30
	[Nullable(0)]
	public StackTrace <>3__stackTrace; // 0x38
	private bool isCurrentStackTrace; // 0x40
	public bool <>3__isCurrentStackTrace; // 0x41
	private bool <firstFrame>5__2; // 0x42
	[Nullable(0)]
	private IEnumerator<StackFrame> <>7__wrap2; // 0x48

	// Properties
	private SentryStackFrame System.Collections.Generic.IEnumerator<Sentry.SentryStackFrame>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x5B8720 Offset: 0x5B7920 VA: 0x1805B8720
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x1C9A6F0 Offset: 0x1C998F0 VA: 0x181C9A6F0 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1C9A010 Offset: 0x1C99210 VA: 0x181C9A010 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x1C9A780 Offset: 0x1C99980 VA: 0x181C9A780
	private void <>m__Finally1() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 6
	private SentryStackFrame System.Collections.Generic.IEnumerator<Sentry.SentryStackFrame>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1C9A6B0 Offset: 0x1C998B0 VA: 0x181C9A6B0 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1C9A600 Offset: 0x1C99800 VA: 0x181C9A600 Slot: 4
	private IEnumerator<SentryStackFrame> System.Collections.Generic.IEnumerable<Sentry.SentryStackFrame>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1C9A600 Offset: 0x1C99800 VA: 0x181C9A600 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: Sentry.Internal
[Nullable(0)]
[NullableContext(1)]
internal class DebugStackTrace : SentryStackTrace // TypeDefIndex: 13588
{
	// Fields
	private readonly SentryOptions _options; // 0x20
	private readonly Dictionary<Guid, int> _debugImageIndexByModule; // 0x28
	private const int DebugImageMissing = -1;
	private bool _debugImagesMerged; // 0x30
	private static readonly Regex RegexAsyncFunctionName; // 0x0
	private static readonly Regex RegexAnonymousFunction; // 0x8
	private static readonly Regex RegexAsyncReturn; // 0x10
	[CompilerGenerated]
	private readonly List<DebugImage> <DebugImages>k__BackingField; // 0x38

	// Properties
	protected List<DebugImage> DebugImages { get; }

	// Methods

	// RVA: 0x1C8C190 Offset: 0x1C8B390 VA: 0x181C8C190
	internal void .ctor(SentryOptions options) { }

	[CompilerGenerated]
	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	protected List<DebugImage> get_DebugImages() { }

	// RVA: 0x1C8A4A0 Offset: 0x1C896A0 VA: 0x181C8A4A0
	internal static DebugStackTrace Create(SentryOptions options, StackTrace stackTrace, bool isCurrentStackTrace) { }

	// RVA: 0x1C8B9D0 Offset: 0x1C8ABD0 VA: 0x181C8B9D0
	internal void MergeDebugImagesInto(SentryEvent event) { }

	[IteratorStateMachine(typeof(DebugStackTrace.<CreateFrames>d__13))]
	// RVA: 0x1C8A410 Offset: 0x1C89610 VA: 0x181C8A410
	private IEnumerable<SentryStackFrame> CreateFrames(StackTrace stackTrace, bool isCurrentStackTrace) { }

	// RVA: 0x1C8A400 Offset: 0x1C89600 VA: 0x181C8A400
	internal SentryStackFrame CreateFrame(StackFrame stackFrame) { }

	// RVA: 0x1C8AF00 Offset: 0x1C8A100 VA: 0x181C8AF00
	private SentryStackFrame InternalCreateFrame(StackFrame stackFrame, bool demangle) { }

	// RVA: 0x1C8AEA0 Offset: 0x1C8A0A0 VA: 0x181C8AEA0
	private static string GetRelativeAddressMode(int moduleIndex) { }

	// RVA: 0x1C8A960 Offset: 0x1C89B60 VA: 0x181C8A960
	private static void DemangleAsyncFunctionName(SentryStackFrame frame) { }

	// RVA: 0x1C8A830 Offset: 0x1C89A30 VA: 0x181C8A830
	internal static void DemangleAnonymousFunction(SentryStackFrame frame) { }

	// RVA: 0x1C8AAE0 Offset: 0x1C89CE0 VA: 0x181C8AAE0
	private static void DemangleLambdaReturnType(SentryStackFrame frame) { }

	// RVA: 0x1C8BFB0 Offset: 0x1C8B1B0 VA: 0x181C8BFB0
	private static PEReader TryReadAssemblyFromDisk(Module module, SentryOptions options, out string assemblyName) { }

	// RVA: 0x1C8A220 Offset: 0x1C89420 VA: 0x181C8A220
	private Nullable<int> AddDebugImage(Module module) { }

	// RVA: 0x1C8ABF0 Offset: 0x1C89DF0 VA: 0x181C8ABF0
	internal static DebugImage GetDebugImage(Module module, SentryOptions options) { }

	// RVA: 0x1C8C080 Offset: 0x1C8B280 VA: 0x181C8C080
	private static void .cctor() { }
}

// Namespace: Sentry.Internal
[NullableContext(1)]
[Nullable(0)]
internal class DelegateEventProcessor : ISentryEventProcessor // TypeDefIndex: 13589
{
	// Fields
	private readonly Func<SentryEvent, SentryEvent> _func; // 0x10

	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	public void .ctor(Func<SentryEvent, SentryEvent> func) { }

	// RVA: 0x86D060 Offset: 0x86C260 VA: 0x18086D060 Slot: 4
	public SentryEvent Process(SentryEvent event) { }
}

// Namespace: Sentry.Internal
internal class DelegateTransactionProcessor : ISentryTransactionProcessor // TypeDefIndex: 13590
{
	// Fields
	[Nullable(new[] { 1, 1, 2 })]
	private readonly Func<Transaction, Transaction> _func; // 0x10

	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	public void .ctor(Func<Transaction, Transaction> func) { }

	[NullableContext(1)]
	// RVA: 0x86D060 Offset: 0x86C260 VA: 0x18086D060 Slot: 4
	public Transaction Process(Transaction transaction) { }
}

// Namespace: Sentry.Internal
[IsReadOnly]
internal struct DiscardReason : IEnumeration<DiscardReason>, IEquatable<DiscardReason>, IComparable<DiscardReason>, IEnumeration, IComparable // TypeDefIndex: 13591
{
	// Fields
	public static DiscardReason BeforeSend; // 0x0
	public static DiscardReason CacheOverflow; // 0x8
	public static DiscardReason EventProcessor; // 0x10
	public static DiscardReason NetworkError; // 0x18
	public static DiscardReason QueueOverflow; // 0x20
	public static DiscardReason RateLimitBackoff; // 0x28
	public static DiscardReason SampleRate; // 0x30
	[Nullable(1)]
	private readonly string _value; // 0x0

	// Properties
	[Nullable(1)]
	private string Sentry.Internal.IEnumeration.Value { get; }

	// Methods

	[NullableContext(1)]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410 Slot: 6
	private string Sentry.Internal.IEnumeration.get_Value() { }

	[NullableContext(1)]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void .ctor(string value) { }

	// RVA: 0x1C8C850 Offset: 0x1C8BA50 VA: 0x181C8C850
	public DiscardReasonWithCategory WithCategory(DataCategory category) { }

	// RVA: 0x1C89EE0 Offset: 0x1C890E0 VA: 0x181C89EE0 Slot: 5
	public int CompareTo(DiscardReason other) { }

	[NullableContext(2)]
	// RVA: 0x1C8C6B0 Offset: 0x1C8B8B0 VA: 0x181C8C6B0 Slot: 7
	public int CompareTo(object obj) { }

	// RVA: 0x15E5160 Offset: 0x15E4360 VA: 0x1815E5160 Slot: 4
	public bool Equals(DiscardReason other) { }

	[NullableContext(2)]
	// RVA: 0x1C8C7B0 Offset: 0x1C8B9B0 VA: 0x181C8C7B0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1C8A0A0 Offset: 0x1C892A0 VA: 0x181C8A0A0 Slot: 2
	public override int GetHashCode() { }

	[NullableContext(1)]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410 Slot: 3
	public override string ToString() { }

	// RVA: 0x1C8C860 Offset: 0x1C8BA60 VA: 0x181C8C860
	private static void .cctor() { }
}

// Namespace: Sentry.Internal
[IsReadOnly]
internal struct DiscardReasonWithCategory : IEquatable<DiscardReasonWithCategory>, IComparable<DiscardReasonWithCategory>, IComparable // TypeDefIndex: 13592
{
	// Fields
	[CompilerGenerated]
	private readonly DiscardReason <Reason>k__BackingField; // 0x0
	[CompilerGenerated]
	private readonly DataCategory <Category>k__BackingField; // 0x8

	// Properties
	public DiscardReason Reason { get; }
	public DataCategory Category { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public DiscardReason get_Reason() { }

	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public DataCategory get_Category() { }

	[NullableContext(1)]
	// RVA: 0x5C3520 Offset: 0x5C2720 VA: 0x1805C3520
	public void .ctor(string reason, string category) { }

	// RVA: 0x5C3520 Offset: 0x5C2720 VA: 0x1805C3520
	public void .ctor(DiscardReason reason, DataCategory category) { }

	// RVA: 0x1C8C250 Offset: 0x1C8B450 VA: 0x181C8C250 Slot: 5
	public int CompareTo(DiscardReasonWithCategory other) { }

	[NullableContext(2)]
	// RVA: 0x1C8C300 Offset: 0x1C8B500 VA: 0x181C8C300 Slot: 6
	public int CompareTo(object obj) { }

	// RVA: 0x1C8C3F0 Offset: 0x1C8B5F0 VA: 0x181C8C3F0 Slot: 4
	public bool Equals(DiscardReasonWithCategory other) { }

	[NullableContext(2)]
	// RVA: 0x1C8C4A0 Offset: 0x1C8B6A0 VA: 0x181C8C4A0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1C8C540 Offset: 0x1C8B740 VA: 0x181C8C540 Slot: 2
	public override int GetHashCode() { }

	[NullableContext(1)]
	// RVA: 0x1C8C610 Offset: 0x1C8B810 VA: 0x181C8C610 Slot: 3
	public override string ToString() { }
}

// Namespace: Sentry.Internal
[NullableContext(1)]
[Nullable(0)]
internal class Disposable : IDisposable // TypeDefIndex: 13593
{
	// Fields
	private readonly Action _dispose; // 0x10

	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	public void .ctor(Action dispose) { }

	// RVA: 0x54C5B0 Offset: 0x54B7B0 VA: 0x18054C5B0 Slot: 4
	public void Dispose() { }

	// RVA: 0x1C8C990 Offset: 0x1C8BB90 VA: 0x181C8C990
	public static IDisposable Create(Action dispose) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class DuplicateEventDetectionEventProcessor.<>c__DisplayClass4_0 // TypeDefIndex: 13594
{
	// Fields
	[Nullable(0)]
	public DuplicateEventDetectionEventProcessor <>4__this; // 0x10
	public SentryId eventId; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	[NullableContext(0)]
	// RVA: 0x1CA0C20 Offset: 0x1C9FE20 VA: 0x181CA0C20
	internal bool <IsDuplicate>b__0(Exception e) { }
}

// Namespace: Sentry.Internal
[Nullable(0)]
[NullableContext(1)]
internal class DuplicateEventDetectionEventProcessor : ISentryEventProcessor // TypeDefIndex: 13595
{
	// Fields
	private readonly SentryOptions _options; // 0x10
	[Nullable(new[] { 1, 1, 2 })]
	private readonly ConditionalWeakTable<object, object> _capturedObjects; // 0x18

	// Methods

	// RVA: 0x1C8CDF0 Offset: 0x1C8BFF0 VA: 0x181C8CDF0
	public void .ctor(SentryOptions options) { }

	// RVA: 0x1C8CCB0 Offset: 0x1C8BEB0 VA: 0x181C8CCB0 Slot: 4
	public SentryEvent Process(SentryEvent event) { }

	// RVA: 0x1C8C9F0 Offset: 0x1C8BBF0 VA: 0x181C8C9F0
	private bool IsDuplicate(Exception ex, SentryId eventId, bool debugLog) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class Enricher.<>c // TypeDefIndex: 13596
{
	// Fields
	[Nullable(0)]
	public static readonly Enricher.<>c <>9; // 0x0
	[Nullable(new[] { 0, 1 })]
	public static Func<Runtime> <>9__2_0; // 0x8

	// Methods

	// RVA: 0x1CA0D80 Offset: 0x1C9FF80 VA: 0x181CA0D80
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1CA0700 Offset: 0x1C9F900 VA: 0x181CA0700
	internal Runtime <.ctor>b__2_0() { }
}

// Namespace: Sentry.Internal
[Nullable(0)]
[NullableContext(1)]
internal class Enricher // TypeDefIndex: 13597
{
	// Fields
	private readonly SentryOptions _options; // 0x10
	private readonly Lazy<Runtime> _runtimeLazy; // 0x18

	// Methods

	// RVA: 0x1C8D690 Offset: 0x1C8C890 VA: 0x181C8D690
	public void .ctor(SentryOptions options) { }

	// RVA: 0x1C8CE70 Offset: 0x1C8C070 VA: 0x181C8CE70
	public void Apply(IEventLike eventLike) { }

	[CompilerGenerated]
	// RVA: 0x1C8D610 Offset: 0x1C8C810 VA: 0x181C8D610
	private void <Apply>b__3_0(IHasDistribution _) { }
}

// Namespace: Sentry.Internal
internal class ExceptionTypeFilter<TException> : IExceptionFilter // TypeDefIndex: 13598
{
	// Fields
	[Nullable(1)]
	private readonly Type _filteredType; // 0x0

	// Methods

	[NullableContext(1)]
	// RVA: -1 Offset: -1 Slot: 4
	public bool Filter(Exception ex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11EFC80 Offset: 0x11EEE80 VA: 0x1811EFC80
	|-ExceptionTypeFilter<object>.Filter
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11EFCB0 Offset: 0x11EEEB0 VA: 0x1811EFCB0
	|-ExceptionTypeFilter<object>..ctor
	*/
}

// Namespace: Sentry.Internal
[Nullable(0)]
[NullableContext(1)]
[DefaultMember("Item")]
internal struct HashableGrowableArray<T> : IReadOnlyList<T>, IEnumerable<T>, IEnumerable, IReadOnlyCollection<T>, IEquatable<HashableGrowableArray<T>> // TypeDefIndex: 13599
{
	// Fields
	[Nullable(new[] { 0, 1 })]
	private GrowableArray<T> _items; // 0x0
	private int _hashCode; // 0x0
	private bool _sealed; // 0x0

	// Properties
	public T Item { get; set; }
	public int Count { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125C040 Offset: 0x125B240 VA: 0x18125C040
	|-HashableGrowableArray<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125C120 Offset: 0x125B320 VA: 0x18125C120
	|-HashableGrowableArray<__Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1
	public void set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125C230 Offset: 0x125B430 VA: 0x18125C230
	|-HashableGrowableArray<__Il2CppFullySharedGenericType>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125C0B0 Offset: 0x125B2B0 VA: 0x18125C0B0
	|-HashableGrowableArray<__Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1
	public void Seal() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125BC30 Offset: 0x125AE30 VA: 0x18125BC30
	|-HashableGrowableArray<__Il2CppFullySharedGenericType>.Seal
	*/

	// RVA: -1 Offset: -1
	public void Trim(int maxWaste) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125BFC0 Offset: 0x125B1C0 VA: 0x18125BFC0
	|-HashableGrowableArray<__Il2CppFullySharedGenericType>.Trim
	*/

	// RVA: -1 Offset: -1
	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125B800 Offset: 0x125AA00 VA: 0x18125B800
	|-HashableGrowableArray<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	|-HashableGrowableArray<__Il2CppFullySharedGenericType>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public bool Equals(HashableGrowableArray<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125B950 Offset: 0x125AB50 VA: 0x18125B950
	|-HashableGrowableArray<__Il2CppFullySharedGenericType>.Equals
	*/

	[NullableContext(2)]
	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125BA60 Offset: 0x125AC60 VA: 0x18125BA60
	|-HashableGrowableArray<__Il2CppFullySharedGenericType>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public IEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125BBC0 Offset: 0x125ADC0 VA: 0x18125BBC0
	|-HashableGrowableArray<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125BBC0 Offset: 0x125ADC0 VA: 0x18125BBC0
	|-HashableGrowableArray<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: 
[Nullable(0)]
public struct GrowableArray.GrowableArrayEnumerator<T> : IEnumerator<T>, IEnumerator, IDisposable // TypeDefIndex: 13600
{
	// Fields
	private int cur; // 0x0
	private int end; // 0x0
	private T[] array; // 0x0

	// Properties
	private object System.Collections.IEnumerator.Current { get; }
	public T Current { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1214900 Offset: 0x1213B00 VA: 0x181214900
	|-GrowableArray.GrowableArrayEnumerator<GrowableArray<int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1214790 Offset: 0x1213990 VA: 0x181214790
	|-GrowableArray.GrowableArrayEnumerator<int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1214750 Offset: 0x1213950 VA: 0x181214750
	|-GrowableArray.GrowableArrayEnumerator<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1214800 Offset: 0x1213A00 VA: 0x181214800
	|-GrowableArray.GrowableArrayEnumerator<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1214A00 Offset: 0x1213C00 VA: 0x181214A00
	|-GrowableArray.GrowableArrayEnumerator<GrowableArray<int>>.get_Current
	|
	|-RVA: 0x1214B90 Offset: 0x1213D90 VA: 0x181214B90
	|-GrowableArray.GrowableArrayEnumerator<int>.get_Current
	|
	|-RVA: 0x1214C10 Offset: 0x1213E10 VA: 0x181214C10
	|-GrowableArray.GrowableArrayEnumerator<object>.get_Current
	|
	|-RVA: 0x1214A80 Offset: 0x1213C80 VA: 0x181214A80
	|-GrowableArray.GrowableArrayEnumerator<__Il2CppFullySharedGenericType>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1214730 Offset: 0x1213930 VA: 0x181214730
	|-GrowableArray.GrowableArrayEnumerator<GrowableArray<int>>.MoveNext
	|-GrowableArray.GrowableArrayEnumerator<int>.MoveNext
	|-GrowableArray.GrowableArrayEnumerator<object>.MoveNext
	|-GrowableArray.GrowableArrayEnumerator<__Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1214740 Offset: 0x1213940 VA: 0x181214740
	|-GrowableArray.GrowableArrayEnumerator<GrowableArray<int>>.Reset
	|-GrowableArray.GrowableArrayEnumerator<int>.Reset
	|-GrowableArray.GrowableArrayEnumerator<object>.Reset
	|-GrowableArray.GrowableArrayEnumerator<__Il2CppFullySharedGenericType>.Reset
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	|-GrowableArray.GrowableArrayEnumerator<GrowableArray<int>>.Dispose
	|-GrowableArray.GrowableArrayEnumerator<int>.Dispose
	|-GrowableArray.GrowableArrayEnumerator<object>.Dispose
	|-GrowableArray.GrowableArrayEnumerator<__Il2CppFullySharedGenericType>.Dispose
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(GrowableArray<T> growableArray) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12149E0 Offset: 0x1213BE0 VA: 0x1812149E0
	|-GrowableArray.GrowableArrayEnumerator<GrowableArray<int>>..ctor
	|-GrowableArray.GrowableArrayEnumerator<int>..ctor
	|-GrowableArray.GrowableArrayEnumerator<object>..ctor
	|-GrowableArray.GrowableArrayEnumerator<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: Sentry.Internal
[NullableContext(1)]
[Nullable(0)]
[DefaultMember("Item")]
internal struct GrowableArray<T> : IReadOnlyList<T>, IEnumerable<T>, IEnumerable, IReadOnlyCollection<T> // TypeDefIndex: 13601
{
	// Fields
	private T[] array; // 0x0
	private int arrayLength; // 0x0

	// Properties
	public T Item { get; set; }
	public int Count { get; }
	public bool Empty { get; }
	public bool EmptyCapacity { get; }
	public T[] UnderlyingArray { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(int initialSize) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1217540 Offset: 0x1216740 VA: 0x181217540
	|-GrowableArray<GrowableArray<int>>..ctor
	|-GrowableArray<int>..ctor
	|-GrowableArray<object>..ctor
	|-GrowableArray<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12175E0 Offset: 0x12167E0 VA: 0x1812175E0
	|-GrowableArray<GrowableArray<int>>.get_Item
	|
	|-RVA: 0x12175B0 Offset: 0x12167B0 VA: 0x1812175B0
	|-GrowableArray<int>.get_Item
	|
	|-RVA: 0x12176F0 Offset: 0x12168F0 VA: 0x1812176F0
	|-GrowableArray<object>.get_Item
	|
	|-RVA: 0x1217620 Offset: 0x1216820 VA: 0x181217620
	|-GrowableArray<__Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1
	public void set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12178B0 Offset: 0x1216AB0 VA: 0x1812178B0
	|-GrowableArray<GrowableArray<int>>.set_Item
	|
	|-RVA: 0x1217880 Offset: 0x1216A80 VA: 0x181217880
	|-GrowableArray<int>.set_Item
	|
	|-RVA: 0x1217850 Offset: 0x1216A50 VA: 0x181217850
	|-GrowableArray<object>.set_Item
	|
	|-RVA: 0x1217720 Offset: 0x1216920 VA: 0x181217720
	|-GrowableArray<__Il2CppFullySharedGenericType>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3F5510 Offset: 0x3F4710 VA: 0x1803F5510
	|-GrowableArray<GrowableArray<int>>.get_Count
	|-GrowableArray<int>.get_Count
	|-GrowableArray<object>.get_Count
	|-GrowableArray<__Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1
	public void Reserve(int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1216930 Offset: 0x1215B30 VA: 0x181216930
	|-GrowableArray<GrowableArray<int>>.Reserve
	|-GrowableArray<int>.Reserve
	|-GrowableArray<object>.Reserve
	|
	|-RVA: 0x12168B0 Offset: 0x1215AB0 VA: 0x1812168B0
	|-GrowableArray<__Il2CppFullySharedGenericType>.Reserve
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1215B00 Offset: 0x1214D00 VA: 0x181215B00
	|-GrowableArray<GrowableArray<int>>.Clear
	|-GrowableArray<int>.Clear
	|-GrowableArray<object>.Clear
	|-GrowableArray<__Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1
	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12157D0 Offset: 0x12149D0 VA: 0x1812157D0
	|-GrowableArray<GrowableArray<int>>.Add
	|
	|-RVA: 0x1215860 Offset: 0x1214A60 VA: 0x181215860
	|-GrowableArray<int>.Add
	|
	|-RVA: 0x12158E0 Offset: 0x1214AE0 VA: 0x1812158E0
	|-GrowableArray<object>.Add
	|
	|-RVA: 0x1215960 Offset: 0x1214B60 VA: 0x181215960
	|-GrowableArray<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1
	public void AddRange(IEnumerable<T> items) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1214C90 Offset: 0x1213E90 VA: 0x181214C90
	|-GrowableArray<GrowableArray<int>>.AddRange
	|
	|-RVA: 0x1215540 Offset: 0x1214740 VA: 0x181215540
	|-GrowableArray<int>.AddRange
	|
	|-RVA: 0x12152B0 Offset: 0x12144B0 VA: 0x1812152B0
	|-GrowableArray<object>.AddRange
	|
	|-RVA: 0x1214F40 Offset: 0x1214140 VA: 0x181214F40
	|-GrowableArray<__Il2CppFullySharedGenericType>.AddRange
	*/

	// RVA: -1 Offset: -1
	public void Insert(int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1216080 Offset: 0x1215280 VA: 0x181216080
	|-GrowableArray<GrowableArray<int>>.Insert
	|
	|-RVA: 0x1215F70 Offset: 0x1215170 VA: 0x181215F70
	|-GrowableArray<int>.Insert
	|
	|-RVA: 0x1215E50 Offset: 0x1215050 VA: 0x181215E50
	|-GrowableArray<object>.Insert
	|
	|-RVA: 0x1215BA0 Offset: 0x1214DA0 VA: 0x181215BA0
	|-GrowableArray<__Il2CppFullySharedGenericType>.Insert
	*/

	// RVA: -1 Offset: -1
	public void RemoveRange(int index, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1216490 Offset: 0x1215690 VA: 0x181216490
	|-GrowableArray<GrowableArray<int>>.RemoveRange
	|
	|-RVA: 0x1216390 Offset: 0x1215590 VA: 0x181216390
	|-GrowableArray<int>.RemoveRange
	|
	|-RVA: 0x12165C0 Offset: 0x12157C0 VA: 0x1812165C0
	|-GrowableArray<object>.RemoveRange
	|
	|-RVA: 0x12166C0 Offset: 0x12158C0 VA: 0x1812166C0
	|-GrowableArray<__Il2CppFullySharedGenericType>.RemoveRange
	*/

	// RVA: -1 Offset: -1
	public bool get_Empty() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBE1CD0 Offset: 0xBE0ED0 VA: 0x180BE1CD0
	|-GrowableArray<GrowableArray<int>>.get_Empty
	|-GrowableArray<int>.get_Empty
	|-GrowableArray<object>.get_Empty
	|-GrowableArray<__Il2CppFullySharedGenericType>.get_Empty
	*/

	// RVA: -1 Offset: -1
	public void Trim(int maxWaste) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1217460 Offset: 0x1216660 VA: 0x181217460
	|-GrowableArray<GrowableArray<int>>.Trim
	|-GrowableArray<int>.Trim
	|-GrowableArray<object>.Trim
	|-GrowableArray<__Il2CppFullySharedGenericType>.Trim
	*/

	// RVA: -1 Offset: -1
	public bool get_EmptyCapacity() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12175A0 Offset: 0x12167A0 VA: 0x1812175A0
	|-GrowableArray<GrowableArray<int>>.get_EmptyCapacity
	|-GrowableArray<int>.get_EmptyCapacity
	|-GrowableArray<object>.get_EmptyCapacity
	|-GrowableArray<__Il2CppFullySharedGenericType>.get_EmptyCapacity
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1216980 Offset: 0x1215B80 VA: 0x181216980
	|-GrowableArray<GrowableArray<int>>.ToString
	|
	|-RVA: 0x1217250 Offset: 0x1216450 VA: 0x181217250
	|-GrowableArray<int>.ToString
	|
	|-RVA: 0x1217060 Offset: 0x1216260 VA: 0x181217060
	|-GrowableArray<object>.ToString
	|
	|-RVA: 0x1216B80 Offset: 0x1215D80 VA: 0x181216B80
	|-GrowableArray<__Il2CppFullySharedGenericType>.ToString
	*/

	// RVA: -1 Offset: -1
	public GrowableArray<T1> Foreach<T1>(Func<T, T1> func) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8E14C0 Offset: 0x8E06C0 VA: 0x1808E14C0
	|-GrowableArray<__Il2CppFullySharedGenericType>.Foreach<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public bool Search<Key>(Key key, int startIndex, Func<Key, T, int> compare, ref int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8E1750 Offset: 0x8E0950 VA: 0x1808E1750
	|-GrowableArray<__Il2CppFullySharedGenericType>.Search<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public T[] get_UnderlyingArray() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	|-GrowableArray<GrowableArray<int>>.get_UnderlyingArray
	|-GrowableArray<int>.get_UnderlyingArray
	|-GrowableArray<object>.get_UnderlyingArray
	|-GrowableArray<__Il2CppFullySharedGenericType>.get_UnderlyingArray
	*/

	// RVA: -1 Offset: -1
	private void Realloc(int minSize) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12161B0 Offset: 0x12153B0 VA: 0x1812161B0
	|-GrowableArray<GrowableArray<int>>.Realloc
	|-GrowableArray<int>.Realloc
	|-GrowableArray<object>.Realloc
	|
	|-RVA: 0x1216280 Offset: 0x1215480 VA: 0x181216280
	|-GrowableArray<__Il2CppFullySharedGenericType>.Realloc
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1215B10 Offset: 0x1214D10 VA: 0x181215B10
	|-GrowableArray<GrowableArray<int>>.System.Collections.IEnumerable.GetEnumerator
	|-GrowableArray<int>.System.Collections.IEnumerable.GetEnumerator
	|-GrowableArray<object>.System.Collections.IEnumerable.GetEnumerator
	|-GrowableArray<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public IEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1215B10 Offset: 0x1214D10 VA: 0x181215B10
	|-GrowableArray<GrowableArray<int>>.GetEnumerator
	|-GrowableArray<int>.GetEnumerator
	|-GrowableArray<object>.GetEnumerator
	|-GrowableArray<__Il2CppFullySharedGenericType>.GetEnumerator
	*/
}

// Namespace: Sentry.Internal
[Nullable(0)]
[NullableContext(1)]
internal class FileSystem : IFileSystem // TypeDefIndex: 13602
{
	// Fields
	[CompilerGenerated]
	private static readonly IFileSystem <Instance>k__BackingField; // 0x0

	// Properties
	public static IFileSystem Instance { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1C8D9D0 Offset: 0x1C8CBD0 VA: 0x181C8D9D0
	public static IFileSystem get_Instance() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	private void .ctor() { }

	// RVA: 0x1C8D860 Offset: 0x1C8CA60 VA: 0x181C8D860 Slot: 4
	public IEnumerable<string> EnumerateFiles(string path) { }

	// RVA: 0x1C8D820 Offset: 0x1C8CA20 VA: 0x181C8D820 Slot: 5
	public IEnumerable<string> EnumerateFiles(string path, string searchPattern) { }

	// RVA: 0x1C8D840 Offset: 0x1C8CA40 VA: 0x181C8D840 Slot: 6
	public IEnumerable<string> EnumerateFiles(string path, string searchPattern, SearchOption searchOption) { }

	// RVA: 0x1C8D7D0 Offset: 0x1C8C9D0 VA: 0x181C8D7D0 Slot: 7
	public void CreateDirectory(string path) { }

	// RVA: 0x1C8D7F0 Offset: 0x1C8C9F0 VA: 0x181C8D7F0 Slot: 8
	public void DeleteDirectory(string path, bool recursive = False) { }

	// RVA: 0x1C8D810 Offset: 0x1C8CA10 VA: 0x181C8D810 Slot: 9
	public bool DirectoryExists(string path) { }

	// RVA: 0x83E710 Offset: 0x83D910 VA: 0x18083E710 Slot: 10
	public bool FileExists(string path) { }

	// RVA: 0x1C8D920 Offset: 0x1C8CB20 VA: 0x181C8D920 Slot: 11
	public void MoveFile(string sourceFileName, string destFileName, bool overwrite = False) { }

	// RVA: 0x74F040 Offset: 0x74E240 VA: 0x18074F040 Slot: 12
	public void DeleteFile(string path) { }

	// RVA: 0x1C8D870 Offset: 0x1C8CA70 VA: 0x181C8D870 Slot: 13
	public DateTimeOffset GetFileCreationTime(string path) { }

	// RVA: 0x83E8B0 Offset: 0x83DAB0 VA: 0x18083E8B0 Slot: 14
	public string ReadAllTextFromFile(string path) { }

	// RVA: 0x1C8D960 Offset: 0x1C8CB60 VA: 0x181C8D960 Slot: 15
	public Stream OpenFileForReading(string path) { }

	// RVA: 0x1C8D7E0 Offset: 0x1C8C9E0 VA: 0x181C8D7E0 Slot: 16
	public Stream CreateFileForWriting(string path) { }

	// RVA: 0x1C8D970 Offset: 0x1C8CB70 VA: 0x181C8D970
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Hub.<>c__DisplayClass32_0 // TypeDefIndex: 13603
{
	// Fields
	[Nullable(0)]
	public ISpan span; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	internal ISpan <BindException>b__0(Exception _) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Hub.<>c__DisplayClass37_0 // TypeDefIndex: 13604
{
	// Fields
	[Nullable(0)]
	public SentryPropagationContext propagationContext; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1CA0C00 Offset: 0x1C9FE00 VA: 0x181CA0C00
	internal void <ContinueTrace>b__0(Scope scope) { }
}

// Namespace: 
[CompilerGenerated]
private struct Hub.<ConfigureScopeAsync>d__21 : IAsyncStateMachine // TypeDefIndex: 13605
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	[Nullable(0)]
	public Hub <>4__this; // 0x20
	[Nullable(new[] { 0, 1, 1 })]
	public Func<Scope, Task> configureScope; // 0x28
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x30

	// Methods

	// RVA: 0x1C99D90 Offset: 0x1C98F90 VA: 0x181C99D90 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1C99FB0 Offset: 0x1C991B0 VA: 0x181C99FB0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct Hub.<FlushAsync>d__55 : IAsyncStateMachine // TypeDefIndex: 13606
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	[Nullable(0)]
	public Hub <>4__this; // 0x20
	public TimeSpan timeout; // 0x28
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x30

	// Methods

	// RVA: 0x1C9DBD0 Offset: 0x1C9CDD0 VA: 0x181C9DBD0 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1C9DF70 Offset: 0x1C9D170 VA: 0x181C9DF70 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: Sentry.Internal
[NullableContext(1)]
[Nullable(0)]
internal class Hub : IHubEx, IHub, ISentryClient, ISentryScopeManager, IDisposable // TypeDefIndex: 13607
{
	// Fields
	private readonly object _sessionPauseLock; // 0x10
	private readonly ISentryClient _ownedClient; // 0x18
	private readonly ISystemClock _clock; // 0x20
	private readonly ISessionManager _sessionManager; // 0x28
	private readonly SentryOptions _options; // 0x30
	private readonly RandomValuesFactory _randomValuesFactory; // 0x38
	private readonly Enricher _enricher; // 0x40
	private int _isPersistedSessionRecovered; // 0x48
	[CompilerGenerated]
	private readonly ConditionalWeakTable<Exception, ISpan> <ExceptionToSpanMap>k__BackingField; // 0x50
	[CompilerGenerated]
	private readonly IInternalScopeManager <ScopeManager>k__BackingField; // 0x58
	private int _isEnabled; // 0x60

	// Properties
	internal ConditionalWeakTable<Exception, ISpan> ExceptionToSpanMap { get; }
	internal IInternalScopeManager ScopeManager { get; }
	public bool IsEnabled { get; }
	internal SentryOptions Options { get; }
	public SentryId LastEventId { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0
	internal ConditionalWeakTable<Exception, ISpan> get_ExceptionToSpanMap() { }

	[CompilerGenerated]
	// RVA: 0x405090 Offset: 0x404290 VA: 0x180405090
	internal IInternalScopeManager get_ScopeManager() { }

	// RVA: 0x1C91A40 Offset: 0x1C90C40 VA: 0x181C91A40 Slot: 21
	public bool get_IsEnabled() { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	internal SentryOptions get_Options() { }

	[NullableContext(2)]
	// RVA: 0x1C91380 Offset: 0x1C90580 VA: 0x181C91380
	internal void .ctor(SentryOptions options, ISentryClient client, ISessionManager sessionManager, ISystemClock clock, IInternalScopeManager scopeManager, RandomValuesFactory randomValuesFactory) { }

	// RVA: 0x1C8F440 Offset: 0x1C8E640 VA: 0x181C8F440 Slot: 29
	public void ConfigureScope(Action<Scope> configureScope) { }

	[AsyncStateMachine(typeof(Hub.<ConfigureScopeAsync>d__21))]
	// RVA: 0x1C8F360 Offset: 0x1C8E560 VA: 0x181C8F360 Slot: 30
	public Task ConfigureScopeAsync(Func<Scope, Task> configureScope) { }

	// RVA: 0x1C90260 Offset: 0x1C8F460 VA: 0x181C90260 Slot: 32
	public IDisposable PushScope() { }

	// RVA: -1 Offset: -1 Slot: 33
	public IDisposable PushScope<TState>(TState state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA23120 Offset: 0xA22320 VA: 0x180A23120
	|-Hub.PushScope<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1C902B0 Offset: 0x1C8F4B0 VA: 0x181C902B0
	public void RestoreScope(Scope savedScope) { }

	[Obsolete]
	// RVA: 0x1C91320 Offset: 0x1C90520 VA: 0x181C91320 Slot: 34
	public void WithScope(Action<Scope> scopeCallback) { }

	[Obsolete]
	[NullableContext(2)]
	// RVA: -1 Offset: -1 Slot: 5
	public T WithScope<T>(Func<Scope, T> scopeCallback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA23360 Offset: 0xA22560 VA: 0x180A23360
	|-Hub.WithScope<__Il2CppFullySharedGenericType>
	*/

	[Obsolete]
	// RVA: 0x1C912C0 Offset: 0x1C904C0 VA: 0x181C912C0 Slot: 6
	public Task WithScopeAsync(Func<Scope, Task> scopeCallback) { }

	[Obsolete]
	[NullableContext(2)]
	// RVA: -1 Offset: -1 Slot: 7
	public Task<T> WithScopeAsync<T>(Func<Scope, Task<T>> scopeCallback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA23280 Offset: 0xA22480 VA: 0x180A23280
	|-Hub.WithScopeAsync<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1C8E4E0 Offset: 0x1C8D6E0 VA: 0x181C8E4E0 Slot: 31
	public void BindClient(ISentryClient client) { }

	// RVA: 0x1C90C90 Offset: 0x1C8FE90 VA: 0x181C90C90 Slot: 9
	public ITransaction StartTransaction(ITransactionContext context, IReadOnlyDictionary<string, object> customSamplingContext) { }

	// RVA: 0x1C90CB0 Offset: 0x1C8FEB0 VA: 0x181C90CB0
	internal ITransaction StartTransaction(ITransactionContext context, IReadOnlyDictionary<string, object> customSamplingContext, DynamicSamplingContext dynamicSamplingContext) { }

	// RVA: 0x1C8E540 Offset: 0x1C8D740 VA: 0x181C8E540 Slot: 10
	public void BindException(Exception exception, ISpan span) { }

	[NullableContext(2)]
	// RVA: 0x1C8FE60 Offset: 0x1C8F060 VA: 0x181C8FE60 Slot: 11
	public ISpan GetSpan() { }

	// RVA: 0x1C8FF30 Offset: 0x1C8F130 VA: 0x181C8FF30 Slot: 12
	public SentryTraceHeader GetTraceHeader() { }

	// RVA: 0x1C8FC50 Offset: 0x1C8EE50 VA: 0x181C8FC50 Slot: 13
	public BaggageHeader GetBaggage() { }

	[NullableContext(2)]
	// RVA: 0x1C8F4D0 Offset: 0x1C8E6D0 VA: 0x181C8F4D0 Slot: 14
	public TransactionContext ContinueTrace(string traceHeader, string baggageHeader, string name, string operation) { }

	[NullableContext(2)]
	// RVA: 0x1C8F720 Offset: 0x1C8E920 VA: 0x181C8F720 Slot: 15
	public TransactionContext ContinueTrace(SentryTraceHeader traceHeader, BaggageHeader baggageHeader, string name, string operation) { }

	// RVA: 0x1C90B70 Offset: 0x1C8FD70 VA: 0x181C90B70 Slot: 16
	public void StartSession() { }

	// RVA: 0x1C90130 Offset: 0x1C8F330 VA: 0x181C90130 Slot: 17
	public void PauseSession() { }

	// RVA: 0x1C90380 Offset: 0x1C8F580 VA: 0x181C90380 Slot: 18
	public void ResumeSession() { }

	// RVA: 0x1C8FA50 Offset: 0x1C8EC50 VA: 0x181C8FA50
	private void EndSession(DateTimeOffset timestamp, SessionEndStatus status) { }

	// RVA: 0x1C8F970 Offset: 0x1C8EB70 VA: 0x181C8F970 Slot: 19
	public void EndSession(SessionEndStatus status = 0) { }

	// RVA: 0x1C8FDD0 Offset: 0x1C8EFD0 VA: 0x181C8FDD0
	private ISpan GetLinkedSpan(SentryEvent evt) { }

	// RVA: 0x1C8E150 Offset: 0x1C8D350 VA: 0x181C8E150
	private void ApplyTraceContextToEvent(SentryEvent evt, ISpan span) { }

	// RVA: 0x1C8E420 Offset: 0x1C8D620 VA: 0x181C8E420
	private void ApplyTraceContextToEvent(SentryEvent evt, SentryPropagationContext propagationContext) { }

	// RVA: 0x1C8E9A0 Offset: 0x1C8DBA0 VA: 0x181C8E9A0 Slot: 20
	public SentryId CaptureEvent(SentryEvent evt, Action<Scope> configureScope) { }

	// RVA: 0x1C8E670 Offset: 0x1C8D870 VA: 0x181C8E670
	public SentryId CaptureEvent(SentryEvent evt, Hint hint, Action<Scope> configureScope) { }

	// RVA: 0x1C8E9E0 Offset: 0x1C8DBE0 VA: 0x181C8E9E0 Slot: 22
	public SentryId CaptureEvent(SentryEvent evt, Scope scope) { }

	[NullableContext(2)]
	// RVA: 0x1C8E8D0 Offset: 0x1C8DAD0 VA: 0x181C8E8D0 Slot: 23
	public SentryId CaptureEvent(SentryEvent evt, Hint hint, Scope scope) { }

	[NullableContext(2)]
	// RVA: 0x1C90660 Offset: 0x1C8F860 VA: 0x181C90660 Slot: 4
	private SentryId Sentry.Internal.IHubEx.CaptureEventInternal(SentryEvent evt, Hint hint, Scope scope) { }

	// RVA: 0x1C8F210 Offset: 0x1C8E410 VA: 0x181C8F210 Slot: 24
	public void CaptureUserFeedback(UserFeedback userFeedback) { }

	// RVA: 0x1C8EBF0 Offset: 0x1C8DDF0 VA: 0x181C8EBF0 Slot: 25
	public void CaptureTransaction(Transaction transaction) { }

	// RVA: 0x1C8EC00 Offset: 0x1C8DE00 VA: 0x181C8EC00 Slot: 26
	public void CaptureTransaction(Transaction transaction, Hint hint) { }

	// RVA: 0x1C8EAA0 Offset: 0x1C8DCA0 VA: 0x181C8EAA0 Slot: 27
	public void CaptureSession(SessionUpdate sessionUpdate) { }

	[AsyncStateMachine(typeof(Hub.<FlushAsync>d__55))]
	// RVA: 0x1C8FB70 Offset: 0x1C8ED70 VA: 0x181C8FB70 Slot: 28
	public Task FlushAsync(TimeSpan timeout) { }

	// RVA: 0x1C8F8F0 Offset: 0x1C8EAF0 VA: 0x181C8F8F0 Slot: 35
	public void Dispose() { }

	// RVA: 0x1C91A50 Offset: 0x1C90C50 VA: 0x181C91A50 Slot: 8
	public SentryId get_LastEventId() { }
}

// Namespace: Sentry.Internal
[NullableContext(1)]
internal interface IClientReportRecorder // TypeDefIndex: 13608
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void RecordDiscardedEvent(DiscardReason reason, DataCategory category);

	[NullableContext(2)]
	// RVA: -1 Offset: -1 Slot: 1
	public abstract ClientReport GenerateClientReport();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void Load(ClientReport report);
}

// Namespace: Sentry.Internal
[NullableContext(1)]
internal interface ICloneable<T> // TypeDefIndex: 13609
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract T Clone();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ICloneable<__Il2CppFullySharedGenericType>.Clone
	*/
}

// Namespace: Sentry.Internal
[NullableContext(1)]
internal interface IEnumeration : IComparable // TypeDefIndex: 13610
{
	// Properties
	internal abstract string Value { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	internal abstract string get_Value();
}

// Namespace: Sentry.Internal
internal interface IEnumeration<T> : IEquatable<T>, IComparable<T>, IEnumeration, IComparable // TypeDefIndex: 13611
{}

// Namespace: Sentry.Internal
[NullableContext(1)]
internal interface IFileSystem // TypeDefIndex: 13612
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IEnumerable<string> EnumerateFiles(string path);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IEnumerable<string> EnumerateFiles(string path, string searchPattern);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract IEnumerable<string> EnumerateFiles(string path, string searchPattern, SearchOption searchOption);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void CreateDirectory(string path);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void DeleteDirectory(string path, bool recursive = False);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool DirectoryExists(string path);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool FileExists(string path);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void MoveFile(string sourceFileName, string destFileName, bool overwrite = False);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void DeleteFile(string path);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract DateTimeOffset GetFileCreationTime(string path);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract string ReadAllTextFromFile(string file);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract Stream OpenFileForReading(string path);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract Stream CreateFileForWriting(string path);
}

// Namespace: Sentry.Internal
[NullableContext(2)]
internal interface IHasDistribution // TypeDefIndex: 13613
{
	// Properties
	public abstract string Distribution { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_Distribution();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_Distribution(string value);
}

// Namespace: Sentry.Internal
[NullableContext(1)]
[Extension]
[Nullable(0)]
internal static class HasDistributionExtensions // TypeDefIndex: 13614
{
	// Methods

	[Extension]
	// RVA: 0x1C8E080 Offset: 0x1C8D280 VA: 0x181C8E080
	internal static string GetDistribution(IEventLike obj) { }

	[Extension]
	// RVA: 0x1C8E0E0 Offset: 0x1C8D2E0 VA: 0x181C8E0E0
	internal static void WithDistribution(IEventLike obj, Action<IHasDistribution> action) { }
}

// Namespace: Sentry.Internal
internal interface IHubEx : IHub, ISentryClient, ISentryScopeManager // TypeDefIndex: 13615
{
	// Methods

	[NullableContext(2)]
	// RVA: -1 Offset: -1 Slot: 0
	public abstract SentryId CaptureEventInternal(SentryEvent evt, Hint hint, Scope scope);

	[NullableContext(2)]
	// RVA: -1 Offset: -1 Slot: 1
	public abstract T WithScope<T>(Func<Scope, T> scopeCallback);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IHubEx.WithScope<__Il2CppFullySharedGenericType>
	*/

	[NullableContext(1)]
	// RVA: -1 Offset: -1 Slot: 2
	public abstract Task WithScopeAsync(Func<Scope, Task> scopeCallback);

	[NullableContext(2)]
	// RVA: -1 Offset: -1 Slot: 3
	public abstract Task<T> WithScopeAsync<T>(Func<Scope, Task<T>> scopeCallback);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IHubEx.WithScopeAsync<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: Sentry.Internal
[NullableContext(1)]
internal interface IInternalScopeManager : ISentryScopeManager, IDisposable // TypeDefIndex: 13616
{
	// Properties
	public abstract IScopeStackContainer ScopeStackContainer { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract KeyValuePair<Scope, ISentryClient> GetCurrent();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void RestoreScope(Scope savedScope);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract IScopeStackContainer get_ScopeStackContainer();

	[NullableContext(2)]
	// RVA: -1 Offset: -1 Slot: 3
	public abstract T WithScope<T>(Func<Scope, T> scopeCallback);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IInternalScopeManager.WithScope<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public abstract Task WithScopeAsync(Func<Scope, Task> scopeCallback);

	[NullableContext(2)]
	// RVA: -1 Offset: -1 Slot: 5
	public abstract Task<T> WithScopeAsync<T>(Func<Scope, Task<T>> scopeCallback);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IInternalScopeManager.WithScopeAsync<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: Sentry.Internal
[NullableContext(1)]
internal interface ITransactionProfilerFactory // TypeDefIndex: 13617
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ITransactionProfiler Start(ITransaction transaction, CancellationToken cancellationToken);
}

// Namespace: Sentry.Internal
[NullableContext(1)]
internal interface ITransactionProfiler // TypeDefIndex: 13618
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Finish();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract Task<ProfileInfo> CollectAsync(Transaction transaction);
}

// Namespace: Sentry.Internal
internal interface IUpdatable<T> : IUpdatable // TypeDefIndex: 13619
{
	// Methods

	[NullableContext(1)]
	// RVA: -1 Offset: -1 Slot: 0
	public abstract void UpdateFrom(T source);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IUpdatable<__Il2CppFullySharedGenericType>.UpdateFrom
	*/
}

// Namespace: Sentry.Internal
[NullableContext(1)]
internal interface IUpdatable // TypeDefIndex: 13620
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void UpdateFrom(object source);
}

// Namespace: Sentry.Internal
[Nullable(0)]
[NullableContext(1)]
internal static class Json // TypeDefIndex: 13621
{
	// Methods

	// RVA: -1 Offset: -1
	public static T Parse<T>(byte[] json, Func<JsonElement, T> factory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA2FBD0 Offset: 0xA2EDD0 VA: 0x180A2FBD0
	|-Json.Parse<object>
	|
	|-RVA: 0xA2F9C0 Offset: 0xA2EBC0 VA: 0x180A2F9C0
	|-Json.Parse<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static T Parse<T>(string json, Func<JsonElement, T> factory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA2F7E0 Offset: 0xA2E9E0 VA: 0x180A2F7E0
	|-Json.Parse<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static T Load<T>(string filePath, Func<JsonElement, T> factory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA2F650 Offset: 0xA2E850 VA: 0x180A2F650
	|-Json.Load<object>
	|
	|-RVA: 0xA2F410 Offset: 0xA2E610 VA: 0x180A2F410
	|-Json.Load<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: 
[CompilerGenerated]
private struct Lock.<AcquireAsync>d__2 : IAsyncStateMachine // TypeDefIndex: 13622
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<IDisposable> <>t__builder; // 0x8
	public Lock <>4__this; // 0x20
	public CancellationToken cancellationToken; // 0x28
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x30

	// Methods

	// RVA: 0x1C99AC0 Offset: 0x1C98CC0 VA: 0x181C99AC0 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1C99D20 Offset: 0x1C98F20 VA: 0x181C99D20 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: Sentry.Internal
internal class Lock : IDisposable // TypeDefIndex: 13623
{
	// Fields
	[Nullable(1)]
	private readonly Signal _signal; // 0x10

	// Methods

	// RVA: 0x1C91EB0 Offset: 0x1C910B0 VA: 0x181C91EB0
	public void .ctor() { }

	[AsyncStateMachine(typeof(Lock.<AcquireAsync>d__2))]
	[NullableContext(1)]
	// RVA: 0x1C91D90 Offset: 0x1C90F90 VA: 0x181C91D90
	public Task<IDisposable> AcquireAsync(CancellationToken cancellationToken) { }

	// RVA: 0x1C91E80 Offset: 0x1C91080 VA: 0x181C91E80 Slot: 4
	public void Dispose() { }
}

// Namespace: 
[NullableContext(0)]
private class MainExceptionProcessor.Counter // TypeDefIndex: 13624
{
	// Fields
	private int _value; // 0x10

	// Methods

	// RVA: 0x1B1A140 Offset: 0x1B19340 VA: 0x181B1A140
	public int GetNextValue() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class MainExceptionProcessor.<WalkExceptions>d__12 : IEnumerable<SentryException>, IEnumerable, IEnumerator<SentryException>, IEnumerator, IDisposable // TypeDefIndex: 13625
{
	// Fields
	private int <>1__state; // 0x10
	private SentryException <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	[Nullable(0)]
	private Exception exception; // 0x28
	[Nullable(0)]
	public Exception <>3__exception; // 0x30
	[Nullable(0)]
	private MainExceptionProcessor.Counter counter; // 0x38
	[Nullable(0)]
	public MainExceptionProcessor.Counter <>3__counter; // 0x40
	[Nullable(0)]
	public MainExceptionProcessor <>4__this; // 0x48
	private Nullable<int> parentId; // 0x50
	public Nullable<int> <>3__parentId; // 0x58
	[Nullable(0)]
	private string source; // 0x60
	[Nullable(0)]
	public string <>3__source; // 0x68
	[Nullable(0)]
	private Exception <ex>5__2; // 0x70
	private int <id>5__3; // 0x78
	[Nullable(0)]
	private AggregateException <aex>5__4; // 0x80
	private int <i>5__5; // 0x88
	[Nullable(new[] { 0, 1 })]
	private IEnumerator<SentryException> <>7__wrap5; // 0x90

	// Properties
	private SentryException System.Collections.Generic.IEnumerator<Sentry.Protocol.SentryException>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x5B8720 Offset: 0x5B7920 VA: 0x1805B8720
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x1CA14B0 Offset: 0x1CA06B0 VA: 0x181CA14B0 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1CA0EA0 Offset: 0x1CA00A0 VA: 0x181CA0EA0 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x1CA1510 Offset: 0x1CA0710 VA: 0x181CA1510
	private void <>m__Finally1() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 6
	private SentryException System.Collections.Generic.IEnumerator<Sentry.Protocol.SentryException>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1CA1470 Offset: 0x1CA0670 VA: 0x181CA1470 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1CA13B0 Offset: 0x1CA05B0 VA: 0x181CA13B0 Slot: 4
	private IEnumerator<SentryException> System.Collections.Generic.IEnumerable<Sentry.Protocol.SentryException>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1CA13B0 Offset: 0x1CA05B0 VA: 0x181CA13B0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: Sentry.Internal
[NullableContext(1)]
[Nullable(0)]
internal class MainExceptionProcessor : ISentryEventExceptionProcessor // TypeDefIndex: 13626
{
	// Fields
	private const string ExceptionDataKeyPrefix = "sentry:";
	internal const string ExceptionDataTagKey = "sentry:tag:";
	internal const string ExceptionDataContextKey = "sentry:context:";
	private readonly SentryOptions _options; // 0x10
	[CompilerGenerated]
	private readonly Func<ISentryStackTraceFactory> <SentryStackTraceFactoryAccessor>k__BackingField; // 0x18

	// Properties
	internal Func<ISentryStackTraceFactory> SentryStackTraceFactoryAccessor { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	internal Func<ISentryStackTraceFactory> get_SentryStackTraceFactoryAccessor() { }

	// RVA: 0x441CC0 Offset: 0x440EC0 VA: 0x180441CC0
	public void .ctor(SentryOptions options, Func<ISentryStackTraceFactory> sentryStackTraceFactoryAccessor) { }

	// RVA: 0x1C932C0 Offset: 0x1C924C0 VA: 0x181C932C0 Slot: 4
	public void Process(Exception exception, SentryEvent sentryEvent) { }

	// RVA: 0x1C921B0 Offset: 0x1C913B0 VA: 0x181C921B0
	internal IReadOnlyList<SentryException> CreateSentryExceptions(Exception exception) { }

	// RVA: 0x1C934A0 Offset: 0x1C926A0 VA: 0x181C934A0
	private IEnumerable<SentryException> WalkExceptions(Exception exception) { }

	[IteratorStateMachine(typeof(MainExceptionProcessor.<WalkExceptions>d__12))]
	// RVA: 0x1C93520 Offset: 0x1C92720 VA: 0x181C93520
	private IEnumerable<SentryException> WalkExceptions(Exception exception, MainExceptionProcessor.Counter counter, Nullable<int> parentId, string source) { }

	// RVA: 0x1C92B40 Offset: 0x1C91D40 VA: 0x181C92B40
	private static void MoveExceptionDataToEvent(SentryEvent sentryEvent, IEnumerable<SentryException> sentryExceptions) { }

	// RVA: 0x1C91F90 Offset: 0x1C91190 VA: 0x181C91F90
	private SentryException BuildSentryException(Exception exception, int id, Nullable<int> parentId, string source) { }

	// RVA: 0x1C92300 Offset: 0x1C91500 VA: 0x181C92300
	private static Mechanism GetMechanism(Exception exception, int id, Nullable<int> parentId, string source) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class MainSentryEventProcessor.<>c__DisplayClass17_0 // TypeDefIndex: 13627
{
	// Fields
	[Nullable(new[] { 0, 1, 1 })]
	public IDictionary<string, string> cultureInfoMapped; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	[NullableContext(0)]
	// RVA: 0x1CA0A40 Offset: 0x1C9FC40 VA: 0x181CA0A40
	internal bool <Process>b__0(KeyValuePair<string, string> p) { }
}

// Namespace: Sentry.Internal
[Nullable(0)]
[NullableContext(1)]
internal class MainSentryEventProcessor : ISentryEventProcessor // TypeDefIndex: 13628
{
	// Fields
	internal const string CultureInfoKey = "Current Culture";
	internal const string CurrentUiCultureKey = "Current UI Culture";
	internal const string MemoryInfoKey = "Memory Info";
	internal const string ThreadPoolInfoKey = "ThreadPool Info";
	internal const string IsDynamicCodeKey = "Dynamic Code";
	internal const string IsDynamicCodeCompiledKey = "Compiled";
	internal const string IsDynamicCodeSupportedKey = "Supported";
	private readonly Enricher _enricher; // 0x10
	private readonly SentryOptions _options; // 0x18
	[CompilerGenerated]
	private readonly Func<ISentryStackTraceFactory> <SentryStackTraceFactoryAccessor>k__BackingField; // 0x20

	// Properties
	internal Func<ISentryStackTraceFactory> SentryStackTraceFactoryAccessor { get; }
	[Nullable(2)]
	internal string Release { get; }
	[Nullable(2)]
	internal string Distribution { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	internal Func<ISentryStackTraceFactory> get_SentryStackTraceFactoryAccessor() { }

	[NullableContext(2)]
	// RVA: 0x1C945B0 Offset: 0x1C937B0 VA: 0x181C945B0
	internal string get_Release() { }

	[NullableContext(2)]
	// RVA: 0x1C94590 Offset: 0x1C93790 VA: 0x181C94590
	internal string get_Distribution() { }

	// RVA: 0x1C94510 Offset: 0x1C93710 VA: 0x181C94510
	public void .ctor(SentryOptions options, Func<ISentryStackTraceFactory> sentryStackTraceFactoryAccessor) { }

	// RVA: 0x1C93900 Offset: 0x1C92B00 VA: 0x181C93900 Slot: 4
	public SentryEvent Process(SentryEvent event) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	private static void AddMemoryInfo(Contexts contexts) { }

	// RVA: 0x1C935D0 Offset: 0x1C927D0 VA: 0x181C935D0
	private static void AddThreadPoolInfo(Contexts contexts) { }

	// RVA: 0x1C93720 Offset: 0x1C92920 VA: 0x181C93720
	private static IDictionary<string, string> CultureInfoToDictionary(CultureInfo cultureInfo) { }
}

// Namespace: Sentry.Internal
[Nullable(0)]
[NullableContext(1)]
internal class NoOpSpan : ISpan, ISpanData, ISpanContext, ITraceContext, IHasTags, IHasExtra // TypeDefIndex: 13629
{
	// Fields
	[CompilerGenerated]
	private static readonly ISpan <Instance>k__BackingField; // 0x0

	// Properties
	public static ISpan Instance { get; }
	public SpanId SpanId { get; }
	public Nullable<SpanId> ParentSpanId { get; }
	public SentryId TraceId { get; }
	public Nullable<bool> IsSampled { get; }
	public IReadOnlyDictionary<string, string> Tags { get; }
	[Nullable(new[] { 1, 1, 2 })]
	public IReadOnlyDictionary<string, object> Extra { get; }
	public DateTimeOffset StartTimestamp { get; }
	public Nullable<DateTimeOffset> EndTimestamp { get; }
	public bool IsFinished { get; }
	public string Operation { get; set; }
	[Nullable(2)]
	public string Description { get; set; }
	public Nullable<SpanStatus> Status { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1C946E0 Offset: 0x1C938E0 VA: 0x181C946E0
	public static ISpan get_Instance() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }

	// RVA: 0x1C947F0 Offset: 0x1C939F0 VA: 0x181C947F0 Slot: 19
	public SpanId get_SpanId() { }

	// RVA: 0x1C94770 Offset: 0x1C93970 VA: 0x181C94770 Slot: 20
	public Nullable<SpanId> get_ParentSpanId() { }

	// RVA: 0x1C94890 Offset: 0x1C93A90 VA: 0x181C94890 Slot: 21
	public SentryId get_TraceId() { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 25
	public Nullable<bool> get_IsSampled() { }

	// RVA: 0x1C94840 Offset: 0x1C93A40 VA: 0x181C94840 Slot: 26
	public IReadOnlyDictionary<string, string> get_Tags() { }

	// RVA: 0x1C94690 Offset: 0x1C93890 VA: 0x181C94690 Slot: 29
	public IReadOnlyDictionary<string, object> get_Extra() { }

	// RVA: 0x9E8FF0 Offset: 0x9E81F0 VA: 0x1809E8FF0 Slot: 15
	public DateTimeOffset get_StartTimestamp() { }

	// RVA: 0x9E9000 Offset: 0x9E8200 VA: 0x1809E9000 Slot: 16
	public Nullable<DateTimeOffset> get_EndTimestamp() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 17
	public bool get_IsFinished() { }

	// RVA: 0x1C94730 Offset: 0x1C93930 VA: 0x181C94730 Slot: 22
	public string get_Operation() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 7
	public void set_Operation(string value) { }

	[NullableContext(2)]
	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 23
	public string get_Description() { }

	[NullableContext(2)]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 5
	public void set_Description(string value) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 24
	public Nullable<SpanStatus> get_Status() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 9
	public void set_Status(Nullable<SpanStatus> value) { }

	// RVA: 0x937670 Offset: 0x936870 VA: 0x180937670 Slot: 10
	public ISpan StartChild(string operation) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 11
	public void Finish() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 12
	public void Finish(SpanStatus status) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 13
	public void Finish(Exception exception, SpanStatus status) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 14
	public void Finish(Exception exception) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 27
	public void SetTag(string key, string value) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 28
	public void UnsetTag(string key) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 30
	public void SetExtra(string key, object value) { }

	// RVA: 0x1C945E0 Offset: 0x1C937E0 VA: 0x181C945E0 Slot: 18
	public SentryTraceHeader GetTraceHeader() { }

	// RVA: 0x1C94630 Offset: 0x1C93830 VA: 0x181C94630
	private static void .cctor() { }
}

// Namespace: Sentry.Internal
[Nullable(0)]
[NullableContext(1)]
internal class NoOpTransaction : NoOpSpan, ITransaction, ITransactionData, ISpanData, ISpanContext, ITraceContext, IHasTags, IHasExtra, ITransactionContext, IEventLike, IHasBreadcrumbs, ISpan // TypeDefIndex: 13630
{
	// Fields
	[CompilerGenerated]
	private static readonly ITransaction <Instance>k__BackingField; // 0x0

	// Properties
	public static ITransaction Instance { get; }
	public SdkVersion Sdk { get; }
	public string Name { get; set; }
	public Nullable<bool> IsParentSampled { get; set; }
	public Nullable<SentryLevel> Level { get; set; }
	public Request Request { get; set; }
	public Contexts Contexts { get; set; }
	public User User { get; set; }
	[Nullable(2)]
	public string Platform { get; set; }
	[Nullable(2)]
	public string Release { get; set; }
	[Nullable(2)]
	public string Environment { get; set; }
	[Nullable(2)]
	public string TransactionName { get; set; }
	public IReadOnlyList<string> Fingerprint { get; set; }
	public IReadOnlyCollection<ISpan> Spans { get; }
	public IReadOnlyCollection<Breadcrumb> Breadcrumbs { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1C94AC0 Offset: 0x1C93CC0 VA: 0x181C94AC0
	public static ITransaction get_Instance() { }

	// RVA: 0x1C94980 Offset: 0x1C93B80 VA: 0x181C94980
	private void .ctor() { }

	// RVA: 0x1C94BA0 Offset: 0x1C93DA0 VA: 0x181C94BA0 Slot: 55
	public SdkVersion get_Sdk() { }

	// RVA: 0x1C94B10 Offset: 0x1C93D10 VA: 0x181C94B10 Slot: 37
	public string get_Name() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 32
	public void set_Name(string value) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 38
	public Nullable<bool> get_IsParentSampled() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 34
	public void set_IsParentSampled(Nullable<bool> value) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 39
	public Nullable<SentryLevel> get_Level() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 40
	public void set_Level(Nullable<SentryLevel> value) { }

	// RVA: 0x1C94B50 Offset: 0x1C93D50 VA: 0x181C94B50 Slot: 41
	public Request get_Request() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 42
	public void set_Request(Request value) { }

	// RVA: 0x1C94A20 Offset: 0x1C93C20 VA: 0x181C94A20 Slot: 43
	public Contexts get_Contexts() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 44
	public void set_Contexts(Contexts value) { }

	// RVA: 0x1C94C30 Offset: 0x1C93E30 VA: 0x181C94C30 Slot: 45
	public User get_User() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 46
	public void set_User(User value) { }

	[NullableContext(2)]
	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 47
	public string get_Platform() { }

	[NullableContext(2)]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 48
	public void set_Platform(string value) { }

	[NullableContext(2)]
	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 49
	public string get_Release() { }

	[NullableContext(2)]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 50
	public void set_Release(string value) { }

	[NullableContext(2)]
	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 51
	public string get_Environment() { }

	[NullableContext(2)]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 52
	public void set_Environment(string value) { }

	[NullableContext(2)]
	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 53
	public string get_TransactionName() { }

	[NullableContext(2)]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 54
	public void set_TransactionName(string value) { }

	// RVA: 0x1C94A70 Offset: 0x1C93C70 VA: 0x181C94A70 Slot: 56
	public IReadOnlyList<string> get_Fingerprint() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 57
	public void set_Fingerprint(IReadOnlyList<string> value) { }

	// RVA: 0x1C94BE0 Offset: 0x1C93DE0 VA: 0x181C94BE0 Slot: 35
	public IReadOnlyCollection<ISpan> get_Spans() { }

	// RVA: 0x1C949D0 Offset: 0x1C93BD0 VA: 0x181C949D0 Slot: 58
	public IReadOnlyCollection<Breadcrumb> get_Breadcrumbs() { }

	[NullableContext(2)]
	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 36
	public ISpan GetLastActiveSpan() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 59
	public void AddBreadcrumb(Breadcrumb breadcrumb) { }

	// RVA: 0x1C948F0 Offset: 0x1C93AF0 VA: 0x181C948F0
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class ObjectExtensions.<>c // TypeDefIndex: 13631
{
	// Fields
	[Nullable(0)]
	public static readonly ObjectExtensions.<>c <>9; // 0x0
	[Nullable(new[] { 0, 1, 1, 1, 2 })]
	public static ConditionalWeakTable.CreateValueCallback<object, Dictionary<string, object>> <>9__3_0; // 0x8

	// Methods

	// RVA: 0x1CA0DE0 Offset: 0x1C9FFE0 VA: 0x181CA0DE0
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1CA0320 Offset: 0x1C9F520 VA: 0x181CA0320
	internal Dictionary<string, object> <AssociatedProperties>b__3_0(object _) { }
}

// Namespace: Sentry.Internal
[Nullable(0)]
[Extension]
[NullableContext(1)]
internal static class ObjectExtensions // TypeDefIndex: 13632
{
	// Fields
	[CompilerGenerated]
	[Nullable(new[] { 1, 1, 1, 1, 2 })]
	private static readonly ConditionalWeakTable<object, Dictionary<string, object>> <Map>k__BackingField; // 0x0

	// Properties
	[Nullable(new[] { 1, 1, 1, 1, 2 })]
	private static ConditionalWeakTable<object, Dictionary<string, object>> Map { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1C95040 Offset: 0x1C94240 VA: 0x181C95040
	private static ConditionalWeakTable<object, Dictionary<string, object>> get_Map() { }

	[Extension]
	// RVA: 0x1C94C80 Offset: 0x1C93E80 VA: 0x181C94C80
	private static Dictionary<string, object> AssociatedProperties(object source) { }

	[Extension]
	// RVA: 0x1C94DF0 Offset: 0x1C93FF0 VA: 0x181C94DF0
	public static void SetFused(object source, string propertyName, object value) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static void SetFused<T>(object source, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA57820 Offset: 0xA56A20 VA: 0x180A57820
	|-ObjectExtensions.SetFused<object>
	|
	|-RVA: 0xA576D0 Offset: 0xA568D0 VA: 0x180A576D0
	|-ObjectExtensions.SetFused<__Il2CppFullySharedGenericType>
	*/

	[NullableContext(2)]
	[Extension]
	// RVA: -1 Offset: -1
	public static T GetFused<T>(object source, string propertyName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA575D0 Offset: 0xA567D0 VA: 0x180A575D0
	|-ObjectExtensions.GetFused<object>
	|
	|-RVA: 0xA57410 Offset: 0xA56610 VA: 0x180A57410
	|-ObjectExtensions.GetFused<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1C94FD0 Offset: 0x1C941D0 VA: 0x181C94FD0
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
private struct PartialStream.<ReadAsync>d__16 : IAsyncStateMachine // TypeDefIndex: 13633
{
	// Fields
	public int <>1__state; // 0x0
	[Nullable(0)]
	public AsyncTaskMethodBuilder<int> <>t__builder; // 0x8
	[Nullable(0)]
	public PartialStream <>4__this; // 0x20
	public int count; // 0x28
	[Nullable(0)]
	public byte[] buffer; // 0x30
	public int offset; // 0x38
	public CancellationToken cancellationToken; // 0x40
	[Nullable(0)]
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int> <>u__1; // 0x48

	// Methods

	// RVA: 0x1C9DFD0 Offset: 0x1C9D1D0 VA: 0x181C9DFD0 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1C9E3A0 Offset: 0x1C9D5A0 VA: 0x181C9E3A0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: Sentry.Internal
[Nullable(0)]
[NullableContext(1)]
internal class PartialStream : Stream // TypeDefIndex: 13634
{
	// Fields
	private readonly Stream _innerStream; // 0x28
	private readonly long _offset; // 0x30
	private readonly Nullable<long> _length; // 0x38
	private long _position; // 0x48

	// Properties
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x1C954E0 Offset: 0x1C946E0 VA: 0x181C954E0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x557000 Offset: 0x556200 VA: 0x180557000 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x1C95510 Offset: 0x1C94710 VA: 0x181C95510 Slot: 11
	public override long get_Length() { }

	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0 Slot: 12
	public override long get_Position() { }

	// RVA: 0x1C95590 Offset: 0x1C94790 VA: 0x181C95590 Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x1C95460 Offset: 0x1C94660 VA: 0x181C95460
	public void .ctor(Stream innerStream, long offset, Nullable<long> length) { }

	[AsyncStateMachine(typeof(PartialStream.<ReadAsync>d__16))]
	// RVA: 0x1C95090 Offset: 0x1C94290 VA: 0x181C95090 Slot: 26
	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x1C952B0 Offset: 0x1C944B0 VA: 0x181C952B0 Slot: 32
	public override long Seek(long offset, SeekOrigin origin) { }

	[ExcludeFromCodeCoverage]
	// RVA: 0x1C951D0 Offset: 0x1C943D0 VA: 0x181C951D0 Slot: 34
	public override int Read(byte[] buffer, int offset, int count) { }

	[ExcludeFromCodeCoverage]
	// RVA: 0x1C953E0 Offset: 0x1C945E0 VA: 0x181C953E0 Slot: 33
	public override void SetLength(long value) { }

	[ExcludeFromCodeCoverage]
	// RVA: 0x1C95420 Offset: 0x1C94620 VA: 0x181C95420 Slot: 37
	public override void Write(byte[] buffer, int offset, int count) { }

	[ExcludeFromCodeCoverage]
	// RVA: 0x173D3E0 Offset: 0x173C5E0 VA: 0x18173D3E0 Slot: 22
	public override void Flush() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class PiiExtensions.<>c // TypeDefIndex: 13635
{
	// Fields
	[Nullable(0)]
	public static readonly PiiExtensions.<>c <>9; // 0x0
	[Nullable(0)]
	public static MatchEvaluator <>9__3_0; // 0x8

	// Methods

	// RVA: 0x1CA0C60 Offset: 0x1C9FE60 VA: 0x181CA0C60
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	[NullableContext(0)]
	// RVA: 0x1CA05A0 Offset: 0x1C9F7A0 VA: 0x181CA05A0
	internal string <RedactUrl>b__3_0(Match match) { }
}

// Namespace: Sentry.Internal
[Extension]
[Nullable(0)]
[NullableContext(1)]
internal static class PiiExtensions // TypeDefIndex: 13636
{
	// Fields
	internal const string RedactedText = "[Filtered]";
	private static readonly Regex AuthRegex; // 0x0
	private static readonly Regex UserInfoMatcher; // 0x8

	// Methods

	[Extension]
	// RVA: 0x1C95850 Offset: 0x1C94A50 VA: 0x181C95850
	public static string RedactUrl(string data) { }

	// RVA: 0x1C95640 Offset: 0x1C94840 VA: 0x181C95640
	private static string RedactAuth(string data) { }

	// RVA: 0x1C959A0 Offset: 0x1C94BA0 VA: 0x181C959A0
	private static void .cctor() { }
}

// Namespace: Sentry.Internal
[Nullable(0)]
[NullableContext(1)]
[IsReadOnly]
internal struct PooledBuffer<T> : IDisposable // TypeDefIndex: 13637
{
	// Fields
	[CompilerGenerated]
	private readonly T[] <Array>k__BackingField; // 0x0

	// Properties
	public T[] Array { get; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public T[] get_Array() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	|-PooledBuffer<byte>.get_Array
	|-PooledBuffer<__Il2CppFullySharedGenericType>.get_Array
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int minimumLength) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB838F0 Offset: 0xB82AF0 VA: 0x180B838F0
	|-PooledBuffer<byte>..ctor
	|
	|-RVA: 0xB83850 Offset: 0xB82A50 VA: 0x180B83850
	|-PooledBuffer<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB836D0 Offset: 0xB828D0 VA: 0x180B836D0
	|-PooledBuffer<byte>.Dispose
	|
	|-RVA: 0xB83760 Offset: 0xB82960 VA: 0x180B83760
	|-PooledBuffer<__Il2CppFullySharedGenericType>.Dispose
	*/
}

// Namespace: 
[CompilerGenerated]
private static class ProcessInfo.<>O // TypeDefIndex: 13638
{
	// Fields
	[Nullable(0)]
	public static Func<DateTimeOffset> <0>__GetStartupTime; // 0x0
}

// Namespace: 
[CompilerGenerated]
private sealed class ProcessInfo.<>c__DisplayClass12_0 // TypeDefIndex: 13639
{
	// Fields
	[Nullable(0)]
	public ProcessInfo <>4__this; // 0x10
	[Nullable(0)]
	public SentryOptions options; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	[NullableContext(0)]
	// RVA: 0x1CA0890 Offset: 0x1C9FA90 VA: 0x181CA0890
	internal Task <.ctor>b__1(Task _) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ProcessInfo.<>c__DisplayClass12_1 // TypeDefIndex: 13640
{
	// Fields
	[Nullable(0)]
	public Func<DateTimeOffset> preciseStartupTimeFunc; // 0x10
	[Nullable(0)]
	public ProcessInfo.<>c__DisplayClass12_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1CA0940 Offset: 0x1C9FB40 VA: 0x181CA0940
	internal void <.ctor>b__0() { }
}

// Namespace: Sentry.Internal
[NullableContext(1)]
[Nullable(0)]
internal class ProcessInfo // TypeDefIndex: 13641
{
	// Fields
	[Nullable(2)]
	internal static ProcessInfo Instance; // 0x0
	[CompilerGenerated]
	private Nullable<DateTimeOffset> <StartupTime>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly Nullable<DateTimeOffset> <BootTime>k__BackingField; // 0x28
	private Task _preciseAppStartupTask; // 0x40

	// Properties
	internal Nullable<DateTimeOffset> StartupTime { get; set; }
	internal Nullable<DateTimeOffset> BootTime { get; }
	internal Task PreciseAppStartupTask { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x44F1F0 Offset: 0x44E3F0 VA: 0x18044F1F0
	internal Nullable<DateTimeOffset> get_StartupTime() { }

	[CompilerGenerated]
	// RVA: 0x44F220 Offset: 0x44E420 VA: 0x18044F220
	private void set_StartupTime(Nullable<DateTimeOffset> value) { }

	[CompilerGenerated]
	// RVA: 0x4E6990 Offset: 0x4E5B90 VA: 0x1804E6990
	internal Nullable<DateTimeOffset> get_BootTime() { }

	// RVA: 0x1C96150 Offset: 0x1C95350 VA: 0x181C96150
	internal Task get_PreciseAppStartupTask() { }

	// RVA: 0x1C96170 Offset: 0x1C95370 VA: 0x181C96170
	private void set_PreciseAppStartupTask(Task value) { }

	// RVA: 0x1C95BA0 Offset: 0x1C94DA0 VA: 0x181C95BA0
	internal void .ctor(SentryOptions options, Func<DateTimeOffset> findPreciseStartupTime) { }

	// RVA: 0x1C95A60 Offset: 0x1C94C60 VA: 0x181C95A60
	private static DateTimeOffset GetStartupTime() { }
}

// Namespace: Sentry.Internal
internal abstract class RandomValuesFactory // TypeDefIndex: 13642
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract int NextInt();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract int NextInt(int minValue, int maxValue);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract double NextDouble();

	[NullableContext(1)]
	// RVA: -1 Offset: -1 Slot: 7
	public abstract void NextBytes(byte[] bytes);

	// RVA: 0x1C961A0 Offset: 0x1C953A0 VA: 0x181C961A0
	public bool NextBool(double rate) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: Sentry.Internal
[Nullable(0)]
[NullableContext(1)]
internal class SdkComposer // TypeDefIndex: 13643
{
	// Fields
	private readonly SentryOptions _options; // 0x10

	// Methods

	// RVA: 0x1C97C00 Offset: 0x1C96E00 VA: 0x181C97C00
	public void .ctor(SentryOptions options) { }

	// RVA: 0x1C97AB0 Offset: 0x1C96CB0 VA: 0x181C97AB0
	private ITransport CreateTransport() { }

	// RVA: 0x1C979E0 Offset: 0x1C96BE0 VA: 0x181C979E0
	private LazyHttpTransport CreateHttpTransport() { }

	// RVA: 0x1C97690 Offset: 0x1C96890 VA: 0x181C97690
	public IBackgroundWorker CreateBackgroundWorker() { }
}

// Namespace: 
[Nullable(0)]
private sealed class SentryScopeManager.ScopeSnapshot : IDisposable // TypeDefIndex: 13644
{
	// Fields
	private readonly SentryOptions _options; // 0x10
	[Nullable(new[] { 1, 0, 1, 1 })]
	private readonly KeyValuePair<Scope, ISentryClient>[] _snapshot; // 0x18
	private readonly SentryScopeManager _scopeManager; // 0x20

	// Methods

	// RVA: 0x3F6C30 Offset: 0x3F5E30 VA: 0x1803F6C30
	public void .ctor(SentryOptions options, KeyValuePair<Scope, ISentryClient>[] snapshot, SentryScopeManager scopeManager) { }

	// RVA: 0x1C975A0 Offset: 0x1C967A0 VA: 0x181C975A0 Slot: 4
	public void Dispose() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class SentryScopeManager.<>c__DisplayClass12_0 // TypeDefIndex: 13645
{
	// Fields
	[Nullable(0)]
	public SentryOptions options; // 0x10
	[Nullable(0)]
	public ISentryClient rootClient; // 0x18

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1CA07B0 Offset: 0x1C9F9B0 VA: 0x181CA07B0
	internal KeyValuePair<Scope, ISentryClient>[] <.ctor>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private struct SentryScopeManager.<WithScopeAsync>d__21 : IAsyncStateMachine // TypeDefIndex: 13646
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	[Nullable(0)]
	public SentryScopeManager <>4__this; // 0x20
	[Nullable(new[] { 0, 1, 1 })]
	public Func<Scope, Task> scopeCallback; // 0x28
	[Nullable(0)]
	private IDisposable <>7__wrap1; // 0x30
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x38

	// Methods

	// RVA: 0x1CA1570 Offset: 0x1CA0770 VA: 0x181CA1570 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1CA1960 Offset: 0x1CA0B60 VA: 0x181CA1960 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct SentryScopeManager.<WithScopeAsync>d__22<T> : IAsyncStateMachine // TypeDefIndex: 13647
{
	// Fields
	public int <>1__state; // 0x0
	[Nullable(0)]
	public AsyncTaskMethodBuilder<T> <>t__builder; // 0x0
	[Nullable(0)]
	public SentryScopeManager <>4__this; // 0x0
	[Nullable(new[] { 0, 1, 1, 2 })]
	public Func<Scope, Task<T>> scopeCallback; // 0x0
	[Nullable(0)]
	private IDisposable <>7__wrap1; // 0x0
	[Nullable(new[] { 0, 2 })]
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<T> <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF55F50 Offset: 0xF55150 VA: 0x180F55F50
	|-SentryScopeManager.<WithScopeAsync>d__22<__Il2CppFullySharedGenericType>.MoveNext
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF56670 Offset: 0xF55870 VA: 0x180F56670
	|-SentryScopeManager.<WithScopeAsync>d__22<__Il2CppFullySharedGenericType>.SetStateMachine
	*/
}

// Namespace: Sentry.Internal
[Nullable(0)]
[NullableContext(1)]
internal sealed class SentryScopeManager : IInternalScopeManager, ISentryScopeManager, IDisposable // TypeDefIndex: 13648
{
	// Fields
	[CompilerGenerated]
	private readonly IScopeStackContainer <ScopeStackContainer>k__BackingField; // 0x10
	private readonly SentryOptions _options; // 0x18
	[Nullable(new[] { 1, 1, 0, 1, 1 })]
	[CompilerGenerated]
	private readonly Func<KeyValuePair<Scope, ISentryClient>[]> <NewStack>k__BackingField; // 0x20

	// Properties
	public IScopeStackContainer ScopeStackContainer { get; }
	[Nullable(new[] { 1, 0, 1, 1 })]
	private KeyValuePair<Scope, ISentryClient>[] ScopeAndClientStack { get; set; }
	[Nullable(new[] { 1, 1, 0, 1, 1 })]
	private Func<KeyValuePair<Scope, ISentryClient>[]> NewStack { get; }
	private bool IsGlobalMode { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0 Slot: 6
	public IScopeStackContainer get_ScopeStackContainer() { }

	// RVA: 0x1C98880 Offset: 0x1C97A80 VA: 0x181C98880
	private KeyValuePair<Scope, ISentryClient>[] get_ScopeAndClientStack() { }

	// RVA: 0x1C98980 Offset: 0x1C97B80 VA: 0x181C98980
	private void set_ScopeAndClientStack(KeyValuePair<Scope, ISentryClient>[] value) { }

	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	private Func<KeyValuePair<Scope, ISentryClient>[]> get_NewStack() { }

	// RVA: 0x1C98800 Offset: 0x1C97A00 VA: 0x181C98800
	private bool get_IsGlobalMode() { }

	// RVA: 0x1C986B0 Offset: 0x1C978B0 VA: 0x181C986B0
	public void .ctor(SentryOptions options, ISentryClient rootClient) { }

	// RVA: 0x1C98140 Offset: 0x1C97340 VA: 0x181C98140 Slot: 4
	public KeyValuePair<Scope, ISentryClient> GetCurrent() { }

	// RVA: 0x1C97FF0 Offset: 0x1C971F0 VA: 0x181C97FF0 Slot: 10
	public void ConfigureScope(Action<Scope> configureScope) { }

	// RVA: 0x1C97EA0 Offset: 0x1C970A0 VA: 0x181C97EA0 Slot: 11
	public Task ConfigureScopeAsync(Func<Scope, Task> configureScope) { }

	// RVA: 0x1C98190 Offset: 0x1C97390 VA: 0x181C98190 Slot: 13
	public IDisposable PushScope() { }

	[NullableContext(2)]
	// RVA: -1 Offset: -1 Slot: 14
	public IDisposable PushScope<TState>(TState state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA6B820 Offset: 0xA6AA20 VA: 0x180A6B820
	|-SentryScopeManager.PushScope<object>
	|
	|-RVA: 0xA6B4B0 Offset: 0xA6A6B0 VA: 0x180A6B4B0
	|-SentryScopeManager.PushScope<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1C981D0 Offset: 0x1C973D0 VA: 0x181C981D0 Slot: 5
	public void RestoreScope(Scope savedScope) { }

	// RVA: 0x1C98510 Offset: 0x1C97710 VA: 0x181C98510 Slot: 15
	public void WithScope(Action<Scope> scopeCallback) { }

	[NullableContext(2)]
	// RVA: -1 Offset: -1 Slot: 7
	public T WithScope<T>(Func<Scope, T> scopeCallback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA6BBD0 Offset: 0xA6ADD0 VA: 0x180A6BBD0
	|-SentryScopeManager.WithScope<__Il2CppFullySharedGenericType>
	*/

	[AsyncStateMachine(typeof(SentryScopeManager.<WithScopeAsync>d__21))]
	// RVA: 0x1C98430 Offset: 0x1C97630 VA: 0x181C98430 Slot: 8
	public Task WithScopeAsync(Func<Scope, Task> scopeCallback) { }

	[AsyncStateMachine(typeof(SentryScopeManager.<WithScopeAsync>d__22<T>))]
	[NullableContext(2)]
	// RVA: -1 Offset: -1 Slot: 9
	public Task<T> WithScopeAsync<T>(Func<Scope, Task<T>> scopeCallback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA6BAD0 Offset: 0xA6ACD0 VA: 0x180A6BAD0
	|-SentryScopeManager.WithScopeAsync<__Il2CppFullySharedGenericType>
	*/

	[NullableContext(2)]
	// RVA: 0x1C97CE0 Offset: 0x1C96EE0 VA: 0x181C97CE0 Slot: 12
	public void BindClient(ISentryClient client) { }

	// RVA: 0x1C980D0 Offset: 0x1C972D0 VA: 0x181C980D0 Slot: 16
	public void Dispose() { }
}

// Namespace: Sentry.Internal
internal struct SentryStopwatch // TypeDefIndex: 13649
{
	// Fields
	private static readonly double StopwatchTicksPerTimeSpanTick; // 0x0
	private long _startTimestamp; // 0x0
	private DateTimeOffset _startDateTimeOffset; // 0x8

	// Properties
	public DateTimeOffset StartDateTimeOffset { get; }
	public DateTimeOffset CurrentDateTimeOffset { get; }
	public TimeSpan Elapsed { get; }

	// Methods

	// RVA: 0x1C989E0 Offset: 0x1C97BE0 VA: 0x181C989E0
	public static SentryStopwatch StartNew() { }

	// RVA: 0x42C4A0 Offset: 0x42B6A0 VA: 0x18042C4A0
	public DateTimeOffset get_StartDateTimeOffset() { }

	// RVA: 0x1C98AF0 Offset: 0x1C97CF0 VA: 0x181C98AF0
	public DateTimeOffset get_CurrentDateTimeOffset() { }

	// RVA: 0x1C98BA0 Offset: 0x1C97DA0 VA: 0x181C98BA0
	public TimeSpan get_Elapsed() { }

	// RVA: 0x1C98A70 Offset: 0x1C97C70 VA: 0x181C98A70
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
private struct SerializableExtensions.<SerializeToStringAsync>d__0 : IAsyncStateMachine // TypeDefIndex: 13650
{
	// Fields
	public int <>1__state; // 0x0
	[Nullable(0)]
	public AsyncTaskMethodBuilder<string> <>t__builder; // 0x8
	[Nullable(0)]
	public ISystemClock clock; // 0x20
	[Nullable(0)]
	public ISerializable serializable; // 0x28
	[Nullable(0)]
	public IDiagnosticLogger logger; // 0x30
	public CancellationToken cancellationToken; // 0x38
	[Nullable(0)]
	private MemoryStream <stream>5__2; // 0x40
	[Nullable(0)]
	private MemoryStream <>7__wrap2; // 0x48
	[Nullable(0)]
	private StreamReader <reader>5__4; // 0x50
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x58
	[Nullable(0)]
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<string> <>u__2; // 0x68

	// Methods

	// RVA: 0x1C9FA50 Offset: 0x1C9EC50 VA: 0x181C9FA50 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1CA02B0 Offset: 0x1C9F4B0 VA: 0x181CA02B0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: Sentry.Internal
[Extension]
[Nullable(0)]
[NullableContext(1)]
internal static class SerializableExtensions // TypeDefIndex: 13651
{
	// Methods

	[Extension]
	[AsyncStateMachine(typeof(SerializableExtensions.<SerializeToStringAsync>d__0))]
	// RVA: 0x1C98C70 Offset: 0x1C97E70 VA: 0x181C98C70
	public static Task<string> SerializeToStringAsync(ISerializable serializable, IDiagnosticLogger logger, ISystemClock clock, CancellationToken cancellationToken) { }

	[Extension]
	// RVA: 0x1C98DB0 Offset: 0x1C97FB0 VA: 0x181C98DB0
	public static string SerializeToString(ISerializable serializable, IDiagnosticLogger logger, ISystemClock clock) { }
}

// Namespace: Sentry.Internal
[NullableContext(2)]
[Nullable(0)]
internal class SettingLocator // TypeDefIndex: 13652
{
	// Fields
	[Nullable(1)]
	private readonly SentryOptions _options; // 0x10
	[CompilerGenerated]
	private Assembly <AssemblyForAttributes>k__BackingField; // 0x18

	// Properties
	public Assembly AssemblyForAttributes { get; set; }

	// Methods

	[NullableContext(1)]
	// RVA: 0x1C99500 Offset: 0x1C98700 VA: 0x181C99500
	public void .ctor(SentryOptions options) { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public Assembly get_AssemblyForAttributes() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	protected void set_AssemblyForAttributes(Assembly value) { }

	[NullableContext(1)]
	// RVA: 0x1C99150 Offset: 0x1C98350 VA: 0x181C99150 Slot: 4
	public virtual string GetEnvironmentVariable(string variable) { }

	[NullableContext(1)]
	// RVA: 0x1C99080 Offset: 0x1C98280 VA: 0x181C99080
	public string GetDsn() { }

	[NullableContext(1)]
	// RVA: 0x1C99160 Offset: 0x1C98360 VA: 0x181C99160
	public string GetEnvironment() { }

	// RVA: 0x1C99250 Offset: 0x1C98450 VA: 0x181C99250
	public string GetEnvironment(bool useDefaultIfNotFound) { }

	// RVA: 0x1C99380 Offset: 0x1C98580 VA: 0x181C99380
	public string GetRelease() { }
}

// Namespace: Sentry.Internal
[Nullable(0)]
[NullableContext(1)]
internal class Signal : IDisposable // TypeDefIndex: 13653
{
	// Fields
	private readonly object _lock; // 0x10
	private readonly SemaphoreSlim _semaphore; // 0x18

	// Methods

	// RVA: 0x1C99650 Offset: 0x1C98850 VA: 0x181C99650
	public void .ctor(bool isReleasedInitially = False) { }

	// RVA: 0x1C99560 Offset: 0x1C98760 VA: 0x181C99560
	public void Release() { }

	// RVA: 0x1C99630 Offset: 0x1C98830 VA: 0x181C99630
	public Task WaitAsync(CancellationToken cancellationToken) { }

	// RVA: 0x1C99540 Offset: 0x1C98740 VA: 0x181C99540 Slot: 4
	public void Dispose() { }
}

// Namespace: Sentry.Internal
[DefaultMember("Item")]
[Nullable(0)]
[NullableContext(1)]
internal sealed class SparseScalarArray<T> // TypeDefIndex: 13654
{
	// Fields
	[Nullable(new[] { 0, 1 })]
	private GrowableArray<T> _items; // 0x0
	private T _uninitializedValue; // 0x0

	// Properties
	public T Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T uninitializedValue, int capacity = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC3C2D0 Offset: 0xC3B4D0 VA: 0x180C3C2D0
	|-SparseScalarArray<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC3C400 Offset: 0xC3B600 VA: 0x180C3C400
	|-SparseScalarArray<__Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1
	public void set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC3C4F0 Offset: 0xC3B6F0 VA: 0x180C3C4F0
	|-SparseScalarArray<__Il2CppFullySharedGenericType>.set_Item
	*/

	// RVA: -1 Offset: -1
	public bool ContainsKey(int key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC3C030 Offset: 0xC3B230 VA: 0x180C3C030
	|-SparseScalarArray<__Il2CppFullySharedGenericType>.ContainsKey
	*/
}

// Namespace: Sentry.Internal
[Nullable(0)]
[NullableContext(1)]
internal class SynchronizedRandomValuesFactory : RandomValuesFactory // TypeDefIndex: 13655
{
	// Fields
	private static readonly AsyncLocal<Random> LocalRandom; // 0x0

	// Properties
	private static Random Random { get; }

	// Methods

	// RVA: 0x1C999F0 Offset: 0x1C98BF0 VA: 0x181C999F0
	private static Random get_Random() { }

	// RVA: 0x1C99890 Offset: 0x1C98A90 VA: 0x181C99890 Slot: 4
	public override int NextInt() { }

	// RVA: 0x1C99900 Offset: 0x1C98B00 VA: 0x181C99900 Slot: 5
	public override int NextInt(int minValue, int maxValue) { }

	// RVA: 0x1C99820 Offset: 0x1C98A20 VA: 0x181C99820 Slot: 6
	public override double NextDouble() { }

	// RVA: 0x1C997B0 Offset: 0x1C989B0 VA: 0x181C997B0 Slot: 7
	public override void NextBytes(byte[] bytes) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1C99980 Offset: 0x1C98B80 VA: 0x181C99980
	private static void .cctor() { }
}

// Namespace: Sentry.Internal
internal sealed class ThreadPoolInfo : IJsonSerializable // TypeDefIndex: 13656
{
	// Fields
	[CompilerGenerated]
	private readonly int <MinWorkerThreads>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly int <MinCompletionPortThreads>k__BackingField; // 0x14
	[CompilerGenerated]
	private readonly int <MaxWorkerThreads>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly int <MaxCompletionPortThreads>k__BackingField; // 0x1C
	[CompilerGenerated]
	private readonly int <AvailableWorkerThreads>k__BackingField; // 0x20
	[CompilerGenerated]
	private readonly int <AvailableCompletionPortThreads>k__BackingField; // 0x24

	// Properties
	public int MinWorkerThreads { get; }
	public int MinCompletionPortThreads { get; }
	public int MaxWorkerThreads { get; }
	public int MaxCompletionPortThreads { get; }
	public int AvailableWorkerThreads { get; }
	public int AvailableCompletionPortThreads { get; }

	// Methods

	// RVA: 0x1CB80A0 Offset: 0x1CB72A0 VA: 0x181CB80A0
	public void .ctor(int minWorkerThreads, int minCompletionPortThreads, int maxWorkerThreads, int maxCompletionPortThreads, int availableWorkerThreads, int availableCompletionPortThreads) { }

	[CompilerGenerated]
	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public int get_MinWorkerThreads() { }

	[CompilerGenerated]
	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500
	public int get_MinCompletionPortThreads() { }

	[CompilerGenerated]
	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public int get_MaxWorkerThreads() { }

	[CompilerGenerated]
	// RVA: 0x3F9110 Offset: 0x3F8310 VA: 0x1803F9110
	public int get_MaxCompletionPortThreads() { }

	[CompilerGenerated]
	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400
	public int get_AvailableWorkerThreads() { }

	[CompilerGenerated]
	// RVA: 0x47BD90 Offset: 0x47AF90 VA: 0x18047BD90
	public int get_AvailableCompletionPortThreads() { }

	[NullableContext(1)]
	// RVA: 0x1CB7F80 Offset: 0x1CB7180 VA: 0x181CB7F80 Slot: 4
	public void WriteTo(Utf8JsonWriter writer, IDiagnosticLogger logger) { }
}

// Namespace: 
[NullableContext(0)]
private class ThreadsafeCounterDictionary.CounterItem<TKey> // TypeDefIndex: 13657
{
	// Fields
	private int _value; // 0x0

	// Properties
	public int Value { get; }

	// Methods

	// RVA: -1 Offset: -1
	public int get_Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	|-ThreadsafeCounterDictionary.CounterItem<DiscardReasonWithCategory>.get_Value
	|-ThreadsafeCounterDictionary.CounterItem<__Il2CppFullySharedGenericType>.get_Value
	*/

	// RVA: -1 Offset: -1
	public void Add(int quantity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFBB050 Offset: 0xFBA250 VA: 0x180FBB050
	|-ThreadsafeCounterDictionary.CounterItem<DiscardReasonWithCategory>.Add
	|-ThreadsafeCounterDictionary.CounterItem<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1
	public void Increment() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFBB060 Offset: 0xFBA260 VA: 0x180FBB060
	|-ThreadsafeCounterDictionary.CounterItem<DiscardReasonWithCategory>.Increment
	|-ThreadsafeCounterDictionary.CounterItem<__Il2CppFullySharedGenericType>.Increment
	*/

	// RVA: -1 Offset: -1
	public int ReadAndReset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFBB070 Offset: 0xFBA270 VA: 0x180FBB070
	|-ThreadsafeCounterDictionary.CounterItem<DiscardReasonWithCategory>.ReadAndReset
	|-ThreadsafeCounterDictionary.CounterItem<__Il2CppFullySharedGenericType>.ReadAndReset
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	|-ThreadsafeCounterDictionary.CounterItem<DiscardReasonWithCategory>..ctor
	|-ThreadsafeCounterDictionary.CounterItem<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class ThreadsafeCounterDictionary.<>c<TKey> // TypeDefIndex: 13658
{
	// Fields
	[Nullable(0)]
	public static readonly ThreadsafeCounterDictionary.<>c<TKey> <>9; // 0x0
	[Nullable(0)]
	public static Func<KeyValuePair<TKey, ThreadsafeCounterDictionary.CounterItem<TKey>>, TKey> <>9__5_0; // 0x0
	[Nullable(0)]
	public static Func<KeyValuePair<TKey, ThreadsafeCounterDictionary.CounterItem<TKey>>, int> <>9__5_1; // 0x0
	[Nullable(0)]
	public static Func<KeyValuePair<TKey, ThreadsafeCounterDictionary.CounterItem<TKey>>, KeyValuePair<TKey, int>> <>9__6_0; // 0x0
	[Nullable(0)]
	public static Func<ThreadsafeCounterDictionary.CounterItem<TKey>, int> <>9__17_0; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB08330 Offset: 0xB07530 VA: 0x180B08330
	|-ThreadsafeCounterDictionary.<>c<DiscardReasonWithCategory>..cctor
	|
	|-RVA: 0xB08640 Offset: 0xB07840 VA: 0x180B08640
	|-ThreadsafeCounterDictionary.<>c<__Il2CppFullySharedGenericType>..cctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	|-ThreadsafeCounterDictionary.<>c<DiscardReasonWithCategory>..ctor
	|-ThreadsafeCounterDictionary.<>c<__Il2CppFullySharedGenericType>..ctor
	*/

	[NullableContext(0)]
	// RVA: -1 Offset: -1
	internal TKey <ReadAllAndReset>b__5_0(KeyValuePair<TKey, ThreadsafeCounterDictionary.CounterItem<TKey>> x) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB069D0 Offset: 0xB05BD0 VA: 0x180B069D0
	|-ThreadsafeCounterDictionary.<>c<DiscardReasonWithCategory>.<ReadAllAndReset>b__5_0
	|
	|-RVA: 0xB069E0 Offset: 0xB05BE0 VA: 0x180B069E0
	|-ThreadsafeCounterDictionary.<>c<__Il2CppFullySharedGenericType>.<ReadAllAndReset>b__5_0
	*/

	[NullableContext(0)]
	// RVA: -1 Offset: -1
	internal int <ReadAllAndReset>b__5_1(KeyValuePair<TKey, ThreadsafeCounterDictionary.CounterItem<TKey>> x) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB06AE0 Offset: 0xB05CE0 VA: 0x180B06AE0
	|-ThreadsafeCounterDictionary.<>c<DiscardReasonWithCategory>.<ReadAllAndReset>b__5_1
	|
	|-RVA: 0xB06A80 Offset: 0xB05C80 VA: 0x180B06A80
	|-ThreadsafeCounterDictionary.<>c<__Il2CppFullySharedGenericType>.<ReadAllAndReset>b__5_1
	*/

	[NullableContext(0)]
	// RVA: -1 Offset: -1
	internal KeyValuePair<TKey, int> <GetEnumerator>b__6_0(KeyValuePair<TKey, ThreadsafeCounterDictionary.CounterItem<TKey>> x) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB06440 Offset: 0xB05640 VA: 0x180B06440
	|-ThreadsafeCounterDictionary.<>c<DiscardReasonWithCategory>.<GetEnumerator>b__6_0
	|
	|-RVA: 0xB064A0 Offset: 0xB056A0 VA: 0x180B064A0
	|-ThreadsafeCounterDictionary.<>c<__Il2CppFullySharedGenericType>.<GetEnumerator>b__6_0
	*/

	[NullableContext(0)]
	// RVA: -1 Offset: -1
	internal int <get_Values>b__17_0(ThreadsafeCounterDictionary.CounterItem<TKey> x) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6C93A0 Offset: 0x6C85A0 VA: 0x1806C93A0
	|-ThreadsafeCounterDictionary.<>c<DiscardReasonWithCategory>.<get_Values>b__17_0
	|
	|-RVA: 0xB08220 Offset: 0xB07420 VA: 0x180B08220
	|-ThreadsafeCounterDictionary.<>c<__Il2CppFullySharedGenericType>.<get_Values>b__17_0
	*/
}

// Namespace: Sentry.Internal
[DefaultMember("Item")]
[Nullable(0)]
[NullableContext(1)]
internal class ThreadsafeCounterDictionary<TKey> : IReadOnlyDictionary<TKey, int>, IEnumerable<KeyValuePair<TKey, int>>, IEnumerable, IReadOnlyCollection<KeyValuePair<TKey, int>> // TypeDefIndex: 13659
{
	// Fields
	[Nullable(new[] { 1, 1, 1, 0 })]
	private readonly ConcurrentDictionary<TKey, ThreadsafeCounterDictionary.CounterItem<TKey>> _items; // 0x0

	// Properties
	public int Count { get; }
	public int Item { get; }
	public IEnumerable<TKey> Keys { get; }
	public IEnumerable<int> Values { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void Add(TKey key, int quantity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCAD3B0 Offset: 0xCAC5B0 VA: 0x180CAD3B0
	|-ThreadsafeCounterDictionary<DiscardReasonWithCategory>.Add
	|
	|-RVA: 0xCAD490 Offset: 0xCAC690 VA: 0x180CAD490
	|-ThreadsafeCounterDictionary<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1
	public void Increment(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCADB00 Offset: 0xCACD00 VA: 0x180CADB00
	|-ThreadsafeCounterDictionary<DiscardReasonWithCategory>.Increment
	|
	|-RVA: 0xCADBD0 Offset: 0xCACDD0 VA: 0x180CADBD0
	|-ThreadsafeCounterDictionary<__Il2CppFullySharedGenericType>.Increment
	*/

	// RVA: -1 Offset: -1
	public int ReadAndReset(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCAE3E0 Offset: 0xCAD5E0 VA: 0x180CAE3E0
	|-ThreadsafeCounterDictionary<DiscardReasonWithCategory>.ReadAndReset
	|
	|-RVA: 0xCAE460 Offset: 0xCAD660 VA: 0x180CAE460
	|-ThreadsafeCounterDictionary<__Il2CppFullySharedGenericType>.ReadAndReset
	*/

	// RVA: -1 Offset: -1
	public IReadOnlyDictionary<TKey, int> ReadAllAndReset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCAE080 Offset: 0xCAD280 VA: 0x180CAE080
	|-ThreadsafeCounterDictionary<DiscardReasonWithCategory>.ReadAllAndReset
	|
	|-RVA: 0xCADD20 Offset: 0xCACF20 VA: 0x180CADD20
	|-ThreadsafeCounterDictionary<__Il2CppFullySharedGenericType>.ReadAllAndReset
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public IEnumerator<KeyValuePair<TKey, int>> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCAD910 Offset: 0xCACB10 VA: 0x180CAD910
	|-ThreadsafeCounterDictionary<DiscardReasonWithCategory>.GetEnumerator
	|
	|-RVA: 0xCAD720 Offset: 0xCAC920 VA: 0x180CAD720
	|-ThreadsafeCounterDictionary<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCAE5B0 Offset: 0xCAD7B0 VA: 0x180CAE5B0
	|-ThreadsafeCounterDictionary<DiscardReasonWithCategory>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xCAE5D0 Offset: 0xCAD7D0 VA: 0x180CAE5D0
	|-ThreadsafeCounterDictionary<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCAE860 Offset: 0xCADA60 VA: 0x180CAE860
	|-ThreadsafeCounterDictionary<DiscardReasonWithCategory>.get_Count
	|
	|-RVA: 0xCAE890 Offset: 0xCADA90 VA: 0x180CAE890
	|-ThreadsafeCounterDictionary<__Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public bool ContainsKey(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCAD6E0 Offset: 0xCAC8E0 VA: 0x180CAD6E0
	|-ThreadsafeCounterDictionary<DiscardReasonWithCategory>.ContainsKey
	|
	|-RVA: 0xCAD5F0 Offset: 0xCAC7F0 VA: 0x180CAD5F0
	|-ThreadsafeCounterDictionary<__Il2CppFullySharedGenericType>.ContainsKey
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public bool TryGetValue(TKey key, out int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCAE5F0 Offset: 0xCAD7F0 VA: 0x180CAE5F0
	|-ThreadsafeCounterDictionary<DiscardReasonWithCategory>.TryGetValue
	|
	|-RVA: 0xCAE670 Offset: 0xCAD870 VA: 0x180CAE670
	|-ThreadsafeCounterDictionary<__Il2CppFullySharedGenericType>.TryGetValue
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public int get_Item(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCAE8D0 Offset: 0xCADAD0 VA: 0x180CAE8D0
	|-ThreadsafeCounterDictionary<DiscardReasonWithCategory>.get_Item
	|
	|-RVA: 0xCAE930 Offset: 0xCADB30 VA: 0x180CAE930
	|-ThreadsafeCounterDictionary<__Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public IEnumerable<TKey> get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCAEAC0 Offset: 0xCADCC0 VA: 0x180CAEAC0
	|-ThreadsafeCounterDictionary<DiscardReasonWithCategory>.get_Keys
	|
	|-RVA: 0xCAEA80 Offset: 0xCADC80 VA: 0x180CAEA80
	|-ThreadsafeCounterDictionary<__Il2CppFullySharedGenericType>.get_Keys
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public IEnumerable<int> get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCAEAF0 Offset: 0xCADCF0 VA: 0x180CAEAF0
	|-ThreadsafeCounterDictionary<DiscardReasonWithCategory>.get_Values
	|
	|-RVA: 0xCAECC0 Offset: 0xCADEC0 VA: 0x180CAECC0
	|-ThreadsafeCounterDictionary<__Il2CppFullySharedGenericType>.get_Values
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCAE7E0 Offset: 0xCAD9E0 VA: 0x180CAE7E0
	|-ThreadsafeCounterDictionary<DiscardReasonWithCategory>..ctor
	|
	|-RVA: 0xCAE760 Offset: 0xCAD960 VA: 0x180CAE760
	|-ThreadsafeCounterDictionary<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: Sentry.Internal.ScopeStack
internal class AsyncLocalScopeStackContainer : IScopeStackContainer // TypeDefIndex: 13660
{
	// Fields
	[Nullable(new[] { 1, 2, 0, 1, 1 })]
	private readonly AsyncLocal<KeyValuePair<Scope, ISentryClient>[]> _asyncLocalScope; // 0x10

	// Properties
	[Nullable(new[] { 2, 0, 1, 1 })]
	public KeyValuePair<Scope, ISentryClient>[] Stack { get; set; }

	// Methods

	// RVA: 0x1CA2150 Offset: 0x1CA1350 VA: 0x181CA2150 Slot: 4
	public KeyValuePair<Scope, ISentryClient>[] get_Stack() { }

	// RVA: 0x1CA21A0 Offset: 0x1CA13A0 VA: 0x181CA21A0 Slot: 5
	public void set_Stack(KeyValuePair<Scope, ISentryClient>[] value) { }

	// RVA: 0x1CA20E0 Offset: 0x1CA12E0 VA: 0x181CA20E0
	public void .ctor() { }
}

// Namespace: Sentry.Internal.ScopeStack
internal class GlobalScopeStackContainer : IScopeStackContainer // TypeDefIndex: 13661
{
	// Fields
	[Nullable(new[] { 2, 0, 1, 1 })]
	[CompilerGenerated]
	private KeyValuePair<Scope, ISentryClient>[] <Stack>k__BackingField; // 0x10

	// Properties
	[Nullable(new[] { 2, 0, 1, 1 })]
	public KeyValuePair<Scope, ISentryClient>[] Stack { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0 Slot: 4
	public KeyValuePair<Scope, ISentryClient>[] get_Stack() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0 Slot: 5
	public void set_Stack(KeyValuePair<Scope, ISentryClient>[] value) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: Sentry.Internal.ScopeStack
internal interface IScopeStackContainer // TypeDefIndex: 13662
{
	// Properties
	[Nullable(new[] { 2, 0, 1, 1 })]
	public abstract KeyValuePair<Scope, ISentryClient>[] Stack { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract KeyValuePair<Scope, ISentryClient>[] get_Stack();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_Stack(KeyValuePair<Scope, ISentryClient>[] value);
}

// Namespace: Sentry.Internal.OpenTelemetry
[NullableContext(1)]
[Nullable(0)]
internal static class OtelSemanticConventions // TypeDefIndex: 13663
{
	// Fields
	public const string AttributeNetTransport = "net.transport";
	public const string AttributeNetPeerIp = "net.peer.ip";
	public const string AttributeNetPeerPort = "net.peer.port";
	public const string AttributeNetPeerName = "net.peer.name";
	public const string AttributeNetHostIp = "net.host.ip";
	public const string AttributeNetHostPort = "net.host.port";
	public const string AttributeNetHostName = "net.host.name";
	public const string AttributeEnduserId = "enduser.id";
	public const string AttributeEnduserRole = "enduser.role";
	public const string AttributeEnduserScope = "enduser.scope";
	public const string AttributePeerService = "peer.service";
	public const string AttributeHttpMethod = "http.method";
	public const string AttributeHttpUrl = "http.url";
	public const string AttributeHttpTarget = "http.target";
	public const string AttributeHttpHost = "http.host";
	public const string AttributeHttpScheme = "http.scheme";
	public const string AttributeHttpStatusCode = "http.status_code";
	public const string AttributeHttpStatusText = "http.status_text";
	public const string AttributeHttpFlavor = "http.flavor";
	public const string AttributeHttpServerName = "http.server_name";
	public const string AttributeHttpRoute = "http.route";
	public const string AttributeHttpClientIP = "http.client_ip";
	public const string AttributeHttpUserAgent = "http.user_agent";
	public const string AttributeHttpRequestContentLength = "http.request_content_length";
	public const string AttributeHttpRequestContentLengthUncompressed = "http.request_content_length_uncompressed";
	public const string AttributeHttpResponseContentLength = "http.response_content_length";
	public const string AttributeHttpResponseContentLengthUncompressed = "http.response_content_length_uncompressed";
	public const string AttributeDbSystem = "db.system";
	public const string AttributeDbConnectionString = "db.connection_string";
	public const string AttributeDbUser = "db.user";
	public const string AttributeDbMsSqlInstanceName = "db.mssql.instance_name";
	public const string AttributeDbJdbcDriverClassName = "db.jdbc.driver_classname";
	public const string AttributeDbName = "db.name";
	public const string AttributeDbStatement = "db.statement";
	public const string AttributeDbOperation = "db.operation";
	public const string AttributeDbInstance = "db.instance";
	public const string AttributeDbUrl = "db.url";
	public const string AttributeDbCassandraKeyspace = "db.cassandra.keyspace";
	public const string AttributeDbHBaseNamespace = "db.hbase.namespace";
	public const string AttributeDbRedisDatabaseIndex = "db.redis.database_index";
	public const string AttributeDbMongoDbCollection = "db.mongodb.collection";
	public const string AttributeRpcSystem = "rpc.system";
	public const string AttributeRpcService = "rpc.service";
	public const string AttributeRpcMethod = "rpc.method";
	public const string AttributeRpcGrpcStatusCode = "rpc.grpc.status_code";
	public const string AttributeMessageType = "message.type";
	public const string AttributeMessageId = "message.id";
	public const string AttributeMessageCompressedSize = "message.compressed_size";
	public const string AttributeMessageUncompressedSize = "message.uncompressed_size";
	public const string AttributeFaasTrigger = "faas.trigger";
	public const string AttributeFaasExecution = "faas.execution";
	public const string AttributeFaasDocumentCollection = "faas.document.collection";
	public const string AttributeFaasDocumentOperation = "faas.document.operation";
	public const string AttributeFaasDocumentTime = "faas.document.time";
	public const string AttributeFaasDocumentName = "faas.document.name";
	public const string AttributeFaasTime = "faas.time";
	public const string AttributeFaasCron = "faas.cron";
	public const string AttributeMessagingSystem = "messaging.system";
	public const string AttributeMessagingDestination = "messaging.destination";
	public const string AttributeMessagingDestinationKind = "messaging.destination_kind";
	public const string AttributeMessagingTempDestination = "messaging.temp_destination";
	public const string AttributeMessagingProtocol = "messaging.protocol";
	public const string AttributeMessagingProtocolVersion = "messaging.protocol_version";
	public const string AttributeMessagingUrl = "messaging.url";
	public const string AttributeMessagingMessageId = "messaging.message_id";
	public const string AttributeMessagingConversationId = "messaging.conversation_id";
	public const string AttributeMessagingPayloadSize = "messaging.message_payload_size_bytes";
	public const string AttributeMessagingPayloadCompressedSize = "messaging.message_payload_compressed_size_bytes";
	public const string AttributeMessagingOperation = "messaging.operation";
	public const string AttributeExceptionEventName = "exception";
	public const string AttributeExceptionType = "exception.type";
	public const string AttributeExceptionMessage = "exception.message";
	public const string AttributeExceptionStacktrace = "exception.stacktrace";
	public const string AttributeClientAddress = "client.address";
	public const string AttributeClientPort = "client.port";
	public const string AttributeHttpRequestMethod = "http.request.method";
	public const string AttributeHttpResponseStatusCode = "http.response.status_code";
	public const string AttributeNetworkProtocolVersion = "network.protocol.version";
	public const string AttributeServerAddress = "server.address";
	public const string AttributeServerPort = "server.port";
	public const string AttributeServerSocketAddress = "server.socket.address";
	public const string AttributeUrlFull = "url.full";
	public const string AttributeUrlPath = "url.path";
	public const string AttributeUrlScheme = "url.scheme";
	public const string AttributeUrlQuery = "url.query";
	public const string AttributeUserAgentOriginal = "user_agent.original";
}

// Namespace: Sentry.Internal.OpenTelemetry
[NullableContext(1)]
[Nullable(0)]
internal static class OtelSpanAttributeConstants // TypeDefIndex: 13664
{
	// Fields
	public const string StatusCodeKey = "otel.status_code";
	public const string StatusDescriptionKey = "otel.status_description";
	public const string DatabaseStatementTypeKey = "db.statement_type";
}

// Namespace: Sentry.Internal.OpenTelemetry
[NullableContext(1)]
[Nullable(0)]
internal static class OtelStatusTags // TypeDefIndex: 13665
{
	// Fields
	public const string UnsetStatusCodeTagValue = "UNSET";
	public const string OkStatusCodeTagValue = "OK";
	public const string ErrorStatusCodeTagValue = "ERROR";
}

// Namespace: Sentry.Internal.JsonConverters
[NullableContext(1)]
[Nullable(0)]
internal class IntPtrJsonConverter : JsonConverter<IntPtr> // TypeDefIndex: 13666
{
	// Methods

	// RVA: 0x1CB0C90 Offset: 0x1CAFE90 VA: 0x181CB0C90 Slot: 23
	public override IntPtr Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) { }

	// RVA: 0x1CB0CD0 Offset: 0x1CAFED0 VA: 0x181CB0CD0 Slot: 24
	public override void Write(Utf8JsonWriter writer, IntPtr value, JsonSerializerOptions options) { }

	// RVA: 0x1CB0D10 Offset: 0x1CAFF10 VA: 0x181CB0D10
	public void .ctor() { }
}

// Namespace: Sentry.Internal.JsonConverters
[NullableContext(1)]
[Nullable(0)]
internal class IntPtrNullableJsonConverter : JsonConverter<Nullable<IntPtr>> // TypeDefIndex: 13667
{
	// Methods

	// RVA: 0x1CB0D50 Offset: 0x1CAFF50 VA: 0x181CB0D50 Slot: 23
	public override Nullable<IntPtr> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) { }

	// RVA: 0x1CB0DF0 Offset: 0x1CAFFF0 VA: 0x181CB0DF0 Slot: 24
	public override void Write(Utf8JsonWriter writer, Nullable<IntPtr> value, JsonSerializerOptions options) { }

	// RVA: 0x1CB0E90 Offset: 0x1CB0090 VA: 0x181CB0E90
	public void .ctor() { }
}

// Namespace: Sentry.Internal.JsonConverters
[NullableContext(1)]
[Nullable(new[] { 0, 2 })]
internal class SentryJsonConverter : JsonConverter<object> // TypeDefIndex: 13668
{
	// Methods

	// RVA: 0x1CB7310 Offset: 0x1CB6510 VA: 0x181CB7310 Slot: 4
	public override bool CanConvert(Type typeToConvert) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 23
	public override object Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) { }

	// RVA: 0x1CB7400 Offset: 0x1CB6600 VA: 0x181CB7400 Slot: 24
	public override void Write(Utf8JsonWriter writer, object value, JsonSerializerOptions options) { }

	// RVA: 0x1CB74F0 Offset: 0x1CB66F0 VA: 0x181CB74F0
	public void .ctor() { }
}

// Namespace: Sentry.Internal.JsonConverters
[Nullable(0)]
[NullableContext(1)]
internal class UIntPtrJsonConverter : JsonConverter<UIntPtr> // TypeDefIndex: 13669
{
	// Methods

	// RVA: 0x1CC0160 Offset: 0x1CBF360 VA: 0x181CC0160 Slot: 23
	public override UIntPtr Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) { }

	// RVA: 0x1CC01A0 Offset: 0x1CBF3A0 VA: 0x181CC01A0 Slot: 24
	public override void Write(Utf8JsonWriter writer, UIntPtr value, JsonSerializerOptions options) { }

	// RVA: 0x1CC01E0 Offset: 0x1CBF3E0 VA: 0x181CC01E0
	public void .ctor() { }
}

// Namespace: Sentry.Internal.JsonConverters
[NullableContext(1)]
[Nullable(0)]
internal class UIntPtrNullableJsonConverter : JsonConverter<Nullable<UIntPtr>> // TypeDefIndex: 13670
{
	// Methods

	// RVA: 0x1CC0220 Offset: 0x1CBF420 VA: 0x181CC0220 Slot: 23
	public override Nullable<UIntPtr> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) { }

	// RVA: 0x1CC02C0 Offset: 0x1CBF4C0 VA: 0x181CC02C0 Slot: 24
	public override void Write(Utf8JsonWriter writer, Nullable<UIntPtr> value, JsonSerializerOptions options) { }

	// RVA: 0x1CC0360 Offset: 0x1CBF560 VA: 0x181CC0360
	public void .ctor() { }
}

// Namespace: Sentry.Internal.ILSpy
[Extension]
internal static class ModuleExtensions // TypeDefIndex: 13671
{
	// Methods

	[NullableContext(1)]
	[Extension]
	// RVA: 0x1CB5100 Offset: 0x1CB4300 VA: 0x181CB5100
	public static string GetNameOrScopeName(Module module) { }
}

// Namespace: 
[CompilerGenerated]
private struct CachingTransport.<CachedTransportBackgroundTaskAsync>d__20 : IAsyncStateMachine // TypeDefIndex: 13672
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	[Nullable(0)]
	public CachingTransport <>4__this; // 0x20
	[Nullable(0)]
	private object <>7__wrap1; // 0x28
	private int <>7__wrap2; // 0x30
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x38

	// Methods

	// RVA: 0x1CB8110 Offset: 0x1CB7310 VA: 0x181CB8110 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1CB89A0 Offset: 0x1CB7BA0 VA: 0x181CB89A0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct CachingTransport.<DisposeAsync>d__33 : IAsyncStateMachine // TypeDefIndex: 13673
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncValueTaskMethodBuilder <>t__builder; // 0x8
	[Nullable(0)]
	public CachingTransport <>4__this; // 0x28
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x30

	// Methods

	// RVA: 0x1CB8A00 Offset: 0x1CB7C00 VA: 0x181CB8A00 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1C3AEA0 Offset: 0x1C3A0A0 VA: 0x181C3AEA0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct CachingTransport.<InnerProcessCacheAsync>d__25 : IAsyncStateMachine // TypeDefIndex: 13674
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	[Nullable(0)]
	public CachingTransport <>4__this; // 0x20
	public CancellationToken cancellation; // 0x28
	[Nullable(0)]
	public string file; // 0x30
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x38
	[Nullable(0)]
	private Stream <>7__wrap1; // 0x48
	[Nullable(0)]
	private Envelope <envelope>5__3; // 0x50
	[Nullable(new[] { 0, 1 })]
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Envelope> <>u__2; // 0x58

	// Methods

	// RVA: 0x1CBA070 Offset: 0x1CB9270 VA: 0x181CBA070 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1CBAFE0 Offset: 0x1CBA1E0 VA: 0x181CBAFE0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct CachingTransport.<ProcessCacheAsync>d__24 : IAsyncStateMachine // TypeDefIndex: 13675
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	[Nullable(0)]
	public CachingTransport <>4__this; // 0x20
	public CancellationToken cancellation; // 0x28
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x30
	[Nullable(new[] { 0, 2 })]
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<string> <>u__2; // 0x40

	// Methods

	// RVA: 0x1CBB040 Offset: 0x1CBA240 VA: 0x181CBB040 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1CBB7E0 Offset: 0x1CBA9E0 VA: 0x181CBB7E0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct CachingTransport.<SendEnvelopeAsync>d__30 : IAsyncStateMachine // TypeDefIndex: 13676
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	[Nullable(0)]
	public CachingTransport <>4__this; // 0x20
	[Nullable(0)]
	public Envelope envelope; // 0x28
	public CancellationToken cancellationToken; // 0x30
	[Nullable(0)]
	private ClientReport <clientReport>5__2; // 0x38
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x40

	// Methods

	// RVA: 0x1CBD400 Offset: 0x1CBC600 VA: 0x181CBD400 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1CBD850 Offset: 0x1CBCA50 VA: 0x181CBD850 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct CachingTransport.<StoreToCacheAsync>d__28 : IAsyncStateMachine // TypeDefIndex: 13677
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	[Nullable(0)]
	public CachingTransport <>4__this; // 0x20
	[Nullable(0)]
	public Envelope envelope; // 0x28
	public CancellationToken cancellationToken; // 0x30
	[Nullable(0)]
	private string <envelopeFilePath>5__2; // 0x38
	[Nullable(0)]
	private IDisposable <lockClaim>5__3; // 0x40
	[Nullable(new[] { 0, 1 })]
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<IDisposable> <>u__1; // 0x48
	[Nullable(0)]
	private Stream <>7__wrap3; // 0x58
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2; // 0x60

	// Methods

	// RVA: 0x1CBED30 Offset: 0x1CBDF30 VA: 0x181CBED30 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1CBF720 Offset: 0x1CBE920 VA: 0x181CBF720 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct CachingTransport.<TryPrepareNextCacheFileAsync>d__27 : IAsyncStateMachine // TypeDefIndex: 13678
{
	// Fields
	public int <>1__state; // 0x0
	[Nullable(0)]
	public AsyncTaskMethodBuilder<string> <>t__builder; // 0x8
	[Nullable(0)]
	public CachingTransport <>4__this; // 0x20
	public CancellationToken cancellationToken; // 0x28
	[Nullable(new[] { 0, 1 })]
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<IDisposable> <>u__1; // 0x30

	// Methods

	// RVA: 0x1CBF780 Offset: 0x1CBE980 VA: 0x181CBF780 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1CBFB60 Offset: 0x1CBED60 VA: 0x181CBFB60 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: Sentry.Internal.Http
[NullableContext(1)]
[Nullable(0)]
internal class CachingTransport : ITransport, IAsyncDisposable, IDisposable // TypeDefIndex: 13679
{
	// Fields
	private const string EnvelopeFileExt = "envelope";
	private readonly ITransport _innerTransport; // 0x10
	private readonly SentryOptions _options; // 0x18
	private readonly bool _failStorage; // 0x20
	private readonly string _isolatedCacheDirectoryPath; // 0x28
	private readonly int _keepCount; // 0x30
	private readonly string _processingDirectoryPath; // 0x38
	private readonly Signal _workerSignal; // 0x40
	private readonly Signal _processingSignal; // 0x48
	private readonly Lock _cacheDirectoryLock; // 0x50
	private readonly CancellationTokenSource _workerCts; // 0x58
	private Task _worker; // 0x60
	[Nullable(2)]
	private ManualResetEventSlim _initCacheResetEvent; // 0x68
	[Nullable(2)]
	private ManualResetEventSlim _preInitCacheResetEvent; // 0x70
	private readonly IFileSystem _fileSystem; // 0x78

	// Properties
	internal ITransport InnerTransport { get; }

	// Methods

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	internal ITransport get_InnerTransport() { }

	// RVA: 0x1CA2860 Offset: 0x1CA1A60 VA: 0x181CA2860
	public static CachingTransport Create(ITransport innerTransport, SentryOptions options, bool startWorker = True, bool failStorage = False) { }

	// RVA: 0x1CA4120 Offset: 0x1CA3320 VA: 0x181CA4120
	private void .ctor(ITransport innerTransport, SentryOptions options, bool failStorage) { }

	// RVA: 0x1CA3060 Offset: 0x1CA2260 VA: 0x181CA3060
	private void Initialize(bool startWorker) { }

	[AsyncStateMachine(typeof(CachingTransport.<CachedTransportBackgroundTaskAsync>d__20))]
	// RVA: 0x1CA2790 Offset: 0x1CA1990 VA: 0x181CA2790
	private Task CachedTransportBackgroundTaskAsync() { }

	// RVA: 0x1CA3760 Offset: 0x1CA2960 VA: 0x181CA3760
	private void MoveUnprocessedFilesBackToCache() { }

	// RVA: 0x1CA2CD0 Offset: 0x1CA1ED0 VA: 0x181CA2CD0
	private void EnsureFreeSpaceInCache() { }

	// RVA: 0x1CA2EC0 Offset: 0x1CA20C0 VA: 0x181CA2EC0
	private IEnumerable<string> GetCacheFilePaths() { }

	[AsyncStateMachine(typeof(CachingTransport.<ProcessCacheAsync>d__24))]
	// RVA: 0x1CA3BA0 Offset: 0x1CA2DA0 VA: 0x181CA3BA0
	private Task ProcessCacheAsync(CancellationToken cancellation) { }

	[AsyncStateMachine(typeof(CachingTransport.<InnerProcessCacheAsync>d__25))]
	// RVA: 0x1CA34A0 Offset: 0x1CA26A0 VA: 0x181CA34A0
	private Task InnerProcessCacheAsync(string file, CancellationToken cancellation) { }

	// RVA: 0x1CA35A0 Offset: 0x1CA27A0 VA: 0x181CA35A0
	private void LogFailureWithDiscard(string file, Exception ex) { }

	[AsyncStateMachine(typeof(CachingTransport.<TryPrepareNextCacheFileAsync>d__27))]
	// RVA: 0x1CA3F50 Offset: 0x1CA3150 VA: 0x181CA3F50
	private Task<string> TryPrepareNextCacheFileAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(CachingTransport.<StoreToCacheAsync>d__28))]
	// RVA: 0x1CA3E50 Offset: 0x1CA3050 VA: 0x181CA3E50
	private Task StoreToCacheAsync(Envelope envelope, CancellationToken cancellationToken) { }

	// RVA: 0x1CA3010 Offset: 0x1CA2210 VA: 0x181CA3010
	internal int GetCacheLength() { }

	[AsyncStateMachine(typeof(CachingTransport.<SendEnvelopeAsync>d__30))]
	// RVA: 0x1CA3C80 Offset: 0x1CA2E80 VA: 0x181CA3C80 Slot: 4
	public Task SendEnvelopeAsync(Envelope envelope, CancellationToken cancellationToken) { }

	// RVA: 0x1CA3D70 Offset: 0x1CA2F70 VA: 0x181CA3D70
	public Task StopWorkerAsync() { }

	// RVA: 0x1CA2E60 Offset: 0x1CA2060 VA: 0x181CA2E60
	public Task FlushAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(CachingTransport.<DisposeAsync>d__33))]
	// RVA: 0x1CA2910 Offset: 0x1CA1B10 VA: 0x181CA2910 Slot: 5
	public ValueTask DisposeAsync() { }

	// RVA: 0x1CA2A10 Offset: 0x1CA1C10 VA: 0x181CA2A10 Slot: 6
	public void Dispose() { }

	[NullableContext(0)]
	[CompilerGenerated]
	// RVA: 0x1CA4040 Offset: 0x1CA3240 VA: 0x181CA4040
	private DateTimeOffset <GetCacheFilePaths>b__23_0(string f) { }
}

// Namespace: Sentry.Internal.Http
internal class DefaultSentryHttpClientFactory : ISentryHttpClientFactory // TypeDefIndex: 13680
{
	// Methods

	[NullableContext(1)]
	// RVA: 0x1CA4840 Offset: 0x1CA3A40 VA: 0x181CA4840 Slot: 4
	public HttpClient Create(SentryOptions options) { }

	[NullableContext(1)]
	// RVA: 0x1CA4E00 Offset: 0x1CA4000 VA: 0x181CA4E00
	private static bool SupportsAutomaticDecompression(HttpClientHandler handler) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private struct EnvelopeHttpContent.<SerializeToStreamAsync>d__4 : IAsyncStateMachine // TypeDefIndex: 13681
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	[Nullable(0)]
	public EnvelopeHttpContent <>4__this; // 0x20
	[Nullable(0)]
	public Stream stream; // 0x28
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x30

	// Methods

	// RVA: 0x1CBE280 Offset: 0x1CBD480 VA: 0x181CBE280 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1CBE850 Offset: 0x1CBDA50 VA: 0x181CBE850 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: Sentry.Internal.Http
[Nullable(0)]
[NullableContext(1)]
internal class EnvelopeHttpContent : SerializableHttpContent // TypeDefIndex: 13682
{
	// Fields
	private readonly Envelope _envelope; // 0x30
	[Nullable(2)]
	private readonly IDiagnosticLogger _logger; // 0x38
	private readonly ISystemClock _clock; // 0x40

	// Methods

	// RVA: 0x1CAB4C0 Offset: 0x1CAA6C0 VA: 0x181CAB4C0
	public void .ctor(Envelope envelope, IDiagnosticLogger logger, ISystemClock clock) { }

	[AsyncStateMachine(typeof(EnvelopeHttpContent.<SerializeToStreamAsync>d__4))]
	// RVA: 0x1CAB330 Offset: 0x1CAA530 VA: 0x181CAB330 Slot: 7
	protected override Task SerializeToStreamAsync(Stream stream, TransportContext context) { }

	// RVA: 0x1CAB410 Offset: 0x1CAA610 VA: 0x181CAB410 Slot: 9
	protected override void SerializeToStream(Stream stream, TransportContext context, CancellationToken cancellationToken) { }

	// RVA: 0x1CAB4B0 Offset: 0x1CAA6B0 VA: 0x181CAB4B0 Slot: 8
	protected override bool TryComputeLength(out long length) { }
}

// Namespace: 
[NullableContext(0)]
internal class GzipBufferedRequestBodyHandler.BufferedStreamContent : StreamContent // TypeDefIndex: 13683
{
	// Fields
	[CompilerGenerated]
	private readonly long <ContentLength>k__BackingField; // 0x58

	// Properties
	internal long ContentLength { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x405090 Offset: 0x404290 VA: 0x180405090
	internal long get_ContentLength() { }

	[NullableContext(1)]
	// RVA: 0x1CA2520 Offset: 0x1CA1720 VA: 0x181CA2520
	public void .ctor(Stream stream, long contentLength, HttpContentHeaders headers) { }

	// RVA: 0x1CA2510 Offset: 0x1CA1710 VA: 0x181CA2510 Slot: 8
	protected override bool TryComputeLength(out long length) { }
}

// Namespace: 
[CompilerGenerated]
private struct GzipBufferedRequestBodyHandler.<SendAsync>d__3 : IAsyncStateMachine // TypeDefIndex: 13684
{
	// Fields
	public int <>1__state; // 0x0
	[Nullable(0)]
	public AsyncTaskMethodBuilder<HttpResponseMessage> <>t__builder; // 0x8
	[Nullable(0)]
	public HttpRequestMessage request; // 0x20
	[Nullable(0)]
	public GzipBufferedRequestBodyHandler <>4__this; // 0x28
	public CancellationToken cancellationToken; // 0x30
	[Nullable(0)]
	private MemoryStream <memoryStream>5__2; // 0x38
	[Nullable(0)]
	private GZipStream <>7__wrap2; // 0x40
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x48
	[Nullable(0)]
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<HttpResponseMessage> <>u__2; // 0x58

	// Methods

	// RVA: 0x1CBC980 Offset: 0x1CBBB80 VA: 0x181CBC980 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1CBCFD0 Offset: 0x1CBC1D0 VA: 0x181CBCFD0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: Sentry.Internal.Http
[NullableContext(1)]
[Nullable(0)]
internal class GzipBufferedRequestBodyHandler : DelegatingHandler // TypeDefIndex: 13685
{
	// Fields
	private const string Gzip = "gzip";
	private readonly CompressionLevel _compressionLevel; // 0x20

	// Methods

	// RVA: 0x1CABB50 Offset: 0x1CAAD50 VA: 0x181CABB50
	public void .ctor(HttpMessageHandler innerHandler, CompressionLevel compressionLevel) { }

	[AsyncStateMachine(typeof(GzipBufferedRequestBodyHandler.<SendAsync>d__3))]
	// RVA: 0x1CABA30 Offset: 0x1CAAC30 VA: 0x181CABA30 Slot: 6
	protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken) { }

	[NullableContext(0)]
	[CompilerGenerated]
	[DebuggerHidden]
	// RVA: 0x1C5C590 Offset: 0x1C5B790 VA: 0x181C5C590
	private Task<HttpResponseMessage> <>n__0(HttpRequestMessage request, CancellationToken cancellationToken) { }
}

// Namespace: 
[CompilerGenerated]
private struct GzipRequestBodyHandler.GzipContent.<SerializeToStreamAsync>d__4 : IAsyncStateMachine // TypeDefIndex: 13686
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	[Nullable(0)]
	public Stream stream; // 0x20
	[Nullable(0)]
	public GzipRequestBodyHandler.GzipContent <>4__this; // 0x28
	[Nullable(0)]
	private GZipStream <>7__wrap1; // 0x30
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x38

	// Methods

	// RVA: 0x1CBE4A0 Offset: 0x1CBD6A0 VA: 0x181CBE4A0 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1CBE7F0 Offset: 0x1CBD9F0 VA: 0x181CBE7F0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[Nullable(0)]
internal class GzipRequestBodyHandler.GzipContent : HttpContent // TypeDefIndex: 13687
{
	// Fields
	private readonly HttpContent _content; // 0x30
	private readonly CompressionLevel _compressionLevel; // 0x38

	// Methods

	// RVA: 0x1CABCF0 Offset: 0x1CAAEF0 VA: 0x181CABCF0
	public void .ctor(HttpContent content, CompressionLevel compressionLevel) { }

	// RVA: 0x1CABCE0 Offset: 0x1CAAEE0 VA: 0x181CABCE0 Slot: 8
	protected override bool TryComputeLength(out long length) { }

	[AsyncStateMachine(typeof(GzipRequestBodyHandler.GzipContent.<SerializeToStreamAsync>d__4))]
	// RVA: 0x1CABC00 Offset: 0x1CAAE00 VA: 0x181CABC00 Slot: 7
	protected override Task SerializeToStreamAsync(Stream stream, TransportContext context) { }
}

// Namespace: Sentry.Internal.Http
[NullableContext(1)]
[Nullable(0)]
internal class GzipRequestBodyHandler : DelegatingHandler // TypeDefIndex: 13688
{
	// Fields
	private const string Gzip = "gzip";
	private readonly CompressionLevel _compressionLevel; // 0x20

	// Methods

	// RVA: 0x1CAC020 Offset: 0x1CAB220 VA: 0x181CAC020
	public void .ctor(HttpMessageHandler innerHandler, CompressionLevel compressionLevel) { }

	// RVA: 0x1CABF70 Offset: 0x1CAB170 VA: 0x181CABF70 Slot: 6
	protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken) { }
}

// Namespace: 
[CompilerGenerated]
private struct HttpTransport.<SendEnvelopeAsync>d__3 : IAsyncStateMachine // TypeDefIndex: 13689
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	[Nullable(0)]
	public HttpTransport <>4__this; // 0x20
	[Nullable(0)]
	public Envelope envelope; // 0x28
	public CancellationToken cancellationToken; // 0x30
	[Nullable(0)]
	private Envelope <processedEnvelope>5__2; // 0x38
	[Nullable(0)]
	private HttpRequestMessage <request>5__3; // 0x40
	[Nullable(0)]
	private HttpResponseMessage <response>5__4; // 0x48
	[Nullable(0)]
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<HttpResponseMessage> <>u__1; // 0x50
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2; // 0x60

	// Methods

	// RVA: 0x1CBD8B0 Offset: 0x1CBCAB0 VA: 0x181CBD8B0 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1CBE220 Offset: 0x1CBD420 VA: 0x181CBE220 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: Sentry.Internal.Http
[Nullable(0)]
[NullableContext(1)]
internal class HttpTransport : HttpTransportBase, ITransport // TypeDefIndex: 13690
{
	// Fields
	private readonly HttpClient _httpClient; // 0x38

	// Methods

	// RVA: 0x1CAF960 Offset: 0x1CAEB60 VA: 0x181CAF960
	public void .ctor(SentryOptions options, HttpClient httpClient) { }

	// RVA: 0x1CAF820 Offset: 0x1CAEA20 VA: 0x181CAF820
	internal void .ctor(SentryOptions options, HttpClient httpClient, Func<string, string> getEnvironmentVariable, ISystemClock clock) { }

	[AsyncStateMachine(typeof(HttpTransport.<SendEnvelopeAsync>d__3))]
	// RVA: 0x1CAF720 Offset: 0x1CAE920 VA: 0x181CAF720 Slot: 4
	public Task SendEnvelopeAsync(Envelope envelope, CancellationToken cancellationToken) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class LazyHttpTransport.<>c__DisplayClass1_0 // TypeDefIndex: 13691
{
	// Fields
	[Nullable(0)]
	public SentryOptions options; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1CBFE20 Offset: 0x1CBF020 VA: 0x181CBFE20
	internal HttpTransport <.ctor>b__0() { }
}

// Namespace: Sentry.Internal.Http
[NullableContext(1)]
[Nullable(0)]
internal class LazyHttpTransport : ITransport // TypeDefIndex: 13692
{
	// Fields
	private readonly Lazy<HttpTransport> _httpTransport; // 0x10

	// Methods

	// RVA: 0x1CB4690 Offset: 0x1CB3890 VA: 0x181CB4690
	public void .ctor(SentryOptions options) { }

	// RVA: 0x1CB4550 Offset: 0x1CB3750 VA: 0x181CB4550 Slot: 4
	public Task SendEnvelopeAsync(Envelope envelope, CancellationToken cancellationToken) { }
}

// Namespace: 
[CompilerGenerated]
private static class RateLimit.<>O // TypeDefIndex: 13693
{
	// Fields
	[Nullable(0)]
	public static Func<string, RateLimit> <0>__Parse; // 0x0
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class RateLimit.<>c // TypeDefIndex: 13694
{
	// Fields
	[Nullable(0)]
	public static readonly RateLimit.<>c <>9; // 0x0
	[Nullable(0)]
	public static Func<string, RateLimitCategory> <>9__7_0; // 0x8

	// Methods

	// RVA: 0x1CC0040 Offset: 0x1CBF240 VA: 0x181CC0040
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	[NullableContext(0)]
	// RVA: 0x1CBFCB0 Offset: 0x1CBEEB0 VA: 0x181CBFCB0
	internal RateLimitCategory <Parse>b__7_0(string c) { }
}

// Namespace: Sentry.Internal.Http
[Nullable(0)]
[NullableContext(1)]
internal class RateLimit // TypeDefIndex: 13695
{
	// Fields
	[CompilerGenerated]
	private readonly IReadOnlyList<RateLimitCategory> <Categories>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly TimeSpan <RetryAfter>k__BackingField; // 0x18

	// Properties
	public IReadOnlyList<RateLimitCategory> Categories { get; }
	public TimeSpan RetryAfter { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public IReadOnlyList<RateLimitCategory> get_Categories() { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public TimeSpan get_RetryAfter() { }

	// RVA: 0x1CB6740 Offset: 0x1CB5940 VA: 0x181CB6740
	public void .ctor(IReadOnlyList<RateLimitCategory> categories, TimeSpan retryAfter) { }

	// RVA: 0x1CB64B0 Offset: 0x1CB56B0 VA: 0x181CB64B0
	public static RateLimit Parse(string rateLimitEncoded) { }

	// RVA: 0x1CB63A0 Offset: 0x1CB55A0 VA: 0x181CB63A0
	public static IEnumerable<RateLimit> ParseMany(string rateLimitsEncoded) { }
}

// Namespace: Sentry.Internal.Http
[Nullable(0)]
[NullableContext(1)]
internal class RateLimitCategory : IEquatable<RateLimitCategory> // TypeDefIndex: 13696
{
	// Fields
	[CompilerGenerated]
	private readonly string <Name>k__BackingField; // 0x10

	// Properties
	public string Name { get; }
	public bool IsMatchAll { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_Name() { }

	// RVA: 0x1CB6390 Offset: 0x1CB5590 VA: 0x181CB6390
	public bool get_IsMatchAll() { }

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	public void .ctor(string name) { }

	// RVA: 0x1CB6310 Offset: 0x1CB5510 VA: 0x181CB6310
	public bool Matches(EnvelopeItem item) { }

	[NullableContext(2)]
	// RVA: 0x1CB6100 Offset: 0x1CB5300 VA: 0x181CB6100 Slot: 4
	public bool Equals(RateLimitCategory other) { }

	[NullableContext(2)]
	// RVA: 0x1CB6130 Offset: 0x1CB5330 VA: 0x181CB6130 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1CB6260 Offset: 0x1CB5460 VA: 0x181CB6260 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: 
[CompilerGenerated]
private struct RetryAfterHandler.<SendAsync>d__8 : IAsyncStateMachine // TypeDefIndex: 13697
{
	// Fields
	public int <>1__state; // 0x0
	[Nullable(0)]
	public AsyncTaskMethodBuilder<HttpResponseMessage> <>t__builder; // 0x8
	[Nullable(0)]
	public RetryAfterHandler <>4__this; // 0x20
	[Nullable(0)]
	public HttpRequestMessage request; // 0x28
	public CancellationToken cancellationToken; // 0x30
	[Nullable(0)]
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<HttpResponseMessage> <>u__1; // 0x38

	// Methods

	// RVA: 0x1CBD040 Offset: 0x1CBC240 VA: 0x181CBD040 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1CBD390 Offset: 0x1CBC590 VA: 0x181CBD390 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: Sentry.Internal.Http
[Nullable(0)]
[NullableContext(1)]
internal class RetryAfterHandler : DelegatingHandler // TypeDefIndex: 13698
{
	// Fields
	private readonly ISystemClock _clock; // 0x20
	private const HttpStatusCode TooManyRequests = 429;
	internal static readonly TimeSpan DefaultRetryAfterDelay; // 0x0
	private long _retryAfterUtcTicks; // 0x28

	// Properties
	internal long RetryAfterUtcTicks { get; }

	// Methods

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	internal long get_RetryAfterUtcTicks() { }

	// RVA: 0x1CB7230 Offset: 0x1CB6430 VA: 0x181CB7230
	public void .ctor(HttpMessageHandler innerHandler) { }

	// RVA: 0x1CB71B0 Offset: 0x1CB63B0 VA: 0x181CB71B0
	internal void .ctor(HttpMessageHandler innerHandler, ISystemClock clock) { }

	[AsyncStateMachine(typeof(RetryAfterHandler.<SendAsync>d__8))]
	// RVA: 0x1CB7040 Offset: 0x1CB6240 VA: 0x181CB7040 Slot: 6
	protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken) { }

	// RVA: 0x1CB6D10 Offset: 0x1CB5F10 VA: 0x181CB6D10
	private DateTimeOffset GetRetryAfterTimestamp(HttpResponseMessage response) { }

	// RVA: 0x1CB7140 Offset: 0x1CB6340 VA: 0x181CB7140
	private static void .cctor() { }

	[DebuggerHidden]
	[CompilerGenerated]
	[NullableContext(0)]
	// RVA: 0x1C5C590 Offset: 0x1C5B790 VA: 0x181C5C590
	private Task<HttpResponseMessage> <>n__0(HttpRequestMessage request, CancellationToken cancellationToken) { }
}

// Namespace: Sentry.Internal.Extensions
[Extension]
internal static class ClientReportExtensions // TypeDefIndex: 13699
{
	// Methods

	[NullableContext(1)]
	[Extension]
	// RVA: 0x1CA4340 Offset: 0x1CA3540 VA: 0x181CA4340
	public static void RecordDiscardedEvents(IClientReportRecorder recorder, DiscardReason reason, Envelope envelope) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class CollectionsExtensions.<>c__0<TValue> // TypeDefIndex: 13700
{
	// Fields
	[Nullable(0)]
	public static readonly CollectionsExtensions.<>c__0<TValue> <>9; // 0x0
	[Nullable(new[] { 0, 1, 1 })]
	public static Func<string, object> <>9__0_0; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB08330 Offset: 0xB07530 VA: 0x180B08330
	|-CollectionsExtensions.<>c__0<object>..cctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	|-CollectionsExtensions.<>c__0<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal object <GetOrCreate>b__0_0(string _) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB08310 Offset: 0xB07510 VA: 0x180B08310
	|-CollectionsExtensions.<>c__0<object>.<GetOrCreate>b__0_0
	*/
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class CollectionsExtensions.<>c__2<TKey, TValue> // TypeDefIndex: 13701
{
	// Fields
	[Nullable(0)]
	public static readonly CollectionsExtensions.<>c__2<TKey, TValue> <>9; // 0x0
	[Nullable(0)]
	public static Func<KeyValuePair<TKey, TValue>, TKey> <>9__2_0; // 0x0
	[Nullable(0)]
	public static Func<KeyValuePair<TKey, TValue>, TValue> <>9__2_1; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB08330 Offset: 0xB07530 VA: 0x180B08330
	|-CollectionsExtensions.<>c__2<object, object>..cctor
	|
	|-RVA: 0xB08640 Offset: 0xB07840 VA: 0x180B08640
	|-CollectionsExtensions.<>c__2<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..cctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	|-CollectionsExtensions.<>c__2<object, object>..ctor
	|-CollectionsExtensions.<>c__2<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	[NullableContext(0)]
	// RVA: -1 Offset: -1
	internal TKey <ToDictionary>b__2_0(KeyValuePair<TKey, TValue> kvp) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB08210 Offset: 0xB07410 VA: 0x180B08210
	|-CollectionsExtensions.<>c__2<object, object>.<ToDictionary>b__2_0
	|
	|-RVA: 0xB069E0 Offset: 0xB05BE0 VA: 0x180B069E0
	|-CollectionsExtensions.<>c__2<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<ToDictionary>b__2_0
	*/

	[NullableContext(0)]
	// RVA: -1 Offset: -1
	internal TValue <ToDictionary>b__2_1(KeyValuePair<TKey, TValue> kvp) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB08300 Offset: 0xB07500 VA: 0x180B08300
	|-CollectionsExtensions.<>c__2<object, object>.<ToDictionary>b__2_1
	|
	|-RVA: 0xB08260 Offset: 0xB07460 VA: 0x180B08260
	|-CollectionsExtensions.<>c__2<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<ToDictionary>b__2_1
	*/
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class CollectionsExtensions.<>c__7<T> // TypeDefIndex: 13702
{
	// Fields
	[Nullable(0)]
	public static readonly CollectionsExtensions.<>c__7<T> <>9; // 0x0
	[Nullable(0)]
	public static Func<T, bool> <>9__7_0; // 0x0
	[Nullable(0)]
	public static Func<T, T> <>9__7_1; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB08330 Offset: 0xB07530 VA: 0x180B08330
	|-CollectionsExtensions.<>c__7<object>..cctor
	|
	|-RVA: 0xB08640 Offset: 0xB07840 VA: 0x180B08640
	|-CollectionsExtensions.<>c__7<__Il2CppFullySharedGenericType>..cctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	|-CollectionsExtensions.<>c__7<object>..ctor
	|-CollectionsExtensions.<>c__7<__Il2CppFullySharedGenericType>..ctor
	*/

	[NullableContext(0)]
	// RVA: -1 Offset: -1
	internal bool <ExceptNulls>b__7_0(T x) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB09CD0 Offset: 0xB08ED0 VA: 0x180B09CD0
	|-CollectionsExtensions.<>c__7<object>.<ExceptNulls>b__7_0
	|
	|-RVA: 0xB09CE0 Offset: 0xB08EE0 VA: 0x180B09CE0
	|-CollectionsExtensions.<>c__7<__Il2CppFullySharedGenericType>.<ExceptNulls>b__7_0
	*/

	[NullableContext(0)]
	// RVA: -1 Offset: -1
	internal T <ExceptNulls>b__7_1(T x) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x70E580 Offset: 0x70D780 VA: 0x18070E580
	|-CollectionsExtensions.<>c__7<object>.<ExceptNulls>b__7_1
	|
	|-RVA: 0xB08170 Offset: 0xB07370 VA: 0x180B08170
	|-CollectionsExtensions.<>c__7<__Il2CppFullySharedGenericType>.<ExceptNulls>b__7_1
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class CollectionsExtensions.<WhereNotNullValue>d__3<TKey, TValue> : IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, IEnumerator<KeyValuePair<TKey, TValue>>, IEnumerator, IDisposable // TypeDefIndex: 13703
{
	// Fields
	private int <>1__state; // 0x0
	[Nullable(new[] { 0, 1, 0 })]
	private KeyValuePair<TKey, TValue> <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	[Nullable(new[] { 0, 0, 1, 2 })]
	private IEnumerable<KeyValuePair<TKey, TValue>> source; // 0x0
	[Nullable(new[] { 0, 0, 1, 2 })]
	public IEnumerable<KeyValuePair<TKey, TValue>> <>3__source; // 0x0
	[Nullable(new[] { 0, 0, 1, 2 })]
	private IEnumerator<KeyValuePair<TKey, TValue>> <>7__wrap1; // 0x0

	// Properties
	private KeyValuePair<TKey, TValue> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB028A0 Offset: 0xB01AA0 VA: 0x180B028A0
	|-CollectionsExtensions.<WhereNotNullValue>d__3<object, object>..ctor
	|
	|-RVA: 0xB027F0 Offset: 0xB019F0 VA: 0x180B027F0
	|-CollectionsExtensions.<WhereNotNullValue>d__3<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF55D80 Offset: 0xF54F80 VA: 0x180F55D80
	|-CollectionsExtensions.<WhereNotNullValue>d__3<object, object>.System.IDisposable.Dispose
	|
	|-RVA: 0xB02530 Offset: 0xB01730 VA: 0x180B02530
	|-CollectionsExtensions.<WhereNotNullValue>d__3<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF55900 Offset: 0xF54B00 VA: 0x180F55900
	|-CollectionsExtensions.<WhereNotNullValue>d__3<object, object>.MoveNext
	|
	|-RVA: 0xF55420 Offset: 0xF54620 VA: 0x180F55420
	|-CollectionsExtensions.<WhereNotNullValue>d__3<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF55F00 Offset: 0xF55100 VA: 0x180F55F00
	|-CollectionsExtensions.<WhereNotNullValue>d__3<object, object>.<>m__Finally1
	|
	|-RVA: 0xF55E20 Offset: 0xF55020 VA: 0x180F55E20
	|-CollectionsExtensions.<WhereNotNullValue>d__3<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<>m__Finally1
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 6
	private KeyValuePair<TKey, TValue> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x42D820 Offset: 0x42CA20 VA: 0x18042D820
	|-CollectionsExtensions.<WhereNotNullValue>d__3<object, object>.System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_Current
	|
	|-RVA: 0xB02120 Offset: 0xB01320 VA: 0x180B02120
	|-CollectionsExtensions.<WhereNotNullValue>d__3<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB02370 Offset: 0xB01570 VA: 0x180B02370
	|-CollectionsExtensions.<WhereNotNullValue>d__3<object, object>.System.Collections.IEnumerator.Reset
	|-CollectionsExtensions.<WhereNotNullValue>d__3<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB02460 Offset: 0xB01660 VA: 0x180B02460
	|-CollectionsExtensions.<WhereNotNullValue>d__3<object, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0xB023B0 Offset: 0xB015B0 VA: 0x180B023B0
	|-CollectionsExtensions.<WhereNotNullValue>d__3<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<KeyValuePair<TKey, TValue>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB03B70 Offset: 0xB02D70 VA: 0x180B03B70
	|-CollectionsExtensions.<WhereNotNullValue>d__3<object, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0xF55B70 Offset: 0xF54D70 VA: 0x180F55B70
	|-CollectionsExtensions.<WhereNotNullValue>d__3<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF55CD0 Offset: 0xF54ED0 VA: 0x180F55CD0
	|-CollectionsExtensions.<WhereNotNullValue>d__3<object, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xBCB590 Offset: 0xBCA790 VA: 0x180BCB590
	|-CollectionsExtensions.<WhereNotNullValue>d__3<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: Sentry.Internal.Extensions
[Extension]
[Nullable(0)]
[NullableContext(1)]
internal static class CollectionsExtensions // TypeDefIndex: 13704
{
	// Methods

	[Extension]
	// RVA: -1 Offset: -1
	public static TValue GetOrCreate<TValue>(ConcurrentDictionary<string, object> dictionary, string key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x94B670 Offset: 0x94A870 VA: 0x18094B670
	|-CollectionsExtensions.GetOrCreate<object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static void TryCopyTo<TKey, TValue>(IDictionary<TKey, TValue> from, IDictionary<TKey, TValue> to) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x94C410 Offset: 0x94B610 VA: 0x18094C410
	|-CollectionsExtensions.TryCopyTo<object, object>
	|
	|-RVA: 0x94BEF0 Offset: 0x94B0F0 VA: 0x18094BEF0
	|-CollectionsExtensions.TryCopyTo<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static Dictionary<TKey, TValue> ToDictionary<TKey, TValue>(IEnumerable<KeyValuePair<TKey, TValue>> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x94BC50 Offset: 0x94AE50 VA: 0x18094BC50
	|-CollectionsExtensions.ToDictionary<object, object>
	|
	|-RVA: 0x94B9B0 Offset: 0x94ABB0 VA: 0x18094B9B0
	|-CollectionsExtensions.ToDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	[IteratorStateMachine(typeof(CollectionsExtensions.<WhereNotNullValue>d__3<TKey, TValue>))]
	// RVA: -1 Offset: -1
	public static IEnumerable<KeyValuePair<TKey, TValue>> WhereNotNullValue<TKey, TValue>(IEnumerable<KeyValuePair<TKey, TValue>> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x94CBB0 Offset: 0x94BDB0 VA: 0x18094CBB0
	|-CollectionsExtensions.WhereNotNullValue<object, object>
	|
	|-RVA: 0x94CB00 Offset: 0x94BD00 VA: 0x18094CB00
	|-CollectionsExtensions.WhereNotNullValue<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<KeyValuePair<TKey, TValue>> Append<TKey, TValue>(IEnumerable<KeyValuePair<TKey, TValue>> source, TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x94AF20 Offset: 0x94A120 VA: 0x18094AF20
	|-CollectionsExtensions.Append<object, object>
	|
	|-RVA: 0x94AD00 Offset: 0x949F00 VA: 0x18094AD00
	|-CollectionsExtensions.Append<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IReadOnlyList<T> AsReadOnly<T>(IList<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x94B020 Offset: 0x94A220 VA: 0x18094B020
	|-CollectionsExtensions.AsReadOnly<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IReadOnlyDictionary<TKey, TValue> AsReadOnly<TKey, TValue>(IDictionary<TKey, TValue> dictionary) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x94B0C0 Offset: 0x94A2C0 VA: 0x18094B0C0
	|-CollectionsExtensions.AsReadOnly<object, object>
	|
	|-RVA: 0x94AFB0 Offset: 0x94A1B0 VA: 0x18094AFB0
	|-CollectionsExtensions.AsReadOnly<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<T> ExceptNulls<T>(IEnumerable<T> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x94B3D0 Offset: 0x94A5D0 VA: 0x18094B3D0
	|-CollectionsExtensions.ExceptNulls<object>
	|
	|-RVA: 0x94B130 Offset: 0x94A330 VA: 0x18094B130
	|-CollectionsExtensions.ExceptNulls<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static bool TryGetTypedValue<T>(IDictionary<string, object> source, string key, out T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x94C980 Offset: 0x94BB80 VA: 0x18094C980
	|-CollectionsExtensions.TryGetTypedValue<object>
	|
	|-RVA: 0x94C750 Offset: 0x94B950 VA: 0x18094C750
	|-CollectionsExtensions.TryGetTypedValue<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: Sentry.Internal.Extensions
[Extension]
internal static class DisposableExtensions // TypeDefIndex: 13705
{
	// Methods

	[Extension]
	[NullableContext(1)]
	// RVA: 0x1CA6120 Offset: 0x1CA5320 VA: 0x181CA6120
	public static void DisposeAll(IEnumerable<IDisposable> disposables) { }
}

// Namespace: Sentry.Internal.Extensions
[Extension]
internal static class EnumExtensions // TypeDefIndex: 13706
{
	// Methods

	[Extension]
	// RVA: -1 Offset: -1
	public static T ParseEnum<T>(string str) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x965610 Offset: 0x964810 VA: 0x180965610
	|-EnumExtensions.ParseEnum<Int16Enum>
	|
	|-RVA: 0x965700 Offset: 0x964900 VA: 0x180965700
	|-EnumExtensions.ParseEnum<Int32Enum>
	|
	|-RVA: 0x9654F0 Offset: 0x9646F0 VA: 0x1809654F0
	|-EnumExtensions.ParseEnum<__Il2CppFullySharedGenericStructType>
	*/
}

// Namespace: Sentry.Internal.Extensions
[Extension]
internal static class HashExtensions // TypeDefIndex: 13707
{
	// Methods

	[NullableContext(1)]
	[Extension]
	// RVA: 0x1CAC0D0 Offset: 0x1CAB2D0 VA: 0x181CAC0D0
	public static string GetHashString(string str, bool upperCase = True) { }
}

// Namespace: 
[CompilerGenerated]
private struct HttpClientExtensions.<ReadAsJsonAsync>d__0 : IAsyncStateMachine // TypeDefIndex: 13708
{
	// Fields
	public int <>1__state; // 0x0
	[Nullable(0)]
	public AsyncTaskMethodBuilder<JsonElement> <>t__builder; // 0x8
	[Nullable(0)]
	public HttpContent content; // 0x20
	public CancellationToken cancellationToken; // 0x28
	[Nullable(new[] { 0, 1 })]
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Stream> <>u__1; // 0x30
	[Nullable(0)]
	private Stream <>7__wrap1; // 0x40
	[Nullable(new[] { 0, 1 })]
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<JsonDocument> <>u__2; // 0x48

	// Methods

	// RVA: 0x1CBB840 Offset: 0x1CBAA40 VA: 0x181CBB840 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1CBBE20 Offset: 0x1CBB020 VA: 0x181CBBE20 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: Sentry.Internal.Extensions
[NullableContext(1)]
[Nullable(0)]
[Extension]
internal static class HttpClientExtensions // TypeDefIndex: 13709
{
	// Methods

	[AsyncStateMachine(typeof(HttpClientExtensions.<ReadAsJsonAsync>d__0))]
	[Extension]
	// RVA: 0x1CAC340 Offset: 0x1CAB540 VA: 0x181CAC340
	public static Task<JsonElement> ReadAsJsonAsync(HttpContent content, CancellationToken cancellationToken) { }

	[Extension]
	// RVA: 0x1CAC450 Offset: 0x1CAB650 VA: 0x181CAC450
	public static JsonElement ReadAsJson(HttpContent content) { }

	[Extension]
	// RVA: 0x1CAC5F0 Offset: 0x1CAB7F0 VA: 0x181CAC5F0
	public static string ReadAsString(HttpContent content) { }
}

// Namespace: 
[CompilerGenerated]
private static class JsonExtensions.<>O // TypeDefIndex: 13710
{
	// Fields
	[Nullable(0)]
	public static Func<JsonElement, object> <0>__GetDynamicOrNull; // 0x0
}

// Namespace: Sentry.Internal.Extensions
[Extension]
[NullableContext(1)]
[Nullable(0)]
internal static class JsonExtensions // TypeDefIndex: 13711
{
	// Fields
	private static readonly JsonConverter[] DefaultConverters; // 0x0
	[CompilerGenerated]
	private static bool <JsonPreserveReferences>k__BackingField; // 0x8
	private static JsonSerializerOptions SerializerOptions; // 0x10
	private static JsonSerializerOptions AltSerializerOptions; // 0x18

	// Properties
	internal static bool JsonPreserveReferences { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1CB44A0 Offset: 0x1CB36A0 VA: 0x181CB44A0
	internal static bool get_JsonPreserveReferences() { }

	[CompilerGenerated]
	// RVA: 0x1CB44F0 Offset: 0x1CB36F0 VA: 0x181CB44F0
	internal static void set_JsonPreserveReferences(bool value) { }

	// RVA: 0x1CB4050 Offset: 0x1CB3250 VA: 0x181CB4050
	private static void .cctor() { }

	// RVA: 0x1CB1E20 Offset: 0x1CB1020 VA: 0x181CB1E20
	internal static void ResetSerializerOptions() { }

	// RVA: 0x1CB1040 Offset: 0x1CB0240 VA: 0x181CB1040
	internal static void AddJsonConverter(JsonConverter converter) { }

	[Extension]
	// RVA: 0x1CB0ED0 Offset: 0x1CB00D0 VA: 0x181CB0ED0
	private static JsonSerializerOptions AddDefaultConverters(JsonSerializerOptions options) { }

	[Extension]
	// RVA: 0x1CB1200 Offset: 0x1CB0400 VA: 0x181CB1200
	public static void Deconstruct(JsonProperty jsonProperty, out string name, out JsonElement value) { }

	[Extension]
	// RVA: 0x1CB13F0 Offset: 0x1CB05F0 VA: 0x181CB13F0
	public static Dictionary<string, object> GetDictionaryOrNull(JsonElement json) { }

	[NullableContext(0)]
	[Extension]
	// RVA: -1 Offset: -1
	public static Dictionary<string, TValue> GetDictionaryOrNull<TValue>(JsonElement json, Func<JsonElement, TValue> factory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA26F40 Offset: 0xA26140 VA: 0x180A26F40
	|-JsonExtensions.GetDictionaryOrNull<object>
	|
	|-RVA: 0xA26C70 Offset: 0xA25E70 VA: 0x180A26C70
	|-JsonExtensions.GetDictionaryOrNull<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: 0x1CB1B20 Offset: 0x1CB0D20 VA: 0x181CB1B20
	public static Dictionary<string, string> GetStringDictionaryOrNull(JsonElement json) { }

	[Extension]
	// RVA: 0x1CB1A20 Offset: 0x1CB0C20 VA: 0x181CB1A20
	public static Nullable<JsonElement> GetPropertyOrNull(JsonElement json, string name) { }

	[NullableContext(2)]
	[Extension]
	// RVA: 0x1CB1600 Offset: 0x1CB0800 VA: 0x181CB1600
	public static object GetDynamicOrNull(JsonElement json) { }

	[Extension]
	[NullableContext(2)]
	// RVA: 0x1CB1930 Offset: 0x1CB0B30 VA: 0x181CB1930
	private static object GetNumber(JsonElement json) { }

	[Extension]
	// RVA: 0x1CB1240 Offset: 0x1CB0440 VA: 0x181CB1240
	public static Nullable<long> GetAddressAsLong(JsonElement json) { }

	[Extension]
	// RVA: 0x1CB1DB0 Offset: 0x1CB0FB0 VA: 0x181CB1DB0
	public static string GetStringOrThrow(JsonElement json) { }

	[Extension]
	// RVA: 0x1CB21D0 Offset: 0x1CB13D0 VA: 0x181CB21D0
	public static void WriteDictionaryValue(Utf8JsonWriter writer, IEnumerable<KeyValuePair<string, object>> dic, IDiagnosticLogger logger, bool includeNullValues = True) { }

	[Extension]
	[NullableContext(2)]
	// RVA: -1 Offset: -1
	public static void WriteDictionaryValue<TValue>(Utf8JsonWriter writer, IEnumerable<KeyValuePair<string, TValue>> dic, IDiagnosticLogger logger, bool includeNullValues = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA285E0 Offset: 0xA277E0 VA: 0x180A285E0
	|-JsonExtensions.WriteDictionaryValue<object>
	|
	|-RVA: 0xA28190 Offset: 0xA27390 VA: 0x180A28190
	|-JsonExtensions.WriteDictionaryValue<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: 0x1CB3BD0 Offset: 0x1CB2DD0 VA: 0x181CB3BD0
	public static void WriteStringDictionaryValue(Utf8JsonWriter writer, IEnumerable<KeyValuePair<string, string>> dic) { }

	[Extension]
	// RVA: 0x1CB2670 Offset: 0x1CB1870 VA: 0x181CB2670
	public static void WriteDictionary(Utf8JsonWriter writer, string propertyName, IEnumerable<KeyValuePair<string, object>> dic, IDiagnosticLogger logger) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static void WriteDictionary<TValue>(Utf8JsonWriter writer, string propertyName, IEnumerable<KeyValuePair<string, TValue>> dic, IDiagnosticLogger logger) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA289A0 Offset: 0xA27BA0 VA: 0x180A289A0
	|-JsonExtensions.WriteDictionary<object>
	|
	|-RVA: 0xA288E0 Offset: 0xA27AE0 VA: 0x180A288E0
	|-JsonExtensions.WriteDictionary<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: 0x1CB3E30 Offset: 0x1CB3030 VA: 0x181CB3E30
	public static void WriteStringDictionary(Utf8JsonWriter writer, string propertyName, IEnumerable<KeyValuePair<string, string>> dic) { }

	[Extension]
	[NullableContext(2)]
	// RVA: -1 Offset: -1
	public static void WriteArrayValue<T>(Utf8JsonWriter writer, IEnumerable<T> arr, IDiagnosticLogger logger) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA27690 Offset: 0xA26890 VA: 0x180A27690
	|-JsonExtensions.WriteArrayValue<GrowableArray<int>>
	|
	|-RVA: 0xA27BE0 Offset: 0xA26DE0 VA: 0x180A27BE0
	|-JsonExtensions.WriteArrayValue<object>
	|
	|-RVA: 0xA278E0 Offset: 0xA26AE0 VA: 0x180A278E0
	|-JsonExtensions.WriteArrayValue<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static void WriteArray<T>(Utf8JsonWriter writer, string propertyName, IEnumerable<T> arr, IDiagnosticLogger logger) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA27E10 Offset: 0xA27010 VA: 0x180A27E10
	|-JsonExtensions.WriteArray<GrowableArray<int>>
	|
	|-RVA: 0xA27F70 Offset: 0xA27170 VA: 0x180A27F70
	|-JsonExtensions.WriteArray<object>
	|
	|-RVA: 0xA27EC0 Offset: 0xA270C0 VA: 0x180A27EC0
	|-JsonExtensions.WriteArray<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: 0x1CB3830 Offset: 0x1CB2A30 VA: 0x181CB3830
	public static void WriteStringArrayValue(Utf8JsonWriter writer, IEnumerable<string> arr) { }

	[Extension]
	// RVA: 0x1CB3A20 Offset: 0x1CB2C20 VA: 0x181CB3A20
	public static void WriteStringArray(Utf8JsonWriter writer, string propertyName, IEnumerable<string> arr) { }

	[Extension]
	// RVA: 0x1CB35A0 Offset: 0x1CB27A0 VA: 0x181CB35A0
	public static void WriteSerializableValue(Utf8JsonWriter writer, IJsonSerializable value, IDiagnosticLogger logger) { }

	[Extension]
	// RVA: 0x1CB3670 Offset: 0x1CB2870 VA: 0x181CB3670
	public static void WriteSerializable(Utf8JsonWriter writer, string propertyName, IJsonSerializable value, IDiagnosticLogger logger) { }

	[NullableContext(2)]
	[Extension]
	// RVA: 0x1CB27A0 Offset: 0x1CB19A0 VA: 0x181CB27A0
	public static void WriteDynamicValue(Utf8JsonWriter writer, object value, IDiagnosticLogger logger) { }

	[Extension]
	// RVA: 0x1CB3080 Offset: 0x1CB2280 VA: 0x181CB3080
	public static void WriteDynamic(Utf8JsonWriter writer, string propertyName, object value, IDiagnosticLogger logger) { }

	[Extension]
	// RVA: 0x1CB1F50 Offset: 0x1CB1150 VA: 0x181CB1F50
	public static void WriteBooleanIfNotNull(Utf8JsonWriter writer, string propertyName, Nullable<bool> value) { }

	[Extension]
	// RVA: 0x1CB1FE0 Offset: 0x1CB11E0 VA: 0x181CB1FE0
	public static void WriteBooleanIfTrue(Utf8JsonWriter writer, string propertyName, Nullable<bool> value) { }

	[Extension]
	// RVA: 0x1CB31E0 Offset: 0x1CB23E0 VA: 0x181CB31E0
	public static void WriteNumberIfNotNull(Utf8JsonWriter writer, string propertyName, Nullable<short> value) { }

	[Extension]
	// RVA: 0x1CB3360 Offset: 0x1CB2560 VA: 0x181CB3360
	public static void WriteNumberIfNotNull(Utf8JsonWriter writer, string propertyName, Nullable<int> value) { }

	[Extension]
	// RVA: 0x1CB32E0 Offset: 0x1CB24E0 VA: 0x181CB32E0
	public static void WriteNumberIfNotNull(Utf8JsonWriter writer, string propertyName, Nullable<long> value) { }

	[Extension]
	// RVA: 0x1CB3260 Offset: 0x1CB2460 VA: 0x181CB3260
	public static void WriteNumberIfNotNull(Utf8JsonWriter writer, string propertyName, Nullable<float> value) { }

	[Extension]
	// RVA: 0x1CB3440 Offset: 0x1CB2640 VA: 0x181CB3440
	public static void WriteNumberIfNotZero(Utf8JsonWriter writer, string propertyName, short value) { }

	[Extension]
	// RVA: 0x1CB3410 Offset: 0x1CB2610 VA: 0x181CB3410
	public static void WriteNumberIfNotZero(Utf8JsonWriter writer, string propertyName, int value) { }

	[Extension]
	// RVA: 0x1CB3470 Offset: 0x1CB2670 VA: 0x181CB3470
	public static void WriteNumberIfNotZero(Utf8JsonWriter writer, string propertyName, long value) { }

	[Extension]
	// RVA: 0x1CB33E0 Offset: 0x1CB25E0 VA: 0x181CB33E0
	public static void WriteNumberIfNotZero(Utf8JsonWriter writer, string propertyName, float value) { }

	[Extension]
	// RVA: 0x1CB34A0 Offset: 0x1CB26A0 VA: 0x181CB34A0
	public static void WriteNumberIfNotZero(Utf8JsonWriter writer, string propertyName, double value) { }

	[Extension]
	// RVA: 0x1CB3F50 Offset: 0x1CB3150 VA: 0x181CB3F50
	public static void WriteStringIfNotWhiteSpace(Utf8JsonWriter writer, string propertyName, string value) { }

	[Extension]
	// RVA: 0x1CB3EB0 Offset: 0x1CB30B0 VA: 0x181CB3EB0
	public static void WriteStringIfNotNull(Utf8JsonWriter writer, string propertyName, Nullable<DateTimeOffset> value) { }

	[Extension]
	// RVA: 0x1CB34D0 Offset: 0x1CB26D0 VA: 0x181CB34D0
	public static void WriteSerializableIfNotNull(Utf8JsonWriter writer, string propertyName, IJsonSerializable value, IDiagnosticLogger logger) { }

	[Extension]
	// RVA: 0x1CB2080 Offset: 0x1CB1280 VA: 0x181CB2080
	public static void WriteDictionaryIfNotEmpty(Utf8JsonWriter writer, string propertyName, IEnumerable<KeyValuePair<string, object>> dic, IDiagnosticLogger logger) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static void WriteDictionaryIfNotEmpty<TValue>(Utf8JsonWriter writer, string propertyName, IEnumerable<KeyValuePair<string, TValue>> dic, IDiagnosticLogger logger) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA28020 Offset: 0xA27220 VA: 0x180A28020
	|-JsonExtensions.WriteDictionaryIfNotEmpty<object>
	|
	|-RVA: 0xA27410 Offset: 0xA26610 VA: 0x180A27410
	|-JsonExtensions.WriteDictionaryIfNotEmpty<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: 0x1CB3AA0 Offset: 0x1CB2CA0 VA: 0x181CB3AA0
	public static void WriteStringDictionaryIfNotEmpty(Utf8JsonWriter writer, string propertyName, IEnumerable<KeyValuePair<string, string>> dic) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static void WriteArrayIfNotEmpty<T>(Utf8JsonWriter writer, string propertyName, IEnumerable<T> arr, IDiagnosticLogger logger) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA27520 Offset: 0xA26720 VA: 0x180A27520
	|-JsonExtensions.WriteArrayIfNotEmpty<object>
	|
	|-RVA: 0xA27410 Offset: 0xA26610 VA: 0x180A27410
	|-JsonExtensions.WriteArrayIfNotEmpty<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: 0x1CB3700 Offset: 0x1CB2900 VA: 0x181CB3700
	public static void WriteStringArrayIfNotEmpty(Utf8JsonWriter writer, string propertyName, IEnumerable<string> arr) { }

	[Extension]
	// RVA: 0x1CB2710 Offset: 0x1CB1910 VA: 0x181CB2710
	public static void WriteDynamicIfNotNull(Utf8JsonWriter writer, string propertyName, object value, IDiagnosticLogger logger) { }

	[Extension]
	// RVA: 0x1CB3FB0 Offset: 0x1CB31B0 VA: 0x181CB3FB0
	public static void WriteString(Utf8JsonWriter writer, string propertyName, IEnumeration value) { }
}

// Namespace: Sentry.Internal.Extensions
[NullableContext(1)]
[Extension]
[Nullable(0)]
internal static class MiscExtensions // TypeDefIndex: 13712
{
	// Fields
	private static readonly TimeSpan MaxTimeout; // 0x0

	// Methods

	[Extension]
	// RVA: -1 Offset: -1
	public static TOut Pipe<TIn, TOut>(TIn input, Func<TIn, TOut> pipe) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA52150 Offset: 0xA51350 VA: 0x180A52150
	|-MiscExtensions.Pipe<JsonElement, object>
	|-MiscExtensions.Pipe<JsonElement, SpanId>
	|
	|-RVA: 0xA521A0 Offset: 0xA513A0 VA: 0x180A521A0
	|-MiscExtensions.Pipe<JsonElement, SentryId>
	|
	|-RVA: 0xA52210 Offset: 0xA51410 VA: 0x180A52210
	|-MiscExtensions.Pipe<object, object>
	|
	|-RVA: 0xA52260 Offset: 0xA51460 VA: 0x180A52260
	|-MiscExtensions.Pipe<object, SentryId>
	|
	|-RVA: 0xA52020 Offset: 0xA51220 VA: 0x180A52020
	|-MiscExtensions.Pipe<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	[NullableContext(0)]
	// RVA: -1 Offset: -1
	public static Nullable<T> NullIfDefault<T>(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA519C0 Offset: 0xA50BC0 VA: 0x180A519C0
	|-MiscExtensions.NullIfDefault<int>
	|
	|-RVA: 0xA51840 Offset: 0xA50A40 VA: 0x180A51840
	|-MiscExtensions.NullIfDefault<Int32Enum>
	|
	|-RVA: 0xA51B40 Offset: 0xA50D40 VA: 0x180A51B40
	|-MiscExtensions.NullIfDefault<long>
	|
	|-RVA: 0xA51CD0 Offset: 0xA50ED0 VA: 0x180A51CD0
	|-MiscExtensions.NullIfDefault<SentryId>
	|
	|-RVA: 0xA51E90 Offset: 0xA51090 VA: 0x180A51E90
	|-MiscExtensions.NullIfDefault<SpanId>
	|
	|-RVA: 0xA51620 Offset: 0xA50820 VA: 0x180A51620
	|-MiscExtensions.NullIfDefault<__Il2CppFullySharedGenericStructType>
	*/

	[Extension]
	// RVA: 0x1CB4E70 Offset: 0x1CB4070 VA: 0x181CB4E70
	public static string ToHexString(long l, bool upperCase = False) { }

	[Extension]
	// RVA: 0x1CB4C70 Offset: 0x1CB3E70 VA: 0x181CB4C70
	public static string ToHexString(byte[] bytes, bool upperCase = False) { }

	[Extension]
	[NullableContext(0)]
	// RVA: 0x1CB4DC0 Offset: 0x1CB3FC0 VA: 0x181CB4DC0
	public static string ToHexString(Span<byte> bytes, bool upperCase = False) { }

	[NullableContext(0)]
	[Extension]
	// RVA: 0x1CB4F00 Offset: 0x1CB4100 VA: 0x181CB4F00
	public static string ToHexString(ReadOnlySpan<byte> bytes, bool upperCase = False) { }

	[Extension]
	// RVA: 0x1CB4780 Offset: 0x1CB3980 VA: 0x181CB4780
	public static void CancelAfterSafe(CancellationTokenSource cts, TimeSpan timeout) { }

	[NullableContext(2)]
	[Extension]
	// RVA: 0x1CB4C60 Offset: 0x1CB3E60 VA: 0x181CB4C60
	public static bool IsNull(object o) { }

	[Extension]
	// RVA: 0x1CB49C0 Offset: 0x1CB3BC0 VA: 0x181CB49C0
	public static object GetProperty(object obj, string name) { }

	[Extension]
	// RVA: 0x1CB48E0 Offset: 0x1CB3AE0 VA: 0x181CB48E0
	public static Nullable<Guid> GetGuidProperty(object obj, string name) { }

	[Extension]
	// RVA: 0x1CB4BD0 Offset: 0x1CB3DD0 VA: 0x181CB4BD0
	public static string GetStringProperty(object obj, string name) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static void Add<TKey, TValue>(ICollection<KeyValuePair<TKey, TValue>> collection, TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA51500 Offset: 0xA50700 VA: 0x180A51500
	|-MiscExtensions.Add<object, object>
	|
	|-RVA: 0xA51280 Offset: 0xA50480 VA: 0x180A51280
	|-MiscExtensions.Add<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: 0x1CB4AF0 Offset: 0x1CB3CF0 VA: 0x181CB4AF0
	internal static string GetRawMessage(AggregateException exception) { }

	// RVA: 0x1CB5090 Offset: 0x1CB4290 VA: 0x181CB5090
	private static void .cctor() { }
}

// Namespace: Sentry.Internal.Extensions
[NullableContext(1)]
[Nullable(0)]
[Extension]
internal static class PEReaderExtensions // TypeDefIndex: 13713
{
	// Methods

	[Extension]
	// RVA: 0x1CB57E0 Offset: 0x1CB49E0 VA: 0x181CB57E0
	public static PEDebugImageData TryGetPEDebugImageData(PEReader peReader) { }

	[Extension]
	// RVA: 0x1CB52F0 Offset: 0x1CB44F0 VA: 0x181CB52F0
	private static PEDebugImageData GetPEDebugImageData(PEReader peReader) { }
}

// Namespace: Sentry.Internal.Extensions
[Nullable(0)]
[NullableContext(2)]
internal sealed class PEDebugImageData // TypeDefIndex: 13714
{
	// Fields
	[CompilerGenerated]
	private string <ImageAddress>k__BackingField; // 0x10
	[CompilerGenerated]
	private Nullable<long> <ImageSize>k__BackingField; // 0x18
	[CompilerGenerated]
	private string <DebugId>k__BackingField; // 0x28
	[CompilerGenerated]
	private string <DebugChecksum>k__BackingField; // 0x30
	[CompilerGenerated]
	private string <DebugFile>k__BackingField; // 0x38
	[CompilerGenerated]
	private string <CodeId>k__BackingField; // 0x40

	// Properties
	[Nullable(1)]
	public string Type { get; }
	public string ImageAddress { get; set; }
	public Nullable<long> ImageSize { get; set; }
	public string DebugId { get; set; }
	public string DebugChecksum { get; set; }
	public string DebugFile { get; set; }
	public string CodeId { get; set; }

	// Methods

	[NullableContext(1)]
	// RVA: 0x1CB52C0 Offset: 0x1CB44C0 VA: 0x181CB52C0
	public string get_Type() { }

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_ImageAddress() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_ImageAddress(string value) { }

	[CompilerGenerated]
	// RVA: 0x42D820 Offset: 0x42CA20 VA: 0x18042D820
	public Nullable<long> get_ImageSize() { }

	[CompilerGenerated]
	// RVA: 0x42D8A0 Offset: 0x42CAA0 VA: 0x18042D8A0
	public void set_ImageSize(Nullable<long> value) { }

	[CompilerGenerated]
	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public string get_DebugId() { }

	[CompilerGenerated]
	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	public void set_DebugId(string value) { }

	[CompilerGenerated]
	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public string get_DebugChecksum() { }

	[CompilerGenerated]
	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	public void set_DebugChecksum(string value) { }

	[CompilerGenerated]
	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public string get_DebugFile() { }

	[CompilerGenerated]
	// RVA: 0x40EC50 Offset: 0x40DE50 VA: 0x18040EC50
	public void set_DebugFile(string value) { }

	[CompilerGenerated]
	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	public string get_CodeId() { }

	[CompilerGenerated]
	// RVA: 0x415820 Offset: 0x414A20 VA: 0x180415820
	public void set_CodeId(string value) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: Sentry.Internal.Extensions
[Extension]
internal static class PEDebugImageDataExtensions // TypeDefIndex: 13715
{
	// Methods

	[NullableContext(2)]
	[Extension]
	// RVA: 0x1CB51C0 Offset: 0x1CB43C0 VA: 0x181CB51C0
	internal static DebugImage ToDebugImage(PEDebugImageData imageData, string codeFile, Nullable<Guid> moduleVersionId) { }
}

// Namespace: Sentry.Internal.Extensions
[Extension]
internal static class ReadOnlyDictionaryExtensions // TypeDefIndex: 13716
{
	// Methods

	[Extension]
	[NullableContext(1)]
	// RVA: -1 Offset: -1
	public static TValue TryGetValue<TKey, TValue>(IReadOnlyDictionary<TKey, object> dictionary, TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA5D310 Offset: 0xA5C510 VA: 0x180A5D310
	|-ReadOnlyDictionaryExtensions.TryGetValue<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/
}

// Namespace: 
[CompilerGenerated]
private struct StreamExtensions.<ReadByteChunkAsync>d__2 : IAsyncStateMachine // TypeDefIndex: 13717
{
	// Fields
	public int <>1__state; // 0x0
	[Nullable(0)]
	public AsyncTaskMethodBuilder<byte[]> <>t__builder; // 0x8
	public int expectedLength; // 0x20
	[Nullable(0)]
	public Stream stream; // 0x28
	public CancellationToken cancellationToken; // 0x30
	[Nullable(0)]
	private PooledBuffer<byte> <buffer>5__2; // 0x38
	[Nullable(0)]
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int> <>u__1; // 0x40

	// Methods

	// RVA: 0x1CBBE90 Offset: 0x1CBB090 VA: 0x181CBBE90 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1CBC290 Offset: 0x1CBB490 VA: 0x181CBC290 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct StreamExtensions.<ReadLineAsync>d__0 : IAsyncStateMachine // TypeDefIndex: 13718
{
	// Fields
	public int <>1__state; // 0x0
	[Nullable(0)]
	public AsyncTaskMethodBuilder<byte[]> <>t__builder; // 0x8
	[Nullable(0)]
	public Stream stream; // 0x20
	public CancellationToken cancellationToken; // 0x28
	[Nullable(0)]
	private PooledBuffer<byte> <buffer>5__2; // 0x30
	[Nullable(0)]
	private MemoryStream <result>5__3; // 0x38
	private int <overreach>5__4; // 0x40
	private bool <found>5__5; // 0x44
	[Nullable(0)]
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int> <>u__1; // 0x48

	// Methods

	// RVA: 0x1CBC300 Offset: 0x1CBB500 VA: 0x181CBC300 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1CBC910 Offset: 0x1CBBB10 VA: 0x181CBC910 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct StreamExtensions.<SkipNewlinesAsync>d__1 : IAsyncStateMachine // TypeDefIndex: 13719
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	[Nullable(0)]
	public Stream stream; // 0x20
	public CancellationToken cancellationToken; // 0x28
	[Nullable(0)]
	private PooledBuffer<byte> <buffer>5__2; // 0x30
	[Nullable(0)]
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int> <>u__1; // 0x38

	// Methods

	// RVA: 0x1CBE8B0 Offset: 0x1CBDAB0 VA: 0x181CBE8B0 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1CBECD0 Offset: 0x1CBDED0 VA: 0x181CBECD0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: Sentry.Internal.Extensions
[Nullable(0)]
[Extension]
[NullableContext(1)]
internal static class StreamExtensions // TypeDefIndex: 13720
{
	// Fields
	private static readonly byte[] NewlineBuffer; // 0x0

	// Methods

	[AsyncStateMachine(typeof(StreamExtensions.<ReadLineAsync>d__0))]
	[Extension]
	// RVA: 0x1CB79C0 Offset: 0x1CB6BC0 VA: 0x181CB79C0
	public static Task<byte[]> ReadLineAsync(Stream stream, CancellationToken cancellationToken) { }

	[Extension]
	[AsyncStateMachine(typeof(StreamExtensions.<SkipNewlinesAsync>d__1))]
	// RVA: 0x1CB7AD0 Offset: 0x1CB6CD0 VA: 0x181CB7AD0
	public static Task SkipNewlinesAsync(Stream stream, CancellationToken cancellationToken) { }

	[Extension]
	[AsyncStateMachine(typeof(StreamExtensions.<ReadByteChunkAsync>d__2))]
	// RVA: 0x1CB78B0 Offset: 0x1CB6AB0 VA: 0x181CB78B0
	public static Task<byte[]> ReadByteChunkAsync(Stream stream, int expectedLength, CancellationToken cancellationToken) { }

	[Extension]
	// RVA: 0x1CB7C50 Offset: 0x1CB6E50 VA: 0x181CB7C50
	public static Task WriteNewlineAsync(Stream stream, CancellationToken cancellationToken) { }

	[Extension]
	// RVA: 0x1CB7CF0 Offset: 0x1CB6EF0 VA: 0x181CB7CF0
	public static void WriteNewline(Stream stream) { }

	[Extension]
	// RVA: 0x1CB7BB0 Offset: 0x1CB6DB0 VA: 0x181CB7BB0
	public static Nullable<long> TryGetLength(Stream stream) { }

	[Extension]
	[NullableContext(2)]
	// RVA: 0x1CB77E0 Offset: 0x1CB69E0 VA: 0x181CB77E0
	public static bool IsFileStream(Stream stream) { }

	// RVA: 0x1CB7D80 Offset: 0x1CB6F80 VA: 0x181CB7D80
	private static void .cctor() { }
}

// Namespace: Sentry.Internal.Extensions
[Extension]
internal static class StringExtensions // TypeDefIndex: 13721
{
	// Methods

	[NullableContext(1)]
	[Extension]
	// RVA: 0x1CB7E30 Offset: 0x1CB7030 VA: 0x181CB7E30
	public static string ToSnakeCase(string str) { }

	[Extension]
	[NullableContext(2)]
	// RVA: 0x1CB7E00 Offset: 0x1CB7000 VA: 0x181CB7E00
	public static string NullIfWhitespace(string str) { }
}

// Namespace: Sentry.Integrations
[NullableContext(1)]
[Nullable(0)]
internal class AppDomainProcessExitIntegration : ISdkIntegration // TypeDefIndex: 13722
{
	// Fields
	private readonly IAppDomain _appDomain; // 0x10
	[Nullable(2)]
	private IHub _hub; // 0x18
	[Nullable(2)]
	private SentryOptions _options; // 0x20

	// Methods

	[NullableContext(2)]
	// RVA: 0x1CA1D00 Offset: 0x1CA0F00 VA: 0x181CA1D00
	public void .ctor(IAppDomain appDomain) { }

	// RVA: 0x1CA1BE0 Offset: 0x1CA0DE0 VA: 0x181CA1BE0 Slot: 4
	public void Register(IHub hub, SentryOptions options) { }

	// RVA: 0x1CA1AC0 Offset: 0x1CA0CC0 VA: 0x181CA1AC0
	internal void HandleProcessExit(object sender, EventArgs e) { }
}

// Namespace: Sentry.Integrations
[Nullable(0)]
[NullableContext(1)]
internal class AppDomainUnhandledExceptionIntegration : ISdkIntegration // TypeDefIndex: 13723
{
	// Fields
	private readonly IAppDomain _appDomain; // 0x10
	[Nullable(2)]
	private IHub _hub; // 0x18
	[Nullable(2)]
	private SentryOptions _options; // 0x20

	// Methods

	[NullableContext(2)]
	// RVA: 0x1CA2030 Offset: 0x1CA1230 VA: 0x181CA2030
	internal void .ctor(IAppDomain appDomain) { }

	// RVA: 0x1CA1F20 Offset: 0x1CA1120 VA: 0x181CA1F20 Slot: 4
	public void Register(IHub hub, SentryOptions options) { }

	[HandleProcessCorruptedStateExceptions]
	// RVA: 0x1CA1DB0 Offset: 0x1CA0FB0 VA: 0x181CA1DB0
	internal void Handle(object sender, UnhandledExceptionEventArgs e) { }
}

// Namespace: Sentry.Integrations
internal class AutoSessionTrackingIntegration : ISdkIntegration // TypeDefIndex: 13724
{
	// Methods

	[NullableContext(1)]
	// RVA: 0x1CA2200 Offset: 0x1CA1400 VA: 0x181CA2200 Slot: 4
	public void Register(IHub hub, SentryOptions options) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: Sentry.Integrations
[NullableContext(1)]
public interface ISdkIntegration // TypeDefIndex: 13725
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Register(IHub hub, SentryOptions options);
}

// Namespace: Sentry.Integrations
[Nullable(0)]
[NullableContext(1)]
internal class UnobservedTaskExceptionIntegration : ISdkIntegration // TypeDefIndex: 13726
{
	// Fields
	internal const string MechanismKey = "UnobservedTaskException";
	private readonly IAppDomain _appDomain; // 0x10
	private IHub _hub; // 0x18

	// Methods

	[NullableContext(2)]
	// RVA: 0x1CC0570 Offset: 0x1CBF770 VA: 0x181CC0570
	internal void .ctor(IAppDomain appDomain) { }

	// RVA: 0x1CC0460 Offset: 0x1CBF660 VA: 0x181CC0460 Slot: 4
	public void Register(IHub hub, SentryOptions _) { }

	[HandleProcessCorruptedStateExceptions]
	// RVA: 0x1CC03A0 Offset: 0x1CBF5A0 VA: 0x181CC03A0
	internal void Handle(object sender, UnobservedTaskExceptionEventArgs e) { }
}

// Namespace: Sentry.Infrastructure
public class ConsoleDiagnosticLogger : DiagnosticLogger // TypeDefIndex: 13727
{
	// Methods

	// RVA: 0x1CA4610 Offset: 0x1CA3810 VA: 0x181CA4610
	public void .ctor(SentryLevel minimalLevel) { }

	[NullableContext(1)]
	// RVA: 0x1CA45C0 Offset: 0x1CA37C0 VA: 0x181CA45C0 Slot: 6
	protected override void LogMessage(string message) { }
}

// Namespace: Sentry.Infrastructure
[Obsolete("Logger doesn't work outside of Sentry SDK. Please use TraceDiagnosticLogger instead")]
public class DebugDiagnosticLogger : DiagnosticLogger // TypeDefIndex: 13728
{
	// Methods

	// RVA: 0x1CA4610 Offset: 0x1CA3810 VA: 0x181CA4610
	public void .ctor(SentryLevel minimalLevel) { }

	[NullableContext(1)]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	protected override void LogMessage(string message) { }
}

// Namespace: Sentry.Infrastructure
[NullableContext(1)]
[Nullable(0)]
public abstract class DiagnosticLogger : IDiagnosticLogger // TypeDefIndex: 13729
{
	// Fields
	private readonly SentryLevel _minimalLevel; // 0x10

	// Methods

	// RVA: 0x1CA4610 Offset: 0x1CA3810 VA: 0x181CA4610
	protected void .ctor(SentryLevel minimalLevel) { }

	// RVA: 0x1CA5750 Offset: 0x1CA4950 VA: 0x181CA5750 Slot: 4
	public bool IsEnabled(SentryLevel level) { }

	// RVA: 0x1CA5760 Offset: 0x1CA4960 VA: 0x181CA5760 Slot: 5
	public void Log(SentryLevel logLevel, string message, Exception exception, object[] args) { }

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract void LogMessage(string message);

	// RVA: 0x1CA5AA0 Offset: 0x1CA4CA0 VA: 0x181CA5AA0
	private static string ScrubNewlines(string s) { }
}

// Namespace: Sentry.Infrastructure
[NullableContext(1)]
[Nullable(0)]
public class FileDiagnosticLogger : DiagnosticLogger // TypeDefIndex: 13730
{
	// Fields
	private readonly bool _alsoWriteToConsole; // 0x18
	private readonly StreamWriter _writer; // 0x20

	// Methods

	// RVA: 0x1CAB6E0 Offset: 0x1CAA8E0 VA: 0x181CAB6E0
	public void .ctor(string path, bool alsoWriteToConsole = False) { }

	// RVA: 0x1CAB5E0 Offset: 0x1CAA7E0 VA: 0x181CAB5E0
	public void .ctor(string path, SentryLevel minimalLevel, bool alsoWriteToConsole = False) { }

	// RVA: 0x1CAB510 Offset: 0x1CAA710 VA: 0x181CAB510 Slot: 6
	protected override void LogMessage(string message) { }

	[CompilerGenerated]
	[NullableContext(0)]
	// RVA: 0x1CAB5A0 Offset: 0x1CAA7A0 VA: 0x181CAB5A0
	private void <.ctor>b__3_0(object _, EventArgs _) { }
}

// Namespace: Sentry.Infrastructure
public interface ISystemClock // TypeDefIndex: 13731
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract DateTimeOffset GetUtcNow();
}

// Namespace: Sentry.Infrastructure
public sealed class SystemClock : ISystemClock // TypeDefIndex: 13732
{
	// Fields
	[Nullable(1)]
	public static readonly SystemClock Clock; // 0x0

	// Methods

	[Obsolete("This constructor will become private in a future major version. Use the `SystemClock.Clock` singleton instead.")]
	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x1CB7EC0 Offset: 0x1CB70C0 VA: 0x181CB7EC0 Slot: 4
	public DateTimeOffset GetUtcNow() { }

	// RVA: 0x1CB7F20 Offset: 0x1CB7120 VA: 0x181CB7F20
	private static void .cctor() { }
}

// Namespace: Sentry.Infrastructure
public class TraceDiagnosticLogger : DiagnosticLogger // TypeDefIndex: 13733
{
	// Methods

	// RVA: 0x1CA4610 Offset: 0x1CA3810 VA: 0x181CA4610
	public void .ctor(SentryLevel minimalLevel) { }

	[NullableContext(1)]
	// RVA: 0x1CB8100 Offset: 0x1CB7300 VA: 0x181CB8100 Slot: 6
	protected override void LogMessage(string message) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class HttpTransportBase.<>c // TypeDefIndex: 13734
{
	// Fields
	[Nullable(0)]
	public static readonly HttpTransportBase.<>c <>9; // 0x0
	[Nullable(0)]
	public static Func<RateLimit, TimeSpan> <>9__15_0; // 0x8
	[Nullable(0)]
	public static Func<EnvelopeItem, bool> <>9__21_0; // 0x10
	[Nullable(0)]
	public static Func<JsonElement, string> <>9__23_0; // 0x18

	// Methods

	// RVA: 0x1CC0100 Offset: 0x1CBF300 VA: 0x181CC0100
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	[NullableContext(0)]
	// RVA: 0x404400 Offset: 0x403600 VA: 0x180404400
	internal TimeSpan <ExtractRateLimits>b__15_0(RateLimit rl) { }

	[NullableContext(0)]
	// RVA: 0x1CBFC50 Offset: 0x1CBEE50 VA: 0x181CBFC50
	internal bool <IncrementDiscardsForHttpFailure>b__21_0(EnvelopeItem x) { }

	[NullableContext(0)]
	// RVA: 0x1C70C70 Offset: 0x1C6FE70 VA: 0x181C70C70
	internal string <LogFailure>b__23_0(JsonElement j) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HttpTransportBase.<>c__DisplayClass10_0 // TypeDefIndex: 13735
{
	// Fields
	public DateTimeOffset now; // 0x10
	[Nullable(0)]
	public EnvelopeItem item; // 0x20

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	[NullableContext(0)]
	// RVA: 0x1CBFD10 Offset: 0x1CBEF10 VA: 0x181CBFD10
	internal bool <ProcessEnvelopeItem>b__0(KeyValuePair<RateLimitCategory, DateTimeOffset> kvp) { }
}

// Namespace: 
[CompilerGenerated]
private struct HttpTransportBase.<HandleFailureAsync>d__20 : IAsyncStateMachine // TypeDefIndex: 13736
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	[Nullable(0)]
	public HttpTransportBase <>4__this; // 0x20
	[Nullable(0)]
	public HttpResponseMessage response; // 0x28
	[Nullable(0)]
	public Envelope envelope; // 0x30
	public CancellationToken cancellationToken; // 0x38
	private Nullable<SentryId> <eventId>5__2; // 0x40
	[Nullable(0)]
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<JsonElement> <>u__1; // 0x58
	[Nullable(new[] { 0, 1 })]
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<string> <>u__2; // 0x68
	[Nullable(0)]
	private string <destination>5__3; // 0x78
	[Nullable(0)]
	private FileStream <envelopeFile>5__4; // 0x80
	[Nullable(0)]
	private FileStream <>7__wrap4; // 0x88
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__3; // 0x90

	// Methods

	// RVA: 0x1CB8D30 Offset: 0x1CB7F30 VA: 0x181CB8D30 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1CB9CD0 Offset: 0x1CB8ED0 VA: 0x181CB9CD0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct HttpTransportBase.<HandleSuccessAsync>d__17 : IAsyncStateMachine // TypeDefIndex: 13737
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	[Nullable(0)]
	public HttpTransportBase <>4__this; // 0x20
	[Nullable(0)]
	public Envelope envelope; // 0x28
	public CancellationToken cancellationToken; // 0x30
	[Nullable(new[] { 0, 1 })]
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<string> <>u__1; // 0x38

	// Methods

	// RVA: 0x1CB9D30 Offset: 0x1CB8F30 VA: 0x181CB9D30 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1CBA010 Offset: 0x1CB9210 VA: 0x181CBA010 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: Sentry.Http
[Nullable(0)]
[NullableContext(1)]
public abstract class HttpTransportBase // TypeDefIndex: 13738
{
	// Fields
	internal const string DefaultErrorMessage = "No message";
	private readonly SentryOptions _options; // 0x10
	private readonly ISystemClock _clock; // 0x18
	[Nullable(new[] { 1, 1, 2 })]
	private readonly Func<string, string> _getEnvironmentVariable; // 0x20
	[Nullable(2)]
	private string _lastDiscardedSessionInitId; // 0x28
	[CompilerGenerated]
	private readonly ConcurrentDictionary<RateLimitCategory, DateTimeOffset> <CategoryLimitResets>k__BackingField; // 0x30

	// Properties
	internal ConcurrentDictionary<RateLimitCategory, DateTimeOffset> CategoryLimitResets { get; }

	// Methods

	// RVA: 0x1CAF5F0 Offset: 0x1CAE7F0 VA: 0x181CAF5F0
	protected void .ctor(SentryOptions options, Func<string, string> getEnvironmentVariable, ISystemClock clock) { }

	[CompilerGenerated]
	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	internal ConcurrentDictionary<RateLimitCategory, DateTimeOffset> get_CategoryLimitResets() { }

	// RVA: 0x1CAF0D0 Offset: 0x1CAE2D0 VA: 0x181CAF0D0
	protected internal Envelope ProcessEnvelope(Envelope envelope) { }

	// RVA: 0x1CAEAA0 Offset: 0x1CADCA0 VA: 0x181CAEAA0
	private void ProcessEnvelopeItem(DateTimeOffset now, EnvelopeItem item, List<EnvelopeItem> items) { }

	// RVA: 0x1CAC790 Offset: 0x1CAB990 VA: 0x181CAC790
	protected internal HttpRequestMessage CreateRequest(Envelope envelope) { }

	// RVA: 0x1CADA30 Offset: 0x1CACC30 VA: 0x181CADA30
	protected void HandleResponse(HttpResponseMessage response, Envelope envelope) { }

	// RVA: 0x1CAD850 Offset: 0x1CACA50 VA: 0x181CAD850
	protected Task HandleResponseAsync(HttpResponseMessage response, Envelope envelope, CancellationToken cancellationToken) { }

	// RVA: 0x1CAF5A0 Offset: 0x1CAE7A0 VA: 0x181CAF5A0
	protected Stream ReadStreamFromHttpContent(HttpContent content) { }

	// RVA: 0x1CACB60 Offset: 0x1CABD60 VA: 0x181CACB60
	private void ExtractRateLimits(HttpHeaders responseHeaders) { }

	// RVA: 0x1CADC70 Offset: 0x1CACE70 VA: 0x181CADC70
	private void HandleSuccess(Envelope envelope) { }

	[AsyncStateMachine(typeof(HttpTransportBase.<HandleSuccessAsync>d__17))]
	// RVA: 0x1CADB80 Offset: 0x1CACD80 VA: 0x181CADB80
	private Task HandleSuccessAsync(Envelope envelope, CancellationToken cancellationToken) { }

	// RVA: 0x1CAE250 Offset: 0x1CAD450 VA: 0x181CAE250
	private void LogEnvelopeSent(Envelope envelope, string payload) { }

	// RVA: 0x1CAD290 Offset: 0x1CAC490 VA: 0x181CAD290
	private void HandleFailure(HttpResponseMessage response, Envelope envelope) { }

	[AsyncStateMachine(typeof(HttpTransportBase.<HandleFailureAsync>d__20))]
	// RVA: 0x1CAD1A0 Offset: 0x1CAC3A0 VA: 0x181CAD1A0
	private Task HandleFailureAsync(HttpResponseMessage response, Envelope envelope, CancellationToken cancellationToken) { }

	// RVA: 0x1CADDE0 Offset: 0x1CACFE0 VA: 0x181CADDE0
	private void IncrementDiscardsForHttpFailure(HttpStatusCode responseStatusCode, Envelope envelope) { }

	// RVA: 0x1CAE3C0 Offset: 0x1CAD5C0 VA: 0x181CAE3C0
	private void LogFailure(string responseString, HttpStatusCode responseStatusCode, Nullable<SentryId> eventId) { }

	// RVA: 0x1CAE5C0 Offset: 0x1CAD7C0 VA: 0x181CAE5C0
	private void LogFailure(JsonElement responseJson, HttpStatusCode responseStatusCode, Nullable<SentryId> eventId) { }

	// RVA: 0x1CADD70 Offset: 0x1CACF70 VA: 0x181CADD70
	private static bool HasJsonContent(HttpContent content) { }
}

// Namespace: Sentry.Http
[NullableContext(1)]
public interface ISentryHttpClientFactory // TypeDefIndex: 13739
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract HttpClient Create(SentryOptions options);
}

// Namespace: Sentry.Extensibility
[Nullable(0)]
[NullableContext(1)]
public abstract class BaseRequestPayloadExtractor : IRequestPayloadExtractor // TypeDefIndex: 13740
{
	// Methods

	// RVA: 0x1CA2270 Offset: 0x1CA1470 VA: 0x181CA2270 Slot: 4
	public object ExtractPayload(IHttpRequest request) { }

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract bool IsSupported(IHttpRequest request);

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract object DoExtractPayLoad(IHttpRequest request);

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	protected void .ctor() { }
}

// Namespace: Sentry.Extensibility
[NullableContext(1)]
[Nullable(0)]
public class DefaultRequestPayloadExtractor : BaseRequestPayloadExtractor // TypeDefIndex: 13741
{
	// Methods

	// RVA: 0x3D6F20 Offset: 0x3D6120 VA: 0x1803D6F20 Slot: 5
	protected override bool IsSupported(IHttpRequest request) { }

	// RVA: 0x1CA4640 Offset: 0x1CA3840 VA: 0x181CA4640 Slot: 6
	protected override object DoExtractPayLoad(IHttpRequest request) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: Sentry.Extensibility
[NullableContext(1)]
[Extension]
[Nullable(0)]
[EditorBrowsable(1)]
public static class DiagnosticLoggerExtensions // TypeDefIndex: 13742
{
	// Methods

	[Extension]
	// RVA: 0x1CA56B0 Offset: 0x1CA48B0 VA: 0x181CA56B0
	internal static void Log(SentryOptions options, SentryLevel logLevel, string message, Exception exception, object[] args) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static void LogDebug<TArg>(IDiagnosticLogger logger, string message, TArg arg) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x95B3C0 Offset: 0x95A5C0 VA: 0x18095B3C0
	|-DiagnosticLoggerExtensions.LogDebug<bool>
	|
	|-RVA: 0x95B980 Offset: 0x95AB80 VA: 0x18095B980
	|-DiagnosticLoggerExtensions.LogDebug<Int16Enum>
	|
	|-RVA: 0x95BB40 Offset: 0x95AD40 VA: 0x18095BB40
	|-DiagnosticLoggerExtensions.LogDebug<Int32Enum>
	|
	|-RVA: 0x95C2E0 Offset: 0x95B4E0 VA: 0x18095C2E0
	|-DiagnosticLoggerExtensions.LogDebug<object>
	|
	|-RVA: 0x95C3D0 Offset: 0x95B5D0 VA: 0x18095C3D0
	|-DiagnosticLoggerExtensions.LogDebug<SentryId>
	|
	|-RVA: 0x95C4E0 Offset: 0x95B6E0 VA: 0x18095C4E0
	|-DiagnosticLoggerExtensions.LogDebug<float>
	|
	|-RVA: 0x95B880 Offset: 0x95AA80 VA: 0x18095B880
	|-DiagnosticLoggerExtensions.LogDebug<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	internal static void LogDebug<TArg>(SentryOptions options, string message, TArg arg) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x95BF70 Offset: 0x95B170 VA: 0x18095BF70
	|-DiagnosticLoggerExtensions.LogDebug<Nullable<SentryId>>
	|
	|-RVA: 0x95B330 Offset: 0x95A530 VA: 0x18095B330
	|-DiagnosticLoggerExtensions.LogDebug<bool>
	|
	|-RVA: 0x95BAC0 Offset: 0x95ACC0 VA: 0x18095BAC0
	|-DiagnosticLoggerExtensions.LogDebug<int>
	|-DiagnosticLoggerExtensions.LogDebug<Int32Enum>
	|
	|-RVA: 0x95C350 Offset: 0x95B550 VA: 0x18095C350
	|-DiagnosticLoggerExtensions.LogDebug<object>
	|
	|-RVA: 0x95C450 Offset: 0x95B650 VA: 0x18095C450
	|-DiagnosticLoggerExtensions.LogDebug<SentryId>
	|
	|-RVA: 0x95C7F0 Offset: 0x95B9F0 VA: 0x18095C7F0
	|-DiagnosticLoggerExtensions.LogDebug<SpanId>
	|
	|-RVA: 0x95CA40 Offset: 0x95BC40 VA: 0x18095CA40
	|-DiagnosticLoggerExtensions.LogDebug<TimeSpan>
	|
	|-RVA: 0x95B760 Offset: 0x95A960 VA: 0x18095B760
	|-DiagnosticLoggerExtensions.LogDebug<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static void LogDebug<TArg, TArg2>(IDiagnosticLogger logger, string message, TArg arg, TArg2 arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x95C260 Offset: 0x95B460 VA: 0x18095C260
	|-DiagnosticLoggerExtensions.LogDebug<object, object>
	|
	|-RVA: 0x95B5E0 Offset: 0x95A7E0 VA: 0x18095B5E0
	|-DiagnosticLoggerExtensions.LogDebug<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	internal static void LogDebug<TArg, TArg2>(SentryOptions options, string message, TArg arg, TArg2 arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x95BC50 Offset: 0x95AE50 VA: 0x18095BC50
	|-DiagnosticLoggerExtensions.LogDebug<Nullable<long>, Int32Enum>
	|
	|-RVA: 0x95BD00 Offset: 0x95AF00 VA: 0x18095BD00
	|-DiagnosticLoggerExtensions.LogDebug<Nullable<SentryId>, int>
	|
	|-RVA: 0x95BDB0 Offset: 0x95AFB0 VA: 0x18095BDB0
	|-DiagnosticLoggerExtensions.LogDebug<Nullable<SentryId>, object>
	|
	|-RVA: 0x95B160 Offset: 0x95A360 VA: 0x18095B160
	|-DiagnosticLoggerExtensions.LogDebug<bool, bool>
	|
	|-RVA: 0x95BBB0 Offset: 0x95ADB0 VA: 0x18095BBB0
	|-DiagnosticLoggerExtensions.LogDebug<int, object>
	|
	|-RVA: 0x95C010 Offset: 0x95B210 VA: 0x18095C010
	|-DiagnosticLoggerExtensions.LogDebug<object, int>
	|
	|-RVA: 0x95C1C0 Offset: 0x95B3C0 VA: 0x18095C1C0
	|-DiagnosticLoggerExtensions.LogDebug<object, object>
	|
	|-RVA: 0x95C630 Offset: 0x95B830 VA: 0x18095C630
	|-DiagnosticLoggerExtensions.LogDebug<SpanId, SpanId>
	|
	|-RVA: 0x95C870 Offset: 0x95BA70 VA: 0x18095C870
	|-DiagnosticLoggerExtensions.LogDebug<TimeSpan, int>
	|
	|-RVA: 0x95B430 Offset: 0x95A630 VA: 0x18095B430
	|-DiagnosticLoggerExtensions.LogDebug<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: 0x1CA4E30 Offset: 0x1CA4030 VA: 0x181CA4E30
	public static void LogDebug(IDiagnosticLogger logger, string message) { }

	[Extension]
	// RVA: 0x1CA4ED0 Offset: 0x1CA40D0 VA: 0x181CA4ED0
	internal static void LogDebug(SentryOptions options, string message) { }

	[Extension]
	// RVA: 0x1CA54A0 Offset: 0x1CA46A0 VA: 0x181CA54A0
	public static void LogInfo(IDiagnosticLogger logger, string message) { }

	[Extension]
	// RVA: 0x1CA53F0 Offset: 0x1CA45F0 VA: 0x181CA53F0
	internal static void LogInfo(SentryOptions options, string message) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static void LogInfo<TArg>(IDiagnosticLogger logger, string message, TArg arg) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x963320 Offset: 0x962520 VA: 0x180963320
	|-DiagnosticLoggerExtensions.LogInfo<object>
	|
	|-RVA: 0x962960 Offset: 0x961B60 VA: 0x180962960
	|-DiagnosticLoggerExtensions.LogInfo<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	internal static void LogInfo<TArg>(SentryOptions options, string message, TArg arg) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x962FA0 Offset: 0x9621A0 VA: 0x180962FA0
	|-DiagnosticLoggerExtensions.LogInfo<Nullable<SentryId>>
	|
	|-RVA: 0x962B80 Offset: 0x961D80 VA: 0x180962B80
	|-DiagnosticLoggerExtensions.LogInfo<int>
	|
	|-RVA: 0x963290 Offset: 0x962490 VA: 0x180963290
	|-DiagnosticLoggerExtensions.LogInfo<object>
	|
	|-RVA: 0x962A60 Offset: 0x961C60 VA: 0x180962A60
	|-DiagnosticLoggerExtensions.LogInfo<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static void LogInfo<TArg, TArg2>(IDiagnosticLogger logger, string message, TArg arg, TArg2 arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x963210 Offset: 0x962410 VA: 0x180963210
	|-DiagnosticLoggerExtensions.LogInfo<object, object>
	|
	|-RVA: 0x9627E0 Offset: 0x9619E0 VA: 0x1809627E0
	|-DiagnosticLoggerExtensions.LogInfo<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	internal static void LogInfo<TArg, TArg2>(SentryOptions options, string message, TArg arg, TArg2 arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x963040 Offset: 0x962240 VA: 0x180963040
	|-DiagnosticLoggerExtensions.LogInfo<Nullable<Int16Enum>, Nullable<Int16Enum>>
	|
	|-RVA: 0x962DC0 Offset: 0x961FC0 VA: 0x180962DC0
	|-DiagnosticLoggerExtensions.LogInfo<Nullable<Int32Enum>, Nullable<DateTimeOffset>>
	|
	|-RVA: 0x962C10 Offset: 0x961E10 VA: 0x180962C10
	|-DiagnosticLoggerExtensions.LogInfo<long, object>
	|
	|-RVA: 0x963510 Offset: 0x962710 VA: 0x180963510
	|-DiagnosticLoggerExtensions.LogInfo<SentryId, object>
	|
	|-RVA: 0x962630 Offset: 0x961830 VA: 0x180962630
	|-DiagnosticLoggerExtensions.LogInfo<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static void LogInfo<TArg, TArg2, TArg3>(IDiagnosticLogger logger, string message, TArg arg, TArg2 arg2, TArg3 arg3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x962440 Offset: 0x961640 VA: 0x180962440
	|-DiagnosticLoggerExtensions.LogInfo<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	internal static void LogInfo<TArg, TArg2, TArg3>(SentryOptions options, string message, TArg arg, TArg2 arg2, TArg3 arg3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x963390 Offset: 0x962590 VA: 0x180963390
	|-DiagnosticLoggerExtensions.LogInfo<SentryId, object, Int32Enum>
	|
	|-RVA: 0x963450 Offset: 0x962650 VA: 0x180963450
	|-DiagnosticLoggerExtensions.LogInfo<SentryId, object, TimeSpan>
	|
	|-RVA: 0x962220 Offset: 0x961420 VA: 0x180962220
	|-DiagnosticLoggerExtensions.LogInfo<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: 0x1CA5600 Offset: 0x1CA4800 VA: 0x181CA5600
	public static void LogWarning(IDiagnosticLogger logger, string message, Exception exception) { }

	[Extension]
	// RVA: 0x1CA5540 Offset: 0x1CA4740 VA: 0x181CA5540
	internal static void LogWarning(SentryOptions options, string message, Exception exception) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static void LogWarning<TArg>(IDiagnosticLogger logger, string message, TArg arg) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9643A0 Offset: 0x9635A0 VA: 0x1809643A0
	|-DiagnosticLoggerExtensions.LogWarning<object>
	|
	|-RVA: 0x9639F0 Offset: 0x962BF0 VA: 0x1809639F0
	|-DiagnosticLoggerExtensions.LogWarning<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	internal static void LogWarning<TArg>(SentryOptions options, string message, TArg arg) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x963F90 Offset: 0x963190 VA: 0x180963F90
	|-DiagnosticLoggerExtensions.LogWarning<int>
	|
	|-RVA: 0x964310 Offset: 0x963510 VA: 0x180964310
	|-DiagnosticLoggerExtensions.LogWarning<object>
	|
	|-RVA: 0x963AF0 Offset: 0x962CF0 VA: 0x180963AF0
	|-DiagnosticLoggerExtensions.LogWarning<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static void LogWarning<TArg, TArg2>(IDiagnosticLogger logger, string message, TArg arg, TArg2 arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x963DE0 Offset: 0x962FE0 VA: 0x180963DE0
	|-DiagnosticLoggerExtensions.LogWarning<int, int>
	|
	|-RVA: 0x964290 Offset: 0x963490 VA: 0x180964290
	|-DiagnosticLoggerExtensions.LogWarning<object, object>
	|
	|-RVA: 0x963870 Offset: 0x962A70 VA: 0x180963870
	|-DiagnosticLoggerExtensions.LogWarning<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	internal static void LogWarning<TArg, TArg2>(SentryOptions options, string message, TArg arg, TArg2 arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x964020 Offset: 0x963220 VA: 0x180964020
	|-DiagnosticLoggerExtensions.LogWarning<Nullable<long>, Int32Enum>
	|
	|-RVA: 0x963C10 Offset: 0x962E10 VA: 0x180963C10
	|-DiagnosticLoggerExtensions.LogWarning<Int32Enum, Int32Enum>
	|
	|-RVA: 0x9640D0 Offset: 0x9632D0 VA: 0x1809640D0
	|-DiagnosticLoggerExtensions.LogWarning<object, Nullable<long>>
	|
	|-RVA: 0x9636C0 Offset: 0x9628C0 VA: 0x1809636C0
	|-DiagnosticLoggerExtensions.LogWarning<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: 0x1CA5040 Offset: 0x1CA4240 VA: 0x181CA5040
	public static void LogError(IDiagnosticLogger logger, string message, Exception exception) { }

	[Extension]
	// RVA: 0x1CA4F80 Offset: 0x1CA4180 VA: 0x181CA4F80
	internal static void LogError(SentryOptions options, string message, Exception exception) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static void LogError<TArg>(IDiagnosticLogger logger, string message, Exception exception, TArg arg) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x95E090 Offset: 0x95D290 VA: 0x18095E090
	|-DiagnosticLoggerExtensions.LogError<object>
	|
	|-RVA: 0x95DA10 Offset: 0x95CC10 VA: 0x18095DA10
	|-DiagnosticLoggerExtensions.LogError<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	internal static void LogError<TArg>(SentryOptions options, string message, Exception exception, TArg arg) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x95DC70 Offset: 0x95CE70 VA: 0x18095DC70
	|-DiagnosticLoggerExtensions.LogError<Nullable<SentryId>>
	|
	|-RVA: 0x95DFF0 Offset: 0x95D1F0 VA: 0x18095DFF0
	|-DiagnosticLoggerExtensions.LogError<object>
	|
	|-RVA: 0x95E110 Offset: 0x95D310 VA: 0x18095E110
	|-DiagnosticLoggerExtensions.LogError<SentryId>
	|
	|-RVA: 0x95E1C0 Offset: 0x95D3C0 VA: 0x18095E1C0
	|-DiagnosticLoggerExtensions.LogError<SpanId>
	|
	|-RVA: 0x95D8D0 Offset: 0x95CAD0 VA: 0x18095D8D0
	|-DiagnosticLoggerExtensions.LogError<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static void LogError<TArg, TArg2>(IDiagnosticLogger logger, string message, Exception exception, TArg arg, TArg2 arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x95DDB0 Offset: 0x95CFB0 VA: 0x18095DDB0
	|-DiagnosticLoggerExtensions.LogError<object, Nullable<Int32Enum>>
	|
	|-RVA: 0x95D750 Offset: 0x95C950 VA: 0x18095D750
	|-DiagnosticLoggerExtensions.LogError<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	internal static void LogError<TArg, TArg2>(SentryOptions options, string message, Exception exception, TArg arg, TArg2 arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x95DBB0 Offset: 0x95CDB0 VA: 0x18095DBB0
	|-DiagnosticLoggerExtensions.LogError<Nullable<SentryId>, int>
	|
	|-RVA: 0x95DB10 Offset: 0x95CD10 VA: 0x18095DB10
	|-DiagnosticLoggerExtensions.LogError<int, object>
	|
	|-RVA: 0x95DF50 Offset: 0x95D150 VA: 0x18095DF50
	|-DiagnosticLoggerExtensions.LogError<object, object>
	|
	|-RVA: 0x95D5A0 Offset: 0x95C7A0 VA: 0x18095D5A0
	|-DiagnosticLoggerExtensions.LogError<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static void LogError<TArg, TArg2, TArg3, TArg4>(IDiagnosticLogger logger, string message, Exception exception, TArg arg, TArg2 arg2, TArg3 arg3, TArg4 arg4) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x95CF00 Offset: 0x95C100 VA: 0x18095CF00
	|-DiagnosticLoggerExtensions.LogError<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	internal static void LogError<TArg, TArg2, TArg3, TArg4>(SentryOptions options, string message, Exception exception, TArg arg, TArg2 arg2, TArg3 arg3, TArg4 arg4) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x95CB90 Offset: 0x95BD90 VA: 0x18095CB90
	|-DiagnosticLoggerExtensions.LogError<DateTimeOffset, Nullable<long>, long, long>
	|
	|-RVA: 0x95CC70 Offset: 0x95BE70 VA: 0x18095CC70
	|-DiagnosticLoggerExtensions.LogError<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static void LogError<TArg, TArg2, TArg3>(IDiagnosticLogger logger, Exception exception, string message, TArg arg, TArg2 arg2, TArg3 arg3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x95DD20 Offset: 0x95CF20 VA: 0x18095DD20
	|-DiagnosticLoggerExtensions.LogError<object, int, int>
	|
	|-RVA: 0x95D170 Offset: 0x95C370 VA: 0x18095D170
	|-DiagnosticLoggerExtensions.LogError<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	internal static void LogError<TArg, TArg2, TArg3>(SentryOptions options, Exception exception, string message, TArg arg, TArg2 arg2, TArg3 arg3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x95D370 Offset: 0x95C570 VA: 0x18095D370
	|-DiagnosticLoggerExtensions.LogError<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: 0x1CA50F0 Offset: 0x1CA42F0 VA: 0x181CA50F0
	public static void LogFatal(IDiagnosticLogger logger, string message, Exception exception) { }

	[Extension]
	// RVA: 0x1CA51A0 Offset: 0x1CA43A0 VA: 0x181CA51A0
	internal static void LogFatal(SentryOptions options, string message, Exception exception) { }

	[Extension]
	// RVA: 0x1CA5260 Offset: 0x1CA4460 VA: 0x181CA5260
	internal static void LogIfEnabled(IDiagnosticLogger logger, SentryLevel level, Exception exception, string message) { }

	[Extension]
	// RVA: 0x1CA5320 Offset: 0x1CA4520 VA: 0x181CA5320
	internal static void LogIfEnabled(SentryOptions options, SentryLevel level, Exception exception, string message) { }

	[Extension]
	// RVA: -1 Offset: -1
	internal static void LogIfEnabled<TArg>(IDiagnosticLogger logger, SentryLevel level, Exception exception, string message, TArg arg) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x960AB0 Offset: 0x95FCB0 VA: 0x180960AB0
	|-DiagnosticLoggerExtensions.LogIfEnabled<Nullable<SentryId>>
	|
	|-RVA: 0x95E410 Offset: 0x95D610 VA: 0x18095E410
	|-DiagnosticLoggerExtensions.LogIfEnabled<bool>
	|
	|-RVA: 0x95FC80 Offset: 0x95EE80 VA: 0x18095FC80
	|-DiagnosticLoggerExtensions.LogIfEnabled<Int16Enum>
	|
	|-RVA: 0x95FF70 Offset: 0x95F170 VA: 0x18095FF70
	|-DiagnosticLoggerExtensions.LogIfEnabled<int>
	|-DiagnosticLoggerExtensions.LogIfEnabled<Int32Enum>
	|
	|-RVA: 0x961430 Offset: 0x960630 VA: 0x180961430
	|-DiagnosticLoggerExtensions.LogIfEnabled<object>
	|
	|-RVA: 0x961AD0 Offset: 0x960CD0 VA: 0x180961AD0
	|-DiagnosticLoggerExtensions.LogIfEnabled<SentryId>
	|
	|-RVA: 0x961C20 Offset: 0x960E20 VA: 0x180961C20
	|-DiagnosticLoggerExtensions.LogIfEnabled<float>
	|
	|-RVA: 0x961F20 Offset: 0x961120 VA: 0x180961F20
	|-DiagnosticLoggerExtensions.LogIfEnabled<SpanId>
	|-DiagnosticLoggerExtensions.LogIfEnabled<TimeSpan>
	|
	|-RVA: 0x95FAF0 Offset: 0x95ECF0 VA: 0x18095FAF0
	|-DiagnosticLoggerExtensions.LogIfEnabled<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	internal static void LogIfEnabled<TArg>(SentryOptions options, SentryLevel level, Exception exception, string message, TArg arg) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x95F950 Offset: 0x95EB50 VA: 0x18095F950
	|-DiagnosticLoggerExtensions.LogIfEnabled<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	internal static void LogIfEnabled<TArg, TArg2>(IDiagnosticLogger logger, SentryLevel level, Exception exception, string message, TArg arg, TArg2 arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x95FDC0 Offset: 0x95EFC0 VA: 0x18095FDC0
	|-DiagnosticLoggerExtensions.LogIfEnabled<Nullable<Int16Enum>, Nullable<Int16Enum>>
	|-DiagnosticLoggerExtensions.LogIfEnabled<int, int>
	|-DiagnosticLoggerExtensions.LogIfEnabled<Int32Enum, Int32Enum>
	|
	|-RVA: 0x9603C0 Offset: 0x95F5C0 VA: 0x1809603C0
	|-DiagnosticLoggerExtensions.LogIfEnabled<Nullable<Int32Enum>, Nullable<DateTimeOffset>>
	|
	|-RVA: 0x960590 Offset: 0x95F790 VA: 0x180960590
	|-DiagnosticLoggerExtensions.LogIfEnabled<Nullable<long>, Int32Enum>
	|
	|-RVA: 0x960750 Offset: 0x95F950 VA: 0x180960750
	|-DiagnosticLoggerExtensions.LogIfEnabled<Nullable<SentryId>, int>
	|
	|-RVA: 0x960910 Offset: 0x95FB10 VA: 0x180960910
	|-DiagnosticLoggerExtensions.LogIfEnabled<Nullable<SentryId>, object>
	|
	|-RVA: 0x95E260 Offset: 0x95D460 VA: 0x18095E260
	|-DiagnosticLoggerExtensions.LogIfEnabled<bool, bool>
	|
	|-RVA: 0x9600B0 Offset: 0x95F2B0 VA: 0x1809600B0
	|-DiagnosticLoggerExtensions.LogIfEnabled<int, object>
	|
	|-RVA: 0x960230 Offset: 0x95F430 VA: 0x180960230
	|-DiagnosticLoggerExtensions.LogIfEnabled<long, object>
	|
	|-RVA: 0x960F90 Offset: 0x960190 VA: 0x180960F90
	|-DiagnosticLoggerExtensions.LogIfEnabled<object, Nullable<Int32Enum>>
	|
	|-RVA: 0x961130 Offset: 0x960330 VA: 0x180961130
	|-DiagnosticLoggerExtensions.LogIfEnabled<object, Nullable<long>>
	|
	|-RVA: 0x960E00 Offset: 0x960000 VA: 0x180960E00
	|-DiagnosticLoggerExtensions.LogIfEnabled<object, int>
	|
	|-RVA: 0x9612D0 Offset: 0x9604D0 VA: 0x1809612D0
	|-DiagnosticLoggerExtensions.LogIfEnabled<object, object>
	|
	|-RVA: 0x961940 Offset: 0x960B40 VA: 0x180961940
	|-DiagnosticLoggerExtensions.LogIfEnabled<SentryId, object>
	|
	|-RVA: 0x961D70 Offset: 0x960F70 VA: 0x180961D70
	|-DiagnosticLoggerExtensions.LogIfEnabled<SpanId, SpanId>
	|
	|-RVA: 0x962070 Offset: 0x961270 VA: 0x180962070
	|-DiagnosticLoggerExtensions.LogIfEnabled<TimeSpan, int>
	|
	|-RVA: 0x95F4E0 Offset: 0x95E6E0 VA: 0x18095F4E0
	|-DiagnosticLoggerExtensions.LogIfEnabled<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	internal static void LogIfEnabled<TArg, TArg2>(SentryOptions options, SentryLevel level, Exception exception, string message, TArg arg, TArg2 arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x95F710 Offset: 0x95E910 VA: 0x18095F710
	|-DiagnosticLoggerExtensions.LogIfEnabled<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	internal static void LogIfEnabled<TArg, TArg2, TArg3>(IDiagnosticLogger logger, SentryLevel level, Exception exception, string message, TArg arg, TArg2 arg2, TArg3 arg3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x960C10 Offset: 0x95FE10 VA: 0x180960C10
	|-DiagnosticLoggerExtensions.LogIfEnabled<object, int, int>
	|
	|-RVA: 0x961540 Offset: 0x960740 VA: 0x180961540
	|-DiagnosticLoggerExtensions.LogIfEnabled<SentryId, object, Int32Enum>
	|
	|-RVA: 0x961740 Offset: 0x960940 VA: 0x180961740
	|-DiagnosticLoggerExtensions.LogIfEnabled<SentryId, object, TimeSpan>
	|
	|-RVA: 0x95EF10 Offset: 0x95E110 VA: 0x18095EF10
	|-DiagnosticLoggerExtensions.LogIfEnabled<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	internal static void LogIfEnabled<TArg, TArg2, TArg3>(SentryOptions options, SentryLevel level, Exception exception, string message, TArg arg, TArg2 arg2, TArg3 arg3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x95F1F0 Offset: 0x95E3F0 VA: 0x18095F1F0
	|-DiagnosticLoggerExtensions.LogIfEnabled<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	internal static void LogIfEnabled<TArg, TArg2, TArg3, TArg4>(IDiagnosticLogger logger, SentryLevel level, Exception exception, string message, TArg arg, TArg2 arg2, TArg3 arg3, TArg4 arg4) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x95E550 Offset: 0x95D750 VA: 0x18095E550
	|-DiagnosticLoggerExtensions.LogIfEnabled<DateTimeOffset, Nullable<long>, long, long>
	|
	|-RVA: 0x95E7D0 Offset: 0x95D9D0 VA: 0x18095E7D0
	|-DiagnosticLoggerExtensions.LogIfEnabled<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	internal static void LogIfEnabled<TArg, TArg2, TArg3, TArg4>(SentryOptions options, SentryLevel level, Exception exception, string message, TArg arg, TArg2 arg2, TArg3 arg3, TArg4 arg4) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x95EB60 Offset: 0x95DD60 VA: 0x18095EB60
	|-DiagnosticLoggerExtensions.LogIfEnabled<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/
}

// Namespace: Sentry.Extensibility
[Nullable(0)]
[NullableContext(1)]
public class DisabledHub : IHub, ISentryClient, ISentryScopeManager, IDisposable // TypeDefIndex: 13743
{
	// Fields
	public static readonly DisabledHub Instance; // 0x0

	// Properties
	public bool IsEnabled { get; }
	public SentryId LastEventId { get; }

	// Methods

	// RVA: 0x3F3110 Offset: 0x3F2310 VA: 0x1803F3110 Slot: 17
	public bool get_IsEnabled() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	private void .ctor() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 25
	public void ConfigureScope(Action<Scope> configureScope) { }

	// RVA: 0x1CA5CF0 Offset: 0x1CA4EF0 VA: 0x181CA5CF0 Slot: 26
	public Task ConfigureScopeAsync(Func<Scope, Task> configureScope) { }

	// RVA: 0x937670 Offset: 0x936870 VA: 0x180937670 Slot: 28
	public IDisposable PushScope() { }

	// RVA: -1 Offset: -1 Slot: 29
	public IDisposable PushScope<TState>(TState state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x937670 Offset: 0x936870 VA: 0x180937670
	|-DisabledHub.PushScope<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 30
	public void WithScope(Action<Scope> scopeCallback) { }

	// RVA: 0x1CA5FB0 Offset: 0x1CA51B0 VA: 0x181CA5FB0 Slot: 5
	public ITransaction StartTransaction(ITransactionContext context, IReadOnlyDictionary<string, object> customSamplingContext) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void BindException(Exception exception, ISpan span) { }

	[NullableContext(2)]
	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 7
	public ISpan GetSpan() { }

	[NullableContext(2)]
	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 8
	public SentryTraceHeader GetTraceHeader() { }

	[NullableContext(2)]
	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 9
	public BaggageHeader GetBaggage() { }

	[NullableContext(2)]
	// RVA: 0x1CA5D80 Offset: 0x1CA4F80 VA: 0x181CA5D80 Slot: 10
	public TransactionContext ContinueTrace(string traceHeader, string baggageHeader, string name, string operation) { }

	[NullableContext(2)]
	// RVA: 0x1CA5E50 Offset: 0x1CA5050 VA: 0x181CA5E50 Slot: 11
	public TransactionContext ContinueTrace(SentryTraceHeader traceHeader, BaggageHeader baggageHeader, string name, string operation) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 12
	public void StartSession() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 13
	public void PauseSession() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 14
	public void ResumeSession() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 15
	public void EndSession(SessionEndStatus status = 0) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 27
	public void BindClient(ISentryClient client) { }

	// RVA: 0x1CA5C90 Offset: 0x1CA4E90 VA: 0x181CA5C90 Slot: 18
	public SentryId CaptureEvent(SentryEvent evt, Scope scope) { }

	[NullableContext(2)]
	// RVA: 0x1CA5C30 Offset: 0x1CA4E30 VA: 0x181CA5C30 Slot: 19
	public SentryId CaptureEvent(SentryEvent evt, Hint hint, Scope scope) { }

	// RVA: 0x1CA5BD0 Offset: 0x1CA4DD0 VA: 0x181CA5BD0 Slot: 16
	public SentryId CaptureEvent(SentryEvent evt, Action<Scope> configureScope) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 21
	public void CaptureTransaction(Transaction transaction) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 22
	public void CaptureTransaction(Transaction transaction, Hint hint) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 23
	public void CaptureSession(SessionUpdate sessionUpdate) { }

	// RVA: 0x1CA5F20 Offset: 0x1CA5120 VA: 0x181CA5F20 Slot: 24
	public Task FlushAsync(TimeSpan timeout) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 31
	public void Dispose() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 20
	public void CaptureUserFeedback(UserFeedback userFeedback) { }

	// RVA: 0x1CA60C0 Offset: 0x1CA52C0 VA: 0x181CA60C0 Slot: 4
	public SentryId get_LastEventId() { }

	// RVA: 0x1CA6060 Offset: 0x1CA5260 VA: 0x181CA6060
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class FormRequestPayloadExtractor.<>c // TypeDefIndex: 13744
{
	// Fields
	[Nullable(0)]
	public static readonly FormRequestPayloadExtractor.<>c <>9; // 0x0
	[Nullable(0)]
	public static Func<KeyValuePair<string, IEnumerable<string>>, string> <>9__2_0; // 0x8
	[Nullable(0)]
	public static Func<KeyValuePair<string, IEnumerable<string>>, IEnumerable<string>> <>9__2_1; // 0x10

	// Methods

	// RVA: 0x1CC00A0 Offset: 0x1CBF2A0 VA: 0x181CC00A0
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	[NullableContext(0)]
	// RVA: 0x1CBFBD0 Offset: 0x1CBEDD0 VA: 0x181CBFBD0
	internal string <DoExtractPayLoad>b__2_0(KeyValuePair<string, IEnumerable<string>> k) { }

	[NullableContext(0)]
	// RVA: 0x1CBFC10 Offset: 0x1CBEE10 VA: 0x181CBFC10
	internal IEnumerable<string> <DoExtractPayLoad>b__2_1(KeyValuePair<string, IEnumerable<string>> v) { }
}

// Namespace: Sentry.Extensibility
[NullableContext(1)]
[Nullable(0)]
public class FormRequestPayloadExtractor : BaseRequestPayloadExtractor // TypeDefIndex: 13745
{
	// Fields
	private const string SupportedContentType = "application/x-www-form-urlencoded";

	// Methods

	// RVA: 0x1CAB9B0 Offset: 0x1CAABB0 VA: 0x181CAB9B0 Slot: 5
	protected override bool IsSupported(IHttpRequest request) { }

	// RVA: 0x1CAB7D0 Offset: 0x1CAA9D0 VA: 0x181CAB7D0 Slot: 6
	protected override object DoExtractPayLoad(IHttpRequest request) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: Sentry.Extensibility
[DebuggerStepThrough]
[Nullable(0)]
[NullableContext(1)]
public sealed class HubAdapter : IHub, ISentryClient, ISentryScopeManager, IHubEx // TypeDefIndex: 13746
{
	// Fields
	public static readonly HubAdapter Instance; // 0x0

	// Properties
	public bool IsEnabled { get; }
	public SentryId LastEventId { get; }

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	private void .ctor() { }

	[DebuggerStepThrough]
	// RVA: 0x1CB0640 Offset: 0x1CAF840 VA: 0x181CB0640 Slot: 17
	public bool get_IsEnabled() { }

	[DebuggerStepThrough]
	// RVA: 0x1CB0680 Offset: 0x1CAF880 VA: 0x181CB0680 Slot: 4
	public SentryId get_LastEventId() { }

	[DebuggerStepThrough]
	// RVA: 0x1CB0040 Offset: 0x1CAF240 VA: 0x181CB0040 Slot: 25
	public void ConfigureScope(Action<Scope> configureScope) { }

	[DebuggerStepThrough]
	// RVA: 0x1CAFFF0 Offset: 0x1CAF1F0 VA: 0x181CAFFF0 Slot: 26
	public Task ConfigureScopeAsync(Func<Scope, Task> configureScope) { }

	[DebuggerStepThrough]
	// RVA: 0x1CB0330 Offset: 0x1CAF530 VA: 0x181CB0330 Slot: 28
	public IDisposable PushScope() { }

	[DebuggerStepThrough]
	// RVA: -1 Offset: -1 Slot: 29
	public IDisposable PushScope<TState>(TState state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA22EE0 Offset: 0xA220E0 VA: 0x180A22EE0
	|-HubAdapter.PushScope<__Il2CppFullySharedGenericType>
	*/

	[DebuggerStepThrough]
	[Obsolete("This method is deprecated in favor of overloads of CaptureEvent, CaptureMessage and CaptureException that provide a callback to a configurable scope.")]
	// RVA: 0x1CB0590 Offset: 0x1CAF790 VA: 0x181CB0590 Slot: 30
	public void WithScope(Action<Scope> scopeCallback) { }

	[DebuggerStepThrough]
	// RVA: 0x1CB0470 Offset: 0x1CAF670 VA: 0x181CB0470 Slot: 5
	public ITransaction StartTransaction(ITransactionContext context, IReadOnlyDictionary<string, object> customSamplingContext) { }

	[DebuggerStepThrough]
	// RVA: 0x1CB04D0 Offset: 0x1CAF6D0 VA: 0x181CB04D0
	internal ITransaction StartTransaction(ITransactionContext context, IReadOnlyDictionary<string, object> customSamplingContext, DynamicSamplingContext dynamicSamplingContext) { }

	[DebuggerStepThrough]
	// RVA: 0x1CAFBE0 Offset: 0x1CAEDE0 VA: 0x181CAFBE0 Slot: 6
	public void BindException(Exception exception, ISpan span) { }

	[DebuggerStepThrough]
	[NullableContext(2)]
	// RVA: 0x1CB0270 Offset: 0x1CAF470 VA: 0x181CB0270 Slot: 7
	public ISpan GetSpan() { }

	[DebuggerStepThrough]
	[NullableContext(2)]
	// RVA: 0x1CB02B0 Offset: 0x1CAF4B0 VA: 0x181CB02B0 Slot: 8
	public SentryTraceHeader GetTraceHeader() { }

	[DebuggerStepThrough]
	[NullableContext(2)]
	// RVA: 0x1CB0230 Offset: 0x1CAF430 VA: 0x181CB0230 Slot: 9
	public BaggageHeader GetBaggage() { }

	[NullableContext(2)]
	[DebuggerStepThrough]
	// RVA: 0x1CB0110 Offset: 0x1CAF310 VA: 0x181CB0110 Slot: 10
	public TransactionContext ContinueTrace(string traceHeader, string baggageHeader, string name, string operation) { }

	[DebuggerStepThrough]
	[NullableContext(2)]
	// RVA: 0x1CB0090 Offset: 0x1CAF290 VA: 0x181CB0090 Slot: 11
	public TransactionContext ContinueTrace(SentryTraceHeader traceHeader, BaggageHeader baggageHeader, string name, string operation) { }

	[DebuggerStepThrough]
	// RVA: 0x1CB0430 Offset: 0x1CAF630 VA: 0x181CB0430 Slot: 12
	public void StartSession() { }

	[DebuggerStepThrough]
	// RVA: 0x1CB02F0 Offset: 0x1CAF4F0 VA: 0x181CB02F0 Slot: 13
	public void PauseSession() { }

	[DebuggerStepThrough]
	// RVA: 0x1CB0370 Offset: 0x1CAF570 VA: 0x181CB0370 Slot: 14
	public void ResumeSession() { }

	[DebuggerStepThrough]
	// RVA: 0x1CB0190 Offset: 0x1CAF390 VA: 0x181CB0190 Slot: 15
	public void EndSession(SessionEndStatus status = 0) { }

	[DebuggerStepThrough]
	// RVA: 0x1CAFB90 Offset: 0x1CAED90 VA: 0x181CAFB90 Slot: 27
	public void BindClient(ISentryClient client) { }

	[NullableContext(2)]
	[DebuggerStepThrough]
	// RVA: 0x1CAFB10 Offset: 0x1CAED10 VA: 0x181CAFB10
	public void AddBreadcrumb(string message, string category, string type, IDictionary<string, string> data, BreadcrumbLevel level = 0) { }

	[DebuggerStepThrough]
	[EditorBrowsable(1)]
	// RVA: 0x1CAFA80 Offset: 0x1CAEC80 VA: 0x181CAFA80
	public void AddBreadcrumb(ISystemClock clock, string message, string category, string type, IDictionary<string, string> data, BreadcrumbLevel level = 0) { }

	[NullableContext(2)]
	// RVA: 0x1CB03B0 Offset: 0x1CAF5B0 VA: 0x181CB03B0 Slot: 31
	private SentryId Sentry.Internal.IHubEx.CaptureEventInternal(SentryEvent evt, Hint hint, Scope scope) { }

	[DebuggerStepThrough]
	// RVA: 0x1CAFCC0 Offset: 0x1CAEEC0 VA: 0x181CAFCC0
	public SentryId CaptureEvent(SentryEvent evt) { }

	[EditorBrowsable(1)]
	[DebuggerStepThrough]
	// RVA: 0x1CAFC40 Offset: 0x1CAEE40 VA: 0x181CAFC40 Slot: 18
	public SentryId CaptureEvent(SentryEvent evt, Scope scope) { }

	[EditorBrowsable(1)]
	[DebuggerStepThrough]
	[NullableContext(2)]
	// RVA: 0x1CAFDB0 Offset: 0x1CAEFB0 VA: 0x181CAFDB0 Slot: 19
	public SentryId CaptureEvent(SentryEvent evt, Hint hint, Scope scope) { }

	[EditorBrowsable(1)]
	[DebuggerStepThrough]
	// RVA: 0x1CAFD30 Offset: 0x1CAEF30 VA: 0x181CAFD30 Slot: 16
	public SentryId CaptureEvent(SentryEvent evt, Action<Scope> configureScope) { }

	[DebuggerStepThrough]
	// RVA: 0x1CAFE30 Offset: 0x1CAF030 VA: 0x181CAFE30
	public SentryId CaptureException(Exception exception) { }

	[EditorBrowsable(1)]
	[DebuggerStepThrough]
	// RVA: 0x1CAFF50 Offset: 0x1CAF150 VA: 0x181CAFF50 Slot: 21
	public void CaptureTransaction(Transaction transaction) { }

	[DebuggerStepThrough]
	[EditorBrowsable(1)]
	// RVA: 0x1CAFEF0 Offset: 0x1CAF0F0 VA: 0x181CAFEF0 Slot: 22
	public void CaptureTransaction(Transaction transaction, Hint hint) { }

	[EditorBrowsable(1)]
	[DebuggerStepThrough]
	// RVA: 0x1CAFEA0 Offset: 0x1CAF0A0 VA: 0x181CAFEA0 Slot: 23
	public void CaptureSession(SessionUpdate sessionUpdate) { }

	[EditorBrowsable(1)]
	[DebuggerStepThrough]
	// RVA: 0x1CB01E0 Offset: 0x1CAF3E0 VA: 0x181CB01E0 Slot: 24
	public Task FlushAsync(TimeSpan timeout) { }

	[EditorBrowsable(1)]
	[DebuggerStepThrough]
	// RVA: 0x1CAFFA0 Offset: 0x1CAF1A0 VA: 0x181CAFFA0 Slot: 20
	public void CaptureUserFeedback(UserFeedback sentryUserFeedback) { }

	[NullableContext(2)]
	[Obsolete("This method is deprecated in favor of overloads of CaptureEvent, CaptureMessage and CaptureException that provide a callback to a configurable scope.")]
	// RVA: -1 Offset: -1 Slot: 32
	public T WithScope<T>(Func<Scope, T> scopeCallback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA23040 Offset: 0xA22240 VA: 0x180A23040
	|-HubAdapter.WithScope<__Il2CppFullySharedGenericType>
	*/

	[Obsolete("This method is deprecated in favor of overloads of CaptureEvent, CaptureMessage and CaptureException that provide a callback to a configurable scope.")]
	// RVA: 0x1CB0540 Offset: 0x1CAF740 VA: 0x181CB0540 Slot: 33
	public Task WithScopeAsync(Func<Scope, Task> scopeCallback) { }

	[Obsolete("This method is deprecated in favor of overloads of CaptureEvent, CaptureMessage and CaptureException that provide a callback to a configurable scope.")]
	[NullableContext(2)]
	// RVA: -1 Offset: -1 Slot: 34
	public Task<T> WithScopeAsync<T>(Func<Scope, Task<T>> scopeCallback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA22FD0 Offset: 0xA221D0 VA: 0x180A22FD0
	|-HubAdapter.WithScopeAsync<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1CB05E0 Offset: 0x1CAF7E0 VA: 0x181CB05E0
	private static void .cctor() { }
}

// Namespace: Sentry.Extensibility
[NullableContext(1)]
public interface IBackgroundWorker // TypeDefIndex: 13747
{
	// Properties
	public abstract int QueuedItems { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool EnqueueEnvelope(Envelope envelope);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract Task FlushAsync(TimeSpan timeout);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract int get_QueuedItems();
}

// Namespace: Sentry.Extensibility
[NullableContext(1)]
public interface IDiagnosticLogger // TypeDefIndex: 13748
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool IsEnabled(SentryLevel level);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Log(SentryLevel logLevel, string message, Exception exception, object[] args);
}

// Namespace: Sentry.Extensibility
[NullableContext(1)]
public interface IExceptionFilter // TypeDefIndex: 13749
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool Filter(Exception ex);
}

// Namespace: Sentry.Extensibility
[NullableContext(2)]
public interface IHttpRequest // TypeDefIndex: 13750
{
	// Properties
	public abstract Nullable<long> ContentLength { get; }
	public abstract string ContentType { get; }
	public abstract Stream Body { get; }
	[Nullable(new[] { 2, 0, 1, 1, 1 })]
	public abstract IEnumerable<KeyValuePair<string, IEnumerable<string>>> Form { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Nullable<long> get_ContentLength();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string get_ContentType();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract Stream get_Body();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract IEnumerable<KeyValuePair<string, IEnumerable<string>>> get_Form();
}

// Namespace: Sentry.Extensibility
[EditorBrowsable(1)]
[NullableContext(1)]
public interface INetworkStatusListener // TypeDefIndex: 13751
{
	// Properties
	public abstract bool Online { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_Online();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract Task WaitForNetworkOnlineAsync(CancellationToken cancellationToken);
}

// Namespace: Sentry.Extensibility
[NullableContext(1)]
public interface IRequestPayloadExtractor // TypeDefIndex: 13752
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object ExtractPayload(IHttpRequest request);
}

// Namespace: Sentry.Extensibility
[NullableContext(1)]
public interface ISentryEventExceptionProcessor // TypeDefIndex: 13753
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Process(Exception exception, SentryEvent sentryEvent);
}

// Namespace: Sentry.Extensibility
[NullableContext(1)]
public interface ISentryEventProcessor // TypeDefIndex: 13754
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract SentryEvent Process(SentryEvent event);
}

// Namespace: Sentry.Extensibility
[Extension]
internal static class ISentryEventProcessorExtensions // TypeDefIndex: 13755
{
	// Methods

	[NullableContext(1)]
	[Extension]
	// RVA: 0x1CB06E0 Offset: 0x1CAF8E0 VA: 0x181CB06E0
	internal static SentryEvent DoProcessEvent(ISentryEventProcessor processor, SentryEvent event, Hint hint) { }
}

// Namespace: Sentry.Extensibility
public interface ISentryEventProcessorWithHint : ISentryEventProcessor // TypeDefIndex: 13756
{
	// Methods

	[NullableContext(1)]
	// RVA: -1 Offset: -1 Slot: 0
	public abstract SentryEvent Process(SentryEvent event, Hint hint);
}

// Namespace: Sentry.Extensibility
[NullableContext(2)]
public interface ISentryStackTraceFactory // TypeDefIndex: 13757
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract SentryStackTrace Create(Exception exception);
}

// Namespace: Sentry.Extensibility
[NullableContext(1)]
public interface ISentryTransactionProcessor // TypeDefIndex: 13758
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Transaction Process(Transaction transaction);
}

// Namespace: Sentry.Extensibility
[Extension]
internal static class ISentryTransactionProcessorExtensions // TypeDefIndex: 13759
{
	// Methods

	[NullableContext(1)]
	[Extension]
	// RVA: 0x1CB0850 Offset: 0x1CAFA50 VA: 0x181CB0850
	internal static Transaction DoProcessTransaction(ISentryTransactionProcessor processor, Transaction transaction, Hint hint) { }
}

// Namespace: Sentry.Extensibility
public interface ISentryTransactionProcessorWithHint : ISentryTransactionProcessor // TypeDefIndex: 13760
{
	// Methods

	[NullableContext(1)]
	// RVA: -1 Offset: -1 Slot: 0
	public abstract Transaction Process(Transaction transaction, Hint hint);
}

// Namespace: Sentry.Extensibility
[NullableContext(1)]
public interface ITransport // TypeDefIndex: 13761
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Task SendEnvelopeAsync(Envelope envelope, CancellationToken cancellationToken);
}

// Namespace: Sentry.Extensibility
[Nullable(0)]
[NullableContext(1)]
public class RequestBodyExtractionDispatcher : IRequestPayloadExtractor // TypeDefIndex: 13762
{
	// Fields
	private readonly SentryOptions _options; // 0x10
	private readonly Func<RequestSize> _sizeSwitch; // 0x18
	[CompilerGenerated]
	private readonly IEnumerable<IRequestPayloadExtractor> <Extractors>k__BackingField; // 0x20

	// Properties
	internal IEnumerable<IRequestPayloadExtractor> Extractors { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	internal IEnumerable<IRequestPayloadExtractor> get_Extractors() { }

	// RVA: 0x1CB6BC0 Offset: 0x1CB5DC0 VA: 0x181CB6BC0
	public void .ctor(IEnumerable<IRequestPayloadExtractor> extractors, SentryOptions options, Func<RequestSize> sizeSwitch) { }

	// RVA: 0x1CB6780 Offset: 0x1CB5980 VA: 0x181CB6780 Slot: 4
	public object ExtractPayload(IHttpRequest request) { }
}

// Namespace: Sentry.Extensibility
public enum RequestSize // TypeDefIndex: 13763
{
	// Fields
	public int value__; // 0x0
	public const RequestSize None = 0;
	public const RequestSize Small = 1;
	public const RequestSize Medium = 2;
	public const RequestSize Always = 3;
}

// Namespace: Sentry.Extensibility
public abstract class SentryEventExceptionProcessor<TException> : ISentryEventExceptionProcessor // TypeDefIndex: 13764
{
	// Methods

	[NullableContext(1)]
	// RVA: -1 Offset: -1 Slot: 4
	public void Process(Exception exception, SentryEvent sentryEvent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF0770 Offset: 0xBEF970 VA: 0x180BF0770
	|-SentryEventExceptionProcessor<object>.Process
	*/

	[NullableContext(1)]
	// RVA: -1 Offset: -1 Slot: 5
	protected internal abstract void ProcessException(TException exception, SentryEvent sentryEvent);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-SentryEventExceptionProcessor<object>.ProcessException
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	|-SentryEventExceptionProcessor<object>..ctor
	*/
}

// Namespace: Sentry.Extensibility
public sealed class SentryStackTraceFactory : ISentryStackTraceFactory // TypeDefIndex: 13765
{
	// Fields
	[Nullable(1)]
	private readonly SentryOptions _options; // 0x10

	// Methods

	[NullableContext(1)]
	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	public void .ctor(SentryOptions options) { }

	[NullableContext(2)]
	// RVA: 0x1CB7530 Offset: 0x1CB6730 VA: 0x181CB7530 Slot: 4
	public SentryStackTrace Create(Exception exception) { }
}

// Namespace: System
[Nullable(0)]
[NullableContext(1)]
[ExcludeFromCodeCoverage]
[DebuggerNonUserCode]
[IsReadOnly]
internal struct Index : IEquatable<Index> // TypeDefIndex: 13766
{
	// Fields
	private readonly int _value; // 0x0

	// Properties
	public static Index Start { get; }
	public static Index End { get; }
	public int Value { get; }
	public bool IsFromEnd { get; }

	// Methods

	// RVA: 0x1CB0C10 Offset: 0x1CAFE10 VA: 0x181CB0C10
	public void .ctor(int value, bool fromEnd = False) { }

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	private void .ctor(int value) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0
	public static Index get_Start() { }

	// RVA: 0x729380 Offset: 0x728580 VA: 0x180729380
	public static Index get_End() { }

	// RVA: 0x1CB0AB0 Offset: 0x1CAFCB0 VA: 0x181CB0AB0
	public static Index FromStart(int value) { }

	// RVA: 0x1CB0A40 Offset: 0x1CAFC40 VA: 0x181CB0A40
	public static Index FromEnd(int value) { }

	// RVA: 0x1CB0C80 Offset: 0x1CAFE80 VA: 0x181CB0C80
	public int get_Value() { }

	// RVA: 0x180F8F0 Offset: 0x180EAF0 VA: 0x18180F8F0
	public bool get_IsFromEnd() { }

	// RVA: 0x1CB0B20 Offset: 0x1CAFD20 VA: 0x181CB0B20
	public int GetOffset(int length) { }

	// RVA: 0x1CB09C0 Offset: 0x1CAFBC0 VA: 0x181CB09C0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x179DB20 Offset: 0x179CD20 VA: 0x18179DB20 Slot: 4
	public bool Equals(Index other) { }

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1CB0AB0 Offset: 0x1CAFCB0 VA: 0x181CB0AB0
	public static Index op_Implicit(int value) { }

	// RVA: 0x1CB0B90 Offset: 0x1CAFD90 VA: 0x181CB0B90 Slot: 3
	public override string ToString() { }

	// RVA: 0x1CB0B30 Offset: 0x1CAFD30 VA: 0x181CB0B30
	private string ToStringFromEnd() { }
}

// Namespace: System
[NullableContext(1)]
[Nullable(0)]
[ExcludeFromCodeCoverage]
[DebuggerNonUserCode]
internal class Range : IEquatable<Range> // TypeDefIndex: 13767
{
	// Fields
	[CompilerGenerated]
	private readonly Index <Start>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly Index <End>k__BackingField; // 0x14

	// Properties
	[CompilerGenerated]
	protected virtual Type EqualityContract { get; }
	public Index Start { get; set; }
	public Index End { get; set; }
	public static Range All { get; }

	// Methods

	// RVA: 0x1CB5FC0 Offset: 0x1CB51C0 VA: 0x181CB5FC0
	public void .ctor(Index Start, Index End) { }

	[CompilerGenerated]
	// RVA: 0x1CB6030 Offset: 0x1CB5230 VA: 0x181CB6030 Slot: 5
	protected virtual Type get_EqualityContract() { }

	[CompilerGenerated]
	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public Index get_Start() { }

	[CompilerGenerated]
	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_Start(Index value) { }

	[CompilerGenerated]
	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500
	public Index get_End() { }

	[CompilerGenerated]
	// RVA: 0x426530 Offset: 0x425730 VA: 0x180426530
	public void set_End(Index value) { }

	// RVA: 0x1CB5EC0 Offset: 0x1CB50C0 VA: 0x181CB5EC0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1CB5E60 Offset: 0x1CB5060 VA: 0x181CB5E60
	public static Range StartAt(Index start) { }

	// RVA: 0x1CB5810 Offset: 0x1CB4A10 VA: 0x181CB5810
	public static Range EndAt(Index end) { }

	// RVA: 0x1CB5FD0 Offset: 0x1CB51D0 VA: 0x181CB5FD0
	public static Range get_All() { }

	[NullableContext(0)]
	// RVA: 0x1CB5C20 Offset: 0x1CB4E20 VA: 0x181CB5C20
	public ValueTuple<int, int> GetOffsetAndLength(int length) { }

	[CompilerGenerated]
	// RVA: 0x1CB5CF0 Offset: 0x1CB4EF0 VA: 0x181CB5CF0 Slot: 6
	protected virtual bool PrintMembers(StringBuilder builder) { }

	[NullableContext(2)]
	[CompilerGenerated]
	// RVA: 0x1CB60C0 Offset: 0x1CB52C0 VA: 0x181CB60C0
	public static bool op_Inequality(Range left, Range right) { }

	[CompilerGenerated]
	[NullableContext(2)]
	// RVA: 0x1CB6090 Offset: 0x1CB5290 VA: 0x181CB6090
	public static bool op_Equality(Range left, Range right) { }

	[CompilerGenerated]
	// RVA: 0x1CB5A40 Offset: 0x1CB4C40 VA: 0x181CB5A40 Slot: 2
	public override int GetHashCode() { }

	[CompilerGenerated]
	[NullableContext(2)]
	// RVA: 0x1CB59B0 Offset: 0x1CB4BB0 VA: 0x181CB59B0 Slot: 0
	public override bool Equals(object obj) { }

	[NullableContext(2)]
	[CompilerGenerated]
	// RVA: 0x1CB5870 Offset: 0x1CB4A70 VA: 0x181CB5870 Slot: 7
	public virtual bool Equals(Range other) { }

	[CompilerGenerated]
	// RVA: 0x1CB5F50 Offset: 0x1CB5150 VA: 0x181CB5F50 Slot: 8
	public virtual Range <Clone>$() { }

	[CompilerGenerated]
	// RVA: 0x1A33F60 Offset: 0x1A33160 VA: 0x181A33F60
	protected void .ctor(Range original) { }

	[CompilerGenerated]
	// RVA: 0x1CB5800 Offset: 0x1CB4A00 VA: 0x181CB5800
	public void Deconstruct(out Index Start, out Index End) { }
}

// Namespace: System
[Nullable(0)]
[NullableContext(1)]
internal static class HashCode // TypeDefIndex: 13768
{
	// Methods

	// RVA: -1 Offset: -1
	public static int Combine<T1, T2>(T1 value1, T2 value2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B1A00 Offset: 0x9B0C00 VA: 0x1809B1A00
	|-HashCode.Combine<int, int>
	|
	|-RVA: 0x9B1730 Offset: 0x9B0930 VA: 0x1809B1730
	|-HashCode.Combine<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static int Combine<T1, T2, T3>(T1 value1, T2 value2, T3 value3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B1D60 Offset: 0x9B0F60 VA: 0x1809B1D60
	|-HashCode.Combine<object, object, object>
	|
	|-RVA: 0x9B13B0 Offset: 0x9B05B0 VA: 0x1809B13B0
	|-HashCode.Combine<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/
}

// Namespace: System.Collections.Generic.Enumerable
internal static class EnumerableIList // TypeDefIndex: 13769
{
	// Methods

	[NullableContext(1)]
	// RVA: -1 Offset: -1
	public static EnumerableIList<T> Create<T>(IList<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x99FEC0 Offset: 0x99F0C0 VA: 0x18099FEC0
	|-EnumerableIList.Create<object>
	|-EnumerableIList.Create<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: System.Collections.Generic.Enumerable
[Nullable(0)]
[NullableContext(1)]
[DefaultMember("Item")]
internal struct EnumerableIList<T> : IEnumerableIList<T>, IEnumerable<T>, IEnumerable, IList<T>, ICollection<T> // TypeDefIndex: 13770
{
	// Fields
	private readonly IList<T> _list; // 0x0
	[Nullable(new[] { 0, 1 })]
	public static EnumerableIList<T> Empty; // 0x0

	// Properties
	public T Item { get; set; }
	public int Count { get; }
	public bool IsReadOnly { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IList<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	|-EnumerableIList<object>..ctor
	|-EnumerableIList<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public EnumeratorIList<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10E2270 Offset: 0x10E1470 VA: 0x1810E2270
	|-EnumerableIList<object>.GetEnumerator
	|-EnumerableIList<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	public static EnumerableIList<T> op_Implicit(List<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10E2E30 Offset: 0x10E2030 VA: 0x1810E2E30
	|-EnumerableIList<object>.op_Implicit
	|-EnumerableIList<__Il2CppFullySharedGenericType>.op_Implicit
	*/

	// RVA: -1 Offset: -1
	public static EnumerableIList<T> op_Implicit(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10E2E30 Offset: 0x10E2030 VA: 0x1810E2E30
	|-EnumerableIList<object>.op_Implicit
	|-EnumerableIList<__Il2CppFullySharedGenericType>.op_Implicit
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10E2C00 Offset: 0x10E1E00 VA: 0x1810E2C00
	|-EnumerableIList<object>.get_Item
	|
	|-RVA: 0x10E2CD0 Offset: 0x10E1ED0 VA: 0x1810E2CD0
	|-EnumerableIList<__Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10E2FB0 Offset: 0x10E21B0 VA: 0x1810E2FB0
	|-EnumerableIList<object>.set_Item
	|
	|-RVA: 0x10E2E60 Offset: 0x10E2060 VA: 0x1810E2E60
	|-EnumerableIList<__Il2CppFullySharedGenericType>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10E2B40 Offset: 0x10E1D40 VA: 0x1810E2B40
	|-EnumerableIList<object>.get_Count
	|-EnumerableIList<__Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public bool get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10E2BA0 Offset: 0x10E1DA0 VA: 0x1810E2BA0
	|-EnumerableIList<object>.get_IsReadOnly
	|-EnumerableIList<__Il2CppFullySharedGenericType>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10E1CE0 Offset: 0x10E0EE0 VA: 0x1810E1CE0
	|-EnumerableIList<object>.Add
	|
	|-RVA: 0x10E1DC0 Offset: 0x10E0FC0 VA: 0x1810E1DC0
	|-EnumerableIList<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10E1F70 Offset: 0x10E1170 VA: 0x1810E1F70
	|-EnumerableIList<object>.Clear
	|-EnumerableIList<__Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10E2120 Offset: 0x10E1320 VA: 0x1810E2120
	|-EnumerableIList<object>.Contains
	|
	|-RVA: 0x10E1FD0 Offset: 0x10E11D0 VA: 0x1810E1FD0
	|-EnumerableIList<__Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 17
	public void CopyTo(T[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10E2190 Offset: 0x10E1390 VA: 0x1810E2190
	|-EnumerableIList<object>.CopyTo
	|-EnumerableIList<__Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public int IndexOf(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10E2480 Offset: 0x10E1680 VA: 0x1810E2480
	|-EnumerableIList<object>.IndexOf
	|
	|-RVA: 0x10E22C0 Offset: 0x10E14C0 VA: 0x1810E22C0
	|-EnumerableIList<__Il2CppFullySharedGenericType>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public void Insert(int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10E2560 Offset: 0x10E1760 VA: 0x1810E2560
	|-EnumerableIList<object>.Insert
	|
	|-RVA: 0x10E25E0 Offset: 0x10E17E0 VA: 0x1810E25E0
	|-EnumerableIList<__Il2CppFullySharedGenericType>.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 18
	public bool Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10E27A0 Offset: 0x10E19A0 VA: 0x1810E27A0
	|-EnumerableIList<object>.Remove
	|
	|-RVA: 0x10E2810 Offset: 0x10E1A10 VA: 0x1810E2810
	|-EnumerableIList<__Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public void RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10E2730 Offset: 0x10E1930 VA: 0x1810E2730
	|-EnumerableIList<object>.RemoveAt
	|-EnumerableIList<__Il2CppFullySharedGenericType>.RemoveAt
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10E2960 Offset: 0x10E1B60 VA: 0x1810E2960
	|-EnumerableIList<object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x10E2A50 Offset: 0x10E1C50 VA: 0x1810E2A50
	|-EnumerableIList<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10E2960 Offset: 0x10E1B60 VA: 0x1810E2960
	|-EnumerableIList<object>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x10E2A50 Offset: 0x10E1C50 VA: 0x1810E2A50
	|-EnumerableIList<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	|-EnumerableIList<object>..cctor
	|-EnumerableIList<__Il2CppFullySharedGenericType>..cctor
	*/
}

// Namespace: System.Collections.Generic.Enumerable
[Nullable(0)]
[NullableContext(1)]
internal struct EnumeratorIList<T> : IEnumerator<T>, IEnumerator, IDisposable // TypeDefIndex: 13771
{
	// Fields
	private readonly IList<T> _list; // 0x0
	private int _index; // 0x0

	// Properties
	public T Current { get; }
	[Nullable(2)]
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IList<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x112D980 Offset: 0x112CB80 VA: 0x18112D980
	|-EnumeratorIList<object>..ctor
	|-EnumeratorIList<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x112D990 Offset: 0x112CB90 VA: 0x18112D990
	|-EnumeratorIList<object>.get_Current
	|
	|-RVA: 0x112DA60 Offset: 0x112CC60 VA: 0x18112DA60
	|-EnumeratorIList<__Il2CppFullySharedGenericType>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x112D8C0 Offset: 0x112CAC0 VA: 0x18112D8C0
	|-EnumeratorIList<object>.MoveNext
	|-EnumeratorIList<__Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	|-EnumeratorIList<object>.Dispose
	|-EnumeratorIList<__Il2CppFullySharedGenericType>.Dispose
	*/

	[NullableContext(2)]
	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x112D940 Offset: 0x112CB40 VA: 0x18112D940
	|-EnumeratorIList<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0xBC5680 Offset: 0xBC4880 VA: 0x180BC5680
	|-EnumeratorIList<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10EE2D0 Offset: 0x10ED4D0 VA: 0x1810EE2D0
	|-EnumeratorIList<object>.Reset
	|-EnumeratorIList<__Il2CppFullySharedGenericType>.Reset
	*/
}

// Namespace: System.Collections.Generic.Enumerable
internal interface IEnumerableIList<T> : IEnumerable<T>, IEnumerable // TypeDefIndex: 13772
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract EnumeratorIList<T> GetEnumerator();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IEnumerableIList<__Il2CppFullySharedGenericType>.GetEnumerator
	*/
}

// Namespace: System.Net.Http
[Nullable(0)]
[NullableContext(1)]
internal abstract class SerializableHttpContent : HttpContent // TypeDefIndex: 13773
{
	// Methods

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 9
	protected virtual void SerializeToStream(Stream stream, TransportContext context, CancellationToken cancellationToken) { }

	// RVA: 0x1CB7730 Offset: 0x1CB6930 VA: 0x181CB7730
	internal Stream ReadAsStream(CancellationToken cancellationToken) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	protected void .ctor() { }
}

// Namespace: System.Diagnostics
[DebuggerNonUserCode]
[Usage(108, Inherited = False)]
[ExcludeFromCodeCoverage]
internal sealed class StackTraceHiddenAttribute : Attribute // TypeDefIndex: 13774
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.Diagnostics
[Nullable(0)]
[NullableContext(1)]
internal class EnhancedStackFrame : StackFrame // TypeDefIndex: 13775
{
	// Fields
	[Nullable(2)]
	private readonly string _fileName; // 0x48
	private readonly int _lineNumber; // 0x50
	private readonly int _colNumber; // 0x54
	[CompilerGenerated]
	private readonly StackFrame <StackFrame>k__BackingField; // 0x58
	[CompilerGenerated]
	private readonly ResolvedMethod <MethodInfo>k__BackingField; // 0x60

	// Properties
	public StackFrame StackFrame { get; }
	public bool IsRecursive { get; set; }
	public ResolvedMethod MethodInfo { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x405090 Offset: 0x404290 VA: 0x180405090
	public StackFrame get_StackFrame() { }

	// RVA: 0x1CA6510 Offset: 0x1CA5710 VA: 0x181CA6510
	public bool get_IsRecursive() { }

	// RVA: 0x1CA6530 Offset: 0x1CA5730 VA: 0x181CA6530
	internal void set_IsRecursive(bool value) { }

	[CompilerGenerated]
	// RVA: 0x542860 Offset: 0x541A60 VA: 0x180542860
	public ResolvedMethod get_MethodInfo() { }

	// RVA: 0x1CA64A0 Offset: 0x1CA56A0 VA: 0x181CA64A0
	internal void .ctor(StackFrame stackFrame, ResolvedMethod methodInfo, string fileName, int lineNumber, int colNumber) { }

	// RVA: 0x1CA6400 Offset: 0x1CA5600 VA: 0x181CA6400
	internal bool IsEquivalent(ResolvedMethod methodInfo, string fileName, int lineNumber, int colNumber) { }

	// RVA: 0x4D1A40 Offset: 0x4D0C40 VA: 0x1804D1A40 Slot: 5
	public override int GetFileColumnNumber() { }

	// RVA: 0x430410 Offset: 0x42F610 VA: 0x180430410 Slot: 4
	public override int GetFileLineNumber() { }

	[NullableContext(2)]
	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0 Slot: 6
	public override string GetFileName() { }

	// RVA: 0x1CA6370 Offset: 0x1CA5570 VA: 0x181CA6370 Slot: 7
	public override int GetILOffset() { }

	[NullableContext(2)]
	// RVA: 0x1CA63A0 Offset: 0x1CA55A0 VA: 0x181CA63A0 Slot: 8
	public override MethodBase GetMethod() { }

	// RVA: 0x1CA63D0 Offset: 0x1CA55D0 VA: 0x181CA63D0 Slot: 9
	public override int GetNativeOffset() { }

	// RVA: 0x1CA6470 Offset: 0x1CA5670 VA: 0x181CA6470 Slot: 3
	public override string ToString() { }
}

// Namespace: 
[NullableContext(0)]
internal enum EnhancedStackTrace.GeneratedNameKind // TypeDefIndex: 13776
{
	// Fields
	public int value__; // 0x0
	public const EnhancedStackTrace.GeneratedNameKind None = 0;
	public const EnhancedStackTrace.GeneratedNameKind ThisProxyField = 52;
	public const EnhancedStackTrace.GeneratedNameKind HoistedLocalField = 53;
	public const EnhancedStackTrace.GeneratedNameKind DisplayClassLocalOrField = 56;
	public const EnhancedStackTrace.GeneratedNameKind LambdaMethod = 98;
	public const EnhancedStackTrace.GeneratedNameKind LambdaDisplayClass = 99;
	public const EnhancedStackTrace.GeneratedNameKind StateMachineType = 100;
	public const EnhancedStackTrace.GeneratedNameKind LocalFunction = 103;
	public const EnhancedStackTrace.GeneratedNameKind AwaiterField = 117;
	public const EnhancedStackTrace.GeneratedNameKind HoistedSynthesizedLocalField = 115;
	public const EnhancedStackTrace.GeneratedNameKind StateMachineStateField = 49;
	public const EnhancedStackTrace.GeneratedNameKind IteratorCurrentBackingField = 50;
	public const EnhancedStackTrace.GeneratedNameKind StateMachineParameterProxyField = 51;
	public const EnhancedStackTrace.GeneratedNameKind ReusableHoistedLocalField = 55;
	public const EnhancedStackTrace.GeneratedNameKind LambdaCacheField = 57;
	public const EnhancedStackTrace.GeneratedNameKind FixedBufferField = 101;
	public const EnhancedStackTrace.GeneratedNameKind AnonymousType = 102;
	public const EnhancedStackTrace.GeneratedNameKind TransparentIdentifier = 104;
	public const EnhancedStackTrace.GeneratedNameKind AnonymousTypeField = 105;
	public const EnhancedStackTrace.GeneratedNameKind AutoPropertyBackingField = 107;
	public const EnhancedStackTrace.GeneratedNameKind IteratorCurrentThreadIdField = 108;
	public const EnhancedStackTrace.GeneratedNameKind IteratorFinallyMethod = 109;
	public const EnhancedStackTrace.GeneratedNameKind BaseMethodWrapper = 110;
	public const EnhancedStackTrace.GeneratedNameKind AsyncBuilderField = 116;
	public const EnhancedStackTrace.GeneratedNameKind DynamicCallSiteContainerType = 111;
	public const EnhancedStackTrace.GeneratedNameKind DynamicCallSiteField = 112;
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class EnhancedStackTrace.<>c // TypeDefIndex: 13777
{
	// Fields
	[Nullable(0)]
	public static readonly EnhancedStackTrace.<>c <>9; // 0x0
	[Nullable(0)]
	public static Func<Type, string> <>9__19_0; // 0x8
	[Nullable(0)]
	public static Func<Attribute, bool> <>9__28_0; // 0x10

	// Methods

	// RVA: 0x1CC8480 Offset: 0x1CC7680 VA: 0x181CC8480
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	[NullableContext(0)]
	// RVA: 0x1CC8250 Offset: 0x1CC7450 VA: 0x181CC8250
	internal string <GetMethodDisplayString>b__19_0(Type arg) { }

	[NullableContext(0)]
	// RVA: 0x1CC8330 Offset: 0x1CC7530 VA: 0x181CC8330
	internal bool <GetParameter>b__28_0(Attribute a) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class EnhancedStackTrace.<>c__DisplayClass21_0 // TypeDefIndex: 13778
{
	// Fields
	[Nullable(0)]
	public string matchName; // 0x10
	[Nullable(0)]
	public Func<MethodInfo, bool> <>9__2; // 0x18
	[Nullable(0)]
	public Func<ConstructorInfo, bool> <>9__3; // 0x20
	[Nullable(0)]
	public Func<ConstructorInfo, bool> <>9__4; // 0x28

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	[NullableContext(0)]
	// RVA: 0x1CC83E0 Offset: 0x1CC75E0 VA: 0x181CC83E0
	internal bool <TryResolveGeneratedName>b__0(MethodInfo m) { }

	[NullableContext(0)]
	// RVA: 0x1CC83E0 Offset: 0x1CC75E0 VA: 0x181CC83E0
	internal bool <TryResolveGeneratedName>b__1(ConstructorInfo m) { }

	[NullableContext(0)]
	// RVA: 0x1CC83E0 Offset: 0x1CC75E0 VA: 0x181CC83E0
	internal bool <TryResolveGeneratedName>b__2(MethodInfo m) { }

	[NullableContext(0)]
	// RVA: 0x1CC83E0 Offset: 0x1CC75E0 VA: 0x181CC83E0
	internal bool <TryResolveGeneratedName>b__3(ConstructorInfo m) { }

	[NullableContext(0)]
	// RVA: 0x1CC83E0 Offset: 0x1CC75E0 VA: 0x181CC83E0
	internal bool <TryResolveGeneratedName>b__4(ConstructorInfo m) { }
}

// Namespace: System.Diagnostics
[NullableContext(1)]
[Nullable(0)]
internal class EnhancedStackTrace : StackTrace, IEnumerable<EnhancedStackFrame>, IEnumerable // TypeDefIndex: 13779
{
	// Fields
	private readonly List<EnhancedStackFrame> _frames; // 0x28
	[Nullable(2)]
	private static readonly Type StackTraceHiddenAttributeType; // 0x0
	[Nullable(2)]
	private static readonly Type AsyncIteratorStateMachineAttributeType; // 0x8

	// Properties
	public override int FrameCount { get; }

	// Methods

	// RVA: 0x1CA6730 Offset: 0x1CA5930 VA: 0x181CA6730
	public static EnhancedStackTrace Current() { }

	// RVA: 0x1CAB0F0 Offset: 0x1CAA2F0 VA: 0x181CAB0F0
	public void .ctor(Exception e) { }

	// RVA: 0x1CAB230 Offset: 0x1CAA430 VA: 0x181CAB230
	public void .ctor(StackTrace stackTrace) { }

	// RVA: 0x1CAB2F0 Offset: 0x1CAA4F0 VA: 0x181CAB2F0 Slot: 4
	public override int get_FrameCount() { }

	// RVA: 0x1CA6880 Offset: 0x1CA5A80 VA: 0x181CA6880 Slot: 5
	public override StackFrame GetFrame(int index) { }

	// RVA: 0x1CA68E0 Offset: 0x1CA5AE0 VA: 0x181CA68E0 Slot: 6
	public override StackFrame[] GetFrames() { }

	// RVA: 0x1CA9810 Offset: 0x1CA8A10 VA: 0x181CA9810 Slot: 3
	public override string ToString() { }

	// RVA: 0x1CA6550 Offset: 0x1CA5750 VA: 0x181CA6550
	internal void Append(StringBuilder sb) { }

	// RVA: 0x1CA6840 Offset: 0x1CA5A40 VA: 0x181CA6840
	private EnumerableIList<EnhancedStackFrame> GetEnumerator() { }

	// RVA: 0x1CA9710 Offset: 0x1CA8910 VA: 0x181CA9710 Slot: 7
	private IEnumerator<EnhancedStackFrame> System.Collections.Generic.IEnumerable<System.Diagnostics.EnhancedStackFrame>.GetEnumerator() { }

	// RVA: 0x1CA9790 Offset: 0x1CA8990 VA: 0x181CA9790 Slot: 8
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1CA98D0 Offset: 0x1CA8AD0 VA: 0x181CA98D0
	public static string TryGetFullPath(string filePath) { }

	// RVA: 0x1CAAFA0 Offset: 0x1CAA1A0 VA: 0x181CAAFA0
	private static void .cctor() { }

	// RVA: 0x1CA6D40 Offset: 0x1CA5F40 VA: 0x181CA6D40
	private static List<EnhancedStackFrame> GetFrames(Exception exception) { }

	// RVA: 0x1CA6930 Offset: 0x1CA5B30 VA: 0x181CA6930
	public static List<EnhancedStackFrame> GetFrames(StackTrace stackTrace) { }

	// RVA: 0x1CA6EE0 Offset: 0x1CA60E0 VA: 0x181CA6EE0
	public static ResolvedMethod GetMethodDisplayString(MethodBase originMethod) { }

	// RVA: 0x1CA86D0 Offset: 0x1CA78D0 VA: 0x181CA86D0
	private static bool IsFSharpAsync(MethodBase method) { }

	// RVA: 0x1CA9B40 Offset: 0x1CA8D40 VA: 0x181CA9B40
	private static bool TryResolveGeneratedName(ref MethodBase method, out Type type, out string methodName, out string subMethodName, out EnhancedStackTrace.GeneratedNameKind kind, out Nullable<int> ordinal) { }

	// RVA: 0x1CAA4F0 Offset: 0x1CA96F0 VA: 0x181CAA4F0
	private static bool TryResolveSourceMethod(IEnumerable<MethodBase> candidateMethods, EnhancedStackTrace.GeneratedNameKind kind, string matchHint, ref MethodBase method, ref Type type, out Nullable<int> ordinal) { }

	// RVA: 0x1CA7B10 Offset: 0x1CA6D10 VA: 0x181CA7B10
	private static void GetOrdinal(MethodBase method, ref Nullable<int> ordinal) { }

	// RVA: 0x1CA6E10 Offset: 0x1CA6010 VA: 0x181CA6E10
	private static string GetMatchHint(EnhancedStackTrace.GeneratedNameKind kind, MethodBase method) { }

	// RVA: 0x1CA9990 Offset: 0x1CA8B90 VA: 0x181CA9990
	internal static bool TryParseGeneratedName(string name, out EnhancedStackTrace.GeneratedNameKind kind, out int openBracketOffset, out int closeBracketOffset) { }

	// RVA: 0x1CA8650 Offset: 0x1CA7850 VA: 0x181CA8650
	private static int IndexOfBalancedParenthesis(string str, int openingOffset, char closing) { }

	// RVA: 0x1CA8230 Offset: 0x1CA7430 VA: 0x181CA8230
	private static string GetPrefix(ParameterInfo parameter) { }

	// RVA: 0x1CA7DA0 Offset: 0x1CA6FA0 VA: 0x181CA7DA0
	private static ResolvedParameter GetParameter(ParameterInfo parameter) { }

	// RVA: 0x1CA85B0 Offset: 0x1CA77B0 VA: 0x181CA85B0
	private static ResolvedParameter GetValueTupleParameter(IList<string> tupleNames, string prefix, string name, Type parameterType) { }

	// RVA: 0x1CA83A0 Offset: 0x1CA75A0 VA: 0x181CA83A0
	private static string GetValueTupleParameterName(IList<string> tupleNames, Type parameterType) { }

	// RVA: 0x1CA8B10 Offset: 0x1CA7D10 VA: 0x181CA8B10
	private static bool ShowInStackTrace(MethodBase method) { }

	// RVA: 0x1CA87F0 Offset: 0x1CA79F0 VA: 0x181CA87F0
	private static bool IsStackTraceHidden(MemberInfo memberInfo) { }

	// RVA: 0x1CAAB10 Offset: 0x1CA9D10 VA: 0x181CAAB10
	private static bool TryResolveStateMachineMethod(ref MethodBase method, out Type declaringType) { }

	[CompilerGenerated]
	// RVA: 0x1CAAF70 Offset: 0x1CAA170 VA: 0x181CAAF70
	internal static MethodInfo[] <TryResolveStateMachineMethod>g__GetDeclaredMethods|33_0(Type type) { }
}

// Namespace: System.Diagnostics
[Extension]
[NullableContext(1)]
[Nullable(0)]
internal static class ExceptionExtensions // TypeDefIndex: 13780
{
	// Fields
	[Nullable(2)]
	private static readonly FieldInfo stackTraceString; // 0x0

	// Methods

	[Extension]
	// RVA: 0x1CC0740 Offset: 0x1CBF940 VA: 0x181CC0740
	private static void SetStackTracesString(Exception exception, string value) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static T Demystify<T>(T exception) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9A1390 Offset: 0x9A0590 VA: 0x1809A1390
	|-ExceptionExtensions.Demystify<object>
	*/

	[Extension]
	// RVA: 0x1CC07C0 Offset: 0x1CBF9C0 VA: 0x181CC07C0
	public static string ToStringDemystified(Exception exception) { }

	// RVA: 0x1CC0840 Offset: 0x1CBFA40 VA: 0x181CC0840
	private static void .cctor() { }
}

// Namespace: System.Diagnostics
[Nullable(0)]
[NullableContext(2)]
internal class ResolvedMethod // TypeDefIndex: 13781
{
	// Fields
	[CompilerGenerated]
	private MethodBase <MethodBase>k__BackingField; // 0x10
	[CompilerGenerated]
	private Type <DeclaringType>k__BackingField; // 0x18
	[CompilerGenerated]
	private bool <IsAsync>k__BackingField; // 0x20
	[CompilerGenerated]
	private bool <IsLambda>k__BackingField; // 0x21
	[CompilerGenerated]
	private ResolvedParameter <ReturnParameter>k__BackingField; // 0x28
	[CompilerGenerated]
	private string <Name>k__BackingField; // 0x30
	[CompilerGenerated]
	private Nullable<int> <Ordinal>k__BackingField; // 0x38
	[CompilerGenerated]
	private string <GenericArguments>k__BackingField; // 0x40
	[Nullable(new[] { 2, 1 })]
	[CompilerGenerated]
	private Type[] <ResolvedGenericArguments>k__BackingField; // 0x48
	[CompilerGenerated]
	private MethodBase <SubMethodBase>k__BackingField; // 0x50
	[CompilerGenerated]
	private string <SubMethod>k__BackingField; // 0x58
	[Nullable(new[] { 0, 1 })]
	[CompilerGenerated]
	private EnumerableIList<ResolvedParameter> <Parameters>k__BackingField; // 0x60
	[CompilerGenerated]
	[Nullable(new[] { 0, 1 })]
	private EnumerableIList<ResolvedParameter> <SubMethodParameters>k__BackingField; // 0x68
	[CompilerGenerated]
	private int <RecurseCount>k__BackingField; // 0x70

	// Properties
	public MethodBase MethodBase { get; set; }
	public Type DeclaringType { get; set; }
	public bool IsAsync { get; set; }
	public bool IsLambda { get; set; }
	public ResolvedParameter ReturnParameter { get; set; }
	public string Name { get; set; }
	public Nullable<int> Ordinal { get; set; }
	public string GenericArguments { get; set; }
	[Nullable(new[] { 2, 1 })]
	public Type[] ResolvedGenericArguments { get; set; }
	public MethodBase SubMethodBase { get; set; }
	public string SubMethod { get; set; }
	[Nullable(new[] { 0, 1 })]
	public EnumerableIList<ResolvedParameter> Parameters { get; set; }
	[Nullable(new[] { 0, 1 })]
	public EnumerableIList<ResolvedParameter> SubMethodParameters { get; set; }
	public int RecurseCount { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public MethodBase get_MethodBase() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_MethodBase(MethodBase value) { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public Type get_DeclaringType() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_DeclaringType(Type value) { }

	[CompilerGenerated]
	// RVA: 0x4009D0 Offset: 0x3FFBD0 VA: 0x1804009D0
	public bool get_IsAsync() { }

	[CompilerGenerated]
	// RVA: 0x4009E0 Offset: 0x3FFBE0 VA: 0x1804009E0
	public void set_IsAsync(bool value) { }

	[CompilerGenerated]
	// RVA: 0x4BD710 Offset: 0x4BC910 VA: 0x1804BD710
	public bool get_IsLambda() { }

	[CompilerGenerated]
	// RVA: 0x4BD770 Offset: 0x4BC970 VA: 0x1804BD770
	public void set_IsLambda(bool value) { }

	[CompilerGenerated]
	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public ResolvedParameter get_ReturnParameter() { }

	[CompilerGenerated]
	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	public void set_ReturnParameter(ResolvedParameter value) { }

	[CompilerGenerated]
	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	public void set_Name(string value) { }

	[CompilerGenerated]
	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public Nullable<int> get_Ordinal() { }

	[CompilerGenerated]
	// RVA: 0x40EC50 Offset: 0x40DE50 VA: 0x18040EC50
	public void set_Ordinal(Nullable<int> value) { }

	[CompilerGenerated]
	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	public string get_GenericArguments() { }

	[CompilerGenerated]
	// RVA: 0x415820 Offset: 0x414A20 VA: 0x180415820
	public void set_GenericArguments(string value) { }

	[CompilerGenerated]
	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0
	public Type[] get_ResolvedGenericArguments() { }

	[CompilerGenerated]
	// RVA: 0x41A200 Offset: 0x419400 VA: 0x18041A200
	public void set_ResolvedGenericArguments(Type[] value) { }

	[CompilerGenerated]
	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0
	public MethodBase get_SubMethodBase() { }

	[CompilerGenerated]
	// RVA: 0x4050C0 Offset: 0x4042C0 VA: 0x1804050C0
	public void set_SubMethodBase(MethodBase value) { }

	[CompilerGenerated]
	// RVA: 0x405090 Offset: 0x404290 VA: 0x180405090
	public string get_SubMethod() { }

	[CompilerGenerated]
	// RVA: 0x4050B0 Offset: 0x4042B0 VA: 0x1804050B0
	public void set_SubMethod(string value) { }

	[CompilerGenerated]
	// RVA: 0x542860 Offset: 0x541A60 VA: 0x180542860
	public EnumerableIList<ResolvedParameter> get_Parameters() { }

	[CompilerGenerated]
	// RVA: 0x542AA0 Offset: 0x541CA0 VA: 0x180542AA0
	public void set_Parameters(EnumerableIList<ResolvedParameter> value) { }

	[CompilerGenerated]
	// RVA: 0x4EDB00 Offset: 0x4ECD00 VA: 0x1804EDB00
	public EnumerableIList<ResolvedParameter> get_SubMethodParameters() { }

	[CompilerGenerated]
	// RVA: 0x4EDE80 Offset: 0x4ED080 VA: 0x1804EDE80
	public void set_SubMethodParameters(EnumerableIList<ResolvedParameter> value) { }

	[CompilerGenerated]
	// RVA: 0x526CC0 Offset: 0x525EC0 VA: 0x180526CC0
	public int get_RecurseCount() { }

	[CompilerGenerated]
	// RVA: 0x526DC0 Offset: 0x525FC0 VA: 0x180526DC0
	internal void set_RecurseCount(int value) { }

	[NullableContext(1)]
	// RVA: 0x1CC6550 Offset: 0x1CC5750 VA: 0x181CC6550
	internal bool IsSequentialEquivalent(ResolvedMethod obj) { }

	[NullableContext(1)]
	// RVA: 0x1CC6680 Offset: 0x1CC5880 VA: 0x181CC6680 Slot: 3
	public override string ToString() { }

	[NullableContext(1)]
	// RVA: 0x1CC5EA0 Offset: 0x1CC50A0 VA: 0x181CC5EA0
	public StringBuilder Append(StringBuilder builder) { }

	[NullableContext(1)]
	// RVA: 0x1CC5EB0 Offset: 0x1CC50B0 VA: 0x181CC5EB0
	public StringBuilder Append(StringBuilder builder, bool fullName) { }

	[NullableContext(1)]
	// RVA: 0x1CC5DE0 Offset: 0x1CC4FE0 VA: 0x181CC5DE0
	private StringBuilder AppendDeclaringTypeName(StringBuilder builder, bool fullName = True) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: System.Diagnostics
[NullableContext(1)]
[Nullable(0)]
internal class ResolvedParameter // TypeDefIndex: 13782
{
	// Fields
	[Nullable(2)]
	[CompilerGenerated]
	private string <Name>k__BackingField; // 0x10
	[CompilerGenerated]
	private Type <ResolvedType>k__BackingField; // 0x18
	[Nullable(2)]
	[CompilerGenerated]
	private string <Prefix>k__BackingField; // 0x20
	[CompilerGenerated]
	private bool <IsDynamicType>k__BackingField; // 0x28

	// Properties
	[Nullable(2)]
	public string Name { get; set; }
	public Type ResolvedType { get; set; }
	[Nullable(2)]
	public string Prefix { get; set; }
	public bool IsDynamicType { get; set; }

	// Methods

	[CompilerGenerated]
	[NullableContext(2)]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_Name() { }

	[CompilerGenerated]
	[NullableContext(2)]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_Name(string value) { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public Type get_ResolvedType() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_ResolvedType(Type value) { }

	[NullableContext(2)]
	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public string get_Prefix() { }

	[NullableContext(2)]
	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_Prefix(string value) { }

	[CompilerGenerated]
	// RVA: 0x42D840 Offset: 0x42CA40 VA: 0x18042D840
	public bool get_IsDynamicType() { }

	[CompilerGenerated]
	// RVA: 0x42D8B0 Offset: 0x42CAB0 VA: 0x18042D8B0
	public void set_IsDynamicType(bool value) { }

	// RVA: 0x81DA00 Offset: 0x81CC00 VA: 0x18081DA00
	public void .ctor(Type resolvedType) { }

	// RVA: 0x1CC69A0 Offset: 0x1CC5BA0 VA: 0x181CC69A0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1CC6770 Offset: 0x1CC5970 VA: 0x181CC6770
	public StringBuilder Append(StringBuilder sb) { }

	// RVA: 0x1CC6700 Offset: 0x1CC5900 VA: 0x181CC6700 Slot: 4
	protected virtual void AppendTypeName(StringBuilder sb) { }
}

// Namespace: System.Diagnostics
[NullableContext(1)]
[Nullable(0)]
[Extension]
internal static class StringBuilderExtentions // TypeDefIndex: 13783
{
	// Methods

	[Extension]
	// RVA: 0x1CC6A20 Offset: 0x1CC5C20 VA: 0x181CC6A20
	public static StringBuilder AppendDemystified(StringBuilder builder, Exception exception) { }

	[Extension]
	// RVA: 0x1CC6E30 Offset: 0x1CC6030 VA: 0x181CC6E30
	private static void AppendInnerException(StringBuilder builder, Exception exception) { }
}

// Namespace: 
[NullableContext(0)]
private struct TypeNameHelper.DisplayNameOptions // TypeDefIndex: 13784
{
	// Fields
	[CompilerGenerated]
	private readonly bool <FullName>k__BackingField; // 0x0
	[CompilerGenerated]
	private readonly bool <IncludeGenericParameterNames>k__BackingField; // 0x1

	// Properties
	public bool FullName { get; }
	public bool IncludeGenericParameterNames { get; }

	// Methods

	// RVA: 0x63DB50 Offset: 0x63CD50 VA: 0x18063DB50
	public void .ctor(bool fullName, bool includeGenericParameterNames) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x41D600 Offset: 0x41C800 VA: 0x18041D600
	public bool get_FullName() { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x13147E0 Offset: 0x13139E0 VA: 0x1813147E0
	public bool get_IncludeGenericParameterNames() { }
}

// Namespace: System.Diagnostics
[Nullable(0)]
[Extension]
[NullableContext(1)]
internal static class TypeNameHelper // TypeDefIndex: 13785
{
	// Fields
	public static readonly Dictionary<Type, string> BuiltInTypeNames; // 0x0
	public static readonly Dictionary<string, string> FSharpTypeNames; // 0x8

	// Methods

	// RVA: 0x1CC6FC0 Offset: 0x1CC61C0 VA: 0x181CC6FC0
	public static string GetTypeDisplayName(Type type, bool fullName = True, bool includeGenericParameterNames = False) { }

	[Extension]
	// RVA: 0x1CC6F30 Offset: 0x1CC6130 VA: 0x181CC6F30
	public static StringBuilder AppendTypeDisplayName(StringBuilder builder, Type type, bool fullName = True, bool includeGenericParameterNames = False) { }

	// RVA: 0x1CC7090 Offset: 0x1CC6290 VA: 0x181CC7090
	public static string GetTypeNameForGenericType(Type type) { }

	// RVA: 0x1CC7780 Offset: 0x1CC6980 VA: 0x181CC7780
	private static void ProcessType(StringBuilder builder, Type type, TypeNameHelper.DisplayNameOptions options) { }

	// RVA: 0x1CC71B0 Offset: 0x1CC63B0 VA: 0x181CC71B0
	private static void ProcessArrayType(StringBuilder builder, Type type, TypeNameHelper.DisplayNameOptions options) { }

	// RVA: 0x1CC7310 Offset: 0x1CC6510 VA: 0x181CC7310
	private static void ProcessGenericType(StringBuilder builder, Type type, Type[] genericArguments, int length, TypeNameHelper.DisplayNameOptions options) { }

	// RVA: 0x1CC7C20 Offset: 0x1CC6E20 VA: 0x181CC7C20
	private static void .cctor() { }
}

// Namespace: System.Diagnostics
[Nullable(0)]
[NullableContext(1)]
internal class ValueTupleResolvedParameter : ResolvedParameter // TypeDefIndex: 13786
{
	// Fields
	[CompilerGenerated]
	private readonly IList<string> <TupleNames>k__BackingField; // 0x30

	// Properties
	public IList<string> TupleNames { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public IList<string> get_TupleNames() { }

	// RVA: 0x1CC8970 Offset: 0x1CC7B70 VA: 0x181CC8970
	public void .ctor(Type resolvedType, IList<string> tupleNames) { }

	// RVA: 0x1CC84E0 Offset: 0x1CC76E0 VA: 0x181CC84E0 Slot: 4
	protected override void AppendTypeName(StringBuilder sb) { }

	// RVA: 0x1CC8790 Offset: 0x1CC7990 VA: 0x181CC8790
	private void AppendValueTupleParameterName(StringBuilder sb, Type parameterType) { }
}

// Namespace: System.Diagnostics.Internal
[NullableContext(1)]
[Nullable(0)]
internal class ILReader // TypeDefIndex: 13787
{
	// Fields
	private static OpCode[] singleByteOpCode; // 0x0
	private static OpCode[] doubleByteOpCode; // 0x8
	private readonly byte[] _cil; // 0x10
	private int ptr; // 0x18
	[CompilerGenerated]
	private OpCode <OpCode>k__BackingField; // 0x1C
	[CompilerGenerated]
	private int <MetadataToken>k__BackingField; // 0x24
	[Nullable(2)]
	[CompilerGenerated]
	private MemberInfo <Operand>k__BackingField; // 0x28

	// Properties
	public OpCode OpCode { get; set; }
	public int MetadataToken { get; set; }
	[Nullable(2)]
	public MemberInfo Operand { get; set; }

	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	public void .ctor(byte[] cil) { }

	[CompilerGenerated]
	// RVA: 0x1CC1240 Offset: 0x1CC0440 VA: 0x181CC1240
	public OpCode get_OpCode() { }

	[CompilerGenerated]
	// RVA: 0x1CC1250 Offset: 0x1CC0450 VA: 0x181CC1250
	private void set_OpCode(OpCode value) { }

	[CompilerGenerated]
	// RVA: 0x47BD90 Offset: 0x47AF90 VA: 0x18047BD90
	public int get_MetadataToken() { }

	[CompilerGenerated]
	// RVA: 0x47C1C0 Offset: 0x47B3C0 VA: 0x18047C1C0
	private void set_MetadataToken(int value) { }

	[NullableContext(2)]
	[CompilerGenerated]
	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public MemberInfo get_Operand() { }

	[CompilerGenerated]
	[NullableContext(2)]
	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	private void set_Operand(MemberInfo value) { }

	// RVA: 0x1CC0EC0 Offset: 0x1CC00C0 VA: 0x181CC0EC0
	public bool Read(MethodBase methodInfo) { }

	// RVA: 0x1CC0A60 Offset: 0x1CBFC60 VA: 0x181CC0A60
	private OpCode ReadOpCode() { }

	// RVA: 0x1CC0B60 Offset: 0x1CBFD60 VA: 0x181CC0B60
	private MemberInfo ReadOperand(OpCode code, MethodBase methodInfo) { }

	// RVA: 0x1CC0980 Offset: 0x1CBFB80 VA: 0x181CC0980
	private byte ReadByte() { }

	// RVA: 0x1CC09C0 Offset: 0x1CBFBC0 VA: 0x181CC09C0
	private int ReadInt() { }

	// RVA: 0x1CC1010 Offset: 0x1CC0210 VA: 0x181CC1010
	private static void .cctor() { }

	// RVA: 0x1CC0900 Offset: 0x1CBFB00 VA: 0x181CC0900
	private static FieldInfo[] GetOpCodeFields() { }
}

// Namespace: System.Diagnostics.Internal
[NullableContext(1)]
[Nullable(0)]
internal class PortablePdbReader : IDisposable // TypeDefIndex: 13788
{
	// Fields
	private readonly Dictionary<string, MetadataReaderProvider> _cache; // 0x10

	// Methods

	// RVA: 0x1CC53F0 Offset: 0x1CC45F0 VA: 0x181CC53F0
	public void PopulateStackFrame(StackFrame frameInfo, MethodBase method, int IlOffset, out string fileName, out int row, out int column) { }

	// RVA: 0x1CC4E10 Offset: 0x1CC4010 VA: 0x181CC4E10
	private MetadataReader GetMetadataReader(string assemblyPath) { }

	// RVA: 0x1CC4F40 Offset: 0x1CC4140 VA: 0x181CC4F40
	private static string GetPdbPath(string assemblyPath) { }

	// RVA: 0x1CC52A0 Offset: 0x1CC44A0 VA: 0x181CC52A0
	private static bool IsPortable(string pdbPath) { }

	// RVA: 0x1CC4CC0 Offset: 0x1CC3EC0 VA: 0x181CC4CC0 Slot: 4
	public void Dispose() { }

	// RVA: 0x1CC59B0 Offset: 0x1CC4BB0 VA: 0x181CC59B0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ReflectionHelper.<>c__DisplayClass4_0 // TypeDefIndex: 13789
{
	// Fields
	[Nullable(0)]
	public Type attributeType; // 0x10

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	[NullableContext(0)]
	// RVA: 0x1CC8430 Offset: 0x1CC7630 VA: 0x181CC8430
	internal PropertyInfo <GetTransformNamesPropertyInfo>b__0() { }
}

// Namespace: System.Diagnostics.Internal
[NullableContext(1)]
[Nullable(0)]
[Extension]
internal static class ReflectionHelper // TypeDefIndex: 13790
{
	// Fields
	[Nullable(2)]
	private static PropertyInfo transformerNamesLazyPropertyInfo; // 0x0

	// Methods

	[Extension]
	// RVA: 0x1CC5D40 Offset: 0x1CC4F40 VA: 0x181CC5D40
	public static bool IsValueTuple(Type type) { }

	[Extension]
	// RVA: 0x1CC5C90 Offset: 0x1CC4E90 VA: 0x181CC5C90
	public static bool IsTupleElementNameAttribute(Attribute attribute) { }

	[Extension]
	// RVA: 0x1CC5B60 Offset: 0x1CC4D60 VA: 0x181CC5B60
	public static IList<string> GetTransformerNames(Attribute attribute) { }

	// RVA: 0x1CC5A90 Offset: 0x1CC4C90 VA: 0x181CC5A90
	private static PropertyInfo GetTransformNamesPropertyInfo(Type attributeType) { }
}

// Namespace: System.Diagnostics.CodeAnalysis
[ExcludeFromCodeCoverage]
[Usage(2432)]
[DebuggerNonUserCode]
internal sealed class AllowNullAttribute : Attribute // TypeDefIndex: 13791
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.Diagnostics.CodeAnalysis
[DebuggerNonUserCode]
[Usage(2432)]
[ExcludeFromCodeCoverage]
internal sealed class DisallowNullAttribute : Attribute // TypeDefIndex: 13792
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.Diagnostics.CodeAnalysis
[DebuggerNonUserCode]
[ExcludeFromCodeCoverage]
[Usage(64, Inherited = False)]
internal sealed class DoesNotReturnAttribute : Attribute // TypeDefIndex: 13793
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.Diagnostics.CodeAnalysis
[DebuggerNonUserCode]
[Usage(2048)]
[ExcludeFromCodeCoverage]
internal sealed class DoesNotReturnIfAttribute : Attribute // TypeDefIndex: 13794
{
	// Fields
	[CompilerGenerated]
	private readonly bool <ParameterValue>k__BackingField; // 0x10

	// Properties
	public bool ParameterValue { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	public bool get_ParameterValue() { }

	// RVA: 0x547B70 Offset: 0x546D70 VA: 0x180547B70
	public void .ctor(bool parameterValue) { }
}

// Namespace: System.Diagnostics.CodeAnalysis
[DebuggerNonUserCode]
[ExcludeFromCodeCoverage]
[Usage(10624)]
internal sealed class MaybeNullAttribute : Attribute // TypeDefIndex: 13795
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.Diagnostics.CodeAnalysis
[ExcludeFromCodeCoverage]
[DebuggerNonUserCode]
[Usage(2048)]
internal sealed class MaybeNullWhenAttribute : Attribute // TypeDefIndex: 13796
{
	// Fields
	[CompilerGenerated]
	private readonly bool <ReturnValue>k__BackingField; // 0x10

	// Properties
	public bool ReturnValue { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	public bool get_ReturnValue() { }

	// RVA: 0x547B70 Offset: 0x546D70 VA: 0x180547B70
	public void .ctor(bool returnValue) { }
}

// Namespace: System.Diagnostics.CodeAnalysis
[NullableContext(1)]
[ExcludeFromCodeCoverage]
[DebuggerNonUserCode]
[Usage(192, Inherited = False, AllowMultiple = True)]
[Nullable(0)]
internal sealed class MemberNotNullAttribute : Attribute // TypeDefIndex: 13797
{
	// Fields
	[CompilerGenerated]
	private readonly string[] <Members>k__BackingField; // 0x10

	// Properties
	public string[] Members { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string[] get_Members() { }

	// RVA: 0x1CC12E0 Offset: 0x1CC04E0 VA: 0x181CC12E0
	public void .ctor(string member) { }

	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	public void .ctor(string[] members) { }
}

// Namespace: System.Diagnostics.CodeAnalysis
[ExcludeFromCodeCoverage]
[Nullable(0)]
[NullableContext(1)]
[Usage(192, Inherited = False, AllowMultiple = True)]
[DebuggerNonUserCode]
internal sealed class MemberNotNullWhenAttribute : Attribute // TypeDefIndex: 13798
{
	// Fields
	[CompilerGenerated]
	private readonly bool <ReturnValue>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly string[] <Members>k__BackingField; // 0x18

	// Properties
	public bool ReturnValue { get; }
	public string[] Members { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	public bool get_ReturnValue() { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string[] get_Members() { }

	// RVA: 0x1CC1360 Offset: 0x1CC0560 VA: 0x181CC1360
	public void .ctor(bool returnValue, string member) { }

	// RVA: 0x1C41C40 Offset: 0x1C40E40 VA: 0x181C41C40
	public void .ctor(bool returnValue, string[] members) { }
}

// Namespace: System.Diagnostics.CodeAnalysis
[ExcludeFromCodeCoverage]
[Usage(10624)]
[DebuggerNonUserCode]
internal sealed class NotNullAttribute : Attribute // TypeDefIndex: 13799
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.Diagnostics.CodeAnalysis
[Usage(10368, AllowMultiple = True)]
[DebuggerNonUserCode]
[ExcludeFromCodeCoverage]
[Nullable(0)]
[NullableContext(1)]
internal sealed class NotNullIfNotNullAttribute : Attribute // TypeDefIndex: 13800
{
	// Fields
	[CompilerGenerated]
	private readonly string <ParameterName>k__BackingField; // 0x10

	// Properties
	public string ParameterName { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_ParameterName() { }

	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	public void .ctor(string parameterName) { }
}

// Namespace: System.Diagnostics.CodeAnalysis
[Usage(2048)]
[ExcludeFromCodeCoverage]
[DebuggerNonUserCode]
internal sealed class NotNullWhenAttribute : Attribute // TypeDefIndex: 13801
{
	// Fields
	[CompilerGenerated]
	private readonly bool <ReturnValue>k__BackingField; // 0x10

	// Properties
	public bool ReturnValue { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	public bool get_ReturnValue() { }

	// RVA: 0x547B70 Offset: 0x546D70 VA: 0x180547B70
	public void .ctor(bool returnValue) { }
}

// Namespace: System.Diagnostics.CodeAnalysis
[DebuggerNonUserCode]
[Usage(32)]
[ExcludeFromCodeCoverage]
internal sealed class SetsRequiredMembersAttribute : Attribute // TypeDefIndex: 13802
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.Diagnostics.CodeAnalysis
[NullableContext(1)]
[Nullable(0)]
[Usage(2432)]
[ExcludeFromCodeCoverage]
[DebuggerNonUserCode]
internal sealed class StringSyntaxAttribute : Attribute // TypeDefIndex: 13803
{
	// Fields
	[CompilerGenerated]
	private readonly string <Syntax>k__BackingField; // 0x10
	[CompilerGenerated]
	[Nullable(new[] { 1, 2 })]
	private readonly object[] <Arguments>k__BackingField; // 0x18
	public const string CompositeFormat = "CompositeFormat";
	public const string DateOnlyFormat = "DateOnlyFormat";
	public const string DateTimeFormat = "DateTimeFormat";
	public const string EnumFormat = "EnumFormat";
	public const string GuidFormat = "GuidFormat";
	public const string Json = "Json";
	public const string NumericFormat = "NumericFormat";
	public const string Regex = "Regex";
	public const string TimeOnlyFormat = "TimeOnlyFormat";
	public const string TimeSpanFormat = "TimeSpanFormat";
	public const string Uri = "Uri";
	public const string Xml = "Xml";

	// Properties
	public string Syntax { get; }
	[Nullable(new[] { 1, 2 })]
	public object[] Arguments { get; }

	// Methods

	// RVA: 0x1CC6ED0 Offset: 0x1CC60D0 VA: 0x181CC6ED0
	public void .ctor(string syntax) { }

	// RVA: 0x1675460 Offset: 0x1674660 VA: 0x181675460
	public void .ctor(string syntax, object[] arguments) { }

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_Syntax() { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public object[] get_Arguments() { }
}

// Namespace: System.Diagnostics.CodeAnalysis
[Nullable(0)]
[NullableContext(2)]
[DebuggerNonUserCode]
[Usage(352, AllowMultiple = True, Inherited = False)]
[ExcludeFromCodeCoverage]
internal sealed class DynamicDependencyAttribute : Attribute // TypeDefIndex: 13804
{
	// Fields
	[CompilerGenerated]
	private readonly string <MemberSignature>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly DynamicallyAccessedMemberTypes <MemberTypes>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly Type <Type>k__BackingField; // 0x20
	[CompilerGenerated]
	private readonly string <TypeName>k__BackingField; // 0x28
	[CompilerGenerated]
	private readonly string <AssemblyName>k__BackingField; // 0x30
	[CompilerGenerated]
	private string <Condition>k__BackingField; // 0x38

	// Properties
	public string MemberSignature { get; }
	public DynamicallyAccessedMemberTypes MemberTypes { get; }
	public Type Type { get; }
	public string TypeName { get; }
	public string AssemblyName { get; }
	public string Condition { get; set; }

	// Methods

	[NullableContext(1)]
	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	public void .ctor(string memberSignature) { }

	[NullableContext(1)]
	// RVA: 0x1CC0660 Offset: 0x1CBF860 VA: 0x181CC0660
	public void .ctor(string memberSignature, Type type) { }

	[NullableContext(1)]
	// RVA: 0x1CC06F0 Offset: 0x1CBF8F0 VA: 0x181CC06F0
	public void .ctor(string memberSignature, string typeName, string assemblyName) { }

	[NullableContext(1)]
	// RVA: 0x1CC0620 Offset: 0x1CBF820 VA: 0x181CC0620
	public void .ctor(DynamicallyAccessedMemberTypes memberTypes, Type type) { }

	[NullableContext(1)]
	// RVA: 0x1CC06A0 Offset: 0x1CBF8A0 VA: 0x181CC06A0
	public void .ctor(DynamicallyAccessedMemberTypes memberTypes, string typeName, string assemblyName) { }

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_MemberSignature() { }

	[CompilerGenerated]
	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public DynamicallyAccessedMemberTypes get_MemberTypes() { }

	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public Type get_Type() { }

	[CompilerGenerated]
	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public string get_TypeName() { }

	[CompilerGenerated]
	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public string get_AssemblyName() { }

	[CompilerGenerated]
	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public string get_Condition() { }

	[CompilerGenerated]
	// RVA: 0x40EC50 Offset: 0x40DE50 VA: 0x18040EC50
	public void set_Condition(string value) { }
}

// Namespace: System.Diagnostics.CodeAnalysis
[Flags]
internal enum DynamicallyAccessedMemberTypes // TypeDefIndex: 13805
{
	// Fields
	public int value__; // 0x0
	public const DynamicallyAccessedMemberTypes None = 0;
	public const DynamicallyAccessedMemberTypes PublicParameterlessConstructor = 1;
	public const DynamicallyAccessedMemberTypes PublicConstructors = 3;
	public const DynamicallyAccessedMemberTypes NonPublicConstructors = 4;
	public const DynamicallyAccessedMemberTypes PublicMethods = 8;
	public const DynamicallyAccessedMemberTypes NonPublicMethods = 16;
	public const DynamicallyAccessedMemberTypes PublicFields = 32;
	public const DynamicallyAccessedMemberTypes NonPublicFields = 64;
	public const DynamicallyAccessedMemberTypes PublicNestedTypes = 128;
	public const DynamicallyAccessedMemberTypes NonPublicNestedTypes = 256;
	public const DynamicallyAccessedMemberTypes PublicProperties = 512;
	public const DynamicallyAccessedMemberTypes NonPublicProperties = 1024;
	public const DynamicallyAccessedMemberTypes PublicEvents = 2048;
	public const DynamicallyAccessedMemberTypes NonPublicEvents = 4096;
	public const DynamicallyAccessedMemberTypes Interfaces = 8192;
	public const DynamicallyAccessedMemberTypes All = -1;
}

// Namespace: System.Diagnostics.CodeAnalysis
[DebuggerNonUserCode]
[Usage(27072, Inherited = False)]
[ExcludeFromCodeCoverage]
internal sealed class DynamicallyAccessedMembersAttribute : Attribute // TypeDefIndex: 13806
{
	// Fields
	[CompilerGenerated]
	private readonly DynamicallyAccessedMemberTypes <MemberTypes>k__BackingField; // 0x10

	// Properties
	public DynamicallyAccessedMemberTypes MemberTypes { get; }

	// Methods

	// RVA: 0x15C97A0 Offset: 0x15C89A0 VA: 0x1815C97A0
	public void .ctor(DynamicallyAccessedMemberTypes memberTypes) { }

	[CompilerGenerated]
	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public DynamicallyAccessedMemberTypes get_MemberTypes() { }
}

// Namespace: System.Diagnostics.CodeAnalysis
[Usage(100, Inherited = False)]
[NullableContext(1)]
[Nullable(0)]
[DebuggerNonUserCode]
[ExcludeFromCodeCoverage]
internal sealed class RequiresDynamicCodeAttribute : Attribute // TypeDefIndex: 13807
{
	// Fields
	[CompilerGenerated]
	private readonly string <Message>k__BackingField; // 0x10
	[CompilerGenerated]
	[Nullable(2)]
	private string <Url>k__BackingField; // 0x18

	// Properties
	public string Message { get; }
	[Nullable(2)]
	public string Url { get; set; }

	// Methods

	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	public void .ctor(string message) { }

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_Message() { }

	[CompilerGenerated]
	[NullableContext(2)]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_Url() { }

	[NullableContext(2)]
	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_Url(string value) { }
}

// Namespace: System.Diagnostics.CodeAnalysis
[Nullable(0)]
[Usage(100, Inherited = False)]
[ExcludeFromCodeCoverage]
[NullableContext(1)]
[DebuggerNonUserCode]
internal sealed class RequiresUnreferencedCodeAttribute : Attribute // TypeDefIndex: 13808
{
	// Fields
	[CompilerGenerated]
	private readonly string <Message>k__BackingField; // 0x10
	[Nullable(2)]
	[CompilerGenerated]
	private string <Url>k__BackingField; // 0x18

	// Properties
	public string Message { get; }
	[Nullable(2)]
	public string Url { get; set; }

	// Methods

	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	public void .ctor(string message) { }

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_Message() { }

	[NullableContext(2)]
	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_Url() { }

	[NullableContext(2)]
	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_Url(string value) { }
}

// Namespace: System.Diagnostics.CodeAnalysis
[NullableContext(2)]
[Nullable(0)]
[ExcludeFromCodeCoverage]
[DebuggerNonUserCode]
[Usage(32767, Inherited = False, AllowMultiple = True)]
internal sealed class UnconditionalSuppressMessageAttribute : Attribute // TypeDefIndex: 13809
{
	// Fields
	[Nullable(1)]
	[CompilerGenerated]
	private readonly string <Category>k__BackingField; // 0x10
	[Nullable(1)]
	[CompilerGenerated]
	private readonly string <CheckId>k__BackingField; // 0x18
	[CompilerGenerated]
	private string <Scope>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <Target>k__BackingField; // 0x28
	[CompilerGenerated]
	private string <MessageId>k__BackingField; // 0x30
	[CompilerGenerated]
	private string <Justification>k__BackingField; // 0x38

	// Properties
	[Nullable(1)]
	public string Category { get; }
	[Nullable(1)]
	public string CheckId { get; }
	public string Scope { get; set; }
	public string Target { get; set; }
	public string MessageId { get; set; }
	public string Justification { get; set; }

	// Methods

	[NullableContext(1)]
	// RVA: 0x1675460 Offset: 0x1674660 VA: 0x181675460
	public void .ctor(string category, string checkId) { }

	[NullableContext(1)]
	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_Category() { }

	[NullableContext(1)]
	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_CheckId() { }

	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public string get_Scope() { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_Scope(string value) { }

	[CompilerGenerated]
	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public string get_Target() { }

	[CompilerGenerated]
	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	public void set_Target(string value) { }

	[CompilerGenerated]
	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public string get_MessageId() { }

	[CompilerGenerated]
	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	public void set_MessageId(string value) { }

	[CompilerGenerated]
	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public string get_Justification() { }

	[CompilerGenerated]
	// RVA: 0x40EC50 Offset: 0x40DE50 VA: 0x18040EC50
	public void set_Justification(string value) { }
}

// Namespace: System.Diagnostics.CodeAnalysis
[ExcludeFromCodeCoverage]
[DebuggerNonUserCode]
[Usage(2240, Inherited = False)]
internal sealed class UnscopedRefAttribute : Attribute // TypeDefIndex: 13810
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.Reflection
[Nullable(0)]
[NullableContext(1)]
internal sealed class NullabilityInfo // TypeDefIndex: 13811
{
	// Fields
	[CompilerGenerated]
	private readonly Type <Type>k__BackingField; // 0x10
	[CompilerGenerated]
	private NullabilityState <ReadState>k__BackingField; // 0x18
	[CompilerGenerated]
	private NullabilityState <WriteState>k__BackingField; // 0x1C
	[CompilerGenerated]
	[Nullable(2)]
	private readonly NullabilityInfo <ElementType>k__BackingField; // 0x20
	[CompilerGenerated]
	private readonly NullabilityInfo[] <GenericTypeArguments>k__BackingField; // 0x28

	// Properties
	public Type Type { get; }
	public NullabilityState ReadState { get; set; }
	public NullabilityState WriteState { get; set; }
	[Nullable(2)]
	public NullabilityInfo ElementType { get; }
	public NullabilityInfo[] GenericTypeArguments { get; }

	// Methods

	// RVA: 0x1CC49D0 Offset: 0x1CC3BD0 VA: 0x181CC49D0
	internal void .ctor(Type type, NullabilityState readState, NullabilityState writeState, NullabilityInfo elementType, NullabilityInfo[] typeArguments) { }

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Type get_Type() { }

	[CompilerGenerated]
	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public NullabilityState get_ReadState() { }

	[CompilerGenerated]
	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	internal void set_ReadState(NullabilityState value) { }

	[CompilerGenerated]
	// RVA: 0x3F9110 Offset: 0x3F8310 VA: 0x1803F9110
	public NullabilityState get_WriteState() { }

	[CompilerGenerated]
	// RVA: 0x3F9290 Offset: 0x3F8490 VA: 0x1803F9290
	internal void set_WriteState(NullabilityState value) { }

	[NullableContext(2)]
	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public NullabilityInfo get_ElementType() { }

	[CompilerGenerated]
	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public NullabilityInfo[] get_GenericTypeArguments() { }
}

// Namespace: System.Reflection
internal enum NullabilityState // TypeDefIndex: 13812
{
	// Fields
	public int value__; // 0x0
	public const NullabilityState Unknown = 0;
	public const NullabilityState NotNull = 1;
	public const NullabilityState Nullable = 2;
}

// Namespace: 
[Flags]
[NullableContext(0)]
private enum NullabilityInfoContext.NotAnnotatedStatus // TypeDefIndex: 13813
{
	// Fields
	public int value__; // 0x0
	public const NullabilityInfoContext.NotAnnotatedStatus None = 0;
	public const NullabilityInfoContext.NotAnnotatedStatus Private = 1;
	public const NullabilityInfoContext.NotAnnotatedStatus Internal = 2;
}

// Namespace: 
[NullableContext(2)]
[IsReadOnly]
[Nullable(0)]
private struct NullabilityInfoContext.NullableAttributeStateParser // TypeDefIndex: 13814
{
	// Fields
	[Nullable(1)]
	private static readonly object UnknownByte; // 0x0
	private readonly object _nullableAttributeArgument; // 0x0

	// Properties
	public static NullabilityInfoContext.NullableAttributeStateParser Unknown { get; }

	// Methods

	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void .ctor(object nullableAttributeArgument) { }

	// RVA: 0x1CC4C70 Offset: 0x1CC3E70 VA: 0x181CC4C70
	public static NullabilityInfoContext.NullableAttributeStateParser get_Unknown() { }

	// RVA: 0x1CC4A30 Offset: 0x1CC3C30 VA: 0x181CC4A30
	public bool ParseNullableState(int index, ref NullabilityState state) { }

	// RVA: 0x1CC4C10 Offset: 0x1CC3E10 VA: 0x181CC4C10
	private static void .cctor() { }
}

// Namespace: System.Reflection
[NullableContext(1)]
[Nullable(0)]
internal sealed class NullabilityInfoContext // TypeDefIndex: 13815
{
	// Fields
	private const string CompilerServicesNameSpace = "System.Runtime.CompilerServices";
	private readonly Dictionary<Module, NullabilityInfoContext.NotAnnotatedStatus> _publicOnlyModules; // 0x10
	private readonly Dictionary<MemberInfo, NullabilityState> _context; // 0x18
	[CompilerGenerated]
	private static readonly bool <IsSupported>k__BackingField; // 0x0

	// Properties
	internal static bool IsSupported { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1CC4980 Offset: 0x1CC3B80 VA: 0x181CC4980
	internal static bool get_IsSupported() { }

	[NullableContext(2)]
	// RVA: 0x1CC3000 Offset: 0x1CC2200 VA: 0x181CC3000
	private Nullable<NullabilityState> GetNullableContext(MemberInfo memberInfo) { }

	// RVA: 0x1CC20B0 Offset: 0x1CC12B0 VA: 0x181CC20B0
	public NullabilityInfo Create(ParameterInfo parameterInfo) { }

	// RVA: 0x1CC1A90 Offset: 0x1CC0C90 VA: 0x181CC1A90
	private void CheckParameterMetadataType(ParameterInfo parameter, NullabilityInfo nullability) { }

	// RVA: 0x1CC2B70 Offset: 0x1CC1D70 VA: 0x181CC2B70
	private static MethodInfo GetMethodMetadataDefinition(MethodInfo method) { }

	// RVA: 0x1CC15B0 Offset: 0x1CC07B0 VA: 0x181CC15B0
	private static void CheckNullabilityAttributes(NullabilityInfo nullability, IList<CustomAttributeData> attributes) { }

	// RVA: 0x1CC2660 Offset: 0x1CC1860 VA: 0x181CC2660
	public NullabilityInfo Create(PropertyInfo propertyInfo) { }

	// RVA: 0x1CC3610 Offset: 0x1CC2810 VA: 0x181CC3610
	private bool IsPrivateOrInternalMethodAndAnnotationDisabled(MethodBase method) { }

	// RVA: 0x1CC2310 Offset: 0x1CC1510 VA: 0x181CC2310
	public NullabilityInfo Create(EventInfo eventInfo) { }

	// RVA: 0x1CC2410 Offset: 0x1CC1610 VA: 0x181CC2410
	public NullabilityInfo Create(FieldInfo fieldInfo) { }

	// RVA: 0x1CC2980 Offset: 0x1CC1B80 VA: 0x181CC2980
	private static void EnsureIsSupported() { }

	// RVA: 0x1CC3520 Offset: 0x1CC2720 VA: 0x181CC3520
	private bool IsPrivateOrInternalFieldAndAnnotationDisabled(FieldInfo fieldInfo) { }

	// RVA: 0x1CC3700 Offset: 0x1CC2900 VA: 0x181CC3700
	private bool IsPublicOnly(bool isPrivate, bool isFamilyAndAssembly, bool isAssembly, Module module) { }

	// RVA: 0x1CC38B0 Offset: 0x1CC2AB0 VA: 0x181CC38B0
	private static NullabilityInfoContext.NotAnnotatedStatus PopulateAnnotationInfo(IList<CustomAttributeData> customAttributes) { }

	// RVA: 0x1CC2C80 Offset: 0x1CC1E80 VA: 0x181CC2C80
	private NullabilityInfo GetNullabilityInfo(MemberInfo memberInfo, Type type, NullabilityInfoContext.NullableAttributeStateParser parser) { }

	// RVA: 0x1CC2CF0 Offset: 0x1CC1EF0 VA: 0x181CC2CF0
	private NullabilityInfo GetNullabilityInfo(MemberInfo memberInfo, Type type, NullabilityInfoContext.NullableAttributeStateParser parser, ref int index) { }

	// RVA: 0x1CC1E00 Offset: 0x1CC1000 VA: 0x181CC1E00
	private static NullabilityInfoContext.NullableAttributeStateParser CreateParser(IList<CustomAttributeData> customAttributes) { }

	// RVA: 0x1CC3CC0 Offset: 0x1CC2EC0 VA: 0x181CC3CC0
	private void TryLoadGenericMetaTypeNullability(MemberInfo memberInfo, NullabilityInfo nullability) { }

	// RVA: 0x1CC2A50 Offset: 0x1CC1C50 VA: 0x181CC2A50
	private static MemberInfo GetMemberMetadataDefinition(MemberInfo member) { }

	// RVA: 0x1CC3460 Offset: 0x1CC2660 VA: 0x181CC3460
	private static Type GetPropertyMetaType(PropertyInfo property) { }

	// RVA: 0x1CC13F0 Offset: 0x1CC05F0 VA: 0x181CC13F0
	private void CheckGenericParameters(NullabilityInfo nullability, MemberInfo metaMember, Type metaType, Type reflectedType) { }

	// RVA: 0x1CC4110 Offset: 0x1CC3310 VA: 0x181CC4110
	private bool TryUpdateGenericParameterNullability(NullabilityInfo nullability, Type genericParameter, Type reflectedType) { }

	// RVA: 0x1CC4320 Offset: 0x1CC3520 VA: 0x181CC4320
	private bool TryUpdateGenericTypeParameterNullabilityFromReflectedType(NullabilityInfo nullability, Type genericParameter, Type context, Type reflectedType) { }

	// RVA: 0x1CC3F20 Offset: 0x1CC3120 VA: 0x181CC3F20
	private bool TryPopulateNullabilityInfo(NullabilityInfo nullability, NullabilityInfoContext.NullableAttributeStateParser parser, ref int index) { }

	[NullableContext(2)]
	// RVA: 0x1CC3BE0 Offset: 0x1CC2DE0 VA: 0x181CC3BE0
	private static NullabilityState TranslateByte(object value) { }

	// RVA: 0x1CC3CA0 Offset: 0x1CC2EA0 VA: 0x181CC3CA0
	private static NullabilityState TranslateByte(byte b) { }

	// RVA: 0x1CC3830 Offset: 0x1CC2A30 VA: 0x181CC3830
	private static bool IsValueTypeOrValueTypeByRef(Type type) { }

	// RVA: 0x1CC48D0 Offset: 0x1CC3AD0 VA: 0x181CC48D0
	public void .ctor() { }

	// RVA: 0x1CC4840 Offset: 0x1CC3A40 VA: 0x181CC4840
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x1CC46A0 Offset: 0x1CC38A0 VA: 0x181CC46A0
	internal static int <TryUpdateGenericTypeParameterNullabilityFromReflectedType>g__CountNullabilityStates|28_0(Type type) { }
}

// Namespace: System.Runtime.InteropServices
[Usage(64, Inherited = False)]
[DebuggerNonUserCode]
[ExcludeFromCodeCoverage]
internal sealed class SuppressGCTransitionAttribute : Attribute // TypeDefIndex: 13816
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.Runtime.InteropServices
[DebuggerNonUserCode]
[ExcludeFromCodeCoverage]
[Usage(64, Inherited = False)]
internal sealed class UnmanagedCallersOnlyAttribute : Attribute // TypeDefIndex: 13817
{
	// Fields
	[Nullable(new[] { 2, 1 })]
	public Type[] CallConvs; // 0x10
	[Nullable(2)]
	public string EntryPoint; // 0x18

	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.Runtime.Versioning
[DebuggerNonUserCode]
[ExcludeFromCodeCoverage]
[Nullable(0)]
[NullableContext(1)]
internal abstract class OSPlatformAttribute : Attribute // TypeDefIndex: 13818
{
	// Fields
	[CompilerGenerated]
	private readonly string <PlatformName>k__BackingField; // 0x10

	// Properties
	public string PlatformName { get; }

	// Methods

	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	protected void .ctor(string platformName) { }

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_PlatformName() { }
}

// Namespace: System.Runtime.Versioning
[NullableContext(2)]
[Nullable(0)]
[ExcludeFromCodeCoverage]
[DebuggerNonUserCode]
[Usage(2047, AllowMultiple = True, Inherited = False)]
internal sealed class ObsoletedOSPlatformAttribute : OSPlatformAttribute // TypeDefIndex: 13819
{
	// Fields
	[CompilerGenerated]
	private readonly string <Message>k__BackingField; // 0x18
	[CompilerGenerated]
	private string <Url>k__BackingField; // 0x20

	// Properties
	public string Message { get; }
	public string Url { get; set; }

	// Methods

	[NullableContext(1)]
	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	public void .ctor(string platformName) { }

	[NullableContext(1)]
	// RVA: 0x1675460 Offset: 0x1674660 VA: 0x181675460
	public void .ctor(string platformName, string message) { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_Message() { }

	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public string get_Url() { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_Url(string value) { }
}

// Namespace: System.Runtime.Versioning
[ExcludeFromCodeCoverage]
[DebuggerNonUserCode]
[Usage(2047, AllowMultiple = True, Inherited = False)]
internal sealed class SupportedOSPlatformAttribute : OSPlatformAttribute // TypeDefIndex: 13820
{
	// Methods

	[NullableContext(1)]
	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	public void .ctor(string platformName) { }
}

// Namespace: System.Runtime.Versioning
[Usage(448, AllowMultiple = True, Inherited = False)]
[DebuggerNonUserCode]
[ExcludeFromCodeCoverage]
internal sealed class SupportedOSPlatformGuardAttribute : OSPlatformAttribute // TypeDefIndex: 13821
{
	// Methods

	[NullableContext(1)]
	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	public void .ctor(string platformName) { }
}

// Namespace: System.Runtime.Versioning
[ExcludeFromCodeCoverage]
[DebuggerNonUserCode]
[Usage(1)]
internal sealed class TargetPlatformAttribute : OSPlatformAttribute // TypeDefIndex: 13822
{
	// Methods

	[NullableContext(1)]
	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	public void .ctor(string platformName) { }
}

// Namespace: System.Runtime.Versioning
[Usage(2047, AllowMultiple = True, Inherited = False)]
[ExcludeFromCodeCoverage]
[Nullable(0)]
[DebuggerNonUserCode]
[NullableContext(2)]
internal sealed class UnsupportedOSPlatformAttribute : OSPlatformAttribute // TypeDefIndex: 13823
{
	// Fields
	[CompilerGenerated]
	private readonly string <Message>k__BackingField; // 0x18

	// Properties
	public string Message { get; }

	// Methods

	[NullableContext(1)]
	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	public void .ctor(string platformName) { }

	[NullableContext(1)]
	// RVA: 0x1675460 Offset: 0x1674660 VA: 0x181675460
	public void .ctor(string platformName, string message) { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public string get_Message() { }
}

// Namespace: System.Runtime.Versioning
[ExcludeFromCodeCoverage]
[DebuggerNonUserCode]
[Usage(448, AllowMultiple = True, Inherited = False)]
internal sealed class UnsupportedOSPlatformGuardAttribute : OSPlatformAttribute // TypeDefIndex: 13824
{
	// Methods

	[NullableContext(1)]
	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	public void .ctor(string platformName) { }
}

// Namespace: System.Runtime.CompilerServices
[NullableContext(1)]
[DebuggerNonUserCode]
[ExcludeFromCodeCoverage]
[Nullable(0)]
[Usage(2048)]
internal sealed class CallerArgumentExpressionAttribute : Attribute // TypeDefIndex: 13825
{
	// Fields
	[CompilerGenerated]
	private readonly string <ParameterName>k__BackingField; // 0x10

	// Properties
	public string ParameterName { get; }

	// Methods

	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	public void .ctor(string parameterName) { }

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_ParameterName() { }
}

// Namespace: System.Runtime.CompilerServices
[Nullable(0)]
[ExcludeFromCodeCoverage]
[DebuggerNonUserCode]
[Usage(32767, AllowMultiple = True, Inherited = False)]
[NullableContext(1)]
internal sealed class CompilerFeatureRequiredAttribute : Attribute // TypeDefIndex: 13826
{
	// Fields
	[CompilerGenerated]
	private readonly string <FeatureName>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly bool <IsOptional>k__BackingField; // 0x18
	public const string RefStructs = "RefStructs";
	public const string RequiredMembers = "RequiredMembers";

	// Properties
	public string FeatureName { get; }
	public bool IsOptional { get; set; }

	// Methods

	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	public void .ctor(string featureName) { }

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_FeatureName() { }

	[CompilerGenerated]
	// RVA: 0x411B20 Offset: 0x410D20 VA: 0x180411B20
	public bool get_IsOptional() { }

	[CompilerGenerated]
	// RVA: 0x411B30 Offset: 0x410D30 VA: 0x180411B30
	public void set_IsOptional(bool value) { }
}

// Namespace: System.Runtime.CompilerServices
[Usage(1)]
[ExcludeFromCodeCoverage]
[DebuggerNonUserCode]
internal sealed class DisableRuntimeMarshallingAttribute : Attribute // TypeDefIndex: 13827
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.Runtime.CompilerServices
[Usage(2048)]
[DebuggerNonUserCode]
[Nullable(0)]
[ExcludeFromCodeCoverage]
[NullableContext(1)]
internal sealed class InterpolatedStringHandlerArgumentAttribute : Attribute // TypeDefIndex: 13828
{
	// Fields
	[CompilerGenerated]
	private readonly string[] <Arguments>k__BackingField; // 0x10

	// Properties
	public string[] Arguments { get; }

	// Methods

	// RVA: 0x1CC1260 Offset: 0x1CC0460 VA: 0x181CC1260
	public void .ctor(string argument) { }

	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	public void .ctor(string[] arguments) { }

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string[] get_Arguments() { }
}

// Namespace: System.Runtime.CompilerServices
[ExcludeFromCodeCoverage]
[Usage(12, Inherited = False)]
[DebuggerNonUserCode]
internal sealed class InterpolatedStringHandlerAttribute : Attribute // TypeDefIndex: 13829
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.Runtime.CompilerServices
[DebuggerNonUserCode]
[ExcludeFromCodeCoverage]
internal static class IsExternalInit // TypeDefIndex: 13830
{}

// Namespace: System.Runtime.CompilerServices
[Usage(64, Inherited = False)]
[ExcludeFromCodeCoverage]
[DebuggerNonUserCode]
internal sealed class ModuleInitializerAttribute : Attribute // TypeDefIndex: 13831
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.Runtime.CompilerServices
[ExcludeFromCodeCoverage]
[Usage(396, Inherited = False)]
[DebuggerNonUserCode]
internal sealed class RequiredMemberAttribute : Attribute // TypeDefIndex: 13832
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.Runtime.CompilerServices
[DebuggerNonUserCode]
[Usage(1774, Inherited = False)]
[ExcludeFromCodeCoverage]
internal sealed class SkipLocalsInitAttribute : Attribute // TypeDefIndex: 13833
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 // TypeDefIndex: 13834
{}

// Namespace: 
[CompilerGenerated]
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 13835
{
	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 04D9D643E5A26924DC98C9906714082D395DCB17CEE9674D5EBFEC15D098C2B5 /*Metadata offset 0x8EE1A0*/; // 0x0

	// Methods

	// RVA: 0x1CC8210 Offset: 0x1CC7410 VA: 0x181CC8210
	internal static void ThrowInvalidOperationException() { }
}

// Namespace: 
internal class <Module> // TypeDefIndex: 13836
{}

// Namespace: Microsoft.CodeAnalysis
[CompilerGenerated]
[Embedded]
internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 13837
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: System.Runtime.CompilerServices
[Embedded]
[CompilerGenerated]
internal sealed class IsUnmanagedAttribute : Attribute // TypeDefIndex: 13838
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: AOT
[Usage(64, AllowMultiple = True)]
public class MonoPInvokeCallbackAttribute : Attribute // TypeDefIndex: 13839
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor(Type type) { }
}

// Namespace: UnityEngineInternal
[Il2CppEagerStaticClassConstruction]
public struct MathfInternal // TypeDefIndex: 13840
{
	// Fields
	public static float FloatMinNormal; // 0x0
	public static float FloatMinDenormal; // 0x4
	public static bool IsFlushToZeroEnabled; // 0x8

	// Methods

	// RVA: 0x2462010 Offset: 0x2461210 VA: 0x182462010
	private static void .cctor() { }
}

// Namespace: UnityEngineInternal
public enum TypeInferenceRules // TypeDefIndex: 13841
{
	// Fields
	public int value__; // 0x0
	public const TypeInferenceRules TypeReferencedByFirstArgument = 0;
	public const TypeInferenceRules TypeReferencedBySecondArgument = 1;
	public const TypeInferenceRules ArrayOfTypeReferencedByFirstArgument = 2;
	public const TypeInferenceRules TypeOfFirstArgument = 3;
}

// Namespace: UnityEngineInternal
[Usage(64)]
[Serializable]
public class TypeInferenceRuleAttribute : Attribute // TypeDefIndex: 13842
{
	// Fields
	private readonly string _rule; // 0x10

	// Methods

	// RVA: 0x2474A30 Offset: 0x2473C30 VA: 0x182474A30
	public void .ctor(TypeInferenceRules rule) { }

	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	public void .ctor(string rule) { }

	// RVA: 0x1208660 Offset: 0x1207860 VA: 0x181208660 Slot: 3
	public override string ToString() { }
}

// Namespace: UnityEngineInternal
public class GenericStack : Stack // TypeDefIndex: 13843
{
	// Methods

	// RVA: 0x24590B0 Offset: 0x24582B0 VA: 0x1824590B0
	public void .ctor() { }
}

// Namespace: Unity.Jobs
[JobProducerType(typeof(IJobExtensions.JobStruct<T>))]
public interface IJob // TypeDefIndex: 13844
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Execute();
}

// Namespace: 
internal sealed class IJobExtensions.JobStruct.ExecuteJobFunction<T> : MulticastDelegate // TypeDefIndex: 13845
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11EFD30 Offset: 0x11EEF30 VA: 0x1811EFD30
	|-IJobExtensions.JobStruct.ExecuteJobFunction<NativeArrayDisposeJob>..ctor
	|-IJobExtensions.JobStruct.ExecuteJobFunction<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(ref T data, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x449250 Offset: 0x448450 VA: 0x180449250
	|-IJobExtensions.JobStruct.ExecuteJobFunction<NativeArrayDisposeJob>.Invoke
	|-IJobExtensions.JobStruct.ExecuteJobFunction<__Il2CppFullySharedGenericStructType>.Invoke
	*/
}

// Namespace: 
internal struct IJobExtensions.JobStruct<T> // TypeDefIndex: 13846
{
	// Fields
	internal static readonly BurstLike.SharedStatic<IntPtr> jobReflectionData; // 0x0

	// Methods

	[BurstDiscard]
	// RVA: -1 Offset: -1
	internal static void Initialize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12B3750 Offset: 0x12B2950 VA: 0x1812B3750
	|-IJobExtensions.JobStruct<NativeArrayDisposeJob>.Initialize
	|
	|-RVA: 0x12B39C0 Offset: 0x12B2BC0 VA: 0x1812B39C0
	|-IJobExtensions.JobStruct<__Il2CppFullySharedGenericStructType>.Initialize
	*/

	// RVA: -1 Offset: -1
	public static void Execute(ref T data, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12B3600 Offset: 0x12B2800 VA: 0x1812B3600
	|-IJobExtensions.JobStruct<NativeArrayDisposeJob>.Execute
	|
	|-RVA: 0x12B3640 Offset: 0x12B2840 VA: 0x1812B3640
	|-IJobExtensions.JobStruct<__Il2CppFullySharedGenericStructType>.Execute
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB7D290 Offset: 0xB7C490 VA: 0x180B7D290
	|-IJobExtensions.JobStruct<NativeArrayDisposeJob>..cctor
	|
	|-RVA: 0xB7D320 Offset: 0xB7C520 VA: 0x180B7D320
	|-IJobExtensions.JobStruct<__Il2CppFullySharedGenericStructType>..cctor
	*/
}

// Namespace: Unity.Jobs
[Extension]
public static class IJobExtensions // TypeDefIndex: 13847
{
	// Methods

	// RVA: -1 Offset: -1
	public static void EarlyJobInit<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA23510 Offset: 0xA22710 VA: 0x180A23510
	|-IJobExtensions.EarlyJobInit<NativeArrayDisposeJob>
	|
	|-RVA: 0xA234B0 Offset: 0xA226B0 VA: 0x180A234B0
	|-IJobExtensions.EarlyJobInit<__Il2CppFullySharedGenericStructType>
	*/
}

// Namespace: Unity.Jobs
[JobProducerType(typeof(IJobParallelForExtensions.ParallelForJobStruct<T>))]
public interface IJobParallelFor // TypeDefIndex: 13848
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Execute(int index);
}

// Namespace: 
public sealed class IJobParallelForExtensions.ParallelForJobStruct.ExecuteJobFunction<T> : MulticastDelegate // TypeDefIndex: 13849
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11EFD30 Offset: 0x11EEF30 VA: 0x1811EFD30
	|-IJobParallelForExtensions.ParallelForJobStruct.ExecuteJobFunction<__Il2CppFullySharedGenericStructType>..ctor
	|-IJobParallelForExtensions.ParallelForJobStruct.ExecuteJobFunction<OpacityIdAccelerator.OpacityIdUpdateJob>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(ref T data, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x449250 Offset: 0x448450 VA: 0x180449250
	|-IJobParallelForExtensions.ParallelForJobStruct.ExecuteJobFunction<__Il2CppFullySharedGenericStructType>.Invoke
	|-IJobParallelForExtensions.ParallelForJobStruct.ExecuteJobFunction<OpacityIdAccelerator.OpacityIdUpdateJob>.Invoke
	*/
}

// Namespace: 
internal struct IJobParallelForExtensions.ParallelForJobStruct<T> // TypeDefIndex: 13850
{
	// Fields
	internal static readonly BurstLike.SharedStatic<IntPtr> jobReflectionData; // 0x0

	// Methods

	[BurstDiscard]
	// RVA: -1 Offset: -1
	internal static void Initialize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB7CD80 Offset: 0xB7BF80 VA: 0x180B7CD80
	|-IJobParallelForExtensions.ParallelForJobStruct<__Il2CppFullySharedGenericStructType>.Initialize
	|
	|-RVA: 0xB7D020 Offset: 0xB7C220 VA: 0x180B7D020
	|-IJobParallelForExtensions.ParallelForJobStruct<OpacityIdAccelerator.OpacityIdUpdateJob>.Initialize
	*/

	// RVA: -1 Offset: -1
	public static void Execute(ref T jobData, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB7CB00 Offset: 0xB7BD00 VA: 0x180B7CB00
	|-IJobParallelForExtensions.ParallelForJobStruct<__Il2CppFullySharedGenericStructType>.Execute
	|
	|-RVA: 0xB7CCA0 Offset: 0xB7BEA0 VA: 0x180B7CCA0
	|-IJobParallelForExtensions.ParallelForJobStruct<OpacityIdAccelerator.OpacityIdUpdateJob>.Execute
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB7D320 Offset: 0xB7C520 VA: 0x180B7D320
	|-IJobParallelForExtensions.ParallelForJobStruct<__Il2CppFullySharedGenericStructType>..cctor
	|
	|-RVA: 0xB7D290 Offset: 0xB7C490 VA: 0x180B7D290
	|-IJobParallelForExtensions.ParallelForJobStruct<OpacityIdAccelerator.OpacityIdUpdateJob>..cctor
	*/
}

// Namespace: Unity.Jobs
[Extension]
public static class IJobParallelForExtensions // TypeDefIndex: 13851
{
	// Methods

	// RVA: -1 Offset: -1
	private static IntPtr GetReflectionData<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA23560 Offset: 0xA22760 VA: 0x180A23560
	|-IJobParallelForExtensions.GetReflectionData<__Il2CppFullySharedGenericStructType>
	|
	|-RVA: 0xA23610 Offset: 0xA22810 VA: 0x180A23610
	|-IJobParallelForExtensions.GetReflectionData<OpacityIdAccelerator.OpacityIdUpdateJob>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static JobHandle Schedule<T>(T jobData, int arrayLength, int innerloopBatchCount, JobHandle dependsOn) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA236C0 Offset: 0xA228C0 VA: 0x180A236C0
	|-IJobParallelForExtensions.Schedule<__Il2CppFullySharedGenericStructType>
	|
	|-RVA: 0xA237B0 Offset: 0xA229B0 VA: 0x180A237B0
	|-IJobParallelForExtensions.Schedule<OpacityIdAccelerator.OpacityIdUpdateJob>
	*/
}

// Namespace: Unity.Jobs
[NativeType(Header = "Runtime/Jobs/ScriptBindings/JobsBindings.h")]
public struct JobHandle : IEquatable<JobHandle> // TypeDefIndex: 13852
{
	// Fields
	internal ulong jobGroup; // 0x0
	internal int version; // 0x8

	// Methods

	// RVA: 0x245A2A0 Offset: 0x24594A0 VA: 0x18245A2A0
	public void Complete() { }

	[NativeMethod("ScheduleBatchedScriptingJobs", IsFreeFunction = True, IsThreadSafe = True)]
	// RVA: 0x245A330 Offset: 0x2459530 VA: 0x18245A330
	public static void ScheduleBatchedJobs() { }

	[NativeMethod("ScheduleBatchedScriptingJobsAndComplete", IsFreeFunction = True, IsThreadSafe = True, ThrowsException = True)]
	// RVA: 0x245A2F0 Offset: 0x24594F0 VA: 0x18245A2F0
	private static void ScheduleBatchedJobsAndComplete(ref JobHandle job) { }

	// RVA: 0x245A130 Offset: 0x2459330 VA: 0x18245A130
	public static JobHandle CombineDependencies(NativeArray<JobHandle> jobs) { }

	// RVA: 0x245A1E0 Offset: 0x24593E0 VA: 0x18245A1E0
	public static JobHandle CombineDependencies(NativeSlice<JobHandle> jobs) { }

	[NativeMethod(IsFreeFunction = True, IsThreadSafe = True, ThrowsException = True)]
	// RVA: 0x245A0D0 Offset: 0x24592D0 VA: 0x18245A0D0
	internal static JobHandle CombineDependenciesInternalPtr(void* jobs, int count) { }

	// RVA: 0x245A2E0 Offset: 0x24594E0 VA: 0x18245A2E0 Slot: 4
	public bool Equals(JobHandle other) { }

	// RVA: 0x245A080 Offset: 0x2459280 VA: 0x18245A080
	private static void CombineDependenciesInternalPtr_Injected(void* jobs, int count, out JobHandle ret) { }
}

// Namespace: Unity.Jobs.LowLevel.Unsafe
[Usage(1024)]
public sealed class JobProducerTypeAttribute : Attribute // TypeDefIndex: 13853
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly Type <ProducerType>k__BackingField; // 0x10

	// Methods

	// RVA: 0x547B40 Offset: 0x546D40 VA: 0x180547B40
	public void .ctor(Type producerType) { }
}

// Namespace: Unity.Jobs.LowLevel.Unsafe
public struct JobRanges // TypeDefIndex: 13854
{
	// Fields
	internal int BatchSize; // 0x0
	internal int NumJobs; // 0x4
	public int TotalIterationCount; // 0x8
	internal IntPtr StartEndIndex; // 0x10
}

// Namespace: Unity.Jobs.LowLevel.Unsafe
public enum ScheduleMode // TypeDefIndex: 13855
{
	// Fields
	public int value__; // 0x0
	public const ScheduleMode Run = 0;
	[Obsolete("Batched is obsolete, use Parallel or Single depending on job type. (UnityUpgradable) -> Parallel", False)]
	public const ScheduleMode Batched = 1;
	public const ScheduleMode Parallel = 1;
	public const ScheduleMode Single = 2;
}

// Namespace: 
public struct JobsUtility.JobScheduleParameters // TypeDefIndex: 13856
{
	// Fields
	public JobHandle Dependency; // 0x0
	public int ScheduleMode; // 0x10
	public IntPtr ReflectionData; // 0x18
	public IntPtr JobDataPtr; // 0x20

	// Methods

	// RVA: 0x245A360 Offset: 0x2459560 VA: 0x18245A360
	public void .ctor(void* i_jobData, IntPtr i_reflectionData, JobHandle i_dependency, ScheduleMode i_scheduleMode) { }
}

// Namespace: 
internal sealed class JobsUtility.PanicFunction_ : MulticastDelegate // TypeDefIndex: 13857
{
	// Methods

	// RVA: 0x458710 Offset: 0x457910 VA: 0x180458710
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x4240E0 Offset: 0x4232E0 VA: 0x1804240E0 Slot: 13
	public virtual void Invoke() { }
}

// Namespace: Unity.Jobs.LowLevel.Unsafe
[NativeHeader("Runtime/Jobs/JobSystem.h")]
[NativeType(Header = "Runtime/Jobs/ScriptBindings/JobsBindings.h")]
public static class JobsUtility // TypeDefIndex: 13858
{
	// Fields
	internal static JobsUtility.PanicFunction_ PanicFunction; // 0x0

	// Methods

	[NativeMethod(IsFreeFunction = True, IsThreadSafe = True)]
	// RVA: 0x245A480 Offset: 0x2459680 VA: 0x18245A480
	public static bool GetWorkStealingRange(ref JobRanges ranges, int jobIndex, out int beginIndex, out int endIndex) { }

	[FreeFunction("ScheduleManagedJobParallelFor", ThrowsException = True, IsThreadSafe = True)]
	// RVA: 0x245A590 Offset: 0x2459790 VA: 0x18245A590
	public static JobHandle ScheduleParallelFor(ref JobsUtility.JobScheduleParameters parameters, int arrayLength, int innerloopBatchCount) { }

	[FreeFunction(ThrowsException = True, IsThreadSafe = True)]
	// RVA: 0x245A410 Offset: 0x2459610 VA: 0x18245A410
	private static IntPtr CreateJobReflectionData(Type wrapperJobType, Type userJobType, object managedJobFunction0, object managedJobFunction1, object managedJobFunction2) { }

	// RVA: 0x245A3A0 Offset: 0x24595A0 VA: 0x18245A3A0
	public static IntPtr CreateJobReflectionData(Type type, object managedJobFunction0, object managedJobFunction1, object managedJobFunction2) { }

	[RequiredByNativeCode]
	// RVA: 0x245A4E0 Offset: 0x24596E0 VA: 0x18245A4E0
	private static void InvokePanicFunction() { }

	// RVA: 0x245A530 Offset: 0x2459730 VA: 0x18245A530
	private static void ScheduleParallelFor_Injected(ref JobsUtility.JobScheduleParameters parameters, int arrayLength, int innerloopBatchCount, out JobHandle ret) { }
}

// Namespace: Unity.IL2CPP.CompilerServices
[Usage(12, Inherited = False, AllowMultiple = False)]
internal class Il2CppEagerStaticClassConstructionAttribute : Attribute // TypeDefIndex: 13859
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: Unity.Profiling
[RequiredByNativeCode]
[Usage(76, AllowMultiple = False)]
public sealed class IgnoredByDeepProfilerAttribute : Attribute // TypeDefIndex: 13860
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: Unity.Profiling
[IsReadOnly]
[UsedByNativeCode]
public struct ProfilerCategory // TypeDefIndex: 13861
{
	// Fields
	private readonly ushort m_CategoryId; // 0x0

	// Properties
	public string Name { get; }
	public static ProfilerCategory Scripts { get; }
	public static ProfilerCategory Memory { get; }

	// Methods

	// RVA: 0x4D1C10 Offset: 0x4D0E10 VA: 0x1804D1C10
	internal void .ctor(ushort category) { }

	// RVA: 0x246C870 Offset: 0x246BA70 VA: 0x18246C870
	public string get_Name() { }

	// RVA: 0x246C860 Offset: 0x246BA60 VA: 0x18246C860 Slot: 3
	public override string ToString() { }

	// RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10
	public static ProfilerCategory get_Scripts() { }

	// RVA: 0x1717A10 Offset: 0x1716C10 VA: 0x181717A10
	public static ProfilerCategory get_Memory() { }

	// RVA: 0x246C9A0 Offset: 0x246BBA0 VA: 0x18246C9A0
	public static ushort op_Implicit(ProfilerCategory category) { }
}

// Namespace: Unity.Profiling
public enum ProfilerCategoryColor // TypeDefIndex: 13862
{
	// Fields
	public ushort value__; // 0x0
	public const ProfilerCategoryColor Render = 0;
	public const ProfilerCategoryColor Scripts = 1;
	public const ProfilerCategoryColor BurstJobs = 2;
	public const ProfilerCategoryColor Other = 3;
	public const ProfilerCategoryColor Physics = 4;
	public const ProfilerCategoryColor Animation = 5;
	public const ProfilerCategoryColor Audio = 6;
	public const ProfilerCategoryColor AudioJob = 7;
	public const ProfilerCategoryColor AudioUpdateJob = 8;
	public const ProfilerCategoryColor Lighting = 9;
	public const ProfilerCategoryColor GC = 10;
	public const ProfilerCategoryColor VSync = 11;
	public const ProfilerCategoryColor Memory = 12;
	public const ProfilerCategoryColor Internal = 13;
	public const ProfilerCategoryColor UI = 14;
	public const ProfilerCategoryColor Build = 15;
	public const ProfilerCategoryColor Input = 16;
}

// Namespace: 
[IgnoredByDeepProfiler]
[UsedByNativeCode]
public struct ProfilerMarker.AutoScope : IDisposable // TypeDefIndex: 13863
{
	// Fields
	[NativeDisableUnsafePtrRestriction]
	internal readonly IntPtr m_Ptr; // 0x0

	// Methods

	// RVA: 0x244CB10 Offset: 0x244BD10 VA: 0x18244CB10
	internal void .ctor(IntPtr markerPtr) { }

	// RVA: 0x244CAC0 Offset: 0x244BCC0 VA: 0x18244CAC0 Slot: 4
	public void Dispose() { }
}

// Namespace: Unity.Profiling
[UsedByNativeCode]
[IgnoredByDeepProfiler]
public struct ProfilerMarker // TypeDefIndex: 13864
{
	// Fields
	[NativeDisableUnsafePtrRestriction]
	internal readonly IntPtr m_Ptr; // 0x0

	// Methods

	// RVA: 0x246CA60 Offset: 0x246BC60 VA: 0x18246CA60
	public void .ctor(string name) { }

	// RVA: 0x246CA00 Offset: 0x246BC00 VA: 0x18246CA00
	public void .ctor(ProfilerCategory category, string name) { }

	[Pure]
	// RVA: 0x246C9B0 Offset: 0x246BBB0 VA: 0x18246C9B0
	public ProfilerMarker.AutoScope Auto() { }
}

// Namespace: Unity.Profiling
[Flags]
public enum ProfilerCounterOptions // TypeDefIndex: 13865
{
	// Fields
	public ushort value__; // 0x0
	public const ProfilerCounterOptions None = 0;
	public const ProfilerCounterOptions FlushOnEndOfFrame = 2;
	public const ProfilerCounterOptions ResetToZeroOnFlush = 4;
}

// Namespace: Unity.Profiling
[Flags]
public enum ProfilerRecorderOptions // TypeDefIndex: 13866
{
	// Fields
	public int value__; // 0x0
	public const ProfilerRecorderOptions None = 0;
	public const ProfilerRecorderOptions StartImmediately = 1;
	public const ProfilerRecorderOptions KeepAliveDuringDomainReload = 2;
	public const ProfilerRecorderOptions CollectOnlyOnCurrentThread = 4;
	public const ProfilerRecorderOptions WrapAroundWhenCapacityReached = 8;
	public const ProfilerRecorderOptions SumAllSamplesInFrame = 16;
	public const ProfilerRecorderOptions GpuRecorder = 64;
	public const ProfilerRecorderOptions Default = 24;
}

// Namespace: 
internal enum ProfilerRecorder.ControlOptions // TypeDefIndex: 13867
{
	// Fields
	public int value__; // 0x0
	public const ProfilerRecorder.ControlOptions Start = 0;
	public const ProfilerRecorder.ControlOptions Stop = 1;
	public const ProfilerRecorder.ControlOptions Reset = 2;
	public const ProfilerRecorder.ControlOptions Release = 4;
	public const ProfilerRecorder.ControlOptions SetFilterToCurrentThread = 5;
	public const ProfilerRecorder.ControlOptions SetToCollectFromAllThreads = 6;
}

// Namespace: Unity.Profiling
[DebuggerTypeProxy(typeof(ProfilerRecorderDebugView))]
[UsedByNativeCode]
[NativeHeader("Runtime/Profiler/ScriptBindings/ProfilerRecorder.bindings.h")]
[DebuggerDisplay("Count = {Count}")]
public struct ProfilerRecorder : IDisposable // TypeDefIndex: 13868
{
	// Fields
	internal ulong handle; // 0x0
	internal const ProfilerRecorderOptions SharedRecorder = 128;

	// Properties
	public long LastValue { get; }
	public bool IsRunning { get; }

	// Methods

	// RVA: 0x246D090 Offset: 0x246C290 VA: 0x18246D090
	public void .ctor(ProfilerCategory category, char* statName, int statNameLen, int capacity = 1, ProfilerRecorderOptions options = 24) { }

	// RVA: 0x246CFB0 Offset: 0x246C1B0 VA: 0x18246CFB0
	public static ProfilerRecorder StartNew(ProfilerCategory category, string statName, int capacity = 1, ProfilerRecorderOptions options = 24) { }

	// RVA: 0x246D1D0 Offset: 0x246C3D0 VA: 0x18246D1D0
	public long get_LastValue() { }

	// RVA: 0x246D140 Offset: 0x246C340 VA: 0x18246D140
	public bool get_IsRunning() { }

	[NativeMethod(IsThreadSafe = True, ThrowsException = True)]
	// RVA: 0x246CE00 Offset: 0x246C000 VA: 0x18246CE00
	private static ProfilerRecorder Create(ProfilerRecorderHandle statHandle, int maxSampleCount, ProfilerRecorderOptions options) { }

	[NativeMethod(IsThreadSafe = True)]
	// RVA: 0x246CD60 Offset: 0x246BF60 VA: 0x18246CD60
	private static void Control(ProfilerRecorder handle, ProfilerRecorder.ControlOptions options) { }

	[NativeMethod(IsThreadSafe = True)]
	// RVA: 0x246CEF0 Offset: 0x246C0F0 VA: 0x18246CEF0
	private static long GetLastValue(ProfilerRecorder handle) { }

	[NativeMethod(IsThreadSafe = True)]
	// RVA: 0x246CF70 Offset: 0x246C170 VA: 0x18246CF70
	private static bool GetRunning(ProfilerRecorder handle) { }

	// RVA: 0x246CE60 Offset: 0x246C060 VA: 0x18246CE60 Slot: 4
	public void Dispose() { }

	[BurstDiscard]
	// RVA: 0x246CCB0 Offset: 0x246BEB0 VA: 0x18246CCB0
	private void CheckInitializedAndThrow() { }

	// RVA: 0x246CDA0 Offset: 0x246BFA0 VA: 0x18246CDA0
	private static void Create_Injected(ref ProfilerRecorderHandle statHandle, int maxSampleCount, ProfilerRecorderOptions options, out ProfilerRecorder ret) { }

	// RVA: 0x246CD20 Offset: 0x246BF20 VA: 0x18246CD20
	private static void Control_Injected(ref ProfilerRecorder handle, ProfilerRecorder.ControlOptions options) { }

	// RVA: 0x246CEB0 Offset: 0x246C0B0 VA: 0x18246CEB0
	private static long GetLastValue_Injected(ref ProfilerRecorder handle) { }

	// RVA: 0x246CF30 Offset: 0x246C130 VA: 0x18246CF30
	private static bool GetRunning_Injected(ref ProfilerRecorder handle) { }
}

// Namespace: Unity.Profiling
internal sealed class ProfilerRecorderDebugView // TypeDefIndex: 13869
{}

// Namespace: Unity.Profiling
public struct DebugScreenCapture // TypeDefIndex: 13870
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private NativeArray<byte> <RawImageDataReference>k__BackingField; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private TextureFormat <ImageFormat>k__BackingField; // 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private int <Width>k__BackingField; // 0x14
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private int <Height>k__BackingField; // 0x18

	// Properties
	public NativeArray<byte> RawImageDataReference { set; }
	public TextureFormat ImageFormat { set; }
	public int Width { set; }
	public int Height { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4354B0 Offset: 0x4346B0 VA: 0x1804354B0
	public void set_RawImageDataReference(NativeArray<byte> value) { }

	[CompilerGenerated]
	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_ImageFormat(TextureFormat value) { }

	[CompilerGenerated]
	// RVA: 0x426530 Offset: 0x425730 VA: 0x180426530
	public void set_Width(int value) { }

	[CompilerGenerated]
	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	public void set_Height(int value) { }
}

// Namespace: Unity.Profiling.LowLevel
[Flags]
public enum MarkerFlags // TypeDefIndex: 13871
{
	// Fields
	public ushort value__; // 0x0
	public const MarkerFlags Default = 0;
	public const MarkerFlags Script = 2;
	public const MarkerFlags ScriptInvoke = 32;
	public const MarkerFlags ScriptDeepProfiler = 64;
	public const MarkerFlags AvailabilityEditor = 4;
	public const MarkerFlags AvailabilityNonDevelopment = 8;
	public const MarkerFlags Warning = 16;
	public const MarkerFlags Counter = 128;
	public const MarkerFlags SampleGPU = 256;
}

// Namespace: Unity.Profiling.LowLevel.Unsafe
[UsedByNativeCode]
[IsReadOnly]
public struct ProfilerRecorderHandle // TypeDefIndex: 13872
{
	// Fields
	internal readonly ulong handle; // 0x0

	// Methods

	[NativeMethod(IsThreadSafe = True)]
	// RVA: 0x246CBF0 Offset: 0x246BDF0 VA: 0x18246CBF0
	internal static ProfilerRecorderHandle GetByName__Unmanaged(ProfilerCategory category, byte* name, int nameLen) { }

	// RVA: 0x246CC50 Offset: 0x246BE50 VA: 0x18246CC50
	internal static ProfilerRecorderHandle GetByName(ProfilerCategory category, char* name, int nameLen) { }

	[NativeMethod(IsThreadSafe = True)]
	// RVA: 0x246CB20 Offset: 0x246BD20 VA: 0x18246CB20
	private static ProfilerRecorderHandle GetByName_Unsafe(ProfilerCategory category, char* name, int nameLen) { }

	// RVA: 0x246CB80 Offset: 0x246BD80 VA: 0x18246CB80
	private static void GetByName__Unmanaged_Injected(ref ProfilerCategory category, byte* name, int nameLen, out ProfilerRecorderHandle ret) { }

	// RVA: 0x246CAB0 Offset: 0x246BCB0 VA: 0x18246CAB0
	private static void GetByName_Unsafe_Injected(ref ProfilerCategory category, char* name, int nameLen, out ProfilerRecorderHandle ret) { }
}

// Namespace: Unity.Profiling.LowLevel.Unsafe
[IsReadOnly]
public struct ProfilerCategoryDescription // TypeDefIndex: 13873
{
	// Fields
	public readonly ushort Id; // 0x0
	public readonly ushort Flags; // 0x2
	public readonly Color32 Color; // 0x4
	private readonly int reserved0; // 0x8
	public readonly int NameUtf8Len; // 0xC
	public readonly byte* NameUtf8; // 0x10
}

// Namespace: Unity.Profiling.LowLevel.Unsafe
[UsedByNativeCode]
[IgnoredByDeepProfiler]
[NativeHeader("Runtime/Profiler/ScriptBindings/ProfilerUnsafeUtility.bindings.h")]
public static class ProfilerUnsafeUtility // TypeDefIndex: 13874
{
	// Methods

	[ThreadSafe]
	// RVA: 0x246D2A0 Offset: 0x246C4A0 VA: 0x18246D2A0
	internal static ushort CreateCategory__Unmanaged(byte* name, int nameLen, ProfilerCategoryColor colorIndex) { }

	[ThreadSafe]
	// RVA: 0x246D520 Offset: 0x246C720 VA: 0x18246D520
	public static ProfilerCategoryDescription GetCategoryDescription(ushort categoryId) { }

	[ThreadSafe]
	// RVA: 0x246D420 Offset: 0x246C620 VA: 0x18246D420
	public static IntPtr CreateMarker(string name, ushort categoryId, MarkerFlags flags, int metadataCount) { }

	[ThreadSafe]
	// RVA: 0x246D3B0 Offset: 0x246C5B0 VA: 0x18246D3B0
	internal static IntPtr CreateMarker__Unmanaged(byte* name, int nameLen, ushort categoryId, MarkerFlags flags, int metadataCount) { }

	[ThreadSafe]
	// RVA: 0x246D580 Offset: 0x246C780 VA: 0x18246D580
	internal static void SetMarkerMetadata__Unmanaged(IntPtr markerPtr, int index, byte* name, int nameLen, byte type, byte unit) { }

	[ThreadSafe]
	// RVA: 0x246D260 Offset: 0x246C460 VA: 0x18246D260
	public static void BeginSample(IntPtr markerPtr) { }

	[ThreadSafe]
	// RVA: 0x246D490 Offset: 0x246C690 VA: 0x18246D490
	public static void EndSample(IntPtr markerPtr) { }

	[ThreadSafe]
	// RVA: 0x246D300 Offset: 0x246C500 VA: 0x18246D300
	internal static void* CreateCounterValue__Unmanaged(out IntPtr counterPtr, byte* name, int nameLen, ushort categoryId, MarkerFlags flags, byte dataType, byte dataUnit, int dataSize, ProfilerCounterOptions counterOptions) { }

	// RVA: 0x246D600 Offset: 0x246C800 VA: 0x18246D600
	internal static string Utf8ToString(byte* chars, int charsLen) { }

	// RVA: 0x246D4D0 Offset: 0x246C6D0 VA: 0x18246D4D0
	private static void GetCategoryDescription_Injected(ushort categoryId, out ProfilerCategoryDescription ret) { }
}

// Namespace: Unity.Profiling.Memory
public class MemorySnapshotMetadata // TypeDefIndex: 13875
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private string <Description>k__BackingField; // 0x10
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private byte[] <Data>k__BackingField; // 0x18

	// Properties
	public string Description { get; set; }
	internal byte[] Data { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public string get_Description() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_Description(string value) { }

	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	internal byte[] get_Data() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: Unity.Profiling.Memory
[NativeHeader("Modules/Profiler/Runtime/MemorySnapshotManager.h")]
public static class MemoryProfiler // TypeDefIndex: 13876
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action<string, bool> m_SnapshotFinished; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action<string, bool, DebugScreenCapture> m_SaveScreenshotToDisk; // 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action<MemorySnapshotMetadata> CreatingMetadata; // 0x10

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x2462170 Offset: 0x2461370 VA: 0x182462170
	private static byte[] PrepareMetadata() { }

	// RVA: 0x24625A0 Offset: 0x24617A0 VA: 0x1824625A0
	internal static int WriteIntToByteArray(byte[] array, int offset, int value) { }

	// RVA: 0x2462620 Offset: 0x2461820 VA: 0x182462620
	internal static int WriteStringToByteArray(byte[] array, int offset, string value) { }

	[RequiredByNativeCode]
	// RVA: 0x2462100 Offset: 0x2461300 VA: 0x182462100
	private static void FinalizeSnapshot(string path, bool result) { }

	[RequiredByNativeCode]
	// RVA: 0x2462480 Offset: 0x2461680 VA: 0x182462480
	private static void SaveScreenshotToDisk(string path, bool result, IntPtr pixelsPtr, int pixelsCount, TextureFormat format, int width, int height) { }
}

// Namespace: Unity.IO.LowLevel.Unsafe
[RequiredByNativeCode]
public enum FileState // TypeDefIndex: 13877
{
	// Fields
	public int value__; // 0x0
	public const FileState Absent = 0;
	public const FileState Exists = 1;
}

// Namespace: Unity.IO.LowLevel.Unsafe
public enum AssetLoadingSubsystem // TypeDefIndex: 13878
{
	// Fields
	public int value__; // 0x0
	public const AssetLoadingSubsystem Other = 0;
	public const AssetLoadingSubsystem Texture = 1;
	public const AssetLoadingSubsystem VirtualTexture = 2;
	public const AssetLoadingSubsystem Mesh = 3;
	public const AssetLoadingSubsystem Audio = 4;
	public const AssetLoadingSubsystem Scripts = 5;
	public const AssetLoadingSubsystem EntitiesScene = 6;
	public const AssetLoadingSubsystem EntitiesStreamBinaryReader = 7;
	public const AssetLoadingSubsystem FileInfo = 8;
	public const AssetLoadingSubsystem ContentLoading = 9;
}

// Namespace: Unity.IO.LowLevel.Unsafe
[RequiredByNativeCode]
public enum Priority // TypeDefIndex: 13879
{
	// Fields
	public int value__; // 0x0
	public const Priority PriorityLow = 0;
	public const Priority PriorityHigh = 1;
}

// Namespace: Unity.IO.LowLevel.Unsafe
[NativeHeader("Runtime/File/AsyncReadManagerMetrics.h")]
public enum ProcessingState // TypeDefIndex: 13880
{
	// Fields
	public int value__; // 0x0
	public const ProcessingState Unknown = 0;
	public const ProcessingState InQueue = 1;
	public const ProcessingState Reading = 2;
	public const ProcessingState Completed = 3;
	public const ProcessingState Failed = 4;
	public const ProcessingState Canceled = 5;
}

// Namespace: Unity.IO.LowLevel.Unsafe
public enum FileReadType // TypeDefIndex: 13881
{
	// Fields
	public int value__; // 0x0
	public const FileReadType Sync = 0;
	public const FileReadType Async = 1;
}

// Namespace: Unity.IO.LowLevel.Unsafe
[NativeConditional("ENABLE_PROFILER")]
[RequiredByNativeCode]
public struct AsyncReadManagerRequestMetric // TypeDefIndex: 13882
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly string <AssetName>k__BackingField; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly string <FileName>k__BackingField; // 0x8
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly ulong <OffsetBytes>k__BackingField; // 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly ulong <SizeBytes>k__BackingField; // 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly ulong <AssetTypeId>k__BackingField; // 0x20
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly ulong <CurrentBytesRead>k__BackingField; // 0x28
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly uint <BatchReadCount>k__BackingField; // 0x30
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly bool <IsBatchRead>k__BackingField; // 0x34
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly ProcessingState <State>k__BackingField; // 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly FileReadType <ReadType>k__BackingField; // 0x3C
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly Priority <PriorityLevel>k__BackingField; // 0x40
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly AssetLoadingSubsystem <Subsystem>k__BackingField; // 0x44
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly double <RequestTimeMicroseconds>k__BackingField; // 0x48
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly double <TimeInQueueMicroseconds>k__BackingField; // 0x50
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly double <TotalTimeMicroseconds>k__BackingField; // 0x58
}

// Namespace: Unity.IO.LowLevel.Unsafe
[NativeConditional("ENABLE_PROFILER")]
[RequiredByNativeCode]
[NativeAsStruct]
public class AsyncReadManagerMetricsFilters // TypeDefIndex: 13883
{
	// Fields
	[NativeName("typeIDs")]
	internal ulong[] TypeIDs; // 0x10
	[NativeName("states")]
	internal ProcessingState[] States; // 0x18
	[NativeName("readTypes")]
	internal FileReadType[] ReadTypes; // 0x20
	[NativeName("priorityLevels")]
	internal Priority[] PriorityLevels; // 0x28
	[NativeName("subsystems")]
	internal AssetLoadingSubsystem[] Subsystems; // 0x30
}

// Namespace: Unity.IO.Archive
[RequiredByNativeCode]
public enum ArchiveStatus // TypeDefIndex: 13884
{
	// Fields
	public int value__; // 0x0
	public const ArchiveStatus InProgress = 0;
	public const ArchiveStatus Complete = 1;
	public const ArchiveStatus Failed = 2;
}

// Namespace: Unity.IO.Archive
[NativeHeader("Runtime/VirtualFileSystem/ArchiveFileSystem/ArchiveFileHandle.h")]
[RequiredByNativeCode]
public struct ArchiveFileInfo // TypeDefIndex: 13885
{
	// Fields
	public string Filename; // 0x0
	public ulong FileSize; // 0x8
}

// Namespace: Unity.IO.Archive
[RequiredByNativeCode]
[NativeHeader("Runtime/VirtualFileSystem/ArchiveFileSystem/ArchiveFileHandle.h")]
public struct ArchiveHandle // TypeDefIndex: 13886
{
	// Fields
	internal ulong Handle; // 0x0
}

// Namespace: Unity.IO.Archive
[NativeHeader("Runtime/VirtualFileSystem/ArchiveFileSystem/ArchiveFileHandle.h")]
[StaticAccessor("GetManagedArchiveSystem()", 0)]
[RequiredByNativeCode]
public static class ArchiveFileInterface // TypeDefIndex: 13887
{}

// Namespace: Unity.Collections
[RequiredByNativeCode]
[Usage(10496)]
public sealed class ReadOnlyAttribute : Attribute // TypeDefIndex: 13888
{}

// Namespace: Unity.Collections
[Usage(10496)]
[RequiredByNativeCode]
public sealed class WriteOnlyAttribute : Attribute // TypeDefIndex: 13889
{}

// Namespace: Unity.Collections
[RequiredByNativeCode]
[Usage(256)]
public sealed class DeallocateOnJobCompletionAttribute : Attribute // TypeDefIndex: 13890
{}

// Namespace: Unity.Collections
[Usage(256)]
[RequiredByNativeCode]
public sealed class NativeFixedLengthAttribute : Attribute // TypeDefIndex: 13891
{}

// Namespace: Unity.Collections
[Usage(256)]
[RequiredByNativeCode]
public sealed class NativeMatchesParallelForLengthAttribute : Attribute // TypeDefIndex: 13892
{}

// Namespace: Unity.Collections
[Usage(256)]
[RequiredByNativeCode]
public sealed class NativeDisableParallelForRestrictionAttribute : Attribute // TypeDefIndex: 13893
{}

// Namespace: Unity.Collections
[UsedByNativeCode]
public enum Allocator // TypeDefIndex: 13894
{
	// Fields
	public int value__; // 0x0
	public const Allocator Invalid = 0;
	public const Allocator None = 1;
	public const Allocator Temp = 2;
	public const Allocator TempJob = 3;
	public const Allocator Persistent = 4;
	public const Allocator AudioKernel = 5;
	public const Allocator FirstUserIndex = 64;
}

// Namespace: Unity.Collections
[UsedByNativeCode]
internal enum LeakCategory // TypeDefIndex: 13895
{
	// Fields
	public int value__; // 0x0
	public const LeakCategory Invalid = 0;
	public const LeakCategory Malloc = 1;
	public const LeakCategory TempJob = 2;
	public const LeakCategory Persistent = 3;
	public const LeakCategory LightProbesQuery = 4;
	public const LeakCategory NativeTest = 5;
	public const LeakCategory MeshDataArray = 6;
	public const LeakCategory TransformAccessArray = 7;
	public const LeakCategory NavMeshQuery = 8;
}

// Namespace: Unity.Collections
public enum NativeArrayOptions // TypeDefIndex: 13896
{
	// Fields
	public int value__; // 0x0
	public const NativeArrayOptions UninitializedMemory = 0;
	public const NativeArrayOptions ClearMemory = 1;
}

// Namespace: 
[ExcludeFromDocs]
public struct NativeArray.Enumerator<T> : IEnumerator<T>, IEnumerator, IDisposable // TypeDefIndex: 13897
{
	// Fields
	private NativeArray<T> m_Array; // 0x0
	private int m_Index; // 0x0
	private T value; // 0x0

	// Properties
	public T Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(ref NativeArray<T> array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10EAA40 Offset: 0x10E9C40 VA: 0x1810EAA40
	|-NativeArray.Enumerator<BatchCullingOutputDrawCommands>..ctor
	|
	|-RVA: 0x10EB670 Offset: 0x10EA870 VA: 0x1810EB670
	|-NativeArray.Enumerator<BoneWeight1>..ctor
	|
	|-RVA: 0x10EB770 Offset: 0x10EA970 VA: 0x1810EB770
	|-NativeArray.Enumerator<byte>..ctor
	|
	|-RVA: 0x10EB0B0 Offset: 0x10EA2B0 VA: 0x1810EB0B0
	|-NativeArray.Enumerator<Color>..ctor
	|-NativeArray.Enumerator<DrawBufferRange>..ctor
	|-NativeArray.Enumerator<Plane>..ctor
	|-NativeArray.Enumerator<Quaternion>..ctor
	|-NativeArray.Enumerator<Vector4>..ctor
	|-NativeArray.Enumerator<VertexAttributeDescriptor>..ctor
	|
	|-RVA: 0x10EABC0 Offset: 0x10E9DC0 VA: 0x1810EABC0
	|-NativeArray.Enumerator<Color32>..ctor
	|-NativeArray.Enumerator<int>..ctor
	|
	|-RVA: 0x10EAA20 Offset: 0x10E9C20 VA: 0x1810EAA20
	|-NativeArray.Enumerator<ContactPairHeader>..ctor
	|
	|-RVA: 0x10F0190 Offset: 0x10EF390 VA: 0x1810F0190
	|-NativeArray.Enumerator<ConvertMeshJobData>..ctor
	|
	|-RVA: 0x10F0130 Offset: 0x10EF330 VA: 0x1810F0130
	|-NativeArray.Enumerator<CopyClosingMeshJobData>..ctor
	|
	|-RVA: 0x10F0090 Offset: 0x10EF290 VA: 0x1810F0090
	|-NativeArray.Enumerator<CullingSplit>..ctor
	|-NativeArray.Enumerator<LightDataGI>..ctor
	|-NativeArray.Enumerator<TileData>..ctor
	|
	|-RVA: 0x10F03A0 Offset: 0x10EF5A0 VA: 0x1810F03A0
	|-NativeArray.Enumerator<GfxUpdateBufferRange>..ctor
	|-NativeArray.Enumerator<JobHandle>..ctor
	|
	|-RVA: 0x10F0020 Offset: 0x10EF220 VA: 0x1810F0020
	|-NativeArray.Enumerator<Matrix4x4>..ctor
	|-NativeArray.Enumerator<Vertex>..ctor
	|
	|-RVA: 0x10F0320 Offset: 0x10EF520 VA: 0x1810F0320
	|-NativeArray.Enumerator<ModifiableContactPair>..ctor
	|
	|-RVA: 0x10F0050 Offset: 0x10EF250 VA: 0x1810F0050
	|-NativeArray.Enumerator<NudgeJobData>..ctor
	|
	|-RVA: 0x11106B0 Offset: 0x110F8B0 VA: 0x1811106B0
	|-NativeArray.Enumerator<Transform3x4>..ctor
	|
	|-RVA: 0x1110B90 Offset: 0x110FD90 VA: 0x181110B90
	|-NativeArray.Enumerator<ushort>..ctor
	|
	|-RVA: 0x1110030 Offset: 0x110F230 VA: 0x181110030
	|-NativeArray.Enumerator<Vector3>..ctor
	|-NativeArray.Enumerator<Vector3Int>..ctor
	|
	|-RVA: 0x1110370 Offset: 0x110F570 VA: 0x181110370
	|-NativeArray.Enumerator<__Il2CppFullySharedGenericStructType>..ctor
	|
	|-RVA: 0x1116DB0 Offset: 0x1115FB0 VA: 0x181116DB0
	|-NativeArray.Enumerator<ParticleSystem.Particle>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	|-NativeArray.Enumerator<BatchCullingOutputDrawCommands>.Dispose
	|-NativeArray.Enumerator<BoneWeight1>.Dispose
	|-NativeArray.Enumerator<byte>.Dispose
	|-NativeArray.Enumerator<Color>.Dispose
	|-NativeArray.Enumerator<Color32>.Dispose
	|-NativeArray.Enumerator<ContactPairHeader>.Dispose
	|-NativeArray.Enumerator<ConvertMeshJobData>.Dispose
	|-NativeArray.Enumerator<CopyClosingMeshJobData>.Dispose
	|-NativeArray.Enumerator<CullingSplit>.Dispose
	|-NativeArray.Enumerator<DrawBufferRange>.Dispose
	|-NativeArray.Enumerator<GfxUpdateBufferRange>.Dispose
	|-NativeArray.Enumerator<int>.Dispose
	|-NativeArray.Enumerator<JobHandle>.Dispose
	|-NativeArray.Enumerator<LightDataGI>.Dispose
	|-NativeArray.Enumerator<Matrix4x4>.Dispose
	|-NativeArray.Enumerator<ModifiableContactPair>.Dispose
	|-NativeArray.Enumerator<NudgeJobData>.Dispose
	|-NativeArray.Enumerator<Plane>.Dispose
	|-NativeArray.Enumerator<Quaternion>.Dispose
	|-NativeArray.Enumerator<TileData>.Dispose
	|-NativeArray.Enumerator<Transform3x4>.Dispose
	|-NativeArray.Enumerator<ushort>.Dispose
	|-NativeArray.Enumerator<Vector3>.Dispose
	|-NativeArray.Enumerator<Vector3Int>.Dispose
	|-NativeArray.Enumerator<Vector4>.Dispose
	|-NativeArray.Enumerator<Vertex>.Dispose
	|-NativeArray.Enumerator<VertexAttributeDescriptor>.Dispose
	|-NativeArray.Enumerator<__Il2CppFullySharedGenericStructType>.Dispose
	|-NativeArray.Enumerator<ParticleSystem.Particle>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10E6900 Offset: 0x10E5B00 VA: 0x1810E6900
	|-NativeArray.Enumerator<BatchCullingOutputDrawCommands>.MoveNext
	|
	|-RVA: 0x10E6170 Offset: 0x10E5370 VA: 0x1810E6170
	|-NativeArray.Enumerator<BoneWeight1>.MoveNext
	|
	|-RVA: 0x10E6380 Offset: 0x10E5580 VA: 0x1810E6380
	|-NativeArray.Enumerator<byte>.MoveNext
	|
	|-RVA: 0x10E6D20 Offset: 0x10E5F20 VA: 0x1810E6D20
	|-NativeArray.Enumerator<Color>.MoveNext
	|-NativeArray.Enumerator<DrawBufferRange>.MoveNext
	|-NativeArray.Enumerator<Plane>.MoveNext
	|-NativeArray.Enumerator<Quaternion>.MoveNext
	|-NativeArray.Enumerator<Vector4>.MoveNext
	|-NativeArray.Enumerator<VertexAttributeDescriptor>.MoveNext
	|
	|-RVA: 0x10E67D0 Offset: 0x10E59D0 VA: 0x1810E67D0
	|-NativeArray.Enumerator<Color32>.MoveNext
	|-NativeArray.Enumerator<int>.MoveNext
	|
	|-RVA: 0x10E79A0 Offset: 0x10E6BA0 VA: 0x1810E79A0
	|-NativeArray.Enumerator<ContactPairHeader>.MoveNext
	|
	|-RVA: 0x10ECEB0 Offset: 0x10EC0B0 VA: 0x1810ECEB0
	|-NativeArray.Enumerator<ConvertMeshJobData>.MoveNext
	|
	|-RVA: 0x10ED1B0 Offset: 0x10EC3B0 VA: 0x1810ED1B0
	|-NativeArray.Enumerator<CopyClosingMeshJobData>.MoveNext
	|
	|-RVA: 0x10EC3D0 Offset: 0x10EB5D0 VA: 0x1810EC3D0
	|-NativeArray.Enumerator<CullingSplit>.MoveNext
	|-NativeArray.Enumerator<LightDataGI>.MoveNext
	|-NativeArray.Enumerator<TileData>.MoveNext
	|
	|-RVA: 0x10EC650 Offset: 0x10EB850 VA: 0x1810EC650
	|-NativeArray.Enumerator<GfxUpdateBufferRange>.MoveNext
	|-NativeArray.Enumerator<JobHandle>.MoveNext
	|
	|-RVA: 0x10ECCD0 Offset: 0x10EBED0 VA: 0x1810ECCD0
	|-NativeArray.Enumerator<Matrix4x4>.MoveNext
	|-NativeArray.Enumerator<Vertex>.MoveNext
	|
	|-RVA: 0x10ED350 Offset: 0x10EC550 VA: 0x1810ED350
	|-NativeArray.Enumerator<ModifiableContactPair>.MoveNext
	|
	|-RVA: 0x10ECDC0 Offset: 0x10EBFC0 VA: 0x1810ECDC0
	|-NativeArray.Enumerator<NudgeJobData>.MoveNext
	|
	|-RVA: 0x1109EE0 Offset: 0x11090E0 VA: 0x181109EE0
	|-NativeArray.Enumerator<Transform3x4>.MoveNext
	|
	|-RVA: 0x110AC70 Offset: 0x1109E70 VA: 0x18110AC70
	|-NativeArray.Enumerator<ushort>.MoveNext
	|
	|-RVA: 0x1109720 Offset: 0x1108920 VA: 0x181109720
	|-NativeArray.Enumerator<Vector3>.MoveNext
	|-NativeArray.Enumerator<Vector3Int>.MoveNext
	|
	|-RVA: 0x11066E0 Offset: 0x11058E0 VA: 0x1811066E0
	|-NativeArray.Enumerator<__Il2CppFullySharedGenericStructType>.MoveNext
	|
	|-RVA: 0x1112770 Offset: 0x1111970 VA: 0x181112770
	|-NativeArray.Enumerator<ParticleSystem.Particle>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10E8670 Offset: 0x10E7870 VA: 0x1810E8670
	|-NativeArray.Enumerator<BatchCullingOutputDrawCommands>.Reset
	|-NativeArray.Enumerator<BoneWeight1>.Reset
	|-NativeArray.Enumerator<byte>.Reset
	|-NativeArray.Enumerator<Color>.Reset
	|-NativeArray.Enumerator<Color32>.Reset
	|-NativeArray.Enumerator<ContactPairHeader>.Reset
	|-NativeArray.Enumerator<ConvertMeshJobData>.Reset
	|-NativeArray.Enumerator<CopyClosingMeshJobData>.Reset
	|-NativeArray.Enumerator<CullingSplit>.Reset
	|-NativeArray.Enumerator<DrawBufferRange>.Reset
	|-NativeArray.Enumerator<GfxUpdateBufferRange>.Reset
	|-NativeArray.Enumerator<int>.Reset
	|-NativeArray.Enumerator<JobHandle>.Reset
	|-NativeArray.Enumerator<LightDataGI>.Reset
	|-NativeArray.Enumerator<Matrix4x4>.Reset
	|-NativeArray.Enumerator<ModifiableContactPair>.Reset
	|-NativeArray.Enumerator<NudgeJobData>.Reset
	|-NativeArray.Enumerator<Plane>.Reset
	|-NativeArray.Enumerator<Quaternion>.Reset
	|-NativeArray.Enumerator<TileData>.Reset
	|-NativeArray.Enumerator<Transform3x4>.Reset
	|-NativeArray.Enumerator<ushort>.Reset
	|-NativeArray.Enumerator<Vector3>.Reset
	|-NativeArray.Enumerator<Vector3Int>.Reset
	|-NativeArray.Enumerator<Vector4>.Reset
	|-NativeArray.Enumerator<Vertex>.Reset
	|-NativeArray.Enumerator<VertexAttributeDescriptor>.Reset
	|-NativeArray.Enumerator<ParticleSystem.Particle>.Reset
	|
	|-RVA: 0x110BE20 Offset: 0x110B020 VA: 0x18110BE20
	|-NativeArray.Enumerator<__Il2CppFullySharedGenericStructType>.Reset
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10EBDD0 Offset: 0x10EAFD0 VA: 0x1810EBDD0
	|-NativeArray.Enumerator<BatchCullingOutputDrawCommands>.get_Current
	|
	|-RVA: 0x10EBEE0 Offset: 0x10EB0E0 VA: 0x1810EBEE0
	|-NativeArray.Enumerator<BoneWeight1>.get_Current
	|
	|-RVA: 0x10EBE00 Offset: 0x10EB000 VA: 0x1810EBE00
	|-NativeArray.Enumerator<byte>.get_Current
	|
	|-RVA: 0x10EC060 Offset: 0x10EB260 VA: 0x1810EC060
	|-NativeArray.Enumerator<Color>.get_Current
	|-NativeArray.Enumerator<DrawBufferRange>.get_Current
	|-NativeArray.Enumerator<Plane>.get_Current
	|-NativeArray.Enumerator<Quaternion>.get_Current
	|-NativeArray.Enumerator<Vector4>.get_Current
	|-NativeArray.Enumerator<VertexAttributeDescriptor>.get_Current
	|
	|-RVA: 0x10EBDC0 Offset: 0x10EAFC0 VA: 0x1810EBDC0
	|-NativeArray.Enumerator<Color32>.get_Current
	|-NativeArray.Enumerator<int>.get_Current
	|
	|-RVA: 0x10EBE10 Offset: 0x10EB010 VA: 0x1810EBE10
	|-NativeArray.Enumerator<ContactPairHeader>.get_Current
	|
	|-RVA: 0x10F1030 Offset: 0x10F0230 VA: 0x1810F1030
	|-NativeArray.Enumerator<ConvertMeshJobData>.get_Current
	|
	|-RVA: 0x10F12A0 Offset: 0x10F04A0 VA: 0x1810F12A0
	|-NativeArray.Enumerator<CopyClosingMeshJobData>.get_Current
	|
	|-RVA: 0x10F0D40 Offset: 0x10EFF40 VA: 0x1810F0D40
	|-NativeArray.Enumerator<CullingSplit>.get_Current
	|-NativeArray.Enumerator<LightDataGI>.get_Current
	|-NativeArray.Enumerator<TileData>.get_Current
	|
	|-RVA: 0x10F0D30 Offset: 0x10EFF30 VA: 0x1810F0D30
	|-NativeArray.Enumerator<GfxUpdateBufferRange>.get_Current
	|-NativeArray.Enumerator<JobHandle>.get_Current
	|
	|-RVA: 0x10F10E0 Offset: 0x10F02E0 VA: 0x1810F10E0
	|-NativeArray.Enumerator<Matrix4x4>.get_Current
	|-NativeArray.Enumerator<Vertex>.get_Current
	|
	|-RVA: 0x10F0DB0 Offset: 0x10EFFB0 VA: 0x1810F0DB0
	|-NativeArray.Enumerator<ModifiableContactPair>.get_Current
	|
	|-RVA: 0x10F13F0 Offset: 0x10F05F0 VA: 0x1810F13F0
	|-NativeArray.Enumerator<NudgeJobData>.get_Current
	|
	|-RVA: 0x1112030 Offset: 0x1111230 VA: 0x181112030
	|-NativeArray.Enumerator<Transform3x4>.get_Current
	|
	|-RVA: 0x1112230 Offset: 0x1111430 VA: 0x181112230
	|-NativeArray.Enumerator<ushort>.get_Current
	|
	|-RVA: 0x1111BF0 Offset: 0x1110DF0 VA: 0x181111BF0
	|-NativeArray.Enumerator<Vector3>.get_Current
	|-NativeArray.Enumerator<Vector3Int>.get_Current
	|
	|-RVA: 0x11122F0 Offset: 0x11114F0 VA: 0x1811122F0
	|-NativeArray.Enumerator<__Il2CppFullySharedGenericStructType>.get_Current
	|
	|-RVA: 0x1116EE0 Offset: 0x11160E0 VA: 0x181116EE0
	|-NativeArray.Enumerator<ParticleSystem.Particle>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10E9120 Offset: 0x10E8320 VA: 0x1810E9120
	|-NativeArray.Enumerator<BatchCullingOutputDrawCommands>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x10E97F0 Offset: 0x10E89F0 VA: 0x1810E97F0
	|-NativeArray.Enumerator<BoneWeight1>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x10E90C0 Offset: 0x10E82C0 VA: 0x1810E90C0
	|-NativeArray.Enumerator<byte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x10E9240 Offset: 0x10E8440 VA: 0x1810E9240
	|-NativeArray.Enumerator<Color>.System.Collections.IEnumerator.get_Current
	|-NativeArray.Enumerator<DrawBufferRange>.System.Collections.IEnumerator.get_Current
	|-NativeArray.Enumerator<Plane>.System.Collections.IEnumerator.get_Current
	|-NativeArray.Enumerator<Quaternion>.System.Collections.IEnumerator.get_Current
	|-NativeArray.Enumerator<Vector4>.System.Collections.IEnumerator.get_Current
	|-NativeArray.Enumerator<VertexAttributeDescriptor>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x10E9850 Offset: 0x10E8A50 VA: 0x1810E9850
	|-NativeArray.Enumerator<Color32>.System.Collections.IEnumerator.get_Current
	|-NativeArray.Enumerator<int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x10E9640 Offset: 0x10E8840 VA: 0x1810E9640
	|-NativeArray.Enumerator<ContactPairHeader>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x10EF7C0 Offset: 0x10EE9C0 VA: 0x1810EF7C0
	|-NativeArray.Enumerator<ConvertMeshJobData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x10EEC20 Offset: 0x10EDE20 VA: 0x1810EEC20
	|-NativeArray.Enumerator<CopyClosingMeshJobData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x10EF2D0 Offset: 0x10EE4D0 VA: 0x1810EF2D0
	|-NativeArray.Enumerator<CullingSplit>.System.Collections.IEnumerator.get_Current
	|-NativeArray.Enumerator<LightDataGI>.System.Collections.IEnumerator.get_Current
	|-NativeArray.Enumerator<TileData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x10EF440 Offset: 0x10EE640 VA: 0x1810EF440
	|-NativeArray.Enumerator<GfxUpdateBufferRange>.System.Collections.IEnumerator.get_Current
	|-NativeArray.Enumerator<JobHandle>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x10EED50 Offset: 0x10EDF50 VA: 0x1810EED50
	|-NativeArray.Enumerator<Matrix4x4>.System.Collections.IEnumerator.get_Current
	|-NativeArray.Enumerator<Vertex>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x10EECA0 Offset: 0x10EDEA0 VA: 0x1810EECA0
	|-NativeArray.Enumerator<ModifiableContactPair>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x10EF210 Offset: 0x10EE410 VA: 0x1810EF210
	|-NativeArray.Enumerator<NudgeJobData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x110D120 Offset: 0x110C320 VA: 0x18110D120
	|-NativeArray.Enumerator<Transform3x4>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x110D700 Offset: 0x110C900 VA: 0x18110D700
	|-NativeArray.Enumerator<ushort>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x110D9D0 Offset: 0x110CBD0 VA: 0x18110D9D0
	|-NativeArray.Enumerator<Vector3>.System.Collections.IEnumerator.get_Current
	|-NativeArray.Enumerator<Vector3Int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x110E130 Offset: 0x110D330 VA: 0x18110E130
	|-NativeArray.Enumerator<__Il2CppFullySharedGenericStructType>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1115650 Offset: 0x1114850 VA: 0x181115650
	|-NativeArray.Enumerator<ParticleSystem.Particle>.System.Collections.IEnumerator.get_Current
	*/
}

// Namespace: 
[ExcludeFromDocs]
public struct NativeArray.ReadOnly.Enumerator<T> : IEnumerator<T>, IEnumerator, IDisposable // TypeDefIndex: 13898
{
	// Fields
	private NativeArray.ReadOnly<T> m_Array; // 0x0
	private int m_Index; // 0x0
	private T value; // 0x0

	// Properties
	public T Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(in NativeArray.ReadOnly<T> array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10EAA40 Offset: 0x10E9C40 VA: 0x1810EAA40
	|-NativeArray.ReadOnly.Enumerator<BatchCullingOutputDrawCommands>..ctor
	|
	|-RVA: 0x10EB670 Offset: 0x10EA870 VA: 0x1810EB670
	|-NativeArray.ReadOnly.Enumerator<BoneWeight1>..ctor
	|
	|-RVA: 0x10EB770 Offset: 0x10EA970 VA: 0x1810EB770
	|-NativeArray.ReadOnly.Enumerator<byte>..ctor
	|
	|-RVA: 0x10EB0B0 Offset: 0x10EA2B0 VA: 0x1810EB0B0
	|-NativeArray.ReadOnly.Enumerator<Color>..ctor
	|-NativeArray.ReadOnly.Enumerator<DrawBufferRange>..ctor
	|-NativeArray.ReadOnly.Enumerator<Plane>..ctor
	|-NativeArray.ReadOnly.Enumerator<Quaternion>..ctor
	|-NativeArray.ReadOnly.Enumerator<Vector4>..ctor
	|-NativeArray.ReadOnly.Enumerator<VertexAttributeDescriptor>..ctor
	|
	|-RVA: 0x10EABC0 Offset: 0x10E9DC0 VA: 0x1810EABC0
	|-NativeArray.ReadOnly.Enumerator<Color32>..ctor
	|-NativeArray.ReadOnly.Enumerator<int>..ctor
	|
	|-RVA: 0x10EAA20 Offset: 0x10E9C20 VA: 0x1810EAA20
	|-NativeArray.ReadOnly.Enumerator<ContactPairHeader>..ctor
	|
	|-RVA: 0x10F0190 Offset: 0x10EF390 VA: 0x1810F0190
	|-NativeArray.ReadOnly.Enumerator<ConvertMeshJobData>..ctor
	|
	|-RVA: 0x10F0130 Offset: 0x10EF330 VA: 0x1810F0130
	|-NativeArray.ReadOnly.Enumerator<CopyClosingMeshJobData>..ctor
	|
	|-RVA: 0x10F0090 Offset: 0x10EF290 VA: 0x1810F0090
	|-NativeArray.ReadOnly.Enumerator<CullingSplit>..ctor
	|-NativeArray.ReadOnly.Enumerator<LightDataGI>..ctor
	|-NativeArray.ReadOnly.Enumerator<TileData>..ctor
	|
	|-RVA: 0x10F03A0 Offset: 0x10EF5A0 VA: 0x1810F03A0
	|-NativeArray.ReadOnly.Enumerator<GfxUpdateBufferRange>..ctor
	|-NativeArray.ReadOnly.Enumerator<JobHandle>..ctor
	|
	|-RVA: 0x10F0020 Offset: 0x10EF220 VA: 0x1810F0020
	|-NativeArray.ReadOnly.Enumerator<Matrix4x4>..ctor
	|-NativeArray.ReadOnly.Enumerator<Vertex>..ctor
	|
	|-RVA: 0x10F0320 Offset: 0x10EF520 VA: 0x1810F0320
	|-NativeArray.ReadOnly.Enumerator<ModifiableContactPair>..ctor
	|
	|-RVA: 0x10F0050 Offset: 0x10EF250 VA: 0x1810F0050
	|-NativeArray.ReadOnly.Enumerator<NudgeJobData>..ctor
	|
	|-RVA: 0x11106B0 Offset: 0x110F8B0 VA: 0x1811106B0
	|-NativeArray.ReadOnly.Enumerator<Transform3x4>..ctor
	|
	|-RVA: 0x1110B90 Offset: 0x110FD90 VA: 0x181110B90
	|-NativeArray.ReadOnly.Enumerator<ushort>..ctor
	|
	|-RVA: 0x1110030 Offset: 0x110F230 VA: 0x181110030
	|-NativeArray.ReadOnly.Enumerator<Vector3>..ctor
	|-NativeArray.ReadOnly.Enumerator<Vector3Int>..ctor
	|
	|-RVA: 0x1110370 Offset: 0x110F570 VA: 0x181110370
	|-NativeArray.ReadOnly.Enumerator<__Il2CppFullySharedGenericStructType>..ctor
	|
	|-RVA: 0x1116DB0 Offset: 0x1115FB0 VA: 0x181116DB0
	|-NativeArray.ReadOnly.Enumerator<ParticleSystem.Particle>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	|-NativeArray.ReadOnly.Enumerator<BatchCullingOutputDrawCommands>.Dispose
	|-NativeArray.ReadOnly.Enumerator<BoneWeight1>.Dispose
	|-NativeArray.ReadOnly.Enumerator<byte>.Dispose
	|-NativeArray.ReadOnly.Enumerator<Color>.Dispose
	|-NativeArray.ReadOnly.Enumerator<Color32>.Dispose
	|-NativeArray.ReadOnly.Enumerator<ContactPairHeader>.Dispose
	|-NativeArray.ReadOnly.Enumerator<ConvertMeshJobData>.Dispose
	|-NativeArray.ReadOnly.Enumerator<CopyClosingMeshJobData>.Dispose
	|-NativeArray.ReadOnly.Enumerator<CullingSplit>.Dispose
	|-NativeArray.ReadOnly.Enumerator<DrawBufferRange>.Dispose
	|-NativeArray.ReadOnly.Enumerator<GfxUpdateBufferRange>.Dispose
	|-NativeArray.ReadOnly.Enumerator<int>.Dispose
	|-NativeArray.ReadOnly.Enumerator<JobHandle>.Dispose
	|-NativeArray.ReadOnly.Enumerator<LightDataGI>.Dispose
	|-NativeArray.ReadOnly.Enumerator<Matrix4x4>.Dispose
	|-NativeArray.ReadOnly.Enumerator<ModifiableContactPair>.Dispose
	|-NativeArray.ReadOnly.Enumerator<NudgeJobData>.Dispose
	|-NativeArray.ReadOnly.Enumerator<Plane>.Dispose
	|-NativeArray.ReadOnly.Enumerator<Quaternion>.Dispose
	|-NativeArray.ReadOnly.Enumerator<TileData>.Dispose
	|-NativeArray.ReadOnly.Enumerator<Transform3x4>.Dispose
	|-NativeArray.ReadOnly.Enumerator<ushort>.Dispose
	|-NativeArray.ReadOnly.Enumerator<Vector3>.Dispose
	|-NativeArray.ReadOnly.Enumerator<Vector3Int>.Dispose
	|-NativeArray.ReadOnly.Enumerator<Vector4>.Dispose
	|-NativeArray.ReadOnly.Enumerator<Vertex>.Dispose
	|-NativeArray.ReadOnly.Enumerator<VertexAttributeDescriptor>.Dispose
	|-NativeArray.ReadOnly.Enumerator<__Il2CppFullySharedGenericStructType>.Dispose
	|-NativeArray.ReadOnly.Enumerator<ParticleSystem.Particle>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10E6900 Offset: 0x10E5B00 VA: 0x1810E6900
	|-NativeArray.ReadOnly.Enumerator<BatchCullingOutputDrawCommands>.MoveNext
	|
	|-RVA: 0x10E6170 Offset: 0x10E5370 VA: 0x1810E6170
	|-NativeArray.ReadOnly.Enumerator<BoneWeight1>.MoveNext
	|
	|-RVA: 0x10E6380 Offset: 0x10E5580 VA: 0x1810E6380
	|-NativeArray.ReadOnly.Enumerator<byte>.MoveNext
	|
	|-RVA: 0x10E6D20 Offset: 0x10E5F20 VA: 0x1810E6D20
	|-NativeArray.ReadOnly.Enumerator<Color>.MoveNext
	|-NativeArray.ReadOnly.Enumerator<DrawBufferRange>.MoveNext
	|-NativeArray.ReadOnly.Enumerator<Plane>.MoveNext
	|-NativeArray.ReadOnly.Enumerator<Quaternion>.MoveNext
	|-NativeArray.ReadOnly.Enumerator<Vector4>.MoveNext
	|-NativeArray.ReadOnly.Enumerator<VertexAttributeDescriptor>.MoveNext
	|
	|-RVA: 0x10E67D0 Offset: 0x10E59D0 VA: 0x1810E67D0
	|-NativeArray.ReadOnly.Enumerator<Color32>.MoveNext
	|-NativeArray.ReadOnly.Enumerator<int>.MoveNext
	|
	|-RVA: 0x10E79A0 Offset: 0x10E6BA0 VA: 0x1810E79A0
	|-NativeArray.ReadOnly.Enumerator<ContactPairHeader>.MoveNext
	|
	|-RVA: 0x10ECEB0 Offset: 0x10EC0B0 VA: 0x1810ECEB0
	|-NativeArray.ReadOnly.Enumerator<ConvertMeshJobData>.MoveNext
	|
	|-RVA: 0x10ED1B0 Offset: 0x10EC3B0 VA: 0x1810ED1B0
	|-NativeArray.ReadOnly.Enumerator<CopyClosingMeshJobData>.MoveNext
	|
	|-RVA: 0x10EC3D0 Offset: 0x10EB5D0 VA: 0x1810EC3D0
	|-NativeArray.ReadOnly.Enumerator<CullingSplit>.MoveNext
	|-NativeArray.ReadOnly.Enumerator<LightDataGI>.MoveNext
	|-NativeArray.ReadOnly.Enumerator<TileData>.MoveNext
	|
	|-RVA: 0x10EC650 Offset: 0x10EB850 VA: 0x1810EC650
	|-NativeArray.ReadOnly.Enumerator<GfxUpdateBufferRange>.MoveNext
	|-NativeArray.ReadOnly.Enumerator<JobHandle>.MoveNext
	|
	|-RVA: 0x10ECCD0 Offset: 0x10EBED0 VA: 0x1810ECCD0
	|-NativeArray.ReadOnly.Enumerator<Matrix4x4>.MoveNext
	|-NativeArray.ReadOnly.Enumerator<Vertex>.MoveNext
	|
	|-RVA: 0x10ED350 Offset: 0x10EC550 VA: 0x1810ED350
	|-NativeArray.ReadOnly.Enumerator<ModifiableContactPair>.MoveNext
	|
	|-RVA: 0x10ECDC0 Offset: 0x10EBFC0 VA: 0x1810ECDC0
	|-NativeArray.ReadOnly.Enumerator<NudgeJobData>.MoveNext
	|
	|-RVA: 0x1109EE0 Offset: 0x11090E0 VA: 0x181109EE0
	|-NativeArray.ReadOnly.Enumerator<Transform3x4>.MoveNext
	|
	|-RVA: 0x110AC70 Offset: 0x1109E70 VA: 0x18110AC70
	|-NativeArray.ReadOnly.Enumerator<ushort>.MoveNext
	|
	|-RVA: 0x1109720 Offset: 0x1108920 VA: 0x181109720
	|-NativeArray.ReadOnly.Enumerator<Vector3>.MoveNext
	|-NativeArray.ReadOnly.Enumerator<Vector3Int>.MoveNext
	|
	|-RVA: 0x11066E0 Offset: 0x11058E0 VA: 0x1811066E0
	|-NativeArray.ReadOnly.Enumerator<__Il2CppFullySharedGenericStructType>.MoveNext
	|
	|-RVA: 0x1112770 Offset: 0x1111970 VA: 0x181112770
	|-NativeArray.ReadOnly.Enumerator<ParticleSystem.Particle>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10E8670 Offset: 0x10E7870 VA: 0x1810E8670
	|-NativeArray.ReadOnly.Enumerator<BatchCullingOutputDrawCommands>.Reset
	|-NativeArray.ReadOnly.Enumerator<BoneWeight1>.Reset
	|-NativeArray.ReadOnly.Enumerator<byte>.Reset
	|-NativeArray.ReadOnly.Enumerator<Color>.Reset
	|-NativeArray.ReadOnly.Enumerator<Color32>.Reset
	|-NativeArray.ReadOnly.Enumerator<ContactPairHeader>.Reset
	|-NativeArray.ReadOnly.Enumerator<ConvertMeshJobData>.Reset
	|-NativeArray.ReadOnly.Enumerator<CopyClosingMeshJobData>.Reset
	|-NativeArray.ReadOnly.Enumerator<CullingSplit>.Reset
	|-NativeArray.ReadOnly.Enumerator<DrawBufferRange>.Reset
	|-NativeArray.ReadOnly.Enumerator<GfxUpdateBufferRange>.Reset
	|-NativeArray.ReadOnly.Enumerator<int>.Reset
	|-NativeArray.ReadOnly.Enumerator<JobHandle>.Reset
	|-NativeArray.ReadOnly.Enumerator<LightDataGI>.Reset
	|-NativeArray.ReadOnly.Enumerator<Matrix4x4>.Reset
	|-NativeArray.ReadOnly.Enumerator<ModifiableContactPair>.Reset
	|-NativeArray.ReadOnly.Enumerator<NudgeJobData>.Reset
	|-NativeArray.ReadOnly.Enumerator<Plane>.Reset
	|-NativeArray.ReadOnly.Enumerator<Quaternion>.Reset
	|-NativeArray.ReadOnly.Enumerator<TileData>.Reset
	|-NativeArray.ReadOnly.Enumerator<Transform3x4>.Reset
	|-NativeArray.ReadOnly.Enumerator<ushort>.Reset
	|-NativeArray.ReadOnly.Enumerator<Vector3>.Reset
	|-NativeArray.ReadOnly.Enumerator<Vector3Int>.Reset
	|-NativeArray.ReadOnly.Enumerator<Vector4>.Reset
	|-NativeArray.ReadOnly.Enumerator<Vertex>.Reset
	|-NativeArray.ReadOnly.Enumerator<VertexAttributeDescriptor>.Reset
	|-NativeArray.ReadOnly.Enumerator<ParticleSystem.Particle>.Reset
	|
	|-RVA: 0x110BE20 Offset: 0x110B020 VA: 0x18110BE20
	|-NativeArray.ReadOnly.Enumerator<__Il2CppFullySharedGenericStructType>.Reset
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10EBEB0 Offset: 0x10EB0B0 VA: 0x1810EBEB0
	|-NativeArray.ReadOnly.Enumerator<BatchCullingOutputDrawCommands>.get_Current
	|
	|-RVA: 0xB220A0 Offset: 0xB212A0 VA: 0x180B220A0
	|-NativeArray.ReadOnly.Enumerator<BoneWeight1>.get_Current
	|
	|-RVA: 0x41AC30 Offset: 0x419E30 VA: 0x18041AC30
	|-NativeArray.ReadOnly.Enumerator<byte>.get_Current
	|
	|-RVA: 0x10EBEA0 Offset: 0x10EB0A0 VA: 0x1810EBEA0
	|-NativeArray.ReadOnly.Enumerator<Color>.get_Current
	|-NativeArray.ReadOnly.Enumerator<DrawBufferRange>.get_Current
	|-NativeArray.ReadOnly.Enumerator<Plane>.get_Current
	|-NativeArray.ReadOnly.Enumerator<Quaternion>.get_Current
	|-NativeArray.ReadOnly.Enumerator<Vector4>.get_Current
	|-NativeArray.ReadOnly.Enumerator<VertexAttributeDescriptor>.get_Current
	|
	|-RVA: 0x426500 Offset: 0x425700 VA: 0x180426500
	|-NativeArray.ReadOnly.Enumerator<Color32>.get_Current
	|-NativeArray.ReadOnly.Enumerator<int>.get_Current
	|
	|-RVA: 0x41A1E0 Offset: 0x4193E0 VA: 0x18041A1E0
	|-NativeArray.ReadOnly.Enumerator<ContactPairHeader>.get_Current
	|
	|-RVA: 0x10F1230 Offset: 0x10F0430 VA: 0x1810F1230
	|-NativeArray.ReadOnly.Enumerator<ConvertMeshJobData>.get_Current
	|
	|-RVA: 0x4C1250 Offset: 0x4C0450 VA: 0x1804C1250
	|-NativeArray.ReadOnly.Enumerator<CopyClosingMeshJobData>.get_Current
	|
	|-RVA: 0x10F0C10 Offset: 0x10EFE10 VA: 0x1810F0C10
	|-NativeArray.ReadOnly.Enumerator<CullingSplit>.get_Current
	|-NativeArray.ReadOnly.Enumerator<LightDataGI>.get_Current
	|-NativeArray.ReadOnly.Enumerator<TileData>.get_Current
	|
	|-RVA: 0x42D820 Offset: 0x42CA20 VA: 0x18042D820
	|-NativeArray.ReadOnly.Enumerator<GfxUpdateBufferRange>.get_Current
	|-NativeArray.ReadOnly.Enumerator<JobHandle>.get_Current
	|
	|-RVA: 0x10F12C0 Offset: 0x10F04C0 VA: 0x1810F12C0
	|-NativeArray.ReadOnly.Enumerator<Matrix4x4>.get_Current
	|-NativeArray.ReadOnly.Enumerator<Vertex>.get_Current
	|
	|-RVA: 0x10F10A0 Offset: 0x10F02A0 VA: 0x1810F10A0
	|-NativeArray.ReadOnly.Enumerator<ModifiableContactPair>.get_Current
	|
	|-RVA: 0x10F1560 Offset: 0x10F0760 VA: 0x1810F1560
	|-NativeArray.ReadOnly.Enumerator<NudgeJobData>.get_Current
	|
	|-RVA: 0x1111B80 Offset: 0x1110D80 VA: 0x181111B80
	|-NativeArray.ReadOnly.Enumerator<Transform3x4>.get_Current
	|
	|-RVA: 0xB03E10 Offset: 0xB03010 VA: 0x180B03E10
	|-NativeArray.ReadOnly.Enumerator<ushort>.get_Current
	|
	|-RVA: 0x4C29D0 Offset: 0x4C1BD0 VA: 0x1804C29D0
	|-NativeArray.ReadOnly.Enumerator<Vector3>.get_Current
	|-NativeArray.ReadOnly.Enumerator<Vector3Int>.get_Current
	|
	|-RVA: 0x1111AA0 Offset: 0x1110CA0 VA: 0x181111AA0
	|-NativeArray.ReadOnly.Enumerator<__Il2CppFullySharedGenericStructType>.get_Current
	|
	|-RVA: 0x1116EE0 Offset: 0x11160E0 VA: 0x181116EE0
	|-NativeArray.ReadOnly.Enumerator<ParticleSystem.Particle>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10E9120 Offset: 0x10E8320 VA: 0x1810E9120
	|-NativeArray.ReadOnly.Enumerator<BatchCullingOutputDrawCommands>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x10E97F0 Offset: 0x10E89F0 VA: 0x1810E97F0
	|-NativeArray.ReadOnly.Enumerator<BoneWeight1>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x10E90C0 Offset: 0x10E82C0 VA: 0x1810E90C0
	|-NativeArray.ReadOnly.Enumerator<byte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x10E9240 Offset: 0x10E8440 VA: 0x1810E9240
	|-NativeArray.ReadOnly.Enumerator<Color>.System.Collections.IEnumerator.get_Current
	|-NativeArray.ReadOnly.Enumerator<DrawBufferRange>.System.Collections.IEnumerator.get_Current
	|-NativeArray.ReadOnly.Enumerator<Plane>.System.Collections.IEnumerator.get_Current
	|-NativeArray.ReadOnly.Enumerator<Quaternion>.System.Collections.IEnumerator.get_Current
	|-NativeArray.ReadOnly.Enumerator<Vector4>.System.Collections.IEnumerator.get_Current
	|-NativeArray.ReadOnly.Enumerator<VertexAttributeDescriptor>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x10E9850 Offset: 0x10E8A50 VA: 0x1810E9850
	|-NativeArray.ReadOnly.Enumerator<Color32>.System.Collections.IEnumerator.get_Current
	|-NativeArray.ReadOnly.Enumerator<int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x10E9640 Offset: 0x10E8840 VA: 0x1810E9640
	|-NativeArray.ReadOnly.Enumerator<ContactPairHeader>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x10EF7C0 Offset: 0x10EE9C0 VA: 0x1810EF7C0
	|-NativeArray.ReadOnly.Enumerator<ConvertMeshJobData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x10EEC20 Offset: 0x10EDE20 VA: 0x1810EEC20
	|-NativeArray.ReadOnly.Enumerator<CopyClosingMeshJobData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x10EF2D0 Offset: 0x10EE4D0 VA: 0x1810EF2D0
	|-NativeArray.ReadOnly.Enumerator<CullingSplit>.System.Collections.IEnumerator.get_Current
	|-NativeArray.ReadOnly.Enumerator<LightDataGI>.System.Collections.IEnumerator.get_Current
	|-NativeArray.ReadOnly.Enumerator<TileData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x10EF440 Offset: 0x10EE640 VA: 0x1810EF440
	|-NativeArray.ReadOnly.Enumerator<GfxUpdateBufferRange>.System.Collections.IEnumerator.get_Current
	|-NativeArray.ReadOnly.Enumerator<JobHandle>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x10EED50 Offset: 0x10EDF50 VA: 0x1810EED50
	|-NativeArray.ReadOnly.Enumerator<Matrix4x4>.System.Collections.IEnumerator.get_Current
	|-NativeArray.ReadOnly.Enumerator<Vertex>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x10EECA0 Offset: 0x10EDEA0 VA: 0x1810EECA0
	|-NativeArray.ReadOnly.Enumerator<ModifiableContactPair>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x10EF210 Offset: 0x10EE410 VA: 0x1810EF210
	|-NativeArray.ReadOnly.Enumerator<NudgeJobData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x110D120 Offset: 0x110C320 VA: 0x18110D120
	|-NativeArray.ReadOnly.Enumerator<Transform3x4>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x110D700 Offset: 0x110C900 VA: 0x18110D700
	|-NativeArray.ReadOnly.Enumerator<ushort>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x110D9D0 Offset: 0x110CBD0 VA: 0x18110D9D0
	|-NativeArray.ReadOnly.Enumerator<Vector3>.System.Collections.IEnumerator.get_Current
	|-NativeArray.ReadOnly.Enumerator<Vector3Int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x110E130 Offset: 0x110D330 VA: 0x18110E130
	|-NativeArray.ReadOnly.Enumerator<__Il2CppFullySharedGenericStructType>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1115650 Offset: 0x1114850 VA: 0x181115650
	|-NativeArray.ReadOnly.Enumerator<ParticleSystem.Particle>.System.Collections.IEnumerator.get_Current
	*/
}

// Namespace: 
[DebuggerDisplay("Length = {Length}")]
[NativeContainer]
[NativeContainerIsReadOnly]
[DebuggerTypeProxy(typeof(NativeArrayReadOnlyDebugView<T>))]
[DefaultMember("Item")]
public struct NativeArray.ReadOnly<T> : IEnumerable<T>, IEnumerable // TypeDefIndex: 13899
{
	// Fields
	[NativeDisableUnsafePtrRestriction]
	internal void* m_Buffer; // 0x0
	internal int m_Length; // 0x0

	// Properties
	public int Length { get; }
	public T Item { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(void* buffer, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5511A0 Offset: 0x5503A0 VA: 0x1805511A0
	|-NativeArray.ReadOnly<BatchCullingOutputDrawCommands>..ctor
	|-NativeArray.ReadOnly<BoneWeight1>..ctor
	|-NativeArray.ReadOnly<byte>..ctor
	|-NativeArray.ReadOnly<Color>..ctor
	|-NativeArray.ReadOnly<Color32>..ctor
	|-NativeArray.ReadOnly<ContactPairHeader>..ctor
	|-NativeArray.ReadOnly<ConvertMeshJobData>..ctor
	|-NativeArray.ReadOnly<CopyClosingMeshJobData>..ctor
	|-NativeArray.ReadOnly<CullingSplit>..ctor
	|-NativeArray.ReadOnly<DrawBufferRange>..ctor
	|-NativeArray.ReadOnly<GfxUpdateBufferRange>..ctor
	|-NativeArray.ReadOnly<int>..ctor
	|-NativeArray.ReadOnly<JobHandle>..ctor
	|-NativeArray.ReadOnly<LightDataGI>..ctor
	|-NativeArray.ReadOnly<Matrix4x4>..ctor
	|-NativeArray.ReadOnly<ModifiableContactPair>..ctor
	|-NativeArray.ReadOnly<NudgeJobData>..ctor
	|-NativeArray.ReadOnly<Plane>..ctor
	|-NativeArray.ReadOnly<Quaternion>..ctor
	|-NativeArray.ReadOnly<TileData>..ctor
	|-NativeArray.ReadOnly<Transform3x4>..ctor
	|-NativeArray.ReadOnly<ushort>..ctor
	|-NativeArray.ReadOnly<Vector3>..ctor
	|-NativeArray.ReadOnly<Vector3Int>..ctor
	|-NativeArray.ReadOnly<Vector4>..ctor
	|-NativeArray.ReadOnly<Vertex>..ctor
	|-NativeArray.ReadOnly<VertexAttributeDescriptor>..ctor
	|-NativeArray.ReadOnly<__Il2CppFullySharedGenericStructType>..ctor
	|-NativeArray.ReadOnly<ParticleSystem.Particle>..ctor
	*/

	// RVA: -1 Offset: -1
	public int get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBC6000 Offset: 0xBC5200 VA: 0x180BC6000
	|-NativeArray.ReadOnly<BatchCullingOutputDrawCommands>.get_Length
	|-NativeArray.ReadOnly<BoneWeight1>.get_Length
	|-NativeArray.ReadOnly<byte>.get_Length
	|-NativeArray.ReadOnly<Color>.get_Length
	|-NativeArray.ReadOnly<Color32>.get_Length
	|-NativeArray.ReadOnly<ContactPairHeader>.get_Length
	|-NativeArray.ReadOnly<ConvertMeshJobData>.get_Length
	|-NativeArray.ReadOnly<CopyClosingMeshJobData>.get_Length
	|-NativeArray.ReadOnly<CullingSplit>.get_Length
	|-NativeArray.ReadOnly<DrawBufferRange>.get_Length
	|-NativeArray.ReadOnly<GfxUpdateBufferRange>.get_Length
	|-NativeArray.ReadOnly<int>.get_Length
	|-NativeArray.ReadOnly<JobHandle>.get_Length
	|-NativeArray.ReadOnly<LightDataGI>.get_Length
	|-NativeArray.ReadOnly<Matrix4x4>.get_Length
	|-NativeArray.ReadOnly<ModifiableContactPair>.get_Length
	|-NativeArray.ReadOnly<NudgeJobData>.get_Length
	|-NativeArray.ReadOnly<Plane>.get_Length
	|-NativeArray.ReadOnly<Quaternion>.get_Length
	|-NativeArray.ReadOnly<TileData>.get_Length
	|-NativeArray.ReadOnly<Transform3x4>.get_Length
	|-NativeArray.ReadOnly<ushort>.get_Length
	|-NativeArray.ReadOnly<Vector3>.get_Length
	|-NativeArray.ReadOnly<Vector3Int>.get_Length
	|-NativeArray.ReadOnly<Vector4>.get_Length
	|-NativeArray.ReadOnly<Vertex>.get_Length
	|-NativeArray.ReadOnly<VertexAttributeDescriptor>.get_Length
	|-NativeArray.ReadOnly<__Il2CppFullySharedGenericStructType>.get_Length
	|-NativeArray.ReadOnly<ParticleSystem.Particle>.get_Length
	*/

	// RVA: -1 Offset: -1
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBC5F80 Offset: 0xBC5180 VA: 0x180BC5F80
	|-NativeArray.ReadOnly<BatchCullingOutputDrawCommands>.get_Item
	|
	|-RVA: 0xBC5890 Offset: 0xBC4A90 VA: 0x180BC5890
	|-NativeArray.ReadOnly<BoneWeight1>.get_Item
	|
	|-RVA: 0xBC5850 Offset: 0xBC4A50 VA: 0x180BC5850
	|-NativeArray.ReadOnly<byte>.get_Item
	|
	|-RVA: 0xBC5800 Offset: 0xBC4A00 VA: 0x180BC5800
	|-NativeArray.ReadOnly<Color>.get_Item
	|-NativeArray.ReadOnly<DrawBufferRange>.get_Item
	|-NativeArray.ReadOnly<GfxUpdateBufferRange>.get_Item
	|-NativeArray.ReadOnly<JobHandle>.get_Item
	|-NativeArray.ReadOnly<Plane>.get_Item
	|-NativeArray.ReadOnly<Quaternion>.get_Item
	|-NativeArray.ReadOnly<Vector4>.get_Item
	|-NativeArray.ReadOnly<VertexAttributeDescriptor>.get_Item
	|
	|-RVA: 0xBC59D0 Offset: 0xBC4BD0 VA: 0x180BC59D0
	|-NativeArray.ReadOnly<Color32>.get_Item
	|-NativeArray.ReadOnly<int>.get_Item
	|
	|-RVA: 0xBC5B80 Offset: 0xBC4D80 VA: 0x180BC5B80
	|-NativeArray.ReadOnly<ContactPairHeader>.get_Item
	|
	|-RVA: 0xBC5DC0 Offset: 0xBC4FC0 VA: 0x180BC5DC0
	|-NativeArray.ReadOnly<ConvertMeshJobData>.get_Item
	|
	|-RVA: 0xBC5D50 Offset: 0xBC4F50 VA: 0x180BC5D50
	|-NativeArray.ReadOnly<CopyClosingMeshJobData>.get_Item
	|-NativeArray.ReadOnly<Transform3x4>.get_Item
	|
	|-RVA: 0xBC58D0 Offset: 0xBC4AD0 VA: 0x180BC58D0
	|-NativeArray.ReadOnly<CullingSplit>.get_Item
	|-NativeArray.ReadOnly<LightDataGI>.get_Item
	|-NativeArray.ReadOnly<TileData>.get_Item
	|
	|-RVA: 0xBC5780 Offset: 0xBC4980 VA: 0x180BC5780
	|-NativeArray.ReadOnly<Matrix4x4>.get_Item
	|-NativeArray.ReadOnly<Vertex>.get_Item
	|
	|-RVA: 0xBC5EA0 Offset: 0xBC50A0 VA: 0x180BC5EA0
	|-NativeArray.ReadOnly<ModifiableContactPair>.get_Item
	|
	|-RVA: 0xBC5AD0 Offset: 0xBC4CD0 VA: 0x180BC5AD0
	|-NativeArray.ReadOnly<NudgeJobData>.get_Item
	|
	|-RVA: 0xBC5F40 Offset: 0xBC5140 VA: 0x180BC5F40
	|-NativeArray.ReadOnly<ushort>.get_Item
	|
	|-RVA: 0xBC5970 Offset: 0xBC4B70 VA: 0x180BC5970
	|-NativeArray.ReadOnly<Vector3>.get_Item
	|-NativeArray.ReadOnly<Vector3Int>.get_Item
	|
	|-RVA: 0xBC5BF0 Offset: 0xBC4DF0 VA: 0x180BC5BF0
	|-NativeArray.ReadOnly<__Il2CppFullySharedGenericStructType>.get_Item
	|
	|-RVA: 0xBC5A00 Offset: 0xBC4C00 VA: 0x180BC5A00
	|-NativeArray.ReadOnly<ParticleSystem.Particle>.get_Item
	*/

	// RVA: -1 Offset: -1
	public NativeArray.ReadOnly.Enumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBC4860 Offset: 0xBC3A60 VA: 0x180BC4860
	|-NativeArray.ReadOnly<BatchCullingOutputDrawCommands>.GetEnumerator
	|
	|-RVA: 0xBC4440 Offset: 0xBC3640 VA: 0x180BC4440
	|-NativeArray.ReadOnly<BoneWeight1>.GetEnumerator
	|
	|-RVA: 0xBC47E0 Offset: 0xBC39E0 VA: 0x180BC47E0
	|-NativeArray.ReadOnly<byte>.GetEnumerator
	|
	|-RVA: 0xBC43B0 Offset: 0xBC35B0 VA: 0x180BC43B0
	|-NativeArray.ReadOnly<Color>.GetEnumerator
	|-NativeArray.ReadOnly<DrawBufferRange>.GetEnumerator
	|-NativeArray.ReadOnly<Plane>.GetEnumerator
	|-NativeArray.ReadOnly<Quaternion>.GetEnumerator
	|-NativeArray.ReadOnly<Vector4>.GetEnumerator
	|-NativeArray.ReadOnly<VertexAttributeDescriptor>.GetEnumerator
	|
	|-RVA: 0xBC4100 Offset: 0xBC3300 VA: 0x180BC4100
	|-NativeArray.ReadOnly<Color32>.GetEnumerator
	|-NativeArray.ReadOnly<int>.GetEnumerator
	|
	|-RVA: 0xBC45A0 Offset: 0xBC37A0 VA: 0x180BC45A0
	|-NativeArray.ReadOnly<ContactPairHeader>.GetEnumerator
	|
	|-RVA: 0xBC4640 Offset: 0xBC3840 VA: 0x180BC4640
	|-NativeArray.ReadOnly<ConvertMeshJobData>.GetEnumerator
	|
	|-RVA: 0xBC4180 Offset: 0xBC3380 VA: 0x180BC4180
	|-NativeArray.ReadOnly<CopyClosingMeshJobData>.GetEnumerator
	|
	|-RVA: 0xBC3CF0 Offset: 0xBC2EF0 VA: 0x180BC3CF0
	|-NativeArray.ReadOnly<CullingSplit>.GetEnumerator
	|-NativeArray.ReadOnly<LightDataGI>.GetEnumerator
	|-NativeArray.ReadOnly<TileData>.GetEnumerator
	|
	|-RVA: 0xBC4320 Offset: 0xBC3520 VA: 0x180BC4320
	|-NativeArray.ReadOnly<GfxUpdateBufferRange>.GetEnumerator
	|-NativeArray.ReadOnly<JobHandle>.GetEnumerator
	|
	|-RVA: 0xBC3DE0 Offset: 0xBC2FE0 VA: 0x180BC3DE0
	|-NativeArray.ReadOnly<Matrix4x4>.GetEnumerator
	|-NativeArray.ReadOnly<Vertex>.GetEnumerator
	|
	|-RVA: 0xBC4230 Offset: 0xBC3430 VA: 0x180BC4230
	|-NativeArray.ReadOnly<ModifiableContactPair>.GetEnumerator
	|
	|-RVA: 0xBC3BE0 Offset: 0xBC2DE0 VA: 0x180BC3BE0
	|-NativeArray.ReadOnly<NudgeJobData>.GetEnumerator
	|
	|-RVA: 0xBC4730 Offset: 0xBC3930 VA: 0x180BC4730
	|-NativeArray.ReadOnly<Transform3x4>.GetEnumerator
	|
	|-RVA: 0xBC4520 Offset: 0xBC3720 VA: 0x180BC4520
	|-NativeArray.ReadOnly<ushort>.GetEnumerator
	|
	|-RVA: 0xBC44B0 Offset: 0xBC36B0 VA: 0x180BC44B0
	|-NativeArray.ReadOnly<Vector3>.GetEnumerator
	|-NativeArray.ReadOnly<Vector3Int>.GetEnumerator
	|
	|-RVA: 0xBC3FE0 Offset: 0xBC31E0 VA: 0x180BC3FE0
	|-NativeArray.ReadOnly<__Il2CppFullySharedGenericStructType>.GetEnumerator
	|
	|-RVA: 0xBC3EB0 Offset: 0xBC30B0 VA: 0x180BC3EB0
	|-NativeArray.ReadOnly<ParticleSystem.Particle>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBC4F70 Offset: 0xBC4170 VA: 0x180BC4F70
	|-NativeArray.ReadOnly<BatchCullingOutputDrawCommands>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0xBC4AA0 Offset: 0xBC3CA0 VA: 0x180BC4AA0
	|-NativeArray.ReadOnly<BoneWeight1>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0xBC54E0 Offset: 0xBC46E0 VA: 0x180BC54E0
	|-NativeArray.ReadOnly<byte>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0xBC4910 Offset: 0xBC3B10 VA: 0x180BC4910
	|-NativeArray.ReadOnly<Color>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeArray.ReadOnly<DrawBufferRange>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeArray.ReadOnly<Plane>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeArray.ReadOnly<Quaternion>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeArray.ReadOnly<Vector4>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeArray.ReadOnly<VertexAttributeDescriptor>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0xBC4CF0 Offset: 0xBC3EF0 VA: 0x180BC4CF0
	|-NativeArray.ReadOnly<Color32>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeArray.ReadOnly<int>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0xBC55A0 Offset: 0xBC47A0 VA: 0x180BC55A0
	|-NativeArray.ReadOnly<ContactPairHeader>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0xBC5190 Offset: 0xBC4390 VA: 0x180BC5190
	|-NativeArray.ReadOnly<ConvertMeshJobData>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0xBC5280 Offset: 0xBC4480 VA: 0x180BC5280
	|-NativeArray.ReadOnly<CopyClosingMeshJobData>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0xBC4EA0 Offset: 0xBC40A0 VA: 0x180BC4EA0
	|-NativeArray.ReadOnly<CullingSplit>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeArray.ReadOnly<LightDataGI>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeArray.ReadOnly<TileData>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0xBC4C20 Offset: 0xBC3E20 VA: 0x180BC4C20
	|-NativeArray.ReadOnly<GfxUpdateBufferRange>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeArray.ReadOnly<JobHandle>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0xBC49E0 Offset: 0xBC3BE0 VA: 0x180BC49E0
	|-NativeArray.ReadOnly<Matrix4x4>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeArray.ReadOnly<Vertex>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0xBC5330 Offset: 0xBC4530 VA: 0x180BC5330
	|-NativeArray.ReadOnly<ModifiableContactPair>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0xBC5400 Offset: 0xBC4600 VA: 0x180BC5400
	|-NativeArray.ReadOnly<NudgeJobData>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0xBC50E0 Offset: 0xBC42E0 VA: 0x180BC50E0
	|-NativeArray.ReadOnly<Transform3x4>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0xBC5020 Offset: 0xBC4220 VA: 0x180BC5020
	|-NativeArray.ReadOnly<ushort>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0xBC4B60 Offset: 0xBC3D60 VA: 0x180BC4B60
	|-NativeArray.ReadOnly<Vector3>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeArray.ReadOnly<Vector3Int>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0xBC5680 Offset: 0xBC4880 VA: 0x180BC5680
	|-NativeArray.ReadOnly<__Il2CppFullySharedGenericStructType>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0xBC4DB0 Offset: 0xBC3FB0 VA: 0x180BC4DB0
	|-NativeArray.ReadOnly<ParticleSystem.Particle>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBC4F70 Offset: 0xBC4170 VA: 0x180BC4F70
	|-NativeArray.ReadOnly<BatchCullingOutputDrawCommands>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xBC4AA0 Offset: 0xBC3CA0 VA: 0x180BC4AA0
	|-NativeArray.ReadOnly<BoneWeight1>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xBC54E0 Offset: 0xBC46E0 VA: 0x180BC54E0
	|-NativeArray.ReadOnly<byte>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xBC4910 Offset: 0xBC3B10 VA: 0x180BC4910
	|-NativeArray.ReadOnly<Color>.System.Collections.IEnumerable.GetEnumerator
	|-NativeArray.ReadOnly<DrawBufferRange>.System.Collections.IEnumerable.GetEnumerator
	|-NativeArray.ReadOnly<Plane>.System.Collections.IEnumerable.GetEnumerator
	|-NativeArray.ReadOnly<Quaternion>.System.Collections.IEnumerable.GetEnumerator
	|-NativeArray.ReadOnly<Vector4>.System.Collections.IEnumerable.GetEnumerator
	|-NativeArray.ReadOnly<VertexAttributeDescriptor>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xBC4CF0 Offset: 0xBC3EF0 VA: 0x180BC4CF0
	|-NativeArray.ReadOnly<Color32>.System.Collections.IEnumerable.GetEnumerator
	|-NativeArray.ReadOnly<int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xBC55A0 Offset: 0xBC47A0 VA: 0x180BC55A0
	|-NativeArray.ReadOnly<ContactPairHeader>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xBC5190 Offset: 0xBC4390 VA: 0x180BC5190
	|-NativeArray.ReadOnly<ConvertMeshJobData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xBC5280 Offset: 0xBC4480 VA: 0x180BC5280
	|-NativeArray.ReadOnly<CopyClosingMeshJobData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xBC4EA0 Offset: 0xBC40A0 VA: 0x180BC4EA0
	|-NativeArray.ReadOnly<CullingSplit>.System.Collections.IEnumerable.GetEnumerator
	|-NativeArray.ReadOnly<LightDataGI>.System.Collections.IEnumerable.GetEnumerator
	|-NativeArray.ReadOnly<TileData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xBC4C20 Offset: 0xBC3E20 VA: 0x180BC4C20
	|-NativeArray.ReadOnly<GfxUpdateBufferRange>.System.Collections.IEnumerable.GetEnumerator
	|-NativeArray.ReadOnly<JobHandle>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xBC49E0 Offset: 0xBC3BE0 VA: 0x180BC49E0
	|-NativeArray.ReadOnly<Matrix4x4>.System.Collections.IEnumerable.GetEnumerator
	|-NativeArray.ReadOnly<Vertex>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xBC5330 Offset: 0xBC4530 VA: 0x180BC5330
	|-NativeArray.ReadOnly<ModifiableContactPair>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xBC5400 Offset: 0xBC4600 VA: 0x180BC5400
	|-NativeArray.ReadOnly<NudgeJobData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xBC50E0 Offset: 0xBC42E0 VA: 0x180BC50E0
	|-NativeArray.ReadOnly<Transform3x4>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xBC5020 Offset: 0xBC4220 VA: 0x180BC5020
	|-NativeArray.ReadOnly<ushort>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xBC4B60 Offset: 0xBC3D60 VA: 0x180BC4B60
	|-NativeArray.ReadOnly<Vector3>.System.Collections.IEnumerable.GetEnumerator
	|-NativeArray.ReadOnly<Vector3Int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xBC5680 Offset: 0xBC4880 VA: 0x180BC5680
	|-NativeArray.ReadOnly<__Il2CppFullySharedGenericStructType>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xBC4DB0 Offset: 0xBC3FB0 VA: 0x180BC4DB0
	|-NativeArray.ReadOnly<ParticleSystem.Particle>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: Unity.Collections
[NativeContainerSupportsDeallocateOnJobCompletion]
[NativeContainerSupportsMinMaxWriteRestriction]
[DebuggerTypeProxy(typeof(NativeArrayDebugView<T>))]
[DebuggerDisplay("Length = {m_Length}")]
[NativeContainerSupportsDeferredConvertListToArray]
[DefaultMember("Item")]
[NativeContainer]
public struct NativeArray<T> : IDisposable, IEnumerable<T>, IEnumerable, IEquatable<NativeArray<T>> // TypeDefIndex: 13900
{
	// Fields
	[NativeDisableUnsafePtrRestriction]
	internal void* m_Buffer; // 0x0
	internal int m_Length; // 0x0
	internal Allocator m_AllocatorLabel; // 0x0

	// Properties
	public int Length { get; }
	public T Item { get; set; }
	public bool IsCreated { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(int length, Allocator allocator, NativeArrayOptions options = 1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1471320 Offset: 0x1470520 VA: 0x181471320
	|-NativeArray<BatchCullingOutputDrawCommands>..ctor
	|
	|-RVA: 0x1471660 Offset: 0x1470860 VA: 0x181471660
	|-NativeArray<BoneWeight1>..ctor
	|
	|-RVA: 0x14715C0 Offset: 0x14707C0 VA: 0x1814715C0
	|-NativeArray<byte>..ctor
	|
	|-RVA: 0x14709D0 Offset: 0x146FBD0 VA: 0x1814709D0
	|-NativeArray<Color>..ctor
	|-NativeArray<DrawBufferRange>..ctor
	|-NativeArray<Plane>..ctor
	|-NativeArray<Quaternion>..ctor
	|-NativeArray<Vector4>..ctor
	|-NativeArray<VertexAttributeDescriptor>..ctor
	|
	|-RVA: 0x1471270 Offset: 0x1470470 VA: 0x181471270
	|-NativeArray<Color32>..ctor
	|-NativeArray<int>..ctor
	|
	|-RVA: 0x1471510 Offset: 0x1470710 VA: 0x181471510
	|-NativeArray<ContactPairHeader>..ctor
	|
	|-RVA: 0x1470FC0 Offset: 0x14701C0 VA: 0x181470FC0
	|-NativeArray<ConvertMeshJobData>..ctor
	|
	|-RVA: 0x14719B0 Offset: 0x1470BB0 VA: 0x1814719B0
	|-NativeArray<CopyClosingMeshJobData>..ctor
	|
	|-RVA: 0x1471070 Offset: 0x1470270 VA: 0x181471070
	|-NativeArray<CullingSplit>..ctor
	|-NativeArray<LightDataGI>..ctor
	|-NativeArray<TileData>..ctor
	|
	|-RVA: 0x1471A60 Offset: 0x1470C60 VA: 0x181471A60
	|-NativeArray<GfxUpdateBufferRange>..ctor
	|-NativeArray<JobHandle>..ctor
	|
	|-RVA: 0x147E110 Offset: 0x147D310 VA: 0x18147E110
	|-NativeArray<Matrix4x4>..ctor
	|-NativeArray<Vertex>..ctor
	|
	|-RVA: 0x147E270 Offset: 0x147D470 VA: 0x18147E270
	|-NativeArray<ModifiableContactPair>..ctor
	|
	|-RVA: 0x147E070 Offset: 0x147D270 VA: 0x18147E070
	|-NativeArray<NudgeJobData>..ctor
	|
	|-RVA: 0x147D990 Offset: 0x147CB90 VA: 0x18147D990
	|-NativeArray<Transform3x4>..ctor
	|
	|-RVA: 0x147D590 Offset: 0x147C790 VA: 0x18147D590
	|-NativeArray<ushort>..ctor
	|
	|-RVA: 0x147D640 Offset: 0x147C840 VA: 0x18147D640
	|-NativeArray<Vector3>..ctor
	|-NativeArray<Vector3Int>..ctor
	|
	|-RVA: 0x147DA40 Offset: 0x147CC40 VA: 0x18147DA40
	|-NativeArray<__Il2CppFullySharedGenericStructType>..ctor
	|
	|-RVA: 0x147E1C0 Offset: 0x147D3C0 VA: 0x18147E1C0
	|-NativeArray<ParticleSystem.Particle>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(T[] array, Allocator allocator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1470BD0 Offset: 0x146FDD0 VA: 0x181470BD0
	|-NativeArray<BatchCullingOutputDrawCommands>..ctor
	|
	|-RVA: 0x1470E70 Offset: 0x1470070 VA: 0x181470E70
	|-NativeArray<BoneWeight1>..ctor
	|
	|-RVA: 0x1471120 Offset: 0x1470320 VA: 0x181471120
	|-NativeArray<byte>..ctor
	|
	|-RVA: 0x1470880 Offset: 0x146FA80 VA: 0x181470880
	|-NativeArray<Color>..ctor
	|-NativeArray<DrawBufferRange>..ctor
	|-NativeArray<Plane>..ctor
	|-NativeArray<Quaternion>..ctor
	|-NativeArray<Vector4>..ctor
	|-NativeArray<VertexAttributeDescriptor>..ctor
	|
	|-RVA: 0x1471860 Offset: 0x1470A60 VA: 0x181471860
	|-NativeArray<Color32>..ctor
	|-NativeArray<int>..ctor
	|
	|-RVA: 0x1470A80 Offset: 0x146FC80 VA: 0x181470A80
	|-NativeArray<ContactPairHeader>..ctor
	|
	|-RVA: 0x1471B10 Offset: 0x1470D10 VA: 0x181471B10
	|-NativeArray<ConvertMeshJobData>..ctor
	|
	|-RVA: 0x14713C0 Offset: 0x14705C0 VA: 0x1814713C0
	|-NativeArray<CopyClosingMeshJobData>..ctor
	|
	|-RVA: 0x1470D20 Offset: 0x146FF20 VA: 0x181470D20
	|-NativeArray<CullingSplit>..ctor
	|-NativeArray<LightDataGI>..ctor
	|-NativeArray<TileData>..ctor
	|
	|-RVA: 0x1471710 Offset: 0x1470910 VA: 0x181471710
	|-NativeArray<GfxUpdateBufferRange>..ctor
	|-NativeArray<JobHandle>..ctor
	|
	|-RVA: 0x147D2F0 Offset: 0x147C4F0 VA: 0x18147D2F0
	|-NativeArray<Matrix4x4>..ctor
	|-NativeArray<Vertex>..ctor
	|
	|-RVA: 0x147DF20 Offset: 0x147D120 VA: 0x18147DF20
	|-NativeArray<ModifiableContactPair>..ctor
	|
	|-RVA: 0x147DB80 Offset: 0x147CD80 VA: 0x18147DB80
	|-NativeArray<NudgeJobData>..ctor
	|
	|-RVA: 0x147D840 Offset: 0x147CA40 VA: 0x18147D840
	|-NativeArray<Transform3x4>..ctor
	|
	|-RVA: 0x147DDD0 Offset: 0x147CFD0 VA: 0x18147DDD0
	|-NativeArray<ushort>..ctor
	|
	|-RVA: 0x147D440 Offset: 0x147C640 VA: 0x18147D440
	|-NativeArray<Vector3>..ctor
	|-NativeArray<Vector3Int>..ctor
	|
	|-RVA: 0x147DCD0 Offset: 0x147CED0 VA: 0x18147DCD0
	|-NativeArray<__Il2CppFullySharedGenericStructType>..ctor
	|
	|-RVA: 0x147D6F0 Offset: 0x147C8F0 VA: 0x18147D6F0
	|-NativeArray<ParticleSystem.Particle>..ctor
	*/

	// RVA: -1 Offset: -1
	private static void Allocate(int length, Allocator allocator, out NativeArray<T> array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x146B6B0 Offset: 0x146A8B0 VA: 0x18146B6B0
	|-NativeArray<BatchCullingOutputDrawCommands>.Allocate
	|
	|-RVA: 0x146B570 Offset: 0x146A770 VA: 0x18146B570
	|-NativeArray<BoneWeight1>.Allocate
	|
	|-RVA: 0x146B4D0 Offset: 0x146A6D0 VA: 0x18146B4D0
	|-NativeArray<byte>.Allocate
	|
	|-RVA: 0x146B390 Offset: 0x146A590 VA: 0x18146B390
	|-NativeArray<Color>.Allocate
	|-NativeArray<DrawBufferRange>.Allocate
	|-NativeArray<Plane>.Allocate
	|-NativeArray<Quaternion>.Allocate
	|-NativeArray<Vector4>.Allocate
	|-NativeArray<VertexAttributeDescriptor>.Allocate
	|
	|-RVA: 0x146B250 Offset: 0x146A450 VA: 0x18146B250
	|-NativeArray<Color32>.Allocate
	|-NativeArray<int>.Allocate
	|
	|-RVA: 0x146B750 Offset: 0x146A950 VA: 0x18146B750
	|-NativeArray<ContactPairHeader>.Allocate
	|
	|-RVA: 0x146B2F0 Offset: 0x146A4F0 VA: 0x18146B2F0
	|-NativeArray<ConvertMeshJobData>.Allocate
	|
	|-RVA: 0x146B430 Offset: 0x146A630 VA: 0x18146B430
	|-NativeArray<CopyClosingMeshJobData>.Allocate
	|
	|-RVA: 0x146B7F0 Offset: 0x146A9F0 VA: 0x18146B7F0
	|-NativeArray<CullingSplit>.Allocate
	|-NativeArray<LightDataGI>.Allocate
	|-NativeArray<TileData>.Allocate
	|
	|-RVA: 0x146B610 Offset: 0x146A810 VA: 0x18146B610
	|-NativeArray<GfxUpdateBufferRange>.Allocate
	|-NativeArray<JobHandle>.Allocate
	|
	|-RVA: 0x1478A80 Offset: 0x1477C80 VA: 0x181478A80
	|-NativeArray<Matrix4x4>.Allocate
	|-NativeArray<Vertex>.Allocate
	|
	|-RVA: 0x1478B20 Offset: 0x1477D20 VA: 0x181478B20
	|-NativeArray<ModifiableContactPair>.Allocate
	|
	|-RVA: 0x1478EA0 Offset: 0x14780A0 VA: 0x181478EA0
	|-NativeArray<NudgeJobData>.Allocate
	|
	|-RVA: 0x1478D60 Offset: 0x1477F60 VA: 0x181478D60
	|-NativeArray<Transform3x4>.Allocate
	|
	|-RVA: 0x1478CC0 Offset: 0x1477EC0 VA: 0x181478CC0
	|-NativeArray<ushort>.Allocate
	|
	|-RVA: 0x1478E00 Offset: 0x1478000 VA: 0x181478E00
	|-NativeArray<Vector3>.Allocate
	|-NativeArray<Vector3Int>.Allocate
	|
	|-RVA: 0x1478BC0 Offset: 0x1477DC0 VA: 0x181478BC0
	|-NativeArray<__Il2CppFullySharedGenericStructType>.Allocate
	|
	|-RVA: 0x1478F40 Offset: 0x1478140 VA: 0x181478F40
	|-NativeArray<ParticleSystem.Particle>.Allocate
	*/

	// RVA: -1 Offset: -1
	public int get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBC6000 Offset: 0xBC5200 VA: 0x180BC6000
	|-NativeArray<BatchCullingOutputDrawCommands>.get_Length
	|-NativeArray<BoneWeight1>.get_Length
	|-NativeArray<byte>.get_Length
	|-NativeArray<Color>.get_Length
	|-NativeArray<Color32>.get_Length
	|-NativeArray<ContactPairHeader>.get_Length
	|-NativeArray<ConvertMeshJobData>.get_Length
	|-NativeArray<CopyClosingMeshJobData>.get_Length
	|-NativeArray<CullingSplit>.get_Length
	|-NativeArray<DrawBufferRange>.get_Length
	|-NativeArray<GfxUpdateBufferRange>.get_Length
	|-NativeArray<int>.get_Length
	|-NativeArray<JobHandle>.get_Length
	|-NativeArray<LightDataGI>.get_Length
	|-NativeArray<Matrix4x4>.get_Length
	|-NativeArray<ModifiableContactPair>.get_Length
	|-NativeArray<NudgeJobData>.get_Length
	|-NativeArray<Plane>.get_Length
	|-NativeArray<Quaternion>.get_Length
	|-NativeArray<TileData>.get_Length
	|-NativeArray<Transform3x4>.get_Length
	|-NativeArray<ushort>.get_Length
	|-NativeArray<Vector3>.get_Length
	|-NativeArray<Vector3Int>.get_Length
	|-NativeArray<Vector4>.get_Length
	|-NativeArray<Vertex>.get_Length
	|-NativeArray<VertexAttributeDescriptor>.get_Length
	|-NativeArray<__Il2CppFullySharedGenericStructType>.get_Length
	|-NativeArray<ParticleSystem.Particle>.get_Length
	*/

	// RVA: -1 Offset: -1
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBC5F80 Offset: 0xBC5180 VA: 0x180BC5F80
	|-NativeArray<BatchCullingOutputDrawCommands>.get_Item
	|
	|-RVA: 0xBC5890 Offset: 0xBC4A90 VA: 0x180BC5890
	|-NativeArray<BoneWeight1>.get_Item
	|
	|-RVA: 0xBC5850 Offset: 0xBC4A50 VA: 0x180BC5850
	|-NativeArray<byte>.get_Item
	|
	|-RVA: 0xBC5800 Offset: 0xBC4A00 VA: 0x180BC5800
	|-NativeArray<Color>.get_Item
	|-NativeArray<DrawBufferRange>.get_Item
	|-NativeArray<GfxUpdateBufferRange>.get_Item
	|-NativeArray<JobHandle>.get_Item
	|-NativeArray<Plane>.get_Item
	|-NativeArray<Quaternion>.get_Item
	|-NativeArray<Vector4>.get_Item
	|-NativeArray<VertexAttributeDescriptor>.get_Item
	|
	|-RVA: 0xBC59D0 Offset: 0xBC4BD0 VA: 0x180BC59D0
	|-NativeArray<Color32>.get_Item
	|-NativeArray<int>.get_Item
	|
	|-RVA: 0xBC5B80 Offset: 0xBC4D80 VA: 0x180BC5B80
	|-NativeArray<ContactPairHeader>.get_Item
	|
	|-RVA: 0xBC5DC0 Offset: 0xBC4FC0 VA: 0x180BC5DC0
	|-NativeArray<ConvertMeshJobData>.get_Item
	|
	|-RVA: 0xBC5D50 Offset: 0xBC4F50 VA: 0x180BC5D50
	|-NativeArray<CopyClosingMeshJobData>.get_Item
	|-NativeArray<Transform3x4>.get_Item
	|
	|-RVA: 0xBC58D0 Offset: 0xBC4AD0 VA: 0x180BC58D0
	|-NativeArray<CullingSplit>.get_Item
	|-NativeArray<LightDataGI>.get_Item
	|-NativeArray<TileData>.get_Item
	|
	|-RVA: 0xBC5780 Offset: 0xBC4980 VA: 0x180BC5780
	|-NativeArray<Matrix4x4>.get_Item
	|-NativeArray<Vertex>.get_Item
	|
	|-RVA: 0xBC5EA0 Offset: 0xBC50A0 VA: 0x180BC5EA0
	|-NativeArray<ModifiableContactPair>.get_Item
	|
	|-RVA: 0xBC5AD0 Offset: 0xBC4CD0 VA: 0x180BC5AD0
	|-NativeArray<NudgeJobData>.get_Item
	|
	|-RVA: 0xBC5F40 Offset: 0xBC5140 VA: 0x180BC5F40
	|-NativeArray<ushort>.get_Item
	|
	|-RVA: 0xBC5970 Offset: 0xBC4B70 VA: 0x180BC5970
	|-NativeArray<Vector3>.get_Item
	|-NativeArray<Vector3Int>.get_Item
	|
	|-RVA: 0x147E310 Offset: 0x147D510 VA: 0x18147E310
	|-NativeArray<__Il2CppFullySharedGenericStructType>.get_Item
	|
	|-RVA: 0xBC5A00 Offset: 0xBC4C00 VA: 0x180BC5A00
	|-NativeArray<ParticleSystem.Particle>.get_Item
	*/

	[WriteAccessRequired]
	// RVA: -1 Offset: -1
	public void set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1471F70 Offset: 0x1471170 VA: 0x181471F70
	|-NativeArray<BatchCullingOutputDrawCommands>.set_Item
	|
	|-RVA: 0x1471D20 Offset: 0x1470F20 VA: 0x181471D20
	|-NativeArray<BoneWeight1>.set_Item
	|
	|-RVA: 0x1471EF0 Offset: 0x14710F0 VA: 0x181471EF0
	|-NativeArray<byte>.set_Item
	|
	|-RVA: 0x1471D60 Offset: 0x1470F60 VA: 0x181471D60
	|-NativeArray<Color>.set_Item
	|-NativeArray<DrawBufferRange>.set_Item
	|-NativeArray<GfxUpdateBufferRange>.set_Item
	|-NativeArray<JobHandle>.set_Item
	|-NativeArray<Plane>.set_Item
	|-NativeArray<Quaternion>.set_Item
	|-NativeArray<Vector4>.set_Item
	|-NativeArray<VertexAttributeDescriptor>.set_Item
	|
	|-RVA: 0x1471F30 Offset: 0x1471130 VA: 0x181471F30
	|-NativeArray<Color32>.set_Item
	|-NativeArray<int>.set_Item
	|
	|-RVA: 0x1471DB0 Offset: 0x1470FB0 VA: 0x181471DB0
	|-NativeArray<ContactPairHeader>.set_Item
	|
	|-RVA: 0x1471C70 Offset: 0x1470E70 VA: 0x181471C70
	|-NativeArray<ConvertMeshJobData>.set_Item
	|
	|-RVA: 0x1471E90 Offset: 0x1471090 VA: 0x181471E90
	|-NativeArray<CopyClosingMeshJobData>.set_Item
	|-NativeArray<Transform3x4>.set_Item
	|
	|-RVA: 0x1471E10 Offset: 0x1471010 VA: 0x181471E10
	|-NativeArray<CullingSplit>.set_Item
	|-NativeArray<LightDataGI>.set_Item
	|-NativeArray<TileData>.set_Item
	|
	|-RVA: 0x147E5A0 Offset: 0x147D7A0 VA: 0x18147E5A0
	|-NativeArray<Matrix4x4>.set_Item
	|-NativeArray<Vertex>.set_Item
	|
	|-RVA: 0x147E7B0 Offset: 0x147D9B0 VA: 0x18147E7B0
	|-NativeArray<ModifiableContactPair>.set_Item
	|
	|-RVA: 0x147E720 Offset: 0x147D920 VA: 0x18147E720
	|-NativeArray<NudgeJobData>.set_Item
	|
	|-RVA: 0x147E4C0 Offset: 0x147D6C0 VA: 0x18147E4C0
	|-NativeArray<ushort>.set_Item
	|
	|-RVA: 0x147E470 Offset: 0x147D670 VA: 0x18147E470
	|-NativeArray<Vector3>.set_Item
	|-NativeArray<Vector3Int>.set_Item
	|
	|-RVA: 0x147E610 Offset: 0x147D810 VA: 0x18147E610
	|-NativeArray<__Il2CppFullySharedGenericStructType>.set_Item
	|
	|-RVA: 0x147E500 Offset: 0x147D700 VA: 0x18147E500
	|-NativeArray<ParticleSystem.Particle>.set_Item
	*/

	// RVA: -1 Offset: -1
	public bool get_IsCreated() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1471C60 Offset: 0x1470E60 VA: 0x181471C60
	|-NativeArray<BatchCullingOutputDrawCommands>.get_IsCreated
	|-NativeArray<BoneWeight1>.get_IsCreated
	|-NativeArray<byte>.get_IsCreated
	|-NativeArray<Color>.get_IsCreated
	|-NativeArray<Color32>.get_IsCreated
	|-NativeArray<ContactPairHeader>.get_IsCreated
	|-NativeArray<ConvertMeshJobData>.get_IsCreated
	|-NativeArray<CopyClosingMeshJobData>.get_IsCreated
	|-NativeArray<CullingSplit>.get_IsCreated
	|-NativeArray<DrawBufferRange>.get_IsCreated
	|-NativeArray<GfxUpdateBufferRange>.get_IsCreated
	|-NativeArray<int>.get_IsCreated
	|-NativeArray<JobHandle>.get_IsCreated
	|-NativeArray<LightDataGI>.get_IsCreated
	|-NativeArray<Matrix4x4>.get_IsCreated
	|-NativeArray<ModifiableContactPair>.get_IsCreated
	|-NativeArray<NudgeJobData>.get_IsCreated
	|-NativeArray<Plane>.get_IsCreated
	|-NativeArray<Quaternion>.get_IsCreated
	|-NativeArray<TileData>.get_IsCreated
	|-NativeArray<Transform3x4>.get_IsCreated
	|-NativeArray<ushort>.get_IsCreated
	|-NativeArray<Vector3>.get_IsCreated
	|-NativeArray<Vector3Int>.get_IsCreated
	|-NativeArray<Vector4>.get_IsCreated
	|-NativeArray<Vertex>.get_IsCreated
	|-NativeArray<VertexAttributeDescriptor>.get_IsCreated
	|-NativeArray<__Il2CppFullySharedGenericStructType>.get_IsCreated
	|-NativeArray<ParticleSystem.Particle>.get_IsCreated
	*/

	[WriteAccessRequired]
	// RVA: -1 Offset: -1 Slot: 4
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x146E480 Offset: 0x146D680 VA: 0x18146E480
	|-NativeArray<BatchCullingOutputDrawCommands>.Dispose
	|-NativeArray<BoneWeight1>.Dispose
	|-NativeArray<byte>.Dispose
	|-NativeArray<Color>.Dispose
	|-NativeArray<Color32>.Dispose
	|-NativeArray<ContactPairHeader>.Dispose
	|-NativeArray<ConvertMeshJobData>.Dispose
	|-NativeArray<CopyClosingMeshJobData>.Dispose
	|-NativeArray<CullingSplit>.Dispose
	|-NativeArray<DrawBufferRange>.Dispose
	|-NativeArray<GfxUpdateBufferRange>.Dispose
	|-NativeArray<int>.Dispose
	|-NativeArray<JobHandle>.Dispose
	|-NativeArray<LightDataGI>.Dispose
	|-NativeArray<Matrix4x4>.Dispose
	|-NativeArray<ModifiableContactPair>.Dispose
	|-NativeArray<NudgeJobData>.Dispose
	|-NativeArray<Plane>.Dispose
	|-NativeArray<Quaternion>.Dispose
	|-NativeArray<TileData>.Dispose
	|-NativeArray<Transform3x4>.Dispose
	|-NativeArray<ushort>.Dispose
	|-NativeArray<Vector3>.Dispose
	|-NativeArray<Vector3Int>.Dispose
	|-NativeArray<Vector4>.Dispose
	|-NativeArray<Vertex>.Dispose
	|-NativeArray<VertexAttributeDescriptor>.Dispose
	|-NativeArray<ParticleSystem.Particle>.Dispose
	|
	|-RVA: 0x147B2E0 Offset: 0x147A4E0 VA: 0x18147B2E0
	|-NativeArray<__Il2CppFullySharedGenericStructType>.Dispose
	*/

	// RVA: -1 Offset: -1
	public T[] ToArray() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14701F0 Offset: 0x146F3F0 VA: 0x1814701F0
	|-NativeArray<BatchCullingOutputDrawCommands>.ToArray
	|
	|-RVA: 0x1470730 Offset: 0x146F930 VA: 0x181470730
	|-NativeArray<BoneWeight1>.ToArray
	|
	|-RVA: 0x14700A0 Offset: 0x146F2A0 VA: 0x1814700A0
	|-NativeArray<byte>.ToArray
	|
	|-RVA: 0x146FCB0 Offset: 0x146EEB0 VA: 0x18146FCB0
	|-NativeArray<Color>.ToArray
	|-NativeArray<DrawBufferRange>.ToArray
	|-NativeArray<GfxUpdateBufferRange>.ToArray
	|-NativeArray<JobHandle>.ToArray
	|-NativeArray<Plane>.ToArray
	|-NativeArray<Quaternion>.ToArray
	|-NativeArray<Vector4>.ToArray
	|-NativeArray<VertexAttributeDescriptor>.ToArray
	|
	|-RVA: 0x146FE00 Offset: 0x146F000 VA: 0x18146FE00
	|-NativeArray<Color32>.ToArray
	|-NativeArray<int>.ToArray
	|
	|-RVA: 0x1470490 Offset: 0x146F690 VA: 0x181470490
	|-NativeArray<ContactPairHeader>.ToArray
	|
	|-RVA: 0x1470340 Offset: 0x146F540 VA: 0x181470340
	|-NativeArray<ConvertMeshJobData>.ToArray
	|
	|-RVA: 0x14705E0 Offset: 0x146F7E0 VA: 0x1814705E0
	|-NativeArray<CopyClosingMeshJobData>.ToArray
	|-NativeArray<Transform3x4>.ToArray
	|
	|-RVA: 0x146FF50 Offset: 0x146F150 VA: 0x18146FF50
	|-NativeArray<CullingSplit>.ToArray
	|-NativeArray<LightDataGI>.ToArray
	|-NativeArray<TileData>.ToArray
	|
	|-RVA: 0x147CC40 Offset: 0x147BE40 VA: 0x18147CC40
	|-NativeArray<Matrix4x4>.ToArray
	|-NativeArray<Vertex>.ToArray
	|
	|-RVA: 0x147C9A0 Offset: 0x147BBA0 VA: 0x18147C9A0
	|-NativeArray<ModifiableContactPair>.ToArray
	|
	|-RVA: 0x147CEE0 Offset: 0x147C0E0 VA: 0x18147CEE0
	|-NativeArray<NudgeJobData>.ToArray
	|
	|-RVA: 0x147D1A0 Offset: 0x147C3A0 VA: 0x18147D1A0
	|-NativeArray<ushort>.ToArray
	|
	|-RVA: 0x147CAF0 Offset: 0x147BCF0 VA: 0x18147CAF0
	|-NativeArray<Vector3>.ToArray
	|-NativeArray<Vector3Int>.ToArray
	|
	|-RVA: 0x147D030 Offset: 0x147C230 VA: 0x18147D030
	|-NativeArray<__Il2CppFullySharedGenericStructType>.ToArray
	|
	|-RVA: 0x147CD90 Offset: 0x147BF90 VA: 0x18147CD90
	|-NativeArray<ParticleSystem.Particle>.ToArray
	*/

	// RVA: -1 Offset: -1
	public NativeArray.Enumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x146E750 Offset: 0x146D950 VA: 0x18146E750
	|-NativeArray<BatchCullingOutputDrawCommands>.GetEnumerator
	|
	|-RVA: 0x146E6D0 Offset: 0x146D8D0 VA: 0x18146E6D0
	|-NativeArray<BoneWeight1>.GetEnumerator
	|
	|-RVA: 0x146EBD0 Offset: 0x146DDD0 VA: 0x18146EBD0
	|-NativeArray<byte>.GetEnumerator
	|
	|-RVA: 0x146E640 Offset: 0x146D840 VA: 0x18146E640
	|-NativeArray<Color>.GetEnumerator
	|-NativeArray<DrawBufferRange>.GetEnumerator
	|-NativeArray<Plane>.GetEnumerator
	|-NativeArray<Quaternion>.GetEnumerator
	|-NativeArray<Vector4>.GetEnumerator
	|-NativeArray<VertexAttributeDescriptor>.GetEnumerator
	|
	|-RVA: 0x146EC50 Offset: 0x146DE50 VA: 0x18146EC50
	|-NativeArray<Color32>.GetEnumerator
	|-NativeArray<int>.GetEnumerator
	|
	|-RVA: 0x146E9A0 Offset: 0x146DBA0 VA: 0x18146E9A0
	|-NativeArray<ContactPairHeader>.GetEnumerator
	|
	|-RVA: 0x146E800 Offset: 0x146DA00 VA: 0x18146E800
	|-NativeArray<ConvertMeshJobData>.GetEnumerator
	|
	|-RVA: 0x146E8F0 Offset: 0x146DAF0 VA: 0x18146E8F0
	|-NativeArray<CopyClosingMeshJobData>.GetEnumerator
	|
	|-RVA: 0x146EA40 Offset: 0x146DC40 VA: 0x18146EA40
	|-NativeArray<CullingSplit>.GetEnumerator
	|-NativeArray<LightDataGI>.GetEnumerator
	|-NativeArray<TileData>.GetEnumerator
	|
	|-RVA: 0x146EB40 Offset: 0x146DD40 VA: 0x18146EB40
	|-NativeArray<GfxUpdateBufferRange>.GetEnumerator
	|-NativeArray<JobHandle>.GetEnumerator
	|
	|-RVA: 0x147B850 Offset: 0x147AA50 VA: 0x18147B850
	|-NativeArray<Matrix4x4>.GetEnumerator
	|-NativeArray<Vertex>.GetEnumerator
	|
	|-RVA: 0x147B630 Offset: 0x147A830 VA: 0x18147B630
	|-NativeArray<ModifiableContactPair>.GetEnumerator
	|
	|-RVA: 0x147B920 Offset: 0x147AB20 VA: 0x18147B920
	|-NativeArray<NudgeJobData>.GetEnumerator
	|
	|-RVA: 0x147B580 Offset: 0x147A780 VA: 0x18147B580
	|-NativeArray<Transform3x4>.GetEnumerator
	|
	|-RVA: 0x147BA30 Offset: 0x147AC30 VA: 0x18147BA30
	|-NativeArray<ushort>.GetEnumerator
	|
	|-RVA: 0x147B500 Offset: 0x147A700 VA: 0x18147B500
	|-NativeArray<Vector3>.GetEnumerator
	|-NativeArray<Vector3Int>.GetEnumerator
	|
	|-RVA: 0x147BAB0 Offset: 0x147ACB0 VA: 0x18147BAB0
	|-NativeArray<__Il2CppFullySharedGenericStructType>.GetEnumerator
	|
	|-RVA: 0x147B720 Offset: 0x147A920 VA: 0x18147B720
	|-NativeArray<ParticleSystem.Particle>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x146EEB0 Offset: 0x146E0B0 VA: 0x18146EEB0
	|-NativeArray<BatchCullingOutputDrawCommands>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x146F180 Offset: 0x146E380 VA: 0x18146F180
	|-NativeArray<BoneWeight1>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x146F040 Offset: 0x146E240 VA: 0x18146F040
	|-NativeArray<byte>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x146F300 Offset: 0x146E500 VA: 0x18146F300
	|-NativeArray<Color>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeArray<DrawBufferRange>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeArray<Plane>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeArray<Quaternion>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeArray<Vector4>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeArray<VertexAttributeDescriptor>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x146F0E0 Offset: 0x146E2E0 VA: 0x18146F0E0
	|-NativeArray<Color32>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeArray<int>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x146EDE0 Offset: 0x146DFE0 VA: 0x18146EDE0
	|-NativeArray<ContactPairHeader>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x146F3B0 Offset: 0x146E5B0 VA: 0x18146F3B0
	|-NativeArray<ConvertMeshJobData>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x146F220 Offset: 0x146E420 VA: 0x18146F220
	|-NativeArray<CopyClosingMeshJobData>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x146ECE0 Offset: 0x146DEE0 VA: 0x18146ECE0
	|-NativeArray<CullingSplit>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeArray<LightDataGI>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeArray<TileData>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x146EF90 Offset: 0x146E190 VA: 0x18146EF90
	|-NativeArray<GfxUpdateBufferRange>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeArray<JobHandle>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x147C050 Offset: 0x147B250 VA: 0x18147C050
	|-NativeArray<Matrix4x4>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeArray<Vertex>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x147BCB0 Offset: 0x147AEB0 VA: 0x18147BCB0
	|-NativeArray<ModifiableContactPair>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x147C1F0 Offset: 0x147B3F0 VA: 0x18147C1F0
	|-NativeArray<NudgeJobData>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x147BBD0 Offset: 0x147ADD0 VA: 0x18147BBD0
	|-NativeArray<Transform3x4>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x147BFB0 Offset: 0x147B1B0 VA: 0x18147BFB0
	|-NativeArray<ushort>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x147C150 Offset: 0x147B350 VA: 0x18147C150
	|-NativeArray<Vector3>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeArray<Vector3Int>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x147BDB0 Offset: 0x147AFB0 VA: 0x18147BDB0
	|-NativeArray<__Il2CppFullySharedGenericStructType>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x147BE90 Offset: 0x147B090 VA: 0x18147BE90
	|-NativeArray<ParticleSystem.Particle>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x146F9A0 Offset: 0x146EBA0 VA: 0x18146F9A0
	|-NativeArray<BatchCullingOutputDrawCommands>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x146F8E0 Offset: 0x146EAE0 VA: 0x18146F8E0
	|-NativeArray<BoneWeight1>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x146F730 Offset: 0x146E930 VA: 0x18146F730
	|-NativeArray<byte>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x146F590 Offset: 0x146E790 VA: 0x18146F590
	|-NativeArray<Color>.System.Collections.IEnumerable.GetEnumerator
	|-NativeArray<DrawBufferRange>.System.Collections.IEnumerable.GetEnumerator
	|-NativeArray<Plane>.System.Collections.IEnumerable.GetEnumerator
	|-NativeArray<Quaternion>.System.Collections.IEnumerable.GetEnumerator
	|-NativeArray<Vector4>.System.Collections.IEnumerable.GetEnumerator
	|-NativeArray<VertexAttributeDescriptor>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x146FBF0 Offset: 0x146EDF0 VA: 0x18146FBF0
	|-NativeArray<Color32>.System.Collections.IEnumerable.GetEnumerator
	|-NativeArray<int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x146FB00 Offset: 0x146ED00 VA: 0x18146FB00
	|-NativeArray<ContactPairHeader>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x146F7F0 Offset: 0x146E9F0 VA: 0x18146F7F0
	|-NativeArray<ConvertMeshJobData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x146FA50 Offset: 0x146EC50 VA: 0x18146FA50
	|-NativeArray<CopyClosingMeshJobData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x146F4C0 Offset: 0x146E6C0 VA: 0x18146F4C0
	|-NativeArray<CullingSplit>.System.Collections.IEnumerable.GetEnumerator
	|-NativeArray<LightDataGI>.System.Collections.IEnumerable.GetEnumerator
	|-NativeArray<TileData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x146F660 Offset: 0x146E860 VA: 0x18146F660
	|-NativeArray<GfxUpdateBufferRange>.System.Collections.IEnumerable.GetEnumerator
	|-NativeArray<JobHandle>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x147C490 Offset: 0x147B690 VA: 0x18147C490
	|-NativeArray<Matrix4x4>.System.Collections.IEnumerable.GetEnumerator
	|-NativeArray<Vertex>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x147C810 Offset: 0x147BA10 VA: 0x18147C810
	|-NativeArray<ModifiableContactPair>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x147C3B0 Offset: 0x147B5B0 VA: 0x18147C3B0
	|-NativeArray<NudgeJobData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x147C300 Offset: 0x147B500 VA: 0x18147C300
	|-NativeArray<Transform3x4>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x147C550 Offset: 0x147B750 VA: 0x18147C550
	|-NativeArray<ushort>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x147C8E0 Offset: 0x147BAE0 VA: 0x18147C8E0
	|-NativeArray<Vector3>.System.Collections.IEnumerable.GetEnumerator
	|-NativeArray<Vector3Int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x147C610 Offset: 0x147B810 VA: 0x18147C610
	|-NativeArray<__Il2CppFullySharedGenericStructType>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x147C720 Offset: 0x147B920 VA: 0x18147C720
	|-NativeArray<ParticleSystem.Particle>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public bool Equals(NativeArray<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x146E520 Offset: 0x146D720 VA: 0x18146E520
	|-NativeArray<BatchCullingOutputDrawCommands>.Equals
	|-NativeArray<BoneWeight1>.Equals
	|-NativeArray<byte>.Equals
	|-NativeArray<Color>.Equals
	|-NativeArray<Color32>.Equals
	|-NativeArray<ContactPairHeader>.Equals
	|-NativeArray<ConvertMeshJobData>.Equals
	|-NativeArray<CopyClosingMeshJobData>.Equals
	|-NativeArray<CullingSplit>.Equals
	|-NativeArray<DrawBufferRange>.Equals
	|-NativeArray<GfxUpdateBufferRange>.Equals
	|-NativeArray<int>.Equals
	|-NativeArray<JobHandle>.Equals
	|-NativeArray<LightDataGI>.Equals
	|-NativeArray<Matrix4x4>.Equals
	|-NativeArray<ModifiableContactPair>.Equals
	|-NativeArray<NudgeJobData>.Equals
	|-NativeArray<Plane>.Equals
	|-NativeArray<Quaternion>.Equals
	|-NativeArray<TileData>.Equals
	|-NativeArray<Transform3x4>.Equals
	|-NativeArray<ushort>.Equals
	|-NativeArray<Vector3>.Equals
	|-NativeArray<Vector3Int>.Equals
	|-NativeArray<Vector4>.Equals
	|-NativeArray<Vertex>.Equals
	|-NativeArray<VertexAttributeDescriptor>.Equals
	|-NativeArray<__Il2CppFullySharedGenericStructType>.Equals
	|-NativeArray<ParticleSystem.Particle>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x146E540 Offset: 0x146D740 VA: 0x18146E540
	|-NativeArray<BatchCullingOutputDrawCommands>.Equals
	|-NativeArray<BoneWeight1>.Equals
	|-NativeArray<byte>.Equals
	|-NativeArray<Color>.Equals
	|-NativeArray<Color32>.Equals
	|-NativeArray<ContactPairHeader>.Equals
	|-NativeArray<ConvertMeshJobData>.Equals
	|-NativeArray<CopyClosingMeshJobData>.Equals
	|-NativeArray<CullingSplit>.Equals
	|-NativeArray<DrawBufferRange>.Equals
	|-NativeArray<GfxUpdateBufferRange>.Equals
	|-NativeArray<int>.Equals
	|-NativeArray<JobHandle>.Equals
	|-NativeArray<LightDataGI>.Equals
	|-NativeArray<Matrix4x4>.Equals
	|-NativeArray<ModifiableContactPair>.Equals
	|-NativeArray<NudgeJobData>.Equals
	|-NativeArray<Plane>.Equals
	|-NativeArray<Quaternion>.Equals
	|-NativeArray<TileData>.Equals
	|-NativeArray<Transform3x4>.Equals
	|-NativeArray<ushort>.Equals
	|-NativeArray<Vector3>.Equals
	|-NativeArray<Vector3Int>.Equals
	|-NativeArray<Vector4>.Equals
	|-NativeArray<Vertex>.Equals
	|-NativeArray<VertexAttributeDescriptor>.Equals
	|-NativeArray<ParticleSystem.Particle>.Equals
	|
	|-RVA: 0x147B3B0 Offset: 0x147A5B0 VA: 0x18147B3B0
	|-NativeArray<__Il2CppFullySharedGenericStructType>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x146ECD0 Offset: 0x146DED0 VA: 0x18146ECD0
	|-NativeArray<BatchCullingOutputDrawCommands>.GetHashCode
	|-NativeArray<BoneWeight1>.GetHashCode
	|-NativeArray<byte>.GetHashCode
	|-NativeArray<Color>.GetHashCode
	|-NativeArray<Color32>.GetHashCode
	|-NativeArray<ContactPairHeader>.GetHashCode
	|-NativeArray<ConvertMeshJobData>.GetHashCode
	|-NativeArray<CopyClosingMeshJobData>.GetHashCode
	|-NativeArray<CullingSplit>.GetHashCode
	|-NativeArray<DrawBufferRange>.GetHashCode
	|-NativeArray<GfxUpdateBufferRange>.GetHashCode
	|-NativeArray<int>.GetHashCode
	|-NativeArray<JobHandle>.GetHashCode
	|-NativeArray<LightDataGI>.GetHashCode
	|-NativeArray<Matrix4x4>.GetHashCode
	|-NativeArray<ModifiableContactPair>.GetHashCode
	|-NativeArray<NudgeJobData>.GetHashCode
	|-NativeArray<Plane>.GetHashCode
	|-NativeArray<Quaternion>.GetHashCode
	|-NativeArray<TileData>.GetHashCode
	|-NativeArray<Transform3x4>.GetHashCode
	|-NativeArray<ushort>.GetHashCode
	|-NativeArray<Vector3>.GetHashCode
	|-NativeArray<Vector3Int>.GetHashCode
	|-NativeArray<Vector4>.GetHashCode
	|-NativeArray<Vertex>.GetHashCode
	|-NativeArray<VertexAttributeDescriptor>.GetHashCode
	|-NativeArray<__Il2CppFullySharedGenericStructType>.GetHashCode
	|-NativeArray<ParticleSystem.Particle>.GetHashCode
	*/

	// RVA: -1 Offset: -1
	public static void Copy(T[] src, NativeArray<T> dst) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x146D270 Offset: 0x146C470 VA: 0x18146D270
	|-NativeArray<BatchCullingOutputDrawCommands>.Copy
	|
	|-RVA: 0x146D360 Offset: 0x146C560 VA: 0x18146D360
	|-NativeArray<BoneWeight1>.Copy
	|
	|-RVA: 0x146E1F0 Offset: 0x146D3F0 VA: 0x18146E1F0
	|-NativeArray<byte>.Copy
	|
	|-RVA: 0x146D8A0 Offset: 0x146CAA0 VA: 0x18146D8A0
	|-NativeArray<Color>.Copy
	|-NativeArray<DrawBufferRange>.Copy
	|-NativeArray<GfxUpdateBufferRange>.Copy
	|-NativeArray<JobHandle>.Copy
	|-NativeArray<Plane>.Copy
	|-NativeArray<Quaternion>.Copy
	|-NativeArray<Vector4>.Copy
	|-NativeArray<VertexAttributeDescriptor>.Copy
	|
	|-RVA: 0x146D180 Offset: 0x146C380 VA: 0x18146D180
	|-NativeArray<Color32>.Copy
	|-NativeArray<int>.Copy
	|
	|-RVA: 0x146DA70 Offset: 0x146CC70 VA: 0x18146DA70
	|-NativeArray<ContactPairHeader>.Copy
	|
	|-RVA: 0x146D6D0 Offset: 0x146C8D0 VA: 0x18146D6D0
	|-NativeArray<ConvertMeshJobData>.Copy
	|
	|-RVA: 0x146E2E0 Offset: 0x146D4E0 VA: 0x18146E2E0
	|-NativeArray<CopyClosingMeshJobData>.Copy
	|-NativeArray<Transform3x4>.Copy
	|
	|-RVA: 0x146D5E0 Offset: 0x146C7E0 VA: 0x18146D5E0
	|-NativeArray<CullingSplit>.Copy
	|-NativeArray<LightDataGI>.Copy
	|-NativeArray<TileData>.Copy
	|
	|-RVA: 0x147A7D0 Offset: 0x14799D0 VA: 0x18147A7D0
	|-NativeArray<Matrix4x4>.Copy
	|-NativeArray<Vertex>.Copy
	|
	|-RVA: 0x147A600 Offset: 0x1479800 VA: 0x18147A600
	|-NativeArray<ModifiableContactPair>.Copy
	|
	|-RVA: 0x147A1F0 Offset: 0x14793F0 VA: 0x18147A1F0
	|-NativeArray<NudgeJobData>.Copy
	|
	|-RVA: 0x147AC80 Offset: 0x1479E80 VA: 0x18147AC80
	|-NativeArray<ushort>.Copy
	|
	|-RVA: 0x147A380 Offset: 0x1479580 VA: 0x18147A380
	|-NativeArray<Vector3>.Copy
	|-NativeArray<Vector3Int>.Copy
	|
	|-RVA: 0x147A550 Offset: 0x1479750 VA: 0x18147A550
	|-NativeArray<__Il2CppFullySharedGenericStructType>.Copy
	|
	|-RVA: 0x147AFB0 Offset: 0x147A1B0 VA: 0x18147AFB0
	|-NativeArray<ParticleSystem.Particle>.Copy
	*/

	// RVA: -1 Offset: -1
	public static void Copy(NativeArray<T> src, NativeArray<T> dst, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x146CF80 Offset: 0x146C180 VA: 0x18146CF80
	|-NativeArray<BatchCullingOutputDrawCommands>.Copy
	|
	|-RVA: 0x146CED0 Offset: 0x146C0D0 VA: 0x18146CED0
	|-NativeArray<BoneWeight1>.Copy
	|
	|-RVA: 0x146CE30 Offset: 0x146C030 VA: 0x18146CE30
	|-NativeArray<byte>.Copy
	|
	|-RVA: 0x146DD20 Offset: 0x146CF20 VA: 0x18146DD20
	|-NativeArray<Color>.Copy
	|-NativeArray<DrawBufferRange>.Copy
	|-NativeArray<GfxUpdateBufferRange>.Copy
	|-NativeArray<JobHandle>.Copy
	|-NativeArray<Plane>.Copy
	|-NativeArray<Quaternion>.Copy
	|-NativeArray<Vector4>.Copy
	|-NativeArray<VertexAttributeDescriptor>.Copy
	|
	|-RVA: 0x146DDC0 Offset: 0x146CFC0 VA: 0x18146DDC0
	|-NativeArray<Color32>.Copy
	|-NativeArray<int>.Copy
	|
	|-RVA: 0x146D530 Offset: 0x146C730 VA: 0x18146D530
	|-NativeArray<ContactPairHeader>.Copy
	|
	|-RVA: 0x146E3D0 Offset: 0x146D5D0 VA: 0x18146E3D0
	|-NativeArray<ConvertMeshJobData>.Copy
	|
	|-RVA: 0x146D020 Offset: 0x146C220 VA: 0x18146D020
	|-NativeArray<CopyClosingMeshJobData>.Copy
	|-NativeArray<Transform3x4>.Copy
	|
	|-RVA: 0x146D0D0 Offset: 0x146C2D0 VA: 0x18146D0D0
	|-NativeArray<CullingSplit>.Copy
	|-NativeArray<LightDataGI>.Copy
	|-NativeArray<TileData>.Copy
	|
	|-RVA: 0x147ABE0 Offset: 0x1479DE0 VA: 0x18147ABE0
	|-NativeArray<Matrix4x4>.Copy
	|-NativeArray<Vertex>.Copy
	|
	|-RVA: 0x147A2E0 Offset: 0x14794E0 VA: 0x18147A2E0
	|-NativeArray<ModifiableContactPair>.Copy
	|
	|-RVA: 0x147AD70 Offset: 0x1479F70 VA: 0x18147AD70
	|-NativeArray<NudgeJobData>.Copy
	|
	|-RVA: 0x147B230 Offset: 0x147A430 VA: 0x18147B230
	|-NativeArray<ushort>.Copy
	|
	|-RVA: 0x147A9A0 Offset: 0x1479BA0 VA: 0x18147A9A0
	|-NativeArray<Vector3>.Copy
	|-NativeArray<Vector3Int>.Copy
	|
	|-RVA: 0x147AEF0 Offset: 0x147A0F0 VA: 0x18147AEF0
	|-NativeArray<__Il2CppFullySharedGenericStructType>.Copy
	|
	|-RVA: 0x147B180 Offset: 0x147A380 VA: 0x18147B180
	|-NativeArray<ParticleSystem.Particle>.Copy
	*/

	// RVA: -1 Offset: -1
	public static void Copy(NativeArray<T> src, T[] dst, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x146D7C0 Offset: 0x146C9C0 VA: 0x18146D7C0
	|-NativeArray<BatchCullingOutputDrawCommands>.Copy
	|
	|-RVA: 0x146D450 Offset: 0x146C650 VA: 0x18146D450
	|-NativeArray<BoneWeight1>.Copy
	|
	|-RVA: 0x146DB60 Offset: 0x146CD60 VA: 0x18146DB60
	|-NativeArray<byte>.Copy
	|
	|-RVA: 0x146DE70 Offset: 0x146D070 VA: 0x18146DE70
	|-NativeArray<Color>.Copy
	|-NativeArray<DrawBufferRange>.Copy
	|-NativeArray<GfxUpdateBufferRange>.Copy
	|-NativeArray<JobHandle>.Copy
	|-NativeArray<Plane>.Copy
	|-NativeArray<Quaternion>.Copy
	|-NativeArray<Vector4>.Copy
	|-NativeArray<VertexAttributeDescriptor>.Copy
	|
	|-RVA: 0x146D990 Offset: 0x146CB90 VA: 0x18146D990
	|-NativeArray<Color32>.Copy
	|-NativeArray<int>.Copy
	|
	|-RVA: 0x146E030 Offset: 0x146D230 VA: 0x18146E030
	|-NativeArray<ContactPairHeader>.Copy
	|
	|-RVA: 0x146DF50 Offset: 0x146D150 VA: 0x18146DF50
	|-NativeArray<ConvertMeshJobData>.Copy
	|
	|-RVA: 0x146E110 Offset: 0x146D310 VA: 0x18146E110
	|-NativeArray<CopyClosingMeshJobData>.Copy
	|-NativeArray<Transform3x4>.Copy
	|
	|-RVA: 0x146DC40 Offset: 0x146CE40 VA: 0x18146DC40
	|-NativeArray<CullingSplit>.Copy
	|-NativeArray<LightDataGI>.Copy
	|-NativeArray<TileData>.Copy
	|
	|-RVA: 0x147AE10 Offset: 0x147A010 VA: 0x18147AE10
	|-NativeArray<Matrix4x4>.Copy
	|-NativeArray<Vertex>.Copy
	|
	|-RVA: 0x147B0A0 Offset: 0x147A2A0 VA: 0x18147B0A0
	|-NativeArray<ModifiableContactPair>.Copy
	|
	|-RVA: 0x147A470 Offset: 0x1479670 VA: 0x18147A470
	|-NativeArray<NudgeJobData>.Copy
	|
	|-RVA: 0x147A8C0 Offset: 0x1479AC0 VA: 0x18147A8C0
	|-NativeArray<ushort>.Copy
	|
	|-RVA: 0x147A6F0 Offset: 0x14798F0 VA: 0x18147A6F0
	|-NativeArray<Vector3>.Copy
	|-NativeArray<Vector3Int>.Copy
	|
	|-RVA: 0x147AB30 Offset: 0x1479D30 VA: 0x18147AB30
	|-NativeArray<__Il2CppFullySharedGenericStructType>.Copy
	|
	|-RVA: 0x147AA50 Offset: 0x1479C50 VA: 0x18147AA50
	|-NativeArray<ParticleSystem.Particle>.Copy
	*/

	// RVA: -1 Offset: -1
	private static void CopySafe(NativeArray<T> src, int srcIndex, NativeArray<T> dst, int dstIndex, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x146CA70 Offset: 0x146BC70 VA: 0x18146CA70
	|-NativeArray<BatchCullingOutputDrawCommands>.CopySafe
	|
	|-RVA: 0x146BB90 Offset: 0x146AD90 VA: 0x18146BB90
	|-NativeArray<BoneWeight1>.CopySafe
	|
	|-RVA: 0x146BE90 Offset: 0x146B090 VA: 0x18146BE90
	|-NativeArray<byte>.CopySafe
	|
	|-RVA: 0x146BD20 Offset: 0x146AF20 VA: 0x18146BD20
	|-NativeArray<Color>.CopySafe
	|-NativeArray<DrawBufferRange>.CopySafe
	|-NativeArray<GfxUpdateBufferRange>.CopySafe
	|-NativeArray<JobHandle>.CopySafe
	|-NativeArray<Plane>.CopySafe
	|-NativeArray<Quaternion>.CopySafe
	|-NativeArray<Vector4>.CopySafe
	|-NativeArray<VertexAttributeDescriptor>.CopySafe
	|
	|-RVA: 0x146CCB0 Offset: 0x146BEB0 VA: 0x18146CCB0
	|-NativeArray<Color32>.CopySafe
	|-NativeArray<int>.CopySafe
	|
	|-RVA: 0x146C830 Offset: 0x146BA30 VA: 0x18146C830
	|-NativeArray<ContactPairHeader>.CopySafe
	|
	|-RVA: 0x146C6A0 Offset: 0x146B8A0 VA: 0x18146C6A0
	|-NativeArray<ConvertMeshJobData>.CopySafe
	|
	|-RVA: 0x146C290 Offset: 0x146B490 VA: 0x18146C290
	|-NativeArray<CopyClosingMeshJobData>.CopySafe
	|-NativeArray<Transform3x4>.CopySafe
	|
	|-RVA: 0x146C8E0 Offset: 0x146BAE0 VA: 0x18146C8E0
	|-NativeArray<CullingSplit>.CopySafe
	|-NativeArray<LightDataGI>.CopySafe
	|-NativeArray<TileData>.CopySafe
	|
	|-RVA: 0x14795E0 Offset: 0x14787E0 VA: 0x1814795E0
	|-NativeArray<Matrix4x4>.CopySafe
	|-NativeArray<Vertex>.CopySafe
	|
	|-RVA: 0x1479FB0 Offset: 0x14791B0 VA: 0x181479FB0
	|-NativeArray<ModifiableContactPair>.CopySafe
	|
	|-RVA: 0x14793C0 Offset: 0x14785C0 VA: 0x1814793C0
	|-NativeArray<NudgeJobData>.CopySafe
	|
	|-RVA: 0x1479C40 Offset: 0x1478E40 VA: 0x181479C40
	|-NativeArray<ushort>.CopySafe
	|
	|-RVA: 0x1479090 Offset: 0x1478290 VA: 0x181479090
	|-NativeArray<Vector3>.CopySafe
	|-NativeArray<Vector3Int>.CopySafe
	|
	|-RVA: 0x1479CE0 Offset: 0x1478EE0 VA: 0x181479CE0
	|-NativeArray<__Il2CppFullySharedGenericStructType>.CopySafe
	|
	|-RVA: 0x1478FE0 Offset: 0x14781E0 VA: 0x181478FE0
	|-NativeArray<ParticleSystem.Particle>.CopySafe
	*/

	// RVA: -1 Offset: -1
	private static void CopySafe(T[] src, int srcIndex, NativeArray<T> dst, int dstIndex, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x146CBE0 Offset: 0x146BDE0 VA: 0x18146CBE0
	|-NativeArray<BatchCullingOutputDrawCommands>.CopySafe
	|
	|-RVA: 0x146C010 Offset: 0x146B210 VA: 0x18146C010
	|-NativeArray<BoneWeight1>.CopySafe
	|
	|-RVA: 0x146C340 Offset: 0x146B540 VA: 0x18146C340
	|-NativeArray<byte>.CopySafe
	|
	|-RVA: 0x146C1C0 Offset: 0x146B3C0 VA: 0x18146C1C0
	|-NativeArray<Color>.CopySafe
	|-NativeArray<DrawBufferRange>.CopySafe
	|-NativeArray<GfxUpdateBufferRange>.CopySafe
	|-NativeArray<JobHandle>.CopySafe
	|-NativeArray<Plane>.CopySafe
	|-NativeArray<Quaternion>.CopySafe
	|-NativeArray<Vector4>.CopySafe
	|-NativeArray<VertexAttributeDescriptor>.CopySafe
	|
	|-RVA: 0x146C4E0 Offset: 0x146B6E0 VA: 0x18146C4E0
	|-NativeArray<Color32>.CopySafe
	|-NativeArray<int>.CopySafe
	|
	|-RVA: 0x146C990 Offset: 0x146BB90 VA: 0x18146C990
	|-NativeArray<ContactPairHeader>.CopySafe
	|
	|-RVA: 0x146CB10 Offset: 0x146BD10 VA: 0x18146CB10
	|-NativeArray<ConvertMeshJobData>.CopySafe
	|
	|-RVA: 0x146B9D0 Offset: 0x146ABD0 VA: 0x18146B9D0
	|-NativeArray<CopyClosingMeshJobData>.CopySafe
	|-NativeArray<Transform3x4>.CopySafe
	|
	|-RVA: 0x146BC40 Offset: 0x146AE40 VA: 0x18146BC40
	|-NativeArray<CullingSplit>.CopySafe
	|-NativeArray<LightDataGI>.CopySafe
	|-NativeArray<TileData>.CopySafe
	|
	|-RVA: 0x1479680 Offset: 0x1478880 VA: 0x181479680
	|-NativeArray<Matrix4x4>.CopySafe
	|-NativeArray<Vertex>.CopySafe
	|
	|-RVA: 0x1479A90 Offset: 0x1478C90 VA: 0x181479A90
	|-NativeArray<ModifiableContactPair>.CopySafe
	|
	|-RVA: 0x14798F0 Offset: 0x1478AF0 VA: 0x1814798F0
	|-NativeArray<NudgeJobData>.CopySafe
	|
	|-RVA: 0x1479140 Offset: 0x1478340 VA: 0x181479140
	|-NativeArray<ushort>.CopySafe
	|
	|-RVA: 0x1479B60 Offset: 0x1478D60 VA: 0x181479B60
	|-NativeArray<Vector3>.CopySafe
	|-NativeArray<Vector3Int>.CopySafe
	|
	|-RVA: 0x1479E30 Offset: 0x1479030 VA: 0x181479E30
	|-NativeArray<__Il2CppFullySharedGenericStructType>.CopySafe
	|
	|-RVA: 0x147A050 Offset: 0x1479250 VA: 0x18147A050
	|-NativeArray<ParticleSystem.Particle>.CopySafe
	*/

	// RVA: -1 Offset: -1
	private static void CopySafe(NativeArray<T> src, int srcIndex, T[] dst, int dstIndex, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x146CD60 Offset: 0x146BF60 VA: 0x18146CD60
	|-NativeArray<BatchCullingOutputDrawCommands>.CopySafe
	|
	|-RVA: 0x146BF30 Offset: 0x146B130 VA: 0x18146BF30
	|-NativeArray<BoneWeight1>.CopySafe
	|
	|-RVA: 0x146B910 Offset: 0x146AB10 VA: 0x18146B910
	|-NativeArray<byte>.CopySafe
	|
	|-RVA: 0x146BDC0 Offset: 0x146AFC0 VA: 0x18146BDC0
	|-NativeArray<Color>.CopySafe
	|-NativeArray<DrawBufferRange>.CopySafe
	|-NativeArray<GfxUpdateBufferRange>.CopySafe
	|-NativeArray<JobHandle>.CopySafe
	|-NativeArray<Plane>.CopySafe
	|-NativeArray<Quaternion>.CopySafe
	|-NativeArray<Vector4>.CopySafe
	|-NativeArray<VertexAttributeDescriptor>.CopySafe
	|
	|-RVA: 0x146C750 Offset: 0x146B950 VA: 0x18146C750
	|-NativeArray<Color32>.CopySafe
	|-NativeArray<int>.CopySafe
	|
	|-RVA: 0x146BAB0 Offset: 0x146ACB0 VA: 0x18146BAB0
	|-NativeArray<ContactPairHeader>.CopySafe
	|
	|-RVA: 0x146C0F0 Offset: 0x146B2F0 VA: 0x18146C0F0
	|-NativeArray<ConvertMeshJobData>.CopySafe
	|
	|-RVA: 0x146C400 Offset: 0x146B600 VA: 0x18146C400
	|-NativeArray<CopyClosingMeshJobData>.CopySafe
	|-NativeArray<Transform3x4>.CopySafe
	|
	|-RVA: 0x146C5C0 Offset: 0x146B7C0 VA: 0x18146C5C0
	|-NativeArray<CullingSplit>.CopySafe
	|-NativeArray<LightDataGI>.CopySafe
	|-NativeArray<TileData>.CopySafe
	|
	|-RVA: 0x14799C0 Offset: 0x1478BC0 VA: 0x1814799C0
	|-NativeArray<Matrix4x4>.CopySafe
	|-NativeArray<Vertex>.CopySafe
	|
	|-RVA: 0x1479210 Offset: 0x1478410 VA: 0x181479210
	|-NativeArray<ModifiableContactPair>.CopySafe
	|
	|-RVA: 0x1479820 Offset: 0x1478A20 VA: 0x181479820
	|-NativeArray<NudgeJobData>.CopySafe
	|
	|-RVA: 0x1479750 Offset: 0x1478950 VA: 0x181479750
	|-NativeArray<ushort>.CopySafe
	|
	|-RVA: 0x14792E0 Offset: 0x14784E0 VA: 0x1814792E0
	|-NativeArray<Vector3>.CopySafe
	|-NativeArray<Vector3Int>.CopySafe
	|
	|-RVA: 0x1479460 Offset: 0x1478660 VA: 0x181479460
	|-NativeArray<__Il2CppFullySharedGenericStructType>.CopySafe
	|
	|-RVA: 0x147A120 Offset: 0x1479320 VA: 0x18147A120
	|-NativeArray<ParticleSystem.Particle>.CopySafe
	*/

	// RVA: -1 Offset: -1
	public NativeArray.ReadOnly<T> AsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x146B890 Offset: 0x146AA90 VA: 0x18146B890
	|-NativeArray<BatchCullingOutputDrawCommands>.AsReadOnly
	|-NativeArray<BoneWeight1>.AsReadOnly
	|-NativeArray<byte>.AsReadOnly
	|-NativeArray<Color>.AsReadOnly
	|-NativeArray<Color32>.AsReadOnly
	|-NativeArray<ContactPairHeader>.AsReadOnly
	|-NativeArray<ConvertMeshJobData>.AsReadOnly
	|-NativeArray<CopyClosingMeshJobData>.AsReadOnly
	|-NativeArray<CullingSplit>.AsReadOnly
	|-NativeArray<DrawBufferRange>.AsReadOnly
	|-NativeArray<GfxUpdateBufferRange>.AsReadOnly
	|-NativeArray<int>.AsReadOnly
	|-NativeArray<JobHandle>.AsReadOnly
	|-NativeArray<LightDataGI>.AsReadOnly
	|-NativeArray<Matrix4x4>.AsReadOnly
	|-NativeArray<ModifiableContactPair>.AsReadOnly
	|-NativeArray<NudgeJobData>.AsReadOnly
	|-NativeArray<Plane>.AsReadOnly
	|-NativeArray<Quaternion>.AsReadOnly
	|-NativeArray<TileData>.AsReadOnly
	|-NativeArray<Transform3x4>.AsReadOnly
	|-NativeArray<ushort>.AsReadOnly
	|-NativeArray<Vector3>.AsReadOnly
	|-NativeArray<Vector3Int>.AsReadOnly
	|-NativeArray<Vector4>.AsReadOnly
	|-NativeArray<Vertex>.AsReadOnly
	|-NativeArray<VertexAttributeDescriptor>.AsReadOnly
	|-NativeArray<__Il2CppFullySharedGenericStructType>.AsReadOnly
	|-NativeArray<ParticleSystem.Particle>.AsReadOnly
	*/
}

// Namespace: Unity.Collections
[NativeContainer]
internal struct NativeArrayDispose // TypeDefIndex: 13901
{
	// Fields
	[NativeDisableUnsafePtrRestriction]
	internal void* m_Buffer; // 0x0
	internal Allocator m_AllocatorLabel; // 0x8

	// Methods

	// RVA: 0x246C350 Offset: 0x246B550 VA: 0x18246C350
	public void Dispose() { }
}

// Namespace: Unity.Collections
[NativeClass(null)]
internal struct NativeArrayDisposeJob : IJob // TypeDefIndex: 13902
{
	// Fields
	internal NativeArrayDispose Data; // 0x0

	// Methods

	// RVA: 0x246C350 Offset: 0x246B550 VA: 0x18246C350 Slot: 4
	public void Execute() { }

	[RequiredByNativeCode]
	// RVA: 0x246C3A0 Offset: 0x246B5A0 VA: 0x18246C3A0
	internal static void RegisterNativeArrayDisposeJobReflectionData() { }
}

// Namespace: Unity.Collections
internal sealed class NativeArrayDebugView<T> // TypeDefIndex: 13903
{}

// Namespace: Unity.Collections
internal sealed class NativeArrayReadOnlyDebugView<T> // TypeDefIndex: 13904
{}

// Namespace: Unity.Collections
[Extension]
public static class NativeSliceExtensions // TypeDefIndex: 13905
{
	// Methods

	[Extension]
	// RVA: -1 Offset: -1
	public static NativeSlice<T> Slice<T>(NativeArray<T> thisArray, int start, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA55390 Offset: 0xA54590 VA: 0x180A55390
	|-NativeSliceExtensions.Slice<ConvertMeshJobData>
	|
	|-RVA: 0xA55430 Offset: 0xA54630 VA: 0x180A55430
	|-NativeSliceExtensions.Slice<CopyClosingMeshJobData>
	|
	|-RVA: 0xA554D0 Offset: 0xA546D0 VA: 0x180A554D0
	|-NativeSliceExtensions.Slice<GfxUpdateBufferRange>
	|-NativeSliceExtensions.Slice<JobHandle>
	|
	|-RVA: 0xA556B0 Offset: 0xA548B0 VA: 0x180A556B0
	|-NativeSliceExtensions.Slice<NudgeJobData>
	|
	|-RVA: 0xA55750 Offset: 0xA54950 VA: 0x180A55750
	|-NativeSliceExtensions.Slice<ushort>
	|
	|-RVA: 0xA557F0 Offset: 0xA549F0 VA: 0x180A557F0
	|-NativeSliceExtensions.Slice<Vertex>
	|
	|-RVA: 0xA55610 Offset: 0xA54810 VA: 0x180A55610
	|-NativeSliceExtensions.Slice<__Il2CppFullySharedGenericStructType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static NativeSlice<T> Slice<T>(NativeSlice<T> thisSlice, int start, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA55570 Offset: 0xA54770 VA: 0x180A55570
	|-NativeSliceExtensions.Slice<ushort>
	|-NativeSliceExtensions.Slice<Vertex>
	|-NativeSliceExtensions.Slice<__Il2CppFullySharedGenericStructType>
	*/
}

// Namespace: 
[ExcludeFromDocs]
public struct NativeSlice.Enumerator<T> : IEnumerator<T>, IEnumerator, IDisposable // TypeDefIndex: 13906
{
	// Fields
	private NativeSlice<T> m_Array; // 0x0
	private int m_Index; // 0x0

	// Properties
	public T Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(ref NativeSlice<T> array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F00F0 Offset: 0x10EF2F0 VA: 0x1810F00F0
	|-NativeSlice.Enumerator<ConvertMeshJobData>..ctor
	|-NativeSlice.Enumerator<CopyClosingMeshJobData>..ctor
	|-NativeSlice.Enumerator<DrawBufferRange>..ctor
	|-NativeSlice.Enumerator<GfxUpdateBufferRange>..ctor
	|-NativeSlice.Enumerator<JobHandle>..ctor
	|-NativeSlice.Enumerator<NudgeJobData>..ctor
	|-NativeSlice.Enumerator<Transform3x4>..ctor
	|-NativeSlice.Enumerator<ushort>..ctor
	|-NativeSlice.Enumerator<Vector3>..ctor
	|-NativeSlice.Enumerator<Vector4>..ctor
	|-NativeSlice.Enumerator<Vertex>..ctor
	|-NativeSlice.Enumerator<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	|-NativeSlice.Enumerator<ConvertMeshJobData>.Dispose
	|-NativeSlice.Enumerator<CopyClosingMeshJobData>.Dispose
	|-NativeSlice.Enumerator<DrawBufferRange>.Dispose
	|-NativeSlice.Enumerator<GfxUpdateBufferRange>.Dispose
	|-NativeSlice.Enumerator<JobHandle>.Dispose
	|-NativeSlice.Enumerator<NudgeJobData>.Dispose
	|-NativeSlice.Enumerator<Transform3x4>.Dispose
	|-NativeSlice.Enumerator<ushort>.Dispose
	|-NativeSlice.Enumerator<Vector3>.Dispose
	|-NativeSlice.Enumerator<Vector4>.Dispose
	|-NativeSlice.Enumerator<Vertex>.Dispose
	|-NativeSlice.Enumerator<__Il2CppFullySharedGenericStructType>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10ECD70 Offset: 0x10EBF70 VA: 0x1810ECD70
	|-NativeSlice.Enumerator<ConvertMeshJobData>.MoveNext
	|-NativeSlice.Enumerator<CopyClosingMeshJobData>.MoveNext
	|-NativeSlice.Enumerator<DrawBufferRange>.MoveNext
	|-NativeSlice.Enumerator<GfxUpdateBufferRange>.MoveNext
	|-NativeSlice.Enumerator<JobHandle>.MoveNext
	|-NativeSlice.Enumerator<NudgeJobData>.MoveNext
	|-NativeSlice.Enumerator<Transform3x4>.MoveNext
	|-NativeSlice.Enumerator<ushort>.MoveNext
	|-NativeSlice.Enumerator<Vector3>.MoveNext
	|-NativeSlice.Enumerator<Vector4>.MoveNext
	|-NativeSlice.Enumerator<Vertex>.MoveNext
	|
	|-RVA: 0x1107810 Offset: 0x1106A10 VA: 0x181107810
	|-NativeSlice.Enumerator<__Il2CppFullySharedGenericStructType>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10E8670 Offset: 0x10E7870 VA: 0x1810E8670
	|-NativeSlice.Enumerator<ConvertMeshJobData>.Reset
	|-NativeSlice.Enumerator<CopyClosingMeshJobData>.Reset
	|-NativeSlice.Enumerator<DrawBufferRange>.Reset
	|-NativeSlice.Enumerator<GfxUpdateBufferRange>.Reset
	|-NativeSlice.Enumerator<JobHandle>.Reset
	|-NativeSlice.Enumerator<NudgeJobData>.Reset
	|-NativeSlice.Enumerator<Transform3x4>.Reset
	|-NativeSlice.Enumerator<ushort>.Reset
	|-NativeSlice.Enumerator<Vector3>.Reset
	|-NativeSlice.Enumerator<Vector4>.Reset
	|-NativeSlice.Enumerator<Vertex>.Reset
	|-NativeSlice.Enumerator<__Il2CppFullySharedGenericStructType>.Reset
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F1440 Offset: 0x10F0640 VA: 0x1810F1440
	|-NativeSlice.Enumerator<ConvertMeshJobData>.get_Current
	|
	|-RVA: 0x10F11B0 Offset: 0x10F03B0 VA: 0x1810F11B0
	|-NativeSlice.Enumerator<CopyClosingMeshJobData>.get_Current
	|-NativeSlice.Enumerator<Transform3x4>.get_Current
	|
	|-RVA: 0x10F0DF0 Offset: 0x10EFFF0 VA: 0x1810F0DF0
	|-NativeSlice.Enumerator<DrawBufferRange>.get_Current
	|-NativeSlice.Enumerator<GfxUpdateBufferRange>.get_Current
	|-NativeSlice.Enumerator<JobHandle>.get_Current
	|-NativeSlice.Enumerator<Vector4>.get_Current
	|
	|-RVA: 0x10F1330 Offset: 0x10F0530 VA: 0x1810F1330
	|-NativeSlice.Enumerator<NudgeJobData>.get_Current
	|
	|-RVA: 0x1111FE0 Offset: 0x11111E0 VA: 0x181111FE0
	|-NativeSlice.Enumerator<ushort>.get_Current
	|
	|-RVA: 0x1111DB0 Offset: 0x1110FB0 VA: 0x181111DB0
	|-NativeSlice.Enumerator<Vector3>.get_Current
	|
	|-RVA: 0x1111CB0 Offset: 0x1110EB0 VA: 0x181111CB0
	|-NativeSlice.Enumerator<Vertex>.get_Current
	|
	|-RVA: 0x1112050 Offset: 0x1111250 VA: 0x181112050
	|-NativeSlice.Enumerator<__Il2CppFullySharedGenericStructType>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10EF940 Offset: 0x10EEB40 VA: 0x1810EF940
	|-NativeSlice.Enumerator<ConvertMeshJobData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x10EEFC0 Offset: 0x10EE1C0 VA: 0x1810EEFC0
	|-NativeSlice.Enumerator<CopyClosingMeshJobData>.System.Collections.IEnumerator.get_Current
	|-NativeSlice.Enumerator<Transform3x4>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x10EF670 Offset: 0x10EE870 VA: 0x1810EF670
	|-NativeSlice.Enumerator<DrawBufferRange>.System.Collections.IEnumerator.get_Current
	|-NativeSlice.Enumerator<GfxUpdateBufferRange>.System.Collections.IEnumerator.get_Current
	|-NativeSlice.Enumerator<JobHandle>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x10EF370 Offset: 0x10EE570 VA: 0x1810EF370
	|-NativeSlice.Enumerator<NudgeJobData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x110E420 Offset: 0x110D620 VA: 0x18110E420
	|-NativeSlice.Enumerator<ushort>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x110E810 Offset: 0x110DA10 VA: 0x18110E810
	|-NativeSlice.Enumerator<Vector3>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x110EBD0 Offset: 0x110DDD0 VA: 0x18110EBD0
	|-NativeSlice.Enumerator<Vector4>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x110DA40 Offset: 0x110CC40 VA: 0x18110DA40
	|-NativeSlice.Enumerator<Vertex>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x110EAD0 Offset: 0x110DCD0 VA: 0x18110EAD0
	|-NativeSlice.Enumerator<__Il2CppFullySharedGenericStructType>.System.Collections.IEnumerator.get_Current
	*/
}

// Namespace: Unity.Collections
[DebuggerTypeProxy(typeof(NativeSliceDebugView<T>))]
[DebuggerDisplay("Length = {Length}")]
[NativeContainerSupportsMinMaxWriteRestriction]
[DefaultMember("Item")]
[NativeContainer]
public struct NativeSlice<T> : IEnumerable<T>, IEnumerable, IEquatable<NativeSlice<T>> // TypeDefIndex: 13907
{
	// Fields
	[NativeDisableUnsafePtrRestriction]
	internal byte* m_Buffer; // 0x0
	internal int m_Stride; // 0x0
	internal int m_Length; // 0x0

	// Properties
	public T Item { get; set; }
	public int Stride { get; }
	public int Length { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(NativeSlice<T> slice, int start, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14824E0 Offset: 0x14816E0 VA: 0x1814824E0
	|-NativeSlice<ConvertMeshJobData>..ctor
	|-NativeSlice<CopyClosingMeshJobData>..ctor
	|-NativeSlice<DrawBufferRange>..ctor
	|-NativeSlice<GfxUpdateBufferRange>..ctor
	|-NativeSlice<JobHandle>..ctor
	|-NativeSlice<NudgeJobData>..ctor
	|-NativeSlice<Transform3x4>..ctor
	|-NativeSlice<ushort>..ctor
	|-NativeSlice<Vector3>..ctor
	|-NativeSlice<Vector4>..ctor
	|-NativeSlice<Vertex>..ctor
	|-NativeSlice<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(NativeArray<T> array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1482AF0 Offset: 0x1481CF0 VA: 0x181482AF0
	|-NativeSlice<ConvertMeshJobData>..ctor
	|
	|-RVA: 0x14826F0 Offset: 0x14818F0 VA: 0x1814826F0
	|-NativeSlice<CopyClosingMeshJobData>..ctor
	|-NativeSlice<Transform3x4>..ctor
	|
	|-RVA: 0x1482500 Offset: 0x1481700 VA: 0x181482500
	|-NativeSlice<DrawBufferRange>..ctor
	|-NativeSlice<GfxUpdateBufferRange>..ctor
	|-NativeSlice<JobHandle>..ctor
	|-NativeSlice<Vector4>..ctor
	|
	|-RVA: 0x14829A0 Offset: 0x1481BA0 VA: 0x1814829A0
	|-NativeSlice<NudgeJobData>..ctor
	|
	|-RVA: 0x14825E0 Offset: 0x14817E0 VA: 0x1814825E0
	|-NativeSlice<ushort>..ctor
	|
	|-RVA: 0x1482930 Offset: 0x1481B30 VA: 0x181482930
	|-NativeSlice<Vector3>..ctor
	|
	|-RVA: 0x1482570 Offset: 0x1481770 VA: 0x181482570
	|-NativeSlice<Vertex>..ctor
	|
	|-RVA: 0x14827D0 Offset: 0x14819D0 VA: 0x1814827D0
	|-NativeSlice<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1
	public static NativeSlice<T> op_Implicit(NativeArray<T> array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1483490 Offset: 0x1482690 VA: 0x181483490
	|-NativeSlice<ConvertMeshJobData>.op_Implicit
	|
	|-RVA: 0x1483280 Offset: 0x1482480 VA: 0x181483280
	|-NativeSlice<CopyClosingMeshJobData>.op_Implicit
	|-NativeSlice<Transform3x4>.op_Implicit
	|
	|-RVA: 0x1483330 Offset: 0x1482530 VA: 0x181483330
	|-NativeSlice<DrawBufferRange>.op_Implicit
	|-NativeSlice<GfxUpdateBufferRange>.op_Implicit
	|-NativeSlice<JobHandle>.op_Implicit
	|-NativeSlice<Vector4>.op_Implicit
	|
	|-RVA: 0x1483120 Offset: 0x1482320 VA: 0x181483120
	|-NativeSlice<NudgeJobData>.op_Implicit
	|
	|-RVA: 0x14831D0 Offset: 0x14823D0 VA: 0x1814831D0
	|-NativeSlice<ushort>.op_Implicit
	|
	|-RVA: 0x14833E0 Offset: 0x14825E0 VA: 0x1814833E0
	|-NativeSlice<Vector3>.op_Implicit
	|
	|-RVA: 0x1483540 Offset: 0x1482740 VA: 0x181483540
	|-NativeSlice<Vertex>.op_Implicit
	|
	|-RVA: 0x14835F0 Offset: 0x14827F0 VA: 0x1814835F0
	|-NativeSlice<__Il2CppFullySharedGenericStructType>.op_Implicit
	*/

	// RVA: -1 Offset: -1
	public void .ctor(NativeArray<T> array, int start, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1482B60 Offset: 0x1481D60 VA: 0x181482B60
	|-NativeSlice<ConvertMeshJobData>..ctor
	|
	|-RVA: 0x1482A80 Offset: 0x1481C80 VA: 0x181482A80
	|-NativeSlice<CopyClosingMeshJobData>..ctor
	|-NativeSlice<Transform3x4>..ctor
	|
	|-RVA: 0x1482400 Offset: 0x1481600 VA: 0x181482400
	|-NativeSlice<DrawBufferRange>..ctor
	|-NativeSlice<GfxUpdateBufferRange>..ctor
	|-NativeSlice<JobHandle>..ctor
	|-NativeSlice<Vector4>..ctor
	|
	|-RVA: 0x1482A10 Offset: 0x1481C10 VA: 0x181482A10
	|-NativeSlice<NudgeJobData>..ctor
	|
	|-RVA: 0x14828C0 Offset: 0x1481AC0 VA: 0x1814828C0
	|-NativeSlice<ushort>..ctor
	|
	|-RVA: 0x1482760 Offset: 0x1481960 VA: 0x181482760
	|-NativeSlice<Vector3>..ctor
	|
	|-RVA: 0x1482470 Offset: 0x1481670 VA: 0x181482470
	|-NativeSlice<Vertex>..ctor
	|
	|-RVA: 0x1482650 Offset: 0x1481850 VA: 0x181482650
	|-NativeSlice<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1482CC0 Offset: 0x1481EC0 VA: 0x181482CC0
	|-NativeSlice<ConvertMeshJobData>.get_Item
	|
	|-RVA: 0x1482E00 Offset: 0x1482000 VA: 0x181482E00
	|-NativeSlice<CopyClosingMeshJobData>.get_Item
	|-NativeSlice<Transform3x4>.get_Item
	|
	|-RVA: 0x1482C60 Offset: 0x1481E60 VA: 0x181482C60
	|-NativeSlice<DrawBufferRange>.get_Item
	|-NativeSlice<GfxUpdateBufferRange>.get_Item
	|-NativeSlice<JobHandle>.get_Item
	|-NativeSlice<Vector4>.get_Item
	|
	|-RVA: 0x1483050 Offset: 0x1482250 VA: 0x181483050
	|-NativeSlice<NudgeJobData>.get_Item
	|
	|-RVA: 0x1482DB0 Offset: 0x1481FB0 VA: 0x181482DB0
	|-NativeSlice<ushort>.get_Item
	|
	|-RVA: 0x1482E80 Offset: 0x1482080 VA: 0x181482E80
	|-NativeSlice<Vector3>.get_Item
	|
	|-RVA: 0x1482BD0 Offset: 0x1481DD0 VA: 0x181482BD0
	|-NativeSlice<Vertex>.get_Item
	|
	|-RVA: 0x1482EF0 Offset: 0x14820F0 VA: 0x181482EF0
	|-NativeSlice<__Il2CppFullySharedGenericStructType>.get_Item
	*/

	[WriteAccessRequired]
	// RVA: -1 Offset: -1
	public void set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1483820 Offset: 0x1482A20 VA: 0x181483820
	|-NativeSlice<ConvertMeshJobData>.set_Item
	|
	|-RVA: 0x1483710 Offset: 0x1482910 VA: 0x181483710
	|-NativeSlice<CopyClosingMeshJobData>.set_Item
	|-NativeSlice<Transform3x4>.set_Item
	|
	|-RVA: 0x1483650 Offset: 0x1482850 VA: 0x181483650
	|-NativeSlice<DrawBufferRange>.set_Item
	|-NativeSlice<GfxUpdateBufferRange>.set_Item
	|-NativeSlice<JobHandle>.set_Item
	|-NativeSlice<Vector4>.set_Item
	|
	|-RVA: 0x1483780 Offset: 0x1482980 VA: 0x181483780
	|-NativeSlice<NudgeJobData>.set_Item
	|
	|-RVA: 0x14836B0 Offset: 0x14828B0 VA: 0x1814836B0
	|-NativeSlice<ushort>.set_Item
	|
	|-RVA: 0x1483A70 Offset: 0x1482C70 VA: 0x181483A70
	|-NativeSlice<Vector3>.set_Item
	|
	|-RVA: 0x14838E0 Offset: 0x1482AE0 VA: 0x1814838E0
	|-NativeSlice<Vertex>.set_Item
	|
	|-RVA: 0x1483960 Offset: 0x1482B60 VA: 0x181483960
	|-NativeSlice<__Il2CppFullySharedGenericStructType>.set_Item
	*/

	[WriteAccessRequired]
	// RVA: -1 Offset: -1
	public void CopyFrom(NativeSlice<T> slice) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1480F80 Offset: 0x1480180 VA: 0x181480F80
	|-NativeSlice<ConvertMeshJobData>.CopyFrom
	|
	|-RVA: 0x1480D40 Offset: 0x147FF40 VA: 0x181480D40
	|-NativeSlice<CopyClosingMeshJobData>.CopyFrom
	|-NativeSlice<Transform3x4>.CopyFrom
	|
	|-RVA: 0x14817E0 Offset: 0x14809E0 VA: 0x1814817E0
	|-NativeSlice<DrawBufferRange>.CopyFrom
	|-NativeSlice<GfxUpdateBufferRange>.CopyFrom
	|-NativeSlice<JobHandle>.CopyFrom
	|-NativeSlice<Vector4>.CopyFrom
	|
	|-RVA: 0x14813A0 Offset: 0x14805A0 VA: 0x1814813A0
	|-NativeSlice<NudgeJobData>.CopyFrom
	|
	|-RVA: 0x1481CA0 Offset: 0x1480EA0 VA: 0x181481CA0
	|-NativeSlice<ushort>.CopyFrom
	|
	|-RVA: 0x14814C0 Offset: 0x14806C0 VA: 0x1814814C0
	|-NativeSlice<Vector3>.CopyFrom
	|
	|-RVA: 0x1480E60 Offset: 0x1480060 VA: 0x181480E60
	|-NativeSlice<Vertex>.CopyFrom
	|
	|-RVA: 0x1481AA0 Offset: 0x1480CA0 VA: 0x181481AA0
	|-NativeSlice<__Il2CppFullySharedGenericStructType>.CopyFrom
	*/

	[WriteAccessRequired]
	// RVA: -1 Offset: -1
	public void CopyFrom(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14816E0 Offset: 0x14808E0 VA: 0x1814816E0
	|-NativeSlice<ConvertMeshJobData>.CopyFrom
	|
	|-RVA: 0x1480C40 Offset: 0x147FE40 VA: 0x181480C40
	|-NativeSlice<CopyClosingMeshJobData>.CopyFrom
	|-NativeSlice<Transform3x4>.CopyFrom
	|
	|-RVA: 0x14812A0 Offset: 0x14804A0 VA: 0x1814812A0
	|-NativeSlice<DrawBufferRange>.CopyFrom
	|-NativeSlice<GfxUpdateBufferRange>.CopyFrom
	|-NativeSlice<JobHandle>.CopyFrom
	|-NativeSlice<Vector4>.CopyFrom
	|
	|-RVA: 0x1481DC0 Offset: 0x1480FC0 VA: 0x181481DC0
	|-NativeSlice<NudgeJobData>.CopyFrom
	|
	|-RVA: 0x14815E0 Offset: 0x14807E0 VA: 0x1814815E0
	|-NativeSlice<ushort>.CopyFrom
	|
	|-RVA: 0x14810A0 Offset: 0x14802A0 VA: 0x1814810A0
	|-NativeSlice<Vector3>.CopyFrom
	|
	|-RVA: 0x14811A0 Offset: 0x14803A0 VA: 0x1814811A0
	|-NativeSlice<Vertex>.CopyFrom
	|
	|-RVA: 0x1481900 Offset: 0x1480B00 VA: 0x181481900
	|-NativeSlice<__Il2CppFullySharedGenericStructType>.CopyFrom
	*/

	// RVA: -1 Offset: -1
	public int get_Stride() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3F5510 Offset: 0x3F4710 VA: 0x1803F5510
	|-NativeSlice<ConvertMeshJobData>.get_Stride
	|-NativeSlice<CopyClosingMeshJobData>.get_Stride
	|-NativeSlice<DrawBufferRange>.get_Stride
	|-NativeSlice<GfxUpdateBufferRange>.get_Stride
	|-NativeSlice<JobHandle>.get_Stride
	|-NativeSlice<NudgeJobData>.get_Stride
	|-NativeSlice<Transform3x4>.get_Stride
	|-NativeSlice<ushort>.get_Stride
	|-NativeSlice<Vector3>.get_Stride
	|-NativeSlice<Vector4>.get_Stride
	|-NativeSlice<Vertex>.get_Stride
	|-NativeSlice<__Il2CppFullySharedGenericStructType>.get_Stride
	*/

	// RVA: -1 Offset: -1
	public int get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1483110 Offset: 0x1482310 VA: 0x181483110
	|-NativeSlice<ConvertMeshJobData>.get_Length
	|-NativeSlice<CopyClosingMeshJobData>.get_Length
	|-NativeSlice<DrawBufferRange>.get_Length
	|-NativeSlice<GfxUpdateBufferRange>.get_Length
	|-NativeSlice<JobHandle>.get_Length
	|-NativeSlice<NudgeJobData>.get_Length
	|-NativeSlice<Transform3x4>.get_Length
	|-NativeSlice<ushort>.get_Length
	|-NativeSlice<Vector3>.get_Length
	|-NativeSlice<Vector4>.get_Length
	|-NativeSlice<Vertex>.get_Length
	|-NativeSlice<__Il2CppFullySharedGenericStructType>.get_Length
	*/

	// RVA: -1 Offset: -1
	public NativeSlice.Enumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1482140 Offset: 0x1481340 VA: 0x181482140
	|-NativeSlice<ConvertMeshJobData>.GetEnumerator
	|-NativeSlice<CopyClosingMeshJobData>.GetEnumerator
	|-NativeSlice<DrawBufferRange>.GetEnumerator
	|-NativeSlice<GfxUpdateBufferRange>.GetEnumerator
	|-NativeSlice<JobHandle>.GetEnumerator
	|-NativeSlice<NudgeJobData>.GetEnumerator
	|-NativeSlice<Transform3x4>.GetEnumerator
	|-NativeSlice<ushort>.GetEnumerator
	|-NativeSlice<Vector3>.GetEnumerator
	|-NativeSlice<Vector4>.GetEnumerator
	|-NativeSlice<Vertex>.GetEnumerator
	|-NativeSlice<__Il2CppFullySharedGenericStructType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14821E0 Offset: 0x14813E0 VA: 0x1814821E0
	|-NativeSlice<ConvertMeshJobData>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeSlice<CopyClosingMeshJobData>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeSlice<DrawBufferRange>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeSlice<GfxUpdateBufferRange>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeSlice<JobHandle>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeSlice<NudgeJobData>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeSlice<Transform3x4>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeSlice<ushort>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeSlice<Vector3>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeSlice<Vector4>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeSlice<Vertex>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-NativeSlice<__Il2CppFullySharedGenericStructType>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1482280 Offset: 0x1481480 VA: 0x181482280
	|-NativeSlice<ConvertMeshJobData>.System.Collections.IEnumerable.GetEnumerator
	|-NativeSlice<CopyClosingMeshJobData>.System.Collections.IEnumerable.GetEnumerator
	|-NativeSlice<DrawBufferRange>.System.Collections.IEnumerable.GetEnumerator
	|-NativeSlice<GfxUpdateBufferRange>.System.Collections.IEnumerable.GetEnumerator
	|-NativeSlice<JobHandle>.System.Collections.IEnumerable.GetEnumerator
	|-NativeSlice<NudgeJobData>.System.Collections.IEnumerable.GetEnumerator
	|-NativeSlice<Transform3x4>.System.Collections.IEnumerable.GetEnumerator
	|-NativeSlice<ushort>.System.Collections.IEnumerable.GetEnumerator
	|-NativeSlice<Vector3>.System.Collections.IEnumerable.GetEnumerator
	|-NativeSlice<Vector4>.System.Collections.IEnumerable.GetEnumerator
	|-NativeSlice<Vertex>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1482340 Offset: 0x1481540 VA: 0x181482340
	|-NativeSlice<__Il2CppFullySharedGenericStructType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool Equals(NativeSlice<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1481EC0 Offset: 0x14810C0 VA: 0x181481EC0
	|-NativeSlice<ConvertMeshJobData>.Equals
	|-NativeSlice<CopyClosingMeshJobData>.Equals
	|-NativeSlice<DrawBufferRange>.Equals
	|-NativeSlice<GfxUpdateBufferRange>.Equals
	|-NativeSlice<JobHandle>.Equals
	|-NativeSlice<NudgeJobData>.Equals
	|-NativeSlice<Transform3x4>.Equals
	|-NativeSlice<ushort>.Equals
	|-NativeSlice<Vector3>.Equals
	|-NativeSlice<Vector4>.Equals
	|-NativeSlice<Vertex>.Equals
	|-NativeSlice<__Il2CppFullySharedGenericStructType>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1481EE0 Offset: 0x14810E0 VA: 0x181481EE0
	|-NativeSlice<ConvertMeshJobData>.Equals
	|-NativeSlice<CopyClosingMeshJobData>.Equals
	|-NativeSlice<DrawBufferRange>.Equals
	|-NativeSlice<GfxUpdateBufferRange>.Equals
	|-NativeSlice<JobHandle>.Equals
	|-NativeSlice<NudgeJobData>.Equals
	|-NativeSlice<Transform3x4>.Equals
	|-NativeSlice<ushort>.Equals
	|-NativeSlice<Vector3>.Equals
	|-NativeSlice<Vector4>.Equals
	|-NativeSlice<Vertex>.Equals
	|
	|-RVA: 0x1481FF0 Offset: 0x14811F0 VA: 0x181481FF0
	|-NativeSlice<__Il2CppFullySharedGenericStructType>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14821C0 Offset: 0x14813C0 VA: 0x1814821C0
	|-NativeSlice<ConvertMeshJobData>.GetHashCode
	|-NativeSlice<CopyClosingMeshJobData>.GetHashCode
	|-NativeSlice<DrawBufferRange>.GetHashCode
	|-NativeSlice<GfxUpdateBufferRange>.GetHashCode
	|-NativeSlice<JobHandle>.GetHashCode
	|-NativeSlice<NudgeJobData>.GetHashCode
	|-NativeSlice<Transform3x4>.GetHashCode
	|-NativeSlice<ushort>.GetHashCode
	|-NativeSlice<Vector3>.GetHashCode
	|-NativeSlice<Vector4>.GetHashCode
	|-NativeSlice<Vertex>.GetHashCode
	|-NativeSlice<__Il2CppFullySharedGenericStructType>.GetHashCode
	*/
}

// Namespace: Unity.Collections
internal sealed class NativeSliceDebugView<T> // TypeDefIndex: 13908
{}

// Namespace: 
[IsReadOnly]
internal struct BurstLike.SharedStatic<T> // TypeDefIndex: 13909
{
	// Fields
	private readonly void* _buffer; // 0x0

	// Properties
	public T Data { get; }

	// Methods

	// RVA: -1 Offset: -1
	private void .ctor(void* buffer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	|-BurstLike.SharedStatic<IntPtr>..ctor
	|-BurstLike.SharedStatic<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1
	public ref T get_Data() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF6EB0 Offset: 0xBF60B0 VA: 0x180BF6EB0
	|-BurstLike.SharedStatic<IntPtr>.get_Data
	|
	|-RVA: 0xBF6EE0 Offset: 0xBF60E0 VA: 0x180BF6EE0
	|-BurstLike.SharedStatic<__Il2CppFullySharedGenericStructType>.get_Data
	*/

	// RVA: -1 Offset: -1
	public static BurstLike.SharedStatic<T> GetOrCreate<TContext>(uint alignment = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8F0BA0 Offset: 0x8EFDA0 VA: 0x1808F0BA0
	|-BurstLike.SharedStatic<IntPtr>.GetOrCreate<IJobExtensions.JobStruct<NativeArrayDisposeJob>>
	|-BurstLike.SharedStatic<IntPtr>.GetOrCreate<IJobParallelForExtensions.ParallelForJobStruct<OpacityIdAccelerator.OpacityIdUpdateJob>>
	|
	|-RVA: 0x8F0AD0 Offset: 0x8EFCD0 VA: 0x1808F0AD0
	|-BurstLike.SharedStatic<__Il2CppFullySharedGenericStructType>.GetOrCreate<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: 
internal static class BurstLike.SharedStatic // TypeDefIndex: 13910
{
	// Methods

	// RVA: 0x2474970 Offset: 0x2473B70 VA: 0x182474970
	public static void* GetOrCreateSharedStaticInternal(long getHashCode64, long getSubHashCode64, uint sizeOf, uint alignment) { }
}

// Namespace: Unity.Collections.LowLevel.Unsafe
[NativeHeader("Runtime/Export/BurstLike/BurstLike.bindings.h")]
[StaticAccessor("BurstLike", 2)]
internal static class BurstLike // TypeDefIndex: 13911
{}

// Namespace: 
private struct BurstRuntime.HashCode64<T> // TypeDefIndex: 13912
{
	// Fields
	public static readonly long Value; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x121A1A0 Offset: 0x12193A0 VA: 0x18121A1A0
	|-BurstRuntime.HashCode64<IJobExtensions.JobStruct<NativeArrayDisposeJob>>..cctor
	|
	|-RVA: 0x121A360 Offset: 0x1219560 VA: 0x18121A360
	|-BurstRuntime.HashCode64<IJobParallelForExtensions.ParallelForJobStruct<OpacityIdAccelerator.OpacityIdUpdateJob>>..cctor
	|
	|-RVA: 0x121A280 Offset: 0x1219480 VA: 0x18121A280
	|-BurstRuntime.HashCode64<__Il2CppFullySharedGenericType>..cctor
	*/
}

// Namespace: Unity.Collections.LowLevel.Unsafe
internal static class BurstRuntime // TypeDefIndex: 13913
{
	// Methods

	// RVA: -1 Offset: -1
	public static long GetHashCode64<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x945680 Offset: 0x944880 VA: 0x180945680
	|-BurstRuntime.GetHashCode64<IJobExtensions.JobStruct<NativeArrayDisposeJob>>
	|-BurstRuntime.GetHashCode64<IJobParallelForExtensions.ParallelForJobStruct<OpacityIdAccelerator.OpacityIdUpdateJob>>
	|-BurstRuntime.GetHashCode64<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x244DDF0 Offset: 0x244CFF0 VA: 0x18244DDF0
	internal static long HashStringWithFNV1A64(string text) { }
}

// Namespace: Unity.Collections.LowLevel.Unsafe
[RequiredByNativeCode]
[Usage(8)]
public sealed class NativeContainerAttribute : Attribute // TypeDefIndex: 13914
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: Unity.Collections.LowLevel.Unsafe
[Usage(8)]
[RequiredByNativeCode]
public sealed class NativeContainerIsReadOnlyAttribute : Attribute // TypeDefIndex: 13915
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: Unity.Collections.LowLevel.Unsafe
[Usage(8)]
[RequiredByNativeCode]
public sealed class NativeContainerIsAtomicWriteOnlyAttribute : Attribute // TypeDefIndex: 13916
{}

// Namespace: Unity.Collections.LowLevel.Unsafe
[Usage(8)]
[RequiredByNativeCode]
public sealed class NativeContainerSupportsMinMaxWriteRestrictionAttribute : Attribute // TypeDefIndex: 13917
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: Unity.Collections.LowLevel.Unsafe
[Usage(8)]
[RequiredByNativeCode]
public sealed class NativeContainerSupportsDeallocateOnJobCompletionAttribute : Attribute // TypeDefIndex: 13918
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: Unity.Collections.LowLevel.Unsafe
[Usage(8)]
[RequiredByNativeCode]
public sealed class NativeContainerSupportsDeferredConvertListToArray : Attribute // TypeDefIndex: 13919
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: Unity.Collections.LowLevel.Unsafe
[RequiredByNativeCode]
[Usage(256)]
public sealed class NativeSetThreadIndexAttribute : Attribute // TypeDefIndex: 13920
{}

// Namespace: Unity.Collections.LowLevel.Unsafe
[Obsolete("Use NativeSetThreadIndexAttribute instead")]
[RequiredByNativeCode]
[Usage(8)]
public sealed class NativeContainerNeedsThreadIndexAttribute : Attribute // TypeDefIndex: 13921
{}

// Namespace: Unity.Collections.LowLevel.Unsafe
[Usage(192)]
public class WriteAccessRequiredAttribute : Attribute // TypeDefIndex: 13922
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: Unity.Collections.LowLevel.Unsafe
[Usage(256)]
[RequiredByNativeCode]
public sealed class NativeDisableUnsafePtrRestrictionAttribute : Attribute // TypeDefIndex: 13923
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: Unity.Collections.LowLevel.Unsafe
[RequiredByNativeCode]
[Usage(256)]
public sealed class NativeDisableContainerSafetyRestrictionAttribute : Attribute // TypeDefIndex: 13924
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: Unity.Collections.LowLevel.Unsafe
[RequiredByNativeCode]
[Usage(256)]
public sealed class NativeSetClassTypeToNullOnScheduleAttribute : Attribute // TypeDefIndex: 13925
{}

// Namespace: Unity.Collections.LowLevel.Unsafe
[Extension]
public static class NativeArrayUnsafeUtility // TypeDefIndex: 13926
{
	// Methods

	// RVA: -1 Offset: -1
	public static NativeArray<T> ConvertExistingDataToNativeArray<T>(void* dataPointer, int length, Allocator allocator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA55350 Offset: 0xA54550 VA: 0x180A55350
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<BatchCullingOutputDrawCommands>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<BoneWeight1>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<byte>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<Color>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<Color32>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<ContactPairHeader>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<CullingSplit>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<int>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<LightDataGI>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<Matrix4x4>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<ModifiableContactPair>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<Plane>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<Quaternion>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<TileData>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<Vector3>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<Vector3Int>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<__Il2CppFullySharedGenericStructType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static void* GetUnsafePtr<T>(NativeArray<T> nativeArray) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA55380 Offset: 0xA54580 VA: 0x180A55380
	|-NativeArrayUnsafeUtility.GetUnsafePtr<Vector3>
	|-NativeArrayUnsafeUtility.GetUnsafePtr<__Il2CppFullySharedGenericStructType>
	|-NativeArrayUnsafeUtility.GetUnsafePtr<ParticleSystem.Particle>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static void* GetUnsafeReadOnlyPtr<T>(NativeArray<T> nativeArray) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA55380 Offset: 0xA54580 VA: 0x180A55380
	|-NativeArrayUnsafeUtility.GetUnsafeReadOnlyPtr<BoneWeight1>
	|-NativeArrayUnsafeUtility.GetUnsafeReadOnlyPtr<byte>
	|-NativeArrayUnsafeUtility.GetUnsafeReadOnlyPtr<int>
	|-NativeArrayUnsafeUtility.GetUnsafeReadOnlyPtr<JobHandle>
	|-NativeArrayUnsafeUtility.GetUnsafeReadOnlyPtr<ushort>
	|-NativeArrayUnsafeUtility.GetUnsafeReadOnlyPtr<Vector3>
	|-NativeArrayUnsafeUtility.GetUnsafeReadOnlyPtr<Vertex>
	|-NativeArrayUnsafeUtility.GetUnsafeReadOnlyPtr<VertexAttributeDescriptor>
	|-NativeArrayUnsafeUtility.GetUnsafeReadOnlyPtr<__Il2CppFullySharedGenericStructType>
	|-NativeArrayUnsafeUtility.GetUnsafeReadOnlyPtr<ParticleSystem.Particle>
	*/
}

// Namespace: Unity.Collections.LowLevel.Unsafe
[Extension]
public static class NativeSliceUnsafeUtility // TypeDefIndex: 13927
{
	// Methods

	// RVA: -1 Offset: -1
	public static NativeSlice<T> ConvertExistingDataToNativeSlice<T>(void* dataPointer, int stride, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA55890 Offset: 0xA54A90 VA: 0x180A55890
	|-NativeSliceUnsafeUtility.ConvertExistingDataToNativeSlice<DrawBufferRange>
	|-NativeSliceUnsafeUtility.ConvertExistingDataToNativeSlice<ushort>
	|-NativeSliceUnsafeUtility.ConvertExistingDataToNativeSlice<Vertex>
	|-NativeSliceUnsafeUtility.ConvertExistingDataToNativeSlice<__Il2CppFullySharedGenericStructType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static void* GetUnsafePtr<T>(NativeSlice<T> nativeSlice) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA55380 Offset: 0xA54580 VA: 0x180A55380
	|-NativeSliceUnsafeUtility.GetUnsafePtr<ConvertMeshJobData>
	|-NativeSliceUnsafeUtility.GetUnsafePtr<CopyClosingMeshJobData>
	|-NativeSliceUnsafeUtility.GetUnsafePtr<DrawBufferRange>
	|-NativeSliceUnsafeUtility.GetUnsafePtr<GfxUpdateBufferRange>
	|-NativeSliceUnsafeUtility.GetUnsafePtr<JobHandle>
	|-NativeSliceUnsafeUtility.GetUnsafePtr<NudgeJobData>
	|-NativeSliceUnsafeUtility.GetUnsafePtr<Transform3x4>
	|-NativeSliceUnsafeUtility.GetUnsafePtr<ushort>
	|-NativeSliceUnsafeUtility.GetUnsafePtr<Vector3>
	|-NativeSliceUnsafeUtility.GetUnsafePtr<Vector4>
	|-NativeSliceUnsafeUtility.GetUnsafePtr<Vertex>
	|-NativeSliceUnsafeUtility.GetUnsafePtr<__Il2CppFullySharedGenericStructType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static void* GetUnsafeReadOnlyPtr<T>(NativeSlice<T> nativeSlice) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA55380 Offset: 0xA54580 VA: 0x180A55380
	|-NativeSliceUnsafeUtility.GetUnsafeReadOnlyPtr<ConvertMeshJobData>
	|-NativeSliceUnsafeUtility.GetUnsafeReadOnlyPtr<CopyClosingMeshJobData>
	|-NativeSliceUnsafeUtility.GetUnsafeReadOnlyPtr<DrawBufferRange>
	|-NativeSliceUnsafeUtility.GetUnsafeReadOnlyPtr<GfxUpdateBufferRange>
	|-NativeSliceUnsafeUtility.GetUnsafeReadOnlyPtr<JobHandle>
	|-NativeSliceUnsafeUtility.GetUnsafeReadOnlyPtr<NudgeJobData>
	|-NativeSliceUnsafeUtility.GetUnsafeReadOnlyPtr<Transform3x4>
	|-NativeSliceUnsafeUtility.GetUnsafeReadOnlyPtr<ushort>
	|-NativeSliceUnsafeUtility.GetUnsafeReadOnlyPtr<Vector3>
	|-NativeSliceUnsafeUtility.GetUnsafeReadOnlyPtr<Vector4>
	|-NativeSliceUnsafeUtility.GetUnsafeReadOnlyPtr<Vertex>
	|-NativeSliceUnsafeUtility.GetUnsafeReadOnlyPtr<__Il2CppFullySharedGenericStructType>
	*/
}

// Namespace: 
private struct UnsafeUtility.AlignOfHelper<T> // TypeDefIndex: 13928
{
	// Fields
	public byte dummy; // 0x0
	public T data; // 0x0
}

// Namespace: Unity.Collections.LowLevel.Unsafe
[NativeHeader("Runtime/Export/Unsafe/UnsafeUtility.bindings.h")]
[StaticAccessor("UnsafeUtility", 2)]
public static class UnsafeUtility // TypeDefIndex: 13929
{
	// Methods

	// RVA: -1 Offset: -1
	public static bool IsBlittable<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA9F9F0 Offset: 0xA9EBF0 VA: 0x180A9F9F0
	|-UnsafeUtility.IsBlittable<__Il2CppFullySharedGenericStructType>
	*/

	[BurstAuthorizedExternalMethod]
	[ThreadSafe(ThrowsException = False)]
	// RVA: 0x2475070 Offset: 0x2474270 VA: 0x182475070
	internal static int LeakRecord(IntPtr handle, LeakCategory category, int callstacksToSkip) { }

	[BurstAuthorizedExternalMethod]
	[ThreadSafe(ThrowsException = False)]
	// RVA: 0x2475030 Offset: 0x2474230 VA: 0x182475030
	internal static int LeakErase(IntPtr handle, LeakCategory category) { }

	[ThreadSafe(ThrowsException = True)]
	// RVA: 0x24750C0 Offset: 0x24742C0 VA: 0x1824750C0
	public static void* MallocTracked(long size, int alignment, Allocator allocator, int callstacksToSkip) { }

	[ThreadSafe(ThrowsException = True)]
	// RVA: 0x2474C00 Offset: 0x2473E00 VA: 0x182474C00
	public static void FreeTracked(void* memory, Allocator allocator) { }

	[ThreadSafe(ThrowsException = True)]
	// RVA: 0x2475120 Offset: 0x2474320 VA: 0x182475120
	public static void* Malloc(long size, int alignment, Allocator allocator) { }

	[ThreadSafe(ThrowsException = True)]
	// RVA: 0x2474C40 Offset: 0x2473E40 VA: 0x182474C40
	public static void Free(void* memory, Allocator allocator) { }

	[ThreadSafe(ThrowsException = True)]
	// RVA: 0x2475220 Offset: 0x2474420 VA: 0x182475220
	public static void MemCpy(void* destination, void* source, long size) { }

	[ThreadSafe(ThrowsException = True)]
	// RVA: 0x24751C0 Offset: 0x24743C0 VA: 0x1824751C0
	public static void MemCpyStride(void* destination, int destinationStride, void* source, int sourceStride, int elementSize, int count) { }

	[ThreadSafe(ThrowsException = True)]
	// RVA: 0x2475280 Offset: 0x2474480 VA: 0x182475280
	public static void MemSet(void* destination, byte value, long size) { }

	// RVA: 0x2475170 Offset: 0x2474370 VA: 0x182475170
	public static void MemClear(void* destination, long size) { }

	[ThreadSafe]
	// RVA: 0x2474FF0 Offset: 0x24741F0 VA: 0x182474FF0
	public static bool IsBlittable(Type type) { }

	// RVA: 0x2474F90 Offset: 0x2474190 VA: 0x182474F90
	private static bool IsBlittableValueType(Type t) { }

	// RVA: 0x2474CF0 Offset: 0x2473EF0 VA: 0x182474CF0
	private static string GetReasonForTypeNonBlittableImpl(Type t, string name) { }

	// RVA: 0x2474F00 Offset: 0x2474100 VA: 0x182474F00
	internal static bool IsArrayBlittable(Array arr) { }

	// RVA: -1 Offset: -1
	internal static bool IsGenericListBlittable<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA9FA50 Offset: 0xA9EC50 VA: 0x180A9FA50
	|-UnsafeUtility.IsGenericListBlittable<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x2474C80 Offset: 0x2473E80 VA: 0x182474C80
	internal static string GetReasonForArrayNonBlittable(Array arr) { }

	// RVA: -1 Offset: -1
	internal static string GetReasonForGenericListNonBlittable<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA9F960 Offset: 0xA9EB60 VA: 0x180A9F960
	|-UnsafeUtility.GetReasonForGenericListNonBlittable<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public static int AlignOf<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA9F6F0 Offset: 0xA9E8F0 VA: 0x180A9F6F0
	|-UnsafeUtility.AlignOf<BatchCullingOutputDrawCommands>
	|-UnsafeUtility.AlignOf<ContactPairHeader>
	|-UnsafeUtility.AlignOf<ConvertMeshJobData>
	|-UnsafeUtility.AlignOf<CopyClosingMeshJobData>
	|-UnsafeUtility.AlignOf<GfxUpdateBufferRange>
	|-UnsafeUtility.AlignOf<IntPtr>
	|-UnsafeUtility.AlignOf<JobHandle>
	|-UnsafeUtility.AlignOf<ModifiableContactPair>
	|-UnsafeUtility.AlignOf<NudgeJobData>
	|
	|-RVA: 0xA9F710 Offset: 0xA9E910 VA: 0x180A9F710
	|-UnsafeUtility.AlignOf<BoneWeight1>
	|-UnsafeUtility.AlignOf<Color>
	|-UnsafeUtility.AlignOf<Color32>
	|-UnsafeUtility.AlignOf<CullingSplit>
	|-UnsafeUtility.AlignOf<DrawBufferRange>
	|-UnsafeUtility.AlignOf<int>
	|-UnsafeUtility.AlignOf<LightDataGI>
	|-UnsafeUtility.AlignOf<Matrix4x4>
	|-UnsafeUtility.AlignOf<Plane>
	|-UnsafeUtility.AlignOf<Quaternion>
	|-UnsafeUtility.AlignOf<TileData>
	|-UnsafeUtility.AlignOf<Transform3x4>
	|-UnsafeUtility.AlignOf<Vector3>
	|-UnsafeUtility.AlignOf<Vector3Int>
	|-UnsafeUtility.AlignOf<Vector4>
	|-UnsafeUtility.AlignOf<Vertex>
	|-UnsafeUtility.AlignOf<VertexAttributeDescriptor>
	|-UnsafeUtility.AlignOf<ParticleSystem.Particle>
	|
	|-RVA: 0xA9F730 Offset: 0xA9E930 VA: 0x180A9F730
	|-UnsafeUtility.AlignOf<byte>
	|
	|-RVA: 0xA9F7A0 Offset: 0xA9E9A0 VA: 0x180A9F7A0
	|-UnsafeUtility.AlignOf<ushort>
	|
	|-RVA: 0xA9F750 Offset: 0xA9E950 VA: 0x180A9F750
	|-UnsafeUtility.AlignOf<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public static T ReadArrayElement<T>(void* source, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA9FCD0 Offset: 0xA9EED0 VA: 0x180A9FCD0
	|-UnsafeUtility.ReadArrayElement<BatchCullingOutputDrawCommands>
	|
	|-RVA: 0xA9FD10 Offset: 0xA9EF10 VA: 0x180A9FD10
	|-UnsafeUtility.ReadArrayElement<BoneWeight1>
	|
	|-RVA: 0xA9FD20 Offset: 0xA9EF20 VA: 0x180A9FD20
	|-UnsafeUtility.ReadArrayElement<byte>
	|
	|-RVA: 0xA9FD40 Offset: 0xA9EF40 VA: 0x180A9FD40
	|-UnsafeUtility.ReadArrayElement<Color>
	|-UnsafeUtility.ReadArrayElement<DrawBufferRange>
	|-UnsafeUtility.ReadArrayElement<GfxUpdateBufferRange>
	|-UnsafeUtility.ReadArrayElement<JobHandle>
	|-UnsafeUtility.ReadArrayElement<Plane>
	|-UnsafeUtility.ReadArrayElement<Quaternion>
	|-UnsafeUtility.ReadArrayElement<Vector4>
	|-UnsafeUtility.ReadArrayElement<VertexAttributeDescriptor>
	|
	|-RVA: 0xA9FD30 Offset: 0xA9EF30 VA: 0x180A9FD30
	|-UnsafeUtility.ReadArrayElement<Color32>
	|-UnsafeUtility.ReadArrayElement<int>
	|
	|-RVA: 0xA9FD60 Offset: 0xA9EF60 VA: 0x180A9FD60
	|-UnsafeUtility.ReadArrayElement<ContactPairHeader>
	|
	|-RVA: 0xA9FD90 Offset: 0xA9EF90 VA: 0x180A9FD90
	|-UnsafeUtility.ReadArrayElement<ConvertMeshJobData>
	|
	|-RVA: 0xA9FE10 Offset: 0xA9F010 VA: 0x180A9FE10
	|-UnsafeUtility.ReadArrayElement<CopyClosingMeshJobData>
	|-UnsafeUtility.ReadArrayElement<Transform3x4>
	|
	|-RVA: 0xA9FE40 Offset: 0xA9F040 VA: 0x180A9FE40
	|-UnsafeUtility.ReadArrayElement<CullingSplit>
	|-UnsafeUtility.ReadArrayElement<LightDataGI>
	|-UnsafeUtility.ReadArrayElement<TileData>
	|
	|-RVA: 0xA9FF30 Offset: 0xA9F130 VA: 0x180A9FF30
	|-UnsafeUtility.ReadArrayElement<Matrix4x4>
	|-UnsafeUtility.ReadArrayElement<Vertex>
	|
	|-RVA: 0xA9FF60 Offset: 0xA9F160 VA: 0x180A9FF60
	|-UnsafeUtility.ReadArrayElement<ModifiableContactPair>
	|
	|-RVA: 0xA9FFC0 Offset: 0xA9F1C0 VA: 0x180A9FFC0
	|-UnsafeUtility.ReadArrayElement<NudgeJobData>
	|
	|-RVA: 0xAA0090 Offset: 0xA9F290 VA: 0x180AA0090
	|-UnsafeUtility.ReadArrayElement<ushort>
	|
	|-RVA: 0xAA00A0 Offset: 0xA9F2A0 VA: 0x180AA00A0
	|-UnsafeUtility.ReadArrayElement<Vector3>
	|-UnsafeUtility.ReadArrayElement<Vector3Int>
	|
	|-RVA: 0xA9FE90 Offset: 0xA9F090 VA: 0x180A9FE90
	|-UnsafeUtility.ReadArrayElement<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0xAA0020 Offset: 0xA9F220 VA: 0x180AA0020
	|-UnsafeUtility.ReadArrayElement<ParticleSystem.Particle>
	*/

	// RVA: -1 Offset: -1
	public static T ReadArrayElementWithStride<T>(void* source, int index, int stride) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA9FA80 Offset: 0xA9EC80 VA: 0x180A9FA80
	|-UnsafeUtility.ReadArrayElementWithStride<ConvertMeshJobData>
	|
	|-RVA: 0xA9FB00 Offset: 0xA9ED00 VA: 0x180A9FB00
	|-UnsafeUtility.ReadArrayElementWithStride<CopyClosingMeshJobData>
	|-UnsafeUtility.ReadArrayElementWithStride<Transform3x4>
	|
	|-RVA: 0xA9FB30 Offset: 0xA9ED30 VA: 0x180A9FB30
	|-UnsafeUtility.ReadArrayElementWithStride<DrawBufferRange>
	|-UnsafeUtility.ReadArrayElementWithStride<GfxUpdateBufferRange>
	|-UnsafeUtility.ReadArrayElementWithStride<JobHandle>
	|-UnsafeUtility.ReadArrayElementWithStride<Vector4>
	|
	|-RVA: 0xA9FC00 Offset: 0xA9EE00 VA: 0x180A9FC00
	|-UnsafeUtility.ReadArrayElementWithStride<NudgeJobData>
	|
	|-RVA: 0xA9FC60 Offset: 0xA9EE60 VA: 0x180A9FC60
	|-UnsafeUtility.ReadArrayElementWithStride<ushort>
	|
	|-RVA: 0xA9FC70 Offset: 0xA9EE70 VA: 0x180A9FC70
	|-UnsafeUtility.ReadArrayElementWithStride<Vector3>
	|
	|-RVA: 0xA9FC90 Offset: 0xA9EE90 VA: 0x180A9FC90
	|-UnsafeUtility.ReadArrayElementWithStride<Vertex>
	|
	|-RVA: 0xA9FB50 Offset: 0xA9ED50 VA: 0x180A9FB50
	|-UnsafeUtility.ReadArrayElementWithStride<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void WriteArrayElement<T>(void* destination, int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAA04D0 Offset: 0xA9F6D0 VA: 0x180AA04D0
	|-UnsafeUtility.WriteArrayElement<BatchCullingOutputDrawCommands>
	|
	|-RVA: 0xAA0500 Offset: 0xA9F700 VA: 0x180AA0500
	|-UnsafeUtility.WriteArrayElement<BoneWeight1>
	|
	|-RVA: 0xAA0510 Offset: 0xA9F710 VA: 0x180AA0510
	|-UnsafeUtility.WriteArrayElement<byte>
	|
	|-RVA: 0xAA0530 Offset: 0xA9F730 VA: 0x180AA0530
	|-UnsafeUtility.WriteArrayElement<Color>
	|-UnsafeUtility.WriteArrayElement<DrawBufferRange>
	|-UnsafeUtility.WriteArrayElement<GfxUpdateBufferRange>
	|-UnsafeUtility.WriteArrayElement<JobHandle>
	|-UnsafeUtility.WriteArrayElement<Plane>
	|-UnsafeUtility.WriteArrayElement<Quaternion>
	|-UnsafeUtility.WriteArrayElement<Vector4>
	|-UnsafeUtility.WriteArrayElement<VertexAttributeDescriptor>
	|
	|-RVA: 0xAA0520 Offset: 0xA9F720 VA: 0x180AA0520
	|-UnsafeUtility.WriteArrayElement<Color32>
	|-UnsafeUtility.WriteArrayElement<int>
	|
	|-RVA: 0xAA0540 Offset: 0xA9F740 VA: 0x180AA0540
	|-UnsafeUtility.WriteArrayElement<ContactPairHeader>
	|
	|-RVA: 0xAA0570 Offset: 0xA9F770 VA: 0x180AA0570
	|-UnsafeUtility.WriteArrayElement<ConvertMeshJobData>
	|
	|-RVA: 0xAA05F0 Offset: 0xA9F7F0 VA: 0x180AA05F0
	|-UnsafeUtility.WriteArrayElement<CopyClosingMeshJobData>
	|-UnsafeUtility.WriteArrayElement<Transform3x4>
	|
	|-RVA: 0xAA0620 Offset: 0xA9F820 VA: 0x180AA0620
	|-UnsafeUtility.WriteArrayElement<CullingSplit>
	|-UnsafeUtility.WriteArrayElement<LightDataGI>
	|-UnsafeUtility.WriteArrayElement<TileData>
	|
	|-RVA: 0xAA0740 Offset: 0xA9F940 VA: 0x180AA0740
	|-UnsafeUtility.WriteArrayElement<Matrix4x4>
	|-UnsafeUtility.WriteArrayElement<Vertex>
	|
	|-RVA: 0xAA0770 Offset: 0xA9F970 VA: 0x180AA0770
	|-UnsafeUtility.WriteArrayElement<ModifiableContactPair>
	|
	|-RVA: 0xAA07C0 Offset: 0xA9F9C0 VA: 0x180AA07C0
	|-UnsafeUtility.WriteArrayElement<NudgeJobData>
	|
	|-RVA: 0xAA0890 Offset: 0xA9FA90 VA: 0x180AA0890
	|-UnsafeUtility.WriteArrayElement<ushort>
	|
	|-RVA: 0xAA08A0 Offset: 0xA9FAA0 VA: 0x180AA08A0
	|-UnsafeUtility.WriteArrayElement<Vector3>
	|-UnsafeUtility.WriteArrayElement<Vector3Int>
	|
	|-RVA: 0xAA0670 Offset: 0xA9F870 VA: 0x180AA0670
	|-UnsafeUtility.WriteArrayElement<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0xAA0820 Offset: 0xA9FA20 VA: 0x180AA0820
	|-UnsafeUtility.WriteArrayElement<ParticleSystem.Particle>
	*/

	// RVA: -1 Offset: -1
	public static void WriteArrayElementWithStride<T>(void* destination, int index, int stride, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAA0230 Offset: 0xA9F430 VA: 0x180AA0230
	|-UnsafeUtility.WriteArrayElementWithStride<ConvertMeshJobData>
	|
	|-RVA: 0xAA02C0 Offset: 0xA9F4C0 VA: 0x180AA02C0
	|-UnsafeUtility.WriteArrayElementWithStride<CopyClosingMeshJobData>
	|-UnsafeUtility.WriteArrayElementWithStride<Transform3x4>
	|
	|-RVA: 0xAA02F0 Offset: 0xA9F4F0 VA: 0x180AA02F0
	|-UnsafeUtility.WriteArrayElementWithStride<DrawBufferRange>
	|-UnsafeUtility.WriteArrayElementWithStride<GfxUpdateBufferRange>
	|-UnsafeUtility.WriteArrayElementWithStride<JobHandle>
	|-UnsafeUtility.WriteArrayElementWithStride<Vector4>
	|
	|-RVA: 0xAA03F0 Offset: 0xA9F5F0 VA: 0x180AA03F0
	|-UnsafeUtility.WriteArrayElementWithStride<NudgeJobData>
	|
	|-RVA: 0xAA0460 Offset: 0xA9F660 VA: 0x180AA0460
	|-UnsafeUtility.WriteArrayElementWithStride<ushort>
	|
	|-RVA: 0xAA0470 Offset: 0xA9F670 VA: 0x180AA0470
	|-UnsafeUtility.WriteArrayElementWithStride<Vector3>
	|
	|-RVA: 0xAA0490 Offset: 0xA9F690 VA: 0x180AA0490
	|-UnsafeUtility.WriteArrayElementWithStride<Vertex>
	|
	|-RVA: 0xAA0310 Offset: 0xA9F510 VA: 0x180AA0310
	|-UnsafeUtility.WriteArrayElementWithStride<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void* AddressOf<T>(ref T output) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x937670 Offset: 0x936870 VA: 0x180937670
	|-UnsafeUtility.AddressOf<__Il2CppFullySharedGenericStructType>
	|-UnsafeUtility.AddressOf<OpacityIdAccelerator.OpacityIdUpdateJob>
	*/

	// RVA: -1 Offset: -1
	public static int SizeOf<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAA0110 Offset: 0xA9F310 VA: 0x180AA0110
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<BatchCullingOutputDrawCommands>>
	|-UnsafeUtility.SizeOf<Matrix4x4>
	|-UnsafeUtility.SizeOf<Vertex>
	|
	|-RVA: 0xAA0160 Offset: 0xA9F360 VA: 0x180AA0160
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<BoneWeight1>>
	|-UnsafeUtility.SizeOf<Vector3>
	|-UnsafeUtility.SizeOf<Vector3Int>
	|
	|-RVA: 0x6D3920 Offset: 0x6D2B20 VA: 0x1806D3920
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<byte>>
	|-UnsafeUtility.SizeOf<ushort>
	|
	|-RVA: 0xAA00C0 Offset: 0xA9F2C0 VA: 0x180AA00C0
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<Color>>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<DrawBufferRange>>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<Plane>>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<Quaternion>>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<Vector4>>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<VertexAttributeDescriptor>>
	|
	|-RVA: 0xAA00E0 Offset: 0xA9F2E0 VA: 0x180AA00E0
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<Color32>>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<int>>
	|-UnsafeUtility.SizeOf<BoneWeight1>
	|-UnsafeUtility.SizeOf<IntPtr>
	|
	|-RVA: 0xAA0100 Offset: 0xA9F300 VA: 0x180AA0100
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<ContactPairHeader>>
	|-UnsafeUtility.SizeOf<CopyClosingMeshJobData>
	|-UnsafeUtility.SizeOf<SubMeshDescriptor>
	|-UnsafeUtility.SizeOf<Transform3x4>
	|
	|-RVA: 0xAA0170 Offset: 0xA9F370 VA: 0x180AA0170
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<ConvertMeshJobData>>
	|
	|-RVA: 0xAA0130 Offset: 0xA9F330 VA: 0x180AA0130
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<CopyClosingMeshJobData>>
	|-UnsafeUtility.SizeOf<BatchCullingOutputDrawCommands>
	|
	|-RVA: 0xAA0150 Offset: 0xA9F350 VA: 0x180AA0150
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<CullingSplit>>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<LightDataGI>>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<TileData>>
	|
	|-RVA: 0xAA00D0 Offset: 0xA9F2D0 VA: 0x180AA00D0
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<GfxUpdateBufferRange>>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<JobHandle>>
	|
	|-RVA: 0x6F8DD0 Offset: 0x6F7FD0 VA: 0x1806F8DD0
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<IntPtr>>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<Vector3>>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<Vector3Int>>
	|-UnsafeUtility.SizeOf<Color>
	|-UnsafeUtility.SizeOf<DrawBufferRange>
	|-UnsafeUtility.SizeOf<GfxUpdateBufferRange>
	|-UnsafeUtility.SizeOf<JobHandle>
	|-UnsafeUtility.SizeOf<Plane>
	|-UnsafeUtility.SizeOf<Quaternion>
	|-UnsafeUtility.SizeOf<Vector4>
	|-UnsafeUtility.SizeOf<VertexAttributeDescriptor>
	|
	|-RVA: 0xAA0140 Offset: 0xA9F340 VA: 0x180AA0140
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<Matrix4x4>>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<Vertex>>
	|
	|-RVA: 0xAA0180 Offset: 0xA9F380 VA: 0x180AA0180
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<ModifiableContactPair>>
	|
	|-RVA: 0xAA0190 Offset: 0xA9F390 VA: 0x180AA0190
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<NudgeJobData>>
	|
	|-RVA: 0xAA0120 Offset: 0xA9F320 VA: 0x180AA0120
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<Transform3x4>>
	|
	|-RVA: 0x68EEE0 Offset: 0x68E0E0 VA: 0x18068EEE0
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<ushort>>
	|-UnsafeUtility.SizeOf<Color32>
	|-UnsafeUtility.SizeOf<int>
	|
	|-RVA: 0xAA00F0 Offset: 0xA9F2F0 VA: 0x180AA00F0
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<ParticleSystem.Particle>>
	|
	|-RVA: 0x680B10 Offset: 0x67FD10 VA: 0x180680B10
	|-UnsafeUtility.SizeOf<byte>
	|
	|-RVA: 0xAA01A0 Offset: 0xA9F3A0 VA: 0x180AA01A0
	|-UnsafeUtility.SizeOf<ContactPairHeader>
	|
	|-RVA: 0xAA01B0 Offset: 0xA9F3B0 VA: 0x180AA01B0
	|-UnsafeUtility.SizeOf<ConvertMeshJobData>
	|
	|-RVA: 0xAA01C0 Offset: 0xA9F3C0 VA: 0x180AA01C0
	|-UnsafeUtility.SizeOf<CullingSplit>
	|-UnsafeUtility.SizeOf<LightDataGI>
	|-UnsafeUtility.SizeOf<TileData>
	|
	|-RVA: 0xAA0200 Offset: 0xA9F400 VA: 0x180AA0200
	|-UnsafeUtility.SizeOf<ModifiableContactPair>
	|
	|-RVA: 0xAA0210 Offset: 0xA9F410 VA: 0x180AA0210
	|-UnsafeUtility.SizeOf<NudgeJobData>
	|
	|-RVA: 0xAA01D0 Offset: 0xA9F3D0 VA: 0x180AA01D0
	|-UnsafeUtility.SizeOf<__Il2CppFullySharedGenericStructType>
	|
	|-RVA: 0xAA0220 Offset: 0xA9F420 VA: 0x180AA0220
	|-UnsafeUtility.SizeOf<ParticleSystem.Particle>
	*/

	// RVA: -1 Offset: -1
	public static ref T As<U, T>(ref U from) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x937670 Offset: 0x936870 VA: 0x180937670
	|-UnsafeUtility.As<double, double>
	|-UnsafeUtility.As<double, int>
	|-UnsafeUtility.As<double, long>
	|-UnsafeUtility.As<double, float>
	|-UnsafeUtility.As<double, ulong>
	|-UnsafeUtility.As<int, double>
	|-UnsafeUtility.As<int, long>
	|-UnsafeUtility.As<int, ulong>
	|-UnsafeUtility.As<long, double>
	|-UnsafeUtility.As<long, int>
	|-UnsafeUtility.As<long, long>
	|-UnsafeUtility.As<long, float>
	|-UnsafeUtility.As<long, ulong>
	|-UnsafeUtility.As<float, double>
	|-UnsafeUtility.As<float, long>
	|-UnsafeUtility.As<float, ulong>
	|-UnsafeUtility.As<ulong, double>
	|-UnsafeUtility.As<ulong, int>
	|-UnsafeUtility.As<ulong, long>
	|-UnsafeUtility.As<ulong, float>
	|-UnsafeUtility.As<ulong, ulong>
	|-UnsafeUtility.As<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static ref T AsRef<T>(void* ptr) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x937670 Offset: 0x936870 VA: 0x180937670
	|-UnsafeUtility.AsRef<IntPtr>
	|-UnsafeUtility.AsRef<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public static int EnumToInt<T>(T enumValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA9F940 Offset: 0xA9EB40 VA: 0x180A9F940
	|-UnsafeUtility.EnumToInt<Int32Enum>
	|
	|-RVA: 0xA9F8F0 Offset: 0xA9EAF0 VA: 0x180A9F8F0
	|-UnsafeUtility.EnumToInt<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	private static void InternalEnumToInt<T>(ref T enumValue, ref int intValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9EE4E0 Offset: 0x9ED6E0 VA: 0x1809EE4E0
	|-UnsafeUtility.InternalEnumToInt<Int32Enum>
	|-UnsafeUtility.InternalEnumToInt<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static bool EnumEquals<T>(T lhs, T rhs) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA9F8E0 Offset: 0xA9EAE0 VA: 0x180A9F8E0
	|-UnsafeUtility.EnumEquals<Int32Enum>
	|
	|-RVA: 0xA9F7C0 Offset: 0xA9E9C0 VA: 0x180A9F7C0
	|-UnsafeUtility.EnumEquals<__Il2CppFullySharedGenericStructType>
	*/
}

// Namespace: Unity.Burst
[Usage(64)]
public class BurstAuthorizedExternalMethodAttribute : Attribute // TypeDefIndex: 13930
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: Unity.Burst
[Usage(192)]
public class BurstDiscardAttribute : Attribute // TypeDefIndex: 13931
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: Unity.Burst.LowLevel
[StaticAccessor("BurstCompilerService::Get()", 1)]
[NativeHeader("Runtime/Burst/BurstDelegateCache.h")]
[NativeHeader("Runtime/Burst/Burst.h")]
internal static class BurstCompilerService // TypeDefIndex: 13932
{
	// Methods

	[ThreadSafe]
	// RVA: 0x244DDA0 Offset: 0x244CFA0 VA: 0x18244DDA0
	public static void* GetOrCreateSharedMemory(ref Hash128 key, uint size_of, uint alignment) { }
}

// Namespace: JetBrains.Annotations
[Usage(24516)]
public sealed class CanBeNullAttribute : Attribute // TypeDefIndex: 13933
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: JetBrains.Annotations
[Usage(24516)]
public sealed class NotNullAttribute : Attribute // TypeDefIndex: 13934
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: JetBrains.Annotations
[Usage(64)]
public sealed class PureAttribute : Attribute // TypeDefIndex: 13935
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/BaseClasses/TagManager.h")]
public struct SortingLayer // TypeDefIndex: 13936
{
	// Fields
	private int m_Id; // 0x0

	// Methods

	[FreeFunction("GetTagManager().GetSortingLayerValueFromUniqueID")]
	// RVA: 0x24749F0 Offset: 0x2473BF0 VA: 0x1824749F0
	public static int GetLayerValueFromID(int id) { }
}

// Namespace: UnityEngine
[RequiredByNativeCode]
public struct Keyframe // TypeDefIndex: 13937
{
	// Fields
	private float m_Time; // 0x0
	private float m_Value; // 0x4
	private float m_InTangent; // 0x8
	private float m_OutTangent; // 0xC
	private int m_WeightedMode; // 0x10
	private float m_InWeight; // 0x14
	private float m_OutWeight; // 0x18

	// Properties
	public float time { get; }

	// Methods

	// RVA: 0x245A630 Offset: 0x2459830 VA: 0x18245A630
	public void .ctor(float time, float value) { }

	// RVA: 0x245A600 Offset: 0x2459800 VA: 0x18245A600
	public void .ctor(float time, float value, float inTangent, float outTangent) { }

	// RVA: 0x758EB0 Offset: 0x7580B0 VA: 0x180758EB0
	public float get_time() { }
}

// Namespace: UnityEngine
public enum WrapMode // TypeDefIndex: 13938
{
	// Fields
	public int value__; // 0x0
	public const WrapMode Once = 1;
	public const WrapMode Loop = 2;
	public const WrapMode PingPong = 4;
	public const WrapMode Default = 0;
	public const WrapMode ClampForever = 8;
	public const WrapMode Clamp = 1;
}

// Namespace: UnityEngine
[RequiredByNativeCode]
[NativeHeader("Runtime/Math/AnimationCurve.bindings.h")]
[DefaultMember("Item")]
public class AnimationCurve : IEquatable<AnimationCurve> // TypeDefIndex: 13939
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Properties
	public Keyframe[] keys { get; }
	public Keyframe Item { get; }
	public int length { get; }
	public WrapMode preWrapMode { get; set; }
	public WrapMode postWrapMode { get; set; }

	// Methods

	[FreeFunction("AnimationCurveBindings::Internal_Destroy", IsThreadSafe = True)]
	// RVA: 0x244B3B0 Offset: 0x244A5B0 VA: 0x18244B3B0
	private static void Internal_Destroy(IntPtr ptr) { }

	[FreeFunction("AnimationCurveBindings::Internal_Create", IsThreadSafe = True)]
	// RVA: 0x244B370 Offset: 0x244A570 VA: 0x18244B370
	private static IntPtr Internal_Create(Keyframe[] keys) { }

	[FreeFunction("AnimationCurveBindings::Internal_Equals", HasExplicitThis = True, IsThreadSafe = True)]
	// RVA: 0x244B3F0 Offset: 0x244A5F0 VA: 0x18244B3F0
	private bool Internal_Equals(IntPtr other) { }

	// RVA: 0x244B1B0 Offset: 0x244A3B0 VA: 0x18244B1B0 Slot: 1
	protected override void Finalize() { }

	[ThreadSafe]
	// RVA: 0x244B160 Offset: 0x244A360 VA: 0x18244B160
	public float Evaluate(float time) { }

	// RVA: 0x244B330 Offset: 0x244A530 VA: 0x18244B330
	public Keyframe[] get_keys() { }

	// RVA: 0x244B6E0 Offset: 0x244A8E0 VA: 0x18244B6E0
	public Keyframe get_Item(int index) { }

	[NativeMethod("GetKeyCount", IsThreadSafe = True)]
	// RVA: 0x244B770 Offset: 0x244A970 VA: 0x18244B770
	public int get_length() { }

	[FreeFunction("AnimationCurveBindings::GetKey", HasExplicitThis = True, IsThreadSafe = True)]
	[NativeThrows]
	// RVA: 0x244B2C0 Offset: 0x244A4C0 VA: 0x18244B2C0
	private Keyframe GetKey(int index) { }

	[FreeFunction("AnimationCurveBindings::GetKeys", HasExplicitThis = True, IsThreadSafe = True)]
	// RVA: 0x244B330 Offset: 0x244A530 VA: 0x18244B330
	private Keyframe[] GetKeys() { }

	[FreeFunction("AnimationCurveBindings::GetHashCode", HasExplicitThis = True, IsThreadSafe = True)]
	// RVA: 0x244B230 Offset: 0x244A430 VA: 0x18244B230 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x244B440 Offset: 0x244A640 VA: 0x18244B440
	public static AnimationCurve Linear(float timeStart, float valueStart, float timeEnd, float valueEnd) { }

	[NativeMethod("GetPreInfinity", IsThreadSafe = True)]
	// RVA: 0x244B7F0 Offset: 0x244A9F0 VA: 0x18244B7F0
	public WrapMode get_preWrapMode() { }

	[NativeMethod("SetPreInfinity", IsThreadSafe = True)]
	// RVA: 0x244B870 Offset: 0x244AA70 VA: 0x18244B870
	public void set_preWrapMode(WrapMode value) { }

	[NativeMethod("GetPostInfinity", IsThreadSafe = True)]
	// RVA: 0x244B7B0 Offset: 0x244A9B0 VA: 0x18244B7B0
	public WrapMode get_postWrapMode() { }

	[NativeMethod("SetPostInfinity", IsThreadSafe = True)]
	// RVA: 0x244B830 Offset: 0x244AA30 VA: 0x18244B830
	public void set_postWrapMode(WrapMode value) { }

	// RVA: 0x244B690 Offset: 0x244A890 VA: 0x18244B690
	public void .ctor(Keyframe[] keys) { }

	[RequiredByNativeCode]
	// RVA: 0x244B650 Offset: 0x244A850 VA: 0x18244B650
	public void .ctor() { }

	// RVA: 0x244AFC0 Offset: 0x244A1C0 VA: 0x18244AFC0 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x244AEE0 Offset: 0x244A0E0 VA: 0x18244AEE0 Slot: 4
	public bool Equals(AnimationCurve other) { }

	// RVA: 0x244B270 Offset: 0x244A470 VA: 0x18244B270
	private void GetKey_Injected(int index, out Keyframe ret) { }
}

// Namespace: 
public sealed class Application.LowMemoryCallback : MulticastDelegate // TypeDefIndex: 13940
{
	// Methods

	// RVA: 0x458710 Offset: 0x457910 VA: 0x180458710
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x4240E0 Offset: 0x4232E0 VA: 0x1804240E0 Slot: 13
	public virtual void Invoke() { }
}

// Namespace: 
public sealed class Application.MemoryUsageChangedCallback : MulticastDelegate // TypeDefIndex: 13941
{
	// Methods

	// RVA: 0x4047F0 Offset: 0x4039F0 VA: 0x1804047F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(in ApplicationMemoryUsageChange usage) { }
}

// Namespace: 
public sealed class Application.LogCallback : MulticastDelegate // TypeDefIndex: 13942
{
	// Methods

	// RVA: 0x245BE80 Offset: 0x245B080 VA: 0x18245BE80
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x409CF0 Offset: 0x408EF0 VA: 0x180409CF0 Slot: 13
	public virtual void Invoke(string condition, string stackTrace, LogType type) { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Utilities/Argv.h")]
[NativeHeader("Runtime/Misc/BuildSettings.h")]
[NativeHeader("Runtime/Misc/PlayerSettings.h")]
[NativeHeader("Runtime/Misc/Player.h")]
[NativeHeader("Runtime/Logging/LogSystem.h")]
[NativeHeader("Runtime/Input/TargetFrameRate.h")]
[NativeHeader("Runtime/Input/InputManager.h")]
[NativeHeader("Runtime/Network/NetworkUtility.h")]
[NativeHeader("Runtime/PreloadManager/LoadSceneOperation.h")]
[NativeHeader("Runtime/PreloadManager/PreloadManager.h")]
[NativeHeader("Runtime/Application/AdsIdHandler.h")]
[NativeHeader("Runtime/Export/Application/Application.bindings.h")]
[NativeHeader("Runtime/BaseClasses/IsPlaying.h")]
[NativeHeader("Runtime/File/ApplicationSpecificPersistentDataPath.h")]
[NativeHeader("Runtime/Application/ApplicationInfo.h")]
[NativeHeader("Runtime/Misc/SystemInfo.h")]
[NativeHeader("Runtime/Input/GetInput.h")]
[NativeHeader("Runtime/Utilities/URLUtility.h")]
public class Application // TypeDefIndex: 13943
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Application.LowMemoryCallback lowMemory; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Application.MemoryUsageChangedCallback memoryUsageChanged; // 0x8
	private static Application.LogCallback s_LogCallbackHandler; // 0x10
	private static Application.LogCallback s_LogCallbackHandlerThreaded; // 0x18
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action<bool> focusChanged; // 0x20
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action<string> deepLinkActivated; // 0x28
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Func<bool> wantsToQuit; // 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action quitting; // 0x38
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action unloading; // 0x40
	private static CancellationTokenSource s_currentCancellationTokenSource; // 0x48

	// Properties
	public static bool isPlaying { get; }
	public static bool isFocused { get; }
	public static string buildGUID { get; }
	public static bool runInBackground { get; }
	public static bool isBatchMode { get; }
	public static string dataPath { get; }
	public static string streamingAssetsPath { get; }
	public static string persistentDataPath { get; }
	public static string temporaryCachePath { get; }
	public static string unityVersion { get; }
	public static string version { get; }
	public static string identifier { get; }
	public static ApplicationInstallMode installMode { get; }
	public static string productName { get; }
	public static string cloudProjectId { get; }
	public static int targetFrameRate { get; set; }
	public static bool genuine { get; }
	public static bool genuineCheckAvailable { get; }
	public static RuntimePlatform platform { get; }
	public static bool isMobilePlatform { get; }
	public static bool isConsolePlatform { get; }
	public static SystemLanguage systemLanguage { get; }
	public static bool isEditor { get; }

	// Methods

	[FreeFunction("GetInputManager().QuitApplication")]
	// RVA: 0x244C090 Offset: 0x244B290 VA: 0x18244C090
	public static void Quit(int exitCode) { }

	// RVA: 0x244C0D0 Offset: 0x244B2D0 VA: 0x18244C0D0
	public static void Quit() { }

	[FreeFunction("IsWorldPlaying")]
	// RVA: 0x244C6A0 Offset: 0x244B8A0 VA: 0x18244C6A0
	public static bool get_isPlaying() { }

	[FreeFunction("IsPlayerFocused")]
	// RVA: 0x244C5D0 Offset: 0x244B7D0 VA: 0x18244C5D0
	public static bool get_isFocused() { }

	[FreeFunction("Application_Bindings::GetBuildGUID")]
	// RVA: 0x244C3C0 Offset: 0x244B5C0 VA: 0x18244C3C0
	public static string get_buildGUID() { }

	[FreeFunction("GetPlayerSettingsRunInBackground")]
	// RVA: 0x244C760 Offset: 0x244B960 VA: 0x18244C760
	public static bool get_runInBackground() { }

	[FreeFunction("::IsBatchmode")]
	// RVA: 0x244C510 Offset: 0x244B710 VA: 0x18244C510
	public static bool get_isBatchMode() { }

	[FreeFunction("GetAppDataPath", IsThreadSafe = True)]
	// RVA: 0x244C420 Offset: 0x244B620 VA: 0x18244C420
	public static string get_dataPath() { }

	[FreeFunction("GetStreamingAssetsPath", IsThreadSafe = True)]
	// RVA: 0x244C790 Offset: 0x244B990 VA: 0x18244C790
	public static string get_streamingAssetsPath() { }

	[FreeFunction("GetPersistentDataPathApplicationSpecific")]
	// RVA: 0x244C6D0 Offset: 0x244B8D0 VA: 0x18244C6D0
	public static string get_persistentDataPath() { }

	[FreeFunction("GetTemporaryCachePathApplicationSpecific")]
	// RVA: 0x244C820 Offset: 0x244BA20 VA: 0x18244C820
	public static string get_temporaryCachePath() { }

	[FreeFunction("Application_Bindings::GetUnityVersion", IsThreadSafe = True)]
	// RVA: 0x244C850 Offset: 0x244BA50 VA: 0x18244C850
	public static string get_unityVersion() { }

	[FreeFunction("GetApplicationInfo().GetVersion")]
	// RVA: 0x244C880 Offset: 0x244BA80 VA: 0x18244C880
	public static string get_version() { }

	[FreeFunction("GetApplicationInfo().GetApplicationIdentifier")]
	// RVA: 0x244C4B0 Offset: 0x244B6B0 VA: 0x18244C4B0
	public static string get_identifier() { }

	[FreeFunction("GetApplicationInfo().GetInstallMode")]
	// RVA: 0x244C4E0 Offset: 0x244B6E0 VA: 0x18244C4E0
	public static ApplicationInstallMode get_installMode() { }

	[FreeFunction("GetPlayerSettings().GetProductName")]
	// RVA: 0x244C730 Offset: 0x244B930 VA: 0x18244C730
	public static string get_productName() { }

	[FreeFunction("GetPlayerSettings().GetCloudProjectId")]
	// RVA: 0x244C3F0 Offset: 0x244B5F0 VA: 0x18244C3F0
	public static string get_cloudProjectId() { }

	[FreeFunction("OpenURL")]
	// RVA: 0x244C050 Offset: 0x244B250 VA: 0x18244C050
	public static void OpenURL(string url) { }

	[FreeFunction("GetTargetFrameRate")]
	// RVA: 0x244C7F0 Offset: 0x244B9F0 VA: 0x18244C7F0
	public static int get_targetFrameRate() { }

	[FreeFunction("SetTargetFrameRate")]
	// RVA: 0x244CA80 Offset: 0x244BC80 VA: 0x18244CA80
	public static void set_targetFrameRate(int value) { }

	[FreeFunction("Application_Bindings::SetLogCallbackDefined")]
	// RVA: 0x244C130 Offset: 0x244B330 VA: 0x18244C130
	private static void SetLogCallbackDefined(bool defined) { }

	[FreeFunction("IsApplicationGenuine")]
	// RVA: 0x244C480 Offset: 0x244B680 VA: 0x18244C480
	public static bool get_genuine() { }

	[FreeFunction("IsApplicationGenuineAvailable")]
	// RVA: 0x244C450 Offset: 0x244B650 VA: 0x18244C450
	public static bool get_genuineCheckAvailable() { }

	[FreeFunction("systeminfo::GetRuntimePlatform", IsThreadSafe = True)]
	// RVA: 0x244C700 Offset: 0x244B900 VA: 0x18244C700
	public static RuntimePlatform get_platform() { }

	// RVA: 0x244C600 Offset: 0x244B800 VA: 0x18244C600
	public static bool get_isMobilePlatform() { }

	// RVA: 0x244C540 Offset: 0x244B740 VA: 0x18244C540
	public static bool get_isConsolePlatform() { }

	[FreeFunction("(SystemLanguage)systeminfo::GetSystemLanguage")]
	// RVA: 0x244C7C0 Offset: 0x244B9C0 VA: 0x18244C7C0
	public static SystemLanguage get_systemLanguage() { }

	[RequiredByNativeCode]
	// RVA: 0x244B9A0 Offset: 0x244ABA0 VA: 0x18244B9A0
	internal static void CallLowMemory(ApplicationMemoryUsage usage) { }

	[RequiredByNativeCode]
	// RVA: 0x244BAE0 Offset: 0x244ACE0 VA: 0x18244BAE0
	internal static bool HasLogCallback() { }

	// RVA: 0x244C1D0 Offset: 0x244B3D0 VA: 0x18244C1D0
	public static void add_logMessageReceivedThreaded(Application.LogCallback value) { }

	// RVA: 0x244C8B0 Offset: 0x244BAB0 VA: 0x18244C8B0
	public static void remove_logMessageReceivedThreaded(Application.LogCallback value) { }

	[RequiredByNativeCode]
	// RVA: 0x244B8B0 Offset: 0x244AAB0 VA: 0x18244B8B0
	private static void CallLogCallback(string logString, string stackTrace, LogType type, bool invokedOnMainThread) { }

	[CompilerGenerated]
	// RVA: 0x244C2C0 Offset: 0x244B4C0 VA: 0x18244C2C0
	public static void add_quitting(Action value) { }

	[CompilerGenerated]
	// RVA: 0x244C980 Offset: 0x244BB80 VA: 0x18244C980
	public static void remove_quitting(Action value) { }

	[RequiredByNativeCode]
	// RVA: 0x244BD30 Offset: 0x244AF30 VA: 0x18244BD30
	private static bool Internal_ApplicationWantsToQuit() { }

	[RequiredByNativeCode]
	// RVA: 0x244BB60 Offset: 0x244AD60 VA: 0x18244BB60
	private static void Internal_ApplicationInit() { }

	[RequiredByNativeCode]
	// RVA: 0x244BBF0 Offset: 0x244ADF0 VA: 0x18244BBF0
	private static void Internal_ApplicationQuit() { }

	[RequiredByNativeCode]
	// RVA: 0x244BCA0 Offset: 0x244AEA0 VA: 0x18244BCA0
	private static void Internal_ApplicationUnload() { }

	[RequiredByNativeCode]
	// RVA: 0x244C010 Offset: 0x244B210 VA: 0x18244C010
	internal static void InvokeOnBeforeRender() { }

	[RequiredByNativeCode]
	// RVA: 0x244BF70 Offset: 0x244B170 VA: 0x18244BF70
	internal static void InvokeFocusChanged(bool focus) { }

	[RequiredByNativeCode]
	// RVA: 0x244BED0 Offset: 0x244B0D0 VA: 0x18244BED0
	internal static void InvokeDeepLinkActivated(string url) { }

	// RVA: 0xA641B0 Offset: 0xA633B0 VA: 0x180A641B0
	public static bool get_isEditor() { }

	// RVA: 0x244C170 Offset: 0x244B370 VA: 0x18244C170
	private static void .cctor() { }
}

// Namespace: UnityEngine
public enum ApplicationMemoryUsage // TypeDefIndex: 13944
{
	// Fields
	public int value__; // 0x0
	public const ApplicationMemoryUsage Unknown = 0;
	public const ApplicationMemoryUsage Low = 1;
	public const ApplicationMemoryUsage Medium = 2;
	public const ApplicationMemoryUsage High = 3;
	public const ApplicationMemoryUsage Critical = 4;
}

// Namespace: UnityEngine
public struct ApplicationMemoryUsageChange // TypeDefIndex: 13945
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private ApplicationMemoryUsage <memoryUsage>k__BackingField; // 0x0

	// Properties
	private ApplicationMemoryUsage memoryUsage { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	private void set_memoryUsage(ApplicationMemoryUsage value) { }

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void .ctor(ApplicationMemoryUsage usage) { }
}

// Namespace: UnityEngine
public enum ApplicationInstallMode // TypeDefIndex: 13946
{
	// Fields
	public int value__; // 0x0
	public const ApplicationInstallMode Unknown = 0;
	public const ApplicationInstallMode Store = 1;
	public const ApplicationInstallMode DeveloperBuild = 2;
	public const ApplicationInstallMode Adhoc = 3;
	public const ApplicationInstallMode Enterprise = 4;
	public const ApplicationInstallMode Editor = 5;
}

// Namespace: UnityEngine
public enum SendMessageOptions // TypeDefIndex: 13947
{
	// Fields
	public int value__; // 0x0
	public const SendMessageOptions RequireReceiver = 0;
	public const SendMessageOptions DontRequireReceiver = 1;
}

// Namespace: UnityEngine
public enum PrimitiveType // TypeDefIndex: 13948
{
	// Fields
	public int value__; // 0x0
	public const PrimitiveType Sphere = 0;
	public const PrimitiveType Capsule = 1;
	public const PrimitiveType Cylinder = 2;
	public const PrimitiveType Cube = 3;
	public const PrimitiveType Plane = 4;
	public const PrimitiveType Quad = 5;
}

// Namespace: UnityEngine
public enum Space // TypeDefIndex: 13949
{
	// Fields
	public int value__; // 0x0
	public const Space World = 0;
	public const Space Self = 1;
}

// Namespace: UnityEngine
public enum RuntimePlatform // TypeDefIndex: 13950
{
	// Fields
	public int value__; // 0x0
	public const RuntimePlatform OSXEditor = 0;
	public const RuntimePlatform OSXPlayer = 1;
	public const RuntimePlatform WindowsPlayer = 2;
	[Obsolete("WebPlayer export is no longer supported in Unity 5.4+.", True)]
	public const RuntimePlatform OSXWebPlayer = 3;
	[Obsolete("Dashboard widget on Mac OS X export is no longer supported in Unity 5.4+.", True)]
	public const RuntimePlatform OSXDashboardPlayer = 4;
	[Obsolete("WebPlayer export is no longer supported in Unity 5.4+.", True)]
	public const RuntimePlatform WindowsWebPlayer = 5;
	public const RuntimePlatform WindowsEditor = 7;
	public const RuntimePlatform IPhonePlayer = 8;
	[Obsolete("Xbox360 export is no longer supported in Unity 5.5+.")]
	public const RuntimePlatform XBOX360 = 10;
	[Obsolete("PS3 export is no longer supported in Unity >=5.5.")]
	public const RuntimePlatform PS3 = 9;
	public const RuntimePlatform Android = 11;
	[Obsolete("NaCl export is no longer supported in Unity 5.0+.")]
	public const RuntimePlatform NaCl = 12;
	[Obsolete("FlashPlayer export is no longer supported in Unity 5.0+.")]
	public const RuntimePlatform FlashPlayer = 15;
	public const RuntimePlatform LinuxPlayer = 13;
	public const RuntimePlatform LinuxEditor = 16;
	public const RuntimePlatform WebGLPlayer = 17;
	[Obsolete("Use WSAPlayerX86 instead")]
	public const RuntimePlatform MetroPlayerX86 = 18;
	public const RuntimePlatform WSAPlayerX86 = 18;
	[Obsolete("Use WSAPlayerX64 instead")]
	public const RuntimePlatform MetroPlayerX64 = 19;
	public const RuntimePlatform WSAPlayerX64 = 19;
	[Obsolete("Use WSAPlayerARM instead")]
	public const RuntimePlatform MetroPlayerARM = 20;
	public const RuntimePlatform WSAPlayerARM = 20;
	[Obsolete("Windows Phone 8 was removed in 5.3")]
	public const RuntimePlatform WP8Player = 21;
	[Obsolete("BlackBerryPlayer export is no longer supported in Unity 5.4+.")]
	public const RuntimePlatform BlackBerryPlayer = 22;
	[Obsolete("TizenPlayer export is no longer supported in Unity 2017.3+.")]
	public const RuntimePlatform TizenPlayer = 23;
	[Obsolete("PSP2 is no longer supported as of Unity 2018.3")]
	public const RuntimePlatform PSP2 = 24;
	public const RuntimePlatform PS4 = 25;
	[Obsolete("PSM export is no longer supported in Unity >= 5.3")]
	public const RuntimePlatform PSM = 26;
	public const RuntimePlatform XboxOne = 27;
	[Obsolete("SamsungTVPlayer export is no longer supported in Unity 2017.3+.")]
	public const RuntimePlatform SamsungTVPlayer = 28;
	[Obsolete("Wii U is no longer supported in Unity 2018.1+.")]
	public const RuntimePlatform WiiU = 30;
	public const RuntimePlatform tvOS = 31;
	public const RuntimePlatform Switch = 32;
	[Obsolete("Lumin is no longer supported in Unity 2022.2")]
	public const RuntimePlatform Lumin = 33;
	public const RuntimePlatform Stadia = 34;
	[Obsolete("Use LinuxPlayer instead")]
	public const RuntimePlatform CloudRendering = 35;
	[Obsolete("GameCoreScarlett is deprecated, please use GameCoreXboxSeries (UnityUpgradable) -> GameCoreXboxSeries", False)]
	public const RuntimePlatform GameCoreScarlett = -1;
	public const RuntimePlatform GameCoreXboxSeries = 36;
	public const RuntimePlatform GameCoreXboxOne = 37;
	public const RuntimePlatform PS5 = 38;
	public const RuntimePlatform EmbeddedLinuxArm64 = 39;
	public const RuntimePlatform EmbeddedLinuxArm32 = 40;
	public const RuntimePlatform EmbeddedLinuxX64 = 41;
	public const RuntimePlatform EmbeddedLinuxX86 = 42;
	public const RuntimePlatform LinuxServer = 43;
	public const RuntimePlatform WindowsServer = 44;
	public const RuntimePlatform OSXServer = 45;
	public const RuntimePlatform QNXArm32 = 46;
	public const RuntimePlatform QNXArm64 = 47;
	public const RuntimePlatform QNXX64 = 48;
	public const RuntimePlatform QNXX86 = 49;
	public const RuntimePlatform VisionOS = 50;
}

// Namespace: UnityEngine
public enum SystemLanguage // TypeDefIndex: 13951
{
	// Fields
	public int value__; // 0x0
	public const SystemLanguage Afrikaans = 0;
	public const SystemLanguage Arabic = 1;
	public const SystemLanguage Basque = 2;
	public const SystemLanguage Belarusian = 3;
	public const SystemLanguage Bulgarian = 4;
	public const SystemLanguage Catalan = 5;
	public const SystemLanguage Chinese = 6;
	public const SystemLanguage Czech = 7;
	public const SystemLanguage Danish = 8;
	public const SystemLanguage Dutch = 9;
	public const SystemLanguage English = 10;
	public const SystemLanguage Estonian = 11;
	public const SystemLanguage Faroese = 12;
	public const SystemLanguage Finnish = 13;
	public const SystemLanguage French = 14;
	public const SystemLanguage German = 15;
	public const SystemLanguage Greek = 16;
	public const SystemLanguage Hebrew = 17;
	public const SystemLanguage Icelandic = 19;
	public const SystemLanguage Indonesian = 20;
	public const SystemLanguage Italian = 21;
	public const SystemLanguage Japanese = 22;
	public const SystemLanguage Korean = 23;
	public const SystemLanguage Latvian = 24;
	public const SystemLanguage Lithuanian = 25;
	public const SystemLanguage Norwegian = 26;
	public const SystemLanguage Polish = 27;
	public const SystemLanguage Portuguese = 28;
	public const SystemLanguage Romanian = 29;
	public const SystemLanguage Russian = 30;
	public const SystemLanguage SerboCroatian = 31;
	public const SystemLanguage Slovak = 32;
	public const SystemLanguage Slovenian = 33;
	public const SystemLanguage Spanish = 34;
	public const SystemLanguage Swedish = 35;
	public const SystemLanguage Thai = 36;
	public const SystemLanguage Turkish = 37;
	public const SystemLanguage Ukrainian = 38;
	public const SystemLanguage Vietnamese = 39;
	public const SystemLanguage ChineseSimplified = 40;
	public const SystemLanguage ChineseTraditional = 41;
	public const SystemLanguage Hindi = 42;
	public const SystemLanguage Unknown = 43;
	public const SystemLanguage Hungarian = 18;
}

// Namespace: UnityEngine
public enum LogType // TypeDefIndex: 13952
{
	// Fields
	public int value__; // 0x0
	public const LogType Error = 0;
	public const LogType Assert = 1;
	public const LogType Warning = 2;
	public const LogType Log = 3;
	public const LogType Exception = 4;
}

// Namespace: UnityEngine
public enum LogOption // TypeDefIndex: 13953
{
	// Fields
	public int value__; // 0x0
	public const LogOption None = 0;
	public const LogOption NoStacktrace = 1;
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Export/Bootstrap/BootConfig.bindings.h")]
internal class BootConfigData // TypeDefIndex: 13954
{
	// Fields
	private IntPtr m_Ptr; // 0x10

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x244CD70 Offset: 0x244BF70 VA: 0x18244CD70
	private static BootConfigData WrapBootConfigData(IntPtr nativeHandle) { }

	// RVA: 0x244CE20 Offset: 0x244C020 VA: 0x18244CE20
	private void .ctor(IntPtr nativeHandle) { }
}

// Namespace: UnityEngine
[UsedByNativeCode]
public struct CachedAssetBundle // TypeDefIndex: 13955
{
	// Fields
	private string m_Name; // 0x0
	private Hash128 m_Hash; // 0x8

	// Properties
	public string name { get; }
	public Hash128 hash { get; }

	// Methods

	// RVA: 0x1314440 Offset: 0x1313640 VA: 0x181314440
	public void .ctor(string name, Hash128 hash) { }

	// RVA: 0xA55380 Offset: 0xA54580 VA: 0x180A55380
	public string get_name() { }

	// RVA: 0x244E130 Offset: 0x244D330 VA: 0x18244E130
	public Hash128 get_hash() { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Misc/Cache.h")]
[StaticAccessor("CacheWrapper", 2)]
public struct Cache : IEquatable<Cache> // TypeDefIndex: 13956
{
	// Fields
	private int m_Handle; // 0x0

	// Properties
	internal int handle { get; }
	public bool valid { get; }
	public string path { get; }
	public long maximumAvailableStorageSpace { set; }
	public int expirationDelay { set; }

	// Methods

	// RVA: 0x244E020 Offset: 0x244D220 VA: 0x18244E020
	internal int get_handle() { }

	// RVA: 0x244E020 Offset: 0x244D220 VA: 0x18244E020 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x244DF80 Offset: 0x244D180 VA: 0x18244DF80 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x244E010 Offset: 0x244D210 VA: 0x18244E010 Slot: 4
	public bool Equals(Cache other) { }

	// RVA: 0x244E070 Offset: 0x244D270 VA: 0x18244E070
	public bool get_valid() { }

	// RVA: 0x244DEC0 Offset: 0x244D0C0 VA: 0x18244DEC0
	internal static bool Cache_IsValid(int handle) { }

	// RVA: 0x244E030 Offset: 0x244D230 VA: 0x18244E030
	public string get_path() { }

	[NativeThrows]
	// RVA: 0x244DE80 Offset: 0x244D080 VA: 0x18244DE80
	internal static string Cache_GetPath(int handle) { }

	// RVA: 0x244E0F0 Offset: 0x244D2F0 VA: 0x18244E0F0
	public void set_maximumAvailableStorageSpace(long value) { }

	[NativeThrows]
	// RVA: 0x244DF40 Offset: 0x244D140 VA: 0x18244DF40
	internal static void Cache_SetMaximumDiskSpaceAvailable(int handle, long value) { }

	// RVA: 0x244E0B0 Offset: 0x244D2B0 VA: 0x18244E0B0
	public void set_expirationDelay(int value) { }

	[NativeThrows]
	// RVA: 0x244DF00 Offset: 0x244D100 VA: 0x18244DF00
	internal static void Cache_SetExpirationDelay(int handle, int value) { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Misc/CachingManager.h")]
[StaticAccessor("GetCachingManager()", 0)]
public sealed class Caching // TypeDefIndex: 13957
{
	// Properties
	public static bool compressionEnabled { set; }
	public static bool ready { get; }
	[StaticAccessor("CachingManagerWrapper", 2)]
	public static Cache defaultCache { get; }
	[StaticAccessor("CachingManagerWrapper", 2)]
	public static Cache currentCacheForWriting { get; set; }

	// Methods

	// RVA: 0x244EB50 Offset: 0x244DD50 VA: 0x18244EB50
	public static void set_compressionEnabled(bool value) { }

	[NativeName("GetIsReady")]
	// RVA: 0x244EB20 Offset: 0x244DD20 VA: 0x18244EB20
	public static bool get_ready() { }

	// RVA: 0x244E5E0 Offset: 0x244D7E0 VA: 0x18244E5E0
	public static bool ClearCachedVersion(string assetBundleName, Hash128 hash) { }

	[NativeName("ClearCachedVersion")]
	// RVA: 0x244E590 Offset: 0x244D790 VA: 0x18244E590
	internal static bool ClearCachedVersionInternal(string assetBundleName, Hash128 hash) { }

	// RVA: 0x244E740 Offset: 0x244D940 VA: 0x18244E740
	public static bool ClearOtherCachedVersions(string assetBundleName, Hash128 hash) { }

	// RVA: 0x244E4A0 Offset: 0x244D6A0 VA: 0x18244E4A0
	public static bool ClearAllCachedVersions(string assetBundleName) { }

	// RVA: 0x244E6E0 Offset: 0x244D8E0 VA: 0x18244E6E0
	internal static bool ClearCachedVersions(string assetBundleName, Hash128 hash, bool keepInputVersion) { }

	// RVA: 0x244E950 Offset: 0x244DB50 VA: 0x18244E950
	public static bool IsVersionCached(CachedAssetBundle cachedBundle) { }

	[NativeName("IsCached")]
	// RVA: 0x244E8F0 Offset: 0x244DAF0 VA: 0x18244E8F0
	internal static bool IsVersionCached(string url, string assetBundleName, Hash128 hash) { }

	// RVA: 0x244E200 Offset: 0x244D400 VA: 0x18244E200
	public static Cache AddCache(string cachePath) { }

	[NativeName("AddCachePath")]
	// RVA: 0x244E1A0 Offset: 0x244D3A0 VA: 0x18244E1A0
	internal static Cache AddCache(string cachePath, bool isReadonly) { }

	[StaticAccessor("CachingManagerWrapper", 2)]
	[NativeThrows]
	[NativeName("Caching_GetCacheHandleByPath")]
	// RVA: 0x244E840 Offset: 0x244DA40 VA: 0x18244E840
	public static Cache GetCacheByPath(string cachePath) { }

	[NativeName("Caching_GetDefaultCacheHandle")]
	// RVA: 0x244EAE0 Offset: 0x244DCE0 VA: 0x18244EAE0
	public static Cache get_defaultCache() { }

	[NativeName("Caching_GetCurrentCacheHandle")]
	// RVA: 0x244EA60 Offset: 0x244DC60 VA: 0x18244EA60
	public static Cache get_currentCacheForWriting() { }

	[NativeName("Caching_SetCurrentCacheByHandle")]
	[NativeThrows]
	// RVA: 0x244EBD0 Offset: 0x244DDD0 VA: 0x18244EBD0
	public static void set_currentCacheForWriting(Cache value) { }

	// RVA: 0x244E540 Offset: 0x244D740 VA: 0x18244E540
	private static bool ClearCachedVersionInternal_Injected(string assetBundleName, ref Hash128 hash) { }

	// RVA: 0x244E680 Offset: 0x244D880 VA: 0x18244E680
	private static bool ClearCachedVersions_Injected(string assetBundleName, ref Hash128 hash, bool keepInputVersion) { }

	// RVA: 0x244E890 Offset: 0x244DA90 VA: 0x18244E890
	private static bool IsVersionCached_Injected(string url, string assetBundleName, ref Hash128 hash) { }

	// RVA: 0x244E140 Offset: 0x244D340 VA: 0x18244E140
	private static void AddCache_Injected(string cachePath, bool isReadonly, out Cache ret) { }

	// RVA: 0x244E7F0 Offset: 0x244D9F0 VA: 0x18244E7F0
	private static void GetCacheByPath_Injected(string cachePath, out Cache ret) { }

	// RVA: 0x244EAA0 Offset: 0x244DCA0 VA: 0x18244EAA0
	private static void get_defaultCache_Injected(out Cache ret) { }

	// RVA: 0x244EA20 Offset: 0x244DC20 VA: 0x18244EA20
	private static void get_currentCacheForWriting_Injected(out Cache ret) { }

	// RVA: 0x244EB90 Offset: 0x244DD90 VA: 0x18244EB90
	private static void set_currentCacheForWriting_Injected(ref Cache value) { }
}

// Namespace: 
internal enum Camera.ProjectionMatrixMode // TypeDefIndex: 13958
{
	// Fields
	public int value__; // 0x0
	public const Camera.ProjectionMatrixMode Explicit = 0;
	public const Camera.ProjectionMatrixMode Implicit = 1;
	public const Camera.ProjectionMatrixMode PhysicalPropertiesBased = 2;
}

// Namespace: 
public enum Camera.GateFitMode // TypeDefIndex: 13959
{
	// Fields
	public int value__; // 0x0
	public const Camera.GateFitMode Vertical = 1;
	public const Camera.GateFitMode Horizontal = 2;
	public const Camera.GateFitMode Fill = 3;
	public const Camera.GateFitMode Overscan = 4;
	public const Camera.GateFitMode None = 0;
}

// Namespace: 
public struct Camera.GateFitParameters // TypeDefIndex: 13960
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Camera.GateFitMode <mode>k__BackingField; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private float <aspect>k__BackingField; // 0x4

	// Properties
	public Camera.GateFitMode mode { get; }
	public float aspect { get; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Camera.GateFitMode get_mode() { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x439FB0 Offset: 0x4391B0 VA: 0x180439FB0
	public float get_aspect() { }
}

// Namespace: 
public enum Camera.StereoscopicEye // TypeDefIndex: 13961
{
	// Fields
	public int value__; // 0x0
	public const Camera.StereoscopicEye Left = 0;
	public const Camera.StereoscopicEye Right = 1;
}

// Namespace: 
public enum Camera.MonoOrStereoscopicEye // TypeDefIndex: 13962
{
	// Fields
	public int value__; // 0x0
	public const Camera.MonoOrStereoscopicEye Left = 0;
	public const Camera.MonoOrStereoscopicEye Right = 1;
	public const Camera.MonoOrStereoscopicEye Mono = 2;
}

// Namespace: 
public enum Camera.SceneViewFilterMode // TypeDefIndex: 13963
{
	// Fields
	public int value__; // 0x0
	public const Camera.SceneViewFilterMode Off = 0;
	public const Camera.SceneViewFilterMode ShowFiltered = 1;
}

// Namespace: 
[Obsolete("The RenderRequest struct is obsolete, use the function overload with RequestData of supported types such as RenderPipeline.StandardRequest", True)]
public enum Camera.RenderRequestMode // TypeDefIndex: 13964
{
	// Fields
	public int value__; // 0x0
	public const Camera.RenderRequestMode None = 0;
	public const Camera.RenderRequestMode ObjectId = 1;
	public const Camera.RenderRequestMode Depth = 2;
	public const Camera.RenderRequestMode VertexNormal = 3;
	public const Camera.RenderRequestMode WorldPosition = 4;
	public const Camera.RenderRequestMode EntityId = 5;
	public const Camera.RenderRequestMode BaseColor = 6;
	public const Camera.RenderRequestMode SpecularColor = 7;
	public const Camera.RenderRequestMode Metallic = 8;
	public const Camera.RenderRequestMode Emission = 9;
	public const Camera.RenderRequestMode Normal = 10;
	public const Camera.RenderRequestMode Smoothness = 11;
	public const Camera.RenderRequestMode Occlusion = 12;
	public const Camera.RenderRequestMode DiffuseColor = 13;
}

// Namespace: 
[Obsolete("The RenderRequest struct is obsolete, use the function overload with RequestData of supported types such as RenderPipeline.StandardRequest", True)]
public enum Camera.RenderRequestOutputSpace // TypeDefIndex: 13965
{
	// Fields
	public int value__; // 0x0
	public const Camera.RenderRequestOutputSpace ScreenSpace = -1;
	public const Camera.RenderRequestOutputSpace UV0 = 0;
	public const Camera.RenderRequestOutputSpace UV1 = 1;
	public const Camera.RenderRequestOutputSpace UV2 = 2;
	public const Camera.RenderRequestOutputSpace UV3 = 3;
	public const Camera.RenderRequestOutputSpace UV4 = 4;
	public const Camera.RenderRequestOutputSpace UV5 = 5;
	public const Camera.RenderRequestOutputSpace UV6 = 6;
	public const Camera.RenderRequestOutputSpace UV7 = 7;
	public const Camera.RenderRequestOutputSpace UV8 = 8;
}

// Namespace: 
[Obsolete("The RenderRequest struct is obsolete, use the function overload with RequestData of supported types such as RenderPipeline.StandardRequest", True)]
public struct Camera.RenderRequest // TypeDefIndex: 13966
{
	// Fields
	private readonly Camera.RenderRequestMode m_CameraRenderMode; // 0x0
	private readonly RenderTexture m_ResultRT; // 0x8
	private readonly Camera.RenderRequestOutputSpace m_OutputSpace; // 0x10
}

// Namespace: 
public sealed class Camera.CameraCallback : MulticastDelegate // TypeDefIndex: 13967
{
	// Methods

	// RVA: 0x4047F0 Offset: 0x4039F0 VA: 0x1804047F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(Camera cam) { }
}

// Namespace: UnityEngine
[UsedByNativeCode]
[NativeHeader("Runtime/Camera/RenderManager.h")]
[NativeHeader("Runtime/Camera/Camera.h")]
[NativeHeader("Runtime/Graphics/CommandBuffer/RenderingCommandBuffer.h")]
[NativeHeader("Runtime/GfxDevice/GfxDeviceTypes.h")]
[NativeHeader("Runtime/Misc/GameObjectUtility.h")]
[NativeHeader("Runtime/Graphics/RenderTexture.h")]
[NativeHeader("Runtime/Shaders/Shader.h")]
[RequireComponent(typeof(Transform))]
public sealed class Camera : Behaviour // TypeDefIndex: 13968
{
	// Fields
	public const float kMinAperture = 0,7;
	public const float kMaxAperture = 32;
	public const int kMinBladeCount = 3;
	public const int kMaxBladeCount = 11;
	public static Camera.CameraCallback onPreCull; // 0x0
	public static Camera.CameraCallback onPreRender; // 0x8
	public static Camera.CameraCallback onPostRender; // 0x10

	// Properties
	[NativeProperty("Near")]
	public float nearClipPlane { get; set; }
	[NativeProperty("Far")]
	public float farClipPlane { get; set; }
	[NativeProperty("VerticalFieldOfView")]
	public float fieldOfView { get; set; }
	public RenderingPath renderingPath { get; set; }
	public RenderingPath actualRenderingPath { get; }
	public bool allowHDR { get; set; }
	public bool allowMSAA { get; set; }
	public bool allowDynamicResolution { get; set; }
	[NativeProperty("ForceIntoRT")]
	public bool forceIntoRenderTexture { get; set; }
	public float orthographicSize { get; set; }
	public bool orthographic { get; set; }
	public OpaqueSortMode opaqueSortMode { get; set; }
	public TransparencySortMode transparencySortMode { get; set; }
	public Vector3 transparencySortAxis { get; set; }
	public float depth { get; set; }
	public float aspect { get; set; }
	public Vector3 velocity { get; }
	public int cullingMask { get; set; }
	public int eventMask { get; set; }
	public bool layerCullSpherical { get; set; }
	public CameraType cameraType { get; set; }
	internal Material skyboxMaterial { get; }
	[NativeConditional("UNITY_EDITOR")]
	public ulong overrideSceneCullingMask { get; set; }
	[NativeConditional("UNITY_EDITOR")]
	internal ulong sceneCullingMask { get; }
	public float[] layerCullDistances { get; set; }
	[Obsolete("PreviewCullingLayer is obsolete. Use scene culling masks instead.", False)]
	internal static int PreviewCullingLayer { get; }
	public bool useOcclusionCulling { get; set; }
	public Matrix4x4 cullingMatrix { get; set; }
	public Color backgroundColor { get; set; }
	public CameraClearFlags clearFlags { get; set; }
	public DepthTextureMode depthTextureMode { get; set; }
	public bool clearStencilAfterLightingPass { get; set; }
	internal Camera.ProjectionMatrixMode projectionMatrixMode { get; }
	public bool usePhysicalProperties { get; set; }
	public int iso { get; set; }
	public float shutterSpeed { get; set; }
	public float aperture { get; set; }
	public float focusDistance { get; set; }
	public float focalLength { get; set; }
	public int bladeCount { get; set; }
	public Vector2 curvature { get; set; }
	public float barrelClipping { get; set; }
	public float anamorphism { get; set; }
	public Vector2 sensorSize { get; set; }
	public Vector2 lensShift { get; set; }
	public Camera.GateFitMode gateFit { get; set; }
	[NativeProperty("NormalizedViewportRect")]
	public Rect rect { get; set; }
	[NativeProperty("ScreenViewportRect")]
	public Rect pixelRect { get; set; }
	public int pixelWidth { get; }
	public int pixelHeight { get; }
	public int scaledPixelWidth { get; }
	public int scaledPixelHeight { get; }
	public RenderTexture targetTexture { get; set; }
	public RenderTexture activeTexture { get; }
	public int targetDisplay { get; set; }
	public Matrix4x4 cameraToWorldMatrix { get; }
	public Matrix4x4 worldToCameraMatrix { get; set; }
	public Matrix4x4 projectionMatrix { get; set; }
	public Matrix4x4 nonJitteredProjectionMatrix { get; set; }
	[NativeProperty("UseJitteredProjectionMatrixForTransparent")]
	public bool useJitteredProjectionMatrixForTransparentRendering { get; set; }
	public Matrix4x4 previousViewProjectionMatrix { get; }
	public static Camera main { get; }
	public static Camera current { get; }
	public Scene scene { get; set; }
	public bool stereoEnabled { get; }
	public float stereoSeparation { get; set; }
	public float stereoConvergence { get; set; }
	public bool areVRStereoViewMatricesWithinSingleCullTolerance { get; }
	public StereoTargetEyeMask stereoTargetEye { get; set; }
	public Camera.MonoOrStereoscopicEye stereoActiveEye { get; }
	public static int allCamerasCount { get; }
	public static Camera[] allCameras { get; }
	[NativeConditional("UNITY_EDITOR")]
	public Camera.SceneViewFilterMode sceneViewFilterMode { get; }
	public int commandBufferCount { get; }

	// Methods

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }

	// RVA: 0x24522B0 Offset: 0x24514B0 VA: 0x1824522B0
	public float get_nearClipPlane() { }

	// RVA: 0x2453920 Offset: 0x2452B20 VA: 0x182453920
	public void set_nearClipPlane(float value) { }

	// RVA: 0x2451FE0 Offset: 0x24511E0 VA: 0x182451FE0
	public float get_farClipPlane() { }

	// RVA: 0x2453590 Offset: 0x2452790 VA: 0x182453590
	public void set_farClipPlane(float value) { }

	// RVA: 0x2452020 Offset: 0x2451220 VA: 0x182452020
	public float get_fieldOfView() { }

	// RVA: 0x24535E0 Offset: 0x24527E0 VA: 0x1824535E0
	public void set_fieldOfView(float value) { }

	// RVA: 0x2452800 Offset: 0x2451A00 VA: 0x182452800
	public RenderingPath get_renderingPath() { }

	// RVA: 0x2453D20 Offset: 0x2452F20 VA: 0x182453D20
	public void set_renderingPath(RenderingPath value) { }

	[NativeName("CalculateRenderingPath")]
	// RVA: 0x2451800 Offset: 0x2450A00 VA: 0x182451800
	public RenderingPath get_actualRenderingPath() { }

	// RVA: 0x24503B0 Offset: 0x244F5B0 VA: 0x1824503B0
	public void Reset() { }

	// RVA: 0x2451910 Offset: 0x2450B10 VA: 0x182451910
	public bool get_allowHDR() { }

	// RVA: 0x2452FC0 Offset: 0x24521C0 VA: 0x182452FC0
	public void set_allowHDR(bool value) { }

	// RVA: 0x2451950 Offset: 0x2450B50 VA: 0x182451950
	public bool get_allowMSAA() { }

	// RVA: 0x2453010 Offset: 0x2452210 VA: 0x182453010
	public void set_allowMSAA(bool value) { }

	// RVA: 0x24518D0 Offset: 0x2450AD0 VA: 0x1824518D0
	public bool get_allowDynamicResolution() { }

	// RVA: 0x2452F70 Offset: 0x2452170 VA: 0x182452F70
	public void set_allowDynamicResolution(bool value) { }

	// RVA: 0x24520E0 Offset: 0x24512E0 VA: 0x1824520E0
	public bool get_forceIntoRenderTexture() { }

	// RVA: 0x24536D0 Offset: 0x24528D0 VA: 0x1824536D0
	public void set_forceIntoRenderTexture(bool value) { }

	// RVA: 0x24523E0 Offset: 0x24515E0 VA: 0x1824523E0
	public float get_orthographicSize() { }

	// RVA: 0x2453A50 Offset: 0x2452C50 VA: 0x182453A50
	public void set_orthographicSize(float value) { }

	// RVA: 0x2452420 Offset: 0x2451620 VA: 0x182452420
	public bool get_orthographic() { }

	// RVA: 0x2453AA0 Offset: 0x2452CA0 VA: 0x182453AA0
	public void set_orthographic(bool value) { }

	// RVA: 0x24523A0 Offset: 0x24515A0 VA: 0x1824523A0
	public OpaqueSortMode get_opaqueSortMode() { }

	// RVA: 0x2453A10 Offset: 0x2452C10 VA: 0x182453A10
	public void set_opaqueSortMode(OpaqueSortMode value) { }

	// RVA: 0x2452D20 Offset: 0x2451F20 VA: 0x182452D20
	public TransparencySortMode get_transparencySortMode() { }

	// RVA: 0x24540E0 Offset: 0x24532E0 VA: 0x1824540E0
	public void set_transparencySortMode(TransparencySortMode value) { }

	// RVA: 0x2452CD0 Offset: 0x2451ED0 VA: 0x182452CD0
	public Vector3 get_transparencySortAxis() { }

	// RVA: 0x2454090 Offset: 0x2453290 VA: 0x182454090
	public void set_transparencySortAxis(Vector3 value) { }

	// RVA: 0x2450330 Offset: 0x244F530 VA: 0x182450330
	public void ResetTransparencySortSettings() { }

	// RVA: 0x2451F60 Offset: 0x2451160 VA: 0x182451F60
	public float get_depth() { }

	// RVA: 0x2453500 Offset: 0x2452700 VA: 0x182453500
	public void set_depth(float value) { }

	// RVA: 0x2451A50 Offset: 0x2450C50 VA: 0x182451A50
	public float get_aspect() { }

	// RVA: 0x2453100 Offset: 0x2452300 VA: 0x182453100
	public void set_aspect(float value) { }

	// RVA: 0x24501B0 Offset: 0x244F3B0 VA: 0x1824501B0
	public void ResetAspect() { }

	// RVA: 0x2452E70 Offset: 0x2452070 VA: 0x182452E70
	public Vector3 get_velocity() { }

	// RVA: 0x2451D60 Offset: 0x2450F60 VA: 0x182451D60
	public int get_cullingMask() { }

	// RVA: 0x2453350 Offset: 0x2452550 VA: 0x182453350
	public void set_cullingMask(int value) { }

	// RVA: 0x2451FA0 Offset: 0x24511A0 VA: 0x182451FA0
	public int get_eventMask() { }

	// RVA: 0x2453550 Offset: 0x2452750 VA: 0x182453550
	public void set_eventMask(int value) { }

	// RVA: 0x24521A0 Offset: 0x24513A0 VA: 0x1824521A0
	public bool get_layerCullSpherical() { }

	// RVA: 0x2453840 Offset: 0x2452A40 VA: 0x182453840
	public void set_layerCullSpherical(bool value) { }

	// RVA: 0x2451C60 Offset: 0x2450E60 VA: 0x182451C60
	public CameraType get_cameraType() { }

	// RVA: 0x2453280 Offset: 0x2452480 VA: 0x182453280
	public void set_cameraType(CameraType value) { }

	// RVA: 0x2452A80 Offset: 0x2451C80 VA: 0x182452A80
	internal Material get_skyboxMaterial() { }

	// RVA: 0x2452460 Offset: 0x2451660 VA: 0x182452460
	public ulong get_overrideSceneCullingMask() { }

	// RVA: 0x2453AF0 Offset: 0x2452CF0 VA: 0x182453AF0
	public void set_overrideSceneCullingMask(ulong value) { }

	// RVA: 0x24528C0 Offset: 0x2451AC0 VA: 0x1824528C0
	internal ulong get_sceneCullingMask() { }

	[FreeFunction("CameraScripting::GetLayerCullDistances", HasExplicitThis = True)]
	// RVA: 0x244FA30 Offset: 0x244EC30 VA: 0x18244FA30
	private float[] GetLayerCullDistances() { }

	[FreeFunction("CameraScripting::SetLayerCullDistances", HasExplicitThis = True)]
	// RVA: 0x2450860 Offset: 0x244FA60 VA: 0x182450860
	private void SetLayerCullDistances(float[] d) { }

	// RVA: 0x244FA30 Offset: 0x244EC30 VA: 0x18244FA30
	public float[] get_layerCullDistances() { }

	// RVA: 0x24537A0 Offset: 0x24529A0 VA: 0x1824537A0
	public void set_layerCullDistances(float[] value) { }

	// RVA: 0x24517B0 Offset: 0x24509B0 VA: 0x1824517B0
	internal static int get_PreviewCullingLayer() { }

	// RVA: 0x2452DA0 Offset: 0x2451FA0 VA: 0x182452DA0
	public bool get_useOcclusionCulling() { }

	// RVA: 0x2454170 Offset: 0x2453370 VA: 0x182454170
	public void set_useOcclusionCulling(bool value) { }

	// RVA: 0x2451DF0 Offset: 0x2450FF0 VA: 0x182451DF0
	public Matrix4x4 get_cullingMatrix() { }

	// RVA: 0x24533E0 Offset: 0x24525E0 VA: 0x1824533E0
	public void set_cullingMatrix(Matrix4x4 value) { }

	// RVA: 0x24501F0 Offset: 0x244F3F0 VA: 0x1824501F0
	public void ResetCullingMatrix() { }

	// RVA: 0x2451AE0 Offset: 0x2450CE0 VA: 0x182451AE0
	public Color get_backgroundColor() { }

	// RVA: 0x24531A0 Offset: 0x24523A0 VA: 0x1824531A0
	public void set_backgroundColor(Color value) { }

	// RVA: 0x2451CA0 Offset: 0x2450EA0 VA: 0x182451CA0
	public CameraClearFlags get_clearFlags() { }

	// RVA: 0x24532C0 Offset: 0x24524C0 VA: 0x1824532C0
	public void set_clearFlags(CameraClearFlags value) { }

	// RVA: 0x2451F20 Offset: 0x2451120 VA: 0x182451F20
	public DepthTextureMode get_depthTextureMode() { }

	// RVA: 0x24534C0 Offset: 0x24526C0 VA: 0x1824534C0
	public void set_depthTextureMode(DepthTextureMode value) { }

	// RVA: 0x2451CE0 Offset: 0x2450EE0 VA: 0x182451CE0
	public bool get_clearStencilAfterLightingPass() { }

	// RVA: 0x2453300 Offset: 0x2452500 VA: 0x182453300
	public void set_clearStencilAfterLightingPass(bool value) { }

	// RVA: 0x24508B0 Offset: 0x244FAB0 VA: 0x1824508B0
	public void SetReplacementShader(Shader shader, string replacementTag) { }

	// RVA: 0x2450270 Offset: 0x244F470 VA: 0x182450270
	public void ResetReplacementShader() { }

	// RVA: 0x2452670 Offset: 0x2451870 VA: 0x182452670
	internal Camera.ProjectionMatrixMode get_projectionMatrixMode() { }

	// RVA: 0x2452DE0 Offset: 0x2451FE0 VA: 0x182452DE0
	public bool get_usePhysicalProperties() { }

	// RVA: 0x24541C0 Offset: 0x24533C0 VA: 0x1824541C0
	public void set_usePhysicalProperties(bool value) { }

	// RVA: 0x2452160 Offset: 0x2451360 VA: 0x182452160
	public int get_iso() { }

	// RVA: 0x2453760 Offset: 0x2452960 VA: 0x182453760
	public void set_iso(int value) { }

	// RVA: 0x2452A40 Offset: 0x2451C40 VA: 0x182452A40
	public float get_shutterSpeed() { }

	// RVA: 0x2453E80 Offset: 0x2453080 VA: 0x182453E80
	public void set_shutterSpeed(float value) { }

	// RVA: 0x24519D0 Offset: 0x2450BD0 VA: 0x1824519D0
	public float get_aperture() { }

	// RVA: 0x24530B0 Offset: 0x24522B0 VA: 0x1824530B0
	public void set_aperture(float value) { }

	// RVA: 0x24520A0 Offset: 0x24512A0 VA: 0x1824520A0
	public float get_focusDistance() { }

	// RVA: 0x2453680 Offset: 0x2452880 VA: 0x182453680
	public void set_focusDistance(float value) { }

	// RVA: 0x2452060 Offset: 0x2451260 VA: 0x182452060
	public float get_focalLength() { }

	// RVA: 0x2453630 Offset: 0x2452830 VA: 0x182453630
	public void set_focalLength(float value) { }

	// RVA: 0x2451B70 Offset: 0x2450D70 VA: 0x182451B70
	public int get_bladeCount() { }

	// RVA: 0x2453240 Offset: 0x2452440 VA: 0x182453240
	public void set_bladeCount(int value) { }

	// RVA: 0x2451ED0 Offset: 0x24510D0 VA: 0x182451ED0
	public Vector2 get_curvature() { }

	// RVA: 0x2453480 Offset: 0x2452680 VA: 0x182453480
	public void set_curvature(Vector2 value) { }

	// RVA: 0x2451B30 Offset: 0x2450D30 VA: 0x182451B30
	public float get_barrelClipping() { }

	// RVA: 0x24531F0 Offset: 0x24523F0 VA: 0x1824531F0
	public void set_barrelClipping(float value) { }

	// RVA: 0x2451990 Offset: 0x2450B90 VA: 0x182451990
	public float get_anamorphism() { }

	// RVA: 0x2453060 Offset: 0x2452260 VA: 0x182453060
	public void set_anamorphism(float value) { }

	// RVA: 0x24529F0 Offset: 0x2451BF0 VA: 0x1824529F0
	public Vector2 get_sensorSize() { }

	// RVA: 0x2453E40 Offset: 0x2453040 VA: 0x182453E40
	public void set_sensorSize(Vector2 value) { }

	// RVA: 0x2452230 Offset: 0x2451430 VA: 0x182452230
	public Vector2 get_lensShift() { }

	// RVA: 0x24538E0 Offset: 0x2452AE0 VA: 0x1824538E0
	public void set_lensShift(Vector2 value) { }

	// RVA: 0x2452120 Offset: 0x2451320 VA: 0x182452120
	public Camera.GateFitMode get_gateFit() { }

	// RVA: 0x2453720 Offset: 0x2452920 VA: 0x182453720
	public void set_gateFit(Camera.GateFitMode value) { }

	// RVA: 0x244F950 Offset: 0x244EB50 VA: 0x18244F950
	public float GetGateFittedFieldOfView() { }

	// RVA: 0x244F9E0 Offset: 0x244EBE0 VA: 0x18244F9E0
	public Vector2 GetGateFittedLensShift() { }

	// RVA: 0x244FAC0 Offset: 0x244ECC0 VA: 0x18244FAC0
	internal Vector3 GetLocalSpaceAim() { }

	// RVA: 0x24527B0 Offset: 0x24519B0 VA: 0x1824527B0
	public Rect get_rect() { }

	// RVA: 0x2453CD0 Offset: 0x2452ED0 VA: 0x182453CD0
	public void set_rect(Rect value) { }

	// RVA: 0x2452530 Offset: 0x2451730 VA: 0x182452530
	public Rect get_pixelRect() { }

	// RVA: 0x2453B90 Offset: 0x2452D90 VA: 0x182453B90
	public void set_pixelRect(Rect value) { }

	[FreeFunction("CameraScripting::GetPixelWidth", HasExplicitThis = True)]
	// RVA: 0x2452580 Offset: 0x2451780 VA: 0x182452580
	public int get_pixelWidth() { }

	[FreeFunction("CameraScripting::GetPixelHeight", HasExplicitThis = True)]
	// RVA: 0x24524A0 Offset: 0x24516A0 VA: 0x1824524A0
	public int get_pixelHeight() { }

	[FreeFunction("CameraScripting::GetScaledPixelWidth", HasExplicitThis = True)]
	// RVA: 0x2452880 Offset: 0x2451A80 VA: 0x182452880
	public int get_scaledPixelWidth() { }

	[FreeFunction("CameraScripting::GetScaledPixelHeight", HasExplicitThis = True)]
	// RVA: 0x2452840 Offset: 0x2451A40 VA: 0x182452840
	public int get_scaledPixelHeight() { }

	// RVA: 0x2452C40 Offset: 0x2451E40 VA: 0x182452C40
	public RenderTexture get_targetTexture() { }

	// RVA: 0x2453FF0 Offset: 0x24531F0 VA: 0x182453FF0
	public void set_targetTexture(RenderTexture value) { }

	[NativeName("GetCurrentTargetTexture")]
	// RVA: 0x24517C0 Offset: 0x24509C0 VA: 0x1824517C0
	public RenderTexture get_activeTexture() { }

	// RVA: 0x2452C00 Offset: 0x2451E00 VA: 0x182452C00
	public int get_targetDisplay() { }

	// RVA: 0x2453FB0 Offset: 0x24531B0 VA: 0x182453FB0
	public void set_targetDisplay(int value) { }

	[FreeFunction("CameraScripting::SetTargetBuffers", HasExplicitThis = True)]
	// RVA: 0x2450AB0 Offset: 0x244FCB0 VA: 0x182450AB0
	private void SetTargetBuffersImpl(RenderBuffer color, RenderBuffer depth) { }

	// RVA: 0x2450BD0 Offset: 0x244FDD0 VA: 0x182450BD0
	public void SetTargetBuffers(RenderBuffer colorBuffer, RenderBuffer depthBuffer) { }

	[FreeFunction("CameraScripting::SetTargetBuffers", HasExplicitThis = True)]
	// RVA: 0x2450B70 Offset: 0x244FD70 VA: 0x182450B70
	private void SetTargetBuffersMRTImpl(RenderBuffer[] color, RenderBuffer depth) { }

	// RVA: 0x2450C20 Offset: 0x244FE20 VA: 0x182450C20
	public void SetTargetBuffers(RenderBuffer[] colorBuffer, RenderBuffer depthBuffer) { }

	// RVA: 0x244F760 Offset: 0x244E960 VA: 0x18244F760
	internal string[] GetCameraBufferWarnings() { }

	// RVA: 0x2451C00 Offset: 0x2450E00 VA: 0x182451C00
	public Matrix4x4 get_cameraToWorldMatrix() { }

	// RVA: 0x2452F10 Offset: 0x2452110 VA: 0x182452F10
	public Matrix4x4 get_worldToCameraMatrix() { }

	// RVA: 0x2454260 Offset: 0x2453460 VA: 0x182454260
	public void set_worldToCameraMatrix(Matrix4x4 value) { }

	// RVA: 0x2452700 Offset: 0x2451900 VA: 0x182452700
	public Matrix4x4 get_projectionMatrix() { }

	// RVA: 0x2453C30 Offset: 0x2452E30 VA: 0x182453C30
	public void set_projectionMatrix(Matrix4x4 value) { }

	// RVA: 0x2452340 Offset: 0x2451540 VA: 0x182452340
	public Matrix4x4 get_nonJitteredProjectionMatrix() { }

	// RVA: 0x24539C0 Offset: 0x2452BC0 VA: 0x1824539C0
	public void set_nonJitteredProjectionMatrix(Matrix4x4 value) { }

	// RVA: 0x2452D60 Offset: 0x2451F60 VA: 0x182452D60
	public bool get_useJitteredProjectionMatrixForTransparentRendering() { }

	// RVA: 0x2454120 Offset: 0x2453320 VA: 0x182454120
	public void set_useJitteredProjectionMatrixForTransparentRendering(bool value) { }

	// RVA: 0x2452610 Offset: 0x2451810 VA: 0x182452610
	public Matrix4x4 get_previousViewProjectionMatrix() { }

	// RVA: 0x2450370 Offset: 0x244F570 VA: 0x182450370
	public void ResetWorldToCameraMatrix() { }

	// RVA: 0x2450230 Offset: 0x244F430 VA: 0x182450230
	public void ResetProjectionMatrix() { }

	[FreeFunction("CameraScripting::CalculateObliqueMatrix", HasExplicitThis = True)]
	// RVA: 0x244F1C0 Offset: 0x244E3C0 VA: 0x18244F1C0
	public Matrix4x4 CalculateObliqueMatrix(Vector4 clipPlane) { }

	// RVA: 0x24515D0 Offset: 0x24507D0 VA: 0x1824515D0
	public Vector3 WorldToScreenPoint(Vector3 position, Camera.MonoOrStereoscopicEye eye) { }

	// RVA: 0x2451740 Offset: 0x2450940 VA: 0x182451740
	public Vector3 WorldToViewportPoint(Vector3 position, Camera.MonoOrStereoscopicEye eye) { }

	// RVA: 0x2451460 Offset: 0x2450660 VA: 0x182451460
	public Vector3 ViewportToWorldPoint(Vector3 position, Camera.MonoOrStereoscopicEye eye) { }

	// RVA: 0x2450760 Offset: 0x244F960 VA: 0x182450760
	public Vector3 ScreenToWorldPoint(Vector3 position, Camera.MonoOrStereoscopicEye eye) { }

	// RVA: 0x2451540 Offset: 0x2450740 VA: 0x182451540
	public Vector3 WorldToScreenPoint(Vector3 position) { }

	// RVA: 0x24516B0 Offset: 0x24508B0 VA: 0x1824516B0
	public Vector3 WorldToViewportPoint(Vector3 position) { }

	// RVA: 0x24513D0 Offset: 0x24505D0 VA: 0x1824513D0
	public Vector3 ViewportToWorldPoint(Vector3 position) { }

	// RVA: 0x24507D0 Offset: 0x244F9D0 VA: 0x1824507D0
	public Vector3 ScreenToWorldPoint(Vector3 position) { }

	// RVA: 0x2450690 Offset: 0x244F890 VA: 0x182450690
	public Vector3 ScreenToViewportPoint(Vector3 position) { }

	// RVA: 0x2451300 Offset: 0x2450500 VA: 0x182451300
	public Vector3 ViewportToScreenPoint(Vector3 position) { }

	// RVA: 0x244F8F0 Offset: 0x244EAF0 VA: 0x18244F8F0
	internal Vector2 GetFrustumPlaneSizeAt(float distance) { }

	// RVA: 0x24510D0 Offset: 0x24502D0 VA: 0x1824510D0
	private Ray ViewportPointToRay(Vector2 pos, Camera.MonoOrStereoscopicEye eye) { }

	// RVA: 0x24511F0 Offset: 0x24503F0 VA: 0x1824511F0
	public Ray ViewportPointToRay(Vector3 pos, Camera.MonoOrStereoscopicEye eye) { }

	// RVA: 0x2451140 Offset: 0x2450340 VA: 0x182451140
	public Ray ViewportPointToRay(Vector3 pos) { }

	// RVA: 0x24505C0 Offset: 0x244F7C0 VA: 0x1824505C0
	private Ray ScreenPointToRay(Vector2 pos, Camera.MonoOrStereoscopicEye eye) { }

	// RVA: 0x2450510 Offset: 0x244F710 VA: 0x182450510
	public Ray ScreenPointToRay(Vector3 pos, Camera.MonoOrStereoscopicEye eye) { }

	// RVA: 0x2450460 Offset: 0x244F660 VA: 0x182450460
	public Ray ScreenPointToRay(Vector3 pos) { }

	[FreeFunction("CameraScripting::CalculateViewportRayVectors", HasExplicitThis = True)]
	// RVA: 0x244EFC0 Offset: 0x244E1C0 VA: 0x18244EFC0
	private void CalculateFrustumCornersInternal(Rect viewport, float z, Camera.MonoOrStereoscopicEye eye, [Out] Vector3[] outCorners) { }

	// RVA: 0x244F030 Offset: 0x244E230 VA: 0x18244F030
	public void CalculateFrustumCorners(Rect viewport, float z, Camera.MonoOrStereoscopicEye eye, Vector3[] outCorners) { }

	[NativeName("CalculateProjectionMatrixFromPhysicalProperties")]
	// RVA: 0x244F2A0 Offset: 0x244E4A0 VA: 0x18244F2A0
	private static void CalculateProjectionMatrixFromPhysicalPropertiesInternal(out Matrix4x4 output, float focalLength, Vector2 sensorSize, Vector2 lensShift, float nearClip, float farClip, float gateAspect, Camera.GateFitMode gateFitMode) { }

	// RVA: 0x244F330 Offset: 0x244E530 VA: 0x18244F330
	public static void CalculateProjectionMatrixFromPhysicalProperties(out Matrix4x4 output, float focalLength, Vector2 sensorSize, Vector2 lensShift, float nearClip, float farClip, Camera.GateFitParameters gateFitParameters) { }

	[NativeName("FocalLengthToFieldOfView_Safe")]
	// RVA: 0x244F5C0 Offset: 0x244E7C0 VA: 0x18244F5C0
	public static float FocalLengthToFieldOfView(float focalLength, float sensorSize) { }

	[NativeName("FieldOfViewToFocalLength_Safe")]
	// RVA: 0x244F450 Offset: 0x244E650 VA: 0x18244F450
	public static float FieldOfViewToFocalLength(float fieldOfView, float sensorSize) { }

	[NativeName("HorizontalToVerticalFieldOfView_Safe")]
	// RVA: 0x244FD50 Offset: 0x244EF50 VA: 0x18244FD50
	public static float HorizontalToVerticalFieldOfView(float horizontalFieldOfView, float aspectRatio) { }

	// RVA: 0x2451010 Offset: 0x2450210 VA: 0x182451010
	public static float VerticalToHorizontalFieldOfView(float verticalFieldOfView, float aspectRatio) { }

	[FreeFunction("FindMainCamera")]
	// RVA: 0x2452280 Offset: 0x2451480 VA: 0x182452280
	public static Camera get_main() { }

	[FreeFunction("GetCurrentCameraPPtr")]
	// RVA: 0x2451E50 Offset: 0x2451050 VA: 0x182451E50
	public static Camera get_current() { }

	[FreeFunction("CameraScripting::GetScene", HasExplicitThis = True)]
	// RVA: 0x2452950 Offset: 0x2451B50 VA: 0x182452950
	public Scene get_scene() { }

	[FreeFunction("CameraScripting::SetScene", HasExplicitThis = True)]
	// RVA: 0x2453DB0 Offset: 0x2452FB0 VA: 0x182453DB0
	public void set_scene(Scene value) { }

	[NativeMethod("GetStereoEnabledForBuiltInOrSRP")]
	// RVA: 0x2452B40 Offset: 0x2451D40 VA: 0x182452B40
	public bool get_stereoEnabled() { }

	// RVA: 0x2452B80 Offset: 0x2451D80 VA: 0x182452B80
	public float get_stereoSeparation() { }

	// RVA: 0x2453F20 Offset: 0x2453120 VA: 0x182453F20
	public void set_stereoSeparation(float value) { }

	// RVA: 0x2452B00 Offset: 0x2451D00 VA: 0x182452B00
	public float get_stereoConvergence() { }

	// RVA: 0x2453ED0 Offset: 0x24530D0 VA: 0x182453ED0
	public void set_stereoConvergence(float value) { }

	[NativeName("AreVRStereoViewMatricesWithinSingleCullTolerance")]
	// RVA: 0x2451A10 Offset: 0x2450C10 VA: 0x182451A10
	public bool get_areVRStereoViewMatricesWithinSingleCullTolerance() { }

	// RVA: 0x2452BC0 Offset: 0x2451DC0 VA: 0x182452BC0
	public StereoTargetEyeMask get_stereoTargetEye() { }

	// RVA: 0x2453F70 Offset: 0x2453170 VA: 0x182453F70
	public void set_stereoTargetEye(StereoTargetEyeMask value) { }

	[FreeFunction("CameraScripting::GetStereoActiveEye", HasExplicitThis = True)]
	// RVA: 0x2452AC0 Offset: 0x2451CC0 VA: 0x182452AC0
	public Camera.MonoOrStereoscopicEye get_stereoActiveEye() { }

	// RVA: 0x244FB60 Offset: 0x244ED60 VA: 0x18244FB60
	public Matrix4x4 GetStereoNonJitteredProjectionMatrix(Camera.StereoscopicEye eye) { }

	[FreeFunction("CameraScripting::GetStereoViewMatrix", HasExplicitThis = True)]
	// RVA: 0x244FCE0 Offset: 0x244EEE0 VA: 0x18244FCE0
	public Matrix4x4 GetStereoViewMatrix(Camera.StereoscopicEye eye) { }

	// RVA: 0x244F410 Offset: 0x244E610 VA: 0x18244F410
	public void CopyStereoDeviceProjectionMatrixToNonJittered(Camera.StereoscopicEye eye) { }

	[FreeFunction("CameraScripting::GetStereoProjectionMatrix", HasExplicitThis = True)]
	// RVA: 0x244FC20 Offset: 0x244EE20 VA: 0x18244FC20
	public Matrix4x4 GetStereoProjectionMatrix(Camera.StereoscopicEye eye) { }

	// RVA: 0x2450960 Offset: 0x244FB60 VA: 0x182450960
	public void SetStereoProjectionMatrix(Camera.StereoscopicEye eye, Matrix4x4 matrix) { }

	// RVA: 0x24502B0 Offset: 0x244F4B0 VA: 0x1824502B0
	public void ResetStereoProjectionMatrices() { }

	// RVA: 0x2450A00 Offset: 0x244FC00 VA: 0x182450A00
	public void SetStereoViewMatrix(Camera.StereoscopicEye eye, Matrix4x4 matrix) { }

	// RVA: 0x24502F0 Offset: 0x244F4F0 VA: 0x1824502F0
	public void ResetStereoViewMatrices() { }

	[FreeFunction("CameraScripting::GetAllCamerasCount")]
	// RVA: 0x244F610 Offset: 0x244E810 VA: 0x18244F610
	private static int GetAllCamerasCount() { }

	[FreeFunction("CameraScripting::GetAllCameras")]
	// RVA: 0x244F640 Offset: 0x244E840 VA: 0x18244F640
	private static int GetAllCamerasImpl([Out] Camera[] cam) { }

	// RVA: 0x244F610 Offset: 0x244E810 VA: 0x18244F610
	public static int get_allCamerasCount() { }

	// RVA: 0x2451840 Offset: 0x2450A40 VA: 0x182451840
	public static Camera[] get_allCameras() { }

	// RVA: 0x244F680 Offset: 0x244E880 VA: 0x18244F680
	public static int GetAllCameras(Camera[] cameras) { }

	[FreeFunction("CameraScripting::RenderToCubemap", HasExplicitThis = True)]
	// RVA: 0x2450060 Offset: 0x244F260 VA: 0x182450060
	private bool RenderToCubemapImpl(Texture tex, int faceMask) { }

	// RVA: 0x2450060 Offset: 0x244F260 VA: 0x182450060
	public bool RenderToCubemap(Cubemap cubemap, int faceMask) { }

	// RVA: 0x24500C0 Offset: 0x244F2C0 VA: 0x1824500C0
	public bool RenderToCubemap(Cubemap cubemap) { }

	// RVA: 0x2450060 Offset: 0x244F260 VA: 0x182450060
	public bool RenderToCubemap(RenderTexture cubemap, int faceMask) { }

	// RVA: 0x24500C0 Offset: 0x244F2C0 VA: 0x1824500C0
	public bool RenderToCubemap(RenderTexture cubemap) { }

	[NativeConditional("UNITY_EDITOR")]
	// RVA: 0x244F850 Offset: 0x244EA50 VA: 0x18244F850
	private int GetFilterMode() { }

	// RVA: 0x244F850 Offset: 0x244EA50 VA: 0x18244F850
	public Camera.SceneViewFilterMode get_sceneViewFilterMode() { }

	[NativeName("RenderToCubemap")]
	// RVA: 0x244FFF0 Offset: 0x244F1F0 VA: 0x18244FFF0
	private bool RenderToCubemapEyeImpl(RenderTexture cubemap, int faceMask, Camera.MonoOrStereoscopicEye stereoEye) { }

	// RVA: 0x244FFF0 Offset: 0x244F1F0 VA: 0x18244FFF0
	public bool RenderToCubemap(RenderTexture cubemap, int faceMask, Camera.MonoOrStereoscopicEye stereoEye) { }

	[FreeFunction("CameraScripting::Render", HasExplicitThis = True)]
	// RVA: 0x2450170 Offset: 0x244F370 VA: 0x182450170
	public void Render() { }

	[FreeFunction("CameraScripting::RenderWithShader", HasExplicitThis = True)]
	// RVA: 0x2450110 Offset: 0x244F310 VA: 0x182450110
	public void RenderWithShader(Shader shader, string replacementTag) { }

	[FreeFunction("CameraScripting::RenderDontRestore", HasExplicitThis = True)]
	// RVA: 0x244FFB0 Offset: 0x244F1B0 VA: 0x18244FFB0
	public void RenderDontRestore() { }

	[Obsolete("SubmitRenderRequests is obsolete, use SubmitRenderRequest with RequestData of supported types such as RenderPipeline.StandardRequest", True)]
	// RVA: 0x2450D70 Offset: 0x244FF70 VA: 0x182450D70
	public void SubmitRenderRequests(List<Camera.RenderRequest> renderRequests) { }

	// RVA: -1 Offset: -1
	public void SubmitRenderRequest<RequestData>(RequestData renderRequest) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x946980 Offset: 0x945B80 VA: 0x180946980
	|-Camera.SubmitRenderRequest<__Il2CppFullySharedGenericType>
	*/

	[FreeFunction("CameraScripting::SubmitRenderRequests", HasExplicitThis = True)]
	// RVA: 0x2450D20 Offset: 0x244FF20 VA: 0x182450D20
	private void SubmitRenderRequestsInternal(object requests) { }

	[FreeFunction("CameraScripting::SubmitBuiltInObjectIDRenderRequest", HasExplicitThis = True)]
	[NativeConditional("UNITY_EDITOR")]
	// RVA: 0x2450CB0 Offset: 0x244FEB0 VA: 0x182450CB0
	private Object[] SubmitBuiltInObjectIDRenderRequest(RenderTexture target, int mipLevel, CubemapFace cubemapFace, int depthSlice) { }

	[FreeFunction("CameraScripting::SetupCurrent")]
	// RVA: 0x2450C70 Offset: 0x244FE70 VA: 0x182450C70
	public static void SetupCurrent(Camera cur) { }

	[FreeFunction("CameraScripting::CopyFrom", HasExplicitThis = True)]
	// RVA: 0x244F3C0 Offset: 0x244E5C0 VA: 0x18244F3C0
	public void CopyFrom(Camera other) { }

	// RVA: 0x2451D20 Offset: 0x2450F20 VA: 0x182451D20
	public int get_commandBufferCount() { }

	// RVA: 0x244FF70 Offset: 0x244F170 VA: 0x18244FF70
	public void RemoveCommandBuffers(CameraEvent evt) { }

	// RVA: 0x244FDA0 Offset: 0x244EFA0 VA: 0x18244FDA0
	public void RemoveAllCommandBuffers() { }

	[NativeName("AddCommandBuffer")]
	// RVA: 0x244EDC0 Offset: 0x244DFC0 VA: 0x18244EDC0
	private void AddCommandBufferImpl(CameraEvent evt, CommandBuffer buffer) { }

	[NativeName("AddCommandBufferAsync")]
	// RVA: 0x244EC10 Offset: 0x244DE10 VA: 0x18244EC10
	private void AddCommandBufferAsyncImpl(CameraEvent evt, CommandBuffer buffer, ComputeQueueType queueType) { }

	[NativeName("RemoveCommandBuffer")]
	// RVA: 0x244FDE0 Offset: 0x244EFE0 VA: 0x18244FDE0
	private void RemoveCommandBufferImpl(CameraEvent evt, CommandBuffer buffer) { }

	// RVA: 0x244EE10 Offset: 0x244E010 VA: 0x18244EE10
	public void AddCommandBuffer(CameraEvent evt, CommandBuffer buffer) { }

	// RVA: 0x244EC70 Offset: 0x244DE70 VA: 0x18244EC70
	public void AddCommandBufferAsync(CameraEvent evt, CommandBuffer buffer, ComputeQueueType queueType) { }

	// RVA: 0x244FE30 Offset: 0x244F030 VA: 0x18244FE30
	public void RemoveCommandBuffer(CameraEvent evt, CommandBuffer buffer) { }

	[FreeFunction("CameraScripting::GetCommandBuffers", HasExplicitThis = True)]
	// RVA: 0x244F7A0 Offset: 0x244E9A0 VA: 0x18244F7A0
	public CommandBuffer[] GetCommandBuffers(CameraEvent evt) { }

	[RequiredByNativeCode]
	// RVA: 0x244F500 Offset: 0x244E700 VA: 0x18244F500
	private static void FireOnPreCull(Camera cam) { }

	[RequiredByNativeCode]
	// RVA: 0x244F560 Offset: 0x244E760 VA: 0x18244F560
	private static void FireOnPreRender(Camera cam) { }

	[RequiredByNativeCode]
	// RVA: 0x244F4A0 Offset: 0x244E6A0 VA: 0x18244F4A0
	private static void FireOnPostRender(Camera cam) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	internal void OnlyUsedForTesting1() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	internal void OnlyUsedForTesting2() { }

	// RVA: 0x2450FC0 Offset: 0x24501C0 VA: 0x182450FC0
	public bool TryGetCullingParameters(out ScriptableCullingParameters cullingParameters) { }

	// RVA: 0x2450F60 Offset: 0x2450160 VA: 0x182450F60
	public bool TryGetCullingParameters(bool stereoAware, out ScriptableCullingParameters cullingParameters) { }

	[FreeFunction("ScriptableRenderPipeline_Bindings::GetCullingParameters_Internal")]
	[NativeHeader("Runtime/Export/RenderPipeline/ScriptableRenderPipeline.bindings.h")]
	// RVA: 0x244F7E0 Offset: 0x244E9E0 VA: 0x18244F7E0
	private static bool GetCullingParameters_Internal(Camera camera, bool stereoAware, out ScriptableCullingParameters cullingParameters, int managedCullingParametersSize) { }

	// RVA: 0x2452C80 Offset: 0x2451E80 VA: 0x182452C80
	private void get_transparencySortAxis_Injected(out Vector3 ret) { }

	// RVA: 0x2454040 Offset: 0x2453240 VA: 0x182454040
	private void set_transparencySortAxis_Injected(ref Vector3 value) { }

	// RVA: 0x2452E20 Offset: 0x2452020 VA: 0x182452E20
	private void get_velocity_Injected(out Vector3 ret) { }

	// RVA: 0x2451DA0 Offset: 0x2450FA0 VA: 0x182451DA0
	private void get_cullingMatrix_Injected(out Matrix4x4 ret) { }

	// RVA: 0x2453390 Offset: 0x2452590 VA: 0x182453390
	private void set_cullingMatrix_Injected(ref Matrix4x4 value) { }

	// RVA: 0x2451A90 Offset: 0x2450C90 VA: 0x182451A90
	private void get_backgroundColor_Injected(out Color ret) { }

	// RVA: 0x2453150 Offset: 0x2452350 VA: 0x182453150
	private void set_backgroundColor_Injected(ref Color value) { }

	// RVA: 0x2451E80 Offset: 0x2451080 VA: 0x182451E80
	private void get_curvature_Injected(out Vector2 ret) { }

	// RVA: 0x2453430 Offset: 0x2452630 VA: 0x182453430
	private void set_curvature_Injected(ref Vector2 value) { }

	// RVA: 0x24529A0 Offset: 0x2451BA0 VA: 0x1824529A0
	private void get_sensorSize_Injected(out Vector2 ret) { }

	// RVA: 0x2453DF0 Offset: 0x2452FF0 VA: 0x182453DF0
	private void set_sensorSize_Injected(ref Vector2 value) { }

	// RVA: 0x24521E0 Offset: 0x24513E0 VA: 0x1824521E0
	private void get_lensShift_Injected(out Vector2 ret) { }

	// RVA: 0x2453890 Offset: 0x2452A90 VA: 0x182453890
	private void set_lensShift_Injected(ref Vector2 value) { }

	// RVA: 0x244F990 Offset: 0x244EB90 VA: 0x18244F990
	private void GetGateFittedLensShift_Injected(out Vector2 ret) { }

	// RVA: 0x244FA70 Offset: 0x244EC70 VA: 0x18244FA70
	private void GetLocalSpaceAim_Injected(out Vector3 ret) { }

	// RVA: 0x2452760 Offset: 0x2451960 VA: 0x182452760
	private void get_rect_Injected(out Rect ret) { }

	// RVA: 0x2453C80 Offset: 0x2452E80 VA: 0x182453C80
	private void set_rect_Injected(ref Rect value) { }

	// RVA: 0x24524E0 Offset: 0x24516E0 VA: 0x1824524E0
	private void get_pixelRect_Injected(out Rect ret) { }

	// RVA: 0x2453B40 Offset: 0x2452D40 VA: 0x182453B40
	private void set_pixelRect_Injected(ref Rect value) { }

	// RVA: 0x2450A50 Offset: 0x244FC50 VA: 0x182450A50
	private void SetTargetBuffersImpl_Injected(ref RenderBuffer color, ref RenderBuffer depth) { }

	// RVA: 0x2450B10 Offset: 0x244FD10 VA: 0x182450B10
	private void SetTargetBuffersMRTImpl_Injected(RenderBuffer[] color, ref RenderBuffer depth) { }

	// RVA: 0x2451BB0 Offset: 0x2450DB0 VA: 0x182451BB0
	private void get_cameraToWorldMatrix_Injected(out Matrix4x4 ret) { }

	// RVA: 0x2452EC0 Offset: 0x24520C0 VA: 0x182452EC0
	private void get_worldToCameraMatrix_Injected(out Matrix4x4 ret) { }

	// RVA: 0x2454210 Offset: 0x2453410 VA: 0x182454210
	private void set_worldToCameraMatrix_Injected(ref Matrix4x4 value) { }

	// RVA: 0x24526B0 Offset: 0x24518B0 VA: 0x1824526B0
	private void get_projectionMatrix_Injected(out Matrix4x4 ret) { }

	// RVA: 0x2453BE0 Offset: 0x2452DE0 VA: 0x182453BE0
	private void set_projectionMatrix_Injected(ref Matrix4x4 value) { }

	// RVA: 0x24522F0 Offset: 0x24514F0 VA: 0x1824522F0
	private void get_nonJitteredProjectionMatrix_Injected(out Matrix4x4 ret) { }

	// RVA: 0x2453970 Offset: 0x2452B70 VA: 0x182453970
	private void set_nonJitteredProjectionMatrix_Injected(ref Matrix4x4 value) { }

	// RVA: 0x24525C0 Offset: 0x24517C0 VA: 0x1824525C0
	private void get_previousViewProjectionMatrix_Injected(out Matrix4x4 ret) { }

	// RVA: 0x244F160 Offset: 0x244E360 VA: 0x18244F160
	private void CalculateObliqueMatrix_Injected(ref Vector4 clipPlane, out Matrix4x4 ret) { }

	// RVA: 0x24514D0 Offset: 0x24506D0 VA: 0x1824514D0
	private void WorldToScreenPoint_Injected(ref Vector3 position, Camera.MonoOrStereoscopicEye eye, out Vector3 ret) { }

	// RVA: 0x2451640 Offset: 0x2450840 VA: 0x182451640
	private void WorldToViewportPoint_Injected(ref Vector3 position, Camera.MonoOrStereoscopicEye eye, out Vector3 ret) { }

	// RVA: 0x2451360 Offset: 0x2450560 VA: 0x182451360
	private void ViewportToWorldPoint_Injected(ref Vector3 position, Camera.MonoOrStereoscopicEye eye, out Vector3 ret) { }

	// RVA: 0x24506F0 Offset: 0x244F8F0 VA: 0x1824506F0
	private void ScreenToWorldPoint_Injected(ref Vector3 position, Camera.MonoOrStereoscopicEye eye, out Vector3 ret) { }

	// RVA: 0x2450630 Offset: 0x244F830 VA: 0x182450630
	private void ScreenToViewportPoint_Injected(ref Vector3 position, out Vector3 ret) { }

	// RVA: 0x24512A0 Offset: 0x24504A0 VA: 0x1824512A0
	private void ViewportToScreenPoint_Injected(ref Vector3 position, out Vector3 ret) { }

	// RVA: 0x244F890 Offset: 0x244EA90 VA: 0x18244F890
	private void GetFrustumPlaneSizeAt_Injected(float distance, out Vector2 ret) { }

	// RVA: 0x2451060 Offset: 0x2450260 VA: 0x182451060
	private void ViewportPointToRay_Injected(ref Vector2 pos, Camera.MonoOrStereoscopicEye eye, out Ray ret) { }

	// RVA: 0x24503F0 Offset: 0x244F5F0 VA: 0x1824503F0
	private void ScreenPointToRay_Injected(ref Vector2 pos, Camera.MonoOrStereoscopicEye eye, out Ray ret) { }

	// RVA: 0x244EF50 Offset: 0x244E150 VA: 0x18244EF50
	private void CalculateFrustumCornersInternal_Injected(ref Rect viewport, float z, Camera.MonoOrStereoscopicEye eye, [Out] Vector3[] outCorners) { }

	// RVA: 0x244F230 Offset: 0x244E430 VA: 0x18244F230
	private static void CalculateProjectionMatrixFromPhysicalPropertiesInternal_Injected(out Matrix4x4 output, float focalLength, ref Vector2 sensorSize, ref Vector2 lensShift, float nearClip, float farClip, float gateAspect, Camera.GateFitMode gateFitMode) { }

	// RVA: 0x2452900 Offset: 0x2451B00 VA: 0x182452900
	private void get_scene_Injected(out Scene ret) { }

	// RVA: 0x2453D60 Offset: 0x2452F60 VA: 0x182453D60
	private void set_scene_Injected(ref Scene value) { }

	// RVA: 0x244FB10 Offset: 0x244ED10 VA: 0x18244FB10
	private void GetStereoNonJitteredProjectionMatrix_Injected(Camera.StereoscopicEye eye, out Matrix4x4 ret) { }

	// RVA: 0x244FC90 Offset: 0x244EE90 VA: 0x18244FC90
	private void GetStereoViewMatrix_Injected(Camera.StereoscopicEye eye, out Matrix4x4 ret) { }

	// RVA: 0x244FBD0 Offset: 0x244EDD0 VA: 0x18244FBD0
	private void GetStereoProjectionMatrix_Injected(Camera.StereoscopicEye eye, out Matrix4x4 ret) { }

	// RVA: 0x2450910 Offset: 0x244FB10 VA: 0x182450910
	private void SetStereoProjectionMatrix_Injected(Camera.StereoscopicEye eye, ref Matrix4x4 matrix) { }

	// RVA: 0x24509B0 Offset: 0x244FBB0 VA: 0x1824509B0
	private void SetStereoViewMatrix_Injected(Camera.StereoscopicEye eye, ref Matrix4x4 matrix) { }
}

// Namespace: UnityEngine
public struct CullingGroupEvent // TypeDefIndex: 13969
{
	// Fields
	private int m_Index; // 0x0
	private byte m_PrevState; // 0x4
	private byte m_ThisState; // 0x5
}

// Namespace: 
public sealed class CullingGroup.StateChanged : MulticastDelegate // TypeDefIndex: 13970
{
	// Methods

	// RVA: 0x1106640 Offset: 0x1105840 VA: 0x181106640
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(CullingGroupEvent sphere) { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Export/Camera/CullingGroup.bindings.h")]
public class CullingGroup // TypeDefIndex: 13971
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	private CullingGroup.StateChanged m_OnStateChanged; // 0x18

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x24542B0 Offset: 0x24534B0 VA: 0x1824542B0
	private static void SendEvents(CullingGroup cullingGroup, IntPtr eventsPtr, int count) { }
}

// Namespace: UnityEngine
[RequireComponent(typeof(Camera))]
public class FlareLayer : Behaviour // TypeDefIndex: 13972
{}

// Namespace: 
public enum ReflectionProbe.ReflectionProbeEvent // TypeDefIndex: 13973
{
	// Fields
	public int value__; // 0x0
	public const ReflectionProbe.ReflectionProbeEvent ReflectionProbeAdded = 0;
	public const ReflectionProbe.ReflectionProbeEvent ReflectionProbeRemoved = 1;
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Camera/ReflectionProbes.h")]
public sealed class ReflectionProbe : Behaviour // TypeDefIndex: 13974
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action<ReflectionProbe, ReflectionProbe.ReflectionProbeEvent> reflectionProbeChanged; // 0x0
	private static Dictionary<int, Action<Texture>> registeredDefaultReflectionSetActions; // 0x8
	private static List<Action<Texture>> registeredDefaultReflectionTextureActions; // 0x10

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x246EEC0 Offset: 0x246E0C0 VA: 0x18246EEC0
	private static void CallReflectionProbeEvent(ReflectionProbe probe, ReflectionProbe.ReflectionProbeEvent probeEvent) { }

	[RequiredByNativeCode]
	// RVA: 0x246EF40 Offset: 0x246E140 VA: 0x18246EF40
	private static void CallSetDefaultReflection(Texture defaultReflectionCubemap) { }

	// RVA: 0x246F090 Offset: 0x246E290 VA: 0x18246F090
	private static void .cctor() { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Export/Debug/Debug.bindings.h")]
internal sealed class DebugLogHandler : ILogHandler // TypeDefIndex: 13975
{
	// Methods

	[ThreadAndSerializationSafe]
	// RVA: 0x2454430 Offset: 0x2453630 VA: 0x182454430
	internal static void Internal_Log(LogType level, LogOption options, string msg, Object obj) { }

	[ThreadAndSerializationSafe]
	// RVA: 0x24543E0 Offset: 0x24535E0 VA: 0x1824543E0
	internal static void Internal_LogException(Exception ex, Object obj) { }

	// RVA: 0x2454520 Offset: 0x2453720 VA: 0x182454520 Slot: 4
	public void LogFormat(LogType logType, Object context, string format, object[] args) { }

	// RVA: 0x2454590 Offset: 0x2453790 VA: 0x182454590
	public void LogFormat(LogType logType, LogOption logOptions, Object context, string format, object[] args) { }

	// RVA: 0x2454490 Offset: 0x2453690 VA: 0x182454490 Slot: 5
	public void LogException(Exception exception, Object context) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Export/Debug/Debug.bindings.h")]
public class Debug // TypeDefIndex: 13976
{
	// Fields
	internal static readonly ILogger s_DefaultLogger; // 0x0
	internal static ILogger s_Logger; // 0x8

	// Properties
	public static ILogger unityLogger { get; }
	public static bool isDebugBuild { get; }

	// Methods

	// RVA: 0x24561E0 Offset: 0x24553E0 VA: 0x1824561E0
	public static ILogger get_unityLogger() { }

	[ExcludeFromDocs]
	// RVA: 0x2454B60 Offset: 0x2453D60 VA: 0x182454B60
	public static void DrawLine(Vector3 start, Vector3 end, Color color, float duration) { }

	[ExcludeFromDocs]
	// RVA: 0x2454C60 Offset: 0x2453E60 VA: 0x182454C60
	public static void DrawLine(Vector3 start, Vector3 end, Color color) { }

	[FreeFunction("DebugDrawLine", IsThreadSafe = True)]
	// RVA: 0x2454AC0 Offset: 0x2453CC0 VA: 0x182454AC0
	public static void DrawLine(Vector3 start, Vector3 end, Color color, float duration, bool depthTest) { }

	[ExcludeFromDocs]
	// RVA: 0x2454D50 Offset: 0x2453F50 VA: 0x182454D50
	public static void DrawRay(Vector3 start, Vector3 dir, Color color, float duration) { }

	// RVA: 0x2454EE0 Offset: 0x24540E0 VA: 0x182454EE0
	public static void DrawRay(Vector3 start, Vector3 dir, Color color, float duration, bool depthTest) { }

	[ThreadSafe]
	// RVA: 0x2455050 Offset: 0x2454250 VA: 0x182455050
	public static int ExtractStackTraceNoAlloc(byte* buffer, int bufferMax, string projectFolder) { }

	// RVA: 0x2456010 Offset: 0x2455210 VA: 0x182456010
	public static void Log(object message) { }

	// RVA: 0x2455F40 Offset: 0x2455140 VA: 0x182455F40
	public static void Log(object message, Object context) { }

	// RVA: 0x2455B30 Offset: 0x2454D30 VA: 0x182455B30
	public static void LogFormat(string format, object[] args) { }

	// RVA: 0x2455860 Offset: 0x2454A60 VA: 0x182455860
	public static void LogFormat(LogType logType, LogOption logOptions, Object context, string format, object[] args) { }

	// RVA: 0x2455620 Offset: 0x2454820 VA: 0x182455620
	public static void LogError(object message) { }

	// RVA: 0x2455550 Offset: 0x2454750 VA: 0x182455550
	public static void LogError(object message, Object context) { }

	// RVA: 0x2455480 Offset: 0x2454680 VA: 0x182455480
	public static void LogErrorFormat(string format, object[] args) { }

	// RVA: 0x24553A0 Offset: 0x24545A0 VA: 0x1824553A0
	public static void LogErrorFormat(Object context, string format, object[] args) { }

	// RVA: 0x24556E0 Offset: 0x24548E0 VA: 0x1824556E0
	public static void LogException(Exception exception) { }

	// RVA: 0x24557A0 Offset: 0x24549A0 VA: 0x1824557A0
	public static void LogException(Exception exception, Object context) { }

	// RVA: 0x2455E80 Offset: 0x2455080 VA: 0x182455E80
	public static void LogWarning(object message) { }

	// RVA: 0x2455DB0 Offset: 0x2454FB0 VA: 0x182455DB0
	public static void LogWarning(object message, Object context) { }

	// RVA: 0x2455C00 Offset: 0x2454E00 VA: 0x182455C00
	public static void LogWarningFormat(string format, object[] args) { }

	// RVA: 0x2455CD0 Offset: 0x2454ED0 VA: 0x182455CD0
	public static void LogWarningFormat(Object context, string format, object[] args) { }

	[Conditional("UNITY_ASSERTIONS")]
	// RVA: 0x2454610 Offset: 0x2453810 VA: 0x182454610
	public static void Assert(bool condition) { }

	[Conditional("UNITY_ASSERTIONS")]
	// RVA: 0x24546F0 Offset: 0x24538F0 VA: 0x1824546F0
	public static void Assert(bool condition, string message) { }

	[Conditional("UNITY_ASSERTIONS")]
	// RVA: 0x24552E0 Offset: 0x24544E0 VA: 0x1824552E0
	public static void LogAssertion(object message) { }

	[Conditional("UNITY_ASSERTIONS")]
	// RVA: 0x2455210 Offset: 0x2454410 VA: 0x182455210
	public static void LogAssertionFormat(string format, object[] args) { }

	// RVA: 0x24561B0 Offset: 0x24553B0 VA: 0x1824561B0
	public static bool get_isDebugBuild() { }

	[RequiredByNativeCode]
	// RVA: 0x24547C0 Offset: 0x24539C0 VA: 0x1824547C0
	internal static bool CallOverridenDebugHandler(Exception exception, Object obj) { }

	[RequiredByNativeCode]
	// RVA: 0x24550A0 Offset: 0x24542A0 VA: 0x1824550A0
	internal static bool IsLoggingEnabled() { }

	// RVA: 0x24560D0 Offset: 0x24552D0 VA: 0x1824560D0
	private static void .cctor() { }

	// RVA: 0x2454A50 Offset: 0x2453C50 VA: 0x182454A50
	private static void DrawLine_Injected(ref Vector3 start, ref Vector3 end, ref Color color, float duration, bool depthTest) { }
}

// Namespace: 
internal class ExpressionEvaluator.Expression // TypeDefIndex: 13977
{
	// Fields
	internal readonly string[] rpnTokens; // 0x10
	internal readonly bool hasVariables; // 0x18

	// Methods

	// RVA: 0x2458840 Offset: 0x2457A40 VA: 0x182458840
	internal void .ctor(string expression) { }

	// RVA: -1 Offset: -1
	public bool Evaluate<T>(ref T value, int index = 0, int count = 1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xACC8D0 Offset: 0xACBAD0 VA: 0x180ACC8D0
	|-ExpressionEvaluator.Expression.Evaluate<double>
	|-ExpressionEvaluator.Expression.Evaluate<long>
	|-ExpressionEvaluator.Expression.Evaluate<ulong>
	|
	|-RVA: 0xACC970 Offset: 0xACBB70 VA: 0x180ACC970
	|-ExpressionEvaluator.Expression.Evaluate<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: 
private struct ExpressionEvaluator.PcgRandom // TypeDefIndex: 13978
{
	// Fields
	private readonly ulong increment; // 0x0
	private ulong state; // 0x8

	// Methods

	// RVA: 0x246C4C0 Offset: 0x246B6C0 VA: 0x18246C4C0
	public void .ctor(ulong state = 0, ulong sequence = 0) { }

	// RVA: 0x246C420 Offset: 0x246B620 VA: 0x18246C420
	public uint GetUInt() { }

	// RVA: 0x15F9FB0 Offset: 0x15F91B0 VA: 0x1815F9FB0
	private static uint RotateRight(uint v, int rot) { }

	// RVA: 0x246C490 Offset: 0x246B690 VA: 0x18246C490
	private static uint XshRr(ulong s) { }

	// RVA: 0x246C470 Offset: 0x246B670 VA: 0x18246C470
	private void Step() { }
}

// Namespace: 
private enum ExpressionEvaluator.Op // TypeDefIndex: 13979
{
	// Fields
	public int value__; // 0x0
	public const ExpressionEvaluator.Op Add = 0;
	public const ExpressionEvaluator.Op Sub = 1;
	public const ExpressionEvaluator.Op Mul = 2;
	public const ExpressionEvaluator.Op Div = 3;
	public const ExpressionEvaluator.Op Mod = 4;
	public const ExpressionEvaluator.Op Neg = 5;
	public const ExpressionEvaluator.Op Pow = 6;
	public const ExpressionEvaluator.Op Sqrt = 7;
	public const ExpressionEvaluator.Op Sin = 8;
	public const ExpressionEvaluator.Op Cos = 9;
	public const ExpressionEvaluator.Op Tan = 10;
	public const ExpressionEvaluator.Op Floor = 11;
	public const ExpressionEvaluator.Op Ceil = 12;
	public const ExpressionEvaluator.Op Round = 13;
	public const ExpressionEvaluator.Op Rand = 14;
	public const ExpressionEvaluator.Op Linear = 15;
}

// Namespace: 
private enum ExpressionEvaluator.Associativity // TypeDefIndex: 13980
{
	// Fields
	public int value__; // 0x0
	public const ExpressionEvaluator.Associativity Left = 0;
	public const ExpressionEvaluator.Associativity Right = 1;
}

// Namespace: 
private class ExpressionEvaluator.Operator // TypeDefIndex: 13981
{
	// Fields
	public readonly ExpressionEvaluator.Op op; // 0x10
	public readonly int precedence; // 0x14
	public readonly ExpressionEvaluator.Associativity associativity; // 0x18
	public readonly int inputs; // 0x1C

	// Methods

	// RVA: 0x246C3D0 Offset: 0x246B5D0 VA: 0x18246C3D0
	public void .ctor(ExpressionEvaluator.Op op, int precedence, int inputs, ExpressionEvaluator.Associativity associativity) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class ExpressionEvaluator.<>c // TypeDefIndex: 13982
{
	// Fields
	public static readonly ExpressionEvaluator.<>c <>9; // 0x0
	public static Func<string, bool> <>9__14_0; // 0x8

	// Methods

	// RVA: 0x2474BA0 Offset: 0x2473DA0 VA: 0x182474BA0
	private static void .cctor() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x2474AA0 Offset: 0x2473CA0 VA: 0x182474AA0
	internal bool <ExpressionToTokens>b__14_0(string f) { }
}

// Namespace: UnityEngine
[MovedFrom(True, "UnityEditor", "UnityEditor", null)]
public class ExpressionEvaluator // TypeDefIndex: 13983
{
	// Fields
	private static ExpressionEvaluator.PcgRandom s_Random; // 0x0
	private static Dictionary<string, ExpressionEvaluator.Operator> s_Operators; // 0x10

	// Methods

	// RVA: -1 Offset: -1
	internal static bool Evaluate<T>(string expression, out T value, out ExpressionEvaluator.Expression delayed) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9A3820 Offset: 0x9A2A20 VA: 0x1809A3820
	|-ExpressionEvaluator.Evaluate<double>
	|-ExpressionEvaluator.Evaluate<long>
	|-ExpressionEvaluator.Evaluate<ulong>
	|
	|-RVA: 0x9A3940 Offset: 0x9A2B40 VA: 0x1809A3940
	|-ExpressionEvaluator.Evaluate<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private static bool EvaluateTokens<T>(string[] tokens, ref T value, int index, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9A2E60 Offset: 0x9A2060 VA: 0x1809A2E60
	|-ExpressionEvaluator.EvaluateTokens<double>
	|-ExpressionEvaluator.EvaluateTokens<long>
	|-ExpressionEvaluator.EvaluateTokens<ulong>
	|
	|-RVA: 0x9A32F0 Offset: 0x9A24F0 VA: 0x1809A32F0
	|-ExpressionEvaluator.EvaluateTokens<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2456A10 Offset: 0x2455C10 VA: 0x182456A10
	private static bool EvaluateDouble(string[] tokens, ref double value, int index, int count) { }

	// RVA: 0x2457870 Offset: 0x2456A70 VA: 0x182457870
	private static string[] InfixToRPN(string[] tokens) { }

	// RVA: 0x2457EF0 Offset: 0x24570F0 VA: 0x182457EF0
	private static bool NeedToPop(Stack<string> operatorStack, ExpressionEvaluator.Operator newOperator) { }

	// RVA: 0x2457330 Offset: 0x2456530 VA: 0x182457330
	private static string[] ExpressionToTokens(string expression, out bool hasVariables) { }

	// RVA: 0x2457D20 Offset: 0x2456F20 VA: 0x182457D20
	private static bool IsCommand(string token) { }

	// RVA: 0x2457E90 Offset: 0x2457090 VA: 0x182457E90
	private static bool IsVariable(string token) { }

	// RVA: 0x2457DA0 Offset: 0x2456FA0 VA: 0x182457DA0
	private static bool IsDelayedFunction(string token) { }

	// RVA: 0x2457E10 Offset: 0x2457010 VA: 0x182457E10
	private static bool IsOperator(string token) { }

	// RVA: 0x2458180 Offset: 0x2457380 VA: 0x182458180
	private static ExpressionEvaluator.Operator TokenToOperator(string token) { }

	// RVA: 0x2457FC0 Offset: 0x24571C0 VA: 0x182457FC0
	private static string PreFormatExpression(string expression) { }

	// RVA: 0x2457700 Offset: 0x2456900 VA: 0x182457700
	private static string[] FixUnaryOperators(string[] tokens) { }

	// RVA: 0x2456F00 Offset: 0x2456100 VA: 0x182456F00
	private static double EvaluateOp(double[] values, ExpressionEvaluator.Op op, int index, int count) { }

	// RVA: -1 Offset: -1
	private static bool TryParse<T>(string expression, out T result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9A3A80 Offset: 0x9A2C80 VA: 0x1809A3A80
	|-ExpressionEvaluator.TryParse<double>
	|-ExpressionEvaluator.TryParse<long>
	|-ExpressionEvaluator.TryParse<ulong>
	|
	|-RVA: 0x9A42E0 Offset: 0x9A34E0 VA: 0x1809A42E0
	|-ExpressionEvaluator.TryParse<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2458220 Offset: 0x2457420 VA: 0x182458220
	private static void .cctor() { }
}

// Namespace: UnityEngine
[NativeClass("AABB")]
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
[NativeHeader("Runtime/Geometry/AABB.h")]
[NativeHeader("Runtime/Math/MathScripting.h")]
[NativeType(Header = "Runtime/Geometry/AABB.h")]
[NativeHeader("Runtime/Geometry/Intersection.h")]
[NativeHeader("Runtime/Geometry/Ray.h")]
public struct Bounds : IEquatable<Bounds>, IFormattable // TypeDefIndex: 13984
{
	// Fields
	private Vector3 m_Center; // 0x0
	[NativeName("m_Extent")]
	private Vector3 m_Extents; // 0xC

	// Properties
	public Vector3 center { get; set; }
	public Vector3 size { get; set; }
	public Vector3 extents { get; set; }
	public Vector3 min { get; set; }
	public Vector3 max { get; set; }

	// Methods

	// RVA: 0x244D9C0 Offset: 0x244CBC0 VA: 0x18244D9C0
	public void .ctor(Vector3 center, Vector3 size) { }

	// RVA: 0x244D6B0 Offset: 0x244C8B0 VA: 0x18244D6B0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x244D590 Offset: 0x244C790 VA: 0x18244D590 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x244D500 Offset: 0x244C700 VA: 0x18244D500 Slot: 4
	public bool Equals(Bounds other) { }

	// RVA: 0x244D260 Offset: 0x244C460 VA: 0x18244D260
	public Vector3 get_center() { }

	// RVA: 0xAA0CC0 Offset: 0xA9FEC0 VA: 0x180AA0CC0
	public void set_center(Vector3 value) { }

	// RVA: 0x244DA90 Offset: 0x244CC90 VA: 0x18244DA90
	public Vector3 get_size() { }

	// RVA: 0x244DD60 Offset: 0x244CF60 VA: 0x18244DD60
	public void set_size(Vector3 value) { }

	// RVA: 0x244D280 Offset: 0x244C480 VA: 0x18244D280
	public Vector3 get_extents() { }

	// RVA: 0x244D3F0 Offset: 0x244C5F0 VA: 0x18244D3F0
	public void set_extents(Vector3 value) { }

	// RVA: 0x244DA50 Offset: 0x244CC50 VA: 0x18244DA50
	public Vector3 get_min() { }

	// RVA: 0x244DCD0 Offset: 0x244CED0 VA: 0x18244DCD0
	public void set_min(Vector3 value) { }

	// RVA: 0x244DA10 Offset: 0x244CC10 VA: 0x18244DA10
	public Vector3 get_max() { }

	// RVA: 0x244DC30 Offset: 0x244CE30 VA: 0x18244DC30
	public void set_max(Vector3 value) { }

	// RVA: 0x244DAD0 Offset: 0x244CCD0 VA: 0x18244DAD0
	public static bool op_Equality(Bounds lhs, Bounds rhs) { }

	// RVA: 0x244DB70 Offset: 0x244CD70 VA: 0x18244DB70
	public static bool op_Inequality(Bounds lhs, Bounds rhs) { }

	// RVA: 0x244D780 Offset: 0x244C980 VA: 0x18244D780
	public void SetMinMax(Vector3 min, Vector3 max) { }

	// RVA: 0x244D400 Offset: 0x244C600 VA: 0x18244D400
	public void Encapsulate(Vector3 point) { }

	// RVA: 0x244D9B0 Offset: 0x244CBB0 VA: 0x18244D9B0 Slot: 3
	public override string ToString() { }

	// RVA: 0x244D800 Offset: 0x244CA00 VA: 0x18244D800 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }
}

// Namespace: UnityEngine
[UsedByNativeCode]
public struct BoundsInt : IEquatable<BoundsInt>, IFormattable // TypeDefIndex: 13985
{
	// Fields
	private Vector3Int m_Position; // 0x0
	private Vector3Int m_Size; // 0xC

	// Properties
	public Vector3Int min { get; }
	public int xMin { get; }
	public int yMin { get; }
	public int zMin { get; }
	public Vector3Int position { get; set; }
	public Vector3Int size { get; set; }

	// Methods

	// RVA: 0x2449CC0 Offset: 0x2448EC0 VA: 0x182449CC0
	public Vector3Int get_min() { }

	// RVA: 0x244D2A0 Offset: 0x244C4A0 VA: 0x18244D2A0
	public int get_xMin() { }

	// RVA: 0x244D310 Offset: 0x244C510 VA: 0x18244D310
	public int get_yMin() { }

	// RVA: 0x244D380 Offset: 0x244C580 VA: 0x18244D380
	public int get_zMin() { }

	// RVA: 0x244D260 Offset: 0x244C460 VA: 0x18244D260
	public Vector3Int get_position() { }

	// RVA: 0xAA0CC0 Offset: 0xA9FEC0 VA: 0x180AA0CC0
	public void set_position(Vector3Int value) { }

	// RVA: 0x244D280 Offset: 0x244C480 VA: 0x18244D280
	public Vector3Int get_size() { }

	// RVA: 0x244D3F0 Offset: 0x244C5F0 VA: 0x18244D3F0
	public void set_size(Vector3Int value) { }

	// RVA: 0x242D7C0 Offset: 0x242C9C0 VA: 0x18242D7C0
	public void .ctor(Vector3Int position, Vector3Int size) { }

	// RVA: 0x244D250 Offset: 0x244C450 VA: 0x18244D250 Slot: 3
	public override string ToString() { }

	// RVA: 0x244D0C0 Offset: 0x244C2C0 VA: 0x18244D0C0 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x244CF40 Offset: 0x244C140 VA: 0x18244CF40 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x244CEA0 Offset: 0x244C0A0 VA: 0x18244CEA0 Slot: 4
	public bool Equals(BoundsInt other) { }

	// RVA: 0x244D080 Offset: 0x244C280 VA: 0x18244D080 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: UnityEngine
[UsedByNativeCode]
public struct Plane : IFormattable // TypeDefIndex: 13986
{
	// Fields
	private Vector3 m_Normal; // 0x0
	private float m_Distance; // 0xC

	// Properties
	public Vector3 normal { get; }

	// Methods

	// RVA: 0x244D260 Offset: 0x244C460 VA: 0x18244D260
	public Vector3 get_normal() { }

	// RVA: 0x246C7D0 Offset: 0x246B9D0 VA: 0x18246C7D0
	public void .ctor(Vector3 inNormal, Vector3 inPoint) { }

	// RVA: 0x246C4F0 Offset: 0x246B6F0 VA: 0x18246C4F0
	public bool Raycast(Ray ray, out float enter) { }

	// RVA: 0x246C7C0 Offset: 0x246B9C0 VA: 0x18246C7C0 Slot: 3
	public override string ToString() { }

	// RVA: 0x246C610 Offset: 0x246B810 VA: 0x18246C610 Slot: 4
	public string ToString(string format, IFormatProvider formatProvider) { }
}

// Namespace: UnityEngine
public struct Ray : IFormattable // TypeDefIndex: 13987
{
	// Fields
	private Vector3 m_Origin; // 0x0
	private Vector3 m_Direction; // 0xC

	// Properties
	public Vector3 origin { get; }
	public Vector3 direction { get; }

	// Methods

	// RVA: 0x246D9D0 Offset: 0x246CBD0 VA: 0x18246D9D0
	public void .ctor(Vector3 origin, Vector3 direction) { }

	// RVA: 0x244D260 Offset: 0x244C460 VA: 0x18244D260
	public Vector3 get_origin() { }

	// RVA: 0x244D280 Offset: 0x244C480 VA: 0x18244D280
	public Vector3 get_direction() { }

	// RVA: 0x246D7C0 Offset: 0x246C9C0 VA: 0x18246D7C0
	public Vector3 GetPoint(float distance) { }

	// RVA: 0x246D810 Offset: 0x246CA10 VA: 0x18246D810 Slot: 3
	public override string ToString() { }

	// RVA: 0x246D820 Offset: 0x246CA20 VA: 0x18246D820 Slot: 4
	public string ToString(string format, IFormatProvider formatProvider) { }
}

// Namespace: UnityEngine
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
[NativeClass("Rectf", "template<typename T> class RectT; typedef RectT<float> Rectf;")]
[NativeHeader("Runtime/Math/Rect.h")]
public struct Rect : IEquatable<Rect>, IFormattable // TypeDefIndex: 13988
{
	// Fields
	[NativeName("x")]
	private float m_XMin; // 0x0
	[NativeName("y")]
	private float m_YMin; // 0x4
	[NativeName("width")]
	private float m_Width; // 0x8
	[NativeName("height")]
	private float m_Height; // 0xC

	// Properties
	public static Rect zero { get; }
	public float x { get; set; }
	public float y { get; set; }
	public Vector2 position { get; set; }
	public Vector2 center { get; set; }
	public Vector2 min { get; set; }
	public Vector2 max { get; set; }
	public float width { get; set; }
	public float height { get; set; }
	public Vector2 size { get; set; }
	public float xMin { get; set; }
	public float yMin { get; set; }
	public float xMax { get; set; }
	public float yMax { get; set; }

	// Methods

	// RVA: 0x1A1AC10 Offset: 0x1A19E10 VA: 0x181A1AC10
	public void .ctor(float x, float y, float width, float height) { }

	// RVA: 0x246EC40 Offset: 0x246DE40 VA: 0x18246EC40
	public void .ctor(Vector2 position, Vector2 size) { }

	// RVA: 0x52C580 Offset: 0x52B780 VA: 0x18052C580
	public void .ctor(Rect source) { }

	// RVA: 0x151EF90 Offset: 0x151E190 VA: 0x18151EF90
	public static Rect get_zero() { }

	// RVA: 0x246E8C0 Offset: 0x246DAC0 VA: 0x18246E8C0
	public static Rect MinMaxRect(float xmin, float ymin, float xmax, float ymax) { }

	// RVA: 0x758EB0 Offset: 0x7580B0 VA: 0x180758EB0
	public float get_x() { }

	// RVA: 0x439FD0 Offset: 0x4391D0 VA: 0x180439FD0
	public void set_x(float value) { }

	// RVA: 0x758EC0 Offset: 0x7580C0 VA: 0x180758EC0
	public float get_y() { }

	// RVA: 0x439FE0 Offset: 0x4391E0 VA: 0x180439FE0
	public void set_y(float value) { }

	// RVA: 0x246ECF0 Offset: 0x246DEF0 VA: 0x18246ECF0
	public Vector2 get_position() { }

	// RVA: 0x246EE40 Offset: 0x246E040 VA: 0x18246EE40
	public void set_position(Vector2 value) { }

	// RVA: 0x246EC80 Offset: 0x246DE80 VA: 0x18246EC80
	public Vector2 get_center() { }

	// RVA: 0x246ED90 Offset: 0x246DF90 VA: 0x18246ED90
	public void set_center(Vector2 value) { }

	// RVA: 0x246ECD0 Offset: 0x246DED0 VA: 0x18246ECD0
	public Vector2 get_min() { }

	// RVA: 0x246EE00 Offset: 0x246E000 VA: 0x18246EE00
	public void set_min(Vector2 value) { }

	// RVA: 0x246ECB0 Offset: 0x246DEB0 VA: 0x18246ECB0
	public Vector2 get_max() { }

	// RVA: 0x246EDD0 Offset: 0x246DFD0 VA: 0x18246EDD0
	public void set_max(Vector2 value) { }

	// RVA: 0x576F00 Offset: 0x576100 VA: 0x180576F00
	public float get_width() { }

	// RVA: 0x439FF0 Offset: 0x4391F0 VA: 0x180439FF0
	public void set_width(float value) { }

	// RVA: 0x576EF0 Offset: 0x5760F0 VA: 0x180576EF0
	public float get_height() { }

	// RVA: 0x52C5B0 Offset: 0x52B7B0 VA: 0x18052C5B0
	public void set_height(float value) { }

	// RVA: 0x246ED10 Offset: 0x246DF10 VA: 0x18246ED10
	public Vector2 get_size() { }

	// RVA: 0x246EE60 Offset: 0x246E060 VA: 0x18246EE60
	public void set_size(Vector2 value) { }

	// RVA: 0x758EB0 Offset: 0x7580B0 VA: 0x180758EB0
	public float get_xMin() { }

	// RVA: 0x246EE80 Offset: 0x246E080 VA: 0x18246EE80
	public void set_xMin(float value) { }

	// RVA: 0x758EC0 Offset: 0x7580C0 VA: 0x180758EC0
	public float get_yMin() { }

	// RVA: 0x246EEA0 Offset: 0x246E0A0 VA: 0x18246EEA0
	public void set_yMin(float value) { }

	// RVA: 0x246ED30 Offset: 0x246DF30 VA: 0x18246ED30
	public float get_xMax() { }

	// RVA: 0x1A33EC0 Offset: 0x1A330C0 VA: 0x181A33EC0
	public void set_xMax(float value) { }

	// RVA: 0x246ED40 Offset: 0x246DF40 VA: 0x18246ED40
	public float get_yMax() { }

	// RVA: 0x1A33ED0 Offset: 0x1A330D0 VA: 0x181A33ED0
	public void set_yMax(float value) { }

	// RVA: 0x11F4300 Offset: 0x11F3500 VA: 0x1811F4300
	public bool Contains(Vector2 point) { }

	// RVA: 0x246E600 Offset: 0x246D800 VA: 0x18246E600
	public bool Contains(Vector3 point) { }

	// RVA: 0x246E900 Offset: 0x246DB00 VA: 0x18246E900
	private static Rect OrderMinMax(Rect rect) { }

	// RVA: 0x246E970 Offset: 0x246DB70 VA: 0x18246E970
	public bool Overlaps(Rect other) { }

	// RVA: 0x23C0E10 Offset: 0x23C0010 VA: 0x1823C0E10
	public bool Overlaps(Rect other, bool allowInverse) { }

	// RVA: 0x1996A10 Offset: 0x1995C10 VA: 0x181996A10
	public static bool op_Inequality(Rect lhs, Rect rhs) { }

	// RVA: 0x246ED50 Offset: 0x246DF50 VA: 0x18246ED50
	public static bool op_Equality(Rect lhs, Rect rhs) { }

	// RVA: 0x246E820 Offset: 0x246DA20 VA: 0x18246E820 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x246E640 Offset: 0x246D840 VA: 0x18246E640 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x246E770 Offset: 0x246D970 VA: 0x18246E770 Slot: 4
	public bool Equals(Rect other) { }

	// RVA: 0x246E9C0 Offset: 0x246DBC0 VA: 0x18246E9C0 Slot: 3
	public override string ToString() { }

	// RVA: 0x246E9D0 Offset: 0x246DBD0 VA: 0x18246E9D0 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }
}

// Namespace: UnityEngine
[UsedByNativeCode]
public struct RectInt : IEquatable<RectInt>, IFormattable // TypeDefIndex: 13989
{
	// Fields
	private int m_XMin; // 0x0
	private int m_YMin; // 0x4
	private int m_Width; // 0x8
	private int m_Height; // 0xC

	// Properties
	public int x { get; set; }
	public int y { get; set; }
	public int width { get; set; }
	public int height { get; set; }
	public int xMin { get; }
	public int yMin { get; }
	public int xMax { get; }
	public int yMax { get; }

	// Methods

	// RVA: 0x244E020 Offset: 0x244D220 VA: 0x18244E020
	public int get_x() { }

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_x(int value) { }

	// RVA: 0xC45280 Offset: 0xC44480 VA: 0x180C45280
	public int get_y() { }

	// RVA: 0x3F84A0 Offset: 0x3F76A0 VA: 0x1803F84A0
	public void set_y(int value) { }

	// RVA: 0xBC6000 Offset: 0xBC5200 VA: 0x180BC6000
	public int get_width() { }

	// RVA: 0x3F5520 Offset: 0x3F4720 VA: 0x1803F5520
	public void set_width(int value) { }

	// RVA: 0x1483110 Offset: 0x1482310 VA: 0x181483110
	public int get_height() { }

	// RVA: 0x438090 Offset: 0x437290 VA: 0x180438090
	public void set_height(int value) { }

	// RVA: 0x246DD20 Offset: 0x246CF20 VA: 0x18246DD20
	public int get_xMin() { }

	// RVA: 0x246DE00 Offset: 0x246D000 VA: 0x18246DE00
	public int get_yMin() { }

	// RVA: 0x246DCB0 Offset: 0x246CEB0 VA: 0x18246DCB0
	public int get_xMax() { }

	// RVA: 0x246DD90 Offset: 0x246CF90 VA: 0x18246DD90
	public int get_yMax() { }

	// RVA: 0xD4CCD0 Offset: 0xD4BED0 VA: 0x180D4CCD0
	public void .ctor(int xMin, int yMin, int width, int height) { }

	// RVA: 0x244A300 Offset: 0x2449500 VA: 0x18244A300
	public bool Overlaps(RectInt other) { }

	// RVA: 0x246DCA0 Offset: 0x246CEA0 VA: 0x18246DCA0 Slot: 3
	public override string ToString() { }

	// RVA: 0x246DA60 Offset: 0x246CC60 VA: 0x18246DA60 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x246DA30 Offset: 0x246CC30 VA: 0x18246DA30 Slot: 4
	public bool Equals(RectInt other) { }
}

// Namespace: UnityEngine
[UsedByNativeCode]
[NativeHeader("Modules/IMGUI/GUIStyle.h")]
[Serializable]
public class RectOffset : IFormattable // TypeDefIndex: 13990
{
	// Fields
	[VisibleToOtherModules(new[] { "UnityEngine.IMGUIModule" })]
	internal IntPtr m_Ptr; // 0x10
	private readonly object m_SourceStyle; // 0x18

	// Properties
	[NativeProperty("left", False, 1)]
	public int left { get; set; }
	[NativeProperty("right", False, 1)]
	public int right { get; }
	[NativeProperty("top", False, 1)]
	public int top { get; set; }
	[NativeProperty("bottom", False, 1)]
	public int bottom { get; set; }
	public int horizontal { get; }
	public int vertical { get; }

	// Methods

	// RVA: 0x246E380 Offset: 0x246D580 VA: 0x18246E380
	public void .ctor() { }

	[VisibleToOtherModules(new[] { "UnityEngine.IMGUIModule" })]
	// RVA: 0x162EF30 Offset: 0x162E130 VA: 0x18162EF30
	internal void .ctor(object sourceStyle, IntPtr source) { }

	// RVA: 0x246DED0 Offset: 0x246D0D0 VA: 0x18246DED0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x246E0B0 Offset: 0x246D2B0 VA: 0x18246E0B0 Slot: 3
	public override string ToString() { }

	// RVA: 0x246E0C0 Offset: 0x246D2C0 VA: 0x18246E0C0 Slot: 4
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x246DE70 Offset: 0x246D070 VA: 0x18246DE70
	private void Destroy() { }

	[ThreadAndSerializationSafe]
	// RVA: 0x246DF80 Offset: 0x246D180 VA: 0x18246DF80
	private static IntPtr InternalCreate() { }

	[ThreadAndSerializationSafe]
	// RVA: 0x246DFB0 Offset: 0x246D1B0 VA: 0x18246DFB0
	private static void InternalDestroy(IntPtr ptr) { }

	// RVA: 0x246E440 Offset: 0x246D640 VA: 0x18246E440
	public int get_left() { }

	// RVA: 0x246E580 Offset: 0x246D780 VA: 0x18246E580
	public void set_left(int value) { }

	// RVA: 0x246E480 Offset: 0x246D680 VA: 0x18246E480
	public int get_right() { }

	// RVA: 0x246E4C0 Offset: 0x246D6C0 VA: 0x18246E4C0
	public int get_top() { }

	// RVA: 0x246E5C0 Offset: 0x246D7C0 VA: 0x18246E5C0
	public void set_top(int value) { }

	// RVA: 0x246E3C0 Offset: 0x246D5C0 VA: 0x18246E3C0
	public int get_bottom() { }

	// RVA: 0x246E540 Offset: 0x246D740 VA: 0x18246E540
	public void set_bottom(int value) { }

	// RVA: 0x246E400 Offset: 0x246D600 VA: 0x18246E400
	public int get_horizontal() { }

	// RVA: 0x246E500 Offset: 0x246D700 VA: 0x18246E500
	public int get_vertical() { }

	// RVA: 0x246E050 Offset: 0x246D250 VA: 0x18246E050
	public Rect Remove(Rect rect) { }

	// RVA: 0x246DFF0 Offset: 0x246D1F0 VA: 0x18246DFF0
	private void Remove_Injected(ref Rect rect, out Rect ret) { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Graphics/LightingSettings.h")]
[PreventReadOnlyInstanceModification]
public sealed class LightingSettings : Object // TypeDefIndex: 13991
{
	// Methods

	[RequiredByNativeCode]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	internal void LightingSettingsDontStripMe() { }
}

// Namespace: UnityEngine
[StaticAccessor("GizmoBindings", 2)]
[NativeHeader("Runtime/Export/Gizmos/Gizmos.bindings.h")]
public sealed class Gizmos // TypeDefIndex: 13992
{
	// Properties
	public static Color color { get; set; }

	// Methods

	[NativeThrows]
	// RVA: 0x24591B0 Offset: 0x24583B0 VA: 0x1824591B0
	public static void DrawLine(Vector3 from, Vector3 to) { }

	[NativeThrows]
	// RVA: 0x2459250 Offset: 0x2458450 VA: 0x182459250
	public static void DrawWireSphere(Vector3 center, float radius) { }

	[NativeThrows]
	// RVA: 0x2459110 Offset: 0x2458310 VA: 0x182459110
	public static void DrawCube(Vector3 center, Vector3 size) { }

	// RVA: 0x24592E0 Offset: 0x24584E0 VA: 0x1824592E0
	public static Color get_color() { }

	// RVA: 0x2459360 Offset: 0x2458560 VA: 0x182459360
	public static void set_color(Color value) { }

	// RVA: 0x2459160 Offset: 0x2458360 VA: 0x182459160
	private static void DrawLine_Injected(ref Vector3 from, ref Vector3 to) { }

	// RVA: 0x2459200 Offset: 0x2458400 VA: 0x182459200
	private static void DrawWireSphere_Injected(ref Vector3 center, float radius) { }

	// RVA: 0x24590C0 Offset: 0x24582C0 VA: 0x1824590C0
	private static void DrawCube_Injected(ref Vector3 center, ref Vector3 size) { }

	// RVA: 0x24592A0 Offset: 0x24584A0 VA: 0x1824592A0
	private static void get_color_Injected(out Color ret) { }

	// RVA: 0x2459320 Offset: 0x2458520 VA: 0x182459320
	private static void set_color_Injected(ref Color value) { }
}

// Namespace: 
private struct BeforeRenderHelper.OrderBlock // TypeDefIndex: 13993
{
	// Fields
	internal int order; // 0x0
	internal UnityAction callback; // 0x8
}

// Namespace: UnityEngine
internal static class BeforeRenderHelper // TypeDefIndex: 13994
{
	// Fields
	private static List<BeforeRenderHelper.OrderBlock> s_OrderBlocks; // 0x0

	// Methods

	// RVA: 0x244CB60 Offset: 0x244BD60 VA: 0x18244CB60
	public static void Invoke() { }

	// RVA: 0x244CD00 Offset: 0x244BF00 VA: 0x18244CD00
	private static void .cctor() { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Graphics/CustomRenderTextureManager.h")]
public static class CustomRenderTextureManager // TypeDefIndex: 13995
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action<CustomRenderTexture> textureLoaded; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action<CustomRenderTexture> textureUnloaded; // 0x8

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x2454320 Offset: 0x2453520 VA: 0x182454320
	private static void InvokeOnTextureLoaded_Internal(CustomRenderTexture source) { }

	[RequiredByNativeCode]
	// RVA: 0x2454380 Offset: 0x2453580 VA: 0x182454380
	private static void InvokeOnTextureUnloaded_Internal(CustomRenderTexture source) { }
}

// Namespace: 
public sealed class Display.DisplaysUpdatedDelegate : MulticastDelegate // TypeDefIndex: 13996
{
	// Methods

	// RVA: 0x458710 Offset: 0x457910 VA: 0x180458710
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x4240E0 Offset: 0x4232E0 VA: 0x1804240E0 Slot: 13
	public virtual void Invoke() { }
}

// Namespace: UnityEngine
[UsedByNativeCode]
[NativeHeader("Runtime/Graphics/DisplayManager.h")]
public class Display // TypeDefIndex: 13997
{
	// Fields
	internal IntPtr nativeDisplay; // 0x10
	public static Display[] displays; // 0x0
	private static Display _mainDisplay; // 0x8
	private static int m_ActiveEditorGameViewTarget; // 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Display.DisplaysUpdatedDelegate onDisplaysUpdated; // 0x18

	// Properties
	public int renderingWidth { get; }
	public int renderingHeight { get; }
	public int systemWidth { get; }
	public int systemHeight { get; }
	public static Display main { get; }

	// Methods

	// RVA: 0x2456780 Offset: 0x2455980 VA: 0x182456780
	internal void .ctor() { }

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	internal void .ctor(IntPtr nativeDisplay) { }

	// RVA: 0x2456890 Offset: 0x2455A90 VA: 0x182456890
	public int get_renderingWidth() { }

	// RVA: 0x2456810 Offset: 0x2455A10 VA: 0x182456810
	public int get_renderingHeight() { }

	// RVA: 0x2456990 Offset: 0x2455B90 VA: 0x182456990
	public int get_systemWidth() { }

	// RVA: 0x2456910 Offset: 0x2455B10 VA: 0x182456910
	public int get_systemHeight() { }

	// RVA: 0x2456570 Offset: 0x2455770 VA: 0x182456570
	public static Vector3 RelativeMouseAt(Vector3 inputMouseCoordinates) { }

	// RVA: 0x24567C0 Offset: 0x24559C0 VA: 0x1824567C0
	public static Display get_main() { }

	[RequiredByNativeCode]
	// RVA: 0x2456380 Offset: 0x2455580 VA: 0x182456380
	internal static void RecreateDisplayList(IntPtr[] nativeDisplay) { }

	[RequiredByNativeCode]
	// RVA: 0x2456230 Offset: 0x2455430 VA: 0x182456230
	internal static void FireDisplaysUpdated() { }

	[FreeFunction("UnityDisplayManager_DisplaySystemResolution")]
	// RVA: 0x2456320 Offset: 0x2455520 VA: 0x182456320
	private static void GetSystemExtImpl(IntPtr nativeDisplay, out int w, out int h) { }

	[FreeFunction("UnityDisplayManager_DisplayRenderingResolution")]
	// RVA: 0x24562C0 Offset: 0x24554C0 VA: 0x1824562C0
	private static void GetRenderingExtImpl(IntPtr nativeDisplay, out int w, out int h) { }

	[FreeFunction("UnityDisplayManager_RelativeMouseAt")]
	// RVA: 0x2456510 Offset: 0x2455710 VA: 0x182456510
	private static int RelativeMouseAtImpl(int x, int y, out int rx, out int ry) { }

	// RVA: 0x2456640 Offset: 0x2455840 VA: 0x182456640
	private static void .cctor() { }
}

// Namespace: UnityEngine
public enum FullScreenMode // TypeDefIndex: 13998
{
	// Fields
	public int value__; // 0x0
	public const FullScreenMode ExclusiveFullScreen = 0;
	public const FullScreenMode FullScreenWindow = 1;
	public const FullScreenMode MaximizedWindow = 2;
	public const FullScreenMode Windowed = 3;
}

// Namespace: UnityEngine
[NativeType("Runtime/Graphics/RefreshRate.h")]
public struct RefreshRate : IEquatable<RefreshRate>, IComparable<RefreshRate> // TypeDefIndex: 13999
{
	// Fields
	public uint numerator; // 0x0
	public uint denominator; // 0x4

	// Properties
	public double value { get; }

	// Methods

	// RVA: 0x246F290 Offset: 0x246E490 VA: 0x18246F290
	public double get_value() { }

	// RVA: 0x246F1B0 Offset: 0x246E3B0 VA: 0x18246F1B0 Slot: 4
	public bool Equals(RefreshRate other) { }

	// RVA: 0x246F150 Offset: 0x246E350 VA: 0x18246F150 Slot: 5
	public int CompareTo(RefreshRate other) { }

	// RVA: 0x246F1F0 Offset: 0x246E3F0 VA: 0x18246F1F0 Slot: 3
	public override string ToString() { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
[NativeHeader("Runtime/Graphics/ScreenManager.h")]
[StaticAccessor("GetScreenManager()", 0)]
[NativeHeader("Runtime/Graphics/WindowLayout.h")]
public sealed class Screen // TypeDefIndex: 14000
{
	// Properties
	public static int width { get; }
	public static int height { get; }
	public static float dpi { get; }
	public static ScreenOrientation orientation { get; set; }
	[NativeProperty("ScreenTimeout")]
	public static int sleepTimeout { set; }
	public static Resolution currentResolution { get; }
	public static bool fullScreen { get; }
	public static FullScreenMode fullScreenMode { get; }
	public static Rect safeArea { get; }
	public static Resolution[] resolutions { get; }

	// Methods

	[NativeMethod(Name = "GetWidth", IsThreadSafe = True)]
	// RVA: 0x2470020 Offset: 0x246F220 VA: 0x182470020
	public static int get_width() { }

	[NativeMethod(Name = "GetHeight", IsThreadSafe = True)]
	// RVA: 0x246FF40 Offset: 0x246F140 VA: 0x18246FF40
	public static int get_height() { }

	[NativeName("GetDPI")]
	// RVA: 0x246FEB0 Offset: 0x246F0B0 VA: 0x18246FEB0
	public static float get_dpi() { }

	// RVA: 0x246FC30 Offset: 0x246EE30 VA: 0x18246FC30
	private static void RequestOrientation(ScreenOrientation orient) { }

	// RVA: 0x246FC00 Offset: 0x246EE00 VA: 0x18246FC00
	private static ScreenOrientation GetScreenOrientation() { }

	// RVA: 0x246FC00 Offset: 0x246EE00 VA: 0x18246FC00
	public static ScreenOrientation get_orientation() { }

	// RVA: 0x2470050 Offset: 0x246F250 VA: 0x182470050
	public static void set_orientation(ScreenOrientation value) { }

	// RVA: 0x2470180 Offset: 0x246F380 VA: 0x182470180
	public static void set_sleepTimeout(int value) { }

	// RVA: 0x246FE70 Offset: 0x246F070 VA: 0x18246FE70
	public static Resolution get_currentResolution() { }

	[NativeName("IsFullscreen")]
	// RVA: 0x246FF10 Offset: 0x246F110 VA: 0x18246FF10
	public static bool get_fullScreen() { }

	[NativeName("GetFullscreenMode")]
	// RVA: 0x246FEE0 Offset: 0x246F0E0 VA: 0x18246FEE0
	public static FullScreenMode get_fullScreenMode() { }

	// RVA: 0x246FFE0 Offset: 0x246F1E0 VA: 0x18246FFE0
	public static Rect get_safeArea() { }

	[NativeName("RequestResolution")]
	// RVA: 0x246FCD0 Offset: 0x246EED0 VA: 0x18246FCD0
	public static void SetResolution(int width, int height, FullScreenMode fullscreenMode, RefreshRate preferredRefreshRate) { }

	[Obsolete("SetResolution(int, int, bool, int) is obsolete. Use SetResolution(int, int, FullScreenMode, RefreshRate) instead.")]
	[EditorBrowsable(1)]
	// RVA: 0x246FDB0 Offset: 0x246EFB0 VA: 0x18246FDB0
	public static void SetResolution(int width, int height, bool fullscreen, int preferredRefreshRate) { }

	// RVA: 0x246FD30 Offset: 0x246EF30 VA: 0x18246FD30
	public static void SetResolution(int width, int height, bool fullscreen) { }

	[FreeFunction("ScreenScripting::GetResolutions")]
	// RVA: 0x246FF70 Offset: 0x246F170 VA: 0x18246FF70
	public static Resolution[] get_resolutions() { }

	// RVA: 0x246FE30 Offset: 0x246F030 VA: 0x18246FE30
	private static void get_currentResolution_Injected(out Resolution ret) { }

	// RVA: 0x246FFA0 Offset: 0x246F1A0 VA: 0x18246FFA0
	private static void get_safeArea_Injected(out Rect ret) { }

	// RVA: 0x246FC70 Offset: 0x246EE70 VA: 0x18246FC70
	private static void SetResolution_Injected(int width, int height, FullScreenMode fullscreenMode, ref RefreshRate preferredRefreshRate) { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
public struct RenderBuffer // TypeDefIndex: 14001
{
	// Fields
	internal int m_RenderTextureInstanceID; // 0x0
	internal IntPtr m_BufferPtr; // 0x8
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Graphics/ColorGamut.h")]
[NativeHeader("Runtime/Camera/LightProbeProxyVolume.h")]
[NativeHeader("Runtime/Graphics/CopyTexture.h")]
[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
[NativeHeader("Runtime/Shaders/ComputeShader.h")]
[NativeHeader("Runtime/Misc/PlayerSettings.h")]
public class Graphics // TypeDefIndex: 14002
{
	// Fields
	internal static readonly int kMaxDrawMeshInstanceCount; // 0x0
	internal static Dictionary<int, RenderInstancedDataLayout> s_RenderInstancedDataLayouts; // 0x8

	// Properties
	[StaticAccessor("GetGfxDevice()", 0)]
	public static GraphicsTier activeTier { get; set; }

	// Methods

	[FreeFunction("GraphicsScripting::GetMaxDrawMeshInstanceCount", IsThreadSafe = True)]
	// RVA: 0x2459720 Offset: 0x2458920 VA: 0x182459720
	private static int Internal_GetMaxDrawMeshInstanceCount() { }

	// RVA: 0x245A010 Offset: 0x2459210 VA: 0x18245A010
	public static GraphicsTier get_activeTier() { }

	// RVA: 0x245A040 Offset: 0x2459240 VA: 0x18245A040
	public static void set_activeTier(GraphicsTier value) { }

	[FreeFunction("GraphicsScripting::SetNullRT")]
	// RVA: 0x2459750 Offset: 0x2458950 VA: 0x182459750
	private static void Internal_SetNullRT() { }

	[NativeMethod(Name = "GraphicsScripting::SetRTSimple", IsFreeFunction = True, ThrowsException = True)]
	// RVA: 0x24597F0 Offset: 0x24589F0 VA: 0x1824597F0
	private static void Internal_SetRTSimple(RenderBuffer color, RenderBuffer depth, int mip, CubemapFace face, int depthSlice) { }

	[FreeFunction("GraphicsScripting::Blit")]
	// RVA: 0x2459430 Offset: 0x2458630 VA: 0x182459430
	private static void Blit2(Texture source, RenderTexture dest) { }

	[FreeFunction("GraphicsScripting::Blit")]
	// RVA: 0x24594F0 Offset: 0x24586F0 VA: 0x1824594F0
	private static void Blit4(Texture source, RenderTexture dest, Vector2 scale, Vector2 offset) { }

	[NativeMethod(Name = "GraphicsScripting::ExecuteCommandBuffer", IsFreeFunction = True, ThrowsException = True)]
	// RVA: 0x24596E0 Offset: 0x24588E0 VA: 0x1824596E0
	public static void ExecuteCommandBuffer(CommandBuffer buffer) { }

	// RVA: 0x2459A60 Offset: 0x2458C60 VA: 0x182459A60
	internal static void SetRenderTargetImpl(RenderBuffer colorBuffer, RenderBuffer depthBuffer, int mipLevel, CubemapFace face, int depthSlice) { }

	// RVA: 0x2459890 Offset: 0x2458A90 VA: 0x182459890
	internal static void SetRenderTargetImpl(RenderTexture rt, int mipLevel, CubemapFace face, int depthSlice) { }

	// RVA: 0x2459D60 Offset: 0x2458F60 VA: 0x182459D60
	public static void SetRenderTarget(RenderTexture rt, int mipLevel, CubemapFace face, int depthSlice) { }

	// RVA: 0x2459580 Offset: 0x2458780 VA: 0x182459580
	public static void Blit(Texture source, RenderTexture dest) { }

	// RVA: 0x2459600 Offset: 0x2458800 VA: 0x182459600
	public static void Blit(Texture source, RenderTexture dest, Vector2 scale, Vector2 offset) { }

	[ExcludeFromDocs]
	// RVA: 0x2459B50 Offset: 0x2458D50 VA: 0x182459B50
	public static void SetRenderTarget(RenderTexture rt) { }

	// RVA: 0x2459F60 Offset: 0x2459160 VA: 0x182459F60
	private static void .cctor() { }

	// RVA: 0x2459780 Offset: 0x2458980 VA: 0x182459780
	private static void Internal_SetRTSimple_Injected(ref RenderBuffer color, ref RenderBuffer depth, int mip, CubemapFace face, int depthSlice) { }

	// RVA: 0x2459480 Offset: 0x2458680 VA: 0x182459480
	private static void Blit4_Injected(Texture source, RenderTexture dest, ref Vector2 scale, ref Vector2 offset) { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Camera/CameraUtil.h")]
[NativeHeader("Runtime/Camera/Camera.h")]
[StaticAccessor("GetGfxDevice()", 0)]
[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
[NativeHeader("Runtime/GfxDevice/GfxDevice.h")]
public sealed class GL // TypeDefIndex: 14003
{
	// Properties
	public static Matrix4x4 modelview { set; }

	// Methods

	[NativeName("ImmediateVertex")]
	// RVA: 0x2458F70 Offset: 0x2458170 VA: 0x182458F70
	public static void Vertex3(float x, float y, float z) { }

	[NativeName("ImmediateTexCoordAll")]
	// RVA: 0x2458F10 Offset: 0x2458110 VA: 0x182458F10
	public static void TexCoord3(float x, float y, float z) { }

	// RVA: 0x2458EC0 Offset: 0x24580C0 VA: 0x182458EC0
	public static void TexCoord2(float x, float y) { }

	[NativeName("ImmediateColor")]
	// RVA: 0x2458CB0 Offset: 0x2457EB0 VA: 0x182458CB0
	private static void ImmediateColor(float r, float g, float b, float a) { }

	// RVA: 0x2458AD0 Offset: 0x2457CD0 VA: 0x182458AD0
	public static void Color(Color c) { }

	// RVA: 0x2458E80 Offset: 0x2458080 VA: 0x182458E80
	private static void SetViewMatrix(Matrix4x4 m) { }

	// RVA: 0x2459050 Offset: 0x2458250 VA: 0x182459050
	public static void set_modelview(Matrix4x4 value) { }

	[FreeFunction("GLPushMatrixScript")]
	// RVA: 0x2458E10 Offset: 0x2458010 VA: 0x182458E10
	public static void PushMatrix() { }

	[FreeFunction("GLPopMatrixScript")]
	// RVA: 0x2458DE0 Offset: 0x2457FE0 VA: 0x182458DE0
	public static void PopMatrix() { }

	[FreeFunction("GLLoadOrthoScript")]
	// RVA: 0x2458D30 Offset: 0x2457F30 VA: 0x182458D30
	public static void LoadOrtho() { }

	[FreeFunction("GLLoadProjectionMatrixScript")]
	// RVA: 0x2458DA0 Offset: 0x2457FA0 VA: 0x182458DA0
	public static void LoadProjectionMatrix(Matrix4x4 mat) { }

	[FreeFunction]
	// RVA: 0x2458C30 Offset: 0x2457E30 VA: 0x182458C30
	private static void GLLoadPixelMatrixScript(float left, float right, float bottom, float top) { }

	// RVA: 0x2458C30 Offset: 0x2457E30 VA: 0x182458C30
	public static void LoadPixelMatrix(float left, float right, float bottom, float top) { }

	[FreeFunction("GLBegin", ThrowsException = True)]
	// RVA: 0x2458A20 Offset: 0x2457C20 VA: 0x182458A20
	public static void Begin(int mode) { }

	[FreeFunction("GLEnd")]
	// RVA: 0x2458B20 Offset: 0x2457D20 VA: 0x182458B20
	public static void End() { }

	[FreeFunction]
	// RVA: 0x2458BC0 Offset: 0x2457DC0 VA: 0x182458BC0
	private static void GLClear(bool clearDepth, bool clearColor, Color backgroundColor, float depth) { }

	// RVA: 0x2458A60 Offset: 0x2457C60 VA: 0x182458A60
	public static void Clear(bool clearDepth, bool clearColor, Color backgroundColor, float depth) { }

	[FreeFunction("SetGLViewport")]
	// RVA: 0x2459010 Offset: 0x2458210 VA: 0x182459010
	public static void Viewport(Rect pixelRect) { }

	// RVA: 0x2458E40 Offset: 0x2458040 VA: 0x182458E40
	private static void SetViewMatrix_Injected(ref Matrix4x4 m) { }

	// RVA: 0x2458D60 Offset: 0x2457F60 VA: 0x182458D60
	private static void LoadProjectionMatrix_Injected(ref Matrix4x4 mat) { }

	// RVA: 0x2458B50 Offset: 0x2457D50 VA: 0x182458B50
	private static void GLClear_Injected(bool clearDepth, bool clearColor, ref Color backgroundColor, float depth) { }

	// RVA: 0x2458FD0 Offset: 0x24581D0 VA: 0x182458FD0
	private static void Viewport_Injected(ref Rect pixelRect) { }
}

// Namespace: UnityEngine
[StaticAccessor("GetLightmapSettings()")]
[NativeHeader("Runtime/Graphics/LightmapSettings.h")]
public sealed class LightmapSettings : Object // TypeDefIndex: 14004
{}

// Namespace: UnityEngine
[NativeHeader("Runtime/Export/Graphics/Graphics.bindings.h")]
public sealed class LightProbes : Object // TypeDefIndex: 14005
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action lightProbesUpdated; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action tetrahedralizationCompleted; // 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action needsRetetrahedralization; // 0x10

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x245A650 Offset: 0x2459850 VA: 0x18245A650
	private static void Internal_CallLightProbesUpdatedFunction() { }

	[RequiredByNativeCode]
	// RVA: 0x245A700 Offset: 0x2459900 VA: 0x18245A700
	private static void Internal_CallTetrahedralizationCompletedFunction() { }

	[RequiredByNativeCode]
	// RVA: 0x245A6A0 Offset: 0x24598A0 VA: 0x18245A6A0
	private static void Internal_CallNeedsRetetrahedralizationFunction() { }
}

// Namespace: UnityEngine
[RequiredByNativeCode]
public struct Resolution // TypeDefIndex: 14006
{
	// Fields
	private int m_Width; // 0x0
	private int m_Height; // 0x4
	private RefreshRate m_RefreshRate; // 0x8

	// Properties
	public int width { get; set; }
	public int height { get; set; }

	// Methods

	// RVA: 0x244E020 Offset: 0x244D220 VA: 0x18244E020
	public int get_width() { }

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_width(int value) { }

	// RVA: 0xC45280 Offset: 0xC44480 VA: 0x180C45280
	public int get_height() { }

	// RVA: 0x3F84A0 Offset: 0x3F76A0 VA: 0x1803F84A0
	public void set_height(int value) { }

	// RVA: 0x246FA70 Offset: 0x246EC70 VA: 0x18246FA70 Slot: 3
	public override string ToString() { }
}

// Namespace: UnityEngine
[IsReadOnly]
internal struct RenderInstancedDataLayout // TypeDefIndex: 14007
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly int <size>k__BackingField; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly int <offsetObjectToWorld>k__BackingField; // 0x4
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly int <offsetPrevObjectToWorld>k__BackingField; // 0x8
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly int <offsetRenderingLayerMask>k__BackingField; // 0xC
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Misc/PlayerSettings.h")]
[NativeHeader("Runtime/Graphics/QualitySettings.h")]
[StaticAccessor("GetQualitySettings()", 0)]
public sealed class QualitySettings : Object // TypeDefIndex: 14008
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action<int, int> activeQualityLevelChanged; // 0x0

	// Properties
	public static int vSyncCount { set; }
	public static ColorSpace activeColorSpace { get; }

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x246D6F0 Offset: 0x246C8F0 VA: 0x18246D6F0
	internal static void OnActiveQualityLevelChanged(int previousQualityLevel, int currentQualityLevel) { }

	// RVA: 0x246D780 Offset: 0x246C980 VA: 0x18246D780
	public static void set_vSyncCount(int value) { }

	[NativeName("GetColorSpace")]
	[StaticAccessor("GetPlayerSettings()", 0)]
	// RVA: 0x246D750 Offset: 0x246C950 VA: 0x18246D750
	public static ColorSpace get_activeColorSpace() { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
[NativeHeader("Runtime/Graphics/LineRenderer.h")]
public sealed class LineRenderer : Renderer // TypeDefIndex: 14009
{
	// Properties
	[Obsolete("Use positionCount instead (UnityUpgradable) -> positionCount", False)]
	public int numPositions { get; set; }
	public float startWidth { get; set; }
	public float endWidth { get; set; }
	public float widthMultiplier { get; set; }
	public int numCornerVertices { get; set; }
	public int numCapVertices { get; set; }
	public bool useWorldSpace { get; set; }
	public bool loop { get; set; }
	public Color startColor { get; set; }
	public Color endColor { get; set; }
	[NativeProperty("PositionsCount")]
	public int positionCount { get; set; }
	public Vector2 textureScale { get; set; }
	public float shadowBias { get; set; }
	public bool generateLightingData { get; set; }
	public LineTextureMode textureMode { get; set; }
	public LineAlignment alignment { get; set; }
	public SpriteMaskInteraction maskInteraction { get; set; }
	public AnimationCurve widthCurve { get; set; }
	public Gradient colorGradient { get; set; }

	// Methods

	[Obsolete("Use startWidth, endWidth or widthCurve instead.", False)]
	// RVA: 0x245B350 Offset: 0x245A550 VA: 0x18245B350
	public void SetWidth(float start, float end) { }

	[Obsolete("Use startColor, endColor or colorGradient instead.", False)]
	// RVA: 0x245AFA0 Offset: 0x245A1A0 VA: 0x18245AFA0
	public void SetColors(Color start, Color end) { }

	[Obsolete("Use positionCount instead.", False)]
	// RVA: 0x245B2C0 Offset: 0x245A4C0 VA: 0x18245B2C0
	public void SetVertexCount(int count) { }

	// RVA: 0x245B680 Offset: 0x245A880 VA: 0x18245B680
	public int get_numPositions() { }

	// RVA: 0x245B2C0 Offset: 0x245A4C0 VA: 0x18245B2C0
	public void set_numPositions(int value) { }

	// RVA: 0x245B7A0 Offset: 0x245A9A0 VA: 0x18245B7A0
	public float get_startWidth() { }

	// RVA: 0x245BCC0 Offset: 0x245AEC0 VA: 0x18245BCC0
	public void set_startWidth(float value) { }

	// RVA: 0x245B500 Offset: 0x245A700 VA: 0x18245B500
	public float get_endWidth() { }

	// RVA: 0x245BA20 Offset: 0x245AC20 VA: 0x18245BA20
	public void set_endWidth(float value) { }

	// RVA: 0x245B900 Offset: 0x245AB00 VA: 0x18245B900
	public float get_widthMultiplier() { }

	// RVA: 0x245BE30 Offset: 0x245B030 VA: 0x18245BE30
	public void set_widthMultiplier(float value) { }

	// RVA: 0x245B640 Offset: 0x245A840 VA: 0x18245B640
	public int get_numCornerVertices() { }

	// RVA: 0x245BB90 Offset: 0x245AD90 VA: 0x18245BB90
	public void set_numCornerVertices(int value) { }

	// RVA: 0x245B600 Offset: 0x245A800 VA: 0x18245B600
	public int get_numCapVertices() { }

	// RVA: 0x245BB50 Offset: 0x245AD50 VA: 0x18245BB50
	public void set_numCapVertices(int value) { }

	// RVA: 0x245B8C0 Offset: 0x245AAC0 VA: 0x18245B8C0
	public bool get_useWorldSpace() { }

	// RVA: 0x245BDE0 Offset: 0x245AFE0 VA: 0x18245BDE0
	public void set_useWorldSpace(bool value) { }

	// RVA: 0x245B580 Offset: 0x245A780 VA: 0x18245B580
	public bool get_loop() { }

	// RVA: 0x245BAC0 Offset: 0x245ACC0 VA: 0x18245BAC0
	public void set_loop(bool value) { }

	// RVA: 0x245B750 Offset: 0x245A950 VA: 0x18245B750
	public Color get_startColor() { }

	// RVA: 0x245BC70 Offset: 0x245AE70 VA: 0x18245BC70
	public void set_startColor(Color value) { }

	// RVA: 0x245B4B0 Offset: 0x245A6B0 VA: 0x18245B4B0
	public Color get_endColor() { }

	// RVA: 0x245B9D0 Offset: 0x245ABD0 VA: 0x18245B9D0
	public void set_endColor(Color value) { }

	// RVA: 0x245B680 Offset: 0x245A880 VA: 0x18245B680
	public int get_positionCount() { }

	// RVA: 0x245B2C0 Offset: 0x245A4C0 VA: 0x18245B2C0
	public void set_positionCount(int value) { }

	// RVA: 0x245B070 Offset: 0x245A270 VA: 0x18245B070
	public void SetPosition(int index, Vector3 position) { }

	// RVA: 0x245ACB0 Offset: 0x2459EB0 VA: 0x18245ACB0
	public Vector3 GetPosition(int index) { }

	// RVA: 0x245B870 Offset: 0x245AA70 VA: 0x18245B870
	public Vector2 get_textureScale() { }

	// RVA: 0x245BDA0 Offset: 0x245AFA0 VA: 0x18245BDA0
	public void set_textureScale(Vector2 value) { }

	// RVA: 0x245B6C0 Offset: 0x245A8C0 VA: 0x18245B6C0
	public float get_shadowBias() { }

	// RVA: 0x245BBD0 Offset: 0x245ADD0 VA: 0x18245BBD0
	public void set_shadowBias(float value) { }

	// RVA: 0x245B540 Offset: 0x245A740 VA: 0x18245B540
	public bool get_generateLightingData() { }

	// RVA: 0x245BA70 Offset: 0x245AC70 VA: 0x18245BA70
	public void set_generateLightingData(bool value) { }

	// RVA: 0x245B7E0 Offset: 0x245A9E0 VA: 0x18245B7E0
	public LineTextureMode get_textureMode() { }

	// RVA: 0x245BD10 Offset: 0x245AF10 VA: 0x18245BD10
	public void set_textureMode(LineTextureMode value) { }

	// RVA: 0x245B420 Offset: 0x245A620 VA: 0x18245B420
	public LineAlignment get_alignment() { }

	// RVA: 0x245B940 Offset: 0x245AB40 VA: 0x18245B940
	public void set_alignment(LineAlignment value) { }

	// RVA: 0x245B5C0 Offset: 0x245A7C0 VA: 0x18245B5C0
	public SpriteMaskInteraction get_maskInteraction() { }

	// RVA: 0x245BB10 Offset: 0x245AD10 VA: 0x18245BB10
	public void set_maskInteraction(SpriteMaskInteraction value) { }

	// RVA: 0x245B3D0 Offset: 0x245A5D0 VA: 0x18245B3D0
	public void Simplify(float tolerance) { }

	// RVA: 0x245AB90 Offset: 0x2459D90 VA: 0x18245AB90
	public void BakeMesh(Mesh mesh, bool useTransform = False) { }

	// RVA: 0x245AB20 Offset: 0x2459D20 VA: 0x18245AB20
	public void BakeMesh(Mesh mesh, Camera camera, bool useTransform = False) { }

	// RVA: 0x245AF10 Offset: 0x245A110 VA: 0x18245AF10
	public AnimationCurve get_widthCurve() { }

	// RVA: 0x245B300 Offset: 0x245A500 VA: 0x18245B300
	public void set_widthCurve(AnimationCurve value) { }

	// RVA: 0x245AC20 Offset: 0x2459E20 VA: 0x18245AC20
	public Gradient get_colorGradient() { }

	// RVA: 0x245AF50 Offset: 0x245A150 VA: 0x18245AF50
	public void set_colorGradient(Gradient value) { }

	// RVA: 0x245AF10 Offset: 0x245A110 VA: 0x18245AF10
	private AnimationCurve GetWidthCurveCopy() { }

	// RVA: 0x245B300 Offset: 0x245A500 VA: 0x18245B300
	private void SetWidthCurve(AnimationCurve curve) { }

	// RVA: 0x245AC20 Offset: 0x2459E20 VA: 0x18245AC20
	private Gradient GetColorGradientCopy() { }

	// RVA: 0x245AF50 Offset: 0x245A150 VA: 0x18245AF50
	private void SetColorGradient(Gradient curve) { }

	[FreeFunction(Name = "LineRendererScripting::GetPositions", HasExplicitThis = True)]
	// RVA: 0x245AD70 Offset: 0x2459F70 VA: 0x18245AD70
	public int GetPositions([Out] Vector3[] positions) { }

	[FreeFunction(Name = "LineRendererScripting::SetPositions", HasExplicitThis = True)]
	// RVA: 0x245B1D0 Offset: 0x245A3D0 VA: 0x18245B1D0
	public void SetPositions(Vector3[] positions) { }

	// RVA: 0x245B220 Offset: 0x245A420 VA: 0x18245B220
	public void SetPositions(NativeArray<Vector3> positions) { }

	// RVA: 0x245B120 Offset: 0x245A320 VA: 0x18245B120
	public void SetPositions(NativeSlice<Vector3> positions) { }

	// RVA: 0x245ADC0 Offset: 0x2459FC0 VA: 0x18245ADC0
	public int GetPositions([Out] NativeArray<Vector3> positions) { }

	// RVA: 0x245AE60 Offset: 0x245A060 VA: 0x18245AE60
	public int GetPositions([Out] NativeSlice<Vector3> positions) { }

	[FreeFunction(Name = "LineRendererScripting::SetPositionsWithNativeContainer", HasExplicitThis = True)]
	// RVA: 0x245B0C0 Offset: 0x245A2C0 VA: 0x18245B0C0
	private void SetPositionsWithNativeContainer(IntPtr positions, int count) { }

	[FreeFunction(Name = "LineRendererScripting::GetPositionsWithNativeContainer", HasExplicitThis = True)]
	// RVA: 0x245AD10 Offset: 0x2459F10 VA: 0x18245AD10
	private int GetPositionsWithNativeContainer(IntPtr positions, int length) { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }

	// RVA: 0x245B700 Offset: 0x245A900 VA: 0x18245B700
	private void get_startColor_Injected(out Color ret) { }

	// RVA: 0x245BC20 Offset: 0x245AE20 VA: 0x18245BC20
	private void set_startColor_Injected(ref Color value) { }

	// RVA: 0x245B460 Offset: 0x245A660 VA: 0x18245B460
	private void get_endColor_Injected(out Color ret) { }

	// RVA: 0x245B980 Offset: 0x245AB80 VA: 0x18245B980
	private void set_endColor_Injected(ref Color value) { }

	// RVA: 0x245B020 Offset: 0x245A220 VA: 0x18245B020
	private void SetPosition_Injected(int index, ref Vector3 position) { }

	// RVA: 0x245AC60 Offset: 0x2459E60 VA: 0x18245AC60
	private void GetPosition_Injected(int index, out Vector3 ret) { }

	// RVA: 0x245B820 Offset: 0x245AA20 VA: 0x18245B820
	private void get_textureScale_Injected(out Vector2 ret) { }

	// RVA: 0x245BD50 Offset: 0x245AF50 VA: 0x18245BD50
	private void set_textureScale_Injected(ref Vector2 value) { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Shaders/ComputeShader.h")]
[NativeHeader("Runtime/Shaders/ShaderPropertySheet.h")]
[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
[NativeHeader("Runtime/Math/SphericalHarmonicsL2.h")]
public sealed class MaterialPropertyBlock // TypeDefIndex: 14010
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Methods

	[NativeName("SetFloatFromScript")]
	[ThreadSafe]
	// RVA: 0x245C1B0 Offset: 0x245B3B0 VA: 0x18245C1B0
	private void SetFloatImpl(int name, float value) { }

	[NativeName("SetTextureFromScript")]
	[ThreadSafe]
	// RVA: 0x245C280 Offset: 0x245B480 VA: 0x18245C280
	private void SetTextureImpl(int name, Texture value) { }

	[NativeName("SetVectorArrayFromScript")]
	[ThreadSafe]
	// RVA: 0x245C350 Offset: 0x245B550 VA: 0x18245C350
	private void SetVectorArrayImpl(int name, Vector4[] values, int count) { }

	[NativeMethod(Name = "MaterialPropertyBlockScripting::Create", IsFreeFunction = True)]
	// RVA: 0x245BFC0 Offset: 0x245B1C0 VA: 0x18245BFC0
	private static IntPtr CreateImpl() { }

	[NativeMethod(Name = "MaterialPropertyBlockScripting::Destroy", IsFreeFunction = True, IsThreadSafe = True)]
	// RVA: 0x245BFF0 Offset: 0x245B1F0 VA: 0x18245BFF0
	private static void DestroyImpl(IntPtr mpb) { }

	[ThreadSafe]
	// RVA: 0x245BF30 Offset: 0x245B130 VA: 0x18245BF30
	private void Clear(bool keepMemory) { }

	// RVA: 0x245BF80 Offset: 0x245B180 VA: 0x18245BF80
	public void Clear() { }

	// RVA: 0x245C470 Offset: 0x245B670 VA: 0x18245C470
	private void SetVectorArray(int name, Vector4[] values, int count) { }

	// RVA: 0x245C5D0 Offset: 0x245B7D0 VA: 0x18245C5D0
	public void .ctor() { }

	// RVA: 0x245C0D0 Offset: 0x245B2D0 VA: 0x18245C0D0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x245C030 Offset: 0x245B230 VA: 0x18245C030
	private void Dispose() { }

	// RVA: 0x245C200 Offset: 0x245B400 VA: 0x18245C200
	public void SetInt(string name, int value) { }

	// RVA: 0x245C2D0 Offset: 0x245B4D0 VA: 0x18245C2D0
	public void SetTexture(string name, Texture value) { }

	// RVA: 0x245C280 Offset: 0x245B480 VA: 0x18245C280
	public void SetTexture(int nameID, Texture value) { }

	// RVA: 0x245C3B0 Offset: 0x245B5B0 VA: 0x18245C3B0
	public void SetVectorArray(int nameID, Vector4[] values) { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Graphics/Renderer.h")]
[RequireComponent(typeof(Transform))]
[UsedByNativeCode]
[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
public class Renderer : Component // TypeDefIndex: 14011
{
	// Properties
	public Bounds bounds { get; }
	public bool enabled { get; set; }
	public ShadowCastingMode shadowCastingMode { set; }
	public bool receiveShadows { set; }
	public int sortingLayerID { get; set; }
	public int sortingOrder { get; set; }
	internal int sortingGroupID { get; }
	internal int sortingGroupOrder { get; }
	public bool isPartOfStaticBatch { get; }
	public Material material { get; set; }
	public Material sharedMaterial { get; set; }
	public Material[] sharedMaterials { get; set; }

	// Methods

	[FreeFunction(Name = "RendererScripting::GetWorldBounds", HasExplicitThis = True)]
	// RVA: 0x246F730 Offset: 0x246E930 VA: 0x18246F730
	public Bounds get_bounds() { }

	[FreeFunction(Name = "RendererScripting::GetMaterial", HasExplicitThis = True)]
	// RVA: 0x246F340 Offset: 0x246E540 VA: 0x18246F340
	private Material GetMaterial() { }

	[FreeFunction(Name = "RendererScripting::GetSharedMaterial", HasExplicitThis = True)]
	// RVA: 0x246F410 Offset: 0x246E610 VA: 0x18246F410
	private Material GetSharedMaterial() { }

	[FreeFunction(Name = "RendererScripting::SetMaterial", HasExplicitThis = True)]
	// RVA: 0x246F690 Offset: 0x246E890 VA: 0x18246F690
	private void SetMaterial(Material m) { }

	[FreeFunction(Name = "RendererScripting::GetSharedMaterialArray", HasExplicitThis = True)]
	// RVA: 0x246F2B0 Offset: 0x246E4B0 VA: 0x18246F2B0
	private void CopySharedMaterialArray([Out] Material[] m) { }

	[FreeFunction(Name = "RendererScripting::SetMaterialArray", HasExplicitThis = True)]
	// RVA: 0x246F5C0 Offset: 0x246E7C0 VA: 0x18246F5C0
	private void SetMaterialArray(Material[] m, int length) { }

	// RVA: 0x246F620 Offset: 0x246E820 VA: 0x18246F620
	private void SetMaterialArray(Material[] m) { }

	[FreeFunction(Name = "RendererScripting::SetPropertyBlock", HasExplicitThis = True)]
	// RVA: 0x246F570 Offset: 0x246E770 VA: 0x18246F570
	internal void Internal_SetPropertyBlock(MaterialPropertyBlock properties) { }

	[FreeFunction(Name = "RendererScripting::GetPropertyBlock", HasExplicitThis = True)]
	// RVA: 0x246F380 Offset: 0x246E580 VA: 0x18246F380
	internal void Internal_GetPropertyBlock(MaterialPropertyBlock dest) { }

	// RVA: 0x246F570 Offset: 0x246E770 VA: 0x18246F570
	public void SetPropertyBlock(MaterialPropertyBlock properties) { }

	// RVA: 0x246F380 Offset: 0x246E580 VA: 0x18246F380
	public void GetPropertyBlock(MaterialPropertyBlock properties) { }

	// RVA: 0x246F790 Offset: 0x246E990 VA: 0x18246F790
	public bool get_enabled() { }

	// RVA: 0x246F910 Offset: 0x246EB10 VA: 0x18246F910
	public void set_enabled(bool value) { }

	// RVA: 0x246F9B0 Offset: 0x246EBB0 VA: 0x18246F9B0
	public void set_shadowCastingMode(ShadowCastingMode value) { }

	// RVA: 0x246F960 Offset: 0x246EB60 VA: 0x18246F960
	public void set_receiveShadows(bool value) { }

	// RVA: 0x246F890 Offset: 0x246EA90 VA: 0x18246F890
	public int get_sortingLayerID() { }

	// RVA: 0x246F9F0 Offset: 0x246EBF0 VA: 0x18246F9F0
	public void set_sortingLayerID(int value) { }

	// RVA: 0x246F8D0 Offset: 0x246EAD0 VA: 0x18246F8D0
	public int get_sortingOrder() { }

	// RVA: 0x246FA30 Offset: 0x246EC30 VA: 0x18246FA30
	public void set_sortingOrder(int value) { }

	// RVA: 0x246F810 Offset: 0x246EA10 VA: 0x18246F810
	internal int get_sortingGroupID() { }

	// RVA: 0x246F850 Offset: 0x246EA50 VA: 0x18246F850
	internal int get_sortingGroupOrder() { }

	[NativeName("IsPartOfStaticBatch")]
	// RVA: 0x246F7D0 Offset: 0x246E9D0 VA: 0x18246F7D0
	public bool get_isPartOfStaticBatch() { }

	// RVA: 0x246F300 Offset: 0x246E500 VA: 0x18246F300
	private int GetMaterialCount() { }

	[NativeName("GetMaterialArray")]
	// RVA: 0x246F3D0 Offset: 0x246E5D0 VA: 0x18246F3D0
	private Material[] GetSharedMaterialArray() { }

	// RVA: 0x246F340 Offset: 0x246E540 VA: 0x18246F340
	public Material get_material() { }

	// RVA: 0x246F690 Offset: 0x246E890 VA: 0x18246F690
	public void set_material(Material value) { }

	// RVA: 0x246F410 Offset: 0x246E610 VA: 0x18246F410
	public Material get_sharedMaterial() { }

	// RVA: 0x246F690 Offset: 0x246E890 VA: 0x18246F690
	public void set_sharedMaterial(Material value) { }

	// RVA: 0x246F3D0 Offset: 0x246E5D0 VA: 0x18246F3D0
	public Material[] get_sharedMaterials() { }

	// RVA: 0x246F620 Offset: 0x246E820 VA: 0x18246F620
	public void set_sharedMaterials(Material[] value) { }

	// RVA: 0x246F450 Offset: 0x246E650 VA: 0x18246F450
	public void GetSharedMaterials(List<Material> m) { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }

	// RVA: 0x246F6E0 Offset: 0x246E8E0 VA: 0x18246F6E0
	private void get_bounds_Injected(out Bounds ret) { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Camera/RenderSettings.h")]
[NativeHeader("Runtime/Graphics/QualitySettingsTypes.h")]
[StaticAccessor("GetRenderSettings()", 0)]
public sealed class RenderSettings : Object // TypeDefIndex: 14012
{}

// Namespace: UnityEngine
[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
[NativeHeader("Runtime/Shaders/ShaderNameRegistry.h")]
[NativeHeader("Runtime/Shaders/Shader.h")]
[NativeHeader("Runtime/Shaders/Keywords/KeywordSpaceScriptBindings.h")]
[NativeHeader("Runtime/Shaders/GpuPrograms/ShaderVariantCollection.h")]
[NativeHeader("Runtime/Shaders/ComputeShader.h")]
[NativeHeader("Runtime/Misc/ResourceManager.h")]
public sealed class Shader : Object // TypeDefIndex: 14013
{
	// Properties
	[Obsolete("Use Graphics.activeTier instead (UnityUpgradable) -> UnityEngine.Graphics.activeTier", False)]
	public static ShaderHardwareTier globalShaderHardwareTier { get; set; }
	[NativeProperty("MaxChunksRuntimeOverride")]
	public static int maximumChunksOverride { get; set; }
	[NativeProperty("MaximumShaderLOD")]
	public int maximumLOD { get; set; }
	[NativeProperty("GlobalMaximumShaderLOD")]
	public static int globalMaximumLOD { get; set; }
	public bool isSupported { get; }
	public static string globalRenderPipeline { get; set; }
	public static GlobalKeyword[] enabledGlobalKeywords { get; }
	public static GlobalKeyword[] globalKeywords { get; }
	public LocalKeywordSpace keywordSpace { get; }
	public int renderQueue { get; }
	internal DisableBatchingType disableBatching { get; }
	public int passCount { get; }
	public int subshaderCount { get; }

	// Methods

	// RVA: 0x2474590 Offset: 0x2473790 VA: 0x182474590
	public static ShaderHardwareTier get_globalShaderHardwareTier() { }

	// RVA: 0x2474880 Offset: 0x2473A80 VA: 0x182474880
	public static void set_globalShaderHardwareTier(ShaderHardwareTier value) { }

	// RVA: 0x2470F60 Offset: 0x2470160 VA: 0x182470F60
	public static Shader Find(string name) { }

	[FreeFunction("GetBuiltinResource<Shader>")]
	// RVA: 0x2470940 Offset: 0x246FB40 VA: 0x182470940
	internal static Shader FindBuiltin(string name) { }

	// RVA: 0x24746D0 Offset: 0x24738D0 VA: 0x1824746D0
	public static int get_maximumChunksOverride() { }

	// RVA: 0x24748F0 Offset: 0x2473AF0 VA: 0x1824748F0
	public static void set_maximumChunksOverride(int value) { }

	// RVA: 0x2474700 Offset: 0x2473900 VA: 0x182474700
	public int get_maximumLOD() { }

	// RVA: 0x2474930 Offset: 0x2473B30 VA: 0x182474930
	public void set_maximumLOD(int value) { }

	// RVA: 0x2474530 Offset: 0x2473730 VA: 0x182474530
	public static int get_globalMaximumLOD() { }

	// RVA: 0x2474800 Offset: 0x2473A00 VA: 0x182474800
	public static void set_globalMaximumLOD(int value) { }

	[NativeMethod("IsSupported")]
	// RVA: 0x24745F0 Offset: 0x24737F0 VA: 0x1824745F0
	public bool get_isSupported() { }

	// RVA: 0x2474560 Offset: 0x2473760 VA: 0x182474560
	public static string get_globalRenderPipeline() { }

	// RVA: 0x2474840 Offset: 0x2473A40 VA: 0x182474840
	public static void set_globalRenderPipeline(string value) { }

	// RVA: 0x2471050 Offset: 0x2470250 VA: 0x182471050
	public static GlobalKeyword[] get_enabledGlobalKeywords() { }

	// RVA: 0x2470FD0 Offset: 0x24701D0 VA: 0x182470FD0
	public static GlobalKeyword[] get_globalKeywords() { }

	// RVA: 0x2474680 Offset: 0x2473880 VA: 0x182474680
	public LocalKeywordSpace get_keywordSpace() { }

	[FreeFunction("keywords::GetEnabledGlobalKeywords")]
	// RVA: 0x2471050 Offset: 0x2470250 VA: 0x182471050
	internal static GlobalKeyword[] GetEnabledGlobalKeywords() { }

	[FreeFunction("keywords::GetAllGlobalKeywords")]
	// RVA: 0x2470FD0 Offset: 0x24701D0 VA: 0x182470FD0
	internal static GlobalKeyword[] GetAllGlobalKeywords() { }

	[FreeFunction("ShaderScripting::EnableKeyword")]
	// RVA: 0x24703E0 Offset: 0x246F5E0 VA: 0x1824703E0
	public static void EnableKeyword(string keyword) { }

	[FreeFunction("ShaderScripting::DisableKeyword")]
	// RVA: 0x24702E0 Offset: 0x246F4E0 VA: 0x1824702E0
	public static void DisableKeyword(string keyword) { }

	[FreeFunction("ShaderScripting::IsKeywordEnabled")]
	// RVA: 0x2472E30 Offset: 0x2472030 VA: 0x182472E30
	public static bool IsKeywordEnabled(string keyword) { }

	[FreeFunction("ShaderScripting::EnableKeyword")]
	// RVA: 0x24703A0 Offset: 0x246F5A0 VA: 0x1824703A0
	internal static void EnableKeywordFast(GlobalKeyword keyword) { }

	[FreeFunction("ShaderScripting::DisableKeyword")]
	// RVA: 0x24702A0 Offset: 0x246F4A0 VA: 0x1824702A0
	internal static void DisableKeywordFast(GlobalKeyword keyword) { }

	[FreeFunction("ShaderScripting::SetKeyword")]
	// RVA: 0x24743A0 Offset: 0x24735A0 VA: 0x1824743A0
	internal static void SetKeywordFast(GlobalKeyword keyword, bool value) { }

	[FreeFunction("ShaderScripting::IsKeywordEnabled")]
	// RVA: 0x2472DF0 Offset: 0x2471FF0 VA: 0x182472DF0
	internal static bool IsKeywordEnabledFast(GlobalKeyword keyword) { }

	// RVA: 0x2470420 Offset: 0x246F620 VA: 0x182470420
	public static void EnableKeyword(in GlobalKeyword keyword) { }

	// RVA: 0x2470320 Offset: 0x246F520 VA: 0x182470320
	public static void DisableKeyword(in GlobalKeyword keyword) { }

	// RVA: 0x24743F0 Offset: 0x24735F0 VA: 0x1824743F0
	public static void SetKeyword(in GlobalKeyword keyword, bool value) { }

	// RVA: 0x2472E70 Offset: 0x2472070 VA: 0x182472E70
	public static bool IsKeywordEnabled(in GlobalKeyword keyword) { }

	[FreeFunction("ShaderScripting::GetRenderQueue", HasExplicitThis = True)]
	// RVA: 0x2474780 Offset: 0x2473980 VA: 0x182474780
	public int get_renderQueue() { }

	[FreeFunction("ShaderScripting::GetDisableBatchingType", HasExplicitThis = True)]
	// RVA: 0x24744F0 Offset: 0x24736F0 VA: 0x1824744F0
	internal DisableBatchingType get_disableBatching() { }

	[FreeFunction]
	// RVA: 0x2474470 Offset: 0x2473670 VA: 0x182474470
	public static void WarmupAllShaders() { }

	[FreeFunction("ShaderScripting::TagToID")]
	// RVA: 0x2474430 Offset: 0x2473630 VA: 0x182474430
	internal static int TagToID(string name) { }

	[FreeFunction("ShaderScripting::IDToTag")]
	// RVA: 0x2472C70 Offset: 0x2471E70 VA: 0x182472C70
	internal static string IDToTag(int name) { }

	[FreeFunction(Name = "ShaderScripting::PropertyToID", IsThreadSafe = True)]
	// RVA: 0x2472EB0 Offset: 0x24720B0 VA: 0x182472EB0
	public static int PropertyToID(string name) { }

	// RVA: 0x2471000 Offset: 0x2470200 VA: 0x182471000
	public Shader GetDependency(string name) { }

	[FreeFunction(Name = "ShaderScripting::GetPassCount", HasExplicitThis = True)]
	// RVA: 0x2474740 Offset: 0x2473940 VA: 0x182474740
	public int get_passCount() { }

	[FreeFunction(Name = "ShaderScripting::GetSubshaderCount", HasExplicitThis = True)]
	// RVA: 0x24747C0 Offset: 0x24739C0 VA: 0x1824747C0
	public int get_subshaderCount() { }

	[FreeFunction(Name = "ShaderScripting::GetPassCountInSubshader", HasExplicitThis = True)]
	// RVA: 0x2471CD0 Offset: 0x2470ED0 VA: 0x182471CD0
	public int GetPassCountInSubshader(int subshaderIndex) { }

	// RVA: 0x2470B00 Offset: 0x246FD00 VA: 0x182470B00
	public ShaderTagId FindPassTagValue(int passIndex, ShaderTagId tagName) { }

	// RVA: 0x2470980 Offset: 0x246FB80 VA: 0x182470980
	public ShaderTagId FindPassTagValue(int subshaderIndex, int passIndex, ShaderTagId tagName) { }

	// RVA: 0x2470C50 Offset: 0x246FE50 VA: 0x182470C50
	public ShaderTagId FindSubshaderTagValue(int subshaderIndex, ShaderTagId tagName) { }

	[FreeFunction(Name = "ShaderScripting::FindPassTagValue", HasExplicitThis = True)]
	// RVA: 0x2472D10 Offset: 0x2471F10 VA: 0x182472D10
	private int Internal_FindPassTagValue(int passIndex, int tagName) { }

	[FreeFunction(Name = "ShaderScripting::FindPassTagValue", HasExplicitThis = True)]
	// RVA: 0x2472CB0 Offset: 0x2471EB0 VA: 0x182472CB0
	private int Internal_FindPassTagValueInSubShader(int subShaderIndex, int passIndex, int tagName) { }

	[FreeFunction(Name = "ShaderScripting::FindSubshaderTagValue", HasExplicitThis = True)]
	// RVA: 0x2472D60 Offset: 0x2471F60 VA: 0x182472D60
	private int Internal_FindSubshaderTagValue(int subShaderIndex, int tagName) { }

	[FreeFunction("ShaderScripting::SetGlobalInt")]
	// RVA: 0x2473750 Offset: 0x2472950 VA: 0x182473750
	private static void SetGlobalIntImpl(int name, int value) { }

	[FreeFunction("ShaderScripting::SetGlobalFloat")]
	// RVA: 0x2473690 Offset: 0x2472890 VA: 0x182473690
	private static void SetGlobalFloatImpl(int name, float value) { }

	[FreeFunction("ShaderScripting::SetGlobalVector")]
	// RVA: 0x2474250 Offset: 0x2473450 VA: 0x182474250
	private static void SetGlobalVectorImpl(int name, Vector4 value) { }

	[FreeFunction("ShaderScripting::SetGlobalMatrix")]
	// RVA: 0x2473C30 Offset: 0x2472E30 VA: 0x182473C30
	private static void SetGlobalMatrixImpl(int name, Matrix4x4 value) { }

	[FreeFunction("ShaderScripting::SetGlobalTexture")]
	// RVA: 0x2473DB0 Offset: 0x2472FB0 VA: 0x182473DB0
	private static void SetGlobalTextureImpl(int name, Texture value) { }

	[FreeFunction("ShaderScripting::SetGlobalRenderTexture")]
	// RVA: 0x2473D60 Offset: 0x2472F60 VA: 0x182473D60
	private static void SetGlobalRenderTextureImpl(int name, RenderTexture value, RenderTextureSubElement element) { }

	[FreeFunction("ShaderScripting::SetGlobalBuffer")]
	// RVA: 0x2472EF0 Offset: 0x24720F0 VA: 0x182472EF0
	private static void SetGlobalBufferImpl(int name, ComputeBuffer value) { }

	[FreeFunction("ShaderScripting::SetGlobalBuffer")]
	// RVA: 0x2472F30 Offset: 0x2472130 VA: 0x182472F30
	private static void SetGlobalGraphicsBufferImpl(int name, GraphicsBuffer value) { }

	[FreeFunction("ShaderScripting::SetGlobalConstantBuffer")]
	// RVA: 0x2473180 Offset: 0x2472380 VA: 0x182473180
	private static void SetGlobalConstantBufferImpl(int name, ComputeBuffer value, int offset, int size) { }

	[FreeFunction("ShaderScripting::SetGlobalConstantBuffer")]
	// RVA: 0x2473300 Offset: 0x2472500 VA: 0x182473300
	private static void SetGlobalConstantGraphicsBufferImpl(int name, GraphicsBuffer value, int offset, int size) { }

	[FreeFunction("ShaderScripting::GetGlobalInt")]
	// RVA: 0x24713E0 Offset: 0x24705E0 VA: 0x1824713E0
	private static int GetGlobalIntImpl(int name) { }

	[FreeFunction("ShaderScripting::GetGlobalFloat")]
	// RVA: 0x2471340 Offset: 0x2470540 VA: 0x182471340
	private static float GetGlobalFloatImpl(int name) { }

	[FreeFunction("ShaderScripting::GetGlobalVector")]
	// RVA: 0x2471B90 Offset: 0x2470D90 VA: 0x182471B90
	private static Vector4 GetGlobalVectorImpl(int name) { }

	[FreeFunction("ShaderScripting::GetGlobalMatrix")]
	// RVA: 0x2471730 Offset: 0x2470930 VA: 0x182471730
	private static Matrix4x4 GetGlobalMatrixImpl(int name) { }

	[FreeFunction("ShaderScripting::GetGlobalTexture")]
	// RVA: 0x24718E0 Offset: 0x2470AE0 VA: 0x1824718E0
	private static Texture GetGlobalTextureImpl(int name) { }

	[FreeFunction("ShaderScripting::SetGlobalFloatArray")]
	// RVA: 0x2473360 Offset: 0x2472560 VA: 0x182473360
	private static void SetGlobalFloatArrayImpl(int name, float[] values, int count) { }

	[FreeFunction("ShaderScripting::SetGlobalVectorArray")]
	// RVA: 0x2473EE0 Offset: 0x24730E0 VA: 0x182473EE0
	private static void SetGlobalVectorArrayImpl(int name, Vector4[] values, int count) { }

	[FreeFunction("ShaderScripting::SetGlobalMatrixArray")]
	// RVA: 0x24738C0 Offset: 0x2472AC0 VA: 0x1824738C0
	private static void SetGlobalMatrixArrayImpl(int name, Matrix4x4[] values, int count) { }

	[FreeFunction("ShaderScripting::GetGlobalFloatArray")]
	// RVA: 0x24711B0 Offset: 0x24703B0 VA: 0x1824711B0
	private static float[] GetGlobalFloatArrayImpl(int name) { }

	[FreeFunction("ShaderScripting::GetGlobalVectorArray")]
	// RVA: 0x24719C0 Offset: 0x2470BC0 VA: 0x1824719C0
	private static Vector4[] GetGlobalVectorArrayImpl(int name) { }

	[FreeFunction("ShaderScripting::GetGlobalMatrixArray")]
	// RVA: 0x2471560 Offset: 0x2470760 VA: 0x182471560
	private static Matrix4x4[] GetGlobalMatrixArrayImpl(int name) { }

	[FreeFunction("ShaderScripting::GetGlobalFloatArrayCount")]
	// RVA: 0x2471170 Offset: 0x2470370 VA: 0x182471170
	private static int GetGlobalFloatArrayCountImpl(int name) { }

	[FreeFunction("ShaderScripting::GetGlobalVectorArrayCount")]
	// RVA: 0x2471980 Offset: 0x2470B80 VA: 0x182471980
	private static int GetGlobalVectorArrayCountImpl(int name) { }

	[FreeFunction("ShaderScripting::GetGlobalMatrixArrayCount")]
	// RVA: 0x2471520 Offset: 0x2470720 VA: 0x182471520
	private static int GetGlobalMatrixArrayCountImpl(int name) { }

	[FreeFunction("ShaderScripting::ExtractGlobalFloatArray")]
	// RVA: 0x2470460 Offset: 0x246F660 VA: 0x182470460
	private static void ExtractGlobalFloatArrayImpl(int name, [Out] float[] val) { }

	[FreeFunction("ShaderScripting::ExtractGlobalVectorArray")]
	// RVA: 0x24707A0 Offset: 0x246F9A0 VA: 0x1824707A0
	private static void ExtractGlobalVectorArrayImpl(int name, [Out] Vector4[] val) { }

	[FreeFunction("ShaderScripting::ExtractGlobalMatrixArray")]
	// RVA: 0x2470600 Offset: 0x246F800 VA: 0x182470600
	private static void ExtractGlobalMatrixArrayImpl(int name, [Out] Matrix4x4[] val) { }

	// RVA: 0x24734A0 Offset: 0x24726A0 VA: 0x1824734A0
	private static void SetGlobalFloatArray(int name, float[] values, int count) { }

	// RVA: 0x2474030 Offset: 0x2473230 VA: 0x182474030
	private static void SetGlobalVectorArray(int name, Vector4[] values, int count) { }

	// RVA: 0x2473930 Offset: 0x2472B30 VA: 0x182473930
	private static void SetGlobalMatrixArray(int name, Matrix4x4[] values, int count) { }

	// RVA: 0x24704A0 Offset: 0x246F6A0 VA: 0x1824704A0
	private static void ExtractGlobalFloatArray(int name, List<float> values) { }

	// RVA: 0x24707E0 Offset: 0x246F9E0 VA: 0x1824707E0
	private static void ExtractGlobalVectorArray(int name, List<Vector4> values) { }

	// RVA: 0x2470640 Offset: 0x246F840 VA: 0x182470640
	private static void ExtractGlobalMatrixArray(int name, List<Matrix4x4> values) { }

	// RVA: 0x2473790 Offset: 0x2472990 VA: 0x182473790
	public static void SetGlobalInt(string name, int value) { }

	// RVA: 0x2473800 Offset: 0x2472A00 VA: 0x182473800
	public static void SetGlobalInt(int nameID, int value) { }

	// RVA: 0x24736E0 Offset: 0x24728E0 VA: 0x1824736E0
	public static void SetGlobalFloat(string name, float value) { }

	// RVA: 0x2473690 Offset: 0x2472890 VA: 0x182473690
	public static void SetGlobalFloat(int nameID, float value) { }

	// RVA: 0x2473850 Offset: 0x2472A50 VA: 0x182473850
	public static void SetGlobalInteger(string name, int value) { }

	// RVA: 0x2473750 Offset: 0x2472950 VA: 0x182473750
	public static void SetGlobalInteger(int nameID, int value) { }

	// RVA: 0x2474290 Offset: 0x2473490 VA: 0x182474290
	public static void SetGlobalVector(string name, Vector4 value) { }

	// RVA: 0x2474310 Offset: 0x2473510 VA: 0x182474310
	public static void SetGlobalVector(int nameID, Vector4 value) { }

	// RVA: 0x24730D0 Offset: 0x24722D0 VA: 0x1824730D0
	public static void SetGlobalColor(string name, Color value) { }

	// RVA: 0x2473050 Offset: 0x2472250 VA: 0x182473050
	public static void SetGlobalColor(int nameID, Color value) { }

	// RVA: 0x2473C70 Offset: 0x2472E70 VA: 0x182473C70
	public static void SetGlobalMatrix(string name, Matrix4x4 value) { }

	// RVA: 0x2473D00 Offset: 0x2472F00 VA: 0x182473D00
	public static void SetGlobalMatrix(int nameID, Matrix4x4 value) { }

	// RVA: 0x2473E70 Offset: 0x2473070 VA: 0x182473E70
	public static void SetGlobalTexture(string name, Texture value) { }

	// RVA: 0x2473DB0 Offset: 0x2472FB0 VA: 0x182473DB0
	public static void SetGlobalTexture(int nameID, Texture value) { }

	// RVA: 0x2473DF0 Offset: 0x2472FF0 VA: 0x182473DF0
	public static void SetGlobalTexture(string name, RenderTexture value, RenderTextureSubElement element) { }

	// RVA: 0x2473D60 Offset: 0x2472F60 VA: 0x182473D60
	public static void SetGlobalTexture(int nameID, RenderTexture value, RenderTextureSubElement element) { }

	// RVA: 0x2472F70 Offset: 0x2472170 VA: 0x182472F70
	public static void SetGlobalBuffer(string name, ComputeBuffer value) { }

	// RVA: 0x2472EF0 Offset: 0x24720F0 VA: 0x182472EF0
	public static void SetGlobalBuffer(int nameID, ComputeBuffer value) { }

	// RVA: 0x2472FE0 Offset: 0x24721E0 VA: 0x182472FE0
	public static void SetGlobalBuffer(string name, GraphicsBuffer value) { }

	// RVA: 0x2472F30 Offset: 0x2472130 VA: 0x182472F30
	public static void SetGlobalBuffer(int nameID, GraphicsBuffer value) { }

	// RVA: 0x2473270 Offset: 0x2472470 VA: 0x182473270
	public static void SetGlobalConstantBuffer(string name, ComputeBuffer value, int offset, int size) { }

	// RVA: 0x2473180 Offset: 0x2472380 VA: 0x182473180
	public static void SetGlobalConstantBuffer(int nameID, ComputeBuffer value, int offset, int size) { }

	// RVA: 0x24731E0 Offset: 0x24723E0 VA: 0x1824731E0
	public static void SetGlobalConstantBuffer(string name, GraphicsBuffer value, int offset, int size) { }

	// RVA: 0x2473300 Offset: 0x2472500 VA: 0x182473300
	public static void SetGlobalConstantBuffer(int nameID, GraphicsBuffer value, int offset, int size) { }

	// RVA: 0x24735F0 Offset: 0x24727F0 VA: 0x1824735F0
	public static void SetGlobalFloatArray(string name, List<float> values) { }

	// RVA: 0x2473430 Offset: 0x2472630 VA: 0x182473430
	public static void SetGlobalFloatArray(int nameID, List<float> values) { }

	// RVA: 0x24733D0 Offset: 0x24725D0 VA: 0x1824733D0
	public static void SetGlobalFloatArray(string name, float[] values) { }

	// RVA: 0x24733B0 Offset: 0x24725B0 VA: 0x1824733B0
	public static void SetGlobalFloatArray(int nameID, float[] values) { }

	// RVA: 0x2473F90 Offset: 0x2473190 VA: 0x182473F90
	public static void SetGlobalVectorArray(string name, List<Vector4> values) { }

	// RVA: 0x24741A0 Offset: 0x24733A0 VA: 0x1824741A0
	public static void SetGlobalVectorArray(int nameID, List<Vector4> values) { }

	// RVA: 0x2473F30 Offset: 0x2473130 VA: 0x182473F30
	public static void SetGlobalVectorArray(string name, Vector4[] values) { }

	// RVA: 0x2474180 Offset: 0x2473380 VA: 0x182474180
	public static void SetGlobalVectorArray(int nameID, Vector4[] values) { }

	// RVA: 0x2473B50 Offset: 0x2472D50 VA: 0x182473B50
	public static void SetGlobalMatrixArray(string name, List<Matrix4x4> values) { }

	// RVA: 0x2473AE0 Offset: 0x2472CE0 VA: 0x182473AE0
	public static void SetGlobalMatrixArray(int nameID, List<Matrix4x4> values) { }

	// RVA: 0x2473A80 Offset: 0x2472C80 VA: 0x182473A80
	public static void SetGlobalMatrixArray(string name, Matrix4x4[] values) { }

	// RVA: 0x2473910 Offset: 0x2472B10 VA: 0x182473910
	public static void SetGlobalMatrixArray(int nameID, Matrix4x4[] values) { }

	// RVA: 0x2471460 Offset: 0x2470660 VA: 0x182471460
	public static int GetGlobalInt(string name) { }

	// RVA: 0x2471420 Offset: 0x2470620 VA: 0x182471420
	public static int GetGlobalInt(int nameID) { }

	// RVA: 0x2471380 Offset: 0x2470580 VA: 0x182471380
	public static float GetGlobalFloat(string name) { }

	// RVA: 0x2471340 Offset: 0x2470540 VA: 0x182471340
	public static float GetGlobalFloat(int nameID) { }

	// RVA: 0x24714C0 Offset: 0x24706C0 VA: 0x1824714C0
	public static int GetGlobalInteger(string name) { }

	// RVA: 0x24713E0 Offset: 0x24705E0 VA: 0x1824713E0
	public static int GetGlobalInteger(int nameID) { }

	// RVA: 0x2471C40 Offset: 0x2470E40 VA: 0x182471C40
	public static Vector4 GetGlobalVector(string name) { }

	// RVA: 0x2471BE0 Offset: 0x2470DE0 VA: 0x182471BE0
	public static Vector4 GetGlobalVector(int nameID) { }

	// RVA: 0x24710E0 Offset: 0x24702E0 VA: 0x1824710E0
	public static Color GetGlobalColor(string name) { }

	// RVA: 0x2471080 Offset: 0x2470280 VA: 0x182471080
	public static Color GetGlobalColor(int nameID) { }

	// RVA: 0x2471790 Offset: 0x2470990 VA: 0x182471790
	public static Matrix4x4 GetGlobalMatrix(string name) { }

	// RVA: 0x2471850 Offset: 0x2470A50 VA: 0x182471850
	public static Matrix4x4 GetGlobalMatrix(int nameID) { }

	// RVA: 0x2471920 Offset: 0x2470B20 VA: 0x182471920
	public static Texture GetGlobalTexture(string name) { }

	// RVA: 0x24718E0 Offset: 0x2470AE0 VA: 0x1824718E0
	public static Texture GetGlobalTexture(int nameID) { }

	// RVA: 0x24711F0 Offset: 0x24703F0 VA: 0x1824711F0
	public static float[] GetGlobalFloatArray(string name) { }

	// RVA: 0x24712E0 Offset: 0x24704E0 VA: 0x1824712E0
	public static float[] GetGlobalFloatArray(int nameID) { }

	// RVA: 0x2471AC0 Offset: 0x2470CC0 VA: 0x182471AC0
	public static Vector4[] GetGlobalVectorArray(string name) { }

	// RVA: 0x2471A00 Offset: 0x2470C00 VA: 0x182471A00
	public static Vector4[] GetGlobalVectorArray(int nameID) { }

	// RVA: 0x2471660 Offset: 0x2470860 VA: 0x182471660
	public static Matrix4x4[] GetGlobalMatrixArray(string name) { }

	// RVA: 0x24715A0 Offset: 0x24707A0 VA: 0x1824715A0
	public static Matrix4x4[] GetGlobalMatrixArray(int nameID) { }

	// RVA: 0x2471290 Offset: 0x2470490 VA: 0x182471290
	public static void GetGlobalFloatArray(string name, List<float> values) { }

	// RVA: 0x2471280 Offset: 0x2470480 VA: 0x182471280
	public static void GetGlobalFloatArray(int nameID, List<float> values) { }

	// RVA: 0x2471A70 Offset: 0x2470C70 VA: 0x182471A70
	public static void GetGlobalVectorArray(string name, List<Vector4> values) { }

	// RVA: 0x2471A60 Offset: 0x2470C60 VA: 0x182471A60
	public static void GetGlobalVectorArray(int nameID, List<Vector4> values) { }

	// RVA: 0x2471600 Offset: 0x2470800 VA: 0x182471600
	public static void GetGlobalMatrixArray(string name, List<Matrix4x4> values) { }

	// RVA: 0x2471650 Offset: 0x2470850 VA: 0x182471650
	public static void GetGlobalMatrixArray(int nameID, List<Matrix4x4> values) { }

	// RVA: 0x24744A0 Offset: 0x24736A0 VA: 0x1824744A0
	private void .ctor() { }

	[FreeFunction("ShaderScripting::GetPropertyName")]
	// RVA: 0x2472640 Offset: 0x2471840 VA: 0x182472640
	private static string GetPropertyName(Shader shader, int propertyIndex) { }

	[FreeFunction("ShaderScripting::GetPropertyNameId")]
	// RVA: 0x2472600 Offset: 0x2471800 VA: 0x182472600
	private static int GetPropertyNameId(Shader shader, int propertyIndex) { }

	[FreeFunction("ShaderScripting::GetPropertyType")]
	// RVA: 0x2472B60 Offset: 0x2471D60 VA: 0x182472B60
	private static ShaderPropertyType GetPropertyType(Shader shader, int propertyIndex) { }

	[FreeFunction("ShaderScripting::GetPropertyDescription")]
	// RVA: 0x24723E0 Offset: 0x24715E0 VA: 0x1824723E0
	private static string GetPropertyDescription(Shader shader, int propertyIndex) { }

	[FreeFunction("ShaderScripting::GetPropertyFlags")]
	// RVA: 0x24724F0 Offset: 0x24716F0 VA: 0x1824724F0
	private static ShaderPropertyFlags GetPropertyFlags(Shader shader, int propertyIndex) { }

	[FreeFunction("ShaderScripting::GetPropertyAttributes")]
	// RVA: 0x2471DE0 Offset: 0x2470FE0 VA: 0x182471DE0
	private static string[] GetPropertyAttributes(Shader shader, int propertyIndex) { }

	[FreeFunction("ShaderScripting::GetPropertyDefaultIntValue")]
	// RVA: 0x24720C0 Offset: 0x24712C0 VA: 0x1824720C0
	private static int GetPropertyDefaultIntValue(Shader shader, int propertyIndex) { }

	[FreeFunction("ShaderScripting::GetPropertyDefaultValue")]
	// RVA: 0x2472150 Offset: 0x2471350 VA: 0x182472150
	private static Vector4 GetPropertyDefaultValue(Shader shader, int propertyIndex) { }

	[FreeFunction("ShaderScripting::GetPropertyTextureDimension")]
	// RVA: 0x2472A00 Offset: 0x2471C00 VA: 0x182472A00
	private static TextureDimension GetPropertyTextureDimension(Shader shader, int propertyIndex) { }

	[FreeFunction("ShaderScripting::GetPropertyTextureDefaultName")]
	// RVA: 0x24728A0 Offset: 0x2471AA0 VA: 0x1824728A0
	private static string GetPropertyTextureDefaultName(Shader shader, int propertyIndex) { }

	[FreeFunction("ShaderScripting::FindTextureStack")]
	// RVA: 0x2470DB0 Offset: 0x246FFB0 VA: 0x182470DB0
	private static bool FindTextureStackImpl(Shader s, int propertyIdx, out string stackName, out int layerIndex) { }

	// RVA: 0x24701C0 Offset: 0x246F3C0 VA: 0x1824701C0
	private static void CheckPropertyIndex(Shader s, int propertyIndex) { }

	// RVA: 0x2471E20 Offset: 0x2471020 VA: 0x182471E20
	public int GetPropertyCount() { }

	// RVA: 0x2470C00 Offset: 0x246FE00 VA: 0x182470C00
	public int FindPropertyIndex(string propertyName) { }

	// RVA: 0x2472680 Offset: 0x2471880 VA: 0x182472680
	public string GetPropertyName(int propertyIndex) { }

	// RVA: 0x2472530 Offset: 0x2471730 VA: 0x182472530
	public int GetPropertyNameId(int propertyIndex) { }

	// RVA: 0x2472BA0 Offset: 0x2471DA0 VA: 0x182472BA0
	public ShaderPropertyType GetPropertyType(int propertyIndex) { }

	// RVA: 0x2472310 Offset: 0x2471510 VA: 0x182472310
	public string GetPropertyDescription(int propertyIndex) { }

	// RVA: 0x2472420 Offset: 0x2471620 VA: 0x182472420
	public ShaderPropertyFlags GetPropertyFlags(int propertyIndex) { }

	// RVA: 0x2471D10 Offset: 0x2470F10 VA: 0x182471D10
	public string[] GetPropertyAttributes(int propertyIndex) { }

	// RVA: 0x2471E60 Offset: 0x2471060 VA: 0x182471E60
	public float GetPropertyDefaultFloatValue(int propertyIndex) { }

	// RVA: 0x24721B0 Offset: 0x24713B0 VA: 0x1824721B0
	public Vector4 GetPropertyDefaultVectorValue(int propertyIndex) { }

	// RVA: 0x2472750 Offset: 0x2471950 VA: 0x182472750
	public Vector2 GetPropertyRangeLimits(int propertyIndex) { }

	// RVA: 0x2471FA0 Offset: 0x24711A0 VA: 0x182471FA0
	public int GetPropertyDefaultIntValue(int propertyIndex) { }

	// RVA: 0x2472A40 Offset: 0x2471C40 VA: 0x182472A40
	public TextureDimension GetPropertyTextureDimension(int propertyIndex) { }

	// RVA: 0x24728E0 Offset: 0x2471AE0 VA: 0x1824728E0
	public string GetPropertyTextureDefaultName(int propertyIndex) { }

	// RVA: 0x2470E10 Offset: 0x2470010 VA: 0x182470E10
	public bool FindTextureStack(int propertyIndex, out string stackName, out int layerIndex) { }

	// RVA: 0x2474630 Offset: 0x2473830 VA: 0x182474630
	private void get_keywordSpace_Injected(out LocalKeywordSpace ret) { }

	// RVA: 0x2470360 Offset: 0x246F560 VA: 0x182470360
	private static void EnableKeywordFast_Injected(ref GlobalKeyword keyword) { }

	// RVA: 0x2470260 Offset: 0x246F460 VA: 0x182470260
	private static void DisableKeywordFast_Injected(ref GlobalKeyword keyword) { }

	// RVA: 0x2474350 Offset: 0x2473550 VA: 0x182474350
	private static void SetKeywordFast_Injected(ref GlobalKeyword keyword, bool value) { }

	// RVA: 0x2472DB0 Offset: 0x2471FB0 VA: 0x182472DB0
	private static bool IsKeywordEnabledFast_Injected(ref GlobalKeyword keyword) { }

	// RVA: 0x2474210 Offset: 0x2473410 VA: 0x182474210
	private static void SetGlobalVectorImpl_Injected(int name, ref Vector4 value) { }

	// RVA: 0x2473BF0 Offset: 0x2472DF0 VA: 0x182473BF0
	private static void SetGlobalMatrixImpl_Injected(int name, ref Matrix4x4 value) { }

	// RVA: 0x2471B50 Offset: 0x2470D50 VA: 0x182471B50
	private static void GetGlobalVectorImpl_Injected(int name, out Vector4 ret) { }

	// RVA: 0x24716F0 Offset: 0x24708F0 VA: 0x1824716F0
	private static void GetGlobalMatrixImpl_Injected(int name, out Matrix4x4 ret) { }

	// RVA: 0x2472100 Offset: 0x2471300 VA: 0x182472100
	private static void GetPropertyDefaultValue_Injected(Shader shader, int propertyIndex, out Vector4 ret) { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Shaders/Material.h")]
[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
public class Material : Object // TypeDefIndex: 14014
{
	// Properties
	public Shader shader { get; set; }
	public Color color { get; set; }
	public Texture mainTexture { get; set; }
	public Vector2 mainTextureOffset { get; set; }
	public Vector2 mainTextureScale { get; set; }
	public int renderQueue { get; set; }
	internal int rawRenderQueue { get; }
	public LocalKeyword[] enabledKeywords { get; set; }
	public MaterialGlobalIlluminationFlags globalIlluminationFlags { get; set; }
	public bool doubleSidedGI { get; set; }
	[NativeProperty("EnableInstancingVariants")]
	public bool enableInstancing { get; set; }
	public int passCount { get; }
	public string[] shaderKeywords { get; set; }

	// Methods

	[Obsolete("Creating materials from shader source string will be removed in the future. Use Shader assets instead.", False)]
	// RVA: 0x245C7D0 Offset: 0x245B9D0 VA: 0x18245C7D0
	public static Material Create(string scriptContents) { }

	[FreeFunction("MaterialScripting::CreateWithShader")]
	// RVA: 0x245C740 Offset: 0x245B940 VA: 0x18245C740
	private static void CreateWithShader(Material self, Shader shader) { }

	[FreeFunction("MaterialScripting::CreateWithMaterial")]
	// RVA: 0x245C6F0 Offset: 0x245B8F0 VA: 0x18245C6F0
	private static void CreateWithMaterial(Material self, Material source) { }

	[FreeFunction("MaterialScripting::CreateWithString")]
	// RVA: 0x245C790 Offset: 0x245B990 VA: 0x18245C790
	private static void CreateWithString(Material self) { }

	// RVA: 0x2461480 Offset: 0x2460680 VA: 0x182461480
	public void .ctor(Shader shader) { }

	[RequiredByNativeCode]
	// RVA: 0x2461570 Offset: 0x2460770 VA: 0x182461570
	public void .ctor(Material source) { }

	[EditorBrowsable(1)]
	[Obsolete("Creating materials from shader source string is no longer supported. Use Shader assets instead.", False)]
	// RVA: 0x2461500 Offset: 0x2460700 VA: 0x182461500
	public void .ctor(string contents) { }

	// RVA: 0x245D8A0 Offset: 0x245CAA0 VA: 0x18245D8A0
	internal static Material GetDefaultMaterial() { }

	// RVA: 0x245D8D0 Offset: 0x245CAD0 VA: 0x18245D8D0
	internal static Material GetDefaultParticleMaterial() { }

	// RVA: 0x245D870 Offset: 0x245CA70 VA: 0x18245D870
	internal static Material GetDefaultLineMaterial() { }

	// RVA: 0x2461B00 Offset: 0x2460D00 VA: 0x182461B00
	public Shader get_shader() { }

	// RVA: 0x2461FC0 Offset: 0x24611C0 VA: 0x182461FC0
	public void set_shader(Shader value) { }

	// RVA: 0x24615F0 Offset: 0x24607F0 VA: 0x1824615F0
	public Color get_color() { }

	// RVA: 0x2461B40 Offset: 0x2460D40 VA: 0x182461B40
	public void set_color(Color value) { }

	// RVA: 0x2461980 Offset: 0x2460B80 VA: 0x182461980
	public Texture get_mainTexture() { }

	// RVA: 0x2461EB0 Offset: 0x24610B0 VA: 0x182461EB0
	public void set_mainTexture(Texture value) { }

	// RVA: 0x24617A0 Offset: 0x24609A0 VA: 0x1824617A0
	public Vector2 get_mainTextureOffset() { }

	// RVA: 0x2461CF0 Offset: 0x2460EF0 VA: 0x182461CF0
	public void set_mainTextureOffset(Vector2 value) { }

	// RVA: 0x2461890 Offset: 0x2460A90 VA: 0x182461890
	public Vector2 get_mainTextureScale() { }

	// RVA: 0x2461DD0 Offset: 0x2460FD0 VA: 0x182461DD0
	public void set_mainTextureScale(Vector2 value) { }

	[NativeName("GetFirstPropertyNameIdByAttributeFromScript")]
	// RVA: 0x245D940 Offset: 0x245CB40 VA: 0x18245D940
	private int GetFirstPropertyNameIdByAttribute(ShaderPropertyFlags attributeFlag) { }

	[NativeName("HasPropertyFromScript")]
	// RVA: 0x245F150 Offset: 0x245E350 VA: 0x18245F150
	public bool HasProperty(int nameID) { }

	// RVA: 0x245F190 Offset: 0x245E390 VA: 0x18245F190
	public bool HasProperty(string name) { }

	[NativeName("HasFloatFromScript")]
	// RVA: 0x245EF40 Offset: 0x245E140 VA: 0x18245EF40
	private bool HasFloatImpl(int name) { }

	// RVA: 0x245EF80 Offset: 0x245E180 VA: 0x18245EF80
	public bool HasFloat(string name) { }

	// RVA: 0x245EF40 Offset: 0x245E140 VA: 0x18245EF40
	public bool HasFloat(int nameID) { }

	// RVA: 0x245EF80 Offset: 0x245E180 VA: 0x18245EF80
	public bool HasInt(string name) { }

	// RVA: 0x245EF40 Offset: 0x245E140 VA: 0x18245EF40
	public bool HasInt(int nameID) { }

	[NativeName("HasIntegerFromScript")]
	// RVA: 0x245EFF0 Offset: 0x245E1F0 VA: 0x18245EFF0
	private bool HasIntImpl(int name) { }

	// RVA: 0x245F030 Offset: 0x245E230 VA: 0x18245F030
	public bool HasInteger(string name) { }

	// RVA: 0x245EFF0 Offset: 0x245E1F0 VA: 0x18245EFF0
	public bool HasInteger(int nameID) { }

	[NativeName("HasTextureFromScript")]
	// RVA: 0x245F200 Offset: 0x245E400 VA: 0x18245F200
	private bool HasTextureImpl(int name) { }

	// RVA: 0x245F240 Offset: 0x245E440 VA: 0x18245F240
	public bool HasTexture(string name) { }

	// RVA: 0x245F200 Offset: 0x245E400 VA: 0x18245F200
	public bool HasTexture(int nameID) { }

	[NativeName("HasMatrixFromScript")]
	// RVA: 0x245F0A0 Offset: 0x245E2A0 VA: 0x18245F0A0
	private bool HasMatrixImpl(int name) { }

	// RVA: 0x245F0E0 Offset: 0x245E2E0 VA: 0x18245F0E0
	public bool HasMatrix(string name) { }

	// RVA: 0x245F0A0 Offset: 0x245E2A0 VA: 0x18245F0A0
	public bool HasMatrix(int nameID) { }

	[NativeName("HasVectorFromScript")]
	// RVA: 0x245EE50 Offset: 0x245E050 VA: 0x18245EE50
	private bool HasVectorImpl(int name) { }

	// RVA: 0x245EDE0 Offset: 0x245DFE0 VA: 0x18245EDE0
	public bool HasVector(string name) { }

	// RVA: 0x245EE50 Offset: 0x245E050 VA: 0x18245EE50
	public bool HasVector(int nameID) { }

	// RVA: 0x245EDE0 Offset: 0x245DFE0 VA: 0x18245EDE0
	public bool HasColor(string name) { }

	// RVA: 0x245EE50 Offset: 0x245E050 VA: 0x18245EE50
	public bool HasColor(int nameID) { }

	[NativeName("HasBufferFromScript")]
	// RVA: 0x245ED30 Offset: 0x245DF30 VA: 0x18245ED30
	private bool HasBufferImpl(int name) { }

	// RVA: 0x245ED70 Offset: 0x245DF70 VA: 0x18245ED70
	public bool HasBuffer(string name) { }

	// RVA: 0x245ED30 Offset: 0x245DF30 VA: 0x18245ED30
	public bool HasBuffer(int nameID) { }

	[NativeName("HasConstantBufferFromScript")]
	// RVA: 0x245EE90 Offset: 0x245E090 VA: 0x18245EE90
	private bool HasConstantBufferImpl(int name) { }

	// RVA: 0x245EED0 Offset: 0x245E0D0 VA: 0x18245EED0
	public bool HasConstantBuffer(string name) { }

	// RVA: 0x245EE90 Offset: 0x245E090 VA: 0x18245EE90
	public bool HasConstantBuffer(int nameID) { }

	[NativeName("GetActualRenderQueue")]
	// RVA: 0x2461AC0 Offset: 0x2460CC0 VA: 0x182461AC0
	public int get_renderQueue() { }

	[NativeName("SetCustomRenderQueue")]
	// RVA: 0x2461F80 Offset: 0x2461180 VA: 0x182461F80
	public void set_renderQueue(int value) { }

	[NativeName("GetCustomRenderQueue")]
	// RVA: 0x2461A80 Offset: 0x2460C80 VA: 0x182461A80
	internal int get_rawRenderQueue() { }

	// RVA: 0x245CA00 Offset: 0x245BC00 VA: 0x18245CA00
	public void EnableKeyword(string keyword) { }

	// RVA: 0x245C8C0 Offset: 0x245BAC0 VA: 0x18245C8C0
	public void DisableKeyword(string keyword) { }

	// RVA: 0x245F300 Offset: 0x245E500 VA: 0x18245F300
	public bool IsKeywordEnabled(string keyword) { }

	[FreeFunction("MaterialScripting::EnableKeyword", HasExplicitThis = True)]
	// RVA: 0x245CAA0 Offset: 0x245BCA0 VA: 0x18245CAA0
	private void EnableLocalKeyword(LocalKeyword keyword) { }

	[FreeFunction("MaterialScripting::DisableKeyword", HasExplicitThis = True)]
	// RVA: 0x245C960 Offset: 0x245BB60 VA: 0x18245C960
	private void DisableLocalKeyword(LocalKeyword keyword) { }

	[FreeFunction("MaterialScripting::SetKeyword", HasExplicitThis = True)]
	// RVA: 0x2460450 Offset: 0x245F650 VA: 0x182460450
	private void SetLocalKeyword(LocalKeyword keyword, bool value) { }

	[FreeFunction("MaterialScripting::IsKeywordEnabled", HasExplicitThis = True)]
	// RVA: 0x245F3A0 Offset: 0x245E5A0 VA: 0x18245F3A0
	private bool IsLocalKeywordEnabled(LocalKeyword keyword) { }

	// RVA: 0x245C9B0 Offset: 0x245BBB0 VA: 0x18245C9B0
	public void EnableKeyword(in LocalKeyword keyword) { }

	// RVA: 0x245C870 Offset: 0x245BA70 VA: 0x18245C870
	public void DisableKeyword(in LocalKeyword keyword) { }

	// RVA: 0x2460390 Offset: 0x245F590 VA: 0x182460390
	public void SetKeyword(in LocalKeyword keyword, bool value) { }

	// RVA: 0x245F2B0 Offset: 0x245E4B0 VA: 0x18245F2B0
	public bool IsKeywordEnabled(in LocalKeyword keyword) { }

	[FreeFunction("MaterialScripting::GetEnabledKeywords", HasExplicitThis = True)]
	// RVA: 0x245D900 Offset: 0x245CB00 VA: 0x18245D900
	private LocalKeyword[] GetEnabledKeywords() { }

	[FreeFunction("MaterialScripting::SetEnabledKeywords", HasExplicitThis = True)]
	// RVA: 0x245FD10 Offset: 0x245EF10 VA: 0x18245FD10
	private void SetEnabledKeywords(LocalKeyword[] keywords) { }

	// RVA: 0x245D900 Offset: 0x245CB00 VA: 0x18245D900
	public LocalKeyword[] get_enabledKeywords() { }

	// RVA: 0x245FD10 Offset: 0x245EF10 VA: 0x18245FD10
	public void set_enabledKeywords(LocalKeyword[] value) { }

	// RVA: 0x2461760 Offset: 0x2460960 VA: 0x182461760
	public MaterialGlobalIlluminationFlags get_globalIlluminationFlags() { }

	// RVA: 0x2461CB0 Offset: 0x2460EB0 VA: 0x182461CB0
	public void set_globalIlluminationFlags(MaterialGlobalIlluminationFlags value) { }

	// RVA: 0x24616E0 Offset: 0x24608E0 VA: 0x1824616E0
	public bool get_doubleSidedGI() { }

	// RVA: 0x2461C10 Offset: 0x2460E10 VA: 0x182461C10
	public void set_doubleSidedGI(bool value) { }

	// RVA: 0x2461720 Offset: 0x2460920 VA: 0x182461720
	public bool get_enableInstancing() { }

	// RVA: 0x2461C60 Offset: 0x2460E60 VA: 0x182461C60
	public void set_enableInstancing(bool value) { }

	[NativeName("GetShader()->GetPassCount")]
	// RVA: 0x2461A40 Offset: 0x2460C40 VA: 0x182461A40
	public int get_passCount() { }

	[FreeFunction("MaterialScripting::SetShaderPassEnabled", HasExplicitThis = True)]
	// RVA: 0x2460B60 Offset: 0x245FD60 VA: 0x182460B60
	public void SetShaderPassEnabled(string passName, bool enabled) { }

	[FreeFunction("MaterialScripting::GetShaderPassEnabled", HasExplicitThis = True)]
	// RVA: 0x245E2B0 Offset: 0x245D4B0 VA: 0x18245E2B0
	public bool GetShaderPassEnabled(string passName) { }

	// RVA: 0x245E1F0 Offset: 0x245D3F0 VA: 0x18245E1F0
	public string GetPassName(int pass) { }

	// RVA: 0x245D1F0 Offset: 0x245C3F0 VA: 0x18245D1F0
	public int FindPass(string passName) { }

	// RVA: 0x2460A10 Offset: 0x245FC10 VA: 0x182460A10
	public void SetOverrideTag(string tag, string val) { }

	[NativeName("GetTag")]
	// RVA: 0x245E300 Offset: 0x245D500 VA: 0x18245E300
	private string GetTagImpl(string tag, bool currentSubShaderOnly, string defaultValue) { }

	// RVA: 0x245E400 Offset: 0x245D600 VA: 0x18245E400
	public string GetTag(string tag, bool searchFallbacks, string defaultValue) { }

	// RVA: 0x245E370 Offset: 0x245D570 VA: 0x18245E370
	public string GetTag(string tag, bool searchFallbacks) { }

	[FreeFunction("MaterialScripting::Lerp", HasExplicitThis = True)]
	[NativeThrows]
	// RVA: 0x245F3F0 Offset: 0x245E5F0 VA: 0x18245F3F0
	public void Lerp(Material start, Material end, float t) { }

	[FreeFunction("MaterialScripting::SetPass", HasExplicitThis = True)]
	// RVA: 0x2460A70 Offset: 0x245FC70 VA: 0x182460A70
	public bool SetPass(int pass) { }

	[FreeFunction("MaterialScripting::CopyPropertiesFrom", HasExplicitThis = True)]
	// RVA: 0x245C6A0 Offset: 0x245B8A0 VA: 0x18245C6A0
	public void CopyPropertiesFromMaterial(Material mat) { }

	[FreeFunction("MaterialScripting::CopyMatchingPropertiesFrom", HasExplicitThis = True)]
	// RVA: 0x245C650 Offset: 0x245B850 VA: 0x18245C650
	public void CopyMatchingPropertiesFromMaterial(Material mat) { }

	[FreeFunction("MaterialScripting::GetShaderKeywords", HasExplicitThis = True)]
	// RVA: 0x245E270 Offset: 0x245D470 VA: 0x18245E270
	private string[] GetShaderKeywords() { }

	[FreeFunction("MaterialScripting::SetShaderKeywords", HasExplicitThis = True)]
	// RVA: 0x2460B10 Offset: 0x245FD10 VA: 0x182460B10
	private void SetShaderKeywords(string[] names) { }

	// RVA: 0x245E270 Offset: 0x245D470 VA: 0x18245E270
	public string[] get_shaderKeywords() { }

	// RVA: 0x2460B10 Offset: 0x245FD10 VA: 0x182460B10
	public void set_shaderKeywords(string[] value) { }

	[FreeFunction("MaterialScripting::GetPropertyNames", HasExplicitThis = True)]
	// RVA: 0x245E230 Offset: 0x245D430 VA: 0x18245E230
	private string[] GetPropertyNamesImpl(int propertyType) { }

	// RVA: 0x245C610 Offset: 0x245B810 VA: 0x18245C610
	public int ComputeCRC() { }

	[FreeFunction("MaterialScripting::GetTexturePropertyNames", HasExplicitThis = True)]
	// RVA: 0x245E7B0 Offset: 0x245D9B0 VA: 0x18245E7B0
	public string[] GetTexturePropertyNames() { }

	[FreeFunction("MaterialScripting::GetTexturePropertyNameIDs", HasExplicitThis = True)]
	// RVA: 0x245E600 Offset: 0x245D800 VA: 0x18245E600
	public int[] GetTexturePropertyNameIDs() { }

	[FreeFunction("MaterialScripting::GetTexturePropertyNamesInternal", HasExplicitThis = True)]
	// RVA: 0x245E6D0 Offset: 0x245D8D0 VA: 0x18245E6D0
	private void GetTexturePropertyNamesInternal(object outNames) { }

	[FreeFunction("MaterialScripting::GetTexturePropertyNameIDsInternal", HasExplicitThis = True)]
	// RVA: 0x245E5B0 Offset: 0x245D7B0 VA: 0x18245E5B0
	private void GetTexturePropertyNameIDsInternal(object outNames) { }

	// RVA: 0x245E720 Offset: 0x245D920 VA: 0x18245E720
	public void GetTexturePropertyNames(List<string> outNames) { }

	// RVA: 0x245E640 Offset: 0x245D840 VA: 0x18245E640
	public void GetTexturePropertyNameIDs(List<int> outNames) { }

	[NativeName("SetIntFromScript")]
	// RVA: 0x24601E0 Offset: 0x245F3E0 VA: 0x1824601E0
	private void SetIntImpl(int name, int value) { }

	[NativeName("SetFloatFromScript")]
	// RVA: 0x2460110 Offset: 0x245F310 VA: 0x182460110
	private void SetFloatImpl(int name, float value) { }

	[NativeName("SetColorFromScript")]
	// RVA: 0x245FA00 Offset: 0x245EC00 VA: 0x18245FA00
	private void SetColorImpl(int name, Color value) { }

	[NativeName("SetMatrixFromScript")]
	// RVA: 0x24608B0 Offset: 0x245FAB0 VA: 0x1824608B0
	private void SetMatrixImpl(int name, Matrix4x4 value) { }

	[NativeName("SetTextureFromScript")]
	// RVA: 0x2460BC0 Offset: 0x245FDC0 VA: 0x182460BC0
	private void SetTextureImpl(int name, Texture value) { }

	[NativeName("SetRenderTextureFromScript")]
	// RVA: 0x2460AB0 Offset: 0x245FCB0 VA: 0x182460AB0
	private void SetRenderTextureImpl(int name, RenderTexture value, RenderTextureSubElement element) { }

	[NativeName("SetBufferFromScript")]
	// RVA: 0x245F460 Offset: 0x245E660 VA: 0x18245F460
	private void SetBufferImpl(int name, ComputeBuffer value) { }

	[NativeName("SetBufferFromScript")]
	// RVA: 0x245F4B0 Offset: 0x245E6B0 VA: 0x18245F4B0
	private void SetGraphicsBufferImpl(int name, GraphicsBuffer value) { }

	[NativeName("SetConstantBufferFromScript")]
	// RVA: 0x245FB30 Offset: 0x245ED30 VA: 0x18245FB30
	private void SetConstantBufferImpl(int name, ComputeBuffer value, int offset, int size) { }

	[NativeName("SetConstantBufferFromScript")]
	// RVA: 0x245FC20 Offset: 0x245EE20 VA: 0x18245FC20
	private void SetConstantGraphicsBufferImpl(int name, GraphicsBuffer value, int offset, int size) { }

	[NativeName("GetIntFromScript")]
	// RVA: 0x245DC40 Offset: 0x245CE40 VA: 0x18245DC40
	private int GetIntImpl(int name) { }

	[NativeName("GetFloatFromScript")]
	// RVA: 0x245DB90 Offset: 0x245CD90 VA: 0x18245DB90
	private float GetFloatImpl(int name) { }

	[NativeName("GetColorFromScript")]
	// RVA: 0x245D5D0 Offset: 0x245C7D0 VA: 0x18245D5D0
	private Color GetColorImpl(int name) { }

	[NativeName("GetMatrixFromScript")]
	// RVA: 0x245E010 Offset: 0x245D210 VA: 0x18245E010
	private Matrix4x4 GetMatrixImpl(int name) { }

	[NativeName("GetTextureFromScript")]
	// RVA: 0x245E470 Offset: 0x245D670 VA: 0x18245E470
	private Texture GetTextureImpl(int name) { }

	[NativeName("GetBufferFromScript")]
	// RVA: 0x245D290 Offset: 0x245C490 VA: 0x18245D290
	private GraphicsBufferHandle GetBufferImpl(int name) { }

	[NativeName("GetConstantBufferFromScript")]
	// RVA: 0x245D790 Offset: 0x245C990 VA: 0x18245D790
	private GraphicsBufferHandle GetConstantBufferImpl(int name) { }

	[FreeFunction(Name = "MaterialScripting::SetFloatArray", HasExplicitThis = True)]
	// RVA: 0x245FD60 Offset: 0x245EF60 VA: 0x18245FD60
	private void SetFloatArrayImpl(int name, float[] values, int count) { }

	[FreeFunction(Name = "MaterialScripting::SetVectorArray", HasExplicitThis = True)]
	// RVA: 0x2460F80 Offset: 0x2460180 VA: 0x182460F80
	private void SetVectorArrayImpl(int name, Vector4[] values, int count) { }

	[FreeFunction(Name = "MaterialScripting::SetColorArray", HasExplicitThis = True)]
	// RVA: 0x245F600 Offset: 0x245E800 VA: 0x18245F600
	private void SetColorArrayImpl(int name, Color[] values, int count) { }

	[FreeFunction(Name = "MaterialScripting::SetMatrixArray", HasExplicitThis = True)]
	// RVA: 0x24604B0 Offset: 0x245F6B0 VA: 0x1824604B0
	private void SetMatrixArrayImpl(int name, Matrix4x4[] values, int count) { }

	[FreeFunction(Name = "MaterialScripting::GetFloatArray", HasExplicitThis = True)]
	// RVA: 0x245D9C0 Offset: 0x245CBC0 VA: 0x18245D9C0
	private float[] GetFloatArrayImpl(int name) { }

	[FreeFunction(Name = "MaterialScripting::GetVectorArray", HasExplicitThis = True)]
	// RVA: 0x245EA50 Offset: 0x245DC50 VA: 0x18245EA50
	private Vector4[] GetVectorArrayImpl(int name) { }

	[FreeFunction(Name = "MaterialScripting::GetColorArray", HasExplicitThis = True)]
	// RVA: 0x245D3B0 Offset: 0x245C5B0 VA: 0x18245D3B0
	private Color[] GetColorArrayImpl(int name) { }

	[FreeFunction(Name = "MaterialScripting::GetMatrixArray", HasExplicitThis = True)]
	// RVA: 0x245DDF0 Offset: 0x245CFF0 VA: 0x18245DDF0
	private Matrix4x4[] GetMatrixArrayImpl(int name) { }

	[FreeFunction(Name = "MaterialScripting::GetFloatArrayCount", HasExplicitThis = True)]
	// RVA: 0x245D980 Offset: 0x245CB80 VA: 0x18245D980
	private int GetFloatArrayCountImpl(int name) { }

	[FreeFunction(Name = "MaterialScripting::GetVectorArrayCount", HasExplicitThis = True)]
	// RVA: 0x245EA10 Offset: 0x245DC10 VA: 0x18245EA10
	private int GetVectorArrayCountImpl(int name) { }

	[FreeFunction(Name = "MaterialScripting::GetColorArrayCount", HasExplicitThis = True)]
	// RVA: 0x245D370 Offset: 0x245C570 VA: 0x18245D370
	private int GetColorArrayCountImpl(int name) { }

	[FreeFunction(Name = "MaterialScripting::GetMatrixArrayCount", HasExplicitThis = True)]
	// RVA: 0x245DDB0 Offset: 0x245CFB0 VA: 0x18245DDB0
	private int GetMatrixArrayCountImpl(int name) { }

	[FreeFunction(Name = "MaterialScripting::ExtractFloatArray", HasExplicitThis = True)]
	// RVA: 0x245CCB0 Offset: 0x245BEB0 VA: 0x18245CCB0
	private void ExtractFloatArrayImpl(int name, [Out] float[] val) { }

	[FreeFunction(Name = "MaterialScripting::ExtractVectorArray", HasExplicitThis = True)]
	// RVA: 0x245D030 Offset: 0x245C230 VA: 0x18245D030
	private void ExtractVectorArrayImpl(int name, [Out] Vector4[] val) { }

	[FreeFunction(Name = "MaterialScripting::ExtractColorArray", HasExplicitThis = True)]
	// RVA: 0x245CAF0 Offset: 0x245BCF0 VA: 0x18245CAF0
	private void ExtractColorArrayImpl(int name, [Out] Color[] val) { }

	[FreeFunction(Name = "MaterialScripting::ExtractMatrixArray", HasExplicitThis = True)]
	// RVA: 0x245CE70 Offset: 0x245C070 VA: 0x18245CE70
	private void ExtractMatrixArrayImpl(int name, [Out] Matrix4x4[] val) { }

	[NativeName("GetTextureScaleAndOffsetFromScript")]
	// RVA: 0x245E840 Offset: 0x245DA40 VA: 0x18245E840
	private Vector4 GetTextureScaleAndOffsetImpl(int name) { }

	[NativeName("SetTextureOffsetFromScript")]
	// RVA: 0x2460C60 Offset: 0x245FE60 VA: 0x182460C60
	private void SetTextureOffsetImpl(int name, Vector2 offset) { }

	[NativeName("SetTextureScaleFromScript")]
	// RVA: 0x2460D90 Offset: 0x245FF90 VA: 0x182460D90
	private void SetTextureScaleImpl(int name, Vector2 scale) { }

	// RVA: 0x245FFB0 Offset: 0x245F1B0 VA: 0x18245FFB0
	private void SetFloatArray(int name, float[] values, int count) { }

	// RVA: 0x2461070 Offset: 0x2460270 VA: 0x182461070
	private void SetVectorArray(int name, Vector4[] values, int count) { }

	// RVA: 0x245F850 Offset: 0x245EA50 VA: 0x18245F850
	private void SetColorArray(int name, Color[] values, int count) { }

	// RVA: 0x24605C0 Offset: 0x245F7C0 VA: 0x1824605C0
	private void SetMatrixArray(int name, Matrix4x4[] values, int count) { }

	// RVA: 0x245CD00 Offset: 0x245BF00 VA: 0x18245CD00
	private void ExtractFloatArray(int name, List<float> values) { }

	// RVA: 0x245D080 Offset: 0x245C280 VA: 0x18245D080
	private void ExtractVectorArray(int name, List<Vector4> values) { }

	// RVA: 0x245CB40 Offset: 0x245BD40 VA: 0x18245CB40
	private void ExtractColorArray(int name, List<Color> values) { }

	// RVA: 0x245CEC0 Offset: 0x245C0C0 VA: 0x18245CEC0
	private void ExtractMatrixArray(int name, List<Matrix4x4> values) { }

	// RVA: 0x2460230 Offset: 0x245F430 VA: 0x182460230
	public void SetInt(string name, int value) { }

	// RVA: 0x24602B0 Offset: 0x245F4B0 VA: 0x1824602B0
	public void SetInt(int nameID, int value) { }

	// RVA: 0x2460160 Offset: 0x245F360 VA: 0x182460160
	public void SetFloat(string name, float value) { }

	// RVA: 0x2460110 Offset: 0x245F310 VA: 0x182460110
	public void SetFloat(int nameID, float value) { }

	// RVA: 0x2460310 Offset: 0x245F510 VA: 0x182460310
	public void SetInteger(string name, int value) { }

	// RVA: 0x24601E0 Offset: 0x245F3E0 VA: 0x1824601E0
	public void SetInteger(int nameID, int value) { }

	// RVA: 0x245FAA0 Offset: 0x245ECA0 VA: 0x18245FAA0
	public void SetColor(string name, Color value) { }

	// RVA: 0x245FA50 Offset: 0x245EC50 VA: 0x18245FA50
	public void SetColor(int nameID, Color value) { }

	// RVA: 0x24613C0 Offset: 0x24605C0 VA: 0x1824613C0
	public void SetVector(string name, Vector4 value) { }

	// RVA: 0x2461330 Offset: 0x2460530 VA: 0x182461330
	public void SetVector(int nameID, Vector4 value) { }

	// RVA: 0x2460900 Offset: 0x245FB00 VA: 0x182460900
	public void SetMatrix(string name, Matrix4x4 value) { }

	// RVA: 0x24609A0 Offset: 0x245FBA0 VA: 0x1824609A0
	public void SetMatrix(int nameID, Matrix4x4 value) { }

	// RVA: 0x2460E70 Offset: 0x2460070 VA: 0x182460E70
	public void SetTexture(string name, Texture value) { }

	// RVA: 0x2460BC0 Offset: 0x245FDC0 VA: 0x182460BC0
	public void SetTexture(int nameID, Texture value) { }

	// RVA: 0x2460EF0 Offset: 0x24600F0 VA: 0x182460EF0
	public void SetTexture(string name, RenderTexture value, RenderTextureSubElement element) { }

	// RVA: 0x2460AB0 Offset: 0x245FCB0 VA: 0x182460AB0
	public void SetTexture(int nameID, RenderTexture value, RenderTextureSubElement element) { }

	// RVA: 0x245F500 Offset: 0x245E700 VA: 0x18245F500
	public void SetBuffer(string name, ComputeBuffer value) { }

	// RVA: 0x245F460 Offset: 0x245E660 VA: 0x18245F460
	public void SetBuffer(int nameID, ComputeBuffer value) { }

	// RVA: 0x245F580 Offset: 0x245E780 VA: 0x18245F580
	public void SetBuffer(string name, GraphicsBuffer value) { }

	// RVA: 0x245F4B0 Offset: 0x245E6B0 VA: 0x18245F4B0
	public void SetBuffer(int nameID, GraphicsBuffer value) { }

	// RVA: 0x245FC80 Offset: 0x245EE80 VA: 0x18245FC80
	public void SetConstantBuffer(string name, ComputeBuffer value, int offset, int size) { }

	// RVA: 0x245FB30 Offset: 0x245ED30 VA: 0x18245FB30
	public void SetConstantBuffer(int nameID, ComputeBuffer value, int offset, int size) { }

	// RVA: 0x245FB90 Offset: 0x245ED90 VA: 0x18245FB90
	public void SetConstantBuffer(string name, GraphicsBuffer value, int offset, int size) { }

	// RVA: 0x245FC20 Offset: 0x245EE20 VA: 0x18245FC20
	public void SetConstantBuffer(int nameID, GraphicsBuffer value, int offset, int size) { }

	// RVA: 0x245FF00 Offset: 0x245F100 VA: 0x18245FF00
	public void SetFloatArray(string name, List<float> values) { }

	// RVA: 0x245FE70 Offset: 0x245F070 VA: 0x18245FE70
	public void SetFloatArray(int nameID, List<float> values) { }

	// RVA: 0x245FDF0 Offset: 0x245EFF0 VA: 0x18245FDF0
	public void SetFloatArray(string name, float[] values) { }

	// RVA: 0x245FDC0 Offset: 0x245EFC0 VA: 0x18245FDC0
	public void SetFloatArray(int nameID, float[] values) { }

	// RVA: 0x245F7A0 Offset: 0x245E9A0 VA: 0x18245F7A0
	public void SetColorArray(string name, List<Color> values) { }

	// RVA: 0x245F710 Offset: 0x245E910 VA: 0x18245F710
	public void SetColorArray(int nameID, List<Color> values) { }

	// RVA: 0x245F660 Offset: 0x245E860 VA: 0x18245F660
	public void SetColorArray(string name, Color[] values) { }

	// RVA: 0x245F6E0 Offset: 0x245E8E0 VA: 0x18245F6E0
	public void SetColorArray(int nameID, Color[] values) { }

	// RVA: 0x2461200 Offset: 0x2460400 VA: 0x182461200
	public void SetVectorArray(string name, List<Vector4> values) { }

	// RVA: 0x2460FE0 Offset: 0x24601E0 VA: 0x182460FE0
	public void SetVectorArray(int nameID, List<Vector4> values) { }

	// RVA: 0x24612B0 Offset: 0x24604B0 VA: 0x1824612B0
	public void SetVectorArray(string name, Vector4[] values) { }

	// RVA: 0x24611D0 Offset: 0x24603D0 VA: 0x1824611D0
	public void SetVectorArray(int nameID, Vector4[] values) { }

	// RVA: 0x2460510 Offset: 0x245F710 VA: 0x182460510
	public void SetMatrixArray(string name, List<Matrix4x4> values) { }

	// RVA: 0x2460720 Offset: 0x245F920 VA: 0x182460720
	public void SetMatrixArray(int nameID, List<Matrix4x4> values) { }

	// RVA: 0x24607E0 Offset: 0x245F9E0 VA: 0x1824607E0
	public void SetMatrixArray(string name, Matrix4x4[] values) { }

	// RVA: 0x24607B0 Offset: 0x245F9B0 VA: 0x1824607B0
	public void SetMatrixArray(int nameID, Matrix4x4[] values) { }

	// RVA: 0x245DC80 Offset: 0x245CE80 VA: 0x18245DC80
	public int GetInt(string name) { }

	// RVA: 0x245DCF0 Offset: 0x245CEF0 VA: 0x18245DCF0
	public int GetInt(int nameID) { }

	// RVA: 0x245DBD0 Offset: 0x245CDD0 VA: 0x18245DBD0
	public float GetFloat(string name) { }

	// RVA: 0x245DB90 Offset: 0x245CD90 VA: 0x18245DB90
	public float GetFloat(int nameID) { }

	// RVA: 0x245DD40 Offset: 0x245CF40 VA: 0x18245DD40
	public int GetInteger(string name) { }

	// RVA: 0x245DC40 Offset: 0x245CE40 VA: 0x18245DC40
	public int GetInteger(int nameID) { }

	// RVA: 0x245D630 Offset: 0x245C830 VA: 0x18245D630
	public Color GetColor(string name) { }

	// RVA: 0x245D6D0 Offset: 0x245C8D0 VA: 0x18245D6D0
	public Color GetColor(int nameID) { }

	// RVA: 0x245EC20 Offset: 0x245DE20 VA: 0x18245EC20
	public Vector4 GetVector(string name) { }

	// RVA: 0x245ECC0 Offset: 0x245DEC0 VA: 0x18245ECC0
	public Vector4 GetVector(int nameID) { }

	// RVA: 0x245E080 Offset: 0x245D280 VA: 0x18245E080
	public Matrix4x4 GetMatrix(string name) { }

	// RVA: 0x245E150 Offset: 0x245D350 VA: 0x18245E150
	public Matrix4x4 GetMatrix(int nameID) { }

	// RVA: 0x245E9A0 Offset: 0x245DBA0 VA: 0x18245E9A0
	public Texture GetTexture(string name) { }

	// RVA: 0x245E470 Offset: 0x245D670 VA: 0x18245E470
	public Texture GetTexture(int nameID) { }

	// RVA: 0x245D2F0 Offset: 0x245C4F0 VA: 0x18245D2F0
	public GraphicsBufferHandle GetBuffer(string name) { }

	// RVA: 0x245D7F0 Offset: 0x245C9F0 VA: 0x18245D7F0
	public GraphicsBufferHandle GetConstantBuffer(string name) { }

	// RVA: 0x245DA80 Offset: 0x245CC80 VA: 0x18245DA80
	public float[] GetFloatArray(string name) { }

	// RVA: 0x245DA00 Offset: 0x245CC00 VA: 0x18245DA00
	public float[] GetFloatArray(int nameID) { }

	// RVA: 0x245D4E0 Offset: 0x245C6E0 VA: 0x18245D4E0
	public Color[] GetColorArray(string name) { }

	// RVA: 0x245D450 Offset: 0x245C650 VA: 0x18245D450
	public Color[] GetColorArray(int nameID) { }

	// RVA: 0x245EA90 Offset: 0x245DC90 VA: 0x18245EA90
	public Vector4[] GetVectorArray(string name) { }

	// RVA: 0x245EB30 Offset: 0x245DD30 VA: 0x18245EB30
	public Vector4[] GetVectorArray(int nameID) { }

	// RVA: 0x245DE90 Offset: 0x245D090 VA: 0x18245DE90
	public Matrix4x4[] GetMatrixArray(string name) { }

	// RVA: 0x245DF40 Offset: 0x245D140 VA: 0x18245DF40
	public Matrix4x4[] GetMatrixArray(int nameID) { }

	// RVA: 0x245DB20 Offset: 0x245CD20 VA: 0x18245DB20
	public void GetFloatArray(string name, List<float> values) { }

	// RVA: 0x245DB80 Offset: 0x245CD80 VA: 0x18245DB80
	public void GetFloatArray(int nameID, List<float> values) { }

	// RVA: 0x245D3F0 Offset: 0x245C5F0 VA: 0x18245D3F0
	public void GetColorArray(string name, List<Color> values) { }

	// RVA: 0x245D4D0 Offset: 0x245C6D0 VA: 0x18245D4D0
	public void GetColorArray(int nameID, List<Color> values) { }

	// RVA: 0x245EBC0 Offset: 0x245DDC0 VA: 0x18245EBC0
	public void GetVectorArray(string name, List<Vector4> values) { }

	// RVA: 0x245EBB0 Offset: 0x245DDB0 VA: 0x18245EBB0
	public void GetVectorArray(int nameID, List<Vector4> values) { }

	// RVA: 0x245DE30 Offset: 0x245D030 VA: 0x18245DE30
	public void GetMatrixArray(string name, List<Matrix4x4> values) { }

	// RVA: 0x245DF30 Offset: 0x245D130 VA: 0x18245DF30
	public void GetMatrixArray(int nameID, List<Matrix4x4> values) { }

	// RVA: 0x2460CB0 Offset: 0x245FEB0 VA: 0x182460CB0
	public void SetTextureOffset(string name, Vector2 value) { }

	// RVA: 0x2460C60 Offset: 0x245FE60 VA: 0x182460C60
	public void SetTextureOffset(int nameID, Vector2 value) { }

	// RVA: 0x2460DE0 Offset: 0x245FFE0 VA: 0x182460DE0
	public void SetTextureScale(string name, Vector2 value) { }

	// RVA: 0x2460D90 Offset: 0x245FF90 VA: 0x182460D90
	public void SetTextureScale(int nameID, Vector2 value) { }

	// RVA: 0x245E520 Offset: 0x245D720 VA: 0x18245E520
	public Vector2 GetTextureOffset(string name) { }

	// RVA: 0x245E4B0 Offset: 0x245D6B0 VA: 0x18245E4B0
	public Vector2 GetTextureOffset(int nameID) { }

	// RVA: 0x245E910 Offset: 0x245DB10 VA: 0x18245E910
	public Vector2 GetTextureScale(string name) { }

	// RVA: 0x245E8A0 Offset: 0x245DAA0 VA: 0x18245E8A0
	public Vector2 GetTextureScale(int nameID) { }

	// RVA: 0x245E230 Offset: 0x245D430 VA: 0x18245E230
	public string[] GetPropertyNames(MaterialPropertyType type) { }

	// RVA: 0x245CA50 Offset: 0x245BC50 VA: 0x18245CA50
	private void EnableLocalKeyword_Injected(ref LocalKeyword keyword) { }

	// RVA: 0x245C910 Offset: 0x245BB10 VA: 0x18245C910
	private void DisableLocalKeyword_Injected(ref LocalKeyword keyword) { }

	// RVA: 0x24603F0 Offset: 0x245F5F0 VA: 0x1824603F0
	private void SetLocalKeyword_Injected(ref LocalKeyword keyword, bool value) { }

	// RVA: 0x245F350 Offset: 0x245E550 VA: 0x18245F350
	private bool IsLocalKeywordEnabled_Injected(ref LocalKeyword keyword) { }

	// RVA: 0x245F9B0 Offset: 0x245EBB0 VA: 0x18245F9B0
	private void SetColorImpl_Injected(int name, ref Color value) { }

	// RVA: 0x2460860 Offset: 0x245FA60 VA: 0x182460860
	private void SetMatrixImpl_Injected(int name, ref Matrix4x4 value) { }

	// RVA: 0x245D580 Offset: 0x245C780 VA: 0x18245D580
	private void GetColorImpl_Injected(int name, out Color ret) { }

	// RVA: 0x245DFC0 Offset: 0x245D1C0 VA: 0x18245DFC0
	private void GetMatrixImpl_Injected(int name, out Matrix4x4 ret) { }

	// RVA: 0x245D240 Offset: 0x245C440 VA: 0x18245D240
	private void GetBufferImpl_Injected(int name, out GraphicsBufferHandle ret) { }

	// RVA: 0x245D740 Offset: 0x245C940 VA: 0x18245D740
	private void GetConstantBufferImpl_Injected(int name, out GraphicsBufferHandle ret) { }

	// RVA: 0x245E7F0 Offset: 0x245D9F0 VA: 0x18245E7F0
	private void GetTextureScaleAndOffsetImpl_Injected(int name, out Vector4 ret) { }

	// RVA: 0x2460C10 Offset: 0x245FE10 VA: 0x182460C10
	private void SetTextureOffsetImpl_Injected(int name, ref Vector2 offset) { }

	// RVA: 0x2460D40 Offset: 0x245FF40 VA: 0x182460D40
	private void SetTextureScaleImpl_Injected(int name, ref Vector2 scale) { }
}

// Namespace: UnityEngine
[IsReadOnly]
[NativeHeader("Runtime/GfxDevice/GfxDeviceTypes.h")]
[NativeClass("GfxBufferID")]
public struct GraphicsBufferHandle : IEquatable<GraphicsBufferHandle> // TypeDefIndex: 14015
{
	// Fields
	public readonly uint value; // 0x0

	// Methods

	// RVA: 0x2459420 Offset: 0x2458620 VA: 0x182459420 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x24593A0 Offset: 0x24585A0 VA: 0x1824593A0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x244E010 Offset: 0x244D210 VA: 0x18244E010 Slot: 4
	public bool Equals(GraphicsBufferHandle other) { }
}

// Namespace: 
[Flags]
public enum GraphicsBuffer.Target // TypeDefIndex: 14016
{
	// Fields
	public int value__; // 0x0
	public const GraphicsBuffer.Target Vertex = 1;
	public const GraphicsBuffer.Target Index = 2;
	public const GraphicsBuffer.Target CopySource = 4;
	public const GraphicsBuffer.Target CopyDestination = 8;
	public const GraphicsBuffer.Target Structured = 16;
	public const GraphicsBuffer.Target Raw = 32;
	public const GraphicsBuffer.Target Append = 64;
	public const GraphicsBuffer.Target Counter = 128;
	public const GraphicsBuffer.Target IndirectArguments = 256;
	public const GraphicsBuffer.Target Constant = 512;
}

// Namespace: UnityEngine
[UsedByNativeCode]
[NativeHeader("Runtime/Export/Graphics/GraphicsBuffer.bindings.h")]
[NativeHeader("Runtime/Shaders/GraphicsBuffer.h")]
public sealed class GraphicsBuffer // TypeDefIndex: 14017
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Camera/SharedLightData.h")]
public struct LightBakingOutput // TypeDefIndex: 14018
{
	// Fields
	public int probeOcclusionLightIndex; // 0x0
	public int occlusionMaskChannel; // 0x4
	[NativeName("lightmapBakeMode.lightmapBakeType")]
	public LightmapBakeType lightmapBakeType; // 0x8
	[NativeName("lightmapBakeMode.mixedLightingMode")]
	public MixedLightingMode mixedLightingMode; // 0xC
	public bool isBaked; // 0x10
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Export/Graphics/Light.bindings.h")]
[NativeHeader("Runtime/Camera/Light.h")]
[RequireComponent(typeof(Transform))]
[RequireComponent(typeof(Transform))]
public sealed class Light : Behaviour // TypeDefIndex: 14019
{
	// Fields
	private int m_BakedIndex; // 0x18

	// Properties
	[NativeProperty("LightType")]
	public LightType type { get; }
	public float spotAngle { get; }
	public Color color { get; }
	public float colorTemperature { get; }
	public bool useColorTemperature { get; }
	public float intensity { get; }
	public float bounceIntensity { get; }
	public float range { get; }
	public LightBakingOutput bakingOutput { get; }
	public LightShadows shadows { get; }
	public float cookieSize { get; }
	public Texture cookie { get; }

	// Methods

	// RVA: 0x245AAA0 Offset: 0x2459CA0 VA: 0x18245AAA0
	public LightType get_type() { }

	// RVA: 0x245AA60 Offset: 0x2459C60 VA: 0x18245AA60
	public float get_spotAngle() { }

	// RVA: 0x245A8D0 Offset: 0x2459AD0 VA: 0x18245A8D0
	public Color get_color() { }

	// RVA: 0x245A840 Offset: 0x2459A40 VA: 0x18245A840
	public float get_colorTemperature() { }

	// RVA: 0x245AAE0 Offset: 0x2459CE0 VA: 0x18245AAE0
	public bool get_useColorTemperature() { }

	// RVA: 0x245A9A0 Offset: 0x2459BA0 VA: 0x18245A9A0
	public float get_intensity() { }

	// RVA: 0x245A800 Offset: 0x2459A00 VA: 0x18245A800
	public float get_bounceIntensity() { }

	// RVA: 0x245A9E0 Offset: 0x2459BE0 VA: 0x18245A9E0
	public float get_range() { }

	// RVA: 0x245A7B0 Offset: 0x24599B0 VA: 0x18245A7B0
	public LightBakingOutput get_bakingOutput() { }

	[NativeMethod("GetShadowType")]
	// RVA: 0x245AA20 Offset: 0x2459C20 VA: 0x18245AA20
	public LightShadows get_shadows() { }

	// RVA: 0x245A920 Offset: 0x2459B20 VA: 0x18245A920
	public float get_cookieSize() { }

	// RVA: 0x245A960 Offset: 0x2459B60 VA: 0x18245A960
	public Texture get_cookie() { }

	// RVA: 0x245A880 Offset: 0x2459A80 VA: 0x18245A880
	private void get_color_Injected(out Color ret) { }

	// RVA: 0x245A760 Offset: 0x2459960 VA: 0x18245A760
	private void get_bakingOutput_Injected(out LightBakingOutput ret) { }
}

// Namespace: UnityEngine
[RequireComponent(typeof(Transform))]
[NativeHeader("Runtime/Graphics/Mesh/MeshFilter.h")]
public sealed class MeshFilter : Component // TypeDefIndex: 14020
{
	// Properties
	public Mesh sharedMesh { get; set; }
	public Mesh mesh { get; set; }

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	private void DontStripMeshFilter() { }

	// RVA: 0x2462700 Offset: 0x2461900 VA: 0x182462700
	public Mesh get_sharedMesh() { }

	// RVA: 0x2462790 Offset: 0x2461990 VA: 0x182462790
	public void set_sharedMesh(Mesh value) { }

	[NativeName("GetInstantiatedMeshFromScript")]
	// RVA: 0x24626C0 Offset: 0x24618C0 VA: 0x1824626C0
	public Mesh get_mesh() { }

	[NativeName("SetInstantiatedMesh")]
	// RVA: 0x2462740 Offset: 0x2461940 VA: 0x182462740
	public void set_mesh(Mesh value) { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: UnityEngine
public enum RenderingPath // TypeDefIndex: 14021
{
	// Fields
	public int value__; // 0x0
	public const RenderingPath UsePlayerSettings = -1;
	public const RenderingPath VertexLit = 0;
	public const RenderingPath Forward = 1;
	[Obsolete("DeferredLighting has been removed. Use DeferredShading, Forward or HDRP/URP instead.", False)]
	public const RenderingPath DeferredLighting = 2;
	public const RenderingPath DeferredShading = 3;
}

// Namespace: UnityEngine
public enum TransparencySortMode // TypeDefIndex: 14022
{
	// Fields
	public int value__; // 0x0
	public const TransparencySortMode Default = 0;
	public const TransparencySortMode Perspective = 1;
	public const TransparencySortMode Orthographic = 2;
	public const TransparencySortMode CustomAxis = 3;
}

// Namespace: UnityEngine
public enum StereoTargetEyeMask // TypeDefIndex: 14023
{
	// Fields
	public int value__; // 0x0
	public const StereoTargetEyeMask None = 0;
	public const StereoTargetEyeMask Left = 1;
	public const StereoTargetEyeMask Right = 2;
	public const StereoTargetEyeMask Both = 3;
}

// Namespace: UnityEngine
[Flags]
public enum CameraType // TypeDefIndex: 14024
{
	// Fields
	public int value__; // 0x0
	public const CameraType Game = 1;
	public const CameraType SceneView = 2;
	public const CameraType Preview = 4;
	public const CameraType VR = 8;
	public const CameraType Reflection = 16;
}

// Namespace: UnityEngine
public enum LightType // TypeDefIndex: 14025
{
	// Fields
	public int value__; // 0x0
	public const LightType Spot = 0;
	public const LightType Directional = 1;
	public const LightType Point = 2;
	public const LightType Area = 3;
	public const LightType Rectangle = 3;
	public const LightType Disc = 4;
}

// Namespace: UnityEngine
public enum LightShadows // TypeDefIndex: 14026
{
	// Fields
	public int value__; // 0x0
	public const LightShadows None = 0;
	public const LightShadows Hard = 1;
	public const LightShadows Soft = 2;
}

// Namespace: UnityEngine
[Flags]
public enum LightmapBakeType // TypeDefIndex: 14027
{
	// Fields
	public int value__; // 0x0
	public const LightmapBakeType Realtime = 4;
	public const LightmapBakeType Baked = 2;
	public const LightmapBakeType Mixed = 1;
}

// Namespace: UnityEngine
public enum MixedLightingMode // TypeDefIndex: 14028
{
	// Fields
	public int value__; // 0x0
	public const MixedLightingMode IndirectOnly = 0;
	public const MixedLightingMode Shadowmask = 2;
	public const MixedLightingMode Subtractive = 1;
}

// Namespace: UnityEngine
public enum CameraClearFlags // TypeDefIndex: 14029
{
	// Fields
	public int value__; // 0x0
	public const CameraClearFlags Skybox = 1;
	public const CameraClearFlags Color = 2;
	public const CameraClearFlags SolidColor = 2;
	public const CameraClearFlags Depth = 3;
	public const CameraClearFlags Nothing = 4;
}

// Namespace: UnityEngine
[Flags]
public enum DepthTextureMode // TypeDefIndex: 14030
{
	// Fields
	public int value__; // 0x0
	public const DepthTextureMode None = 0;
	public const DepthTextureMode Depth = 1;
	public const DepthTextureMode DepthNormals = 2;
	public const DepthTextureMode MotionVectors = 4;
}

// Namespace: UnityEngine
public enum SkinWeights // TypeDefIndex: 14031
{
	// Fields
	public int value__; // 0x0
	public const SkinWeights None = 0;
	public const SkinWeights OneBone = 1;
	public const SkinWeights TwoBones = 2;
	public const SkinWeights FourBones = 4;
	public const SkinWeights Unlimited = 255;
}

// Namespace: UnityEngine
public enum MeshTopology // TypeDefIndex: 14032
{
	// Fields
	public int value__; // 0x0
	public const MeshTopology Triangles = 0;
	public const MeshTopology Quads = 2;
	public const MeshTopology Lines = 3;
	public const MeshTopology LineStrip = 4;
	public const MeshTopology Points = 5;
}

// Namespace: UnityEngine
public enum ColorSpace // TypeDefIndex: 14033
{
	// Fields
	public int value__; // 0x0
	public const ColorSpace Uninitialized = -1;
	public const ColorSpace Gamma = 0;
	public const ColorSpace Linear = 1;
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Graphics/ColorGamut.h")]
[UsedByNativeCode]
public enum ColorGamut // TypeDefIndex: 14034
{
	// Fields
	public int value__; // 0x0
	public const ColorGamut sRGB = 0;
	public const ColorGamut Rec709 = 1;
	public const ColorGamut Rec2020 = 2;
	public const ColorGamut DisplayP3 = 3;
	public const ColorGamut HDR10 = 4;
	public const ColorGamut DolbyHDR = 5;
	public const ColorGamut P3D65G22 = 6;
}

// Namespace: UnityEngine
public enum ScreenOrientation // TypeDefIndex: 14035
{
	// Fields
	public int value__; // 0x0
	public const ScreenOrientation Portrait = 1;
	public const ScreenOrientation PortraitUpsideDown = 2;
	public const ScreenOrientation LandscapeLeft = 3;
	public const ScreenOrientation LandscapeRight = 4;
	public const ScreenOrientation AutoRotation = 5;
	[Obsolete("Enum member Unknown has been deprecated.", False)]
	public const ScreenOrientation Unknown = 0;
	[Obsolete("Use LandscapeLeft instead (UnityUpgradable) -> LandscapeLeft", True)]
	public const ScreenOrientation Landscape = 3;
}

// Namespace: UnityEngine
public enum FilterMode // TypeDefIndex: 14036
{
	// Fields
	public int value__; // 0x0
	public const FilterMode Point = 0;
	public const FilterMode Bilinear = 1;
	public const FilterMode Trilinear = 2;
}

// Namespace: UnityEngine
public enum TextureWrapMode // TypeDefIndex: 14037
{
	// Fields
	public int value__; // 0x0
	public const TextureWrapMode Repeat = 0;
	public const TextureWrapMode Clamp = 1;
	public const TextureWrapMode Mirror = 2;
	public const TextureWrapMode MirrorOnce = 3;
}

// Namespace: UnityEngine
public enum NPOTSupport // TypeDefIndex: 14038
{
	// Fields
	public int value__; // 0x0
	[Obsolete("NPOTSupport.None does not happen on any platforms")]
	public const NPOTSupport None = 0;
	public const NPOTSupport Restricted = 1;
	public const NPOTSupport Full = 2;
}

// Namespace: UnityEngine
public enum TextureFormat // TypeDefIndex: 14039
{
	// Fields
	public int value__; // 0x0
	public const TextureFormat Alpha8 = 1;
	public const TextureFormat ARGB4444 = 2;
	public const TextureFormat RGB24 = 3;
	public const TextureFormat RGBA32 = 4;
	public const TextureFormat ARGB32 = 5;
	public const TextureFormat RGB565 = 7;
	public const TextureFormat R16 = 9;
	public const TextureFormat DXT1 = 10;
	public const TextureFormat DXT5 = 12;
	public const TextureFormat RGBA4444 = 13;
	public const TextureFormat BGRA32 = 14;
	public const TextureFormat RHalf = 15;
	public const TextureFormat RGHalf = 16;
	public const TextureFormat RGBAHalf = 17;
	public const TextureFormat RFloat = 18;
	public const TextureFormat RGFloat = 19;
	public const TextureFormat RGBAFloat = 20;
	public const TextureFormat YUY2 = 21;
	public const TextureFormat RGB9e5Float = 22;
	public const TextureFormat BC4 = 26;
	public const TextureFormat BC5 = 27;
	public const TextureFormat BC6H = 24;
	public const TextureFormat BC7 = 25;
	public const TextureFormat DXT1Crunched = 28;
	public const TextureFormat DXT5Crunched = 29;
	public const TextureFormat PVRTC_RGB2 = 30;
	public const TextureFormat PVRTC_RGBA2 = 31;
	public const TextureFormat PVRTC_RGB4 = 32;
	public const TextureFormat PVRTC_RGBA4 = 33;
	public const TextureFormat ETC_RGB4 = 34;
	public const TextureFormat EAC_R = 41;
	public const TextureFormat EAC_R_SIGNED = 42;
	public const TextureFormat EAC_RG = 43;
	public const TextureFormat EAC_RG_SIGNED = 44;
	public const TextureFormat ETC2_RGB = 45;
	public const TextureFormat ETC2_RGBA1 = 46;
	public const TextureFormat ETC2_RGBA8 = 47;
	public const TextureFormat ASTC_4x4 = 48;
	public const TextureFormat ASTC_5x5 = 49;
	public const TextureFormat ASTC_6x6 = 50;
	public const TextureFormat ASTC_8x8 = 51;
	public const TextureFormat ASTC_10x10 = 52;
	public const TextureFormat ASTC_12x12 = 53;
	[Obsolete("Nintendo 3DS is no longer supported.")]
	public const TextureFormat ETC_RGB4_3DS = 60;
	[Obsolete("Nintendo 3DS is no longer supported.")]
	public const TextureFormat ETC_RGBA8_3DS = 61;
	public const TextureFormat RG16 = 62;
	public const TextureFormat R8 = 63;
	public const TextureFormat ETC_RGB4Crunched = 64;
	public const TextureFormat ETC2_RGBA8Crunched = 65;
	public const TextureFormat ASTC_HDR_4x4 = 66;
	public const TextureFormat ASTC_HDR_5x5 = 67;
	public const TextureFormat ASTC_HDR_6x6 = 68;
	public const TextureFormat ASTC_HDR_8x8 = 69;
	public const TextureFormat ASTC_HDR_10x10 = 70;
	public const TextureFormat ASTC_HDR_12x12 = 71;
	public const TextureFormat RG32 = 72;
	public const TextureFormat RGB48 = 73;
	public const TextureFormat RGBA64 = 74;
	[EditorBrowsable(1)]
	[Obsolete("Enum member TextureFormat.ASTC_RGB_4x4 has been deprecated. Use ASTC_4x4 instead (UnityUpgradable) -> ASTC_4x4")]
	public const TextureFormat ASTC_RGB_4x4 = 48;
	[EditorBrowsable(1)]
	[Obsolete("Enum member TextureFormat.ASTC_RGB_5x5 has been deprecated. Use ASTC_5x5 instead (UnityUpgradable) -> ASTC_5x5")]
	public const TextureFormat ASTC_RGB_5x5 = 49;
	[Obsolete("Enum member TextureFormat.ASTC_RGB_6x6 has been deprecated. Use ASTC_6x6 instead (UnityUpgradable) -> ASTC_6x6")]
	[EditorBrowsable(1)]
	public const TextureFormat ASTC_RGB_6x6 = 50;
	[EditorBrowsable(1)]
	[Obsolete("Enum member TextureFormat.ASTC_RGB_8x8 has been deprecated. Use ASTC_8x8 instead (UnityUpgradable) -> ASTC_8x8")]
	public const TextureFormat ASTC_RGB_8x8 = 51;
	[EditorBrowsable(1)]
	[Obsolete("Enum member TextureFormat.ASTC_RGB_10x10 has been deprecated. Use ASTC_10x10 instead (UnityUpgradable) -> ASTC_10x10")]
	public const TextureFormat ASTC_RGB_10x10 = 52;
	[EditorBrowsable(1)]
	[Obsolete("Enum member TextureFormat.ASTC_RGB_12x12 has been deprecated. Use ASTC_12x12 instead (UnityUpgradable) -> ASTC_12x12")]
	public const TextureFormat ASTC_RGB_12x12 = 53;
	[EditorBrowsable(1)]
	[Obsolete("Enum member TextureFormat.ASTC_RGBA_4x4 has been deprecated. Use ASTC_4x4 instead (UnityUpgradable) -> ASTC_4x4")]
	public const TextureFormat ASTC_RGBA_4x4 = 54;
	[Obsolete("Enum member TextureFormat.ASTC_RGBA_5x5 has been deprecated. Use ASTC_5x5 instead (UnityUpgradable) -> ASTC_5x5")]
	[EditorBrowsable(1)]
	public const TextureFormat ASTC_RGBA_5x5 = 55;
	[EditorBrowsable(1)]
	[Obsolete("Enum member TextureFormat.ASTC_RGBA_6x6 has been deprecated. Use ASTC_6x6 instead (UnityUpgradable) -> ASTC_6x6")]
	public const TextureFormat ASTC_RGBA_6x6 = 56;
	[Obsolete("Enum member TextureFormat.ASTC_RGBA_8x8 has been deprecated. Use ASTC_8x8 instead (UnityUpgradable) -> ASTC_8x8")]
	[EditorBrowsable(1)]
	public const TextureFormat ASTC_RGBA_8x8 = 57;
	[Obsolete("Enum member TextureFormat.ASTC_RGBA_10x10 has been deprecated. Use ASTC_10x10 instead (UnityUpgradable) -> ASTC_10x10")]
	[EditorBrowsable(1)]
	public const TextureFormat ASTC_RGBA_10x10 = 58;
	[Obsolete("Enum member TextureFormat.ASTC_RGBA_12x12 has been deprecated. Use ASTC_12x12 instead (UnityUpgradable) -> ASTC_12x12")]
	[EditorBrowsable(1)]
	public const TextureFormat ASTC_RGBA_12x12 = 59;
}

// Namespace: UnityEngine
internal enum TextureColorSpace // TypeDefIndex: 14040
{
	// Fields
	public int value__; // 0x0
	public const TextureColorSpace Linear = 0;
	public const TextureColorSpace sRGB = 1;
}

// Namespace: UnityEngine
public enum CubemapFace // TypeDefIndex: 14041
{
	// Fields
	public int value__; // 0x0
	public const CubemapFace Unknown = -1;
	public const CubemapFace PositiveX = 0;
	public const CubemapFace NegativeX = 1;
	public const CubemapFace PositiveY = 2;
	public const CubemapFace NegativeY = 3;
	public const CubemapFace PositiveZ = 4;
	public const CubemapFace NegativeZ = 5;
}

// Namespace: UnityEngine
public enum RenderTextureFormat // TypeDefIndex: 14042
{
	// Fields
	public int value__; // 0x0
	public const RenderTextureFormat ARGB32 = 0;
	public const RenderTextureFormat Depth = 1;
	public const RenderTextureFormat ARGBHalf = 2;
	public const RenderTextureFormat Shadowmap = 3;
	public const RenderTextureFormat RGB565 = 4;
	public const RenderTextureFormat ARGB4444 = 5;
	public const RenderTextureFormat ARGB1555 = 6;
	public const RenderTextureFormat Default = 7;
	public const RenderTextureFormat ARGB2101010 = 8;
	public const RenderTextureFormat DefaultHDR = 9;
	public const RenderTextureFormat ARGB64 = 10;
	public const RenderTextureFormat ARGBFloat = 11;
	public const RenderTextureFormat RGFloat = 12;
	public const RenderTextureFormat RGHalf = 13;
	public const RenderTextureFormat RFloat = 14;
	public const RenderTextureFormat RHalf = 15;
	public const RenderTextureFormat R8 = 16;
	public const RenderTextureFormat ARGBInt = 17;
	public const RenderTextureFormat RGInt = 18;
	public const RenderTextureFormat RInt = 19;
	public const RenderTextureFormat BGRA32 = 20;
	public const RenderTextureFormat RGB111110Float = 22;
	public const RenderTextureFormat RG32 = 23;
	public const RenderTextureFormat RGBAUShort = 24;
	public const RenderTextureFormat RG16 = 25;
	public const RenderTextureFormat BGRA10101010_XR = 26;
	public const RenderTextureFormat BGR101010_XR = 27;
	public const RenderTextureFormat R16 = 28;
}

// Namespace: UnityEngine
public enum VRTextureUsage // TypeDefIndex: 14043
{
	// Fields
	public int value__; // 0x0
	public const VRTextureUsage None = 0;
	public const VRTextureUsage OneEye = 1;
	public const VRTextureUsage TwoEyes = 2;
	public const VRTextureUsage DeviceSpecific = 3;
}

// Namespace: UnityEngine
[Flags]
public enum RenderTextureCreationFlags // TypeDefIndex: 14044
{
	// Fields
	public int value__; // 0x0
	public const RenderTextureCreationFlags MipMap = 1;
	public const RenderTextureCreationFlags AutoGenerateMips = 2;
	public const RenderTextureCreationFlags SRGB = 4;
	public const RenderTextureCreationFlags EyeTexture = 8;
	public const RenderTextureCreationFlags EnableRandomWrite = 16;
	public const RenderTextureCreationFlags CreatedFromScript = 32;
	public const RenderTextureCreationFlags AllowVerticalFlip = 128;
	public const RenderTextureCreationFlags NoResolvedColorSurface = 256;
	public const RenderTextureCreationFlags DynamicallyScalable = 1024;
	public const RenderTextureCreationFlags BindMS = 2048;
}

// Namespace: UnityEngine
public enum RenderTextureReadWrite // TypeDefIndex: 14045
{
	// Fields
	public int value__; // 0x0
	public const RenderTextureReadWrite Default = 0;
	public const RenderTextureReadWrite Linear = 1;
	public const RenderTextureReadWrite sRGB = 2;
}

// Namespace: UnityEngine
[Flags]
public enum RenderTextureMemoryless // TypeDefIndex: 14046
{
	// Fields
	public int value__; // 0x0
	public const RenderTextureMemoryless None = 0;
	public const RenderTextureMemoryless Color = 1;
	public const RenderTextureMemoryless Depth = 2;
	public const RenderTextureMemoryless MSAA = 4;
}

// Namespace: UnityEngine
[Flags]
public enum LightmapsMode // TypeDefIndex: 14047
{
	// Fields
	public int value__; // 0x0
	public const LightmapsMode NonDirectional = 0;
	public const LightmapsMode CombinedDirectional = 1;
}

// Namespace: UnityEngine
[Flags]
public enum MaterialGlobalIlluminationFlags // TypeDefIndex: 14048
{
	// Fields
	public int value__; // 0x0
	public const MaterialGlobalIlluminationFlags None = 0;
	public const MaterialGlobalIlluminationFlags RealtimeEmissive = 1;
	public const MaterialGlobalIlluminationFlags BakedEmissive = 2;
	public const MaterialGlobalIlluminationFlags EmissiveIsBlack = 4;
	public const MaterialGlobalIlluminationFlags AnyEmissive = 3;
}

// Namespace: UnityEngine
public enum LineTextureMode // TypeDefIndex: 14049
{
	// Fields
	public int value__; // 0x0
	public const LineTextureMode Stretch = 0;
	public const LineTextureMode Tile = 1;
	public const LineTextureMode DistributePerSegment = 2;
	public const LineTextureMode RepeatPerSegment = 3;
	public const LineTextureMode Static = 4;
}

// Namespace: UnityEngine
public enum LineAlignment // TypeDefIndex: 14050
{
	// Fields
	public int value__; // 0x0
	public const LineAlignment View = 0;
	[Obsolete("Enum member Local has been deprecated. Use TransformZ instead (UnityUpgradable) -> TransformZ", False)]
	public const LineAlignment Local = 1;
	public const LineAlignment TransformZ = 1;
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Graphics/Mesh/SkinnedMeshRenderer.h")]
[RequiredByNativeCode]
public class SkinnedMeshRenderer : Renderer // TypeDefIndex: 14051
{}

// Namespace: UnityEngine
[NativeHeader("Runtime/Graphics/Mesh/MeshRenderer.h")]
public class MeshRenderer : Renderer // TypeDefIndex: 14052
{
	// Properties
	public Mesh additionalVertexStreams { get; set; }
	public Mesh enlightenVertexStream { get; set; }
	public int subMeshStartIndex { get; }

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	private void DontStripMeshRenderer() { }

	// RVA: 0x24627E0 Offset: 0x24619E0 VA: 0x1824627E0
	public Mesh get_additionalVertexStreams() { }

	// RVA: 0x24628A0 Offset: 0x2461AA0 VA: 0x1824628A0
	public void set_additionalVertexStreams(Mesh value) { }

	// RVA: 0x2462820 Offset: 0x2461A20 VA: 0x182462820
	public Mesh get_enlightenVertexStream() { }

	// RVA: 0x24628F0 Offset: 0x2461AF0 VA: 0x1824628F0
	public void set_enlightenVertexStream(Mesh value) { }

	[NativeName("GetSubMeshStartIndex")]
	// RVA: 0x2462860 Offset: 0x2461A60 VA: 0x182462860
	public int get_subMeshStartIndex() { }

	// RVA: 0x3D61A0 Offset: 0x3D53A0 VA: 0x1803D61A0
	public void .ctor() { }
}

// Namespace: 
[StaticAccessor("MeshDataBindings", 2)]
[NativeHeader("Runtime/Graphics/Mesh/MeshScriptBindings.h")]
public struct Mesh.MeshData // TypeDefIndex: 14053
{
	// Fields
	[NativeDisableUnsafePtrRestriction]
	internal IntPtr m_Ptr; // 0x0
}

// Namespace: 
[DefaultMember("Item")]
[NativeContainerSupportsMinMaxWriteRestriction]
[NativeContainer]
[StaticAccessor("MeshDataArrayBindings", 2)]
public struct Mesh.MeshDataArray : IDisposable // TypeDefIndex: 14054
{
	// Fields
	[NativeDisableUnsafePtrRestriction]
	internal IntPtr* m_Ptrs; // 0x0
	internal int m_Length; // 0x8

	// Properties
	public int Length { get; }

	// Methods

	// RVA: 0x247D170 Offset: 0x247C370 VA: 0x18247D170
	private static void AcquireReadOnlyMeshData(Mesh mesh, IntPtr* datas) { }

	// RVA: 0x247D1C0 Offset: 0x247C3C0 VA: 0x18247D1C0
	private static void AcquireReadOnlyMeshDatas(Mesh[] meshes, IntPtr* datas, int count) { }

	// RVA: 0x247D700 Offset: 0x247C900 VA: 0x18247D700
	private static void ReleaseMeshDatas(IntPtr* datas, int count) { }

	// RVA: 0x247D630 Offset: 0x247C830 VA: 0x18247D630
	private static void CreateNewMeshDatas(IntPtr* datas, int count) { }

	[NativeThrows]
	// RVA: 0x247D5C0 Offset: 0x247C7C0 VA: 0x18247D5C0
	private static void ApplyToMeshesImpl(Mesh[] meshes, IntPtr* datas, int count, MeshUpdateFlags flags) { }

	[NativeThrows]
	// RVA: 0x247D330 Offset: 0x247C530 VA: 0x18247D330
	private static void ApplyToMeshImpl(Mesh mesh, IntPtr data, MeshUpdateFlags flags) { }

	// RVA: 0x3F5510 Offset: 0x3F4710 VA: 0x1803F5510
	public int get_Length() { }

	// RVA: 0x247D670 Offset: 0x247C870 VA: 0x18247D670 Slot: 4
	public void Dispose() { }

	// RVA: 0x247D220 Offset: 0x247C420 VA: 0x18247D220
	internal void ApplyToMeshAndDispose(Mesh mesh, MeshUpdateFlags flags) { }

	// RVA: 0x247D390 Offset: 0x247C590 VA: 0x18247D390
	internal void ApplyToMeshesAndDispose(Mesh[] meshes, MeshUpdateFlags flags) { }

	// RVA: 0x247DA80 Offset: 0x247CC80 VA: 0x18247DA80
	internal void .ctor(Mesh mesh, bool checkReadWrite = True) { }

	// RVA: 0x247D740 Offset: 0x247C940 VA: 0x18247D740
	internal void .ctor(Mesh[] meshes, int meshesCount, bool checkReadWrite = True) { }

	// RVA: 0x247DC80 Offset: 0x247CE80 VA: 0x18247DC80
	internal void .ctor(int meshesCount) { }
}

// Namespace: UnityEngine
[ExcludeFromPreset]
[RequiredByNativeCode]
[NativeHeader("Runtime/Graphics/Mesh/MeshScriptBindings.h")]
public sealed class Mesh : Object // TypeDefIndex: 14055
{
	// Properties
	public IndexFormat indexFormat { get; set; }
	public int vertexBufferCount { get; }
	public GraphicsBuffer.Target vertexBufferTarget { get; set; }
	public GraphicsBuffer.Target indexBufferTarget { get; set; }
	public int blendShapeCount { get; }
	public int bindposeCount { get; }
	[NativeName("BindPosesFromScript")]
	public Matrix4x4[] bindposes { get; set; }
	public bool isReadable { get; }
	internal bool canAccess { get; }
	public int vertexCount { get; }
	public int subMeshCount { get; set; }
	public Bounds bounds { get; set; }
	public Vector3[] vertices { get; set; }
	public Vector3[] normals { get; set; }
	public Vector4[] tangents { get; set; }
	public Vector2[] uv { get; set; }
	public Vector2[] uv2 { get; set; }
	public Vector2[] uv3 { get; set; }
	public Vector2[] uv4 { get; set; }
	public Vector2[] uv5 { get; set; }
	public Vector2[] uv6 { get; set; }
	public Vector2[] uv7 { get; set; }
	public Vector2[] uv8 { get; set; }
	public Color[] colors { get; set; }
	public Color32[] colors32 { get; set; }
	public int vertexAttributeCount { get; }
	public int[] triangles { get; set; }
	public BoneWeight[] boneWeights { get; set; }
	public SkinWeights skinWeightBufferLayout { get; }

	// Methods

	[FreeFunction("MeshScripting::CreateMesh")]
	// RVA: 0x2466BD0 Offset: 0x2465DD0 VA: 0x182466BD0
	private static void Internal_Create(Mesh mono) { }

	[RequiredByNativeCode]
	// RVA: 0x246B3B0 Offset: 0x246A5B0 VA: 0x18246B3B0
	public void .ctor() { }

	[FreeFunction("MeshScripting::MeshFromInstanceId")]
	// RVA: 0x2463750 Offset: 0x2462950 VA: 0x182463750
	internal static Mesh FromInstanceID(int id) { }

	// RVA: 0x246B6A0 Offset: 0x246A8A0 VA: 0x18246B6A0
	public IndexFormat get_indexFormat() { }

	// RVA: 0x246BD80 Offset: 0x246AF80 VA: 0x18246BD80
	public void set_indexFormat(IndexFormat value) { }

	// RVA: 0x2465980 Offset: 0x2464B80 VA: 0x182465980
	internal uint GetTotalIndexCount() { }

	[FreeFunction(Name = "MeshScripting::SetIndexBufferParams", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2468200 Offset: 0x2467400 VA: 0x182468200
	public void SetIndexBufferParams(int indexCount, IndexFormat format) { }

	[FreeFunction(Name = "MeshScripting::InternalSetIndexBufferData", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2466AA0 Offset: 0x2465CA0 VA: 0x182466AA0
	private void InternalSetIndexBufferData(IntPtr data, int dataStart, int meshBufferStart, int count, int elemSize, MeshUpdateFlags flags) { }

	[FreeFunction(Name = "MeshScripting::InternalSetIndexBufferDataFromArray", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2466A30 Offset: 0x2465C30 VA: 0x182466A30
	private void InternalSetIndexBufferDataFromArray(Array data, int dataStart, int meshBufferStart, int count, int elemSize, MeshUpdateFlags flags) { }

	[FreeFunction(Name = "MeshScripting::SetVertexBufferParamsFromPtr", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x246AEF0 Offset: 0x246A0F0 VA: 0x18246AEF0
	private void SetVertexBufferParamsFromPtr(int vertexCount, IntPtr attributesPtr, int attributesCount) { }

	[FreeFunction(Name = "MeshScripting::SetVertexBufferParamsFromArray", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x246AEA0 Offset: 0x246A0A0 VA: 0x18246AEA0
	private void SetVertexBufferParamsFromArray(int vertexCount, VertexAttributeDescriptor[] attributes) { }

	[FreeFunction(Name = "MeshScripting::InternalSetVertexBufferData", HasExplicitThis = True)]
	// RVA: 0x2466B70 Offset: 0x2465D70 VA: 0x182466B70
	private void InternalSetVertexBufferData(int stream, IntPtr data, int dataStart, int meshBufferStart, int count, int elemSize, MeshUpdateFlags flags) { }

	[FreeFunction(Name = "MeshScripting::InternalSetVertexBufferDataFromArray", HasExplicitThis = True)]
	// RVA: 0x2466B10 Offset: 0x2465D10 VA: 0x182466B10
	private void InternalSetVertexBufferDataFromArray(int stream, Array data, int dataStart, int meshBufferStart, int count, int elemSize, MeshUpdateFlags flags) { }

	[FreeFunction(Name = "MeshScripting::GetVertexAttributesAlloc", HasExplicitThis = True)]
	// RVA: 0x24665B0 Offset: 0x24657B0 VA: 0x1824665B0
	private Array GetVertexAttributesAlloc() { }

	[FreeFunction(Name = "MeshScripting::GetVertexAttributesArray", HasExplicitThis = True)]
	// RVA: 0x24665F0 Offset: 0x24657F0 VA: 0x1824665F0
	private int GetVertexAttributesArray(VertexAttributeDescriptor[] attributes) { }

	[FreeFunction(Name = "MeshScripting::GetVertexAttributesList", HasExplicitThis = True)]
	// RVA: 0x2466640 Offset: 0x2465840 VA: 0x182466640
	private int GetVertexAttributesList(List<VertexAttributeDescriptor> attributes) { }

	[FreeFunction(Name = "MeshScripting::GetVertexAttributesCount", HasExplicitThis = True)]
	// RVA: 0x24663C0 Offset: 0x24655C0 VA: 0x1824663C0
	private int GetVertexAttributeCountImpl() { }

	[FreeFunction(Name = "MeshScripting::GetVertexAttributeByIndex", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2466550 Offset: 0x2465750 VA: 0x182466550
	public VertexAttributeDescriptor GetVertexAttribute(int index) { }

	[FreeFunction(Name = "MeshScripting::GetIndexStart", HasExplicitThis = True)]
	// RVA: 0x2464D10 Offset: 0x2463F10 VA: 0x182464D10
	private uint GetIndexStartImpl(int submesh) { }

	[FreeFunction(Name = "MeshScripting::GetIndexCount", HasExplicitThis = True)]
	// RVA: 0x2464C10 Offset: 0x2463E10 VA: 0x182464C10
	private uint GetIndexCountImpl(int submesh) { }

	[FreeFunction(Name = "MeshScripting::GetTrianglesCount", HasExplicitThis = True)]
	// RVA: 0x24659C0 Offset: 0x2464BC0 VA: 0x1824659C0
	private uint GetTrianglesCountImpl(int submesh) { }

	[FreeFunction(Name = "MeshScripting::GetBaseVertex", HasExplicitThis = True)]
	// RVA: 0x24639A0 Offset: 0x2462BA0 VA: 0x1824639A0
	private uint GetBaseVertexImpl(int submesh) { }

	[FreeFunction(Name = "MeshScripting::GetTriangles", HasExplicitThis = True)]
	// RVA: 0x2465A00 Offset: 0x2464C00 VA: 0x182465A00
	private int[] GetTrianglesImpl(int submesh, bool applyBaseVertex) { }

	[FreeFunction(Name = "MeshScripting::GetIndices", HasExplicitThis = True)]
	// RVA: 0x2464E10 Offset: 0x2464010 VA: 0x182464E10
	private int[] GetIndicesImpl(int submesh, bool applyBaseVertex) { }

	[FreeFunction(Name = "SetMeshIndicesFromScript", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2468250 Offset: 0x2467450 VA: 0x182468250
	private void SetIndicesImpl(int submesh, MeshTopology topology, IndexFormat indicesFormat, Array indices, int arrayStart, int arraySize, bool calculateBounds, int baseVertex) { }

	[FreeFunction(Name = "SetMeshIndicesFromNativeArray", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x24682C0 Offset: 0x24674C0 VA: 0x1824682C0
	private void SetIndicesNativeArrayImpl(int submesh, MeshTopology topology, IndexFormat indicesFormat, IntPtr indices, int arrayStart, int arraySize, bool calculateBounds, int baseVertex) { }

	[FreeFunction(Name = "MeshScripting::ExtractTrianglesToArray", HasExplicitThis = True)]
	// RVA: 0x2465AD0 Offset: 0x2464CD0 VA: 0x182465AD0
	private void GetTrianglesNonAllocImpl([Out] int[] values, int submesh, bool applyBaseVertex) { }

	[FreeFunction(Name = "MeshScripting::ExtractTrianglesToArray16", HasExplicitThis = True)]
	// RVA: 0x2465A60 Offset: 0x2464C60 VA: 0x182465A60
	private void GetTrianglesNonAllocImpl16([Out] ushort[] values, int submesh, bool applyBaseVertex) { }

	[FreeFunction(Name = "MeshScripting::ExtractIndicesToArray", HasExplicitThis = True)]
	// RVA: 0x2464EE0 Offset: 0x24640E0 VA: 0x182464EE0
	private void GetIndicesNonAllocImpl([Out] int[] values, int submesh, bool applyBaseVertex) { }

	[FreeFunction(Name = "MeshScripting::ExtractIndicesToArray16", HasExplicitThis = True)]
	// RVA: 0x2464E70 Offset: 0x2464070 VA: 0x182464E70
	private void GetIndicesNonAllocImpl16([Out] ushort[] values, int submesh, bool applyBaseVertex) { }

	[FreeFunction(Name = "MeshScripting::PrintErrorCantAccessChannel", HasExplicitThis = True)]
	// RVA: 0x2467030 Offset: 0x2466230 VA: 0x182467030
	private void PrintErrorCantAccessChannel(VertexAttribute ch) { }

	[FreeFunction(Name = "MeshScripting::HasChannel", HasExplicitThis = True)]
	// RVA: 0x2466980 Offset: 0x2465B80 VA: 0x182466980
	public bool HasVertexAttribute(VertexAttribute attr) { }

	[FreeFunction(Name = "MeshScripting::GetChannelDimension", HasExplicitThis = True)]
	// RVA: 0x2466400 Offset: 0x2465600 VA: 0x182466400
	public int GetVertexAttributeDimension(VertexAttribute attr) { }

	[FreeFunction(Name = "MeshScripting::GetChannelFormat", HasExplicitThis = True)]
	// RVA: 0x2466440 Offset: 0x2465640 VA: 0x182466440
	public VertexAttributeFormat GetVertexAttributeFormat(VertexAttribute attr) { }

	[FreeFunction(Name = "MeshScripting::GetChannelStream", HasExplicitThis = True)]
	// RVA: 0x24664C0 Offset: 0x24656C0 VA: 0x1824664C0
	public int GetVertexAttributeStream(VertexAttribute attr) { }

	[FreeFunction(Name = "MeshScripting::GetChannelOffset", HasExplicitThis = True)]
	// RVA: 0x2466480 Offset: 0x2465680 VA: 0x182466480
	public int GetVertexAttributeOffset(VertexAttribute attr) { }

	[FreeFunction(Name = "SetMeshComponentFromArrayFromScript", HasExplicitThis = True)]
	// RVA: 0x2467A10 Offset: 0x2466C10 VA: 0x182467A10
	private void SetArrayForChannelImpl(VertexAttribute channel, VertexAttributeFormat format, int dim, Array values, int arraySize, int valuesStart, int valuesCount, MeshUpdateFlags flags) { }

	[FreeFunction(Name = "SetMeshComponentFromNativeArrayFromScript", HasExplicitThis = True)]
	// RVA: 0x2468B60 Offset: 0x2467D60 VA: 0x182468B60
	private void SetNativeArrayForChannelImpl(VertexAttribute channel, VertexAttributeFormat format, int dim, IntPtr values, int arraySize, int valuesStart, int valuesCount, MeshUpdateFlags flags) { }

	[FreeFunction(Name = "AllocExtractMeshComponentFromScript", HasExplicitThis = True)]
	// RVA: 0x24638E0 Offset: 0x2462AE0 VA: 0x1824638E0
	private Array GetAllocArrayFromChannelImpl(VertexAttribute channel, VertexAttributeFormat format, int dim) { }

	[FreeFunction(Name = "ExtractMeshComponentFromScript", HasExplicitThis = True)]
	// RVA: 0x2463940 Offset: 0x2462B40 VA: 0x182463940
	private void GetArrayFromChannelImpl(VertexAttribute channel, VertexAttributeFormat format, int dim, Array values) { }

	[FreeFunction(Name = "MeshScripting::GetVertexBufferCount", HasExplicitThis = True)]
	// RVA: 0x246BA80 Offset: 0x246AC80 VA: 0x18246BA80
	public int get_vertexBufferCount() { }

	[FreeFunction(Name = "MeshScripting::GetVertexBufferStride", HasExplicitThis = True)]
	// RVA: 0x2466760 Offset: 0x2465960 VA: 0x182466760
	public int GetVertexBufferStride(int stream) { }

	[NativeThrows]
	[FreeFunction(Name = "MeshScripting::GetNativeVertexBufferPtr", HasExplicitThis = True)]
	// RVA: 0x2465590 Offset: 0x2464790 VA: 0x182465590
	public IntPtr GetNativeVertexBufferPtr(int index) { }

	[FreeFunction(Name = "MeshScripting::GetNativeIndexBufferPtr", HasExplicitThis = True)]
	// RVA: 0x2465550 Offset: 0x2464750 VA: 0x182465550
	public IntPtr GetNativeIndexBufferPtr() { }

	[FreeFunction(Name = "MeshScripting::GetVertexBufferPtr", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2466720 Offset: 0x2465920 VA: 0x182466720
	private GraphicsBuffer GetVertexBufferImpl(int index) { }

	[FreeFunction(Name = "MeshScripting::GetIndexBufferPtr", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2464B20 Offset: 0x2463D20 VA: 0x182464B20
	private GraphicsBuffer GetIndexBufferImpl() { }

	[FreeFunction(Name = "MeshScripting::GetBoneWeightBufferPtr", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x24642F0 Offset: 0x24634F0 VA: 0x1824642F0
	private GraphicsBuffer GetBoneWeightBufferImpl(int bonesPerVertex) { }

	[FreeFunction(Name = "MeshScripting::GetBlendShapeBufferPtr", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x2463D20 Offset: 0x2462F20 VA: 0x182463D20
	private GraphicsBuffer GetBlendShapeBufferImpl(int layout) { }

	// RVA: 0x246BAC0 Offset: 0x246ACC0 VA: 0x18246BAC0
	public GraphicsBuffer.Target get_vertexBufferTarget() { }

	// RVA: 0x246C2B0 Offset: 0x246B4B0 VA: 0x18246C2B0
	public void set_vertexBufferTarget(GraphicsBuffer.Target value) { }

