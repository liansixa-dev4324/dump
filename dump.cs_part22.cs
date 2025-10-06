	public ProductUserId LocalUserId { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Utf8String get_LobbyId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_LobbyId(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_LocalUserId(ProductUserId value) { }
}

// Namespace: Epic.OnlineServices.Lobby
internal struct CopyLobbyDetailsHandleOptionsInternal : ISettable<CopyLobbyDetailsHandleOptions>, IDisposable // TypeDefIndex: 9164
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LobbyId; // 0x8
	private IntPtr m_LocalUserId; // 0x10

	// Properties
	public Utf8String LobbyId { set; }
	public ProductUserId LocalUserId { set; }

	// Methods

	// RVA: 0x4BC1B0 Offset: 0x4BB3B0 VA: 0x1804BC1B0
	public void set_LobbyId(Utf8String value) { }

	// RVA: 0x4BC210 Offset: 0x4BB410 VA: 0x1804BC210
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x4BBFF0 Offset: 0x4BB1F0 VA: 0x1804BBFF0 Slot: 4
	public void Set(ref CopyLobbyDetailsHandleOptions other) { }

	// RVA: 0x4BC0B0 Offset: 0x4BB2B0 VA: 0x1804BC0B0 Slot: 5
	public void Set(ref Nullable<CopyLobbyDetailsHandleOptions> other) { }

	// RVA: 0x4BBF90 Offset: 0x4BB190 VA: 0x1804BBF90 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Lobby
public struct CreateLobbyCallbackInfo : ICallbackInfo // TypeDefIndex: 9165
{
	// Fields
	[CompilerGenerated]
	private Result <ResultCode>k__BackingField; // 0x0
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x8
	[CompilerGenerated]
	private Utf8String <LobbyId>k__BackingField; // 0x10

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public Utf8String LobbyId { get; set; }

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
	public Utf8String get_LobbyId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_LobbyId(Utf8String value) { }

	// RVA: 0x4BC850 Offset: 0x4BBA50 VA: 0x1804BC850 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x4BC8A0 Offset: 0x4BBAA0 VA: 0x1804BC8A0
	internal void Set(ref CreateLobbyCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.Lobby
internal struct CreateLobbyCallbackInfoInternal : ICallbackInfoInternal, IGettable<CreateLobbyCallbackInfo>, ISettable<CreateLobbyCallbackInfo>, IDisposable // TypeDefIndex: 9166
{
	// Fields
	private Result m_ResultCode; // 0x0
	private IntPtr m_ClientData; // 0x8
	private IntPtr m_LobbyId; // 0x10

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public Utf8String LobbyId { get; set; }

	// Methods

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	// RVA: 0x4BC6B0 Offset: 0x4BB8B0 VA: 0x1804BC6B0
	public object get_ClientData() { }

	// RVA: 0x4BC790 Offset: 0x4BB990 VA: 0x1804BC790
	public void set_ClientData(object value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x4BC720 Offset: 0x4BB920 VA: 0x1804BC720
	public Utf8String get_LobbyId() { }

	// RVA: 0x4BC7F0 Offset: 0x4BB9F0 VA: 0x1804BC7F0
	public void set_LobbyId(Utf8String value) { }

	// RVA: 0x4BC4E0 Offset: 0x4BB6E0 VA: 0x1804BC4E0 Slot: 6
	public void Set(ref CreateLobbyCallbackInfo other) { }

	// RVA: 0x4BC590 Offset: 0x4BB790 VA: 0x1804BC590 Slot: 7
	public void Set(ref Nullable<CreateLobbyCallbackInfo> other) { }

	// RVA: 0x4BC460 Offset: 0x4BB660 VA: 0x1804BC460 Slot: 8
	public void Dispose() { }

	// RVA: 0x4BC4C0 Offset: 0x4BB6C0 VA: 0x1804BC4C0 Slot: 5
	public void Get(out CreateLobbyCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.Lobby
public struct CreateLobbyOptions // TypeDefIndex: 9167
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private uint <MaxLobbyMembers>k__BackingField; // 0x8
	[CompilerGenerated]
	private LobbyPermissionLevel <PermissionLevel>k__BackingField; // 0xC
	[CompilerGenerated]
	private bool <PresenceEnabled>k__BackingField; // 0x10
	[CompilerGenerated]
	private bool <AllowInvites>k__BackingField; // 0x11
	[CompilerGenerated]
	private Utf8String <BucketId>k__BackingField; // 0x18
	[CompilerGenerated]
	private bool <DisableHostMigration>k__BackingField; // 0x20
	[CompilerGenerated]
	private bool <EnableRTCRoom>k__BackingField; // 0x21
	[CompilerGenerated]
	private Nullable<LocalRTCOptions> <LocalRTCOptions>k__BackingField; // 0x24
	[CompilerGenerated]
	private Utf8String <LobbyId>k__BackingField; // 0x30
	[CompilerGenerated]
	private bool <EnableJoinById>k__BackingField; // 0x38
	[CompilerGenerated]
	private bool <RejoinAfterKickRequiresInvite>k__BackingField; // 0x39
	[CompilerGenerated]
	private uint[] <AllowedPlatformIds>k__BackingField; // 0x40
	[CompilerGenerated]
	private bool <CrossplayOptOut>k__BackingField; // 0x48

	// Properties
	public ProductUserId LocalUserId { get; set; }
	public uint MaxLobbyMembers { get; set; }
	public LobbyPermissionLevel PermissionLevel { get; set; }
	public bool PresenceEnabled { get; set; }
	public bool AllowInvites { get; set; }
	public Utf8String BucketId { get; set; }
	public bool DisableHostMigration { get; set; }
	public bool EnableRTCRoom { get; set; }
	public Nullable<LocalRTCOptions> LocalRTCOptions { get; set; }
	public Utf8String LobbyId { get; set; }
	public bool EnableJoinById { get; set; }
	public bool RejoinAfterKickRequiresInvite { get; set; }
	public uint[] AllowedPlatformIds { get; set; }
	public bool CrossplayOptOut { get; set; }

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
	// RVA: 0x3F5510 Offset: 0x3F4710 VA: 0x1803F5510
	public uint get_MaxLobbyMembers() { }

	[CompilerGenerated]
	// RVA: 0x3F5520 Offset: 0x3F4720 VA: 0x1803F5520
	public void set_MaxLobbyMembers(uint value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x438080 Offset: 0x437280 VA: 0x180438080
	public LobbyPermissionLevel get_PermissionLevel() { }

	[CompilerGenerated]
	// RVA: 0x438090 Offset: 0x437290 VA: 0x180438090
	public void set_PermissionLevel(LobbyPermissionLevel value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	public bool get_PresenceEnabled() { }

	[CompilerGenerated]
	// RVA: 0x3D6DB0 Offset: 0x3D5FB0 VA: 0x1803D6DB0
	public void set_PresenceEnabled(bool value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x4BD6F0 Offset: 0x4BC8F0 VA: 0x1804BD6F0
	public bool get_AllowInvites() { }

	[CompilerGenerated]
	// RVA: 0x4BD750 Offset: 0x4BC950 VA: 0x1804BD750
	public void set_AllowInvites(bool value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public Utf8String get_BucketId() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_BucketId(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x4009D0 Offset: 0x3FFBD0 VA: 0x1804009D0
	public bool get_DisableHostMigration() { }

	[CompilerGenerated]
	// RVA: 0x4009E0 Offset: 0x3FFBE0 VA: 0x1804009E0
	public void set_DisableHostMigration(bool value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x4BD710 Offset: 0x4BC910 VA: 0x1804BD710
	public bool get_EnableRTCRoom() { }

	[CompilerGenerated]
	// RVA: 0x4BD770 Offset: 0x4BC970 VA: 0x1804BD770
	public void set_EnableRTCRoom(bool value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x4BD720 Offset: 0x4BC920 VA: 0x1804BD720
	public Nullable<LocalRTCOptions> get_LocalRTCOptions() { }

	[CompilerGenerated]
	// RVA: 0x4BD780 Offset: 0x4BC980 VA: 0x1804BD780
	public void set_LocalRTCOptions(Nullable<LocalRTCOptions> value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public Utf8String get_LobbyId() { }

	[CompilerGenerated]
	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	public void set_LobbyId(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x4BD700 Offset: 0x4BC900 VA: 0x1804BD700
	public bool get_EnableJoinById() { }

	[CompilerGenerated]
	// RVA: 0x4BD760 Offset: 0x4BC960 VA: 0x1804BD760
	public void set_EnableJoinById(bool value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x4BD740 Offset: 0x4BC940 VA: 0x1804BD740
	public bool get_RejoinAfterKickRequiresInvite() { }

	[CompilerGenerated]
	// RVA: 0x4BD790 Offset: 0x4BC990 VA: 0x1804BD790
	public void set_RejoinAfterKickRequiresInvite(bool value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	public uint[] get_AllowedPlatformIds() { }

	[CompilerGenerated]
	// RVA: 0x415820 Offset: 0x414A20 VA: 0x180415820
	public void set_AllowedPlatformIds(uint[] value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x445A70 Offset: 0x444C70 VA: 0x180445A70
	public bool get_CrossplayOptOut() { }

	[CompilerGenerated]
	// RVA: 0x445A80 Offset: 0x444C80 VA: 0x180445A80
	public void set_CrossplayOptOut(bool value) { }
}

// Namespace: Epic.OnlineServices.Lobby
internal struct CreateLobbyOptionsInternal : ISettable<CreateLobbyOptions>, IDisposable // TypeDefIndex: 9168
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private uint m_MaxLobbyMembers; // 0x10
	private LobbyPermissionLevel m_PermissionLevel; // 0x14
	private int m_PresenceEnabled; // 0x18
	private int m_AllowInvites; // 0x1C
	private IntPtr m_BucketId; // 0x20
	private int m_DisableHostMigration; // 0x28
	private int m_EnableRTCRoom; // 0x2C
	private IntPtr m_LocalRTCOptions; // 0x30
	private IntPtr m_LobbyId; // 0x38
	private int m_EnableJoinById; // 0x40
	private int m_RejoinAfterKickRequiresInvite; // 0x44
	private IntPtr m_AllowedPlatformIds; // 0x48
	private uint m_AllowedPlatformIdsCount; // 0x50
	private int m_CrossplayOptOut; // 0x54

	// Properties
	public ProductUserId LocalUserId { set; }
	public uint MaxLobbyMembers { set; }
	public LobbyPermissionLevel PermissionLevel { set; }
	public bool PresenceEnabled { set; }
	public bool AllowInvites { set; }
	public Utf8String BucketId { set; }
	public bool DisableHostMigration { set; }
	public bool EnableRTCRoom { set; }
	public Nullable<LocalRTCOptions> LocalRTCOptions { set; }
	public Utf8String LobbyId { set; }
	public bool EnableJoinById { set; }
	public bool RejoinAfterKickRequiresInvite { set; }
	public uint[] AllowedPlatformIds { set; }
	public bool CrossplayOptOut { set; }

	// Methods

	// RVA: 0x4BD5D0 Offset: 0x4BC7D0 VA: 0x1804BD5D0
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_MaxLobbyMembers(uint value) { }

	// RVA: 0x426530 Offset: 0x425730 VA: 0x180426530
	public void set_PermissionLevel(LobbyPermissionLevel value) { }

	// RVA: 0x4BD630 Offset: 0x4BC830 VA: 0x1804BD630
	public void set_PresenceEnabled(bool value) { }

	// RVA: 0x4BD250 Offset: 0x4BC450 VA: 0x1804BD250
	public void set_AllowInvites(bool value) { }

	// RVA: 0x4BD320 Offset: 0x4BC520 VA: 0x1804BD320
	public void set_BucketId(Utf8String value) { }

	// RVA: 0x4BD3E0 Offset: 0x4BC5E0 VA: 0x1804BD3E0
	public void set_DisableHostMigration(bool value) { }

	// RVA: 0x4BD4A0 Offset: 0x4BC6A0 VA: 0x1804BD4A0
	public void set_EnableRTCRoom(bool value) { }

	// RVA: 0x4BD560 Offset: 0x4BC760 VA: 0x1804BD560
	public void set_LocalRTCOptions(Nullable<LocalRTCOptions> value) { }

	// RVA: 0x4BD500 Offset: 0x4BC700 VA: 0x1804BD500
	public void set_LobbyId(Utf8String value) { }

	// RVA: 0x4BD440 Offset: 0x4BC640 VA: 0x1804BD440
	public void set_EnableJoinById(bool value) { }

	// RVA: 0x4BD690 Offset: 0x4BC890 VA: 0x1804BD690
	public void set_RejoinAfterKickRequiresInvite(bool value) { }

	// RVA: 0x4BD2B0 Offset: 0x4BC4B0 VA: 0x1804BD2B0
	public void set_AllowedPlatformIds(uint[] value) { }

	// RVA: 0x4BD380 Offset: 0x4BC580 VA: 0x1804BD380
	public void set_CrossplayOptOut(bool value) { }

	// RVA: 0x4BCA00 Offset: 0x4BBC00 VA: 0x1804BCA00 Slot: 4
	public void Set(ref CreateLobbyOptions other) { }

	// RVA: 0x4BCDB0 Offset: 0x4BBFB0 VA: 0x1804BCDB0 Slot: 5
	public void Set(ref Nullable<CreateLobbyOptions> other) { }

	// RVA: 0x4BC980 Offset: 0x4BBB80 VA: 0x1804BC980 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Lobby
public struct CreateLobbySearchOptions // TypeDefIndex: 9169
{
	// Fields
	[CompilerGenerated]
	private uint <MaxResults>k__BackingField; // 0x0

	// Properties
	public uint MaxResults { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public uint get_MaxResults() { }

	[CompilerGenerated]
	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_MaxResults(uint value) { }
}

// Namespace: Epic.OnlineServices.Lobby
internal struct CreateLobbySearchOptionsInternal : ISettable<CreateLobbySearchOptions>, IDisposable // TypeDefIndex: 9170
{
	// Fields
	private int m_ApiVersion; // 0x0
	private uint m_MaxResults; // 0x4

	// Properties
	public uint MaxResults { set; }

	// Methods

	// RVA: 0x3F84A0 Offset: 0x3F76A0 VA: 0x1803F84A0
	public void set_MaxResults(uint value) { }

	// RVA: 0x40B2E0 Offset: 0x40A4E0 VA: 0x18040B2E0 Slot: 4
	public void Set(ref CreateLobbySearchOptions other) { }

	// RVA: 0x4BD7A0 Offset: 0x4BC9A0 VA: 0x1804BD7A0 Slot: 5
	public void Set(ref Nullable<CreateLobbySearchOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Lobby
public struct DestroyLobbyCallbackInfo : ICallbackInfo // TypeDefIndex: 9171
{
	// Fields
	[CompilerGenerated]
	private Result <ResultCode>k__BackingField; // 0x0
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x8
	[CompilerGenerated]
	private Utf8String <LobbyId>k__BackingField; // 0x10

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public Utf8String LobbyId { get; set; }

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
	public Utf8String get_LobbyId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_LobbyId(Utf8String value) { }

	// RVA: 0x4BDBF0 Offset: 0x4BCDF0 VA: 0x1804BDBF0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x4BDC40 Offset: 0x4BCE40 VA: 0x1804BDC40
	internal void Set(ref DestroyLobbyCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.Lobby
internal struct DestroyLobbyCallbackInfoInternal : ICallbackInfoInternal, IGettable<DestroyLobbyCallbackInfo>, ISettable<DestroyLobbyCallbackInfo>, IDisposable // TypeDefIndex: 9172
{
	// Fields
	private Result m_ResultCode; // 0x0
	private IntPtr m_ClientData; // 0x8
	private IntPtr m_LobbyId; // 0x10

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public Utf8String LobbyId { get; set; }

	// Methods

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	// RVA: 0x4BDA50 Offset: 0x4BCC50 VA: 0x1804BDA50
	public object get_ClientData() { }

	// RVA: 0x4BDB30 Offset: 0x4BCD30 VA: 0x1804BDB30
	public void set_ClientData(object value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x4BDAC0 Offset: 0x4BCCC0 VA: 0x1804BDAC0
	public Utf8String get_LobbyId() { }

	// RVA: 0x4BDB90 Offset: 0x4BCD90 VA: 0x1804BDB90
	public void set_LobbyId(Utf8String value) { }

	// RVA: 0x4BD9A0 Offset: 0x4BCBA0 VA: 0x1804BD9A0 Slot: 6
	public void Set(ref DestroyLobbyCallbackInfo other) { }

	// RVA: 0x4BD880 Offset: 0x4BCA80 VA: 0x1804BD880 Slot: 7
	public void Set(ref Nullable<DestroyLobbyCallbackInfo> other) { }

	// RVA: 0x4BD800 Offset: 0x4BCA00 VA: 0x1804BD800 Slot: 8
	public void Dispose() { }

	// RVA: 0x4BD860 Offset: 0x4BCA60 VA: 0x1804BD860 Slot: 5
	public void Get(out DestroyLobbyCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.Lobby
public struct DestroyLobbyOptions // TypeDefIndex: 9173
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <LobbyId>k__BackingField; // 0x8

	// Properties
	public ProductUserId LocalUserId { get; set; }
	public Utf8String LobbyId { get; set; }

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
	public Utf8String get_LobbyId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_LobbyId(Utf8String value) { }
}

// Namespace: Epic.OnlineServices.Lobby
internal struct DestroyLobbyOptionsInternal : ISettable<DestroyLobbyOptions>, IDisposable // TypeDefIndex: 9174
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_LobbyId; // 0x10

	// Properties
	public ProductUserId LocalUserId { set; }
	public Utf8String LobbyId { set; }

	// Methods

	// RVA: 0x4BDFA0 Offset: 0x4BD1A0 VA: 0x1804BDFA0
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x4BDF40 Offset: 0x4BD140 VA: 0x1804BDF40
	public void set_LobbyId(Utf8String value) { }

	// RVA: 0x4BDE80 Offset: 0x4BD080 VA: 0x1804BDE80 Slot: 4
	public void Set(ref DestroyLobbyOptions other) { }

	// RVA: 0x4BDD80 Offset: 0x4BCF80 VA: 0x1804BDD80 Slot: 5
	public void Set(ref Nullable<DestroyLobbyOptions> other) { }

	// RVA: 0x4BDD20 Offset: 0x4BCF20 VA: 0x1804BDD20 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Lobby
public struct GetConnectStringOptions // TypeDefIndex: 9175
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <LobbyId>k__BackingField; // 0x8

	// Properties
	public ProductUserId LocalUserId { get; set; }
	public Utf8String LobbyId { get; set; }

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
	public Utf8String get_LobbyId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_LobbyId(Utf8String value) { }
}

// Namespace: Epic.OnlineServices.Lobby
internal struct GetConnectStringOptionsInternal : ISettable<GetConnectStringOptions>, IDisposable // TypeDefIndex: 9176
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_LobbyId; // 0x10

	// Properties
	public ProductUserId LocalUserId { set; }
	public Utf8String LobbyId { set; }

	// Methods

	// RVA: 0x4BF430 Offset: 0x4BE630 VA: 0x1804BF430
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x4BF3D0 Offset: 0x4BE5D0 VA: 0x1804BF3D0
	public void set_LobbyId(Utf8String value) { }

	// RVA: 0x4BF210 Offset: 0x4BE410 VA: 0x1804BF210 Slot: 4
	public void Set(ref GetConnectStringOptions other) { }

	// RVA: 0x4BF2D0 Offset: 0x4BE4D0 VA: 0x1804BF2D0 Slot: 5
	public void Set(ref Nullable<GetConnectStringOptions> other) { }

	// RVA: 0x4BF1B0 Offset: 0x4BE3B0 VA: 0x1804BF1B0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Lobby
public struct GetInviteCountOptions // TypeDefIndex: 9177
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

// Namespace: Epic.OnlineServices.Lobby
internal struct GetInviteCountOptionsInternal : ISettable<GetInviteCountOptions>, IDisposable // TypeDefIndex: 9178
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8

	// Properties
	public ProductUserId LocalUserId { set; }

	// Methods

	// RVA: 0x4BF5E0 Offset: 0x4BE7E0 VA: 0x1804BF5E0
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x4BF580 Offset: 0x4BE780 VA: 0x1804BF580 Slot: 4
	public void Set(ref GetInviteCountOptions other) { }

	// RVA: 0x4BF4E0 Offset: 0x4BE6E0 VA: 0x1804BF4E0 Slot: 5
	public void Set(ref Nullable<GetInviteCountOptions> other) { }

	// RVA: 0x4BF490 Offset: 0x4BE690 VA: 0x1804BF490 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Lobby
public struct GetInviteIdByIndexOptions // TypeDefIndex: 9179
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

// Namespace: Epic.OnlineServices.Lobby
internal struct GetInviteIdByIndexOptionsInternal : ISettable<GetInviteIdByIndexOptions>, IDisposable // TypeDefIndex: 9180
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private uint m_Index; // 0x10

	// Properties
	public ProductUserId LocalUserId { set; }
	public uint Index { set; }

	// Methods

	// RVA: 0x4BF7D0 Offset: 0x4BE9D0 VA: 0x1804BF7D0
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_Index(uint value) { }

	// RVA: 0x4BF690 Offset: 0x4BE890 VA: 0x1804BF690 Slot: 4
	public void Set(ref GetInviteIdByIndexOptions other) { }

	// RVA: 0x4BF710 Offset: 0x4BE910 VA: 0x1804BF710 Slot: 5
	public void Set(ref Nullable<GetInviteIdByIndexOptions> other) { }

	// RVA: 0x4BF640 Offset: 0x4BE840 VA: 0x1804BF640 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Lobby
public struct GetRTCRoomNameOptions // TypeDefIndex: 9181
{
	// Fields
	[CompilerGenerated]
	private Utf8String <LobbyId>k__BackingField; // 0x0
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x8

	// Properties
	public Utf8String LobbyId { get; set; }
	public ProductUserId LocalUserId { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Utf8String get_LobbyId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_LobbyId(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_LocalUserId(ProductUserId value) { }
}

// Namespace: Epic.OnlineServices.Lobby
internal struct GetRTCRoomNameOptionsInternal : ISettable<GetRTCRoomNameOptions>, IDisposable // TypeDefIndex: 9182
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LobbyId; // 0x8
	private IntPtr m_LocalUserId; // 0x10

	// Properties
	public Utf8String LobbyId { set; }
	public ProductUserId LocalUserId { set; }

	// Methods

	// RVA: 0x4BFEB0 Offset: 0x4BF0B0 VA: 0x1804BFEB0
	public void set_LobbyId(Utf8String value) { }

	// RVA: 0x4BFF10 Offset: 0x4BF110 VA: 0x1804BFF10
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x4BFCF0 Offset: 0x4BEEF0 VA: 0x1804BFCF0 Slot: 4
	public void Set(ref GetRTCRoomNameOptions other) { }

	// RVA: 0x4BFDB0 Offset: 0x4BEFB0 VA: 0x1804BFDB0 Slot: 5
	public void Set(ref Nullable<GetRTCRoomNameOptions> other) { }

	// RVA: 0x4BFC90 Offset: 0x4BEE90 VA: 0x1804BFC90 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Lobby
public struct HardMuteMemberCallbackInfo : ICallbackInfo // TypeDefIndex: 9183
{
	// Fields
	[CompilerGenerated]
	private Result <ResultCode>k__BackingField; // 0x0
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x8
	[CompilerGenerated]
	private Utf8String <LobbyId>k__BackingField; // 0x10
	[CompilerGenerated]
	private ProductUserId <TargetUserId>k__BackingField; // 0x18

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public Utf8String LobbyId { get; set; }
	public ProductUserId TargetUserId { get; set; }

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
	public Utf8String get_LobbyId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_LobbyId(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public ProductUserId get_TargetUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_TargetUserId(ProductUserId value) { }

	// RVA: 0x4C04E0 Offset: 0x4BF6E0 VA: 0x1804C04E0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x4C0530 Offset: 0x4BF730 VA: 0x1804C0530
	internal void Set(ref HardMuteMemberCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.Lobby
internal struct HardMuteMemberCallbackInfoInternal : ICallbackInfoInternal, IGettable<HardMuteMemberCallbackInfo>, ISettable<HardMuteMemberCallbackInfo>, IDisposable // TypeDefIndex: 9184
{
	// Fields
	private Result m_ResultCode; // 0x0
	private IntPtr m_ClientData; // 0x8
	private IntPtr m_LobbyId; // 0x10
	private IntPtr m_TargetUserId; // 0x18

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public Utf8String LobbyId { get; set; }
	public ProductUserId TargetUserId { get; set; }

	// Methods

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	// RVA: 0x4C0260 Offset: 0x4BF460 VA: 0x1804C0260
	public object get_ClientData() { }

	// RVA: 0x4C03C0 Offset: 0x4BF5C0 VA: 0x1804C03C0
	public void set_ClientData(object value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x4C02D0 Offset: 0x4BF4D0 VA: 0x1804C02D0
	public Utf8String get_LobbyId() { }

	// RVA: 0x4C0420 Offset: 0x4BF620 VA: 0x1804C0420
	public void set_LobbyId(Utf8String value) { }

	// RVA: 0x4C0340 Offset: 0x4BF540 VA: 0x1804C0340
	public ProductUserId get_TargetUserId() { }

	// RVA: 0x4C0480 Offset: 0x4BF680 VA: 0x1804C0480
	public void set_TargetUserId(ProductUserId value) { }

	// RVA: 0x4C0160 Offset: 0x4BF360 VA: 0x1804C0160 Slot: 6
	public void Set(ref HardMuteMemberCallbackInfo other) { }

	// RVA: 0x4BFFF0 Offset: 0x4BF1F0 VA: 0x1804BFFF0 Slot: 7
	public void Set(ref Nullable<HardMuteMemberCallbackInfo> other) { }

	// RVA: 0x4BFF70 Offset: 0x4BF170 VA: 0x1804BFF70 Slot: 8
	public void Dispose() { }

	// RVA: 0x4BFFD0 Offset: 0x4BF1D0 VA: 0x1804BFFD0 Slot: 5
	public void Get(out HardMuteMemberCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.Lobby
public struct HardMuteMemberOptions // TypeDefIndex: 9185
{
	// Fields
	[CompilerGenerated]
	private Utf8String <LobbyId>k__BackingField; // 0x0
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x8
	[CompilerGenerated]
	private ProductUserId <TargetUserId>k__BackingField; // 0x10
	[CompilerGenerated]
	private bool <HardMute>k__BackingField; // 0x18

	// Properties
	public Utf8String LobbyId { get; set; }
	public ProductUserId LocalUserId { get; set; }
	public ProductUserId TargetUserId { get; set; }
	public bool HardMute { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Utf8String get_LobbyId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_LobbyId(Utf8String value) { }

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
	public ProductUserId get_TargetUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_TargetUserId(ProductUserId value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x411B20 Offset: 0x410D20 VA: 0x180411B20
	public bool get_HardMute() { }

	[CompilerGenerated]
	// RVA: 0x411B30 Offset: 0x410D30 VA: 0x180411B30
	public void set_HardMute(bool value) { }
}

// Namespace: Epic.OnlineServices.Lobby
internal struct HardMuteMemberOptionsInternal : ISettable<HardMuteMemberOptions>, IDisposable // TypeDefIndex: 9186
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LobbyId; // 0x8
	private IntPtr m_LocalUserId; // 0x10
	private IntPtr m_TargetUserId; // 0x18
	private int m_HardMute; // 0x20

	// Properties
	public Utf8String LobbyId { set; }
	public ProductUserId LocalUserId { set; }
	public ProductUserId TargetUserId { set; }
	public bool HardMute { set; }

	// Methods

	// RVA: 0x4C09D0 Offset: 0x4BFBD0 VA: 0x1804C09D0
	public void set_LobbyId(Utf8String value) { }

	// RVA: 0x4C0A30 Offset: 0x4BFC30 VA: 0x1804C0A30
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x4C0A90 Offset: 0x4BFC90 VA: 0x1804C0A90
	public void set_TargetUserId(ProductUserId value) { }

	// RVA: 0x4C0970 Offset: 0x4BFB70 VA: 0x1804C0970
	public void set_HardMute(bool value) { }

	// RVA: 0x4C0680 Offset: 0x4BF880 VA: 0x1804C0680 Slot: 4
	public void Set(ref HardMuteMemberOptions other) { }

	// RVA: 0x4C07C0 Offset: 0x4BF9C0 VA: 0x1804C07C0 Slot: 5
	public void Set(ref Nullable<HardMuteMemberOptions> other) { }

	// RVA: 0x4C0620 Offset: 0x4BF820 VA: 0x1804C0620 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Lobby
public struct IsRTCRoomConnectedOptions // TypeDefIndex: 9187
{
	// Fields
	[CompilerGenerated]
	private Utf8String <LobbyId>k__BackingField; // 0x0
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x8

	// Properties
	public Utf8String LobbyId { get; set; }
	public ProductUserId LocalUserId { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Utf8String get_LobbyId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_LobbyId(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_LocalUserId(ProductUserId value) { }
}

// Namespace: Epic.OnlineServices.Lobby
internal struct IsRTCRoomConnectedOptionsInternal : ISettable<IsRTCRoomConnectedOptions>, IDisposable // TypeDefIndex: 9188
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LobbyId; // 0x8
	private IntPtr m_LocalUserId; // 0x10

	// Properties
	public Utf8String LobbyId { set; }
	public ProductUserId LocalUserId { set; }

	// Methods

	// RVA: 0x4C1930 Offset: 0x4C0B30 VA: 0x1804C1930
	public void set_LobbyId(Utf8String value) { }

	// RVA: 0x4C1990 Offset: 0x4C0B90 VA: 0x1804C1990
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x4C1770 Offset: 0x4C0970 VA: 0x1804C1770 Slot: 4
	public void Set(ref IsRTCRoomConnectedOptions other) { }

	// RVA: 0x4C1830 Offset: 0x4C0A30 VA: 0x1804C1830 Slot: 5
	public void Set(ref Nullable<IsRTCRoomConnectedOptions> other) { }

	// RVA: 0x4C1710 Offset: 0x4C0910 VA: 0x1804C1710 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Lobby
public struct JoinLobbyAcceptedCallbackInfo : ICallbackInfo // TypeDefIndex: 9189
{
	// Fields
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x0
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x8
	[CompilerGenerated]
	private ulong <UiEventId>k__BackingField; // 0x10

	// Properties
	public object ClientData { get; set; }
	public ProductUserId LocalUserId { get; set; }
	public ulong UiEventId { get; set; }

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
	public ulong get_UiEventId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_UiEventId(ulong value) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x4C1E00 Offset: 0x4C1000 VA: 0x1804C1E00
	internal void Set(ref JoinLobbyAcceptedCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.Lobby
internal struct JoinLobbyAcceptedCallbackInfoInternal : ICallbackInfoInternal, IGettable<JoinLobbyAcceptedCallbackInfo>, ISettable<JoinLobbyAcceptedCallbackInfo>, IDisposable // TypeDefIndex: 9190
{
	// Fields
	private IntPtr m_ClientData; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private ulong m_UiEventId; // 0x10

	// Properties
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public ProductUserId LocalUserId { get; set; }
	public ulong UiEventId { get; set; }

	// Methods

	// RVA: 0x4C1C50 Offset: 0x4C0E50 VA: 0x1804C1C50
	public object get_ClientData() { }

	// RVA: 0x4C1D40 Offset: 0x4C0F40 VA: 0x1804C1D40
	public void set_ClientData(object value) { }

	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x4C1CC0 Offset: 0x4C0EC0 VA: 0x1804C1CC0
	public ProductUserId get_LocalUserId() { }

	// RVA: 0x4C1DA0 Offset: 0x4C0FA0 VA: 0x1804C1DA0
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public ulong get_UiEventId() { }

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_UiEventId(ulong value) { }

	// RVA: 0x4C1B90 Offset: 0x4C0D90 VA: 0x1804C1B90 Slot: 6
	public void Set(ref JoinLobbyAcceptedCallbackInfo other) { }

	// RVA: 0x4C1A70 Offset: 0x4C0C70 VA: 0x1804C1A70 Slot: 7
	public void Set(ref Nullable<JoinLobbyAcceptedCallbackInfo> other) { }

	// RVA: 0x4C19F0 Offset: 0x4C0BF0 VA: 0x1804C19F0 Slot: 8
	public void Dispose() { }

	// RVA: 0x4C1A50 Offset: 0x4C0C50 VA: 0x1804C1A50 Slot: 5
	public void Get(out JoinLobbyAcceptedCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.Lobby
public struct JoinLobbyByIdCallbackInfo : ICallbackInfo // TypeDefIndex: 9191
{
	// Fields
	[CompilerGenerated]
	private Result <ResultCode>k__BackingField; // 0x0
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x8
	[CompilerGenerated]
	private Utf8String <LobbyId>k__BackingField; // 0x10

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public Utf8String LobbyId { get; set; }

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
	public Utf8String get_LobbyId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_LobbyId(Utf8String value) { }

	// RVA: 0x4C2280 Offset: 0x4C1480 VA: 0x1804C2280 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x4C22D0 Offset: 0x4C14D0 VA: 0x1804C22D0
	internal void Set(ref JoinLobbyByIdCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.Lobby
internal struct JoinLobbyByIdCallbackInfoInternal : ICallbackInfoInternal, IGettable<JoinLobbyByIdCallbackInfo>, ISettable<JoinLobbyByIdCallbackInfo>, IDisposable // TypeDefIndex: 9192
{
	// Fields
	private Result m_ResultCode; // 0x0
	private IntPtr m_ClientData; // 0x8
	private IntPtr m_LobbyId; // 0x10

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public Utf8String LobbyId { get; set; }

	// Methods

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	// RVA: 0x4C20E0 Offset: 0x4C12E0 VA: 0x1804C20E0
	public object get_ClientData() { }

	// RVA: 0x4C21C0 Offset: 0x4C13C0 VA: 0x1804C21C0
	public void set_ClientData(object value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x4C2150 Offset: 0x4C1350 VA: 0x1804C2150
	public Utf8String get_LobbyId() { }

	// RVA: 0x4C2220 Offset: 0x4C1420 VA: 0x1804C2220
	public void set_LobbyId(Utf8String value) { }

	// RVA: 0x4C1F10 Offset: 0x4C1110 VA: 0x1804C1F10 Slot: 6
	public void Set(ref JoinLobbyByIdCallbackInfo other) { }

	// RVA: 0x4C1FC0 Offset: 0x4C11C0 VA: 0x1804C1FC0 Slot: 7
	public void Set(ref Nullable<JoinLobbyByIdCallbackInfo> other) { }

	// RVA: 0x4C1E90 Offset: 0x4C1090 VA: 0x1804C1E90 Slot: 8
	public void Dispose() { }

	// RVA: 0x4C1EF0 Offset: 0x4C10F0 VA: 0x1804C1EF0 Slot: 5
	public void Get(out JoinLobbyByIdCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.Lobby
public struct JoinLobbyByIdOptions // TypeDefIndex: 9193
{
	// Fields
	[CompilerGenerated]
	private Utf8String <LobbyId>k__BackingField; // 0x0
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x8
	[CompilerGenerated]
	private bool <PresenceEnabled>k__BackingField; // 0x10
	[CompilerGenerated]
	private Nullable<LocalRTCOptions> <LocalRTCOptions>k__BackingField; // 0x14
	[CompilerGenerated]
	private bool <CrossplayOptOut>k__BackingField; // 0x20

	// Properties
	public Utf8String LobbyId { get; set; }
	public ProductUserId LocalUserId { get; set; }
	public bool PresenceEnabled { get; set; }
	public Nullable<LocalRTCOptions> LocalRTCOptions { get; set; }
	public bool CrossplayOptOut { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Utf8String get_LobbyId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_LobbyId(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_LocalUserId(ProductUserId value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	public bool get_PresenceEnabled() { }

	[CompilerGenerated]
	// RVA: 0x3D6DB0 Offset: 0x3D5FB0 VA: 0x1803D6DB0
	public void set_PresenceEnabled(bool value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x4C29D0 Offset: 0x4C1BD0 VA: 0x1804C29D0
	public Nullable<LocalRTCOptions> get_LocalRTCOptions() { }

	[CompilerGenerated]
	// RVA: 0x4C29F0 Offset: 0x4C1BF0 VA: 0x1804C29F0
	public void set_LocalRTCOptions(Nullable<LocalRTCOptions> value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x4009D0 Offset: 0x3FFBD0 VA: 0x1804009D0
	public bool get_CrossplayOptOut() { }

	[CompilerGenerated]
	// RVA: 0x4009E0 Offset: 0x3FFBE0 VA: 0x1804009E0
	public void set_CrossplayOptOut(bool value) { }
}

// Namespace: Epic.OnlineServices.Lobby
internal struct JoinLobbyByIdOptionsInternal : ISettable<JoinLobbyByIdOptions>, IDisposable // TypeDefIndex: 9194
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LobbyId; // 0x8
	private IntPtr m_LocalUserId; // 0x10
	private int m_PresenceEnabled; // 0x18
	private IntPtr m_LocalRTCOptions; // 0x20
	private int m_CrossplayOptOut; // 0x28

	// Properties
	public Utf8String LobbyId { set; }
	public ProductUserId LocalUserId { set; }
	public bool PresenceEnabled { set; }
	public Nullable<LocalRTCOptions> LocalRTCOptions { set; }
	public bool CrossplayOptOut { set; }

	// Methods

	// RVA: 0x4C2840 Offset: 0x4C1A40 VA: 0x1804C2840
	public void set_LobbyId(Utf8String value) { }

	// RVA: 0x4C2910 Offset: 0x4C1B10 VA: 0x1804C2910
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x4C2970 Offset: 0x4C1B70 VA: 0x1804C2970
	public void set_PresenceEnabled(bool value) { }

	// RVA: 0x4C28A0 Offset: 0x4C1AA0 VA: 0x1804C28A0
	public void set_LocalRTCOptions(Nullable<LocalRTCOptions> value) { }

	// RVA: 0x4C27E0 Offset: 0x4C19E0 VA: 0x1804C27E0
	public void set_CrossplayOptOut(bool value) { }

	// RVA: 0x4C2410 Offset: 0x4C1610 VA: 0x1804C2410 Slot: 4
	public void Set(ref JoinLobbyByIdOptions other) { }

	// RVA: 0x4C25B0 Offset: 0x4C17B0 VA: 0x1804C25B0 Slot: 5
	public void Set(ref Nullable<JoinLobbyByIdOptions> other) { }

	// RVA: 0x4C23B0 Offset: 0x4C15B0 VA: 0x1804C23B0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Lobby
public struct JoinLobbyCallbackInfo : ICallbackInfo // TypeDefIndex: 9195
{
	// Fields
	[CompilerGenerated]
	private Result <ResultCode>k__BackingField; // 0x0
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x8
	[CompilerGenerated]
	private Utf8String <LobbyId>k__BackingField; // 0x10

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public Utf8String LobbyId { get; set; }

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
	public Utf8String get_LobbyId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_LobbyId(Utf8String value) { }

	// RVA: 0x4C2DF0 Offset: 0x4C1FF0 VA: 0x1804C2DF0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x4C2E40 Offset: 0x4C2040 VA: 0x1804C2E40
	internal void Set(ref JoinLobbyCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.Lobby
internal struct JoinLobbyCallbackInfoInternal : ICallbackInfoInternal, IGettable<JoinLobbyCallbackInfo>, ISettable<JoinLobbyCallbackInfo>, IDisposable // TypeDefIndex: 9196
{
	// Fields
	private Result m_ResultCode; // 0x0
	private IntPtr m_ClientData; // 0x8
	private IntPtr m_LobbyId; // 0x10

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public Utf8String LobbyId { get; set; }

	// Methods

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	// RVA: 0x4C2C50 Offset: 0x4C1E50 VA: 0x1804C2C50
	public object get_ClientData() { }

	// RVA: 0x4C2D30 Offset: 0x4C1F30 VA: 0x1804C2D30
	public void set_ClientData(object value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x4C2CC0 Offset: 0x4C1EC0 VA: 0x1804C2CC0
	public Utf8String get_LobbyId() { }

	// RVA: 0x4C2D90 Offset: 0x4C1F90 VA: 0x1804C2D90
	public void set_LobbyId(Utf8String value) { }

	// RVA: 0x4C2A80 Offset: 0x4C1C80 VA: 0x1804C2A80 Slot: 6
	public void Set(ref JoinLobbyCallbackInfo other) { }

	// RVA: 0x4C2B30 Offset: 0x4C1D30 VA: 0x1804C2B30 Slot: 7
	public void Set(ref Nullable<JoinLobbyCallbackInfo> other) { }

	// RVA: 0x4C2A00 Offset: 0x4C1C00 VA: 0x1804C2A00 Slot: 8
	public void Dispose() { }

	// RVA: 0x4C2A60 Offset: 0x4C1C60 VA: 0x1804C2A60 Slot: 5
	public void Get(out JoinLobbyCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.Lobby
public struct JoinLobbyOptions // TypeDefIndex: 9197
{
	// Fields
	[CompilerGenerated]
	private LobbyDetails <LobbyDetailsHandle>k__BackingField; // 0x0
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x8
	[CompilerGenerated]
	private bool <PresenceEnabled>k__BackingField; // 0x10
	[CompilerGenerated]
	private Nullable<LocalRTCOptions> <LocalRTCOptions>k__BackingField; // 0x14
	[CompilerGenerated]
	private bool <CrossplayOptOut>k__BackingField; // 0x20

	// Properties
	public LobbyDetails LobbyDetailsHandle { get; set; }
	public ProductUserId LocalUserId { get; set; }
	public bool PresenceEnabled { get; set; }
	public Nullable<LocalRTCOptions> LocalRTCOptions { get; set; }
	public bool CrossplayOptOut { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public LobbyDetails get_LobbyDetailsHandle() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_LobbyDetailsHandle(LobbyDetails value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_LocalUserId(ProductUserId value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	public bool get_PresenceEnabled() { }

	[CompilerGenerated]
	// RVA: 0x3D6DB0 Offset: 0x3D5FB0 VA: 0x1803D6DB0
	public void set_PresenceEnabled(bool value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x4C29D0 Offset: 0x4C1BD0 VA: 0x1804C29D0
	public Nullable<LocalRTCOptions> get_LocalRTCOptions() { }

	[CompilerGenerated]
	// RVA: 0x4C29F0 Offset: 0x4C1BF0 VA: 0x1804C29F0
	public void set_LocalRTCOptions(Nullable<LocalRTCOptions> value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x4009D0 Offset: 0x3FFBD0 VA: 0x1804009D0
	public bool get_CrossplayOptOut() { }

	[CompilerGenerated]
	// RVA: 0x4009E0 Offset: 0x3FFBE0 VA: 0x1804009E0
	public void set_CrossplayOptOut(bool value) { }
}

// Namespace: Epic.OnlineServices.Lobby
internal struct JoinLobbyOptionsInternal : ISettable<JoinLobbyOptions>, IDisposable // TypeDefIndex: 9198
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LobbyDetailsHandle; // 0x8
	private IntPtr m_LocalUserId; // 0x10
	private int m_PresenceEnabled; // 0x18
	private IntPtr m_LocalRTCOptions; // 0x20
	private int m_CrossplayOptOut; // 0x28

	// Properties
	public LobbyDetails LobbyDetailsHandle { set; }
	public ProductUserId LocalUserId { set; }
	public bool PresenceEnabled { set; }
	public Nullable<LocalRTCOptions> LocalRTCOptions { set; }
	public bool CrossplayOptOut { set; }

	// Methods

	// RVA: 0x4C33B0 Offset: 0x4C25B0 VA: 0x1804C33B0
	public void set_LobbyDetailsHandle(LobbyDetails value) { }

	// RVA: 0x4C3480 Offset: 0x4C2680 VA: 0x1804C3480
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x4C34E0 Offset: 0x4C26E0 VA: 0x1804C34E0
	public void set_PresenceEnabled(bool value) { }

	// RVA: 0x4C3410 Offset: 0x4C2610 VA: 0x1804C3410
	public void set_LocalRTCOptions(Nullable<LocalRTCOptions> value) { }

	// RVA: 0x4C3350 Offset: 0x4C2550 VA: 0x1804C3350
	public void set_CrossplayOptOut(bool value) { }

	// RVA: 0x4C2F80 Offset: 0x4C2180 VA: 0x1804C2F80 Slot: 4
	public void Set(ref JoinLobbyOptions other) { }

	// RVA: 0x4C3120 Offset: 0x4C2320 VA: 0x1804C3120 Slot: 5
	public void Set(ref Nullable<JoinLobbyOptions> other) { }

	// RVA: 0x4C2F20 Offset: 0x4C2120 VA: 0x1804C2F20 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Lobby
public struct KickMemberCallbackInfo : ICallbackInfo // TypeDefIndex: 9199
{
	// Fields
	[CompilerGenerated]
	private Result <ResultCode>k__BackingField; // 0x0
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x8
	[CompilerGenerated]
	private Utf8String <LobbyId>k__BackingField; // 0x10

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public Utf8String LobbyId { get; set; }

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
	public Utf8String get_LobbyId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_LobbyId(Utf8String value) { }

	// RVA: 0x4C3930 Offset: 0x4C2B30 VA: 0x1804C3930 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x4C3980 Offset: 0x4C2B80 VA: 0x1804C3980
	internal void Set(ref KickMemberCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.Lobby
internal struct KickMemberCallbackInfoInternal : ICallbackInfoInternal, IGettable<KickMemberCallbackInfo>, ISettable<KickMemberCallbackInfo>, IDisposable // TypeDefIndex: 9200
{
	// Fields
	private Result m_ResultCode; // 0x0
	private IntPtr m_ClientData; // 0x8
	private IntPtr m_LobbyId; // 0x10

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public Utf8String LobbyId { get; set; }

	// Methods

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	// RVA: 0x4C3790 Offset: 0x4C2990 VA: 0x1804C3790
	public object get_ClientData() { }

	// RVA: 0x4C3870 Offset: 0x4C2A70 VA: 0x1804C3870
	public void set_ClientData(object value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x4C3800 Offset: 0x4C2A00 VA: 0x1804C3800
	public Utf8String get_LobbyId() { }

	// RVA: 0x4C38D0 Offset: 0x4C2AD0 VA: 0x1804C38D0
	public void set_LobbyId(Utf8String value) { }

	// RVA: 0x4C35C0 Offset: 0x4C27C0 VA: 0x1804C35C0 Slot: 6
	public void Set(ref KickMemberCallbackInfo other) { }

	// RVA: 0x4C3670 Offset: 0x4C2870 VA: 0x1804C3670 Slot: 7
	public void Set(ref Nullable<KickMemberCallbackInfo> other) { }

	// RVA: 0x4C3540 Offset: 0x4C2740 VA: 0x1804C3540 Slot: 8
	public void Dispose() { }

	// RVA: 0x4C35A0 Offset: 0x4C27A0 VA: 0x1804C35A0 Slot: 5
	public void Get(out KickMemberCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.Lobby
public struct KickMemberOptions // TypeDefIndex: 9201
{
	// Fields
	[CompilerGenerated]
	private Utf8String <LobbyId>k__BackingField; // 0x0
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x8
	[CompilerGenerated]
	private ProductUserId <TargetUserId>k__BackingField; // 0x10

	// Properties
	public Utf8String LobbyId { get; set; }
	public ProductUserId LocalUserId { get; set; }
	public ProductUserId TargetUserId { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Utf8String get_LobbyId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_LobbyId(Utf8String value) { }

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
	public ProductUserId get_TargetUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_TargetUserId(ProductUserId value) { }
}

// Namespace: Epic.OnlineServices.Lobby
internal struct KickMemberOptionsInternal : ISettable<KickMemberOptions>, IDisposable // TypeDefIndex: 9202
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LobbyId; // 0x8
	private IntPtr m_LocalUserId; // 0x10
	private IntPtr m_TargetUserId; // 0x18

	// Properties
	public Utf8String LobbyId { set; }
	public ProductUserId LocalUserId { set; }
	public ProductUserId TargetUserId { set; }

	// Methods

	// RVA: 0x4C3D20 Offset: 0x4C2F20 VA: 0x1804C3D20
	public void set_LobbyId(Utf8String value) { }

	// RVA: 0x4C3D80 Offset: 0x4C2F80 VA: 0x1804C3D80
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x4C3DE0 Offset: 0x4C2FE0 VA: 0x1804C3DE0
	public void set_TargetUserId(ProductUserId value) { }

	// RVA: 0x4C3AC0 Offset: 0x4C2CC0 VA: 0x1804C3AC0 Slot: 4
	public void Set(ref KickMemberOptions other) { }

	// RVA: 0x4C3BC0 Offset: 0x4C2DC0 VA: 0x1804C3BC0 Slot: 5
	public void Set(ref Nullable<KickMemberOptions> other) { }

	// RVA: 0x4C3A60 Offset: 0x4C2C60 VA: 0x1804C3A60 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Lobby
public struct LeaveLobbyCallbackInfo : ICallbackInfo // TypeDefIndex: 9203
{
	// Fields
	[CompilerGenerated]
	private Result <ResultCode>k__BackingField; // 0x0
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x8
	[CompilerGenerated]
	private Utf8String <LobbyId>k__BackingField; // 0x10

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public Utf8String LobbyId { get; set; }

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
	public Utf8String get_LobbyId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_LobbyId(Utf8String value) { }

	// RVA: 0x4C4230 Offset: 0x4C3430 VA: 0x1804C4230 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x4C4280 Offset: 0x4C3480 VA: 0x1804C4280
	internal void Set(ref LeaveLobbyCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.Lobby
internal struct LeaveLobbyCallbackInfoInternal : ICallbackInfoInternal, IGettable<LeaveLobbyCallbackInfo>, ISettable<LeaveLobbyCallbackInfo>, IDisposable // TypeDefIndex: 9204
{
	// Fields
	private Result m_ResultCode; // 0x0
	private IntPtr m_ClientData; // 0x8
	private IntPtr m_LobbyId; // 0x10

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public Utf8String LobbyId { get; set; }

	// Methods

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	// RVA: 0x4C4090 Offset: 0x4C3290 VA: 0x1804C4090
	public object get_ClientData() { }

	// RVA: 0x4C4170 Offset: 0x4C3370 VA: 0x1804C4170
	public void set_ClientData(object value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x4C4100 Offset: 0x4C3300 VA: 0x1804C4100
	public Utf8String get_LobbyId() { }

	// RVA: 0x4C41D0 Offset: 0x4C33D0 VA: 0x1804C41D0
	public void set_LobbyId(Utf8String value) { }

	// RVA: 0x4C3FE0 Offset: 0x4C31E0 VA: 0x1804C3FE0 Slot: 6
	public void Set(ref LeaveLobbyCallbackInfo other) { }

	// RVA: 0x4C3EC0 Offset: 0x4C30C0 VA: 0x1804C3EC0 Slot: 7
	public void Set(ref Nullable<LeaveLobbyCallbackInfo> other) { }

	// RVA: 0x4C3E40 Offset: 0x4C3040 VA: 0x1804C3E40 Slot: 8
	public void Dispose() { }

	// RVA: 0x4C3EA0 Offset: 0x4C30A0 VA: 0x1804C3EA0 Slot: 5
	public void Get(out LeaveLobbyCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.Lobby
public struct LeaveLobbyOptions // TypeDefIndex: 9205
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <LobbyId>k__BackingField; // 0x8

	// Properties
	public ProductUserId LocalUserId { get; set; }
	public Utf8String LobbyId { get; set; }

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
	public Utf8String get_LobbyId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_LobbyId(Utf8String value) { }
}

// Namespace: Epic.OnlineServices.Lobby
internal struct LeaveLobbyOptionsInternal : ISettable<LeaveLobbyOptions>, IDisposable // TypeDefIndex: 9206
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_LobbyId; // 0x10

	// Properties
	public ProductUserId LocalUserId { set; }
	public Utf8String LobbyId { set; }

	// Methods

	// RVA: 0x4C45E0 Offset: 0x4C37E0 VA: 0x1804C45E0
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x4C4580 Offset: 0x4C3780 VA: 0x1804C4580
	public void set_LobbyId(Utf8String value) { }

	// RVA: 0x4C44C0 Offset: 0x4C36C0 VA: 0x1804C44C0 Slot: 4
	public void Set(ref LeaveLobbyOptions other) { }

	// RVA: 0x4C43C0 Offset: 0x4C35C0 VA: 0x1804C43C0 Slot: 5
	public void Set(ref Nullable<LeaveLobbyOptions> other) { }

	// RVA: 0x4C4360 Offset: 0x4C3560 VA: 0x1804C4360 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Lobby
public struct LeaveLobbyRequestedCallbackInfo : ICallbackInfo // TypeDefIndex: 9207
{
	// Fields
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x0
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x8
	[CompilerGenerated]
	private Utf8String <LobbyId>k__BackingField; // 0x10

	// Properties
	public object ClientData { get; set; }
	public ProductUserId LocalUserId { get; set; }
	public Utf8String LobbyId { get; set; }

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
	public Utf8String get_LobbyId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_LobbyId(Utf8String value) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x4C4B80 Offset: 0x4C3D80 VA: 0x1804C4B80
	internal void Set(ref LeaveLobbyRequestedCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.Lobby
internal struct LeaveLobbyRequestedCallbackInfoInternal : ICallbackInfoInternal, IGettable<LeaveLobbyRequestedCallbackInfo>, ISettable<LeaveLobbyRequestedCallbackInfo>, IDisposable // TypeDefIndex: 9208
{
	// Fields
	private IntPtr m_ClientData; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_LobbyId; // 0x10

	// Properties
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public ProductUserId LocalUserId { get; set; }
	public Utf8String LobbyId { get; set; }

	// Methods

	// RVA: 0x4C4900 Offset: 0x4C3B00 VA: 0x1804C4900
	public object get_ClientData() { }

	// RVA: 0x4C4A60 Offset: 0x4C3C60 VA: 0x1804C4A60
	public void set_ClientData(object value) { }

	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x4C49E0 Offset: 0x4C3BE0 VA: 0x1804C49E0
	public ProductUserId get_LocalUserId() { }

	// RVA: 0x4C4B20 Offset: 0x4C3D20 VA: 0x1804C4B20
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x4C4970 Offset: 0x4C3B70 VA: 0x1804C4970
	public Utf8String get_LobbyId() { }

	// RVA: 0x4C4AC0 Offset: 0x4C3CC0 VA: 0x1804C4AC0
	public void set_LobbyId(Utf8String value) { }

	// RVA: 0x4C46C0 Offset: 0x4C38C0 VA: 0x1804C46C0 Slot: 6
	public void Set(ref LeaveLobbyRequestedCallbackInfo other) { }

	// RVA: 0x4C47B0 Offset: 0x4C39B0 VA: 0x1804C47B0 Slot: 7
	public void Set(ref Nullable<LeaveLobbyRequestedCallbackInfo> other) { }

	// RVA: 0x4C4640 Offset: 0x4C3840 VA: 0x1804C4640 Slot: 8
	public void Dispose() { }

	// RVA: 0x4C46A0 Offset: 0x4C38A0 VA: 0x1804C46A0 Slot: 5
	public void Get(out LeaveLobbyRequestedCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.Lobby
public enum LobbyAttributeVisibility // TypeDefIndex: 9209
{
	// Fields
	public int value__; // 0x0
	public const LobbyAttributeVisibility Public = 0;
	public const LobbyAttributeVisibility Private = 1;
}

// Namespace: Epic.OnlineServices.Lobby
public sealed class LobbyDetails : Handle // TypeDefIndex: 9210
{
	// Fields
	public const int LobbydetailsCopyattributebyindexApiLatest = 1;
	public const int LobbydetailsCopyattributebykeyApiLatest = 1;
	public const int LobbydetailsCopyinfoApiLatest = 1;
	public const int LobbydetailsCopymemberattributebyindexApiLatest = 1;
	public const int LobbydetailsCopymemberattributebykeyApiLatest = 1;
	public const int LobbydetailsCopymemberinfoApiLatest = 1;
	public const int LobbydetailsGetattributecountApiLatest = 1;
	public const int LobbydetailsGetlobbyownerApiLatest = 1;
	public const int LobbydetailsGetmemberattributecountApiLatest = 1;
	public const int LobbydetailsGetmemberbyindexApiLatest = 1;
	public const int LobbydetailsGetmembercountApiLatest = 1;
	public const int LobbydetailsInfoApiLatest = 3;
	public const int LobbydetailsMemberinfoApiLatest = 1;

	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }

	// RVA: 0x40BDB0 Offset: 0x40AFB0 VA: 0x18040BDB0
	public void .ctor(IntPtr innerHandle) { }

	// RVA: 0x4C6F70 Offset: 0x4C6170 VA: 0x1804C6F70
	public Result CopyAttributeByIndex(ref LobbyDetailsCopyAttributeByIndexOptions options, out Nullable<Attribute> outAttribute) { }

	// RVA: 0x4C7060 Offset: 0x4C6260 VA: 0x1804C7060
	public Result CopyAttributeByKey(ref LobbyDetailsCopyAttributeByKeyOptions options, out Nullable<Attribute> outAttribute) { }

	// RVA: 0x4C7190 Offset: 0x4C6390 VA: 0x1804C7190
	public Result CopyInfo(ref LobbyDetailsCopyInfoOptions options, out Nullable<LobbyDetailsInfo> outLobbyDetailsInfo) { }

	// RVA: 0x4C7270 Offset: 0x4C6470 VA: 0x1804C7270
	public Result CopyMemberAttributeByIndex(ref LobbyDetailsCopyMemberAttributeByIndexOptions options, out Nullable<Attribute> outAttribute) { }

	// RVA: 0x4C73C0 Offset: 0x4C65C0 VA: 0x1804C73C0
	public Result CopyMemberAttributeByKey(ref LobbyDetailsCopyMemberAttributeByKeyOptions options, out Nullable<Attribute> outAttribute) { }

	// RVA: 0x4C74C0 Offset: 0x4C66C0 VA: 0x1804C74C0
	public Result CopyMemberInfo(ref LobbyDetailsCopyMemberInfoOptions options, out Nullable<LobbyDetailsMemberInfo> outLobbyDetailsMemberInfo) { }

	// RVA: 0x4C75F0 Offset: 0x4C67F0 VA: 0x1804C75F0
	public uint GetAttributeCount(ref LobbyDetailsGetAttributeCountOptions options) { }

	// RVA: 0x4C7670 Offset: 0x4C6870 VA: 0x1804C7670
	public ProductUserId GetLobbyOwner(ref LobbyDetailsGetLobbyOwnerOptions options) { }

	// RVA: 0x4C7720 Offset: 0x4C6920 VA: 0x1804C7720
	public uint GetMemberAttributeCount(ref LobbyDetailsGetMemberAttributeCountOptions options) { }

	// RVA: 0x4C7800 Offset: 0x4C6A00 VA: 0x1804C7800
	public ProductUserId GetMemberByIndex(ref LobbyDetailsGetMemberByIndexOptions options) { }

	// RVA: 0x4C78C0 Offset: 0x4C6AC0 VA: 0x1804C78C0
	public uint GetMemberCount(ref LobbyDetailsGetMemberCountOptions options) { }

	// RVA: 0x4C7940 Offset: 0x4C6B40 VA: 0x1804C7940
	public void Release() { }
}

// Namespace: Epic.OnlineServices.Lobby
public struct LobbyDetailsCopyAttributeByIndexOptions // TypeDefIndex: 9211
{
	// Fields
	[CompilerGenerated]
	private uint <AttrIndex>k__BackingField; // 0x0

	// Properties
	public uint AttrIndex { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public uint get_AttrIndex() { }

	[CompilerGenerated]
	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_AttrIndex(uint value) { }
}

// Namespace: Epic.OnlineServices.Lobby
internal struct LobbyDetailsCopyAttributeByIndexOptionsInternal : ISettable<LobbyDetailsCopyAttributeByIndexOptions>, IDisposable // TypeDefIndex: 9212
{
	// Fields
	private int m_ApiVersion; // 0x0
	private uint m_AttrIndex; // 0x4

	// Properties
	public uint AttrIndex { set; }

	// Methods

	// RVA: 0x3F84A0 Offset: 0x3F76A0 VA: 0x1803F84A0
	public void set_AttrIndex(uint value) { }

	// RVA: 0x40B2E0 Offset: 0x40A4E0 VA: 0x18040B2E0 Slot: 4
	public void Set(ref LobbyDetailsCopyAttributeByIndexOptions other) { }

	// RVA: 0x4C4C60 Offset: 0x4C3E60 VA: 0x1804C4C60 Slot: 5
	public void Set(ref Nullable<LobbyDetailsCopyAttributeByIndexOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Lobby
public struct LobbyDetailsCopyAttributeByKeyOptions // TypeDefIndex: 9213
{
	// Fields
	[CompilerGenerated]
	private Utf8String <AttrKey>k__BackingField; // 0x0

	// Properties
	public Utf8String AttrKey { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Utf8String get_AttrKey() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_AttrKey(Utf8String value) { }
}

// Namespace: Epic.OnlineServices.Lobby
internal struct LobbyDetailsCopyAttributeByKeyOptionsInternal : ISettable<LobbyDetailsCopyAttributeByKeyOptions>, IDisposable // TypeDefIndex: 9214
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_AttrKey; // 0x8

	// Properties
	public Utf8String AttrKey { set; }

	// Methods

	// RVA: 0x4C4E10 Offset: 0x4C4010 VA: 0x1804C4E10
	public void set_AttrKey(Utf8String value) { }

	// RVA: 0x4C4D10 Offset: 0x4C3F10 VA: 0x1804C4D10 Slot: 4
	public void Set(ref LobbyDetailsCopyAttributeByKeyOptions other) { }

	// RVA: 0x4C4D70 Offset: 0x4C3F70 VA: 0x1804C4D70 Slot: 5
	public void Set(ref Nullable<LobbyDetailsCopyAttributeByKeyOptions> other) { }

	// RVA: 0x4C4CC0 Offset: 0x4C3EC0 VA: 0x1804C4CC0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Lobby
public struct LobbyDetailsCopyInfoOptions // TypeDefIndex: 9215
{}

// Namespace: Epic.OnlineServices.Lobby
internal struct LobbyDetailsCopyInfoOptionsInternal : ISettable<LobbyDetailsCopyInfoOptions>, IDisposable // TypeDefIndex: 9216
{
	// Fields
	private int m_ApiVersion; // 0x0

	// Methods

	// RVA: 0x3F98A0 Offset: 0x3F8AA0 VA: 0x1803F98A0 Slot: 4
	public void Set(ref LobbyDetailsCopyInfoOptions other) { }

	// RVA: 0x4C4E70 Offset: 0x4C4070 VA: 0x1804C4E70 Slot: 5
	public void Set(ref Nullable<LobbyDetailsCopyInfoOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Lobby
public struct LobbyDetailsCopyMemberAttributeByIndexOptions // TypeDefIndex: 9217
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <TargetUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private uint <AttrIndex>k__BackingField; // 0x8

	// Properties
	public ProductUserId TargetUserId { get; set; }
	public uint AttrIndex { get; set; }

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
	// RVA: 0x3F5510 Offset: 0x3F4710 VA: 0x1803F5510
	public uint get_AttrIndex() { }

	[CompilerGenerated]
	// RVA: 0x3F5520 Offset: 0x3F4720 VA: 0x1803F5520
	public void set_AttrIndex(uint value) { }
}

// Namespace: Epic.OnlineServices.Lobby
internal struct LobbyDetailsCopyMemberAttributeByIndexOptionsInternal : ISettable<LobbyDetailsCopyMemberAttributeByIndexOptions>, IDisposable // TypeDefIndex: 9218
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_TargetUserId; // 0x8
	private uint m_AttrIndex; // 0x10

	// Properties
	public ProductUserId TargetUserId { set; }
	public uint AttrIndex { set; }

	// Methods

	// RVA: 0x4C5050 Offset: 0x4C4250 VA: 0x1804C5050
	public void set_TargetUserId(ProductUserId value) { }

	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_AttrIndex(uint value) { }

	// RVA: 0x4C4FD0 Offset: 0x4C41D0 VA: 0x1804C4FD0 Slot: 4
	public void Set(ref LobbyDetailsCopyMemberAttributeByIndexOptions other) { }

	// RVA: 0x4C4F10 Offset: 0x4C4110 VA: 0x1804C4F10 Slot: 5
	public void Set(ref Nullable<LobbyDetailsCopyMemberAttributeByIndexOptions> other) { }

	// RVA: 0x4C4EC0 Offset: 0x4C40C0 VA: 0x1804C4EC0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Lobby
public struct LobbyDetailsCopyMemberAttributeByKeyOptions // TypeDefIndex: 9219
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <TargetUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <AttrKey>k__BackingField; // 0x8

	// Properties
	public ProductUserId TargetUserId { get; set; }
	public Utf8String AttrKey { get; set; }

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
	public Utf8String get_AttrKey() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_AttrKey(Utf8String value) { }
}

// Namespace: Epic.OnlineServices.Lobby
internal struct LobbyDetailsCopyMemberAttributeByKeyOptionsInternal : ISettable<LobbyDetailsCopyMemberAttributeByKeyOptions>, IDisposable // TypeDefIndex: 9220
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_TargetUserId; // 0x8
	private IntPtr m_AttrKey; // 0x10

	// Properties
	public ProductUserId TargetUserId { set; }
	public Utf8String AttrKey { set; }

	// Methods

	// RVA: 0x4C5330 Offset: 0x4C4530 VA: 0x1804C5330
	public void set_TargetUserId(ProductUserId value) { }

	// RVA: 0x4C52D0 Offset: 0x4C44D0 VA: 0x1804C52D0
	public void set_AttrKey(Utf8String value) { }

	// RVA: 0x4C5110 Offset: 0x4C4310 VA: 0x1804C5110 Slot: 4
	public void Set(ref LobbyDetailsCopyMemberAttributeByKeyOptions other) { }

	// RVA: 0x4C51D0 Offset: 0x4C43D0 VA: 0x1804C51D0 Slot: 5
	public void Set(ref Nullable<LobbyDetailsCopyMemberAttributeByKeyOptions> other) { }

	// RVA: 0x4C50B0 Offset: 0x4C42B0 VA: 0x1804C50B0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Lobby
public struct LobbyDetailsCopyMemberInfoOptions // TypeDefIndex: 9221
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

// Namespace: Epic.OnlineServices.Lobby
internal struct LobbyDetailsCopyMemberInfoOptionsInternal : ISettable<LobbyDetailsCopyMemberInfoOptions>, IDisposable // TypeDefIndex: 9222
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_TargetUserId; // 0x8

	// Properties
	public ProductUserId TargetUserId { set; }

	// Methods

	// RVA: 0x4C54E0 Offset: 0x4C46E0 VA: 0x1804C54E0
	public void set_TargetUserId(ProductUserId value) { }

	// RVA: 0x4C5480 Offset: 0x4C4680 VA: 0x1804C5480 Slot: 4
	public void Set(ref LobbyDetailsCopyMemberInfoOptions other) { }

	// RVA: 0x4C53E0 Offset: 0x4C45E0 VA: 0x1804C53E0 Slot: 5
	public void Set(ref Nullable<LobbyDetailsCopyMemberInfoOptions> other) { }

	// RVA: 0x4C5390 Offset: 0x4C4590 VA: 0x1804C5390 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Lobby
public struct LobbyDetailsGetAttributeCountOptions // TypeDefIndex: 9223
{}

// Namespace: Epic.OnlineServices.Lobby
internal struct LobbyDetailsGetAttributeCountOptionsInternal : ISettable<LobbyDetailsGetAttributeCountOptions>, IDisposable // TypeDefIndex: 9224
{
	// Fields
	private int m_ApiVersion; // 0x0

	// Methods

	// RVA: 0x3F98A0 Offset: 0x3F8AA0 VA: 0x1803F98A0 Slot: 4
	public void Set(ref LobbyDetailsGetAttributeCountOptions other) { }

	// RVA: 0x4C5540 Offset: 0x4C4740 VA: 0x1804C5540 Slot: 5
	public void Set(ref Nullable<LobbyDetailsGetAttributeCountOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Lobby
public struct LobbyDetailsGetLobbyOwnerOptions // TypeDefIndex: 9225
{}

// Namespace: Epic.OnlineServices.Lobby
internal struct LobbyDetailsGetLobbyOwnerOptionsInternal : ISettable<LobbyDetailsGetLobbyOwnerOptions>, IDisposable // TypeDefIndex: 9226
{
	// Fields
	private int m_ApiVersion; // 0x0

	// Methods

	// RVA: 0x3F98A0 Offset: 0x3F8AA0 VA: 0x1803F98A0 Slot: 4
	public void Set(ref LobbyDetailsGetLobbyOwnerOptions other) { }

	// RVA: 0x4C5590 Offset: 0x4C4790 VA: 0x1804C5590 Slot: 5
	public void Set(ref Nullable<LobbyDetailsGetLobbyOwnerOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Lobby
public struct LobbyDetailsGetMemberAttributeCountOptions // TypeDefIndex: 9227
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

// Namespace: Epic.OnlineServices.Lobby
internal struct LobbyDetailsGetMemberAttributeCountOptionsInternal : ISettable<LobbyDetailsGetMemberAttributeCountOptions>, IDisposable // TypeDefIndex: 9228
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_TargetUserId; // 0x8

	// Properties
	public ProductUserId TargetUserId { set; }

	// Methods

	// RVA: 0x4C5730 Offset: 0x4C4930 VA: 0x1804C5730
	public void set_TargetUserId(ProductUserId value) { }

	// RVA: 0x4C56D0 Offset: 0x4C48D0 VA: 0x1804C56D0 Slot: 4
	public void Set(ref LobbyDetailsGetMemberAttributeCountOptions other) { }

	// RVA: 0x4C5630 Offset: 0x4C4830 VA: 0x1804C5630 Slot: 5
	public void Set(ref Nullable<LobbyDetailsGetMemberAttributeCountOptions> other) { }

	// RVA: 0x4C55E0 Offset: 0x4C47E0 VA: 0x1804C55E0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Lobby
public struct LobbyDetailsGetMemberByIndexOptions // TypeDefIndex: 9229
{
	// Fields
	[CompilerGenerated]
	private uint <MemberIndex>k__BackingField; // 0x0

	// Properties
	public uint MemberIndex { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public uint get_MemberIndex() { }

	[CompilerGenerated]
	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_MemberIndex(uint value) { }
}

// Namespace: Epic.OnlineServices.Lobby
internal struct LobbyDetailsGetMemberByIndexOptionsInternal : ISettable<LobbyDetailsGetMemberByIndexOptions>, IDisposable // TypeDefIndex: 9230
{
	// Fields
	private int m_ApiVersion; // 0x0
	private uint m_MemberIndex; // 0x4

	// Properties
	public uint MemberIndex { set; }

	// Methods

	// RVA: 0x3F84A0 Offset: 0x3F76A0 VA: 0x1803F84A0
	public void set_MemberIndex(uint value) { }

	// RVA: 0x40B2E0 Offset: 0x40A4E0 VA: 0x18040B2E0 Slot: 4
	public void Set(ref LobbyDetailsGetMemberByIndexOptions other) { }

	// RVA: 0x4C5790 Offset: 0x4C4990 VA: 0x1804C5790 Slot: 5
	public void Set(ref Nullable<LobbyDetailsGetMemberByIndexOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Lobby
public struct LobbyDetailsGetMemberCountOptions // TypeDefIndex: 9231
{}

// Namespace: Epic.OnlineServices.Lobby
internal struct LobbyDetailsGetMemberCountOptionsInternal : ISettable<LobbyDetailsGetMemberCountOptions>, IDisposable // TypeDefIndex: 9232
{
	// Fields
	private int m_ApiVersion; // 0x0

	// Methods

	// RVA: 0x3F98A0 Offset: 0x3F8AA0 VA: 0x1803F98A0 Slot: 4
	public void Set(ref LobbyDetailsGetMemberCountOptions other) { }

	// RVA: 0x4C57F0 Offset: 0x4C49F0 VA: 0x1804C57F0 Slot: 5
	public void Set(ref Nullable<LobbyDetailsGetMemberCountOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Lobby
public struct LobbyDetailsInfo // TypeDefIndex: 9233
{
	// Fields
	[CompilerGenerated]
	private Utf8String <LobbyId>k__BackingField; // 0x0
	[CompilerGenerated]
	private ProductUserId <LobbyOwnerUserId>k__BackingField; // 0x8
	[CompilerGenerated]
	private LobbyPermissionLevel <PermissionLevel>k__BackingField; // 0x10
	[CompilerGenerated]
	private uint <AvailableSlots>k__BackingField; // 0x14
	[CompilerGenerated]
	private uint <MaxMembers>k__BackingField; // 0x18
	[CompilerGenerated]
	private bool <AllowInvites>k__BackingField; // 0x1C
	[CompilerGenerated]
	private Utf8String <BucketId>k__BackingField; // 0x20
	[CompilerGenerated]
	private bool <AllowHostMigration>k__BackingField; // 0x28
	[CompilerGenerated]
	private bool <RTCRoomEnabled>k__BackingField; // 0x29
	[CompilerGenerated]
	private bool <AllowJoinById>k__BackingField; // 0x2A
	[CompilerGenerated]
	private bool <RejoinAfterKickRequiresInvite>k__BackingField; // 0x2B
	[CompilerGenerated]
	private bool <PresenceEnabled>k__BackingField; // 0x2C
	[CompilerGenerated]
	private uint[] <AllowedPlatformIds>k__BackingField; // 0x30

	// Properties
	public Utf8String LobbyId { get; set; }
	public ProductUserId LobbyOwnerUserId { get; set; }
	public LobbyPermissionLevel PermissionLevel { get; set; }
	public uint AvailableSlots { get; set; }
	public uint MaxMembers { get; set; }
	public bool AllowInvites { get; set; }
	public Utf8String BucketId { get; set; }
	public bool AllowHostMigration { get; set; }
	public bool RTCRoomEnabled { get; set; }
	public bool AllowJoinById { get; set; }
	public bool RejoinAfterKickRequiresInvite { get; set; }
	public bool PresenceEnabled { get; set; }
	public uint[] AllowedPlatformIds { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Utf8String get_LobbyId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_LobbyId(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public ProductUserId get_LobbyOwnerUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_LobbyOwnerUserId(ProductUserId value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public LobbyPermissionLevel get_PermissionLevel() { }

	[CompilerGenerated]
	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_PermissionLevel(LobbyPermissionLevel value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500
	public uint get_AvailableSlots() { }

	[CompilerGenerated]
	// RVA: 0x426530 Offset: 0x425730 VA: 0x180426530
	public void set_AvailableSlots(uint value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public uint get_MaxMembers() { }

	[CompilerGenerated]
	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	public void set_MaxMembers(uint value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x416930 Offset: 0x415B30 VA: 0x180416930
	public bool get_AllowInvites() { }

	[CompilerGenerated]
	// RVA: 0x416950 Offset: 0x415B50 VA: 0x180416950
	public void set_AllowInvites(bool value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public Utf8String get_BucketId() { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_BucketId(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x42D840 Offset: 0x42CA40 VA: 0x18042D840
	public bool get_AllowHostMigration() { }

	[CompilerGenerated]
	// RVA: 0x42D8B0 Offset: 0x42CAB0 VA: 0x18042D8B0
	public void set_AllowHostMigration(bool value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x4C6AB0 Offset: 0x4C5CB0 VA: 0x1804C6AB0
	public bool get_RTCRoomEnabled() { }

	[CompilerGenerated]
	// RVA: 0x4C6AE0 Offset: 0x4C5CE0 VA: 0x1804C6AE0
	public void set_RTCRoomEnabled(bool value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x4C6AA0 Offset: 0x4C5CA0 VA: 0x1804C6AA0
	public bool get_AllowJoinById() { }

	[CompilerGenerated]
	// RVA: 0x4C6AD0 Offset: 0x4C5CD0 VA: 0x1804C6AD0
	public void set_AllowJoinById(bool value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x4C6AC0 Offset: 0x4C5CC0 VA: 0x1804C6AC0
	public bool get_RejoinAfterKickRequiresInvite() { }

	[CompilerGenerated]
	// RVA: 0x4C6AF0 Offset: 0x4C5CF0 VA: 0x1804C6AF0
	public void set_RejoinAfterKickRequiresInvite(bool value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x48DA50 Offset: 0x48CC50 VA: 0x18048DA50
	public bool get_PresenceEnabled() { }

	[CompilerGenerated]
	// RVA: 0x48DA70 Offset: 0x48CC70 VA: 0x18048DA70
	public void set_PresenceEnabled(bool value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public uint[] get_AllowedPlatformIds() { }

	[CompilerGenerated]
	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	public void set_AllowedPlatformIds(uint[] value) { }

	// RVA: 0x4C67C0 Offset: 0x4C59C0 VA: 0x1804C67C0
	internal void Set(ref LobbyDetailsInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.Lobby
internal struct LobbyDetailsInfoInternal : IGettable<LobbyDetailsInfo>, ISettable<LobbyDetailsInfo>, IDisposable // TypeDefIndex: 9234
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LobbyId; // 0x8
	private IntPtr m_LobbyOwnerUserId; // 0x10
	private LobbyPermissionLevel m_PermissionLevel; // 0x18
	private uint m_AvailableSlots; // 0x1C
	private uint m_MaxMembers; // 0x20
	private int m_AllowInvites; // 0x24
	private IntPtr m_BucketId; // 0x28
	private int m_AllowHostMigration; // 0x30
	private int m_RTCRoomEnabled; // 0x34
	private int m_AllowJoinById; // 0x38
	private int m_RejoinAfterKickRequiresInvite; // 0x3C
	private int m_PresenceEnabled; // 0x40
	private IntPtr m_AllowedPlatformIds; // 0x48
	private uint m_AllowedPlatformIdsCount; // 0x50

	// Properties
	public Utf8String LobbyId { get; set; }
	public ProductUserId LobbyOwnerUserId { get; set; }
	public LobbyPermissionLevel PermissionLevel { get; set; }
	public uint AvailableSlots { get; set; }
	public uint MaxMembers { get; set; }
	public bool AllowInvites { get; set; }
	public Utf8String BucketId { get; set; }
	public bool AllowHostMigration { get; set; }
	public bool RTCRoomEnabled { get; set; }
	public bool AllowJoinById { get; set; }
	public bool RejoinAfterKickRequiresInvite { get; set; }
	public bool PresenceEnabled { get; set; }
	public uint[] AllowedPlatformIds { get; set; }

	// Methods

	// RVA: 0x4C61E0 Offset: 0x4C53E0 VA: 0x1804C61E0
	public Utf8String get_LobbyId() { }

	// RVA: 0x4C65E0 Offset: 0x4C57E0 VA: 0x1804C65E0
	public void set_LobbyId(Utf8String value) { }

	// RVA: 0x4C6250 Offset: 0x4C5450 VA: 0x1804C6250
	public ProductUserId get_LobbyOwnerUserId() { }

	// RVA: 0x4C6640 Offset: 0x4C5840 VA: 0x1804C6640
	public void set_LobbyOwnerUserId(ProductUserId value) { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public LobbyPermissionLevel get_PermissionLevel() { }

	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	public void set_PermissionLevel(LobbyPermissionLevel value) { }

	// RVA: 0x3F9110 Offset: 0x3F8310 VA: 0x1803F9110
	public uint get_AvailableSlots() { }

	// RVA: 0x3F9290 Offset: 0x3F8490 VA: 0x1803F9290
	public void set_AvailableSlots(uint value) { }

	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400
	public uint get_MaxMembers() { }

	// RVA: 0x3DA420 Offset: 0x3D9620 VA: 0x1803DA420
	public void set_MaxMembers(uint value) { }

	// RVA: 0x4C6020 Offset: 0x4C5220 VA: 0x1804C6020
	public bool get_AllowInvites() { }

	// RVA: 0x4C6450 Offset: 0x4C5650 VA: 0x1804C6450
	public void set_AllowInvites(bool value) { }

	// RVA: 0x4C6170 Offset: 0x4C5370 VA: 0x1804C6170
	public Utf8String get_BucketId() { }

	// RVA: 0x4C6580 Offset: 0x4C5780 VA: 0x1804C6580
	public void set_BucketId(Utf8String value) { }

	// RVA: 0x4C5FC0 Offset: 0x4C51C0 VA: 0x1804C5FC0
	public bool get_AllowHostMigration() { }

	// RVA: 0x4C63F0 Offset: 0x4C55F0 VA: 0x1804C63F0
	public void set_AllowHostMigration(bool value) { }

	// RVA: 0x4C6330 Offset: 0x4C5530 VA: 0x1804C6330
	public bool get_RTCRoomEnabled() { }

	// RVA: 0x4C6700 Offset: 0x4C5900 VA: 0x1804C6700
	public void set_RTCRoomEnabled(bool value) { }

	// RVA: 0x4C6080 Offset: 0x4C5280 VA: 0x1804C6080
	public bool get_AllowJoinById() { }

	// RVA: 0x4C64B0 Offset: 0x4C56B0 VA: 0x1804C64B0
	public void set_AllowJoinById(bool value) { }

	// RVA: 0x4C6390 Offset: 0x4C5590 VA: 0x1804C6390
	public bool get_RejoinAfterKickRequiresInvite() { }

	// RVA: 0x4C6760 Offset: 0x4C5960 VA: 0x1804C6760
	public void set_RejoinAfterKickRequiresInvite(bool value) { }

	// RVA: 0x4C62D0 Offset: 0x4C54D0 VA: 0x1804C62D0
	public bool get_PresenceEnabled() { }

	// RVA: 0x4C66A0 Offset: 0x4C58A0 VA: 0x1804C66A0
	public void set_PresenceEnabled(bool value) { }

	// RVA: 0x4C60E0 Offset: 0x4C52E0 VA: 0x1804C60E0
	public uint[] get_AllowedPlatformIds() { }

	// RVA: 0x4C6510 Offset: 0x4C5710 VA: 0x1804C6510
	public void set_AllowedPlatformIds(uint[] value) { }

	// RVA: 0x4C5CC0 Offset: 0x4C4EC0 VA: 0x1804C5CC0 Slot: 5
	public void Set(ref LobbyDetailsInfo other) { }

	// RVA: 0x4C58E0 Offset: 0x4C4AE0 VA: 0x1804C58E0 Slot: 6
	public void Set(ref Nullable<LobbyDetailsInfo> other) { }

	// RVA: 0x4C5840 Offset: 0x4C4A40 VA: 0x1804C5840 Slot: 7
	public void Dispose() { }

	// RVA: 0x4C58B0 Offset: 0x4C4AB0 VA: 0x1804C58B0 Slot: 4
	public void Get(out LobbyDetailsInfo output) { }
}

// Namespace: Epic.OnlineServices.Lobby
public struct LobbyDetailsMemberInfo // TypeDefIndex: 9235
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <UserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private uint <Platform>k__BackingField; // 0x8
	[CompilerGenerated]
	private bool <AllowsCrossplay>k__BackingField; // 0xC

	// Properties
	public ProductUserId UserId { get; set; }
	public uint Platform { get; set; }
	public bool AllowsCrossplay { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public ProductUserId get_UserId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_UserId(ProductUserId value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3F5510 Offset: 0x3F4710 VA: 0x1803F5510
	public uint get_Platform() { }

	[CompilerGenerated]
	// RVA: 0x3F5520 Offset: 0x3F4720 VA: 0x1803F5520
	public void set_Platform(uint value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x41AC20 Offset: 0x419E20 VA: 0x18041AC20
	public bool get_AllowsCrossplay() { }

	[CompilerGenerated]
	// RVA: 0x41AC50 Offset: 0x419E50 VA: 0x18041AC50
	public void set_AllowsCrossplay(bool value) { }

	// RVA: 0x4C6EF0 Offset: 0x4C60F0 VA: 0x1804C6EF0
	internal void Set(ref LobbyDetailsMemberInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.Lobby
internal struct LobbyDetailsMemberInfoInternal : IGettable<LobbyDetailsMemberInfo>, ISettable<LobbyDetailsMemberInfo>, IDisposable // TypeDefIndex: 9236
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_UserId; // 0x8
	private uint m_Platform; // 0x10
	private int m_AllowsCrossplay; // 0x14

	// Properties
	public ProductUserId UserId { get; set; }
	public uint Platform { get; set; }
	public bool AllowsCrossplay { get; set; }

	// Methods

	// RVA: 0x4C6DB0 Offset: 0x4C5FB0 VA: 0x1804C6DB0
	public ProductUserId get_UserId() { }

	// RVA: 0x4C6E90 Offset: 0x4C6090 VA: 0x1804C6E90
	public void set_UserId(ProductUserId value) { }

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public uint get_Platform() { }

	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_Platform(uint value) { }

	// RVA: 0x4C6D50 Offset: 0x4C5F50 VA: 0x1804C6D50
	public bool get_AllowsCrossplay() { }

	// RVA: 0x4C6E30 Offset: 0x4C6030 VA: 0x1804C6E30
	public void set_AllowsCrossplay(bool value) { }

	// RVA: 0x4C6B70 Offset: 0x4C5D70 VA: 0x1804C6B70 Slot: 5
	public void Set(ref LobbyDetailsMemberInfo other) { }

	// RVA: 0x4C6C30 Offset: 0x4C5E30 VA: 0x1804C6C30 Slot: 6
	public void Set(ref Nullable<LobbyDetailsMemberInfo> other) { }

	// RVA: 0x4C6B00 Offset: 0x4C5D00 VA: 0x1804C6B00 Slot: 7
	public void Dispose() { }

	// RVA: 0x4C6B50 Offset: 0x4C5D50 VA: 0x1804C6B50 Slot: 4
	public void Get(out LobbyDetailsMemberInfo output) { }
}

// Namespace: Epic.OnlineServices.Lobby
public sealed class LobbyInterface : Handle // TypeDefIndex: 9237
{
	// Fields
	public const int AddnotifyjoinlobbyacceptedApiLatest = 1;
	public const int AddnotifyleavelobbyrequestedApiLatest = 1;
	public const int AddnotifylobbyinviteacceptedApiLatest = 1;
	public const int AddnotifylobbyinvitereceivedApiLatest = 1;
	public const int AddnotifylobbyinviterejectedApiLatest = 1;
	public const int AddnotifylobbymemberstatusreceivedApiLatest = 1;
	public const int AddnotifylobbymemberupdatereceivedApiLatest = 1;
	public const int AddnotifylobbyupdatereceivedApiLatest = 1;
	public const int AddnotifyrtcroomconnectionchangedApiLatest = 2;
	public const int AddnotifysendlobbynativeinviterequestedApiLatest = 1;
	public const int AttributeApiLatest = 1;
	public const int AttributedataApiLatest = 1;
	public const int CopylobbydetailshandleApiLatest = 1;
	public const int CopylobbydetailshandlebyinviteidApiLatest = 1;
	public const int CopylobbydetailshandlebyuieventidApiLatest = 1;
	public const int CreatelobbyApiLatest = 9;
	public const int CreatelobbysearchApiLatest = 1;
	public const int DestroylobbyApiLatest = 1;
	public const int GetconnectstringApiLatest = 1;
	public const int GetconnectstringBufferSize = 256;
	public const int GetinvitecountApiLatest = 1;
	public const int GetinviteidbyindexApiLatest = 1;
	public const int GetrtcroomnameApiLatest = 1;
	public const int HardmutememberApiLatest = 1;
	public const int InviteidMaxLength = 64;
	public const int IsrtcroomconnectedApiLatest = 1;
	public const int JoinlobbyApiLatest = 4;
	public const int JoinlobbybyidApiLatest = 2;
	public const int KickmemberApiLatest = 1;
	public const int LeavelobbyApiLatest = 1;
	public const int LocalrtcoptionsApiLatest = 1;
	public const int MaxLobbies = 16;
	public const int MaxLobbyMembers = 64;
	public const int MaxLobbyidoverrideLength = 60;
	public const int MaxSearchResults = 200;
	public const int MinLobbyidoverrideLength = 4;
	public const int ParseconnectstringApiLatest = 1;
	public const int ParseconnectstringBufferSize = 256;
	public const int PromotememberApiLatest = 1;
	public const int QueryinvitesApiLatest = 1;
	public const int RejectinviteApiLatest = 1;
	public static readonly Utf8String SearchBucketId; // 0x0
	public static readonly Utf8String SearchMincurrentmembers; // 0x8
	public static readonly Utf8String SearchMinslotsavailable; // 0x10
	public const int SendinviteApiLatest = 1;
	public const int UpdatelobbyApiLatest = 1;
	public const int UpdatelobbymodificationApiLatest = 1;

	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }

	// RVA: 0x40BDB0 Offset: 0x40AFB0 VA: 0x18040BDB0
	public void .ctor(IntPtr innerHandle) { }

	// RVA: 0x4C7950 Offset: 0x4C6B50 VA: 0x1804C7950
	public ulong AddNotifyJoinLobbyAccepted(ref AddNotifyJoinLobbyAcceptedOptions options, object clientData, OnJoinLobbyAcceptedCallback notificationFn) { }

	// RVA: 0x4C7A90 Offset: 0x4C6C90 VA: 0x1804C7A90
	public ulong AddNotifyLeaveLobbyRequested(ref AddNotifyLeaveLobbyRequestedOptions options, object clientData, OnLeaveLobbyRequestedCallback notificationFn) { }

	// RVA: 0x4C7BD0 Offset: 0x4C6DD0 VA: 0x1804C7BD0
	public ulong AddNotifyLobbyInviteAccepted(ref AddNotifyLobbyInviteAcceptedOptions options, object clientData, OnLobbyInviteAcceptedCallback notificationFn) { }

	// RVA: 0x4C7D10 Offset: 0x4C6F10 VA: 0x1804C7D10
	public ulong AddNotifyLobbyInviteReceived(ref AddNotifyLobbyInviteReceivedOptions options, object clientData, OnLobbyInviteReceivedCallback notificationFn) { }

	// RVA: 0x4C7E50 Offset: 0x4C7050 VA: 0x1804C7E50
	public ulong AddNotifyLobbyInviteRejected(ref AddNotifyLobbyInviteRejectedOptions options, object clientData, OnLobbyInviteRejectedCallback notificationFn) { }

	// RVA: 0x4C7F90 Offset: 0x4C7190 VA: 0x1804C7F90
	public ulong AddNotifyLobbyMemberStatusReceived(ref AddNotifyLobbyMemberStatusReceivedOptions options, object clientData, OnLobbyMemberStatusReceivedCallback notificationFn) { }

	// RVA: 0x4C80D0 Offset: 0x4C72D0 VA: 0x1804C80D0
	public ulong AddNotifyLobbyMemberUpdateReceived(ref AddNotifyLobbyMemberUpdateReceivedOptions options, object clientData, OnLobbyMemberUpdateReceivedCallback notificationFn) { }

	// RVA: 0x4C8210 Offset: 0x4C7410 VA: 0x1804C8210
	public ulong AddNotifyLobbyUpdateReceived(ref AddNotifyLobbyUpdateReceivedOptions options, object clientData, OnLobbyUpdateReceivedCallback notificationFn) { }

	// RVA: 0x4C8350 Offset: 0x4C7550 VA: 0x1804C8350
	public ulong AddNotifyRTCRoomConnectionChanged(ref AddNotifyRTCRoomConnectionChangedOptions options, object clientData, OnRTCRoomConnectionChangedCallback notificationFn) { }

	// RVA: 0x4C84B0 Offset: 0x4C76B0 VA: 0x1804C84B0
	public ulong AddNotifySendLobbyNativeInviteRequested(ref AddNotifySendLobbyNativeInviteRequestedOptions options, object clientData, OnSendLobbyNativeInviteRequestedCallback notificationFn) { }

	// RVA: 0x4C87D0 Offset: 0x4C79D0 VA: 0x1804C87D0
	public Result CopyLobbyDetailsHandle(ref CopyLobbyDetailsHandleOptions options, out LobbyDetails outLobbyDetailsHandle) { }

	// RVA: 0x4C85F0 Offset: 0x4C77F0 VA: 0x1804C85F0
	public Result CopyLobbyDetailsHandleByInviteId(ref CopyLobbyDetailsHandleByInviteIdOptions options, out LobbyDetails outLobbyDetailsHandle) { }

	// RVA: 0x4C8700 Offset: 0x4C7900 VA: 0x1804C8700
	public Result CopyLobbyDetailsHandleByUiEventId(ref CopyLobbyDetailsHandleByUiEventIdOptions options, out LobbyDetails outLobbyDetailsHandle) { }

	// RVA: 0x4C8980 Offset: 0x4C7B80 VA: 0x1804C8980
	public void CreateLobby(ref CreateLobbyOptions options, object clientData, OnCreateLobbyCallback completionDelegate) { }

	// RVA: 0x4C88B0 Offset: 0x4C7AB0 VA: 0x1804C88B0
	public Result CreateLobbySearch(ref CreateLobbySearchOptions options, out LobbySearch outLobbySearchHandle) { }

	// RVA: 0x4C8AF0 Offset: 0x4C7CF0 VA: 0x1804C8AF0
	public void DestroyLobby(ref DestroyLobbyOptions options, object clientData, OnDestroyLobbyCallback completionDelegate) { }

	// RVA: 0x4C8C30 Offset: 0x4C7E30 VA: 0x1804C8C30
	public Result GetConnectString(ref GetConnectStringOptions options, out Utf8String outBuffer) { }

	// RVA: 0x4C8D20 Offset: 0x4C7F20 VA: 0x1804C8D20
	public uint GetInviteCount(ref GetInviteCountOptions options) { }

	// RVA: 0x4C8E00 Offset: 0x4C8000 VA: 0x1804C8E00
	public Result GetInviteIdByIndex(ref GetInviteIdByIndexOptions options, out Utf8String outBuffer) { }

	// RVA: 0x4C8F30 Offset: 0x4C8130 VA: 0x1804C8F30
	public Result GetRTCRoomName(ref GetRTCRoomNameOptions options, out Utf8String outBuffer) { }

	// RVA: 0x4C9020 Offset: 0x4C8220 VA: 0x1804C9020
	public void HardMuteMember(ref HardMuteMemberOptions options, object clientData, OnHardMuteMemberCallback completionDelegate) { }

	// RVA: 0x4C9170 Offset: 0x4C8370 VA: 0x1804C9170
	public Result IsRTCRoomConnected(ref IsRTCRoomConnectedOptions options, out bool bOutIsConnected) { }

	// RVA: 0x4C9390 Offset: 0x4C8590 VA: 0x1804C9390
	public void JoinLobby(ref JoinLobbyOptions options, object clientData, OnJoinLobbyCallback completionDelegate) { }

	// RVA: 0x4C9240 Offset: 0x4C8440 VA: 0x1804C9240
	public void JoinLobbyById(ref JoinLobbyByIdOptions options, object clientData, OnJoinLobbyByIdCallback completionDelegate) { }

	// RVA: 0x4C94E0 Offset: 0x4C86E0 VA: 0x1804C94E0
	public void KickMember(ref KickMemberOptions options, object clientData, OnKickMemberCallback completionDelegate) { }

	// RVA: 0x4C9620 Offset: 0x4C8820 VA: 0x1804C9620
	public void LeaveLobby(ref LeaveLobbyOptions options, object clientData, OnLeaveLobbyCallback completionDelegate) { }

	// RVA: 0x4CA670 Offset: 0x4C9870 VA: 0x1804CA670
	public Result ParseConnectString(ref ParseConnectStringOptions options, out Utf8String outBuffer) { }

	// RVA: 0x4CA760 Offset: 0x4C9960 VA: 0x1804CA760
	public void PromoteMember(ref PromoteMemberOptions options, object clientData, OnPromoteMemberCallback completionDelegate) { }

	// RVA: 0x4CA8A0 Offset: 0x4C9AA0 VA: 0x1804CA8A0
	public void QueryInvites(ref QueryInvitesOptions options, object clientData, OnQueryInvitesCallback completionDelegate) { }

	// RVA: 0x4CA9E0 Offset: 0x4C9BE0 VA: 0x1804CA9E0
	public void RejectInvite(ref RejectInviteOptions options, object clientData, OnRejectInviteCallback completionDelegate) { }

	// RVA: 0x4CAB20 Offset: 0x4C9D20 VA: 0x1804CAB20
	public void RemoveNotifyJoinLobbyAccepted(ulong inId) { }

	// RVA: 0x4CAB90 Offset: 0x4C9D90 VA: 0x1804CAB90
	public void RemoveNotifyLeaveLobbyRequested(ulong inId) { }

	// RVA: 0x4CAC00 Offset: 0x4C9E00 VA: 0x1804CAC00
	public void RemoveNotifyLobbyInviteAccepted(ulong inId) { }

	// RVA: 0x4CAC70 Offset: 0x4C9E70 VA: 0x1804CAC70
	public void RemoveNotifyLobbyInviteReceived(ulong inId) { }

	// RVA: 0x4CACE0 Offset: 0x4C9EE0 VA: 0x1804CACE0
	public void RemoveNotifyLobbyInviteRejected(ulong inId) { }

	// RVA: 0x4CAD50 Offset: 0x4C9F50 VA: 0x1804CAD50
	public void RemoveNotifyLobbyMemberStatusReceived(ulong inId) { }

	// RVA: 0x4CADC0 Offset: 0x4C9FC0 VA: 0x1804CADC0
	public void RemoveNotifyLobbyMemberUpdateReceived(ulong inId) { }

	// RVA: 0x4CAE30 Offset: 0x4CA030 VA: 0x1804CAE30
	public void RemoveNotifyLobbyUpdateReceived(ulong inId) { }

	// RVA: 0x4CAEA0 Offset: 0x4CA0A0 VA: 0x1804CAEA0
	public void RemoveNotifyRTCRoomConnectionChanged(ulong inId) { }

	// RVA: 0x4CAF10 Offset: 0x4CA110 VA: 0x1804CAF10
	public void RemoveNotifySendLobbyNativeInviteRequested(ulong inId) { }

	// RVA: 0x4CAF80 Offset: 0x4CA180 VA: 0x1804CAF80
	public void SendInvite(ref SendInviteOptions options, object clientData, OnSendInviteCallback completionDelegate) { }

	// RVA: 0x4CB1A0 Offset: 0x4CA3A0 VA: 0x1804CB1A0
	public void UpdateLobby(ref UpdateLobbyOptions options, object clientData, OnUpdateLobbyCallback completionDelegate) { }

	// RVA: 0x4CB0C0 Offset: 0x4CA2C0 VA: 0x1804CB0C0
	public Result UpdateLobbyModification(ref UpdateLobbyModificationOptions options, out LobbyModification outLobbyModificationHandle) { }

	[MonoPInvokeCallback(typeof(OnCreateLobbyCallbackInternal))]
	// RVA: 0x4C9760 Offset: 0x4C8960 VA: 0x1804C9760
	internal static void OnCreateLobbyCallbackInternalImplementation(ref CreateLobbyCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnDestroyLobbyCallbackInternal))]
	// RVA: 0x4C9810 Offset: 0x4C8A10 VA: 0x1804C9810
	internal static void OnDestroyLobbyCallbackInternalImplementation(ref DestroyLobbyCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnHardMuteMemberCallbackInternal))]
	// RVA: 0x4C98C0 Offset: 0x4C8AC0 VA: 0x1804C98C0
	internal static void OnHardMuteMemberCallbackInternalImplementation(ref HardMuteMemberCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnJoinLobbyAcceptedCallbackInternal))]
	// RVA: 0x4C9970 Offset: 0x4C8B70 VA: 0x1804C9970
	internal static void OnJoinLobbyAcceptedCallbackInternalImplementation(ref JoinLobbyAcceptedCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnJoinLobbyByIdCallbackInternal))]
	// RVA: 0x4C9A20 Offset: 0x4C8C20 VA: 0x1804C9A20
	internal static void OnJoinLobbyByIdCallbackInternalImplementation(ref JoinLobbyByIdCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnJoinLobbyCallbackInternal))]
	// RVA: 0x4C9AD0 Offset: 0x4C8CD0 VA: 0x1804C9AD0
	internal static void OnJoinLobbyCallbackInternalImplementation(ref JoinLobbyCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnKickMemberCallbackInternal))]
	// RVA: 0x4C9B80 Offset: 0x4C8D80 VA: 0x1804C9B80
	internal static void OnKickMemberCallbackInternalImplementation(ref KickMemberCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnLeaveLobbyCallbackInternal))]
	// RVA: 0x4C9C30 Offset: 0x4C8E30 VA: 0x1804C9C30
	internal static void OnLeaveLobbyCallbackInternalImplementation(ref LeaveLobbyCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnLeaveLobbyRequestedCallbackInternal))]
	// RVA: 0x4C9CE0 Offset: 0x4C8EE0 VA: 0x1804C9CE0
	internal static void OnLeaveLobbyRequestedCallbackInternalImplementation(ref LeaveLobbyRequestedCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnLobbyInviteAcceptedCallbackInternal))]
	// RVA: 0x4C9D90 Offset: 0x4C8F90 VA: 0x1804C9D90
	internal static void OnLobbyInviteAcceptedCallbackInternalImplementation(ref LobbyInviteAcceptedCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnLobbyInviteReceivedCallbackInternal))]
	// RVA: 0x4C9E40 Offset: 0x4C9040 VA: 0x1804C9E40
	internal static void OnLobbyInviteReceivedCallbackInternalImplementation(ref LobbyInviteReceivedCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnLobbyInviteRejectedCallbackInternal))]
	// RVA: 0x4C9EF0 Offset: 0x4C90F0 VA: 0x1804C9EF0
	internal static void OnLobbyInviteRejectedCallbackInternalImplementation(ref LobbyInviteRejectedCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnLobbyMemberStatusReceivedCallbackInternal))]
	// RVA: 0x4C9FA0 Offset: 0x4C91A0 VA: 0x1804C9FA0
	internal static void OnLobbyMemberStatusReceivedCallbackInternalImplementation(ref LobbyMemberStatusReceivedCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnLobbyMemberUpdateReceivedCallbackInternal))]
	// RVA: 0x4CA050 Offset: 0x4C9250 VA: 0x1804CA050
	internal static void OnLobbyMemberUpdateReceivedCallbackInternalImplementation(ref LobbyMemberUpdateReceivedCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnLobbyUpdateReceivedCallbackInternal))]
	// RVA: 0x4CA100 Offset: 0x4C9300 VA: 0x1804CA100
	internal static void OnLobbyUpdateReceivedCallbackInternalImplementation(ref LobbyUpdateReceivedCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnPromoteMemberCallbackInternal))]
	// RVA: 0x4CA1A0 Offset: 0x4C93A0 VA: 0x1804CA1A0
	internal static void OnPromoteMemberCallbackInternalImplementation(ref PromoteMemberCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnQueryInvitesCallbackInternal))]
	// RVA: 0x4CA250 Offset: 0x4C9450 VA: 0x1804CA250
	internal static void OnQueryInvitesCallbackInternalImplementation(ref QueryInvitesCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnRTCRoomConnectionChangedCallbackInternal))]
	// RVA: 0x4CA300 Offset: 0x4C9500 VA: 0x1804CA300
	internal static void OnRTCRoomConnectionChangedCallbackInternalImplementation(ref RTCRoomConnectionChangedCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnRejectInviteCallbackInternal))]
	// RVA: 0x4CA3B0 Offset: 0x4C95B0 VA: 0x1804CA3B0
	internal static void OnRejectInviteCallbackInternalImplementation(ref RejectInviteCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnSendInviteCallbackInternal))]
	// RVA: 0x4CA460 Offset: 0x4C9660 VA: 0x1804CA460
	internal static void OnSendInviteCallbackInternalImplementation(ref SendInviteCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnSendLobbyNativeInviteRequestedCallbackInternal))]
	// RVA: 0x4CA510 Offset: 0x4C9710 VA: 0x1804CA510
	internal static void OnSendLobbyNativeInviteRequestedCallbackInternalImplementation(ref SendLobbyNativeInviteRequestedCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnUpdateLobbyCallbackInternal))]
	// RVA: 0x4CA5C0 Offset: 0x4C97C0 VA: 0x1804CA5C0
	internal static void OnUpdateLobbyCallbackInternalImplementation(ref UpdateLobbyCallbackInfoInternal data) { }

	// RVA: 0x4CB2E0 Offset: 0x4CA4E0 VA: 0x1804CB2E0
	private static void .cctor() { }
}

// Namespace: Epic.OnlineServices.Lobby
public struct LobbyInviteAcceptedCallbackInfo : ICallbackInfo // TypeDefIndex: 9238
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
	private Utf8String <LobbyId>k__BackingField; // 0x20

	// Properties
	public object ClientData { get; set; }
	public Utf8String InviteId { get; set; }
	public ProductUserId LocalUserId { get; set; }
	public ProductUserId TargetUserId { get; set; }
	public Utf8String LobbyId { get; set; }

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

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public ProductUserId get_TargetUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_TargetUserId(ProductUserId value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public Utf8String get_LobbyId() { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_LobbyId(Utf8String value) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x4CBC10 Offset: 0x4CAE10 VA: 0x1804CBC10
	internal void Set(ref LobbyInviteAcceptedCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.Lobby
internal struct LobbyInviteAcceptedCallbackInfoInternal : ICallbackInfoInternal, IGettable<LobbyInviteAcceptedCallbackInfo>, ISettable<LobbyInviteAcceptedCallbackInfo>, IDisposable // TypeDefIndex: 9239
{
	// Fields
	private IntPtr m_ClientData; // 0x0
	private IntPtr m_InviteId; // 0x8
	private IntPtr m_LocalUserId; // 0x10
	private IntPtr m_TargetUserId; // 0x18
	private IntPtr m_LobbyId; // 0x20

	// Properties
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public Utf8String InviteId { get; set; }
	public ProductUserId LocalUserId { get; set; }
	public ProductUserId TargetUserId { get; set; }
	public Utf8String LobbyId { get; set; }

	// Methods

	// RVA: 0x4CB7E0 Offset: 0x4CA9E0 VA: 0x1804CB7E0
	public object get_ClientData() { }

	// RVA: 0x4CBA30 Offset: 0x4CAC30 VA: 0x1804CBA30
	public void set_ClientData(object value) { }

	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x4CB850 Offset: 0x4CAA50 VA: 0x1804CB850
	public Utf8String get_InviteId() { }

	// RVA: 0x4CBA90 Offset: 0x4CAC90 VA: 0x1804CBA90
	public void set_InviteId(Utf8String value) { }

	// RVA: 0x4CB930 Offset: 0x4CAB30 VA: 0x1804CB930
	public ProductUserId get_LocalUserId() { }

	// RVA: 0x4CBB50 Offset: 0x4CAD50 VA: 0x1804CBB50
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x4CB9B0 Offset: 0x4CABB0 VA: 0x1804CB9B0
	public ProductUserId get_TargetUserId() { }

	// RVA: 0x4CBBB0 Offset: 0x4CADB0 VA: 0x1804CBBB0
	public void set_TargetUserId(ProductUserId value) { }

	// RVA: 0x4CB8C0 Offset: 0x4CAAC0 VA: 0x1804CB8C0
	public Utf8String get_LobbyId() { }

	// RVA: 0x4CBAF0 Offset: 0x4CACF0 VA: 0x1804CBAF0
	public void set_LobbyId(Utf8String value) { }

	// RVA: 0x4CB660 Offset: 0x4CA860 VA: 0x1804CB660 Slot: 6
	public void Set(ref LobbyInviteAcceptedCallbackInfo other) { }

	// RVA: 0x4CB460 Offset: 0x4CA660 VA: 0x1804CB460 Slot: 7
	public void Set(ref Nullable<LobbyInviteAcceptedCallbackInfo> other) { }

	// RVA: 0x4CB3B0 Offset: 0x4CA5B0 VA: 0x1804CB3B0 Slot: 8
	public void Dispose() { }

	// RVA: 0x4CB430 Offset: 0x4CA630 VA: 0x1804CB430 Slot: 5
	public void Get(out LobbyInviteAcceptedCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.Lobby
public struct LobbyInviteReceivedCallbackInfo : ICallbackInfo // TypeDefIndex: 9240
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

	// Properties
	public object ClientData { get; set; }
	public Utf8String InviteId { get; set; }
	public ProductUserId LocalUserId { get; set; }
	public ProductUserId TargetUserId { get; set; }

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
	public Utf8String get_InviteId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_InviteId(Utf8String value) { }

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
	public ProductUserId get_TargetUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_TargetUserId(ProductUserId value) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x4DB900 Offset: 0x4DAB00 VA: 0x1804DB900
	internal void Set(ref LobbyInviteReceivedCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.Lobby
internal struct LobbyInviteReceivedCallbackInfoInternal : ICallbackInfoInternal, IGettable<LobbyInviteReceivedCallbackInfo>, ISettable<LobbyInviteReceivedCallbackInfo>, IDisposable // TypeDefIndex: 9241
{
	// Fields
	private IntPtr m_ClientData; // 0x0
	private IntPtr m_InviteId; // 0x8
	private IntPtr m_LocalUserId; // 0x10
	private IntPtr m_TargetUserId; // 0x18

	// Properties
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public Utf8String InviteId { get; set; }
	public ProductUserId LocalUserId { get; set; }
	public ProductUserId TargetUserId { get; set; }

	// Methods

	// RVA: 0x4DB5A0 Offset: 0x4DA7A0 VA: 0x1804DB5A0
	public object get_ClientData() { }

	// RVA: 0x4DB780 Offset: 0x4DA980 VA: 0x1804DB780
	public void set_ClientData(object value) { }

	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x4DB610 Offset: 0x4DA810 VA: 0x1804DB610
	public Utf8String get_InviteId() { }

	// RVA: 0x4DB7E0 Offset: 0x4DA9E0 VA: 0x1804DB7E0
	public void set_InviteId(Utf8String value) { }

	// RVA: 0x4DB680 Offset: 0x4DA880 VA: 0x1804DB680
	public ProductUserId get_LocalUserId() { }

	// RVA: 0x4DB840 Offset: 0x4DAA40 VA: 0x1804DB840
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x4DB700 Offset: 0x4DA900 VA: 0x1804DB700
	public ProductUserId get_TargetUserId() { }

	// RVA: 0x4DB8A0 Offset: 0x4DAAA0 VA: 0x1804DB8A0
	public void set_TargetUserId(ProductUserId value) { }

	// RVA: 0x4DB460 Offset: 0x4DA660 VA: 0x1804DB460 Slot: 6
	public void Set(ref LobbyInviteReceivedCallbackInfo other) { }

	// RVA: 0x4DB2B0 Offset: 0x4DA4B0 VA: 0x1804DB2B0 Slot: 7
	public void Set(ref Nullable<LobbyInviteReceivedCallbackInfo> other) { }

	// RVA: 0x4DB220 Offset: 0x4DA420 VA: 0x1804DB220 Slot: 8
	public void Dispose() { }

	// RVA: 0x4DB290 Offset: 0x4DA490 VA: 0x1804DB290 Slot: 5
	public void Get(out LobbyInviteReceivedCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.Lobby
public struct LobbyInviteRejectedCallbackInfo : ICallbackInfo // TypeDefIndex: 9242
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
	private Utf8String <LobbyId>k__BackingField; // 0x20

	// Properties
	public object ClientData { get; set; }
	public Utf8String InviteId { get; set; }
	public ProductUserId LocalUserId { get; set; }
	public ProductUserId TargetUserId { get; set; }
	public Utf8String LobbyId { get; set; }

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

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public Utf8String get_LobbyId() { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_LobbyId(Utf8String value) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x4DC250 Offset: 0x4DB450 VA: 0x1804DC250
	internal void Set(ref LobbyInviteRejectedCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.Lobby
internal struct LobbyInviteRejectedCallbackInfoInternal : ICallbackInfoInternal, IGettable<LobbyInviteRejectedCallbackInfo>, ISettable<LobbyInviteRejectedCallbackInfo>, IDisposable // TypeDefIndex: 9243
{
	// Fields
	private IntPtr m_ClientData; // 0x0
	private IntPtr m_InviteId; // 0x8
	private IntPtr m_LocalUserId; // 0x10
	private IntPtr m_TargetUserId; // 0x18
	private IntPtr m_LobbyId; // 0x20

	// Properties
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public Utf8String InviteId { get; set; }
	public ProductUserId LocalUserId { get; set; }
	public ProductUserId TargetUserId { get; set; }
	public Utf8String LobbyId { get; set; }

	// Methods

	// RVA: 0x4DBE20 Offset: 0x4DB020 VA: 0x1804DBE20
	public object get_ClientData() { }

	// RVA: 0x4DC070 Offset: 0x4DB270 VA: 0x1804DC070
	public void set_ClientData(object value) { }

	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x4DBE90 Offset: 0x4DB090 VA: 0x1804DBE90
	public Utf8String get_InviteId() { }

	// RVA: 0x4DC0D0 Offset: 0x4DB2D0 VA: 0x1804DC0D0
	public void set_InviteId(Utf8String value) { }

	// RVA: 0x4DBF70 Offset: 0x4DB170 VA: 0x1804DBF70
	public ProductUserId get_LocalUserId() { }

	// RVA: 0x4DC190 Offset: 0x4DB390 VA: 0x1804DC190
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x4DBFF0 Offset: 0x4DB1F0 VA: 0x1804DBFF0
	public ProductUserId get_TargetUserId() { }

	// RVA: 0x4DC1F0 Offset: 0x4DB3F0 VA: 0x1804DC1F0
	public void set_TargetUserId(ProductUserId value) { }

	// RVA: 0x4DBF00 Offset: 0x4DB100 VA: 0x1804DBF00
	public Utf8String get_LobbyId() { }

	// RVA: 0x4DC130 Offset: 0x4DB330 VA: 0x1804DC130
	public void set_LobbyId(Utf8String value) { }

	// RVA: 0x4DBCA0 Offset: 0x4DAEA0 VA: 0x1804DBCA0 Slot: 6
	public void Set(ref LobbyInviteRejectedCallbackInfo other) { }

	// RVA: 0x4DBAA0 Offset: 0x4DACA0 VA: 0x1804DBAA0 Slot: 7
	public void Set(ref Nullable<LobbyInviteRejectedCallbackInfo> other) { }

	// RVA: 0x4DB9F0 Offset: 0x4DABF0 VA: 0x1804DB9F0 Slot: 8
	public void Dispose() { }

	// RVA: 0x4DBA70 Offset: 0x4DAC70 VA: 0x1804DBA70 Slot: 5
	public void Get(out LobbyInviteRejectedCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.Lobby
public enum LobbyMemberStatus // TypeDefIndex: 9244
{
	// Fields
	public int value__; // 0x0
	public const LobbyMemberStatus Joined = 0;
	public const LobbyMemberStatus Left = 1;
	public const LobbyMemberStatus Disconnected = 2;
	public const LobbyMemberStatus Kicked = 3;
	public const LobbyMemberStatus Promoted = 4;
	public const LobbyMemberStatus Closed = 5;
}

// Namespace: Epic.OnlineServices.Lobby
public struct LobbyMemberStatusReceivedCallbackInfo : ICallbackInfo // TypeDefIndex: 9245
{
	// Fields
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <LobbyId>k__BackingField; // 0x8
	[CompilerGenerated]
	private ProductUserId <TargetUserId>k__BackingField; // 0x10
	[CompilerGenerated]
	private LobbyMemberStatus <CurrentStatus>k__BackingField; // 0x18

	// Properties
	public object ClientData { get; set; }
	public Utf8String LobbyId { get; set; }
	public ProductUserId TargetUserId { get; set; }
	public LobbyMemberStatus CurrentStatus { get; set; }

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
	public Utf8String get_LobbyId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_LobbyId(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public ProductUserId get_TargetUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_TargetUserId(ProductUserId value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public LobbyMemberStatus get_CurrentStatus() { }

	[CompilerGenerated]
	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	public void set_CurrentStatus(LobbyMemberStatus value) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x4DC910 Offset: 0x4DBB10 VA: 0x1804DC910
	internal void Set(ref LobbyMemberStatusReceivedCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.Lobby
internal struct LobbyMemberStatusReceivedCallbackInfoInternal : ICallbackInfoInternal, IGettable<LobbyMemberStatusReceivedCallbackInfo>, ISettable<LobbyMemberStatusReceivedCallbackInfo>, IDisposable // TypeDefIndex: 9246
{
	// Fields
	private IntPtr m_ClientData; // 0x0
	private IntPtr m_LobbyId; // 0x8
	private IntPtr m_TargetUserId; // 0x10
	private LobbyMemberStatus m_CurrentStatus; // 0x18

	// Properties
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public Utf8String LobbyId { get; set; }
	public ProductUserId TargetUserId { get; set; }
	public LobbyMemberStatus CurrentStatus { get; set; }

	// Methods

	// RVA: 0x4DC690 Offset: 0x4DB890 VA: 0x1804DC690
	public object get_ClientData() { }

	// RVA: 0x4DC7F0 Offset: 0x4DB9F0 VA: 0x1804DC7F0
	public void set_ClientData(object value) { }

	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x4DC700 Offset: 0x4DB900 VA: 0x1804DC700
	public Utf8String get_LobbyId() { }

	// RVA: 0x4DC850 Offset: 0x4DBA50 VA: 0x1804DC850
	public void set_LobbyId(Utf8String value) { }

	// RVA: 0x4DC770 Offset: 0x4DB970 VA: 0x1804DC770
	public ProductUserId get_TargetUserId() { }

	// RVA: 0x4DC8B0 Offset: 0x4DBAB0 VA: 0x1804DC8B0
	public void set_TargetUserId(ProductUserId value) { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public LobbyMemberStatus get_CurrentStatus() { }

	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	public void set_CurrentStatus(LobbyMemberStatus value) { }

	// RVA: 0x4DC590 Offset: 0x4DB790 VA: 0x1804DC590 Slot: 6
	public void Set(ref LobbyMemberStatusReceivedCallbackInfo other) { }

	// RVA: 0x4DC420 Offset: 0x4DB620 VA: 0x1804DC420 Slot: 7
	public void Set(ref Nullable<LobbyMemberStatusReceivedCallbackInfo> other) { }

	// RVA: 0x4DC3A0 Offset: 0x4DB5A0 VA: 0x1804DC3A0 Slot: 8
	public void Dispose() { }

	// RVA: 0x4DC400 Offset: 0x4DB600 VA: 0x1804DC400 Slot: 5
	public void Get(out LobbyMemberStatusReceivedCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.Lobby
public struct LobbyMemberUpdateReceivedCallbackInfo : ICallbackInfo // TypeDefIndex: 9247
{
	// Fields
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <LobbyId>k__BackingField; // 0x8
	[CompilerGenerated]
	private ProductUserId <TargetUserId>k__BackingField; // 0x10

	// Properties
	public object ClientData { get; set; }
	public Utf8String LobbyId { get; set; }
	public ProductUserId TargetUserId { get; set; }

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
	public Utf8String get_LobbyId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_LobbyId(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public ProductUserId get_TargetUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_TargetUserId(ProductUserId value) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x4DCF40 Offset: 0x4DC140 VA: 0x1804DCF40
	internal void Set(ref LobbyMemberUpdateReceivedCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.Lobby
internal struct LobbyMemberUpdateReceivedCallbackInfoInternal : ICallbackInfoInternal, IGettable<LobbyMemberUpdateReceivedCallbackInfo>, ISettable<LobbyMemberUpdateReceivedCallbackInfo>, IDisposable // TypeDefIndex: 9248
{
	// Fields
	private IntPtr m_ClientData; // 0x0
	private IntPtr m_LobbyId; // 0x8
	private IntPtr m_TargetUserId; // 0x10

	// Properties
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public Utf8String LobbyId { get; set; }
	public ProductUserId TargetUserId { get; set; }

	// Methods

	// RVA: 0x4DCCC0 Offset: 0x4DBEC0 VA: 0x1804DCCC0
	public object get_ClientData() { }

	// RVA: 0x4DCE20 Offset: 0x4DC020 VA: 0x1804DCE20
	public void set_ClientData(object value) { }

	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x4DCD30 Offset: 0x4DBF30 VA: 0x1804DCD30
	public Utf8String get_LobbyId() { }

	// RVA: 0x4DCE80 Offset: 0x4DC080 VA: 0x1804DCE80
	public void set_LobbyId(Utf8String value) { }

	// RVA: 0x4DCDA0 Offset: 0x4DBFA0 VA: 0x1804DCDA0
	public ProductUserId get_TargetUserId() { }

	// RVA: 0x4DCEE0 Offset: 0x4DC0E0 VA: 0x1804DCEE0
	public void set_TargetUserId(ProductUserId value) { }

	// RVA: 0x4DCBD0 Offset: 0x4DBDD0 VA: 0x1804DCBD0 Slot: 6
	public void Set(ref LobbyMemberUpdateReceivedCallbackInfo other) { }

	// RVA: 0x4DCA80 Offset: 0x4DBC80 VA: 0x1804DCA80 Slot: 7
	public void Set(ref Nullable<LobbyMemberUpdateReceivedCallbackInfo> other) { }

	// RVA: 0x4DCA00 Offset: 0x4DBC00 VA: 0x1804DCA00 Slot: 8
	public void Dispose() { }

	// RVA: 0x4DCA60 Offset: 0x4DBC60 VA: 0x1804DCA60 Slot: 5
	public void Get(out LobbyMemberUpdateReceivedCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.Lobby
public sealed class LobbyModification : Handle // TypeDefIndex: 9249
{
	// Fields
	public const int LobbymodificationAddattributeApiLatest = 2;
	public const int LobbymodificationAddmemberattributeApiLatest = 2;
	public const int LobbymodificationMaxAttributeLength = 64;
	public const int LobbymodificationMaxAttributes = 64;
	public const int LobbymodificationRemoveattributeApiLatest = 1;
	public const int LobbymodificationRemovememberattributeApiLatest = 1;
	public const int LobbymodificationSetallowedplatformidsApiLatest = 1;
	public const int LobbymodificationSetbucketidApiLatest = 1;
	public const int LobbymodificationSetinvitesallowedApiLatest = 1;
	public const int LobbymodificationSetmaxmembersApiLatest = 1;
	public const int LobbymodificationSetpermissionlevelApiLatest = 1;

	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }

	// RVA: 0x40BDB0 Offset: 0x40AFB0 VA: 0x18040BDB0
	public void .ctor(IntPtr innerHandle) { }

	// RVA: 0x4DDE30 Offset: 0x4DD030 VA: 0x1804DDE30
	public Result AddAttribute(ref LobbyModificationAddAttributeOptions options) { }

	// RVA: 0x4DDF60 Offset: 0x4DD160 VA: 0x1804DDF60
	public Result AddMemberAttribute(ref LobbyModificationAddMemberAttributeOptions options) { }

	// RVA: 0x4DE090 Offset: 0x4DD290 VA: 0x1804DE090
	public void Release() { }

	// RVA: 0x4DE0A0 Offset: 0x4DD2A0 VA: 0x1804DE0A0
	public Result RemoveAttribute(ref LobbyModificationRemoveAttributeOptions options) { }

	// RVA: 0x4DE180 Offset: 0x4DD380 VA: 0x1804DE180
	public Result RemoveMemberAttribute(ref LobbyModificationRemoveMemberAttributeOptions options) { }

	// RVA: 0x4DE260 Offset: 0x4DD460 VA: 0x1804DE260
	public Result SetAllowedPlatformIds(ref LobbyModificationSetAllowedPlatformIdsOptions options) { }

	// RVA: 0x4DE350 Offset: 0x4DD550 VA: 0x1804DE350
	public Result SetBucketId(ref LobbyModificationSetBucketIdOptions options) { }

	// RVA: 0x4DE430 Offset: 0x4DD630 VA: 0x1804DE430
	public Result SetInvitesAllowed(ref LobbyModificationSetInvitesAllowedOptions options) { }

	// RVA: 0x4DE510 Offset: 0x4DD710 VA: 0x1804DE510
	public Result SetMaxMembers(ref LobbyModificationSetMaxMembersOptions options) { }

	// RVA: 0x4DE5A0 Offset: 0x4DD7A0 VA: 0x1804DE5A0
	public Result SetPermissionLevel(ref LobbyModificationSetPermissionLevelOptions options) { }
}

// Namespace: Epic.OnlineServices.Lobby
public struct LobbyModificationAddAttributeOptions // TypeDefIndex: 9250
{
	// Fields
	[CompilerGenerated]
	private Nullable<AttributeData> <Attribute>k__BackingField; // 0x0
	[CompilerGenerated]
	private LobbyAttributeVisibility <Visibility>k__BackingField; // 0x48

	// Properties
	public Nullable<AttributeData> Attribute { get; set; }
	public LobbyAttributeVisibility Visibility { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x4193E0 Offset: 0x4185E0 VA: 0x1804193E0
	public Nullable<AttributeData> get_Attribute() { }

	[CompilerGenerated]
	// RVA: 0x419420 Offset: 0x418620 VA: 0x180419420
	public void set_Attribute(Nullable<AttributeData> value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x4193D0 Offset: 0x4185D0 VA: 0x1804193D0
	public LobbyAttributeVisibility get_Visibility() { }

	[CompilerGenerated]
	// RVA: 0x419410 Offset: 0x418610 VA: 0x180419410
	public void set_Visibility(LobbyAttributeVisibility value) { }
}

// Namespace: Epic.OnlineServices.Lobby
internal struct LobbyModificationAddAttributeOptionsInternal : ISettable<LobbyModificationAddAttributeOptions>, IDisposable // TypeDefIndex: 9251
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_Attribute; // 0x8
	private LobbyAttributeVisibility m_Visibility; // 0x10

	// Properties
	public Nullable<AttributeData> Attribute { set; }
	public LobbyAttributeVisibility Visibility { set; }

	// Methods

	// RVA: 0x4DD240 Offset: 0x4DC440 VA: 0x1804DD240
	public void set_Attribute(Nullable<AttributeData> value) { }

	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_Visibility(LobbyAttributeVisibility value) { }

	// RVA: 0x4DD190 Offset: 0x4DC390 VA: 0x1804DD190 Slot: 4
	public void Set(ref LobbyModificationAddAttributeOptions other) { }

	// RVA: 0x4DD070 Offset: 0x4DC270 VA: 0x1804DD070 Slot: 5
	public void Set(ref Nullable<LobbyModificationAddAttributeOptions> other) { }

	// RVA: 0x4DD020 Offset: 0x4DC220 VA: 0x1804DD020 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Lobby
public struct LobbyModificationAddMemberAttributeOptions // TypeDefIndex: 9252
{
	// Fields
	[CompilerGenerated]
	private Nullable<AttributeData> <Attribute>k__BackingField; // 0x0
	[CompilerGenerated]
	private LobbyAttributeVisibility <Visibility>k__BackingField; // 0x48

	// Properties
	public Nullable<AttributeData> Attribute { get; set; }
	public LobbyAttributeVisibility Visibility { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x4193E0 Offset: 0x4185E0 VA: 0x1804193E0
	public Nullable<AttributeData> get_Attribute() { }

	[CompilerGenerated]
	// RVA: 0x419420 Offset: 0x418620 VA: 0x180419420
	public void set_Attribute(Nullable<AttributeData> value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x4193D0 Offset: 0x4185D0 VA: 0x1804193D0
	public LobbyAttributeVisibility get_Visibility() { }

	[CompilerGenerated]
	// RVA: 0x419410 Offset: 0x418610 VA: 0x180419410
	public void set_Visibility(LobbyAttributeVisibility value) { }
}

// Namespace: Epic.OnlineServices.Lobby
internal struct LobbyModificationAddMemberAttributeOptionsInternal : ISettable<LobbyModificationAddMemberAttributeOptions>, IDisposable // TypeDefIndex: 9253
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_Attribute; // 0x8
	private LobbyAttributeVisibility m_Visibility; // 0x10

	// Properties
	public Nullable<AttributeData> Attribute { set; }
	public LobbyAttributeVisibility Visibility { set; }

	// Methods

	// RVA: 0x4DD4D0 Offset: 0x4DC6D0 VA: 0x1804DD4D0
	public void set_Attribute(Nullable<AttributeData> value) { }

	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_Visibility(LobbyAttributeVisibility value) { }

	// RVA: 0x4DD420 Offset: 0x4DC620 VA: 0x1804DD420 Slot: 4
	public void Set(ref LobbyModificationAddMemberAttributeOptions other) { }

	// RVA: 0x4DD300 Offset: 0x4DC500 VA: 0x1804DD300 Slot: 5
	public void Set(ref Nullable<LobbyModificationAddMemberAttributeOptions> other) { }

	// RVA: 0x4DD2B0 Offset: 0x4DC4B0 VA: 0x1804DD2B0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Lobby
public struct LobbyModificationRemoveAttributeOptions // TypeDefIndex: 9254
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

// Namespace: Epic.OnlineServices.Lobby
internal struct LobbyModificationRemoveAttributeOptionsInternal : ISettable<LobbyModificationRemoveAttributeOptions>, IDisposable // TypeDefIndex: 9255
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_Key; // 0x8

	// Properties
	public Utf8String Key { set; }

	// Methods

	// RVA: 0x4DD690 Offset: 0x4DC890 VA: 0x1804DD690
	public void set_Key(Utf8String value) { }

	// RVA: 0x4DD630 Offset: 0x4DC830 VA: 0x1804DD630 Slot: 4
	public void Set(ref LobbyModificationRemoveAttributeOptions other) { }

	// RVA: 0x4DD590 Offset: 0x4DC790 VA: 0x1804DD590 Slot: 5
	public void Set(ref Nullable<LobbyModificationRemoveAttributeOptions> other) { }

	// RVA: 0x4DD540 Offset: 0x4DC740 VA: 0x1804DD540 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Lobby
public struct LobbyModificationRemoveMemberAttributeOptions // TypeDefIndex: 9256
{
	// Fields
	[CompilerGenerated]
	private Utf8String <Key>k__BackingField; // 0x0

	// Properties
	public Utf8String Key { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Utf8String get_Key() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_Key(Utf8String value) { }
}

// Namespace: Epic.OnlineServices.Lobby
internal struct LobbyModificationRemoveMemberAttributeOptionsInternal : ISettable<LobbyModificationRemoveMemberAttributeOptions>, IDisposable // TypeDefIndex: 9257
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_Key; // 0x8

	// Properties
	public Utf8String Key { set; }

	// Methods

	// RVA: 0x4DD840 Offset: 0x4DCA40 VA: 0x1804DD840
	public void set_Key(Utf8String value) { }

	// RVA: 0x4DD7E0 Offset: 0x4DC9E0 VA: 0x1804DD7E0 Slot: 4
	public void Set(ref LobbyModificationRemoveMemberAttributeOptions other) { }

	// RVA: 0x4DD740 Offset: 0x4DC940 VA: 0x1804DD740 Slot: 5
	public void Set(ref Nullable<LobbyModificationRemoveMemberAttributeOptions> other) { }

	// RVA: 0x4DD6F0 Offset: 0x4DC8F0 VA: 0x1804DD6F0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Lobby
public struct LobbyModificationSetAllowedPlatformIdsOptions // TypeDefIndex: 9258
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

// Namespace: Epic.OnlineServices.Lobby
internal struct LobbyModificationSetAllowedPlatformIdsOptionsInternal : ISettable<LobbyModificationSetAllowedPlatformIdsOptions>, IDisposable // TypeDefIndex: 9259
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_AllowedPlatformIds; // 0x8
	private uint m_AllowedPlatformIdsCount; // 0x10

	// Properties
	public uint[] AllowedPlatformIds { set; }

	// Methods

	// RVA: 0x4DD9E0 Offset: 0x4DCBE0 VA: 0x1804DD9E0
	public void set_AllowedPlatformIds(uint[] value) { }

	// RVA: 0x4DD8F0 Offset: 0x4DCAF0 VA: 0x1804DD8F0 Slot: 4
	public void Set(ref LobbyModificationSetAllowedPlatformIdsOptions other) { }

	// RVA: 0x4DD970 Offset: 0x4DCB70 VA: 0x1804DD970 Slot: 5
	public void Set(ref Nullable<LobbyModificationSetAllowedPlatformIdsOptions> other) { }

	// RVA: 0x4DD8A0 Offset: 0x4DCAA0 VA: 0x1804DD8A0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Lobby
public struct LobbyModificationSetBucketIdOptions // TypeDefIndex: 9260
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

// Namespace: Epic.OnlineServices.Lobby
internal struct LobbyModificationSetBucketIdOptionsInternal : ISettable<LobbyModificationSetBucketIdOptions>, IDisposable // TypeDefIndex: 9261
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_BucketId; // 0x8

	// Properties
	public Utf8String BucketId { set; }

	// Methods

	// RVA: 0x4DDBA0 Offset: 0x4DCDA0 VA: 0x1804DDBA0
	public void set_BucketId(Utf8String value) { }

	// RVA: 0x4DDAA0 Offset: 0x4DCCA0 VA: 0x1804DDAA0 Slot: 4
	public void Set(ref LobbyModificationSetBucketIdOptions other) { }

	// RVA: 0x4DDB00 Offset: 0x4DCD00 VA: 0x1804DDB00 Slot: 5
	public void Set(ref Nullable<LobbyModificationSetBucketIdOptions> other) { }

	// RVA: 0x4DDA50 Offset: 0x4DCC50 VA: 0x1804DDA50 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Lobby
public struct LobbyModificationSetInvitesAllowedOptions // TypeDefIndex: 9262
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

// Namespace: Epic.OnlineServices.Lobby
internal struct LobbyModificationSetInvitesAllowedOptionsInternal : ISettable<LobbyModificationSetInvitesAllowedOptions>, IDisposable // TypeDefIndex: 9263
{
	// Fields
	private int m_ApiVersion; // 0x0
	private int m_InvitesAllowed; // 0x4

	// Properties
	public bool InvitesAllowed { set; }

	// Methods

	// RVA: 0x4DDD10 Offset: 0x4DCF10 VA: 0x1804DDD10
	public void set_InvitesAllowed(bool value) { }

	// RVA: 0x4DDC00 Offset: 0x4DCE00 VA: 0x1804DDC00 Slot: 4
	public void Set(ref LobbyModificationSetInvitesAllowedOptions other) { }

	// RVA: 0x4DDC70 Offset: 0x4DCE70 VA: 0x1804DDC70 Slot: 5
	public void Set(ref Nullable<LobbyModificationSetInvitesAllowedOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Lobby
public struct LobbyModificationSetMaxMembersOptions // TypeDefIndex: 9264
{
	// Fields
	[CompilerGenerated]
	private uint <MaxMembers>k__BackingField; // 0x0

	// Properties
	public uint MaxMembers { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public uint get_MaxMembers() { }

	[CompilerGenerated]
	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_MaxMembers(uint value) { }
}

// Namespace: Epic.OnlineServices.Lobby
internal struct LobbyModificationSetMaxMembersOptionsInternal : ISettable<LobbyModificationSetMaxMembersOptions>, IDisposable // TypeDefIndex: 9265
{
	// Fields
	private int m_ApiVersion; // 0x0
	private uint m_MaxMembers; // 0x4

	// Properties
	public uint MaxMembers { set; }

	// Methods

	// RVA: 0x3F84A0 Offset: 0x3F76A0 VA: 0x1803F84A0
	public void set_MaxMembers(uint value) { }

	// RVA: 0x40B2E0 Offset: 0x40A4E0 VA: 0x18040B2E0 Slot: 4
	public void Set(ref LobbyModificationSetMaxMembersOptions other) { }

	// RVA: 0x4DDD70 Offset: 0x4DCF70 VA: 0x1804DDD70 Slot: 5
	public void Set(ref Nullable<LobbyModificationSetMaxMembersOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Lobby
public struct LobbyModificationSetPermissionLevelOptions // TypeDefIndex: 9266
{
	// Fields
	[CompilerGenerated]
	private LobbyPermissionLevel <PermissionLevel>k__BackingField; // 0x0

	// Properties
	public LobbyPermissionLevel PermissionLevel { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public LobbyPermissionLevel get_PermissionLevel() { }

	[CompilerGenerated]
	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_PermissionLevel(LobbyPermissionLevel value) { }
}

// Namespace: Epic.OnlineServices.Lobby
internal struct LobbyModificationSetPermissionLevelOptionsInternal : ISettable<LobbyModificationSetPermissionLevelOptions>, IDisposable // TypeDefIndex: 9267
{
	// Fields
	private int m_ApiVersion; // 0x0
	private LobbyPermissionLevel m_PermissionLevel; // 0x4

	// Properties
	public LobbyPermissionLevel PermissionLevel { set; }

	// Methods

	// RVA: 0x3F84A0 Offset: 0x3F76A0 VA: 0x1803F84A0
	public void set_PermissionLevel(LobbyPermissionLevel value) { }

	// RVA: 0x40B2E0 Offset: 0x40A4E0 VA: 0x18040B2E0 Slot: 4
	public void Set(ref LobbyModificationSetPermissionLevelOptions other) { }

	// RVA: 0x4DDDD0 Offset: 0x4DCFD0 VA: 0x1804DDDD0 Slot: 5
	public void Set(ref Nullable<LobbyModificationSetPermissionLevelOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Lobby
public enum LobbyPermissionLevel // TypeDefIndex: 9268
{
	// Fields
	public int value__; // 0x0
	public const LobbyPermissionLevel Publicadvertised = 0;
	public const LobbyPermissionLevel Joinviapresence = 1;
	public const LobbyPermissionLevel Inviteonly = 2;
}

// Namespace: Epic.OnlineServices.Lobby
public sealed class LobbySearch : Handle // TypeDefIndex: 9269
{
	// Fields
	public const int LobbysearchCopysearchresultbyindexApiLatest = 1;
	public const int LobbysearchFindApiLatest = 1;
	public const int LobbysearchGetsearchresultcountApiLatest = 1;
	public const int LobbysearchRemoveparameterApiLatest = 1;
	public const int LobbysearchSetlobbyidApiLatest = 1;
	public const int LobbysearchSetmaxresultsApiLatest = 1;
	public const int LobbysearchSetparameterApiLatest = 1;
	public const int LobbysearchSettargetuseridApiLatest = 1;

	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }

	// RVA: 0x40BDB0 Offset: 0x40AFB0 VA: 0x18040BDB0
	public void .ctor(IntPtr innerHandle) { }

	// RVA: 0x4DF520 Offset: 0x4DE720 VA: 0x1804DF520
	public Result CopySearchResultByIndex(ref LobbySearchCopySearchResultByIndexOptions options, out LobbyDetails outLobbyDetailsHandle) { }

	// RVA: 0x4DF5F0 Offset: 0x4DE7F0 VA: 0x1804DF5F0
	public void Find(ref LobbySearchFindOptions options, object clientData, LobbySearchOnFindCallback completionDelegate) { }

	// RVA: 0x4DF7E0 Offset: 0x4DE9E0 VA: 0x1804DF7E0
	public uint GetSearchResultCount(ref LobbySearchGetSearchResultCountOptions options) { }

	// RVA: 0x4DF900 Offset: 0x4DEB00 VA: 0x1804DF900
	public void Release() { }

	// RVA: 0x4DF910 Offset: 0x4DEB10 VA: 0x1804DF910
	public Result RemoveParameter(ref LobbySearchRemoveParameterOptions options) { }

	// RVA: 0x4DFA00 Offset: 0x4DEC00 VA: 0x1804DFA00
	public Result SetLobbyId(ref LobbySearchSetLobbyIdOptions options) { }

	// RVA: 0x4DFAE0 Offset: 0x4DECE0 VA: 0x1804DFAE0
	public Result SetMaxResults(ref LobbySearchSetMaxResultsOptions options) { }

	// RVA: 0x4DFB70 Offset: 0x4DED70 VA: 0x1804DFB70
	public Result SetParameter(ref LobbySearchSetParameterOptions options) { }

	// RVA: 0x4DFCA0 Offset: 0x4DEEA0 VA: 0x1804DFCA0
	public Result SetTargetUserId(ref LobbySearchSetTargetUserIdOptions options) { }

	[MonoPInvokeCallback(typeof(LobbySearchOnFindCallbackInternal))]
	// RVA: 0x4DF860 Offset: 0x4DEA60 VA: 0x1804DF860
	internal static void OnFindCallbackInternalImplementation(ref LobbySearchFindCallbackInfoInternal data) { }
}

// Namespace: Epic.OnlineServices.Lobby
public struct LobbySearchCopySearchResultByIndexOptions // TypeDefIndex: 9270
{
	// Fields
	[CompilerGenerated]
	private uint <LobbyIndex>k__BackingField; // 0x0

	// Properties
	public uint LobbyIndex { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public uint get_LobbyIndex() { }

	[CompilerGenerated]
	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_LobbyIndex(uint value) { }
}

// Namespace: Epic.OnlineServices.Lobby
internal struct LobbySearchCopySearchResultByIndexOptionsInternal : ISettable<LobbySearchCopySearchResultByIndexOptions>, IDisposable // TypeDefIndex: 9271
{
	// Fields
	private int m_ApiVersion; // 0x0
	private uint m_LobbyIndex; // 0x4

	// Properties
	public uint LobbyIndex { set; }

	// Methods

	// RVA: 0x3F84A0 Offset: 0x3F76A0 VA: 0x1803F84A0
	public void set_LobbyIndex(uint value) { }

	// RVA: 0x40B2E0 Offset: 0x40A4E0 VA: 0x18040B2E0 Slot: 4
	public void Set(ref LobbySearchCopySearchResultByIndexOptions other) { }

	// RVA: 0x4DE630 Offset: 0x4DD830 VA: 0x1804DE630 Slot: 5
	public void Set(ref Nullable<LobbySearchCopySearchResultByIndexOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Lobby
public struct LobbySearchFindCallbackInfo : ICallbackInfo // TypeDefIndex: 9272
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

	// RVA: 0x4DE8F0 Offset: 0x4DDAF0 VA: 0x1804DE8F0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x4DE940 Offset: 0x4DDB40 VA: 0x1804DE940
	internal void Set(ref LobbySearchFindCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.Lobby
internal struct LobbySearchFindCallbackInfoInternal : ICallbackInfoInternal, IGettable<LobbySearchFindCallbackInfo>, ISettable<LobbySearchFindCallbackInfo>, IDisposable // TypeDefIndex: 9273
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

	// RVA: 0x4DE820 Offset: 0x4DDA20 VA: 0x1804DE820
	public object get_ClientData() { }

	// RVA: 0x4DE890 Offset: 0x4DDA90 VA: 0x1804DE890
	public void set_ClientData(object value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x4DE700 Offset: 0x4DD900 VA: 0x1804DE700 Slot: 6
	public void Set(ref LobbySearchFindCallbackInfo other) { }

	// RVA: 0x4DE760 Offset: 0x4DD960 VA: 0x1804DE760 Slot: 7
	public void Set(ref Nullable<LobbySearchFindCallbackInfo> other) { }

	// RVA: 0x4DE690 Offset: 0x4DD890 VA: 0x1804DE690 Slot: 8
	public void Dispose() { }

	// RVA: 0x4DE6E0 Offset: 0x4DD8E0 VA: 0x1804DE6E0 Slot: 5
	public void Get(out LobbySearchFindCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.Lobby
public struct LobbySearchFindOptions // TypeDefIndex: 9274
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

// Namespace: Epic.OnlineServices.Lobby
internal struct LobbySearchFindOptionsInternal : ISettable<LobbySearchFindOptions>, IDisposable // TypeDefIndex: 9275
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8

	// Properties
	public ProductUserId LocalUserId { set; }

	// Methods

	// RVA: 0x4DEB10 Offset: 0x4DDD10 VA: 0x1804DEB10
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x4DEA10 Offset: 0x4DDC10 VA: 0x1804DEA10 Slot: 4
	public void Set(ref LobbySearchFindOptions other) { }

	// RVA: 0x4DEA70 Offset: 0x4DDC70 VA: 0x1804DEA70 Slot: 5
	public void Set(ref Nullable<LobbySearchFindOptions> other) { }

	// RVA: 0x4DE9C0 Offset: 0x4DDBC0 VA: 0x1804DE9C0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Lobby
public struct LobbySearchGetSearchResultCountOptions // TypeDefIndex: 9276
{}

// Namespace: Epic.OnlineServices.Lobby
internal struct LobbySearchGetSearchResultCountOptionsInternal : ISettable<LobbySearchGetSearchResultCountOptions>, IDisposable // TypeDefIndex: 9277
{
	// Fields
	private int m_ApiVersion; // 0x0

	// Methods

	// RVA: 0x3F98A0 Offset: 0x3F8AA0 VA: 0x1803F98A0 Slot: 4
	public void Set(ref LobbySearchGetSearchResultCountOptions other) { }

	// RVA: 0x4DEB70 Offset: 0x4DDD70 VA: 0x1804DEB70 Slot: 5
	public void Set(ref Nullable<LobbySearchGetSearchResultCountOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Lobby
public sealed class LobbySearchOnFindCallback : MulticastDelegate // TypeDefIndex: 9278
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref LobbySearchFindCallbackInfo data) { }

	// RVA: 0x4DEC50 Offset: 0x4DDE50 VA: 0x1804DEC50 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref LobbySearchFindCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref LobbySearchFindCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Lobby
[UnmanagedFunctionPointer(2)]
internal sealed class LobbySearchOnFindCallbackInternal : MulticastDelegate // TypeDefIndex: 9279
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref LobbySearchFindCallbackInfoInternal data) { }

	// RVA: 0x4DEBC0 Offset: 0x4DDDC0 VA: 0x1804DEBC0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref LobbySearchFindCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref LobbySearchFindCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Lobby
public struct LobbySearchRemoveParameterOptions // TypeDefIndex: 9280
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

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Utf8String get_Key() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_Key(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3F5510 Offset: 0x3F4710 VA: 0x1803F5510
	public ComparisonOp get_ComparisonOp() { }

	[CompilerGenerated]
	// RVA: 0x3F5520 Offset: 0x3F4720 VA: 0x1803F5520
	public void set_ComparisonOp(ComparisonOp value) { }
}

// Namespace: Epic.OnlineServices.Lobby
internal struct LobbySearchRemoveParameterOptionsInternal : ISettable<LobbySearchRemoveParameterOptions>, IDisposable // TypeDefIndex: 9281
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_Key; // 0x8
	private ComparisonOp m_ComparisonOp; // 0x10

	// Properties
	public Utf8String Key { set; }
	public ComparisonOp ComparisonOp { set; }

	// Methods

	// RVA: 0x4DEE70 Offset: 0x4DE070 VA: 0x1804DEE70
	public void set_Key(Utf8String value) { }

	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_ComparisonOp(ComparisonOp value) { }

	// RVA: 0x4DEDF0 Offset: 0x4DDFF0 VA: 0x1804DEDF0 Slot: 4
	public void Set(ref LobbySearchRemoveParameterOptions other) { }

	// RVA: 0x4DED30 Offset: 0x4DDF30 VA: 0x1804DED30 Slot: 5
	public void Set(ref Nullable<LobbySearchRemoveParameterOptions> other) { }

	// RVA: 0x4DECE0 Offset: 0x4DDEE0 VA: 0x1804DECE0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Lobby
public struct LobbySearchSetLobbyIdOptions // TypeDefIndex: 9282
{
	// Fields
	[CompilerGenerated]
	private Utf8String <LobbyId>k__BackingField; // 0x0

	// Properties
	public Utf8String LobbyId { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Utf8String get_LobbyId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_LobbyId(Utf8String value) { }
}

// Namespace: Epic.OnlineServices.Lobby
internal struct LobbySearchSetLobbyIdOptionsInternal : ISettable<LobbySearchSetLobbyIdOptions>, IDisposable // TypeDefIndex: 9283
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LobbyId; // 0x8

	// Properties
	public Utf8String LobbyId { set; }

	// Methods

	// RVA: 0x4DF020 Offset: 0x4DE220 VA: 0x1804DF020
	public void set_LobbyId(Utf8String value) { }

	// RVA: 0x4DEF20 Offset: 0x4DE120 VA: 0x1804DEF20 Slot: 4
	public void Set(ref LobbySearchSetLobbyIdOptions other) { }

	// RVA: 0x4DEF80 Offset: 0x4DE180 VA: 0x1804DEF80 Slot: 5
	public void Set(ref Nullable<LobbySearchSetLobbyIdOptions> other) { }

	// RVA: 0x4DEED0 Offset: 0x4DE0D0 VA: 0x1804DEED0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Lobby
public struct LobbySearchSetMaxResultsOptions // TypeDefIndex: 9284
{
	// Fields
	[CompilerGenerated]
	private uint <MaxResults>k__BackingField; // 0x0

	// Properties
	public uint MaxResults { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public uint get_MaxResults() { }

	[CompilerGenerated]
	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_MaxResults(uint value) { }
}

// Namespace: Epic.OnlineServices.Lobby
internal struct LobbySearchSetMaxResultsOptionsInternal : ISettable<LobbySearchSetMaxResultsOptions>, IDisposable // TypeDefIndex: 9285
{
	// Fields
	private int m_ApiVersion; // 0x0
	private uint m_MaxResults; // 0x4

	// Properties
	public uint MaxResults { set; }

	// Methods

	// RVA: 0x3F84A0 Offset: 0x3F76A0 VA: 0x1803F84A0
	public void set_MaxResults(uint value) { }

	// RVA: 0x40B2E0 Offset: 0x40A4E0 VA: 0x18040B2E0 Slot: 4
	public void Set(ref LobbySearchSetMaxResultsOptions other) { }

	// RVA: 0x4DF080 Offset: 0x4DE280 VA: 0x1804DF080 Slot: 5
	public void Set(ref Nullable<LobbySearchSetMaxResultsOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Lobby
public struct LobbySearchSetParameterOptions // TypeDefIndex: 9286
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

	[CompilerGenerated]
	[IsReadOnly]
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

// Namespace: Epic.OnlineServices.Lobby
internal struct LobbySearchSetParameterOptionsInternal : ISettable<LobbySearchSetParameterOptions>, IDisposable // TypeDefIndex: 9287
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_Parameter; // 0x8
	private ComparisonOp m_ComparisonOp; // 0x10

	// Properties
	public Nullable<AttributeData> Parameter { set; }
	public ComparisonOp ComparisonOp { set; }

	// Methods

	// RVA: 0x4DF300 Offset: 0x4DE500 VA: 0x1804DF300
	public void set_Parameter(Nullable<AttributeData> value) { }

	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_ComparisonOp(ComparisonOp value) { }

	// RVA: 0x4DF130 Offset: 0x4DE330 VA: 0x1804DF130 Slot: 4
	public void Set(ref LobbySearchSetParameterOptions other) { }

	// RVA: 0x4DF1E0 Offset: 0x4DE3E0 VA: 0x1804DF1E0 Slot: 5
	public void Set(ref Nullable<LobbySearchSetParameterOptions> other) { }

	// RVA: 0x4DF0E0 Offset: 0x4DE2E0 VA: 0x1804DF0E0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Lobby
public struct LobbySearchSetTargetUserIdOptions // TypeDefIndex: 9288
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <TargetUserId>k__BackingField; // 0x0

	// Properties
	public ProductUserId TargetUserId { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public ProductUserId get_TargetUserId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_TargetUserId(ProductUserId value) { }
}

// Namespace: Epic.OnlineServices.Lobby
internal struct LobbySearchSetTargetUserIdOptionsInternal : ISettable<LobbySearchSetTargetUserIdOptions>, IDisposable // TypeDefIndex: 9289
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_TargetUserId; // 0x8

	// Properties
	public ProductUserId TargetUserId { set; }

	// Methods

	// RVA: 0x4DF4C0 Offset: 0x4DE6C0 VA: 0x1804DF4C0
	public void set_TargetUserId(ProductUserId value) { }

	// RVA: 0x4DF3C0 Offset: 0x4DE5C0 VA: 0x1804DF3C0 Slot: 4
	public void Set(ref LobbySearchSetTargetUserIdOptions other) { }

	// RVA: 0x4DF420 Offset: 0x4DE620 VA: 0x1804DF420 Slot: 5
	public void Set(ref Nullable<LobbySearchSetTargetUserIdOptions> other) { }

	// RVA: 0x4DF370 Offset: 0x4DE570 VA: 0x1804DF370 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Lobby
public struct LobbyUpdateReceivedCallbackInfo : ICallbackInfo // TypeDefIndex: 9290
{
	// Fields
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <LobbyId>k__BackingField; // 0x8

	// Properties
	public object ClientData { get; set; }
	public Utf8String LobbyId { get; set; }

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
	public Utf8String get_LobbyId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_LobbyId(Utf8String value) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x4E0150 Offset: 0x4DF350 VA: 0x1804E0150
	internal void Set(ref LobbyUpdateReceivedCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.Lobby
internal struct LobbyUpdateReceivedCallbackInfoInternal : ICallbackInfoInternal, IGettable<LobbyUpdateReceivedCallbackInfo>, ISettable<LobbyUpdateReceivedCallbackInfo>, IDisposable // TypeDefIndex: 9291
{
	// Fields
	private IntPtr m_ClientData; // 0x0
	private IntPtr m_LobbyId; // 0x8

	// Properties
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public Utf8String LobbyId { get; set; }

	// Methods

	// RVA: 0x4DFFB0 Offset: 0x4DF1B0 VA: 0x1804DFFB0
	public object get_ClientData() { }

	// RVA: 0x4E0090 Offset: 0x4DF290 VA: 0x1804E0090
	public void set_ClientData(object value) { }

	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x4E0020 Offset: 0x4DF220 VA: 0x1804E0020
	public Utf8String get_LobbyId() { }

	// RVA: 0x4E00F0 Offset: 0x4DF2F0 VA: 0x1804E00F0
	public void set_LobbyId(Utf8String value) { }

	// RVA: 0x4DFE00 Offset: 0x4DF000 VA: 0x1804DFE00 Slot: 6
	public void Set(ref LobbyUpdateReceivedCallbackInfo other) { }

	// RVA: 0x4DFEB0 Offset: 0x4DF0B0 VA: 0x1804DFEB0 Slot: 7
	public void Set(ref Nullable<LobbyUpdateReceivedCallbackInfo> other) { }

	// RVA: 0x4DFD80 Offset: 0x4DEF80 VA: 0x1804DFD80 Slot: 8
	public void Dispose() { }

	// RVA: 0x4DFDE0 Offset: 0x4DEFE0 VA: 0x1804DFDE0 Slot: 5
	public void Get(out LobbyUpdateReceivedCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.Lobby
public struct LocalRTCOptions // TypeDefIndex: 9292
{
	// Fields
	[CompilerGenerated]
	private uint <Flags>k__BackingField; // 0x0
	[CompilerGenerated]
	private bool <UseManualAudioInput>k__BackingField; // 0x4
	[CompilerGenerated]
	private bool <UseManualAudioOutput>k__BackingField; // 0x5
	[CompilerGenerated]
	private bool <LocalAudioDeviceInputStartsMuted>k__BackingField; // 0x6

	// Properties
	public uint Flags { get; set; }
	public bool UseManualAudioInput { get; set; }
	public bool UseManualAudioOutput { get; set; }
	public bool LocalAudioDeviceInputStartsMuted { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public uint get_Flags() { }

	[CompilerGenerated]
	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_Flags(uint value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x499020 Offset: 0x498220 VA: 0x180499020
	public bool get_UseManualAudioInput() { }

	[CompilerGenerated]
	// RVA: 0x499070 Offset: 0x498270 VA: 0x180499070
	public void set_UseManualAudioInput(bool value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x499050 Offset: 0x498250 VA: 0x180499050
	public bool get_UseManualAudioOutput() { }

	[CompilerGenerated]
	// RVA: 0x499090 Offset: 0x498290 VA: 0x180499090
	public void set_UseManualAudioOutput(bool value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x4E0820 Offset: 0x4DFA20 VA: 0x1804E0820
	public bool get_LocalAudioDeviceInputStartsMuted() { }

	[CompilerGenerated]
	// RVA: 0x4E0830 Offset: 0x4DFA30 VA: 0x1804E0830
	public void set_LocalAudioDeviceInputStartsMuted(bool value) { }

	// RVA: 0x4E0700 Offset: 0x4DF900 VA: 0x1804E0700
	internal void Set(ref LocalRTCOptionsInternal other) { }
}

// Namespace: Epic.OnlineServices.Lobby
internal struct LocalRTCOptionsInternal : IGettable<LocalRTCOptions>, ISettable<LocalRTCOptions>, IDisposable // TypeDefIndex: 9293
{
	// Fields
	private int m_ApiVersion; // 0x0
	private uint m_Flags; // 0x4
	private int m_UseManualAudioInput; // 0x8
	private int m_UseManualAudioOutput; // 0xC
	private int m_LocalAudioDeviceInputStartsMuted; // 0x10

	// Properties
	public uint Flags { get; set; }
	public bool UseManualAudioInput { get; set; }
	public bool UseManualAudioOutput { get; set; }
	public bool LocalAudioDeviceInputStartsMuted { get; set; }

	// Methods

	// RVA: 0x3F8350 Offset: 0x3F7550 VA: 0x1803F8350
	public uint get_Flags() { }

	// RVA: 0x3F84A0 Offset: 0x3F76A0 VA: 0x1803F84A0
	public void set_Flags(uint value) { }

	// RVA: 0x4E0520 Offset: 0x4DF720 VA: 0x1804E0520
	public bool get_UseManualAudioInput() { }

	// RVA: 0x4E0640 Offset: 0x4DF840 VA: 0x1804E0640
	public void set_UseManualAudioInput(bool value) { }

	// RVA: 0x4E0580 Offset: 0x4DF780 VA: 0x1804E0580
	public bool get_UseManualAudioOutput() { }

	// RVA: 0x4E06A0 Offset: 0x4DF8A0 VA: 0x1804E06A0
	public void set_UseManualAudioOutput(bool value) { }

	// RVA: 0x4E04C0 Offset: 0x4DF6C0 VA: 0x1804E04C0
	public bool get_LocalAudioDeviceInputStartsMuted() { }

	// RVA: 0x4E05E0 Offset: 0x4DF7E0 VA: 0x1804E05E0
	public void set_LocalAudioDeviceInputStartsMuted(bool value) { }

	// RVA: 0x4E03C0 Offset: 0x4DF5C0 VA: 0x1804E03C0 Slot: 5
	public void Set(ref LocalRTCOptions other) { }

	// RVA: 0x4E0250 Offset: 0x4DF450 VA: 0x1804E0250 Slot: 6
	public void Set(ref Nullable<LocalRTCOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 7
	public void Dispose() { }

	// RVA: 0x4E0230 Offset: 0x4DF430 VA: 0x1804E0230 Slot: 4
	public void Get(out LocalRTCOptions output) { }
}

// Namespace: Epic.OnlineServices.Lobby
public sealed class OnCreateLobbyCallback : MulticastDelegate // TypeDefIndex: 9294
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref CreateLobbyCallbackInfo data) { }

	// RVA: 0x4E08D0 Offset: 0x4DFAD0 VA: 0x1804E08D0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref CreateLobbyCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref CreateLobbyCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Lobby
[UnmanagedFunctionPointer(2)]
internal sealed class OnCreateLobbyCallbackInternal : MulticastDelegate // TypeDefIndex: 9295
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref CreateLobbyCallbackInfoInternal data) { }

	// RVA: 0x4E0840 Offset: 0x4DFA40 VA: 0x1804E0840 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref CreateLobbyCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref CreateLobbyCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Lobby
public sealed class OnDestroyLobbyCallback : MulticastDelegate // TypeDefIndex: 9296
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref DestroyLobbyCallbackInfo data) { }

	// RVA: 0x4E0B10 Offset: 0x4DFD10 VA: 0x1804E0B10 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref DestroyLobbyCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref DestroyLobbyCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Lobby
[UnmanagedFunctionPointer(2)]
internal sealed class OnDestroyLobbyCallbackInternal : MulticastDelegate // TypeDefIndex: 9297
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref DestroyLobbyCallbackInfoInternal data) { }

	// RVA: 0x4E0A80 Offset: 0x4DFC80 VA: 0x1804E0A80 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref DestroyLobbyCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref DestroyLobbyCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Lobby
public sealed class OnHardMuteMemberCallback : MulticastDelegate // TypeDefIndex: 9298
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref HardMuteMemberCallbackInfo data) { }

	// RVA: 0x4E0C30 Offset: 0x4DFE30 VA: 0x1804E0C30 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref HardMuteMemberCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref HardMuteMemberCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Lobby
[UnmanagedFunctionPointer(2)]
internal sealed class OnHardMuteMemberCallbackInternal : MulticastDelegate // TypeDefIndex: 9299
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref HardMuteMemberCallbackInfoInternal data) { }

	// RVA: 0x4E0BA0 Offset: 0x4DFDA0 VA: 0x1804E0BA0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref HardMuteMemberCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref HardMuteMemberCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Lobby
public sealed class OnJoinLobbyAcceptedCallback : MulticastDelegate // TypeDefIndex: 9300
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref JoinLobbyAcceptedCallbackInfo data) { }

	// RVA: 0x4E0D50 Offset: 0x4DFF50 VA: 0x1804E0D50 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref JoinLobbyAcceptedCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref JoinLobbyAcceptedCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Lobby
[UnmanagedFunctionPointer(2)]
internal sealed class OnJoinLobbyAcceptedCallbackInternal : MulticastDelegate // TypeDefIndex: 9301
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref JoinLobbyAcceptedCallbackInfoInternal data) { }

	// RVA: 0x4E0CC0 Offset: 0x4DFEC0 VA: 0x1804E0CC0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref JoinLobbyAcceptedCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref JoinLobbyAcceptedCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Lobby
public sealed class OnJoinLobbyByIdCallback : MulticastDelegate // TypeDefIndex: 9302
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref JoinLobbyByIdCallbackInfo data) { }

	// RVA: 0x4E0E70 Offset: 0x4E0070 VA: 0x1804E0E70 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref JoinLobbyByIdCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref JoinLobbyByIdCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Lobby
[UnmanagedFunctionPointer(2)]
internal sealed class OnJoinLobbyByIdCallbackInternal : MulticastDelegate // TypeDefIndex: 9303
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref JoinLobbyByIdCallbackInfoInternal data) { }

	// RVA: 0x4E0DE0 Offset: 0x4DFFE0 VA: 0x1804E0DE0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref JoinLobbyByIdCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref JoinLobbyByIdCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Lobby
public sealed class OnJoinLobbyCallback : MulticastDelegate // TypeDefIndex: 9304
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref JoinLobbyCallbackInfo data) { }

	// RVA: 0x4E0F90 Offset: 0x4E0190 VA: 0x1804E0F90 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref JoinLobbyCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref JoinLobbyCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Lobby
[UnmanagedFunctionPointer(2)]
internal sealed class OnJoinLobbyCallbackInternal : MulticastDelegate // TypeDefIndex: 9305
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref JoinLobbyCallbackInfoInternal data) { }

	// RVA: 0x4E0F00 Offset: 0x4E0100 VA: 0x1804E0F00 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref JoinLobbyCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref JoinLobbyCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Lobby
public sealed class OnKickMemberCallback : MulticastDelegate // TypeDefIndex: 9306
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref KickMemberCallbackInfo data) { }

	// RVA: 0x4E10B0 Offset: 0x4E02B0 VA: 0x1804E10B0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref KickMemberCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref KickMemberCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Lobby
[UnmanagedFunctionPointer(2)]
internal sealed class OnKickMemberCallbackInternal : MulticastDelegate // TypeDefIndex: 9307
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref KickMemberCallbackInfoInternal data) { }

	// RVA: 0x4E1020 Offset: 0x4E0220 VA: 0x1804E1020 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref KickMemberCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref KickMemberCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Lobby
public sealed class OnLeaveLobbyCallback : MulticastDelegate // TypeDefIndex: 9308
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref LeaveLobbyCallbackInfo data) { }

	// RVA: 0x4E11D0 Offset: 0x4E03D0 VA: 0x1804E11D0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref LeaveLobbyCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref LeaveLobbyCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Lobby
[UnmanagedFunctionPointer(2)]
internal sealed class OnLeaveLobbyCallbackInternal : MulticastDelegate // TypeDefIndex: 9309
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref LeaveLobbyCallbackInfoInternal data) { }

	// RVA: 0x4E1140 Offset: 0x4E0340 VA: 0x1804E1140 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref LeaveLobbyCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref LeaveLobbyCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Lobby
public sealed class OnLeaveLobbyRequestedCallback : MulticastDelegate // TypeDefIndex: 9310
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref LeaveLobbyRequestedCallbackInfo data) { }

	// RVA: 0x4E12F0 Offset: 0x4E04F0 VA: 0x1804E12F0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref LeaveLobbyRequestedCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref LeaveLobbyRequestedCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Lobby
[UnmanagedFunctionPointer(2)]
internal sealed class OnLeaveLobbyRequestedCallbackInternal : MulticastDelegate // TypeDefIndex: 9311
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref LeaveLobbyRequestedCallbackInfoInternal data) { }

	// RVA: 0x4E1260 Offset: 0x4E0460 VA: 0x1804E1260 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref LeaveLobbyRequestedCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref LeaveLobbyRequestedCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Lobby
public sealed class OnLobbyInviteAcceptedCallback : MulticastDelegate // TypeDefIndex: 9312
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref LobbyInviteAcceptedCallbackInfo data) { }

	// RVA: 0x4E1410 Offset: 0x4E0610 VA: 0x1804E1410 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref LobbyInviteAcceptedCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref LobbyInviteAcceptedCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Lobby
[UnmanagedFunctionPointer(2)]
internal sealed class OnLobbyInviteAcceptedCallbackInternal : MulticastDelegate // TypeDefIndex: 9313
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref LobbyInviteAcceptedCallbackInfoInternal data) { }

	// RVA: 0x4E1380 Offset: 0x4E0580 VA: 0x1804E1380 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref LobbyInviteAcceptedCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref LobbyInviteAcceptedCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Lobby
public sealed class OnLobbyInviteReceivedCallback : MulticastDelegate // TypeDefIndex: 9314
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref LobbyInviteReceivedCallbackInfo data) { }

	// RVA: 0x4E1530 Offset: 0x4E0730 VA: 0x1804E1530 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref LobbyInviteReceivedCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref LobbyInviteReceivedCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Lobby
[UnmanagedFunctionPointer(2)]
internal sealed class OnLobbyInviteReceivedCallbackInternal : MulticastDelegate // TypeDefIndex: 9315
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref LobbyInviteReceivedCallbackInfoInternal data) { }

	// RVA: 0x4E14A0 Offset: 0x4E06A0 VA: 0x1804E14A0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref LobbyInviteReceivedCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref LobbyInviteReceivedCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Lobby
public sealed class OnLobbyInviteRejectedCallback : MulticastDelegate // TypeDefIndex: 9316
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref LobbyInviteRejectedCallbackInfo data) { }

	// RVA: 0x4E1650 Offset: 0x4E0850 VA: 0x1804E1650 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref LobbyInviteRejectedCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref LobbyInviteRejectedCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Lobby
[UnmanagedFunctionPointer(2)]
internal sealed class OnLobbyInviteRejectedCallbackInternal : MulticastDelegate // TypeDefIndex: 9317
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref LobbyInviteRejectedCallbackInfoInternal data) { }

	// RVA: 0x4E15C0 Offset: 0x4E07C0 VA: 0x1804E15C0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref LobbyInviteRejectedCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref LobbyInviteRejectedCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Lobby
public sealed class OnLobbyMemberStatusReceivedCallback : MulticastDelegate // TypeDefIndex: 9318
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref LobbyMemberStatusReceivedCallbackInfo data) { }

	// RVA: 0x4E1770 Offset: 0x4E0970 VA: 0x1804E1770 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref LobbyMemberStatusReceivedCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref LobbyMemberStatusReceivedCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Lobby
[UnmanagedFunctionPointer(2)]
internal sealed class OnLobbyMemberStatusReceivedCallbackInternal : MulticastDelegate // TypeDefIndex: 9319
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref LobbyMemberStatusReceivedCallbackInfoInternal data) { }

	// RVA: 0x4E16E0 Offset: 0x4E08E0 VA: 0x1804E16E0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref LobbyMemberStatusReceivedCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref LobbyMemberStatusReceivedCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Lobby
public sealed class OnLobbyMemberUpdateReceivedCallback : MulticastDelegate // TypeDefIndex: 9320
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref LobbyMemberUpdateReceivedCallbackInfo data) { }

	// RVA: 0x4E1890 Offset: 0x4E0A90 VA: 0x1804E1890 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref LobbyMemberUpdateReceivedCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref LobbyMemberUpdateReceivedCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Lobby
[UnmanagedFunctionPointer(2)]
internal sealed class OnLobbyMemberUpdateReceivedCallbackInternal : MulticastDelegate // TypeDefIndex: 9321
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref LobbyMemberUpdateReceivedCallbackInfoInternal data) { }

	// RVA: 0x4E1800 Offset: 0x4E0A00 VA: 0x1804E1800 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref LobbyMemberUpdateReceivedCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref LobbyMemberUpdateReceivedCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Lobby
public sealed class OnLobbyUpdateReceivedCallback : MulticastDelegate // TypeDefIndex: 9322
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref LobbyUpdateReceivedCallbackInfo data) { }

	// RVA: 0x4E19B0 Offset: 0x4E0BB0 VA: 0x1804E19B0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref LobbyUpdateReceivedCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref LobbyUpdateReceivedCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Lobby
[UnmanagedFunctionPointer(2)]
internal sealed class OnLobbyUpdateReceivedCallbackInternal : MulticastDelegate // TypeDefIndex: 9323
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref LobbyUpdateReceivedCallbackInfoInternal data) { }

	// RVA: 0x4E1920 Offset: 0x4E0B20 VA: 0x1804E1920 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref LobbyUpdateReceivedCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref LobbyUpdateReceivedCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Lobby
public sealed class OnPromoteMemberCallback : MulticastDelegate // TypeDefIndex: 9324
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref PromoteMemberCallbackInfo data) { }

	// RVA: 0x4E1BF0 Offset: 0x4E0DF0 VA: 0x1804E1BF0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref PromoteMemberCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref PromoteMemberCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Lobby
[UnmanagedFunctionPointer(2)]
internal sealed class OnPromoteMemberCallbackInternal : MulticastDelegate // TypeDefIndex: 9325
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref PromoteMemberCallbackInfoInternal data) { }

	// RVA: 0x4E1B60 Offset: 0x4E0D60 VA: 0x1804E1B60 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref PromoteMemberCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref PromoteMemberCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Lobby
public sealed class OnQueryInvitesCallback : MulticastDelegate // TypeDefIndex: 9326
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref QueryInvitesCallbackInfo data) { }

	// RVA: 0x4E1E30 Offset: 0x4E1030 VA: 0x1804E1E30 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref QueryInvitesCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref QueryInvitesCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Lobby
[UnmanagedFunctionPointer(2)]
internal sealed class OnQueryInvitesCallbackInternal : MulticastDelegate // TypeDefIndex: 9327
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref QueryInvitesCallbackInfoInternal data) { }

	// RVA: 0x4E1DA0 Offset: 0x4E0FA0 VA: 0x1804E1DA0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref QueryInvitesCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref QueryInvitesCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Lobby
public sealed class OnRejectInviteCallback : MulticastDelegate // TypeDefIndex: 9328
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref RejectInviteCallbackInfo data) { }

	// RVA: 0x4E3070 Offset: 0x4E2270 VA: 0x1804E3070 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref RejectInviteCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref RejectInviteCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Lobby
[UnmanagedFunctionPointer(2)]
internal sealed class OnRejectInviteCallbackInternal : MulticastDelegate // TypeDefIndex: 9329
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref RejectInviteCallbackInfoInternal data) { }

	// RVA: 0x4E2FE0 Offset: 0x4E21E0 VA: 0x1804E2FE0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref RejectInviteCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref RejectInviteCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Lobby
public sealed class OnRTCRoomConnectionChangedCallback : MulticastDelegate // TypeDefIndex: 9330
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref RTCRoomConnectionChangedCallbackInfo data) { }

	// RVA: 0x4E2F50 Offset: 0x4E2150 VA: 0x1804E2F50 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref RTCRoomConnectionChangedCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref RTCRoomConnectionChangedCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Lobby
[UnmanagedFunctionPointer(2)]
internal sealed class OnRTCRoomConnectionChangedCallbackInternal : MulticastDelegate // TypeDefIndex: 9331
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref RTCRoomConnectionChangedCallbackInfoInternal data) { }

	// RVA: 0x4E2EC0 Offset: 0x4E20C0 VA: 0x1804E2EC0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref RTCRoomConnectionChangedCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref RTCRoomConnectionChangedCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Lobby
public sealed class OnSendInviteCallback : MulticastDelegate // TypeDefIndex: 9332
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref SendInviteCallbackInfo data) { }

	// RVA: 0x4E32B0 Offset: 0x4E24B0 VA: 0x1804E32B0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref SendInviteCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref SendInviteCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Lobby
[UnmanagedFunctionPointer(2)]
internal sealed class OnSendInviteCallbackInternal : MulticastDelegate // TypeDefIndex: 9333
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref SendInviteCallbackInfoInternal data) { }

	// RVA: 0x4E3220 Offset: 0x4E2420 VA: 0x1804E3220 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref SendInviteCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref SendInviteCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Lobby
public sealed class OnSendLobbyNativeInviteRequestedCallback : MulticastDelegate // TypeDefIndex: 9334
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref SendLobbyNativeInviteRequestedCallbackInfo data) { }

	// RVA: 0x4E33D0 Offset: 0x4E25D0 VA: 0x1804E33D0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref SendLobbyNativeInviteRequestedCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref SendLobbyNativeInviteRequestedCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Lobby
[UnmanagedFunctionPointer(2)]
internal sealed class OnSendLobbyNativeInviteRequestedCallbackInternal : MulticastDelegate // TypeDefIndex: 9335
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref SendLobbyNativeInviteRequestedCallbackInfoInternal data) { }

	// RVA: 0x4E3340 Offset: 0x4E2540 VA: 0x1804E3340 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref SendLobbyNativeInviteRequestedCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref SendLobbyNativeInviteRequestedCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Lobby
public sealed class OnUpdateLobbyCallback : MulticastDelegate // TypeDefIndex: 9336
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref UpdateLobbyCallbackInfo data) { }

	// RVA: 0x4E34F0 Offset: 0x4E26F0 VA: 0x1804E34F0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref UpdateLobbyCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref UpdateLobbyCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Lobby
[UnmanagedFunctionPointer(2)]
internal sealed class OnUpdateLobbyCallbackInternal : MulticastDelegate // TypeDefIndex: 9337
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref UpdateLobbyCallbackInfoInternal data) { }

	// RVA: 0x4E3460 Offset: 0x4E2660 VA: 0x1804E3460 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref UpdateLobbyCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref UpdateLobbyCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Lobby
public struct ParseConnectStringOptions // TypeDefIndex: 9338
{
	// Fields
	[CompilerGenerated]
	private Utf8String <ConnectString>k__BackingField; // 0x0

	// Properties
	public Utf8String ConnectString { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Utf8String get_ConnectString() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_ConnectString(Utf8String value) { }
}

// Namespace: Epic.OnlineServices.Lobby
internal struct ParseConnectStringOptionsInternal : ISettable<ParseConnectStringOptions>, IDisposable // TypeDefIndex: 9339
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_ConnectString; // 0x8

	// Properties
	public Utf8String ConnectString { set; }

	// Methods

	// RVA: 0x4E37F0 Offset: 0x4E29F0 VA: 0x1804E37F0
	public void set_ConnectString(Utf8String value) { }

	// RVA: 0x4E36F0 Offset: 0x4E28F0 VA: 0x1804E36F0 Slot: 4
	public void Set(ref ParseConnectStringOptions other) { }

	// RVA: 0x4E3750 Offset: 0x4E2950 VA: 0x1804E3750 Slot: 5
	public void Set(ref Nullable<ParseConnectStringOptions> other) { }

	// RVA: 0x4E36A0 Offset: 0x4E28A0 VA: 0x1804E36A0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Lobby
public struct PromoteMemberCallbackInfo : ICallbackInfo // TypeDefIndex: 9340
{
	// Fields
	[CompilerGenerated]
	private Result <ResultCode>k__BackingField; // 0x0
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x8
	[CompilerGenerated]
	private Utf8String <LobbyId>k__BackingField; // 0x10

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public Utf8String LobbyId { get; set; }

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
	public Utf8String get_LobbyId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_LobbyId(Utf8String value) { }

	// RVA: 0x4E4AC0 Offset: 0x4E3CC0 VA: 0x1804E4AC0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x4E4B10 Offset: 0x4E3D10 VA: 0x1804E4B10
	internal void Set(ref PromoteMemberCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.Lobby
internal struct PromoteMemberCallbackInfoInternal : ICallbackInfoInternal, IGettable<PromoteMemberCallbackInfo>, ISettable<PromoteMemberCallbackInfo>, IDisposable // TypeDefIndex: 9341
{
	// Fields
	private Result m_ResultCode; // 0x0
	private IntPtr m_ClientData; // 0x8
	private IntPtr m_LobbyId; // 0x10

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public Utf8String LobbyId { get; set; }

	// Methods

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	// RVA: 0x4E4920 Offset: 0x4E3B20 VA: 0x1804E4920
	public object get_ClientData() { }

	// RVA: 0x4E4A00 Offset: 0x4E3C00 VA: 0x1804E4A00
	public void set_ClientData(object value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x4E4990 Offset: 0x4E3B90 VA: 0x1804E4990
	public Utf8String get_LobbyId() { }

	// RVA: 0x4E4A60 Offset: 0x4E3C60 VA: 0x1804E4A60
	public void set_LobbyId(Utf8String value) { }

	// RVA: 0x4E4870 Offset: 0x4E3A70 VA: 0x1804E4870 Slot: 6
	public void Set(ref PromoteMemberCallbackInfo other) { }

	// RVA: 0x4E4750 Offset: 0x4E3950 VA: 0x1804E4750 Slot: 7
	public void Set(ref Nullable<PromoteMemberCallbackInfo> other) { }

	// RVA: 0x4E46D0 Offset: 0x4E38D0 VA: 0x1804E46D0 Slot: 8
	public void Dispose() { }

	// RVA: 0x4E4730 Offset: 0x4E3930 VA: 0x1804E4730 Slot: 5
	public void Get(out PromoteMemberCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.Lobby
public struct PromoteMemberOptions // TypeDefIndex: 9342
{
	// Fields
	[CompilerGenerated]
	private Utf8String <LobbyId>k__BackingField; // 0x0
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x8
	[CompilerGenerated]
	private ProductUserId <TargetUserId>k__BackingField; // 0x10

	// Properties
	public Utf8String LobbyId { get; set; }
	public ProductUserId LocalUserId { get; set; }
	public ProductUserId TargetUserId { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Utf8String get_LobbyId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_LobbyId(Utf8String value) { }

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
	public ProductUserId get_TargetUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_TargetUserId(ProductUserId value) { }
}

// Namespace: Epic.OnlineServices.Lobby
internal struct PromoteMemberOptionsInternal : ISettable<PromoteMemberOptions>, IDisposable // TypeDefIndex: 9343
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LobbyId; // 0x8
	private IntPtr m_LocalUserId; // 0x10
	private IntPtr m_TargetUserId; // 0x18

	// Properties
	public Utf8String LobbyId { set; }
	public ProductUserId LocalUserId { set; }
	public ProductUserId TargetUserId { set; }

	// Methods

	// RVA: 0x4E4EB0 Offset: 0x4E40B0 VA: 0x1804E4EB0
	public void set_LobbyId(Utf8String value) { }

	// RVA: 0x4E4F10 Offset: 0x4E4110 VA: 0x1804E4F10
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x4E4F70 Offset: 0x4E4170 VA: 0x1804E4F70
	public void set_TargetUserId(ProductUserId value) { }

	// RVA: 0x4E4DB0 Offset: 0x4E3FB0 VA: 0x1804E4DB0 Slot: 4
	public void Set(ref PromoteMemberOptions other) { }

	// RVA: 0x4E4C50 Offset: 0x4E3E50 VA: 0x1804E4C50 Slot: 5
	public void Set(ref Nullable<PromoteMemberOptions> other) { }

	// RVA: 0x4E4BF0 Offset: 0x4E3DF0 VA: 0x1804E4BF0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Lobby
public struct QueryInvitesCallbackInfo : ICallbackInfo // TypeDefIndex: 9344
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

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x4E5960 Offset: 0x4E4B60 VA: 0x1804E5960 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x4E59B0 Offset: 0x4E4BB0 VA: 0x1804E59B0
	internal void Set(ref QueryInvitesCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.Lobby
internal struct QueryInvitesCallbackInfoInternal : ICallbackInfoInternal, IGettable<QueryInvitesCallbackInfo>, ISettable<QueryInvitesCallbackInfo>, IDisposable // TypeDefIndex: 9345
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

	// RVA: 0x4E57B0 Offset: 0x4E49B0 VA: 0x1804E57B0
	public object get_ClientData() { }

	// RVA: 0x4E58A0 Offset: 0x4E4AA0 VA: 0x1804E58A0
	public void set_ClientData(object value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x4E5820 Offset: 0x4E4A20 VA: 0x1804E5820
	public ProductUserId get_LocalUserId() { }

	// RVA: 0x4E5900 Offset: 0x4E4B00 VA: 0x1804E5900
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x4E5700 Offset: 0x4E4900 VA: 0x1804E5700 Slot: 6
	public void Set(ref QueryInvitesCallbackInfo other) { }

	// RVA: 0x4E55E0 Offset: 0x4E47E0 VA: 0x1804E55E0 Slot: 7
	public void Set(ref Nullable<QueryInvitesCallbackInfo> other) { }

	// RVA: 0x4E5560 Offset: 0x4E4760 VA: 0x1804E5560 Slot: 8
	public void Dispose() { }

	// RVA: 0x4E55C0 Offset: 0x4E47C0 VA: 0x1804E55C0 Slot: 5
	public void Get(out QueryInvitesCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.Lobby
public struct QueryInvitesOptions // TypeDefIndex: 9346
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

// Namespace: Epic.OnlineServices.Lobby
internal struct QueryInvitesOptionsInternal : ISettable<QueryInvitesOptions>, IDisposable // TypeDefIndex: 9347
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8

	// Properties
	public ProductUserId LocalUserId { set; }

	// Methods

	// RVA: 0x4E5B90 Offset: 0x4E4D90 VA: 0x1804E5B90
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x4E5B30 Offset: 0x4E4D30 VA: 0x1804E5B30 Slot: 4
	public void Set(ref QueryInvitesOptions other) { }

	// RVA: 0x4E5A90 Offset: 0x4E4C90 VA: 0x1804E5A90 Slot: 5
	public void Set(ref Nullable<QueryInvitesOptions> other) { }

	// RVA: 0x4E5A40 Offset: 0x4E4C40 VA: 0x1804E5A40 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Lobby
public struct RejectInviteCallbackInfo : ICallbackInfo // TypeDefIndex: 9348
{
	// Fields
	[CompilerGenerated]
	private Result <ResultCode>k__BackingField; // 0x0
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x8
	[CompilerGenerated]
	private Utf8String <InviteId>k__BackingField; // 0x10

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public Utf8String InviteId { get; set; }

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
	public Utf8String get_InviteId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_InviteId(Utf8String value) { }

	// RVA: 0x4E8380 Offset: 0x4E7580 VA: 0x1804E8380 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x4E83D0 Offset: 0x4E75D0 VA: 0x1804E83D0
	internal void Set(ref RejectInviteCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.Lobby
internal struct RejectInviteCallbackInfoInternal : ICallbackInfoInternal, IGettable<RejectInviteCallbackInfo>, ISettable<RejectInviteCallbackInfo>, IDisposable // TypeDefIndex: 9349
{
	// Fields
	private Result m_ResultCode; // 0x0
	private IntPtr m_ClientData; // 0x8
	private IntPtr m_InviteId; // 0x10

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public Utf8String InviteId { get; set; }

	// Methods

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	// RVA: 0x4E81E0 Offset: 0x4E73E0 VA: 0x1804E81E0
	public object get_ClientData() { }

	// RVA: 0x4E82C0 Offset: 0x4E74C0 VA: 0x1804E82C0
	public void set_ClientData(object value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x4E8250 Offset: 0x4E7450 VA: 0x1804E8250
	public Utf8String get_InviteId() { }

	// RVA: 0x4E8320 Offset: 0x4E7520 VA: 0x1804E8320
	public void set_InviteId(Utf8String value) { }

	// RVA: 0x4E8010 Offset: 0x4E7210 VA: 0x1804E8010 Slot: 6
	public void Set(ref RejectInviteCallbackInfo other) { }

	// RVA: 0x4E80C0 Offset: 0x4E72C0 VA: 0x1804E80C0 Slot: 7
	public void Set(ref Nullable<RejectInviteCallbackInfo> other) { }

	// RVA: 0x4E7F90 Offset: 0x4E7190 VA: 0x1804E7F90 Slot: 8
	public void Dispose() { }

	// RVA: 0x4E7FF0 Offset: 0x4E71F0 VA: 0x1804E7FF0 Slot: 5
	public void Get(out RejectInviteCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.Lobby
public struct RejectInviteOptions // TypeDefIndex: 9350
{
	// Fields
	[CompilerGenerated]
	private Utf8String <InviteId>k__BackingField; // 0x0
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x8

	// Properties
	public Utf8String InviteId { get; set; }
	public ProductUserId LocalUserId { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Utf8String get_InviteId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_InviteId(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_LocalUserId(ProductUserId value) { }
}

// Namespace: Epic.OnlineServices.Lobby
internal struct RejectInviteOptionsInternal : ISettable<RejectInviteOptions>, IDisposable // TypeDefIndex: 9351
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_InviteId; // 0x8
	private IntPtr m_LocalUserId; // 0x10

	// Properties
	public Utf8String InviteId { set; }
	public ProductUserId LocalUserId { set; }

	// Methods

	// RVA: 0x4E86D0 Offset: 0x4E78D0 VA: 0x1804E86D0
	public void set_InviteId(Utf8String value) { }

	// RVA: 0x4E8730 Offset: 0x4E7930 VA: 0x1804E8730
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x4E8510 Offset: 0x4E7710 VA: 0x1804E8510 Slot: 4
	public void Set(ref RejectInviteOptions other) { }

	// RVA: 0x4E85D0 Offset: 0x4E77D0 VA: 0x1804E85D0 Slot: 5
	public void Set(ref Nullable<RejectInviteOptions> other) { }

	// RVA: 0x4E84B0 Offset: 0x4E76B0 VA: 0x1804E84B0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Lobby
public struct RTCRoomConnectionChangedCallbackInfo : ICallbackInfo // TypeDefIndex: 9352
{
	// Fields
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <LobbyId>k__BackingField; // 0x8
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x10
	[CompilerGenerated]
	private bool <IsConnected>k__BackingField; // 0x18
	[CompilerGenerated]
	private Result <DisconnectReason>k__BackingField; // 0x1C

	// Properties
	public object ClientData { get; set; }
	public Utf8String LobbyId { get; set; }
	public ProductUserId LocalUserId { get; set; }
	public bool IsConnected { get; set; }
	public Result DisconnectReason { get; set; }

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
	public Utf8String get_LobbyId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_LobbyId(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_LocalUserId(ProductUserId value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x411B20 Offset: 0x410D20 VA: 0x180411B20
	public bool get_IsConnected() { }

	[CompilerGenerated]
	// RVA: 0x411B30 Offset: 0x410D30 VA: 0x180411B30
	public void set_IsConnected(bool value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3F9110 Offset: 0x3F8310 VA: 0x1803F9110
	public Result get_DisconnectReason() { }

	[CompilerGenerated]
	// RVA: 0x3F9290 Offset: 0x3F8490 VA: 0x1803F9290
	public void set_DisconnectReason(Result value) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x4E7E50 Offset: 0x4E7050 VA: 0x1804E7E50
	internal void Set(ref RTCRoomConnectionChangedCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.Lobby
internal struct RTCRoomConnectionChangedCallbackInfoInternal : ICallbackInfoInternal, IGettable<RTCRoomConnectionChangedCallbackInfo>, ISettable<RTCRoomConnectionChangedCallbackInfo>, IDisposable // TypeDefIndex: 9353
{
	// Fields
	private IntPtr m_ClientData; // 0x0
	private IntPtr m_LobbyId; // 0x8
	private IntPtr m_LocalUserId; // 0x10
	private int m_IsConnected; // 0x18
	private Result m_DisconnectReason; // 0x1C

	// Properties
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public Utf8String LobbyId { get; set; }
	public ProductUserId LocalUserId { get; set; }
	public bool IsConnected { get; set; }
	public Result DisconnectReason { get; set; }

	// Methods

	// RVA: 0x4E7B10 Offset: 0x4E6D10 VA: 0x1804E7B10
	public object get_ClientData() { }

	// RVA: 0x4E7CD0 Offset: 0x4E6ED0 VA: 0x1804E7CD0
	public void set_ClientData(object value) { }

	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x4E7BE0 Offset: 0x4E6DE0 VA: 0x1804E7BE0
	public Utf8String get_LobbyId() { }

	// RVA: 0x4E7D90 Offset: 0x4E6F90 VA: 0x1804E7D90
	public void set_LobbyId(Utf8String value) { }

	// RVA: 0x4E7C50 Offset: 0x4E6E50 VA: 0x1804E7C50
	public ProductUserId get_LocalUserId() { }

	// RVA: 0x4E7DF0 Offset: 0x4E6FF0 VA: 0x1804E7DF0
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x4E7B80 Offset: 0x4E6D80 VA: 0x1804E7B80
	public bool get_IsConnected() { }

	// RVA: 0x4E7D30 Offset: 0x4E6F30 VA: 0x1804E7D30
	public void set_IsConnected(bool value) { }

	// RVA: 0x3F9110 Offset: 0x3F8310 VA: 0x1803F9110
	public Result get_DisconnectReason() { }

	// RVA: 0x3F9290 Offset: 0x3F8490 VA: 0x1803F9290
	public void set_DisconnectReason(Result value) { }

	// RVA: 0x4E7800 Offset: 0x4E6A00 VA: 0x1804E7800 Slot: 6
	public void Set(ref RTCRoomConnectionChangedCallbackInfo other) { }

	// RVA: 0x4E7940 Offset: 0x4E6B40 VA: 0x1804E7940 Slot: 7
	public void Set(ref Nullable<RTCRoomConnectionChangedCallbackInfo> other) { }

	// RVA: 0x4E7780 Offset: 0x4E6980 VA: 0x1804E7780 Slot: 8
	public void Dispose() { }

	// RVA: 0x4E77E0 Offset: 0x4E69E0 VA: 0x1804E77E0 Slot: 5
	public void Get(out RTCRoomConnectionChangedCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.Lobby
public struct SendInviteCallbackInfo : ICallbackInfo // TypeDefIndex: 9354
{
	// Fields
	[CompilerGenerated]
	private Result <ResultCode>k__BackingField; // 0x0
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x8
	[CompilerGenerated]
	private Utf8String <LobbyId>k__BackingField; // 0x10

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public Utf8String LobbyId { get; set; }

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
	public Utf8String get_LobbyId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_LobbyId(Utf8String value) { }

	// RVA: 0x4E92F0 Offset: 0x4E84F0 VA: 0x1804E92F0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x4E9340 Offset: 0x4E8540 VA: 0x1804E9340
	internal void Set(ref SendInviteCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.Lobby
internal struct SendInviteCallbackInfoInternal : ICallbackInfoInternal, IGettable<SendInviteCallbackInfo>, ISettable<SendInviteCallbackInfo>, IDisposable // TypeDefIndex: 9355
{
	// Fields
	private Result m_ResultCode; // 0x0
	private IntPtr m_ClientData; // 0x8
	private IntPtr m_LobbyId; // 0x10

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public Utf8String LobbyId { get; set; }

	// Methods

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	// RVA: 0x4E9150 Offset: 0x4E8350 VA: 0x1804E9150
	public object get_ClientData() { }

	// RVA: 0x4E9230 Offset: 0x4E8430 VA: 0x1804E9230
	public void set_ClientData(object value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x4E91C0 Offset: 0x4E83C0 VA: 0x1804E91C0
	public Utf8String get_LobbyId() { }

	// RVA: 0x4E9290 Offset: 0x4E8490 VA: 0x1804E9290
	public void set_LobbyId(Utf8String value) { }

	// RVA: 0x4E8F80 Offset: 0x4E8180 VA: 0x1804E8F80 Slot: 6
	public void Set(ref SendInviteCallbackInfo other) { }

	// RVA: 0x4E9030 Offset: 0x4E8230 VA: 0x1804E9030 Slot: 7
	public void Set(ref Nullable<SendInviteCallbackInfo> other) { }

	// RVA: 0x4E8F00 Offset: 0x4E8100 VA: 0x1804E8F00 Slot: 8
	public void Dispose() { }

	// RVA: 0x4E8F60 Offset: 0x4E8160 VA: 0x1804E8F60 Slot: 5
	public void Get(out SendInviteCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.Lobby
public struct SendInviteOptions // TypeDefIndex: 9356
{
	// Fields
	[CompilerGenerated]
	private Utf8String <LobbyId>k__BackingField; // 0x0
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x8
	[CompilerGenerated]
	private ProductUserId <TargetUserId>k__BackingField; // 0x10

	// Properties
	public Utf8String LobbyId { get; set; }
	public ProductUserId LocalUserId { get; set; }
	public ProductUserId TargetUserId { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Utf8String get_LobbyId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_LobbyId(Utf8String value) { }

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
	public ProductUserId get_TargetUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_TargetUserId(ProductUserId value) { }
}

// Namespace: Epic.OnlineServices.Lobby
internal struct SendInviteOptionsInternal : ISettable<SendInviteOptions>, IDisposable // TypeDefIndex: 9357
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LobbyId; // 0x8
	private IntPtr m_LocalUserId; // 0x10
	private IntPtr m_TargetUserId; // 0x18

	// Properties
	public Utf8String LobbyId { set; }
	public ProductUserId LocalUserId { set; }
	public ProductUserId TargetUserId { set; }

	// Methods

	// RVA: 0x4E96E0 Offset: 0x4E88E0 VA: 0x1804E96E0
	public void set_LobbyId(Utf8String value) { }

	// RVA: 0x4E9740 Offset: 0x4E8940 VA: 0x1804E9740
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x4E97A0 Offset: 0x4E89A0 VA: 0x1804E97A0
	public void set_TargetUserId(ProductUserId value) { }

	// RVA: 0x4E9480 Offset: 0x4E8680 VA: 0x1804E9480 Slot: 4
	public void Set(ref SendInviteOptions other) { }

	// RVA: 0x4E9580 Offset: 0x4E8780 VA: 0x1804E9580 Slot: 5
	public void Set(ref Nullable<SendInviteOptions> other) { }

	// RVA: 0x4E9420 Offset: 0x4E8620 VA: 0x1804E9420 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Lobby
public struct SendLobbyNativeInviteRequestedCallbackInfo : ICallbackInfo // TypeDefIndex: 9358
{
	// Fields
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x0
	[CompilerGenerated]
	private ulong <UiEventId>k__BackingField; // 0x8
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x10
	[CompilerGenerated]
	private Utf8String <TargetNativeAccountType>k__BackingField; // 0x18
	[CompilerGenerated]
	private Utf8String <TargetUserNativeAccountId>k__BackingField; // 0x20
	[CompilerGenerated]
	private Utf8String <LobbyId>k__BackingField; // 0x28

	// Properties
	public object ClientData { get; set; }
	public ulong UiEventId { get; set; }
	public ProductUserId LocalUserId { get; set; }
	public Utf8String TargetNativeAccountType { get; set; }
	public Utf8String TargetUserNativeAccountId { get; set; }
	public Utf8String LobbyId { get; set; }

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
	public ulong get_UiEventId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_UiEventId(ulong value) { }

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
	public Utf8String get_TargetNativeAccountType() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_TargetNativeAccountType(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public Utf8String get_TargetUserNativeAccountId() { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_TargetUserNativeAccountId(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public Utf8String get_LobbyId() { }

	[CompilerGenerated]
	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	public void set_LobbyId(Utf8String value) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x4EA060 Offset: 0x4E9260 VA: 0x1804EA060
	internal void Set(ref SendLobbyNativeInviteRequestedCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.Lobby
internal struct SendLobbyNativeInviteRequestedCallbackInfoInternal : ICallbackInfoInternal, IGettable<SendLobbyNativeInviteRequestedCallbackInfo>, ISettable<SendLobbyNativeInviteRequestedCallbackInfo>, IDisposable // TypeDefIndex: 9359
{
	// Fields
	private IntPtr m_ClientData; // 0x0
	private ulong m_UiEventId; // 0x8
	private IntPtr m_LocalUserId; // 0x10
	private IntPtr m_TargetNativeAccountType; // 0x18
	private IntPtr m_TargetUserNativeAccountId; // 0x20
	private IntPtr m_LobbyId; // 0x28

	// Properties
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public ulong UiEventId { get; set; }
	public ProductUserId LocalUserId { get; set; }
	public Utf8String TargetNativeAccountType { get; set; }
	public Utf8String TargetUserNativeAccountId { get; set; }
	public Utf8String LobbyId { get; set; }

	// Methods

	// RVA: 0x4E9C40 Offset: 0x4E8E40 VA: 0x1804E9C40
	public object get_ClientData() { }

	// RVA: 0x4E9E80 Offset: 0x4E9080 VA: 0x1804E9E80
	public void set_ClientData(object value) { }

	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public ulong get_UiEventId() { }

	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_UiEventId(ulong value) { }

	// RVA: 0x4E9D20 Offset: 0x4E8F20 VA: 0x1804E9D20
	public ProductUserId get_LocalUserId() { }

	// RVA: 0x4E9F40 Offset: 0x4E9140 VA: 0x1804E9F40
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x4E9DA0 Offset: 0x4E8FA0 VA: 0x1804E9DA0
	public Utf8String get_TargetNativeAccountType() { }

	// RVA: 0x4E9FA0 Offset: 0x4E91A0 VA: 0x1804E9FA0
	public void set_TargetNativeAccountType(Utf8String value) { }

	// RVA: 0x4E9E10 Offset: 0x4E9010 VA: 0x1804E9E10
	public Utf8String get_TargetUserNativeAccountId() { }

	// RVA: 0x4EA000 Offset: 0x4E9200 VA: 0x1804EA000
	public void set_TargetUserNativeAccountId(Utf8String value) { }

	// RVA: 0x4E9CB0 Offset: 0x4E8EB0 VA: 0x1804E9CB0
	public Utf8String get_LobbyId() { }

	// RVA: 0x4E9EE0 Offset: 0x4E90E0 VA: 0x1804E9EE0
	public void set_LobbyId(Utf8String value) { }

	// RVA: 0x4E9AC0 Offset: 0x4E8CC0 VA: 0x1804E9AC0 Slot: 6
	public void Set(ref SendLobbyNativeInviteRequestedCallbackInfo other) { }

	// RVA: 0x4E98A0 Offset: 0x4E8AA0 VA: 0x1804E98A0 Slot: 7
	public void Set(ref Nullable<SendLobbyNativeInviteRequestedCallbackInfo> other) { }

	// RVA: 0x4E9800 Offset: 0x4E8A00 VA: 0x1804E9800 Slot: 8
	public void Dispose() { }

	// RVA: 0x4E9880 Offset: 0x4E8A80 VA: 0x1804E9880 Slot: 5
	public void Get(out SendLobbyNativeInviteRequestedCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.Lobby
public struct UpdateLobbyCallbackInfo : ICallbackInfo // TypeDefIndex: 9360
{
	// Fields
	[CompilerGenerated]
	private Result <ResultCode>k__BackingField; // 0x0
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x8
	[CompilerGenerated]
	private Utf8String <LobbyId>k__BackingField; // 0x10

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public Utf8String LobbyId { get; set; }

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
	public Utf8String get_LobbyId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_LobbyId(Utf8String value) { }

	// RVA: 0x4EA5E0 Offset: 0x4E97E0 VA: 0x1804EA5E0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x4EA630 Offset: 0x4E9830 VA: 0x1804EA630
	internal void Set(ref UpdateLobbyCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.Lobby
internal struct UpdateLobbyCallbackInfoInternal : ICallbackInfoInternal, IGettable<UpdateLobbyCallbackInfo>, ISettable<UpdateLobbyCallbackInfo>, IDisposable // TypeDefIndex: 9361
{
	// Fields
	private Result m_ResultCode; // 0x0
	private IntPtr m_ClientData; // 0x8
	private IntPtr m_LobbyId; // 0x10

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public Utf8String LobbyId { get; set; }

	// Methods

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	// RVA: 0x4EA440 Offset: 0x4E9640 VA: 0x1804EA440
	public object get_ClientData() { }

	// RVA: 0x4EA520 Offset: 0x4E9720 VA: 0x1804EA520
	public void set_ClientData(object value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x4EA4B0 Offset: 0x4E96B0 VA: 0x1804EA4B0
	public Utf8String get_LobbyId() { }

	// RVA: 0x4EA580 Offset: 0x4E9780 VA: 0x1804EA580
	public void set_LobbyId(Utf8String value) { }

	// RVA: 0x4EA270 Offset: 0x4E9470 VA: 0x1804EA270 Slot: 6
	public void Set(ref UpdateLobbyCallbackInfo other) { }

	// RVA: 0x4EA320 Offset: 0x4E9520 VA: 0x1804EA320 Slot: 7
	public void Set(ref Nullable<UpdateLobbyCallbackInfo> other) { }

	// RVA: 0x4EA1F0 Offset: 0x4E93F0 VA: 0x1804EA1F0 Slot: 8
	public void Dispose() { }

	// RVA: 0x4EA250 Offset: 0x4E9450 VA: 0x1804EA250 Slot: 5
	public void Get(out UpdateLobbyCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.Lobby
public struct UpdateLobbyModificationOptions // TypeDefIndex: 9362
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <LobbyId>k__BackingField; // 0x8

	// Properties
	public ProductUserId LocalUserId { get; set; }
	public Utf8String LobbyId { get; set; }

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
	public Utf8String get_LobbyId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_LobbyId(Utf8String value) { }
}

// Namespace: Epic.OnlineServices.Lobby
internal struct UpdateLobbyModificationOptionsInternal : ISettable<UpdateLobbyModificationOptions>, IDisposable // TypeDefIndex: 9363
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_LobbyId; // 0x10

	// Properties
	public ProductUserId LocalUserId { set; }
	public Utf8String LobbyId { set; }

	// Methods

	// RVA: 0x4EA990 Offset: 0x4E9B90 VA: 0x1804EA990
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x4EA930 Offset: 0x4E9B30 VA: 0x1804EA930
	public void set_LobbyId(Utf8String value) { }

	// RVA: 0x4EA770 Offset: 0x4E9970 VA: 0x1804EA770 Slot: 4
	public void Set(ref UpdateLobbyModificationOptions other) { }

	// RVA: 0x4EA830 Offset: 0x4E9A30 VA: 0x1804EA830 Slot: 5
	public void Set(ref Nullable<UpdateLobbyModificationOptions> other) { }

	// RVA: 0x4EA710 Offset: 0x4E9910 VA: 0x1804EA710 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Lobby
public struct UpdateLobbyOptions // TypeDefIndex: 9364
{
	// Fields
	[CompilerGenerated]
	private LobbyModification <LobbyModificationHandle>k__BackingField; // 0x0

	// Properties
	public LobbyModification LobbyModificationHandle { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public LobbyModification get_LobbyModificationHandle() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_LobbyModificationHandle(LobbyModification value) { }
}

// Namespace: Epic.OnlineServices.Lobby
internal struct UpdateLobbyOptionsInternal : ISettable<UpdateLobbyOptions>, IDisposable // TypeDefIndex: 9365
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LobbyModificationHandle; // 0x8

	// Properties
	public LobbyModification LobbyModificationHandle { set; }

	// Methods

	// RVA: 0x4EAB40 Offset: 0x4E9D40 VA: 0x1804EAB40
	public void set_LobbyModificationHandle(LobbyModification value) { }

	// RVA: 0x4EAA40 Offset: 0x4E9C40 VA: 0x1804EAA40 Slot: 4
	public void Set(ref UpdateLobbyOptions other) { }

	// RVA: 0x4EAAA0 Offset: 0x4E9CA0 VA: 0x1804EAAA0 Slot: 5
	public void Set(ref Nullable<UpdateLobbyOptions> other) { }

	// RVA: 0x4EA9F0 Offset: 0x4E9BF0 VA: 0x1804EA9F0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Leaderboards
public struct CopyLeaderboardDefinitionByIndexOptions // TypeDefIndex: 9366
{
	// Fields
	[CompilerGenerated]
	private uint <LeaderboardIndex>k__BackingField; // 0x0

	// Properties
	public uint LeaderboardIndex { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public uint get_LeaderboardIndex() { }

	[CompilerGenerated]
	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_LeaderboardIndex(uint value) { }
}

// Namespace: Epic.OnlineServices.Leaderboards
internal struct CopyLeaderboardDefinitionByIndexOptionsInternal : ISettable<CopyLeaderboardDefinitionByIndexOptions>, IDisposable // TypeDefIndex: 9367
{
	// Fields
	private int m_ApiVersion; // 0x0
	private uint m_LeaderboardIndex; // 0x4

	// Properties
	public uint LeaderboardIndex { set; }

	// Methods

	// RVA: 0x3F84A0 Offset: 0x3F76A0 VA: 0x1803F84A0
	public void set_LeaderboardIndex(uint value) { }

	// RVA: 0x40B2E0 Offset: 0x40A4E0 VA: 0x18040B2E0 Slot: 4
	public void Set(ref CopyLeaderboardDefinitionByIndexOptions other) { }

	// RVA: 0x4D4360 Offset: 0x4D3560 VA: 0x1804D4360 Slot: 5
	public void Set(ref Nullable<CopyLeaderboardDefinitionByIndexOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Leaderboards
public struct CopyLeaderboardDefinitionByLeaderboardIdOptions // TypeDefIndex: 9368
{
	// Fields
	[CompilerGenerated]
	private Utf8String <LeaderboardId>k__BackingField; // 0x0

	// Properties
	public Utf8String LeaderboardId { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Utf8String get_LeaderboardId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_LeaderboardId(Utf8String value) { }
}

// Namespace: Epic.OnlineServices.Leaderboards
internal struct CopyLeaderboardDefinitionByLeaderboardIdOptionsInternal : ISettable<CopyLeaderboardDefinitionByLeaderboardIdOptions>, IDisposable // TypeDefIndex: 9369
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LeaderboardId; // 0x8

	// Properties
	public Utf8String LeaderboardId { set; }

	// Methods

	// RVA: 0x4D4510 Offset: 0x4D3710 VA: 0x1804D4510
	public void set_LeaderboardId(Utf8String value) { }

	// RVA: 0x4D44B0 Offset: 0x4D36B0 VA: 0x1804D44B0 Slot: 4
	public void Set(ref CopyLeaderboardDefinitionByLeaderboardIdOptions other) { }

	// RVA: 0x4D4410 Offset: 0x4D3610 VA: 0x1804D4410 Slot: 5
	public void Set(ref Nullable<CopyLeaderboardDefinitionByLeaderboardIdOptions> other) { }

	// RVA: 0x4D43C0 Offset: 0x4D35C0 VA: 0x1804D43C0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Leaderboards
public struct CopyLeaderboardRecordByIndexOptions // TypeDefIndex: 9370
{
	// Fields
	[CompilerGenerated]
	private uint <LeaderboardRecordIndex>k__BackingField; // 0x0

	// Properties
	public uint LeaderboardRecordIndex { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public uint get_LeaderboardRecordIndex() { }

	[CompilerGenerated]
	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_LeaderboardRecordIndex(uint value) { }
}

// Namespace: Epic.OnlineServices.Leaderboards
internal struct CopyLeaderboardRecordByIndexOptionsInternal : ISettable<CopyLeaderboardRecordByIndexOptions>, IDisposable // TypeDefIndex: 9371
{
	// Fields
	private int m_ApiVersion; // 0x0
	private uint m_LeaderboardRecordIndex; // 0x4

	// Properties
	public uint LeaderboardRecordIndex { set; }

	// Methods

	// RVA: 0x3F84A0 Offset: 0x3F76A0 VA: 0x1803F84A0
	public void set_LeaderboardRecordIndex(uint value) { }

	// RVA: 0x442680 Offset: 0x441880 VA: 0x180442680 Slot: 4
	public void Set(ref CopyLeaderboardRecordByIndexOptions other) { }

	// RVA: 0x4D4570 Offset: 0x4D3770 VA: 0x1804D4570 Slot: 5
	public void Set(ref Nullable<CopyLeaderboardRecordByIndexOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Leaderboards
public struct CopyLeaderboardRecordByUserIdOptions // TypeDefIndex: 9372
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <UserId>k__BackingField; // 0x0

	// Properties
	public ProductUserId UserId { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public ProductUserId get_UserId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_UserId(ProductUserId value) { }
}

// Namespace: Epic.OnlineServices.Leaderboards
internal struct CopyLeaderboardRecordByUserIdOptionsInternal : ISettable<CopyLeaderboardRecordByUserIdOptions>, IDisposable // TypeDefIndex: 9373
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_UserId; // 0x8

	// Properties
	public ProductUserId UserId { set; }

	// Methods

	// RVA: 0x4D4720 Offset: 0x4D3920 VA: 0x1804D4720
	public void set_UserId(ProductUserId value) { }

	// RVA: 0x4D46C0 Offset: 0x4D38C0 VA: 0x1804D46C0 Slot: 4
	public void Set(ref CopyLeaderboardRecordByUserIdOptions other) { }

	// RVA: 0x4D4620 Offset: 0x4D3820 VA: 0x1804D4620 Slot: 5
	public void Set(ref Nullable<CopyLeaderboardRecordByUserIdOptions> other) { }

	// RVA: 0x4D45D0 Offset: 0x4D37D0 VA: 0x1804D45D0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Leaderboards
public struct CopyLeaderboardUserScoreByIndexOptions // TypeDefIndex: 9374
{
	// Fields
	[CompilerGenerated]
	private uint <LeaderboardUserScoreIndex>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <StatName>k__BackingField; // 0x8

	// Properties
	public uint LeaderboardUserScoreIndex { get; set; }
	public Utf8String StatName { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public uint get_LeaderboardUserScoreIndex() { }

	[CompilerGenerated]
	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_LeaderboardUserScoreIndex(uint value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public Utf8String get_StatName() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_StatName(Utf8String value) { }
}

// Namespace: Epic.OnlineServices.Leaderboards
internal struct CopyLeaderboardUserScoreByIndexOptionsInternal : ISettable<CopyLeaderboardUserScoreByIndexOptions>, IDisposable // TypeDefIndex: 9375
{
	// Fields
	private int m_ApiVersion; // 0x0
	private uint m_LeaderboardUserScoreIndex; // 0x4
	private IntPtr m_StatName; // 0x8

	// Properties
	public uint LeaderboardUserScoreIndex { set; }
	public Utf8String StatName { set; }

	// Methods

	// RVA: 0x3F84A0 Offset: 0x3F76A0 VA: 0x1803F84A0
	public void set_LeaderboardUserScoreIndex(uint value) { }

	// RVA: 0x4D4900 Offset: 0x4D3B00 VA: 0x1804D4900
	public void set_StatName(Utf8String value) { }

	// RVA: 0x4D47D0 Offset: 0x4D39D0 VA: 0x1804D47D0 Slot: 4
	public void Set(ref CopyLeaderboardUserScoreByIndexOptions other) { }

	// RVA: 0x4D4840 Offset: 0x4D3A40 VA: 0x1804D4840 Slot: 5
	public void Set(ref Nullable<CopyLeaderboardUserScoreByIndexOptions> other) { }

	// RVA: 0x4D4780 Offset: 0x4D3980 VA: 0x1804D4780 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Leaderboards
public struct CopyLeaderboardUserScoreByUserIdOptions // TypeDefIndex: 9376
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <UserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <StatName>k__BackingField; // 0x8

	// Properties
	public ProductUserId UserId { get; set; }
	public Utf8String StatName { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public ProductUserId get_UserId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_UserId(ProductUserId value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public Utf8String get_StatName() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_StatName(Utf8String value) { }
}

// Namespace: Epic.OnlineServices.Leaderboards
internal struct CopyLeaderboardUserScoreByUserIdOptionsInternal : ISettable<CopyLeaderboardUserScoreByUserIdOptions>, IDisposable // TypeDefIndex: 9377
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_UserId; // 0x8
	private IntPtr m_StatName; // 0x10

	// Properties
	public ProductUserId UserId { set; }
	public Utf8String StatName { set; }

	// Methods

	// RVA: 0x4D4BE0 Offset: 0x4D3DE0 VA: 0x1804D4BE0
	public void set_UserId(ProductUserId value) { }

	// RVA: 0x4D4B80 Offset: 0x4D3D80 VA: 0x1804D4B80
	public void set_StatName(Utf8String value) { }

	// RVA: 0x4D4AC0 Offset: 0x4D3CC0 VA: 0x1804D4AC0 Slot: 4
	public void Set(ref CopyLeaderboardUserScoreByUserIdOptions other) { }

	// RVA: 0x4D49C0 Offset: 0x4D3BC0 VA: 0x1804D49C0 Slot: 5
	public void Set(ref Nullable<CopyLeaderboardUserScoreByUserIdOptions> other) { }

	// RVA: 0x4D4960 Offset: 0x4D3B60 VA: 0x1804D4960 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Leaderboards
public struct Definition // TypeDefIndex: 9378
{
	// Fields
	[CompilerGenerated]
	private Utf8String <LeaderboardId>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <StatName>k__BackingField; // 0x8
	[CompilerGenerated]
	private LeaderboardAggregation <Aggregation>k__BackingField; // 0x10
	[CompilerGenerated]
	private Nullable<DateTimeOffset> <StartTime>k__BackingField; // 0x18
	[CompilerGenerated]
	private Nullable<DateTimeOffset> <EndTime>k__BackingField; // 0x30

	// Properties
	public Utf8String LeaderboardId { get; set; }
	public Utf8String StatName { get; set; }
	public LeaderboardAggregation Aggregation { get; set; }
	public Nullable<DateTimeOffset> StartTime { get; set; }
	public Nullable<DateTimeOffset> EndTime { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Utf8String get_LeaderboardId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_LeaderboardId(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public Utf8String get_StatName() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_StatName(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public LeaderboardAggregation get_Aggregation() { }

	[CompilerGenerated]
	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_Aggregation(LeaderboardAggregation value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x426510 Offset: 0x425710 VA: 0x180426510
	public Nullable<DateTimeOffset> get_StartTime() { }

	[CompilerGenerated]
	// RVA: 0x426540 Offset: 0x425740 VA: 0x180426540
	public void set_StartTime(Nullable<DateTimeOffset> value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x4D6780 Offset: 0x4D5980 VA: 0x1804D6780
	public Nullable<DateTimeOffset> get_EndTime() { }

	[CompilerGenerated]
	// RVA: 0x4D67A0 Offset: 0x4D59A0 VA: 0x1804D67A0
	public void set_EndTime(Nullable<DateTimeOffset> value) { }

	// RVA: 0x4D65D0 Offset: 0x4D57D0 VA: 0x1804D65D0
	internal void Set(ref DefinitionInternal other) { }
}

// Namespace: Epic.OnlineServices.Leaderboards
internal struct DefinitionInternal : IGettable<Definition>, ISettable<Definition>, IDisposable // TypeDefIndex: 9379
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LeaderboardId; // 0x8
	private IntPtr m_StatName; // 0x10
	private LeaderboardAggregation m_Aggregation; // 0x18
	private long m_StartTime; // 0x20
	private long m_EndTime; // 0x28

	// Properties
	public Utf8String LeaderboardId { get; set; }
	public Utf8String StatName { get; set; }
	public LeaderboardAggregation Aggregation { get; set; }
	public Nullable<DateTimeOffset> StartTime { get; set; }
	public Nullable<DateTimeOffset> EndTime { get; set; }

	// Methods

	// RVA: 0x4D62E0 Offset: 0x4D54E0 VA: 0x1804D62E0
	public Utf8String get_LeaderboardId() { }

	// RVA: 0x4D64A0 Offset: 0x4D56A0 VA: 0x1804D64A0
	public void set_LeaderboardId(Utf8String value) { }

	// RVA: 0x4D63C0 Offset: 0x4D55C0 VA: 0x1804D63C0
	public Utf8String get_StatName() { }

	// RVA: 0x4D6570 Offset: 0x4D5770 VA: 0x1804D6570
	public void set_StatName(Utf8String value) { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public LeaderboardAggregation get_Aggregation() { }

	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	public void set_Aggregation(LeaderboardAggregation value) { }

	// RVA: 0x4D6350 Offset: 0x4D5550 VA: 0x1804D6350
	public Nullable<DateTimeOffset> get_StartTime() { }

	// RVA: 0x4D6500 Offset: 0x4D5700 VA: 0x1804D6500
	public void set_StartTime(Nullable<DateTimeOffset> value) { }

	// RVA: 0x4D6270 Offset: 0x4D5470 VA: 0x1804D6270
	public Nullable<DateTimeOffset> get_EndTime() { }

	// RVA: 0x4D6430 Offset: 0x4D5630 VA: 0x1804D6430
	public void set_EndTime(Nullable<DateTimeOffset> value) { }

	// RVA: 0x4D60E0 Offset: 0x4D52E0 VA: 0x1804D60E0 Slot: 5
	public void Set(ref Definition other) { }

	// RVA: 0x4D5EE0 Offset: 0x4D50E0 VA: 0x1804D5EE0 Slot: 6
	public void Set(ref Nullable<Definition> other) { }

	// RVA: 0x4D5E50 Offset: 0x4D5050 VA: 0x1804D5E50 Slot: 7
	public void Dispose() { }

	// RVA: 0x4D5EB0 Offset: 0x4D50B0 VA: 0x1804D5EB0 Slot: 4
	public void Get(out Definition output) { }
}

// Namespace: Epic.OnlineServices.Leaderboards
public struct GetLeaderboardDefinitionCountOptions // TypeDefIndex: 9380
{}

// Namespace: Epic.OnlineServices.Leaderboards
internal struct GetLeaderboardDefinitionCountOptionsInternal : ISettable<GetLeaderboardDefinitionCountOptions>, IDisposable // TypeDefIndex: 9381
{
	// Fields
	private int m_ApiVersion; // 0x0

	// Methods

	// RVA: 0x3F98A0 Offset: 0x3F8AA0 VA: 0x1803F98A0 Slot: 4
	public void Set(ref GetLeaderboardDefinitionCountOptions other) { }

	// RVA: 0x4D67C0 Offset: 0x4D59C0 VA: 0x1804D67C0 Slot: 5
	public void Set(ref Nullable<GetLeaderboardDefinitionCountOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Leaderboards
public struct GetLeaderboardRecordCountOptions // TypeDefIndex: 9382
{}

// Namespace: Epic.OnlineServices.Leaderboards
internal struct GetLeaderboardRecordCountOptionsInternal : ISettable<GetLeaderboardRecordCountOptions>, IDisposable // TypeDefIndex: 9383
{
	// Fields
	private int m_ApiVersion; // 0x0

	// Methods

	// RVA: 0x3F98A0 Offset: 0x3F8AA0 VA: 0x1803F98A0 Slot: 4
	public void Set(ref GetLeaderboardRecordCountOptions other) { }

	// RVA: 0x4D6810 Offset: 0x4D5A10 VA: 0x1804D6810 Slot: 5
	public void Set(ref Nullable<GetLeaderboardRecordCountOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Leaderboards
public struct GetLeaderboardUserScoreCountOptions // TypeDefIndex: 9384
{
	// Fields
	[CompilerGenerated]
	private Utf8String <StatName>k__BackingField; // 0x0

	// Properties
	public Utf8String StatName { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Utf8String get_StatName() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_StatName(Utf8String value) { }
}

// Namespace: Epic.OnlineServices.Leaderboards
internal struct GetLeaderboardUserScoreCountOptionsInternal : ISettable<GetLeaderboardUserScoreCountOptions>, IDisposable // TypeDefIndex: 9385
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_StatName; // 0x8

	// Properties
	public Utf8String StatName { set; }

	// Methods

	// RVA: 0x4D69B0 Offset: 0x4D5BB0 VA: 0x1804D69B0
	public void set_StatName(Utf8String value) { }

	// RVA: 0x4D68B0 Offset: 0x4D5AB0 VA: 0x1804D68B0 Slot: 4
	public void Set(ref GetLeaderboardUserScoreCountOptions other) { }

	// RVA: 0x4D6910 Offset: 0x4D5B10 VA: 0x1804D6910 Slot: 5
	public void Set(ref Nullable<GetLeaderboardUserScoreCountOptions> other) { }

	// RVA: 0x4D6860 Offset: 0x4D5A60 VA: 0x1804D6860 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Leaderboards
public enum LeaderboardAggregation // TypeDefIndex: 9386
{
	// Fields
	public int value__; // 0x0
	public const LeaderboardAggregation Min = 0;
	public const LeaderboardAggregation Max = 1;
	public const LeaderboardAggregation Sum = 2;
	public const LeaderboardAggregation Latest = 3;
}

// Namespace: Epic.OnlineServices.Leaderboards
public struct LeaderboardRecord // TypeDefIndex: 9387
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <UserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private uint <Rank>k__BackingField; // 0x8
	[CompilerGenerated]
	private int <Score>k__BackingField; // 0xC
	[CompilerGenerated]
	private Utf8String <UserDisplayName>k__BackingField; // 0x10

	// Properties
	public ProductUserId UserId { get; set; }
	public uint Rank { get; set; }
	public int Score { get; set; }
	public Utf8String UserDisplayName { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public ProductUserId get_UserId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_UserId(ProductUserId value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3F5510 Offset: 0x3F4710 VA: 0x1803F5510
	public uint get_Rank() { }

	[CompilerGenerated]
	// RVA: 0x3F5520 Offset: 0x3F4720 VA: 0x1803F5520
	public void set_Rank(uint value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x438080 Offset: 0x437280 VA: 0x180438080
	public int get_Score() { }

	[CompilerGenerated]
	// RVA: 0x438090 Offset: 0x437290 VA: 0x180438090
	public void set_Score(int value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Utf8String get_UserDisplayName() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_UserDisplayName(Utf8String value) { }

	// RVA: 0x4D9F40 Offset: 0x4D9140 VA: 0x1804D9F40
	internal void Set(ref LeaderboardRecordInternal other) { }
}

// Namespace: Epic.OnlineServices.Leaderboards
internal struct LeaderboardRecordInternal : IGettable<LeaderboardRecord>, ISettable<LeaderboardRecord>, IDisposable // TypeDefIndex: 9388
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_UserId; // 0x8
	private uint m_Rank; // 0x10
	private int m_Score; // 0x14
	private IntPtr m_UserDisplayName; // 0x18

	// Properties
	public ProductUserId UserId { get; set; }
	public uint Rank { get; set; }
	public int Score { get; set; }
	public Utf8String UserDisplayName { get; set; }

	// Methods

	// RVA: 0x4D9E00 Offset: 0x4D9000 VA: 0x1804D9E00
	public ProductUserId get_UserId() { }

	// RVA: 0x4D9EE0 Offset: 0x4D90E0 VA: 0x1804D9EE0
	public void set_UserId(ProductUserId value) { }

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public uint get_Rank() { }

	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_Rank(uint value) { }

	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500
	public int get_Score() { }

	// RVA: 0x426530 Offset: 0x425730 VA: 0x180426530
	public void set_Score(int value) { }

	// RVA: 0x4D9D90 Offset: 0x4D8F90 VA: 0x1804D9D90
	public Utf8String get_UserDisplayName() { }

	// RVA: 0x4D9E80 Offset: 0x4D9080 VA: 0x1804D9E80
	public void set_UserDisplayName(Utf8String value) { }

	// RVA: 0x4D9B90 Offset: 0x4D8D90 VA: 0x1804D9B90 Slot: 5
	public void Set(ref LeaderboardRecord other) { }

	// RVA: 0x4D9C50 Offset: 0x4D8E50 VA: 0x1804D9C50 Slot: 6
	public void Set(ref Nullable<LeaderboardRecord> other) { }

	// RVA: 0x4D9B10 Offset: 0x4D8D10 VA: 0x1804D9B10 Slot: 7
	public void Dispose() { }

	// RVA: 0x4D9B70 Offset: 0x4D8D70 VA: 0x1804D9B70 Slot: 4
	public void Get(out LeaderboardRecord output) { }
}

// Namespace: Epic.OnlineServices.Leaderboards
public sealed class LeaderboardsInterface : Handle // TypeDefIndex: 9389
{
	// Fields
	public const int CopyleaderboarddefinitionbyindexApiLatest = 1;
	public const int CopyleaderboarddefinitionbyleaderboardidApiLatest = 1;
	public const int CopyleaderboardrecordbyindexApiLatest = 2;
	public const int CopyleaderboardrecordbyuseridApiLatest = 2;
	public const int CopyleaderboarduserscorebyindexApiLatest = 1;
	public const int CopyleaderboarduserscorebyuseridApiLatest = 1;
	public const int DefinitionApiLatest = 1;
	public const int GetleaderboarddefinitioncountApiLatest = 1;
	public const int GetleaderboardrecordcountApiLatest = 1;
	public const int GetleaderboarduserscorecountApiLatest = 1;
	public const int LeaderboardrecordApiLatest = 2;
	public const int LeaderboarduserscoreApiLatest = 1;
	public const int QueryleaderboarddefinitionsApiLatest = 2;
	public const int QueryleaderboardranksApiLatest = 2;
	public const int QueryleaderboarduserscoresApiLatest = 2;
	public const int TimeUndefined = -1;
	public const int UserscoresquerystatinfoApiLatest = 1;

	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }

	// RVA: 0x40BDB0 Offset: 0x40AFB0 VA: 0x18040BDB0
	public void .ctor(IntPtr innerHandle) { }

	// RVA: 0x4DA2B0 Offset: 0x4D94B0 VA: 0x1804DA2B0
	public Result CopyLeaderboardDefinitionByIndex(ref CopyLeaderboardDefinitionByIndexOptions options, out Nullable<Definition> outLeaderboardDefinition) { }

	// RVA: 0x4DA3A0 Offset: 0x4D95A0 VA: 0x1804DA3A0
	public Result CopyLeaderboardDefinitionByLeaderboardId(ref CopyLeaderboardDefinitionByLeaderboardIdOptions options, out Nullable<Definition> outLeaderboardDefinition) { }

	// RVA: 0x4DA4D0 Offset: 0x4D96D0 VA: 0x1804DA4D0
	public Result CopyLeaderboardRecordByIndex(ref CopyLeaderboardRecordByIndexOptions options, out Nullable<LeaderboardRecord> outLeaderboardRecord) { }

	// RVA: 0x4DA5C0 Offset: 0x4D97C0 VA: 0x1804DA5C0
	public Result CopyLeaderboardRecordByUserId(ref CopyLeaderboardRecordByUserIdOptions options, out Nullable<LeaderboardRecord> outLeaderboardRecord) { }

	// RVA: 0x4DA6F0 Offset: 0x4D98F0 VA: 0x1804DA6F0
	public Result CopyLeaderboardUserScoreByIndex(ref CopyLeaderboardUserScoreByIndexOptions options, out Nullable<LeaderboardUserScore> outLeaderboardUserScore) { }

	// RVA: 0x4DA830 Offset: 0x4D9A30 VA: 0x1804DA830
	public Result CopyLeaderboardUserScoreByUserId(ref CopyLeaderboardUserScoreByUserIdOptions options, out Nullable<LeaderboardUserScore> outLeaderboardUserScore) { }

	// RVA: 0x4DA930 Offset: 0x4D9B30 VA: 0x1804DA930
	public uint GetLeaderboardDefinitionCount(ref GetLeaderboardDefinitionCountOptions options) { }

	// RVA: 0x4DA9B0 Offset: 0x4D9BB0 VA: 0x1804DA9B0
	public uint GetLeaderboardRecordCount(ref GetLeaderboardRecordCountOptions options) { }

	// RVA: 0x4DAA30 Offset: 0x4D9C30 VA: 0x1804DAA30
	public uint GetLeaderboardUserScoreCount(ref GetLeaderboardUserScoreCountOptions options) { }

	// RVA: 0x4DAD00 Offset: 0x4D9F00 VA: 0x1804DAD00
	public void QueryLeaderboardDefinitions(ref QueryLeaderboardDefinitionsOptions options, object clientData, OnQueryLeaderboardDefinitionsCompleteCallback completionDelegate) { }

	// RVA: 0x4DAEB0 Offset: 0x4DA0B0 VA: 0x1804DAEB0
	public void QueryLeaderboardRanks(ref QueryLeaderboardRanksOptions options, object clientData, OnQueryLeaderboardRanksCompleteCallback completionDelegate) { }

	// RVA: 0x4DB060 Offset: 0x4DA260 VA: 0x1804DB060
	public void QueryLeaderboardUserScores(ref QueryLeaderboardUserScoresOptions options, object clientData, OnQueryLeaderboardUserScoresCompleteCallback completionDelegate) { }

	[MonoPInvokeCallback(typeof(OnQueryLeaderboardDefinitionsCompleteCallbackInternal))]
	// RVA: 0x4DAB10 Offset: 0x4D9D10 VA: 0x1804DAB10
	internal static void OnQueryLeaderboardDefinitionsCompleteCallbackInternalImplementation(ref OnQueryLeaderboardDefinitionsCompleteCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnQueryLeaderboardRanksCompleteCallbackInternal))]
	// RVA: 0x4DABB0 Offset: 0x4D9DB0 VA: 0x1804DABB0
	internal static void OnQueryLeaderboardRanksCompleteCallbackInternalImplementation(ref OnQueryLeaderboardRanksCompleteCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnQueryLeaderboardUserScoresCompleteCallbackInternal))]
	// RVA: 0x4DAC60 Offset: 0x4D9E60 VA: 0x1804DAC60
	internal static void OnQueryLeaderboardUserScoresCompleteCallbackInternalImplementation(ref OnQueryLeaderboardUserScoresCompleteCallbackInfoInternal data) { }
}

// Namespace: Epic.OnlineServices.Leaderboards
public struct LeaderboardUserScore // TypeDefIndex: 9390
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <UserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private int <Score>k__BackingField; // 0x8

	// Properties
	public ProductUserId UserId { get; set; }
	public int Score { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public ProductUserId get_UserId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_UserId(ProductUserId value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3F5510 Offset: 0x3F4710 VA: 0x1803F5510
	public int get_Score() { }

	[CompilerGenerated]
	// RVA: 0x3F5520 Offset: 0x3F4720 VA: 0x1803F5520
	public void set_Score(int value) { }

	// RVA: 0x4DA280 Offset: 0x4D9480 VA: 0x1804DA280
	internal void Set(ref LeaderboardUserScoreInternal other) { }
}

// Namespace: Epic.OnlineServices.Leaderboards
internal struct LeaderboardUserScoreInternal : IGettable<LeaderboardUserScore>, ISettable<LeaderboardUserScore>, IDisposable // TypeDefIndex: 9391
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_UserId; // 0x8
	private int m_Score; // 0x10

	// Properties
	public ProductUserId UserId { get; set; }
	public int Score { get; set; }

	// Methods

	// RVA: 0x4DA1A0 Offset: 0x4D93A0 VA: 0x1804DA1A0
	public ProductUserId get_UserId() { }

	// RVA: 0x4DA220 Offset: 0x4D9420 VA: 0x1804DA220
	public void set_UserId(ProductUserId value) { }

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public int get_Score() { }

	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_Score(int value) { }

	// RVA: 0x4DA060 Offset: 0x4D9260 VA: 0x1804DA060 Slot: 5
	public void Set(ref LeaderboardUserScore other) { }

	// RVA: 0x4DA0E0 Offset: 0x4D92E0 VA: 0x1804DA0E0 Slot: 6
	public void Set(ref Nullable<LeaderboardUserScore> other) { }

	// RVA: 0x4D9FD0 Offset: 0x4D91D0 VA: 0x1804D9FD0 Slot: 7
	public void Dispose() { }

	// RVA: 0x4DA020 Offset: 0x4D9220 VA: 0x1804DA020 Slot: 4
	public void Get(out LeaderboardUserScore output) { }
}

// Namespace: Epic.OnlineServices.Leaderboards
public sealed class OnQueryLeaderboardDefinitionsCompleteCallback : MulticastDelegate // TypeDefIndex: 9392
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref OnQueryLeaderboardDefinitionsCompleteCallbackInfo data) { }

	// RVA: 0x4E2280 Offset: 0x4E1480 VA: 0x1804E2280 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref OnQueryLeaderboardDefinitionsCompleteCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref OnQueryLeaderboardDefinitionsCompleteCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Leaderboards
[UnmanagedFunctionPointer(2)]
internal sealed class OnQueryLeaderboardDefinitionsCompleteCallbackInternal : MulticastDelegate // TypeDefIndex: 9393
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref OnQueryLeaderboardDefinitionsCompleteCallbackInfoInternal data) { }

	// RVA: 0x4E21F0 Offset: 0x4E13F0 VA: 0x1804E21F0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref OnQueryLeaderboardDefinitionsCompleteCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref OnQueryLeaderboardDefinitionsCompleteCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Leaderboards
public struct OnQueryLeaderboardDefinitionsCompleteCallbackInfo : ICallbackInfo // TypeDefIndex: 9394
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

	// RVA: 0x4E2120 Offset: 0x4E1320 VA: 0x1804E2120 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x4E2170 Offset: 0x4E1370 VA: 0x1804E2170
	internal void Set(ref OnQueryLeaderboardDefinitionsCompleteCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.Leaderboards
internal struct OnQueryLeaderboardDefinitionsCompleteCallbackInfoInternal : ICallbackInfoInternal, IGettable<OnQueryLeaderboardDefinitionsCompleteCallbackInfo>, ISettable<OnQueryLeaderboardDefinitionsCompleteCallbackInfo>, IDisposable // TypeDefIndex: 9395
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

	// RVA: 0x4E2050 Offset: 0x4E1250 VA: 0x1804E2050
	public object get_ClientData() { }

	// RVA: 0x4E20C0 Offset: 0x4E12C0 VA: 0x1804E20C0
	public void set_ClientData(object value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x4E1FF0 Offset: 0x4E11F0 VA: 0x1804E1FF0 Slot: 6
	public void Set(ref OnQueryLeaderboardDefinitionsCompleteCallbackInfo other) { }

	// RVA: 0x4E1F30 Offset: 0x4E1130 VA: 0x1804E1F30 Slot: 7
	public void Set(ref Nullable<OnQueryLeaderboardDefinitionsCompleteCallbackInfo> other) { }

	// RVA: 0x4E1EC0 Offset: 0x4E10C0 VA: 0x1804E1EC0 Slot: 8
	public void Dispose() { }

	// RVA: 0x4E1F10 Offset: 0x4E1110 VA: 0x1804E1F10 Slot: 5
	public void Get(out OnQueryLeaderboardDefinitionsCompleteCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.Leaderboards
public sealed class OnQueryLeaderboardRanksCompleteCallback : MulticastDelegate // TypeDefIndex: 9396
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref OnQueryLeaderboardRanksCompleteCallbackInfo data) { }

	// RVA: 0x4E28C0 Offset: 0x4E1AC0 VA: 0x1804E28C0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref OnQueryLeaderboardRanksCompleteCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref OnQueryLeaderboardRanksCompleteCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Leaderboards
[UnmanagedFunctionPointer(2)]
internal sealed class OnQueryLeaderboardRanksCompleteCallbackInternal : MulticastDelegate // TypeDefIndex: 9397
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref OnQueryLeaderboardRanksCompleteCallbackInfoInternal data) { }

	// RVA: 0x4E2830 Offset: 0x4E1A30 VA: 0x1804E2830 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref OnQueryLeaderboardRanksCompleteCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref OnQueryLeaderboardRanksCompleteCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Leaderboards
public struct OnQueryLeaderboardRanksCompleteCallbackInfo : ICallbackInfo // TypeDefIndex: 9398
{
	// Fields
	[CompilerGenerated]
	private Result <ResultCode>k__BackingField; // 0x0
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x8
	[CompilerGenerated]
	private Utf8String <LeaderboardId>k__BackingField; // 0x10

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public Utf8String LeaderboardId { get; set; }

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
	public Utf8String get_LeaderboardId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_LeaderboardId(Utf8String value) { }

	// RVA: 0x4E2700 Offset: 0x4E1900 VA: 0x1804E2700 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x4E2750 Offset: 0x4E1950 VA: 0x1804E2750
	internal void Set(ref OnQueryLeaderboardRanksCompleteCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.Leaderboards
internal struct OnQueryLeaderboardRanksCompleteCallbackInfoInternal : ICallbackInfoInternal, IGettable<OnQueryLeaderboardRanksCompleteCallbackInfo>, ISettable<OnQueryLeaderboardRanksCompleteCallbackInfo>, IDisposable // TypeDefIndex: 9399
{
	// Fields
	private Result m_ResultCode; // 0x0
	private IntPtr m_ClientData; // 0x8
	private IntPtr m_LeaderboardId; // 0x10

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public Utf8String LeaderboardId { get; set; }

	// Methods

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	// RVA: 0x4E2560 Offset: 0x4E1760 VA: 0x1804E2560
	public object get_ClientData() { }

	// RVA: 0x4E2640 Offset: 0x4E1840 VA: 0x1804E2640
	public void set_ClientData(object value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x4E25D0 Offset: 0x4E17D0 VA: 0x1804E25D0
	public Utf8String get_LeaderboardId() { }

	// RVA: 0x4E26A0 Offset: 0x4E18A0 VA: 0x1804E26A0
	public void set_LeaderboardId(Utf8String value) { }

	// RVA: 0x4E24B0 Offset: 0x4E16B0 VA: 0x1804E24B0 Slot: 6
	public void Set(ref OnQueryLeaderboardRanksCompleteCallbackInfo other) { }

	// RVA: 0x4E2390 Offset: 0x4E1590 VA: 0x1804E2390 Slot: 7
	public void Set(ref Nullable<OnQueryLeaderboardRanksCompleteCallbackInfo> other) { }

	// RVA: 0x4E2310 Offset: 0x4E1510 VA: 0x1804E2310 Slot: 8
	public void Dispose() { }

	// RVA: 0x4E2370 Offset: 0x4E1570 VA: 0x1804E2370 Slot: 5
	public void Get(out OnQueryLeaderboardRanksCompleteCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.Leaderboards
public sealed class OnQueryLeaderboardUserScoresCompleteCallback : MulticastDelegate // TypeDefIndex: 9400
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref OnQueryLeaderboardUserScoresCompleteCallbackInfo data) { }

	// RVA: 0x4E2D10 Offset: 0x4E1F10 VA: 0x1804E2D10 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref OnQueryLeaderboardUserScoresCompleteCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref OnQueryLeaderboardUserScoresCompleteCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Leaderboards
[UnmanagedFunctionPointer(2)]
internal sealed class OnQueryLeaderboardUserScoresCompleteCallbackInternal : MulticastDelegate // TypeDefIndex: 9401
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref OnQueryLeaderboardUserScoresCompleteCallbackInfoInternal data) { }

	// RVA: 0x4E2C80 Offset: 0x4E1E80 VA: 0x1804E2C80 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref OnQueryLeaderboardUserScoresCompleteCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref OnQueryLeaderboardUserScoresCompleteCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Leaderboards
public struct OnQueryLeaderboardUserScoresCompleteCallbackInfo : ICallbackInfo // TypeDefIndex: 9402
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

	// RVA: 0x4E2BB0 Offset: 0x4E1DB0 VA: 0x1804E2BB0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x4E2C00 Offset: 0x4E1E00 VA: 0x1804E2C00
	internal void Set(ref OnQueryLeaderboardUserScoresCompleteCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.Leaderboards
internal struct OnQueryLeaderboardUserScoresCompleteCallbackInfoInternal : ICallbackInfoInternal, IGettable<OnQueryLeaderboardUserScoresCompleteCallbackInfo>, ISettable<OnQueryLeaderboardUserScoresCompleteCallbackInfo>, IDisposable // TypeDefIndex: 9403
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

	// RVA: 0x4E2AE0 Offset: 0x4E1CE0 VA: 0x1804E2AE0
	public object get_ClientData() { }

	// RVA: 0x4E2B50 Offset: 0x4E1D50 VA: 0x1804E2B50
	public void set_ClientData(object value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x4E2A80 Offset: 0x4E1C80 VA: 0x1804E2A80 Slot: 6
	public void Set(ref OnQueryLeaderboardUserScoresCompleteCallbackInfo other) { }

	// RVA: 0x4E29C0 Offset: 0x4E1BC0 VA: 0x1804E29C0 Slot: 7
	public void Set(ref Nullable<OnQueryLeaderboardUserScoresCompleteCallbackInfo> other) { }

	// RVA: 0x4E2950 Offset: 0x4E1B50 VA: 0x1804E2950 Slot: 8
	public void Dispose() { }

	// RVA: 0x4E29A0 Offset: 0x4E1BA0 VA: 0x1804E29A0 Slot: 5
	public void Get(out OnQueryLeaderboardUserScoresCompleteCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.Leaderboards
public struct QueryLeaderboardDefinitionsOptions // TypeDefIndex: 9404
{
	// Fields
	[CompilerGenerated]
	private Nullable<DateTimeOffset> <StartTime>k__BackingField; // 0x0
	[CompilerGenerated]
	private Nullable<DateTimeOffset> <EndTime>k__BackingField; // 0x18
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x30

	// Properties
	public Nullable<DateTimeOffset> StartTime { get; set; }
	public Nullable<DateTimeOffset> EndTime { get; set; }
	public ProductUserId LocalUserId { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x4BBD30 Offset: 0x4BAF30 VA: 0x1804BBD30
	public Nullable<DateTimeOffset> get_StartTime() { }

	[CompilerGenerated]
	// RVA: 0x4BBD50 Offset: 0x4BAF50 VA: 0x1804BBD50
	public void set_StartTime(Nullable<DateTimeOffset> value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x426510 Offset: 0x425710 VA: 0x180426510
	public Nullable<DateTimeOffset> get_EndTime() { }

	[CompilerGenerated]
	// RVA: 0x426540 Offset: 0x425740 VA: 0x180426540
	public void set_EndTime(Nullable<DateTimeOffset> value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	public void set_LocalUserId(ProductUserId value) { }
}

// Namespace: Epic.OnlineServices.Leaderboards
internal struct QueryLeaderboardDefinitionsOptionsInternal : ISettable<QueryLeaderboardDefinitionsOptions>, IDisposable // TypeDefIndex: 9405
{
	// Fields
	private int m_ApiVersion; // 0x0
	private long m_StartTime; // 0x8
	private long m_EndTime; // 0x10
	private IntPtr m_LocalUserId; // 0x18

	// Properties
	public Nullable<DateTimeOffset> StartTime { set; }
	public Nullable<DateTimeOffset> EndTime { set; }
	public ProductUserId LocalUserId { set; }

	// Methods

	// RVA: 0x4E5FE0 Offset: 0x4E51E0 VA: 0x1804E5FE0
	public void set_StartTime(Nullable<DateTimeOffset> value) { }

	// RVA: 0x4E5F10 Offset: 0x4E5110 VA: 0x1804E5F10
	public void set_EndTime(Nullable<DateTimeOffset> value) { }

	// RVA: 0x4E5F80 Offset: 0x4E5180 VA: 0x1804E5F80
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x4E5C40 Offset: 0x4E4E40 VA: 0x1804E5C40 Slot: 4
	public void Set(ref QueryLeaderboardDefinitionsOptions other) { }

	// RVA: 0x4E5D80 Offset: 0x4E4F80 VA: 0x1804E5D80 Slot: 5
	public void Set(ref Nullable<QueryLeaderboardDefinitionsOptions> other) { }

	// RVA: 0x4E5BF0 Offset: 0x4E4DF0 VA: 0x1804E5BF0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Leaderboards
public struct QueryLeaderboardRanksOptions // TypeDefIndex: 9406
{
	// Fields
	[CompilerGenerated]
	private Utf8String <LeaderboardId>k__BackingField; // 0x0
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x8

	// Properties
	public Utf8String LeaderboardId { get; set; }
	public ProductUserId LocalUserId { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Utf8String get_LeaderboardId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_LeaderboardId(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_LocalUserId(ProductUserId value) { }
}

// Namespace: Epic.OnlineServices.Leaderboards
internal struct QueryLeaderboardRanksOptionsInternal : ISettable<QueryLeaderboardRanksOptions>, IDisposable // TypeDefIndex: 9407
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LeaderboardId; // 0x8
	private IntPtr m_LocalUserId; // 0x10

	// Properties
	public Utf8String LeaderboardId { set; }
	public ProductUserId LocalUserId { set; }

	// Methods

	// RVA: 0x4E6270 Offset: 0x4E5470 VA: 0x1804E6270
	public void set_LeaderboardId(Utf8String value) { }

	// RVA: 0x4E62D0 Offset: 0x4E54D0 VA: 0x1804E62D0
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x4E60B0 Offset: 0x4E52B0 VA: 0x1804E60B0 Slot: 4
	public void Set(ref QueryLeaderboardRanksOptions other) { }

	// RVA: 0x4E6170 Offset: 0x4E5370 VA: 0x1804E6170 Slot: 5
	public void Set(ref Nullable<QueryLeaderboardRanksOptions> other) { }

	// RVA: 0x4E6050 Offset: 0x4E5250 VA: 0x1804E6050 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Leaderboards
public struct QueryLeaderboardUserScoresOptions // TypeDefIndex: 9408
{
	// Fields
	[CompilerGenerated]
	private ProductUserId[] <UserIds>k__BackingField; // 0x0
	[CompilerGenerated]
	private UserScoresQueryStatInfo[] <StatInfo>k__BackingField; // 0x8
	[CompilerGenerated]
	private Nullable<DateTimeOffset> <StartTime>k__BackingField; // 0x10
	[CompilerGenerated]
	private Nullable<DateTimeOffset> <EndTime>k__BackingField; // 0x28
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x40

	// Properties
	public ProductUserId[] UserIds { get; set; }
	public UserScoresQueryStatInfo[] StatInfo { get; set; }
	public Nullable<DateTimeOffset> StartTime { get; set; }
	public Nullable<DateTimeOffset> EndTime { get; set; }
	public ProductUserId LocalUserId { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public ProductUserId[] get_UserIds() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_UserIds(ProductUserId[] value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public UserScoresQueryStatInfo[] get_StatInfo() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_StatInfo(UserScoresQueryStatInfo[] value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x44F1F0 Offset: 0x44E3F0 VA: 0x18044F1F0
	public Nullable<DateTimeOffset> get_StartTime() { }

	[CompilerGenerated]
	// RVA: 0x44F220 Offset: 0x44E420 VA: 0x18044F220
	public void set_StartTime(Nullable<DateTimeOffset> value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x4E6990 Offset: 0x4E5B90 VA: 0x1804E6990
	public Nullable<DateTimeOffset> get_EndTime() { }

	[CompilerGenerated]
	// RVA: 0x4E69B0 Offset: 0x4E5BB0 VA: 0x1804E69B0
	public void set_EndTime(Nullable<DateTimeOffset> value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x415820 Offset: 0x414A20 VA: 0x180415820
	public void set_LocalUserId(ProductUserId value) { }
}

// Namespace: Epic.OnlineServices.Leaderboards
internal struct QueryLeaderboardUserScoresOptionsInternal : ISettable<QueryLeaderboardUserScoresOptions>, IDisposable // TypeDefIndex: 9409
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_UserIds; // 0x8
	private uint m_UserIdsCount; // 0x10
	private IntPtr m_StatInfo; // 0x18
	private uint m_StatInfoCount; // 0x20
	private long m_StartTime; // 0x28
	private long m_EndTime; // 0x30
	private IntPtr m_LocalUserId; // 0x38

	// Properties
	public ProductUserId[] UserIds { set; }
	public UserScoresQueryStatInfo[] StatInfo { set; }
	public Nullable<DateTimeOffset> StartTime { set; }
	public Nullable<DateTimeOffset> EndTime { set; }
	public ProductUserId LocalUserId { set; }

	// Methods

	// RVA: 0x4E6920 Offset: 0x4E5B20 VA: 0x1804E6920
	public void set_UserIds(ProductUserId[] value) { }

	// RVA: 0x4E68B0 Offset: 0x4E5AB0 VA: 0x1804E68B0
	public void set_StatInfo(UserScoresQueryStatInfo[] value) { }

	// RVA: 0x4E6840 Offset: 0x4E5A40 VA: 0x1804E6840
	public void set_StartTime(Nullable<DateTimeOffset> value) { }

	// RVA: 0x4E6770 Offset: 0x4E5970 VA: 0x1804E6770
	public void set_EndTime(Nullable<DateTimeOffset> value) { }

	// RVA: 0x4E67E0 Offset: 0x4E59E0 VA: 0x1804E67E0
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x4E6570 Offset: 0x4E5770 VA: 0x1804E6570 Slot: 4
	public void Set(ref QueryLeaderboardUserScoresOptions other) { }

	// RVA: 0x4E6390 Offset: 0x4E5590 VA: 0x1804E6390 Slot: 5
	public void Set(ref Nullable<QueryLeaderboardUserScoresOptions> other) { }

	// RVA: 0x4E6330 Offset: 0x4E5530 VA: 0x1804E6330 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Leaderboards
public struct UserScoresQueryStatInfo // TypeDefIndex: 9410
{
	// Fields
	[CompilerGenerated]
	private Utf8String <StatName>k__BackingField; // 0x0
	[CompilerGenerated]
	private LeaderboardAggregation <Aggregation>k__BackingField; // 0x8

	// Properties
	public Utf8String StatName { get; set; }
	public LeaderboardAggregation Aggregation { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Utf8String get_StatName() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_StatName(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3F5510 Offset: 0x3F4710 VA: 0x1803F5510
	public LeaderboardAggregation get_Aggregation() { }

	[CompilerGenerated]
	// RVA: 0x3F5520 Offset: 0x3F4720 VA: 0x1803F5520
	public void set_Aggregation(LeaderboardAggregation value) { }

	// RVA: 0x4EB5E0 Offset: 0x4EA7E0 VA: 0x1804EB5E0
	internal void Set(ref UserScoresQueryStatInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.Leaderboards
internal struct UserScoresQueryStatInfoInternal : IGettable<UserScoresQueryStatInfo>, ISettable<UserScoresQueryStatInfo>, IDisposable // TypeDefIndex: 9411
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_StatName; // 0x8
	private LeaderboardAggregation m_Aggregation; // 0x10

	// Properties
	public Utf8String StatName { get; set; }
	public LeaderboardAggregation Aggregation { get; set; }

	// Methods

	// RVA: 0x4EB510 Offset: 0x4EA710 VA: 0x1804EB510
	public Utf8String get_StatName() { }

	// RVA: 0x4EB580 Offset: 0x4EA780 VA: 0x1804EB580
	public void set_StatName(Utf8String value) { }

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public LeaderboardAggregation get_Aggregation() { }

	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_Aggregation(LeaderboardAggregation value) { }

	// RVA: 0x4EB3D0 Offset: 0x4EA5D0 VA: 0x1804EB3D0 Slot: 5
	public void Set(ref UserScoresQueryStatInfo other) { }

	// RVA: 0x4EB450 Offset: 0x4EA650 VA: 0x1804EB450 Slot: 6
	public void Set(ref Nullable<UserScoresQueryStatInfo> other) { }

	// RVA: 0x4EB360 Offset: 0x4EA560 VA: 0x1804EB360 Slot: 7
	public void Dispose() { }

	// RVA: 0x4EB3B0 Offset: 0x4EA5B0 VA: 0x1804EB3B0 Slot: 4
	public void Get(out UserScoresQueryStatInfo output) { }
}

// Namespace: Epic.OnlineServices.KWS
public struct AddNotifyPermissionsUpdateReceivedOptions // TypeDefIndex: 9412
{}

// Namespace: Epic.OnlineServices.KWS
internal struct AddNotifyPermissionsUpdateReceivedOptionsInternal : ISettable<AddNotifyPermissionsUpdateReceivedOptions>, IDisposable // TypeDefIndex: 9413
{
	// Fields
	private int m_ApiVersion; // 0x0

	// Methods

	// RVA: 0x3F98A0 Offset: 0x3F8AA0 VA: 0x1803F98A0 Slot: 4
	public void Set(ref AddNotifyPermissionsUpdateReceivedOptions other) { }

	// RVA: 0x4D3B50 Offset: 0x4D2D50 VA: 0x1804D3B50 Slot: 5
	public void Set(ref Nullable<AddNotifyPermissionsUpdateReceivedOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.KWS
public struct CopyPermissionByIndexOptions // TypeDefIndex: 9414
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

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3F5510 Offset: 0x3F4710 VA: 0x1803F5510
	public uint get_Index() { }

	[CompilerGenerated]
	// RVA: 0x3F5520 Offset: 0x3F4720 VA: 0x1803F5520
	public void set_Index(uint value) { }
}

// Namespace: Epic.OnlineServices.KWS
internal struct CopyPermissionByIndexOptionsInternal : ISettable<CopyPermissionByIndexOptions>, IDisposable // TypeDefIndex: 9415
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private uint m_Index; // 0x10

	// Properties
	public ProductUserId LocalUserId { set; }
	public uint Index { set; }

	// Methods

	// RVA: 0x4D4DD0 Offset: 0x4D3FD0 VA: 0x1804D4DD0
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_Index(uint value) { }

	// RVA: 0x4D4D50 Offset: 0x4D3F50 VA: 0x1804D4D50 Slot: 4
	public void Set(ref CopyPermissionByIndexOptions other) { }

	// RVA: 0x4D4C90 Offset: 0x4D3E90 VA: 0x1804D4C90 Slot: 5
	public void Set(ref Nullable<CopyPermissionByIndexOptions> other) { }

	// RVA: 0x4D4C40 Offset: 0x4D3E40 VA: 0x1804D4C40 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.KWS
public struct CreateUserCallbackInfo : ICallbackInfo // TypeDefIndex: 9416
{
	// Fields
	[CompilerGenerated]
	private Result <ResultCode>k__BackingField; // 0x0
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x8
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x10
	[CompilerGenerated]
	private Utf8String <KWSUserId>k__BackingField; // 0x18
	[CompilerGenerated]
	private bool <IsMinor>k__BackingField; // 0x20

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public ProductUserId LocalUserId { get; set; }
	public Utf8String KWSUserId { get; set; }
	public bool IsMinor { get; set; }

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

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public Utf8String get_KWSUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_KWSUserId(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x4009D0 Offset: 0x3FFBD0 VA: 0x1804009D0
	public bool get_IsMinor() { }

	[CompilerGenerated]
	// RVA: 0x4009E0 Offset: 0x3FFBE0 VA: 0x1804009E0
	public void set_IsMinor(bool value) { }

	// RVA: 0x4D58E0 Offset: 0x4D4AE0 VA: 0x1804D58E0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x4D5930 Offset: 0x4D4B30 VA: 0x1804D5930
	internal void Set(ref CreateUserCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.KWS
internal struct CreateUserCallbackInfoInternal : ICallbackInfoInternal, IGettable<CreateUserCallbackInfo>, ISettable<CreateUserCallbackInfo>, IDisposable // TypeDefIndex: 9417
{
	// Fields
	private Result m_ResultCode; // 0x0
	private IntPtr m_ClientData; // 0x8
	private IntPtr m_LocalUserId; // 0x10
	private IntPtr m_KWSUserId; // 0x18
	private int m_IsMinor; // 0x20

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public ProductUserId LocalUserId { get; set; }
	public Utf8String KWSUserId { get; set; }
	public bool IsMinor { get; set; }

	// Methods

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	// RVA: 0x4D55A0 Offset: 0x4D47A0 VA: 0x1804D55A0
	public object get_ClientData() { }

	// RVA: 0x4D5760 Offset: 0x4D4960 VA: 0x1804D5760
	public void set_ClientData(object value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x4D56E0 Offset: 0x4D48E0 VA: 0x1804D56E0
	public ProductUserId get_LocalUserId() { }

	// RVA: 0x4D5880 Offset: 0x4D4A80 VA: 0x1804D5880
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x4D5670 Offset: 0x4D4870 VA: 0x1804D5670
	public Utf8String get_KWSUserId() { }

	// RVA: 0x4D5820 Offset: 0x4D4A20 VA: 0x1804D5820
	public void set_KWSUserId(Utf8String value) { }

	// RVA: 0x4D5610 Offset: 0x4D4810 VA: 0x1804D5610
	public bool get_IsMinor() { }

	// RVA: 0x4D57C0 Offset: 0x4D49C0 VA: 0x1804D57C0
	public void set_IsMinor(bool value) { }

	// RVA: 0x4D5460 Offset: 0x4D4660 VA: 0x1804D5460 Slot: 6
	public void Set(ref CreateUserCallbackInfo other) { }

	// RVA: 0x4D52A0 Offset: 0x4D44A0 VA: 0x1804D52A0 Slot: 7
	public void Set(ref Nullable<CreateUserCallbackInfo> other) { }

	// RVA: 0x4D5210 Offset: 0x4D4410 VA: 0x1804D5210 Slot: 8
	public void Dispose() { }

	// RVA: 0x4D5270 Offset: 0x4D4470 VA: 0x1804D5270 Slot: 5
	public void Get(out CreateUserCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.KWS
public struct CreateUserOptions // TypeDefIndex: 9418
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <DateOfBirth>k__BackingField; // 0x8
	[CompilerGenerated]
	private Utf8String <ParentEmail>k__BackingField; // 0x10

	// Properties
	public ProductUserId LocalUserId { get; set; }
	public Utf8String DateOfBirth { get; set; }
	public Utf8String ParentEmail { get; set; }

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
	public Utf8String get_DateOfBirth() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_DateOfBirth(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Utf8String get_ParentEmail() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_ParentEmail(Utf8String value) { }
}

// Namespace: Epic.OnlineServices.KWS
internal struct CreateUserOptionsInternal : ISettable<CreateUserOptions>, IDisposable // TypeDefIndex: 9419
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_DateOfBirth; // 0x10
	private IntPtr m_ParentEmail; // 0x18

	// Properties
	public ProductUserId LocalUserId { set; }
	public Utf8String DateOfBirth { set; }
	public Utf8String ParentEmail { set; }

	// Methods

	// RVA: 0x4D5D90 Offset: 0x4D4F90 VA: 0x1804D5D90
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x4D5D30 Offset: 0x4D4F30 VA: 0x1804D5D30
	public void set_DateOfBirth(Utf8String value) { }

	// RVA: 0x4D5DF0 Offset: 0x4D4FF0 VA: 0x1804D5DF0
	public void set_ParentEmail(Utf8String value) { }

	// RVA: 0x4D5C30 Offset: 0x4D4E30 VA: 0x1804D5C30 Slot: 4
	public void Set(ref CreateUserOptions other) { }

	// RVA: 0x4D5AD0 Offset: 0x4D4CD0 VA: 0x1804D5AD0 Slot: 5
	public void Set(ref Nullable<CreateUserOptions> other) { }

	// RVA: 0x4D5A70 Offset: 0x4D4C70 VA: 0x1804D5A70 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.KWS
public struct GetPermissionByKeyOptions // TypeDefIndex: 9420
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <Key>k__BackingField; // 0x8

	// Properties
	public ProductUserId LocalUserId { get; set; }
	public Utf8String Key { get; set; }

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
	public Utf8String get_Key() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_Key(Utf8String value) { }
}

// Namespace: Epic.OnlineServices.KWS
internal struct GetPermissionByKeyOptionsInternal : ISettable<GetPermissionByKeyOptions>, IDisposable // TypeDefIndex: 9421
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_Key; // 0x10

	// Properties
	public ProductUserId LocalUserId { set; }
	public Utf8String Key { set; }

	// Methods

	// RVA: 0x4D6C90 Offset: 0x4D5E90 VA: 0x1804D6C90
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x4D6C30 Offset: 0x4D5E30 VA: 0x1804D6C30
	public void set_Key(Utf8String value) { }

	// RVA: 0x4D6A70 Offset: 0x4D5C70 VA: 0x1804D6A70 Slot: 4
	public void Set(ref GetPermissionByKeyOptions other) { }

	// RVA: 0x4D6B30 Offset: 0x4D5D30 VA: 0x1804D6B30 Slot: 5
	public void Set(ref Nullable<GetPermissionByKeyOptions> other) { }

	// RVA: 0x4D6A10 Offset: 0x4D5C10 VA: 0x1804D6A10 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.KWS
public struct GetPermissionsCountOptions // TypeDefIndex: 9422
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

// Namespace: Epic.OnlineServices.KWS
internal struct GetPermissionsCountOptionsInternal : ISettable<GetPermissionsCountOptions>, IDisposable // TypeDefIndex: 9423
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8

	// Properties
	public ProductUserId LocalUserId { set; }

	// Methods

	// RVA: 0x4D6E40 Offset: 0x4D6040 VA: 0x1804D6E40
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x4D6DE0 Offset: 0x4D5FE0 VA: 0x1804D6DE0 Slot: 4
	public void Set(ref GetPermissionsCountOptions other) { }

	// RVA: 0x4D6D40 Offset: 0x4D5F40 VA: 0x1804D6D40 Slot: 5
	public void Set(ref Nullable<GetPermissionsCountOptions> other) { }

	// RVA: 0x4D6CF0 Offset: 0x4D5EF0 VA: 0x1804D6CF0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.KWS
public sealed class KWSInterface : Handle // TypeDefIndex: 9424
{
	// Fields
	public const int AddnotifypermissionsupdatereceivedApiLatest = 1;
	public const int CopypermissionbyindexApiLatest = 1;
	public const int CreateuserApiLatest = 1;
	public const int GetpermissionbykeyApiLatest = 1;
	public const int GetpermissionscountApiLatest = 1;
	public const int MaxPermissionLength = 32;
	public const int MaxPermissions = 16;
	public const int PermissionstatusApiLatest = 1;
	public const int QueryagegateApiLatest = 1;
	public const int QuerypermissionsApiLatest = 1;
	public const int RequestpermissionsApiLatest = 1;
	public const int UpdateparentemailApiLatest = 1;

	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }

	// RVA: 0x40BDB0 Offset: 0x40AFB0 VA: 0x18040BDB0
	public void .ctor(IntPtr innerHandle) { }

	// RVA: 0x4D8890 Offset: 0x4D7A90 VA: 0x1804D8890
	public ulong AddNotifyPermissionsUpdateReceived(ref AddNotifyPermissionsUpdateReceivedOptions options, object clientData, OnPermissionsUpdateReceivedCallback notificationFn) { }

	// RVA: 0x4D8A40 Offset: 0x4D7C40 VA: 0x1804D8A40
	public Result CopyPermissionByIndex(ref CopyPermissionByIndexOptions options, out Nullable<PermissionStatus> outPermission) { }

	// RVA: 0x4D8B90 Offset: 0x4D7D90 VA: 0x1804D8B90
	public void CreateUser(ref CreateUserOptions options, object clientData, OnCreateUserCallback completionDelegate) { }

	// RVA: 0x4D8D40 Offset: 0x4D7F40 VA: 0x1804D8D40
	public Result GetPermissionByKey(ref GetPermissionByKeyOptions options, out KWSPermissionStatus outPermission) { }

	// RVA: 0x4D8E10 Offset: 0x4D8010 VA: 0x1804D8E10
	public int GetPermissionsCount(ref GetPermissionsCountOptions options) { }

	// RVA: 0x4D9310 Offset: 0x4D8510 VA: 0x1804D9310
	public void QueryAgeGate(ref QueryAgeGateOptions options, object clientData, OnQueryAgeGateCallback completionDelegate) { }

	// RVA: 0x4D94B0 Offset: 0x4D86B0 VA: 0x1804D94B0
	public void QueryPermissions(ref QueryPermissionsOptions options, object clientData, OnQueryPermissionsCallback completionDelegate) { }

	// RVA: 0x4D96A0 Offset: 0x4D88A0 VA: 0x1804D96A0
	public void RemoveNotifyPermissionsUpdateReceived(ulong inId) { }

	// RVA: 0x4D9710 Offset: 0x4D8910 VA: 0x1804D9710
	public void RequestPermissions(ref RequestPermissionsOptions options, object clientData, OnRequestPermissionsCallback completionDelegate) { }

	// RVA: 0x4D9960 Offset: 0x4D8B60 VA: 0x1804D9960
	public void UpdateParentEmail(ref UpdateParentEmailOptions options, object clientData, OnUpdateParentEmailCallback completionDelegate) { }

	[MonoPInvokeCallback(typeof(OnCreateUserCallbackInternal))]
	// RVA: 0x4D8EF0 Offset: 0x4D80F0 VA: 0x1804D8EF0
	internal static void OnCreateUserCallbackInternalImplementation(ref CreateUserCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnPermissionsUpdateReceivedCallbackInternal))]
	// RVA: 0x4D8FA0 Offset: 0x4D81A0 VA: 0x1804D8FA0
	internal static void OnPermissionsUpdateReceivedCallbackInternalImplementation(ref PermissionsUpdateReceivedCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnQueryAgeGateCallbackInternal))]
	// RVA: 0x4D9050 Offset: 0x4D8250 VA: 0x1804D9050
	internal static void OnQueryAgeGateCallbackInternalImplementation(ref QueryAgeGateCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnQueryPermissionsCallbackInternal))]
	// RVA: 0x4D9100 Offset: 0x4D8300 VA: 0x1804D9100
	internal static void OnQueryPermissionsCallbackInternalImplementation(ref QueryPermissionsCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnRequestPermissionsCallbackInternal))]
	// RVA: 0x4D91B0 Offset: 0x4D83B0 VA: 0x1804D91B0
	internal static void OnRequestPermissionsCallbackInternalImplementation(ref RequestPermissionsCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnUpdateParentEmailCallbackInternal))]
	// RVA: 0x4D9260 Offset: 0x4D8460 VA: 0x1804D9260
	internal static void OnUpdateParentEmailCallbackInternalImplementation(ref UpdateParentEmailCallbackInfoInternal data) { }
}

// Namespace: Epic.OnlineServices.KWS
public enum KWSPermissionStatus // TypeDefIndex: 9425
{
	// Fields
	public int value__; // 0x0
	public const KWSPermissionStatus Granted = 0;
	public const KWSPermissionStatus Rejected = 1;
	public const KWSPermissionStatus Pending = 2;
}

// Namespace: Epic.OnlineServices.KWS
public sealed class OnCreateUserCallback : MulticastDelegate // TypeDefIndex: 9426
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref CreateUserCallbackInfo data) { }

	// RVA: 0x4E09F0 Offset: 0x4DFBF0 VA: 0x1804E09F0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref CreateUserCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref CreateUserCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.KWS
[UnmanagedFunctionPointer(2)]
internal sealed class OnCreateUserCallbackInternal : MulticastDelegate // TypeDefIndex: 9427
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref CreateUserCallbackInfoInternal data) { }

	// RVA: 0x4E0960 Offset: 0x4DFB60 VA: 0x1804E0960 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref CreateUserCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref CreateUserCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.KWS
public sealed class OnPermissionsUpdateReceivedCallback : MulticastDelegate // TypeDefIndex: 9428
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref PermissionsUpdateReceivedCallbackInfo data) { }

	// RVA: 0x4E1AD0 Offset: 0x4E0CD0 VA: 0x1804E1AD0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref PermissionsUpdateReceivedCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref PermissionsUpdateReceivedCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.KWS
[UnmanagedFunctionPointer(2)]
internal sealed class OnPermissionsUpdateReceivedCallbackInternal : MulticastDelegate // TypeDefIndex: 9429
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref PermissionsUpdateReceivedCallbackInfoInternal data) { }

	// RVA: 0x4E1A40 Offset: 0x4E0C40 VA: 0x1804E1A40 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref PermissionsUpdateReceivedCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref PermissionsUpdateReceivedCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.KWS
public sealed class OnQueryAgeGateCallback : MulticastDelegate // TypeDefIndex: 9430
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref QueryAgeGateCallbackInfo data) { }

	// RVA: 0x4E1D10 Offset: 0x4E0F10 VA: 0x1804E1D10 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref QueryAgeGateCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref QueryAgeGateCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.KWS
[UnmanagedFunctionPointer(2)]
internal sealed class OnQueryAgeGateCallbackInternal : MulticastDelegate // TypeDefIndex: 9431
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref QueryAgeGateCallbackInfoInternal data) { }

	// RVA: 0x4E1C80 Offset: 0x4E0E80 VA: 0x1804E1C80 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref QueryAgeGateCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref QueryAgeGateCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.KWS
public sealed class OnQueryPermissionsCallback : MulticastDelegate // TypeDefIndex: 9432
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref QueryPermissionsCallbackInfo data) { }

	// RVA: 0x4E2E30 Offset: 0x4E2030 VA: 0x1804E2E30 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref QueryPermissionsCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref QueryPermissionsCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.KWS
[UnmanagedFunctionPointer(2)]
internal sealed class OnQueryPermissionsCallbackInternal : MulticastDelegate // TypeDefIndex: 9433
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref QueryPermissionsCallbackInfoInternal data) { }

	// RVA: 0x4E2DA0 Offset: 0x4E1FA0 VA: 0x1804E2DA0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref QueryPermissionsCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref QueryPermissionsCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.KWS
public sealed class OnRequestPermissionsCallback : MulticastDelegate // TypeDefIndex: 9434
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref RequestPermissionsCallbackInfo data) { }

	// RVA: 0x4E3190 Offset: 0x4E2390 VA: 0x1804E3190 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref RequestPermissionsCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref RequestPermissionsCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.KWS
[UnmanagedFunctionPointer(2)]
internal sealed class OnRequestPermissionsCallbackInternal : MulticastDelegate // TypeDefIndex: 9435
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref RequestPermissionsCallbackInfoInternal data) { }

	// RVA: 0x4E3100 Offset: 0x4E2300 VA: 0x1804E3100 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref RequestPermissionsCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref RequestPermissionsCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.KWS
public sealed class OnUpdateParentEmailCallback : MulticastDelegate // TypeDefIndex: 9436
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref UpdateParentEmailCallbackInfo data) { }

	// RVA: 0x4E3610 Offset: 0x4E2810 VA: 0x1804E3610 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref UpdateParentEmailCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref UpdateParentEmailCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.KWS
[UnmanagedFunctionPointer(2)]
internal sealed class OnUpdateParentEmailCallbackInternal : MulticastDelegate // TypeDefIndex: 9437
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref UpdateParentEmailCallbackInfoInternal data) { }

	// RVA: 0x4E3580 Offset: 0x4E2780 VA: 0x1804E3580 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref UpdateParentEmailCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref UpdateParentEmailCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.KWS
public struct PermissionStatus // TypeDefIndex: 9438
{
	// Fields
	[CompilerGenerated]
	private Utf8String <Name>k__BackingField; // 0x0
	[CompilerGenerated]
	private KWSPermissionStatus <Status>k__BackingField; // 0x8

	// Properties
	public Utf8String Name { get; set; }
	public KWSPermissionStatus Status { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Utf8String get_Name() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_Name(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3F5510 Offset: 0x3F4710 VA: 0x1803F5510
	public KWSPermissionStatus get_Status() { }

	[CompilerGenerated]
	// RVA: 0x3F5520 Offset: 0x3F4720 VA: 0x1803F5520
	public void set_Status(KWSPermissionStatus value) { }

	// RVA: 0x4E3AD0 Offset: 0x4E2CD0 VA: 0x1804E3AD0
	internal void Set(ref PermissionStatusInternal other) { }
}

// Namespace: Epic.OnlineServices.KWS
internal struct PermissionStatusInternal : IGettable<PermissionStatus>, ISettable<PermissionStatus>, IDisposable // TypeDefIndex: 9439
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_Name; // 0x8
	private KWSPermissionStatus m_Status; // 0x10

	// Properties
	public Utf8String Name { get; set; }
	public KWSPermissionStatus Status { get; set; }

	// Methods

	// RVA: 0x4E3A00 Offset: 0x4E2C00 VA: 0x1804E3A00
	public Utf8String get_Name() { }

	// RVA: 0x4E3A70 Offset: 0x4E2C70 VA: 0x1804E3A70
	public void set_Name(Utf8String value) { }

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public KWSPermissionStatus get_Status() { }

	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_Status(KWSPermissionStatus value) { }

	// RVA: 0x4E3980 Offset: 0x4E2B80 VA: 0x1804E3980 Slot: 5
	public void Set(ref PermissionStatus other) { }

	// RVA: 0x4E38C0 Offset: 0x4E2AC0 VA: 0x1804E38C0 Slot: 6
	public void Set(ref Nullable<PermissionStatus> other) { }

	// RVA: 0x4E3850 Offset: 0x4E2A50 VA: 0x1804E3850 Slot: 7
	public void Dispose() { }

	// RVA: 0x4E38A0 Offset: 0x4E2AA0 VA: 0x1804E38A0 Slot: 4
	public void Get(out PermissionStatus output) { }
}

// Namespace: Epic.OnlineServices.KWS
public struct PermissionsUpdateReceivedCallbackInfo : ICallbackInfo // TypeDefIndex: 9440
{
	// Fields
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x0
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x8
	[CompilerGenerated]
	private Utf8String <KWSUserId>k__BackingField; // 0x10
	[CompilerGenerated]
	private Utf8String <DateOfBirth>k__BackingField; // 0x18
	[CompilerGenerated]
	private bool <IsMinor>k__BackingField; // 0x20
	[CompilerGenerated]
	private Utf8String <ParentEmail>k__BackingField; // 0x28

	// Properties
	public object ClientData { get; set; }
	public ProductUserId LocalUserId { get; set; }
	public Utf8String KWSUserId { get; set; }
	public Utf8String DateOfBirth { get; set; }
	public bool IsMinor { get; set; }
	public Utf8String ParentEmail { get; set; }

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
	public Utf8String get_KWSUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_KWSUserId(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public Utf8String get_DateOfBirth() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_DateOfBirth(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x4009D0 Offset: 0x3FFBD0 VA: 0x1804009D0
	public bool get_IsMinor() { }

	[CompilerGenerated]
	// RVA: 0x4009E0 Offset: 0x3FFBE0 VA: 0x1804009E0
	public void set_IsMinor(bool value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public Utf8String get_ParentEmail() { }

	[CompilerGenerated]
	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	public void set_ParentEmail(Utf8String value) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x4E44F0 Offset: 0x4E36F0 VA: 0x1804E44F0
	internal void Set(ref PermissionsUpdateReceivedCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.KWS
internal struct PermissionsUpdateReceivedCallbackInfoInternal : ICallbackInfoInternal, IGettable<PermissionsUpdateReceivedCallbackInfo>, ISettable<PermissionsUpdateReceivedCallbackInfo>, IDisposable // TypeDefIndex: 9441
{
	// Fields
	private IntPtr m_ClientData; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_KWSUserId; // 0x10
	private IntPtr m_DateOfBirth; // 0x18
	private int m_IsMinor; // 0x20
	private IntPtr m_ParentEmail; // 0x28

	// Properties
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public ProductUserId LocalUserId { get; set; }
	public Utf8String KWSUserId { get; set; }
	public Utf8String DateOfBirth { get; set; }
	public bool IsMinor { get; set; }
	public Utf8String ParentEmail { get; set; }

	// Methods

	// RVA: 0x4E4010 Offset: 0x4E3210 VA: 0x1804E4010
	public object get_ClientData() { }

	// RVA: 0x4E42B0 Offset: 0x4E34B0 VA: 0x1804E42B0
	public void set_ClientData(object value) { }

	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x4E41C0 Offset: 0x4E33C0 VA: 0x1804E41C0
	public ProductUserId get_LocalUserId() { }

	// RVA: 0x4E4430 Offset: 0x4E3630 VA: 0x1804E4430
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x4E4150 Offset: 0x4E3350 VA: 0x1804E4150
	public Utf8String get_KWSUserId() { }

	// RVA: 0x4E43D0 Offset: 0x4E35D0 VA: 0x1804E43D0
	public void set_KWSUserId(Utf8String value) { }

	// RVA: 0x4E4080 Offset: 0x4E3280 VA: 0x1804E4080
	public Utf8String get_DateOfBirth() { }

	// RVA: 0x4E4310 Offset: 0x4E3510 VA: 0x1804E4310
	public void set_DateOfBirth(Utf8String value) { }

	// RVA: 0x4E40F0 Offset: 0x4E32F0 VA: 0x1804E40F0
	public bool get_IsMinor() { }

	// RVA: 0x4E4370 Offset: 0x4E3570 VA: 0x1804E4370
	public void set_IsMinor(bool value) { }

	// RVA: 0x4E4240 Offset: 0x4E3440 VA: 0x1804E4240
	public Utf8String get_ParentEmail() { }

	// RVA: 0x4E4490 Offset: 0x4E3690 VA: 0x1804E4490
	public void set_ParentEmail(Utf8String value) { }

	// RVA: 0x4E3E50 Offset: 0x4E3050 VA: 0x1804E3E50 Slot: 6
	public void Set(ref PermissionsUpdateReceivedCallbackInfo other) { }

	// RVA: 0x4E3C00 Offset: 0x4E2E00 VA: 0x1804E3C00 Slot: 7
	public void Set(ref Nullable<PermissionsUpdateReceivedCallbackInfo> other) { }

	// RVA: 0x4E3B60 Offset: 0x4E2D60 VA: 0x1804E3B60 Slot: 8
	public void Dispose() { }

	// RVA: 0x4E3BE0 Offset: 0x4E2DE0 VA: 0x1804E3BE0 Slot: 5
	public void Get(out PermissionsUpdateReceivedCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.KWS
public struct QueryAgeGateCallbackInfo : ICallbackInfo // TypeDefIndex: 9442
{
	// Fields
	[CompilerGenerated]
	private Result <ResultCode>k__BackingField; // 0x0
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x8
	[CompilerGenerated]
	private Utf8String <CountryCode>k__BackingField; // 0x10
	[CompilerGenerated]
	private uint <AgeOfConsent>k__BackingField; // 0x18

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public Utf8String CountryCode { get; set; }
	public uint AgeOfConsent { get; set; }

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
	public Utf8String get_CountryCode() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_CountryCode(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public uint get_AgeOfConsent() { }

	[CompilerGenerated]
	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	public void set_AgeOfConsent(uint value) { }

	// RVA: 0x4E53E0 Offset: 0x4E45E0 VA: 0x1804E53E0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x4E5430 Offset: 0x4E4630 VA: 0x1804E5430
	internal void Set(ref QueryAgeGateCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.KWS
internal struct QueryAgeGateCallbackInfoInternal : ICallbackInfoInternal, IGettable<QueryAgeGateCallbackInfo>, ISettable<QueryAgeGateCallbackInfo>, IDisposable // TypeDefIndex: 9443
{
	// Fields
	private Result m_ResultCode; // 0x0
	private IntPtr m_ClientData; // 0x8
	private IntPtr m_CountryCode; // 0x10
	private uint m_AgeOfConsent; // 0x18

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public Utf8String CountryCode { get; set; }
	public uint AgeOfConsent { get; set; }

	// Methods

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	// RVA: 0x4E5240 Offset: 0x4E4440 VA: 0x1804E5240
	public object get_ClientData() { }

	// RVA: 0x4E5320 Offset: 0x4E4520 VA: 0x1804E5320
	public void set_ClientData(object value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x4E52B0 Offset: 0x4E44B0 VA: 0x1804E52B0
	public Utf8String get_CountryCode() { }

	// RVA: 0x4E5380 Offset: 0x4E4580 VA: 0x1804E5380
	public void set_CountryCode(Utf8String value) { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public uint get_AgeOfConsent() { }

	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	public void set_AgeOfConsent(uint value) { }

	// RVA: 0x4E5180 Offset: 0x4E4380 VA: 0x1804E5180 Slot: 6
	public void Set(ref QueryAgeGateCallbackInfo other) { }

	// RVA: 0x4E5050 Offset: 0x4E4250 VA: 0x1804E5050 Slot: 7
	public void Set(ref Nullable<QueryAgeGateCallbackInfo> other) { }

	// RVA: 0x4E4FD0 Offset: 0x4E41D0 VA: 0x1804E4FD0 Slot: 8
	public void Dispose() { }

	// RVA: 0x4E5030 Offset: 0x4E4230 VA: 0x1804E5030 Slot: 5
	public void Get(out QueryAgeGateCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.KWS
public struct QueryAgeGateOptions // TypeDefIndex: 9444
{}

// Namespace: Epic.OnlineServices.KWS
internal struct QueryAgeGateOptionsInternal : ISettable<QueryAgeGateOptions>, IDisposable // TypeDefIndex: 9445
{
	// Fields
	private int m_ApiVersion; // 0x0

	// Methods

	// RVA: 0x3F98A0 Offset: 0x3F8AA0 VA: 0x1803F98A0 Slot: 4
	public void Set(ref QueryAgeGateOptions other) { }

	// RVA: 0x4E5510 Offset: 0x4E4710 VA: 0x1804E5510 Slot: 5
	public void Set(ref Nullable<QueryAgeGateOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.KWS
public struct QueryPermissionsCallbackInfo : ICallbackInfo // TypeDefIndex: 9446
{
	// Fields
	[CompilerGenerated]
	private Result <ResultCode>k__BackingField; // 0x0
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x8
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x10
	[CompilerGenerated]
	private Utf8String <KWSUserId>k__BackingField; // 0x18
	[CompilerGenerated]
	private Utf8String <DateOfBirth>k__BackingField; // 0x20
	[CompilerGenerated]
	private bool <IsMinor>k__BackingField; // 0x28
	[CompilerGenerated]
	private Utf8String <ParentEmail>k__BackingField; // 0x30

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public ProductUserId LocalUserId { get; set; }
	public Utf8String KWSUserId { get; set; }
	public Utf8String DateOfBirth { get; set; }
	public bool IsMinor { get; set; }
	public Utf8String ParentEmail { get; set; }

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
	public Utf8String get_KWSUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_KWSUserId(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public Utf8String get_DateOfBirth() { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_DateOfBirth(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x42D840 Offset: 0x42CA40 VA: 0x18042D840
	public bool get_IsMinor() { }

	[CompilerGenerated]
	// RVA: 0x42D8B0 Offset: 0x42CAB0 VA: 0x18042D8B0
	public void set_IsMinor(bool value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public Utf8String get_ParentEmail() { }

	[CompilerGenerated]
	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	public void set_ParentEmail(Utf8String value) { }

	// RVA: 0x4E73A0 Offset: 0x4E65A0 VA: 0x1804E73A0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x4E73F0 Offset: 0x4E65F0 VA: 0x1804E73F0
	internal void Set(ref QueryPermissionsCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.KWS
internal struct QueryPermissionsCallbackInfoInternal : ICallbackInfoInternal, IGettable<QueryPermissionsCallbackInfo>, ISettable<QueryPermissionsCallbackInfo>, IDisposable // TypeDefIndex: 9447
{
	// Fields
	private Result m_ResultCode; // 0x0
	private IntPtr m_ClientData; // 0x8
	private IntPtr m_LocalUserId; // 0x10
	private IntPtr m_KWSUserId; // 0x18
	private IntPtr m_DateOfBirth; // 0x20
	private int m_IsMinor; // 0x28
	private IntPtr m_ParentEmail; // 0x30

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public ProductUserId LocalUserId { get; set; }
	public Utf8String KWSUserId { get; set; }
	public Utf8String DateOfBirth { get; set; }
	public bool IsMinor { get; set; }
	public Utf8String ParentEmail { get; set; }

	// Methods

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	// RVA: 0x4E6EC0 Offset: 0x4E60C0 VA: 0x1804E6EC0
	public object get_ClientData() { }

	// RVA: 0x4E7160 Offset: 0x4E6360 VA: 0x1804E7160
	public void set_ClientData(object value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x4E7070 Offset: 0x4E6270 VA: 0x1804E7070
	public ProductUserId get_LocalUserId() { }

	// RVA: 0x4E72E0 Offset: 0x4E64E0 VA: 0x1804E72E0
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x4E7000 Offset: 0x4E6200 VA: 0x1804E7000
	public Utf8String get_KWSUserId() { }

	// RVA: 0x4E7280 Offset: 0x4E6480 VA: 0x1804E7280
	public void set_KWSUserId(Utf8String value) { }

	// RVA: 0x4E6F30 Offset: 0x4E6130 VA: 0x1804E6F30
	public Utf8String get_DateOfBirth() { }

	// RVA: 0x4E71C0 Offset: 0x4E63C0 VA: 0x1804E71C0
	public void set_DateOfBirth(Utf8String value) { }

	// RVA: 0x4E6FA0 Offset: 0x4E61A0 VA: 0x1804E6FA0
	public bool get_IsMinor() { }

	// RVA: 0x4E7220 Offset: 0x4E6420 VA: 0x1804E7220
	public void set_IsMinor(bool value) { }

	// RVA: 0x4E70F0 Offset: 0x4E62F0 VA: 0x1804E70F0
	public Utf8String get_ParentEmail() { }

	// RVA: 0x4E7340 Offset: 0x4E6540 VA: 0x1804E7340
	public void set_ParentEmail(Utf8String value) { }

	// RVA: 0x4E6CF0 Offset: 0x4E5EF0 VA: 0x1804E6CF0 Slot: 6
	public void Set(ref QueryPermissionsCallbackInfo other) { }

	// RVA: 0x4E6A80 Offset: 0x4E5C80 VA: 0x1804E6A80 Slot: 7
	public void Set(ref Nullable<QueryPermissionsCallbackInfo> other) { }

	// RVA: 0x4E69D0 Offset: 0x4E5BD0 VA: 0x1804E69D0 Slot: 8
	public void Dispose() { }

	// RVA: 0x4E6A50 Offset: 0x4E5C50 VA: 0x1804E6A50 Slot: 5
	public void Get(out QueryPermissionsCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.KWS
public struct QueryPermissionsOptions // TypeDefIndex: 9448
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

// Namespace: Epic.OnlineServices.KWS
internal struct QueryPermissionsOptionsInternal : ISettable<QueryPermissionsOptions>, IDisposable // TypeDefIndex: 9449
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8

	// Properties
	public ProductUserId LocalUserId { set; }

	// Methods

	// RVA: 0x4E7720 Offset: 0x4E6920 VA: 0x1804E7720
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x4E76C0 Offset: 0x4E68C0 VA: 0x1804E76C0 Slot: 4
	public void Set(ref QueryPermissionsOptions other) { }

	// RVA: 0x4E7620 Offset: 0x4E6820 VA: 0x1804E7620 Slot: 5
	public void Set(ref Nullable<QueryPermissionsOptions> other) { }

	// RVA: 0x4E75D0 Offset: 0x4E67D0 VA: 0x1804E75D0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.KWS
public struct RequestPermissionsCallbackInfo : ICallbackInfo // TypeDefIndex: 9450
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

	// RVA: 0x4E8B90 Offset: 0x4E7D90 VA: 0x1804E8B90 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x4E8BE0 Offset: 0x4E7DE0 VA: 0x1804E8BE0
	internal void Set(ref RequestPermissionsCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.KWS
internal struct RequestPermissionsCallbackInfoInternal : ICallbackInfoInternal, IGettable<RequestPermissionsCallbackInfo>, ISettable<RequestPermissionsCallbackInfo>, IDisposable // TypeDefIndex: 9451
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

	// RVA: 0x4E89E0 Offset: 0x4E7BE0 VA: 0x1804E89E0
	public object get_ClientData() { }

	// RVA: 0x4E8AD0 Offset: 0x4E7CD0 VA: 0x1804E8AD0
	public void set_ClientData(object value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x4E8A50 Offset: 0x4E7C50 VA: 0x1804E8A50
	public ProductUserId get_LocalUserId() { }

	// RVA: 0x4E8B30 Offset: 0x4E7D30 VA: 0x1804E8B30
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x4E8810 Offset: 0x4E7A10 VA: 0x1804E8810 Slot: 6
	public void Set(ref RequestPermissionsCallbackInfo other) { }

	// RVA: 0x4E88C0 Offset: 0x4E7AC0 VA: 0x1804E88C0 Slot: 7
	public void Set(ref Nullable<RequestPermissionsCallbackInfo> other) { }

	// RVA: 0x4E8790 Offset: 0x4E7990 VA: 0x1804E8790 Slot: 8
	public void Dispose() { }

	// RVA: 0x4E87F0 Offset: 0x4E79F0 VA: 0x1804E87F0 Slot: 5
	public void Get(out RequestPermissionsCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.KWS
public struct RequestPermissionsOptions // TypeDefIndex: 9452
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String[] <PermissionKeys>k__BackingField; // 0x8

	// Properties
	public ProductUserId LocalUserId { get; set; }
	public Utf8String[] PermissionKeys { get; set; }

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
	public Utf8String[] get_PermissionKeys() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_PermissionKeys(Utf8String[] value) { }
}

// Namespace: Epic.OnlineServices.KWS
internal struct RequestPermissionsOptionsInternal : ISettable<RequestPermissionsOptions>, IDisposable // TypeDefIndex: 9453
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private uint m_PermissionKeyCount; // 0x10
	private IntPtr m_PermissionKeys; // 0x18

	// Properties
	public ProductUserId LocalUserId { set; }
	public Utf8String[] PermissionKeys { set; }

	// Methods

	// RVA: 0x4E8E20 Offset: 0x4E8020 VA: 0x1804E8E20
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x4E8E80 Offset: 0x4E8080 VA: 0x1804E8E80
	public void set_PermissionKeys(Utf8String[] value) { }

	// RVA: 0x4E8CD0 Offset: 0x4E7ED0 VA: 0x1804E8CD0 Slot: 4
	public void Set(ref RequestPermissionsOptions other) { }

	// RVA: 0x4E8D50 Offset: 0x4E7F50 VA: 0x1804E8D50 Slot: 5
	public void Set(ref Nullable<RequestPermissionsOptions> other) { }

	// RVA: 0x4E8C70 Offset: 0x4E7E70 VA: 0x1804E8C70 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.KWS
public struct UpdateParentEmailCallbackInfo : ICallbackInfo // TypeDefIndex: 9454
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

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x4EAFA0 Offset: 0x4EA1A0 VA: 0x1804EAFA0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x4EAFF0 Offset: 0x4EA1F0 VA: 0x1804EAFF0
	internal void Set(ref UpdateParentEmailCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.KWS
internal struct UpdateParentEmailCallbackInfoInternal : ICallbackInfoInternal, IGettable<UpdateParentEmailCallbackInfo>, ISettable<UpdateParentEmailCallbackInfo>, IDisposable // TypeDefIndex: 9455
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

	// RVA: 0x4EADF0 Offset: 0x4E9FF0 VA: 0x1804EADF0
	public object get_ClientData() { }

	// RVA: 0x4EAEE0 Offset: 0x4EA0E0 VA: 0x1804EAEE0
	public void set_ClientData(object value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x4EAE60 Offset: 0x4EA060 VA: 0x1804EAE60
	public ProductUserId get_LocalUserId() { }

	// RVA: 0x4EAF40 Offset: 0x4EA140 VA: 0x1804EAF40
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x4EAC20 Offset: 0x4E9E20 VA: 0x1804EAC20 Slot: 6
	public void Set(ref UpdateParentEmailCallbackInfo other) { }

	// RVA: 0x4EACD0 Offset: 0x4E9ED0 VA: 0x1804EACD0 Slot: 7
	public void Set(ref Nullable<UpdateParentEmailCallbackInfo> other) { }

	// RVA: 0x4EABA0 Offset: 0x4E9DA0 VA: 0x1804EABA0 Slot: 8
	public void Dispose() { }

	// RVA: 0x4EAC00 Offset: 0x4E9E00 VA: 0x1804EAC00 Slot: 5
	public void Get(out UpdateParentEmailCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.KWS
public struct UpdateParentEmailOptions // TypeDefIndex: 9456
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <ParentEmail>k__BackingField; // 0x8

	// Properties
	public ProductUserId LocalUserId { get; set; }
	public Utf8String ParentEmail { get; set; }

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
	public Utf8String get_ParentEmail() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_ParentEmail(Utf8String value) { }
}

// Namespace: Epic.OnlineServices.KWS
internal struct UpdateParentEmailOptionsInternal : ISettable<UpdateParentEmailOptions>, IDisposable // TypeDefIndex: 9457
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_ParentEmail; // 0x10

	// Properties
	public ProductUserId LocalUserId { set; }
	public Utf8String ParentEmail { set; }

	// Methods

	// RVA: 0x4EB2A0 Offset: 0x4EA4A0 VA: 0x1804EB2A0
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x4EB300 Offset: 0x4EA500 VA: 0x1804EB300
	public void set_ParentEmail(Utf8String value) { }

	// RVA: 0x4EB0E0 Offset: 0x4EA2E0 VA: 0x1804EB0E0 Slot: 4
	public void Set(ref UpdateParentEmailOptions other) { }

	// RVA: 0x4EB1A0 Offset: 0x4EA3A0 VA: 0x1804EB1A0 Slot: 5
	public void Set(ref Nullable<UpdateParentEmailOptions> other) { }

	// RVA: 0x4EB080 Offset: 0x4EA280 VA: 0x1804EB080 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Inventory
public struct CheckpointOptions // TypeDefIndex: 9458
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private ProductUserId <TargetUserId>k__BackingField; // 0x8
	[CompilerGenerated]
	private Utf8String <InventoryName>k__BackingField; // 0x10

	// Properties
	public ProductUserId LocalUserId { get; set; }
	public ProductUserId TargetUserId { get; set; }
	public Utf8String InventoryName { get; set; }

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
	public ProductUserId get_TargetUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_TargetUserId(ProductUserId value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Utf8String get_InventoryName() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_InventoryName(Utf8String value) { }
}

// Namespace: Epic.OnlineServices.Inventory
internal struct CheckpointOptionsInternal : ISettable<CheckpointOptions>, IDisposable // TypeDefIndex: 9459
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_TargetUserId; // 0x10
	private IntPtr m_InventoryName; // 0x18

	// Properties
	public ProductUserId LocalUserId { set; }
	public ProductUserId TargetUserId { set; }
	public Utf8String InventoryName { set; }

	// Methods

	// RVA: 0x4D3EC0 Offset: 0x4D30C0 VA: 0x1804D3EC0
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x4D3F20 Offset: 0x4D3120 VA: 0x1804D3F20
	public void set_TargetUserId(ProductUserId value) { }

	// RVA: 0x4D3E60 Offset: 0x4D3060 VA: 0x1804D3E60
	public void set_InventoryName(Utf8String value) { }

	// RVA: 0x4D3C00 Offset: 0x4D2E00 VA: 0x1804D3C00 Slot: 4
	public void Set(ref CheckpointOptions other) { }

	// RVA: 0x4D3D00 Offset: 0x4D2F00 VA: 0x1804D3D00 Slot: 5
	public void Set(ref Nullable<CheckpointOptions> other) { }

	// RVA: 0x4D3BA0 Offset: 0x4D2DA0 VA: 0x1804D3BA0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Inventory
public struct CloseOptions // TypeDefIndex: 9460
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private ProductUserId <TargetUserId>k__BackingField; // 0x8
	[CompilerGenerated]
	private Utf8String <InventoryName>k__BackingField; // 0x10

	// Properties
	public ProductUserId LocalUserId { get; set; }
	public ProductUserId TargetUserId { get; set; }
	public Utf8String InventoryName { get; set; }

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
	public ProductUserId get_TargetUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_TargetUserId(ProductUserId value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Utf8String get_InventoryName() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_InventoryName(Utf8String value) { }
}

// Namespace: Epic.OnlineServices.Inventory
internal struct CloseOptionsInternal : ISettable<CloseOptions>, IDisposable // TypeDefIndex: 9461
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_TargetUserId; // 0x10
	private IntPtr m_InventoryName; // 0x18

	// Properties
	public ProductUserId LocalUserId { set; }
	public ProductUserId TargetUserId { set; }
	public Utf8String InventoryName { set; }

	// Methods

	// RVA: 0x4D42A0 Offset: 0x4D34A0 VA: 0x1804D42A0
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x4D4300 Offset: 0x4D3500 VA: 0x1804D4300
	public void set_TargetUserId(ProductUserId value) { }

	// RVA: 0x4D4240 Offset: 0x4D3440 VA: 0x1804D4240
	public void set_InventoryName(Utf8String value) { }

	// RVA: 0x4D4140 Offset: 0x4D3340 VA: 0x1804D4140 Slot: 4
	public void Set(ref CloseOptions other) { }

	// RVA: 0x4D3FE0 Offset: 0x4D31E0 VA: 0x1804D3FE0 Slot: 5
	public void Set(ref Nullable<CloseOptions> other) { }

	// RVA: 0x4D3F80 Offset: 0x4D3180 VA: 0x1804D3F80 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Inventory
public struct CreateOptions // TypeDefIndex: 9462
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private ProductUserId <TargetUserId>k__BackingField; // 0x8
	[CompilerGenerated]
	private Utf8String <InventoryName>k__BackingField; // 0x10

	// Properties
	public ProductUserId LocalUserId { get; set; }
	public ProductUserId TargetUserId { get; set; }
	public Utf8String InventoryName { get; set; }

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
	public ProductUserId get_TargetUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_TargetUserId(ProductUserId value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Utf8String get_InventoryName() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_InventoryName(Utf8String value) { }
}

// Namespace: Epic.OnlineServices.Inventory
internal struct CreateOptionsInternal : ISettable<CreateOptions>, IDisposable // TypeDefIndex: 9463
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_TargetUserId; // 0x10
	private IntPtr m_InventoryName; // 0x18

	// Properties
	public ProductUserId LocalUserId { set; }
	public ProductUserId TargetUserId { set; }
	public Utf8String InventoryName { set; }

	// Methods

	// RVA: 0x4D5150 Offset: 0x4D4350 VA: 0x1804D5150
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x4D51B0 Offset: 0x4D43B0 VA: 0x1804D51B0
	public void set_TargetUserId(ProductUserId value) { }

	// RVA: 0x4D50F0 Offset: 0x4D42F0 VA: 0x1804D50F0
	public void set_InventoryName(Utf8String value) { }

	// RVA: 0x4D4FF0 Offset: 0x4D41F0 VA: 0x1804D4FF0 Slot: 4
	public void Set(ref CreateOptions other) { }

	// RVA: 0x4D4E90 Offset: 0x4D4090 VA: 0x1804D4E90 Slot: 5
	public void Set(ref Nullable<CreateOptions> other) { }

	// RVA: 0x4D4E30 Offset: 0x4D4030 VA: 0x1804D4E30 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Inventory
public sealed class InventoryInterface : Handle // TypeDefIndex: 9464
{
	// Fields
	public const int CheckpointApiLatest = 1;
	public const int CloseApiLatest = 1;
	public const int CreateApiLatest = 1;
	public const int OpenApiLatest = 1;

	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }

	// RVA: 0x40BDB0 Offset: 0x40AFB0 VA: 0x18040BDB0
	public void .ctor(IntPtr innerHandle) { }

	// RVA: 0x4D6EA0 Offset: 0x4D60A0 VA: 0x1804D6EA0
	public void Checkpoint(ref CheckpointOptions options, object clientData, OnCheckpointCompleteCallback completionDelegate) { }

	// RVA: 0x4D6FE0 Offset: 0x4D61E0 VA: 0x1804D6FE0
	public void Close(ref CloseOptions options, object clientData, OnCloseCompleteCallback completionDelegate) { }

	// RVA: 0x4D7120 Offset: 0x4D6320 VA: 0x1804D7120
	public void Create(ref CreateOptions options, object clientData, OnCreateCompleteCallback completionDelegate) { }

	// RVA: 0x4D7500 Offset: 0x4D6700 VA: 0x1804D7500
	public void Open(ref OpenOptions options, object clientData, OnOpenCompleteCallback completionDelegate) { }

	[MonoPInvokeCallback(typeof(OnCheckpointCompleteCallbackInternal))]
	// RVA: 0x4D7260 Offset: 0x4D6460 VA: 0x1804D7260
	internal static void OnCheckpointCompleteCallbackInternalImplementation(ref OnCheckpointCompleteCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnCloseCompleteCallbackInternal))]
	// RVA: 0x4D7300 Offset: 0x4D6500 VA: 0x1804D7300
	internal static void OnCloseCompleteCallbackInternalImplementation(ref OnCloseCompleteCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnCreateCompleteCallbackInternal))]
	// RVA: 0x4D73A0 Offset: 0x4D65A0 VA: 0x1804D73A0
	internal static void OnCreateCompleteCallbackInternalImplementation(ref OnCreateCompleteCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnOpenCompleteCallbackInternal))]
	// RVA: 0x4D7450 Offset: 0x4D6650 VA: 0x1804D7450
	internal static void OnOpenCompleteCallbackInternalImplementation(ref OnOpenCompleteCallbackInfoInternal data) { }
}

// Namespace: Epic.OnlineServices.Inventory
public sealed class InventoryItem : Handle // TypeDefIndex: 9465
{
	// Fields
	public const int InventoryitemCreatesubitemApiLatest = 1;
	public const int InventoryitemDeletesubitemApiLatest = 1;
	public const int InventoryitemGetdoublesetvaluebyindexApiLatest = 1;
	public const int InventoryitemGetint64SetvaluebyindexApiLatest = 1;
	public const int InventoryitemGetkeyApiLatest = 1;
	public const int InventoryitemGetstringsetvaluebyindexApiLatest = 1;
	public const int InventoryitemGetsubitemApiLatest = 1;
	public const int InventoryitemGetsubitembyindexApiLatest = 1;
	public const int InventoryitemGetsubitemscountApiLatest = 1;
	public const int InventoryitemGetvalueasboolApiLatest = 1;
	public const int InventoryitemGetvalueasdoubleApiLatest = 1;
	public const int InventoryitemGetvalueasint64ApiLatest = 1;
	public const int InventoryitemGetvalueasstringApiLatest = 1;
	public const int InventoryitemGetvalueastimestampApiLatest = 1;
	public const int InventoryitemGetvaluecountApiLatest = 1;
	public const int InventoryitemGetvaluetypeApiLatest = 1;
	public const int InventoryitemKeyMaxLength = 256;
	public const int InventoryitemSetkeyApiLatest = 1;
	public const int InventoryitemSetvalueasboolApiLatest = 1;
	public const int InventoryitemSetvalueasdoubleApiLatest = 1;
	public const int InventoryitemSetvalueasdoublesetApiLatest = 1;
	public const int InventoryitemSetvalueasint64ApiLatest = 1;
	public const int InventoryitemSetvalueasint64SetApiLatest = 1;
	public const int InventoryitemSetvalueasstringApiLatest = 1;
	public const int InventoryitemSetvalueasstringsetApiLatest = 1;
	public const int InventoryitemSetvalueastimestampApiLatest = 1;
	public const int InventoryitemStringValueMaxLength = 393216;

	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }

	// RVA: 0x40BDB0 Offset: 0x40AFB0 VA: 0x18040BDB0
	public void .ctor(IntPtr innerHandle) { }

	// RVA: 0x4D7640 Offset: 0x4D6840 VA: 0x1804D7640
	public Result CreateSubItem(ref InventoryItemCreateSubItemOptions options, out InventoryItem outInventoryItemHandle) { }

	// RVA: 0x4D7720 Offset: 0x4D6920 VA: 0x1804D7720
	public Result DeleteSubItem(ref InventoryItemDeleteSubItemOptions options) { }

	// RVA: 0x4D77C0 Offset: 0x4D69C0 VA: 0x1804D77C0
	public Result GetDoubleSetValueByIndex(ref InventoryItemGetDoubleSetValueByIndexOptions options, out double outValue) { }

	// RVA: 0x4D7890 Offset: 0x4D6A90 VA: 0x1804D7890
	public Result GetInt64SetValueByIndex(ref InventoryItemGetInt64SetValueByIndexOptions options, out long outValue) { }

	// RVA: 0x4D7960 Offset: 0x4D6B60 VA: 0x1804D7960
	public Result GetKey(ref InventoryItemGetKeyOptions options, out Utf8String outKey) { }

	// RVA: 0x4D7A40 Offset: 0x4D6C40 VA: 0x1804D7A40
	public Result GetStringSetValueByIndex(ref InventoryItemGetStringSetValueByIndexOptions options, out Utf8String outValue) { }

	// RVA: 0x4D7C00 Offset: 0x4D6E00 VA: 0x1804D7C00
	public Result GetSubItem(ref InventoryItemGetSubItemOptions options, out InventoryItem outInventoryItemHandle) { }

	// RVA: 0x4D7B20 Offset: 0x4D6D20 VA: 0x1804D7B20
	public Result GetSubItemByIndex(ref InventoryItemGetSubItemByIndexOptions options, out InventoryItem outInventoryItemHandle) { }

	// RVA: 0x4D7CE0 Offset: 0x4D6EE0 VA: 0x1804D7CE0
	public uint GetSubItemsCount(ref InventoryItemGetSubItemsCountOptions options) { }

	// RVA: 0x4D7D80 Offset: 0x4D6F80 VA: 0x1804D7D80
	public Result GetValueAsBool(ref InventoryItemGetValueAsBoolOptions options, out bool outValue) { }

	// RVA: 0x4D7E40 Offset: 0x4D7040 VA: 0x1804D7E40
	public Result GetValueAsDouble(ref InventoryItemGetValueAsDoubleOptions options, out double outValue) { }

	// RVA: 0x4D7F10 Offset: 0x4D7110 VA: 0x1804D7F10
	public Result GetValueAsInt64(ref InventoryItemGetValueAsInt64Options options, out long outValue) { }

	// RVA: 0x4D7FE0 Offset: 0x4D71E0 VA: 0x1804D7FE0
	public Result GetValueAsString(ref InventoryItemGetValueAsStringOptions options, out Utf8String outValue) { }

	// RVA: 0x4D80C0 Offset: 0x4D72C0 VA: 0x1804D80C0
	public Result GetValueAsTimestamp(ref InventoryItemGetValueAsTimestampOptions options, out long outValue) { }

	// RVA: 0x4D8190 Offset: 0x4D7390 VA: 0x1804D8190
	public uint GetValueCount(ref InventoryItemGetValueCountOptions options) { }

	// RVA: 0x4D8230 Offset: 0x4D7430 VA: 0x1804D8230
	public Result GetValueType(ref InventoryItemGetValueTypeOptions options, out ValueType outValueType) { }

	// RVA: 0x4D82F0 Offset: 0x4D74F0 VA: 0x1804D82F0
	public Result SetKey(ref InventoryItemSetKeyOptions options) { }

	// RVA: 0x4D8390 Offset: 0x4D7590 VA: 0x1804D8390
	public Result SetValueAsBool(ref InventoryItemSetValueAsBoolOptions options) { }

	// RVA: 0x4D84D0 Offset: 0x4D76D0 VA: 0x1804D84D0
	public Result SetValueAsDouble(ref InventoryItemSetValueAsDoubleOptions options) { }

	// RVA: 0x4D8430 Offset: 0x4D7630 VA: 0x1804D8430
	public Result SetValueAsDoubleSet(ref InventoryItemSetValueAsDoubleSetOptions options) { }

	// RVA: 0x4D8610 Offset: 0x4D7810 VA: 0x1804D8610
	public Result SetValueAsInt64(ref InventoryItemSetValueAsInt64Options options) { }

	// RVA: 0x4D8570 Offset: 0x4D7770 VA: 0x1804D8570
	public Result SetValueAsInt64Set(ref InventoryItemSetValueAsInt64SetOptions options) { }

	// RVA: 0x4D8750 Offset: 0x4D7950 VA: 0x1804D8750
	public Result SetValueAsString(ref InventoryItemSetValueAsStringOptions options) { }

	// RVA: 0x4D86B0 Offset: 0x4D78B0 VA: 0x1804D86B0
	public Result SetValueAsStringSet(ref InventoryItemSetValueAsStringSetOptions options) { }

	// RVA: 0x4D87F0 Offset: 0x4D79F0 VA: 0x1804D87F0
	public Result SetValueAsTimestamp(ref InventoryItemSetValueAsTimestampOptions options) { }
}

// Namespace: Epic.OnlineServices.Inventory
public struct InventoryItemCreateSubItemOptions // TypeDefIndex: 9466
{
	// Fields
	[CompilerGenerated]
	private Utf8String <Key>k__BackingField; // 0x0

	// Properties
	public Utf8String Key { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Utf8String get_Key() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_Key(Utf8String value) { }
}

// Namespace: Epic.OnlineServices.Inventory
internal struct InventoryItemCreateSubItemOptionsInternal : ISettable<InventoryItemCreateSubItemOptions>, IDisposable // TypeDefIndex: 9467
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_Key; // 0x8

	// Properties
	public Utf8String Key { set; }

	// Methods

	// RVA: 0x4F8CC0 Offset: 0x4F7EC0 VA: 0x1804F8CC0
	public void set_Key(Utf8String value) { }

	// RVA: 0x4F8BC0 Offset: 0x4F7DC0 VA: 0x1804F8BC0 Slot: 4
	public void Set(ref InventoryItemCreateSubItemOptions other) { }

	// RVA: 0x4F8C20 Offset: 0x4F7E20 VA: 0x1804F8C20 Slot: 5
	public void Set(ref Nullable<InventoryItemCreateSubItemOptions> other) { }

	// RVA: 0x4F8B70 Offset: 0x4F7D70 VA: 0x1804F8B70 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Inventory
public struct InventoryItemDeleteSubItemOptions // TypeDefIndex: 9468
{
	// Fields
	[CompilerGenerated]
	private Utf8String <Key>k__BackingField; // 0x0

	// Properties
	public Utf8String Key { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Utf8String get_Key() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_Key(Utf8String value) { }
}

// Namespace: Epic.OnlineServices.Inventory
internal struct InventoryItemDeleteSubItemOptionsInternal : ISettable<InventoryItemDeleteSubItemOptions>, IDisposable // TypeDefIndex: 9469
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_Key; // 0x8

	// Properties
	public Utf8String Key { set; }

	// Methods

	// RVA: 0x4F8E70 Offset: 0x4F8070 VA: 0x1804F8E70
	public void set_Key(Utf8String value) { }

	// RVA: 0x4F8D70 Offset: 0x4F7F70 VA: 0x1804F8D70 Slot: 4
	public void Set(ref InventoryItemDeleteSubItemOptions other) { }

	// RVA: 0x4F8DD0 Offset: 0x4F7FD0 VA: 0x1804F8DD0 Slot: 5
	public void Set(ref Nullable<InventoryItemDeleteSubItemOptions> other) { }

	// RVA: 0x4F8D20 Offset: 0x4F7F20 VA: 0x1804F8D20 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Inventory
public struct InventoryItemGetDoubleSetValueByIndexOptions // TypeDefIndex: 9470
{
	// Fields
	[CompilerGenerated]
	private uint <SetValueIndex>k__BackingField; // 0x0

	// Properties
	public uint SetValueIndex { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public uint get_SetValueIndex() { }

	[CompilerGenerated]
	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_SetValueIndex(uint value) { }
}

// Namespace: Epic.OnlineServices.Inventory
internal struct InventoryItemGetDoubleSetValueByIndexOptionsInternal : ISettable<InventoryItemGetDoubleSetValueByIndexOptions>, IDisposable // TypeDefIndex: 9471
{
	// Fields
	private int m_ApiVersion; // 0x0
	private uint m_SetValueIndex; // 0x4

	// Properties
	public uint SetValueIndex { set; }

	// Methods

	// RVA: 0x3F84A0 Offset: 0x3F76A0 VA: 0x1803F84A0
	public void set_SetValueIndex(uint value) { }

	// RVA: 0x40B2E0 Offset: 0x40A4E0 VA: 0x18040B2E0 Slot: 4
	public void Set(ref InventoryItemGetDoubleSetValueByIndexOptions other) { }

	// RVA: 0x4F8ED0 Offset: 0x4F80D0 VA: 0x1804F8ED0 Slot: 5
	public void Set(ref Nullable<InventoryItemGetDoubleSetValueByIndexOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Inventory
public struct InventoryItemGetInt64SetValueByIndexOptions // TypeDefIndex: 9472
{
	// Fields
	[CompilerGenerated]
	private uint <SetValueIndex>k__BackingField; // 0x0

	// Properties
	public uint SetValueIndex { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public uint get_SetValueIndex() { }

	[CompilerGenerated]
	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_SetValueIndex(uint value) { }
}

// Namespace: Epic.OnlineServices.Inventory
internal struct InventoryItemGetInt64SetValueByIndexOptionsInternal : ISettable<InventoryItemGetInt64SetValueByIndexOptions>, IDisposable // TypeDefIndex: 9473
{
	// Fields
	private int m_ApiVersion; // 0x0
	private uint m_SetValueIndex; // 0x4

	// Properties
	public uint SetValueIndex { set; }

	// Methods

	// RVA: 0x3F84A0 Offset: 0x3F76A0 VA: 0x1803F84A0
	public void set_SetValueIndex(uint value) { }

	// RVA: 0x40B2E0 Offset: 0x40A4E0 VA: 0x18040B2E0 Slot: 4
	public void Set(ref InventoryItemGetInt64SetValueByIndexOptions other) { }

	// RVA: 0x4F8F30 Offset: 0x4F8130 VA: 0x1804F8F30 Slot: 5
	public void Set(ref Nullable<InventoryItemGetInt64SetValueByIndexOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Inventory
public struct InventoryItemGetKeyOptions // TypeDefIndex: 9474
{}

// Namespace: Epic.OnlineServices.Inventory
internal struct InventoryItemGetKeyOptionsInternal : ISettable<InventoryItemGetKeyOptions>, IDisposable // TypeDefIndex: 9475
{
	// Fields
	private int m_ApiVersion; // 0x0

	// Methods

	// RVA: 0x3F98A0 Offset: 0x3F8AA0 VA: 0x1803F98A0 Slot: 4
	public void Set(ref InventoryItemGetKeyOptions other) { }

	// RVA: 0x4F8F90 Offset: 0x4F8190 VA: 0x1804F8F90 Slot: 5
	public void Set(ref Nullable<InventoryItemGetKeyOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Inventory
public struct InventoryItemGetStringSetValueByIndexOptions // TypeDefIndex: 9476
{
	// Fields
	[CompilerGenerated]
	private uint <SetValueIndex>k__BackingField; // 0x0

	// Properties
	public uint SetValueIndex { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public uint get_SetValueIndex() { }

	[CompilerGenerated]
	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_SetValueIndex(uint value) { }
}

// Namespace: Epic.OnlineServices.Inventory
internal struct InventoryItemGetStringSetValueByIndexOptionsInternal : ISettable<InventoryItemGetStringSetValueByIndexOptions>, IDisposable // TypeDefIndex: 9477
{
	// Fields
	private int m_ApiVersion; // 0x0
	private uint m_SetValueIndex; // 0x4

	// Properties
	public uint SetValueIndex { set; }

	// Methods

	// RVA: 0x3F84A0 Offset: 0x3F76A0 VA: 0x1803F84A0
	public void set_SetValueIndex(uint value) { }

	// RVA: 0x40B2E0 Offset: 0x40A4E0 VA: 0x18040B2E0 Slot: 4
	public void Set(ref InventoryItemGetStringSetValueByIndexOptions other) { }

	// RVA: 0x4F8FE0 Offset: 0x4F81E0 VA: 0x1804F8FE0 Slot: 5
	public void Set(ref Nullable<InventoryItemGetStringSetValueByIndexOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Inventory
public struct InventoryItemGetSubItemByIndexOptions // TypeDefIndex: 9478
{
	// Fields
	[CompilerGenerated]
	private uint <SubItemIndex>k__BackingField; // 0x0

	// Properties
	public uint SubItemIndex { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public uint get_SubItemIndex() { }

	[CompilerGenerated]
	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_SubItemIndex(uint value) { }
}

// Namespace: Epic.OnlineServices.Inventory
internal struct InventoryItemGetSubItemByIndexOptionsInternal : ISettable<InventoryItemGetSubItemByIndexOptions>, IDisposable // TypeDefIndex: 9479
{
	// Fields
	private int m_ApiVersion; // 0x0
	private uint m_SubItemIndex; // 0x4

	// Properties
	public uint SubItemIndex { set; }

	// Methods

	// RVA: 0x3F84A0 Offset: 0x3F76A0 VA: 0x1803F84A0
	public void set_SubItemIndex(uint value) { }

	// RVA: 0x40B2E0 Offset: 0x40A4E0 VA: 0x18040B2E0 Slot: 4
	public void Set(ref InventoryItemGetSubItemByIndexOptions other) { }

	// RVA: 0x4F9040 Offset: 0x4F8240 VA: 0x1804F9040 Slot: 5
	public void Set(ref Nullable<InventoryItemGetSubItemByIndexOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Inventory
public struct InventoryItemGetSubItemOptions // TypeDefIndex: 9480
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

// Namespace: Epic.OnlineServices.Inventory
internal struct InventoryItemGetSubItemOptionsInternal : ISettable<InventoryItemGetSubItemOptions>, IDisposable // TypeDefIndex: 9481
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_Key; // 0x8

	// Properties
	public Utf8String Key { set; }

	// Methods

	// RVA: 0x4F91F0 Offset: 0x4F83F0 VA: 0x1804F91F0
	public void set_Key(Utf8String value) { }

	// RVA: 0x4F90F0 Offset: 0x4F82F0 VA: 0x1804F90F0 Slot: 4
	public void Set(ref InventoryItemGetSubItemOptions other) { }

	// RVA: 0x4F9150 Offset: 0x4F8350 VA: 0x1804F9150 Slot: 5
	public void Set(ref Nullable<InventoryItemGetSubItemOptions> other) { }

	// RVA: 0x4F90A0 Offset: 0x4F82A0 VA: 0x1804F90A0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Inventory
public struct InventoryItemGetSubItemsCountOptions // TypeDefIndex: 9482
{}

// Namespace: Epic.OnlineServices.Inventory
internal struct InventoryItemGetSubItemsCountOptionsInternal : ISettable<InventoryItemGetSubItemsCountOptions>, IDisposable // TypeDefIndex: 9483
{
	// Fields
	private int m_ApiVersion; // 0x0

	// Methods

	// RVA: 0x3F98A0 Offset: 0x3F8AA0 VA: 0x1803F98A0 Slot: 4
	public void Set(ref InventoryItemGetSubItemsCountOptions other) { }

	// RVA: 0x4F9250 Offset: 0x4F8450 VA: 0x1804F9250 Slot: 5
	public void Set(ref Nullable<InventoryItemGetSubItemsCountOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Inventory
public struct InventoryItemGetValueAsBoolOptions // TypeDefIndex: 9484
{}

// Namespace: Epic.OnlineServices.Inventory
internal struct InventoryItemGetValueAsBoolOptionsInternal : ISettable<InventoryItemGetValueAsBoolOptions>, IDisposable // TypeDefIndex: 9485
{
	// Fields
	private int m_ApiVersion; // 0x0

	// Methods

	// RVA: 0x3F98A0 Offset: 0x3F8AA0 VA: 0x1803F98A0 Slot: 4
	public void Set(ref InventoryItemGetValueAsBoolOptions other) { }

	// RVA: 0x4F92A0 Offset: 0x4F84A0 VA: 0x1804F92A0 Slot: 5
	public void Set(ref Nullable<InventoryItemGetValueAsBoolOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Inventory
public struct InventoryItemGetValueAsDoubleOptions // TypeDefIndex: 9486
{}

// Namespace: Epic.OnlineServices.Inventory
internal struct InventoryItemGetValueAsDoubleOptionsInternal : ISettable<InventoryItemGetValueAsDoubleOptions>, IDisposable // TypeDefIndex: 9487
{
	// Fields
	private int m_ApiVersion; // 0x0

	// Methods

	// RVA: 0x3F98A0 Offset: 0x3F8AA0 VA: 0x1803F98A0 Slot: 4
	public void Set(ref InventoryItemGetValueAsDoubleOptions other) { }

	// RVA: 0x4F92F0 Offset: 0x4F84F0 VA: 0x1804F92F0 Slot: 5
	public void Set(ref Nullable<InventoryItemGetValueAsDoubleOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Inventory
public struct InventoryItemGetValueAsInt64Options // TypeDefIndex: 9488
{}

// Namespace: Epic.OnlineServices.Inventory
internal struct InventoryItemGetValueAsInt64OptionsInternal : ISettable<InventoryItemGetValueAsInt64Options>, IDisposable // TypeDefIndex: 9489
{
	// Fields
	private int m_ApiVersion; // 0x0

	// Methods

	// RVA: 0x3F98A0 Offset: 0x3F8AA0 VA: 0x1803F98A0 Slot: 4
	public void Set(ref InventoryItemGetValueAsInt64Options other) { }

	// RVA: 0x4F9340 Offset: 0x4F8540 VA: 0x1804F9340 Slot: 5
	public void Set(ref Nullable<InventoryItemGetValueAsInt64Options> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Inventory
public struct InventoryItemGetValueAsStringOptions // TypeDefIndex: 9490
{}

// Namespace: Epic.OnlineServices.Inventory
internal struct InventoryItemGetValueAsStringOptionsInternal : ISettable<InventoryItemGetValueAsStringOptions>, IDisposable // TypeDefIndex: 9491
{
	// Fields
	private int m_ApiVersion; // 0x0

	// Methods

	// RVA: 0x3F98A0 Offset: 0x3F8AA0 VA: 0x1803F98A0 Slot: 4
	public void Set(ref InventoryItemGetValueAsStringOptions other) { }

	// RVA: 0x4F9390 Offset: 0x4F8590 VA: 0x1804F9390 Slot: 5
	public void Set(ref Nullable<InventoryItemGetValueAsStringOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Inventory
public struct InventoryItemGetValueAsTimestampOptions // TypeDefIndex: 9492
{}

// Namespace: Epic.OnlineServices.Inventory
internal struct InventoryItemGetValueAsTimestampOptionsInternal : ISettable<InventoryItemGetValueAsTimestampOptions>, IDisposable // TypeDefIndex: 9493
{
	// Fields
	private int m_ApiVersion; // 0x0

	// Methods

	// RVA: 0x3F98A0 Offset: 0x3F8AA0 VA: 0x1803F98A0 Slot: 4
	public void Set(ref InventoryItemGetValueAsTimestampOptions other) { }

	// RVA: 0x4F93E0 Offset: 0x4F85E0 VA: 0x1804F93E0 Slot: 5
	public void Set(ref Nullable<InventoryItemGetValueAsTimestampOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Inventory
public struct InventoryItemGetValueCountOptions // TypeDefIndex: 9494
{}

// Namespace: Epic.OnlineServices.Inventory
internal struct InventoryItemGetValueCountOptionsInternal : ISettable<InventoryItemGetValueCountOptions>, IDisposable // TypeDefIndex: 9495
{
	// Fields
	private int m_ApiVersion; // 0x0

	// Methods

	// RVA: 0x3F98A0 Offset: 0x3F8AA0 VA: 0x1803F98A0 Slot: 4
	public void Set(ref InventoryItemGetValueCountOptions other) { }

	// RVA: 0x4F9430 Offset: 0x4F8630 VA: 0x1804F9430 Slot: 5
	public void Set(ref Nullable<InventoryItemGetValueCountOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Inventory
public struct InventoryItemGetValueTypeOptions // TypeDefIndex: 9496
{}

// Namespace: Epic.OnlineServices.Inventory
internal struct InventoryItemGetValueTypeOptionsInternal : ISettable<InventoryItemGetValueTypeOptions>, IDisposable // TypeDefIndex: 9497
{
	// Fields
	private int m_ApiVersion; // 0x0

	// Methods

	// RVA: 0x3F98A0 Offset: 0x3F8AA0 VA: 0x1803F98A0 Slot: 4
	public void Set(ref InventoryItemGetValueTypeOptions other) { }

	// RVA: 0x4F9480 Offset: 0x4F8680 VA: 0x1804F9480 Slot: 5
	public void Set(ref Nullable<InventoryItemGetValueTypeOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Inventory
public struct InventoryItemSetKeyOptions // TypeDefIndex: 9498
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

// Namespace: Epic.OnlineServices.Inventory
internal struct InventoryItemSetKeyOptionsInternal : ISettable<InventoryItemSetKeyOptions>, IDisposable // TypeDefIndex: 9499
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_Key; // 0x8

	// Properties
	public Utf8String Key { set; }

	// Methods

	// RVA: 0x4F9620 Offset: 0x4F8820 VA: 0x1804F9620
	public void set_Key(Utf8String value) { }

	// RVA: 0x4F95C0 Offset: 0x4F87C0 VA: 0x1804F95C0 Slot: 4
	public void Set(ref InventoryItemSetKeyOptions other) { }

	// RVA: 0x4F9520 Offset: 0x4F8720 VA: 0x1804F9520 Slot: 5
	public void Set(ref Nullable<InventoryItemSetKeyOptions> other) { }

	// RVA: 0x4F94D0 Offset: 0x4F86D0 VA: 0x1804F94D0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Inventory
public struct InventoryItemSetValueAsBoolOptions // TypeDefIndex: 9500
{
	// Fields
	[CompilerGenerated]
	private bool <Value>k__BackingField; // 0x0

	// Properties
	public bool Value { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x41D600 Offset: 0x41C800 VA: 0x18041D600
	public bool get_Value() { }

	[CompilerGenerated]
	// RVA: 0x41D610 Offset: 0x41C810 VA: 0x18041D610
	public void set_Value(bool value) { }
}

// Namespace: Epic.OnlineServices.Inventory
internal struct InventoryItemSetValueAsBoolOptionsInternal : ISettable<InventoryItemSetValueAsBoolOptions>, IDisposable // TypeDefIndex: 9501
{
	// Fields
	private int m_ApiVersion; // 0x0
	private int m_Value; // 0x4

	// Properties
	public bool Value { set; }

	// Methods

	// RVA: 0x4F9790 Offset: 0x4F8990 VA: 0x1804F9790
	public void set_Value(bool value) { }

	// RVA: 0x4F9680 Offset: 0x4F8880 VA: 0x1804F9680 Slot: 4
	public void Set(ref InventoryItemSetValueAsBoolOptions other) { }

	// RVA: 0x4F96F0 Offset: 0x4F88F0 VA: 0x1804F96F0 Slot: 5
	public void Set(ref Nullable<InventoryItemSetValueAsBoolOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Inventory
public struct InventoryItemSetValueAsDoubleOptions // TypeDefIndex: 9502
{
	// Fields
	[CompilerGenerated]
	private double <Value>k__BackingField; // 0x0

	// Properties
	public double Value { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x4F9860 Offset: 0x4F8A60 VA: 0x1804F9860
	public double get_Value() { }

	[CompilerGenerated]
	// RVA: 0x4F9870 Offset: 0x4F8A70 VA: 0x1804F9870
	public void set_Value(double value) { }
}

// Namespace: Epic.OnlineServices.Inventory
internal struct InventoryItemSetValueAsDoubleOptionsInternal : ISettable<InventoryItemSetValueAsDoubleOptions>, IDisposable // TypeDefIndex: 9503
{
	// Fields
	private int m_ApiVersion; // 0x0
	private double m_Value; // 0x8

	// Properties
	public double Value { set; }

	// Methods

	// RVA: 0x44F210 Offset: 0x44E410 VA: 0x18044F210
	public void set_Value(double value) { }

	// RVA: 0x40DD30 Offset: 0x40CF30 VA: 0x18040DD30 Slot: 4
	public void Set(ref InventoryItemSetValueAsDoubleOptions other) { }

	// RVA: 0x4F97F0 Offset: 0x4F89F0 VA: 0x1804F97F0 Slot: 5
	public void Set(ref Nullable<InventoryItemSetValueAsDoubleOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Inventory
public struct InventoryItemSetValueAsDoubleSetOptions // TypeDefIndex: 9504
{
	// Fields
	[CompilerGenerated]
	private double[] <Value>k__BackingField; // 0x0

	// Properties
	public double[] Value { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public double[] get_Value() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_Value(double[] value) { }
}

// Namespace: Epic.OnlineServices.Inventory
internal struct InventoryItemSetValueAsDoubleSetOptionsInternal : ISettable<InventoryItemSetValueAsDoubleSetOptions>, IDisposable // TypeDefIndex: 9505
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_Value; // 0x8
	private uint m_ValueCount; // 0x10

	// Properties
	public double[] Value { set; }

	// Methods

	// RVA: 0x4F99C0 Offset: 0x4F8BC0 VA: 0x1804F99C0
	public void set_Value(double[] value) { }

	// RVA: 0x4F98D0 Offset: 0x4F8AD0 VA: 0x1804F98D0 Slot: 4
	public void Set(ref InventoryItemSetValueAsDoubleSetOptions other) { }

	// RVA: 0x4F9950 Offset: 0x4F8B50 VA: 0x1804F9950 Slot: 5
	public void Set(ref Nullable<InventoryItemSetValueAsDoubleSetOptions> other) { }

	// RVA: 0x4F9880 Offset: 0x4F8A80 VA: 0x1804F9880 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Inventory
public struct InventoryItemSetValueAsInt64Options // TypeDefIndex: 9506
{
	// Fields
	[CompilerGenerated]
	private long <Value>k__BackingField; // 0x0

	// Properties
	public long Value { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public long get_Value() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_Value(long value) { }
}

// Namespace: Epic.OnlineServices.Inventory
internal struct InventoryItemSetValueAsInt64OptionsInternal : ISettable<InventoryItemSetValueAsInt64Options>, IDisposable // TypeDefIndex: 9507
{
	// Fields
	private int m_ApiVersion; // 0x0
	private long m_Value; // 0x8

	// Properties
	public long Value { set; }

	// Methods

	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_Value(long value) { }

	// RVA: 0x40DD30 Offset: 0x40CF30 VA: 0x18040DD30 Slot: 4
	public void Set(ref InventoryItemSetValueAsInt64Options other) { }

	// RVA: 0x4F9A30 Offset: 0x4F8C30 VA: 0x1804F9A30 Slot: 5
	public void Set(ref Nullable<InventoryItemSetValueAsInt64Options> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Inventory
public struct InventoryItemSetValueAsInt64SetOptions // TypeDefIndex: 9508
{
	// Fields
	[CompilerGenerated]
	private long[] <Value>k__BackingField; // 0x0

	// Properties
	public long[] Value { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public long[] get_Value() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_Value(long[] value) { }
}

// Namespace: Epic.OnlineServices.Inventory
internal struct InventoryItemSetValueAsInt64SetOptionsInternal : ISettable<InventoryItemSetValueAsInt64SetOptions>, IDisposable // TypeDefIndex: 9509
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_Value; // 0x8
	private uint m_ValueCount; // 0x10

	// Properties
	public long[] Value { set; }

	// Methods

	// RVA: 0x4F9BE0 Offset: 0x4F8DE0 VA: 0x1804F9BE0
	public void set_Value(long[] value) { }

	// RVA: 0x4F9B60 Offset: 0x4F8D60 VA: 0x1804F9B60 Slot: 4
	public void Set(ref InventoryItemSetValueAsInt64SetOptions other) { }

	// RVA: 0x4F9AF0 Offset: 0x4F8CF0 VA: 0x1804F9AF0 Slot: 5
	public void Set(ref Nullable<InventoryItemSetValueAsInt64SetOptions> other) { }

	// RVA: 0x4F9AA0 Offset: 0x4F8CA0 VA: 0x1804F9AA0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Inventory
public struct InventoryItemSetValueAsStringOptions // TypeDefIndex: 9510
{
	// Fields
	[CompilerGenerated]
	private Utf8String <Value>k__BackingField; // 0x0

	// Properties
	public Utf8String Value { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Utf8String get_Value() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_Value(Utf8String value) { }
}

// Namespace: Epic.OnlineServices.Inventory
internal struct InventoryItemSetValueAsStringOptionsInternal : ISettable<InventoryItemSetValueAsStringOptions>, IDisposable // TypeDefIndex: 9511
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_Value; // 0x8

	// Properties
	public Utf8String Value { set; }

	// Methods

	// RVA: 0x4F9DA0 Offset: 0x4F8FA0 VA: 0x1804F9DA0
	public void set_Value(Utf8String value) { }

	// RVA: 0x4F9D40 Offset: 0x4F8F40 VA: 0x1804F9D40 Slot: 4
	public void Set(ref InventoryItemSetValueAsStringOptions other) { }

	// RVA: 0x4F9CA0 Offset: 0x4F8EA0 VA: 0x1804F9CA0 Slot: 5
	public void Set(ref Nullable<InventoryItemSetValueAsStringOptions> other) { }

	// RVA: 0x4F9C50 Offset: 0x4F8E50 VA: 0x1804F9C50 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Inventory
public struct InventoryItemSetValueAsStringSetOptions // TypeDefIndex: 9512
{
	// Fields
	[CompilerGenerated]
	private Utf8String[] <Value>k__BackingField; // 0x0

	// Properties
	public Utf8String[] Value { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Utf8String[] get_Value() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_Value(Utf8String[] value) { }
}

// Namespace: Epic.OnlineServices.Inventory
internal struct InventoryItemSetValueAsStringSetOptionsInternal : ISettable<InventoryItemSetValueAsStringSetOptions>, IDisposable // TypeDefIndex: 9513
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_Value; // 0x8
	private uint m_ValueCount; // 0x10

	// Properties
	public Utf8String[] Value { set; }

	// Methods

	// RVA: 0x4F9EE0 Offset: 0x4F90E0 VA: 0x1804F9EE0
	public void set_Value(Utf8String[] value) { }

	// RVA: 0x4F9E50 Offset: 0x4F9050 VA: 0x1804F9E50 Slot: 4
	public void Set(ref InventoryItemSetValueAsStringSetOptions other) { }

	// RVA: 0x4F9E70 Offset: 0x4F9070 VA: 0x1804F9E70 Slot: 5
	public void Set(ref Nullable<InventoryItemSetValueAsStringSetOptions> other) { }

	// RVA: 0x4F9E00 Offset: 0x4F9000 VA: 0x1804F9E00 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Inventory
public struct InventoryItemSetValueAsTimestampOptions // TypeDefIndex: 9514
{
	// Fields
	[CompilerGenerated]
	private long <Value>k__BackingField; // 0x0

	// Properties
	public long Value { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public long get_Value() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_Value(long value) { }
}

// Namespace: Epic.OnlineServices.Inventory
internal struct InventoryItemSetValueAsTimestampOptionsInternal : ISettable<InventoryItemSetValueAsTimestampOptions>, IDisposable // TypeDefIndex: 9515
{
	// Fields
	private int m_ApiVersion; // 0x0
	private long m_Value; // 0x8

	// Properties
	public long Value { set; }

	// Methods

	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_Value(long value) { }

	// RVA: 0x40DD30 Offset: 0x40CF30 VA: 0x18040DD30 Slot: 4
	public void Set(ref InventoryItemSetValueAsTimestampOptions other) { }

	// RVA: 0x4F9F60 Offset: 0x4F9160 VA: 0x1804F9F60 Slot: 5
	public void Set(ref Nullable<InventoryItemSetValueAsTimestampOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Inventory
public sealed class OnCheckpointCompleteCallback : MulticastDelegate // TypeDefIndex: 9516
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref OnCheckpointCompleteCallbackInfo data) { }

	// RVA: 0x4FAD80 Offset: 0x4F9F80 VA: 0x1804FAD80 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref OnCheckpointCompleteCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref OnCheckpointCompleteCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Inventory
[UnmanagedFunctionPointer(2)]
internal sealed class OnCheckpointCompleteCallbackInternal : MulticastDelegate // TypeDefIndex: 9517
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref OnCheckpointCompleteCallbackInfoInternal data) { }

	// RVA: 0x4FACF0 Offset: 0x4F9EF0 VA: 0x1804FACF0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref OnCheckpointCompleteCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref OnCheckpointCompleteCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Inventory
public struct OnCheckpointCompleteCallbackInfo : ICallbackInfo // TypeDefIndex: 9518
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

	// RVA: 0x4FAC20 Offset: 0x4F9E20 VA: 0x1804FAC20 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x4FAC70 Offset: 0x4F9E70 VA: 0x1804FAC70
	internal void Set(ref OnCheckpointCompleteCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.Inventory
internal struct OnCheckpointCompleteCallbackInfoInternal : ICallbackInfoInternal, IGettable<OnCheckpointCompleteCallbackInfo>, ISettable<OnCheckpointCompleteCallbackInfo>, IDisposable // TypeDefIndex: 9519
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

	// RVA: 0x4FAB50 Offset: 0x4F9D50 VA: 0x1804FAB50
	public object get_ClientData() { }

	// RVA: 0x4FABC0 Offset: 0x4F9DC0 VA: 0x1804FABC0
	public void set_ClientData(object value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x4FAAF0 Offset: 0x4F9CF0 VA: 0x1804FAAF0 Slot: 6
	public void Set(ref OnCheckpointCompleteCallbackInfo other) { }

	// RVA: 0x4FAA30 Offset: 0x4F9C30 VA: 0x1804FAA30 Slot: 7
	public void Set(ref Nullable<OnCheckpointCompleteCallbackInfo> other) { }

	// RVA: 0x4FA9C0 Offset: 0x4F9BC0 VA: 0x1804FA9C0 Slot: 8
	public void Dispose() { }

	// RVA: 0x4FAA10 Offset: 0x4F9C10 VA: 0x1804FAA10 Slot: 5
	public void Get(out OnCheckpointCompleteCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.Inventory
public sealed class OnCloseCompleteCallback : MulticastDelegate // TypeDefIndex: 9520
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref OnCloseCompleteCallbackInfo data) { }

	// RVA: 0x4FB1D0 Offset: 0x4FA3D0 VA: 0x1804FB1D0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref OnCloseCompleteCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref OnCloseCompleteCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Inventory
[UnmanagedFunctionPointer(2)]
internal sealed class OnCloseCompleteCallbackInternal : MulticastDelegate // TypeDefIndex: 9521
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref OnCloseCompleteCallbackInfoInternal data) { }

	// RVA: 0x4FB140 Offset: 0x4FA340 VA: 0x1804FB140 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref OnCloseCompleteCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref OnCloseCompleteCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Inventory
public struct OnCloseCompleteCallbackInfo : ICallbackInfo // TypeDefIndex: 9522
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

	// RVA: 0x4FB070 Offset: 0x4FA270 VA: 0x1804FB070 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x4FB0C0 Offset: 0x4FA2C0 VA: 0x1804FB0C0
	internal void Set(ref OnCloseCompleteCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.Inventory
internal struct OnCloseCompleteCallbackInfoInternal : ICallbackInfoInternal, IGettable<OnCloseCompleteCallbackInfo>, ISettable<OnCloseCompleteCallbackInfo>, IDisposable // TypeDefIndex: 9523
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

	// RVA: 0x4FAFA0 Offset: 0x4FA1A0 VA: 0x1804FAFA0
	public object get_ClientData() { }

	// RVA: 0x4FB010 Offset: 0x4FA210 VA: 0x1804FB010
	public void set_ClientData(object value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x4FAF40 Offset: 0x4FA140 VA: 0x1804FAF40 Slot: 6
	public void Set(ref OnCloseCompleteCallbackInfo other) { }

	// RVA: 0x4FAE80 Offset: 0x4FA080 VA: 0x1804FAE80 Slot: 7
	public void Set(ref Nullable<OnCloseCompleteCallbackInfo> other) { }

	// RVA: 0x4FAE10 Offset: 0x4FA010 VA: 0x1804FAE10 Slot: 8
	public void Dispose() { }

	// RVA: 0x4FAE60 Offset: 0x4FA060 VA: 0x1804FAE60 Slot: 5
	public void Get(out OnCloseCompleteCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.Inventory
public sealed class OnCreateCompleteCallback : MulticastDelegate // TypeDefIndex: 9524
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref OnCreateCompleteCallbackInfo data) { }

	// RVA: 0x4FB7D0 Offset: 0x4FA9D0 VA: 0x1804FB7D0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref OnCreateCompleteCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref OnCreateCompleteCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Inventory
[UnmanagedFunctionPointer(2)]
internal sealed class OnCreateCompleteCallbackInternal : MulticastDelegate // TypeDefIndex: 9525
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref OnCreateCompleteCallbackInfoInternal data) { }

	// RVA: 0x4FB740 Offset: 0x4FA940 VA: 0x1804FB740 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref OnCreateCompleteCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref OnCreateCompleteCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Inventory
public struct OnCreateCompleteCallbackInfo : ICallbackInfo // TypeDefIndex: 9526
{
	// Fields
	[CompilerGenerated]
	private Result <ResultCode>k__BackingField; // 0x0
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x8
	[CompilerGenerated]
	private InventoryItem <InventoryItemHandle>k__BackingField; // 0x10

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public InventoryItem InventoryItemHandle { get; set; }

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
	public InventoryItem get_InventoryItemHandle() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_InventoryItemHandle(InventoryItem value) { }

	// RVA: 0x4FB660 Offset: 0x4FA860 VA: 0x1804FB660 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x4FB6B0 Offset: 0x4FA8B0 VA: 0x1804FB6B0
	internal void Set(ref OnCreateCompleteCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.Inventory
internal struct OnCreateCompleteCallbackInfoInternal : ICallbackInfoInternal, IGettable<OnCreateCompleteCallbackInfo>, ISettable<OnCreateCompleteCallbackInfo>, IDisposable // TypeDefIndex: 9527
{
	// Fields
	private Result m_ResultCode; // 0x0
	private IntPtr m_ClientData; // 0x8
	private IntPtr m_InventoryItemHandle; // 0x10

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public InventoryItem InventoryItemHandle { get; set; }

	// Methods

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	// RVA: 0x4FB4B0 Offset: 0x4FA6B0 VA: 0x1804FB4B0
	public object get_ClientData() { }

	// RVA: 0x4FB5A0 Offset: 0x4FA7A0 VA: 0x1804FB5A0
	public void set_ClientData(object value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x4FB520 Offset: 0x4FA720 VA: 0x1804FB520
	public InventoryItem get_InventoryItemHandle() { }

	// RVA: 0x4FB600 Offset: 0x4FA800 VA: 0x1804FB600
	public void set_InventoryItemHandle(InventoryItem value) { }

	// RVA: 0x4FB2E0 Offset: 0x4FA4E0 VA: 0x1804FB2E0 Slot: 6
	public void Set(ref OnCreateCompleteCallbackInfo other) { }

	// RVA: 0x4FB390 Offset: 0x4FA590 VA: 0x1804FB390 Slot: 7
	public void Set(ref Nullable<OnCreateCompleteCallbackInfo> other) { }

	// RVA: 0x4FB260 Offset: 0x4FA460 VA: 0x1804FB260 Slot: 8
	public void Dispose() { }

	// RVA: 0x4FB2C0 Offset: 0x4FA4C0 VA: 0x1804FB2C0 Slot: 5
	public void Get(out OnCreateCompleteCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.Inventory
public sealed class OnOpenCompleteCallback : MulticastDelegate // TypeDefIndex: 9528
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref OnOpenCompleteCallbackInfo data) { }

	// RVA: 0x4FC540 Offset: 0x4FB740 VA: 0x1804FC540 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref OnOpenCompleteCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref OnOpenCompleteCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Inventory
[UnmanagedFunctionPointer(2)]
internal sealed class OnOpenCompleteCallbackInternal : MulticastDelegate // TypeDefIndex: 9529
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref OnOpenCompleteCallbackInfoInternal data) { }

	// RVA: 0x4FC4B0 Offset: 0x4FB6B0 VA: 0x1804FC4B0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref OnOpenCompleteCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref OnOpenCompleteCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Inventory
public struct OnOpenCompleteCallbackInfo : ICallbackInfo // TypeDefIndex: 9530
{
	// Fields
	[CompilerGenerated]
	private Result <ResultCode>k__BackingField; // 0x0
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x8
	[CompilerGenerated]
	private InventoryItem <InventoryItemHandle>k__BackingField; // 0x10

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public InventoryItem InventoryItemHandle { get; set; }

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
	public InventoryItem get_InventoryItemHandle() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_InventoryItemHandle(InventoryItem value) { }

	// RVA: 0x4FC3D0 Offset: 0x4FB5D0 VA: 0x1804FC3D0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x4FC420 Offset: 0x4FB620 VA: 0x1804FC420
	internal void Set(ref OnOpenCompleteCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.Inventory
internal struct OnOpenCompleteCallbackInfoInternal : ICallbackInfoInternal, IGettable<OnOpenCompleteCallbackInfo>, ISettable<OnOpenCompleteCallbackInfo>, IDisposable // TypeDefIndex: 9531
{
	// Fields
	private Result m_ResultCode; // 0x0
	private IntPtr m_ClientData; // 0x8
	private IntPtr m_InventoryItemHandle; // 0x10

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public InventoryItem InventoryItemHandle { get; set; }

	// Methods

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	// RVA: 0x4FC220 Offset: 0x4FB420 VA: 0x1804FC220
	public object get_ClientData() { }

	// RVA: 0x4FC310 Offset: 0x4FB510 VA: 0x1804FC310
	public void set_ClientData(object value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x4FC290 Offset: 0x4FB490 VA: 0x1804FC290
	public InventoryItem get_InventoryItemHandle() { }

	// RVA: 0x4FC370 Offset: 0x4FB570 VA: 0x1804FC370
	public void set_InventoryItemHandle(InventoryItem value) { }

	// RVA: 0x4FC170 Offset: 0x4FB370 VA: 0x1804FC170 Slot: 6
	public void Set(ref OnOpenCompleteCallbackInfo other) { }

	// RVA: 0x4FC050 Offset: 0x4FB250 VA: 0x1804FC050 Slot: 7
	public void Set(ref Nullable<OnOpenCompleteCallbackInfo> other) { }

	// RVA: 0x4FBFD0 Offset: 0x4FB1D0 VA: 0x1804FBFD0 Slot: 8
	public void Dispose() { }

	// RVA: 0x4FC030 Offset: 0x4FB230 VA: 0x1804FC030 Slot: 5
	public void Get(out OnOpenCompleteCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.Inventory
public struct OpenOptions // TypeDefIndex: 9532
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private ProductUserId <TargetUserId>k__BackingField; // 0x8
	[CompilerGenerated]
	private Utf8String <InventoryName>k__BackingField; // 0x10

	// Properties
	public ProductUserId LocalUserId { get; set; }
	public ProductUserId TargetUserId { get; set; }
	public Utf8String InventoryName { get; set; }

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
	public ProductUserId get_TargetUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_TargetUserId(ProductUserId value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Utf8String get_InventoryName() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_InventoryName(Utf8String value) { }
}

// Namespace: Epic.OnlineServices.Inventory
internal struct OpenOptionsInternal : ISettable<OpenOptions>, IDisposable // TypeDefIndex: 9533
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_TargetUserId; // 0x10
	private IntPtr m_InventoryName; // 0x18

	// Properties
	public ProductUserId LocalUserId { set; }
	public ProductUserId TargetUserId { set; }
	public Utf8String InventoryName { set; }

	// Methods

	// RVA: 0x4FCE90 Offset: 0x4FC090 VA: 0x1804FCE90
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x4FCEF0 Offset: 0x4FC0F0 VA: 0x1804FCEF0
	public void set_TargetUserId(ProductUserId value) { }

	// RVA: 0x4FCE30 Offset: 0x4FC030 VA: 0x1804FCE30
	public void set_InventoryName(Utf8String value) { }

	// RVA: 0x4FCBD0 Offset: 0x4FBDD0 VA: 0x1804FCBD0 Slot: 4
	public void Set(ref OpenOptions other) { }

	// RVA: 0x4FCCD0 Offset: 0x4FBED0 VA: 0x1804FCCD0 Slot: 5
	public void Set(ref Nullable<OpenOptions> other) { }

	// RVA: 0x4FCB70 Offset: 0x4FBD70 VA: 0x1804FCB70 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Inventory
public enum ValueType // TypeDefIndex: 9534
{
	// Fields
	public int value__; // 0x0
	public const ValueType Undefined = 0;
	public const ValueType String = 1;
	public const ValueType Boolean = 2;
	public const ValueType Timestamp = 3;
	public const ValueType Integer = 4;
	public const ValueType Double = 5;
	public const ValueType Integerset = 6;
	public const ValueType Doubleset = 7;
	public const ValueType Stringset = 8;
}

// Namespace: Epic.OnlineServices.IntegratedPlatform
public struct AddNotifyUserLoginStatusChangedOptions // TypeDefIndex: 9535
{}

// Namespace: Epic.OnlineServices.IntegratedPlatform
internal struct AddNotifyUserLoginStatusChangedOptionsInternal : ISettable<AddNotifyUserLoginStatusChangedOptions>, IDisposable // TypeDefIndex: 9536
{
	// Fields
	private int m_ApiVersion; // 0x0

	// Methods

	// RVA: 0x3F98A0 Offset: 0x3F8AA0 VA: 0x1803F98A0 Slot: 4
	public void Set(ref AddNotifyUserLoginStatusChangedOptions other) { }

	// RVA: 0x4EC060 Offset: 0x4EB260 VA: 0x1804EC060 Slot: 5
	public void Set(ref Nullable<AddNotifyUserLoginStatusChangedOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.IntegratedPlatform
public struct ClearUserPreLogoutCallbackOptions // TypeDefIndex: 9537
{}

// Namespace: Epic.OnlineServices.IntegratedPlatform
internal struct ClearUserPreLogoutCallbackOptionsInternal : ISettable<ClearUserPreLogoutCallbackOptions>, IDisposable // TypeDefIndex: 9538
{
	// Fields
	private int m_ApiVersion; // 0x0

	// Methods

	// RVA: 0x3F98A0 Offset: 0x3F8AA0 VA: 0x1803F98A0 Slot: 4
	public void Set(ref ClearUserPreLogoutCallbackOptions other) { }

	// RVA: 0x4EF570 Offset: 0x4EE770 VA: 0x1804EF570 Slot: 5
	public void Set(ref Nullable<ClearUserPreLogoutCallbackOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.IntegratedPlatform
public struct CreateIntegratedPlatformOptionsContainerOptions // TypeDefIndex: 9539
{}

// Namespace: Epic.OnlineServices.IntegratedPlatform
internal struct CreateIntegratedPlatformOptionsContainerOptionsInternal : ISettable<CreateIntegratedPlatformOptionsContainerOptions>, IDisposable // TypeDefIndex: 9540
{
	// Fields
	private int m_ApiVersion; // 0x0

	// Methods

	// RVA: 0x3F98A0 Offset: 0x3F8AA0 VA: 0x1803F98A0 Slot: 4
	public void Set(ref CreateIntegratedPlatformOptionsContainerOptions other) { }

	// RVA: 0x4F1800 Offset: 0x4F0A00 VA: 0x1804F1800 Slot: 5
	public void Set(ref Nullable<CreateIntegratedPlatformOptionsContainerOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.IntegratedPlatform
public struct FinalizeDeferredUserLogoutOptions // TypeDefIndex: 9541
{
	// Fields
	[CompilerGenerated]
	private Utf8String <PlatformType>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <LocalPlatformUserId>k__BackingField; // 0x8
	[CompilerGenerated]
	private LoginStatus <ExpectedLoginStatus>k__BackingField; // 0x10

	// Properties
	public Utf8String PlatformType { get; set; }
	public Utf8String LocalPlatformUserId { get; set; }
	public LoginStatus ExpectedLoginStatus { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Utf8String get_PlatformType() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_PlatformType(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public Utf8String get_LocalPlatformUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_LocalPlatformUserId(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public LoginStatus get_ExpectedLoginStatus() { }

	[CompilerGenerated]
	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_ExpectedLoginStatus(LoginStatus value) { }
}

// Namespace: Epic.OnlineServices.IntegratedPlatform
internal struct FinalizeDeferredUserLogoutOptionsInternal : ISettable<FinalizeDeferredUserLogoutOptions>, IDisposable // TypeDefIndex: 9542
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_PlatformType; // 0x8
	private IntPtr m_LocalPlatformUserId; // 0x10
	private LoginStatus m_ExpectedLoginStatus; // 0x18

	// Properties
	public Utf8String PlatformType { set; }
	public Utf8String LocalPlatformUserId { set; }
	public LoginStatus ExpectedLoginStatus { set; }

	// Methods

	// RVA: 0x4F47C0 Offset: 0x4F39C0 VA: 0x1804F47C0
	public void set_PlatformType(Utf8String value) { }

	// RVA: 0x4F4760 Offset: 0x4F3960 VA: 0x1804F4760
	public void set_LocalPlatformUserId(Utf8String value) { }

	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	public void set_ExpectedLoginStatus(LoginStatus value) { }

	// RVA: 0x4F46A0 Offset: 0x4F38A0 VA: 0x1804F46A0 Slot: 4
	public void Set(ref FinalizeDeferredUserLogoutOptions other) { }

	// RVA: 0x4F4580 Offset: 0x4F3780 VA: 0x1804F4580 Slot: 5
	public void Set(ref Nullable<FinalizeDeferredUserLogoutOptions> other) { }

	// RVA: 0x4F4520 Offset: 0x4F3720 VA: 0x1804F4520 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.IntegratedPlatform
public sealed class IntegratedPlatformInterface : Handle // TypeDefIndex: 9543
{
	// Fields
	public const int AddnotifyuserloginstatuschangedApiLatest = 1;
	public const int ClearuserprelogoutcallbackApiLatest = 1;
	public const int CreateintegratedplatformoptionscontainerApiLatest = 1;
	public const int FinalizedeferreduserlogoutApiLatest = 1;
	public const int OptionsApiLatest = 1;
	public const int SetuserloginstatusApiLatest = 1;
	public const int SetuserprelogoutcallbackApiLatest = 1;
	public const int SteamMaxSteamapiinterfaceversionsarraySize = 4096;
	public const int SteamOptionsApiLatest = 3;
	public const int Ps4OptionsinitoptionsApiLatest = 1;
	public const int Ps5OptionsinitoptionsApiLatest = 1;
	public const int SwitchOptionsinitoptionsApiLatest = 1;
	public const int XboxonegdkXbloptionsinitoptionsApiLatest = 2;
	public const int XsxXbloptionsinitoptionsApiLatest = 2;

	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }

	// RVA: 0x40BDB0 Offset: 0x40AFB0 VA: 0x18040BDB0
	public void .ctor(IntPtr innerHandle) { }

	// RVA: 0x4F7B60 Offset: 0x4F6D60 VA: 0x1804F7B60
	public ulong AddNotifyUserLoginStatusChanged(ref AddNotifyUserLoginStatusChangedOptions options, object clientData, OnUserLoginStatusChangedCallback callbackFunction) { }

	// RVA: 0x4F7D10 Offset: 0x4F6F10 VA: 0x1804F7D10
	public void ClearUserPreLogoutCallback(ref ClearUserPreLogoutCallbackOptions options) { }

	// RVA: 0x4F7D90 Offset: 0x4F6F90 VA: 0x1804F7D90
	public static Result CreateIntegratedPlatformOptionsContainer(ref CreateIntegratedPlatformOptionsContainerOptions options, out IntegratedPlatformOptionsContainer outIntegratedPlatformOptionsContainerHandle) { }

	// RVA: 0x4F7E50 Offset: 0x4F7050 VA: 0x1804F7E50
	public Result FinalizeDeferredUserLogout(ref FinalizeDeferredUserLogoutOptions options) { }

	// RVA: 0x4F8160 Offset: 0x4F7360 VA: 0x1804F8160
	public void RemoveNotifyUserLoginStatusChanged(ulong notificationId) { }

	// RVA: 0x4F81D0 Offset: 0x4F73D0 VA: 0x1804F81D0
	public Result SetUserLoginStatus(ref SetUserLoginStatusOptions options) { }

	// RVA: 0x4F8270 Offset: 0x4F7470 VA: 0x1804F8270
	public Result SetUserPreLogoutCallback(ref SetUserPreLogoutCallbackOptions options, object clientData, OnUserPreLogoutCallback callbackFunction) { }

	[MonoPInvokeCallback(typeof(OnUserLoginStatusChangedCallbackInternal))]
	// RVA: 0x4F7EF0 Offset: 0x4F70F0 VA: 0x1804F7EF0
	internal static void OnUserLoginStatusChangedCallbackInternalImplementation(ref UserLoginStatusChangedCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnUserPreLogoutCallbackInternal))]
	// RVA: 0x4F7FA0 Offset: 0x4F71A0 VA: 0x1804F7FA0
	internal static IntegratedPlatformPreLogoutAction OnUserPreLogoutCallbackInternalImplementation(ref UserPreLogoutCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(PS4ManagedBySdkNotificationMessagesCallbackInternal))]
	// RVA: 0x4F8080 Offset: 0x4F7280 VA: 0x1804F8080
	internal static void PS4ManagedBySdkNotificationMessagesCallbackInternalImplementation(IntPtr clientData, IntPtr inEvent) { }
}

// Namespace: Epic.OnlineServices.IntegratedPlatform
[Flags]
public enum IntegratedPlatformManagementFlags // TypeDefIndex: 9544
{
	// Fields
	public int value__; // 0x0
	public const IntegratedPlatformManagementFlags Disabled = 1;
	public const IntegratedPlatformManagementFlags LibraryManagedByApplication = 2;
	public const IntegratedPlatformManagementFlags LibraryManagedBySDK = 4;
	public const IntegratedPlatformManagementFlags DisablePresenceMirroring = 8;
	public const IntegratedPlatformManagementFlags DisableSDKManagedSessions = 16;
	public const IntegratedPlatformManagementFlags PreferEOSIdentity = 32;
	public const IntegratedPlatformManagementFlags PreferIntegratedIdentity = 64;
	public const IntegratedPlatformManagementFlags ApplicationManagedIdentityLogin = 128;
}

// Namespace: Epic.OnlineServices.IntegratedPlatform
public sealed class IntegratedPlatformOptionsContainer : Handle // TypeDefIndex: 9545
{
	// Fields
	public const int IntegratedplatformoptionscontainerAddApiLatest = 1;

	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }

	// RVA: 0x40BDB0 Offset: 0x40AFB0 VA: 0x18040BDB0
	public void .ctor(IntPtr innerHandle) { }

	// RVA: 0x4F8850 Offset: 0x4F7A50 VA: 0x1804F8850
	public Result Add(ref IntegratedPlatformOptionsContainerAddOptions inOptions) { }

	// RVA: 0x4F8B60 Offset: 0x4F7D60 VA: 0x1804F8B60
	public void Release() { }

	// RVA: 0x4F8950 Offset: 0x4F7B50 VA: 0x1804F8950
	public Result Add(ref PS4IntegratedPlatformOptionsContainerAddOptions inOptions) { }

	// RVA: 0x4F8A60 Offset: 0x4F7C60 VA: 0x1804F8A60
	public Result Add(ref PS5IntegratedPlatformOptionsContainerAddOptions inOptions) { }

	// RVA: 0x4F8750 Offset: 0x4F7950 VA: 0x1804F8750
	public Result Add(ref XboxOneGDKIntegratedPlatformOptionsContainerAddOptions inOptions) { }

	// RVA: 0x4F8650 Offset: 0x4F7850 VA: 0x1804F8650
	public Result Add(ref XSXIntegratedPlatformOptionsContainerAddOptions inOptions) { }
}

// Namespace: Epic.OnlineServices.IntegratedPlatform
public struct IntegratedPlatformOptionsContainerAddOptions // TypeDefIndex: 9546
{
	// Fields
	[CompilerGenerated]
	private Nullable<Options> <Options>k__BackingField; // 0x0

	// Properties
	public Nullable<Options> Options { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x4F8620 Offset: 0x4F7820 VA: 0x1804F8620
	public Nullable<Options> get_Options() { }

	[CompilerGenerated]
	// RVA: 0x4F8640 Offset: 0x4F7840 VA: 0x1804F8640
	public void set_Options(Nullable<Options> value) { }
}

// Namespace: Epic.OnlineServices.IntegratedPlatform
internal struct IntegratedPlatformOptionsContainerAddOptionsInternal : ISettable<IntegratedPlatformOptionsContainerAddOptions>, IDisposable // TypeDefIndex: 9547
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_Options; // 0x8

	// Properties
	public Nullable<Options> Options { set; }

	// Methods

	// RVA: 0x4F85B0 Offset: 0x4F77B0 VA: 0x1804F85B0
	public void set_Options(Nullable<Options> value) { }

	// RVA: 0x4F8530 Offset: 0x4F7730 VA: 0x1804F8530 Slot: 4
	public void Set(ref IntegratedPlatformOptionsContainerAddOptions other) { }

	// RVA: 0x4F8460 Offset: 0x4F7660 VA: 0x1804F8460 Slot: 5
	public void Set(ref Nullable<IntegratedPlatformOptionsContainerAddOptions> other) { }

	// RVA: 0x4F8410 Offset: 0x4F7610 VA: 0x1804F8410 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.IntegratedPlatform
public enum IntegratedPlatformPreLogoutAction // TypeDefIndex: 9548
{
	// Fields
	public int value__; // 0x0
	public const IntegratedPlatformPreLogoutAction ProcessLogoutImmediately = 0;
	public const IntegratedPlatformPreLogoutAction DeferLogout = 1;
}

// Namespace: Epic.OnlineServices.IntegratedPlatform
public sealed class OnUserLoginStatusChangedCallback : MulticastDelegate // TypeDefIndex: 9549
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref UserLoginStatusChangedCallbackInfo data) { }

	// RVA: 0x4FC9C0 Offset: 0x4FBBC0 VA: 0x1804FC9C0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref UserLoginStatusChangedCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref UserLoginStatusChangedCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.IntegratedPlatform
[UnmanagedFunctionPointer(2)]
internal sealed class OnUserLoginStatusChangedCallbackInternal : MulticastDelegate // TypeDefIndex: 9550
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref UserLoginStatusChangedCallbackInfoInternal data) { }

	// RVA: 0x4FC930 Offset: 0x4FBB30 VA: 0x1804FC930 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref UserLoginStatusChangedCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref UserLoginStatusChangedCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.IntegratedPlatform
public sealed class OnUserPreLogoutCallback : MulticastDelegate // TypeDefIndex: 9551
{
	// Methods

	// RVA: 0x3FEA60 Offset: 0x3FDC60 VA: 0x1803FEA60
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual IntegratedPlatformPreLogoutAction Invoke(ref UserPreLogoutCallbackInfo data) { }

	// RVA: 0x4FCAE0 Offset: 0x4FBCE0 VA: 0x1804FCAE0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref UserPreLogoutCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FEA30 Offset: 0x3FDC30 VA: 0x1803FEA30 Slot: 15
	public virtual IntegratedPlatformPreLogoutAction EndInvoke(ref UserPreLogoutCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.IntegratedPlatform
[UnmanagedFunctionPointer(2)]
internal sealed class OnUserPreLogoutCallbackInternal : MulticastDelegate // TypeDefIndex: 9552
{
	// Methods

	// RVA: 0x3FEA60 Offset: 0x3FDC60 VA: 0x1803FEA60
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual IntegratedPlatformPreLogoutAction Invoke(ref UserPreLogoutCallbackInfoInternal data) { }

	// RVA: 0x4FCA50 Offset: 0x4FBC50 VA: 0x1804FCA50 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref UserPreLogoutCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FEA30 Offset: 0x3FDC30 VA: 0x1803FEA30 Slot: 15
	public virtual IntegratedPlatformPreLogoutAction EndInvoke(ref UserPreLogoutCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.IntegratedPlatform
public struct Options // TypeDefIndex: 9553
{
	// Fields
	[CompilerGenerated]
	private Utf8String <Type>k__BackingField; // 0x0
	[CompilerGenerated]
	private IntegratedPlatformManagementFlags <Flags>k__BackingField; // 0x8
	[CompilerGenerated]
	private IntPtr <InitOptions>k__BackingField; // 0x10

	// Properties
	public Utf8String Type { get; set; }
	public IntegratedPlatformManagementFlags Flags { get; set; }
	public IntPtr InitOptions { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Utf8String get_Type() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_Type(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3F5510 Offset: 0x3F4710 VA: 0x1803F5510
	public IntegratedPlatformManagementFlags get_Flags() { }

	[CompilerGenerated]
	// RVA: 0x3F5520 Offset: 0x3F4720 VA: 0x1803F5520
	public void set_Flags(IntegratedPlatformManagementFlags value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public IntPtr get_InitOptions() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_InitOptions(IntPtr value) { }

	// RVA: 0x4FD200 Offset: 0x4FC400 VA: 0x1804FD200
	internal void Set(ref OptionsInternal other) { }
}

// Namespace: Epic.OnlineServices.IntegratedPlatform
internal struct OptionsInternal : IGettable<Options>, ISettable<Options>, IDisposable // TypeDefIndex: 9554
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_Type; // 0x8
	private IntegratedPlatformManagementFlags m_Flags; // 0x10
	private IntPtr m_InitOptions; // 0x18

	// Properties
	public Utf8String Type { get; set; }
	public IntegratedPlatformManagementFlags Flags { get; set; }
	public IntPtr InitOptions { get; set; }

	// Methods

	// RVA: 0x4FD130 Offset: 0x4FC330 VA: 0x1804FD130
	public Utf8String get_Type() { }

	// RVA: 0x4FD1A0 Offset: 0x4FC3A0 VA: 0x1804FD1A0
	public void set_Type(Utf8String value) { }

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public IntegratedPlatformManagementFlags get_Flags() { }

	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_Flags(IntegratedPlatformManagementFlags value) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public IntPtr get_InitOptions() { }

	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_InitOptions(IntPtr value) { }

	// RVA: 0x4FCFD0 Offset: 0x4FC1D0 VA: 0x1804FCFD0 Slot: 5
	public void Set(ref Options other) { }

	// RVA: 0x4FD050 Offset: 0x4FC250 VA: 0x1804FD050 Slot: 6
	public void Set(ref Nullable<Options> other) { }

	// RVA: 0x4FCF50 Offset: 0x4FC150 VA: 0x1804FCF50 Slot: 7
	public void Dispose() { }

	// RVA: 0x4FCFB0 Offset: 0x4FC1B0 VA: 0x1804FCFB0 Slot: 4
	public void Get(out Options output) { }
}

// Namespace: Epic.OnlineServices.IntegratedPlatform
public struct SetUserLoginStatusOptions // TypeDefIndex: 9555
{
	// Fields
	[CompilerGenerated]
	private Utf8String <PlatformType>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <LocalPlatformUserId>k__BackingField; // 0x8
	[CompilerGenerated]
	private LoginStatus <CurrentLoginStatus>k__BackingField; // 0x10

	// Properties
	public Utf8String PlatformType { get; set; }
	public Utf8String LocalPlatformUserId { get; set; }
	public LoginStatus CurrentLoginStatus { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Utf8String get_PlatformType() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_PlatformType(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public Utf8String get_LocalPlatformUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_LocalPlatformUserId(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public LoginStatus get_CurrentLoginStatus() { }

	[CompilerGenerated]
	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_CurrentLoginStatus(LoginStatus value) { }
}

// Namespace: Epic.OnlineServices.IntegratedPlatform
internal struct SetUserLoginStatusOptionsInternal : ISettable<SetUserLoginStatusOptions>, IDisposable // TypeDefIndex: 9556
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_PlatformType; // 0x8
	private IntPtr m_LocalPlatformUserId; // 0x10
	private LoginStatus m_CurrentLoginStatus; // 0x18

	// Properties
	public Utf8String PlatformType { set; }
	public Utf8String LocalPlatformUserId { set; }
	public LoginStatus CurrentLoginStatus { set; }

	// Methods

	// RVA: 0x500780 Offset: 0x4FF980 VA: 0x180500780
	public void set_PlatformType(Utf8String value) { }

	// RVA: 0x500720 Offset: 0x4FF920 VA: 0x180500720
	public void set_LocalPlatformUserId(Utf8String value) { }

	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	public void set_CurrentLoginStatus(LoginStatus value) { }

	// RVA: 0x500540 Offset: 0x4FF740 VA: 0x180500540 Slot: 4
	public void Set(ref SetUserLoginStatusOptions other) { }

	// RVA: 0x500600 Offset: 0x4FF800 VA: 0x180500600 Slot: 5
	public void Set(ref Nullable<SetUserLoginStatusOptions> other) { }

	// RVA: 0x5004E0 Offset: 0x4FF6E0 VA: 0x1805004E0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.IntegratedPlatform
public struct SetUserPreLogoutCallbackOptions // TypeDefIndex: 9557
{}

// Namespace: Epic.OnlineServices.IntegratedPlatform
internal struct SetUserPreLogoutCallbackOptionsInternal : ISettable<SetUserPreLogoutCallbackOptions>, IDisposable // TypeDefIndex: 9558
{
	// Fields
	private int m_ApiVersion; // 0x0

	// Methods

	// RVA: 0x3F98A0 Offset: 0x3F8AA0 VA: 0x1803F98A0 Slot: 4
	public void Set(ref SetUserPreLogoutCallbackOptions other) { }

	// RVA: 0x5007E0 Offset: 0x4FF9E0 VA: 0x1805007E0 Slot: 5
	public void Set(ref Nullable<SetUserPreLogoutCallbackOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.IntegratedPlatform
public struct SteamOptions // TypeDefIndex: 9559
{
	// Fields
	[CompilerGenerated]
	private Utf8String <OverrideLibraryPath>k__BackingField; // 0x0
	[CompilerGenerated]
	private uint <SteamMajorVersion>k__BackingField; // 0x8
	[CompilerGenerated]
	private uint <SteamMinorVersion>k__BackingField; // 0xC
	[CompilerGenerated]
	private Utf8String <SteamApiInterfaceVersionsArray>k__BackingField; // 0x10
	[CompilerGenerated]
	private uint <SteamApiInterfaceVersionsArrayBytes>k__BackingField; // 0x18

	// Properties
	public Utf8String OverrideLibraryPath { get; set; }
	public uint SteamMajorVersion { get; set; }
	public uint SteamMinorVersion { get; set; }
	public Utf8String SteamApiInterfaceVersionsArray { get; set; }
	public uint SteamApiInterfaceVersionsArrayBytes { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Utf8String get_OverrideLibraryPath() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_OverrideLibraryPath(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3F5510 Offset: 0x3F4710 VA: 0x1803F5510
	public uint get_SteamMajorVersion() { }

	[CompilerGenerated]
	// RVA: 0x3F5520 Offset: 0x3F4720 VA: 0x1803F5520
	public void set_SteamMajorVersion(uint value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x438080 Offset: 0x437280 VA: 0x180438080
	public uint get_SteamMinorVersion() { }

	[CompilerGenerated]
	// RVA: 0x438090 Offset: 0x437290 VA: 0x180438090
	public void set_SteamMinorVersion(uint value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Utf8String get_SteamApiInterfaceVersionsArray() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_SteamApiInterfaceVersionsArray(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public uint get_SteamApiInterfaceVersionsArrayBytes() { }

	[CompilerGenerated]
	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	public void set_SteamApiInterfaceVersionsArrayBytes(uint value) { }

	// RVA: 0x500C80 Offset: 0x4FFE80 VA: 0x180500C80
	internal void Set(ref SteamOptionsInternal other) { }
}

// Namespace: Epic.OnlineServices.IntegratedPlatform
internal struct SteamOptionsInternal : IGettable<SteamOptions>, ISettable<SteamOptions>, IDisposable // TypeDefIndex: 9560
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_OverrideLibraryPath; // 0x8
	private uint m_SteamMajorVersion; // 0x10
	private uint m_SteamMinorVersion; // 0x14
	private IntPtr m_SteamApiInterfaceVersionsArray; // 0x18
	private uint m_SteamApiInterfaceVersionsArrayBytes; // 0x20

	// Properties
	public Utf8String OverrideLibraryPath { get; set; }
	public uint SteamMajorVersion { get; set; }
	public uint SteamMinorVersion { get; set; }
	public Utf8String SteamApiInterfaceVersionsArray { get; set; }
	public uint SteamApiInterfaceVersionsArrayBytes { get; set; }

	// Methods

	// RVA: 0x500AE0 Offset: 0x4FFCE0 VA: 0x180500AE0
	public Utf8String get_OverrideLibraryPath() { }

	// RVA: 0x500BC0 Offset: 0x4FFDC0 VA: 0x180500BC0
	public void set_OverrideLibraryPath(Utf8String value) { }

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public uint get_SteamMajorVersion() { }

	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_SteamMajorVersion(uint value) { }

	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500
	public uint get_SteamMinorVersion() { }

	// RVA: 0x426530 Offset: 0x425730 VA: 0x180426530
	public void set_SteamMinorVersion(uint value) { }

	// RVA: 0x500B50 Offset: 0x4FFD50 VA: 0x180500B50
	public Utf8String get_SteamApiInterfaceVersionsArray() { }

	// RVA: 0x500C20 Offset: 0x4FFE20 VA: 0x180500C20
	public void set_SteamApiInterfaceVersionsArray(Utf8String value) { }

	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400
	public uint get_SteamApiInterfaceVersionsArrayBytes() { }

	// RVA: 0x3DA420 Offset: 0x3D9620 VA: 0x1803DA420
	public void set_SteamApiInterfaceVersionsArrayBytes(uint value) { }

	// RVA: 0x5008B0 Offset: 0x4FFAB0 VA: 0x1805008B0 Slot: 5
	public void Set(ref SteamOptions other) { }

	// RVA: 0x500980 Offset: 0x4FFB80 VA: 0x180500980 Slot: 6
	public void Set(ref Nullable<SteamOptions> other) { }

	// RVA: 0x500830 Offset: 0x4FFA30 VA: 0x180500830 Slot: 7
	public void Dispose() { }

	// RVA: 0x500890 Offset: 0x4FFA90 VA: 0x180500890 Slot: 4
	public void Get(out SteamOptions output) { }
}

// Namespace: Epic.OnlineServices.IntegratedPlatform
public struct UserLoginStatusChangedCallbackInfo : ICallbackInfo // TypeDefIndex: 9561
{
	// Fields
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <PlatformType>k__BackingField; // 0x8
	[CompilerGenerated]
	private Utf8String <LocalPlatformUserId>k__BackingField; // 0x10
	[CompilerGenerated]
	private EpicAccountId <AccountId>k__BackingField; // 0x18
	[CompilerGenerated]
	private ProductUserId <ProductUserId>k__BackingField; // 0x20
	[CompilerGenerated]
	private LoginStatus <PreviousLoginStatus>k__BackingField; // 0x28
	[CompilerGenerated]
	private LoginStatus <CurrentLoginStatus>k__BackingField; // 0x2C

	// Properties
	public object ClientData { get; set; }
	public Utf8String PlatformType { get; set; }
	public Utf8String LocalPlatformUserId { get; set; }
	public EpicAccountId AccountId { get; set; }
	public ProductUserId ProductUserId { get; set; }
	public LoginStatus PreviousLoginStatus { get; set; }
	public LoginStatus CurrentLoginStatus { get; set; }

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
	public Utf8String get_PlatformType() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_PlatformType(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Utf8String get_LocalPlatformUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_LocalPlatformUserId(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public EpicAccountId get_AccountId() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_AccountId(EpicAccountId value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public ProductUserId get_ProductUserId() { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_ProductUserId(ProductUserId value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA050 Offset: 0x3D9250 VA: 0x1803DA050
	public LoginStatus get_PreviousLoginStatus() { }

	[CompilerGenerated]
	// RVA: 0x3DA200 Offset: 0x3D9400 VA: 0x1803DA200
	public void set_PreviousLoginStatus(LoginStatus value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x5012C0 Offset: 0x5004C0 VA: 0x1805012C0
	public LoginStatus get_CurrentLoginStatus() { }

	[CompilerGenerated]
	// RVA: 0x5014F0 Offset: 0x5006F0 VA: 0x1805014F0
	public void set_CurrentLoginStatus(LoginStatus value) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x501620 Offset: 0x500820 VA: 0x180501620
	internal void Set(ref UserLoginStatusChangedCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.IntegratedPlatform
internal struct UserLoginStatusChangedCallbackInfoInternal : ICallbackInfoInternal, IGettable<UserLoginStatusChangedCallbackInfo>, ISettable<UserLoginStatusChangedCallbackInfo>, IDisposable // TypeDefIndex: 9562
{
	// Fields
	private IntPtr m_ClientData; // 0x0
	private IntPtr m_PlatformType; // 0x8
	private IntPtr m_LocalPlatformUserId; // 0x10
	private IntPtr m_AccountId; // 0x18
	private IntPtr m_ProductUserId; // 0x20
	private LoginStatus m_PreviousLoginStatus; // 0x28
	private LoginStatus m_CurrentLoginStatus; // 0x2C

	// Properties
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public Utf8String PlatformType { get; set; }
	public Utf8String LocalPlatformUserId { get; set; }
	public EpicAccountId AccountId { get; set; }
	public ProductUserId ProductUserId { get; set; }
	public LoginStatus PreviousLoginStatus { get; set; }
	public LoginStatus CurrentLoginStatus { get; set; }

	// Methods

	// RVA: 0x501250 Offset: 0x500450 VA: 0x180501250
	public object get_ClientData() { }

	// RVA: 0x501490 Offset: 0x500690 VA: 0x180501490
	public void set_ClientData(object value) { }

	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x501340 Offset: 0x500540 VA: 0x180501340
	public Utf8String get_PlatformType() { }

	// RVA: 0x501560 Offset: 0x500760 VA: 0x180501560
	public void set_PlatformType(Utf8String value) { }

	// RVA: 0x5012D0 Offset: 0x5004D0 VA: 0x1805012D0
	public Utf8String get_LocalPlatformUserId() { }

	// RVA: 0x501500 Offset: 0x500700 VA: 0x180501500
	public void set_LocalPlatformUserId(Utf8String value) { }

	// RVA: 0x5011D0 Offset: 0x5003D0 VA: 0x1805011D0
	public EpicAccountId get_AccountId() { }

	// RVA: 0x501430 Offset: 0x500630 VA: 0x180501430
	public void set_AccountId(EpicAccountId value) { }

	// RVA: 0x5013B0 Offset: 0x5005B0 VA: 0x1805013B0
	public ProductUserId get_ProductUserId() { }

	// RVA: 0x5015C0 Offset: 0x5007C0 VA: 0x1805015C0
	public void set_ProductUserId(ProductUserId value) { }

	// RVA: 0x3DA050 Offset: 0x3D9250 VA: 0x1803DA050
	public LoginStatus get_PreviousLoginStatus() { }

	// RVA: 0x3DA200 Offset: 0x3D9400 VA: 0x1803DA200
	public void set_PreviousLoginStatus(LoginStatus value) { }

	// RVA: 0x5012C0 Offset: 0x5004C0 VA: 0x1805012C0
	public LoginStatus get_CurrentLoginStatus() { }

	// RVA: 0x5014F0 Offset: 0x5006F0 VA: 0x1805014F0
	public void set_CurrentLoginStatus(LoginStatus value) { }

	// RVA: 0x500E10 Offset: 0x500010 VA: 0x180500E10 Slot: 6
	public void Set(ref UserLoginStatusChangedCallbackInfo other) { }

	// RVA: 0x500FA0 Offset: 0x5001A0 VA: 0x180500FA0 Slot: 7
	public void Set(ref Nullable<UserLoginStatusChangedCallbackInfo> other) { }

	// RVA: 0x500D70 Offset: 0x4FFF70 VA: 0x180500D70 Slot: 8
	public void Dispose() { }

	// RVA: 0x500DF0 Offset: 0x4FFFF0 VA: 0x180500DF0 Slot: 5
	public void Get(out UserLoginStatusChangedCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.IntegratedPlatform
public struct UserPreLogoutCallbackInfo : ICallbackInfo // TypeDefIndex: 9563
{
	// Fields
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <PlatformType>k__BackingField; // 0x8
	[CompilerGenerated]
	private Utf8String <LocalPlatformUserId>k__BackingField; // 0x10
	[CompilerGenerated]
	private EpicAccountId <AccountId>k__BackingField; // 0x18
	[CompilerGenerated]
	private ProductUserId <ProductUserId>k__BackingField; // 0x20

	// Properties
	public object ClientData { get; set; }
	public Utf8String PlatformType { get; set; }
	public Utf8String LocalPlatformUserId { get; set; }
	public EpicAccountId AccountId { get; set; }
	public ProductUserId ProductUserId { get; set; }

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
	public Utf8String get_PlatformType() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_PlatformType(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Utf8String get_LocalPlatformUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_LocalPlatformUserId(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public EpicAccountId get_AccountId() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_AccountId(EpicAccountId value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public ProductUserId get_ProductUserId() { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_ProductUserId(ProductUserId value) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x501FD0 Offset: 0x5011D0 VA: 0x180501FD0
	internal void Set(ref UserPreLogoutCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.IntegratedPlatform
internal struct UserPreLogoutCallbackInfoInternal : ICallbackInfoInternal, IGettable<UserPreLogoutCallbackInfo>, ISettable<UserPreLogoutCallbackInfo>, IDisposable // TypeDefIndex: 9564
{
	// Fields
	private IntPtr m_ClientData; // 0x0
	private IntPtr m_PlatformType; // 0x8
	private IntPtr m_LocalPlatformUserId; // 0x10
	private IntPtr m_AccountId; // 0x18
	private IntPtr m_ProductUserId; // 0x20

	// Properties
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public Utf8String PlatformType { get; set; }
	public Utf8String LocalPlatformUserId { get; set; }
	public EpicAccountId AccountId { get; set; }
	public ProductUserId ProductUserId { get; set; }

	// Methods

	// RVA: 0x501C20 Offset: 0x500E20 VA: 0x180501C20
	public object get_ClientData() { }

	// RVA: 0x501E50 Offset: 0x501050 VA: 0x180501E50
	public void set_ClientData(object value) { }

	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x501D00 Offset: 0x500F00 VA: 0x180501D00
	public Utf8String get_PlatformType() { }

	// RVA: 0x501F10 Offset: 0x501110 VA: 0x180501F10
	public void set_PlatformType(Utf8String value) { }

	// RVA: 0x501C90 Offset: 0x500E90 VA: 0x180501C90
	public Utf8String get_LocalPlatformUserId() { }

	// RVA: 0x501EB0 Offset: 0x5010B0 VA: 0x180501EB0
	public void set_LocalPlatformUserId(Utf8String value) { }

	// RVA: 0x501BA0 Offset: 0x500DA0 VA: 0x180501BA0
	public EpicAccountId get_AccountId() { }

	// RVA: 0x501DF0 Offset: 0x500FF0 VA: 0x180501DF0
	public void set_AccountId(EpicAccountId value) { }

	// RVA: 0x501D70 Offset: 0x500F70 VA: 0x180501D70
	public ProductUserId get_ProductUserId() { }

	// RVA: 0x501F70 Offset: 0x501170 VA: 0x180501F70
	public void set_ProductUserId(ProductUserId value) { }

	// RVA: 0x501A20 Offset: 0x500C20 VA: 0x180501A20 Slot: 6
	public void Set(ref UserPreLogoutCallbackInfo other) { }

	// RVA: 0x501820 Offset: 0x500A20 VA: 0x180501820 Slot: 7
	public void Set(ref Nullable<UserPreLogoutCallbackInfo> other) { }

	// RVA: 0x501770 Offset: 0x500970 VA: 0x180501770 Slot: 8
	public void Dispose() { }

	// RVA: 0x5017F0 Offset: 0x5009F0 VA: 0x1805017F0 Slot: 5
	public void Get(out UserPreLogoutCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.IntegratedPlatform
public struct PS4IntegratedPlatformOptionsContainerAddOptions // TypeDefIndex: 9565
{
	// Fields
	[CompilerGenerated]
	private Nullable<PS4Options> <Options>k__BackingField; // 0x0

	// Properties
	public Nullable<PS4Options> Options { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x492990 Offset: 0x491B90 VA: 0x180492990
	public Nullable<PS4Options> get_Options() { }

	[CompilerGenerated]
	// RVA: 0x4929C0 Offset: 0x491BC0 VA: 0x1804929C0
	public void set_Options(Nullable<PS4Options> value) { }
}

// Namespace: Epic.OnlineServices.IntegratedPlatform
internal struct PS4IntegratedPlatformOptionsContainerAddOptionsInternal : ISettable<PS4IntegratedPlatformOptionsContainerAddOptions>, IDisposable // TypeDefIndex: 9566
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_Options; // 0x8

	// Properties
	public Nullable<PS4Options> Options { set; }

	// Methods

	// RVA: 0x4FD470 Offset: 0x4FC670 VA: 0x1804FD470
	public void set_Options(Nullable<PS4Options> value) { }

	// RVA: 0x4FD2E0 Offset: 0x4FC4E0 VA: 0x1804FD2E0 Slot: 4
	public void Set(ref PS4IntegratedPlatformOptionsContainerAddOptions other) { }

	// RVA: 0x4FD370 Offset: 0x4FC570 VA: 0x1804FD370 Slot: 5
	public void Set(ref Nullable<PS4IntegratedPlatformOptionsContainerAddOptions> other) { }

	// RVA: 0x4FD290 Offset: 0x4FC490 VA: 0x1804FD290 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.IntegratedPlatform
public sealed class PS4ManagedBySdkNotificationMessagesCallback : MulticastDelegate // TypeDefIndex: 9567
{
	// Methods

	// RVA: 0x4FD600 Offset: 0x4FC800 VA: 0x1804FD600
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(object clientData, IntPtr inEvent) { }

	// RVA: 0x4FD570 Offset: 0x4FC770 VA: 0x1804FD570 Slot: 14
	public virtual IAsyncResult BeginInvoke(object clientData, IntPtr inEvent, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.IntegratedPlatform
[UnmanagedFunctionPointer(2)]
internal sealed class PS4ManagedBySdkNotificationMessagesCallbackInternal : MulticastDelegate // TypeDefIndex: 9568
{
	// Methods

	// RVA: 0x43FEE0 Offset: 0x43F0E0 VA: 0x18043FEE0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(IntPtr clientData, IntPtr inEvent) { }

	// RVA: 0x4FD4E0 Offset: 0x4FC6E0 VA: 0x1804FD4E0 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr clientData, IntPtr inEvent, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.IntegratedPlatform
public struct PS4Options // TypeDefIndex: 9569
{
	// Fields
	[CompilerGenerated]
	private Utf8String <Type>k__BackingField; // 0x0
	[CompilerGenerated]
	private IntegratedPlatformManagementFlags <Flags>k__BackingField; // 0x8
	[CompilerGenerated]
	private Nullable<PS4OptionsInitOptions> <InitOptions>k__BackingField; // 0x10

	// Properties
	public Utf8String Type { get; set; }
	public IntegratedPlatformManagementFlags Flags { get; set; }
	public Nullable<PS4OptionsInitOptions> InitOptions { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Utf8String get_Type() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_Type(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3F5510 Offset: 0x3F4710 VA: 0x1803F5510
	public IntegratedPlatformManagementFlags get_Flags() { }

	[CompilerGenerated]
	// RVA: 0x3F5520 Offset: 0x3F4720 VA: 0x1803F5520
	public void set_Flags(IntegratedPlatformManagementFlags value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x4FE170 Offset: 0x4FD370 VA: 0x1804FE170
	public Nullable<PS4OptionsInitOptions> get_InitOptions() { }

	[CompilerGenerated]
	// RVA: 0x4FE190 Offset: 0x4FD390 VA: 0x1804FE190
	public void set_InitOptions(Nullable<PS4OptionsInitOptions> value) { }

	// RVA: 0x4FE070 Offset: 0x4FD270 VA: 0x1804FE070
	internal void Set(ref PS4OptionsInternal other) { }
}

// Namespace: Epic.OnlineServices.IntegratedPlatform
internal struct PS4OptionsInternal : IGettable<PS4Options>, ISettable<PS4Options>, IDisposable // TypeDefIndex: 9570
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_Type; // 0x8
	private IntegratedPlatformManagementFlags m_Flags; // 0x10
	private IntPtr m_InitOptions; // 0x18

	// Properties
	public Utf8String Type { get; set; }
	public IntegratedPlatformManagementFlags Flags { get; set; }
	public Nullable<PS4OptionsInitOptions> InitOptions { get; set; }

	// Methods

	// RVA: 0x4FDF30 Offset: 0x4FD130 VA: 0x1804FDF30
	public Utf8String get_Type() { }

	// RVA: 0x4FE010 Offset: 0x4FD210 VA: 0x1804FE010
	public void set_Type(Utf8String value) { }

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public IntegratedPlatformManagementFlags get_Flags() { }

	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_Flags(IntegratedPlatformManagementFlags value) { }

	// RVA: 0x4FDEB0 Offset: 0x4FD0B0 VA: 0x1804FDEB0
	public Nullable<PS4OptionsInitOptions> get_InitOptions() { }

	// RVA: 0x4FDFA0 Offset: 0x4FD1A0 VA: 0x1804FDFA0
	public void set_InitOptions(Nullable<PS4OptionsInitOptions> value) { }

	// RVA: 0x4FDC90 Offset: 0x4FCE90 VA: 0x1804FDC90 Slot: 5
	public void Set(ref PS4Options other) { }

	// RVA: 0x4FDD70 Offset: 0x4FCF70 VA: 0x1804FDD70 Slot: 6
	public void Set(ref Nullable<PS4Options> other) { }

	// RVA: 0x4FDC10 Offset: 0x4FCE10 VA: 0x1804FDC10 Slot: 7
	public void Dispose() { }

	// RVA: 0x4FDC70 Offset: 0x4FCE70 VA: 0x1804FDC70 Slot: 4
	public void Get(out PS4Options output) { }
}

// Namespace: Epic.OnlineServices.IntegratedPlatform
public struct PS4OptionsInitOptions // TypeDefIndex: 9571
{
	// Fields
	[CompilerGenerated]
	private IntPtr <ManagedBySdkClientData>k__BackingField; // 0x0
	[CompilerGenerated]
	private PS4ManagedBySdkNotificationMessagesCallback <ManagedBySdkCallback>k__BackingField; // 0x8
	[CompilerGenerated]
	private bool <IsPsPlusRequired>k__BackingField; // 0x10

	// Properties
	public IntPtr ManagedBySdkClientData { get; set; }
	public PS4ManagedBySdkNotificationMessagesCallback ManagedBySdkCallback { get; set; }
	public bool IsPsPlusRequired { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public IntPtr get_ManagedBySdkClientData() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_ManagedBySdkClientData(IntPtr value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public PS4ManagedBySdkNotificationMessagesCallback get_ManagedBySdkCallback() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_ManagedBySdkCallback(PS4ManagedBySdkNotificationMessagesCallback value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	public bool get_IsPsPlusRequired() { }

	[CompilerGenerated]
	// RVA: 0x3D6DB0 Offset: 0x3D5FB0 VA: 0x1803D6DB0
	public void set_IsPsPlusRequired(bool value) { }

	// RVA: 0x4FDB90 Offset: 0x4FCD90 VA: 0x1804FDB90
	internal void Set(ref PS4OptionsInitOptionsInternal other) { }
}

// Namespace: Epic.OnlineServices.IntegratedPlatform
internal struct PS4OptionsInitOptionsInternal : IGettable<PS4OptionsInitOptions>, ISettable<PS4OptionsInitOptions>, IDisposable // TypeDefIndex: 9572
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_ManagedBySdkClientData; // 0x8
	private IntPtr m_ManagedBySdkCallback; // 0x10
	private int m_IsPsPlusRequired; // 0x18
	private static PS4ManagedBySdkNotificationMessagesCallbackInternal s_ManagedBySdkCallback; // 0x0

	// Properties
	public IntPtr ManagedBySdkClientData { get; set; }
	public static PS4ManagedBySdkNotificationMessagesCallbackInternal ManagedBySdkCallback { get; }
	public bool IsPsPlusRequired { get; set; }

	// Methods

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public IntPtr get_ManagedBySdkClientData() { }

	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_ManagedBySdkClientData(IntPtr value) { }

	// RVA: 0x4FDA20 Offset: 0x4FCC20 VA: 0x1804FDA20
	public static PS4ManagedBySdkNotificationMessagesCallbackInternal get_ManagedBySdkCallback() { }

	// RVA: 0x4FD9C0 Offset: 0x4FCBC0 VA: 0x1804FD9C0
	public bool get_IsPsPlusRequired() { }

	// RVA: 0x4FDB30 Offset: 0x4FCD30 VA: 0x1804FDB30
	public void set_IsPsPlusRequired(bool value) { }

	// RVA: 0x4FD8E0 Offset: 0x4FCAE0 VA: 0x1804FD8E0 Slot: 5
	public void Set(ref PS4OptionsInitOptions other) { }

	// RVA: 0x4FD7A0 Offset: 0x4FC9A0 VA: 0x1804FD7A0 Slot: 6
	public void Set(ref Nullable<PS4OptionsInitOptions> other) { }

	// RVA: 0x4FD720 Offset: 0x4FC920 VA: 0x1804FD720 Slot: 7
	public void Dispose() { }

	// RVA: 0x4FD780 Offset: 0x4FC980 VA: 0x1804FD780 Slot: 4
	public void Get(out PS4OptionsInitOptions output) { }
}

// Namespace: Epic.OnlineServices.IntegratedPlatform
public struct PS5IntegratedPlatformOptionsContainerAddOptions // TypeDefIndex: 9573
{
	// Fields
	[CompilerGenerated]
	private Nullable<PS5Options> <Options>k__BackingField; // 0x0

	// Properties
	public Nullable<PS5Options> Options { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x4BBD30 Offset: 0x4BAF30 VA: 0x1804BBD30
	public Nullable<PS5Options> get_Options() { }

	[CompilerGenerated]
	// RVA: 0x4BBD50 Offset: 0x4BAF50 VA: 0x1804BBD50
	public void set_Options(Nullable<PS5Options> value) { }
}

// Namespace: Epic.OnlineServices.IntegratedPlatform
internal struct PS5IntegratedPlatformOptionsContainerAddOptionsInternal : ISettable<PS5IntegratedPlatformOptionsContainerAddOptions>, IDisposable // TypeDefIndex: 9574
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_Options; // 0x8

	// Properties
	public Nullable<PS5Options> Options { set; }

	// Methods

	// RVA: 0x4FE340 Offset: 0x4FD540 VA: 0x1804FE340
	public void set_Options(Nullable<PS5Options> value) { }

	// RVA: 0x4FE1F0 Offset: 0x4FD3F0 VA: 0x1804FE1F0 Slot: 4
	public void Set(ref PS5IntegratedPlatformOptionsContainerAddOptions other) { }

	// RVA: 0x4FE270 Offset: 0x4FD470 VA: 0x1804FE270 Slot: 5
	public void Set(ref Nullable<PS5IntegratedPlatformOptionsContainerAddOptions> other) { }

	// RVA: 0x4FE1A0 Offset: 0x4FD3A0 VA: 0x1804FE1A0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.IntegratedPlatform
public struct PS5Options // TypeDefIndex: 9575
{
	// Fields
	[CompilerGenerated]
	private Utf8String <Type>k__BackingField; // 0x0
	[CompilerGenerated]
	private IntegratedPlatformManagementFlags <Flags>k__BackingField; // 0x8
	[CompilerGenerated]
	private Nullable<PS5OptionsInitOptions> <InitOptions>k__BackingField; // 0xC

	// Properties
	public Utf8String Type { get; set; }
	public IntegratedPlatformManagementFlags Flags { get; set; }
	public Nullable<PS5OptionsInitOptions> InitOptions { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Utf8String get_Type() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_Type(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3F5510 Offset: 0x3F4710 VA: 0x1803F5510
	public IntegratedPlatformManagementFlags get_Flags() { }

	[CompilerGenerated]
	// RVA: 0x3F5520 Offset: 0x3F4720 VA: 0x1803F5520
	public void set_Flags(IntegratedPlatformManagementFlags value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x4FEB90 Offset: 0x4FDD90 VA: 0x1804FEB90
	public Nullable<PS5OptionsInitOptions> get_InitOptions() { }

	[CompilerGenerated]
	// RVA: 0x4FEBA0 Offset: 0x4FDDA0 VA: 0x1804FEBA0
	public void set_InitOptions(Nullable<PS5OptionsInitOptions> value) { }

	// RVA: 0x4FEAA0 Offset: 0x4FDCA0 VA: 0x1804FEAA0
	internal void Set(ref PS5OptionsInternal other) { }
}

// Namespace: Epic.OnlineServices.IntegratedPlatform
internal struct PS5OptionsInternal : IGettable<PS5Options>, ISettable<PS5Options>, IDisposable // TypeDefIndex: 9576
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_Type; // 0x8
	private IntegratedPlatformManagementFlags m_Flags; // 0x10
	private IntPtr m_InitOptions; // 0x18

	// Properties
	public Utf8String Type { get; set; }
	public IntegratedPlatformManagementFlags Flags { get; set; }
	public Nullable<PS5OptionsInitOptions> InitOptions { get; set; }

	// Methods

	// RVA: 0x4FE960 Offset: 0x4FDB60 VA: 0x1804FE960
	public Utf8String get_Type() { }

	// RVA: 0x4FEA40 Offset: 0x4FDC40 VA: 0x1804FEA40
	public void set_Type(Utf8String value) { }

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public IntegratedPlatformManagementFlags get_Flags() { }

	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_Flags(IntegratedPlatformManagementFlags value) { }

	// RVA: 0x4FE8F0 Offset: 0x4FDAF0 VA: 0x1804FE8F0
	public Nullable<PS5OptionsInitOptions> get_InitOptions() { }

	// RVA: 0x4FE9D0 Offset: 0x4FDBD0 VA: 0x1804FE9D0
	public void set_InitOptions(Nullable<PS5OptionsInitOptions> value) { }

	// RVA: 0x4FE6E0 Offset: 0x4FD8E0 VA: 0x1804FE6E0 Slot: 5
	public void Set(ref PS5Options other) { }

	// RVA: 0x4FE7B0 Offset: 0x4FD9B0 VA: 0x1804FE7B0 Slot: 6
	public void Set(ref Nullable<PS5Options> other) { }

	// RVA: 0x4FE660 Offset: 0x4FD860 VA: 0x1804FE660 Slot: 7
	public void Dispose() { }

	// RVA: 0x4FE6C0 Offset: 0x4FD8C0 VA: 0x1804FE6C0 Slot: 4
	public void Get(out PS5Options output) { }
}

// Namespace: Epic.OnlineServices.IntegratedPlatform
public struct PS5OptionsInitOptions // TypeDefIndex: 9577
{
	// Fields
	[CompilerGenerated]
	private bool <IsPsPlusRequired>k__BackingField; // 0x0

	// Properties
	public bool IsPsPlusRequired { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x41D600 Offset: 0x41C800 VA: 0x18041D600
	public bool get_IsPsPlusRequired() { }

	[CompilerGenerated]
	// RVA: 0x41D610 Offset: 0x41C810 VA: 0x18041D610
	public void set_IsPsPlusRequired(bool value) { }

	// RVA: 0x4FE5F0 Offset: 0x4FD7F0 VA: 0x1804FE5F0
	internal void Set(ref PS5OptionsInitOptionsInternal other) { }
}

// Namespace: Epic.OnlineServices.IntegratedPlatform
internal struct PS5OptionsInitOptionsInternal : IGettable<PS5OptionsInitOptions>, ISettable<PS5OptionsInitOptions>, IDisposable // TypeDefIndex: 9578
{
	// Fields
	private int m_ApiVersion; // 0x0
	private int m_IsPsPlusRequired; // 0x4

	// Properties
	public bool IsPsPlusRequired { get; set; }

	// Methods

	// RVA: 0x4FE530 Offset: 0x4FD730 VA: 0x1804FE530
	public bool get_IsPsPlusRequired() { }

	// RVA: 0x4FE590 Offset: 0x4FD790 VA: 0x1804FE590
	public void set_IsPsPlusRequired(bool value) { }

	// RVA: 0x4FE420 Offset: 0x4FD620 VA: 0x1804FE420 Slot: 5
	public void Set(ref PS5OptionsInitOptions other) { }

	// RVA: 0x4FE490 Offset: 0x4FD690 VA: 0x1804FE490 Slot: 6
	public void Set(ref Nullable<PS5OptionsInitOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 7
	public void Dispose() { }

	// RVA: 0x4FE3B0 Offset: 0x4FD5B0 VA: 0x1804FE3B0 Slot: 4
	public void Get(out PS5OptionsInitOptions output) { }
}

// Namespace: Epic.OnlineServices.IntegratedPlatform
public struct XboxOneGDKIntegratedPlatformOptionsContainerAddOptions // TypeDefIndex: 9579
{
	// Fields
	[CompilerGenerated]
	private Nullable<XboxOneGDKXBLOptions> <Options>k__BackingField; // 0x0

	// Properties
	public Nullable<XboxOneGDKXBLOptions> Options { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x502350 Offset: 0x501550 VA: 0x180502350
	public Nullable<XboxOneGDKXBLOptions> get_Options() { }

	[CompilerGenerated]
	// RVA: 0x502370 Offset: 0x501570 VA: 0x180502370
	public void set_Options(Nullable<XboxOneGDKXBLOptions> value) { }
}

// Namespace: Epic.OnlineServices.IntegratedPlatform
internal struct XboxOneGDKIntegratedPlatformOptionsContainerAddOptionsInternal : ISettable<XboxOneGDKIntegratedPlatformOptionsContainerAddOptions>, IDisposable // TypeDefIndex: 9580
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_Options; // 0x8

	// Properties
	public Nullable<XboxOneGDKXBLOptions> Options { set; }

	// Methods

	// RVA: 0x503110 Offset: 0x502310 VA: 0x180503110
	public void set_Options(Nullable<XboxOneGDKXBLOptions> value) { }

	// RVA: 0x502FA0 Offset: 0x5021A0 VA: 0x180502FA0 Slot: 4
	public void Set(ref XboxOneGDKIntegratedPlatformOptionsContainerAddOptions other) { }

	// RVA: 0x503030 Offset: 0x502230 VA: 0x180503030 Slot: 5
	public void Set(ref Nullable<XboxOneGDKIntegratedPlatformOptionsContainerAddOptions> other) { }

	// RVA: 0x502F50 Offset: 0x502150 VA: 0x180502F50 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.IntegratedPlatform
public struct XboxOneGDKXBLOptions // TypeDefIndex: 9581
{
	// Fields
	[CompilerGenerated]
	private Utf8String <Type>k__BackingField; // 0x0
	[CompilerGenerated]
	private IntegratedPlatformManagementFlags <Flags>k__BackingField; // 0x8
	[CompilerGenerated]
	private Nullable<XboxOneGDKXBLOptionsInitOptions> <InitOptions>k__BackingField; // 0x10

	// Properties
	public Utf8String Type { get; set; }
	public IntegratedPlatformManagementFlags Flags { get; set; }
	public Nullable<XboxOneGDKXBLOptionsInitOptions> InitOptions { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Utf8String get_Type() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_Type(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3F5510 Offset: 0x3F4710 VA: 0x1803F5510
	public IntegratedPlatformManagementFlags get_Flags() { }

	[CompilerGenerated]
	// RVA: 0x3F5520 Offset: 0x3F4720 VA: 0x1803F5520
	public void set_Flags(IntegratedPlatformManagementFlags value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x44F1F0 Offset: 0x44E3F0 VA: 0x18044F1F0
	public Nullable<XboxOneGDKXBLOptionsInitOptions> get_InitOptions() { }

	[CompilerGenerated]
	// RVA: 0x44F220 Offset: 0x44E420 VA: 0x18044F220
	public void set_InitOptions(Nullable<XboxOneGDKXBLOptionsInitOptions> value) { }

	// RVA: 0x503C40 Offset: 0x502E40 VA: 0x180503C40
	internal void Set(ref XboxOneGDKXBLOptionsInternal other) { }
}

// Namespace: Epic.OnlineServices.IntegratedPlatform
internal struct XboxOneGDKXBLOptionsInternal : IGettable<XboxOneGDKXBLOptions>, ISettable<XboxOneGDKXBLOptions>, IDisposable // TypeDefIndex: 9582
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_Type; // 0x8
	private IntegratedPlatformManagementFlags m_Flags; // 0x10
	private IntPtr m_InitOptions; // 0x18

	// Properties
	public Utf8String Type { get; set; }
	public IntegratedPlatformManagementFlags Flags { get; set; }
	public Nullable<XboxOneGDKXBLOptionsInitOptions> InitOptions { get; set; }

	// Methods

	// RVA: 0x503B00 Offset: 0x502D00 VA: 0x180503B00
	public Utf8String get_Type() { }

	// RVA: 0x503BE0 Offset: 0x502DE0 VA: 0x180503BE0
	public void set_Type(Utf8String value) { }

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public IntegratedPlatformManagementFlags get_Flags() { }

	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_Flags(IntegratedPlatformManagementFlags value) { }

	// RVA: 0x503A80 Offset: 0x502C80 VA: 0x180503A80
	public Nullable<XboxOneGDKXBLOptionsInitOptions> get_InitOptions() { }

	// RVA: 0x503B70 Offset: 0x502D70 VA: 0x180503B70
	public void set_InitOptions(Nullable<XboxOneGDKXBLOptionsInitOptions> value) { }

	// RVA: 0x503850 Offset: 0x502A50 VA: 0x180503850 Slot: 5
	public void Set(ref XboxOneGDKXBLOptions other) { }

	// RVA: 0x503930 Offset: 0x502B30 VA: 0x180503930 Slot: 6
	public void Set(ref Nullable<XboxOneGDKXBLOptions> other) { }

	// RVA: 0x5037C0 Offset: 0x5029C0 VA: 0x1805037C0 Slot: 7
	public void Dispose() { }

	// RVA: 0x503820 Offset: 0x502A20 VA: 0x180503820 Slot: 4
	public void Get(out XboxOneGDKXBLOptions output) { }
}

// Namespace: Epic.OnlineServices.IntegratedPlatform
public struct XboxOneGDKXBLOptionsInitOptions // TypeDefIndex: 9583
{
	// Fields
	[CompilerGenerated]
	private Utf8String <ServiceConfigurationID>k__BackingField; // 0x0
	[CompilerGenerated]
	private bool <IsXboxGoldRequired>k__BackingField; // 0x8
	[CompilerGenerated]
	private bool <UseClassicGamertag>k__BackingField; // 0x9

	// Properties
	public Utf8String ServiceConfigurationID { get; set; }
	public bool IsXboxGoldRequired { get; set; }
	public bool UseClassicGamertag { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Utf8String get_ServiceConfigurationID() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_ServiceConfigurationID(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x48F5C0 Offset: 0x48E7C0 VA: 0x18048F5C0
	public bool get_IsXboxGoldRequired() { }

	[CompilerGenerated]
	// RVA: 0x48F5E0 Offset: 0x48E7E0 VA: 0x18048F5E0
	public void set_IsXboxGoldRequired(bool value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x48F5B0 Offset: 0x48E7B0 VA: 0x18048F5B0
	public bool get_UseClassicGamertag() { }

	[CompilerGenerated]
	// RVA: 0x48F5D0 Offset: 0x48E7D0 VA: 0x18048F5D0
	public void set_UseClassicGamertag(bool value) { }

	// RVA: 0x5036A0 Offset: 0x5028A0 VA: 0x1805036A0
	internal void Set(ref XboxOneGDKXBLOptionsInitOptionsInternal other) { }
}

// Namespace: Epic.OnlineServices.IntegratedPlatform
internal struct XboxOneGDKXBLOptionsInitOptionsInternal : IGettable<XboxOneGDKXBLOptionsInitOptions>, ISettable<XboxOneGDKXBLOptionsInitOptions>, IDisposable // TypeDefIndex: 9584
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_ServiceConfigurationID; // 0x8
	private int m_IsXboxGoldRequired; // 0x10
	private int m_UseClassicGamertag; // 0x14

	// Properties
	public Utf8String ServiceConfigurationID { get; set; }
	public bool IsXboxGoldRequired { get; set; }
	public bool UseClassicGamertag { get; set; }

	// Methods

	// RVA: 0x5034B0 Offset: 0x5026B0 VA: 0x1805034B0
	public Utf8String get_ServiceConfigurationID() { }

	// RVA: 0x5035E0 Offset: 0x5027E0 VA: 0x1805035E0
	public void set_ServiceConfigurationID(Utf8String value) { }

	// RVA: 0x503450 Offset: 0x502650 VA: 0x180503450
	public bool get_IsXboxGoldRequired() { }

	// RVA: 0x503580 Offset: 0x502780 VA: 0x180503580
	public void set_IsXboxGoldRequired(bool value) { }

	// RVA: 0x503520 Offset: 0x502720 VA: 0x180503520
	public bool get_UseClassicGamertag() { }

	// RVA: 0x503640 Offset: 0x502840 VA: 0x180503640
	public void set_UseClassicGamertag(bool value) { }

	// RVA: 0x503350 Offset: 0x502550 VA: 0x180503350 Slot: 5
	public void Set(ref XboxOneGDKXBLOptionsInitOptions other) { }

	// RVA: 0x5031F0 Offset: 0x5023F0 VA: 0x1805031F0 Slot: 6
	public void Set(ref Nullable<XboxOneGDKXBLOptionsInitOptions> other) { }

	// RVA: 0x503180 Offset: 0x502380 VA: 0x180503180 Slot: 7
	public void Dispose() { }

	// RVA: 0x5031D0 Offset: 0x5023D0 VA: 0x1805031D0 Slot: 4
	public void Get(out XboxOneGDKXBLOptionsInitOptions output) { }
}

// Namespace: Epic.OnlineServices.IntegratedPlatform
public struct XSXIntegratedPlatformOptionsContainerAddOptions // TypeDefIndex: 9585
{
	// Fields
	[CompilerGenerated]
	private Nullable<XSXXBLOptions> <Options>k__BackingField; // 0x0

	// Properties
	public Nullable<XSXXBLOptions> Options { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x502350 Offset: 0x501550 VA: 0x180502350
	public Nullable<XSXXBLOptions> get_Options() { }

	[CompilerGenerated]
	// RVA: 0x502370 Offset: 0x501570 VA: 0x180502370
	public void set_Options(Nullable<XSXXBLOptions> value) { }
}

// Namespace: Epic.OnlineServices.IntegratedPlatform
internal struct XSXIntegratedPlatformOptionsContainerAddOptionsInternal : ISettable<XSXIntegratedPlatformOptionsContainerAddOptions>, IDisposable // TypeDefIndex: 9586
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_Options; // 0x8

	// Properties
	public Nullable<XSXXBLOptions> Options { set; }

	// Methods

	// RVA: 0x5022E0 Offset: 0x5014E0 VA: 0x1805022E0
	public void set_Options(Nullable<XSXXBLOptions> value) { }

	// RVA: 0x502250 Offset: 0x501450 VA: 0x180502250 Slot: 4
	public void Set(ref XSXIntegratedPlatformOptionsContainerAddOptions other) { }

	// RVA: 0x502170 Offset: 0x501370 VA: 0x180502170 Slot: 5
	public void Set(ref Nullable<XSXIntegratedPlatformOptionsContainerAddOptions> other) { }

	// RVA: 0x502120 Offset: 0x501320 VA: 0x180502120 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.IntegratedPlatform
public struct XSXXBLOptions // TypeDefIndex: 9587
{
	// Fields
	[CompilerGenerated]
	private Utf8String <Type>k__BackingField; // 0x0
	[CompilerGenerated]
	private IntegratedPlatformManagementFlags <Flags>k__BackingField; // 0x8
	[CompilerGenerated]
	private Nullable<XSXXBLOptionsInitOptions> <InitOptions>k__BackingField; // 0x10

	// Properties
	public Utf8String Type { get; set; }
	public IntegratedPlatformManagementFlags Flags { get; set; }
	public Nullable<XSXXBLOptionsInitOptions> InitOptions { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Utf8String get_Type() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_Type(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3F5510 Offset: 0x3F4710 VA: 0x1803F5510
	public IntegratedPlatformManagementFlags get_Flags() { }

	[CompilerGenerated]
	// RVA: 0x3F5520 Offset: 0x3F4720 VA: 0x1803F5520
	public void set_Flags(IntegratedPlatformManagementFlags value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x44F1F0 Offset: 0x44E3F0 VA: 0x18044F1F0
	public Nullable<XSXXBLOptionsInitOptions> get_InitOptions() { }

	[CompilerGenerated]
	// RVA: 0x44F220 Offset: 0x44E420 VA: 0x18044F220
	public void set_InitOptions(Nullable<XSXXBLOptionsInitOptions> value) { }

	// RVA: 0x502E50 Offset: 0x502050 VA: 0x180502E50
	internal void Set(ref XSXXBLOptionsInternal other) { }
}

// Namespace: Epic.OnlineServices.IntegratedPlatform
internal struct XSXXBLOptionsInternal : IGettable<XSXXBLOptions>, ISettable<XSXXBLOptions>, IDisposable // TypeDefIndex: 9588
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_Type; // 0x8
	private IntegratedPlatformManagementFlags m_Flags; // 0x10
	private IntPtr m_InitOptions; // 0x18

	// Properties
	public Utf8String Type { get; set; }
	public IntegratedPlatformManagementFlags Flags { get; set; }
	public Nullable<XSXXBLOptionsInitOptions> InitOptions { get; set; }

	// Methods

	// RVA: 0x502D10 Offset: 0x501F10 VA: 0x180502D10
	public Utf8String get_Type() { }

	// RVA: 0x502DF0 Offset: 0x501FF0 VA: 0x180502DF0
	public void set_Type(Utf8String value) { }

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public IntegratedPlatformManagementFlags get_Flags() { }

	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_Flags(IntegratedPlatformManagementFlags value) { }

	// RVA: 0x502C90 Offset: 0x501E90 VA: 0x180502C90
	public Nullable<XSXXBLOptionsInitOptions> get_InitOptions() { }

	// RVA: 0x502D80 Offset: 0x501F80 VA: 0x180502D80
	public void set_InitOptions(Nullable<XSXXBLOptionsInitOptions> value) { }

	// RVA: 0x502BB0 Offset: 0x501DB0 VA: 0x180502BB0 Slot: 5
	public void Set(ref XSXXBLOptions other) { }

	// RVA: 0x502A60 Offset: 0x501C60 VA: 0x180502A60 Slot: 6
	public void Set(ref Nullable<XSXXBLOptions> other) { }

	// RVA: 0x5029D0 Offset: 0x501BD0 VA: 0x1805029D0 Slot: 7
	public void Dispose() { }

	// RVA: 0x502A30 Offset: 0x501C30 VA: 0x180502A30 Slot: 4
	public void Get(out XSXXBLOptions output) { }
}

// Namespace: Epic.OnlineServices.IntegratedPlatform
public struct XSXXBLOptionsInitOptions // TypeDefIndex: 9589
{
	// Fields
	[CompilerGenerated]
	private Utf8String <ServiceConfigurationID>k__BackingField; // 0x0
	[CompilerGenerated]
	private bool <IsXboxGoldRequired>k__BackingField; // 0x8
	[CompilerGenerated]
	private bool <UseClassicGamertag>k__BackingField; // 0x9

	// Properties
	public Utf8String ServiceConfigurationID { get; set; }
	public bool IsXboxGoldRequired { get; set; }
	public bool UseClassicGamertag { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Utf8String get_ServiceConfigurationID() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_ServiceConfigurationID(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x48F5C0 Offset: 0x48E7C0 VA: 0x18048F5C0
	public bool get_IsXboxGoldRequired() { }

	[CompilerGenerated]
	// RVA: 0x48F5E0 Offset: 0x48E7E0 VA: 0x18048F5E0
	public void set_IsXboxGoldRequired(bool value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x48F5B0 Offset: 0x48E7B0 VA: 0x18048F5B0
	public bool get_UseClassicGamertag() { }

	[CompilerGenerated]
	// RVA: 0x48F5D0 Offset: 0x48E7D0 VA: 0x18048F5D0
	public void set_UseClassicGamertag(bool value) { }

	// RVA: 0x5028B0 Offset: 0x501AB0 VA: 0x1805028B0
	internal void Set(ref XSXXBLOptionsInitOptionsInternal other) { }
}

// Namespace: Epic.OnlineServices.IntegratedPlatform
internal struct XSXXBLOptionsInitOptionsInternal : IGettable<XSXXBLOptionsInitOptions>, ISettable<XSXXBLOptionsInitOptions>, IDisposable // TypeDefIndex: 9590
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_ServiceConfigurationID; // 0x8
	private int m_IsXboxGoldRequired; // 0x10
	private int m_UseClassicGamertag; // 0x14

	// Properties
	public Utf8String ServiceConfigurationID { get; set; }
	public bool IsXboxGoldRequired { get; set; }
	public bool UseClassicGamertag { get; set; }

	// Methods

	// RVA: 0x5026C0 Offset: 0x5018C0 VA: 0x1805026C0
	public Utf8String get_ServiceConfigurationID() { }

	// RVA: 0x5027F0 Offset: 0x5019F0 VA: 0x1805027F0
	public void set_ServiceConfigurationID(Utf8String value) { }

	// RVA: 0x502660 Offset: 0x501860 VA: 0x180502660
	public bool get_IsXboxGoldRequired() { }

	// RVA: 0x502790 Offset: 0x501990 VA: 0x180502790
	public void set_IsXboxGoldRequired(bool value) { }

	// RVA: 0x502730 Offset: 0x501930 VA: 0x180502730
	public bool get_UseClassicGamertag() { }

	// RVA: 0x502850 Offset: 0x501A50 VA: 0x180502850
	public void set_UseClassicGamertag(bool value) { }

	// RVA: 0x502560 Offset: 0x501760 VA: 0x180502560 Slot: 5
	public void Set(ref XSXXBLOptionsInitOptions other) { }

	// RVA: 0x502400 Offset: 0x501600 VA: 0x180502400 Slot: 6
	public void Set(ref Nullable<XSXXBLOptionsInitOptions> other) { }

	// RVA: 0x502390 Offset: 0x501590 VA: 0x180502390 Slot: 7
	public void Dispose() { }

	// RVA: 0x5023E0 Offset: 0x5015E0 VA: 0x1805023E0 Slot: 4
	public void Get(out XSXXBLOptionsInitOptions output) { }
}

// Namespace: Epic.OnlineServices.Friends
public struct AcceptInviteCallbackInfo : ICallbackInfo // TypeDefIndex: 9591
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

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public EpicAccountId get_TargetUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_TargetUserId(EpicAccountId value) { }

	// RVA: 0x4EBBF0 Offset: 0x4EADF0 VA: 0x1804EBBF0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x4EBC40 Offset: 0x4EAE40 VA: 0x1804EBC40
	internal void Set(ref AcceptInviteCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.Friends
internal struct AcceptInviteCallbackInfoInternal : ICallbackInfoInternal, IGettable<AcceptInviteCallbackInfo>, ISettable<AcceptInviteCallbackInfo>, IDisposable // TypeDefIndex: 9592
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

	// RVA: 0x4EB960 Offset: 0x4EAB60 VA: 0x1804EB960
	public object get_ClientData() { }

	// RVA: 0x4EBAD0 Offset: 0x4EACD0 VA: 0x1804EBAD0
	public void set_ClientData(object value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x4EB9D0 Offset: 0x4EABD0 VA: 0x1804EB9D0
	public EpicAccountId get_LocalUserId() { }

	// RVA: 0x4EBB30 Offset: 0x4EAD30 VA: 0x1804EBB30
	public void set_LocalUserId(EpicAccountId value) { }

	// RVA: 0x4EBA50 Offset: 0x4EAC50 VA: 0x1804EBA50
	public EpicAccountId get_TargetUserId() { }

	// RVA: 0x4EBB90 Offset: 0x4EAD90 VA: 0x1804EBB90
	public void set_TargetUserId(EpicAccountId value) { }

	// RVA: 0x4EB860 Offset: 0x4EAA60 VA: 0x1804EB860 Slot: 6
	public void Set(ref AcceptInviteCallbackInfo other) { }

	// RVA: 0x4EB6F0 Offset: 0x4EA8F0 VA: 0x1804EB6F0 Slot: 7
	public void Set(ref Nullable<AcceptInviteCallbackInfo> other) { }

	// RVA: 0x4EB670 Offset: 0x4EA870 VA: 0x1804EB670 Slot: 8
	public void Dispose() { }

	// RVA: 0x4EB6D0 Offset: 0x4EA8D0 VA: 0x1804EB6D0 Slot: 5
	public void Get(out AcceptInviteCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.Friends
public struct AcceptInviteOptions // TypeDefIndex: 9593
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

// Namespace: Epic.OnlineServices.Friends
internal struct AcceptInviteOptionsInternal : ISettable<AcceptInviteOptions>, IDisposable // TypeDefIndex: 9594
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_TargetUserId; // 0x10

	// Properties
	public EpicAccountId LocalUserId { set; }
	public EpicAccountId TargetUserId { set; }

	// Methods

	// RVA: 0x4EBF00 Offset: 0x4EB100 VA: 0x1804EBF00
	public void set_LocalUserId(EpicAccountId value) { }

	// RVA: 0x4EBF60 Offset: 0x4EB160 VA: 0x1804EBF60
	public void set_TargetUserId(EpicAccountId value) { }

	// RVA: 0x4EBD40 Offset: 0x4EAF40 VA: 0x1804EBD40 Slot: 4
	public void Set(ref AcceptInviteOptions other) { }

	// RVA: 0x4EBE00 Offset: 0x4EB000 VA: 0x1804EBE00 Slot: 5
	public void Set(ref Nullable<AcceptInviteOptions> other) { }

	// RVA: 0x4EBCE0 Offset: 0x4EAEE0 VA: 0x1804EBCE0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Friends
public struct AddNotifyBlockedUsersUpdateOptions // TypeDefIndex: 9595
{}

// Namespace: Epic.OnlineServices.Friends
internal struct AddNotifyBlockedUsersUpdateOptionsInternal : ISettable<AddNotifyBlockedUsersUpdateOptions>, IDisposable // TypeDefIndex: 9596
{
	// Fields
	private int m_ApiVersion; // 0x0

	// Methods

	// RVA: 0x3F98A0 Offset: 0x3F8AA0 VA: 0x1803F98A0 Slot: 4
	public void Set(ref AddNotifyBlockedUsersUpdateOptions other) { }

	// RVA: 0x4EBFC0 Offset: 0x4EB1C0 VA: 0x1804EBFC0 Slot: 5
	public void Set(ref Nullable<AddNotifyBlockedUsersUpdateOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Friends
public struct AddNotifyFriendsUpdateOptions // TypeDefIndex: 9597
{}

// Namespace: Epic.OnlineServices.Friends
internal struct AddNotifyFriendsUpdateOptionsInternal : ISettable<AddNotifyFriendsUpdateOptions>, IDisposable // TypeDefIndex: 9598
{
	// Fields
	private int m_ApiVersion; // 0x0

	// Methods

	// RVA: 0x3F98A0 Offset: 0x3F8AA0 VA: 0x1803F98A0 Slot: 4
	public void Set(ref AddNotifyFriendsUpdateOptions other) { }

	// RVA: 0x4EC010 Offset: 0x4EB210 VA: 0x1804EC010 Slot: 5
	public void Set(ref Nullable<AddNotifyFriendsUpdateOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Friends
public sealed class FriendsInterface : Handle // TypeDefIndex: 9599
{
	// Fields
	public const int AcceptinviteApiLatest = 1;
	public const int AddnotifyblockedusersupdateApiLatest = 1;
	public const int AddnotifyfriendsupdateApiLatest = 1;
	public const int GetblockeduseratindexApiLatest = 1;
	public const int GetblockeduserscountApiLatest = 1;
	public const int GetfriendatindexApiLatest = 1;
	public const int GetfriendscountApiLatest = 1;
	public const int GetstatusApiLatest = 1;
	public const int QueryfriendsApiLatest = 1;
	public const int RejectinviteApiLatest = 1;
	public const int SendinviteApiLatest = 1;

	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }

	// RVA: 0x40BDB0 Offset: 0x40AFB0 VA: 0x18040BDB0
	public void .ctor(IntPtr innerHandle) { }

	// RVA: 0x4F4820 Offset: 0x4F3A20 VA: 0x1804F4820
	public void AcceptInvite(ref AcceptInviteOptions options, object clientData, OnAcceptInviteCallback completionDelegate) { }

	// RVA: 0x4F49D0 Offset: 0x4F3BD0 VA: 0x1804F49D0
	public ulong AddNotifyBlockedUsersUpdate(ref AddNotifyBlockedUsersUpdateOptions options, object clientData, OnBlockedUsersUpdateCallback blockedUsersUpdateHandler) { }

	// RVA: 0x4F4B80 Offset: 0x4F3D80 VA: 0x1804F4B80
	public ulong AddNotifyFriendsUpdate(ref AddNotifyFriendsUpdateOptions options, object clientData, OnFriendsUpdateCallback friendsUpdateHandler) { }

	// RVA: 0x4F4D30 Offset: 0x4F3F30 VA: 0x1804F4D30
	public EpicAccountId GetBlockedUserAtIndex(ref GetBlockedUserAtIndexOptions options) { }

	// RVA: 0x4F4E50 Offset: 0x4F4050 VA: 0x1804F4E50
	public int GetBlockedUsersCount(ref GetBlockedUsersCountOptions options) { }

	// RVA: 0x4F4F30 Offset: 0x4F4130 VA: 0x1804F4F30
	public EpicAccountId GetFriendAtIndex(ref GetFriendAtIndexOptions options) { }

	// RVA: 0x4F5050 Offset: 0x4F4250 VA: 0x1804F5050
	public int GetFriendsCount(ref GetFriendsCountOptions options) { }

	// RVA: 0x4F5130 Offset: 0x4F4330 VA: 0x1804F5130
	public FriendsStatus GetStatus(ref GetStatusOptions options) { }

	// RVA: 0x4F55F0 Offset: 0x4F47F0 VA: 0x1804F55F0
	public void QueryFriends(ref QueryFriendsOptions options, object clientData, OnQueryFriendsCallback completionDelegate) { }

	// RVA: 0x4F57E0 Offset: 0x4F49E0 VA: 0x1804F57E0
	public void RejectInvite(ref RejectInviteOptions options, object clientData, OnRejectInviteCallback completionDelegate) { }

	// RVA: 0x4F5990 Offset: 0x4F4B90 VA: 0x1804F5990
	public void RemoveNotifyBlockedUsersUpdate(ulong notificationId) { }

	// RVA: 0x4F5A00 Offset: 0x4F4C00 VA: 0x1804F5A00
	public void RemoveNotifyFriendsUpdate(ulong notificationId) { }

	// RVA: 0x4F5A70 Offset: 0x4F4C70 VA: 0x1804F5A70
	public void SendInvite(ref SendInviteOptions options, object clientData, OnSendInviteCallback completionDelegate) { }

	[MonoPInvokeCallback(typeof(OnAcceptInviteCallbackInternal))]
	// RVA: 0x4F51D0 Offset: 0x4F43D0 VA: 0x1804F51D0
	internal static void OnAcceptInviteCallbackInternalImplementation(ref AcceptInviteCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnBlockedUsersUpdateCallbackInternal))]
	// RVA: 0x4F5280 Offset: 0x4F4480 VA: 0x1804F5280
	internal static void OnBlockedUsersUpdateCallbackInternalImplementation(ref OnBlockedUsersUpdateInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnFriendsUpdateCallbackInternal))]
	// RVA: 0x4F5330 Offset: 0x4F4530 VA: 0x1804F5330
	internal static void OnFriendsUpdateCallbackInternalImplementation(ref OnFriendsUpdateInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnQueryFriendsCallbackInternal))]
	// RVA: 0x4F53E0 Offset: 0x4F45E0 VA: 0x1804F53E0
	internal static void OnQueryFriendsCallbackInternalImplementation(ref QueryFriendsCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnRejectInviteCallbackInternal))]
	// RVA: 0x4F5490 Offset: 0x4F4690 VA: 0x1804F5490
	internal static void OnRejectInviteCallbackInternalImplementation(ref RejectInviteCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnSendInviteCallbackInternal))]
	// RVA: 0x4F5540 Offset: 0x4F4740 VA: 0x1804F5540
	internal static void OnSendInviteCallbackInternalImplementation(ref SendInviteCallbackInfoInternal data) { }
}

// Namespace: Epic.OnlineServices.Friends
public enum FriendsStatus // TypeDefIndex: 9600
{
	// Fields
	public int value__; // 0x0
	public const FriendsStatus NotFriends = 0;
	public const FriendsStatus InviteSent = 1;
	public const FriendsStatus InviteReceived = 2;
	public const FriendsStatus Friends = 3;
}

// Namespace: Epic.OnlineServices.Friends
public struct GetBlockedUserAtIndexOptions // TypeDefIndex: 9601
{
	// Fields
	[CompilerGenerated]
	private EpicAccountId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private int <Index>k__BackingField; // 0x8

	// Properties
	public EpicAccountId LocalUserId { get; set; }
	public int Index { get; set; }

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
	public int get_Index() { }

	[CompilerGenerated]
	// RVA: 0x3F5520 Offset: 0x3F4720 VA: 0x1803F5520
	public void set_Index(int value) { }
}

// Namespace: Epic.OnlineServices.Friends
internal struct GetBlockedUserAtIndexOptionsInternal : ISettable<GetBlockedUserAtIndexOptions>, IDisposable // TypeDefIndex: 9602
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private int m_Index; // 0x10

	// Properties
	public EpicAccountId LocalUserId { set; }
	public int Index { set; }

	// Methods

	// RVA: 0x4F5DB0 Offset: 0x4F4FB0 VA: 0x1804F5DB0
	public void set_LocalUserId(EpicAccountId value) { }

	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_Index(int value) { }

	// RVA: 0x4F5D30 Offset: 0x4F4F30 VA: 0x1804F5D30 Slot: 4
	public void Set(ref GetBlockedUserAtIndexOptions other) { }

	// RVA: 0x4F5C70 Offset: 0x4F4E70 VA: 0x1804F5C70 Slot: 5
	public void Set(ref Nullable<GetBlockedUserAtIndexOptions> other) { }

	// RVA: 0x4F5C20 Offset: 0x4F4E20 VA: 0x1804F5C20 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Friends
public struct GetBlockedUsersCountOptions // TypeDefIndex: 9603
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

// Namespace: Epic.OnlineServices.Friends
internal struct GetBlockedUsersCountOptionsInternal : ISettable<GetBlockedUsersCountOptions>, IDisposable // TypeDefIndex: 9604
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8

	// Properties
	public EpicAccountId LocalUserId { set; }

	// Methods

	// RVA: 0x4F5F60 Offset: 0x4F5160 VA: 0x1804F5F60
	public void set_LocalUserId(EpicAccountId value) { }

	// RVA: 0x4F5E60 Offset: 0x4F5060 VA: 0x1804F5E60 Slot: 4
	public void Set(ref GetBlockedUsersCountOptions other) { }

	// RVA: 0x4F5EC0 Offset: 0x4F50C0 VA: 0x1804F5EC0 Slot: 5
	public void Set(ref Nullable<GetBlockedUsersCountOptions> other) { }

	// RVA: 0x4F5E10 Offset: 0x4F5010 VA: 0x1804F5E10 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Friends
public struct GetFriendAtIndexOptions // TypeDefIndex: 9605
{
	// Fields
	[CompilerGenerated]
	private EpicAccountId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private int <Index>k__BackingField; // 0x8

	// Properties
	public EpicAccountId LocalUserId { get; set; }
	public int Index { get; set; }

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
	// RVA: 0x3F5510 Offset: 0x3F4710 VA: 0x1803F5510
	public int get_Index() { }

	[CompilerGenerated]
	// RVA: 0x3F5520 Offset: 0x3F4720 VA: 0x1803F5520
	public void set_Index(int value) { }
}

// Namespace: Epic.OnlineServices.Friends
internal struct GetFriendAtIndexOptionsInternal : ISettable<GetFriendAtIndexOptions>, IDisposable // TypeDefIndex: 9606
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private int m_Index; // 0x10

	// Properties
	public EpicAccountId LocalUserId { set; }
	public int Index { set; }

	// Methods

	// RVA: 0x4F65E0 Offset: 0x4F57E0 VA: 0x1804F65E0
	public void set_LocalUserId(EpicAccountId value) { }

	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_Index(int value) { }

	// RVA: 0x4F6560 Offset: 0x4F5760 VA: 0x1804F6560 Slot: 4
	public void Set(ref GetFriendAtIndexOptions other) { }

	// RVA: 0x4F64A0 Offset: 0x4F56A0 VA: 0x1804F64A0 Slot: 5
	public void Set(ref Nullable<GetFriendAtIndexOptions> other) { }

	// RVA: 0x4F6450 Offset: 0x4F5650 VA: 0x1804F6450 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Friends
public struct GetFriendsCountOptions // TypeDefIndex: 9607
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

// Namespace: Epic.OnlineServices.Friends
internal struct GetFriendsCountOptionsInternal : ISettable<GetFriendsCountOptions>, IDisposable // TypeDefIndex: 9608
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8

	// Properties
	public EpicAccountId LocalUserId { set; }

	// Methods

	// RVA: 0x4F6790 Offset: 0x4F5990 VA: 0x1804F6790
	public void set_LocalUserId(EpicAccountId value) { }

	// RVA: 0x4F6730 Offset: 0x4F5930 VA: 0x1804F6730 Slot: 4
	public void Set(ref GetFriendsCountOptions other) { }

	// RVA: 0x4F6690 Offset: 0x4F5890 VA: 0x1804F6690 Slot: 5
	public void Set(ref Nullable<GetFriendsCountOptions> other) { }

	// RVA: 0x4F6640 Offset: 0x4F5840 VA: 0x1804F6640 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Friends
public struct GetStatusOptions // TypeDefIndex: 9609
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

// Namespace: Epic.OnlineServices.Friends
internal struct GetStatusOptionsInternal : ISettable<GetStatusOptions>, IDisposable // TypeDefIndex: 9610
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_TargetUserId; // 0x10

	// Properties
	public EpicAccountId LocalUserId { set; }
	public EpicAccountId TargetUserId { set; }

	// Methods

	// RVA: 0x4F78F0 Offset: 0x4F6AF0 VA: 0x1804F78F0
	public void set_LocalUserId(EpicAccountId value) { }

	// RVA: 0x4F7950 Offset: 0x4F6B50 VA: 0x1804F7950
	public void set_TargetUserId(EpicAccountId value) { }

	// RVA: 0x4F7830 Offset: 0x4F6A30 VA: 0x1804F7830 Slot: 4
	public void Set(ref GetStatusOptions other) { }

	// RVA: 0x4F7730 Offset: 0x4F6930 VA: 0x1804F7730 Slot: 5
	public void Set(ref Nullable<GetStatusOptions> other) { }

	// RVA: 0x4F76D0 Offset: 0x4F68D0 VA: 0x1804F76D0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Friends
public sealed class OnAcceptInviteCallback : MulticastDelegate // TypeDefIndex: 9611
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref AcceptInviteCallbackInfo data) { }

	// RVA: 0x4FA060 Offset: 0x4F9260 VA: 0x1804FA060 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref AcceptInviteCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref AcceptInviteCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Friends
[UnmanagedFunctionPointer(2)]
internal sealed class OnAcceptInviteCallbackInternal : MulticastDelegate // TypeDefIndex: 9612
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref AcceptInviteCallbackInfoInternal data) { }

	// RVA: 0x4F9FD0 Offset: 0x4F91D0 VA: 0x1804F9FD0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref AcceptInviteCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref AcceptInviteCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Friends
public sealed class OnBlockedUsersUpdateCallback : MulticastDelegate // TypeDefIndex: 9613
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref OnBlockedUsersUpdateInfo data) { }

	// RVA: 0x4FA180 Offset: 0x4F9380 VA: 0x1804FA180 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref OnBlockedUsersUpdateInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref OnBlockedUsersUpdateInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Friends
[UnmanagedFunctionPointer(2)]
internal sealed class OnBlockedUsersUpdateCallbackInternal : MulticastDelegate // TypeDefIndex: 9614
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref OnBlockedUsersUpdateInfoInternal data) { }

	// RVA: 0x4FA0F0 Offset: 0x4F92F0 VA: 0x1804FA0F0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref OnBlockedUsersUpdateInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref OnBlockedUsersUpdateInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Friends
public struct OnBlockedUsersUpdateInfo : ICallbackInfo // TypeDefIndex: 9615
{
	// Fields
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x0
	[CompilerGenerated]
	private EpicAccountId <LocalUserId>k__BackingField; // 0x8
	[CompilerGenerated]
	private EpicAccountId <TargetUserId>k__BackingField; // 0x10
	[CompilerGenerated]
	private bool <Blocked>k__BackingField; // 0x18

	// Properties
	public object ClientData { get; set; }
	public EpicAccountId LocalUserId { get; set; }
	public EpicAccountId TargetUserId { get; set; }
	public bool Blocked { get; set; }

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

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public EpicAccountId get_TargetUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_TargetUserId(EpicAccountId value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x411B20 Offset: 0x410D20 VA: 0x180411B20
	public bool get_Blocked() { }

	[CompilerGenerated]
	// RVA: 0x411B30 Offset: 0x410D30 VA: 0x180411B30
	public void set_Blocked(bool value) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x4FA8D0 Offset: 0x4F9AD0 VA: 0x1804FA8D0
	internal void Set(ref OnBlockedUsersUpdateInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.Friends
internal struct OnBlockedUsersUpdateInfoInternal : ICallbackInfoInternal, IGettable<OnBlockedUsersUpdateInfo>, ISettable<OnBlockedUsersUpdateInfo>, IDisposable // TypeDefIndex: 9616
{
	// Fields
	private IntPtr m_ClientData; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_TargetUserId; // 0x10
	private int m_Blocked; // 0x18

	// Properties
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public EpicAccountId LocalUserId { get; set; }
	public EpicAccountId TargetUserId { get; set; }
	public bool Blocked { get; set; }

	// Methods

	// RVA: 0x4FA5E0 Offset: 0x4F97E0 VA: 0x1804FA5E0
	public object get_ClientData() { }

	// RVA: 0x4FA7B0 Offset: 0x4F99B0 VA: 0x1804FA7B0
	public void set_ClientData(object value) { }

	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x4FA650 Offset: 0x4F9850 VA: 0x1804FA650
	public EpicAccountId get_LocalUserId() { }

	// RVA: 0x4FA810 Offset: 0x4F9A10 VA: 0x1804FA810
	public void set_LocalUserId(EpicAccountId value) { }

	// RVA: 0x4FA6D0 Offset: 0x4F98D0 VA: 0x1804FA6D0
	public EpicAccountId get_TargetUserId() { }

	// RVA: 0x4FA870 Offset: 0x4F9A70 VA: 0x1804FA870
	public void set_TargetUserId(EpicAccountId value) { }

	// RVA: 0x4FA580 Offset: 0x4F9780 VA: 0x1804FA580
	public bool get_Blocked() { }

	// RVA: 0x4FA750 Offset: 0x4F9950 VA: 0x1804FA750
	public void set_Blocked(bool value) { }

	// RVA: 0x4FA440 Offset: 0x4F9640 VA: 0x1804FA440 Slot: 6
	public void Set(ref OnBlockedUsersUpdateInfo other) { }

	// RVA: 0x4FA290 Offset: 0x4F9490 VA: 0x1804FA290 Slot: 7
	public void Set(ref Nullable<OnBlockedUsersUpdateInfo> other) { }

	// RVA: 0x4FA210 Offset: 0x4F9410 VA: 0x1804FA210 Slot: 8
	public void Dispose() { }

	// RVA: 0x4FA270 Offset: 0x4F9470 VA: 0x1804FA270 Slot: 5
	public void Get(out OnBlockedUsersUpdateInfo output) { }
}

// Namespace: Epic.OnlineServices.Friends
public sealed class OnFriendsUpdateCallback : MulticastDelegate // TypeDefIndex: 9617
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref OnFriendsUpdateInfo data) { }

	// RVA: 0x4FB8F0 Offset: 0x4FAAF0 VA: 0x1804FB8F0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref OnFriendsUpdateInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref OnFriendsUpdateInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Friends
[UnmanagedFunctionPointer(2)]
internal sealed class OnFriendsUpdateCallbackInternal : MulticastDelegate // TypeDefIndex: 9618
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref OnFriendsUpdateInfoInternal data) { }

	// RVA: 0x4FB860 Offset: 0x4FAA60 VA: 0x1804FB860 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref OnFriendsUpdateInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref OnFriendsUpdateInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Friends
public struct OnFriendsUpdateInfo : ICallbackInfo // TypeDefIndex: 9619
{
	// Fields
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x0
	[CompilerGenerated]
	private EpicAccountId <LocalUserId>k__BackingField; // 0x8
	[CompilerGenerated]
	private EpicAccountId <TargetUserId>k__BackingField; // 0x10
	[CompilerGenerated]
	private FriendsStatus <PreviousStatus>k__BackingField; // 0x18
	[CompilerGenerated]
	private FriendsStatus <CurrentStatus>k__BackingField; // 0x1C

	// Properties
	public object ClientData { get; set; }
	public EpicAccountId LocalUserId { get; set; }
	public EpicAccountId TargetUserId { get; set; }
	public FriendsStatus PreviousStatus { get; set; }
	public FriendsStatus CurrentStatus { get; set; }

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
	public EpicAccountId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_LocalUserId(EpicAccountId value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public EpicAccountId get_TargetUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_TargetUserId(EpicAccountId value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public FriendsStatus get_PreviousStatus() { }

	[CompilerGenerated]
	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	public void set_PreviousStatus(FriendsStatus value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3F9110 Offset: 0x3F8310 VA: 0x1803F9110
	public FriendsStatus get_CurrentStatus() { }

	[CompilerGenerated]
	// RVA: 0x3F9290 Offset: 0x3F8490 VA: 0x1803F9290
	public void set_CurrentStatus(FriendsStatus value) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x4FBF20 Offset: 0x4FB120 VA: 0x1804FBF20
	internal void Set(ref OnFriendsUpdateInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.Friends
internal struct OnFriendsUpdateInfoInternal : ICallbackInfoInternal, IGettable<OnFriendsUpdateInfo>, ISettable<OnFriendsUpdateInfo>, IDisposable // TypeDefIndex: 9620
{
	// Fields
	private IntPtr m_ClientData; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_TargetUserId; // 0x10
	private FriendsStatus m_PreviousStatus; // 0x18
	private FriendsStatus m_CurrentStatus; // 0x1C

	// Properties
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public EpicAccountId LocalUserId { get; set; }
	public EpicAccountId TargetUserId { get; set; }
	public FriendsStatus PreviousStatus { get; set; }
	public FriendsStatus CurrentStatus { get; set; }

	// Methods

	// RVA: 0x4FBC90 Offset: 0x4FAE90 VA: 0x1804FBC90
	public object get_ClientData() { }

	// RVA: 0x4FBE00 Offset: 0x4FB000 VA: 0x1804FBE00
	public void set_ClientData(object value) { }

	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x4FBD00 Offset: 0x4FAF00 VA: 0x1804FBD00
	public EpicAccountId get_LocalUserId() { }

	// RVA: 0x4FBE60 Offset: 0x4FB060 VA: 0x1804FBE60
	public void set_LocalUserId(EpicAccountId value) { }

	// RVA: 0x4FBD80 Offset: 0x4FAF80 VA: 0x1804FBD80
	public EpicAccountId get_TargetUserId() { }

	// RVA: 0x4FBEC0 Offset: 0x4FB0C0 VA: 0x1804FBEC0
	public void set_TargetUserId(EpicAccountId value) { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public FriendsStatus get_PreviousStatus() { }

	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	public void set_PreviousStatus(FriendsStatus value) { }

	// RVA: 0x3F9110 Offset: 0x3F8310 VA: 0x1803F9110
	public FriendsStatus get_CurrentStatus() { }

	// RVA: 0x3F9290 Offset: 0x3F8490 VA: 0x1803F9290
	public void set_CurrentStatus(FriendsStatus value) { }

	// RVA: 0x4FBA00 Offset: 0x4FAC00 VA: 0x1804FBA00 Slot: 6
	public void Set(ref OnFriendsUpdateInfo other) { }

	// RVA: 0x4FBB00 Offset: 0x4FAD00 VA: 0x1804FBB00 Slot: 7
	public void Set(ref Nullable<OnFriendsUpdateInfo> other) { }

	// RVA: 0x4FB980 Offset: 0x4FAB80 VA: 0x1804FB980 Slot: 8
	public void Dispose() { }

	// RVA: 0x4FB9E0 Offset: 0x4FABE0 VA: 0x1804FB9E0 Slot: 5
	public void Get(out OnFriendsUpdateInfo output) { }
}

// Namespace: Epic.OnlineServices.Friends
public sealed class OnQueryFriendsCallback : MulticastDelegate // TypeDefIndex: 9621
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref QueryFriendsCallbackInfo data) { }

	// RVA: 0x4FC660 Offset: 0x4FB860 VA: 0x1804FC660 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref QueryFriendsCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref QueryFriendsCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Friends
[UnmanagedFunctionPointer(2)]
internal sealed class OnQueryFriendsCallbackInternal : MulticastDelegate // TypeDefIndex: 9622
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref QueryFriendsCallbackInfoInternal data) { }

	// RVA: 0x4FC5D0 Offset: 0x4FB7D0 VA: 0x1804FC5D0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref QueryFriendsCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref QueryFriendsCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Friends
public sealed class OnRejectInviteCallback : MulticastDelegate // TypeDefIndex: 9623
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref RejectInviteCallbackInfo data) { }

	// RVA: 0x4FC780 Offset: 0x4FB980 VA: 0x1804FC780 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref RejectInviteCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref RejectInviteCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Friends
[UnmanagedFunctionPointer(2)]
internal sealed class OnRejectInviteCallbackInternal : MulticastDelegate // TypeDefIndex: 9624
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref RejectInviteCallbackInfoInternal data) { }

	// RVA: 0x4FC6F0 Offset: 0x4FB8F0 VA: 0x1804FC6F0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref RejectInviteCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref RejectInviteCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Friends
public sealed class OnSendInviteCallback : MulticastDelegate // TypeDefIndex: 9625
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref SendInviteCallbackInfo data) { }

	// RVA: 0x4FC8A0 Offset: 0x4FBAA0 VA: 0x1804FC8A0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref SendInviteCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref SendInviteCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Friends
[UnmanagedFunctionPointer(2)]
internal sealed class OnSendInviteCallbackInternal : MulticastDelegate // TypeDefIndex: 9626
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref SendInviteCallbackInfoInternal data) { }

	// RVA: 0x4FC810 Offset: 0x4FBA10 VA: 0x1804FC810 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref SendInviteCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref SendInviteCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Friends
public struct QueryFriendsCallbackInfo : ICallbackInfo // TypeDefIndex: 9627
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

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public EpicAccountId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_LocalUserId(EpicAccountId value) { }

	// RVA: 0x4FEFB0 Offset: 0x4FE1B0 VA: 0x1804FEFB0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x4FF000 Offset: 0x4FE200 VA: 0x1804FF000
	internal void Set(ref QueryFriendsCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.Friends
internal struct QueryFriendsCallbackInfoInternal : ICallbackInfoInternal, IGettable<QueryFriendsCallbackInfo>, ISettable<QueryFriendsCallbackInfo>, IDisposable // TypeDefIndex: 9628
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

	// RVA: 0x4FEE00 Offset: 0x4FE000 VA: 0x1804FEE00
	public object get_ClientData() { }

	// RVA: 0x4FEEF0 Offset: 0x4FE0F0 VA: 0x1804FEEF0
	public void set_ClientData(object value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x4FEE70 Offset: 0x4FE070 VA: 0x1804FEE70
	public EpicAccountId get_LocalUserId() { }

	// RVA: 0x4FEF50 Offset: 0x4FE150 VA: 0x1804FEF50
	public void set_LocalUserId(EpicAccountId value) { }

	// RVA: 0x4FED50 Offset: 0x4FDF50 VA: 0x1804FED50 Slot: 6
	public void Set(ref QueryFriendsCallbackInfo other) { }

	// RVA: 0x4FEC30 Offset: 0x4FDE30 VA: 0x1804FEC30 Slot: 7
	public void Set(ref Nullable<QueryFriendsCallbackInfo> other) { }

	// RVA: 0x4FEBB0 Offset: 0x4FDDB0 VA: 0x1804FEBB0 Slot: 8
	public void Dispose() { }

	// RVA: 0x4FEC10 Offset: 0x4FDE10 VA: 0x1804FEC10 Slot: 5
	public void Get(out QueryFriendsCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.Friends
public struct QueryFriendsOptions // TypeDefIndex: 9629
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

// Namespace: Epic.OnlineServices.Friends
internal struct QueryFriendsOptionsInternal : ISettable<QueryFriendsOptions>, IDisposable // TypeDefIndex: 9630
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8

	// Properties
	public EpicAccountId LocalUserId { set; }

	// Methods

	// RVA: 0x4FF1E0 Offset: 0x4FE3E0 VA: 0x1804FF1E0
	public void set_LocalUserId(EpicAccountId value) { }

	// RVA: 0x4FF0E0 Offset: 0x4FE2E0 VA: 0x1804FF0E0 Slot: 4
	public void Set(ref QueryFriendsOptions other) { }

	// RVA: 0x4FF140 Offset: 0x4FE340 VA: 0x1804FF140 Slot: 5
	public void Set(ref Nullable<QueryFriendsOptions> other) { }

	// RVA: 0x4FF090 Offset: 0x4FE290 VA: 0x1804FF090 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Friends
public struct RejectInviteCallbackInfo : ICallbackInfo // TypeDefIndex: 9631
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

	// RVA: 0x4FF7C0 Offset: 0x4FE9C0 VA: 0x1804FF7C0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x4FF810 Offset: 0x4FEA10 VA: 0x1804FF810
	internal void Set(ref RejectInviteCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.Friends
internal struct RejectInviteCallbackInfoInternal : ICallbackInfoInternal, IGettable<RejectInviteCallbackInfo>, ISettable<RejectInviteCallbackInfo>, IDisposable // TypeDefIndex: 9632
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

	// RVA: 0x4FF530 Offset: 0x4FE730 VA: 0x1804FF530
	public object get_ClientData() { }

	// RVA: 0x4FF6A0 Offset: 0x4FE8A0 VA: 0x1804FF6A0
	public void set_ClientData(object value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x4FF5A0 Offset: 0x4FE7A0 VA: 0x1804FF5A0
	public EpicAccountId get_LocalUserId() { }

	// RVA: 0x4FF700 Offset: 0x4FE900 VA: 0x1804FF700
	public void set_LocalUserId(EpicAccountId value) { }

	// RVA: 0x4FF620 Offset: 0x4FE820 VA: 0x1804FF620
	public EpicAccountId get_TargetUserId() { }

	// RVA: 0x4FF760 Offset: 0x4FE960 VA: 0x1804FF760
	public void set_TargetUserId(EpicAccountId value) { }

	// RVA: 0x4FF430 Offset: 0x4FE630 VA: 0x1804FF430 Slot: 6
	public void Set(ref RejectInviteCallbackInfo other) { }

	// RVA: 0x4FF2C0 Offset: 0x4FE4C0 VA: 0x1804FF2C0 Slot: 7
	public void Set(ref Nullable<RejectInviteCallbackInfo> other) { }

	// RVA: 0x4FF240 Offset: 0x4FE440 VA: 0x1804FF240 Slot: 8
	public void Dispose() { }

	// RVA: 0x4FF2A0 Offset: 0x4FE4A0 VA: 0x1804FF2A0 Slot: 5
	public void Get(out RejectInviteCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.Friends
public struct RejectInviteOptions // TypeDefIndex: 9633
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

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public EpicAccountId get_TargetUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_TargetUserId(EpicAccountId value) { }
}

// Namespace: Epic.OnlineServices.Friends
internal struct RejectInviteOptionsInternal : ISettable<RejectInviteOptions>, IDisposable // TypeDefIndex: 9634
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_TargetUserId; // 0x10

	// Properties
	public EpicAccountId LocalUserId { set; }
	public EpicAccountId TargetUserId { set; }

	// Methods

	// RVA: 0x4FFAD0 Offset: 0x4FECD0 VA: 0x1804FFAD0
	public void set_LocalUserId(EpicAccountId value) { }

	// RVA: 0x4FFB30 Offset: 0x4FED30 VA: 0x1804FFB30
	public void set_TargetUserId(EpicAccountId value) { }

	// RVA: 0x4FFA10 Offset: 0x4FEC10 VA: 0x1804FFA10 Slot: 4
	public void Set(ref RejectInviteOptions other) { }

	// RVA: 0x4FF910 Offset: 0x4FEB10 VA: 0x1804FF910 Slot: 5
	public void Set(ref Nullable<RejectInviteOptions> other) { }

	// RVA: 0x4FF8B0 Offset: 0x4FEAB0 VA: 0x1804FF8B0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Friends
public struct SendInviteCallbackInfo : ICallbackInfo // TypeDefIndex: 9635
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

	// RVA: 0x500110 Offset: 0x4FF310 VA: 0x180500110 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x500160 Offset: 0x4FF360 VA: 0x180500160
	internal void Set(ref SendInviteCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.Friends
internal struct SendInviteCallbackInfoInternal : ICallbackInfoInternal, IGettable<SendInviteCallbackInfo>, ISettable<SendInviteCallbackInfo>, IDisposable // TypeDefIndex: 9636
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

	// RVA: 0x4FFE80 Offset: 0x4FF080 VA: 0x1804FFE80
	public object get_ClientData() { }

	// RVA: 0x4FFFF0 Offset: 0x4FF1F0 VA: 0x1804FFFF0
	public void set_ClientData(object value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x4FFEF0 Offset: 0x4FF0F0 VA: 0x1804FFEF0
	public EpicAccountId get_LocalUserId() { }

	// RVA: 0x500050 Offset: 0x4FF250 VA: 0x180500050
	public void set_LocalUserId(EpicAccountId value) { }

	// RVA: 0x4FFF70 Offset: 0x4FF170 VA: 0x1804FFF70
	public EpicAccountId get_TargetUserId() { }

	// RVA: 0x5000B0 Offset: 0x4FF2B0 VA: 0x1805000B0
	public void set_TargetUserId(EpicAccountId value) { }

	// RVA: 0x4FFD80 Offset: 0x4FEF80 VA: 0x1804FFD80 Slot: 6
	public void Set(ref SendInviteCallbackInfo other) { }

	// RVA: 0x4FFC10 Offset: 0x4FEE10 VA: 0x1804FFC10 Slot: 7
	public void Set(ref Nullable<SendInviteCallbackInfo> other) { }

	// RVA: 0x4FFB90 Offset: 0x4FED90 VA: 0x1804FFB90 Slot: 8
	public void Dispose() { }

	// RVA: 0x4FFBF0 Offset: 0x4FEDF0 VA: 0x1804FFBF0 Slot: 5
	public void Get(out SendInviteCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.Friends
public struct SendInviteOptions // TypeDefIndex: 9637
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

// Namespace: Epic.OnlineServices.Friends
internal struct SendInviteOptionsInternal : ISettable<SendInviteOptions>, IDisposable // TypeDefIndex: 9638
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_TargetUserId; // 0x10

	// Properties
	public EpicAccountId LocalUserId { set; }
	public EpicAccountId TargetUserId { set; }

	// Methods

	// RVA: 0x500420 Offset: 0x4FF620 VA: 0x180500420
	public void set_LocalUserId(EpicAccountId value) { }

	// RVA: 0x500480 Offset: 0x4FF680 VA: 0x180500480
	public void set_TargetUserId(EpicAccountId value) { }

	// RVA: 0x500260 Offset: 0x4FF460 VA: 0x180500260 Slot: 4
	public void Set(ref SendInviteOptions other) { }

	// RVA: 0x500320 Offset: 0x4FF520 VA: 0x180500320 Slot: 5
	public void Set(ref Nullable<SendInviteOptions> other) { }

	// RVA: 0x500200 Offset: 0x4FF400 VA: 0x180500200 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Ecom
public struct CatalogItem // TypeDefIndex: 9639
{
	// Fields
	[CompilerGenerated]
	private Utf8String <CatalogNamespace>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <Id>k__BackingField; // 0x8
	[CompilerGenerated]
	private Utf8String <EntitlementName>k__BackingField; // 0x10
	[CompilerGenerated]
	private Utf8String <TitleText>k__BackingField; // 0x18
	[CompilerGenerated]
	private Utf8String <DescriptionText>k__BackingField; // 0x20
	[CompilerGenerated]
	private Utf8String <LongDescriptionText>k__BackingField; // 0x28
	[CompilerGenerated]
	private Utf8String <TechnicalDetailsText>k__BackingField; // 0x30
	[CompilerGenerated]
	private Utf8String <DeveloperText>k__BackingField; // 0x38
	[CompilerGenerated]
	private EcomItemType <ItemType>k__BackingField; // 0x40
	[CompilerGenerated]
	private long <EntitlementEndTimestamp>k__BackingField; // 0x48

	// Properties
	public Utf8String CatalogNamespace { get; set; }
	public Utf8String Id { get; set; }
	public Utf8String EntitlementName { get; set; }
	public Utf8String TitleText { get; set; }
	public Utf8String DescriptionText { get; set; }
	public Utf8String LongDescriptionText { get; set; }
	public Utf8String TechnicalDetailsText { get; set; }
	public Utf8String DeveloperText { get; set; }
	public EcomItemType ItemType { get; set; }
	public long EntitlementEndTimestamp { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Utf8String get_CatalogNamespace() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_CatalogNamespace(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public Utf8String get_Id() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_Id(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Utf8String get_EntitlementName() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_EntitlementName(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public Utf8String get_TitleText() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_TitleText(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public Utf8String get_DescriptionText() { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_DescriptionText(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public Utf8String get_LongDescriptionText() { }

	[CompilerGenerated]
	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	public void set_LongDescriptionText(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public Utf8String get_TechnicalDetailsText() { }

	[CompilerGenerated]
	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	public void set_TechnicalDetailsText(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public Utf8String get_DeveloperText() { }

	[CompilerGenerated]
	// RVA: 0x40EC50 Offset: 0x40DE50 VA: 0x18040EC50
	public void set_DeveloperText(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x433440 Offset: 0x432640 VA: 0x180433440
	public EcomItemType get_ItemType() { }

	[CompilerGenerated]
	// RVA: 0x433450 Offset: 0x432650 VA: 0x180433450
	public void set_ItemType(EcomItemType value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0
	public long get_EntitlementEndTimestamp() { }

	[CompilerGenerated]
	// RVA: 0x41A200 Offset: 0x419400 VA: 0x18041A200
	public void set_EntitlementEndTimestamp(long value) { }

	// RVA: 0x4ECDA0 Offset: 0x4EBFA0 VA: 0x1804ECDA0
	internal void Set(ref CatalogItemInternal other) { }
}

// Namespace: Epic.OnlineServices.Ecom
internal struct CatalogItemInternal : IGettable<CatalogItem>, ISettable<CatalogItem>, IDisposable // TypeDefIndex: 9640
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_CatalogNamespace; // 0x8
	private IntPtr m_Id; // 0x10
	private IntPtr m_EntitlementName; // 0x18
	private IntPtr m_TitleText; // 0x20
	private IntPtr m_DescriptionText; // 0x28
	private IntPtr m_LongDescriptionText; // 0x30
	private IntPtr m_TechnicalDetailsText; // 0x38
	private IntPtr m_DeveloperText; // 0x40
	private EcomItemType m_ItemType; // 0x48
	private long m_EntitlementEndTimestamp; // 0x50

	// Properties
	public Utf8String CatalogNamespace { get; set; }
	public Utf8String Id { get; set; }
	public Utf8String EntitlementName { get; set; }
	public Utf8String TitleText { get; set; }
	public Utf8String DescriptionText { get; set; }
	public Utf8String LongDescriptionText { get; set; }
	public Utf8String TechnicalDetailsText { get; set; }
	public Utf8String DeveloperText { get; set; }
	public EcomItemType ItemType { get; set; }
	public long EntitlementEndTimestamp { get; set; }

	// Methods

	// RVA: 0x4EC720 Offset: 0x4EB920 VA: 0x1804EC720
	public Utf8String get_CatalogNamespace() { }

	// RVA: 0x4ECAA0 Offset: 0x4EBCA0 VA: 0x1804ECAA0
	public void set_CatalogNamespace(Utf8String value) { }

	// RVA: 0x4EC8E0 Offset: 0x4EBAE0 VA: 0x1804EC8E0
	public Utf8String get_Id() { }

	// RVA: 0x4ECC20 Offset: 0x4EBE20 VA: 0x1804ECC20
	public void set_Id(Utf8String value) { }

	// RVA: 0x4EC870 Offset: 0x4EBA70 VA: 0x1804EC870
	public Utf8String get_EntitlementName() { }

	// RVA: 0x4ECBC0 Offset: 0x4EBDC0 VA: 0x1804ECBC0
	public void set_EntitlementName(Utf8String value) { }

	// RVA: 0x4ECA30 Offset: 0x4EBC30 VA: 0x1804ECA30
	public Utf8String get_TitleText() { }

	// RVA: 0x4ECD40 Offset: 0x4EBF40 VA: 0x1804ECD40
	public void set_TitleText(Utf8String value) { }

	// RVA: 0x4EC790 Offset: 0x4EB990 VA: 0x1804EC790
	public Utf8String get_DescriptionText() { }

	// RVA: 0x4ECB00 Offset: 0x4EBD00 VA: 0x1804ECB00
	public void set_DescriptionText(Utf8String value) { }

	// RVA: 0x4EC950 Offset: 0x4EBB50 VA: 0x1804EC950
	public Utf8String get_LongDescriptionText() { }

	// RVA: 0x4ECC80 Offset: 0x4EBE80 VA: 0x1804ECC80
	public void set_LongDescriptionText(Utf8String value) { }

	// RVA: 0x4EC9C0 Offset: 0x4EBBC0 VA: 0x1804EC9C0
	public Utf8String get_TechnicalDetailsText() { }

	// RVA: 0x4ECCE0 Offset: 0x4EBEE0 VA: 0x1804ECCE0
	public void set_TechnicalDetailsText(Utf8String value) { }

	// RVA: 0x4EC800 Offset: 0x4EBA00 VA: 0x1804EC800
	public Utf8String get_DeveloperText() { }

	// RVA: 0x4ECB60 Offset: 0x4EBD60 VA: 0x1804ECB60
	public void set_DeveloperText(Utf8String value) { }

	// RVA: 0x4193D0 Offset: 0x4185D0 VA: 0x1804193D0
	public EcomItemType get_ItemType() { }

	// RVA: 0x419410 Offset: 0x418610 VA: 0x180419410
	public void set_ItemType(EcomItemType value) { }

	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0
	public long get_EntitlementEndTimestamp() { }

	// RVA: 0x4050C0 Offset: 0x4042C0 VA: 0x1804050C0
	public void set_EntitlementEndTimestamp(long value) { }

	// RVA: 0x4EC180 Offset: 0x4EB380 VA: 0x1804EC180 Slot: 5
	public void Set(ref CatalogItem other) { }

	// RVA: 0x4EC3E0 Offset: 0x4EB5E0 VA: 0x1804EC3E0 Slot: 6
	public void Set(ref Nullable<CatalogItem> other) { }

	// RVA: 0x4EC0B0 Offset: 0x4EB2B0 VA: 0x1804EC0B0 Slot: 7
	public void Dispose() { }

	// RVA: 0x4EC150 Offset: 0x4EB350 VA: 0x1804EC150 Slot: 4
	public void Get(out CatalogItem output) { }
}

// Namespace: Epic.OnlineServices.Ecom
public struct CatalogOffer // TypeDefIndex: 9641
{
	// Fields
	[CompilerGenerated]
	private int <ServerIndex>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <CatalogNamespace>k__BackingField; // 0x8
	[CompilerGenerated]
	private Utf8String <Id>k__BackingField; // 0x10
	[CompilerGenerated]
	private Utf8String <TitleText>k__BackingField; // 0x18
	[CompilerGenerated]
	private Utf8String <DescriptionText>k__BackingField; // 0x20
	[CompilerGenerated]
	private Utf8String <LongDescriptionText>k__BackingField; // 0x28
	[CompilerGenerated]
	private Utf8String <TechnicalDetailsText_DEPRECATED>k__BackingField; // 0x30
	[CompilerGenerated]
	private Utf8String <CurrencyCode>k__BackingField; // 0x38
	[CompilerGenerated]
	private Result <PriceResult>k__BackingField; // 0x40
	[CompilerGenerated]
	private uint <OriginalPrice_DEPRECATED>k__BackingField; // 0x44
	[CompilerGenerated]
	private uint <CurrentPrice_DEPRECATED>k__BackingField; // 0x48
	[CompilerGenerated]
	private byte <DiscountPercentage>k__BackingField; // 0x4C
	[CompilerGenerated]
	private long <ExpirationTimestamp>k__BackingField; // 0x50
	[CompilerGenerated]
	private uint <PurchasedCount_DEPRECATED>k__BackingField; // 0x58
	[CompilerGenerated]
	private int <PurchaseLimit>k__BackingField; // 0x5C
	[CompilerGenerated]
	private bool <AvailableForPurchase>k__BackingField; // 0x60
	[CompilerGenerated]
	private ulong <OriginalPrice64>k__BackingField; // 0x68
	[CompilerGenerated]
	private ulong <CurrentPrice64>k__BackingField; // 0x70
	[CompilerGenerated]
	private uint <DecimalPoint>k__BackingField; // 0x78
	[CompilerGenerated]
	private long <ReleaseDateTimestamp>k__BackingField; // 0x80
	[CompilerGenerated]
	private long <EffectiveDateTimestamp>k__BackingField; // 0x88

	// Properties
	public int ServerIndex { get; set; }
	public Utf8String CatalogNamespace { get; set; }
	public Utf8String Id { get; set; }
	public Utf8String TitleText { get; set; }
	public Utf8String DescriptionText { get; set; }
	public Utf8String LongDescriptionText { get; set; }
	internal Utf8String TechnicalDetailsText_DEPRECATED { get; set; }
	public Utf8String CurrencyCode { get; set; }
	public Result PriceResult { get; set; }
	internal uint OriginalPrice_DEPRECATED { get; set; }
	internal uint CurrentPrice_DEPRECATED { get; set; }
	public byte DiscountPercentage { get; set; }
	public long ExpirationTimestamp { get; set; }
	internal uint PurchasedCount_DEPRECATED { get; set; }
	public int PurchaseLimit { get; set; }
	public bool AvailableForPurchase { get; set; }
	public ulong OriginalPrice64 { get; set; }
	public ulong CurrentPrice64 { get; set; }
	public uint DecimalPoint { get; set; }
	public long ReleaseDateTimestamp { get; set; }
	public long EffectiveDateTimestamp { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public int get_ServerIndex() { }

	[CompilerGenerated]
	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ServerIndex(int value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public Utf8String get_CatalogNamespace() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_CatalogNamespace(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Utf8String get_Id() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_Id(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public Utf8String get_TitleText() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_TitleText(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public Utf8String get_DescriptionText() { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_DescriptionText(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public Utf8String get_LongDescriptionText() { }

	[CompilerGenerated]
	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	public void set_LongDescriptionText(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	internal Utf8String get_TechnicalDetailsText_DEPRECATED() { }

	[CompilerGenerated]
	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	internal void set_TechnicalDetailsText_DEPRECATED(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public Utf8String get_CurrencyCode() { }

	[CompilerGenerated]
	// RVA: 0x40EC50 Offset: 0x40DE50 VA: 0x18040EC50
	public void set_CurrencyCode(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x433440 Offset: 0x432640 VA: 0x180433440
	public Result get_PriceResult() { }

	[CompilerGenerated]
	// RVA: 0x433450 Offset: 0x432650 VA: 0x180433450
	public void set_PriceResult(Result value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x4AB2B0 Offset: 0x4AA4B0 VA: 0x1804AB2B0
	internal uint get_OriginalPrice_DEPRECATED() { }

	[CompilerGenerated]
	// RVA: 0x4AB2C0 Offset: 0x4AA4C0 VA: 0x1804AB2C0
	internal void set_OriginalPrice_DEPRECATED(uint value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x4193D0 Offset: 0x4185D0 VA: 0x1804193D0
	internal uint get_CurrentPrice_DEPRECATED() { }

	[CompilerGenerated]
	// RVA: 0x419410 Offset: 0x418610 VA: 0x180419410
	internal void set_CurrentPrice_DEPRECATED(uint value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x4EDA10 Offset: 0x4ECC10 VA: 0x1804EDA10
	public byte get_DiscountPercentage() { }

	[CompilerGenerated]
	// RVA: 0x4EDDB0 Offset: 0x4ECFB0 VA: 0x1804EDDB0
	public void set_DiscountPercentage(byte value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0
	public long get_ExpirationTimestamp() { }

	[CompilerGenerated]
	// RVA: 0x4050C0 Offset: 0x4042C0 VA: 0x1804050C0
	public void set_ExpirationTimestamp(long value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x4EDB20 Offset: 0x4ECD20 VA: 0x1804EDB20
	internal uint get_PurchasedCount_DEPRECATED() { }

	[CompilerGenerated]
	// RVA: 0x4EDEA0 Offset: 0x4ED0A0 VA: 0x1804EDEA0
	internal void set_PurchasedCount_DEPRECATED(uint value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x4EDB10 Offset: 0x4ECD10 VA: 0x1804EDB10
	public int get_PurchaseLimit() { }

	[CompilerGenerated]
	// RVA: 0x4EDE90 Offset: 0x4ED090 VA: 0x1804EDE90
	public void set_PurchaseLimit(int value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x4EE290 Offset: 0x4ED490 VA: 0x1804EE290
	public bool get_AvailableForPurchase() { }

	[CompilerGenerated]
	// RVA: 0x4EE2A0 Offset: 0x4ED4A0 VA: 0x1804EE2A0
	public void set_AvailableForPurchase(bool value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x4EDB00 Offset: 0x4ECD00 VA: 0x1804EDB00
	public ulong get_OriginalPrice64() { }

	[CompilerGenerated]
	// RVA: 0x4EDE80 Offset: 0x4ED080 VA: 0x1804EDE80
	public void set_OriginalPrice64(ulong value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x4ED980 Offset: 0x4ECB80 VA: 0x1804ED980
	public ulong get_CurrentPrice64() { }

	[CompilerGenerated]
	// RVA: 0x4EDD30 Offset: 0x4ECF30 VA: 0x1804EDD30
	public void set_CurrentPrice64(ulong value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x4ED990 Offset: 0x4ECB90 VA: 0x1804ED990
	public uint get_DecimalPoint() { }

	[CompilerGenerated]
	// RVA: 0x4EDD40 Offset: 0x4ECF40 VA: 0x1804EDD40
	public void set_DecimalPoint(uint value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x42D830 Offset: 0x42CA30 VA: 0x18042D830
	public long get_ReleaseDateTimestamp() { }

	[CompilerGenerated]
	// RVA: 0x42D780 Offset: 0x42C980 VA: 0x18042D780
	public void set_ReleaseDateTimestamp(long value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x42D870 Offset: 0x42CA70 VA: 0x18042D870
	public long get_EffectiveDateTimestamp() { }

	[CompilerGenerated]
	// RVA: 0x42D8E0 Offset: 0x42CAE0 VA: 0x18042D8E0
	public void set_EffectiveDateTimestamp(long value) { }

	// RVA: 0x4EDF70 Offset: 0x4ED170 VA: 0x1804EDF70
	internal void Set(ref CatalogOfferInternal other) { }
}

// Namespace: Epic.OnlineServices.Ecom
internal struct CatalogOfferInternal : IGettable<CatalogOffer>, ISettable<CatalogOffer>, IDisposable // TypeDefIndex: 9642
{
	// Fields
	private int m_ApiVersion; // 0x0
	private int m_ServerIndex; // 0x4
	private IntPtr m_CatalogNamespace; // 0x8
	private IntPtr m_Id; // 0x10
	private IntPtr m_TitleText; // 0x18
	private IntPtr m_DescriptionText; // 0x20
	private IntPtr m_LongDescriptionText; // 0x28
	private IntPtr m_TechnicalDetailsText_DEPRECATED; // 0x30
	private IntPtr m_CurrencyCode; // 0x38
	private Result m_PriceResult; // 0x40
	private uint m_OriginalPrice_DEPRECATED; // 0x44
	private uint m_CurrentPrice_DEPRECATED; // 0x48
	private byte m_DiscountPercentage; // 0x4C
	private long m_ExpirationTimestamp; // 0x50
	private uint m_PurchasedCount_DEPRECATED; // 0x58
	private int m_PurchaseLimit; // 0x5C
	private int m_AvailableForPurchase; // 0x60
	private ulong m_OriginalPrice64; // 0x68
	private ulong m_CurrentPrice64; // 0x70
	private uint m_DecimalPoint; // 0x78
	private long m_ReleaseDateTimestamp; // 0x80
	private long m_EffectiveDateTimestamp; // 0x88

	// Properties
	public int ServerIndex { get; set; }
	public Utf8String CatalogNamespace { get; set; }
	public Utf8String Id { get; set; }
	public Utf8String TitleText { get; set; }
	public Utf8String DescriptionText { get; set; }
	public Utf8String LongDescriptionText { get; set; }
	public Utf8String TechnicalDetailsText_DEPRECATED { get; set; }
	public Utf8String CurrencyCode { get; set; }
	public Result PriceResult { get; set; }
	public uint OriginalPrice_DEPRECATED { get; set; }
	public uint CurrentPrice_DEPRECATED { get; set; }
	public byte DiscountPercentage { get; set; }
	public long ExpirationTimestamp { get; set; }
	public uint PurchasedCount_DEPRECATED { get; set; }
	public int PurchaseLimit { get; set; }
	public bool AvailableForPurchase { get; set; }
	public ulong OriginalPrice64 { get; set; }
	public ulong CurrentPrice64 { get; set; }
	public uint DecimalPoint { get; set; }
	public long ReleaseDateTimestamp { get; set; }
	public long EffectiveDateTimestamp { get; set; }

	// Methods

	// RVA: 0x3F8350 Offset: 0x3F7550 VA: 0x1803F8350
	public int get_ServerIndex() { }

	// RVA: 0x3F84A0 Offset: 0x3F76A0 VA: 0x1803F84A0
	public void set_ServerIndex(int value) { }

	// RVA: 0x4ED8A0 Offset: 0x4ECAA0 VA: 0x1804ED8A0
	public Utf8String get_CatalogNamespace() { }

	// RVA: 0x4EDC70 Offset: 0x4ECE70 VA: 0x1804EDC70
	public void set_CatalogNamespace(Utf8String value) { }

	// RVA: 0x4EDA20 Offset: 0x4ECC20 VA: 0x1804EDA20
	public Utf8String get_Id() { }

	// RVA: 0x4EDDC0 Offset: 0x4ECFC0 VA: 0x1804EDDC0
	public void set_Id(Utf8String value) { }

	// RVA: 0x4EDBA0 Offset: 0x4ECDA0 VA: 0x1804EDBA0
	public Utf8String get_TitleText() { }

	// RVA: 0x4EDF10 Offset: 0x4ED110 VA: 0x1804EDF10
	public void set_TitleText(Utf8String value) { }

	// RVA: 0x4ED9A0 Offset: 0x4ECBA0 VA: 0x1804ED9A0
	public Utf8String get_DescriptionText() { }

	// RVA: 0x4EDD50 Offset: 0x4ECF50 VA: 0x1804EDD50
	public void set_DescriptionText(Utf8String value) { }

	// RVA: 0x4EDA90 Offset: 0x4ECC90 VA: 0x1804EDA90
	public Utf8String get_LongDescriptionText() { }

	// RVA: 0x4EDE20 Offset: 0x4ED020 VA: 0x1804EDE20
	public void set_LongDescriptionText(Utf8String value) { }

	// RVA: 0x4EDB30 Offset: 0x4ECD30 VA: 0x1804EDB30
	public Utf8String get_TechnicalDetailsText_DEPRECATED() { }

	// RVA: 0x4EDEB0 Offset: 0x4ED0B0 VA: 0x1804EDEB0
	public void set_TechnicalDetailsText_DEPRECATED(Utf8String value) { }

	// RVA: 0x4ED910 Offset: 0x4ECB10 VA: 0x1804ED910
	public Utf8String get_CurrencyCode() { }

	// RVA: 0x4EDCD0 Offset: 0x4ECED0 VA: 0x1804EDCD0
	public void set_CurrencyCode(Utf8String value) { }

	// RVA: 0x433440 Offset: 0x432640 VA: 0x180433440
	public Result get_PriceResult() { }

	// RVA: 0x433450 Offset: 0x432650 VA: 0x180433450
	public void set_PriceResult(Result value) { }

	// RVA: 0x4AB2B0 Offset: 0x4AA4B0 VA: 0x1804AB2B0
	public uint get_OriginalPrice_DEPRECATED() { }

	// RVA: 0x4AB2C0 Offset: 0x4AA4C0 VA: 0x1804AB2C0
	public void set_OriginalPrice_DEPRECATED(uint value) { }

	// RVA: 0x4193D0 Offset: 0x4185D0 VA: 0x1804193D0
	public uint get_CurrentPrice_DEPRECATED() { }

	// RVA: 0x419410 Offset: 0x418610 VA: 0x180419410
	public void set_CurrentPrice_DEPRECATED(uint value) { }

	// RVA: 0x4EDA10 Offset: 0x4ECC10 VA: 0x1804EDA10
	public byte get_DiscountPercentage() { }

	// RVA: 0x4EDDB0 Offset: 0x4ECFB0 VA: 0x1804EDDB0
	public void set_DiscountPercentage(byte value) { }

	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0
	public long get_ExpirationTimestamp() { }

	// RVA: 0x4050C0 Offset: 0x4042C0 VA: 0x1804050C0
	public void set_ExpirationTimestamp(long value) { }

	// RVA: 0x4EDB20 Offset: 0x4ECD20 VA: 0x1804EDB20
	public uint get_PurchasedCount_DEPRECATED() { }

	// RVA: 0x4EDEA0 Offset: 0x4ED0A0 VA: 0x1804EDEA0
	public void set_PurchasedCount_DEPRECATED(uint value) { }

	// RVA: 0x4EDB10 Offset: 0x4ECD10 VA: 0x1804EDB10
	public int get_PurchaseLimit() { }

	// RVA: 0x4EDE90 Offset: 0x4ED090 VA: 0x1804EDE90
	public void set_PurchaseLimit(int value) { }

	// RVA: 0x4ED840 Offset: 0x4ECA40 VA: 0x1804ED840
	public bool get_AvailableForPurchase() { }

	// RVA: 0x4EDC10 Offset: 0x4ECE10 VA: 0x1804EDC10
	public void set_AvailableForPurchase(bool value) { }

	// RVA: 0x4EDB00 Offset: 0x4ECD00 VA: 0x1804EDB00
	public ulong get_OriginalPrice64() { }

	// RVA: 0x4EDE80 Offset: 0x4ED080 VA: 0x1804EDE80
	public void set_OriginalPrice64(ulong value) { }

	// RVA: 0x4ED980 Offset: 0x4ECB80 VA: 0x1804ED980
	public ulong get_CurrentPrice64() { }

	// RVA: 0x4EDD30 Offset: 0x4ECF30 VA: 0x1804EDD30
	public void set_CurrentPrice64(ulong value) { }

	// RVA: 0x4ED990 Offset: 0x4ECB90 VA: 0x1804ED990
	public uint get_DecimalPoint() { }

	// RVA: 0x4EDD40 Offset: 0x4ECF40 VA: 0x1804EDD40
	public void set_DecimalPoint(uint value) { }

	// RVA: 0x42D830 Offset: 0x42CA30 VA: 0x18042D830
	public long get_ReleaseDateTimestamp() { }

	// RVA: 0x42D780 Offset: 0x42C980 VA: 0x18042D780
	public void set_ReleaseDateTimestamp(long value) { }

	// RVA: 0x42D870 Offset: 0x42CA70 VA: 0x18042D870
	public long get_EffectiveDateTimestamp() { }

	// RVA: 0x42D8E0 Offset: 0x42CAE0 VA: 0x18042D8E0
	public void set_EffectiveDateTimestamp(long value) { }

	// RVA: 0x4ED130 Offset: 0x4EC330 VA: 0x1804ED130 Slot: 5
	public void Set(ref CatalogOffer other) { }

	// RVA: 0x4ED3E0 Offset: 0x4EC5E0 VA: 0x1804ED3E0 Slot: 6
	public void Set(ref Nullable<CatalogOffer> other) { }

	// RVA: 0x4ED060 Offset: 0x4EC260 VA: 0x1804ED060 Slot: 7
	public void Dispose() { }

	// RVA: 0x4ED0F0 Offset: 0x4EC2F0 VA: 0x1804ED0F0 Slot: 4
	public void Get(out CatalogOffer output) { }
}

// Namespace: Epic.OnlineServices.Ecom
public struct CatalogRelease // TypeDefIndex: 9643
{
	// Fields
	[CompilerGenerated]
	private Utf8String[] <CompatibleAppIds>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String[] <CompatiblePlatforms>k__BackingField; // 0x8
	[CompilerGenerated]
	private Utf8String <ReleaseNote>k__BackingField; // 0x10

	// Properties
	public Utf8String[] CompatibleAppIds { get; set; }
	public Utf8String[] CompatiblePlatforms { get; set; }
	public Utf8String ReleaseNote { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Utf8String[] get_CompatibleAppIds() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_CompatibleAppIds(Utf8String[] value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public Utf8String[] get_CompatiblePlatforms() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_CompatiblePlatforms(Utf8String[] value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Utf8String get_ReleaseNote() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_ReleaseNote(Utf8String value) { }

	// RVA: 0x4EE790 Offset: 0x4ED990 VA: 0x1804EE790
	internal void Set(ref CatalogReleaseInternal other) { }
}

// Namespace: Epic.OnlineServices.Ecom
internal struct CatalogReleaseInternal : IGettable<CatalogRelease>, ISettable<CatalogRelease>, IDisposable // TypeDefIndex: 9644
{
	// Fields
	private int m_ApiVersion; // 0x0
	private uint m_CompatibleAppIdCount; // 0x4
	private IntPtr m_CompatibleAppIds; // 0x8
	private uint m_CompatiblePlatformCount; // 0x10
	private IntPtr m_CompatiblePlatforms; // 0x18
	private IntPtr m_ReleaseNote; // 0x20

	// Properties
	public Utf8String[] CompatibleAppIds { get; set; }
	public Utf8String[] CompatiblePlatforms { get; set; }
	public Utf8String ReleaseNote { get; set; }

	// Methods

	// RVA: 0x4EE4A0 Offset: 0x4ED6A0 VA: 0x1804EE4A0
	public Utf8String[] get_CompatibleAppIds() { }

	// RVA: 0x4EE630 Offset: 0x4ED830 VA: 0x1804EE630
	public void set_CompatibleAppIds(Utf8String[] value) { }

	// RVA: 0x4EE530 Offset: 0x4ED730 VA: 0x1804EE530
	public Utf8String[] get_CompatiblePlatforms() { }

	// RVA: 0x4EE6B0 Offset: 0x4ED8B0 VA: 0x1804EE6B0
	public void set_CompatiblePlatforms(Utf8String[] value) { }

	// RVA: 0x4EE5C0 Offset: 0x4ED7C0 VA: 0x1804EE5C0
	public Utf8String get_ReleaseNote() { }

	// RVA: 0x4EE730 Offset: 0x4ED930 VA: 0x1804EE730
	public void set_ReleaseNote(Utf8String value) { }

	// RVA: 0x4EE420 Offset: 0x4ED620 VA: 0x1804EE420 Slot: 5
	public void Set(ref CatalogRelease other) { }

	// RVA: 0x4EE330 Offset: 0x4ED530 VA: 0x1804EE330 Slot: 6
	public void Set(ref Nullable<CatalogRelease> other) { }

	// RVA: 0x4EE2B0 Offset: 0x4ED4B0 VA: 0x1804EE2B0 Slot: 7
	public void Dispose() { }

	// RVA: 0x4EE310 Offset: 0x4ED510 VA: 0x1804EE310 Slot: 4
	public void Get(out CatalogRelease output) { }
}

// Namespace: Epic.OnlineServices.Ecom
public struct CheckoutCallbackInfo : ICallbackInfo // TypeDefIndex: 9645
{
	// Fields
	[CompilerGenerated]
	private Result <ResultCode>k__BackingField; // 0x0
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x8
	[CompilerGenerated]
	private EpicAccountId <LocalUserId>k__BackingField; // 0x10
	[CompilerGenerated]
	private Utf8String <TransactionId>k__BackingField; // 0x18

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public EpicAccountId LocalUserId { get; set; }
	public Utf8String TransactionId { get; set; }

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

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public Utf8String get_TransactionId() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_TransactionId(Utf8String value) { }

	// RVA: 0x4EED90 Offset: 0x4EDF90 VA: 0x1804EED90 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x4EEDE0 Offset: 0x4EDFE0 VA: 0x1804EEDE0
	internal void Set(ref CheckoutCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.Ecom
internal struct CheckoutCallbackInfoInternal : ICallbackInfoInternal, IGettable<CheckoutCallbackInfo>, ISettable<CheckoutCallbackInfo>, IDisposable // TypeDefIndex: 9646
{
	// Fields
	private Result m_ResultCode; // 0x0
	private IntPtr m_ClientData; // 0x8
	private IntPtr m_LocalUserId; // 0x10
	private IntPtr m_TransactionId; // 0x18

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public EpicAccountId LocalUserId { get; set; }
	public Utf8String TransactionId { get; set; }

	// Methods

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	// RVA: 0x4EEB10 Offset: 0x4EDD10 VA: 0x1804EEB10
	public object get_ClientData() { }

	// RVA: 0x4EEC70 Offset: 0x4EDE70 VA: 0x1804EEC70
	public void set_ClientData(object value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x4EEB80 Offset: 0x4EDD80 VA: 0x1804EEB80
	public EpicAccountId get_LocalUserId() { }

	// RVA: 0x4EECD0 Offset: 0x4EDED0 VA: 0x1804EECD0
	public void set_LocalUserId(EpicAccountId value) { }

	// RVA: 0x4EEC00 Offset: 0x4EDE00 VA: 0x1804EEC00
	public Utf8String get_TransactionId() { }

	// RVA: 0x4EED30 Offset: 0x4EDF30 VA: 0x1804EED30
	public void set_TransactionId(Utf8String value) { }

	// RVA: 0x4EEA10 Offset: 0x4EDC10 VA: 0x1804EEA10 Slot: 6
	public void Set(ref CheckoutCallbackInfo other) { }

	// RVA: 0x4EE8A0 Offset: 0x4EDAA0 VA: 0x1804EE8A0 Slot: 7
	public void Set(ref Nullable<CheckoutCallbackInfo> other) { }

	// RVA: 0x4EE820 Offset: 0x4EDA20 VA: 0x1804EE820 Slot: 8
	public void Dispose() { }

	// RVA: 0x4EE880 Offset: 0x4EDA80 VA: 0x1804EE880 Slot: 5
	public void Get(out CheckoutCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.Ecom
public struct CheckoutEntry // TypeDefIndex: 9647
{
	// Fields
	[CompilerGenerated]
	private Utf8String <OfferId>k__BackingField; // 0x0

	// Properties
	public Utf8String OfferId { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Utf8String get_OfferId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_OfferId(Utf8String value) { }

	// RVA: 0x4EF110 Offset: 0x4EE310 VA: 0x1804EF110
	internal void Set(ref CheckoutEntryInternal other) { }
}

// Namespace: Epic.OnlineServices.Ecom
internal struct CheckoutEntryInternal : IGettable<CheckoutEntry>, ISettable<CheckoutEntry>, IDisposable // TypeDefIndex: 9648
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_OfferId; // 0x8

	// Properties
	public Utf8String OfferId { get; set; }

	// Methods

	// RVA: 0x4EF040 Offset: 0x4EE240 VA: 0x1804EF040
	public Utf8String get_OfferId() { }

	// RVA: 0x4EF0B0 Offset: 0x4EE2B0 VA: 0x1804EF0B0
	public void set_OfferId(Utf8String value) { }

	// RVA: 0x4EEF40 Offset: 0x4EE140 VA: 0x1804EEF40 Slot: 5
	public void Set(ref CheckoutEntry other) { }

	// RVA: 0x4EEFA0 Offset: 0x4EE1A0 VA: 0x1804EEFA0 Slot: 6
	public void Set(ref Nullable<CheckoutEntry> other) { }

	// RVA: 0x4EEED0 Offset: 0x4EE0D0 VA: 0x1804EEED0 Slot: 7
	public void Dispose() { }

	// RVA: 0x4EEF20 Offset: 0x4EE120 VA: 0x1804EEF20 Slot: 4
	public void Get(out CheckoutEntry output) { }
}

// Namespace: Epic.OnlineServices.Ecom
public struct CheckoutOptions // TypeDefIndex: 9649
{
	// Fields
	[CompilerGenerated]
	private EpicAccountId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <OverrideCatalogNamespace>k__BackingField; // 0x8
	[CompilerGenerated]
	private CheckoutEntry[] <Entries>k__BackingField; // 0x10

	// Properties
	public EpicAccountId LocalUserId { get; set; }
	public Utf8String OverrideCatalogNamespace { get; set; }
	public CheckoutEntry[] Entries { get; set; }

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
	public Utf8String get_OverrideCatalogNamespace() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_OverrideCatalogNamespace(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public CheckoutEntry[] get_Entries() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_Entries(CheckoutEntry[] value) { }
}

// Namespace: Epic.OnlineServices.Ecom
internal struct CheckoutOptionsInternal : ISettable<CheckoutOptions>, IDisposable // TypeDefIndex: 9650
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_OverrideCatalogNamespace; // 0x10
	private uint m_EntryCount; // 0x18
	private IntPtr m_Entries; // 0x20

	// Properties
	public EpicAccountId LocalUserId { set; }
	public Utf8String OverrideCatalogNamespace { set; }
	public CheckoutEntry[] Entries { set; }

	// Methods

	// RVA: 0x4EF4B0 Offset: 0x4EE6B0 VA: 0x1804EF4B0
	public void set_LocalUserId(EpicAccountId value) { }

	// RVA: 0x4EF510 Offset: 0x4EE710 VA: 0x1804EF510
	public void set_OverrideCatalogNamespace(Utf8String value) { }

	// RVA: 0x4EF440 Offset: 0x4EE640 VA: 0x1804EF440
	public void set_Entries(CheckoutEntry[] value) { }

	// RVA: 0x4EF320 Offset: 0x4EE520 VA: 0x1804EF320 Slot: 4
	public void Set(ref CheckoutOptions other) { }

	// RVA: 0x4EF1F0 Offset: 0x4EE3F0 VA: 0x1804EF1F0 Slot: 5
	public void Set(ref Nullable<CheckoutOptions> other) { }

	// RVA: 0x4EF190 Offset: 0x4EE390 VA: 0x1804EF190 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Ecom
public struct CopyEntitlementByIdOptions // TypeDefIndex: 9651
{
	// Fields
	[CompilerGenerated]
	private EpicAccountId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <EntitlementId>k__BackingField; // 0x8

	// Properties
	public EpicAccountId LocalUserId { get; set; }
	public Utf8String EntitlementId { get; set; }

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
	public Utf8String get_EntitlementId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_EntitlementId(Utf8String value) { }
}

// Namespace: Epic.OnlineServices.Ecom
internal struct CopyEntitlementByIdOptionsInternal : ISettable<CopyEntitlementByIdOptions>, IDisposable // TypeDefIndex: 9652
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_EntitlementId; // 0x10

	// Properties
	public EpicAccountId LocalUserId { set; }
	public Utf8String EntitlementId { set; }

	// Methods

	// RVA: 0x4EF840 Offset: 0x4EEA40 VA: 0x1804EF840
	public void set_LocalUserId(EpicAccountId value) { }

	// RVA: 0x4EF7E0 Offset: 0x4EE9E0 VA: 0x1804EF7E0
	public void set_EntitlementId(Utf8String value) { }

	// RVA: 0x4EF620 Offset: 0x4EE820 VA: 0x1804EF620 Slot: 4
	public void Set(ref CopyEntitlementByIdOptions other) { }

	// RVA: 0x4EF6E0 Offset: 0x4EE8E0 VA: 0x1804EF6E0 Slot: 5
	public void Set(ref Nullable<CopyEntitlementByIdOptions> other) { }

	// RVA: 0x4EF5C0 Offset: 0x4EE7C0 VA: 0x1804EF5C0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Ecom
public struct CopyEntitlementByIndexOptions // TypeDefIndex: 9653
{
	// Fields
	[CompilerGenerated]
	private EpicAccountId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private uint <EntitlementIndex>k__BackingField; // 0x8

	// Properties
	public EpicAccountId LocalUserId { get; set; }
	public uint EntitlementIndex { get; set; }

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
	// RVA: 0x3F5510 Offset: 0x3F4710 VA: 0x1803F5510
	public uint get_EntitlementIndex() { }

	[CompilerGenerated]
	// RVA: 0x3F5520 Offset: 0x3F4720 VA: 0x1803F5520
	public void set_EntitlementIndex(uint value) { }
}

// Namespace: Epic.OnlineServices.Ecom
internal struct CopyEntitlementByIndexOptionsInternal : ISettable<CopyEntitlementByIndexOptions>, IDisposable // TypeDefIndex: 9654
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private uint m_EntitlementIndex; // 0x10

	// Properties
	public EpicAccountId LocalUserId { set; }
	public uint EntitlementIndex { set; }

	// Methods

	// RVA: 0x4EFA30 Offset: 0x4EEC30 VA: 0x1804EFA30
	public void set_LocalUserId(EpicAccountId value) { }

	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_EntitlementIndex(uint value) { }

	// RVA: 0x4EF8F0 Offset: 0x4EEAF0 VA: 0x1804EF8F0 Slot: 4
	public void Set(ref CopyEntitlementByIndexOptions other) { }

	// RVA: 0x4EF970 Offset: 0x4EEB70 VA: 0x1804EF970 Slot: 5
	public void Set(ref Nullable<CopyEntitlementByIndexOptions> other) { }

	// RVA: 0x4EF8A0 Offset: 0x4EEAA0 VA: 0x1804EF8A0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Ecom
public struct CopyEntitlementByNameAndIndexOptions // TypeDefIndex: 9655
{
	// Fields
	[CompilerGenerated]
	private EpicAccountId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <EntitlementName>k__BackingField; // 0x8
	[CompilerGenerated]
	private uint <Index>k__BackingField; // 0x10

	// Properties
	public EpicAccountId LocalUserId { get; set; }
	public Utf8String EntitlementName { get; set; }
	public uint Index { get; set; }

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
	public Utf8String get_EntitlementName() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_EntitlementName(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public uint get_Index() { }

	[CompilerGenerated]
	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_Index(uint value) { }
}

// Namespace: Epic.OnlineServices.Ecom
internal struct CopyEntitlementByNameAndIndexOptionsInternal : ISettable<CopyEntitlementByNameAndIndexOptions>, IDisposable // TypeDefIndex: 9656
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_EntitlementName; // 0x10
	private uint m_Index; // 0x18

	// Properties
	public EpicAccountId LocalUserId { set; }
	public Utf8String EntitlementName { set; }
	public uint Index { set; }

	// Methods

	// RVA: 0x4EFD30 Offset: 0x4EEF30 VA: 0x1804EFD30
	public void set_LocalUserId(EpicAccountId value) { }

	// RVA: 0x4EFCD0 Offset: 0x4EEED0 VA: 0x1804EFCD0
	public void set_EntitlementName(Utf8String value) { }

	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	public void set_Index(uint value) { }

	// RVA: 0x4EFC10 Offset: 0x4EEE10 VA: 0x1804EFC10 Slot: 4
	public void Set(ref CopyEntitlementByNameAndIndexOptions other) { }

	// RVA: 0x4EFAF0 Offset: 0x4EECF0 VA: 0x1804EFAF0 Slot: 5
	public void Set(ref Nullable<CopyEntitlementByNameAndIndexOptions> other) { }

	// RVA: 0x4EFA90 Offset: 0x4EEC90 VA: 0x1804EFA90 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Ecom
public struct CopyItemByIdOptions // TypeDefIndex: 9657
{
	// Fields
	[CompilerGenerated]
	private EpicAccountId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <ItemId>k__BackingField; // 0x8

	// Properties
	public EpicAccountId LocalUserId { get; set; }
	public Utf8String ItemId { get; set; }

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
	public Utf8String get_ItemId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_ItemId(Utf8String value) { }
}

// Namespace: Epic.OnlineServices.Ecom
internal struct CopyItemByIdOptionsInternal : ISettable<CopyItemByIdOptions>, IDisposable // TypeDefIndex: 9658
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_ItemId; // 0x10

	// Properties
	public EpicAccountId LocalUserId { set; }
	public Utf8String ItemId { set; }

	// Methods

	// RVA: 0x4F0010 Offset: 0x4EF210 VA: 0x1804F0010
	public void set_LocalUserId(EpicAccountId value) { }

	// RVA: 0x4EFFB0 Offset: 0x4EF1B0 VA: 0x1804EFFB0
	public void set_ItemId(Utf8String value) { }

	// RVA: 0x4EFDF0 Offset: 0x4EEFF0 VA: 0x1804EFDF0 Slot: 4
	public void Set(ref CopyItemByIdOptions other) { }

	// RVA: 0x4EFEB0 Offset: 0x4EF0B0 VA: 0x1804EFEB0 Slot: 5
	public void Set(ref Nullable<CopyItemByIdOptions> other) { }

	// RVA: 0x4EFD90 Offset: 0x4EEF90 VA: 0x1804EFD90 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Ecom
public struct CopyItemImageInfoByIndexOptions // TypeDefIndex: 9659
{
	// Fields
	[CompilerGenerated]
	private EpicAccountId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <ItemId>k__BackingField; // 0x8
	[CompilerGenerated]
	private uint <ImageInfoIndex>k__BackingField; // 0x10

	// Properties
	public EpicAccountId LocalUserId { get; set; }
	public Utf8String ItemId { get; set; }
	public uint ImageInfoIndex { get; set; }

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
	public Utf8String get_ItemId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_ItemId(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public uint get_ImageInfoIndex() { }

	[CompilerGenerated]
	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_ImageInfoIndex(uint value) { }
}

// Namespace: Epic.OnlineServices.Ecom
internal struct CopyItemImageInfoByIndexOptionsInternal : ISettable<CopyItemImageInfoByIndexOptions>, IDisposable // TypeDefIndex: 9660
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_ItemId; // 0x10
	private uint m_ImageInfoIndex; // 0x18

	// Properties
	public EpicAccountId LocalUserId { set; }
	public Utf8String ItemId { set; }
	public uint ImageInfoIndex { set; }

	// Methods

	// RVA: 0x4F0310 Offset: 0x4EF510 VA: 0x1804F0310
	public void set_LocalUserId(EpicAccountId value) { }

	// RVA: 0x4F02B0 Offset: 0x4EF4B0 VA: 0x1804F02B0
	public void set_ItemId(Utf8String value) { }

	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	public void set_ImageInfoIndex(uint value) { }

	// RVA: 0x4F01F0 Offset: 0x4EF3F0 VA: 0x1804F01F0 Slot: 4
	public void Set(ref CopyItemImageInfoByIndexOptions other) { }

	// RVA: 0x4F00D0 Offset: 0x4EF2D0 VA: 0x1804F00D0 Slot: 5
	public void Set(ref Nullable<CopyItemImageInfoByIndexOptions> other) { }

	// RVA: 0x4F0070 Offset: 0x4EF270 VA: 0x1804F0070 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Ecom
public struct CopyItemReleaseByIndexOptions // TypeDefIndex: 9661
{
	// Fields
	[CompilerGenerated]
	private EpicAccountId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <ItemId>k__BackingField; // 0x8
	[CompilerGenerated]
	private uint <ReleaseIndex>k__BackingField; // 0x10

	// Properties
	public EpicAccountId LocalUserId { get; set; }
	public Utf8String ItemId { get; set; }
	public uint ReleaseIndex { get; set; }

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
	public Utf8String get_ItemId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_ItemId(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public uint get_ReleaseIndex() { }

	[CompilerGenerated]
	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_ReleaseIndex(uint value) { }
}

// Namespace: Epic.OnlineServices.Ecom
internal struct CopyItemReleaseByIndexOptionsInternal : ISettable<CopyItemReleaseByIndexOptions>, IDisposable // TypeDefIndex: 9662
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_ItemId; // 0x10
	private uint m_ReleaseIndex; // 0x18

	// Properties
	public EpicAccountId LocalUserId { set; }
	public Utf8String ItemId { set; }
	public uint ReleaseIndex { set; }

	// Methods

	// RVA: 0x4F0610 Offset: 0x4EF810 VA: 0x1804F0610
	public void set_LocalUserId(EpicAccountId value) { }

	// RVA: 0x4F05B0 Offset: 0x4EF7B0 VA: 0x1804F05B0
	public void set_ItemId(Utf8String value) { }

	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	public void set_ReleaseIndex(uint value) { }

	// RVA: 0x4F04F0 Offset: 0x4EF6F0 VA: 0x1804F04F0 Slot: 4
	public void Set(ref CopyItemReleaseByIndexOptions other) { }

	// RVA: 0x4F03D0 Offset: 0x4EF5D0 VA: 0x1804F03D0 Slot: 5
	public void Set(ref Nullable<CopyItemReleaseByIndexOptions> other) { }

	// RVA: 0x4F0370 Offset: 0x4EF570 VA: 0x1804F0370 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Ecom
public struct CopyLastRedeemedEntitlementByIndexOptions // TypeDefIndex: 9663
{
	// Fields
	[CompilerGenerated]
	private EpicAccountId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private uint <RedeemedEntitlementIndex>k__BackingField; // 0x8

	// Properties
	public EpicAccountId LocalUserId { get; set; }
	public uint RedeemedEntitlementIndex { get; set; }

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
	public uint get_RedeemedEntitlementIndex() { }

	[CompilerGenerated]
	// RVA: 0x3F5520 Offset: 0x3F4720 VA: 0x1803F5520
	public void set_RedeemedEntitlementIndex(uint value) { }
}

// Namespace: Epic.OnlineServices.Ecom
internal struct CopyLastRedeemedEntitlementByIndexOptionsInternal : ISettable<CopyLastRedeemedEntitlementByIndexOptions>, IDisposable // TypeDefIndex: 9664
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private uint m_RedeemedEntitlementIndex; // 0x10

	// Properties
	public EpicAccountId LocalUserId { set; }
	public uint RedeemedEntitlementIndex { set; }

	// Methods

	// RVA: 0x4F0800 Offset: 0x4EFA00 VA: 0x1804F0800
	public void set_LocalUserId(EpicAccountId value) { }

	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_RedeemedEntitlementIndex(uint value) { }

	// RVA: 0x4F0780 Offset: 0x4EF980 VA: 0x1804F0780 Slot: 4
	public void Set(ref CopyLastRedeemedEntitlementByIndexOptions other) { }

	// RVA: 0x4F06C0 Offset: 0x4EF8C0 VA: 0x1804F06C0 Slot: 5
	public void Set(ref Nullable<CopyLastRedeemedEntitlementByIndexOptions> other) { }

	// RVA: 0x4F0670 Offset: 0x4EF870 VA: 0x1804F0670 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Ecom
public struct CopyOfferByIdOptions // TypeDefIndex: 9665
{
	// Fields
	[CompilerGenerated]
	private EpicAccountId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <OfferId>k__BackingField; // 0x8

	// Properties
	public EpicAccountId LocalUserId { get; set; }
	public Utf8String OfferId { get; set; }

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
	public Utf8String get_OfferId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_OfferId(Utf8String value) { }
}

// Namespace: Epic.OnlineServices.Ecom
internal struct CopyOfferByIdOptionsInternal : ISettable<CopyOfferByIdOptions>, IDisposable // TypeDefIndex: 9666
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_OfferId; // 0x10

	// Properties
	public EpicAccountId LocalUserId { set; }
	public Utf8String OfferId { set; }

	// Methods

	// RVA: 0x4F0A80 Offset: 0x4EFC80 VA: 0x1804F0A80
	public void set_LocalUserId(EpicAccountId value) { }

	// RVA: 0x4F0AE0 Offset: 0x4EFCE0 VA: 0x1804F0AE0
	public void set_OfferId(Utf8String value) { }

	// RVA: 0x4F08C0 Offset: 0x4EFAC0 VA: 0x1804F08C0 Slot: 4
	public void Set(ref CopyOfferByIdOptions other) { }

	// RVA: 0x4F0980 Offset: 0x4EFB80 VA: 0x1804F0980 Slot: 5
	public void Set(ref Nullable<CopyOfferByIdOptions> other) { }

	// RVA: 0x4F0860 Offset: 0x4EFA60 VA: 0x1804F0860 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Ecom
public struct CopyOfferByIndexOptions // TypeDefIndex: 9667
{
	// Fields
	[CompilerGenerated]
	private EpicAccountId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private uint <OfferIndex>k__BackingField; // 0x8

	// Properties
	public EpicAccountId LocalUserId { get; set; }
	public uint OfferIndex { get; set; }

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
	// RVA: 0x3F5510 Offset: 0x3F4710 VA: 0x1803F5510
	public uint get_OfferIndex() { }

	[CompilerGenerated]
	// RVA: 0x3F5520 Offset: 0x3F4720 VA: 0x1803F5520
	public void set_OfferIndex(uint value) { }
}

// Namespace: Epic.OnlineServices.Ecom
internal struct CopyOfferByIndexOptionsInternal : ISettable<CopyOfferByIndexOptions>, IDisposable // TypeDefIndex: 9668
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private uint m_OfferIndex; // 0x10

	// Properties
	public EpicAccountId LocalUserId { set; }
	public uint OfferIndex { set; }

	// Methods

	// RVA: 0x4F0CD0 Offset: 0x4EFED0 VA: 0x1804F0CD0
	public void set_LocalUserId(EpicAccountId value) { }

	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_OfferIndex(uint value) { }

	// RVA: 0x4F0B90 Offset: 0x4EFD90 VA: 0x1804F0B90 Slot: 4
	public void Set(ref CopyOfferByIndexOptions other) { }

	// RVA: 0x4F0C10 Offset: 0x4EFE10 VA: 0x1804F0C10 Slot: 5
	public void Set(ref Nullable<CopyOfferByIndexOptions> other) { }

	// RVA: 0x4F0B40 Offset: 0x4EFD40 VA: 0x1804F0B40 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Ecom
public struct CopyOfferImageInfoByIndexOptions // TypeDefIndex: 9669
{
	// Fields
	[CompilerGenerated]
	private EpicAccountId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <OfferId>k__BackingField; // 0x8
	[CompilerGenerated]
	private uint <ImageInfoIndex>k__BackingField; // 0x10

	// Properties
	public EpicAccountId LocalUserId { get; set; }
	public Utf8String OfferId { get; set; }
	public uint ImageInfoIndex { get; set; }

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
	public Utf8String get_OfferId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_OfferId(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public uint get_ImageInfoIndex() { }

	[CompilerGenerated]
	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_ImageInfoIndex(uint value) { }
}

// Namespace: Epic.OnlineServices.Ecom
internal struct CopyOfferImageInfoByIndexOptionsInternal : ISettable<CopyOfferImageInfoByIndexOptions>, IDisposable // TypeDefIndex: 9670
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_OfferId; // 0x10
	private uint m_ImageInfoIndex; // 0x18

	// Properties
	public EpicAccountId LocalUserId { set; }
	public Utf8String OfferId { set; }
	public uint ImageInfoIndex { set; }

	// Methods

	// RVA: 0x4F0F70 Offset: 0x4F0170 VA: 0x1804F0F70
	public void set_LocalUserId(EpicAccountId value) { }

	// RVA: 0x4F0FD0 Offset: 0x4F01D0 VA: 0x1804F0FD0
	public void set_OfferId(Utf8String value) { }

	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	public void set_ImageInfoIndex(uint value) { }

	// RVA: 0x4F0D90 Offset: 0x4EFF90 VA: 0x1804F0D90 Slot: 4
	public void Set(ref CopyOfferImageInfoByIndexOptions other) { }

	// RVA: 0x4F0E50 Offset: 0x4F0050 VA: 0x1804F0E50 Slot: 5
	public void Set(ref Nullable<CopyOfferImageInfoByIndexOptions> other) { }

	// RVA: 0x4F0D30 Offset: 0x4EFF30 VA: 0x1804F0D30 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Ecom
public struct CopyOfferItemByIndexOptions // TypeDefIndex: 9671
{
	// Fields
	[CompilerGenerated]
	private EpicAccountId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <OfferId>k__BackingField; // 0x8
	[CompilerGenerated]
	private uint <ItemIndex>k__BackingField; // 0x10

	// Properties
	public EpicAccountId LocalUserId { get; set; }
	public Utf8String OfferId { get; set; }
	public uint ItemIndex { get; set; }

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
	public Utf8String get_OfferId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_OfferId(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public uint get_ItemIndex() { }

	[CompilerGenerated]
	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_ItemIndex(uint value) { }
}

// Namespace: Epic.OnlineServices.Ecom
internal struct CopyOfferItemByIndexOptionsInternal : ISettable<CopyOfferItemByIndexOptions>, IDisposable // TypeDefIndex: 9672
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_OfferId; // 0x10
	private uint m_ItemIndex; // 0x18

	// Properties
	public EpicAccountId LocalUserId { set; }
	public Utf8String OfferId { set; }
	public uint ItemIndex { set; }

	// Methods

	// RVA: 0x4F1270 Offset: 0x4F0470 VA: 0x1804F1270
	public void set_LocalUserId(EpicAccountId value) { }

	// RVA: 0x4F12D0 Offset: 0x4F04D0 VA: 0x1804F12D0
	public void set_OfferId(Utf8String value) { }

	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	public void set_ItemIndex(uint value) { }

	// RVA: 0x4F11B0 Offset: 0x4F03B0 VA: 0x1804F11B0 Slot: 4
	public void Set(ref CopyOfferItemByIndexOptions other) { }

	// RVA: 0x4F1090 Offset: 0x4F0290 VA: 0x1804F1090 Slot: 5
	public void Set(ref Nullable<CopyOfferItemByIndexOptions> other) { }

	// RVA: 0x4F1030 Offset: 0x4F0230 VA: 0x1804F1030 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Ecom
public struct CopyTransactionByIdOptions // TypeDefIndex: 9673
{
	// Fields
	[CompilerGenerated]
	private EpicAccountId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <TransactionId>k__BackingField; // 0x8

	// Properties
	public EpicAccountId LocalUserId { get; set; }
	public Utf8String TransactionId { get; set; }

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
	public Utf8String get_TransactionId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_TransactionId(Utf8String value) { }
}

// Namespace: Epic.OnlineServices.Ecom
internal struct CopyTransactionByIdOptionsInternal : ISettable<CopyTransactionByIdOptions>, IDisposable // TypeDefIndex: 9674
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_TransactionId; // 0x10

	// Properties
	public EpicAccountId LocalUserId { set; }
	public Utf8String TransactionId { set; }

	// Methods

	// RVA: 0x4F1550 Offset: 0x4F0750 VA: 0x1804F1550
	public void set_LocalUserId(EpicAccountId value) { }

	// RVA: 0x4F15B0 Offset: 0x4F07B0 VA: 0x1804F15B0
	public void set_TransactionId(Utf8String value) { }

	// RVA: 0x4F1490 Offset: 0x4F0690 VA: 0x1804F1490 Slot: 4
	public void Set(ref CopyTransactionByIdOptions other) { }

	// RVA: 0x4F1390 Offset: 0x4F0590 VA: 0x1804F1390 Slot: 5
	public void Set(ref Nullable<CopyTransactionByIdOptions> other) { }

	// RVA: 0x4F1330 Offset: 0x4F0530 VA: 0x1804F1330 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Ecom
public struct CopyTransactionByIndexOptions // TypeDefIndex: 9675
{
	// Fields
	[CompilerGenerated]
	private EpicAccountId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private uint <TransactionIndex>k__BackingField; // 0x8

	// Properties
	public EpicAccountId LocalUserId { get; set; }
	public uint TransactionIndex { get; set; }

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
	public uint get_TransactionIndex() { }

	[CompilerGenerated]
	// RVA: 0x3F5520 Offset: 0x3F4720 VA: 0x1803F5520
	public void set_TransactionIndex(uint value) { }
}

// Namespace: Epic.OnlineServices.Ecom
internal struct CopyTransactionByIndexOptionsInternal : ISettable<CopyTransactionByIndexOptions>, IDisposable // TypeDefIndex: 9676
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private uint m_TransactionIndex; // 0x10

	// Properties
	public EpicAccountId LocalUserId { set; }
	public uint TransactionIndex { set; }

	// Methods

	// RVA: 0x4F17A0 Offset: 0x4F09A0 VA: 0x1804F17A0
	public void set_LocalUserId(EpicAccountId value) { }

	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_TransactionIndex(uint value) { }

	// RVA: 0x4F1660 Offset: 0x4F0860 VA: 0x1804F1660 Slot: 4
	public void Set(ref CopyTransactionByIndexOptions other) { }

	// RVA: 0x4F16E0 Offset: 0x4F08E0 VA: 0x1804F16E0 Slot: 5
	public void Set(ref Nullable<CopyTransactionByIndexOptions> other) { }

	// RVA: 0x4F1610 Offset: 0x4F0810 VA: 0x1804F1610 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Ecom
public sealed class EcomInterface : Handle // TypeDefIndex: 9677
{
	// Fields
	public const int CatalogitemApiLatest = 1;
	public const int CatalogitemEntitlementendtimestampUndefined = -1;
	public const int CatalogofferApiLatest = 5;
	public const int CatalogofferEffectivedatetimestampUndefined = -1;
	public const int CatalogofferExpirationtimestampUndefined = -1;
	public const int CatalogofferReleasedatetimestampUndefined = -1;
	public const int CatalogreleaseApiLatest = 1;
	public const int CheckoutApiLatest = 1;
	public const int CheckoutMaxEntries = 10;
	public const int CheckoutentryApiLatest = 1;
	public const int CopyentitlementbyidApiLatest = 2;
	public const int CopyentitlementbyindexApiLatest = 1;
	public const int CopyentitlementbynameandindexApiLatest = 1;
	public const int CopyitembyidApiLatest = 1;
	public const int CopyitemimageinfobyindexApiLatest = 1;
	public const int CopyitemreleasebyindexApiLatest = 1;
	public const int CopylastredeemedentitlementbyindexApiLatest = 1;
	public const int CopyofferbyidApiLatest = 3;
	public const int CopyofferbyindexApiLatest = 3;
	public const int CopyofferimageinfobyindexApiLatest = 1;
	public const int CopyofferitembyindexApiLatest = 1;
	public const int CopytransactionbyidApiLatest = 1;
	public const int CopytransactionbyindexApiLatest = 1;
	public const int EntitlementApiLatest = 2;
	public const int EntitlementEndtimestampUndefined = -1;
	public const int EntitlementidMaxLength = 32;
	public const int GetentitlementsbynamecountApiLatest = 1;
	public const int GetentitlementscountApiLatest = 1;
	public const int GetitemimageinfocountApiLatest = 1;
	public const int GetitemreleasecountApiLatest = 1;
	public const int GetlastredeemedentitlementscountApiLatest = 1;
	public const int GetoffercountApiLatest = 1;
	public const int GetofferimageinfocountApiLatest = 1;
	public const int GetofferitemcountApiLatest = 1;
	public const int GettransactioncountApiLatest = 1;
	public const int ItemownershipApiLatest = 1;
	public const int KeyimageinfoApiLatest = 1;
	public const int QueryentitlementsApiLatest = 2;
	public const int QueryentitlementsMaxEntitlementIds = 256;
	public const int QueryentitlementtokenApiLatest = 1;
	public const int QueryentitlementtokenMaxEntitlementIds = 32;
	public const int QueryoffersApiLatest = 1;
	public const int QueryownershipApiLatest = 2;
	public const int QueryownershipMaxCatalogIds = 400;
	public const int QueryownershipMaxSandboxIds = 10;
	public const int QueryownershipbysandboxidsoptionsApiLatest = 1;
	public const int QueryownershiptokenApiLatest = 2;
	public const int QueryownershiptokenMaxCatalogitemIds = 32;
	public const int RedeementitlementsApiLatest = 2;
	public const int RedeementitlementsMaxIds = 32;
	public const int TransactionidMaximumLength = 64;

	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }

	// RVA: 0x40BDB0 Offset: 0x40AFB0 VA: 0x18040BDB0
	public void .ctor(IntPtr innerHandle) { }

	// RVA: 0x4F1850 Offset: 0x4F0A50 VA: 0x1804F1850
	public void Checkout(ref CheckoutOptions options, object clientData, OnCheckoutCallback completionDelegate) { }

	// RVA: 0x4F19A0 Offset: 0x4F0BA0 VA: 0x1804F19A0
	public Result CopyEntitlementById(ref CopyEntitlementByIdOptions options, out Nullable<Entitlement> outEntitlement) { }

	// RVA: 0x4F1AA0 Offset: 0x4F0CA0 VA: 0x1804F1AA0
	public Result CopyEntitlementByIndex(ref CopyEntitlementByIndexOptions options, out Nullable<Entitlement> outEntitlement) { }

	// RVA: 0x4F1BF0 Offset: 0x4F0DF0 VA: 0x1804F1BF0
	public Result CopyEntitlementByNameAndIndex(ref CopyEntitlementByNameAndIndexOptions options, out Nullable<Entitlement> outEntitlement) { }

	// RVA: 0x4F1CF0 Offset: 0x4F0EF0 VA: 0x1804F1CF0
	public Result CopyItemById(ref CopyItemByIdOptions options, out Nullable<CatalogItem> outItem) { }

	// RVA: 0x4F1DF0 Offset: 0x4F0FF0 VA: 0x1804F1DF0
	public Result CopyItemImageInfoByIndex(ref CopyItemImageInfoByIndexOptions options, out Nullable<KeyImageInfo> outImageInfo) { }

	// RVA: 0x4F1EF0 Offset: 0x4F10F0 VA: 0x1804F1EF0
	public Result CopyItemReleaseByIndex(ref CopyItemReleaseByIndexOptions options, out Nullable<CatalogRelease> outRelease) { }

	// RVA: 0x4F1FF0 Offset: 0x4F11F0 VA: 0x1804F1FF0
	public Result CopyLastRedeemedEntitlementByIndex(ref CopyLastRedeemedEntitlementByIndexOptions options, out Utf8String outRedeemedEntitlementId) { }

	// RVA: 0x4F2120 Offset: 0x4F1320 VA: 0x1804F2120
	public Result CopyOfferById(ref CopyOfferByIdOptions options, out Nullable<CatalogOffer> outOffer) { }

	// RVA: 0x4F2220 Offset: 0x4F1420 VA: 0x1804F2220
	public Result CopyOfferByIndex(ref CopyOfferByIndexOptions options, out Nullable<CatalogOffer> outOffer) { }

	// RVA: 0x4F2370 Offset: 0x4F1570 VA: 0x1804F2370
	public Result CopyOfferImageInfoByIndex(ref CopyOfferImageInfoByIndexOptions options, out Nullable<KeyImageInfo> outImageInfo) { }

	// RVA: 0x4F2470 Offset: 0x4F1670 VA: 0x1804F2470
	public Result CopyOfferItemByIndex(ref CopyOfferItemByIndexOptions options, out Nullable<CatalogItem> outItem) { }

	// RVA: 0x4F2570 Offset: 0x4F1770 VA: 0x1804F2570
	public Result CopyTransactionById(ref CopyTransactionByIdOptions options, out Transaction outTransaction) { }

	// RVA: 0x4F2650 Offset: 0x4F1850 VA: 0x1804F2650
	public Result CopyTransactionByIndex(ref CopyTransactionByIndexOptions options, out Transaction outTransaction) { }

	// RVA: 0x4F2780 Offset: 0x4F1980 VA: 0x1804F2780
	public uint GetEntitlementsByNameCount(ref GetEntitlementsByNameCountOptions options) { }

	// RVA: 0x4F2820 Offset: 0x4F1A20 VA: 0x1804F2820
	public uint GetEntitlementsCount(ref GetEntitlementsCountOptions options) { }

	// RVA: 0x4F2900 Offset: 0x4F1B00 VA: 0x1804F2900
	public uint GetItemImageInfoCount(ref GetItemImageInfoCountOptions options) { }

	// RVA: 0x4F29A0 Offset: 0x4F1BA0 VA: 0x1804F29A0
	public uint GetItemReleaseCount(ref GetItemReleaseCountOptions options) { }

	// RVA: 0x4F2A40 Offset: 0x4F1C40 VA: 0x1804F2A40
	public uint GetLastRedeemedEntitlementsCount(ref GetLastRedeemedEntitlementsCountOptions options) { }

	// RVA: 0x4F2B20 Offset: 0x4F1D20 VA: 0x1804F2B20
	public uint GetOfferCount(ref GetOfferCountOptions options) { }

	// RVA: 0x4F2C00 Offset: 0x4F1E00 VA: 0x1804F2C00
	public uint GetOfferImageInfoCount(ref GetOfferImageInfoCountOptions options) { }

	// RVA: 0x4F2CA0 Offset: 0x4F1EA0 VA: 0x1804F2CA0
	public uint GetOfferItemCount(ref GetOfferItemCountOptions options) { }

	// RVA: 0x4F2D40 Offset: 0x4F1F40 VA: 0x1804F2D40
	public uint GetTransactionCount(ref GetTransactionCountOptions options) { }

	// RVA: 0x4F33A0 Offset: 0x4F25A0 VA: 0x1804F33A0
	public void QueryEntitlementToken(ref QueryEntitlementTokenOptions options, object clientData, OnQueryEntitlementTokenCallback completionDelegate) { }

	// RVA: 0x4F34E0 Offset: 0x4F26E0 VA: 0x1804F34E0
	public void QueryEntitlements(ref QueryEntitlementsOptions options, object clientData, OnQueryEntitlementsCallback completionDelegate) { }

	// RVA: 0x4F3620 Offset: 0x4F2820 VA: 0x1804F3620
	public void QueryOffers(ref QueryOffersOptions options, object clientData, OnQueryOffersCallback completionDelegate) { }

	// RVA: 0x4F39F0 Offset: 0x4F2BF0 VA: 0x1804F39F0
	public void QueryOwnership(ref QueryOwnershipOptions options, object clientData, OnQueryOwnershipCallback completionDelegate) { }

	// RVA: 0x4F3760 Offset: 0x4F2960 VA: 0x1804F3760
	public void QueryOwnershipBySandboxIds(ref QueryOwnershipBySandboxIdsOptions options, object clientData, OnQueryOwnershipBySandboxIdsCallback completionDelegate) { }

	// RVA: 0x4F38A0 Offset: 0x4F2AA0 VA: 0x1804F38A0
	public void QueryOwnershipToken(ref QueryOwnershipTokenOptions options, object clientData, OnQueryOwnershipTokenCallback completionDelegate) { }

	// RVA: 0x4F3B40 Offset: 0x4F2D40 VA: 0x1804F3B40
	public void RedeemEntitlements(ref RedeemEntitlementsOptions options, object clientData, OnRedeemEntitlementsCallback completionDelegate) { }

	[MonoPInvokeCallback(typeof(OnCheckoutCallbackInternal))]
	// RVA: 0x4F2E20 Offset: 0x4F2020 VA: 0x1804F2E20
	internal static void OnCheckoutCallbackInternalImplementation(ref CheckoutCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnQueryEntitlementTokenCallbackInternal))]
	// RVA: 0x4F2ED0 Offset: 0x4F20D0 VA: 0x1804F2ED0
	internal static void OnQueryEntitlementTokenCallbackInternalImplementation(ref QueryEntitlementTokenCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnQueryEntitlementsCallbackInternal))]
	// RVA: 0x4F2F80 Offset: 0x4F2180 VA: 0x1804F2F80
	internal static void OnQueryEntitlementsCallbackInternalImplementation(ref QueryEntitlementsCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnQueryOffersCallbackInternal))]
	// RVA: 0x4F3030 Offset: 0x4F2230 VA: 0x1804F3030
	internal static void OnQueryOffersCallbackInternalImplementation(ref QueryOffersCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnQueryOwnershipBySandboxIdsCallbackInternal))]
	// RVA: 0x4F30E0 Offset: 0x4F22E0 VA: 0x1804F30E0
	internal static void OnQueryOwnershipBySandboxIdsCallbackInternalImplementation(ref QueryOwnershipBySandboxIdsCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnQueryOwnershipCallbackInternal))]
	// RVA: 0x4F3190 Offset: 0x4F2390 VA: 0x1804F3190
	internal static void OnQueryOwnershipCallbackInternalImplementation(ref QueryOwnershipCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnQueryOwnershipTokenCallbackInternal))]
	// RVA: 0x4F3240 Offset: 0x4F2440 VA: 0x1804F3240
	internal static void OnQueryOwnershipTokenCallbackInternalImplementation(ref QueryOwnershipTokenCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnRedeemEntitlementsCallbackInternal))]
	// RVA: 0x4F32F0 Offset: 0x4F24F0 VA: 0x1804F32F0
	internal static void OnRedeemEntitlementsCallbackInternalImplementation(ref RedeemEntitlementsCallbackInfoInternal data) { }
}

// Namespace: Epic.OnlineServices.Ecom
public enum EcomItemType // TypeDefIndex: 9678
{
	// Fields
	public int value__; // 0x0
	public const EcomItemType Durable = 0;
	public const EcomItemType Consumable = 1;
	public const EcomItemType Other = 2;
}

// Namespace: Epic.OnlineServices.Ecom
public struct Entitlement // TypeDefIndex: 9679
{
	// Fields
	[CompilerGenerated]
	private Utf8String <EntitlementName>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <EntitlementId>k__BackingField; // 0x8
	[CompilerGenerated]
	private Utf8String <CatalogItemId>k__BackingField; // 0x10
	[CompilerGenerated]
	private int <ServerIndex>k__BackingField; // 0x18
	[CompilerGenerated]
	private bool <Redeemed>k__BackingField; // 0x1C
	[CompilerGenerated]
	private long <EndTimestamp>k__BackingField; // 0x20

	// Properties
	public Utf8String EntitlementName { get; set; }
	public Utf8String EntitlementId { get; set; }
	public Utf8String CatalogItemId { get; set; }
	public int ServerIndex { get; set; }
	public bool Redeemed { get; set; }
	public long EndTimestamp { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Utf8String get_EntitlementName() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_EntitlementName(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public Utf8String get_EntitlementId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_EntitlementId(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Utf8String get_CatalogItemId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_CatalogItemId(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public int get_ServerIndex() { }

	[CompilerGenerated]
	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	public void set_ServerIndex(int value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x416930 Offset: 0x415B30 VA: 0x180416930
	public bool get_Redeemed() { }

	[CompilerGenerated]
	// RVA: 0x416950 Offset: 0x415B50 VA: 0x180416950
	public void set_Redeemed(bool value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public long get_EndTimestamp() { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_EndTimestamp(long value) { }

	// RVA: 0x4F4390 Offset: 0x4F3590 VA: 0x1804F4390
	internal void Set(ref EntitlementInternal other) { }
}

// Namespace: Epic.OnlineServices.Ecom
internal struct EntitlementInternal : IGettable<Entitlement>, ISettable<Entitlement>, IDisposable // TypeDefIndex: 9680
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_EntitlementName; // 0x8
	private IntPtr m_EntitlementId; // 0x10
	private IntPtr m_CatalogItemId; // 0x18
	private int m_ServerIndex; // 0x20
	private int m_Redeemed; // 0x24
	private long m_EndTimestamp; // 0x28

	// Properties
	public Utf8String EntitlementName { get; set; }
	public Utf8String EntitlementId { get; set; }
	public Utf8String CatalogItemId { get; set; }
	public int ServerIndex { get; set; }
	public bool Redeemed { get; set; }
	public long EndTimestamp { get; set; }

	// Methods

	// RVA: 0x4F4140 Offset: 0x4F3340 VA: 0x1804F4140
	public Utf8String get_EntitlementName() { }

	// RVA: 0x4F42D0 Offset: 0x4F34D0 VA: 0x1804F42D0
	public void set_EntitlementName(Utf8String value) { }

	// RVA: 0x4F40D0 Offset: 0x4F32D0 VA: 0x1804F40D0
	public Utf8String get_EntitlementId() { }

	// RVA: 0x4F4270 Offset: 0x4F3470 VA: 0x1804F4270
	public void set_EntitlementId(Utf8String value) { }

	// RVA: 0x4F4060 Offset: 0x4F3260 VA: 0x1804F4060
	public Utf8String get_CatalogItemId() { }

	// RVA: 0x4F4210 Offset: 0x4F3410 VA: 0x1804F4210
	public void set_CatalogItemId(Utf8String value) { }

	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400
	public int get_ServerIndex() { }

	// RVA: 0x3DA420 Offset: 0x3D9620 VA: 0x1803DA420
	public void set_ServerIndex(int value) { }

	// RVA: 0x4F41B0 Offset: 0x4F33B0 VA: 0x1804F41B0
	public bool get_Redeemed() { }

	// RVA: 0x4F4330 Offset: 0x4F3530 VA: 0x1804F4330
	public void set_Redeemed(bool value) { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public long get_EndTimestamp() { }

	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	public void set_EndTimestamp(long value) { }

	// RVA: 0x4F3F10 Offset: 0x4F3110 VA: 0x1804F3F10 Slot: 5
	public void Set(ref Entitlement other) { }

	// RVA: 0x4F3D10 Offset: 0x4F2F10 VA: 0x1804F3D10 Slot: 6
	public void Set(ref Nullable<Entitlement> other) { }

	// RVA: 0x4F3C80 Offset: 0x4F2E80 VA: 0x1804F3C80 Slot: 7
	public void Dispose() { }

	// RVA: 0x4F3CE0 Offset: 0x4F2EE0 VA: 0x1804F3CE0 Slot: 4
	public void Get(out Entitlement output) { }
}

// Namespace: Epic.OnlineServices.Ecom
public struct GetEntitlementsByNameCountOptions // TypeDefIndex: 9681
{
	// Fields
	[CompilerGenerated]
	private EpicAccountId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <EntitlementName>k__BackingField; // 0x8

	// Properties
	public EpicAccountId LocalUserId { get; set; }
	public Utf8String EntitlementName { get; set; }

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
	public Utf8String get_EntitlementName() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_EntitlementName(Utf8String value) { }
}

// Namespace: Epic.OnlineServices.Ecom
internal struct GetEntitlementsByNameCountOptionsInternal : ISettable<GetEntitlementsByNameCountOptions>, IDisposable // TypeDefIndex: 9682
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_EntitlementName; // 0x10

	// Properties
	public EpicAccountId LocalUserId { set; }
	public Utf8String EntitlementName { set; }

	// Methods

	// RVA: 0x4F6240 Offset: 0x4F5440 VA: 0x1804F6240
	public void set_LocalUserId(EpicAccountId value) { }

	// RVA: 0x4F61E0 Offset: 0x4F53E0 VA: 0x1804F61E0
	public void set_EntitlementName(Utf8String value) { }

	// RVA: 0x4F6120 Offset: 0x4F5320 VA: 0x1804F6120 Slot: 4
	public void Set(ref GetEntitlementsByNameCountOptions other) { }

	// RVA: 0x4F6020 Offset: 0x4F5220 VA: 0x1804F6020 Slot: 5
	public void Set(ref Nullable<GetEntitlementsByNameCountOptions> other) { }

	// RVA: 0x4F5FC0 Offset: 0x4F51C0 VA: 0x1804F5FC0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Ecom
public struct GetEntitlementsCountOptions // TypeDefIndex: 9683
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

// Namespace: Epic.OnlineServices.Ecom
internal struct GetEntitlementsCountOptionsInternal : ISettable<GetEntitlementsCountOptions>, IDisposable // TypeDefIndex: 9684
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8

	// Properties
	public EpicAccountId LocalUserId { set; }

	// Methods

	// RVA: 0x4F63F0 Offset: 0x4F55F0 VA: 0x1804F63F0
	public void set_LocalUserId(EpicAccountId value) { }

	// RVA: 0x4F6390 Offset: 0x4F5590 VA: 0x1804F6390 Slot: 4
	public void Set(ref GetEntitlementsCountOptions other) { }

	// RVA: 0x4F62F0 Offset: 0x4F54F0 VA: 0x1804F62F0 Slot: 5
	public void Set(ref Nullable<GetEntitlementsCountOptions> other) { }

	// RVA: 0x4F62A0 Offset: 0x4F54A0 VA: 0x1804F62A0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Ecom
public struct GetItemImageInfoCountOptions // TypeDefIndex: 9685
{
	// Fields
	[CompilerGenerated]
	private EpicAccountId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <ItemId>k__BackingField; // 0x8

	// Properties
	public EpicAccountId LocalUserId { get; set; }
	public Utf8String ItemId { get; set; }

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
	public Utf8String get_ItemId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_ItemId(Utf8String value) { }
}

// Namespace: Epic.OnlineServices.Ecom
internal struct GetItemImageInfoCountOptionsInternal : ISettable<GetItemImageInfoCountOptions>, IDisposable // TypeDefIndex: 9686
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_ItemId; // 0x10

	// Properties
	public EpicAccountId LocalUserId { set; }
	public Utf8String ItemId { set; }

	// Methods

	// RVA: 0x4F6A70 Offset: 0x4F5C70 VA: 0x1804F6A70
	public void set_LocalUserId(EpicAccountId value) { }

	// RVA: 0x4F6A10 Offset: 0x4F5C10 VA: 0x1804F6A10
	public void set_ItemId(Utf8String value) { }

	// RVA: 0x4F6850 Offset: 0x4F5A50 VA: 0x1804F6850 Slot: 4
	public void Set(ref GetItemImageInfoCountOptions other) { }

	// RVA: 0x4F6910 Offset: 0x4F5B10 VA: 0x1804F6910 Slot: 5
	public void Set(ref Nullable<GetItemImageInfoCountOptions> other) { }

	// RVA: 0x4F67F0 Offset: 0x4F59F0 VA: 0x1804F67F0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Ecom
public struct GetItemReleaseCountOptions // TypeDefIndex: 9687
{
	// Fields
	[CompilerGenerated]
	private EpicAccountId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <ItemId>k__BackingField; // 0x8

	// Properties
	public EpicAccountId LocalUserId { get; set; }
	public Utf8String ItemId { get; set; }

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
	public Utf8String get_ItemId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_ItemId(Utf8String value) { }
}

// Namespace: Epic.OnlineServices.Ecom
internal struct GetItemReleaseCountOptionsInternal : ISettable<GetItemReleaseCountOptions>, IDisposable // TypeDefIndex: 9688
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_ItemId; // 0x10

	// Properties
	public EpicAccountId LocalUserId { set; }
	public Utf8String ItemId { set; }

	// Methods

	// RVA: 0x4F6D50 Offset: 0x4F5F50 VA: 0x1804F6D50
	public void set_LocalUserId(EpicAccountId value) { }

	// RVA: 0x4F6CF0 Offset: 0x4F5EF0 VA: 0x1804F6CF0
	public void set_ItemId(Utf8String value) { }

	// RVA: 0x4F6C30 Offset: 0x4F5E30 VA: 0x1804F6C30 Slot: 4
	public void Set(ref GetItemReleaseCountOptions other) { }

	// RVA: 0x4F6B30 Offset: 0x4F5D30 VA: 0x1804F6B30 Slot: 5
	public void Set(ref Nullable<GetItemReleaseCountOptions> other) { }

	// RVA: 0x4F6AD0 Offset: 0x4F5CD0 VA: 0x1804F6AD0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Ecom
public struct GetLastRedeemedEntitlementsCountOptions // TypeDefIndex: 9689
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

// Namespace: Epic.OnlineServices.Ecom
internal struct GetLastRedeemedEntitlementsCountOptionsInternal : ISettable<GetLastRedeemedEntitlementsCountOptions>, IDisposable // TypeDefIndex: 9690
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8

	// Properties
	public EpicAccountId LocalUserId { set; }

	// Methods

	// RVA: 0x4F6F00 Offset: 0x4F6100 VA: 0x1804F6F00
	public void set_LocalUserId(EpicAccountId value) { }

	// RVA: 0x4F6EA0 Offset: 0x4F60A0 VA: 0x1804F6EA0 Slot: 4
	public void Set(ref GetLastRedeemedEntitlementsCountOptions other) { }

	// RVA: 0x4F6E00 Offset: 0x4F6000 VA: 0x1804F6E00 Slot: 5
	public void Set(ref Nullable<GetLastRedeemedEntitlementsCountOptions> other) { }

	// RVA: 0x4F6DB0 Offset: 0x4F5FB0 VA: 0x1804F6DB0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Ecom
public struct GetOfferCountOptions // TypeDefIndex: 9691
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

// Namespace: Epic.OnlineServices.Ecom
internal struct GetOfferCountOptionsInternal : ISettable<GetOfferCountOptions>, IDisposable // TypeDefIndex: 9692
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8

	// Properties
	public EpicAccountId LocalUserId { set; }

	// Methods

	// RVA: 0x4F70B0 Offset: 0x4F62B0 VA: 0x1804F70B0
	public void set_LocalUserId(EpicAccountId value) { }

	// RVA: 0x4F7050 Offset: 0x4F6250 VA: 0x1804F7050 Slot: 4
	public void Set(ref GetOfferCountOptions other) { }

	// RVA: 0x4F6FB0 Offset: 0x4F61B0 VA: 0x1804F6FB0 Slot: 5
	public void Set(ref Nullable<GetOfferCountOptions> other) { }

	// RVA: 0x4F6F60 Offset: 0x4F6160 VA: 0x1804F6F60 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Ecom
public struct GetOfferImageInfoCountOptions // TypeDefIndex: 9693
{
	// Fields
	[CompilerGenerated]
	private EpicAccountId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <OfferId>k__BackingField; // 0x8

	// Properties
	public EpicAccountId LocalUserId { get; set; }
	public Utf8String OfferId { get; set; }

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
	public Utf8String get_OfferId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_OfferId(Utf8String value) { }
}

// Namespace: Epic.OnlineServices.Ecom
internal struct GetOfferImageInfoCountOptionsInternal : ISettable<GetOfferImageInfoCountOptions>, IDisposable // TypeDefIndex: 9694
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_OfferId; // 0x10

	// Properties
	public EpicAccountId LocalUserId { set; }
	public Utf8String OfferId { set; }

	// Methods

	// RVA: 0x4F7330 Offset: 0x4F6530 VA: 0x1804F7330
	public void set_LocalUserId(EpicAccountId value) { }

	// RVA: 0x4F7390 Offset: 0x4F6590 VA: 0x1804F7390
	public void set_OfferId(Utf8String value) { }

	// RVA: 0x4F7270 Offset: 0x4F6470 VA: 0x1804F7270 Slot: 4
	public void Set(ref GetOfferImageInfoCountOptions other) { }

	// RVA: 0x4F7170 Offset: 0x4F6370 VA: 0x1804F7170 Slot: 5
	public void Set(ref Nullable<GetOfferImageInfoCountOptions> other) { }

	// RVA: 0x4F7110 Offset: 0x4F6310 VA: 0x1804F7110 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Ecom
public struct GetOfferItemCountOptions // TypeDefIndex: 9695
{
	// Fields
	[CompilerGenerated]
	private EpicAccountId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <OfferId>k__BackingField; // 0x8

	// Properties
	public EpicAccountId LocalUserId { get; set; }
	public Utf8String OfferId { get; set; }

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
	public Utf8String get_OfferId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_OfferId(Utf8String value) { }
}

// Namespace: Epic.OnlineServices.Ecom
internal struct GetOfferItemCountOptionsInternal : ISettable<GetOfferItemCountOptions>, IDisposable // TypeDefIndex: 9696
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_OfferId; // 0x10

	// Properties
	public EpicAccountId LocalUserId { set; }
	public Utf8String OfferId { set; }

	// Methods

	// RVA: 0x4F7610 Offset: 0x4F6810 VA: 0x1804F7610
	public void set_LocalUserId(EpicAccountId value) { }

	// RVA: 0x4F7670 Offset: 0x4F6870 VA: 0x1804F7670
	public void set_OfferId(Utf8String value) { }

	// RVA: 0x4F7550 Offset: 0x4F6750 VA: 0x1804F7550 Slot: 4
	public void Set(ref GetOfferItemCountOptions other) { }

	// RVA: 0x4F7450 Offset: 0x4F6650 VA: 0x1804F7450 Slot: 5
	public void Set(ref Nullable<GetOfferItemCountOptions> other) { }

	// RVA: 0x4F73F0 Offset: 0x4F65F0 VA: 0x1804F73F0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Ecom
public struct GetTransactionCountOptions // TypeDefIndex: 9697
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

// Namespace: Epic.OnlineServices.Ecom
internal struct GetTransactionCountOptionsInternal : ISettable<GetTransactionCountOptions>, IDisposable // TypeDefIndex: 9698
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8

	// Properties
	public EpicAccountId LocalUserId { set; }

	// Methods

	// RVA: 0x4F7B00 Offset: 0x4F6D00 VA: 0x1804F7B00
	public void set_LocalUserId(EpicAccountId value) { }

	// RVA: 0x4F7AA0 Offset: 0x4F6CA0 VA: 0x1804F7AA0 Slot: 4
	public void Set(ref GetTransactionCountOptions other) { }

	// RVA: 0x4F7A00 Offset: 0x4F6C00 VA: 0x1804F7A00 Slot: 5
	public void Set(ref Nullable<GetTransactionCountOptions> other) { }

	// RVA: 0x4F79B0 Offset: 0x4F6BB0 VA: 0x1804F79B0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Ecom
public struct ItemOwnership // TypeDefIndex: 9699
{
	// Fields
	[CompilerGenerated]
	private Utf8String <Id>k__BackingField; // 0x0
	[CompilerGenerated]
	private OwnershipStatus <OwnershipStatus>k__BackingField; // 0x8

	// Properties
	public Utf8String Id { get; set; }
	public OwnershipStatus OwnershipStatus { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Utf8String get_Id() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_Id(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3F5510 Offset: 0x3F4710 VA: 0x1803F5510
	public OwnershipStatus get_OwnershipStatus() { }

	[CompilerGenerated]
	// RVA: 0x3F5520 Offset: 0x3F4720 VA: 0x1803F5520
	public void set_OwnershipStatus(OwnershipStatus value) { }

	// RVA: 0x50D8F0 Offset: 0x50CAF0 VA: 0x18050D8F0
	internal void Set(ref ItemOwnershipInternal other) { }
}

// Namespace: Epic.OnlineServices.Ecom
internal struct ItemOwnershipInternal : IGettable<ItemOwnership>, ISettable<ItemOwnership>, IDisposable // TypeDefIndex: 9700
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_Id; // 0x8
	private OwnershipStatus m_OwnershipStatus; // 0x10

	// Properties
	public Utf8String Id { get; set; }
	public OwnershipStatus OwnershipStatus { get; set; }

	// Methods

	// RVA: 0x50D820 Offset: 0x50CA20 VA: 0x18050D820
	public Utf8String get_Id() { }

	// RVA: 0x50D890 Offset: 0x50CA90 VA: 0x18050D890
	public void set_Id(Utf8String value) { }

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public OwnershipStatus get_OwnershipStatus() { }

	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_OwnershipStatus(OwnershipStatus value) { }

	// RVA: 0x50D7A0 Offset: 0x50C9A0 VA: 0x18050D7A0 Slot: 5
	public void Set(ref ItemOwnership other) { }

	// RVA: 0x50D6E0 Offset: 0x50C8E0 VA: 0x18050D6E0 Slot: 6
	public void Set(ref Nullable<ItemOwnership> other) { }

	// RVA: 0x50D670 Offset: 0x50C870 VA: 0x18050D670 Slot: 7
	public void Dispose() { }

	// RVA: 0x50D6C0 Offset: 0x50C8C0 VA: 0x18050D6C0 Slot: 4
	public void Get(out ItemOwnership output) { }
}

// Namespace: Epic.OnlineServices.Ecom
public struct KeyImageInfo // TypeDefIndex: 9701
{
	// Fields
	[CompilerGenerated]
	private Utf8String <Type>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <Url>k__BackingField; // 0x8
	[CompilerGenerated]
	private uint <Width>k__BackingField; // 0x10
	[CompilerGenerated]
	private uint <Height>k__BackingField; // 0x14

	// Properties
	public Utf8String Type { get; set; }
	public Utf8String Url { get; set; }
	public uint Width { get; set; }
	public uint Height { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Utf8String get_Type() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_Type(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public Utf8String get_Url() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_Url(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public uint get_Width() { }

	[CompilerGenerated]
	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_Width(uint value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500
	public uint get_Height() { }

	[CompilerGenerated]
	// RVA: 0x426530 Offset: 0x425730 VA: 0x180426530
	public void set_Height(uint value) { }

	// RVA: 0x50DDA0 Offset: 0x50CFA0 VA: 0x18050DDA0
	internal void Set(ref KeyImageInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.Ecom
internal struct KeyImageInfoInternal : IGettable<KeyImageInfo>, ISettable<KeyImageInfo>, IDisposable // TypeDefIndex: 9702
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_Type; // 0x8
	private IntPtr m_Url; // 0x10
	private uint m_Width; // 0x18
	private uint m_Height; // 0x1C

	// Properties
	public Utf8String Type { get; set; }
	public Utf8String Url { get; set; }
	public uint Width { get; set; }
	public uint Height { get; set; }

	// Methods

	// RVA: 0x50DC00 Offset: 0x50CE00 VA: 0x18050DC00
	public Utf8String get_Type() { }

	// RVA: 0x50DCE0 Offset: 0x50CEE0 VA: 0x18050DCE0
	public void set_Type(Utf8String value) { }

	// RVA: 0x50DC70 Offset: 0x50CE70 VA: 0x18050DC70
	public Utf8String get_Url() { }

	// RVA: 0x50DD40 Offset: 0x50CF40 VA: 0x18050DD40
	public void set_Url(Utf8String value) { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public uint get_Width() { }

	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	public void set_Width(uint value) { }

	// RVA: 0x3F9110 Offset: 0x3F8310 VA: 0x1803F9110
	public uint get_Height() { }

	// RVA: 0x3F9290 Offset: 0x3F8490 VA: 0x1803F9290
	public void set_Height(uint value) { }

	// RVA: 0x50DA00 Offset: 0x50CC00 VA: 0x18050DA00 Slot: 5
	public void Set(ref KeyImageInfo other) { }

	// RVA: 0x50DAC0 Offset: 0x50CCC0 VA: 0x18050DAC0 Slot: 6
	public void Set(ref Nullable<KeyImageInfo> other) { }

	// RVA: 0x50D980 Offset: 0x50CB80 VA: 0x18050D980 Slot: 7
	public void Dispose() { }

	// RVA: 0x50D9E0 Offset: 0x50CBE0 VA: 0x18050D9E0 Slot: 4
	public void Get(out KeyImageInfo output) { }
}

// Namespace: Epic.OnlineServices.Ecom
public sealed class OnCheckoutCallback : MulticastDelegate // TypeDefIndex: 9703
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref CheckoutCallbackInfo data) { }

	// RVA: 0x50FE60 Offset: 0x50F060 VA: 0x18050FE60 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref CheckoutCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref CheckoutCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Ecom
[UnmanagedFunctionPointer(2)]
internal sealed class OnCheckoutCallbackInternal : MulticastDelegate // TypeDefIndex: 9704
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref CheckoutCallbackInfoInternal data) { }

	// RVA: 0x50FDD0 Offset: 0x50EFD0 VA: 0x18050FDD0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref CheckoutCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref CheckoutCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Ecom
public sealed class OnQueryEntitlementsCallback : MulticastDelegate // TypeDefIndex: 9705
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref QueryEntitlementsCallbackInfo data) { }

	// RVA: 0x511F40 Offset: 0x511140 VA: 0x180511F40 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref QueryEntitlementsCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref QueryEntitlementsCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Ecom
[UnmanagedFunctionPointer(2)]
internal sealed class OnQueryEntitlementsCallbackInternal : MulticastDelegate // TypeDefIndex: 9706
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref QueryEntitlementsCallbackInfoInternal data) { }

	// RVA: 0x511EB0 Offset: 0x5110B0 VA: 0x180511EB0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref QueryEntitlementsCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref QueryEntitlementsCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Ecom
public sealed class OnQueryEntitlementTokenCallback : MulticastDelegate // TypeDefIndex: 9707
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref QueryEntitlementTokenCallbackInfo data) { }

	// RVA: 0x511E20 Offset: 0x511020 VA: 0x180511E20 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref QueryEntitlementTokenCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref QueryEntitlementTokenCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Ecom
[UnmanagedFunctionPointer(2)]
internal sealed class OnQueryEntitlementTokenCallbackInternal : MulticastDelegate // TypeDefIndex: 9708
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref QueryEntitlementTokenCallbackInfoInternal data) { }

	// RVA: 0x511D90 Offset: 0x510F90 VA: 0x180511D90 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref QueryEntitlementTokenCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref QueryEntitlementTokenCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Ecom
public sealed class OnQueryOffersCallback : MulticastDelegate // TypeDefIndex: 9709
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref QueryOffersCallbackInfo data) { }

	// RVA: 0x512180 Offset: 0x511380 VA: 0x180512180 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref QueryOffersCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref QueryOffersCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Ecom
[UnmanagedFunctionPointer(2)]
internal sealed class OnQueryOffersCallbackInternal : MulticastDelegate // TypeDefIndex: 9710
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref QueryOffersCallbackInfoInternal data) { }

	// RVA: 0x5120F0 Offset: 0x5112F0 VA: 0x1805120F0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref QueryOffersCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref QueryOffersCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Ecom
public sealed class OnQueryOwnershipBySandboxIdsCallback : MulticastDelegate // TypeDefIndex: 9711
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref QueryOwnershipBySandboxIdsCallbackInfo data) { }

	// RVA: 0x5122A0 Offset: 0x5114A0 VA: 0x1805122A0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref QueryOwnershipBySandboxIdsCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref QueryOwnershipBySandboxIdsCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Ecom
[UnmanagedFunctionPointer(2)]
internal sealed class OnQueryOwnershipBySandboxIdsCallbackInternal : MulticastDelegate // TypeDefIndex: 9712
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref QueryOwnershipBySandboxIdsCallbackInfoInternal data) { }

	// RVA: 0x512210 Offset: 0x511410 VA: 0x180512210 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref QueryOwnershipBySandboxIdsCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref QueryOwnershipBySandboxIdsCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Ecom
public sealed class OnQueryOwnershipCallback : MulticastDelegate // TypeDefIndex: 9713
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref QueryOwnershipCallbackInfo data) { }

	// RVA: 0x5123C0 Offset: 0x5115C0 VA: 0x1805123C0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref QueryOwnershipCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref QueryOwnershipCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Ecom
[UnmanagedFunctionPointer(2)]
internal sealed class OnQueryOwnershipCallbackInternal : MulticastDelegate // TypeDefIndex: 9714
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref QueryOwnershipCallbackInfoInternal data) { }

	// RVA: 0x512330 Offset: 0x511530 VA: 0x180512330 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref QueryOwnershipCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref QueryOwnershipCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Ecom
public sealed class OnQueryOwnershipTokenCallback : MulticastDelegate // TypeDefIndex: 9715
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref QueryOwnershipTokenCallbackInfo data) { }

	// RVA: 0x5124E0 Offset: 0x5116E0 VA: 0x1805124E0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref QueryOwnershipTokenCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref QueryOwnershipTokenCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Ecom
[UnmanagedFunctionPointer(2)]
internal sealed class OnQueryOwnershipTokenCallbackInternal : MulticastDelegate // TypeDefIndex: 9716
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref QueryOwnershipTokenCallbackInfoInternal data) { }

	// RVA: 0x512450 Offset: 0x511650 VA: 0x180512450 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref QueryOwnershipTokenCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref QueryOwnershipTokenCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Ecom
public sealed class OnRedeemEntitlementsCallback : MulticastDelegate // TypeDefIndex: 9717
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref RedeemEntitlementsCallbackInfo data) { }

	// RVA: 0x512690 Offset: 0x511890 VA: 0x180512690 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref RedeemEntitlementsCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref RedeemEntitlementsCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Ecom
[UnmanagedFunctionPointer(2)]
internal sealed class OnRedeemEntitlementsCallbackInternal : MulticastDelegate // TypeDefIndex: 9718
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref RedeemEntitlementsCallbackInfoInternal data) { }

	// RVA: 0x512600 Offset: 0x511800 VA: 0x180512600 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref RedeemEntitlementsCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref RedeemEntitlementsCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Ecom
public enum OwnershipStatus // TypeDefIndex: 9719
{
	// Fields
	public int value__; // 0x0
	public const OwnershipStatus NotOwned = 0;
	public const OwnershipStatus Owned = 1;
}

// Namespace: Epic.OnlineServices.Ecom
public struct QueryEntitlementsCallbackInfo : ICallbackInfo // TypeDefIndex: 9720
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

	// RVA: 0x514980 Offset: 0x513B80 VA: 0x180514980 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x5149D0 Offset: 0x513BD0 VA: 0x1805149D0
	internal void Set(ref QueryEntitlementsCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.Ecom
internal struct QueryEntitlementsCallbackInfoInternal : ICallbackInfoInternal, IGettable<QueryEntitlementsCallbackInfo>, ISettable<QueryEntitlementsCallbackInfo>, IDisposable // TypeDefIndex: 9721
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

	// RVA: 0x5147D0 Offset: 0x5139D0 VA: 0x1805147D0
	public object get_ClientData() { }

	// RVA: 0x5148C0 Offset: 0x513AC0 VA: 0x1805148C0
	public void set_ClientData(object value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x514840 Offset: 0x513A40 VA: 0x180514840
	public EpicAccountId get_LocalUserId() { }

	// RVA: 0x514920 Offset: 0x513B20 VA: 0x180514920
	public void set_LocalUserId(EpicAccountId value) { }

	// RVA: 0x514600 Offset: 0x513800 VA: 0x180514600 Slot: 6
	public void Set(ref QueryEntitlementsCallbackInfo other) { }

	// RVA: 0x5146B0 Offset: 0x5138B0 VA: 0x1805146B0 Slot: 7
	public void Set(ref Nullable<QueryEntitlementsCallbackInfo> other) { }

	// RVA: 0x514580 Offset: 0x513780 VA: 0x180514580 Slot: 8
	public void Dispose() { }

	// RVA: 0x5145E0 Offset: 0x5137E0 VA: 0x1805145E0 Slot: 5
	public void Get(out QueryEntitlementsCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.Ecom
public struct QueryEntitlementsOptions // TypeDefIndex: 9722
{
	// Fields
	[CompilerGenerated]
	private EpicAccountId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String[] <EntitlementNames>k__BackingField; // 0x8
	[CompilerGenerated]
	private bool <IncludeRedeemed>k__BackingField; // 0x10

	// Properties
	public EpicAccountId LocalUserId { get; set; }
	public Utf8String[] EntitlementNames { get; set; }
	public bool IncludeRedeemed { get; set; }

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
	public Utf8String[] get_EntitlementNames() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_EntitlementNames(Utf8String[] value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	public bool get_IncludeRedeemed() { }

	[CompilerGenerated]
	// RVA: 0x3D6DB0 Offset: 0x3D5FB0 VA: 0x1803D6DB0
	public void set_IncludeRedeemed(bool value) { }
}

// Namespace: Epic.OnlineServices.Ecom
internal struct QueryEntitlementsOptionsInternal : ISettable<QueryEntitlementsOptions>, IDisposable // TypeDefIndex: 9723
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_EntitlementNames; // 0x10
	private uint m_EntitlementNameCount; // 0x18
	private int m_IncludeRedeemed; // 0x1C

	// Properties
	public EpicAccountId LocalUserId { set; }
	public Utf8String[] EntitlementNames { set; }
	public bool IncludeRedeemed { set; }

	// Methods

	// RVA: 0x514DD0 Offset: 0x513FD0 VA: 0x180514DD0
	public void set_LocalUserId(EpicAccountId value) { }

	// RVA: 0x514D00 Offset: 0x513F00 VA: 0x180514D00
	public void set_EntitlementNames(Utf8String[] value) { }

	// RVA: 0x514D70 Offset: 0x513F70 VA: 0x180514D70
	public void set_IncludeRedeemed(bool value) { }

	// RVA: 0x514BF0 Offset: 0x513DF0 VA: 0x180514BF0 Slot: 4
	public void Set(ref QueryEntitlementsOptions other) { }

	// RVA: 0x514AC0 Offset: 0x513CC0 VA: 0x180514AC0 Slot: 5
	public void Set(ref Nullable<QueryEntitlementsOptions> other) { }

	// RVA: 0x514A60 Offset: 0x513C60 VA: 0x180514A60 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Ecom
public struct QueryEntitlementTokenCallbackInfo : ICallbackInfo // TypeDefIndex: 9724
{
	// Fields
	[CompilerGenerated]
	private Result <ResultCode>k__BackingField; // 0x0
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x8
	[CompilerGenerated]
	private EpicAccountId <LocalUserId>k__BackingField; // 0x10
	[CompilerGenerated]
	private Utf8String <EntitlementToken>k__BackingField; // 0x18

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public EpicAccountId LocalUserId { get; set; }
	public Utf8String EntitlementToken { get; set; }

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
	public EpicAccountId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_LocalUserId(EpicAccountId value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public Utf8String get_EntitlementToken() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_EntitlementToken(Utf8String value) { }

	// RVA: 0x514170 Offset: 0x513370 VA: 0x180514170 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x5141C0 Offset: 0x5133C0 VA: 0x1805141C0
	internal void Set(ref QueryEntitlementTokenCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.Ecom
internal struct QueryEntitlementTokenCallbackInfoInternal : ICallbackInfoInternal, IGettable<QueryEntitlementTokenCallbackInfo>, ISettable<QueryEntitlementTokenCallbackInfo>, IDisposable // TypeDefIndex: 9725
{
	// Fields
	private Result m_ResultCode; // 0x0
	private IntPtr m_ClientData; // 0x8
	private IntPtr m_LocalUserId; // 0x10
	private IntPtr m_EntitlementToken; // 0x18

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public EpicAccountId LocalUserId { get; set; }
	public Utf8String EntitlementToken { get; set; }

	// Methods

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	// RVA: 0x513EF0 Offset: 0x5130F0 VA: 0x180513EF0
	public object get_ClientData() { }

	// RVA: 0x514050 Offset: 0x513250 VA: 0x180514050
	public void set_ClientData(object value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x513FD0 Offset: 0x5131D0 VA: 0x180513FD0
	public EpicAccountId get_LocalUserId() { }

	// RVA: 0x514110 Offset: 0x513310 VA: 0x180514110
	public void set_LocalUserId(EpicAccountId value) { }

	// RVA: 0x513F60 Offset: 0x513160 VA: 0x180513F60
	public Utf8String get_EntitlementToken() { }

	// RVA: 0x5140B0 Offset: 0x5132B0 VA: 0x1805140B0
	public void set_EntitlementToken(Utf8String value) { }

	// RVA: 0x513DF0 Offset: 0x512FF0 VA: 0x180513DF0 Slot: 6
	public void Set(ref QueryEntitlementTokenCallbackInfo other) { }

	// RVA: 0x513C80 Offset: 0x512E80 VA: 0x180513C80 Slot: 7
	public void Set(ref Nullable<QueryEntitlementTokenCallbackInfo> other) { }

	// RVA: 0x513C00 Offset: 0x512E00 VA: 0x180513C00 Slot: 8
	public void Dispose() { }

	// RVA: 0x513C60 Offset: 0x512E60 VA: 0x180513C60 Slot: 5
	public void Get(out QueryEntitlementTokenCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.Ecom
public struct QueryEntitlementTokenOptions // TypeDefIndex: 9726
{
	// Fields
	[CompilerGenerated]
	private EpicAccountId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String[] <EntitlementNames>k__BackingField; // 0x8

	// Properties
	public EpicAccountId LocalUserId { get; set; }
	public Utf8String[] EntitlementNames { get; set; }

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
	public Utf8String[] get_EntitlementNames() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_EntitlementNames(Utf8String[] value) { }
}

// Namespace: Epic.OnlineServices.Ecom
internal struct QueryEntitlementTokenOptionsInternal : ISettable<QueryEntitlementTokenOptions>, IDisposable // TypeDefIndex: 9727
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_EntitlementNames; // 0x10
	private uint m_EntitlementNameCount; // 0x18

	// Properties
	public EpicAccountId LocalUserId { set; }
	public Utf8String[] EntitlementNames { set; }

	// Methods

	// RVA: 0x514520 Offset: 0x513720 VA: 0x180514520
	public void set_LocalUserId(EpicAccountId value) { }

	// RVA: 0x5144B0 Offset: 0x5136B0 VA: 0x1805144B0
	public void set_EntitlementNames(Utf8String[] value) { }

	// RVA: 0x514310 Offset: 0x513510 VA: 0x180514310 Slot: 4
	public void Set(ref QueryEntitlementTokenOptions other) { }

	// RVA: 0x5143E0 Offset: 0x5135E0 VA: 0x1805143E0 Slot: 5
	public void Set(ref Nullable<QueryEntitlementTokenOptions> other) { }

	// RVA: 0x5142B0 Offset: 0x5134B0 VA: 0x1805142B0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Ecom
public struct QueryOffersCallbackInfo : ICallbackInfo // TypeDefIndex: 9728
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

	// RVA: 0x515230 Offset: 0x514430 VA: 0x180515230 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x515280 Offset: 0x514480 VA: 0x180515280
	internal void Set(ref QueryOffersCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.Ecom
internal struct QueryOffersCallbackInfoInternal : ICallbackInfoInternal, IGettable<QueryOffersCallbackInfo>, ISettable<QueryOffersCallbackInfo>, IDisposable // TypeDefIndex: 9729
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

	// RVA: 0x515080 Offset: 0x514280 VA: 0x180515080
	public object get_ClientData() { }

	// RVA: 0x515170 Offset: 0x514370 VA: 0x180515170
	public void set_ClientData(object value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x5150F0 Offset: 0x5142F0 VA: 0x1805150F0
	public EpicAccountId get_LocalUserId() { }

	// RVA: 0x5151D0 Offset: 0x5143D0 VA: 0x1805151D0
	public void set_LocalUserId(EpicAccountId value) { }

	// RVA: 0x514FD0 Offset: 0x5141D0 VA: 0x180514FD0 Slot: 6
	public void Set(ref QueryOffersCallbackInfo other) { }

	// RVA: 0x514EB0 Offset: 0x5140B0 VA: 0x180514EB0 Slot: 7
	public void Set(ref Nullable<QueryOffersCallbackInfo> other) { }

	// RVA: 0x514E30 Offset: 0x514030 VA: 0x180514E30 Slot: 8
	public void Dispose() { }

	// RVA: 0x514E90 Offset: 0x514090 VA: 0x180514E90 Slot: 5
	public void Get(out QueryOffersCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.Ecom
public struct QueryOffersOptions // TypeDefIndex: 9730
{
	// Fields
	[CompilerGenerated]
	private EpicAccountId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <OverrideCatalogNamespace>k__BackingField; // 0x8

	// Properties
	public EpicAccountId LocalUserId { get; set; }
	public Utf8String OverrideCatalogNamespace { get; set; }

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
	public Utf8String get_OverrideCatalogNamespace() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_OverrideCatalogNamespace(Utf8String value) { }
}

// Namespace: Epic.OnlineServices.Ecom
internal struct QueryOffersOptionsInternal : ISettable<QueryOffersOptions>, IDisposable // TypeDefIndex: 9731
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_OverrideCatalogNamespace; // 0x10

	// Properties
	public EpicAccountId LocalUserId { set; }
	public Utf8String OverrideCatalogNamespace { set; }

	// Methods

	// RVA: 0x515530 Offset: 0x514730 VA: 0x180515530
	public void set_LocalUserId(EpicAccountId value) { }

	// RVA: 0x515590 Offset: 0x514790 VA: 0x180515590
	public void set_OverrideCatalogNamespace(Utf8String value) { }

	// RVA: 0x515470 Offset: 0x514670 VA: 0x180515470 Slot: 4
	public void Set(ref QueryOffersOptions other) { }

	// RVA: 0x515370 Offset: 0x514570 VA: 0x180515370 Slot: 5
	public void Set(ref Nullable<QueryOffersOptions> other) { }

	// RVA: 0x515310 Offset: 0x514510 VA: 0x180515310 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Ecom
public struct QueryOwnershipBySandboxIdsCallbackInfo : ICallbackInfo // TypeDefIndex: 9732
{
	// Fields
	[CompilerGenerated]
	private Result <ResultCode>k__BackingField; // 0x0
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x8
	[CompilerGenerated]
	private EpicAccountId <LocalUserId>k__BackingField; // 0x10
	[CompilerGenerated]
	private SandboxIdItemOwnership[] <SandboxIdItemOwnerships>k__BackingField; // 0x18

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public EpicAccountId LocalUserId { get; set; }
	public SandboxIdItemOwnership[] SandboxIdItemOwnerships { get; set; }

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

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public SandboxIdItemOwnership[] get_SandboxIdItemOwnerships() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_SandboxIdItemOwnerships(SandboxIdItemOwnership[] value) { }

	// RVA: 0x515B70 Offset: 0x514D70 VA: 0x180515B70 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x515BC0 Offset: 0x514DC0 VA: 0x180515BC0
	internal void Set(ref QueryOwnershipBySandboxIdsCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.Ecom
internal struct QueryOwnershipBySandboxIdsCallbackInfoInternal : ICallbackInfoInternal, IGettable<QueryOwnershipBySandboxIdsCallbackInfo>, ISettable<QueryOwnershipBySandboxIdsCallbackInfo>, IDisposable // TypeDefIndex: 9733
{
	// Fields
	private Result m_ResultCode; // 0x0
	private IntPtr m_ClientData; // 0x8
	private IntPtr m_LocalUserId; // 0x10
	private IntPtr m_SandboxIdItemOwnerships; // 0x18
	private uint m_SandboxIdItemOwnershipsCount; // 0x20

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public EpicAccountId LocalUserId { get; set; }
	public SandboxIdItemOwnership[] SandboxIdItemOwnerships { get; set; }

	// Methods

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	// RVA: 0x5158C0 Offset: 0x514AC0 VA: 0x1805158C0
	public object get_ClientData() { }

	// RVA: 0x515A40 Offset: 0x514C40 VA: 0x180515A40
	public void set_ClientData(object value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x515930 Offset: 0x514B30 VA: 0x180515930
	public EpicAccountId get_LocalUserId() { }

	// RVA: 0x515AA0 Offset: 0x514CA0 VA: 0x180515AA0
	public void set_LocalUserId(EpicAccountId value) { }

	// RVA: 0x5159B0 Offset: 0x514BB0 VA: 0x1805159B0
	public SandboxIdItemOwnership[] get_SandboxIdItemOwnerships() { }

	// RVA: 0x515B00 Offset: 0x514D00 VA: 0x180515B00
	public void set_SandboxIdItemOwnerships(SandboxIdItemOwnership[] value) { }

	// RVA: 0x515670 Offset: 0x514870 VA: 0x180515670 Slot: 6
	public void Set(ref QueryOwnershipBySandboxIdsCallbackInfo other) { }

	// RVA: 0x515780 Offset: 0x514980 VA: 0x180515780 Slot: 7
	public void Set(ref Nullable<QueryOwnershipBySandboxIdsCallbackInfo> other) { }

	// RVA: 0x5155F0 Offset: 0x5147F0 VA: 0x1805155F0 Slot: 8
	public void Dispose() { }

	// RVA: 0x515650 Offset: 0x514850 VA: 0x180515650 Slot: 5
	public void Get(out QueryOwnershipBySandboxIdsCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.Ecom
public struct QueryOwnershipBySandboxIdsOptions // TypeDefIndex: 9734
{
	// Fields
	[CompilerGenerated]
	private EpicAccountId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String[] <SandboxIds>k__BackingField; // 0x8

	// Properties
	public EpicAccountId LocalUserId { get; set; }
	public Utf8String[] SandboxIds { get; set; }

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
	public Utf8String[] get_SandboxIds() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_SandboxIds(Utf8String[] value) { }
}

// Namespace: Epic.OnlineServices.Ecom
internal struct QueryOwnershipBySandboxIdsOptionsInternal : ISettable<QueryOwnershipBySandboxIdsOptions>, IDisposable // TypeDefIndex: 9735
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_SandboxIds; // 0x10
	private uint m_SandboxIdsCount; // 0x18

	// Properties
	public EpicAccountId LocalUserId { set; }
	public Utf8String[] SandboxIds { set; }

	// Methods

	// RVA: 0x515E60 Offset: 0x515060 VA: 0x180515E60
	public void set_LocalUserId(EpicAccountId value) { }

	// RVA: 0x515EC0 Offset: 0x5150C0 VA: 0x180515EC0
	public void set_SandboxIds(Utf8String[] value) { }

	// RVA: 0x515D90 Offset: 0x514F90 VA: 0x180515D90 Slot: 4
	public void Set(ref QueryOwnershipBySandboxIdsOptions other) { }

	// RVA: 0x515CC0 Offset: 0x514EC0 VA: 0x180515CC0 Slot: 5
	public void Set(ref Nullable<QueryOwnershipBySandboxIdsOptions> other) { }

	// RVA: 0x515C60 Offset: 0x514E60 VA: 0x180515C60 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Ecom
public struct QueryOwnershipCallbackInfo : ICallbackInfo // TypeDefIndex: 9736
{
	// Fields
	[CompilerGenerated]
	private Result <ResultCode>k__BackingField; // 0x0
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x8
	[CompilerGenerated]
	private EpicAccountId <LocalUserId>k__BackingField; // 0x10
	[CompilerGenerated]
	private ItemOwnership[] <ItemOwnership>k__BackingField; // 0x18

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public EpicAccountId LocalUserId { get; set; }
	public ItemOwnership[] ItemOwnership { get; set; }

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
	public ItemOwnership[] get_ItemOwnership() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_ItemOwnership(ItemOwnership[] value) { }

	// RVA: 0x5164B0 Offset: 0x5156B0 VA: 0x1805164B0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x516500 Offset: 0x515700 VA: 0x180516500
	internal void Set(ref QueryOwnershipCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.Ecom
internal struct QueryOwnershipCallbackInfoInternal : ICallbackInfoInternal, IGettable<QueryOwnershipCallbackInfo>, ISettable<QueryOwnershipCallbackInfo>, IDisposable // TypeDefIndex: 9737
{
	// Fields
	private Result m_ResultCode; // 0x0
	private IntPtr m_ClientData; // 0x8
	private IntPtr m_LocalUserId; // 0x10
	private IntPtr m_ItemOwnership; // 0x18
	private uint m_ItemOwnershipCount; // 0x20

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public EpicAccountId LocalUserId { get; set; }
	public ItemOwnership[] ItemOwnership { get; set; }

	// Methods

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	// RVA: 0x516200 Offset: 0x515400 VA: 0x180516200
	public object get_ClientData() { }

	// RVA: 0x516380 Offset: 0x515580 VA: 0x180516380
	public void set_ClientData(object value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x516300 Offset: 0x515500 VA: 0x180516300
	public EpicAccountId get_LocalUserId() { }

	// RVA: 0x516450 Offset: 0x515650 VA: 0x180516450
	public void set_LocalUserId(EpicAccountId value) { }

	// RVA: 0x516270 Offset: 0x515470 VA: 0x180516270
	public ItemOwnership[] get_ItemOwnership() { }

	// RVA: 0x5163E0 Offset: 0x5155E0 VA: 0x1805163E0
	public void set_ItemOwnership(ItemOwnership[] value) { }

	// RVA: 0x5160F0 Offset: 0x5152F0 VA: 0x1805160F0 Slot: 6
	public void Set(ref QueryOwnershipCallbackInfo other) { }

	// RVA: 0x515FB0 Offset: 0x5151B0 VA: 0x180515FB0 Slot: 7
	public void Set(ref Nullable<QueryOwnershipCallbackInfo> other) { }

	// RVA: 0x515F30 Offset: 0x515130 VA: 0x180515F30 Slot: 8
	public void Dispose() { }

	// RVA: 0x515F90 Offset: 0x515190 VA: 0x180515F90 Slot: 5
	public void Get(out QueryOwnershipCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.Ecom
public struct QueryOwnershipOptions // TypeDefIndex: 9738
{
	// Fields
	[CompilerGenerated]
	private EpicAccountId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String[] <CatalogItemIds>k__BackingField; // 0x8
	[CompilerGenerated]
	private Utf8String <CatalogNamespace>k__BackingField; // 0x10

	// Properties
	public EpicAccountId LocalUserId { get; set; }
	public Utf8String[] CatalogItemIds { get; set; }
	public Utf8String CatalogNamespace { get; set; }

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
	public Utf8String[] get_CatalogItemIds() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_CatalogItemIds(Utf8String[] value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Utf8String get_CatalogNamespace() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_CatalogNamespace(Utf8String value) { }
}

// Namespace: Epic.OnlineServices.Ecom
internal struct QueryOwnershipOptionsInternal : ISettable<QueryOwnershipOptions>, IDisposable // TypeDefIndex: 9739
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_CatalogItemIds; // 0x10
	private uint m_CatalogItemIdCount; // 0x18
	private IntPtr m_CatalogNamespace; // 0x20

	// Properties
	public EpicAccountId LocalUserId { set; }
	public Utf8String[] CatalogItemIds { set; }
	public Utf8String CatalogNamespace { set; }

	// Methods

	// RVA: 0x516910 Offset: 0x515B10 VA: 0x180516910
	public void set_LocalUserId(EpicAccountId value) { }

	// RVA: 0x516840 Offset: 0x515A40 VA: 0x180516840
	public void set_CatalogItemIds(Utf8String[] value) { }

	// RVA: 0x5168B0 Offset: 0x515AB0 VA: 0x1805168B0
	public void set_CatalogNamespace(Utf8String value) { }

	// RVA: 0x516730 Offset: 0x515930 VA: 0x180516730 Slot: 4
	public void Set(ref QueryOwnershipOptions other) { }

	// RVA: 0x516600 Offset: 0x515800 VA: 0x180516600 Slot: 5
	public void Set(ref Nullable<QueryOwnershipOptions> other) { }

	// RVA: 0x5165A0 Offset: 0x5157A0 VA: 0x1805165A0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Ecom
public struct QueryOwnershipTokenCallbackInfo : ICallbackInfo // TypeDefIndex: 9740
{
	// Fields
	[CompilerGenerated]
	private Result <ResultCode>k__BackingField; // 0x0
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x8
	[CompilerGenerated]
	private EpicAccountId <LocalUserId>k__BackingField; // 0x10
	[CompilerGenerated]
	private Utf8String <OwnershipToken>k__BackingField; // 0x18

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public EpicAccountId LocalUserId { get; set; }
	public Utf8String OwnershipToken { get; set; }

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
	public Utf8String get_OwnershipToken() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_OwnershipToken(Utf8String value) { }

	// RVA: 0x516EE0 Offset: 0x5160E0 VA: 0x180516EE0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x516F30 Offset: 0x516130 VA: 0x180516F30
	internal void Set(ref QueryOwnershipTokenCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.Ecom
internal struct QueryOwnershipTokenCallbackInfoInternal : ICallbackInfoInternal, IGettable<QueryOwnershipTokenCallbackInfo>, ISettable<QueryOwnershipTokenCallbackInfo>, IDisposable // TypeDefIndex: 9741
{
	// Fields
	private Result m_ResultCode; // 0x0
	private IntPtr m_ClientData; // 0x8
	private IntPtr m_LocalUserId; // 0x10
	private IntPtr m_OwnershipToken; // 0x18

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public EpicAccountId LocalUserId { get; set; }
	public Utf8String OwnershipToken { get; set; }

	// Methods

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	// RVA: 0x516C60 Offset: 0x515E60 VA: 0x180516C60
	public object get_ClientData() { }

	// RVA: 0x516DC0 Offset: 0x515FC0 VA: 0x180516DC0
	public void set_ClientData(object value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x516CD0 Offset: 0x515ED0 VA: 0x180516CD0
	public EpicAccountId get_LocalUserId() { }

	// RVA: 0x516E20 Offset: 0x516020 VA: 0x180516E20
	public void set_LocalUserId(EpicAccountId value) { }

	// RVA: 0x516D50 Offset: 0x515F50 VA: 0x180516D50
	public Utf8String get_OwnershipToken() { }

	// RVA: 0x516E80 Offset: 0x516080 VA: 0x180516E80
	public void set_OwnershipToken(Utf8String value) { }

	// RVA: 0x516B60 Offset: 0x515D60 VA: 0x180516B60 Slot: 6
	public void Set(ref QueryOwnershipTokenCallbackInfo other) { }

	// RVA: 0x5169F0 Offset: 0x515BF0 VA: 0x1805169F0 Slot: 7
	public void Set(ref Nullable<QueryOwnershipTokenCallbackInfo> other) { }

	// RVA: 0x516970 Offset: 0x515B70 VA: 0x180516970 Slot: 8
	public void Dispose() { }

	// RVA: 0x5169D0 Offset: 0x515BD0 VA: 0x1805169D0 Slot: 5
	public void Get(out QueryOwnershipTokenCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.Ecom
public struct QueryOwnershipTokenOptions // TypeDefIndex: 9742
{
	// Fields
	[CompilerGenerated]
	private EpicAccountId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String[] <CatalogItemIds>k__BackingField; // 0x8
	[CompilerGenerated]
	private Utf8String <CatalogNamespace>k__BackingField; // 0x10

	// Properties
	public EpicAccountId LocalUserId { get; set; }
	public Utf8String[] CatalogItemIds { get; set; }
	public Utf8String CatalogNamespace { get; set; }

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
	public Utf8String[] get_CatalogItemIds() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_CatalogItemIds(Utf8String[] value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Utf8String get_CatalogNamespace() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_CatalogNamespace(Utf8String value) { }
}

// Namespace: Epic.OnlineServices.Ecom
internal struct QueryOwnershipTokenOptionsInternal : ISettable<QueryOwnershipTokenOptions>, IDisposable // TypeDefIndex: 9743
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_CatalogItemIds; // 0x10
	private uint m_CatalogItemIdCount; // 0x18
	private IntPtr m_CatalogNamespace; // 0x20

	// Properties
	public EpicAccountId LocalUserId { set; }
	public Utf8String[] CatalogItemIds { set; }
	public Utf8String CatalogNamespace { set; }

	// Methods

	// RVA: 0x517390 Offset: 0x516590 VA: 0x180517390
	public void set_LocalUserId(EpicAccountId value) { }

	// RVA: 0x5172C0 Offset: 0x5164C0 VA: 0x1805172C0
	public void set_CatalogItemIds(Utf8String[] value) { }

	// RVA: 0x517330 Offset: 0x516530 VA: 0x180517330
	public void set_CatalogNamespace(Utf8String value) { }

	// RVA: 0x517080 Offset: 0x516280 VA: 0x180517080 Slot: 4
	public void Set(ref QueryOwnershipTokenOptions other) { }

	// RVA: 0x517190 Offset: 0x516390 VA: 0x180517190 Slot: 5
	public void Set(ref Nullable<QueryOwnershipTokenOptions> other) { }

	// RVA: 0x517020 Offset: 0x516220 VA: 0x180517020 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Ecom
public struct RedeemEntitlementsCallbackInfo : ICallbackInfo // TypeDefIndex: 9744
{
	// Fields
	[CompilerGenerated]
	private Result <ResultCode>k__BackingField; // 0x0
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x8
	[CompilerGenerated]
	private EpicAccountId <LocalUserId>k__BackingField; // 0x10
	[CompilerGenerated]
	private uint <RedeemedEntitlementIdsCount>k__BackingField; // 0x18

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public EpicAccountId LocalUserId { get; set; }
	public uint RedeemedEntitlementIdsCount { get; set; }

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
	public EpicAccountId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_LocalUserId(EpicAccountId value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public uint get_RedeemedEntitlementIdsCount() { }

	[CompilerGenerated]
	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	public void set_RedeemedEntitlementIdsCount(uint value) { }

	// RVA: 0x517810 Offset: 0x516A10 VA: 0x180517810 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x517860 Offset: 0x516A60 VA: 0x180517860
	internal void Set(ref RedeemEntitlementsCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.Ecom
internal struct RedeemEntitlementsCallbackInfoInternal : ICallbackInfoInternal, IGettable<RedeemEntitlementsCallbackInfo>, ISettable<RedeemEntitlementsCallbackInfo>, IDisposable // TypeDefIndex: 9745
{
	// Fields
	private Result m_ResultCode; // 0x0
	private IntPtr m_ClientData; // 0x8
	private IntPtr m_LocalUserId; // 0x10
	private uint m_RedeemedEntitlementIdsCount; // 0x18

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public EpicAccountId LocalUserId { get; set; }
	public uint RedeemedEntitlementIdsCount { get; set; }

	// Methods

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	// RVA: 0x517660 Offset: 0x516860 VA: 0x180517660
	public object get_ClientData() { }

	// RVA: 0x517750 Offset: 0x516950 VA: 0x180517750
	public void set_ClientData(object value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x5176D0 Offset: 0x5168D0 VA: 0x1805176D0
	public EpicAccountId get_LocalUserId() { }

	// RVA: 0x5177B0 Offset: 0x5169B0 VA: 0x1805177B0
	public void set_LocalUserId(EpicAccountId value) { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public uint get_RedeemedEntitlementIdsCount() { }

	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	public void set_RedeemedEntitlementIdsCount(uint value) { }

	// RVA: 0x5175A0 Offset: 0x5167A0 VA: 0x1805175A0 Slot: 6
	public void Set(ref RedeemEntitlementsCallbackInfo other) { }

	// RVA: 0x517470 Offset: 0x516670 VA: 0x180517470 Slot: 7
	public void Set(ref Nullable<RedeemEntitlementsCallbackInfo> other) { }

	// RVA: 0x5173F0 Offset: 0x5165F0 VA: 0x1805173F0 Slot: 8
	public void Dispose() { }

	// RVA: 0x517450 Offset: 0x516650 VA: 0x180517450 Slot: 5
	public void Get(out RedeemEntitlementsCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.Ecom
public struct RedeemEntitlementsOptions // TypeDefIndex: 9746
{
	// Fields
	[CompilerGenerated]
	private EpicAccountId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String[] <EntitlementIds>k__BackingField; // 0x8

	// Properties
	public EpicAccountId LocalUserId { get; set; }
	public Utf8String[] EntitlementIds { get; set; }

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
	public Utf8String[] get_EntitlementIds() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_EntitlementIds(Utf8String[] value) { }
}

// Namespace: Epic.OnlineServices.Ecom
internal struct RedeemEntitlementsOptionsInternal : ISettable<RedeemEntitlementsOptions>, IDisposable // TypeDefIndex: 9747
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private uint m_EntitlementIdCount; // 0x10
	private IntPtr m_EntitlementIds; // 0x18

	// Properties
	public EpicAccountId LocalUserId { set; }
	public Utf8String[] EntitlementIds { set; }

	// Methods

	// RVA: 0x517B70 Offset: 0x516D70 VA: 0x180517B70
	public void set_LocalUserId(EpicAccountId value) { }

	// RVA: 0x517B00 Offset: 0x516D00 VA: 0x180517B00
	public void set_EntitlementIds(Utf8String[] value) { }

	// RVA: 0x517A30 Offset: 0x516C30 VA: 0x180517A30 Slot: 4
	public void Set(ref RedeemEntitlementsOptions other) { }

	// RVA: 0x517960 Offset: 0x516B60 VA: 0x180517960 Slot: 5
	public void Set(ref Nullable<RedeemEntitlementsOptions> other) { }

	// RVA: 0x517900 Offset: 0x516B00 VA: 0x180517900 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Ecom
public struct SandboxIdItemOwnership // TypeDefIndex: 9748
{
	// Fields
	[CompilerGenerated]
	private Utf8String <SandboxId>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String[] <OwnedCatalogItemIds>k__BackingField; // 0x8

	// Properties
	public Utf8String SandboxId { get; set; }
	public Utf8String[] OwnedCatalogItemIds { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Utf8String get_SandboxId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_SandboxId(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public Utf8String[] get_OwnedCatalogItemIds() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_OwnedCatalogItemIds(Utf8String[] value) { }

	// RVA: 0x519510 Offset: 0x518710 VA: 0x180519510
	internal void Set(ref SandboxIdItemOwnershipInternal other) { }
}

// Namespace: Epic.OnlineServices.Ecom
internal struct SandboxIdItemOwnershipInternal : IGettable<SandboxIdItemOwnership>, ISettable<SandboxIdItemOwnership>, IDisposable // TypeDefIndex: 9749
{
	// Fields
	private IntPtr m_SandboxId; // 0x0
	private IntPtr m_OwnedCatalogItemIds; // 0x8
	private uint m_OwnedCatalogItemIdsCount; // 0x10

	// Properties
	public Utf8String SandboxId { get; set; }
	public Utf8String[] OwnedCatalogItemIds { get; set; }

	// Methods

	// RVA: 0x5193D0 Offset: 0x5185D0 VA: 0x1805193D0
	public Utf8String get_SandboxId() { }

	// RVA: 0x5194B0 Offset: 0x5186B0 VA: 0x1805194B0
	public void set_SandboxId(Utf8String value) { }

	// RVA: 0x519340 Offset: 0x518540 VA: 0x180519340
	public Utf8String[] get_OwnedCatalogItemIds() { }

	// RVA: 0x519440 Offset: 0x518640 VA: 0x180519440
	public void set_OwnedCatalogItemIds(Utf8String[] value) { }

	// RVA: 0x519280 Offset: 0x518480 VA: 0x180519280 Slot: 5
	public void Set(ref SandboxIdItemOwnership other) { }

	// RVA: 0x5191B0 Offset: 0x5183B0 VA: 0x1805191B0 Slot: 6
	public void Set(ref Nullable<SandboxIdItemOwnership> other) { }

	// RVA: 0x519130 Offset: 0x518330 VA: 0x180519130 Slot: 7
	public void Dispose() { }

	// RVA: 0x519190 Offset: 0x518390 VA: 0x180519190 Slot: 4
	public void Get(out SandboxIdItemOwnership output) { }
}

// Namespace: Epic.OnlineServices.Ecom
public sealed class Transaction : Handle // TypeDefIndex: 9750
{
	// Fields
	public const int TransactionCopyentitlementbyindexApiLatest = 1;
	public const int TransactionGetentitlementscountApiLatest = 1;

	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }

	// RVA: 0x40BDB0 Offset: 0x40AFB0 VA: 0x18040BDB0
	public void .ctor(IntPtr innerHandle) { }

	// RVA: 0x51B5B0 Offset: 0x51A7B0 VA: 0x18051B5B0
	public Result CopyEntitlementByIndex(ref TransactionCopyEntitlementByIndexOptions options, out Nullable<Entitlement> outEntitlement) { }

	// RVA: 0x51B6A0 Offset: 0x51A8A0 VA: 0x18051B6A0
	public uint GetEntitlementsCount(ref TransactionGetEntitlementsCountOptions options) { }

	// RVA: 0x51B720 Offset: 0x51A920 VA: 0x18051B720
	public Result GetTransactionId(out Utf8String outBuffer) { }

	// RVA: 0x51B7C0 Offset: 0x51A9C0 VA: 0x18051B7C0
	public void Release() { }
}

// Namespace: Epic.OnlineServices.Ecom
public struct TransactionCopyEntitlementByIndexOptions // TypeDefIndex: 9751
{
	// Fields
	[CompilerGenerated]
	private uint <EntitlementIndex>k__BackingField; // 0x0

	// Properties
	public uint EntitlementIndex { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public uint get_EntitlementIndex() { }

	[CompilerGenerated]
	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_EntitlementIndex(uint value) { }
}

// Namespace: Epic.OnlineServices.Ecom
internal struct TransactionCopyEntitlementByIndexOptionsInternal : ISettable<TransactionCopyEntitlementByIndexOptions>, IDisposable // TypeDefIndex: 9752
{
	// Fields
	private int m_ApiVersion; // 0x0
	private uint m_EntitlementIndex; // 0x4

	// Properties
	public uint EntitlementIndex { set; }

	// Methods

	// RVA: 0x3F84A0 Offset: 0x3F76A0 VA: 0x1803F84A0
	public void set_EntitlementIndex(uint value) { }

	// RVA: 0x40B2E0 Offset: 0x40A4E0 VA: 0x18040B2E0 Slot: 4
	public void Set(ref TransactionCopyEntitlementByIndexOptions other) { }

	// RVA: 0x51B500 Offset: 0x51A700 VA: 0x18051B500 Slot: 5
	public void Set(ref Nullable<TransactionCopyEntitlementByIndexOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Ecom
public struct TransactionGetEntitlementsCountOptions // TypeDefIndex: 9753
{}

// Namespace: Epic.OnlineServices.Ecom
internal struct TransactionGetEntitlementsCountOptionsInternal : ISettable<TransactionGetEntitlementsCountOptions>, IDisposable // TypeDefIndex: 9754
{
	// Fields
	private int m_ApiVersion; // 0x0

	// Methods

	// RVA: 0x3F98A0 Offset: 0x3F8AA0 VA: 0x1803F98A0 Slot: 4
	public void Set(ref TransactionGetEntitlementsCountOptions other) { }

	// RVA: 0x51B560 Offset: 0x51A760 VA: 0x18051B560 Slot: 5
	public void Set(ref Nullable<TransactionGetEntitlementsCountOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.CustomInvites
public struct AcceptRequestToJoinCallbackInfo : ICallbackInfo // TypeDefIndex: 9755
{
	// Fields
	[CompilerGenerated]
	private Result <ResultCode>k__BackingField; // 0x0
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x8
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x10
	[CompilerGenerated]
	private ProductUserId <TargetUserId>k__BackingField; // 0x18

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public ProductUserId LocalUserId { get; set; }
	public ProductUserId TargetUserId { get; set; }

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

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public ProductUserId get_TargetUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_TargetUserId(ProductUserId value) { }

	// RVA: 0x5042C0 Offset: 0x5034C0 VA: 0x1805042C0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x504310 Offset: 0x503510 VA: 0x180504310
	internal void Set(ref AcceptRequestToJoinCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.CustomInvites
internal struct AcceptRequestToJoinCallbackInfoInternal : ICallbackInfoInternal, IGettable<AcceptRequestToJoinCallbackInfo>, ISettable<AcceptRequestToJoinCallbackInfo>, IDisposable // TypeDefIndex: 9756
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
	public ProductUserId LocalUserId { get; set; }
	public ProductUserId TargetUserId { get; set; }

	// Methods

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	// RVA: 0x504030 Offset: 0x503230 VA: 0x180504030
	public object get_ClientData() { }

	// RVA: 0x5041A0 Offset: 0x5033A0 VA: 0x1805041A0
	public void set_ClientData(object value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x5040A0 Offset: 0x5032A0 VA: 0x1805040A0
	public ProductUserId get_LocalUserId() { }

	// RVA: 0x504200 Offset: 0x503400 VA: 0x180504200
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x504120 Offset: 0x503320 VA: 0x180504120
	public ProductUserId get_TargetUserId() { }

	// RVA: 0x504260 Offset: 0x503460 VA: 0x180504260
	public void set_TargetUserId(ProductUserId value) { }

	// RVA: 0x503F30 Offset: 0x503130 VA: 0x180503F30 Slot: 6
	public void Set(ref AcceptRequestToJoinCallbackInfo other) { }

	// RVA: 0x503DC0 Offset: 0x502FC0 VA: 0x180503DC0 Slot: 7
	public void Set(ref Nullable<AcceptRequestToJoinCallbackInfo> other) { }

	// RVA: 0x503D40 Offset: 0x502F40 VA: 0x180503D40 Slot: 8
	public void Dispose() { }

	// RVA: 0x503DA0 Offset: 0x502FA0 VA: 0x180503DA0 Slot: 5
	public void Get(out AcceptRequestToJoinCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.CustomInvites
public struct AcceptRequestToJoinOptions // TypeDefIndex: 9757
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private ProductUserId <TargetUserId>k__BackingField; // 0x8

	// Properties
	public ProductUserId LocalUserId { get; set; }
	public ProductUserId TargetUserId { get; set; }

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
	public ProductUserId get_TargetUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_TargetUserId(ProductUserId value) { }
}

// Namespace: Epic.OnlineServices.CustomInvites
internal struct AcceptRequestToJoinOptionsInternal : ISettable<AcceptRequestToJoinOptions>, IDisposable // TypeDefIndex: 9758
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_TargetUserId; // 0x10

	// Properties
	public ProductUserId LocalUserId { set; }
	public ProductUserId TargetUserId { set; }

	// Methods

	// RVA: 0x5045D0 Offset: 0x5037D0 VA: 0x1805045D0
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x504630 Offset: 0x503830 VA: 0x180504630
	public void set_TargetUserId(ProductUserId value) { }

	// RVA: 0x504410 Offset: 0x503610 VA: 0x180504410 Slot: 4
	public void Set(ref AcceptRequestToJoinOptions other) { }

	// RVA: 0x5044D0 Offset: 0x5036D0 VA: 0x1805044D0 Slot: 5
	public void Set(ref Nullable<AcceptRequestToJoinOptions> other) { }

	// RVA: 0x5043B0 Offset: 0x5035B0 VA: 0x1805043B0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.CustomInvites
public struct AddNotifyCustomInviteAcceptedOptions // TypeDefIndex: 9759
{}

// Namespace: Epic.OnlineServices.CustomInvites
internal struct AddNotifyCustomInviteAcceptedOptionsInternal : ISettable<AddNotifyCustomInviteAcceptedOptions>, IDisposable // TypeDefIndex: 9760
{
	// Fields
	private int m_ApiVersion; // 0x0

	// Methods

	// RVA: 0x3F98A0 Offset: 0x3F8AA0 VA: 0x1803F98A0 Slot: 4
	public void Set(ref AddNotifyCustomInviteAcceptedOptions other) { }

	// RVA: 0x5046E0 Offset: 0x5038E0 VA: 0x1805046E0 Slot: 5
	public void Set(ref Nullable<AddNotifyCustomInviteAcceptedOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.CustomInvites
public struct AddNotifyCustomInviteReceivedOptions // TypeDefIndex: 9761
{}

// Namespace: Epic.OnlineServices.CustomInvites
internal struct AddNotifyCustomInviteReceivedOptionsInternal : ISettable<AddNotifyCustomInviteReceivedOptions>, IDisposable // TypeDefIndex: 9762
{
	// Fields
	private int m_ApiVersion; // 0x0

	// Methods

	// RVA: 0x3F98A0 Offset: 0x3F8AA0 VA: 0x1803F98A0 Slot: 4
	public void Set(ref AddNotifyCustomInviteReceivedOptions other) { }

	// RVA: 0x504730 Offset: 0x503930 VA: 0x180504730 Slot: 5
	public void Set(ref Nullable<AddNotifyCustomInviteReceivedOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.CustomInvites
public struct AddNotifyCustomInviteRejectedOptions // TypeDefIndex: 9763
{}

// Namespace: Epic.OnlineServices.CustomInvites
internal struct AddNotifyCustomInviteRejectedOptionsInternal : ISettable<AddNotifyCustomInviteRejectedOptions>, IDisposable // TypeDefIndex: 9764
{
	// Fields
	private int m_ApiVersion; // 0x0

	// Methods

	// RVA: 0x3F98A0 Offset: 0x3F8AA0 VA: 0x1803F98A0 Slot: 4
	public void Set(ref AddNotifyCustomInviteRejectedOptions other) { }

	// RVA: 0x504780 Offset: 0x503980 VA: 0x180504780 Slot: 5
	public void Set(ref Nullable<AddNotifyCustomInviteRejectedOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.CustomInvites
public struct AddNotifyRequestToJoinAcceptedOptions // TypeDefIndex: 9765
{}

// Namespace: Epic.OnlineServices.CustomInvites
internal struct AddNotifyRequestToJoinAcceptedOptionsInternal : ISettable<AddNotifyRequestToJoinAcceptedOptions>, IDisposable // TypeDefIndex: 9766
{
	// Fields
	private int m_ApiVersion; // 0x0

	// Methods

	// RVA: 0x3F98A0 Offset: 0x3F8AA0 VA: 0x1803F98A0 Slot: 4
	public void Set(ref AddNotifyRequestToJoinAcceptedOptions other) { }

	// RVA: 0x504820 Offset: 0x503A20 VA: 0x180504820 Slot: 5
	public void Set(ref Nullable<AddNotifyRequestToJoinAcceptedOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.CustomInvites
public struct AddNotifyRequestToJoinReceivedOptions // TypeDefIndex: 9767
{}

// Namespace: Epic.OnlineServices.CustomInvites
internal struct AddNotifyRequestToJoinReceivedOptionsInternal : ISettable<AddNotifyRequestToJoinReceivedOptions>, IDisposable // TypeDefIndex: 9768
{
	// Fields
	private int m_ApiVersion; // 0x0

	// Methods

	// RVA: 0x3F98A0 Offset: 0x3F8AA0 VA: 0x1803F98A0 Slot: 4
	public void Set(ref AddNotifyRequestToJoinReceivedOptions other) { }

	// RVA: 0x504870 Offset: 0x503A70 VA: 0x180504870 Slot: 5
	public void Set(ref Nullable<AddNotifyRequestToJoinReceivedOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.CustomInvites
public struct AddNotifyRequestToJoinRejectedOptions // TypeDefIndex: 9769
{}

// Namespace: Epic.OnlineServices.CustomInvites
internal struct AddNotifyRequestToJoinRejectedOptionsInternal : ISettable<AddNotifyRequestToJoinRejectedOptions>, IDisposable // TypeDefIndex: 9770
{
	// Fields
	private int m_ApiVersion; // 0x0

	// Methods

	// RVA: 0x3F98A0 Offset: 0x3F8AA0 VA: 0x1803F98A0 Slot: 4
	public void Set(ref AddNotifyRequestToJoinRejectedOptions other) { }

	// RVA: 0x5048C0 Offset: 0x503AC0 VA: 0x1805048C0 Slot: 5
	public void Set(ref Nullable<AddNotifyRequestToJoinRejectedOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.CustomInvites
public struct AddNotifyRequestToJoinResponseReceivedOptions // TypeDefIndex: 9771
{}

// Namespace: Epic.OnlineServices.CustomInvites
internal struct AddNotifyRequestToJoinResponseReceivedOptionsInternal : ISettable<AddNotifyRequestToJoinResponseReceivedOptions>, IDisposable // TypeDefIndex: 9772
{
	// Fields
	private int m_ApiVersion; // 0x0

	// Methods

	// RVA: 0x3F98A0 Offset: 0x3F8AA0 VA: 0x1803F98A0 Slot: 4
	public void Set(ref AddNotifyRequestToJoinResponseReceivedOptions other) { }

	// RVA: 0x504910 Offset: 0x503B10 VA: 0x180504910 Slot: 5
	public void Set(ref Nullable<AddNotifyRequestToJoinResponseReceivedOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.CustomInvites
public struct AddNotifySendCustomNativeInviteRequestedOptions // TypeDefIndex: 9773
{}

// Namespace: Epic.OnlineServices.CustomInvites
internal struct AddNotifySendCustomNativeInviteRequestedOptionsInternal : ISettable<AddNotifySendCustomNativeInviteRequestedOptions>, IDisposable // TypeDefIndex: 9774
{
	// Fields
	private int m_ApiVersion; // 0x0

	// Methods

	// RVA: 0x3F98A0 Offset: 0x3F8AA0 VA: 0x1803F98A0 Slot: 4
	public void Set(ref AddNotifySendCustomNativeInviteRequestedOptions other) { }

	// RVA: 0x504960 Offset: 0x503B60 VA: 0x180504960 Slot: 5
	public void Set(ref Nullable<AddNotifySendCustomNativeInviteRequestedOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.CustomInvites
public struct CustomInviteRejectedCallbackInfo : ICallbackInfo // TypeDefIndex: 9775
{
	// Fields
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x0
	[CompilerGenerated]
	private ProductUserId <TargetUserId>k__BackingField; // 0x8
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x10
	[CompilerGenerated]
	private Utf8String <CustomInviteId>k__BackingField; // 0x18
	[CompilerGenerated]
	private Utf8String <Payload>k__BackingField; // 0x20

	// Properties
	public object ClientData { get; set; }
	public ProductUserId TargetUserId { get; set; }
	public ProductUserId LocalUserId { get; set; }
	public Utf8String CustomInviteId { get; set; }
	public Utf8String Payload { get; set; }

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
	public ProductUserId get_TargetUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_TargetUserId(ProductUserId value) { }

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
	public Utf8String get_CustomInviteId() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_CustomInviteId(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public Utf8String get_Payload() { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_Payload(Utf8String value) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x5097A0 Offset: 0x5089A0 VA: 0x1805097A0
	internal void Set(ref CustomInviteRejectedCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.CustomInvites
internal struct CustomInviteRejectedCallbackInfoInternal : ICallbackInfoInternal, IGettable<CustomInviteRejectedCallbackInfo>, ISettable<CustomInviteRejectedCallbackInfo>, IDisposable // TypeDefIndex: 9776
{
	// Fields
	private IntPtr m_ClientData; // 0x0
	private IntPtr m_TargetUserId; // 0x8
	private IntPtr m_LocalUserId; // 0x10
	private IntPtr m_CustomInviteId; // 0x18
	private IntPtr m_Payload; // 0x20

	// Properties
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public ProductUserId TargetUserId { get; set; }
	public ProductUserId LocalUserId { get; set; }
	public Utf8String CustomInviteId { get; set; }
	public Utf8String Payload { get; set; }

	// Methods

	// RVA: 0x509370 Offset: 0x508570 VA: 0x180509370
	public object get_ClientData() { }

	// RVA: 0x5095C0 Offset: 0x5087C0 VA: 0x1805095C0
	public void set_ClientData(object value) { }

	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x509540 Offset: 0x508740 VA: 0x180509540
	public ProductUserId get_TargetUserId() { }

	// RVA: 0x509740 Offset: 0x508940 VA: 0x180509740
	public void set_TargetUserId(ProductUserId value) { }

	// RVA: 0x509450 Offset: 0x508650 VA: 0x180509450
	public ProductUserId get_LocalUserId() { }

	// RVA: 0x509680 Offset: 0x508880 VA: 0x180509680
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x5093E0 Offset: 0x5085E0 VA: 0x1805093E0
	public Utf8String get_CustomInviteId() { }

	// RVA: 0x509620 Offset: 0x508820 VA: 0x180509620
	public void set_CustomInviteId(Utf8String value) { }

	// RVA: 0x5094D0 Offset: 0x5086D0 VA: 0x1805094D0
	public Utf8String get_Payload() { }

	// RVA: 0x5096E0 Offset: 0x5088E0 VA: 0x1805096E0
	public void set_Payload(Utf8String value) { }

	// RVA: 0x508FF0 Offset: 0x5081F0 VA: 0x180508FF0 Slot: 6
	public void Set(ref CustomInviteRejectedCallbackInfo other) { }

	// RVA: 0x509170 Offset: 0x508370 VA: 0x180509170 Slot: 7
	public void Set(ref Nullable<CustomInviteRejectedCallbackInfo> other) { }

	// RVA: 0x508F40 Offset: 0x508140 VA: 0x180508F40 Slot: 8
	public void Dispose() { }

	// RVA: 0x508FC0 Offset: 0x5081C0 VA: 0x180508FC0 Slot: 5
	public void Get(out CustomInviteRejectedCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.CustomInvites
public sealed class CustomInvitesInterface : Handle // TypeDefIndex: 9777
{
	// Fields
	public const int AcceptrequesttojoinApiLatest = 1;
	public const int AddnotifycustominviteacceptedApiLatest = 1;
	public const int AddnotifycustominvitereceivedApiLatest = 1;
	public const int AddnotifycustominviterejectedApiLatest = 1;
	public const int AddnotifyrequesttojoinacceptedApiLatest = 1;
	public const int AddnotifyrequesttojoinreceivedApiLatest = 1;
	public const int AddnotifyrequesttojoinrejectedApiLatest = 1;
	public const int AddnotifyrequesttojoinresponsereceivedApiLatest = 1;
	public const int AddnotifysendcustomnativeinviterequestedApiLatest = 1;
	public const int FinalizeinviteApiLatest = 1;
	public const int MaxPayloadLength = 500;
	public const int RejectrequesttojoinApiLatest = 1;
	public const int SendcustominviteApiLatest = 1;
	public const int SendrequesttojoinApiLatest = 1;
	public const int SetcustominviteApiLatest = 1;

	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }

	// RVA: 0x40BDB0 Offset: 0x40AFB0 VA: 0x18040BDB0
	public void .ctor(IntPtr innerHandle) { }

	// RVA: 0x5098F0 Offset: 0x508AF0 VA: 0x1805098F0
	public void AcceptRequestToJoin(ref AcceptRequestToJoinOptions options, object clientData, OnAcceptRequestToJoinCallback completionDelegate) { }

	// RVA: 0x509AA0 Offset: 0x508CA0 VA: 0x180509AA0
	public ulong AddNotifyCustomInviteAccepted(ref AddNotifyCustomInviteAcceptedOptions options, object clientData, OnCustomInviteAcceptedCallback notificationFn) { }

	// RVA: 0x509C50 Offset: 0x508E50 VA: 0x180509C50
	public ulong AddNotifyCustomInviteReceived(ref AddNotifyCustomInviteReceivedOptions options, object clientData, OnCustomInviteReceivedCallback notificationFn) { }

	// RVA: 0x509E00 Offset: 0x509000 VA: 0x180509E00
	public ulong AddNotifyCustomInviteRejected(ref AddNotifyCustomInviteRejectedOptions options, object clientData, OnCustomInviteRejectedCallback notificationFn) { }

	// RVA: 0x509FB0 Offset: 0x5091B0 VA: 0x180509FB0
	public ulong AddNotifyRequestToJoinAccepted(ref AddNotifyRequestToJoinAcceptedOptions options, object clientData, OnRequestToJoinAcceptedCallback notificationFn) { }

	// RVA: 0x50A160 Offset: 0x509360 VA: 0x18050A160
	public ulong AddNotifyRequestToJoinReceived(ref AddNotifyRequestToJoinReceivedOptions options, object clientData, OnRequestToJoinReceivedCallback notificationFn) { }

	// RVA: 0x50A310 Offset: 0x509510 VA: 0x18050A310
	public ulong AddNotifyRequestToJoinRejected(ref AddNotifyRequestToJoinRejectedOptions options, object clientData, OnRequestToJoinRejectedCallback notificationFn) { }

	// RVA: 0x50A4C0 Offset: 0x5096C0 VA: 0x18050A4C0
	public ulong AddNotifyRequestToJoinResponseReceived(ref AddNotifyRequestToJoinResponseReceivedOptions options, object clientData, OnRequestToJoinResponseReceivedCallback notificationFn) { }

	// RVA: 0x50A670 Offset: 0x509870 VA: 0x18050A670
	public ulong AddNotifySendCustomNativeInviteRequested(ref AddNotifySendCustomNativeInviteRequestedOptions options, object clientData, OnSendCustomNativeInviteRequestedCallback notificationFn) { }

	// RVA: 0x50A820 Offset: 0x509A20 VA: 0x18050A820
	public Result FinalizeInvite(ref FinalizeInviteOptions options) { }

	// RVA: 0x50B110 Offset: 0x50A310 VA: 0x18050B110
	public void RejectRequestToJoin(ref RejectRequestToJoinOptions options, object clientData, OnRejectRequestToJoinCallback completionDelegate) { }

	// RVA: 0x50B2C0 Offset: 0x50A4C0 VA: 0x18050B2C0
	public void RemoveNotifyCustomInviteAccepted(ulong inId) { }

	// RVA: 0x50B330 Offset: 0x50A530 VA: 0x18050B330
	public void RemoveNotifyCustomInviteReceived(ulong inId) { }

	// RVA: 0x50B3A0 Offset: 0x50A5A0 VA: 0x18050B3A0
	public void RemoveNotifyCustomInviteRejected(ulong inId) { }

	// RVA: 0x50B410 Offset: 0x50A610 VA: 0x18050B410
	public void RemoveNotifyRequestToJoinAccepted(ulong inId) { }

	// RVA: 0x50B480 Offset: 0x50A680 VA: 0x18050B480
	public void RemoveNotifyRequestToJoinReceived(ulong inId) { }

	// RVA: 0x50B4F0 Offset: 0x50A6F0 VA: 0x18050B4F0
	public void RemoveNotifyRequestToJoinRejected(ulong inId) { }

	// RVA: 0x50B560 Offset: 0x50A760 VA: 0x18050B560
	public void RemoveNotifyRequestToJoinResponseReceived(ulong inId) { }

	// RVA: 0x50B5D0 Offset: 0x50A7D0 VA: 0x18050B5D0
	public void RemoveNotifySendCustomNativeInviteRequested(ulong inId) { }

	// RVA: 0x50B640 Offset: 0x50A840 VA: 0x18050B640
	public void SendCustomInvite(ref SendCustomInviteOptions options, object clientData, OnSendCustomInviteCallback completionDelegate) { }

	// RVA: 0x50B7F0 Offset: 0x50A9F0 VA: 0x18050B7F0
	public void SendRequestToJoin(ref SendRequestToJoinOptions options, object clientData, OnSendRequestToJoinCallback completionDelegate) { }

	// RVA: 0x50B9A0 Offset: 0x50ABA0 VA: 0x18050B9A0
	public Result SetCustomInvite(ref SetCustomInviteOptions options) { }

	[MonoPInvokeCallback(typeof(OnAcceptRequestToJoinCallbackInternal))]
	// RVA: 0x50A8D0 Offset: 0x509AD0 VA: 0x18050A8D0
	internal static void OnAcceptRequestToJoinCallbackInternalImplementation(ref AcceptRequestToJoinCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnCustomInviteAcceptedCallbackInternal))]
	// RVA: 0x50A980 Offset: 0x509B80 VA: 0x18050A980
	internal static void OnCustomInviteAcceptedCallbackInternalImplementation(ref OnCustomInviteAcceptedCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnCustomInviteReceivedCallbackInternal))]
	// RVA: 0x50AA30 Offset: 0x509C30 VA: 0x18050AA30
	internal static void OnCustomInviteReceivedCallbackInternalImplementation(ref OnCustomInviteReceivedCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnCustomInviteRejectedCallbackInternal))]
	// RVA: 0x50AAE0 Offset: 0x509CE0 VA: 0x18050AAE0
	internal static void OnCustomInviteRejectedCallbackInternalImplementation(ref CustomInviteRejectedCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnRejectRequestToJoinCallbackInternal))]
	// RVA: 0x50AB90 Offset: 0x509D90 VA: 0x18050AB90
	internal static void OnRejectRequestToJoinCallbackInternalImplementation(ref RejectRequestToJoinCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnRequestToJoinAcceptedCallbackInternal))]
	// RVA: 0x50AC40 Offset: 0x509E40 VA: 0x18050AC40
	internal static void OnRequestToJoinAcceptedCallbackInternalImplementation(ref OnRequestToJoinAcceptedCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnRequestToJoinReceivedCallbackInternal))]
	// RVA: 0x50ACF0 Offset: 0x509EF0 VA: 0x18050ACF0
	internal static void OnRequestToJoinReceivedCallbackInternalImplementation(ref RequestToJoinReceivedCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnRequestToJoinRejectedCallbackInternal))]
	// RVA: 0x50ADA0 Offset: 0x509FA0 VA: 0x18050ADA0
	internal static void OnRequestToJoinRejectedCallbackInternalImplementation(ref OnRequestToJoinRejectedCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnRequestToJoinResponseReceivedCallbackInternal))]
	// RVA: 0x50AE50 Offset: 0x50A050 VA: 0x18050AE50
	internal static void OnRequestToJoinResponseReceivedCallbackInternalImplementation(ref RequestToJoinResponseReceivedCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnSendCustomInviteCallbackInternal))]
	// RVA: 0x50AF00 Offset: 0x50A100 VA: 0x18050AF00
	internal static void OnSendCustomInviteCallbackInternalImplementation(ref SendCustomInviteCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnSendCustomNativeInviteRequestedCallbackInternal))]
	// RVA: 0x50AFB0 Offset: 0x50A1B0 VA: 0x18050AFB0
	internal static void OnSendCustomNativeInviteRequestedCallbackInternalImplementation(ref SendCustomNativeInviteRequestedCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnSendRequestToJoinCallbackInternal))]
	// RVA: 0x50B060 Offset: 0x50A260 VA: 0x18050B060
	internal static void OnSendRequestToJoinCallbackInternalImplementation(ref SendRequestToJoinCallbackInfoInternal data) { }
}

// Namespace: Epic.OnlineServices.CustomInvites
public struct FinalizeInviteOptions // TypeDefIndex: 9778
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <TargetUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x8
	[CompilerGenerated]
	private Utf8String <CustomInviteId>k__BackingField; // 0x10
	[CompilerGenerated]
	private Result <ProcessingResult>k__BackingField; // 0x18

	// Properties
	public ProductUserId TargetUserId { get; set; }
	public ProductUserId LocalUserId { get; set; }
	public Utf8String CustomInviteId { get; set; }
	public Result ProcessingResult { get; set; }

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
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_LocalUserId(ProductUserId value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Utf8String get_CustomInviteId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_CustomInviteId(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public Result get_ProcessingResult() { }

	[CompilerGenerated]
	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	public void set_ProcessingResult(Result value) { }
}

// Namespace: Epic.OnlineServices.CustomInvites
internal struct FinalizeInviteOptionsInternal : ISettable<FinalizeInviteOptions>, IDisposable // TypeDefIndex: 9779
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_TargetUserId; // 0x8
	private IntPtr m_LocalUserId; // 0x10
	private IntPtr m_CustomInviteId; // 0x18
	private Result m_ProcessingResult; // 0x20

	// Properties
	public ProductUserId TargetUserId { set; }
	public ProductUserId LocalUserId { set; }
	public Utf8String CustomInviteId { set; }
	public Result ProcessingResult { set; }

	// Methods

	// RVA: 0x50C9F0 Offset: 0x50BBF0 VA: 0x18050C9F0
	public void set_TargetUserId(ProductUserId value) { }

	// RVA: 0x50C990 Offset: 0x50BB90 VA: 0x18050C990
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x50C930 Offset: 0x50BB30 VA: 0x18050C930
	public void set_CustomInviteId(Utf8String value) { }

	// RVA: 0x3DA420 Offset: 0x3D9620 VA: 0x1803DA420
	public void set_ProcessingResult(Result value) { }

	// RVA: 0x50C6C0 Offset: 0x50B8C0 VA: 0x18050C6C0 Slot: 4
	public void Set(ref FinalizeInviteOptions other) { }

	// RVA: 0x50C7C0 Offset: 0x50B9C0 VA: 0x18050C7C0 Slot: 5
	public void Set(ref Nullable<FinalizeInviteOptions> other) { }

	// RVA: 0x50C660 Offset: 0x50B860 VA: 0x18050C660 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.CustomInvites
public sealed class OnAcceptRequestToJoinCallback : MulticastDelegate // TypeDefIndex: 9780
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref AcceptRequestToJoinCallbackInfo data) { }

	// RVA: 0x50FC20 Offset: 0x50EE20 VA: 0x18050FC20 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref AcceptRequestToJoinCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref AcceptRequestToJoinCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.CustomInvites
[UnmanagedFunctionPointer(2)]
internal sealed class OnAcceptRequestToJoinCallbackInternal : MulticastDelegate // TypeDefIndex: 9781
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref AcceptRequestToJoinCallbackInfoInternal data) { }

	// RVA: 0x50FB90 Offset: 0x50ED90 VA: 0x18050FB90 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref AcceptRequestToJoinCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref AcceptRequestToJoinCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.CustomInvites
public sealed class OnCustomInviteAcceptedCallback : MulticastDelegate // TypeDefIndex: 9782
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref OnCustomInviteAcceptedCallbackInfo data) { }

	// RVA: 0x510B70 Offset: 0x50FD70 VA: 0x180510B70 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref OnCustomInviteAcceptedCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref OnCustomInviteAcceptedCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.CustomInvites
[UnmanagedFunctionPointer(2)]
internal sealed class OnCustomInviteAcceptedCallbackInternal : MulticastDelegate // TypeDefIndex: 9783
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref OnCustomInviteAcceptedCallbackInfoInternal data) { }

	// RVA: 0x510AE0 Offset: 0x50FCE0 VA: 0x180510AE0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref OnCustomInviteAcceptedCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref OnCustomInviteAcceptedCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.CustomInvites
public struct OnCustomInviteAcceptedCallbackInfo : ICallbackInfo // TypeDefIndex: 9784
{
	// Fields
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x0
	[CompilerGenerated]
	private ProductUserId <TargetUserId>k__BackingField; // 0x8
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x10
	[CompilerGenerated]
	private Utf8String <CustomInviteId>k__BackingField; // 0x18
	[CompilerGenerated]
	private Utf8String <Payload>k__BackingField; // 0x20

	// Properties
	public object ClientData { get; set; }
	public ProductUserId TargetUserId { get; set; }
	public ProductUserId LocalUserId { get; set; }
	public Utf8String CustomInviteId { get; set; }
	public Utf8String Payload { get; set; }

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
	public ProductUserId get_TargetUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_TargetUserId(ProductUserId value) { }

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
	public Utf8String get_CustomInviteId() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_CustomInviteId(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public Utf8String get_Payload() { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_Payload(Utf8String value) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x510990 Offset: 0x50FB90 VA: 0x180510990
	internal void Set(ref OnCustomInviteAcceptedCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.CustomInvites
internal struct OnCustomInviteAcceptedCallbackInfoInternal : ICallbackInfoInternal, IGettable<OnCustomInviteAcceptedCallbackInfo>, ISettable<OnCustomInviteAcceptedCallbackInfo>, IDisposable // TypeDefIndex: 9785
{
	// Fields
	private IntPtr m_ClientData; // 0x0
	private IntPtr m_TargetUserId; // 0x8
	private IntPtr m_LocalUserId; // 0x10
	private IntPtr m_CustomInviteId; // 0x18
	private IntPtr m_Payload; // 0x20

	// Properties
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public ProductUserId TargetUserId { get; set; }
	public ProductUserId LocalUserId { get; set; }
	public Utf8String CustomInviteId { get; set; }
	public Utf8String Payload { get; set; }

	// Methods

	// RVA: 0x510560 Offset: 0x50F760 VA: 0x180510560
	public object get_ClientData() { }

	// RVA: 0x5107B0 Offset: 0x50F9B0 VA: 0x1805107B0
	public void set_ClientData(object value) { }

	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x510730 Offset: 0x50F930 VA: 0x180510730
	public ProductUserId get_TargetUserId() { }

	// RVA: 0x510930 Offset: 0x50FB30 VA: 0x180510930
	public void set_TargetUserId(ProductUserId value) { }

	// RVA: 0x510640 Offset: 0x50F840 VA: 0x180510640
	public ProductUserId get_LocalUserId() { }

	// RVA: 0x510870 Offset: 0x50FA70 VA: 0x180510870
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x5105D0 Offset: 0x50F7D0 VA: 0x1805105D0
	public Utf8String get_CustomInviteId() { }

	// RVA: 0x510810 Offset: 0x50FA10 VA: 0x180510810
	public void set_CustomInviteId(Utf8String value) { }

	// RVA: 0x5106C0 Offset: 0x50F8C0 VA: 0x1805106C0
	public Utf8String get_Payload() { }

	// RVA: 0x5108D0 Offset: 0x50FAD0 VA: 0x1805108D0
	public void set_Payload(Utf8String value) { }

	// RVA: 0x5103E0 Offset: 0x50F5E0 VA: 0x1805103E0 Slot: 6
	public void Set(ref OnCustomInviteAcceptedCallbackInfo other) { }

	// RVA: 0x5101E0 Offset: 0x50F3E0 VA: 0x1805101E0 Slot: 7
	public void Set(ref Nullable<OnCustomInviteAcceptedCallbackInfo> other) { }

	// RVA: 0x510130 Offset: 0x50F330 VA: 0x180510130 Slot: 8
	public void Dispose() { }

	// RVA: 0x5101B0 Offset: 0x50F3B0 VA: 0x1805101B0 Slot: 5
	public void Get(out OnCustomInviteAcceptedCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.CustomInvites
public sealed class OnCustomInviteReceivedCallback : MulticastDelegate // TypeDefIndex: 9786
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref OnCustomInviteReceivedCallbackInfo data) { }

	// RVA: 0x511640 Offset: 0x510840 VA: 0x180511640 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref OnCustomInviteReceivedCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref OnCustomInviteReceivedCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.CustomInvites
[UnmanagedFunctionPointer(2)]
internal sealed class OnCustomInviteReceivedCallbackInternal : MulticastDelegate // TypeDefIndex: 9787
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref OnCustomInviteReceivedCallbackInfoInternal data) { }

	// RVA: 0x5115B0 Offset: 0x5107B0 VA: 0x1805115B0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref OnCustomInviteReceivedCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref OnCustomInviteReceivedCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.CustomInvites
public struct OnCustomInviteReceivedCallbackInfo : ICallbackInfo // TypeDefIndex: 9788
{
	// Fields
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x0
	[CompilerGenerated]
	private ProductUserId <TargetUserId>k__BackingField; // 0x8
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x10
	[CompilerGenerated]
	private Utf8String <CustomInviteId>k__BackingField; // 0x18
	[CompilerGenerated]
	private Utf8String <Payload>k__BackingField; // 0x20

	// Properties
	public object ClientData { get; set; }
	public ProductUserId TargetUserId { get; set; }
	public ProductUserId LocalUserId { get; set; }
	public Utf8String CustomInviteId { get; set; }
	public Utf8String Payload { get; set; }

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
	public ProductUserId get_TargetUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_TargetUserId(ProductUserId value) { }

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
	public Utf8String get_CustomInviteId() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_CustomInviteId(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public Utf8String get_Payload() { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_Payload(Utf8String value) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x511460 Offset: 0x510660 VA: 0x180511460
	internal void Set(ref OnCustomInviteReceivedCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.CustomInvites
internal struct OnCustomInviteReceivedCallbackInfoInternal : ICallbackInfoInternal, IGettable<OnCustomInviteReceivedCallbackInfo>, ISettable<OnCustomInviteReceivedCallbackInfo>, IDisposable // TypeDefIndex: 9789
{
	// Fields
	private IntPtr m_ClientData; // 0x0
	private IntPtr m_TargetUserId; // 0x8
	private IntPtr m_LocalUserId; // 0x10
	private IntPtr m_CustomInviteId; // 0x18
	private IntPtr m_Payload; // 0x20

	// Properties
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public ProductUserId TargetUserId { get; set; }
	public ProductUserId LocalUserId { get; set; }
	public Utf8String CustomInviteId { get; set; }
	public Utf8String Payload { get; set; }

	// Methods

	// RVA: 0x511030 Offset: 0x510230 VA: 0x180511030
	public object get_ClientData() { }

	// RVA: 0x511280 Offset: 0x510480 VA: 0x180511280
	public void set_ClientData(object value) { }

	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x511200 Offset: 0x510400 VA: 0x180511200
	public ProductUserId get_TargetUserId() { }

	// RVA: 0x511400 Offset: 0x510600 VA: 0x180511400
	public void set_TargetUserId(ProductUserId value) { }

	// RVA: 0x511110 Offset: 0x510310 VA: 0x180511110
	public ProductUserId get_LocalUserId() { }

	// RVA: 0x511340 Offset: 0x510540 VA: 0x180511340
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x5110A0 Offset: 0x5102A0 VA: 0x1805110A0
	public Utf8String get_CustomInviteId() { }

	// RVA: 0x5112E0 Offset: 0x5104E0 VA: 0x1805112E0
	public void set_CustomInviteId(Utf8String value) { }

	// RVA: 0x511190 Offset: 0x510390 VA: 0x180511190
	public Utf8String get_Payload() { }

	// RVA: 0x5113A0 Offset: 0x5105A0 VA: 0x1805113A0
	public void set_Payload(Utf8String value) { }

	// RVA: 0x510CB0 Offset: 0x50FEB0 VA: 0x180510CB0 Slot: 6
	public void Set(ref OnCustomInviteReceivedCallbackInfo other) { }

	// RVA: 0x510E30 Offset: 0x510030 VA: 0x180510E30 Slot: 7
	public void Set(ref Nullable<OnCustomInviteReceivedCallbackInfo> other) { }

	// RVA: 0x510C00 Offset: 0x50FE00 VA: 0x180510C00 Slot: 8
	public void Dispose() { }

	// RVA: 0x510C80 Offset: 0x50FE80 VA: 0x180510C80 Slot: 5
	public void Get(out OnCustomInviteReceivedCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.CustomInvites
public sealed class OnCustomInviteRejectedCallback : MulticastDelegate // TypeDefIndex: 9790
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref CustomInviteRejectedCallbackInfo data) { }

	// RVA: 0x511760 Offset: 0x510960 VA: 0x180511760 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref CustomInviteRejectedCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref CustomInviteRejectedCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.CustomInvites
[UnmanagedFunctionPointer(2)]
internal sealed class OnCustomInviteRejectedCallbackInternal : MulticastDelegate // TypeDefIndex: 9791
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref CustomInviteRejectedCallbackInfoInternal data) { }

	// RVA: 0x5116D0 Offset: 0x5108D0 VA: 0x1805116D0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref CustomInviteRejectedCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref CustomInviteRejectedCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.CustomInvites
public sealed class OnRejectRequestToJoinCallback : MulticastDelegate // TypeDefIndex: 9792
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref RejectRequestToJoinCallbackInfo data) { }

	// RVA: 0x5127B0 Offset: 0x5119B0 VA: 0x1805127B0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref RejectRequestToJoinCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref RejectRequestToJoinCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.CustomInvites
[UnmanagedFunctionPointer(2)]
internal sealed class OnRejectRequestToJoinCallbackInternal : MulticastDelegate // TypeDefIndex: 9793
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref RejectRequestToJoinCallbackInfoInternal data) { }

	// RVA: 0x512720 Offset: 0x511920 VA: 0x180512720 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref RejectRequestToJoinCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref RejectRequestToJoinCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.CustomInvites
public sealed class OnRequestToJoinAcceptedCallback : MulticastDelegate // TypeDefIndex: 9794
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref OnRequestToJoinAcceptedCallbackInfo data) { }

	// RVA: 0x512EC0 Offset: 0x5120C0 VA: 0x180512EC0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref OnRequestToJoinAcceptedCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref OnRequestToJoinAcceptedCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.CustomInvites
[UnmanagedFunctionPointer(2)]
internal sealed class OnRequestToJoinAcceptedCallbackInternal : MulticastDelegate // TypeDefIndex: 9795
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref OnRequestToJoinAcceptedCallbackInfoInternal data) { }

	// RVA: 0x512E30 Offset: 0x512030 VA: 0x180512E30 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref OnRequestToJoinAcceptedCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref OnRequestToJoinAcceptedCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.CustomInvites
public struct OnRequestToJoinAcceptedCallbackInfo : ICallbackInfo // TypeDefIndex: 9796
{
	// Fields
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x0
	[CompilerGenerated]
	private ProductUserId <TargetUserId>k__BackingField; // 0x8
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x10

	// Properties
	public object ClientData { get; set; }
	public ProductUserId TargetUserId { get; set; }
	public ProductUserId LocalUserId { get; set; }

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
	public ProductUserId get_TargetUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_TargetUserId(ProductUserId value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x512D90 Offset: 0x511F90 VA: 0x180512D90
	internal void Set(ref OnRequestToJoinAcceptedCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.CustomInvites
internal struct OnRequestToJoinAcceptedCallbackInfoInternal : ICallbackInfoInternal, IGettable<OnRequestToJoinAcceptedCallbackInfo>, ISettable<OnRequestToJoinAcceptedCallbackInfo>, IDisposable // TypeDefIndex: 9797
{
	// Fields
	private IntPtr m_ClientData; // 0x0
	private IntPtr m_TargetUserId; // 0x8
	private IntPtr m_LocalUserId; // 0x10

	// Properties
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public ProductUserId TargetUserId { get; set; }
	public ProductUserId LocalUserId { get; set; }

	// Methods

	// RVA: 0x512B00 Offset: 0x511D00 VA: 0x180512B00
	public object get_ClientData() { }

	// RVA: 0x512C70 Offset: 0x511E70 VA: 0x180512C70
	public void set_ClientData(object value) { }

	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x512BF0 Offset: 0x511DF0 VA: 0x180512BF0
	public ProductUserId get_TargetUserId() { }

	// RVA: 0x512D30 Offset: 0x511F30 VA: 0x180512D30
	public void set_TargetUserId(ProductUserId value) { }

	// RVA: 0x512B70 Offset: 0x511D70 VA: 0x180512B70
	public ProductUserId get_LocalUserId() { }

	// RVA: 0x512CD0 Offset: 0x511ED0 VA: 0x180512CD0
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x512A10 Offset: 0x511C10 VA: 0x180512A10 Slot: 6
	public void Set(ref OnRequestToJoinAcceptedCallbackInfo other) { }

	// RVA: 0x5128C0 Offset: 0x511AC0 VA: 0x1805128C0 Slot: 7
	public void Set(ref Nullable<OnRequestToJoinAcceptedCallbackInfo> other) { }

	// RVA: 0x512840 Offset: 0x511A40 VA: 0x180512840 Slot: 8
	public void Dispose() { }

	// RVA: 0x5128A0 Offset: 0x511AA0 VA: 0x1805128A0 Slot: 5
	public void Get(out OnRequestToJoinAcceptedCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.CustomInvites
public sealed class OnRequestToJoinReceivedCallback : MulticastDelegate // TypeDefIndex: 9798
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref RequestToJoinReceivedCallbackInfo data) { }

	// RVA: 0x512FE0 Offset: 0x5121E0 VA: 0x180512FE0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref RequestToJoinReceivedCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref RequestToJoinReceivedCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.CustomInvites
[UnmanagedFunctionPointer(2)]
internal sealed class OnRequestToJoinReceivedCallbackInternal : MulticastDelegate // TypeDefIndex: 9799
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref RequestToJoinReceivedCallbackInfoInternal data) { }

	// RVA: 0x512F50 Offset: 0x512150 VA: 0x180512F50 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref RequestToJoinReceivedCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref RequestToJoinReceivedCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.CustomInvites
public sealed class OnRequestToJoinRejectedCallback : MulticastDelegate // TypeDefIndex: 9800
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref OnRequestToJoinRejectedCallbackInfo data) { }

	// RVA: 0x5136F0 Offset: 0x5128F0 VA: 0x1805136F0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref OnRequestToJoinRejectedCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref OnRequestToJoinRejectedCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.CustomInvites
[UnmanagedFunctionPointer(2)]
internal sealed class OnRequestToJoinRejectedCallbackInternal : MulticastDelegate // TypeDefIndex: 9801
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref OnRequestToJoinRejectedCallbackInfoInternal data) { }

	// RVA: 0x513660 Offset: 0x512860 VA: 0x180513660 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref OnRequestToJoinRejectedCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref OnRequestToJoinRejectedCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.CustomInvites
public struct OnRequestToJoinRejectedCallbackInfo : ICallbackInfo // TypeDefIndex: 9802
{
	// Fields
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x0
	[CompilerGenerated]
	private ProductUserId <TargetUserId>k__BackingField; // 0x8
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x10

	// Properties
	public object ClientData { get; set; }
	public ProductUserId TargetUserId { get; set; }
	public ProductUserId LocalUserId { get; set; }

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
	public ProductUserId get_TargetUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_TargetUserId(ProductUserId value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x5135C0 Offset: 0x5127C0 VA: 0x1805135C0
	internal void Set(ref OnRequestToJoinRejectedCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.CustomInvites
internal struct OnRequestToJoinRejectedCallbackInfoInternal : ICallbackInfoInternal, IGettable<OnRequestToJoinRejectedCallbackInfo>, ISettable<OnRequestToJoinRejectedCallbackInfo>, IDisposable // TypeDefIndex: 9803
{
	// Fields
	private IntPtr m_ClientData; // 0x0
	private IntPtr m_TargetUserId; // 0x8
	private IntPtr m_LocalUserId; // 0x10

	// Properties
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public ProductUserId TargetUserId { get; set; }
	public ProductUserId LocalUserId { get; set; }

	// Methods

	// RVA: 0x513330 Offset: 0x512530 VA: 0x180513330
	public object get_ClientData() { }

	// RVA: 0x5134A0 Offset: 0x5126A0 VA: 0x1805134A0
	public void set_ClientData(object value) { }

	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x513420 Offset: 0x512620 VA: 0x180513420
	public ProductUserId get_TargetUserId() { }

	// RVA: 0x513560 Offset: 0x512760 VA: 0x180513560
	public void set_TargetUserId(ProductUserId value) { }

	// RVA: 0x5133A0 Offset: 0x5125A0 VA: 0x1805133A0
	public ProductUserId get_LocalUserId() { }

	// RVA: 0x513500 Offset: 0x512700 VA: 0x180513500
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x5130F0 Offset: 0x5122F0 VA: 0x1805130F0 Slot: 6
	public void Set(ref OnRequestToJoinRejectedCallbackInfo other) { }

	// RVA: 0x5131E0 Offset: 0x5123E0 VA: 0x1805131E0 Slot: 7
	public void Set(ref Nullable<OnRequestToJoinRejectedCallbackInfo> other) { }

	// RVA: 0x513070 Offset: 0x512270 VA: 0x180513070 Slot: 8
	public void Dispose() { }

	// RVA: 0x5130D0 Offset: 0x5122D0 VA: 0x1805130D0 Slot: 5
	public void Get(out OnRequestToJoinRejectedCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.CustomInvites
public sealed class OnRequestToJoinResponseReceivedCallback : MulticastDelegate // TypeDefIndex: 9804
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref RequestToJoinResponseReceivedCallbackInfo data) { }

	// RVA: 0x513810 Offset: 0x512A10 VA: 0x180513810 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref RequestToJoinResponseReceivedCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref RequestToJoinResponseReceivedCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.CustomInvites
[UnmanagedFunctionPointer(2)]
internal sealed class OnRequestToJoinResponseReceivedCallbackInternal : MulticastDelegate // TypeDefIndex: 9805
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref RequestToJoinResponseReceivedCallbackInfoInternal data) { }

	// RVA: 0x513780 Offset: 0x512980 VA: 0x180513780 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref RequestToJoinResponseReceivedCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref RequestToJoinResponseReceivedCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.CustomInvites
public sealed class OnSendCustomInviteCallback : MulticastDelegate // TypeDefIndex: 9806
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref SendCustomInviteCallbackInfo data) { }

	// RVA: 0x513930 Offset: 0x512B30 VA: 0x180513930 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref SendCustomInviteCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref SendCustomInviteCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.CustomInvites
[UnmanagedFunctionPointer(2)]
internal sealed class OnSendCustomInviteCallbackInternal : MulticastDelegate // TypeDefIndex: 9807
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref SendCustomInviteCallbackInfoInternal data) { }

	// RVA: 0x5138A0 Offset: 0x512AA0 VA: 0x1805138A0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref SendCustomInviteCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref SendCustomInviteCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.CustomInvites
public sealed class OnSendCustomNativeInviteRequestedCallback : MulticastDelegate // TypeDefIndex: 9808
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref SendCustomNativeInviteRequestedCallbackInfo data) { }

	// RVA: 0x513A50 Offset: 0x512C50 VA: 0x180513A50 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref SendCustomNativeInviteRequestedCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref SendCustomNativeInviteRequestedCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.CustomInvites
[UnmanagedFunctionPointer(2)]
internal sealed class OnSendCustomNativeInviteRequestedCallbackInternal : MulticastDelegate // TypeDefIndex: 9809
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref SendCustomNativeInviteRequestedCallbackInfoInternal data) { }

	// RVA: 0x5139C0 Offset: 0x512BC0 VA: 0x1805139C0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref SendCustomNativeInviteRequestedCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref SendCustomNativeInviteRequestedCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.CustomInvites
public sealed class OnSendRequestToJoinCallback : MulticastDelegate // TypeDefIndex: 9810
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref SendRequestToJoinCallbackInfo data) { }

	// RVA: 0x513B70 Offset: 0x512D70 VA: 0x180513B70 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref SendRequestToJoinCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref SendRequestToJoinCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.CustomInvites
[UnmanagedFunctionPointer(2)]
internal sealed class OnSendRequestToJoinCallbackInternal : MulticastDelegate // TypeDefIndex: 9811
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref SendRequestToJoinCallbackInfoInternal data) { }

	// RVA: 0x513AE0 Offset: 0x512CE0 VA: 0x180513AE0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref SendRequestToJoinCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref SendRequestToJoinCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.CustomInvites
public struct RejectRequestToJoinCallbackInfo : ICallbackInfo // TypeDefIndex: 9812
{
	// Fields
	[CompilerGenerated]
	private Result <ResultCode>k__BackingField; // 0x0
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x8
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x10
	[CompilerGenerated]
	private ProductUserId <TargetUserId>k__BackingField; // 0x18

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public ProductUserId LocalUserId { get; set; }
	public ProductUserId TargetUserId { get; set; }

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

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public ProductUserId get_TargetUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_TargetUserId(ProductUserId value) { }

	// RVA: 0x518150 Offset: 0x517350 VA: 0x180518150 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x5181A0 Offset: 0x5173A0 VA: 0x1805181A0
	internal void Set(ref RejectRequestToJoinCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.CustomInvites
internal struct RejectRequestToJoinCallbackInfoInternal : ICallbackInfoInternal, IGettable<RejectRequestToJoinCallbackInfo>, ISettable<RejectRequestToJoinCallbackInfo>, IDisposable // TypeDefIndex: 9813
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
	public ProductUserId LocalUserId { get; set; }
	public ProductUserId TargetUserId { get; set; }

	// Methods

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	// RVA: 0x517EC0 Offset: 0x5170C0 VA: 0x180517EC0
	public object get_ClientData() { }

	// RVA: 0x518030 Offset: 0x517230 VA: 0x180518030
	public void set_ClientData(object value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x517F30 Offset: 0x517130 VA: 0x180517F30
	public ProductUserId get_LocalUserId() { }

	// RVA: 0x518090 Offset: 0x517290 VA: 0x180518090
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x517FB0 Offset: 0x5171B0 VA: 0x180517FB0
	public ProductUserId get_TargetUserId() { }

	// RVA: 0x5180F0 Offset: 0x5172F0 VA: 0x1805180F0
	public void set_TargetUserId(ProductUserId value) { }

	// RVA: 0x517DC0 Offset: 0x516FC0 VA: 0x180517DC0 Slot: 6
	public void Set(ref RejectRequestToJoinCallbackInfo other) { }

	// RVA: 0x517C50 Offset: 0x516E50 VA: 0x180517C50 Slot: 7
	public void Set(ref Nullable<RejectRequestToJoinCallbackInfo> other) { }

	// RVA: 0x517BD0 Offset: 0x516DD0 VA: 0x180517BD0 Slot: 8
	public void Dispose() { }

	// RVA: 0x517C30 Offset: 0x516E30 VA: 0x180517C30 Slot: 5
	public void Get(out RejectRequestToJoinCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.CustomInvites
public struct RejectRequestToJoinOptions // TypeDefIndex: 9814
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private ProductUserId <TargetUserId>k__BackingField; // 0x8

	// Properties
	public ProductUserId LocalUserId { get; set; }
	public ProductUserId TargetUserId { get; set; }

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
	public ProductUserId get_TargetUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_TargetUserId(ProductUserId value) { }
}

// Namespace: Epic.OnlineServices.CustomInvites
internal struct RejectRequestToJoinOptionsInternal : ISettable<RejectRequestToJoinOptions>, IDisposable // TypeDefIndex: 9815
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_TargetUserId; // 0x10

	// Properties
	public ProductUserId LocalUserId { set; }
	public ProductUserId TargetUserId { set; }

	// Methods

	// RVA: 0x518460 Offset: 0x517660 VA: 0x180518460
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x5184C0 Offset: 0x5176C0 VA: 0x1805184C0
	public void set_TargetUserId(ProductUserId value) { }

	// RVA: 0x5182A0 Offset: 0x5174A0 VA: 0x1805182A0 Slot: 4
	public void Set(ref RejectRequestToJoinOptions other) { }

	// RVA: 0x518360 Offset: 0x517560 VA: 0x180518360 Slot: 5
	public void Set(ref Nullable<RejectRequestToJoinOptions> other) { }

	// RVA: 0x518240 Offset: 0x517440 VA: 0x180518240 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.CustomInvites
public struct RequestToJoinReceivedCallbackInfo : ICallbackInfo // TypeDefIndex: 9816
{
	// Fields
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x0
	[CompilerGenerated]
	private ProductUserId <FromUserId>k__BackingField; // 0x8
	[CompilerGenerated]
	private ProductUserId <ToUserId>k__BackingField; // 0x10

	// Properties
	public object ClientData { get; set; }
	public ProductUserId FromUserId { get; set; }
	public ProductUserId ToUserId { get; set; }

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
	public ProductUserId get_FromUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_FromUserId(ProductUserId value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public ProductUserId get_ToUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_ToUserId(ProductUserId value) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x518A70 Offset: 0x517C70 VA: 0x180518A70
	internal void Set(ref RequestToJoinReceivedCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.CustomInvites
internal struct RequestToJoinReceivedCallbackInfoInternal : ICallbackInfoInternal, IGettable<RequestToJoinReceivedCallbackInfo>, ISettable<RequestToJoinReceivedCallbackInfo>, IDisposable // TypeDefIndex: 9817
{
	// Fields
	private IntPtr m_ClientData; // 0x0
	private IntPtr m_FromUserId; // 0x8
	private IntPtr m_ToUserId; // 0x10

	// Properties
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public ProductUserId FromUserId { get; set; }
	public ProductUserId ToUserId { get; set; }

	// Methods

	// RVA: 0x5187E0 Offset: 0x5179E0 VA: 0x1805187E0
	public object get_ClientData() { }

	// RVA: 0x518950 Offset: 0x517B50 VA: 0x180518950
	public void set_ClientData(object value) { }

	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x518850 Offset: 0x517A50 VA: 0x180518850
	public ProductUserId get_FromUserId() { }

	// RVA: 0x5189B0 Offset: 0x517BB0 VA: 0x1805189B0
	public void set_FromUserId(ProductUserId value) { }

	// RVA: 0x5188D0 Offset: 0x517AD0 VA: 0x1805188D0
	public ProductUserId get_ToUserId() { }

	// RVA: 0x518A10 Offset: 0x517C10 VA: 0x180518A10
	public void set_ToUserId(ProductUserId value) { }

	// RVA: 0x5186F0 Offset: 0x5178F0 VA: 0x1805186F0 Slot: 6
	public void Set(ref RequestToJoinReceivedCallbackInfo other) { }

	// RVA: 0x5185A0 Offset: 0x5177A0 VA: 0x1805185A0 Slot: 7
	public void Set(ref Nullable<RequestToJoinReceivedCallbackInfo> other) { }

	// RVA: 0x518520 Offset: 0x517720 VA: 0x180518520 Slot: 8
	public void Dispose() { }

	// RVA: 0x518580 Offset: 0x517780 VA: 0x180518580 Slot: 5
	public void Get(out RequestToJoinReceivedCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.CustomInvites
public enum RequestToJoinResponse // TypeDefIndex: 9818
{
	// Fields
	public int value__; // 0x0
	public const RequestToJoinResponse Accepted = 0;
	public const RequestToJoinResponse Rejected = 1;
}

// Namespace: Epic.OnlineServices.CustomInvites
public struct RequestToJoinResponseReceivedCallbackInfo : ICallbackInfo // TypeDefIndex: 9819
{
	// Fields
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x0
	[CompilerGenerated]
	private ProductUserId <FromUserId>k__BackingField; // 0x8
	[CompilerGenerated]
	private ProductUserId <ToUserId>k__BackingField; // 0x10
	[CompilerGenerated]
	private RequestToJoinResponse <Response>k__BackingField; // 0x18

	// Properties
	public object ClientData { get; set; }
	public ProductUserId FromUserId { get; set; }
	public ProductUserId ToUserId { get; set; }
	public RequestToJoinResponse Response { get; set; }

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
	public ProductUserId get_FromUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_FromUserId(ProductUserId value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public ProductUserId get_ToUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_ToUserId(ProductUserId value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public RequestToJoinResponse get_Response() { }

	[CompilerGenerated]
	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	public void set_Response(RequestToJoinResponse value) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x519090 Offset: 0x518290 VA: 0x180519090
	internal void Set(ref RequestToJoinResponseReceivedCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.CustomInvites
internal struct RequestToJoinResponseReceivedCallbackInfoInternal : ICallbackInfoInternal, IGettable<RequestToJoinResponseReceivedCallbackInfo>, ISettable<RequestToJoinResponseReceivedCallbackInfo>, IDisposable // TypeDefIndex: 9820
{
	// Fields
	private IntPtr m_ClientData; // 0x0
	private IntPtr m_FromUserId; // 0x8
	private IntPtr m_ToUserId; // 0x10
	private RequestToJoinResponse m_Response; // 0x18

	// Properties
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public ProductUserId FromUserId { get; set; }
	public ProductUserId ToUserId { get; set; }
	public RequestToJoinResponse Response { get; set; }

	// Methods

	// RVA: 0x518E00 Offset: 0x518000 VA: 0x180518E00
	public object get_ClientData() { }

	// RVA: 0x518F70 Offset: 0x518170 VA: 0x180518F70
	public void set_ClientData(object value) { }

	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x518E70 Offset: 0x518070 VA: 0x180518E70
	public ProductUserId get_FromUserId() { }

	// RVA: 0x518FD0 Offset: 0x5181D0 VA: 0x180518FD0
	public void set_FromUserId(ProductUserId value) { }

	// RVA: 0x518EF0 Offset: 0x5180F0 VA: 0x180518EF0
	public ProductUserId get_ToUserId() { }

	// RVA: 0x519030 Offset: 0x518230 VA: 0x180519030
	public void set_ToUserId(ProductUserId value) { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public RequestToJoinResponse get_Response() { }

	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	public void set_Response(RequestToJoinResponse value) { }

	// RVA: 0x518D00 Offset: 0x517F00 VA: 0x180518D00 Slot: 6
	public void Set(ref RequestToJoinResponseReceivedCallbackInfo other) { }

	// RVA: 0x518B90 Offset: 0x517D90 VA: 0x180518B90 Slot: 7
	public void Set(ref Nullable<RequestToJoinResponseReceivedCallbackInfo> other) { }

	// RVA: 0x518B10 Offset: 0x517D10 VA: 0x180518B10 Slot: 8
	public void Dispose() { }

	// RVA: 0x518B70 Offset: 0x517D70 VA: 0x180518B70 Slot: 5
	public void Get(out RequestToJoinResponseReceivedCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.CustomInvites
public struct SendCustomInviteCallbackInfo : ICallbackInfo // TypeDefIndex: 9821
{
	// Fields
	[CompilerGenerated]
	private Result <ResultCode>k__BackingField; // 0x0
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x8
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x10
	[CompilerGenerated]
	private ProductUserId[] <TargetUserIds>k__BackingField; // 0x18

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public ProductUserId LocalUserId { get; set; }
	public ProductUserId[] TargetUserIds { get; set; }

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

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public ProductUserId[] get_TargetUserIds() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_TargetUserIds(ProductUserId[] value) { }

	// RVA: 0x519B20 Offset: 0x518D20 VA: 0x180519B20 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x519B70 Offset: 0x518D70 VA: 0x180519B70
	internal void Set(ref SendCustomInviteCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.CustomInvites
internal struct SendCustomInviteCallbackInfoInternal : ICallbackInfoInternal, IGettable<SendCustomInviteCallbackInfo>, ISettable<SendCustomInviteCallbackInfo>, IDisposable // TypeDefIndex: 9822
{
	// Fields
	private Result m_ResultCode; // 0x0
	private IntPtr m_ClientData; // 0x8
	private IntPtr m_LocalUserId; // 0x10
	private IntPtr m_TargetUserIds; // 0x18
	private uint m_TargetUserIdsCount; // 0x20

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public ProductUserId LocalUserId { get; set; }
	public ProductUserId[] TargetUserIds { get; set; }

	// Methods

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	// RVA: 0x519870 Offset: 0x518A70 VA: 0x180519870
	public object get_ClientData() { }

	// RVA: 0x5199F0 Offset: 0x518BF0 VA: 0x1805199F0
	public void set_ClientData(object value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x5198E0 Offset: 0x518AE0 VA: 0x1805198E0
	public ProductUserId get_LocalUserId() { }

	// RVA: 0x519A50 Offset: 0x518C50 VA: 0x180519A50
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x519960 Offset: 0x518B60 VA: 0x180519960
	public ProductUserId[] get_TargetUserIds() { }

	// RVA: 0x519AB0 Offset: 0x518CB0 VA: 0x180519AB0
	public void set_TargetUserIds(ProductUserId[] value) { }

	// RVA: 0x519760 Offset: 0x518960 VA: 0x180519760 Slot: 6
	public void Set(ref SendCustomInviteCallbackInfo other) { }

	// RVA: 0x519620 Offset: 0x518820 VA: 0x180519620 Slot: 7
	public void Set(ref Nullable<SendCustomInviteCallbackInfo> other) { }

	// RVA: 0x5195A0 Offset: 0x5187A0 VA: 0x1805195A0 Slot: 8
	public void Dispose() { }

	// RVA: 0x519600 Offset: 0x518800 VA: 0x180519600 Slot: 5
	public void Get(out SendCustomInviteCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.CustomInvites
public struct SendCustomInviteOptions // TypeDefIndex: 9823
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private ProductUserId[] <TargetUserIds>k__BackingField; // 0x8

	// Properties
	public ProductUserId LocalUserId { get; set; }
	public ProductUserId[] TargetUserIds { get; set; }

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
	public ProductUserId[] get_TargetUserIds() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_TargetUserIds(ProductUserId[] value) { }
}

// Namespace: Epic.OnlineServices.CustomInvites
internal struct SendCustomInviteOptionsInternal : ISettable<SendCustomInviteOptions>, IDisposable // TypeDefIndex: 9824
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_TargetUserIds; // 0x10
	private uint m_TargetUserIdsCount; // 0x18

	// Properties
	public ProductUserId LocalUserId { set; }
	public ProductUserId[] TargetUserIds { set; }

	// Methods

	// RVA: 0x519E10 Offset: 0x519010 VA: 0x180519E10
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x519E70 Offset: 0x519070 VA: 0x180519E70
	public void set_TargetUserIds(ProductUserId[] value) { }

	// RVA: 0x519D40 Offset: 0x518F40 VA: 0x180519D40 Slot: 4
	public void Set(ref SendCustomInviteOptions other) { }

	// RVA: 0x519C70 Offset: 0x518E70 VA: 0x180519C70 Slot: 5
	public void Set(ref Nullable<SendCustomInviteOptions> other) { }

	// RVA: 0x519C10 Offset: 0x518E10 VA: 0x180519C10 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.CustomInvites
public struct SendCustomNativeInviteRequestedCallbackInfo : ICallbackInfo // TypeDefIndex: 9825
{
	// Fields
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x0
	[CompilerGenerated]
	private ulong <UiEventId>k__BackingField; // 0x8
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x10
	[CompilerGenerated]
	private Utf8String <TargetNativeAccountType>k__BackingField; // 0x18
	[CompilerGenerated]
	private Utf8String <TargetUserNativeAccountId>k__BackingField; // 0x20
	[CompilerGenerated]
	private Utf8String <InviteId>k__BackingField; // 0x28

	// Properties
	public object ClientData { get; set; }
	public ulong UiEventId { get; set; }
	public ProductUserId LocalUserId { get; set; }
	public Utf8String TargetNativeAccountType { get; set; }
	public Utf8String TargetUserNativeAccountId { get; set; }
	public Utf8String InviteId { get; set; }

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
	public ulong get_UiEventId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_UiEventId(ulong value) { }

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
	public Utf8String get_TargetNativeAccountType() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_TargetNativeAccountType(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public Utf8String get_TargetUserNativeAccountId() { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_TargetUserNativeAccountId(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public Utf8String get_InviteId() { }

	[CompilerGenerated]
	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	public void set_InviteId(Utf8String value) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x51A740 Offset: 0x519940 VA: 0x18051A740
	internal void Set(ref SendCustomNativeInviteRequestedCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.CustomInvites
internal struct SendCustomNativeInviteRequestedCallbackInfoInternal : ICallbackInfoInternal, IGettable<SendCustomNativeInviteRequestedCallbackInfo>, ISettable<SendCustomNativeInviteRequestedCallbackInfo>, IDisposable // TypeDefIndex: 9826
{
	// Fields
	private IntPtr m_ClientData; // 0x0
	private ulong m_UiEventId; // 0x8
	private IntPtr m_LocalUserId; // 0x10
	private IntPtr m_TargetNativeAccountType; // 0x18
	private IntPtr m_TargetUserNativeAccountId; // 0x20
	private IntPtr m_InviteId; // 0x28

	// Properties
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public ulong UiEventId { get; set; }
	public ProductUserId LocalUserId { get; set; }
	public Utf8String TargetNativeAccountType { get; set; }
	public Utf8String TargetUserNativeAccountId { get; set; }
	public Utf8String InviteId { get; set; }

	// Methods

	// RVA: 0x51A320 Offset: 0x519520 VA: 0x18051A320
	public object get_ClientData() { }

	// RVA: 0x51A560 Offset: 0x519760 VA: 0x18051A560
	public void set_ClientData(object value) { }

	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public ulong get_UiEventId() { }

	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_UiEventId(ulong value) { }

	// RVA: 0x51A400 Offset: 0x519600 VA: 0x18051A400
	public ProductUserId get_LocalUserId() { }

	// RVA: 0x51A620 Offset: 0x519820 VA: 0x18051A620
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x51A480 Offset: 0x519680 VA: 0x18051A480
	public Utf8String get_TargetNativeAccountType() { }

	// RVA: 0x51A680 Offset: 0x519880 VA: 0x18051A680
	public void set_TargetNativeAccountType(Utf8String value) { }

	// RVA: 0x51A4F0 Offset: 0x5196F0 VA: 0x18051A4F0
	public Utf8String get_TargetUserNativeAccountId() { }

	// RVA: 0x51A6E0 Offset: 0x5198E0 VA: 0x18051A6E0
	public void set_TargetUserNativeAccountId(Utf8String value) { }

	// RVA: 0x51A390 Offset: 0x519590 VA: 0x18051A390
	public Utf8String get_InviteId() { }

	// RVA: 0x51A5C0 Offset: 0x5197C0 VA: 0x18051A5C0
	public void set_InviteId(Utf8String value) { }

	// RVA: 0x51A1A0 Offset: 0x5193A0 VA: 0x18051A1A0 Slot: 6
	public void Set(ref SendCustomNativeInviteRequestedCallbackInfo other) { }

	// RVA: 0x519F80 Offset: 0x519180 VA: 0x180519F80 Slot: 7
	public void Set(ref Nullable<SendCustomNativeInviteRequestedCallbackInfo> other) { }

	// RVA: 0x519EE0 Offset: 0x5190E0 VA: 0x180519EE0 Slot: 8
	public void Dispose() { }

	// RVA: 0x519F60 Offset: 0x519160 VA: 0x180519F60 Slot: 5
	public void Get(out SendCustomNativeInviteRequestedCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.CustomInvites
public struct SendRequestToJoinCallbackInfo : ICallbackInfo // TypeDefIndex: 9827
{
	// Fields
	[CompilerGenerated]
	private Result <ResultCode>k__BackingField; // 0x0
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x8
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x10
	[CompilerGenerated]
	private ProductUserId <TargetUserId>k__BackingField; // 0x18

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public ProductUserId LocalUserId { get; set; }
	public ProductUserId TargetUserId { get; set; }

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
	public ProductUserId get_TargetUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_TargetUserId(ProductUserId value) { }

	// RVA: 0x51AE50 Offset: 0x51A050 VA: 0x18051AE50 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x51AEA0 Offset: 0x51A0A0 VA: 0x18051AEA0
	internal void Set(ref SendRequestToJoinCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.CustomInvites
internal struct SendRequestToJoinCallbackInfoInternal : ICallbackInfoInternal, IGettable<SendRequestToJoinCallbackInfo>, ISettable<SendRequestToJoinCallbackInfo>, IDisposable // TypeDefIndex: 9828
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
	public ProductUserId LocalUserId { get; set; }
	public ProductUserId TargetUserId { get; set; }

	// Methods

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	// RVA: 0x51ABC0 Offset: 0x519DC0 VA: 0x18051ABC0
	public object get_ClientData() { }

	// RVA: 0x51AD30 Offset: 0x519F30 VA: 0x18051AD30
	public void set_ClientData(object value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x51AC30 Offset: 0x519E30 VA: 0x18051AC30
	public ProductUserId get_LocalUserId() { }

	// RVA: 0x51AD90 Offset: 0x519F90 VA: 0x18051AD90
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x51ACB0 Offset: 0x519EB0 VA: 0x18051ACB0
	public ProductUserId get_TargetUserId() { }

	// RVA: 0x51ADF0 Offset: 0x519FF0 VA: 0x18051ADF0
	public void set_TargetUserId(ProductUserId value) { }

	// RVA: 0x51A950 Offset: 0x519B50 VA: 0x18051A950 Slot: 6
	public void Set(ref SendRequestToJoinCallbackInfo other) { }

	// RVA: 0x51AA50 Offset: 0x519C50 VA: 0x18051AA50 Slot: 7
	public void Set(ref Nullable<SendRequestToJoinCallbackInfo> other) { }

	// RVA: 0x51A8D0 Offset: 0x519AD0 VA: 0x18051A8D0 Slot: 8
	public void Dispose() { }

	// RVA: 0x51A930 Offset: 0x519B30 VA: 0x18051A930 Slot: 5
	public void Get(out SendRequestToJoinCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.CustomInvites
public struct SendRequestToJoinOptions // TypeDefIndex: 9829
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private ProductUserId <TargetUserId>k__BackingField; // 0x8

	// Properties
	public ProductUserId LocalUserId { get; set; }
	public ProductUserId TargetUserId { get; set; }

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
	public ProductUserId get_TargetUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_TargetUserId(ProductUserId value) { }
}

// Namespace: Epic.OnlineServices.CustomInvites
internal struct SendRequestToJoinOptionsInternal : ISettable<SendRequestToJoinOptions>, IDisposable // TypeDefIndex: 9830
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_TargetUserId; // 0x10

	// Properties
	public ProductUserId LocalUserId { set; }
	public ProductUserId TargetUserId { set; }

	// Methods

	// RVA: 0x51B160 Offset: 0x51A360 VA: 0x18051B160
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x51B1C0 Offset: 0x51A3C0 VA: 0x18051B1C0
	public void set_TargetUserId(ProductUserId value) { }

	// RVA: 0x51B0A0 Offset: 0x51A2A0 VA: 0x18051B0A0 Slot: 4
	public void Set(ref SendRequestToJoinOptions other) { }

	// RVA: 0x51AFA0 Offset: 0x51A1A0 VA: 0x18051AFA0 Slot: 5
	public void Set(ref Nullable<SendRequestToJoinOptions> other) { }

	// RVA: 0x51AF40 Offset: 0x51A140 VA: 0x18051AF40 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.CustomInvites
public struct SetCustomInviteOptions // TypeDefIndex: 9831
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <Payload>k__BackingField; // 0x8

	// Properties
	public ProductUserId LocalUserId { get; set; }
	public Utf8String Payload { get; set; }

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
	public Utf8String get_Payload() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_Payload(Utf8String value) { }
}

// Namespace: Epic.OnlineServices.CustomInvites
internal struct SetCustomInviteOptionsInternal : ISettable<SetCustomInviteOptions>, IDisposable // TypeDefIndex: 9832
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_Payload; // 0x10

	// Properties
	public ProductUserId LocalUserId { set; }
	public Utf8String Payload { set; }

	// Methods

	// RVA: 0x51B440 Offset: 0x51A640 VA: 0x18051B440
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x51B4A0 Offset: 0x51A6A0 VA: 0x18051B4A0
	public void set_Payload(Utf8String value) { }

	// RVA: 0x51B280 Offset: 0x51A480 VA: 0x18051B280 Slot: 4
	public void Set(ref SetCustomInviteOptions other) { }

	// RVA: 0x51B340 Offset: 0x51A540 VA: 0x18051B340 Slot: 5
	public void Set(ref Nullable<SetCustomInviteOptions> other) { }

	// RVA: 0x51B220 Offset: 0x51A420 VA: 0x18051B220 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Connect
public struct AddNotifyAuthExpirationOptions // TypeDefIndex: 9833
{}

// Namespace: Epic.OnlineServices.Connect
internal struct AddNotifyAuthExpirationOptionsInternal : ISettable<AddNotifyAuthExpirationOptions>, IDisposable // TypeDefIndex: 9834
{
	// Fields
	private int m_ApiVersion; // 0x0

	// Methods

	// RVA: 0x3F98A0 Offset: 0x3F8AA0 VA: 0x1803F98A0 Slot: 4
	public void Set(ref AddNotifyAuthExpirationOptions other) { }

	// RVA: 0x504690 Offset: 0x503890 VA: 0x180504690 Slot: 5
	public void Set(ref Nullable<AddNotifyAuthExpirationOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Connect
public struct AddNotifyLoginStatusChangedOptions // TypeDefIndex: 9835
{}

// Namespace: Epic.OnlineServices.Connect
internal struct AddNotifyLoginStatusChangedOptionsInternal : ISettable<AddNotifyLoginStatusChangedOptions>, IDisposable // TypeDefIndex: 9836
{
	// Fields
	private int m_ApiVersion; // 0x0

	// Methods

	// RVA: 0x3F98A0 Offset: 0x3F8AA0 VA: 0x1803F98A0 Slot: 4
	public void Set(ref AddNotifyLoginStatusChangedOptions other) { }

	// RVA: 0x5047D0 Offset: 0x5039D0 VA: 0x1805047D0 Slot: 5
	public void Set(ref Nullable<AddNotifyLoginStatusChangedOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Connect
public struct AuthExpirationCallbackInfo : ICallbackInfo // TypeDefIndex: 9837
{
	// Fields
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x0
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x8

	// Properties
	public object ClientData { get; set; }
	public ProductUserId LocalUserId { get; set; }

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

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x504D90 Offset: 0x503F90 VA: 0x180504D90
	internal void Set(ref AuthExpirationCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.Connect
internal struct AuthExpirationCallbackInfoInternal : ICallbackInfoInternal, IGettable<AuthExpirationCallbackInfo>, ISettable<AuthExpirationCallbackInfo>, IDisposable // TypeDefIndex: 9838
{
	// Fields
	private IntPtr m_ClientData; // 0x0
	private IntPtr m_LocalUserId; // 0x8

	// Properties
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public ProductUserId LocalUserId { get; set; }

	// Methods

	// RVA: 0x504BE0 Offset: 0x503DE0 VA: 0x180504BE0
	public object get_ClientData() { }

	// RVA: 0x504CD0 Offset: 0x503ED0 VA: 0x180504CD0
	public void set_ClientData(object value) { }

	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x504C50 Offset: 0x503E50 VA: 0x180504C50
	public ProductUserId get_LocalUserId() { }

	// RVA: 0x504D30 Offset: 0x503F30 VA: 0x180504D30
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x504B30 Offset: 0x503D30 VA: 0x180504B30 Slot: 6
	public void Set(ref AuthExpirationCallbackInfo other) { }

	// RVA: 0x504A30 Offset: 0x503C30 VA: 0x180504A30 Slot: 7
	public void Set(ref Nullable<AuthExpirationCallbackInfo> other) { }

	// RVA: 0x5049B0 Offset: 0x503BB0 VA: 0x1805049B0 Slot: 8
	public void Dispose() { }

	// RVA: 0x504A10 Offset: 0x503C10 VA: 0x180504A10 Slot: 5
	public void Get(out AuthExpirationCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.Connect
public sealed class ConnectInterface : Handle // TypeDefIndex: 9839
{
	// Fields
	public const int AddnotifyauthexpirationApiLatest = 1;
	public const int AddnotifyloginstatuschangedApiLatest = 1;
	public const int CopyidtokenApiLatest = 1;
	public const int CopyproductuserexternalaccountbyaccountidApiLatest = 1;
	public const int CopyproductuserexternalaccountbyaccounttypeApiLatest = 1;
	public const int CopyproductuserexternalaccountbyindexApiLatest = 1;
	public const int CopyproductuserinfoApiLatest = 1;
	public const int CreatedeviceidApiLatest = 1;
	public const int CreatedeviceidDevicemodelMaxLength = 64;
	public const int CreateuserApiLatest = 1;
	public const int CredentialsApiLatest = 1;
	public const int DeletedeviceidApiLatest = 1;
	public const int ExternalAccountIdMaxLength = 256;
	public const int ExternalaccountinfoApiLatest = 1;
	public const int GetexternalaccountmappingApiLatest = 1;
	public const int GetexternalaccountmappingsApiLatest = 1;
	public const int GetproductuserexternalaccountcountApiLatest = 1;
	public const int GetproductuseridmappingApiLatest = 1;
	public const int IdtokenApiLatest = 1;
	public const int LinkaccountApiLatest = 1;
	public const int LoginApiLatest = 2;
	public const int LogoutApiLatest = 1;
	public const int OnauthexpirationcallbackApiLatest = 1;
	public const int QueryexternalaccountmappingsApiLatest = 1;
	public const int QueryexternalaccountmappingsMaxAccountIds = 128;
	public const int QueryproductuseridmappingsApiLatest = 2;
	public const int TimeUndefined = -1;
	public const int TransferdeviceidaccountApiLatest = 1;
	public const int UnlinkaccountApiLatest = 1;
	public const int UserlogininfoApiLatest = 2;
	public const int UserlogininfoDisplaynameMaxLength = 32;
	public const int VerifyidtokenApiLatest = 1;

	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }

	// RVA: 0x40BDB0 Offset: 0x40AFB0 VA: 0x18040BDB0
	public void .ctor(IntPtr innerHandle) { }

	// RVA: 0x504E20 Offset: 0x504020 VA: 0x180504E20
	public ulong AddNotifyAuthExpiration(ref AddNotifyAuthExpirationOptions options, object clientData, OnAuthExpirationCallback notification) { }

	// RVA: 0x504FD0 Offset: 0x5041D0 VA: 0x180504FD0
	public ulong AddNotifyLoginStatusChanged(ref AddNotifyLoginStatusChangedOptions options, object clientData, OnLoginStatusChangedCallback notification) { }

	// RVA: 0x505180 Offset: 0x504380 VA: 0x180505180
	public Result CopyIdToken(ref CopyIdTokenOptions options, out Nullable<IdToken> outIdToken) { }

	// RVA: 0x5052B0 Offset: 0x5044B0 VA: 0x1805052B0
	public Result CopyProductUserExternalAccountByAccountId(ref CopyProductUserExternalAccountByAccountIdOptions options, out Nullable<ExternalAccountInfo> outExternalAccountInfo) { }

	// RVA: 0x5053B0 Offset: 0x5045B0 VA: 0x1805053B0
	public Result CopyProductUserExternalAccountByAccountType(ref CopyProductUserExternalAccountByAccountTypeOptions options, out Nullable<ExternalAccountInfo> outExternalAccountInfo) { }

	// RVA: 0x505500 Offset: 0x504700 VA: 0x180505500
	public Result CopyProductUserExternalAccountByIndex(ref CopyProductUserExternalAccountByIndexOptions options, out Nullable<ExternalAccountInfo> outExternalAccountInfo) { }

	// RVA: 0x505650 Offset: 0x504850 VA: 0x180505650
	public Result CopyProductUserInfo(ref CopyProductUserInfoOptions options, out Nullable<ExternalAccountInfo> outExternalAccountInfo) { }

	// RVA: 0x505780 Offset: 0x504980 VA: 0x180505780
	public void CreateDeviceId(ref CreateDeviceIdOptions options, object clientData, OnCreateDeviceIdCallback completionDelegate) { }

	// RVA: 0x505970 Offset: 0x504B70 VA: 0x180505970
	public void CreateUser(ref CreateUserOptions options, object clientData, OnCreateUserCallback completionDelegate) { }

	// RVA: 0x505B60 Offset: 0x504D60 VA: 0x180505B60
	public void DeleteDeviceId(ref DeleteDeviceIdOptions options, object clientData, OnDeleteDeviceIdCallback completionDelegate) { }

	// RVA: 0x505D00 Offset: 0x504F00 VA: 0x180505D00
	public ProductUserId GetExternalAccountMapping(ref GetExternalAccountMappingsOptions options) { }

	// RVA: 0x505DD0 Offset: 0x504FD0 VA: 0x180505DD0
	public ProductUserId GetLoggedInUserByIndex(int index) { }

	// RVA: 0x505E60 Offset: 0x505060 VA: 0x180505E60
	public int GetLoggedInUsersCount() { }

	// RVA: 0x505E70 Offset: 0x505070 VA: 0x180505E70
	public LoginStatus GetLoginStatus(ProductUserId localUserId) { }

	// RVA: 0x505EF0 Offset: 0x5050F0 VA: 0x180505EF0
	public uint GetProductUserExternalAccountCount(ref GetProductUserExternalAccountCountOptions options) { }

	// RVA: 0x505FD0 Offset: 0x5051D0 VA: 0x180505FD0
	public Result GetProductUserIdMapping(ref GetProductUserIdMappingOptions options, out Utf8String outBuffer) { }

	// RVA: 0x5060C0 Offset: 0x5052C0 VA: 0x1805060C0
	public void LinkAccount(ref LinkAccountOptions options, object clientData, OnLinkAccountCallback completionDelegate) { }

	// RVA: 0x506270 Offset: 0x505470 VA: 0x180506270
	public void Login(ref LoginOptions options, object clientData, OnLoginCallback completionDelegate) { }

	// RVA: 0x506420 Offset: 0x505620 VA: 0x180506420
	public void Logout(ref LogoutOptions options, object clientData, OnLogoutCallback completionDelegate) { }

	// RVA: 0x506EF0 Offset: 0x5060F0 VA: 0x180506EF0
	public void QueryExternalAccountMappings(ref QueryExternalAccountMappingsOptions options, object clientData, OnQueryExternalAccountMappingsCallback completionDelegate) { }

	// RVA: 0x5070B0 Offset: 0x5062B0 VA: 0x1805070B0
	public void QueryProductUserIdMappings(ref QueryProductUserIdMappingsOptions options, object clientData, OnQueryProductUserIdMappingsCallback completionDelegate) { }

	// RVA: 0x507200 Offset: 0x506400 VA: 0x180507200
	public void RemoveNotifyAuthExpiration(ulong inId) { }

	// RVA: 0x507270 Offset: 0x506470 VA: 0x180507270
	public void RemoveNotifyLoginStatusChanged(ulong inId) { }

	// RVA: 0x5072E0 Offset: 0x5064E0 VA: 0x1805072E0
	public void TransferDeviceIdAccount(ref TransferDeviceIdAccountOptions options, object clientData, OnTransferDeviceIdAccountCallback completionDelegate) { }

	// RVA: 0x507420 Offset: 0x506620 VA: 0x180507420
	public void UnlinkAccount(ref UnlinkAccountOptions options, object clientData, OnUnlinkAccountCallback completionDelegate) { }

	// RVA: 0x507560 Offset: 0x506760 VA: 0x180507560
	public void VerifyIdToken(ref VerifyIdTokenOptions options, object clientData, OnVerifyIdTokenCallback completionDelegate) { }

	[MonoPInvokeCallback(typeof(OnAuthExpirationCallbackInternal))]
	// RVA: 0x506610 Offset: 0x505810 VA: 0x180506610
	internal static void OnAuthExpirationCallbackInternalImplementation(ref AuthExpirationCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnCreateDeviceIdCallbackInternal))]
	// RVA: 0x5066B0 Offset: 0x5058B0 VA: 0x1805066B0
	internal static void OnCreateDeviceIdCallbackInternalImplementation(ref CreateDeviceIdCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnCreateUserCallbackInternal))]
	// RVA: 0x506750 Offset: 0x505950 VA: 0x180506750
	internal static void OnCreateUserCallbackInternalImplementation(ref CreateUserCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnDeleteDeviceIdCallbackInternal))]
	// RVA: 0x506800 Offset: 0x505A00 VA: 0x180506800
	internal static void OnDeleteDeviceIdCallbackInternalImplementation(ref DeleteDeviceIdCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnLinkAccountCallbackInternal))]
	// RVA: 0x5068A0 Offset: 0x505AA0 VA: 0x1805068A0
	internal static void OnLinkAccountCallbackInternalImplementation(ref LinkAccountCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnLoginCallbackInternal))]
	// RVA: 0x506950 Offset: 0x505B50 VA: 0x180506950
	internal static void OnLoginCallbackInternalImplementation(ref LoginCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnLoginStatusChangedCallbackInternal))]
	// RVA: 0x506A00 Offset: 0x505C00 VA: 0x180506A00
	internal static void OnLoginStatusChangedCallbackInternalImplementation(ref LoginStatusChangedCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnLogoutCallbackInternal))]
	// RVA: 0x506AB0 Offset: 0x505CB0 VA: 0x180506AB0
	internal static void OnLogoutCallbackInternalImplementation(ref LogoutCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnQueryExternalAccountMappingsCallbackInternal))]
	// RVA: 0x506B60 Offset: 0x505D60 VA: 0x180506B60
	internal static void OnQueryExternalAccountMappingsCallbackInternalImplementation(ref QueryExternalAccountMappingsCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnQueryProductUserIdMappingsCallbackInternal))]
	// RVA: 0x506C10 Offset: 0x505E10 VA: 0x180506C10
	internal static void OnQueryProductUserIdMappingsCallbackInternalImplementation(ref QueryProductUserIdMappingsCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnTransferDeviceIdAccountCallbackInternal))]
	// RVA: 0x506CC0 Offset: 0x505EC0 VA: 0x180506CC0
	internal static void OnTransferDeviceIdAccountCallbackInternalImplementation(ref TransferDeviceIdAccountCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnUnlinkAccountCallbackInternal))]
	// RVA: 0x506D70 Offset: 0x505F70 VA: 0x180506D70
	internal static void OnUnlinkAccountCallbackInternalImplementation(ref UnlinkAccountCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnVerifyIdTokenCallbackInternal))]
	// RVA: 0x506E20 Offset: 0x506020 VA: 0x180506E20
	internal static void OnVerifyIdTokenCallbackInternalImplementation(ref VerifyIdTokenCallbackInfoInternal data) { }
}

// Namespace: Epic.OnlineServices.Connect
public struct CopyIdTokenOptions // TypeDefIndex: 9840
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

// Namespace: Epic.OnlineServices.Connect
internal struct CopyIdTokenOptionsInternal : ISettable<CopyIdTokenOptions>, IDisposable // TypeDefIndex: 9841
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8

	// Properties
	public ProductUserId LocalUserId { set; }

	// Methods

	// RVA: 0x5077F0 Offset: 0x5069F0 VA: 0x1805077F0
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x507790 Offset: 0x506990 VA: 0x180507790 Slot: 4
	public void Set(ref CopyIdTokenOptions other) { }

	// RVA: 0x5076F0 Offset: 0x5068F0 VA: 0x1805076F0 Slot: 5
	public void Set(ref Nullable<CopyIdTokenOptions> other) { }

	// RVA: 0x5076A0 Offset: 0x5068A0 VA: 0x1805076A0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Connect
public struct CopyProductUserExternalAccountByAccountIdOptions // TypeDefIndex: 9842
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <TargetUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <AccountId>k__BackingField; // 0x8

	// Properties
	public ProductUserId TargetUserId { get; set; }
	public Utf8String AccountId { get; set; }

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
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public Utf8String get_AccountId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_AccountId(Utf8String value) { }
}

// Namespace: Epic.OnlineServices.Connect
internal struct CopyProductUserExternalAccountByAccountIdOptionsInternal : ISettable<CopyProductUserExternalAccountByAccountIdOptions>, IDisposable // TypeDefIndex: 9843
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_TargetUserId; // 0x8
	private IntPtr m_AccountId; // 0x10

	// Properties
	public ProductUserId TargetUserId { set; }
	public Utf8String AccountId { set; }

	// Methods

	// RVA: 0x507AD0 Offset: 0x506CD0 VA: 0x180507AD0
	public void set_TargetUserId(ProductUserId value) { }

	// RVA: 0x507A70 Offset: 0x506C70 VA: 0x180507A70
	public void set_AccountId(Utf8String value) { }

	// RVA: 0x5079B0 Offset: 0x506BB0 VA: 0x1805079B0 Slot: 4
	public void Set(ref CopyProductUserExternalAccountByAccountIdOptions other) { }

	// RVA: 0x5078B0 Offset: 0x506AB0 VA: 0x1805078B0 Slot: 5
	public void Set(ref Nullable<CopyProductUserExternalAccountByAccountIdOptions> other) { }

	// RVA: 0x507850 Offset: 0x506A50 VA: 0x180507850 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Connect
public struct CopyProductUserExternalAccountByAccountTypeOptions // TypeDefIndex: 9844
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <TargetUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private ExternalAccountType <AccountIdType>k__BackingField; // 0x8

	// Properties
	public ProductUserId TargetUserId { get; set; }
	public ExternalAccountType AccountIdType { get; set; }

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
	public ExternalAccountType get_AccountIdType() { }

	[CompilerGenerated]
	// RVA: 0x3F5520 Offset: 0x3F4720 VA: 0x1803F5520
	public void set_AccountIdType(ExternalAccountType value) { }
}

// Namespace: Epic.OnlineServices.Connect
internal struct CopyProductUserExternalAccountByAccountTypeOptionsInternal : ISettable<CopyProductUserExternalAccountByAccountTypeOptions>, IDisposable // TypeDefIndex: 9845
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_TargetUserId; // 0x8
	private ExternalAccountType m_AccountIdType; // 0x10

	// Properties
	public ProductUserId TargetUserId { set; }
	public ExternalAccountType AccountIdType { set; }

	// Methods

	// RVA: 0x507CC0 Offset: 0x506EC0 VA: 0x180507CC0
	public void set_TargetUserId(ProductUserId value) { }

	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_AccountIdType(ExternalAccountType value) { }

	// RVA: 0x507B80 Offset: 0x506D80 VA: 0x180507B80 Slot: 4
	public void Set(ref CopyProductUserExternalAccountByAccountTypeOptions other) { }

	// RVA: 0x507C00 Offset: 0x506E00 VA: 0x180507C00 Slot: 5
	public void Set(ref Nullable<CopyProductUserExternalAccountByAccountTypeOptions> other) { }

	// RVA: 0x507B30 Offset: 0x506D30 VA: 0x180507B30 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Connect
public struct CopyProductUserExternalAccountByIndexOptions // TypeDefIndex: 9846
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <TargetUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private uint <ExternalAccountInfoIndex>k__BackingField; // 0x8

	// Properties
	public ProductUserId TargetUserId { get; set; }
	public uint ExternalAccountInfoIndex { get; set; }

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
	public uint get_ExternalAccountInfoIndex() { }

	[CompilerGenerated]
	// RVA: 0x3F5520 Offset: 0x3F4720 VA: 0x1803F5520
	public void set_ExternalAccountInfoIndex(uint value) { }
}

// Namespace: Epic.OnlineServices.Connect
internal struct CopyProductUserExternalAccountByIndexOptionsInternal : ISettable<CopyProductUserExternalAccountByIndexOptions>, IDisposable // TypeDefIndex: 9847
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_TargetUserId; // 0x8
	private uint m_ExternalAccountInfoIndex; // 0x10

	// Properties
	public ProductUserId TargetUserId { set; }
	public uint ExternalAccountInfoIndex { set; }

	// Methods

	// RVA: 0x507EB0 Offset: 0x5070B0 VA: 0x180507EB0
	public void set_TargetUserId(ProductUserId value) { }

	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_ExternalAccountInfoIndex(uint value) { }

	// RVA: 0x507E30 Offset: 0x507030 VA: 0x180507E30 Slot: 4
	public void Set(ref CopyProductUserExternalAccountByIndexOptions other) { }

	// RVA: 0x507D70 Offset: 0x506F70 VA: 0x180507D70 Slot: 5
	public void Set(ref Nullable<CopyProductUserExternalAccountByIndexOptions> other) { }

	// RVA: 0x507D20 Offset: 0x506F20 VA: 0x180507D20 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Connect
public struct CopyProductUserInfoOptions // TypeDefIndex: 9848
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

// Namespace: Epic.OnlineServices.Connect
internal struct CopyProductUserInfoOptionsInternal : ISettable<CopyProductUserInfoOptions>, IDisposable // TypeDefIndex: 9849
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_TargetUserId; // 0x8

	// Properties
	public ProductUserId TargetUserId { set; }

	// Methods

	// RVA: 0x508060 Offset: 0x507260 VA: 0x180508060
	public void set_TargetUserId(ProductUserId value) { }

	// RVA: 0x508000 Offset: 0x507200 VA: 0x180508000 Slot: 4
	public void Set(ref CopyProductUserInfoOptions other) { }

	// RVA: 0x507F60 Offset: 0x507160 VA: 0x180507F60 Slot: 5
	public void Set(ref Nullable<CopyProductUserInfoOptions> other) { }

	// RVA: 0x507F10 Offset: 0x507110 VA: 0x180507F10 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Connect
public struct CreateDeviceIdCallbackInfo : ICallbackInfo // TypeDefIndex: 9850
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

	// RVA: 0x508320 Offset: 0x507520 VA: 0x180508320 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x508370 Offset: 0x507570 VA: 0x180508370
	internal void Set(ref CreateDeviceIdCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.Connect
internal struct CreateDeviceIdCallbackInfoInternal : ICallbackInfoInternal, IGettable<CreateDeviceIdCallbackInfo>, ISettable<CreateDeviceIdCallbackInfo>, IDisposable // TypeDefIndex: 9851
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

	// RVA: 0x508250 Offset: 0x507450 VA: 0x180508250
	public object get_ClientData() { }

	// RVA: 0x5082C0 Offset: 0x5074C0 VA: 0x1805082C0
	public void set_ClientData(object value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x508130 Offset: 0x507330 VA: 0x180508130 Slot: 6
	public void Set(ref CreateDeviceIdCallbackInfo other) { }

	// RVA: 0x508190 Offset: 0x507390 VA: 0x180508190 Slot: 7
	public void Set(ref Nullable<CreateDeviceIdCallbackInfo> other) { }

	// RVA: 0x5080C0 Offset: 0x5072C0 VA: 0x1805080C0 Slot: 8
	public void Dispose() { }

	// RVA: 0x508110 Offset: 0x507310 VA: 0x180508110 Slot: 5
	public void Get(out CreateDeviceIdCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.Connect
public struct CreateDeviceIdOptions // TypeDefIndex: 9852
{
	// Fields
	[CompilerGenerated]
	private Utf8String <DeviceModel>k__BackingField; // 0x0

	// Properties
	public Utf8String DeviceModel { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Utf8String get_DeviceModel() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_DeviceModel(Utf8String value) { }
}

// Namespace: Epic.OnlineServices.Connect
internal struct CreateDeviceIdOptionsInternal : ISettable<CreateDeviceIdOptions>, IDisposable // TypeDefIndex: 9853
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_DeviceModel; // 0x8

	// Properties
	public Utf8String DeviceModel { set; }

	// Methods

	// RVA: 0x508540 Offset: 0x507740 VA: 0x180508540
	public void set_DeviceModel(Utf8String value) { }

	// RVA: 0x508440 Offset: 0x507640 VA: 0x180508440 Slot: 4
	public void Set(ref CreateDeviceIdOptions other) { }

	// RVA: 0x5084A0 Offset: 0x5076A0 VA: 0x1805084A0 Slot: 5
	public void Set(ref Nullable<CreateDeviceIdOptions> other) { }

	// RVA: 0x5083F0 Offset: 0x5075F0 VA: 0x1805083F0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Connect
public struct CreateUserCallbackInfo : ICallbackInfo // TypeDefIndex: 9854
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

	// RVA: 0x5089A0 Offset: 0x507BA0 VA: 0x1805089A0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x5089F0 Offset: 0x507BF0 VA: 0x1805089F0
	internal void Set(ref CreateUserCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.Connect
internal struct CreateUserCallbackInfoInternal : ICallbackInfoInternal, IGettable<CreateUserCallbackInfo>, ISettable<CreateUserCallbackInfo>, IDisposable // TypeDefIndex: 9855
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

	// RVA: 0x5087F0 Offset: 0x5079F0 VA: 0x1805087F0
	public object get_ClientData() { }

	// RVA: 0x5088E0 Offset: 0x507AE0 VA: 0x1805088E0
	public void set_ClientData(object value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x508860 Offset: 0x507A60 VA: 0x180508860
	public ProductUserId get_LocalUserId() { }

	// RVA: 0x508940 Offset: 0x507B40 VA: 0x180508940
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x508620 Offset: 0x507820 VA: 0x180508620 Slot: 6
	public void Set(ref CreateUserCallbackInfo other) { }

	// RVA: 0x5086D0 Offset: 0x5078D0 VA: 0x1805086D0 Slot: 7
	public void Set(ref Nullable<CreateUserCallbackInfo> other) { }

	// RVA: 0x5085A0 Offset: 0x5077A0 VA: 0x1805085A0 Slot: 8
	public void Dispose() { }

	// RVA: 0x508600 Offset: 0x507800 VA: 0x180508600 Slot: 5
	public void Get(out CreateUserCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.Connect
public struct CreateUserOptions // TypeDefIndex: 9856
{
	// Fields
	[CompilerGenerated]
	private ContinuanceToken <ContinuanceToken>k__BackingField; // 0x0

	// Properties
	public ContinuanceToken ContinuanceToken { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public ContinuanceToken get_ContinuanceToken() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_ContinuanceToken(ContinuanceToken value) { }
}

// Namespace: Epic.OnlineServices.Connect
internal struct CreateUserOptionsInternal : ISettable<CreateUserOptions>, IDisposable // TypeDefIndex: 9857
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_ContinuanceToken; // 0x8

	// Properties
	public ContinuanceToken ContinuanceToken { set; }

	// Methods

	// RVA: 0x508BD0 Offset: 0x507DD0 VA: 0x180508BD0
	public void set_ContinuanceToken(ContinuanceToken value) { }

	// RVA: 0x508AD0 Offset: 0x507CD0 VA: 0x180508AD0 Slot: 4
	public void Set(ref CreateUserOptions other) { }

	// RVA: 0x508B30 Offset: 0x507D30 VA: 0x180508B30 Slot: 5
	public void Set(ref Nullable<CreateUserOptions> other) { }

	// RVA: 0x508A80 Offset: 0x507C80 VA: 0x180508A80 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Connect
public struct Credentials // TypeDefIndex: 9858
{
	// Fields
	[CompilerGenerated]
	private Utf8String <Token>k__BackingField; // 0x0
	[CompilerGenerated]
	private ExternalCredentialType <Type>k__BackingField; // 0x8

	// Properties
	public Utf8String Token { get; set; }
	public ExternalCredentialType Type { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Utf8String get_Token() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_Token(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3F5510 Offset: 0x3F4710 VA: 0x1803F5510
	public ExternalCredentialType get_Type() { }

	[CompilerGenerated]
	// RVA: 0x3F5520 Offset: 0x3F4720 VA: 0x1803F5520
	public void set_Type(ExternalCredentialType value) { }

	// RVA: 0x508EB0 Offset: 0x5080B0 VA: 0x180508EB0
	internal void Set(ref CredentialsInternal other) { }
}

// Namespace: Epic.OnlineServices.Connect
internal struct CredentialsInternal : IGettable<Credentials>, ISettable<Credentials>, IDisposable // TypeDefIndex: 9859
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_Token; // 0x8
	private ExternalCredentialType m_Type; // 0x10

	// Properties
	public Utf8String Token { get; set; }
	public ExternalCredentialType Type { get; set; }

	// Methods

	// RVA: 0x508DE0 Offset: 0x507FE0 VA: 0x180508DE0
	public Utf8String get_Token() { }

	// RVA: 0x508E50 Offset: 0x508050 VA: 0x180508E50
	public void set_Token(Utf8String value) { }

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public ExternalCredentialType get_Type() { }

	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_Type(ExternalCredentialType value) { }

	// RVA: 0x508CA0 Offset: 0x507EA0 VA: 0x180508CA0 Slot: 5
	public void Set(ref Credentials other) { }

	// RVA: 0x508D20 Offset: 0x507F20 VA: 0x180508D20 Slot: 6
	public void Set(ref Nullable<Credentials> other) { }

	// RVA: 0x508C30 Offset: 0x507E30 VA: 0x180508C30 Slot: 7
	public void Dispose() { }

	// RVA: 0x508C80 Offset: 0x507E80 VA: 0x180508C80 Slot: 4
	public void Get(out Credentials output) { }
}

// Namespace: Epic.OnlineServices.Connect
public struct DeleteDeviceIdCallbackInfo : ICallbackInfo // TypeDefIndex: 9860
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

	// RVA: 0x50BCA0 Offset: 0x50AEA0 VA: 0x18050BCA0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x50BCF0 Offset: 0x50AEF0 VA: 0x18050BCF0
	internal void Set(ref DeleteDeviceIdCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.Connect
internal struct DeleteDeviceIdCallbackInfoInternal : ICallbackInfoInternal, IGettable<DeleteDeviceIdCallbackInfo>, ISettable<DeleteDeviceIdCallbackInfo>, IDisposable // TypeDefIndex: 9861
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

	// RVA: 0x50BBD0 Offset: 0x50ADD0 VA: 0x18050BBD0
	public object get_ClientData() { }

	// RVA: 0x50BC40 Offset: 0x50AE40 VA: 0x18050BC40
	public void set_ClientData(object value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x50BAB0 Offset: 0x50ACB0 VA: 0x18050BAB0 Slot: 6
	public void Set(ref DeleteDeviceIdCallbackInfo other) { }

	// RVA: 0x50BB10 Offset: 0x50AD10 VA: 0x18050BB10 Slot: 7
	public void Set(ref Nullable<DeleteDeviceIdCallbackInfo> other) { }

	// RVA: 0x50BA40 Offset: 0x50AC40 VA: 0x18050BA40 Slot: 8
	public void Dispose() { }

	// RVA: 0x50BA90 Offset: 0x50AC90 VA: 0x18050BA90 Slot: 5
	public void Get(out DeleteDeviceIdCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.Connect
public struct DeleteDeviceIdOptions // TypeDefIndex: 9862
{}

// Namespace: Epic.OnlineServices.Connect
internal struct DeleteDeviceIdOptionsInternal : ISettable<DeleteDeviceIdOptions>, IDisposable // TypeDefIndex: 9863
{
	// Fields
	private int m_ApiVersion; // 0x0

	// Methods

	// RVA: 0x3F98A0 Offset: 0x3F8AA0 VA: 0x1803F98A0 Slot: 4
	public void Set(ref DeleteDeviceIdOptions other) { }

	// RVA: 0x50BD70 Offset: 0x50AF70 VA: 0x18050BD70 Slot: 5
	public void Set(ref Nullable<DeleteDeviceIdOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Connect
public struct ExternalAccountInfo // TypeDefIndex: 9864
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <ProductUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <DisplayName>k__BackingField; // 0x8
	[CompilerGenerated]
	private Utf8String <AccountId>k__BackingField; // 0x10
	[CompilerGenerated]
	private ExternalAccountType <AccountIdType>k__BackingField; // 0x18
	[CompilerGenerated]
	private Nullable<DateTimeOffset> <LastLoginTime>k__BackingField; // 0x20

	// Properties
	public ProductUserId ProductUserId { get; set; }
	public Utf8String DisplayName { get; set; }
	public Utf8String AccountId { get; set; }
	public ExternalAccountType AccountIdType { get; set; }
	public Nullable<DateTimeOffset> LastLoginTime { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public ProductUserId get_ProductUserId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_ProductUserId(ProductUserId value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public Utf8String get_DisplayName() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_DisplayName(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Utf8String get_AccountId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_AccountId(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public ExternalAccountType get_AccountIdType() { }

	[CompilerGenerated]
	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	public void set_AccountIdType(ExternalAccountType value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x415790 Offset: 0x414990 VA: 0x180415790
	public Nullable<DateTimeOffset> get_LastLoginTime() { }

	[CompilerGenerated]
	// RVA: 0x4157E0 Offset: 0x4149E0 VA: 0x1804157E0
	public void set_LastLoginTime(Nullable<DateTimeOffset> value) { }

	// RVA: 0x50C510 Offset: 0x50B710 VA: 0x18050C510
	internal void Set(ref ExternalAccountInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.Connect
internal struct ExternalAccountInfoInternal : IGettable<ExternalAccountInfo>, ISettable<ExternalAccountInfo>, IDisposable // TypeDefIndex: 9865
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_ProductUserId; // 0x8
	private IntPtr m_DisplayName; // 0x10
	private IntPtr m_AccountId; // 0x18
	private ExternalAccountType m_AccountIdType; // 0x20
	private long m_LastLoginTime; // 0x28

	// Properties
	public ProductUserId ProductUserId { get; set; }
	public Utf8String DisplayName { get; set; }
	public Utf8String AccountId { get; set; }
	public ExternalAccountType AccountIdType { get; set; }
	public Nullable<DateTimeOffset> LastLoginTime { get; set; }

	// Methods

	// RVA: 0x50C300 Offset: 0x50B500 VA: 0x18050C300
	public ProductUserId get_ProductUserId() { }

	// RVA: 0x50C4B0 Offset: 0x50B6B0 VA: 0x18050C4B0
	public void set_ProductUserId(ProductUserId value) { }

	// RVA: 0x50C220 Offset: 0x50B420 VA: 0x18050C220
	public Utf8String get_DisplayName() { }

	// RVA: 0x50C3E0 Offset: 0x50B5E0 VA: 0x18050C3E0
	public void set_DisplayName(Utf8String value) { }

	// RVA: 0x50C1B0 Offset: 0x50B3B0 VA: 0x18050C1B0
	public Utf8String get_AccountId() { }

	// RVA: 0x50C380 Offset: 0x50B580 VA: 0x18050C380
	public void set_AccountId(Utf8String value) { }

	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400
	public ExternalAccountType get_AccountIdType() { }

	// RVA: 0x3DA420 Offset: 0x3D9620 VA: 0x1803DA420
	public void set_AccountIdType(ExternalAccountType value) { }

	// RVA: 0x50C290 Offset: 0x50B490 VA: 0x18050C290
	public Nullable<DateTimeOffset> get_LastLoginTime() { }

	// RVA: 0x50C440 Offset: 0x50B640 VA: 0x18050C440
	public void set_LastLoginTime(Nullable<DateTimeOffset> value) { }

	// RVA: 0x50BE50 Offset: 0x50B050 VA: 0x18050BE50 Slot: 5
	public void Set(ref ExternalAccountInfo other) { }

	// RVA: 0x50BFC0 Offset: 0x50B1C0 VA: 0x18050BFC0 Slot: 6
	public void Set(ref Nullable<ExternalAccountInfo> other) { }

	// RVA: 0x50BDC0 Offset: 0x50AFC0 VA: 0x18050BDC0 Slot: 7
	public void Dispose() { }

	// RVA: 0x50BE20 Offset: 0x50B020 VA: 0x18050BE20 Slot: 4
	public void Get(out ExternalAccountInfo output) { }
}

// Namespace: Epic.OnlineServices.Connect
public struct GetExternalAccountMappingsOptions // TypeDefIndex: 9866
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private ExternalAccountType <AccountIdType>k__BackingField; // 0x8
	[CompilerGenerated]
	private Utf8String <TargetExternalUserId>k__BackingField; // 0x10

	// Properties
	public ProductUserId LocalUserId { get; set; }
	public ExternalAccountType AccountIdType { get; set; }
	public Utf8String TargetExternalUserId { get; set; }

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
	public ExternalAccountType get_AccountIdType() { }

	[CompilerGenerated]
	// RVA: 0x3F5520 Offset: 0x3F4720 VA: 0x1803F5520
	public void set_AccountIdType(ExternalAccountType value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Utf8String get_TargetExternalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_TargetExternalUserId(Utf8String value) { }
}

// Namespace: Epic.OnlineServices.Connect
internal struct GetExternalAccountMappingsOptionsInternal : ISettable<GetExternalAccountMappingsOptions>, IDisposable // TypeDefIndex: 9867
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private ExternalAccountType m_AccountIdType; // 0x10
	private IntPtr m_TargetExternalUserId; // 0x18

	// Properties
	public ProductUserId LocalUserId { set; }
	public ExternalAccountType AccountIdType { set; }
	public Utf8String TargetExternalUserId { set; }

	// Methods

	// RVA: 0x50CC90 Offset: 0x50BE90 VA: 0x18050CC90
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_AccountIdType(ExternalAccountType value) { }

	// RVA: 0x50CCF0 Offset: 0x50BEF0 VA: 0x18050CCF0
	public void set_TargetExternalUserId(Utf8String value) { }

	// RVA: 0x50CAB0 Offset: 0x50BCB0 VA: 0x18050CAB0 Slot: 4
	public void Set(ref GetExternalAccountMappingsOptions other) { }

	// RVA: 0x50CB70 Offset: 0x50BD70 VA: 0x18050CB70 Slot: 5
	public void Set(ref Nullable<GetExternalAccountMappingsOptions> other) { }

	// RVA: 0x50CA50 Offset: 0x50BC50 VA: 0x18050CA50 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Connect
public struct GetProductUserExternalAccountCountOptions // TypeDefIndex: 9868
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

// Namespace: Epic.OnlineServices.Connect
internal struct GetProductUserExternalAccountCountOptionsInternal : ISettable<GetProductUserExternalAccountCountOptions>, IDisposable // TypeDefIndex: 9869
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_TargetUserId; // 0x8

	// Properties
	public ProductUserId TargetUserId { set; }

	// Methods

	// RVA: 0x50CEA0 Offset: 0x50C0A0 VA: 0x18050CEA0
	public void set_TargetUserId(ProductUserId value) { }

	// RVA: 0x50CDA0 Offset: 0x50BFA0 VA: 0x18050CDA0 Slot: 4
	public void Set(ref GetProductUserExternalAccountCountOptions other) { }

	// RVA: 0x50CE00 Offset: 0x50C000 VA: 0x18050CE00 Slot: 5
	public void Set(ref Nullable<GetProductUserExternalAccountCountOptions> other) { }

	// RVA: 0x50CD50 Offset: 0x50BF50 VA: 0x18050CD50 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Connect
public struct GetProductUserIdMappingOptions // TypeDefIndex: 9870
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private ExternalAccountType <AccountIdType>k__BackingField; // 0x8
	[CompilerGenerated]
	private ProductUserId <TargetProductUserId>k__BackingField; // 0x10

	// Properties
	public ProductUserId LocalUserId { get; set; }
	public ExternalAccountType AccountIdType { get; set; }
	public ProductUserId TargetProductUserId { get; set; }

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
	// RVA: 0x3F5510 Offset: 0x3F4710 VA: 0x1803F5510
	public ExternalAccountType get_AccountIdType() { }

	[CompilerGenerated]
	// RVA: 0x3F5520 Offset: 0x3F4720 VA: 0x1803F5520
	public void set_AccountIdType(ExternalAccountType value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public ProductUserId get_TargetProductUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_TargetProductUserId(ProductUserId value) { }
}

// Namespace: Epic.OnlineServices.Connect
internal struct GetProductUserIdMappingOptionsInternal : ISettable<GetProductUserIdMappingOptions>, IDisposable // TypeDefIndex: 9871
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private ExternalAccountType m_AccountIdType; // 0x10
	private IntPtr m_TargetProductUserId; // 0x18

	// Properties
	public ProductUserId LocalUserId { set; }
	public ExternalAccountType AccountIdType { set; }
	public ProductUserId TargetProductUserId { set; }

	// Methods

	// RVA: 0x50D140 Offset: 0x50C340 VA: 0x18050D140
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_AccountIdType(ExternalAccountType value) { }

	// RVA: 0x50D1A0 Offset: 0x50C3A0 VA: 0x18050D1A0
	public void set_TargetProductUserId(ProductUserId value) { }

	// RVA: 0x50D080 Offset: 0x50C280 VA: 0x18050D080 Slot: 4
	public void Set(ref GetProductUserIdMappingOptions other) { }

	// RVA: 0x50CF60 Offset: 0x50C160 VA: 0x18050CF60 Slot: 5
	public void Set(ref Nullable<GetProductUserIdMappingOptions> other) { }

	// RVA: 0x50CF00 Offset: 0x50C100 VA: 0x18050CF00 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Connect
public struct IdToken // TypeDefIndex: 9872
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <ProductUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <JsonWebToken>k__BackingField; // 0x8

	// Properties
	public ProductUserId ProductUserId { get; set; }
	public Utf8String JsonWebToken { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public ProductUserId get_ProductUserId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_ProductUserId(ProductUserId value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public Utf8String get_JsonWebToken() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_JsonWebToken(Utf8String value) { }

	// RVA: 0x50D5F0 Offset: 0x50C7F0 VA: 0x18050D5F0
	internal void Set(ref IdTokenInternal other) { }
}

// Namespace: Epic.OnlineServices.Connect
internal struct IdTokenInternal : IGettable<IdToken>, ISettable<IdToken>, IDisposable // TypeDefIndex: 9873
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_ProductUserId; // 0x8
	private IntPtr m_JsonWebToken; // 0x10

	// Properties
	public ProductUserId ProductUserId { get; set; }
	public Utf8String JsonWebToken { get; set; }

	// Methods

	// RVA: 0x50D4B0 Offset: 0x50C6B0 VA: 0x18050D4B0
	public ProductUserId get_ProductUserId() { }

	// RVA: 0x50D590 Offset: 0x50C790 VA: 0x18050D590
	public void set_ProductUserId(ProductUserId value) { }

	// RVA: 0x50D440 Offset: 0x50C640 VA: 0x18050D440
	public Utf8String get_JsonWebToken() { }

	// RVA: 0x50D530 Offset: 0x50C730 VA: 0x18050D530
	public void set_JsonWebToken(Utf8String value) { }

	// RVA: 0x50D280 Offset: 0x50C480 VA: 0x18050D280 Slot: 5
	public void Set(ref IdToken other) { }

	// RVA: 0x50D340 Offset: 0x50C540 VA: 0x18050D340 Slot: 6
	public void Set(ref Nullable<IdToken> other) { }

	// RVA: 0x50D200 Offset: 0x50C400 VA: 0x18050D200 Slot: 7
	public void Dispose() { }

	// RVA: 0x50D260 Offset: 0x50C460 VA: 0x18050D260 Slot: 4
	public void Get(out IdToken output) { }
}

// Namespace: Epic.OnlineServices.Connect
public struct LinkAccountCallbackInfo : ICallbackInfo // TypeDefIndex: 9874
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

	// RVA: 0x50E280 Offset: 0x50D480 VA: 0x18050E280 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x50E2D0 Offset: 0x50D4D0 VA: 0x18050E2D0
	internal void Set(ref LinkAccountCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.Connect
internal struct LinkAccountCallbackInfoInternal : ICallbackInfoInternal, IGettable<LinkAccountCallbackInfo>, ISettable<LinkAccountCallbackInfo>, IDisposable // TypeDefIndex: 9875
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

	// RVA: 0x50E0D0 Offset: 0x50D2D0 VA: 0x18050E0D0
	public object get_ClientData() { }

	// RVA: 0x50E1C0 Offset: 0x50D3C0 VA: 0x18050E1C0
	public void set_ClientData(object value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x50E140 Offset: 0x50D340 VA: 0x18050E140
	public ProductUserId get_LocalUserId() { }

	// RVA: 0x50E220 Offset: 0x50D420 VA: 0x18050E220
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x50E020 Offset: 0x50D220 VA: 0x18050E020 Slot: 6
	public void Set(ref LinkAccountCallbackInfo other) { }

	// RVA: 0x50DF00 Offset: 0x50D100 VA: 0x18050DF00 Slot: 7
	public void Set(ref Nullable<LinkAccountCallbackInfo> other) { }

	// RVA: 0x50DE80 Offset: 0x50D080 VA: 0x18050DE80 Slot: 8
	public void Dispose() { }

	// RVA: 0x50DEE0 Offset: 0x50D0E0 VA: 0x18050DEE0 Slot: 5
	public void Get(out LinkAccountCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.Connect
public struct LinkAccountOptions // TypeDefIndex: 9876
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private ContinuanceToken <ContinuanceToken>k__BackingField; // 0x8

	// Properties
	public ProductUserId LocalUserId { get; set; }
	public ContinuanceToken ContinuanceToken { get; set; }

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
	public ContinuanceToken get_ContinuanceToken() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_ContinuanceToken(ContinuanceToken value) { }
}

// Namespace: Epic.OnlineServices.Connect
internal struct LinkAccountOptionsInternal : ISettable<LinkAccountOptions>, IDisposable // TypeDefIndex: 9877
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_ContinuanceToken; // 0x10

	// Properties
	public ProductUserId LocalUserId { set; }
	public ContinuanceToken ContinuanceToken { set; }

	// Methods

	// RVA: 0x50E5E0 Offset: 0x50D7E0 VA: 0x18050E5E0
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x50E580 Offset: 0x50D780 VA: 0x18050E580
	public void set_ContinuanceToken(ContinuanceToken value) { }

	// RVA: 0x50E3C0 Offset: 0x50D5C0 VA: 0x18050E3C0 Slot: 4
	public void Set(ref LinkAccountOptions other) { }

	// RVA: 0x50E480 Offset: 0x50D680 VA: 0x18050E480 Slot: 5
	public void Set(ref Nullable<LinkAccountOptions> other) { }

	// RVA: 0x50E360 Offset: 0x50D560 VA: 0x18050E360 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Connect
public struct LoginCallbackInfo : ICallbackInfo // TypeDefIndex: 9878
{
	// Fields
	[CompilerGenerated]
	private Result <ResultCode>k__BackingField; // 0x0
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x8
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x10
	[CompilerGenerated]
	private ContinuanceToken <ContinuanceToken>k__BackingField; // 0x18

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public ProductUserId LocalUserId { get; set; }
	public ContinuanceToken ContinuanceToken { get; set; }

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

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public ContinuanceToken get_ContinuanceToken() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_ContinuanceToken(ContinuanceToken value) { }

	// RVA: 0x50EBC0 Offset: 0x50DDC0 VA: 0x18050EBC0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x50EC10 Offset: 0x50DE10 VA: 0x18050EC10
	internal void Set(ref LoginCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.Connect
internal struct LoginCallbackInfoInternal : ICallbackInfoInternal, IGettable<LoginCallbackInfo>, ISettable<LoginCallbackInfo>, IDisposable // TypeDefIndex: 9879
{
	// Fields
	private Result m_ResultCode; // 0x0
	private IntPtr m_ClientData; // 0x8
	private IntPtr m_LocalUserId; // 0x10
	private IntPtr m_ContinuanceToken; // 0x18

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public ProductUserId LocalUserId { get; set; }
	public ContinuanceToken ContinuanceToken { get; set; }

	// Methods

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	// RVA: 0x50E930 Offset: 0x50DB30 VA: 0x18050E930
	public object get_ClientData() { }

	// RVA: 0x50EAA0 Offset: 0x50DCA0 VA: 0x18050EAA0
	public void set_ClientData(object value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x50EA20 Offset: 0x50DC20 VA: 0x18050EA20
	public ProductUserId get_LocalUserId() { }

	// RVA: 0x50EB60 Offset: 0x50DD60 VA: 0x18050EB60
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x50E9A0 Offset: 0x50DBA0 VA: 0x18050E9A0
	public ContinuanceToken get_ContinuanceToken() { }

	// RVA: 0x50EB00 Offset: 0x50DD00 VA: 0x18050EB00
	public void set_ContinuanceToken(ContinuanceToken value) { }

	// RVA: 0x50E6C0 Offset: 0x50D8C0 VA: 0x18050E6C0 Slot: 6
	public void Set(ref LoginCallbackInfo other) { }

	// RVA: 0x50E7C0 Offset: 0x50D9C0 VA: 0x18050E7C0 Slot: 7
	public void Set(ref Nullable<LoginCallbackInfo> other) { }

	// RVA: 0x50E640 Offset: 0x50D840 VA: 0x18050E640 Slot: 8
	public void Dispose() { }

	// RVA: 0x50E6A0 Offset: 0x50D8A0 VA: 0x18050E6A0 Slot: 5
	public void Get(out LoginCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.Connect
public struct LoginOptions // TypeDefIndex: 9880
{
	// Fields
	[CompilerGenerated]
	private Nullable<Credentials> <Credentials>k__BackingField; // 0x0
	[CompilerGenerated]
	private Nullable<UserLoginInfo> <UserLoginInfo>k__BackingField; // 0x18

	// Properties
	public Nullable<Credentials> Credentials { get; set; }
	public Nullable<UserLoginInfo> UserLoginInfo { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x4BBD30 Offset: 0x4BAF30 VA: 0x1804BBD30
	public Nullable<Credentials> get_Credentials() { }

	[CompilerGenerated]
	// RVA: 0x4BBD50 Offset: 0x4BAF50 VA: 0x1804BBD50
	public void set_Credentials(Nullable<Credentials> value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x426510 Offset: 0x425710 VA: 0x180426510
	public Nullable<UserLoginInfo> get_UserLoginInfo() { }

	[CompilerGenerated]
	// RVA: 0x426540 Offset: 0x425740 VA: 0x180426540
	public void set_UserLoginInfo(Nullable<UserLoginInfo> value) { }
}

// Namespace: Epic.OnlineServices.Connect
internal struct LoginOptionsInternal : ISettable<LoginOptions>, IDisposable // TypeDefIndex: 9881
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_Credentials; // 0x8
	private IntPtr m_UserLoginInfo; // 0x10

	// Properties
	public Nullable<Credentials> Credentials { set; }
	public Nullable<UserLoginInfo> UserLoginInfo { set; }

	// Methods

	// RVA: 0x50EF50 Offset: 0x50E150 VA: 0x18050EF50
	public void set_Credentials(Nullable<Credentials> value) { }

	// RVA: 0x50EFC0 Offset: 0x50E1C0 VA: 0x18050EFC0
	public void set_UserLoginInfo(Nullable<UserLoginInfo> value) { }

	// RVA: 0x50EE60 Offset: 0x50E060 VA: 0x18050EE60 Slot: 4
	public void Set(ref LoginOptions other) { }

	// RVA: 0x50ED10 Offset: 0x50DF10 VA: 0x18050ED10 Slot: 5
	public void Set(ref Nullable<LoginOptions> other) { }

	// RVA: 0x50ECB0 Offset: 0x50DEB0 VA: 0x18050ECB0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Connect
public struct LoginStatusChangedCallbackInfo : ICallbackInfo // TypeDefIndex: 9882
{
	// Fields
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x0
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x8
	[CompilerGenerated]
	private LoginStatus <PreviousStatus>k__BackingField; // 0x10
	[CompilerGenerated]
	private LoginStatus <CurrentStatus>k__BackingField; // 0x14

	// Properties
	public object ClientData { get; set; }
	public ProductUserId LocalUserId { get; set; }
	public LoginStatus PreviousStatus { get; set; }
	public LoginStatus CurrentStatus { get; set; }

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
	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public LoginStatus get_PreviousStatus() { }

	[CompilerGenerated]
	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_PreviousStatus(LoginStatus value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500
	public LoginStatus get_CurrentStatus() { }

	[CompilerGenerated]
	// RVA: 0x426530 Offset: 0x425730 VA: 0x180426530
	public void set_CurrentStatus(LoginStatus value) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x50F460 Offset: 0x50E660 VA: 0x18050F460
	internal void Set(ref LoginStatusChangedCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.Connect
internal struct LoginStatusChangedCallbackInfoInternal : ICallbackInfoInternal, IGettable<LoginStatusChangedCallbackInfo>, ISettable<LoginStatusChangedCallbackInfo>, IDisposable // TypeDefIndex: 9883
{
	// Fields
	private IntPtr m_ClientData; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private LoginStatus m_PreviousStatus; // 0x10
	private LoginStatus m_CurrentStatus; // 0x14

	// Properties
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public ProductUserId LocalUserId { get; set; }
	public LoginStatus PreviousStatus { get; set; }
	public LoginStatus CurrentStatus { get; set; }

	// Methods

	// RVA: 0x50F2B0 Offset: 0x50E4B0 VA: 0x18050F2B0
	public object get_ClientData() { }

	// RVA: 0x50F3A0 Offset: 0x50E5A0 VA: 0x18050F3A0
	public void set_ClientData(object value) { }

	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x50F320 Offset: 0x50E520 VA: 0x18050F320
	public ProductUserId get_LocalUserId() { }

	// RVA: 0x50F400 Offset: 0x50E600 VA: 0x18050F400
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public LoginStatus get_PreviousStatus() { }

	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_PreviousStatus(LoginStatus value) { }

	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500
	public LoginStatus get_CurrentStatus() { }

	// RVA: 0x426530 Offset: 0x425730 VA: 0x180426530
	public void set_CurrentStatus(LoginStatus value) { }

	// RVA: 0x50F1F0 Offset: 0x50E3F0 VA: 0x18050F1F0 Slot: 6
	public void Set(ref LoginStatusChangedCallbackInfo other) { }

	// RVA: 0x50F0B0 Offset: 0x50E2B0 VA: 0x18050F0B0 Slot: 7
	public void Set(ref Nullable<LoginStatusChangedCallbackInfo> other) { }

	// RVA: 0x50F030 Offset: 0x50E230 VA: 0x18050F030 Slot: 8
	public void Dispose() { }

	// RVA: 0x50F090 Offset: 0x50E290 VA: 0x18050F090 Slot: 5
	public void Get(out LoginStatusChangedCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.Connect
public struct LogoutCallbackInfo : ICallbackInfo // TypeDefIndex: 9884
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

	// RVA: 0x50F900 Offset: 0x50EB00 VA: 0x18050F900 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x50F950 Offset: 0x50EB50 VA: 0x18050F950
	internal void Set(ref LogoutCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.Connect
internal struct LogoutCallbackInfoInternal : ICallbackInfoInternal, IGettable<LogoutCallbackInfo>, ISettable<LogoutCallbackInfo>, IDisposable // TypeDefIndex: 9885
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

	// RVA: 0x50F750 Offset: 0x50E950 VA: 0x18050F750
	public object get_ClientData() { }

	// RVA: 0x50F840 Offset: 0x50EA40 VA: 0x18050F840
	public void set_ClientData(object value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x50F7C0 Offset: 0x50E9C0 VA: 0x18050F7C0
	public ProductUserId get_LocalUserId() { }

	// RVA: 0x50F8A0 Offset: 0x50EAA0 VA: 0x18050F8A0
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x50F6A0 Offset: 0x50E8A0 VA: 0x18050F6A0 Slot: 6
	public void Set(ref LogoutCallbackInfo other) { }

	// RVA: 0x50F580 Offset: 0x50E780 VA: 0x18050F580 Slot: 7
	public void Set(ref Nullable<LogoutCallbackInfo> other) { }

	// RVA: 0x50F500 Offset: 0x50E700 VA: 0x18050F500 Slot: 8
	public void Dispose() { }

	// RVA: 0x50F560 Offset: 0x50E760 VA: 0x18050F560 Slot: 5
	public void Get(out LogoutCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.Connect
public struct LogoutOptions // TypeDefIndex: 9886
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

// Namespace: Epic.OnlineServices.Connect
internal struct LogoutOptionsInternal : ISettable<LogoutOptions>, IDisposable // TypeDefIndex: 9887
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8

	// Properties
	public ProductUserId LocalUserId { set; }

	// Methods

	// RVA: 0x50FB30 Offset: 0x50ED30 VA: 0x18050FB30
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x50FAD0 Offset: 0x50ECD0 VA: 0x18050FAD0 Slot: 4
	public void Set(ref LogoutOptions other) { }

	// RVA: 0x50FA30 Offset: 0x50EC30 VA: 0x18050FA30 Slot: 5
	public void Set(ref Nullable<LogoutOptions> other) { }

	// RVA: 0x50F9E0 Offset: 0x50EBE0 VA: 0x18050F9E0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Connect
public sealed class OnAuthExpirationCallback : MulticastDelegate // TypeDefIndex: 9888
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref AuthExpirationCallbackInfo data) { }

	// RVA: 0x50FD40 Offset: 0x50EF40 VA: 0x18050FD40 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref AuthExpirationCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref AuthExpirationCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Connect
[UnmanagedFunctionPointer(2)]
internal sealed class OnAuthExpirationCallbackInternal : MulticastDelegate // TypeDefIndex: 9889
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref AuthExpirationCallbackInfoInternal data) { }

	// RVA: 0x50FCB0 Offset: 0x50EEB0 VA: 0x18050FCB0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref AuthExpirationCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref AuthExpirationCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Connect
public sealed class OnCreateDeviceIdCallback : MulticastDelegate // TypeDefIndex: 9890
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref CreateDeviceIdCallbackInfo data) { }

	// RVA: 0x50FF80 Offset: 0x50F180 VA: 0x18050FF80 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref CreateDeviceIdCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref CreateDeviceIdCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Connect
[UnmanagedFunctionPointer(2)]
internal sealed class OnCreateDeviceIdCallbackInternal : MulticastDelegate // TypeDefIndex: 9891
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref CreateDeviceIdCallbackInfoInternal data) { }

	// RVA: 0x50FEF0 Offset: 0x50F0F0 VA: 0x18050FEF0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref CreateDeviceIdCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref CreateDeviceIdCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Connect
public sealed class OnCreateUserCallback : MulticastDelegate // TypeDefIndex: 9892
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref CreateUserCallbackInfo data) { }

	// RVA: 0x5100A0 Offset: 0x50F2A0 VA: 0x1805100A0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref CreateUserCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref CreateUserCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Connect
[UnmanagedFunctionPointer(2)]
internal sealed class OnCreateUserCallbackInternal : MulticastDelegate // TypeDefIndex: 9893
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref CreateUserCallbackInfoInternal data) { }

	// RVA: 0x510010 Offset: 0x50F210 VA: 0x180510010 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref CreateUserCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref CreateUserCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Connect
public sealed class OnDeleteDeviceIdCallback : MulticastDelegate // TypeDefIndex: 9894
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref DeleteDeviceIdCallbackInfo data) { }

	// RVA: 0x511880 Offset: 0x510A80 VA: 0x180511880 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref DeleteDeviceIdCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref DeleteDeviceIdCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Connect
[UnmanagedFunctionPointer(2)]
internal sealed class OnDeleteDeviceIdCallbackInternal : MulticastDelegate // TypeDefIndex: 9895
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref DeleteDeviceIdCallbackInfoInternal data) { }

	// RVA: 0x5117F0 Offset: 0x5109F0 VA: 0x1805117F0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref DeleteDeviceIdCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref DeleteDeviceIdCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Connect
public sealed class OnLinkAccountCallback : MulticastDelegate // TypeDefIndex: 9896
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref LinkAccountCallbackInfo data) { }

	// RVA: 0x5119A0 Offset: 0x510BA0 VA: 0x1805119A0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref LinkAccountCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref LinkAccountCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Connect
[UnmanagedFunctionPointer(2)]
internal sealed class OnLinkAccountCallbackInternal : MulticastDelegate // TypeDefIndex: 9897
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref LinkAccountCallbackInfoInternal data) { }

	// RVA: 0x511910 Offset: 0x510B10 VA: 0x180511910 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref LinkAccountCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref LinkAccountCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Connect
public sealed class OnLoginCallback : MulticastDelegate // TypeDefIndex: 9898
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref LoginCallbackInfo data) { }

	// RVA: 0x511AC0 Offset: 0x510CC0 VA: 0x180511AC0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref LoginCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref LoginCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Connect
[UnmanagedFunctionPointer(2)]
internal sealed class OnLoginCallbackInternal : MulticastDelegate // TypeDefIndex: 9899
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref LoginCallbackInfoInternal data) { }

	// RVA: 0x511A30 Offset: 0x510C30 VA: 0x180511A30 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref LoginCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref LoginCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Connect
public sealed class OnLoginStatusChangedCallback : MulticastDelegate // TypeDefIndex: 9900
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref LoginStatusChangedCallbackInfo data) { }

	// RVA: 0x511BE0 Offset: 0x510DE0 VA: 0x180511BE0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref LoginStatusChangedCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref LoginStatusChangedCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Connect
[UnmanagedFunctionPointer(2)]
internal sealed class OnLoginStatusChangedCallbackInternal : MulticastDelegate // TypeDefIndex: 9901
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref LoginStatusChangedCallbackInfoInternal data) { }

	// RVA: 0x511B50 Offset: 0x510D50 VA: 0x180511B50 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref LoginStatusChangedCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref LoginStatusChangedCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Connect
public sealed class OnLogoutCallback : MulticastDelegate // TypeDefIndex: 9902
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref LogoutCallbackInfo data) { }

	// RVA: 0x511D00 Offset: 0x510F00 VA: 0x180511D00 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref LogoutCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref LogoutCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Connect
[UnmanagedFunctionPointer(2)]
internal sealed class OnLogoutCallbackInternal : MulticastDelegate // TypeDefIndex: 9903
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref LogoutCallbackInfoInternal data) { }

	// RVA: 0x511C70 Offset: 0x510E70 VA: 0x180511C70 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref LogoutCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref LogoutCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Connect
public sealed class OnQueryExternalAccountMappingsCallback : MulticastDelegate // TypeDefIndex: 9904
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref QueryExternalAccountMappingsCallbackInfo data) { }

	// RVA: 0x512060 Offset: 0x511260 VA: 0x180512060 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref QueryExternalAccountMappingsCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref QueryExternalAccountMappingsCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Connect
[UnmanagedFunctionPointer(2)]
internal sealed class OnQueryExternalAccountMappingsCallbackInternal : MulticastDelegate // TypeDefIndex: 9905
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref QueryExternalAccountMappingsCallbackInfoInternal data) { }

	// RVA: 0x511FD0 Offset: 0x5111D0 VA: 0x180511FD0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref QueryExternalAccountMappingsCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref QueryExternalAccountMappingsCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Connect
public sealed class OnQueryProductUserIdMappingsCallback : MulticastDelegate // TypeDefIndex: 9906
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref QueryProductUserIdMappingsCallbackInfo data) { }

	// RVA: 0x512570 Offset: 0x511770 VA: 0x180512570 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref QueryProductUserIdMappingsCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref QueryProductUserIdMappingsCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Connect
[UnmanagedFunctionPointer(2)]
internal sealed class OnQueryProductUserIdMappingsCallbackInternal : MulticastDelegate // TypeDefIndex: 9907
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref QueryProductUserIdMappingsCallbackInfoInternal data) { }

	// RVA: 0x52B580 Offset: 0x52A780 VA: 0x18052B580 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref QueryProductUserIdMappingsCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref QueryProductUserIdMappingsCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Connect
public sealed class OnTransferDeviceIdAccountCallback : MulticastDelegate // TypeDefIndex: 9908
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref TransferDeviceIdAccountCallbackInfo data) { }

	// RVA: 0x52B6A0 Offset: 0x52A8A0 VA: 0x18052B6A0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref TransferDeviceIdAccountCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref TransferDeviceIdAccountCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Connect
[UnmanagedFunctionPointer(2)]
internal sealed class OnTransferDeviceIdAccountCallbackInternal : MulticastDelegate // TypeDefIndex: 9909
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref TransferDeviceIdAccountCallbackInfoInternal data) { }

	// RVA: 0x52B610 Offset: 0x52A810 VA: 0x18052B610 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref TransferDeviceIdAccountCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref TransferDeviceIdAccountCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Connect
public sealed class OnUnlinkAccountCallback : MulticastDelegate // TypeDefIndex: 9910
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref UnlinkAccountCallbackInfo data) { }

	// RVA: 0x52B7C0 Offset: 0x52A9C0 VA: 0x18052B7C0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref UnlinkAccountCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref UnlinkAccountCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Connect
[UnmanagedFunctionPointer(2)]
internal sealed class OnUnlinkAccountCallbackInternal : MulticastDelegate // TypeDefIndex: 9911
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref UnlinkAccountCallbackInfoInternal data) { }

	// RVA: 0x52B730 Offset: 0x52A930 VA: 0x18052B730 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref UnlinkAccountCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref UnlinkAccountCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Connect
public sealed class OnVerifyIdTokenCallback : MulticastDelegate // TypeDefIndex: 9912
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref VerifyIdTokenCallbackInfo data) { }

	// RVA: 0x52B970 Offset: 0x52AB70 VA: 0x18052B970 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref VerifyIdTokenCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref VerifyIdTokenCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Connect
[UnmanagedFunctionPointer(2)]
internal sealed class OnVerifyIdTokenCallbackInternal : MulticastDelegate // TypeDefIndex: 9913
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref VerifyIdTokenCallbackInfoInternal data) { }

	// RVA: 0x52B8E0 Offset: 0x52AAE0 VA: 0x18052B8E0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref VerifyIdTokenCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref VerifyIdTokenCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Connect
public struct QueryExternalAccountMappingsCallbackInfo : ICallbackInfo // TypeDefIndex: 9914
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

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x52C9C0 Offset: 0x52BBC0 VA: 0x18052C9C0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x52CA10 Offset: 0x52BC10 VA: 0x18052CA10
	internal void Set(ref QueryExternalAccountMappingsCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.Connect
internal struct QueryExternalAccountMappingsCallbackInfoInternal : ICallbackInfoInternal, IGettable<QueryExternalAccountMappingsCallbackInfo>, ISettable<QueryExternalAccountMappingsCallbackInfo>, IDisposable // TypeDefIndex: 9915
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

	// RVA: 0x52C810 Offset: 0x52BA10 VA: 0x18052C810
	public object get_ClientData() { }

	// RVA: 0x52C900 Offset: 0x52BB00 VA: 0x18052C900
	public void set_ClientData(object value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x52C880 Offset: 0x52BA80 VA: 0x18052C880
	public ProductUserId get_LocalUserId() { }

	// RVA: 0x52C960 Offset: 0x52BB60 VA: 0x18052C960
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x52C760 Offset: 0x52B960 VA: 0x18052C760 Slot: 6
	public void Set(ref QueryExternalAccountMappingsCallbackInfo other) { }

	// RVA: 0x52C640 Offset: 0x52B840 VA: 0x18052C640 Slot: 7
	public void Set(ref Nullable<QueryExternalAccountMappingsCallbackInfo> other) { }

	// RVA: 0x52C5C0 Offset: 0x52B7C0 VA: 0x18052C5C0 Slot: 8
	public void Dispose() { }

	// RVA: 0x52C620 Offset: 0x52B820 VA: 0x18052C620 Slot: 5
	public void Get(out QueryExternalAccountMappingsCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.Connect
public struct QueryExternalAccountMappingsOptions // TypeDefIndex: 9916
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private ExternalAccountType <AccountIdType>k__BackingField; // 0x8
	[CompilerGenerated]
	private Utf8String[] <ExternalAccountIds>k__BackingField; // 0x10

	// Properties
	public ProductUserId LocalUserId { get; set; }
	public ExternalAccountType AccountIdType { get; set; }
	public Utf8String[] ExternalAccountIds { get; set; }

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
	public ExternalAccountType get_AccountIdType() { }

	[CompilerGenerated]
	// RVA: 0x3F5520 Offset: 0x3F4720 VA: 0x1803F5520
	public void set_AccountIdType(ExternalAccountType value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Utf8String[] get_ExternalAccountIds() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_ExternalAccountIds(Utf8String[] value) { }
}

// Namespace: Epic.OnlineServices.Connect
internal struct QueryExternalAccountMappingsOptionsInternal : ISettable<QueryExternalAccountMappingsOptions>, IDisposable // TypeDefIndex: 9917
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private ExternalAccountType m_AccountIdType; // 0x10
	private IntPtr m_ExternalAccountIds; // 0x18
	private uint m_ExternalAccountIdCount; // 0x20

	// Properties
	public ProductUserId LocalUserId { set; }
	public ExternalAccountType AccountIdType { set; }
	public Utf8String[] ExternalAccountIds { set; }

	// Methods

	// RVA: 0x52CD00 Offset: 0x52BF00 VA: 0x18052CD00
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_AccountIdType(ExternalAccountType value) { }

	// RVA: 0x52CC80 Offset: 0x52BE80 VA: 0x18052CC80
	public void set_ExternalAccountIds(Utf8String[] value) { }

	// RVA: 0x52CBF0 Offset: 0x52BDF0 VA: 0x18052CBF0 Slot: 4
	public void Set(ref QueryExternalAccountMappingsOptions other) { }

	// RVA: 0x52CB00 Offset: 0x52BD00 VA: 0x18052CB00 Slot: 5
	public void Set(ref Nullable<QueryExternalAccountMappingsOptions> other) { }

	// RVA: 0x52CAA0 Offset: 0x52BCA0 VA: 0x18052CAA0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Connect
public struct QueryProductUserIdMappingsCallbackInfo : ICallbackInfo // TypeDefIndex: 9918
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

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x52DAB0 Offset: 0x52CCB0 VA: 0x18052DAB0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x52DB00 Offset: 0x52CD00 VA: 0x18052DB00
	internal void Set(ref QueryProductUserIdMappingsCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.Connect
internal struct QueryProductUserIdMappingsCallbackInfoInternal : ICallbackInfoInternal, IGettable<QueryProductUserIdMappingsCallbackInfo>, ISettable<QueryProductUserIdMappingsCallbackInfo>, IDisposable // TypeDefIndex: 9919
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

	// RVA: 0x52D900 Offset: 0x52CB00 VA: 0x18052D900
	public object get_ClientData() { }

	// RVA: 0x52D9F0 Offset: 0x52CBF0 VA: 0x18052D9F0
	public void set_ClientData(object value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x52D970 Offset: 0x52CB70 VA: 0x18052D970
	public ProductUserId get_LocalUserId() { }

	// RVA: 0x52DA50 Offset: 0x52CC50 VA: 0x18052DA50
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x52D850 Offset: 0x52CA50 VA: 0x18052D850 Slot: 6
	public void Set(ref QueryProductUserIdMappingsCallbackInfo other) { }

	// RVA: 0x52D730 Offset: 0x52C930 VA: 0x18052D730 Slot: 7
	public void Set(ref Nullable<QueryProductUserIdMappingsCallbackInfo> other) { }

	// RVA: 0x52D6B0 Offset: 0x52C8B0 VA: 0x18052D6B0 Slot: 8
	public void Dispose() { }

	// RVA: 0x52D710 Offset: 0x52C910 VA: 0x18052D710 Slot: 5
	public void Get(out QueryProductUserIdMappingsCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.Connect
public struct QueryProductUserIdMappingsOptions // TypeDefIndex: 9920
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private ExternalAccountType <AccountIdType_DEPRECATED>k__BackingField; // 0x8
	[CompilerGenerated]
	private ProductUserId[] <ProductUserIds>k__BackingField; // 0x10

	// Properties
	public ProductUserId LocalUserId { get; set; }
	internal ExternalAccountType AccountIdType_DEPRECATED { get; set; }
	public ProductUserId[] ProductUserIds { get; set; }

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
	internal ExternalAccountType get_AccountIdType_DEPRECATED() { }

	[CompilerGenerated]
	// RVA: 0x3F5520 Offset: 0x3F4720 VA: 0x1803F5520
	internal void set_AccountIdType_DEPRECATED(ExternalAccountType value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public ProductUserId[] get_ProductUserIds() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_ProductUserIds(ProductUserId[] value) { }
}

// Namespace: Epic.OnlineServices.Connect
internal struct QueryProductUserIdMappingsOptionsInternal : ISettable<QueryProductUserIdMappingsOptions>, IDisposable // TypeDefIndex: 9921
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private ExternalAccountType m_AccountIdType_DEPRECATED; // 0x10
	private IntPtr m_ProductUserIds; // 0x18
	private uint m_ProductUserIdCount; // 0x20

	// Properties
	public ProductUserId LocalUserId { set; }
	public ExternalAccountType AccountIdType_DEPRECATED { set; }
	public ProductUserId[] ProductUserIds { set; }

	// Methods

	// RVA: 0x52DDB0 Offset: 0x52CFB0 VA: 0x18052DDB0
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_AccountIdType_DEPRECATED(ExternalAccountType value) { }

	// RVA: 0x52DE10 Offset: 0x52D010 VA: 0x18052DE10
	public void set_ProductUserIds(ProductUserId[] value) { }

	// RVA: 0x52DCE0 Offset: 0x52CEE0 VA: 0x18052DCE0 Slot: 4
	public void Set(ref QueryProductUserIdMappingsOptions other) { }

	// RVA: 0x52DBF0 Offset: 0x52CDF0 VA: 0x18052DBF0 Slot: 5
	public void Set(ref Nullable<QueryProductUserIdMappingsOptions> other) { }

	// RVA: 0x52DB90 Offset: 0x52CD90 VA: 0x18052DB90 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Connect
public struct TransferDeviceIdAccountCallbackInfo : ICallbackInfo // TypeDefIndex: 9922
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

	// RVA: 0x52F960 Offset: 0x52EB60 VA: 0x18052F960 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x52F9B0 Offset: 0x52EBB0 VA: 0x18052F9B0
	internal void Set(ref TransferDeviceIdAccountCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.Connect
internal struct TransferDeviceIdAccountCallbackInfoInternal : ICallbackInfoInternal, IGettable<TransferDeviceIdAccountCallbackInfo>, ISettable<TransferDeviceIdAccountCallbackInfo>, IDisposable // TypeDefIndex: 9923
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

	// RVA: 0x52F7B0 Offset: 0x52E9B0 VA: 0x18052F7B0
	public object get_ClientData() { }

	// RVA: 0x52F8A0 Offset: 0x52EAA0 VA: 0x18052F8A0
	public void set_ClientData(object value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x52F820 Offset: 0x52EA20 VA: 0x18052F820
	public ProductUserId get_LocalUserId() { }

	// RVA: 0x52F900 Offset: 0x52EB00 VA: 0x18052F900
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x52F5E0 Offset: 0x52E7E0 VA: 0x18052F5E0 Slot: 6
	public void Set(ref TransferDeviceIdAccountCallbackInfo other) { }

	// RVA: 0x52F690 Offset: 0x52E890 VA: 0x18052F690 Slot: 7
	public void Set(ref Nullable<TransferDeviceIdAccountCallbackInfo> other) { }

	// RVA: 0x52F560 Offset: 0x52E760 VA: 0x18052F560 Slot: 8
	public void Dispose() { }

	// RVA: 0x52F5C0 Offset: 0x52E7C0 VA: 0x18052F5C0 Slot: 5
	public void Get(out TransferDeviceIdAccountCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.Connect
public struct TransferDeviceIdAccountOptions // TypeDefIndex: 9924
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <PrimaryLocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private ProductUserId <LocalDeviceUserId>k__BackingField; // 0x8
	[CompilerGenerated]
	private ProductUserId <ProductUserIdToPreserve>k__BackingField; // 0x10

	// Properties
	public ProductUserId PrimaryLocalUserId { get; set; }
	public ProductUserId LocalDeviceUserId { get; set; }
	public ProductUserId ProductUserIdToPreserve { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public ProductUserId get_PrimaryLocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_PrimaryLocalUserId(ProductUserId value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public ProductUserId get_LocalDeviceUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_LocalDeviceUserId(ProductUserId value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public ProductUserId get_ProductUserIdToPreserve() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_ProductUserIdToPreserve(ProductUserId value) { }
}

// Namespace: Epic.OnlineServices.Connect
internal struct TransferDeviceIdAccountOptionsInternal : ISettable<TransferDeviceIdAccountOptions>, IDisposable // TypeDefIndex: 9925
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_PrimaryLocalUserId; // 0x8
	private IntPtr m_LocalDeviceUserId; // 0x10
	private IntPtr m_ProductUserIdToPreserve; // 0x18

	// Properties
	public ProductUserId PrimaryLocalUserId { set; }
	public ProductUserId LocalDeviceUserId { set; }
	public ProductUserId ProductUserIdToPreserve { set; }

	// Methods

	// RVA: 0x52FD60 Offset: 0x52EF60 VA: 0x18052FD60
	public void set_PrimaryLocalUserId(ProductUserId value) { }

	// RVA: 0x52FD00 Offset: 0x52EF00 VA: 0x18052FD00
	public void set_LocalDeviceUserId(ProductUserId value) { }

	// RVA: 0x52FDC0 Offset: 0x52EFC0 VA: 0x18052FDC0
	public void set_ProductUserIdToPreserve(ProductUserId value) { }

	// RVA: 0x52FAA0 Offset: 0x52ECA0 VA: 0x18052FAA0 Slot: 4
	public void Set(ref TransferDeviceIdAccountOptions other) { }

	// RVA: 0x52FBA0 Offset: 0x52EDA0 VA: 0x18052FBA0 Slot: 5
	public void Set(ref Nullable<TransferDeviceIdAccountOptions> other) { }

	// RVA: 0x52FA40 Offset: 0x52EC40 VA: 0x18052FA40 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Connect
public struct UnlinkAccountCallbackInfo : ICallbackInfo // TypeDefIndex: 9926
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

	// RVA: 0x530220 Offset: 0x52F420 VA: 0x180530220 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x530270 Offset: 0x52F470 VA: 0x180530270
	internal void Set(ref UnlinkAccountCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.Connect
internal struct UnlinkAccountCallbackInfoInternal : ICallbackInfoInternal, IGettable<UnlinkAccountCallbackInfo>, ISettable<UnlinkAccountCallbackInfo>, IDisposable // TypeDefIndex: 9927
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

	// RVA: 0x530070 Offset: 0x52F270 VA: 0x180530070
	public object get_ClientData() { }

	// RVA: 0x530160 Offset: 0x52F360 VA: 0x180530160
	public void set_ClientData(object value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x5300E0 Offset: 0x52F2E0 VA: 0x1805300E0
	public ProductUserId get_LocalUserId() { }

	// RVA: 0x5301C0 Offset: 0x52F3C0 VA: 0x1805301C0
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x52FFC0 Offset: 0x52F1C0 VA: 0x18052FFC0 Slot: 6
	public void Set(ref UnlinkAccountCallbackInfo other) { }

	// RVA: 0x52FEA0 Offset: 0x52F0A0 VA: 0x18052FEA0 Slot: 7
	public void Set(ref Nullable<UnlinkAccountCallbackInfo> other) { }

	// RVA: 0x52FE20 Offset: 0x52F020 VA: 0x18052FE20 Slot: 8
	public void Dispose() { }

	// RVA: 0x52FE80 Offset: 0x52F080 VA: 0x18052FE80 Slot: 5
	public void Get(out UnlinkAccountCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.Connect
public struct UnlinkAccountOptions // TypeDefIndex: 9928
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

// Namespace: Epic.OnlineServices.Connect
internal struct UnlinkAccountOptionsInternal : ISettable<UnlinkAccountOptions>, IDisposable // TypeDefIndex: 9929
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8

	// Properties
	public ProductUserId LocalUserId { set; }

	// Methods

	// RVA: 0x530450 Offset: 0x52F650 VA: 0x180530450
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x5303F0 Offset: 0x52F5F0 VA: 0x1805303F0 Slot: 4
	public void Set(ref UnlinkAccountOptions other) { }

	// RVA: 0x530350 Offset: 0x52F550 VA: 0x180530350 Slot: 5
	public void Set(ref Nullable<UnlinkAccountOptions> other) { }

	// RVA: 0x530300 Offset: 0x52F500 VA: 0x180530300 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Connect
public struct UserLoginInfo // TypeDefIndex: 9930
{
	// Fields
	[CompilerGenerated]
	private Utf8String <DisplayName>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <NsaIdToken>k__BackingField; // 0x8

	// Properties
	public Utf8String DisplayName { get; set; }
	public Utf8String NsaIdToken { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Utf8String get_DisplayName() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_DisplayName(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public Utf8String get_NsaIdToken() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_NsaIdToken(Utf8String value) { }

	// RVA: 0x530BA0 Offset: 0x52FDA0 VA: 0x180530BA0
	internal void Set(ref UserLoginInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.Connect
internal struct UserLoginInfoInternal : IGettable<UserLoginInfo>, ISettable<UserLoginInfo>, IDisposable // TypeDefIndex: 9931
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_DisplayName; // 0x8
	private IntPtr m_NsaIdToken; // 0x10

	// Properties
	public Utf8String DisplayName { get; set; }
	public Utf8String NsaIdToken { get; set; }

	// Methods

	// RVA: 0x530A00 Offset: 0x52FC00 VA: 0x180530A00
	public Utf8String get_DisplayName() { }

	// RVA: 0x530AE0 Offset: 0x52FCE0 VA: 0x180530AE0
	public void set_DisplayName(Utf8String value) { }

	// RVA: 0x530A70 Offset: 0x52FC70 VA: 0x180530A70
	public Utf8String get_NsaIdToken() { }

	// RVA: 0x530B40 Offset: 0x52FD40 VA: 0x180530B40
	public void set_NsaIdToken(Utf8String value) { }

	// RVA: 0x530940 Offset: 0x52FB40 VA: 0x180530940 Slot: 5
	public void Set(ref UserLoginInfo other) { }

	// RVA: 0x530840 Offset: 0x52FA40 VA: 0x180530840 Slot: 6
	public void Set(ref Nullable<UserLoginInfo> other) { }

	// RVA: 0x5307C0 Offset: 0x52F9C0 VA: 0x1805307C0 Slot: 7
	public void Dispose() { }

	// RVA: 0x530820 Offset: 0x52FA20 VA: 0x180530820 Slot: 4
	public void Get(out UserLoginInfo output) { }
}

// Namespace: Epic.OnlineServices.Connect
public struct VerifyIdTokenCallbackInfo : ICallbackInfo // TypeDefIndex: 9932
{
	// Fields
	[CompilerGenerated]
	private Result <ResultCode>k__BackingField; // 0x0
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x8
	[CompilerGenerated]
	private ProductUserId <ProductUserId>k__BackingField; // 0x10
	[CompilerGenerated]
	private bool <IsAccountInfoPresent>k__BackingField; // 0x18
	[CompilerGenerated]
	private ExternalAccountType <AccountIdType>k__BackingField; // 0x1C
	[CompilerGenerated]
	private Utf8String <AccountId>k__BackingField; // 0x20
	[CompilerGenerated]
	private Utf8String <Platform>k__BackingField; // 0x28
	[CompilerGenerated]
	private Utf8String <DeviceType>k__BackingField; // 0x30
	[CompilerGenerated]
	private Utf8String <ClientId>k__BackingField; // 0x38
	[CompilerGenerated]
	private Utf8String <ProductId>k__BackingField; // 0x40
	[CompilerGenerated]
	private Utf8String <SandboxId>k__BackingField; // 0x48
	[CompilerGenerated]
	private Utf8String <DeploymentId>k__BackingField; // 0x50

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public ProductUserId ProductUserId { get; set; }
	public bool IsAccountInfoPresent { get; set; }
	public ExternalAccountType AccountIdType { get; set; }
	public Utf8String AccountId { get; set; }
	public Utf8String Platform { get; set; }
	public Utf8String DeviceType { get; set; }
	public Utf8String ClientId { get; set; }
	public Utf8String ProductId { get; set; }
	public Utf8String SandboxId { get; set; }
	public Utf8String DeploymentId { get; set; }

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
	public ProductUserId get_ProductUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_ProductUserId(ProductUserId value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x411B20 Offset: 0x410D20 VA: 0x180411B20
	public bool get_IsAccountInfoPresent() { }

	[CompilerGenerated]
	// RVA: 0x411B30 Offset: 0x410D30 VA: 0x180411B30
	public void set_IsAccountInfoPresent(bool value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3F9110 Offset: 0x3F8310 VA: 0x1803F9110
	public ExternalAccountType get_AccountIdType() { }

	[CompilerGenerated]
	// RVA: 0x3F9290 Offset: 0x3F8490 VA: 0x1803F9290
	public void set_AccountIdType(ExternalAccountType value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public Utf8String get_AccountId() { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_AccountId(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public Utf8String get_Platform() { }

	[CompilerGenerated]
	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	public void set_Platform(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public Utf8String get_DeviceType() { }

	[CompilerGenerated]
	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	public void set_DeviceType(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public Utf8String get_ClientId() { }

	[CompilerGenerated]
	// RVA: 0x40EC50 Offset: 0x40DE50 VA: 0x18040EC50
	public void set_ClientId(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	public Utf8String get_ProductId() { }

	[CompilerGenerated]
	// RVA: 0x415820 Offset: 0x414A20 VA: 0x180415820
	public void set_ProductId(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0
	public Utf8String get_SandboxId() { }

	[CompilerGenerated]
	// RVA: 0x41A200 Offset: 0x419400 VA: 0x18041A200
	public void set_SandboxId(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0
	public Utf8String get_DeploymentId() { }

	[CompilerGenerated]
	// RVA: 0x4050C0 Offset: 0x4042C0 VA: 0x1804050C0
	public void set_DeploymentId(Utf8String value) { }

	// RVA: 0x532DA0 Offset: 0x531FA0 VA: 0x180532DA0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x5331A0 Offset: 0x5323A0 VA: 0x1805331A0
	internal void Set(ref VerifyIdTokenCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.Connect
internal struct VerifyIdTokenCallbackInfoInternal : ICallbackInfoInternal, IGettable<VerifyIdTokenCallbackInfo>, ISettable<VerifyIdTokenCallbackInfo>, IDisposable // TypeDefIndex: 9933
{
	// Fields
	private Result m_ResultCode; // 0x0
	private IntPtr m_ClientData; // 0x8
	private IntPtr m_ProductUserId; // 0x10
	private int m_IsAccountInfoPresent; // 0x18
	private ExternalAccountType m_AccountIdType; // 0x1C
	private IntPtr m_AccountId; // 0x20
	private IntPtr m_Platform; // 0x28
	private IntPtr m_DeviceType; // 0x30
	private IntPtr m_ClientId; // 0x38
	private IntPtr m_ProductId; // 0x40
	private IntPtr m_SandboxId; // 0x48
	private IntPtr m_DeploymentId; // 0x50

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public ProductUserId ProductUserId { get; set; }
	public bool IsAccountInfoPresent { get; set; }
	public ExternalAccountType AccountIdType { get; set; }
	public Utf8String AccountId { get; set; }
	public Utf8String Platform { get; set; }
	public Utf8String DeviceType { get; set; }
	public Utf8String ClientId { get; set; }
	public Utf8String ProductId { get; set; }
	public Utf8String SandboxId { get; set; }
	public Utf8String DeploymentId { get; set; }

	// Methods

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	// RVA: 0x531D30 Offset: 0x530F30 VA: 0x180531D30
	public object get_ClientData() { }

	// RVA: 0x532630 Offset: 0x531830 VA: 0x180532630
	public void set_ClientData(object value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x532410 Offset: 0x531610 VA: 0x180532410
	public ProductUserId get_ProductUserId() { }

	// RVA: 0x532C30 Offset: 0x531E30 VA: 0x180532C30
	public void set_ProductUserId(ProductUserId value) { }

	// RVA: 0x532190 Offset: 0x531390 VA: 0x180532190
	public bool get_IsAccountInfoPresent() { }

	// RVA: 0x5329F0 Offset: 0x531BF0 VA: 0x1805329F0
	public void set_IsAccountInfoPresent(bool value) { }

	// RVA: 0x3F9110 Offset: 0x3F8310 VA: 0x1803F9110
	public ExternalAccountType get_AccountIdType() { }

	// RVA: 0x3F9290 Offset: 0x3F8490 VA: 0x1803F9290
	public void set_AccountIdType(ExternalAccountType value) { }

	// RVA: 0x531C50 Offset: 0x530E50 VA: 0x180531C50
	public Utf8String get_AccountId() { }

	// RVA: 0x532570 Offset: 0x531770 VA: 0x180532570
	public void set_AccountId(Utf8String value) { }

	// RVA: 0x5322C0 Offset: 0x5314C0 VA: 0x1805322C0
	public Utf8String get_Platform() { }

	// RVA: 0x532AB0 Offset: 0x531CB0 VA: 0x180532AB0
	public void set_Platform(Utf8String value) { }

	// RVA: 0x531FD0 Offset: 0x5311D0 VA: 0x180531FD0
	public Utf8String get_DeviceType() { }

	// RVA: 0x532870 Offset: 0x531A70 VA: 0x180532870
	public void set_DeviceType(Utf8String value) { }

	// RVA: 0x531E10 Offset: 0x531010 VA: 0x180531E10
	public Utf8String get_ClientId() { }

	// RVA: 0x5326F0 Offset: 0x5318F0 VA: 0x1805326F0
	public void set_ClientId(Utf8String value) { }

	// RVA: 0x532330 Offset: 0x531530 VA: 0x180532330
	public Utf8String get_ProductId() { }

	// RVA: 0x532BD0 Offset: 0x531DD0 VA: 0x180532BD0
	public void set_ProductId(Utf8String value) { }

	// RVA: 0x532490 Offset: 0x531690 VA: 0x180532490
	public Utf8String get_SandboxId() { }

	// RVA: 0x532CF0 Offset: 0x531EF0 VA: 0x180532CF0
	public void set_SandboxId(Utf8String value) { }

	// RVA: 0x531EF0 Offset: 0x5310F0 VA: 0x180531EF0
	public Utf8String get_DeploymentId() { }

	// RVA: 0x532810 Offset: 0x531A10 VA: 0x180532810
	public void set_DeploymentId(Utf8String value) { }

	// RVA: 0x530E40 Offset: 0x530040 VA: 0x180530E40 Slot: 6
	public void Set(ref VerifyIdTokenCallbackInfo other) { }

	// RVA: 0x531120 Offset: 0x530320 VA: 0x180531120 Slot: 7
	public void Set(ref Nullable<VerifyIdTokenCallbackInfo> other) { }

	// RVA: 0x530D30 Offset: 0x52FF30 VA: 0x180530D30 Slot: 8
	public void Dispose() { }

	// RVA: 0x530E10 Offset: 0x530010 VA: 0x180530E10 Slot: 5
	public void Get(out VerifyIdTokenCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.Connect
public struct VerifyIdTokenOptions // TypeDefIndex: 9934
{
	// Fields
	[CompilerGenerated]
	private Nullable<IdToken> <IdToken>k__BackingField; // 0x0

	// Properties
	public Nullable<IdToken> IdToken { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x4BBD30 Offset: 0x4BAF30 VA: 0x1804BBD30
	public Nullable<IdToken> get_IdToken() { }

	[CompilerGenerated]
	// RVA: 0x4BBD50 Offset: 0x4BAF50 VA: 0x1804BBD50
	public void set_IdToken(Nullable<IdToken> value) { }
}

// Namespace: Epic.OnlineServices.Connect
internal struct VerifyIdTokenOptionsInternal : ISettable<VerifyIdTokenOptions>, IDisposable // TypeDefIndex: 9935
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_IdToken; // 0x8

	// Properties
	public Nullable<IdToken> IdToken { set; }

	// Methods

	// RVA: 0x533870 Offset: 0x532A70 VA: 0x180533870
	public void set_IdToken(Nullable<IdToken> value) { }

	// RVA: 0x533560 Offset: 0x532760 VA: 0x180533560 Slot: 4
	public void Set(ref VerifyIdTokenOptions other) { }

	// RVA: 0x533730 Offset: 0x532930 VA: 0x180533730 Slot: 5
	public void Set(ref Nullable<VerifyIdTokenOptions> other) { }

	// RVA: 0x533510 Offset: 0x532710 VA: 0x180533510 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Auth
public struct AccountFeatureRestrictedInfo // TypeDefIndex: 9936
{
	// Fields
	[CompilerGenerated]
	private Utf8String <VerificationURI>k__BackingField; // 0x0

	// Properties
	public Utf8String VerificationURI { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Utf8String get_VerificationURI() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_VerificationURI(Utf8String value) { }

	// RVA: 0x51BA10 Offset: 0x51AC10 VA: 0x18051BA10
	internal void Set(ref AccountFeatureRestrictedInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.Auth
internal struct AccountFeatureRestrictedInfoInternal : IGettable<AccountFeatureRestrictedInfo>, ISettable<AccountFeatureRestrictedInfo>, IDisposable // TypeDefIndex: 9937
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_VerificationURI; // 0x8

	// Properties
	public Utf8String VerificationURI { get; set; }

	// Methods

	// RVA: 0x51B940 Offset: 0x51AB40 VA: 0x18051B940
	public Utf8String get_VerificationURI() { }

	// RVA: 0x51B9B0 Offset: 0x51ABB0 VA: 0x18051B9B0
	public void set_VerificationURI(Utf8String value) { }

	// RVA: 0x51B840 Offset: 0x51AA40 VA: 0x18051B840 Slot: 5
	public void Set(ref AccountFeatureRestrictedInfo other) { }

	// RVA: 0x51B8A0 Offset: 0x51AAA0 VA: 0x18051B8A0 Slot: 6
	public void Set(ref Nullable<AccountFeatureRestrictedInfo> other) { }

	// RVA: 0x51B7D0 Offset: 0x51A9D0 VA: 0x18051B7D0 Slot: 7
	public void Dispose() { }

	// RVA: 0x51B820 Offset: 0x51AA20 VA: 0x18051B820 Slot: 4
	public void Get(out AccountFeatureRestrictedInfo output) { }
}

// Namespace: Epic.OnlineServices.Auth
public struct AddNotifyLoginStatusChangedOptions // TypeDefIndex: 9938
{}

// Namespace: Epic.OnlineServices.Auth
internal struct AddNotifyLoginStatusChangedOptionsInternal : ISettable<AddNotifyLoginStatusChangedOptions>, IDisposable // TypeDefIndex: 9939
{
	// Fields
	private int m_ApiVersion; // 0x0

	// Methods

	// RVA: 0x3F98A0 Offset: 0x3F8AA0 VA: 0x1803F98A0 Slot: 4
	public void Set(ref AddNotifyLoginStatusChangedOptions other) { }

	// RVA: 0x51BB30 Offset: 0x51AD30 VA: 0x18051BB30 Slot: 5
	public void Set(ref Nullable<AddNotifyLoginStatusChangedOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Auth
public sealed class AuthInterface : Handle // TypeDefIndex: 9940
{
	// Fields
	public const int AccountfeaturerestrictedinfoApiLatest = 1;
	public const int AddnotifyloginstatuschangedApiLatest = 1;
	public const int CopyidtokenApiLatest = 1;
	public const int CopyuserauthtokenApiLatest = 1;
	public const int CredentialsApiLatest = 4;
	public const int DeletepersistentauthApiLatest = 2;
	public const int IdtokenApiLatest = 1;
	public const int LinkaccountApiLatest = 1;
	public const int LoginApiLatest = 3;
	public const int LogoutApiLatest = 1;
	public const int PingrantinfoApiLatest = 2;
	public const int QueryidtokenApiLatest = 1;
	public const int TokenApiLatest = 2;
	public const int VerifyidtokenApiLatest = 1;
	public const int VerifyuserauthApiLatest = 1;
	public const int IosCredentialssystemauthcredentialsoptionsApiLatest = 2;

	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }

	// RVA: 0x40BDB0 Offset: 0x40AFB0 VA: 0x18040BDB0
	public void .ctor(IntPtr innerHandle) { }

	// RVA: 0x51D530 Offset: 0x51C730 VA: 0x18051D530
	public ulong AddNotifyLoginStatusChanged(ref AddNotifyLoginStatusChangedOptions options, object clientData, OnLoginStatusChangedCallback notification) { }

	// RVA: 0x51D6E0 Offset: 0x51C8E0 VA: 0x18051D6E0
	public Result CopyIdToken(ref CopyIdTokenOptions options, out Nullable<IdToken> outIdToken) { }

	// RVA: 0x51D810 Offset: 0x51CA10 VA: 0x18051D810
	public Result CopyUserAuthToken(ref CopyUserAuthTokenOptions options, EpicAccountId localUserId, out Nullable<Token> outUserAuthToken) { }

	// RVA: 0x51D910 Offset: 0x51CB10 VA: 0x18051D910
	public void DeletePersistentAuth(ref DeletePersistentAuthOptions options, object clientData, OnDeletePersistentAuthCallback completionDelegate) { }

	// RVA: 0x51DB00 Offset: 0x51CD00 VA: 0x18051DB00
	public EpicAccountId GetLoggedInAccountByIndex(int index) { }

	// RVA: 0x51DB90 Offset: 0x51CD90 VA: 0x18051DB90
	public int GetLoggedInAccountsCount() { }

	// RVA: 0x51DBA0 Offset: 0x51CDA0 VA: 0x18051DBA0
	public LoginStatus GetLoginStatus(EpicAccountId localUserId) { }

	// RVA: 0x51DC20 Offset: 0x51CE20 VA: 0x18051DC20
	public EpicAccountId GetMergedAccountByIndex(EpicAccountId localUserId, uint index) { }

	// RVA: 0x51DCD0 Offset: 0x51CED0 VA: 0x18051DCD0
	public uint GetMergedAccountsCount(EpicAccountId localUserId) { }

	// RVA: 0x51DD50 Offset: 0x51CF50 VA: 0x18051DD50
	public Result GetSelectedAccountId(EpicAccountId localUserId, out EpicAccountId outSelectedAccountId) { }

	// RVA: 0x51DEF0 Offset: 0x51D0F0 VA: 0x18051DEF0
	public void LinkAccount(ref LinkAccountOptions options, object clientData, OnLinkAccountCallback completionDelegate) { }

	// RVA: 0x51E250 Offset: 0x51D450 VA: 0x18051E250
	public void Login(ref LoginOptions options, object clientData, OnLoginCallback completionDelegate) { }

	// RVA: 0x51E480 Offset: 0x51D680 VA: 0x18051E480
	public void Logout(ref LogoutOptions options, object clientData, OnLogoutCallback completionDelegate) { }

	// RVA: 0x51EC20 Offset: 0x51DE20 VA: 0x18051EC20
	public void QueryIdToken(ref QueryIdTokenOptions options, object clientData, OnQueryIdTokenCallback completionDelegate) { }

	// RVA: 0x51EDD0 Offset: 0x51DFD0 VA: 0x18051EDD0
	public void RemoveNotifyLoginStatusChanged(ulong inId) { }

	// RVA: 0x51EE40 Offset: 0x51E040 VA: 0x18051EE40
	public void VerifyIdToken(ref VerifyIdTokenOptions options, object clientData, OnVerifyIdTokenCallback completionDelegate) { }

	// RVA: 0x51F050 Offset: 0x51E250 VA: 0x18051F050
	public void VerifyUserAuth(ref VerifyUserAuthOptions options, object clientData, OnVerifyUserAuthCallback completionDelegate) { }

	[MonoPInvokeCallback(typeof(OnDeletePersistentAuthCallbackInternal))]
	// RVA: 0x51E670 Offset: 0x51D870 VA: 0x18051E670
	internal static void OnDeletePersistentAuthCallbackInternalImplementation(ref DeletePersistentAuthCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnLinkAccountCallbackInternal))]
	// RVA: 0x51E710 Offset: 0x51D910 VA: 0x18051E710
	internal static void OnLinkAccountCallbackInternalImplementation(ref LinkAccountCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnLoginCallbackInternal))]
	// RVA: 0x51E7D0 Offset: 0x51D9D0 VA: 0x18051E7D0
	internal static void OnLoginCallbackInternalImplementation(ref LoginCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnLoginStatusChangedCallbackInternal))]
	// RVA: 0x51E8A0 Offset: 0x51DAA0 VA: 0x18051E8A0
	internal static void OnLoginStatusChangedCallbackInternalImplementation(ref LoginStatusChangedCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnLogoutCallbackInternal))]
	// RVA: 0x51E950 Offset: 0x51DB50 VA: 0x18051E950
	internal static void OnLogoutCallbackInternalImplementation(ref LogoutCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnQueryIdTokenCallbackInternal))]
	// RVA: 0x51EA00 Offset: 0x51DC00 VA: 0x18051EA00
	internal static void OnQueryIdTokenCallbackInternalImplementation(ref QueryIdTokenCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnVerifyIdTokenCallbackInternal))]
	// RVA: 0x51EAB0 Offset: 0x51DCB0 VA: 0x18051EAB0
	internal static void OnVerifyIdTokenCallbackInternalImplementation(ref VerifyIdTokenCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnVerifyUserAuthCallbackInternal))]
	// RVA: 0x51EB80 Offset: 0x51DD80 VA: 0x18051EB80
	internal static void OnVerifyUserAuthCallbackInternalImplementation(ref VerifyUserAuthCallbackInfoInternal data) { }

	// RVA: 0x51E0A0 Offset: 0x51D2A0 VA: 0x18051E0A0
	public void Login(ref IOSLoginOptions options, object clientData, OnLoginCallback completionDelegate) { }

	[MonoPInvokeCallback(typeof(IOSCreateBackgroundSnapshotViewInternal))]
	// RVA: 0x51DE10 Offset: 0x51D010 VA: 0x18051DE10
	internal static IntPtr IOSCreateBackgroundSnapshotViewInternalImplementation(IntPtr context) { }
}

// Namespace: Epic.OnlineServices.Auth
[Flags]
public enum AuthScopeFlags // TypeDefIndex: 9941
{
	// Fields
	public int value__; // 0x0
	public const AuthScopeFlags NoFlags = 0;
	public const AuthScopeFlags BasicProfile = 1;
	public const AuthScopeFlags FriendsList = 2;
	public const AuthScopeFlags Presence = 4;
	public const AuthScopeFlags FriendsManagement = 8;
	public const AuthScopeFlags Email = 16;
	public const AuthScopeFlags Country = 32;
}

// Namespace: Epic.OnlineServices.Auth
public enum AuthTokenType // TypeDefIndex: 9942
{
	// Fields
	public int value__; // 0x0
	public const AuthTokenType Client = 0;
	public const AuthTokenType User = 1;
}

// Namespace: Epic.OnlineServices.Auth
public struct CopyIdTokenOptions // TypeDefIndex: 9943
{
	// Fields
	[CompilerGenerated]
	private EpicAccountId <AccountId>k__BackingField; // 0x0

	// Properties
	public EpicAccountId AccountId { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public EpicAccountId get_AccountId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_AccountId(EpicAccountId value) { }
}

// Namespace: Epic.OnlineServices.Auth
internal struct CopyIdTokenOptionsInternal : ISettable<CopyIdTokenOptions>, IDisposable // TypeDefIndex: 9944
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_AccountId; // 0x8

	// Properties
	public EpicAccountId AccountId { set; }

	// Methods

	// RVA: 0x51F7D0 Offset: 0x51E9D0 VA: 0x18051F7D0
	public void set_AccountId(EpicAccountId value) { }

	// RVA: 0x51F770 Offset: 0x51E970 VA: 0x18051F770 Slot: 4
	public void Set(ref CopyIdTokenOptions other) { }

	// RVA: 0x51F6D0 Offset: 0x51E8D0 VA: 0x18051F6D0 Slot: 5
	public void Set(ref Nullable<CopyIdTokenOptions> other) { }

	// RVA: 0x51F680 Offset: 0x51E880 VA: 0x18051F680 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Auth
public struct CopyUserAuthTokenOptions // TypeDefIndex: 9945
{}

// Namespace: Epic.OnlineServices.Auth
internal struct CopyUserAuthTokenOptionsInternal : ISettable<CopyUserAuthTokenOptions>, IDisposable // TypeDefIndex: 9946
{
	// Fields
	private int m_ApiVersion; // 0x0

	// Methods

	// RVA: 0x3F98A0 Offset: 0x3F8AA0 VA: 0x1803F98A0 Slot: 4
	public void Set(ref CopyUserAuthTokenOptions other) { }

	// RVA: 0x51F830 Offset: 0x51EA30 VA: 0x18051F830 Slot: 5
	public void Set(ref Nullable<CopyUserAuthTokenOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Auth
public struct Credentials // TypeDefIndex: 9947
{
	// Fields
	[CompilerGenerated]
	private Utf8String <Id>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <Token>k__BackingField; // 0x8
	[CompilerGenerated]
	private LoginCredentialType <Type>k__BackingField; // 0x10
	[CompilerGenerated]
	private IntPtr <SystemAuthCredentialsOptions>k__BackingField; // 0x18
	[CompilerGenerated]
	private ExternalCredentialType <ExternalType>k__BackingField; // 0x20

	// Properties
	public Utf8String Id { get; set; }
	public Utf8String Token { get; set; }
	public LoginCredentialType Type { get; set; }
	public IntPtr SystemAuthCredentialsOptions { get; set; }
	public ExternalCredentialType ExternalType { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Utf8String get_Id() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_Id(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public Utf8String get_Token() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_Token(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public LoginCredentialType get_Type() { }

	[CompilerGenerated]
	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_Type(LoginCredentialType value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public IntPtr get_SystemAuthCredentialsOptions() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_SystemAuthCredentialsOptions(IntPtr value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA400 Offset: 0x3D9600 VA: 0x1803DA400
	public ExternalCredentialType get_ExternalType() { }

	[CompilerGenerated]
	// RVA: 0x3DA420 Offset: 0x3D9620 VA: 0x1803DA420
	public void set_ExternalType(ExternalCredentialType value) { }

	// RVA: 0x51FCE0 Offset: 0x51EEE0 VA: 0x18051FCE0
	internal void Set(ref CredentialsInternal other) { }
}

// Namespace: Epic.OnlineServices.Auth
internal struct CredentialsInternal : IGettable<Credentials>, ISettable<Credentials>, IDisposable // TypeDefIndex: 9948
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_Id; // 0x8
	private IntPtr m_Token; // 0x10
	private LoginCredentialType m_Type; // 0x18
	private IntPtr m_SystemAuthCredentialsOptions; // 0x20
	private ExternalCredentialType m_ExternalType; // 0x28

	// Properties
	public Utf8String Id { get; set; }
	public Utf8String Token { get; set; }
	public LoginCredentialType Type { get; set; }
	public IntPtr SystemAuthCredentialsOptions { get; set; }
	public ExternalCredentialType ExternalType { get; set; }

	// Methods

	// RVA: 0x51FB40 Offset: 0x51ED40 VA: 0x18051FB40
	public Utf8String get_Id() { }

	// RVA: 0x51FC20 Offset: 0x51EE20 VA: 0x18051FC20
	public void set_Id(Utf8String value) { }

	// RVA: 0x51FBB0 Offset: 0x51EDB0 VA: 0x18051FBB0
	public Utf8String get_Token() { }

	// RVA: 0x51FC80 Offset: 0x51EE80 VA: 0x18051FC80
	public void set_Token(Utf8String value) { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public LoginCredentialType get_Type() { }

	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	public void set_Type(LoginCredentialType value) { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public IntPtr get_SystemAuthCredentialsOptions() { }

	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_SystemAuthCredentialsOptions(IntPtr value) { }

	// RVA: 0x3DA050 Offset: 0x3D9250 VA: 0x1803DA050
	public ExternalCredentialType get_ExternalType() { }

	// RVA: 0x3DA200 Offset: 0x3D9400 VA: 0x1803DA200
	public void set_ExternalType(ExternalCredentialType value) { }

	// RVA: 0x51FA70 Offset: 0x51EC70 VA: 0x18051FA70 Slot: 5
	public void Set(ref Credentials other) { }

	// RVA: 0x51F910 Offset: 0x51EB10 VA: 0x18051F910 Slot: 6
	public void Set(ref Nullable<Credentials> other) { }

	// RVA: 0x51F880 Offset: 0x51EA80 VA: 0x18051F880 Slot: 7
	public void Dispose() { }

	// RVA: 0x51F8E0 Offset: 0x51EAE0 VA: 0x18051F8E0 Slot: 4
	public void Get(out Credentials output) { }
}

// Namespace: Epic.OnlineServices.Auth
public struct DeletePersistentAuthCallbackInfo : ICallbackInfo // TypeDefIndex: 9949
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

	// RVA: 0x520030 Offset: 0x51F230 VA: 0x180520030 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x520080 Offset: 0x51F280 VA: 0x180520080
	internal void Set(ref DeletePersistentAuthCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.Auth
internal struct DeletePersistentAuthCallbackInfoInternal : ICallbackInfoInternal, IGettable<DeletePersistentAuthCallbackInfo>, ISettable<DeletePersistentAuthCallbackInfo>, IDisposable // TypeDefIndex: 9950
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

	// RVA: 0x51FF60 Offset: 0x51F160 VA: 0x18051FF60
	public object get_ClientData() { }

	// RVA: 0x51FFD0 Offset: 0x51F1D0 VA: 0x18051FFD0
	public void set_ClientData(object value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x51FF00 Offset: 0x51F100 VA: 0x18051FF00 Slot: 6
	public void Set(ref DeletePersistentAuthCallbackInfo other) { }

	// RVA: 0x51FE40 Offset: 0x51F040 VA: 0x18051FE40 Slot: 7
	public void Set(ref Nullable<DeletePersistentAuthCallbackInfo> other) { }

	// RVA: 0x51FDD0 Offset: 0x51EFD0 VA: 0x18051FDD0 Slot: 8
	public void Dispose() { }

	// RVA: 0x51FE20 Offset: 0x51F020 VA: 0x18051FE20 Slot: 5
	public void Get(out DeletePersistentAuthCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.Auth
public struct DeletePersistentAuthOptions // TypeDefIndex: 9951
{
	// Fields
	[CompilerGenerated]
	private Utf8String <RefreshToken>k__BackingField; // 0x0

	// Properties
	public Utf8String RefreshToken { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Utf8String get_RefreshToken() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_RefreshToken(Utf8String value) { }
}

// Namespace: Epic.OnlineServices.Auth
internal struct DeletePersistentAuthOptionsInternal : ISettable<DeletePersistentAuthOptions>, IDisposable // TypeDefIndex: 9952
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_RefreshToken; // 0x8

	// Properties
	public Utf8String RefreshToken { set; }

	// Methods

	// RVA: 0x520250 Offset: 0x51F450 VA: 0x180520250
	public void set_RefreshToken(Utf8String value) { }

	// RVA: 0x5201F0 Offset: 0x51F3F0 VA: 0x1805201F0 Slot: 4
	public void Set(ref DeletePersistentAuthOptions other) { }

	// RVA: 0x520150 Offset: 0x51F350 VA: 0x180520150 Slot: 5
	public void Set(ref Nullable<DeletePersistentAuthOptions> other) { }

	// RVA: 0x520100 Offset: 0x51F300 VA: 0x180520100 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Auth
public struct IdToken // TypeDefIndex: 9953
{
	// Fields
	[CompilerGenerated]
	private EpicAccountId <AccountId>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <JsonWebToken>k__BackingField; // 0x8

	// Properties
