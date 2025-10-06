
	// Properties
	public object ClientData { get; set; }
	public ProductUserId LocalUserId { get; set; }
	public ProductUserId TargetUserId { get; set; }
	public Utf8String InviteId { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410 Slot: 4
	public object get_ClientData() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_ClientData(object value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_LocalUserId(ProductUserId value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public ProductUserId get_TargetUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_TargetUserId(ProductUserId value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public Utf8String get_InviteId() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_InviteId(Utf8String value) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x41C0A0 Offset: 0x41B2A0 VA: 0x18041C0A0
	internal void Set(ref SessionInviteReceivedCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.Sessions
internal struct SessionInviteReceivedCallbackInfoInternal : ICallbackInfoInternal, IGettable<SessionInviteReceivedCallbackInfo>, ISettable<SessionInviteReceivedCallbackInfo>, IDisposable // TypeDefIndex: 8384
{
	// Fields
	private IntPtr m_ClientData; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_TargetUserId; // 0x10
	private IntPtr m_InviteId; // 0x18

	// Properties
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public ProductUserId LocalUserId { get; set; }
	public ProductUserId TargetUserId { get; set; }
	public Utf8String InviteId { get; set; }

	// Methods

	// RVA: 0x41BD40 Offset: 0x41AF40 VA: 0x18041BD40
	public object get_ClientData() { }

	// RVA: 0x41BF20 Offset: 0x41B120 VA: 0x18041BF20
	public void set_ClientData(object value) { }

	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x41BE20 Offset: 0x41B020 VA: 0x18041BE20
	public ProductUserId get_LocalUserId() { }

	// RVA: 0x41BFE0 Offset: 0x41B1E0 VA: 0x18041BFE0
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x41BEA0 Offset: 0x41B0A0 VA: 0x18041BEA0
	public ProductUserId get_TargetUserId() { }

	// RVA: 0x41C040 Offset: 0x41B240 VA: 0x18041C040
	public void set_TargetUserId(ProductUserId value) { }

	// RVA: 0x41BDB0 Offset: 0x41AFB0 VA: 0x18041BDB0
	public Utf8String get_InviteId() { }

	// RVA: 0x41BF80 Offset: 0x41B180 VA: 0x18041BF80
	public void set_InviteId(Utf8String value) { }

	// RVA: 0x41BA50 Offset: 0x41AC50 VA: 0x18041BA50 Slot: 6
	public void Set(ref SessionInviteReceivedCallbackInfo other) { }

	// RVA: 0x41BB90 Offset: 0x41AD90 VA: 0x18041BB90 Slot: 7
	public void Set(ref Nullable<SessionInviteReceivedCallbackInfo> other) { }

	// RVA: 0x41B9C0 Offset: 0x41ABC0 VA: 0x18041B9C0 Slot: 8
	public void Dispose() { }

	// RVA: 0x41BA30 Offset: 0x41AC30 VA: 0x18041BA30 Slot: 5
	public void Get(out SessionInviteReceivedCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.Sessions
public struct SessionInviteRejectedCallbackInfo : ICallbackInfo // TypeDefIndex: 8385
{
	// Fields
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <InviteId>k__BackingField; // 0x8
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x10
	[CompilerGenerated]
	private ProductUserId <TargetUserId>k__BackingField; // 0x18
	[CompilerGenerated]
	private Utf8String <SessionId>k__BackingField; // 0x20

	// Properties
	public object ClientData { get; set; }
	public Utf8String InviteId { get; set; }
	public ProductUserId LocalUserId { get; set; }
	public ProductUserId TargetUserId { get; set; }
	public Utf8String SessionId { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410 Slot: 4
	public object get_ClientData() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_ClientData(object value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public Utf8String get_InviteId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_InviteId(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_LocalUserId(ProductUserId value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public ProductUserId get_TargetUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_TargetUserId(ProductUserId value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public Utf8String get_SessionId() { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_SessionId(Utf8String value) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x41C9F0 Offset: 0x41BBF0 VA: 0x18041C9F0
	internal void Set(ref SessionInviteRejectedCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.Sessions
internal struct SessionInviteRejectedCallbackInfoInternal : ICallbackInfoInternal, IGettable<SessionInviteRejectedCallbackInfo>, ISettable<SessionInviteRejectedCallbackInfo>, IDisposable // TypeDefIndex: 8386
{
	// Fields
	private IntPtr m_ClientData; // 0x0
	private IntPtr m_InviteId; // 0x8
	private IntPtr m_LocalUserId; // 0x10
	private IntPtr m_TargetUserId; // 0x18
	private IntPtr m_SessionId; // 0x20

	// Properties
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public Utf8String InviteId { get; set; }
	public ProductUserId LocalUserId { get; set; }
	public ProductUserId TargetUserId { get; set; }
	public Utf8String SessionId { get; set; }

	// Methods

	// RVA: 0x41C5C0 Offset: 0x41B7C0 VA: 0x18041C5C0
	public object get_ClientData() { }

	// RVA: 0x41C810 Offset: 0x41BA10 VA: 0x18041C810
	public void set_ClientData(object value) { }

	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x41C630 Offset: 0x41B830 VA: 0x18041C630
	public Utf8String get_InviteId() { }

	// RVA: 0x41C870 Offset: 0x41BA70 VA: 0x18041C870
	public void set_InviteId(Utf8String value) { }

	// RVA: 0x41C6A0 Offset: 0x41B8A0 VA: 0x18041C6A0
	public ProductUserId get_LocalUserId() { }

	// RVA: 0x41C8D0 Offset: 0x41BAD0 VA: 0x18041C8D0
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x41C790 Offset: 0x41B990 VA: 0x18041C790
	public ProductUserId get_TargetUserId() { }

	// RVA: 0x41C990 Offset: 0x41BB90 VA: 0x18041C990
	public void set_TargetUserId(ProductUserId value) { }

	// RVA: 0x41C720 Offset: 0x41B920 VA: 0x18041C720
	public Utf8String get_SessionId() { }

	// RVA: 0x41C930 Offset: 0x41BB30 VA: 0x18041C930
	public void set_SessionId(Utf8String value) { }

	// RVA: 0x41C440 Offset: 0x41B640 VA: 0x18041C440 Slot: 6
	public void Set(ref SessionInviteRejectedCallbackInfo other) { }

	// RVA: 0x41C240 Offset: 0x41B440 VA: 0x18041C240 Slot: 7
	public void Set(ref Nullable<SessionInviteRejectedCallbackInfo> other) { }

	// RVA: 0x41C190 Offset: 0x41B390 VA: 0x18041C190 Slot: 8
	public void Dispose() { }

	// RVA: 0x41C210 Offset: 0x41B410 VA: 0x18041C210 Slot: 5
	public void Get(out SessionInviteRejectedCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.Sessions
public sealed class SessionModification : Handle // TypeDefIndex: 8387
{
	// Fields
	public const int SessionmodificationAddattributeApiLatest = 2;
	public const int SessionmodificationMaxSessionAttributeLength = 64;
	public const int SessionmodificationMaxSessionAttributes = 64;
	public const int SessionmodificationMaxSessionidoverrideLength = 64;
	public const int SessionmodificationMinSessionidoverrideLength = 16;
	public const int SessionmodificationRemoveattributeApiLatest = 1;
	public const int SessionmodificationSetallowedplatformidsApiLatest = 1;
	public const int SessionmodificationSetbucketidApiLatest = 1;
	public const int SessionmodificationSethostaddressApiLatest = 1;
	public const int SessionmodificationSetinvitesallowedApiLatest = 1;
	public const int SessionmodificationSetjoininprogressallowedApiLatest = 1;
	public const int SessionmodificationSetmaxplayersApiLatest = 1;
	public const int SessionmodificationSetpermissionlevelApiLatest = 1;

	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }

	// RVA: 0x40BDB0 Offset: 0x40AFB0 VA: 0x18040BDB0
	public void .ctor(IntPtr innerHandle) { }

	// RVA: 0x41D850 Offset: 0x41CA50 VA: 0x18041D850
	public Result AddAttribute(ref SessionModificationAddAttributeOptions options) { }

	// RVA: 0x41D980 Offset: 0x41CB80 VA: 0x18041D980
	public void Release() { }

	// RVA: 0x41D990 Offset: 0x41CB90 VA: 0x18041D990
	public Result RemoveAttribute(ref SessionModificationRemoveAttributeOptions options) { }

	// RVA: 0x41DA70 Offset: 0x41CC70 VA: 0x18041DA70
	public Result SetAllowedPlatformIds(ref SessionModificationSetAllowedPlatformIdsOptions options) { }

	// RVA: 0x41DB60 Offset: 0x41CD60 VA: 0x18041DB60
	public Result SetBucketId(ref SessionModificationSetBucketIdOptions options) { }

	// RVA: 0x41DC40 Offset: 0x41CE40 VA: 0x18041DC40
	public Result SetHostAddress(ref SessionModificationSetHostAddressOptions options) { }

	// RVA: 0x41DD20 Offset: 0x41CF20 VA: 0x18041DD20
	public Result SetInvitesAllowed(ref SessionModificationSetInvitesAllowedOptions options) { }

	// RVA: 0x41DE00 Offset: 0x41D000 VA: 0x18041DE00
	public Result SetJoinInProgressAllowed(ref SessionModificationSetJoinInProgressAllowedOptions options) { }

	// RVA: 0x41DEE0 Offset: 0x41D0E0 VA: 0x18041DEE0
	public Result SetMaxPlayers(ref SessionModificationSetMaxPlayersOptions options) { }

	// RVA: 0x41DF70 Offset: 0x41D170 VA: 0x18041DF70
	public Result SetPermissionLevel(ref SessionModificationSetPermissionLevelOptions options) { }
}

// Namespace: Epic.OnlineServices.Sessions
public struct SessionModificationAddAttributeOptions // TypeDefIndex: 8388
{
	// Fields
	[CompilerGenerated]
	private Nullable<AttributeData> <SessionAttribute>k__BackingField; // 0x0
	[CompilerGenerated]
	private SessionAttributeAdvertisementType <AdvertisementType>k__BackingField; // 0x48

	// Properties
	public Nullable<AttributeData> SessionAttribute { get; set; }
	public SessionAttributeAdvertisementType AdvertisementType { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x4193E0 Offset: 0x4185E0 VA: 0x1804193E0
	public Nullable<AttributeData> get_SessionAttribute() { }

	[CompilerGenerated]
	// RVA: 0x419420 Offset: 0x418620 VA: 0x180419420
	public void set_SessionAttribute(Nullable<AttributeData> value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x4193D0 Offset: 0x4185D0 VA: 0x1804193D0
	public SessionAttributeAdvertisementType get_AdvertisementType() { }

	[CompilerGenerated]
	// RVA: 0x419410 Offset: 0x418610 VA: 0x180419410
	public void set_AdvertisementType(SessionAttributeAdvertisementType value) { }
}

// Namespace: Epic.OnlineServices.Sessions
internal struct SessionModificationAddAttributeOptionsInternal : ISettable<SessionModificationAddAttributeOptions>, IDisposable // TypeDefIndex: 8389
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_SessionAttribute; // 0x8
	private SessionAttributeAdvertisementType m_AdvertisementType; // 0x10

	// Properties
	public Nullable<AttributeData> SessionAttribute { set; }
	public SessionAttributeAdvertisementType AdvertisementType { set; }

	// Methods

	// RVA: 0x41CD60 Offset: 0x41BF60 VA: 0x18041CD60
	public void set_SessionAttribute(Nullable<AttributeData> value) { }

	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_AdvertisementType(SessionAttributeAdvertisementType value) { }

	// RVA: 0x41CCB0 Offset: 0x41BEB0 VA: 0x18041CCB0 Slot: 4
	public void Set(ref SessionModificationAddAttributeOptions other) { }

	// RVA: 0x41CB90 Offset: 0x41BD90 VA: 0x18041CB90 Slot: 5
	public void Set(ref Nullable<SessionModificationAddAttributeOptions> other) { }

	// RVA: 0x41CB40 Offset: 0x41BD40 VA: 0x18041CB40 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Sessions
public struct SessionModificationRemoveAttributeOptions // TypeDefIndex: 8390
{
	// Fields
	[CompilerGenerated]
	private Utf8String <Key>k__BackingField; // 0x0

	// Properties
	public Utf8String Key { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Utf8String get_Key() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_Key(Utf8String value) { }
}

// Namespace: Epic.OnlineServices.Sessions
internal struct SessionModificationRemoveAttributeOptionsInternal : ISettable<SessionModificationRemoveAttributeOptions>, IDisposable // TypeDefIndex: 8391
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_Key; // 0x8

	// Properties
	public Utf8String Key { set; }

	// Methods

	// RVA: 0x41CF20 Offset: 0x41C120 VA: 0x18041CF20
	public void set_Key(Utf8String value) { }

	// RVA: 0x41CE20 Offset: 0x41C020 VA: 0x18041CE20 Slot: 4
	public void Set(ref SessionModificationRemoveAttributeOptions other) { }

	// RVA: 0x41CE80 Offset: 0x41C080 VA: 0x18041CE80 Slot: 5
	public void Set(ref Nullable<SessionModificationRemoveAttributeOptions> other) { }

	// RVA: 0x41CDD0 Offset: 0x41BFD0 VA: 0x18041CDD0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Sessions
public struct SessionModificationSetAllowedPlatformIdsOptions // TypeDefIndex: 8392
{
	// Fields
	[CompilerGenerated]
	private uint[] <AllowedPlatformIds>k__BackingField; // 0x0

	// Properties
	public uint[] AllowedPlatformIds { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public uint[] get_AllowedPlatformIds() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_AllowedPlatformIds(uint[] value) { }
}

// Namespace: Epic.OnlineServices.Sessions
internal struct SessionModificationSetAllowedPlatformIdsOptionsInternal : ISettable<SessionModificationSetAllowedPlatformIdsOptions>, IDisposable // TypeDefIndex: 8393
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_AllowedPlatformIds; // 0x8
	private uint m_AllowedPlatformIdsCount; // 0x10

	// Properties
	public uint[] AllowedPlatformIds { set; }

	// Methods

	// RVA: 0x41D0C0 Offset: 0x41C2C0 VA: 0x18041D0C0
	public void set_AllowedPlatformIds(uint[] value) { }

	// RVA: 0x41CFD0 Offset: 0x41C1D0 VA: 0x18041CFD0 Slot: 4
	public void Set(ref SessionModificationSetAllowedPlatformIdsOptions other) { }

	// RVA: 0x41D050 Offset: 0x41C250 VA: 0x18041D050 Slot: 5
	public void Set(ref Nullable<SessionModificationSetAllowedPlatformIdsOptions> other) { }

	// RVA: 0x41CF80 Offset: 0x41C180 VA: 0x18041CF80 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Sessions
public struct SessionModificationSetBucketIdOptions // TypeDefIndex: 8394
{
	// Fields
	[CompilerGenerated]
	private Utf8String <BucketId>k__BackingField; // 0x0

	// Properties
	public Utf8String BucketId { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Utf8String get_BucketId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_BucketId(Utf8String value) { }
}

// Namespace: Epic.OnlineServices.Sessions
internal struct SessionModificationSetBucketIdOptionsInternal : ISettable<SessionModificationSetBucketIdOptions>, IDisposable // TypeDefIndex: 8395
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_BucketId; // 0x8

	// Properties
	public Utf8String BucketId { set; }

	// Methods

	// RVA: 0x41D280 Offset: 0x41C480 VA: 0x18041D280
	public void set_BucketId(Utf8String value) { }

	// RVA: 0x41D220 Offset: 0x41C420 VA: 0x18041D220 Slot: 4
	public void Set(ref SessionModificationSetBucketIdOptions other) { }

	// RVA: 0x41D180 Offset: 0x41C380 VA: 0x18041D180 Slot: 5
	public void Set(ref Nullable<SessionModificationSetBucketIdOptions> other) { }

	// RVA: 0x41D130 Offset: 0x41C330 VA: 0x18041D130 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Sessions
public struct SessionModificationSetHostAddressOptions // TypeDefIndex: 8396
{
	// Fields
	[CompilerGenerated]
	private Utf8String <HostAddress>k__BackingField; // 0x0

	// Properties
	public Utf8String HostAddress { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Utf8String get_HostAddress() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_HostAddress(Utf8String value) { }
}

// Namespace: Epic.OnlineServices.Sessions
internal struct SessionModificationSetHostAddressOptionsInternal : ISettable<SessionModificationSetHostAddressOptions>, IDisposable // TypeDefIndex: 8397
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_HostAddress; // 0x8

	// Properties
	public Utf8String HostAddress { set; }

	// Methods

	// RVA: 0x41D430 Offset: 0x41C630 VA: 0x18041D430
	public void set_HostAddress(Utf8String value) { }

	// RVA: 0x41D3D0 Offset: 0x41C5D0 VA: 0x18041D3D0 Slot: 4
	public void Set(ref SessionModificationSetHostAddressOptions other) { }

	// RVA: 0x41D330 Offset: 0x41C530 VA: 0x18041D330 Slot: 5
	public void Set(ref Nullable<SessionModificationSetHostAddressOptions> other) { }

	// RVA: 0x41D2E0 Offset: 0x41C4E0 VA: 0x18041D2E0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Sessions
public struct SessionModificationSetInvitesAllowedOptions // TypeDefIndex: 8398
{
	// Fields
	[CompilerGenerated]
	private bool <InvitesAllowed>k__BackingField; // 0x0

	// Properties
	public bool InvitesAllowed { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x41D600 Offset: 0x41C800 VA: 0x18041D600
	public bool get_InvitesAllowed() { }

	[CompilerGenerated]
	// RVA: 0x41D610 Offset: 0x41C810 VA: 0x18041D610
	public void set_InvitesAllowed(bool value) { }
}

// Namespace: Epic.OnlineServices.Sessions
internal struct SessionModificationSetInvitesAllowedOptionsInternal : ISettable<SessionModificationSetInvitesAllowedOptions>, IDisposable // TypeDefIndex: 8399
{
	// Fields
	private int m_ApiVersion; // 0x0
	private int m_InvitesAllowed; // 0x4

	// Properties
	public bool InvitesAllowed { set; }

	// Methods

	// RVA: 0x41D5A0 Offset: 0x41C7A0 VA: 0x18041D5A0
	public void set_InvitesAllowed(bool value) { }

	// RVA: 0x41D530 Offset: 0x41C730 VA: 0x18041D530 Slot: 4
	public void Set(ref SessionModificationSetInvitesAllowedOptions other) { }

	// RVA: 0x41D490 Offset: 0x41C690 VA: 0x18041D490 Slot: 5
	public void Set(ref Nullable<SessionModificationSetInvitesAllowedOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Sessions
public struct SessionModificationSetJoinInProgressAllowedOptions // TypeDefIndex: 8400
{
	// Fields
	[CompilerGenerated]
	private bool <AllowJoinInProgress>k__BackingField; // 0x0

	// Properties
	public bool AllowJoinInProgress { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x41D600 Offset: 0x41C800 VA: 0x18041D600
	public bool get_AllowJoinInProgress() { }

	[CompilerGenerated]
	// RVA: 0x41D610 Offset: 0x41C810 VA: 0x18041D610
	public void set_AllowJoinInProgress(bool value) { }
}

// Namespace: Epic.OnlineServices.Sessions
internal struct SessionModificationSetJoinInProgressAllowedOptionsInternal : ISettable<SessionModificationSetJoinInProgressAllowedOptions>, IDisposable // TypeDefIndex: 8401
{
	// Fields
	private int m_ApiVersion; // 0x0
	private int m_AllowJoinInProgress; // 0x4

	// Properties
	public bool AllowJoinInProgress { set; }

	// Methods

	// RVA: 0x41D730 Offset: 0x41C930 VA: 0x18041D730
	public void set_AllowJoinInProgress(bool value) { }

	// RVA: 0x41D620 Offset: 0x41C820 VA: 0x18041D620 Slot: 4
	public void Set(ref SessionModificationSetJoinInProgressAllowedOptions other) { }

	// RVA: 0x41D690 Offset: 0x41C890 VA: 0x18041D690 Slot: 5
	public void Set(ref Nullable<SessionModificationSetJoinInProgressAllowedOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Sessions
public struct SessionModificationSetMaxPlayersOptions // TypeDefIndex: 8402
{
	// Fields
	[CompilerGenerated]
	private uint <MaxPlayers>k__BackingField; // 0x0

	// Properties
	public uint MaxPlayers { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public uint get_MaxPlayers() { }

	[CompilerGenerated]
	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_MaxPlayers(uint value) { }
}

// Namespace: Epic.OnlineServices.Sessions
internal struct SessionModificationSetMaxPlayersOptionsInternal : ISettable<SessionModificationSetMaxPlayersOptions>, IDisposable // TypeDefIndex: 8403
{
	// Fields
	private int m_ApiVersion; // 0x0
	private uint m_MaxPlayers; // 0x4

	// Properties
	public uint MaxPlayers { set; }

	// Methods

	// RVA: 0x3F84A0 Offset: 0x3F76A0 VA: 0x1803F84A0
	public void set_MaxPlayers(uint value) { }

	// RVA: 0x40B2E0 Offset: 0x40A4E0 VA: 0x18040B2E0 Slot: 4
	public void Set(ref SessionModificationSetMaxPlayersOptions other) { }

	// RVA: 0x41D790 Offset: 0x41C990 VA: 0x18041D790 Slot: 5
	public void Set(ref Nullable<SessionModificationSetMaxPlayersOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Sessions
public struct SessionModificationSetPermissionLevelOptions // TypeDefIndex: 8404
{
	// Fields
	[CompilerGenerated]
	private OnlineSessionPermissionLevel <PermissionLevel>k__BackingField; // 0x0

	// Properties
	public OnlineSessionPermissionLevel PermissionLevel { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public OnlineSessionPermissionLevel get_PermissionLevel() { }

	[CompilerGenerated]
	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_PermissionLevel(OnlineSessionPermissionLevel value) { }
}

// Namespace: Epic.OnlineServices.Sessions
internal struct SessionModificationSetPermissionLevelOptionsInternal : ISettable<SessionModificationSetPermissionLevelOptions>, IDisposable // TypeDefIndex: 8405
{
	// Fields
	private int m_ApiVersion; // 0x0
	private OnlineSessionPermissionLevel m_PermissionLevel; // 0x4

	// Properties
	public OnlineSessionPermissionLevel PermissionLevel { set; }

	// Methods

	// RVA: 0x3F84A0 Offset: 0x3F76A0 VA: 0x1803F84A0
	public void set_PermissionLevel(OnlineSessionPermissionLevel value) { }

	// RVA: 0x40B2E0 Offset: 0x40A4E0 VA: 0x18040B2E0 Slot: 4
	public void Set(ref SessionModificationSetPermissionLevelOptions other) { }

	// RVA: 0x41D7F0 Offset: 0x41C9F0 VA: 0x18041D7F0 Slot: 5
	public void Set(ref Nullable<SessionModificationSetPermissionLevelOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Sessions
public sealed class SessionSearch : Handle // TypeDefIndex: 8406
{
	// Fields
	public const int SessionsearchCopysearchresultbyindexApiLatest = 1;
	public const int SessionsearchFindApiLatest = 2;
	public const int SessionsearchGetsearchresultcountApiLatest = 1;
	public const int SessionsearchRemoveparameterApiLatest = 1;
	public const int SessionsearchSetmaxsearchresultsApiLatest = 1;
	public const int SessionsearchSetparameterApiLatest = 1;
	public const int SessionsearchSetsessionidApiLatest = 1;
	public const int SessionsearchSettargetuseridApiLatest = 1;

	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }

	// RVA: 0x40BDB0 Offset: 0x40AFB0 VA: 0x18040BDB0
	public void .ctor(IntPtr innerHandle) { }

	// RVA: 0x41EEF0 Offset: 0x41E0F0 VA: 0x18041EEF0
	public Result CopySearchResultByIndex(ref SessionSearchCopySearchResultByIndexOptions options, out SessionDetails outSessionHandle) { }

	// RVA: 0x41EFC0 Offset: 0x41E1C0 VA: 0x18041EFC0
	public void Find(ref SessionSearchFindOptions options, object clientData, SessionSearchOnFindCallback completionDelegate) { }

	// RVA: 0x41F1B0 Offset: 0x41E3B0 VA: 0x18041F1B0
	public uint GetSearchResultCount(ref SessionSearchGetSearchResultCountOptions options) { }

	// RVA: 0x41F2D0 Offset: 0x41E4D0 VA: 0x18041F2D0
	public void Release() { }

	// RVA: 0x41F2E0 Offset: 0x41E4E0 VA: 0x18041F2E0
	public Result RemoveParameter(ref SessionSearchRemoveParameterOptions options) { }

	// RVA: 0x41F3D0 Offset: 0x41E5D0 VA: 0x18041F3D0
	public Result SetMaxResults(ref SessionSearchSetMaxResultsOptions options) { }

	// RVA: 0x41F460 Offset: 0x41E660 VA: 0x18041F460
	public Result SetParameter(ref SessionSearchSetParameterOptions options) { }

	// RVA: 0x41F590 Offset: 0x41E790 VA: 0x18041F590
	public Result SetSessionId(ref SessionSearchSetSessionIdOptions options) { }

	// RVA: 0x41F670 Offset: 0x41E870 VA: 0x18041F670
	public Result SetTargetUserId(ref SessionSearchSetTargetUserIdOptions options) { }

	[MonoPInvokeCallback(typeof(SessionSearchOnFindCallbackInternal))]
	// RVA: 0x41F230 Offset: 0x41E430 VA: 0x18041F230
	internal static void OnFindCallbackInternalImplementation(ref SessionSearchFindCallbackInfoInternal data) { }
}

// Namespace: Epic.OnlineServices.Sessions
public struct SessionSearchCopySearchResultByIndexOptions // TypeDefIndex: 8407
{
	// Fields
	[CompilerGenerated]
	private uint <SessionIndex>k__BackingField; // 0x0

	// Properties
	public uint SessionIndex { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public uint get_SessionIndex() { }

	[CompilerGenerated]
	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_SessionIndex(uint value) { }
}

// Namespace: Epic.OnlineServices.Sessions
internal struct SessionSearchCopySearchResultByIndexOptionsInternal : ISettable<SessionSearchCopySearchResultByIndexOptions>, IDisposable // TypeDefIndex: 8408
{
	// Fields
	private int m_ApiVersion; // 0x0
	private uint m_SessionIndex; // 0x4

	// Properties
	public uint SessionIndex { set; }

	// Methods

	// RVA: 0x3F84A0 Offset: 0x3F76A0 VA: 0x1803F84A0
	public void set_SessionIndex(uint value) { }

	// RVA: 0x40B2E0 Offset: 0x40A4E0 VA: 0x18040B2E0 Slot: 4
	public void Set(ref SessionSearchCopySearchResultByIndexOptions other) { }

	// RVA: 0x41E000 Offset: 0x41D200 VA: 0x18041E000 Slot: 5
	public void Set(ref Nullable<SessionSearchCopySearchResultByIndexOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Sessions
public struct SessionSearchFindCallbackInfo : ICallbackInfo // TypeDefIndex: 8409
{
	// Fields
	[CompilerGenerated]
	private Result <ResultCode>k__BackingField; // 0x0
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x8

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	[CompilerGenerated]
	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public object get_ClientData() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_ClientData(object value) { }

	// RVA: 0x41E2C0 Offset: 0x41D4C0 VA: 0x18041E2C0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x41E310 Offset: 0x41D510 VA: 0x18041E310
	internal void Set(ref SessionSearchFindCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.Sessions
internal struct SessionSearchFindCallbackInfoInternal : ICallbackInfoInternal, IGettable<SessionSearchFindCallbackInfo>, ISettable<SessionSearchFindCallbackInfo>, IDisposable // TypeDefIndex: 8410
{
	// Fields
	private Result m_ResultCode; // 0x0
	private IntPtr m_ClientData; // 0x8

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }

	// Methods

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	// RVA: 0x41E1F0 Offset: 0x41D3F0 VA: 0x18041E1F0
	public object get_ClientData() { }

	// RVA: 0x41E260 Offset: 0x41D460 VA: 0x18041E260
	public void set_ClientData(object value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x41E190 Offset: 0x41D390 VA: 0x18041E190 Slot: 6
	public void Set(ref SessionSearchFindCallbackInfo other) { }

	// RVA: 0x41E0D0 Offset: 0x41D2D0 VA: 0x18041E0D0 Slot: 7
	public void Set(ref Nullable<SessionSearchFindCallbackInfo> other) { }

	// RVA: 0x41E060 Offset: 0x41D260 VA: 0x18041E060 Slot: 8
	public void Dispose() { }

	// RVA: 0x41E0B0 Offset: 0x41D2B0 VA: 0x18041E0B0 Slot: 5
	public void Get(out SessionSearchFindCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.Sessions
public struct SessionSearchFindOptions // TypeDefIndex: 8411
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x0

	// Properties
	public ProductUserId LocalUserId { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_LocalUserId(ProductUserId value) { }
}

// Namespace: Epic.OnlineServices.Sessions
internal struct SessionSearchFindOptionsInternal : ISettable<SessionSearchFindOptions>, IDisposable // TypeDefIndex: 8412
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8

	// Properties
	public ProductUserId LocalUserId { set; }

	// Methods

	// RVA: 0x41E4E0 Offset: 0x41D6E0 VA: 0x18041E4E0
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x41E3E0 Offset: 0x41D5E0 VA: 0x18041E3E0 Slot: 4
	public void Set(ref SessionSearchFindOptions other) { }

	// RVA: 0x41E440 Offset: 0x41D640 VA: 0x18041E440 Slot: 5
	public void Set(ref Nullable<SessionSearchFindOptions> other) { }

	// RVA: 0x41E390 Offset: 0x41D590 VA: 0x18041E390 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Sessions
public struct SessionSearchGetSearchResultCountOptions // TypeDefIndex: 8413
{}

// Namespace: Epic.OnlineServices.Sessions
internal struct SessionSearchGetSearchResultCountOptionsInternal : ISettable<SessionSearchGetSearchResultCountOptions>, IDisposable // TypeDefIndex: 8414
{
	// Fields
	private int m_ApiVersion; // 0x0

	// Methods

	// RVA: 0x3F98A0 Offset: 0x3F8AA0 VA: 0x1803F98A0 Slot: 4
	public void Set(ref SessionSearchGetSearchResultCountOptions other) { }

	// RVA: 0x41E540 Offset: 0x41D740 VA: 0x18041E540 Slot: 5
	public void Set(ref Nullable<SessionSearchGetSearchResultCountOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Sessions
public sealed class SessionSearchOnFindCallback : MulticastDelegate // TypeDefIndex: 8415
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref SessionSearchFindCallbackInfo data) { }

	// RVA: 0x41E620 Offset: 0x41D820 VA: 0x18041E620 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref SessionSearchFindCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref SessionSearchFindCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Sessions
[UnmanagedFunctionPointer(2)]
internal sealed class SessionSearchOnFindCallbackInternal : MulticastDelegate // TypeDefIndex: 8416
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref SessionSearchFindCallbackInfoInternal data) { }

	// RVA: 0x41E590 Offset: 0x41D790 VA: 0x18041E590 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref SessionSearchFindCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref SessionSearchFindCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Sessions
public struct SessionSearchRemoveParameterOptions // TypeDefIndex: 8417
{
	// Fields
	[CompilerGenerated]
	private Utf8String <Key>k__BackingField; // 0x0
	[CompilerGenerated]
	private ComparisonOp <ComparisonOp>k__BackingField; // 0x8

	// Properties
	public Utf8String Key { get; set; }
	public ComparisonOp ComparisonOp { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Utf8String get_Key() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_Key(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3F5510 Offset: 0x3F4710 VA: 0x1803F5510
	public ComparisonOp get_ComparisonOp() { }

	[CompilerGenerated]
	// RVA: 0x3F5520 Offset: 0x3F4720 VA: 0x1803F5520
	public void set_ComparisonOp(ComparisonOp value) { }
}

// Namespace: Epic.OnlineServices.Sessions
internal struct SessionSearchRemoveParameterOptionsInternal : ISettable<SessionSearchRemoveParameterOptions>, IDisposable // TypeDefIndex: 8418
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_Key; // 0x8
	private ComparisonOp m_ComparisonOp; // 0x10

	// Properties
	public Utf8String Key { set; }
	public ComparisonOp ComparisonOp { set; }

	// Methods

	// RVA: 0x41E840 Offset: 0x41DA40 VA: 0x18041E840
	public void set_Key(Utf8String value) { }

	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_ComparisonOp(ComparisonOp value) { }

	// RVA: 0x41E700 Offset: 0x41D900 VA: 0x18041E700 Slot: 4
	public void Set(ref SessionSearchRemoveParameterOptions other) { }

	// RVA: 0x41E780 Offset: 0x41D980 VA: 0x18041E780 Slot: 5
	public void Set(ref Nullable<SessionSearchRemoveParameterOptions> other) { }

	// RVA: 0x41E6B0 Offset: 0x41D8B0 VA: 0x18041E6B0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Sessions
public struct SessionSearchSetMaxResultsOptions // TypeDefIndex: 8419
{
	// Fields
	[CompilerGenerated]
	private uint <MaxSearchResults>k__BackingField; // 0x0

	// Properties
	public uint MaxSearchResults { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public uint get_MaxSearchResults() { }

	[CompilerGenerated]
	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_MaxSearchResults(uint value) { }
}

// Namespace: Epic.OnlineServices.Sessions
internal struct SessionSearchSetMaxResultsOptionsInternal : ISettable<SessionSearchSetMaxResultsOptions>, IDisposable // TypeDefIndex: 8420
{
	// Fields
	private int m_ApiVersion; // 0x0
	private uint m_MaxSearchResults; // 0x4

	// Properties
	public uint MaxSearchResults { set; }

	// Methods

	// RVA: 0x3F84A0 Offset: 0x3F76A0 VA: 0x1803F84A0
	public void set_MaxSearchResults(uint value) { }

	// RVA: 0x40B2E0 Offset: 0x40A4E0 VA: 0x18040B2E0 Slot: 4
	public void Set(ref SessionSearchSetMaxResultsOptions other) { }

	// RVA: 0x41E8A0 Offset: 0x41DAA0 VA: 0x18041E8A0 Slot: 5
	public void Set(ref Nullable<SessionSearchSetMaxResultsOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Sessions
public struct SessionSearchSetParameterOptions // TypeDefIndex: 8421
{
	// Fields
	[CompilerGenerated]
	private Nullable<AttributeData> <Parameter>k__BackingField; // 0x0
	[CompilerGenerated]
	private ComparisonOp <ComparisonOp>k__BackingField; // 0x48

	// Properties
	public Nullable<AttributeData> Parameter { get; set; }
	public ComparisonOp ComparisonOp { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x4193E0 Offset: 0x4185E0 VA: 0x1804193E0
	public Nullable<AttributeData> get_Parameter() { }

	[CompilerGenerated]
	// RVA: 0x419420 Offset: 0x418620 VA: 0x180419420
	public void set_Parameter(Nullable<AttributeData> value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x4193D0 Offset: 0x4185D0 VA: 0x1804193D0
	public ComparisonOp get_ComparisonOp() { }

	[CompilerGenerated]
	// RVA: 0x419410 Offset: 0x418610 VA: 0x180419410
	public void set_ComparisonOp(ComparisonOp value) { }
}

// Namespace: Epic.OnlineServices.Sessions
internal struct SessionSearchSetParameterOptionsInternal : ISettable<SessionSearchSetParameterOptions>, IDisposable // TypeDefIndex: 8422
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_Parameter; // 0x8
	private ComparisonOp m_ComparisonOp; // 0x10

	// Properties
	public Nullable<AttributeData> Parameter { set; }
	public ComparisonOp ComparisonOp { set; }

	// Methods

	// RVA: 0x41EB20 Offset: 0x41DD20 VA: 0x18041EB20
	public void set_Parameter(Nullable<AttributeData> value) { }

	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_ComparisonOp(ComparisonOp value) { }

	// RVA: 0x41EA70 Offset: 0x41DC70 VA: 0x18041EA70 Slot: 4
	public void Set(ref SessionSearchSetParameterOptions other) { }

	// RVA: 0x41E950 Offset: 0x41DB50 VA: 0x18041E950 Slot: 5
	public void Set(ref Nullable<SessionSearchSetParameterOptions> other) { }

	// RVA: 0x41E900 Offset: 0x41DB00 VA: 0x18041E900 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Sessions
public struct SessionSearchSetSessionIdOptions // TypeDefIndex: 8423
{
	// Fields
	[CompilerGenerated]
	private Utf8String <SessionId>k__BackingField; // 0x0

	// Properties
	public Utf8String SessionId { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Utf8String get_SessionId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_SessionId(Utf8String value) { }
}

// Namespace: Epic.OnlineServices.Sessions
internal struct SessionSearchSetSessionIdOptionsInternal : ISettable<SessionSearchSetSessionIdOptions>, IDisposable // TypeDefIndex: 8424
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_SessionId; // 0x8

	// Properties
	public Utf8String SessionId { set; }

	// Methods

	// RVA: 0x41ECE0 Offset: 0x41DEE0 VA: 0x18041ECE0
	public void set_SessionId(Utf8String value) { }

	// RVA: 0x41EC80 Offset: 0x41DE80 VA: 0x18041EC80 Slot: 4
	public void Set(ref SessionSearchSetSessionIdOptions other) { }

	// RVA: 0x41EBE0 Offset: 0x41DDE0 VA: 0x18041EBE0 Slot: 5
	public void Set(ref Nullable<SessionSearchSetSessionIdOptions> other) { }

	// RVA: 0x41EB90 Offset: 0x41DD90 VA: 0x18041EB90 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Sessions
public struct SessionSearchSetTargetUserIdOptions // TypeDefIndex: 8425
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <TargetUserId>k__BackingField; // 0x0

	// Properties
	public ProductUserId TargetUserId { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public ProductUserId get_TargetUserId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_TargetUserId(ProductUserId value) { }
}

// Namespace: Epic.OnlineServices.Sessions
internal struct SessionSearchSetTargetUserIdOptionsInternal : ISettable<SessionSearchSetTargetUserIdOptions>, IDisposable // TypeDefIndex: 8426
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_TargetUserId; // 0x8

	// Properties
	public ProductUserId TargetUserId { set; }

	// Methods

	// RVA: 0x41EE90 Offset: 0x41E090 VA: 0x18041EE90
	public void set_TargetUserId(ProductUserId value) { }

	// RVA: 0x41EE30 Offset: 0x41E030 VA: 0x18041EE30 Slot: 4
	public void Set(ref SessionSearchSetTargetUserIdOptions other) { }

	// RVA: 0x41ED90 Offset: 0x41DF90 VA: 0x18041ED90 Slot: 5
	public void Set(ref Nullable<SessionSearchSetTargetUserIdOptions> other) { }

	// RVA: 0x41ED40 Offset: 0x41DF40 VA: 0x18041ED40 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Sessions
public sealed class SessionsInterface : Handle // TypeDefIndex: 8427
{
	// Fields
	public const int AddnotifyjoinsessionacceptedApiLatest = 1;
	public const int AddnotifyleavesessionrequestedApiLatest = 1;
	public const int AddnotifysendsessionnativeinviterequestedApiLatest = 1;
	public const int AddnotifysessioninviteacceptedApiLatest = 1;
	public const int AddnotifysessioninvitereceivedApiLatest = 1;
	public const int AddnotifysessioninviterejectedApiLatest = 1;
	public const int AttributedataApiLatest = 1;
	public const int CopyactivesessionhandleApiLatest = 1;
	public const int CopysessionhandlebyinviteidApiLatest = 1;
	public const int CopysessionhandlebyuieventidApiLatest = 1;
	public const int CopysessionhandleforpresenceApiLatest = 1;
	public const int CreatesessionmodificationApiLatest = 5;
	public const int CreatesessionsearchApiLatest = 1;
	public const int DestroysessionApiLatest = 1;
	public const int DumpsessionstateApiLatest = 1;
	public const int EndsessionApiLatest = 1;
	public const int GetinvitecountApiLatest = 1;
	public const int GetinviteidbyindexApiLatest = 1;
	public const int InviteidMaxLength = 64;
	public const int IsuserinsessionApiLatest = 1;
	public const int JoinsessionApiLatest = 2;
	public const int MaxSearchResults = 200;
	public const int Maxregisteredplayers = 1000;
	public const int QueryinvitesApiLatest = 1;
	public const int RegisterplayersApiLatest = 3;
	public const int RejectinviteApiLatest = 1;
	public static readonly Utf8String SearchBucketId; // 0x0
	public static readonly Utf8String SearchEmptyServersOnly; // 0x8
	public static readonly Utf8String SearchMinslotsavailable; // 0x10
	public static readonly Utf8String SearchNonemptyServersOnly; // 0x18
	public const int SendinviteApiLatest = 1;
	public const int SessionattributeApiLatest = 1;
	public const int SessionattributedataApiLatest = 1;
	public const int StartsessionApiLatest = 1;
	public const int UnregisterplayersApiLatest = 2;
	public const int UpdatesessionApiLatest = 1;
	public const int UpdatesessionmodificationApiLatest = 1;

	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }

	// RVA: 0x40BDB0 Offset: 0x40AFB0 VA: 0x18040BDB0
	public void .ctor(IntPtr innerHandle) { }

	// RVA: 0x41F750 Offset: 0x41E950 VA: 0x18041F750
	public ulong AddNotifyJoinSessionAccepted(ref AddNotifyJoinSessionAcceptedOptions options, object clientData, OnJoinSessionAcceptedCallback notificationFn) { }

	// RVA: 0x41F900 Offset: 0x41EB00 VA: 0x18041F900
	public ulong AddNotifyLeaveSessionRequested(ref AddNotifyLeaveSessionRequestedOptions options, object clientData, OnLeaveSessionRequestedCallback notificationFn) { }

	// RVA: 0x41FAB0 Offset: 0x41ECB0 VA: 0x18041FAB0
	public ulong AddNotifySendSessionNativeInviteRequested(ref AddNotifySendSessionNativeInviteRequestedOptions options, object clientData, OnSendSessionNativeInviteRequestedCallback notificationFn) { }

	// RVA: 0x41FC60 Offset: 0x41EE60 VA: 0x18041FC60
	public ulong AddNotifySessionInviteAccepted(ref AddNotifySessionInviteAcceptedOptions options, object clientData, OnSessionInviteAcceptedCallback notificationFn) { }

	// RVA: 0x41FE10 Offset: 0x41F010 VA: 0x18041FE10
	public ulong AddNotifySessionInviteReceived(ref AddNotifySessionInviteReceivedOptions options, object clientData, OnSessionInviteReceivedCallback notificationFn) { }

	// RVA: 0x41FFC0 Offset: 0x41F1C0 VA: 0x18041FFC0
	public ulong AddNotifySessionInviteRejected(ref AddNotifySessionInviteRejectedOptions options, object clientData, OnSessionInviteRejectedCallback notificationFn) { }

	// RVA: 0x420170 Offset: 0x41F370 VA: 0x180420170
	public Result CopyActiveSessionHandle(ref CopyActiveSessionHandleOptions options, out ActiveSession outSessionHandle) { }

	// RVA: 0x420280 Offset: 0x41F480 VA: 0x180420280
	public Result CopySessionHandleByInviteId(ref CopySessionHandleByInviteIdOptions options, out SessionDetails outSessionHandle) { }

	// RVA: 0x420390 Offset: 0x41F590 VA: 0x180420390
	public Result CopySessionHandleByUiEventId(ref CopySessionHandleByUiEventIdOptions options, out SessionDetails outSessionHandle) { }

	// RVA: 0x420460 Offset: 0x41F660 VA: 0x180420460
	public Result CopySessionHandleForPresence(ref CopySessionHandleForPresenceOptions options, out SessionDetails outSessionHandle) { }

	// RVA: 0x420570 Offset: 0x41F770 VA: 0x180420570
	public Result CreateSessionModification(ref CreateSessionModificationOptions options, out SessionModification outSessionModificationHandle) { }

	// RVA: 0x420660 Offset: 0x41F860 VA: 0x180420660
	public Result CreateSessionSearch(ref CreateSessionSearchOptions options, out SessionSearch outSessionSearchHandle) { }

	// RVA: 0x420730 Offset: 0x41F930 VA: 0x180420730
	public void DestroySession(ref DestroySessionOptions options, object clientData, OnDestroySessionCallback completionDelegate) { }

	// RVA: 0x420920 Offset: 0x41FB20 VA: 0x180420920
	public Result DumpSessionState(ref DumpSessionStateOptions options) { }

	// RVA: 0x420A00 Offset: 0x41FC00 VA: 0x180420A00
	public void EndSession(ref EndSessionOptions options, object clientData, OnEndSessionCallback completionDelegate) { }

	// RVA: 0x420BF0 Offset: 0x41FDF0 VA: 0x180420BF0
	public uint GetInviteCount(ref GetInviteCountOptions options) { }

	// RVA: 0x420CD0 Offset: 0x41FED0 VA: 0x180420CD0
	public Result GetInviteIdByIndex(ref GetInviteIdByIndexOptions options, out Utf8String outBuffer) { }

	// RVA: 0x420E00 Offset: 0x420000 VA: 0x180420E00
	public Result IsUserInSession(ref IsUserInSessionOptions options) { }

	// RVA: 0x420EA0 Offset: 0x4200A0 VA: 0x180420EA0
	public void JoinSession(ref JoinSessionOptions options, object clientData, OnJoinSessionCallback completionDelegate) { }

	// RVA: 0x421B00 Offset: 0x420D00 VA: 0x180421B00
	public void QueryInvites(ref QueryInvitesOptions options, object clientData, OnQueryInvitesCallback completionDelegate) { }

	// RVA: 0x421CF0 Offset: 0x420EF0 VA: 0x180421CF0
	public void RegisterPlayers(ref RegisterPlayersOptions options, object clientData, OnRegisterPlayersCallback completionDelegate) { }

	// RVA: 0x421EA0 Offset: 0x4210A0 VA: 0x180421EA0
	public void RejectInvite(ref RejectInviteOptions options, object clientData, OnRejectInviteCallback completionDelegate) { }

	// RVA: 0x422050 Offset: 0x421250 VA: 0x180422050
	public void RemoveNotifyJoinSessionAccepted(ulong inId) { }

	// RVA: 0x4220C0 Offset: 0x4212C0 VA: 0x1804220C0
	public void RemoveNotifyLeaveSessionRequested(ulong inId) { }

	// RVA: 0x422130 Offset: 0x421330 VA: 0x180422130
	public void RemoveNotifySendSessionNativeInviteRequested(ulong inId) { }

	// RVA: 0x4221A0 Offset: 0x4213A0 VA: 0x1804221A0
	public void RemoveNotifySessionInviteAccepted(ulong inId) { }

	// RVA: 0x422210 Offset: 0x421410 VA: 0x180422210
	public void RemoveNotifySessionInviteReceived(ulong inId) { }

	// RVA: 0x422280 Offset: 0x421480 VA: 0x180422280
	public void RemoveNotifySessionInviteRejected(ulong inId) { }

	// RVA: 0x4222F0 Offset: 0x4214F0 VA: 0x1804222F0
	public void SendInvite(ref SendInviteOptions options, object clientData, OnSendInviteCallback completionDelegate) { }

	// RVA: 0x4224A0 Offset: 0x4216A0 VA: 0x1804224A0
	public void StartSession(ref StartSessionOptions options, object clientData, OnStartSessionCallback completionDelegate) { }

	// RVA: 0x422650 Offset: 0x421850 VA: 0x180422650
	public void UnregisterPlayers(ref UnregisterPlayersOptions options, object clientData, OnUnregisterPlayersCallback completionDelegate) { }

	// RVA: 0x4228E0 Offset: 0x421AE0 VA: 0x1804228E0
	public void UpdateSession(ref UpdateSessionOptions options, object clientData, OnUpdateSessionCallback completionDelegate) { }

	// RVA: 0x422800 Offset: 0x421A00 VA: 0x180422800
	public Result UpdateSessionModification(ref UpdateSessionModificationOptions options, out SessionModification outSessionModificationHandle) { }

	[MonoPInvokeCallback(typeof(OnDestroySessionCallbackInternal))]
	// RVA: 0x421060 Offset: 0x420260 VA: 0x180421060
	internal static void OnDestroySessionCallbackInternalImplementation(ref DestroySessionCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnEndSessionCallbackInternal))]
	// RVA: 0x421100 Offset: 0x420300 VA: 0x180421100
	internal static void OnEndSessionCallbackInternalImplementation(ref EndSessionCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnJoinSessionAcceptedCallbackInternal))]
	// RVA: 0x4211A0 Offset: 0x4203A0 VA: 0x1804211A0
	internal static void OnJoinSessionAcceptedCallbackInternalImplementation(ref JoinSessionAcceptedCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnJoinSessionCallbackInternal))]
	// RVA: 0x421250 Offset: 0x420450 VA: 0x180421250
	internal static void OnJoinSessionCallbackInternalImplementation(ref JoinSessionCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnLeaveSessionRequestedCallbackInternal))]
	// RVA: 0x4212F0 Offset: 0x4204F0 VA: 0x1804212F0
	internal static void OnLeaveSessionRequestedCallbackInternalImplementation(ref LeaveSessionRequestedCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnQueryInvitesCallbackInternal))]
	// RVA: 0x4213A0 Offset: 0x4205A0 VA: 0x1804213A0
	internal static void OnQueryInvitesCallbackInternalImplementation(ref QueryInvitesCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnRegisterPlayersCallbackInternal))]
	// RVA: 0x421450 Offset: 0x420650 VA: 0x180421450
	internal static void OnRegisterPlayersCallbackInternalImplementation(ref RegisterPlayersCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnRejectInviteCallbackInternal))]
	// RVA: 0x421500 Offset: 0x420700 VA: 0x180421500
	internal static void OnRejectInviteCallbackInternalImplementation(ref RejectInviteCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnSendInviteCallbackInternal))]
	// RVA: 0x4215A0 Offset: 0x4207A0 VA: 0x1804215A0
	internal static void OnSendInviteCallbackInternalImplementation(ref SendInviteCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnSendSessionNativeInviteRequestedCallbackInternal))]
	// RVA: 0x421640 Offset: 0x420840 VA: 0x180421640
	internal static void OnSendSessionNativeInviteRequestedCallbackInternalImplementation(ref SendSessionNativeInviteRequestedCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnSessionInviteAcceptedCallbackInternal))]
	// RVA: 0x4216F0 Offset: 0x4208F0 VA: 0x1804216F0
	internal static void OnSessionInviteAcceptedCallbackInternalImplementation(ref SessionInviteAcceptedCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnSessionInviteReceivedCallbackInternal))]
	// RVA: 0x4217A0 Offset: 0x4209A0 VA: 0x1804217A0
	internal static void OnSessionInviteReceivedCallbackInternalImplementation(ref SessionInviteReceivedCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnSessionInviteRejectedCallbackInternal))]
	// RVA: 0x421850 Offset: 0x420A50 VA: 0x180421850
	internal static void OnSessionInviteRejectedCallbackInternalImplementation(ref SessionInviteRejectedCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnStartSessionCallbackInternal))]
	// RVA: 0x421900 Offset: 0x420B00 VA: 0x180421900
	internal static void OnStartSessionCallbackInternalImplementation(ref StartSessionCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnUnregisterPlayersCallbackInternal))]
	// RVA: 0x4219A0 Offset: 0x420BA0 VA: 0x1804219A0
	internal static void OnUnregisterPlayersCallbackInternalImplementation(ref UnregisterPlayersCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnUpdateSessionCallbackInternal))]
	// RVA: 0x421A50 Offset: 0x420C50 VA: 0x180421A50
	internal static void OnUpdateSessionCallbackInternalImplementation(ref UpdateSessionCallbackInfoInternal data) { }

	// RVA: 0x422A90 Offset: 0x421C90 VA: 0x180422A90
	private static void .cctor() { }
}

// Namespace: Epic.OnlineServices.Sessions
public struct StartSessionCallbackInfo : ICallbackInfo // TypeDefIndex: 8428
{
	// Fields
	[CompilerGenerated]
	private Result <ResultCode>k__BackingField; // 0x0
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x8

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	[CompilerGenerated]
	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public object get_ClientData() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_ClientData(object value) { }

	// RVA: 0x483A00 Offset: 0x482C00 VA: 0x180483A00 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x483A50 Offset: 0x482C50 VA: 0x180483A50
	internal void Set(ref StartSessionCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.Sessions
internal struct StartSessionCallbackInfoInternal : ICallbackInfoInternal, IGettable<StartSessionCallbackInfo>, ISettable<StartSessionCallbackInfo>, IDisposable // TypeDefIndex: 8429
{
	// Fields
	private Result m_ResultCode; // 0x0
	private IntPtr m_ClientData; // 0x8

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }

	// Methods

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	// RVA: 0x483930 Offset: 0x482B30 VA: 0x180483930
	public object get_ClientData() { }

	// RVA: 0x4839A0 Offset: 0x482BA0 VA: 0x1804839A0
	public void set_ClientData(object value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x4838D0 Offset: 0x482AD0 VA: 0x1804838D0 Slot: 6
	public void Set(ref StartSessionCallbackInfo other) { }

	// RVA: 0x483810 Offset: 0x482A10 VA: 0x180483810 Slot: 7
	public void Set(ref Nullable<StartSessionCallbackInfo> other) { }

	// RVA: 0x4837A0 Offset: 0x4829A0 VA: 0x1804837A0 Slot: 8
	public void Dispose() { }

	// RVA: 0x4837F0 Offset: 0x4829F0 VA: 0x1804837F0 Slot: 5
	public void Get(out StartSessionCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.Sessions
public struct StartSessionOptions // TypeDefIndex: 8430
{
	// Fields
	[CompilerGenerated]
	private Utf8String <SessionName>k__BackingField; // 0x0

	// Properties
	public Utf8String SessionName { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Utf8String get_SessionName() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_SessionName(Utf8String value) { }
}

// Namespace: Epic.OnlineServices.Sessions
internal struct StartSessionOptionsInternal : ISettable<StartSessionOptions>, IDisposable // TypeDefIndex: 8431
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_SessionName; // 0x8

	// Properties
	public Utf8String SessionName { set; }

	// Methods

	// RVA: 0x483C20 Offset: 0x482E20 VA: 0x180483C20
	public void set_SessionName(Utf8String value) { }

	// RVA: 0x483BC0 Offset: 0x482DC0 VA: 0x180483BC0 Slot: 4
	public void Set(ref StartSessionOptions other) { }

	// RVA: 0x483B20 Offset: 0x482D20 VA: 0x180483B20 Slot: 5
	public void Set(ref Nullable<StartSessionOptions> other) { }

	// RVA: 0x483AD0 Offset: 0x482CD0 VA: 0x180483AD0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Sessions
public struct UnregisterPlayersCallbackInfo : ICallbackInfo // TypeDefIndex: 8432
{
	// Fields
	[CompilerGenerated]
	private Result <ResultCode>k__BackingField; // 0x0
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x8
	[CompilerGenerated]
	private ProductUserId[] <UnregisteredPlayers>k__BackingField; // 0x10

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public ProductUserId[] UnregisteredPlayers { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	[CompilerGenerated]
	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public object get_ClientData() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_ClientData(object value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public ProductUserId[] get_UnregisteredPlayers() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_UnregisteredPlayers(ProductUserId[] value) { }

	// RVA: 0x4843E0 Offset: 0x4835E0 VA: 0x1804843E0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x484430 Offset: 0x483630 VA: 0x180484430
	internal void Set(ref UnregisterPlayersCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.Sessions
internal struct UnregisterPlayersCallbackInfoInternal : ICallbackInfoInternal, IGettable<UnregisterPlayersCallbackInfo>, ISettable<UnregisterPlayersCallbackInfo>, IDisposable // TypeDefIndex: 8433
{
	// Fields
	private Result m_ResultCode; // 0x0
	private IntPtr m_ClientData; // 0x8
	private IntPtr m_UnregisteredPlayers; // 0x10
	private uint m_UnregisteredPlayersCount; // 0x18

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public ProductUserId[] UnregisteredPlayers { get; set; }

	// Methods

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	// RVA: 0x484210 Offset: 0x483410 VA: 0x180484210
	public object get_ClientData() { }

	// RVA: 0x484310 Offset: 0x483510 VA: 0x180484310
	public void set_ClientData(object value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x484280 Offset: 0x483480 VA: 0x180484280
	public ProductUserId[] get_UnregisteredPlayers() { }

	// RVA: 0x484370 Offset: 0x483570 VA: 0x180484370
	public void set_UnregisteredPlayers(ProductUserId[] value) { }

	// RVA: 0x484060 Offset: 0x483260 VA: 0x180484060 Slot: 6
	public void Set(ref UnregisterPlayersCallbackInfo other) { }

	// RVA: 0x484130 Offset: 0x483330 VA: 0x180484130 Slot: 7
	public void Set(ref Nullable<UnregisterPlayersCallbackInfo> other) { }

	// RVA: 0x483FE0 Offset: 0x4831E0 VA: 0x180483FE0 Slot: 8
	public void Dispose() { }

	// RVA: 0x484040 Offset: 0x483240 VA: 0x180484040 Slot: 5
	public void Get(out UnregisterPlayersCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.Sessions
public struct UnregisterPlayersOptions // TypeDefIndex: 8434
{
	// Fields
	[CompilerGenerated]
	private Utf8String <SessionName>k__BackingField; // 0x0
	[CompilerGenerated]
	private ProductUserId[] <PlayersToUnregister>k__BackingField; // 0x8

	// Properties
	public Utf8String SessionName { get; set; }
	public ProductUserId[] PlayersToUnregister { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Utf8String get_SessionName() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_SessionName(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public ProductUserId[] get_PlayersToUnregister() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_PlayersToUnregister(ProductUserId[] value) { }
}

// Namespace: Epic.OnlineServices.Sessions
internal struct UnregisterPlayersOptionsInternal : ISettable<UnregisterPlayersOptions>, IDisposable // TypeDefIndex: 8435
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_SessionName; // 0x8
	private IntPtr m_PlayersToUnregister; // 0x10
	private uint m_PlayersToUnregisterCount; // 0x18

	// Properties
	public Utf8String SessionName { set; }
	public ProductUserId[] PlayersToUnregister { set; }

	// Methods

	// RVA: 0x484730 Offset: 0x483930 VA: 0x180484730
	public void set_SessionName(Utf8String value) { }

	// RVA: 0x4846C0 Offset: 0x4838C0 VA: 0x1804846C0
	public void set_PlayersToUnregister(ProductUserId[] value) { }

	// RVA: 0x484520 Offset: 0x483720 VA: 0x180484520 Slot: 4
	public void Set(ref UnregisterPlayersOptions other) { }

	// RVA: 0x4845F0 Offset: 0x4837F0 VA: 0x1804845F0 Slot: 5
	public void Set(ref Nullable<UnregisterPlayersOptions> other) { }

	// RVA: 0x4844C0 Offset: 0x4836C0 VA: 0x1804844C0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Sessions
public struct UpdateSessionCallbackInfo : ICallbackInfo // TypeDefIndex: 8436
{
	// Fields
	[CompilerGenerated]
	private Result <ResultCode>k__BackingField; // 0x0
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x8
	[CompilerGenerated]
	private Utf8String <SessionName>k__BackingField; // 0x10
	[CompilerGenerated]
	private Utf8String <SessionId>k__BackingField; // 0x18

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public Utf8String SessionName { get; set; }
	public Utf8String SessionId { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	[CompilerGenerated]
	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public object get_ClientData() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_ClientData(object value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Utf8String get_SessionName() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_SessionName(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public Utf8String get_SessionId() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_SessionId(Utf8String value) { }

	// RVA: 0x4897C0 Offset: 0x4889C0 VA: 0x1804897C0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x489810 Offset: 0x488A10 VA: 0x180489810
	internal void Set(ref UpdateSessionCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.Sessions
internal struct UpdateSessionCallbackInfoInternal : ICallbackInfoInternal, IGettable<UpdateSessionCallbackInfo>, ISettable<UpdateSessionCallbackInfo>, IDisposable // TypeDefIndex: 8437
{
	// Fields
	private Result m_ResultCode; // 0x0
	private IntPtr m_ClientData; // 0x8
	private IntPtr m_SessionName; // 0x10
	private IntPtr m_SessionId; // 0x18

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public Utf8String SessionName { get; set; }
	public Utf8String SessionId { get; set; }

	// Methods

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	// RVA: 0x489550 Offset: 0x488750 VA: 0x180489550
	public object get_ClientData() { }

	// RVA: 0x4896A0 Offset: 0x4888A0 VA: 0x1804896A0
	public void set_ClientData(object value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x489630 Offset: 0x488830 VA: 0x180489630
	public Utf8String get_SessionName() { }

	// RVA: 0x489760 Offset: 0x488960 VA: 0x180489760
	public void set_SessionName(Utf8String value) { }

	// RVA: 0x4895C0 Offset: 0x4887C0 VA: 0x1804895C0
	public Utf8String get_SessionId() { }

	// RVA: 0x489700 Offset: 0x488900 VA: 0x180489700
	public void set_SessionId(Utf8String value) { }

	// RVA: 0x4892E0 Offset: 0x4884E0 VA: 0x1804892E0 Slot: 6
	public void Set(ref UpdateSessionCallbackInfo other) { }

	// RVA: 0x4893E0 Offset: 0x4885E0 VA: 0x1804893E0 Slot: 7
	public void Set(ref Nullable<UpdateSessionCallbackInfo> other) { }

	// RVA: 0x489260 Offset: 0x488460 VA: 0x180489260 Slot: 8
	public void Dispose() { }

	// RVA: 0x4892C0 Offset: 0x4884C0 VA: 0x1804892C0 Slot: 5
	public void Get(out UpdateSessionCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.Sessions
public struct UpdateSessionModificationOptions // TypeDefIndex: 8438
{
	// Fields
	[CompilerGenerated]
	private Utf8String <SessionName>k__BackingField; // 0x0

	// Properties
	public Utf8String SessionName { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Utf8String get_SessionName() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_SessionName(Utf8String value) { }
}

// Namespace: Epic.OnlineServices.Sessions
internal struct UpdateSessionModificationOptionsInternal : ISettable<UpdateSessionModificationOptions>, IDisposable // TypeDefIndex: 8439
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_SessionName; // 0x8

	// Properties
	public Utf8String SessionName { set; }

	// Methods

	// RVA: 0x489A90 Offset: 0x488C90 VA: 0x180489A90
	public void set_SessionName(Utf8String value) { }

	// RVA: 0x489A30 Offset: 0x488C30 VA: 0x180489A30 Slot: 4
	public void Set(ref UpdateSessionModificationOptions other) { }

	// RVA: 0x489990 Offset: 0x488B90 VA: 0x180489990 Slot: 5
	public void Set(ref Nullable<UpdateSessionModificationOptions> other) { }

	// RVA: 0x489940 Offset: 0x488B40 VA: 0x180489940 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Sessions
public struct UpdateSessionOptions // TypeDefIndex: 8440
{
	// Fields
	[CompilerGenerated]
	private SessionModification <SessionModificationHandle>k__BackingField; // 0x0

	// Properties
	public SessionModification SessionModificationHandle { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public SessionModification get_SessionModificationHandle() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_SessionModificationHandle(SessionModification value) { }
}

// Namespace: Epic.OnlineServices.Sessions
internal struct UpdateSessionOptionsInternal : ISettable<UpdateSessionOptions>, IDisposable // TypeDefIndex: 8441
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_SessionModificationHandle; // 0x8

	// Properties
	public SessionModification SessionModificationHandle { set; }

	// Methods

	// RVA: 0x489C40 Offset: 0x488E40 VA: 0x180489C40
	public void set_SessionModificationHandle(SessionModification value) { }

	// RVA: 0x489B40 Offset: 0x488D40 VA: 0x180489B40 Slot: 4
	public void Set(ref UpdateSessionOptions other) { }

	// RVA: 0x489BA0 Offset: 0x488DA0 VA: 0x180489BA0 Slot: 5
	public void Set(ref Nullable<UpdateSessionOptions> other) { }

	// RVA: 0x489AF0 Offset: 0x488CF0 VA: 0x180489AF0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Sanctions
public struct CopyPlayerSanctionByIndexOptions // TypeDefIndex: 8442
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <TargetUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private uint <SanctionIndex>k__BackingField; // 0x8

	// Properties
	public ProductUserId TargetUserId { get; set; }
	public uint SanctionIndex { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public ProductUserId get_TargetUserId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_TargetUserId(ProductUserId value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3F5510 Offset: 0x3F4710 VA: 0x1803F5510
	public uint get_SanctionIndex() { }

	[CompilerGenerated]
	// RVA: 0x3F5520 Offset: 0x3F4720 VA: 0x1803F5520
	public void set_SanctionIndex(uint value) { }
}

// Namespace: Epic.OnlineServices.Sanctions
internal struct CopyPlayerSanctionByIndexOptionsInternal : ISettable<CopyPlayerSanctionByIndexOptions>, IDisposable // TypeDefIndex: 8443
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_TargetUserId; // 0x8
	private uint m_SanctionIndex; // 0x10

	// Properties
	public ProductUserId TargetUserId { set; }
	public uint SanctionIndex { set; }

	// Methods

	// RVA: 0x475E00 Offset: 0x475000 VA: 0x180475E00
	public void set_TargetUserId(ProductUserId value) { }

	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_SanctionIndex(uint value) { }

	// RVA: 0x475CC0 Offset: 0x474EC0 VA: 0x180475CC0 Slot: 4
	public void Set(ref CopyPlayerSanctionByIndexOptions other) { }

	// RVA: 0x475D40 Offset: 0x474F40 VA: 0x180475D40 Slot: 5
	public void Set(ref Nullable<CopyPlayerSanctionByIndexOptions> other) { }

	// RVA: 0x475C70 Offset: 0x474E70 VA: 0x180475C70 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Sanctions
public sealed class CreatePlayerSanctionAppealCallback : MulticastDelegate // TypeDefIndex: 8444
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref CreatePlayerSanctionAppealCallbackInfo data) { }

	// RVA: 0x476410 Offset: 0x475610 VA: 0x180476410 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref CreatePlayerSanctionAppealCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref CreatePlayerSanctionAppealCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Sanctions
[UnmanagedFunctionPointer(2)]
internal sealed class CreatePlayerSanctionAppealCallbackInternal : MulticastDelegate // TypeDefIndex: 8445
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref CreatePlayerSanctionAppealCallbackInfoInternal data) { }

	// RVA: 0x476380 Offset: 0x475580 VA: 0x180476380 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref CreatePlayerSanctionAppealCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref CreatePlayerSanctionAppealCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Sanctions
public struct CreatePlayerSanctionAppealCallbackInfo : ICallbackInfo // TypeDefIndex: 8446
{
	// Fields
	[CompilerGenerated]
	private Result <ResultCode>k__BackingField; // 0x0
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x8
	[CompilerGenerated]
	private Utf8String <ReferenceId>k__BackingField; // 0x10

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public Utf8String ReferenceId { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	[CompilerGenerated]
	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public object get_ClientData() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_ClientData(object value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Utf8String get_ReferenceId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_ReferenceId(Utf8String value) { }

	// RVA: 0x476250 Offset: 0x475450 VA: 0x180476250 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x4762A0 Offset: 0x4754A0 VA: 0x1804762A0
	internal void Set(ref CreatePlayerSanctionAppealCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.Sanctions
internal struct CreatePlayerSanctionAppealCallbackInfoInternal : ICallbackInfoInternal, IGettable<CreatePlayerSanctionAppealCallbackInfo>, ISettable<CreatePlayerSanctionAppealCallbackInfo>, IDisposable // TypeDefIndex: 8447
{
	// Fields
	private Result m_ResultCode; // 0x0
	private IntPtr m_ClientData; // 0x8
	private IntPtr m_ReferenceId; // 0x10

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public Utf8String ReferenceId { get; set; }

	// Methods

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	// RVA: 0x4760B0 Offset: 0x4752B0 VA: 0x1804760B0
	public object get_ClientData() { }

	// RVA: 0x476190 Offset: 0x475390 VA: 0x180476190
	public void set_ClientData(object value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x476120 Offset: 0x475320 VA: 0x180476120
	public Utf8String get_ReferenceId() { }

	// RVA: 0x4761F0 Offset: 0x4753F0 VA: 0x1804761F0
	public void set_ReferenceId(Utf8String value) { }

	// RVA: 0x476000 Offset: 0x475200 VA: 0x180476000 Slot: 6
	public void Set(ref CreatePlayerSanctionAppealCallbackInfo other) { }

	// RVA: 0x475EE0 Offset: 0x4750E0 VA: 0x180475EE0 Slot: 7
	public void Set(ref Nullable<CreatePlayerSanctionAppealCallbackInfo> other) { }

	// RVA: 0x475E60 Offset: 0x475060 VA: 0x180475E60 Slot: 8
	public void Dispose() { }

	// RVA: 0x475EC0 Offset: 0x4750C0 VA: 0x180475EC0 Slot: 5
	public void Get(out CreatePlayerSanctionAppealCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.Sanctions
public struct CreatePlayerSanctionAppealOptions // TypeDefIndex: 8448
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private SanctionAppealReason <Reason>k__BackingField; // 0x8
	[CompilerGenerated]
	private Utf8String <ReferenceId>k__BackingField; // 0x10

	// Properties
	public ProductUserId LocalUserId { get; set; }
	public SanctionAppealReason Reason { get; set; }
	public Utf8String ReferenceId { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_LocalUserId(ProductUserId value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3F5510 Offset: 0x3F4710 VA: 0x1803F5510
	public SanctionAppealReason get_Reason() { }

	[CompilerGenerated]
	// RVA: 0x3F5520 Offset: 0x3F4720 VA: 0x1803F5520
	public void set_Reason(SanctionAppealReason value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Utf8String get_ReferenceId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_ReferenceId(Utf8String value) { }
}

// Namespace: Epic.OnlineServices.Sanctions
internal struct CreatePlayerSanctionAppealOptionsInternal : ISettable<CreatePlayerSanctionAppealOptions>, IDisposable // TypeDefIndex: 8449
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private SanctionAppealReason m_Reason; // 0x10
	private IntPtr m_ReferenceId; // 0x18

	// Properties
	public ProductUserId LocalUserId { set; }
	public SanctionAppealReason Reason { set; }
	public Utf8String ReferenceId { set; }

	// Methods

	// RVA: 0x4766E0 Offset: 0x4758E0 VA: 0x1804766E0
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_Reason(SanctionAppealReason value) { }

	// RVA: 0x476740 Offset: 0x475940 VA: 0x180476740
	public void set_ReferenceId(Utf8String value) { }

	// RVA: 0x476620 Offset: 0x475820 VA: 0x180476620 Slot: 4
	public void Set(ref CreatePlayerSanctionAppealOptions other) { }

	// RVA: 0x476500 Offset: 0x475700 VA: 0x180476500 Slot: 5
	public void Set(ref Nullable<CreatePlayerSanctionAppealOptions> other) { }

	// RVA: 0x4764A0 Offset: 0x4756A0 VA: 0x1804764A0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Sanctions
public struct GetPlayerSanctionCountOptions // TypeDefIndex: 8450
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <TargetUserId>k__BackingField; // 0x0

	// Properties
	public ProductUserId TargetUserId { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public ProductUserId get_TargetUserId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_TargetUserId(ProductUserId value) { }
}

// Namespace: Epic.OnlineServices.Sanctions
internal struct GetPlayerSanctionCountOptionsInternal : ISettable<GetPlayerSanctionCountOptions>, IDisposable // TypeDefIndex: 8451
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_TargetUserId; // 0x8

	// Properties
	public ProductUserId TargetUserId { set; }

	// Methods

	// RVA: 0x4774D0 Offset: 0x4766D0 VA: 0x1804774D0
	public void set_TargetUserId(ProductUserId value) { }

	// RVA: 0x4773D0 Offset: 0x4765D0 VA: 0x1804773D0 Slot: 4
	public void Set(ref GetPlayerSanctionCountOptions other) { }

	// RVA: 0x477430 Offset: 0x476630 VA: 0x180477430 Slot: 5
	public void Set(ref Nullable<GetPlayerSanctionCountOptions> other) { }

	// RVA: 0x477380 Offset: 0x476580 VA: 0x180477380 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Sanctions
public sealed class OnQueryActivePlayerSanctionsCallback : MulticastDelegate // TypeDefIndex: 8452
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref QueryActivePlayerSanctionsCallbackInfo data) { }

	// RVA: 0x478530 Offset: 0x477730 VA: 0x180478530 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref QueryActivePlayerSanctionsCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref QueryActivePlayerSanctionsCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Sanctions
[UnmanagedFunctionPointer(2)]
internal sealed class OnQueryActivePlayerSanctionsCallbackInternal : MulticastDelegate // TypeDefIndex: 8453
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref QueryActivePlayerSanctionsCallbackInfoInternal data) { }

	// RVA: 0x4784A0 Offset: 0x4776A0 VA: 0x1804784A0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref QueryActivePlayerSanctionsCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref QueryActivePlayerSanctionsCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Sanctions
public struct PlayerSanction // TypeDefIndex: 8454
{
	// Fields
	[CompilerGenerated]
	private long <TimePlaced>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <Action>k__BackingField; // 0x8
	[CompilerGenerated]
	private long <TimeExpires>k__BackingField; // 0x10
	[CompilerGenerated]
	private Utf8String <ReferenceId>k__BackingField; // 0x18

	// Properties
	public long TimePlaced { get; set; }
	public Utf8String Action { get; set; }
	public long TimeExpires { get; set; }
	public Utf8String ReferenceId { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public long get_TimePlaced() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_TimePlaced(long value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public Utf8String get_Action() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_Action(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public long get_TimeExpires() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_TimeExpires(long value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public Utf8String get_ReferenceId() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_ReferenceId(Utf8String value) { }

	// RVA: 0x47CBB0 Offset: 0x47BDB0 VA: 0x18047CBB0
	internal void Set(ref PlayerSanctionInternal other) { }
}

// Namespace: Epic.OnlineServices.Sanctions
internal struct PlayerSanctionInternal : IGettable<PlayerSanction>, ISettable<PlayerSanction>, IDisposable // TypeDefIndex: 8455
{
	// Fields
	private int m_ApiVersion; // 0x0
	private long m_TimePlaced; // 0x8
	private IntPtr m_Action; // 0x10
	private long m_TimeExpires; // 0x18
	private IntPtr m_ReferenceId; // 0x20

	// Properties
	public long TimePlaced { get; set; }
	public Utf8String Action { get; set; }
	public long TimeExpires { get; set; }
	public Utf8String ReferenceId { get; set; }

	// Methods

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public long get_TimePlaced() { }

	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_TimePlaced(long value) { }

	// RVA: 0x47CA10 Offset: 0x47BC10 VA: 0x18047CA10
	public Utf8String get_Action() { }

	// RVA: 0x47CAF0 Offset: 0x47BCF0 VA: 0x18047CAF0
	public void set_Action(Utf8String value) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public long get_TimeExpires() { }

	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_TimeExpires(long value) { }

	// RVA: 0x47CA80 Offset: 0x47BC80 VA: 0x18047CA80
	public Utf8String get_ReferenceId() { }

	// RVA: 0x47CB50 Offset: 0x47BD50 VA: 0x18047CB50
	public void set_ReferenceId(Utf8String value) { }

	// RVA: 0x47C800 Offset: 0x47BA00 VA: 0x18047C800 Slot: 5
	public void Set(ref PlayerSanction other) { }

	// RVA: 0x47C8D0 Offset: 0x47BAD0 VA: 0x18047C8D0 Slot: 6
	public void Set(ref Nullable<PlayerSanction> other) { }

	// RVA: 0x47C780 Offset: 0x47B980 VA: 0x18047C780 Slot: 7
	public void Dispose() { }

	// RVA: 0x47C7E0 Offset: 0x47B9E0 VA: 0x18047C7E0 Slot: 4
	public void Get(out PlayerSanction output) { }
}

// Namespace: Epic.OnlineServices.Sanctions
public struct QueryActivePlayerSanctionsCallbackInfo : ICallbackInfo // TypeDefIndex: 8456
{
	// Fields
	[CompilerGenerated]
	private Result <ResultCode>k__BackingField; // 0x0
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x8
	[CompilerGenerated]
	private ProductUserId <TargetUserId>k__BackingField; // 0x10
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x18

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public ProductUserId TargetUserId { get; set; }
	public ProductUserId LocalUserId { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	[CompilerGenerated]
	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public object get_ClientData() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_ClientData(object value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public ProductUserId get_TargetUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_TargetUserId(ProductUserId value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x47D220 Offset: 0x47C420 VA: 0x18047D220 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x47D270 Offset: 0x47C470 VA: 0x18047D270
	internal void Set(ref QueryActivePlayerSanctionsCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.Sanctions
internal struct QueryActivePlayerSanctionsCallbackInfoInternal : ICallbackInfoInternal, IGettable<QueryActivePlayerSanctionsCallbackInfo>, ISettable<QueryActivePlayerSanctionsCallbackInfo>, IDisposable // TypeDefIndex: 8457
{
	// Fields
	private Result m_ResultCode; // 0x0
	private IntPtr m_ClientData; // 0x8
	private IntPtr m_TargetUserId; // 0x10
	private IntPtr m_LocalUserId; // 0x18

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public ProductUserId TargetUserId { get; set; }
	public ProductUserId LocalUserId { get; set; }

	// Methods

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	// RVA: 0x47CF90 Offset: 0x47C190 VA: 0x18047CF90
	public object get_ClientData() { }

	// RVA: 0x47D100 Offset: 0x47C300 VA: 0x18047D100
	public void set_ClientData(object value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x47D080 Offset: 0x47C280 VA: 0x18047D080
	public ProductUserId get_TargetUserId() { }

	// RVA: 0x47D1C0 Offset: 0x47C3C0 VA: 0x18047D1C0
	public void set_TargetUserId(ProductUserId value) { }

	// RVA: 0x47D000 Offset: 0x47C200 VA: 0x18047D000
	public ProductUserId get_LocalUserId() { }

	// RVA: 0x47D160 Offset: 0x47C360 VA: 0x18047D160
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x47CE90 Offset: 0x47C090 VA: 0x18047CE90 Slot: 6
	public void Set(ref QueryActivePlayerSanctionsCallbackInfo other) { }

	// RVA: 0x47CD20 Offset: 0x47BF20 VA: 0x18047CD20 Slot: 7
	public void Set(ref Nullable<QueryActivePlayerSanctionsCallbackInfo> other) { }

	// RVA: 0x47CCA0 Offset: 0x47BEA0 VA: 0x18047CCA0 Slot: 8
	public void Dispose() { }

	// RVA: 0x47CD00 Offset: 0x47BF00 VA: 0x18047CD00 Slot: 5
	public void Get(out QueryActivePlayerSanctionsCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.Sanctions
public struct QueryActivePlayerSanctionsOptions // TypeDefIndex: 8458
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <TargetUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x8

	// Properties
	public ProductUserId TargetUserId { get; set; }
	public ProductUserId LocalUserId { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public ProductUserId get_TargetUserId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_TargetUserId(ProductUserId value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_LocalUserId(ProductUserId value) { }
}

// Namespace: Epic.OnlineServices.Sanctions
internal struct QueryActivePlayerSanctionsOptionsInternal : ISettable<QueryActivePlayerSanctionsOptions>, IDisposable // TypeDefIndex: 8459
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_TargetUserId; // 0x8
	private IntPtr m_LocalUserId; // 0x10

	// Properties
	public ProductUserId TargetUserId { set; }
	public ProductUserId LocalUserId { set; }

	// Methods

	// RVA: 0x47D590 Offset: 0x47C790 VA: 0x18047D590
	public void set_TargetUserId(ProductUserId value) { }

	// RVA: 0x47D530 Offset: 0x47C730 VA: 0x18047D530
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x47D470 Offset: 0x47C670 VA: 0x18047D470 Slot: 4
	public void Set(ref QueryActivePlayerSanctionsOptions other) { }

	// RVA: 0x47D370 Offset: 0x47C570 VA: 0x18047D370 Slot: 5
	public void Set(ref Nullable<QueryActivePlayerSanctionsOptions> other) { }

	// RVA: 0x47D310 Offset: 0x47C510 VA: 0x18047D310 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Sanctions
public enum SanctionAppealReason // TypeDefIndex: 8460
{
	// Fields
	public int value__; // 0x0
	public const SanctionAppealReason Invalid = 0;
	public const SanctionAppealReason IncorrectSanction = 1;
	public const SanctionAppealReason CompromisedAccount = 2;
	public const SanctionAppealReason UnfairPunishment = 3;
	public const SanctionAppealReason AppealForForgiveness = 4;
}

// Namespace: Epic.OnlineServices.Sanctions
public sealed class SanctionsInterface : Handle // TypeDefIndex: 8461
{
	// Fields
	public const int CopyplayersanctionbyindexApiLatest = 1;
	public const int CreateplayersanctionappealApiLatest = 1;
	public const int GetplayersanctioncountApiLatest = 1;
	public const int PlayersanctionApiLatest = 2;
	public const int QueryactiveplayersanctionsApiLatest = 2;

	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }

	// RVA: 0x40BDB0 Offset: 0x40AFB0 VA: 0x18040BDB0
	public void .ctor(IntPtr innerHandle) { }

	// RVA: 0x481A60 Offset: 0x480C60 VA: 0x180481A60
	public Result CopyPlayerSanctionByIndex(ref CopyPlayerSanctionByIndexOptions options, out Nullable<PlayerSanction> outSanction) { }

	// RVA: 0x481C60 Offset: 0x480E60 VA: 0x180481C60
	public void CreatePlayerSanctionAppeal(ref CreatePlayerSanctionAppealOptions options, object clientData, CreatePlayerSanctionAppealCallback completionDelegate) { }

	// RVA: 0x481E10 Offset: 0x481010 VA: 0x180481E10
	public uint GetPlayerSanctionCount(ref GetPlayerSanctionCountOptions options) { }

	// RVA: 0x481FA0 Offset: 0x4811A0 VA: 0x180481FA0
	public void QueryActivePlayerSanctions(ref QueryActivePlayerSanctionsOptions options, object clientData, OnQueryActivePlayerSanctionsCallback completionDelegate) { }

	[MonoPInvokeCallback(typeof(CreatePlayerSanctionAppealCallbackInternal))]
	// RVA: 0x481BB0 Offset: 0x480DB0 VA: 0x180481BB0
	internal static void CreatePlayerSanctionAppealCallbackInternalImplementation(ref CreatePlayerSanctionAppealCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnQueryActivePlayerSanctionsCallbackInternal))]
	// RVA: 0x481EF0 Offset: 0x4810F0 VA: 0x180481EF0
	internal static void OnQueryActivePlayerSanctionsCallbackInternalImplementation(ref QueryActivePlayerSanctionsCallbackInfoInternal data) { }
}

// Namespace: Epic.OnlineServices.RTCData
public struct AddNotifyDataReceivedOptions // TypeDefIndex: 8462
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <RoomName>k__BackingField; // 0x8

	// Properties
	public ProductUserId LocalUserId { get; set; }
	public Utf8String RoomName { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_LocalUserId(ProductUserId value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public Utf8String get_RoomName() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_RoomName(Utf8String value) { }
}

// Namespace: Epic.OnlineServices.RTCData
internal struct AddNotifyDataReceivedOptionsInternal : ISettable<AddNotifyDataReceivedOptions>, IDisposable // TypeDefIndex: 8463
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_RoomName; // 0x10

	// Properties
	public ProductUserId LocalUserId { set; }
	public Utf8String RoomName { set; }

	// Methods

	// RVA: 0x472300 Offset: 0x471500 VA: 0x180472300
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x472360 Offset: 0x471560 VA: 0x180472360
	public void set_RoomName(Utf8String value) { }

	// RVA: 0x472140 Offset: 0x471340 VA: 0x180472140 Slot: 4
	public void Set(ref AddNotifyDataReceivedOptions other) { }

	// RVA: 0x472200 Offset: 0x471400 VA: 0x180472200 Slot: 5
	public void Set(ref Nullable<AddNotifyDataReceivedOptions> other) { }

	// RVA: 0x4720E0 Offset: 0x4712E0 VA: 0x1804720E0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.RTCData
public struct AddNotifyParticipantUpdatedOptions // TypeDefIndex: 8464
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <RoomName>k__BackingField; // 0x8

	// Properties
	public ProductUserId LocalUserId { get; set; }
	public Utf8String RoomName { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_LocalUserId(ProductUserId value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public Utf8String get_RoomName() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_RoomName(Utf8String value) { }
}

// Namespace: Epic.OnlineServices.RTCData
internal struct AddNotifyParticipantUpdatedOptionsInternal : ISettable<AddNotifyParticipantUpdatedOptions>, IDisposable // TypeDefIndex: 8465
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_RoomName; // 0x10

	// Properties
	public ProductUserId LocalUserId { set; }
	public Utf8String RoomName { set; }

	// Methods

	// RVA: 0x472800 Offset: 0x471A00 VA: 0x180472800
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x472920 Offset: 0x471B20 VA: 0x180472920
	public void set_RoomName(Utf8String value) { }

	// RVA: 0x472740 Offset: 0x471940 VA: 0x180472740 Slot: 4
	public void Set(ref AddNotifyParticipantUpdatedOptions other) { }

	// RVA: 0x472540 Offset: 0x471740 VA: 0x180472540 Slot: 5
	public void Set(ref Nullable<AddNotifyParticipantUpdatedOptions> other) { }

	// RVA: 0x4723C0 Offset: 0x4715C0 VA: 0x1804723C0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.RTCData
public struct DataReceivedCallbackInfo : ICallbackInfo // TypeDefIndex: 8466
{
	// Fields
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x0
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x8
	[CompilerGenerated]
	private Utf8String <RoomName>k__BackingField; // 0x10
	[CompilerGenerated]
	private ArraySegment<byte> <Data>k__BackingField; // 0x18
	[CompilerGenerated]
	private ProductUserId <ParticipantId>k__BackingField; // 0x28

	// Properties
	public object ClientData { get; set; }
	public ProductUserId LocalUserId { get; set; }
	public Utf8String RoomName { get; set; }
	public ArraySegment<byte> Data { get; set; }
	public ProductUserId ParticipantId { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410 Slot: 4
	public object get_ClientData() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_ClientData(object value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_LocalUserId(ProductUserId value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Utf8String get_RoomName() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_RoomName(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x42D820 Offset: 0x42CA20 VA: 0x18042D820
	public ArraySegment<byte> get_Data() { }

	[CompilerGenerated]
	// RVA: 0x42D8A0 Offset: 0x42CAA0 VA: 0x18042D8A0
	public void set_Data(ArraySegment<byte> value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public ProductUserId get_ParticipantId() { }

	[CompilerGenerated]
	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	public void set_ParticipantId(ProductUserId value) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x477030 Offset: 0x476230 VA: 0x180477030
	internal void Set(ref DataReceivedCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.RTCData
internal struct DataReceivedCallbackInfoInternal : ICallbackInfoInternal, IGettable<DataReceivedCallbackInfo>, ISettable<DataReceivedCallbackInfo>, IDisposable // TypeDefIndex: 8467
{
	// Fields
	private IntPtr m_ClientData; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_RoomName; // 0x10
	private uint m_DataLengthBytes; // 0x18
	private IntPtr m_Data; // 0x20
	private IntPtr m_ParticipantId; // 0x28

	// Properties
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public ProductUserId LocalUserId { get; set; }
	public Utf8String RoomName { get; set; }
	public ArraySegment<byte> Data { get; set; }
	public ProductUserId ParticipantId { get; set; }

	// Methods

	// RVA: 0x476BE0 Offset: 0x475DE0 VA: 0x180476BE0
	public object get_ClientData() { }

	// RVA: 0x476E40 Offset: 0x476040 VA: 0x180476E40
	public void set_ClientData(object value) { }

	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x476CD0 Offset: 0x475ED0 VA: 0x180476CD0
	public ProductUserId get_LocalUserId() { }

	// RVA: 0x476F10 Offset: 0x476110 VA: 0x180476F10
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x476DD0 Offset: 0x475FD0 VA: 0x180476DD0
	public Utf8String get_RoomName() { }

	// RVA: 0x476FD0 Offset: 0x4761D0 VA: 0x180476FD0
	public void set_RoomName(Utf8String value) { }

	// RVA: 0x476C50 Offset: 0x475E50 VA: 0x180476C50
	public ArraySegment<byte> get_Data() { }

	// RVA: 0x476EA0 Offset: 0x4760A0 VA: 0x180476EA0
	public void set_Data(ArraySegment<byte> value) { }

	// RVA: 0x476D50 Offset: 0x475F50 VA: 0x180476D50
	public ProductUserId get_ParticipantId() { }

	// RVA: 0x476F70 Offset: 0x476170 VA: 0x180476F70
	public void set_ParticipantId(ProductUserId value) { }

	// RVA: 0x476A50 Offset: 0x475C50 VA: 0x180476A50 Slot: 6
	public void Set(ref DataReceivedCallbackInfo other) { }

	// RVA: 0x476840 Offset: 0x475A40 VA: 0x180476840 Slot: 7
	public void Set(ref Nullable<DataReceivedCallbackInfo> other) { }

	// RVA: 0x4767A0 Offset: 0x4759A0 VA: 0x1804767A0 Slot: 8
	public void Dispose() { }

	// RVA: 0x476820 Offset: 0x475A20 VA: 0x180476820 Slot: 5
	public void Get(out DataReceivedCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.RTCData
public sealed class OnDataReceivedCallback : MulticastDelegate // TypeDefIndex: 8468
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref DataReceivedCallbackInfo data) { }

	// RVA: 0x4781D0 Offset: 0x4773D0 VA: 0x1804781D0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref DataReceivedCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref DataReceivedCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.RTCData
[UnmanagedFunctionPointer(2)]
internal sealed class OnDataReceivedCallbackInternal : MulticastDelegate // TypeDefIndex: 8469
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref DataReceivedCallbackInfoInternal data) { }

	// RVA: 0x478140 Offset: 0x477340 VA: 0x180478140 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref DataReceivedCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref DataReceivedCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.RTCData
public sealed class OnParticipantUpdatedCallback : MulticastDelegate // TypeDefIndex: 8470
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref ParticipantUpdatedCallbackInfo data) { }

	// RVA: 0x478380 Offset: 0x477580 VA: 0x180478380 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref ParticipantUpdatedCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref ParticipantUpdatedCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.RTCData
[UnmanagedFunctionPointer(2)]
internal sealed class OnParticipantUpdatedCallbackInternal : MulticastDelegate // TypeDefIndex: 8471
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref ParticipantUpdatedCallbackInfoInternal data) { }

	// RVA: 0x478260 Offset: 0x477460 VA: 0x180478260 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref ParticipantUpdatedCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref ParticipantUpdatedCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.RTCData
public sealed class OnUpdateReceivingCallback : MulticastDelegate // TypeDefIndex: 8472
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref UpdateReceivingCallbackInfo data) { }

	// RVA: 0x47AA30 Offset: 0x479C30 VA: 0x18047AA30 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref UpdateReceivingCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref UpdateReceivingCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.RTCData
[UnmanagedFunctionPointer(2)]
internal sealed class OnUpdateReceivingCallbackInternal : MulticastDelegate // TypeDefIndex: 8473
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref UpdateReceivingCallbackInfoInternal data) { }

	// RVA: 0x47A880 Offset: 0x479A80 VA: 0x18047A880 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref UpdateReceivingCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref UpdateReceivingCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.RTCData
public sealed class OnUpdateSendingCallback : MulticastDelegate // TypeDefIndex: 8474
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref UpdateSendingCallbackInfo data) { }

	// RVA: 0x47AD90 Offset: 0x479F90 VA: 0x18047AD90 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref UpdateSendingCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref UpdateSendingCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.RTCData
[UnmanagedFunctionPointer(2)]
internal sealed class OnUpdateSendingCallbackInternal : MulticastDelegate // TypeDefIndex: 8475
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref UpdateSendingCallbackInfoInternal data) { }

	// RVA: 0x47ABE0 Offset: 0x479DE0 VA: 0x18047ABE0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref UpdateSendingCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref UpdateSendingCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.RTCData
public struct ParticipantUpdatedCallbackInfo : ICallbackInfo // TypeDefIndex: 8476
{
	// Fields
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x0
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x8
	[CompilerGenerated]
	private Utf8String <RoomName>k__BackingField; // 0x10
	[CompilerGenerated]
	private ProductUserId <ParticipantId>k__BackingField; // 0x18
	[CompilerGenerated]
	private RTCDataStatus <DataStatus>k__BackingField; // 0x20

	// Properties
	public object ClientData { get; set; }
	public ProductUserId LocalUserId { get; set; }
	public Utf8String RoomName { get; set; }
	public ProductUserId ParticipantId { get; set; }
	public RTCDataStatus DataStatus { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410 Slot: 4
	public object get_ClientData() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_ClientData(object value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_LocalUserId(ProductUserId value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Utf8String get_RoomName() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_RoomName(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public ProductUserId get_ParticipantId() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_ParticipantId(ProductUserId value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400
	public RTCDataStatus get_DataStatus() { }

	[CompilerGenerated]
	// RVA: 0x3DA420 Offset: 0x3D9620 VA: 0x1803DA420
	public void set_DataStatus(RTCDataStatus value) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x47C680 Offset: 0x47B880 VA: 0x18047C680
	internal void Set(ref ParticipantUpdatedCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.RTCData
internal struct ParticipantUpdatedCallbackInfoInternal : ICallbackInfoInternal, IGettable<ParticipantUpdatedCallbackInfo>, ISettable<ParticipantUpdatedCallbackInfo>, IDisposable // TypeDefIndex: 8477
{
	// Fields
	private IntPtr m_ClientData; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_RoomName; // 0x10
	private IntPtr m_ParticipantId; // 0x18
	private RTCDataStatus m_DataStatus; // 0x20

	// Properties
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public ProductUserId LocalUserId { get; set; }
	public Utf8String RoomName { get; set; }
	public ProductUserId ParticipantId { get; set; }
	public RTCDataStatus DataStatus { get; set; }

	// Methods

	// RVA: 0x47BDA0 Offset: 0x47AFA0 VA: 0x18047BDA0
	public object get_ClientData() { }

	// RVA: 0x47C1D0 Offset: 0x47B3D0 VA: 0x18047C1D0
	public void set_ClientData(object value) { }

	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x47BF00 Offset: 0x47B100 VA: 0x18047BF00
	public ProductUserId get_LocalUserId() { }

	// RVA: 0x47C290 Offset: 0x47B490 VA: 0x18047C290
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x47C0F0 Offset: 0x47B2F0 VA: 0x18047C0F0
	public Utf8String get_RoomName() { }

	// RVA: 0x47C410 Offset: 0x47B610 VA: 0x18047C410
	public void set_RoomName(Utf8String value) { }

	// RVA: 0x47C000 Offset: 0x47B200 VA: 0x18047C000
	public ProductUserId get_ParticipantId() { }

	// RVA: 0x47C3B0 Offset: 0x47B5B0 VA: 0x18047C3B0
	public void set_ParticipantId(ProductUserId value) { }

	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400
	public RTCDataStatus get_DataStatus() { }

	// RVA: 0x3DA420 Offset: 0x3D9620 VA: 0x1803DA420
	public void set_DataStatus(RTCDataStatus value) { }

	// RVA: 0x47BA30 Offset: 0x47AC30 VA: 0x18047BA30 Slot: 6
	public void Set(ref ParticipantUpdatedCallbackInfo other) { }

	// RVA: 0x47B870 Offset: 0x47AA70 VA: 0x18047B870 Slot: 7
	public void Set(ref Nullable<ParticipantUpdatedCallbackInfo> other) { }

	// RVA: 0x47B5B0 Offset: 0x47A7B0 VA: 0x18047B5B0 Slot: 8
	public void Dispose() { }

	// RVA: 0x47B690 Offset: 0x47A890 VA: 0x18047B690 Slot: 5
	public void Get(out ParticipantUpdatedCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.RTCData
public sealed class RTCDataInterface : Handle // TypeDefIndex: 8478
{
	// Fields
	public const int AddnotifydatareceivedApiLatest = 1;
	public const int AddnotifyparticipantupdatedApiLatest = 1;
	public const int MaxPacketSize = 1170;
	public const int SenddataApiLatest = 1;
	public const int UpdatereceivingApiLatest = 1;
	public const int UpdatesendingApiLatest = 1;

	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }

	// RVA: 0x40BDB0 Offset: 0x40AFB0 VA: 0x18040BDB0
	public void .ctor(IntPtr innerHandle) { }

	// RVA: 0x480BA0 Offset: 0x47FDA0 VA: 0x180480BA0
	public ulong AddNotifyDataReceived(ref AddNotifyDataReceivedOptions options, object clientData, OnDataReceivedCallback completionDelegate) { }

	// RVA: 0x480D70 Offset: 0x47FF70 VA: 0x180480D70
	public ulong AddNotifyParticipantUpdated(ref AddNotifyParticipantUpdatedOptions options, object clientData, OnParticipantUpdatedCallback completionDelegate) { }

	// RVA: 0x481200 Offset: 0x480400 VA: 0x180481200
	public void RemoveNotifyDataReceived(ulong notificationId) { }

	// RVA: 0x481270 Offset: 0x480470 VA: 0x180481270
	public void RemoveNotifyParticipantUpdated(ulong notificationId) { }

	// RVA: 0x4812E0 Offset: 0x4804E0 VA: 0x1804812E0
	public Result SendData(ref SendDataOptions options) { }

	// RVA: 0x481390 Offset: 0x480590 VA: 0x180481390
	public void UpdateReceiving(ref UpdateReceivingOptions options, object clientData, OnUpdateReceivingCallback completionDelegate) { }

	// RVA: 0x481550 Offset: 0x480750 VA: 0x180481550
	public void UpdateSending(ref UpdateSendingOptions options, object clientData, OnUpdateSendingCallback completionDelegate) { }

	[MonoPInvokeCallback(typeof(OnDataReceivedCallbackInternal))]
	// RVA: 0x480F40 Offset: 0x480140 VA: 0x180480F40
	internal static void OnDataReceivedCallbackInternalImplementation(ref DataReceivedCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnParticipantUpdatedCallbackInternal))]
	// RVA: 0x480FF0 Offset: 0x4801F0 VA: 0x180480FF0
	internal static void OnParticipantUpdatedCallbackInternalImplementation(ref ParticipantUpdatedCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnUpdateReceivingCallbackInternal))]
	// RVA: 0x4810A0 Offset: 0x4802A0 VA: 0x1804810A0
	internal static void OnUpdateReceivingCallbackInternalImplementation(ref UpdateReceivingCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnUpdateSendingCallbackInternal))]
	// RVA: 0x481150 Offset: 0x480350 VA: 0x180481150
	internal static void OnUpdateSendingCallbackInternalImplementation(ref UpdateSendingCallbackInfoInternal data) { }
}

// Namespace: Epic.OnlineServices.RTCData
public enum RTCDataStatus // TypeDefIndex: 8479
{
	// Fields
	public int value__; // 0x0
	public const RTCDataStatus Unsupported = 0;
	public const RTCDataStatus Enabled = 1;
	public const RTCDataStatus Disabled = 2;
}

// Namespace: Epic.OnlineServices.RTCData
public struct SendDataOptions // TypeDefIndex: 8480
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <RoomName>k__BackingField; // 0x8
	[CompilerGenerated]
	private ArraySegment<byte> <Data>k__BackingField; // 0x10

	// Properties
	public ProductUserId LocalUserId { get; set; }
	public Utf8String RoomName { get; set; }
	public ArraySegment<byte> Data { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_LocalUserId(ProductUserId value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public Utf8String get_RoomName() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_RoomName(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x482990 Offset: 0x481B90 VA: 0x180482990
	public ArraySegment<byte> get_Data() { }

	[CompilerGenerated]
	// RVA: 0x4829A0 Offset: 0x481BA0 VA: 0x1804829A0
	public void set_Data(ArraySegment<byte> value) { }
}

// Namespace: Epic.OnlineServices.RTCData
internal struct SendDataOptionsInternal : ISettable<SendDataOptions>, IDisposable // TypeDefIndex: 8481
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_RoomName; // 0x10
	private uint m_DataLengthBytes; // 0x18
	private IntPtr m_Data; // 0x20

	// Properties
	public ProductUserId LocalUserId { set; }
	public Utf8String RoomName { set; }
	public ArraySegment<byte> Data { set; }

	// Methods

	// RVA: 0x4828D0 Offset: 0x481AD0 VA: 0x1804828D0
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x482930 Offset: 0x481B30 VA: 0x180482930
	public void set_RoomName(Utf8String value) { }

	// RVA: 0x482860 Offset: 0x481A60 VA: 0x180482860
	public void set_Data(ArraySegment<byte> value) { }

	// RVA: 0x4825E0 Offset: 0x4817E0 VA: 0x1804825E0 Slot: 4
	public void Set(ref SendDataOptions other) { }

	// RVA: 0x4826F0 Offset: 0x4818F0 VA: 0x1804826F0 Slot: 5
	public void Set(ref Nullable<SendDataOptions> other) { }

	// RVA: 0x482580 Offset: 0x481780 VA: 0x180482580 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.RTCData
public struct UpdateReceivingCallbackInfo : ICallbackInfo // TypeDefIndex: 8482
{
	// Fields
	[CompilerGenerated]
	private Result <ResultCode>k__BackingField; // 0x0
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x8
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x10
	[CompilerGenerated]
	private Utf8String <RoomName>k__BackingField; // 0x18
	[CompilerGenerated]
	private ProductUserId <ParticipantId>k__BackingField; // 0x20
	[CompilerGenerated]
	private bool <DataEnabled>k__BackingField; // 0x28

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public ProductUserId LocalUserId { get; set; }
	public Utf8String RoomName { get; set; }
	public ProductUserId ParticipantId { get; set; }
	public bool DataEnabled { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	[CompilerGenerated]
	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public object get_ClientData() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_ClientData(object value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_LocalUserId(ProductUserId value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public Utf8String get_RoomName() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_RoomName(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public ProductUserId get_ParticipantId() { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_ParticipantId(ProductUserId value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x42D840 Offset: 0x42CA40 VA: 0x18042D840
	public bool get_DataEnabled() { }

	[CompilerGenerated]
	// RVA: 0x42D8B0 Offset: 0x42CAB0 VA: 0x18042D8B0
	public void set_DataEnabled(bool value) { }

	// RVA: 0x486520 Offset: 0x485720 VA: 0x180486520 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x4866C0 Offset: 0x4858C0 VA: 0x1804866C0
	internal void Set(ref UpdateReceivingCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.RTCData
internal struct UpdateReceivingCallbackInfoInternal : ICallbackInfoInternal, IGettable<UpdateReceivingCallbackInfo>, ISettable<UpdateReceivingCallbackInfo>, IDisposable // TypeDefIndex: 8483
{
	// Fields
	private Result m_ResultCode; // 0x0
	private IntPtr m_ClientData; // 0x8
	private IntPtr m_LocalUserId; // 0x10
	private IntPtr m_RoomName; // 0x18
	private IntPtr m_ParticipantId; // 0x20
	private int m_DataEnabled; // 0x28

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public ProductUserId LocalUserId { get; set; }
	public Utf8String RoomName { get; set; }
	public ProductUserId ParticipantId { get; set; }
	public bool DataEnabled { get; set; }

	// Methods

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	// RVA: 0x485CF0 Offset: 0x484EF0 VA: 0x180485CF0
	public object get_ClientData() { }

	// RVA: 0x4861D0 Offset: 0x4853D0 VA: 0x1804861D0
	public void set_ClientData(object value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x485EB0 Offset: 0x4850B0 VA: 0x180485EB0
	public ProductUserId get_LocalUserId() { }

	// RVA: 0x486290 Offset: 0x485490 VA: 0x180486290
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x4860A0 Offset: 0x4852A0 VA: 0x1804860A0
	public Utf8String get_RoomName() { }

	// RVA: 0x486470 Offset: 0x485670 VA: 0x180486470
	public void set_RoomName(Utf8String value) { }

	// RVA: 0x485F30 Offset: 0x485130 VA: 0x180485F30
	public ProductUserId get_ParticipantId() { }

	// RVA: 0x486350 Offset: 0x485550 VA: 0x180486350
	public void set_ParticipantId(ProductUserId value) { }

	// RVA: 0x485DD0 Offset: 0x484FD0 VA: 0x180485DD0
	public bool get_DataEnabled() { }

	// RVA: 0x486230 Offset: 0x485430 VA: 0x180486230
	public void set_DataEnabled(bool value) { }

	// RVA: 0x4858F0 Offset: 0x484AF0 VA: 0x1804858F0 Slot: 6
	public void Set(ref UpdateReceivingCallbackInfo other) { }

	// RVA: 0x485A70 Offset: 0x484C70 VA: 0x180485A70 Slot: 7
	public void Set(ref Nullable<UpdateReceivingCallbackInfo> other) { }

	// RVA: 0x485430 Offset: 0x484630 VA: 0x180485430 Slot: 8
	public void Dispose() { }

	// RVA: 0x485510 Offset: 0x484710 VA: 0x180485510 Slot: 5
	public void Get(out UpdateReceivingCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.RTCData
public struct UpdateReceivingOptions // TypeDefIndex: 8484
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <RoomName>k__BackingField; // 0x8
	[CompilerGenerated]
	private ProductUserId <ParticipantId>k__BackingField; // 0x10
	[CompilerGenerated]
	private bool <DataEnabled>k__BackingField; // 0x18

	// Properties
	public ProductUserId LocalUserId { get; set; }
	public Utf8String RoomName { get; set; }
	public ProductUserId ParticipantId { get; set; }
	public bool DataEnabled { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_LocalUserId(ProductUserId value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public Utf8String get_RoomName() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_RoomName(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public ProductUserId get_ParticipantId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_ParticipantId(ProductUserId value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x411B20 Offset: 0x410D20 VA: 0x180411B20
	public bool get_DataEnabled() { }

	[CompilerGenerated]
	// RVA: 0x411B30 Offset: 0x410D30 VA: 0x180411B30
	public void set_DataEnabled(bool value) { }
}

// Namespace: Epic.OnlineServices.RTCData
internal struct UpdateReceivingOptionsInternal : ISettable<UpdateReceivingOptions>, IDisposable // TypeDefIndex: 8485
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_RoomName; // 0x10
	private IntPtr m_ParticipantId; // 0x18
	private int m_DataEnabled; // 0x20

	// Properties
	public ProductUserId LocalUserId { set; }
	public Utf8String RoomName { set; }
	public ProductUserId ParticipantId { set; }
	public bool DataEnabled { set; }

	// Methods

	// RVA: 0x486F70 Offset: 0x486170 VA: 0x180486F70
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x4870F0 Offset: 0x4862F0 VA: 0x1804870F0
	public void set_RoomName(Utf8String value) { }

	// RVA: 0x487030 Offset: 0x486230 VA: 0x180487030
	public void set_ParticipantId(ProductUserId value) { }

	// RVA: 0x486F10 Offset: 0x486110 VA: 0x180486F10
	public void set_DataEnabled(bool value) { }

	// RVA: 0x486BC0 Offset: 0x485DC0 VA: 0x180486BC0 Slot: 4
	public void Set(ref UpdateReceivingOptions other) { }

	// RVA: 0x486D00 Offset: 0x485F00 VA: 0x180486D00 Slot: 5
	public void Set(ref Nullable<UpdateReceivingOptions> other) { }

	// RVA: 0x486810 Offset: 0x485A10 VA: 0x180486810 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.RTCData
public struct UpdateSendingCallbackInfo : ICallbackInfo // TypeDefIndex: 8486
{
	// Fields
	[CompilerGenerated]
	private Result <ResultCode>k__BackingField; // 0x0
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x8
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x10
	[CompilerGenerated]
	private Utf8String <RoomName>k__BackingField; // 0x18
	[CompilerGenerated]
	private bool <DataEnabled>k__BackingField; // 0x20

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public ProductUserId LocalUserId { get; set; }
	public Utf8String RoomName { get; set; }
	public bool DataEnabled { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	[CompilerGenerated]
	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public object get_ClientData() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_ClientData(object value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_LocalUserId(ProductUserId value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public Utf8String get_RoomName() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_RoomName(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x4009D0 Offset: 0x3FFBD0 VA: 0x1804009D0
	public bool get_DataEnabled() { }

	[CompilerGenerated]
	// RVA: 0x4009E0 Offset: 0x3FFBE0 VA: 0x1804009E0
	public void set_DataEnabled(bool value) { }

	// RVA: 0x488860 Offset: 0x487A60 VA: 0x180488860 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x4889A0 Offset: 0x487BA0 VA: 0x1804889A0
	internal void Set(ref UpdateSendingCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.RTCData
internal struct UpdateSendingCallbackInfoInternal : ICallbackInfoInternal, IGettable<UpdateSendingCallbackInfo>, ISettable<UpdateSendingCallbackInfo>, IDisposable // TypeDefIndex: 8487
{
	// Fields
	private Result m_ResultCode; // 0x0
	private IntPtr m_ClientData; // 0x8
	private IntPtr m_LocalUserId; // 0x10
	private IntPtr m_RoomName; // 0x18
	private int m_DataEnabled; // 0x20

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public ProductUserId LocalUserId { get; set; }
	public Utf8String RoomName { get; set; }
	public bool DataEnabled { get; set; }

	// Methods

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	// RVA: 0x488250 Offset: 0x487450 VA: 0x180488250
	public object get_ClientData() { }

	// RVA: 0x4885D0 Offset: 0x4877D0 VA: 0x1804885D0
	public void set_ClientData(object value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x488390 Offset: 0x487590 VA: 0x180488390
	public ProductUserId get_LocalUserId() { }

	// RVA: 0x4886F0 Offset: 0x4878F0 VA: 0x1804886F0
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x488490 Offset: 0x487690 VA: 0x180488490
	public Utf8String get_RoomName() { }

	// RVA: 0x4887B0 Offset: 0x4879B0 VA: 0x1804887B0
	public void set_RoomName(Utf8String value) { }

	// RVA: 0x488330 Offset: 0x487530 VA: 0x180488330
	public bool get_DataEnabled() { }

	// RVA: 0x488630 Offset: 0x487830 VA: 0x180488630
	public void set_DataEnabled(bool value) { }

	// RVA: 0x487E80 Offset: 0x487080 VA: 0x180487E80 Slot: 6
	public void Set(ref UpdateSendingCallbackInfo other) { }

	// RVA: 0x487CC0 Offset: 0x486EC0 VA: 0x180487CC0 Slot: 7
	public void Set(ref Nullable<UpdateSendingCallbackInfo> other) { }

	// RVA: 0x487C00 Offset: 0x486E00 VA: 0x180487C00 Slot: 8
	public void Dispose() { }

	// RVA: 0x487C60 Offset: 0x486E60 VA: 0x180487C60 Slot: 5
	public void Get(out UpdateSendingCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.RTCData
public struct UpdateSendingOptions // TypeDefIndex: 8488
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <RoomName>k__BackingField; // 0x8
	[CompilerGenerated]
	private bool <DataEnabled>k__BackingField; // 0x10

	// Properties
	public ProductUserId LocalUserId { get; set; }
	public Utf8String RoomName { get; set; }
	public bool DataEnabled { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_LocalUserId(ProductUserId value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public Utf8String get_RoomName() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_RoomName(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	public bool get_DataEnabled() { }

	[CompilerGenerated]
	// RVA: 0x3D6DB0 Offset: 0x3D5FB0 VA: 0x1803D6DB0
	public void set_DataEnabled(bool value) { }
}

// Namespace: Epic.OnlineServices.RTCData
internal struct UpdateSendingOptionsInternal : ISettable<UpdateSendingOptions>, IDisposable // TypeDefIndex: 8489
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_RoomName; // 0x10
	private int m_DataEnabled; // 0x18

	// Properties
	public ProductUserId LocalUserId { set; }
	public Utf8String RoomName { set; }
	public bool DataEnabled { set; }

	// Methods

	// RVA: 0x4890A0 Offset: 0x4882A0 VA: 0x1804890A0
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x489160 Offset: 0x488360 VA: 0x180489160
	public void set_RoomName(Utf8String value) { }

	// RVA: 0x488FE0 Offset: 0x4881E0 VA: 0x180488FE0
	public void set_DataEnabled(bool value) { }

	// RVA: 0x488E20 Offset: 0x488020 VA: 0x180488E20 Slot: 4
	public void Set(ref UpdateSendingOptions other) { }

	// RVA: 0x488BA0 Offset: 0x487DA0 VA: 0x180488BA0 Slot: 5
	public void Set(ref Nullable<UpdateSendingOptions> other) { }

	// RVA: 0x488AE0 Offset: 0x487CE0 VA: 0x180488AE0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.RTCAudio
public struct AddNotifyAudioBeforeRenderOptions // TypeDefIndex: 8490
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <RoomName>k__BackingField; // 0x8
	[CompilerGenerated]
	private bool <UnmixedAudio>k__BackingField; // 0x10

	// Properties
	public ProductUserId LocalUserId { get; set; }
	public Utf8String RoomName { get; set; }
	public bool UnmixedAudio { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_LocalUserId(ProductUserId value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public Utf8String get_RoomName() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_RoomName(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	public bool get_UnmixedAudio() { }

	[CompilerGenerated]
	// RVA: 0x3D6DB0 Offset: 0x3D5FB0 VA: 0x1803D6DB0
	public void set_UnmixedAudio(bool value) { }
}

// Namespace: Epic.OnlineServices.RTCAudio
internal struct AddNotifyAudioBeforeRenderOptionsInternal : ISettable<AddNotifyAudioBeforeRenderOptions>, IDisposable // TypeDefIndex: 8491
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_RoomName; // 0x10
	private int m_UnmixedAudio; // 0x18

	// Properties
	public ProductUserId LocalUserId { set; }
	public Utf8String RoomName { set; }
	public bool UnmixedAudio { set; }

	// Methods

	// RVA: 0x4716D0 Offset: 0x4708D0 VA: 0x1804716D0
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x471730 Offset: 0x470930 VA: 0x180471730
	public void set_RoomName(Utf8String value) { }

	// RVA: 0x471790 Offset: 0x470990 VA: 0x180471790
	public void set_UnmixedAudio(bool value) { }

	// RVA: 0x4715D0 Offset: 0x4707D0 VA: 0x1804715D0 Slot: 4
	public void Set(ref AddNotifyAudioBeforeRenderOptions other) { }

	// RVA: 0x471470 Offset: 0x470670 VA: 0x180471470 Slot: 5
	public void Set(ref Nullable<AddNotifyAudioBeforeRenderOptions> other) { }

	// RVA: 0x471410 Offset: 0x470610 VA: 0x180471410 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.RTCAudio
public struct AddNotifyAudioBeforeSendOptions // TypeDefIndex: 8492
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <RoomName>k__BackingField; // 0x8

	// Properties
	public ProductUserId LocalUserId { get; set; }
	public Utf8String RoomName { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_LocalUserId(ProductUserId value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public Utf8String get_RoomName() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_RoomName(Utf8String value) { }
}

// Namespace: Epic.OnlineServices.RTCAudio
internal struct AddNotifyAudioBeforeSendOptionsInternal : ISettable<AddNotifyAudioBeforeSendOptions>, IDisposable // TypeDefIndex: 8493
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_RoomName; // 0x10

	// Properties
	public ProductUserId LocalUserId { set; }
	public Utf8String RoomName { set; }

	// Methods

	// RVA: 0x471A10 Offset: 0x470C10 VA: 0x180471A10
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x471A70 Offset: 0x470C70 VA: 0x180471A70
	public void set_RoomName(Utf8String value) { }

	// RVA: 0x471850 Offset: 0x470A50 VA: 0x180471850 Slot: 4
	public void Set(ref AddNotifyAudioBeforeSendOptions other) { }

	// RVA: 0x471910 Offset: 0x470B10 VA: 0x180471910 Slot: 5
	public void Set(ref Nullable<AddNotifyAudioBeforeSendOptions> other) { }

	// RVA: 0x4717F0 Offset: 0x4709F0 VA: 0x1804717F0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.RTCAudio
public struct AddNotifyAudioDevicesChangedOptions // TypeDefIndex: 8494
{}

// Namespace: Epic.OnlineServices.RTCAudio
internal struct AddNotifyAudioDevicesChangedOptionsInternal : ISettable<AddNotifyAudioDevicesChangedOptions>, IDisposable // TypeDefIndex: 8495
{
	// Fields
	private int m_ApiVersion; // 0x0

	// Methods

	// RVA: 0x3F98A0 Offset: 0x3F8AA0 VA: 0x1803F98A0 Slot: 4
	public void Set(ref AddNotifyAudioDevicesChangedOptions other) { }

	// RVA: 0x471AD0 Offset: 0x470CD0 VA: 0x180471AD0 Slot: 5
	public void Set(ref Nullable<AddNotifyAudioDevicesChangedOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.RTCAudio
public struct AddNotifyAudioInputStateOptions // TypeDefIndex: 8496
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <RoomName>k__BackingField; // 0x8

	// Properties
	public ProductUserId LocalUserId { get; set; }
	public Utf8String RoomName { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_LocalUserId(ProductUserId value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public Utf8String get_RoomName() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_RoomName(Utf8String value) { }
}

// Namespace: Epic.OnlineServices.RTCAudio
internal struct AddNotifyAudioInputStateOptionsInternal : ISettable<AddNotifyAudioInputStateOptions>, IDisposable // TypeDefIndex: 8497
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_RoomName; // 0x10

	// Properties
	public ProductUserId LocalUserId { set; }
	public Utf8String RoomName { set; }

	// Methods

	// RVA: 0x471D40 Offset: 0x470F40 VA: 0x180471D40
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x471DA0 Offset: 0x470FA0 VA: 0x180471DA0
	public void set_RoomName(Utf8String value) { }

	// RVA: 0x471B80 Offset: 0x470D80 VA: 0x180471B80 Slot: 4
	public void Set(ref AddNotifyAudioInputStateOptions other) { }

	// RVA: 0x471C40 Offset: 0x470E40 VA: 0x180471C40 Slot: 5
	public void Set(ref Nullable<AddNotifyAudioInputStateOptions> other) { }

	// RVA: 0x471B20 Offset: 0x470D20 VA: 0x180471B20 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.RTCAudio
public struct AddNotifyAudioOutputStateOptions // TypeDefIndex: 8498
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <RoomName>k__BackingField; // 0x8

	// Properties
	public ProductUserId LocalUserId { get; set; }
	public Utf8String RoomName { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_LocalUserId(ProductUserId value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public Utf8String get_RoomName() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_RoomName(Utf8String value) { }
}

// Namespace: Epic.OnlineServices.RTCAudio
internal struct AddNotifyAudioOutputStateOptionsInternal : ISettable<AddNotifyAudioOutputStateOptions>, IDisposable // TypeDefIndex: 8499
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_RoomName; // 0x10

	// Properties
	public ProductUserId LocalUserId { set; }
	public Utf8String RoomName { set; }

	// Methods

	// RVA: 0x472020 Offset: 0x471220 VA: 0x180472020
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x472080 Offset: 0x471280 VA: 0x180472080
	public void set_RoomName(Utf8String value) { }

	// RVA: 0x471E60 Offset: 0x471060 VA: 0x180471E60 Slot: 4
	public void Set(ref AddNotifyAudioOutputStateOptions other) { }

	// RVA: 0x471F20 Offset: 0x471120 VA: 0x180471F20 Slot: 5
	public void Set(ref Nullable<AddNotifyAudioOutputStateOptions> other) { }

	// RVA: 0x471E00 Offset: 0x471000 VA: 0x180471E00 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.RTCAudio
public struct AddNotifyParticipantUpdatedOptions // TypeDefIndex: 8500
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <RoomName>k__BackingField; // 0x8

	// Properties
	public ProductUserId LocalUserId { get; set; }
	public Utf8String RoomName { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_LocalUserId(ProductUserId value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public Utf8String get_RoomName() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_RoomName(Utf8String value) { }
}

// Namespace: Epic.OnlineServices.RTCAudio
internal struct AddNotifyParticipantUpdatedOptionsInternal : ISettable<AddNotifyParticipantUpdatedOptions>, IDisposable // TypeDefIndex: 8501
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_RoomName; // 0x10

	// Properties
	public ProductUserId LocalUserId { set; }
	public Utf8String RoomName { set; }

	// Methods

	// RVA: 0x472860 Offset: 0x471A60 VA: 0x180472860
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x4728C0 Offset: 0x471AC0 VA: 0x1804728C0
	public void set_RoomName(Utf8String value) { }

	// RVA: 0x472480 Offset: 0x471680 VA: 0x180472480 Slot: 4
	public void Set(ref AddNotifyParticipantUpdatedOptions other) { }

	// RVA: 0x472640 Offset: 0x471840 VA: 0x180472640 Slot: 5
	public void Set(ref Nullable<AddNotifyParticipantUpdatedOptions> other) { }

	// RVA: 0x472420 Offset: 0x471620 VA: 0x180472420 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.RTCAudio
public struct AudioBeforeRenderCallbackInfo : ICallbackInfo // TypeDefIndex: 8502
{
	// Fields
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x0
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x8
	[CompilerGenerated]
	private Utf8String <RoomName>k__BackingField; // 0x10
	[CompilerGenerated]
	private Nullable<AudioBuffer> <Buffer>k__BackingField; // 0x18
	[CompilerGenerated]
	private ProductUserId <ParticipantId>k__BackingField; // 0x30

	// Properties
	public object ClientData { get; set; }
	public ProductUserId LocalUserId { get; set; }
	public Utf8String RoomName { get; set; }
	public Nullable<AudioBuffer> Buffer { get; set; }
	public ProductUserId ParticipantId { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410 Slot: 4
	public object get_ClientData() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_ClientData(object value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_LocalUserId(ProductUserId value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Utf8String get_RoomName() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_RoomName(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x426510 Offset: 0x425710 VA: 0x180426510
	public Nullable<AudioBuffer> get_Buffer() { }

	[CompilerGenerated]
	// RVA: 0x426540 Offset: 0x425740 VA: 0x180426540
	public void set_Buffer(Nullable<AudioBuffer> value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public ProductUserId get_ParticipantId() { }

	[CompilerGenerated]
	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	public void set_ParticipantId(ProductUserId value) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x473250 Offset: 0x472450 VA: 0x180473250
	internal void Set(ref AudioBeforeRenderCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.RTCAudio
internal struct AudioBeforeRenderCallbackInfoInternal : ICallbackInfoInternal, IGettable<AudioBeforeRenderCallbackInfo>, ISettable<AudioBeforeRenderCallbackInfo>, IDisposable // TypeDefIndex: 8503
{
	// Fields
	private IntPtr m_ClientData; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_RoomName; // 0x10
	private IntPtr m_Buffer; // 0x18
	private IntPtr m_ParticipantId; // 0x20

	// Properties
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public ProductUserId LocalUserId { get; set; }
	public Utf8String RoomName { get; set; }
	public Nullable<AudioBuffer> Buffer { get; set; }
	public ProductUserId ParticipantId { get; set; }

	// Methods

	// RVA: 0x472E80 Offset: 0x472080 VA: 0x180472E80
	public object get_ClientData() { }

	// RVA: 0x4730D0 Offset: 0x4722D0 VA: 0x1804730D0
	public void set_ClientData(object value) { }

	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x472EF0 Offset: 0x4720F0 VA: 0x180472EF0
	public ProductUserId get_LocalUserId() { }

	// RVA: 0x473130 Offset: 0x472330 VA: 0x180473130
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x472FF0 Offset: 0x4721F0 VA: 0x180472FF0
	public Utf8String get_RoomName() { }

	// RVA: 0x4731F0 Offset: 0x4723F0 VA: 0x1804731F0
	public void set_RoomName(Utf8String value) { }

	// RVA: 0x472E00 Offset: 0x472000 VA: 0x180472E00
	public Nullable<AudioBuffer> get_Buffer() { }

	// RVA: 0x473060 Offset: 0x472260 VA: 0x180473060
	public void set_Buffer(Nullable<AudioBuffer> value) { }

	// RVA: 0x472F70 Offset: 0x472170 VA: 0x180472F70
	public ProductUserId get_ParticipantId() { }

	// RVA: 0x473190 Offset: 0x472390 VA: 0x180473190
	public void set_ParticipantId(ProductUserId value) { }

	// RVA: 0x472C60 Offset: 0x471E60 VA: 0x180472C60 Slot: 6
	public void Set(ref AudioBeforeRenderCallbackInfo other) { }

	// RVA: 0x472A30 Offset: 0x471C30 VA: 0x180472A30 Slot: 7
	public void Set(ref Nullable<AudioBeforeRenderCallbackInfo> other) { }

	// RVA: 0x472980 Offset: 0x471B80 VA: 0x180472980 Slot: 8
	public void Dispose() { }

	// RVA: 0x472A00 Offset: 0x471C00 VA: 0x180472A00 Slot: 5
	public void Get(out AudioBeforeRenderCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.RTCAudio
public struct AudioBeforeSendCallbackInfo : ICallbackInfo // TypeDefIndex: 8504
{
	// Fields
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x0
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x8
	[CompilerGenerated]
	private Utf8String <RoomName>k__BackingField; // 0x10
	[CompilerGenerated]
	private Nullable<AudioBuffer> <Buffer>k__BackingField; // 0x18

	// Properties
	public object ClientData { get; set; }
	public ProductUserId LocalUserId { get; set; }
	public Utf8String RoomName { get; set; }
	public Nullable<AudioBuffer> Buffer { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410 Slot: 4
	public object get_ClientData() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_ClientData(object value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_LocalUserId(ProductUserId value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Utf8String get_RoomName() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_RoomName(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x426510 Offset: 0x425710 VA: 0x180426510
	public Nullable<AudioBuffer> get_Buffer() { }

	[CompilerGenerated]
	// RVA: 0x426540 Offset: 0x425740 VA: 0x180426540
	public void set_Buffer(Nullable<AudioBuffer> value) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x473AF0 Offset: 0x472CF0 VA: 0x180473AF0
	internal void Set(ref AudioBeforeSendCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.RTCAudio
internal struct AudioBeforeSendCallbackInfoInternal : ICallbackInfoInternal, IGettable<AudioBeforeSendCallbackInfo>, ISettable<AudioBeforeSendCallbackInfo>, IDisposable // TypeDefIndex: 8505
{
	// Fields
	private IntPtr m_ClientData; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_RoomName; // 0x10
	private IntPtr m_Buffer; // 0x18

	// Properties
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public ProductUserId LocalUserId { get; set; }
	public Utf8String RoomName { get; set; }
	public Nullable<AudioBuffer> Buffer { get; set; }

	// Methods

	// RVA: 0x473800 Offset: 0x472A00 VA: 0x180473800
	public object get_ClientData() { }

	// RVA: 0x4739D0 Offset: 0x472BD0 VA: 0x1804739D0
	public void set_ClientData(object value) { }

	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x473870 Offset: 0x472A70 VA: 0x180473870
	public ProductUserId get_LocalUserId() { }

	// RVA: 0x473A30 Offset: 0x472C30 VA: 0x180473A30
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x4738F0 Offset: 0x472AF0 VA: 0x1804738F0
	public Utf8String get_RoomName() { }

	// RVA: 0x473A90 Offset: 0x472C90 VA: 0x180473A90
	public void set_RoomName(Utf8String value) { }

	// RVA: 0x473780 Offset: 0x472980 VA: 0x180473780
	public Nullable<AudioBuffer> get_Buffer() { }

	// RVA: 0x473960 Offset: 0x472B60 VA: 0x180473960
	public void set_Buffer(Nullable<AudioBuffer> value) { }

	// RVA: 0x473620 Offset: 0x472820 VA: 0x180473620 Slot: 6
	public void Set(ref AudioBeforeSendCallbackInfo other) { }

	// RVA: 0x473450 Offset: 0x472650 VA: 0x180473450 Slot: 7
	public void Set(ref Nullable<AudioBeforeSendCallbackInfo> other) { }

	// RVA: 0x4733C0 Offset: 0x4725C0 VA: 0x1804733C0 Slot: 8
	public void Dispose() { }

	// RVA: 0x473430 Offset: 0x472630 VA: 0x180473430 Slot: 5
	public void Get(out AudioBeforeSendCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.RTCAudio
public struct AudioBuffer // TypeDefIndex: 8506
{
	// Fields
	[CompilerGenerated]
	private short[] <Frames>k__BackingField; // 0x0
	[CompilerGenerated]
	private uint <SampleRate>k__BackingField; // 0x8
	[CompilerGenerated]
	private uint <Channels>k__BackingField; // 0xC

	// Properties
	public short[] Frames { get; set; }
	public uint SampleRate { get; set; }
	public uint Channels { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public short[] get_Frames() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_Frames(short[] value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3F5510 Offset: 0x3F4710 VA: 0x1803F5510
	public uint get_SampleRate() { }

	[CompilerGenerated]
	// RVA: 0x3F5520 Offset: 0x3F4720 VA: 0x1803F5520
	public void set_SampleRate(uint value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x438080 Offset: 0x437280 VA: 0x180438080
	public uint get_Channels() { }

	[CompilerGenerated]
	// RVA: 0x438090 Offset: 0x437290 VA: 0x180438090
	public void set_Channels(uint value) { }

	// RVA: 0x473F20 Offset: 0x473120 VA: 0x180473F20
	internal void Set(ref AudioBufferInternal other) { }
}

// Namespace: Epic.OnlineServices.RTCAudio
internal struct AudioBufferInternal : IGettable<AudioBuffer>, ISettable<AudioBuffer>, IDisposable // TypeDefIndex: 8507
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_Frames; // 0x8
	private uint m_FramesCount; // 0x10
	private uint m_SampleRate; // 0x14
	private uint m_Channels; // 0x18

	// Properties
	public short[] Frames { get; set; }
	public uint SampleRate { get; set; }
	public uint Channels { get; set; }

	// Methods

	// RVA: 0x473E20 Offset: 0x473020 VA: 0x180473E20
	public short[] get_Frames() { }

	// RVA: 0x473EB0 Offset: 0x4730B0 VA: 0x180473EB0
	public void set_Frames(short[] value) { }

	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500
	public uint get_SampleRate() { }

	// RVA: 0x426530 Offset: 0x425730 VA: 0x180426530
	public void set_SampleRate(uint value) { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public uint get_Channels() { }

	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	public void set_Channels(uint value) { }

	// RVA: 0x473D90 Offset: 0x472F90 VA: 0x180473D90 Slot: 5
	public void Set(ref AudioBuffer other) { }

	// RVA: 0x473CE0 Offset: 0x472EE0 VA: 0x180473CE0 Slot: 6
	public void Set(ref Nullable<AudioBuffer> other) { }

	// RVA: 0x473C50 Offset: 0x472E50 VA: 0x180473C50 Slot: 7
	public void Dispose() { }

	// RVA: 0x473CA0 Offset: 0x472EA0 VA: 0x180473CA0 Slot: 4
	public void Get(out AudioBuffer output) { }
}

// Namespace: Epic.OnlineServices.RTCAudio
public struct AudioDevicesChangedCallbackInfo : ICallbackInfo // TypeDefIndex: 8508
{
	// Fields
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x0

	// Properties
	public object ClientData { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410 Slot: 4
	public object get_ClientData() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_ClientData(object value) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x4741A0 Offset: 0x4733A0 VA: 0x1804741A0
	internal void Set(ref AudioDevicesChangedCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.RTCAudio
internal struct AudioDevicesChangedCallbackInfoInternal : ICallbackInfoInternal, IGettable<AudioDevicesChangedCallbackInfo>, ISettable<AudioDevicesChangedCallbackInfo>, IDisposable // TypeDefIndex: 8509
{
	// Fields
	private IntPtr m_ClientData; // 0x0

	// Properties
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }

	// Methods

	// RVA: 0x4740D0 Offset: 0x4732D0 VA: 0x1804740D0
	public object get_ClientData() { }

	// RVA: 0x474140 Offset: 0x473340 VA: 0x180474140
	public void set_ClientData(object value) { }

	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x474070 Offset: 0x473270 VA: 0x180474070 Slot: 6
	public void Set(ref AudioDevicesChangedCallbackInfo other) { }

	// RVA: 0x473FD0 Offset: 0x4731D0 VA: 0x180473FD0 Slot: 7
	public void Set(ref Nullable<AudioDevicesChangedCallbackInfo> other) { }

	// RVA: 0x473F60 Offset: 0x473160 VA: 0x180473F60 Slot: 8
	public void Dispose() { }

	// RVA: 0x473FB0 Offset: 0x4731B0 VA: 0x180473FB0 Slot: 5
	public void Get(out AudioDevicesChangedCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.RTCAudio
public struct AudioInputDeviceInfo // TypeDefIndex: 8510
{
	// Fields
	[CompilerGenerated]
	private bool <DefaultDevice>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <DeviceId>k__BackingField; // 0x8
	[CompilerGenerated]
	private Utf8String <DeviceName>k__BackingField; // 0x10

	// Properties
	public bool DefaultDevice { get; set; }
	public Utf8String DeviceId { get; set; }
	public Utf8String DeviceName { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x41D600 Offset: 0x41C800 VA: 0x18041D600
	public bool get_DefaultDevice() { }

	[CompilerGenerated]
	// RVA: 0x41D610 Offset: 0x41C810 VA: 0x18041D610
	public void set_DefaultDevice(bool value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public Utf8String get_DeviceId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_DeviceId(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Utf8String get_DeviceName() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_DeviceName(Utf8String value) { }

	// RVA: 0x474750 Offset: 0x473950 VA: 0x180474750
	internal void Set(ref AudioInputDeviceInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.RTCAudio
internal struct AudioInputDeviceInfoInternal : IGettable<AudioInputDeviceInfo>, ISettable<AudioInputDeviceInfo>, IDisposable // TypeDefIndex: 8511
{
	// Fields
	private int m_ApiVersion; // 0x0
	private int m_DefaultDevice; // 0x4
	private IntPtr m_DeviceId; // 0x8
	private IntPtr m_DeviceName; // 0x10

	// Properties
	public bool DefaultDevice { get; set; }
	public Utf8String DeviceId { get; set; }
	public Utf8String DeviceName { get; set; }

	// Methods

	// RVA: 0x4744F0 Offset: 0x4736F0 VA: 0x1804744F0
	public bool get_DefaultDevice() { }

	// RVA: 0x474630 Offset: 0x473830 VA: 0x180474630
	public void set_DefaultDevice(bool value) { }

	// RVA: 0x474550 Offset: 0x473750 VA: 0x180474550
	public Utf8String get_DeviceId() { }

	// RVA: 0x474690 Offset: 0x473890 VA: 0x180474690
	public void set_DeviceId(Utf8String value) { }

	// RVA: 0x4745C0 Offset: 0x4737C0 VA: 0x1804745C0
	public Utf8String get_DeviceName() { }

	// RVA: 0x4746F0 Offset: 0x4738F0 VA: 0x1804746F0
	public void set_DeviceName(Utf8String value) { }

	// RVA: 0x474290 Offset: 0x473490 VA: 0x180474290 Slot: 5
	public void Set(ref AudioInputDeviceInfo other) { }

	// RVA: 0x474390 Offset: 0x473590 VA: 0x180474390 Slot: 6
	public void Set(ref Nullable<AudioInputDeviceInfo> other) { }

	// RVA: 0x474210 Offset: 0x473410 VA: 0x180474210 Slot: 7
	public void Dispose() { }

	// RVA: 0x474270 Offset: 0x473470 VA: 0x180474270 Slot: 4
	public void Get(out AudioInputDeviceInfo output) { }
}

// Namespace: Epic.OnlineServices.RTCAudio
public struct AudioInputStateCallbackInfo : ICallbackInfo // TypeDefIndex: 8512
{
	// Fields
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x0
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x8
	[CompilerGenerated]
	private Utf8String <RoomName>k__BackingField; // 0x10
	[CompilerGenerated]
	private RTCAudioInputStatus <Status>k__BackingField; // 0x18

	// Properties
	public object ClientData { get; set; }
	public ProductUserId LocalUserId { get; set; }
	public Utf8String RoomName { get; set; }
	public RTCAudioInputStatus Status { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410 Slot: 4
	public object get_ClientData() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_ClientData(object value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_LocalUserId(ProductUserId value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Utf8String get_RoomName() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_RoomName(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public RTCAudioInputStatus get_Status() { }

	[CompilerGenerated]
	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	public void set_Status(RTCAudioInputStatus value) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x474DF0 Offset: 0x473FF0 VA: 0x180474DF0
	internal void Set(ref AudioInputStateCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.RTCAudio
internal struct AudioInputStateCallbackInfoInternal : ICallbackInfoInternal, IGettable<AudioInputStateCallbackInfo>, ISettable<AudioInputStateCallbackInfo>, IDisposable // TypeDefIndex: 8513
{
	// Fields
	private IntPtr m_ClientData; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_RoomName; // 0x10
	private RTCAudioInputStatus m_Status; // 0x18

	// Properties
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public ProductUserId LocalUserId { get; set; }
	public Utf8String RoomName { get; set; }
	public RTCAudioInputStatus Status { get; set; }

	// Methods

	// RVA: 0x474B70 Offset: 0x473D70 VA: 0x180474B70
	public object get_ClientData() { }

	// RVA: 0x474CD0 Offset: 0x473ED0 VA: 0x180474CD0
	public void set_ClientData(object value) { }

	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x474BE0 Offset: 0x473DE0 VA: 0x180474BE0
	public ProductUserId get_LocalUserId() { }

	// RVA: 0x474D30 Offset: 0x473F30 VA: 0x180474D30
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x474C60 Offset: 0x473E60 VA: 0x180474C60
	public Utf8String get_RoomName() { }

	// RVA: 0x474D90 Offset: 0x473F90 VA: 0x180474D90
	public void set_RoomName(Utf8String value) { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public RTCAudioInputStatus get_Status() { }

	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	public void set_Status(RTCAudioInputStatus value) { }

	// RVA: 0x474A70 Offset: 0x473C70 VA: 0x180474A70 Slot: 6
	public void Set(ref AudioInputStateCallbackInfo other) { }

	// RVA: 0x474900 Offset: 0x473B00 VA: 0x180474900 Slot: 7
	public void Set(ref Nullable<AudioInputStateCallbackInfo> other) { }

	// RVA: 0x474880 Offset: 0x473A80 VA: 0x180474880 Slot: 8
	public void Dispose() { }

	// RVA: 0x4748E0 Offset: 0x473AE0 VA: 0x1804748E0 Slot: 5
	public void Get(out AudioInputStateCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.RTCAudio
public struct AudioOutputDeviceInfo // TypeDefIndex: 8514
{
	// Fields
	[CompilerGenerated]
	private bool <DefaultDevice>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <DeviceId>k__BackingField; // 0x8
	[CompilerGenerated]
	private Utf8String <DeviceName>k__BackingField; // 0x10

	// Properties
	public bool DefaultDevice { get; set; }
	public Utf8String DeviceId { get; set; }
	public Utf8String DeviceName { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x41D600 Offset: 0x41C800 VA: 0x18041D600
	public bool get_DefaultDevice() { }

	[CompilerGenerated]
	// RVA: 0x41D610 Offset: 0x41C810 VA: 0x18041D610
	public void set_DefaultDevice(bool value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public Utf8String get_DeviceId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_DeviceId(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Utf8String get_DeviceName() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_DeviceName(Utf8String value) { }

	// RVA: 0x475420 Offset: 0x474620 VA: 0x180475420
	internal void Set(ref AudioOutputDeviceInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.RTCAudio
internal struct AudioOutputDeviceInfoInternal : IGettable<AudioOutputDeviceInfo>, ISettable<AudioOutputDeviceInfo>, IDisposable // TypeDefIndex: 8515
{
	// Fields
	private int m_ApiVersion; // 0x0
	private int m_DefaultDevice; // 0x4
	private IntPtr m_DeviceId; // 0x8
	private IntPtr m_DeviceName; // 0x10

	// Properties
	public bool DefaultDevice { get; set; }
	public Utf8String DeviceId { get; set; }
	public Utf8String DeviceName { get; set; }

	// Methods

	// RVA: 0x4751C0 Offset: 0x4743C0 VA: 0x1804751C0
	public bool get_DefaultDevice() { }

	// RVA: 0x475300 Offset: 0x474500 VA: 0x180475300
	public void set_DefaultDevice(bool value) { }

	// RVA: 0x475220 Offset: 0x474420 VA: 0x180475220
	public Utf8String get_DeviceId() { }

	// RVA: 0x475360 Offset: 0x474560 VA: 0x180475360
	public void set_DeviceId(Utf8String value) { }

	// RVA: 0x475290 Offset: 0x474490 VA: 0x180475290
	public Utf8String get_DeviceName() { }

	// RVA: 0x4753C0 Offset: 0x4745C0 VA: 0x1804753C0
	public void set_DeviceName(Utf8String value) { }

	// RVA: 0x474F60 Offset: 0x474160 VA: 0x180474F60 Slot: 5
	public void Set(ref AudioOutputDeviceInfo other) { }

	// RVA: 0x475060 Offset: 0x474260 VA: 0x180475060 Slot: 6
	public void Set(ref Nullable<AudioOutputDeviceInfo> other) { }

	// RVA: 0x474EE0 Offset: 0x4740E0 VA: 0x180474EE0 Slot: 7
	public void Dispose() { }

	// RVA: 0x474F40 Offset: 0x474140 VA: 0x180474F40 Slot: 4
	public void Get(out AudioOutputDeviceInfo output) { }
}

// Namespace: Epic.OnlineServices.RTCAudio
public struct AudioOutputStateCallbackInfo : ICallbackInfo // TypeDefIndex: 8516
{
	// Fields
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x0
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x8
	[CompilerGenerated]
	private Utf8String <RoomName>k__BackingField; // 0x10
	[CompilerGenerated]
	private RTCAudioOutputStatus <Status>k__BackingField; // 0x18

	// Properties
	public object ClientData { get; set; }
	public ProductUserId LocalUserId { get; set; }
	public Utf8String RoomName { get; set; }
	public RTCAudioOutputStatus Status { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410 Slot: 4
	public object get_ClientData() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_ClientData(object value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_LocalUserId(ProductUserId value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Utf8String get_RoomName() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_RoomName(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public RTCAudioOutputStatus get_Status() { }

	[CompilerGenerated]
	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	public void set_Status(RTCAudioOutputStatus value) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x475AC0 Offset: 0x474CC0 VA: 0x180475AC0
	internal void Set(ref AudioOutputStateCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.RTCAudio
internal struct AudioOutputStateCallbackInfoInternal : ICallbackInfoInternal, IGettable<AudioOutputStateCallbackInfo>, ISettable<AudioOutputStateCallbackInfo>, IDisposable // TypeDefIndex: 8517
{
	// Fields
	private IntPtr m_ClientData; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_RoomName; // 0x10
	private RTCAudioOutputStatus m_Status; // 0x18

	// Properties
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public ProductUserId LocalUserId { get; set; }
	public Utf8String RoomName { get; set; }
	public RTCAudioOutputStatus Status { get; set; }

	// Methods

	// RVA: 0x475840 Offset: 0x474A40 VA: 0x180475840
	public object get_ClientData() { }

	// RVA: 0x4759A0 Offset: 0x474BA0 VA: 0x1804759A0
	public void set_ClientData(object value) { }

	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x4758B0 Offset: 0x474AB0 VA: 0x1804758B0
	public ProductUserId get_LocalUserId() { }

	// RVA: 0x475A00 Offset: 0x474C00 VA: 0x180475A00
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x475930 Offset: 0x474B30 VA: 0x180475930
	public Utf8String get_RoomName() { }

	// RVA: 0x475A60 Offset: 0x474C60 VA: 0x180475A60
	public void set_RoomName(Utf8String value) { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public RTCAudioOutputStatus get_Status() { }

	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	public void set_Status(RTCAudioOutputStatus value) { }

	// RVA: 0x475740 Offset: 0x474940 VA: 0x180475740 Slot: 6
	public void Set(ref AudioOutputStateCallbackInfo other) { }

	// RVA: 0x4755D0 Offset: 0x4747D0 VA: 0x1804755D0 Slot: 7
	public void Set(ref Nullable<AudioOutputStateCallbackInfo> other) { }

	// RVA: 0x475550 Offset: 0x474750 VA: 0x180475550 Slot: 8
	public void Dispose() { }

	// RVA: 0x4755B0 Offset: 0x4747B0 VA: 0x1804755B0 Slot: 5
	public void Get(out AudioOutputStateCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.RTCAudio
public struct CopyInputDeviceInformationByIndexOptions // TypeDefIndex: 8518
{
	// Fields
	[CompilerGenerated]
	private uint <DeviceIndex>k__BackingField; // 0x0

	// Properties
	public uint DeviceIndex { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public uint get_DeviceIndex() { }

	[CompilerGenerated]
	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_DeviceIndex(uint value) { }
}

// Namespace: Epic.OnlineServices.RTCAudio
internal struct CopyInputDeviceInformationByIndexOptionsInternal : ISettable<CopyInputDeviceInformationByIndexOptions>, IDisposable // TypeDefIndex: 8519
{
	// Fields
	private int m_ApiVersion; // 0x0
	private uint m_DeviceIndex; // 0x4

	// Properties
	public uint DeviceIndex { set; }

	// Methods

	// RVA: 0x3F84A0 Offset: 0x3F76A0 VA: 0x1803F84A0
	public void set_DeviceIndex(uint value) { }

	// RVA: 0x40B2E0 Offset: 0x40A4E0 VA: 0x18040B2E0 Slot: 4
	public void Set(ref CopyInputDeviceInformationByIndexOptions other) { }

	// RVA: 0x475BB0 Offset: 0x474DB0 VA: 0x180475BB0 Slot: 5
	public void Set(ref Nullable<CopyInputDeviceInformationByIndexOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.RTCAudio
public struct CopyOutputDeviceInformationByIndexOptions // TypeDefIndex: 8520
{
	// Fields
	[CompilerGenerated]
	private uint <DeviceIndex>k__BackingField; // 0x0

	// Properties
	public uint DeviceIndex { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public uint get_DeviceIndex() { }

	[CompilerGenerated]
	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_DeviceIndex(uint value) { }
}

// Namespace: Epic.OnlineServices.RTCAudio
internal struct CopyOutputDeviceInformationByIndexOptionsInternal : ISettable<CopyOutputDeviceInformationByIndexOptions>, IDisposable // TypeDefIndex: 8521
{
	// Fields
	private int m_ApiVersion; // 0x0
	private uint m_DeviceIndex; // 0x4

	// Properties
	public uint DeviceIndex { set; }

	// Methods

	// RVA: 0x3F84A0 Offset: 0x3F76A0 VA: 0x1803F84A0
	public void set_DeviceIndex(uint value) { }

	// RVA: 0x40B2E0 Offset: 0x40A4E0 VA: 0x18040B2E0 Slot: 4
	public void Set(ref CopyOutputDeviceInformationByIndexOptions other) { }

	// RVA: 0x475C10 Offset: 0x474E10 VA: 0x180475C10 Slot: 5
	public void Set(ref Nullable<CopyOutputDeviceInformationByIndexOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.RTCAudio
public struct GetAudioInputDeviceByIndexOptions // TypeDefIndex: 8522
{
	// Fields
	[CompilerGenerated]
	private uint <DeviceInfoIndex>k__BackingField; // 0x0

	// Properties
	public uint DeviceInfoIndex { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public uint get_DeviceInfoIndex() { }

	[CompilerGenerated]
	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_DeviceInfoIndex(uint value) { }
}

// Namespace: Epic.OnlineServices.RTCAudio
internal struct GetAudioInputDeviceByIndexOptionsInternal : ISettable<GetAudioInputDeviceByIndexOptions>, IDisposable // TypeDefIndex: 8523
{
	// Fields
	private int m_ApiVersion; // 0x0
	private uint m_DeviceInfoIndex; // 0x4

	// Properties
	public uint DeviceInfoIndex { set; }

	// Methods

	// RVA: 0x3F84A0 Offset: 0x3F76A0 VA: 0x1803F84A0
	public void set_DeviceInfoIndex(uint value) { }

	// RVA: 0x40B2E0 Offset: 0x40A4E0 VA: 0x18040B2E0 Slot: 4
	public void Set(ref GetAudioInputDeviceByIndexOptions other) { }

	// RVA: 0x477180 Offset: 0x476380 VA: 0x180477180 Slot: 5
	public void Set(ref Nullable<GetAudioInputDeviceByIndexOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.RTCAudio
public struct GetAudioInputDevicesCountOptions // TypeDefIndex: 8524
{}

// Namespace: Epic.OnlineServices.RTCAudio
internal struct GetAudioInputDevicesCountOptionsInternal : ISettable<GetAudioInputDevicesCountOptions>, IDisposable // TypeDefIndex: 8525
{
	// Fields
	private int m_ApiVersion; // 0x0

	// Methods

	// RVA: 0x3F98A0 Offset: 0x3F8AA0 VA: 0x1803F98A0 Slot: 4
	public void Set(ref GetAudioInputDevicesCountOptions other) { }

	// RVA: 0x4771E0 Offset: 0x4763E0 VA: 0x1804771E0 Slot: 5
	public void Set(ref Nullable<GetAudioInputDevicesCountOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.RTCAudio
public struct GetAudioOutputDeviceByIndexOptions // TypeDefIndex: 8526
{
	// Fields
	[CompilerGenerated]
	private uint <DeviceInfoIndex>k__BackingField; // 0x0

	// Properties
	public uint DeviceInfoIndex { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public uint get_DeviceInfoIndex() { }

	[CompilerGenerated]
	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_DeviceInfoIndex(uint value) { }
}

// Namespace: Epic.OnlineServices.RTCAudio
internal struct GetAudioOutputDeviceByIndexOptionsInternal : ISettable<GetAudioOutputDeviceByIndexOptions>, IDisposable // TypeDefIndex: 8527
{
	// Fields
	private int m_ApiVersion; // 0x0
	private uint m_DeviceInfoIndex; // 0x4

	// Properties
	public uint DeviceInfoIndex { set; }

	// Methods

	// RVA: 0x3F84A0 Offset: 0x3F76A0 VA: 0x1803F84A0
	public void set_DeviceInfoIndex(uint value) { }

	// RVA: 0x40B2E0 Offset: 0x40A4E0 VA: 0x18040B2E0 Slot: 4
	public void Set(ref GetAudioOutputDeviceByIndexOptions other) { }

	// RVA: 0x477230 Offset: 0x476430 VA: 0x180477230 Slot: 5
	public void Set(ref Nullable<GetAudioOutputDeviceByIndexOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.RTCAudio
public struct GetAudioOutputDevicesCountOptions // TypeDefIndex: 8528
{}

// Namespace: Epic.OnlineServices.RTCAudio
internal struct GetAudioOutputDevicesCountOptionsInternal : ISettable<GetAudioOutputDevicesCountOptions>, IDisposable // TypeDefIndex: 8529
{
	// Fields
	private int m_ApiVersion; // 0x0

	// Methods

	// RVA: 0x3F98A0 Offset: 0x3F8AA0 VA: 0x1803F98A0 Slot: 4
	public void Set(ref GetAudioOutputDevicesCountOptions other) { }

	// RVA: 0x477290 Offset: 0x476490 VA: 0x180477290 Slot: 5
	public void Set(ref Nullable<GetAudioOutputDevicesCountOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.RTCAudio
public struct GetInputDevicesCountOptions // TypeDefIndex: 8530
{}

// Namespace: Epic.OnlineServices.RTCAudio
internal struct GetInputDevicesCountOptionsInternal : ISettable<GetInputDevicesCountOptions>, IDisposable // TypeDefIndex: 8531
{
	// Fields
	private int m_ApiVersion; // 0x0

	// Methods

	// RVA: 0x3F98A0 Offset: 0x3F8AA0 VA: 0x1803F98A0 Slot: 4
	public void Set(ref GetInputDevicesCountOptions other) { }

	// RVA: 0x4772E0 Offset: 0x4764E0 VA: 0x1804772E0 Slot: 5
	public void Set(ref Nullable<GetInputDevicesCountOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.RTCAudio
public struct GetOutputDevicesCountOptions // TypeDefIndex: 8532
{}

// Namespace: Epic.OnlineServices.RTCAudio
internal struct GetOutputDevicesCountOptionsInternal : ISettable<GetOutputDevicesCountOptions>, IDisposable // TypeDefIndex: 8533
{
	// Fields
	private int m_ApiVersion; // 0x0

	// Methods

	// RVA: 0x3F98A0 Offset: 0x3F8AA0 VA: 0x1803F98A0 Slot: 4
	public void Set(ref GetOutputDevicesCountOptions other) { }

	// RVA: 0x477330 Offset: 0x476530 VA: 0x180477330 Slot: 5
	public void Set(ref Nullable<GetOutputDevicesCountOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.RTCAudio
public struct InputDeviceInformation // TypeDefIndex: 8534
{
	// Fields
	[CompilerGenerated]
	private bool <DefaultDevice>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <DeviceId>k__BackingField; // 0x8
	[CompilerGenerated]
	private Utf8String <DeviceName>k__BackingField; // 0x10

	// Properties
	public bool DefaultDevice { get; set; }
	public Utf8String DeviceId { get; set; }
	public Utf8String DeviceName { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x41D600 Offset: 0x41C800 VA: 0x18041D600
	public bool get_DefaultDevice() { }

	[CompilerGenerated]
	// RVA: 0x41D610 Offset: 0x41C810 VA: 0x18041D610
	public void set_DefaultDevice(bool value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public Utf8String get_DeviceId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_DeviceId(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Utf8String get_DeviceName() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_DeviceName(Utf8String value) { }

	// RVA: 0x477A70 Offset: 0x476C70 VA: 0x180477A70
	internal void Set(ref InputDeviceInformationInternal other) { }
}

// Namespace: Epic.OnlineServices.RTCAudio
internal struct InputDeviceInformationInternal : IGettable<InputDeviceInformation>, ISettable<InputDeviceInformation>, IDisposable // TypeDefIndex: 8535
{
	// Fields
	private int m_ApiVersion; // 0x0
	private int m_DefaultDevice; // 0x4
	private IntPtr m_DeviceId; // 0x8
	private IntPtr m_DeviceName; // 0x10

	// Properties
	public bool DefaultDevice { get; set; }
	public Utf8String DeviceId { get; set; }
	public Utf8String DeviceName { get; set; }

	// Methods

	// RVA: 0x477810 Offset: 0x476A10 VA: 0x180477810
	public bool get_DefaultDevice() { }

	// RVA: 0x477950 Offset: 0x476B50 VA: 0x180477950
	public void set_DefaultDevice(bool value) { }

	// RVA: 0x477870 Offset: 0x476A70 VA: 0x180477870
	public Utf8String get_DeviceId() { }

	// RVA: 0x4779B0 Offset: 0x476BB0 VA: 0x1804779B0
	public void set_DeviceId(Utf8String value) { }

	// RVA: 0x4778E0 Offset: 0x476AE0 VA: 0x1804778E0
	public Utf8String get_DeviceName() { }

	// RVA: 0x477A10 Offset: 0x476C10 VA: 0x180477A10
	public void set_DeviceName(Utf8String value) { }

	// RVA: 0x4775B0 Offset: 0x4767B0 VA: 0x1804775B0 Slot: 5
	public void Set(ref InputDeviceInformation other) { }

	// RVA: 0x4776B0 Offset: 0x4768B0 VA: 0x1804776B0 Slot: 6
	public void Set(ref Nullable<InputDeviceInformation> other) { }

	// RVA: 0x477530 Offset: 0x476730 VA: 0x180477530 Slot: 7
	public void Dispose() { }

	// RVA: 0x477590 Offset: 0x476790 VA: 0x180477590 Slot: 4
	public void Get(out InputDeviceInformation output) { }
}

// Namespace: Epic.OnlineServices.RTCAudio
public sealed class OnAudioBeforeRenderCallback : MulticastDelegate // TypeDefIndex: 8536
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref AudioBeforeRenderCallbackInfo data) { }

	// RVA: 0x477C30 Offset: 0x476E30 VA: 0x180477C30 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref AudioBeforeRenderCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref AudioBeforeRenderCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.RTCAudio
[UnmanagedFunctionPointer(2)]
internal sealed class OnAudioBeforeRenderCallbackInternal : MulticastDelegate // TypeDefIndex: 8537
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref AudioBeforeRenderCallbackInfoInternal data) { }

	// RVA: 0x477BA0 Offset: 0x476DA0 VA: 0x180477BA0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref AudioBeforeRenderCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref AudioBeforeRenderCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.RTCAudio
public sealed class OnAudioBeforeSendCallback : MulticastDelegate // TypeDefIndex: 8538
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref AudioBeforeSendCallbackInfo data) { }

	// RVA: 0x477D50 Offset: 0x476F50 VA: 0x180477D50 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref AudioBeforeSendCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref AudioBeforeSendCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.RTCAudio
[UnmanagedFunctionPointer(2)]
internal sealed class OnAudioBeforeSendCallbackInternal : MulticastDelegate // TypeDefIndex: 8539
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref AudioBeforeSendCallbackInfoInternal data) { }

	// RVA: 0x477CC0 Offset: 0x476EC0 VA: 0x180477CC0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref AudioBeforeSendCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref AudioBeforeSendCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.RTCAudio
public sealed class OnAudioDevicesChangedCallback : MulticastDelegate // TypeDefIndex: 8540
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref AudioDevicesChangedCallbackInfo data) { }

	// RVA: 0x477E70 Offset: 0x477070 VA: 0x180477E70 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref AudioDevicesChangedCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref AudioDevicesChangedCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.RTCAudio
[UnmanagedFunctionPointer(2)]
internal sealed class OnAudioDevicesChangedCallbackInternal : MulticastDelegate // TypeDefIndex: 8541
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref AudioDevicesChangedCallbackInfoInternal data) { }

	// RVA: 0x477DE0 Offset: 0x476FE0 VA: 0x180477DE0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref AudioDevicesChangedCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref AudioDevicesChangedCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.RTCAudio
public sealed class OnAudioInputStateCallback : MulticastDelegate // TypeDefIndex: 8542
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref AudioInputStateCallbackInfo data) { }

	// RVA: 0x477F90 Offset: 0x477190 VA: 0x180477F90 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref AudioInputStateCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref AudioInputStateCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.RTCAudio
[UnmanagedFunctionPointer(2)]
internal sealed class OnAudioInputStateCallbackInternal : MulticastDelegate // TypeDefIndex: 8543
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref AudioInputStateCallbackInfoInternal data) { }

	// RVA: 0x477F00 Offset: 0x477100 VA: 0x180477F00 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref AudioInputStateCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref AudioInputStateCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.RTCAudio
public sealed class OnAudioOutputStateCallback : MulticastDelegate // TypeDefIndex: 8544
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref AudioOutputStateCallbackInfo data) { }

	// RVA: 0x4780B0 Offset: 0x4772B0 VA: 0x1804780B0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref AudioOutputStateCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref AudioOutputStateCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.RTCAudio
[UnmanagedFunctionPointer(2)]
internal sealed class OnAudioOutputStateCallbackInternal : MulticastDelegate // TypeDefIndex: 8545
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref AudioOutputStateCallbackInfoInternal data) { }

	// RVA: 0x478020 Offset: 0x477220 VA: 0x180478020 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref AudioOutputStateCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref AudioOutputStateCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.RTCAudio
public sealed class OnParticipantUpdatedCallback : MulticastDelegate // TypeDefIndex: 8546
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref ParticipantUpdatedCallbackInfo data) { }

	// RVA: 0x478410 Offset: 0x477610 VA: 0x180478410 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref ParticipantUpdatedCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref ParticipantUpdatedCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.RTCAudio
[UnmanagedFunctionPointer(2)]
internal sealed class OnParticipantUpdatedCallbackInternal : MulticastDelegate // TypeDefIndex: 8547
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref ParticipantUpdatedCallbackInfoInternal data) { }

	// RVA: 0x4782F0 Offset: 0x4774F0 VA: 0x1804782F0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref ParticipantUpdatedCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref ParticipantUpdatedCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.RTCAudio
public sealed class OnQueryInputDevicesInformationCallback : MulticastDelegate // TypeDefIndex: 8548
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref OnQueryInputDevicesInformationCallbackInfo data) { }

	// RVA: 0x478980 Offset: 0x477B80 VA: 0x180478980 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref OnQueryInputDevicesInformationCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref OnQueryInputDevicesInformationCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.RTCAudio
[UnmanagedFunctionPointer(2)]
internal sealed class OnQueryInputDevicesInformationCallbackInternal : MulticastDelegate // TypeDefIndex: 8549
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref OnQueryInputDevicesInformationCallbackInfoInternal data) { }

	// RVA: 0x4788F0 Offset: 0x477AF0 VA: 0x1804788F0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref OnQueryInputDevicesInformationCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref OnQueryInputDevicesInformationCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.RTCAudio
public struct OnQueryInputDevicesInformationCallbackInfo : ICallbackInfo // TypeDefIndex: 8550
{
	// Fields
	[CompilerGenerated]
	private Result <ResultCode>k__BackingField; // 0x0
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x8

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	[CompilerGenerated]
	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public object get_ClientData() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_ClientData(object value) { }

	// RVA: 0x478820 Offset: 0x477A20 VA: 0x180478820 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x478870 Offset: 0x477A70 VA: 0x180478870
	internal void Set(ref OnQueryInputDevicesInformationCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.RTCAudio
internal struct OnQueryInputDevicesInformationCallbackInfoInternal : ICallbackInfoInternal, IGettable<OnQueryInputDevicesInformationCallbackInfo>, ISettable<OnQueryInputDevicesInformationCallbackInfo>, IDisposable // TypeDefIndex: 8551
{
	// Fields
	private Result m_ResultCode; // 0x0
	private IntPtr m_ClientData; // 0x8

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }

	// Methods

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	// RVA: 0x478750 Offset: 0x477950 VA: 0x180478750
	public object get_ClientData() { }

	// RVA: 0x4787C0 Offset: 0x4779C0 VA: 0x1804787C0
	public void set_ClientData(object value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x478630 Offset: 0x477830 VA: 0x180478630 Slot: 6
	public void Set(ref OnQueryInputDevicesInformationCallbackInfo other) { }

	// RVA: 0x478690 Offset: 0x477890 VA: 0x180478690 Slot: 7
	public void Set(ref Nullable<OnQueryInputDevicesInformationCallbackInfo> other) { }

	// RVA: 0x4785C0 Offset: 0x4777C0 VA: 0x1804785C0 Slot: 8
	public void Dispose() { }

	// RVA: 0x478610 Offset: 0x477810 VA: 0x180478610 Slot: 5
	public void Get(out OnQueryInputDevicesInformationCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.RTCAudio
public sealed class OnQueryOutputDevicesInformationCallback : MulticastDelegate // TypeDefIndex: 8552
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref OnQueryOutputDevicesInformationCallbackInfo data) { }

	// RVA: 0x478DD0 Offset: 0x477FD0 VA: 0x180478DD0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref OnQueryOutputDevicesInformationCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref OnQueryOutputDevicesInformationCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.RTCAudio
[UnmanagedFunctionPointer(2)]
internal sealed class OnQueryOutputDevicesInformationCallbackInternal : MulticastDelegate // TypeDefIndex: 8553
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref OnQueryOutputDevicesInformationCallbackInfoInternal data) { }

	// RVA: 0x478D40 Offset: 0x477F40 VA: 0x180478D40 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref OnQueryOutputDevicesInformationCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref OnQueryOutputDevicesInformationCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.RTCAudio
public struct OnQueryOutputDevicesInformationCallbackInfo : ICallbackInfo // TypeDefIndex: 8554
{
	// Fields
	[CompilerGenerated]
	private Result <ResultCode>k__BackingField; // 0x0
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x8

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	[CompilerGenerated]
	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public object get_ClientData() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_ClientData(object value) { }

	// RVA: 0x478C70 Offset: 0x477E70 VA: 0x180478C70 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x478CC0 Offset: 0x477EC0 VA: 0x180478CC0
	internal void Set(ref OnQueryOutputDevicesInformationCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.RTCAudio
internal struct OnQueryOutputDevicesInformationCallbackInfoInternal : ICallbackInfoInternal, IGettable<OnQueryOutputDevicesInformationCallbackInfo>, ISettable<OnQueryOutputDevicesInformationCallbackInfo>, IDisposable // TypeDefIndex: 8555
{
	// Fields
	private Result m_ResultCode; // 0x0
	private IntPtr m_ClientData; // 0x8

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }

	// Methods

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	// RVA: 0x478BA0 Offset: 0x477DA0 VA: 0x180478BA0
	public object get_ClientData() { }

	// RVA: 0x478C10 Offset: 0x477E10 VA: 0x180478C10
	public void set_ClientData(object value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x478A80 Offset: 0x477C80 VA: 0x180478A80 Slot: 6
	public void Set(ref OnQueryOutputDevicesInformationCallbackInfo other) { }

	// RVA: 0x478AE0 Offset: 0x477CE0 VA: 0x180478AE0 Slot: 7
	public void Set(ref Nullable<OnQueryOutputDevicesInformationCallbackInfo> other) { }

	// RVA: 0x478A10 Offset: 0x477C10 VA: 0x180478A10 Slot: 8
	public void Dispose() { }

	// RVA: 0x478A60 Offset: 0x477C60 VA: 0x180478A60 Slot: 5
	public void Get(out OnQueryOutputDevicesInformationCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.RTCAudio
public sealed class OnRegisterPlatformUserCallback : MulticastDelegate // TypeDefIndex: 8556
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref OnRegisterPlatformUserCallbackInfo data) { }

	// RVA: 0x479410 Offset: 0x478610 VA: 0x180479410 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref OnRegisterPlatformUserCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref OnRegisterPlatformUserCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.RTCAudio
[UnmanagedFunctionPointer(2)]
internal sealed class OnRegisterPlatformUserCallbackInternal : MulticastDelegate // TypeDefIndex: 8557
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref OnRegisterPlatformUserCallbackInfoInternal data) { }

	// RVA: 0x479380 Offset: 0x478580 VA: 0x180479380 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref OnRegisterPlatformUserCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref OnRegisterPlatformUserCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.RTCAudio
public struct OnRegisterPlatformUserCallbackInfo : ICallbackInfo // TypeDefIndex: 8558
{
	// Fields
	[CompilerGenerated]
	private Result <ResultCode>k__BackingField; // 0x0
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x8
	[CompilerGenerated]
	private Utf8String <PlatformUserId>k__BackingField; // 0x10

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public Utf8String PlatformUserId { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	[CompilerGenerated]
	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public object get_ClientData() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_ClientData(object value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Utf8String get_PlatformUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_PlatformUserId(Utf8String value) { }

	// RVA: 0x479250 Offset: 0x478450 VA: 0x180479250 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x4792A0 Offset: 0x4784A0 VA: 0x1804792A0
	internal void Set(ref OnRegisterPlatformUserCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.RTCAudio
internal struct OnRegisterPlatformUserCallbackInfoInternal : ICallbackInfoInternal, IGettable<OnRegisterPlatformUserCallbackInfo>, ISettable<OnRegisterPlatformUserCallbackInfo>, IDisposable // TypeDefIndex: 8559
{
	// Fields
	private Result m_ResultCode; // 0x0
	private IntPtr m_ClientData; // 0x8
	private IntPtr m_PlatformUserId; // 0x10

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public Utf8String PlatformUserId { get; set; }

	// Methods

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	// RVA: 0x4790B0 Offset: 0x4782B0 VA: 0x1804790B0
	public object get_ClientData() { }

	// RVA: 0x479190 Offset: 0x478390 VA: 0x180479190
	public void set_ClientData(object value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x479120 Offset: 0x478320 VA: 0x180479120
	public Utf8String get_PlatformUserId() { }

	// RVA: 0x4791F0 Offset: 0x4783F0 VA: 0x1804791F0
	public void set_PlatformUserId(Utf8String value) { }

	// RVA: 0x478EE0 Offset: 0x4780E0 VA: 0x180478EE0 Slot: 6
	public void Set(ref OnRegisterPlatformUserCallbackInfo other) { }

	// RVA: 0x478F90 Offset: 0x478190 VA: 0x180478F90 Slot: 7
	public void Set(ref Nullable<OnRegisterPlatformUserCallbackInfo> other) { }

	// RVA: 0x478E60 Offset: 0x478060 VA: 0x180478E60 Slot: 8
	public void Dispose() { }

	// RVA: 0x478EC0 Offset: 0x4780C0 VA: 0x180478EC0 Slot: 5
	public void Get(out OnRegisterPlatformUserCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.RTCAudio
public sealed class OnSetInputDeviceSettingsCallback : MulticastDelegate // TypeDefIndex: 8560
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref OnSetInputDeviceSettingsCallbackInfo data) { }

	// RVA: 0x479A50 Offset: 0x478C50 VA: 0x180479A50 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref OnSetInputDeviceSettingsCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref OnSetInputDeviceSettingsCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.RTCAudio
[UnmanagedFunctionPointer(2)]
internal sealed class OnSetInputDeviceSettingsCallbackInternal : MulticastDelegate // TypeDefIndex: 8561
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref OnSetInputDeviceSettingsCallbackInfoInternal data) { }

	// RVA: 0x4799C0 Offset: 0x478BC0 VA: 0x1804799C0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref OnSetInputDeviceSettingsCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref OnSetInputDeviceSettingsCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.RTCAudio
public struct OnSetInputDeviceSettingsCallbackInfo : ICallbackInfo // TypeDefIndex: 8562
{
	// Fields
	[CompilerGenerated]
	private Result <ResultCode>k__BackingField; // 0x0
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x8
	[CompilerGenerated]
	private Utf8String <RealDeviceId>k__BackingField; // 0x10

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public Utf8String RealDeviceId { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	[CompilerGenerated]
	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public object get_ClientData() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_ClientData(object value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Utf8String get_RealDeviceId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_RealDeviceId(Utf8String value) { }

	// RVA: 0x479890 Offset: 0x478A90 VA: 0x180479890 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x4798E0 Offset: 0x478AE0 VA: 0x1804798E0
	internal void Set(ref OnSetInputDeviceSettingsCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.RTCAudio
internal struct OnSetInputDeviceSettingsCallbackInfoInternal : ICallbackInfoInternal, IGettable<OnSetInputDeviceSettingsCallbackInfo>, ISettable<OnSetInputDeviceSettingsCallbackInfo>, IDisposable // TypeDefIndex: 8563
{
	// Fields
	private Result m_ResultCode; // 0x0
	private IntPtr m_ClientData; // 0x8
	private IntPtr m_RealDeviceId; // 0x10

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public Utf8String RealDeviceId { get; set; }

	// Methods

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	// RVA: 0x4796F0 Offset: 0x4788F0 VA: 0x1804796F0
	public object get_ClientData() { }

	// RVA: 0x4797D0 Offset: 0x4789D0 VA: 0x1804797D0
	public void set_ClientData(object value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x479760 Offset: 0x478960 VA: 0x180479760
	public Utf8String get_RealDeviceId() { }

	// RVA: 0x479830 Offset: 0x478A30 VA: 0x180479830
	public void set_RealDeviceId(Utf8String value) { }

	// RVA: 0x479640 Offset: 0x478840 VA: 0x180479640 Slot: 6
	public void Set(ref OnSetInputDeviceSettingsCallbackInfo other) { }

	// RVA: 0x479520 Offset: 0x478720 VA: 0x180479520 Slot: 7
	public void Set(ref Nullable<OnSetInputDeviceSettingsCallbackInfo> other) { }

	// RVA: 0x4794A0 Offset: 0x4786A0 VA: 0x1804794A0 Slot: 8
	public void Dispose() { }

	// RVA: 0x479500 Offset: 0x478700 VA: 0x180479500 Slot: 5
	public void Get(out OnSetInputDeviceSettingsCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.RTCAudio
public sealed class OnSetOutputDeviceSettingsCallback : MulticastDelegate // TypeDefIndex: 8564
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref OnSetOutputDeviceSettingsCallbackInfo data) { }

	// RVA: 0x47A090 Offset: 0x479290 VA: 0x18047A090 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref OnSetOutputDeviceSettingsCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref OnSetOutputDeviceSettingsCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.RTCAudio
[UnmanagedFunctionPointer(2)]
internal sealed class OnSetOutputDeviceSettingsCallbackInternal : MulticastDelegate // TypeDefIndex: 8565
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref OnSetOutputDeviceSettingsCallbackInfoInternal data) { }

	// RVA: 0x47A000 Offset: 0x479200 VA: 0x18047A000 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref OnSetOutputDeviceSettingsCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref OnSetOutputDeviceSettingsCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.RTCAudio
public struct OnSetOutputDeviceSettingsCallbackInfo : ICallbackInfo // TypeDefIndex: 8566
{
	// Fields
	[CompilerGenerated]
	private Result <ResultCode>k__BackingField; // 0x0
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x8
	[CompilerGenerated]
	private Utf8String <RealDeviceId>k__BackingField; // 0x10

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public Utf8String RealDeviceId { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	[CompilerGenerated]
	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public object get_ClientData() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_ClientData(object value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Utf8String get_RealDeviceId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_RealDeviceId(Utf8String value) { }

	// RVA: 0x479ED0 Offset: 0x4790D0 VA: 0x180479ED0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x479F20 Offset: 0x479120 VA: 0x180479F20
	internal void Set(ref OnSetOutputDeviceSettingsCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.RTCAudio
internal struct OnSetOutputDeviceSettingsCallbackInfoInternal : ICallbackInfoInternal, IGettable<OnSetOutputDeviceSettingsCallbackInfo>, ISettable<OnSetOutputDeviceSettingsCallbackInfo>, IDisposable // TypeDefIndex: 8567
{
	// Fields
	private Result m_ResultCode; // 0x0
	private IntPtr m_ClientData; // 0x8
	private IntPtr m_RealDeviceId; // 0x10

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public Utf8String RealDeviceId { get; set; }

	// Methods

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	// RVA: 0x479D30 Offset: 0x478F30 VA: 0x180479D30
	public object get_ClientData() { }

	// RVA: 0x479E10 Offset: 0x479010 VA: 0x180479E10
	public void set_ClientData(object value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x479DA0 Offset: 0x478FA0 VA: 0x180479DA0
	public Utf8String get_RealDeviceId() { }

	// RVA: 0x479E70 Offset: 0x479070 VA: 0x180479E70
	public void set_RealDeviceId(Utf8String value) { }

	// RVA: 0x479C80 Offset: 0x478E80 VA: 0x180479C80 Slot: 6
	public void Set(ref OnSetOutputDeviceSettingsCallbackInfo other) { }

	// RVA: 0x479B60 Offset: 0x478D60 VA: 0x180479B60 Slot: 7
	public void Set(ref Nullable<OnSetOutputDeviceSettingsCallbackInfo> other) { }

	// RVA: 0x479AE0 Offset: 0x478CE0 VA: 0x180479AE0 Slot: 8
	public void Dispose() { }

	// RVA: 0x479B40 Offset: 0x478D40 VA: 0x180479B40 Slot: 5
	public void Get(out OnSetOutputDeviceSettingsCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.RTCAudio
public sealed class OnUnregisterPlatformUserCallback : MulticastDelegate // TypeDefIndex: 8568
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref OnUnregisterPlatformUserCallbackInfo data) { }

	// RVA: 0x47A6D0 Offset: 0x4798D0 VA: 0x18047A6D0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref OnUnregisterPlatformUserCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref OnUnregisterPlatformUserCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.RTCAudio
[UnmanagedFunctionPointer(2)]
internal sealed class OnUnregisterPlatformUserCallbackInternal : MulticastDelegate // TypeDefIndex: 8569
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref OnUnregisterPlatformUserCallbackInfoInternal data) { }

	// RVA: 0x47A640 Offset: 0x479840 VA: 0x18047A640 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref OnUnregisterPlatformUserCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref OnUnregisterPlatformUserCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.RTCAudio
public struct OnUnregisterPlatformUserCallbackInfo : ICallbackInfo // TypeDefIndex: 8570
{
	// Fields
	[CompilerGenerated]
	private Result <ResultCode>k__BackingField; // 0x0
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x8
	[CompilerGenerated]
	private Utf8String <PlatformUserId>k__BackingField; // 0x10

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public Utf8String PlatformUserId { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	[CompilerGenerated]
	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public object get_ClientData() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_ClientData(object value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Utf8String get_PlatformUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_PlatformUserId(Utf8String value) { }

	// RVA: 0x47A510 Offset: 0x479710 VA: 0x18047A510 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x47A560 Offset: 0x479760 VA: 0x18047A560
	internal void Set(ref OnUnregisterPlatformUserCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.RTCAudio
internal struct OnUnregisterPlatformUserCallbackInfoInternal : ICallbackInfoInternal, IGettable<OnUnregisterPlatformUserCallbackInfo>, ISettable<OnUnregisterPlatformUserCallbackInfo>, IDisposable // TypeDefIndex: 8571
{
	// Fields
	private Result m_ResultCode; // 0x0
	private IntPtr m_ClientData; // 0x8
	private IntPtr m_PlatformUserId; // 0x10

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public Utf8String PlatformUserId { get; set; }

	// Methods

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	// RVA: 0x47A370 Offset: 0x479570 VA: 0x18047A370
	public object get_ClientData() { }

	// RVA: 0x47A450 Offset: 0x479650 VA: 0x18047A450
	public void set_ClientData(object value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x47A3E0 Offset: 0x4795E0 VA: 0x18047A3E0
	public Utf8String get_PlatformUserId() { }

	// RVA: 0x47A4B0 Offset: 0x4796B0 VA: 0x18047A4B0
	public void set_PlatformUserId(Utf8String value) { }

	// RVA: 0x47A1A0 Offset: 0x4793A0 VA: 0x18047A1A0 Slot: 6
	public void Set(ref OnUnregisterPlatformUserCallbackInfo other) { }

	// RVA: 0x47A250 Offset: 0x479450 VA: 0x18047A250 Slot: 7
	public void Set(ref Nullable<OnUnregisterPlatformUserCallbackInfo> other) { }

	// RVA: 0x47A120 Offset: 0x479320 VA: 0x18047A120 Slot: 8
	public void Dispose() { }

	// RVA: 0x47A180 Offset: 0x479380 VA: 0x18047A180 Slot: 5
	public void Get(out OnUnregisterPlatformUserCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.RTCAudio
public sealed class OnUpdateParticipantVolumeCallback : MulticastDelegate // TypeDefIndex: 8572
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref UpdateParticipantVolumeCallbackInfo data) { }

	// RVA: 0x47A7F0 Offset: 0x4799F0 VA: 0x18047A7F0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref UpdateParticipantVolumeCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref UpdateParticipantVolumeCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.RTCAudio
[UnmanagedFunctionPointer(2)]
internal sealed class OnUpdateParticipantVolumeCallbackInternal : MulticastDelegate // TypeDefIndex: 8573
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref UpdateParticipantVolumeCallbackInfoInternal data) { }

	// RVA: 0x47A760 Offset: 0x479960 VA: 0x18047A760 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref UpdateParticipantVolumeCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref UpdateParticipantVolumeCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.RTCAudio
public sealed class OnUpdateReceivingCallback : MulticastDelegate // TypeDefIndex: 8574
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref UpdateReceivingCallbackInfo data) { }

	// RVA: 0x47A9A0 Offset: 0x479BA0 VA: 0x18047A9A0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref UpdateReceivingCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref UpdateReceivingCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.RTCAudio
[UnmanagedFunctionPointer(2)]
internal sealed class OnUpdateReceivingCallbackInternal : MulticastDelegate // TypeDefIndex: 8575
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref UpdateReceivingCallbackInfoInternal data) { }

	// RVA: 0x47A910 Offset: 0x479B10 VA: 0x18047A910 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref UpdateReceivingCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref UpdateReceivingCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.RTCAudio
public sealed class OnUpdateReceivingVolumeCallback : MulticastDelegate // TypeDefIndex: 8576
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref UpdateReceivingVolumeCallbackInfo data) { }

	// RVA: 0x47AB50 Offset: 0x479D50 VA: 0x18047AB50 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref UpdateReceivingVolumeCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref UpdateReceivingVolumeCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.RTCAudio
[UnmanagedFunctionPointer(2)]
internal sealed class OnUpdateReceivingVolumeCallbackInternal : MulticastDelegate // TypeDefIndex: 8577
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref UpdateReceivingVolumeCallbackInfoInternal data) { }

	// RVA: 0x47AAC0 Offset: 0x479CC0 VA: 0x18047AAC0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref UpdateReceivingVolumeCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref UpdateReceivingVolumeCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.RTCAudio
public sealed class OnUpdateSendingCallback : MulticastDelegate // TypeDefIndex: 8578
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref UpdateSendingCallbackInfo data) { }

	// RVA: 0x47AD00 Offset: 0x479F00 VA: 0x18047AD00 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref UpdateSendingCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref UpdateSendingCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.RTCAudio
[UnmanagedFunctionPointer(2)]
internal sealed class OnUpdateSendingCallbackInternal : MulticastDelegate // TypeDefIndex: 8579
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref UpdateSendingCallbackInfoInternal data) { }

	// RVA: 0x47AC70 Offset: 0x479E70 VA: 0x18047AC70 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref UpdateSendingCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref UpdateSendingCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.RTCAudio
public sealed class OnUpdateSendingVolumeCallback : MulticastDelegate // TypeDefIndex: 8580
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref UpdateSendingVolumeCallbackInfo data) { }

	// RVA: 0x47AEB0 Offset: 0x47A0B0 VA: 0x18047AEB0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref UpdateSendingVolumeCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref UpdateSendingVolumeCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.RTCAudio
[UnmanagedFunctionPointer(2)]
internal sealed class OnUpdateSendingVolumeCallbackInternal : MulticastDelegate // TypeDefIndex: 8581
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref UpdateSendingVolumeCallbackInfoInternal data) { }

	// RVA: 0x47AE20 Offset: 0x47A020 VA: 0x18047AE20 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref UpdateSendingVolumeCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref UpdateSendingVolumeCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.RTCAudio
public struct OutputDeviceInformation // TypeDefIndex: 8582
{
	// Fields
	[CompilerGenerated]
	private bool <DefaultDevice>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <DeviceId>k__BackingField; // 0x8
	[CompilerGenerated]
	private Utf8String <DeviceName>k__BackingField; // 0x10

	// Properties
	public bool DefaultDevice { get; set; }
	public Utf8String DeviceId { get; set; }
	public Utf8String DeviceName { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x41D600 Offset: 0x41C800 VA: 0x18041D600
	public bool get_DefaultDevice() { }

	[CompilerGenerated]
	// RVA: 0x41D610 Offset: 0x41C810 VA: 0x18041D610
	public void set_DefaultDevice(bool value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public Utf8String get_DeviceId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_DeviceId(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Utf8String get_DeviceName() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_DeviceName(Utf8String value) { }

	// RVA: 0x47B480 Offset: 0x47A680 VA: 0x18047B480
	internal void Set(ref OutputDeviceInformationInternal other) { }
}

// Namespace: Epic.OnlineServices.RTCAudio
internal struct OutputDeviceInformationInternal : IGettable<OutputDeviceInformation>, ISettable<OutputDeviceInformation>, IDisposable // TypeDefIndex: 8583
{
	// Fields
	private int m_ApiVersion; // 0x0
	private int m_DefaultDevice; // 0x4
	private IntPtr m_DeviceId; // 0x8
	private IntPtr m_DeviceName; // 0x10

	// Properties
	public bool DefaultDevice { get; set; }
	public Utf8String DeviceId { get; set; }
	public Utf8String DeviceName { get; set; }

	// Methods

	// RVA: 0x47B220 Offset: 0x47A420 VA: 0x18047B220
	public bool get_DefaultDevice() { }

	// RVA: 0x47B360 Offset: 0x47A560 VA: 0x18047B360
	public void set_DefaultDevice(bool value) { }

	// RVA: 0x47B280 Offset: 0x47A480 VA: 0x18047B280
	public Utf8String get_DeviceId() { }

	// RVA: 0x47B3C0 Offset: 0x47A5C0 VA: 0x18047B3C0
	public void set_DeviceId(Utf8String value) { }

	// RVA: 0x47B2F0 Offset: 0x47A4F0 VA: 0x18047B2F0
	public Utf8String get_DeviceName() { }

	// RVA: 0x47B420 Offset: 0x47A620 VA: 0x18047B420
	public void set_DeviceName(Utf8String value) { }

	// RVA: 0x47AFC0 Offset: 0x47A1C0 VA: 0x18047AFC0 Slot: 5
	public void Set(ref OutputDeviceInformation other) { }

	// RVA: 0x47B0C0 Offset: 0x47A2C0 VA: 0x18047B0C0 Slot: 6
	public void Set(ref Nullable<OutputDeviceInformation> other) { }

	// RVA: 0x47AF40 Offset: 0x47A140 VA: 0x18047AF40 Slot: 7
	public void Dispose() { }

	// RVA: 0x47AFA0 Offset: 0x47A1A0 VA: 0x18047AFA0 Slot: 4
	public void Get(out OutputDeviceInformation output) { }
}

// Namespace: Epic.OnlineServices.RTCAudio
public struct ParticipantUpdatedCallbackInfo : ICallbackInfo // TypeDefIndex: 8584
{
	// Fields
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x0
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x8
	[CompilerGenerated]
	private Utf8String <RoomName>k__BackingField; // 0x10
	[CompilerGenerated]
	private ProductUserId <ParticipantId>k__BackingField; // 0x18
	[CompilerGenerated]
	private bool <Speaking>k__BackingField; // 0x20
	[CompilerGenerated]
	private RTCAudioStatus <AudioStatus>k__BackingField; // 0x24

	// Properties
	public object ClientData { get; set; }
	public ProductUserId LocalUserId { get; set; }
	public Utf8String RoomName { get; set; }
	public ProductUserId ParticipantId { get; set; }
	public bool Speaking { get; set; }
	public RTCAudioStatus AudioStatus { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410 Slot: 4
	public object get_ClientData() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_ClientData(object value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_LocalUserId(ProductUserId value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Utf8String get_RoomName() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_RoomName(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public ProductUserId get_ParticipantId() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_ParticipantId(ProductUserId value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x4009D0 Offset: 0x3FFBD0 VA: 0x1804009D0
	public bool get_Speaking() { }

	[CompilerGenerated]
	// RVA: 0x4009E0 Offset: 0x3FFBE0 VA: 0x1804009E0
	public void set_Speaking(bool value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x47BD90 Offset: 0x47AF90 VA: 0x18047BD90
	public RTCAudioStatus get_AudioStatus() { }

	[CompilerGenerated]
	// RVA: 0x47C1C0 Offset: 0x47B3C0 VA: 0x18047C1C0
	public void set_AudioStatus(RTCAudioStatus value) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x47C530 Offset: 0x47B730 VA: 0x18047C530
	internal void Set(ref ParticipantUpdatedCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.RTCAudio
internal struct ParticipantUpdatedCallbackInfoInternal : ICallbackInfoInternal, IGettable<ParticipantUpdatedCallbackInfo>, ISettable<ParticipantUpdatedCallbackInfo>, IDisposable // TypeDefIndex: 8585
{
	// Fields
	private IntPtr m_ClientData; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_RoomName; // 0x10
	private IntPtr m_ParticipantId; // 0x18
	private int m_Speaking; // 0x20
	private RTCAudioStatus m_AudioStatus; // 0x24

	// Properties
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public ProductUserId LocalUserId { get; set; }
	public Utf8String RoomName { get; set; }
	public ProductUserId ParticipantId { get; set; }
	public bool Speaking { get; set; }
	public RTCAudioStatus AudioStatus { get; set; }

	// Methods

	// RVA: 0x47BE10 Offset: 0x47B010 VA: 0x18047BE10
	public object get_ClientData() { }

	// RVA: 0x47C230 Offset: 0x47B430 VA: 0x18047C230
	public void set_ClientData(object value) { }

	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x47BE80 Offset: 0x47B080 VA: 0x18047BE80
	public ProductUserId get_LocalUserId() { }

	// RVA: 0x47C2F0 Offset: 0x47B4F0 VA: 0x18047C2F0
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x47C080 Offset: 0x47B280 VA: 0x18047C080
	public Utf8String get_RoomName() { }

	// RVA: 0x47C470 Offset: 0x47B670 VA: 0x18047C470
	public void set_RoomName(Utf8String value) { }

	// RVA: 0x47BF80 Offset: 0x47B180 VA: 0x18047BF80
	public ProductUserId get_ParticipantId() { }

	// RVA: 0x47C350 Offset: 0x47B550 VA: 0x18047C350
	public void set_ParticipantId(ProductUserId value) { }

	// RVA: 0x47C160 Offset: 0x47B360 VA: 0x18047C160
	public bool get_Speaking() { }

	// RVA: 0x47C4D0 Offset: 0x47B6D0 VA: 0x18047C4D0
	public void set_Speaking(bool value) { }

	// RVA: 0x47BD90 Offset: 0x47AF90 VA: 0x18047BD90
	public RTCAudioStatus get_AudioStatus() { }

	// RVA: 0x47C1C0 Offset: 0x47B3C0 VA: 0x18047C1C0
	public void set_AudioStatus(RTCAudioStatus value) { }

	// RVA: 0x47B6F0 Offset: 0x47A8F0 VA: 0x18047B6F0 Slot: 6
	public void Set(ref ParticipantUpdatedCallbackInfo other) { }

	// RVA: 0x47BB70 Offset: 0x47AD70 VA: 0x18047BB70 Slot: 7
	public void Set(ref Nullable<ParticipantUpdatedCallbackInfo> other) { }

	// RVA: 0x47B620 Offset: 0x47A820 VA: 0x18047B620 Slot: 8
	public void Dispose() { }

	// RVA: 0x47B6C0 Offset: 0x47A8C0 VA: 0x18047B6C0 Slot: 5
	public void Get(out ParticipantUpdatedCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.RTCAudio
public struct QueryInputDevicesInformationOptions // TypeDefIndex: 8586
{}

// Namespace: Epic.OnlineServices.RTCAudio
internal struct QueryInputDevicesInformationOptionsInternal : ISettable<QueryInputDevicesInformationOptions>, IDisposable // TypeDefIndex: 8587
{
	// Fields
	private int m_ApiVersion; // 0x0

	// Methods

	// RVA: 0x3F98A0 Offset: 0x3F8AA0 VA: 0x1803F98A0 Slot: 4
	public void Set(ref QueryInputDevicesInformationOptions other) { }

	// RVA: 0x47D5F0 Offset: 0x47C7F0 VA: 0x18047D5F0 Slot: 5
	public void Set(ref Nullable<QueryInputDevicesInformationOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.RTCAudio
public struct QueryOutputDevicesInformationOptions // TypeDefIndex: 8588
{}

// Namespace: Epic.OnlineServices.RTCAudio
internal struct QueryOutputDevicesInformationOptionsInternal : ISettable<QueryOutputDevicesInformationOptions>, IDisposable // TypeDefIndex: 8589
{
	// Fields
	private int m_ApiVersion; // 0x0

	// Methods

	// RVA: 0x3F98A0 Offset: 0x3F8AA0 VA: 0x1803F98A0 Slot: 4
	public void Set(ref QueryOutputDevicesInformationOptions other) { }

	// RVA: 0x47D640 Offset: 0x47C840 VA: 0x18047D640 Slot: 5
	public void Set(ref Nullable<QueryOutputDevicesInformationOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.RTCAudio
public struct RegisterPlatformAudioUserOptions // TypeDefIndex: 8590
{
	// Fields
	[CompilerGenerated]
	private Utf8String <UserId>k__BackingField; // 0x0

	// Properties
	public Utf8String UserId { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Utf8String get_UserId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_UserId(Utf8String value) { }
}

// Namespace: Epic.OnlineServices.RTCAudio
internal struct RegisterPlatformAudioUserOptionsInternal : ISettable<RegisterPlatformAudioUserOptions>, IDisposable // TypeDefIndex: 8591
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_UserId; // 0x8

	// Properties
	public Utf8String UserId { set; }

	// Methods

	// RVA: 0x481850 Offset: 0x480A50 VA: 0x180481850
	public void set_UserId(Utf8String value) { }

	// RVA: 0x4817F0 Offset: 0x4809F0 VA: 0x1804817F0 Slot: 4
	public void Set(ref RegisterPlatformAudioUserOptions other) { }

	// RVA: 0x481750 Offset: 0x480950 VA: 0x180481750 Slot: 5
	public void Set(ref Nullable<RegisterPlatformAudioUserOptions> other) { }

	// RVA: 0x481700 Offset: 0x480900 VA: 0x180481700 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.RTCAudio
public struct RegisterPlatformUserOptions // TypeDefIndex: 8592
{
	// Fields
	[CompilerGenerated]
	private Utf8String <PlatformUserId>k__BackingField; // 0x0

	// Properties
	public Utf8String PlatformUserId { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Utf8String get_PlatformUserId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_PlatformUserId(Utf8String value) { }
}

// Namespace: Epic.OnlineServices.RTCAudio
internal struct RegisterPlatformUserOptionsInternal : ISettable<RegisterPlatformUserOptions>, IDisposable // TypeDefIndex: 8593
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_PlatformUserId; // 0x8

	// Properties
	public Utf8String PlatformUserId { set; }

	// Methods

	// RVA: 0x481A00 Offset: 0x480C00 VA: 0x180481A00
	public void set_PlatformUserId(Utf8String value) { }

	// RVA: 0x4819A0 Offset: 0x480BA0 VA: 0x1804819A0 Slot: 4
	public void Set(ref RegisterPlatformUserOptions other) { }

	// RVA: 0x481900 Offset: 0x480B00 VA: 0x180481900 Slot: 5
	public void Set(ref Nullable<RegisterPlatformUserOptions> other) { }

	// RVA: 0x4818B0 Offset: 0x480AB0 VA: 0x1804818B0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.RTCAudio
public enum RTCAudioInputStatus // TypeDefIndex: 8594
{
	// Fields
	public int value__; // 0x0
	public const RTCAudioInputStatus Idle = 0;
	public const RTCAudioInputStatus Recording = 1;
	public const RTCAudioInputStatus RecordingSilent = 2;
	public const RTCAudioInputStatus RecordingDisconnected = 3;
	public const RTCAudioInputStatus Failed = 4;
}

// Namespace: Epic.OnlineServices.RTCAudio
public sealed class RTCAudioInterface : Handle // TypeDefIndex: 8595
{
	// Fields
	public const int AddnotifyaudiobeforerenderApiLatest = 1;
	public const int AddnotifyaudiobeforesendApiLatest = 1;
	public const int AddnotifyaudiodeviceschangedApiLatest = 1;
	public const int AddnotifyaudioinputstateApiLatest = 1;
	public const int AddnotifyaudiooutputstateApiLatest = 1;
	public const int AddnotifyparticipantupdatedApiLatest = 1;
	public const int AudiobufferApiLatest = 1;
	public const int AudioinputdeviceinfoApiLatest = 1;
	public const int AudiooutputdeviceinfoApiLatest = 1;
	public const int CopyinputdeviceinformationbyindexApiLatest = 1;
	public const int CopyoutputdeviceinformationbyindexApiLatest = 1;
	public const int GetaudioinputdevicebyindexApiLatest = 1;
	public const int GetaudioinputdevicescountApiLatest = 1;
	public const int GetaudiooutputdevicebyindexApiLatest = 1;
	public const int GetaudiooutputdevicescountApiLatest = 1;
	public const int GetinputdevicescountApiLatest = 1;
	public const int GetoutputdevicescountApiLatest = 1;
	public const int InputdeviceinformationApiLatest = 1;
	public const int OutputdeviceinformationApiLatest = 1;
	public const int QueryinputdevicesinformationApiLatest = 1;
	public const int QueryoutputdevicesinformationApiLatest = 1;
	public const int RegisterplatformaudiouserApiLatest = 1;
	public const int RegisterplatformuserApiLatest = 1;
	public const int SendaudioApiLatest = 1;
	public const int SetaudioinputsettingsApiLatest = 1;
	public const int SetaudiooutputsettingsApiLatest = 1;
	public const int SetinputdevicesettingsApiLatest = 1;
	public const int SetoutputdevicesettingsApiLatest = 1;
	public const int UnregisterplatformaudiouserApiLatest = 1;
	public const int UnregisterplatformuserApiLatest = 1;
	public const int UpdateparticipantvolumeApiLatest = 1;
	public const int UpdatereceivingApiLatest = 1;
	public const int UpdatereceivingvolumeApiLatest = 1;
	public const int UpdatesendingApiLatest = 1;
	public const int UpdatesendingvolumeApiLatest = 1;

	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }

	// RVA: 0x40BDB0 Offset: 0x40AFB0 VA: 0x18040BDB0
	public void .ctor(IntPtr innerHandle) { }

	// RVA: 0x47D690 Offset: 0x47C890 VA: 0x18047D690
	public ulong AddNotifyAudioBeforeRender(ref AddNotifyAudioBeforeRenderOptions options, object clientData, OnAudioBeforeRenderCallback completionDelegate) { }

	// RVA: 0x47D860 Offset: 0x47CA60 VA: 0x18047D860
	public ulong AddNotifyAudioBeforeSend(ref AddNotifyAudioBeforeSendOptions options, object clientData, OnAudioBeforeSendCallback completionDelegate) { }

	// RVA: 0x47DA30 Offset: 0x47CC30 VA: 0x18047DA30
	public ulong AddNotifyAudioDevicesChanged(ref AddNotifyAudioDevicesChangedOptions options, object clientData, OnAudioDevicesChangedCallback completionDelegate) { }

	// RVA: 0x47DBE0 Offset: 0x47CDE0 VA: 0x18047DBE0
	public ulong AddNotifyAudioInputState(ref AddNotifyAudioInputStateOptions options, object clientData, OnAudioInputStateCallback completionDelegate) { }

	// RVA: 0x47DDB0 Offset: 0x47CFB0 VA: 0x18047DDB0
	public ulong AddNotifyAudioOutputState(ref AddNotifyAudioOutputStateOptions options, object clientData, OnAudioOutputStateCallback completionDelegate) { }

	// RVA: 0x47DF80 Offset: 0x47D180 VA: 0x18047DF80
	public ulong AddNotifyParticipantUpdated(ref AddNotifyParticipantUpdatedOptions options, object clientData, OnParticipantUpdatedCallback completionDelegate) { }

	// RVA: 0x47E150 Offset: 0x47D350 VA: 0x18047E150
	public Result CopyInputDeviceInformationByIndex(ref CopyInputDeviceInformationByIndexOptions options, out Nullable<InputDeviceInformation> outInputDeviceInformation) { }

	// RVA: 0x47E240 Offset: 0x47D440 VA: 0x18047E240
	public Result CopyOutputDeviceInformationByIndex(ref CopyOutputDeviceInformationByIndexOptions options, out Nullable<OutputDeviceInformation> outOutputDeviceInformation) { }

	// RVA: 0x47E330 Offset: 0x47D530 VA: 0x18047E330
	public Nullable<AudioInputDeviceInfo> GetAudioInputDeviceByIndex(ref GetAudioInputDeviceByIndexOptions options) { }

	// RVA: 0x47E400 Offset: 0x47D600 VA: 0x18047E400
	public uint GetAudioInputDevicesCount(ref GetAudioInputDevicesCountOptions options) { }

	// RVA: 0x47E480 Offset: 0x47D680 VA: 0x18047E480
	public Nullable<AudioOutputDeviceInfo> GetAudioOutputDeviceByIndex(ref GetAudioOutputDeviceByIndexOptions options) { }

	// RVA: 0x47E550 Offset: 0x47D750 VA: 0x18047E550
	public uint GetAudioOutputDevicesCount(ref GetAudioOutputDevicesCountOptions options) { }

	// RVA: 0x47E5D0 Offset: 0x47D7D0 VA: 0x18047E5D0
	public uint GetInputDevicesCount(ref GetInputDevicesCountOptions options) { }

	// RVA: 0x47E650 Offset: 0x47D850 VA: 0x18047E650
	public uint GetOutputDevicesCount(ref GetOutputDevicesCountOptions options) { }

	// RVA: 0x47F250 Offset: 0x47E450 VA: 0x18047F250
	public void QueryInputDevicesInformation(ref QueryInputDevicesInformationOptions options, object clientData, OnQueryInputDevicesInformationCallback completionDelegate) { }

	// RVA: 0x47F3F0 Offset: 0x47E5F0 VA: 0x18047F3F0
	public void QueryOutputDevicesInformation(ref QueryOutputDevicesInformationOptions options, object clientData, OnQueryOutputDevicesInformationCallback completionDelegate) { }

	// RVA: 0x47F590 Offset: 0x47E790 VA: 0x18047F590
	public Result RegisterPlatformAudioUser(ref RegisterPlatformAudioUserOptions options) { }

	// RVA: 0x47F670 Offset: 0x47E870 VA: 0x18047F670
	public void RegisterPlatformUser(ref RegisterPlatformUserOptions options, object clientData, OnRegisterPlatformUserCallback completionDelegate) { }

	// RVA: 0x47F860 Offset: 0x47EA60 VA: 0x18047F860
	public void RemoveNotifyAudioBeforeRender(ulong notificationId) { }

	// RVA: 0x47F8D0 Offset: 0x47EAD0 VA: 0x18047F8D0
	public void RemoveNotifyAudioBeforeSend(ulong notificationId) { }

	// RVA: 0x47F940 Offset: 0x47EB40 VA: 0x18047F940
	public void RemoveNotifyAudioDevicesChanged(ulong notificationId) { }

	// RVA: 0x47F9B0 Offset: 0x47EBB0 VA: 0x18047F9B0
	public void RemoveNotifyAudioInputState(ulong notificationId) { }

	// RVA: 0x47FA20 Offset: 0x47EC20 VA: 0x18047FA20
	public void RemoveNotifyAudioOutputState(ulong notificationId) { }

	// RVA: 0x47FA90 Offset: 0x47EC90 VA: 0x18047FA90
	public void RemoveNotifyParticipantUpdated(ulong notificationId) { }

	// RVA: 0x47FB00 Offset: 0x47ED00 VA: 0x18047FB00
	public Result SendAudio(ref SendAudioOptions options) { }

	// RVA: 0x47FBA0 Offset: 0x47EDA0 VA: 0x18047FBA0
	public Result SetAudioInputSettings(ref SetAudioInputSettingsOptions options) { }

	// RVA: 0x47FC40 Offset: 0x47EE40 VA: 0x18047FC40
	public Result SetAudioOutputSettings(ref SetAudioOutputSettingsOptions options) { }

	// RVA: 0x47FCE0 Offset: 0x47EEE0 VA: 0x18047FCE0
	public void SetInputDeviceSettings(ref SetInputDeviceSettingsOptions options, object clientData, OnSetInputDeviceSettingsCallback completionDelegate) { }

	// RVA: 0x47FE90 Offset: 0x47F090 VA: 0x18047FE90
	public void SetOutputDeviceSettings(ref SetOutputDeviceSettingsOptions options, object clientData, OnSetOutputDeviceSettingsCallback completionDelegate) { }

	// RVA: 0x480040 Offset: 0x47F240 VA: 0x180480040
	public Result UnregisterPlatformAudioUser(ref UnregisterPlatformAudioUserOptions options) { }

	// RVA: 0x480120 Offset: 0x47F320 VA: 0x180480120
	public void UnregisterPlatformUser(ref UnregisterPlatformUserOptions options, object clientData, OnUnregisterPlatformUserCallback completionDelegate) { }

	// RVA: 0x480310 Offset: 0x47F510 VA: 0x180480310
	public void UpdateParticipantVolume(ref UpdateParticipantVolumeOptions options, object clientData, OnUpdateParticipantVolumeCallback completionDelegate) { }

	// RVA: 0x480680 Offset: 0x47F880 VA: 0x180480680
	public void UpdateReceiving(ref UpdateReceivingOptions options, object clientData, OnUpdateReceivingCallback completionDelegate) { }

	// RVA: 0x4804D0 Offset: 0x47F6D0 VA: 0x1804804D0
	public void UpdateReceivingVolume(ref UpdateReceivingVolumeOptions options, object clientData, OnUpdateReceivingVolumeCallback completionDelegate) { }

	// RVA: 0x4809F0 Offset: 0x47FBF0 VA: 0x1804809F0
	public void UpdateSending(ref UpdateSendingOptions options, object clientData, OnUpdateSendingCallback completionDelegate) { }

	// RVA: 0x480840 Offset: 0x47FA40 VA: 0x180480840
	public void UpdateSendingVolume(ref UpdateSendingVolumeOptions options, object clientData, OnUpdateSendingVolumeCallback completionDelegate) { }

	[MonoPInvokeCallback(typeof(OnAudioBeforeRenderCallbackInternal))]
	// RVA: 0x47E6D0 Offset: 0x47D8D0 VA: 0x18047E6D0
	internal static void OnAudioBeforeRenderCallbackInternalImplementation(ref AudioBeforeRenderCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnAudioBeforeSendCallbackInternal))]
	// RVA: 0x47E780 Offset: 0x47D980 VA: 0x18047E780
	internal static void OnAudioBeforeSendCallbackInternalImplementation(ref AudioBeforeSendCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnAudioDevicesChangedCallbackInternal))]
	// RVA: 0x47E830 Offset: 0x47DA30 VA: 0x18047E830
	internal static void OnAudioDevicesChangedCallbackInternalImplementation(ref AudioDevicesChangedCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnAudioInputStateCallbackInternal))]
	// RVA: 0x47E8D0 Offset: 0x47DAD0 VA: 0x18047E8D0
	internal static void OnAudioInputStateCallbackInternalImplementation(ref AudioInputStateCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnAudioOutputStateCallbackInternal))]
	// RVA: 0x47E980 Offset: 0x47DB80 VA: 0x18047E980
	internal static void OnAudioOutputStateCallbackInternalImplementation(ref AudioOutputStateCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnParticipantUpdatedCallbackInternal))]
	// RVA: 0x47EA30 Offset: 0x47DC30 VA: 0x18047EA30
	internal static void OnParticipantUpdatedCallbackInternalImplementation(ref ParticipantUpdatedCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnQueryInputDevicesInformationCallbackInternal))]
	// RVA: 0x47EAE0 Offset: 0x47DCE0 VA: 0x18047EAE0
	internal static void OnQueryInputDevicesInformationCallbackInternalImplementation(ref OnQueryInputDevicesInformationCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnQueryOutputDevicesInformationCallbackInternal))]
	// RVA: 0x47EB80 Offset: 0x47DD80 VA: 0x18047EB80
	internal static void OnQueryOutputDevicesInformationCallbackInternalImplementation(ref OnQueryOutputDevicesInformationCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnRegisterPlatformUserCallbackInternal))]
	// RVA: 0x47EC20 Offset: 0x47DE20 VA: 0x18047EC20
	internal static void OnRegisterPlatformUserCallbackInternalImplementation(ref OnRegisterPlatformUserCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnSetInputDeviceSettingsCallbackInternal))]
	// RVA: 0x47ECD0 Offset: 0x47DED0 VA: 0x18047ECD0
	internal static void OnSetInputDeviceSettingsCallbackInternalImplementation(ref OnSetInputDeviceSettingsCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnSetOutputDeviceSettingsCallbackInternal))]
	// RVA: 0x47ED80 Offset: 0x47DF80 VA: 0x18047ED80
	internal static void OnSetOutputDeviceSettingsCallbackInternalImplementation(ref OnSetOutputDeviceSettingsCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnUnregisterPlatformUserCallbackInternal))]
	// RVA: 0x47EE30 Offset: 0x47E030 VA: 0x18047EE30
	internal static void OnUnregisterPlatformUserCallbackInternalImplementation(ref OnUnregisterPlatformUserCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnUpdateParticipantVolumeCallbackInternal))]
	// RVA: 0x47EEE0 Offset: 0x47E0E0 VA: 0x18047EEE0
	internal static void OnUpdateParticipantVolumeCallbackInternalImplementation(ref UpdateParticipantVolumeCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnUpdateReceivingCallbackInternal))]
	// RVA: 0x47EF90 Offset: 0x47E190 VA: 0x18047EF90
	internal static void OnUpdateReceivingCallbackInternalImplementation(ref UpdateReceivingCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnUpdateReceivingVolumeCallbackInternal))]
	// RVA: 0x47F040 Offset: 0x47E240 VA: 0x18047F040
	internal static void OnUpdateReceivingVolumeCallbackInternalImplementation(ref UpdateReceivingVolumeCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnUpdateSendingCallbackInternal))]
	// RVA: 0x47F0F0 Offset: 0x47E2F0 VA: 0x18047F0F0
	internal static void OnUpdateSendingCallbackInternalImplementation(ref UpdateSendingCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnUpdateSendingVolumeCallbackInternal))]
	// RVA: 0x47F1A0 Offset: 0x47E3A0 VA: 0x18047F1A0
	internal static void OnUpdateSendingVolumeCallbackInternalImplementation(ref UpdateSendingVolumeCallbackInfoInternal data) { }
}

// Namespace: Epic.OnlineServices.RTCAudio
public enum RTCAudioOutputStatus // TypeDefIndex: 8596
{
	// Fields
	public int value__; // 0x0
	public const RTCAudioOutputStatus Idle = 0;
	public const RTCAudioOutputStatus Playing = 1;
	public const RTCAudioOutputStatus Failed = 2;
}

// Namespace: Epic.OnlineServices.RTCAudio
public enum RTCAudioStatus // TypeDefIndex: 8597
{
	// Fields
	public int value__; // 0x0
	public const RTCAudioStatus Unsupported = 0;
	public const RTCAudioStatus Enabled = 1;
	public const RTCAudioStatus Disabled = 2;
	public const RTCAudioStatus AdminDisabled = 3;
	public const RTCAudioStatus NotListeningDisabled = 4;
}

// Namespace: Epic.OnlineServices.RTCAudio
public struct SendAudioOptions // TypeDefIndex: 8598
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <RoomName>k__BackingField; // 0x8
	[CompilerGenerated]
	private Nullable<AudioBuffer> <Buffer>k__BackingField; // 0x10

	// Properties
	public ProductUserId LocalUserId { get; set; }
	public Utf8String RoomName { get; set; }
	public Nullable<AudioBuffer> Buffer { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_LocalUserId(ProductUserId value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public Utf8String get_RoomName() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_RoomName(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x44F1F0 Offset: 0x44E3F0 VA: 0x18044F1F0
	public Nullable<AudioBuffer> get_Buffer() { }

	[CompilerGenerated]
	// RVA: 0x44F220 Offset: 0x44E420 VA: 0x18044F220
	public void set_Buffer(Nullable<AudioBuffer> value) { }
}

// Namespace: Epic.OnlineServices.RTCAudio
internal struct SendAudioOptionsInternal : ISettable<SendAudioOptions>, IDisposable // TypeDefIndex: 8599
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_RoomName; // 0x10
	private IntPtr m_Buffer; // 0x18

	// Properties
	public ProductUserId LocalUserId { set; }
	public Utf8String RoomName { set; }
	public Nullable<AudioBuffer> Buffer { set; }

	// Methods

	// RVA: 0x4824C0 Offset: 0x4816C0 VA: 0x1804824C0
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x482520 Offset: 0x481720 VA: 0x180482520
	public void set_RoomName(Utf8String value) { }

	// RVA: 0x482450 Offset: 0x481650 VA: 0x180482450
	public void set_Buffer(Nullable<AudioBuffer> value) { }

	// RVA: 0x482330 Offset: 0x481530 VA: 0x180482330 Slot: 4
	public void Set(ref SendAudioOptions other) { }

	// RVA: 0x4821B0 Offset: 0x4813B0 VA: 0x1804821B0 Slot: 5
	public void Set(ref Nullable<SendAudioOptions> other) { }

	// RVA: 0x482150 Offset: 0x481350 VA: 0x180482150 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.RTCAudio
public struct SetAudioInputSettingsOptions // TypeDefIndex: 8600
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <DeviceId>k__BackingField; // 0x8
	[CompilerGenerated]
	private float <Volume>k__BackingField; // 0x10
	[CompilerGenerated]
	private bool <PlatformAEC>k__BackingField; // 0x14

	// Properties
	public ProductUserId LocalUserId { get; set; }
	public Utf8String DeviceId { get; set; }
	public float Volume { get; set; }
	public bool PlatformAEC { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_LocalUserId(ProductUserId value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public Utf8String get_DeviceId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_DeviceId(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x482DC0 Offset: 0x481FC0 VA: 0x180482DC0
	public float get_Volume() { }

	[CompilerGenerated]
	// RVA: 0x482DD0 Offset: 0x481FD0 VA: 0x180482DD0
	public void set_Volume(float value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x41AC30 Offset: 0x419E30 VA: 0x18041AC30
	public bool get_PlatformAEC() { }

	[CompilerGenerated]
	// RVA: 0x41AC60 Offset: 0x419E60 VA: 0x18041AC60
	public void set_PlatformAEC(bool value) { }
}

// Namespace: Epic.OnlineServices.RTCAudio
internal struct SetAudioInputSettingsOptionsInternal : ISettable<SetAudioInputSettingsOptions>, IDisposable // TypeDefIndex: 8601
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_DeviceId; // 0x10
	private float m_Volume; // 0x18
	private int m_PlatformAEC; // 0x1C

	// Properties
	public ProductUserId LocalUserId { set; }
	public Utf8String DeviceId { set; }
	public float Volume { set; }
	public bool PlatformAEC { set; }

	// Methods

	// RVA: 0x482CF0 Offset: 0x481EF0 VA: 0x180482CF0
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x482C90 Offset: 0x481E90 VA: 0x180482C90
	public void set_DeviceId(Utf8String value) { }

	// RVA: 0x482DB0 Offset: 0x481FB0 VA: 0x180482DB0
	public void set_Volume(float value) { }

	// RVA: 0x482D50 Offset: 0x481F50 VA: 0x180482D50
	public void set_PlatformAEC(bool value) { }

	// RVA: 0x482A10 Offset: 0x481C10 VA: 0x180482A10 Slot: 4
	public void Set(ref SetAudioInputSettingsOptions other) { }

	// RVA: 0x482B10 Offset: 0x481D10 VA: 0x180482B10 Slot: 5
	public void Set(ref Nullable<SetAudioInputSettingsOptions> other) { }

	// RVA: 0x4829B0 Offset: 0x481BB0 VA: 0x1804829B0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.RTCAudio
public struct SetAudioOutputSettingsOptions // TypeDefIndex: 8602
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <DeviceId>k__BackingField; // 0x8
	[CompilerGenerated]
	private float <Volume>k__BackingField; // 0x10

	// Properties
	public ProductUserId LocalUserId { get; set; }
	public Utf8String DeviceId { get; set; }
	public float Volume { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_LocalUserId(ProductUserId value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public Utf8String get_DeviceId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_DeviceId(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x482DC0 Offset: 0x481FC0 VA: 0x180482DC0
	public float get_Volume() { }

	[CompilerGenerated]
	// RVA: 0x482DD0 Offset: 0x481FD0 VA: 0x180482DD0
	public void set_Volume(float value) { }
}

// Namespace: Epic.OnlineServices.RTCAudio
internal struct SetAudioOutputSettingsOptionsInternal : ISettable<SetAudioOutputSettingsOptions>, IDisposable // TypeDefIndex: 8603
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_DeviceId; // 0x10
	private float m_Volume; // 0x18

	// Properties
	public ProductUserId LocalUserId { set; }
	public Utf8String DeviceId { set; }
	public float Volume { set; }

	// Methods

	// RVA: 0x483080 Offset: 0x482280 VA: 0x180483080
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x483020 Offset: 0x482220 VA: 0x180483020
	public void set_DeviceId(Utf8String value) { }

	// RVA: 0x482DB0 Offset: 0x481FB0 VA: 0x180482DB0
	public void set_Volume(float value) { }

	// RVA: 0x482F60 Offset: 0x482160 VA: 0x180482F60 Slot: 4
	public void Set(ref SetAudioOutputSettingsOptions other) { }

	// RVA: 0x482E40 Offset: 0x482040 VA: 0x180482E40 Slot: 5
	public void Set(ref Nullable<SetAudioOutputSettingsOptions> other) { }

	// RVA: 0x482DE0 Offset: 0x481FE0 VA: 0x180482DE0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.RTCAudio
public struct SetInputDeviceSettingsOptions // TypeDefIndex: 8604
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <RealDeviceId>k__BackingField; // 0x8
	[CompilerGenerated]
	private bool <PlatformAEC>k__BackingField; // 0x10

	// Properties
	public ProductUserId LocalUserId { get; set; }
	public Utf8String RealDeviceId { get; set; }
	public bool PlatformAEC { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_LocalUserId(ProductUserId value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public Utf8String get_RealDeviceId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_RealDeviceId(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	public bool get_PlatformAEC() { }

	[CompilerGenerated]
	// RVA: 0x3D6DB0 Offset: 0x3D5FB0 VA: 0x1803D6DB0
	public void set_PlatformAEC(bool value) { }
}

// Namespace: Epic.OnlineServices.RTCAudio
internal struct SetInputDeviceSettingsOptionsInternal : ISettable<SetInputDeviceSettingsOptions>, IDisposable // TypeDefIndex: 8605
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_RealDeviceId; // 0x10
	private int m_PlatformAEC; // 0x18

	// Properties
	public ProductUserId LocalUserId { set; }
	public Utf8String RealDeviceId { set; }
	public bool PlatformAEC { set; }

	// Methods

	// RVA: 0x4833A0 Offset: 0x4825A0 VA: 0x1804833A0
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x483460 Offset: 0x482660 VA: 0x180483460
	public void set_RealDeviceId(Utf8String value) { }

	// RVA: 0x483400 Offset: 0x482600 VA: 0x180483400
	public void set_PlatformAEC(bool value) { }

	// RVA: 0x4832A0 Offset: 0x4824A0 VA: 0x1804832A0 Slot: 4
	public void Set(ref SetInputDeviceSettingsOptions other) { }

	// RVA: 0x483140 Offset: 0x482340 VA: 0x180483140 Slot: 5
	public void Set(ref Nullable<SetInputDeviceSettingsOptions> other) { }

	// RVA: 0x4830E0 Offset: 0x4822E0 VA: 0x1804830E0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.RTCAudio
public struct SetOutputDeviceSettingsOptions // TypeDefIndex: 8606
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <RealDeviceId>k__BackingField; // 0x8

	// Properties
	public ProductUserId LocalUserId { get; set; }
	public Utf8String RealDeviceId { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_LocalUserId(ProductUserId value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public Utf8String get_RealDeviceId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_RealDeviceId(Utf8String value) { }
}

// Namespace: Epic.OnlineServices.RTCAudio
internal struct SetOutputDeviceSettingsOptionsInternal : ISettable<SetOutputDeviceSettingsOptions>, IDisposable // TypeDefIndex: 8607
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_RealDeviceId; // 0x10

	// Properties
	public ProductUserId LocalUserId { set; }
	public Utf8String RealDeviceId { set; }

	// Methods

	// RVA: 0x4836E0 Offset: 0x4828E0 VA: 0x1804836E0
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x483740 Offset: 0x482940 VA: 0x180483740
	public void set_RealDeviceId(Utf8String value) { }

	// RVA: 0x483520 Offset: 0x482720 VA: 0x180483520 Slot: 4
	public void Set(ref SetOutputDeviceSettingsOptions other) { }

	// RVA: 0x4835E0 Offset: 0x4827E0 VA: 0x1804835E0 Slot: 5
	public void Set(ref Nullable<SetOutputDeviceSettingsOptions> other) { }

	// RVA: 0x4834C0 Offset: 0x4826C0 VA: 0x1804834C0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.RTCAudio
public struct UnregisterPlatformAudioUserOptions // TypeDefIndex: 8608
{
	// Fields
	[CompilerGenerated]
	private Utf8String <UserId>k__BackingField; // 0x0

	// Properties
	public Utf8String UserId { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Utf8String get_UserId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_UserId(Utf8String value) { }
}

// Namespace: Epic.OnlineServices.RTCAudio
internal struct UnregisterPlatformAudioUserOptionsInternal : ISettable<UnregisterPlatformAudioUserOptions>, IDisposable // TypeDefIndex: 8609
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_UserId; // 0x8

	// Properties
	public Utf8String UserId { set; }

	// Methods

	// RVA: 0x483DD0 Offset: 0x482FD0 VA: 0x180483DD0
	public void set_UserId(Utf8String value) { }

	// RVA: 0x483CD0 Offset: 0x482ED0 VA: 0x180483CD0 Slot: 4
	public void Set(ref UnregisterPlatformAudioUserOptions other) { }

	// RVA: 0x483D30 Offset: 0x482F30 VA: 0x180483D30 Slot: 5
	public void Set(ref Nullable<UnregisterPlatformAudioUserOptions> other) { }

	// RVA: 0x483C80 Offset: 0x482E80 VA: 0x180483C80 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.RTCAudio
public struct UnregisterPlatformUserOptions // TypeDefIndex: 8610
{
	// Fields
	[CompilerGenerated]
	private Utf8String <PlatformUserId>k__BackingField; // 0x0

	// Properties
	public Utf8String PlatformUserId { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Utf8String get_PlatformUserId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_PlatformUserId(Utf8String value) { }
}

// Namespace: Epic.OnlineServices.RTCAudio
internal struct UnregisterPlatformUserOptionsInternal : ISettable<UnregisterPlatformUserOptions>, IDisposable // TypeDefIndex: 8611
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_PlatformUserId; // 0x8

	// Properties
	public Utf8String PlatformUserId { set; }

	// Methods

	// RVA: 0x483F80 Offset: 0x483180 VA: 0x180483F80
	public void set_PlatformUserId(Utf8String value) { }

	// RVA: 0x483E80 Offset: 0x483080 VA: 0x180483E80 Slot: 4
	public void Set(ref UnregisterPlatformUserOptions other) { }

	// RVA: 0x483EE0 Offset: 0x4830E0 VA: 0x180483EE0 Slot: 5
	public void Set(ref Nullable<UnregisterPlatformUserOptions> other) { }

	// RVA: 0x483E30 Offset: 0x483030 VA: 0x180483E30 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.RTCAudio
public struct UpdateParticipantVolumeCallbackInfo : ICallbackInfo // TypeDefIndex: 8612
{
	// Fields
	[CompilerGenerated]
	private Result <ResultCode>k__BackingField; // 0x0
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x8
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x10
	[CompilerGenerated]
	private Utf8String <RoomName>k__BackingField; // 0x18
	[CompilerGenerated]
	private ProductUserId <ParticipantId>k__BackingField; // 0x20
	[CompilerGenerated]
	private float <Volume>k__BackingField; // 0x28

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public ProductUserId LocalUserId { get; set; }
	public Utf8String RoomName { get; set; }
	public ProductUserId ParticipantId { get; set; }
	public float Volume { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	[CompilerGenerated]
	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public object get_ClientData() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_ClientData(object value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_LocalUserId(ProductUserId value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public Utf8String get_RoomName() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_RoomName(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public ProductUserId get_ParticipantId() { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_ParticipantId(ProductUserId value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x484D20 Offset: 0x483F20 VA: 0x180484D20
	public float get_Volume() { }

	[CompilerGenerated]
	// RVA: 0x484EB0 Offset: 0x4840B0 VA: 0x180484EB0
	public void set_Volume(float value) { }

	// RVA: 0x484EC0 Offset: 0x4840C0 VA: 0x180484EC0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x484F10 Offset: 0x484110 VA: 0x180484F10
	internal void Set(ref UpdateParticipantVolumeCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.RTCAudio
internal struct UpdateParticipantVolumeCallbackInfoInternal : ICallbackInfoInternal, IGettable<UpdateParticipantVolumeCallbackInfo>, ISettable<UpdateParticipantVolumeCallbackInfo>, IDisposable // TypeDefIndex: 8613
{
	// Fields
	private Result m_ResultCode; // 0x0
	private IntPtr m_ClientData; // 0x8
	private IntPtr m_LocalUserId; // 0x10
	private IntPtr m_RoomName; // 0x18
	private IntPtr m_ParticipantId; // 0x20
	private float m_Volume; // 0x28

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public ProductUserId LocalUserId { get; set; }
	public Utf8String RoomName { get; set; }
	public ProductUserId ParticipantId { get; set; }
	public float Volume { get; set; }

	// Methods

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	// RVA: 0x484B40 Offset: 0x483D40 VA: 0x180484B40
	public object get_ClientData() { }

	// RVA: 0x484D30 Offset: 0x483F30 VA: 0x180484D30
	public void set_ClientData(object value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x484BB0 Offset: 0x483DB0 VA: 0x180484BB0
	public ProductUserId get_LocalUserId() { }

	// RVA: 0x484D90 Offset: 0x483F90 VA: 0x180484D90
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x484CB0 Offset: 0x483EB0 VA: 0x180484CB0
	public Utf8String get_RoomName() { }

	// RVA: 0x484E50 Offset: 0x484050 VA: 0x180484E50
	public void set_RoomName(Utf8String value) { }

	// RVA: 0x484C30 Offset: 0x483E30 VA: 0x180484C30
	public ProductUserId get_ParticipantId() { }

	// RVA: 0x484DF0 Offset: 0x483FF0 VA: 0x180484DF0
	public void set_ParticipantId(ProductUserId value) { }

	// RVA: 0x484D20 Offset: 0x483F20 VA: 0x180484D20
	public float get_Volume() { }

	// RVA: 0x484EB0 Offset: 0x4840B0 VA: 0x180484EB0
	public void set_Volume(float value) { }

	// RVA: 0x484A00 Offset: 0x483C00 VA: 0x180484A00 Slot: 6
	public void Set(ref UpdateParticipantVolumeCallbackInfo other) { }

	// RVA: 0x484820 Offset: 0x483A20 VA: 0x180484820 Slot: 7
	public void Set(ref Nullable<UpdateParticipantVolumeCallbackInfo> other) { }

	// RVA: 0x484790 Offset: 0x483990 VA: 0x180484790 Slot: 8
	public void Dispose() { }

	// RVA: 0x484800 Offset: 0x483A00 VA: 0x180484800 Slot: 5
	public void Get(out UpdateParticipantVolumeCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.RTCAudio
public struct UpdateParticipantVolumeOptions // TypeDefIndex: 8614
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <RoomName>k__BackingField; // 0x8
	[CompilerGenerated]
	private ProductUserId <ParticipantId>k__BackingField; // 0x10
	[CompilerGenerated]
	private float <Volume>k__BackingField; // 0x18

	// Properties
	public ProductUserId LocalUserId { get; set; }
	public Utf8String RoomName { get; set; }
	public ProductUserId ParticipantId { get; set; }
	public float Volume { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_LocalUserId(ProductUserId value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public Utf8String get_RoomName() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_RoomName(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public ProductUserId get_ParticipantId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_ParticipantId(ProductUserId value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x485420 Offset: 0x484620 VA: 0x180485420
	public float get_Volume() { }

	[CompilerGenerated]
	// RVA: 0x482DB0 Offset: 0x481FB0 VA: 0x180482DB0
	public void set_Volume(float value) { }
}

// Namespace: Epic.OnlineServices.RTCAudio
internal struct UpdateParticipantVolumeOptionsInternal : ISettable<UpdateParticipantVolumeOptions>, IDisposable // TypeDefIndex: 8615
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_RoomName; // 0x10
	private IntPtr m_ParticipantId; // 0x18
	private float m_Volume; // 0x20

	// Properties
	public ProductUserId LocalUserId { set; }
	public Utf8String RoomName { set; }
	public ProductUserId ParticipantId { set; }
	public float Volume { set; }

	// Methods

	// RVA: 0x4852F0 Offset: 0x4844F0 VA: 0x1804852F0
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x4853B0 Offset: 0x4845B0 VA: 0x1804853B0
	public void set_RoomName(Utf8String value) { }

	// RVA: 0x485350 Offset: 0x484550 VA: 0x180485350
	public void set_ParticipantId(ProductUserId value) { }

	// RVA: 0x485410 Offset: 0x484610 VA: 0x180485410
	public void set_Volume(float value) { }

	// RVA: 0x485070 Offset: 0x484270 VA: 0x180485070 Slot: 4
	public void Set(ref UpdateParticipantVolumeOptions other) { }

	// RVA: 0x485170 Offset: 0x484370 VA: 0x180485170 Slot: 5
	public void Set(ref Nullable<UpdateParticipantVolumeOptions> other) { }

	// RVA: 0x485010 Offset: 0x484210 VA: 0x180485010 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.RTCAudio
public struct UpdateReceivingCallbackInfo : ICallbackInfo // TypeDefIndex: 8616
{
	// Fields
	[CompilerGenerated]
	private Result <ResultCode>k__BackingField; // 0x0
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x8
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x10
	[CompilerGenerated]
	private Utf8String <RoomName>k__BackingField; // 0x18
	[CompilerGenerated]
	private ProductUserId <ParticipantId>k__BackingField; // 0x20
	[CompilerGenerated]
	private bool <AudioEnabled>k__BackingField; // 0x28

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public ProductUserId LocalUserId { get; set; }
	public Utf8String RoomName { get; set; }
	public ProductUserId ParticipantId { get; set; }
	public bool AudioEnabled { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	[CompilerGenerated]
	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public object get_ClientData() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_ClientData(object value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_LocalUserId(ProductUserId value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public Utf8String get_RoomName() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_RoomName(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public ProductUserId get_ParticipantId() { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_ParticipantId(ProductUserId value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x42D840 Offset: 0x42CA40 VA: 0x18042D840
	public bool get_AudioEnabled() { }

	[CompilerGenerated]
	// RVA: 0x42D8B0 Offset: 0x42CAB0 VA: 0x18042D8B0
	public void set_AudioEnabled(bool value) { }

	// RVA: 0x4864D0 Offset: 0x4856D0 VA: 0x1804864D0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x486570 Offset: 0x485770 VA: 0x180486570
	internal void Set(ref UpdateReceivingCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.RTCAudio
internal struct UpdateReceivingCallbackInfoInternal : ICallbackInfoInternal, IGettable<UpdateReceivingCallbackInfo>, ISettable<UpdateReceivingCallbackInfo>, IDisposable // TypeDefIndex: 8617
{
	// Fields
	private Result m_ResultCode; // 0x0
	private IntPtr m_ClientData; // 0x8
	private IntPtr m_LocalUserId; // 0x10
	private IntPtr m_RoomName; // 0x18
	private IntPtr m_ParticipantId; // 0x20
	private int m_AudioEnabled; // 0x28

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public ProductUserId LocalUserId { get; set; }
	public Utf8String RoomName { get; set; }
	public ProductUserId ParticipantId { get; set; }
	public bool AudioEnabled { get; set; }

	// Methods

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	// RVA: 0x485D60 Offset: 0x484F60 VA: 0x180485D60
	public object get_ClientData() { }

	// RVA: 0x486170 Offset: 0x485370 VA: 0x180486170
	public void set_ClientData(object value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x485E30 Offset: 0x485030 VA: 0x180485E30
	public ProductUserId get_LocalUserId() { }

	// RVA: 0x4862F0 Offset: 0x4854F0 VA: 0x1804862F0
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x486030 Offset: 0x485230 VA: 0x180486030
	public Utf8String get_RoomName() { }

	// RVA: 0x486410 Offset: 0x485610 VA: 0x180486410
	public void set_RoomName(Utf8String value) { }

	// RVA: 0x485FB0 Offset: 0x4851B0 VA: 0x180485FB0
	public ProductUserId get_ParticipantId() { }

	// RVA: 0x4863B0 Offset: 0x4855B0 VA: 0x1804863B0
	public void set_ParticipantId(ProductUserId value) { }

	// RVA: 0x485C90 Offset: 0x484E90 VA: 0x180485C90
	public bool get_AudioEnabled() { }

	// RVA: 0x486110 Offset: 0x485310 VA: 0x180486110
	public void set_AudioEnabled(bool value) { }

	// RVA: 0x485770 Offset: 0x484970 VA: 0x180485770 Slot: 6
	public void Set(ref UpdateReceivingCallbackInfo other) { }

	// RVA: 0x485550 Offset: 0x484750 VA: 0x180485550 Slot: 7
	public void Set(ref Nullable<UpdateReceivingCallbackInfo> other) { }

	// RVA: 0x4854A0 Offset: 0x4846A0 VA: 0x1804854A0 Slot: 8
	public void Dispose() { }

	// RVA: 0x485530 Offset: 0x484730 VA: 0x180485530 Slot: 5
	public void Get(out UpdateReceivingCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.RTCAudio
public struct UpdateReceivingOptions // TypeDefIndex: 8618
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <RoomName>k__BackingField; // 0x8
	[CompilerGenerated]
	private ProductUserId <ParticipantId>k__BackingField; // 0x10
	[CompilerGenerated]
	private bool <AudioEnabled>k__BackingField; // 0x18

	// Properties
	public ProductUserId LocalUserId { get; set; }
	public Utf8String RoomName { get; set; }
	public ProductUserId ParticipantId { get; set; }
	public bool AudioEnabled { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_LocalUserId(ProductUserId value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public Utf8String get_RoomName() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_RoomName(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public ProductUserId get_ParticipantId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_ParticipantId(ProductUserId value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x411B20 Offset: 0x410D20 VA: 0x180411B20
	public bool get_AudioEnabled() { }

	[CompilerGenerated]
	// RVA: 0x411B30 Offset: 0x410D30 VA: 0x180411B30
	public void set_AudioEnabled(bool value) { }
}

// Namespace: Epic.OnlineServices.RTCAudio
internal struct UpdateReceivingOptionsInternal : ISettable<UpdateReceivingOptions>, IDisposable // TypeDefIndex: 8619
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_RoomName; // 0x10
	private IntPtr m_ParticipantId; // 0x18
	private int m_AudioEnabled; // 0x20

	// Properties
	public ProductUserId LocalUserId { set; }
	public Utf8String RoomName { set; }
	public ProductUserId ParticipantId { set; }
	public bool AudioEnabled { set; }

	// Methods

	// RVA: 0x486FD0 Offset: 0x4861D0 VA: 0x180486FD0
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x487150 Offset: 0x486350 VA: 0x180487150
	public void set_RoomName(Utf8String value) { }

	// RVA: 0x487090 Offset: 0x486290 VA: 0x180487090
	public void set_ParticipantId(ProductUserId value) { }

	// RVA: 0x486EB0 Offset: 0x4860B0 VA: 0x180486EB0
	public void set_AudioEnabled(bool value) { }

	// RVA: 0x486A80 Offset: 0x485C80 VA: 0x180486A80 Slot: 4
	public void Set(ref UpdateReceivingOptions other) { }

	// RVA: 0x4868D0 Offset: 0x485AD0 VA: 0x1804868D0 Slot: 5
	public void Set(ref Nullable<UpdateReceivingOptions> other) { }

	// RVA: 0x486870 Offset: 0x485A70 VA: 0x180486870 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.RTCAudio
public struct UpdateReceivingVolumeCallbackInfo : ICallbackInfo // TypeDefIndex: 8620
{
	// Fields
	[CompilerGenerated]
	private Result <ResultCode>k__BackingField; // 0x0
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x8
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x10
	[CompilerGenerated]
	private Utf8String <RoomName>k__BackingField; // 0x18
	[CompilerGenerated]
	private float <Volume>k__BackingField; // 0x20

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public ProductUserId LocalUserId { get; set; }
	public Utf8String RoomName { get; set; }
	public float Volume { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	[CompilerGenerated]
	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public object get_ClientData() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_ClientData(object value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_LocalUserId(ProductUserId value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public Utf8String get_RoomName() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_RoomName(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x487630 Offset: 0x486830 VA: 0x180487630
	public float get_Volume() { }

	[CompilerGenerated]
	// RVA: 0x485410 Offset: 0x484610 VA: 0x180485410
	public void set_Volume(float value) { }

	// RVA: 0x487760 Offset: 0x486960 VA: 0x180487760 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x4877B0 Offset: 0x4869B0 VA: 0x1804877B0
	internal void Set(ref UpdateReceivingVolumeCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.RTCAudio
internal struct UpdateReceivingVolumeCallbackInfoInternal : ICallbackInfoInternal, IGettable<UpdateReceivingVolumeCallbackInfo>, ISettable<UpdateReceivingVolumeCallbackInfo>, IDisposable // TypeDefIndex: 8621
{
	// Fields
	private Result m_ResultCode; // 0x0
	private IntPtr m_ClientData; // 0x8
	private IntPtr m_LocalUserId; // 0x10
	private IntPtr m_RoomName; // 0x18
	private float m_Volume; // 0x20

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public ProductUserId LocalUserId { get; set; }
	public Utf8String RoomName { get; set; }
	public float Volume { get; set; }

	// Methods

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	// RVA: 0x4874D0 Offset: 0x4866D0 VA: 0x1804874D0
	public object get_ClientData() { }

	// RVA: 0x487640 Offset: 0x486840 VA: 0x180487640
	public void set_ClientData(object value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x487540 Offset: 0x486740 VA: 0x180487540
	public ProductUserId get_LocalUserId() { }

	// RVA: 0x4876A0 Offset: 0x4868A0 VA: 0x1804876A0
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x4875C0 Offset: 0x4867C0 VA: 0x1804875C0
	public Utf8String get_RoomName() { }

	// RVA: 0x487700 Offset: 0x486900 VA: 0x180487700
	public void set_RoomName(Utf8String value) { }

	// RVA: 0x487630 Offset: 0x486830 VA: 0x180487630
	public float get_Volume() { }

	// RVA: 0x485410 Offset: 0x484610 VA: 0x180485410
	public void set_Volume(float value) { }

	// RVA: 0x487240 Offset: 0x486440 VA: 0x180487240 Slot: 6
	public void Set(ref UpdateReceivingVolumeCallbackInfo other) { }

	// RVA: 0x487340 Offset: 0x486540 VA: 0x180487340 Slot: 7
	public void Set(ref Nullable<UpdateReceivingVolumeCallbackInfo> other) { }

	// RVA: 0x4871B0 Offset: 0x4863B0 VA: 0x1804871B0 Slot: 8
	public void Dispose() { }

	// RVA: 0x487210 Offset: 0x486410 VA: 0x180487210 Slot: 5
	public void Get(out UpdateReceivingVolumeCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.RTCAudio
public struct UpdateReceivingVolumeOptions // TypeDefIndex: 8622
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <RoomName>k__BackingField; // 0x8
	[CompilerGenerated]
	private float <Volume>k__BackingField; // 0x10

	// Properties
	public ProductUserId LocalUserId { get; set; }
	public Utf8String RoomName { get; set; }
	public float Volume { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_LocalUserId(ProductUserId value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public Utf8String get_RoomName() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_RoomName(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x482DC0 Offset: 0x481FC0 VA: 0x180482DC0
	public float get_Volume() { }

	[CompilerGenerated]
	// RVA: 0x482DD0 Offset: 0x481FD0 VA: 0x180482DD0
	public void set_Volume(float value) { }
}

// Namespace: Epic.OnlineServices.RTCAudio
internal struct UpdateReceivingVolumeOptionsInternal : ISettable<UpdateReceivingVolumeOptions>, IDisposable // TypeDefIndex: 8623
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_RoomName; // 0x10
	private float m_Volume; // 0x18

	// Properties
	public ProductUserId LocalUserId { set; }
	public Utf8String RoomName { set; }
	public float Volume { set; }

	// Methods

	// RVA: 0x487AE0 Offset: 0x486CE0 VA: 0x180487AE0
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x487B40 Offset: 0x486D40 VA: 0x180487B40
	public void set_RoomName(Utf8String value) { }

	// RVA: 0x482DB0 Offset: 0x481FB0 VA: 0x180482DB0
	public void set_Volume(float value) { }

	// RVA: 0x487A20 Offset: 0x486C20 VA: 0x180487A20 Slot: 4
	public void Set(ref UpdateReceivingVolumeOptions other) { }

	// RVA: 0x487900 Offset: 0x486B00 VA: 0x180487900 Slot: 5
	public void Set(ref Nullable<UpdateReceivingVolumeOptions> other) { }

	// RVA: 0x4878A0 Offset: 0x486AA0 VA: 0x1804878A0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.RTCAudio
public struct UpdateSendingCallbackInfo : ICallbackInfo // TypeDefIndex: 8624
{
	// Fields
	[CompilerGenerated]
	private Result <ResultCode>k__BackingField; // 0x0
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x8
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x10
	[CompilerGenerated]
	private Utf8String <RoomName>k__BackingField; // 0x18
	[CompilerGenerated]
	private RTCAudioStatus <AudioStatus>k__BackingField; // 0x20

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public ProductUserId LocalUserId { get; set; }
	public Utf8String RoomName { get; set; }
	public RTCAudioStatus AudioStatus { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	[CompilerGenerated]
	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public object get_ClientData() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_ClientData(object value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_LocalUserId(ProductUserId value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public Utf8String get_RoomName() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_RoomName(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400
	public RTCAudioStatus get_AudioStatus() { }

	[CompilerGenerated]
	// RVA: 0x3DA420 Offset: 0x3D9620 VA: 0x1803DA420
	public void set_AudioStatus(RTCAudioStatus value) { }

	// RVA: 0x488810 Offset: 0x487A10 VA: 0x180488810 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x4888B0 Offset: 0x487AB0 VA: 0x1804888B0
	internal void Set(ref UpdateSendingCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.RTCAudio
internal struct UpdateSendingCallbackInfoInternal : ICallbackInfoInternal, IGettable<UpdateSendingCallbackInfo>, ISettable<UpdateSendingCallbackInfo>, IDisposable // TypeDefIndex: 8625
{
	// Fields
	private Result m_ResultCode; // 0x0
	private IntPtr m_ClientData; // 0x8
	private IntPtr m_LocalUserId; // 0x10
	private IntPtr m_RoomName; // 0x18
	private RTCAudioStatus m_AudioStatus; // 0x20

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public ProductUserId LocalUserId { get; set; }
	public Utf8String RoomName { get; set; }
	public RTCAudioStatus AudioStatus { get; set; }

	// Methods

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	// RVA: 0x4882C0 Offset: 0x4874C0 VA: 0x1804882C0
	public object get_ClientData() { }

	// RVA: 0x488570 Offset: 0x487770 VA: 0x180488570
	public void set_ClientData(object value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x488410 Offset: 0x487610 VA: 0x180488410
	public ProductUserId get_LocalUserId() { }

	// RVA: 0x488690 Offset: 0x487890 VA: 0x180488690
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x488500 Offset: 0x487700 VA: 0x180488500
	public Utf8String get_RoomName() { }

	// RVA: 0x488750 Offset: 0x487950 VA: 0x180488750
	public void set_RoomName(Utf8String value) { }

	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400
	public RTCAudioStatus get_AudioStatus() { }

	// RVA: 0x3DA420 Offset: 0x3D9620 VA: 0x1803DA420
	public void set_AudioStatus(RTCAudioStatus value) { }

	// RVA: 0x488150 Offset: 0x487350 VA: 0x180488150 Slot: 6
	public void Set(ref UpdateSendingCallbackInfo other) { }

	// RVA: 0x487FC0 Offset: 0x4871C0 VA: 0x180487FC0 Slot: 7
	public void Set(ref Nullable<UpdateSendingCallbackInfo> other) { }

	// RVA: 0x487BA0 Offset: 0x486DA0 VA: 0x180487BA0 Slot: 8
	public void Dispose() { }

	// RVA: 0x487C90 Offset: 0x486E90 VA: 0x180487C90 Slot: 5
	public void Get(out UpdateSendingCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.RTCAudio
public struct UpdateSendingOptions // TypeDefIndex: 8626
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <RoomName>k__BackingField; // 0x8
	[CompilerGenerated]
	private RTCAudioStatus <AudioStatus>k__BackingField; // 0x10

	// Properties
	public ProductUserId LocalUserId { get; set; }
	public Utf8String RoomName { get; set; }
	public RTCAudioStatus AudioStatus { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_LocalUserId(ProductUserId value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public Utf8String get_RoomName() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_RoomName(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public RTCAudioStatus get_AudioStatus() { }

	[CompilerGenerated]
	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_AudioStatus(RTCAudioStatus value) { }
}

// Namespace: Epic.OnlineServices.RTCAudio
internal struct UpdateSendingOptionsInternal : ISettable<UpdateSendingOptions>, IDisposable // TypeDefIndex: 8627
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_RoomName; // 0x10
	private RTCAudioStatus m_AudioStatus; // 0x18

	// Properties
	public ProductUserId LocalUserId { set; }
	public Utf8String RoomName { set; }
	public RTCAudioStatus AudioStatus { set; }

	// Methods

	// RVA: 0x489040 Offset: 0x488240 VA: 0x180489040
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x489100 Offset: 0x488300 VA: 0x180489100
	public void set_RoomName(Utf8String value) { }

	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	public void set_AudioStatus(RTCAudioStatus value) { }

	// RVA: 0x488F20 Offset: 0x488120 VA: 0x180488F20 Slot: 4
	public void Set(ref UpdateSendingOptions other) { }

	// RVA: 0x488D00 Offset: 0x487F00 VA: 0x180488D00 Slot: 5
	public void Set(ref Nullable<UpdateSendingOptions> other) { }

	// RVA: 0x488B40 Offset: 0x487D40 VA: 0x180488B40 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.RTCAudio
public struct UpdateSendingVolumeCallbackInfo : ICallbackInfo // TypeDefIndex: 8628
{
	// Fields
	[CompilerGenerated]
	private Result <ResultCode>k__BackingField; // 0x0
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x8
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x10
	[CompilerGenerated]
	private Utf8String <RoomName>k__BackingField; // 0x18
	[CompilerGenerated]
	private float <Volume>k__BackingField; // 0x20

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public ProductUserId LocalUserId { get; set; }
	public Utf8String RoomName { get; set; }
	public float Volume { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	[CompilerGenerated]
	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public object get_ClientData() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_ClientData(object value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_LocalUserId(ProductUserId value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public Utf8String get_RoomName() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_RoomName(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x487630 Offset: 0x486830 VA: 0x180487630
	public float get_Volume() { }

	[CompilerGenerated]
	// RVA: 0x485410 Offset: 0x484610 VA: 0x180485410
	public void set_Volume(float value) { }

	// RVA: 0x4891C0 Offset: 0x4883C0 VA: 0x1804891C0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x489210 Offset: 0x488410 VA: 0x180489210
	internal void Set(ref UpdateSendingVolumeCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.RTCAudio
internal struct UpdateSendingVolumeCallbackInfoInternal : ICallbackInfoInternal, IGettable<UpdateSendingVolumeCallbackInfo>, ISettable<UpdateSendingVolumeCallbackInfo>, IDisposable // TypeDefIndex: 8629
{
	// Fields
	private Result m_ResultCode; // 0x0
	private IntPtr m_ClientData; // 0x8
	private IntPtr m_LocalUserId; // 0x10
	private IntPtr m_RoomName; // 0x18
	private float m_Volume; // 0x20

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public ProductUserId LocalUserId { get; set; }
	public Utf8String RoomName { get; set; }
	public float Volume { get; set; }

	// Methods

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	// RVA: 0x49F770 Offset: 0x49E970 VA: 0x18049F770
	public object get_ClientData() { }

	// RVA: 0x49F8D0 Offset: 0x49EAD0 VA: 0x18049F8D0
	public void set_ClientData(object value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x49F7E0 Offset: 0x49E9E0 VA: 0x18049F7E0
	public ProductUserId get_LocalUserId() { }

	// RVA: 0x49F930 Offset: 0x49EB30 VA: 0x18049F930
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x49F860 Offset: 0x49EA60 VA: 0x18049F860
	public Utf8String get_RoomName() { }

	// RVA: 0x49F990 Offset: 0x49EB90 VA: 0x18049F990
	public void set_RoomName(Utf8String value) { }

	// RVA: 0x487630 Offset: 0x486830 VA: 0x180487630
	public float get_Volume() { }

	// RVA: 0x485410 Offset: 0x484610 VA: 0x180485410
	public void set_Volume(float value) { }

	// RVA: 0x49F4E0 Offset: 0x49E6E0 VA: 0x18049F4E0 Slot: 6
	public void Set(ref UpdateSendingVolumeCallbackInfo other) { }

	// RVA: 0x49F5E0 Offset: 0x49E7E0 VA: 0x18049F5E0 Slot: 7
	public void Set(ref Nullable<UpdateSendingVolumeCallbackInfo> other) { }

	// RVA: 0x49F450 Offset: 0x49E650 VA: 0x18049F450 Slot: 8
	public void Dispose() { }

	// RVA: 0x49F4B0 Offset: 0x49E6B0 VA: 0x18049F4B0 Slot: 5
	public void Get(out UpdateSendingVolumeCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.RTCAudio
public struct UpdateSendingVolumeOptions // TypeDefIndex: 8630
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <RoomName>k__BackingField; // 0x8
	[CompilerGenerated]
	private float <Volume>k__BackingField; // 0x10

	// Properties
	public ProductUserId LocalUserId { get; set; }
	public Utf8String RoomName { get; set; }
	public float Volume { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_LocalUserId(ProductUserId value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public Utf8String get_RoomName() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_RoomName(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x482DC0 Offset: 0x481FC0 VA: 0x180482DC0
	public float get_Volume() { }

	[CompilerGenerated]
	// RVA: 0x482DD0 Offset: 0x481FD0 VA: 0x180482DD0
	public void set_Volume(float value) { }
}

// Namespace: Epic.OnlineServices.RTCAudio
internal struct UpdateSendingVolumeOptionsInternal : ISettable<UpdateSendingVolumeOptions>, IDisposable // TypeDefIndex: 8631
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_RoomName; // 0x10
	private float m_Volume; // 0x18

	// Properties
	public ProductUserId LocalUserId { set; }
	public Utf8String RoomName { set; }
	public float Volume { set; }

	// Methods

	// RVA: 0x49FC30 Offset: 0x49EE30 VA: 0x18049FC30
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x49FC90 Offset: 0x49EE90 VA: 0x18049FC90
	public void set_RoomName(Utf8String value) { }

	// RVA: 0x482DB0 Offset: 0x481FB0 VA: 0x180482DB0
	public void set_Volume(float value) { }

	// RVA: 0x49FA50 Offset: 0x49EC50 VA: 0x18049FA50 Slot: 4
	public void Set(ref UpdateSendingVolumeOptions other) { }

	// RVA: 0x49FB10 Offset: 0x49ED10 VA: 0x18049FB10 Slot: 5
	public void Set(ref Nullable<UpdateSendingVolumeOptions> other) { }

	// RVA: 0x49F9F0 Offset: 0x49EBF0 VA: 0x18049F9F0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.RTCAdmin
public struct CopyUserTokenByIndexOptions // TypeDefIndex: 8632
{
	// Fields
	[CompilerGenerated]
	private uint <UserTokenIndex>k__BackingField; // 0x0
	[CompilerGenerated]
	private uint <QueryId>k__BackingField; // 0x4

	// Properties
	public uint UserTokenIndex { get; set; }
	public uint QueryId { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public uint get_UserTokenIndex() { }

	[CompilerGenerated]
	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_UserTokenIndex(uint value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3F8350 Offset: 0x3F7550 VA: 0x1803F8350
	public uint get_QueryId() { }

	[CompilerGenerated]
	// RVA: 0x3F84A0 Offset: 0x3F76A0 VA: 0x1803F84A0
	public void set_QueryId(uint value) { }
}

// Namespace: Epic.OnlineServices.RTCAdmin
internal struct CopyUserTokenByIndexOptionsInternal : ISettable<CopyUserTokenByIndexOptions>, IDisposable // TypeDefIndex: 8633
{
	// Fields
	private int m_ApiVersion; // 0x0
	private uint m_UserTokenIndex; // 0x4
	private uint m_QueryId; // 0x8

	// Properties
	public uint UserTokenIndex { set; }
	public uint QueryId { set; }

	// Methods

	// RVA: 0x3F84A0 Offset: 0x3F76A0 VA: 0x1803F84A0
	public void set_UserTokenIndex(uint value) { }

	// RVA: 0x3F5520 Offset: 0x3F4720 VA: 0x1803F5520
	public void set_QueryId(uint value) { }

	// RVA: 0x48B550 Offset: 0x48A750 VA: 0x18048B550 Slot: 4
	public void Set(ref CopyUserTokenByIndexOptions other) { }

	// RVA: 0x48B570 Offset: 0x48A770 VA: 0x18048B570 Slot: 5
	public void Set(ref Nullable<CopyUserTokenByIndexOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.RTCAdmin
public struct CopyUserTokenByUserIdOptions // TypeDefIndex: 8634
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <TargetUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private uint <QueryId>k__BackingField; // 0x8

	// Properties
	public ProductUserId TargetUserId { get; set; }
	public uint QueryId { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public ProductUserId get_TargetUserId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_TargetUserId(ProductUserId value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3F5510 Offset: 0x3F4710 VA: 0x1803F5510
	public uint get_QueryId() { }

	[CompilerGenerated]
	// RVA: 0x3F5520 Offset: 0x3F4720 VA: 0x1803F5520
	public void set_QueryId(uint value) { }
}

// Namespace: Epic.OnlineServices.RTCAdmin
internal struct CopyUserTokenByUserIdOptionsInternal : ISettable<CopyUserTokenByUserIdOptions>, IDisposable // TypeDefIndex: 8635
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_TargetUserId; // 0x8
	private uint m_QueryId; // 0x10

	// Properties
	public ProductUserId TargetUserId { set; }
	public uint QueryId { set; }

	// Methods

	// RVA: 0x48B780 Offset: 0x48A980 VA: 0x18048B780
	public void set_TargetUserId(ProductUserId value) { }

	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_QueryId(uint value) { }

	// RVA: 0x48B700 Offset: 0x48A900 VA: 0x18048B700 Slot: 4
	public void Set(ref CopyUserTokenByUserIdOptions other) { }

	// RVA: 0x48B640 Offset: 0x48A840 VA: 0x18048B640 Slot: 5
	public void Set(ref Nullable<CopyUserTokenByUserIdOptions> other) { }

	// RVA: 0x48B5F0 Offset: 0x48A7F0 VA: 0x18048B5F0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.RTCAdmin
public struct KickCompleteCallbackInfo : ICallbackInfo // TypeDefIndex: 8636
{
	// Fields
	[CompilerGenerated]
	private Result <ResultCode>k__BackingField; // 0x0
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x8

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	[CompilerGenerated]
	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public object get_ClientData() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_ClientData(object value) { }

	// RVA: 0x48DCF0 Offset: 0x48CEF0 VA: 0x18048DCF0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x48DD40 Offset: 0x48CF40 VA: 0x18048DD40
	internal void Set(ref KickCompleteCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.RTCAdmin
internal struct KickCompleteCallbackInfoInternal : ICallbackInfoInternal, IGettable<KickCompleteCallbackInfo>, ISettable<KickCompleteCallbackInfo>, IDisposable // TypeDefIndex: 8637
{
	// Fields
	private Result m_ResultCode; // 0x0
	private IntPtr m_ClientData; // 0x8

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }

	// Methods

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	// RVA: 0x48DC20 Offset: 0x48CE20 VA: 0x18048DC20
	public object get_ClientData() { }

	// RVA: 0x48DC90 Offset: 0x48CE90 VA: 0x18048DC90
	public void set_ClientData(object value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x48DB00 Offset: 0x48CD00 VA: 0x18048DB00 Slot: 6
	public void Set(ref KickCompleteCallbackInfo other) { }

	// RVA: 0x48DB60 Offset: 0x48CD60 VA: 0x18048DB60 Slot: 7
	public void Set(ref Nullable<KickCompleteCallbackInfo> other) { }

	// RVA: 0x48DA90 Offset: 0x48CC90 VA: 0x18048DA90 Slot: 8
	public void Dispose() { }

	// RVA: 0x48DAE0 Offset: 0x48CCE0 VA: 0x18048DAE0 Slot: 5
	public void Get(out KickCompleteCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.RTCAdmin
public struct KickOptions // TypeDefIndex: 8638
{
	// Fields
	[CompilerGenerated]
	private Utf8String <RoomName>k__BackingField; // 0x0
	[CompilerGenerated]
	private ProductUserId <TargetUserId>k__BackingField; // 0x8

	// Properties
	public Utf8String RoomName { get; set; }
	public ProductUserId TargetUserId { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Utf8String get_RoomName() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_RoomName(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public ProductUserId get_TargetUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_TargetUserId(ProductUserId value) { }
}

// Namespace: Epic.OnlineServices.RTCAdmin
internal struct KickOptionsInternal : ISettable<KickOptions>, IDisposable // TypeDefIndex: 8639
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_RoomName; // 0x8
	private IntPtr m_TargetUserId; // 0x10

	// Properties
	public Utf8String RoomName { set; }
	public ProductUserId TargetUserId { set; }

	// Methods

	// RVA: 0x48DFE0 Offset: 0x48D1E0 VA: 0x18048DFE0
	public void set_RoomName(Utf8String value) { }

	// RVA: 0x48E040 Offset: 0x48D240 VA: 0x18048E040
	public void set_TargetUserId(ProductUserId value) { }

	// RVA: 0x48DE20 Offset: 0x48D020 VA: 0x18048DE20 Slot: 4
	public void Set(ref KickOptions other) { }

	// RVA: 0x48DEE0 Offset: 0x48D0E0 VA: 0x18048DEE0 Slot: 5
	public void Set(ref Nullable<KickOptions> other) { }

	// RVA: 0x48DDC0 Offset: 0x48CFC0 VA: 0x18048DDC0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.RTCAdmin
public sealed class OnKickCompleteCallback : MulticastDelegate // TypeDefIndex: 8640
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref KickCompleteCallbackInfo data) { }

	// RVA: 0x48F9E0 Offset: 0x48EBE0 VA: 0x18048F9E0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref KickCompleteCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref KickCompleteCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.RTCAdmin
[UnmanagedFunctionPointer(2)]
internal sealed class OnKickCompleteCallbackInternal : MulticastDelegate // TypeDefIndex: 8641
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref KickCompleteCallbackInfoInternal data) { }

	// RVA: 0x48F950 Offset: 0x48EB50 VA: 0x18048F950 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref KickCompleteCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref KickCompleteCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.RTCAdmin
public sealed class OnQueryJoinRoomTokenCompleteCallback : MulticastDelegate // TypeDefIndex: 8642
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref QueryJoinRoomTokenCompleteCallbackInfo data) { }

	// RVA: 0x48FE60 Offset: 0x48F060 VA: 0x18048FE60 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref QueryJoinRoomTokenCompleteCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref QueryJoinRoomTokenCompleteCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.RTCAdmin
[UnmanagedFunctionPointer(2)]
internal sealed class OnQueryJoinRoomTokenCompleteCallbackInternal : MulticastDelegate // TypeDefIndex: 8643
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref QueryJoinRoomTokenCompleteCallbackInfoInternal data) { }

	// RVA: 0x48FDD0 Offset: 0x48EFD0 VA: 0x18048FDD0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref QueryJoinRoomTokenCompleteCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref QueryJoinRoomTokenCompleteCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.RTCAdmin
public sealed class OnSetParticipantHardMuteCompleteCallback : MulticastDelegate // TypeDefIndex: 8644
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref SetParticipantHardMuteCompleteCallbackInfo data) { }

	// RVA: 0x4901C0 Offset: 0x48F3C0 VA: 0x1804901C0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref SetParticipantHardMuteCompleteCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref SetParticipantHardMuteCompleteCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.RTCAdmin
[UnmanagedFunctionPointer(2)]
internal sealed class OnSetParticipantHardMuteCompleteCallbackInternal : MulticastDelegate // TypeDefIndex: 8645
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref SetParticipantHardMuteCompleteCallbackInfoInternal data) { }

	// RVA: 0x490130 Offset: 0x48F330 VA: 0x180490130 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref SetParticipantHardMuteCompleteCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref SetParticipantHardMuteCompleteCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.RTCAdmin
public struct QueryJoinRoomTokenCompleteCallbackInfo : ICallbackInfo // TypeDefIndex: 8646
{
	// Fields
	[CompilerGenerated]
	private Result <ResultCode>k__BackingField; // 0x0
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x8
	[CompilerGenerated]
	private Utf8String <RoomName>k__BackingField; // 0x10
	[CompilerGenerated]
	private Utf8String <ClientBaseUrl>k__BackingField; // 0x18
	[CompilerGenerated]
	private uint <QueryId>k__BackingField; // 0x20
	[CompilerGenerated]
	private uint <TokenCount>k__BackingField; // 0x24

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public Utf8String RoomName { get; set; }
	public Utf8String ClientBaseUrl { get; set; }
	public uint QueryId { get; set; }
	public uint TokenCount { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	[CompilerGenerated]
	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public object get_ClientData() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_ClientData(object value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Utf8String get_RoomName() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_RoomName(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public Utf8String get_ClientBaseUrl() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_ClientBaseUrl(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400
	public uint get_QueryId() { }

	[CompilerGenerated]
	// RVA: 0x3DA420 Offset: 0x3D9620 VA: 0x1803DA420
	public void set_QueryId(uint value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x47BD90 Offset: 0x47AF90 VA: 0x18047BD90
	public uint get_TokenCount() { }

	[CompilerGenerated]
	// RVA: 0x47C1C0 Offset: 0x47B3C0 VA: 0x18047C1C0
	public void set_TokenCount(uint value) { }

	// RVA: 0x4968B0 Offset: 0x495AB0 VA: 0x1804968B0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x496900 Offset: 0x495B00 VA: 0x180496900
	internal void Set(ref QueryJoinRoomTokenCompleteCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.RTCAdmin
internal struct QueryJoinRoomTokenCompleteCallbackInfoInternal : ICallbackInfoInternal, IGettable<QueryJoinRoomTokenCompleteCallbackInfo>, ISettable<QueryJoinRoomTokenCompleteCallbackInfo>, IDisposable // TypeDefIndex: 8647
{
	// Fields
	private Result m_ResultCode; // 0x0
	private IntPtr m_ClientData; // 0x8
	private IntPtr m_RoomName; // 0x10
	private IntPtr m_ClientBaseUrl; // 0x18
	private uint m_QueryId; // 0x20
	private uint m_TokenCount; // 0x24

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public Utf8String RoomName { get; set; }
	public Utf8String ClientBaseUrl { get; set; }
	public uint QueryId { get; set; }
	public uint TokenCount { get; set; }

	// Methods

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	// RVA: 0x4966B0 Offset: 0x4958B0 VA: 0x1804966B0
	public object get_ClientData() { }

	// RVA: 0x4967F0 Offset: 0x4959F0 VA: 0x1804967F0
	public void set_ClientData(object value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x496720 Offset: 0x495920 VA: 0x180496720
	public Utf8String get_RoomName() { }

	// RVA: 0x496850 Offset: 0x495A50 VA: 0x180496850
	public void set_RoomName(Utf8String value) { }

	// RVA: 0x496640 Offset: 0x495840 VA: 0x180496640
	public Utf8String get_ClientBaseUrl() { }

	// RVA: 0x496790 Offset: 0x495990 VA: 0x180496790
	public void set_ClientBaseUrl(Utf8String value) { }

	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400
	public uint get_QueryId() { }

	// RVA: 0x3DA420 Offset: 0x3D9620 VA: 0x1803DA420
	public void set_QueryId(uint value) { }

	// RVA: 0x47BD90 Offset: 0x47AF90 VA: 0x18047BD90
	public uint get_TokenCount() { }

	// RVA: 0x47C1C0 Offset: 0x47B3C0 VA: 0x18047C1C0
	public void set_TokenCount(uint value) { }

	// RVA: 0x496530 Offset: 0x495730 VA: 0x180496530 Slot: 6
	public void Set(ref QueryJoinRoomTokenCompleteCallbackInfo other) { }

	// RVA: 0x496390 Offset: 0x495590 VA: 0x180496390 Slot: 7
	public void Set(ref Nullable<QueryJoinRoomTokenCompleteCallbackInfo> other) { }

	// RVA: 0x496300 Offset: 0x495500 VA: 0x180496300 Slot: 8
	public void Dispose() { }

	// RVA: 0x496360 Offset: 0x495560 VA: 0x180496360 Slot: 5
	public void Get(out QueryJoinRoomTokenCompleteCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.RTCAdmin
public struct QueryJoinRoomTokenOptions // TypeDefIndex: 8648
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <RoomName>k__BackingField; // 0x8
	[CompilerGenerated]
	private ProductUserId[] <TargetUserIds>k__BackingField; // 0x10
	[CompilerGenerated]
	private Utf8String <TargetUserIpAddresses>k__BackingField; // 0x18

	// Properties
	public ProductUserId LocalUserId { get; set; }
	public Utf8String RoomName { get; set; }
	public ProductUserId[] TargetUserIds { get; set; }
	public Utf8String TargetUserIpAddresses { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_LocalUserId(ProductUserId value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public Utf8String get_RoomName() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_RoomName(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public ProductUserId[] get_TargetUserIds() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_TargetUserIds(ProductUserId[] value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public Utf8String get_TargetUserIpAddresses() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_TargetUserIpAddresses(Utf8String value) { }
}

// Namespace: Epic.OnlineServices.RTCAdmin
internal struct QueryJoinRoomTokenOptionsInternal : ISettable<QueryJoinRoomTokenOptions>, IDisposable // TypeDefIndex: 8649
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_RoomName; // 0x10
	private IntPtr m_TargetUserIds; // 0x18
	private uint m_TargetUserIdsCount; // 0x20
	private IntPtr m_TargetUserIpAddresses; // 0x28

	// Properties
	public ProductUserId LocalUserId { set; }
	public Utf8String RoomName { set; }
	public ProductUserId[] TargetUserIds { set; }
	public Utf8String TargetUserIpAddresses { set; }

	// Methods

	// RVA: 0x496D80 Offset: 0x495F80 VA: 0x180496D80
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x496DE0 Offset: 0x495FE0 VA: 0x180496DE0
	public void set_RoomName(Utf8String value) { }

	// RVA: 0x496E40 Offset: 0x496040 VA: 0x180496E40
	public void set_TargetUserIds(ProductUserId[] value) { }

	// RVA: 0x496EB0 Offset: 0x4960B0 VA: 0x180496EB0
	public void set_TargetUserIpAddresses(Utf8String value) { }

	// RVA: 0x496AB0 Offset: 0x495CB0 VA: 0x180496AB0 Slot: 4
	public void Set(ref QueryJoinRoomTokenOptions other) { }

	// RVA: 0x496C00 Offset: 0x495E00 VA: 0x180496C00 Slot: 5
	public void Set(ref Nullable<QueryJoinRoomTokenOptions> other) { }

	// RVA: 0x496A40 Offset: 0x495C40 VA: 0x180496A40 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.RTCAdmin
public sealed class RTCAdminInterface : Handle // TypeDefIndex: 8650
{
	// Fields
	public const int CopyusertokenbyindexApiLatest = 2;
	public const int CopyusertokenbyuseridApiLatest = 2;
	public const int KickApiLatest = 1;
	public const int QueryjoinroomtokenApiLatest = 2;
	public const int SetparticipanthardmuteApiLatest = 1;
	public const int UsertokenApiLatest = 1;

	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }

	// RVA: 0x40BDB0 Offset: 0x40AFB0 VA: 0x18040BDB0
	public void .ctor(IntPtr innerHandle) { }

	// RVA: 0x496F10 Offset: 0x496110 VA: 0x180496F10
	public Result CopyUserTokenByIndex(ref CopyUserTokenByIndexOptions options, out Nullable<UserToken> outUserToken) { }

	// RVA: 0x497000 Offset: 0x496200 VA: 0x180497000
	public Result CopyUserTokenByUserId(ref CopyUserTokenByUserIdOptions options, out Nullable<UserToken> outUserToken) { }

	// RVA: 0x497150 Offset: 0x496350 VA: 0x180497150
	public void Kick(ref KickOptions options, object clientData, OnKickCompleteCallback completionDelegate) { }

	// RVA: 0x4974F0 Offset: 0x4966F0 VA: 0x1804974F0
	public void QueryJoinRoomToken(ref QueryJoinRoomTokenOptions options, object clientData, OnQueryJoinRoomTokenCompleteCallback completionDelegate) { }

	// RVA: 0x4976B0 Offset: 0x4968B0 VA: 0x1804976B0
	public void SetParticipantHardMute(ref SetParticipantHardMuteOptions options, object clientData, OnSetParticipantHardMuteCompleteCallback completionDelegate) { }

	[MonoPInvokeCallback(typeof(OnKickCompleteCallbackInternal))]
	// RVA: 0x497300 Offset: 0x496500 VA: 0x180497300
	internal static void OnKickCompleteCallbackInternalImplementation(ref KickCompleteCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnQueryJoinRoomTokenCompleteCallbackInternal))]
	// RVA: 0x4973A0 Offset: 0x4965A0 VA: 0x1804973A0
	internal static void OnQueryJoinRoomTokenCompleteCallbackInternalImplementation(ref QueryJoinRoomTokenCompleteCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnSetParticipantHardMuteCompleteCallbackInternal))]
	// RVA: 0x497450 Offset: 0x496650 VA: 0x180497450
	internal static void OnSetParticipantHardMuteCompleteCallbackInternalImplementation(ref SetParticipantHardMuteCompleteCallbackInfoInternal data) { }
}

// Namespace: Epic.OnlineServices.RTCAdmin
public struct SetParticipantHardMuteCompleteCallbackInfo : ICallbackInfo // TypeDefIndex: 8651
{
	// Fields
	[CompilerGenerated]
	private Result <ResultCode>k__BackingField; // 0x0
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x8

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	[CompilerGenerated]
	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public object get_ClientData() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_ClientData(object value) { }

	// RVA: 0x49A600 Offset: 0x499800 VA: 0x18049A600 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x49A650 Offset: 0x499850 VA: 0x18049A650
	internal void Set(ref SetParticipantHardMuteCompleteCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.RTCAdmin
internal struct SetParticipantHardMuteCompleteCallbackInfoInternal : ICallbackInfoInternal, IGettable<SetParticipantHardMuteCompleteCallbackInfo>, ISettable<SetParticipantHardMuteCompleteCallbackInfo>, IDisposable // TypeDefIndex: 8652
{
	// Fields
	private Result m_ResultCode; // 0x0
	private IntPtr m_ClientData; // 0x8

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }

	// Methods

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	// RVA: 0x49A530 Offset: 0x499730 VA: 0x18049A530
	public object get_ClientData() { }

	// RVA: 0x49A5A0 Offset: 0x4997A0 VA: 0x18049A5A0
	public void set_ClientData(object value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x49A410 Offset: 0x499610 VA: 0x18049A410 Slot: 6
	public void Set(ref SetParticipantHardMuteCompleteCallbackInfo other) { }

	// RVA: 0x49A470 Offset: 0x499670 VA: 0x18049A470 Slot: 7
	public void Set(ref Nullable<SetParticipantHardMuteCompleteCallbackInfo> other) { }

	// RVA: 0x49A3A0 Offset: 0x4995A0 VA: 0x18049A3A0 Slot: 8
	public void Dispose() { }

	// RVA: 0x49A3F0 Offset: 0x4995F0 VA: 0x18049A3F0 Slot: 5
	public void Get(out SetParticipantHardMuteCompleteCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.RTCAdmin
public struct SetParticipantHardMuteOptions // TypeDefIndex: 8653
{
	// Fields
	[CompilerGenerated]
	private Utf8String <RoomName>k__BackingField; // 0x0
	[CompilerGenerated]
	private ProductUserId <TargetUserId>k__BackingField; // 0x8
	[CompilerGenerated]
	private bool <Mute>k__BackingField; // 0x10

	// Properties
	public Utf8String RoomName { get; set; }
	public ProductUserId TargetUserId { get; set; }
	public bool Mute { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Utf8String get_RoomName() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_RoomName(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public ProductUserId get_TargetUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_TargetUserId(ProductUserId value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	public bool get_Mute() { }

	[CompilerGenerated]
	// RVA: 0x3D6DB0 Offset: 0x3D5FB0 VA: 0x1803D6DB0
	public void set_Mute(bool value) { }
}

// Namespace: Epic.OnlineServices.RTCAdmin
internal struct SetParticipantHardMuteOptionsInternal : ISettable<SetParticipantHardMuteOptions>, IDisposable // TypeDefIndex: 8654
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_RoomName; // 0x8
	private IntPtr m_TargetUserId; // 0x10
	private int m_Mute; // 0x18

	// Properties
	public Utf8String RoomName { set; }
	public ProductUserId TargetUserId { set; }
	public bool Mute { set; }

	// Methods

	// RVA: 0x49A9F0 Offset: 0x499BF0 VA: 0x18049A9F0
	public void set_RoomName(Utf8String value) { }

	// RVA: 0x49AA50 Offset: 0x499C50 VA: 0x18049AA50
	public void set_TargetUserId(ProductUserId value) { }

	// RVA: 0x49A990 Offset: 0x499B90 VA: 0x18049A990
	public void set_Mute(bool value) { }

	// RVA: 0x49A890 Offset: 0x499A90 VA: 0x18049A890 Slot: 4
	public void Set(ref SetParticipantHardMuteOptions other) { }

	// RVA: 0x49A730 Offset: 0x499930 VA: 0x18049A730 Slot: 5
	public void Set(ref Nullable<SetParticipantHardMuteOptions> other) { }

	// RVA: 0x49A6D0 Offset: 0x4998D0 VA: 0x18049A6D0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.RTCAdmin
public struct UserToken // TypeDefIndex: 8655
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <ProductUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <Token>k__BackingField; // 0x8

	// Properties
	public ProductUserId ProductUserId { get; set; }
	public Utf8String Token { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public ProductUserId get_ProductUserId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_ProductUserId(ProductUserId value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public Utf8String get_Token() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_Token(Utf8String value) { }

	// RVA: 0x4A00E0 Offset: 0x49F2E0 VA: 0x1804A00E0
	internal void Set(ref UserTokenInternal other) { }
}

// Namespace: Epic.OnlineServices.RTCAdmin
internal struct UserTokenInternal : IGettable<UserToken>, ISettable<UserToken>, IDisposable // TypeDefIndex: 8656
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_ProductUserId; // 0x8
	private IntPtr m_Token; // 0x10

	// Properties
	public ProductUserId ProductUserId { get; set; }
	public Utf8String Token { get; set; }

	// Methods

	// RVA: 0x49FF30 Offset: 0x49F130 VA: 0x18049FF30
	public ProductUserId get_ProductUserId() { }

	// RVA: 0x4A0020 Offset: 0x49F220 VA: 0x1804A0020
	public void set_ProductUserId(ProductUserId value) { }

	// RVA: 0x49FFB0 Offset: 0x49F1B0 VA: 0x18049FFB0
	public Utf8String get_Token() { }

	// RVA: 0x4A0080 Offset: 0x49F280 VA: 0x1804A0080
	public void set_Token(Utf8String value) { }

	// RVA: 0x49FE70 Offset: 0x49F070 VA: 0x18049FE70 Slot: 5
	public void Set(ref UserToken other) { }

	// RVA: 0x49FD70 Offset: 0x49EF70 VA: 0x18049FD70 Slot: 6
	public void Set(ref Nullable<UserToken> other) { }

	// RVA: 0x49FCF0 Offset: 0x49EEF0 VA: 0x18049FCF0 Slot: 7
	public void Dispose() { }

	// RVA: 0x49FD50 Offset: 0x49EF50 VA: 0x18049FD50 Slot: 4
	public void Get(out UserToken output) { }
}

// Namespace: Epic.OnlineServices.RTC
public struct AddNotifyDisconnectedOptions // TypeDefIndex: 8657
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <RoomName>k__BackingField; // 0x8

	// Properties
	public ProductUserId LocalUserId { get; set; }
	public Utf8String RoomName { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_LocalUserId(ProductUserId value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public Utf8String get_RoomName() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_RoomName(Utf8String value) { }
}

// Namespace: Epic.OnlineServices.RTC
internal struct AddNotifyDisconnectedOptionsInternal : ISettable<AddNotifyDisconnectedOptions>, IDisposable // TypeDefIndex: 8658
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_RoomName; // 0x10

	// Properties
	public ProductUserId LocalUserId { set; }
	public Utf8String RoomName { set; }

	// Methods

	// RVA: 0x489F70 Offset: 0x489170 VA: 0x180489F70
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x489FD0 Offset: 0x4891D0 VA: 0x180489FD0
	public void set_RoomName(Utf8String value) { }

	// RVA: 0x489EB0 Offset: 0x4890B0 VA: 0x180489EB0 Slot: 4
	public void Set(ref AddNotifyDisconnectedOptions other) { }

	// RVA: 0x489DB0 Offset: 0x488FB0 VA: 0x180489DB0 Slot: 5
	public void Set(ref Nullable<AddNotifyDisconnectedOptions> other) { }

	// RVA: 0x489D50 Offset: 0x488F50 VA: 0x180489D50 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.RTC
public struct AddNotifyParticipantStatusChangedOptions // TypeDefIndex: 8659
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <RoomName>k__BackingField; // 0x8

	// Properties
	public ProductUserId LocalUserId { get; set; }
	public Utf8String RoomName { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_LocalUserId(ProductUserId value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public Utf8String get_RoomName() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_RoomName(Utf8String value) { }
}

// Namespace: Epic.OnlineServices.RTC
internal struct AddNotifyParticipantStatusChangedOptionsInternal : ISettable<AddNotifyParticipantStatusChangedOptions>, IDisposable // TypeDefIndex: 8660
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_RoomName; // 0x10

	// Properties
	public ProductUserId LocalUserId { set; }
	public Utf8String RoomName { set; }

	// Methods

	// RVA: 0x48A2F0 Offset: 0x4894F0 VA: 0x18048A2F0
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x48A350 Offset: 0x489550 VA: 0x18048A350
	public void set_RoomName(Utf8String value) { }

	// RVA: 0x48A230 Offset: 0x489430 VA: 0x18048A230 Slot: 4
	public void Set(ref AddNotifyParticipantStatusChangedOptions other) { }

	// RVA: 0x48A130 Offset: 0x489330 VA: 0x18048A130 Slot: 5
	public void Set(ref Nullable<AddNotifyParticipantStatusChangedOptions> other) { }

	// RVA: 0x48A0D0 Offset: 0x4892D0 VA: 0x18048A0D0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.RTC
public struct AddNotifyRoomStatisticsUpdatedOptions // TypeDefIndex: 8661
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <RoomName>k__BackingField; // 0x8

	// Properties
	public ProductUserId LocalUserId { get; set; }
	public Utf8String RoomName { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_LocalUserId(ProductUserId value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public Utf8String get_RoomName() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_RoomName(Utf8String value) { }
}

// Namespace: Epic.OnlineServices.RTC
internal struct AddNotifyRoomStatisticsUpdatedOptionsInternal : ISettable<AddNotifyRoomStatisticsUpdatedOptions>, IDisposable // TypeDefIndex: 8662
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_RoomName; // 0x10

	// Properties
	public ProductUserId LocalUserId { set; }
	public Utf8String RoomName { set; }

	// Methods

	// RVA: 0x48A5D0 Offset: 0x4897D0 VA: 0x18048A5D0
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x48A630 Offset: 0x489830 VA: 0x18048A630
	public void set_RoomName(Utf8String value) { }

	// RVA: 0x48A410 Offset: 0x489610 VA: 0x18048A410 Slot: 4
	public void Set(ref AddNotifyRoomStatisticsUpdatedOptions other) { }

	// RVA: 0x48A4D0 Offset: 0x4896D0 VA: 0x18048A4D0 Slot: 5
	public void Set(ref Nullable<AddNotifyRoomStatisticsUpdatedOptions> other) { }

	// RVA: 0x48A3B0 Offset: 0x4895B0 VA: 0x18048A3B0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.RTC
public struct BlockParticipantCallbackInfo : ICallbackInfo // TypeDefIndex: 8663
{
	// Fields
	[CompilerGenerated]
	private Result <ResultCode>k__BackingField; // 0x0
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x8
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x10
	[CompilerGenerated]
	private Utf8String <RoomName>k__BackingField; // 0x18
	[CompilerGenerated]
	private ProductUserId <ParticipantId>k__BackingField; // 0x20
	[CompilerGenerated]
	private bool <Blocked>k__BackingField; // 0x28

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public ProductUserId LocalUserId { get; set; }
	public Utf8String RoomName { get; set; }
	public ProductUserId ParticipantId { get; set; }
	public bool Blocked { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	[CompilerGenerated]
	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public object get_ClientData() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_ClientData(object value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_LocalUserId(ProductUserId value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public Utf8String get_RoomName() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_RoomName(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public ProductUserId get_ParticipantId() { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_ParticipantId(ProductUserId value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x42D840 Offset: 0x42CA40 VA: 0x18042D840
	public bool get_Blocked() { }

	[CompilerGenerated]
	// RVA: 0x42D8B0 Offset: 0x42CAB0 VA: 0x18042D8B0
	public void set_Blocked(bool value) { }

	// RVA: 0x48AEE0 Offset: 0x48A0E0 VA: 0x18048AEE0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x48AF30 Offset: 0x48A130 VA: 0x18048AF30
	internal void Set(ref BlockParticipantCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.RTC
internal struct BlockParticipantCallbackInfoInternal : ICallbackInfoInternal, IGettable<BlockParticipantCallbackInfo>, ISettable<BlockParticipantCallbackInfo>, IDisposable // TypeDefIndex: 8664
{
	// Fields
	private Result m_ResultCode; // 0x0
	private IntPtr m_ClientData; // 0x8
	private IntPtr m_LocalUserId; // 0x10
	private IntPtr m_RoomName; // 0x18
	private IntPtr m_ParticipantId; // 0x20
	private int m_Blocked; // 0x28

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public ProductUserId LocalUserId { get; set; }
	public Utf8String RoomName { get; set; }
	public ProductUserId ParticipantId { get; set; }
	public bool Blocked { get; set; }

	// Methods

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	// RVA: 0x48AB20 Offset: 0x489D20 VA: 0x18048AB20
	public object get_ClientData() { }

	// RVA: 0x48AD60 Offset: 0x489F60 VA: 0x18048AD60
	public void set_ClientData(object value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x48AB90 Offset: 0x489D90 VA: 0x18048AB90
	public ProductUserId get_LocalUserId() { }

	// RVA: 0x48ADC0 Offset: 0x489FC0 VA: 0x18048ADC0
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x48AC90 Offset: 0x489E90 VA: 0x18048AC90
	public Utf8String get_RoomName() { }

	// RVA: 0x48AE80 Offset: 0x48A080 VA: 0x18048AE80
	public void set_RoomName(Utf8String value) { }

	// RVA: 0x48AC10 Offset: 0x489E10 VA: 0x18048AC10
	public ProductUserId get_ParticipantId() { }

	// RVA: 0x48AE20 Offset: 0x48A020 VA: 0x18048AE20
	public void set_ParticipantId(ProductUserId value) { }

	// RVA: 0x48AAC0 Offset: 0x489CC0 VA: 0x18048AAC0
	public bool get_Blocked() { }

	// RVA: 0x48AD00 Offset: 0x489F00 VA: 0x18048AD00
	public void set_Blocked(bool value) { }

	// RVA: 0x48A940 Offset: 0x489B40 VA: 0x18048A940 Slot: 6
	public void Set(ref BlockParticipantCallbackInfo other) { }

	// RVA: 0x48A720 Offset: 0x489920 VA: 0x18048A720 Slot: 7
	public void Set(ref Nullable<BlockParticipantCallbackInfo> other) { }

	// RVA: 0x48A690 Offset: 0x489890 VA: 0x18048A690 Slot: 8
	public void Dispose() { }

	// RVA: 0x48A700 Offset: 0x489900 VA: 0x18048A700 Slot: 5
	public void Get(out BlockParticipantCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.RTC
public struct BlockParticipantOptions // TypeDefIndex: 8665
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <RoomName>k__BackingField; // 0x8
	[CompilerGenerated]
	private ProductUserId <ParticipantId>k__BackingField; // 0x10
	[CompilerGenerated]
	private bool <Blocked>k__BackingField; // 0x18

	// Properties
	public ProductUserId LocalUserId { get; set; }
	public Utf8String RoomName { get; set; }
	public ProductUserId ParticipantId { get; set; }
	public bool Blocked { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_LocalUserId(ProductUserId value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public Utf8String get_RoomName() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_RoomName(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public ProductUserId get_ParticipantId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_ParticipantId(ProductUserId value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x411B20 Offset: 0x410D20 VA: 0x180411B20
	public bool get_Blocked() { }

	[CompilerGenerated]
	// RVA: 0x411B30 Offset: 0x410D30 VA: 0x180411B30
	public void set_Blocked(bool value) { }
}

// Namespace: Epic.OnlineServices.RTC
internal struct BlockParticipantOptionsInternal : ISettable<BlockParticipantOptions>, IDisposable // TypeDefIndex: 8666
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_RoomName; // 0x10
	private IntPtr m_ParticipantId; // 0x18
	private int m_Blocked; // 0x20

	// Properties
	public ProductUserId LocalUserId { set; }
	public Utf8String RoomName { set; }
	public ProductUserId ParticipantId { set; }
	public bool Blocked { set; }

	// Methods

	// RVA: 0x48B430 Offset: 0x48A630 VA: 0x18048B430
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x48B4F0 Offset: 0x48A6F0 VA: 0x18048B4F0
	public void set_RoomName(Utf8String value) { }

	// RVA: 0x48B490 Offset: 0x48A690 VA: 0x18048B490
	public void set_ParticipantId(ProductUserId value) { }

	// RVA: 0x48B3D0 Offset: 0x48A5D0 VA: 0x18048B3D0
	public void set_Blocked(bool value) { }

	// RVA: 0x48B290 Offset: 0x48A490 VA: 0x18048B290 Slot: 4
	public void Set(ref BlockParticipantOptions other) { }

	// RVA: 0x48B0E0 Offset: 0x48A2E0 VA: 0x18048B0E0 Slot: 5
	public void Set(ref Nullable<BlockParticipantOptions> other) { }

	// RVA: 0x48B080 Offset: 0x48A280 VA: 0x18048B080 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.RTC
public struct DisconnectedCallbackInfo : ICallbackInfo // TypeDefIndex: 8667
{
	// Fields
	[CompilerGenerated]
	private Result <ResultCode>k__BackingField; // 0x0
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x8
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x10
	[CompilerGenerated]
	private Utf8String <RoomName>k__BackingField; // 0x18

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public ProductUserId LocalUserId { get; set; }
	public Utf8String RoomName { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	[CompilerGenerated]
	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public object get_ClientData() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_ClientData(object value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_LocalUserId(ProductUserId value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public Utf8String get_RoomName() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_RoomName(Utf8String value) { }

	// RVA: 0x48BD50 Offset: 0x48AF50 VA: 0x18048BD50 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x48BDA0 Offset: 0x48AFA0 VA: 0x18048BDA0
	internal void Set(ref DisconnectedCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.RTC
internal struct DisconnectedCallbackInfoInternal : ICallbackInfoInternal, IGettable<DisconnectedCallbackInfo>, ISettable<DisconnectedCallbackInfo>, IDisposable // TypeDefIndex: 8668
{
	// Fields
	private Result m_ResultCode; // 0x0
	private IntPtr m_ClientData; // 0x8
	private IntPtr m_LocalUserId; // 0x10
	private IntPtr m_RoomName; // 0x18

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public ProductUserId LocalUserId { get; set; }
	public Utf8String RoomName { get; set; }

	// Methods

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	// RVA: 0x48BAD0 Offset: 0x48ACD0 VA: 0x18048BAD0
	public object get_ClientData() { }

	// RVA: 0x48BC30 Offset: 0x48AE30 VA: 0x18048BC30
	public void set_ClientData(object value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x48BB40 Offset: 0x48AD40 VA: 0x18048BB40
	public ProductUserId get_LocalUserId() { }

	// RVA: 0x48BC90 Offset: 0x48AE90 VA: 0x18048BC90
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x48BBC0 Offset: 0x48ADC0 VA: 0x18048BBC0
	public Utf8String get_RoomName() { }

	// RVA: 0x48BCF0 Offset: 0x48AEF0 VA: 0x18048BCF0
	public void set_RoomName(Utf8String value) { }

	// RVA: 0x48B9D0 Offset: 0x48ABD0 VA: 0x18048B9D0 Slot: 6
	public void Set(ref DisconnectedCallbackInfo other) { }

	// RVA: 0x48B860 Offset: 0x48AA60 VA: 0x18048B860 Slot: 7
	public void Set(ref Nullable<DisconnectedCallbackInfo> other) { }

	// RVA: 0x48B7E0 Offset: 0x48A9E0 VA: 0x18048B7E0 Slot: 8
	public void Dispose() { }

	// RVA: 0x48B840 Offset: 0x48AA40 VA: 0x18048B840 Slot: 5
	public void Get(out DisconnectedCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.RTC
public struct JoinRoomCallbackInfo : ICallbackInfo // TypeDefIndex: 8669
{
	// Fields
	[CompilerGenerated]
	private Result <ResultCode>k__BackingField; // 0x0
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x8
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x10
	[CompilerGenerated]
	private Utf8String <RoomName>k__BackingField; // 0x18
	[CompilerGenerated]
	private Option[] <RoomOptions>k__BackingField; // 0x20

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public ProductUserId LocalUserId { get; set; }
	public Utf8String RoomName { get; set; }
	public Option[] RoomOptions { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	[CompilerGenerated]
	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public object get_ClientData() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_ClientData(object value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_LocalUserId(ProductUserId value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public Utf8String get_RoomName() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_RoomName(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public Option[] get_RoomOptions() { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_RoomOptions(Option[] value) { }

	// RVA: 0x48D100 Offset: 0x48C300 VA: 0x18048D100 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x48D150 Offset: 0x48C350 VA: 0x18048D150
	internal void Set(ref JoinRoomCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.RTC
internal struct JoinRoomCallbackInfoInternal : ICallbackInfoInternal, IGettable<JoinRoomCallbackInfo>, ISettable<JoinRoomCallbackInfo>, IDisposable // TypeDefIndex: 8670
{
	// Fields
	private Result m_ResultCode; // 0x0
	private IntPtr m_ClientData; // 0x8
	private IntPtr m_LocalUserId; // 0x10
	private IntPtr m_RoomName; // 0x18
	private uint m_RoomOptionsCount; // 0x20
	private IntPtr m_RoomOptions; // 0x28

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public ProductUserId LocalUserId { get; set; }
	public Utf8String RoomName { get; set; }
	public Option[] RoomOptions { get; set; }

	// Methods

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	// RVA: 0x48CD80 Offset: 0x48BF80 VA: 0x18048CD80
	public object get_ClientData() { }

	// RVA: 0x48CF70 Offset: 0x48C170 VA: 0x18048CF70
	public void set_ClientData(object value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x48CDF0 Offset: 0x48BFF0 VA: 0x18048CDF0
	public ProductUserId get_LocalUserId() { }

	// RVA: 0x48CFD0 Offset: 0x48C1D0 VA: 0x18048CFD0
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x48CE70 Offset: 0x48C070 VA: 0x18048CE70
	public Utf8String get_RoomName() { }

	// RVA: 0x48D030 Offset: 0x48C230 VA: 0x18048D030
	public void set_RoomName(Utf8String value) { }

	// RVA: 0x48CEE0 Offset: 0x48C0E0 VA: 0x18048CEE0
	public Option[] get_RoomOptions() { }

	// RVA: 0x48D090 Offset: 0x48C290 VA: 0x18048D090
	public void set_RoomOptions(Option[] value) { }

	// RVA: 0x48CA90 Offset: 0x48BC90 VA: 0x18048CA90 Slot: 6
	public void Set(ref JoinRoomCallbackInfo other) { }

	// RVA: 0x48CBF0 Offset: 0x48BDF0 VA: 0x18048CBF0 Slot: 7
	public void Set(ref Nullable<JoinRoomCallbackInfo> other) { }

	// RVA: 0x48C9F0 Offset: 0x48BBF0 VA: 0x18048C9F0 Slot: 8
	public void Dispose() { }

	// RVA: 0x48CA60 Offset: 0x48BC60 VA: 0x18048CA60 Slot: 5
	public void Get(out JoinRoomCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.RTC
[Flags]
public enum JoinRoomFlags // TypeDefIndex: 8671
{
	// Fields
	public uint value__; // 0x0
	public const JoinRoomFlags None = 0;
	public const JoinRoomFlags EnableEcho = 1;
	public const JoinRoomFlags EnableDatachannel = 4;
}

// Namespace: Epic.OnlineServices.RTC
public struct JoinRoomOptions // TypeDefIndex: 8672
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <RoomName>k__BackingField; // 0x8
	[CompilerGenerated]
	private Utf8String <ClientBaseUrl>k__BackingField; // 0x10
	[CompilerGenerated]
	private Utf8String <ParticipantToken>k__BackingField; // 0x18
	[CompilerGenerated]
	private ProductUserId <ParticipantId>k__BackingField; // 0x20
	[CompilerGenerated]
	private JoinRoomFlags <Flags>k__BackingField; // 0x28
	[CompilerGenerated]
	private bool <ManualAudioInputEnabled>k__BackingField; // 0x2C
	[CompilerGenerated]
	private bool <ManualAudioOutputEnabled>k__BackingField; // 0x2D

	// Properties
	public ProductUserId LocalUserId { get; set; }
	public Utf8String RoomName { get; set; }
	public Utf8String ClientBaseUrl { get; set; }
	public Utf8String ParticipantToken { get; set; }
	public ProductUserId ParticipantId { get; set; }
	public JoinRoomFlags Flags { get; set; }
	public bool ManualAudioInputEnabled { get; set; }
	public bool ManualAudioOutputEnabled { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_LocalUserId(ProductUserId value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public Utf8String get_RoomName() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_RoomName(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Utf8String get_ClientBaseUrl() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_ClientBaseUrl(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public Utf8String get_ParticipantToken() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_ParticipantToken(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public ProductUserId get_ParticipantId() { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_ParticipantId(ProductUserId value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA050 Offset: 0x3D9250 VA: 0x1803DA050
	public JoinRoomFlags get_Flags() { }

	[CompilerGenerated]
	// RVA: 0x3DA200 Offset: 0x3D9400 VA: 0x1803DA200
	public void set_Flags(JoinRoomFlags value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x48DA50 Offset: 0x48CC50 VA: 0x18048DA50
	public bool get_ManualAudioInputEnabled() { }

	[CompilerGenerated]
	// RVA: 0x48DA70 Offset: 0x48CC70 VA: 0x18048DA70
	public void set_ManualAudioInputEnabled(bool value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x48DA60 Offset: 0x48CC60 VA: 0x18048DA60
	public bool get_ManualAudioOutputEnabled() { }

	[CompilerGenerated]
	// RVA: 0x48DA80 Offset: 0x48CC80 VA: 0x18048DA80
	public void set_ManualAudioOutputEnabled(bool value) { }
}

// Namespace: Epic.OnlineServices.RTC
internal struct JoinRoomOptionsInternal : ISettable<JoinRoomOptions>, IDisposable // TypeDefIndex: 8673
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_RoomName; // 0x10
	private IntPtr m_ClientBaseUrl; // 0x18
	private IntPtr m_ParticipantToken; // 0x20
	private IntPtr m_ParticipantId; // 0x28
	private JoinRoomFlags m_Flags; // 0x30
	private int m_ManualAudioInputEnabled; // 0x34
	private int m_ManualAudioOutputEnabled; // 0x38

	// Properties
	public ProductUserId LocalUserId { set; }
	public Utf8String RoomName { set; }
	public Utf8String ClientBaseUrl { set; }
	public Utf8String ParticipantToken { set; }
	public ProductUserId ParticipantId { set; }
	public JoinRoomFlags Flags { set; }
	public bool ManualAudioInputEnabled { set; }
	public bool ManualAudioOutputEnabled { set; }

	// Methods

	// RVA: 0x48D810 Offset: 0x48CA10 VA: 0x18048D810
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x48D9F0 Offset: 0x48CBF0 VA: 0x18048D9F0
	public void set_RoomName(Utf8String value) { }

	// RVA: 0x48D7B0 Offset: 0x48C9B0 VA: 0x18048D7B0
	public void set_ClientBaseUrl(Utf8String value) { }

	// RVA: 0x48D990 Offset: 0x48CB90 VA: 0x18048D990
	public void set_ParticipantToken(Utf8String value) { }

	// RVA: 0x48D930 Offset: 0x48CB30 VA: 0x18048D930
	public void set_ParticipantId(ProductUserId value) { }

	// RVA: 0x40D850 Offset: 0x40CA50 VA: 0x18040D850
	public void set_Flags(JoinRoomFlags value) { }

	// RVA: 0x48D870 Offset: 0x48CA70 VA: 0x18048D870
	public void set_ManualAudioInputEnabled(bool value) { }

	// RVA: 0x48D8D0 Offset: 0x48CAD0 VA: 0x18048D8D0
	public void set_ManualAudioOutputEnabled(bool value) { }

	// RVA: 0x48D5A0 Offset: 0x48C7A0 VA: 0x18048D5A0 Slot: 4
	public void Set(ref JoinRoomOptions other) { }

	// RVA: 0x48D2D0 Offset: 0x48C4D0 VA: 0x18048D2D0 Slot: 5
	public void Set(ref Nullable<JoinRoomOptions> other) { }

	// RVA: 0x48D250 Offset: 0x48C450 VA: 0x18048D250 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.RTC
public struct LeaveRoomCallbackInfo : ICallbackInfo // TypeDefIndex: 8674
{
	// Fields
	[CompilerGenerated]
	private Result <ResultCode>k__BackingField; // 0x0
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x8
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x10
	[CompilerGenerated]
	private Utf8String <RoomName>k__BackingField; // 0x18

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public ProductUserId LocalUserId { get; set; }
	public Utf8String RoomName { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	[CompilerGenerated]
	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public object get_ClientData() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_ClientData(object value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_LocalUserId(ProductUserId value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public Utf8String get_RoomName() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_RoomName(Utf8String value) { }

	// RVA: 0x48E610 Offset: 0x48D810 VA: 0x18048E610 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x48E660 Offset: 0x48D860 VA: 0x18048E660
	internal void Set(ref LeaveRoomCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.RTC
internal struct LeaveRoomCallbackInfoInternal : ICallbackInfoInternal, IGettable<LeaveRoomCallbackInfo>, ISettable<LeaveRoomCallbackInfo>, IDisposable // TypeDefIndex: 8675
{
	// Fields
	private Result m_ResultCode; // 0x0
	private IntPtr m_ClientData; // 0x8
	private IntPtr m_LocalUserId; // 0x10
	private IntPtr m_RoomName; // 0x18

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public ProductUserId LocalUserId { get; set; }
	public Utf8String RoomName { get; set; }

	// Methods

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	// RVA: 0x48E390 Offset: 0x48D590 VA: 0x18048E390
	public object get_ClientData() { }

	// RVA: 0x48E4F0 Offset: 0x48D6F0 VA: 0x18048E4F0
	public void set_ClientData(object value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x48E400 Offset: 0x48D600 VA: 0x18048E400
	public ProductUserId get_LocalUserId() { }

	// RVA: 0x48E550 Offset: 0x48D750 VA: 0x18048E550
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x48E480 Offset: 0x48D680 VA: 0x18048E480
	public Utf8String get_RoomName() { }

	// RVA: 0x48E5B0 Offset: 0x48D7B0 VA: 0x18048E5B0
	public void set_RoomName(Utf8String value) { }

	// RVA: 0x48E120 Offset: 0x48D320 VA: 0x18048E120 Slot: 6
	public void Set(ref LeaveRoomCallbackInfo other) { }

	// RVA: 0x48E220 Offset: 0x48D420 VA: 0x18048E220 Slot: 7
	public void Set(ref Nullable<LeaveRoomCallbackInfo> other) { }

	// RVA: 0x48E0A0 Offset: 0x48D2A0 VA: 0x18048E0A0 Slot: 8
	public void Dispose() { }

	// RVA: 0x48E100 Offset: 0x48D300 VA: 0x18048E100 Slot: 5
	public void Get(out LeaveRoomCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.RTC
public struct LeaveRoomOptions // TypeDefIndex: 8676
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <RoomName>k__BackingField; // 0x8

	// Properties
	public ProductUserId LocalUserId { get; set; }
	public Utf8String RoomName { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_LocalUserId(ProductUserId value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public Utf8String get_RoomName() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_RoomName(Utf8String value) { }
}

// Namespace: Epic.OnlineServices.RTC
internal struct LeaveRoomOptionsInternal : ISettable<LeaveRoomOptions>, IDisposable // TypeDefIndex: 8677
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_RoomName; // 0x10

	// Properties
	public ProductUserId LocalUserId { set; }
	public Utf8String RoomName { set; }

	// Methods

	// RVA: 0x48E970 Offset: 0x48DB70 VA: 0x18048E970
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x48E9D0 Offset: 0x48DBD0 VA: 0x18048E9D0
	public void set_RoomName(Utf8String value) { }

	// RVA: 0x48E7B0 Offset: 0x48D9B0 VA: 0x18048E7B0 Slot: 4
	public void Set(ref LeaveRoomOptions other) { }

	// RVA: 0x48E870 Offset: 0x48DA70 VA: 0x18048E870 Slot: 5
	public void Set(ref Nullable<LeaveRoomOptions> other) { }

	// RVA: 0x48E750 Offset: 0x48D950 VA: 0x18048E750 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.RTC
public sealed class OnBlockParticipantCallback : MulticastDelegate // TypeDefIndex: 8678
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref BlockParticipantCallbackInfo data) { }

	// RVA: 0x48EDD0 Offset: 0x48DFD0 VA: 0x18048EDD0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref BlockParticipantCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref BlockParticipantCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.RTC
[UnmanagedFunctionPointer(2)]
internal sealed class OnBlockParticipantCallbackInternal : MulticastDelegate // TypeDefIndex: 8679
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref BlockParticipantCallbackInfoInternal data) { }

	// RVA: 0x48ED40 Offset: 0x48DF40 VA: 0x18048ED40 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref BlockParticipantCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref BlockParticipantCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.RTC
public sealed class OnDisconnectedCallback : MulticastDelegate // TypeDefIndex: 8680
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref DisconnectedCallbackInfo data) { }

	// RVA: 0x48EEF0 Offset: 0x48E0F0 VA: 0x18048EEF0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref DisconnectedCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref DisconnectedCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.RTC
[UnmanagedFunctionPointer(2)]
internal sealed class OnDisconnectedCallbackInternal : MulticastDelegate // TypeDefIndex: 8681
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref DisconnectedCallbackInfoInternal data) { }

	// RVA: 0x48EE60 Offset: 0x48E060 VA: 0x18048EE60 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref DisconnectedCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref DisconnectedCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.RTC
public sealed class OnJoinRoomCallback : MulticastDelegate // TypeDefIndex: 8682
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref JoinRoomCallbackInfo data) { }

	// RVA: 0x48F8C0 Offset: 0x48EAC0 VA: 0x18048F8C0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref JoinRoomCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref JoinRoomCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.RTC
[UnmanagedFunctionPointer(2)]
internal sealed class OnJoinRoomCallbackInternal : MulticastDelegate // TypeDefIndex: 8683
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref JoinRoomCallbackInfoInternal data) { }

	// RVA: 0x48F830 Offset: 0x48EA30 VA: 0x18048F830 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref JoinRoomCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref JoinRoomCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.RTC
public sealed class OnLeaveRoomCallback : MulticastDelegate // TypeDefIndex: 8684
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref LeaveRoomCallbackInfo data) { }

	// RVA: 0x48FB00 Offset: 0x48ED00 VA: 0x18048FB00 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref LeaveRoomCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref LeaveRoomCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.RTC
[UnmanagedFunctionPointer(2)]
internal sealed class OnLeaveRoomCallbackInternal : MulticastDelegate // TypeDefIndex: 8685
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref LeaveRoomCallbackInfoInternal data) { }

	// RVA: 0x48FA70 Offset: 0x48EC70 VA: 0x18048FA70 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref LeaveRoomCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref LeaveRoomCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.RTC
public sealed class OnParticipantStatusChangedCallback : MulticastDelegate // TypeDefIndex: 8686
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref ParticipantStatusChangedCallbackInfo data) { }

	// RVA: 0x48FD40 Offset: 0x48EF40 VA: 0x18048FD40 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref ParticipantStatusChangedCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref ParticipantStatusChangedCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.RTC
[UnmanagedFunctionPointer(2)]
internal sealed class OnParticipantStatusChangedCallbackInternal : MulticastDelegate // TypeDefIndex: 8687
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref ParticipantStatusChangedCallbackInfoInternal data) { }

	// RVA: 0x48FCB0 Offset: 0x48EEB0 VA: 0x18048FCB0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref ParticipantStatusChangedCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref ParticipantStatusChangedCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.RTC
public sealed class OnRoomStatisticsUpdatedCallback : MulticastDelegate // TypeDefIndex: 8688
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref RoomStatisticsUpdatedInfo data) { }

	// RVA: 0x48FF80 Offset: 0x48F180 VA: 0x18048FF80 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref RoomStatisticsUpdatedInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref RoomStatisticsUpdatedInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.RTC
[UnmanagedFunctionPointer(2)]
internal sealed class OnRoomStatisticsUpdatedCallbackInternal : MulticastDelegate // TypeDefIndex: 8689
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref RoomStatisticsUpdatedInfoInternal data) { }

	// RVA: 0x48FEF0 Offset: 0x48F0F0 VA: 0x18048FEF0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref RoomStatisticsUpdatedInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref RoomStatisticsUpdatedInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.RTC
public struct Option // TypeDefIndex: 8690
{
	// Fields
	[CompilerGenerated]
	private Utf8String <Key>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <Value>k__BackingField; // 0x8

	// Properties
	public Utf8String Key { get; set; }
	public Utf8String Value { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Utf8String get_Key() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_Key(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public Utf8String get_Value() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_Value(Utf8String value) { }

	// RVA: 0x491790 Offset: 0x490990 VA: 0x180491790
	internal void Set(ref OptionInternal other) { }
}

// Namespace: Epic.OnlineServices.RTC
internal struct OptionInternal : IGettable<Option>, ISettable<Option>, IDisposable // TypeDefIndex: 8691
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_Key; // 0x8
	private IntPtr m_Value; // 0x10

	// Properties
	public Utf8String Key { get; set; }
	public Utf8String Value { get; set; }

	// Methods

	// RVA: 0x4915F0 Offset: 0x4907F0 VA: 0x1804915F0
	public Utf8String get_Key() { }

	// RVA: 0x4916D0 Offset: 0x4908D0 VA: 0x1804916D0
	public void set_Key(Utf8String value) { }

	// RVA: 0x491660 Offset: 0x490860 VA: 0x180491660
	public Utf8String get_Value() { }

	// RVA: 0x491730 Offset: 0x490930 VA: 0x180491730
	public void set_Value(Utf8String value) { }

	// RVA: 0x491530 Offset: 0x490730 VA: 0x180491530 Slot: 5
	public void Set(ref Option other) { }

	// RVA: 0x491430 Offset: 0x490630 VA: 0x180491430 Slot: 6
	public void Set(ref Nullable<Option> other) { }

	// RVA: 0x4913B0 Offset: 0x4905B0 VA: 0x1804913B0 Slot: 7
	public void Dispose() { }

	// RVA: 0x491410 Offset: 0x490610 VA: 0x180491410 Slot: 4
	public void Get(out Option output) { }
}

// Namespace: Epic.OnlineServices.RTC
public struct ParticipantMetadata // TypeDefIndex: 8692
{
	// Fields
	[CompilerGenerated]
	private Utf8String <Key>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <Value>k__BackingField; // 0x8

	// Properties
	public Utf8String Key { get; set; }
	public Utf8String Value { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Utf8String get_Key() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_Key(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public Utf8String get_Value() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_Value(Utf8String value) { }

	// RVA: 0x4954A0 Offset: 0x4946A0 VA: 0x1804954A0
	internal void Set(ref ParticipantMetadataInternal other) { }
}

// Namespace: Epic.OnlineServices.RTC
internal struct ParticipantMetadataInternal : IGettable<ParticipantMetadata>, ISettable<ParticipantMetadata>, IDisposable // TypeDefIndex: 8693
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_Key; // 0x8
	private IntPtr m_Value; // 0x10

	// Properties
	public Utf8String Key { get; set; }
	public Utf8String Value { get; set; }

	// Methods

	// RVA: 0x495300 Offset: 0x494500 VA: 0x180495300
	public Utf8String get_Key() { }

	// RVA: 0x4953E0 Offset: 0x4945E0 VA: 0x1804953E0
	public void set_Key(Utf8String value) { }

	// RVA: 0x495370 Offset: 0x494570 VA: 0x180495370
	public Utf8String get_Value() { }

	// RVA: 0x495440 Offset: 0x494640 VA: 0x180495440
	public void set_Value(Utf8String value) { }

	// RVA: 0x495140 Offset: 0x494340 VA: 0x180495140 Slot: 5
	public void Set(ref ParticipantMetadata other) { }

	// RVA: 0x495200 Offset: 0x494400 VA: 0x180495200 Slot: 6
	public void Set(ref Nullable<ParticipantMetadata> other) { }

	// RVA: 0x4950C0 Offset: 0x4942C0 VA: 0x1804950C0 Slot: 7
	public void Dispose() { }

	// RVA: 0x495120 Offset: 0x494320 VA: 0x180495120 Slot: 4
	public void Get(out ParticipantMetadata output) { }
}

// Namespace: Epic.OnlineServices.RTC
public struct ParticipantStatusChangedCallbackInfo : ICallbackInfo // TypeDefIndex: 8694
{
	// Fields
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x0
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x8
	[CompilerGenerated]
	private Utf8String <RoomName>k__BackingField; // 0x10
	[CompilerGenerated]
	private ProductUserId <ParticipantId>k__BackingField; // 0x18
	[CompilerGenerated]
	private RTCParticipantStatus <ParticipantStatus>k__BackingField; // 0x20
	[CompilerGenerated]
	private ParticipantMetadata[] <ParticipantMetadata>k__BackingField; // 0x28
	[CompilerGenerated]
	private bool <ParticipantInBlocklist>k__BackingField; // 0x30

	// Properties
	public object ClientData { get; set; }
	public ProductUserId LocalUserId { get; set; }
	public Utf8String RoomName { get; set; }
	public ProductUserId ParticipantId { get; set; }
	public RTCParticipantStatus ParticipantStatus { get; set; }
	public ParticipantMetadata[] ParticipantMetadata { get; set; }
	public bool ParticipantInBlocklist { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410 Slot: 4
	public object get_ClientData() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_ClientData(object value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_LocalUserId(ProductUserId value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Utf8String get_RoomName() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_RoomName(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public ProductUserId get_ParticipantId() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_ParticipantId(ProductUserId value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400
	public RTCParticipantStatus get_ParticipantStatus() { }

	[CompilerGenerated]
	// RVA: 0x3DA420 Offset: 0x3D9620 VA: 0x1803DA420
	public void set_ParticipantStatus(RTCParticipantStatus value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public ParticipantMetadata[] get_ParticipantMetadata() { }

	[CompilerGenerated]
	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	public void set_ParticipantMetadata(ParticipantMetadata[] value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x40EC40 Offset: 0x40DE40 VA: 0x18040EC40
	public bool get_ParticipantInBlocklist() { }

	[CompilerGenerated]
	// RVA: 0x40EC60 Offset: 0x40DE60 VA: 0x18040EC60
	public void set_ParticipantInBlocklist(bool value) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x495F70 Offset: 0x495170 VA: 0x180495F70
	internal void Set(ref ParticipantStatusChangedCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.RTC
internal struct ParticipantStatusChangedCallbackInfoInternal : ICallbackInfoInternal, IGettable<ParticipantStatusChangedCallbackInfo>, ISettable<ParticipantStatusChangedCallbackInfo>, IDisposable // TypeDefIndex: 8695
{
	// Fields
	private IntPtr m_ClientData; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_RoomName; // 0x10
	private IntPtr m_ParticipantId; // 0x18
	private RTCParticipantStatus m_ParticipantStatus; // 0x20
	private uint m_ParticipantMetadataCount; // 0x24
	private IntPtr m_ParticipantMetadata; // 0x28
	private int m_ParticipantInBlocklist; // 0x30

	// Properties
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public ProductUserId LocalUserId { get; set; }
	public Utf8String RoomName { get; set; }
	public ProductUserId ParticipantId { get; set; }
	public RTCParticipantStatus ParticipantStatus { get; set; }
	public ParticipantMetadata[] ParticipantMetadata { get; set; }
	public bool ParticipantInBlocklist { get; set; }

	// Methods

	// RVA: 0x495A50 Offset: 0x494C50 VA: 0x180495A50
	public object get_ClientData() { }

	// RVA: 0x495D20 Offset: 0x494F20 VA: 0x180495D20
	public void set_ClientData(object value) { }

	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x495AC0 Offset: 0x494CC0 VA: 0x180495AC0
	public ProductUserId get_LocalUserId() { }

	// RVA: 0x495D80 Offset: 0x494F80 VA: 0x180495D80
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x495CB0 Offset: 0x494EB0 VA: 0x180495CB0
	public Utf8String get_RoomName() { }

	// RVA: 0x495F10 Offset: 0x495110 VA: 0x180495F10
	public void set_RoomName(Utf8String value) { }

	// RVA: 0x495B40 Offset: 0x494D40 VA: 0x180495B40
	public ProductUserId get_ParticipantId() { }

	// RVA: 0x495DE0 Offset: 0x494FE0 VA: 0x180495DE0
	public void set_ParticipantId(ProductUserId value) { }

	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400
	public RTCParticipantStatus get_ParticipantStatus() { }

	// RVA: 0x3DA420 Offset: 0x3D9620 VA: 0x1803DA420
	public void set_ParticipantStatus(RTCParticipantStatus value) { }

	// RVA: 0x495C20 Offset: 0x494E20 VA: 0x180495C20
	public ParticipantMetadata[] get_ParticipantMetadata() { }

	// RVA: 0x495EA0 Offset: 0x4950A0 VA: 0x180495EA0
	public void set_ParticipantMetadata(ParticipantMetadata[] value) { }

	// RVA: 0x495BC0 Offset: 0x494DC0 VA: 0x180495BC0
	public bool get_ParticipantInBlocklist() { }

	// RVA: 0x495E40 Offset: 0x495040 VA: 0x180495E40
	public void set_ParticipantInBlocklist(bool value) { }

	// RVA: 0x495870 Offset: 0x494A70 VA: 0x180495870 Slot: 6
	public void Set(ref ParticipantStatusChangedCallbackInfo other) { }

	// RVA: 0x495630 Offset: 0x494830 VA: 0x180495630 Slot: 7
	public void Set(ref Nullable<ParticipantStatusChangedCallbackInfo> other) { }

	// RVA: 0x495580 Offset: 0x494780 VA: 0x180495580 Slot: 8
	public void Dispose() { }

	// RVA: 0x495600 Offset: 0x494800 VA: 0x180495600 Slot: 5
	public void Get(out ParticipantStatusChangedCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.RTC
public struct RoomStatisticsUpdatedInfo : ICallbackInfo // TypeDefIndex: 8696
{
	// Fields
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x0
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x8
	[CompilerGenerated]
	private Utf8String <RoomName>k__BackingField; // 0x10
	[CompilerGenerated]
	private Utf8String <Statistic>k__BackingField; // 0x18

	// Properties
	public object ClientData { get; set; }
	public ProductUserId LocalUserId { get; set; }
	public Utf8String RoomName { get; set; }
	public Utf8String Statistic { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410 Slot: 4
	public object get_ClientData() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_ClientData(object value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_LocalUserId(ProductUserId value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Utf8String get_RoomName() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_RoomName(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public Utf8String get_Statistic() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_Statistic(Utf8String value) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x4999D0 Offset: 0x498BD0 VA: 0x1804999D0
	internal void Set(ref RoomStatisticsUpdatedInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.RTC
internal struct RoomStatisticsUpdatedInfoInternal : ICallbackInfoInternal, IGettable<RoomStatisticsUpdatedInfo>, ISettable<RoomStatisticsUpdatedInfo>, IDisposable // TypeDefIndex: 8697
{
	// Fields
	private IntPtr m_ClientData; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_RoomName; // 0x10
	private IntPtr m_Statistic; // 0x18

	// Properties
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public ProductUserId LocalUserId { get; set; }
	public Utf8String RoomName { get; set; }
	public Utf8String Statistic { get; set; }

	// Methods

	// RVA: 0x499680 Offset: 0x498880 VA: 0x180499680
	public object get_ClientData() { }

	// RVA: 0x499850 Offset: 0x498A50 VA: 0x180499850
	public void set_ClientData(object value) { }

	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x4996F0 Offset: 0x4988F0 VA: 0x1804996F0
	public ProductUserId get_LocalUserId() { }

	// RVA: 0x4998B0 Offset: 0x498AB0 VA: 0x1804998B0
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x499770 Offset: 0x498970 VA: 0x180499770
	public Utf8String get_RoomName() { }

	// RVA: 0x499910 Offset: 0x498B10 VA: 0x180499910
	public void set_RoomName(Utf8String value) { }

	// RVA: 0x4997E0 Offset: 0x4989E0 VA: 0x1804997E0
	public Utf8String get_Statistic() { }

	// RVA: 0x499970 Offset: 0x498B70 VA: 0x180499970
	public void set_Statistic(Utf8String value) { }

	// RVA: 0x499390 Offset: 0x498590 VA: 0x180499390 Slot: 6
	public void Set(ref RoomStatisticsUpdatedInfo other) { }

	// RVA: 0x4994D0 Offset: 0x4986D0 VA: 0x1804994D0 Slot: 7
	public void Set(ref Nullable<RoomStatisticsUpdatedInfo> other) { }

	// RVA: 0x499300 Offset: 0x498500 VA: 0x180499300 Slot: 8
	public void Dispose() { }

	// RVA: 0x499370 Offset: 0x498570 VA: 0x180499370 Slot: 5
	public void Get(out RoomStatisticsUpdatedInfo output) { }
}

// Namespace: Epic.OnlineServices.RTC
public sealed class RTCInterface : Handle // TypeDefIndex: 8698
{
	// Fields
	public const int AddnotifydisconnectedApiLatest = 1;
	public const int AddnotifyparticipantstatuschangedApiLatest = 1;
	public const int AddnotifyroomstatisticsupdatedApiLatest = 1;
	public const int BlockparticipantApiLatest = 1;
	public const int JoinroomApiLatest = 1;
	public const int LeaveroomApiLatest = 1;
	public const int OptionApiLatest = 1;
	public const int OptionKeyMaxcharcount = 256;
	public const int OptionValueMaxcharcount = 256;
	public const int ParticipantmetadataApiLatest = 1;
	public const int ParticipantmetadataKeyMaxcharcount = 256;
	public const int ParticipantmetadataValueMaxcharcount = 256;
	public const int SetroomsettingApiLatest = 1;
	public const int SetsettingApiLatest = 1;

	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }

	// RVA: 0x40BDB0 Offset: 0x40AFB0 VA: 0x18040BDB0
	public void .ctor(IntPtr innerHandle) { }

	// RVA: 0x497860 Offset: 0x496A60 VA: 0x180497860
	public ulong AddNotifyDisconnected(ref AddNotifyDisconnectedOptions options, object clientData, OnDisconnectedCallback completionDelegate) { }

	// RVA: 0x497A30 Offset: 0x496C30 VA: 0x180497A30
	public ulong AddNotifyParticipantStatusChanged(ref AddNotifyParticipantStatusChangedOptions options, object clientData, OnParticipantStatusChangedCallback completionDelegate) { }

	// RVA: 0x497C00 Offset: 0x496E00 VA: 0x180497C00
	public ulong AddNotifyRoomStatisticsUpdated(ref AddNotifyRoomStatisticsUpdatedOptions options, object clientData, OnRoomStatisticsUpdatedCallback statisticsUpdateHandler) { }

	// RVA: 0x497DD0 Offset: 0x496FD0 VA: 0x180497DD0
	public void BlockParticipant(ref BlockParticipantOptions options, object clientData, OnBlockParticipantCallback completionDelegate) { }

	// RVA: 0x497F90 Offset: 0x497190 VA: 0x180497F90
	public RTCAudioInterface GetAudioInterface() { }

	// RVA: 0x498010 Offset: 0x497210 VA: 0x180498010
	public RTCDataInterface GetDataInterface() { }

	// RVA: 0x498090 Offset: 0x497290 VA: 0x180498090
	public void JoinRoom(ref JoinRoomOptions options, object clientData, OnJoinRoomCallback completionDelegate) { }

	// RVA: 0x498250 Offset: 0x497450 VA: 0x180498250
	public void LeaveRoom(ref LeaveRoomOptions options, object clientData, OnLeaveRoomCallback completionDelegate) { }

	// RVA: 0x498820 Offset: 0x497A20 VA: 0x180498820
	public void RemoveNotifyDisconnected(ulong notificationId) { }

	// RVA: 0x498890 Offset: 0x497A90 VA: 0x180498890
	public void RemoveNotifyParticipantStatusChanged(ulong notificationId) { }

	// RVA: 0x498900 Offset: 0x497B00 VA: 0x180498900
	public void RemoveNotifyRoomStatisticsUpdated(ulong notificationId) { }

	// RVA: 0x498970 Offset: 0x497B70 VA: 0x180498970
	public Result SetRoomSetting(ref SetRoomSettingOptions options) { }

	// RVA: 0x498A20 Offset: 0x497C20 VA: 0x180498A20
	public Result SetSetting(ref SetSettingOptions options) { }

	[MonoPInvokeCallback(typeof(OnBlockParticipantCallbackInternal))]
	// RVA: 0x498400 Offset: 0x497600 VA: 0x180498400
	internal static void OnBlockParticipantCallbackInternalImplementation(ref BlockParticipantCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnDisconnectedCallbackInternal))]
	// RVA: 0x4984B0 Offset: 0x4976B0 VA: 0x1804984B0
	internal static void OnDisconnectedCallbackInternalImplementation(ref DisconnectedCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnJoinRoomCallbackInternal))]
	// RVA: 0x498560 Offset: 0x497760 VA: 0x180498560
	internal static void OnJoinRoomCallbackInternalImplementation(ref JoinRoomCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnLeaveRoomCallbackInternal))]
	// RVA: 0x498610 Offset: 0x497810 VA: 0x180498610
	internal static void OnLeaveRoomCallbackInternalImplementation(ref LeaveRoomCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnParticipantStatusChangedCallbackInternal))]
	// RVA: 0x4986C0 Offset: 0x4978C0 VA: 0x1804986C0
	internal static void OnParticipantStatusChangedCallbackInternalImplementation(ref ParticipantStatusChangedCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnRoomStatisticsUpdatedCallbackInternal))]
	// RVA: 0x498770 Offset: 0x497970 VA: 0x180498770
	internal static void OnRoomStatisticsUpdatedCallbackInternalImplementation(ref RoomStatisticsUpdatedInfoInternal data) { }
}

// Namespace: Epic.OnlineServices.RTC
public enum RTCParticipantStatus // TypeDefIndex: 8699
{
	// Fields
	public int value__; // 0x0
	public const RTCParticipantStatus Joined = 0;
	public const RTCParticipantStatus Left = 1;
}

// Namespace: Epic.OnlineServices.RTC
public struct SetRoomSettingOptions // TypeDefIndex: 8700
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <RoomName>k__BackingField; // 0x8
	[CompilerGenerated]
	private Utf8String <SettingName>k__BackingField; // 0x10
	[CompilerGenerated]
	private Utf8String <SettingValue>k__BackingField; // 0x18

	// Properties
	public ProductUserId LocalUserId { get; set; }
	public Utf8String RoomName { get; set; }
	public Utf8String SettingName { get; set; }
	public Utf8String SettingValue { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_LocalUserId(ProductUserId value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public Utf8String get_RoomName() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_RoomName(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Utf8String get_SettingName() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_SettingName(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public Utf8String get_SettingValue() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_SettingValue(Utf8String value) { }
}

// Namespace: Epic.OnlineServices.RTC
internal struct SetRoomSettingOptionsInternal : ISettable<SetRoomSettingOptions>, IDisposable // TypeDefIndex: 8701
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_RoomName; // 0x10
	private IntPtr m_SettingName; // 0x18
	private IntPtr m_SettingValue; // 0x20

	// Properties
	public ProductUserId LocalUserId { set; }
	public Utf8String RoomName { set; }
	public Utf8String SettingName { set; }
	public Utf8String SettingValue { set; }

	// Methods

	// RVA: 0x49AE10 Offset: 0x49A010 VA: 0x18049AE10
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x49AE70 Offset: 0x49A070 VA: 0x18049AE70
	public void set_RoomName(Utf8String value) { }

	// RVA: 0x49AED0 Offset: 0x49A0D0 VA: 0x18049AED0
	public void set_SettingName(Utf8String value) { }

	// RVA: 0x49AF30 Offset: 0x49A130 VA: 0x18049AF30
	public void set_SettingValue(Utf8String value) { }

	// RVA: 0x49AB20 Offset: 0x499D20 VA: 0x18049AB20 Slot: 4
	public void Set(ref SetRoomSettingOptions other) { }

	// RVA: 0x49AC60 Offset: 0x499E60 VA: 0x18049AC60 Slot: 5
	public void Set(ref Nullable<SetRoomSettingOptions> other) { }

	// RVA: 0x49AAB0 Offset: 0x499CB0 VA: 0x18049AAB0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.RTC
public struct SetSettingOptions // TypeDefIndex: 8702
{
	// Fields
	[CompilerGenerated]
	private Utf8String <SettingName>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <SettingValue>k__BackingField; // 0x8

	// Properties
	public Utf8String SettingName { get; set; }
	public Utf8String SettingValue { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Utf8String get_SettingName() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_SettingName(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public Utf8String get_SettingValue() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_SettingValue(Utf8String value) { }
}

// Namespace: Epic.OnlineServices.RTC
internal struct SetSettingOptionsInternal : ISettable<SetSettingOptions>, IDisposable // TypeDefIndex: 8703
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_SettingName; // 0x8
	private IntPtr m_SettingValue; // 0x10

	// Properties
	public Utf8String SettingName { set; }
	public Utf8String SettingValue { set; }

	// Methods

	// RVA: 0x49B1B0 Offset: 0x49A3B0 VA: 0x18049B1B0
	public void set_SettingName(Utf8String value) { }

	// RVA: 0x49B210 Offset: 0x49A410 VA: 0x18049B210
	public void set_SettingValue(Utf8String value) { }

	// RVA: 0x49B0F0 Offset: 0x49A2F0 VA: 0x18049B0F0 Slot: 4
	public void Set(ref SetSettingOptions other) { }

	// RVA: 0x49AFF0 Offset: 0x49A1F0 VA: 0x18049AFF0 Slot: 5
	public void Set(ref Nullable<SetSettingOptions> other) { }

	// RVA: 0x49AF90 Offset: 0x49A190 VA: 0x18049AF90 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Reports
public sealed class OnSendPlayerBehaviorReportCompleteCallback : MulticastDelegate // TypeDefIndex: 8704
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref SendPlayerBehaviorReportCompleteCallbackInfo data) { }

	// RVA: 0x4900A0 Offset: 0x48F2A0 VA: 0x1804900A0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref SendPlayerBehaviorReportCompleteCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref SendPlayerBehaviorReportCompleteCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Reports
[UnmanagedFunctionPointer(2)]
internal sealed class OnSendPlayerBehaviorReportCompleteCallbackInternal : MulticastDelegate // TypeDefIndex: 8705
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref SendPlayerBehaviorReportCompleteCallbackInfoInternal data) { }

	// RVA: 0x490010 Offset: 0x48F210 VA: 0x180490010 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref SendPlayerBehaviorReportCompleteCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref SendPlayerBehaviorReportCompleteCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Reports
public enum PlayerReportsCategory // TypeDefIndex: 8706
{
	// Fields
	public int value__; // 0x0
	public const PlayerReportsCategory Invalid = 0;
	public const PlayerReportsCategory Cheating = 1;
	public const PlayerReportsCategory Exploiting = 2;
	public const PlayerReportsCategory OffensiveProfile = 3;
	public const PlayerReportsCategory VerbalAbuse = 4;
	public const PlayerReportsCategory Scamming = 5;
	public const PlayerReportsCategory Spamming = 6;
	public const PlayerReportsCategory Other = 7;
}

// Namespace: Epic.OnlineServices.Reports
public sealed class ReportsInterface : Handle // TypeDefIndex: 8707
{
	// Fields
	public const int ReportcontextMaxLength = 4096;
	public const int ReportmessageMaxLength = 512;
	public const int SendplayerbehaviorreportApiLatest = 2;

	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }

	// RVA: 0x40BDB0 Offset: 0x40AFB0 VA: 0x18040BDB0
	public void .ctor(IntPtr innerHandle) { }

	// RVA: 0x499140 Offset: 0x498340 VA: 0x180499140
	public void SendPlayerBehaviorReport(ref SendPlayerBehaviorReportOptions options, object clientData, OnSendPlayerBehaviorReportCompleteCallback completionDelegate) { }

	[MonoPInvokeCallback(typeof(OnSendPlayerBehaviorReportCompleteCallbackInternal))]
	// RVA: 0x4990A0 Offset: 0x4982A0 VA: 0x1804990A0
	internal static void OnSendPlayerBehaviorReportCompleteCallbackInternalImplementation(ref SendPlayerBehaviorReportCompleteCallbackInfoInternal data) { }
}

// Namespace: Epic.OnlineServices.Reports
public struct SendPlayerBehaviorReportCompleteCallbackInfo : ICallbackInfo // TypeDefIndex: 8708
{
	// Fields
	[CompilerGenerated]
	private Result <ResultCode>k__BackingField; // 0x0
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x8

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	[CompilerGenerated]
	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public object get_ClientData() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_ClientData(object value) { }

	// RVA: 0x499D70 Offset: 0x498F70 VA: 0x180499D70 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x499DC0 Offset: 0x498FC0 VA: 0x180499DC0
	internal void Set(ref SendPlayerBehaviorReportCompleteCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.Reports
internal struct SendPlayerBehaviorReportCompleteCallbackInfoInternal : ICallbackInfoInternal, IGettable<SendPlayerBehaviorReportCompleteCallbackInfo>, ISettable<SendPlayerBehaviorReportCompleteCallbackInfo>, IDisposable // TypeDefIndex: 8709
{
	// Fields
	private Result m_ResultCode; // 0x0
	private IntPtr m_ClientData; // 0x8

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }

	// Methods

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	// RVA: 0x499CA0 Offset: 0x498EA0 VA: 0x180499CA0
	public object get_ClientData() { }

	// RVA: 0x499D10 Offset: 0x498F10 VA: 0x180499D10
	public void set_ClientData(object value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x499B80 Offset: 0x498D80 VA: 0x180499B80 Slot: 6
	public void Set(ref SendPlayerBehaviorReportCompleteCallbackInfo other) { }

	// RVA: 0x499BE0 Offset: 0x498DE0 VA: 0x180499BE0 Slot: 7
	public void Set(ref Nullable<SendPlayerBehaviorReportCompleteCallbackInfo> other) { }

	// RVA: 0x499B10 Offset: 0x498D10 VA: 0x180499B10 Slot: 8
	public void Dispose() { }

	// RVA: 0x499B60 Offset: 0x498D60 VA: 0x180499B60 Slot: 5
	public void Get(out SendPlayerBehaviorReportCompleteCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.Reports
public struct SendPlayerBehaviorReportOptions // TypeDefIndex: 8710
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <ReporterUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private ProductUserId <ReportedUserId>k__BackingField; // 0x8
	[CompilerGenerated]
	private PlayerReportsCategory <Category>k__BackingField; // 0x10
	[CompilerGenerated]
	private Utf8String <Message>k__BackingField; // 0x18
	[CompilerGenerated]
	private Utf8String <Context>k__BackingField; // 0x20

	// Properties
	public ProductUserId ReporterUserId { get; set; }
	public ProductUserId ReportedUserId { get; set; }
	public PlayerReportsCategory Category { get; set; }
	public Utf8String Message { get; set; }
	public Utf8String Context { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public ProductUserId get_ReporterUserId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_ReporterUserId(ProductUserId value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public ProductUserId get_ReportedUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_ReportedUserId(ProductUserId value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public PlayerReportsCategory get_Category() { }

	[CompilerGenerated]
	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_Category(PlayerReportsCategory value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public Utf8String get_Message() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_Message(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public Utf8String get_Context() { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_Context(Utf8String value) { }
}

// Namespace: Epic.OnlineServices.Reports
internal struct SendPlayerBehaviorReportOptionsInternal : ISettable<SendPlayerBehaviorReportOptions>, IDisposable // TypeDefIndex: 8711
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_ReporterUserId; // 0x8
	private IntPtr m_ReportedUserId; // 0x10
	private PlayerReportsCategory m_Category; // 0x18
	private IntPtr m_Message; // 0x20
	private IntPtr m_Context; // 0x28

	// Properties
	public ProductUserId ReporterUserId { set; }
	public ProductUserId ReportedUserId { set; }
	public PlayerReportsCategory Category { set; }
	public Utf8String Message { set; }
	public Utf8String Context { set; }

	// Methods

	// RVA: 0x49A2E0 Offset: 0x4994E0 VA: 0x18049A2E0
	public void set_ReporterUserId(ProductUserId value) { }

	// RVA: 0x49A280 Offset: 0x499480 VA: 0x18049A280
	public void set_ReportedUserId(ProductUserId value) { }

	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	public void set_Category(PlayerReportsCategory value) { }

	// RVA: 0x49A220 Offset: 0x499420 VA: 0x18049A220
	public void set_Message(Utf8String value) { }

	// RVA: 0x49A1C0 Offset: 0x4993C0 VA: 0x18049A1C0
	public void set_Context(Utf8String value) { }

	// RVA: 0x49A080 Offset: 0x499280 VA: 0x18049A080 Slot: 4
	public void Set(ref SendPlayerBehaviorReportOptions other) { }

	// RVA: 0x499EB0 Offset: 0x4990B0 VA: 0x180499EB0 Slot: 5
	public void Set(ref Nullable<SendPlayerBehaviorReportOptions> other) { }

	// RVA: 0x499E40 Offset: 0x499040 VA: 0x180499E40 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.PS5
public sealed class IntegratedPlatform // TypeDefIndex: 8712
{
	// Fields
	public static readonly Utf8String IptPsn; // 0x0

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x48C920 Offset: 0x48BB20 VA: 0x18048C920
	private static void .cctor() { }
}

// Namespace: Epic.OnlineServices.PS5
public enum PS5AccessType // TypeDefIndex: 8713
{
	// Fields
	public int value__; // 0x0
	public const PS5AccessType Default = 0;
	public const PS5AccessType WriteCombineGpu = 1;
}

// Namespace: Epic.OnlineServices.PS5
public sealed class PS5Interface // TypeDefIndex: 8714
{
	// Methods

	[MonoPInvokeCallback(typeof(PS5VMCommitFuncInternal))]
	// RVA: 0x493020 Offset: 0x492220 VA: 0x180493020
	internal static int PS5CommitFuncInternalImplementation(IntPtr address, UIntPtr sizeInBytes, IntPtr contextData) { }

	[MonoPInvokeCallback(typeof(PS5VMDecommitFuncInternal))]
	// RVA: 0x493150 Offset: 0x492350 VA: 0x180493150
	internal static int PS5DecommitFuncInternalImplementation(IntPtr address, UIntPtr sizeInBytes, IntPtr contextData) { }

	[MonoPInvokeCallback(typeof(PS5VMReleaseFuncInternal))]
	// RVA: 0x493280 Offset: 0x492480 VA: 0x180493280
	internal static int PS5ReleaseFuncInternalImplementation(IntPtr address, UIntPtr sizeInBytes, IntPtr contextData) { }

	[MonoPInvokeCallback(typeof(PS5VMReserveFuncInternal))]
	// RVA: 0x4933B0 Offset: 0x4925B0 VA: 0x1804933B0
	internal static IntPtr PS5ReserveFuncInternalImplementation(UIntPtr sizeInBytes, PS5AccessType accessType, ref IntPtr outContextData) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: Epic.OnlineServices.PS5
public sealed class PS5VMCommitFunc : MulticastDelegate // TypeDefIndex: 8715
{
	// Methods

	// RVA: 0x409E90 Offset: 0x409090 VA: 0x180409E90
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x409CF0 Offset: 0x408EF0 VA: 0x180409CF0 Slot: 13
	public virtual bool Invoke(IntPtr address, UIntPtr sizeInBytes, IntPtr contextData) { }

	// RVA: 0x494BD0 Offset: 0x493DD0 VA: 0x180494BD0 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr address, UIntPtr sizeInBytes, IntPtr contextData, AsyncCallback callback, object object) { }

	// RVA: 0x409E60 Offset: 0x409060 VA: 0x180409E60 Slot: 15
	public virtual bool EndInvoke(IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.PS5
[UnmanagedFunctionPointer(2)]
internal sealed class PS5VMCommitFuncInternal : MulticastDelegate // TypeDefIndex: 8716
{
	// Methods

	// RVA: 0x409D10 Offset: 0x408F10 VA: 0x180409D10
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x409CF0 Offset: 0x408EF0 VA: 0x180409CF0 Slot: 13
	public virtual int Invoke(IntPtr address, UIntPtr sizeInBytes, IntPtr contextData) { }

	// RVA: 0x494B20 Offset: 0x493D20 VA: 0x180494B20 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr address, UIntPtr sizeInBytes, IntPtr contextData, AsyncCallback callback, object object) { }

	// RVA: 0x409CC0 Offset: 0x408EC0 VA: 0x180409CC0 Slot: 15
	public virtual int EndInvoke(IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.PS5
public sealed class PS5VMDecommitFunc : MulticastDelegate // TypeDefIndex: 8717
{
	// Methods

	// RVA: 0x409E90 Offset: 0x409090 VA: 0x180409E90
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x409CF0 Offset: 0x408EF0 VA: 0x180409CF0 Slot: 13
	public virtual bool Invoke(IntPtr address, UIntPtr sizeInBytes, IntPtr contextData) { }

	// RVA: 0x494D30 Offset: 0x493F30 VA: 0x180494D30 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr address, UIntPtr sizeInBytes, IntPtr contextData, AsyncCallback callback, object object) { }

	// RVA: 0x409E60 Offset: 0x409060 VA: 0x180409E60 Slot: 15
	public virtual bool EndInvoke(IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.PS5
[UnmanagedFunctionPointer(2)]
internal sealed class PS5VMDecommitFuncInternal : MulticastDelegate // TypeDefIndex: 8718
{
	// Methods

	// RVA: 0x409D10 Offset: 0x408F10 VA: 0x180409D10
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x409CF0 Offset: 0x408EF0 VA: 0x180409CF0 Slot: 13
	public virtual int Invoke(IntPtr address, UIntPtr sizeInBytes, IntPtr contextData) { }

	// RVA: 0x494C80 Offset: 0x493E80 VA: 0x180494C80 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr address, UIntPtr sizeInBytes, IntPtr contextData, AsyncCallback callback, object object) { }

	// RVA: 0x409CC0 Offset: 0x408EC0 VA: 0x180409CC0 Slot: 15
	public virtual int EndInvoke(IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.PS5
public sealed class PS5VMReleaseFunc : MulticastDelegate // TypeDefIndex: 8719
{
	// Methods

	// RVA: 0x409E90 Offset: 0x409090 VA: 0x180409E90
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x409CF0 Offset: 0x408EF0 VA: 0x180409CF0 Slot: 13
	public virtual bool Invoke(IntPtr address, UIntPtr sizeInBytes, IntPtr contextData) { }

	// RVA: 0x494E90 Offset: 0x494090 VA: 0x180494E90 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr address, UIntPtr sizeInBytes, IntPtr contextData, AsyncCallback callback, object object) { }

	// RVA: 0x409E60 Offset: 0x409060 VA: 0x180409E60 Slot: 15
	public virtual bool EndInvoke(IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.PS5
[UnmanagedFunctionPointer(2)]
internal sealed class PS5VMReleaseFuncInternal : MulticastDelegate // TypeDefIndex: 8720
{
	// Methods

	// RVA: 0x409D10 Offset: 0x408F10 VA: 0x180409D10
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x409CF0 Offset: 0x408EF0 VA: 0x180409CF0 Slot: 13
	public virtual int Invoke(IntPtr address, UIntPtr sizeInBytes, IntPtr contextData) { }

	// RVA: 0x494DE0 Offset: 0x493FE0 VA: 0x180494DE0 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr address, UIntPtr sizeInBytes, IntPtr contextData, AsyncCallback callback, object object) { }

	// RVA: 0x409CC0 Offset: 0x408EC0 VA: 0x180409CC0 Slot: 15
	public virtual int EndInvoke(IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.PS5
public sealed class PS5VMReserveFunc : MulticastDelegate // TypeDefIndex: 8721
{
	// Methods

	// RVA: 0x40A2F0 Offset: 0x4094F0 VA: 0x18040A2F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x409CF0 Offset: 0x408EF0 VA: 0x180409CF0 Slot: 13
	public virtual IntPtr Invoke(UIntPtr sizeInBytes, PS5AccessType accessType, out IntPtr outContextData) { }

	// RVA: 0x495000 Offset: 0x494200 VA: 0x180495000 Slot: 14
	public virtual IAsyncResult BeginInvoke(UIntPtr sizeInBytes, PS5AccessType accessType, out IntPtr outContextData, AsyncCallback callback, object object) { }

	// RVA: 0x40A2B0 Offset: 0x4094B0 VA: 0x18040A2B0 Slot: 15
	public virtual IntPtr EndInvoke(out IntPtr outContextData, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.PS5
[UnmanagedFunctionPointer(2)]
internal sealed class PS5VMReserveFuncInternal : MulticastDelegate // TypeDefIndex: 8722
{
	// Methods

	// RVA: 0x40A2F0 Offset: 0x4094F0 VA: 0x18040A2F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x409CF0 Offset: 0x408EF0 VA: 0x180409CF0 Slot: 13
	public virtual IntPtr Invoke(UIntPtr sizeInBytes, PS5AccessType accessType, ref IntPtr outContextData) { }

	// RVA: 0x494F40 Offset: 0x494140 VA: 0x180494F40 Slot: 14
	public virtual IAsyncResult BeginInvoke(UIntPtr sizeInBytes, PS5AccessType accessType, ref IntPtr outContextData, AsyncCallback callback, object object) { }

	// RVA: 0x40A2B0 Offset: 0x4094B0 VA: 0x18040A2B0 Slot: 15
	public virtual IntPtr EndInvoke(ref IntPtr outContextData, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.UI
public struct PS4MemoryMonitorCallbackInfo : ICallbackInfo // TypeDefIndex: 8723
{
	// Fields
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x0
	[CompilerGenerated]
	private Nullable<PS4MemoryMonitorCallbackInfoSystemMemoryMonitorReport> <SystemMemoryMonitorReport>k__BackingField; // 0x8

	// Properties
	public object ClientData { get; set; }
	public Nullable<PS4MemoryMonitorCallbackInfoSystemMemoryMonitorReport> SystemMemoryMonitorReport { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410 Slot: 4
	public object get_ClientData() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_ClientData(object value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x4157B0 Offset: 0x4149B0 VA: 0x1804157B0
	public Nullable<PS4MemoryMonitorCallbackInfoSystemMemoryMonitorReport> get_SystemMemoryMonitorReport() { }

	[CompilerGenerated]
	// RVA: 0x415800 Offset: 0x414A00 VA: 0x180415800
	public void set_SystemMemoryMonitorReport(Nullable<PS4MemoryMonitorCallbackInfoSystemMemoryMonitorReport> value) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x491D80 Offset: 0x490F80 VA: 0x180491D80
	internal void Set(ref PS4MemoryMonitorCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.UI
internal struct PS4MemoryMonitorCallbackInfoInternal : ICallbackInfoInternal, IGettable<PS4MemoryMonitorCallbackInfo>, ISettable<PS4MemoryMonitorCallbackInfo>, IDisposable // TypeDefIndex: 8724
{
	// Fields
	private IntPtr m_ClientData; // 0x0
	private IntPtr m_SystemMemoryMonitorReport; // 0x8

	// Properties
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public Nullable<PS4MemoryMonitorCallbackInfoSystemMemoryMonitorReport> SystemMemoryMonitorReport { get; set; }

	// Methods

	// RVA: 0x491AE0 Offset: 0x490CE0 VA: 0x180491AE0
	public object get_ClientData() { }

	// RVA: 0x491BD0 Offset: 0x490DD0 VA: 0x180491BD0
	public void set_ClientData(object value) { }

	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x491B50 Offset: 0x490D50 VA: 0x180491B50
	public Nullable<PS4MemoryMonitorCallbackInfoSystemMemoryMonitorReport> get_SystemMemoryMonitorReport() { }

	// RVA: 0x491C30 Offset: 0x490E30 VA: 0x180491C30
	public void set_SystemMemoryMonitorReport(Nullable<PS4MemoryMonitorCallbackInfoSystemMemoryMonitorReport> value) { }

	// RVA: 0x4918F0 Offset: 0x490AF0 VA: 0x1804918F0 Slot: 6
	public void Set(ref PS4MemoryMonitorCallbackInfo other) { }

	// RVA: 0x4919C0 Offset: 0x490BC0 VA: 0x1804919C0 Slot: 7
	public void Set(ref Nullable<PS4MemoryMonitorCallbackInfo> other) { }

	// RVA: 0x491870 Offset: 0x490A70 VA: 0x180491870 Slot: 8
	public void Dispose() { }

	// RVA: 0x4918D0 Offset: 0x490AD0 VA: 0x1804918D0 Slot: 5
	public void Get(out PS4MemoryMonitorCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.UI
public struct PS4MemoryMonitorCallbackInfoSystemMemoryMonitorReport // TypeDefIndex: 8725
{
	// Fields
	[CompilerGenerated]
	private ulong <OverlayUsedCpuMemory>k__BackingField; // 0x0
	[CompilerGenerated]
	private ulong <OverlayUsedGpuMemory>k__BackingField; // 0x8

	// Properties
	public ulong OverlayUsedCpuMemory { get; set; }
	public ulong OverlayUsedGpuMemory { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public ulong get_OverlayUsedCpuMemory() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_OverlayUsedCpuMemory(ulong value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public ulong get_OverlayUsedGpuMemory() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_OverlayUsedGpuMemory(ulong value) { }

	// RVA: 0x491D70 Offset: 0x490F70 VA: 0x180491D70
	internal void Set(ref PS4MemoryMonitorCallbackInfoSystemMemoryMonitorReportInternal other) { }
}

// Namespace: Epic.OnlineServices.UI
internal struct PS4MemoryMonitorCallbackInfoSystemMemoryMonitorReportInternal : IGettable<PS4MemoryMonitorCallbackInfoSystemMemoryMonitorReport>, ISettable<PS4MemoryMonitorCallbackInfoSystemMemoryMonitorReport>, IDisposable // TypeDefIndex: 8726
{
	// Fields
	private int m_ApiVersion; // 0x0
	private ulong m_OverlayUsedCpuMemory; // 0x8
	private ulong m_OverlayUsedGpuMemory; // 0x10

	// Properties
	public ulong OverlayUsedCpuMemory { get; set; }
	public ulong OverlayUsedGpuMemory { get; set; }

	// Methods

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public ulong get_OverlayUsedCpuMemory() { }

	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_OverlayUsedCpuMemory(ulong value) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public ulong get_OverlayUsedGpuMemory() { }

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_OverlayUsedGpuMemory(ulong value) { }

	// RVA: 0x491D50 Offset: 0x490F50 VA: 0x180491D50 Slot: 5
	public void Set(ref PS4MemoryMonitorCallbackInfoSystemMemoryMonitorReport other) { }

	// RVA: 0x491CC0 Offset: 0x490EC0 VA: 0x180491CC0 Slot: 6
	public void Set(ref Nullable<PS4MemoryMonitorCallbackInfoSystemMemoryMonitorReport> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 7
	public void Dispose() { }

	// RVA: 0x491CA0 Offset: 0x490EA0 VA: 0x180491CA0 Slot: 4
	public void Get(out PS4MemoryMonitorCallbackInfoSystemMemoryMonitorReport output) { }
}

// Namespace: Epic.OnlineServices.UI
public sealed class PS4OnMemoryMonitorCallback : MulticastDelegate // TypeDefIndex: 8727
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref PS4MemoryMonitorCallbackInfo data) { }

	// RVA: 0x491F10 Offset: 0x491110 VA: 0x180491F10 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref PS4MemoryMonitorCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref PS4MemoryMonitorCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.UI
[UnmanagedFunctionPointer(2)]
internal sealed class PS4OnMemoryMonitorCallbackInternal : MulticastDelegate // TypeDefIndex: 8728
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref PS4MemoryMonitorCallbackInfoInternal data) { }

	// RVA: 0x491E80 Offset: 0x491080 VA: 0x180491E80 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref PS4MemoryMonitorCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref PS4MemoryMonitorCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.UI
public struct PS4PrePresentOptions // TypeDefIndex: 8729
{
	// Fields
	[CompilerGenerated]
	private Nullable<PS4PrePresentOptionsPlatformSpecificData> <PlatformSpecificData>k__BackingField; // 0x0

	// Properties
	public Nullable<PS4PrePresentOptionsPlatformSpecificData> PlatformSpecificData { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x492990 Offset: 0x491B90 VA: 0x180492990
	public Nullable<PS4PrePresentOptionsPlatformSpecificData> get_PlatformSpecificData() { }

	[CompilerGenerated]
	// RVA: 0x4929C0 Offset: 0x491BC0 VA: 0x1804929C0
	public void set_PlatformSpecificData(Nullable<PS4PrePresentOptionsPlatformSpecificData> value) { }
}

// Namespace: Epic.OnlineServices.UI
internal struct PS4PrePresentOptionsInternal : ISettable<PS4PrePresentOptions>, IDisposable // TypeDefIndex: 8730
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_PlatformSpecificData; // 0x8

	// Properties
	public Nullable<PS4PrePresentOptionsPlatformSpecificData> PlatformSpecificData { set; }

	// Methods

	// RVA: 0x492180 Offset: 0x491380 VA: 0x180492180
	public void set_PlatformSpecificData(Nullable<PS4PrePresentOptionsPlatformSpecificData> value) { }

	// RVA: 0x4920F0 Offset: 0x4912F0 VA: 0x1804920F0 Slot: 4
	public void Set(ref PS4PrePresentOptions other) { }

	// RVA: 0x491FF0 Offset: 0x4911F0 VA: 0x180491FF0 Slot: 5
	public void Set(ref Nullable<PS4PrePresentOptions> other) { }

	// RVA: 0x491FA0 Offset: 0x4911A0 VA: 0x180491FA0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.UI
public struct PS4PrePresentOptionsPlatformSpecificData : ICallbackInfo // TypeDefIndex: 8731
{
	// Fields
	[CompilerGenerated]
	private IntPtr <ScreenRenderTarget>k__BackingField; // 0x0
	[CompilerGenerated]
	private PS4SubmitGraphicsCommandsCallback <SubmitGraphicsCommands>k__BackingField; // 0x8
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x10
	[CompilerGenerated]
	private Nullable<Rect> <ScreenRenderTargetSubRegion>k__BackingField; // 0x18

	// Properties
	public IntPtr ScreenRenderTarget { get; set; }
	public PS4SubmitGraphicsCommandsCallback SubmitGraphicsCommands { get; set; }
	public object ClientData { get; set; }
	public Nullable<Rect> ScreenRenderTargetSubRegion { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public IntPtr get_ScreenRenderTarget() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_ScreenRenderTarget(IntPtr value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public PS4SubmitGraphicsCommandsCallback get_SubmitGraphicsCommands() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_SubmitGraphicsCommands(PS4SubmitGraphicsCommandsCallback value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0 Slot: 4
	public object get_ClientData() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_ClientData(object value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x492960 Offset: 0x491B60 VA: 0x180492960
	public Nullable<Rect> get_ScreenRenderTargetSubRegion() { }

	[CompilerGenerated]
	// RVA: 0x492980 Offset: 0x491B80 VA: 0x180492980
	public void set_ScreenRenderTargetSubRegion(Nullable<Rect> value) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x492860 Offset: 0x491A60 VA: 0x180492860
	internal void Set(ref PS4PrePresentOptionsPlatformSpecificDataInternal other) { }
}

// Namespace: Epic.OnlineServices.UI
internal struct PS4PrePresentOptionsPlatformSpecificDataInternal : ICallbackInfoInternal, IGettable<PS4PrePresentOptionsPlatformSpecificData>, ISettable<PS4PrePresentOptionsPlatformSpecificData>, IDisposable // TypeDefIndex: 8732
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_ScreenRenderTarget; // 0x8
	private IntPtr m_SubmitGraphicsCommands; // 0x10
	private IntPtr m_ClientData; // 0x18
	private IntPtr m_ScreenRenderTargetSubRegion; // 0x20
	private static PS4SubmitGraphicsCommandsCallbackInternal s_SubmitGraphicsCommands; // 0x0

	// Properties
	public IntPtr ScreenRenderTarget { get; set; }
	public static PS4SubmitGraphicsCommandsCallbackInternal SubmitGraphicsCommands { get; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public Nullable<Rect> ScreenRenderTargetSubRegion { get; set; }

	// Methods

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public IntPtr get_ScreenRenderTarget() { }

	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_ScreenRenderTarget(IntPtr value) { }

	// RVA: 0x492670 Offset: 0x491870 VA: 0x180492670
	public static PS4SubmitGraphicsCommandsCallbackInternal get_SubmitGraphicsCommands() { }

	// RVA: 0x492580 Offset: 0x491780 VA: 0x180492580
	public object get_ClientData() { }

	// RVA: 0x492790 Offset: 0x491990 VA: 0x180492790
	public void set_ClientData(object value) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x4925F0 Offset: 0x4917F0 VA: 0x1804925F0
	public Nullable<Rect> get_ScreenRenderTargetSubRegion() { }

	// RVA: 0x4927F0 Offset: 0x4919F0 VA: 0x1804927F0
	public void set_ScreenRenderTargetSubRegion(Nullable<Rect> value) { }

	// RVA: 0x492440 Offset: 0x491640 VA: 0x180492440 Slot: 6
	public void Set(ref PS4PrePresentOptionsPlatformSpecificData other) { }

	// RVA: 0x492280 Offset: 0x491480 VA: 0x180492280 Slot: 7
	public void Set(ref Nullable<PS4PrePresentOptionsPlatformSpecificData> other) { }

	// RVA: 0x4921F0 Offset: 0x4913F0 VA: 0x1804921F0 Slot: 8
	public void Dispose() { }

	// RVA: 0x492260 Offset: 0x491460 VA: 0x180492260 Slot: 5
	public void Get(out PS4PrePresentOptionsPlatformSpecificData output) { }
}

// Namespace: Epic.OnlineServices.UI
public sealed class PS4SubmitGraphicsCommandsCallback : MulticastDelegate // TypeDefIndex: 8733
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref PS4SubmitGraphicsCommandsCallbackInfo data) { }

	// RVA: 0x492F90 Offset: 0x492190 VA: 0x180492F90 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref PS4SubmitGraphicsCommandsCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref PS4SubmitGraphicsCommandsCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.UI
[UnmanagedFunctionPointer(2)]
internal sealed class PS4SubmitGraphicsCommandsCallbackInternal : MulticastDelegate // TypeDefIndex: 8734
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref PS4SubmitGraphicsCommandsCallbackInfoInternal data) { }

	// RVA: 0x492F00 Offset: 0x492100 VA: 0x180492F00 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref PS4SubmitGraphicsCommandsCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref PS4SubmitGraphicsCommandsCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.UI
public struct PS4SubmitGraphicsCommandsCallbackInfo : ICallbackInfo // TypeDefIndex: 8735
{
	// Fields
	[CompilerGenerated]
	private uint <BuffersCount>k__BackingField; // 0x0
	[CompilerGenerated]
	private IntPtr <DispatchCommandBuffers>k__BackingField; // 0x8
	[CompilerGenerated]
	private Nullable<uint> <DispatchCommandBuffersSizes>k__BackingField; // 0x10
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x18
	[CompilerGenerated]
	private IntPtr <DispatchCommandBuffersReturnPatches>k__BackingField; // 0x20

	// Properties
	public uint BuffersCount { get; set; }
	public IntPtr DispatchCommandBuffers { get; set; }
	public Nullable<uint> DispatchCommandBuffersSizes { get; set; }
	public object ClientData { get; set; }
	public IntPtr DispatchCommandBuffersReturnPatches { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public uint get_BuffersCount() { }

	[CompilerGenerated]
	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_BuffersCount(uint value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public IntPtr get_DispatchCommandBuffers() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_DispatchCommandBuffers(IntPtr value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Nullable<uint> get_DispatchCommandBuffersSizes() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_DispatchCommandBuffersSizes(Nullable<uint> value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	public object get_ClientData() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_ClientData(object value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public IntPtr get_DispatchCommandBuffersReturnPatches() { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_DispatchCommandBuffersReturnPatches(IntPtr value) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x492E60 Offset: 0x492060 VA: 0x180492E60
	internal void Set(ref PS4SubmitGraphicsCommandsCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.UI
internal struct PS4SubmitGraphicsCommandsCallbackInfoInternal : ICallbackInfoInternal, IGettable<PS4SubmitGraphicsCommandsCallbackInfo>, ISettable<PS4SubmitGraphicsCommandsCallbackInfo>, IDisposable // TypeDefIndex: 8736
{
	// Fields
	private int m_ApiVersion; // 0x0
	private uint m_BuffersCount; // 0x4
	private IntPtr m_DispatchCommandBuffers; // 0x8
	private IntPtr m_DispatchCommandBuffersSizes; // 0x10
	private IntPtr m_ClientData; // 0x18
	private IntPtr m_DispatchCommandBuffersReturnPatches; // 0x20

	// Properties
	public uint BuffersCount { get; set; }
	public IntPtr DispatchCommandBuffers { get; set; }
	public Nullable<uint> DispatchCommandBuffersSizes { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public IntPtr DispatchCommandBuffersReturnPatches { get; set; }

	// Methods

	// RVA: 0x3F8350 Offset: 0x3F7550 VA: 0x1803F8350
	public uint get_BuffersCount() { }

	// RVA: 0x3F84A0 Offset: 0x3F76A0 VA: 0x1803F84A0
	public void set_BuffersCount(uint value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public IntPtr get_DispatchCommandBuffers() { }

	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_DispatchCommandBuffers(IntPtr value) { }

	// RVA: 0x492D10 Offset: 0x491F10 VA: 0x180492D10
	public Nullable<uint> get_DispatchCommandBuffersSizes() { }

	// RVA: 0x492DF0 Offset: 0x491FF0 VA: 0x180492DF0
	public void set_DispatchCommandBuffersSizes(Nullable<uint> value) { }

	// RVA: 0x492CA0 Offset: 0x491EA0 VA: 0x180492CA0
	public object get_ClientData() { }

	// RVA: 0x492D90 Offset: 0x491F90 VA: 0x180492D90
	public void set_ClientData(object value) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public IntPtr get_DispatchCommandBuffersReturnPatches() { }

	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_DispatchCommandBuffersReturnPatches(IntPtr value) { }

	// RVA: 0x492BC0 Offset: 0x491DC0 VA: 0x180492BC0 Slot: 6
	public void Set(ref PS4SubmitGraphicsCommandsCallbackInfo other) { }

	// RVA: 0x492A90 Offset: 0x491C90 VA: 0x180492A90 Slot: 7
	public void Set(ref Nullable<PS4SubmitGraphicsCommandsCallbackInfo> other) { }

	// RVA: 0x4929F0 Offset: 0x491BF0 VA: 0x1804929F0 Slot: 8
	public void Dispose() { }

	// RVA: 0x492A60 Offset: 0x491C60 VA: 0x180492A60 Slot: 5
	public void Get(out PS4SubmitGraphicsCommandsCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.UI
public sealed class UIInterface : Handle // TypeDefIndex: 8737
{
	// Fields
	public const int Ps4MemorymonitorcallbackinfosystemmemorymonitorreportApiLatest = 1;
	public const int Ps4PrepresentoptionsplatformspecificdataApiLatest = 4;
	public const int Ps4SubmitgraphicscommandscallbackinfoApiLatest = 2;
	public const int Ps5MemorymonitorcallbackinfosystemmemorymonitorreportApiLatest = 1;
	public const int Ps5PrepresentoptionsplatformspecificdataApiLatest = 4;
	public const int Ps5SubmitgraphicscommandscallbackinfoApiLatest = 1;
	public const int AcknowledgecorrelationidApiLatest = 1;
	public const int AcknowledgeeventidApiLatest = 1;
	public const int AddnotifydisplaysettingsupdatedApiLatest = 1;
	public const int AddnotifymemorymonitorApiLatest = 1;
	public const int AddnotifymemorymonitoroptionsApiLatest = 1;
	public const int EventidInvalid = 0;
	public const int GetfriendsexclusiveinputApiLatest = 1;
	public const int GetfriendsvisibleApiLatest = 1;
	public const int GettogglefriendsbuttonApiLatest = 1;
	public const int GettogglefriendskeyApiLatest = 1;
	public const int HidefriendsApiLatest = 1;
	public const int IssocialoverlaypausedApiLatest = 1;
	public const int MemorymonitorcallbackinfoApiLatest = 1;
	public const int PausesocialoverlayApiLatest = 1;
	public const int PrepresentApiLatest = 1;
	public const int RectApiLatest = 1;
	public const int ReportinputstateApiLatest = 2;
	public const int SetdisplaypreferenceApiLatest = 1;
	public const int SettogglefriendsbuttonApiLatest = 1;
	public const int SettogglefriendskeyApiLatest = 1;
	public const int ShowblockplayerApiLatest = 1;
	public const int ShowfriendsApiLatest = 1;
	public const int ShownativeprofileApiLatest = 1;
	public const int ShowreportplayerApiLatest = 1;
	public const int XboxonegdkMemorymonitorcallbackinfosystemmemorymonitorreportApiLatest = 1;
	public const int XboxonegdkPrepresentadditionaldataApiLatest = 1;
	public const int XboxonegdkPrepresentoptionsplatformspecificdataApiLatest = 5;
	public const int XboxonegdkSubmitgraphicscommandscallbackinfoApiLatest = 2;
	public const int XsxMemorymonitorcallbackinfosystemmemorymonitorreportApiLatest = 1;
	public const int XsxPrepresentadditionaldataApiLatest = 1;
	public const int XsxPrepresentoptionsplatformspecificdataApiLatest = 5;
	public const int XsxSubmitgraphicscommandscallbackinfoApiLatest = 2;

	// Methods

	// RVA: 0x49D170 Offset: 0x49C370 VA: 0x18049D170
	public ulong AddNotifyMemoryMonitor(ref AddNotifyMemoryMonitorOptions options, object clientData, PS4OnMemoryMonitorCallback notificationFn) { }

	// RVA: 0x49E5C0 Offset: 0x49D7C0 VA: 0x18049E5C0
	public Result PrePresent(ref PS4PrePresentOptions options) { }

	[MonoPInvokeCallback(typeof(PS4OnMemoryMonitorCallbackInternal))]
	// RVA: 0x49DE50 Offset: 0x49D050 VA: 0x18049DE50
	internal static void PS4OnMemoryMonitorCallbackInternalImplementation(ref PS4MemoryMonitorCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(PS4SubmitGraphicsCommandsCallbackInternal))]
	// RVA: 0x49DF00 Offset: 0x49D100 VA: 0x18049DF00
	internal static void PS4SubmitGraphicsCommandsCallbackInternalImplementation(ref PS4SubmitGraphicsCommandsCallbackInfoInternal data) { }

	// RVA: 0x49CCD0 Offset: 0x49BED0 VA: 0x18049CCD0
	public ulong AddNotifyMemoryMonitor(ref AddNotifyMemoryMonitorOptions options, object clientData, PS5OnMemoryMonitorCallback notificationFn) { }

	// RVA: 0x49E310 Offset: 0x49D510 VA: 0x18049E310
	public Result PrePresent(ref PS5PrePresentOptions options) { }

	[MonoPInvokeCallback(typeof(PS5OnMemoryMonitorCallbackInternal))]
	// RVA: 0x49DFF0 Offset: 0x49D1F0 VA: 0x18049DFF0
	internal static void PS5OnMemoryMonitorCallbackInternalImplementation(ref PS5MemoryMonitorCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(PS5SubmitGraphicsCommandsCallbackInternal))]
	// RVA: 0x49E0A0 Offset: 0x49D2A0 VA: 0x18049E0A0
	internal static void PS5SubmitGraphicsCommandsCallbackInternalImplementation(ref PS5SubmitGraphicsCommandsCallbackInfoInternal data) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }

	// RVA: 0x40BDB0 Offset: 0x40AFB0 VA: 0x18040BDB0
	public void .ctor(IntPtr innerHandle) { }

	// RVA: 0x49C8D0 Offset: 0x49BAD0 VA: 0x18049C8D0
	public Result AcknowledgeEventId(ref AcknowledgeEventIdOptions options) { }

	// RVA: 0x49C970 Offset: 0x49BB70 VA: 0x18049C970
	public ulong AddNotifyDisplaySettingsUpdated(ref AddNotifyDisplaySettingsUpdatedOptions options, object clientData, OnDisplaySettingsUpdatedCallback notificationFn) { }

	// RVA: 0x49CE80 Offset: 0x49C080 VA: 0x18049CE80
	public ulong AddNotifyMemoryMonitor(ref AddNotifyMemoryMonitorOptions options, object clientData, OnMemoryMonitorCallback notificationFn) { }

	// RVA: 0x49D320 Offset: 0x49C520 VA: 0x18049D320
	public bool GetFriendsExclusiveInput(ref GetFriendsExclusiveInputOptions options) { }

	// RVA: 0x49D410 Offset: 0x49C610 VA: 0x18049D410
	public bool GetFriendsVisible(ref GetFriendsVisibleOptions options) { }

	// RVA: 0x49D500 Offset: 0x49C700 VA: 0x18049D500
	public NotificationLocation GetNotificationLocationPreference() { }

	// RVA: 0x49D510 Offset: 0x49C710 VA: 0x18049D510
	public InputStateButtonFlags GetToggleFriendsButton(ref GetToggleFriendsButtonOptions options) { }

	// RVA: 0x49D590 Offset: 0x49C790 VA: 0x18049D590
	public KeyCombination GetToggleFriendsKey(ref GetToggleFriendsKeyOptions options) { }

	// RVA: 0x49D610 Offset: 0x49C810 VA: 0x18049D610
	public void HideFriends(ref HideFriendsOptions options, object clientData, OnHideFriendsCallback completionDelegate) { }

	// RVA: 0x49D800 Offset: 0x49CA00 VA: 0x18049D800
	public bool IsSocialOverlayPaused(ref IsSocialOverlayPausedOptions options) { }

	// RVA: 0x49D8A0 Offset: 0x49CAA0 VA: 0x18049D8A0
	public bool IsValidButtonCombination(InputStateButtonFlags buttonCombination) { }

	// RVA: 0x49D920 Offset: 0x49CB20 VA: 0x18049D920
	public bool IsValidKeyCombination(KeyCombination keyCombination) { }

	// RVA: 0x49E190 Offset: 0x49D390 VA: 0x18049E190
	public Result PauseSocialOverlay(ref PauseSocialOverlayOptions options) { }

	// RVA: 0x49E420 Offset: 0x49D620 VA: 0x18049E420
	public Result PrePresent(ref PrePresentOptions options) { }

	// RVA: 0x49E6D0 Offset: 0x49D8D0 VA: 0x18049E6D0
	public void RemoveNotifyDisplaySettingsUpdated(ulong id) { }

	// RVA: 0x49E740 Offset: 0x49D940 VA: 0x18049E740
	public void RemoveNotifyMemoryMonitor(ulong id) { }

	// RVA: 0x49E7B0 Offset: 0x49D9B0 VA: 0x18049E7B0
	public Result ReportInputState(ref ReportInputStateOptions options) { }

	// RVA: 0x49E860 Offset: 0x49DA60 VA: 0x18049E860
	public Result SetDisplayPreference(ref SetDisplayPreferenceOptions options) { }

	// RVA: 0x49E8F0 Offset: 0x49DAF0 VA: 0x18049E8F0
	public Result SetToggleFriendsButton(ref SetToggleFriendsButtonOptions options) { }

	// RVA: 0x49E980 Offset: 0x49DB80 VA: 0x18049E980
	public Result SetToggleFriendsKey(ref SetToggleFriendsKeyOptions options) { }

	// RVA: 0x49EA10 Offset: 0x49DC10 VA: 0x18049EA10
	public void ShowBlockPlayer(ref ShowBlockPlayerOptions options, object clientData, OnShowBlockPlayerCallback completionDelegate) { }

	// RVA: 0x49EBC0 Offset: 0x49DDC0 VA: 0x18049EBC0
	public void ShowFriends(ref ShowFriendsOptions options, object clientData, OnShowFriendsCallback completionDelegate) { }

	// RVA: 0x49EDB0 Offset: 0x49DFB0 VA: 0x18049EDB0
	public void ShowNativeProfile(ref ShowNativeProfileOptions options, object clientData, OnShowNativeProfileCallback completionDelegate) { }

	// RVA: 0x49EF60 Offset: 0x49E160 VA: 0x18049EF60
	public void ShowReportPlayer(ref ShowReportPlayerOptions options, object clientData, OnShowReportPlayerCallback completionDelegate) { }

	[MonoPInvokeCallback(typeof(OnDisplaySettingsUpdatedCallbackInternal))]
	// RVA: 0x49D9A0 Offset: 0x49CBA0 VA: 0x18049D9A0
	internal static void OnDisplaySettingsUpdatedCallbackInternalImplementation(ref OnDisplaySettingsUpdatedCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnHideFriendsCallbackInternal))]
	// RVA: 0x49DA40 Offset: 0x49CC40 VA: 0x18049DA40
	internal static void OnHideFriendsCallbackInternalImplementation(ref HideFriendsCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnMemoryMonitorCallbackInternal))]
	// RVA: 0x49DAF0 Offset: 0x49CCF0 VA: 0x18049DAF0
	internal static void OnMemoryMonitorCallbackInternalImplementation(ref MemoryMonitorCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnShowBlockPlayerCallbackInternal))]
	// RVA: 0x49DB90 Offset: 0x49CD90 VA: 0x18049DB90
	internal static void OnShowBlockPlayerCallbackInternalImplementation(ref OnShowBlockPlayerCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnShowFriendsCallbackInternal))]
	// RVA: 0x49DC40 Offset: 0x49CE40 VA: 0x18049DC40
	internal static void OnShowFriendsCallbackInternalImplementation(ref ShowFriendsCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnShowNativeProfileCallbackInternal))]
	// RVA: 0x49DCF0 Offset: 0x49CEF0 VA: 0x18049DCF0
	internal static void OnShowNativeProfileCallbackInternalImplementation(ref ShowNativeProfileCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnShowReportPlayerCallbackInternal))]
	// RVA: 0x49DDA0 Offset: 0x49CFA0 VA: 0x18049DDA0
	internal static void OnShowReportPlayerCallbackInternalImplementation(ref OnShowReportPlayerCallbackInfoInternal data) { }

	// RVA: 0x49CB20 Offset: 0x49BD20 VA: 0x18049CB20
	public ulong AddNotifyMemoryMonitor(ref AddNotifyMemoryMonitorOptions options, object clientData, XboxOneGDKOnMemoryMonitorCallback notificationFn) { }

	// RVA: 0x49E4B0 Offset: 0x49D6B0 VA: 0x18049E4B0
	public Result PrePresent(ref XboxOneGDKPrePresentOptions options) { }

	[MonoPInvokeCallback(typeof(XboxOneGDKOnMemoryMonitorCallbackInternal))]
	// RVA: 0x49F2B0 Offset: 0x49E4B0 VA: 0x18049F2B0
	internal static void XboxOneGDKOnMemoryMonitorCallbackInternalImplementation(ref XboxOneGDKMemoryMonitorCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(XboxOneGDKSubmitGraphicsCommandsCallbackInternal))]
	// RVA: 0x49F360 Offset: 0x49E560 VA: 0x18049F360
	internal static void XboxOneGDKSubmitGraphicsCommandsCallbackInternalImplementation(ref XboxOneGDKSubmitGraphicsCommandsCallbackInfoInternal data) { }

	// RVA: 0x49D030 Offset: 0x49C230 VA: 0x18049D030
	public ulong AddNotifyMemoryMonitor(ref AddNotifyMemoryMonitorOptions options, object clientData, XSXOnMemoryMonitorCallback notificationFn) { }

	// RVA: 0x49E270 Offset: 0x49D470 VA: 0x18049E270
	public Result PrePresent(ref XSXPrePresentOptions options) { }

	[MonoPInvokeCallback(typeof(XSXOnMemoryMonitorCallbackInternal))]
	// RVA: 0x49F110 Offset: 0x49E310 VA: 0x18049F110
	internal static void XSXOnMemoryMonitorCallbackInternalImplementation(ref XSXMemoryMonitorCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(XSXSubmitGraphicsCommandsCallbackInternal))]
	// RVA: 0x49F1C0 Offset: 0x49E3C0 VA: 0x18049F1C0
	internal static void XSXSubmitGraphicsCommandsCallbackInternalImplementation(ref XSXSubmitGraphicsCommandsCallbackInfoInternal data) { }
}

// Namespace: Epic.OnlineServices.UI
public struct PS5MemoryMonitorCallbackInfo : ICallbackInfo // TypeDefIndex: 8738
{
	// Fields
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x0
	[CompilerGenerated]
	private Nullable<PS5MemoryMonitorCallbackInfoSystemMemoryMonitorReport> <SystemMemoryMonitorReport>k__BackingField; // 0x8

	// Properties
	public object ClientData { get; set; }
	public Nullable<PS5MemoryMonitorCallbackInfoSystemMemoryMonitorReport> SystemMemoryMonitorReport { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410 Slot: 4
	public object get_ClientData() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_ClientData(object value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x4157B0 Offset: 0x4149B0 VA: 0x1804157B0
	public Nullable<PS5MemoryMonitorCallbackInfoSystemMemoryMonitorReport> get_SystemMemoryMonitorReport() { }

	[CompilerGenerated]
	// RVA: 0x415800 Offset: 0x414A00 VA: 0x180415800
	public void set_SystemMemoryMonitorReport(Nullable<PS5MemoryMonitorCallbackInfoSystemMemoryMonitorReport> value) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x493970 Offset: 0x492B70 VA: 0x180493970
	internal void Set(ref PS5MemoryMonitorCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.UI
internal struct PS5MemoryMonitorCallbackInfoInternal : ICallbackInfoInternal, IGettable<PS5MemoryMonitorCallbackInfo>, ISettable<PS5MemoryMonitorCallbackInfo>, IDisposable // TypeDefIndex: 8739
{
	// Fields
	private IntPtr m_ClientData; // 0x0
	private IntPtr m_SystemMemoryMonitorReport; // 0x8

	// Properties
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public Nullable<PS5MemoryMonitorCallbackInfoSystemMemoryMonitorReport> SystemMemoryMonitorReport { get; set; }

	// Methods

	// RVA: 0x493720 Offset: 0x492920 VA: 0x180493720
	public object get_ClientData() { }

	// RVA: 0x493810 Offset: 0x492A10 VA: 0x180493810
	public void set_ClientData(object value) { }

	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x493790 Offset: 0x492990 VA: 0x180493790
	public Nullable<PS5MemoryMonitorCallbackInfoSystemMemoryMonitorReport> get_SystemMemoryMonitorReport() { }

	// RVA: 0x493870 Offset: 0x492A70 VA: 0x180493870
	public void set_SystemMemoryMonitorReport(Nullable<PS5MemoryMonitorCallbackInfoSystemMemoryMonitorReport> value) { }

	// RVA: 0x493650 Offset: 0x492850 VA: 0x180493650 Slot: 6
	public void Set(ref PS5MemoryMonitorCallbackInfo other) { }

	// RVA: 0x493530 Offset: 0x492730 VA: 0x180493530 Slot: 7
	public void Set(ref Nullable<PS5MemoryMonitorCallbackInfo> other) { }

	// RVA: 0x4934B0 Offset: 0x4926B0 VA: 0x1804934B0 Slot: 8
	public void Dispose() { }

	// RVA: 0x493510 Offset: 0x492710 VA: 0x180493510 Slot: 5
	public void Get(out PS5MemoryMonitorCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.UI
public struct PS5MemoryMonitorCallbackInfoSystemMemoryMonitorReport // TypeDefIndex: 8740
{
	// Fields
	[CompilerGenerated]
	private ulong <OverlayUsedCpuMemory>k__BackingField; // 0x0
	[CompilerGenerated]
	private ulong <OverlayUsedGpuMemory>k__BackingField; // 0x8

	// Properties
	public ulong OverlayUsedCpuMemory { get; set; }
	public ulong OverlayUsedGpuMemory { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public ulong get_OverlayUsedCpuMemory() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_OverlayUsedCpuMemory(ulong value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public ulong get_OverlayUsedGpuMemory() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_OverlayUsedGpuMemory(ulong value) { }

	// RVA: 0x491D70 Offset: 0x490F70 VA: 0x180491D70
	internal void Set(ref PS5MemoryMonitorCallbackInfoSystemMemoryMonitorReportInternal other) { }
}

// Namespace: Epic.OnlineServices.UI
internal struct PS5MemoryMonitorCallbackInfoSystemMemoryMonitorReportInternal : IGettable<PS5MemoryMonitorCallbackInfoSystemMemoryMonitorReport>, ISettable<PS5MemoryMonitorCallbackInfoSystemMemoryMonitorReport>, IDisposable // TypeDefIndex: 8741
{
	// Fields
	private int m_ApiVersion; // 0x0
	private ulong m_OverlayUsedCpuMemory; // 0x8
	private ulong m_OverlayUsedGpuMemory; // 0x10

	// Properties
	public ulong OverlayUsedCpuMemory { get; set; }
	public ulong OverlayUsedGpuMemory { get; set; }

	// Methods

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public ulong get_OverlayUsedCpuMemory() { }

	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_OverlayUsedCpuMemory(ulong value) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public ulong get_OverlayUsedGpuMemory() { }

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_OverlayUsedGpuMemory(ulong value) { }

	// RVA: 0x491D50 Offset: 0x490F50 VA: 0x180491D50 Slot: 5
	public void Set(ref PS5MemoryMonitorCallbackInfoSystemMemoryMonitorReport other) { }

	// RVA: 0x4938E0 Offset: 0x492AE0 VA: 0x1804938E0 Slot: 6
	public void Set(ref Nullable<PS5MemoryMonitorCallbackInfoSystemMemoryMonitorReport> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 7
	public void Dispose() { }

	// RVA: 0x491CA0 Offset: 0x490EA0 VA: 0x180491CA0 Slot: 4
	public void Get(out PS5MemoryMonitorCallbackInfoSystemMemoryMonitorReport output) { }
}

// Namespace: Epic.OnlineServices.UI
public sealed class PS5OnMemoryMonitorCallback : MulticastDelegate // TypeDefIndex: 8742
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref PS5MemoryMonitorCallbackInfo data) { }

	// RVA: 0x493B00 Offset: 0x492D00 VA: 0x180493B00 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref PS5MemoryMonitorCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref PS5MemoryMonitorCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.UI
[UnmanagedFunctionPointer(2)]
internal sealed class PS5OnMemoryMonitorCallbackInternal : MulticastDelegate // TypeDefIndex: 8743
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref PS5MemoryMonitorCallbackInfoInternal data) { }

	// RVA: 0x493A70 Offset: 0x492C70 VA: 0x180493A70 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref PS5MemoryMonitorCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref PS5MemoryMonitorCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.UI
public struct PS5PrePresentOptions // TypeDefIndex: 8744
{
	// Fields
	[CompilerGenerated]
	private Nullable<PS5PrePresentOptionsPlatformSpecificData> <PlatformSpecificData>k__BackingField; // 0x0

	// Properties
	public Nullable<PS5PrePresentOptionsPlatformSpecificData> PlatformSpecificData { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x492990 Offset: 0x491B90 VA: 0x180492990
	public Nullable<PS5PrePresentOptionsPlatformSpecificData> get_PlatformSpecificData() { }

	[CompilerGenerated]
	// RVA: 0x4929C0 Offset: 0x491BC0 VA: 0x1804929C0
	public void set_PlatformSpecificData(Nullable<PS5PrePresentOptionsPlatformSpecificData> value) { }
}

// Namespace: Epic.OnlineServices.UI
internal struct PS5PrePresentOptionsInternal : ISettable<PS5PrePresentOptions>, IDisposable // TypeDefIndex: 8745
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_PlatformSpecificData; // 0x8

	// Properties
	public Nullable<PS5PrePresentOptionsPlatformSpecificData> PlatformSpecificData { set; }

	// Methods

	// RVA: 0x493D70 Offset: 0x492F70 VA: 0x180493D70
	public void set_PlatformSpecificData(Nullable<PS5PrePresentOptionsPlatformSpecificData> value) { }

	// RVA: 0x493CE0 Offset: 0x492EE0 VA: 0x180493CE0 Slot: 4
	public void Set(ref PS5PrePresentOptions other) { }

	// RVA: 0x493BE0 Offset: 0x492DE0 VA: 0x180493BE0 Slot: 5
	public void Set(ref Nullable<PS5PrePresentOptions> other) { }

	// RVA: 0x493B90 Offset: 0x492D90 VA: 0x180493B90 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.UI
public struct PS5PrePresentOptionsPlatformSpecificData : ICallbackInfo // TypeDefIndex: 8746
{
	// Fields
	[CompilerGenerated]
	private IntPtr <ScreenRenderTarget>k__BackingField; // 0x0
	[CompilerGenerated]
	private PS5SubmitGraphicsCommandsCallback <SubmitGraphicsCommands>k__BackingField; // 0x8
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x10
	[CompilerGenerated]
	private Nullable<Rect> <ScreenRenderTargetSubRegion>k__BackingField; // 0x18

	// Properties
	public IntPtr ScreenRenderTarget { get; set; }
	public PS5SubmitGraphicsCommandsCallback SubmitGraphicsCommands { get; set; }
	public object ClientData { get; set; }
	public Nullable<Rect> ScreenRenderTargetSubRegion { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public IntPtr get_ScreenRenderTarget() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_ScreenRenderTarget(IntPtr value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public PS5SubmitGraphicsCommandsCallback get_SubmitGraphicsCommands() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_SubmitGraphicsCommands(PS5SubmitGraphicsCommandsCallback value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0 Slot: 4
	public object get_ClientData() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_ClientData(object value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x492960 Offset: 0x491B60 VA: 0x180492960
	public Nullable<Rect> get_ScreenRenderTargetSubRegion() { }

	[CompilerGenerated]
	// RVA: 0x492980 Offset: 0x491B80 VA: 0x180492980
	public void set_ScreenRenderTargetSubRegion(Nullable<Rect> value) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x494450 Offset: 0x493650 VA: 0x180494450
	internal void Set(ref PS5PrePresentOptionsPlatformSpecificDataInternal other) { }
}

// Namespace: Epic.OnlineServices.UI
internal struct PS5PrePresentOptionsPlatformSpecificDataInternal : ICallbackInfoInternal, IGettable<PS5PrePresentOptionsPlatformSpecificData>, ISettable<PS5PrePresentOptionsPlatformSpecificData>, IDisposable // TypeDefIndex: 8747
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_ScreenRenderTarget; // 0x8
	private IntPtr m_SubmitGraphicsCommands; // 0x10
	private IntPtr m_ClientData; // 0x18
	private IntPtr m_ScreenRenderTargetSubRegion; // 0x20
	private static PS5SubmitGraphicsCommandsCallbackInternal s_SubmitGraphicsCommands; // 0x0

	// Properties
	public IntPtr ScreenRenderTarget { get; set; }
	public static PS5SubmitGraphicsCommandsCallbackInternal SubmitGraphicsCommands { get; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public Nullable<Rect> ScreenRenderTargetSubRegion { get; set; }

	// Methods

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public IntPtr get_ScreenRenderTarget() { }

	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_ScreenRenderTarget(IntPtr value) { }

	// RVA: 0x494260 Offset: 0x493460 VA: 0x180494260
	public static PS5SubmitGraphicsCommandsCallbackInternal get_SubmitGraphicsCommands() { }

	// RVA: 0x494170 Offset: 0x493370 VA: 0x180494170
	public object get_ClientData() { }

	// RVA: 0x494380 Offset: 0x493580 VA: 0x180494380
	public void set_ClientData(object value) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x4941E0 Offset: 0x4933E0 VA: 0x1804941E0
	public Nullable<Rect> get_ScreenRenderTargetSubRegion() { }

	// RVA: 0x4943E0 Offset: 0x4935E0 VA: 0x1804943E0
	public void set_ScreenRenderTargetSubRegion(Nullable<Rect> value) { }

	// RVA: 0x494030 Offset: 0x493230 VA: 0x180494030 Slot: 6
	public void Set(ref PS5PrePresentOptionsPlatformSpecificData other) { }

	// RVA: 0x493E70 Offset: 0x493070 VA: 0x180493E70 Slot: 7
	public void Set(ref Nullable<PS5PrePresentOptionsPlatformSpecificData> other) { }

	// RVA: 0x493DE0 Offset: 0x492FE0 VA: 0x180493DE0 Slot: 8
	public void Dispose() { }

	// RVA: 0x493E50 Offset: 0x493050 VA: 0x180493E50 Slot: 5
	public void Get(out PS5PrePresentOptionsPlatformSpecificData output) { }
}

// Namespace: Epic.OnlineServices.UI
public sealed class PS5SubmitGraphicsCommandsCallback : MulticastDelegate // TypeDefIndex: 8748
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref PS5SubmitGraphicsCommandsCallbackInfo data) { }

	// RVA: 0x494A90 Offset: 0x493C90 VA: 0x180494A90 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref PS5SubmitGraphicsCommandsCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref PS5SubmitGraphicsCommandsCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.UI
[UnmanagedFunctionPointer(2)]
internal sealed class PS5SubmitGraphicsCommandsCallbackInternal : MulticastDelegate // TypeDefIndex: 8749
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref PS5SubmitGraphicsCommandsCallbackInfoInternal data) { }

	// RVA: 0x494A00 Offset: 0x493C00 VA: 0x180494A00 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref PS5SubmitGraphicsCommandsCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref PS5SubmitGraphicsCommandsCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.UI
public struct PS5SubmitGraphicsCommandsCallbackInfo : ICallbackInfo // TypeDefIndex: 8750
{
	// Fields
	[CompilerGenerated]
	private uint <BuffersCount>k__BackingField; // 0x0
	[CompilerGenerated]
	private IntPtr <DispatchCommandBuffers>k__BackingField; // 0x8
	[CompilerGenerated]
	private Nullable<uint> <DispatchCommandBuffersSizes>k__BackingField; // 0x10
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x18

	// Properties
	public uint BuffersCount { get; set; }
	public IntPtr DispatchCommandBuffers { get; set; }
	public Nullable<uint> DispatchCommandBuffersSizes { get; set; }
	public object ClientData { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public uint get_BuffersCount() { }

	[CompilerGenerated]
	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_BuffersCount(uint value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public IntPtr get_DispatchCommandBuffers() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_DispatchCommandBuffers(IntPtr value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Nullable<uint> get_DispatchCommandBuffersSizes() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_DispatchCommandBuffersSizes(Nullable<uint> value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	public object get_ClientData() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_ClientData(object value) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x494970 Offset: 0x493B70 VA: 0x180494970
	internal void Set(ref PS5SubmitGraphicsCommandsCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.UI
internal struct PS5SubmitGraphicsCommandsCallbackInfoInternal : ICallbackInfoInternal, IGettable<PS5SubmitGraphicsCommandsCallbackInfo>, ISettable<PS5SubmitGraphicsCommandsCallbackInfo>, IDisposable // TypeDefIndex: 8751
{
	// Fields
	private int m_ApiVersion; // 0x0
	private uint m_BuffersCount; // 0x4
	private IntPtr m_DispatchCommandBuffers; // 0x8
	private IntPtr m_DispatchCommandBuffersSizes; // 0x10
	private IntPtr m_ClientData; // 0x18

	// Properties
	public uint BuffersCount { get; set; }
	public IntPtr DispatchCommandBuffers { get; set; }
	public Nullable<uint> DispatchCommandBuffersSizes { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }

	// Methods

	// RVA: 0x3F8350 Offset: 0x3F7550 VA: 0x1803F8350
	public uint get_BuffersCount() { }

	// RVA: 0x3F84A0 Offset: 0x3F76A0 VA: 0x1803F84A0
	public void set_BuffersCount(uint value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public IntPtr get_DispatchCommandBuffers() { }

	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_DispatchCommandBuffers(IntPtr value) { }

	// RVA: 0x494820 Offset: 0x493A20 VA: 0x180494820
	public Nullable<uint> get_DispatchCommandBuffersSizes() { }

	// RVA: 0x494900 Offset: 0x493B00 VA: 0x180494900
	public void set_DispatchCommandBuffersSizes(Nullable<uint> value) { }

	// RVA: 0x4947B0 Offset: 0x4939B0 VA: 0x1804947B0
	public object get_ClientData() { }

	// RVA: 0x4948A0 Offset: 0x493AA0 VA: 0x1804948A0
	public void set_ClientData(object value) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x4945D0 Offset: 0x4937D0 VA: 0x1804945D0 Slot: 6
	public void Set(ref PS5SubmitGraphicsCommandsCallbackInfo other) { }

	// RVA: 0x4946A0 Offset: 0x4938A0 VA: 0x1804946A0 Slot: 7
	public void Set(ref Nullable<PS5SubmitGraphicsCommandsCallbackInfo> other) { }

	// RVA: 0x494550 Offset: 0x493750 VA: 0x180494550 Slot: 8
	public void Dispose() { }

	// RVA: 0x4945B0 Offset: 0x4937B0 VA: 0x1804945B0 Slot: 5
	public void Get(out PS5SubmitGraphicsCommandsCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.UI
public struct AcknowledgeEventIdOptions // TypeDefIndex: 8752
{
	// Fields
	[CompilerGenerated]
	private ulong <UiEventId>k__BackingField; // 0x0
	[CompilerGenerated]
	private Result <Result>k__BackingField; // 0x8

	// Properties
	public ulong UiEventId { get; set; }
	public Result Result { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public ulong get_UiEventId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_UiEventId(ulong value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3F5510 Offset: 0x3F4710 VA: 0x1803F5510
	public Result get_Result() { }

	[CompilerGenerated]
	// RVA: 0x3F5520 Offset: 0x3F4720 VA: 0x1803F5520
	public void set_Result(Result value) { }
}

// Namespace: Epic.OnlineServices.UI
internal struct AcknowledgeEventIdOptionsInternal : ISettable<AcknowledgeEventIdOptions>, IDisposable // TypeDefIndex: 8753
{
	// Fields
	private int m_ApiVersion; // 0x0
	private ulong m_UiEventId; // 0x8
	private Result m_Result; // 0x10

	// Properties
	public ulong UiEventId { set; }
	public Result Result { set; }

	// Methods

	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_UiEventId(ulong value) { }

	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_Result(Result value) { }

	// RVA: 0x489CA0 Offset: 0x488EA0 VA: 0x180489CA0 Slot: 4
	public void Set(ref AcknowledgeEventIdOptions other) { }

	// RVA: 0x489CC0 Offset: 0x488EC0 VA: 0x180489CC0 Slot: 5
	public void Set(ref Nullable<AcknowledgeEventIdOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.UI
public struct AddNotifyDisplaySettingsUpdatedOptions // TypeDefIndex: 8754
{}

// Namespace: Epic.OnlineServices.UI
internal struct AddNotifyDisplaySettingsUpdatedOptionsInternal : ISettable<AddNotifyDisplaySettingsUpdatedOptions>, IDisposable // TypeDefIndex: 8755
{
	// Fields
	private int m_ApiVersion; // 0x0

	// Methods

	// RVA: 0x3F98A0 Offset: 0x3F8AA0 VA: 0x1803F98A0 Slot: 4
	public void Set(ref AddNotifyDisplaySettingsUpdatedOptions other) { }

	// RVA: 0x48A030 Offset: 0x489230 VA: 0x18048A030 Slot: 5
	public void Set(ref Nullable<AddNotifyDisplaySettingsUpdatedOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.UI
public struct AddNotifyMemoryMonitorOptions // TypeDefIndex: 8756
{}

// Namespace: Epic.OnlineServices.UI
internal struct AddNotifyMemoryMonitorOptionsInternal : ISettable<AddNotifyMemoryMonitorOptions>, IDisposable // TypeDefIndex: 8757
{
	// Fields
	private int m_ApiVersion; // 0x0

	// Methods

	// RVA: 0x3F98A0 Offset: 0x3F8AA0 VA: 0x1803F98A0 Slot: 4
	public void Set(ref AddNotifyMemoryMonitorOptions other) { }

	// RVA: 0x48A080 Offset: 0x489280 VA: 0x18048A080 Slot: 5
	public void Set(ref Nullable<AddNotifyMemoryMonitorOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.UI
public struct GetFriendsExclusiveInputOptions // TypeDefIndex: 8758
{
	// Fields
	[CompilerGenerated]
	private EpicAccountId <LocalUserId>k__BackingField; // 0x0

	// Properties
	public EpicAccountId LocalUserId { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public EpicAccountId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_LocalUserId(EpicAccountId value) { }
}

// Namespace: Epic.OnlineServices.UI
internal struct GetFriendsExclusiveInputOptionsInternal : ISettable<GetFriendsExclusiveInputOptions>, IDisposable // TypeDefIndex: 8759
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8

	// Properties
	public EpicAccountId LocalUserId { set; }

	// Methods

	// RVA: 0x48BFE0 Offset: 0x48B1E0 VA: 0x18048BFE0
	public void set_LocalUserId(EpicAccountId value) { }

	// RVA: 0x48BF80 Offset: 0x48B180 VA: 0x18048BF80 Slot: 4
	public void Set(ref GetFriendsExclusiveInputOptions other) { }

	// RVA: 0x48BEE0 Offset: 0x48B0E0 VA: 0x18048BEE0 Slot: 5
	public void Set(ref Nullable<GetFriendsExclusiveInputOptions> other) { }

	// RVA: 0x48BE90 Offset: 0x48B090 VA: 0x18048BE90 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.UI
public struct GetFriendsVisibleOptions // TypeDefIndex: 8760
{
	// Fields
	[CompilerGenerated]
	private EpicAccountId <LocalUserId>k__BackingField; // 0x0

	// Properties
	public EpicAccountId LocalUserId { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public EpicAccountId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_LocalUserId(EpicAccountId value) { }
}

// Namespace: Epic.OnlineServices.UI
internal struct GetFriendsVisibleOptionsInternal : ISettable<GetFriendsVisibleOptions>, IDisposable // TypeDefIndex: 8761
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8

	// Properties
	public EpicAccountId LocalUserId { set; }

	// Methods

	// RVA: 0x48C190 Offset: 0x48B390 VA: 0x18048C190
	public void set_LocalUserId(EpicAccountId value) { }

	// RVA: 0x48C130 Offset: 0x48B330 VA: 0x18048C130 Slot: 4
	public void Set(ref GetFriendsVisibleOptions other) { }

	// RVA: 0x48C090 Offset: 0x48B290 VA: 0x18048C090 Slot: 5
	public void Set(ref Nullable<GetFriendsVisibleOptions> other) { }

	// RVA: 0x48C040 Offset: 0x48B240 VA: 0x18048C040 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.UI
public struct GetToggleFriendsButtonOptions // TypeDefIndex: 8762
{}

// Namespace: Epic.OnlineServices.UI
internal struct GetToggleFriendsButtonOptionsInternal : ISettable<GetToggleFriendsButtonOptions>, IDisposable // TypeDefIndex: 8763
{
	// Fields
	private int m_ApiVersion; // 0x0

	// Methods

	// RVA: 0x3F98A0 Offset: 0x3F8AA0 VA: 0x1803F98A0 Slot: 4
	public void Set(ref GetToggleFriendsButtonOptions other) { }

	// RVA: 0x48C1F0 Offset: 0x48B3F0 VA: 0x18048C1F0 Slot: 5
	public void Set(ref Nullable<GetToggleFriendsButtonOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.UI
public struct GetToggleFriendsKeyOptions // TypeDefIndex: 8764
{}

// Namespace: Epic.OnlineServices.UI
internal struct GetToggleFriendsKeyOptionsInternal : ISettable<GetToggleFriendsKeyOptions>, IDisposable // TypeDefIndex: 8765
{
	// Fields
	private int m_ApiVersion; // 0x0

	// Methods

	// RVA: 0x3F98A0 Offset: 0x3F8AA0 VA: 0x1803F98A0 Slot: 4
	public void Set(ref GetToggleFriendsKeyOptions other) { }

	// RVA: 0x48C240 Offset: 0x48B440 VA: 0x18048C240 Slot: 5
	public void Set(ref Nullable<GetToggleFriendsKeyOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.UI
public struct HideFriendsCallbackInfo : ICallbackInfo // TypeDefIndex: 8766
{
	// Fields
	[CompilerGenerated]
	private Result <ResultCode>k__BackingField; // 0x0
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x8
	[CompilerGenerated]
	private EpicAccountId <LocalUserId>k__BackingField; // 0x10

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public EpicAccountId LocalUserId { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	[CompilerGenerated]
	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public object get_ClientData() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_ClientData(object value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public EpicAccountId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_LocalUserId(EpicAccountId value) { }

	// RVA: 0x48C690 Offset: 0x48B890 VA: 0x18048C690 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x48C6E0 Offset: 0x48B8E0 VA: 0x18048C6E0
	internal void Set(ref HideFriendsCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.UI
internal struct HideFriendsCallbackInfoInternal : ICallbackInfoInternal, IGettable<HideFriendsCallbackInfo>, ISettable<HideFriendsCallbackInfo>, IDisposable // TypeDefIndex: 8767
{
	// Fields
	private Result m_ResultCode; // 0x0
	private IntPtr m_ClientData; // 0x8
	private IntPtr m_LocalUserId; // 0x10

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public EpicAccountId LocalUserId { get; set; }

	// Methods

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	// RVA: 0x48C4E0 Offset: 0x48B6E0 VA: 0x18048C4E0
	public object get_ClientData() { }

	// RVA: 0x48C5D0 Offset: 0x48B7D0 VA: 0x18048C5D0
	public void set_ClientData(object value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x48C550 Offset: 0x48B750 VA: 0x18048C550
	public EpicAccountId get_LocalUserId() { }

	// RVA: 0x48C630 Offset: 0x48B830 VA: 0x18048C630
	public void set_LocalUserId(EpicAccountId value) { }

	// RVA: 0x48C310 Offset: 0x48B510 VA: 0x18048C310 Slot: 6
	public void Set(ref HideFriendsCallbackInfo other) { }

	// RVA: 0x48C3C0 Offset: 0x48B5C0 VA: 0x18048C3C0 Slot: 7
	public void Set(ref Nullable<HideFriendsCallbackInfo> other) { }

	// RVA: 0x48C290 Offset: 0x48B490 VA: 0x18048C290 Slot: 8
	public void Dispose() { }

	// RVA: 0x48C2F0 Offset: 0x48B4F0 VA: 0x18048C2F0 Slot: 5
	public void Get(out HideFriendsCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.UI
public struct HideFriendsOptions // TypeDefIndex: 8768
{
	// Fields
	[CompilerGenerated]
	private EpicAccountId <LocalUserId>k__BackingField; // 0x0

	// Properties
	public EpicAccountId LocalUserId { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public EpicAccountId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_LocalUserId(EpicAccountId value) { }
}

// Namespace: Epic.OnlineServices.UI
internal struct HideFriendsOptionsInternal : ISettable<HideFriendsOptions>, IDisposable // TypeDefIndex: 8769
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8

	// Properties
	public EpicAccountId LocalUserId { set; }

	// Methods

	// RVA: 0x48C8C0 Offset: 0x48BAC0 VA: 0x18048C8C0
	public void set_LocalUserId(EpicAccountId value) { }

	// RVA: 0x48C7C0 Offset: 0x48B9C0 VA: 0x18048C7C0 Slot: 4
	public void Set(ref HideFriendsOptions other) { }

	// RVA: 0x48C820 Offset: 0x48BA20 VA: 0x18048C820 Slot: 5
	public void Set(ref Nullable<HideFriendsOptions> other) { }

	// RVA: 0x48C770 Offset: 0x48B970 VA: 0x18048C770 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.UI
[Flags]
public enum InputStateButtonFlags // TypeDefIndex: 8770
{
	// Fields
	public int value__; // 0x0
	public const InputStateButtonFlags None = 0;
	public const InputStateButtonFlags DPadLeft = 1;
	public const InputStateButtonFlags DPadRight = 2;
	public const InputStateButtonFlags DPadDown = 4;
	public const InputStateButtonFlags DPadUp = 8;
	public const InputStateButtonFlags FaceButtonLeft = 16;
	public const InputStateButtonFlags FaceButtonRight = 32;
	public const InputStateButtonFlags FaceButtonBottom = 64;
	public const InputStateButtonFlags FaceButtonTop = 128;
	public const InputStateButtonFlags LeftShoulder = 256;
	public const InputStateButtonFlags RightShoulder = 512;
	public const InputStateButtonFlags LeftTrigger = 1024;
	public const InputStateButtonFlags RightTrigger = 2048;
	public const InputStateButtonFlags SpecialLeft = 4096;
	public const InputStateButtonFlags SpecialRight = 8192;
	public const InputStateButtonFlags LeftThumbstick = 16384;
	public const InputStateButtonFlags RightThumbstick = 32768;
}

// Namespace: Epic.OnlineServices.UI
public struct IsSocialOverlayPausedOptions // TypeDefIndex: 8771
{}

// Namespace: Epic.OnlineServices.UI
internal struct IsSocialOverlayPausedOptionsInternal : ISettable<IsSocialOverlayPausedOptions>, IDisposable // TypeDefIndex: 8772
{
	// Fields
	private int m_ApiVersion; // 0x0

	// Methods

	// RVA: 0x3F98A0 Offset: 0x3F8AA0 VA: 0x1803F98A0 Slot: 4
	public void Set(ref IsSocialOverlayPausedOptions other) { }

	// RVA: 0x48C9A0 Offset: 0x48BBA0 VA: 0x18048C9A0 Slot: 5
	public void Set(ref Nullable<IsSocialOverlayPausedOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.UI
[Flags]
public enum KeyCombination // TypeDefIndex: 8773
{
	// Fields
	public int value__; // 0x0
	public const KeyCombination ModifierShift = 16;
	public const KeyCombination KeyTypeMask = 65535;
	public const KeyCombination ModifierMask = -65536;
	public const KeyCombination Shift = 65536;
	public const KeyCombination Control = 131072;
	public const KeyCombination Alt = 262144;
	public const KeyCombination Meta = 524288;
	public const KeyCombination ValidModifierMask = 983040;
	public const KeyCombination None = 0;
	public const KeyCombination Space = 1;
	public const KeyCombination Backspace = 2;
	public const KeyCombination Tab = 3;
	public const KeyCombination Escape = 4;
	public const KeyCombination PageUp = 5;
	public const KeyCombination PageDown = 6;
	public const KeyCombination End = 7;
	public const KeyCombination Home = 8;
	public const KeyCombination Insert = 9;
	public const KeyCombination Delete = 10;
	public const KeyCombination Left = 11;
	public const KeyCombination Up = 12;
	public const KeyCombination Right = 13;
	public const KeyCombination Down = 14;
	public const KeyCombination Key0 = 15;
	public const KeyCombination Key1 = 16;
	public const KeyCombination Key2 = 17;
	public const KeyCombination Key3 = 18;
	public const KeyCombination Key4 = 19;
	public const KeyCombination Key5 = 20;
	public const KeyCombination Key6 = 21;
	public const KeyCombination Key7 = 22;
	public const KeyCombination Key8 = 23;
	public const KeyCombination Key9 = 24;
	public const KeyCombination KeyA = 25;
	public const KeyCombination KeyB = 26;
	public const KeyCombination KeyC = 27;
	public const KeyCombination KeyD = 28;
	public const KeyCombination KeyE = 29;
	public const KeyCombination KeyF = 30;
	public const KeyCombination KeyG = 31;
	public const KeyCombination KeyH = 32;
	public const KeyCombination KeyI = 33;
	public const KeyCombination KeyJ = 34;
	public const KeyCombination KeyK = 35;
	public const KeyCombination KeyL = 36;
	public const KeyCombination KeyM = 37;
	public const KeyCombination KeyN = 38;
	public const KeyCombination KeyO = 39;
	public const KeyCombination KeyP = 40;
	public const KeyCombination KeyQ = 41;
	public const KeyCombination KeyR = 42;
	public const KeyCombination KeyS = 43;
	public const KeyCombination KeyT = 44;
	public const KeyCombination KeyU = 45;
	public const KeyCombination KeyV = 46;
	public const KeyCombination KeyW = 47;
	public const KeyCombination KeyX = 48;
	public const KeyCombination KeyY = 49;
	public const KeyCombination KeyZ = 50;
	public const KeyCombination Numpad0 = 51;
	public const KeyCombination Numpad1 = 52;
	public const KeyCombination Numpad2 = 53;
	public const KeyCombination Numpad3 = 54;
	public const KeyCombination Numpad4 = 55;
	public const KeyCombination Numpad5 = 56;
	public const KeyCombination Numpad6 = 57;
	public const KeyCombination Numpad7 = 58;
	public const KeyCombination Numpad8 = 59;
	public const KeyCombination Numpad9 = 60;
	public const KeyCombination NumpadAsterisk = 61;
	public const KeyCombination NumpadPlus = 62;
	public const KeyCombination NumpadMinus = 63;
	public const KeyCombination NumpadPeriod = 64;
	public const KeyCombination NumpadDivide = 65;
	public const KeyCombination F1 = 66;
	public const KeyCombination F2 = 67;
	public const KeyCombination F3 = 68;
	public const KeyCombination F4 = 69;
	public const KeyCombination F5 = 70;
	public const KeyCombination F6 = 71;
	public const KeyCombination F7 = 72;
	public const KeyCombination F8 = 73;
	public const KeyCombination F9 = 74;
	public const KeyCombination F10 = 75;
	public const KeyCombination F11 = 76;
	public const KeyCombination F12 = 77;
	public const KeyCombination F13 = 78;
	public const KeyCombination F14 = 79;
	public const KeyCombination F15 = 80;
	public const KeyCombination F16 = 81;
	public const KeyCombination F17 = 82;
	public const KeyCombination F18 = 83;
	public const KeyCombination F19 = 84;
	public const KeyCombination F20 = 85;
	public const KeyCombination F21 = 86;
	public const KeyCombination F22 = 87;
	public const KeyCombination F23 = 88;
	public const KeyCombination F24 = 89;
	public const KeyCombination OemPlus = 90;
	public const KeyCombination OemComma = 91;
	public const KeyCombination OemMinus = 92;
	public const KeyCombination OemPeriod = 93;
	public const KeyCombination Oem1 = 94;
	public const KeyCombination Oem2 = 95;
	public const KeyCombination Oem3 = 96;
	public const KeyCombination Oem4 = 97;
	public const KeyCombination Oem5 = 98;
	public const KeyCombination Oem6 = 99;
	public const KeyCombination Oem7 = 100;
	public const KeyCombination Oem8 = 101;
	public const KeyCombination MaxKeyType = 102;
}

// Namespace: Epic.OnlineServices.UI
public struct MemoryMonitorCallbackInfo : ICallbackInfo // TypeDefIndex: 8774
{
	// Fields
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x0
	[CompilerGenerated]
	private IntPtr <SystemMemoryMonitorReport>k__BackingField; // 0x8

	// Properties
	public object ClientData { get; set; }
	public IntPtr SystemMemoryMonitorReport { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410 Slot: 4
	public object get_ClientData() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_ClientData(object value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public IntPtr get_SystemMemoryMonitorReport() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_SystemMemoryMonitorReport(IntPtr value) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x48ECB0 Offset: 0x48DEB0 VA: 0x18048ECB0
	internal void Set(ref MemoryMonitorCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.UI
internal struct MemoryMonitorCallbackInfoInternal : ICallbackInfoInternal, IGettable<MemoryMonitorCallbackInfo>, ISettable<MemoryMonitorCallbackInfo>, IDisposable // TypeDefIndex: 8775
{
	// Fields
	private IntPtr m_ClientData; // 0x0
	private IntPtr m_SystemMemoryMonitorReport; // 0x8

	// Properties
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public IntPtr SystemMemoryMonitorReport { get; set; }

	// Methods

	// RVA: 0x48EBE0 Offset: 0x48DDE0 VA: 0x18048EBE0
	public object get_ClientData() { }

	// RVA: 0x48EC50 Offset: 0x48DE50 VA: 0x18048EC50
	public void set_ClientData(object value) { }

	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public IntPtr get_SystemMemoryMonitorReport() { }

	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_SystemMemoryMonitorReport(IntPtr value) { }

	// RVA: 0x48EAB0 Offset: 0x48DCB0 VA: 0x18048EAB0 Slot: 6
	public void Set(ref MemoryMonitorCallbackInfo other) { }

	// RVA: 0x48EB20 Offset: 0x48DD20 VA: 0x18048EB20 Slot: 7
	public void Set(ref Nullable<MemoryMonitorCallbackInfo> other) { }

	// RVA: 0x48EA30 Offset: 0x48DC30 VA: 0x18048EA30 Slot: 8
	public void Dispose() { }

	// RVA: 0x48EA90 Offset: 0x48DC90 VA: 0x18048EA90 Slot: 5
	public void Get(out MemoryMonitorCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.UI
public enum NotificationLocation // TypeDefIndex: 8776
{
	// Fields
	public int value__; // 0x0
	public const NotificationLocation TopLeft = 0;
	public const NotificationLocation TopRight = 1;
	public const NotificationLocation BottomLeft = 2;
	public const NotificationLocation BottomRight = 3;
}

// Namespace: Epic.OnlineServices.UI
public sealed class OnDisplaySettingsUpdatedCallback : MulticastDelegate // TypeDefIndex: 8777
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref OnDisplaySettingsUpdatedCallbackInfo data) { }

	// RVA: 0x48F680 Offset: 0x48E880 VA: 0x18048F680 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref OnDisplaySettingsUpdatedCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref OnDisplaySettingsUpdatedCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.UI
[UnmanagedFunctionPointer(2)]
internal sealed class OnDisplaySettingsUpdatedCallbackInternal : MulticastDelegate // TypeDefIndex: 8778
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref OnDisplaySettingsUpdatedCallbackInfoInternal data) { }

	// RVA: 0x48F5F0 Offset: 0x48E7F0 VA: 0x18048F5F0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref OnDisplaySettingsUpdatedCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref OnDisplaySettingsUpdatedCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.UI
public struct OnDisplaySettingsUpdatedCallbackInfo : ICallbackInfo // TypeDefIndex: 8779
{
	// Fields
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x0
	[CompilerGenerated]
	private bool <IsVisible>k__BackingField; // 0x8
	[CompilerGenerated]
	private bool <IsExclusiveInput>k__BackingField; // 0x9

	// Properties
	public object ClientData { get; set; }
	public bool IsVisible { get; set; }
	public bool IsExclusiveInput { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410 Slot: 4
	public object get_ClientData() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_ClientData(object value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x48F5C0 Offset: 0x48E7C0 VA: 0x18048F5C0
	public bool get_IsVisible() { }

	[CompilerGenerated]
	// RVA: 0x48F5E0 Offset: 0x48E7E0 VA: 0x18048F5E0
	public void set_IsVisible(bool value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x48F5B0 Offset: 0x48E7B0 VA: 0x18048F5B0
	public bool get_IsExclusiveInput() { }

	[CompilerGenerated]
	// RVA: 0x48F5D0 Offset: 0x48E7D0 VA: 0x18048F5D0
	public void set_IsExclusiveInput(bool value) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x48F490 Offset: 0x48E690 VA: 0x18048F490
	internal void Set(ref OnDisplaySettingsUpdatedCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.UI
internal struct OnDisplaySettingsUpdatedCallbackInfoInternal : ICallbackInfoInternal, IGettable<OnDisplaySettingsUpdatedCallbackInfo>, ISettable<OnDisplaySettingsUpdatedCallbackInfo>, IDisposable // TypeDefIndex: 8780
{
	// Fields
	private IntPtr m_ClientData; // 0x0
	private int m_IsVisible; // 0x8
	private int m_IsExclusiveInput; // 0xC

	// Properties
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public bool IsVisible { get; set; }
	public bool IsExclusiveInput { get; set; }

	// Methods

	// RVA: 0x48F240 Offset: 0x48E440 VA: 0x18048F240
	public object get_ClientData() { }

	// RVA: 0x48F370 Offset: 0x48E570 VA: 0x18048F370
	public void set_ClientData(object value) { }

	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x48F310 Offset: 0x48E510 VA: 0x18048F310
	public bool get_IsVisible() { }

	// RVA: 0x48F430 Offset: 0x48E630 VA: 0x18048F430
	public void set_IsVisible(bool value) { }

	// RVA: 0x48F2B0 Offset: 0x48E4B0 VA: 0x18048F2B0
	public bool get_IsExclusiveInput() { }

	// RVA: 0x48F3D0 Offset: 0x48E5D0 VA: 0x18048F3D0
	public void set_IsExclusiveInput(bool value) { }

	// RVA: 0x48F150 Offset: 0x48E350 VA: 0x18048F150 Slot: 6
	public void Set(ref OnDisplaySettingsUpdatedCallbackInfo other) { }

	// RVA: 0x48EFF0 Offset: 0x48E1F0 VA: 0x18048EFF0 Slot: 7
	public void Set(ref Nullable<OnDisplaySettingsUpdatedCallbackInfo> other) { }

	// RVA: 0x48EF80 Offset: 0x48E180 VA: 0x18048EF80 Slot: 8
	public void Dispose() { }

	// RVA: 0x48EFD0 Offset: 0x48E1D0 VA: 0x18048EFD0 Slot: 5
	public void Get(out OnDisplaySettingsUpdatedCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.UI
public sealed class OnHideFriendsCallback : MulticastDelegate // TypeDefIndex: 8781
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref HideFriendsCallbackInfo data) { }

	// RVA: 0x48F7A0 Offset: 0x48E9A0 VA: 0x18048F7A0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref HideFriendsCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref HideFriendsCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.UI
[UnmanagedFunctionPointer(2)]
internal sealed class OnHideFriendsCallbackInternal : MulticastDelegate // TypeDefIndex: 8782
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref HideFriendsCallbackInfoInternal data) { }

	// RVA: 0x48F710 Offset: 0x48E910 VA: 0x18048F710 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref HideFriendsCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref HideFriendsCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.UI
public sealed class OnMemoryMonitorCallback : MulticastDelegate // TypeDefIndex: 8783
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref MemoryMonitorCallbackInfo data) { }

	// RVA: 0x48FC20 Offset: 0x48EE20 VA: 0x18048FC20 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref MemoryMonitorCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref MemoryMonitorCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.UI
[UnmanagedFunctionPointer(2)]
internal sealed class OnMemoryMonitorCallbackInternal : MulticastDelegate // TypeDefIndex: 8784
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref MemoryMonitorCallbackInfoInternal data) { }

	// RVA: 0x48FB90 Offset: 0x48ED90 VA: 0x18048FB90 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref MemoryMonitorCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref MemoryMonitorCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.UI
public sealed class OnShowBlockPlayerCallback : MulticastDelegate // TypeDefIndex: 8785
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref OnShowBlockPlayerCallbackInfo data) { }

	// RVA: 0x490950 Offset: 0x48FB50 VA: 0x180490950 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref OnShowBlockPlayerCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref OnShowBlockPlayerCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.UI
[UnmanagedFunctionPointer(2)]
internal sealed class OnShowBlockPlayerCallbackInternal : MulticastDelegate // TypeDefIndex: 8786
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref OnShowBlockPlayerCallbackInfoInternal data) { }

	// RVA: 0x4908C0 Offset: 0x48FAC0 VA: 0x1804908C0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref OnShowBlockPlayerCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref OnShowBlockPlayerCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.UI
public struct OnShowBlockPlayerCallbackInfo : ICallbackInfo // TypeDefIndex: 8787
{
	// Fields
	[CompilerGenerated]
	private Result <ResultCode>k__BackingField; // 0x0
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x8
	[CompilerGenerated]
	private EpicAccountId <LocalUserId>k__BackingField; // 0x10
	[CompilerGenerated]
	private EpicAccountId <TargetUserId>k__BackingField; // 0x18

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public EpicAccountId LocalUserId { get; set; }
	public EpicAccountId TargetUserId { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	[CompilerGenerated]
	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public object get_ClientData() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_ClientData(object value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public EpicAccountId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_LocalUserId(EpicAccountId value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public EpicAccountId get_TargetUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_TargetUserId(EpicAccountId value) { }

	// RVA: 0x4907D0 Offset: 0x48F9D0 VA: 0x1804907D0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x490820 Offset: 0x48FA20 VA: 0x180490820
	internal void Set(ref OnShowBlockPlayerCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.UI
internal struct OnShowBlockPlayerCallbackInfoInternal : ICallbackInfoInternal, IGettable<OnShowBlockPlayerCallbackInfo>, ISettable<OnShowBlockPlayerCallbackInfo>, IDisposable // TypeDefIndex: 8788
{
	// Fields
	private Result m_ResultCode; // 0x0
	private IntPtr m_ClientData; // 0x8
	private IntPtr m_LocalUserId; // 0x10
	private IntPtr m_TargetUserId; // 0x18

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public EpicAccountId LocalUserId { get; set; }
	public EpicAccountId TargetUserId { get; set; }

	// Methods

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	// RVA: 0x490540 Offset: 0x48F740 VA: 0x180490540
	public object get_ClientData() { }

	// RVA: 0x4906B0 Offset: 0x48F8B0 VA: 0x1804906B0
	public void set_ClientData(object value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x4905B0 Offset: 0x48F7B0 VA: 0x1804905B0
	public EpicAccountId get_LocalUserId() { }

	// RVA: 0x490710 Offset: 0x48F910 VA: 0x180490710
	public void set_LocalUserId(EpicAccountId value) { }

	// RVA: 0x490630 Offset: 0x48F830 VA: 0x180490630
	public EpicAccountId get_TargetUserId() { }

	// RVA: 0x490770 Offset: 0x48F970 VA: 0x180490770
	public void set_TargetUserId(EpicAccountId value) { }

	// RVA: 0x4902D0 Offset: 0x48F4D0 VA: 0x1804902D0 Slot: 6
	public void Set(ref OnShowBlockPlayerCallbackInfo other) { }

	// RVA: 0x4903D0 Offset: 0x48F5D0 VA: 0x1804903D0 Slot: 7
	public void Set(ref Nullable<OnShowBlockPlayerCallbackInfo> other) { }

	// RVA: 0x490250 Offset: 0x48F450 VA: 0x180490250 Slot: 8
	public void Dispose() { }

	// RVA: 0x4902B0 Offset: 0x48F4B0 VA: 0x1804902B0 Slot: 5
	public void Get(out OnShowBlockPlayerCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.UI
public sealed class OnShowFriendsCallback : MulticastDelegate // TypeDefIndex: 8789
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref ShowFriendsCallbackInfo data) { }

	// RVA: 0x490A70 Offset: 0x48FC70 VA: 0x180490A70 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref ShowFriendsCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref ShowFriendsCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.UI
[UnmanagedFunctionPointer(2)]
internal sealed class OnShowFriendsCallbackInternal : MulticastDelegate // TypeDefIndex: 8790
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref ShowFriendsCallbackInfoInternal data) { }

	// RVA: 0x4909E0 Offset: 0x48FBE0 VA: 0x1804909E0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref ShowFriendsCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref ShowFriendsCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.UI
public sealed class OnShowNativeProfileCallback : MulticastDelegate // TypeDefIndex: 8791
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref ShowNativeProfileCallbackInfo data) { }

	// RVA: 0x490B90 Offset: 0x48FD90 VA: 0x180490B90 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref ShowNativeProfileCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref ShowNativeProfileCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.UI
[UnmanagedFunctionPointer(2)]
internal sealed class OnShowNativeProfileCallbackInternal : MulticastDelegate // TypeDefIndex: 8792
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref ShowNativeProfileCallbackInfoInternal data) { }

	// RVA: 0x490B00 Offset: 0x48FD00 VA: 0x180490B00 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref ShowNativeProfileCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref ShowNativeProfileCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.UI
public sealed class OnShowReportPlayerCallback : MulticastDelegate // TypeDefIndex: 8793
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref OnShowReportPlayerCallbackInfo data) { }

	// RVA: 0x491320 Offset: 0x490520 VA: 0x180491320 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref OnShowReportPlayerCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref OnShowReportPlayerCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.UI
[UnmanagedFunctionPointer(2)]
internal sealed class OnShowReportPlayerCallbackInternal : MulticastDelegate // TypeDefIndex: 8794
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref OnShowReportPlayerCallbackInfoInternal data) { }

	// RVA: 0x491290 Offset: 0x490490 VA: 0x180491290 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref OnShowReportPlayerCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref OnShowReportPlayerCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.UI
public struct OnShowReportPlayerCallbackInfo : ICallbackInfo // TypeDefIndex: 8795
{
	// Fields
	[CompilerGenerated]
	private Result <ResultCode>k__BackingField; // 0x0
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x8
	[CompilerGenerated]
	private EpicAccountId <LocalUserId>k__BackingField; // 0x10
	[CompilerGenerated]
	private EpicAccountId <TargetUserId>k__BackingField; // 0x18

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public EpicAccountId LocalUserId { get; set; }
	public EpicAccountId TargetUserId { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	[CompilerGenerated]
	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public object get_ClientData() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_ClientData(object value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public EpicAccountId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_LocalUserId(EpicAccountId value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public EpicAccountId get_TargetUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_TargetUserId(EpicAccountId value) { }

	// RVA: 0x4911A0 Offset: 0x4903A0 VA: 0x1804911A0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x4911F0 Offset: 0x4903F0 VA: 0x1804911F0
	internal void Set(ref OnShowReportPlayerCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.UI
internal struct OnShowReportPlayerCallbackInfoInternal : ICallbackInfoInternal, IGettable<OnShowReportPlayerCallbackInfo>, ISettable<OnShowReportPlayerCallbackInfo>, IDisposable // TypeDefIndex: 8796
{
	// Fields
	private Result m_ResultCode; // 0x0
	private IntPtr m_ClientData; // 0x8
	private IntPtr m_LocalUserId; // 0x10
	private IntPtr m_TargetUserId; // 0x18

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public EpicAccountId LocalUserId { get; set; }
	public EpicAccountId TargetUserId { get; set; }

	// Methods

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	// RVA: 0x490F10 Offset: 0x490110 VA: 0x180490F10
	public object get_ClientData() { }

	// RVA: 0x491080 Offset: 0x490280 VA: 0x180491080
	public void set_ClientData(object value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x490F80 Offset: 0x490180 VA: 0x180490F80
	public EpicAccountId get_LocalUserId() { }

	// RVA: 0x4910E0 Offset: 0x4902E0 VA: 0x1804910E0
	public void set_LocalUserId(EpicAccountId value) { }

	// RVA: 0x491000 Offset: 0x490200 VA: 0x180491000
	public EpicAccountId get_TargetUserId() { }

	// RVA: 0x491140 Offset: 0x490340 VA: 0x180491140
	public void set_TargetUserId(EpicAccountId value) { }

	// RVA: 0x490CA0 Offset: 0x48FEA0 VA: 0x180490CA0 Slot: 6
	public void Set(ref OnShowReportPlayerCallbackInfo other) { }

	// RVA: 0x490DA0 Offset: 0x48FFA0 VA: 0x180490DA0 Slot: 7
	public void Set(ref Nullable<OnShowReportPlayerCallbackInfo> other) { }

	// RVA: 0x490C20 Offset: 0x48FE20 VA: 0x180490C20 Slot: 8
	public void Dispose() { }

	// RVA: 0x490C80 Offset: 0x48FE80 VA: 0x180490C80 Slot: 5
	public void Get(out OnShowReportPlayerCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.UI
public struct PauseSocialOverlayOptions // TypeDefIndex: 8797
{
	// Fields
	[CompilerGenerated]
	private bool <IsPaused>k__BackingField; // 0x0

	// Properties
	public bool IsPaused { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x41D600 Offset: 0x41C800 VA: 0x18041D600
	public bool get_IsPaused() { }

	[CompilerGenerated]
	// RVA: 0x41D610 Offset: 0x41C810 VA: 0x18041D610
	public void set_IsPaused(bool value) { }
}

// Namespace: Epic.OnlineServices.UI
internal struct PauseSocialOverlayOptionsInternal : ISettable<PauseSocialOverlayOptions>, IDisposable // TypeDefIndex: 8798
{
	// Fields
	private int m_ApiVersion; // 0x0
	private int m_IsPaused; // 0x4

	// Properties
	public bool IsPaused { set; }

	// Methods

	// RVA: 0x4961E0 Offset: 0x4953E0 VA: 0x1804961E0
	public void set_IsPaused(bool value) { }

	// RVA: 0x4960D0 Offset: 0x4952D0 VA: 0x1804960D0 Slot: 4
	public void Set(ref PauseSocialOverlayOptions other) { }

	// RVA: 0x496140 Offset: 0x495340 VA: 0x180496140 Slot: 5
	public void Set(ref Nullable<PauseSocialOverlayOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.UI
public struct PrePresentOptions // TypeDefIndex: 8799
{
	// Fields
	[CompilerGenerated]
	private IntPtr <PlatformSpecificData>k__BackingField; // 0x0

	// Properties
	public IntPtr PlatformSpecificData { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public IntPtr get_PlatformSpecificData() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_PlatformSpecificData(IntPtr value) { }
}

// Namespace: Epic.OnlineServices.UI
internal struct PrePresentOptionsInternal : ISettable<PrePresentOptions>, IDisposable // TypeDefIndex: 8800
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_PlatformSpecificData; // 0x8

	// Properties
	public IntPtr PlatformSpecificData { set; }

	// Methods

	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_PlatformSpecificData(IntPtr value) { }

	// RVA: 0x40DD30 Offset: 0x40CF30 VA: 0x18040DD30 Slot: 4
	public void Set(ref PrePresentOptions other) { }

	// RVA: 0x496290 Offset: 0x495490 VA: 0x180496290 Slot: 5
	public void Set(ref Nullable<PrePresentOptions> other) { }

	// RVA: 0x496240 Offset: 0x495440 VA: 0x180496240 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.UI
public struct Rect // TypeDefIndex: 8801
{
	// Fields
	[CompilerGenerated]
	private int <X>k__BackingField; // 0x0
	[CompilerGenerated]
	private int <Y>k__BackingField; // 0x4
	[CompilerGenerated]
	private uint <Width>k__BackingField; // 0x8
	[CompilerGenerated]
	private uint <Height>k__BackingField; // 0xC

	// Properties
	public int X { get; set; }
	public int Y { get; set; }
	public uint Width { get; set; }
	public uint Height { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public int get_X() { }

	[CompilerGenerated]
	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_X(int value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3F8350 Offset: 0x3F7550 VA: 0x1803F8350
	public int get_Y() { }

	[CompilerGenerated]
	// RVA: 0x3F84A0 Offset: 0x3F76A0 VA: 0x1803F84A0
	public void set_Y(int value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3F5510 Offset: 0x3F4710 VA: 0x1803F5510
	public uint get_Width() { }

	[CompilerGenerated]
	// RVA: 0x3F5520 Offset: 0x3F4720 VA: 0x1803F5520
	public void set_Width(uint value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x438080 Offset: 0x437280 VA: 0x180438080
	public uint get_Height() { }

	[CompilerGenerated]
	// RVA: 0x438090 Offset: 0x437290 VA: 0x180438090
	public void set_Height(uint value) { }

	// RVA: 0x498BD0 Offset: 0x497DD0 VA: 0x180498BD0
	internal void Set(ref RectInternal other) { }
}

// Namespace: Epic.OnlineServices.UI
internal struct RectInternal : IGettable<Rect>, ISettable<Rect>, IDisposable // TypeDefIndex: 8802
{
	// Fields
	private int m_ApiVersion; // 0x0
	private int m_X; // 0x4
	private int m_Y; // 0x8
	private uint m_Width; // 0xC
	private uint m_Height; // 0x10

	// Properties
	public int X { get; set; }
	public int Y { get; set; }
	public uint Width { get; set; }
	public uint Height { get; set; }

	// Methods

	// RVA: 0x3F8350 Offset: 0x3F7550 VA: 0x1803F8350
	public int get_X() { }

	// RVA: 0x3F84A0 Offset: 0x3F76A0 VA: 0x1803F84A0
	public void set_X(int value) { }

	// RVA: 0x3F5510 Offset: 0x3F4710 VA: 0x1803F5510
	public int get_Y() { }

	// RVA: 0x3F5520 Offset: 0x3F4720 VA: 0x1803F5520
	public void set_Y(int value) { }

	// RVA: 0x438080 Offset: 0x437280 VA: 0x180438080
	public uint get_Width() { }

	// RVA: 0x438090 Offset: 0x437290 VA: 0x180438090
	public void set_Width(uint value) { }

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public uint get_Height() { }

	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_Height(uint value) { }

	// RVA: 0x498BB0 Offset: 0x497DB0 VA: 0x180498BB0 Slot: 5
	public void Set(ref Rect other) { }

	// RVA: 0x498AE0 Offset: 0x497CE0 VA: 0x180498AE0 Slot: 6
	public void Set(ref Nullable<Rect> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 7
	public void Dispose() { }

	// RVA: 0x498AC0 Offset: 0x497CC0 VA: 0x180498AC0 Slot: 4
	public void Get(out Rect output) { }
}

// Namespace: Epic.OnlineServices.UI
public struct ReportInputStateOptions // TypeDefIndex: 8803
{
	// Fields
	[CompilerGenerated]
	private InputStateButtonFlags <ButtonDownFlags>k__BackingField; // 0x0
	[CompilerGenerated]
	private bool <AcceptIsFaceButtonRight>k__BackingField; // 0x4
	[CompilerGenerated]
	private bool <MouseButtonDown>k__BackingField; // 0x5
	[CompilerGenerated]
	private uint <MousePosX>k__BackingField; // 0x8
	[CompilerGenerated]
	private uint <MousePosY>k__BackingField; // 0xC
	[CompilerGenerated]
	private uint <GamepadIndex>k__BackingField; // 0x10
	[CompilerGenerated]
	private float <LeftStickX>k__BackingField; // 0x14
	[CompilerGenerated]
	private float <LeftStickY>k__BackingField; // 0x18
	[CompilerGenerated]
	private float <RightStickX>k__BackingField; // 0x1C
	[CompilerGenerated]
	private float <RightStickY>k__BackingField; // 0x20
	[CompilerGenerated]
	private float <LeftTrigger>k__BackingField; // 0x24
	[CompilerGenerated]
	private float <RightTrigger>k__BackingField; // 0x28

	// Properties
	public InputStateButtonFlags ButtonDownFlags { get; set; }
	public bool AcceptIsFaceButtonRight { get; set; }
	public bool MouseButtonDown { get; set; }
	public uint MousePosX { get; set; }
	public uint MousePosY { get; set; }
	public uint GamepadIndex { get; set; }
	public float LeftStickX { get; set; }
	public float LeftStickY { get; set; }
	public float RightStickX { get; set; }
	public float RightStickY { get; set; }
	public float LeftTrigger { get; set; }
	public float RightTrigger { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public InputStateButtonFlags get_ButtonDownFlags() { }

	[CompilerGenerated]
	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ButtonDownFlags(InputStateButtonFlags value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x499020 Offset: 0x498220 VA: 0x180499020
	public bool get_AcceptIsFaceButtonRight() { }

	[CompilerGenerated]
	// RVA: 0x499070 Offset: 0x498270 VA: 0x180499070
	public void set_AcceptIsFaceButtonRight(bool value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x499050 Offset: 0x498250 VA: 0x180499050
	public bool get_MouseButtonDown() { }

	[CompilerGenerated]
	// RVA: 0x499090 Offset: 0x498290 VA: 0x180499090
	public void set_MouseButtonDown(bool value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3F5510 Offset: 0x3F4710 VA: 0x1803F5510
	public uint get_MousePosX() { }

	[CompilerGenerated]
	// RVA: 0x3F5520 Offset: 0x3F4720 VA: 0x1803F5520
	public void set_MousePosX(uint value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x438080 Offset: 0x437280 VA: 0x180438080
	public uint get_MousePosY() { }

	[CompilerGenerated]
	// RVA: 0x438090 Offset: 0x437290 VA: 0x180438090
	public void set_MousePosY(uint value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public uint get_GamepadIndex() { }

	[CompilerGenerated]
	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_GamepadIndex(uint value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x499030 Offset: 0x498230 VA: 0x180499030
	public float get_LeftStickX() { }

	[CompilerGenerated]
	// RVA: 0x499080 Offset: 0x498280 VA: 0x180499080
	public void set_LeftStickX(float value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x485420 Offset: 0x484620 VA: 0x180485420
	public float get_LeftStickY() { }

	[CompilerGenerated]
	// RVA: 0x482DB0 Offset: 0x481FB0 VA: 0x180482DB0
	public void set_LeftStickY(float value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x499060 Offset: 0x498260 VA: 0x180499060
	public float get_RightStickX() { }

	[CompilerGenerated]
	// RVA: 0x498F80 Offset: 0x498180 VA: 0x180498F80
	public void set_RightStickX(float value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x487630 Offset: 0x486830 VA: 0x180487630
	public float get_RightStickY() { }

	[CompilerGenerated]
	// RVA: 0x485410 Offset: 0x484610 VA: 0x180485410
	public void set_RightStickY(float value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x499040 Offset: 0x498240 VA: 0x180499040
	public float get_LeftTrigger() { }

	[CompilerGenerated]
	// RVA: 0x499000 Offset: 0x498200 VA: 0x180499000
	public void set_LeftTrigger(float value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x484D20 Offset: 0x483F20 VA: 0x180484D20
	public float get_RightTrigger() { }

	[CompilerGenerated]
	// RVA: 0x484EB0 Offset: 0x4840B0 VA: 0x180484EB0
	public void set_RightTrigger(float value) { }
}

// Namespace: Epic.OnlineServices.UI
internal struct ReportInputStateOptionsInternal : ISettable<ReportInputStateOptions>, IDisposable // TypeDefIndex: 8804
{
	// Fields
	private int m_ApiVersion; // 0x0
	private InputStateButtonFlags m_ButtonDownFlags; // 0x4
	private int m_AcceptIsFaceButtonRight; // 0x8
	private int m_MouseButtonDown; // 0xC
	private uint m_MousePosX; // 0x10
	private uint m_MousePosY; // 0x14
	private uint m_GamepadIndex; // 0x18
	private float m_LeftStickX; // 0x1C
	private float m_LeftStickY; // 0x20
	private float m_RightStickX; // 0x24
	private float m_RightStickY; // 0x28
	private float m_LeftTrigger; // 0x2C
	private float m_RightTrigger; // 0x30

	// Properties
	public InputStateButtonFlags ButtonDownFlags { set; }
	public bool AcceptIsFaceButtonRight { set; }
	public bool MouseButtonDown { set; }
	public uint MousePosX { set; }
	public uint MousePosY { set; }
	public uint GamepadIndex { set; }
	public float LeftStickX { set; }
	public float LeftStickY { set; }
	public float RightStickX { set; }
	public float RightStickY { set; }
	public float LeftTrigger { set; }
	public float RightTrigger { set; }

	// Methods

	// RVA: 0x3F84A0 Offset: 0x3F76A0 VA: 0x1803F84A0
	public void set_ButtonDownFlags(InputStateButtonFlags value) { }

	// RVA: 0x498F20 Offset: 0x498120 VA: 0x180498F20
	public void set_AcceptIsFaceButtonRight(bool value) { }

	// RVA: 0x498FA0 Offset: 0x4981A0 VA: 0x180498FA0
	public void set_MouseButtonDown(bool value) { }

	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_MousePosX(uint value) { }

	// RVA: 0x426530 Offset: 0x425730 VA: 0x180426530
	public void set_MousePosY(uint value) { }

	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	public void set_GamepadIndex(uint value) { }

	// RVA: 0x498F80 Offset: 0x498180 VA: 0x180498F80
	public void set_LeftStickX(float value) { }

	// RVA: 0x485410 Offset: 0x484610 VA: 0x180485410
	public void set_LeftStickY(float value) { }

	// RVA: 0x499000 Offset: 0x498200 VA: 0x180499000
	public void set_RightStickX(float value) { }

	// RVA: 0x484EB0 Offset: 0x4840B0 VA: 0x180484EB0
	public void set_RightStickY(float value) { }

	// RVA: 0x498F90 Offset: 0x498190 VA: 0x180498F90
	public void set_LeftTrigger(float value) { }

	// RVA: 0x499010 Offset: 0x498210 VA: 0x180499010
	public void set_RightTrigger(float value) { }

	// RVA: 0x498BF0 Offset: 0x497DF0 VA: 0x180498BF0 Slot: 4
	public void Set(ref ReportInputStateOptions other) { }

	// RVA: 0x498CE0 Offset: 0x497EE0 VA: 0x180498CE0 Slot: 5
	public void Set(ref Nullable<ReportInputStateOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.UI
public struct SetDisplayPreferenceOptions // TypeDefIndex: 8805
{
	// Fields
	[CompilerGenerated]
	private NotificationLocation <NotificationLocation>k__BackingField; // 0x0

	// Properties
	public NotificationLocation NotificationLocation { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public NotificationLocation get_NotificationLocation() { }

	[CompilerGenerated]
	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_NotificationLocation(NotificationLocation value) { }
}

// Namespace: Epic.OnlineServices.UI
internal struct SetDisplayPreferenceOptionsInternal : ISettable<SetDisplayPreferenceOptions>, IDisposable // TypeDefIndex: 8806
{
	// Fields
	private int m_ApiVersion; // 0x0
	private NotificationLocation m_NotificationLocation; // 0x4

	// Properties
	public NotificationLocation NotificationLocation { set; }

	// Methods

	// RVA: 0x3F84A0 Offset: 0x3F76A0 VA: 0x1803F84A0
	public void set_NotificationLocation(NotificationLocation value) { }

	// RVA: 0x40B2E0 Offset: 0x40A4E0 VA: 0x18040B2E0 Slot: 4
	public void Set(ref SetDisplayPreferenceOptions other) { }

	// RVA: 0x49A340 Offset: 0x499540 VA: 0x18049A340 Slot: 5
	public void Set(ref Nullable<SetDisplayPreferenceOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.UI
public struct SetToggleFriendsButtonOptions // TypeDefIndex: 8807
{
	// Fields
	[CompilerGenerated]
	private InputStateButtonFlags <ButtonCombination>k__BackingField; // 0x0

	// Properties
	public InputStateButtonFlags ButtonCombination { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public InputStateButtonFlags get_ButtonCombination() { }

	[CompilerGenerated]
	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ButtonCombination(InputStateButtonFlags value) { }
}

// Namespace: Epic.OnlineServices.UI
internal struct SetToggleFriendsButtonOptionsInternal : ISettable<SetToggleFriendsButtonOptions>, IDisposable // TypeDefIndex: 8808
{
	// Fields
	private int m_ApiVersion; // 0x0
	private InputStateButtonFlags m_ButtonCombination; // 0x4

	// Properties
	public InputStateButtonFlags ButtonCombination { set; }

	// Methods

	// RVA: 0x3F84A0 Offset: 0x3F76A0 VA: 0x1803F84A0
	public void set_ButtonCombination(InputStateButtonFlags value) { }

	// RVA: 0x40B2E0 Offset: 0x40A4E0 VA: 0x18040B2E0 Slot: 4
	public void Set(ref SetToggleFriendsButtonOptions other) { }

	// RVA: 0x49B270 Offset: 0x49A470 VA: 0x18049B270 Slot: 5
	public void Set(ref Nullable<SetToggleFriendsButtonOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.UI
public struct SetToggleFriendsKeyOptions // TypeDefIndex: 8809
{
	// Fields
	[CompilerGenerated]
	private KeyCombination <KeyCombination>k__BackingField; // 0x0

	// Properties
	public KeyCombination KeyCombination { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public KeyCombination get_KeyCombination() { }

	[CompilerGenerated]
	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_KeyCombination(KeyCombination value) { }
}

// Namespace: Epic.OnlineServices.UI
internal struct SetToggleFriendsKeyOptionsInternal : ISettable<SetToggleFriendsKeyOptions>, IDisposable // TypeDefIndex: 8810
{
	// Fields
	private int m_ApiVersion; // 0x0
	private KeyCombination m_KeyCombination; // 0x4

	// Properties
	public KeyCombination KeyCombination { set; }

	// Methods

	// RVA: 0x3F84A0 Offset: 0x3F76A0 VA: 0x1803F84A0
	public void set_KeyCombination(KeyCombination value) { }

	// RVA: 0x40B2E0 Offset: 0x40A4E0 VA: 0x18040B2E0 Slot: 4
	public void Set(ref SetToggleFriendsKeyOptions other) { }

	// RVA: 0x49B2D0 Offset: 0x49A4D0 VA: 0x18049B2D0 Slot: 5
	public void Set(ref Nullable<SetToggleFriendsKeyOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.UI
public struct ShowBlockPlayerOptions // TypeDefIndex: 8811
{
	// Fields
	[CompilerGenerated]
	private EpicAccountId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private EpicAccountId <TargetUserId>k__BackingField; // 0x8

	// Properties
	public EpicAccountId LocalUserId { get; set; }
	public EpicAccountId TargetUserId { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public EpicAccountId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_LocalUserId(EpicAccountId value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public EpicAccountId get_TargetUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_TargetUserId(EpicAccountId value) { }
}

// Namespace: Epic.OnlineServices.UI
internal struct ShowBlockPlayerOptionsInternal : ISettable<ShowBlockPlayerOptions>, IDisposable // TypeDefIndex: 8812
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_TargetUserId; // 0x10

	// Properties
	public EpicAccountId LocalUserId { set; }
	public EpicAccountId TargetUserId { set; }

	// Methods

	// RVA: 0x49B550 Offset: 0x49A750 VA: 0x18049B550
	public void set_LocalUserId(EpicAccountId value) { }

	// RVA: 0x49B5B0 Offset: 0x49A7B0 VA: 0x18049B5B0
	public void set_TargetUserId(EpicAccountId value) { }

	// RVA: 0x49B490 Offset: 0x49A690 VA: 0x18049B490 Slot: 4
	public void Set(ref ShowBlockPlayerOptions other) { }

	// RVA: 0x49B390 Offset: 0x49A590 VA: 0x18049B390 Slot: 5
	public void Set(ref Nullable<ShowBlockPlayerOptions> other) { }

	// RVA: 0x49B330 Offset: 0x49A530 VA: 0x18049B330 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.UI
public struct ShowFriendsCallbackInfo : ICallbackInfo // TypeDefIndex: 8813
{
	// Fields
	[CompilerGenerated]
	private Result <ResultCode>k__BackingField; // 0x0
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x8
	[CompilerGenerated]
	private EpicAccountId <LocalUserId>k__BackingField; // 0x10

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public EpicAccountId LocalUserId { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	[CompilerGenerated]
	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public object get_ClientData() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_ClientData(object value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public EpicAccountId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_LocalUserId(EpicAccountId value) { }

	// RVA: 0x49BA10 Offset: 0x49AC10 VA: 0x18049BA10 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x49BA60 Offset: 0x49AC60 VA: 0x18049BA60
	internal void Set(ref ShowFriendsCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.UI
internal struct ShowFriendsCallbackInfoInternal : ICallbackInfoInternal, IGettable<ShowFriendsCallbackInfo>, ISettable<ShowFriendsCallbackInfo>, IDisposable // TypeDefIndex: 8814
{
	// Fields
	private Result m_ResultCode; // 0x0
	private IntPtr m_ClientData; // 0x8
	private IntPtr m_LocalUserId; // 0x10

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public EpicAccountId LocalUserId { get; set; }

	// Methods

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	// RVA: 0x49B860 Offset: 0x49AA60 VA: 0x18049B860
	public object get_ClientData() { }

	// RVA: 0x49B950 Offset: 0x49AB50 VA: 0x18049B950
	public void set_ClientData(object value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x49B8D0 Offset: 0x49AAD0 VA: 0x18049B8D0
	public EpicAccountId get_LocalUserId() { }

	// RVA: 0x49B9B0 Offset: 0x49ABB0 VA: 0x18049B9B0
	public void set_LocalUserId(EpicAccountId value) { }

	// RVA: 0x49B7B0 Offset: 0x49A9B0 VA: 0x18049B7B0 Slot: 6
	public void Set(ref ShowFriendsCallbackInfo other) { }

	// RVA: 0x49B690 Offset: 0x49A890 VA: 0x18049B690 Slot: 7
	public void Set(ref Nullable<ShowFriendsCallbackInfo> other) { }

	// RVA: 0x49B610 Offset: 0x49A810 VA: 0x18049B610 Slot: 8
	public void Dispose() { }

	// RVA: 0x49B670 Offset: 0x49A870 VA: 0x18049B670 Slot: 5
	public void Get(out ShowFriendsCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.UI
public struct ShowFriendsOptions // TypeDefIndex: 8815
{
	// Fields
	[CompilerGenerated]
	private EpicAccountId <LocalUserId>k__BackingField; // 0x0

	// Properties
	public EpicAccountId LocalUserId { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public EpicAccountId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_LocalUserId(EpicAccountId value) { }
}

// Namespace: Epic.OnlineServices.UI
internal struct ShowFriendsOptionsInternal : ISettable<ShowFriendsOptions>, IDisposable // TypeDefIndex: 8816
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8

	// Properties
	public EpicAccountId LocalUserId { set; }

	// Methods

	// RVA: 0x49BC40 Offset: 0x49AE40 VA: 0x18049BC40
	public void set_LocalUserId(EpicAccountId value) { }

	// RVA: 0x49BBE0 Offset: 0x49ADE0 VA: 0x18049BBE0 Slot: 4
	public void Set(ref ShowFriendsOptions other) { }

	// RVA: 0x49BB40 Offset: 0x49AD40 VA: 0x18049BB40 Slot: 5
	public void Set(ref Nullable<ShowFriendsOptions> other) { }

	// RVA: 0x49BAF0 Offset: 0x49ACF0 VA: 0x18049BAF0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.UI
public struct ShowNativeProfileCallbackInfo : ICallbackInfo // TypeDefIndex: 8817
{
	// Fields
	[CompilerGenerated]
	private Result <ResultCode>k__BackingField; // 0x0
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x8
	[CompilerGenerated]
	private EpicAccountId <LocalUserId>k__BackingField; // 0x10
	[CompilerGenerated]
	private EpicAccountId <TargetUserId>k__BackingField; // 0x18

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public EpicAccountId LocalUserId { get; set; }
	public EpicAccountId TargetUserId { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	[CompilerGenerated]
	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public object get_ClientData() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_ClientData(object value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public EpicAccountId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_LocalUserId(EpicAccountId value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public EpicAccountId get_TargetUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_TargetUserId(EpicAccountId value) { }

	// RVA: 0x49C220 Offset: 0x49B420 VA: 0x18049C220 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x49C270 Offset: 0x49B470 VA: 0x18049C270
	internal void Set(ref ShowNativeProfileCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.UI
internal struct ShowNativeProfileCallbackInfoInternal : ICallbackInfoInternal, IGettable<ShowNativeProfileCallbackInfo>, ISettable<ShowNativeProfileCallbackInfo>, IDisposable // TypeDefIndex: 8818
{
	// Fields
	private Result m_ResultCode; // 0x0
	private IntPtr m_ClientData; // 0x8
	private IntPtr m_LocalUserId; // 0x10
	private IntPtr m_TargetUserId; // 0x18

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public EpicAccountId LocalUserId { get; set; }
	public EpicAccountId TargetUserId { get; set; }

	// Methods

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	// RVA: 0x49BF90 Offset: 0x49B190 VA: 0x18049BF90
	public object get_ClientData() { }

	// RVA: 0x49C100 Offset: 0x49B300 VA: 0x18049C100
	public void set_ClientData(object value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x49C000 Offset: 0x49B200 VA: 0x18049C000
	public EpicAccountId get_LocalUserId() { }

	// RVA: 0x49C160 Offset: 0x49B360 VA: 0x18049C160
	public void set_LocalUserId(EpicAccountId value) { }

	// RVA: 0x49C080 Offset: 0x49B280 VA: 0x18049C080
	public EpicAccountId get_TargetUserId() { }

	// RVA: 0x49C1C0 Offset: 0x49B3C0 VA: 0x18049C1C0
	public void set_TargetUserId(EpicAccountId value) { }

	// RVA: 0x49BE90 Offset: 0x49B090 VA: 0x18049BE90 Slot: 6
	public void Set(ref ShowNativeProfileCallbackInfo other) { }

	// RVA: 0x49BD20 Offset: 0x49AF20 VA: 0x18049BD20 Slot: 7
	public void Set(ref Nullable<ShowNativeProfileCallbackInfo> other) { }

	// RVA: 0x49BCA0 Offset: 0x49AEA0 VA: 0x18049BCA0 Slot: 8
	public void Dispose() { }

	// RVA: 0x49BD00 Offset: 0x49AF00 VA: 0x18049BD00 Slot: 5
	public void Get(out ShowNativeProfileCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.UI
public struct ShowNativeProfileOptions // TypeDefIndex: 8819
{
	// Fields
	[CompilerGenerated]
	private EpicAccountId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private EpicAccountId <TargetUserId>k__BackingField; // 0x8

	// Properties
	public EpicAccountId LocalUserId { get; set; }
	public EpicAccountId TargetUserId { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public EpicAccountId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_LocalUserId(EpicAccountId value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public EpicAccountId get_TargetUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_TargetUserId(EpicAccountId value) { }
}

// Namespace: Epic.OnlineServices.UI
internal struct ShowNativeProfileOptionsInternal : ISettable<ShowNativeProfileOptions>, IDisposable // TypeDefIndex: 8820
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_TargetUserId; // 0x10

	// Properties
	public EpicAccountId LocalUserId { set; }
	public EpicAccountId TargetUserId { set; }

	// Methods

	// RVA: 0x49C530 Offset: 0x49B730 VA: 0x18049C530
	public void set_LocalUserId(EpicAccountId value) { }

	// RVA: 0x49C590 Offset: 0x49B790 VA: 0x18049C590
	public void set_TargetUserId(EpicAccountId value) { }

	// RVA: 0x49C470 Offset: 0x49B670 VA: 0x18049C470 Slot: 4
	public void Set(ref ShowNativeProfileOptions other) { }

	// RVA: 0x49C370 Offset: 0x49B570 VA: 0x18049C370 Slot: 5
	public void Set(ref Nullable<ShowNativeProfileOptions> other) { }

	// RVA: 0x49C310 Offset: 0x49B510 VA: 0x18049C310 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.UI
public struct ShowReportPlayerOptions // TypeDefIndex: 8821
{
	// Fields
	[CompilerGenerated]
	private EpicAccountId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private EpicAccountId <TargetUserId>k__BackingField; // 0x8

	// Properties
	public EpicAccountId LocalUserId { get; set; }
	public EpicAccountId TargetUserId { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public EpicAccountId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_LocalUserId(EpicAccountId value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public EpicAccountId get_TargetUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_TargetUserId(EpicAccountId value) { }
}

// Namespace: Epic.OnlineServices.UI
internal struct ShowReportPlayerOptionsInternal : ISettable<ShowReportPlayerOptions>, IDisposable // TypeDefIndex: 8822
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_TargetUserId; // 0x10

	// Properties
	public EpicAccountId LocalUserId { set; }
	public EpicAccountId TargetUserId { set; }

	// Methods

	// RVA: 0x49C810 Offset: 0x49BA10 VA: 0x18049C810
	public void set_LocalUserId(EpicAccountId value) { }

	// RVA: 0x49C870 Offset: 0x49BA70 VA: 0x18049C870
	public void set_TargetUserId(EpicAccountId value) { }

	// RVA: 0x49C650 Offset: 0x49B850 VA: 0x18049C650 Slot: 4
	public void Set(ref ShowReportPlayerOptions other) { }

	// RVA: 0x49C710 Offset: 0x49B910 VA: 0x18049C710 Slot: 5
	public void Set(ref Nullable<ShowReportPlayerOptions> other) { }

	// RVA: 0x49C5F0 Offset: 0x49B7F0 VA: 0x18049C5F0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.UI
public struct XboxOneGDKMemoryMonitorCallbackInfo : ICallbackInfo // TypeDefIndex: 8823
{
	// Fields
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x0
	[CompilerGenerated]
	private Nullable<XboxOneGDKMemoryMonitorCallbackInfoSystemMemoryMonitorReport> <SystemMemoryMonitorReport>k__BackingField; // 0x8

	// Properties
	public object ClientData { get; set; }
	public Nullable<XboxOneGDKMemoryMonitorCallbackInfoSystemMemoryMonitorReport> SystemMemoryMonitorReport { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410 Slot: 4
	public object get_ClientData() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_ClientData(object value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x42C4A0 Offset: 0x42B6A0 VA: 0x18042C4A0
	public Nullable<XboxOneGDKMemoryMonitorCallbackInfoSystemMemoryMonitorReport> get_SystemMemoryMonitorReport() { }

	[CompilerGenerated]
	// RVA: 0x42C4B0 Offset: 0x42B6B0 VA: 0x18042C4B0
	public void set_SystemMemoryMonitorReport(Nullable<XboxOneGDKMemoryMonitorCallbackInfoSystemMemoryMonitorReport> value) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x4A0600 Offset: 0x49F800 VA: 0x1804A0600
	internal void Set(ref XboxOneGDKMemoryMonitorCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.UI
internal struct XboxOneGDKMemoryMonitorCallbackInfoInternal : ICallbackInfoInternal, IGettable<XboxOneGDKMemoryMonitorCallbackInfo>, ISettable<XboxOneGDKMemoryMonitorCallbackInfo>, IDisposable // TypeDefIndex: 8824
{
	// Fields
	private IntPtr m_ClientData; // 0x0
	private IntPtr m_SystemMemoryMonitorReport; // 0x8

	// Properties
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public Nullable<XboxOneGDKMemoryMonitorCallbackInfoSystemMemoryMonitorReport> SystemMemoryMonitorReport { get; set; }

	// Methods

	// RVA: 0x4A03D0 Offset: 0x49F5D0 VA: 0x1804A03D0
	public object get_ClientData() { }

	// RVA: 0x4A04C0 Offset: 0x49F6C0 VA: 0x1804A04C0
	public void set_ClientData(object value) { }

	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x4A0440 Offset: 0x49F640 VA: 0x1804A0440
	public Nullable<XboxOneGDKMemoryMonitorCallbackInfoSystemMemoryMonitorReport> get_SystemMemoryMonitorReport() { }

	// RVA: 0x4A0520 Offset: 0x49F720 VA: 0x1804A0520
	public void set_SystemMemoryMonitorReport(Nullable<XboxOneGDKMemoryMonitorCallbackInfoSystemMemoryMonitorReport> value) { }

	// RVA: 0x4A01E0 Offset: 0x49F3E0 VA: 0x1804A01E0 Slot: 6
	public void Set(ref XboxOneGDKMemoryMonitorCallbackInfo other) { }

	// RVA: 0x4A02B0 Offset: 0x49F4B0 VA: 0x1804A02B0 Slot: 7
	public void Set(ref Nullable<XboxOneGDKMemoryMonitorCallbackInfo> other) { }

	// RVA: 0x4A0160 Offset: 0x49F360 VA: 0x1804A0160 Slot: 8
	public void Dispose() { }

	// RVA: 0x4A01C0 Offset: 0x49F3C0 VA: 0x1804A01C0 Slot: 5
	public void Get(out XboxOneGDKMemoryMonitorCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.UI
public struct XboxOneGDKMemoryMonitorCallbackInfoSystemMemoryMonitorReport // TypeDefIndex: 8825
{
	// Fields
	[CompilerGenerated]
	private ulong <OverlayUsedCpuMemory>k__BackingField; // 0x0

	// Properties
	public ulong OverlayUsedCpuMemory { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public ulong get_OverlayUsedCpuMemory() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_OverlayUsedCpuMemory(ulong value) { }

	// RVA: 0x454B10 Offset: 0x453D10 VA: 0x180454B10
	internal void Set(ref XboxOneGDKMemoryMonitorCallbackInfoSystemMemoryMonitorReportInternal other) { }
}

// Namespace: Epic.OnlineServices.UI
internal struct XboxOneGDKMemoryMonitorCallbackInfoSystemMemoryMonitorReportInternal : IGettable<XboxOneGDKMemoryMonitorCallbackInfoSystemMemoryMonitorReport>, ISettable<XboxOneGDKMemoryMonitorCallbackInfoSystemMemoryMonitorReport>, IDisposable // TypeDefIndex: 8826
{
	// Fields
	private int m_ApiVersion; // 0x0
	private ulong m_OverlayUsedCpuMemory; // 0x8

	// Properties
	public ulong OverlayUsedCpuMemory { get; set; }

	// Methods

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public ulong get_OverlayUsedCpuMemory() { }

	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_OverlayUsedCpuMemory(ulong value) { }

	// RVA: 0x40DD30 Offset: 0x40CF30 VA: 0x18040DD30 Slot: 5
	public void Set(ref XboxOneGDKMemoryMonitorCallbackInfoSystemMemoryMonitorReport other) { }

	// RVA: 0x4A0590 Offset: 0x49F790 VA: 0x1804A0590 Slot: 6
	public void Set(ref Nullable<XboxOneGDKMemoryMonitorCallbackInfoSystemMemoryMonitorReport> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 7
	public void Dispose() { }

	// RVA: 0x454A90 Offset: 0x453C90 VA: 0x180454A90 Slot: 4
	public void Get(out XboxOneGDKMemoryMonitorCallbackInfoSystemMemoryMonitorReport output) { }
}

// Namespace: Epic.OnlineServices.UI
public sealed class XboxOneGDKOnMemoryMonitorCallback : MulticastDelegate // TypeDefIndex: 8827
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref XboxOneGDKMemoryMonitorCallbackInfo data) { }

	// RVA: 0x4A0770 Offset: 0x49F970 VA: 0x1804A0770 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref XboxOneGDKMemoryMonitorCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref XboxOneGDKMemoryMonitorCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.UI
[UnmanagedFunctionPointer(2)]
internal sealed class XboxOneGDKOnMemoryMonitorCallbackInternal : MulticastDelegate // TypeDefIndex: 8828
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref XboxOneGDKMemoryMonitorCallbackInfoInternal data) { }

	// RVA: 0x4A06E0 Offset: 0x49F8E0 VA: 0x1804A06E0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref XboxOneGDKMemoryMonitorCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref XboxOneGDKMemoryMonitorCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.UI
public struct XboxOneGDKPrePresentAdditionalData // TypeDefIndex: 8829
{
	// Fields
	[CompilerGenerated]
	private int <ScreenRenderTargetResourceState>k__BackingField; // 0x0

	// Properties
	public int ScreenRenderTargetResourceState { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public int get_ScreenRenderTargetResourceState() { }

	[CompilerGenerated]
	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ScreenRenderTargetResourceState(int value) { }

	// RVA: 0x4A0870 Offset: 0x49FA70 VA: 0x1804A0870
	internal void Set(ref XboxOneGDKPrePresentAdditionalDataInternal other) { }
}

// Namespace: Epic.OnlineServices.UI
internal struct XboxOneGDKPrePresentAdditionalDataInternal : IGettable<XboxOneGDKPrePresentAdditionalData>, ISettable<XboxOneGDKPrePresentAdditionalData>, IDisposable // TypeDefIndex: 8830
{
	// Fields
	private int m_ApiVersion; // 0x0
	private int m_ScreenRenderTargetResourceState; // 0x4

	// Properties
	public int ScreenRenderTargetResourceState { get; set; }

	// Methods

	// RVA: 0x3F8350 Offset: 0x3F7550 VA: 0x1803F8350
	public int get_ScreenRenderTargetResourceState() { }

	// RVA: 0x3F84A0 Offset: 0x3F76A0 VA: 0x1803F84A0
	public void set_ScreenRenderTargetResourceState(int value) { }

	// RVA: 0x40B2E0 Offset: 0x40A4E0 VA: 0x18040B2E0 Slot: 5
	public void Set(ref XboxOneGDKPrePresentAdditionalData other) { }

	// RVA: 0x4A0810 Offset: 0x49FA10 VA: 0x1804A0810 Slot: 6
	public void Set(ref Nullable<XboxOneGDKPrePresentAdditionalData> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 7
	public void Dispose() { }

	// RVA: 0x4A0800 Offset: 0x49FA00 VA: 0x1804A0800 Slot: 4
	public void Get(out XboxOneGDKPrePresentAdditionalData output) { }
}

// Namespace: Epic.OnlineServices.UI
public struct XboxOneGDKPrePresentOptions // TypeDefIndex: 8831
{
	// Fields
	[CompilerGenerated]
	private Nullable<XboxOneGDKPrePresentOptionsPlatformSpecificData> <PlatformSpecificData>k__BackingField; // 0x0

	// Properties
	public Nullable<XboxOneGDKPrePresentOptionsPlatformSpecificData> PlatformSpecificData { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x4A13D0 Offset: 0x4A05D0 VA: 0x1804A13D0
	public Nullable<XboxOneGDKPrePresentOptionsPlatformSpecificData> get_PlatformSpecificData() { }

	[CompilerGenerated]
	// RVA: 0x4A1400 Offset: 0x4A0600 VA: 0x1804A1400
	public void set_PlatformSpecificData(Nullable<XboxOneGDKPrePresentOptionsPlatformSpecificData> value) { }
}

// Namespace: Epic.OnlineServices.UI
internal struct XboxOneGDKPrePresentOptionsInternal : ISettable<XboxOneGDKPrePresentOptions>, IDisposable // TypeDefIndex: 8832
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_PlatformSpecificData; // 0x8

	// Properties
	public Nullable<XboxOneGDKPrePresentOptionsPlatformSpecificData> PlatformSpecificData { set; }

	// Methods

	// RVA: 0x4A0A50 Offset: 0x49FC50 VA: 0x1804A0A50
	public void set_PlatformSpecificData(Nullable<XboxOneGDKPrePresentOptionsPlatformSpecificData> value) { }

	// RVA: 0x4A09C0 Offset: 0x49FBC0 VA: 0x1804A09C0 Slot: 4
	public void Set(ref XboxOneGDKPrePresentOptions other) { }

	// RVA: 0x4A08D0 Offset: 0x49FAD0 VA: 0x1804A08D0 Slot: 5
	public void Set(ref Nullable<XboxOneGDKPrePresentOptions> other) { }

	// RVA: 0x4A0880 Offset: 0x49FA80 VA: 0x1804A0880 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.UI
public struct XboxOneGDKPrePresentOptionsPlatformSpecificData : ICallbackInfo // TypeDefIndex: 8833
{
	// Fields
	[CompilerGenerated]
	private IntPtr <ScreenRenderTarget>k__BackingField; // 0x0
	[CompilerGenerated]
	private XboxOneGDKSubmitGraphicsCommandsCallback <SubmitGraphicsCommands>k__BackingField; // 0x8
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x10
	[CompilerGenerated]
	private Nullable<Rect> <ScreenRenderTargetSubRegion>k__BackingField; // 0x18
	[CompilerGenerated]
	private Nullable<XboxOneGDKPrePresentAdditionalData> <AdditionalData>k__BackingField; // 0x2C

	// Properties
	public IntPtr ScreenRenderTarget { get; set; }
	public XboxOneGDKSubmitGraphicsCommandsCallback SubmitGraphicsCommands { get; set; }
	public object ClientData { get; set; }
	public Nullable<Rect> ScreenRenderTargetSubRegion { get; set; }
	public Nullable<XboxOneGDKPrePresentAdditionalData> AdditionalData { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public IntPtr get_ScreenRenderTarget() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_ScreenRenderTarget(IntPtr value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public XboxOneGDKSubmitGraphicsCommandsCallback get_SubmitGraphicsCommands() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_SubmitGraphicsCommands(XboxOneGDKSubmitGraphicsCommandsCallback value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0 Slot: 4
	public object get_ClientData() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_ClientData(object value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x492960 Offset: 0x491B60 VA: 0x180492960
	public Nullable<Rect> get_ScreenRenderTargetSubRegion() { }

	[CompilerGenerated]
	// RVA: 0x492980 Offset: 0x491B80 VA: 0x180492980
	public void set_ScreenRenderTargetSubRegion(Nullable<Rect> value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x4A13B0 Offset: 0x4A05B0 VA: 0x1804A13B0
	public Nullable<XboxOneGDKPrePresentAdditionalData> get_AdditionalData() { }

	[CompilerGenerated]
	// RVA: 0x4A13C0 Offset: 0x4A05C0 VA: 0x1804A13C0
	public void set_AdditionalData(Nullable<XboxOneGDKPrePresentAdditionalData> value) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x4A12A0 Offset: 0x4A04A0 VA: 0x1804A12A0
	internal void Set(ref XboxOneGDKPrePresentOptionsPlatformSpecificDataInternal other) { }
}

// Namespace: Epic.OnlineServices.UI
internal struct XboxOneGDKPrePresentOptionsPlatformSpecificDataInternal : ICallbackInfoInternal, IGettable<XboxOneGDKPrePresentOptionsPlatformSpecificData>, ISettable<XboxOneGDKPrePresentOptionsPlatformSpecificData>, IDisposable // TypeDefIndex: 8834
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_ScreenRenderTarget; // 0x8
	private IntPtr m_SubmitGraphicsCommands; // 0x10
	private IntPtr m_ClientData; // 0x18
	private IntPtr m_ScreenRenderTargetSubRegion; // 0x20
	private IntPtr m_AdditionalData; // 0x28
	private static XboxOneGDKSubmitGraphicsCommandsCallbackInternal s_SubmitGraphicsCommands; // 0x0

	// Properties
	public IntPtr ScreenRenderTarget { get; set; }
	public static XboxOneGDKSubmitGraphicsCommandsCallbackInternal SubmitGraphicsCommands { get; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public Nullable<Rect> ScreenRenderTargetSubRegion { get; set; }
	public Nullable<XboxOneGDKPrePresentAdditionalData> AdditionalData { get; set; }

	// Methods

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public IntPtr get_ScreenRenderTarget() { }

	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_ScreenRenderTarget(IntPtr value) { }

	// RVA: 0x4A10C0 Offset: 0x4A02C0 VA: 0x1804A10C0
	public static XboxOneGDKSubmitGraphicsCommandsCallbackInternal get_SubmitGraphicsCommands() { }

	// RVA: 0x4A0FD0 Offset: 0x4A01D0 VA: 0x1804A0FD0
	public object get_ClientData() { }

	// RVA: 0x4A11D0 Offset: 0x4A03D0 VA: 0x1804A11D0
	public void set_ClientData(object value) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x4A1040 Offset: 0x4A0240 VA: 0x1804A1040
	public Nullable<Rect> get_ScreenRenderTargetSubRegion() { }

	// RVA: 0x4A1230 Offset: 0x4A0430 VA: 0x1804A1230
	public void set_ScreenRenderTargetSubRegion(Nullable<Rect> value) { }

	// RVA: 0x4A0F50 Offset: 0x4A0150 VA: 0x1804A0F50
	public Nullable<XboxOneGDKPrePresentAdditionalData> get_AdditionalData() { }

	// RVA: 0x4A1160 Offset: 0x4A0360 VA: 0x1804A1160
	public void set_AdditionalData(Nullable<XboxOneGDKPrePresentAdditionalData> value) { }

	// RVA: 0x4A0DB0 Offset: 0x49FFB0 VA: 0x1804A0DB0 Slot: 6
	public void Set(ref XboxOneGDKPrePresentOptionsPlatformSpecificData other) { }

	// RVA: 0x4A0B70 Offset: 0x49FD70 VA: 0x1804A0B70 Slot: 7
	public void Set(ref Nullable<XboxOneGDKPrePresentOptionsPlatformSpecificData> other) { }

	// RVA: 0x4A0AC0 Offset: 0x49FCC0 VA: 0x1804A0AC0 Slot: 8
	public void Dispose() { }

	// RVA: 0x4A0B40 Offset: 0x49FD40 VA: 0x1804A0B40 Slot: 5
	public void Get(out XboxOneGDKPrePresentOptionsPlatformSpecificData output) { }
}

// Namespace: Epic.OnlineServices.UI
public sealed class XboxOneGDKSubmitGraphicsCommandsCallback : MulticastDelegate // TypeDefIndex: 8835
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref XboxOneGDKSubmitGraphicsCommandsCallbackInfo data) { }

	// RVA: 0x4B89E0 Offset: 0x4B7BE0 VA: 0x1804B89E0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref XboxOneGDKSubmitGraphicsCommandsCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref XboxOneGDKSubmitGraphicsCommandsCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.UI
[UnmanagedFunctionPointer(2)]
internal sealed class XboxOneGDKSubmitGraphicsCommandsCallbackInternal : MulticastDelegate // TypeDefIndex: 8836
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref XboxOneGDKSubmitGraphicsCommandsCallbackInfoInternal data) { }

	// RVA: 0x4B8950 Offset: 0x4B7B50 VA: 0x1804B8950 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref XboxOneGDKSubmitGraphicsCommandsCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref XboxOneGDKSubmitGraphicsCommandsCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.UI
public struct XboxOneGDKSubmitGraphicsCommandsCallbackInfo : ICallbackInfo // TypeDefIndex: 8837
{
	// Fields
	[CompilerGenerated]
	private XboxOneGDKSubmitGraphicsCommandsDataCommand[] <Commands>k__BackingField; // 0x0
	[CompilerGenerated]
	private ArraySegment<byte>[] <DeviceObjects>k__BackingField; // 0x8
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x10

	// Properties
	public XboxOneGDKSubmitGraphicsCommandsDataCommand[] Commands { get; set; }
	public ArraySegment<byte>[] DeviceObjects { get; set; }
	public object ClientData { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public XboxOneGDKSubmitGraphicsCommandsDataCommand[] get_Commands() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_Commands(XboxOneGDKSubmitGraphicsCommandsDataCommand[] value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public ArraySegment<byte>[] get_DeviceObjects() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_DeviceObjects(ArraySegment<byte>[] value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0 Slot: 4
	public object get_ClientData() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_ClientData(object value) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x4B88C0 Offset: 0x4B7AC0 VA: 0x1804B88C0
	internal void Set(ref XboxOneGDKSubmitGraphicsCommandsCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.UI
internal struct XboxOneGDKSubmitGraphicsCommandsCallbackInfoInternal : ICallbackInfoInternal, IGettable<XboxOneGDKSubmitGraphicsCommandsCallbackInfo>, ISettable<XboxOneGDKSubmitGraphicsCommandsCallbackInfo>, IDisposable // TypeDefIndex: 8838
{
	// Fields
	private int m_ApiVersion; // 0x0
	private uint m_CommandCount; // 0x4
	private IntPtr m_Commands; // 0x8
	private uint m_DeviceObjectCount; // 0x10
	private IntPtr m_DeviceObjects; // 0x18
	private IntPtr m_ClientData; // 0x20

	// Properties
	public XboxOneGDKSubmitGraphicsCommandsDataCommand[] Commands { get; set; }
	public ArraySegment<byte>[] DeviceObjects { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }

	// Methods

	// RVA: 0x4B8650 Offset: 0x4B7850 VA: 0x1804B8650
	public XboxOneGDKSubmitGraphicsCommandsDataCommand[] get_Commands() { }

	// RVA: 0x4B87D0 Offset: 0x4B79D0 VA: 0x1804B87D0
	public void set_Commands(XboxOneGDKSubmitGraphicsCommandsDataCommand[] value) { }

	// RVA: 0x4B86E0 Offset: 0x4B78E0 VA: 0x1804B86E0
	public ArraySegment<byte>[] get_DeviceObjects() { }

	// RVA: 0x4B8840 Offset: 0x4B7A40 VA: 0x1804B8840
	public void set_DeviceObjects(ArraySegment<byte>[] value) { }

	// RVA: 0x4B85E0 Offset: 0x4B77E0 VA: 0x1804B85E0
	public object get_ClientData() { }

	// RVA: 0x4B8770 Offset: 0x4B7970 VA: 0x1804B8770
	public void set_ClientData(object value) { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x4B8410 Offset: 0x4B7610 VA: 0x1804B8410 Slot: 6
	public void Set(ref XboxOneGDKSubmitGraphicsCommandsCallbackInfo other) { }

	// RVA: 0x4B84F0 Offset: 0x4B76F0 VA: 0x1804B84F0 Slot: 7
	public void Set(ref Nullable<XboxOneGDKSubmitGraphicsCommandsCallbackInfo> other) { }

	// RVA: 0x4B8390 Offset: 0x4B7590 VA: 0x1804B8390 Slot: 8
	public void Dispose() { }

	// RVA: 0x4B83F0 Offset: 0x4B75F0 VA: 0x1804B83F0 Slot: 5
	public void Get(out XboxOneGDKSubmitGraphicsCommandsCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.UI
public enum XboxOneGDKSubmitGraphicsCommandsDataAction // TypeDefIndex: 8839
{
	// Fields
	public int value__; // 0x0
	public const XboxOneGDKSubmitGraphicsCommandsDataAction SgcdaExecutegraphicscommandlists = 0;
	public const XboxOneGDKSubmitGraphicsCommandsDataAction SgcdaWaitforfence = 1;
	public const XboxOneGDKSubmitGraphicsCommandsDataAction SgcdaSignalfence = 2;
}

// Namespace: Epic.OnlineServices.UI
public struct XboxOneGDKSubmitGraphicsCommandsDataCommand // TypeDefIndex: 8840
{
	// Fields
	[CompilerGenerated]
	private XboxOneGDKSubmitGraphicsCommandsDataAction <Action>k__BackingField; // 0x0
	[CompilerGenerated]
	private uint <DeviceObjectCount>k__BackingField; // 0x4
	[CompilerGenerated]
	private ulong <ExtraParameter>k__BackingField; // 0x8

	// Properties
	public XboxOneGDKSubmitGraphicsCommandsDataAction Action { get; set; }
	public uint DeviceObjectCount { get; set; }
	public ulong ExtraParameter { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public XboxOneGDKSubmitGraphicsCommandsDataAction get_Action() { }

	[CompilerGenerated]
	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_Action(XboxOneGDKSubmitGraphicsCommandsDataAction value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3F8350 Offset: 0x3F7550 VA: 0x1803F8350
	public uint get_DeviceObjectCount() { }

	[CompilerGenerated]
	// RVA: 0x3F84A0 Offset: 0x3F76A0 VA: 0x1803F84A0
	public void set_DeviceObjectCount(uint value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public ulong get_ExtraParameter() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_ExtraParameter(ulong value) { }

	// RVA: 0x4B82D0 Offset: 0x4B74D0 VA: 0x1804B82D0
	internal void Set(ref XboxOneGDKSubmitGraphicsCommandsDataCommandInternal other) { }
}

// Namespace: Epic.OnlineServices.UI
internal struct XboxOneGDKSubmitGraphicsCommandsDataCommandInternal : IGettable<XboxOneGDKSubmitGraphicsCommandsDataCommand>, ISettable<XboxOneGDKSubmitGraphicsCommandsDataCommand>, IDisposable // TypeDefIndex: 8841
{
	// Fields
	private XboxOneGDKSubmitGraphicsCommandsDataAction m_Action; // 0x0
	private uint m_DeviceObjectCount; // 0x4
	private ulong m_ExtraParameter; // 0x8

	// Properties
	public XboxOneGDKSubmitGraphicsCommandsDataAction Action { get; set; }
	public uint DeviceObjectCount { get; set; }
	public ulong ExtraParameter { get; set; }

	// Methods

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public XboxOneGDKSubmitGraphicsCommandsDataAction get_Action() { }

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_Action(XboxOneGDKSubmitGraphicsCommandsDataAction value) { }

	// RVA: 0x3F8350 Offset: 0x3F7550 VA: 0x1803F8350
	public uint get_DeviceObjectCount() { }

	// RVA: 0x3F84A0 Offset: 0x3F76A0 VA: 0x1803F84A0
	public void set_DeviceObjectCount(uint value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public ulong get_ExtraParameter() { }

	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_ExtraParameter(ulong value) { }

	// RVA: 0x4B82D0 Offset: 0x4B74D0 VA: 0x1804B82D0 Slot: 5
	public void Set(ref XboxOneGDKSubmitGraphicsCommandsDataCommand other) { }

	// RVA: 0x4B8A70 Offset: 0x4B7C70 VA: 0x1804B8A70 Slot: 6
	public void Set(ref Nullable<XboxOneGDKSubmitGraphicsCommandsDataCommand> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 7
	public void Dispose() { }

	// RVA: 0x4B82B0 Offset: 0x4B74B0 VA: 0x1804B82B0 Slot: 4
	public void Get(out XboxOneGDKSubmitGraphicsCommandsDataCommand output) { }
}

// Namespace: Epic.OnlineServices.UI
public struct XSXMemoryMonitorCallbackInfo : ICallbackInfo // TypeDefIndex: 8842
{
	// Fields
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x0
	[CompilerGenerated]
	private Nullable<XSXMemoryMonitorCallbackInfoSystemMemoryMonitorReport> <SystemMemoryMonitorReport>k__BackingField; // 0x8

	// Properties
	public object ClientData { get; set; }
	public Nullable<XSXMemoryMonitorCallbackInfoSystemMemoryMonitorReport> SystemMemoryMonitorReport { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410 Slot: 4
	public object get_ClientData() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_ClientData(object value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x42C4A0 Offset: 0x42B6A0 VA: 0x18042C4A0
	public Nullable<XSXMemoryMonitorCallbackInfoSystemMemoryMonitorReport> get_SystemMemoryMonitorReport() { }

	[CompilerGenerated]
	// RVA: 0x42C4B0 Offset: 0x42B6B0 VA: 0x18042C4B0
	public void set_SystemMemoryMonitorReport(Nullable<XSXMemoryMonitorCallbackInfoSystemMemoryMonitorReport> value) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x4B6DC0 Offset: 0x4B5FC0 VA: 0x1804B6DC0
	internal void Set(ref XSXMemoryMonitorCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.UI
internal struct XSXMemoryMonitorCallbackInfoInternal : ICallbackInfoInternal, IGettable<XSXMemoryMonitorCallbackInfo>, ISettable<XSXMemoryMonitorCallbackInfo>, IDisposable // TypeDefIndex: 8843
{
	// Fields
	private IntPtr m_ClientData; // 0x0
	private IntPtr m_SystemMemoryMonitorReport; // 0x8

	// Properties
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public Nullable<XSXMemoryMonitorCallbackInfoSystemMemoryMonitorReport> SystemMemoryMonitorReport { get; set; }

	// Methods

	// RVA: 0x4B6B90 Offset: 0x4B5D90 VA: 0x1804B6B90
	public object get_ClientData() { }

	// RVA: 0x4B6C80 Offset: 0x4B5E80 VA: 0x1804B6C80
	public void set_ClientData(object value) { }

	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x4B6C00 Offset: 0x4B5E00 VA: 0x1804B6C00
	public Nullable<XSXMemoryMonitorCallbackInfoSystemMemoryMonitorReport> get_SystemMemoryMonitorReport() { }

	// RVA: 0x4B6CE0 Offset: 0x4B5EE0 VA: 0x1804B6CE0
	public void set_SystemMemoryMonitorReport(Nullable<XSXMemoryMonitorCallbackInfoSystemMemoryMonitorReport> value) { }

	// RVA: 0x4B69A0 Offset: 0x4B5BA0 VA: 0x1804B69A0 Slot: 6
	public void Set(ref XSXMemoryMonitorCallbackInfo other) { }

	// RVA: 0x4B6A70 Offset: 0x4B5C70 VA: 0x1804B6A70 Slot: 7
	public void Set(ref Nullable<XSXMemoryMonitorCallbackInfo> other) { }

	// RVA: 0x4B6920 Offset: 0x4B5B20 VA: 0x1804B6920 Slot: 8
	public void Dispose() { }

	// RVA: 0x4B6980 Offset: 0x4B5B80 VA: 0x1804B6980 Slot: 5
	public void Get(out XSXMemoryMonitorCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.UI
public struct XSXMemoryMonitorCallbackInfoSystemMemoryMonitorReport // TypeDefIndex: 8844
{
	// Fields
	[CompilerGenerated]
	private ulong <OverlayUsedCpuMemory>k__BackingField; // 0x0

	// Properties
	public ulong OverlayUsedCpuMemory { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public ulong get_OverlayUsedCpuMemory() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_OverlayUsedCpuMemory(ulong value) { }

	// RVA: 0x454B10 Offset: 0x453D10 VA: 0x180454B10
	internal void Set(ref XSXMemoryMonitorCallbackInfoSystemMemoryMonitorReportInternal other) { }
}

// Namespace: Epic.OnlineServices.UI
internal struct XSXMemoryMonitorCallbackInfoSystemMemoryMonitorReportInternal : IGettable<XSXMemoryMonitorCallbackInfoSystemMemoryMonitorReport>, ISettable<XSXMemoryMonitorCallbackInfoSystemMemoryMonitorReport>, IDisposable // TypeDefIndex: 8845
{
	// Fields
	private int m_ApiVersion; // 0x0
	private ulong m_OverlayUsedCpuMemory; // 0x8

	// Properties
	public ulong OverlayUsedCpuMemory { get; set; }

	// Methods

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public ulong get_OverlayUsedCpuMemory() { }

	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_OverlayUsedCpuMemory(ulong value) { }

	// RVA: 0x40DD30 Offset: 0x40CF30 VA: 0x18040DD30 Slot: 5
	public void Set(ref XSXMemoryMonitorCallbackInfoSystemMemoryMonitorReport other) { }

	// RVA: 0x4B6D50 Offset: 0x4B5F50 VA: 0x1804B6D50 Slot: 6
	public void Set(ref Nullable<XSXMemoryMonitorCallbackInfoSystemMemoryMonitorReport> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 7
	public void Dispose() { }

	// RVA: 0x454A90 Offset: 0x453C90 VA: 0x180454A90 Slot: 4
	public void Get(out XSXMemoryMonitorCallbackInfoSystemMemoryMonitorReport output) { }
}

// Namespace: Epic.OnlineServices.UI
public sealed class XSXOnMemoryMonitorCallback : MulticastDelegate // TypeDefIndex: 8846
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref XSXMemoryMonitorCallbackInfo data) { }

	// RVA: 0x4B6F30 Offset: 0x4B6130 VA: 0x1804B6F30 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref XSXMemoryMonitorCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref XSXMemoryMonitorCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.UI
[UnmanagedFunctionPointer(2)]
internal sealed class XSXOnMemoryMonitorCallbackInternal : MulticastDelegate // TypeDefIndex: 8847
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref XSXMemoryMonitorCallbackInfoInternal data) { }

	// RVA: 0x4B6EA0 Offset: 0x4B60A0 VA: 0x1804B6EA0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref XSXMemoryMonitorCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref XSXMemoryMonitorCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.UI
public struct XSXPrePresentAdditionalData // TypeDefIndex: 8848
{
	// Fields
	[CompilerGenerated]
	private int <ScreenRenderTargetResourceState>k__BackingField; // 0x0

	// Properties
	public int ScreenRenderTargetResourceState { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public int get_ScreenRenderTargetResourceState() { }

	[CompilerGenerated]
	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ScreenRenderTargetResourceState(int value) { }

	// RVA: 0x4A0870 Offset: 0x49FA70 VA: 0x1804A0870
	internal void Set(ref XSXPrePresentAdditionalDataInternal other) { }
}

// Namespace: Epic.OnlineServices.UI
internal struct XSXPrePresentAdditionalDataInternal : IGettable<XSXPrePresentAdditionalData>, ISettable<XSXPrePresentAdditionalData>, IDisposable // TypeDefIndex: 8849
{
	// Fields
	private int m_ApiVersion; // 0x0
	private int m_ScreenRenderTargetResourceState; // 0x4

	// Properties
	public int ScreenRenderTargetResourceState { get; set; }

	// Methods

	// RVA: 0x3F8350 Offset: 0x3F7550 VA: 0x1803F8350
	public int get_ScreenRenderTargetResourceState() { }

	// RVA: 0x3F84A0 Offset: 0x3F76A0 VA: 0x1803F84A0
	public void set_ScreenRenderTargetResourceState(int value) { }

	// RVA: 0x40B2E0 Offset: 0x40A4E0 VA: 0x18040B2E0 Slot: 5
	public void Set(ref XSXPrePresentAdditionalData other) { }

	// RVA: 0x4B6FC0 Offset: 0x4B61C0 VA: 0x1804B6FC0 Slot: 6
	public void Set(ref Nullable<XSXPrePresentAdditionalData> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 7
	public void Dispose() { }

	// RVA: 0x4A0800 Offset: 0x49FA00 VA: 0x1804A0800 Slot: 4
	public void Get(out XSXPrePresentAdditionalData output) { }
}

// Namespace: Epic.OnlineServices.UI
public struct XSXPrePresentOptions // TypeDefIndex: 8850
{
	// Fields
	[CompilerGenerated]
	private Nullable<XSXPrePresentOptionsPlatformSpecificData> <PlatformSpecificData>k__BackingField; // 0x0

	// Properties
	public Nullable<XSXPrePresentOptionsPlatformSpecificData> PlatformSpecificData { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x4A13D0 Offset: 0x4A05D0 VA: 0x1804A13D0
	public Nullable<XSXPrePresentOptionsPlatformSpecificData> get_PlatformSpecificData() { }

	[CompilerGenerated]
	// RVA: 0x4A1400 Offset: 0x4A0600 VA: 0x1804A1400
	public void set_PlatformSpecificData(Nullable<XSXPrePresentOptionsPlatformSpecificData> value) { }
}

// Namespace: Epic.OnlineServices.UI
internal struct XSXPrePresentOptionsInternal : ISettable<XSXPrePresentOptions>, IDisposable // TypeDefIndex: 8851
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_PlatformSpecificData; // 0x8

	// Properties
	public Nullable<XSXPrePresentOptionsPlatformSpecificData> PlatformSpecificData { set; }

	// Methods

	// RVA: 0x4B71F0 Offset: 0x4B63F0 VA: 0x1804B71F0
	public void set_PlatformSpecificData(Nullable<XSXPrePresentOptionsPlatformSpecificData> value) { }

	// RVA: 0x4B7070 Offset: 0x4B6270 VA: 0x1804B7070 Slot: 4
	public void Set(ref XSXPrePresentOptions other) { }

	// RVA: 0x4B7100 Offset: 0x4B6300 VA: 0x1804B7100 Slot: 5
	public void Set(ref Nullable<XSXPrePresentOptions> other) { }

	// RVA: 0x4B7020 Offset: 0x4B6220 VA: 0x1804B7020 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.UI
public struct XSXPrePresentOptionsPlatformSpecificData : ICallbackInfo // TypeDefIndex: 8852
{
	// Fields
	[CompilerGenerated]
	private IntPtr <ScreenRenderTarget>k__BackingField; // 0x0
	[CompilerGenerated]
	private XSXSubmitGraphicsCommandsCallback <SubmitGraphicsCommands>k__BackingField; // 0x8
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x10
	[CompilerGenerated]
	private Nullable<Rect> <ScreenRenderTargetSubRegion>k__BackingField; // 0x18
	[CompilerGenerated]
	private Nullable<XSXPrePresentAdditionalData> <AdditionalData>k__BackingField; // 0x2C

	// Properties
	public IntPtr ScreenRenderTarget { get; set; }
	public XSXSubmitGraphicsCommandsCallback SubmitGraphicsCommands { get; set; }
	public object ClientData { get; set; }
	public Nullable<Rect> ScreenRenderTargetSubRegion { get; set; }
	public Nullable<XSXPrePresentAdditionalData> AdditionalData { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public IntPtr get_ScreenRenderTarget() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_ScreenRenderTarget(IntPtr value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public XSXSubmitGraphicsCommandsCallback get_SubmitGraphicsCommands() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_SubmitGraphicsCommands(XSXSubmitGraphicsCommandsCallback value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0 Slot: 4
	public object get_ClientData() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_ClientData(object value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x492960 Offset: 0x491B60 VA: 0x180492960
	public Nullable<Rect> get_ScreenRenderTargetSubRegion() { }

	[CompilerGenerated]
	// RVA: 0x492980 Offset: 0x491B80 VA: 0x180492980
	public void set_ScreenRenderTargetSubRegion(Nullable<Rect> value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x4A13B0 Offset: 0x4A05B0 VA: 0x1804A13B0
	public Nullable<XSXPrePresentAdditionalData> get_AdditionalData() { }

	[CompilerGenerated]
	// RVA: 0x4A13C0 Offset: 0x4A05C0 VA: 0x1804A13C0
	public void set_AdditionalData(Nullable<XSXPrePresentAdditionalData> value) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x4B7AC0 Offset: 0x4B6CC0 VA: 0x1804B7AC0
	internal void Set(ref XSXPrePresentOptionsPlatformSpecificDataInternal other) { }
}

// Namespace: Epic.OnlineServices.UI
internal struct XSXPrePresentOptionsPlatformSpecificDataInternal : ICallbackInfoInternal, IGettable<XSXPrePresentOptionsPlatformSpecificData>, ISettable<XSXPrePresentOptionsPlatformSpecificData>, IDisposable // TypeDefIndex: 8853
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_ScreenRenderTarget; // 0x8
	private IntPtr m_SubmitGraphicsCommands; // 0x10
	private IntPtr m_ClientData; // 0x18
	private IntPtr m_ScreenRenderTargetSubRegion; // 0x20
	private IntPtr m_AdditionalData; // 0x28
	private static XSXSubmitGraphicsCommandsCallbackInternal s_SubmitGraphicsCommands; // 0x0

	// Properties
	public IntPtr ScreenRenderTarget { get; set; }
	public static XSXSubmitGraphicsCommandsCallbackInternal SubmitGraphicsCommands { get; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public Nullable<Rect> ScreenRenderTargetSubRegion { get; set; }
	public Nullable<XSXPrePresentAdditionalData> AdditionalData { get; set; }

	// Methods

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public IntPtr get_ScreenRenderTarget() { }

	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_ScreenRenderTarget(IntPtr value) { }

	// RVA: 0x4B7860 Offset: 0x4B6A60 VA: 0x1804B7860
	public static XSXSubmitGraphicsCommandsCallbackInternal get_SubmitGraphicsCommands() { }

	// RVA: 0x4B7770 Offset: 0x4B6970 VA: 0x1804B7770
	public object get_ClientData() { }

	// RVA: 0x4B79F0 Offset: 0x4B6BF0 VA: 0x1804B79F0
	public void set_ClientData(object value) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x4B77E0 Offset: 0x4B69E0 VA: 0x1804B77E0
	public Nullable<Rect> get_ScreenRenderTargetSubRegion() { }

	// RVA: 0x4B7A50 Offset: 0x4B6C50 VA: 0x1804B7A50
	public void set_ScreenRenderTargetSubRegion(Nullable<Rect> value) { }

	// RVA: 0x4B76F0 Offset: 0x4B68F0 VA: 0x1804B76F0
	public Nullable<XSXPrePresentAdditionalData> get_AdditionalData() { }

	// RVA: 0x4B7980 Offset: 0x4B6B80 VA: 0x1804B7980
	public void set_AdditionalData(Nullable<XSXPrePresentAdditionalData> value) { }

	// RVA: 0x4B7550 Offset: 0x4B6750 VA: 0x1804B7550 Slot: 6
	public void Set(ref XSXPrePresentOptionsPlatformSpecificData other) { }

	// RVA: 0x4B7310 Offset: 0x4B6510 VA: 0x1804B7310 Slot: 7
	public void Set(ref Nullable<XSXPrePresentOptionsPlatformSpecificData> other) { }

	// RVA: 0x4B7260 Offset: 0x4B6460 VA: 0x1804B7260 Slot: 8
	public void Dispose() { }

	// RVA: 0x4B72E0 Offset: 0x4B64E0 VA: 0x1804B72E0 Slot: 5
	public void Get(out XSXPrePresentOptionsPlatformSpecificData output) { }
}

// Namespace: Epic.OnlineServices.UI
public sealed class XSXSubmitGraphicsCommandsCallback : MulticastDelegate // TypeDefIndex: 8854
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref XSXSubmitGraphicsCommandsCallbackInfo data) { }

	// RVA: 0x4B8220 Offset: 0x4B7420 VA: 0x1804B8220 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref XSXSubmitGraphicsCommandsCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref XSXSubmitGraphicsCommandsCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.UI
[UnmanagedFunctionPointer(2)]
internal sealed class XSXSubmitGraphicsCommandsCallbackInternal : MulticastDelegate // TypeDefIndex: 8855
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref XSXSubmitGraphicsCommandsCallbackInfoInternal data) { }

	// RVA: 0x4B8190 Offset: 0x4B7390 VA: 0x1804B8190 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref XSXSubmitGraphicsCommandsCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref XSXSubmitGraphicsCommandsCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.UI
public struct XSXSubmitGraphicsCommandsCallbackInfo : ICallbackInfo // TypeDefIndex: 8856
{
	// Fields
	[CompilerGenerated]
	private XSXSubmitGraphicsCommandsDataCommand[] <Commands>k__BackingField; // 0x0
	[CompilerGenerated]
	private ArraySegment<byte>[] <DeviceObjects>k__BackingField; // 0x8
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x10

	// Properties
	public XSXSubmitGraphicsCommandsDataCommand[] Commands { get; set; }
	public ArraySegment<byte>[] DeviceObjects { get; set; }
	public object ClientData { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public XSXSubmitGraphicsCommandsDataCommand[] get_Commands() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_Commands(XSXSubmitGraphicsCommandsDataCommand[] value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public ArraySegment<byte>[] get_DeviceObjects() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_DeviceObjects(ArraySegment<byte>[] value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0 Slot: 4
	public object get_ClientData() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_ClientData(object value) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x4B8100 Offset: 0x4B7300 VA: 0x1804B8100
	internal void Set(ref XSXSubmitGraphicsCommandsCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.UI
internal struct XSXSubmitGraphicsCommandsCallbackInfoInternal : ICallbackInfoInternal, IGettable<XSXSubmitGraphicsCommandsCallbackInfo>, ISettable<XSXSubmitGraphicsCommandsCallbackInfo>, IDisposable // TypeDefIndex: 8857
{
	// Fields
	private int m_ApiVersion; // 0x0
	private uint m_CommandCount; // 0x4
	private IntPtr m_Commands; // 0x8
	private uint m_DeviceObjectCount; // 0x10
	private IntPtr m_DeviceObjects; // 0x18
	private IntPtr m_ClientData; // 0x20

	// Properties
	public XSXSubmitGraphicsCommandsDataCommand[] Commands { get; set; }
	public ArraySegment<byte>[] DeviceObjects { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }

	// Methods

	// RVA: 0x4B7E90 Offset: 0x4B7090 VA: 0x1804B7E90
	public XSXSubmitGraphicsCommandsDataCommand[] get_Commands() { }

	// RVA: 0x4B8010 Offset: 0x4B7210 VA: 0x1804B8010
	public void set_Commands(XSXSubmitGraphicsCommandsDataCommand[] value) { }

	// RVA: 0x4B7F20 Offset: 0x4B7120 VA: 0x1804B7F20
	public ArraySegment<byte>[] get_DeviceObjects() { }

	// RVA: 0x4B8080 Offset: 0x4B7280 VA: 0x1804B8080
	public void set_DeviceObjects(ArraySegment<byte>[] value) { }

	// RVA: 0x4B7E20 Offset: 0x4B7020 VA: 0x1804B7E20
	public object get_ClientData() { }

	// RVA: 0x4B7FB0 Offset: 0x4B71B0 VA: 0x1804B7FB0
	public void set_ClientData(object value) { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x4B7C50 Offset: 0x4B6E50 VA: 0x1804B7C50 Slot: 6
	public void Set(ref XSXSubmitGraphicsCommandsCallbackInfo other) { }

	// RVA: 0x4B7D30 Offset: 0x4B6F30 VA: 0x1804B7D30 Slot: 7
	public void Set(ref Nullable<XSXSubmitGraphicsCommandsCallbackInfo> other) { }

	// RVA: 0x4B7BD0 Offset: 0x4B6DD0 VA: 0x1804B7BD0 Slot: 8
	public void Dispose() { }

	// RVA: 0x4B7C30 Offset: 0x4B6E30 VA: 0x1804B7C30 Slot: 5
	public void Get(out XSXSubmitGraphicsCommandsCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.UI
public enum XSXSubmitGraphicsCommandsDataAction // TypeDefIndex: 8858
{
	// Fields
	public int value__; // 0x0
	public const XSXSubmitGraphicsCommandsDataAction SgcdaExecutegraphicscommandlists = 0;
	public const XSXSubmitGraphicsCommandsDataAction SgcdaWaitforfence = 1;
	public const XSXSubmitGraphicsCommandsDataAction SgcdaSignalfence = 2;
}

// Namespace: Epic.OnlineServices.UI
public struct XSXSubmitGraphicsCommandsDataCommand // TypeDefIndex: 8859
{
	// Fields
	[CompilerGenerated]
	private XSXSubmitGraphicsCommandsDataAction <Action>k__BackingField; // 0x0
	[CompilerGenerated]
	private uint <DeviceObjectCount>k__BackingField; // 0x4
	[CompilerGenerated]
	private ulong <ExtraParameter>k__BackingField; // 0x8

	// Properties
	public XSXSubmitGraphicsCommandsDataAction Action { get; set; }
	public uint DeviceObjectCount { get; set; }
	public ulong ExtraParameter { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public XSXSubmitGraphicsCommandsDataAction get_Action() { }

	[CompilerGenerated]
	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_Action(XSXSubmitGraphicsCommandsDataAction value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3F8350 Offset: 0x3F7550 VA: 0x1803F8350
	public uint get_DeviceObjectCount() { }

	[CompilerGenerated]
	// RVA: 0x3F84A0 Offset: 0x3F76A0 VA: 0x1803F84A0
	public void set_DeviceObjectCount(uint value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public ulong get_ExtraParameter() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_ExtraParameter(ulong value) { }

	// RVA: 0x4B82D0 Offset: 0x4B74D0 VA: 0x1804B82D0
	internal void Set(ref XSXSubmitGraphicsCommandsDataCommandInternal other) { }
}

// Namespace: Epic.OnlineServices.UI
internal struct XSXSubmitGraphicsCommandsDataCommandInternal : IGettable<XSXSubmitGraphicsCommandsDataCommand>, ISettable<XSXSubmitGraphicsCommandsDataCommand>, IDisposable // TypeDefIndex: 8860
{
	// Fields
	private XSXSubmitGraphicsCommandsDataAction m_Action; // 0x0
	private uint m_DeviceObjectCount; // 0x4
	private ulong m_ExtraParameter; // 0x8

	// Properties
	public XSXSubmitGraphicsCommandsDataAction Action { get; set; }
	public uint DeviceObjectCount { get; set; }
	public ulong ExtraParameter { get; set; }

	// Methods

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public XSXSubmitGraphicsCommandsDataAction get_Action() { }

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_Action(XSXSubmitGraphicsCommandsDataAction value) { }

	// RVA: 0x3F8350 Offset: 0x3F7550 VA: 0x1803F8350
	public uint get_DeviceObjectCount() { }

	// RVA: 0x3F84A0 Offset: 0x3F76A0 VA: 0x1803F84A0
	public void set_DeviceObjectCount(uint value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public ulong get_ExtraParameter() { }

	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_ExtraParameter(ulong value) { }

	// RVA: 0x4B82D0 Offset: 0x4B74D0 VA: 0x1804B82D0 Slot: 5
	public void Set(ref XSXSubmitGraphicsCommandsDataCommand other) { }

	// RVA: 0x4B82F0 Offset: 0x4B74F0 VA: 0x1804B82F0 Slot: 6
	public void Set(ref Nullable<XSXSubmitGraphicsCommandsDataCommand> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 7
	public void Dispose() { }

	// RVA: 0x4B82B0 Offset: 0x4B74B0 VA: 0x1804B82B0 Slot: 4
	public void Get(out XSXSubmitGraphicsCommandsDataCommand output) { }
}

// Namespace: Epic.OnlineServices.PS4
public sealed class IntegratedPlatform // TypeDefIndex: 8861
{
	// Fields
	public static readonly Utf8String IptPsn; // 0x0

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }

	// RVA: 0x4A8980 Offset: 0x4A7B80 VA: 0x1804A8980
	private static void .cctor() { }
}

// Namespace: Epic.OnlineServices.PS4
public enum PS4AccessType // TypeDefIndex: 8862
{
	// Fields
	public int value__; // 0x0
	public const PS4AccessType Default = 0;
	public const PS4AccessType WriteCombineGpu = 1;
}

// Namespace: Epic.OnlineServices.PS4
public sealed class PS4Interface // TypeDefIndex: 8863
{
	// Methods

	[MonoPInvokeCallback(typeof(PS4VMCommitFuncInternal))]
	// RVA: 0x4AC9A0 Offset: 0x4ABBA0 VA: 0x1804AC9A0
	internal static int PS4CommitFuncInternalImplementation(IntPtr address, UIntPtr sizeInBytes, IntPtr contextData) { }

	[MonoPInvokeCallback(typeof(PS4VMDecommitFuncInternal))]
	// RVA: 0x4ACAD0 Offset: 0x4ABCD0 VA: 0x1804ACAD0
	internal static int PS4DecommitFuncInternalImplementation(IntPtr address, UIntPtr sizeInBytes, IntPtr contextData) { }

	[MonoPInvokeCallback(typeof(PS4VMReleaseFuncInternal))]
	// RVA: 0x4ACC00 Offset: 0x4ABE00 VA: 0x1804ACC00
	internal static int PS4ReleaseFuncInternalImplementation(IntPtr address, UIntPtr sizeInBytes, IntPtr contextData) { }

	[MonoPInvokeCallback(typeof(PS4VMReserveFuncInternal))]
	// RVA: 0x4ACD30 Offset: 0x4ABF30 VA: 0x1804ACD30
	internal static IntPtr PS4ReserveFuncInternalImplementation(UIntPtr sizeInBytes, PS4AccessType accessType, ref IntPtr outContextData) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: Epic.OnlineServices.PS4
public sealed class PS4VMCommitFunc : MulticastDelegate // TypeDefIndex: 8864
{
	// Methods

	// RVA: 0x409E90 Offset: 0x409090 VA: 0x180409E90
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x409CF0 Offset: 0x408EF0 VA: 0x180409CF0 Slot: 13
	public virtual bool Invoke(IntPtr address, UIntPtr sizeInBytes, IntPtr contextData) { }

	// RVA: 0x4ACEE0 Offset: 0x4AC0E0 VA: 0x1804ACEE0 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr address, UIntPtr sizeInBytes, IntPtr contextData, AsyncCallback callback, object object) { }

	// RVA: 0x409E60 Offset: 0x409060 VA: 0x180409E60 Slot: 15
	public virtual bool EndInvoke(IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.PS4
[UnmanagedFunctionPointer(2)]
internal sealed class PS4VMCommitFuncInternal : MulticastDelegate // TypeDefIndex: 8865
{
	// Methods

	// RVA: 0x409D10 Offset: 0x408F10 VA: 0x180409D10
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x409CF0 Offset: 0x408EF0 VA: 0x180409CF0 Slot: 13
	public virtual int Invoke(IntPtr address, UIntPtr sizeInBytes, IntPtr contextData) { }

	// RVA: 0x4ACE30 Offset: 0x4AC030 VA: 0x1804ACE30 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr address, UIntPtr sizeInBytes, IntPtr contextData, AsyncCallback callback, object object) { }

	// RVA: 0x409CC0 Offset: 0x408EC0 VA: 0x180409CC0 Slot: 15
	public virtual int EndInvoke(IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.PS4
public sealed class PS4VMDecommitFunc : MulticastDelegate // TypeDefIndex: 8866
{
	// Methods

	// RVA: 0x409E90 Offset: 0x409090 VA: 0x180409E90
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x409CF0 Offset: 0x408EF0 VA: 0x180409CF0 Slot: 13
	public virtual bool Invoke(IntPtr address, UIntPtr sizeInBytes, IntPtr contextData) { }

	// RVA: 0x4AD040 Offset: 0x4AC240 VA: 0x1804AD040 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr address, UIntPtr sizeInBytes, IntPtr contextData, AsyncCallback callback, object object) { }

	// RVA: 0x409E60 Offset: 0x409060 VA: 0x180409E60 Slot: 15
	public virtual bool EndInvoke(IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.PS4
[UnmanagedFunctionPointer(2)]
internal sealed class PS4VMDecommitFuncInternal : MulticastDelegate // TypeDefIndex: 8867
{
	// Methods

	// RVA: 0x409D10 Offset: 0x408F10 VA: 0x180409D10
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x409CF0 Offset: 0x408EF0 VA: 0x180409CF0 Slot: 13
	public virtual int Invoke(IntPtr address, UIntPtr sizeInBytes, IntPtr contextData) { }

	// RVA: 0x4ACF90 Offset: 0x4AC190 VA: 0x1804ACF90 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr address, UIntPtr sizeInBytes, IntPtr contextData, AsyncCallback callback, object object) { }

	// RVA: 0x409CC0 Offset: 0x408EC0 VA: 0x180409CC0 Slot: 15
	public virtual int EndInvoke(IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.PS4
public sealed class PS4VMReleaseFunc : MulticastDelegate // TypeDefIndex: 8868
{
	// Methods

	// RVA: 0x409E90 Offset: 0x409090 VA: 0x180409E90
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x409CF0 Offset: 0x408EF0 VA: 0x180409CF0 Slot: 13
	public virtual bool Invoke(IntPtr address, UIntPtr sizeInBytes, IntPtr contextData) { }

	// RVA: 0x4AD1A0 Offset: 0x4AC3A0 VA: 0x1804AD1A0 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr address, UIntPtr sizeInBytes, IntPtr contextData, AsyncCallback callback, object object) { }

	// RVA: 0x409E60 Offset: 0x409060 VA: 0x180409E60 Slot: 15
	public virtual bool EndInvoke(IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.PS4
[UnmanagedFunctionPointer(2)]
internal sealed class PS4VMReleaseFuncInternal : MulticastDelegate // TypeDefIndex: 8869
{
	// Methods

	// RVA: 0x409D10 Offset: 0x408F10 VA: 0x180409D10
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x409CF0 Offset: 0x408EF0 VA: 0x180409CF0 Slot: 13
	public virtual int Invoke(IntPtr address, UIntPtr sizeInBytes, IntPtr contextData) { }

	// RVA: 0x4AD0F0 Offset: 0x4AC2F0 VA: 0x1804AD0F0 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr address, UIntPtr sizeInBytes, IntPtr contextData, AsyncCallback callback, object object) { }

	// RVA: 0x409CC0 Offset: 0x408EC0 VA: 0x180409CC0 Slot: 15
	public virtual int EndInvoke(IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.PS4
public sealed class PS4VMReserveFunc : MulticastDelegate // TypeDefIndex: 8870
{
	// Methods

	// RVA: 0x40A2F0 Offset: 0x4094F0 VA: 0x18040A2F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x409CF0 Offset: 0x408EF0 VA: 0x180409CF0 Slot: 13
	public virtual IntPtr Invoke(UIntPtr sizeInBytes, PS4AccessType accessType, out IntPtr outContextData) { }

	// RVA: 0x4AD310 Offset: 0x4AC510 VA: 0x1804AD310 Slot: 14
	public virtual IAsyncResult BeginInvoke(UIntPtr sizeInBytes, PS4AccessType accessType, out IntPtr outContextData, AsyncCallback callback, object object) { }

	// RVA: 0x40A2B0 Offset: 0x4094B0 VA: 0x18040A2B0 Slot: 15
	public virtual IntPtr EndInvoke(out IntPtr outContextData, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.PS4
[UnmanagedFunctionPointer(2)]
internal sealed class PS4VMReserveFuncInternal : MulticastDelegate // TypeDefIndex: 8871
{
	// Methods

	// RVA: 0x40A2F0 Offset: 0x4094F0 VA: 0x18040A2F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x409CF0 Offset: 0x408EF0 VA: 0x180409CF0 Slot: 13
	public virtual IntPtr Invoke(UIntPtr sizeInBytes, PS4AccessType accessType, ref IntPtr outContextData) { }

	// RVA: 0x4AD250 Offset: 0x4AC450 VA: 0x1804AD250 Slot: 14
	public virtual IAsyncResult BeginInvoke(UIntPtr sizeInBytes, PS4AccessType accessType, ref IntPtr outContextData, AsyncCallback callback, object object) { }

	// RVA: 0x40A2B0 Offset: 0x4094B0 VA: 0x18040A2B0 Slot: 15
	public virtual IntPtr EndInvoke(ref IntPtr outContextData, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.ProgressionSnapshot
public struct AddProgressionOptions // TypeDefIndex: 8872
{
	// Fields
	[CompilerGenerated]
	private uint <SnapshotId>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <Key>k__BackingField; // 0x8
	[CompilerGenerated]
	private Utf8String <Value>k__BackingField; // 0x10

	// Properties
	public uint SnapshotId { get; set; }
	public Utf8String Key { get; set; }
	public Utf8String Value { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public uint get_SnapshotId() { }

	[CompilerGenerated]
	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_SnapshotId(uint value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public Utf8String get_Key() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_Key(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Utf8String get_Value() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_Value(Utf8String value) { }
}

// Namespace: Epic.OnlineServices.ProgressionSnapshot
internal struct AddProgressionOptionsInternal : ISettable<AddProgressionOptions>, IDisposable // TypeDefIndex: 8873
{
	// Fields
	private int m_ApiVersion; // 0x0
	private uint m_SnapshotId; // 0x4
	private IntPtr m_Key; // 0x8
	private IntPtr m_Value; // 0x10

	// Properties
	public uint SnapshotId { set; }
	public Utf8String Key { set; }
	public Utf8String Value { set; }

	// Methods

	// RVA: 0x3F84A0 Offset: 0x3F76A0 VA: 0x1803F84A0
	public void set_SnapshotId(uint value) { }

	// RVA: 0x4A2960 Offset: 0x4A1B60 VA: 0x1804A2960
	public void set_Key(Utf8String value) { }

	// RVA: 0x4A29C0 Offset: 0x4A1BC0 VA: 0x1804A29C0
	public void set_Value(Utf8String value) { }

	// RVA: 0x4A28A0 Offset: 0x4A1AA0 VA: 0x1804A28A0 Slot: 4
	public void Set(ref AddProgressionOptions other) { }

	// RVA: 0x4A2780 Offset: 0x4A1980 VA: 0x1804A2780 Slot: 5
	public void Set(ref Nullable<AddProgressionOptions> other) { }

	// RVA: 0x4A2720 Offset: 0x4A1920 VA: 0x1804A2720 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.ProgressionSnapshot
public struct BeginSnapshotOptions // TypeDefIndex: 8874
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x0

	// Properties
	public ProductUserId LocalUserId { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_LocalUserId(ProductUserId value) { }
}

// Namespace: Epic.OnlineServices.ProgressionSnapshot
internal struct BeginSnapshotOptionsInternal : ISettable<BeginSnapshotOptions>, IDisposable // TypeDefIndex: 8875
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8

	// Properties
	public ProductUserId LocalUserId { set; }

	// Methods

	// RVA: 0x4A2B70 Offset: 0x4A1D70 VA: 0x1804A2B70
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x4A2B10 Offset: 0x4A1D10 VA: 0x1804A2B10 Slot: 4
	public void Set(ref BeginSnapshotOptions other) { }

	// RVA: 0x4A2A70 Offset: 0x4A1C70 VA: 0x1804A2A70 Slot: 5
	public void Set(ref Nullable<BeginSnapshotOptions> other) { }

	// RVA: 0x4A2A20 Offset: 0x4A1C20 VA: 0x1804A2A20 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.ProgressionSnapshot
public struct DeleteSnapshotCallbackInfo : ICallbackInfo // TypeDefIndex: 8876
{
	// Fields
	[CompilerGenerated]
	private Result <ResultCode>k__BackingField; // 0x0
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x8
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x10

	// Properties
	public Result ResultCode { get; set; }
	public ProductUserId LocalUserId { get; set; }
	public object ClientData { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	[CompilerGenerated]
	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_LocalUserId(ProductUserId value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0 Slot: 4
	public object get_ClientData() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_ClientData(object value) { }

	// RVA: 0x4A5830 Offset: 0x4A4A30 VA: 0x1804A5830 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x4A5880 Offset: 0x4A4A80 VA: 0x1804A5880
	internal void Set(ref DeleteSnapshotCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.ProgressionSnapshot
internal struct DeleteSnapshotCallbackInfoInternal : ICallbackInfoInternal, IGettable<DeleteSnapshotCallbackInfo>, ISettable<DeleteSnapshotCallbackInfo>, IDisposable // TypeDefIndex: 8877
{
	// Fields
	private Result m_ResultCode; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_ClientData; // 0x10

	// Properties
	public Result ResultCode { get; set; }
	public ProductUserId LocalUserId { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }

	// Methods

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	// RVA: 0x4A56F0 Offset: 0x4A48F0 VA: 0x1804A56F0
	public ProductUserId get_LocalUserId() { }

	// RVA: 0x4A57D0 Offset: 0x4A49D0 VA: 0x1804A57D0
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x4A5680 Offset: 0x4A4880 VA: 0x1804A5680
	public object get_ClientData() { }

	// RVA: 0x4A5770 Offset: 0x4A4970 VA: 0x1804A5770
	public void set_ClientData(object value) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x4A55D0 Offset: 0x4A47D0 VA: 0x1804A55D0 Slot: 6
	public void Set(ref DeleteSnapshotCallbackInfo other) { }

	// RVA: 0x4A54B0 Offset: 0x4A46B0 VA: 0x1804A54B0 Slot: 7
	public void Set(ref Nullable<DeleteSnapshotCallbackInfo> other) { }

	// RVA: 0x4A5430 Offset: 0x4A4630 VA: 0x1804A5430 Slot: 8
	public void Dispose() { }

	// RVA: 0x4A5490 Offset: 0x4A4690 VA: 0x1804A5490 Slot: 5
	public void Get(out DeleteSnapshotCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.ProgressionSnapshot
public struct DeleteSnapshotOptions // TypeDefIndex: 8878
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x0

	// Properties
	public ProductUserId LocalUserId { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_LocalUserId(ProductUserId value) { }
}

// Namespace: Epic.OnlineServices.ProgressionSnapshot
internal struct DeleteSnapshotOptionsInternal : ISettable<DeleteSnapshotOptions>, IDisposable // TypeDefIndex: 8879
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8

	// Properties
	public ProductUserId LocalUserId { set; }

	// Methods

	// RVA: 0x4A5A60 Offset: 0x4A4C60 VA: 0x1804A5A60
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x4A5960 Offset: 0x4A4B60 VA: 0x1804A5960 Slot: 4
	public void Set(ref DeleteSnapshotOptions other) { }

	// RVA: 0x4A59C0 Offset: 0x4A4BC0 VA: 0x1804A59C0 Slot: 5
	public void Set(ref Nullable<DeleteSnapshotOptions> other) { }

	// RVA: 0x4A5910 Offset: 0x4A4B10 VA: 0x1804A5910 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.ProgressionSnapshot
public struct EndSnapshotOptions // TypeDefIndex: 8880
{
	// Fields
	[CompilerGenerated]
	private uint <SnapshotId>k__BackingField; // 0x0

	// Properties
	public uint SnapshotId { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public uint get_SnapshotId() { }

	[CompilerGenerated]
	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_SnapshotId(uint value) { }
}

// Namespace: Epic.OnlineServices.ProgressionSnapshot
internal struct EndSnapshotOptionsInternal : ISettable<EndSnapshotOptions>, IDisposable // TypeDefIndex: 8881
{
	// Fields
	private int m_ApiVersion; // 0x0
	private uint m_SnapshotId; // 0x4

	// Properties
	public uint SnapshotId { set; }

	// Methods

	// RVA: 0x3F84A0 Offset: 0x3F76A0 VA: 0x1803F84A0
	public void set_SnapshotId(uint value) { }

	// RVA: 0x40B2E0 Offset: 0x40A4E0 VA: 0x18040B2E0 Slot: 4
	public void Set(ref EndSnapshotOptions other) { }

	// RVA: 0x4A6380 Offset: 0x4A5580 VA: 0x1804A6380 Slot: 5
	public void Set(ref Nullable<EndSnapshotOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.ProgressionSnapshot
public sealed class OnDeleteSnapshotCallback : MulticastDelegate // TypeDefIndex: 8882
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref DeleteSnapshotCallbackInfo data) { }

	// RVA: 0x4A94D0 Offset: 0x4A86D0 VA: 0x1804A94D0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref DeleteSnapshotCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref DeleteSnapshotCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.ProgressionSnapshot
[UnmanagedFunctionPointer(2)]
internal sealed class OnDeleteSnapshotCallbackInternal : MulticastDelegate // TypeDefIndex: 8883
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref DeleteSnapshotCallbackInfoInternal data) { }

	// RVA: 0x4A9440 Offset: 0x4A8640 VA: 0x1804A9440 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref DeleteSnapshotCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref DeleteSnapshotCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.ProgressionSnapshot
public sealed class OnSubmitSnapshotCallback : MulticastDelegate // TypeDefIndex: 8884
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref SubmitSnapshotCallbackInfo data) { }

	// RVA: 0x4AC4E0 Offset: 0x4AB6E0 VA: 0x1804AC4E0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref SubmitSnapshotCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref SubmitSnapshotCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.ProgressionSnapshot
[UnmanagedFunctionPointer(2)]
internal sealed class OnSubmitSnapshotCallbackInternal : MulticastDelegate // TypeDefIndex: 8885
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref SubmitSnapshotCallbackInfoInternal data) { }

	// RVA: 0x4AC450 Offset: 0x4AB650 VA: 0x1804AC450 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref SubmitSnapshotCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref SubmitSnapshotCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.ProgressionSnapshot
public sealed class ProgressionSnapshotInterface : Handle // TypeDefIndex: 8886
{
	// Fields
	public const int AddprogressionApiLatest = 1;
	public const int BeginsnapshotApiLatest = 1;
	public const int DeletesnapshotApiLatest = 1;
	public const int EndsnapshotApiLatest = 1;
	public const int InvalidProgressionsnapshotid = 0;
	public const int SubmitsnapshotApiLatest = 1;

	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }

	// RVA: 0x40BDB0 Offset: 0x40AFB0 VA: 0x18040BDB0
	public void .ctor(IntPtr innerHandle) { }

	// RVA: 0x4B11C0 Offset: 0x4B03C0 VA: 0x1804B11C0
	public Result AddProgression(ref AddProgressionOptions options) { }

	// RVA: 0x4B1260 Offset: 0x4B0460 VA: 0x1804B1260
	public Result BeginSnapshot(ref BeginSnapshotOptions options, out uint outSnapshotId) { }

	// RVA: 0x4B1360 Offset: 0x4B0560 VA: 0x1804B1360
	public void DeleteSnapshot(ref DeleteSnapshotOptions options, object clientData, OnDeleteSnapshotCallback completionDelegate) { }

	// RVA: 0x4B1550 Offset: 0x4B0750 VA: 0x1804B1550
	public Result EndSnapshot(ref EndSnapshotOptions options) { }

	// RVA: 0x4B1730 Offset: 0x4B0930 VA: 0x1804B1730
	public void SubmitSnapshot(ref SubmitSnapshotOptions options, object clientData, OnSubmitSnapshotCallback completionDelegate) { }

	[MonoPInvokeCallback(typeof(OnDeleteSnapshotCallbackInternal))]
	// RVA: 0x4B15E0 Offset: 0x4B07E0 VA: 0x1804B15E0
	internal static void OnDeleteSnapshotCallbackInternalImplementation(ref DeleteSnapshotCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnSubmitSnapshotCallbackInternal))]
	// RVA: 0x4B1690 Offset: 0x4B0890 VA: 0x1804B1690
	internal static void OnSubmitSnapshotCallbackInternalImplementation(ref SubmitSnapshotCallbackInfoInternal data) { }
}

// Namespace: Epic.OnlineServices.ProgressionSnapshot
public struct SubmitSnapshotCallbackInfo : ICallbackInfo // TypeDefIndex: 8887
{
	// Fields
	[CompilerGenerated]
	private Result <ResultCode>k__BackingField; // 0x0
	[CompilerGenerated]
	private uint <SnapshotId>k__BackingField; // 0x4
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x8

	// Properties
	public Result ResultCode { get; set; }
	public uint SnapshotId { get; set; }
	public object ClientData { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	[CompilerGenerated]
	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3F8350 Offset: 0x3F7550 VA: 0x1803F8350
	public uint get_SnapshotId() { }

	[CompilerGenerated]
	// RVA: 0x3F84A0 Offset: 0x3F76A0 VA: 0x1803F84A0
	public void set_SnapshotId(uint value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public object get_ClientData() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_ClientData(object value) { }

	// RVA: 0x4B53F0 Offset: 0x4B45F0 VA: 0x1804B53F0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x4B5440 Offset: 0x4B4640 VA: 0x1804B5440
	internal void Set(ref SubmitSnapshotCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.ProgressionSnapshot
internal struct SubmitSnapshotCallbackInfoInternal : ICallbackInfoInternal, IGettable<SubmitSnapshotCallbackInfo>, ISettable<SubmitSnapshotCallbackInfo>, IDisposable // TypeDefIndex: 8888
{
	// Fields
	private Result m_ResultCode; // 0x0
	private uint m_SnapshotId; // 0x4
	private IntPtr m_ClientData; // 0x8

	// Properties
	public Result ResultCode { get; set; }
	public uint SnapshotId { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }

	// Methods

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	// RVA: 0x3F8350 Offset: 0x3F7550 VA: 0x1803F8350
	public uint get_SnapshotId() { }

	// RVA: 0x3F84A0 Offset: 0x3F76A0 VA: 0x1803F84A0
	public void set_SnapshotId(uint value) { }

	// RVA: 0x4B5320 Offset: 0x4B4520 VA: 0x1804B5320
	public object get_ClientData() { }

	// RVA: 0x4B5390 Offset: 0x4B4590 VA: 0x1804B5390
	public void set_ClientData(object value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x4B51D0 Offset: 0x4B43D0 VA: 0x1804B51D0 Slot: 6
	public void Set(ref SubmitSnapshotCallbackInfo other) { }

	// RVA: 0x4B5240 Offset: 0x4B4440 VA: 0x1804B5240 Slot: 7
	public void Set(ref Nullable<SubmitSnapshotCallbackInfo> other) { }

	// RVA: 0x4B5160 Offset: 0x4B4360 VA: 0x1804B5160 Slot: 8
	public void Dispose() { }

	// RVA: 0x4B51B0 Offset: 0x4B43B0 VA: 0x1804B51B0 Slot: 5
	public void Get(out SubmitSnapshotCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.ProgressionSnapshot
public struct SubmitSnapshotOptions // TypeDefIndex: 8889
{
	// Fields
	[CompilerGenerated]
	private uint <SnapshotId>k__BackingField; // 0x0

	// Properties
	public uint SnapshotId { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public uint get_SnapshotId() { }

	[CompilerGenerated]
	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_SnapshotId(uint value) { }
}

// Namespace: Epic.OnlineServices.ProgressionSnapshot
internal struct SubmitSnapshotOptionsInternal : ISettable<SubmitSnapshotOptions>, IDisposable // TypeDefIndex: 8890
{
	// Fields
	private int m_ApiVersion; // 0x0
	private uint m_SnapshotId; // 0x4

	// Properties
	public uint SnapshotId { set; }

	// Methods

	// RVA: 0x3F84A0 Offset: 0x3F76A0 VA: 0x1803F84A0
	public void set_SnapshotId(uint value) { }

	// RVA: 0x40B2E0 Offset: 0x40A4E0 VA: 0x18040B2E0 Slot: 4
	public void Set(ref SubmitSnapshotOptions other) { }

	// RVA: 0x4B54C0 Offset: 0x4B46C0 VA: 0x1804B54C0 Slot: 5
	public void Set(ref Nullable<SubmitSnapshotOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Presence
public struct AddNotifyJoinGameAcceptedOptions // TypeDefIndex: 8891
{}

// Namespace: Epic.OnlineServices.Presence
internal struct AddNotifyJoinGameAcceptedOptionsInternal : ISettable<AddNotifyJoinGameAcceptedOptions>, IDisposable // TypeDefIndex: 8892
{
	// Fields
	private int m_ApiVersion; // 0x0

	// Methods

	// RVA: 0x441C60 Offset: 0x440E60 VA: 0x180441C60 Slot: 4
	public void Set(ref AddNotifyJoinGameAcceptedOptions other) { }

	// RVA: 0x4A1900 Offset: 0x4A0B00 VA: 0x1804A1900 Slot: 5
	public void Set(ref Nullable<AddNotifyJoinGameAcceptedOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Presence
public struct AddNotifyOnPresenceChangedOptions // TypeDefIndex: 8893
{}

// Namespace: Epic.OnlineServices.Presence
internal struct AddNotifyOnPresenceChangedOptionsInternal : ISettable<AddNotifyOnPresenceChangedOptions>, IDisposable // TypeDefIndex: 8894
{
	// Fields
	private int m_ApiVersion; // 0x0

	// Methods

	// RVA: 0x3F98A0 Offset: 0x3F8AA0 VA: 0x1803F98A0 Slot: 4
	public void Set(ref AddNotifyOnPresenceChangedOptions other) { }

	// RVA: 0x4A1950 Offset: 0x4A0B50 VA: 0x1804A1950 Slot: 5
	public void Set(ref Nullable<AddNotifyOnPresenceChangedOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Presence
public struct CopyPresenceOptions // TypeDefIndex: 8895
{
	// Fields
	[CompilerGenerated]
	private EpicAccountId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private EpicAccountId <TargetUserId>k__BackingField; // 0x8

	// Properties
	public EpicAccountId LocalUserId { get; set; }
	public EpicAccountId TargetUserId { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public EpicAccountId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_LocalUserId(EpicAccountId value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public EpicAccountId get_TargetUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_TargetUserId(EpicAccountId value) { }
}

// Namespace: Epic.OnlineServices.Presence
internal struct CopyPresenceOptionsInternal : ISettable<CopyPresenceOptions>, IDisposable // TypeDefIndex: 8896
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_TargetUserId; // 0x10

	// Properties
	public EpicAccountId LocalUserId { set; }
	public EpicAccountId TargetUserId { set; }

	// Methods

	// RVA: 0x4A3EB0 Offset: 0x4A30B0 VA: 0x1804A3EB0
	public void set_LocalUserId(EpicAccountId value) { }

	// RVA: 0x4A3F10 Offset: 0x4A3110 VA: 0x1804A3F10
	public void set_TargetUserId(EpicAccountId value) { }

	// RVA: 0x4A3CF0 Offset: 0x4A2EF0 VA: 0x1804A3CF0 Slot: 4
	public void Set(ref CopyPresenceOptions other) { }

	// RVA: 0x4A3DB0 Offset: 0x4A2FB0 VA: 0x1804A3DB0 Slot: 5
	public void Set(ref Nullable<CopyPresenceOptions> other) { }

	// RVA: 0x4A3C90 Offset: 0x4A2E90 VA: 0x1804A3C90 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Presence
public struct CreatePresenceModificationOptions // TypeDefIndex: 8897
{
	// Fields
	[CompilerGenerated]
	private EpicAccountId <LocalUserId>k__BackingField; // 0x0

	// Properties
	public EpicAccountId LocalUserId { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public EpicAccountId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_LocalUserId(EpicAccountId value) { }
}

// Namespace: Epic.OnlineServices.Presence
internal struct CreatePresenceModificationOptionsInternal : ISettable<CreatePresenceModificationOptions>, IDisposable // TypeDefIndex: 8898
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8

	// Properties
	public EpicAccountId LocalUserId { set; }

	// Methods

	// RVA: 0x4A40C0 Offset: 0x4A32C0 VA: 0x1804A40C0
	public void set_LocalUserId(EpicAccountId value) { }

	// RVA: 0x4A3FC0 Offset: 0x4A31C0 VA: 0x1804A3FC0 Slot: 4
	public void Set(ref CreatePresenceModificationOptions other) { }

	// RVA: 0x4A4020 Offset: 0x4A3220 VA: 0x1804A4020 Slot: 5
	public void Set(ref Nullable<CreatePresenceModificationOptions> other) { }

	// RVA: 0x4A3F70 Offset: 0x4A3170 VA: 0x1804A3F70 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Presence
public struct DataRecord // TypeDefIndex: 8899
{
	// Fields
	[CompilerGenerated]
	private Utf8String <Key>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <Value>k__BackingField; // 0x8

	// Properties
	public Utf8String Key { get; set; }
	public Utf8String Value { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Utf8String get_Key() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_Key(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public Utf8String get_Value() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_Value(Utf8String value) { }

	// RVA: 0x4A4500 Offset: 0x4A3700 VA: 0x1804A4500
	internal void Set(ref DataRecordInternal other) { }
}

// Namespace: Epic.OnlineServices.Presence
internal struct DataRecordInternal : IGettable<DataRecord>, ISettable<DataRecord>, IDisposable // TypeDefIndex: 8900
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_Key; // 0x8
	private IntPtr m_Value; // 0x10

	// Properties
	public Utf8String Key { get; set; }
	public Utf8String Value { get; set; }

	// Methods

	// RVA: 0x4A4360 Offset: 0x4A3560 VA: 0x1804A4360
	public Utf8String get_Key() { }

	// RVA: 0x4A4440 Offset: 0x4A3640 VA: 0x1804A4440
	public void set_Key(Utf8String value) { }

	// RVA: 0x4A43D0 Offset: 0x4A35D0 VA: 0x1804A43D0
	public Utf8String get_Value() { }

	// RVA: 0x4A44A0 Offset: 0x4A36A0 VA: 0x1804A44A0
	public void set_Value(Utf8String value) { }

	// RVA: 0x4A42A0 Offset: 0x4A34A0 VA: 0x1804A42A0 Slot: 5
	public void Set(ref DataRecord other) { }

	// RVA: 0x4A41A0 Offset: 0x4A33A0 VA: 0x1804A41A0 Slot: 6
	public void Set(ref Nullable<DataRecord> other) { }

	// RVA: 0x4A4120 Offset: 0x4A3320 VA: 0x1804A4120 Slot: 7
	public void Dispose() { }

	// RVA: 0x4A4180 Offset: 0x4A3380 VA: 0x1804A4180 Slot: 4
	public void Get(out DataRecord output) { }
}

// Namespace: Epic.OnlineServices.Presence
public struct GetJoinInfoOptions // TypeDefIndex: 8901
{
	// Fields
	[CompilerGenerated]
	private EpicAccountId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private EpicAccountId <TargetUserId>k__BackingField; // 0x8

	// Properties
	public EpicAccountId LocalUserId { get; set; }
	public EpicAccountId TargetUserId { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public EpicAccountId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_LocalUserId(EpicAccountId value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public EpicAccountId get_TargetUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_TargetUserId(EpicAccountId value) { }
}

// Namespace: Epic.OnlineServices.Presence
internal struct GetJoinInfoOptionsInternal : ISettable<GetJoinInfoOptions>, IDisposable // TypeDefIndex: 8902
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_TargetUserId; // 0x10

	// Properties
	public EpicAccountId LocalUserId { set; }
	public EpicAccountId TargetUserId { set; }

	// Methods

	// RVA: 0x4A7570 Offset: 0x4A6770 VA: 0x1804A7570
	public void set_LocalUserId(EpicAccountId value) { }

	// RVA: 0x4A75D0 Offset: 0x4A67D0 VA: 0x1804A75D0
	public void set_TargetUserId(EpicAccountId value) { }

	// RVA: 0x4A74B0 Offset: 0x4A66B0 VA: 0x1804A74B0 Slot: 4
	public void Set(ref GetJoinInfoOptions other) { }

	// RVA: 0x4A73B0 Offset: 0x4A65B0 VA: 0x1804A73B0 Slot: 5
	public void Set(ref Nullable<GetJoinInfoOptions> other) { }

	// RVA: 0x4A7350 Offset: 0x4A6550 VA: 0x1804A7350 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Presence
public struct HasPresenceOptions // TypeDefIndex: 8903
{
	// Fields
	[CompilerGenerated]
	private EpicAccountId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private EpicAccountId <TargetUserId>k__BackingField; // 0x8

	// Properties
	public EpicAccountId LocalUserId { get; set; }
	public EpicAccountId TargetUserId { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public EpicAccountId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_LocalUserId(EpicAccountId value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public EpicAccountId get_TargetUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_TargetUserId(EpicAccountId value) { }
}

// Namespace: Epic.OnlineServices.Presence
internal struct HasPresenceOptionsInternal : ISettable<HasPresenceOptions>, IDisposable // TypeDefIndex: 8904
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_TargetUserId; // 0x10

	// Properties
	public EpicAccountId LocalUserId { set; }
	public EpicAccountId TargetUserId { set; }

	// Methods

	// RVA: 0x4A7990 Offset: 0x4A6B90 VA: 0x1804A7990
	public void set_LocalUserId(EpicAccountId value) { }

	// RVA: 0x4A79F0 Offset: 0x4A6BF0 VA: 0x1804A79F0
	public void set_TargetUserId(EpicAccountId value) { }

	// RVA: 0x4A77D0 Offset: 0x4A69D0 VA: 0x1804A77D0 Slot: 4
	public void Set(ref HasPresenceOptions other) { }

	// RVA: 0x4A7890 Offset: 0x4A6A90 VA: 0x1804A7890 Slot: 5
	public void Set(ref Nullable<HasPresenceOptions> other) { }

	// RVA: 0x4A7770 Offset: 0x4A6970 VA: 0x1804A7770 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Presence
public struct Info // TypeDefIndex: 8905
{
	// Fields
	[CompilerGenerated]
	private Status <Status>k__BackingField; // 0x0
	[CompilerGenerated]
	private EpicAccountId <UserId>k__BackingField; // 0x8
	[CompilerGenerated]
	private Utf8String <ProductId>k__BackingField; // 0x10
	[CompilerGenerated]
	private Utf8String <ProductVersion>k__BackingField; // 0x18
	[CompilerGenerated]
	private Utf8String <Platform>k__BackingField; // 0x20
	[CompilerGenerated]
	private Utf8String <RichText>k__BackingField; // 0x28
	[CompilerGenerated]
	private DataRecord[] <Records>k__BackingField; // 0x30
	[CompilerGenerated]
	private Utf8String <ProductName>k__BackingField; // 0x38
	[CompilerGenerated]
	private Utf8String <IntegratedPlatform>k__BackingField; // 0x40

	// Properties
	public Status Status { get; set; }
	public EpicAccountId UserId { get; set; }
	public Utf8String ProductId { get; set; }
	public Utf8String ProductVersion { get; set; }
	public Utf8String Platform { get; set; }
	public Utf8String RichText { get; set; }
	public DataRecord[] Records { get; set; }
	public Utf8String ProductName { get; set; }
	public Utf8String IntegratedPlatform { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Status get_Status() { }

	[CompilerGenerated]
	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_Status(Status value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public EpicAccountId get_UserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_UserId(EpicAccountId value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Utf8String get_ProductId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_ProductId(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public Utf8String get_ProductVersion() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_ProductVersion(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public Utf8String get_Platform() { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_Platform(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public Utf8String get_RichText() { }

	[CompilerGenerated]
	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	public void set_RichText(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public DataRecord[] get_Records() { }

	[CompilerGenerated]
	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	public void set_Records(DataRecord[] value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public Utf8String get_ProductName() { }

	[CompilerGenerated]
	// RVA: 0x40EC50 Offset: 0x40DE50 VA: 0x18040EC50
	public void set_ProductName(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	public Utf8String get_IntegratedPlatform() { }

	[CompilerGenerated]
	// RVA: 0x415820 Offset: 0x414A20 VA: 0x180415820
	public void set_IntegratedPlatform(Utf8String value) { }

	// RVA: 0x4A8740 Offset: 0x4A7940 VA: 0x1804A8740
	internal void Set(ref InfoInternal other) { }
}

// Namespace: Epic.OnlineServices.Presence
internal struct InfoInternal : IGettable<Info>, ISettable<Info>, IDisposable // TypeDefIndex: 8906
{
	// Fields
	private int m_ApiVersion; // 0x0
	private Status m_Status; // 0x4
	private IntPtr m_UserId; // 0x8
	private IntPtr m_ProductId; // 0x10
	private IntPtr m_ProductVersion; // 0x18
	private IntPtr m_Platform; // 0x20
	private IntPtr m_RichText; // 0x28
	private int m_RecordsCount; // 0x30
	private IntPtr m_Records; // 0x38
	private IntPtr m_ProductName; // 0x40
	private IntPtr m_IntegratedPlatform; // 0x48

	// Properties
	public Status Status { get; set; }
	public EpicAccountId UserId { get; set; }
	public Utf8String ProductId { get; set; }
	public Utf8String ProductVersion { get; set; }
	public Utf8String Platform { get; set; }
	public Utf8String RichText { get; set; }
	public DataRecord[] Records { get; set; }
	public Utf8String ProductName { get; set; }
	public Utf8String IntegratedPlatform { get; set; }

	// Methods

	// RVA: 0x3F8350 Offset: 0x3F7550 VA: 0x1803F8350
	public Status get_Status() { }

	// RVA: 0x3F84A0 Offset: 0x3F76A0 VA: 0x1803F84A0
	public void set_Status(Status value) { }

	// RVA: 0x4A83B0 Offset: 0x4A75B0 VA: 0x1804A83B0
	public EpicAccountId get_UserId() { }

	// RVA: 0x4A86E0 Offset: 0x4A78E0 VA: 0x1804A86E0
	public void set_UserId(EpicAccountId value) { }

	// RVA: 0x4A8160 Offset: 0x4A7360 VA: 0x1804A8160
	public Utf8String get_ProductId() { }

	// RVA: 0x4A84F0 Offset: 0x4A76F0 VA: 0x1804A84F0
	public void set_ProductId(Utf8String value) { }

	// RVA: 0x4A8240 Offset: 0x4A7440 VA: 0x1804A8240
	public Utf8String get_ProductVersion() { }

	// RVA: 0x4A85B0 Offset: 0x4A77B0 VA: 0x1804A85B0
	public void set_ProductVersion(Utf8String value) { }

	// RVA: 0x4A80F0 Offset: 0x4A72F0 VA: 0x1804A80F0
	public Utf8String get_Platform() { }

	// RVA: 0x4A8490 Offset: 0x4A7690 VA: 0x1804A8490
	public void set_Platform(Utf8String value) { }

	// RVA: 0x4A8340 Offset: 0x4A7540 VA: 0x1804A8340
	public Utf8String get_RichText() { }

	// RVA: 0x4A8680 Offset: 0x4A7880 VA: 0x1804A8680
	public void set_RichText(Utf8String value) { }

	// RVA: 0x4A82B0 Offset: 0x4A74B0 VA: 0x1804A82B0
	public DataRecord[] get_Records() { }

	// RVA: 0x4A8610 Offset: 0x4A7810 VA: 0x1804A8610
	public void set_Records(DataRecord[] value) { }

	// RVA: 0x4A81D0 Offset: 0x4A73D0 VA: 0x1804A81D0
	public Utf8String get_ProductName() { }

	// RVA: 0x4A8550 Offset: 0x4A7750 VA: 0x1804A8550
	public void set_ProductName(Utf8String value) { }

	// RVA: 0x4A8080 Offset: 0x4A7280 VA: 0x1804A8080
	public Utf8String get_IntegratedPlatform() { }

	// RVA: 0x4A8430 Offset: 0x4A7630 VA: 0x1804A8430
	public void set_IntegratedPlatform(Utf8String value) { }

	// RVA: 0x4A7E10 Offset: 0x4A7010 VA: 0x1804A7E10 Slot: 5
	public void Set(ref Info other) { }

	// RVA: 0x4A7B20 Offset: 0x4A6D20 VA: 0x1804A7B20 Slot: 6
	public void Set(ref Nullable<Info> other) { }

	// RVA: 0x4A7A50 Offset: 0x4A6C50 VA: 0x1804A7A50 Slot: 7
	public void Dispose() { }

	// RVA: 0x4A7AF0 Offset: 0x4A6CF0 VA: 0x1804A7AF0 Slot: 4
	public void Get(out Info output) { }
}

// Namespace: Epic.OnlineServices.Presence
public struct JoinGameAcceptedCallbackInfo : ICallbackInfo // TypeDefIndex: 8907
{
	// Fields
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <JoinInfo>k__BackingField; // 0x8
	[CompilerGenerated]
	private EpicAccountId <LocalUserId>k__BackingField; // 0x10
	[CompilerGenerated]
	private EpicAccountId <TargetUserId>k__BackingField; // 0x18
	[CompilerGenerated]
	private ulong <UiEventId>k__BackingField; // 0x20

	// Properties
	public object ClientData { get; set; }
	public Utf8String JoinInfo { get; set; }
	public EpicAccountId LocalUserId { get; set; }
	public EpicAccountId TargetUserId { get; set; }
	public ulong UiEventId { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410 Slot: 4
	public object get_ClientData() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_ClientData(object value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public Utf8String get_JoinInfo() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_JoinInfo(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public EpicAccountId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_LocalUserId(EpicAccountId value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public EpicAccountId get_TargetUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_TargetUserId(EpicAccountId value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public ulong get_UiEventId() { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_UiEventId(ulong value) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x4A9100 Offset: 0x4A8300 VA: 0x1804A9100
	internal void Set(ref JoinGameAcceptedCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.Presence
internal struct JoinGameAcceptedCallbackInfoInternal : ICallbackInfoInternal, IGettable<JoinGameAcceptedCallbackInfo>, ISettable<JoinGameAcceptedCallbackInfo>, IDisposable // TypeDefIndex: 8908
{
	// Fields
	private IntPtr m_ClientData; // 0x0
	private IntPtr m_JoinInfo; // 0x8
	private IntPtr m_LocalUserId; // 0x10
	private IntPtr m_TargetUserId; // 0x18
	private ulong m_UiEventId; // 0x20

	// Properties
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public Utf8String JoinInfo { get; set; }
	public EpicAccountId LocalUserId { get; set; }
	public EpicAccountId TargetUserId { get; set; }
	public ulong UiEventId { get; set; }

	// Methods

	// RVA: 0x4A8DA0 Offset: 0x4A7FA0 VA: 0x1804A8DA0
	public object get_ClientData() { }

	// RVA: 0x4A8F80 Offset: 0x4A8180 VA: 0x1804A8F80
	public void set_ClientData(object value) { }

	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x4A8E10 Offset: 0x4A8010 VA: 0x1804A8E10
	public Utf8String get_JoinInfo() { }

	// RVA: 0x4A8FE0 Offset: 0x4A81E0 VA: 0x1804A8FE0
	public void set_JoinInfo(Utf8String value) { }

	// RVA: 0x4A8E80 Offset: 0x4A8080 VA: 0x1804A8E80
	public EpicAccountId get_LocalUserId() { }

	// RVA: 0x4A9040 Offset: 0x4A8240 VA: 0x1804A9040
	public void set_LocalUserId(EpicAccountId value) { }

	// RVA: 0x4A8F00 Offset: 0x4A8100 VA: 0x1804A8F00
	public EpicAccountId get_TargetUserId() { }

	// RVA: 0x4A90A0 Offset: 0x4A82A0 VA: 0x1804A90A0
	public void set_TargetUserId(EpicAccountId value) { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public ulong get_UiEventId() { }

	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_UiEventId(ulong value) { }

	// RVA: 0x4A8AA0 Offset: 0x4A7CA0 VA: 0x1804A8AA0 Slot: 6
	public void Set(ref JoinGameAcceptedCallbackInfo other) { }

	// RVA: 0x4A8BE0 Offset: 0x4A7DE0 VA: 0x1804A8BE0 Slot: 7
	public void Set(ref Nullable<JoinGameAcceptedCallbackInfo> other) { }

	// RVA: 0x4A8A00 Offset: 0x4A7C00 VA: 0x1804A8A00 Slot: 8
	public void Dispose() { }

	// RVA: 0x4A8A70 Offset: 0x4A7C70 VA: 0x1804A8A70 Slot: 5
	public void Get(out JoinGameAcceptedCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.Presence
public sealed class OnJoinGameAcceptedCallback : MulticastDelegate // TypeDefIndex: 8909
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref JoinGameAcceptedCallbackInfo data) { }

	// RVA: 0x4AA820 Offset: 0x4A9A20 VA: 0x1804AA820 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref JoinGameAcceptedCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref JoinGameAcceptedCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Presence
[UnmanagedFunctionPointer(2)]
internal sealed class OnJoinGameAcceptedCallbackInternal : MulticastDelegate // TypeDefIndex: 8910
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref JoinGameAcceptedCallbackInfoInternal data) { }

	// RVA: 0x4AA790 Offset: 0x4A9990 VA: 0x1804AA790 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref JoinGameAcceptedCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref JoinGameAcceptedCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Presence
public sealed class OnPresenceChangedCallback : MulticastDelegate // TypeDefIndex: 8911
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref PresenceChangedCallbackInfo data) { }

	// RVA: 0x4ABD00 Offset: 0x4AAF00 VA: 0x1804ABD00 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref PresenceChangedCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref PresenceChangedCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Presence
[UnmanagedFunctionPointer(2)]
internal sealed class OnPresenceChangedCallbackInternal : MulticastDelegate // TypeDefIndex: 8912
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref PresenceChangedCallbackInfoInternal data) { }

	// RVA: 0x4ABC70 Offset: 0x4AAE70 VA: 0x1804ABC70 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref PresenceChangedCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref PresenceChangedCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Presence
public sealed class OnQueryPresenceCompleteCallback : MulticastDelegate // TypeDefIndex: 8913
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref QueryPresenceCallbackInfo data) { }

	// RVA: 0x4AC180 Offset: 0x4AB380 VA: 0x1804AC180 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref QueryPresenceCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref QueryPresenceCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Presence
[UnmanagedFunctionPointer(2)]
internal sealed class OnQueryPresenceCompleteCallbackInternal : MulticastDelegate // TypeDefIndex: 8914
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref QueryPresenceCallbackInfoInternal data) { }

	// RVA: 0x4AC0F0 Offset: 0x4AB2F0 VA: 0x1804AC0F0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref QueryPresenceCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref QueryPresenceCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Presence
public struct PresenceChangedCallbackInfo : ICallbackInfo // TypeDefIndex: 8915
{
	// Fields
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x0
	[CompilerGenerated]
	private EpicAccountId <LocalUserId>k__BackingField; // 0x8
	[CompilerGenerated]
	private EpicAccountId <PresenceUserId>k__BackingField; // 0x10

	// Properties
	public object ClientData { get; set; }
	public EpicAccountId LocalUserId { get; set; }
	public EpicAccountId PresenceUserId { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410 Slot: 4
	public object get_ClientData() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_ClientData(object value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public EpicAccountId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_LocalUserId(EpicAccountId value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public EpicAccountId get_PresenceUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_PresenceUserId(EpicAccountId value) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x4AF460 Offset: 0x4AE660 VA: 0x1804AF460
	internal void Set(ref PresenceChangedCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.Presence
internal struct PresenceChangedCallbackInfoInternal : ICallbackInfoInternal, IGettable<PresenceChangedCallbackInfo>, ISettable<PresenceChangedCallbackInfo>, IDisposable // TypeDefIndex: 8916
{
	// Fields
	private IntPtr m_ClientData; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_PresenceUserId; // 0x10

	// Properties
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public EpicAccountId LocalUserId { get; set; }
	public EpicAccountId PresenceUserId { get; set; }

	// Methods

	// RVA: 0x4AF1D0 Offset: 0x4AE3D0 VA: 0x1804AF1D0
	public object get_ClientData() { }

	// RVA: 0x4AF340 Offset: 0x4AE540 VA: 0x1804AF340
	public void set_ClientData(object value) { }

	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x4AF240 Offset: 0x4AE440 VA: 0x1804AF240
	public EpicAccountId get_LocalUserId() { }

	// RVA: 0x4AF3A0 Offset: 0x4AE5A0 VA: 0x1804AF3A0
	public void set_LocalUserId(EpicAccountId value) { }

	// RVA: 0x4AF2C0 Offset: 0x4AE4C0 VA: 0x1804AF2C0
	public EpicAccountId get_PresenceUserId() { }

	// RVA: 0x4AF400 Offset: 0x4AE600 VA: 0x1804AF400
	public void set_PresenceUserId(EpicAccountId value) { }

	// RVA: 0x4AEF90 Offset: 0x4AE190 VA: 0x1804AEF90 Slot: 6
	public void Set(ref PresenceChangedCallbackInfo other) { }

	// RVA: 0x4AF080 Offset: 0x4AE280 VA: 0x1804AF080 Slot: 7
	public void Set(ref Nullable<PresenceChangedCallbackInfo> other) { }

	// RVA: 0x4AEF10 Offset: 0x4AE110 VA: 0x1804AEF10 Slot: 8
	public void Dispose() { }

	// RVA: 0x4AEF70 Offset: 0x4AE170 VA: 0x1804AEF70 Slot: 5
	public void Get(out PresenceChangedCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.Presence
public sealed class PresenceInterface : Handle // TypeDefIndex: 8917
{
	// Fields
	public const int AddnotifyjoingameacceptedApiLatest = 2;
	public const int AddnotifyonpresencechangedApiLatest = 1;
	public const int CopypresenceApiLatest = 3;
	public const int CreatepresencemodificationApiLatest = 1;
	public const int DataMaxKeyLength = 64;
	public const int DataMaxKeys = 32;
	public const int DataMaxValueLength = 255;
	public const int DatarecordApiLatest = 1;
	public const int DeletedataApiLatest = 1;
	public const int GetjoininfoApiLatest = 1;
	public const int HaspresenceApiLatest = 1;
	public const int InfoApiLatest = 3;
	public static readonly Utf8String KeyPlatformPresence; // 0x0
	public const int QuerypresenceApiLatest = 1;
	public const int RichTextMaxValueLength = 255;
	public const int SetdataApiLatest = 1;
	public const int SetpresenceApiLatest = 1;
	public const int SetrawrichtextApiLatest = 1;
	public const int SetstatusApiLatest = 1;

	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }

	// RVA: 0x40BDB0 Offset: 0x40AFB0 VA: 0x18040BDB0
	public void .ctor(IntPtr innerHandle) { }

	// RVA: 0x4AF500 Offset: 0x4AE700 VA: 0x1804AF500
	public ulong AddNotifyJoinGameAccepted(ref AddNotifyJoinGameAcceptedOptions options, object clientData, OnJoinGameAcceptedCallback notificationFn) { }

	// RVA: 0x4AF6B0 Offset: 0x4AE8B0 VA: 0x1804AF6B0
	public ulong AddNotifyOnPresenceChanged(ref AddNotifyOnPresenceChangedOptions options, object clientData, OnPresenceChangedCallback notificationHandler) { }

	// RVA: 0x4AF860 Offset: 0x4AEA60 VA: 0x1804AF860
	public Result CopyPresence(ref CopyPresenceOptions options, out Nullable<Info> outPresence) { }

	// RVA: 0x4AF960 Offset: 0x4AEB60 VA: 0x1804AF960
	public Result CreatePresenceModification(ref CreatePresenceModificationOptions options, out PresenceModification outPresenceModificationHandle) { }

	// RVA: 0x4AFA70 Offset: 0x4AEC70 VA: 0x1804AFA70
	public Result GetJoinInfo(ref GetJoinInfoOptions options, out Utf8String outBuffer) { }

	// RVA: 0x4AFB60 Offset: 0x4AED60 VA: 0x1804AFB60
	public bool HasPresence(ref HasPresenceOptions options) { }

	// RVA: 0x4AFE30 Offset: 0x4AF030 VA: 0x1804AFE30
	public void QueryPresence(ref QueryPresenceOptions options, object clientData, OnQueryPresenceCompleteCallback completionDelegate) { }

	// RVA: 0x4AFFE0 Offset: 0x4AF1E0 VA: 0x1804AFFE0
	public void RemoveNotifyJoinGameAccepted(ulong inId) { }

	// RVA: 0x4B0050 Offset: 0x4AF250 VA: 0x1804B0050
	public void RemoveNotifyOnPresenceChanged(ulong notificationId) { }

	// RVA: 0x4B0170 Offset: 0x4AF370 VA: 0x1804B0170
	public void SetPresence(ref SetPresenceOptions options, object clientData, SetPresenceCompleteCallback completionDelegate) { }

	[MonoPInvokeCallback(typeof(OnJoinGameAcceptedCallbackInternal))]
	// RVA: 0x4AFC20 Offset: 0x4AEE20 VA: 0x1804AFC20
	internal static void OnJoinGameAcceptedCallbackInternalImplementation(ref JoinGameAcceptedCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnPresenceChangedCallbackInternal))]
	// RVA: 0x4AFCD0 Offset: 0x4AEED0 VA: 0x1804AFCD0
	internal static void OnPresenceChangedCallbackInternalImplementation(ref PresenceChangedCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnQueryPresenceCompleteCallbackInternal))]
	// RVA: 0x4AFD80 Offset: 0x4AEF80 VA: 0x1804AFD80
	internal static void OnQueryPresenceCompleteCallbackInternalImplementation(ref QueryPresenceCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(SetPresenceCompleteCallbackInternal))]
	// RVA: 0x4B00C0 Offset: 0x4AF2C0 VA: 0x1804B00C0
	internal static void SetPresenceCompleteCallbackInternalImplementation(ref SetPresenceCallbackInfoInternal data) { }

	// RVA: 0x4B0320 Offset: 0x4AF520 VA: 0x1804B0320
	private static void .cctor() { }
}

// Namespace: Epic.OnlineServices.Presence
public sealed class PresenceModification : Handle // TypeDefIndex: 8918
{
	// Fields
	public const int PresencemodificationDatarecordidApiLatest = 1;
	public const int PresencemodificationDeletedataApiLatest = 1;
	public const int PresencemodificationJoininfoMaxLength = 255;
	public const int PresencemodificationSetdataApiLatest = 1;
	public const int PresencemodificationSetjoininfoApiLatest = 1;
	public const int PresencemodificationSetrawrichtextApiLatest = 1;
	public const int PresencemodificationSetstatusApiLatest = 1;

	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }

	// RVA: 0x40BDB0 Offset: 0x40AFB0 VA: 0x18040BDB0
	public void .ctor(IntPtr innerHandle) { }

	// RVA: 0x4B0D80 Offset: 0x4AFF80 VA: 0x1804B0D80
	public Result DeleteData(ref PresenceModificationDeleteDataOptions options) { }

	// RVA: 0x4B0E70 Offset: 0x4B0070 VA: 0x1804B0E70
	public void Release() { }

	// RVA: 0x4B0E80 Offset: 0x4B0080 VA: 0x1804B0E80
	public Result SetData(ref PresenceModificationSetDataOptions options) { }

	// RVA: 0x4B0F70 Offset: 0x4B0170 VA: 0x1804B0F70
	public Result SetJoinInfo(ref PresenceModificationSetJoinInfoOptions options) { }

	// RVA: 0x4B1050 Offset: 0x4B0250 VA: 0x1804B1050
	public Result SetRawRichText(ref PresenceModificationSetRawRichTextOptions options) { }

	// RVA: 0x4B1130 Offset: 0x4B0330 VA: 0x1804B1130
	public Result SetStatus(ref PresenceModificationSetStatusOptions options) { }
}

// Namespace: Epic.OnlineServices.Presence
public struct PresenceModificationDataRecordId // TypeDefIndex: 8919
{
	// Fields
	[CompilerGenerated]
	private Utf8String <Key>k__BackingField; // 0x0

	// Properties
	public Utf8String Key { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Utf8String get_Key() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_Key(Utf8String value) { }

	// RVA: 0x4B05E0 Offset: 0x4AF7E0 VA: 0x1804B05E0
	internal void Set(ref PresenceModificationDataRecordIdInternal other) { }
}

// Namespace: Epic.OnlineServices.Presence
internal struct PresenceModificationDataRecordIdInternal : IGettable<PresenceModificationDataRecordId>, ISettable<PresenceModificationDataRecordId>, IDisposable // TypeDefIndex: 8920
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_Key; // 0x8

	// Properties
	public Utf8String Key { get; set; }

	// Methods

	// RVA: 0x4B0510 Offset: 0x4AF710 VA: 0x1804B0510
	public Utf8String get_Key() { }

	// RVA: 0x4B0580 Offset: 0x4AF780 VA: 0x1804B0580
	public void set_Key(Utf8String value) { }

	// RVA: 0x4B0410 Offset: 0x4AF610 VA: 0x1804B0410 Slot: 5
	public void Set(ref PresenceModificationDataRecordId other) { }

	// RVA: 0x4B0470 Offset: 0x4AF670 VA: 0x1804B0470 Slot: 6
	public void Set(ref Nullable<PresenceModificationDataRecordId> other) { }

	// RVA: 0x4B03A0 Offset: 0x4AF5A0 VA: 0x1804B03A0 Slot: 7
	public void Dispose() { }

	// RVA: 0x4B03F0 Offset: 0x4AF5F0 VA: 0x1804B03F0 Slot: 4
	public void Get(out PresenceModificationDataRecordId output) { }
}

// Namespace: Epic.OnlineServices.Presence
public struct PresenceModificationDeleteDataOptions // TypeDefIndex: 8921
{
	// Fields
	[CompilerGenerated]
	private PresenceModificationDataRecordId[] <Records>k__BackingField; // 0x0

	// Properties
	public PresenceModificationDataRecordId[] Records { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public PresenceModificationDataRecordId[] get_Records() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_Records(PresenceModificationDataRecordId[] value) { }
}

// Namespace: Epic.OnlineServices.Presence
internal struct PresenceModificationDeleteDataOptionsInternal : ISettable<PresenceModificationDeleteDataOptions>, IDisposable // TypeDefIndex: 8922
{
	// Fields
	private int m_ApiVersion; // 0x0
	private int m_RecordsCount; // 0x4
	private IntPtr m_Records; // 0x8

	// Properties
	public PresenceModificationDataRecordId[] Records { set; }

	// Methods

	// RVA: 0x4B07A0 Offset: 0x4AF9A0 VA: 0x1804B07A0
	public void set_Records(PresenceModificationDataRecordId[] value) { }

	// RVA: 0x4B06B0 Offset: 0x4AF8B0 VA: 0x1804B06B0 Slot: 4
	public void Set(ref PresenceModificationDeleteDataOptions other) { }

	// RVA: 0x4B0730 Offset: 0x4AF930 VA: 0x1804B0730 Slot: 5
	public void Set(ref Nullable<PresenceModificationDeleteDataOptions> other) { }

	// RVA: 0x4B0660 Offset: 0x4AF860 VA: 0x1804B0660 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Presence
public struct PresenceModificationSetDataOptions // TypeDefIndex: 8923
{
	// Fields
	[CompilerGenerated]
	private DataRecord[] <Records>k__BackingField; // 0x0

	// Properties
	public DataRecord[] Records { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public DataRecord[] get_Records() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_Records(DataRecord[] value) { }
}

// Namespace: Epic.OnlineServices.Presence
internal struct PresenceModificationSetDataOptionsInternal : ISettable<PresenceModificationSetDataOptions>, IDisposable // TypeDefIndex: 8924
{
	// Fields
	private int m_ApiVersion; // 0x0
	private int m_RecordsCount; // 0x4
	private IntPtr m_Records; // 0x8

	// Properties
	public DataRecord[] Records { set; }

	// Methods

	// RVA: 0x4B0950 Offset: 0x4AFB50 VA: 0x1804B0950
	public void set_Records(DataRecord[] value) { }

	// RVA: 0x4B0860 Offset: 0x4AFA60 VA: 0x1804B0860 Slot: 4
	public void Set(ref PresenceModificationSetDataOptions other) { }

	// RVA: 0x4B08E0 Offset: 0x4AFAE0 VA: 0x1804B08E0 Slot: 5
	public void Set(ref Nullable<PresenceModificationSetDataOptions> other) { }

	// RVA: 0x4B0810 Offset: 0x4AFA10 VA: 0x1804B0810 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Presence
public struct PresenceModificationSetJoinInfoOptions // TypeDefIndex: 8925
{
	// Fields
	[CompilerGenerated]
	private Utf8String <JoinInfo>k__BackingField; // 0x0

	// Properties
	public Utf8String JoinInfo { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Utf8String get_JoinInfo() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_JoinInfo(Utf8String value) { }
}

// Namespace: Epic.OnlineServices.Presence
internal struct PresenceModificationSetJoinInfoOptionsInternal : ISettable<PresenceModificationSetJoinInfoOptions>, IDisposable // TypeDefIndex: 8926
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_JoinInfo; // 0x8

	// Properties
	public Utf8String JoinInfo { set; }

	// Methods

	// RVA: 0x4B0B10 Offset: 0x4AFD10 VA: 0x1804B0B10
	public void set_JoinInfo(Utf8String value) { }

	// RVA: 0x4B0A10 Offset: 0x4AFC10 VA: 0x1804B0A10 Slot: 4
	public void Set(ref PresenceModificationSetJoinInfoOptions other) { }

	// RVA: 0x4B0A70 Offset: 0x4AFC70 VA: 0x1804B0A70 Slot: 5
	public void Set(ref Nullable<PresenceModificationSetJoinInfoOptions> other) { }

	// RVA: 0x4B09C0 Offset: 0x4AFBC0 VA: 0x1804B09C0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Presence
public struct PresenceModificationSetRawRichTextOptions // TypeDefIndex: 8927
{
	// Fields
	[CompilerGenerated]
	private Utf8String <RichText>k__BackingField; // 0x0

	// Properties
	public Utf8String RichText { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Utf8String get_RichText() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_RichText(Utf8String value) { }
}

// Namespace: Epic.OnlineServices.Presence
internal struct PresenceModificationSetRawRichTextOptionsInternal : ISettable<PresenceModificationSetRawRichTextOptions>, IDisposable // TypeDefIndex: 8928
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_RichText; // 0x8

	// Properties
	public Utf8String RichText { set; }

	// Methods

	// RVA: 0x4B0CC0 Offset: 0x4AFEC0 VA: 0x1804B0CC0
	public void set_RichText(Utf8String value) { }

	// RVA: 0x4B0BC0 Offset: 0x4AFDC0 VA: 0x1804B0BC0 Slot: 4
	public void Set(ref PresenceModificationSetRawRichTextOptions other) { }

	// RVA: 0x4B0C20 Offset: 0x4AFE20 VA: 0x1804B0C20 Slot: 5
	public void Set(ref Nullable<PresenceModificationSetRawRichTextOptions> other) { }

	// RVA: 0x4B0B70 Offset: 0x4AFD70 VA: 0x1804B0B70 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Presence
public struct PresenceModificationSetStatusOptions // TypeDefIndex: 8929
{
	// Fields
	[CompilerGenerated]
	private Status <Status>k__BackingField; // 0x0

	// Properties
	public Status Status { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Status get_Status() { }

	[CompilerGenerated]
	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_Status(Status value) { }
}

// Namespace: Epic.OnlineServices.Presence
internal struct PresenceModificationSetStatusOptionsInternal : ISettable<PresenceModificationSetStatusOptions>, IDisposable // TypeDefIndex: 8930
{
	// Fields
	private int m_ApiVersion; // 0x0
	private Status m_Status; // 0x4

	// Properties
	public Status Status { set; }

	// Methods

	// RVA: 0x3F84A0 Offset: 0x3F76A0 VA: 0x1803F84A0
	public void set_Status(Status value) { }

	// RVA: 0x40B2E0 Offset: 0x40A4E0 VA: 0x18040B2E0 Slot: 4
	public void Set(ref PresenceModificationSetStatusOptions other) { }

	// RVA: 0x4B0D20 Offset: 0x4AFF20 VA: 0x1804B0D20 Slot: 5
	public void Set(ref Nullable<PresenceModificationSetStatusOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Presence
public struct QueryPresenceCallbackInfo : ICallbackInfo // TypeDefIndex: 8931
{
	// Fields
	[CompilerGenerated]
	private Result <ResultCode>k__BackingField; // 0x0
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x8
	[CompilerGenerated]
	private EpicAccountId <LocalUserId>k__BackingField; // 0x10
	[CompilerGenerated]
	private EpicAccountId <TargetUserId>k__BackingField; // 0x18

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public EpicAccountId LocalUserId { get; set; }
	public EpicAccountId TargetUserId { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	[CompilerGenerated]
	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public object get_ClientData() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_ClientData(object value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public EpicAccountId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_LocalUserId(EpicAccountId value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public EpicAccountId get_TargetUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_TargetUserId(EpicAccountId value) { }

	// RVA: 0x4B2CD0 Offset: 0x4B1ED0 VA: 0x1804B2CD0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x4B2D20 Offset: 0x4B1F20 VA: 0x1804B2D20
	internal void Set(ref QueryPresenceCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.Presence
internal struct QueryPresenceCallbackInfoInternal : ICallbackInfoInternal, IGettable<QueryPresenceCallbackInfo>, ISettable<QueryPresenceCallbackInfo>, IDisposable // TypeDefIndex: 8932
{
	// Fields
	private Result m_ResultCode; // 0x0
	private IntPtr m_ClientData; // 0x8
	private IntPtr m_LocalUserId; // 0x10
	private IntPtr m_TargetUserId; // 0x18

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public EpicAccountId LocalUserId { get; set; }
	public EpicAccountId TargetUserId { get; set; }

	// Methods

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	// RVA: 0x4B2A40 Offset: 0x4B1C40 VA: 0x1804B2A40
	public object get_ClientData() { }

	// RVA: 0x4B2BB0 Offset: 0x4B1DB0 VA: 0x1804B2BB0
	public void set_ClientData(object value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x4B2AB0 Offset: 0x4B1CB0 VA: 0x1804B2AB0
	public EpicAccountId get_LocalUserId() { }

	// RVA: 0x4B2C10 Offset: 0x4B1E10 VA: 0x1804B2C10
	public void set_LocalUserId(EpicAccountId value) { }

	// RVA: 0x4B2B30 Offset: 0x4B1D30 VA: 0x1804B2B30
	public EpicAccountId get_TargetUserId() { }

	// RVA: 0x4B2C70 Offset: 0x4B1E70 VA: 0x1804B2C70
	public void set_TargetUserId(EpicAccountId value) { }

	// RVA: 0x4B27D0 Offset: 0x4B19D0 VA: 0x1804B27D0 Slot: 6
	public void Set(ref QueryPresenceCallbackInfo other) { }

	// RVA: 0x4B28D0 Offset: 0x4B1AD0 VA: 0x1804B28D0 Slot: 7
	public void Set(ref Nullable<QueryPresenceCallbackInfo> other) { }

	// RVA: 0x4B2750 Offset: 0x4B1950 VA: 0x1804B2750 Slot: 8
	public void Dispose() { }

	// RVA: 0x4B27B0 Offset: 0x4B19B0 VA: 0x1804B27B0 Slot: 5
	public void Get(out QueryPresenceCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.Presence
public struct QueryPresenceOptions // TypeDefIndex: 8933
{
	// Fields
	[CompilerGenerated]
	private EpicAccountId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private EpicAccountId <TargetUserId>k__BackingField; // 0x8

	// Properties
	public EpicAccountId LocalUserId { get; set; }
	public EpicAccountId TargetUserId { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public EpicAccountId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_LocalUserId(EpicAccountId value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public EpicAccountId get_TargetUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_TargetUserId(EpicAccountId value) { }
}

// Namespace: Epic.OnlineServices.Presence
internal struct QueryPresenceOptionsInternal : ISettable<QueryPresenceOptions>, IDisposable // TypeDefIndex: 8934
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_TargetUserId; // 0x10

	// Properties
	public EpicAccountId LocalUserId { set; }
	public EpicAccountId TargetUserId { set; }

	// Methods

	// RVA: 0x4B2FE0 Offset: 0x4B21E0 VA: 0x1804B2FE0
	public void set_LocalUserId(EpicAccountId value) { }

	// RVA: 0x4B3040 Offset: 0x4B2240 VA: 0x1804B3040
	public void set_TargetUserId(EpicAccountId value) { }

	// RVA: 0x4B2F20 Offset: 0x4B2120 VA: 0x1804B2F20 Slot: 4
	public void Set(ref QueryPresenceOptions other) { }

	// RVA: 0x4B2E20 Offset: 0x4B2020 VA: 0x1804B2E20 Slot: 5
	public void Set(ref Nullable<QueryPresenceOptions> other) { }

	// RVA: 0x4B2DC0 Offset: 0x4B1FC0 VA: 0x1804B2DC0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Presence
public struct SetPresenceCallbackInfo : ICallbackInfo // TypeDefIndex: 8935
{
	// Fields
	[CompilerGenerated]
	private Result <ResultCode>k__BackingField; // 0x0
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x8
	[CompilerGenerated]
	private EpicAccountId <LocalUserId>k__BackingField; // 0x10

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public EpicAccountId LocalUserId { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	[CompilerGenerated]
	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public object get_ClientData() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_ClientData(object value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public EpicAccountId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_LocalUserId(EpicAccountId value) { }

	// RVA: 0x4B4C80 Offset: 0x4B3E80 VA: 0x1804B4C80 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x4B4CD0 Offset: 0x4B3ED0 VA: 0x1804B4CD0
	internal void Set(ref SetPresenceCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.Presence
internal struct SetPresenceCallbackInfoInternal : ICallbackInfoInternal, IGettable<SetPresenceCallbackInfo>, ISettable<SetPresenceCallbackInfo>, IDisposable // TypeDefIndex: 8936
{
	// Fields
	private Result m_ResultCode; // 0x0
	private IntPtr m_ClientData; // 0x8
	private IntPtr m_LocalUserId; // 0x10

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public EpicAccountId LocalUserId { get; set; }

	// Methods

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	// RVA: 0x4B4AD0 Offset: 0x4B3CD0 VA: 0x1804B4AD0
	public object get_ClientData() { }

	// RVA: 0x4B4BC0 Offset: 0x4B3DC0 VA: 0x1804B4BC0
	public void set_ClientData(object value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x4B4B40 Offset: 0x4B3D40 VA: 0x1804B4B40
	public EpicAccountId get_LocalUserId() { }

	// RVA: 0x4B4C20 Offset: 0x4B3E20 VA: 0x1804B4C20
	public void set_LocalUserId(EpicAccountId value) { }

	// RVA: 0x4B4A20 Offset: 0x4B3C20 VA: 0x1804B4A20 Slot: 6
	public void Set(ref SetPresenceCallbackInfo other) { }

	// RVA: 0x4B4900 Offset: 0x4B3B00 VA: 0x1804B4900 Slot: 7
	public void Set(ref Nullable<SetPresenceCallbackInfo> other) { }

	// RVA: 0x4B4880 Offset: 0x4B3A80 VA: 0x1804B4880 Slot: 8
	public void Dispose() { }

	// RVA: 0x4B48E0 Offset: 0x4B3AE0 VA: 0x1804B48E0 Slot: 5
	public void Get(out SetPresenceCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.Presence
public sealed class SetPresenceCompleteCallback : MulticastDelegate // TypeDefIndex: 8937
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref SetPresenceCallbackInfo data) { }

	// RVA: 0x4B4DF0 Offset: 0x4B3FF0 VA: 0x1804B4DF0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref SetPresenceCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref SetPresenceCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Presence
[UnmanagedFunctionPointer(2)]
internal sealed class SetPresenceCompleteCallbackInternal : MulticastDelegate // TypeDefIndex: 8938
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref SetPresenceCallbackInfoInternal data) { }

	// RVA: 0x4B4D60 Offset: 0x4B3F60 VA: 0x1804B4D60 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref SetPresenceCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref SetPresenceCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Presence
public struct SetPresenceOptions // TypeDefIndex: 8939
{
	// Fields
	[CompilerGenerated]
	private EpicAccountId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private PresenceModification <PresenceModificationHandle>k__BackingField; // 0x8

	// Properties
	public EpicAccountId LocalUserId { get; set; }
	public PresenceModification PresenceModificationHandle { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public EpicAccountId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_LocalUserId(EpicAccountId value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public PresenceModification get_PresenceModificationHandle() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_PresenceModificationHandle(PresenceModification value) { }
}

// Namespace: Epic.OnlineServices.Presence
internal struct SetPresenceOptionsInternal : ISettable<SetPresenceOptions>, IDisposable // TypeDefIndex: 8940
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_PresenceModificationHandle; // 0x10

	// Properties
	public EpicAccountId LocalUserId { set; }
	public PresenceModification PresenceModificationHandle { set; }

	// Methods

	// RVA: 0x4B50A0 Offset: 0x4B42A0 VA: 0x1804B50A0
	public void set_LocalUserId(EpicAccountId value) { }

	// RVA: 0x4B5100 Offset: 0x4B4300 VA: 0x1804B5100
	public void set_PresenceModificationHandle(PresenceModification value) { }

	// RVA: 0x4B4FE0 Offset: 0x4B41E0 VA: 0x1804B4FE0 Slot: 4
	public void Set(ref SetPresenceOptions other) { }

	// RVA: 0x4B4EE0 Offset: 0x4B40E0 VA: 0x1804B4EE0 Slot: 5
	public void Set(ref Nullable<SetPresenceOptions> other) { }

	// RVA: 0x4B4E80 Offset: 0x4B4080 VA: 0x1804B4E80 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Presence
public enum Status // TypeDefIndex: 8941
{
	// Fields
	public int value__; // 0x0
	public const Status Offline = 0;
	public const Status Online = 1;
	public const Status Away = 2;
	public const Status ExtendedAway = 3;
	public const Status DoNotDisturb = 4;
}

// Namespace: Epic.OnlineServices.PlayerDataStorage
public struct CopyFileMetadataAtIndexOptions // TypeDefIndex: 8942
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private uint <Index>k__BackingField; // 0x8

	// Properties
	public ProductUserId LocalUserId { get; set; }
	public uint Index { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_LocalUserId(ProductUserId value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3F5510 Offset: 0x3F4710 VA: 0x1803F5510
	public uint get_Index() { }

	[CompilerGenerated]
	// RVA: 0x3F5520 Offset: 0x3F4720 VA: 0x1803F5520
	public void set_Index(uint value) { }
}

// Namespace: Epic.OnlineServices.PlayerDataStorage
internal struct CopyFileMetadataAtIndexOptionsInternal : ISettable<CopyFileMetadataAtIndexOptions>, IDisposable // TypeDefIndex: 8943
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private uint m_Index; // 0x10

	// Properties
	public ProductUserId LocalUserId { set; }
	public uint Index { set; }

	// Methods

	// RVA: 0x4A3950 Offset: 0x4A2B50 VA: 0x1804A3950
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_Index(uint value) { }

	// RVA: 0x4A38D0 Offset: 0x4A2AD0 VA: 0x1804A38D0 Slot: 4
	public void Set(ref CopyFileMetadataAtIndexOptions other) { }

	// RVA: 0x4A3810 Offset: 0x4A2A10 VA: 0x1804A3810 Slot: 5
	public void Set(ref Nullable<CopyFileMetadataAtIndexOptions> other) { }

	// RVA: 0x4A37C0 Offset: 0x4A29C0 VA: 0x1804A37C0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.PlayerDataStorage
public struct CopyFileMetadataByFilenameOptions // TypeDefIndex: 8944
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <Filename>k__BackingField; // 0x8

	// Properties
	public ProductUserId LocalUserId { get; set; }
	public Utf8String Filename { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_LocalUserId(ProductUserId value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public Utf8String get_Filename() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_Filename(Utf8String value) { }
}

// Namespace: Epic.OnlineServices.PlayerDataStorage
internal struct CopyFileMetadataByFilenameOptionsInternal : ISettable<CopyFileMetadataByFilenameOptions>, IDisposable // TypeDefIndex: 8945
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_Filename; // 0x10

	// Properties
	public ProductUserId LocalUserId { set; }
	public Utf8String Filename { set; }

	// Methods

	// RVA: 0x4A3C30 Offset: 0x4A2E30 VA: 0x1804A3C30
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x4A3BD0 Offset: 0x4A2DD0 VA: 0x1804A3BD0
	public void set_Filename(Utf8String value) { }

	// RVA: 0x4A3B10 Offset: 0x4A2D10 VA: 0x1804A3B10 Slot: 4
	public void Set(ref CopyFileMetadataByFilenameOptions other) { }

	// RVA: 0x4A3A10 Offset: 0x4A2C10 VA: 0x1804A3A10 Slot: 5
	public void Set(ref Nullable<CopyFileMetadataByFilenameOptions> other) { }

	// RVA: 0x4A39B0 Offset: 0x4A2BB0 VA: 0x1804A39B0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.PlayerDataStorage
public struct DeleteCacheCallbackInfo : ICallbackInfo // TypeDefIndex: 8946
{
	// Fields
	[CompilerGenerated]
	private Result <ResultCode>k__BackingField; // 0x0
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x8
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x10

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public ProductUserId LocalUserId { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	[CompilerGenerated]
	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public object get_ClientData() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_ClientData(object value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x4A49E0 Offset: 0x4A3BE0 VA: 0x1804A49E0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x4A4A30 Offset: 0x4A3C30 VA: 0x1804A4A30
	internal void Set(ref DeleteCacheCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.PlayerDataStorage
internal struct DeleteCacheCallbackInfoInternal : ICallbackInfoInternal, IGettable<DeleteCacheCallbackInfo>, ISettable<DeleteCacheCallbackInfo>, IDisposable // TypeDefIndex: 8947
{
	// Fields
	private Result m_ResultCode; // 0x0
	private IntPtr m_ClientData; // 0x8
	private IntPtr m_LocalUserId; // 0x10

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public ProductUserId LocalUserId { get; set; }

	// Methods

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	// RVA: 0x4A4830 Offset: 0x4A3A30 VA: 0x1804A4830
	public object get_ClientData() { }

	// RVA: 0x4A4920 Offset: 0x4A3B20 VA: 0x1804A4920
	public void set_ClientData(object value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x4A48A0 Offset: 0x4A3AA0 VA: 0x1804A48A0
	public ProductUserId get_LocalUserId() { }

	// RVA: 0x4A4980 Offset: 0x4A3B80 VA: 0x1804A4980
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x4A4660 Offset: 0x4A3860 VA: 0x1804A4660 Slot: 6
	public void Set(ref DeleteCacheCallbackInfo other) { }

	// RVA: 0x4A4710 Offset: 0x4A3910 VA: 0x1804A4710 Slot: 7
	public void Set(ref Nullable<DeleteCacheCallbackInfo> other) { }

	// RVA: 0x4A45E0 Offset: 0x4A37E0 VA: 0x1804A45E0 Slot: 8
	public void Dispose() { }

	// RVA: 0x4A4640 Offset: 0x4A3840 VA: 0x1804A4640 Slot: 5
	public void Get(out DeleteCacheCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.PlayerDataStorage
public struct DeleteCacheOptions // TypeDefIndex: 8948
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x0

	// Properties
	public ProductUserId LocalUserId { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_LocalUserId(ProductUserId value) { }
}

// Namespace: Epic.OnlineServices.PlayerDataStorage
internal struct DeleteCacheOptionsInternal : ISettable<DeleteCacheOptions>, IDisposable // TypeDefIndex: 8949
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8

	// Properties
	public ProductUserId LocalUserId { set; }

	// Methods

	// RVA: 0x4A4C10 Offset: 0x4A3E10 VA: 0x1804A4C10
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x4A4B10 Offset: 0x4A3D10 VA: 0x1804A4B10 Slot: 4
	public void Set(ref DeleteCacheOptions other) { }

	// RVA: 0x4A4B70 Offset: 0x4A3D70 VA: 0x1804A4B70 Slot: 5
	public void Set(ref Nullable<DeleteCacheOptions> other) { }

	// RVA: 0x4A4AC0 Offset: 0x4A3CC0 VA: 0x1804A4AC0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.PlayerDataStorage
public struct DeleteFileCallbackInfo : ICallbackInfo // TypeDefIndex: 8950
{
	// Fields
	[CompilerGenerated]
	private Result <ResultCode>k__BackingField; // 0x0
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x8
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x10

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public ProductUserId LocalUserId { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	[CompilerGenerated]
	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public object get_ClientData() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_ClientData(object value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x4A5070 Offset: 0x4A4270 VA: 0x1804A5070 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x4A50C0 Offset: 0x4A42C0 VA: 0x1804A50C0
	internal void Set(ref DeleteFileCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.PlayerDataStorage
internal struct DeleteFileCallbackInfoInternal : ICallbackInfoInternal, IGettable<DeleteFileCallbackInfo>, ISettable<DeleteFileCallbackInfo>, IDisposable // TypeDefIndex: 8951
{
	// Fields
	private Result m_ResultCode; // 0x0
	private IntPtr m_ClientData; // 0x8
	private IntPtr m_LocalUserId; // 0x10

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public ProductUserId LocalUserId { get; set; }

	// Methods

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	// RVA: 0x4A4EC0 Offset: 0x4A40C0 VA: 0x1804A4EC0
	public object get_ClientData() { }

	// RVA: 0x4A4FB0 Offset: 0x4A41B0 VA: 0x1804A4FB0
	public void set_ClientData(object value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x4A4F30 Offset: 0x4A4130 VA: 0x1804A4F30
	public ProductUserId get_LocalUserId() { }

	// RVA: 0x4A5010 Offset: 0x4A4210 VA: 0x1804A5010
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x4A4E10 Offset: 0x4A4010 VA: 0x1804A4E10 Slot: 6
	public void Set(ref DeleteFileCallbackInfo other) { }

	// RVA: 0x4A4CF0 Offset: 0x4A3EF0 VA: 0x1804A4CF0 Slot: 7
	public void Set(ref Nullable<DeleteFileCallbackInfo> other) { }

	// RVA: 0x4A4C70 Offset: 0x4A3E70 VA: 0x1804A4C70 Slot: 8
	public void Dispose() { }

	// RVA: 0x4A4CD0 Offset: 0x4A3ED0 VA: 0x1804A4CD0 Slot: 5
	public void Get(out DeleteFileCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.PlayerDataStorage
public struct DeleteFileOptions // TypeDefIndex: 8952
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <Filename>k__BackingField; // 0x8

	// Properties
	public ProductUserId LocalUserId { get; set; }
	public Utf8String Filename { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_LocalUserId(ProductUserId value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public Utf8String get_Filename() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_Filename(Utf8String value) { }
}

// Namespace: Epic.OnlineServices.PlayerDataStorage
internal struct DeleteFileOptionsInternal : ISettable<DeleteFileOptions>, IDisposable // TypeDefIndex: 8953
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_Filename; // 0x10

	// Properties
	public ProductUserId LocalUserId { set; }
	public Utf8String Filename { set; }

	// Methods

	// RVA: 0x4A53D0 Offset: 0x4A45D0 VA: 0x1804A53D0
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x4A5370 Offset: 0x4A4570 VA: 0x1804A5370
	public void set_Filename(Utf8String value) { }

	// RVA: 0x4A52B0 Offset: 0x4A44B0 VA: 0x1804A52B0 Slot: 4
	public void Set(ref DeleteFileOptions other) { }

	// RVA: 0x4A51B0 Offset: 0x4A43B0 VA: 0x1804A51B0 Slot: 5
	public void Set(ref Nullable<DeleteFileOptions> other) { }

	// RVA: 0x4A5150 Offset: 0x4A4350 VA: 0x1804A5150 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.PlayerDataStorage
public struct DuplicateFileCallbackInfo : ICallbackInfo // TypeDefIndex: 8954
{
	// Fields
	[CompilerGenerated]
	private Result <ResultCode>k__BackingField; // 0x0
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x8
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x10

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public ProductUserId LocalUserId { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	[CompilerGenerated]
	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public object get_ClientData() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_ClientData(object value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x4A5EC0 Offset: 0x4A50C0 VA: 0x1804A5EC0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x4A5F10 Offset: 0x4A5110 VA: 0x1804A5F10
	internal void Set(ref DuplicateFileCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.PlayerDataStorage
internal struct DuplicateFileCallbackInfoInternal : ICallbackInfoInternal, IGettable<DuplicateFileCallbackInfo>, ISettable<DuplicateFileCallbackInfo>, IDisposable // TypeDefIndex: 8955
{
	// Fields
	private Result m_ResultCode; // 0x0
	private IntPtr m_ClientData; // 0x8
	private IntPtr m_LocalUserId; // 0x10

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public ProductUserId LocalUserId { get; set; }

	// Methods

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	// RVA: 0x4A5D10 Offset: 0x4A4F10 VA: 0x1804A5D10
	public object get_ClientData() { }

	// RVA: 0x4A5E00 Offset: 0x4A5000 VA: 0x1804A5E00
	public void set_ClientData(object value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x4A5D80 Offset: 0x4A4F80 VA: 0x1804A5D80
	public ProductUserId get_LocalUserId() { }

	// RVA: 0x4A5E60 Offset: 0x4A5060 VA: 0x1804A5E60
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x4A5C60 Offset: 0x4A4E60 VA: 0x1804A5C60 Slot: 6
	public void Set(ref DuplicateFileCallbackInfo other) { }

	// RVA: 0x4A5B40 Offset: 0x4A4D40 VA: 0x1804A5B40 Slot: 7
	public void Set(ref Nullable<DuplicateFileCallbackInfo> other) { }

	// RVA: 0x4A5AC0 Offset: 0x4A4CC0 VA: 0x1804A5AC0 Slot: 8
	public void Dispose() { }

	// RVA: 0x4A5B20 Offset: 0x4A4D20 VA: 0x1804A5B20 Slot: 5
	public void Get(out DuplicateFileCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.PlayerDataStorage
public struct DuplicateFileOptions // TypeDefIndex: 8956
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <SourceFilename>k__BackingField; // 0x8
	[CompilerGenerated]
	private Utf8String <DestinationFilename>k__BackingField; // 0x10

	// Properties
	public ProductUserId LocalUserId { get; set; }
	public Utf8String SourceFilename { get; set; }
	public Utf8String DestinationFilename { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_LocalUserId(ProductUserId value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public Utf8String get_SourceFilename() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_SourceFilename(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Utf8String get_DestinationFilename() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_DestinationFilename(Utf8String value) { }
}

// Namespace: Epic.OnlineServices.PlayerDataStorage
internal struct DuplicateFileOptionsInternal : ISettable<DuplicateFileOptions>, IDisposable // TypeDefIndex: 8957
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_SourceFilename; // 0x10
	private IntPtr m_DestinationFilename; // 0x18

	// Properties
	public ProductUserId LocalUserId { set; }
	public Utf8String SourceFilename { set; }
	public Utf8String DestinationFilename { set; }

	// Methods

	// RVA: 0x4A62C0 Offset: 0x4A54C0 VA: 0x1804A62C0
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x4A6320 Offset: 0x4A5520 VA: 0x1804A6320
	public void set_SourceFilename(Utf8String value) { }

	// RVA: 0x4A6260 Offset: 0x4A5460 VA: 0x1804A6260
	public void set_DestinationFilename(Utf8String value) { }

	// RVA: 0x4A6160 Offset: 0x4A5360 VA: 0x1804A6160 Slot: 4
	public void Set(ref DuplicateFileOptions other) { }

	// RVA: 0x4A6000 Offset: 0x4A5200 VA: 0x1804A6000 Slot: 5
	public void Set(ref Nullable<DuplicateFileOptions> other) { }

	// RVA: 0x4A5FA0 Offset: 0x4A51A0 VA: 0x1804A5FA0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.PlayerDataStorage
public struct FileMetadata // TypeDefIndex: 8958
{
	// Fields
	[CompilerGenerated]
	private uint <FileSizeBytes>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <MD5Hash>k__BackingField; // 0x8
	[CompilerGenerated]
	private Utf8String <Filename>k__BackingField; // 0x10
	[CompilerGenerated]
	private Nullable<DateTimeOffset> <LastModifiedTime>k__BackingField; // 0x18
	[CompilerGenerated]
	private uint <UnencryptedDataSizeBytes>k__BackingField; // 0x30

	// Properties
	public uint FileSizeBytes { get; set; }
	public Utf8String MD5Hash { get; set; }
	public Utf8String Filename { get; set; }
	public Nullable<DateTimeOffset> LastModifiedTime { get; set; }
	public uint UnencryptedDataSizeBytes { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public uint get_FileSizeBytes() { }

	[CompilerGenerated]
	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_FileSizeBytes(uint value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public Utf8String get_MD5Hash() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_MD5Hash(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Utf8String get_Filename() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_Filename(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x426510 Offset: 0x425710 VA: 0x180426510
	public Nullable<DateTimeOffset> get_LastModifiedTime() { }

	[CompilerGenerated]
	// RVA: 0x426540 Offset: 0x425740 VA: 0x180426540
	public void set_LastModifiedTime(Nullable<DateTimeOffset> value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x40D300 Offset: 0x40C500 VA: 0x18040D300
	public uint get_UnencryptedDataSizeBytes() { }

	[CompilerGenerated]
	// RVA: 0x40D850 Offset: 0x40CA50 VA: 0x18040D850
	public void set_UnencryptedDataSizeBytes(uint value) { }

	// RVA: 0x4A69D0 Offset: 0x4A5BD0 VA: 0x1804A69D0
	internal void Set(ref FileMetadataInternal other) { }
}

// Namespace: Epic.OnlineServices.PlayerDataStorage
internal struct FileMetadataInternal : IGettable<FileMetadata>, ISettable<FileMetadata>, IDisposable // TypeDefIndex: 8959
{
	// Fields
	private int m_ApiVersion; // 0x0
	private uint m_FileSizeBytes; // 0x4
	private IntPtr m_MD5Hash; // 0x8
	private IntPtr m_Filename; // 0x10
	private long m_LastModifiedTime; // 0x18
	private uint m_UnencryptedDataSizeBytes; // 0x20

	// Properties
	public uint FileSizeBytes { get; set; }
	public Utf8String MD5Hash { get; set; }
	public Utf8String Filename { get; set; }
	public Nullable<DateTimeOffset> LastModifiedTime { get; set; }
	public uint UnencryptedDataSizeBytes { get; set; }

	// Methods

	// RVA: 0x3F8350 Offset: 0x3F7550 VA: 0x1803F8350
	public uint get_FileSizeBytes() { }

	// RVA: 0x3F84A0 Offset: 0x3F76A0 VA: 0x1803F84A0
	public void set_FileSizeBytes(uint value) { }

	// RVA: 0x4A6830 Offset: 0x4A5A30 VA: 0x1804A6830
	public Utf8String get_MD5Hash() { }

	// RVA: 0x4A6970 Offset: 0x4A5B70 VA: 0x1804A6970
	public void set_MD5Hash(Utf8String value) { }

	// RVA: 0x4A6750 Offset: 0x4A5950 VA: 0x1804A6750
	public Utf8String get_Filename() { }

	// RVA: 0x4A68A0 Offset: 0x4A5AA0 VA: 0x1804A68A0
	public void set_Filename(Utf8String value) { }

	// RVA: 0x4A67C0 Offset: 0x4A59C0 VA: 0x1804A67C0
	public Nullable<DateTimeOffset> get_LastModifiedTime() { }

	// RVA: 0x4A6900 Offset: 0x4A5B00 VA: 0x1804A6900
	public void set_LastModifiedTime(Nullable<DateTimeOffset> value) { }

	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400
	public uint get_UnencryptedDataSizeBytes() { }

	// RVA: 0x3DA420 Offset: 0x3D9620 VA: 0x1803DA420
	public void set_UnencryptedDataSizeBytes(uint value) { }

	// RVA: 0x4A6470 Offset: 0x4A5670 VA: 0x1804A6470 Slot: 5
	public void Set(ref FileMetadata other) { }

	// RVA: 0x4A65A0 Offset: 0x4A57A0 VA: 0x1804A65A0 Slot: 6
	public void Set(ref Nullable<FileMetadata> other) { }

	// RVA: 0x4A63E0 Offset: 0x4A55E0 VA: 0x1804A63E0 Slot: 7
	public void Dispose() { }

	// RVA: 0x4A6440 Offset: 0x4A5640 VA: 0x1804A6440 Slot: 4
	public void Get(out FileMetadata output) { }
}

// Namespace: Epic.OnlineServices.PlayerDataStorage
public struct FileTransferProgressCallbackInfo : ICallbackInfo // TypeDefIndex: 8960
{
	// Fields
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x0
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x8
	[CompilerGenerated]
	private Utf8String <Filename>k__BackingField; // 0x10
	[CompilerGenerated]
	private uint <BytesTransferred>k__BackingField; // 0x18
	[CompilerGenerated]
	private uint <TotalFileSizeBytes>k__BackingField; // 0x1C

	// Properties
	public object ClientData { get; set; }
	public ProductUserId LocalUserId { get; set; }
	public Utf8String Filename { get; set; }
	public uint BytesTransferred { get; set; }
	public uint TotalFileSizeBytes { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410 Slot: 4
	public object get_ClientData() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_ClientData(object value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_LocalUserId(ProductUserId value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Utf8String get_Filename() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_Filename(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public uint get_BytesTransferred() { }

	[CompilerGenerated]
	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	public void set_BytesTransferred(uint value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3F9110 Offset: 0x3F8310 VA: 0x1803F9110
	public uint get_TotalFileSizeBytes() { }

	[CompilerGenerated]
	// RVA: 0x3F9290 Offset: 0x3F8490 VA: 0x1803F9290
	public void set_TotalFileSizeBytes(uint value) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x4A70B0 Offset: 0x4A62B0 VA: 0x1804A70B0
	internal void Set(ref FileTransferProgressCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.PlayerDataStorage
internal struct FileTransferProgressCallbackInfoInternal : ICallbackInfoInternal, IGettable<FileTransferProgressCallbackInfo>, ISettable<FileTransferProgressCallbackInfo>, IDisposable // TypeDefIndex: 8961
{
	// Fields
	private IntPtr m_ClientData; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_Filename; // 0x10
	private uint m_BytesTransferred; // 0x18
	private uint m_TotalFileSizeBytes; // 0x1C

	// Properties
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public ProductUserId LocalUserId { get; set; }
	public Utf8String Filename { get; set; }
	public uint BytesTransferred { get; set; }
	public uint TotalFileSizeBytes { get; set; }

	// Methods

	// RVA: 0x4A6E30 Offset: 0x4A6030 VA: 0x1804A6E30
	public object get_ClientData() { }

	// RVA: 0x4A6F90 Offset: 0x4A6190 VA: 0x1804A6F90
	public void set_ClientData(object value) { }

	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x4A6F10 Offset: 0x4A6110 VA: 0x1804A6F10
	public ProductUserId get_LocalUserId() { }

	// RVA: 0x4A7050 Offset: 0x4A6250 VA: 0x1804A7050
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x4A6EA0 Offset: 0x4A60A0 VA: 0x1804A6EA0
	public Utf8String get_Filename() { }

	// RVA: 0x4A6FF0 Offset: 0x4A61F0 VA: 0x1804A6FF0
	public void set_Filename(Utf8String value) { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public uint get_BytesTransferred() { }

	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	public void set_BytesTransferred(uint value) { }

	// RVA: 0x3F9110 Offset: 0x3F8310 VA: 0x1803F9110
	public uint get_TotalFileSizeBytes() { }

	// RVA: 0x3F9290 Offset: 0x3F8490 VA: 0x1803F9290
	public void set_TotalFileSizeBytes(uint value) { }

	// RVA: 0x4A6D30 Offset: 0x4A5F30 VA: 0x1804A6D30 Slot: 6
	public void Set(ref FileTransferProgressCallbackInfo other) { }

	// RVA: 0x4A6BA0 Offset: 0x4A5DA0 VA: 0x1804A6BA0 Slot: 7
	public void Set(ref Nullable<FileTransferProgressCallbackInfo> other) { }

	// RVA: 0x4A6B20 Offset: 0x4A5D20 VA: 0x1804A6B20 Slot: 8
	public void Dispose() { }

	// RVA: 0x4A6B80 Offset: 0x4A5D80 VA: 0x1804A6B80 Slot: 5
	public void Get(out FileTransferProgressCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.PlayerDataStorage
public struct GetFileMetadataCountOptions // TypeDefIndex: 8962
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x0

	// Properties
	public ProductUserId LocalUserId { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_LocalUserId(ProductUserId value) { }
}

// Namespace: Epic.OnlineServices.PlayerDataStorage
internal struct GetFileMetadataCountOptionsInternal : ISettable<GetFileMetadataCountOptions>, IDisposable // TypeDefIndex: 8963
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8

	// Properties
	public ProductUserId LocalUserId { set; }

	// Methods

	// RVA: 0x4A72F0 Offset: 0x4A64F0 VA: 0x1804A72F0
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x4A7290 Offset: 0x4A6490 VA: 0x1804A7290 Slot: 4
	public void Set(ref GetFileMetadataCountOptions other) { }

	// RVA: 0x4A71F0 Offset: 0x4A63F0 VA: 0x1804A71F0 Slot: 5
	public void Set(ref Nullable<GetFileMetadataCountOptions> other) { }

	// RVA: 0x4A71A0 Offset: 0x4A63A0 VA: 0x1804A71A0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.PlayerDataStorage
public sealed class OnDeleteCacheCompleteCallback : MulticastDelegate // TypeDefIndex: 8964
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref DeleteCacheCallbackInfo data) { }

	// RVA: 0x4A9290 Offset: 0x4A8490 VA: 0x1804A9290 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref DeleteCacheCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref DeleteCacheCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.PlayerDataStorage
[UnmanagedFunctionPointer(2)]
internal sealed class OnDeleteCacheCompleteCallbackInternal : MulticastDelegate // TypeDefIndex: 8965
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref DeleteCacheCallbackInfoInternal data) { }

	// RVA: 0x4A9200 Offset: 0x4A8400 VA: 0x1804A9200 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref DeleteCacheCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref DeleteCacheCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.PlayerDataStorage
public sealed class OnDeleteFileCompleteCallback : MulticastDelegate // TypeDefIndex: 8966
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref DeleteFileCallbackInfo data) { }

	// RVA: 0x4A93B0 Offset: 0x4A85B0 VA: 0x1804A93B0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref DeleteFileCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref DeleteFileCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.PlayerDataStorage
[UnmanagedFunctionPointer(2)]
internal sealed class OnDeleteFileCompleteCallbackInternal : MulticastDelegate // TypeDefIndex: 8967
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref DeleteFileCallbackInfoInternal data) { }

	// RVA: 0x4A9320 Offset: 0x4A8520 VA: 0x1804A9320 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref DeleteFileCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref DeleteFileCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.PlayerDataStorage
public sealed class OnDuplicateFileCompleteCallback : MulticastDelegate // TypeDefIndex: 8968
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref DuplicateFileCallbackInfo data) { }

	// RVA: 0x4A95F0 Offset: 0x4A87F0 VA: 0x1804A95F0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref DuplicateFileCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref DuplicateFileCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.PlayerDataStorage
[UnmanagedFunctionPointer(2)]
internal sealed class OnDuplicateFileCompleteCallbackInternal : MulticastDelegate // TypeDefIndex: 8969
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref DuplicateFileCallbackInfoInternal data) { }

	// RVA: 0x4A9560 Offset: 0x4A8760 VA: 0x1804A9560 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref DuplicateFileCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref DuplicateFileCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.PlayerDataStorage
public sealed class OnFileTransferProgressCallback : MulticastDelegate // TypeDefIndex: 8970
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref FileTransferProgressCallbackInfo data) { }

	// RVA: 0x4A9710 Offset: 0x4A8910 VA: 0x1804A9710 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref FileTransferProgressCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref FileTransferProgressCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.PlayerDataStorage
[UnmanagedFunctionPointer(2)]
internal sealed class OnFileTransferProgressCallbackInternal : MulticastDelegate // TypeDefIndex: 8971
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref FileTransferProgressCallbackInfoInternal data) { }

	// RVA: 0x4A9680 Offset: 0x4A8880 VA: 0x1804A9680 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref FileTransferProgressCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref FileTransferProgressCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.PlayerDataStorage
public sealed class OnQueryFileCompleteCallback : MulticastDelegate // TypeDefIndex: 8972
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref QueryFileCallbackInfo data) { }

	// RVA: 0x4ABE20 Offset: 0x4AB020 VA: 0x1804ABE20 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref QueryFileCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref QueryFileCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.PlayerDataStorage
[UnmanagedFunctionPointer(2)]
internal sealed class OnQueryFileCompleteCallbackInternal : MulticastDelegate // TypeDefIndex: 8973
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref QueryFileCallbackInfoInternal data) { }

	// RVA: 0x4ABD90 Offset: 0x4AAF90 VA: 0x1804ABD90 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref QueryFileCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref QueryFileCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.PlayerDataStorage
public sealed class OnQueryFileListCompleteCallback : MulticastDelegate // TypeDefIndex: 8974
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref QueryFileListCallbackInfo data) { }

	// RVA: 0x4ABF40 Offset: 0x4AB140 VA: 0x1804ABF40 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref QueryFileListCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref QueryFileListCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.PlayerDataStorage
[UnmanagedFunctionPointer(2)]
internal sealed class OnQueryFileListCompleteCallbackInternal : MulticastDelegate // TypeDefIndex: 8975
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref QueryFileListCallbackInfoInternal data) { }

	// RVA: 0x4ABEB0 Offset: 0x4AB0B0 VA: 0x1804ABEB0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref QueryFileListCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref QueryFileListCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.PlayerDataStorage
public sealed class OnReadFileCompleteCallback : MulticastDelegate // TypeDefIndex: 8976
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref ReadFileCallbackInfo data) { }

	// RVA: 0x4AC2A0 Offset: 0x4AB4A0 VA: 0x1804AC2A0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref ReadFileCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref ReadFileCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.PlayerDataStorage
[UnmanagedFunctionPointer(2)]
internal sealed class OnReadFileCompleteCallbackInternal : MulticastDelegate // TypeDefIndex: 8977
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref ReadFileCallbackInfoInternal data) { }

	// RVA: 0x4AC210 Offset: 0x4AB410 VA: 0x1804AC210 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref ReadFileCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref ReadFileCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.PlayerDataStorage
public sealed class OnReadFileDataCallback : MulticastDelegate // TypeDefIndex: 8978
{
	// Methods

	// RVA: 0x3FEA60 Offset: 0x3FDC60 VA: 0x1803FEA60
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual ReadResult Invoke(ref ReadFileDataCallbackInfo data) { }

	// RVA: 0x4AC3C0 Offset: 0x4AB5C0 VA: 0x1804AC3C0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref ReadFileDataCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FEA30 Offset: 0x3FDC30 VA: 0x1803FEA30 Slot: 15
	public virtual ReadResult EndInvoke(ref ReadFileDataCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.PlayerDataStorage
[UnmanagedFunctionPointer(2)]
internal sealed class OnReadFileDataCallbackInternal : MulticastDelegate // TypeDefIndex: 8979
{
	// Methods

	// RVA: 0x3FEA60 Offset: 0x3FDC60 VA: 0x1803FEA60
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual ReadResult Invoke(ref ReadFileDataCallbackInfoInternal data) { }

	// RVA: 0x4AC330 Offset: 0x4AB530 VA: 0x1804AC330 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref ReadFileDataCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FEA30 Offset: 0x3FDC30 VA: 0x1803FEA30 Slot: 15
	public virtual ReadResult EndInvoke(ref ReadFileDataCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.PlayerDataStorage
public sealed class OnWriteFileCompleteCallback : MulticastDelegate // TypeDefIndex: 8980
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref WriteFileCallbackInfo data) { }

	// RVA: 0x4AC600 Offset: 0x4AB800 VA: 0x1804AC600 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref WriteFileCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref WriteFileCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.PlayerDataStorage
[UnmanagedFunctionPointer(2)]
internal sealed class OnWriteFileCompleteCallbackInternal : MulticastDelegate // TypeDefIndex: 8981
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref WriteFileCallbackInfoInternal data) { }

	// RVA: 0x4AC570 Offset: 0x4AB770 VA: 0x1804AC570 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref WriteFileCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref WriteFileCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.PlayerDataStorage
public sealed class OnWriteFileDataCallback : MulticastDelegate // TypeDefIndex: 8982
{
	// Methods

	// RVA: 0x4AC8F0 Offset: 0x4ABAF0 VA: 0x1804AC8F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual WriteResult Invoke(ref WriteFileDataCallbackInfo data, out ArraySegment<byte> outDataBuffer) { }

	// RVA: 0x4AC840 Offset: 0x4ABA40 VA: 0x1804AC840 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref WriteFileDataCallbackInfo data, out ArraySegment<byte> outDataBuffer, AsyncCallback callback, object object) { }

	// RVA: 0x4AC750 Offset: 0x4AB950 VA: 0x1804AC750 Slot: 15
	public virtual WriteResult EndInvoke(ref WriteFileDataCallbackInfo data, out ArraySegment<byte> outDataBuffer, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.PlayerDataStorage
[UnmanagedFunctionPointer(2)]
internal sealed class OnWriteFileDataCallbackInternal : MulticastDelegate // TypeDefIndex: 8983
{
	// Methods

	// RVA: 0x4AC790 Offset: 0x4AB990 VA: 0x1804AC790
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x409CF0 Offset: 0x408EF0 VA: 0x180409CF0 Slot: 13
	public virtual WriteResult Invoke(ref WriteFileDataCallbackInfoInternal data, IntPtr outDataBuffer, ref uint outDataWritten) { }

	// RVA: 0x4AC690 Offset: 0x4AB890 VA: 0x1804AC690 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref WriteFileDataCallbackInfoInternal data, IntPtr outDataBuffer, ref uint outDataWritten, AsyncCallback callback, object object) { }

	// RVA: 0x4AC750 Offset: 0x4AB950 VA: 0x1804AC750 Slot: 15
	public virtual WriteResult EndInvoke(ref WriteFileDataCallbackInfoInternal data, ref uint outDataWritten, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.PlayerDataStorage
public sealed class PlayerDataStorageFileTransferRequest : Handle // TypeDefIndex: 8984
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }

	// RVA: 0x40BDB0 Offset: 0x40AFB0 VA: 0x18040BDB0
	public void .ctor(IntPtr innerHandle) { }

	// RVA: 0x4AD3D0 Offset: 0x4AC5D0 VA: 0x1804AD3D0
	public Result CancelRequest() { }

	// RVA: 0x4AD3E0 Offset: 0x4AC5E0 VA: 0x1804AD3E0
	public Result GetFileRequestState() { }

	// RVA: 0x4AD3F0 Offset: 0x4AC5F0 VA: 0x1804AD3F0
	public Result GetFilename(out Utf8String outStringBuffer) { }

	// RVA: 0x4AD4A0 Offset: 0x4AC6A0 VA: 0x1804AD4A0
	public void Release() { }
}

// Namespace: Epic.OnlineServices.PlayerDataStorage
public sealed class PlayerDataStorageInterface : Handle // TypeDefIndex: 8985
{
	// Fields
	public const int CopyfilemetadataatindexApiLatest = 1;
	public const int CopyfilemetadataatindexoptionsApiLatest = 1;
	public const int CopyfilemetadatabyfilenameApiLatest = 1;
	public const int CopyfilemetadatabyfilenameoptionsApiLatest = 1;
	public const int DeletecacheApiLatest = 1;
	public const int DeletecacheoptionsApiLatest = 1;
	public const int DeletefileApiLatest = 1;
	public const int DeletefileoptionsApiLatest = 1;
	public const int DuplicatefileApiLatest = 1;
	public const int DuplicatefileoptionsApiLatest = 1;
	public const int FilemetadataApiLatest = 3;
	public const int FilenameMaxLengthBytes = 64;
	public const int GetfilemetadatacountApiLatest = 1;
	public const int GetfilemetadatacountoptionsApiLatest = 1;
	public const int QueryfileApiLatest = 1;
	public const int QueryfilelistApiLatest = 2;
	public const int QueryfilelistoptionsApiLatest = 2;
	public const int QueryfileoptionsApiLatest = 1;
	public const int ReadfileApiLatest = 2;
	public const int ReadfileoptionsApiLatest = 2;
	public const int TimeUndefined = -1;
	public const int WritefileApiLatest = 2;
	public const int WritefileoptionsApiLatest = 2;

	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }

	// RVA: 0x40BDB0 Offset: 0x40AFB0 VA: 0x18040BDB0
	public void .ctor(IntPtr innerHandle) { }

	// RVA: 0x4AD4B0 Offset: 0x4AC6B0 VA: 0x1804AD4B0
	public Result CopyFileMetadataAtIndex(ref CopyFileMetadataAtIndexOptions copyFileMetadataOptions, out Nullable<FileMetadata> outMetadata) { }

	// RVA: 0x4AD600 Offset: 0x4AC800 VA: 0x1804AD600
	public Result CopyFileMetadataByFilename(ref CopyFileMetadataByFilenameOptions copyFileMetadataOptions, out Nullable<FileMetadata> outMetadata) { }

	// RVA: 0x4AD700 Offset: 0x4AC900 VA: 0x1804AD700
	public Result DeleteCache(ref DeleteCacheOptions options, object clientData, OnDeleteCacheCompleteCallback completionCallback) { }

	// RVA: 0x4AD8F0 Offset: 0x4ACAF0 VA: 0x1804AD8F0
	public void DeleteFile(ref DeleteFileOptions deleteOptions, object clientData, OnDeleteFileCompleteCallback completionCallback) { }

	// RVA: 0x4ADAA0 Offset: 0x4ACCA0 VA: 0x1804ADAA0
	public void DuplicateFile(ref DuplicateFileOptions duplicateOptions, object clientData, OnDuplicateFileCompleteCallback completionCallback) { }

	// RVA: 0x4ADC50 Offset: 0x4ACE50 VA: 0x1804ADC50
	public Result GetFileMetadataCount(ref GetFileMetadataCountOptions getFileMetadataCountOptions, out int outFileMetadataCount) { }

	// RVA: 0x4AE720 Offset: 0x4AD920 VA: 0x1804AE720
	public void QueryFile(ref QueryFileOptions queryFileOptions, object clientData, OnQueryFileCompleteCallback completionCallback) { }

	// RVA: 0x4AE530 Offset: 0x4AD730 VA: 0x1804AE530
	public void QueryFileList(ref QueryFileListOptions queryFileListOptions, object clientData, OnQueryFileListCompleteCallback completionCallback) { }

	// RVA: 0x4AE8D0 Offset: 0x4ADAD0 VA: 0x1804AE8D0
	public PlayerDataStorageFileTransferRequest ReadFile(ref ReadFileOptions readOptions, object clientData, OnReadFileCompleteCallback completionCallback) { }

	// RVA: 0x4AEBF0 Offset: 0x4ADDF0 VA: 0x1804AEBF0
	public PlayerDataStorageFileTransferRequest WriteFile(ref WriteFileOptions writeOptions, object clientData, OnWriteFileCompleteCallback completionCallback) { }

	[MonoPInvokeCallback(typeof(OnDeleteCacheCompleteCallbackInternal))]
	// RVA: 0x4ADD50 Offset: 0x4ACF50 VA: 0x1804ADD50
	internal static void OnDeleteCacheCompleteCallbackInternalImplementation(ref DeleteCacheCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnDeleteFileCompleteCallbackInternal))]
	// RVA: 0x4ADE00 Offset: 0x4AD000 VA: 0x1804ADE00
	internal static void OnDeleteFileCompleteCallbackInternalImplementation(ref DeleteFileCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnDuplicateFileCompleteCallbackInternal))]
	// RVA: 0x4ADEB0 Offset: 0x4AD0B0 VA: 0x1804ADEB0
	internal static void OnDuplicateFileCompleteCallbackInternalImplementation(ref DuplicateFileCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnFileTransferProgressCallbackInternal))]
	// RVA: 0x4ADF60 Offset: 0x4AD160 VA: 0x1804ADF60
	internal static void OnFileTransferProgressCallbackInternalImplementation(ref FileTransferProgressCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnQueryFileCompleteCallbackInternal))]
	// RVA: 0x4AE010 Offset: 0x4AD210 VA: 0x1804AE010
	internal static void OnQueryFileCompleteCallbackInternalImplementation(ref QueryFileCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnQueryFileListCompleteCallbackInternal))]
	// RVA: 0x4AE0C0 Offset: 0x4AD2C0 VA: 0x1804AE0C0
	internal static void OnQueryFileListCompleteCallbackInternalImplementation(ref QueryFileListCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnReadFileCompleteCallbackInternal))]
	// RVA: 0x4AE170 Offset: 0x4AD370 VA: 0x1804AE170
	internal static void OnReadFileCompleteCallbackInternalImplementation(ref ReadFileCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnReadFileDataCallbackInternal))]
	// RVA: 0x4AE220 Offset: 0x4AD420 VA: 0x1804AE220
	internal static ReadResult OnReadFileDataCallbackInternalImplementation(ref ReadFileDataCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnWriteFileCompleteCallbackInternal))]
	// RVA: 0x4AE300 Offset: 0x4AD500 VA: 0x1804AE300
	internal static void OnWriteFileCompleteCallbackInternalImplementation(ref WriteFileCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnWriteFileDataCallbackInternal))]
	// RVA: 0x4AE3B0 Offset: 0x4AD5B0 VA: 0x1804AE3B0
	internal static WriteResult OnWriteFileDataCallbackInternalImplementation(ref WriteFileDataCallbackInfoInternal data, IntPtr outDataBuffer, ref uint outDataWritten) { }
}

// Namespace: Epic.OnlineServices.PlayerDataStorage
public struct QueryFileCallbackInfo : ICallbackInfo // TypeDefIndex: 8986
{
	// Fields
	[CompilerGenerated]
	private Result <ResultCode>k__BackingField; // 0x0
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x8
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x10

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public ProductUserId LocalUserId { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	[CompilerGenerated]
	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public object get_ClientData() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_ClientData(object value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x4B1CD0 Offset: 0x4B0ED0 VA: 0x1804B1CD0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x4B1D20 Offset: 0x4B0F20 VA: 0x1804B1D20
	internal void Set(ref QueryFileCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.PlayerDataStorage
internal struct QueryFileCallbackInfoInternal : ICallbackInfoInternal, IGettable<QueryFileCallbackInfo>, ISettable<QueryFileCallbackInfo>, IDisposable // TypeDefIndex: 8987
{
	// Fields
	private Result m_ResultCode; // 0x0
	private IntPtr m_ClientData; // 0x8
	private IntPtr m_LocalUserId; // 0x10

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public ProductUserId LocalUserId { get; set; }

	// Methods

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	// RVA: 0x4B1B20 Offset: 0x4B0D20 VA: 0x1804B1B20
	public object get_ClientData() { }

	// RVA: 0x4B1C10 Offset: 0x4B0E10 VA: 0x1804B1C10
	public void set_ClientData(object value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x4B1B90 Offset: 0x4B0D90 VA: 0x1804B1B90
	public ProductUserId get_LocalUserId() { }

	// RVA: 0x4B1C70 Offset: 0x4B0E70 VA: 0x1804B1C70
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x4B1950 Offset: 0x4B0B50 VA: 0x1804B1950 Slot: 6
	public void Set(ref QueryFileCallbackInfo other) { }

	// RVA: 0x4B1A00 Offset: 0x4B0C00 VA: 0x1804B1A00 Slot: 7
	public void Set(ref Nullable<QueryFileCallbackInfo> other) { }

	// RVA: 0x4B18D0 Offset: 0x4B0AD0 VA: 0x1804B18D0 Slot: 8
	public void Dispose() { }

	// RVA: 0x4B1930 Offset: 0x4B0B30 VA: 0x1804B1930 Slot: 5
	public void Get(out QueryFileCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.PlayerDataStorage
public struct QueryFileListCallbackInfo : ICallbackInfo // TypeDefIndex: 8988
{
	// Fields
	[CompilerGenerated]
	private Result <ResultCode>k__BackingField; // 0x0
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x8
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x10
	[CompilerGenerated]
	private uint <FileCount>k__BackingField; // 0x18

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public ProductUserId LocalUserId { get; set; }
	public uint FileCount { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	[CompilerGenerated]
	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public object get_ClientData() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_ClientData(object value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_LocalUserId(ProductUserId value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public uint get_FileCount() { }

	[CompilerGenerated]
	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	public void set_FileCount(uint value) { }

	// RVA: 0x4B21D0 Offset: 0x4B13D0 VA: 0x1804B21D0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x4B2220 Offset: 0x4B1420 VA: 0x1804B2220
	internal void Set(ref QueryFileListCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.PlayerDataStorage
internal struct QueryFileListCallbackInfoInternal : ICallbackInfoInternal, IGettable<QueryFileListCallbackInfo>, ISettable<QueryFileListCallbackInfo>, IDisposable // TypeDefIndex: 8989
{
	// Fields
	private Result m_ResultCode; // 0x0
	private IntPtr m_ClientData; // 0x8
	private IntPtr m_LocalUserId; // 0x10
	private uint m_FileCount; // 0x18

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public ProductUserId LocalUserId { get; set; }
	public uint FileCount { get; set; }

	// Methods

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	// RVA: 0x4B2020 Offset: 0x4B1220 VA: 0x1804B2020
	public object get_ClientData() { }

	// RVA: 0x4B2110 Offset: 0x4B1310 VA: 0x1804B2110
	public void set_ClientData(object value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x4B2090 Offset: 0x4B1290 VA: 0x1804B2090
	public ProductUserId get_LocalUserId() { }

	// RVA: 0x4B2170 Offset: 0x4B1370 VA: 0x1804B2170
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public uint get_FileCount() { }

	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	public void set_FileCount(uint value) { }

	// RVA: 0x4B1F60 Offset: 0x4B1160 VA: 0x1804B1F60 Slot: 6
	public void Set(ref QueryFileListCallbackInfo other) { }

	// RVA: 0x4B1E30 Offset: 0x4B1030 VA: 0x1804B1E30 Slot: 7
	public void Set(ref Nullable<QueryFileListCallbackInfo> other) { }

	// RVA: 0x4B1DB0 Offset: 0x4B0FB0 VA: 0x1804B1DB0 Slot: 8
	public void Dispose() { }

	// RVA: 0x4B1E10 Offset: 0x4B1010 VA: 0x1804B1E10 Slot: 5
	public void Get(out QueryFileListCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.PlayerDataStorage
public struct QueryFileListOptions // TypeDefIndex: 8990
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x0

	// Properties
	public ProductUserId LocalUserId { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_LocalUserId(ProductUserId value) { }
}

// Namespace: Epic.OnlineServices.PlayerDataStorage
internal struct QueryFileListOptionsInternal : ISettable<QueryFileListOptions>, IDisposable // TypeDefIndex: 8991
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8

	// Properties
	public ProductUserId LocalUserId { set; }

	// Methods

	// RVA: 0x4B2410 Offset: 0x4B1610 VA: 0x1804B2410
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x4B23B0 Offset: 0x4B15B0 VA: 0x1804B23B0 Slot: 4
	public void Set(ref QueryFileListOptions other) { }

	// RVA: 0x4B2310 Offset: 0x4B1510 VA: 0x1804B2310 Slot: 5
	public void Set(ref Nullable<QueryFileListOptions> other) { }

	// RVA: 0x4B22C0 Offset: 0x4B14C0 VA: 0x1804B22C0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.PlayerDataStorage
public struct QueryFileOptions // TypeDefIndex: 8992
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <Filename>k__BackingField; // 0x8

	// Properties
	public ProductUserId LocalUserId { get; set; }
	public Utf8String Filename { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_LocalUserId(ProductUserId value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public Utf8String get_Filename() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_Filename(Utf8String value) { }
}

// Namespace: Epic.OnlineServices.PlayerDataStorage
internal struct QueryFileOptionsInternal : ISettable<QueryFileOptions>, IDisposable // TypeDefIndex: 8993
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_Filename; // 0x10

	// Properties
	public ProductUserId LocalUserId { set; }
	public Utf8String Filename { set; }

	// Methods

	// RVA: 0x4B26F0 Offset: 0x4B18F0 VA: 0x1804B26F0
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x4B2690 Offset: 0x4B1890 VA: 0x1804B2690
	public void set_Filename(Utf8String value) { }

	// RVA: 0x4B24D0 Offset: 0x4B16D0 VA: 0x1804B24D0 Slot: 4
	public void Set(ref QueryFileOptions other) { }

	// RVA: 0x4B2590 Offset: 0x4B1790 VA: 0x1804B2590 Slot: 5
	public void Set(ref Nullable<QueryFileOptions> other) { }

	// RVA: 0x4B2470 Offset: 0x4B1670 VA: 0x1804B2470 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.PlayerDataStorage
public struct ReadFileCallbackInfo : ICallbackInfo // TypeDefIndex: 8994
{
	// Fields
	[CompilerGenerated]
	private Result <ResultCode>k__BackingField; // 0x0
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x8
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x10
	[CompilerGenerated]
	private Utf8String <Filename>k__BackingField; // 0x18

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public ProductUserId LocalUserId { get; set; }
	public Utf8String Filename { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	[CompilerGenerated]
	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public object get_ClientData() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_ClientData(object value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_LocalUserId(ProductUserId value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public Utf8String get_Filename() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_Filename(Utf8String value) { }

	// RVA: 0x4B3610 Offset: 0x4B2810 VA: 0x1804B3610 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x4B3660 Offset: 0x4B2860 VA: 0x1804B3660
	internal void Set(ref ReadFileCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.PlayerDataStorage
internal struct ReadFileCallbackInfoInternal : ICallbackInfoInternal, IGettable<ReadFileCallbackInfo>, ISettable<ReadFileCallbackInfo>, IDisposable // TypeDefIndex: 8995
{
	// Fields
	private Result m_ResultCode; // 0x0
	private IntPtr m_ClientData; // 0x8
	private IntPtr m_LocalUserId; // 0x10
	private IntPtr m_Filename; // 0x18

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public ProductUserId LocalUserId { get; set; }
	public Utf8String Filename { get; set; }

	// Methods

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	// RVA: 0x4B3390 Offset: 0x4B2590 VA: 0x1804B3390
	public object get_ClientData() { }

	// RVA: 0x4B34F0 Offset: 0x4B26F0 VA: 0x1804B34F0
	public void set_ClientData(object value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x4B3470 Offset: 0x4B2670 VA: 0x1804B3470
	public ProductUserId get_LocalUserId() { }

	// RVA: 0x4B35B0 Offset: 0x4B27B0 VA: 0x1804B35B0
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x4B3400 Offset: 0x4B2600 VA: 0x1804B3400
	public Utf8String get_Filename() { }

	// RVA: 0x4B3550 Offset: 0x4B2750 VA: 0x1804B3550
	public void set_Filename(Utf8String value) { }

	// RVA: 0x4B3290 Offset: 0x4B2490 VA: 0x1804B3290 Slot: 6
	public void Set(ref ReadFileCallbackInfo other) { }

	// RVA: 0x4B3120 Offset: 0x4B2320 VA: 0x1804B3120 Slot: 7
	public void Set(ref Nullable<ReadFileCallbackInfo> other) { }

	// RVA: 0x4B30A0 Offset: 0x4B22A0 VA: 0x1804B30A0 Slot: 8
	public void Dispose() { }

	// RVA: 0x4B3100 Offset: 0x4B2300 VA: 0x1804B3100 Slot: 5
	public void Get(out ReadFileCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.PlayerDataStorage
public struct ReadFileDataCallbackInfo : ICallbackInfo // TypeDefIndex: 8996
{
	// Fields
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x0
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x8
	[CompilerGenerated]
	private Utf8String <Filename>k__BackingField; // 0x10
	[CompilerGenerated]
	private uint <TotalFileSizeBytes>k__BackingField; // 0x18
	[CompilerGenerated]
	private bool <IsLastChunk>k__BackingField; // 0x1C
	[CompilerGenerated]
	private ArraySegment<byte> <DataChunk>k__BackingField; // 0x20

	// Properties
	public object ClientData { get; set; }
	public ProductUserId LocalUserId { get; set; }
	public Utf8String Filename { get; set; }
	public uint TotalFileSizeBytes { get; set; }
	public bool IsLastChunk { get; set; }
	public ArraySegment<byte> DataChunk { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410 Slot: 4
	public object get_ClientData() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_ClientData(object value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_LocalUserId(ProductUserId value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Utf8String get_Filename() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_Filename(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public uint get_TotalFileSizeBytes() { }

	[CompilerGenerated]
	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	public void set_TotalFileSizeBytes(uint value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x416930 Offset: 0x415B30 VA: 0x180416930
	public bool get_IsLastChunk() { }

	[CompilerGenerated]
	// RVA: 0x416950 Offset: 0x415B50 VA: 0x180416950
	public void set_IsLastChunk(bool value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x416920 Offset: 0x415B20 VA: 0x180416920
	public ArraySegment<byte> get_DataChunk() { }

	[CompilerGenerated]
	// RVA: 0x416940 Offset: 0x415B40 VA: 0x180416940
	public void set_DataChunk(ArraySegment<byte> value) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x4B3FF0 Offset: 0x4B31F0 VA: 0x1804B3FF0
	internal void Set(ref ReadFileDataCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.PlayerDataStorage
internal struct ReadFileDataCallbackInfoInternal : ICallbackInfoInternal, IGettable<ReadFileDataCallbackInfo>, ISettable<ReadFileDataCallbackInfo>, IDisposable // TypeDefIndex: 8997
{
	// Fields
	private IntPtr m_ClientData; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_Filename; // 0x10
	private uint m_TotalFileSizeBytes; // 0x18
	private int m_IsLastChunk; // 0x1C
	private uint m_DataChunkLengthBytes; // 0x20
	private IntPtr m_DataChunk; // 0x28

	// Properties
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public ProductUserId LocalUserId { get; set; }
	public Utf8String Filename { get; set; }
	public uint TotalFileSizeBytes { get; set; }
	public bool IsLastChunk { get; set; }
	public ArraySegment<byte> DataChunk { get; set; }

	// Methods

	// RVA: 0x4B3BC0 Offset: 0x4B2DC0 VA: 0x1804B3BC0
	public object get_ClientData() { }

	// RVA: 0x4B3E00 Offset: 0x4B3000 VA: 0x1804B3E00
	public void set_ClientData(object value) { }

	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x4B3D80 Offset: 0x4B2F80 VA: 0x1804B3D80
	public ProductUserId get_LocalUserId() { }

	// RVA: 0x4B3F90 Offset: 0x4B3190 VA: 0x1804B3F90
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x4B3CB0 Offset: 0x4B2EB0 VA: 0x1804B3CB0
	public Utf8String get_Filename() { }

	// RVA: 0x4B3ED0 Offset: 0x4B30D0 VA: 0x1804B3ED0
	public void set_Filename(Utf8String value) { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public uint get_TotalFileSizeBytes() { }

	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	public void set_TotalFileSizeBytes(uint value) { }

	// RVA: 0x4B3D20 Offset: 0x4B2F20 VA: 0x1804B3D20
	public bool get_IsLastChunk() { }

	// RVA: 0x4B3F30 Offset: 0x4B3130 VA: 0x1804B3F30
	public void set_IsLastChunk(bool value) { }

	// RVA: 0x4B3C30 Offset: 0x4B2E30 VA: 0x1804B3C30
	public ArraySegment<byte> get_DataChunk() { }

	// RVA: 0x4B3E60 Offset: 0x4B3060 VA: 0x1804B3E60
	public void set_DataChunk(ArraySegment<byte> value) { }

	// RVA: 0x4B37E0 Offset: 0x4B29E0 VA: 0x1804B37E0 Slot: 6
	public void Set(ref ReadFileDataCallbackInfo other) { }

	// RVA: 0x4B3980 Offset: 0x4B2B80 VA: 0x1804B3980 Slot: 7
	public void Set(ref Nullable<ReadFileDataCallbackInfo> other) { }

	// RVA: 0x4B3750 Offset: 0x4B2950 VA: 0x1804B3750 Slot: 8
	public void Dispose() { }

	// RVA: 0x4B37C0 Offset: 0x4B29C0 VA: 0x1804B37C0 Slot: 5
	public void Get(out ReadFileDataCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.PlayerDataStorage
public struct ReadFileOptions // TypeDefIndex: 8998
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <Filename>k__BackingField; // 0x8
	[CompilerGenerated]
	private uint <ReadChunkLengthBytes>k__BackingField; // 0x10
	[CompilerGenerated]
	private OnReadFileDataCallback <ReadFileDataCallback>k__BackingField; // 0x18
	[CompilerGenerated]
	private OnFileTransferProgressCallback <FileTransferProgressCallback>k__BackingField; // 0x20

	// Properties
	public ProductUserId LocalUserId { get; set; }
	public Utf8String Filename { get; set; }
	public uint ReadChunkLengthBytes { get; set; }
	public OnReadFileDataCallback ReadFileDataCallback { get; set; }
	public OnFileTransferProgressCallback FileTransferProgressCallback { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_LocalUserId(ProductUserId value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public Utf8String get_Filename() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_Filename(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public uint get_ReadChunkLengthBytes() { }

	[CompilerGenerated]
	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_ReadChunkLengthBytes(uint value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public OnReadFileDataCallback get_ReadFileDataCallback() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_ReadFileDataCallback(OnReadFileDataCallback value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public OnFileTransferProgressCallback get_FileTransferProgressCallback() { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_FileTransferProgressCallback(OnFileTransferProgressCallback value) { }
}

// Namespace: Epic.OnlineServices.PlayerDataStorage
internal struct ReadFileOptionsInternal : ISettable<ReadFileOptions>, IDisposable // TypeDefIndex: 8999
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_Filename; // 0x10
	private uint m_ReadChunkLengthBytes; // 0x18
	private IntPtr m_ReadFileDataCallback; // 0x20
	private IntPtr m_FileTransferProgressCallback; // 0x28
	private static OnReadFileDataCallbackInternal s_ReadFileDataCallback; // 0x0
	private static OnFileTransferProgressCallbackInternal s_FileTransferProgressCallback; // 0x8

	// Properties
	public ProductUserId LocalUserId { set; }
	public Utf8String Filename { set; }
	public uint ReadChunkLengthBytes { set; }
	public static OnReadFileDataCallbackInternal ReadFileDataCallback { get; }
	public static OnFileTransferProgressCallbackInternal FileTransferProgressCallback { get; }

	// Methods

	// RVA: 0x4B4820 Offset: 0x4B3A20 VA: 0x1804B4820
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x4B47C0 Offset: 0x4B39C0 VA: 0x1804B47C0
	public void set_Filename(Utf8String value) { }

	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	public void set_ReadChunkLengthBytes(uint value) { }

	// RVA: 0x4B46A0 Offset: 0x4B38A0 VA: 0x1804B46A0
	public static OnReadFileDataCallbackInternal get_ReadFileDataCallback() { }

	// RVA: 0x4B4580 Offset: 0x4B3780 VA: 0x1804B4580
	public static OnFileTransferProgressCallbackInternal get_FileTransferProgressCallback() { }

	// RVA: 0x4B4400 Offset: 0x4B3600 VA: 0x1804B4400 Slot: 4
	public void Set(ref ReadFileOptions other) { }

	// RVA: 0x4B4200 Offset: 0x4B3400 VA: 0x1804B4200 Slot: 5
	public void Set(ref Nullable<ReadFileOptions> other) { }

	// RVA: 0x4B4190 Offset: 0x4B3390 VA: 0x1804B4190 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.PlayerDataStorage
public enum ReadResult // TypeDefIndex: 9000
{
	// Fields
	public int value__; // 0x0
	public const ReadResult ContinueReading = 1;
	public const ReadResult FailRequest = 2;
	public const ReadResult CancelRequest = 3;
}

// Namespace: Epic.OnlineServices.PlayerDataStorage
public struct WriteFileCallbackInfo : ICallbackInfo // TypeDefIndex: 9001
{
	// Fields
	[CompilerGenerated]
	private Result <ResultCode>k__BackingField; // 0x0
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x8
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x10
	[CompilerGenerated]
	private Utf8String <Filename>k__BackingField; // 0x18

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public ProductUserId LocalUserId { get; set; }
	public Utf8String Filename { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	[CompilerGenerated]
	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public object get_ClientData() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_ClientData(object value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_LocalUserId(ProductUserId value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public Utf8String get_Filename() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_Filename(Utf8String value) { }

	// RVA: 0x4B5A90 Offset: 0x4B4C90 VA: 0x1804B5A90 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x4B5AE0 Offset: 0x4B4CE0 VA: 0x1804B5AE0
	internal void Set(ref WriteFileCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.PlayerDataStorage
internal struct WriteFileCallbackInfoInternal : ICallbackInfoInternal, IGettable<WriteFileCallbackInfo>, ISettable<WriteFileCallbackInfo>, IDisposable // TypeDefIndex: 9002
{
	// Fields
	private Result m_ResultCode; // 0x0
	private IntPtr m_ClientData; // 0x8
	private IntPtr m_LocalUserId; // 0x10
	private IntPtr m_Filename; // 0x18

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public ProductUserId LocalUserId { get; set; }
	public Utf8String Filename { get; set; }

	// Methods

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	// RVA: 0x4B5810 Offset: 0x4B4A10 VA: 0x1804B5810
	public object get_ClientData() { }

	// RVA: 0x4B5970 Offset: 0x4B4B70 VA: 0x1804B5970
	public void set_ClientData(object value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x4B58F0 Offset: 0x4B4AF0 VA: 0x1804B58F0
	public ProductUserId get_LocalUserId() { }

	// RVA: 0x4B5A30 Offset: 0x4B4C30 VA: 0x1804B5A30
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x4B5880 Offset: 0x4B4A80 VA: 0x1804B5880
	public Utf8String get_Filename() { }

	// RVA: 0x4B59D0 Offset: 0x4B4BD0 VA: 0x1804B59D0
	public void set_Filename(Utf8String value) { }

	// RVA: 0x4B55A0 Offset: 0x4B47A0 VA: 0x1804B55A0 Slot: 6
	public void Set(ref WriteFileCallbackInfo other) { }

	// RVA: 0x4B56A0 Offset: 0x4B48A0 VA: 0x1804B56A0 Slot: 7
	public void Set(ref Nullable<WriteFileCallbackInfo> other) { }

	// RVA: 0x4B5520 Offset: 0x4B4720 VA: 0x1804B5520 Slot: 8
	public void Dispose() { }

	// RVA: 0x4B5580 Offset: 0x4B4780 VA: 0x1804B5580 Slot: 5
	public void Get(out WriteFileCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.PlayerDataStorage
public struct WriteFileDataCallbackInfo : ICallbackInfo // TypeDefIndex: 9003
{
	// Fields
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x0
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x8
	[CompilerGenerated]
	private Utf8String <Filename>k__BackingField; // 0x10
	[CompilerGenerated]
	private uint <DataBufferLengthBytes>k__BackingField; // 0x18

	// Properties
	public object ClientData { get; set; }
	public ProductUserId LocalUserId { get; set; }
	public Utf8String Filename { get; set; }
	public uint DataBufferLengthBytes { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410 Slot: 4
	public object get_ClientData() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_ClientData(object value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_LocalUserId(ProductUserId value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Utf8String get_Filename() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_Filename(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public uint get_DataBufferLengthBytes() { }

	[CompilerGenerated]
	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	public void set_DataBufferLengthBytes(uint value) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x4B6140 Offset: 0x4B5340 VA: 0x1804B6140
	internal void Set(ref WriteFileDataCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.PlayerDataStorage
internal struct WriteFileDataCallbackInfoInternal : ICallbackInfoInternal, IGettable<WriteFileDataCallbackInfo>, ISettable<WriteFileDataCallbackInfo>, IDisposable // TypeDefIndex: 9004
{
	// Fields
	private IntPtr m_ClientData; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_Filename; // 0x10
	private uint m_DataBufferLengthBytes; // 0x18

	// Properties
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public ProductUserId LocalUserId { get; set; }
	public Utf8String Filename { get; set; }
	public uint DataBufferLengthBytes { get; set; }

	// Methods

	// RVA: 0x4B5EC0 Offset: 0x4B50C0 VA: 0x1804B5EC0
	public object get_ClientData() { }

	// RVA: 0x4B6020 Offset: 0x4B5220 VA: 0x1804B6020
	public void set_ClientData(object value) { }

	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x4B5FA0 Offset: 0x4B51A0 VA: 0x1804B5FA0
	public ProductUserId get_LocalUserId() { }

	// RVA: 0x4B60E0 Offset: 0x4B52E0 VA: 0x1804B60E0
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x4B5F30 Offset: 0x4B5130 VA: 0x1804B5F30
	public Utf8String get_Filename() { }

	// RVA: 0x4B6080 Offset: 0x4B5280 VA: 0x1804B6080
	public void set_Filename(Utf8String value) { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public uint get_DataBufferLengthBytes() { }

	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	public void set_DataBufferLengthBytes(uint value) { }

	// RVA: 0x4B5DC0 Offset: 0x4B4FC0 VA: 0x1804B5DC0 Slot: 6
	public void Set(ref WriteFileDataCallbackInfo other) { }

	// RVA: 0x4B5C50 Offset: 0x4B4E50 VA: 0x1804B5C50 Slot: 7
	public void Set(ref Nullable<WriteFileDataCallbackInfo> other) { }

	// RVA: 0x4B5BD0 Offset: 0x4B4DD0 VA: 0x1804B5BD0 Slot: 8
	public void Dispose() { }

	// RVA: 0x4B5C30 Offset: 0x4B4E30 VA: 0x1804B5C30 Slot: 5
	public void Get(out WriteFileDataCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.PlayerDataStorage
public struct WriteFileOptions // TypeDefIndex: 9005
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <Filename>k__BackingField; // 0x8
	[CompilerGenerated]
	private uint <ChunkLengthBytes>k__BackingField; // 0x10
	[CompilerGenerated]
	private OnWriteFileDataCallback <WriteFileDataCallback>k__BackingField; // 0x18
	[CompilerGenerated]
	private OnFileTransferProgressCallback <FileTransferProgressCallback>k__BackingField; // 0x20

	// Properties
	public ProductUserId LocalUserId { get; set; }
	public Utf8String Filename { get; set; }
	public uint ChunkLengthBytes { get; set; }
	public OnWriteFileDataCallback WriteFileDataCallback { get; set; }
	public OnFileTransferProgressCallback FileTransferProgressCallback { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_LocalUserId(ProductUserId value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public Utf8String get_Filename() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_Filename(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public uint get_ChunkLengthBytes() { }

	[CompilerGenerated]
	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_ChunkLengthBytes(uint value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public OnWriteFileDataCallback get_WriteFileDataCallback() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_WriteFileDataCallback(OnWriteFileDataCallback value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public OnFileTransferProgressCallback get_FileTransferProgressCallback() { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_FileTransferProgressCallback(OnFileTransferProgressCallback value) { }
}

// Namespace: Epic.OnlineServices.PlayerDataStorage
internal struct WriteFileOptionsInternal : ISettable<WriteFileOptions>, IDisposable // TypeDefIndex: 9006
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_Filename; // 0x10
	private uint m_ChunkLengthBytes; // 0x18
	private IntPtr m_WriteFileDataCallback; // 0x20
	private IntPtr m_FileTransferProgressCallback; // 0x28
	private static OnWriteFileDataCallbackInternal s_WriteFileDataCallback; // 0x0
	private static OnFileTransferProgressCallbackInternal s_FileTransferProgressCallback; // 0x8

	// Properties
	public ProductUserId LocalUserId { set; }
	public Utf8String Filename { set; }
	public uint ChunkLengthBytes { set; }
	public static OnWriteFileDataCallbackInternal WriteFileDataCallback { get; }
	public static OnFileTransferProgressCallbackInternal FileTransferProgressCallback { get; }

	// Methods

	// RVA: 0x4B68C0 Offset: 0x4B5AC0 VA: 0x1804B68C0
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x4B6860 Offset: 0x4B5A60 VA: 0x1804B6860
	public void set_Filename(Utf8String value) { }

	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	public void set_ChunkLengthBytes(uint value) { }

	// RVA: 0x4B6740 Offset: 0x4B5940 VA: 0x1804B6740
	public static OnWriteFileDataCallbackInternal get_WriteFileDataCallback() { }

	// RVA: 0x4B6620 Offset: 0x4B5820 VA: 0x1804B6620
	public static OnFileTransferProgressCallbackInternal get_FileTransferProgressCallback() { }

	// RVA: 0x4B64A0 Offset: 0x4B56A0 VA: 0x1804B64A0 Slot: 4
	public void Set(ref WriteFileOptions other) { }

	// RVA: 0x4B62A0 Offset: 0x4B54A0 VA: 0x1804B62A0 Slot: 5
	public void Set(ref Nullable<WriteFileOptions> other) { }

	// RVA: 0x4B6230 Offset: 0x4B5430 VA: 0x1804B6230 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.PlayerDataStorage
public enum WriteResult // TypeDefIndex: 9007
{
	// Fields
	public int value__; // 0x0
	public const WriteResult ContinueWriting = 1;
	public const WriteResult CompleteRequest = 2;
	public const WriteResult FailRequest = 3;
	public const WriteResult CancelRequest = 4;
}

// Namespace: Epic.OnlineServices.P2P
public struct AcceptConnectionOptions // TypeDefIndex: 9008
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private ProductUserId <RemoteUserId>k__BackingField; // 0x8
	[CompilerGenerated]
	private Nullable<SocketId> <SocketId>k__BackingField; // 0x10

	// Properties
	public ProductUserId LocalUserId { get; set; }
	public ProductUserId RemoteUserId { get; set; }
	public Nullable<SocketId> SocketId { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_LocalUserId(ProductUserId value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public ProductUserId get_RemoteUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_RemoteUserId(ProductUserId value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x4A1870 Offset: 0x4A0A70 VA: 0x1804A1870
	public Nullable<SocketId> get_SocketId() { }

	[CompilerGenerated]
	// RVA: 0x4A1890 Offset: 0x4A0A90 VA: 0x1804A1890
	public void set_SocketId(Nullable<SocketId> value) { }
}

// Namespace: Epic.OnlineServices.P2P
internal struct AcceptConnectionOptionsInternal : ISettable<AcceptConnectionOptions>, IDisposable // TypeDefIndex: 9009
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_RemoteUserId; // 0x10
	private IntPtr m_SocketId; // 0x18

	// Properties
	public ProductUserId LocalUserId { set; }
	public ProductUserId RemoteUserId { set; }
	public Nullable<SocketId> SocketId { set; }

	// Methods

	// RVA: 0x4A1740 Offset: 0x4A0940 VA: 0x1804A1740
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x4A17A0 Offset: 0x4A09A0 VA: 0x1804A17A0
	public void set_RemoteUserId(ProductUserId value) { }

	// RVA: 0x4A1800 Offset: 0x4A0A00 VA: 0x1804A1800
	public void set_SocketId(Nullable<SocketId> value) { }

	// RVA: 0x4A1610 Offset: 0x4A0810 VA: 0x1804A1610 Slot: 4
	public void Set(ref AcceptConnectionOptions other) { }

	// RVA: 0x4A1480 Offset: 0x4A0680 VA: 0x1804A1480 Slot: 5
	public void Set(ref Nullable<AcceptConnectionOptions> other) { }

	// RVA: 0x4A1420 Offset: 0x4A0620 VA: 0x1804A1420 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.P2P
public struct AddNotifyIncomingPacketQueueFullOptions // TypeDefIndex: 9010
{}

// Namespace: Epic.OnlineServices.P2P
internal struct AddNotifyIncomingPacketQueueFullOptionsInternal : ISettable<AddNotifyIncomingPacketQueueFullOptions>, IDisposable // TypeDefIndex: 9011
{
	// Fields
	private int m_ApiVersion; // 0x0

	// Methods

	// RVA: 0x3F98A0 Offset: 0x3F8AA0 VA: 0x1803F98A0 Slot: 4
	public void Set(ref AddNotifyIncomingPacketQueueFullOptions other) { }

	// RVA: 0x4A18B0 Offset: 0x4A0AB0 VA: 0x1804A18B0 Slot: 5
	public void Set(ref Nullable<AddNotifyIncomingPacketQueueFullOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.P2P
public struct AddNotifyPeerConnectionClosedOptions // TypeDefIndex: 9012
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private Nullable<SocketId> <SocketId>k__BackingField; // 0x8

	// Properties
	public ProductUserId LocalUserId { get; set; }
	public Nullable<SocketId> SocketId { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_LocalUserId(ProductUserId value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x4A1CF0 Offset: 0x4A0EF0 VA: 0x1804A1CF0
	public Nullable<SocketId> get_SocketId() { }

	[CompilerGenerated]
	// RVA: 0x4A1D10 Offset: 0x4A0F10 VA: 0x1804A1D10
	public void set_SocketId(Nullable<SocketId> value) { }
}

// Namespace: Epic.OnlineServices.P2P
internal struct AddNotifyPeerConnectionClosedOptionsInternal : ISettable<AddNotifyPeerConnectionClosedOptions>, IDisposable // TypeDefIndex: 9013
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_SocketId; // 0x10

	// Properties
	public ProductUserId LocalUserId { set; }
	public Nullable<SocketId> SocketId { set; }

	// Methods

	// RVA: 0x4A1C20 Offset: 0x4A0E20 VA: 0x1804A1C20
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x4A1C80 Offset: 0x4A0E80 VA: 0x1804A1C80
	public void set_SocketId(Nullable<SocketId> value) { }

	// RVA: 0x4A1B40 Offset: 0x4A0D40 VA: 0x1804A1B40 Slot: 4
	public void Set(ref AddNotifyPeerConnectionClosedOptions other) { }

	// RVA: 0x4A1A00 Offset: 0x4A0C00 VA: 0x1804A1A00 Slot: 5
	public void Set(ref Nullable<AddNotifyPeerConnectionClosedOptions> other) { }

	// RVA: 0x4A19A0 Offset: 0x4A0BA0 VA: 0x1804A19A0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.P2P
public struct AddNotifyPeerConnectionEstablishedOptions // TypeDefIndex: 9014
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private Nullable<SocketId> <SocketId>k__BackingField; // 0x8

	// Properties
	public ProductUserId LocalUserId { get; set; }
	public Nullable<SocketId> SocketId { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_LocalUserId(ProductUserId value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x4A1CF0 Offset: 0x4A0EF0 VA: 0x1804A1CF0
	public Nullable<SocketId> get_SocketId() { }

	[CompilerGenerated]
	// RVA: 0x4A1D10 Offset: 0x4A0F10 VA: 0x1804A1D10
	public void set_SocketId(Nullable<SocketId> value) { }
}

// Namespace: Epic.OnlineServices.P2P
internal struct AddNotifyPeerConnectionEstablishedOptionsInternal : ISettable<AddNotifyPeerConnectionEstablishedOptions>, IDisposable // TypeDefIndex: 9015
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_SocketId; // 0x10

	// Properties
	public ProductUserId LocalUserId { set; }
	public Nullable<SocketId> SocketId { set; }

	// Methods

	// RVA: 0x4A1FB0 Offset: 0x4A11B0 VA: 0x1804A1FB0
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x4A2010 Offset: 0x4A1210 VA: 0x1804A2010
	public void set_SocketId(Nullable<SocketId> value) { }

	// RVA: 0x4A1D90 Offset: 0x4A0F90 VA: 0x1804A1D90 Slot: 4
	public void Set(ref AddNotifyPeerConnectionEstablishedOptions other) { }

	// RVA: 0x4A1E70 Offset: 0x4A1070 VA: 0x1804A1E70 Slot: 5
	public void Set(ref Nullable<AddNotifyPeerConnectionEstablishedOptions> other) { }

	// RVA: 0x4A1D30 Offset: 0x4A0F30 VA: 0x1804A1D30 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.P2P
public struct AddNotifyPeerConnectionInterruptedOptions // TypeDefIndex: 9016
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private Nullable<SocketId> <SocketId>k__BackingField; // 0x8

	// Properties
	public ProductUserId LocalUserId { get; set; }
	public Nullable<SocketId> SocketId { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_LocalUserId(ProductUserId value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x4A1CF0 Offset: 0x4A0EF0 VA: 0x1804A1CF0
	public Nullable<SocketId> get_SocketId() { }

	[CompilerGenerated]
	// RVA: 0x4A1D10 Offset: 0x4A0F10 VA: 0x1804A1D10
	public void set_SocketId(Nullable<SocketId> value) { }
}

// Namespace: Epic.OnlineServices.P2P
internal struct AddNotifyPeerConnectionInterruptedOptionsInternal : ISettable<AddNotifyPeerConnectionInterruptedOptions>, IDisposable // TypeDefIndex: 9017
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_SocketId; // 0x10

	// Properties
	public ProductUserId LocalUserId { set; }
	public Nullable<SocketId> SocketId { set; }

	// Methods

	// RVA: 0x4A2300 Offset: 0x4A1500 VA: 0x1804A2300
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x4A2360 Offset: 0x4A1560 VA: 0x1804A2360
	public void set_SocketId(Nullable<SocketId> value) { }

	// RVA: 0x4A2220 Offset: 0x4A1420 VA: 0x1804A2220 Slot: 4
	public void Set(ref AddNotifyPeerConnectionInterruptedOptions other) { }

	// RVA: 0x4A20E0 Offset: 0x4A12E0 VA: 0x1804A20E0 Slot: 5
	public void Set(ref Nullable<AddNotifyPeerConnectionInterruptedOptions> other) { }

	// RVA: 0x4A2080 Offset: 0x4A1280 VA: 0x1804A2080 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.P2P
public struct AddNotifyPeerConnectionRequestOptions // TypeDefIndex: 9018
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private Nullable<SocketId> <SocketId>k__BackingField; // 0x8

	// Properties
	public ProductUserId LocalUserId { get; set; }
	public Nullable<SocketId> SocketId { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_LocalUserId(ProductUserId value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x4A1CF0 Offset: 0x4A0EF0 VA: 0x1804A1CF0
	public Nullable<SocketId> get_SocketId() { }

	[CompilerGenerated]
	// RVA: 0x4A1D10 Offset: 0x4A0F10 VA: 0x1804A1D10
	public void set_SocketId(Nullable<SocketId> value) { }
}

// Namespace: Epic.OnlineServices.P2P
internal struct AddNotifyPeerConnectionRequestOptionsInternal : ISettable<AddNotifyPeerConnectionRequestOptions>, IDisposable // TypeDefIndex: 9019
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_SocketId; // 0x10

	// Properties
	public ProductUserId LocalUserId { set; }
	public Nullable<SocketId> SocketId { set; }

	// Methods

	// RVA: 0x4A2650 Offset: 0x4A1850 VA: 0x1804A2650
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x4A26B0 Offset: 0x4A18B0 VA: 0x1804A26B0
	public void set_SocketId(Nullable<SocketId> value) { }

	// RVA: 0x4A2430 Offset: 0x4A1630 VA: 0x1804A2430 Slot: 4
	public void Set(ref AddNotifyPeerConnectionRequestOptions other) { }

	// RVA: 0x4A2510 Offset: 0x4A1710 VA: 0x1804A2510 Slot: 5
	public void Set(ref Nullable<AddNotifyPeerConnectionRequestOptions> other) { }

	// RVA: 0x4A23D0 Offset: 0x4A15D0 VA: 0x1804A23D0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.P2P
public struct ClearPacketQueueOptions // TypeDefIndex: 9020
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private ProductUserId <RemoteUserId>k__BackingField; // 0x8
	[CompilerGenerated]
	private Nullable<SocketId> <SocketId>k__BackingField; // 0x10

	// Properties
	public ProductUserId LocalUserId { get; set; }
	public ProductUserId RemoteUserId { get; set; }
	public Nullable<SocketId> SocketId { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_LocalUserId(ProductUserId value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public ProductUserId get_RemoteUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_RemoteUserId(ProductUserId value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x4A1870 Offset: 0x4A0A70 VA: 0x1804A1870
	public Nullable<SocketId> get_SocketId() { }

	[CompilerGenerated]
	// RVA: 0x4A1890 Offset: 0x4A0A90 VA: 0x1804A1890
	public void set_SocketId(Nullable<SocketId> value) { }
}

// Namespace: Epic.OnlineServices.P2P
internal struct ClearPacketQueueOptionsInternal : ISettable<ClearPacketQueueOptions>, IDisposable // TypeDefIndex: 9021
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_RemoteUserId; // 0x10
	private IntPtr m_SocketId; // 0x18

	// Properties
	public ProductUserId LocalUserId { set; }
	public ProductUserId RemoteUserId { set; }
	public Nullable<SocketId> SocketId { set; }

	// Methods

	// RVA: 0x4A2EF0 Offset: 0x4A20F0 VA: 0x1804A2EF0
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x4A2F50 Offset: 0x4A2150 VA: 0x1804A2F50
	public void set_RemoteUserId(ProductUserId value) { }

	// RVA: 0x4A2FB0 Offset: 0x4A21B0 VA: 0x1804A2FB0
	public void set_SocketId(Nullable<SocketId> value) { }

	// RVA: 0x4A2DC0 Offset: 0x4A1FC0 VA: 0x1804A2DC0 Slot: 4
	public void Set(ref ClearPacketQueueOptions other) { }

	// RVA: 0x4A2C30 Offset: 0x4A1E30 VA: 0x1804A2C30 Slot: 5
	public void Set(ref Nullable<ClearPacketQueueOptions> other) { }

	// RVA: 0x4A2BD0 Offset: 0x4A1DD0 VA: 0x1804A2BD0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.P2P
public struct CloseConnectionOptions // TypeDefIndex: 9022
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private ProductUserId <RemoteUserId>k__BackingField; // 0x8
	[CompilerGenerated]
	private Nullable<SocketId> <SocketId>k__BackingField; // 0x10

	// Properties
	public ProductUserId LocalUserId { get; set; }
	public ProductUserId RemoteUserId { get; set; }
	public Nullable<SocketId> SocketId { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_LocalUserId(ProductUserId value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public ProductUserId get_RemoteUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_RemoteUserId(ProductUserId value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x4A1870 Offset: 0x4A0A70 VA: 0x1804A1870
	public Nullable<SocketId> get_SocketId() { }

	[CompilerGenerated]
	// RVA: 0x4A1890 Offset: 0x4A0A90 VA: 0x1804A1890
	public void set_SocketId(Nullable<SocketId> value) { }
}

// Namespace: Epic.OnlineServices.P2P
internal struct CloseConnectionOptionsInternal : ISettable<CloseConnectionOptions>, IDisposable // TypeDefIndex: 9023
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_RemoteUserId; // 0x10
	private IntPtr m_SocketId; // 0x18

	// Properties
	public ProductUserId LocalUserId { set; }
	public ProductUserId RemoteUserId { set; }
	public Nullable<SocketId> SocketId { set; }

	// Methods

	// RVA: 0x4A3340 Offset: 0x4A2540 VA: 0x1804A3340
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x4A33A0 Offset: 0x4A25A0 VA: 0x1804A33A0
	public void set_RemoteUserId(ProductUserId value) { }

	// RVA: 0x4A3400 Offset: 0x4A2600 VA: 0x1804A3400
	public void set_SocketId(Nullable<SocketId> value) { }

	// RVA: 0x4A3210 Offset: 0x4A2410 VA: 0x1804A3210 Slot: 4
	public void Set(ref CloseConnectionOptions other) { }

	// RVA: 0x4A3080 Offset: 0x4A2280 VA: 0x1804A3080 Slot: 5
	public void Set(ref Nullable<CloseConnectionOptions> other) { }

	// RVA: 0x4A3020 Offset: 0x4A2220 VA: 0x1804A3020 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.P2P
public struct CloseConnectionsOptions // TypeDefIndex: 9024
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private Nullable<SocketId> <SocketId>k__BackingField; // 0x8

	// Properties
	public ProductUserId LocalUserId { get; set; }
	public Nullable<SocketId> SocketId { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_LocalUserId(ProductUserId value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x4A1CF0 Offset: 0x4A0EF0 VA: 0x1804A1CF0
	public Nullable<SocketId> get_SocketId() { }

	[CompilerGenerated]
	// RVA: 0x4A1D10 Offset: 0x4A0F10 VA: 0x1804A1D10
	public void set_SocketId(Nullable<SocketId> value) { }
}

// Namespace: Epic.OnlineServices.P2P
internal struct CloseConnectionsOptionsInternal : ISettable<CloseConnectionsOptions>, IDisposable // TypeDefIndex: 9025
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_SocketId; // 0x10

	// Properties
	public ProductUserId LocalUserId { set; }
	public Nullable<SocketId> SocketId { set; }

	// Methods

	// RVA: 0x4A36F0 Offset: 0x4A28F0 VA: 0x1804A36F0
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x4A3750 Offset: 0x4A2950 VA: 0x1804A3750
	public void set_SocketId(Nullable<SocketId> value) { }

	// RVA: 0x4A34D0 Offset: 0x4A26D0 VA: 0x1804A34D0 Slot: 4
	public void Set(ref CloseConnectionsOptions other) { }

	// RVA: 0x4A35B0 Offset: 0x4A27B0 VA: 0x1804A35B0 Slot: 5
	public void Set(ref Nullable<CloseConnectionsOptions> other) { }

	// RVA: 0x4A3470 Offset: 0x4A2670 VA: 0x1804A3470 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.P2P
public enum ConnectionClosedReason // TypeDefIndex: 9026
{
	// Fields
	public int value__; // 0x0
	public const ConnectionClosedReason Unknown = 0;
	public const ConnectionClosedReason ClosedByLocalUser = 1;
	public const ConnectionClosedReason ClosedByPeer = 2;
	public const ConnectionClosedReason TimedOut = 3;
	public const ConnectionClosedReason TooManyConnections = 4;
	public const ConnectionClosedReason InvalidMessage = 5;
	public const ConnectionClosedReason InvalidData = 6;
	public const ConnectionClosedReason ConnectionFailed = 7;
	public const ConnectionClosedReason ConnectionClosed = 8;
	public const ConnectionClosedReason NegotiationFailed = 9;
	public const ConnectionClosedReason UnexpectedError = 10;
	public const ConnectionClosedReason ConnectionIgnored = 11;
}

// Namespace: Epic.OnlineServices.P2P
public enum ConnectionEstablishedType // TypeDefIndex: 9027
{
	// Fields
	public int value__; // 0x0
	public const ConnectionEstablishedType NewConnection = 0;
	public const ConnectionEstablishedType Reconnection = 1;
}

// Namespace: Epic.OnlineServices.P2P
public struct GetNATTypeOptions // TypeDefIndex: 9028
{}

// Namespace: Epic.OnlineServices.P2P
internal struct GetNATTypeOptionsInternal : ISettable<GetNATTypeOptions>, IDisposable // TypeDefIndex: 9029
{
	// Fields
	private int m_ApiVersion; // 0x0

	// Methods

	// RVA: 0x3F98A0 Offset: 0x3F8AA0 VA: 0x1803F98A0 Slot: 4
	public void Set(ref GetNATTypeOptions other) { }

	// RVA: 0x4A7630 Offset: 0x4A6830 VA: 0x1804A7630 Slot: 5
	public void Set(ref Nullable<GetNATTypeOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.P2P
public struct GetPacketQueueInfoOptions // TypeDefIndex: 9030
{}

// Namespace: Epic.OnlineServices.P2P
internal struct GetPacketQueueInfoOptionsInternal : ISettable<GetPacketQueueInfoOptions>, IDisposable // TypeDefIndex: 9031
{
	// Fields
	private int m_ApiVersion; // 0x0

	// Methods

	// RVA: 0x3F98A0 Offset: 0x3F8AA0 VA: 0x1803F98A0 Slot: 4
	public void Set(ref GetPacketQueueInfoOptions other) { }

	// RVA: 0x4A7680 Offset: 0x4A6880 VA: 0x1804A7680 Slot: 5
	public void Set(ref Nullable<GetPacketQueueInfoOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.P2P
public struct GetPortRangeOptions // TypeDefIndex: 9032
{}

// Namespace: Epic.OnlineServices.P2P
internal struct GetPortRangeOptionsInternal : ISettable<GetPortRangeOptions>, IDisposable // TypeDefIndex: 9033
{
	// Fields
	private int m_ApiVersion; // 0x0

	// Methods

	// RVA: 0x3F98A0 Offset: 0x3F8AA0 VA: 0x1803F98A0 Slot: 4
	public void Set(ref GetPortRangeOptions other) { }

	// RVA: 0x4A76D0 Offset: 0x4A68D0 VA: 0x1804A76D0 Slot: 5
	public void Set(ref Nullable<GetPortRangeOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.P2P
public struct GetRelayControlOptions // TypeDefIndex: 9034
{}

// Namespace: Epic.OnlineServices.P2P
internal struct GetRelayControlOptionsInternal : ISettable<GetRelayControlOptions>, IDisposable // TypeDefIndex: 9035
{
	// Fields
	private int m_ApiVersion; // 0x0

	// Methods

	// RVA: 0x3F98A0 Offset: 0x3F8AA0 VA: 0x1803F98A0 Slot: 4
	public void Set(ref GetRelayControlOptions other) { }

	// RVA: 0x4A7720 Offset: 0x4A6920 VA: 0x1804A7720 Slot: 5
	public void Set(ref Nullable<GetRelayControlOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.P2P
public enum NATType // TypeDefIndex: 9036
{
	// Fields
	public int value__; // 0x0
	public const NATType Unknown = 0;
	public const NATType Open = 1;
	public const NATType Moderate = 2;
	public const NATType Strict = 3;
}

// Namespace: Epic.OnlineServices.P2P
public enum NetworkConnectionType // TypeDefIndex: 9037
{
	// Fields
	public int value__; // 0x0
	public const NetworkConnectionType NoConnection = 0;
	public const NetworkConnectionType DirectConnection = 1;
	public const NetworkConnectionType RelayedConnection = 2;
}

// Namespace: Epic.OnlineServices.P2P
public sealed class OnIncomingConnectionRequestCallback : MulticastDelegate // TypeDefIndex: 9038
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref OnIncomingConnectionRequestInfo data) { }

	// RVA: 0x4A9830 Offset: 0x4A8A30 VA: 0x1804A9830 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref OnIncomingConnectionRequestInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref OnIncomingConnectionRequestInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.P2P
[UnmanagedFunctionPointer(2)]
internal sealed class OnIncomingConnectionRequestCallbackInternal : MulticastDelegate // TypeDefIndex: 9039
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref OnIncomingConnectionRequestInfoInternal data) { }

	// RVA: 0x4A97A0 Offset: 0x4A89A0 VA: 0x1804A97A0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref OnIncomingConnectionRequestInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref OnIncomingConnectionRequestInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.P2P
public struct OnIncomingConnectionRequestInfo : ICallbackInfo // TypeDefIndex: 9040
{
	// Fields
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x0
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x8
	[CompilerGenerated]
	private ProductUserId <RemoteUserId>k__BackingField; // 0x10
	[CompilerGenerated]
	private Nullable<SocketId> <SocketId>k__BackingField; // 0x18

	// Properties
	public object ClientData { get; set; }
	public ProductUserId LocalUserId { get; set; }
	public ProductUserId RemoteUserId { get; set; }
	public Nullable<SocketId> SocketId { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410 Slot: 4
	public object get_ClientData() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_ClientData(object value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_LocalUserId(ProductUserId value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public ProductUserId get_RemoteUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_RemoteUserId(ProductUserId value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x41A1E0 Offset: 0x4193E0 VA: 0x18041A1E0
	public Nullable<SocketId> get_SocketId() { }

	[CompilerGenerated]
	// RVA: 0x41A210 Offset: 0x419410 VA: 0x18041A210
	public void set_SocketId(Nullable<SocketId> value) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x4AA020 Offset: 0x4A9220 VA: 0x1804AA020
	internal void Set(ref OnIncomingConnectionRequestInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.P2P
internal struct OnIncomingConnectionRequestInfoInternal : ICallbackInfoInternal, IGettable<OnIncomingConnectionRequestInfo>, ISettable<OnIncomingConnectionRequestInfo>, IDisposable // TypeDefIndex: 9041
{
	// Fields
	private IntPtr m_ClientData; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_RemoteUserId; // 0x10
	private IntPtr m_SocketId; // 0x18

	// Properties
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public ProductUserId LocalUserId { get; set; }
	public ProductUserId RemoteUserId { get; set; }
	public Nullable<SocketId> SocketId { get; set; }

	// Methods

	// RVA: 0x4A9CA0 Offset: 0x4A8EA0 VA: 0x1804A9CA0
	public object get_ClientData() { }

	// RVA: 0x4A9E90 Offset: 0x4A9090 VA: 0x1804A9E90
	public void set_ClientData(object value) { }

	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x4A9D10 Offset: 0x4A8F10 VA: 0x1804A9D10
	public ProductUserId get_LocalUserId() { }

	// RVA: 0x4A9EF0 Offset: 0x4A90F0 VA: 0x1804A9EF0
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x4A9D90 Offset: 0x4A8F90 VA: 0x1804A9D90
	public ProductUserId get_RemoteUserId() { }

	// RVA: 0x4A9F50 Offset: 0x4A9150 VA: 0x1804A9F50
	public void set_RemoteUserId(ProductUserId value) { }

	// RVA: 0x4A9E10 Offset: 0x4A9010 VA: 0x1804A9E10
	public Nullable<SocketId> get_SocketId() { }

	// RVA: 0x4A9FB0 Offset: 0x4A91B0 VA: 0x1804A9FB0
	public void set_SocketId(Nullable<SocketId> value) { }

	// RVA: 0x4A9B40 Offset: 0x4A8D40 VA: 0x1804A9B40 Slot: 6
	public void Set(ref OnIncomingConnectionRequestInfo other) { }

	// RVA: 0x4A9960 Offset: 0x4A8B60 VA: 0x1804A9960 Slot: 7
	public void Set(ref Nullable<OnIncomingConnectionRequestInfo> other) { }

	// RVA: 0x4A98C0 Offset: 0x4A8AC0 VA: 0x1804A98C0 Slot: 8
	public void Dispose() { }

	// RVA: 0x4A9930 Offset: 0x4A8B30 VA: 0x1804A9930 Slot: 5
	public void Get(out OnIncomingConnectionRequestInfo output) { }
}

// Namespace: Epic.OnlineServices.P2P
public sealed class OnIncomingPacketQueueFullCallback : MulticastDelegate // TypeDefIndex: 9042
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref OnIncomingPacketQueueFullInfo data) { }

	// RVA: 0x4AA1D0 Offset: 0x4A93D0 VA: 0x1804AA1D0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref OnIncomingPacketQueueFullInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref OnIncomingPacketQueueFullInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.P2P
[UnmanagedFunctionPointer(2)]
internal sealed class OnIncomingPacketQueueFullCallbackInternal : MulticastDelegate // TypeDefIndex: 9043
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref OnIncomingPacketQueueFullInfoInternal data) { }

	// RVA: 0x4AA140 Offset: 0x4A9340 VA: 0x1804AA140 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref OnIncomingPacketQueueFullInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref OnIncomingPacketQueueFullInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.P2P
public struct OnIncomingPacketQueueFullInfo : ICallbackInfo // TypeDefIndex: 9044
{
	// Fields
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x0
	[CompilerGenerated]
	private ulong <PacketQueueMaxSizeBytes>k__BackingField; // 0x8
	[CompilerGenerated]
	private ulong <PacketQueueCurrentSizeBytes>k__BackingField; // 0x10
	[CompilerGenerated]
	private ProductUserId <OverflowPacketLocalUserId>k__BackingField; // 0x18
	[CompilerGenerated]
	private byte <OverflowPacketChannel>k__BackingField; // 0x20
	[CompilerGenerated]
	private uint <OverflowPacketSizeBytes>k__BackingField; // 0x24

	// Properties
	public object ClientData { get; set; }
	public ulong PacketQueueMaxSizeBytes { get; set; }
	public ulong PacketQueueCurrentSizeBytes { get; set; }
	public ProductUserId OverflowPacketLocalUserId { get; set; }
	public byte OverflowPacketChannel { get; set; }
	public uint OverflowPacketSizeBytes { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410 Slot: 4
	public object get_ClientData() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_ClientData(object value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public ulong get_PacketQueueMaxSizeBytes() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_PacketQueueMaxSizeBytes(ulong value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public ulong get_PacketQueueCurrentSizeBytes() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_PacketQueueCurrentSizeBytes(ulong value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public ProductUserId get_OverflowPacketLocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_OverflowPacketLocalUserId(ProductUserId value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x4009D0 Offset: 0x3FFBD0 VA: 0x1804009D0
	public byte get_OverflowPacketChannel() { }

	[CompilerGenerated]
	// RVA: 0x4009E0 Offset: 0x3FFBE0 VA: 0x1804009E0
	public void set_OverflowPacketChannel(byte value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x47BD90 Offset: 0x47AF90 VA: 0x18047BD90
	public uint get_OverflowPacketSizeBytes() { }

	[CompilerGenerated]
	// RVA: 0x47C1C0 Offset: 0x47B3C0 VA: 0x18047C1C0
	public void set_OverflowPacketSizeBytes(uint value) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x4AA6E0 Offset: 0x4A98E0 VA: 0x1804AA6E0
	internal void Set(ref OnIncomingPacketQueueFullInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.P2P
internal struct OnIncomingPacketQueueFullInfoInternal : ICallbackInfoInternal, IGettable<OnIncomingPacketQueueFullInfo>, ISettable<OnIncomingPacketQueueFullInfo>, IDisposable // TypeDefIndex: 9045
{
	// Fields
	private IntPtr m_ClientData; // 0x0
	private ulong m_PacketQueueMaxSizeBytes; // 0x8
	private ulong m_PacketQueueCurrentSizeBytes; // 0x10
	private IntPtr m_OverflowPacketLocalUserId; // 0x18
	private byte m_OverflowPacketChannel; // 0x20
	private uint m_OverflowPacketSizeBytes; // 0x24

	// Properties
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public ulong PacketQueueMaxSizeBytes { get; set; }
	public ulong PacketQueueCurrentSizeBytes { get; set; }
	public ProductUserId OverflowPacketLocalUserId { get; set; }
	public byte OverflowPacketChannel { get; set; }
	public uint OverflowPacketSizeBytes { get; set; }

	// Methods

	// RVA: 0x4AA530 Offset: 0x4A9730 VA: 0x1804AA530
	public object get_ClientData() { }

	// RVA: 0x4AA620 Offset: 0x4A9820 VA: 0x1804AA620
	public void set_ClientData(object value) { }

	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public ulong get_PacketQueueMaxSizeBytes() { }

	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_PacketQueueMaxSizeBytes(ulong value) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public ulong get_PacketQueueCurrentSizeBytes() { }

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_PacketQueueCurrentSizeBytes(ulong value) { }

	// RVA: 0x4AA5A0 Offset: 0x4A97A0 VA: 0x1804AA5A0
	public ProductUserId get_OverflowPacketLocalUserId() { }

	// RVA: 0x4AA680 Offset: 0x4A9880 VA: 0x1804AA680
	public void set_OverflowPacketLocalUserId(ProductUserId value) { }

	// RVA: 0x4009D0 Offset: 0x3FFBD0 VA: 0x1804009D0
	public byte get_OverflowPacketChannel() { }

	// RVA: 0x4009E0 Offset: 0x3FFBE0 VA: 0x1804009E0
	public void set_OverflowPacketChannel(byte value) { }

	// RVA: 0x47BD90 Offset: 0x47AF90 VA: 0x18047BD90
	public uint get_OverflowPacketSizeBytes() { }

	// RVA: 0x47C1C0 Offset: 0x47B3C0 VA: 0x18047C1C0
	public void set_OverflowPacketSizeBytes(uint value) { }

	// RVA: 0x4AA460 Offset: 0x4A9660 VA: 0x1804AA460 Slot: 6
	public void Set(ref OnIncomingPacketQueueFullInfo other) { }

	// RVA: 0x4AA2F0 Offset: 0x4A94F0 VA: 0x1804AA2F0 Slot: 7
	public void Set(ref Nullable<OnIncomingPacketQueueFullInfo> other) { }

	// RVA: 0x4AA260 Offset: 0x4A9460 VA: 0x1804AA260 Slot: 8
	public void Dispose() { }

	// RVA: 0x4AA2C0 Offset: 0x4A94C0 VA: 0x1804AA2C0 Slot: 5
	public void Get(out OnIncomingPacketQueueFullInfo output) { }
}

// Namespace: Epic.OnlineServices.P2P
public sealed class OnPeerConnectionEstablishedCallback : MulticastDelegate // TypeDefIndex: 9046
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref OnPeerConnectionEstablishedInfo data) { }

	// RVA: 0x4AA940 Offset: 0x4A9B40 VA: 0x1804AA940 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref OnPeerConnectionEstablishedInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref OnPeerConnectionEstablishedInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.P2P
[UnmanagedFunctionPointer(2)]
internal sealed class OnPeerConnectionEstablishedCallbackInternal : MulticastDelegate // TypeDefIndex: 9047
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref OnPeerConnectionEstablishedInfoInternal data) { }

	// RVA: 0x4AA8B0 Offset: 0x4A9AB0 VA: 0x1804AA8B0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref OnPeerConnectionEstablishedInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref OnPeerConnectionEstablishedInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.P2P
public struct OnPeerConnectionEstablishedInfo : ICallbackInfo // TypeDefIndex: 9048
{
	// Fields
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x0
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x8
	[CompilerGenerated]
	private ProductUserId <RemoteUserId>k__BackingField; // 0x10
	[CompilerGenerated]
	private Nullable<SocketId> <SocketId>k__BackingField; // 0x18
	[CompilerGenerated]
	private ConnectionEstablishedType <ConnectionType>k__BackingField; // 0x40
	[CompilerGenerated]
	private NetworkConnectionType <NetworkType>k__BackingField; // 0x44

	// Properties
	public object ClientData { get; set; }
	public ProductUserId LocalUserId { get; set; }
	public ProductUserId RemoteUserId { get; set; }
	public Nullable<SocketId> SocketId { get; set; }
	public ConnectionEstablishedType ConnectionType { get; set; }
	public NetworkConnectionType NetworkType { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410 Slot: 4
	public object get_ClientData() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_ClientData(object value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_LocalUserId(ProductUserId value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public ProductUserId get_RemoteUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_RemoteUserId(ProductUserId value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x41A1E0 Offset: 0x4193E0 VA: 0x18041A1E0
	public Nullable<SocketId> get_SocketId() { }

	[CompilerGenerated]
	// RVA: 0x41A210 Offset: 0x419410 VA: 0x18041A210
	public void set_SocketId(Nullable<SocketId> value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x433440 Offset: 0x432640 VA: 0x180433440
	public ConnectionEstablishedType get_ConnectionType() { }

	[CompilerGenerated]
	// RVA: 0x433450 Offset: 0x432650 VA: 0x180433450
	public void set_ConnectionType(ConnectionEstablishedType value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x4AB2B0 Offset: 0x4AA4B0 VA: 0x1804AB2B0
	public NetworkConnectionType get_NetworkType() { }

	[CompilerGenerated]
	// RVA: 0x4AB2C0 Offset: 0x4AA4C0 VA: 0x1804AB2C0
	public void set_NetworkType(NetworkConnectionType value) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x4AB180 Offset: 0x4AA380 VA: 0x1804AB180
	internal void Set(ref OnPeerConnectionEstablishedInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.P2P
internal struct OnPeerConnectionEstablishedInfoInternal : ICallbackInfoInternal, IGettable<OnPeerConnectionEstablishedInfo>, ISettable<OnPeerConnectionEstablishedInfo>, IDisposable // TypeDefIndex: 9049
{
	// Fields
	private IntPtr m_ClientData; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_RemoteUserId; // 0x10
	private IntPtr m_SocketId; // 0x18
	private ConnectionEstablishedType m_ConnectionType; // 0x20
	private NetworkConnectionType m_NetworkType; // 0x24

	// Properties
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public ProductUserId LocalUserId { get; set; }
	public ProductUserId RemoteUserId { get; set; }
	public Nullable<SocketId> SocketId { get; set; }
	public ConnectionEstablishedType ConnectionType { get; set; }
	public NetworkConnectionType NetworkType { get; set; }

	// Methods

	// RVA: 0x4AAE00 Offset: 0x4AA000 VA: 0x1804AAE00
	public object get_ClientData() { }

	// RVA: 0x4AAFF0 Offset: 0x4AA1F0 VA: 0x1804AAFF0
	public void set_ClientData(object value) { }

	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x4AAE70 Offset: 0x4AA070 VA: 0x1804AAE70
	public ProductUserId get_LocalUserId() { }

	// RVA: 0x4AB050 Offset: 0x4AA250 VA: 0x1804AB050
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x4AAEF0 Offset: 0x4AA0F0 VA: 0x1804AAEF0
	public ProductUserId get_RemoteUserId() { }

	// RVA: 0x4AB0B0 Offset: 0x4AA2B0 VA: 0x1804AB0B0
	public void set_RemoteUserId(ProductUserId value) { }

	// RVA: 0x4AAF70 Offset: 0x4AA170 VA: 0x1804AAF70
	public Nullable<SocketId> get_SocketId() { }

	// RVA: 0x4AB110 Offset: 0x4AA310 VA: 0x1804AB110
	public void set_SocketId(Nullable<SocketId> value) { }

	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400
	public ConnectionEstablishedType get_ConnectionType() { }

	// RVA: 0x3DA420 Offset: 0x3D9620 VA: 0x1803DA420
	public void set_ConnectionType(ConnectionEstablishedType value) { }

	// RVA: 0x47BD90 Offset: 0x47AF90 VA: 0x18047BD90
	public NetworkConnectionType get_NetworkType() { }

	// RVA: 0x47C1C0 Offset: 0x47B3C0 VA: 0x18047C1C0
	public void set_NetworkType(NetworkConnectionType value) { }

	// RVA: 0x4AAA70 Offset: 0x4A9C70 VA: 0x1804AAA70 Slot: 6
	public void Set(ref OnPeerConnectionEstablishedInfo other) { }

	// RVA: 0x4AABE0 Offset: 0x4A9DE0 VA: 0x1804AABE0 Slot: 7
	public void Set(ref Nullable<OnPeerConnectionEstablishedInfo> other) { }

	// RVA: 0x4AA9D0 Offset: 0x4A9BD0 VA: 0x1804AA9D0 Slot: 8
	public void Dispose() { }

	// RVA: 0x4AAA40 Offset: 0x4A9C40 VA: 0x1804AAA40 Slot: 5
	public void Get(out OnPeerConnectionEstablishedInfo output) { }
}

// Namespace: Epic.OnlineServices.P2P
public sealed class OnPeerConnectionInterruptedCallback : MulticastDelegate // TypeDefIndex: 9050
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref OnPeerConnectionInterruptedInfo data) { }

	// RVA: 0x4AB360 Offset: 0x4AA560 VA: 0x1804AB360 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref OnPeerConnectionInterruptedInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref OnPeerConnectionInterruptedInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.P2P
[UnmanagedFunctionPointer(2)]
internal sealed class OnPeerConnectionInterruptedCallbackInternal : MulticastDelegate // TypeDefIndex: 9051
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref OnPeerConnectionInterruptedInfoInternal data) { }

	// RVA: 0x4AB2D0 Offset: 0x4AA4D0 VA: 0x1804AB2D0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref OnPeerConnectionInterruptedInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref OnPeerConnectionInterruptedInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.P2P
public struct OnPeerConnectionInterruptedInfo : ICallbackInfo // TypeDefIndex: 9052
{
	// Fields
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x0
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x8
	[CompilerGenerated]
	private ProductUserId <RemoteUserId>k__BackingField; // 0x10
	[CompilerGenerated]
	private Nullable<SocketId> <SocketId>k__BackingField; // 0x18

	// Properties
	public object ClientData { get; set; }
	public ProductUserId LocalUserId { get; set; }
	public ProductUserId RemoteUserId { get; set; }
	public Nullable<SocketId> SocketId { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410 Slot: 4
	public object get_ClientData() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_ClientData(object value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_LocalUserId(ProductUserId value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public ProductUserId get_RemoteUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_RemoteUserId(ProductUserId value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x41A1E0 Offset: 0x4193E0 VA: 0x18041A1E0
	public Nullable<SocketId> get_SocketId() { }

	[CompilerGenerated]
	// RVA: 0x41A210 Offset: 0x419410 VA: 0x18041A210
	public void set_SocketId(Nullable<SocketId> value) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x4ABB50 Offset: 0x4AAD50 VA: 0x1804ABB50
	internal void Set(ref OnPeerConnectionInterruptedInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.P2P
internal struct OnPeerConnectionInterruptedInfoInternal : ICallbackInfoInternal, IGettable<OnPeerConnectionInterruptedInfo>, ISettable<OnPeerConnectionInterruptedInfo>, IDisposable // TypeDefIndex: 9053
{
	// Fields
	private IntPtr m_ClientData; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_RemoteUserId; // 0x10
	private IntPtr m_SocketId; // 0x18

	// Properties
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public ProductUserId LocalUserId { get; set; }
	public ProductUserId RemoteUserId { get; set; }
	public Nullable<SocketId> SocketId { get; set; }

	// Methods

	// RVA: 0x4AB7D0 Offset: 0x4AA9D0 VA: 0x1804AB7D0
	public object get_ClientData() { }

	// RVA: 0x4AB9C0 Offset: 0x4AABC0 VA: 0x1804AB9C0
	public void set_ClientData(object value) { }

	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x4AB840 Offset: 0x4AAA40 VA: 0x1804AB840
	public ProductUserId get_LocalUserId() { }

	// RVA: 0x4ABA20 Offset: 0x4AAC20 VA: 0x1804ABA20
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x4AB8C0 Offset: 0x4AAAC0 VA: 0x1804AB8C0
	public ProductUserId get_RemoteUserId() { }

	// RVA: 0x4ABA80 Offset: 0x4AAC80 VA: 0x1804ABA80
	public void set_RemoteUserId(ProductUserId value) { }

	// RVA: 0x4AB940 Offset: 0x4AAB40 VA: 0x1804AB940
	public Nullable<SocketId> get_SocketId() { }

	// RVA: 0x4ABAE0 Offset: 0x4AACE0 VA: 0x1804ABAE0
	public void set_SocketId(Nullable<SocketId> value) { }

	// RVA: 0x4AB670 Offset: 0x4AA870 VA: 0x1804AB670 Slot: 6
	public void Set(ref OnPeerConnectionInterruptedInfo other) { }

	// RVA: 0x4AB490 Offset: 0x4AA690 VA: 0x1804AB490 Slot: 7
	public void Set(ref Nullable<OnPeerConnectionInterruptedInfo> other) { }

	// RVA: 0x4AB3F0 Offset: 0x4AA5F0 VA: 0x1804AB3F0 Slot: 8
	public void Dispose() { }

	// RVA: 0x4AB460 Offset: 0x4AA660 VA: 0x1804AB460 Slot: 5
	public void Get(out OnPeerConnectionInterruptedInfo output) { }
}

// Namespace: Epic.OnlineServices.P2P
public sealed class OnQueryNATTypeCompleteCallback : MulticastDelegate // TypeDefIndex: 9054
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref OnQueryNATTypeCompleteInfo data) { }

	// RVA: 0x4AC060 Offset: 0x4AB260 VA: 0x1804AC060 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref OnQueryNATTypeCompleteInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref OnQueryNATTypeCompleteInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.P2P
[UnmanagedFunctionPointer(2)]
internal sealed class OnQueryNATTypeCompleteCallbackInternal : MulticastDelegate // TypeDefIndex: 9055
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref OnQueryNATTypeCompleteInfoInternal data) { }

	// RVA: 0x4ABFD0 Offset: 0x4AB1D0 VA: 0x1804ABFD0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref OnQueryNATTypeCompleteInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref OnQueryNATTypeCompleteInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.P2P
public struct OnQueryNATTypeCompleteInfo : ICallbackInfo // TypeDefIndex: 9056
{
	// Fields
	[CompilerGenerated]
	private Result <ResultCode>k__BackingField; // 0x0
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x8
	[CompilerGenerated]
	private NATType <NATType>k__BackingField; // 0x10

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public NATType NATType { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	[CompilerGenerated]
	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public object get_ClientData() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_ClientData(object value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public NATType get_NATType() { }

	[CompilerGenerated]
	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_NATType(NATType value) { }

	// RVA: 0x4CE440 Offset: 0x4CD640 VA: 0x1804CE440 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x4CE490 Offset: 0x4CD690 VA: 0x1804CE490
	internal void Set(ref OnQueryNATTypeCompleteInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.P2P
internal struct OnQueryNATTypeCompleteInfoInternal : ICallbackInfoInternal, IGettable<OnQueryNATTypeCompleteInfo>, ISettable<OnQueryNATTypeCompleteInfo>, IDisposable // TypeDefIndex: 9057
{
	// Fields
	private Result m_ResultCode; // 0x0
	private IntPtr m_ClientData; // 0x8
	private NATType m_NATType; // 0x10

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public NATType NATType { get; set; }

	// Methods

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	// RVA: 0x4CE370 Offset: 0x4CD570 VA: 0x1804CE370
	public object get_ClientData() { }

	// RVA: 0x4CE3E0 Offset: 0x4CD5E0 VA: 0x1804CE3E0
	public void set_ClientData(object value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public NATType get_NATType() { }

	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_NATType(NATType value) { }

	// RVA: 0x4CE210 Offset: 0x4CD410 VA: 0x1804CE210 Slot: 6
	public void Set(ref OnQueryNATTypeCompleteInfo other) { }

	// RVA: 0x4CE290 Offset: 0x4CD490 VA: 0x1804CE290 Slot: 7
	public void Set(ref Nullable<OnQueryNATTypeCompleteInfo> other) { }

	// RVA: 0x4CE1A0 Offset: 0x4CD3A0 VA: 0x1804CE1A0 Slot: 8
	public void Dispose() { }

	// RVA: 0x4CE1F0 Offset: 0x4CD3F0 VA: 0x1804CE1F0 Slot: 5
	public void Get(out OnQueryNATTypeCompleteInfo output) { }
}

// Namespace: Epic.OnlineServices.P2P
public sealed class OnRemoteConnectionClosedCallback : MulticastDelegate // TypeDefIndex: 9058
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref OnRemoteConnectionClosedInfo data) { }

	// RVA: 0x4CE5B0 Offset: 0x4CD7B0 VA: 0x1804CE5B0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref OnRemoteConnectionClosedInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref OnRemoteConnectionClosedInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.P2P
[UnmanagedFunctionPointer(2)]
internal sealed class OnRemoteConnectionClosedCallbackInternal : MulticastDelegate // TypeDefIndex: 9059
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref OnRemoteConnectionClosedInfoInternal data) { }

	// RVA: 0x4CE520 Offset: 0x4CD720 VA: 0x1804CE520 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref OnRemoteConnectionClosedInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref OnRemoteConnectionClosedInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.P2P
public struct OnRemoteConnectionClosedInfo : ICallbackInfo // TypeDefIndex: 9060
{
	// Fields
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x0
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x8
	[CompilerGenerated]
	private ProductUserId <RemoteUserId>k__BackingField; // 0x10
	[CompilerGenerated]
	private Nullable<SocketId> <SocketId>k__BackingField; // 0x18
	[CompilerGenerated]
	private ConnectionClosedReason <Reason>k__BackingField; // 0x40

	// Properties
	public object ClientData { get; set; }
	public ProductUserId LocalUserId { get; set; }
	public ProductUserId RemoteUserId { get; set; }
	public Nullable<SocketId> SocketId { get; set; }
	public ConnectionClosedReason Reason { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410 Slot: 4
	public object get_ClientData() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_ClientData(object value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_LocalUserId(ProductUserId value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public ProductUserId get_RemoteUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_RemoteUserId(ProductUserId value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x41A1E0 Offset: 0x4193E0 VA: 0x18041A1E0
	public Nullable<SocketId> get_SocketId() { }

	[CompilerGenerated]
	// RVA: 0x41A210 Offset: 0x419410 VA: 0x18041A210
	public void set_SocketId(Nullable<SocketId> value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x433440 Offset: 0x432640 VA: 0x180433440
	public ConnectionClosedReason get_Reason() { }

	[CompilerGenerated]
	// RVA: 0x433450 Offset: 0x432650 VA: 0x180433450
	public void set_Reason(ConnectionClosedReason value) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x4CEDD0 Offset: 0x4CDFD0 VA: 0x1804CEDD0
	internal void Set(ref OnRemoteConnectionClosedInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.P2P
internal struct OnRemoteConnectionClosedInfoInternal : ICallbackInfoInternal, IGettable<OnRemoteConnectionClosedInfo>, ISettable<OnRemoteConnectionClosedInfo>, IDisposable // TypeDefIndex: 9061
{
	// Fields
	private IntPtr m_ClientData; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_RemoteUserId; // 0x10
	private IntPtr m_SocketId; // 0x18
	private ConnectionClosedReason m_Reason; // 0x20

	// Properties
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public ProductUserId LocalUserId { get; set; }
	public ProductUserId RemoteUserId { get; set; }
	public Nullable<SocketId> SocketId { get; set; }
	public ConnectionClosedReason Reason { get; set; }

	// Methods

	// RVA: 0x4CEA50 Offset: 0x4CDC50 VA: 0x1804CEA50
	public object get_ClientData() { }

	// RVA: 0x4CEC40 Offset: 0x4CDE40 VA: 0x1804CEC40
	public void set_ClientData(object value) { }

	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x4CEAC0 Offset: 0x4CDCC0 VA: 0x1804CEAC0
	public ProductUserId get_LocalUserId() { }

	// RVA: 0x4CECA0 Offset: 0x4CDEA0 VA: 0x1804CECA0
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x4CEB40 Offset: 0x4CDD40 VA: 0x1804CEB40
	public ProductUserId get_RemoteUserId() { }

	// RVA: 0x4CED00 Offset: 0x4CDF00 VA: 0x1804CED00
	public void set_RemoteUserId(ProductUserId value) { }

	// RVA: 0x4CEBC0 Offset: 0x4CDDC0 VA: 0x1804CEBC0
	public Nullable<SocketId> get_SocketId() { }

	// RVA: 0x4CED60 Offset: 0x4CDF60 VA: 0x1804CED60
	public void set_SocketId(Nullable<SocketId> value) { }

	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400
	public ConnectionClosedReason get_Reason() { }

	// RVA: 0x3DA420 Offset: 0x3D9620 VA: 0x1803DA420
	public void set_Reason(ConnectionClosedReason value) { }

	// RVA: 0x4CE6E0 Offset: 0x4CD8E0 VA: 0x1804CE6E0 Slot: 6
	public void Set(ref OnRemoteConnectionClosedInfo other) { }

	// RVA: 0x4CE850 Offset: 0x4CDA50 VA: 0x1804CE850 Slot: 7
	public void Set(ref Nullable<OnRemoteConnectionClosedInfo> other) { }

	// RVA: 0x4CE640 Offset: 0x4CD840 VA: 0x1804CE640 Slot: 8
	public void Dispose() { }

	// RVA: 0x4CE6B0 Offset: 0x4CD8B0 VA: 0x1804CE6B0 Slot: 5
	public void Get(out OnRemoteConnectionClosedInfo output) { }
}

// Namespace: Epic.OnlineServices.P2P
public sealed class P2PInterface : Handle // TypeDefIndex: 9062
{
	// Fields
	public const int AcceptconnectionApiLatest = 1;
	public const int AddnotifyincomingpacketqueuefullApiLatest = 1;
	public const int AddnotifypeerconnectionclosedApiLatest = 1;
	public const int AddnotifypeerconnectionestablishedApiLatest = 1;
	public const int AddnotifypeerconnectioninterruptedApiLatest = 1;
	public const int AddnotifypeerconnectionrequestApiLatest = 1;
	public const int ClearpacketqueueApiLatest = 1;
	public const int CloseconnectionApiLatest = 1;
	public const int CloseconnectionsApiLatest = 1;
	public const int GetnattypeApiLatest = 1;
	public const int GetnextreceivedpacketsizeApiLatest = 2;
	public const int GetpacketqueueinfoApiLatest = 1;
	public const int GetportrangeApiLatest = 1;
	public const int GetrelaycontrolApiLatest = 1;
	public const int MaxConnections = 32;
	public const int MaxPacketSize = 1170;
	public const int MaxQueueSizeUnlimited = 0;
	public const int QuerynattypeApiLatest = 1;
	public const int ReceivepacketApiLatest = 2;
	public const int SendpacketApiLatest = 3;
	public const int SetpacketqueuesizeApiLatest = 1;
	public const int SetportrangeApiLatest = 1;
	public const int SetrelaycontrolApiLatest = 1;
	public const int SocketidApiLatest = 1;
	public const int SocketidSocketnameSize = 33;

	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }

	// RVA: 0x40BDB0 Offset: 0x40AFB0 VA: 0x18040BDB0
	public void .ctor(IntPtr innerHandle) { }

	// RVA: 0x4CF140 Offset: 0x4CE340 VA: 0x1804CF140
	public Result AcceptConnection(ref AcceptConnectionOptions options) { }

	// RVA: 0x4CF1E0 Offset: 0x4CE3E0 VA: 0x1804CF1E0
	public ulong AddNotifyIncomingPacketQueueFull(ref AddNotifyIncomingPacketQueueFullOptions options, object clientData, OnIncomingPacketQueueFullCallback incomingPacketQueueFullHandler) { }

	// RVA: 0x4CF320 Offset: 0x4CE520 VA: 0x1804CF320
	public ulong AddNotifyPeerConnectionClosed(ref AddNotifyPeerConnectionClosedOptions options, object clientData, OnRemoteConnectionClosedCallback connectionClosedHandler) { }

	// RVA: 0x4CF4F0 Offset: 0x4CE6F0 VA: 0x1804CF4F0
	public ulong AddNotifyPeerConnectionEstablished(ref AddNotifyPeerConnectionEstablishedOptions options, object clientData, OnPeerConnectionEstablishedCallback connectionEstablishedHandler) { }

	// RVA: 0x4CF650 Offset: 0x4CE850 VA: 0x1804CF650
	public ulong AddNotifyPeerConnectionInterrupted(ref AddNotifyPeerConnectionInterruptedOptions options, object clientData, OnPeerConnectionInterruptedCallback connectionInterruptedHandler) { }

	// RVA: 0x4CF7B0 Offset: 0x4CE9B0 VA: 0x1804CF7B0
	public ulong AddNotifyPeerConnectionRequest(ref AddNotifyPeerConnectionRequestOptions options, object clientData, OnIncomingConnectionRequestCallback connectionRequestHandler) { }

	// RVA: 0x4CF910 Offset: 0x4CEB10 VA: 0x1804CF910
	public Result ClearPacketQueue(ref ClearPacketQueueOptions options) { }

	// RVA: 0x4CF9B0 Offset: 0x4CEBB0 VA: 0x1804CF9B0
	public Result CloseConnection(ref CloseConnectionOptions options) { }

	// RVA: 0x4CFA50 Offset: 0x4CEC50 VA: 0x1804CFA50
	public Result CloseConnections(ref CloseConnectionsOptions options) { }

	// RVA: 0x4CFAF0 Offset: 0x4CECF0 VA: 0x1804CFAF0
	public Result GetNATType(ref GetNATTypeOptions options, out NATType outNATType) { }

	// RVA: 0x4CFBB0 Offset: 0x4CEDB0 VA: 0x1804CFBB0
	public Result GetNextReceivedPacketSize(ref GetNextReceivedPacketSizeOptions options, out uint outPacketSizeBytes) { }

	// RVA: 0x4CFC80 Offset: 0x4CEE80 VA: 0x1804CFC80
	public Result GetPacketQueueInfo(ref GetPacketQueueInfoOptions options, out PacketQueueInfo outPacketQueueInfo) { }

	// RVA: 0x4CFDA0 Offset: 0x4CEFA0 VA: 0x1804CFDA0
	public Result GetPortRange(ref GetPortRangeOptions options, out ushort outPort, out ushort outNumAdditionalPortsToTry) { }

	// RVA: 0x4CFE90 Offset: 0x4CF090 VA: 0x1804CFE90
	public Result GetRelayControl(ref GetRelayControlOptions options, out RelayControl outRelayControl) { }

	// RVA: 0x4D0390 Offset: 0x4CF590 VA: 0x1804D0390
	public void QueryNATType(ref QueryNATTypeOptions options, object clientData, OnQueryNATTypeCompleteCallback completionDelegate) { }

	// RVA: 0x4D0830 Offset: 0x4CFA30 VA: 0x1804D0830
	public void RemoveNotifyIncomingPacketQueueFull(ulong notificationId) { }

	// RVA: 0x4D08A0 Offset: 0x4CFAA0 VA: 0x1804D08A0
	public void RemoveNotifyPeerConnectionClosed(ulong notificationId) { }

	// RVA: 0x4D0910 Offset: 0x4CFB10 VA: 0x1804D0910
	public void RemoveNotifyPeerConnectionEstablished(ulong notificationId) { }

	// RVA: 0x4D0980 Offset: 0x4CFB80 VA: 0x1804D0980
	public void RemoveNotifyPeerConnectionInterrupted(ulong notificationId) { }

	// RVA: 0x4D09F0 Offset: 0x4CFBF0 VA: 0x1804D09F0
	public void RemoveNotifyPeerConnectionRequest(ulong notificationId) { }

	// RVA: 0x4D0A60 Offset: 0x4CFC60 VA: 0x1804D0A60
	public Result SendPacket(ref SendPacketOptions options) { }

	// RVA: 0x4D0B10 Offset: 0x4CFD10 VA: 0x1804D0B10
	public Result SetPacketQueueSize(ref SetPacketQueueSizeOptions options) { }

	// RVA: 0x4D0BB0 Offset: 0x4CFDB0 VA: 0x1804D0BB0
	public Result SetPortRange(ref SetPortRangeOptions options) { }

	// RVA: 0x4D0C50 Offset: 0x4CFE50 VA: 0x1804D0C50
	public Result SetRelayControl(ref SetRelayControlOptions options) { }

	[MonoPInvokeCallback(typeof(OnIncomingConnectionRequestCallbackInternal))]
	// RVA: 0x4CFF50 Offset: 0x4CF150 VA: 0x1804CFF50
	internal static void OnIncomingConnectionRequestCallbackInternalImplementation(ref OnIncomingConnectionRequestInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnIncomingPacketQueueFullCallbackInternal))]
	// RVA: 0x4D0000 Offset: 0x4CF200 VA: 0x1804D0000
	internal static void OnIncomingPacketQueueFullCallbackInternalImplementation(ref OnIncomingPacketQueueFullInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnPeerConnectionEstablishedCallbackInternal))]
	// RVA: 0x4D00B0 Offset: 0x4CF2B0 VA: 0x1804D00B0
	internal static void OnPeerConnectionEstablishedCallbackInternalImplementation(ref OnPeerConnectionEstablishedInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnPeerConnectionInterruptedCallbackInternal))]
	// RVA: 0x4D0170 Offset: 0x4CF370 VA: 0x1804D0170
	internal static void OnPeerConnectionInterruptedCallbackInternalImplementation(ref OnPeerConnectionInterruptedInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnQueryNATTypeCompleteCallbackInternal))]
	// RVA: 0x4D0220 Offset: 0x4CF420 VA: 0x1804D0220
	internal static void OnQueryNATTypeCompleteCallbackInternalImplementation(ref OnQueryNATTypeCompleteInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnRemoteConnectionClosedCallbackInternal))]
	// RVA: 0x4D02D0 Offset: 0x4CF4D0 VA: 0x1804D02D0
	internal static void OnRemoteConnectionClosedCallbackInternalImplementation(ref OnRemoteConnectionClosedInfoInternal data) { }

	// RVA: 0x4D04C0 Offset: 0x4CF6C0 VA: 0x1804D04C0
	public Result ReceivePacket(ref ReceivePacketOptions options, ref ProductUserId outPeerId, ref SocketId outSocketId, out byte outChannel, ArraySegment<byte> outData, out uint outBytesWritten) { }
}

// Namespace: Epic.OnlineServices.P2P
public struct PacketQueueInfo // TypeDefIndex: 9063
{
	// Fields
	[CompilerGenerated]
	private ulong <IncomingPacketQueueMaxSizeBytes>k__BackingField; // 0x0
	[CompilerGenerated]
	private ulong <IncomingPacketQueueCurrentSizeBytes>k__BackingField; // 0x8
	[CompilerGenerated]
	private ulong <IncomingPacketQueueCurrentPacketCount>k__BackingField; // 0x10
	[CompilerGenerated]
	private ulong <OutgoingPacketQueueMaxSizeBytes>k__BackingField; // 0x18
	[CompilerGenerated]
	private ulong <OutgoingPacketQueueCurrentSizeBytes>k__BackingField; // 0x20
	[CompilerGenerated]
	private ulong <OutgoingPacketQueueCurrentPacketCount>k__BackingField; // 0x28

	// Properties
	public ulong IncomingPacketQueueMaxSizeBytes { get; set; }
	public ulong IncomingPacketQueueCurrentSizeBytes { get; set; }
	public ulong IncomingPacketQueueCurrentPacketCount { get; set; }
	public ulong OutgoingPacketQueueMaxSizeBytes { get; set; }
	public ulong OutgoingPacketQueueCurrentSizeBytes { get; set; }
	public ulong OutgoingPacketQueueCurrentPacketCount { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public ulong get_IncomingPacketQueueMaxSizeBytes() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_IncomingPacketQueueMaxSizeBytes(ulong value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public ulong get_IncomingPacketQueueCurrentSizeBytes() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_IncomingPacketQueueCurrentSizeBytes(ulong value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public ulong get_IncomingPacketQueueCurrentPacketCount() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_IncomingPacketQueueCurrentPacketCount(ulong value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public ulong get_OutgoingPacketQueueMaxSizeBytes() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_OutgoingPacketQueueMaxSizeBytes(ulong value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public ulong get_OutgoingPacketQueueCurrentSizeBytes() { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_OutgoingPacketQueueCurrentSizeBytes(ulong value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public ulong get_OutgoingPacketQueueCurrentPacketCount() { }

	[CompilerGenerated]
	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	public void set_OutgoingPacketQueueCurrentPacketCount(ulong value) { }

	// RVA: 0x4D0E20 Offset: 0x4D0020 VA: 0x1804D0E20
	internal void Set(ref PacketQueueInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.P2P
internal struct PacketQueueInfoInternal : IGettable<PacketQueueInfo>, ISettable<PacketQueueInfo>, IDisposable // TypeDefIndex: 9064
{
	// Fields
	private ulong m_IncomingPacketQueueMaxSizeBytes; // 0x0
	private ulong m_IncomingPacketQueueCurrentSizeBytes; // 0x8
	private ulong m_IncomingPacketQueueCurrentPacketCount; // 0x10
	private ulong m_OutgoingPacketQueueMaxSizeBytes; // 0x18
	private ulong m_OutgoingPacketQueueCurrentSizeBytes; // 0x20
	private ulong m_OutgoingPacketQueueCurrentPacketCount; // 0x28

	// Properties
	public ulong IncomingPacketQueueMaxSizeBytes { get; set; }
	public ulong IncomingPacketQueueCurrentSizeBytes { get; set; }
	public ulong IncomingPacketQueueCurrentPacketCount { get; set; }
	public ulong OutgoingPacketQueueMaxSizeBytes { get; set; }
	public ulong OutgoingPacketQueueCurrentSizeBytes { get; set; }
	public ulong OutgoingPacketQueueCurrentPacketCount { get; set; }

	// Methods

	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public ulong get_IncomingPacketQueueMaxSizeBytes() { }

	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_IncomingPacketQueueMaxSizeBytes(ulong value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public ulong get_IncomingPacketQueueCurrentSizeBytes() { }

	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_IncomingPacketQueueCurrentSizeBytes(ulong value) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public ulong get_IncomingPacketQueueCurrentPacketCount() { }

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_IncomingPacketQueueCurrentPacketCount(ulong value) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public ulong get_OutgoingPacketQueueMaxSizeBytes() { }

	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_OutgoingPacketQueueMaxSizeBytes(ulong value) { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public ulong get_OutgoingPacketQueueCurrentSizeBytes() { }

	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_OutgoingPacketQueueCurrentSizeBytes(ulong value) { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public ulong get_OutgoingPacketQueueCurrentPacketCount() { }

	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	public void set_OutgoingPacketQueueCurrentPacketCount(ulong value) { }

	// RVA: 0x4D0E20 Offset: 0x4D0020 VA: 0x1804D0E20 Slot: 5
	public void Set(ref PacketQueueInfo other) { }

	// RVA: 0x4D0D20 Offset: 0x4CFF20 VA: 0x1804D0D20 Slot: 6
	public void Set(ref Nullable<PacketQueueInfo> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 7
	public void Dispose() { }

	// RVA: 0x4D0CE0 Offset: 0x4CFEE0 VA: 0x1804D0CE0 Slot: 4
	public void Get(out PacketQueueInfo output) { }
}

// Namespace: Epic.OnlineServices.P2P
public enum PacketReliability // TypeDefIndex: 9065
{
	// Fields
	public int value__; // 0x0
	public const PacketReliability UnreliableUnordered = 0;
	public const PacketReliability ReliableUnordered = 1;
	public const PacketReliability ReliableOrdered = 2;
}

// Namespace: Epic.OnlineServices.P2P
public struct QueryNATTypeOptions // TypeDefIndex: 9066
{}

// Namespace: Epic.OnlineServices.P2P
internal struct QueryNATTypeOptionsInternal : ISettable<QueryNATTypeOptions>, IDisposable // TypeDefIndex: 9067
{
	// Fields
	private int m_ApiVersion; // 0x0

	// Methods

	// RVA: 0x3F98A0 Offset: 0x3F8AA0 VA: 0x1803F98A0 Slot: 4
	public void Set(ref QueryNATTypeOptions other) { }

	// RVA: 0x4D0E50 Offset: 0x4D0050 VA: 0x1804D0E50 Slot: 5
	public void Set(ref Nullable<QueryNATTypeOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.P2P
public enum RelayControl // TypeDefIndex: 9068
{
	// Fields
	public int value__; // 0x0
	public const RelayControl NoRelays = 0;
	public const RelayControl AllowRelays = 1;
	public const RelayControl ForceRelays = 2;
}

// Namespace: Epic.OnlineServices.P2P
public struct SendPacketOptions // TypeDefIndex: 9069
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private ProductUserId <RemoteUserId>k__BackingField; // 0x8
	[CompilerGenerated]
	private Nullable<SocketId> <SocketId>k__BackingField; // 0x10
	[CompilerGenerated]
	private byte <Channel>k__BackingField; // 0x38
	[CompilerGenerated]
	private ArraySegment<byte> <Data>k__BackingField; // 0x40
	[CompilerGenerated]
	private bool <AllowDelayedDelivery>k__BackingField; // 0x50
	[CompilerGenerated]
	private PacketReliability <Reliability>k__BackingField; // 0x54
	[CompilerGenerated]
	private bool <DisableAutoAcceptConnection>k__BackingField; // 0x58

	// Properties
	public ProductUserId LocalUserId { get; set; }
	public ProductUserId RemoteUserId { get; set; }
	public Nullable<SocketId> SocketId { get; set; }
	public byte Channel { get; set; }
	public ArraySegment<byte> Data { get; set; }
	public bool AllowDelayedDelivery { get; set; }
	public PacketReliability Reliability { get; set; }
	public bool DisableAutoAcceptConnection { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_LocalUserId(ProductUserId value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public ProductUserId get_RemoteUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_RemoteUserId(ProductUserId value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x4A1870 Offset: 0x4A0A70 VA: 0x1804A1870
	public Nullable<SocketId> get_SocketId() { }

	[CompilerGenerated]
	// RVA: 0x4A1890 Offset: 0x4A0A90 VA: 0x1804A1890
	public void set_SocketId(Nullable<SocketId> value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x4BD700 Offset: 0x4BC900 VA: 0x1804BD700
	public byte get_Channel() { }

	[CompilerGenerated]
	// RVA: 0x4BD760 Offset: 0x4BC960 VA: 0x1804BD760
	public void set_Channel(byte value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x4D1A20 Offset: 0x4D0C20 VA: 0x1804D1A20
	public ArraySegment<byte> get_Data() { }

	[CompilerGenerated]
	// RVA: 0x4D1A60 Offset: 0x4D0C60 VA: 0x1804D1A60
	public void set_Data(ArraySegment<byte> value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x4D1A10 Offset: 0x4D0C10 VA: 0x1804D1A10
	public bool get_AllowDelayedDelivery() { }

	[CompilerGenerated]
	// RVA: 0x4D1A50 Offset: 0x4D0C50 VA: 0x1804D1A50
	public void set_AllowDelayedDelivery(bool value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x4D1A40 Offset: 0x4D0C40 VA: 0x1804D1A40
	public PacketReliability get_Reliability() { }

	[CompilerGenerated]
	// RVA: 0x4D1A80 Offset: 0x4D0C80 VA: 0x1804D1A80
	public void set_Reliability(PacketReliability value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x4D1A30 Offset: 0x4D0C30 VA: 0x1804D1A30
	public bool get_DisableAutoAcceptConnection() { }

	[CompilerGenerated]
	// RVA: 0x4D1A70 Offset: 0x4D0C70 VA: 0x1804D1A70
	public void set_DisableAutoAcceptConnection(bool value) { }
}

// Namespace: Epic.OnlineServices.P2P
public struct SetPacketQueueSizeOptions // TypeDefIndex: 9070
{
	// Fields
	[CompilerGenerated]
	private ulong <IncomingPacketQueueMaxSizeBytes>k__BackingField; // 0x0
	[CompilerGenerated]
	private ulong <OutgoingPacketQueueMaxSizeBytes>k__BackingField; // 0x8

	// Properties
	public ulong IncomingPacketQueueMaxSizeBytes { get; set; }
	public ulong OutgoingPacketQueueMaxSizeBytes { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public ulong get_IncomingPacketQueueMaxSizeBytes() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_IncomingPacketQueueMaxSizeBytes(ulong value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public ulong get_OutgoingPacketQueueMaxSizeBytes() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_OutgoingPacketQueueMaxSizeBytes(ulong value) { }
}

// Namespace: Epic.OnlineServices.P2P
internal struct SetPacketQueueSizeOptionsInternal : ISettable<SetPacketQueueSizeOptions>, IDisposable // TypeDefIndex: 9071
{
	// Fields
	private int m_ApiVersion; // 0x0
	private ulong m_IncomingPacketQueueMaxSizeBytes; // 0x8
	private ulong m_OutgoingPacketQueueMaxSizeBytes; // 0x10

	// Properties
	public ulong IncomingPacketQueueMaxSizeBytes { set; }
	public ulong OutgoingPacketQueueMaxSizeBytes { set; }

	// Methods

	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_IncomingPacketQueueMaxSizeBytes(ulong value) { }

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_OutgoingPacketQueueMaxSizeBytes(ulong value) { }

	// RVA: 0x491D50 Offset: 0x490F50 VA: 0x180491D50 Slot: 4
	public void Set(ref SetPacketQueueSizeOptions other) { }

	// RVA: 0x4D1A90 Offset: 0x4D0C90 VA: 0x1804D1A90 Slot: 5
	public void Set(ref Nullable<SetPacketQueueSizeOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.P2P
public struct SetPortRangeOptions // TypeDefIndex: 9072
{
	// Fields
	[CompilerGenerated]
	private ushort <Port>k__BackingField; // 0x0
	[CompilerGenerated]
	private ushort <MaxAdditionalPortsToTry>k__BackingField; // 0x2

	// Properties
	public ushort Port { get; set; }
	public ushort MaxAdditionalPortsToTry { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x4D1BF0 Offset: 0x4D0DF0 VA: 0x1804D1BF0
	public ushort get_Port() { }

	[CompilerGenerated]
	// RVA: 0x4D1C10 Offset: 0x4D0E10 VA: 0x1804D1C10
	public void set_Port(ushort value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x4D1BE0 Offset: 0x4D0DE0 VA: 0x1804D1BE0
	public ushort get_MaxAdditionalPortsToTry() { }

	[CompilerGenerated]
	// RVA: 0x4D1C00 Offset: 0x4D0E00 VA: 0x1804D1C00
	public void set_MaxAdditionalPortsToTry(ushort value) { }
}

// Namespace: Epic.OnlineServices.P2P
internal struct SetPortRangeOptionsInternal : ISettable<SetPortRangeOptions>, IDisposable // TypeDefIndex: 9073
{
	// Fields
	private int m_ApiVersion; // 0x0
	private ushort m_Port; // 0x4
	private ushort m_MaxAdditionalPortsToTry; // 0x6

	// Properties
	public ushort Port { set; }
	public ushort MaxAdditionalPortsToTry { set; }

	// Methods

	// RVA: 0x4D1BD0 Offset: 0x4D0DD0 VA: 0x1804D1BD0
	public void set_Port(ushort value) { }

	// RVA: 0x4D1BC0 Offset: 0x4D0DC0 VA: 0x1804D1BC0
	public void set_MaxAdditionalPortsToTry(ushort value) { }

	// RVA: 0x4D1BA0 Offset: 0x4D0DA0 VA: 0x1804D1BA0 Slot: 4
	public void Set(ref SetPortRangeOptions other) { }

	// RVA: 0x4D1B20 Offset: 0x4D0D20 VA: 0x1804D1B20 Slot: 5
	public void Set(ref Nullable<SetPortRangeOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.P2P
public struct SetRelayControlOptions // TypeDefIndex: 9074
{
	// Fields
	[CompilerGenerated]
	private RelayControl <RelayControl>k__BackingField; // 0x0

	// Properties
	public RelayControl RelayControl { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public RelayControl get_RelayControl() { }

	[CompilerGenerated]
	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_RelayControl(RelayControl value) { }
}

// Namespace: Epic.OnlineServices.P2P
internal struct SetRelayControlOptionsInternal : ISettable<SetRelayControlOptions>, IDisposable // TypeDefIndex: 9075
{
	// Fields
	private int m_ApiVersion; // 0x0
	private RelayControl m_RelayControl; // 0x4

	// Properties
	public RelayControl RelayControl { set; }

	// Methods

	// RVA: 0x3F84A0 Offset: 0x3F76A0 VA: 0x1803F84A0
	public void set_RelayControl(RelayControl value) { }

	// RVA: 0x40B2E0 Offset: 0x40A4E0 VA: 0x18040B2E0 Slot: 4
	public void Set(ref SetRelayControlOptions other) { }

	// RVA: 0x4D1C20 Offset: 0x4D0E20 VA: 0x1804D1C20 Slot: 5
	public void Set(ref Nullable<SetRelayControlOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.P2P
internal struct SocketIdInternal : IGettable<SocketId>, ISettable<SocketId>, IDisposable // TypeDefIndex: 9076
{
	// Fields
	private int m_ApiVersion; // 0x0
	private byte[] m_SocketName; // 0x8

	// Properties
	public string SocketName { get; set; }

	// Methods

	// RVA: 0x4D1F30 Offset: 0x4D1130 VA: 0x1804D1F30
	public string get_SocketName() { }

	// RVA: 0x4D1FA0 Offset: 0x4D11A0 VA: 0x1804D1FA0
	public void set_SocketName(string value) { }

	// RVA: 0x4D1E40 Offset: 0x4D1040 VA: 0x1804D1E40 Slot: 5
	public void Set(ref SocketId other) { }

	// RVA: 0x4D1CF0 Offset: 0x4D0EF0 VA: 0x1804D1CF0 Slot: 6
	public void Set(ref Nullable<SocketId> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 7
	public void Dispose() { }

	// RVA: 0x4D1C80 Offset: 0x4D0E80 VA: 0x1804D1C80 Slot: 4
	public void Get(out SocketId output) { }
}

// Namespace: Epic.OnlineServices.P2P
public struct GetNextReceivedPacketSizeOptions // TypeDefIndex: 9077
{
	// Fields
	internal byte[] m_RequestedChannel; // 0x0
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x8

	// Properties
	public ProductUserId LocalUserId { get; set; }
	public Nullable<byte> RequestedChannel { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x4BFB70 Offset: 0x4BED70 VA: 0x1804BFB70
	public Nullable<byte> get_RequestedChannel() { }

	// RVA: 0x4BFBE0 Offset: 0x4BEDE0 VA: 0x1804BFBE0
	public void set_RequestedChannel(Nullable<byte> value) { }
}

// Namespace: Epic.OnlineServices.P2P
internal struct GetNextReceivedPacketSizeOptionsInternal : ISettable<GetNextReceivedPacketSizeOptions>, IDisposable // TypeDefIndex: 9078
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_RequestedChannel; // 0x10

	// Methods

	// RVA: 0x4BF890 Offset: 0x4BEA90 VA: 0x1804BF890 Slot: 4
	public void Set(ref GetNextReceivedPacketSizeOptions other) { }

	// RVA: 0x4BF9D0 Offset: 0x4BEBD0 VA: 0x1804BF9D0 Slot: 5
	public void Set(ref Nullable<GetNextReceivedPacketSizeOptions> other) { }

	// RVA: 0x4BF830 Offset: 0x4BEA30 VA: 0x1804BF830 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.P2P
public struct ReceivePacketOptions // TypeDefIndex: 9079
{
	// Fields
	internal byte[] m_RequestedChannel; // 0x0
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x8
	[CompilerGenerated]
	private uint <MaxDataSizeBytes>k__BackingField; // 0x10

	// Properties
	public ProductUserId LocalUserId { get; set; }
	public uint MaxDataSizeBytes { get; set; }
	public Nullable<byte> RequestedChannel { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_LocalUserId(ProductUserId value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public uint get_MaxDataSizeBytes() { }

	[CompilerGenerated]
	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_MaxDataSizeBytes(uint value) { }

	// RVA: 0x4D1050 Offset: 0x4D0250 VA: 0x1804D1050
	public Nullable<byte> get_RequestedChannel() { }

	// RVA: 0x4D10C0 Offset: 0x4D02C0 VA: 0x1804D10C0
	public void set_RequestedChannel(Nullable<byte> value) { }
}

// Namespace: Epic.OnlineServices.P2P
internal struct ReceivePacketOptionsInternal : IDisposable // TypeDefIndex: 9080
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private uint m_MaxDataSizeBytes; // 0x10
	public IntPtr m_RequestedChannel; // 0x18

	// Methods

	// RVA: 0x4D0F00 Offset: 0x4D0100 VA: 0x1804D0F00
	public void .ctor(ref ReceivePacketOptions other) { }

	// RVA: 0x4D0EA0 Offset: 0x4D00A0 VA: 0x1804D0EA0 Slot: 4
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.P2P
internal struct SendPacketOptionsInternal : ISettable<SendPacketOptions>, IDisposable // TypeDefIndex: 9081
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_RemoteUserId; // 0x10
	internal IntPtr m_SocketId; // 0x18
	private byte m_Channel; // 0x20
	private uint m_DataLengthBytes; // 0x24
	private IntPtr m_Data; // 0x28
	private int m_AllowDelayedDelivery; // 0x30
	private PacketReliability m_Reliability; // 0x34
	private int m_DisableAutoAcceptConnection; // 0x38

	// Properties
	public ProductUserId LocalUserId { set; }
	public ProductUserId RemoteUserId { set; }
	public byte Channel { set; }
	public ArraySegment<byte> Data { set; }
	public bool AllowDelayedDelivery { set; }
	public PacketReliability Reliability { set; }
	public bool DisableAutoAcceptConnection { set; }

	// Methods

	// RVA: 0x4D1940 Offset: 0x4D0B40 VA: 0x1804D1940
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x4D19B0 Offset: 0x4D0BB0 VA: 0x1804D19B0
	public void set_RemoteUserId(ProductUserId value) { }

	// RVA: 0x4009E0 Offset: 0x3FFBE0 VA: 0x1804009E0
	public void set_Channel(byte value) { }

	// RVA: 0x4D1870 Offset: 0x4D0A70 VA: 0x1804D1870
	public void set_Data(ArraySegment<byte> value) { }

	// RVA: 0x4D1810 Offset: 0x4D0A10 VA: 0x1804D1810
	public void set_AllowDelayedDelivery(bool value) { }

	// RVA: 0x4D19A0 Offset: 0x4D0BA0 VA: 0x1804D19A0
	public void set_Reliability(PacketReliability value) { }

	// RVA: 0x4D18E0 Offset: 0x4D0AE0 VA: 0x1804D18E0
	public void set_DisableAutoAcceptConnection(bool value) { }

	// RVA: 0x4D1540 Offset: 0x4D0740 VA: 0x1804D1540 Slot: 4
	public void Set(ref SendPacketOptions other) { }

	// RVA: 0x4D11E0 Offset: 0x4D03E0 VA: 0x1804D11E0 Slot: 5
	public void Set(ref Nullable<SendPacketOptions> other) { }

	// RVA: 0x4D1170 Offset: 0x4D0370 VA: 0x1804D1170 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.P2P
public struct SocketId // TypeDefIndex: 9082
{
	// Fields
	public static readonly SocketId Empty; // 0x0
	private const int MaxSocketNameLength = 32;
	private const int ApiVersionLength = 4;
	private const int NullTerminatorSpace = 1;
	private const int TotalSizeInBytes = 37;
	private bool m_CacheValid; // 0x0
	private string m_CachedSocketName; // 0x8
	internal byte[] m_AllBytes; // 0x10
	internal byte[] m_SwapBuffer; // 0x18

	// Properties
	public string SocketName { get; set; }

	// Methods

	// RVA: 0x4D2460 Offset: 0x4D1660 VA: 0x1804D2460
	public string get_SocketName() { }

	// RVA: 0x4D24D0 Offset: 0x4D16D0 VA: 0x1804D24D0
	public void set_SocketName(string value) { }

	// RVA: 0x4D22C0 Offset: 0x4D14C0 VA: 0x1804D22C0
	internal void Set(ref SocketIdInternal other) { }

	// RVA: 0x4D2150 Offset: 0x4D1350 VA: 0x1804D2150
	internal bool PrepareForUpdate() { }

	// RVA: 0x4D2000 Offset: 0x4D1200 VA: 0x1804D2000
	internal void CheckIfChanged(bool wasCacheValid) { }

	// RVA: 0x4D21F0 Offset: 0x4D13F0 VA: 0x1804D21F0
	private void RebuildStringFromBuffer() { }

	// RVA: 0x4D20B0 Offset: 0x4D12B0 VA: 0x1804D20B0
	private void EnsureStorage() { }

	// RVA: 0x4D2070 Offset: 0x4D1270 VA: 0x1804D2070
	private void CopyIdToSwapBuffer() { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590
	private static void .cctor() { }
}

// Namespace: Epic.OnlineServices.Mods
public struct CopyModInfoOptions // TypeDefIndex: 9083
{
	// Fields
	[CompilerGenerated]
	private EpicAccountId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private ModEnumerationType <Type>k__BackingField; // 0x8

	// Properties
	public EpicAccountId LocalUserId { get; set; }
	public ModEnumerationType Type { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public EpicAccountId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_LocalUserId(EpicAccountId value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3F5510 Offset: 0x3F4710 VA: 0x1803F5510
	public ModEnumerationType get_Type() { }

	[CompilerGenerated]
	// RVA: 0x3F5520 Offset: 0x3F4720 VA: 0x1803F5520
	public void set_Type(ModEnumerationType value) { }
}

// Namespace: Epic.OnlineServices.Mods
internal struct CopyModInfoOptionsInternal : ISettable<CopyModInfoOptions>, IDisposable // TypeDefIndex: 9084
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private ModEnumerationType m_Type; // 0x10

	// Properties
	public EpicAccountId LocalUserId { set; }
	public ModEnumerationType Type { set; }

	// Methods

	// RVA: 0x4BC400 Offset: 0x4BB600 VA: 0x1804BC400
	public void set_LocalUserId(EpicAccountId value) { }

	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_Type(ModEnumerationType value) { }

	// RVA: 0x4BC2C0 Offset: 0x4BB4C0 VA: 0x1804BC2C0 Slot: 4
	public void Set(ref CopyModInfoOptions other) { }

	// RVA: 0x4BC340 Offset: 0x4BB540 VA: 0x1804BC340 Slot: 5
	public void Set(ref Nullable<CopyModInfoOptions> other) { }

	// RVA: 0x4BC270 Offset: 0x4BB470 VA: 0x1804BC270 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Mods
public struct EnumerateModsCallbackInfo : ICallbackInfo // TypeDefIndex: 9085
{
	// Fields
	[CompilerGenerated]
	private Result <ResultCode>k__BackingField; // 0x0
	[CompilerGenerated]
	private EpicAccountId <LocalUserId>k__BackingField; // 0x8
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x10
	[CompilerGenerated]
	private ModEnumerationType <Type>k__BackingField; // 0x18

	// Properties
	public Result ResultCode { get; set; }
	public EpicAccountId LocalUserId { get; set; }
	public object ClientData { get; set; }
	public ModEnumerationType Type { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	[CompilerGenerated]
	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public EpicAccountId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_LocalUserId(EpicAccountId value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0 Slot: 4
	public object get_ClientData() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_ClientData(object value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public ModEnumerationType get_Type() { }

	[CompilerGenerated]
	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	public void set_Type(ModEnumerationType value) { }

	// RVA: 0x4BEED0 Offset: 0x4BE0D0 VA: 0x1804BEED0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x4BEF20 Offset: 0x4BE120 VA: 0x1804BEF20
	internal void Set(ref EnumerateModsCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.Mods
internal struct EnumerateModsCallbackInfoInternal : ICallbackInfoInternal, IGettable<EnumerateModsCallbackInfo>, ISettable<EnumerateModsCallbackInfo>, IDisposable // TypeDefIndex: 9086
{
	// Fields
	private Result m_ResultCode; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_ClientData; // 0x10
	private ModEnumerationType m_Type; // 0x18

	// Properties
	public Result ResultCode { get; set; }
	public EpicAccountId LocalUserId { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public ModEnumerationType Type { get; set; }

	// Methods

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	// RVA: 0x4BED90 Offset: 0x4BDF90 VA: 0x1804BED90
	public EpicAccountId get_LocalUserId() { }

	// RVA: 0x4BEE70 Offset: 0x4BE070 VA: 0x1804BEE70
	public void set_LocalUserId(EpicAccountId value) { }

	// RVA: 0x4BED20 Offset: 0x4BDF20 VA: 0x1804BED20
	public object get_ClientData() { }

	// RVA: 0x4BEE10 Offset: 0x4BE010 VA: 0x1804BEE10
	public void set_ClientData(object value) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public ModEnumerationType get_Type() { }

	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	public void set_Type(ModEnumerationType value) { }

	// RVA: 0x4BEB30 Offset: 0x4BDD30 VA: 0x1804BEB30 Slot: 6
	public void Set(ref EnumerateModsCallbackInfo other) { }

	// RVA: 0x4BEBF0 Offset: 0x4BDDF0 VA: 0x1804BEBF0 Slot: 7
	public void Set(ref Nullable<EnumerateModsCallbackInfo> other) { }

	// RVA: 0x4BEAB0 Offset: 0x4BDCB0 VA: 0x1804BEAB0 Slot: 8
	public void Dispose() { }

	// RVA: 0x4BEB10 Offset: 0x4BDD10 VA: 0x1804BEB10 Slot: 5
	public void Get(out EnumerateModsCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.Mods
public struct EnumerateModsOptions // TypeDefIndex: 9087
{
	// Fields
	[CompilerGenerated]
	private EpicAccountId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private ModEnumerationType <Type>k__BackingField; // 0x8

	// Properties
	public EpicAccountId LocalUserId { get; set; }
	public ModEnumerationType Type { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public EpicAccountId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_LocalUserId(EpicAccountId value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3F5510 Offset: 0x3F4710 VA: 0x1803F5510
	public ModEnumerationType get_Type() { }

	[CompilerGenerated]
	// RVA: 0x3F5520 Offset: 0x3F4720 VA: 0x1803F5520
	public void set_Type(ModEnumerationType value) { }
}

// Namespace: Epic.OnlineServices.Mods
internal struct EnumerateModsOptionsInternal : ISettable<EnumerateModsOptions>, IDisposable // TypeDefIndex: 9088
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private ModEnumerationType m_Type; // 0x10

	// Properties
	public EpicAccountId LocalUserId { set; }
	public ModEnumerationType Type { set; }

	// Methods

	// RVA: 0x4BF150 Offset: 0x4BE350 VA: 0x1804BF150
	public void set_LocalUserId(EpicAccountId value) { }

	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_Type(ModEnumerationType value) { }

	// RVA: 0x4BF0D0 Offset: 0x4BE2D0 VA: 0x1804BF0D0 Slot: 4
	public void Set(ref EnumerateModsOptions other) { }

	// RVA: 0x4BF010 Offset: 0x4BE210 VA: 0x1804BF010 Slot: 5
	public void Set(ref Nullable<EnumerateModsOptions> other) { }

	// RVA: 0x4BEFC0 Offset: 0x4BE1C0 VA: 0x1804BEFC0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Mods
public struct InstallModCallbackInfo : ICallbackInfo // TypeDefIndex: 9089
{
	// Fields
	[CompilerGenerated]
	private Result <ResultCode>k__BackingField; // 0x0
	[CompilerGenerated]
	private EpicAccountId <LocalUserId>k__BackingField; // 0x8
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x10
	[CompilerGenerated]
	private Nullable<ModIdentifier> <Mod>k__BackingField; // 0x18

	// Properties
	public Result ResultCode { get; set; }
	public EpicAccountId LocalUserId { get; set; }
	public object ClientData { get; set; }
	public Nullable<ModIdentifier> Mod { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	[CompilerGenerated]
	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public EpicAccountId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_LocalUserId(EpicAccountId value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0 Slot: 4
	public object get_ClientData() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_ClientData(object value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x4C1250 Offset: 0x4C0450 VA: 0x1804C1250
	public Nullable<ModIdentifier> get_Mod() { }

	[CompilerGenerated]
	// RVA: 0x4C1270 Offset: 0x4C0470 VA: 0x1804C1270
	public void set_Mod(Nullable<ModIdentifier> value) { }

	// RVA: 0x4C10F0 Offset: 0x4C02F0 VA: 0x1804C10F0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x4C1140 Offset: 0x4C0340 VA: 0x1804C1140
	internal void Set(ref InstallModCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.Mods
internal struct InstallModCallbackInfoInternal : ICallbackInfoInternal, IGettable<InstallModCallbackInfo>, ISettable<InstallModCallbackInfo>, IDisposable // TypeDefIndex: 9090
{
	// Fields
	private Result m_ResultCode; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_ClientData; // 0x10
	private IntPtr m_Mod; // 0x18

	// Properties
	public Result ResultCode { get; set; }
	public EpicAccountId LocalUserId { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public Nullable<ModIdentifier> Mod { get; set; }

	// Methods

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	// RVA: 0x4C0EC0 Offset: 0x4C00C0 VA: 0x1804C0EC0
	public EpicAccountId get_LocalUserId() { }

	// RVA: 0x4C1020 Offset: 0x4C0220 VA: 0x1804C1020
	public void set_LocalUserId(EpicAccountId value) { }

	// RVA: 0x4C0E50 Offset: 0x4C0050 VA: 0x1804C0E50
	public object get_ClientData() { }

	// RVA: 0x4C0FC0 Offset: 0x4C01C0 VA: 0x1804C0FC0
	public void set_ClientData(object value) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x4C0F40 Offset: 0x4C0140 VA: 0x1804C0F40
	public Nullable<ModIdentifier> get_Mod() { }

	// RVA: 0x4C1080 Offset: 0x4C0280 VA: 0x1804C1080
	public void set_Mod(Nullable<ModIdentifier> value) { }

	// RVA: 0x4C0D30 Offset: 0x4BFF30 VA: 0x1804C0D30 Slot: 6
	public void Set(ref InstallModCallbackInfo other) { }

	// RVA: 0x4C0B80 Offset: 0x4BFD80 VA: 0x1804C0B80 Slot: 7
	public void Set(ref Nullable<InstallModCallbackInfo> other) { }

	// RVA: 0x4C0AF0 Offset: 0x4BFCF0 VA: 0x1804C0AF0 Slot: 8
	public void Dispose() { }

	// RVA: 0x4C0B50 Offset: 0x4BFD50 VA: 0x1804C0B50 Slot: 5
	public void Get(out InstallModCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.Mods
public struct InstallModOptions // TypeDefIndex: 9091
{
	// Fields
	[CompilerGenerated]
	private EpicAccountId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private Nullable<ModIdentifier> <Mod>k__BackingField; // 0x8
	[CompilerGenerated]
	private bool <RemoveAfterExit>k__BackingField; // 0x38

	// Properties
	public EpicAccountId LocalUserId { get; set; }
	public Nullable<ModIdentifier> Mod { get; set; }
	public bool RemoveAfterExit { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public EpicAccountId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_LocalUserId(EpicAccountId value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x4C16D0 Offset: 0x4C08D0 VA: 0x1804C16D0
	public Nullable<ModIdentifier> get_Mod() { }

	[CompilerGenerated]
	// RVA: 0x4C16F0 Offset: 0x4C08F0 VA: 0x1804C16F0
	public void set_Mod(Nullable<ModIdentifier> value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x4BD700 Offset: 0x4BC900 VA: 0x1804BD700
	public bool get_RemoveAfterExit() { }

	[CompilerGenerated]
	// RVA: 0x4BD760 Offset: 0x4BC960 VA: 0x1804BD760
	public void set_RemoveAfterExit(bool value) { }
}

// Namespace: Epic.OnlineServices.Mods
internal struct InstallModOptionsInternal : ISettable<InstallModOptions>, IDisposable // TypeDefIndex: 9092
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_Mod; // 0x10
	private int m_RemoveAfterExit; // 0x18

	// Properties
	public EpicAccountId LocalUserId { set; }
	public Nullable<ModIdentifier> Mod { set; }
	public bool RemoveAfterExit { set; }

	// Methods

	// RVA: 0x4C15A0 Offset: 0x4C07A0 VA: 0x1804C15A0
	public void set_LocalUserId(EpicAccountId value) { }

	// RVA: 0x4C1600 Offset: 0x4C0800 VA: 0x1804C1600
	public void set_Mod(Nullable<ModIdentifier> value) { }

	// RVA: 0x4C1670 Offset: 0x4C0870 VA: 0x1804C1670
	public void set_RemoveAfterExit(bool value) { }

	// RVA: 0x4C12F0 Offset: 0x4C04F0 VA: 0x1804C12F0 Slot: 4
	public void Set(ref InstallModOptions other) { }

	// RVA: 0x4C1410 Offset: 0x4C0610 VA: 0x1804C1410 Slot: 5
	public void Set(ref Nullable<InstallModOptions> other) { }

	// RVA: 0x4C1290 Offset: 0x4C0490 VA: 0x1804C1290 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Mods
public enum ModEnumerationType // TypeDefIndex: 9093
{
	// Fields
	public int value__; // 0x0
	public const ModEnumerationType Installed = 0;
	public const ModEnumerationType AllAvailable = 1;
}

// Namespace: Epic.OnlineServices.Mods
public struct ModIdentifier // TypeDefIndex: 9094
{
	// Fields
	[CompilerGenerated]
	private Utf8String <NamespaceId>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <ItemId>k__BackingField; // 0x8
	[CompilerGenerated]
	private Utf8String <ArtifactId>k__BackingField; // 0x10
	[CompilerGenerated]
	private Utf8String <Title>k__BackingField; // 0x18
	[CompilerGenerated]
	private Utf8String <Version>k__BackingField; // 0x20

	// Properties
	public Utf8String NamespaceId { get; set; }
	public Utf8String ItemId { get; set; }
	public Utf8String ArtifactId { get; set; }
	public Utf8String Title { get; set; }
	public Utf8String Version { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Utf8String get_NamespaceId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_NamespaceId(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public Utf8String get_ItemId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_ItemId(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Utf8String get_ArtifactId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_ArtifactId(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public Utf8String get_Title() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_Title(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public Utf8String get_Version() { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_Version(Utf8String value) { }

	// RVA: 0x4CCF70 Offset: 0x4CC170 VA: 0x1804CCF70
	internal void Set(ref ModIdentifierInternal other) { }
}

// Namespace: Epic.OnlineServices.Mods
internal struct ModIdentifierInternal : IGettable<ModIdentifier>, ISettable<ModIdentifier>, IDisposable // TypeDefIndex: 9095
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_NamespaceId; // 0x8
	private IntPtr m_ItemId; // 0x10
	private IntPtr m_ArtifactId; // 0x18
	private IntPtr m_Title; // 0x20
	private IntPtr m_Version; // 0x28

	// Properties
	public Utf8String NamespaceId { get; set; }
	public Utf8String ItemId { get; set; }
	public Utf8String ArtifactId { get; set; }
	public Utf8String Title { get; set; }
	public Utf8String Version { get; set; }

	// Methods

	// RVA: 0x4CCC40 Offset: 0x4CBE40 VA: 0x1804CCC40
	public Utf8String get_NamespaceId() { }

	// RVA: 0x4CCE50 Offset: 0x4CC050 VA: 0x1804CCE50
	public void set_NamespaceId(Utf8String value) { }

	// RVA: 0x4CCBD0 Offset: 0x4CBDD0 VA: 0x1804CCBD0
	public Utf8String get_ItemId() { }

	// RVA: 0x4CCDF0 Offset: 0x4CBFF0 VA: 0x1804CCDF0
	public void set_ItemId(Utf8String value) { }

	// RVA: 0x4CCB60 Offset: 0x4CBD60 VA: 0x1804CCB60
	public Utf8String get_ArtifactId() { }

	// RVA: 0x4CCD90 Offset: 0x4CBF90 VA: 0x1804CCD90
	public void set_ArtifactId(Utf8String value) { }

	// RVA: 0x4CCCB0 Offset: 0x4CBEB0 VA: 0x1804CCCB0
	public Utf8String get_Title() { }

	// RVA: 0x4CCEB0 Offset: 0x4CC0B0 VA: 0x1804CCEB0
	public void set_Title(Utf8String value) { }

	// RVA: 0x4CCD20 Offset: 0x4CBF20 VA: 0x1804CCD20
	public Utf8String get_Version() { }

	// RVA: 0x4CCF10 Offset: 0x4CC110 VA: 0x1804CCF10
	public void set_Version(Utf8String value) { }

	// RVA: 0x4CC7E0 Offset: 0x4CB9E0 VA: 0x1804CC7E0 Slot: 5
	public void Set(ref ModIdentifier other) { }

	// RVA: 0x4CC960 Offset: 0x4CBB60 VA: 0x1804CC960 Slot: 6
	public void Set(ref Nullable<ModIdentifier> other) { }

	// RVA: 0x4CC730 Offset: 0x4CB930 VA: 0x1804CC730 Slot: 7
	public void Dispose() { }

	// RVA: 0x4CC7B0 Offset: 0x4CB9B0 VA: 0x1804CC7B0 Slot: 4
	public void Get(out ModIdentifier output) { }
}

// Namespace: Epic.OnlineServices.Mods
public struct ModInfo // TypeDefIndex: 9096
{
	// Fields
	[CompilerGenerated]
	private ModIdentifier[] <Mods>k__BackingField; // 0x0
	[CompilerGenerated]
	private ModEnumerationType <Type>k__BackingField; // 0x8

	// Properties
	public ModIdentifier[] Mods { get; set; }
	public ModEnumerationType Type { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public ModIdentifier[] get_Mods() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_Mods(ModIdentifier[] value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3F5510 Offset: 0x3F4710 VA: 0x1803F5510
	public ModEnumerationType get_Type() { }

	[CompilerGenerated]
	// RVA: 0x3F5520 Offset: 0x3F4720 VA: 0x1803F5520
	public void set_Type(ModEnumerationType value) { }

	// RVA: 0x4CD3F0 Offset: 0x4CC5F0 VA: 0x1804CD3F0
	internal void Set(ref ModInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.Mods
internal struct ModInfoInternal : IGettable<ModInfo>, ISettable<ModInfo>, IDisposable // TypeDefIndex: 9097
{
	// Fields
	private int m_ApiVersion; // 0x0
	private int m_ModsCount; // 0x4
	private IntPtr m_Mods; // 0x8
	private ModEnumerationType m_Type; // 0x10

	// Properties
	public ModIdentifier[] Mods { get; set; }
	public ModEnumerationType Type { get; set; }

	// Methods

	// RVA: 0x4CD2F0 Offset: 0x4CC4F0 VA: 0x1804CD2F0
	public ModIdentifier[] get_Mods() { }

	// RVA: 0x4CD380 Offset: 0x4CC580 VA: 0x1804CD380
	public void set_Mods(ModIdentifier[] value) { }

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public ModEnumerationType get_Type() { }

	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_Type(ModEnumerationType value) { }

	// RVA: 0x4CD1D0 Offset: 0x4CC3D0 VA: 0x1804CD1D0 Slot: 5
	public void Set(ref ModInfo other) { }

	// RVA: 0x4CD260 Offset: 0x4CC460 VA: 0x1804CD260 Slot: 6
	public void Set(ref Nullable<ModInfo> other) { }

	// RVA: 0x4CD140 Offset: 0x4CC340 VA: 0x1804CD140 Slot: 7
	public void Dispose() { }

	// RVA: 0x4CD190 Offset: 0x4CC390 VA: 0x1804CD190 Slot: 4
	public void Get(out ModInfo output) { }
}

// Namespace: Epic.OnlineServices.Mods
public sealed class ModsInterface : Handle // TypeDefIndex: 9098
{
	// Fields
	public const int CopymodinfoApiLatest = 1;
	public const int EnumeratemodsApiLatest = 1;
	public const int InstallmodApiLatest = 1;
	public const int ModIdentifierApiLatest = 1;
	public const int ModinfoApiLatest = 1;
	public const int UninstallmodApiLatest = 1;
	public const int UpdatemodApiLatest = 1;

	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }

	// RVA: 0x40BDB0 Offset: 0x40AFB0 VA: 0x18040BDB0
	public void .ctor(IntPtr innerHandle) { }

	// RVA: 0x4CD420 Offset: 0x4CC620 VA: 0x1804CD420
	public Result CopyModInfo(ref CopyModInfoOptions options, out Nullable<ModInfo> outEnumeratedMods) { }

	// RVA: 0x4CD570 Offset: 0x4CC770 VA: 0x1804CD570
	public void EnumerateMods(ref EnumerateModsOptions options, object clientData, OnEnumerateModsCallback completionDelegate) { }

	// RVA: 0x4CD760 Offset: 0x4CC960 VA: 0x1804CD760
	public void InstallMod(ref InstallModOptions options, object clientData, OnInstallModCallback completionDelegate) { }

	// RVA: 0x4CDC00 Offset: 0x4CCE00 VA: 0x1804CDC00
	public void UninstallMod(ref UninstallModOptions options, object clientData, OnUninstallModCallback completionDelegate) { }

	// RVA: 0x4CDDB0 Offset: 0x4CCFB0 VA: 0x1804CDDB0
	public void UpdateMod(ref UpdateModOptions options, object clientData, OnUpdateModCallback completionDelegate) { }

	[MonoPInvokeCallback(typeof(OnEnumerateModsCallbackInternal))]
	// RVA: 0x4CD910 Offset: 0x4CCB10 VA: 0x1804CD910
	internal static void OnEnumerateModsCallbackInternalImplementation(ref EnumerateModsCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnInstallModCallbackInternal))]
	// RVA: 0x4CD9C0 Offset: 0x4CCBC0 VA: 0x1804CD9C0
	internal static void OnInstallModCallbackInternalImplementation(ref InstallModCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnUninstallModCallbackInternal))]
	// RVA: 0x4CDA80 Offset: 0x4CCC80 VA: 0x1804CDA80
	internal static void OnUninstallModCallbackInternalImplementation(ref UninstallModCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnUpdateModCallbackInternal))]
	// RVA: 0x4CDB40 Offset: 0x4CCD40 VA: 0x1804CDB40
	internal static void OnUpdateModCallbackInternalImplementation(ref UpdateModCallbackInfoInternal data) { }
}

// Namespace: Epic.OnlineServices.Mods
public sealed class OnEnumerateModsCallback : MulticastDelegate // TypeDefIndex: 9099
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref EnumerateModsCallbackInfo data) { }

	// RVA: 0x4CDFF0 Offset: 0x4CD1F0 VA: 0x1804CDFF0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref EnumerateModsCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref EnumerateModsCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Mods
[UnmanagedFunctionPointer(2)]
internal sealed class OnEnumerateModsCallbackInternal : MulticastDelegate // TypeDefIndex: 9100
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref EnumerateModsCallbackInfoInternal data) { }

	// RVA: 0x4CDF60 Offset: 0x4CD160 VA: 0x1804CDF60 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref EnumerateModsCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref EnumerateModsCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Mods
public sealed class OnInstallModCallback : MulticastDelegate // TypeDefIndex: 9101
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref InstallModCallbackInfo data) { }

	// RVA: 0x4CE110 Offset: 0x4CD310 VA: 0x1804CE110 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref InstallModCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref InstallModCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Mods
[UnmanagedFunctionPointer(2)]
internal sealed class OnInstallModCallbackInternal : MulticastDelegate // TypeDefIndex: 9102
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref InstallModCallbackInfoInternal data) { }

	// RVA: 0x4CE080 Offset: 0x4CD280 VA: 0x1804CE080 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref InstallModCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref InstallModCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Mods
public sealed class OnUninstallModCallback : MulticastDelegate // TypeDefIndex: 9103
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref UninstallModCallbackInfo data) { }

	// RVA: 0x4CEF90 Offset: 0x4CE190 VA: 0x1804CEF90 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref UninstallModCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref UninstallModCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Mods
[UnmanagedFunctionPointer(2)]
internal sealed class OnUninstallModCallbackInternal : MulticastDelegate // TypeDefIndex: 9104
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref UninstallModCallbackInfoInternal data) { }

	// RVA: 0x4CEF00 Offset: 0x4CE100 VA: 0x1804CEF00 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref UninstallModCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref UninstallModCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Mods
public sealed class OnUpdateModCallback : MulticastDelegate // TypeDefIndex: 9105
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref UpdateModCallbackInfo data) { }

	// RVA: 0x4CF0B0 Offset: 0x4CE2B0 VA: 0x1804CF0B0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref UpdateModCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref UpdateModCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Mods
[UnmanagedFunctionPointer(2)]
internal sealed class OnUpdateModCallbackInternal : MulticastDelegate // TypeDefIndex: 9106
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref UpdateModCallbackInfoInternal data) { }

	// RVA: 0x4CF020 Offset: 0x4CE220 VA: 0x1804CF020 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref UpdateModCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref UpdateModCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Mods
public struct UninstallModCallbackInfo : ICallbackInfo // TypeDefIndex: 9107
{
	// Fields
	[CompilerGenerated]
	private Result <ResultCode>k__BackingField; // 0x0
	[CompilerGenerated]
	private EpicAccountId <LocalUserId>k__BackingField; // 0x8
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x10
	[CompilerGenerated]
	private Nullable<ModIdentifier> <Mod>k__BackingField; // 0x18

	// Properties
	public Result ResultCode { get; set; }
	public EpicAccountId LocalUserId { get; set; }
	public object ClientData { get; set; }
	public Nullable<ModIdentifier> Mod { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	[CompilerGenerated]
	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public EpicAccountId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_LocalUserId(EpicAccountId value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0 Slot: 4
	public object get_ClientData() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_ClientData(object value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x4C1250 Offset: 0x4C0450 VA: 0x1804C1250
	public Nullable<ModIdentifier> get_Mod() { }

	[CompilerGenerated]
	// RVA: 0x4C1270 Offset: 0x4C0470 VA: 0x1804C1270
	public void set_Mod(Nullable<ModIdentifier> value) { }

	// RVA: 0x4D2BF0 Offset: 0x4D1DF0 VA: 0x1804D2BF0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x4D2C40 Offset: 0x4D1E40 VA: 0x1804D2C40
	internal void Set(ref UninstallModCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.Mods
internal struct UninstallModCallbackInfoInternal : ICallbackInfoInternal, IGettable<UninstallModCallbackInfo>, ISettable<UninstallModCallbackInfo>, IDisposable // TypeDefIndex: 9108
{
	// Fields
	private Result m_ResultCode; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_ClientData; // 0x10
	private IntPtr m_Mod; // 0x18

	// Properties
	public Result ResultCode { get; set; }
	public EpicAccountId LocalUserId { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public Nullable<ModIdentifier> Mod { get; set; }

	// Methods

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	// RVA: 0x4D29C0 Offset: 0x4D1BC0 VA: 0x1804D29C0
	public EpicAccountId get_LocalUserId() { }

	// RVA: 0x4D2B20 Offset: 0x4D1D20 VA: 0x1804D2B20
	public void set_LocalUserId(EpicAccountId value) { }

	// RVA: 0x4D2950 Offset: 0x4D1B50 VA: 0x1804D2950
	public object get_ClientData() { }

	// RVA: 0x4D2AC0 Offset: 0x4D1CC0 VA: 0x1804D2AC0
	public void set_ClientData(object value) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x4D2A40 Offset: 0x4D1C40 VA: 0x1804D2A40
	public Nullable<ModIdentifier> get_Mod() { }

	// RVA: 0x4D2B80 Offset: 0x4D1D80 VA: 0x1804D2B80
	public void set_Mod(Nullable<ModIdentifier> value) { }

	// RVA: 0x4D2680 Offset: 0x4D1880 VA: 0x1804D2680 Slot: 6
	public void Set(ref UninstallModCallbackInfo other) { }

	// RVA: 0x4D27A0 Offset: 0x4D19A0 VA: 0x1804D27A0 Slot: 7
	public void Set(ref Nullable<UninstallModCallbackInfo> other) { }

	// RVA: 0x4D25F0 Offset: 0x4D17F0 VA: 0x1804D25F0 Slot: 8
	public void Dispose() { }

	// RVA: 0x4D2650 Offset: 0x4D1850 VA: 0x1804D2650 Slot: 5
	public void Get(out UninstallModCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.Mods
public struct UninstallModOptions // TypeDefIndex: 9109
{
	// Fields
	[CompilerGenerated]
	private EpicAccountId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private Nullable<ModIdentifier> <Mod>k__BackingField; // 0x8

	// Properties
	public EpicAccountId LocalUserId { get; set; }
	public Nullable<ModIdentifier> Mod { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public EpicAccountId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_LocalUserId(EpicAccountId value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x4C16D0 Offset: 0x4C08D0 VA: 0x1804C16D0
	public Nullable<ModIdentifier> get_Mod() { }

	[CompilerGenerated]
	// RVA: 0x4C16F0 Offset: 0x4C08F0 VA: 0x1804C16F0
	public void set_Mod(Nullable<ModIdentifier> value) { }
}

// Namespace: Epic.OnlineServices.Mods
internal struct UninstallModOptionsInternal : ISettable<UninstallModOptions>, IDisposable // TypeDefIndex: 9110
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_Mod; // 0x10

	// Properties
	public EpicAccountId LocalUserId { set; }
	public Nullable<ModIdentifier> Mod { set; }

	// Methods

	// RVA: 0x4D2FD0 Offset: 0x4D21D0 VA: 0x1804D2FD0
	public void set_LocalUserId(EpicAccountId value) { }

	// RVA: 0x4D3030 Offset: 0x4D2230 VA: 0x1804D3030
	public void set_Mod(Nullable<ModIdentifier> value) { }

	// RVA: 0x4D2EF0 Offset: 0x4D20F0 VA: 0x1804D2EF0 Slot: 4
	public void Set(ref UninstallModOptions other) { }

	// RVA: 0x4D2DB0 Offset: 0x4D1FB0 VA: 0x1804D2DB0 Slot: 5
	public void Set(ref Nullable<UninstallModOptions> other) { }

	// RVA: 0x4D2D50 Offset: 0x4D1F50 VA: 0x1804D2D50 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Mods
public struct UpdateModCallbackInfo : ICallbackInfo // TypeDefIndex: 9111
{
	// Fields
	[CompilerGenerated]
	private Result <ResultCode>k__BackingField; // 0x0
	[CompilerGenerated]
	private EpicAccountId <LocalUserId>k__BackingField; // 0x8
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x10
	[CompilerGenerated]
	private Nullable<ModIdentifier> <Mod>k__BackingField; // 0x18

	// Properties
	public Result ResultCode { get; set; }
	public EpicAccountId LocalUserId { get; set; }
	public object ClientData { get; set; }
	public Nullable<ModIdentifier> Mod { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	[CompilerGenerated]
	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public EpicAccountId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_LocalUserId(EpicAccountId value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0 Slot: 4
	public object get_ClientData() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_ClientData(object value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x4C1250 Offset: 0x4C0450 VA: 0x1804C1250
	public Nullable<ModIdentifier> get_Mod() { }

	[CompilerGenerated]
	// RVA: 0x4C1270 Offset: 0x4C0470 VA: 0x1804C1270
	public void set_Mod(Nullable<ModIdentifier> value) { }

	// RVA: 0x4D36A0 Offset: 0x4D28A0 VA: 0x1804D36A0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x4D36F0 Offset: 0x4D28F0 VA: 0x1804D36F0
	internal void Set(ref UpdateModCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.Mods
internal struct UpdateModCallbackInfoInternal : ICallbackInfoInternal, IGettable<UpdateModCallbackInfo>, ISettable<UpdateModCallbackInfo>, IDisposable // TypeDefIndex: 9112
{
	// Fields
	private Result m_ResultCode; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_ClientData; // 0x10
	private IntPtr m_Mod; // 0x18

	// Properties
	public Result ResultCode { get; set; }
	public EpicAccountId LocalUserId { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public Nullable<ModIdentifier> Mod { get; set; }

	// Methods

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	// RVA: 0x4D3470 Offset: 0x4D2670 VA: 0x1804D3470
	public EpicAccountId get_LocalUserId() { }

	// RVA: 0x4D35D0 Offset: 0x4D27D0 VA: 0x1804D35D0
	public void set_LocalUserId(EpicAccountId value) { }

	// RVA: 0x4D3400 Offset: 0x4D2600 VA: 0x1804D3400
	public object get_ClientData() { }

	// RVA: 0x4D3570 Offset: 0x4D2770 VA: 0x1804D3570
	public void set_ClientData(object value) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x4D34F0 Offset: 0x4D26F0 VA: 0x1804D34F0
	public Nullable<ModIdentifier> get_Mod() { }

	// RVA: 0x4D3630 Offset: 0x4D2830 VA: 0x1804D3630
	public void set_Mod(Nullable<ModIdentifier> value) { }

	// RVA: 0x4D32E0 Offset: 0x4D24E0 VA: 0x1804D32E0 Slot: 6
	public void Set(ref UpdateModCallbackInfo other) { }

	// RVA: 0x4D3130 Offset: 0x4D2330 VA: 0x1804D3130 Slot: 7
	public void Set(ref Nullable<UpdateModCallbackInfo> other) { }

	// RVA: 0x4D30A0 Offset: 0x4D22A0 VA: 0x1804D30A0 Slot: 8
	public void Dispose() { }

	// RVA: 0x4D3100 Offset: 0x4D2300 VA: 0x1804D3100 Slot: 5
	public void Get(out UpdateModCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.Mods
public struct UpdateModOptions // TypeDefIndex: 9113
{
	// Fields
	[CompilerGenerated]
	private EpicAccountId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private Nullable<ModIdentifier> <Mod>k__BackingField; // 0x8

	// Properties
	public EpicAccountId LocalUserId { get; set; }
	public Nullable<ModIdentifier> Mod { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public EpicAccountId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_LocalUserId(EpicAccountId value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x4C16D0 Offset: 0x4C08D0 VA: 0x1804C16D0
	public Nullable<ModIdentifier> get_Mod() { }

	[CompilerGenerated]
	// RVA: 0x4C16F0 Offset: 0x4C08F0 VA: 0x1804C16F0
	public void set_Mod(Nullable<ModIdentifier> value) { }
}

// Namespace: Epic.OnlineServices.Mods
internal struct UpdateModOptionsInternal : ISettable<UpdateModOptions>, IDisposable // TypeDefIndex: 9114
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_Mod; // 0x10

	// Properties
	public EpicAccountId LocalUserId { set; }
	public Nullable<ModIdentifier> Mod { set; }

	// Methods

	// RVA: 0x4D3A80 Offset: 0x4D2C80 VA: 0x1804D3A80
	public void set_LocalUserId(EpicAccountId value) { }

	// RVA: 0x4D3AE0 Offset: 0x4D2CE0 VA: 0x1804D3AE0
	public void set_Mod(Nullable<ModIdentifier> value) { }

	// RVA: 0x4D39A0 Offset: 0x4D2BA0 VA: 0x1804D39A0 Slot: 4
	public void Set(ref UpdateModOptions other) { }

	// RVA: 0x4D3860 Offset: 0x4D2A60 VA: 0x1804D3860 Slot: 5
	public void Set(ref Nullable<UpdateModOptions> other) { }

	// RVA: 0x4D3800 Offset: 0x4D2A00 VA: 0x1804D3800 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Metrics
public struct BeginPlayerSessionOptions // TypeDefIndex: 9115
{
	// Fields
	[CompilerGenerated]
	private BeginPlayerSessionOptionsAccountId <AccountId>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <DisplayName>k__BackingField; // 0x18
	[CompilerGenerated]
	private UserControllerType <ControllerType>k__BackingField; // 0x20
	[CompilerGenerated]
	private Utf8String <ServerIp>k__BackingField; // 0x28
	[CompilerGenerated]
	private Utf8String <GameSessionId>k__BackingField; // 0x30

	// Properties
	public BeginPlayerSessionOptionsAccountId AccountId { get; set; }
	public Utf8String DisplayName { get; set; }
	public UserControllerType ControllerType { get; set; }
	public Utf8String ServerIp { get; set; }
	public Utf8String GameSessionId { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x4BBD30 Offset: 0x4BAF30 VA: 0x1804BBD30
	public BeginPlayerSessionOptionsAccountId get_AccountId() { }

	[CompilerGenerated]
	// RVA: 0x4BBD50 Offset: 0x4BAF50 VA: 0x1804BBD50
	public void set_AccountId(BeginPlayerSessionOptionsAccountId value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public Utf8String get_DisplayName() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_DisplayName(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400
	public UserControllerType get_ControllerType() { }

	[CompilerGenerated]
	// RVA: 0x3DA420 Offset: 0x3D9620 VA: 0x1803DA420
	public void set_ControllerType(UserControllerType value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public Utf8String get_ServerIp() { }

	[CompilerGenerated]
	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	public void set_ServerIp(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public Utf8String get_GameSessionId() { }

	[CompilerGenerated]
	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	public void set_GameSessionId(Utf8String value) { }
}

// Namespace: Epic.OnlineServices.Metrics
internal struct BeginPlayerSessionOptionsInternal : ISettable<BeginPlayerSessionOptions>, IDisposable // TypeDefIndex: 9116
{
	// Fields
	private int m_ApiVersion; // 0x0
	private BeginPlayerSessionOptionsAccountIdInternal m_AccountId; // 0x4
	private IntPtr m_DisplayName; // 0x10
	private UserControllerType m_ControllerType; // 0x18
	private IntPtr m_ServerIp; // 0x20
	private IntPtr m_GameSessionId; // 0x28

	// Properties
	public BeginPlayerSessionOptionsAccountId AccountId { set; }
	public Utf8String DisplayName { set; }
	public UserControllerType ControllerType { set; }
	public Utf8String ServerIp { set; }
	public Utf8String GameSessionId { set; }

	// Methods

	// RVA: 0x4BBBA0 Offset: 0x4BADA0 VA: 0x1804BBBA0
	public void set_AccountId(BeginPlayerSessionOptionsAccountId value) { }

	// RVA: 0x4BBC10 Offset: 0x4BAE10 VA: 0x1804BBC10
	public void set_DisplayName(Utf8String value) { }

	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	public void set_ControllerType(UserControllerType value) { }

	// RVA: 0x4BBCD0 Offset: 0x4BAED0 VA: 0x1804BBCD0
	public void set_ServerIp(Utf8String value) { }

	// RVA: 0x4BBC70 Offset: 0x4BAE70 VA: 0x1804BBC70
	public void set_GameSessionId(Utf8String value) { }

	// RVA: 0x4BBA30 Offset: 0x4BAC30 VA: 0x1804BBA30 Slot: 4
	public void Set(ref BeginPlayerSessionOptions other) { }

	// RVA: 0x4BB830 Offset: 0x4BAA30 VA: 0x1804BB830 Slot: 5
	public void Set(ref Nullable<BeginPlayerSessionOptions> other) { }

	// RVA: 0x4BB7B0 Offset: 0x4BA9B0 VA: 0x1804BB7B0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Metrics
public struct BeginPlayerSessionOptionsAccountId // TypeDefIndex: 9117
{
	// Fields
	private MetricsAccountIdType m_AccountIdType; // 0x0
	private EpicAccountId m_Epic; // 0x8
	private Utf8String m_External; // 0x10

	// Properties
	public MetricsAccountIdType AccountIdType { get; set; }
	public EpicAccountId Epic { get; set; }
	public Utf8String External { get; set; }

	// Methods

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public MetricsAccountIdType get_AccountIdType() { }

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	private void set_AccountIdType(MetricsAccountIdType value) { }

	// RVA: 0x4BB4A0 Offset: 0x4BA6A0 VA: 0x1804BB4A0
	public EpicAccountId get_Epic() { }

	// RVA: 0x4BB6A0 Offset: 0x4BA8A0 VA: 0x1804BB6A0
	public void set_Epic(EpicAccountId value) { }

	// RVA: 0x4BB530 Offset: 0x4BA730 VA: 0x1804BB530
	public Utf8String get_External() { }

	// RVA: 0x4BB720 Offset: 0x4BA920 VA: 0x1804BB720
	public void set_External(Utf8String value) { }

	// RVA: 0x4BB5C0 Offset: 0x4BA7C0 VA: 0x1804BB5C0
	public static BeginPlayerSessionOptionsAccountId op_Implicit(EpicAccountId value) { }

	// RVA: 0x4BB5F0 Offset: 0x4BA7F0 VA: 0x1804BB5F0
	public static BeginPlayerSessionOptionsAccountId op_Implicit(Utf8String value) { }

	// RVA: 0x4BB620 Offset: 0x4BA820 VA: 0x1804BB620
	public static BeginPlayerSessionOptionsAccountId op_Implicit(string value) { }

	// RVA: 0x4BB450 Offset: 0x4BA650 VA: 0x1804BB450
	internal void Set(ref BeginPlayerSessionOptionsAccountIdInternal other) { }
}

// Namespace: Epic.OnlineServices.Metrics
internal struct BeginPlayerSessionOptionsAccountIdInternal : IGettable<BeginPlayerSessionOptionsAccountId>, ISettable<BeginPlayerSessionOptionsAccountId>, IDisposable // TypeDefIndex: 9118
{
	// Fields
	private MetricsAccountIdType m_AccountIdType; // 0x0
	private IntPtr m_Epic; // 0x4
	private IntPtr m_External; // 0x4

	// Properties
	public EpicAccountId Epic { get; set; }
	public Utf8String External { get; set; }

	// Methods

	// RVA: 0x4BB1B0 Offset: 0x4BA3B0 VA: 0x1804BB1B0
	public EpicAccountId get_Epic() { }

	// RVA: 0x4BB2D0 Offset: 0x4BA4D0 VA: 0x1804BB2D0
	public void set_Epic(EpicAccountId value) { }

	// RVA: 0x4BB240 Offset: 0x4BA440 VA: 0x1804BB240
	public Utf8String get_External() { }

	// RVA: 0x4BB390 Offset: 0x4BA590 VA: 0x1804BB390
	public void set_External(Utf8String value) { }

	// RVA: 0x4BAFF0 Offset: 0x4BA1F0 VA: 0x1804BAFF0 Slot: 5
	public void Set(ref BeginPlayerSessionOptionsAccountId other) { }

	// RVA: 0x4BB040 Offset: 0x4BA240 VA: 0x1804BB040 Slot: 6
	public void Set(ref Nullable<BeginPlayerSessionOptionsAccountId> other) { }

	// RVA: 0x4BAF20 Offset: 0x4BA120 VA: 0x1804BAF20 Slot: 7
	public void Dispose() { }

	// RVA: 0x4BAF90 Offset: 0x4BA190 VA: 0x1804BAF90 Slot: 4
	public void Get(out BeginPlayerSessionOptionsAccountId output) { }
}

// Namespace: Epic.OnlineServices.Metrics
public struct EndPlayerSessionOptions // TypeDefIndex: 9119
{
	// Fields
	[CompilerGenerated]
	private EndPlayerSessionOptionsAccountId <AccountId>k__BackingField; // 0x0

	// Properties
	public EndPlayerSessionOptionsAccountId AccountId { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x4BBD30 Offset: 0x4BAF30 VA: 0x1804BBD30
	public EndPlayerSessionOptionsAccountId get_AccountId() { }

	[CompilerGenerated]
	// RVA: 0x4BBD50 Offset: 0x4BAF50 VA: 0x1804BBD50
	public void set_AccountId(EndPlayerSessionOptionsAccountId value) { }
}

// Namespace: Epic.OnlineServices.Metrics
internal struct EndPlayerSessionOptionsInternal : ISettable<EndPlayerSessionOptions>, IDisposable // TypeDefIndex: 9120
{
	// Fields
	private int m_ApiVersion; // 0x0
	private EndPlayerSessionOptionsAccountIdInternal m_AccountId; // 0x4

	// Properties
	public EndPlayerSessionOptionsAccountId AccountId { set; }

	// Methods

	// RVA: 0x4BEA40 Offset: 0x4BDC40 VA: 0x1804BEA40
	public void set_AccountId(EndPlayerSessionOptionsAccountId value) { }

	// RVA: 0x4BE8F0 Offset: 0x4BDAF0 VA: 0x1804BE8F0 Slot: 4
	public void Set(ref EndPlayerSessionOptions other) { }

	// RVA: 0x4BE970 Offset: 0x4BDB70 VA: 0x1804BE970 Slot: 5
	public void Set(ref Nullable<EndPlayerSessionOptions> other) { }

	// RVA: 0x4BE890 Offset: 0x4BDA90 VA: 0x1804BE890 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Metrics
public struct EndPlayerSessionOptionsAccountId // TypeDefIndex: 9121
{
	// Fields
	private MetricsAccountIdType m_AccountIdType; // 0x0
	private EpicAccountId m_Epic; // 0x8
	private Utf8String m_External; // 0x10

	// Properties
	public MetricsAccountIdType AccountIdType { get; set; }
	public EpicAccountId Epic { get; set; }
	public Utf8String External { get; set; }

	// Methods

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public MetricsAccountIdType get_AccountIdType() { }

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	private void set_AccountIdType(MetricsAccountIdType value) { }

	// RVA: 0x4BE580 Offset: 0x4BD780 VA: 0x1804BE580
	public EpicAccountId get_Epic() { }

	// RVA: 0x4BE780 Offset: 0x4BD980 VA: 0x1804BE780
	public void set_Epic(EpicAccountId value) { }

	// RVA: 0x4BE610 Offset: 0x4BD810 VA: 0x1804BE610
	public Utf8String get_External() { }

	// RVA: 0x4BE800 Offset: 0x4BDA00 VA: 0x1804BE800
	public void set_External(Utf8String value) { }

	// RVA: 0x4BE6A0 Offset: 0x4BD8A0 VA: 0x1804BE6A0
	public static EndPlayerSessionOptionsAccountId op_Implicit(EpicAccountId value) { }

	// RVA: 0x4BE6D0 Offset: 0x4BD8D0 VA: 0x1804BE6D0
	public static EndPlayerSessionOptionsAccountId op_Implicit(Utf8String value) { }

	// RVA: 0x4BE700 Offset: 0x4BD900 VA: 0x1804BE700
	public static EndPlayerSessionOptionsAccountId op_Implicit(string value) { }

	// RVA: 0x4BE530 Offset: 0x4BD730 VA: 0x1804BE530
	internal void Set(ref EndPlayerSessionOptionsAccountIdInternal other) { }
}

// Namespace: Epic.OnlineServices.Metrics
internal struct EndPlayerSessionOptionsAccountIdInternal : IGettable<EndPlayerSessionOptionsAccountId>, ISettable<EndPlayerSessionOptionsAccountId>, IDisposable // TypeDefIndex: 9122
{
	// Fields
	private MetricsAccountIdType m_AccountIdType; // 0x0
	private IntPtr m_Epic; // 0x4
	private IntPtr m_External; // 0x4

	// Properties
	public EpicAccountId Epic { get; set; }
	public Utf8String External { get; set; }

	// Methods

	// RVA: 0x4BE290 Offset: 0x4BD490 VA: 0x1804BE290
	public EpicAccountId get_Epic() { }

	// RVA: 0x4BE3B0 Offset: 0x4BD5B0 VA: 0x1804BE3B0
	public void set_Epic(EpicAccountId value) { }

	// RVA: 0x4BE320 Offset: 0x4BD520 VA: 0x1804BE320
	public Utf8String get_External() { }

	// RVA: 0x4BE470 Offset: 0x4BD670 VA: 0x1804BE470
	public void set_External(Utf8String value) { }

	// RVA: 0x4BE0D0 Offset: 0x4BD2D0 VA: 0x1804BE0D0 Slot: 5
	public void Set(ref EndPlayerSessionOptionsAccountId other) { }

	// RVA: 0x4BE120 Offset: 0x4BD320 VA: 0x1804BE120 Slot: 6
	public void Set(ref Nullable<EndPlayerSessionOptionsAccountId> other) { }

	// RVA: 0x4BE000 Offset: 0x4BD200 VA: 0x1804BE000 Slot: 7
	public void Dispose() { }

	// RVA: 0x4BE070 Offset: 0x4BD270 VA: 0x1804BE070 Slot: 4
	public void Get(out EndPlayerSessionOptionsAccountId output) { }
}

// Namespace: Epic.OnlineServices.Metrics
public enum MetricsAccountIdType // TypeDefIndex: 9123
{
	// Fields
	public int value__; // 0x0
	public const MetricsAccountIdType Epic = 0;
	public const MetricsAccountIdType External = 1;
}

// Namespace: Epic.OnlineServices.Metrics
public sealed class MetricsInterface : Handle // TypeDefIndex: 9124
{
	// Fields
	public const int BeginplayersessionApiLatest = 1;
	public const int EndplayersessionApiLatest = 1;

	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }

	// RVA: 0x40BDB0 Offset: 0x40AFB0 VA: 0x18040BDB0
	public void .ctor(IntPtr innerHandle) { }

	// RVA: 0x4CC590 Offset: 0x4CB790 VA: 0x1804CC590
	public Result BeginPlayerSession(ref BeginPlayerSessionOptions options) { }

	// RVA: 0x4CC630 Offset: 0x4CB830 VA: 0x1804CC630
	public Result EndPlayerSession(ref EndPlayerSessionOptions options) { }
}

// Namespace: Epic.OnlineServices.Metrics
public enum UserControllerType // TypeDefIndex: 9125
{
	// Fields
	public int value__; // 0x0
	public const UserControllerType Unknown = 0;
	public const UserControllerType MouseKeyboard = 1;
	public const UserControllerType GamepadControl = 2;
	public const UserControllerType TouchControl = 3;
}

// Namespace: Epic.OnlineServices.Logging
public enum LogCategory // TypeDefIndex: 9126
{
	// Fields
	public int value__; // 0x0
	public const LogCategory Core = 0;
	public const LogCategory Auth = 1;
	public const LogCategory Friends = 2;
	public const LogCategory Presence = 3;
	public const LogCategory UserInfo = 4;
	public const LogCategory HttpSerialization = 5;
	public const LogCategory Ecom = 6;
	public const LogCategory P2P = 7;
	public const LogCategory Sessions = 8;
	public const LogCategory RateLimiter = 9;
	public const LogCategory PlayerDataStorage = 10;
	public const LogCategory Analytics = 11;
	public const LogCategory Messaging = 12;
	public const LogCategory Connect = 13;
	public const LogCategory Overlay = 14;
	public const LogCategory Achievements = 15;
	public const LogCategory Stats = 16;
	public const LogCategory Ui = 17;
	public const LogCategory Lobby = 18;
	public const LogCategory Leaderboards = 19;
	public const LogCategory Keychain = 20;
	public const LogCategory IntegratedPlatform = 21;
	public const LogCategory TitleStorage = 22;
	public const LogCategory Mods = 23;
	public const LogCategory AntiCheat = 24;
	public const LogCategory Reports = 25;
	public const LogCategory Sanctions = 26;
	public const LogCategory ProgressionSnapshots = 27;
	public const LogCategory Kws = 28;
	public const LogCategory Rtc = 29;
	public const LogCategory RTCAdmin = 30;
	public const LogCategory CustomInvites = 31;
	public const LogCategory Inventory = 32;
	public const LogCategory ReceiptValidator = 33;
	public const LogCategory AllCategories = 2147483647;
}

// Namespace: Epic.OnlineServices.Logging
public sealed class LoggingInterface // TypeDefIndex: 9127
{
	// Methods

	// RVA: 0x4CC450 Offset: 0x4CB650 VA: 0x1804CC450
	public static Result SetCallback(LogMessageFunc callback) { }

	// RVA: 0x4CC580 Offset: 0x4CB780 VA: 0x1804CC580
	public static Result SetLogLevel(LogCategory logCategory, LogLevel logLevel) { }

	[MonoPInvokeCallback(typeof(LogMessageFuncInternal))]
	// RVA: 0x4CC360 Offset: 0x4CB560 VA: 0x1804CC360
	internal static void LogMessageFuncInternalImplementation(ref LogMessageInternal message) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: Epic.OnlineServices.Logging
public enum LogLevel // TypeDefIndex: 9128
{
	// Fields
	public int value__; // 0x0
	public const LogLevel Off = 0;
	public const LogLevel Fatal = 100;
	public const LogLevel Error = 200;
	public const LogLevel Warning = 300;
	public const LogLevel Info = 400;
	public const LogLevel Verbose = 500;
	public const LogLevel VeryVerbose = 600;
}

// Namespace: Epic.OnlineServices.Logging
public struct LogMessage // TypeDefIndex: 9129
{
	// Fields
	[CompilerGenerated]
	private Utf8String <Category>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <Message>k__BackingField; // 0x8
	[CompilerGenerated]
	private LogLevel <Level>k__BackingField; // 0x10

	// Properties
	public Utf8String Category { get; set; }
	public Utf8String Message { get; set; }
	public LogLevel Level { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Utf8String get_Category() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_Category(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public Utf8String get_Message() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_Message(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public LogLevel get_Level() { }

	[CompilerGenerated]
	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_Level(LogLevel value) { }

	// RVA: 0x4CC280 Offset: 0x4CB480 VA: 0x1804CC280
	internal void Set(ref LogMessageInternal other) { }
}

// Namespace: Epic.OnlineServices.Logging
internal struct LogMessageInternal : IGettable<LogMessage>, ISettable<LogMessage>, IDisposable // TypeDefIndex: 9130
{
	// Fields
	private IntPtr m_Category; // 0x0
	private IntPtr m_Message; // 0x8
	private LogLevel m_Level; // 0x10

	// Properties
	public Utf8String Category { get; set; }
	public Utf8String Message { get; set; }
	public LogLevel Level { get; set; }

	// Methods

	// RVA: 0x4CC0E0 Offset: 0x4CB2E0 VA: 0x1804CC0E0
	public Utf8String get_Category() { }

	// RVA: 0x4CC1C0 Offset: 0x4CB3C0 VA: 0x1804CC1C0
	public void set_Category(Utf8String value) { }

	// RVA: 0x4CC150 Offset: 0x4CB350 VA: 0x1804CC150
	public Utf8String get_Message() { }

	// RVA: 0x4CC220 Offset: 0x4CB420 VA: 0x1804CC220
	public void set_Message(Utf8String value) { }

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public LogLevel get_Level() { }

	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_Level(LogLevel value) { }

	// RVA: 0x4CC020 Offset: 0x4CB220 VA: 0x1804CC020 Slot: 5
	public void Set(ref LogMessage other) { }

	// RVA: 0x4CBF00 Offset: 0x4CB100 VA: 0x1804CBF00 Slot: 6
	public void Set(ref Nullable<LogMessage> other) { }

	// RVA: 0x4CBE80 Offset: 0x4CB080 VA: 0x1804CBE80 Slot: 7
	public void Dispose() { }

	// RVA: 0x4CBEE0 Offset: 0x4CB0E0 VA: 0x1804CBEE0 Slot: 4
	public void Get(out LogMessage output) { }
}

// Namespace: Epic.OnlineServices.Logging
public sealed class LogMessageFunc : MulticastDelegate // TypeDefIndex: 9131
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref LogMessage message) { }

	// RVA: 0x4CBDF0 Offset: 0x4CAFF0 VA: 0x1804CBDF0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref LogMessage message, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref LogMessage message, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Logging
[UnmanagedFunctionPointer(2)]
internal sealed class LogMessageFuncInternal : MulticastDelegate // TypeDefIndex: 9132
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref LogMessageInternal message) { }

	// RVA: 0x4CBD60 Offset: 0x4CAF60 VA: 0x1804CBD60 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref LogMessageInternal message, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref LogMessageInternal message, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Lobby
public struct AddNotifyJoinLobbyAcceptedOptions // TypeDefIndex: 9133
{}

// Namespace: Epic.OnlineServices.Lobby
internal struct AddNotifyJoinLobbyAcceptedOptionsInternal : ISettable<AddNotifyJoinLobbyAcceptedOptions>, IDisposable // TypeDefIndex: 9134
{
	// Fields
	private int m_ApiVersion; // 0x0

	// Methods

	// RVA: 0x3F98A0 Offset: 0x3F8AA0 VA: 0x1803F98A0 Slot: 4
	public void Set(ref AddNotifyJoinLobbyAcceptedOptions other) { }

	// RVA: 0x4B8BA0 Offset: 0x4B7DA0 VA: 0x1804B8BA0 Slot: 5
	public void Set(ref Nullable<AddNotifyJoinLobbyAcceptedOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Lobby
public struct AddNotifyLeaveLobbyRequestedOptions // TypeDefIndex: 9135
{}

// Namespace: Epic.OnlineServices.Lobby
internal struct AddNotifyLeaveLobbyRequestedOptionsInternal : ISettable<AddNotifyLeaveLobbyRequestedOptions>, IDisposable // TypeDefIndex: 9136
{
	// Fields
	private int m_ApiVersion; // 0x0

	// Methods

	// RVA: 0x3F98A0 Offset: 0x3F8AA0 VA: 0x1803F98A0 Slot: 4
	public void Set(ref AddNotifyLeaveLobbyRequestedOptions other) { }

	// RVA: 0x4B8BF0 Offset: 0x4B7DF0 VA: 0x1804B8BF0 Slot: 5
	public void Set(ref Nullable<AddNotifyLeaveLobbyRequestedOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Lobby
public struct AddNotifyLobbyInviteAcceptedOptions // TypeDefIndex: 9137
{}

// Namespace: Epic.OnlineServices.Lobby
internal struct AddNotifyLobbyInviteAcceptedOptionsInternal : ISettable<AddNotifyLobbyInviteAcceptedOptions>, IDisposable // TypeDefIndex: 9138
{
	// Fields
	private int m_ApiVersion; // 0x0

	// Methods

	// RVA: 0x3F98A0 Offset: 0x3F8AA0 VA: 0x1803F98A0 Slot: 4
	public void Set(ref AddNotifyLobbyInviteAcceptedOptions other) { }

	// RVA: 0x4B8C40 Offset: 0x4B7E40 VA: 0x1804B8C40 Slot: 5
	public void Set(ref Nullable<AddNotifyLobbyInviteAcceptedOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Lobby
public struct AddNotifyLobbyInviteReceivedOptions // TypeDefIndex: 9139
{}

// Namespace: Epic.OnlineServices.Lobby
internal struct AddNotifyLobbyInviteReceivedOptionsInternal : ISettable<AddNotifyLobbyInviteReceivedOptions>, IDisposable // TypeDefIndex: 9140
{
	// Fields
	private int m_ApiVersion; // 0x0

	// Methods

	// RVA: 0x3F98A0 Offset: 0x3F8AA0 VA: 0x1803F98A0 Slot: 4
	public void Set(ref AddNotifyLobbyInviteReceivedOptions other) { }

	// RVA: 0x4B8C90 Offset: 0x4B7E90 VA: 0x1804B8C90 Slot: 5
	public void Set(ref Nullable<AddNotifyLobbyInviteReceivedOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Lobby
public struct AddNotifyLobbyInviteRejectedOptions // TypeDefIndex: 9141
{}

// Namespace: Epic.OnlineServices.Lobby
internal struct AddNotifyLobbyInviteRejectedOptionsInternal : ISettable<AddNotifyLobbyInviteRejectedOptions>, IDisposable // TypeDefIndex: 9142
{
	// Fields
	private int m_ApiVersion; // 0x0

	// Methods

	// RVA: 0x3F98A0 Offset: 0x3F8AA0 VA: 0x1803F98A0 Slot: 4
	public void Set(ref AddNotifyLobbyInviteRejectedOptions other) { }

	// RVA: 0x4B8CE0 Offset: 0x4B7EE0 VA: 0x1804B8CE0 Slot: 5
	public void Set(ref Nullable<AddNotifyLobbyInviteRejectedOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Lobby
public struct AddNotifyLobbyMemberStatusReceivedOptions // TypeDefIndex: 9143
{}

// Namespace: Epic.OnlineServices.Lobby
internal struct AddNotifyLobbyMemberStatusReceivedOptionsInternal : ISettable<AddNotifyLobbyMemberStatusReceivedOptions>, IDisposable // TypeDefIndex: 9144
{
	// Fields
	private int m_ApiVersion; // 0x0

	// Methods

	// RVA: 0x3F98A0 Offset: 0x3F8AA0 VA: 0x1803F98A0 Slot: 4
	public void Set(ref AddNotifyLobbyMemberStatusReceivedOptions other) { }

	// RVA: 0x4B8D30 Offset: 0x4B7F30 VA: 0x1804B8D30 Slot: 5
	public void Set(ref Nullable<AddNotifyLobbyMemberStatusReceivedOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Lobby
public struct AddNotifyLobbyMemberUpdateReceivedOptions // TypeDefIndex: 9145
{}

// Namespace: Epic.OnlineServices.Lobby
internal struct AddNotifyLobbyMemberUpdateReceivedOptionsInternal : ISettable<AddNotifyLobbyMemberUpdateReceivedOptions>, IDisposable // TypeDefIndex: 9146
{
	// Fields
	private int m_ApiVersion; // 0x0

	// Methods

	// RVA: 0x3F98A0 Offset: 0x3F8AA0 VA: 0x1803F98A0 Slot: 4
	public void Set(ref AddNotifyLobbyMemberUpdateReceivedOptions other) { }

	// RVA: 0x4B8D80 Offset: 0x4B7F80 VA: 0x1804B8D80 Slot: 5
	public void Set(ref Nullable<AddNotifyLobbyMemberUpdateReceivedOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Lobby
public struct AddNotifyLobbyUpdateReceivedOptions // TypeDefIndex: 9147
{}

// Namespace: Epic.OnlineServices.Lobby
internal struct AddNotifyLobbyUpdateReceivedOptionsInternal : ISettable<AddNotifyLobbyUpdateReceivedOptions>, IDisposable // TypeDefIndex: 9148
{
	// Fields
	private int m_ApiVersion; // 0x0

	// Methods

	// RVA: 0x3F98A0 Offset: 0x3F8AA0 VA: 0x1803F98A0 Slot: 4
	public void Set(ref AddNotifyLobbyUpdateReceivedOptions other) { }

	// RVA: 0x4B8DD0 Offset: 0x4B7FD0 VA: 0x1804B8DD0 Slot: 5
	public void Set(ref Nullable<AddNotifyLobbyUpdateReceivedOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Lobby
public struct AddNotifyRTCRoomConnectionChangedOptions // TypeDefIndex: 9149
{
	// Fields
	[CompilerGenerated]
	private Utf8String <LobbyId_DEPRECATED>k__BackingField; // 0x0
	[CompilerGenerated]
	private ProductUserId <LocalUserId_DEPRECATED>k__BackingField; // 0x8

	// Properties
	internal Utf8String LobbyId_DEPRECATED { get; set; }
	internal ProductUserId LocalUserId_DEPRECATED { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	internal Utf8String get_LobbyId_DEPRECATED() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	internal void set_LobbyId_DEPRECATED(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	internal ProductUserId get_LocalUserId_DEPRECATED() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	internal void set_LocalUserId_DEPRECATED(ProductUserId value) { }
}

// Namespace: Epic.OnlineServices.Lobby
internal struct AddNotifyRTCRoomConnectionChangedOptionsInternal : ISettable<AddNotifyRTCRoomConnectionChangedOptions>, IDisposable // TypeDefIndex: 9150
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LobbyId_DEPRECATED; // 0x8
	private IntPtr m_LocalUserId_DEPRECATED; // 0x10

	// Properties
	public Utf8String LobbyId_DEPRECATED { set; }
	public ProductUserId LocalUserId_DEPRECATED { set; }

	// Methods

	// RVA: 0x4B9040 Offset: 0x4B8240 VA: 0x1804B9040
	public void set_LobbyId_DEPRECATED(Utf8String value) { }

	// RVA: 0x4B90A0 Offset: 0x4B82A0 VA: 0x1804B90A0
	public void set_LocalUserId_DEPRECATED(ProductUserId value) { }

	// RVA: 0x4B8F80 Offset: 0x4B8180 VA: 0x1804B8F80 Slot: 4
	public void Set(ref AddNotifyRTCRoomConnectionChangedOptions other) { }

	// RVA: 0x4B8E80 Offset: 0x4B8080 VA: 0x1804B8E80 Slot: 5
	public void Set(ref Nullable<AddNotifyRTCRoomConnectionChangedOptions> other) { }

	// RVA: 0x4B8E20 Offset: 0x4B8020 VA: 0x1804B8E20 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Lobby
public struct AddNotifySendLobbyNativeInviteRequestedOptions // TypeDefIndex: 9151
{}

// Namespace: Epic.OnlineServices.Lobby
internal struct AddNotifySendLobbyNativeInviteRequestedOptionsInternal : ISettable<AddNotifySendLobbyNativeInviteRequestedOptions>, IDisposable // TypeDefIndex: 9152
{
	// Fields
	private int m_ApiVersion; // 0x0

	// Methods

	// RVA: 0x3F98A0 Offset: 0x3F8AA0 VA: 0x1803F98A0 Slot: 4
	public void Set(ref AddNotifySendLobbyNativeInviteRequestedOptions other) { }

	// RVA: 0x4B9100 Offset: 0x4B8300 VA: 0x1804B9100 Slot: 5
	public void Set(ref Nullable<AddNotifySendLobbyNativeInviteRequestedOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Lobby
public struct Attribute // TypeDefIndex: 9153
{
	// Fields
	[CompilerGenerated]
	private Nullable<AttributeData> <Data>k__BackingField; // 0x0
	[CompilerGenerated]
	private LobbyAttributeVisibility <Visibility>k__BackingField; // 0x48

	// Properties
	public Nullable<AttributeData> Data { get; set; }
	public LobbyAttributeVisibility Visibility { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x4193E0 Offset: 0x4185E0 VA: 0x1804193E0
	public Nullable<AttributeData> get_Data() { }

	[CompilerGenerated]
	// RVA: 0x419420 Offset: 0x418620 VA: 0x180419420
	public void set_Data(Nullable<AttributeData> value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x4193D0 Offset: 0x4185D0 VA: 0x1804193D0
	public LobbyAttributeVisibility get_Visibility() { }

	[CompilerGenerated]
	// RVA: 0x419410 Offset: 0x418610 VA: 0x180419410
	public void set_Visibility(LobbyAttributeVisibility value) { }

	// RVA: 0x4BAE50 Offset: 0x4BA050 VA: 0x1804BAE50
	internal void Set(ref AttributeInternal other) { }
}

// Namespace: Epic.OnlineServices.Lobby
internal struct AttributeInternal : IGettable<Attribute>, ISettable<Attribute>, IDisposable // TypeDefIndex: 9154
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_Data; // 0x8
	private LobbyAttributeVisibility m_Visibility; // 0x10

	// Properties
	public Nullable<AttributeData> Data { get; set; }
	public LobbyAttributeVisibility Visibility { get; set; }

	// Methods

	// RVA: 0x4BAD50 Offset: 0x4B9F50 VA: 0x1804BAD50
	public Nullable<AttributeData> get_Data() { }

	// RVA: 0x4BADE0 Offset: 0x4B9FE0 VA: 0x1804BADE0
	public void set_Data(Nullable<AttributeData> value) { }

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public LobbyAttributeVisibility get_Visibility() { }

	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_Visibility(LobbyAttributeVisibility value) { }

	// RVA: 0x4BACA0 Offset: 0x4B9EA0 VA: 0x1804BACA0 Slot: 5
	public void Set(ref Attribute other) { }

	// RVA: 0x4BAB80 Offset: 0x4B9D80 VA: 0x1804BAB80 Slot: 6
	public void Set(ref Nullable<Attribute> other) { }

	// RVA: 0x4BAB00 Offset: 0x4B9D00 VA: 0x1804BAB00 Slot: 7
	public void Dispose() { }

	// RVA: 0x4BAB50 Offset: 0x4B9D50 VA: 0x1804BAB50 Slot: 4
	public void Get(out Attribute output) { }
}

// Namespace: Epic.OnlineServices.Lobby
public struct AttributeData // TypeDefIndex: 9155
{
	// Fields
	[CompilerGenerated]
	private Utf8String <Key>k__BackingField; // 0x0
	[CompilerGenerated]
	private AttributeDataValue <Value>k__BackingField; // 0x8

	// Properties
	public Utf8String Key { get; set; }
	public AttributeDataValue Value { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Utf8String get_Key() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_Key(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x40D970 Offset: 0x40CB70 VA: 0x18040D970
	public AttributeDataValue get_Value() { }

	[CompilerGenerated]
	// RVA: 0x40D9A0 Offset: 0x40CBA0 VA: 0x18040D9A0
	public void set_Value(AttributeDataValue value) { }

	// RVA: 0x4BA9F0 Offset: 0x4B9BF0 VA: 0x1804BA9F0
	internal void Set(ref AttributeDataInternal other) { }
}

// Namespace: Epic.OnlineServices.Lobby
internal struct AttributeDataInternal : IGettable<AttributeData>, ISettable<AttributeData>, IDisposable // TypeDefIndex: 9156
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_Key; // 0x8
	private AttributeDataValueInternal m_Value; // 0x10

	// Properties
	public Utf8String Key { get; set; }
	public AttributeDataValue Value { get; set; }

	// Methods

	// RVA: 0x4B9430 Offset: 0x4B8630 VA: 0x1804B9430
	public Utf8String get_Key() { }

	// RVA: 0x4B9530 Offset: 0x4B8730 VA: 0x1804B9530
	public void set_Key(Utf8String value) { }

	// RVA: 0x4B94A0 Offset: 0x4B86A0 VA: 0x1804B94A0
	public AttributeDataValue get_Value() { }

	// RVA: 0x4B9590 Offset: 0x4B8790 VA: 0x1804B9590
	public void set_Value(AttributeDataValue value) { }

	// RVA: 0x4B9340 Offset: 0x4B8540 VA: 0x1804B9340 Slot: 5
	public void Set(ref AttributeData other) { }

	// RVA: 0x4B91F0 Offset: 0x4B83F0 VA: 0x1804B91F0 Slot: 6
	public void Set(ref Nullable<AttributeData> other) { }

	// RVA: 0x4B9150 Offset: 0x4B8350 VA: 0x1804B9150 Slot: 7
	public void Dispose() { }

	// RVA: 0x4B91C0 Offset: 0x4B83C0 VA: 0x1804B91C0 Slot: 4
	public void Get(out AttributeData output) { }
}

// Namespace: Epic.OnlineServices.Lobby
public struct AttributeDataValue // TypeDefIndex: 9157
{
	// Fields
	private Nullable<long> m_AsInt64; // 0x0
	private Nullable<double> m_AsDouble; // 0x10
	private Nullable<bool> m_AsBool; // 0x20
	private Utf8String m_AsUtf8; // 0x28
	private AttributeType m_ValueType; // 0x30

	// Properties
	public Nullable<long> AsInt64 { get; set; }
	public Nullable<double> AsDouble { get; set; }
	public Nullable<bool> AsBool { get; set; }
	public Utf8String AsUtf8 { get; set; }
	public AttributeType ValueType { get; set; }

	// Methods

	// RVA: 0x4BA380 Offset: 0x4B9580 VA: 0x1804BA380
	public Nullable<long> get_AsInt64() { }

	// RVA: 0x4BA8D0 Offset: 0x4B9AD0 VA: 0x1804BA8D0
	public void set_AsInt64(Nullable<long> value) { }

	// RVA: 0x4BA2E0 Offset: 0x4B94E0 VA: 0x1804BA2E0
	public Nullable<double> get_AsDouble() { }

	// RVA: 0x4BA840 Offset: 0x4B9A40 VA: 0x1804BA840
	public void set_AsDouble(Nullable<double> value) { }

	// RVA: 0x4BA250 Offset: 0x4B9450 VA: 0x1804BA250
	public Nullable<bool> get_AsBool() { }

	// RVA: 0x4BA7C0 Offset: 0x4B99C0 VA: 0x1804BA7C0
	public void set_AsBool(Nullable<bool> value) { }

	// RVA: 0x4BA420 Offset: 0x4B9620 VA: 0x1804BA420
	public Utf8String get_AsUtf8() { }

	// RVA: 0x4BA960 Offset: 0x4B9B60 VA: 0x1804BA960
	public void set_AsUtf8(Utf8String value) { }

	// RVA: 0x40D300 Offset: 0x40C500 VA: 0x18040D300
	public AttributeType get_ValueType() { }

	// RVA: 0x40D850 Offset: 0x40CA50 VA: 0x18040D850
	private void set_ValueType(AttributeType value) { }

	// RVA: 0x4BA6D0 Offset: 0x4B98D0 VA: 0x1804BA6D0
	public static AttributeDataValue op_Implicit(long value) { }

	// RVA: 0x4BA4B0 Offset: 0x4B96B0 VA: 0x1804BA4B0
	public static AttributeDataValue op_Implicit(double value) { }

	// RVA: 0x4BA5D0 Offset: 0x4B97D0 VA: 0x1804BA5D0
	public static AttributeDataValue op_Implicit(bool value) { }

	// RVA: 0x4BA5A0 Offset: 0x4B97A0 VA: 0x1804BA5A0
	public static AttributeDataValue op_Implicit(Utf8String value) { }

	// RVA: 0x4BA650 Offset: 0x4B9850 VA: 0x1804BA650
	public static AttributeDataValue op_Implicit(string value) { }

	// RVA: 0x4BA020 Offset: 0x4B9220 VA: 0x1804BA020
	internal void Set(ref AttributeDataValueInternal other) { }
}

// Namespace: Epic.OnlineServices.Lobby
internal struct AttributeDataValueInternal : IGettable<AttributeDataValue>, ISettable<AttributeDataValue>, IDisposable // TypeDefIndex: 9158
{
	// Fields
	private long m_AsInt64; // 0x0
	private double m_AsDouble; // 0x0
	private int m_AsBool; // 0x0
	private IntPtr m_AsUtf8; // 0x0
	private AttributeType m_ValueType; // 0x8

	// Properties
	public Nullable<long> AsInt64 { get; set; }
	public Nullable<double> AsDouble { get; set; }
	public Nullable<bool> AsBool { get; set; }
	public Utf8String AsUtf8 { get; set; }

	// Methods

	// RVA: 0x4B9C10 Offset: 0x4B8E10 VA: 0x1804B9C10
	public Nullable<long> get_AsInt64() { }

	// RVA: 0x4B9EB0 Offset: 0x4B90B0 VA: 0x1804B9EB0
	public void set_AsInt64(Nullable<long> value) { }

	// RVA: 0x4B9B70 Offset: 0x4B8D70 VA: 0x1804B9B70
	public Nullable<double> get_AsDouble() { }

	// RVA: 0x4B9DF0 Offset: 0x4B8FF0 VA: 0x1804B9DF0
	public void set_AsDouble(Nullable<double> value) { }

	// RVA: 0x4B9AE0 Offset: 0x4B8CE0 VA: 0x1804B9AE0
	public Nullable<bool> get_AsBool() { }

	// RVA: 0x4B9D40 Offset: 0x4B8F40 VA: 0x1804B9D40
	public void set_AsBool(Nullable<bool> value) { }

	// RVA: 0x4B9CB0 Offset: 0x4B8EB0 VA: 0x1804B9CB0
	public Utf8String get_AsUtf8() { }

	// RVA: 0x4B9F70 Offset: 0x4B9170 VA: 0x1804B9F70
	public void set_AsUtf8(Utf8String value) { }

	// RVA: 0x4B96A0 Offset: 0x4B88A0 VA: 0x1804B96A0 Slot: 5
	public void Set(ref AttributeDataValue other) { }

	// RVA: 0x4B9820 Offset: 0x4B8A20 VA: 0x1804B9820 Slot: 6
	public void Set(ref Nullable<AttributeDataValue> other) { }

	// RVA: 0x4B9600 Offset: 0x4B8800 VA: 0x1804B9600 Slot: 7
	public void Dispose() { }

	// RVA: 0x4B9670 Offset: 0x4B8870 VA: 0x1804B9670 Slot: 4
	public void Get(out AttributeDataValue output) { }
}

// Namespace: Epic.OnlineServices.Lobby
public struct CopyLobbyDetailsHandleByInviteIdOptions // TypeDefIndex: 9159
{
	// Fields
	[CompilerGenerated]
	private Utf8String <InviteId>k__BackingField; // 0x0

	// Properties
	public Utf8String InviteId { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Utf8String get_InviteId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_InviteId(Utf8String value) { }
}

// Namespace: Epic.OnlineServices.Lobby
internal struct CopyLobbyDetailsHandleByInviteIdOptionsInternal : ISettable<CopyLobbyDetailsHandleByInviteIdOptions>, IDisposable // TypeDefIndex: 9160
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_InviteId; // 0x8

	// Properties
	public Utf8String InviteId { set; }

	// Methods

	// RVA: 0x4BBEC0 Offset: 0x4BB0C0 VA: 0x1804BBEC0
	public void set_InviteId(Utf8String value) { }

	// RVA: 0x4BBE60 Offset: 0x4BB060 VA: 0x1804BBE60 Slot: 4
	public void Set(ref CopyLobbyDetailsHandleByInviteIdOptions other) { }

	// RVA: 0x4BBDC0 Offset: 0x4BAFC0 VA: 0x1804BBDC0 Slot: 5
	public void Set(ref Nullable<CopyLobbyDetailsHandleByInviteIdOptions> other) { }

	// RVA: 0x4BBD70 Offset: 0x4BAF70 VA: 0x1804BBD70 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Lobby
public struct CopyLobbyDetailsHandleByUiEventIdOptions // TypeDefIndex: 9161
{
	// Fields
	[CompilerGenerated]
	private ulong <UiEventId>k__BackingField; // 0x0

	// Properties
	public ulong UiEventId { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public ulong get_UiEventId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_UiEventId(ulong value) { }
}

// Namespace: Epic.OnlineServices.Lobby
internal struct CopyLobbyDetailsHandleByUiEventIdOptionsInternal : ISettable<CopyLobbyDetailsHandleByUiEventIdOptions>, IDisposable // TypeDefIndex: 9162
{
	// Fields
	private int m_ApiVersion; // 0x0
	private ulong m_UiEventId; // 0x8

	// Properties
	public ulong UiEventId { set; }

	// Methods

	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_UiEventId(ulong value) { }

	// RVA: 0x40DD30 Offset: 0x40CF30 VA: 0x18040DD30 Slot: 4
	public void Set(ref CopyLobbyDetailsHandleByUiEventIdOptions other) { }

	// RVA: 0x4BBF20 Offset: 0x4BB120 VA: 0x1804BBF20 Slot: 5
	public void Set(ref Nullable<CopyLobbyDetailsHandleByUiEventIdOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Lobby
public struct CopyLobbyDetailsHandleOptions // TypeDefIndex: 9163
{
	// Fields
	[CompilerGenerated]
	private Utf8String <LobbyId>k__BackingField; // 0x0
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x8

	// Properties
	public Utf8String LobbyId { get; set; }
