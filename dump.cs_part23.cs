	public EpicAccountId AccountId { get; set; }
	public Utf8String JsonWebToken { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public EpicAccountId get_AccountId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_AccountId(EpicAccountId value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public Utf8String get_JsonWebToken() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_JsonWebToken(Utf8String value) { }

	// RVA: 0x5215F0 Offset: 0x5207F0 VA: 0x1805215F0
	internal void Set(ref IdTokenInternal other) { }
}

// Namespace: Epic.OnlineServices.Auth
internal struct IdTokenInternal : IGettable<IdToken>, ISettable<IdToken>, IDisposable // TypeDefIndex: 9954
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_AccountId; // 0x8
	private IntPtr m_JsonWebToken; // 0x10

	// Properties
	public EpicAccountId AccountId { get; set; }
	public Utf8String JsonWebToken { get; set; }

	// Methods

	// RVA: 0x521440 Offset: 0x520640 VA: 0x180521440
	public EpicAccountId get_AccountId() { }

	// RVA: 0x521530 Offset: 0x520730 VA: 0x180521530
	public void set_AccountId(EpicAccountId value) { }

	// RVA: 0x5214C0 Offset: 0x5206C0 VA: 0x1805214C0
	public Utf8String get_JsonWebToken() { }

	// RVA: 0x521590 Offset: 0x520790 VA: 0x180521590
	public void set_JsonWebToken(Utf8String value) { }

	// RVA: 0x521280 Offset: 0x520480 VA: 0x180521280 Slot: 5
	public void Set(ref IdToken other) { }

	// RVA: 0x521340 Offset: 0x520540 VA: 0x180521340 Slot: 6
	public void Set(ref Nullable<IdToken> other) { }

	// RVA: 0x521200 Offset: 0x520400 VA: 0x180521200 Slot: 7
	public void Dispose() { }

	// RVA: 0x521260 Offset: 0x520460 VA: 0x180521260 Slot: 4
	public void Get(out IdToken output) { }
}

// Namespace: Epic.OnlineServices.Auth
public struct LinkAccountCallbackInfo : ICallbackInfo // TypeDefIndex: 9955
{
	// Fields
	[CompilerGenerated]
	private Result <ResultCode>k__BackingField; // 0x0
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x8
	[CompilerGenerated]
	private EpicAccountId <LocalUserId>k__BackingField; // 0x10
	[CompilerGenerated]
	private Nullable<PinGrantInfo> <PinGrantInfo>k__BackingField; // 0x18
	[CompilerGenerated]
	private EpicAccountId <SelectedAccountId>k__BackingField; // 0x40

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public EpicAccountId LocalUserId { get; set; }
	public Nullable<PinGrantInfo> PinGrantInfo { get; set; }
	public EpicAccountId SelectedAccountId { get; set; }

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
	// RVA: 0x41A1E0 Offset: 0x4193E0 VA: 0x18041A1E0
	public Nullable<PinGrantInfo> get_PinGrantInfo() { }

	[CompilerGenerated]
	// RVA: 0x41A210 Offset: 0x419410 VA: 0x18041A210
	public void set_PinGrantInfo(Nullable<PinGrantInfo> value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	public EpicAccountId get_SelectedAccountId() { }

	[CompilerGenerated]
	// RVA: 0x415820 Offset: 0x414A20 VA: 0x180415820
	public void set_SelectedAccountId(EpicAccountId value) { }

	// RVA: 0x521E00 Offset: 0x521000 VA: 0x180521E00 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x521E50 Offset: 0x521050 VA: 0x180521E50
	internal void Set(ref LinkAccountCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.Auth
internal struct LinkAccountCallbackInfoInternal : ICallbackInfoInternal, IGettable<LinkAccountCallbackInfo>, ISettable<LinkAccountCallbackInfo>, IDisposable // TypeDefIndex: 9956
{
	// Fields
	private Result m_ResultCode; // 0x0
	private IntPtr m_ClientData; // 0x8
	private IntPtr m_LocalUserId; // 0x10
	private IntPtr m_PinGrantInfo; // 0x18
	private IntPtr m_SelectedAccountId; // 0x20

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public EpicAccountId LocalUserId { get; set; }
	public Nullable<PinGrantInfo> PinGrantInfo { get; set; }
	public EpicAccountId SelectedAccountId { get; set; }

	// Methods

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	// RVA: 0x521A80 Offset: 0x520C80 VA: 0x180521A80
	public object get_ClientData() { }

	// RVA: 0x521C70 Offset: 0x520E70 VA: 0x180521C70
	public void set_ClientData(object value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x521AF0 Offset: 0x520CF0 VA: 0x180521AF0
	public EpicAccountId get_LocalUserId() { }

	// RVA: 0x521CD0 Offset: 0x520ED0 VA: 0x180521CD0
	public void set_LocalUserId(EpicAccountId value) { }

	// RVA: 0x521B70 Offset: 0x520D70 VA: 0x180521B70
	public Nullable<PinGrantInfo> get_PinGrantInfo() { }

	// RVA: 0x521D30 Offset: 0x520F30 VA: 0x180521D30
	public void set_PinGrantInfo(Nullable<PinGrantInfo> value) { }

	// RVA: 0x521BF0 Offset: 0x520DF0 VA: 0x180521BF0
	public EpicAccountId get_SelectedAccountId() { }

	// RVA: 0x521DA0 Offset: 0x520FA0 VA: 0x180521DA0
	public void set_SelectedAccountId(EpicAccountId value) { }

	// RVA: 0x521910 Offset: 0x520B10 VA: 0x180521910 Slot: 6
	public void Set(ref LinkAccountCallbackInfo other) { }

	// RVA: 0x521710 Offset: 0x520910 VA: 0x180521710 Slot: 7
	public void Set(ref Nullable<LinkAccountCallbackInfo> other) { }

	// RVA: 0x521670 Offset: 0x520870 VA: 0x180521670 Slot: 8
	public void Dispose() { }

	// RVA: 0x5216E0 Offset: 0x5208E0 VA: 0x1805216E0 Slot: 5
	public void Get(out LinkAccountCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.Auth
[Flags]
public enum LinkAccountFlags // TypeDefIndex: 9957
{
	// Fields
	public int value__; // 0x0
	public const LinkAccountFlags NoFlags = 0;
	public const LinkAccountFlags NintendoNsaId = 1;
}

// Namespace: Epic.OnlineServices.Auth
public struct LinkAccountOptions // TypeDefIndex: 9958
{
	// Fields
	[CompilerGenerated]
	private LinkAccountFlags <LinkAccountFlags>k__BackingField; // 0x0
	[CompilerGenerated]
	private ContinuanceToken <ContinuanceToken>k__BackingField; // 0x8
	[CompilerGenerated]
	private EpicAccountId <LocalUserId>k__BackingField; // 0x10

	// Properties
	public LinkAccountFlags LinkAccountFlags { get; set; }
	public ContinuanceToken ContinuanceToken { get; set; }
	public EpicAccountId LocalUserId { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public LinkAccountFlags get_LinkAccountFlags() { }

	[CompilerGenerated]
	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_LinkAccountFlags(LinkAccountFlags value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public ContinuanceToken get_ContinuanceToken() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_ContinuanceToken(ContinuanceToken value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public EpicAccountId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_LocalUserId(EpicAccountId value) { }
}

// Namespace: Epic.OnlineServices.Auth
internal struct LinkAccountOptionsInternal : ISettable<LinkAccountOptions>, IDisposable // TypeDefIndex: 9959
{
	// Fields
	private int m_ApiVersion; // 0x0
	private LinkAccountFlags m_LinkAccountFlags; // 0x4
	private IntPtr m_ContinuanceToken; // 0x8
	private IntPtr m_LocalUserId; // 0x10

	// Properties
	public LinkAccountFlags LinkAccountFlags { set; }
	public ContinuanceToken ContinuanceToken { set; }
	public EpicAccountId LocalUserId { set; }

	// Methods

	// RVA: 0x3F84A0 Offset: 0x3F76A0 VA: 0x1803F84A0
	public void set_LinkAccountFlags(LinkAccountFlags value) { }

	// RVA: 0x5221C0 Offset: 0x5213C0 VA: 0x1805221C0
	public void set_ContinuanceToken(ContinuanceToken value) { }

	// RVA: 0x522220 Offset: 0x521420 VA: 0x180522220
	public void set_LocalUserId(EpicAccountId value) { }

	// RVA: 0x521FE0 Offset: 0x5211E0 VA: 0x180521FE0 Slot: 4
	public void Set(ref LinkAccountOptions other) { }

	// RVA: 0x5220A0 Offset: 0x5212A0 VA: 0x1805220A0 Slot: 5
	public void Set(ref Nullable<LinkAccountOptions> other) { }

	// RVA: 0x521F80 Offset: 0x521180 VA: 0x180521F80 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Auth
public struct LoginCallbackInfo : ICallbackInfo // TypeDefIndex: 9960
{
	// Fields
	[CompilerGenerated]
	private Result <ResultCode>k__BackingField; // 0x0
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x8
	[CompilerGenerated]
	private EpicAccountId <LocalUserId>k__BackingField; // 0x10
	[CompilerGenerated]
	private Nullable<PinGrantInfo> <PinGrantInfo>k__BackingField; // 0x18
	[CompilerGenerated]
	private ContinuanceToken <ContinuanceToken>k__BackingField; // 0x40
	[CompilerGenerated]
	private Nullable<AccountFeatureRestrictedInfo> <AccountFeatureRestrictedInfo_DEPRECATED>k__BackingField; // 0x48
	[CompilerGenerated]
	private EpicAccountId <SelectedAccountId>k__BackingField; // 0x58

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public EpicAccountId LocalUserId { get; set; }
	public Nullable<PinGrantInfo> PinGrantInfo { get; set; }
	public ContinuanceToken ContinuanceToken { get; set; }
	internal Nullable<AccountFeatureRestrictedInfo> AccountFeatureRestrictedInfo_DEPRECATED { get; set; }
	public EpicAccountId SelectedAccountId { get; set; }

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

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x41A1E0 Offset: 0x4193E0 VA: 0x18041A1E0
	public Nullable<PinGrantInfo> get_PinGrantInfo() { }

	[CompilerGenerated]
	// RVA: 0x41A210 Offset: 0x419410 VA: 0x18041A210
	public void set_PinGrantInfo(Nullable<PinGrantInfo> value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	public ContinuanceToken get_ContinuanceToken() { }

	[CompilerGenerated]
	// RVA: 0x415820 Offset: 0x414A20 VA: 0x180415820
	public void set_ContinuanceToken(ContinuanceToken value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x528FE0 Offset: 0x5281E0 VA: 0x180528FE0
	internal Nullable<AccountFeatureRestrictedInfo> get_AccountFeatureRestrictedInfo_DEPRECATED() { }

	[CompilerGenerated]
	// RVA: 0x528FF0 Offset: 0x5281F0 VA: 0x180528FF0
	internal void set_AccountFeatureRestrictedInfo_DEPRECATED(Nullable<AccountFeatureRestrictedInfo> value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x405090 Offset: 0x404290 VA: 0x180405090
	public EpicAccountId get_SelectedAccountId() { }

	[CompilerGenerated]
	// RVA: 0x4050B0 Offset: 0x4042B0 VA: 0x1804050B0
	public void set_SelectedAccountId(EpicAccountId value) { }

	// RVA: 0x528DF0 Offset: 0x527FF0 VA: 0x180528DF0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x528E40 Offset: 0x528040 VA: 0x180528E40
	internal void Set(ref LoginCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.Auth
internal struct LoginCallbackInfoInternal : ICallbackInfoInternal, IGettable<LoginCallbackInfo>, ISettable<LoginCallbackInfo>, IDisposable // TypeDefIndex: 9961
{
	// Fields
	private Result m_ResultCode; // 0x0
	private IntPtr m_ClientData; // 0x8
	private IntPtr m_LocalUserId; // 0x10
	private IntPtr m_PinGrantInfo; // 0x18
	private IntPtr m_ContinuanceToken; // 0x20
	private IntPtr m_AccountFeatureRestrictedInfo_DEPRECATED; // 0x28
	private IntPtr m_SelectedAccountId; // 0x30

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public EpicAccountId LocalUserId { get; set; }
	public Nullable<PinGrantInfo> PinGrantInfo { get; set; }
	public ContinuanceToken ContinuanceToken { get; set; }
	public Nullable<AccountFeatureRestrictedInfo> AccountFeatureRestrictedInfo_DEPRECATED { get; set; }
	public EpicAccountId SelectedAccountId { get; set; }

	// Methods

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	// RVA: 0x528920 Offset: 0x527B20 VA: 0x180528920
	public object get_ClientData() { }

	// RVA: 0x528C00 Offset: 0x527E00 VA: 0x180528C00
	public void set_ClientData(object value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x528A10 Offset: 0x527C10 VA: 0x180528A10
	public EpicAccountId get_LocalUserId() { }

	// RVA: 0x528CC0 Offset: 0x527EC0 VA: 0x180528CC0
	public void set_LocalUserId(EpicAccountId value) { }

	// RVA: 0x528A90 Offset: 0x527C90 VA: 0x180528A90
	public Nullable<PinGrantInfo> get_PinGrantInfo() { }

	// RVA: 0x528D20 Offset: 0x527F20 VA: 0x180528D20
	public void set_PinGrantInfo(Nullable<PinGrantInfo> value) { }

	// RVA: 0x528990 Offset: 0x527B90 VA: 0x180528990
	public ContinuanceToken get_ContinuanceToken() { }

	// RVA: 0x528C60 Offset: 0x527E60 VA: 0x180528C60
	public void set_ContinuanceToken(ContinuanceToken value) { }

	// RVA: 0x5288A0 Offset: 0x527AA0 VA: 0x1805288A0
	public Nullable<AccountFeatureRestrictedInfo> get_AccountFeatureRestrictedInfo_DEPRECATED() { }

	// RVA: 0x528B90 Offset: 0x527D90 VA: 0x180528B90
	public void set_AccountFeatureRestrictedInfo_DEPRECATED(Nullable<AccountFeatureRestrictedInfo> value) { }

	// RVA: 0x528B10 Offset: 0x527D10 VA: 0x180528B10
	public EpicAccountId get_SelectedAccountId() { }

	// RVA: 0x528D90 Offset: 0x527F90 VA: 0x180528D90
	public void set_SelectedAccountId(EpicAccountId value) { }

	// RVA: 0x528690 Offset: 0x527890 VA: 0x180528690 Slot: 6
	public void Set(ref LoginCallbackInfo other) { }

	// RVA: 0x5283C0 Offset: 0x5275C0 VA: 0x1805283C0 Slot: 7
	public void Set(ref Nullable<LoginCallbackInfo> other) { }

	// RVA: 0x528300 Offset: 0x527500 VA: 0x180528300 Slot: 8
	public void Dispose() { }

	// RVA: 0x528390 Offset: 0x527590 VA: 0x180528390 Slot: 5
	public void Get(out LoginCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.Auth
public enum LoginCredentialType // TypeDefIndex: 9962
{
	// Fields
	public int value__; // 0x0
	public const LoginCredentialType Password = 0;
	public const LoginCredentialType ExchangeCode = 1;
	public const LoginCredentialType PersistentAuth = 2;
	public const LoginCredentialType DeviceCode = 3;
	public const LoginCredentialType Developer = 4;
	public const LoginCredentialType RefreshToken = 5;
	public const LoginCredentialType AccountPortal = 6;
	public const LoginCredentialType ExternalAuth = 7;
}

// Namespace: Epic.OnlineServices.Auth
[Flags]
public enum LoginFlags // TypeDefIndex: 9963
{
	// Fields
	public ulong value__; // 0x0
	public const LoginFlags None = 0;
	public const LoginFlags NoUserInterface = 1;
}

// Namespace: Epic.OnlineServices.Auth
public struct LoginOptions // TypeDefIndex: 9964
{
	// Fields
	[CompilerGenerated]
	private Nullable<Credentials> <Credentials>k__BackingField; // 0x0
	[CompilerGenerated]
	private AuthScopeFlags <ScopeFlags>k__BackingField; // 0x30
	[CompilerGenerated]
	private LoginFlags <LoginFlags>k__BackingField; // 0x38

	// Properties
	public Nullable<Credentials> Credentials { get; set; }
	public AuthScopeFlags ScopeFlags { get; set; }
	public LoginFlags LoginFlags { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x502350 Offset: 0x501550 VA: 0x180502350
	public Nullable<Credentials> get_Credentials() { }

	[CompilerGenerated]
	// RVA: 0x502370 Offset: 0x501570 VA: 0x180502370
	public void set_Credentials(Nullable<Credentials> value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x40D300 Offset: 0x40C500 VA: 0x18040D300
	public AuthScopeFlags get_ScopeFlags() { }

	[CompilerGenerated]
	// RVA: 0x40D850 Offset: 0x40CA50 VA: 0x18040D850
	public void set_ScopeFlags(AuthScopeFlags value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public LoginFlags get_LoginFlags() { }

	[CompilerGenerated]
	// RVA: 0x40EC50 Offset: 0x40DE50 VA: 0x18040EC50
	public void set_LoginFlags(LoginFlags value) { }
}

// Namespace: Epic.OnlineServices.Auth
internal struct LoginOptionsInternal : ISettable<LoginOptions>, IDisposable // TypeDefIndex: 9965
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_Credentials; // 0x8
	private AuthScopeFlags m_ScopeFlags; // 0x10
	private LoginFlags m_LoginFlags; // 0x18

	// Properties
	public Nullable<Credentials> Credentials { set; }
	public AuthScopeFlags ScopeFlags { set; }
	public LoginFlags LoginFlags { set; }

	// Methods

	// RVA: 0x529210 Offset: 0x528410 VA: 0x180529210
	public void set_Credentials(Nullable<Credentials> value) { }

	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_ScopeFlags(AuthScopeFlags value) { }

	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_LoginFlags(LoginFlags value) { }

	// RVA: 0x529050 Offset: 0x528250 VA: 0x180529050 Slot: 4
	public void Set(ref LoginOptions other) { }

	// RVA: 0x5290F0 Offset: 0x5282F0 VA: 0x1805290F0 Slot: 5
	public void Set(ref Nullable<LoginOptions> other) { }

	// RVA: 0x529000 Offset: 0x528200 VA: 0x180529000 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Auth
public struct LoginStatusChangedCallbackInfo : ICallbackInfo // TypeDefIndex: 9966
{
	// Fields
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x0
	[CompilerGenerated]
	private EpicAccountId <LocalUserId>k__BackingField; // 0x8
	[CompilerGenerated]
	private LoginStatus <PrevStatus>k__BackingField; // 0x10
	[CompilerGenerated]
	private LoginStatus <CurrentStatus>k__BackingField; // 0x14

	// Properties
	public object ClientData { get; set; }
	public EpicAccountId LocalUserId { get; set; }
	public LoginStatus PrevStatus { get; set; }
	public LoginStatus CurrentStatus { get; set; }

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
	public EpicAccountId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_LocalUserId(EpicAccountId value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public LoginStatus get_PrevStatus() { }

	[CompilerGenerated]
	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_PrevStatus(LoginStatus value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500
	public LoginStatus get_CurrentStatus() { }

	[CompilerGenerated]
	// RVA: 0x426530 Offset: 0x425730 VA: 0x180426530
	public void set_CurrentStatus(LoginStatus value) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x5296B0 Offset: 0x5288B0 VA: 0x1805296B0
	internal void Set(ref LoginStatusChangedCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.Auth
internal struct LoginStatusChangedCallbackInfoInternal : ICallbackInfoInternal, IGettable<LoginStatusChangedCallbackInfo>, ISettable<LoginStatusChangedCallbackInfo>, IDisposable // TypeDefIndex: 9967
{
	// Fields
	private IntPtr m_ClientData; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private LoginStatus m_PrevStatus; // 0x10
	private LoginStatus m_CurrentStatus; // 0x14

	// Properties
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public EpicAccountId LocalUserId { get; set; }
	public LoginStatus PrevStatus { get; set; }
	public LoginStatus CurrentStatus { get; set; }

	// Methods

	// RVA: 0x529500 Offset: 0x528700 VA: 0x180529500
	public object get_ClientData() { }

	// RVA: 0x5295F0 Offset: 0x5287F0 VA: 0x1805295F0
	public void set_ClientData(object value) { }

	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x529570 Offset: 0x528770 VA: 0x180529570
	public EpicAccountId get_LocalUserId() { }

	// RVA: 0x529650 Offset: 0x528850 VA: 0x180529650
	public void set_LocalUserId(EpicAccountId value) { }

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public LoginStatus get_PrevStatus() { }

	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_PrevStatus(LoginStatus value) { }

	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500
	public LoginStatus get_CurrentStatus() { }

	// RVA: 0x426530 Offset: 0x425730 VA: 0x180426530
	public void set_CurrentStatus(LoginStatus value) { }

	// RVA: 0x529440 Offset: 0x528640 VA: 0x180529440 Slot: 6
	public void Set(ref LoginStatusChangedCallbackInfo other) { }

	// RVA: 0x529300 Offset: 0x528500 VA: 0x180529300 Slot: 7
	public void Set(ref Nullable<LoginStatusChangedCallbackInfo> other) { }

	// RVA: 0x529280 Offset: 0x528480 VA: 0x180529280 Slot: 8
	public void Dispose() { }

	// RVA: 0x5292E0 Offset: 0x5284E0 VA: 0x1805292E0 Slot: 5
	public void Get(out LoginStatusChangedCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.Auth
public struct LogoutCallbackInfo : ICallbackInfo // TypeDefIndex: 9968
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

	// RVA: 0x529B50 Offset: 0x528D50 VA: 0x180529B50 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x529BA0 Offset: 0x528DA0 VA: 0x180529BA0
	internal void Set(ref LogoutCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.Auth
internal struct LogoutCallbackInfoInternal : ICallbackInfoInternal, IGettable<LogoutCallbackInfo>, ISettable<LogoutCallbackInfo>, IDisposable // TypeDefIndex: 9969
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

	// RVA: 0x5299A0 Offset: 0x528BA0 VA: 0x1805299A0
	public object get_ClientData() { }

	// RVA: 0x529A90 Offset: 0x528C90 VA: 0x180529A90
	public void set_ClientData(object value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x529A10 Offset: 0x528C10 VA: 0x180529A10
	public EpicAccountId get_LocalUserId() { }

	// RVA: 0x529AF0 Offset: 0x528CF0 VA: 0x180529AF0
	public void set_LocalUserId(EpicAccountId value) { }

	// RVA: 0x5297D0 Offset: 0x5289D0 VA: 0x1805297D0 Slot: 6
	public void Set(ref LogoutCallbackInfo other) { }

	// RVA: 0x529880 Offset: 0x528A80 VA: 0x180529880 Slot: 7
	public void Set(ref Nullable<LogoutCallbackInfo> other) { }

	// RVA: 0x529750 Offset: 0x528950 VA: 0x180529750 Slot: 8
	public void Dispose() { }

	// RVA: 0x5297B0 Offset: 0x5289B0 VA: 0x1805297B0 Slot: 5
	public void Get(out LogoutCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.Auth
public struct LogoutOptions // TypeDefIndex: 9970
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

// Namespace: Epic.OnlineServices.Auth
internal struct LogoutOptionsInternal : ISettable<LogoutOptions>, IDisposable // TypeDefIndex: 9971
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8

	// Properties
	public EpicAccountId LocalUserId { set; }

	// Methods

	// RVA: 0x529D80 Offset: 0x528F80 VA: 0x180529D80
	public void set_LocalUserId(EpicAccountId value) { }

	// RVA: 0x529C80 Offset: 0x528E80 VA: 0x180529C80 Slot: 4
	public void Set(ref LogoutOptions other) { }

	// RVA: 0x529CE0 Offset: 0x528EE0 VA: 0x180529CE0 Slot: 5
	public void Set(ref Nullable<LogoutOptions> other) { }

	// RVA: 0x529C30 Offset: 0x528E30 VA: 0x180529C30 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Auth
public sealed class OnDeletePersistentAuthCallback : MulticastDelegate // TypeDefIndex: 9972
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref DeletePersistentAuthCallbackInfo data) { }

	// RVA: 0x52A910 Offset: 0x529B10 VA: 0x18052A910 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref DeletePersistentAuthCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref DeletePersistentAuthCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Auth
[UnmanagedFunctionPointer(2)]
internal sealed class OnDeletePersistentAuthCallbackInternal : MulticastDelegate // TypeDefIndex: 9973
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref DeletePersistentAuthCallbackInfoInternal data) { }

	// RVA: 0x52A880 Offset: 0x529A80 VA: 0x18052A880 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref DeletePersistentAuthCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref DeletePersistentAuthCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Auth
public sealed class OnLinkAccountCallback : MulticastDelegate // TypeDefIndex: 9974
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref LinkAccountCallbackInfo data) { }

	// RVA: 0x52AA30 Offset: 0x529C30 VA: 0x18052AA30 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref LinkAccountCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref LinkAccountCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Auth
[UnmanagedFunctionPointer(2)]
internal sealed class OnLinkAccountCallbackInternal : MulticastDelegate // TypeDefIndex: 9975
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref LinkAccountCallbackInfoInternal data) { }

	// RVA: 0x52A9A0 Offset: 0x529BA0 VA: 0x18052A9A0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref LinkAccountCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref LinkAccountCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Auth
public sealed class OnLoginCallback : MulticastDelegate // TypeDefIndex: 9976
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref LoginCallbackInfo data) { }

	// RVA: 0x52AB50 Offset: 0x529D50 VA: 0x18052AB50 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref LoginCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref LoginCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Auth
[UnmanagedFunctionPointer(2)]
internal sealed class OnLoginCallbackInternal : MulticastDelegate // TypeDefIndex: 9977
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref LoginCallbackInfoInternal data) { }

	// RVA: 0x52AAC0 Offset: 0x529CC0 VA: 0x18052AAC0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref LoginCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref LoginCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Auth
public sealed class OnLoginStatusChangedCallback : MulticastDelegate // TypeDefIndex: 9978
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref LoginStatusChangedCallbackInfo data) { }

	// RVA: 0x52AC70 Offset: 0x529E70 VA: 0x18052AC70 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref LoginStatusChangedCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref LoginStatusChangedCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Auth
[UnmanagedFunctionPointer(2)]
internal sealed class OnLoginStatusChangedCallbackInternal : MulticastDelegate // TypeDefIndex: 9979
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref LoginStatusChangedCallbackInfoInternal data) { }

	// RVA: 0x52ABE0 Offset: 0x529DE0 VA: 0x18052ABE0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref LoginStatusChangedCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref LoginStatusChangedCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Auth
public sealed class OnLogoutCallback : MulticastDelegate // TypeDefIndex: 9980
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref LogoutCallbackInfo data) { }

	// RVA: 0x52AD90 Offset: 0x529F90 VA: 0x18052AD90 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref LogoutCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref LogoutCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Auth
[UnmanagedFunctionPointer(2)]
internal sealed class OnLogoutCallbackInternal : MulticastDelegate // TypeDefIndex: 9981
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref LogoutCallbackInfoInternal data) { }

	// RVA: 0x52AD00 Offset: 0x529F00 VA: 0x18052AD00 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref LogoutCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref LogoutCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Auth
public sealed class OnQueryIdTokenCallback : MulticastDelegate // TypeDefIndex: 9982
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref QueryIdTokenCallbackInfo data) { }

	// RVA: 0x52B4F0 Offset: 0x52A6F0 VA: 0x18052B4F0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref QueryIdTokenCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref QueryIdTokenCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Auth
[UnmanagedFunctionPointer(2)]
internal sealed class OnQueryIdTokenCallbackInternal : MulticastDelegate // TypeDefIndex: 9983
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref QueryIdTokenCallbackInfoInternal data) { }

	// RVA: 0x52B460 Offset: 0x52A660 VA: 0x18052B460 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref QueryIdTokenCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref QueryIdTokenCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Auth
public sealed class OnVerifyIdTokenCallback : MulticastDelegate // TypeDefIndex: 9984
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref VerifyIdTokenCallbackInfo data) { }

	// RVA: 0x52BA00 Offset: 0x52AC00 VA: 0x18052BA00 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref VerifyIdTokenCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref VerifyIdTokenCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Auth
[UnmanagedFunctionPointer(2)]
internal sealed class OnVerifyIdTokenCallbackInternal : MulticastDelegate // TypeDefIndex: 9985
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref VerifyIdTokenCallbackInfoInternal data) { }

	// RVA: 0x52B850 Offset: 0x52AA50 VA: 0x18052B850 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref VerifyIdTokenCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref VerifyIdTokenCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Auth
public sealed class OnVerifyUserAuthCallback : MulticastDelegate // TypeDefIndex: 9986
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref VerifyUserAuthCallbackInfo data) { }

	// RVA: 0x52BB20 Offset: 0x52AD20 VA: 0x18052BB20 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref VerifyUserAuthCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref VerifyUserAuthCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Auth
[UnmanagedFunctionPointer(2)]
internal sealed class OnVerifyUserAuthCallbackInternal : MulticastDelegate // TypeDefIndex: 9987
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref VerifyUserAuthCallbackInfoInternal data) { }

	// RVA: 0x52BA90 Offset: 0x52AC90 VA: 0x18052BA90 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref VerifyUserAuthCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref VerifyUserAuthCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Auth
public struct PinGrantInfo // TypeDefIndex: 9988
{
	// Fields
	[CompilerGenerated]
	private Utf8String <UserCode>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <VerificationURI>k__BackingField; // 0x8
	[CompilerGenerated]
	private int <ExpiresIn>k__BackingField; // 0x10
	[CompilerGenerated]
	private Utf8String <VerificationURIComplete>k__BackingField; // 0x18

	// Properties
	public Utf8String UserCode { get; set; }
	public Utf8String VerificationURI { get; set; }
	public int ExpiresIn { get; set; }
	public Utf8String VerificationURIComplete { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Utf8String get_UserCode() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_UserCode(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public Utf8String get_VerificationURI() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_VerificationURI(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public int get_ExpiresIn() { }

	[CompilerGenerated]
	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_ExpiresIn(int value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public Utf8String get_VerificationURIComplete() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_VerificationURIComplete(Utf8String value) { }

	// RVA: 0x52C110 Offset: 0x52B310 VA: 0x18052C110
	internal void Set(ref PinGrantInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.Auth
internal struct PinGrantInfoInternal : IGettable<PinGrantInfo>, ISettable<PinGrantInfo>, IDisposable // TypeDefIndex: 9989
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_UserCode; // 0x8
	private IntPtr m_VerificationURI; // 0x10
	private int m_ExpiresIn; // 0x18
	private IntPtr m_VerificationURIComplete; // 0x20

	// Properties
	public Utf8String UserCode { get; set; }
	public Utf8String VerificationURI { get; set; }
	public int ExpiresIn { get; set; }
	public Utf8String VerificationURIComplete { get; set; }

	// Methods

	// RVA: 0x52BEA0 Offset: 0x52B0A0 VA: 0x18052BEA0
	public Utf8String get_UserCode() { }

	// RVA: 0x52BFF0 Offset: 0x52B1F0 VA: 0x18052BFF0
	public void set_UserCode(Utf8String value) { }

	// RVA: 0x52BF80 Offset: 0x52B180 VA: 0x18052BF80
	public Utf8String get_VerificationURI() { }

	// RVA: 0x52C0B0 Offset: 0x52B2B0 VA: 0x18052C0B0
	public void set_VerificationURI(Utf8String value) { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public int get_ExpiresIn() { }

	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	public void set_ExpiresIn(int value) { }

	// RVA: 0x52BF10 Offset: 0x52B110 VA: 0x18052BF10
	public Utf8String get_VerificationURIComplete() { }

	// RVA: 0x52C050 Offset: 0x52B250 VA: 0x18052C050
	public void set_VerificationURIComplete(Utf8String value) { }

	// RVA: 0x52BC30 Offset: 0x52AE30 VA: 0x18052BC30 Slot: 5
	public void Set(ref PinGrantInfo other) { }

	// RVA: 0x52BD30 Offset: 0x52AF30 VA: 0x18052BD30 Slot: 6
	public void Set(ref Nullable<PinGrantInfo> other) { }

	// RVA: 0x52BBB0 Offset: 0x52ADB0 VA: 0x18052BBB0 Slot: 7
	public void Dispose() { }

	// RVA: 0x52BC10 Offset: 0x52AE10 VA: 0x18052BC10 Slot: 4
	public void Get(out PinGrantInfo output) { }
}

// Namespace: Epic.OnlineServices.Auth
public struct QueryIdTokenCallbackInfo : ICallbackInfo // TypeDefIndex: 9990
{
	// Fields
	[CompilerGenerated]
	private Result <ResultCode>k__BackingField; // 0x0
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x8
	[CompilerGenerated]
	private EpicAccountId <LocalUserId>k__BackingField; // 0x10
	[CompilerGenerated]
	private EpicAccountId <TargetAccountId>k__BackingField; // 0x18

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public EpicAccountId LocalUserId { get; set; }
	public EpicAccountId TargetAccountId { get; set; }

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
	public EpicAccountId get_TargetAccountId() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_TargetAccountId(EpicAccountId value) { }

	// RVA: 0x52D2E0 Offset: 0x52C4E0 VA: 0x18052D2E0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x52D330 Offset: 0x52C530 VA: 0x18052D330
	internal void Set(ref QueryIdTokenCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.Auth
internal struct QueryIdTokenCallbackInfoInternal : ICallbackInfoInternal, IGettable<QueryIdTokenCallbackInfo>, ISettable<QueryIdTokenCallbackInfo>, IDisposable // TypeDefIndex: 9991
{
	// Fields
	private Result m_ResultCode; // 0x0
	private IntPtr m_ClientData; // 0x8
	private IntPtr m_LocalUserId; // 0x10
	private IntPtr m_TargetAccountId; // 0x18

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public EpicAccountId LocalUserId { get; set; }
	public EpicAccountId TargetAccountId { get; set; }

	// Methods

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	// RVA: 0x52D050 Offset: 0x52C250 VA: 0x18052D050
	public object get_ClientData() { }

	// RVA: 0x52D1C0 Offset: 0x52C3C0 VA: 0x18052D1C0
	public void set_ClientData(object value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x52D0C0 Offset: 0x52C2C0 VA: 0x18052D0C0
	public EpicAccountId get_LocalUserId() { }

	// RVA: 0x52D220 Offset: 0x52C420 VA: 0x18052D220
	public void set_LocalUserId(EpicAccountId value) { }

	// RVA: 0x52D140 Offset: 0x52C340 VA: 0x18052D140
	public EpicAccountId get_TargetAccountId() { }

	// RVA: 0x52D280 Offset: 0x52C480 VA: 0x18052D280
	public void set_TargetAccountId(EpicAccountId value) { }

	// RVA: 0x52CF50 Offset: 0x52C150 VA: 0x18052CF50 Slot: 6
	public void Set(ref QueryIdTokenCallbackInfo other) { }

	// RVA: 0x52CDE0 Offset: 0x52BFE0 VA: 0x18052CDE0 Slot: 7
	public void Set(ref Nullable<QueryIdTokenCallbackInfo> other) { }

	// RVA: 0x52CD60 Offset: 0x52BF60 VA: 0x18052CD60 Slot: 8
	public void Dispose() { }

	// RVA: 0x52CDC0 Offset: 0x52BFC0 VA: 0x18052CDC0 Slot: 5
	public void Get(out QueryIdTokenCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.Auth
public struct QueryIdTokenOptions // TypeDefIndex: 9992
{
	// Fields
	[CompilerGenerated]
	private EpicAccountId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private EpicAccountId <TargetAccountId>k__BackingField; // 0x8

	// Properties
	public EpicAccountId LocalUserId { get; set; }
	public EpicAccountId TargetAccountId { get; set; }

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
	public EpicAccountId get_TargetAccountId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_TargetAccountId(EpicAccountId value) { }
}

// Namespace: Epic.OnlineServices.Auth
internal struct QueryIdTokenOptionsInternal : ISettable<QueryIdTokenOptions>, IDisposable // TypeDefIndex: 9993
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_TargetAccountId; // 0x10

	// Properties
	public EpicAccountId LocalUserId { set; }
	public EpicAccountId TargetAccountId { set; }

	// Methods

	// RVA: 0x52D5F0 Offset: 0x52C7F0 VA: 0x18052D5F0
	public void set_LocalUserId(EpicAccountId value) { }

	// RVA: 0x52D650 Offset: 0x52C850 VA: 0x18052D650
	public void set_TargetAccountId(EpicAccountId value) { }

	// RVA: 0x52D530 Offset: 0x52C730 VA: 0x18052D530 Slot: 4
	public void Set(ref QueryIdTokenOptions other) { }

	// RVA: 0x52D430 Offset: 0x52C630 VA: 0x18052D430 Slot: 5
	public void Set(ref Nullable<QueryIdTokenOptions> other) { }

	// RVA: 0x52D3D0 Offset: 0x52C5D0 VA: 0x18052D3D0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Auth
public struct Token // TypeDefIndex: 9994
{
	// Fields
	[CompilerGenerated]
	private Utf8String <App>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <ClientId>k__BackingField; // 0x8
	[CompilerGenerated]
	private EpicAccountId <AccountId>k__BackingField; // 0x10
	[CompilerGenerated]
	private Utf8String <AccessToken>k__BackingField; // 0x18
	[CompilerGenerated]
	private double <ExpiresIn>k__BackingField; // 0x20
	[CompilerGenerated]
	private Utf8String <ExpiresAt>k__BackingField; // 0x28
	[CompilerGenerated]
	private AuthTokenType <AuthType>k__BackingField; // 0x30
	[CompilerGenerated]
	private Utf8String <RefreshToken>k__BackingField; // 0x38
	[CompilerGenerated]
	private double <RefreshExpiresIn>k__BackingField; // 0x40
	[CompilerGenerated]
	private Utf8String <RefreshExpiresAt>k__BackingField; // 0x48

	// Properties
	public Utf8String App { get; set; }
	public Utf8String ClientId { get; set; }
	public EpicAccountId AccountId { get; set; }
	public Utf8String AccessToken { get; set; }
	public double ExpiresIn { get; set; }
	public Utf8String ExpiresAt { get; set; }
	public AuthTokenType AuthType { get; set; }
	public Utf8String RefreshToken { get; set; }
	public double RefreshExpiresIn { get; set; }
	public Utf8String RefreshExpiresAt { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Utf8String get_App() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_App(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public Utf8String get_ClientId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_ClientId(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public EpicAccountId get_AccountId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_AccountId(EpicAccountId value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public Utf8String get_AccessToken() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_AccessToken(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x52F520 Offset: 0x52E720 VA: 0x18052F520
	public double get_ExpiresIn() { }

	[CompilerGenerated]
	// RVA: 0x52F540 Offset: 0x52E740 VA: 0x18052F540
	public void set_ExpiresIn(double value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public Utf8String get_ExpiresAt() { }

	[CompilerGenerated]
	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	public void set_ExpiresAt(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x40D300 Offset: 0x40C500 VA: 0x18040D300
	public AuthTokenType get_AuthType() { }

	[CompilerGenerated]
	// RVA: 0x40D850 Offset: 0x40CA50 VA: 0x18040D850
	public void set_AuthType(AuthTokenType value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public Utf8String get_RefreshToken() { }

	[CompilerGenerated]
	// RVA: 0x40EC50 Offset: 0x40DE50 VA: 0x18040EC50
	public void set_RefreshToken(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x52F530 Offset: 0x52E730 VA: 0x18052F530
	public double get_RefreshExpiresIn() { }

	[CompilerGenerated]
	// RVA: 0x52F550 Offset: 0x52E750 VA: 0x18052F550
	public void set_RefreshExpiresIn(double value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0
	public Utf8String get_RefreshExpiresAt() { }

	[CompilerGenerated]
	// RVA: 0x41A200 Offset: 0x419400 VA: 0x18041A200
	public void set_RefreshExpiresAt(Utf8String value) { }

	// RVA: 0x52F2E0 Offset: 0x52E4E0 VA: 0x18052F2E0
	internal void Set(ref TokenInternal other) { }
}

// Namespace: Epic.OnlineServices.Auth
internal struct TokenInternal : IGettable<Token>, ISettable<Token>, IDisposable // TypeDefIndex: 9995
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_App; // 0x8
	private IntPtr m_ClientId; // 0x10
	private IntPtr m_AccountId; // 0x18
	private IntPtr m_AccessToken; // 0x20
	private double m_ExpiresIn; // 0x28
	private IntPtr m_ExpiresAt; // 0x30
	private AuthTokenType m_AuthType; // 0x38
	private IntPtr m_RefreshToken; // 0x40
	private double m_RefreshExpiresIn; // 0x48
	private IntPtr m_RefreshExpiresAt; // 0x50

	// Properties
	public Utf8String App { get; set; }
	public Utf8String ClientId { get; set; }
	public EpicAccountId AccountId { get; set; }
	public Utf8String AccessToken { get; set; }
	public double ExpiresIn { get; set; }
	public Utf8String ExpiresAt { get; set; }
	public AuthTokenType AuthType { get; set; }
	public Utf8String RefreshToken { get; set; }
	public double RefreshExpiresIn { get; set; }
	public Utf8String RefreshExpiresAt { get; set; }

	// Methods

	// RVA: 0x52EDD0 Offset: 0x52DFD0 VA: 0x18052EDD0
	public Utf8String get_App() { }

	// RVA: 0x52F0E0 Offset: 0x52E2E0 VA: 0x18052F0E0
	public void set_App(Utf8String value) { }

	// RVA: 0x52EE40 Offset: 0x52E040 VA: 0x18052EE40
	public Utf8String get_ClientId() { }

	// RVA: 0x52F140 Offset: 0x52E340 VA: 0x18052F140
	public void set_ClientId(Utf8String value) { }

	// RVA: 0x52ED50 Offset: 0x52DF50 VA: 0x18052ED50
	public EpicAccountId get_AccountId() { }

	// RVA: 0x52F080 Offset: 0x52E280 VA: 0x18052F080
	public void set_AccountId(EpicAccountId value) { }

	// RVA: 0x52ECE0 Offset: 0x52DEE0 VA: 0x18052ECE0
	public Utf8String get_AccessToken() { }

	// RVA: 0x52F020 Offset: 0x52E220 VA: 0x18052F020
	public void set_AccessToken(Utf8String value) { }

	// RVA: 0x52EF20 Offset: 0x52E120 VA: 0x18052EF20
	public double get_ExpiresIn() { }

	// RVA: 0x52F200 Offset: 0x52E400 VA: 0x18052F200
	public void set_ExpiresIn(double value) { }

	// RVA: 0x52EEB0 Offset: 0x52E0B0 VA: 0x18052EEB0
	public Utf8String get_ExpiresAt() { }

	// RVA: 0x52F1A0 Offset: 0x52E3A0 VA: 0x18052F1A0
	public void set_ExpiresAt(Utf8String value) { }

	// RVA: 0x4232F0 Offset: 0x4224F0 VA: 0x1804232F0
	public AuthTokenType get_AuthType() { }

	// RVA: 0x423300 Offset: 0x422500 VA: 0x180423300
	public void set_AuthType(AuthTokenType value) { }

	// RVA: 0x52EFB0 Offset: 0x52E1B0 VA: 0x18052EFB0
	public Utf8String get_RefreshToken() { }

	// RVA: 0x52F280 Offset: 0x52E480 VA: 0x18052F280
	public void set_RefreshToken(Utf8String value) { }

	// RVA: 0x52EFA0 Offset: 0x52E1A0 VA: 0x18052EFA0
	public double get_RefreshExpiresIn() { }

	// RVA: 0x52F270 Offset: 0x52E470 VA: 0x18052F270
	public void set_RefreshExpiresIn(double value) { }

	// RVA: 0x52EF30 Offset: 0x52E130 VA: 0x18052EF30
	public Utf8String get_RefreshExpiresAt() { }

	// RVA: 0x52F210 Offset: 0x52E410 VA: 0x18052F210
	public void set_RefreshExpiresAt(Utf8String value) { }

	// RVA: 0x52EAC0 Offset: 0x52DCC0 VA: 0x18052EAC0 Slot: 5
	public void Set(ref Token other) { }

	// RVA: 0x52E7B0 Offset: 0x52D9B0 VA: 0x18052E7B0 Slot: 6
	public void Set(ref Nullable<Token> other) { }

	// RVA: 0x52E6F0 Offset: 0x52D8F0 VA: 0x18052E6F0 Slot: 7
	public void Dispose() { }

	// RVA: 0x52E780 Offset: 0x52D980 VA: 0x18052E780 Slot: 4
	public void Get(out Token output) { }
}

// Namespace: Epic.OnlineServices.Auth
public struct VerifyIdTokenCallbackInfo : ICallbackInfo // TypeDefIndex: 9996
{
	// Fields
	[CompilerGenerated]
	private Result <ResultCode>k__BackingField; // 0x0
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x8
	[CompilerGenerated]
	private Utf8String <ApplicationId>k__BackingField; // 0x10
	[CompilerGenerated]
	private Utf8String <ClientId>k__BackingField; // 0x18
	[CompilerGenerated]
	private Utf8String <ProductId>k__BackingField; // 0x20
	[CompilerGenerated]
	private Utf8String <SandboxId>k__BackingField; // 0x28
	[CompilerGenerated]
	private Utf8String <DeploymentId>k__BackingField; // 0x30
	[CompilerGenerated]
	private Utf8String <DisplayName>k__BackingField; // 0x38
	[CompilerGenerated]
	private bool <IsExternalAccountInfoPresent>k__BackingField; // 0x40
	[CompilerGenerated]
	private ExternalAccountType <ExternalAccountIdType>k__BackingField; // 0x44
	[CompilerGenerated]
	private Utf8String <ExternalAccountId>k__BackingField; // 0x48
	[CompilerGenerated]
	private Utf8String <ExternalAccountDisplayName>k__BackingField; // 0x50
	[CompilerGenerated]
	private Utf8String <Platform>k__BackingField; // 0x58

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public Utf8String ApplicationId { get; set; }
	public Utf8String ClientId { get; set; }
	public Utf8String ProductId { get; set; }
	public Utf8String SandboxId { get; set; }
	public Utf8String DeploymentId { get; set; }
	public Utf8String DisplayName { get; set; }
	public bool IsExternalAccountInfoPresent { get; set; }
	public ExternalAccountType ExternalAccountIdType { get; set; }
	public Utf8String ExternalAccountId { get; set; }
	public Utf8String ExternalAccountDisplayName { get; set; }
	public Utf8String Platform { get; set; }

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
	public Utf8String get_ApplicationId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_ApplicationId(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public Utf8String get_ClientId() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_ClientId(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public Utf8String get_ProductId() { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_ProductId(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public Utf8String get_SandboxId() { }

	[CompilerGenerated]
	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	public void set_SandboxId(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public Utf8String get_DeploymentId() { }

	[CompilerGenerated]
	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	public void set_DeploymentId(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public Utf8String get_DisplayName() { }

	[CompilerGenerated]
	// RVA: 0x40EC50 Offset: 0x40DE50 VA: 0x18040EC50
	public void set_DisplayName(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x4456F0 Offset: 0x4448F0 VA: 0x1804456F0
	public bool get_IsExternalAccountInfoPresent() { }

	[CompilerGenerated]
	// RVA: 0x445700 Offset: 0x444900 VA: 0x180445700
	public void set_IsExternalAccountInfoPresent(bool value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x4AB2B0 Offset: 0x4AA4B0 VA: 0x1804AB2B0
	public ExternalAccountType get_ExternalAccountIdType() { }

	[CompilerGenerated]
	// RVA: 0x4AB2C0 Offset: 0x4AA4C0 VA: 0x1804AB2C0
	public void set_ExternalAccountIdType(ExternalAccountType value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0
	public Utf8String get_ExternalAccountId() { }

	[CompilerGenerated]
	// RVA: 0x41A200 Offset: 0x419400 VA: 0x18041A200
	public void set_ExternalAccountId(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0
	public Utf8String get_ExternalAccountDisplayName() { }

	[CompilerGenerated]
	// RVA: 0x4050C0 Offset: 0x4042C0 VA: 0x1804050C0
	public void set_ExternalAccountDisplayName(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x405090 Offset: 0x404290 VA: 0x180405090
	public Utf8String get_Platform() { }

	[CompilerGenerated]
	// RVA: 0x4050B0 Offset: 0x4042B0 VA: 0x1804050B0
	public void set_Platform(Utf8String value) { }

	// RVA: 0x532D50 Offset: 0x531F50 VA: 0x180532D50 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x532DF0 Offset: 0x531FF0 VA: 0x180532DF0
	internal void Set(ref VerifyIdTokenCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.Auth
internal struct VerifyIdTokenCallbackInfoInternal : ICallbackInfoInternal, IGettable<VerifyIdTokenCallbackInfo>, ISettable<VerifyIdTokenCallbackInfo>, IDisposable // TypeDefIndex: 9997
{
	// Fields
	private Result m_ResultCode; // 0x0
	private IntPtr m_ClientData; // 0x8
	private IntPtr m_ApplicationId; // 0x10
	private IntPtr m_ClientId; // 0x18
	private IntPtr m_ProductId; // 0x20
	private IntPtr m_SandboxId; // 0x28
	private IntPtr m_DeploymentId; // 0x30
	private IntPtr m_DisplayName; // 0x38
	private int m_IsExternalAccountInfoPresent; // 0x40
	private ExternalAccountType m_ExternalAccountIdType; // 0x44
	private IntPtr m_ExternalAccountId; // 0x48
	private IntPtr m_ExternalAccountDisplayName; // 0x50
	private IntPtr m_Platform; // 0x58

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public Utf8String ApplicationId { get; set; }
	public Utf8String ClientId { get; set; }
	public Utf8String ProductId { get; set; }
	public Utf8String SandboxId { get; set; }
	public Utf8String DeploymentId { get; set; }
	public Utf8String DisplayName { get; set; }
	public bool IsExternalAccountInfoPresent { get; set; }
	public ExternalAccountType ExternalAccountIdType { get; set; }
	public Utf8String ExternalAccountId { get; set; }
	public Utf8String ExternalAccountDisplayName { get; set; }
	public Utf8String Platform { get; set; }

	// Methods

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	// RVA: 0x531DA0 Offset: 0x530FA0 VA: 0x180531DA0
	public object get_ClientData() { }

	// RVA: 0x532690 Offset: 0x531890 VA: 0x180532690
	public void set_ClientData(object value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x531CC0 Offset: 0x530EC0 VA: 0x180531CC0
	public Utf8String get_ApplicationId() { }

	// RVA: 0x5325D0 Offset: 0x5317D0 VA: 0x1805325D0
	public void set_ApplicationId(Utf8String value) { }

	// RVA: 0x531E80 Offset: 0x531080 VA: 0x180531E80
	public Utf8String get_ClientId() { }

	// RVA: 0x532750 Offset: 0x531950 VA: 0x180532750
	public void set_ClientId(Utf8String value) { }

	// RVA: 0x5323A0 Offset: 0x5315A0 VA: 0x1805323A0
	public Utf8String get_ProductId() { }

	// RVA: 0x532B70 Offset: 0x531D70 VA: 0x180532B70
	public void set_ProductId(Utf8String value) { }

	// RVA: 0x532500 Offset: 0x531700 VA: 0x180532500
	public Utf8String get_SandboxId() { }

	// RVA: 0x532C90 Offset: 0x531E90 VA: 0x180532C90
	public void set_SandboxId(Utf8String value) { }

	// RVA: 0x531F60 Offset: 0x531160 VA: 0x180531F60
	public Utf8String get_DeploymentId() { }

	// RVA: 0x5327B0 Offset: 0x5319B0 VA: 0x1805327B0
	public void set_DeploymentId(Utf8String value) { }

	// RVA: 0x532040 Offset: 0x531240 VA: 0x180532040
	public Utf8String get_DisplayName() { }

	// RVA: 0x5328D0 Offset: 0x531AD0 VA: 0x1805328D0
	public void set_DisplayName(Utf8String value) { }

	// RVA: 0x5321F0 Offset: 0x5313F0 VA: 0x1805321F0
	public bool get_IsExternalAccountInfoPresent() { }

	// RVA: 0x532A50 Offset: 0x531C50 VA: 0x180532A50
	public void set_IsExternalAccountInfoPresent(bool value) { }

	// RVA: 0x4AB2B0 Offset: 0x4AA4B0 VA: 0x1804AB2B0
	public ExternalAccountType get_ExternalAccountIdType() { }

	// RVA: 0x4AB2C0 Offset: 0x4AA4C0 VA: 0x1804AB2C0
	public void set_ExternalAccountIdType(ExternalAccountType value) { }

	// RVA: 0x532120 Offset: 0x531320 VA: 0x180532120
	public Utf8String get_ExternalAccountId() { }

	// RVA: 0x532990 Offset: 0x531B90 VA: 0x180532990
	public void set_ExternalAccountId(Utf8String value) { }

	// RVA: 0x5320B0 Offset: 0x5312B0 VA: 0x1805320B0
	public Utf8String get_ExternalAccountDisplayName() { }

	// RVA: 0x532930 Offset: 0x531B30 VA: 0x180532930
	public void set_ExternalAccountDisplayName(Utf8String value) { }

	// RVA: 0x532250 Offset: 0x531450 VA: 0x180532250
	public Utf8String get_Platform() { }

	// RVA: 0x532B10 Offset: 0x531D10 VA: 0x180532B10
	public void set_Platform(Utf8String value) { }

	// RVA: 0x531930 Offset: 0x530B30 VA: 0x180531930 Slot: 6
	public void Set(ref VerifyIdTokenCallbackInfo other) { }

	// RVA: 0x531500 Offset: 0x530700 VA: 0x180531500 Slot: 7
	public void Set(ref Nullable<VerifyIdTokenCallbackInfo> other) { }

	// RVA: 0x530C80 Offset: 0x52FE80 VA: 0x180530C80 Slot: 8
	public void Dispose() { }

	// RVA: 0x530DE0 Offset: 0x52FFE0 VA: 0x180530DE0 Slot: 5
	public void Get(out VerifyIdTokenCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.Auth
public struct VerifyIdTokenOptions // TypeDefIndex: 9998
{
	// Fields
	[CompilerGenerated]
	private Nullable<IdToken> <IdToken>k__BackingField; // 0x0

	// Properties
	public Nullable<IdToken> IdToken { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x4BBD30 Offset: 0x4BAF30 VA: 0x1804BBD30
	public Nullable<IdToken> get_IdToken() { }

	[CompilerGenerated]
	// RVA: 0x4BBD50 Offset: 0x4BAF50 VA: 0x1804BBD50
	public void set_IdToken(Nullable<IdToken> value) { }
}

// Namespace: Epic.OnlineServices.Auth
internal struct VerifyIdTokenOptionsInternal : ISettable<VerifyIdTokenOptions>, IDisposable // TypeDefIndex: 9999
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_IdToken; // 0x8

	// Properties
	public Nullable<IdToken> IdToken { set; }

	// Methods

	// RVA: 0x533800 Offset: 0x532A00 VA: 0x180533800
	public void set_IdToken(Nullable<IdToken> value) { }

	// RVA: 0x5336B0 Offset: 0x5328B0 VA: 0x1805336B0 Slot: 4
	public void Set(ref VerifyIdTokenOptions other) { }

	// RVA: 0x5335E0 Offset: 0x5327E0 VA: 0x1805335E0 Slot: 5
	public void Set(ref Nullable<VerifyIdTokenOptions> other) { }

	// RVA: 0x5334C0 Offset: 0x5326C0 VA: 0x1805334C0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Auth
public struct VerifyUserAuthCallbackInfo : ICallbackInfo // TypeDefIndex: 10000
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

	// RVA: 0x533B40 Offset: 0x532D40 VA: 0x180533B40 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x533B90 Offset: 0x532D90 VA: 0x180533B90
	internal void Set(ref VerifyUserAuthCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.Auth
internal struct VerifyUserAuthCallbackInfoInternal : ICallbackInfoInternal, IGettable<VerifyUserAuthCallbackInfo>, ISettable<VerifyUserAuthCallbackInfo>, IDisposable // TypeDefIndex: 10001
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

	// RVA: 0x533A70 Offset: 0x532C70 VA: 0x180533A70
	public object get_ClientData() { }

	// RVA: 0x533AE0 Offset: 0x532CE0 VA: 0x180533AE0
	public void set_ClientData(object value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x533950 Offset: 0x532B50 VA: 0x180533950 Slot: 6
	public void Set(ref VerifyUserAuthCallbackInfo other) { }

	// RVA: 0x5339B0 Offset: 0x532BB0 VA: 0x1805339B0 Slot: 7
	public void Set(ref Nullable<VerifyUserAuthCallbackInfo> other) { }

	// RVA: 0x5338E0 Offset: 0x532AE0 VA: 0x1805338E0 Slot: 8
	public void Dispose() { }

	// RVA: 0x533930 Offset: 0x532B30 VA: 0x180533930 Slot: 5
	public void Get(out VerifyUserAuthCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.Auth
public struct VerifyUserAuthOptions // TypeDefIndex: 10002
{
	// Fields
	[CompilerGenerated]
	private Nullable<Token> <AuthToken>k__BackingField; // 0x0

	// Properties
	public Nullable<Token> AuthToken { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x533EA0 Offset: 0x5330A0 VA: 0x180533EA0
	public Nullable<Token> get_AuthToken() { }

	[CompilerGenerated]
	// RVA: 0x533EE0 Offset: 0x5330E0 VA: 0x180533EE0
	public void set_AuthToken(Nullable<Token> value) { }
}

// Namespace: Epic.OnlineServices.Auth
internal struct VerifyUserAuthOptionsInternal : ISettable<VerifyUserAuthOptions>, IDisposable // TypeDefIndex: 10003
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_AuthToken; // 0x8

	// Properties
	public Nullable<Token> AuthToken { set; }

	// Methods

	// RVA: 0x533E30 Offset: 0x533030 VA: 0x180533E30
	public void set_AuthToken(Nullable<Token> value) { }

	// RVA: 0x533C60 Offset: 0x532E60 VA: 0x180533C60 Slot: 4
	public void Set(ref VerifyUserAuthOptions other) { }

	// RVA: 0x533D10 Offset: 0x532F10 VA: 0x180533D10 Slot: 5
	public void Set(ref Nullable<VerifyUserAuthOptions> other) { }

	// RVA: 0x533C10 Offset: 0x532E10 VA: 0x180533C10 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Auth
public sealed class IOSCreateBackgroundSnapshotView : MulticastDelegate // TypeDefIndex: 10004
{
	// Methods

	// RVA: 0x449560 Offset: 0x448760 VA: 0x180449560
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual IntPtr Invoke(IntPtr context) { }

	// RVA: 0x5203E0 Offset: 0x51F5E0 VA: 0x1805203E0 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr context, AsyncCallback callback, object object) { }

	// RVA: 0x425AE0 Offset: 0x424CE0 VA: 0x180425AE0 Slot: 15
	public virtual IntPtr EndInvoke(IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Auth
[UnmanagedFunctionPointer(2)]
internal sealed class IOSCreateBackgroundSnapshotViewInternal : MulticastDelegate // TypeDefIndex: 10005
{
	// Methods

	// RVA: 0x449560 Offset: 0x448760 VA: 0x180449560
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual IntPtr Invoke(IntPtr context) { }

	// RVA: 0x520360 Offset: 0x51F560 VA: 0x180520360 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr context, AsyncCallback callback, object object) { }

	// RVA: 0x425AE0 Offset: 0x424CE0 VA: 0x180425AE0 Slot: 15
	public virtual IntPtr EndInvoke(IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Auth
public struct IOSCredentials // TypeDefIndex: 10006
{
	// Fields
	[CompilerGenerated]
	private Utf8String <Id>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <Token>k__BackingField; // 0x8
	[CompilerGenerated]
	private LoginCredentialType <Type>k__BackingField; // 0x10
	[CompilerGenerated]
	private Nullable<IOSCredentialsSystemAuthCredentialsOptions> <SystemAuthCredentialsOptions>k__BackingField; // 0x18
	[CompilerGenerated]
	private ExternalCredentialType <ExternalType>k__BackingField; // 0x38

	// Properties
	public Utf8String Id { get; set; }
	public Utf8String Token { get; set; }
	public LoginCredentialType Type { get; set; }
	public Nullable<IOSCredentialsSystemAuthCredentialsOptions> SystemAuthCredentialsOptions { get; set; }
	public ExternalCredentialType ExternalType { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Utf8String get_Id() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_Id(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
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

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x520F10 Offset: 0x520110 VA: 0x180520F10
	public Nullable<IOSCredentialsSystemAuthCredentialsOptions> get_SystemAuthCredentialsOptions() { }

	[CompilerGenerated]
	// RVA: 0x520F30 Offset: 0x520130 VA: 0x180520F30
	public void set_SystemAuthCredentialsOptions(Nullable<IOSCredentialsSystemAuthCredentialsOptions> value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x4232F0 Offset: 0x4224F0 VA: 0x1804232F0
	public ExternalCredentialType get_ExternalType() { }

	[CompilerGenerated]
	// RVA: 0x423300 Offset: 0x422500 VA: 0x180423300
	public void set_ExternalType(ExternalCredentialType value) { }

	// RVA: 0x520DB0 Offset: 0x51FFB0 VA: 0x180520DB0
	internal void Set(ref IOSCredentialsInternal other) { }
}

// Namespace: Epic.OnlineServices.Auth
internal struct IOSCredentialsInternal : IGettable<IOSCredentials>, ISettable<IOSCredentials>, IDisposable // TypeDefIndex: 10007
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
	public Nullable<IOSCredentialsSystemAuthCredentialsOptions> SystemAuthCredentialsOptions { get; set; }
	public ExternalCredentialType ExternalType { get; set; }

	// Methods

	// RVA: 0x5207E0 Offset: 0x51F9E0 VA: 0x1805207E0
	public Utf8String get_Id() { }

	// RVA: 0x520940 Offset: 0x51FB40 VA: 0x180520940
	public void set_Id(Utf8String value) { }

	// RVA: 0x5208D0 Offset: 0x51FAD0 VA: 0x1805208D0
	public Utf8String get_Token() { }

	// RVA: 0x520A10 Offset: 0x51FC10 VA: 0x180520A10
	public void set_Token(Utf8String value) { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public LoginCredentialType get_Type() { }

	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	public void set_Type(LoginCredentialType value) { }

	// RVA: 0x520850 Offset: 0x51FA50 VA: 0x180520850
	public Nullable<IOSCredentialsSystemAuthCredentialsOptions> get_SystemAuthCredentialsOptions() { }

	// RVA: 0x5209A0 Offset: 0x51FBA0 VA: 0x1805209A0
	public void set_SystemAuthCredentialsOptions(Nullable<IOSCredentialsSystemAuthCredentialsOptions> value) { }

	// RVA: 0x3DA050 Offset: 0x3D9250 VA: 0x1803DA050
	public ExternalCredentialType get_ExternalType() { }

	// RVA: 0x3DA200 Offset: 0x3D9400 VA: 0x1803DA200
	public void set_ExternalType(ExternalCredentialType value) { }

	// RVA: 0x5206B0 Offset: 0x51F8B0 VA: 0x1805206B0 Slot: 5
	public void Set(ref IOSCredentials other) { }

	// RVA: 0x5204F0 Offset: 0x51F6F0 VA: 0x1805204F0 Slot: 6
	public void Set(ref Nullable<IOSCredentials> other) { }

	// RVA: 0x520460 Offset: 0x51F660 VA: 0x180520460 Slot: 7
	public void Dispose() { }

	// RVA: 0x5204C0 Offset: 0x51F6C0 VA: 0x1805204C0 Slot: 4
	public void Get(out IOSCredentials output) { }
}

// Namespace: Epic.OnlineServices.Auth
public struct IOSCredentialsSystemAuthCredentialsOptions // TypeDefIndex: 10008
{
	// Fields
	[CompilerGenerated]
	private IntPtr <PresentationContextProviding>k__BackingField; // 0x0
	[CompilerGenerated]
	private IOSCreateBackgroundSnapshotView <CreateBackgroundSnapshotView>k__BackingField; // 0x8
	[CompilerGenerated]
	private IntPtr <CreateBackgroundSnapshotViewContext>k__BackingField; // 0x10

	// Properties
	public IntPtr PresentationContextProviding { get; set; }
	public IOSCreateBackgroundSnapshotView CreateBackgroundSnapshotView { get; set; }
	public IntPtr CreateBackgroundSnapshotViewContext { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public IntPtr get_PresentationContextProviding() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_PresentationContextProviding(IntPtr value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public IOSCreateBackgroundSnapshotView get_CreateBackgroundSnapshotView() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_CreateBackgroundSnapshotView(IOSCreateBackgroundSnapshotView value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public IntPtr get_CreateBackgroundSnapshotViewContext() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_CreateBackgroundSnapshotViewContext(IntPtr value) { }

	// RVA: 0x520DA0 Offset: 0x51FFA0 VA: 0x180520DA0
	internal void Set(ref IOSCredentialsSystemAuthCredentialsOptionsInternal other) { }
}

// Namespace: Epic.OnlineServices.Auth
internal struct IOSCredentialsSystemAuthCredentialsOptionsInternal : IGettable<IOSCredentialsSystemAuthCredentialsOptions>, ISettable<IOSCredentialsSystemAuthCredentialsOptions>, IDisposable // TypeDefIndex: 10009
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_PresentationContextProviding; // 0x8
	private IntPtr m_CreateBackgroundSnapshotView; // 0x10
	private IntPtr m_CreateBackgroundSnapshotViewContext; // 0x18
	private static IOSCreateBackgroundSnapshotViewInternal s_CreateBackgroundSnapshotView; // 0x0

	// Properties
	public IntPtr PresentationContextProviding { get; set; }
	public static IOSCreateBackgroundSnapshotViewInternal CreateBackgroundSnapshotView { get; }
	public IntPtr CreateBackgroundSnapshotViewContext { get; set; }

	// Methods

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public IntPtr get_PresentationContextProviding() { }

	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_PresentationContextProviding(IntPtr value) { }

	// RVA: 0x520C90 Offset: 0x51FE90 VA: 0x180520C90
	public static IOSCreateBackgroundSnapshotViewInternal get_CreateBackgroundSnapshotView() { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public IntPtr get_CreateBackgroundSnapshotViewContext() { }

	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_CreateBackgroundSnapshotViewContext(IntPtr value) { }

	// RVA: 0x520AF0 Offset: 0x51FCF0 VA: 0x180520AF0 Slot: 5
	public void Set(ref IOSCredentialsSystemAuthCredentialsOptions other) { }

	// RVA: 0x520B90 Offset: 0x51FD90 VA: 0x180520B90 Slot: 6
	public void Set(ref Nullable<IOSCredentialsSystemAuthCredentialsOptions> other) { }

	// RVA: 0x520A70 Offset: 0x51FC70 VA: 0x180520A70 Slot: 7
	public void Dispose() { }

	// RVA: 0x520AD0 Offset: 0x51FCD0 VA: 0x180520AD0 Slot: 4
	public void Get(out IOSCredentialsSystemAuthCredentialsOptions output) { }
}

// Namespace: Epic.OnlineServices.Auth
public struct IOSLoginOptions // TypeDefIndex: 10010
{
	// Fields
	[CompilerGenerated]
	private Nullable<IOSCredentials> <Credentials>k__BackingField; // 0x0
	[CompilerGenerated]
	private AuthScopeFlags <ScopeFlags>k__BackingField; // 0x48
	[CompilerGenerated]
	private LoginFlags <LoginFlags>k__BackingField; // 0x50

	// Properties
	public Nullable<IOSCredentials> Credentials { get; set; }
	public AuthScopeFlags ScopeFlags { get; set; }
	public LoginFlags LoginFlags { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x4193E0 Offset: 0x4185E0 VA: 0x1804193E0
	public Nullable<IOSCredentials> get_Credentials() { }

	[CompilerGenerated]
	// RVA: 0x419420 Offset: 0x418620 VA: 0x180419420
	public void set_Credentials(Nullable<IOSCredentials> value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x4193D0 Offset: 0x4185D0 VA: 0x1804193D0
	public AuthScopeFlags get_ScopeFlags() { }

	[CompilerGenerated]
	// RVA: 0x419410 Offset: 0x418610 VA: 0x180419410
	public void set_ScopeFlags(AuthScopeFlags value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0
	public LoginFlags get_LoginFlags() { }

	[CompilerGenerated]
	// RVA: 0x4050C0 Offset: 0x4042C0 VA: 0x1804050C0
	public void set_LoginFlags(LoginFlags value) { }
}

// Namespace: Epic.OnlineServices.Auth
internal struct IOSLoginOptionsInternal : ISettable<IOSLoginOptions>, IDisposable // TypeDefIndex: 10011
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_Credentials; // 0x8
	private AuthScopeFlags m_ScopeFlags; // 0x10
	private LoginFlags m_LoginFlags; // 0x18

	// Properties
	public Nullable<IOSCredentials> Credentials { set; }
	public AuthScopeFlags ScopeFlags { set; }
	public LoginFlags LoginFlags { set; }

	// Methods

	// RVA: 0x521190 Offset: 0x520390 VA: 0x180521190
	public void set_Credentials(Nullable<IOSCredentials> value) { }

	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_ScopeFlags(AuthScopeFlags value) { }

	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_LoginFlags(LoginFlags value) { }

	// RVA: 0x520F90 Offset: 0x520190 VA: 0x180520F90 Slot: 4
	public void Set(ref IOSLoginOptions other) { }

	// RVA: 0x521050 Offset: 0x520250 VA: 0x180521050 Slot: 5
	public void Set(ref Nullable<IOSLoginOptions> other) { }

	// RVA: 0x520F40 Offset: 0x520140 VA: 0x180520F40 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.AntiCheatServer
public struct AddNotifyClientActionRequiredOptions // TypeDefIndex: 10012
{}

// Namespace: Epic.OnlineServices.AntiCheatServer
internal struct AddNotifyClientActionRequiredOptionsInternal : ISettable<AddNotifyClientActionRequiredOptions>, IDisposable // TypeDefIndex: 10013
{
	// Fields
	private int m_ApiVersion; // 0x0

	// Methods

	// RVA: 0x3F98A0 Offset: 0x3F8AA0 VA: 0x1803F98A0 Slot: 4
	public void Set(ref AddNotifyClientActionRequiredOptions other) { }

	// RVA: 0x51BA90 Offset: 0x51AC90 VA: 0x18051BA90 Slot: 5
	public void Set(ref Nullable<AddNotifyClientActionRequiredOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.AntiCheatServer
public struct AddNotifyClientAuthStatusChangedOptions // TypeDefIndex: 10014
{}

// Namespace: Epic.OnlineServices.AntiCheatServer
internal struct AddNotifyClientAuthStatusChangedOptionsInternal : ISettable<AddNotifyClientAuthStatusChangedOptions>, IDisposable // TypeDefIndex: 10015
{
	// Fields
	private int m_ApiVersion; // 0x0

	// Methods

	// RVA: 0x3F98A0 Offset: 0x3F8AA0 VA: 0x1803F98A0 Slot: 4
	public void Set(ref AddNotifyClientAuthStatusChangedOptions other) { }

	// RVA: 0x51BAE0 Offset: 0x51ACE0 VA: 0x18051BAE0 Slot: 5
	public void Set(ref Nullable<AddNotifyClientAuthStatusChangedOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.AntiCheatServer
public struct AddNotifyMessageToClientOptions // TypeDefIndex: 10016
{}

// Namespace: Epic.OnlineServices.AntiCheatServer
internal struct AddNotifyMessageToClientOptionsInternal : ISettable<AddNotifyMessageToClientOptions>, IDisposable // TypeDefIndex: 10017
{
	// Fields
	private int m_ApiVersion; // 0x0

	// Methods

	// RVA: 0x3F98A0 Offset: 0x3F8AA0 VA: 0x1803F98A0 Slot: 4
	public void Set(ref AddNotifyMessageToClientOptions other) { }

	// RVA: 0x51BB80 Offset: 0x51AD80 VA: 0x18051BB80 Slot: 5
	public void Set(ref Nullable<AddNotifyMessageToClientOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.AntiCheatServer
public sealed class AntiCheatServerInterface : Handle // TypeDefIndex: 10018
{
	// Fields
	public const int AddnotifyclientactionrequiredApiLatest = 1;
	public const int AddnotifyclientauthstatuschangedApiLatest = 1;
	public const int AddnotifymessagetoclientApiLatest = 1;
	public const int BeginsessionApiLatest = 3;
	public const int BeginsessionMaxRegistertimeout = 120;
	public const int BeginsessionMinRegistertimeout = 10;
	public const int EndsessionApiLatest = 1;
	public const int GetprotectmessageoutputlengthApiLatest = 1;
	public const int OnmessagetoclientcallbackMaxMessageSize = 512;
	public const int ProtectmessageApiLatest = 1;
	public const int ReceivemessagefromclientApiLatest = 1;
	public const int RegisterclientApiLatest = 2;
	public const int SetclientnetworkstateApiLatest = 1;
	public const int UnprotectmessageApiLatest = 1;
	public const int UnregisterclientApiLatest = 1;

	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }

	// RVA: 0x40BDB0 Offset: 0x40AFB0 VA: 0x18040BDB0
	public void .ctor(IntPtr innerHandle) { }

	// RVA: 0x51BBD0 Offset: 0x51ADD0 VA: 0x18051BBD0
	public ulong AddNotifyClientActionRequired(ref AddNotifyClientActionRequiredOptions options, object clientData, OnClientActionRequiredCallback notificationFn) { }

	// RVA: 0x51BD80 Offset: 0x51AF80 VA: 0x18051BD80
	public ulong AddNotifyClientAuthStatusChanged(ref AddNotifyClientAuthStatusChangedOptions options, object clientData, OnClientAuthStatusChangedCallback notificationFn) { }

	// RVA: 0x51BF30 Offset: 0x51B130 VA: 0x18051BF30
	public ulong AddNotifyMessageToClient(ref AddNotifyMessageToClientOptions options, object clientData, OnMessageToClientCallback notificationFn) { }

	// RVA: 0x51C0E0 Offset: 0x51B2E0 VA: 0x18051C0E0
	public Result BeginSession(ref BeginSessionOptions options) { }

	// RVA: 0x51C180 Offset: 0x51B380 VA: 0x18051C180
	public Result EndSession(ref EndSessionOptions options) { }

	// RVA: 0x51C200 Offset: 0x51B400 VA: 0x18051C200
	public Result GetProtectMessageOutputLength(ref GetProtectMessageOutputLengthOptions options, out uint outBufferSizeBytes) { }

	// RVA: 0x51C2C0 Offset: 0x51B4C0 VA: 0x18051C2C0
	public Result LogEvent(ref LogEventOptions options) { }

	// RVA: 0x51C3D0 Offset: 0x51B5D0 VA: 0x18051C3D0
	public Result LogGameRoundEnd(ref LogGameRoundEndOptions options) { }

	// RVA: 0x51C460 Offset: 0x51B660 VA: 0x18051C460
	public Result LogGameRoundStart(ref LogGameRoundStartOptions options) { }

	// RVA: 0x51C510 Offset: 0x51B710 VA: 0x18051C510
	public Result LogPlayerDespawn(ref LogPlayerDespawnOptions options) { }

	// RVA: 0x51C5A0 Offset: 0x51B7A0 VA: 0x18051C5A0
	public Result LogPlayerRevive(ref LogPlayerReviveOptions options) { }

	// RVA: 0x51C640 Offset: 0x51B840 VA: 0x18051C640
	public Result LogPlayerSpawn(ref LogPlayerSpawnOptions options) { }

	// RVA: 0x51C6E0 Offset: 0x51B8E0 VA: 0x18051C6E0
	public Result LogPlayerTakeDamage(ref LogPlayerTakeDamageOptions options) { }

	// RVA: 0x51C7B0 Offset: 0x51B9B0 VA: 0x18051C7B0
	public Result LogPlayerTick(ref LogPlayerTickOptions options) { }

	// RVA: 0x51C860 Offset: 0x51BA60 VA: 0x18051C860
	public Result LogPlayerUseAbility(ref LogPlayerUseAbilityOptions options) { }

	// RVA: 0x51C910 Offset: 0x51BB10 VA: 0x18051C910
	public Result LogPlayerUseWeapon(ref LogPlayerUseWeaponOptions options) { }

	// RVA: 0x51CC30 Offset: 0x51BE30 VA: 0x18051CC30
	public Result ProtectMessage(ref ProtectMessageOptions options, ArraySegment<byte> outBuffer, out uint outBytesWritten) { }

	// RVA: 0x51CD90 Offset: 0x51BF90 VA: 0x18051CD90
	public Result ReceiveMessageFromClient(ref ReceiveMessageFromClientOptions options) { }

	// RVA: 0x51CE90 Offset: 0x51C090 VA: 0x18051CE90
	public Result RegisterClient(ref RegisterClientOptions options) { }

	// RVA: 0x51CF30 Offset: 0x51C130 VA: 0x18051CF30
	public Result RegisterEvent(ref RegisterEventOptions options) { }

	// RVA: 0x51CFD0 Offset: 0x51C1D0 VA: 0x18051CFD0
	public void RemoveNotifyClientActionRequired(ulong notificationId) { }

	// RVA: 0x51D040 Offset: 0x51C240 VA: 0x18051D040
	public void RemoveNotifyClientAuthStatusChanged(ulong notificationId) { }

	// RVA: 0x51D0B0 Offset: 0x51C2B0 VA: 0x18051D0B0
	public void RemoveNotifyMessageToClient(ulong notificationId) { }

	// RVA: 0x51D120 Offset: 0x51C320 VA: 0x18051D120
	public Result SetClientDetails(ref SetClientDetailsOptions options) { }

	// RVA: 0x51D1C0 Offset: 0x51C3C0 VA: 0x18051D1C0
	public Result SetClientNetworkState(ref SetClientNetworkStateOptions options) { }

	// RVA: 0x51D2A0 Offset: 0x51C4A0 VA: 0x18051D2A0
	public Result SetGameSessionId(ref SetGameSessionIdOptions options) { }

	// RVA: 0x51D340 Offset: 0x51C540 VA: 0x18051D340
	public Result UnprotectMessage(ref UnprotectMessageOptions options, ArraySegment<byte> outBuffer, out uint outBytesWritten) { }

	// RVA: 0x51D4A0 Offset: 0x51C6A0 VA: 0x18051D4A0
	public Result UnregisterClient(ref UnregisterClientOptions options) { }

	[MonoPInvokeCallback(typeof(OnClientActionRequiredCallbackInternal))]
	// RVA: 0x51CA20 Offset: 0x51BC20 VA: 0x18051CA20
	internal static void OnClientActionRequiredCallbackInternalImplementation(ref OnClientActionRequiredCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnClientAuthStatusChangedCallbackInternal))]
	// RVA: 0x51CAD0 Offset: 0x51BCD0 VA: 0x18051CAD0
	internal static void OnClientAuthStatusChangedCallbackInternalImplementation(ref OnClientAuthStatusChangedCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnMessageToClientCallbackInternal))]
	// RVA: 0x51CB80 Offset: 0x51BD80 VA: 0x18051CB80
	internal static void OnMessageToClientCallbackInternalImplementation(ref OnMessageToClientCallbackInfoInternal data) { }
}

// Namespace: Epic.OnlineServices.AntiCheatServer
public struct BeginSessionOptions // TypeDefIndex: 10019
{
	// Fields
	[CompilerGenerated]
	private uint <RegisterTimeoutSeconds>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <ServerName>k__BackingField; // 0x8
	[CompilerGenerated]
	private bool <EnableGameplayData>k__BackingField; // 0x10
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x18

	// Properties
	public uint RegisterTimeoutSeconds { get; set; }
	public Utf8String ServerName { get; set; }
	public bool EnableGameplayData { get; set; }
	public ProductUserId LocalUserId { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public uint get_RegisterTimeoutSeconds() { }

	[CompilerGenerated]
	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_RegisterTimeoutSeconds(uint value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public Utf8String get_ServerName() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_ServerName(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D6DA0 Offset: 0x3D5FA0 VA: 0x1803D6DA0
	public bool get_EnableGameplayData() { }

	[CompilerGenerated]
	// RVA: 0x3D6DB0 Offset: 0x3D5FB0 VA: 0x1803D6DB0
	public void set_EnableGameplayData(bool value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_LocalUserId(ProductUserId value) { }
}

// Namespace: Epic.OnlineServices.AntiCheatServer
internal struct BeginSessionOptionsInternal : ISettable<BeginSessionOptions>, IDisposable // TypeDefIndex: 10020
{
	// Fields
	private int m_ApiVersion; // 0x0
	private uint m_RegisterTimeoutSeconds; // 0x4
	private IntPtr m_ServerName; // 0x8
	private int m_EnableGameplayData; // 0x10
	private IntPtr m_LocalUserId; // 0x18

	// Properties
	public uint RegisterTimeoutSeconds { set; }
	public Utf8String ServerName { set; }
	public bool EnableGameplayData { set; }
	public ProductUserId LocalUserId { set; }

	// Methods

	// RVA: 0x3F84A0 Offset: 0x3F76A0 VA: 0x1803F84A0
	public void set_RegisterTimeoutSeconds(uint value) { }

	// RVA: 0x51F620 Offset: 0x51E820 VA: 0x18051F620
	public void set_ServerName(Utf8String value) { }

	// RVA: 0x51F560 Offset: 0x51E760 VA: 0x18051F560
	public void set_EnableGameplayData(bool value) { }

	// RVA: 0x51F5C0 Offset: 0x51E7C0 VA: 0x18051F5C0
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x51F460 Offset: 0x51E660 VA: 0x18051F460 Slot: 4
	public void Set(ref BeginSessionOptions other) { }

	// RVA: 0x51F2F0 Offset: 0x51E4F0 VA: 0x18051F2F0 Slot: 5
	public void Set(ref Nullable<BeginSessionOptions> other) { }

	// RVA: 0x51F290 Offset: 0x51E490 VA: 0x18051F290 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.AntiCheatServer
public struct EndSessionOptions // TypeDefIndex: 10021
{}

// Namespace: Epic.OnlineServices.AntiCheatServer
internal struct EndSessionOptionsInternal : ISettable<EndSessionOptions>, IDisposable // TypeDefIndex: 10022
{
	// Fields
	private int m_ApiVersion; // 0x0

	// Methods

	// RVA: 0x3F98A0 Offset: 0x3F8AA0 VA: 0x1803F98A0 Slot: 4
	public void Set(ref EndSessionOptions other) { }

	// RVA: 0x5202B0 Offset: 0x51F4B0 VA: 0x1805202B0 Slot: 5
	public void Set(ref Nullable<EndSessionOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.AntiCheatServer
public struct GetProtectMessageOutputLengthOptions // TypeDefIndex: 10023
{
	// Fields
	[CompilerGenerated]
	private uint <DataLengthBytes>k__BackingField; // 0x0

	// Properties
	public uint DataLengthBytes { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public uint get_DataLengthBytes() { }

	[CompilerGenerated]
	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_DataLengthBytes(uint value) { }
}

// Namespace: Epic.OnlineServices.AntiCheatServer
internal struct GetProtectMessageOutputLengthOptionsInternal : ISettable<GetProtectMessageOutputLengthOptions>, IDisposable // TypeDefIndex: 10024
{
	// Fields
	private int m_ApiVersion; // 0x0
	private uint m_DataLengthBytes; // 0x4

	// Properties
	public uint DataLengthBytes { set; }

	// Methods

	// RVA: 0x3F84A0 Offset: 0x3F76A0 VA: 0x1803F84A0
	public void set_DataLengthBytes(uint value) { }

	// RVA: 0x40B2E0 Offset: 0x40A4E0 VA: 0x18040B2E0 Slot: 4
	public void Set(ref GetProtectMessageOutputLengthOptions other) { }

	// RVA: 0x520300 Offset: 0x51F500 VA: 0x180520300 Slot: 5
	public void Set(ref Nullable<GetProtectMessageOutputLengthOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.AntiCheatServer
public sealed class OnClientActionRequiredCallback : MulticastDelegate // TypeDefIndex: 10025
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref OnClientActionRequiredCallbackInfo data) { }

	// RVA: 0x52A390 Offset: 0x529590 VA: 0x18052A390 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref OnClientActionRequiredCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref OnClientActionRequiredCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.AntiCheatServer
[UnmanagedFunctionPointer(2)]
internal sealed class OnClientActionRequiredCallbackInternal : MulticastDelegate // TypeDefIndex: 10026
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref OnClientActionRequiredCallbackInfoInternal data) { }

	// RVA: 0x52A300 Offset: 0x529500 VA: 0x18052A300 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref OnClientActionRequiredCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref OnClientActionRequiredCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.AntiCheatServer
public sealed class OnClientAuthStatusChangedCallback : MulticastDelegate // TypeDefIndex: 10027
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref OnClientAuthStatusChangedCallbackInfo data) { }

	// RVA: 0x52A7F0 Offset: 0x5299F0 VA: 0x18052A7F0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref OnClientAuthStatusChangedCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref OnClientAuthStatusChangedCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.AntiCheatServer
[UnmanagedFunctionPointer(2)]
internal sealed class OnClientAuthStatusChangedCallbackInternal : MulticastDelegate // TypeDefIndex: 10028
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref OnClientAuthStatusChangedCallbackInfoInternal data) { }

	// RVA: 0x52A760 Offset: 0x529960 VA: 0x18052A760 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref OnClientAuthStatusChangedCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref OnClientAuthStatusChangedCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.AntiCheatServer
public sealed class OnMessageToClientCallback : MulticastDelegate // TypeDefIndex: 10029
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref OnMessageToClientCallbackInfo data) { }

	// RVA: 0x52B3D0 Offset: 0x52A5D0 VA: 0x18052B3D0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref OnMessageToClientCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref OnMessageToClientCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.AntiCheatServer
[UnmanagedFunctionPointer(2)]
internal sealed class OnMessageToClientCallbackInternal : MulticastDelegate // TypeDefIndex: 10030
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref OnMessageToClientCallbackInfoInternal data) { }

	// RVA: 0x52B340 Offset: 0x52A540 VA: 0x18052B340 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref OnMessageToClientCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref OnMessageToClientCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.AntiCheatServer
public struct ProtectMessageOptions // TypeDefIndex: 10031
{
	// Fields
	[CompilerGenerated]
	private IntPtr <ClientHandle>k__BackingField; // 0x0
	[CompilerGenerated]
	private ArraySegment<byte> <Data>k__BackingField; // 0x8
	[CompilerGenerated]
	private uint <OutBufferSizeBytes>k__BackingField; // 0x18

	// Properties
	public IntPtr ClientHandle { get; set; }
	public ArraySegment<byte> Data { get; set; }
	public uint OutBufferSizeBytes { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public IntPtr get_ClientHandle() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_ClientHandle(IntPtr value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x42C4A0 Offset: 0x42B6A0 VA: 0x18042C4A0
	public ArraySegment<byte> get_Data() { }

	[CompilerGenerated]
	// RVA: 0x42C4B0 Offset: 0x42B6B0 VA: 0x18042C4B0
	public void set_Data(ArraySegment<byte> value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public uint get_OutBufferSizeBytes() { }

	[CompilerGenerated]
	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	public void set_OutBufferSizeBytes(uint value) { }
}

// Namespace: Epic.OnlineServices.AntiCheatServer
internal struct ProtectMessageOptionsInternal : ISettable<ProtectMessageOptions>, IDisposable // TypeDefIndex: 10032
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_ClientHandle; // 0x8
	private uint m_DataLengthBytes; // 0x10
	private IntPtr m_Data; // 0x18
	private uint m_OutBufferSizeBytes; // 0x20

	// Properties
	public IntPtr ClientHandle { set; }
	public ArraySegment<byte> Data { set; }
	public uint OutBufferSizeBytes { set; }

	// Methods

	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_ClientHandle(IntPtr value) { }

	// RVA: 0x52C420 Offset: 0x52B620 VA: 0x18052C420
	public void set_Data(ArraySegment<byte> value) { }

	// RVA: 0x3DA420 Offset: 0x3D9620 VA: 0x1803DA420
	public void set_OutBufferSizeBytes(uint value) { }

	// RVA: 0x52C2A0 Offset: 0x52B4A0 VA: 0x18052C2A0 Slot: 4
	public void Set(ref ProtectMessageOptions other) { }

	// RVA: 0x52C330 Offset: 0x52B530 VA: 0x18052C330 Slot: 5
	public void Set(ref Nullable<ProtectMessageOptions> other) { }

	// RVA: 0x52C240 Offset: 0x52B440 VA: 0x18052C240 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.AntiCheatServer
public struct ReceiveMessageFromClientOptions // TypeDefIndex: 10033
{
	// Fields
	[CompilerGenerated]
	private IntPtr <ClientHandle>k__BackingField; // 0x0
	[CompilerGenerated]
	private ArraySegment<byte> <Data>k__BackingField; // 0x8

	// Properties
	public IntPtr ClientHandle { get; set; }
	public ArraySegment<byte> Data { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public IntPtr get_ClientHandle() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_ClientHandle(IntPtr value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x42C4A0 Offset: 0x42B6A0 VA: 0x18042C4A0
	public ArraySegment<byte> get_Data() { }

	[CompilerGenerated]
	// RVA: 0x42C4B0 Offset: 0x42B6B0 VA: 0x18042C4B0
	public void set_Data(ArraySegment<byte> value) { }
}

// Namespace: Epic.OnlineServices.AntiCheatServer
internal struct ReceiveMessageFromClientOptionsInternal : ISettable<ReceiveMessageFromClientOptions>, IDisposable // TypeDefIndex: 10034
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_ClientHandle; // 0x8
	private uint m_DataLengthBytes; // 0x10
	private IntPtr m_Data; // 0x18

	// Properties
	public IntPtr ClientHandle { set; }
	public ArraySegment<byte> Data { set; }

	// Methods

	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_ClientHandle(IntPtr value) { }

	// RVA: 0x52E040 Offset: 0x52D240 VA: 0x18052E040
	public void set_Data(ArraySegment<byte> value) { }

	// RVA: 0x52DEE0 Offset: 0x52D0E0 VA: 0x18052DEE0 Slot: 4
	public void Set(ref ReceiveMessageFromClientOptions other) { }

	// RVA: 0x52DF60 Offset: 0x52D160 VA: 0x18052DF60 Slot: 5
	public void Set(ref Nullable<ReceiveMessageFromClientOptions> other) { }

	// RVA: 0x52DE80 Offset: 0x52D080 VA: 0x18052DE80 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.AntiCheatServer
public struct RegisterClientOptions // TypeDefIndex: 10035
{
	// Fields
	[CompilerGenerated]
	private IntPtr <ClientHandle>k__BackingField; // 0x0
	[CompilerGenerated]
	private AntiCheatCommonClientType <ClientType>k__BackingField; // 0x8
	[CompilerGenerated]
	private AntiCheatCommonClientPlatform <ClientPlatform>k__BackingField; // 0xC
	[CompilerGenerated]
	private Utf8String <AccountId_DEPRECATED>k__BackingField; // 0x10
	[CompilerGenerated]
	private Utf8String <IpAddress>k__BackingField; // 0x18
	[CompilerGenerated]
	private ProductUserId <UserId>k__BackingField; // 0x20

	// Properties
	public IntPtr ClientHandle { get; set; }
	public AntiCheatCommonClientType ClientType { get; set; }
	public AntiCheatCommonClientPlatform ClientPlatform { get; set; }
	internal Utf8String AccountId_DEPRECATED { get; set; }
	public Utf8String IpAddress { get; set; }
	public ProductUserId UserId { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public IntPtr get_ClientHandle() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_ClientHandle(IntPtr value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3F5510 Offset: 0x3F4710 VA: 0x1803F5510
	public AntiCheatCommonClientType get_ClientType() { }

	[CompilerGenerated]
	// RVA: 0x3F5520 Offset: 0x3F4720 VA: 0x1803F5520
	public void set_ClientType(AntiCheatCommonClientType value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x438080 Offset: 0x437280 VA: 0x180438080
	public AntiCheatCommonClientPlatform get_ClientPlatform() { }

	[CompilerGenerated]
	// RVA: 0x438090 Offset: 0x437290 VA: 0x180438090
	public void set_ClientPlatform(AntiCheatCommonClientPlatform value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	internal Utf8String get_AccountId_DEPRECATED() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	internal void set_AccountId_DEPRECATED(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public Utf8String get_IpAddress() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_IpAddress(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public ProductUserId get_UserId() { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_UserId(ProductUserId value) { }
}

// Namespace: Epic.OnlineServices.AntiCheatServer
internal struct RegisterClientOptionsInternal : ISettable<RegisterClientOptions>, IDisposable // TypeDefIndex: 10036
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_ClientHandle; // 0x8
	private AntiCheatCommonClientType m_ClientType; // 0x10
	private AntiCheatCommonClientPlatform m_ClientPlatform; // 0x14
	private IntPtr m_AccountId_DEPRECATED; // 0x18
	private IntPtr m_IpAddress; // 0x20
	private IntPtr m_UserId; // 0x28

	// Properties
	public IntPtr ClientHandle { set; }
	public AntiCheatCommonClientType ClientType { set; }
	public AntiCheatCommonClientPlatform ClientPlatform { set; }
	public Utf8String AccountId_DEPRECATED { set; }
	public Utf8String IpAddress { set; }
	public ProductUserId UserId { set; }

	// Methods

	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_ClientHandle(IntPtr value) { }

	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_ClientType(AntiCheatCommonClientType value) { }

	// RVA: 0x426530 Offset: 0x425730 VA: 0x180426530
	public void set_ClientPlatform(AntiCheatCommonClientPlatform value) { }

	// RVA: 0x52E3E0 Offset: 0x52D5E0 VA: 0x18052E3E0
	public void set_AccountId_DEPRECATED(Utf8String value) { }

	// RVA: 0x52E440 Offset: 0x52D640 VA: 0x18052E440
	public void set_IpAddress(Utf8String value) { }

	// RVA: 0x52E4A0 Offset: 0x52D6A0 VA: 0x18052E4A0
	public void set_UserId(ProductUserId value) { }

	// RVA: 0x52E120 Offset: 0x52D320 VA: 0x18052E120 Slot: 4
	public void Set(ref RegisterClientOptions other) { }

	// RVA: 0x52E230 Offset: 0x52D430 VA: 0x18052E230 Slot: 5
	public void Set(ref Nullable<RegisterClientOptions> other) { }

	// RVA: 0x52E0B0 Offset: 0x52D2B0 VA: 0x18052E0B0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.AntiCheatServer
public struct SetClientNetworkStateOptions // TypeDefIndex: 10037
{
	// Fields
	[CompilerGenerated]
	private IntPtr <ClientHandle>k__BackingField; // 0x0
	[CompilerGenerated]
	private bool <IsNetworkActive>k__BackingField; // 0x8

	// Properties
	public IntPtr ClientHandle { get; set; }
	public bool IsNetworkActive { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public IntPtr get_ClientHandle() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_ClientHandle(IntPtr value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x48F5C0 Offset: 0x48E7C0 VA: 0x18048F5C0
	public bool get_IsNetworkActive() { }

	[CompilerGenerated]
	// RVA: 0x48F5E0 Offset: 0x48E7E0 VA: 0x18048F5E0
	public void set_IsNetworkActive(bool value) { }
}

// Namespace: Epic.OnlineServices.AntiCheatServer
internal struct SetClientNetworkStateOptionsInternal : ISettable<SetClientNetworkStateOptions>, IDisposable // TypeDefIndex: 10038
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_ClientHandle; // 0x8
	private int m_IsNetworkActive; // 0x10

	// Properties
	public IntPtr ClientHandle { set; }
	public bool IsNetworkActive { set; }

	// Methods

	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_ClientHandle(IntPtr value) { }

	// RVA: 0x52E690 Offset: 0x52D890 VA: 0x18052E690
	public void set_IsNetworkActive(bool value) { }

	// RVA: 0x52E550 Offset: 0x52D750 VA: 0x18052E550 Slot: 4
	public void Set(ref SetClientNetworkStateOptions other) { }

	// RVA: 0x52E5C0 Offset: 0x52D7C0 VA: 0x18052E5C0 Slot: 5
	public void Set(ref Nullable<SetClientNetworkStateOptions> other) { }

	// RVA: 0x52E500 Offset: 0x52D700 VA: 0x18052E500 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.AntiCheatServer
public struct UnprotectMessageOptions // TypeDefIndex: 10039
{
	// Fields
	[CompilerGenerated]
	private IntPtr <ClientHandle>k__BackingField; // 0x0
	[CompilerGenerated]
	private ArraySegment<byte> <Data>k__BackingField; // 0x8
	[CompilerGenerated]
	private uint <OutBufferSizeBytes>k__BackingField; // 0x18

	// Properties
	public IntPtr ClientHandle { get; set; }
	public ArraySegment<byte> Data { get; set; }
	public uint OutBufferSizeBytes { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public IntPtr get_ClientHandle() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_ClientHandle(IntPtr value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x42C4A0 Offset: 0x42B6A0 VA: 0x18042C4A0
	public ArraySegment<byte> get_Data() { }

	[CompilerGenerated]
	// RVA: 0x42C4B0 Offset: 0x42B6B0 VA: 0x18042C4B0
	public void set_Data(ArraySegment<byte> value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public uint get_OutBufferSizeBytes() { }

	[CompilerGenerated]
	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	public void set_OutBufferSizeBytes(uint value) { }
}

// Namespace: Epic.OnlineServices.AntiCheatServer
internal struct UnprotectMessageOptionsInternal : ISettable<UnprotectMessageOptions>, IDisposable // TypeDefIndex: 10040
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_ClientHandle; // 0x8
	private uint m_DataLengthBytes; // 0x10
	private IntPtr m_Data; // 0x18
	private uint m_OutBufferSizeBytes; // 0x20

	// Properties
	public IntPtr ClientHandle { set; }
	public ArraySegment<byte> Data { set; }
	public uint OutBufferSizeBytes { set; }

	// Methods

	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_ClientHandle(IntPtr value) { }

	// RVA: 0x530690 Offset: 0x52F890 VA: 0x180530690
	public void set_Data(ArraySegment<byte> value) { }

	// RVA: 0x3DA420 Offset: 0x3D9620 VA: 0x1803DA420
	public void set_OutBufferSizeBytes(uint value) { }

	// RVA: 0x530510 Offset: 0x52F710 VA: 0x180530510 Slot: 4
	public void Set(ref UnprotectMessageOptions other) { }

	// RVA: 0x5305A0 Offset: 0x52F7A0 VA: 0x1805305A0 Slot: 5
	public void Set(ref Nullable<UnprotectMessageOptions> other) { }

	// RVA: 0x5304B0 Offset: 0x52F6B0 VA: 0x1805304B0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.AntiCheatServer
public struct UnregisterClientOptions // TypeDefIndex: 10041
{
	// Fields
	[CompilerGenerated]
	private IntPtr <ClientHandle>k__BackingField; // 0x0

	// Properties
	public IntPtr ClientHandle { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public IntPtr get_ClientHandle() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_ClientHandle(IntPtr value) { }
}

// Namespace: Epic.OnlineServices.AntiCheatServer
internal struct UnregisterClientOptionsInternal : ISettable<UnregisterClientOptions>, IDisposable // TypeDefIndex: 10042
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_ClientHandle; // 0x8

	// Properties
	public IntPtr ClientHandle { set; }

	// Methods

	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_ClientHandle(IntPtr value) { }

	// RVA: 0x40DD30 Offset: 0x40CF30 VA: 0x18040DD30 Slot: 4
	public void Set(ref UnregisterClientOptions other) { }

	// RVA: 0x530750 Offset: 0x52F950 VA: 0x180530750 Slot: 5
	public void Set(ref Nullable<UnregisterClientOptions> other) { }

	// RVA: 0x530700 Offset: 0x52F900 VA: 0x180530700 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.AntiCheatCommon
public enum AntiCheatCommonClientAction // TypeDefIndex: 10043
{
	// Fields
	public int value__; // 0x0
	public const AntiCheatCommonClientAction Invalid = 0;
	public const AntiCheatCommonClientAction RemovePlayer = 1;
}

// Namespace: Epic.OnlineServices.AntiCheatCommon
public enum AntiCheatCommonClientActionReason // TypeDefIndex: 10044
{
	// Fields
	public int value__; // 0x0
	public const AntiCheatCommonClientActionReason Invalid = 0;
	public const AntiCheatCommonClientActionReason InternalError = 1;
	public const AntiCheatCommonClientActionReason InvalidMessage = 2;
	public const AntiCheatCommonClientActionReason AuthenticationFailed = 3;
	public const AntiCheatCommonClientActionReason NullClient = 4;
	public const AntiCheatCommonClientActionReason HeartbeatTimeout = 5;
	public const AntiCheatCommonClientActionReason ClientViolation = 6;
	public const AntiCheatCommonClientActionReason BackendViolation = 7;
	public const AntiCheatCommonClientActionReason TemporaryCooldown = 8;
	public const AntiCheatCommonClientActionReason TemporaryBanned = 9;
	public const AntiCheatCommonClientActionReason PermanentBanned = 10;
}

// Namespace: Epic.OnlineServices.AntiCheatCommon
public enum AntiCheatCommonClientAuthStatus // TypeDefIndex: 10045
{
	// Fields
	public int value__; // 0x0
	public const AntiCheatCommonClientAuthStatus Invalid = 0;
	public const AntiCheatCommonClientAuthStatus LocalAuthComplete = 1;
	public const AntiCheatCommonClientAuthStatus RemoteAuthComplete = 2;
}

// Namespace: Epic.OnlineServices.AntiCheatCommon
[Flags]
public enum AntiCheatCommonClientFlags // TypeDefIndex: 10046
{
	// Fields
	public int value__; // 0x0
	public const AntiCheatCommonClientFlags None = 0;
	public const AntiCheatCommonClientFlags Admin = 1;
}

// Namespace: Epic.OnlineServices.AntiCheatCommon
public enum AntiCheatCommonClientInput // TypeDefIndex: 10047
{
	// Fields
	public int value__; // 0x0
	public const AntiCheatCommonClientInput Unknown = 0;
	public const AntiCheatCommonClientInput MouseKeyboard = 1;
	public const AntiCheatCommonClientInput Gamepad = 2;
	public const AntiCheatCommonClientInput TouchInput = 3;
}

// Namespace: Epic.OnlineServices.AntiCheatCommon
public enum AntiCheatCommonClientPlatform // TypeDefIndex: 10048
{
	// Fields
	public int value__; // 0x0
	public const AntiCheatCommonClientPlatform Unknown = 0;
	public const AntiCheatCommonClientPlatform Windows = 1;
	public const AntiCheatCommonClientPlatform Mac = 2;
	public const AntiCheatCommonClientPlatform Linux = 3;
	public const AntiCheatCommonClientPlatform Xbox = 4;
	public const AntiCheatCommonClientPlatform PlayStation = 5;
	public const AntiCheatCommonClientPlatform Nintendo = 6;
	public const AntiCheatCommonClientPlatform iOS = 7;
	public const AntiCheatCommonClientPlatform Android = 8;
}

// Namespace: Epic.OnlineServices.AntiCheatCommon
public enum AntiCheatCommonClientType // TypeDefIndex: 10049
{
	// Fields
	public int value__; // 0x0
	public const AntiCheatCommonClientType ProtectedClient = 0;
	public const AntiCheatCommonClientType UnprotectedClient = 1;
	public const AntiCheatCommonClientType AIBot = 2;
}

// Namespace: Epic.OnlineServices.AntiCheatCommon
public enum AntiCheatCommonEventParamType // TypeDefIndex: 10050
{
	// Fields
	public int value__; // 0x0
	public const AntiCheatCommonEventParamType Invalid = 0;
	public const AntiCheatCommonEventParamType ClientHandle = 1;
	public const AntiCheatCommonEventParamType String = 2;
	public const AntiCheatCommonEventParamType UInt32 = 3;
	public const AntiCheatCommonEventParamType Int32 = 4;
	public const AntiCheatCommonEventParamType UInt64 = 5;
	public const AntiCheatCommonEventParamType Int64 = 6;
	public const AntiCheatCommonEventParamType Vector3f = 7;
	public const AntiCheatCommonEventParamType Quat = 8;
	public const AntiCheatCommonEventParamType Float = 9;
}

// Namespace: Epic.OnlineServices.AntiCheatCommon
public enum AntiCheatCommonEventType // TypeDefIndex: 10051
{
	// Fields
	public int value__; // 0x0
	public const AntiCheatCommonEventType Invalid = 0;
	public const AntiCheatCommonEventType GameEvent = 1;
	public const AntiCheatCommonEventType PlayerEvent = 2;
}

// Namespace: Epic.OnlineServices.AntiCheatCommon
public enum AntiCheatCommonGameRoundCompetitionType // TypeDefIndex: 10052
{
	// Fields
	public int value__; // 0x0
	public const AntiCheatCommonGameRoundCompetitionType None = 0;
	public const AntiCheatCommonGameRoundCompetitionType Casual = 1;
	public const AntiCheatCommonGameRoundCompetitionType Ranked = 2;
	public const AntiCheatCommonGameRoundCompetitionType Competitive = 3;
}

// Namespace: Epic.OnlineServices.AntiCheatCommon
public sealed class AntiCheatCommonInterface // TypeDefIndex: 10053
{
	// Fields
	public const int LogeventApiLatest = 1;
	public const int LogeventStringMaxLength = 39;
	public const int LoggameroundendApiLatest = 1;
	public const int LoggameroundstartApiLatest = 2;
	public const int LogplayerdespawnApiLatest = 1;
	public const int LogplayerreviveApiLatest = 1;
	public const int LogplayerspawnApiLatest = 1;
	public const int LogplayertakedamageApiLatest = 4;
	public const int LogplayertickApiLatest = 3;
	public const int LogplayeruseabilityApiLatest = 1;
	public const int LogplayeruseweaponApiLatest = 2;
	public const int LogplayeruseweaponWeaponnameMaxLength = 16;
	public const int RegistereventApiLatest = 1;
	public const int RegistereventCustomeventbase = 268435456;
	public const int RegistereventMaxParamdefscount = 12;
	public const int SetclientdetailsApiLatest = 1;
	public const int SetgamesessionidApiLatest = 1;

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: Epic.OnlineServices.AntiCheatCommon
public enum AntiCheatCommonPlayerMovementState // TypeDefIndex: 10054
{
	// Fields
	public int value__; // 0x0
	public const AntiCheatCommonPlayerMovementState None = 0;
	public const AntiCheatCommonPlayerMovementState Crouching = 1;
	public const AntiCheatCommonPlayerMovementState Prone = 2;
	public const AntiCheatCommonPlayerMovementState Mounted = 3;
	public const AntiCheatCommonPlayerMovementState Swimming = 4;
	public const AntiCheatCommonPlayerMovementState Falling = 5;
	public const AntiCheatCommonPlayerMovementState Flying = 6;
	public const AntiCheatCommonPlayerMovementState OnLadder = 7;
}

// Namespace: Epic.OnlineServices.AntiCheatCommon
public enum AntiCheatCommonPlayerTakeDamageResult // TypeDefIndex: 10055
{
	// Fields
	public int value__; // 0x0
	public const AntiCheatCommonPlayerTakeDamageResult None = 0;
	public const AntiCheatCommonPlayerTakeDamageResult DownedDEPRECATED = 1;
	public const AntiCheatCommonPlayerTakeDamageResult EliminatedDEPRECATED = 2;
	public const AntiCheatCommonPlayerTakeDamageResult NormalToDowned = 3;
	public const AntiCheatCommonPlayerTakeDamageResult NormalToEliminated = 4;
	public const AntiCheatCommonPlayerTakeDamageResult DownedToEliminated = 5;
}

// Namespace: Epic.OnlineServices.AntiCheatCommon
public enum AntiCheatCommonPlayerTakeDamageSource // TypeDefIndex: 10056
{
	// Fields
	public int value__; // 0x0
	public const AntiCheatCommonPlayerTakeDamageSource None = 0;
	public const AntiCheatCommonPlayerTakeDamageSource Player = 1;
	public const AntiCheatCommonPlayerTakeDamageSource NonPlayerCharacter = 2;
	public const AntiCheatCommonPlayerTakeDamageSource World = 3;
}

// Namespace: Epic.OnlineServices.AntiCheatCommon
public enum AntiCheatCommonPlayerTakeDamageType // TypeDefIndex: 10057
{
	// Fields
	public int value__; // 0x0
	public const AntiCheatCommonPlayerTakeDamageType None = 0;
	public const AntiCheatCommonPlayerTakeDamageType PointDamage = 1;
	public const AntiCheatCommonPlayerTakeDamageType RadialDamage = 2;
	public const AntiCheatCommonPlayerTakeDamageType DamageOverTime = 3;
}

// Namespace: Epic.OnlineServices.AntiCheatCommon
public struct LogEventOptions // TypeDefIndex: 10058
{
	// Fields
	[CompilerGenerated]
	private IntPtr <ClientHandle>k__BackingField; // 0x0
	[CompilerGenerated]
	private uint <EventId>k__BackingField; // 0x8
	[CompilerGenerated]
	private LogEventParamPair[] <Params>k__BackingField; // 0x10

	// Properties
	public IntPtr ClientHandle { get; set; }
	public uint EventId { get; set; }
	public LogEventParamPair[] Params { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public IntPtr get_ClientHandle() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_ClientHandle(IntPtr value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3F5510 Offset: 0x3F4710 VA: 0x1803F5510
	public uint get_EventId() { }

	[CompilerGenerated]
	// RVA: 0x3F5520 Offset: 0x3F4720 VA: 0x1803F5520
	public void set_EventId(uint value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public LogEventParamPair[] get_Params() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_Params(LogEventParamPair[] value) { }
}

// Namespace: Epic.OnlineServices.AntiCheatCommon
internal struct LogEventOptionsInternal : ISettable<LogEventOptions>, IDisposable // TypeDefIndex: 10059
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_ClientHandle; // 0x8
	private uint m_EventId; // 0x10
	private uint m_ParamsCount; // 0x14
	private IntPtr m_Params; // 0x18

	// Properties
	public IntPtr ClientHandle { set; }
	public uint EventId { set; }
	public LogEventParamPair[] Params { set; }

	// Methods

	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_ClientHandle(IntPtr value) { }

	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_EventId(uint value) { }

	// RVA: 0x522420 Offset: 0x521620 VA: 0x180522420
	public void set_Params(LogEventParamPair[] value) { }

	// RVA: 0x522390 Offset: 0x521590 VA: 0x180522390 Slot: 4
	public void Set(ref LogEventOptions other) { }

	// RVA: 0x5222E0 Offset: 0x5214E0 VA: 0x1805222E0 Slot: 5
	public void Set(ref Nullable<LogEventOptions> other) { }

	// RVA: 0x522280 Offset: 0x521480 VA: 0x180522280 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.AntiCheatCommon
public struct LogEventParamPair // TypeDefIndex: 10060
{
	// Fields
	[CompilerGenerated]
	private LogEventParamPairParamValue <ParamValue>k__BackingField; // 0x0

	// Properties
	public LogEventParamPairParamValue ParamValue { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x5255D0 Offset: 0x5247D0 VA: 0x1805255D0
	public LogEventParamPairParamValue get_ParamValue() { }

	[CompilerGenerated]
	// RVA: 0x525620 Offset: 0x524820 VA: 0x180525620
	public void set_ParamValue(LogEventParamPairParamValue value) { }

	// RVA: 0x5254D0 Offset: 0x5246D0 VA: 0x1805254D0
	internal void Set(ref LogEventParamPairInternal other) { }
}

// Namespace: Epic.OnlineServices.AntiCheatCommon
internal struct LogEventParamPairInternal : IGettable<LogEventParamPair>, ISettable<LogEventParamPair>, IDisposable // TypeDefIndex: 10061
{
	// Fields
	private LogEventParamPairParamValueInternal m_ParamValue; // 0x0

	// Properties
	public LogEventParamPairParamValue ParamValue { get; set; }

	// Methods

	// RVA: 0x522710 Offset: 0x521910 VA: 0x180522710
	public LogEventParamPairParamValue get_ParamValue() { }

	// RVA: 0x5227A0 Offset: 0x5219A0 VA: 0x1805227A0
	public void set_ParamValue(LogEventParamPairParamValue value) { }

	// RVA: 0x522660 Offset: 0x521860 VA: 0x180522660 Slot: 5
	public void Set(ref LogEventParamPair other) { }

	// RVA: 0x522530 Offset: 0x521730 VA: 0x180522530 Slot: 6
	public void Set(ref Nullable<LogEventParamPair> other) { }

	// RVA: 0x522490 Offset: 0x521690 VA: 0x180522490 Slot: 7
	public void Dispose() { }

	// RVA: 0x5224F0 Offset: 0x5216F0 VA: 0x1805224F0 Slot: 4
	public void Get(out LogEventParamPair output) { }
}

// Namespace: Epic.OnlineServices.AntiCheatCommon
public struct LogEventParamPairParamValue // TypeDefIndex: 10062
{
	// Fields
	private AntiCheatCommonEventParamType m_ParamValueType; // 0x0
	private Nullable<IntPtr> m_ClientHandle; // 0x8
	private Utf8String m_String; // 0x18
	private Nullable<uint> m_UInt32; // 0x20
	private Nullable<int> m_Int32; // 0x28
	private Nullable<ulong> m_UInt64; // 0x30
	private Nullable<long> m_Int64; // 0x40
	private Vec3f m_Vec3f; // 0x50
	private Quat m_Quat; // 0x5C
	private Nullable<float> m_Float; // 0x6C

	// Properties
	public AntiCheatCommonEventParamType ParamValueType { get; set; }
	public Nullable<IntPtr> ClientHandle { get; set; }
	public Utf8String String { get; set; }
	public Nullable<uint> UInt32 { get; set; }
	public Nullable<int> Int32 { get; set; }
	public Nullable<ulong> UInt64 { get; set; }
	public Nullable<long> Int64 { get; set; }
	public Vec3f Vec3f { get; set; }
	public Quat Quat { get; set; }
	public Nullable<float> Float { get; set; }

	// Methods

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public AntiCheatCommonEventParamType get_ParamValueType() { }

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	private void set_ParamValueType(AntiCheatCommonEventParamType value) { }

	// RVA: 0x524330 Offset: 0x523530 VA: 0x180524330
	public Nullable<IntPtr> get_ClientHandle() { }

	// RVA: 0x524FB0 Offset: 0x5241B0 VA: 0x180524FB0
	public void set_ClientHandle(Nullable<IntPtr> value) { }

	// RVA: 0x524630 Offset: 0x523830 VA: 0x180524630
	public Utf8String get_String() { }

	// RVA: 0x525280 Offset: 0x524480 VA: 0x180525280
	public void set_String(Utf8String value) { }

	// RVA: 0x5246C0 Offset: 0x5238C0 VA: 0x1805246C0
	public Nullable<uint> get_UInt32() { }

	// RVA: 0x525310 Offset: 0x524510 VA: 0x180525310
	public void set_UInt32(Nullable<uint> value) { }

	// RVA: 0x524460 Offset: 0x523660 VA: 0x180524460
	public Nullable<int> get_Int32() { }

	// RVA: 0x5250D0 Offset: 0x5242D0 VA: 0x1805250D0
	public void set_Int32(Nullable<int> value) { }

	// RVA: 0x524750 Offset: 0x523950 VA: 0x180524750
	public Nullable<ulong> get_UInt64() { }

	// RVA: 0x5253A0 Offset: 0x5245A0 VA: 0x1805253A0
	public void set_UInt64(Nullable<ulong> value) { }

	// RVA: 0x5244F0 Offset: 0x5236F0 VA: 0x1805244F0
	public Nullable<long> get_Int64() { }

	// RVA: 0x525160 Offset: 0x524360 VA: 0x180525160
	public void set_Int64(Nullable<long> value) { }

	// RVA: 0x5247F0 Offset: 0x5239F0 VA: 0x1805247F0
	public Vec3f get_Vec3f() { }

	// RVA: 0x525430 Offset: 0x524630 VA: 0x180525430
	public void set_Vec3f(Vec3f value) { }

	// RVA: 0x524590 Offset: 0x523790 VA: 0x180524590
	public Quat get_Quat() { }

	// RVA: 0x5251F0 Offset: 0x5243F0 VA: 0x1805251F0
	public void set_Quat(Quat value) { }

	// RVA: 0x5243D0 Offset: 0x5235D0 VA: 0x1805243D0
	public Nullable<float> get_Float() { }

	// RVA: 0x525040 Offset: 0x524240 VA: 0x180525040
	public void set_Float(Nullable<float> value) { }

	// RVA: 0x524AD0 Offset: 0x523CD0 VA: 0x180524AD0
	public static LogEventParamPairParamValue op_Implicit(IntPtr value) { }

	// RVA: 0x524A90 Offset: 0x523C90 VA: 0x180524A90
	public static LogEventParamPairParamValue op_Implicit(Utf8String value) { }

	// RVA: 0x524A00 Offset: 0x523C00 VA: 0x180524A00
	public static LogEventParamPairParamValue op_Implicit(string value) { }

	// RVA: 0x524F20 Offset: 0x524120 VA: 0x180524F20
	public static LogEventParamPairParamValue op_Implicit(uint value) { }

	// RVA: 0x524E90 Offset: 0x524090 VA: 0x180524E90
	public static LogEventParamPairParamValue op_Implicit(int value) { }

	// RVA: 0x524BD0 Offset: 0x523DD0 VA: 0x180524BD0
	public static LogEventParamPairParamValue op_Implicit(ulong value) { }

	// RVA: 0x524CD0 Offset: 0x523ED0 VA: 0x180524CD0
	public static LogEventParamPairParamValue op_Implicit(long value) { }

	// RVA: 0x5248A0 Offset: 0x523AA0 VA: 0x1805248A0
	public static LogEventParamPairParamValue op_Implicit(Vec3f value) { }

	// RVA: 0x524DD0 Offset: 0x523FD0 VA: 0x180524DD0
	public static LogEventParamPairParamValue op_Implicit(Quat value) { }

	// RVA: 0x524970 Offset: 0x523B70 VA: 0x180524970
	public static LogEventParamPairParamValue op_Implicit(float value) { }

	// RVA: 0x523E50 Offset: 0x523050 VA: 0x180523E50
	internal void Set(ref LogEventParamPairParamValueInternal other) { }
}

// Namespace: Epic.OnlineServices.AntiCheatCommon
internal struct LogEventParamPairParamValueInternal : IGettable<LogEventParamPairParamValue>, ISettable<LogEventParamPairParamValue>, IDisposable // TypeDefIndex: 10063
{
	// Fields
	private AntiCheatCommonEventParamType m_ParamValueType; // 0x0
	private IntPtr m_ClientHandle; // 0x8
	private IntPtr m_String; // 0x8
	private uint m_UInt32; // 0x8
	private int m_Int32; // 0x8
	private ulong m_UInt64; // 0x8
	private long m_Int64; // 0x8
	private Vec3fInternal m_Vec3f; // 0x8
	private QuatInternal m_Quat; // 0x8
	private float m_Float; // 0x8

	// Properties
	public Nullable<IntPtr> ClientHandle { get; set; }
	public Utf8String String { get; set; }
	public Nullable<uint> UInt32 { get; set; }
	public Nullable<int> Int32 { get; set; }
	public Nullable<ulong> UInt64 { get; set; }
	public Nullable<long> Int64 { get; set; }
	public Vec3f Vec3f { get; set; }
	public Quat Quat { get; set; }
	public Nullable<float> Float { get; set; }

	// Methods

	// RVA: 0x523220 Offset: 0x522420 VA: 0x180523220
	public Nullable<IntPtr> get_ClientHandle() { }

	// RVA: 0x523760 Offset: 0x522960 VA: 0x180523760
	public void set_ClientHandle(Nullable<IntPtr> value) { }

	// RVA: 0x523510 Offset: 0x522710 VA: 0x180523510
	public Utf8String get_String() { }

	// RVA: 0x523B40 Offset: 0x522D40 VA: 0x180523B40
	public void set_String(Utf8String value) { }

	// RVA: 0x5235A0 Offset: 0x5227A0 VA: 0x1805235A0
	public Nullable<uint> get_UInt32() { }

	// RVA: 0x523C00 Offset: 0x522E00 VA: 0x180523C00
	public void set_UInt32(Nullable<uint> value) { }

	// RVA: 0x523350 Offset: 0x522550 VA: 0x180523350
	public Nullable<int> get_Int32() { }

	// RVA: 0x5238F0 Offset: 0x522AF0 VA: 0x1805238F0
	public void set_Int32(Nullable<int> value) { }

	// RVA: 0x523630 Offset: 0x522830 VA: 0x180523630
	public Nullable<ulong> get_UInt64() { }

	// RVA: 0x523CC0 Offset: 0x522EC0 VA: 0x180523CC0
	public void set_UInt64(Nullable<ulong> value) { }

	// RVA: 0x5233E0 Offset: 0x5225E0 VA: 0x1805233E0
	public Nullable<long> get_Int64() { }

	// RVA: 0x5239B0 Offset: 0x522BB0 VA: 0x1805239B0
	public void set_Int64(Nullable<long> value) { }

	// RVA: 0x5236D0 Offset: 0x5228D0 VA: 0x1805236D0
	public Vec3f get_Vec3f() { }

	// RVA: 0x523D90 Offset: 0x522F90 VA: 0x180523D90
	public void set_Vec3f(Vec3f value) { }

	// RVA: 0x523480 Offset: 0x522680 VA: 0x180523480
	public Quat get_Quat() { }

	// RVA: 0x523A80 Offset: 0x522C80 VA: 0x180523A80
	public void set_Quat(Quat value) { }

	// RVA: 0x5232C0 Offset: 0x5224C0 VA: 0x1805232C0
	public Nullable<float> get_Float() { }

	// RVA: 0x523830 Offset: 0x522A30 VA: 0x180523830
	public void set_Float(Nullable<float> value) { }

	// RVA: 0x522910 Offset: 0x521B10 VA: 0x180522910 Slot: 5
	public void Set(ref LogEventParamPairParamValue other) { }

	// RVA: 0x522C80 Offset: 0x521E80 VA: 0x180522C80 Slot: 6
	public void Set(ref Nullable<LogEventParamPairParamValue> other) { }

	// RVA: 0x522810 Offset: 0x521A10 VA: 0x180522810 Slot: 7
	public void Dispose() { }

	// RVA: 0x5228D0 Offset: 0x521AD0 VA: 0x1805228D0 Slot: 4
	public void Get(out LogEventParamPairParamValue output) { }
}

// Namespace: Epic.OnlineServices.AntiCheatCommon
public struct LogGameRoundEndOptions // TypeDefIndex: 10064
{
	// Fields
	[CompilerGenerated]
	private uint <WinningTeamId>k__BackingField; // 0x0

	// Properties
	public uint WinningTeamId { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public uint get_WinningTeamId() { }

	[CompilerGenerated]
	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_WinningTeamId(uint value) { }
}

// Namespace: Epic.OnlineServices.AntiCheatCommon
internal struct LogGameRoundEndOptionsInternal : ISettable<LogGameRoundEndOptions>, IDisposable // TypeDefIndex: 10065
{
	// Fields
	private int m_ApiVersion; // 0x0
	private uint m_WinningTeamId; // 0x4

	// Properties
	public uint WinningTeamId { set; }

	// Methods

	// RVA: 0x3F84A0 Offset: 0x3F76A0 VA: 0x1803F84A0
	public void set_WinningTeamId(uint value) { }

	// RVA: 0x40B2E0 Offset: 0x40A4E0 VA: 0x18040B2E0 Slot: 4
	public void Set(ref LogGameRoundEndOptions other) { }

	// RVA: 0x525670 Offset: 0x524870 VA: 0x180525670 Slot: 5
	public void Set(ref Nullable<LogGameRoundEndOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.AntiCheatCommon
public struct LogGameRoundStartOptions // TypeDefIndex: 10066
{
	// Fields
	[CompilerGenerated]
	private Utf8String <SessionIdentifier>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <LevelName>k__BackingField; // 0x8
	[CompilerGenerated]
	private Utf8String <ModeName>k__BackingField; // 0x10
	[CompilerGenerated]
	private uint <RoundTimeSeconds>k__BackingField; // 0x18
	[CompilerGenerated]
	private AntiCheatCommonGameRoundCompetitionType <CompetitionType>k__BackingField; // 0x1C

	// Properties
	public Utf8String SessionIdentifier { get; set; }
	public Utf8String LevelName { get; set; }
	public Utf8String ModeName { get; set; }
	public uint RoundTimeSeconds { get; set; }
	public AntiCheatCommonGameRoundCompetitionType CompetitionType { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Utf8String get_SessionIdentifier() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_SessionIdentifier(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public Utf8String get_LevelName() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_LevelName(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Utf8String get_ModeName() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_ModeName(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public uint get_RoundTimeSeconds() { }

	[CompilerGenerated]
	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	public void set_RoundTimeSeconds(uint value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3F9110 Offset: 0x3F8310 VA: 0x1803F9110
	public AntiCheatCommonGameRoundCompetitionType get_CompetitionType() { }

	[CompilerGenerated]
	// RVA: 0x3F9290 Offset: 0x3F8490 VA: 0x1803F9290
	public void set_CompetitionType(AntiCheatCommonGameRoundCompetitionType value) { }
}

// Namespace: Epic.OnlineServices.AntiCheatCommon
internal struct LogGameRoundStartOptionsInternal : ISettable<LogGameRoundStartOptions>, IDisposable // TypeDefIndex: 10067
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_SessionIdentifier; // 0x8
	private IntPtr m_LevelName; // 0x10
	private IntPtr m_ModeName; // 0x18
	private uint m_RoundTimeSeconds; // 0x20
	private AntiCheatCommonGameRoundCompetitionType m_CompetitionType; // 0x24

	// Properties
	public Utf8String SessionIdentifier { set; }
	public Utf8String LevelName { set; }
	public Utf8String ModeName { set; }
	public uint RoundTimeSeconds { set; }
	public AntiCheatCommonGameRoundCompetitionType CompetitionType { set; }

	// Methods

	// RVA: 0x525A90 Offset: 0x524C90 VA: 0x180525A90
	public void set_SessionIdentifier(Utf8String value) { }

	// RVA: 0x5259D0 Offset: 0x524BD0 VA: 0x1805259D0
	public void set_LevelName(Utf8String value) { }

	// RVA: 0x525A30 Offset: 0x524C30 VA: 0x180525A30
	public void set_ModeName(Utf8String value) { }

	// RVA: 0x3DA420 Offset: 0x3D9620 VA: 0x1803DA420
	public void set_RoundTimeSeconds(uint value) { }

	// RVA: 0x47C1C0 Offset: 0x47B3C0 VA: 0x18047C1C0
	public void set_CompetitionType(AntiCheatCommonGameRoundCompetitionType value) { }

	// RVA: 0x5258C0 Offset: 0x524AC0 VA: 0x1805258C0 Slot: 4
	public void Set(ref LogGameRoundStartOptions other) { }

	// RVA: 0x525730 Offset: 0x524930 VA: 0x180525730 Slot: 5
	public void Set(ref Nullable<LogGameRoundStartOptions> other) { }

	// RVA: 0x5256D0 Offset: 0x5248D0 VA: 0x1805256D0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.AntiCheatCommon
public struct LogPlayerDespawnOptions // TypeDefIndex: 10068
{
	// Fields
	[CompilerGenerated]
	private IntPtr <DespawnedPlayerHandle>k__BackingField; // 0x0

	// Properties
	public IntPtr DespawnedPlayerHandle { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public IntPtr get_DespawnedPlayerHandle() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_DespawnedPlayerHandle(IntPtr value) { }
}

// Namespace: Epic.OnlineServices.AntiCheatCommon
internal struct LogPlayerDespawnOptionsInternal : ISettable<LogPlayerDespawnOptions>, IDisposable // TypeDefIndex: 10069
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_DespawnedPlayerHandle; // 0x8

	// Properties
	public IntPtr DespawnedPlayerHandle { set; }

	// Methods

	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_DespawnedPlayerHandle(IntPtr value) { }

	// RVA: 0x40DD30 Offset: 0x40CF30 VA: 0x18040DD30 Slot: 4
	public void Set(ref LogPlayerDespawnOptions other) { }

	// RVA: 0x525B40 Offset: 0x524D40 VA: 0x180525B40 Slot: 5
	public void Set(ref Nullable<LogPlayerDespawnOptions> other) { }

	// RVA: 0x525AF0 Offset: 0x524CF0 VA: 0x180525AF0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.AntiCheatCommon
public struct LogPlayerReviveOptions // TypeDefIndex: 10070
{
	// Fields
	[CompilerGenerated]
	private IntPtr <RevivedPlayerHandle>k__BackingField; // 0x0
	[CompilerGenerated]
	private IntPtr <ReviverPlayerHandle>k__BackingField; // 0x8

	// Properties
	public IntPtr RevivedPlayerHandle { get; set; }
	public IntPtr ReviverPlayerHandle { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public IntPtr get_RevivedPlayerHandle() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_RevivedPlayerHandle(IntPtr value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public IntPtr get_ReviverPlayerHandle() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_ReviverPlayerHandle(IntPtr value) { }
}

// Namespace: Epic.OnlineServices.AntiCheatCommon
internal struct LogPlayerReviveOptionsInternal : ISettable<LogPlayerReviveOptions>, IDisposable // TypeDefIndex: 10071
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_RevivedPlayerHandle; // 0x8
	private IntPtr m_ReviverPlayerHandle; // 0x10

	// Properties
	public IntPtr RevivedPlayerHandle { set; }
	public IntPtr ReviverPlayerHandle { set; }

	// Methods

	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_RevivedPlayerHandle(IntPtr value) { }

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_ReviverPlayerHandle(IntPtr value) { }

	// RVA: 0x491D50 Offset: 0x490F50 VA: 0x180491D50 Slot: 4
	public void Set(ref LogPlayerReviveOptions other) { }

	// RVA: 0x525C10 Offset: 0x524E10 VA: 0x180525C10 Slot: 5
	public void Set(ref Nullable<LogPlayerReviveOptions> other) { }

	// RVA: 0x525BB0 Offset: 0x524DB0 VA: 0x180525BB0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.AntiCheatCommon
public struct LogPlayerSpawnOptions // TypeDefIndex: 10072
{
	// Fields
	[CompilerGenerated]
	private IntPtr <SpawnedPlayerHandle>k__BackingField; // 0x0
	[CompilerGenerated]
	private uint <TeamId>k__BackingField; // 0x8
	[CompilerGenerated]
	private uint <CharacterId>k__BackingField; // 0xC

	// Properties
	public IntPtr SpawnedPlayerHandle { get; set; }
	public uint TeamId { get; set; }
	public uint CharacterId { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public IntPtr get_SpawnedPlayerHandle() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_SpawnedPlayerHandle(IntPtr value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3F5510 Offset: 0x3F4710 VA: 0x1803F5510
	public uint get_TeamId() { }

	[CompilerGenerated]
	// RVA: 0x3F5520 Offset: 0x3F4720 VA: 0x1803F5520
	public void set_TeamId(uint value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x438080 Offset: 0x437280 VA: 0x180438080
	public uint get_CharacterId() { }

	[CompilerGenerated]
	// RVA: 0x438090 Offset: 0x437290 VA: 0x180438090
	public void set_CharacterId(uint value) { }
}

// Namespace: Epic.OnlineServices.AntiCheatCommon
internal struct LogPlayerSpawnOptionsInternal : ISettable<LogPlayerSpawnOptions>, IDisposable // TypeDefIndex: 10073
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_SpawnedPlayerHandle; // 0x8
	private uint m_TeamId; // 0x10
	private uint m_CharacterId; // 0x14

	// Properties
	public IntPtr SpawnedPlayerHandle { set; }
	public uint TeamId { set; }
	public uint CharacterId { set; }

	// Methods

	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_SpawnedPlayerHandle(IntPtr value) { }

	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_TeamId(uint value) { }

	// RVA: 0x426530 Offset: 0x425730 VA: 0x180426530
	public void set_CharacterId(uint value) { }

	// RVA: 0x438210 Offset: 0x437410 VA: 0x180438210 Slot: 4
	public void Set(ref LogPlayerSpawnOptions other) { }

	// RVA: 0x525CF0 Offset: 0x524EF0 VA: 0x180525CF0 Slot: 5
	public void Set(ref Nullable<LogPlayerSpawnOptions> other) { }

	// RVA: 0x525CA0 Offset: 0x524EA0 VA: 0x180525CA0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.AntiCheatCommon
public struct LogPlayerTakeDamageOptions // TypeDefIndex: 10074
{
	// Fields
	[CompilerGenerated]
	private IntPtr <VictimPlayerHandle>k__BackingField; // 0x0
	[CompilerGenerated]
	private Nullable<Vec3f> <VictimPlayerPosition>k__BackingField; // 0x8
	[CompilerGenerated]
	private Nullable<Quat> <VictimPlayerViewRotation>k__BackingField; // 0x18
	[CompilerGenerated]
	private IntPtr <AttackerPlayerHandle>k__BackingField; // 0x30
	[CompilerGenerated]
	private Nullable<Vec3f> <AttackerPlayerPosition>k__BackingField; // 0x38
	[CompilerGenerated]
	private Nullable<Quat> <AttackerPlayerViewRotation>k__BackingField; // 0x48
	[CompilerGenerated]
	private bool <IsHitscanAttack>k__BackingField; // 0x5C
	[CompilerGenerated]
	private bool <HasLineOfSight>k__BackingField; // 0x5D
	[CompilerGenerated]
	private bool <IsCriticalHit>k__BackingField; // 0x5E
	[CompilerGenerated]
	private uint <HitBoneId_DEPRECATED>k__BackingField; // 0x60
	[CompilerGenerated]
	private float <DamageTaken>k__BackingField; // 0x64
	[CompilerGenerated]
	private float <HealthRemaining>k__BackingField; // 0x68
	[CompilerGenerated]
	private AntiCheatCommonPlayerTakeDamageSource <DamageSource>k__BackingField; // 0x6C
	[CompilerGenerated]
	private AntiCheatCommonPlayerTakeDamageType <DamageType>k__BackingField; // 0x70
	[CompilerGenerated]
	private AntiCheatCommonPlayerTakeDamageResult <DamageResult>k__BackingField; // 0x74
	[CompilerGenerated]
	private Nullable<LogPlayerUseWeaponData> <PlayerUseWeaponData>k__BackingField; // 0x78
	[CompilerGenerated]
	private uint <TimeSincePlayerUseWeaponMs>k__BackingField; // 0xB8
	[CompilerGenerated]
	private Nullable<Vec3f> <DamagePosition>k__BackingField; // 0xBC
	[CompilerGenerated]
	private Nullable<Vec3f> <AttackerPlayerViewPosition>k__BackingField; // 0xCC

	// Properties
	public IntPtr VictimPlayerHandle { get; set; }
	public Nullable<Vec3f> VictimPlayerPosition { get; set; }
	public Nullable<Quat> VictimPlayerViewRotation { get; set; }
	public IntPtr AttackerPlayerHandle { get; set; }
	public Nullable<Vec3f> AttackerPlayerPosition { get; set; }
	public Nullable<Quat> AttackerPlayerViewRotation { get; set; }
	public bool IsHitscanAttack { get; set; }
	public bool HasLineOfSight { get; set; }
	public bool IsCriticalHit { get; set; }
	internal uint HitBoneId_DEPRECATED { get; set; }
	public float DamageTaken { get; set; }
	public float HealthRemaining { get; set; }
	public AntiCheatCommonPlayerTakeDamageSource DamageSource { get; set; }
	public AntiCheatCommonPlayerTakeDamageType DamageType { get; set; }
	public AntiCheatCommonPlayerTakeDamageResult DamageResult { get; set; }
	public Nullable<LogPlayerUseWeaponData> PlayerUseWeaponData { get; set; }
	public uint TimeSincePlayerUseWeaponMs { get; set; }
	public Nullable<Vec3f> DamagePosition { get; set; }
	public Nullable<Vec3f> AttackerPlayerViewPosition { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public IntPtr get_VictimPlayerHandle() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_VictimPlayerHandle(IntPtr value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x42C4A0 Offset: 0x42B6A0 VA: 0x18042C4A0
	public Nullable<Vec3f> get_VictimPlayerPosition() { }

	[CompilerGenerated]
	// RVA: 0x42C4B0 Offset: 0x42B6B0 VA: 0x18042C4B0
	public void set_VictimPlayerPosition(Nullable<Vec3f> value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x492960 Offset: 0x491B60 VA: 0x180492960
	public Nullable<Quat> get_VictimPlayerViewRotation() { }

	[CompilerGenerated]
	// RVA: 0x492980 Offset: 0x491B80 VA: 0x180492980
	public void set_VictimPlayerViewRotation(Nullable<Quat> value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public IntPtr get_AttackerPlayerHandle() { }

	[CompilerGenerated]
	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	public void set_AttackerPlayerHandle(IntPtr value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x526C40 Offset: 0x525E40 VA: 0x180526C40
	public Nullable<Vec3f> get_AttackerPlayerPosition() { }

	[CompilerGenerated]
	// RVA: 0x526D50 Offset: 0x525F50 VA: 0x180526D50
	public void set_AttackerPlayerPosition(Nullable<Vec3f> value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x526C60 Offset: 0x525E60 VA: 0x180526C60
	public Nullable<Quat> get_AttackerPlayerViewRotation() { }

	[CompilerGenerated]
	// RVA: 0x526D70 Offset: 0x525F70 VA: 0x180526D70
	public void set_AttackerPlayerViewRotation(Nullable<Quat> value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x526D00 Offset: 0x525F00 VA: 0x180526D00
	public bool get_IsHitscanAttack() { }

	[CompilerGenerated]
	// RVA: 0x526E00 Offset: 0x526000 VA: 0x180526E00
	public void set_IsHitscanAttack(bool value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x526CD0 Offset: 0x525ED0 VA: 0x180526CD0
	public bool get_HasLineOfSight() { }

	[CompilerGenerated]
	// RVA: 0x526DD0 Offset: 0x525FD0 VA: 0x180526DD0
	public void set_HasLineOfSight(bool value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x526CF0 Offset: 0x525EF0 VA: 0x180526CF0
	public bool get_IsCriticalHit() { }

	[CompilerGenerated]
	// RVA: 0x526DF0 Offset: 0x525FF0 VA: 0x180526DF0
	public void set_IsCriticalHit(bool value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x42D890 Offset: 0x42CA90 VA: 0x18042D890
	internal uint get_HitBoneId_DEPRECATED() { }

	[CompilerGenerated]
	// RVA: 0x42D900 Offset: 0x42CB00 VA: 0x18042D900
	internal void set_HitBoneId_DEPRECATED(uint value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x526CB0 Offset: 0x525EB0 VA: 0x180526CB0
	public float get_DamageTaken() { }

	[CompilerGenerated]
	// RVA: 0x526DB0 Offset: 0x525FB0 VA: 0x180526DB0
	public void set_DamageTaken(float value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x526CE0 Offset: 0x525EE0 VA: 0x180526CE0
	public float get_HealthRemaining() { }

	[CompilerGenerated]
	// RVA: 0x526DE0 Offset: 0x525FE0 VA: 0x180526DE0
	public void set_HealthRemaining(float value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x526CA0 Offset: 0x525EA0 VA: 0x180526CA0
	public AntiCheatCommonPlayerTakeDamageSource get_DamageSource() { }

	[CompilerGenerated]
	// RVA: 0x526DA0 Offset: 0x525FA0 VA: 0x180526DA0
	public void set_DamageSource(AntiCheatCommonPlayerTakeDamageSource value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x526CC0 Offset: 0x525EC0 VA: 0x180526CC0
	public AntiCheatCommonPlayerTakeDamageType get_DamageType() { }

	[CompilerGenerated]
	// RVA: 0x526DC0 Offset: 0x525FC0 VA: 0x180526DC0
	public void set_DamageType(AntiCheatCommonPlayerTakeDamageType value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x526C90 Offset: 0x525E90 VA: 0x180526C90
	public AntiCheatCommonPlayerTakeDamageResult get_DamageResult() { }

	[CompilerGenerated]
	// RVA: 0x526D90 Offset: 0x525F90 VA: 0x180526D90
	public void set_DamageResult(AntiCheatCommonPlayerTakeDamageResult value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x526D10 Offset: 0x525F10 VA: 0x180526D10
	public Nullable<LogPlayerUseWeaponData> get_PlayerUseWeaponData() { }

	[CompilerGenerated]
	// RVA: 0x526E10 Offset: 0x526010 VA: 0x180526E10
	public void set_PlayerUseWeaponData(Nullable<LogPlayerUseWeaponData> value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x526D40 Offset: 0x525F40 VA: 0x180526D40
	public uint get_TimeSincePlayerUseWeaponMs() { }

	[CompilerGenerated]
	// RVA: 0x526E40 Offset: 0x526040 VA: 0x180526E40
	public void set_TimeSincePlayerUseWeaponMs(uint value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x526C80 Offset: 0x525E80 VA: 0x180526C80
	public Nullable<Vec3f> get_DamagePosition() { }

	[CompilerGenerated]
	// RVA: 0x526D80 Offset: 0x525F80 VA: 0x180526D80
	public void set_DamagePosition(Nullable<Vec3f> value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x526C50 Offset: 0x525E50 VA: 0x180526C50
	public Nullable<Vec3f> get_AttackerPlayerViewPosition() { }

	[CompilerGenerated]
	// RVA: 0x526D60 Offset: 0x525F60 VA: 0x180526D60
	public void set_AttackerPlayerViewPosition(Nullable<Vec3f> value) { }
}

// Namespace: Epic.OnlineServices.AntiCheatCommon
internal struct LogPlayerTakeDamageOptionsInternal : ISettable<LogPlayerTakeDamageOptions>, IDisposable // TypeDefIndex: 10075
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_VictimPlayerHandle; // 0x8
	private IntPtr m_VictimPlayerPosition; // 0x10
	private IntPtr m_VictimPlayerViewRotation; // 0x18
	private IntPtr m_AttackerPlayerHandle; // 0x20
	private IntPtr m_AttackerPlayerPosition; // 0x28
	private IntPtr m_AttackerPlayerViewRotation; // 0x30
	private int m_IsHitscanAttack; // 0x38
	private int m_HasLineOfSight; // 0x3C
	private int m_IsCriticalHit; // 0x40
	private uint m_HitBoneId_DEPRECATED; // 0x44
	private float m_DamageTaken; // 0x48
	private float m_HealthRemaining; // 0x4C
	private AntiCheatCommonPlayerTakeDamageSource m_DamageSource; // 0x50
	private AntiCheatCommonPlayerTakeDamageType m_DamageType; // 0x54
	private AntiCheatCommonPlayerTakeDamageResult m_DamageResult; // 0x58
	private IntPtr m_PlayerUseWeaponData; // 0x60
	private uint m_TimeSincePlayerUseWeaponMs; // 0x68
	private IntPtr m_DamagePosition; // 0x70
	private IntPtr m_AttackerPlayerViewPosition; // 0x78

	// Properties
	public IntPtr VictimPlayerHandle { set; }
	public Nullable<Vec3f> VictimPlayerPosition { set; }
	public Nullable<Quat> VictimPlayerViewRotation { set; }
	public IntPtr AttackerPlayerHandle { set; }
	public Nullable<Vec3f> AttackerPlayerPosition { set; }
	public Nullable<Quat> AttackerPlayerViewRotation { set; }
	public bool IsHitscanAttack { set; }
	public bool HasLineOfSight { set; }
	public bool IsCriticalHit { set; }
	public uint HitBoneId_DEPRECATED { set; }
	public float DamageTaken { set; }
	public float HealthRemaining { set; }
	public AntiCheatCommonPlayerTakeDamageSource DamageSource { set; }
	public AntiCheatCommonPlayerTakeDamageType DamageType { set; }
	public AntiCheatCommonPlayerTakeDamageResult DamageResult { set; }
	public Nullable<LogPlayerUseWeaponData> PlayerUseWeaponData { set; }
	public uint TimeSincePlayerUseWeaponMs { set; }
	public Nullable<Vec3f> DamagePosition { set; }
	public Nullable<Vec3f> AttackerPlayerViewPosition { set; }

	// Methods

	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_VictimPlayerHandle(IntPtr value) { }

	// RVA: 0x526B60 Offset: 0x525D60 VA: 0x180526B60
	public void set_VictimPlayerPosition(Nullable<Vec3f> value) { }

	// RVA: 0x526BD0 Offset: 0x525DD0 VA: 0x180526BD0
	public void set_VictimPlayerViewRotation(Nullable<Quat> value) { }

	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_AttackerPlayerHandle(IntPtr value) { }

	// RVA: 0x5267F0 Offset: 0x5259F0 VA: 0x1805267F0
	public void set_AttackerPlayerPosition(Nullable<Vec3f> value) { }

	// RVA: 0x5268D0 Offset: 0x525AD0 VA: 0x1805268D0
	public void set_AttackerPlayerViewRotation(Nullable<Quat> value) { }

	// RVA: 0x526A90 Offset: 0x525C90 VA: 0x180526A90
	public void set_IsHitscanAttack(bool value) { }

	// RVA: 0x5269C0 Offset: 0x525BC0 VA: 0x1805269C0
	public void set_HasLineOfSight(bool value) { }

	// RVA: 0x526A30 Offset: 0x525C30 VA: 0x180526A30
	public void set_IsCriticalHit(bool value) { }

	// RVA: 0x4AB2C0 Offset: 0x4AA4C0 VA: 0x1804AB2C0
	public void set_HitBoneId_DEPRECATED(uint value) { }

	// RVA: 0x5269B0 Offset: 0x525BB0 VA: 0x1805269B0
	public void set_DamageTaken(float value) { }

	// RVA: 0x526A20 Offset: 0x525C20 VA: 0x180526A20
	public void set_HealthRemaining(float value) { }

	// RVA: 0x430630 Offset: 0x42F830 VA: 0x180430630
	public void set_DamageSource(AntiCheatCommonPlayerTakeDamageSource value) { }

	// RVA: 0x4D1A80 Offset: 0x4D0C80 VA: 0x1804D1A80
	public void set_DamageType(AntiCheatCommonPlayerTakeDamageType value) { }

	// RVA: 0x4EDEA0 Offset: 0x4ED0A0 VA: 0x1804EDEA0
	public void set_DamageResult(AntiCheatCommonPlayerTakeDamageResult value) { }

	// RVA: 0x526AF0 Offset: 0x525CF0 VA: 0x180526AF0
	public void set_PlayerUseWeaponData(Nullable<LogPlayerUseWeaponData> value) { }

	// RVA: 0x42D810 Offset: 0x42CA10 VA: 0x18042D810
	public void set_TimeSincePlayerUseWeaponMs(uint value) { }

	// RVA: 0x526940 Offset: 0x525B40 VA: 0x180526940
	public void set_DamagePosition(Nullable<Vec3f> value) { }

	// RVA: 0x526860 Offset: 0x525A60 VA: 0x180526860
	public void set_AttackerPlayerViewPosition(Nullable<Vec3f> value) { }

	// RVA: 0x525E50 Offset: 0x525050 VA: 0x180525E50 Slot: 4
	public void Set(ref LogPlayerTakeDamageOptions other) { }

	// RVA: 0x526250 Offset: 0x525450 VA: 0x180526250 Slot: 5
	public void Set(ref Nullable<LogPlayerTakeDamageOptions> other) { }

	// RVA: 0x525DA0 Offset: 0x524FA0 VA: 0x180525DA0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.AntiCheatCommon
public struct LogPlayerTickOptions // TypeDefIndex: 10076
{
	// Fields
	[CompilerGenerated]
	private IntPtr <PlayerHandle>k__BackingField; // 0x0
	[CompilerGenerated]
	private Nullable<Vec3f> <PlayerPosition>k__BackingField; // 0x8
	[CompilerGenerated]
	private Nullable<Quat> <PlayerViewRotation>k__BackingField; // 0x18
	[CompilerGenerated]
	private bool <IsPlayerViewZoomed>k__BackingField; // 0x2C
	[CompilerGenerated]
	private float <PlayerHealth>k__BackingField; // 0x30
	[CompilerGenerated]
	private AntiCheatCommonPlayerMovementState <PlayerMovementState>k__BackingField; // 0x34
	[CompilerGenerated]
	private Nullable<Vec3f> <PlayerViewPosition>k__BackingField; // 0x38

	// Properties
	public IntPtr PlayerHandle { get; set; }
	public Nullable<Vec3f> PlayerPosition { get; set; }
	public Nullable<Quat> PlayerViewRotation { get; set; }
	public bool IsPlayerViewZoomed { get; set; }
	public float PlayerHealth { get; set; }
	public AntiCheatCommonPlayerMovementState PlayerMovementState { get; set; }
	public Nullable<Vec3f> PlayerViewPosition { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public IntPtr get_PlayerHandle() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_PlayerHandle(IntPtr value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x42C4A0 Offset: 0x42B6A0 VA: 0x18042C4A0
	public Nullable<Vec3f> get_PlayerPosition() { }

	[CompilerGenerated]
	// RVA: 0x42C4B0 Offset: 0x42B6B0 VA: 0x18042C4B0
	public void set_PlayerPosition(Nullable<Vec3f> value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x492960 Offset: 0x491B60 VA: 0x180492960
	public Nullable<Quat> get_PlayerViewRotation() { }

	[CompilerGenerated]
	// RVA: 0x492980 Offset: 0x491B80 VA: 0x180492980
	public void set_PlayerViewRotation(Nullable<Quat> value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x48DA50 Offset: 0x48CC50 VA: 0x18048DA50
	public bool get_IsPlayerViewZoomed() { }

	[CompilerGenerated]
	// RVA: 0x48DA70 Offset: 0x48CC70 VA: 0x18048DA70
	public void set_IsPlayerViewZoomed(bool value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x527470 Offset: 0x526670 VA: 0x180527470
	public float get_PlayerHealth() { }

	[CompilerGenerated]
	// RVA: 0x499010 Offset: 0x498210 VA: 0x180499010
	public void set_PlayerHealth(float value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x527480 Offset: 0x526680 VA: 0x180527480
	public AntiCheatCommonPlayerMovementState get_PlayerMovementState() { }

	[CompilerGenerated]
	// RVA: 0x4D19A0 Offset: 0x4D0BA0 VA: 0x1804D19A0
	public void set_PlayerMovementState(AntiCheatCommonPlayerMovementState value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x526C40 Offset: 0x525E40 VA: 0x180526C40
	public Nullable<Vec3f> get_PlayerViewPosition() { }

	[CompilerGenerated]
	// RVA: 0x526D50 Offset: 0x525F50 VA: 0x180526D50
	public void set_PlayerViewPosition(Nullable<Vec3f> value) { }
}

// Namespace: Epic.OnlineServices.AntiCheatCommon
internal struct LogPlayerTickOptionsInternal : ISettable<LogPlayerTickOptions>, IDisposable // TypeDefIndex: 10077
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_PlayerHandle; // 0x8
	private IntPtr m_PlayerPosition; // 0x10
	private IntPtr m_PlayerViewRotation; // 0x18
	private int m_IsPlayerViewZoomed; // 0x20
	private float m_PlayerHealth; // 0x24
	private AntiCheatCommonPlayerMovementState m_PlayerMovementState; // 0x28
	private IntPtr m_PlayerViewPosition; // 0x30

	// Properties
	public IntPtr PlayerHandle { set; }
	public Nullable<Vec3f> PlayerPosition { set; }
	public Nullable<Quat> PlayerViewRotation { set; }
	public bool IsPlayerViewZoomed { set; }
	public float PlayerHealth { set; }
	public AntiCheatCommonPlayerMovementState PlayerMovementState { set; }
	public Nullable<Vec3f> PlayerViewPosition { set; }

	// Methods

	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_PlayerHandle(IntPtr value) { }

	// RVA: 0x527320 Offset: 0x526520 VA: 0x180527320
	public void set_PlayerPosition(Nullable<Vec3f> value) { }

	// RVA: 0x527400 Offset: 0x526600 VA: 0x180527400
	public void set_PlayerViewRotation(Nullable<Quat> value) { }

	// RVA: 0x5272C0 Offset: 0x5264C0 VA: 0x1805272C0
	public void set_IsPlayerViewZoomed(bool value) { }

	// RVA: 0x499000 Offset: 0x498200 VA: 0x180499000
	public void set_PlayerHealth(float value) { }

	// RVA: 0x3DA200 Offset: 0x3D9400 VA: 0x1803DA200
	public void set_PlayerMovementState(AntiCheatCommonPlayerMovementState value) { }

	// RVA: 0x527390 Offset: 0x526590 VA: 0x180527390
	public void set_PlayerViewPosition(Nullable<Vec3f> value) { }

	// RVA: 0x526EC0 Offset: 0x5260C0 VA: 0x180526EC0 Slot: 4
	public void Set(ref LogPlayerTickOptions other) { }

	// RVA: 0x527060 Offset: 0x526260 VA: 0x180527060 Slot: 5
	public void Set(ref Nullable<LogPlayerTickOptions> other) { }

	// RVA: 0x526E50 Offset: 0x526050 VA: 0x180526E50 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.AntiCheatCommon
public struct LogPlayerUseAbilityOptions // TypeDefIndex: 10078
{
	// Fields
	[CompilerGenerated]
	private IntPtr <PlayerHandle>k__BackingField; // 0x0
	[CompilerGenerated]
	private uint <AbilityId>k__BackingField; // 0x8
	[CompilerGenerated]
	private uint <AbilityDurationMs>k__BackingField; // 0xC
	[CompilerGenerated]
	private uint <AbilityCooldownMs>k__BackingField; // 0x10

	// Properties
	public IntPtr PlayerHandle { get; set; }
	public uint AbilityId { get; set; }
	public uint AbilityDurationMs { get; set; }
	public uint AbilityCooldownMs { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public IntPtr get_PlayerHandle() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_PlayerHandle(IntPtr value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3F5510 Offset: 0x3F4710 VA: 0x1803F5510
	public uint get_AbilityId() { }

	[CompilerGenerated]
	// RVA: 0x3F5520 Offset: 0x3F4720 VA: 0x1803F5520
	public void set_AbilityId(uint value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x438080 Offset: 0x437280 VA: 0x180438080
	public uint get_AbilityDurationMs() { }

	[CompilerGenerated]
	// RVA: 0x438090 Offset: 0x437290 VA: 0x180438090
	public void set_AbilityDurationMs(uint value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public uint get_AbilityCooldownMs() { }

	[CompilerGenerated]
	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_AbilityCooldownMs(uint value) { }
}

// Namespace: Epic.OnlineServices.AntiCheatCommon
internal struct LogPlayerUseAbilityOptionsInternal : ISettable<LogPlayerUseAbilityOptions>, IDisposable // TypeDefIndex: 10079
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_PlayerHandle; // 0x8
	private uint m_AbilityId; // 0x10
	private uint m_AbilityDurationMs; // 0x14
	private uint m_AbilityCooldownMs; // 0x18

	// Properties
	public IntPtr PlayerHandle { set; }
	public uint AbilityId { set; }
	public uint AbilityDurationMs { set; }
	public uint AbilityCooldownMs { set; }

	// Methods

	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_PlayerHandle(IntPtr value) { }

	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_AbilityId(uint value) { }

	// RVA: 0x426530 Offset: 0x425730 VA: 0x180426530
	public void set_AbilityDurationMs(uint value) { }

	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	public void set_AbilityCooldownMs(uint value) { }

	// RVA: 0x5274E0 Offset: 0x5266E0 VA: 0x1805274E0 Slot: 4
	public void Set(ref LogPlayerUseAbilityOptions other) { }

	// RVA: 0x527500 Offset: 0x526700 VA: 0x180527500 Slot: 5
	public void Set(ref Nullable<LogPlayerUseAbilityOptions> other) { }

	// RVA: 0x527490 Offset: 0x526690 VA: 0x180527490 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.AntiCheatCommon
public struct LogPlayerUseWeaponData // TypeDefIndex: 10080
{
	// Fields
	[CompilerGenerated]
	private IntPtr <PlayerHandle>k__BackingField; // 0x0
	[CompilerGenerated]
	private Nullable<Vec3f> <PlayerPosition>k__BackingField; // 0x8
	[CompilerGenerated]
	private Nullable<Quat> <PlayerViewRotation>k__BackingField; // 0x18
	[CompilerGenerated]
	private bool <IsPlayerViewZoomed>k__BackingField; // 0x2C
	[CompilerGenerated]
	private bool <IsMeleeAttack>k__BackingField; // 0x2D
	[CompilerGenerated]
	private Utf8String <WeaponName>k__BackingField; // 0x30

	// Properties
	public IntPtr PlayerHandle { get; set; }
	public Nullable<Vec3f> PlayerPosition { get; set; }
	public Nullable<Quat> PlayerViewRotation { get; set; }
	public bool IsPlayerViewZoomed { get; set; }
	public bool IsMeleeAttack { get; set; }
	public Utf8String WeaponName { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public IntPtr get_PlayerHandle() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_PlayerHandle(IntPtr value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x42C4A0 Offset: 0x42B6A0 VA: 0x18042C4A0
	public Nullable<Vec3f> get_PlayerPosition() { }

	[CompilerGenerated]
	// RVA: 0x42C4B0 Offset: 0x42B6B0 VA: 0x18042C4B0
	public void set_PlayerPosition(Nullable<Vec3f> value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x492960 Offset: 0x491B60 VA: 0x180492960
	public Nullable<Quat> get_PlayerViewRotation() { }

	[CompilerGenerated]
	// RVA: 0x492980 Offset: 0x491B80 VA: 0x180492980
	public void set_PlayerViewRotation(Nullable<Quat> value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x48DA50 Offset: 0x48CC50 VA: 0x18048DA50
	public bool get_IsPlayerViewZoomed() { }

	[CompilerGenerated]
	// RVA: 0x48DA70 Offset: 0x48CC70 VA: 0x18048DA70
	public void set_IsPlayerViewZoomed(bool value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x48DA60 Offset: 0x48CC60 VA: 0x18048DA60
	public bool get_IsMeleeAttack() { }

	[CompilerGenerated]
	// RVA: 0x48DA80 Offset: 0x48CC80 VA: 0x18048DA80
	public void set_IsMeleeAttack(bool value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public Utf8String get_WeaponName() { }

	[CompilerGenerated]
	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	public void set_WeaponName(Utf8String value) { }

	// RVA: 0x527EC0 Offset: 0x5270C0 VA: 0x180527EC0
	internal void Set(ref LogPlayerUseWeaponDataInternal other) { }
}

// Namespace: Epic.OnlineServices.AntiCheatCommon
internal struct LogPlayerUseWeaponDataInternal : IGettable<LogPlayerUseWeaponData>, ISettable<LogPlayerUseWeaponData>, IDisposable // TypeDefIndex: 10081
{
	// Fields
	private IntPtr m_PlayerHandle; // 0x0
	private IntPtr m_PlayerPosition; // 0x8
	private IntPtr m_PlayerViewRotation; // 0x10
	private int m_IsPlayerViewZoomed; // 0x18
	private int m_IsMeleeAttack; // 0x1C
	private IntPtr m_WeaponName; // 0x20

	// Properties
	public IntPtr PlayerHandle { get; set; }
	public Nullable<Vec3f> PlayerPosition { get; set; }
	public Nullable<Quat> PlayerViewRotation { get; set; }
	public bool IsPlayerViewZoomed { get; set; }
	public bool IsMeleeAttack { get; set; }
	public Utf8String WeaponName { get; set; }

	// Methods

	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public IntPtr get_PlayerHandle() { }

	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_PlayerHandle(IntPtr value) { }

	// RVA: 0x527B50 Offset: 0x526D50 VA: 0x180527B50
	public Nullable<Vec3f> get_PlayerPosition() { }

	// RVA: 0x527D80 Offset: 0x526F80 VA: 0x180527D80
	public void set_PlayerPosition(Nullable<Vec3f> value) { }

	// RVA: 0x527BD0 Offset: 0x526DD0 VA: 0x180527BD0
	public Nullable<Quat> get_PlayerViewRotation() { }

	// RVA: 0x527DF0 Offset: 0x526FF0 VA: 0x180527DF0
	public void set_PlayerViewRotation(Nullable<Quat> value) { }

	// RVA: 0x527AF0 Offset: 0x526CF0 VA: 0x180527AF0
	public bool get_IsPlayerViewZoomed() { }

	// RVA: 0x527D20 Offset: 0x526F20 VA: 0x180527D20
	public void set_IsPlayerViewZoomed(bool value) { }

	// RVA: 0x527A90 Offset: 0x526C90 VA: 0x180527A90
	public bool get_IsMeleeAttack() { }

	// RVA: 0x527CC0 Offset: 0x526EC0 VA: 0x180527CC0
	public void set_IsMeleeAttack(bool value) { }

	// RVA: 0x527C50 Offset: 0x526E50 VA: 0x180527C50
	public Utf8String get_WeaponName() { }

	// RVA: 0x527E60 Offset: 0x527060 VA: 0x180527E60
	public void set_WeaponName(Utf8String value) { }

	// RVA: 0x527670 Offset: 0x526870 VA: 0x180527670 Slot: 5
	public void Set(ref LogPlayerUseWeaponData other) { }

	// RVA: 0x527830 Offset: 0x526A30 VA: 0x180527830 Slot: 6
	public void Set(ref Nullable<LogPlayerUseWeaponData> other) { }

	// RVA: 0x5275D0 Offset: 0x5267D0 VA: 0x1805275D0 Slot: 7
	public void Dispose() { }

	// RVA: 0x527640 Offset: 0x526840 VA: 0x180527640 Slot: 4
	public void Get(out LogPlayerUseWeaponData output) { }
}

// Namespace: Epic.OnlineServices.AntiCheatCommon
public struct LogPlayerUseWeaponOptions // TypeDefIndex: 10082
{
	// Fields
	[CompilerGenerated]
	private Nullable<LogPlayerUseWeaponData> <UseWeaponData>k__BackingField; // 0x0

	// Properties
	public Nullable<LogPlayerUseWeaponData> UseWeaponData { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x4A13D0 Offset: 0x4A05D0 VA: 0x1804A13D0
	public Nullable<LogPlayerUseWeaponData> get_UseWeaponData() { }

	[CompilerGenerated]
	// RVA: 0x4A1400 Offset: 0x4A0600 VA: 0x1804A1400
	public void set_UseWeaponData(Nullable<LogPlayerUseWeaponData> value) { }
}

// Namespace: Epic.OnlineServices.AntiCheatCommon
internal struct LogPlayerUseWeaponOptionsInternal : ISettable<LogPlayerUseWeaponOptions>, IDisposable // TypeDefIndex: 10083
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_UseWeaponData; // 0x8

	// Properties
	public Nullable<LogPlayerUseWeaponData> UseWeaponData { set; }

	// Methods

	// RVA: 0x528290 Offset: 0x527490 VA: 0x180528290
	public void set_UseWeaponData(Nullable<LogPlayerUseWeaponData> value) { }

	// RVA: 0x528110 Offset: 0x527310 VA: 0x180528110 Slot: 4
	public void Set(ref LogPlayerUseWeaponOptions other) { }

	// RVA: 0x5281A0 Offset: 0x5273A0 VA: 0x1805281A0 Slot: 5
	public void Set(ref Nullable<LogPlayerUseWeaponOptions> other) { }

	// RVA: 0x5280C0 Offset: 0x5272C0 VA: 0x1805280C0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.AntiCheatCommon
public struct OnClientActionRequiredCallbackInfo : ICallbackInfo // TypeDefIndex: 10084
{
	// Fields
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x0
	[CompilerGenerated]
	private IntPtr <ClientHandle>k__BackingField; // 0x8
	[CompilerGenerated]
	private AntiCheatCommonClientAction <ClientAction>k__BackingField; // 0x10
	[CompilerGenerated]
	private AntiCheatCommonClientActionReason <ActionReasonCode>k__BackingField; // 0x14
	[CompilerGenerated]
	private Utf8String <ActionReasonDetailsString>k__BackingField; // 0x18

	// Properties
	public object ClientData { get; set; }
	public IntPtr ClientHandle { get; set; }
	public AntiCheatCommonClientAction ClientAction { get; set; }
	public AntiCheatCommonClientActionReason ActionReasonCode { get; set; }
	public Utf8String ActionReasonDetailsString { get; set; }

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
	public IntPtr get_ClientHandle() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_ClientHandle(IntPtr value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public AntiCheatCommonClientAction get_ClientAction() { }

	[CompilerGenerated]
	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_ClientAction(AntiCheatCommonClientAction value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500
	public AntiCheatCommonClientActionReason get_ActionReasonCode() { }

	[CompilerGenerated]
	// RVA: 0x426530 Offset: 0x425730 VA: 0x180426530
	public void set_ActionReasonCode(AntiCheatCommonClientActionReason value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public Utf8String get_ActionReasonDetailsString() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_ActionReasonDetailsString(Utf8String value) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x52A210 Offset: 0x529410 VA: 0x18052A210
	internal void Set(ref OnClientActionRequiredCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.AntiCheatCommon
internal struct OnClientActionRequiredCallbackInfoInternal : ICallbackInfoInternal, IGettable<OnClientActionRequiredCallbackInfo>, ISettable<OnClientActionRequiredCallbackInfo>, IDisposable // TypeDefIndex: 10085
{
	// Fields
	private IntPtr m_ClientData; // 0x0
	private IntPtr m_ClientHandle; // 0x8
	private AntiCheatCommonClientAction m_ClientAction; // 0x10
	private AntiCheatCommonClientActionReason m_ActionReasonCode; // 0x14
	private IntPtr m_ActionReasonDetailsString; // 0x18

	// Properties
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public IntPtr ClientHandle { get; set; }
	public AntiCheatCommonClientAction ClientAction { get; set; }
	public AntiCheatCommonClientActionReason ActionReasonCode { get; set; }
	public Utf8String ActionReasonDetailsString { get; set; }

	// Methods

	// RVA: 0x52A0E0 Offset: 0x5292E0 VA: 0x18052A0E0
	public object get_ClientData() { }

	// RVA: 0x52A1B0 Offset: 0x5293B0 VA: 0x18052A1B0
	public void set_ClientData(object value) { }

	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public IntPtr get_ClientHandle() { }

	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_ClientHandle(IntPtr value) { }

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public AntiCheatCommonClientAction get_ClientAction() { }

	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_ClientAction(AntiCheatCommonClientAction value) { }

	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500
	public AntiCheatCommonClientActionReason get_ActionReasonCode() { }

	// RVA: 0x426530 Offset: 0x425730 VA: 0x180426530
	public void set_ActionReasonCode(AntiCheatCommonClientActionReason value) { }

	// RVA: 0x52A070 Offset: 0x529270 VA: 0x18052A070
	public Utf8String get_ActionReasonDetailsString() { }

	// RVA: 0x52A150 Offset: 0x529350 VA: 0x18052A150
	public void set_ActionReasonDetailsString(Utf8String value) { }

	// RVA: 0x529E60 Offset: 0x529060 VA: 0x180529E60 Slot: 6
	public void Set(ref OnClientActionRequiredCallbackInfo other) { }

	// RVA: 0x529F20 Offset: 0x529120 VA: 0x180529F20 Slot: 7
	public void Set(ref Nullable<OnClientActionRequiredCallbackInfo> other) { }

	// RVA: 0x529DE0 Offset: 0x528FE0 VA: 0x180529DE0 Slot: 8
	public void Dispose() { }

	// RVA: 0x529E40 Offset: 0x529040 VA: 0x180529E40 Slot: 5
	public void Get(out OnClientActionRequiredCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.AntiCheatCommon
public struct OnClientAuthStatusChangedCallbackInfo : ICallbackInfo // TypeDefIndex: 10086
{
	// Fields
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x0
	[CompilerGenerated]
	private IntPtr <ClientHandle>k__BackingField; // 0x8
	[CompilerGenerated]
	private AntiCheatCommonClientAuthStatus <ClientAuthStatus>k__BackingField; // 0x10

	// Properties
	public object ClientData { get; set; }
	public IntPtr ClientHandle { get; set; }
	public AntiCheatCommonClientAuthStatus ClientAuthStatus { get; set; }

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
	public IntPtr get_ClientHandle() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_ClientHandle(IntPtr value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public AntiCheatCommonClientAuthStatus get_ClientAuthStatus() { }

	[CompilerGenerated]
	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_ClientAuthStatus(AntiCheatCommonClientAuthStatus value) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x52A6D0 Offset: 0x5298D0 VA: 0x18052A6D0
	internal void Set(ref OnClientAuthStatusChangedCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.AntiCheatCommon
internal struct OnClientAuthStatusChangedCallbackInfoInternal : ICallbackInfoInternal, IGettable<OnClientAuthStatusChangedCallbackInfo>, ISettable<OnClientAuthStatusChangedCallbackInfo>, IDisposable // TypeDefIndex: 10087
{
	// Fields
	private IntPtr m_ClientData; // 0x0
	private IntPtr m_ClientHandle; // 0x8
	private AntiCheatCommonClientAuthStatus m_ClientAuthStatus; // 0x10

	// Properties
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public IntPtr ClientHandle { get; set; }
	public AntiCheatCommonClientAuthStatus ClientAuthStatus { get; set; }

	// Methods

	// RVA: 0x52A600 Offset: 0x529800 VA: 0x18052A600
	public object get_ClientData() { }

	// RVA: 0x52A670 Offset: 0x529870 VA: 0x18052A670
	public void set_ClientData(object value) { }

	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public IntPtr get_ClientHandle() { }

	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_ClientHandle(IntPtr value) { }

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public AntiCheatCommonClientAuthStatus get_ClientAuthStatus() { }

	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_ClientAuthStatus(AntiCheatCommonClientAuthStatus value) { }

	// RVA: 0x52A4A0 Offset: 0x5296A0 VA: 0x18052A4A0 Slot: 6
	public void Set(ref OnClientAuthStatusChangedCallbackInfo other) { }

	// RVA: 0x52A520 Offset: 0x529720 VA: 0x18052A520 Slot: 7
	public void Set(ref Nullable<OnClientAuthStatusChangedCallbackInfo> other) { }

	// RVA: 0x52A420 Offset: 0x529620 VA: 0x18052A420 Slot: 8
	public void Dispose() { }

	// RVA: 0x52A480 Offset: 0x529680 VA: 0x18052A480 Slot: 5
	public void Get(out OnClientAuthStatusChangedCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.AntiCheatCommon
public struct OnMessageToClientCallbackInfo : ICallbackInfo // TypeDefIndex: 10088
{
	// Fields
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x0
	[CompilerGenerated]
	private IntPtr <ClientHandle>k__BackingField; // 0x8
	[CompilerGenerated]
	private ArraySegment<byte> <MessageData>k__BackingField; // 0x10

	// Properties
	public object ClientData { get; set; }
	public IntPtr ClientHandle { get; set; }
	public ArraySegment<byte> MessageData { get; set; }

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
	public IntPtr get_ClientHandle() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_ClientHandle(IntPtr value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x482990 Offset: 0x481B90 VA: 0x180482990
	public ArraySegment<byte> get_MessageData() { }

	[CompilerGenerated]
	// RVA: 0x4829A0 Offset: 0x481BA0 VA: 0x1804829A0
	public void set_MessageData(ArraySegment<byte> value) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x52B260 Offset: 0x52A460 VA: 0x18052B260
	internal void Set(ref OnMessageToClientCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.AntiCheatCommon
internal struct OnMessageToClientCallbackInfoInternal : ICallbackInfoInternal, IGettable<OnMessageToClientCallbackInfo>, ISettable<OnMessageToClientCallbackInfo>, IDisposable // TypeDefIndex: 10089
{
	// Fields
	private IntPtr m_ClientData; // 0x0
	private IntPtr m_ClientHandle; // 0x8
	private IntPtr m_MessageData; // 0x10
	private uint m_MessageDataSizeBytes; // 0x18

	// Properties
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public IntPtr ClientHandle { get; set; }
	public ArraySegment<byte> MessageData { get; set; }

	// Methods

	// RVA: 0x52B0A0 Offset: 0x52A2A0 VA: 0x18052B0A0
	public object get_ClientData() { }

	// RVA: 0x52B190 Offset: 0x52A390 VA: 0x18052B190
	public void set_ClientData(object value) { }

	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public IntPtr get_ClientHandle() { }

	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_ClientHandle(IntPtr value) { }

	// RVA: 0x52B110 Offset: 0x52A310 VA: 0x18052B110
	public ArraySegment<byte> get_MessageData() { }

	// RVA: 0x52B1F0 Offset: 0x52A3F0 VA: 0x18052B1F0
	public void set_MessageData(ArraySegment<byte> value) { }

	// RVA: 0x52AFD0 Offset: 0x52A1D0 VA: 0x18052AFD0 Slot: 6
	public void Set(ref OnMessageToClientCallbackInfo other) { }

	// RVA: 0x52AEA0 Offset: 0x52A0A0 VA: 0x18052AEA0 Slot: 7
	public void Set(ref Nullable<OnMessageToClientCallbackInfo> other) { }

	// RVA: 0x52AE20 Offset: 0x52A020 VA: 0x18052AE20 Slot: 8
	public void Dispose() { }

	// RVA: 0x52AE80 Offset: 0x52A080 VA: 0x18052AE80 Slot: 5
	public void Get(out OnMessageToClientCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.AntiCheatCommon
public struct Quat // TypeDefIndex: 10090
{
	// Fields
	[CompilerGenerated]
	private float <w>k__BackingField; // 0x0
	[CompilerGenerated]
	private float <x>k__BackingField; // 0x4
	[CompilerGenerated]
	private float <y>k__BackingField; // 0x8
	[CompilerGenerated]
	private float <z>k__BackingField; // 0xC

	// Properties
	public float w { get; set; }
	public float x { get; set; }
	public float y { get; set; }
	public float z { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x439FA0 Offset: 0x4391A0 VA: 0x180439FA0
	public float get_w() { }

	[CompilerGenerated]
	// RVA: 0x439FD0 Offset: 0x4391D0 VA: 0x180439FD0
	public void set_w(float value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x439FB0 Offset: 0x4391B0 VA: 0x180439FB0
	public float get_x() { }

	[CompilerGenerated]
	// RVA: 0x439FE0 Offset: 0x4391E0 VA: 0x180439FE0
	public void set_x(float value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x439FC0 Offset: 0x4391C0 VA: 0x180439FC0
	public float get_y() { }

	[CompilerGenerated]
	// RVA: 0x439FF0 Offset: 0x4391F0 VA: 0x180439FF0
	public void set_y(float value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x52C5A0 Offset: 0x52B7A0 VA: 0x18052C5A0
	public float get_z() { }

	[CompilerGenerated]
	// RVA: 0x52C5B0 Offset: 0x52B7B0 VA: 0x18052C5B0
	public void set_z(float value) { }

	// RVA: 0x52C580 Offset: 0x52B780 VA: 0x18052C580
	internal void Set(ref QuatInternal other) { }
}

// Namespace: Epic.OnlineServices.AntiCheatCommon
internal struct QuatInternal : IGettable<Quat>, ISettable<Quat>, IDisposable // TypeDefIndex: 10091
{
	// Fields
	private float m_w; // 0x0
	private float m_x; // 0x4
	private float m_y; // 0x8
	private float m_z; // 0xC

	// Properties
	public float w { get; set; }
	public float x { get; set; }
	public float y { get; set; }
	public float z { get; set; }

	// Methods

	// RVA: 0x439FA0 Offset: 0x4391A0 VA: 0x180439FA0
	public float get_w() { }

	// RVA: 0x439FD0 Offset: 0x4391D0 VA: 0x180439FD0
	public void set_w(float value) { }

	// RVA: 0x439FB0 Offset: 0x4391B0 VA: 0x180439FB0
	public float get_x() { }

	// RVA: 0x439FE0 Offset: 0x4391E0 VA: 0x180439FE0
	public void set_x(float value) { }

	// RVA: 0x439FC0 Offset: 0x4391C0 VA: 0x180439FC0
	public float get_y() { }

	// RVA: 0x439FF0 Offset: 0x4391F0 VA: 0x180439FF0
	public void set_y(float value) { }

	// RVA: 0x52C5A0 Offset: 0x52B7A0 VA: 0x18052C5A0
	public float get_z() { }

	// RVA: 0x52C5B0 Offset: 0x52B7B0 VA: 0x18052C5B0
	public void set_z(float value) { }

	// RVA: 0x52C580 Offset: 0x52B780 VA: 0x18052C580 Slot: 5
	public void Set(ref Quat other) { }

	// RVA: 0x52C4B0 Offset: 0x52B6B0 VA: 0x18052C4B0 Slot: 6
	public void Set(ref Nullable<Quat> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 7
	public void Dispose() { }

	// RVA: 0x52C490 Offset: 0x52B690 VA: 0x18052C490 Slot: 4
	public void Get(out Quat output) { }
}

// Namespace: Epic.OnlineServices.AntiCheatCommon
public struct RegisterEventOptions // TypeDefIndex: 10092
{
	// Fields
	[CompilerGenerated]
	private uint <EventId>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <EventName>k__BackingField; // 0x8
	[CompilerGenerated]
	private AntiCheatCommonEventType <EventType>k__BackingField; // 0x10
	[CompilerGenerated]
	private RegisterEventParamDef[] <ParamDefs>k__BackingField; // 0x18

	// Properties
	public uint EventId { get; set; }
	public Utf8String EventName { get; set; }
	public AntiCheatCommonEventType EventType { get; set; }
	public RegisterEventParamDef[] ParamDefs { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public uint get_EventId() { }

	[CompilerGenerated]
	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_EventId(uint value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public Utf8String get_EventName() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_EventName(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public AntiCheatCommonEventType get_EventType() { }

	[CompilerGenerated]
	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_EventType(AntiCheatCommonEventType value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public RegisterEventParamDef[] get_ParamDefs() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_ParamDefs(RegisterEventParamDef[] value) { }
}

// Namespace: Epic.OnlineServices.AntiCheatCommon
internal struct RegisterEventOptionsInternal : ISettable<RegisterEventOptions>, IDisposable // TypeDefIndex: 10093
{
	// Fields
	private int m_ApiVersion; // 0x0
	private uint m_EventId; // 0x4
	private IntPtr m_EventName; // 0x8
	private AntiCheatCommonEventType m_EventType; // 0x10
	private uint m_ParamDefsCount; // 0x14
	private IntPtr m_ParamDefs; // 0x18

	// Properties
	public uint EventId { set; }
	public Utf8String EventName { set; }
	public AntiCheatCommonEventType EventType { set; }
	public RegisterEventParamDef[] ParamDefs { set; }

	// Methods

	// RVA: 0x3F84A0 Offset: 0x3F76A0 VA: 0x1803F84A0
	public void set_EventId(uint value) { }

	// RVA: 0x437850 Offset: 0x436A50 VA: 0x180437850
	public void set_EventName(Utf8String value) { }

	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_EventType(AntiCheatCommonEventType value) { }

	// RVA: 0x4378B0 Offset: 0x436AB0 VA: 0x1804378B0
	public void set_ParamDefs(RegisterEventParamDef[] value) { }

	// RVA: 0x437770 Offset: 0x436970 VA: 0x180437770 Slot: 4
	public void Set(ref RegisterEventOptions other) { }

	// RVA: 0x437660 Offset: 0x436860 VA: 0x180437660 Slot: 5
	public void Set(ref Nullable<RegisterEventOptions> other) { }

	// RVA: 0x437600 Offset: 0x436800 VA: 0x180437600 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.AntiCheatCommon
public struct RegisterEventParamDef // TypeDefIndex: 10094
{
	// Fields
	[CompilerGenerated]
	private Utf8String <ParamName>k__BackingField; // 0x0
	[CompilerGenerated]
	private AntiCheatCommonEventParamType <ParamType>k__BackingField; // 0x8

	// Properties
	public Utf8String ParamName { get; set; }
	public AntiCheatCommonEventParamType ParamType { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Utf8String get_ParamName() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_ParamName(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3F5510 Offset: 0x3F4710 VA: 0x1803F5510
	public AntiCheatCommonEventParamType get_ParamType() { }

	[CompilerGenerated]
	// RVA: 0x3F5520 Offset: 0x3F4720 VA: 0x1803F5520
	public void set_ParamType(AntiCheatCommonEventParamType value) { }

	// RVA: 0x437B90 Offset: 0x436D90 VA: 0x180437B90
	internal void Set(ref RegisterEventParamDefInternal other) { }
}

// Namespace: Epic.OnlineServices.AntiCheatCommon
internal struct RegisterEventParamDefInternal : IGettable<RegisterEventParamDef>, ISettable<RegisterEventParamDef>, IDisposable // TypeDefIndex: 10095
{
	// Fields
	private IntPtr m_ParamName; // 0x0
	private AntiCheatCommonEventParamType m_ParamType; // 0x8

	// Properties
	public Utf8String ParamName { get; set; }
	public AntiCheatCommonEventParamType ParamType { get; set; }

	// Methods

	// RVA: 0x437AC0 Offset: 0x436CC0 VA: 0x180437AC0
	public Utf8String get_ParamName() { }

	// RVA: 0x437B30 Offset: 0x436D30 VA: 0x180437B30
	public void set_ParamName(Utf8String value) { }

	// RVA: 0x3F5510 Offset: 0x3F4710 VA: 0x1803F5510
	public AntiCheatCommonEventParamType get_ParamType() { }

	// RVA: 0x3F5520 Offset: 0x3F4720 VA: 0x1803F5520
	public void set_ParamType(AntiCheatCommonEventParamType value) { }

	// RVA: 0x437990 Offset: 0x436B90 VA: 0x180437990 Slot: 5
	public void Set(ref RegisterEventParamDef other) { }

	// RVA: 0x437A00 Offset: 0x436C00 VA: 0x180437A00 Slot: 6
	public void Set(ref Nullable<RegisterEventParamDef> other) { }

	// RVA: 0x437920 Offset: 0x436B20 VA: 0x180437920 Slot: 7
	public void Dispose() { }

	// RVA: 0x437970 Offset: 0x436B70 VA: 0x180437970 Slot: 4
	public void Get(out RegisterEventParamDef output) { }
}

// Namespace: Epic.OnlineServices.AntiCheatCommon
public struct SetClientDetailsOptions // TypeDefIndex: 10096
{
	// Fields
	[CompilerGenerated]
	private IntPtr <ClientHandle>k__BackingField; // 0x0
	[CompilerGenerated]
	private AntiCheatCommonClientFlags <ClientFlags>k__BackingField; // 0x8
	[CompilerGenerated]
	private AntiCheatCommonClientInput <ClientInputMethod>k__BackingField; // 0xC

	// Properties
	public IntPtr ClientHandle { get; set; }
	public AntiCheatCommonClientFlags ClientFlags { get; set; }
	public AntiCheatCommonClientInput ClientInputMethod { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public IntPtr get_ClientHandle() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_ClientHandle(IntPtr value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3F5510 Offset: 0x3F4710 VA: 0x1803F5510
	public AntiCheatCommonClientFlags get_ClientFlags() { }

	[CompilerGenerated]
	// RVA: 0x3F5520 Offset: 0x3F4720 VA: 0x1803F5520
	public void set_ClientFlags(AntiCheatCommonClientFlags value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x438080 Offset: 0x437280 VA: 0x180438080
	public AntiCheatCommonClientInput get_ClientInputMethod() { }

	[CompilerGenerated]
	// RVA: 0x438090 Offset: 0x437290 VA: 0x180438090
	public void set_ClientInputMethod(AntiCheatCommonClientInput value) { }
}

// Namespace: Epic.OnlineServices.AntiCheatCommon
internal struct SetClientDetailsOptionsInternal : ISettable<SetClientDetailsOptions>, IDisposable // TypeDefIndex: 10097
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_ClientHandle; // 0x8
	private AntiCheatCommonClientFlags m_ClientFlags; // 0x10
	private AntiCheatCommonClientInput m_ClientInputMethod; // 0x14

	// Properties
	public IntPtr ClientHandle { set; }
	public AntiCheatCommonClientFlags ClientFlags { set; }
	public AntiCheatCommonClientInput ClientInputMethod { set; }

	// Methods

	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_ClientHandle(IntPtr value) { }

	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_ClientFlags(AntiCheatCommonClientFlags value) { }

	// RVA: 0x426530 Offset: 0x425730 VA: 0x180426530
	public void set_ClientInputMethod(AntiCheatCommonClientInput value) { }

	// RVA: 0x438210 Offset: 0x437410 VA: 0x180438210 Slot: 4
	public void Set(ref SetClientDetailsOptions other) { }

	// RVA: 0x438230 Offset: 0x437430 VA: 0x180438230 Slot: 5
	public void Set(ref Nullable<SetClientDetailsOptions> other) { }

	// RVA: 0x4381C0 Offset: 0x4373C0 VA: 0x1804381C0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.AntiCheatCommon
public struct SetGameSessionIdOptions // TypeDefIndex: 10098
{
	// Fields
	[CompilerGenerated]
	private Utf8String <GameSessionId>k__BackingField; // 0x0

	// Properties
	public Utf8String GameSessionId { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Utf8String get_GameSessionId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_GameSessionId(Utf8String value) { }
}

// Namespace: Epic.OnlineServices.AntiCheatCommon
internal struct SetGameSessionIdOptionsInternal : ISettable<SetGameSessionIdOptions>, IDisposable // TypeDefIndex: 10099
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_GameSessionId; // 0x8

	// Properties
	public Utf8String GameSessionId { set; }

	// Methods

	// RVA: 0x438430 Offset: 0x437630 VA: 0x180438430
	public void set_GameSessionId(Utf8String value) { }

	// RVA: 0x438330 Offset: 0x437530 VA: 0x180438330 Slot: 4
	public void Set(ref SetGameSessionIdOptions other) { }

	// RVA: 0x438390 Offset: 0x437590 VA: 0x180438390 Slot: 5
	public void Set(ref Nullable<SetGameSessionIdOptions> other) { }

	// RVA: 0x4382E0 Offset: 0x4374E0 VA: 0x1804382E0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.AntiCheatCommon
public struct Vec3f // TypeDefIndex: 10100
{
	// Fields
	[CompilerGenerated]
	private float <x>k__BackingField; // 0x0
	[CompilerGenerated]
	private float <y>k__BackingField; // 0x4
	[CompilerGenerated]
	private float <z>k__BackingField; // 0x8

	// Properties
	public float x { get; set; }
	public float y { get; set; }
	public float z { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x439FA0 Offset: 0x4391A0 VA: 0x180439FA0
	public float get_x() { }

	[CompilerGenerated]
	// RVA: 0x439FD0 Offset: 0x4391D0 VA: 0x180439FD0
	public void set_x(float value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x439FB0 Offset: 0x4391B0 VA: 0x180439FB0
	public float get_y() { }

	[CompilerGenerated]
	// RVA: 0x439FE0 Offset: 0x4391E0 VA: 0x180439FE0
	public void set_y(float value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x439FC0 Offset: 0x4391C0 VA: 0x180439FC0
	public float get_z() { }

	[CompilerGenerated]
	// RVA: 0x439FF0 Offset: 0x4391F0 VA: 0x180439FF0
	public void set_z(float value) { }

	// RVA: 0x3FF350 Offset: 0x3FE550 VA: 0x1803FF350
	internal void Set(ref Vec3fInternal other) { }
}

// Namespace: Epic.OnlineServices.AntiCheatCommon
internal struct Vec3fInternal : IGettable<Vec3f>, ISettable<Vec3f>, IDisposable // TypeDefIndex: 10101
{
	// Fields
	private float m_x; // 0x0
	private float m_y; // 0x4
	private float m_z; // 0x8

	// Properties
	public float x { get; set; }
	public float y { get; set; }
	public float z { get; set; }

	// Methods

	// RVA: 0x439FA0 Offset: 0x4391A0 VA: 0x180439FA0
	public float get_x() { }

	// RVA: 0x439FD0 Offset: 0x4391D0 VA: 0x180439FD0
	public void set_x(float value) { }

	// RVA: 0x439FB0 Offset: 0x4391B0 VA: 0x180439FB0
	public float get_y() { }

	// RVA: 0x439FE0 Offset: 0x4391E0 VA: 0x180439FE0
	public void set_y(float value) { }

	// RVA: 0x439FC0 Offset: 0x4391C0 VA: 0x180439FC0
	public float get_z() { }

	// RVA: 0x439FF0 Offset: 0x4391F0 VA: 0x180439FF0
	public void set_z(float value) { }

	// RVA: 0x3FF350 Offset: 0x3FE550 VA: 0x1803FF350 Slot: 5
	public void Set(ref Vec3f other) { }

	// RVA: 0x439EF0 Offset: 0x4390F0 VA: 0x180439EF0 Slot: 6
	public void Set(ref Nullable<Vec3f> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 7
	public void Dispose() { }

	// RVA: 0x3FF290 Offset: 0x3FE490 VA: 0x1803FF290 Slot: 4
	public void Get(out Vec3f output) { }
}

// Namespace: Epic.OnlineServices.AntiCheatClient
public struct AddExternalIntegrityCatalogOptions // TypeDefIndex: 10102
{
	// Fields
	[CompilerGenerated]
	private Utf8String <PathToBinFile>k__BackingField; // 0x0

	// Properties
	public Utf8String PathToBinFile { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Utf8String get_PathToBinFile() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_PathToBinFile(Utf8String value) { }
}

// Namespace: Epic.OnlineServices.AntiCheatClient
internal struct AddExternalIntegrityCatalogOptionsInternal : ISettable<AddExternalIntegrityCatalogOptions>, IDisposable // TypeDefIndex: 10103
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_PathToBinFile; // 0x8

	// Properties
	public Utf8String PathToBinFile { set; }

	// Methods

	// RVA: 0x425860 Offset: 0x424A60 VA: 0x180425860
	public void set_PathToBinFile(Utf8String value) { }

	// RVA: 0x425760 Offset: 0x424960 VA: 0x180425760 Slot: 4
	public void Set(ref AddExternalIntegrityCatalogOptions other) { }

	// RVA: 0x4257C0 Offset: 0x4249C0 VA: 0x1804257C0 Slot: 5
	public void Set(ref Nullable<AddExternalIntegrityCatalogOptions> other) { }

	// RVA: 0x425710 Offset: 0x424910 VA: 0x180425710 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.AntiCheatClient
public struct AddNotifyClientIntegrityViolatedOptions // TypeDefIndex: 10104
{}

// Namespace: Epic.OnlineServices.AntiCheatClient
internal struct AddNotifyClientIntegrityViolatedOptionsInternal : ISettable<AddNotifyClientIntegrityViolatedOptions>, IDisposable // TypeDefIndex: 10105
{
	// Fields
	private int m_ApiVersion; // 0x0

	// Methods

	// RVA: 0x3F98A0 Offset: 0x3F8AA0 VA: 0x1803F98A0 Slot: 4
	public void Set(ref AddNotifyClientIntegrityViolatedOptions other) { }

	// RVA: 0x4258C0 Offset: 0x424AC0 VA: 0x1804258C0 Slot: 5
	public void Set(ref Nullable<AddNotifyClientIntegrityViolatedOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.AntiCheatClient
public struct AddNotifyMessageToPeerOptions // TypeDefIndex: 10106
{}

// Namespace: Epic.OnlineServices.AntiCheatClient
internal struct AddNotifyMessageToPeerOptionsInternal : ISettable<AddNotifyMessageToPeerOptions>, IDisposable // TypeDefIndex: 10107
{
	// Fields
	private int m_ApiVersion; // 0x0

	// Methods

	// RVA: 0x3F98A0 Offset: 0x3F8AA0 VA: 0x1803F98A0 Slot: 4
	public void Set(ref AddNotifyMessageToPeerOptions other) { }

	// RVA: 0x425910 Offset: 0x424B10 VA: 0x180425910 Slot: 5
	public void Set(ref Nullable<AddNotifyMessageToPeerOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.AntiCheatClient
public struct AddNotifyMessageToServerOptions // TypeDefIndex: 10108
{}

// Namespace: Epic.OnlineServices.AntiCheatClient
internal struct AddNotifyMessageToServerOptionsInternal : ISettable<AddNotifyMessageToServerOptions>, IDisposable // TypeDefIndex: 10109
{
	// Fields
	private int m_ApiVersion; // 0x0

	// Methods

	// RVA: 0x3F98A0 Offset: 0x3F8AA0 VA: 0x1803F98A0 Slot: 4
	public void Set(ref AddNotifyMessageToServerOptions other) { }

	// RVA: 0x425960 Offset: 0x424B60 VA: 0x180425960 Slot: 5
	public void Set(ref Nullable<AddNotifyMessageToServerOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.AntiCheatClient
public struct AddNotifyPeerActionRequiredOptions // TypeDefIndex: 10110
{}

// Namespace: Epic.OnlineServices.AntiCheatClient
internal struct AddNotifyPeerActionRequiredOptionsInternal : ISettable<AddNotifyPeerActionRequiredOptions>, IDisposable // TypeDefIndex: 10111
{
	// Fields
	private int m_ApiVersion; // 0x0

	// Methods

	// RVA: 0x3F98A0 Offset: 0x3F8AA0 VA: 0x1803F98A0 Slot: 4
	public void Set(ref AddNotifyPeerActionRequiredOptions other) { }

	// RVA: 0x4259B0 Offset: 0x424BB0 VA: 0x1804259B0 Slot: 5
	public void Set(ref Nullable<AddNotifyPeerActionRequiredOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.AntiCheatClient
public struct AddNotifyPeerAuthStatusChangedOptions // TypeDefIndex: 10112
{}

// Namespace: Epic.OnlineServices.AntiCheatClient
internal struct AddNotifyPeerAuthStatusChangedOptionsInternal : ISettable<AddNotifyPeerAuthStatusChangedOptions>, IDisposable // TypeDefIndex: 10113
{
	// Fields
	private int m_ApiVersion; // 0x0

	// Methods

	// RVA: 0x3F98A0 Offset: 0x3F8AA0 VA: 0x1803F98A0 Slot: 4
	public void Set(ref AddNotifyPeerAuthStatusChangedOptions other) { }

	// RVA: 0x425A00 Offset: 0x424C00 VA: 0x180425A00 Slot: 5
	public void Set(ref Nullable<AddNotifyPeerAuthStatusChangedOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.AntiCheatClient
public sealed class AntiCheatClientInterface : Handle // TypeDefIndex: 10114
{
	// Fields
	public const int AddexternalintegritycatalogApiLatest = 1;
	public const int AddnotifyclientintegrityviolatedApiLatest = 1;
	public const int AddnotifymessagetopeerApiLatest = 1;
	public const int AddnotifymessagetoserverApiLatest = 1;
	public const int AddnotifypeeractionrequiredApiLatest = 1;
	public const int AddnotifypeerauthstatuschangedApiLatest = 1;
	public const int BeginsessionApiLatest = 3;
	public const int EndsessionApiLatest = 1;
	public const int GetprotectmessageoutputlengthApiLatest = 1;
	public const int OnmessagetopeercallbackMaxMessageSize = 512;
	public const int OnmessagetoservercallbackMaxMessageSize = 512;
	public IntPtr PeerSelf; // 0x18
	public const int PollstatusApiLatest = 1;
	public const int ProtectmessageApiLatest = 1;
	public const int ReceivemessagefrompeerApiLatest = 1;
	public const int ReceivemessagefromserverApiLatest = 1;
	public const int RegisterpeerApiLatest = 3;
	public const int RegisterpeerMaxAuthenticationtimeout = 120;
	public const int RegisterpeerMinAuthenticationtimeout = 40;
	public const int UnprotectmessageApiLatest = 1;
	public const int UnregisterpeerApiLatest = 1;

	// Methods

	// RVA: 0x428B80 Offset: 0x427D80 VA: 0x180428B80
	public void .ctor() { }

	// RVA: 0x428BB0 Offset: 0x427DB0 VA: 0x180428BB0
	public void .ctor(IntPtr innerHandle) { }

	// RVA: 0x4273A0 Offset: 0x4265A0 VA: 0x1804273A0
	public Result AddExternalIntegrityCatalog(ref AddExternalIntegrityCatalogOptions options) { }

	// RVA: 0x427480 Offset: 0x426680 VA: 0x180427480
	public ulong AddNotifyClientIntegrityViolated(ref AddNotifyClientIntegrityViolatedOptions options, object clientData, OnClientIntegrityViolatedCallback notificationFn) { }

	// RVA: 0x427630 Offset: 0x426830 VA: 0x180427630
	public ulong AddNotifyMessageToPeer(ref AddNotifyMessageToPeerOptions options, object clientData, OnMessageToPeerCallback notificationFn) { }

	// RVA: 0x4277E0 Offset: 0x4269E0 VA: 0x1804277E0
	public ulong AddNotifyMessageToServer(ref AddNotifyMessageToServerOptions options, object clientData, OnMessageToServerCallback notificationFn) { }

	// RVA: 0x427990 Offset: 0x426B90 VA: 0x180427990
	public ulong AddNotifyPeerActionRequired(ref AddNotifyPeerActionRequiredOptions options, object clientData, OnPeerActionRequiredCallback notificationFn) { }

	// RVA: 0x427B40 Offset: 0x426D40 VA: 0x180427B40
	public ulong AddNotifyPeerAuthStatusChanged(ref AddNotifyPeerAuthStatusChangedOptions options, object clientData, OnPeerAuthStatusChangedCallback notificationFn) { }

	// RVA: 0x427CF0 Offset: 0x426EF0 VA: 0x180427CF0
	public Result BeginSession(ref BeginSessionOptions options) { }

	// RVA: 0x427DE0 Offset: 0x426FE0 VA: 0x180427DE0
	public Result EndSession(ref EndSessionOptions options) { }

	// RVA: 0x427E60 Offset: 0x427060 VA: 0x180427E60
	public Result GetProtectMessageOutputLength(ref GetProtectMessageOutputLengthOptions options, out uint outBufferSizeBytes) { }

	// RVA: 0x428290 Offset: 0x427490 VA: 0x180428290
	public Result PollStatus(ref PollStatusOptions options, out AntiCheatClientViolationType outViolationType, out Utf8String outMessage) { }

	// RVA: 0x428380 Offset: 0x427580 VA: 0x180428380
	public Result ProtectMessage(ref ProtectMessageOptions options, ArraySegment<byte> outBuffer, out uint outBytesWritten) { }

	// RVA: 0x4284D0 Offset: 0x4276D0 VA: 0x1804284D0
	public Result ReceiveMessageFromPeer(ref ReceiveMessageFromPeerOptions options) { }

	// RVA: 0x4285D0 Offset: 0x4277D0 VA: 0x1804285D0
	public Result ReceiveMessageFromServer(ref ReceiveMessageFromServerOptions options) { }

	// RVA: 0x4286C0 Offset: 0x4278C0 VA: 0x1804286C0
	public Result RegisterPeer(ref RegisterPeerOptions options) { }

	// RVA: 0x428770 Offset: 0x427970 VA: 0x180428770
	public void RemoveNotifyClientIntegrityViolated(ulong notificationId) { }

	// RVA: 0x4287E0 Offset: 0x4279E0 VA: 0x1804287E0
	public void RemoveNotifyMessageToPeer(ulong notificationId) { }

	// RVA: 0x428850 Offset: 0x427A50 VA: 0x180428850
	public void RemoveNotifyMessageToServer(ulong notificationId) { }

	// RVA: 0x4288C0 Offset: 0x427AC0 VA: 0x1804288C0
	public void RemoveNotifyPeerActionRequired(ulong notificationId) { }

	// RVA: 0x428930 Offset: 0x427B30 VA: 0x180428930
	public void RemoveNotifyPeerAuthStatusChanged(ulong notificationId) { }

	// RVA: 0x4289A0 Offset: 0x427BA0 VA: 0x1804289A0
	public Result UnprotectMessage(ref UnprotectMessageOptions options, ArraySegment<byte> outBuffer, out uint outBytesWritten) { }

	// RVA: 0x428AF0 Offset: 0x427CF0 VA: 0x180428AF0
	public Result UnregisterPeer(ref UnregisterPeerOptions options) { }

	[MonoPInvokeCallback(typeof(OnClientIntegrityViolatedCallbackInternal))]
	// RVA: 0x427F20 Offset: 0x427120 VA: 0x180427F20
	internal static void OnClientIntegrityViolatedCallbackInternalImplementation(ref OnClientIntegrityViolatedCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnMessageToPeerCallbackInternal))]
	// RVA: 0x427FD0 Offset: 0x4271D0 VA: 0x180427FD0
	internal static void OnMessageToPeerCallbackInternalImplementation(ref OnMessageToClientCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnMessageToServerCallbackInternal))]
	// RVA: 0x428080 Offset: 0x427280 VA: 0x180428080
	internal static void OnMessageToServerCallbackInternalImplementation(ref OnMessageToServerCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnPeerActionRequiredCallbackInternal))]
	// RVA: 0x428130 Offset: 0x427330 VA: 0x180428130
	internal static void OnPeerActionRequiredCallbackInternalImplementation(ref OnClientActionRequiredCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnPeerAuthStatusChangedCallbackInternal))]
	// RVA: 0x4281E0 Offset: 0x4273E0 VA: 0x1804281E0
	internal static void OnPeerAuthStatusChangedCallbackInternalImplementation(ref OnClientAuthStatusChangedCallbackInfoInternal data) { }
}

// Namespace: Epic.OnlineServices.AntiCheatClient
public enum AntiCheatClientMode // TypeDefIndex: 10115
{
	// Fields
	public int value__; // 0x0
	public const AntiCheatClientMode Invalid = 0;
	public const AntiCheatClientMode ClientServer = 1;
	public const AntiCheatClientMode PeerToPeer = 2;
}

// Namespace: Epic.OnlineServices.AntiCheatClient
public enum AntiCheatClientViolationType // TypeDefIndex: 10116
{
	// Fields
	public int value__; // 0x0
	public const AntiCheatClientViolationType Invalid = 0;
	public const AntiCheatClientViolationType IntegrityCatalogNotFound = 1;
	public const AntiCheatClientViolationType IntegrityCatalogError = 2;
	public const AntiCheatClientViolationType IntegrityCatalogCertificateRevoked = 3;
	public const AntiCheatClientViolationType IntegrityCatalogMissingMainExecutable = 4;
	public const AntiCheatClientViolationType GameFileMismatch = 5;
	public const AntiCheatClientViolationType RequiredGameFileNotFound = 6;
	public const AntiCheatClientViolationType UnknownGameFileForbidden = 7;
	public const AntiCheatClientViolationType SystemFileUntrusted = 8;
	public const AntiCheatClientViolationType ForbiddenModuleLoaded = 9;
	public const AntiCheatClientViolationType CorruptedMemory = 10;
	public const AntiCheatClientViolationType ForbiddenToolDetected = 11;
	public const AntiCheatClientViolationType InternalAntiCheatViolation = 12;
	public const AntiCheatClientViolationType CorruptedNetworkMessageFlow = 13;
	public const AntiCheatClientViolationType VirtualMachineNotAllowed = 14;
	public const AntiCheatClientViolationType ForbiddenSystemConfiguration = 15;
}

// Namespace: Epic.OnlineServices.AntiCheatClient
public struct BeginSessionOptions // TypeDefIndex: 10117
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private AntiCheatClientMode <Mode>k__BackingField; // 0x8

	// Properties
	public ProductUserId LocalUserId { get; set; }
	public AntiCheatClientMode Mode { get; set; }

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
	public AntiCheatClientMode get_Mode() { }

	[CompilerGenerated]
	// RVA: 0x3F5520 Offset: 0x3F4720 VA: 0x1803F5520
	public void set_Mode(AntiCheatClientMode value) { }
}

// Namespace: Epic.OnlineServices.AntiCheatClient
internal struct BeginSessionOptionsInternal : ISettable<BeginSessionOptions>, IDisposable // TypeDefIndex: 10118
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private AntiCheatClientMode m_Mode; // 0x10

	// Properties
	public ProductUserId LocalUserId { set; }
	public AntiCheatClientMode Mode { set; }

	// Methods

	// RVA: 0x428D80 Offset: 0x427F80 VA: 0x180428D80
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_Mode(AntiCheatClientMode value) { }

	// RVA: 0x428D00 Offset: 0x427F00 VA: 0x180428D00 Slot: 4
	public void Set(ref BeginSessionOptions other) { }

	// RVA: 0x428C40 Offset: 0x427E40 VA: 0x180428C40 Slot: 5
	public void Set(ref Nullable<BeginSessionOptions> other) { }

	// RVA: 0x428BF0 Offset: 0x427DF0 VA: 0x180428BF0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.AntiCheatClient
public struct EndSessionOptions // TypeDefIndex: 10119
{}

// Namespace: Epic.OnlineServices.AntiCheatClient
internal struct EndSessionOptionsInternal : ISettable<EndSessionOptions>, IDisposable // TypeDefIndex: 10120
{
	// Fields
	private int m_ApiVersion; // 0x0

	// Methods

	// RVA: 0x3F98A0 Offset: 0x3F8AA0 VA: 0x1803F98A0 Slot: 4
	public void Set(ref EndSessionOptions other) { }

	// RVA: 0x42A5A0 Offset: 0x4297A0 VA: 0x18042A5A0 Slot: 5
	public void Set(ref Nullable<EndSessionOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.AntiCheatClient
public struct GetProtectMessageOutputLengthOptions // TypeDefIndex: 10121
{
	// Fields
	[CompilerGenerated]
	private uint <DataLengthBytes>k__BackingField; // 0x0

	// Properties
	public uint DataLengthBytes { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public uint get_DataLengthBytes() { }

	[CompilerGenerated]
	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_DataLengthBytes(uint value) { }
}

// Namespace: Epic.OnlineServices.AntiCheatClient
internal struct GetProtectMessageOutputLengthOptionsInternal : ISettable<GetProtectMessageOutputLengthOptions>, IDisposable // TypeDefIndex: 10122
{
	// Fields
	private int m_ApiVersion; // 0x0
	private uint m_DataLengthBytes; // 0x4

	// Properties
	public uint DataLengthBytes { set; }

	// Methods

	// RVA: 0x3F84A0 Offset: 0x3F76A0 VA: 0x1803F84A0
	public void set_DataLengthBytes(uint value) { }

	// RVA: 0x40B2E0 Offset: 0x40A4E0 VA: 0x18040B2E0 Slot: 4
	public void Set(ref GetProtectMessageOutputLengthOptions other) { }

	// RVA: 0x42A640 Offset: 0x429840 VA: 0x18042A640 Slot: 5
	public void Set(ref Nullable<GetProtectMessageOutputLengthOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.AntiCheatClient
public sealed class OnClientIntegrityViolatedCallback : MulticastDelegate // TypeDefIndex: 10123
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref OnClientIntegrityViolatedCallbackInfo data) { }

	// RVA: 0x42BDF0 Offset: 0x42AFF0 VA: 0x18042BDF0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref OnClientIntegrityViolatedCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref OnClientIntegrityViolatedCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.AntiCheatClient
[UnmanagedFunctionPointer(2)]
internal sealed class OnClientIntegrityViolatedCallbackInternal : MulticastDelegate // TypeDefIndex: 10124
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref OnClientIntegrityViolatedCallbackInfoInternal data) { }

	// RVA: 0x42BD60 Offset: 0x42AF60 VA: 0x18042BD60 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref OnClientIntegrityViolatedCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref OnClientIntegrityViolatedCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.AntiCheatClient
public struct OnClientIntegrityViolatedCallbackInfo : ICallbackInfo // TypeDefIndex: 10125
{
	// Fields
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x0
	[CompilerGenerated]
	private AntiCheatClientViolationType <ViolationType>k__BackingField; // 0x8
	[CompilerGenerated]
	private Utf8String <ViolationMessage>k__BackingField; // 0x10

	// Properties
	public object ClientData { get; set; }
	public AntiCheatClientViolationType ViolationType { get; set; }
	public Utf8String ViolationMessage { get; set; }

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
	// RVA: 0x3F5510 Offset: 0x3F4710 VA: 0x1803F5510
	public AntiCheatClientViolationType get_ViolationType() { }

	[CompilerGenerated]
	// RVA: 0x3F5520 Offset: 0x3F4720 VA: 0x1803F5520
	public void set_ViolationType(AntiCheatClientViolationType value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Utf8String get_ViolationMessage() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_ViolationMessage(Utf8String value) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x42BC80 Offset: 0x42AE80 VA: 0x18042BC80
	internal void Set(ref OnClientIntegrityViolatedCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.AntiCheatClient
internal struct OnClientIntegrityViolatedCallbackInfoInternal : ICallbackInfoInternal, IGettable<OnClientIntegrityViolatedCallbackInfo>, ISettable<OnClientIntegrityViolatedCallbackInfo>, IDisposable // TypeDefIndex: 10126
{
	// Fields
	private IntPtr m_ClientData; // 0x0
	private AntiCheatClientViolationType m_ViolationType; // 0x8
	private IntPtr m_ViolationMessage; // 0x10

	// Properties
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public AntiCheatClientViolationType ViolationType { get; set; }
	public Utf8String ViolationMessage { get; set; }

	// Methods

	// RVA: 0x42BAE0 Offset: 0x42ACE0 VA: 0x18042BAE0
	public object get_ClientData() { }

	// RVA: 0x42BBC0 Offset: 0x42ADC0 VA: 0x18042BBC0
	public void set_ClientData(object value) { }

	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x3F5510 Offset: 0x3F4710 VA: 0x1803F5510
	public AntiCheatClientViolationType get_ViolationType() { }

	// RVA: 0x3F5520 Offset: 0x3F4720 VA: 0x1803F5520
	public void set_ViolationType(AntiCheatClientViolationType value) { }

	// RVA: 0x42BB50 Offset: 0x42AD50 VA: 0x18042BB50
	public Utf8String get_ViolationMessage() { }

	// RVA: 0x42BC20 Offset: 0x42AE20 VA: 0x18042BC20
	public void set_ViolationMessage(Utf8String value) { }

	// RVA: 0x42B910 Offset: 0x42AB10 VA: 0x18042B910 Slot: 6
	public void Set(ref OnClientIntegrityViolatedCallbackInfo other) { }

	// RVA: 0x42B9C0 Offset: 0x42ABC0 VA: 0x18042B9C0 Slot: 7
	public void Set(ref Nullable<OnClientIntegrityViolatedCallbackInfo> other) { }

	// RVA: 0x42B890 Offset: 0x42AA90 VA: 0x18042B890 Slot: 8
	public void Dispose() { }

	// RVA: 0x42B8F0 Offset: 0x42AAF0 VA: 0x18042B8F0 Slot: 5
	public void Get(out OnClientIntegrityViolatedCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.AntiCheatClient
public sealed class OnMessageToPeerCallback : MulticastDelegate // TypeDefIndex: 10127
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref OnMessageToClientCallbackInfo data) { }

	// RVA: 0x42BF10 Offset: 0x42B110 VA: 0x18042BF10 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref OnMessageToClientCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref OnMessageToClientCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.AntiCheatClient
[UnmanagedFunctionPointer(2)]
internal sealed class OnMessageToPeerCallbackInternal : MulticastDelegate // TypeDefIndex: 10128
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref OnMessageToClientCallbackInfoInternal data) { }

	// RVA: 0x42BE80 Offset: 0x42B080 VA: 0x18042BE80 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref OnMessageToClientCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref OnMessageToClientCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.AntiCheatClient
public sealed class OnMessageToServerCallback : MulticastDelegate // TypeDefIndex: 10129
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref OnMessageToServerCallbackInfo data) { }

	// RVA: 0x42C550 Offset: 0x42B750 VA: 0x18042C550 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref OnMessageToServerCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref OnMessageToServerCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.AntiCheatClient
[UnmanagedFunctionPointer(2)]
internal sealed class OnMessageToServerCallbackInternal : MulticastDelegate // TypeDefIndex: 10130
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref OnMessageToServerCallbackInfoInternal data) { }

	// RVA: 0x42C4C0 Offset: 0x42B6C0 VA: 0x18042C4C0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref OnMessageToServerCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref OnMessageToServerCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.AntiCheatClient
public struct OnMessageToServerCallbackInfo : ICallbackInfo // TypeDefIndex: 10131
{
	// Fields
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x0
	[CompilerGenerated]
	private ArraySegment<byte> <MessageData>k__BackingField; // 0x8

	// Properties
	public object ClientData { get; set; }
	public ArraySegment<byte> MessageData { get; set; }

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
	// RVA: 0x42C4A0 Offset: 0x42B6A0 VA: 0x18042C4A0
	public ArraySegment<byte> get_MessageData() { }

	[CompilerGenerated]
	// RVA: 0x42C4B0 Offset: 0x42B6B0 VA: 0x18042C4B0
	public void set_MessageData(ArraySegment<byte> value) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x42C3C0 Offset: 0x42B5C0 VA: 0x18042C3C0
	internal void Set(ref OnMessageToServerCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.AntiCheatClient
internal struct OnMessageToServerCallbackInfoInternal : ICallbackInfoInternal, IGettable<OnMessageToServerCallbackInfo>, ISettable<OnMessageToServerCallbackInfo>, IDisposable // TypeDefIndex: 10132
{
	// Fields
	private IntPtr m_ClientData; // 0x0
	private IntPtr m_MessageData; // 0x8
	private uint m_MessageDataSizeBytes; // 0x10

	// Properties
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public ArraySegment<byte> MessageData { get; set; }

	// Methods

	// RVA: 0x42C200 Offset: 0x42B400 VA: 0x18042C200
	public object get_ClientData() { }

	// RVA: 0x42C2F0 Offset: 0x42B4F0 VA: 0x18042C2F0
	public void set_ClientData(object value) { }

	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x42C270 Offset: 0x42B470 VA: 0x18042C270
	public ArraySegment<byte> get_MessageData() { }

	// RVA: 0x42C350 Offset: 0x42B550 VA: 0x18042C350
	public void set_MessageData(ArraySegment<byte> value) { }

	// RVA: 0x42C130 Offset: 0x42B330 VA: 0x18042C130 Slot: 6
	public void Set(ref OnMessageToServerCallbackInfo other) { }

	// RVA: 0x42C020 Offset: 0x42B220 VA: 0x18042C020 Slot: 7
	public void Set(ref Nullable<OnMessageToServerCallbackInfo> other) { }

	// RVA: 0x42BFA0 Offset: 0x42B1A0 VA: 0x18042BFA0 Slot: 8
	public void Dispose() { }

	// RVA: 0x42C000 Offset: 0x42B200 VA: 0x18042C000 Slot: 5
	public void Get(out OnMessageToServerCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.AntiCheatClient
public sealed class OnPeerActionRequiredCallback : MulticastDelegate // TypeDefIndex: 10133
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref OnClientActionRequiredCallbackInfo data) { }

	// RVA: 0x42C670 Offset: 0x42B870 VA: 0x18042C670 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref OnClientActionRequiredCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref OnClientActionRequiredCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.AntiCheatClient
[UnmanagedFunctionPointer(2)]
internal sealed class OnPeerActionRequiredCallbackInternal : MulticastDelegate // TypeDefIndex: 10134
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref OnClientActionRequiredCallbackInfoInternal data) { }

	// RVA: 0x42C5E0 Offset: 0x42B7E0 VA: 0x18042C5E0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref OnClientActionRequiredCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref OnClientActionRequiredCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.AntiCheatClient
public sealed class OnPeerAuthStatusChangedCallback : MulticastDelegate // TypeDefIndex: 10135
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref OnClientAuthStatusChangedCallbackInfo data) { }

	// RVA: 0x42C790 Offset: 0x42B990 VA: 0x18042C790 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref OnClientAuthStatusChangedCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref OnClientAuthStatusChangedCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.AntiCheatClient
[UnmanagedFunctionPointer(2)]
internal sealed class OnPeerAuthStatusChangedCallbackInternal : MulticastDelegate // TypeDefIndex: 10136
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref OnClientAuthStatusChangedCallbackInfoInternal data) { }

	// RVA: 0x42C700 Offset: 0x42B900 VA: 0x18042C700 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref OnClientAuthStatusChangedCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref OnClientAuthStatusChangedCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.AntiCheatClient
public struct PollStatusOptions // TypeDefIndex: 10137
{
	// Fields
	[CompilerGenerated]
	private uint <OutMessageLength>k__BackingField; // 0x0

	// Properties
	public uint OutMessageLength { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public uint get_OutMessageLength() { }

	[CompilerGenerated]
	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_OutMessageLength(uint value) { }
}

// Namespace: Epic.OnlineServices.AntiCheatClient
internal struct PollStatusOptionsInternal : ISettable<PollStatusOptions>, IDisposable // TypeDefIndex: 10138
{
	// Fields
	private int m_ApiVersion; // 0x0
	private uint m_OutMessageLength; // 0x4

	// Properties
	public uint OutMessageLength { set; }

	// Methods

	// RVA: 0x3F84A0 Offset: 0x3F76A0 VA: 0x1803F84A0
	public void set_OutMessageLength(uint value) { }

	// RVA: 0x40B2E0 Offset: 0x40A4E0 VA: 0x18040B2E0 Slot: 4
	public void Set(ref PollStatusOptions other) { }

	// RVA: 0x435220 Offset: 0x434420 VA: 0x180435220 Slot: 5
	public void Set(ref Nullable<PollStatusOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.AntiCheatClient
public struct ProtectMessageOptions // TypeDefIndex: 10139
{
	// Fields
	[CompilerGenerated]
	private ArraySegment<byte> <Data>k__BackingField; // 0x0
	[CompilerGenerated]
	private uint <OutBufferSizeBytes>k__BackingField; // 0x10

	// Properties
	public ArraySegment<byte> Data { get; set; }
	public uint OutBufferSizeBytes { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x4354A0 Offset: 0x4346A0 VA: 0x1804354A0
	public ArraySegment<byte> get_Data() { }

	[CompilerGenerated]
	// RVA: 0x4354B0 Offset: 0x4346B0 VA: 0x1804354B0
	public void set_Data(ArraySegment<byte> value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public uint get_OutBufferSizeBytes() { }

	[CompilerGenerated]
	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_OutBufferSizeBytes(uint value) { }
}

// Namespace: Epic.OnlineServices.AntiCheatClient
internal struct ProtectMessageOptionsInternal : ISettable<ProtectMessageOptions>, IDisposable // TypeDefIndex: 10140
{
	// Fields
	private int m_ApiVersion; // 0x0
	private uint m_DataLengthBytes; // 0x4
	private IntPtr m_Data; // 0x8
	private uint m_OutBufferSizeBytes; // 0x10

	// Properties
	public ArraySegment<byte> Data { set; }
	public uint OutBufferSizeBytes { set; }

	// Methods

	// RVA: 0x435430 Offset: 0x434630 VA: 0x180435430
	public void set_Data(ArraySegment<byte> value) { }

	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_OutBufferSizeBytes(uint value) { }

	// RVA: 0x4352D0 Offset: 0x4344D0 VA: 0x1804352D0 Slot: 4
	public void Set(ref ProtectMessageOptions other) { }

	// RVA: 0x435350 Offset: 0x434550 VA: 0x180435350 Slot: 5
	public void Set(ref Nullable<ProtectMessageOptions> other) { }

	// RVA: 0x435280 Offset: 0x434480 VA: 0x180435280 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.AntiCheatClient
public struct ReceiveMessageFromPeerOptions // TypeDefIndex: 10141
{
	// Fields
	[CompilerGenerated]
	private IntPtr <PeerHandle>k__BackingField; // 0x0
	[CompilerGenerated]
	private ArraySegment<byte> <Data>k__BackingField; // 0x8

	// Properties
	public IntPtr PeerHandle { get; set; }
	public ArraySegment<byte> Data { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public IntPtr get_PeerHandle() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_PeerHandle(IntPtr value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x42C4A0 Offset: 0x42B6A0 VA: 0x18042C4A0
	public ArraySegment<byte> get_Data() { }

	[CompilerGenerated]
	// RVA: 0x42C4B0 Offset: 0x42B6B0 VA: 0x18042C4B0
	public void set_Data(ArraySegment<byte> value) { }
}

// Namespace: Epic.OnlineServices.AntiCheatClient
internal struct ReceiveMessageFromPeerOptionsInternal : ISettable<ReceiveMessageFromPeerOptions>, IDisposable // TypeDefIndex: 10142
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_PeerHandle; // 0x8
	private uint m_DataLengthBytes; // 0x10
	private IntPtr m_Data; // 0x18

	// Properties
	public IntPtr PeerHandle { set; }
	public ArraySegment<byte> Data { set; }

	// Methods

	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_PeerHandle(IntPtr value) { }

	// RVA: 0x4373A0 Offset: 0x4365A0 VA: 0x1804373A0
	public void set_Data(ArraySegment<byte> value) { }

	// RVA: 0x437240 Offset: 0x436440 VA: 0x180437240 Slot: 4
	public void Set(ref ReceiveMessageFromPeerOptions other) { }

	// RVA: 0x4372C0 Offset: 0x4364C0 VA: 0x1804372C0 Slot: 5
	public void Set(ref Nullable<ReceiveMessageFromPeerOptions> other) { }

	// RVA: 0x4371E0 Offset: 0x4363E0 VA: 0x1804371E0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.AntiCheatClient
public struct ReceiveMessageFromServerOptions // TypeDefIndex: 10143
{
	// Fields
	[CompilerGenerated]
	private ArraySegment<byte> <Data>k__BackingField; // 0x0

	// Properties
	public ArraySegment<byte> Data { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x4354A0 Offset: 0x4346A0 VA: 0x1804354A0
	public ArraySegment<byte> get_Data() { }

	[CompilerGenerated]
	// RVA: 0x4354B0 Offset: 0x4346B0 VA: 0x1804354B0
	public void set_Data(ArraySegment<byte> value) { }
}

// Namespace: Epic.OnlineServices.AntiCheatClient
internal struct ReceiveMessageFromServerOptionsInternal : ISettable<ReceiveMessageFromServerOptions>, IDisposable // TypeDefIndex: 10144
{
	// Fields
	private int m_ApiVersion; // 0x0
	private uint m_DataLengthBytes; // 0x4
	private IntPtr m_Data; // 0x8

	// Properties
	public ArraySegment<byte> Data { set; }

	// Methods

	// RVA: 0x437590 Offset: 0x436790 VA: 0x180437590
	public void set_Data(ArraySegment<byte> value) { }

	// RVA: 0x437460 Offset: 0x436660 VA: 0x180437460 Slot: 4
	public void Set(ref ReceiveMessageFromServerOptions other) { }

	// RVA: 0x4374D0 Offset: 0x4366D0 VA: 0x1804374D0 Slot: 5
	public void Set(ref Nullable<ReceiveMessageFromServerOptions> other) { }

	// RVA: 0x437410 Offset: 0x436610 VA: 0x180437410 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.AntiCheatClient
public struct RegisterPeerOptions // TypeDefIndex: 10145
{
	// Fields
	[CompilerGenerated]
	private IntPtr <PeerHandle>k__BackingField; // 0x0
	[CompilerGenerated]
	private AntiCheatCommonClientType <ClientType>k__BackingField; // 0x8
	[CompilerGenerated]
	private AntiCheatCommonClientPlatform <ClientPlatform>k__BackingField; // 0xC
	[CompilerGenerated]
	private uint <AuthenticationTimeout>k__BackingField; // 0x10
	[CompilerGenerated]
	private Utf8String <AccountId_DEPRECATED>k__BackingField; // 0x18
	[CompilerGenerated]
	private Utf8String <IpAddress>k__BackingField; // 0x20
	[CompilerGenerated]
	private ProductUserId <PeerProductUserId>k__BackingField; // 0x28

	// Properties
	public IntPtr PeerHandle { get; set; }
	public AntiCheatCommonClientType ClientType { get; set; }
	public AntiCheatCommonClientPlatform ClientPlatform { get; set; }
	public uint AuthenticationTimeout { get; set; }
	internal Utf8String AccountId_DEPRECATED { get; set; }
	public Utf8String IpAddress { get; set; }
	public ProductUserId PeerProductUserId { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public IntPtr get_PeerHandle() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_PeerHandle(IntPtr value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3F5510 Offset: 0x3F4710 VA: 0x1803F5510
	public AntiCheatCommonClientType get_ClientType() { }

	[CompilerGenerated]
	// RVA: 0x3F5520 Offset: 0x3F4720 VA: 0x1803F5520
	public void set_ClientType(AntiCheatCommonClientType value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x438080 Offset: 0x437280 VA: 0x180438080
	public AntiCheatCommonClientPlatform get_ClientPlatform() { }

	[CompilerGenerated]
	// RVA: 0x438090 Offset: 0x437290 VA: 0x180438090
	public void set_ClientPlatform(AntiCheatCommonClientPlatform value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public uint get_AuthenticationTimeout() { }

	[CompilerGenerated]
	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_AuthenticationTimeout(uint value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	internal Utf8String get_AccountId_DEPRECATED() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	internal void set_AccountId_DEPRECATED(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public Utf8String get_IpAddress() { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_IpAddress(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public ProductUserId get_PeerProductUserId() { }

	[CompilerGenerated]
	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	public void set_PeerProductUserId(ProductUserId value) { }
}

// Namespace: Epic.OnlineServices.AntiCheatClient
internal struct RegisterPeerOptionsInternal : ISettable<RegisterPeerOptions>, IDisposable // TypeDefIndex: 10146
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_PeerHandle; // 0x8
	private AntiCheatCommonClientType m_ClientType; // 0x10
	private AntiCheatCommonClientPlatform m_ClientPlatform; // 0x14
	private uint m_AuthenticationTimeout; // 0x18
	private IntPtr m_AccountId_DEPRECATED; // 0x20
	private IntPtr m_IpAddress; // 0x28
	private IntPtr m_PeerProductUserId; // 0x30

	// Properties
	public IntPtr PeerHandle { set; }
	public AntiCheatCommonClientType ClientType { set; }
	public AntiCheatCommonClientPlatform ClientPlatform { set; }
	public uint AuthenticationTimeout { set; }
	public Utf8String AccountId_DEPRECATED { set; }
	public Utf8String IpAddress { set; }
	public ProductUserId PeerProductUserId { set; }

	// Methods

	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_PeerHandle(IntPtr value) { }

	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_ClientType(AntiCheatCommonClientType value) { }

	// RVA: 0x426530 Offset: 0x425730 VA: 0x180426530
	public void set_ClientPlatform(AntiCheatCommonClientPlatform value) { }

	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	public void set_AuthenticationTimeout(uint value) { }

	// RVA: 0x437F60 Offset: 0x437160 VA: 0x180437F60
	public void set_AccountId_DEPRECATED(Utf8String value) { }

	// RVA: 0x437FC0 Offset: 0x4371C0 VA: 0x180437FC0
	public void set_IpAddress(Utf8String value) { }

	// RVA: 0x438020 Offset: 0x437220 VA: 0x180438020
	public void set_PeerProductUserId(ProductUserId value) { }

	// RVA: 0x437C80 Offset: 0x436E80 VA: 0x180437C80 Slot: 4
	public void Set(ref RegisterPeerOptions other) { }

	// RVA: 0x437D90 Offset: 0x436F90 VA: 0x180437D90 Slot: 5
	public void Set(ref Nullable<RegisterPeerOptions> other) { }

	// RVA: 0x437C10 Offset: 0x436E10 VA: 0x180437C10 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.AntiCheatClient
public struct UnprotectMessageOptions // TypeDefIndex: 10147
{
	// Fields
	[CompilerGenerated]
	private ArraySegment<byte> <Data>k__BackingField; // 0x0
	[CompilerGenerated]
	private uint <OutBufferSizeBytes>k__BackingField; // 0x10

	// Properties
	public ArraySegment<byte> Data { get; set; }
	public uint OutBufferSizeBytes { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x4354A0 Offset: 0x4346A0 VA: 0x1804354A0
	public ArraySegment<byte> get_Data() { }

	[CompilerGenerated]
	// RVA: 0x4354B0 Offset: 0x4346B0 VA: 0x1804354B0
	public void set_Data(ArraySegment<byte> value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public uint get_OutBufferSizeBytes() { }

	[CompilerGenerated]
	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_OutBufferSizeBytes(uint value) { }
}

// Namespace: Epic.OnlineServices.AntiCheatClient
internal struct UnprotectMessageOptionsInternal : ISettable<UnprotectMessageOptions>, IDisposable // TypeDefIndex: 10148
{
	// Fields
	private int m_ApiVersion; // 0x0
	private uint m_DataLengthBytes; // 0x4
	private IntPtr m_Data; // 0x8
	private uint m_OutBufferSizeBytes; // 0x10

	// Properties
	public ArraySegment<byte> Data { set; }
	public uint OutBufferSizeBytes { set; }

	// Methods

	// RVA: 0x439DC0 Offset: 0x438FC0 VA: 0x180439DC0
	public void set_Data(ArraySegment<byte> value) { }

	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_OutBufferSizeBytes(uint value) { }

	// RVA: 0x439C60 Offset: 0x438E60 VA: 0x180439C60 Slot: 4
	public void Set(ref UnprotectMessageOptions other) { }

	// RVA: 0x439CE0 Offset: 0x438EE0 VA: 0x180439CE0 Slot: 5
	public void Set(ref Nullable<UnprotectMessageOptions> other) { }

	// RVA: 0x439C10 Offset: 0x438E10 VA: 0x180439C10 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.AntiCheatClient
public struct UnregisterPeerOptions // TypeDefIndex: 10149
{
	// Fields
	[CompilerGenerated]
	private IntPtr <PeerHandle>k__BackingField; // 0x0

	// Properties
	public IntPtr PeerHandle { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public IntPtr get_PeerHandle() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_PeerHandle(IntPtr value) { }
}

// Namespace: Epic.OnlineServices.AntiCheatClient
internal struct UnregisterPeerOptionsInternal : ISettable<UnregisterPeerOptions>, IDisposable // TypeDefIndex: 10150
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_PeerHandle; // 0x8

	// Properties
	public IntPtr PeerHandle { set; }

	// Methods

	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_PeerHandle(IntPtr value) { }

	// RVA: 0x40DD30 Offset: 0x40CF30 VA: 0x18040DD30 Slot: 4
	public void Set(ref UnregisterPeerOptions other) { }

	// RVA: 0x439E80 Offset: 0x439080 VA: 0x180439E80 Slot: 5
	public void Set(ref Nullable<UnregisterPeerOptions> other) { }

	// RVA: 0x439E30 Offset: 0x439030 VA: 0x180439E30 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.ReceiptValidator
public struct AndroidIAPVerifyPurchaseOptions // TypeDefIndex: 10151
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private ProductUserId <TargetUserId>k__BackingField; // 0x8
	[CompilerGenerated]
	private ReceiptValidatorVendorType <VendorType>k__BackingField; // 0x10
	[CompilerGenerated]
	private ReceiptValidatorEntitlementType <EntitlementType>k__BackingField; // 0x14
	[CompilerGenerated]
	private Nullable<AndroidIAPVerifyPurchaseOptionsPlatformSpecificOptions> <PlatformSpecificOptions>k__BackingField; // 0x18

	// Properties
	public ProductUserId LocalUserId { get; set; }
	public ProductUserId TargetUserId { get; set; }
	public ReceiptValidatorVendorType VendorType { get; set; }
	public ReceiptValidatorEntitlementType EntitlementType { get; set; }
	public Nullable<AndroidIAPVerifyPurchaseOptionsPlatformSpecificOptions> PlatformSpecificOptions { get; set; }

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
	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public ReceiptValidatorVendorType get_VendorType() { }

	[CompilerGenerated]
	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_VendorType(ReceiptValidatorVendorType value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500
	public ReceiptValidatorEntitlementType get_EntitlementType() { }

	[CompilerGenerated]
	// RVA: 0x426530 Offset: 0x425730 VA: 0x180426530
	public void set_EntitlementType(ReceiptValidatorEntitlementType value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x426510 Offset: 0x425710 VA: 0x180426510
	public Nullable<AndroidIAPVerifyPurchaseOptionsPlatformSpecificOptions> get_PlatformSpecificOptions() { }

	[CompilerGenerated]
	// RVA: 0x426540 Offset: 0x425740 VA: 0x180426540
	public void set_PlatformSpecificOptions(Nullable<AndroidIAPVerifyPurchaseOptionsPlatformSpecificOptions> value) { }
}

// Namespace: Epic.OnlineServices.ReceiptValidator
internal struct AndroidIAPVerifyPurchaseOptionsInternal : ISettable<AndroidIAPVerifyPurchaseOptions>, IDisposable // TypeDefIndex: 10152
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_TargetUserId; // 0x10
	private ReceiptValidatorVendorType m_VendorType; // 0x18
	private ReceiptValidatorEntitlementType m_EntitlementType; // 0x1C
	private IntPtr m_PlatformSpecificOptions; // 0x20

	// Properties
	public ProductUserId LocalUserId { set; }
	public ProductUserId TargetUserId { set; }
	public ReceiptValidatorVendorType VendorType { set; }
	public ReceiptValidatorEntitlementType EntitlementType { set; }
	public Nullable<AndroidIAPVerifyPurchaseOptionsPlatformSpecificOptions> PlatformSpecificOptions { set; }

	// Methods

	// RVA: 0x425F10 Offset: 0x425110 VA: 0x180425F10
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x425FE0 Offset: 0x4251E0 VA: 0x180425FE0
	public void set_TargetUserId(ProductUserId value) { }

	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	public void set_VendorType(ReceiptValidatorVendorType value) { }

	// RVA: 0x3F9290 Offset: 0x3F8490 VA: 0x1803F9290
	public void set_EntitlementType(ReceiptValidatorEntitlementType value) { }

	// RVA: 0x425F70 Offset: 0x425170 VA: 0x180425F70
	public void set_PlatformSpecificOptions(Nullable<AndroidIAPVerifyPurchaseOptionsPlatformSpecificOptions> value) { }

	// RVA: 0x425DE0 Offset: 0x424FE0 VA: 0x180425DE0 Slot: 4
	public void Set(ref AndroidIAPVerifyPurchaseOptions other) { }

	// RVA: 0x425C20 Offset: 0x424E20 VA: 0x180425C20 Slot: 5
	public void Set(ref Nullable<AndroidIAPVerifyPurchaseOptions> other) { }

	// RVA: 0x425BC0 Offset: 0x424DC0 VA: 0x180425BC0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.ReceiptValidator
public struct AndroidIAPVerifyPurchaseOptionsPlatformSpecificOptions // TypeDefIndex: 10153
{
	// Fields
	[CompilerGenerated]
	private Utf8String <ProductId>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <Token>k__BackingField; // 0x8

	// Properties
	public Utf8String ProductId { get; set; }
	public Utf8String Token { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Utf8String get_ProductId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_ProductId(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public Utf8String get_Token() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_Token(Utf8String value) { }

	// RVA: 0x426420 Offset: 0x425620 VA: 0x180426420
	internal void Set(ref AndroidIAPVerifyPurchaseOptionsPlatformSpecificOptionsInternal other) { }
}

// Namespace: Epic.OnlineServices.ReceiptValidator
internal struct AndroidIAPVerifyPurchaseOptionsPlatformSpecificOptionsInternal : IGettable<AndroidIAPVerifyPurchaseOptionsPlatformSpecificOptions>, ISettable<AndroidIAPVerifyPurchaseOptionsPlatformSpecificOptions>, IDisposable // TypeDefIndex: 10154
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_ProductId; // 0x8
	private IntPtr m_Token; // 0x10

	// Properties
	public Utf8String ProductId { get; set; }
	public Utf8String Token { get; set; }

	// Methods

	// RVA: 0x426280 Offset: 0x425480 VA: 0x180426280
	public Utf8String get_ProductId() { }

	// RVA: 0x426360 Offset: 0x425560 VA: 0x180426360
	public void set_ProductId(Utf8String value) { }

	// RVA: 0x4262F0 Offset: 0x4254F0 VA: 0x1804262F0
	public Utf8String get_Token() { }

	// RVA: 0x4263C0 Offset: 0x4255C0 VA: 0x1804263C0
	public void set_Token(Utf8String value) { }

	// RVA: 0x4260C0 Offset: 0x4252C0 VA: 0x1804260C0 Slot: 5
	public void Set(ref AndroidIAPVerifyPurchaseOptionsPlatformSpecificOptions other) { }

	// RVA: 0x426180 Offset: 0x425380 VA: 0x180426180 Slot: 6
	public void Set(ref Nullable<AndroidIAPVerifyPurchaseOptionsPlatformSpecificOptions> other) { }

	// RVA: 0x426040 Offset: 0x425240 VA: 0x180426040 Slot: 7
	public void Dispose() { }

	// RVA: 0x4260A0 Offset: 0x4252A0 VA: 0x1804260A0 Slot: 4
	public void Get(out AndroidIAPVerifyPurchaseOptionsPlatformSpecificOptions output) { }
}

// Namespace: Epic.OnlineServices.ReceiptValidator
public sealed class ReceiptValidatorInterface : Handle // TypeDefIndex: 10155
{
	// Fields
	public const int AndroidIapverifypurchaseoptionsplatformspecificoptionsApiLatest = 1;
	public const int IosIapverifypurchaseoptionsplatformspecificoptionsApiLatest = 1;
	public const int Ps4DlcverifypurchaseoptionsplatformspecificoptionsApiLatest = 1;
	public const int Ps4IapverifypurchaseoptionsplatformspecificoptionsApiLatest = 1;
	public const int Ps5DlcverifypurchaseoptionsplatformspecificoptionsApiLatest = 1;
	public const int Ps5IapverifypurchaseoptionsplatformspecificoptionsApiLatest = 1;
	public const int EgsDlcverifypurchaseoptionsplatformspecificoptionsApiLatest = 1;
	public const int EgsIapverifypurchaseoptionsplatformspecificoptionsApiLatest = 1;
	public const int SteamDlcverifypurchaseoptionsplatformspecificoptionsApiLatest = 1;
	public const int SteamIapverifypurchaseoptionsplatformspecificoptionsApiLatest = 1;
	public const int VerifypurchaseApiLatest = 1;
	public const int SwitchIapverifypurchaseoptionsplatformspecificoptionsApiLatest = 1;
	public const int XboxonegdkDlcverifypurchaseoptionsplatformspecificoptionsApiLatest = 1;
	public const int XboxonegdkIapverifypurchaseoptionsplatformspecificoptionsApiLatest = 1;
	public const int XsxDlcverifypurchaseoptionsplatformspecificoptionsApiLatest = 1;
	public const int XsxIapverifypurchaseoptionsplatformspecificoptionsApiLatest = 1;

	// Methods

	// RVA: 0x436680 Offset: 0x435880 VA: 0x180436680
	public void VerifyPurchase(ref AndroidIAPVerifyPurchaseOptions options, object clientData, OnVerifyPurchaseCompleteCallback completionDelegate) { }

	// RVA: 0x435E60 Offset: 0x435060 VA: 0x180435E60
	public void VerifyPurchase(ref IOSIAPVerifyPurchaseOptions options, object clientData, OnVerifyPurchaseCompleteCallback completionDelegate) { }

	// RVA: 0x4364E0 Offset: 0x4356E0 VA: 0x1804364E0
	public void VerifyPurchase(ref PS4IAPVerifyPurchaseOptions options, object clientData, OnVerifyPurchaseCompleteCallback completionDelegate) { }

	// RVA: 0x436340 Offset: 0x435540 VA: 0x180436340
	public void VerifyPurchase(ref PS4DLCVerifyPurchaseOptions options, object clientData, OnVerifyPurchaseCompleteCallback completionDelegate) { }

	// RVA: 0x435CC0 Offset: 0x434EC0 VA: 0x180435CC0
	public void VerifyPurchase(ref PS5IAPVerifyPurchaseOptions options, object clientData, OnVerifyPurchaseCompleteCallback completionDelegate) { }

	// RVA: 0x4361A0 Offset: 0x4353A0 VA: 0x1804361A0
	public void VerifyPurchase(ref PS5DLCVerifyPurchaseOptions options, object clientData, OnVerifyPurchaseCompleteCallback completionDelegate) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }

	// RVA: 0x40BDB0 Offset: 0x40AFB0 VA: 0x18040BDB0
	public void .ctor(IntPtr innerHandle) { }

	// RVA: 0x4357E0 Offset: 0x4349E0 VA: 0x1804357E0
	public void VerifyPurchase(ref VerifyPurchaseOptions options, object clientData, OnVerifyPurchaseCompleteCallback completionDelegate) { }

	// RVA: 0x436D00 Offset: 0x435F00 VA: 0x180436D00
	public void VerifyPurchase(ref SteamIAPVerifyPurchaseOptions options, object clientData, OnVerifyPurchaseCompleteCallback completionDelegate) { }

	// RVA: 0x4369C0 Offset: 0x435BC0 VA: 0x1804369C0
	public void VerifyPurchase(ref SteamDLCVerifyPurchaseOptions options, object clientData, OnVerifyPurchaseCompleteCallback completionDelegate) { }

	// RVA: 0x436EA0 Offset: 0x4360A0 VA: 0x180436EA0
	public void VerifyPurchase(ref EGSIAPVerifyPurchaseOptions options, object clientData, OnVerifyPurchaseCompleteCallback completionDelegate) { }

	// RVA: 0x436B60 Offset: 0x435D60 VA: 0x180436B60
	public void VerifyPurchase(ref EGSDLCVerifyPurchaseOptions options, object clientData, OnVerifyPurchaseCompleteCallback completionDelegate) { }

	[MonoPInvokeCallback(typeof(OnVerifyPurchaseCompleteCallbackInternal))]
	// RVA: 0x435740 Offset: 0x434940 VA: 0x180435740
	internal static void OnVerifyPurchaseCompleteCallbackInternalImplementation(ref VerifyPurchaseCompleteCallbackInfoInternal data) { }

	// RVA: 0x437040 Offset: 0x436240 VA: 0x180437040
	public void VerifyPurchase(ref SwitchIAPVerifyPurchaseOptions options, object clientData, OnVerifyPurchaseCompleteCallback completionDelegate) { }

	// RVA: 0x435980 Offset: 0x434B80 VA: 0x180435980
	public void VerifyPurchase(ref XboxOneGDKIAPVerifyPurchaseOptions options, object clientData, OnVerifyPurchaseCompleteCallback completionDelegate) { }

	// RVA: 0x435B20 Offset: 0x434D20 VA: 0x180435B20
	public void VerifyPurchase(ref XboxOneGDKDLCVerifyPurchaseOptions options, object clientData, OnVerifyPurchaseCompleteCallback completionDelegate) { }

	// RVA: 0x436820 Offset: 0x435A20 VA: 0x180436820
	public void VerifyPurchase(ref XSXIAPVerifyPurchaseOptions options, object clientData, OnVerifyPurchaseCompleteCallback completionDelegate) { }

	// RVA: 0x436000 Offset: 0x435200 VA: 0x180436000
	public void VerifyPurchase(ref XSXDLCVerifyPurchaseOptions options, object clientData, OnVerifyPurchaseCompleteCallback completionDelegate) { }
}

// Namespace: Epic.OnlineServices.ReceiptValidator
public struct IOSIAPVerifyPurchaseOptions // TypeDefIndex: 10156
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private ProductUserId <TargetUserId>k__BackingField; // 0x8
	[CompilerGenerated]
	private ReceiptValidatorVendorType <VendorType>k__BackingField; // 0x10
	[CompilerGenerated]
	private ReceiptValidatorEntitlementType <EntitlementType>k__BackingField; // 0x14
	[CompilerGenerated]
	private Nullable<IOSIAPVerifyPurchaseOptionsPlatformSpecificOptions> <PlatformSpecificOptions>k__BackingField; // 0x18

	// Properties
	public ProductUserId LocalUserId { get; set; }
	public ProductUserId TargetUserId { get; set; }
	public ReceiptValidatorVendorType VendorType { get; set; }
	public ReceiptValidatorEntitlementType EntitlementType { get; set; }
	public Nullable<IOSIAPVerifyPurchaseOptionsPlatformSpecificOptions> PlatformSpecificOptions { get; set; }

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
	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public ReceiptValidatorVendorType get_VendorType() { }

	[CompilerGenerated]
	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_VendorType(ReceiptValidatorVendorType value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500
	public ReceiptValidatorEntitlementType get_EntitlementType() { }

	[CompilerGenerated]
	// RVA: 0x426530 Offset: 0x425730 VA: 0x180426530
	public void set_EntitlementType(ReceiptValidatorEntitlementType value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x426510 Offset: 0x425710 VA: 0x180426510
	public Nullable<IOSIAPVerifyPurchaseOptionsPlatformSpecificOptions> get_PlatformSpecificOptions() { }

	[CompilerGenerated]
	// RVA: 0x426540 Offset: 0x425740 VA: 0x180426540
	public void set_PlatformSpecificOptions(Nullable<IOSIAPVerifyPurchaseOptionsPlatformSpecificOptions> value) { }
}

// Namespace: Epic.OnlineServices.ReceiptValidator
internal struct IOSIAPVerifyPurchaseOptionsInternal : ISettable<IOSIAPVerifyPurchaseOptions>, IDisposable // TypeDefIndex: 10157
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_TargetUserId; // 0x10
	private ReceiptValidatorVendorType m_VendorType; // 0x18
	private ReceiptValidatorEntitlementType m_EntitlementType; // 0x1C
	private IntPtr m_PlatformSpecificOptions; // 0x20

	// Properties
	public ProductUserId LocalUserId { set; }
	public ProductUserId TargetUserId { set; }
	public ReceiptValidatorVendorType VendorType { set; }
	public ReceiptValidatorEntitlementType EntitlementType { set; }
	public Nullable<IOSIAPVerifyPurchaseOptionsPlatformSpecificOptions> PlatformSpecificOptions { set; }

	// Methods

	// RVA: 0x42A9F0 Offset: 0x429BF0 VA: 0x18042A9F0
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x42AAC0 Offset: 0x429CC0 VA: 0x18042AAC0
	public void set_TargetUserId(ProductUserId value) { }

	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	public void set_VendorType(ReceiptValidatorVendorType value) { }

	// RVA: 0x3F9290 Offset: 0x3F8490 VA: 0x1803F9290
	public void set_EntitlementType(ReceiptValidatorEntitlementType value) { }

	// RVA: 0x42AA50 Offset: 0x429C50 VA: 0x18042AA50
	public void set_PlatformSpecificOptions(Nullable<IOSIAPVerifyPurchaseOptionsPlatformSpecificOptions> value) { }

	// RVA: 0x42A8C0 Offset: 0x429AC0 VA: 0x18042A8C0 Slot: 4
	public void Set(ref IOSIAPVerifyPurchaseOptions other) { }

	// RVA: 0x42A700 Offset: 0x429900 VA: 0x18042A700 Slot: 5
	public void Set(ref Nullable<IOSIAPVerifyPurchaseOptions> other) { }

	// RVA: 0x42A6A0 Offset: 0x4298A0 VA: 0x18042A6A0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.ReceiptValidator
public struct IOSIAPVerifyPurchaseOptionsPlatformSpecificOptions // TypeDefIndex: 10158
{
	// Fields
	[CompilerGenerated]
	private Utf8String <TransactionId>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <Receipt>k__BackingField; // 0x8

	// Properties
	public Utf8String TransactionId { get; set; }
	public Utf8String Receipt { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Utf8String get_TransactionId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_TransactionId(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public Utf8String get_Receipt() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_Receipt(Utf8String value) { }

	// RVA: 0x42AF00 Offset: 0x42A100 VA: 0x18042AF00
	internal void Set(ref IOSIAPVerifyPurchaseOptionsPlatformSpecificOptionsInternal other) { }
}

// Namespace: Epic.OnlineServices.ReceiptValidator
internal struct IOSIAPVerifyPurchaseOptionsPlatformSpecificOptionsInternal : IGettable<IOSIAPVerifyPurchaseOptionsPlatformSpecificOptions>, ISettable<IOSIAPVerifyPurchaseOptionsPlatformSpecificOptions>, IDisposable // TypeDefIndex: 10159
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_TransactionId; // 0x8
	private IntPtr m_Receipt; // 0x10

	// Properties
	public Utf8String TransactionId { get; set; }
	public Utf8String Receipt { get; set; }

	// Methods

	// RVA: 0x42ADD0 Offset: 0x429FD0 VA: 0x18042ADD0
	public Utf8String get_TransactionId() { }

	// RVA: 0x42AEA0 Offset: 0x42A0A0 VA: 0x18042AEA0
	public void set_TransactionId(Utf8String value) { }

	// RVA: 0x42AD60 Offset: 0x429F60 VA: 0x18042AD60
	public Utf8String get_Receipt() { }

	// RVA: 0x42AE40 Offset: 0x42A040 VA: 0x18042AE40
	public void set_Receipt(Utf8String value) { }

	// RVA: 0x42ACA0 Offset: 0x429EA0 VA: 0x18042ACA0 Slot: 5
	public void Set(ref IOSIAPVerifyPurchaseOptionsPlatformSpecificOptions other) { }

	// RVA: 0x42ABA0 Offset: 0x429DA0 VA: 0x18042ABA0 Slot: 6
	public void Set(ref Nullable<IOSIAPVerifyPurchaseOptionsPlatformSpecificOptions> other) { }

	// RVA: 0x42AB20 Offset: 0x429D20 VA: 0x18042AB20 Slot: 7
	public void Dispose() { }

	// RVA: 0x42AB80 Offset: 0x429D80 VA: 0x18042AB80 Slot: 4
	public void Get(out IOSIAPVerifyPurchaseOptionsPlatformSpecificOptions output) { }
}

// Namespace: Epic.OnlineServices.ReceiptValidator
public struct PS4DLCVerifyPurchaseOptions // TypeDefIndex: 10160
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private ProductUserId <TargetUserId>k__BackingField; // 0x8
	[CompilerGenerated]
	private ReceiptValidatorVendorType <VendorType>k__BackingField; // 0x10
	[CompilerGenerated]
	private ReceiptValidatorEntitlementType <EntitlementType>k__BackingField; // 0x14
	[CompilerGenerated]
	private Nullable<PS4DLCVerifyPurchaseOptionsPlatformSpecificOptions> <PlatformSpecificOptions>k__BackingField; // 0x18

	// Properties
	public ProductUserId LocalUserId { get; set; }
	public ProductUserId TargetUserId { get; set; }
	public ReceiptValidatorVendorType VendorType { get; set; }
	public ReceiptValidatorEntitlementType EntitlementType { get; set; }
	public Nullable<PS4DLCVerifyPurchaseOptionsPlatformSpecificOptions> PlatformSpecificOptions { get; set; }

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

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public ReceiptValidatorVendorType get_VendorType() { }

	[CompilerGenerated]
	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_VendorType(ReceiptValidatorVendorType value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500
	public ReceiptValidatorEntitlementType get_EntitlementType() { }

	[CompilerGenerated]
	// RVA: 0x426530 Offset: 0x425730 VA: 0x180426530
	public void set_EntitlementType(ReceiptValidatorEntitlementType value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x41A1E0 Offset: 0x4193E0 VA: 0x18041A1E0
	public Nullable<PS4DLCVerifyPurchaseOptionsPlatformSpecificOptions> get_PlatformSpecificOptions() { }

	[CompilerGenerated]
	// RVA: 0x41A210 Offset: 0x419410 VA: 0x18041A210
	public void set_PlatformSpecificOptions(Nullable<PS4DLCVerifyPurchaseOptionsPlatformSpecificOptions> value) { }
}

// Namespace: Epic.OnlineServices.ReceiptValidator
internal struct PS4DLCVerifyPurchaseOptionsInternal : ISettable<PS4DLCVerifyPurchaseOptions>, IDisposable // TypeDefIndex: 10161
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_TargetUserId; // 0x10
	private ReceiptValidatorVendorType m_VendorType; // 0x18
	private ReceiptValidatorEntitlementType m_EntitlementType; // 0x1C
	private IntPtr m_PlatformSpecificOptions; // 0x20

	// Properties
	public ProductUserId LocalUserId { set; }
	public ProductUserId TargetUserId { set; }
	public ReceiptValidatorVendorType VendorType { set; }
	public ReceiptValidatorEntitlementType EntitlementType { set; }
	public Nullable<PS4DLCVerifyPurchaseOptionsPlatformSpecificOptions> PlatformSpecificOptions { set; }

	// Methods

	// RVA: 0x42DC70 Offset: 0x42CE70 VA: 0x18042DC70
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x42DD40 Offset: 0x42CF40 VA: 0x18042DD40
	public void set_TargetUserId(ProductUserId value) { }

	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	public void set_VendorType(ReceiptValidatorVendorType value) { }

	// RVA: 0x3F9290 Offset: 0x3F8490 VA: 0x1803F9290
	public void set_EntitlementType(ReceiptValidatorEntitlementType value) { }

	// RVA: 0x42DCD0 Offset: 0x42CED0 VA: 0x18042DCD0
	public void set_PlatformSpecificOptions(Nullable<PS4DLCVerifyPurchaseOptionsPlatformSpecificOptions> value) { }

	// RVA: 0x42DB40 Offset: 0x42CD40 VA: 0x18042DB40 Slot: 4
	public void Set(ref PS4DLCVerifyPurchaseOptions other) { }

	// RVA: 0x42D970 Offset: 0x42CB70 VA: 0x18042D970 Slot: 5
	public void Set(ref Nullable<PS4DLCVerifyPurchaseOptions> other) { }

	// RVA: 0x42D910 Offset: 0x42CB10 VA: 0x18042D910 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.ReceiptValidator
public struct PS4DLCVerifyPurchaseOptionsPlatformSpecificOptions // TypeDefIndex: 10162
{
	// Fields
	[CompilerGenerated]
	private Utf8String <EntitlementLabel>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <ServiceLabel>k__BackingField; // 0x8
	[CompilerGenerated]
	private Utf8String <IdToken>k__BackingField; // 0x10
	[CompilerGenerated]
	private Utf8String <AccessToken>k__BackingField; // 0x18

	// Properties
	public Utf8String EntitlementLabel { get; set; }
	public Utf8String ServiceLabel { get; set; }
	public Utf8String IdToken { get; set; }
	public Utf8String AccessToken { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Utf8String get_EntitlementLabel() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_EntitlementLabel(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public Utf8String get_ServiceLabel() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_ServiceLabel(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Utf8String get_IdToken() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_IdToken(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public Utf8String get_AccessToken() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_AccessToken(Utf8String value) { }

	// RVA: 0x42E460 Offset: 0x42D660 VA: 0x18042E460
	internal void Set(ref PS4DLCVerifyPurchaseOptionsPlatformSpecificOptionsInternal other) { }
}

// Namespace: Epic.OnlineServices.ReceiptValidator
internal struct PS4DLCVerifyPurchaseOptionsPlatformSpecificOptionsInternal : IGettable<PS4DLCVerifyPurchaseOptionsPlatformSpecificOptions>, ISettable<PS4DLCVerifyPurchaseOptionsPlatformSpecificOptions>, IDisposable // TypeDefIndex: 10163
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_EntitlementLabel; // 0x8
	private IntPtr m_ServiceLabel; // 0x10
	private IntPtr m_IdToken; // 0x18
	private IntPtr m_AccessToken; // 0x20

	// Properties
	public Utf8String EntitlementLabel { get; set; }
	public Utf8String ServiceLabel { get; set; }
	public Utf8String IdToken { get; set; }
	public Utf8String AccessToken { get; set; }

	// Methods

	// RVA: 0x42E190 Offset: 0x42D390 VA: 0x18042E190
	public Utf8String get_EntitlementLabel() { }

	// RVA: 0x42E340 Offset: 0x42D540 VA: 0x18042E340
	public void set_EntitlementLabel(Utf8String value) { }

	// RVA: 0x42E270 Offset: 0x42D470 VA: 0x18042E270
	public Utf8String get_ServiceLabel() { }

	// RVA: 0x42E400 Offset: 0x42D600 VA: 0x18042E400
	public void set_ServiceLabel(Utf8String value) { }

	// RVA: 0x42E200 Offset: 0x42D400 VA: 0x18042E200
	public Utf8String get_IdToken() { }

	// RVA: 0x42E3A0 Offset: 0x42D5A0 VA: 0x18042E3A0
	public void set_IdToken(Utf8String value) { }

	// RVA: 0x42E120 Offset: 0x42D320 VA: 0x18042E120
	public Utf8String get_AccessToken() { }

	// RVA: 0x42E2E0 Offset: 0x42D4E0 VA: 0x18042E2E0
	public void set_AccessToken(Utf8String value) { }

	// RVA: 0x42DE30 Offset: 0x42D030 VA: 0x18042DE30 Slot: 5
	public void Set(ref PS4DLCVerifyPurchaseOptionsPlatformSpecificOptions other) { }

	// RVA: 0x42DF70 Offset: 0x42D170 VA: 0x18042DF70 Slot: 6
	public void Set(ref Nullable<PS4DLCVerifyPurchaseOptionsPlatformSpecificOptions> other) { }

	// RVA: 0x42DDA0 Offset: 0x42CFA0 VA: 0x18042DDA0 Slot: 7
	public void Dispose() { }

	// RVA: 0x42DE10 Offset: 0x42D010 VA: 0x18042DE10 Slot: 4
	public void Get(out PS4DLCVerifyPurchaseOptionsPlatformSpecificOptions output) { }
}

// Namespace: Epic.OnlineServices.ReceiptValidator
public struct PS4IAPVerifyPurchaseOptions // TypeDefIndex: 10164
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private ProductUserId <TargetUserId>k__BackingField; // 0x8
	[CompilerGenerated]
	private ReceiptValidatorVendorType <VendorType>k__BackingField; // 0x10
	[CompilerGenerated]
	private ReceiptValidatorEntitlementType <EntitlementType>k__BackingField; // 0x14
	[CompilerGenerated]
	private Nullable<PS4IAPVerifyPurchaseOptionsPlatformSpecificOptions> <PlatformSpecificOptions>k__BackingField; // 0x18

	// Properties
	public ProductUserId LocalUserId { get; set; }
	public ProductUserId TargetUserId { get; set; }
	public ReceiptValidatorVendorType VendorType { get; set; }
	public ReceiptValidatorEntitlementType EntitlementType { get; set; }
	public Nullable<PS4IAPVerifyPurchaseOptionsPlatformSpecificOptions> PlatformSpecificOptions { get; set; }

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

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public ReceiptValidatorVendorType get_VendorType() { }

	[CompilerGenerated]
	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_VendorType(ReceiptValidatorVendorType value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500
	public ReceiptValidatorEntitlementType get_EntitlementType() { }

	[CompilerGenerated]
	// RVA: 0x426530 Offset: 0x425730 VA: 0x180426530
	public void set_EntitlementType(ReceiptValidatorEntitlementType value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x41A1E0 Offset: 0x4193E0 VA: 0x18041A1E0
	public Nullable<PS4IAPVerifyPurchaseOptionsPlatformSpecificOptions> get_PlatformSpecificOptions() { }

	[CompilerGenerated]
	// RVA: 0x41A210 Offset: 0x419410 VA: 0x18041A210
	public void set_PlatformSpecificOptions(Nullable<PS4IAPVerifyPurchaseOptionsPlatformSpecificOptions> value) { }
}

// Namespace: Epic.OnlineServices.ReceiptValidator
internal struct PS4IAPVerifyPurchaseOptionsInternal : ISettable<PS4IAPVerifyPurchaseOptions>, IDisposable // TypeDefIndex: 10165
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_TargetUserId; // 0x10
	private ReceiptValidatorVendorType m_VendorType; // 0x18
	private ReceiptValidatorEntitlementType m_EntitlementType; // 0x1C
	private IntPtr m_PlatformSpecificOptions; // 0x20

	// Properties
	public ProductUserId LocalUserId { set; }
	public ProductUserId TargetUserId { set; }
	public ReceiptValidatorVendorType VendorType { set; }
	public ReceiptValidatorEntitlementType EntitlementType { set; }
	public Nullable<PS4IAPVerifyPurchaseOptionsPlatformSpecificOptions> PlatformSpecificOptions { set; }

	// Methods

	// RVA: 0x42E940 Offset: 0x42DB40 VA: 0x18042E940
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x42EA10 Offset: 0x42DC10 VA: 0x18042EA10
	public void set_TargetUserId(ProductUserId value) { }

	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	public void set_VendorType(ReceiptValidatorVendorType value) { }

	// RVA: 0x3F9290 Offset: 0x3F8490 VA: 0x1803F9290
	public void set_EntitlementType(ReceiptValidatorEntitlementType value) { }

	// RVA: 0x42E9A0 Offset: 0x42DBA0 VA: 0x18042E9A0
	public void set_PlatformSpecificOptions(Nullable<PS4IAPVerifyPurchaseOptionsPlatformSpecificOptions> value) { }

	// RVA: 0x42E640 Offset: 0x42D840 VA: 0x18042E640 Slot: 4
	public void Set(ref PS4IAPVerifyPurchaseOptions other) { }

	// RVA: 0x42E770 Offset: 0x42D970 VA: 0x18042E770 Slot: 5
	public void Set(ref Nullable<PS4IAPVerifyPurchaseOptions> other) { }

	// RVA: 0x42E5E0 Offset: 0x42D7E0 VA: 0x18042E5E0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.ReceiptValidator
public struct PS4IAPVerifyPurchaseOptionsPlatformSpecificOptions // TypeDefIndex: 10166
{
	// Fields
	[CompilerGenerated]
	private Utf8String <EntitlementLabel>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <ServiceLabel>k__BackingField; // 0x8
	[CompilerGenerated]
	private Utf8String <IdToken>k__BackingField; // 0x10
	[CompilerGenerated]
	private Utf8String <AccessToken>k__BackingField; // 0x18

	// Properties
	public Utf8String EntitlementLabel { get; set; }
	public Utf8String ServiceLabel { get; set; }
	public Utf8String IdToken { get; set; }
	public Utf8String AccessToken { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Utf8String get_EntitlementLabel() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_EntitlementLabel(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public Utf8String get_ServiceLabel() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_ServiceLabel(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Utf8String get_IdToken() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_IdToken(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public Utf8String get_AccessToken() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_AccessToken(Utf8String value) { }

	// RVA: 0x42F130 Offset: 0x42E330 VA: 0x18042F130
	internal void Set(ref PS4IAPVerifyPurchaseOptionsPlatformSpecificOptionsInternal other) { }
}

// Namespace: Epic.OnlineServices.ReceiptValidator
internal struct PS4IAPVerifyPurchaseOptionsPlatformSpecificOptionsInternal : IGettable<PS4IAPVerifyPurchaseOptionsPlatformSpecificOptions>, ISettable<PS4IAPVerifyPurchaseOptionsPlatformSpecificOptions>, IDisposable // TypeDefIndex: 10167
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_EntitlementLabel; // 0x8
	private IntPtr m_ServiceLabel; // 0x10
	private IntPtr m_IdToken; // 0x18
	private IntPtr m_AccessToken; // 0x20

	// Properties
	public Utf8String EntitlementLabel { get; set; }
	public Utf8String ServiceLabel { get; set; }
	public Utf8String IdToken { get; set; }
	public Utf8String AccessToken { get; set; }

	// Methods

	// RVA: 0x42EE60 Offset: 0x42E060 VA: 0x18042EE60
	public Utf8String get_EntitlementLabel() { }

	// RVA: 0x42F010 Offset: 0x42E210 VA: 0x18042F010
	public void set_EntitlementLabel(Utf8String value) { }

	// RVA: 0x42EF40 Offset: 0x42E140 VA: 0x18042EF40
	public Utf8String get_ServiceLabel() { }

	// RVA: 0x42F0D0 Offset: 0x42E2D0 VA: 0x18042F0D0
	public void set_ServiceLabel(Utf8String value) { }

	// RVA: 0x42EED0 Offset: 0x42E0D0 VA: 0x18042EED0
	public Utf8String get_IdToken() { }

	// RVA: 0x42F070 Offset: 0x42E270 VA: 0x18042F070
	public void set_IdToken(Utf8String value) { }

	// RVA: 0x42EDF0 Offset: 0x42DFF0 VA: 0x18042EDF0
	public Utf8String get_AccessToken() { }

	// RVA: 0x42EFB0 Offset: 0x42E1B0 VA: 0x18042EFB0
	public void set_AccessToken(Utf8String value) { }

	// RVA: 0x42EB00 Offset: 0x42DD00 VA: 0x18042EB00 Slot: 5
	public void Set(ref PS4IAPVerifyPurchaseOptionsPlatformSpecificOptions other) { }

	// RVA: 0x42EC40 Offset: 0x42DE40 VA: 0x18042EC40 Slot: 6
	public void Set(ref Nullable<PS4IAPVerifyPurchaseOptionsPlatformSpecificOptions> other) { }

	// RVA: 0x42EA70 Offset: 0x42DC70 VA: 0x18042EA70 Slot: 7
	public void Dispose() { }

	// RVA: 0x42EAE0 Offset: 0x42DCE0 VA: 0x18042EAE0 Slot: 4
	public void Get(out PS4IAPVerifyPurchaseOptionsPlatformSpecificOptions output) { }
}

// Namespace: Epic.OnlineServices.ReceiptValidator
public struct PS5DLCVerifyPurchaseOptions // TypeDefIndex: 10168
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private ProductUserId <TargetUserId>k__BackingField; // 0x8
	[CompilerGenerated]
	private ReceiptValidatorVendorType <VendorType>k__BackingField; // 0x10
	[CompilerGenerated]
	private ReceiptValidatorEntitlementType <EntitlementType>k__BackingField; // 0x14
	[CompilerGenerated]
	private Nullable<PS5DLCVerifyPurchaseOptionsPlatformSpecificOptions> <PlatformSpecificOptions>k__BackingField; // 0x18

	// Properties
	public ProductUserId LocalUserId { get; set; }
	public ProductUserId TargetUserId { get; set; }
	public ReceiptValidatorVendorType VendorType { get; set; }
	public ReceiptValidatorEntitlementType EntitlementType { get; set; }
	public Nullable<PS5DLCVerifyPurchaseOptionsPlatformSpecificOptions> PlatformSpecificOptions { get; set; }

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

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public ReceiptValidatorVendorType get_VendorType() { }

	[CompilerGenerated]
	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_VendorType(ReceiptValidatorVendorType value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500
	public ReceiptValidatorEntitlementType get_EntitlementType() { }

	[CompilerGenerated]
	// RVA: 0x426530 Offset: 0x425730 VA: 0x180426530
	public void set_EntitlementType(ReceiptValidatorEntitlementType value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x41A1E0 Offset: 0x4193E0 VA: 0x18041A1E0
	public Nullable<PS5DLCVerifyPurchaseOptionsPlatformSpecificOptions> get_PlatformSpecificOptions() { }

	[CompilerGenerated]
	// RVA: 0x41A210 Offset: 0x419410 VA: 0x18041A210
	public void set_PlatformSpecificOptions(Nullable<PS5DLCVerifyPurchaseOptionsPlatformSpecificOptions> value) { }
}

// Namespace: Epic.OnlineServices.ReceiptValidator
internal struct PS5DLCVerifyPurchaseOptionsInternal : ISettable<PS5DLCVerifyPurchaseOptions>, IDisposable // TypeDefIndex: 10169
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_TargetUserId; // 0x10
	private ReceiptValidatorVendorType m_VendorType; // 0x18
	private ReceiptValidatorEntitlementType m_EntitlementType; // 0x1C
	private IntPtr m_PlatformSpecificOptions; // 0x20

	// Properties
	public ProductUserId LocalUserId { set; }
	public ProductUserId TargetUserId { set; }
	public ReceiptValidatorVendorType VendorType { set; }
	public ReceiptValidatorEntitlementType EntitlementType { set; }
	public Nullable<PS5DLCVerifyPurchaseOptionsPlatformSpecificOptions> PlatformSpecificOptions { set; }

	// Methods

	// RVA: 0x430B80 Offset: 0x42FD80 VA: 0x180430B80
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x430C50 Offset: 0x42FE50 VA: 0x180430C50
	public void set_TargetUserId(ProductUserId value) { }

	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	public void set_VendorType(ReceiptValidatorVendorType value) { }

	// RVA: 0x3F9290 Offset: 0x3F8490 VA: 0x1803F9290
	public void set_EntitlementType(ReceiptValidatorEntitlementType value) { }

	// RVA: 0x430BE0 Offset: 0x42FDE0 VA: 0x180430BE0
	public void set_PlatformSpecificOptions(Nullable<PS5DLCVerifyPurchaseOptionsPlatformSpecificOptions> value) { }

	// RVA: 0x430880 Offset: 0x42FA80 VA: 0x180430880 Slot: 4
	public void Set(ref PS5DLCVerifyPurchaseOptions other) { }

	// RVA: 0x4309B0 Offset: 0x42FBB0 VA: 0x1804309B0 Slot: 5
	public void Set(ref Nullable<PS5DLCVerifyPurchaseOptions> other) { }

	// RVA: 0x430820 Offset: 0x42FA20 VA: 0x180430820 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.ReceiptValidator
public struct PS5DLCVerifyPurchaseOptionsPlatformSpecificOptions // TypeDefIndex: 10170
{
	// Fields
	[CompilerGenerated]
	private Utf8String <EntitlementLabel>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <ServiceLabel>k__BackingField; // 0x8
	[CompilerGenerated]
	private Utf8String <IdToken>k__BackingField; // 0x10
	[CompilerGenerated]
	private Utf8String <AccessToken>k__BackingField; // 0x18

	// Properties
	public Utf8String EntitlementLabel { get; set; }
	public Utf8String ServiceLabel { get; set; }
	public Utf8String IdToken { get; set; }
	public Utf8String AccessToken { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Utf8String get_EntitlementLabel() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_EntitlementLabel(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public Utf8String get_ServiceLabel() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_ServiceLabel(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Utf8String get_IdToken() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_IdToken(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public Utf8String get_AccessToken() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_AccessToken(Utf8String value) { }

	// RVA: 0x431370 Offset: 0x430570 VA: 0x180431370
	internal void Set(ref PS5DLCVerifyPurchaseOptionsPlatformSpecificOptionsInternal other) { }
}

// Namespace: Epic.OnlineServices.ReceiptValidator
internal struct PS5DLCVerifyPurchaseOptionsPlatformSpecificOptionsInternal : IGettable<PS5DLCVerifyPurchaseOptionsPlatformSpecificOptions>, ISettable<PS5DLCVerifyPurchaseOptionsPlatformSpecificOptions>, IDisposable // TypeDefIndex: 10171
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_EntitlementLabel; // 0x8
	private IntPtr m_ServiceLabel; // 0x10
	private IntPtr m_IdToken; // 0x18
	private IntPtr m_AccessToken; // 0x20

	// Properties
	public Utf8String EntitlementLabel { get; set; }
	public Utf8String ServiceLabel { get; set; }
	public Utf8String IdToken { get; set; }
	public Utf8String AccessToken { get; set; }

	// Methods

	// RVA: 0x4310A0 Offset: 0x4302A0 VA: 0x1804310A0
	public Utf8String get_EntitlementLabel() { }

	// RVA: 0x431250 Offset: 0x430450 VA: 0x180431250
	public void set_EntitlementLabel(Utf8String value) { }

	// RVA: 0x431180 Offset: 0x430380 VA: 0x180431180
	public Utf8String get_ServiceLabel() { }

	// RVA: 0x431310 Offset: 0x430510 VA: 0x180431310
	public void set_ServiceLabel(Utf8String value) { }

	// RVA: 0x431110 Offset: 0x430310 VA: 0x180431110
	public Utf8String get_IdToken() { }

	// RVA: 0x4312B0 Offset: 0x4304B0 VA: 0x1804312B0
	public void set_IdToken(Utf8String value) { }

	// RVA: 0x431030 Offset: 0x430230 VA: 0x180431030
	public Utf8String get_AccessToken() { }

	// RVA: 0x4311F0 Offset: 0x4303F0 VA: 0x1804311F0
	public void set_AccessToken(Utf8String value) { }

	// RVA: 0x430EF0 Offset: 0x4300F0 VA: 0x180430EF0 Slot: 5
	public void Set(ref PS5DLCVerifyPurchaseOptionsPlatformSpecificOptions other) { }

	// RVA: 0x430D40 Offset: 0x42FF40 VA: 0x180430D40 Slot: 6
	public void Set(ref Nullable<PS5DLCVerifyPurchaseOptionsPlatformSpecificOptions> other) { }

	// RVA: 0x430CB0 Offset: 0x42FEB0 VA: 0x180430CB0 Slot: 7
	public void Dispose() { }

	// RVA: 0x430D20 Offset: 0x42FF20 VA: 0x180430D20 Slot: 4
	public void Get(out PS5DLCVerifyPurchaseOptionsPlatformSpecificOptions output) { }
}

// Namespace: Epic.OnlineServices.ReceiptValidator
public struct PS5IAPVerifyPurchaseOptions // TypeDefIndex: 10172
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private ProductUserId <TargetUserId>k__BackingField; // 0x8
	[CompilerGenerated]
	private ReceiptValidatorVendorType <VendorType>k__BackingField; // 0x10
	[CompilerGenerated]
	private ReceiptValidatorEntitlementType <EntitlementType>k__BackingField; // 0x14
	[CompilerGenerated]
	private Nullable<PS5IAPVerifyPurchaseOptionsPlatformSpecificOptions> <PlatformSpecificOptions>k__BackingField; // 0x18

	// Properties
	public ProductUserId LocalUserId { get; set; }
	public ProductUserId TargetUserId { get; set; }
	public ReceiptValidatorVendorType VendorType { get; set; }
	public ReceiptValidatorEntitlementType EntitlementType { get; set; }
	public Nullable<PS5IAPVerifyPurchaseOptionsPlatformSpecificOptions> PlatformSpecificOptions { get; set; }

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
	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public ReceiptValidatorVendorType get_VendorType() { }

	[CompilerGenerated]
	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_VendorType(ReceiptValidatorVendorType value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500
	public ReceiptValidatorEntitlementType get_EntitlementType() { }

	[CompilerGenerated]
	// RVA: 0x426530 Offset: 0x425730 VA: 0x180426530
	public void set_EntitlementType(ReceiptValidatorEntitlementType value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x41A1E0 Offset: 0x4193E0 VA: 0x18041A1E0
	public Nullable<PS5IAPVerifyPurchaseOptionsPlatformSpecificOptions> get_PlatformSpecificOptions() { }

	[CompilerGenerated]
	// RVA: 0x41A210 Offset: 0x419410 VA: 0x18041A210
	public void set_PlatformSpecificOptions(Nullable<PS5IAPVerifyPurchaseOptionsPlatformSpecificOptions> value) { }
}

// Namespace: Epic.OnlineServices.ReceiptValidator
internal struct PS5IAPVerifyPurchaseOptionsInternal : ISettable<PS5IAPVerifyPurchaseOptions>, IDisposable // TypeDefIndex: 10173
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_TargetUserId; // 0x10
	private ReceiptValidatorVendorType m_VendorType; // 0x18
	private ReceiptValidatorEntitlementType m_EntitlementType; // 0x1C
	private IntPtr m_PlatformSpecificOptions; // 0x20

	// Properties
	public ProductUserId LocalUserId { set; }
	public ProductUserId TargetUserId { set; }
	public ReceiptValidatorVendorType VendorType { set; }
	public ReceiptValidatorEntitlementType EntitlementType { set; }
	public Nullable<PS5IAPVerifyPurchaseOptionsPlatformSpecificOptions> PlatformSpecificOptions { set; }

	// Methods

	// RVA: 0x431850 Offset: 0x430A50 VA: 0x180431850
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x431920 Offset: 0x430B20 VA: 0x180431920
	public void set_TargetUserId(ProductUserId value) { }

	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	public void set_VendorType(ReceiptValidatorVendorType value) { }

	// RVA: 0x3F9290 Offset: 0x3F8490 VA: 0x1803F9290
	public void set_EntitlementType(ReceiptValidatorEntitlementType value) { }

	// RVA: 0x4318B0 Offset: 0x430AB0 VA: 0x1804318B0
	public void set_PlatformSpecificOptions(Nullable<PS5IAPVerifyPurchaseOptionsPlatformSpecificOptions> value) { }

	// RVA: 0x431550 Offset: 0x430750 VA: 0x180431550 Slot: 4
	public void Set(ref PS5IAPVerifyPurchaseOptions other) { }

	// RVA: 0x431680 Offset: 0x430880 VA: 0x180431680 Slot: 5
	public void Set(ref Nullable<PS5IAPVerifyPurchaseOptions> other) { }

	// RVA: 0x4314F0 Offset: 0x4306F0 VA: 0x1804314F0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.ReceiptValidator
public struct PS5IAPVerifyPurchaseOptionsPlatformSpecificOptions // TypeDefIndex: 10174
{
	// Fields
	[CompilerGenerated]
	private Utf8String <EntitlementLabel>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <ServiceLabel>k__BackingField; // 0x8
	[CompilerGenerated]
	private Utf8String <IdToken>k__BackingField; // 0x10
	[CompilerGenerated]
	private Utf8String <AccessToken>k__BackingField; // 0x18

	// Properties
	public Utf8String EntitlementLabel { get; set; }
	public Utf8String ServiceLabel { get; set; }
	public Utf8String IdToken { get; set; }
	public Utf8String AccessToken { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Utf8String get_EntitlementLabel() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_EntitlementLabel(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public Utf8String get_ServiceLabel() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_ServiceLabel(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Utf8String get_IdToken() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_IdToken(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public Utf8String get_AccessToken() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_AccessToken(Utf8String value) { }

	// RVA: 0x432040 Offset: 0x431240 VA: 0x180432040
	internal void Set(ref PS5IAPVerifyPurchaseOptionsPlatformSpecificOptionsInternal other) { }
}

// Namespace: Epic.OnlineServices.ReceiptValidator
internal struct PS5IAPVerifyPurchaseOptionsPlatformSpecificOptionsInternal : IGettable<PS5IAPVerifyPurchaseOptionsPlatformSpecificOptions>, ISettable<PS5IAPVerifyPurchaseOptionsPlatformSpecificOptions>, IDisposable // TypeDefIndex: 10175
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_EntitlementLabel; // 0x8
	private IntPtr m_ServiceLabel; // 0x10
	private IntPtr m_IdToken; // 0x18
	private IntPtr m_AccessToken; // 0x20

	// Properties
	public Utf8String EntitlementLabel { get; set; }
	public Utf8String ServiceLabel { get; set; }
	public Utf8String IdToken { get; set; }
	public Utf8String AccessToken { get; set; }

	// Methods

	// RVA: 0x431D70 Offset: 0x430F70 VA: 0x180431D70
	public Utf8String get_EntitlementLabel() { }

	// RVA: 0x431F20 Offset: 0x431120 VA: 0x180431F20
	public void set_EntitlementLabel(Utf8String value) { }

	// RVA: 0x431E50 Offset: 0x431050 VA: 0x180431E50
	public Utf8String get_ServiceLabel() { }

	// RVA: 0x431FE0 Offset: 0x4311E0 VA: 0x180431FE0
	public void set_ServiceLabel(Utf8String value) { }

	// RVA: 0x431DE0 Offset: 0x430FE0 VA: 0x180431DE0
	public Utf8String get_IdToken() { }

	// RVA: 0x431F80 Offset: 0x431180 VA: 0x180431F80
	public void set_IdToken(Utf8String value) { }

	// RVA: 0x431D00 Offset: 0x430F00 VA: 0x180431D00
	public Utf8String get_AccessToken() { }

	// RVA: 0x431EC0 Offset: 0x4310C0 VA: 0x180431EC0
	public void set_AccessToken(Utf8String value) { }

	// RVA: 0x431BC0 Offset: 0x430DC0 VA: 0x180431BC0 Slot: 5
	public void Set(ref PS5IAPVerifyPurchaseOptionsPlatformSpecificOptions other) { }

	// RVA: 0x431A10 Offset: 0x430C10 VA: 0x180431A10 Slot: 6
	public void Set(ref Nullable<PS5IAPVerifyPurchaseOptionsPlatformSpecificOptions> other) { }

	// RVA: 0x431980 Offset: 0x430B80 VA: 0x180431980 Slot: 7
	public void Dispose() { }

	// RVA: 0x4319F0 Offset: 0x430BF0 VA: 0x1804319F0 Slot: 4
	public void Get(out PS5IAPVerifyPurchaseOptionsPlatformSpecificOptions output) { }
}

// Namespace: Epic.OnlineServices.ReceiptValidator
public struct EGSDLCVerifyPurchaseOptions // TypeDefIndex: 10176
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private ProductUserId <TargetUserId>k__BackingField; // 0x8
	[CompilerGenerated]
	private ReceiptValidatorVendorType <VendorType>k__BackingField; // 0x10
	[CompilerGenerated]
	private ReceiptValidatorEntitlementType <EntitlementType>k__BackingField; // 0x14
	[CompilerGenerated]
	private Nullable<EGSDLCVerifyPurchaseOptionsPlatformSpecificOptions> <PlatformSpecificOptions>k__BackingField; // 0x18

	// Properties
	public ProductUserId LocalUserId { get; set; }
	public ProductUserId TargetUserId { get; set; }
	public ReceiptValidatorVendorType VendorType { get; set; }
	public ReceiptValidatorEntitlementType EntitlementType { get; set; }
	public Nullable<EGSDLCVerifyPurchaseOptionsPlatformSpecificOptions> PlatformSpecificOptions { get; set; }

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
	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public ReceiptValidatorVendorType get_VendorType() { }

	[CompilerGenerated]
	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_VendorType(ReceiptValidatorVendorType value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500
	public ReceiptValidatorEntitlementType get_EntitlementType() { }

	[CompilerGenerated]
	// RVA: 0x426530 Offset: 0x425730 VA: 0x180426530
	public void set_EntitlementType(ReceiptValidatorEntitlementType value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x426510 Offset: 0x425710 VA: 0x180426510
	public Nullable<EGSDLCVerifyPurchaseOptionsPlatformSpecificOptions> get_PlatformSpecificOptions() { }

	[CompilerGenerated]
	// RVA: 0x426540 Offset: 0x425740 VA: 0x180426540
	public void set_PlatformSpecificOptions(Nullable<EGSDLCVerifyPurchaseOptionsPlatformSpecificOptions> value) { }
}

// Namespace: Epic.OnlineServices.ReceiptValidator
internal struct EGSDLCVerifyPurchaseOptionsInternal : ISettable<EGSDLCVerifyPurchaseOptions>, IDisposable // TypeDefIndex: 10177
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_TargetUserId; // 0x10
	private ReceiptValidatorVendorType m_VendorType; // 0x18
	private ReceiptValidatorEntitlementType m_EntitlementType; // 0x1C
	private IntPtr m_PlatformSpecificOptions; // 0x20

	// Properties
	public ProductUserId LocalUserId { set; }
	public ProductUserId TargetUserId { set; }
	public ReceiptValidatorVendorType VendorType { set; }
	public ReceiptValidatorEntitlementType EntitlementType { set; }
	public Nullable<EGSDLCVerifyPurchaseOptionsPlatformSpecificOptions> PlatformSpecificOptions { set; }

	// Methods

	// RVA: 0x429670 Offset: 0x428870 VA: 0x180429670
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x429740 Offset: 0x428940 VA: 0x180429740
	public void set_TargetUserId(ProductUserId value) { }

	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	public void set_VendorType(ReceiptValidatorVendorType value) { }

	// RVA: 0x3F9290 Offset: 0x3F8490 VA: 0x1803F9290
	public void set_EntitlementType(ReceiptValidatorEntitlementType value) { }

	// RVA: 0x4296D0 Offset: 0x4288D0 VA: 0x1804296D0
	public void set_PlatformSpecificOptions(Nullable<EGSDLCVerifyPurchaseOptionsPlatformSpecificOptions> value) { }

	// RVA: 0x429540 Offset: 0x428740 VA: 0x180429540 Slot: 4
	public void Set(ref EGSDLCVerifyPurchaseOptions other) { }

	// RVA: 0x429380 Offset: 0x428580 VA: 0x180429380 Slot: 5
	public void Set(ref Nullable<EGSDLCVerifyPurchaseOptions> other) { }

	// RVA: 0x429320 Offset: 0x428520 VA: 0x180429320 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.ReceiptValidator
public struct EGSDLCVerifyPurchaseOptionsPlatformSpecificOptions // TypeDefIndex: 10178
{
	// Fields
	[CompilerGenerated]
	private Utf8String <CatalogItemId>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <EntitlementId>k__BackingField; // 0x8

	// Properties
	public Utf8String CatalogItemId { get; set; }
	public Utf8String EntitlementId { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Utf8String get_CatalogItemId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_CatalogItemId(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public Utf8String get_EntitlementId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_EntitlementId(Utf8String value) { }

	// RVA: 0x429B80 Offset: 0x428D80 VA: 0x180429B80
	internal void Set(ref EGSDLCVerifyPurchaseOptionsPlatformSpecificOptionsInternal other) { }
}

// Namespace: Epic.OnlineServices.ReceiptValidator
internal struct EGSDLCVerifyPurchaseOptionsPlatformSpecificOptionsInternal : IGettable<EGSDLCVerifyPurchaseOptionsPlatformSpecificOptions>, ISettable<EGSDLCVerifyPurchaseOptionsPlatformSpecificOptions>, IDisposable // TypeDefIndex: 10179
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_CatalogItemId; // 0x8
	private IntPtr m_EntitlementId; // 0x10

	// Properties
	public Utf8String CatalogItemId { get; set; }
	public Utf8String EntitlementId { get; set; }

	// Methods

	// RVA: 0x4299E0 Offset: 0x428BE0 VA: 0x1804299E0
	public Utf8String get_CatalogItemId() { }

	// RVA: 0x429AC0 Offset: 0x428CC0 VA: 0x180429AC0
	public void set_CatalogItemId(Utf8String value) { }

	// RVA: 0x429A50 Offset: 0x428C50 VA: 0x180429A50
	public Utf8String get_EntitlementId() { }

	// RVA: 0x429B20 Offset: 0x428D20 VA: 0x180429B20
	public void set_EntitlementId(Utf8String value) { }

	// RVA: 0x429920 Offset: 0x428B20 VA: 0x180429920 Slot: 5
	public void Set(ref EGSDLCVerifyPurchaseOptionsPlatformSpecificOptions other) { }

	// RVA: 0x429820 Offset: 0x428A20 VA: 0x180429820 Slot: 6
	public void Set(ref Nullable<EGSDLCVerifyPurchaseOptionsPlatformSpecificOptions> other) { }

	// RVA: 0x4297A0 Offset: 0x4289A0 VA: 0x1804297A0 Slot: 7
	public void Dispose() { }

	// RVA: 0x429800 Offset: 0x428A00 VA: 0x180429800 Slot: 4
	public void Get(out EGSDLCVerifyPurchaseOptionsPlatformSpecificOptions output) { }
}

// Namespace: Epic.OnlineServices.ReceiptValidator
public struct EGSIAPVerifyPurchaseOptions // TypeDefIndex: 10180
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private ProductUserId <TargetUserId>k__BackingField; // 0x8
	[CompilerGenerated]
	private ReceiptValidatorVendorType <VendorType>k__BackingField; // 0x10
	[CompilerGenerated]
	private ReceiptValidatorEntitlementType <EntitlementType>k__BackingField; // 0x14
	[CompilerGenerated]
	private Nullable<EGSIAPVerifyPurchaseOptionsPlatformSpecificOptions> <PlatformSpecificOptions>k__BackingField; // 0x18

	// Properties
	public ProductUserId LocalUserId { get; set; }
	public ProductUserId TargetUserId { get; set; }
	public ReceiptValidatorVendorType VendorType { get; set; }
	public ReceiptValidatorEntitlementType EntitlementType { get; set; }
	public Nullable<EGSIAPVerifyPurchaseOptionsPlatformSpecificOptions> PlatformSpecificOptions { get; set; }

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
	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public ReceiptValidatorVendorType get_VendorType() { }

	[CompilerGenerated]
	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_VendorType(ReceiptValidatorVendorType value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500
	public ReceiptValidatorEntitlementType get_EntitlementType() { }

	[CompilerGenerated]
	// RVA: 0x426530 Offset: 0x425730 VA: 0x180426530
	public void set_EntitlementType(ReceiptValidatorEntitlementType value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x426510 Offset: 0x425710 VA: 0x180426510
	public Nullable<EGSIAPVerifyPurchaseOptionsPlatformSpecificOptions> get_PlatformSpecificOptions() { }

	[CompilerGenerated]
	// RVA: 0x426540 Offset: 0x425740 VA: 0x180426540
	public void set_PlatformSpecificOptions(Nullable<EGSIAPVerifyPurchaseOptionsPlatformSpecificOptions> value) { }
}

// Namespace: Epic.OnlineServices.ReceiptValidator
internal struct EGSIAPVerifyPurchaseOptionsInternal : ISettable<EGSIAPVerifyPurchaseOptions>, IDisposable // TypeDefIndex: 10181
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_TargetUserId; // 0x10
	private ReceiptValidatorVendorType m_VendorType; // 0x18
	private ReceiptValidatorEntitlementType m_EntitlementType; // 0x1C
	private IntPtr m_PlatformSpecificOptions; // 0x20

	// Properties
	public ProductUserId LocalUserId { set; }
	public ProductUserId TargetUserId { set; }
	public ReceiptValidatorVendorType VendorType { set; }
	public ReceiptValidatorEntitlementType EntitlementType { set; }
	public Nullable<EGSIAPVerifyPurchaseOptionsPlatformSpecificOptions> PlatformSpecificOptions { set; }

	// Methods

	// RVA: 0x429FB0 Offset: 0x4291B0 VA: 0x180429FB0
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x42A080 Offset: 0x429280 VA: 0x18042A080
	public void set_TargetUserId(ProductUserId value) { }

	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	public void set_VendorType(ReceiptValidatorVendorType value) { }

	// RVA: 0x3F9290 Offset: 0x3F8490 VA: 0x1803F9290
	public void set_EntitlementType(ReceiptValidatorEntitlementType value) { }

	// RVA: 0x42A010 Offset: 0x429210 VA: 0x18042A010
	public void set_PlatformSpecificOptions(Nullable<EGSIAPVerifyPurchaseOptionsPlatformSpecificOptions> value) { }

	// RVA: 0x429CC0 Offset: 0x428EC0 VA: 0x180429CC0 Slot: 4
	public void Set(ref EGSIAPVerifyPurchaseOptions other) { }

	// RVA: 0x429DF0 Offset: 0x428FF0 VA: 0x180429DF0 Slot: 5
	public void Set(ref Nullable<EGSIAPVerifyPurchaseOptions> other) { }

	// RVA: 0x429C60 Offset: 0x428E60 VA: 0x180429C60 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.ReceiptValidator
public struct EGSIAPVerifyPurchaseOptionsPlatformSpecificOptions // TypeDefIndex: 10182
{
	// Fields
	[CompilerGenerated]
	private Utf8String <EntitlementName>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <EntitlementId>k__BackingField; // 0x8

	// Properties
	public Utf8String EntitlementName { get; set; }
	public Utf8String EntitlementId { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Utf8String get_EntitlementName() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_EntitlementName(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public Utf8String get_EntitlementId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_EntitlementId(Utf8String value) { }

	// RVA: 0x42A4C0 Offset: 0x4296C0 VA: 0x18042A4C0
	internal void Set(ref EGSIAPVerifyPurchaseOptionsPlatformSpecificOptionsInternal other) { }
}

// Namespace: Epic.OnlineServices.ReceiptValidator
internal struct EGSIAPVerifyPurchaseOptionsPlatformSpecificOptionsInternal : IGettable<EGSIAPVerifyPurchaseOptionsPlatformSpecificOptions>, ISettable<EGSIAPVerifyPurchaseOptionsPlatformSpecificOptions>, IDisposable // TypeDefIndex: 10183
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_EntitlementName; // 0x8
	private IntPtr m_EntitlementId; // 0x10

	// Properties
	public Utf8String EntitlementName { get; set; }
	public Utf8String EntitlementId { get; set; }

	// Methods

	// RVA: 0x42A390 Offset: 0x429590 VA: 0x18042A390
	public Utf8String get_EntitlementName() { }

	// RVA: 0x42A460 Offset: 0x429660 VA: 0x18042A460
	public void set_EntitlementName(Utf8String value) { }

	// RVA: 0x42A320 Offset: 0x429520 VA: 0x18042A320
	public Utf8String get_EntitlementId() { }

	// RVA: 0x42A400 Offset: 0x429600 VA: 0x18042A400
	public void set_EntitlementId(Utf8String value) { }

	// RVA: 0x42A260 Offset: 0x429460 VA: 0x18042A260 Slot: 5
	public void Set(ref EGSIAPVerifyPurchaseOptionsPlatformSpecificOptions other) { }

	// RVA: 0x42A160 Offset: 0x429360 VA: 0x18042A160 Slot: 6
	public void Set(ref Nullable<EGSIAPVerifyPurchaseOptionsPlatformSpecificOptions> other) { }

	// RVA: 0x42A0E0 Offset: 0x4292E0 VA: 0x18042A0E0 Slot: 7
	public void Dispose() { }

	// RVA: 0x42A140 Offset: 0x429340 VA: 0x18042A140 Slot: 4
	public void Get(out EGSIAPVerifyPurchaseOptionsPlatformSpecificOptions output) { }
}

// Namespace: Epic.OnlineServices.ReceiptValidator
public sealed class OnVerifyPurchaseCompleteCallback : MulticastDelegate // TypeDefIndex: 10184
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref VerifyPurchaseCompleteCallbackInfo data) { }

	// RVA: 0x42C8B0 Offset: 0x42BAB0 VA: 0x18042C8B0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref VerifyPurchaseCompleteCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref VerifyPurchaseCompleteCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.ReceiptValidator
[UnmanagedFunctionPointer(2)]
internal sealed class OnVerifyPurchaseCompleteCallbackInternal : MulticastDelegate // TypeDefIndex: 10185
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref VerifyPurchaseCompleteCallbackInfoInternal data) { }

	// RVA: 0x42C820 Offset: 0x42BA20 VA: 0x18042C820 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref VerifyPurchaseCompleteCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref VerifyPurchaseCompleteCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.ReceiptValidator
public enum ReceiptValidatorEntitlementType // TypeDefIndex: 10186
{
	// Fields
	public int value__; // 0x0
	public const ReceiptValidatorEntitlementType InAppPurchase = 0;
	public const ReceiptValidatorEntitlementType Dlc = 1;
}

// Namespace: Epic.OnlineServices.ReceiptValidator
public enum ReceiptValidatorVendorType // TypeDefIndex: 10187
{
	// Fields
	public int value__; // 0x0
	public const ReceiptValidatorVendorType Egs = 0;
	public const ReceiptValidatorVendorType Steam = 1;
	public const ReceiptValidatorVendorType Psn = 2;
	public const ReceiptValidatorVendorType Xbl = 3;
	public const ReceiptValidatorVendorType Nintendo = 4;
	public const ReceiptValidatorVendorType Apple = 5;
	public const ReceiptValidatorVendorType Google = 6;
}

// Namespace: Epic.OnlineServices.ReceiptValidator
public struct SteamDLCVerifyPurchaseOptions // TypeDefIndex: 10188
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private ProductUserId <TargetUserId>k__BackingField; // 0x8
	[CompilerGenerated]
	private ReceiptValidatorVendorType <VendorType>k__BackingField; // 0x10
	[CompilerGenerated]
	private ReceiptValidatorEntitlementType <EntitlementType>k__BackingField; // 0x14
	[CompilerGenerated]
	private Nullable<SteamDLCVerifyPurchaseOptionsPlatformSpecificOptions> <PlatformSpecificOptions>k__BackingField; // 0x18

	// Properties
	public ProductUserId LocalUserId { get; set; }
	public ProductUserId TargetUserId { get; set; }
	public ReceiptValidatorVendorType VendorType { get; set; }
	public ReceiptValidatorEntitlementType EntitlementType { get; set; }
	public Nullable<SteamDLCVerifyPurchaseOptionsPlatformSpecificOptions> PlatformSpecificOptions { get; set; }

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

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public ReceiptValidatorVendorType get_VendorType() { }

	[CompilerGenerated]
	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_VendorType(ReceiptValidatorVendorType value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500
	public ReceiptValidatorEntitlementType get_EntitlementType() { }

	[CompilerGenerated]
	// RVA: 0x426530 Offset: 0x425730 VA: 0x180426530
	public void set_EntitlementType(ReceiptValidatorEntitlementType value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x426510 Offset: 0x425710 VA: 0x180426510
	public Nullable<SteamDLCVerifyPurchaseOptionsPlatformSpecificOptions> get_PlatformSpecificOptions() { }

	[CompilerGenerated]
	// RVA: 0x426540 Offset: 0x425740 VA: 0x180426540
	public void set_PlatformSpecificOptions(Nullable<SteamDLCVerifyPurchaseOptionsPlatformSpecificOptions> value) { }
}

// Namespace: Epic.OnlineServices.ReceiptValidator
internal struct SteamDLCVerifyPurchaseOptionsInternal : ISettable<SteamDLCVerifyPurchaseOptions>, IDisposable // TypeDefIndex: 10189
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_TargetUserId; // 0x10
	private ReceiptValidatorVendorType m_VendorType; // 0x18
	private ReceiptValidatorEntitlementType m_EntitlementType; // 0x1C
	private IntPtr m_PlatformSpecificOptions; // 0x20

	// Properties
	public ProductUserId LocalUserId { set; }
	public ProductUserId TargetUserId { set; }
	public ReceiptValidatorVendorType VendorType { set; }
	public ReceiptValidatorEntitlementType EntitlementType { set; }
	public Nullable<SteamDLCVerifyPurchaseOptionsPlatformSpecificOptions> PlatformSpecificOptions { set; }

	// Methods

	// RVA: 0x4387E0 Offset: 0x4379E0 VA: 0x1804387E0
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x4388B0 Offset: 0x437AB0 VA: 0x1804388B0
	public void set_TargetUserId(ProductUserId value) { }

	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	public void set_VendorType(ReceiptValidatorVendorType value) { }

	// RVA: 0x3F9290 Offset: 0x3F8490 VA: 0x1803F9290
	public void set_EntitlementType(ReceiptValidatorEntitlementType value) { }

	// RVA: 0x438840 Offset: 0x437A40 VA: 0x180438840
	public void set_PlatformSpecificOptions(Nullable<SteamDLCVerifyPurchaseOptionsPlatformSpecificOptions> value) { }

	// RVA: 0x4384F0 Offset: 0x4376F0 VA: 0x1804384F0 Slot: 4
	public void Set(ref SteamDLCVerifyPurchaseOptions other) { }

	// RVA: 0x438620 Offset: 0x437820 VA: 0x180438620 Slot: 5
	public void Set(ref Nullable<SteamDLCVerifyPurchaseOptions> other) { }

	// RVA: 0x438490 Offset: 0x437690 VA: 0x180438490 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.ReceiptValidator
public struct SteamDLCVerifyPurchaseOptionsPlatformSpecificOptions // TypeDefIndex: 10190
{
	// Fields
	[CompilerGenerated]
	private Utf8String <AppId>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <SteamId>k__BackingField; // 0x8

	// Properties
	public Utf8String AppId { get; set; }
	public Utf8String SteamId { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Utf8String get_AppId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_AppId(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public Utf8String get_SteamId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_SteamId(Utf8String value) { }

	// RVA: 0x438CF0 Offset: 0x437EF0 VA: 0x180438CF0
	internal void Set(ref SteamDLCVerifyPurchaseOptionsPlatformSpecificOptionsInternal other) { }
}

// Namespace: Epic.OnlineServices.ReceiptValidator
internal struct SteamDLCVerifyPurchaseOptionsPlatformSpecificOptionsInternal : IGettable<SteamDLCVerifyPurchaseOptionsPlatformSpecificOptions>, ISettable<SteamDLCVerifyPurchaseOptionsPlatformSpecificOptions>, IDisposable // TypeDefIndex: 10191
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_AppId; // 0x8
	private IntPtr m_SteamId; // 0x10

	// Properties
	public Utf8String AppId { get; set; }
	public Utf8String SteamId { get; set; }

	// Methods

	// RVA: 0x438B50 Offset: 0x437D50 VA: 0x180438B50
	public Utf8String get_AppId() { }

	// RVA: 0x438C30 Offset: 0x437E30 VA: 0x180438C30
	public void set_AppId(Utf8String value) { }

	// RVA: 0x438BC0 Offset: 0x437DC0 VA: 0x180438BC0
	public Utf8String get_SteamId() { }

	// RVA: 0x438C90 Offset: 0x437E90 VA: 0x180438C90
	public void set_SteamId(Utf8String value) { }

	// RVA: 0x438990 Offset: 0x437B90 VA: 0x180438990 Slot: 5
	public void Set(ref SteamDLCVerifyPurchaseOptionsPlatformSpecificOptions other) { }

	// RVA: 0x438A50 Offset: 0x437C50 VA: 0x180438A50 Slot: 6
	public void Set(ref Nullable<SteamDLCVerifyPurchaseOptionsPlatformSpecificOptions> other) { }

	// RVA: 0x438910 Offset: 0x437B10 VA: 0x180438910 Slot: 7
	public void Dispose() { }

	// RVA: 0x438970 Offset: 0x437B70 VA: 0x180438970 Slot: 4
	public void Get(out SteamDLCVerifyPurchaseOptionsPlatformSpecificOptions output) { }
}

// Namespace: Epic.OnlineServices.ReceiptValidator
public struct SteamIAPVerifyPurchaseOptions // TypeDefIndex: 10192
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private ProductUserId <TargetUserId>k__BackingField; // 0x8
	[CompilerGenerated]
	private ReceiptValidatorVendorType <VendorType>k__BackingField; // 0x10
	[CompilerGenerated]
	private ReceiptValidatorEntitlementType <EntitlementType>k__BackingField; // 0x14
	[CompilerGenerated]
	private Nullable<SteamIAPVerifyPurchaseOptionsPlatformSpecificOptions> <PlatformSpecificOptions>k__BackingField; // 0x18

	// Properties
	public ProductUserId LocalUserId { get; set; }
	public ProductUserId TargetUserId { get; set; }
	public ReceiptValidatorVendorType VendorType { get; set; }
	public ReceiptValidatorEntitlementType EntitlementType { get; set; }
	public Nullable<SteamIAPVerifyPurchaseOptionsPlatformSpecificOptions> PlatformSpecificOptions { get; set; }

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
	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public ReceiptValidatorVendorType get_VendorType() { }

	[CompilerGenerated]
	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_VendorType(ReceiptValidatorVendorType value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500
	public ReceiptValidatorEntitlementType get_EntitlementType() { }

	[CompilerGenerated]
	// RVA: 0x426530 Offset: 0x425730 VA: 0x180426530
	public void set_EntitlementType(ReceiptValidatorEntitlementType value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x42D820 Offset: 0x42CA20 VA: 0x18042D820
	public Nullable<SteamIAPVerifyPurchaseOptionsPlatformSpecificOptions> get_PlatformSpecificOptions() { }

	[CompilerGenerated]
	// RVA: 0x42D8A0 Offset: 0x42CAA0 VA: 0x18042D8A0
	public void set_PlatformSpecificOptions(Nullable<SteamIAPVerifyPurchaseOptionsPlatformSpecificOptions> value) { }
}

// Namespace: Epic.OnlineServices.ReceiptValidator
internal struct SteamIAPVerifyPurchaseOptionsInternal : ISettable<SteamIAPVerifyPurchaseOptions>, IDisposable // TypeDefIndex: 10193
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_TargetUserId; // 0x10
	private ReceiptValidatorVendorType m_VendorType; // 0x18
	private ReceiptValidatorEntitlementType m_EntitlementType; // 0x1C
	private IntPtr m_PlatformSpecificOptions; // 0x20

	// Properties
	public ProductUserId LocalUserId { set; }
	public ProductUserId TargetUserId { set; }
	public ReceiptValidatorVendorType VendorType { set; }
	public ReceiptValidatorEntitlementType EntitlementType { set; }
	public Nullable<SteamIAPVerifyPurchaseOptionsPlatformSpecificOptions> PlatformSpecificOptions { set; }

	// Methods

	// RVA: 0x439100 Offset: 0x438300 VA: 0x180439100
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x4391D0 Offset: 0x4383D0 VA: 0x1804391D0
	public void set_TargetUserId(ProductUserId value) { }

	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	public void set_VendorType(ReceiptValidatorVendorType value) { }

	// RVA: 0x3F9290 Offset: 0x3F8490 VA: 0x1803F9290
	public void set_EntitlementType(ReceiptValidatorEntitlementType value) { }

	// RVA: 0x439160 Offset: 0x438360 VA: 0x180439160
	public void set_PlatformSpecificOptions(Nullable<SteamIAPVerifyPurchaseOptionsPlatformSpecificOptions> value) { }

	// RVA: 0x438E30 Offset: 0x438030 VA: 0x180438E30 Slot: 4
	public void Set(ref SteamIAPVerifyPurchaseOptions other) { }

	// RVA: 0x438F50 Offset: 0x438150 VA: 0x180438F50 Slot: 5
	public void Set(ref Nullable<SteamIAPVerifyPurchaseOptions> other) { }

	// RVA: 0x438DD0 Offset: 0x437FD0 VA: 0x180438DD0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.ReceiptValidator
public struct SteamIAPVerifyPurchaseOptionsPlatformSpecificOptions // TypeDefIndex: 10194
{
	// Fields
	[CompilerGenerated]
	private Utf8String <TransId>k__BackingField; // 0x0

	// Properties
	public Utf8String TransId { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Utf8String get_TransId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_TransId(Utf8String value) { }

	// RVA: 0x439470 Offset: 0x438670 VA: 0x180439470
	internal void Set(ref SteamIAPVerifyPurchaseOptionsPlatformSpecificOptionsInternal other) { }
}

// Namespace: Epic.OnlineServices.ReceiptValidator
internal struct SteamIAPVerifyPurchaseOptionsPlatformSpecificOptionsInternal : IGettable<SteamIAPVerifyPurchaseOptionsPlatformSpecificOptions>, ISettable<SteamIAPVerifyPurchaseOptionsPlatformSpecificOptions>, IDisposable // TypeDefIndex: 10195
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_TransId; // 0x8

	// Properties
	public Utf8String TransId { get; set; }

	// Methods

	// RVA: 0x4393A0 Offset: 0x4385A0 VA: 0x1804393A0
	public Utf8String get_TransId() { }

	// RVA: 0x439410 Offset: 0x438610 VA: 0x180439410
	public void set_TransId(Utf8String value) { }

	// RVA: 0x439340 Offset: 0x438540 VA: 0x180439340 Slot: 5
	public void Set(ref SteamIAPVerifyPurchaseOptionsPlatformSpecificOptions other) { }

	// RVA: 0x4392A0 Offset: 0x4384A0 VA: 0x1804392A0 Slot: 6
	public void Set(ref Nullable<SteamIAPVerifyPurchaseOptionsPlatformSpecificOptions> other) { }

	// RVA: 0x439230 Offset: 0x438430 VA: 0x180439230 Slot: 7
	public void Dispose() { }

	// RVA: 0x439280 Offset: 0x438480 VA: 0x180439280 Slot: 4
	public void Get(out SteamIAPVerifyPurchaseOptionsPlatformSpecificOptions output) { }
}

// Namespace: Epic.OnlineServices.ReceiptValidator
public struct VerifyPurchaseCompleteCallbackInfo : ICallbackInfo // TypeDefIndex: 10196
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

	// RVA: 0x43A260 Offset: 0x439460 VA: 0x18043A260 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x43A2B0 Offset: 0x4394B0 VA: 0x18043A2B0
	internal void Set(ref VerifyPurchaseCompleteCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.ReceiptValidator
internal struct VerifyPurchaseCompleteCallbackInfoInternal : ICallbackInfoInternal, IGettable<VerifyPurchaseCompleteCallbackInfo>, ISettable<VerifyPurchaseCompleteCallbackInfo>, IDisposable // TypeDefIndex: 10197
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

	// RVA: 0x43A190 Offset: 0x439390 VA: 0x18043A190
	public object get_ClientData() { }

	// RVA: 0x43A200 Offset: 0x439400 VA: 0x18043A200
	public void set_ClientData(object value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x43A070 Offset: 0x439270 VA: 0x18043A070 Slot: 6
	public void Set(ref VerifyPurchaseCompleteCallbackInfo other) { }

	// RVA: 0x43A0D0 Offset: 0x4392D0 VA: 0x18043A0D0 Slot: 7
	public void Set(ref Nullable<VerifyPurchaseCompleteCallbackInfo> other) { }

	// RVA: 0x43A000 Offset: 0x439200 VA: 0x18043A000 Slot: 8
	public void Dispose() { }

	// RVA: 0x43A050 Offset: 0x439250 VA: 0x18043A050 Slot: 5
	public void Get(out VerifyPurchaseCompleteCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.ReceiptValidator
public struct VerifyPurchaseOptions // TypeDefIndex: 10198
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private ProductUserId <TargetUserId>k__BackingField; // 0x8
	[CompilerGenerated]
	private ReceiptValidatorVendorType <VendorType>k__BackingField; // 0x10
	[CompilerGenerated]
	private ReceiptValidatorEntitlementType <EntitlementType>k__BackingField; // 0x14
	[CompilerGenerated]
	private IntPtr <PlatformSpecificOptions>k__BackingField; // 0x18

	// Properties
	public ProductUserId LocalUserId { get; set; }
	public ProductUserId TargetUserId { get; set; }
	public ReceiptValidatorVendorType VendorType { get; set; }
	public ReceiptValidatorEntitlementType EntitlementType { get; set; }
	public IntPtr PlatformSpecificOptions { get; set; }

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

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public ReceiptValidatorVendorType get_VendorType() { }

	[CompilerGenerated]
	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_VendorType(ReceiptValidatorVendorType value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500
	public ReceiptValidatorEntitlementType get_EntitlementType() { }

	[CompilerGenerated]
	// RVA: 0x426530 Offset: 0x425730 VA: 0x180426530
	public void set_EntitlementType(ReceiptValidatorEntitlementType value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public IntPtr get_PlatformSpecificOptions() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_PlatformSpecificOptions(IntPtr value) { }
}

// Namespace: Epic.OnlineServices.ReceiptValidator
internal struct VerifyPurchaseOptionsInternal : ISettable<VerifyPurchaseOptions>, IDisposable // TypeDefIndex: 10199
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_TargetUserId; // 0x10
	private ReceiptValidatorVendorType m_VendorType; // 0x18
	private ReceiptValidatorEntitlementType m_EntitlementType; // 0x1C
	private IntPtr m_PlatformSpecificOptions; // 0x20

	// Properties
	public ProductUserId LocalUserId { set; }
	public ProductUserId TargetUserId { set; }
	public ReceiptValidatorVendorType VendorType { set; }
	public ReceiptValidatorEntitlementType EntitlementType { set; }
	public IntPtr PlatformSpecificOptions { set; }

	// Methods

	// RVA: 0x43A5C0 Offset: 0x4397C0 VA: 0x18043A5C0
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x43A620 Offset: 0x439820 VA: 0x18043A620
	public void set_TargetUserId(ProductUserId value) { }

	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	public void set_VendorType(ReceiptValidatorVendorType value) { }

	// RVA: 0x3F9290 Offset: 0x3F8490 VA: 0x1803F9290
	public void set_EntitlementType(ReceiptValidatorEntitlementType value) { }

	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_PlatformSpecificOptions(IntPtr value) { }

	// RVA: 0x43A390 Offset: 0x439590 VA: 0x18043A390 Slot: 4
	public void Set(ref VerifyPurchaseOptions other) { }

	// RVA: 0x43A460 Offset: 0x439660 VA: 0x18043A460 Slot: 5
	public void Set(ref Nullable<VerifyPurchaseOptions> other) { }

	// RVA: 0x43A330 Offset: 0x439530 VA: 0x18043A330 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.ReceiptValidator
public struct SwitchIAPVerifyPurchaseOptions // TypeDefIndex: 10200
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private ProductUserId <TargetUserId>k__BackingField; // 0x8
	[CompilerGenerated]
	private ReceiptValidatorVendorType <VendorType>k__BackingField; // 0x10
	[CompilerGenerated]
	private ReceiptValidatorEntitlementType <EntitlementType>k__BackingField; // 0x14
	[CompilerGenerated]
	private Nullable<SwitchIAPVerifyPurchaseOptionsPlatformSpecificOptions> <PlatformSpecificOptions>k__BackingField; // 0x18

	// Properties
	public ProductUserId LocalUserId { get; set; }
	public ProductUserId TargetUserId { get; set; }
	public ReceiptValidatorVendorType VendorType { get; set; }
	public ReceiptValidatorEntitlementType EntitlementType { get; set; }
	public Nullable<SwitchIAPVerifyPurchaseOptionsPlatformSpecificOptions> PlatformSpecificOptions { get; set; }

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

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public ReceiptValidatorVendorType get_VendorType() { }

	[CompilerGenerated]
	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_VendorType(ReceiptValidatorVendorType value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500
	public ReceiptValidatorEntitlementType get_EntitlementType() { }

	[CompilerGenerated]
	// RVA: 0x426530 Offset: 0x425730 VA: 0x180426530
	public void set_EntitlementType(ReceiptValidatorEntitlementType value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x42D820 Offset: 0x42CA20 VA: 0x18042D820
	public Nullable<SwitchIAPVerifyPurchaseOptionsPlatformSpecificOptions> get_PlatformSpecificOptions() { }

	[CompilerGenerated]
	// RVA: 0x42D8A0 Offset: 0x42CAA0 VA: 0x18042D8A0
	public void set_PlatformSpecificOptions(Nullable<SwitchIAPVerifyPurchaseOptionsPlatformSpecificOptions> value) { }
}

// Namespace: Epic.OnlineServices.ReceiptValidator
internal struct SwitchIAPVerifyPurchaseOptionsInternal : ISettable<SwitchIAPVerifyPurchaseOptions>, IDisposable // TypeDefIndex: 10201
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_TargetUserId; // 0x10
	private ReceiptValidatorVendorType m_VendorType; // 0x18
	private ReceiptValidatorEntitlementType m_EntitlementType; // 0x1C
	private IntPtr m_PlatformSpecificOptions; // 0x20

	// Properties
	public ProductUserId LocalUserId { set; }
	public ProductUserId TargetUserId { set; }
	public ReceiptValidatorVendorType VendorType { set; }
	public ReceiptValidatorEntitlementType EntitlementType { set; }
	public Nullable<SwitchIAPVerifyPurchaseOptionsPlatformSpecificOptions> PlatformSpecificOptions { set; }

	// Methods

	// RVA: 0x439820 Offset: 0x438A20 VA: 0x180439820
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x4398F0 Offset: 0x438AF0 VA: 0x1804398F0
	public void set_TargetUserId(ProductUserId value) { }

	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	public void set_VendorType(ReceiptValidatorVendorType value) { }

	// RVA: 0x3F9290 Offset: 0x3F8490 VA: 0x1803F9290
	public void set_EntitlementType(ReceiptValidatorEntitlementType value) { }

	// RVA: 0x439880 Offset: 0x438A80 VA: 0x180439880
	public void set_PlatformSpecificOptions(Nullable<SwitchIAPVerifyPurchaseOptionsPlatformSpecificOptions> value) { }

	// RVA: 0x439550 Offset: 0x438750 VA: 0x180439550 Slot: 4
	public void Set(ref SwitchIAPVerifyPurchaseOptions other) { }

	// RVA: 0x439670 Offset: 0x438870 VA: 0x180439670 Slot: 5
	public void Set(ref Nullable<SwitchIAPVerifyPurchaseOptions> other) { }

	// RVA: 0x4394F0 Offset: 0x4386F0 VA: 0x1804394F0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.ReceiptValidator
public struct SwitchIAPVerifyPurchaseOptionsPlatformSpecificOptions // TypeDefIndex: 10202
{
	// Fields
	[CompilerGenerated]
	private Utf8String <NsaIdToken>k__BackingField; // 0x0

	// Properties
	public Utf8String NsaIdToken { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Utf8String get_NsaIdToken() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_NsaIdToken(Utf8String value) { }

	// RVA: 0x439B90 Offset: 0x438D90 VA: 0x180439B90
	internal void Set(ref SwitchIAPVerifyPurchaseOptionsPlatformSpecificOptionsInternal other) { }
}

// Namespace: Epic.OnlineServices.ReceiptValidator
internal struct SwitchIAPVerifyPurchaseOptionsPlatformSpecificOptionsInternal : IGettable<SwitchIAPVerifyPurchaseOptionsPlatformSpecificOptions>, ISettable<SwitchIAPVerifyPurchaseOptionsPlatformSpecificOptions>, IDisposable // TypeDefIndex: 10203
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_NsaIdToken; // 0x8

	// Properties
	public Utf8String NsaIdToken { get; set; }

	// Methods

	// RVA: 0x439AC0 Offset: 0x438CC0 VA: 0x180439AC0
	public Utf8String get_NsaIdToken() { }

	// RVA: 0x439B30 Offset: 0x438D30 VA: 0x180439B30
	public void set_NsaIdToken(Utf8String value) { }

	// RVA: 0x4399C0 Offset: 0x438BC0 VA: 0x1804399C0 Slot: 5
	public void Set(ref SwitchIAPVerifyPurchaseOptionsPlatformSpecificOptions other) { }

	// RVA: 0x439A20 Offset: 0x438C20 VA: 0x180439A20 Slot: 6
	public void Set(ref Nullable<SwitchIAPVerifyPurchaseOptionsPlatformSpecificOptions> other) { }

	// RVA: 0x439950 Offset: 0x438B50 VA: 0x180439950 Slot: 7
	public void Dispose() { }

	// RVA: 0x4399A0 Offset: 0x438BA0 VA: 0x1804399A0 Slot: 4
	public void Get(out SwitchIAPVerifyPurchaseOptionsPlatformSpecificOptions output) { }
}

// Namespace: Epic.OnlineServices.ReceiptValidator
public struct XboxOneGDKDLCVerifyPurchaseOptions // TypeDefIndex: 10204
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private ProductUserId <TargetUserId>k__BackingField; // 0x8
	[CompilerGenerated]
	private ReceiptValidatorVendorType <VendorType>k__BackingField; // 0x10
	[CompilerGenerated]
	private ReceiptValidatorEntitlementType <EntitlementType>k__BackingField; // 0x14
	[CompilerGenerated]
	private Nullable<XboxOneGDKDLCVerifyPurchaseOptionsPlatformSpecificOptions> <PlatformSpecificOptions>k__BackingField; // 0x18

	// Properties
	public ProductUserId LocalUserId { get; set; }
	public ProductUserId TargetUserId { get; set; }
	public ReceiptValidatorVendorType VendorType { get; set; }
	public ReceiptValidatorEntitlementType EntitlementType { get; set; }
	public Nullable<XboxOneGDKDLCVerifyPurchaseOptionsPlatformSpecificOptions> PlatformSpecificOptions { get; set; }

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

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public ReceiptValidatorVendorType get_VendorType() { }

	[CompilerGenerated]
	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_VendorType(ReceiptValidatorVendorType value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500
	public ReceiptValidatorEntitlementType get_EntitlementType() { }

	[CompilerGenerated]
	// RVA: 0x426530 Offset: 0x425730 VA: 0x180426530
	public void set_EntitlementType(ReceiptValidatorEntitlementType value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x426510 Offset: 0x425710 VA: 0x180426510
	public Nullable<XboxOneGDKDLCVerifyPurchaseOptionsPlatformSpecificOptions> get_PlatformSpecificOptions() { }

	[CompilerGenerated]
	// RVA: 0x426540 Offset: 0x425740 VA: 0x180426540
	public void set_PlatformSpecificOptions(Nullable<XboxOneGDKDLCVerifyPurchaseOptionsPlatformSpecificOptions> value) { }
}

// Namespace: Epic.OnlineServices.ReceiptValidator
internal struct XboxOneGDKDLCVerifyPurchaseOptionsInternal : ISettable<XboxOneGDKDLCVerifyPurchaseOptions>, IDisposable // TypeDefIndex: 10205
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_TargetUserId; // 0x10
	private ReceiptValidatorVendorType m_VendorType; // 0x18
	private ReceiptValidatorEntitlementType m_EntitlementType; // 0x1C
	private IntPtr m_PlatformSpecificOptions; // 0x20

	// Properties
	public ProductUserId LocalUserId { set; }
	public ProductUserId TargetUserId { set; }
	public ReceiptValidatorVendorType VendorType { set; }
	public ReceiptValidatorEntitlementType EntitlementType { set; }
	public Nullable<XboxOneGDKDLCVerifyPurchaseOptionsPlatformSpecificOptions> PlatformSpecificOptions { set; }

	// Methods

	// RVA: 0x43CB80 Offset: 0x43BD80 VA: 0x18043CB80
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x43CC50 Offset: 0x43BE50 VA: 0x18043CC50
	public void set_TargetUserId(ProductUserId value) { }

	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	public void set_VendorType(ReceiptValidatorVendorType value) { }

	// RVA: 0x3F9290 Offset: 0x3F8490 VA: 0x1803F9290
	public void set_EntitlementType(ReceiptValidatorEntitlementType value) { }

	// RVA: 0x43CBE0 Offset: 0x43BDE0 VA: 0x18043CBE0
	public void set_PlatformSpecificOptions(Nullable<XboxOneGDKDLCVerifyPurchaseOptionsPlatformSpecificOptions> value) { }

	// RVA: 0x43C890 Offset: 0x43BA90 VA: 0x18043C890 Slot: 4
	public void Set(ref XboxOneGDKDLCVerifyPurchaseOptions other) { }

	// RVA: 0x43C9C0 Offset: 0x43BBC0 VA: 0x18043C9C0 Slot: 5
	public void Set(ref Nullable<XboxOneGDKDLCVerifyPurchaseOptions> other) { }

	// RVA: 0x43C830 Offset: 0x43BA30 VA: 0x18043C830 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.ReceiptValidator
public struct XboxOneGDKDLCVerifyPurchaseOptionsPlatformSpecificOptions // TypeDefIndex: 10206
{
	// Fields
	[CompilerGenerated]
	private Utf8String <ItemId>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <XSTSToken>k__BackingField; // 0x8

	// Properties
	public Utf8String ItemId { get; set; }
	public Utf8String XSTSToken { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Utf8String get_ItemId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_ItemId(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public Utf8String get_XSTSToken() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_XSTSToken(Utf8String value) { }

	// RVA: 0x43D090 Offset: 0x43C290 VA: 0x18043D090
	internal void Set(ref XboxOneGDKDLCVerifyPurchaseOptionsPlatformSpecificOptionsInternal other) { }
}

// Namespace: Epic.OnlineServices.ReceiptValidator
internal struct XboxOneGDKDLCVerifyPurchaseOptionsPlatformSpecificOptionsInternal : IGettable<XboxOneGDKDLCVerifyPurchaseOptionsPlatformSpecificOptions>, ISettable<XboxOneGDKDLCVerifyPurchaseOptionsPlatformSpecificOptions>, IDisposable // TypeDefIndex: 10207
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_ItemId; // 0x8
	private IntPtr m_XSTSToken; // 0x10

	// Properties
	public Utf8String ItemId { get; set; }
	public Utf8String XSTSToken { get; set; }

	// Methods

	// RVA: 0x43CEF0 Offset: 0x43C0F0 VA: 0x18043CEF0
	public Utf8String get_ItemId() { }

	// RVA: 0x43CFD0 Offset: 0x43C1D0 VA: 0x18043CFD0
	public void set_ItemId(Utf8String value) { }

	// RVA: 0x43CF60 Offset: 0x43C160 VA: 0x18043CF60
	public Utf8String get_XSTSToken() { }

	// RVA: 0x43D030 Offset: 0x43C230 VA: 0x18043D030
	public void set_XSTSToken(Utf8String value) { }

	// RVA: 0x43CD30 Offset: 0x43BF30 VA: 0x18043CD30 Slot: 5
	public void Set(ref XboxOneGDKDLCVerifyPurchaseOptionsPlatformSpecificOptions other) { }

	// RVA: 0x43CDF0 Offset: 0x43BFF0 VA: 0x18043CDF0 Slot: 6
	public void Set(ref Nullable<XboxOneGDKDLCVerifyPurchaseOptionsPlatformSpecificOptions> other) { }

	// RVA: 0x43CCB0 Offset: 0x43BEB0 VA: 0x18043CCB0 Slot: 7
	public void Dispose() { }

	// RVA: 0x43CD10 Offset: 0x43BF10 VA: 0x18043CD10 Slot: 4
	public void Get(out XboxOneGDKDLCVerifyPurchaseOptionsPlatformSpecificOptions output) { }
}

// Namespace: Epic.OnlineServices.ReceiptValidator
public struct XboxOneGDKIAPVerifyPurchaseOptions // TypeDefIndex: 10208
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private ProductUserId <TargetUserId>k__BackingField; // 0x8
	[CompilerGenerated]
	private ReceiptValidatorVendorType <VendorType>k__BackingField; // 0x10
	[CompilerGenerated]
	private ReceiptValidatorEntitlementType <EntitlementType>k__BackingField; // 0x14
	[CompilerGenerated]
	private Nullable<XboxOneGDKIAPVerifyPurchaseOptionsPlatformSpecificOptions> <PlatformSpecificOptions>k__BackingField; // 0x18

	// Properties
	public ProductUserId LocalUserId { get; set; }
	public ProductUserId TargetUserId { get; set; }
	public ReceiptValidatorVendorType VendorType { get; set; }
	public ReceiptValidatorEntitlementType EntitlementType { get; set; }
	public Nullable<XboxOneGDKIAPVerifyPurchaseOptionsPlatformSpecificOptions> PlatformSpecificOptions { get; set; }

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

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public ReceiptValidatorVendorType get_VendorType() { }

	[CompilerGenerated]
	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_VendorType(ReceiptValidatorVendorType value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500
	public ReceiptValidatorEntitlementType get_EntitlementType() { }

	[CompilerGenerated]
	// RVA: 0x426530 Offset: 0x425730 VA: 0x180426530
	public void set_EntitlementType(ReceiptValidatorEntitlementType value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x426510 Offset: 0x425710 VA: 0x180426510
	public Nullable<XboxOneGDKIAPVerifyPurchaseOptionsPlatformSpecificOptions> get_PlatformSpecificOptions() { }

	[CompilerGenerated]
	// RVA: 0x426540 Offset: 0x425740 VA: 0x180426540
	public void set_PlatformSpecificOptions(Nullable<XboxOneGDKIAPVerifyPurchaseOptionsPlatformSpecificOptions> value) { }
}

// Namespace: Epic.OnlineServices.ReceiptValidator
internal struct XboxOneGDKIAPVerifyPurchaseOptionsInternal : ISettable<XboxOneGDKIAPVerifyPurchaseOptions>, IDisposable // TypeDefIndex: 10209
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_TargetUserId; // 0x10
	private ReceiptValidatorVendorType m_VendorType; // 0x18
	private ReceiptValidatorEntitlementType m_EntitlementType; // 0x1C
	private IntPtr m_PlatformSpecificOptions; // 0x20

	// Properties
	public ProductUserId LocalUserId { set; }
	public ProductUserId TargetUserId { set; }
	public ReceiptValidatorVendorType VendorType { set; }
	public ReceiptValidatorEntitlementType EntitlementType { set; }
	public Nullable<XboxOneGDKIAPVerifyPurchaseOptionsPlatformSpecificOptions> PlatformSpecificOptions { set; }

	// Methods

	// RVA: 0x43D4C0 Offset: 0x43C6C0 VA: 0x18043D4C0
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x43D590 Offset: 0x43C790 VA: 0x18043D590
	public void set_TargetUserId(ProductUserId value) { }

	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	public void set_VendorType(ReceiptValidatorVendorType value) { }

	// RVA: 0x3F9290 Offset: 0x3F8490 VA: 0x1803F9290
	public void set_EntitlementType(ReceiptValidatorEntitlementType value) { }

	// RVA: 0x43D520 Offset: 0x43C720 VA: 0x18043D520
	public void set_PlatformSpecificOptions(Nullable<XboxOneGDKIAPVerifyPurchaseOptionsPlatformSpecificOptions> value) { }

	// RVA: 0x43D1D0 Offset: 0x43C3D0 VA: 0x18043D1D0 Slot: 4
	public void Set(ref XboxOneGDKIAPVerifyPurchaseOptions other) { }

	// RVA: 0x43D300 Offset: 0x43C500 VA: 0x18043D300 Slot: 5
	public void Set(ref Nullable<XboxOneGDKIAPVerifyPurchaseOptions> other) { }

	// RVA: 0x43D170 Offset: 0x43C370 VA: 0x18043D170 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.ReceiptValidator
public struct XboxOneGDKIAPVerifyPurchaseOptionsPlatformSpecificOptions // TypeDefIndex: 10210
{
	// Fields
	[CompilerGenerated]
	private Utf8String <ItemId>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <XSTSToken>k__BackingField; // 0x8

	// Properties
	public Utf8String ItemId { get; set; }
	public Utf8String XSTSToken { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Utf8String get_ItemId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_ItemId(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public Utf8String get_XSTSToken() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_XSTSToken(Utf8String value) { }

	// RVA: 0x43D9D0 Offset: 0x43CBD0 VA: 0x18043D9D0
	internal void Set(ref XboxOneGDKIAPVerifyPurchaseOptionsPlatformSpecificOptionsInternal other) { }
}

// Namespace: Epic.OnlineServices.ReceiptValidator
internal struct XboxOneGDKIAPVerifyPurchaseOptionsPlatformSpecificOptionsInternal : IGettable<XboxOneGDKIAPVerifyPurchaseOptionsPlatformSpecificOptions>, ISettable<XboxOneGDKIAPVerifyPurchaseOptionsPlatformSpecificOptions>, IDisposable // TypeDefIndex: 10211
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_ItemId; // 0x8
	private IntPtr m_XSTSToken; // 0x10

	// Properties
	public Utf8String ItemId { get; set; }
	public Utf8String XSTSToken { get; set; }

	// Methods

	// RVA: 0x43D830 Offset: 0x43CA30 VA: 0x18043D830
	public Utf8String get_ItemId() { }

	// RVA: 0x43D910 Offset: 0x43CB10 VA: 0x18043D910
	public void set_ItemId(Utf8String value) { }

	// RVA: 0x43D8A0 Offset: 0x43CAA0 VA: 0x18043D8A0
	public Utf8String get_XSTSToken() { }

	// RVA: 0x43D970 Offset: 0x43CB70 VA: 0x18043D970
	public void set_XSTSToken(Utf8String value) { }

	// RVA: 0x43D770 Offset: 0x43C970 VA: 0x18043D770 Slot: 5
	public void Set(ref XboxOneGDKIAPVerifyPurchaseOptionsPlatformSpecificOptions other) { }

	// RVA: 0x43D670 Offset: 0x43C870 VA: 0x18043D670 Slot: 6
	public void Set(ref Nullable<XboxOneGDKIAPVerifyPurchaseOptionsPlatformSpecificOptions> other) { }

	// RVA: 0x43D5F0 Offset: 0x43C7F0 VA: 0x18043D5F0 Slot: 7
	public void Dispose() { }

	// RVA: 0x43D650 Offset: 0x43C850 VA: 0x18043D650 Slot: 4
	public void Get(out XboxOneGDKIAPVerifyPurchaseOptionsPlatformSpecificOptions output) { }
}

// Namespace: Epic.OnlineServices.ReceiptValidator
public struct XSXDLCVerifyPurchaseOptions // TypeDefIndex: 10212
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private ProductUserId <TargetUserId>k__BackingField; // 0x8
	[CompilerGenerated]
	private ReceiptValidatorVendorType <VendorType>k__BackingField; // 0x10
	[CompilerGenerated]
	private ReceiptValidatorEntitlementType <EntitlementType>k__BackingField; // 0x14
	[CompilerGenerated]
	private Nullable<XSXDLCVerifyPurchaseOptionsPlatformSpecificOptions> <PlatformSpecificOptions>k__BackingField; // 0x18

	// Properties
	public ProductUserId LocalUserId { get; set; }
	public ProductUserId TargetUserId { get; set; }
	public ReceiptValidatorVendorType VendorType { get; set; }
	public ReceiptValidatorEntitlementType EntitlementType { get; set; }
	public Nullable<XSXDLCVerifyPurchaseOptionsPlatformSpecificOptions> PlatformSpecificOptions { get; set; }

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
	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public ReceiptValidatorVendorType get_VendorType() { }

	[CompilerGenerated]
	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_VendorType(ReceiptValidatorVendorType value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500
	public ReceiptValidatorEntitlementType get_EntitlementType() { }

	[CompilerGenerated]
	// RVA: 0x426530 Offset: 0x425730 VA: 0x180426530
	public void set_EntitlementType(ReceiptValidatorEntitlementType value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x426510 Offset: 0x425710 VA: 0x180426510
	public Nullable<XSXDLCVerifyPurchaseOptionsPlatformSpecificOptions> get_PlatformSpecificOptions() { }

	[CompilerGenerated]
	// RVA: 0x426540 Offset: 0x425740 VA: 0x180426540
	public void set_PlatformSpecificOptions(Nullable<XSXDLCVerifyPurchaseOptionsPlatformSpecificOptions> value) { }
}

// Namespace: Epic.OnlineServices.ReceiptValidator
internal struct XSXDLCVerifyPurchaseOptionsInternal : ISettable<XSXDLCVerifyPurchaseOptions>, IDisposable // TypeDefIndex: 10213
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_TargetUserId; // 0x10
	private ReceiptValidatorVendorType m_VendorType; // 0x18
	private ReceiptValidatorEntitlementType m_EntitlementType; // 0x1C
	private IntPtr m_PlatformSpecificOptions; // 0x20

	// Properties
	public ProductUserId LocalUserId { set; }
	public ProductUserId TargetUserId { set; }
	public ReceiptValidatorVendorType VendorType { set; }
	public ReceiptValidatorEntitlementType EntitlementType { set; }
	public Nullable<XSXDLCVerifyPurchaseOptionsPlatformSpecificOptions> PlatformSpecificOptions { set; }

	// Methods

	// RVA: 0x43B900 Offset: 0x43AB00 VA: 0x18043B900
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x43B9D0 Offset: 0x43ABD0 VA: 0x18043B9D0
	public void set_TargetUserId(ProductUserId value) { }

	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	public void set_VendorType(ReceiptValidatorVendorType value) { }

	// RVA: 0x3F9290 Offset: 0x3F8490 VA: 0x1803F9290
	public void set_EntitlementType(ReceiptValidatorEntitlementType value) { }

	// RVA: 0x43B960 Offset: 0x43AB60 VA: 0x18043B960
	public void set_PlatformSpecificOptions(Nullable<XSXDLCVerifyPurchaseOptionsPlatformSpecificOptions> value) { }

	// RVA: 0x43B610 Offset: 0x43A810 VA: 0x18043B610 Slot: 4
	public void Set(ref XSXDLCVerifyPurchaseOptions other) { }

	// RVA: 0x43B740 Offset: 0x43A940 VA: 0x18043B740 Slot: 5
	public void Set(ref Nullable<XSXDLCVerifyPurchaseOptions> other) { }

	// RVA: 0x43B5B0 Offset: 0x43A7B0 VA: 0x18043B5B0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.ReceiptValidator
public struct XSXDLCVerifyPurchaseOptionsPlatformSpecificOptions // TypeDefIndex: 10214
{
	// Fields
	[CompilerGenerated]
	private Utf8String <ItemId>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <XSTSToken>k__BackingField; // 0x8

	// Properties
	public Utf8String ItemId { get; set; }
	public Utf8String XSTSToken { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Utf8String get_ItemId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_ItemId(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public Utf8String get_XSTSToken() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_XSTSToken(Utf8String value) { }

	// RVA: 0x43BE10 Offset: 0x43B010 VA: 0x18043BE10
	internal void Set(ref XSXDLCVerifyPurchaseOptionsPlatformSpecificOptionsInternal other) { }
}

// Namespace: Epic.OnlineServices.ReceiptValidator
internal struct XSXDLCVerifyPurchaseOptionsPlatformSpecificOptionsInternal : IGettable<XSXDLCVerifyPurchaseOptionsPlatformSpecificOptions>, ISettable<XSXDLCVerifyPurchaseOptionsPlatformSpecificOptions>, IDisposable // TypeDefIndex: 10215
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_ItemId; // 0x8
	private IntPtr m_XSTSToken; // 0x10

	// Properties
	public Utf8String ItemId { get; set; }
	public Utf8String XSTSToken { get; set; }

	// Methods

	// RVA: 0x43BC70 Offset: 0x43AE70 VA: 0x18043BC70
	public Utf8String get_ItemId() { }

	// RVA: 0x43BD50 Offset: 0x43AF50 VA: 0x18043BD50
	public void set_ItemId(Utf8String value) { }

	// RVA: 0x43BCE0 Offset: 0x43AEE0 VA: 0x18043BCE0
	public Utf8String get_XSTSToken() { }

	// RVA: 0x43BDB0 Offset: 0x43AFB0 VA: 0x18043BDB0
	public void set_XSTSToken(Utf8String value) { }

	// RVA: 0x43BAB0 Offset: 0x43ACB0 VA: 0x18043BAB0 Slot: 5
	public void Set(ref XSXDLCVerifyPurchaseOptionsPlatformSpecificOptions other) { }

	// RVA: 0x43BB70 Offset: 0x43AD70 VA: 0x18043BB70 Slot: 6
	public void Set(ref Nullable<XSXDLCVerifyPurchaseOptionsPlatformSpecificOptions> other) { }

	// RVA: 0x43BA30 Offset: 0x43AC30 VA: 0x18043BA30 Slot: 7
	public void Dispose() { }

	// RVA: 0x43BA90 Offset: 0x43AC90 VA: 0x18043BA90 Slot: 4
	public void Get(out XSXDLCVerifyPurchaseOptionsPlatformSpecificOptions output) { }
}

// Namespace: Epic.OnlineServices.ReceiptValidator
public struct XSXIAPVerifyPurchaseOptions // TypeDefIndex: 10216
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private ProductUserId <TargetUserId>k__BackingField; // 0x8
	[CompilerGenerated]
	private ReceiptValidatorVendorType <VendorType>k__BackingField; // 0x10
	[CompilerGenerated]
	private ReceiptValidatorEntitlementType <EntitlementType>k__BackingField; // 0x14
	[CompilerGenerated]
	private Nullable<XSXIAPVerifyPurchaseOptionsPlatformSpecificOptions> <PlatformSpecificOptions>k__BackingField; // 0x18

	// Properties
	public ProductUserId LocalUserId { get; set; }
	public ProductUserId TargetUserId { get; set; }
	public ReceiptValidatorVendorType VendorType { get; set; }
	public ReceiptValidatorEntitlementType EntitlementType { get; set; }
	public Nullable<XSXIAPVerifyPurchaseOptionsPlatformSpecificOptions> PlatformSpecificOptions { get; set; }

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

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public ReceiptValidatorVendorType get_VendorType() { }

	[CompilerGenerated]
	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_VendorType(ReceiptValidatorVendorType value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500
	public ReceiptValidatorEntitlementType get_EntitlementType() { }

	[CompilerGenerated]
	// RVA: 0x426530 Offset: 0x425730 VA: 0x180426530
	public void set_EntitlementType(ReceiptValidatorEntitlementType value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x426510 Offset: 0x425710 VA: 0x180426510
	public Nullable<XSXIAPVerifyPurchaseOptionsPlatformSpecificOptions> get_PlatformSpecificOptions() { }

	[CompilerGenerated]
	// RVA: 0x426540 Offset: 0x425740 VA: 0x180426540
	public void set_PlatformSpecificOptions(Nullable<XSXIAPVerifyPurchaseOptionsPlatformSpecificOptions> value) { }
}

// Namespace: Epic.OnlineServices.ReceiptValidator
internal struct XSXIAPVerifyPurchaseOptionsInternal : ISettable<XSXIAPVerifyPurchaseOptions>, IDisposable // TypeDefIndex: 10217
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_TargetUserId; // 0x10
	private ReceiptValidatorVendorType m_VendorType; // 0x18
	private ReceiptValidatorEntitlementType m_EntitlementType; // 0x1C
	private IntPtr m_PlatformSpecificOptions; // 0x20

	// Properties
	public ProductUserId LocalUserId { set; }
	public ProductUserId TargetUserId { set; }
	public ReceiptValidatorVendorType VendorType { set; }
	public ReceiptValidatorEntitlementType EntitlementType { set; }
	public Nullable<XSXIAPVerifyPurchaseOptionsPlatformSpecificOptions> PlatformSpecificOptions { set; }

	// Methods

	// RVA: 0x43C240 Offset: 0x43B440 VA: 0x18043C240
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x43C310 Offset: 0x43B510 VA: 0x18043C310
	public void set_TargetUserId(ProductUserId value) { }

	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	public void set_VendorType(ReceiptValidatorVendorType value) { }

	// RVA: 0x3F9290 Offset: 0x3F8490 VA: 0x1803F9290
	public void set_EntitlementType(ReceiptValidatorEntitlementType value) { }

	// RVA: 0x43C2A0 Offset: 0x43B4A0 VA: 0x18043C2A0
	public void set_PlatformSpecificOptions(Nullable<XSXIAPVerifyPurchaseOptionsPlatformSpecificOptions> value) { }

	// RVA: 0x43BF50 Offset: 0x43B150 VA: 0x18043BF50 Slot: 4
	public void Set(ref XSXIAPVerifyPurchaseOptions other) { }

	// RVA: 0x43C080 Offset: 0x43B280 VA: 0x18043C080 Slot: 5
	public void Set(ref Nullable<XSXIAPVerifyPurchaseOptions> other) { }

	// RVA: 0x43BEF0 Offset: 0x43B0F0 VA: 0x18043BEF0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.ReceiptValidator
public struct XSXIAPVerifyPurchaseOptionsPlatformSpecificOptions // TypeDefIndex: 10218
{
	// Fields
	[CompilerGenerated]
	private Utf8String <ItemId>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <XSTSToken>k__BackingField; // 0x8

	// Properties
	public Utf8String ItemId { get; set; }
	public Utf8String XSTSToken { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Utf8String get_ItemId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_ItemId(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public Utf8String get_XSTSToken() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_XSTSToken(Utf8String value) { }

	// RVA: 0x43C750 Offset: 0x43B950 VA: 0x18043C750
	internal void Set(ref XSXIAPVerifyPurchaseOptionsPlatformSpecificOptionsInternal other) { }
}

// Namespace: Epic.OnlineServices.ReceiptValidator
internal struct XSXIAPVerifyPurchaseOptionsPlatformSpecificOptionsInternal : IGettable<XSXIAPVerifyPurchaseOptionsPlatformSpecificOptions>, ISettable<XSXIAPVerifyPurchaseOptionsPlatformSpecificOptions>, IDisposable // TypeDefIndex: 10219
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_ItemId; // 0x8
	private IntPtr m_XSTSToken; // 0x10

	// Properties
	public Utf8String ItemId { get; set; }
	public Utf8String XSTSToken { get; set; }

	// Methods

	// RVA: 0x43C5B0 Offset: 0x43B7B0 VA: 0x18043C5B0
	public Utf8String get_ItemId() { }

	// RVA: 0x43C690 Offset: 0x43B890 VA: 0x18043C690
	public void set_ItemId(Utf8String value) { }

	// RVA: 0x43C620 Offset: 0x43B820 VA: 0x18043C620
	public Utf8String get_XSTSToken() { }

	// RVA: 0x43C6F0 Offset: 0x43B8F0 VA: 0x18043C6F0
	public void set_XSTSToken(Utf8String value) { }

	// RVA: 0x43C4F0 Offset: 0x43B6F0 VA: 0x18043C4F0 Slot: 5
	public void Set(ref XSXIAPVerifyPurchaseOptionsPlatformSpecificOptions other) { }

	// RVA: 0x43C3F0 Offset: 0x43B5F0 VA: 0x18043C3F0 Slot: 6
	public void Set(ref Nullable<XSXIAPVerifyPurchaseOptionsPlatformSpecificOptions> other) { }

	// RVA: 0x43C370 Offset: 0x43B570 VA: 0x18043C370 Slot: 7
	public void Dispose() { }

	// RVA: 0x43C3D0 Offset: 0x43B5D0 VA: 0x18043C3D0 Slot: 4
	public void Get(out XSXIAPVerifyPurchaseOptionsPlatformSpecificOptions output) { }
}

// Namespace: Epic.OnlineServices.Platform
public struct AndroidInitializeOptions // TypeDefIndex: 10220
{
	// Fields
	[CompilerGenerated]
	private IntPtr <AllocateMemoryFunction>k__BackingField; // 0x0
	[CompilerGenerated]
	private IntPtr <ReallocateMemoryFunction>k__BackingField; // 0x8
	[CompilerGenerated]
	private IntPtr <ReleaseMemoryFunction>k__BackingField; // 0x10
	[CompilerGenerated]
	private Utf8String <ProductName>k__BackingField; // 0x18
	[CompilerGenerated]
	private Utf8String <ProductVersion>k__BackingField; // 0x20
	[CompilerGenerated]
	private IntPtr <Reserved>k__BackingField; // 0x28
	[CompilerGenerated]
	private Nullable<AndroidInitializeOptionsSystemInitializeOptions> <SystemInitializeOptions>k__BackingField; // 0x30
	[CompilerGenerated]
	private Nullable<InitializeThreadAffinity> <OverrideThreadAffinity>k__BackingField; // 0x50

	// Properties
	public IntPtr AllocateMemoryFunction { get; set; }
	public IntPtr ReallocateMemoryFunction { get; set; }
	public IntPtr ReleaseMemoryFunction { get; set; }
	public Utf8String ProductName { get; set; }
	public Utf8String ProductVersion { get; set; }
	public IntPtr Reserved { get; set; }
	public Nullable<AndroidInitializeOptionsSystemInitializeOptions> SystemInitializeOptions { get; set; }
	public Nullable<InitializeThreadAffinity> OverrideThreadAffinity { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public IntPtr get_AllocateMemoryFunction() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_AllocateMemoryFunction(IntPtr value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public IntPtr get_ReallocateMemoryFunction() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_ReallocateMemoryFunction(IntPtr value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public IntPtr get_ReleaseMemoryFunction() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_ReleaseMemoryFunction(IntPtr value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public Utf8String get_ProductName() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_ProductName(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public Utf8String get_ProductVersion() { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_ProductVersion(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public IntPtr get_Reserved() { }

	[CompilerGenerated]
	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	public void set_Reserved(IntPtr value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x427340 Offset: 0x426540 VA: 0x180427340
	public Nullable<AndroidInitializeOptionsSystemInitializeOptions> get_SystemInitializeOptions() { }

	[CompilerGenerated]
	// RVA: 0x427390 Offset: 0x426590 VA: 0x180427390
	public void set_SystemInitializeOptions(Nullable<AndroidInitializeOptionsSystemInitializeOptions> value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x427300 Offset: 0x426500 VA: 0x180427300
	public Nullable<InitializeThreadAffinity> get_OverrideThreadAffinity() { }

	[CompilerGenerated]
	// RVA: 0x427360 Offset: 0x426560 VA: 0x180427360
	public void set_OverrideThreadAffinity(Nullable<InitializeThreadAffinity> value) { }
}

// Namespace: Epic.OnlineServices.Platform
internal struct AndroidInitializeOptionsInternal : ISettable<AndroidInitializeOptions>, IDisposable // TypeDefIndex: 10221
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_AllocateMemoryFunction; // 0x8
	private IntPtr m_ReallocateMemoryFunction; // 0x10
	private IntPtr m_ReleaseMemoryFunction; // 0x18
	private IntPtr m_ProductName; // 0x20
	private IntPtr m_ProductVersion; // 0x28
	private IntPtr m_Reserved; // 0x30
	private IntPtr m_SystemInitializeOptions; // 0x38
	private IntPtr m_OverrideThreadAffinity; // 0x40

	// Properties
	public IntPtr AllocateMemoryFunction { set; }
	public IntPtr ReallocateMemoryFunction { set; }
	public IntPtr ReleaseMemoryFunction { set; }
	public Utf8String ProductName { set; }
	public Utf8String ProductVersion { set; }
	public IntPtr Reserved { set; }
	public Nullable<AndroidInitializeOptionsSystemInitializeOptions> SystemInitializeOptions { set; }
	public Nullable<InitializeThreadAffinity> OverrideThreadAffinity { set; }

	// Methods

	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_AllocateMemoryFunction(IntPtr value) { }

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_ReallocateMemoryFunction(IntPtr value) { }

	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_ReleaseMemoryFunction(IntPtr value) { }

	// RVA: 0x426C40 Offset: 0x425E40 VA: 0x180426C40
	public void set_ProductName(Utf8String value) { }

	// RVA: 0x426CA0 Offset: 0x425EA0 VA: 0x180426CA0
	public void set_ProductVersion(Utf8String value) { }

	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	public void set_Reserved(IntPtr value) { }

	// RVA: 0x426D00 Offset: 0x425F00 VA: 0x180426D00
	public void set_SystemInitializeOptions(Nullable<AndroidInitializeOptionsSystemInitializeOptions> value) { }

	// RVA: 0x426BD0 Offset: 0x425DD0 VA: 0x180426BD0
	public void set_OverrideThreadAffinity(Nullable<InitializeThreadAffinity> value) { }

	// RVA: 0x426600 Offset: 0x425800 VA: 0x180426600 Slot: 4
	public void Set(ref AndroidInitializeOptions other) { }

	// RVA: 0x426880 Offset: 0x425A80 VA: 0x180426880 Slot: 5
	public void Set(ref Nullable<AndroidInitializeOptions> other) { }

	// RVA: 0x426560 Offset: 0x425760 VA: 0x180426560 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Platform
public struct AndroidInitializeOptionsSystemInitializeOptions // TypeDefIndex: 10222
{
	// Fields
	[CompilerGenerated]
	private IntPtr <Reserved>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <OptionalInternalDirectory>k__BackingField; // 0x8
	[CompilerGenerated]
	private Utf8String <OptionalExternalDirectory>k__BackingField; // 0x10

	// Properties
	public IntPtr Reserved { get; set; }
	public Utf8String OptionalInternalDirectory { get; set; }
	public Utf8String OptionalExternalDirectory { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public IntPtr get_Reserved() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_Reserved(IntPtr value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public Utf8String get_OptionalInternalDirectory() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_OptionalInternalDirectory(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Utf8String get_OptionalExternalDirectory() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_OptionalExternalDirectory(Utf8String value) { }

	// RVA: 0x427220 Offset: 0x426420 VA: 0x180427220
	internal void Set(ref AndroidInitializeOptionsSystemInitializeOptionsInternal other) { }
}

// Namespace: Epic.OnlineServices.Platform
internal struct AndroidInitializeOptionsSystemInitializeOptionsInternal : IGettable<AndroidInitializeOptionsSystemInitializeOptions>, ISettable<AndroidInitializeOptionsSystemInitializeOptions>, IDisposable // TypeDefIndex: 10223
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_Reserved; // 0x8
	private IntPtr m_OptionalInternalDirectory; // 0x10
	private IntPtr m_OptionalExternalDirectory; // 0x18

	// Properties
	public IntPtr Reserved { get; set; }
	public Utf8String OptionalInternalDirectory { get; set; }
	public Utf8String OptionalExternalDirectory { get; set; }

	// Methods

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public IntPtr get_Reserved() { }

	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_Reserved(IntPtr value) { }

	// RVA: 0x4270F0 Offset: 0x4262F0 VA: 0x1804270F0
	public Utf8String get_OptionalInternalDirectory() { }

	// RVA: 0x4271C0 Offset: 0x4263C0 VA: 0x1804271C0
	public void set_OptionalInternalDirectory(Utf8String value) { }

	// RVA: 0x427080 Offset: 0x426280 VA: 0x180427080
	public Utf8String get_OptionalExternalDirectory() { }

	// RVA: 0x427160 Offset: 0x426360 VA: 0x180427160
	public void set_OptionalExternalDirectory(Utf8String value) { }

	// RVA: 0x426DF0 Offset: 0x425FF0 VA: 0x180426DF0 Slot: 5
	public void Set(ref AndroidInitializeOptionsSystemInitializeOptions other) { }

	// RVA: 0x426EB0 Offset: 0x4260B0 VA: 0x180426EB0 Slot: 6
	public void Set(ref Nullable<AndroidInitializeOptionsSystemInitializeOptions> other) { }

	// RVA: 0x426D70 Offset: 0x425F70 VA: 0x180426D70 Slot: 7
	public void Dispose() { }

	// RVA: 0x426DD0 Offset: 0x425FD0 VA: 0x180426DD0 Slot: 4
	public void Get(out AndroidInitializeOptionsSystemInitializeOptions output) { }
}

// Namespace: Epic.OnlineServices.Platform
public sealed class PlatformInterface : Handle // TypeDefIndex: 10224
{
	// Fields
	public const int AndroidInitializeoptionssysteminitializeoptionsApiLatest = 2;
	public static readonly Utf8String CheckforlauncherandrestartEnvVar; // 0x0
	public const int ClientcredentialsClientidMaxLength = 64;
	public const int ClientcredentialsClientsecretMaxLength = 64;
	public const int CountrycodeMaxBufferLen = 5;
	public const int CountrycodeMaxLength = 4;
	public const int GetdesktopcrossplaystatusApiLatest = 1;
	public const int InitializeApiLatest = 4;
	public const int InitializeThreadaffinityApiLatest = 3;
	public const int InitializeoptionsProductnameMaxLength = 64;
	public const int InitializeoptionsProductversionMaxLength = 64;
	public const int LocalecodeMaxBufferLen = 10;
	public const int LocalecodeMaxLength = 9;
	public const int OptionsApiLatest = 14;
	public const int OptionsDeploymentidMaxLength = 64;
	public const int OptionsEncryptionkeyLength = 64;
	public const int OptionsProductidMaxLength = 64;
	public const int OptionsSandboxidMaxLength = 64;
	public const int RtcoptionsApiLatest = 2;
	public const int Ps4InitializeoptionssysteminitializeoptionsApiLatest = 8;
	public const int Ps5InitializeoptionssysteminitializeoptionsApiLatest = 3;
	public const int WindowsRtcoptionsplatformspecificoptionsApiLatest = 1;
	public const int XboxonegdkInitializeoptionssysteminitializeoptionsApiLatest = 3;
	public const int XboxonegdkOptionssystemspecificoptionsApiLatest = 1;
	public const int XsxInitializeoptionssysteminitializeoptionsApiLatest = 3;
	public const int XsxOptionssystemspecificoptionsApiLatest = 1;

	// Methods

	// RVA: 0x434C20 Offset: 0x433E20 VA: 0x180434C20
	public static Result Initialize(ref AndroidInitializeOptions options) { }

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }

	// RVA: 0x40BDB0 Offset: 0x40AFB0 VA: 0x18040BDB0
	public void .ctor(IntPtr innerHandle) { }

	// RVA: 0x433540 Offset: 0x432740 VA: 0x180433540
	public Result CheckForLauncherAndRestart() { }

	// RVA: 0x433850 Offset: 0x432A50 VA: 0x180433850
	public static PlatformInterface Create(ref Options options) { }

	// RVA: 0x433950 Offset: 0x432B50 VA: 0x180433950
	public AchievementsInterface GetAchievementsInterface() { }

	// RVA: 0x4339D0 Offset: 0x432BD0 VA: 0x1804339D0
	public Result GetActiveCountryCode(EpicAccountId localUserId, out Utf8String outBuffer) { }

	// RVA: 0x433A90 Offset: 0x432C90 VA: 0x180433A90
	public Result GetActiveLocaleCode(EpicAccountId localUserId, out Utf8String outBuffer) { }

	// RVA: 0x433B50 Offset: 0x432D50 VA: 0x180433B50
	public AntiCheatClientInterface GetAntiCheatClientInterface() { }

	// RVA: 0x433BD0 Offset: 0x432DD0 VA: 0x180433BD0
	public AntiCheatServerInterface GetAntiCheatServerInterface() { }

	// RVA: 0x433C50 Offset: 0x432E50 VA: 0x180433C50
	public ApplicationStatus GetApplicationStatus() { }

	// RVA: 0x433C60 Offset: 0x432E60 VA: 0x180433C60
	public AuthInterface GetAuthInterface() { }

	// RVA: 0x433CE0 Offset: 0x432EE0 VA: 0x180433CE0
	public ConnectInterface GetConnectInterface() { }

	// RVA: 0x433D60 Offset: 0x432F60 VA: 0x180433D60
	public CustomInvitesInterface GetCustomInvitesInterface() { }

	// RVA: 0x433DE0 Offset: 0x432FE0 VA: 0x180433DE0
	public Result GetDesktopCrossplayStatus(ref GetDesktopCrossplayStatusOptions options, out DesktopCrossplayStatusInfo outDesktopCrossplayStatusInfo) { }

	// RVA: 0x433EB0 Offset: 0x4330B0 VA: 0x180433EB0
	public EcomInterface GetEcomInterface() { }

	// RVA: 0x433F30 Offset: 0x433130 VA: 0x180433F30
	public FriendsInterface GetFriendsInterface() { }

	// RVA: 0x433FB0 Offset: 0x4331B0 VA: 0x180433FB0
	public IntegratedPlatformInterface GetIntegratedPlatformInterface() { }

	// RVA: 0x434030 Offset: 0x433230 VA: 0x180434030
	public InventoryInterface GetInventoryInterface() { }

	// RVA: 0x4340B0 Offset: 0x4332B0 VA: 0x1804340B0
	public KWSInterface GetKWSInterface() { }

	// RVA: 0x434130 Offset: 0x433330 VA: 0x180434130
	public LeaderboardsInterface GetLeaderboardsInterface() { }

	// RVA: 0x4341B0 Offset: 0x4333B0 VA: 0x1804341B0
	public LobbyInterface GetLobbyInterface() { }

	// RVA: 0x434230 Offset: 0x433430 VA: 0x180434230
	public MetricsInterface GetMetricsInterface() { }

	// RVA: 0x4342B0 Offset: 0x4334B0 VA: 0x1804342B0
	public ModsInterface GetModsInterface() { }

	// RVA: 0x434330 Offset: 0x433530 VA: 0x180434330
	public NetworkStatus GetNetworkStatus() { }

	// RVA: 0x434340 Offset: 0x433540 VA: 0x180434340
	public Result GetOverrideCountryCode(out Utf8String outBuffer) { }

	// RVA: 0x4343E0 Offset: 0x4335E0 VA: 0x1804343E0
	public Result GetOverrideLocaleCode(out Utf8String outBuffer) { }

	// RVA: 0x434480 Offset: 0x433680 VA: 0x180434480
	public P2PInterface GetP2PInterface() { }

	// RVA: 0x434500 Offset: 0x433700 VA: 0x180434500
	public PlayerDataStorageInterface GetPlayerDataStorageInterface() { }

	// RVA: 0x434580 Offset: 0x433780 VA: 0x180434580
	public PresenceInterface GetPresenceInterface() { }

	// RVA: 0x434600 Offset: 0x433800 VA: 0x180434600
	public ProgressionSnapshotInterface GetProgressionSnapshotInterface() { }

	// RVA: 0x434680 Offset: 0x433880 VA: 0x180434680
	public RTCAdminInterface GetRTCAdminInterface() { }

	// RVA: 0x434700 Offset: 0x433900 VA: 0x180434700
	public RTCInterface GetRTCInterface() { }

	// RVA: 0x434780 Offset: 0x433980 VA: 0x180434780
	public ReceiptValidatorInterface GetReceiptValidatorInterface() { }

	// RVA: 0x434800 Offset: 0x433A00 VA: 0x180434800
	public ReportsInterface GetReportsInterface() { }

	// RVA: 0x434880 Offset: 0x433A80 VA: 0x180434880
	public SanctionsInterface GetSanctionsInterface() { }

	// RVA: 0x434900 Offset: 0x433B00 VA: 0x180434900
	public SessionsInterface GetSessionsInterface() { }

	// RVA: 0x434980 Offset: 0x433B80 VA: 0x180434980
	public StatsInterface GetStatsInterface() { }

	// RVA: 0x434A00 Offset: 0x433C00 VA: 0x180434A00
	public TitleStorageInterface GetTitleStorageInterface() { }

	// RVA: 0x434A80 Offset: 0x433C80 VA: 0x180434A80
	public UIInterface GetUIInterface() { }

	// RVA: 0x434B00 Offset: 0x433D00 VA: 0x180434B00
	public UserInfoInterface GetUserInfoInterface() { }

	// RVA: 0x434E00 Offset: 0x434000 VA: 0x180434E00
	public static Result Initialize(ref InitializeOptions options) { }

	// RVA: 0x434F50 Offset: 0x434150 VA: 0x180434F50
	public void Release() { }

	// RVA: 0x434F60 Offset: 0x434160 VA: 0x180434F60
	public Result SetApplicationStatus(ApplicationStatus newStatus) { }

	// RVA: 0x434F70 Offset: 0x434170 VA: 0x180434F70
	public Result SetNetworkStatus(NetworkStatus newStatus) { }

	// RVA: 0x434F80 Offset: 0x434180 VA: 0x180434F80
	public Result SetOverrideCountryCode(Utf8String newCountryCode) { }

	// RVA: 0x435010 Offset: 0x434210 VA: 0x180435010
	public Result SetOverrideLocaleCode(Utf8String newLocaleCode) { }

	// RVA: 0x4350A0 Offset: 0x4342A0 VA: 0x1804350A0
	public static Result Shutdown() { }

	// RVA: 0x4350B0 Offset: 0x4342B0 VA: 0x1804350B0
	public void Tick() { }

	// RVA: 0x435130 Offset: 0x434330 VA: 0x180435130
	public static Utf8String ToString(ApplicationStatus applicationStatus) { }

	// RVA: 0x4350C0 Offset: 0x4342C0 VA: 0x1804350C0
	public static Utf8String ToString(NetworkStatus networkStatus) { }

	// RVA: 0x434D60 Offset: 0x433F60 VA: 0x180434D60
	public static Result Initialize(ref PS4InitializeOptions options) { }

	// RVA: 0x434F40 Offset: 0x434140 VA: 0x180434F40
	public Result ManagedByApplicationNotificationMessages(IntPtr inEvent) { }

	// RVA: 0x434EA0 Offset: 0x4340A0 VA: 0x180434EA0
	public static Result Initialize(ref PS5InitializeOptions options) { }

	// RVA: 0x433750 Offset: 0x432950 VA: 0x180433750
	public static PlatformInterface Create(ref WindowsOptions options) { }

	// RVA: 0x433650 Offset: 0x432850 VA: 0x180433650
	public static PlatformInterface Create(ref XboxOneGDKOptions options) { }

	// RVA: 0x434CC0 Offset: 0x433EC0 VA: 0x180434CC0
	public static Result Initialize(ref XboxOneGDKInitializeOptions options) { }

	// RVA: 0x433550 Offset: 0x432750 VA: 0x180433550
	public static PlatformInterface Create(ref XSXOptions options) { }

	// RVA: 0x434B80 Offset: 0x433D80 VA: 0x180434B80
	public static Result Initialize(ref XSXInitializeOptions options) { }

	// RVA: 0x4351A0 Offset: 0x4343A0 VA: 0x1804351A0
	private static void .cctor() { }
}

// Namespace: Epic.OnlineServices.Platform
[UnmanagedFunctionPointer(2)]
public sealed class AllocateMemoryFunc : MulticastDelegate // TypeDefIndex: 10225
{
	// Methods

	// RVA: 0x425B20 Offset: 0x424D20 VA: 0x180425B20
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual IntPtr Invoke(UIntPtr sizeInBytes, UIntPtr alignment) { }

	// RVA: 0x425A50 Offset: 0x424C50 VA: 0x180425A50 Slot: 14
	public virtual IAsyncResult BeginInvoke(UIntPtr sizeInBytes, UIntPtr alignment, AsyncCallback callback, object object) { }

	// RVA: 0x425AE0 Offset: 0x424CE0 VA: 0x180425AE0 Slot: 15
	public virtual IntPtr EndInvoke(IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Platform
public enum ApplicationStatus // TypeDefIndex: 10226
{
	// Fields
	public int value__; // 0x0
	public const ApplicationStatus BackgroundConstrained = 0;
	public const ApplicationStatus BackgroundUnconstrained = 1;
	public const ApplicationStatus BackgroundSuspended = 2;
	public const ApplicationStatus Foreground = 3;
}

// Namespace: Epic.OnlineServices.Platform
public struct ClientCredentials // TypeDefIndex: 10227
{
	// Fields
	[CompilerGenerated]
	private Utf8String <ClientId>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <ClientSecret>k__BackingField; // 0x8

	// Properties
	public Utf8String ClientId { get; set; }
	public Utf8String ClientSecret { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Utf8String get_ClientId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_ClientId(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public Utf8String get_ClientSecret() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_ClientSecret(Utf8String value) { }

	// RVA: 0x4291B0 Offset: 0x4283B0 VA: 0x1804291B0
	internal void Set(ref ClientCredentialsInternal other) { }
}

// Namespace: Epic.OnlineServices.Platform
internal struct ClientCredentialsInternal : IGettable<ClientCredentials>, ISettable<ClientCredentials>, IDisposable // TypeDefIndex: 10228
{
	// Fields
	private IntPtr m_ClientId; // 0x0
	private IntPtr m_ClientSecret; // 0x8

	// Properties
	public Utf8String ClientId { get; set; }
	public Utf8String ClientSecret { get; set; }

	// Methods

	// RVA: 0x429010 Offset: 0x428210 VA: 0x180429010
	public Utf8String get_ClientId() { }

	// RVA: 0x4290F0 Offset: 0x4282F0 VA: 0x1804290F0
	public void set_ClientId(Utf8String value) { }

	// RVA: 0x429080 Offset: 0x428280 VA: 0x180429080
	public Utf8String get_ClientSecret() { }

	// RVA: 0x429150 Offset: 0x428350 VA: 0x180429150
	public void set_ClientSecret(Utf8String value) { }

	// RVA: 0x428E60 Offset: 0x428060 VA: 0x180428E60 Slot: 5
	public void Set(ref ClientCredentials other) { }

	// RVA: 0x428F10 Offset: 0x428110 VA: 0x180428F10 Slot: 6
	public void Set(ref Nullable<ClientCredentials> other) { }

	// RVA: 0x428DE0 Offset: 0x427FE0 VA: 0x180428DE0 Slot: 7
	public void Dispose() { }

	// RVA: 0x428E40 Offset: 0x428040 VA: 0x180428E40 Slot: 4
	public void Get(out ClientCredentials output) { }
}

// Namespace: Epic.OnlineServices.Platform
public enum DesktopCrossplayStatus // TypeDefIndex: 10229
{
	// Fields
	public int value__; // 0x0
	public const DesktopCrossplayStatus Ok = 0;
	public const DesktopCrossplayStatus ApplicationNotBootstrapped = 1;
	public const DesktopCrossplayStatus ServiceNotInstalled = 2;
	public const DesktopCrossplayStatus ServiceStartFailed = 3;
	public const DesktopCrossplayStatus ServiceNotRunning = 4;
	public const DesktopCrossplayStatus OverlayDisabled = 5;
	public const DesktopCrossplayStatus OverlayNotInstalled = 6;
	public const DesktopCrossplayStatus OverlayTrustCheckFailed = 7;
	public const DesktopCrossplayStatus OverlayLoadFailed = 8;
}

// Namespace: Epic.OnlineServices.Platform
public struct DesktopCrossplayStatusInfo // TypeDefIndex: 10230
{
	// Fields
	[CompilerGenerated]
	private DesktopCrossplayStatus <Status>k__BackingField; // 0x0
	[CompilerGenerated]
	private int <ServiceInitResult>k__BackingField; // 0x4

	// Properties
	public DesktopCrossplayStatus Status { get; set; }
	public int ServiceInitResult { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public DesktopCrossplayStatus get_Status() { }

	[CompilerGenerated]
	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_Status(DesktopCrossplayStatus value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3F8350 Offset: 0x3F7550 VA: 0x1803F8350
	public int get_ServiceInitResult() { }

	[CompilerGenerated]
	// RVA: 0x3F84A0 Offset: 0x3F76A0 VA: 0x1803F84A0
	public void set_ServiceInitResult(int value) { }

	// RVA: 0x429310 Offset: 0x428510 VA: 0x180429310
	internal void Set(ref DesktopCrossplayStatusInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.Platform
internal struct DesktopCrossplayStatusInfoInternal : IGettable<DesktopCrossplayStatusInfo>, ISettable<DesktopCrossplayStatusInfo>, IDisposable // TypeDefIndex: 10231
{
	// Fields
	private DesktopCrossplayStatus m_Status; // 0x0
	private int m_ServiceInitResult; // 0x4

	// Properties
	public DesktopCrossplayStatus Status { get; set; }
	public int ServiceInitResult { get; set; }

	// Methods

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public DesktopCrossplayStatus get_Status() { }

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_Status(DesktopCrossplayStatus value) { }

	// RVA: 0x3F8350 Offset: 0x3F7550 VA: 0x1803F8350
	public int get_ServiceInitResult() { }

	// RVA: 0x3F84A0 Offset: 0x3F76A0 VA: 0x1803F84A0
	public void set_ServiceInitResult(int value) { }

	// RVA: 0x429310 Offset: 0x428510 VA: 0x180429310 Slot: 5
	public void Set(ref DesktopCrossplayStatusInfo other) { }

	// RVA: 0x4292A0 Offset: 0x4284A0 VA: 0x1804292A0 Slot: 6
	public void Set(ref Nullable<DesktopCrossplayStatusInfo> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 7
	public void Dispose() { }

	// RVA: 0x429290 Offset: 0x428490 VA: 0x180429290 Slot: 4
	public void Get(out DesktopCrossplayStatusInfo output) { }
}

// Namespace: Epic.OnlineServices.Platform
public struct GetDesktopCrossplayStatusOptions // TypeDefIndex: 10232
{}

// Namespace: Epic.OnlineServices.Platform
internal struct GetDesktopCrossplayStatusOptionsInternal : ISettable<GetDesktopCrossplayStatusOptions>, IDisposable // TypeDefIndex: 10233
{
	// Fields
	private int m_ApiVersion; // 0x0

	// Methods

	// RVA: 0x3F98A0 Offset: 0x3F8AA0 VA: 0x1803F98A0 Slot: 4
	public void Set(ref GetDesktopCrossplayStatusOptions other) { }

	// RVA: 0x42A5F0 Offset: 0x4297F0 VA: 0x18042A5F0 Slot: 5
	public void Set(ref Nullable<GetDesktopCrossplayStatusOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Platform
public struct InitializeOptions // TypeDefIndex: 10234
{
	// Fields
	[CompilerGenerated]
	private IntPtr <AllocateMemoryFunction>k__BackingField; // 0x0
	[CompilerGenerated]
	private IntPtr <ReallocateMemoryFunction>k__BackingField; // 0x8
	[CompilerGenerated]
	private IntPtr <ReleaseMemoryFunction>k__BackingField; // 0x10
	[CompilerGenerated]
	private Utf8String <ProductName>k__BackingField; // 0x18
	[CompilerGenerated]
	private Utf8String <ProductVersion>k__BackingField; // 0x20
	[CompilerGenerated]
	private IntPtr <Reserved>k__BackingField; // 0x28
	[CompilerGenerated]
	private IntPtr <SystemInitializeOptions>k__BackingField; // 0x30
	[CompilerGenerated]
	private Nullable<InitializeThreadAffinity> <OverrideThreadAffinity>k__BackingField; // 0x38

	// Properties
	public IntPtr AllocateMemoryFunction { get; set; }
	public IntPtr ReallocateMemoryFunction { get; set; }
	public IntPtr ReleaseMemoryFunction { get; set; }
	public Utf8String ProductName { get; set; }
	public Utf8String ProductVersion { get; set; }
	public IntPtr Reserved { get; set; }
	public IntPtr SystemInitializeOptions { get; set; }
	public Nullable<InitializeThreadAffinity> OverrideThreadAffinity { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public IntPtr get_AllocateMemoryFunction() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_AllocateMemoryFunction(IntPtr value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public IntPtr get_ReallocateMemoryFunction() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_ReallocateMemoryFunction(IntPtr value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public IntPtr get_ReleaseMemoryFunction() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_ReleaseMemoryFunction(IntPtr value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public Utf8String get_ProductName() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_ProductName(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public Utf8String get_ProductVersion() { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_ProductVersion(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public IntPtr get_Reserved() { }

	[CompilerGenerated]
	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	public void set_Reserved(IntPtr value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public IntPtr get_SystemInitializeOptions() { }

	[CompilerGenerated]
	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	public void set_SystemInitializeOptions(IntPtr value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x42B5F0 Offset: 0x42A7F0 VA: 0x18042B5F0
	public Nullable<InitializeThreadAffinity> get_OverrideThreadAffinity() { }

	[CompilerGenerated]
	// RVA: 0x42B630 Offset: 0x42A830 VA: 0x18042B630
	public void set_OverrideThreadAffinity(Nullable<InitializeThreadAffinity> value) { }
}

// Namespace: Epic.OnlineServices.Platform
internal struct InitializeOptionsInternal : ISettable<InitializeOptions>, IDisposable // TypeDefIndex: 10235
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_AllocateMemoryFunction; // 0x8
	private IntPtr m_ReallocateMemoryFunction; // 0x10
	private IntPtr m_ReleaseMemoryFunction; // 0x18
	private IntPtr m_ProductName; // 0x20
	private IntPtr m_ProductVersion; // 0x28
	private IntPtr m_Reserved; // 0x30
	private IntPtr m_SystemInitializeOptions; // 0x38
	private IntPtr m_OverrideThreadAffinity; // 0x40

	// Properties
	public IntPtr AllocateMemoryFunction { set; }
	public IntPtr ReallocateMemoryFunction { set; }
	public IntPtr ReleaseMemoryFunction { set; }
	public Utf8String ProductName { set; }
	public Utf8String ProductVersion { set; }
	public IntPtr Reserved { set; }
	public IntPtr SystemInitializeOptions { set; }
	public Nullable<InitializeThreadAffinity> OverrideThreadAffinity { set; }

	// Methods

	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_AllocateMemoryFunction(IntPtr value) { }

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_ReallocateMemoryFunction(IntPtr value) { }

	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_ReleaseMemoryFunction(IntPtr value) { }

	// RVA: 0x42B530 Offset: 0x42A730 VA: 0x18042B530
	public void set_ProductName(Utf8String value) { }

	// RVA: 0x42B590 Offset: 0x42A790 VA: 0x18042B590
	public void set_ProductVersion(Utf8String value) { }

	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	public void set_Reserved(IntPtr value) { }

	// RVA: 0x40EC50 Offset: 0x40DE50 VA: 0x18040EC50
	public void set_SystemInitializeOptions(IntPtr value) { }

	// RVA: 0x42B4C0 Offset: 0x42A6C0 VA: 0x18042B4C0
	public void set_OverrideThreadAffinity(Nullable<InitializeThreadAffinity> value) { }

	// RVA: 0x42B080 Offset: 0x42A280 VA: 0x18042B080 Slot: 4
	public void Set(ref InitializeOptions other) { }

	// RVA: 0x42B1E0 Offset: 0x42A3E0 VA: 0x18042B1E0 Slot: 5
	public void Set(ref Nullable<InitializeOptions> other) { }

	// RVA: 0x42AFE0 Offset: 0x42A1E0 VA: 0x18042AFE0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Platform
public struct InitializeThreadAffinity // TypeDefIndex: 10236
{
	// Fields
	[CompilerGenerated]
	private ulong <NetworkWork>k__BackingField; // 0x0
	[CompilerGenerated]
	private ulong <StorageIo>k__BackingField; // 0x8
	[CompilerGenerated]
	private ulong <WebSocketIo>k__BackingField; // 0x10
	[CompilerGenerated]
	private ulong <P2PIo>k__BackingField; // 0x18
	[CompilerGenerated]
	private ulong <HttpRequestIo>k__BackingField; // 0x20
	[CompilerGenerated]
	private ulong <RTCIo>k__BackingField; // 0x28
	[CompilerGenerated]
	private ulong <EmbeddedOverlayMainThread>k__BackingField; // 0x30
	[CompilerGenerated]
	private ulong <EmbeddedOverlayWorkerThreads>k__BackingField; // 0x38

	// Properties
	public ulong NetworkWork { get; set; }
	public ulong StorageIo { get; set; }
	public ulong WebSocketIo { get; set; }
	public ulong P2PIo { get; set; }
	public ulong HttpRequestIo { get; set; }
	public ulong RTCIo { get; set; }
	public ulong EmbeddedOverlayMainThread { get; set; }
	public ulong EmbeddedOverlayWorkerThreads { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public ulong get_NetworkWork() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_NetworkWork(ulong value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public ulong get_StorageIo() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_StorageIo(ulong value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public ulong get_WebSocketIo() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_WebSocketIo(ulong value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public ulong get_P2PIo() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_P2PIo(ulong value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public ulong get_HttpRequestIo() { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_HttpRequestIo(ulong value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public ulong get_RTCIo() { }

	[CompilerGenerated]
	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	public void set_RTCIo(ulong value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public ulong get_EmbeddedOverlayMainThread() { }

	[CompilerGenerated]
	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	public void set_EmbeddedOverlayMainThread(ulong value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public ulong get_EmbeddedOverlayWorkerThreads() { }

	[CompilerGenerated]
	// RVA: 0x40EC50 Offset: 0x40DE50 VA: 0x18040EC50
	public void set_EmbeddedOverlayWorkerThreads(ulong value) { }

	// RVA: 0x42B850 Offset: 0x42AA50 VA: 0x18042B850
	internal void Set(ref InitializeThreadAffinityInternal other) { }
}

// Namespace: Epic.OnlineServices.Platform
internal struct InitializeThreadAffinityInternal : IGettable<InitializeThreadAffinity>, ISettable<InitializeThreadAffinity>, IDisposable // TypeDefIndex: 10237
{
	// Fields
	private int m_ApiVersion; // 0x0
	private ulong m_NetworkWork; // 0x8
	private ulong m_StorageIo; // 0x10
	private ulong m_WebSocketIo; // 0x18
	private ulong m_P2PIo; // 0x20
	private ulong m_HttpRequestIo; // 0x28
	private ulong m_RTCIo; // 0x30
	private ulong m_EmbeddedOverlayMainThread; // 0x38
	private ulong m_EmbeddedOverlayWorkerThreads; // 0x40

	// Properties
	public ulong NetworkWork { get; set; }
	public ulong StorageIo { get; set; }
	public ulong WebSocketIo { get; set; }
	public ulong P2PIo { get; set; }
	public ulong HttpRequestIo { get; set; }
	public ulong RTCIo { get; set; }
	public ulong EmbeddedOverlayMainThread { get; set; }
	public ulong EmbeddedOverlayWorkerThreads { get; set; }

	// Methods

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public ulong get_NetworkWork() { }

	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_NetworkWork(ulong value) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public ulong get_StorageIo() { }

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_StorageIo(ulong value) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public ulong get_WebSocketIo() { }

	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_WebSocketIo(ulong value) { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public ulong get_P2PIo() { }

	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_P2PIo(ulong value) { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public ulong get_HttpRequestIo() { }

	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	public void set_HttpRequestIo(ulong value) { }

	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public ulong get_RTCIo() { }

	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	public void set_RTCIo(ulong value) { }

	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public ulong get_EmbeddedOverlayMainThread() { }

	// RVA: 0x40EC50 Offset: 0x40DE50 VA: 0x18040EC50
	public void set_EmbeddedOverlayMainThread(ulong value) { }

	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	public ulong get_EmbeddedOverlayWorkerThreads() { }

	// RVA: 0x415820 Offset: 0x414A20 VA: 0x180415820
	public void set_EmbeddedOverlayWorkerThreads(ulong value) { }

	// RVA: 0x42B800 Offset: 0x42AA00 VA: 0x18042B800 Slot: 5
	public void Set(ref InitializeThreadAffinity other) { }

	// RVA: 0x42B6C0 Offset: 0x42A8C0 VA: 0x18042B6C0 Slot: 6
	public void Set(ref Nullable<InitializeThreadAffinity> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 7
	public void Dispose() { }

	// RVA: 0x42B660 Offset: 0x42A860 VA: 0x18042B660 Slot: 4
	public void Get(out InitializeThreadAffinity output) { }
}

// Namespace: Epic.OnlineServices.Platform
public enum NetworkStatus // TypeDefIndex: 10238
{
	// Fields
	public int value__; // 0x0
	public const NetworkStatus Disabled = 0;
	public const NetworkStatus Offline = 1;
	public const NetworkStatus Online = 2;
}

// Namespace: Epic.OnlineServices.Platform
public struct Options // TypeDefIndex: 10239
{
	// Fields
	[CompilerGenerated]
	private IntPtr <Reserved>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <ProductId>k__BackingField; // 0x8
	[CompilerGenerated]
	private Utf8String <SandboxId>k__BackingField; // 0x10
	[CompilerGenerated]
	private ClientCredentials <ClientCredentials>k__BackingField; // 0x18
	[CompilerGenerated]
	private bool <IsServer>k__BackingField; // 0x28
	[CompilerGenerated]
	private Utf8String <EncryptionKey>k__BackingField; // 0x30
	[CompilerGenerated]
	private Utf8String <OverrideCountryCode>k__BackingField; // 0x38
	[CompilerGenerated]
	private Utf8String <OverrideLocaleCode>k__BackingField; // 0x40
	[CompilerGenerated]
	private Utf8String <DeploymentId>k__BackingField; // 0x48
	[CompilerGenerated]
	private PlatformFlags <Flags>k__BackingField; // 0x50
	[CompilerGenerated]
	private Utf8String <CacheDirectory>k__BackingField; // 0x58
	[CompilerGenerated]
	private uint <TickBudgetInMilliseconds>k__BackingField; // 0x60
	[CompilerGenerated]
	private Nullable<RTCOptions> <RTCOptions>k__BackingField; // 0x68
	[CompilerGenerated]
	private IntegratedPlatformOptionsContainer <IntegratedPlatformOptionsContainerHandle>k__BackingField; // 0x80
	[CompilerGenerated]
	private IntPtr <SystemSpecificOptions>k__BackingField; // 0x88
	[CompilerGenerated]
	private Nullable<double> <TaskNetworkTimeoutSeconds>k__BackingField; // 0x90

	// Properties
	public IntPtr Reserved { get; set; }
	public Utf8String ProductId { get; set; }
	public Utf8String SandboxId { get; set; }
	public ClientCredentials ClientCredentials { get; set; }
	public bool IsServer { get; set; }
	public Utf8String EncryptionKey { get; set; }
	public Utf8String OverrideCountryCode { get; set; }
	public Utf8String OverrideLocaleCode { get; set; }
	public Utf8String DeploymentId { get; set; }
	public PlatformFlags Flags { get; set; }
	public Utf8String CacheDirectory { get; set; }
	public uint TickBudgetInMilliseconds { get; set; }
	public Nullable<RTCOptions> RTCOptions { get; set; }
	public IntegratedPlatformOptionsContainer IntegratedPlatformOptionsContainerHandle { get; set; }
	public IntPtr SystemSpecificOptions { get; set; }
	public Nullable<double> TaskNetworkTimeoutSeconds { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public IntPtr get_Reserved() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_Reserved(IntPtr value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public Utf8String get_ProductId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_ProductId(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Utf8String get_SandboxId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_SandboxId(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x42D820 Offset: 0x42CA20 VA: 0x18042D820
	public ClientCredentials get_ClientCredentials() { }

	[CompilerGenerated]
	// RVA: 0x42D8A0 Offset: 0x42CAA0 VA: 0x18042D8A0
	public void set_ClientCredentials(ClientCredentials value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x42D840 Offset: 0x42CA40 VA: 0x18042D840
	public bool get_IsServer() { }

	[CompilerGenerated]
	// RVA: 0x42D8B0 Offset: 0x42CAB0 VA: 0x18042D8B0
	public void set_IsServer(bool value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public Utf8String get_EncryptionKey() { }

	[CompilerGenerated]
	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	public void set_EncryptionKey(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public Utf8String get_OverrideCountryCode() { }

	[CompilerGenerated]
	// RVA: 0x40EC50 Offset: 0x40DE50 VA: 0x18040EC50
	public void set_OverrideCountryCode(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	public Utf8String get_OverrideLocaleCode() { }

	[CompilerGenerated]
	// RVA: 0x415820 Offset: 0x414A20 VA: 0x180415820
	public void set_OverrideLocaleCode(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0
	public Utf8String get_DeploymentId() { }

	[CompilerGenerated]
	// RVA: 0x41A200 Offset: 0x419400 VA: 0x18041A200
	public void set_DeploymentId(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0
	public PlatformFlags get_Flags() { }

	[CompilerGenerated]
	// RVA: 0x4050C0 Offset: 0x4042C0 VA: 0x1804050C0
	public void set_Flags(PlatformFlags value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x405090 Offset: 0x404290 VA: 0x180405090
	public Utf8String get_CacheDirectory() { }

	[CompilerGenerated]
	// RVA: 0x4050B0 Offset: 0x4042B0 VA: 0x1804050B0
	public void set_CacheDirectory(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x42D890 Offset: 0x42CA90 VA: 0x18042D890
	public uint get_TickBudgetInMilliseconds() { }

	[CompilerGenerated]
	// RVA: 0x42D900 Offset: 0x42CB00 VA: 0x18042D900
	public void set_TickBudgetInMilliseconds(uint value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x42D850 Offset: 0x42CA50 VA: 0x18042D850
	public Nullable<RTCOptions> get_RTCOptions() { }

	[CompilerGenerated]
	// RVA: 0x42D8C0 Offset: 0x42CAC0 VA: 0x18042D8C0
	public void set_RTCOptions(Nullable<RTCOptions> value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x42D830 Offset: 0x42CA30 VA: 0x18042D830
	public IntegratedPlatformOptionsContainer get_IntegratedPlatformOptionsContainerHandle() { }

	[CompilerGenerated]
	// RVA: 0x42D780 Offset: 0x42C980 VA: 0x18042D780
	public void set_IntegratedPlatformOptionsContainerHandle(IntegratedPlatformOptionsContainer value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x42D870 Offset: 0x42CA70 VA: 0x18042D870
	public IntPtr get_SystemSpecificOptions() { }

	[CompilerGenerated]
	// RVA: 0x42D8E0 Offset: 0x42CAE0 VA: 0x18042D8E0
	public void set_SystemSpecificOptions(IntPtr value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x42D880 Offset: 0x42CA80 VA: 0x18042D880
	public Nullable<double> get_TaskNetworkTimeoutSeconds() { }

	[CompilerGenerated]
	// RVA: 0x42D8F0 Offset: 0x42CAF0 VA: 0x18042D8F0
	public void set_TaskNetworkTimeoutSeconds(Nullable<double> value) { }
}

// Namespace: Epic.OnlineServices.Platform
internal struct OptionsInternal : ISettable<Options>, IDisposable // TypeDefIndex: 10240
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_Reserved; // 0x8
	private IntPtr m_ProductId; // 0x10
	private IntPtr m_SandboxId; // 0x18
	private ClientCredentialsInternal m_ClientCredentials; // 0x20
	private int m_IsServer; // 0x30
	private IntPtr m_EncryptionKey; // 0x38
	private IntPtr m_OverrideCountryCode; // 0x40
	private IntPtr m_OverrideLocaleCode; // 0x48
	private IntPtr m_DeploymentId; // 0x50
	private PlatformFlags m_Flags; // 0x58
	private IntPtr m_CacheDirectory; // 0x60
	private uint m_TickBudgetInMilliseconds; // 0x68
	private IntPtr m_RTCOptions; // 0x70
	private IntPtr m_IntegratedPlatformOptionsContainerHandle; // 0x78
	private IntPtr m_SystemSpecificOptions; // 0x80
	private IntPtr m_TaskNetworkTimeoutSeconds; // 0x88

	// Properties
	public IntPtr Reserved { set; }
	public Utf8String ProductId { set; }
	public Utf8String SandboxId { set; }
	public ClientCredentials ClientCredentials { set; }
	public bool IsServer { set; }
	public Utf8String EncryptionKey { set; }
	public Utf8String OverrideCountryCode { set; }
	public Utf8String OverrideLocaleCode { set; }
	public Utf8String DeploymentId { set; }
	public PlatformFlags Flags { set; }
	public Utf8String CacheDirectory { set; }
	public uint TickBudgetInMilliseconds { set; }
	public Nullable<RTCOptions> RTCOptions { set; }
	public IntegratedPlatformOptionsContainer IntegratedPlatformOptionsContainerHandle { set; }
	public IntPtr SystemSpecificOptions { set; }
	public Nullable<double> TaskNetworkTimeoutSeconds { set; }

	// Methods

	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_Reserved(IntPtr value) { }

	// RVA: 0x42D650 Offset: 0x42C850 VA: 0x18042D650
	public void set_ProductId(Utf8String value) { }

	// RVA: 0x42D720 Offset: 0x42C920 VA: 0x18042D720
	public void set_SandboxId(Utf8String value) { }

	// RVA: 0x42D3A0 Offset: 0x42C5A0 VA: 0x18042D3A0
	public void set_ClientCredentials(ClientCredentials value) { }

	// RVA: 0x42D530 Offset: 0x42C730 VA: 0x18042D530
	public void set_IsServer(bool value) { }

	// RVA: 0x42D470 Offset: 0x42C670 VA: 0x18042D470
	public void set_EncryptionKey(Utf8String value) { }

	// RVA: 0x42D590 Offset: 0x42C790 VA: 0x18042D590
	public void set_OverrideCountryCode(Utf8String value) { }

	// RVA: 0x42D5F0 Offset: 0x42C7F0 VA: 0x18042D5F0
	public void set_OverrideLocaleCode(Utf8String value) { }

	// RVA: 0x42D410 Offset: 0x42C610 VA: 0x18042D410
	public void set_DeploymentId(Utf8String value) { }

	// RVA: 0x4050B0 Offset: 0x4042B0 VA: 0x1804050B0
	public void set_Flags(PlatformFlags value) { }

	// RVA: 0x42D340 Offset: 0x42C540 VA: 0x18042D340
	public void set_CacheDirectory(Utf8String value) { }

	// RVA: 0x42D810 Offset: 0x42CA10 VA: 0x18042D810
	public void set_TickBudgetInMilliseconds(uint value) { }

	// RVA: 0x42D6B0 Offset: 0x42C8B0 VA: 0x18042D6B0
	public void set_RTCOptions(Nullable<RTCOptions> value) { }

	// RVA: 0x42D4D0 Offset: 0x42C6D0 VA: 0x18042D4D0
	public void set_IntegratedPlatformOptionsContainerHandle(IntegratedPlatformOptionsContainer value) { }

	// RVA: 0x42D780 Offset: 0x42C980 VA: 0x18042D780
	public void set_SystemSpecificOptions(IntPtr value) { }

	// RVA: 0x42D790 Offset: 0x42C990 VA: 0x18042D790
	public void set_TaskNetworkTimeoutSeconds(Nullable<double> value) { }

	// RVA: 0x42CF50 Offset: 0x42C150 VA: 0x18042CF50 Slot: 4
	public void Set(ref Options other) { }

	// RVA: 0x42CA30 Offset: 0x42BC30 VA: 0x18042CA30 Slot: 5
	public void Set(ref Nullable<Options> other) { }

	// RVA: 0x42C940 Offset: 0x42BB40 VA: 0x18042C940 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Platform
[Flags]
public enum PlatformFlags // TypeDefIndex: 10241
{
	// Fields
	public ulong value__; // 0x0
	public const PlatformFlags None = 0;
	public const PlatformFlags LoadingInEditor = 1;
	public const PlatformFlags DisableOverlay = 2;
	public const PlatformFlags DisableSocialOverlay = 4;
	public const PlatformFlags Reserved1 = 8;
	public const PlatformFlags WindowsEnableOverlayD3D9 = 16;
	public const PlatformFlags WindowsEnableOverlayD3D10 = 32;
	public const PlatformFlags WindowsEnableOverlayOpengl = 64;
	public const PlatformFlags ConsoleEnableOverlayAutomaticUnloading = 128;
}

// Namespace: Epic.OnlineServices.Platform
[UnmanagedFunctionPointer(2)]
public sealed class ReallocateMemoryFunc : MulticastDelegate // TypeDefIndex: 10242
{
	// Methods

	// RVA: 0x4356A0 Offset: 0x4348A0 VA: 0x1804356A0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x409CF0 Offset: 0x408EF0 VA: 0x180409CF0 Slot: 13
	public virtual IntPtr Invoke(IntPtr pointer, UIntPtr sizeInBytes, UIntPtr alignment) { }

	// RVA: 0x4355F0 Offset: 0x4347F0 VA: 0x1804355F0 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr pointer, UIntPtr sizeInBytes, UIntPtr alignment, AsyncCallback callback, object object) { }

	// RVA: 0x425AE0 Offset: 0x424CE0 VA: 0x180425AE0 Slot: 15
	public virtual IntPtr EndInvoke(IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Platform
[UnmanagedFunctionPointer(2)]
public sealed class ReleaseMemoryFunc : MulticastDelegate // TypeDefIndex: 10243
{
	// Methods

	// RVA: 0x438120 Offset: 0x437320 VA: 0x180438120
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(IntPtr pointer) { }

	// RVA: 0x4380A0 Offset: 0x4372A0 VA: 0x1804380A0 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr pointer, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Platform
public enum RTCBackgroundMode // TypeDefIndex: 10244
{
	// Fields
	public int value__; // 0x0
	public const RTCBackgroundMode LeaveRooms = 0;
	public const RTCBackgroundMode KeepRoomsAlive = 1;
}

// Namespace: Epic.OnlineServices.Platform
public struct RTCOptions // TypeDefIndex: 10245
{
	// Fields
	[CompilerGenerated]
	private IntPtr <PlatformSpecificOptions>k__BackingField; // 0x0
	[CompilerGenerated]
	private RTCBackgroundMode <BackgroundMode>k__BackingField; // 0x8

	// Properties
	public IntPtr PlatformSpecificOptions { get; set; }
	public RTCBackgroundMode BackgroundMode { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public IntPtr get_PlatformSpecificOptions() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_PlatformSpecificOptions(IntPtr value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3F5510 Offset: 0x3F4710 VA: 0x1803F5510
	public RTCBackgroundMode get_BackgroundMode() { }

	[CompilerGenerated]
	// RVA: 0x3F5520 Offset: 0x3F4720 VA: 0x1803F5520
	public void set_BackgroundMode(RTCBackgroundMode value) { }

	// RVA: 0x4355E0 Offset: 0x4347E0 VA: 0x1804355E0
	internal void Set(ref RTCOptionsInternal other) { }
}

// Namespace: Epic.OnlineServices.Platform
internal struct RTCOptionsInternal : IGettable<RTCOptions>, ISettable<RTCOptions>, IDisposable // TypeDefIndex: 10246
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_PlatformSpecificOptions; // 0x8
	private RTCBackgroundMode m_BackgroundMode; // 0x10

	// Properties
	public IntPtr PlatformSpecificOptions { get; set; }
	public RTCBackgroundMode BackgroundMode { get; set; }

	// Methods

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public IntPtr get_PlatformSpecificOptions() { }

	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_PlatformSpecificOptions(IntPtr value) { }

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public RTCBackgroundMode get_BackgroundMode() { }

	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_BackgroundMode(RTCBackgroundMode value) { }

	// RVA: 0x435530 Offset: 0x434730 VA: 0x180435530 Slot: 5
	public void Set(ref RTCOptions other) { }

	// RVA: 0x435550 Offset: 0x434750 VA: 0x180435550 Slot: 6
	public void Set(ref Nullable<RTCOptions> other) { }

	// RVA: 0x4354C0 Offset: 0x4346C0 VA: 0x1804354C0 Slot: 7
	public void Dispose() { }

	// RVA: 0x435510 Offset: 0x434710 VA: 0x180435510 Slot: 4
	public void Get(out RTCOptions output) { }
}

// Namespace: Epic.OnlineServices.Platform
public struct PS4InitializeOptions // TypeDefIndex: 10247
{
	// Fields
	[CompilerGenerated]
	private IntPtr <AllocateMemoryFunction>k__BackingField; // 0x0
	[CompilerGenerated]
	private IntPtr <ReallocateMemoryFunction>k__BackingField; // 0x8
	[CompilerGenerated]
	private IntPtr <ReleaseMemoryFunction>k__BackingField; // 0x10
	[CompilerGenerated]
	private Utf8String <ProductName>k__BackingField; // 0x18
	[CompilerGenerated]
	private Utf8String <ProductVersion>k__BackingField; // 0x20
	[CompilerGenerated]
	private IntPtr <Reserved>k__BackingField; // 0x28
	[CompilerGenerated]
	private Nullable<PS4InitializeOptionsSystemInitializeOptions> <SystemInitializeOptions>k__BackingField; // 0x30
	[CompilerGenerated]
	private Nullable<InitializeThreadAffinity> <OverrideThreadAffinity>k__BackingField; // 0x88

	// Properties
	public IntPtr AllocateMemoryFunction { get; set; }
	public IntPtr ReallocateMemoryFunction { get; set; }
	public IntPtr ReleaseMemoryFunction { get; set; }
	public Utf8String ProductName { get; set; }
	public Utf8String ProductVersion { get; set; }
	public IntPtr Reserved { get; set; }
	public Nullable<PS4InitializeOptionsSystemInitializeOptions> SystemInitializeOptions { get; set; }
	public Nullable<InitializeThreadAffinity> OverrideThreadAffinity { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public IntPtr get_AllocateMemoryFunction() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_AllocateMemoryFunction(IntPtr value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public IntPtr get_ReallocateMemoryFunction() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_ReallocateMemoryFunction(IntPtr value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public IntPtr get_ReleaseMemoryFunction() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_ReleaseMemoryFunction(IntPtr value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public Utf8String get_ProductName() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_ProductName(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public Utf8String get_ProductVersion() { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_ProductVersion(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public IntPtr get_Reserved() { }

	[CompilerGenerated]
	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	public void set_Reserved(IntPtr value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x430760 Offset: 0x42F960 VA: 0x180430760
	public Nullable<PS4InitializeOptionsSystemInitializeOptions> get_SystemInitializeOptions() { }

	[CompilerGenerated]
	// RVA: 0x4307E0 Offset: 0x42F9E0 VA: 0x1804307E0
	public void set_SystemInitializeOptions(Nullable<PS4InitializeOptionsSystemInitializeOptions> value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x430720 Offset: 0x42F920 VA: 0x180430720
	public Nullable<InitializeThreadAffinity> get_OverrideThreadAffinity() { }

	[CompilerGenerated]
	// RVA: 0x4307A0 Offset: 0x42F9A0 VA: 0x1804307A0
	public void set_OverrideThreadAffinity(Nullable<InitializeThreadAffinity> value) { }
}

// Namespace: Epic.OnlineServices.Platform
internal struct PS4InitializeOptionsInternal : ISettable<PS4InitializeOptions>, IDisposable // TypeDefIndex: 10248
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_AllocateMemoryFunction; // 0x8
	private IntPtr m_ReallocateMemoryFunction; // 0x10
	private IntPtr m_ReleaseMemoryFunction; // 0x18
	private IntPtr m_ProductName; // 0x20
	private IntPtr m_ProductVersion; // 0x28
	private IntPtr m_Reserved; // 0x30
	private IntPtr m_SystemInitializeOptions; // 0x38
	private IntPtr m_OverrideThreadAffinity; // 0x40

	// Properties
	public IntPtr AllocateMemoryFunction { set; }
	public IntPtr ReallocateMemoryFunction { set; }
	public IntPtr ReleaseMemoryFunction { set; }
	public Utf8String ProductName { set; }
	public Utf8String ProductVersion { set; }
	public IntPtr Reserved { set; }
	public Nullable<PS4InitializeOptionsSystemInitializeOptions> SystemInitializeOptions { set; }
	public Nullable<InitializeThreadAffinity> OverrideThreadAffinity { set; }

	// Methods

	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_AllocateMemoryFunction(IntPtr value) { }

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_ReallocateMemoryFunction(IntPtr value) { }

	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_ReleaseMemoryFunction(IntPtr value) { }

	// RVA: 0x42F9E0 Offset: 0x42EBE0 VA: 0x18042F9E0
	public void set_ProductName(Utf8String value) { }

	// RVA: 0x42FA40 Offset: 0x42EC40 VA: 0x18042FA40
	public void set_ProductVersion(Utf8String value) { }

	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	public void set_Reserved(IntPtr value) { }

	// RVA: 0x42FAA0 Offset: 0x42ECA0 VA: 0x18042FAA0
	public void set_SystemInitializeOptions(Nullable<PS4InitializeOptionsSystemInitializeOptions> value) { }

	// RVA: 0x42F970 Offset: 0x42EB70 VA: 0x18042F970
	public void set_OverrideThreadAffinity(Nullable<InitializeThreadAffinity> value) { }

	// RVA: 0x42F350 Offset: 0x42E550 VA: 0x18042F350 Slot: 4
	public void Set(ref PS4InitializeOptions other) { }

	// RVA: 0x42F600 Offset: 0x42E800 VA: 0x18042F600 Slot: 5
	public void Set(ref Nullable<PS4InitializeOptions> other) { }

	// RVA: 0x42F2B0 Offset: 0x42E4B0 VA: 0x18042F2B0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Platform
public struct PS4InitializeOptionsSystemInitializeOptions // TypeDefIndex: 10249
{
	// Fields
	[CompilerGenerated]
	private Utf8String <CommandLine_DEPRECATED>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <OverlayPrxBasePath>k__BackingField; // 0x8
	[CompilerGenerated]
	private IntPtr <AllocatePhysicalMemoryFunction_DEPRECATED>k__BackingField; // 0x10
	[CompilerGenerated]
	private IntPtr <ReleasePhysicalMemoryFunction_DEPRECATED>k__BackingField; // 0x18
	[CompilerGenerated]
	private IntPtr <Reserved>k__BackingField; // 0x20
	[CompilerGenerated]
	private PS4VMReserveFunc <ReserveVirtualMemoryFunction>k__BackingField; // 0x28
	[CompilerGenerated]
	private PS4VMReleaseFunc <ReleaseVirtualMemoryFunction>k__BackingField; // 0x30
	[CompilerGenerated]
	private PS4VMCommitFunc <CommitVirtualMemoryFunction>k__BackingField; // 0x38
	[CompilerGenerated]
	private PS4VMDecommitFunc <DecommitVirtualMemoryFunction>k__BackingField; // 0x40
	[CompilerGenerated]
	private uint <PlatformSDKVersion>k__BackingField; // 0x48

	// Properties
	internal Utf8String CommandLine_DEPRECATED { get; set; }
	public Utf8String OverlayPrxBasePath { get; set; }
	internal IntPtr AllocatePhysicalMemoryFunction_DEPRECATED { get; set; }
	internal IntPtr ReleasePhysicalMemoryFunction_DEPRECATED { get; set; }
	public IntPtr Reserved { get; set; }
	public PS4VMReserveFunc ReserveVirtualMemoryFunction { get; set; }
	public PS4VMReleaseFunc ReleaseVirtualMemoryFunction { get; set; }
	public PS4VMCommitFunc CommitVirtualMemoryFunction { get; set; }
	public PS4VMDecommitFunc DecommitVirtualMemoryFunction { get; set; }
	public uint PlatformSDKVersion { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	internal Utf8String get_CommandLine_DEPRECATED() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	internal void set_CommandLine_DEPRECATED(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public Utf8String get_OverlayPrxBasePath() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_OverlayPrxBasePath(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	internal IntPtr get_AllocatePhysicalMemoryFunction_DEPRECATED() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	internal void set_AllocatePhysicalMemoryFunction_DEPRECATED(IntPtr value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	internal IntPtr get_ReleasePhysicalMemoryFunction_DEPRECATED() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	internal void set_ReleasePhysicalMemoryFunction_DEPRECATED(IntPtr value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public IntPtr get_Reserved() { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_Reserved(IntPtr value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public PS4VMReserveFunc get_ReserveVirtualMemoryFunction() { }

	[CompilerGenerated]
	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	public void set_ReserveVirtualMemoryFunction(PS4VMReserveFunc value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public PS4VMReleaseFunc get_ReleaseVirtualMemoryFunction() { }

	[CompilerGenerated]
	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	public void set_ReleaseVirtualMemoryFunction(PS4VMReleaseFunc value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public PS4VMCommitFunc get_CommitVirtualMemoryFunction() { }

	[CompilerGenerated]
	// RVA: 0x40EC50 Offset: 0x40DE50 VA: 0x18040EC50
	public void set_CommitVirtualMemoryFunction(PS4VMCommitFunc value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	public PS4VMDecommitFunc get_DecommitVirtualMemoryFunction() { }

	[CompilerGenerated]
	// RVA: 0x415820 Offset: 0x414A20 VA: 0x180415820
	public void set_DecommitVirtualMemoryFunction(PS4VMDecommitFunc value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x4193D0 Offset: 0x4185D0 VA: 0x1804193D0
	public uint get_PlatformSDKVersion() { }

	[CompilerGenerated]
	// RVA: 0x419410 Offset: 0x418610 VA: 0x180419410
	public void set_PlatformSDKVersion(uint value) { }

	// RVA: 0x430640 Offset: 0x42F840 VA: 0x180430640
	internal void Set(ref PS4InitializeOptionsSystemInitializeOptionsInternal other) { }
}

// Namespace: Epic.OnlineServices.Platform
internal struct PS4InitializeOptionsSystemInitializeOptionsInternal : IGettable<PS4InitializeOptionsSystemInitializeOptions>, ISettable<PS4InitializeOptionsSystemInitializeOptions>, IDisposable // TypeDefIndex: 10250
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_CommandLine_DEPRECATED; // 0x8
	private IntPtr m_OverlayPrxBasePath; // 0x10
	private IntPtr m_AllocatePhysicalMemoryFunction_DEPRECATED; // 0x18
	private IntPtr m_ReleasePhysicalMemoryFunction_DEPRECATED; // 0x20
	private IntPtr m_Reserved; // 0x28
	private IntPtr m_ReserveVirtualMemoryFunction; // 0x30
	private IntPtr m_ReleaseVirtualMemoryFunction; // 0x38
	private IntPtr m_CommitVirtualMemoryFunction; // 0x40
	private IntPtr m_DecommitVirtualMemoryFunction; // 0x48
	private uint m_PlatformSDKVersion; // 0x50
	private static PS4VMReserveFuncInternal s_ReserveVirtualMemoryFunction; // 0x0
	private static PS4VMReleaseFuncInternal s_ReleaseVirtualMemoryFunction; // 0x8
	private static PS4VMCommitFuncInternal s_CommitVirtualMemoryFunction; // 0x10
	private static PS4VMDecommitFuncInternal s_DecommitVirtualMemoryFunction; // 0x18

	// Properties
	public Utf8String CommandLine_DEPRECATED { get; set; }
	public Utf8String OverlayPrxBasePath { get; set; }
	public IntPtr AllocatePhysicalMemoryFunction_DEPRECATED { get; set; }
	public IntPtr ReleasePhysicalMemoryFunction_DEPRECATED { get; set; }
	public IntPtr Reserved { get; set; }
	public static PS4VMReserveFuncInternal ReserveVirtualMemoryFunction { get; }
	public static PS4VMReleaseFuncInternal ReleaseVirtualMemoryFunction { get; }
	public static PS4VMCommitFuncInternal CommitVirtualMemoryFunction { get; }
	public static PS4VMDecommitFuncInternal DecommitVirtualMemoryFunction { get; }
	public uint PlatformSDKVersion { get; set; }

	// Methods

	// RVA: 0x4301D0 Offset: 0x42F3D0 VA: 0x1804301D0
	public Utf8String get_CommandLine_DEPRECATED() { }

	// RVA: 0x430570 Offset: 0x42F770 VA: 0x180430570
	public void set_CommandLine_DEPRECATED(Utf8String value) { }

	// RVA: 0x4303A0 Offset: 0x42F5A0 VA: 0x1804303A0
	public Utf8String get_OverlayPrxBasePath() { }

	// RVA: 0x4305D0 Offset: 0x42F7D0 VA: 0x1804305D0
	public void set_OverlayPrxBasePath(Utf8String value) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public IntPtr get_AllocatePhysicalMemoryFunction_DEPRECATED() { }

	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_AllocatePhysicalMemoryFunction_DEPRECATED(IntPtr value) { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public IntPtr get_ReleasePhysicalMemoryFunction_DEPRECATED() { }

	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_ReleasePhysicalMemoryFunction_DEPRECATED(IntPtr value) { }

	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public IntPtr get_Reserved() { }

	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	public void set_Reserved(IntPtr value) { }

	// RVA: 0x4304D0 Offset: 0x42F6D0 VA: 0x1804304D0
	public static PS4VMReserveFuncInternal get_ReserveVirtualMemoryFunction() { }

	// RVA: 0x430420 Offset: 0x42F620 VA: 0x180430420
	public static PS4VMReleaseFuncInternal get_ReleaseVirtualMemoryFunction() { }

	// RVA: 0x430240 Offset: 0x42F440 VA: 0x180430240
	public static PS4VMCommitFuncInternal get_CommitVirtualMemoryFunction() { }

	// RVA: 0x4302F0 Offset: 0x42F4F0 VA: 0x1804302F0
	public static PS4VMDecommitFuncInternal get_DecommitVirtualMemoryFunction() { }

	// RVA: 0x430410 Offset: 0x42F610 VA: 0x180430410
	public uint get_PlatformSDKVersion() { }

	// RVA: 0x430630 Offset: 0x42F830 VA: 0x180430630
	public void set_PlatformSDKVersion(uint value) { }

	// RVA: 0x42FFB0 Offset: 0x42F1B0 VA: 0x18042FFB0 Slot: 5
	public void Set(ref PS4InitializeOptionsSystemInitializeOptions other) { }

	// RVA: 0x42FBF0 Offset: 0x42EDF0 VA: 0x18042FBF0 Slot: 6
	public void Set(ref Nullable<PS4InitializeOptionsSystemInitializeOptions> other) { }

	// RVA: 0x42FB10 Offset: 0x42ED10 VA: 0x18042FB10 Slot: 7
	public void Dispose() { }

	// RVA: 0x42FBC0 Offset: 0x42EDC0 VA: 0x18042FBC0 Slot: 4
	public void Get(out PS4InitializeOptionsSystemInitializeOptions output) { }
}

// Namespace: Epic.OnlineServices.Platform
public struct PS5InitializeOptions // TypeDefIndex: 10251
{
	// Fields
	[CompilerGenerated]
	private IntPtr <AllocateMemoryFunction>k__BackingField; // 0x0
	[CompilerGenerated]
	private IntPtr <ReallocateMemoryFunction>k__BackingField; // 0x8
	[CompilerGenerated]
	private IntPtr <ReleaseMemoryFunction>k__BackingField; // 0x10
	[CompilerGenerated]
	private Utf8String <ProductName>k__BackingField; // 0x18
	[CompilerGenerated]
	private Utf8String <ProductVersion>k__BackingField; // 0x20
	[CompilerGenerated]
	private IntPtr <Reserved>k__BackingField; // 0x28
	[CompilerGenerated]
	private Nullable<PS5InitializeOptionsSystemInitializeOptions> <SystemInitializeOptions>k__BackingField; // 0x30
	[CompilerGenerated]
	private Nullable<InitializeThreadAffinity> <OverrideThreadAffinity>k__BackingField; // 0x80

	// Properties
	public IntPtr AllocateMemoryFunction { get; set; }
	public IntPtr ReallocateMemoryFunction { get; set; }
	public IntPtr ReleaseMemoryFunction { get; set; }
	public Utf8String ProductName { get; set; }
	public Utf8String ProductVersion { get; set; }
	public IntPtr Reserved { get; set; }
	public Nullable<PS5InitializeOptionsSystemInitializeOptions> SystemInitializeOptions { get; set; }
	public Nullable<InitializeThreadAffinity> OverrideThreadAffinity { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public IntPtr get_AllocateMemoryFunction() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_AllocateMemoryFunction(IntPtr value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public IntPtr get_ReallocateMemoryFunction() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_ReallocateMemoryFunction(IntPtr value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public IntPtr get_ReleaseMemoryFunction() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_ReleaseMemoryFunction(IntPtr value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public Utf8String get_ProductName() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_ProductName(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public Utf8String get_ProductVersion() { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_ProductVersion(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public IntPtr get_Reserved() { }

	[CompilerGenerated]
	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	public void set_Reserved(IntPtr value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x4334A0 Offset: 0x4326A0 VA: 0x1804334A0
	public Nullable<PS5InitializeOptionsSystemInitializeOptions> get_SystemInitializeOptions() { }

	[CompilerGenerated]
	// RVA: 0x433510 Offset: 0x432710 VA: 0x180433510
	public void set_SystemInitializeOptions(Nullable<PS5InitializeOptionsSystemInitializeOptions> value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x433460 Offset: 0x432660 VA: 0x180433460
	public Nullable<InitializeThreadAffinity> get_OverrideThreadAffinity() { }

	[CompilerGenerated]
	// RVA: 0x4334D0 Offset: 0x4326D0 VA: 0x1804334D0
	public void set_OverrideThreadAffinity(Nullable<InitializeThreadAffinity> value) { }
}

// Namespace: Epic.OnlineServices.Platform
internal struct PS5InitializeOptionsInternal : ISettable<PS5InitializeOptions>, IDisposable // TypeDefIndex: 10252
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_AllocateMemoryFunction; // 0x8
	private IntPtr m_ReallocateMemoryFunction; // 0x10
	private IntPtr m_ReleaseMemoryFunction; // 0x18
	private IntPtr m_ProductName; // 0x20
	private IntPtr m_ProductVersion; // 0x28
	private IntPtr m_Reserved; // 0x30
	private IntPtr m_SystemInitializeOptions; // 0x38
	private IntPtr m_OverrideThreadAffinity; // 0x40

	// Properties
	public IntPtr AllocateMemoryFunction { set; }
	public IntPtr ReallocateMemoryFunction { set; }
	public IntPtr ReleaseMemoryFunction { set; }
	public Utf8String ProductName { set; }
	public Utf8String ProductVersion { set; }
	public IntPtr Reserved { set; }
	public Nullable<PS5InitializeOptionsSystemInitializeOptions> SystemInitializeOptions { set; }
	public Nullable<InitializeThreadAffinity> OverrideThreadAffinity { set; }

	// Methods

	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_AllocateMemoryFunction(IntPtr value) { }

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_ReallocateMemoryFunction(IntPtr value) { }

	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_ReleaseMemoryFunction(IntPtr value) { }

	// RVA: 0x4328E0 Offset: 0x431AE0 VA: 0x1804328E0
	public void set_ProductName(Utf8String value) { }

	// RVA: 0x432940 Offset: 0x431B40 VA: 0x180432940
	public void set_ProductVersion(Utf8String value) { }

	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	public void set_Reserved(IntPtr value) { }

	// RVA: 0x4329A0 Offset: 0x431BA0 VA: 0x1804329A0
	public void set_SystemInitializeOptions(Nullable<PS5InitializeOptionsSystemInitializeOptions> value) { }

	// RVA: 0x432870 Offset: 0x431A70 VA: 0x180432870
	public void set_OverrideThreadAffinity(Nullable<InitializeThreadAffinity> value) { }

	// RVA: 0x4325D0 Offset: 0x4317D0 VA: 0x1804325D0 Slot: 4
	public void Set(ref PS5InitializeOptions other) { }

	// RVA: 0x432260 Offset: 0x431460 VA: 0x180432260 Slot: 5
	public void Set(ref Nullable<PS5InitializeOptions> other) { }

	// RVA: 0x4321C0 Offset: 0x4313C0 VA: 0x1804321C0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Platform
public struct PS5InitializeOptionsSystemInitializeOptions // TypeDefIndex: 10253
{
	// Fields
	[CompilerGenerated]
	private Utf8String <OverlayPrxBasePath>k__BackingField; // 0x0
	[CompilerGenerated]
	private IntPtr <AllocatePhysicalMemoryFunction_DEPRECATED>k__BackingField; // 0x8
	[CompilerGenerated]
	private IntPtr <ReleasePhysicalMemoryFunction_DEPRECATED>k__BackingField; // 0x10
	[CompilerGenerated]
	private IntPtr <Reserved>k__BackingField; // 0x18
	[CompilerGenerated]
	private PS5VMReserveFunc <ReserveVirtualMemoryFunction>k__BackingField; // 0x20
	[CompilerGenerated]
	private PS5VMReleaseFunc <ReleaseVirtualMemoryFunction>k__BackingField; // 0x28
	[CompilerGenerated]
	private PS5VMCommitFunc <CommitVirtualMemoryFunction>k__BackingField; // 0x30
	[CompilerGenerated]
	private PS5VMDecommitFunc <DecommitVirtualMemoryFunction>k__BackingField; // 0x38
	[CompilerGenerated]
	private uint <PlatformSDKVersion>k__BackingField; // 0x40

	// Properties
	public Utf8String OverlayPrxBasePath { get; set; }
	internal IntPtr AllocatePhysicalMemoryFunction_DEPRECATED { get; set; }
	internal IntPtr ReleasePhysicalMemoryFunction_DEPRECATED { get; set; }
	public IntPtr Reserved { get; set; }
	public PS5VMReserveFunc ReserveVirtualMemoryFunction { get; set; }
	public PS5VMReleaseFunc ReleaseVirtualMemoryFunction { get; set; }
	public PS5VMCommitFunc CommitVirtualMemoryFunction { get; set; }
	public PS5VMDecommitFunc DecommitVirtualMemoryFunction { get; set; }
	public uint PlatformSDKVersion { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Utf8String get_OverlayPrxBasePath() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_OverlayPrxBasePath(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	internal IntPtr get_AllocatePhysicalMemoryFunction_DEPRECATED() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	internal void set_AllocatePhysicalMemoryFunction_DEPRECATED(IntPtr value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	internal IntPtr get_ReleasePhysicalMemoryFunction_DEPRECATED() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	internal void set_ReleasePhysicalMemoryFunction_DEPRECATED(IntPtr value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public IntPtr get_Reserved() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_Reserved(IntPtr value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public PS5VMReserveFunc get_ReserveVirtualMemoryFunction() { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_ReserveVirtualMemoryFunction(PS5VMReserveFunc value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public PS5VMReleaseFunc get_ReleaseVirtualMemoryFunction() { }

	[CompilerGenerated]
	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	public void set_ReleaseVirtualMemoryFunction(PS5VMReleaseFunc value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public PS5VMCommitFunc get_CommitVirtualMemoryFunction() { }

	[CompilerGenerated]
	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	public void set_CommitVirtualMemoryFunction(PS5VMCommitFunc value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public PS5VMDecommitFunc get_DecommitVirtualMemoryFunction() { }

	[CompilerGenerated]
	// RVA: 0x40EC50 Offset: 0x40DE50 VA: 0x18040EC50
	public void set_DecommitVirtualMemoryFunction(PS5VMDecommitFunc value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x433440 Offset: 0x432640 VA: 0x180433440
	public uint get_PlatformSDKVersion() { }

	[CompilerGenerated]
	// RVA: 0x433450 Offset: 0x432650 VA: 0x180433450
	public void set_PlatformSDKVersion(uint value) { }

	// RVA: 0x4333B0 Offset: 0x4325B0 VA: 0x1804333B0
	internal void Set(ref PS5InitializeOptionsSystemInitializeOptionsInternal other) { }
}

// Namespace: Epic.OnlineServices.Platform
internal struct PS5InitializeOptionsSystemInitializeOptionsInternal : IGettable<PS5InitializeOptionsSystemInitializeOptions>, ISettable<PS5InitializeOptionsSystemInitializeOptions>, IDisposable // TypeDefIndex: 10254
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_OverlayPrxBasePath; // 0x8
	private IntPtr m_AllocatePhysicalMemoryFunction_DEPRECATED; // 0x10
	private IntPtr m_ReleasePhysicalMemoryFunction_DEPRECATED; // 0x18
	private IntPtr m_Reserved; // 0x20
	private IntPtr m_ReserveVirtualMemoryFunction; // 0x28
	private IntPtr m_ReleaseVirtualMemoryFunction; // 0x30
	private IntPtr m_CommitVirtualMemoryFunction; // 0x38
	private IntPtr m_DecommitVirtualMemoryFunction; // 0x40
	private uint m_PlatformSDKVersion; // 0x48
	private static PS5VMReserveFuncInternal s_ReserveVirtualMemoryFunction; // 0x0
	private static PS5VMReleaseFuncInternal s_ReleaseVirtualMemoryFunction; // 0x8
	private static PS5VMCommitFuncInternal s_CommitVirtualMemoryFunction; // 0x10
	private static PS5VMDecommitFuncInternal s_DecommitVirtualMemoryFunction; // 0x18

	// Properties
	public Utf8String OverlayPrxBasePath { get; set; }
	public IntPtr AllocatePhysicalMemoryFunction_DEPRECATED { get; set; }
	public IntPtr ReleasePhysicalMemoryFunction_DEPRECATED { get; set; }
	public IntPtr Reserved { get; set; }
	public static PS5VMReserveFuncInternal ReserveVirtualMemoryFunction { get; }
	public static PS5VMReleaseFuncInternal ReleaseVirtualMemoryFunction { get; }
	public static PS5VMCommitFuncInternal CommitVirtualMemoryFunction { get; }
	public static PS5VMDecommitFuncInternal DecommitVirtualMemoryFunction { get; }
	public uint PlatformSDKVersion { get; set; }

	// Methods

	// RVA: 0x433190 Offset: 0x432390 VA: 0x180433190
	public Utf8String get_OverlayPrxBasePath() { }

	// RVA: 0x433350 Offset: 0x432550 VA: 0x180433350
	public void set_OverlayPrxBasePath(Utf8String value) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public IntPtr get_AllocatePhysicalMemoryFunction_DEPRECATED() { }

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_AllocatePhysicalMemoryFunction_DEPRECATED(IntPtr value) { }

	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public IntPtr get_ReleasePhysicalMemoryFunction_DEPRECATED() { }

	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_ReleasePhysicalMemoryFunction_DEPRECATED(IntPtr value) { }

	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public IntPtr get_Reserved() { }

	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_Reserved(IntPtr value) { }

	// RVA: 0x4332B0 Offset: 0x4324B0 VA: 0x1804332B0
	public static PS5VMReserveFuncInternal get_ReserveVirtualMemoryFunction() { }

	// RVA: 0x433200 Offset: 0x432400 VA: 0x180433200
	public static PS5VMReleaseFuncInternal get_ReleaseVirtualMemoryFunction() { }

	// RVA: 0x433030 Offset: 0x432230 VA: 0x180433030
	public static PS5VMCommitFuncInternal get_CommitVirtualMemoryFunction() { }

	// RVA: 0x4330E0 Offset: 0x4322E0 VA: 0x1804330E0
	public static PS5VMDecommitFuncInternal get_DecommitVirtualMemoryFunction() { }

	// RVA: 0x4193D0 Offset: 0x4185D0 VA: 0x1804193D0
	public uint get_PlatformSDKVersion() { }

	// RVA: 0x419410 Offset: 0x418610 VA: 0x180419410
	public void set_PlatformSDKVersion(uint value) { }

	// RVA: 0x432E50 Offset: 0x432050 VA: 0x180432E50 Slot: 5
	public void Set(ref PS5InitializeOptionsSystemInitializeOptions other) { }

	// RVA: 0x432AE0 Offset: 0x431CE0 VA: 0x180432AE0 Slot: 6
	public void Set(ref Nullable<PS5InitializeOptionsSystemInitializeOptions> other) { }

	// RVA: 0x432A10 Offset: 0x431C10 VA: 0x180432A10 Slot: 7
	public void Dispose() { }

	// RVA: 0x432AB0 Offset: 0x431CB0 VA: 0x180432AB0 Slot: 4
	public void Get(out PS5InitializeOptionsSystemInitializeOptions output) { }
}

// Namespace: Epic.OnlineServices.Platform
public struct WindowsOptions // TypeDefIndex: 10255
{
	// Fields
	[CompilerGenerated]
	private IntPtr <Reserved>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <ProductId>k__BackingField; // 0x8
	[CompilerGenerated]
	private Utf8String <SandboxId>k__BackingField; // 0x10
	[CompilerGenerated]
	private ClientCredentials <ClientCredentials>k__BackingField; // 0x18
	[CompilerGenerated]
	private bool <IsServer>k__BackingField; // 0x28
	[CompilerGenerated]
	private Utf8String <EncryptionKey>k__BackingField; // 0x30
	[CompilerGenerated]
	private Utf8String <OverrideCountryCode>k__BackingField; // 0x38
	[CompilerGenerated]
	private Utf8String <OverrideLocaleCode>k__BackingField; // 0x40
	[CompilerGenerated]
	private Utf8String <DeploymentId>k__BackingField; // 0x48
	[CompilerGenerated]
	private PlatformFlags <Flags>k__BackingField; // 0x50
	[CompilerGenerated]
	private Utf8String <CacheDirectory>k__BackingField; // 0x58
	[CompilerGenerated]
	private uint <TickBudgetInMilliseconds>k__BackingField; // 0x60
	[CompilerGenerated]
	private Nullable<WindowsRTCOptions> <RTCOptions>k__BackingField; // 0x68
	[CompilerGenerated]
	private IntegratedPlatformOptionsContainer <IntegratedPlatformOptionsContainerHandle>k__BackingField; // 0x88
	[CompilerGenerated]
	private IntPtr <SystemSpecificOptions>k__BackingField; // 0x90
	[CompilerGenerated]
	private Nullable<double> <TaskNetworkTimeoutSeconds>k__BackingField; // 0x98

	// Properties
	public IntPtr Reserved { get; set; }
	public Utf8String ProductId { get; set; }
	public Utf8String SandboxId { get; set; }
	public ClientCredentials ClientCredentials { get; set; }
	public bool IsServer { get; set; }
	public Utf8String EncryptionKey { get; set; }
	public Utf8String OverrideCountryCode { get; set; }
	public Utf8String OverrideLocaleCode { get; set; }
	public Utf8String DeploymentId { get; set; }
	public PlatformFlags Flags { get; set; }
	public Utf8String CacheDirectory { get; set; }
	public uint TickBudgetInMilliseconds { get; set; }
	public Nullable<WindowsRTCOptions> RTCOptions { get; set; }
	public IntegratedPlatformOptionsContainer IntegratedPlatformOptionsContainerHandle { get; set; }
	public IntPtr SystemSpecificOptions { get; set; }
	public Nullable<double> TaskNetworkTimeoutSeconds { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public IntPtr get_Reserved() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_Reserved(IntPtr value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public Utf8String get_ProductId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_ProductId(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Utf8String get_SandboxId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_SandboxId(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x42D820 Offset: 0x42CA20 VA: 0x18042D820
	public ClientCredentials get_ClientCredentials() { }

	[CompilerGenerated]
	// RVA: 0x42D8A0 Offset: 0x42CAA0 VA: 0x18042D8A0
	public void set_ClientCredentials(ClientCredentials value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x42D840 Offset: 0x42CA40 VA: 0x18042D840
	public bool get_IsServer() { }

	[CompilerGenerated]
	// RVA: 0x42D8B0 Offset: 0x42CAB0 VA: 0x18042D8B0
	public void set_IsServer(bool value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public Utf8String get_EncryptionKey() { }

	[CompilerGenerated]
	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	public void set_EncryptionKey(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public Utf8String get_OverrideCountryCode() { }

	[CompilerGenerated]
	// RVA: 0x40EC50 Offset: 0x40DE50 VA: 0x18040EC50
	public void set_OverrideCountryCode(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	public Utf8String get_OverrideLocaleCode() { }

	[CompilerGenerated]
	// RVA: 0x415820 Offset: 0x414A20 VA: 0x180415820
	public void set_OverrideLocaleCode(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0
	public Utf8String get_DeploymentId() { }

	[CompilerGenerated]
	// RVA: 0x41A200 Offset: 0x419400 VA: 0x18041A200
	public void set_DeploymentId(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0
	public PlatformFlags get_Flags() { }

	[CompilerGenerated]
	// RVA: 0x4050C0 Offset: 0x4042C0 VA: 0x1804050C0
	public void set_Flags(PlatformFlags value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x405090 Offset: 0x404290 VA: 0x180405090
	public Utf8String get_CacheDirectory() { }

	[CompilerGenerated]
	// RVA: 0x4050B0 Offset: 0x4042B0 VA: 0x1804050B0
	public void set_CacheDirectory(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x42D890 Offset: 0x42CA90 VA: 0x18042D890
	public uint get_TickBudgetInMilliseconds() { }

	[CompilerGenerated]
	// RVA: 0x42D900 Offset: 0x42CB00 VA: 0x18042D900
	public void set_TickBudgetInMilliseconds(uint value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x43B540 Offset: 0x43A740 VA: 0x18043B540
	public Nullable<WindowsRTCOptions> get_RTCOptions() { }

	[CompilerGenerated]
	// RVA: 0x43B580 Offset: 0x43A780 VA: 0x18043B580
	public void set_RTCOptions(Nullable<WindowsRTCOptions> value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x42D870 Offset: 0x42CA70 VA: 0x18042D870
	public IntegratedPlatformOptionsContainer get_IntegratedPlatformOptionsContainerHandle() { }

	[CompilerGenerated]
	// RVA: 0x42D8E0 Offset: 0x42CAE0 VA: 0x18042D8E0
	public void set_IntegratedPlatformOptionsContainerHandle(IntegratedPlatformOptionsContainer value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x43B560 Offset: 0x43A760 VA: 0x18043B560
	public IntPtr get_SystemSpecificOptions() { }

	[CompilerGenerated]
	// RVA: 0x43B590 Offset: 0x43A790 VA: 0x18043B590
	public void set_SystemSpecificOptions(IntPtr value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x43B570 Offset: 0x43A770 VA: 0x18043B570
	public Nullable<double> get_TaskNetworkTimeoutSeconds() { }

	[CompilerGenerated]
	// RVA: 0x43B5A0 Offset: 0x43A7A0 VA: 0x18043B5A0
	public void set_TaskNetworkTimeoutSeconds(Nullable<double> value) { }
}

// Namespace: Epic.OnlineServices.Platform
internal struct WindowsOptionsInternal : ISettable<WindowsOptions>, IDisposable // TypeDefIndex: 10256
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_Reserved; // 0x8
	private IntPtr m_ProductId; // 0x10
	private IntPtr m_SandboxId; // 0x18
	private ClientCredentialsInternal m_ClientCredentials; // 0x20
	private int m_IsServer; // 0x30
	private IntPtr m_EncryptionKey; // 0x38
	private IntPtr m_OverrideCountryCode; // 0x40
	private IntPtr m_OverrideLocaleCode; // 0x48
	private IntPtr m_DeploymentId; // 0x50
	private PlatformFlags m_Flags; // 0x58
	private IntPtr m_CacheDirectory; // 0x60
	private uint m_TickBudgetInMilliseconds; // 0x68
	private IntPtr m_RTCOptions; // 0x70
	private IntPtr m_IntegratedPlatformOptionsContainerHandle; // 0x78
	private IntPtr m_SystemSpecificOptions; // 0x80
	private IntPtr m_TaskNetworkTimeoutSeconds; // 0x88

	// Properties
	public IntPtr Reserved { set; }
	public Utf8String ProductId { set; }
	public Utf8String SandboxId { set; }
	public ClientCredentials ClientCredentials { set; }
	public bool IsServer { set; }
	public Utf8String EncryptionKey { set; }
	public Utf8String OverrideCountryCode { set; }
	public Utf8String OverrideLocaleCode { set; }
	public Utf8String DeploymentId { set; }
	public PlatformFlags Flags { set; }
	public Utf8String CacheDirectory { set; }
	public uint TickBudgetInMilliseconds { set; }
	public Nullable<WindowsRTCOptions> RTCOptions { set; }
	public IntegratedPlatformOptionsContainer IntegratedPlatformOptionsContainerHandle { set; }
	public IntPtr SystemSpecificOptions { set; }
	public Nullable<double> TaskNetworkTimeoutSeconds { set; }

	// Methods

	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_Reserved(IntPtr value) { }

	// RVA: 0x43B390 Offset: 0x43A590 VA: 0x18043B390
	public void set_ProductId(Utf8String value) { }

	// RVA: 0x43B460 Offset: 0x43A660 VA: 0x18043B460
	public void set_SandboxId(Utf8String value) { }

	// RVA: 0x43B0E0 Offset: 0x43A2E0 VA: 0x18043B0E0
	public void set_ClientCredentials(ClientCredentials value) { }

	// RVA: 0x43B270 Offset: 0x43A470 VA: 0x18043B270
	public void set_IsServer(bool value) { }

	// RVA: 0x43B1B0 Offset: 0x43A3B0 VA: 0x18043B1B0
	public void set_EncryptionKey(Utf8String value) { }

	// RVA: 0x43B2D0 Offset: 0x43A4D0 VA: 0x18043B2D0
	public void set_OverrideCountryCode(Utf8String value) { }

	// RVA: 0x43B330 Offset: 0x43A530 VA: 0x18043B330
	public void set_OverrideLocaleCode(Utf8String value) { }

	// RVA: 0x43B150 Offset: 0x43A350 VA: 0x18043B150
	public void set_DeploymentId(Utf8String value) { }

	// RVA: 0x4050B0 Offset: 0x4042B0 VA: 0x1804050B0
	public void set_Flags(PlatformFlags value) { }

	// RVA: 0x43B080 Offset: 0x43A280 VA: 0x18043B080
	public void set_CacheDirectory(Utf8String value) { }

	// RVA: 0x42D810 Offset: 0x42CA10 VA: 0x18042D810
	public void set_TickBudgetInMilliseconds(uint value) { }

	// RVA: 0x43B3F0 Offset: 0x43A5F0 VA: 0x18043B3F0
	public void set_RTCOptions(Nullable<WindowsRTCOptions> value) { }

	// RVA: 0x43B210 Offset: 0x43A410 VA: 0x18043B210
	public void set_IntegratedPlatformOptionsContainerHandle(IntegratedPlatformOptionsContainer value) { }

	// RVA: 0x42D780 Offset: 0x42C980 VA: 0x18042D780
	public void set_SystemSpecificOptions(IntPtr value) { }

	// RVA: 0x43B4C0 Offset: 0x43A6C0 VA: 0x18043B4C0
	public void set_TaskNetworkTimeoutSeconds(Nullable<double> value) { }

	// RVA: 0x43A770 Offset: 0x439970 VA: 0x18043A770 Slot: 4
	public void Set(ref WindowsOptions other) { }

	// RVA: 0x43AB60 Offset: 0x439D60 VA: 0x18043AB60 Slot: 5
	public void Set(ref Nullable<WindowsOptions> other) { }

	// RVA: 0x43A680 Offset: 0x439880 VA: 0x18043A680 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Platform
public struct WindowsRTCOptions // TypeDefIndex: 10257
{
	// Fields
	[CompilerGenerated]
	private Nullable<WindowsRTCOptionsPlatformSpecificOptions> <PlatformSpecificOptions>k__BackingField; // 0x0
	[CompilerGenerated]
	private RTCBackgroundMode <BackgroundMode>k__BackingField; // 0x10

	// Properties
	public Nullable<WindowsRTCOptionsPlatformSpecificOptions> PlatformSpecificOptions { get; set; }
	public RTCBackgroundMode BackgroundMode { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x4354A0 Offset: 0x4346A0 VA: 0x1804354A0
	public Nullable<WindowsRTCOptionsPlatformSpecificOptions> get_PlatformSpecificOptions() { }

	[CompilerGenerated]
	// RVA: 0x4354B0 Offset: 0x4346B0 VA: 0x1804354B0
	public void set_PlatformSpecificOptions(Nullable<WindowsRTCOptionsPlatformSpecificOptions> value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public RTCBackgroundMode get_BackgroundMode() { }

	[CompilerGenerated]
	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_BackgroundMode(RTCBackgroundMode value) { }

	// RVA: 0x452720 Offset: 0x451920 VA: 0x180452720
	internal void Set(ref WindowsRTCOptionsInternal other) { }
}

// Namespace: Epic.OnlineServices.Platform
internal struct WindowsRTCOptionsInternal : IGettable<WindowsRTCOptions>, ISettable<WindowsRTCOptions>, IDisposable // TypeDefIndex: 10258
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_PlatformSpecificOptions; // 0x8
	private RTCBackgroundMode m_BackgroundMode; // 0x10

	// Properties
	public Nullable<WindowsRTCOptionsPlatformSpecificOptions> PlatformSpecificOptions { get; set; }
	public RTCBackgroundMode BackgroundMode { get; set; }

	// Methods

	// RVA: 0x452370 Offset: 0x451570 VA: 0x180452370
	public Nullable<WindowsRTCOptionsPlatformSpecificOptions> get_PlatformSpecificOptions() { }

	// RVA: 0x4523F0 Offset: 0x4515F0 VA: 0x1804523F0
	public void set_PlatformSpecificOptions(Nullable<WindowsRTCOptionsPlatformSpecificOptions> value) { }

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public RTCBackgroundMode get_BackgroundMode() { }

	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_BackgroundMode(RTCBackgroundMode value) { }

	// RVA: 0x4522E0 Offset: 0x4514E0 VA: 0x1804522E0 Slot: 5
	public void Set(ref WindowsRTCOptions other) { }

	// RVA: 0x452200 Offset: 0x451400 VA: 0x180452200 Slot: 6
	public void Set(ref Nullable<WindowsRTCOptions> other) { }

	// RVA: 0x452190 Offset: 0x451390 VA: 0x180452190 Slot: 7
	public void Dispose() { }

	// RVA: 0x4521E0 Offset: 0x4513E0 VA: 0x1804521E0 Slot: 4
	public void Get(out WindowsRTCOptions output) { }
}

// Namespace: Epic.OnlineServices.Platform
public struct WindowsRTCOptionsPlatformSpecificOptions // TypeDefIndex: 10259
{
	// Fields
	[CompilerGenerated]
	private Utf8String <XAudio29DllPath>k__BackingField; // 0x0

	// Properties
	public Utf8String XAudio29DllPath { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Utf8String get_XAudio29DllPath() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_XAudio29DllPath(Utf8String value) { }

	// RVA: 0x4526A0 Offset: 0x4518A0 VA: 0x1804526A0
	internal void Set(ref WindowsRTCOptionsPlatformSpecificOptionsInternal other) { }
}

// Namespace: Epic.OnlineServices.Platform
internal struct WindowsRTCOptionsPlatformSpecificOptionsInternal : IGettable<WindowsRTCOptionsPlatformSpecificOptions>, ISettable<WindowsRTCOptionsPlatformSpecificOptions>, IDisposable // TypeDefIndex: 10260
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_XAudio29DllPath; // 0x8

	// Properties
	public Utf8String XAudio29DllPath { get; set; }

	// Methods

	// RVA: 0x4525D0 Offset: 0x4517D0 VA: 0x1804525D0
	public Utf8String get_XAudio29DllPath() { }

	// RVA: 0x452640 Offset: 0x451840 VA: 0x180452640
	public void set_XAudio29DllPath(Utf8String value) { }

	// RVA: 0x452570 Offset: 0x451770 VA: 0x180452570 Slot: 5
	public void Set(ref WindowsRTCOptionsPlatformSpecificOptions other) { }

	// RVA: 0x4524D0 Offset: 0x4516D0 VA: 0x1804524D0 Slot: 6
	public void Set(ref Nullable<WindowsRTCOptionsPlatformSpecificOptions> other) { }

	// RVA: 0x452460 Offset: 0x451660 VA: 0x180452460 Slot: 7
	public void Dispose() { }

	// RVA: 0x4524B0 Offset: 0x4516B0 VA: 0x1804524B0 Slot: 4
	public void Get(out WindowsRTCOptionsPlatformSpecificOptions output) { }
}

// Namespace: Epic.OnlineServices.Platform
public struct XboxOneGDKInitializeOptions // TypeDefIndex: 10261
{
	// Fields
	[CompilerGenerated]
	private IntPtr <AllocateMemoryFunction>k__BackingField; // 0x0
	[CompilerGenerated]
	private IntPtr <ReallocateMemoryFunction>k__BackingField; // 0x8
	[CompilerGenerated]
	private IntPtr <ReleaseMemoryFunction>k__BackingField; // 0x10
	[CompilerGenerated]
	private Utf8String <ProductName>k__BackingField; // 0x18
	[CompilerGenerated]
	private Utf8String <ProductVersion>k__BackingField; // 0x20
	[CompilerGenerated]
	private IntPtr <Reserved>k__BackingField; // 0x28
	[CompilerGenerated]
	private Nullable<XboxOneGDKInitializeOptionsSystemInitializeOptions> <SystemInitializeOptions>k__BackingField; // 0x30
	[CompilerGenerated]
	private Nullable<InitializeThreadAffinity> <OverrideThreadAffinity>k__BackingField; // 0x70

	// Properties
	public IntPtr AllocateMemoryFunction { get; set; }
	public IntPtr ReallocateMemoryFunction { get; set; }
	public IntPtr ReleaseMemoryFunction { get; set; }
	public Utf8String ProductName { get; set; }
	public Utf8String ProductVersion { get; set; }
	public IntPtr Reserved { get; set; }
	public Nullable<XboxOneGDKInitializeOptionsSystemInitializeOptions> SystemInitializeOptions { get; set; }
	public Nullable<InitializeThreadAffinity> OverrideThreadAffinity { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public IntPtr get_AllocateMemoryFunction() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_AllocateMemoryFunction(IntPtr value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public IntPtr get_ReallocateMemoryFunction() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_ReallocateMemoryFunction(IntPtr value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public IntPtr get_ReleaseMemoryFunction() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_ReleaseMemoryFunction(IntPtr value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public Utf8String get_ProductName() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_ProductName(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public Utf8String get_ProductVersion() { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_ProductVersion(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public IntPtr get_Reserved() { }

	[CompilerGenerated]
	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	public void set_Reserved(IntPtr value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x4539E0 Offset: 0x452BE0 VA: 0x1804539E0
	public Nullable<XboxOneGDKInitializeOptionsSystemInitializeOptions> get_SystemInitializeOptions() { }

	[CompilerGenerated]
	// RVA: 0x453A50 Offset: 0x452C50 VA: 0x180453A50
	public void set_SystemInitializeOptions(Nullable<XboxOneGDKInitializeOptionsSystemInitializeOptions> value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x4539A0 Offset: 0x452BA0 VA: 0x1804539A0
	public Nullable<InitializeThreadAffinity> get_OverrideThreadAffinity() { }

	[CompilerGenerated]
	// RVA: 0x453A10 Offset: 0x452C10 VA: 0x180453A10
	public void set_OverrideThreadAffinity(Nullable<InitializeThreadAffinity> value) { }
}

// Namespace: Epic.OnlineServices.Platform
internal struct XboxOneGDKInitializeOptionsInternal : ISettable<XboxOneGDKInitializeOptions>, IDisposable // TypeDefIndex: 10262
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_AllocateMemoryFunction; // 0x8
	private IntPtr m_ReallocateMemoryFunction; // 0x10
	private IntPtr m_ReleaseMemoryFunction; // 0x18
	private IntPtr m_ProductName; // 0x20
	private IntPtr m_ProductVersion; // 0x28
	private IntPtr m_Reserved; // 0x30
	private IntPtr m_SystemInitializeOptions; // 0x38
	private IntPtr m_OverrideThreadAffinity; // 0x40

	// Properties
	public IntPtr AllocateMemoryFunction { set; }
	public IntPtr ReallocateMemoryFunction { set; }
	public IntPtr ReleaseMemoryFunction { set; }
	public Utf8String ProductName { set; }
	public Utf8String ProductVersion { set; }
	public IntPtr Reserved { set; }
	public Nullable<XboxOneGDKInitializeOptionsSystemInitializeOptions> SystemInitializeOptions { set; }
	public Nullable<InitializeThreadAffinity> OverrideThreadAffinity { set; }

	// Methods

	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_AllocateMemoryFunction(IntPtr value) { }

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_ReallocateMemoryFunction(IntPtr value) { }

	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_ReleaseMemoryFunction(IntPtr value) { }

	// RVA: 0x455240 Offset: 0x454440 VA: 0x180455240
	public void set_ProductName(Utf8String value) { }

	// RVA: 0x4552A0 Offset: 0x4544A0 VA: 0x1804552A0
	public void set_ProductVersion(Utf8String value) { }

	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	public void set_Reserved(IntPtr value) { }

	// RVA: 0x455300 Offset: 0x454500 VA: 0x180455300
	public void set_SystemInitializeOptions(Nullable<XboxOneGDKInitializeOptionsSystemInitializeOptions> value) { }

	// RVA: 0x4551D0 Offset: 0x4543D0 VA: 0x1804551D0
	public void set_OverrideThreadAffinity(Nullable<InitializeThreadAffinity> value) { }

	// RVA: 0x454F40 Offset: 0x454140 VA: 0x180454F40 Slot: 4
	public void Set(ref XboxOneGDKInitializeOptions other) { }

	// RVA: 0x454BE0 Offset: 0x453DE0 VA: 0x180454BE0 Slot: 5
	public void Set(ref Nullable<XboxOneGDKInitializeOptions> other) { }

	// RVA: 0x454B40 Offset: 0x453D40 VA: 0x180454B40 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Platform
public struct XboxOneGDKInitializeOptionsSystemInitializeOptions // TypeDefIndex: 10263
{
	// Fields
	[CompilerGenerated]
	private Utf8String <OverlayDllBasePath>k__BackingField; // 0x0
	[CompilerGenerated]
	private IntPtr <Reserved>k__BackingField; // 0x8
	[CompilerGenerated]
	private XboxOneGDKVMReserveFunc <ReserveVirtualMemoryFunction>k__BackingField; // 0x10
	[CompilerGenerated]
	private XboxOneGDKVMReleaseFunc <ReleaseVirtualMemoryFunction>k__BackingField; // 0x18
	[CompilerGenerated]
	private XboxOneGDKVMCommitFunc <CommitVirtualMemoryFunction>k__BackingField; // 0x20
	[CompilerGenerated]
	private XboxOneGDKVMDecommitFunc <DecommitVirtualMemoryFunction>k__BackingField; // 0x28
	[CompilerGenerated]
	private uint <PlatformSDKVersion>k__BackingField; // 0x30

	// Properties
	public Utf8String OverlayDllBasePath { get; set; }
	public IntPtr Reserved { get; set; }
	public XboxOneGDKVMReserveFunc ReserveVirtualMemoryFunction { get; set; }
	public XboxOneGDKVMReleaseFunc ReleaseVirtualMemoryFunction { get; set; }
	public XboxOneGDKVMCommitFunc CommitVirtualMemoryFunction { get; set; }
	public XboxOneGDKVMDecommitFunc DecommitVirtualMemoryFunction { get; set; }
	public uint PlatformSDKVersion { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Utf8String get_OverlayDllBasePath() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_OverlayDllBasePath(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public IntPtr get_Reserved() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_Reserved(IntPtr value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public XboxOneGDKVMReserveFunc get_ReserveVirtualMemoryFunction() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_ReserveVirtualMemoryFunction(XboxOneGDKVMReserveFunc value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public XboxOneGDKVMReleaseFunc get_ReleaseVirtualMemoryFunction() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_ReleaseVirtualMemoryFunction(XboxOneGDKVMReleaseFunc value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public XboxOneGDKVMCommitFunc get_CommitVirtualMemoryFunction() { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_CommitVirtualMemoryFunction(XboxOneGDKVMCommitFunc value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public XboxOneGDKVMDecommitFunc get_DecommitVirtualMemoryFunction() { }

	[CompilerGenerated]
	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	public void set_DecommitVirtualMemoryFunction(XboxOneGDKVMDecommitFunc value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x40D300 Offset: 0x40C500 VA: 0x18040D300
	public uint get_PlatformSDKVersion() { }

	[CompilerGenerated]
	// RVA: 0x40D850 Offset: 0x40CA50 VA: 0x18040D850
	public void set_PlatformSDKVersion(uint value) { }

	// RVA: 0x455CA0 Offset: 0x454EA0 VA: 0x180455CA0
	internal void Set(ref XboxOneGDKInitializeOptionsSystemInitializeOptionsInternal other) { }
}

// Namespace: Epic.OnlineServices.Platform
internal struct XboxOneGDKInitializeOptionsSystemInitializeOptionsInternal : IGettable<XboxOneGDKInitializeOptionsSystemInitializeOptions>, ISettable<XboxOneGDKInitializeOptionsSystemInitializeOptions>, IDisposable // TypeDefIndex: 10264
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_OverlayDllBasePath; // 0x8
	private IntPtr m_Reserved; // 0x10
	private IntPtr m_ReserveVirtualMemoryFunction; // 0x18
	private IntPtr m_ReleaseVirtualMemoryFunction; // 0x20
	private IntPtr m_CommitVirtualMemoryFunction; // 0x28
	private IntPtr m_DecommitVirtualMemoryFunction; // 0x30
	private uint m_PlatformSDKVersion; // 0x38
	private static XboxOneGDKVMReserveFuncInternal s_ReserveVirtualMemoryFunction; // 0x0
	private static XboxOneGDKVMReleaseFuncInternal s_ReleaseVirtualMemoryFunction; // 0x8
	private static XboxOneGDKVMCommitFuncInternal s_CommitVirtualMemoryFunction; // 0x10
	private static XboxOneGDKVMDecommitFuncInternal s_DecommitVirtualMemoryFunction; // 0x18

	// Properties
	public Utf8String OverlayDllBasePath { get; set; }
	public IntPtr Reserved { get; set; }
	public static XboxOneGDKVMReserveFuncInternal ReserveVirtualMemoryFunction { get; }
	public static XboxOneGDKVMReleaseFuncInternal ReleaseVirtualMemoryFunction { get; }
	public static XboxOneGDKVMCommitFuncInternal CommitVirtualMemoryFunction { get; }
	public static XboxOneGDKVMDecommitFuncInternal DecommitVirtualMemoryFunction { get; }
	public uint PlatformSDKVersion { get; set; }

	// Methods

	// RVA: 0x455A80 Offset: 0x454C80 VA: 0x180455A80
	public Utf8String get_OverlayDllBasePath() { }

	// RVA: 0x455C40 Offset: 0x454E40 VA: 0x180455C40
	public void set_OverlayDllBasePath(Utf8String value) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public IntPtr get_Reserved() { }

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_Reserved(IntPtr value) { }

	// RVA: 0x455BA0 Offset: 0x454DA0 VA: 0x180455BA0
	public static XboxOneGDKVMReserveFuncInternal get_ReserveVirtualMemoryFunction() { }

	// RVA: 0x455AF0 Offset: 0x454CF0 VA: 0x180455AF0
	public static XboxOneGDKVMReleaseFuncInternal get_ReleaseVirtualMemoryFunction() { }

	// RVA: 0x455920 Offset: 0x454B20 VA: 0x180455920
	public static XboxOneGDKVMCommitFuncInternal get_CommitVirtualMemoryFunction() { }

	// RVA: 0x4559D0 Offset: 0x454BD0 VA: 0x1804559D0
	public static XboxOneGDKVMDecommitFuncInternal get_DecommitVirtualMemoryFunction() { }

	// RVA: 0x4232F0 Offset: 0x4224F0 VA: 0x1804232F0
	public uint get_PlatformSDKVersion() { }

	// RVA: 0x423300 Offset: 0x422500 VA: 0x180423300
	public void set_PlatformSDKVersion(uint value) { }

	// RVA: 0x455750 Offset: 0x454950 VA: 0x180455750 Slot: 5
	public void Set(ref XboxOneGDKInitializeOptionsSystemInitializeOptions other) { }

	// RVA: 0x455430 Offset: 0x454630 VA: 0x180455430 Slot: 6
	public void Set(ref Nullable<XboxOneGDKInitializeOptionsSystemInitializeOptions> other) { }

	// RVA: 0x455370 Offset: 0x454570 VA: 0x180455370 Slot: 7
	public void Dispose() { }

	// RVA: 0x455400 Offset: 0x454600 VA: 0x180455400 Slot: 4
	public void Get(out XboxOneGDKInitializeOptionsSystemInitializeOptions output) { }
}

// Namespace: Epic.OnlineServices.Platform
public struct XboxOneGDKOptions // TypeDefIndex: 10265
{
	// Fields
	[CompilerGenerated]
	private IntPtr <Reserved>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <ProductId>k__BackingField; // 0x8
	[CompilerGenerated]
	private Utf8String <SandboxId>k__BackingField; // 0x10
	[CompilerGenerated]
	private ClientCredentials <ClientCredentials>k__BackingField; // 0x18
	[CompilerGenerated]
	private bool <IsServer>k__BackingField; // 0x28
	[CompilerGenerated]
	private Utf8String <EncryptionKey>k__BackingField; // 0x30
	[CompilerGenerated]
	private Utf8String <OverrideCountryCode>k__BackingField; // 0x38
	[CompilerGenerated]
	private Utf8String <OverrideLocaleCode>k__BackingField; // 0x40
	[CompilerGenerated]
	private Utf8String <DeploymentId>k__BackingField; // 0x48
	[CompilerGenerated]
	private PlatformFlags <Flags>k__BackingField; // 0x50
	[CompilerGenerated]
	private Utf8String <CacheDirectory>k__BackingField; // 0x58
	[CompilerGenerated]
	private uint <TickBudgetInMilliseconds>k__BackingField; // 0x60
	[CompilerGenerated]
	private Nullable<RTCOptions> <RTCOptions>k__BackingField; // 0x68
	[CompilerGenerated]
	private IntegratedPlatformOptionsContainer <IntegratedPlatformOptionsContainerHandle>k__BackingField; // 0x80
	[CompilerGenerated]
	private Nullable<XboxOneGDKOptionsSystemSpecificOptions> <SystemSpecificOptions>k__BackingField; // 0x88
	[CompilerGenerated]
	private Nullable<double> <TaskNetworkTimeoutSeconds>k__BackingField; // 0x98

	// Properties
	public IntPtr Reserved { get; set; }
	public Utf8String ProductId { get; set; }
	public Utf8String SandboxId { get; set; }
	public ClientCredentials ClientCredentials { get; set; }
	public bool IsServer { get; set; }
	public Utf8String EncryptionKey { get; set; }
	public Utf8String OverrideCountryCode { get; set; }
	public Utf8String OverrideLocaleCode { get; set; }
	public Utf8String DeploymentId { get; set; }
	public PlatformFlags Flags { get; set; }
	public Utf8String CacheDirectory { get; set; }
	public uint TickBudgetInMilliseconds { get; set; }
	public Nullable<RTCOptions> RTCOptions { get; set; }
	public IntegratedPlatformOptionsContainer IntegratedPlatformOptionsContainerHandle { get; set; }
	public Nullable<XboxOneGDKOptionsSystemSpecificOptions> SystemSpecificOptions { get; set; }
	public Nullable<double> TaskNetworkTimeoutSeconds { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public IntPtr get_Reserved() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_Reserved(IntPtr value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public Utf8String get_ProductId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_ProductId(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Utf8String get_SandboxId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_SandboxId(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x42D820 Offset: 0x42CA20 VA: 0x18042D820
	public ClientCredentials get_ClientCredentials() { }

	[CompilerGenerated]
	// RVA: 0x42D8A0 Offset: 0x42CAA0 VA: 0x18042D8A0
	public void set_ClientCredentials(ClientCredentials value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x42D840 Offset: 0x42CA40 VA: 0x18042D840
	public bool get_IsServer() { }

	[CompilerGenerated]
	// RVA: 0x42D8B0 Offset: 0x42CAB0 VA: 0x18042D8B0
	public void set_IsServer(bool value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public Utf8String get_EncryptionKey() { }

	[CompilerGenerated]
	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	public void set_EncryptionKey(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public Utf8String get_OverrideCountryCode() { }

	[CompilerGenerated]
	// RVA: 0x40EC50 Offset: 0x40DE50 VA: 0x18040EC50
	public void set_OverrideCountryCode(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	public Utf8String get_OverrideLocaleCode() { }

	[CompilerGenerated]
	// RVA: 0x415820 Offset: 0x414A20 VA: 0x180415820
	public void set_OverrideLocaleCode(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0
	public Utf8String get_DeploymentId() { }

	[CompilerGenerated]
	// RVA: 0x41A200 Offset: 0x419400 VA: 0x18041A200
	public void set_DeploymentId(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0
	public PlatformFlags get_Flags() { }

	[CompilerGenerated]
	// RVA: 0x4050C0 Offset: 0x4042C0 VA: 0x1804050C0
	public void set_Flags(PlatformFlags value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x405090 Offset: 0x404290 VA: 0x180405090
	public Utf8String get_CacheDirectory() { }

	[CompilerGenerated]
	// RVA: 0x4050B0 Offset: 0x4042B0 VA: 0x1804050B0
	public void set_CacheDirectory(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x42D890 Offset: 0x42CA90 VA: 0x18042D890
	public uint get_TickBudgetInMilliseconds() { }

	[CompilerGenerated]
	// RVA: 0x42D900 Offset: 0x42CB00 VA: 0x18042D900
	public void set_TickBudgetInMilliseconds(uint value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x42D850 Offset: 0x42CA50 VA: 0x18042D850
	public Nullable<RTCOptions> get_RTCOptions() { }

	[CompilerGenerated]
	// RVA: 0x42D8C0 Offset: 0x42CAC0 VA: 0x18042D8C0
	public void set_RTCOptions(Nullable<RTCOptions> value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x42D830 Offset: 0x42CA30 VA: 0x18042D830
	public IntegratedPlatformOptionsContainer get_IntegratedPlatformOptionsContainerHandle() { }

	[CompilerGenerated]
	// RVA: 0x42D780 Offset: 0x42C980 VA: 0x18042D780
	public void set_IntegratedPlatformOptionsContainerHandle(IntegratedPlatformOptionsContainer value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x454B20 Offset: 0x453D20 VA: 0x180454B20
	public Nullable<XboxOneGDKOptionsSystemSpecificOptions> get_SystemSpecificOptions() { }

	[CompilerGenerated]
	// RVA: 0x454B30 Offset: 0x453D30 VA: 0x180454B30
	public void set_SystemSpecificOptions(Nullable<XboxOneGDKOptionsSystemSpecificOptions> value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x43B570 Offset: 0x43A770 VA: 0x18043B570
	public Nullable<double> get_TaskNetworkTimeoutSeconds() { }

	[CompilerGenerated]
	// RVA: 0x43B5A0 Offset: 0x43A7A0 VA: 0x18043B5A0
	public void set_TaskNetworkTimeoutSeconds(Nullable<double> value) { }
}

// Namespace: Epic.OnlineServices.Platform
internal struct XboxOneGDKOptionsInternal : ISettable<XboxOneGDKOptions>, IDisposable // TypeDefIndex: 10266
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_Reserved; // 0x8
	private IntPtr m_ProductId; // 0x10
	private IntPtr m_SandboxId; // 0x18
	private ClientCredentialsInternal m_ClientCredentials; // 0x20
	private int m_IsServer; // 0x30
	private IntPtr m_EncryptionKey; // 0x38
	private IntPtr m_OverrideCountryCode; // 0x40
	private IntPtr m_OverrideLocaleCode; // 0x48
	private IntPtr m_DeploymentId; // 0x50
	private PlatformFlags m_Flags; // 0x58
	private IntPtr m_CacheDirectory; // 0x60
	private uint m_TickBudgetInMilliseconds; // 0x68
	private IntPtr m_RTCOptions; // 0x70
	private IntPtr m_IntegratedPlatformOptionsContainerHandle; // 0x78
	private IntPtr m_SystemSpecificOptions; // 0x80
	private IntPtr m_TaskNetworkTimeoutSeconds; // 0x88

	// Properties
	public IntPtr Reserved { set; }
	public Utf8String ProductId { set; }
	public Utf8String SandboxId { set; }
	public ClientCredentials ClientCredentials { set; }
	public bool IsServer { set; }
	public Utf8String EncryptionKey { set; }
	public Utf8String OverrideCountryCode { set; }
	public Utf8String OverrideLocaleCode { set; }
	public Utf8String DeploymentId { set; }
	public PlatformFlags Flags { set; }
	public Utf8String CacheDirectory { set; }
	public uint TickBudgetInMilliseconds { set; }
	public Nullable<RTCOptions> RTCOptions { set; }
	public IntegratedPlatformOptionsContainer IntegratedPlatformOptionsContainerHandle { set; }
	public Nullable<XboxOneGDKOptionsSystemSpecificOptions> SystemSpecificOptions { set; }
	public Nullable<double> TaskNetworkTimeoutSeconds { set; }

	// Methods

	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_Reserved(IntPtr value) { }

	// RVA: 0x456AE0 Offset: 0x455CE0 VA: 0x180456AE0
	public void set_ProductId(Utf8String value) { }

	// RVA: 0x456BB0 Offset: 0x455DB0 VA: 0x180456BB0
	public void set_SandboxId(Utf8String value) { }

	// RVA: 0x456830 Offset: 0x455A30 VA: 0x180456830
	public void set_ClientCredentials(ClientCredentials value) { }

	// RVA: 0x4569C0 Offset: 0x455BC0 VA: 0x1804569C0
	public void set_IsServer(bool value) { }

	// RVA: 0x456900 Offset: 0x455B00 VA: 0x180456900
	public void set_EncryptionKey(Utf8String value) { }

	// RVA: 0x456A20 Offset: 0x455C20 VA: 0x180456A20
	public void set_OverrideCountryCode(Utf8String value) { }

	// RVA: 0x456A80 Offset: 0x455C80 VA: 0x180456A80
	public void set_OverrideLocaleCode(Utf8String value) { }

	// RVA: 0x4568A0 Offset: 0x455AA0 VA: 0x1804568A0
	public void set_DeploymentId(Utf8String value) { }

	// RVA: 0x4050B0 Offset: 0x4042B0 VA: 0x1804050B0
	public void set_Flags(PlatformFlags value) { }

	// RVA: 0x4567D0 Offset: 0x4559D0 VA: 0x1804567D0
	public void set_CacheDirectory(Utf8String value) { }

	// RVA: 0x42D810 Offset: 0x42CA10 VA: 0x18042D810
	public void set_TickBudgetInMilliseconds(uint value) { }

	// RVA: 0x456B40 Offset: 0x455D40 VA: 0x180456B40
	public void set_RTCOptions(Nullable<RTCOptions> value) { }

	// RVA: 0x456960 Offset: 0x455B60 VA: 0x180456960
	public void set_IntegratedPlatformOptionsContainerHandle(IntegratedPlatformOptionsContainer value) { }

	// RVA: 0x456C10 Offset: 0x455E10 VA: 0x180456C10
	public void set_SystemSpecificOptions(Nullable<XboxOneGDKOptionsSystemSpecificOptions> value) { }

	// RVA: 0x456C80 Offset: 0x455E80 VA: 0x180456C80
	public void set_TaskNetworkTimeoutSeconds(Nullable<double> value) { }

	// RVA: 0x455E20 Offset: 0x455020 VA: 0x180455E20 Slot: 4
	public void Set(ref XboxOneGDKOptions other) { }

	// RVA: 0x456260 Offset: 0x455460 VA: 0x180456260 Slot: 5
	public void Set(ref Nullable<XboxOneGDKOptions> other) { }

	// RVA: 0x455D30 Offset: 0x454F30 VA: 0x180455D30 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Platform
public struct XboxOneGDKOptionsSystemSpecificOptions // TypeDefIndex: 10267
{
	// Fields
	[CompilerGenerated]
	private IntPtr <OverlayGraphicsDevice>k__BackingField; // 0x0

	// Properties
	public IntPtr OverlayGraphicsDevice { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public IntPtr get_OverlayGraphicsDevice() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_OverlayGraphicsDevice(IntPtr value) { }

	// RVA: 0x454B10 Offset: 0x453D10 VA: 0x180454B10
	internal void Set(ref XboxOneGDKOptionsSystemSpecificOptionsInternal other) { }
}

// Namespace: Epic.OnlineServices.Platform
internal struct XboxOneGDKOptionsSystemSpecificOptionsInternal : IGettable<XboxOneGDKOptionsSystemSpecificOptions>, ISettable<XboxOneGDKOptionsSystemSpecificOptions>, IDisposable // TypeDefIndex: 10268
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_OverlayGraphicsDevice; // 0x8

	// Properties
	public IntPtr OverlayGraphicsDevice { get; set; }

	// Methods

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public IntPtr get_OverlayGraphicsDevice() { }

	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_OverlayGraphicsDevice(IntPtr value) { }

	// RVA: 0x40DD30 Offset: 0x40CF30 VA: 0x18040DD30 Slot: 5
	public void Set(ref XboxOneGDKOptionsSystemSpecificOptions other) { }

	// RVA: 0x456D50 Offset: 0x455F50 VA: 0x180456D50 Slot: 6
	public void Set(ref Nullable<XboxOneGDKOptionsSystemSpecificOptions> other) { }

	// RVA: 0x456D00 Offset: 0x455F00 VA: 0x180456D00 Slot: 7
	public void Dispose() { }

	// RVA: 0x454A90 Offset: 0x453C90 VA: 0x180454A90 Slot: 4
	public void Get(out XboxOneGDKOptionsSystemSpecificOptions output) { }
}

// Namespace: Epic.OnlineServices.Platform
public struct XSXInitializeOptions // TypeDefIndex: 10269
{
	// Fields
	[CompilerGenerated]
	private IntPtr <AllocateMemoryFunction>k__BackingField; // 0x0
	[CompilerGenerated]
	private IntPtr <ReallocateMemoryFunction>k__BackingField; // 0x8
	[CompilerGenerated]
	private IntPtr <ReleaseMemoryFunction>k__BackingField; // 0x10
	[CompilerGenerated]
	private Utf8String <ProductName>k__BackingField; // 0x18
	[CompilerGenerated]
	private Utf8String <ProductVersion>k__BackingField; // 0x20
	[CompilerGenerated]
	private IntPtr <Reserved>k__BackingField; // 0x28
	[CompilerGenerated]
	private Nullable<XSXInitializeOptionsSystemInitializeOptions> <SystemInitializeOptions>k__BackingField; // 0x30
	[CompilerGenerated]
	private Nullable<InitializeThreadAffinity> <OverrideThreadAffinity>k__BackingField; // 0x70

	// Properties
	public IntPtr AllocateMemoryFunction { get; set; }
	public IntPtr ReallocateMemoryFunction { get; set; }
	public IntPtr ReleaseMemoryFunction { get; set; }
	public Utf8String ProductName { get; set; }
	public Utf8String ProductVersion { get; set; }
	public IntPtr Reserved { get; set; }
	public Nullable<XSXInitializeOptionsSystemInitializeOptions> SystemInitializeOptions { get; set; }
	public Nullable<InitializeThreadAffinity> OverrideThreadAffinity { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public IntPtr get_AllocateMemoryFunction() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_AllocateMemoryFunction(IntPtr value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public IntPtr get_ReallocateMemoryFunction() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_ReallocateMemoryFunction(IntPtr value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public IntPtr get_ReleaseMemoryFunction() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_ReleaseMemoryFunction(IntPtr value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public Utf8String get_ProductName() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_ProductName(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public Utf8String get_ProductVersion() { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_ProductVersion(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public IntPtr get_Reserved() { }

	[CompilerGenerated]
	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	public void set_Reserved(IntPtr value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x4539E0 Offset: 0x452BE0 VA: 0x1804539E0
	public Nullable<XSXInitializeOptionsSystemInitializeOptions> get_SystemInitializeOptions() { }

	[CompilerGenerated]
	// RVA: 0x453A50 Offset: 0x452C50 VA: 0x180453A50
	public void set_SystemInitializeOptions(Nullable<XSXInitializeOptionsSystemInitializeOptions> value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x4539A0 Offset: 0x452BA0 VA: 0x1804539A0
	public Nullable<InitializeThreadAffinity> get_OverrideThreadAffinity() { }

	[CompilerGenerated]
	// RVA: 0x453A10 Offset: 0x452C10 VA: 0x180453A10
	public void set_OverrideThreadAffinity(Nullable<InitializeThreadAffinity> value) { }
}

// Namespace: Epic.OnlineServices.Platform
internal struct XSXInitializeOptionsInternal : ISettable<XSXInitializeOptions>, IDisposable // TypeDefIndex: 10270
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_AllocateMemoryFunction; // 0x8
	private IntPtr m_ReallocateMemoryFunction; // 0x10
	private IntPtr m_ReleaseMemoryFunction; // 0x18
	private IntPtr m_ProductName; // 0x20
	private IntPtr m_ProductVersion; // 0x28
	private IntPtr m_Reserved; // 0x30
	private IntPtr m_SystemInitializeOptions; // 0x38
	private IntPtr m_OverrideThreadAffinity; // 0x40

	// Properties
	public IntPtr AllocateMemoryFunction { set; }
	public IntPtr ReallocateMemoryFunction { set; }
	public IntPtr ReleaseMemoryFunction { set; }
	public Utf8String ProductName { set; }
	public Utf8String ProductVersion { set; }
	public IntPtr Reserved { set; }
	public Nullable<XSXInitializeOptionsSystemInitializeOptions> SystemInitializeOptions { set; }
	public Nullable<InitializeThreadAffinity> OverrideThreadAffinity { set; }

	// Methods

	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_AllocateMemoryFunction(IntPtr value) { }

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_ReallocateMemoryFunction(IntPtr value) { }

	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_ReleaseMemoryFunction(IntPtr value) { }

	// RVA: 0x452EB0 Offset: 0x4520B0 VA: 0x180452EB0
	public void set_ProductName(Utf8String value) { }

	// RVA: 0x452F10 Offset: 0x452110 VA: 0x180452F10
	public void set_ProductVersion(Utf8String value) { }

	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	public void set_Reserved(IntPtr value) { }

	// RVA: 0x452F70 Offset: 0x452170 VA: 0x180452F70
	public void set_SystemInitializeOptions(Nullable<XSXInitializeOptionsSystemInitializeOptions> value) { }

	// RVA: 0x452E40 Offset: 0x452040 VA: 0x180452E40
	public void set_OverrideThreadAffinity(Nullable<InitializeThreadAffinity> value) { }

	// RVA: 0x452BB0 Offset: 0x451DB0 VA: 0x180452BB0 Slot: 4
	public void Set(ref XSXInitializeOptions other) { }

	// RVA: 0x452850 Offset: 0x451A50 VA: 0x180452850 Slot: 5
	public void Set(ref Nullable<XSXInitializeOptions> other) { }

	// RVA: 0x4527B0 Offset: 0x4519B0 VA: 0x1804527B0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Platform
public struct XSXInitializeOptionsSystemInitializeOptions // TypeDefIndex: 10271
{
	// Fields
	[CompilerGenerated]
	private Utf8String <OverlayDllBasePath>k__BackingField; // 0x0
	[CompilerGenerated]
	private IntPtr <Reserved>k__BackingField; // 0x8
	[CompilerGenerated]
	private XSXVMReserveFunc <ReserveVirtualMemoryFunction>k__BackingField; // 0x10
	[CompilerGenerated]
	private XSXVMReleaseFunc <ReleaseVirtualMemoryFunction>k__BackingField; // 0x18
	[CompilerGenerated]
	private XSXVMCommitFunc <CommitVirtualMemoryFunction>k__BackingField; // 0x20
	[CompilerGenerated]
	private XSXVMDecommitFunc <DecommitVirtualMemoryFunction>k__BackingField; // 0x28
	[CompilerGenerated]
	private uint <PlatformSDKVersion>k__BackingField; // 0x30

	// Properties
	public Utf8String OverlayDllBasePath { get; set; }
	public IntPtr Reserved { get; set; }
	public XSXVMReserveFunc ReserveVirtualMemoryFunction { get; set; }
	public XSXVMReleaseFunc ReleaseVirtualMemoryFunction { get; set; }
	public XSXVMCommitFunc CommitVirtualMemoryFunction { get; set; }
	public XSXVMDecommitFunc DecommitVirtualMemoryFunction { get; set; }
	public uint PlatformSDKVersion { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Utf8String get_OverlayDllBasePath() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_OverlayDllBasePath(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public IntPtr get_Reserved() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_Reserved(IntPtr value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public XSXVMReserveFunc get_ReserveVirtualMemoryFunction() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_ReserveVirtualMemoryFunction(XSXVMReserveFunc value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public XSXVMReleaseFunc get_ReleaseVirtualMemoryFunction() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_ReleaseVirtualMemoryFunction(XSXVMReleaseFunc value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public XSXVMCommitFunc get_CommitVirtualMemoryFunction() { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_CommitVirtualMemoryFunction(XSXVMCommitFunc value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public XSXVMDecommitFunc get_DecommitVirtualMemoryFunction() { }

	[CompilerGenerated]
	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	public void set_DecommitVirtualMemoryFunction(XSXVMDecommitFunc value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x40D300 Offset: 0x40C500 VA: 0x18040D300
	public uint get_PlatformSDKVersion() { }

	[CompilerGenerated]
	// RVA: 0x40D850 Offset: 0x40CA50 VA: 0x18040D850
	public void set_PlatformSDKVersion(uint value) { }

	// RVA: 0x453910 Offset: 0x452B10 VA: 0x180453910
	internal void Set(ref XSXInitializeOptionsSystemInitializeOptionsInternal other) { }
}

// Namespace: Epic.OnlineServices.Platform
internal struct XSXInitializeOptionsSystemInitializeOptionsInternal : IGettable<XSXInitializeOptionsSystemInitializeOptions>, ISettable<XSXInitializeOptionsSystemInitializeOptions>, IDisposable // TypeDefIndex: 10272
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_OverlayDllBasePath; // 0x8
	private IntPtr m_Reserved; // 0x10
	private IntPtr m_ReserveVirtualMemoryFunction; // 0x18
	private IntPtr m_ReleaseVirtualMemoryFunction; // 0x20
	private IntPtr m_CommitVirtualMemoryFunction; // 0x28
	private IntPtr m_DecommitVirtualMemoryFunction; // 0x30
	private uint m_PlatformSDKVersion; // 0x38
	private static XSXVMReserveFuncInternal s_ReserveVirtualMemoryFunction; // 0x0
	private static XSXVMReleaseFuncInternal s_ReleaseVirtualMemoryFunction; // 0x8
	private static XSXVMCommitFuncInternal s_CommitVirtualMemoryFunction; // 0x10
	private static XSXVMDecommitFuncInternal s_DecommitVirtualMemoryFunction; // 0x18

	// Properties
	public Utf8String OverlayDllBasePath { get; set; }
	public IntPtr Reserved { get; set; }
	public static XSXVMReserveFuncInternal ReserveVirtualMemoryFunction { get; }
	public static XSXVMReleaseFuncInternal ReleaseVirtualMemoryFunction { get; }
	public static XSXVMCommitFuncInternal CommitVirtualMemoryFunction { get; }
	public static XSXVMDecommitFuncInternal DecommitVirtualMemoryFunction { get; }
	public uint PlatformSDKVersion { get; set; }

	// Methods

	// RVA: 0x4536F0 Offset: 0x4528F0 VA: 0x1804536F0
	public Utf8String get_OverlayDllBasePath() { }

	// RVA: 0x4538B0 Offset: 0x452AB0 VA: 0x1804538B0
	public void set_OverlayDllBasePath(Utf8String value) { }

	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public IntPtr get_Reserved() { }

	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_Reserved(IntPtr value) { }

	// RVA: 0x453810 Offset: 0x452A10 VA: 0x180453810
	public static XSXVMReserveFuncInternal get_ReserveVirtualMemoryFunction() { }

	// RVA: 0x453760 Offset: 0x452960 VA: 0x180453760
	public static XSXVMReleaseFuncInternal get_ReleaseVirtualMemoryFunction() { }

	// RVA: 0x453590 Offset: 0x452790 VA: 0x180453590
	public static XSXVMCommitFuncInternal get_CommitVirtualMemoryFunction() { }

	// RVA: 0x453640 Offset: 0x452840 VA: 0x180453640
	public static XSXVMDecommitFuncInternal get_DecommitVirtualMemoryFunction() { }

	// RVA: 0x4232F0 Offset: 0x4224F0 VA: 0x1804232F0
	public uint get_PlatformSDKVersion() { }

	// RVA: 0x423300 Offset: 0x422500 VA: 0x180423300
	public void set_PlatformSDKVersion(uint value) { }

	// RVA: 0x4533C0 Offset: 0x4525C0 VA: 0x1804533C0 Slot: 5
	public void Set(ref XSXInitializeOptionsSystemInitializeOptions other) { }

	// RVA: 0x4530A0 Offset: 0x4522A0 VA: 0x1804530A0 Slot: 6
	public void Set(ref Nullable<XSXInitializeOptionsSystemInitializeOptions> other) { }

	// RVA: 0x452FE0 Offset: 0x4521E0 VA: 0x180452FE0 Slot: 7
	public void Dispose() { }

	// RVA: 0x453070 Offset: 0x452270 VA: 0x180453070 Slot: 4
	public void Get(out XSXInitializeOptionsSystemInitializeOptions output) { }
}

// Namespace: Epic.OnlineServices.Platform
public struct XSXOptions // TypeDefIndex: 10273
{
	// Fields
	[CompilerGenerated]
	private IntPtr <Reserved>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <ProductId>k__BackingField; // 0x8
	[CompilerGenerated]
	private Utf8String <SandboxId>k__BackingField; // 0x10
	[CompilerGenerated]
	private ClientCredentials <ClientCredentials>k__BackingField; // 0x18
	[CompilerGenerated]
	private bool <IsServer>k__BackingField; // 0x28
	[CompilerGenerated]
	private Utf8String <EncryptionKey>k__BackingField; // 0x30
	[CompilerGenerated]
	private Utf8String <OverrideCountryCode>k__BackingField; // 0x38
	[CompilerGenerated]
	private Utf8String <OverrideLocaleCode>k__BackingField; // 0x40
	[CompilerGenerated]
	private Utf8String <DeploymentId>k__BackingField; // 0x48
	[CompilerGenerated]
	private PlatformFlags <Flags>k__BackingField; // 0x50
	[CompilerGenerated]
	private Utf8String <CacheDirectory>k__BackingField; // 0x58
	[CompilerGenerated]
	private uint <TickBudgetInMilliseconds>k__BackingField; // 0x60
	[CompilerGenerated]
	private Nullable<RTCOptions> <RTCOptions>k__BackingField; // 0x68
	[CompilerGenerated]
	private IntegratedPlatformOptionsContainer <IntegratedPlatformOptionsContainerHandle>k__BackingField; // 0x80
	[CompilerGenerated]
	private Nullable<XSXOptionsSystemSpecificOptions> <SystemSpecificOptions>k__BackingField; // 0x88
	[CompilerGenerated]
	private Nullable<double> <TaskNetworkTimeoutSeconds>k__BackingField; // 0x98

	// Properties
	public IntPtr Reserved { get; set; }
	public Utf8String ProductId { get; set; }
	public Utf8String SandboxId { get; set; }
	public ClientCredentials ClientCredentials { get; set; }
	public bool IsServer { get; set; }
	public Utf8String EncryptionKey { get; set; }
	public Utf8String OverrideCountryCode { get; set; }
	public Utf8String OverrideLocaleCode { get; set; }
	public Utf8String DeploymentId { get; set; }
	public PlatformFlags Flags { get; set; }
	public Utf8String CacheDirectory { get; set; }
	public uint TickBudgetInMilliseconds { get; set; }
	public Nullable<RTCOptions> RTCOptions { get; set; }
	public IntegratedPlatformOptionsContainer IntegratedPlatformOptionsContainerHandle { get; set; }
	public Nullable<XSXOptionsSystemSpecificOptions> SystemSpecificOptions { get; set; }
	public Nullable<double> TaskNetworkTimeoutSeconds { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public IntPtr get_Reserved() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_Reserved(IntPtr value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public Utf8String get_ProductId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_ProductId(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Utf8String get_SandboxId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_SandboxId(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x42D820 Offset: 0x42CA20 VA: 0x18042D820
	public ClientCredentials get_ClientCredentials() { }

	[CompilerGenerated]
	// RVA: 0x42D8A0 Offset: 0x42CAA0 VA: 0x18042D8A0
	public void set_ClientCredentials(ClientCredentials value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x42D840 Offset: 0x42CA40 VA: 0x18042D840
	public bool get_IsServer() { }

	[CompilerGenerated]
	// RVA: 0x42D8B0 Offset: 0x42CAB0 VA: 0x18042D8B0
	public void set_IsServer(bool value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public Utf8String get_EncryptionKey() { }

	[CompilerGenerated]
	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	public void set_EncryptionKey(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public Utf8String get_OverrideCountryCode() { }

	[CompilerGenerated]
	// RVA: 0x40EC50 Offset: 0x40DE50 VA: 0x18040EC50
	public void set_OverrideCountryCode(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	public Utf8String get_OverrideLocaleCode() { }

	[CompilerGenerated]
	// RVA: 0x415820 Offset: 0x414A20 VA: 0x180415820
	public void set_OverrideLocaleCode(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0
	public Utf8String get_DeploymentId() { }

	[CompilerGenerated]
	// RVA: 0x41A200 Offset: 0x419400 VA: 0x18041A200
	public void set_DeploymentId(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0
	public PlatformFlags get_Flags() { }

	[CompilerGenerated]
	// RVA: 0x4050C0 Offset: 0x4042C0 VA: 0x1804050C0
	public void set_Flags(PlatformFlags value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x405090 Offset: 0x404290 VA: 0x180405090
	public Utf8String get_CacheDirectory() { }

	[CompilerGenerated]
	// RVA: 0x4050B0 Offset: 0x4042B0 VA: 0x1804050B0
	public void set_CacheDirectory(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x42D890 Offset: 0x42CA90 VA: 0x18042D890
	public uint get_TickBudgetInMilliseconds() { }

	[CompilerGenerated]
	// RVA: 0x42D900 Offset: 0x42CB00 VA: 0x18042D900
	public void set_TickBudgetInMilliseconds(uint value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x42D850 Offset: 0x42CA50 VA: 0x18042D850
	public Nullable<RTCOptions> get_RTCOptions() { }

	[CompilerGenerated]
	// RVA: 0x42D8C0 Offset: 0x42CAC0 VA: 0x18042D8C0
	public void set_RTCOptions(Nullable<RTCOptions> value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x42D830 Offset: 0x42CA30 VA: 0x18042D830
	public IntegratedPlatformOptionsContainer get_IntegratedPlatformOptionsContainerHandle() { }

	[CompilerGenerated]
	// RVA: 0x42D780 Offset: 0x42C980 VA: 0x18042D780
	public void set_IntegratedPlatformOptionsContainerHandle(IntegratedPlatformOptionsContainer value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x454B20 Offset: 0x453D20 VA: 0x180454B20
	public Nullable<XSXOptionsSystemSpecificOptions> get_SystemSpecificOptions() { }

	[CompilerGenerated]
	// RVA: 0x454B30 Offset: 0x453D30 VA: 0x180454B30
	public void set_SystemSpecificOptions(Nullable<XSXOptionsSystemSpecificOptions> value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x43B570 Offset: 0x43A770 VA: 0x18043B570
	public Nullable<double> get_TaskNetworkTimeoutSeconds() { }

	[CompilerGenerated]
	// RVA: 0x43B5A0 Offset: 0x43A7A0 VA: 0x18043B5A0
	public void set_TaskNetworkTimeoutSeconds(Nullable<double> value) { }
}

// Namespace: Epic.OnlineServices.Platform
internal struct XSXOptionsInternal : ISettable<XSXOptions>, IDisposable // TypeDefIndex: 10274
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_Reserved; // 0x8
	private IntPtr m_ProductId; // 0x10
	private IntPtr m_SandboxId; // 0x18
	private ClientCredentialsInternal m_ClientCredentials; // 0x20
	private int m_IsServer; // 0x30
	private IntPtr m_EncryptionKey; // 0x38
	private IntPtr m_OverrideCountryCode; // 0x40
	private IntPtr m_OverrideLocaleCode; // 0x48
	private IntPtr m_DeploymentId; // 0x50
	private PlatformFlags m_Flags; // 0x58
	private IntPtr m_CacheDirectory; // 0x60
	private uint m_TickBudgetInMilliseconds; // 0x68
	private IntPtr m_RTCOptions; // 0x70
	private IntPtr m_IntegratedPlatformOptionsContainerHandle; // 0x78
	private IntPtr m_SystemSpecificOptions; // 0x80
	private IntPtr m_TaskNetworkTimeoutSeconds; // 0x88

	// Properties
	public IntPtr Reserved { set; }
	public Utf8String ProductId { set; }
	public Utf8String SandboxId { set; }
	public ClientCredentials ClientCredentials { set; }
	public bool IsServer { set; }
	public Utf8String EncryptionKey { set; }
	public Utf8String OverrideCountryCode { set; }
	public Utf8String OverrideLocaleCode { set; }
	public Utf8String DeploymentId { set; }
	public PlatformFlags Flags { set; }
	public Utf8String CacheDirectory { set; }
	public uint TickBudgetInMilliseconds { set; }
	public Nullable<RTCOptions> RTCOptions { set; }
	public IntegratedPlatformOptionsContainer IntegratedPlatformOptionsContainerHandle { set; }
	public Nullable<XSXOptionsSystemSpecificOptions> SystemSpecificOptions { set; }
	public Nullable<double> TaskNetworkTimeoutSeconds { set; }

	// Methods

	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_Reserved(IntPtr value) { }

	// RVA: 0x454820 Offset: 0x453A20 VA: 0x180454820
	public void set_ProductId(Utf8String value) { }

	// RVA: 0x4548F0 Offset: 0x453AF0 VA: 0x1804548F0
	public void set_SandboxId(Utf8String value) { }

	// RVA: 0x454570 Offset: 0x453770 VA: 0x180454570
	public void set_ClientCredentials(ClientCredentials value) { }

	// RVA: 0x454700 Offset: 0x453900 VA: 0x180454700
	public void set_IsServer(bool value) { }

	// RVA: 0x454640 Offset: 0x453840 VA: 0x180454640
	public void set_EncryptionKey(Utf8String value) { }

	// RVA: 0x454760 Offset: 0x453960 VA: 0x180454760
	public void set_OverrideCountryCode(Utf8String value) { }

	// RVA: 0x4547C0 Offset: 0x4539C0 VA: 0x1804547C0
	public void set_OverrideLocaleCode(Utf8String value) { }

	// RVA: 0x4545E0 Offset: 0x4537E0 VA: 0x1804545E0
	public void set_DeploymentId(Utf8String value) { }

	// RVA: 0x4050B0 Offset: 0x4042B0 VA: 0x1804050B0
	public void set_Flags(PlatformFlags value) { }

	// RVA: 0x454510 Offset: 0x453710 VA: 0x180454510
	public void set_CacheDirectory(Utf8String value) { }

	// RVA: 0x42D810 Offset: 0x42CA10 VA: 0x18042D810
	public void set_TickBudgetInMilliseconds(uint value) { }

	// RVA: 0x454880 Offset: 0x453A80 VA: 0x180454880
	public void set_RTCOptions(Nullable<RTCOptions> value) { }

	// RVA: 0x4546A0 Offset: 0x4538A0 VA: 0x1804546A0
	public void set_IntegratedPlatformOptionsContainerHandle(IntegratedPlatformOptionsContainer value) { }

	// RVA: 0x454950 Offset: 0x453B50 VA: 0x180454950
	public void set_SystemSpecificOptions(Nullable<XSXOptionsSystemSpecificOptions> value) { }

	// RVA: 0x4549C0 Offset: 0x453BC0 VA: 0x1804549C0
	public void set_TaskNetworkTimeoutSeconds(Nullable<double> value) { }

	// RVA: 0x4540D0 Offset: 0x4532D0 VA: 0x1804540D0 Slot: 4
	public void Set(ref XSXOptions other) { }

	// RVA: 0x453B60 Offset: 0x452D60 VA: 0x180453B60 Slot: 5
	public void Set(ref Nullable<XSXOptions> other) { }

	// RVA: 0x453A70 Offset: 0x452C70 VA: 0x180453A70 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Platform
public struct XSXOptionsSystemSpecificOptions // TypeDefIndex: 10275
{
	// Fields
	[CompilerGenerated]
	private IntPtr <OverlayGraphicsDevice>k__BackingField; // 0x0

	// Properties
	public IntPtr OverlayGraphicsDevice { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public IntPtr get_OverlayGraphicsDevice() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_OverlayGraphicsDevice(IntPtr value) { }

	// RVA: 0x454B10 Offset: 0x453D10 VA: 0x180454B10
	internal void Set(ref XSXOptionsSystemSpecificOptionsInternal other) { }
}

// Namespace: Epic.OnlineServices.Platform
internal struct XSXOptionsSystemSpecificOptionsInternal : IGettable<XSXOptionsSystemSpecificOptions>, ISettable<XSXOptionsSystemSpecificOptions>, IDisposable // TypeDefIndex: 10276
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_OverlayGraphicsDevice; // 0x8

	// Properties
	public IntPtr OverlayGraphicsDevice { get; set; }

	// Methods

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public IntPtr get_OverlayGraphicsDevice() { }

	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_OverlayGraphicsDevice(IntPtr value) { }

	// RVA: 0x40DD30 Offset: 0x40CF30 VA: 0x18040DD30 Slot: 5
	public void Set(ref XSXOptionsSystemSpecificOptions other) { }

	// RVA: 0x454AA0 Offset: 0x453CA0 VA: 0x180454AA0 Slot: 6
	public void Set(ref Nullable<XSXOptionsSystemSpecificOptions> other) { }

	// RVA: 0x454A40 Offset: 0x453C40 VA: 0x180454A40 Slot: 7
	public void Dispose() { }

	// RVA: 0x454A90 Offset: 0x453C90 VA: 0x180454A90 Slot: 4
	public void Get(out XSXOptionsSystemSpecificOptions output) { }
}

// Namespace: Epic.OnlineServices.Achievements
public sealed class AchievementsInterface : Handle // TypeDefIndex: 10277
{
	// Fields
	public const int AchievementUnlocktimeUndefined = -1;
	public const int AddnotifyachievementsunlockedApiLatest = 1;
	public const int Addnotifyachievementsunlockedv2ApiLatest = 2;
	public const int Copyachievementdefinitionv2ByachievementidApiLatest = 2;
	public const int Copyachievementdefinitionv2ByindexApiLatest = 2;
	public const int CopydefinitionbyachievementidApiLatest = 1;
	public const int CopydefinitionbyindexApiLatest = 1;
	public const int Copydefinitionv2ByachievementidApiLatest = 2;
	public const int Copydefinitionv2ByindexApiLatest = 2;
	public const int CopyplayerachievementbyachievementidApiLatest = 2;
	public const int CopyplayerachievementbyindexApiLatest = 2;
	public const int CopyunlockedachievementbyachievementidApiLatest = 1;
	public const int CopyunlockedachievementbyindexApiLatest = 1;
	public const int DefinitionApiLatest = 1;
	public const int Definitionv2ApiLatest = 2;
	public const int GetachievementdefinitioncountApiLatest = 1;
	public const int GetplayerachievementcountApiLatest = 1;
	public const int GetunlockedachievementcountApiLatest = 1;
	public const int PlayerachievementApiLatest = 2;
	public const int PlayerstatinfoApiLatest = 1;
	public const int QuerydefinitionsApiLatest = 3;
	public const int QueryplayerachievementsApiLatest = 2;
	public const int StatthresholdApiLatest = 1;
	public const int StatthresholdsApiLatest = 1;
	public const int UnlockachievementsApiLatest = 1;
	public const int UnlockedachievementApiLatest = 1;

	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }

	// RVA: 0x40BDB0 Offset: 0x40AFB0 VA: 0x18040BDB0
	public void .ctor(IntPtr innerHandle) { }

	// RVA: 0x43E040 Offset: 0x43D240 VA: 0x18043E040
	public ulong AddNotifyAchievementsUnlocked(ref AddNotifyAchievementsUnlockedOptions options, object clientData, OnAchievementsUnlockedCallback notificationFn) { }

	// RVA: 0x43DE90 Offset: 0x43D090 VA: 0x18043DE90
	public ulong AddNotifyAchievementsUnlockedV2(ref AddNotifyAchievementsUnlockedV2Options options, object clientData, OnAchievementsUnlockedCallbackV2 notificationFn) { }

	// RVA: 0x43E1F0 Offset: 0x43D3F0 VA: 0x18043E1F0
	public Result CopyAchievementDefinitionByAchievementId(ref CopyAchievementDefinitionByAchievementIdOptions options, out Nullable<Definition> outDefinition) { }

	// RVA: 0x43E320 Offset: 0x43D520 VA: 0x18043E320
	public Result CopyAchievementDefinitionByIndex(ref CopyAchievementDefinitionByIndexOptions options, out Nullable<Definition> outDefinition) { }

	// RVA: 0x43E410 Offset: 0x43D610 VA: 0x18043E410
	public Result CopyAchievementDefinitionV2ByAchievementId(ref CopyAchievementDefinitionV2ByAchievementIdOptions options, out Nullable<DefinitionV2> outDefinition) { }

	// RVA: 0x43E540 Offset: 0x43D740 VA: 0x18043E540
	public Result CopyAchievementDefinitionV2ByIndex(ref CopyAchievementDefinitionV2ByIndexOptions options, out Nullable<DefinitionV2> outDefinition) { }

	// RVA: 0x43E630 Offset: 0x43D830 VA: 0x18043E630
	public Result CopyPlayerAchievementByAchievementId(ref CopyPlayerAchievementByAchievementIdOptions options, out Nullable<PlayerAchievement> outAchievement) { }

	// RVA: 0x43E730 Offset: 0x43D930 VA: 0x18043E730
	public Result CopyPlayerAchievementByIndex(ref CopyPlayerAchievementByIndexOptions options, out Nullable<PlayerAchievement> outAchievement) { }

	// RVA: 0x43E830 Offset: 0x43DA30 VA: 0x18043E830
	public Result CopyUnlockedAchievementByAchievementId(ref CopyUnlockedAchievementByAchievementIdOptions options, out Nullable<UnlockedAchievement> outAchievement) { }

	// RVA: 0x43E930 Offset: 0x43DB30 VA: 0x18043E930
	public Result CopyUnlockedAchievementByIndex(ref CopyUnlockedAchievementByIndexOptions options, out Nullable<UnlockedAchievement> outAchievement) { }

	// RVA: 0x43EA80 Offset: 0x43DC80 VA: 0x18043EA80
	public uint GetAchievementDefinitionCount(ref GetAchievementDefinitionCountOptions options) { }

	// RVA: 0x43EB00 Offset: 0x43DD00 VA: 0x18043EB00
	public uint GetPlayerAchievementCount(ref GetPlayerAchievementCountOptions options) { }

	// RVA: 0x43EBE0 Offset: 0x43DDE0 VA: 0x18043EBE0
	public uint GetUnlockedAchievementCount(ref GetUnlockedAchievementCountOptions options) { }

	// RVA: 0x43F020 Offset: 0x43E220 VA: 0x18043F020
	public void QueryDefinitions(ref QueryDefinitionsOptions options, object clientData, OnQueryDefinitionsCompleteCallback completionDelegate) { }

	// RVA: 0x43F1E0 Offset: 0x43E3E0 VA: 0x18043F1E0
	public void QueryPlayerAchievements(ref QueryPlayerAchievementsOptions options, object clientData, OnQueryPlayerAchievementsCompleteCallback completionDelegate) { }

	// RVA: 0x43F390 Offset: 0x43E590 VA: 0x18043F390
	public void RemoveNotifyAchievementsUnlocked(ulong inId) { }

	// RVA: 0x43F400 Offset: 0x43E600 VA: 0x18043F400
	public void UnlockAchievements(ref UnlockAchievementsOptions options, object clientData, OnUnlockAchievementsCompleteCallback completionDelegate) { }

	[MonoPInvokeCallback(typeof(OnAchievementsUnlockedCallbackInternal))]
	// RVA: 0x43ECC0 Offset: 0x43DEC0 VA: 0x18043ECC0
	internal static void OnAchievementsUnlockedCallbackInternalImplementation(ref OnAchievementsUnlockedCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnAchievementsUnlockedCallbackV2Internal))]
	// RVA: 0x43ED70 Offset: 0x43DF70 VA: 0x18043ED70
	internal static void OnAchievementsUnlockedCallbackV2InternalImplementation(ref OnAchievementsUnlockedCallbackV2InfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnQueryDefinitionsCompleteCallbackInternal))]
	// RVA: 0x43EE20 Offset: 0x43E020 VA: 0x18043EE20
	internal static void OnQueryDefinitionsCompleteCallbackInternalImplementation(ref OnQueryDefinitionsCompleteCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnQueryPlayerAchievementsCompleteCallbackInternal))]
	// RVA: 0x43EEC0 Offset: 0x43E0C0 VA: 0x18043EEC0
	internal static void OnQueryPlayerAchievementsCompleteCallbackInternalImplementation(ref OnQueryPlayerAchievementsCompleteCallbackInfoInternal data) { }

	[MonoPInvokeCallback(typeof(OnUnlockAchievementsCompleteCallbackInternal))]
	// RVA: 0x43EF70 Offset: 0x43E170 VA: 0x18043EF70
	internal static void OnUnlockAchievementsCompleteCallbackInternalImplementation(ref OnUnlockAchievementsCompleteCallbackInfoInternal data) { }
}

// Namespace: Epic.OnlineServices.Achievements
public struct AddNotifyAchievementsUnlockedOptions // TypeDefIndex: 10278
{}

// Namespace: Epic.OnlineServices.Achievements
internal struct AddNotifyAchievementsUnlockedOptionsInternal : ISettable<AddNotifyAchievementsUnlockedOptions>, IDisposable // TypeDefIndex: 10279
{
	// Fields
	private int m_ApiVersion; // 0x0

	// Methods

	// RVA: 0x3F98A0 Offset: 0x3F8AA0 VA: 0x1803F98A0 Slot: 4
	public void Set(ref AddNotifyAchievementsUnlockedOptions other) { }

	// RVA: 0x441C10 Offset: 0x440E10 VA: 0x180441C10 Slot: 5
	public void Set(ref Nullable<AddNotifyAchievementsUnlockedOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Achievements
public struct AddNotifyAchievementsUnlockedV2Options // TypeDefIndex: 10280
{}

// Namespace: Epic.OnlineServices.Achievements
internal struct AddNotifyAchievementsUnlockedV2OptionsInternal : ISettable<AddNotifyAchievementsUnlockedV2Options>, IDisposable // TypeDefIndex: 10281
{
	// Fields
	private int m_ApiVersion; // 0x0

	// Methods

	// RVA: 0x441C60 Offset: 0x440E60 VA: 0x180441C60 Slot: 4
	public void Set(ref AddNotifyAchievementsUnlockedV2Options other) { }

	// RVA: 0x441C70 Offset: 0x440E70 VA: 0x180441C70 Slot: 5
	public void Set(ref Nullable<AddNotifyAchievementsUnlockedV2Options> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Achievements
public struct CopyAchievementDefinitionByAchievementIdOptions // TypeDefIndex: 10282
{
	// Fields
	[CompilerGenerated]
	private Utf8String <AchievementId>k__BackingField; // 0x0

	// Properties
	public Utf8String AchievementId { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Utf8String get_AchievementId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_AchievementId(Utf8String value) { }
}

// Namespace: Epic.OnlineServices.Achievements
internal struct CopyAchievementDefinitionByAchievementIdOptionsInternal : ISettable<CopyAchievementDefinitionByAchievementIdOptions>, IDisposable // TypeDefIndex: 10283
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_AchievementId; // 0x8

	// Properties
	public Utf8String AchievementId { set; }

	// Methods

	// RVA: 0x442410 Offset: 0x441610 VA: 0x180442410
	public void set_AchievementId(Utf8String value) { }

	// RVA: 0x4423B0 Offset: 0x4415B0 VA: 0x1804423B0 Slot: 4
	public void Set(ref CopyAchievementDefinitionByAchievementIdOptions other) { }

	// RVA: 0x442310 Offset: 0x441510 VA: 0x180442310 Slot: 5
	public void Set(ref Nullable<CopyAchievementDefinitionByAchievementIdOptions> other) { }

	// RVA: 0x4422C0 Offset: 0x4414C0 VA: 0x1804422C0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Achievements
public struct CopyAchievementDefinitionByIndexOptions // TypeDefIndex: 10284
{
	// Fields
	[CompilerGenerated]
	private uint <AchievementIndex>k__BackingField; // 0x0

	// Properties
	public uint AchievementIndex { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public uint get_AchievementIndex() { }

	[CompilerGenerated]
	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_AchievementIndex(uint value) { }
}

// Namespace: Epic.OnlineServices.Achievements
internal struct CopyAchievementDefinitionByIndexOptionsInternal : ISettable<CopyAchievementDefinitionByIndexOptions>, IDisposable // TypeDefIndex: 10285
{
	// Fields
	private int m_ApiVersion; // 0x0
	private uint m_AchievementIndex; // 0x4

	// Properties
	public uint AchievementIndex { set; }

	// Methods

	// RVA: 0x3F84A0 Offset: 0x3F76A0 VA: 0x1803F84A0
	public void set_AchievementIndex(uint value) { }

	// RVA: 0x40B2E0 Offset: 0x40A4E0 VA: 0x18040B2E0 Slot: 4
	public void Set(ref CopyAchievementDefinitionByIndexOptions other) { }

	// RVA: 0x442470 Offset: 0x441670 VA: 0x180442470 Slot: 5
	public void Set(ref Nullable<CopyAchievementDefinitionByIndexOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Achievements
public struct CopyAchievementDefinitionV2ByAchievementIdOptions // TypeDefIndex: 10286
{
	// Fields
	[CompilerGenerated]
	private Utf8String <AchievementId>k__BackingField; // 0x0

	// Properties
	public Utf8String AchievementId { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Utf8String get_AchievementId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_AchievementId(Utf8String value) { }
}

// Namespace: Epic.OnlineServices.Achievements
internal struct CopyAchievementDefinitionV2ByAchievementIdOptionsInternal : ISettable<CopyAchievementDefinitionV2ByAchievementIdOptions>, IDisposable // TypeDefIndex: 10287
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_AchievementId; // 0x8

	// Properties
	public Utf8String AchievementId { set; }

	// Methods

	// RVA: 0x442620 Offset: 0x441820 VA: 0x180442620
	public void set_AchievementId(Utf8String value) { }

	// RVA: 0x442520 Offset: 0x441720 VA: 0x180442520 Slot: 4
	public void Set(ref CopyAchievementDefinitionV2ByAchievementIdOptions other) { }

	// RVA: 0x442580 Offset: 0x441780 VA: 0x180442580 Slot: 5
	public void Set(ref Nullable<CopyAchievementDefinitionV2ByAchievementIdOptions> other) { }

	// RVA: 0x4424D0 Offset: 0x4416D0 VA: 0x1804424D0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Achievements
public struct CopyAchievementDefinitionV2ByIndexOptions // TypeDefIndex: 10288
{
	// Fields
	[CompilerGenerated]
	private uint <AchievementIndex>k__BackingField; // 0x0

	// Properties
	public uint AchievementIndex { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public uint get_AchievementIndex() { }

	[CompilerGenerated]
	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_AchievementIndex(uint value) { }
}

// Namespace: Epic.OnlineServices.Achievements
internal struct CopyAchievementDefinitionV2ByIndexOptionsInternal : ISettable<CopyAchievementDefinitionV2ByIndexOptions>, IDisposable // TypeDefIndex: 10289
{
	// Fields
	private int m_ApiVersion; // 0x0
	private uint m_AchievementIndex; // 0x4

	// Properties
	public uint AchievementIndex { set; }

	// Methods

	// RVA: 0x3F84A0 Offset: 0x3F76A0 VA: 0x1803F84A0
	public void set_AchievementIndex(uint value) { }

	// RVA: 0x442680 Offset: 0x441880 VA: 0x180442680 Slot: 4
	public void Set(ref CopyAchievementDefinitionV2ByIndexOptions other) { }

	// RVA: 0x442690 Offset: 0x441890 VA: 0x180442690 Slot: 5
	public void Set(ref Nullable<CopyAchievementDefinitionV2ByIndexOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Achievements
public struct CopyPlayerAchievementByAchievementIdOptions // TypeDefIndex: 10290
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <TargetUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <AchievementId>k__BackingField; // 0x8
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x10

	// Properties
	public ProductUserId TargetUserId { get; set; }
	public Utf8String AchievementId { get; set; }
	public ProductUserId LocalUserId { get; set; }

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
	public Utf8String get_AchievementId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_AchievementId(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_LocalUserId(ProductUserId value) { }
}

// Namespace: Epic.OnlineServices.Achievements
internal struct CopyPlayerAchievementByAchievementIdOptionsInternal : ISettable<CopyPlayerAchievementByAchievementIdOptions>, IDisposable // TypeDefIndex: 10291
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_TargetUserId; // 0x8
	private IntPtr m_AchievementId; // 0x10
	private IntPtr m_LocalUserId; // 0x18

	// Properties
	public ProductUserId TargetUserId { set; }
	public Utf8String AchievementId { set; }
	public ProductUserId LocalUserId { set; }

	// Methods

	// RVA: 0x442A70 Offset: 0x441C70 VA: 0x180442A70
	public void set_TargetUserId(ProductUserId value) { }

	// RVA: 0x4429B0 Offset: 0x441BB0 VA: 0x1804429B0
	public void set_AchievementId(Utf8String value) { }

	// RVA: 0x442A10 Offset: 0x441C10 VA: 0x180442A10
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x4428B0 Offset: 0x441AB0 VA: 0x1804428B0 Slot: 4
	public void Set(ref CopyPlayerAchievementByAchievementIdOptions other) { }

	// RVA: 0x442750 Offset: 0x441950 VA: 0x180442750 Slot: 5
	public void Set(ref Nullable<CopyPlayerAchievementByAchievementIdOptions> other) { }

	// RVA: 0x4426F0 Offset: 0x4418F0 VA: 0x1804426F0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Achievements
public struct CopyPlayerAchievementByIndexOptions // TypeDefIndex: 10292
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <TargetUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private uint <AchievementIndex>k__BackingField; // 0x8
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x10

	// Properties
	public ProductUserId TargetUserId { get; set; }
	public uint AchievementIndex { get; set; }
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
	// RVA: 0x3F5510 Offset: 0x3F4710 VA: 0x1803F5510
	public uint get_AchievementIndex() { }

	[CompilerGenerated]
	// RVA: 0x3F5520 Offset: 0x3F4720 VA: 0x1803F5520
	public void set_AchievementIndex(uint value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_LocalUserId(ProductUserId value) { }
}

// Namespace: Epic.OnlineServices.Achievements
internal struct CopyPlayerAchievementByIndexOptionsInternal : ISettable<CopyPlayerAchievementByIndexOptions>, IDisposable // TypeDefIndex: 10293
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_TargetUserId; // 0x8
	private uint m_AchievementIndex; // 0x10
	private IntPtr m_LocalUserId; // 0x18

	// Properties
	public ProductUserId TargetUserId { set; }
	public uint AchievementIndex { set; }
	public ProductUserId LocalUserId { set; }

	// Methods

	// RVA: 0x442D70 Offset: 0x441F70 VA: 0x180442D70
	public void set_TargetUserId(ProductUserId value) { }

	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_AchievementIndex(uint value) { }

	// RVA: 0x442D10 Offset: 0x441F10 VA: 0x180442D10
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x442C50 Offset: 0x441E50 VA: 0x180442C50 Slot: 4
	public void Set(ref CopyPlayerAchievementByIndexOptions other) { }

	// RVA: 0x442B30 Offset: 0x441D30 VA: 0x180442B30 Slot: 5
	public void Set(ref Nullable<CopyPlayerAchievementByIndexOptions> other) { }

	// RVA: 0x442AD0 Offset: 0x441CD0 VA: 0x180442AD0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Achievements
public struct CopyUnlockedAchievementByAchievementIdOptions // TypeDefIndex: 10294
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <UserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <AchievementId>k__BackingField; // 0x8

	// Properties
	public ProductUserId UserId { get; set; }
	public Utf8String AchievementId { get; set; }

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
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public Utf8String get_AchievementId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_AchievementId(Utf8String value) { }
}

// Namespace: Epic.OnlineServices.Achievements
internal struct CopyUnlockedAchievementByAchievementIdOptionsInternal : ISettable<CopyUnlockedAchievementByAchievementIdOptions>, IDisposable // TypeDefIndex: 10295
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_UserId; // 0x8
	private IntPtr m_AchievementId; // 0x10

	// Properties
	public ProductUserId UserId { set; }
	public Utf8String AchievementId { set; }

	// Methods

	// RVA: 0x443050 Offset: 0x442250 VA: 0x180443050
	public void set_UserId(ProductUserId value) { }

	// RVA: 0x442FF0 Offset: 0x4421F0 VA: 0x180442FF0
	public void set_AchievementId(Utf8String value) { }

	// RVA: 0x442E30 Offset: 0x442030 VA: 0x180442E30 Slot: 4
	public void Set(ref CopyUnlockedAchievementByAchievementIdOptions other) { }

	// RVA: 0x442EF0 Offset: 0x4420F0 VA: 0x180442EF0 Slot: 5
	public void Set(ref Nullable<CopyUnlockedAchievementByAchievementIdOptions> other) { }

	// RVA: 0x442DD0 Offset: 0x441FD0 VA: 0x180442DD0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Achievements
public struct CopyUnlockedAchievementByIndexOptions // TypeDefIndex: 10296
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <UserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private uint <AchievementIndex>k__BackingField; // 0x8

	// Properties
	public ProductUserId UserId { get; set; }
	public uint AchievementIndex { get; set; }

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
	public uint get_AchievementIndex() { }

	[CompilerGenerated]
	// RVA: 0x3F5520 Offset: 0x3F4720 VA: 0x1803F5520
	public void set_AchievementIndex(uint value) { }
}

// Namespace: Epic.OnlineServices.Achievements
internal struct CopyUnlockedAchievementByIndexOptionsInternal : ISettable<CopyUnlockedAchievementByIndexOptions>, IDisposable // TypeDefIndex: 10297
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_UserId; // 0x8
	private uint m_AchievementIndex; // 0x10

	// Properties
	public ProductUserId UserId { set; }
	public uint AchievementIndex { set; }

	// Methods

	// RVA: 0x443240 Offset: 0x442440 VA: 0x180443240
	public void set_UserId(ProductUserId value) { }

	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_AchievementIndex(uint value) { }

	// RVA: 0x4431C0 Offset: 0x4423C0 VA: 0x1804431C0 Slot: 4
	public void Set(ref CopyUnlockedAchievementByIndexOptions other) { }

	// RVA: 0x443100 Offset: 0x442300 VA: 0x180443100 Slot: 5
	public void Set(ref Nullable<CopyUnlockedAchievementByIndexOptions> other) { }

	// RVA: 0x4430B0 Offset: 0x4422B0 VA: 0x1804430B0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Achievements
public struct Definition // TypeDefIndex: 10298
{
	// Fields
	[CompilerGenerated]
	private Utf8String <AchievementId>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <DisplayName>k__BackingField; // 0x8
	[CompilerGenerated]
	private Utf8String <Description>k__BackingField; // 0x10
	[CompilerGenerated]
	private Utf8String <LockedDisplayName>k__BackingField; // 0x18
	[CompilerGenerated]
	private Utf8String <LockedDescription>k__BackingField; // 0x20
	[CompilerGenerated]
	private Utf8String <HiddenDescription>k__BackingField; // 0x28
	[CompilerGenerated]
	private Utf8String <CompletionDescription>k__BackingField; // 0x30
	[CompilerGenerated]
	private Utf8String <UnlockedIconId>k__BackingField; // 0x38
	[CompilerGenerated]
	private Utf8String <LockedIconId>k__BackingField; // 0x40
	[CompilerGenerated]
	private bool <IsHidden>k__BackingField; // 0x48
	[CompilerGenerated]
	private StatThresholds[] <StatThresholds>k__BackingField; // 0x50

	// Properties
	public Utf8String AchievementId { get; set; }
	public Utf8String DisplayName { get; set; }
	public Utf8String Description { get; set; }
	public Utf8String LockedDisplayName { get; set; }
	public Utf8String LockedDescription { get; set; }
	public Utf8String HiddenDescription { get; set; }
	public Utf8String CompletionDescription { get; set; }
	public Utf8String UnlockedIconId { get; set; }
	public Utf8String LockedIconId { get; set; }
	public bool IsHidden { get; set; }
	public StatThresholds[] StatThresholds { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Utf8String get_AchievementId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_AchievementId(Utf8String value) { }

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
	public Utf8String get_Description() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_Description(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public Utf8String get_LockedDisplayName() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_LockedDisplayName(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public Utf8String get_LockedDescription() { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_LockedDescription(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public Utf8String get_HiddenDescription() { }

	[CompilerGenerated]
	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	public void set_HiddenDescription(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public Utf8String get_CompletionDescription() { }

	[CompilerGenerated]
	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	public void set_CompletionDescription(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public Utf8String get_UnlockedIconId() { }

	[CompilerGenerated]
	// RVA: 0x40EC50 Offset: 0x40DE50 VA: 0x18040EC50
	public void set_UnlockedIconId(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	public Utf8String get_LockedIconId() { }

	[CompilerGenerated]
	// RVA: 0x415820 Offset: 0x414A20 VA: 0x180415820
	public void set_LockedIconId(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x445A70 Offset: 0x444C70 VA: 0x180445A70
	public bool get_IsHidden() { }

	[CompilerGenerated]
	// RVA: 0x445A80 Offset: 0x444C80 VA: 0x180445A80
	public void set_IsHidden(bool value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x4050A0 Offset: 0x4042A0 VA: 0x1804050A0
	public StatThresholds[] get_StatThresholds() { }

	[CompilerGenerated]
	// RVA: 0x4050C0 Offset: 0x4042C0 VA: 0x1804050C0
	public void set_StatThresholds(StatThresholds[] value) { }

	// RVA: 0x445710 Offset: 0x444910 VA: 0x180445710
	internal void Set(ref DefinitionInternal other) { }
}

// Namespace: Epic.OnlineServices.Achievements
internal struct DefinitionInternal : IGettable<Definition>, ISettable<Definition>, IDisposable // TypeDefIndex: 10299
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_AchievementId; // 0x8
	private IntPtr m_DisplayName; // 0x10
	private IntPtr m_Description; // 0x18
	private IntPtr m_LockedDisplayName; // 0x20
	private IntPtr m_LockedDescription; // 0x28
	private IntPtr m_HiddenDescription; // 0x30
	private IntPtr m_CompletionDescription; // 0x38
	private IntPtr m_UnlockedIconId; // 0x40
	private IntPtr m_LockedIconId; // 0x48
	private int m_IsHidden; // 0x50
	private int m_StatThresholdsCount; // 0x54
	private IntPtr m_StatThresholds; // 0x58

	// Properties
	public Utf8String AchievementId { get; set; }
	public Utf8String DisplayName { get; set; }
	public Utf8String Description { get; set; }
	public Utf8String LockedDisplayName { get; set; }
	public Utf8String LockedDescription { get; set; }
	public Utf8String HiddenDescription { get; set; }
	public Utf8String CompletionDescription { get; set; }
	public Utf8String UnlockedIconId { get; set; }
	public Utf8String LockedIconId { get; set; }
	public bool IsHidden { get; set; }
	public StatThresholds[] StatThresholds { get; set; }

	// Methods

	// RVA: 0x443B40 Offset: 0x442D40 VA: 0x180443B40
	public Utf8String get_AchievementId() { }

	// RVA: 0x444020 Offset: 0x443220 VA: 0x180444020
	public void set_AchievementId(Utf8String value) { }

	// RVA: 0x443C90 Offset: 0x442E90 VA: 0x180443C90
	public Utf8String get_DisplayName() { }

	// RVA: 0x444140 Offset: 0x443340 VA: 0x180444140
	public void set_DisplayName(Utf8String value) { }

	// RVA: 0x443C20 Offset: 0x442E20 VA: 0x180443C20
	public Utf8String get_Description() { }

	// RVA: 0x4440E0 Offset: 0x4432E0 VA: 0x1804440E0
	public void set_Description(Utf8String value) { }

	// RVA: 0x443E40 Offset: 0x443040 VA: 0x180443E40
	public Utf8String get_LockedDisplayName() { }

	// RVA: 0x4442C0 Offset: 0x4434C0 VA: 0x1804442C0
	public void set_LockedDisplayName(Utf8String value) { }

	// RVA: 0x443DD0 Offset: 0x442FD0 VA: 0x180443DD0
	public Utf8String get_LockedDescription() { }

	// RVA: 0x444260 Offset: 0x443460 VA: 0x180444260
	public void set_LockedDescription(Utf8String value) { }

	// RVA: 0x443D00 Offset: 0x442F00 VA: 0x180443D00
	public Utf8String get_HiddenDescription() { }

	// RVA: 0x4441A0 Offset: 0x4433A0 VA: 0x1804441A0
	public void set_HiddenDescription(Utf8String value) { }

	// RVA: 0x443BB0 Offset: 0x442DB0 VA: 0x180443BB0
	public Utf8String get_CompletionDescription() { }

	// RVA: 0x444080 Offset: 0x443280 VA: 0x180444080
	public void set_CompletionDescription(Utf8String value) { }

	// RVA: 0x443FB0 Offset: 0x4431B0 VA: 0x180443FB0
	public Utf8String get_UnlockedIconId() { }

	// RVA: 0x4443F0 Offset: 0x4435F0 VA: 0x1804443F0
	public void set_UnlockedIconId(Utf8String value) { }

	// RVA: 0x443EB0 Offset: 0x4430B0 VA: 0x180443EB0
	public Utf8String get_LockedIconId() { }

	// RVA: 0x444320 Offset: 0x443520 VA: 0x180444320
	public void set_LockedIconId(Utf8String value) { }

	// RVA: 0x443D70 Offset: 0x442F70 VA: 0x180443D70
	public bool get_IsHidden() { }

	// RVA: 0x444200 Offset: 0x443400 VA: 0x180444200
	public void set_IsHidden(bool value) { }

	// RVA: 0x443F20 Offset: 0x443120 VA: 0x180443F20
	public StatThresholds[] get_StatThresholds() { }

	// RVA: 0x444380 Offset: 0x443580 VA: 0x180444380
	public void set_StatThresholds(StatThresholds[] value) { }

	// RVA: 0x443420 Offset: 0x442620 VA: 0x180443420 Slot: 5
	public void Set(ref Definition other) { }

	// RVA: 0x443760 Offset: 0x442960 VA: 0x180443760 Slot: 6
	public void Set(ref Nullable<Definition> other) { }

	// RVA: 0x443340 Offset: 0x442540 VA: 0x180443340 Slot: 7
	public void Dispose() { }

	// RVA: 0x4433F0 Offset: 0x4425F0 VA: 0x1804433F0 Slot: 4
	public void Get(out Definition output) { }
}

// Namespace: Epic.OnlineServices.Achievements
public struct DefinitionV2 // TypeDefIndex: 10300
{
	// Fields
	[CompilerGenerated]
	private Utf8String <AchievementId>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String <UnlockedDisplayName>k__BackingField; // 0x8
	[CompilerGenerated]
	private Utf8String <UnlockedDescription>k__BackingField; // 0x10
	[CompilerGenerated]
	private Utf8String <LockedDisplayName>k__BackingField; // 0x18
	[CompilerGenerated]
	private Utf8String <LockedDescription>k__BackingField; // 0x20
	[CompilerGenerated]
	private Utf8String <FlavorText>k__BackingField; // 0x28
	[CompilerGenerated]
	private Utf8String <UnlockedIconURL>k__BackingField; // 0x30
	[CompilerGenerated]
	private Utf8String <LockedIconURL>k__BackingField; // 0x38
	[CompilerGenerated]
	private bool <IsHidden>k__BackingField; // 0x40
	[CompilerGenerated]
	private StatThresholds[] <StatThresholds>k__BackingField; // 0x48

	// Properties
	public Utf8String AchievementId { get; set; }
	public Utf8String UnlockedDisplayName { get; set; }
	public Utf8String UnlockedDescription { get; set; }
	public Utf8String LockedDisplayName { get; set; }
	public Utf8String LockedDescription { get; set; }
	public Utf8String FlavorText { get; set; }
	public Utf8String UnlockedIconURL { get; set; }
	public Utf8String LockedIconURL { get; set; }
	public bool IsHidden { get; set; }
	public StatThresholds[] StatThresholds { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Utf8String get_AchievementId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_AchievementId(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public Utf8String get_UnlockedDisplayName() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_UnlockedDisplayName(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Utf8String get_UnlockedDescription() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_UnlockedDescription(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public Utf8String get_LockedDisplayName() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_LockedDisplayName(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3F6C90 Offset: 0x3F5E90 VA: 0x1803F6C90
	public Utf8String get_LockedDescription() { }

	[CompilerGenerated]
	// RVA: 0x3F6CB0 Offset: 0x3F5EB0 VA: 0x1803F6CB0
	public void set_LockedDescription(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public Utf8String get_FlavorText() { }

	[CompilerGenerated]
	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	public void set_FlavorText(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public Utf8String get_UnlockedIconURL() { }

	[CompilerGenerated]
	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	public void set_UnlockedIconURL(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public Utf8String get_LockedIconURL() { }

	[CompilerGenerated]
	// RVA: 0x40EC50 Offset: 0x40DE50 VA: 0x18040EC50
	public void set_LockedIconURL(Utf8String value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x4456F0 Offset: 0x4448F0 VA: 0x1804456F0
	public bool get_IsHidden() { }

	[CompilerGenerated]
	// RVA: 0x445700 Offset: 0x444900 VA: 0x180445700
	public void set_IsHidden(bool value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0
	public StatThresholds[] get_StatThresholds() { }

	[CompilerGenerated]
	// RVA: 0x41A200 Offset: 0x419400 VA: 0x18041A200
	public void set_StatThresholds(StatThresholds[] value) { }

	// RVA: 0x4453E0 Offset: 0x4445E0 VA: 0x1804453E0
	internal void Set(ref DefinitionV2Internal other) { }
}

// Namespace: Epic.OnlineServices.Achievements
internal struct DefinitionV2Internal : IGettable<DefinitionV2>, ISettable<DefinitionV2>, IDisposable // TypeDefIndex: 10301
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_AchievementId; // 0x8
	private IntPtr m_UnlockedDisplayName; // 0x10
	private IntPtr m_UnlockedDescription; // 0x18
	private IntPtr m_LockedDisplayName; // 0x20
	private IntPtr m_LockedDescription; // 0x28
	private IntPtr m_FlavorText; // 0x30
	private IntPtr m_UnlockedIconURL; // 0x38
	private IntPtr m_LockedIconURL; // 0x40
	private int m_IsHidden; // 0x48
	private uint m_StatThresholdsCount; // 0x4C
	private IntPtr m_StatThresholds; // 0x50

	// Properties
	public Utf8String AchievementId { get; set; }
	public Utf8String UnlockedDisplayName { get; set; }
	public Utf8String UnlockedDescription { get; set; }
	public Utf8String LockedDisplayName { get; set; }
	public Utf8String LockedDescription { get; set; }
	public Utf8String FlavorText { get; set; }
	public Utf8String UnlockedIconURL { get; set; }
	public Utf8String LockedIconURL { get; set; }
	public bool IsHidden { get; set; }
	public StatThresholds[] StatThresholds { get; set; }

	// Methods

	// RVA: 0x444BA0 Offset: 0x443DA0 VA: 0x180444BA0
	public Utf8String get_AchievementId() { }

	// RVA: 0x445010 Offset: 0x444210 VA: 0x180445010
	public void set_AchievementId(Utf8String value) { }

	// RVA: 0x444F30 Offset: 0x444130 VA: 0x180444F30
	public Utf8String get_UnlockedDisplayName() { }

	// RVA: 0x445320 Offset: 0x444520 VA: 0x180445320
	public void set_UnlockedDisplayName(Utf8String value) { }

	// RVA: 0x444EC0 Offset: 0x4440C0 VA: 0x180444EC0
	public Utf8String get_UnlockedDescription() { }

	// RVA: 0x4452C0 Offset: 0x4444C0 VA: 0x1804452C0
	public void set_UnlockedDescription(Utf8String value) { }

	// RVA: 0x444D50 Offset: 0x443F50 VA: 0x180444D50
	public Utf8String get_LockedDisplayName() { }

	// RVA: 0x445190 Offset: 0x444390 VA: 0x180445190
	public void set_LockedDisplayName(Utf8String value) { }

	// RVA: 0x444CE0 Offset: 0x443EE0 VA: 0x180444CE0
	public Utf8String get_LockedDescription() { }

	// RVA: 0x445130 Offset: 0x444330 VA: 0x180445130
	public void set_LockedDescription(Utf8String value) { }

	// RVA: 0x444C10 Offset: 0x443E10 VA: 0x180444C10
	public Utf8String get_FlavorText() { }

	// RVA: 0x445070 Offset: 0x444270 VA: 0x180445070
	public void set_FlavorText(Utf8String value) { }

	// RVA: 0x444FA0 Offset: 0x4441A0 VA: 0x180444FA0
	public Utf8String get_UnlockedIconURL() { }

	// RVA: 0x445380 Offset: 0x444580 VA: 0x180445380
	public void set_UnlockedIconURL(Utf8String value) { }

	// RVA: 0x444DC0 Offset: 0x443FC0 VA: 0x180444DC0
	public Utf8String get_LockedIconURL() { }

	// RVA: 0x4451F0 Offset: 0x4443F0 VA: 0x1804451F0
	public void set_LockedIconURL(Utf8String value) { }

	// RVA: 0x444C80 Offset: 0x443E80 VA: 0x180444C80
	public bool get_IsHidden() { }

	// RVA: 0x4450D0 Offset: 0x4442D0 VA: 0x1804450D0
	public void set_IsHidden(bool value) { }

	// RVA: 0x444E30 Offset: 0x444030 VA: 0x180444E30
	public StatThresholds[] get_StatThresholds() { }

	// RVA: 0x445250 Offset: 0x444450 VA: 0x180445250
	public void set_StatThresholds(StatThresholds[] value) { }

	// RVA: 0x4448B0 Offset: 0x443AB0 VA: 0x1804448B0 Slot: 5
	public void Set(ref DefinitionV2 other) { }

	// RVA: 0x444530 Offset: 0x443730 VA: 0x180444530 Slot: 6
	public void Set(ref Nullable<DefinitionV2> other) { }

	// RVA: 0x444450 Offset: 0x443650 VA: 0x180444450 Slot: 7
	public void Dispose() { }

	// RVA: 0x444500 Offset: 0x443700 VA: 0x180444500 Slot: 4
	public void Get(out DefinitionV2 output) { }
}

// Namespace: Epic.OnlineServices.Achievements
public struct GetAchievementDefinitionCountOptions // TypeDefIndex: 10302
{}

// Namespace: Epic.OnlineServices.Achievements
internal struct GetAchievementDefinitionCountOptionsInternal : ISettable<GetAchievementDefinitionCountOptions>, IDisposable // TypeDefIndex: 10303
{
	// Fields
	private int m_ApiVersion; // 0x0

	// Methods

	// RVA: 0x3F98A0 Offset: 0x3F8AA0 VA: 0x1803F98A0 Slot: 4
	public void Set(ref GetAchievementDefinitionCountOptions other) { }

	// RVA: 0x449490 Offset: 0x448690 VA: 0x180449490 Slot: 5
	public void Set(ref Nullable<GetAchievementDefinitionCountOptions> other) { }

	// RVA: 0x3D8590 Offset: 0x3D7790 VA: 0x1803D8590 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Achievements
public struct GetPlayerAchievementCountOptions // TypeDefIndex: 10304
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

// Namespace: Epic.OnlineServices.Achievements
internal struct GetPlayerAchievementCountOptionsInternal : ISettable<GetPlayerAchievementCountOptions>, IDisposable // TypeDefIndex: 10305
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_UserId; // 0x8

	// Properties
	public ProductUserId UserId { set; }

	// Methods

	// RVA: 0x449F10 Offset: 0x449110 VA: 0x180449F10
	public void set_UserId(ProductUserId value) { }

	// RVA: 0x449E10 Offset: 0x449010 VA: 0x180449E10 Slot: 4
	public void Set(ref GetPlayerAchievementCountOptions other) { }

	// RVA: 0x449E70 Offset: 0x449070 VA: 0x180449E70 Slot: 5
	public void Set(ref Nullable<GetPlayerAchievementCountOptions> other) { }

	// RVA: 0x449DC0 Offset: 0x448FC0 VA: 0x180449DC0 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Achievements
public struct GetUnlockedAchievementCountOptions // TypeDefIndex: 10306
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <UserId>k__BackingField; // 0x0

	// Properties
	public ProductUserId UserId { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public ProductUserId get_UserId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_UserId(ProductUserId value) { }
}

// Namespace: Epic.OnlineServices.Achievements
internal struct GetUnlockedAchievementCountOptionsInternal : ISettable<GetUnlockedAchievementCountOptions>, IDisposable // TypeDefIndex: 10307
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_UserId; // 0x8

	// Properties
	public ProductUserId UserId { set; }

	// Methods

	// RVA: 0x44A2B0 Offset: 0x4494B0 VA: 0x18044A2B0
	public void set_UserId(ProductUserId value) { }

	// RVA: 0x44A250 Offset: 0x449450 VA: 0x18044A250 Slot: 4
	public void Set(ref GetUnlockedAchievementCountOptions other) { }

	// RVA: 0x44A1B0 Offset: 0x4493B0 VA: 0x18044A1B0 Slot: 5
	public void Set(ref Nullable<GetUnlockedAchievementCountOptions> other) { }

	// RVA: 0x44A160 Offset: 0x449360 VA: 0x18044A160 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Achievements
public sealed class OnAchievementsUnlockedCallback : MulticastDelegate // TypeDefIndex: 10308
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref OnAchievementsUnlockedCallbackInfo data) { }

	// RVA: 0x44D110 Offset: 0x44C310 VA: 0x18044D110 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref OnAchievementsUnlockedCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref OnAchievementsUnlockedCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Achievements
[UnmanagedFunctionPointer(2)]
internal sealed class OnAchievementsUnlockedCallbackInternal : MulticastDelegate // TypeDefIndex: 10309
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref OnAchievementsUnlockedCallbackInfoInternal data) { }

	// RVA: 0x44C710 Offset: 0x44B910 VA: 0x18044C710 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref OnAchievementsUnlockedCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref OnAchievementsUnlockedCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Achievements
public struct OnAchievementsUnlockedCallbackInfo : ICallbackInfo // TypeDefIndex: 10310
{
	// Fields
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x0
	[CompilerGenerated]
	private ProductUserId <UserId>k__BackingField; // 0x8
	[CompilerGenerated]
	private Utf8String[] <AchievementIds>k__BackingField; // 0x10

	// Properties
	public object ClientData { get; set; }
	public ProductUserId UserId { get; set; }
	public Utf8String[] AchievementIds { get; set; }

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
	public ProductUserId get_UserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_UserId(ProductUserId value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Utf8String[] get_AchievementIds() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_AchievementIds(Utf8String[] value) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x44C670 Offset: 0x44B870 VA: 0x18044C670
	internal void Set(ref OnAchievementsUnlockedCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.Achievements
internal struct OnAchievementsUnlockedCallbackInfoInternal : ICallbackInfoInternal, IGettable<OnAchievementsUnlockedCallbackInfo>, ISettable<OnAchievementsUnlockedCallbackInfo>, IDisposable // TypeDefIndex: 10311
{
	// Fields
	private IntPtr m_ClientData; // 0x0
	private IntPtr m_UserId; // 0x8
	private uint m_AchievementsCount; // 0x10
	private IntPtr m_AchievementIds; // 0x18

	// Properties
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public ProductUserId UserId { get; set; }
	public Utf8String[] AchievementIds { get; set; }

	// Methods

	// RVA: 0x44C440 Offset: 0x44B640 VA: 0x18044C440
	public object get_ClientData() { }

	// RVA: 0x44C5B0 Offset: 0x44B7B0 VA: 0x18044C5B0
	public void set_ClientData(object value) { }

	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x44C4B0 Offset: 0x44B6B0 VA: 0x18044C4B0
	public ProductUserId get_UserId() { }

	// RVA: 0x44C610 Offset: 0x44B810 VA: 0x18044C610
	public void set_UserId(ProductUserId value) { }

	// RVA: 0x44C3B0 Offset: 0x44B5B0 VA: 0x18044C3B0
	public Utf8String[] get_AchievementIds() { }

	// RVA: 0x44C530 Offset: 0x44B730 VA: 0x18044C530
	public void set_AchievementIds(Utf8String[] value) { }

	// RVA: 0x44C1D0 Offset: 0x44B3D0 VA: 0x18044C1D0 Slot: 6
	public void Set(ref OnAchievementsUnlockedCallbackInfo other) { }

	// RVA: 0x44C290 Offset: 0x44B490 VA: 0x18044C290 Slot: 7
	public void Set(ref Nullable<OnAchievementsUnlockedCallbackInfo> other) { }

	// RVA: 0x44C150 Offset: 0x44B350 VA: 0x18044C150 Slot: 8
	public void Dispose() { }

	// RVA: 0x44C1B0 Offset: 0x44B3B0 VA: 0x18044C1B0 Slot: 5
	public void Get(out OnAchievementsUnlockedCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.Achievements
public sealed class OnAchievementsUnlockedCallbackV2 : MulticastDelegate // TypeDefIndex: 10312
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref OnAchievementsUnlockedCallbackV2Info data) { }

	// RVA: 0x44D080 Offset: 0x44C280 VA: 0x18044D080 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref OnAchievementsUnlockedCallbackV2Info data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref OnAchievementsUnlockedCallbackV2Info data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Achievements
[UnmanagedFunctionPointer(2)]
internal sealed class OnAchievementsUnlockedCallbackV2Internal : MulticastDelegate // TypeDefIndex: 10313
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref OnAchievementsUnlockedCallbackV2InfoInternal data) { }

	// RVA: 0x44CFF0 Offset: 0x44C1F0 VA: 0x18044CFF0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref OnAchievementsUnlockedCallbackV2InfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref OnAchievementsUnlockedCallbackV2InfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Achievements
public struct OnAchievementsUnlockedCallbackV2Info : ICallbackInfo // TypeDefIndex: 10314
{
	// Fields
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x0
	[CompilerGenerated]
	private ProductUserId <UserId>k__BackingField; // 0x8
	[CompilerGenerated]
	private Utf8String <AchievementId>k__BackingField; // 0x10
	[CompilerGenerated]
	private Nullable<DateTimeOffset> <UnlockTime>k__BackingField; // 0x18

	// Properties
	public object ClientData { get; set; }
	public ProductUserId UserId { get; set; }
	public Utf8String AchievementId { get; set; }
	public Nullable<DateTimeOffset> UnlockTime { get; set; }

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
	public ProductUserId get_UserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_UserId(ProductUserId value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	public Utf8String get_AchievementId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_AchievementId(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x426510 Offset: 0x425710 VA: 0x180426510
	public Nullable<DateTimeOffset> get_UnlockTime() { }

	[CompilerGenerated]
	// RVA: 0x426540 Offset: 0x425740 VA: 0x180426540
	public void set_UnlockTime(Nullable<DateTimeOffset> value) { }

	// RVA: 0x3F92A0 Offset: 0x3F84A0 VA: 0x1803F92A0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x44CEA0 Offset: 0x44C0A0 VA: 0x18044CEA0
	internal void Set(ref OnAchievementsUnlockedCallbackV2InfoInternal other) { }
}

// Namespace: Epic.OnlineServices.Achievements
internal struct OnAchievementsUnlockedCallbackV2InfoInternal : ICallbackInfoInternal, IGettable<OnAchievementsUnlockedCallbackV2Info>, ISettable<OnAchievementsUnlockedCallbackV2Info>, IDisposable // TypeDefIndex: 10315
{
	// Fields
	private IntPtr m_ClientData; // 0x0
	private IntPtr m_UserId; // 0x8
	private IntPtr m_AchievementId; // 0x10
	private long m_UnlockTime; // 0x18

	// Properties
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public ProductUserId UserId { get; set; }
	public Utf8String AchievementId { get; set; }
	public Nullable<DateTimeOffset> UnlockTime { get; set; }

	// Methods

	// RVA: 0x44CBB0 Offset: 0x44BDB0 VA: 0x18044CBB0
	public object get_ClientData() { }

	// RVA: 0x44CD70 Offset: 0x44BF70 VA: 0x18044CD70
	public void set_ClientData(object value) { }

	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x44CC90 Offset: 0x44BE90 VA: 0x18044CC90
	public ProductUserId get_UserId() { }

	// RVA: 0x44CE40 Offset: 0x44C040 VA: 0x18044CE40
	public void set_UserId(ProductUserId value) { }

	// RVA: 0x44CB40 Offset: 0x44BD40 VA: 0x18044CB40
	public Utf8String get_AchievementId() { }

	// RVA: 0x44CD10 Offset: 0x44BF10 VA: 0x18044CD10
	public void set_AchievementId(Utf8String value) { }

	// RVA: 0x44CC20 Offset: 0x44BE20 VA: 0x18044CC20
	public Nullable<DateTimeOffset> get_UnlockTime() { }

	// RVA: 0x44CDD0 Offset: 0x44BFD0 VA: 0x18044CDD0
	public void set_UnlockTime(Nullable<DateTimeOffset> value) { }

	// RVA: 0x44C820 Offset: 0x44BA20 VA: 0x18044C820 Slot: 6
	public void Set(ref OnAchievementsUnlockedCallbackV2Info other) { }

	// RVA: 0x44C980 Offset: 0x44BB80 VA: 0x18044C980 Slot: 7
	public void Set(ref Nullable<OnAchievementsUnlockedCallbackV2Info> other) { }

	// RVA: 0x44C7A0 Offset: 0x44B9A0 VA: 0x18044C7A0 Slot: 8
	public void Dispose() { }

	// RVA: 0x44C800 Offset: 0x44BA00 VA: 0x18044C800 Slot: 5
	public void Get(out OnAchievementsUnlockedCallbackV2Info output) { }
}

// Namespace: Epic.OnlineServices.Achievements
public sealed class OnQueryDefinitionsCompleteCallback : MulticastDelegate // TypeDefIndex: 10316
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref OnQueryDefinitionsCompleteCallbackInfo data) { }

	// RVA: 0x44D560 Offset: 0x44C760 VA: 0x18044D560 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref OnQueryDefinitionsCompleteCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref OnQueryDefinitionsCompleteCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Achievements
[UnmanagedFunctionPointer(2)]
internal sealed class OnQueryDefinitionsCompleteCallbackInternal : MulticastDelegate // TypeDefIndex: 10317
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref OnQueryDefinitionsCompleteCallbackInfoInternal data) { }

	// RVA: 0x44D4D0 Offset: 0x44C6D0 VA: 0x18044D4D0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref OnQueryDefinitionsCompleteCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref OnQueryDefinitionsCompleteCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Achievements
public struct OnQueryDefinitionsCompleteCallbackInfo : ICallbackInfo // TypeDefIndex: 10318
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

	// RVA: 0x44D400 Offset: 0x44C600 VA: 0x18044D400 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x44D450 Offset: 0x44C650 VA: 0x18044D450
	internal void Set(ref OnQueryDefinitionsCompleteCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.Achievements
internal struct OnQueryDefinitionsCompleteCallbackInfoInternal : ICallbackInfoInternal, IGettable<OnQueryDefinitionsCompleteCallbackInfo>, ISettable<OnQueryDefinitionsCompleteCallbackInfo>, IDisposable // TypeDefIndex: 10319
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

	// RVA: 0x44D330 Offset: 0x44C530 VA: 0x18044D330
	public object get_ClientData() { }

	// RVA: 0x44D3A0 Offset: 0x44C5A0 VA: 0x18044D3A0
	public void set_ClientData(object value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x44D2D0 Offset: 0x44C4D0 VA: 0x18044D2D0 Slot: 6
	public void Set(ref OnQueryDefinitionsCompleteCallbackInfo other) { }

	// RVA: 0x44D210 Offset: 0x44C410 VA: 0x18044D210 Slot: 7
	public void Set(ref Nullable<OnQueryDefinitionsCompleteCallbackInfo> other) { }

	// RVA: 0x44D1A0 Offset: 0x44C3A0 VA: 0x18044D1A0 Slot: 8
	public void Dispose() { }

	// RVA: 0x44D1F0 Offset: 0x44C3F0 VA: 0x18044D1F0 Slot: 5
	public void Get(out OnQueryDefinitionsCompleteCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.Achievements
public sealed class OnQueryPlayerAchievementsCompleteCallback : MulticastDelegate // TypeDefIndex: 10320
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref OnQueryPlayerAchievementsCompleteCallbackInfo data) { }

	// RVA: 0x44DCF0 Offset: 0x44CEF0 VA: 0x18044DCF0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref OnQueryPlayerAchievementsCompleteCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref OnQueryPlayerAchievementsCompleteCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Achievements
[UnmanagedFunctionPointer(2)]
internal sealed class OnQueryPlayerAchievementsCompleteCallbackInternal : MulticastDelegate // TypeDefIndex: 10321
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref OnQueryPlayerAchievementsCompleteCallbackInfoInternal data) { }

	// RVA: 0x44DC60 Offset: 0x44CE60 VA: 0x18044DC60 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref OnQueryPlayerAchievementsCompleteCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref OnQueryPlayerAchievementsCompleteCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Achievements
public struct OnQueryPlayerAchievementsCompleteCallbackInfo : ICallbackInfo // TypeDefIndex: 10322
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
	public ProductUserId get_TargetUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_TargetUserId(ProductUserId value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D82F0 Offset: 0x3D74F0 VA: 0x1803D82F0
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9A70 Offset: 0x3D8C70 VA: 0x1803D9A70
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x44DB70 Offset: 0x44CD70 VA: 0x18044DB70 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x44DBC0 Offset: 0x44CDC0 VA: 0x18044DBC0
	internal void Set(ref OnQueryPlayerAchievementsCompleteCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.Achievements
internal struct OnQueryPlayerAchievementsCompleteCallbackInfoInternal : ICallbackInfoInternal, IGettable<OnQueryPlayerAchievementsCompleteCallbackInfo>, ISettable<OnQueryPlayerAchievementsCompleteCallbackInfo>, IDisposable // TypeDefIndex: 10323
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

	// RVA: 0x44D8E0 Offset: 0x44CAE0 VA: 0x18044D8E0
	public object get_ClientData() { }

	// RVA: 0x44DA50 Offset: 0x44CC50 VA: 0x18044DA50
	public void set_ClientData(object value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x44D9D0 Offset: 0x44CBD0 VA: 0x18044D9D0
	public ProductUserId get_TargetUserId() { }

	// RVA: 0x44DB10 Offset: 0x44CD10 VA: 0x18044DB10
	public void set_TargetUserId(ProductUserId value) { }

	// RVA: 0x44D950 Offset: 0x44CB50 VA: 0x18044D950
	public ProductUserId get_LocalUserId() { }

	// RVA: 0x44DAB0 Offset: 0x44CCB0 VA: 0x18044DAB0
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x44D670 Offset: 0x44C870 VA: 0x18044D670 Slot: 6
	public void Set(ref OnQueryPlayerAchievementsCompleteCallbackInfo other) { }

	// RVA: 0x44D770 Offset: 0x44C970 VA: 0x18044D770 Slot: 7
	public void Set(ref Nullable<OnQueryPlayerAchievementsCompleteCallbackInfo> other) { }

	// RVA: 0x44D5F0 Offset: 0x44C7F0 VA: 0x18044D5F0 Slot: 8
	public void Dispose() { }

	// RVA: 0x44D650 Offset: 0x44C850 VA: 0x18044D650 Slot: 5
	public void Get(out OnQueryPlayerAchievementsCompleteCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.Achievements
public sealed class OnUnlockAchievementsCompleteCallback : MulticastDelegate // TypeDefIndex: 10324
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref OnUnlockAchievementsCompleteCallbackInfo data) { }

	// RVA: 0x44E320 Offset: 0x44D520 VA: 0x18044E320 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref OnUnlockAchievementsCompleteCallbackInfo data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref OnUnlockAchievementsCompleteCallbackInfo data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Achievements
[UnmanagedFunctionPointer(2)]
internal sealed class OnUnlockAchievementsCompleteCallbackInternal : MulticastDelegate // TypeDefIndex: 10325
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref OnUnlockAchievementsCompleteCallbackInfoInternal data) { }

	// RVA: 0x44E290 Offset: 0x44D490 VA: 0x18044E290 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref OnUnlockAchievementsCompleteCallbackInfoInternal data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref OnUnlockAchievementsCompleteCallbackInfoInternal data, IAsyncResult result) { }
}

// Namespace: Epic.OnlineServices.Achievements
public struct OnUnlockAchievementsCompleteCallbackInfo : ICallbackInfo // TypeDefIndex: 10326
{
	// Fields
	[CompilerGenerated]
	private Result <ResultCode>k__BackingField; // 0x0
	[CompilerGenerated]
	private object <ClientData>k__BackingField; // 0x8
	[CompilerGenerated]
	private ProductUserId <UserId>k__BackingField; // 0x10
	[CompilerGenerated]
	private uint <AchievementsCount>k__BackingField; // 0x18

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public ProductUserId UserId { get; set; }
	public uint AchievementsCount { get; set; }

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
	public ProductUserId get_UserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	public void set_UserId(ProductUserId value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public uint get_AchievementsCount() { }

	[CompilerGenerated]
	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	public void set_AchievementsCount(uint value) { }

	// RVA: 0x44E1A0 Offset: 0x44D3A0 VA: 0x18044E1A0 Slot: 5
	public Nullable<Result> GetResultCode() { }

	// RVA: 0x44E1F0 Offset: 0x44D3F0 VA: 0x18044E1F0
	internal void Set(ref OnUnlockAchievementsCompleteCallbackInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.Achievements
internal struct OnUnlockAchievementsCompleteCallbackInfoInternal : ICallbackInfoInternal, IGettable<OnUnlockAchievementsCompleteCallbackInfo>, ISettable<OnUnlockAchievementsCompleteCallbackInfo>, IDisposable // TypeDefIndex: 10327
{
	// Fields
	private Result m_ResultCode; // 0x0
	private IntPtr m_ClientData; // 0x8
	private IntPtr m_UserId; // 0x10
	private uint m_AchievementsCount; // 0x18

	// Properties
	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public ProductUserId UserId { get; set; }
	public uint AchievementsCount { get; set; }

	// Methods

	// RVA: 0x3D9030 Offset: 0x3D8230 VA: 0x1803D9030
	public Result get_ResultCode() { }

	// RVA: 0x3D9060 Offset: 0x3D8260 VA: 0x1803D9060
	public void set_ResultCode(Result value) { }

	// RVA: 0x44DFF0 Offset: 0x44D1F0 VA: 0x18044DFF0
	public object get_ClientData() { }

	// RVA: 0x44E0E0 Offset: 0x44D2E0 VA: 0x18044E0E0
	public void set_ClientData(object value) { }

	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010 Slot: 4
	public IntPtr get_ClientDataAddress() { }

	// RVA: 0x44E060 Offset: 0x44D260 VA: 0x18044E060
	public ProductUserId get_UserId() { }

	// RVA: 0x44E140 Offset: 0x44D340 VA: 0x18044E140
	public void set_UserId(ProductUserId value) { }

	// RVA: 0x3F8A80 Offset: 0x3F7C80 VA: 0x1803F8A80
	public uint get_AchievementsCount() { }

	// RVA: 0x3F4740 Offset: 0x3F3940 VA: 0x1803F4740
	public void set_AchievementsCount(uint value) { }

	// RVA: 0x44DF30 Offset: 0x44D130 VA: 0x18044DF30 Slot: 6
	public void Set(ref OnUnlockAchievementsCompleteCallbackInfo other) { }

	// RVA: 0x44DE00 Offset: 0x44D000 VA: 0x18044DE00 Slot: 7
	public void Set(ref Nullable<OnUnlockAchievementsCompleteCallbackInfo> other) { }

	// RVA: 0x44DD80 Offset: 0x44CF80 VA: 0x18044DD80 Slot: 8
	public void Dispose() { }

	// RVA: 0x44DDE0 Offset: 0x44CFE0 VA: 0x18044DDE0 Slot: 5
	public void Get(out OnUnlockAchievementsCompleteCallbackInfo output) { }
}

// Namespace: Epic.OnlineServices.Achievements
public struct PlayerAchievement // TypeDefIndex: 10328
{
	// Fields
	[CompilerGenerated]
	private Utf8String <AchievementId>k__BackingField; // 0x0
	[CompilerGenerated]
	private double <Progress>k__BackingField; // 0x8
	[CompilerGenerated]
	private Nullable<DateTimeOffset> <UnlockTime>k__BackingField; // 0x10
	[CompilerGenerated]
	private PlayerStatInfo[] <StatInfo>k__BackingField; // 0x28
	[CompilerGenerated]
	private Utf8String <DisplayName>k__BackingField; // 0x30
	[CompilerGenerated]
	private Utf8String <Description>k__BackingField; // 0x38
	[CompilerGenerated]
	private Utf8String <IconURL>k__BackingField; // 0x40
	[CompilerGenerated]
	private Utf8String <FlavorText>k__BackingField; // 0x48

	// Properties
	public Utf8String AchievementId { get; set; }
	public double Progress { get; set; }
	public Nullable<DateTimeOffset> UnlockTime { get; set; }
	public PlayerStatInfo[] StatInfo { get; set; }
	public Utf8String DisplayName { get; set; }
	public Utf8String Description { get; set; }
	public Utf8String IconURL { get; set; }
	public Utf8String FlavorText { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Utf8String get_AchievementId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_AchievementId(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x44F1E0 Offset: 0x44E3E0 VA: 0x18044F1E0
	public double get_Progress() { }

	[CompilerGenerated]
	// RVA: 0x44F210 Offset: 0x44E410 VA: 0x18044F210
	public void set_Progress(double value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x44F1F0 Offset: 0x44E3F0 VA: 0x18044F1F0
	public Nullable<DateTimeOffset> get_UnlockTime() { }

	[CompilerGenerated]
	// RVA: 0x44F220 Offset: 0x44E420 VA: 0x18044F220
	public void set_UnlockTime(Nullable<DateTimeOffset> value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3D99E0 Offset: 0x3D8BE0 VA: 0x1803D99E0
	public PlayerStatInfo[] get_StatInfo() { }

	[CompilerGenerated]
	// RVA: 0x402650 Offset: 0x401850 VA: 0x180402650
	public void set_StatInfo(PlayerStatInfo[] value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x42B620 Offset: 0x42A820 VA: 0x18042B620
	public Utf8String get_DisplayName() { }

	[CompilerGenerated]
	// RVA: 0x3F6370 Offset: 0x3F5570 VA: 0x1803F6370
	public void set_DisplayName(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x40EC30 Offset: 0x40DE30 VA: 0x18040EC30
	public Utf8String get_Description() { }

	[CompilerGenerated]
	// RVA: 0x40EC50 Offset: 0x40DE50 VA: 0x18040EC50
	public void set_Description(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x4157D0 Offset: 0x4149D0 VA: 0x1804157D0
	public Utf8String get_IconURL() { }

	[CompilerGenerated]
	// RVA: 0x415820 Offset: 0x414A20 VA: 0x180415820
	public void set_IconURL(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x41A1D0 Offset: 0x4193D0 VA: 0x18041A1D0
	public Utf8String get_FlavorText() { }

	[CompilerGenerated]
	// RVA: 0x41A200 Offset: 0x419400 VA: 0x18041A200
	public void set_FlavorText(Utf8String value) { }

	// RVA: 0x44EF90 Offset: 0x44E190 VA: 0x18044EF90
	internal void Set(ref PlayerAchievementInternal other) { }
}

// Namespace: Epic.OnlineServices.Achievements
internal struct PlayerAchievementInternal : IGettable<PlayerAchievement>, ISettable<PlayerAchievement>, IDisposable // TypeDefIndex: 10329
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_AchievementId; // 0x8
	private double m_Progress; // 0x10
	private long m_UnlockTime; // 0x18
	private int m_StatInfoCount; // 0x20
	private IntPtr m_StatInfo; // 0x28
	private IntPtr m_DisplayName; // 0x30
	private IntPtr m_Description; // 0x38
	private IntPtr m_IconURL; // 0x40
	private IntPtr m_FlavorText; // 0x48

	// Properties
	public Utf8String AchievementId { get; set; }
	public double Progress { get; set; }
	public Nullable<DateTimeOffset> UnlockTime { get; set; }
	public PlayerStatInfo[] StatInfo { get; set; }
	public Utf8String DisplayName { get; set; }
	public Utf8String Description { get; set; }
	public Utf8String IconURL { get; set; }
	public Utf8String FlavorText { get; set; }

	// Methods

	// RVA: 0x44E980 Offset: 0x44DB80 VA: 0x18044E980
	public Utf8String get_AchievementId() { }

	// RVA: 0x44ECC0 Offset: 0x44DEC0 VA: 0x18044ECC0
	public void set_AchievementId(Utf8String value) { }

	// RVA: 0x44EBB0 Offset: 0x44DDB0 VA: 0x18044EBB0
	public double get_Progress() { }

	// RVA: 0x44EEA0 Offset: 0x44E0A0 VA: 0x18044EEA0
	public void set_Progress(double value) { }

	// RVA: 0x44EC50 Offset: 0x44DE50 VA: 0x18044EC50
	public Nullable<DateTimeOffset> get_UnlockTime() { }

	// RVA: 0x44EF20 Offset: 0x44E120 VA: 0x18044EF20
	public void set_UnlockTime(Nullable<DateTimeOffset> value) { }

	// RVA: 0x44EBC0 Offset: 0x44DDC0 VA: 0x18044EBC0
	public PlayerStatInfo[] get_StatInfo() { }

	// RVA: 0x44EEB0 Offset: 0x44E0B0 VA: 0x18044EEB0
	public void set_StatInfo(PlayerStatInfo[] value) { }

	// RVA: 0x44EA60 Offset: 0x44DC60 VA: 0x18044EA60
	public Utf8String get_DisplayName() { }

	// RVA: 0x44ED80 Offset: 0x44DF80 VA: 0x18044ED80
	public void set_DisplayName(Utf8String value) { }

	// RVA: 0x44E9F0 Offset: 0x44DBF0 VA: 0x18044E9F0
	public Utf8String get_Description() { }

	// RVA: 0x44ED20 Offset: 0x44DF20 VA: 0x18044ED20
	public void set_Description(Utf8String value) { }

	// RVA: 0x44EB40 Offset: 0x44DD40 VA: 0x18044EB40
	public Utf8String get_IconURL() { }

	// RVA: 0x44EE40 Offset: 0x44E040 VA: 0x18044EE40
	public void set_IconURL(Utf8String value) { }

	// RVA: 0x44EAD0 Offset: 0x44DCD0 VA: 0x18044EAD0
	public Utf8String get_FlavorText() { }

	// RVA: 0x44EDE0 Offset: 0x44DFE0 VA: 0x18044EDE0
	public void set_FlavorText(Utf8String value) { }

	// RVA: 0x44E470 Offset: 0x44D670 VA: 0x18044E470 Slot: 5
	public void Set(ref PlayerAchievement other) { }

	// RVA: 0x44E6C0 Offset: 0x44D8C0 VA: 0x18044E6C0 Slot: 6
	public void Set(ref Nullable<PlayerAchievement> other) { }

	// RVA: 0x44E3B0 Offset: 0x44D5B0 VA: 0x18044E3B0 Slot: 7
	public void Dispose() { }

	// RVA: 0x44E440 Offset: 0x44D640 VA: 0x18044E440 Slot: 4
	public void Get(out PlayerAchievement output) { }
}

// Namespace: Epic.OnlineServices.Achievements
public struct PlayerStatInfo // TypeDefIndex: 10330
{
	// Fields
	[CompilerGenerated]
	private Utf8String <Name>k__BackingField; // 0x0
	[CompilerGenerated]
	private int <CurrentValue>k__BackingField; // 0x8
	[CompilerGenerated]
	private int <ThresholdValue>k__BackingField; // 0xC

	// Properties
	public Utf8String Name { get; set; }
	public int CurrentValue { get; set; }
	public int ThresholdValue { get; set; }

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
	public int get_CurrentValue() { }

	[CompilerGenerated]
	// RVA: 0x3F5520 Offset: 0x3F4720 VA: 0x1803F5520
	public void set_CurrentValue(int value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x438080 Offset: 0x437280 VA: 0x180438080
	public int get_ThresholdValue() { }

	[CompilerGenerated]
	// RVA: 0x438090 Offset: 0x437290 VA: 0x180438090
	public void set_ThresholdValue(int value) { }

	// RVA: 0x44F4F0 Offset: 0x44E6F0 VA: 0x18044F4F0
	internal void Set(ref PlayerStatInfoInternal other) { }
}

// Namespace: Epic.OnlineServices.Achievements
internal struct PlayerStatInfoInternal : IGettable<PlayerStatInfo>, ISettable<PlayerStatInfo>, IDisposable // TypeDefIndex: 10331
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_Name; // 0x8
	private int m_CurrentValue; // 0x10
	private int m_ThresholdValue; // 0x14

	// Properties
	public Utf8String Name { get; set; }
	public int CurrentValue { get; set; }
	public int ThresholdValue { get; set; }

	// Methods

	// RVA: 0x44F420 Offset: 0x44E620 VA: 0x18044F420
	public Utf8String get_Name() { }

	// RVA: 0x44F490 Offset: 0x44E690 VA: 0x18044F490
	public void set_Name(Utf8String value) { }

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public int get_CurrentValue() { }

	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_CurrentValue(int value) { }

	// RVA: 0x426500 Offset: 0x425700 VA: 0x180426500
	public int get_ThresholdValue() { }

	// RVA: 0x426530 Offset: 0x425730 VA: 0x180426530
	public void set_ThresholdValue(int value) { }

	// RVA: 0x44F2B0 Offset: 0x44E4B0 VA: 0x18044F2B0 Slot: 5
	public void Set(ref PlayerStatInfo other) { }

	// RVA: 0x44F330 Offset: 0x44E530 VA: 0x18044F330 Slot: 6
	public void Set(ref Nullable<PlayerStatInfo> other) { }

	// RVA: 0x44F240 Offset: 0x44E440 VA: 0x18044F240 Slot: 7
	public void Dispose() { }

	// RVA: 0x44F290 Offset: 0x44E490 VA: 0x18044F290 Slot: 4
	public void Get(out PlayerStatInfo output) { }
}

// Namespace: Epic.OnlineServices.Achievements
public struct QueryDefinitionsOptions // TypeDefIndex: 10332
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <LocalUserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private EpicAccountId <EpicUserId_DEPRECATED>k__BackingField; // 0x8
	[CompilerGenerated]
	private Utf8String[] <HiddenAchievementIds_DEPRECATED>k__BackingField; // 0x10

	// Properties
	public ProductUserId LocalUserId { get; set; }
	internal EpicAccountId EpicUserId_DEPRECATED { get; set; }
	internal Utf8String[] HiddenAchievementIds_DEPRECATED { get; set; }

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
	internal EpicAccountId get_EpicUserId_DEPRECATED() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	internal void set_EpicUserId_DEPRECATED(EpicAccountId value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D82E0 Offset: 0x3D74E0 VA: 0x1803D82E0
	internal Utf8String[] get_HiddenAchievementIds_DEPRECATED() { }

	[CompilerGenerated]
	// RVA: 0x3D9AA0 Offset: 0x3D8CA0 VA: 0x1803D9AA0
	internal void set_HiddenAchievementIds_DEPRECATED(Utf8String[] value) { }
}

// Namespace: Epic.OnlineServices.Achievements
internal struct QueryDefinitionsOptionsInternal : ISettable<QueryDefinitionsOptions>, IDisposable // TypeDefIndex: 10333
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_LocalUserId; // 0x8
	private IntPtr m_EpicUserId_DEPRECATED; // 0x10
	private IntPtr m_HiddenAchievementIds_DEPRECATED; // 0x18
	private uint m_HiddenAchievementsCount_DEPRECATED; // 0x20

	// Properties
	public ProductUserId LocalUserId { set; }
	public EpicAccountId EpicUserId_DEPRECATED { set; }
	public Utf8String[] HiddenAchievementIds_DEPRECATED { set; }

	// Methods

	// RVA: 0x44F8B0 Offset: 0x44EAB0 VA: 0x18044F8B0
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x44F7D0 Offset: 0x44E9D0 VA: 0x18044F7D0
	public void set_EpicUserId_DEPRECATED(EpicAccountId value) { }

	// RVA: 0x44F830 Offset: 0x44EA30 VA: 0x18044F830
	public void set_HiddenAchievementIds_DEPRECATED(Utf8String[] value) { }

	// RVA: 0x44F710 Offset: 0x44E910 VA: 0x18044F710 Slot: 4
	public void Set(ref QueryDefinitionsOptions other) { }

	// RVA: 0x44F5E0 Offset: 0x44E7E0 VA: 0x18044F5E0 Slot: 5
	public void Set(ref Nullable<QueryDefinitionsOptions> other) { }

	// RVA: 0x44F580 Offset: 0x44E780 VA: 0x18044F580 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Achievements
public struct QueryPlayerAchievementsOptions // TypeDefIndex: 10334
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

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public ProductUserId get_TargetUserId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_TargetUserId(ProductUserId value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public ProductUserId get_LocalUserId() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_LocalUserId(ProductUserId value) { }
}

// Namespace: Epic.OnlineServices.Achievements
internal struct QueryPlayerAchievementsOptionsInternal : ISettable<QueryPlayerAchievementsOptions>, IDisposable // TypeDefIndex: 10335
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_TargetUserId; // 0x8
	private IntPtr m_LocalUserId; // 0x10

	// Properties
	public ProductUserId TargetUserId { set; }
	public ProductUserId LocalUserId { set; }

	// Methods

	// RVA: 0x44FB90 Offset: 0x44ED90 VA: 0x18044FB90
	public void set_TargetUserId(ProductUserId value) { }

	// RVA: 0x44FB30 Offset: 0x44ED30 VA: 0x18044FB30
	public void set_LocalUserId(ProductUserId value) { }

	// RVA: 0x44F970 Offset: 0x44EB70 VA: 0x18044F970 Slot: 4
	public void Set(ref QueryPlayerAchievementsOptions other) { }

	// RVA: 0x44FA30 Offset: 0x44EC30 VA: 0x18044FA30 Slot: 5
	public void Set(ref Nullable<QueryPlayerAchievementsOptions> other) { }

	// RVA: 0x44F910 Offset: 0x44EB10 VA: 0x18044F910 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Achievements
public struct StatThresholds // TypeDefIndex: 10336
{
	// Fields
	[CompilerGenerated]
	private Utf8String <Name>k__BackingField; // 0x0
	[CompilerGenerated]
	private int <Threshold>k__BackingField; // 0x8

	// Properties
	public Utf8String Name { get; set; }
	public int Threshold { get; set; }

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
	public int get_Threshold() { }

	[CompilerGenerated]
	// RVA: 0x3F5520 Offset: 0x3F4720 VA: 0x1803F5520
	public void set_Threshold(int value) { }

	// RVA: 0x451470 Offset: 0x450670 VA: 0x180451470
	internal void Set(ref StatThresholdsInternal other) { }
}

// Namespace: Epic.OnlineServices.Achievements
internal struct StatThresholdsInternal : IGettable<StatThresholds>, ISettable<StatThresholds>, IDisposable // TypeDefIndex: 10337
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_Name; // 0x8
	private int m_Threshold; // 0x10

	// Properties
	public Utf8String Name { get; set; }
	public int Threshold { get; set; }

	// Methods

	// RVA: 0x4513A0 Offset: 0x4505A0 VA: 0x1804513A0
	public Utf8String get_Name() { }

	// RVA: 0x451410 Offset: 0x450610 VA: 0x180451410
	public void set_Name(Utf8String value) { }

	// RVA: 0x3D8F90 Offset: 0x3D8190 VA: 0x1803D8F90
	public int get_Threshold() { }

	// RVA: 0x3F4800 Offset: 0x3F3A00 VA: 0x1803F4800
	public void set_Threshold(int value) { }

	// RVA: 0x451320 Offset: 0x450520 VA: 0x180451320 Slot: 5
	public void Set(ref StatThresholds other) { }

	// RVA: 0x451260 Offset: 0x450460 VA: 0x180451260 Slot: 6
	public void Set(ref Nullable<StatThresholds> other) { }

	// RVA: 0x4511F0 Offset: 0x4503F0 VA: 0x1804511F0 Slot: 7
	public void Dispose() { }

	// RVA: 0x451240 Offset: 0x450440 VA: 0x180451240 Slot: 4
	public void Get(out StatThresholds output) { }
}

// Namespace: Epic.OnlineServices.Achievements
public struct UnlockAchievementsOptions // TypeDefIndex: 10338
{
	// Fields
	[CompilerGenerated]
	private ProductUserId <UserId>k__BackingField; // 0x0
	[CompilerGenerated]
	private Utf8String[] <AchievementIds>k__BackingField; // 0x8

	// Properties
	public ProductUserId UserId { get; set; }
	public Utf8String[] AchievementIds { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public ProductUserId get_UserId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_UserId(ProductUserId value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x3D9010 Offset: 0x3D8210 VA: 0x1803D9010
	public Utf8String[] get_AchievementIds() { }

	[CompilerGenerated]
	// RVA: 0x3D9040 Offset: 0x3D8240 VA: 0x1803D9040
	public void set_AchievementIds(Utf8String[] value) { }
}

// Namespace: Epic.OnlineServices.Achievements
internal struct UnlockAchievementsOptionsInternal : ISettable<UnlockAchievementsOptions>, IDisposable // TypeDefIndex: 10339
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_UserId; // 0x8
	private IntPtr m_AchievementIds; // 0x10
	private uint m_AchievementsCount; // 0x18

	// Properties
	public ProductUserId UserId { set; }
	public Utf8String[] AchievementIds { set; }

	// Methods

	// RVA: 0x451730 Offset: 0x450930 VA: 0x180451730
	public void set_UserId(ProductUserId value) { }

	// RVA: 0x4516B0 Offset: 0x4508B0 VA: 0x1804516B0
	public void set_AchievementIds(Utf8String[] value) { }

	// RVA: 0x451630 Offset: 0x450830 VA: 0x180451630 Slot: 4
	public void Set(ref UnlockAchievementsOptions other) { }

	// RVA: 0x451560 Offset: 0x450760 VA: 0x180451560 Slot: 5
	public void Set(ref Nullable<UnlockAchievementsOptions> other) { }

	// RVA: 0x451500 Offset: 0x450700 VA: 0x180451500 Slot: 6
	public void Dispose() { }
}

// Namespace: Epic.OnlineServices.Achievements
public struct UnlockedAchievement // TypeDefIndex: 10340
{
	// Fields
	[CompilerGenerated]
	private Utf8String <AchievementId>k__BackingField; // 0x0
	[CompilerGenerated]
	private Nullable<DateTimeOffset> <UnlockTime>k__BackingField; // 0x8

	// Properties
	public Utf8String AchievementId { get; set; }
	public Nullable<DateTimeOffset> UnlockTime { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x3DA410 Offset: 0x3D9610 VA: 0x1803DA410
	public Utf8String get_AchievementId() { }

	[CompilerGenerated]
	// RVA: 0x3DA430 Offset: 0x3D9630 VA: 0x1803DA430
	public void set_AchievementId(Utf8String value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x4157B0 Offset: 0x4149B0 VA: 0x1804157B0
	public Nullable<DateTimeOffset> get_UnlockTime() { }

	[CompilerGenerated]
	// RVA: 0x415800 Offset: 0x414A00 VA: 0x180415800
	public void set_UnlockTime(Nullable<DateTimeOffset> value) { }

	// RVA: 0x451BB0 Offset: 0x450DB0 VA: 0x180451BB0
	internal void Set(ref UnlockedAchievementInternal other) { }
}

// Namespace: Epic.OnlineServices.Achievements
internal struct UnlockedAchievementInternal : IGettable<UnlockedAchievement>, ISettable<UnlockedAchievement>, IDisposable // TypeDefIndex: 10341
{
	// Fields
	private int m_ApiVersion; // 0x0
	private IntPtr m_AchievementId; // 0x8
	private long m_UnlockTime; // 0x10

	// Properties
	public Utf8String AchievementId { get; set; }
	public Nullable<DateTimeOffset> UnlockTime { get; set; }

	// Methods

	// RVA: 0x451A00 Offset: 0x450C00 VA: 0x180451A00
	public Utf8String get_AchievementId() { }

	// RVA: 0x451AE0 Offset: 0x450CE0 VA: 0x180451AE0
	public void set_AchievementId(Utf8String value) { }

	// RVA: 0x451A70 Offset: 0x450C70 VA: 0x180451A70
	public Nullable<DateTimeOffset> get_UnlockTime() { }

	// RVA: 0x451B40 Offset: 0x450D40 VA: 0x180451B40
	public void set_UnlockTime(Nullable<DateTimeOffset> value) { }

	// RVA: 0x451800 Offset: 0x450A00 VA: 0x180451800 Slot: 5
	public void Set(ref UnlockedAchievement other) { }

	// RVA: 0x4518E0 Offset: 0x450AE0 VA: 0x1804518E0 Slot: 6
	public void Set(ref Nullable<UnlockedAchievement> other) { }

	// RVA: 0x451790 Offset: 0x450990 VA: 0x180451790 Slot: 7
	public void Dispose() { }

	// RVA: 0x4517E0 Offset: 0x4509E0 VA: 0x1804517E0 Slot: 4
	public void Get(out UnlockedAchievement output) { }
}

// Namespace: 
[UnmanagedFunctionPointer(2)]
public sealed class ActivitiesManager.FFIMethods.UpdateMethod : MulticastDelegate // TypeDefIndex: 10342
{
	// Methods

	// RVA: 0x43FEE0 Offset: 0x43F0E0 VA: 0x18043FEE0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(IntPtr instance, ref Activity activity) { }

	// RVA: 0x451E80 Offset: 0x451080 VA: 0x180451E80 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr instance, ref Activity activity, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref Activity activity, IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(2)]
public sealed class ActivitiesManager.FFIMethods.ClearMethod : MulticastDelegate // TypeDefIndex: 10343
{
	// Methods

	// RVA: 0x438120 Offset: 0x437320 VA: 0x180438120
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(IntPtr instance) { }

	// RVA: 0x441F60 Offset: 0x441160 VA: 0x180441F60 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr instance, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(2)]
public sealed class ActivitiesManager.FFIMethods.GetMethod : MulticastDelegate // TypeDefIndex: 10344
{
	// Methods

	// RVA: 0x449D20 Offset: 0x448F20 VA: 0x180449D20
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x449CE0 Offset: 0x448EE0 VA: 0x180449CE0 Slot: 13
	public virtual Result Invoke(IntPtr instance, ref Activity activity) { }

	// RVA: 0x449B60 Offset: 0x448D60 VA: 0x180449B60 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr instance, ref Activity activity, AsyncCallback callback, object object) { }

	// RVA: 0x449CA0 Offset: 0x448EA0 VA: 0x180449CA0 Slot: 15
	public virtual Result EndInvoke(ref Activity activity, IAsyncResult result) { }
}

// Namespace: 
private struct ActivitiesManager.FFIMethods // TypeDefIndex: 10345
{
	// Fields
	public ActivitiesManager.FFIMethods.UpdateMethod Update; // 0x0
	public ActivitiesManager.FFIMethods.ClearMethod Clear; // 0x8
	public ActivitiesManager.FFIMethods.GetMethod Get; // 0x10
}

// Namespace: DiscordConnect
public class ActivitiesManager // TypeDefIndex: 10346
{
	// Fields
	private IntPtr MethodsPtr; // 0x10
	private object MethodsStructure; // 0x18

	// Properties
	private ActivitiesManager.FFIMethods Methods { get; }

	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	internal void .ctor(IntPtr ptr) { }

	// RVA: 0x43F690 Offset: 0x43E890 VA: 0x18043F690
	public Activity GetCurrent() { }

	// RVA: 0x43F9E0 Offset: 0x43EBE0 VA: 0x18043F9E0
	public void Update(Activity activity) { }

	// RVA: 0x43F650 Offset: 0x43E850 VA: 0x18043F650
	public void Clear() { }

	// RVA: 0x43F790 Offset: 0x43E990 VA: 0x18043F790
	public void Share(string message) { }

	// RVA: 0x43FA30 Offset: 0x43EC30 VA: 0x18043FA30
	private ActivitiesManager.FFIMethods get_Methods() { }
}

// Namespace: DiscordConnect
public class Constants // TypeDefIndex: 10347
{
	// Fields
	public const string DllName = "discord_connect_sdk";

	// Methods

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private struct Discord.DiscordCreateParams // TypeDefIndex: 10348
{
	// Fields
	public string AccessToken; // 0x0
	public IntPtr EventData; // 0x8
	public Discord.FFIMethods.EventCallback OnEvent; // 0x10
	public IntPtr ConnectData; // 0x18
	public Discord.FFIMethods.ConnectCallback OnConnect; // 0x20
}

// Namespace: 
public sealed class Discord.EventHandler : MulticastDelegate // TypeDefIndex: 10349
{
	// Methods

	// RVA: 0x448CF0 Offset: 0x447EF0 VA: 0x180448CF0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x448CC0 Offset: 0x447EC0 VA: 0x180448CC0 Slot: 13
	public virtual void Invoke(Event e) { }

	// RVA: 0x448C30 Offset: 0x447E30 VA: 0x180448C30 Slot: 14
	public virtual IAsyncResult BeginInvoke(Event e, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class Discord.ConnectHandler : MulticastDelegate // TypeDefIndex: 10350
{
	// Methods

	// RVA: 0x442220 Offset: 0x441420 VA: 0x180442220
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x4421F0 Offset: 0x4413F0 VA: 0x1804421F0 Slot: 13
	public virtual void Invoke(Result result, Discord discord) { }

	// RVA: 0x442160 Offset: 0x441360 VA: 0x180442160 Slot: 14
	public virtual IAsyncResult BeginInvoke(Result result, Discord discord, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
private class Discord.BoxedEventCallback // TypeDefIndex: 10351
{
	// Fields
	public Discord.EventHandler callback; // 0x10

	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	public void .ctor(Discord.EventHandler callback) { }
}

// Namespace: 
private class Discord.BoxedConnectCallback // TypeDefIndex: 10352
{
	// Fields
	public Discord.ConnectHandler callback; // 0x10

	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	public void .ctor(Discord.ConnectHandler callback) { }
}

// Namespace: 
[UnmanagedFunctionPointer(2)]
public sealed class Discord.FFIMethods.DestroyMethod : MulticastDelegate // TypeDefIndex: 10353
{
	// Methods

	// RVA: 0x438120 Offset: 0x437320 VA: 0x180438120
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(IntPtr instance) { }

	// RVA: 0x445D50 Offset: 0x444F50 VA: 0x180445D50 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr instance, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(2)]
public sealed class Discord.FFIMethods.GetUsersManagerMethod : MulticastDelegate // TypeDefIndex: 10354
{
	// Methods

	// RVA: 0x449560 Offset: 0x448760 VA: 0x180449560
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual IntPtr Invoke(IntPtr instance) { }

	// RVA: 0x44A310 Offset: 0x449510 VA: 0x18044A310 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr instance, AsyncCallback callback, object object) { }

	// RVA: 0x425AE0 Offset: 0x424CE0 VA: 0x180425AE0 Slot: 15
	public virtual IntPtr EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(2)]
public sealed class Discord.FFIMethods.GetRelationshipsManagerMethod : MulticastDelegate // TypeDefIndex: 10355
{
	// Methods

	// RVA: 0x449560 Offset: 0x448760 VA: 0x180449560
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual IntPtr Invoke(IntPtr instance) { }

	// RVA: 0x44A0E0 Offset: 0x4492E0 VA: 0x18044A0E0 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr instance, AsyncCallback callback, object object) { }

	// RVA: 0x425AE0 Offset: 0x424CE0 VA: 0x180425AE0 Slot: 15
	public virtual IntPtr EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(2)]
public sealed class Discord.FFIMethods.GetActivitiesManagerMethod : MulticastDelegate // TypeDefIndex: 10356
{
	// Methods

	// RVA: 0x449560 Offset: 0x448760 VA: 0x180449560
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual IntPtr Invoke(IntPtr instance) { }

	// RVA: 0x4494E0 Offset: 0x4486E0 VA: 0x1804494E0 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr instance, AsyncCallback callback, object object) { }

	// RVA: 0x425AE0 Offset: 0x424CE0 VA: 0x180425AE0 Slot: 15
	public virtual IntPtr EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(2)]
public sealed class Discord.FFIMethods.RouteMethod : MulticastDelegate // TypeDefIndex: 10357
{
	// Methods

	// RVA: 0x449D20 Offset: 0x448F20 VA: 0x180449D20
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x449CE0 Offset: 0x448EE0 VA: 0x180449CE0 Slot: 13
	public virtual Result Invoke(IntPtr instance, string url) { }

	// RVA: 0x450600 Offset: 0x44F800 VA: 0x180450600 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr instance, string url, AsyncCallback callback, object object) { }

	// RVA: 0x450690 Offset: 0x44F890 VA: 0x180450690 Slot: 15
	public virtual Result EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(2)]
public sealed class Discord.FFIMethods.EventCallback : MulticastDelegate // TypeDefIndex: 10358
{
	// Methods

	// RVA: 0x448B90 Offset: 0x447D90 VA: 0x180448B90
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x448B50 Offset: 0x447D50 VA: 0x180448B50 Slot: 13
	public virtual void Invoke(IntPtr instance, Event e) { }

	// RVA: 0x448AB0 Offset: 0x447CB0 VA: 0x180448AB0 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr instance, Event e, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(2)]
public sealed class Discord.FFIMethods.ConnectCallback : MulticastDelegate // TypeDefIndex: 10359
{
	// Methods

	// RVA: 0x4420C0 Offset: 0x4412C0 VA: 0x1804420C0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x442090 Offset: 0x441290 VA: 0x180442090 Slot: 13
	public virtual void Invoke(IntPtr instance, Result result, IntPtr discord) { }

	// RVA: 0x441FE0 Offset: 0x4411E0 VA: 0x180441FE0 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr instance, Result result, IntPtr discord, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
private struct Discord.FFIMethods // TypeDefIndex: 10360
{
	// Fields
	public Discord.FFIMethods.DestroyMethod Destroy; // 0x0
	public Discord.FFIMethods.GetUsersManagerMethod GetUsersManager; // 0x8
	public Discord.FFIMethods.GetRelationshipsManagerMethod GetRelationshipsManager; // 0x10
	public Discord.FFIMethods.GetActivitiesManagerMethod GetActivitiesManager; // 0x18
	public Discord.FFIMethods.RouteMethod Route; // 0x20
}

// Namespace: 
public sealed class Discord.ExchangeHandler : MulticastDelegate // TypeDefIndex: 10361
{
	// Methods

	// RVA: 0x4490F0 Offset: 0x4482F0 VA: 0x1804490F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x4490A0 Offset: 0x4482A0 VA: 0x1804490A0 Slot: 13
	public virtual void Invoke(Result result, ExchangeData exchangeData) { }

	// RVA: 0x448F40 Offset: 0x448140 VA: 0x180448F40 Slot: 14
	public virtual IAsyncResult BeginInvoke(Result result, ExchangeData exchangeData, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: DiscordConnect
public class Discord // TypeDefIndex: 10362
{
	// Fields
	public UsersManager UsersManager; // 0x10
	public RelationshipsManager RelationshipsManager; // 0x18
	public ActivitiesManager ActivitiesManager; // 0x20
	private IntPtr MethodsPtr; // 0x28
	private object MethodsStructure; // 0x30

	// Properties
	private Discord.FFIMethods Methods { get; }

	// Methods

	// RVA: 0x447BC0 Offset: 0x446DC0 VA: 0x180447BC0
	private void .ctor(IntPtr ptr) { }

	// RVA: 0x446890 Offset: 0x445A90 VA: 0x180446890 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x447590 Offset: 0x446790 VA: 0x180447590
	public void Route(string url) { }

	// RVA: 0x4460B0 Offset: 0x4452B0 VA: 0x1804460B0
	public static void Connect(string accessToken, Discord.EventHandler eventHandler, Discord.ConnectHandler connectHandler) { }

	// RVA: 0x447670 Offset: 0x446870 VA: 0x180447670
	public static void Route(Uri uri, Discord.EventHandler eventHandler) { }

	[MonoPInvokeCallback(typeof(Discord.FFIMethods.EventCallback))]
	// RVA: 0x446650 Offset: 0x445850 VA: 0x180446650
	private static void EventCallbackFFI(IntPtr ptr, Event e) { }

	[MonoPInvokeCallback(typeof(Discord.FFIMethods.EventCallback))]
	// RVA: 0x446760 Offset: 0x445960 VA: 0x180446760
	private static void EventCallbackThenFreeFFI(IntPtr ptr, Event e) { }

	[MonoPInvokeCallback(typeof(Discord.FFIMethods.ConnectCallback))]
	// RVA: 0x445DD0 Offset: 0x444FD0 VA: 0x180445DD0
	private static void ConnectCallbackFFI(IntPtr ptr, Result result, IntPtr discordPtr) { }

	// RVA: 0x4482A0 Offset: 0x4474A0 VA: 0x1804482A0
	private static extern IntPtr discord_connect_connect(ref Discord.DiscordCreateParams createParams) { }

	// RVA: 0x448430 Offset: 0x447630 VA: 0x180448430
	private static extern Result discord_route(string AccessToken, IntPtr EventData, Discord.FFIMethods.EventCallback OnEvent) { }

	// RVA: 0x448540 Offset: 0x447740 VA: 0x180448540
	private Discord.FFIMethods get_Methods() { }
}

// Namespace: DiscordConnect
internal class Utility // TypeDefIndex: 10363
{
	// Methods

	// RVA: -1 Offset: -1
	internal static IntPtr Retain<T>(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAA1A00 Offset: 0xAA0C00 VA: 0x180AA1A00
	|-Utility.Retain<object>
	|
	|-RVA: 0xAA1940 Offset: 0xAA0B40 VA: 0x180AA1940
	|-Utility.Retain<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x452160 Offset: 0x451360 VA: 0x180452160
	internal static void Release(IntPtr ptr) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: DiscordConnect
public class Logging // TypeDefIndex: 10364
{
	// Methods

	// RVA: 0x44B060 Offset: 0x44A260 VA: 0x18044B060
	private static extern void logging_init() { }

	// RVA: 0x44B060 Offset: 0x44A260 VA: 0x18044B060
	public static void Init() { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
[UnmanagedFunctionPointer(2)]
public sealed class LoginSession.FFIMethods.DestroyMethod : MulticastDelegate // TypeDefIndex: 10365
{
	// Methods

	// RVA: 0x438120 Offset: 0x437320 VA: 0x180438120
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(IntPtr instance) { }

	// RVA: 0x445C50 Offset: 0x444E50 VA: 0x180445C50 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr instance, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(2)]
public sealed class LoginSession.FFIMethods.GetAuthorizationUrlMethod : MulticastDelegate // TypeDefIndex: 10366
{
	// Methods

	// RVA: 0x43FEE0 Offset: 0x43F0E0 VA: 0x18043FEE0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(IntPtr instance, StringBuilder url) { }

	// RVA: 0x4497F0 Offset: 0x4489F0 VA: 0x1804497F0 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr instance, StringBuilder url, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
private struct LoginSession.FFIMethods // TypeDefIndex: 10367
{
	// Fields
	public LoginSession.FFIMethods.DestroyMethod Destroy; // 0x0
	public LoginSession.FFIMethods.GetAuthorizationUrlMethod GetAuthorizationUrl; // 0x8
}

// Namespace: DiscordConnect
public class LoginSession // TypeDefIndex: 10368
{
	// Fields
	private IntPtr MethodsPtr; // 0x10
	private object MethodsStructure; // 0x18

	// Properties
	private LoginSession.FFIMethods Methods { get; }

	// Methods

	// RVA: 0x44BB00 Offset: 0x44AD00 VA: 0x18044BB00
	public void .ctor(long clientId, string redirectURI, OAuth2Scopes[] scopes) { }

	// RVA: 0x44B8D0 Offset: 0x44AAD0 VA: 0x18044B8D0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x44B970 Offset: 0x44AB70 VA: 0x18044B970
	private string GetAuthorizationUrl() { }

	// RVA: 0x44BA20 Offset: 0x44AC20 VA: 0x18044BA20
	public void OpenAuthorizationUrl() { }

	// RVA: 0x44BD80 Offset: 0x44AF80 VA: 0x18044BD80
	private static extern IntPtr login_manager_new(long client_id, string redirect_uri, string scopes) { }

	// RVA: 0x44BC70 Offset: 0x44AE70 VA: 0x18044BC70
	private LoginSession.FFIMethods get_Methods() { }
}

// Namespace: 
private class LoginSessionRFC6749.BoxedExchangeCallback // TypeDefIndex: 10369
{
	// Fields
	public LoginSessionRFC6749.ExchangeHandler callback; // 0x10

	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	public void .ctor(LoginSessionRFC6749.ExchangeHandler callback) { }
}

// Namespace: 
[UnmanagedFunctionPointer(2)]
public sealed class LoginSessionRFC6749.FFIMethods.DestroyMethod : MulticastDelegate // TypeDefIndex: 10370
{
	// Methods

	// RVA: 0x438120 Offset: 0x437320 VA: 0x180438120
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(IntPtr instance) { }

	// RVA: 0x445CD0 Offset: 0x444ED0 VA: 0x180445CD0 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr instance, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(2)]
public sealed class LoginSessionRFC6749.FFIMethods.GetAuthorizationUrlMethod : MulticastDelegate // TypeDefIndex: 10371
{
	// Methods

	// RVA: 0x43FEE0 Offset: 0x43F0E0 VA: 0x18043FEE0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(IntPtr instance, StringBuilder url) { }

	// RVA: 0x449760 Offset: 0x448960 VA: 0x180449760 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr instance, StringBuilder url, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(2)]
public sealed class LoginSessionRFC6749.FFIMethods.ExchangeCallback : MulticastDelegate // TypeDefIndex: 10372
{
	// Methods

	// RVA: 0x448EA0 Offset: 0x4480A0 VA: 0x180448EA0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x448E50 Offset: 0x448050 VA: 0x180448E50 Slot: 13
	public virtual void Invoke(IntPtr instance, Result result, ExchangeData exchangeData) { }

	// RVA: 0x448D90 Offset: 0x447F90 VA: 0x180448D90 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr instance, Result result, ExchangeData exchangeData, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(2)]
public sealed class LoginSessionRFC6749.FFIMethods.ExchangeMethod : MulticastDelegate // TypeDefIndex: 10373
{
	// Methods

	// RVA: 0x449270 Offset: 0x448470 VA: 0x180449270
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x449250 Offset: 0x448450 VA: 0x180449250 Slot: 13
	public virtual void Invoke(IntPtr instance, string accessCode, string state, IntPtr callbackData, LoginSessionRFC6749.FFIMethods.ExchangeCallback callback) { }

	// RVA: 0x449190 Offset: 0x448390 VA: 0x180449190 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr instance, string accessCode, string state, IntPtr callbackData, LoginSessionRFC6749.FFIMethods.ExchangeCallback callback, AsyncCallback __callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
private struct LoginSessionRFC6749.FFIMethods // TypeDefIndex: 10374
{
	// Fields
	public LoginSessionRFC6749.FFIMethods.DestroyMethod Destroy; // 0x0
	public LoginSessionRFC6749.FFIMethods.GetAuthorizationUrlMethod GetAuthorizationUrl; // 0x8
	public LoginSessionRFC6749.FFIMethods.ExchangeMethod Exchange; // 0x10
}

// Namespace: 
public sealed class LoginSessionRFC6749.ExchangeHandler : MulticastDelegate // TypeDefIndex: 10375
{
	// Methods

	// RVA: 0x4490F0 Offset: 0x4482F0 VA: 0x1804490F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x4490A0 Offset: 0x4482A0 VA: 0x1804490A0 Slot: 13
	public virtual void Invoke(Result result, ExchangeData exchangeData) { }

	// RVA: 0x448FF0 Offset: 0x4481F0 VA: 0x180448FF0 Slot: 14
	public virtual IAsyncResult BeginInvoke(Result result, ExchangeData exchangeData, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: DiscordConnect
public class LoginSessionRFC6749 // TypeDefIndex: 10376
{
	// Fields
	private IntPtr MethodsPtr; // 0x10
	private object MethodsStructure; // 0x18

	// Properties
	private LoginSessionRFC6749.FFIMethods Methods { get; }

	// Methods

	// RVA: 0x44B5F0 Offset: 0x44A7F0 VA: 0x18044B5F0
	public void .ctor(long clientId, string redirectURI, OAuth2Scopes[] scopes) { }

	// RVA: 0x44B3B0 Offset: 0x44A5B0 VA: 0x18044B3B0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x44B460 Offset: 0x44A660 VA: 0x18044B460
	private string GetAuthorizationUrl() { }

	// RVA: 0x44B510 Offset: 0x44A710 VA: 0x18044B510
	public void OpenAuthorizationUrl() { }

	// RVA: 0x44B220 Offset: 0x44A420 VA: 0x18044B220
	public void Exchange(string accessCode, string state, LoginSessionRFC6749.ExchangeHandler callback) { }

	[MonoPInvokeCallback(typeof(LoginSessionRFC6749.FFIMethods.ExchangeCallback))]
	// RVA: 0x44B0D0 Offset: 0x44A2D0 VA: 0x18044B0D0
	private static void ExchangeCallbackFFI(IntPtr ptr, Result result, ExchangeData exchangeData) { }

	// RVA: 0x44B800 Offset: 0x44AA00 VA: 0x18044B800
	private static extern IntPtr login_manager_rfc6749_new(long client_id, string redirect_uri, string scopes) { }

	// RVA: 0x44B6F0 Offset: 0x44A8F0 VA: 0x18044B6F0
	private LoginSessionRFC6749.FFIMethods get_Methods() { }
}

// Namespace: DiscordConnect
internal class LoginUtils // TypeDefIndex: 10377
{
	// Methods

	// RVA: 0x44BE50 Offset: 0x44B050 VA: 0x18044BE50
	public static string GetScopesString(OAuth2Scopes[] scopes) { }

	// RVA: 0x44C100 Offset: 0x44B300 VA: 0x18044C100
	public static void OpenAuthorizationUrl(string url) { }

	// RVA: 0x3D62D0 Offset: 0x3D54D0 VA: 0x1803D62D0
	public void .ctor() { }
}

// Namespace: 
private class RelationshipsManager.BoxedGetCallback // TypeDefIndex: 10378
{
	// Fields
	public RelationshipsManager.GetHandler callback; // 0x10
	public RelationshipsManager self; // 0x18

	// Methods

	// RVA: 0x441CC0 Offset: 0x440EC0 VA: 0x180441CC0
	public void .ctor(RelationshipsManager.GetHandler callback, RelationshipsManager self) { }
}

// Namespace: 
public sealed class RelationshipsManager.GetHandler : MulticastDelegate // TypeDefIndex: 10379
{
	// Methods

	// RVA: 0x442220 Offset: 0x441420 VA: 0x180442220
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x4421F0 Offset: 0x4413F0 VA: 0x1804421F0 Slot: 13
	public virtual void Invoke(Result result, IEnumerable<Relationship> relationships) { }

	// RVA: 0x449A30 Offset: 0x448C30 VA: 0x180449A30 Slot: 14
	public virtual IAsyncResult BeginInvoke(Result result, IEnumerable<Relationship> relationships, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(2)]
public sealed class RelationshipsManager.FFIMethods.CountMethod : MulticastDelegate // TypeDefIndex: 10380
{
	// Methods

	// RVA: 0x43FEE0 Offset: 0x43F0E0 VA: 0x18043FEE0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(IntPtr instance, ref int count) { }

	// RVA: 0x4432A0 Offset: 0x4424A0 VA: 0x1804432A0 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr instance, ref int count, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref int count, IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(2)]
public sealed class RelationshipsManager.FFIMethods.GetMethod : MulticastDelegate // TypeDefIndex: 10381
{
	// Methods

	// RVA: 0x441EC0 Offset: 0x4410C0 VA: 0x180441EC0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x409CF0 Offset: 0x408EF0 VA: 0x180409CF0 Slot: 13
	public virtual void Invoke(IntPtr instance, IntPtr data, RelationshipsManager.FFIMethods.GetRelationshipsCallback callback) { }

	// RVA: 0x449C00 Offset: 0x448E00 VA: 0x180449C00 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr instance, IntPtr data, RelationshipsManager.FFIMethods.GetRelationshipsCallback callback, AsyncCallback __callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(2)]
public sealed class RelationshipsManager.FFIMethods.GetLatestMethod : MulticastDelegate // TypeDefIndex: 10382
{
	// Methods

	// RVA: 0x441EC0 Offset: 0x4410C0 VA: 0x180441EC0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x409CF0 Offset: 0x408EF0 VA: 0x180409CF0 Slot: 13
	public virtual void Invoke(IntPtr instance, IntPtr data, RelationshipsManager.FFIMethods.GetRelationshipsCallback callback) { }

	// RVA: 0x449AC0 Offset: 0x448CC0 VA: 0x180449AC0 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr instance, IntPtr data, RelationshipsManager.FFIMethods.GetRelationshipsCallback callback, AsyncCallback __callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(2)]
public sealed class RelationshipsManager.FFIMethods.GetAtMethod : MulticastDelegate // TypeDefIndex: 10383
{
	// Methods

	// RVA: 0x4496C0 Offset: 0x4488C0 VA: 0x1804496C0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x409CF0 Offset: 0x408EF0 VA: 0x180409CF0 Slot: 13
	public virtual void Invoke(IntPtr instance, uint index, ref Relationship relationship) { }

	// RVA: 0x449600 Offset: 0x448800 VA: 0x180449600 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr instance, uint index, ref Relationship relationship, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref Relationship relationship, IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(2)]
public sealed class RelationshipsManager.FFIMethods.GetRelationshipsCallback : MulticastDelegate // TypeDefIndex: 10384
{
	// Methods

	// RVA: 0x44A040 Offset: 0x449240 VA: 0x18044A040
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x44A010 Offset: 0x449210 VA: 0x18044A010 Slot: 13
	public virtual void Invoke(IntPtr data, Result result) { }

	// RVA: 0x449F70 Offset: 0x449170 VA: 0x180449F70 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr data, Result result, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
private struct RelationshipsManager.FFIMethods // TypeDefIndex: 10385
{
	// Fields
	public RelationshipsManager.FFIMethods.CountMethod Count; // 0x0
	public RelationshipsManager.FFIMethods.GetMethod Get; // 0x8
	public RelationshipsManager.FFIMethods.GetLatestMethod GetLatest; // 0x10
	public RelationshipsManager.FFIMethods.GetAtMethod GetAt; // 0x18
}

// Namespace: DiscordConnect
public class RelationshipsManager // TypeDefIndex: 10386
{
	// Fields
	private IntPtr MethodsPtr; // 0x10
	private object MethodsStructure; // 0x18

	// Properties
	private RelationshipsManager.FFIMethods Methods { get; }

	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	internal void .ctor(IntPtr ptr) { }

	// RVA: 0x44FD20 Offset: 0x44EF20 VA: 0x18044FD20
	private uint Count() { }

	// RVA: 0x4502E0 Offset: 0x44F4E0 VA: 0x1804502E0
	public void Get(RelationshipsManager.GetHandler handler) { }

	// RVA: 0x450160 Offset: 0x44F360 VA: 0x180450160
	public void GetLatest(RelationshipsManager.GetHandler handler) { }

	// RVA: 0x44FDB0 Offset: 0x44EFB0 VA: 0x18044FDB0
	private Relationship GetAt(uint index) { }

	[MonoPInvokeCallback(typeof(RelationshipsManager.FFIMethods.GetRelationshipsCallback))]
	// RVA: 0x44FE30 Offset: 0x44F030 VA: 0x18044FE30
	private static void GetCallbackFFI(IntPtr ptr, Result result) { }

	// RVA: 0x450460 Offset: 0x44F660 VA: 0x180450460
	private RelationshipsManager.FFIMethods get_Methods() { }
}

// Namespace: DiscordConnect
public struct ExchangeData // TypeDefIndex: 10387
{
	// Fields
	public string AccessToken; // 0x0
	public string Scope; // 0x8
	public string TokenType; // 0x10
	public long ExpiresIn; // 0x18
	public string RefreshToken; // 0x20
}

// Namespace: DiscordConnect
public struct User // TypeDefIndex: 10388
{
	// Fields
	public long Id; // 0x0
	public string Username; // 0x8
	public string Discriminator; // 0x10
	public string Avatar; // 0x18
	public bool bot; // 0x20
}

// Namespace: DiscordConnect
public enum RelationshipType // TypeDefIndex: 10389
{
	// Fields
	public int value__; // 0x0
	public const RelationshipType None = 0;
	public const RelationshipType Friend = 1;
	public const RelationshipType Blocked = 2;
	public const RelationshipType PendingIncoming = 3;
	public const RelationshipType PendingOutgoing = 4;
	public const RelationshipType Implicit = 5;
}

// Namespace: DiscordConnect
public struct Relationship // TypeDefIndex: 10390
{
	// Fields
	public RelationshipType Type; // 0x0
	public User User; // 0x8
}

// Namespace: DiscordConnect
public enum ActionType // TypeDefIndex: 10391
{
	// Fields
	public int value__; // 0x0
	public const ActionType Join = 1;
}

// Namespace: DiscordConnect
public struct Activity // TypeDefIndex: 10392
{
	// Fields
	public int Type; // 0x0
	public long ApplicationId; // 0x8
	public string SessionId; // 0x10
	public string Name; // 0x18
	public string Platform; // 0x20
	private string SupportedPlatformsString; // 0x28
	public string State; // 0x30
	public string Details; // 0x38
	public ActivityTimestamps Timestamps; // 0x40
	public ActivityAssets Assets; // 0x50
	public ActivityParty Party; // 0x70
	public ActivitySecrets Secrets; // 0x80

	// Properties
	public List<string> SupportedPlatforms { get; set; }

	// Methods

	// RVA: 0x441B60 Offset: 0x440D60 VA: 0x180441B60
	public List<string> get_SupportedPlatforms() { }

	// RVA: 0x441BC0 Offset: 0x440DC0 VA: 0x180441BC0
	public void set_SupportedPlatforms(List<string> value) { }
}

// Namespace: DiscordConnect
public struct ActivityTimestamps // TypeDefIndex: 10393
{
	// Fields
	public long Start; // 0x0
	public long End; // 0x8
}

// Namespace: DiscordConnect
public struct ActivityAssets // TypeDefIndex: 10394
{
	// Fields
	public string LargeImage; // 0x0
	public string LargeText; // 0x8
	public string SmallImage; // 0x10
	public string SmallText; // 0x18
}

// Namespace: DiscordConnect
public struct ActivityParty // TypeDefIndex: 10395
{
	// Fields
	public string Id; // 0x0
	public ActivityPartySize Size; // 0x8
}

// Namespace: DiscordConnect
public struct ActivityPartySize // TypeDefIndex: 10396
{
	// Fields
	public int Current; // 0x0
	public int Max; // 0x4
}

// Namespace: DiscordConnect
public struct ActivitySecrets // TypeDefIndex: 10397
{
	// Fields
	public string Join; // 0x0
	public string Spectate; // 0x8
}

// Namespace: DiscordConnect
public enum ResultType // TypeDefIndex: 10398
{
	// Fields
	public int value__; // 0x0
	public const ResultType Ok = 0;
	public const ResultType InternalError = 1;
	public const ResultType Unauthorized = 2;
	public const ResultType BadRequest = 3;
	public const ResultType JsonError = 4;
	public const ResultType RuntimeCreateFailed = 5;
	public const ResultType OAuth2StateMismatch = 6;
	public const ResultType EventSendFailed = 7;
	public const ResultType NotFound = 8;
	public const ResultType GenericApiError = 9;
	public const ResultType NetworkError = 10;
	public const ResultType UrlParseError = 11;
	public const ResultType MissingAction = 12;
	public const ResultType UnsupportedAction = 13;
	public const ResultType MissingSecret = 14;
	public const ResultType InvalidActionUrl = 15;
	public const ResultType ActivityUpdateCancelled = 16;
}

// Namespace: DiscordConnect
public struct Result // TypeDefIndex: 10399
{
	// Fields
	public ResultType type; // 0x0
	public string Description; // 0x8
}

// Namespace: DiscordConnect
public class ErrorException : Exception // TypeDefIndex: 10400
{
	// Fields
	public readonly Result result; // 0x90

	// Methods

	// RVA: 0x448A50 Offset: 0x447C50 VA: 0x180448A50
	public void .ctor(Result result) { }
}

// Namespace: DiscordConnect
public enum EventType // TypeDefIndex: 10401
{
	// Fields
	public int value__; // 0x0
	public const EventType Connected = 0;
	public const EventType ConenctFailed = 1;
	public const EventType ActivitySet = 2;
	public const EventType ActivityCleared = 3;
	public const EventType ActivitySetFailed = 4;
	public const EventType ActivityJoin = 5;
}

// Namespace: DiscordConnect
public struct ActivityJoinData // TypeDefIndex: 10402
{
	// Fields
	public string Secret; // 0x0
}

// Namespace: DiscordConnect
public struct EventData // TypeDefIndex: 10403
{
	// Fields
	public Result ActivitySetFailed; // 0x0
	public ActivityJoinData ActivityJoin; // 0x0
}

// Namespace: DiscordConnect
public struct Event // TypeDefIndex: 10404
{
	// Fields
	public EventType type; // 0x0
	public EventData data; // 0x8
}

// Namespace: DiscordConnect
public enum OAuth2Scopes // TypeDefIndex: 10405
{
	// Fields
	public int value__; // 0x0
	[Description("identify")]
	public const OAuth2Scopes Identify = 0;
	[Description("relationships.read")]
	public const OAuth2Scopes RelationshipsRead = 1;
	[Description("activities.write")]
	public const OAuth2Scopes ActivitiesWrite = 2;
}

// Namespace: DiscordConnect
[Extension]
public static class EnumDescriptionExtension // TypeDefIndex: 10406
{
	// Methods

	[Extension]
	// RVA: 0x4488F0 Offset: 0x447AF0 VA: 0x1804488F0
	public static string GetDescription(Enum value) { }
}

// Namespace: 
[UnmanagedFunctionPointer(2)]
public sealed class UsersManager.FFIMethods.GetCurrentMethod : MulticastDelegate // TypeDefIndex: 10407
{
	// Methods

	// RVA: 0x449990 Offset: 0x448B90 VA: 0x180449990
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x449950 Offset: 0x448B50 VA: 0x180449950 Slot: 13
	public virtual User Invoke(IntPtr instance) { }

	// RVA: 0x449880 Offset: 0x448A80 VA: 0x180449880 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr instance, AsyncCallback callback, object object) { }

	// RVA: 0x449900 Offset: 0x448B00 VA: 0x180449900 Slot: 15
	public virtual User EndInvoke(IAsyncResult result) { }
}

// Namespace: 
private struct UsersManager.FFIMethods // TypeDefIndex: 10408
{
	// Fields
	public UsersManager.FFIMethods.GetCurrentMethod GetCurrent; // 0x0
}

// Namespace: DiscordConnect
public class UsersManager // TypeDefIndex: 10409
{
	// Fields
	private IntPtr MethodsPtr; // 0x10
	private object MethodsStructure; // 0x18

	// Properties
	private UsersManager.FFIMethods Methods { get; }

	// Methods

	// RVA: 0x3F40F0 Offset: 0x3F32F0 VA: 0x1803F40F0
	internal void .ctor(IntPtr ptr) { }

	// RVA: 0x451F20 Offset: 0x451120 VA: 0x180451F20
	public User GetCurrent() { }

	// RVA: 0x452060 Offset: 0x451260 VA: 0x180452060
	private UsersManager.FFIMethods get_Methods() { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class ActivityManager.FFIEvents.ActivityJoinHandler : MulticastDelegate // TypeDefIndex: 10410
{
	// Methods

	// RVA: 0x43FEE0 Offset: 0x43F0E0 VA: 0x18043FEE0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(IntPtr ptr, string secret) { }

	// RVA: 0x43FE50 Offset: 0x43F050 VA: 0x18043FE50 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr ptr, string secret, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class ActivityManager.FFIEvents.ActivitySpectateHandler : MulticastDelegate // TypeDefIndex: 10411
{
	// Methods

	// RVA: 0x43FEE0 Offset: 0x43F0E0 VA: 0x18043FEE0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(IntPtr ptr, string secret) { }

	// RVA: 0x441AD0 Offset: 0x440CD0 VA: 0x180441AD0 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr ptr, string secret, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class ActivityManager.FFIEvents.ActivityJoinRequestHandler : MulticastDelegate // TypeDefIndex: 10412
{
	// Methods

	// RVA: 0x43FEE0 Offset: 0x43F0E0 VA: 0x18043FEE0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(IntPtr ptr, ref User user) { }

	// RVA: 0x43FF80 Offset: 0x43F180 VA: 0x18043FF80 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr ptr, ref User user, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref User user, IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class ActivityManager.FFIEvents.ActivityInviteHandler : MulticastDelegate // TypeDefIndex: 10413
{
	// Methods

	// RVA: 0x43FD10 Offset: 0x43EF10 VA: 0x18043FD10
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x43DDD0 Offset: 0x43CFD0 VA: 0x18043DDD0 Slot: 13
	public virtual void Invoke(IntPtr ptr, ActivityActionType type, ref User user, ref Activity activity) { }

	// RVA: 0x43FC00 Offset: 0x43EE00 VA: 0x18043FC00 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr ptr, ActivityActionType type, ref User user, ref Activity activity, AsyncCallback callback, object object) { }

	// RVA: 0x43FCF0 Offset: 0x43EEF0 VA: 0x18043FCF0 Slot: 15
	public virtual void EndInvoke(ref User user, ref Activity activity, IAsyncResult result) { }
}

// Namespace: 
internal struct ActivityManager.FFIEvents // TypeDefIndex: 10414
{
	// Fields
	internal ActivityManager.FFIEvents.ActivityJoinHandler OnActivityJoin; // 0x0
	internal ActivityManager.FFIEvents.ActivitySpectateHandler OnActivitySpectate; // 0x8
	internal ActivityManager.FFIEvents.ActivityJoinRequestHandler OnActivityJoinRequest; // 0x10
	internal ActivityManager.FFIEvents.ActivityInviteHandler OnActivityInvite; // 0x18
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class ActivityManager.FFIMethods.RegisterCommandMethod : MulticastDelegate // TypeDefIndex: 10415
{
	// Methods

	// RVA: 0x445BB0 Offset: 0x444DB0 VA: 0x180445BB0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual Result Invoke(IntPtr methodsPtr, string command) { }

	// RVA: 0x44FBF0 Offset: 0x44EDF0 VA: 0x18044FBF0 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, string command, AsyncCallback callback, object object) { }

	// RVA: 0x409CC0 Offset: 0x408EC0 VA: 0x180409CC0 Slot: 15
	public virtual Result EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class ActivityManager.FFIMethods.RegisterSteamMethod : MulticastDelegate // TypeDefIndex: 10416
{
	// Methods

	// RVA: 0x448850 Offset: 0x447A50 VA: 0x180448850
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual Result Invoke(IntPtr methodsPtr, uint steamId) { }

	// RVA: 0x44FC80 Offset: 0x44EE80 VA: 0x18044FC80 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, uint steamId, AsyncCallback callback, object object) { }

	// RVA: 0x409CC0 Offset: 0x408EC0 VA: 0x180409CC0 Slot: 15
	public virtual Result EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class ActivityManager.FFIMethods.UpdateActivityCallback : MulticastDelegate // TypeDefIndex: 10417
{
	// Methods

	// RVA: 0x43DB50 Offset: 0x43CD50 VA: 0x18043DB50
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(IntPtr ptr, Result result) { }

	// RVA: 0x451CA0 Offset: 0x450EA0 VA: 0x180451CA0 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr ptr, Result result, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class ActivityManager.FFIMethods.UpdateActivityMethod : MulticastDelegate // TypeDefIndex: 10418
{
	// Methods

	// RVA: 0x43DDF0 Offset: 0x43CFF0 VA: 0x18043DDF0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x43DDD0 Offset: 0x43CFD0 VA: 0x18043DDD0 Slot: 13
	public virtual void Invoke(IntPtr methodsPtr, ref Activity activity, IntPtr callbackData, ActivityManager.FFIMethods.UpdateActivityCallback callback) { }

	// RVA: 0x451DC0 Offset: 0x450FC0 VA: 0x180451DC0 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, ref Activity activity, IntPtr callbackData, ActivityManager.FFIMethods.UpdateActivityCallback callback, AsyncCallback __callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref Activity activity, IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class ActivityManager.FFIMethods.ClearActivityCallback : MulticastDelegate // TypeDefIndex: 10419
{
	// Methods

	// RVA: 0x43DB50 Offset: 0x43CD50 VA: 0x18043DB50
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(IntPtr ptr, Result result) { }

	// RVA: 0x441D00 Offset: 0x440F00 VA: 0x180441D00 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr ptr, Result result, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class ActivityManager.FFIMethods.ClearActivityMethod : MulticastDelegate // TypeDefIndex: 10420
{
	// Methods

	// RVA: 0x441EC0 Offset: 0x4410C0 VA: 0x180441EC0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x409CF0 Offset: 0x408EF0 VA: 0x180409CF0 Slot: 13
	public virtual void Invoke(IntPtr methodsPtr, IntPtr callbackData, ActivityManager.FFIMethods.ClearActivityCallback callback) { }

	// RVA: 0x441E20 Offset: 0x441020 VA: 0x180441E20 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, IntPtr callbackData, ActivityManager.FFIMethods.ClearActivityCallback callback, AsyncCallback __callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class ActivityManager.FFIMethods.SendRequestReplyCallback : MulticastDelegate // TypeDefIndex: 10421
{
	// Methods

	// RVA: 0x43DB50 Offset: 0x43CD50 VA: 0x18043DB50
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(IntPtr ptr, Result result) { }

	// RVA: 0x4509B0 Offset: 0x44FBB0 VA: 0x1804509B0 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr ptr, Result result, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class ActivityManager.FFIMethods.SendRequestReplyMethod : MulticastDelegate // TypeDefIndex: 10422
{
	// Methods

	// RVA: 0x450BB0 Offset: 0x44FDB0 VA: 0x180450BB0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x449250 Offset: 0x448450 VA: 0x180449250 Slot: 13
	public virtual void Invoke(IntPtr methodsPtr, long userId, ActivityJoinRequestReply reply, IntPtr callbackData, ActivityManager.FFIMethods.SendRequestReplyCallback callback) { }

	// RVA: 0x450AD0 Offset: 0x44FCD0 VA: 0x180450AD0 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, long userId, ActivityJoinRequestReply reply, IntPtr callbackData, ActivityManager.FFIMethods.SendRequestReplyCallback callback, AsyncCallback __callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class ActivityManager.FFIMethods.SendInviteCallback : MulticastDelegate // TypeDefIndex: 10423
{
	// Methods

	// RVA: 0x43DB50 Offset: 0x43CD50 VA: 0x18043DB50
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(IntPtr ptr, Result result) { }

	// RVA: 0x4506D0 Offset: 0x44F8D0 VA: 0x1804506D0 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr ptr, Result result, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class ActivityManager.FFIMethods.SendInviteMethod : MulticastDelegate // TypeDefIndex: 10424
{
	// Methods

	// RVA: 0x450910 Offset: 0x44FB10 VA: 0x180450910
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x4508F0 Offset: 0x44FAF0 VA: 0x1804508F0 Slot: 13
	public virtual void Invoke(IntPtr methodsPtr, long userId, ActivityActionType type, string content, IntPtr callbackData, ActivityManager.FFIMethods.SendInviteCallback callback) { }

	// RVA: 0x4507F0 Offset: 0x44F9F0 VA: 0x1804507F0 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, long userId, ActivityActionType type, string content, IntPtr callbackData, ActivityManager.FFIMethods.SendInviteCallback callback, AsyncCallback __callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class ActivityManager.FFIMethods.AcceptInviteCallback : MulticastDelegate // TypeDefIndex: 10425
{
	// Methods

	// RVA: 0x43DB50 Offset: 0x43CD50 VA: 0x18043DB50
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(IntPtr ptr, Result result) { }

	// RVA: 0x43DAB0 Offset: 0x43CCB0 VA: 0x18043DAB0 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr ptr, Result result, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class ActivityManager.FFIMethods.AcceptInviteMethod : MulticastDelegate // TypeDefIndex: 10426
{
	// Methods

	// RVA: 0x43DDF0 Offset: 0x43CFF0 VA: 0x18043DDF0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x43DDD0 Offset: 0x43CFD0 VA: 0x18043DDD0 Slot: 13
	public virtual void Invoke(IntPtr methodsPtr, long userId, IntPtr callbackData, ActivityManager.FFIMethods.AcceptInviteCallback callback) { }

	// RVA: 0x43DD10 Offset: 0x43CF10 VA: 0x18043DD10 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, long userId, IntPtr callbackData, ActivityManager.FFIMethods.AcceptInviteCallback callback, AsyncCallback __callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
internal struct ActivityManager.FFIMethods // TypeDefIndex: 10427
{
	// Fields
	internal ActivityManager.FFIMethods.RegisterCommandMethod RegisterCommand; // 0x0
	internal ActivityManager.FFIMethods.RegisterSteamMethod RegisterSteam; // 0x8
	internal ActivityManager.FFIMethods.UpdateActivityMethod UpdateActivity; // 0x10
	internal ActivityManager.FFIMethods.ClearActivityMethod ClearActivity; // 0x18
	internal ActivityManager.FFIMethods.SendRequestReplyMethod SendRequestReply; // 0x20
	internal ActivityManager.FFIMethods.SendInviteMethod SendInvite; // 0x28
	internal ActivityManager.FFIMethods.AcceptInviteMethod AcceptInvite; // 0x30
}

// Namespace: 
public sealed class ActivityManager.UpdateActivityHandler : MulticastDelegate // TypeDefIndex: 10428
{
	// Methods

	// RVA: 0x43DC70 Offset: 0x43CE70 VA: 0x18043DC70
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(Result result) { }

	// RVA: 0x451D40 Offset: 0x450F40 VA: 0x180451D40 Slot: 14
	public virtual IAsyncResult BeginInvoke(Result result, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class ActivityManager.ClearActivityHandler : MulticastDelegate // TypeDefIndex: 10429
{
	// Methods

	// RVA: 0x43DC70 Offset: 0x43CE70 VA: 0x18043DC70
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(Result result) { }

	// RVA: 0x441DA0 Offset: 0x440FA0 VA: 0x180441DA0 Slot: 14
	public virtual IAsyncResult BeginInvoke(Result result, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class ActivityManager.SendRequestReplyHandler : MulticastDelegate // TypeDefIndex: 10430
{
	// Methods

	// RVA: 0x43DC70 Offset: 0x43CE70 VA: 0x18043DC70
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(Result result) { }

	// RVA: 0x450A50 Offset: 0x44FC50 VA: 0x180450A50 Slot: 14
	public virtual IAsyncResult BeginInvoke(Result result, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class ActivityManager.SendInviteHandler : MulticastDelegate // TypeDefIndex: 10431
{
	// Methods

	// RVA: 0x43DC70 Offset: 0x43CE70 VA: 0x18043DC70
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(Result result) { }

	// RVA: 0x450770 Offset: 0x44F970 VA: 0x180450770 Slot: 14
	public virtual IAsyncResult BeginInvoke(Result result, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class ActivityManager.AcceptInviteHandler : MulticastDelegate // TypeDefIndex: 10432
{
	// Methods

	// RVA: 0x43DC70 Offset: 0x43CE70 VA: 0x18043DC70
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(Result result) { }

	// RVA: 0x43DBF0 Offset: 0x43CDF0 VA: 0x18043DBF0 Slot: 14
	public virtual IAsyncResult BeginInvoke(Result result, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class ActivityManager.ActivityJoinHandler : MulticastDelegate // TypeDefIndex: 10433
{
	// Methods

	// RVA: 0x4047F0 Offset: 0x4039F0 VA: 0x1804047F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(string secret) { }

	// RVA: 0x3FD210 Offset: 0x3FC410 VA: 0x1803FD210 Slot: 14
	public virtual IAsyncResult BeginInvoke(string secret, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class ActivityManager.ActivitySpectateHandler : MulticastDelegate // TypeDefIndex: 10434
{
	// Methods

	// RVA: 0x4047F0 Offset: 0x4039F0 VA: 0x1804047F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(string secret) { }

	// RVA: 0x3FD210 Offset: 0x3FC410 VA: 0x1803FD210 Slot: 14
	public virtual IAsyncResult BeginInvoke(string secret, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class ActivityManager.ActivityJoinRequestHandler : MulticastDelegate // TypeDefIndex: 10435
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref User user) { }

	// RVA: 0x440020 Offset: 0x43F220 VA: 0x180440020 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref User user, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref User user, IAsyncResult result) { }
}

// Namespace: 
public sealed class ActivityManager.ActivityInviteHandler : MulticastDelegate // TypeDefIndex: 10436
{
	// Methods

	// RVA: 0x43FDB0 Offset: 0x43EFB0 VA: 0x18043FDB0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x409CF0 Offset: 0x408EF0 VA: 0x180409CF0 Slot: 13
	public virtual void Invoke(ActivityActionType type, ref User user, ref Activity activity) { }

	// RVA: 0x43FB40 Offset: 0x43ED40 VA: 0x18043FB40 Slot: 14
	public virtual IAsyncResult BeginInvoke(ActivityActionType type, ref User user, ref Activity activity, AsyncCallback callback, object object) { }

	// RVA: 0x43FCF0 Offset: 0x43EEF0 VA: 0x18043FCF0 Slot: 15
	public virtual void EndInvoke(ref User user, ref Activity activity, IAsyncResult result) { }
}

// Namespace: Discord
public class ActivityManager // TypeDefIndex: 10437
{
	// Fields
	private IntPtr MethodsPtr; // 0x10
	private object MethodsStructure; // 0x18
	[CompilerGenerated]
	private ActivityManager.ActivityJoinHandler OnActivityJoin; // 0x20
	[CompilerGenerated]
	private ActivityManager.ActivitySpectateHandler OnActivitySpectate; // 0x28
	[CompilerGenerated]
	private ActivityManager.ActivityJoinRequestHandler OnActivityJoinRequest; // 0x30
	[CompilerGenerated]
	private ActivityManager.ActivityInviteHandler OnActivityInvite; // 0x38

	// Properties
	private ActivityManager.FFIMethods Methods { get; }

	// Methods

	// RVA: 0x440B80 Offset: 0x43FD80 VA: 0x180440B80
	public void RegisterCommand() { }

	// RVA: 0x441730 Offset: 0x440930 VA: 0x180441730
	private ActivityManager.FFIMethods get_Methods() { }

	[CompilerGenerated]
	// RVA: 0x4415F0 Offset: 0x4407F0 VA: 0x1804415F0
	public void add_OnActivityJoin(ActivityManager.ActivityJoinHandler value) { }

	[CompilerGenerated]
	// RVA: 0x441990 Offset: 0x440B90 VA: 0x180441990
	public void remove_OnActivityJoin(ActivityManager.ActivityJoinHandler value) { }

	[CompilerGenerated]
	// RVA: 0x441690 Offset: 0x440890 VA: 0x180441690
	public void add_OnActivitySpectate(ActivityManager.ActivitySpectateHandler value) { }

	[CompilerGenerated]
	// RVA: 0x441A30 Offset: 0x440C30 VA: 0x180441A30
	public void remove_OnActivitySpectate(ActivityManager.ActivitySpectateHandler value) { }

	[CompilerGenerated]
	// RVA: 0x441550 Offset: 0x440750 VA: 0x180441550
	public void add_OnActivityJoinRequest(ActivityManager.ActivityJoinRequestHandler value) { }

	[CompilerGenerated]
	// RVA: 0x4418F0 Offset: 0x440AF0 VA: 0x1804418F0
	public void remove_OnActivityJoinRequest(ActivityManager.ActivityJoinRequestHandler value) { }

	[CompilerGenerated]
	// RVA: 0x4414B0 Offset: 0x4406B0 VA: 0x1804414B0
	public void add_OnActivityInvite(ActivityManager.ActivityInviteHandler value) { }

	[CompilerGenerated]
	// RVA: 0x441850 Offset: 0x440A50 VA: 0x180441850
	public void remove_OnActivityInvite(ActivityManager.ActivityInviteHandler value) { }

	// RVA: 0x4413B0 Offset: 0x4405B0 VA: 0x1804413B0
	internal void .ctor(IntPtr ptr, IntPtr eventsPtr, ref ActivityManager.FFIEvents events) { }

	// RVA: 0x4404C0 Offset: 0x43F6C0 VA: 0x1804404C0
	private void InitEvents(IntPtr eventsPtr, ref ActivityManager.FFIEvents events) { }

	// RVA: 0x440C20 Offset: 0x43FE20 VA: 0x180440C20
	public void RegisterCommand(string command) { }

	// RVA: 0x440CC0 Offset: 0x43FEC0 VA: 0x180440CC0
	public void RegisterSteam(uint steamId) { }

	[MonoPInvokeCallback]
	// RVA: 0x4411A0 Offset: 0x4403A0 VA: 0x1804411A0
	private static void UpdateActivityCallbackImpl(IntPtr ptr, Result result) { }

	// RVA: 0x441250 Offset: 0x440450 VA: 0x180441250
	public void UpdateActivity(Activity activity, ActivityManager.UpdateActivityHandler callback) { }

	[MonoPInvokeCallback]
	// RVA: 0x4402C0 Offset: 0x43F4C0 VA: 0x1804402C0
	private static void ClearActivityCallbackImpl(IntPtr ptr, Result result) { }

	// RVA: 0x440370 Offset: 0x43F570 VA: 0x180440370
	public void ClearActivity(ActivityManager.ClearActivityHandler callback) { }

	[MonoPInvokeCallback]
	// RVA: 0x440F90 Offset: 0x440190 VA: 0x180440F90
	private static void SendRequestReplyCallbackImpl(IntPtr ptr, Result result) { }

	// RVA: 0x441040 Offset: 0x440240 VA: 0x180441040
	public void SendRequestReply(long userId, ActivityJoinRequestReply reply, ActivityManager.SendRequestReplyHandler callback) { }

	[MonoPInvokeCallback]
	// RVA: 0x440D60 Offset: 0x43FF60 VA: 0x180440D60
	private static void SendInviteCallbackImpl(IntPtr ptr, Result result) { }

	// RVA: 0x440E10 Offset: 0x440010 VA: 0x180440E10
	public void SendInvite(long userId, ActivityActionType type, string content, ActivityManager.SendInviteHandler callback) { }

	[MonoPInvokeCallback]
	// RVA: 0x4400B0 Offset: 0x43F2B0 VA: 0x1804400B0
	private static void AcceptInviteCallbackImpl(IntPtr ptr, Result result) { }

	// RVA: 0x440160 Offset: 0x43F360 VA: 0x180440160
	public void AcceptInvite(long userId, ActivityManager.AcceptInviteHandler callback) { }

	[MonoPInvokeCallback]
	// RVA: 0x4408E0 Offset: 0x43FAE0 VA: 0x1804408E0
	private static void OnActivityJoinImpl(IntPtr ptr, string secret) { }

	[MonoPInvokeCallback]
	// RVA: 0x440AA0 Offset: 0x43FCA0 VA: 0x180440AA0
	private static void OnActivitySpectateImpl(IntPtr ptr, string secret) { }

	[MonoPInvokeCallback]
	// RVA: 0x4409C0 Offset: 0x43FBC0 VA: 0x1804409C0
	private static void OnActivityJoinRequestImpl(IntPtr ptr, ref User user) { }

	[MonoPInvokeCallback]
	// RVA: 0x4407E0 Offset: 0x43F9E0 VA: 0x1804407E0
	private static void OnActivityInviteImpl(IntPtr ptr, ActivityActionType type, ref User user, ref Activity activity) { }
}

// Namespace: Discord
internal static class Constants // TypeDefIndex: 10438
{
	// Fields
	public const string DllName = "discord_game_sdk";
}

// Namespace: Discord
public enum Result // TypeDefIndex: 10439
{
	// Fields
	public int value__; // 0x0
	public const Result Ok = 0;
	public const Result ServiceUnavailable = 1;
	public const Result InvalidVersion = 2;
	public const Result LockFailed = 3;
	public const Result InternalError = 4;
	public const Result InvalidPayload = 5;
	public const Result InvalidCommand = 6;
	public const Result InvalidPermissions = 7;
	public const Result NotFetched = 8;
	public const Result NotFound = 9;
	public const Result Conflict = 10;
	public const Result InvalidSecret = 11;
	public const Result InvalidJoinSecret = 12;
	public const Result NoEligibleActivity = 13;
	public const Result InvalidInvite = 14;
	public const Result NotAuthenticated = 15;
	public const Result InvalidAccessToken = 16;
	public const Result ApplicationMismatch = 17;
	public const Result InvalidDataUrl = 18;
	public const Result InvalidBase64 = 19;
	public const Result NotFiltered = 20;
	public const Result LobbyFull = 21;
	public const Result InvalidLobbySecret = 22;
	public const Result InvalidFilename = 23;
	public const Result InvalidFileSize = 24;
	public const Result InvalidEntitlement = 25;
	public const Result NotInstalled = 26;
	public const Result NotRunning = 27;
	public const Result InsufficientBuffer = 28;
	public const Result PurchaseCanceled = 29;
	public const Result InvalidGuild = 30;
	public const Result InvalidEvent = 31;
	public const Result InvalidChannel = 32;
	public const Result InvalidOrigin = 33;
	public const Result RateLimited = 34;
	public const Result OAuth2Error = 35;
	public const Result SelectChannelTimeout = 36;
	public const Result GetGuildTimeout = 37;
	public const Result SelectVoiceForceRequired = 38;
	public const Result CaptureShortcutAlreadyListening = 39;
	public const Result UnauthorizedForAchievement = 40;
	public const Result InvalidGiftCode = 41;
	public const Result PurchaseError = 42;
	public const Result TransactionAborted = 43;
	public const Result DrawingInitFailed = 44;
}

// Namespace: Discord
public enum CreateFlags // TypeDefIndex: 10440
{
	// Fields
	public int value__; // 0x0
	public const CreateFlags Default = 0;
	public const CreateFlags NoRequireDiscord = 1;
}

// Namespace: Discord
public enum LogLevel // TypeDefIndex: 10441
{
	// Fields
	public int value__; // 0x0
	public const LogLevel Error = 1;
	public const LogLevel Warn = 2;
	public const LogLevel Info = 3;
	public const LogLevel Debug = 4;
}

// Namespace: Discord
public enum UserFlag // TypeDefIndex: 10442
{
	// Fields
	public int value__; // 0x0
	public const UserFlag Partner = 2;
	public const UserFlag HypeSquadEvents = 4;
	public const UserFlag HypeSquadHouse1 = 64;
	public const UserFlag HypeSquadHouse2 = 128;
	public const UserFlag HypeSquadHouse3 = 256;
}

// Namespace: Discord
public enum PremiumType // TypeDefIndex: 10443
{
	// Fields
	public int value__; // 0x0
	public const PremiumType None = 0;
	public const PremiumType Tier1 = 1;
	public const PremiumType Tier2 = 2;
}

// Namespace: Discord
public enum ImageType // TypeDefIndex: 10444
{
	// Fields
	public int value__; // 0x0
	public const ImageType User = 0;
}

// Namespace: Discord
public enum ActivityPartyPrivacy // TypeDefIndex: 10445
{
	// Fields
	public int value__; // 0x0
	public const ActivityPartyPrivacy Private = 0;
	public const ActivityPartyPrivacy Public = 1;
}

// Namespace: Discord
public enum ActivityType // TypeDefIndex: 10446
{
	// Fields
	public int value__; // 0x0
	public const ActivityType Playing = 0;
	public const ActivityType Streaming = 1;
	public const ActivityType Listening = 2;
	public const ActivityType Watching = 3;
}

// Namespace: Discord
public enum ActivityActionType // TypeDefIndex: 10447
{
	// Fields
	public int value__; // 0x0
	public const ActivityActionType Join = 1;
	public const ActivityActionType Spectate = 2;
}

// Namespace: Discord
public enum ActivitySupportedPlatformFlags // TypeDefIndex: 10448
{
	// Fields
	public int value__; // 0x0
	public const ActivitySupportedPlatformFlags Desktop = 1;
	public const ActivitySupportedPlatformFlags Android = 2;
	public const ActivitySupportedPlatformFlags iOS = 4;
}

// Namespace: Discord
public enum ActivityJoinRequestReply // TypeDefIndex: 10449
{
	// Fields
	public int value__; // 0x0
	public const ActivityJoinRequestReply No = 0;
	public const ActivityJoinRequestReply Yes = 1;
	public const ActivityJoinRequestReply Ignore = 2;
}

// Namespace: Discord
public enum Status // TypeDefIndex: 10450
{
	// Fields
	public int value__; // 0x0
	public const Status Offline = 0;
	public const Status Online = 1;
	public const Status Idle = 2;
	public const Status DoNotDisturb = 3;
}

// Namespace: Discord
public enum RelationshipType // TypeDefIndex: 10451
{
	// Fields
	public int value__; // 0x0
	public const RelationshipType None = 0;
	public const RelationshipType Friend = 1;
	public const RelationshipType Blocked = 2;
	public const RelationshipType PendingIncoming = 3;
	public const RelationshipType PendingOutgoing = 4;
	public const RelationshipType Implicit = 5;
}

// Namespace: Discord
public enum LobbyType // TypeDefIndex: 10452
{
	// Fields
	public int value__; // 0x0
	public const LobbyType Private = 1;
	public const LobbyType Public = 2;
}

// Namespace: Discord
public enum LobbySearchComparison // TypeDefIndex: 10453
{
	// Fields
	public int value__; // 0x0
	public const LobbySearchComparison LessThanOrEqual = -2;
	public const LobbySearchComparison LessThan = -1;
	public const LobbySearchComparison Equal = 0;
	public const LobbySearchComparison GreaterThan = 1;
	public const LobbySearchComparison GreaterThanOrEqual = 2;
	public const LobbySearchComparison NotEqual = 3;
}

// Namespace: Discord
public enum LobbySearchCast // TypeDefIndex: 10454
{
	// Fields
	public int value__; // 0x0
	public const LobbySearchCast String = 1;
	public const LobbySearchCast Number = 2;
}

// Namespace: Discord
public enum LobbySearchDistance // TypeDefIndex: 10455
{
	// Fields
	public int value__; // 0x0
	public const LobbySearchDistance Local = 0;
	public const LobbySearchDistance Default = 1;
	public const LobbySearchDistance Extended = 2;
	public const LobbySearchDistance Global = 3;
}

// Namespace: Discord
public enum KeyVariant // TypeDefIndex: 10456
{
	// Fields
	public int value__; // 0x0
	public const KeyVariant Normal = 0;
	public const KeyVariant Right = 1;
	public const KeyVariant Left = 2;
}

// Namespace: Discord
public enum MouseButton // TypeDefIndex: 10457
{
	// Fields
	public int value__; // 0x0
	public const MouseButton Left = 0;
	public const MouseButton Middle = 1;
	public const MouseButton Right = 2;
}

// Namespace: Discord
public enum EntitlementType // TypeDefIndex: 10458
{
	// Fields
	public int value__; // 0x0
	public const EntitlementType Purchase = 1;
	public const EntitlementType PremiumSubscription = 2;
	public const EntitlementType DeveloperGift = 3;
	public const EntitlementType TestModePurchase = 4;
	public const EntitlementType FreePurchase = 5;
	public const EntitlementType UserGift = 6;
	public const EntitlementType PremiumPurchase = 7;
}

// Namespace: Discord
public enum SkuType // TypeDefIndex: 10459
{
	// Fields
	public int value__; // 0x0
	public const SkuType Application = 1;
	public const SkuType DLC = 2;
	public const SkuType Consumable = 3;
	public const SkuType Bundle = 4;
}

// Namespace: Discord
public enum InputModeType // TypeDefIndex: 10460
{
	// Fields
	public int value__; // 0x0
	public const InputModeType VoiceActivity = 0;
	public const InputModeType PushToTalk = 1;
}

// Namespace: Discord
public struct User // TypeDefIndex: 10461
{
	// Fields
	public long Id; // 0x0
	public string Username; // 0x8
	public string Discriminator; // 0x10
	public string Avatar; // 0x18
	public bool Bot; // 0x20
}

// Namespace: Discord
public struct OAuth2Token // TypeDefIndex: 10462
{
	// Fields
	public string AccessToken; // 0x0
	public string Scopes; // 0x8
	public long Expires; // 0x10
}

// Namespace: Discord
public struct ImageHandle // TypeDefIndex: 10463
{
	// Fields
	public ImageType Type; // 0x0
	public long Id; // 0x8
	public uint Size; // 0x10

	// Methods

	// RVA: 0x44A3B0 Offset: 0x4495B0 VA: 0x18044A3B0
	public static ImageHandle User(long id) { }

	// RVA: 0x44A390 Offset: 0x449590 VA: 0x18044A390
	public static ImageHandle User(long id, uint size) { }
}

// Namespace: Discord
public struct ImageDimensions // TypeDefIndex: 10464
{
	// Fields
	public uint Width; // 0x0
	public uint Height; // 0x4
}

// Namespace: Discord
public struct ActivityTimestamps // TypeDefIndex: 10465
{
	// Fields
	public long Start; // 0x0
	public long End; // 0x8
}

// Namespace: Discord
public struct ActivityAssets // TypeDefIndex: 10466
{
	// Fields
	public string LargeImage; // 0x0
	public string LargeText; // 0x8
	public string SmallImage; // 0x10
	public string SmallText; // 0x18
}

// Namespace: Discord
public struct PartySize // TypeDefIndex: 10467
{
	// Fields
	public int CurrentSize; // 0x0
	public int MaxSize; // 0x4
}

// Namespace: Discord
public struct ActivityParty // TypeDefIndex: 10468
{
	// Fields
	public string Id; // 0x0
	public PartySize Size; // 0x8
	public ActivityPartyPrivacy Privacy; // 0x10
}

// Namespace: Discord
public struct ActivitySecrets // TypeDefIndex: 10469
{
	// Fields
	public string Match; // 0x0
	public string Join; // 0x8
	public string Spectate; // 0x10
}

// Namespace: Discord
public struct Activity // TypeDefIndex: 10470
{
	// Fields
	public ActivityType Type; // 0x0
	public long ApplicationId; // 0x8
	public string Name; // 0x10
	public string State; // 0x18
	public string Details; // 0x20
	public ActivityTimestamps Timestamps; // 0x28
	public ActivityAssets Assets; // 0x38
	public ActivityParty Party; // 0x58
	public ActivitySecrets Secrets; // 0x70
	public bool Instance; // 0x88
	public uint SupportedPlatforms; // 0x8C
}

// Namespace: Discord
public struct Presence // TypeDefIndex: 10471
{
	// Fields
	public Status Status; // 0x0
	public Activity Activity; // 0x8
}

// Namespace: Discord
public struct Relationship // TypeDefIndex: 10472
{
	// Fields
	public RelationshipType Type; // 0x0
	public User User; // 0x8
	public Presence Presence; // 0x30
}

// Namespace: Discord
public struct Lobby // TypeDefIndex: 10473
{
	// Fields
	public long Id; // 0x0
	public LobbyType Type; // 0x8
	public long OwnerId; // 0x10
	public string Secret; // 0x18
	public uint Capacity; // 0x20
	public bool Locked; // 0x24
}

// Namespace: Discord
public struct ImeUnderline // TypeDefIndex: 10474
{
	// Fields
	public int From; // 0x0
	public int To; // 0x4
	public uint Color; // 0x8
	public uint BackgroundColor; // 0xC
	public bool Thick; // 0x10
}

// Namespace: Discord
public struct Rect // TypeDefIndex: 10475
{
	// Fields
	public int Left; // 0x0
	public int Top; // 0x4
	public int Right; // 0x8
	public int Bottom; // 0xC
}

// Namespace: Discord
public struct FileStat // TypeDefIndex: 10476
{
	// Fields
	public string Filename; // 0x0
	public ulong Size; // 0x8
	public ulong LastModified; // 0x10
}

// Namespace: Discord
public struct Entitlement // TypeDefIndex: 10477
{
	// Fields
	public long Id; // 0x0
	public EntitlementType Type; // 0x8
	public long SkuId; // 0x10
}

// Namespace: Discord
public struct SkuPrice // TypeDefIndex: 10478
{
	// Fields
	public uint Amount; // 0x0
	public string Currency; // 0x8
}

// Namespace: Discord
public struct Sku // TypeDefIndex: 10479
{
	// Fields
	public long Id; // 0x0
	public SkuType Type; // 0x8
	public string Name; // 0x10
	public SkuPrice Price; // 0x18
}

// Namespace: Discord
public struct InputMode // TypeDefIndex: 10480
{
	// Fields
	public InputModeType Type; // 0x0
	public string Shortcut; // 0x8
}

// Namespace: Discord
public struct UserAchievement // TypeDefIndex: 10481
{
	// Fields
	public long UserId; // 0x0
	public long AchievementId; // 0x8
	public byte PercentComplete; // 0x10
	public string UnlockedAt; // 0x18
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class LobbyTransaction.FFIMethods.SetTypeMethod : MulticastDelegate // TypeDefIndex: 10482
{
	// Methods

	// RVA: 0x448850 Offset: 0x447A50 VA: 0x180448850
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual Result Invoke(IntPtr methodsPtr, LobbyType type) { }

	// RVA: 0x450FF0 Offset: 0x4501F0 VA: 0x180450FF0 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, LobbyType type, AsyncCallback callback, object object) { }

	// RVA: 0x409CC0 Offset: 0x408EC0 VA: 0x180409CC0 Slot: 15
	public virtual Result EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class LobbyTransaction.FFIMethods.SetOwnerMethod : MulticastDelegate // TypeDefIndex: 10483
{
	// Methods

	// RVA: 0x445BB0 Offset: 0x444DB0 VA: 0x180445BB0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual Result Invoke(IntPtr methodsPtr, long ownerId) { }

	// RVA: 0x450F50 Offset: 0x450150 VA: 0x180450F50 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, long ownerId, AsyncCallback callback, object object) { }

	// RVA: 0x409CC0 Offset: 0x408EC0 VA: 0x180409CC0 Slot: 15
	public virtual Result EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class LobbyTransaction.FFIMethods.SetCapacityMethod : MulticastDelegate // TypeDefIndex: 10484
{
	// Methods

	// RVA: 0x448850 Offset: 0x447A50 VA: 0x180448850
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual Result Invoke(IntPtr methodsPtr, uint capacity) { }

	// RVA: 0x450C50 Offset: 0x44FE50 VA: 0x180450C50 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, uint capacity, AsyncCallback callback, object object) { }

	// RVA: 0x409CC0 Offset: 0x408EC0 VA: 0x180409CC0 Slot: 15
	public virtual Result EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class LobbyTransaction.FFIMethods.SetMetadataMethod : MulticastDelegate // TypeDefIndex: 10485
{
	// Methods

	// RVA: 0x409D10 Offset: 0x408F10 VA: 0x180409D10
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x409CF0 Offset: 0x408EF0 VA: 0x180409CF0 Slot: 13
	public virtual Result Invoke(IntPtr methodsPtr, string key, string value) { }

	// RVA: 0x450EC0 Offset: 0x4500C0 VA: 0x180450EC0 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, string key, string value, AsyncCallback callback, object object) { }

	// RVA: 0x409CC0 Offset: 0x408EC0 VA: 0x180409CC0 Slot: 15
	public virtual Result EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class LobbyTransaction.FFIMethods.DeleteMetadataMethod : MulticastDelegate // TypeDefIndex: 10486
{
	// Methods

	// RVA: 0x445BB0 Offset: 0x444DB0 VA: 0x180445BB0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual Result Invoke(IntPtr methodsPtr, string key) { }

	// RVA: 0x445B20 Offset: 0x444D20 VA: 0x180445B20 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, string key, AsyncCallback callback, object object) { }

	// RVA: 0x409CC0 Offset: 0x408EC0 VA: 0x180409CC0 Slot: 15
	public virtual Result EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class LobbyTransaction.FFIMethods.SetLockedMethod : MulticastDelegate // TypeDefIndex: 10487
{
	// Methods

	// RVA: 0x450D90 Offset: 0x44FF90 VA: 0x180450D90
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual Result Invoke(IntPtr methodsPtr, bool locked) { }

	// RVA: 0x450CF0 Offset: 0x44FEF0 VA: 0x180450CF0 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, bool locked, AsyncCallback callback, object object) { }

	// RVA: 0x409CC0 Offset: 0x408EC0 VA: 0x180409CC0 Slot: 15
	public virtual Result EndInvoke(IAsyncResult result) { }
}

// Namespace: 
internal struct LobbyTransaction.FFIMethods // TypeDefIndex: 10488
{
	// Fields
	internal LobbyTransaction.FFIMethods.SetTypeMethod SetType; // 0x0
	internal LobbyTransaction.FFIMethods.SetOwnerMethod SetOwner; // 0x8
	internal LobbyTransaction.FFIMethods.SetCapacityMethod SetCapacity; // 0x10
	internal LobbyTransaction.FFIMethods.SetMetadataMethod SetMetadata; // 0x18
	internal LobbyTransaction.FFIMethods.DeleteMetadataMethod DeleteMetadata; // 0x20
	internal LobbyTransaction.FFIMethods.SetLockedMethod SetLocked; // 0x28
}

// Namespace: Discord
public struct LobbyTransaction // TypeDefIndex: 10489
{
	// Fields
	internal IntPtr MethodsPtr; // 0x0
	internal object MethodsStructure; // 0x8

	// Properties
	private LobbyTransaction.FFIMethods Methods { get; }

	// Methods

	// RVA: 0x44AF40 Offset: 0x44A140 VA: 0x18044AF40
	private LobbyTransaction.FFIMethods get_Methods() { }

	// RVA: 0x44AE90 Offset: 0x44A090 VA: 0x18044AE90
	public void SetType(LobbyType type) { }

	// RVA: 0x44ADE0 Offset: 0x449FE0 VA: 0x18044ADE0
	public void SetOwner(long ownerId) { }

	// RVA: 0x44ABC0 Offset: 0x449DC0 VA: 0x18044ABC0
	public void SetCapacity(uint capacity) { }

	// RVA: 0x44AD20 Offset: 0x449F20 VA: 0x18044AD20
	public void SetMetadata(string key, string value) { }

	// RVA: 0x44AB10 Offset: 0x449D10 VA: 0x18044AB10
	public void DeleteMetadata(string key) { }

	// RVA: 0x44AC70 Offset: 0x449E70 VA: 0x18044AC70
	public void SetLocked(bool locked) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class LobbyMemberTransaction.FFIMethods.SetMetadataMethod : MulticastDelegate // TypeDefIndex: 10490
{
	// Methods

	// RVA: 0x409D10 Offset: 0x408F10 VA: 0x180409D10
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x409CF0 Offset: 0x408EF0 VA: 0x180409CF0 Slot: 13
	public virtual Result Invoke(IntPtr methodsPtr, string key, string value) { }

	// RVA: 0x450E30 Offset: 0x450030 VA: 0x180450E30 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, string key, string value, AsyncCallback callback, object object) { }

	// RVA: 0x409CC0 Offset: 0x408EC0 VA: 0x180409CC0 Slot: 15
	public virtual Result EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class LobbyMemberTransaction.FFIMethods.DeleteMetadataMethod : MulticastDelegate // TypeDefIndex: 10491
{
	// Methods

	// RVA: 0x445BB0 Offset: 0x444DB0 VA: 0x180445BB0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual Result Invoke(IntPtr methodsPtr, string key) { }

	// RVA: 0x445A90 Offset: 0x444C90 VA: 0x180445A90 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, string key, AsyncCallback callback, object object) { }

	// RVA: 0x409CC0 Offset: 0x408EC0 VA: 0x180409CC0 Slot: 15
	public virtual Result EndInvoke(IAsyncResult result) { }
}

// Namespace: 
internal struct LobbyMemberTransaction.FFIMethods // TypeDefIndex: 10492
{
	// Fields
	internal LobbyMemberTransaction.FFIMethods.SetMetadataMethod SetMetadata; // 0x0
	internal LobbyMemberTransaction.FFIMethods.DeleteMetadataMethod DeleteMetadata; // 0x8
}

// Namespace: Discord
public struct LobbyMemberTransaction // TypeDefIndex: 10493
{
	// Fields
	internal IntPtr MethodsPtr; // 0x0
	internal object MethodsStructure; // 0x8

	// Properties
	private LobbyMemberTransaction.FFIMethods Methods { get; }

	// Methods

	// RVA: 0x44A600 Offset: 0x449800 VA: 0x18044A600
	private LobbyMemberTransaction.FFIMethods get_Methods() { }

	// RVA: 0x44A540 Offset: 0x449740 VA: 0x18044A540
	public void SetMetadata(string key, string value) { }

	// RVA: 0x44A490 Offset: 0x449690 VA: 0x18044A490
	public void DeleteMetadata(string key) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class LobbySearchQuery.FFIMethods.FilterMethod : MulticastDelegate // TypeDefIndex: 10494
{
	// Methods

	// RVA: 0x4493F0 Offset: 0x4485F0 VA: 0x1804493F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x449250 Offset: 0x448450 VA: 0x180449250 Slot: 13
	public virtual Result Invoke(IntPtr methodsPtr, string key, LobbySearchComparison comparison, LobbySearchCast cast, string value) { }

	// RVA: 0x449310 Offset: 0x448510 VA: 0x180449310 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, string key, LobbySearchComparison comparison, LobbySearchCast cast, string value, AsyncCallback callback, object object) { }

	// RVA: 0x409CC0 Offset: 0x408EC0 VA: 0x180409CC0 Slot: 15
	public virtual Result EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class LobbySearchQuery.FFIMethods.SortMethod : MulticastDelegate // TypeDefIndex: 10495
{
	// Methods

	// RVA: 0x451150 Offset: 0x450350 VA: 0x180451150
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x43DDD0 Offset: 0x43CFD0 VA: 0x18043DDD0 Slot: 13
	public virtual Result Invoke(IntPtr methodsPtr, string key, LobbySearchCast cast, string value) { }

	// RVA: 0x451090 Offset: 0x450290 VA: 0x180451090 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, string key, LobbySearchCast cast, string value, AsyncCallback callback, object object) { }

	// RVA: 0x409CC0 Offset: 0x408EC0 VA: 0x180409CC0 Slot: 15
	public virtual Result EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class LobbySearchQuery.FFIMethods.LimitMethod : MulticastDelegate // TypeDefIndex: 10496
{
	// Methods

	// RVA: 0x448850 Offset: 0x447A50 VA: 0x180448850
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual Result Invoke(IntPtr methodsPtr, uint limit) { }

	// RVA: 0x44A3F0 Offset: 0x4495F0 VA: 0x18044A3F0 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, uint limit, AsyncCallback callback, object object) { }

	// RVA: 0x409CC0 Offset: 0x408EC0 VA: 0x180409CC0 Slot: 15
	public virtual Result EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class LobbySearchQuery.FFIMethods.DistanceMethod : MulticastDelegate // TypeDefIndex: 10497
{
	// Methods

	// RVA: 0x448850 Offset: 0x447A50 VA: 0x180448850
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual Result Invoke(IntPtr methodsPtr, LobbySearchDistance distance) { }

	// RVA: 0x4487B0 Offset: 0x4479B0 VA: 0x1804487B0 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, LobbySearchDistance distance, AsyncCallback callback, object object) { }

	// RVA: 0x409CC0 Offset: 0x408EC0 VA: 0x180409CC0 Slot: 15
	public virtual Result EndInvoke(IAsyncResult result) { }
}

// Namespace: 
internal struct LobbySearchQuery.FFIMethods // TypeDefIndex: 10498
{
	// Fields
	internal LobbySearchQuery.FFIMethods.FilterMethod Filter; // 0x0
	internal LobbySearchQuery.FFIMethods.SortMethod Sort; // 0x8
	internal LobbySearchQuery.FFIMethods.LimitMethod Limit; // 0x10
	internal LobbySearchQuery.FFIMethods.DistanceMethod Distance; // 0x18
}

// Namespace: Discord
public struct LobbySearchQuery // TypeDefIndex: 10499
{
	// Fields
	internal IntPtr MethodsPtr; // 0x0
	internal object MethodsStructure; // 0x8

	// Properties
	private LobbySearchQuery.FFIMethods Methods { get; }

	// Methods

	// RVA: 0x44AA00 Offset: 0x449C00 VA: 0x18044AA00
	private LobbySearchQuery.FFIMethods get_Methods() { }

	// RVA: 0x44A7B0 Offset: 0x4499B0 VA: 0x18044A7B0
	public void Filter(string key, LobbySearchComparison comparison, LobbySearchCast cast, string value) { }

	// RVA: 0x44A930 Offset: 0x449B30 VA: 0x18044A930
	public void Sort(string key, LobbySearchCast cast, string value) { }

	// RVA: 0x44A890 Offset: 0x449A90 VA: 0x18044A890
	public void Limit(uint limit) { }

	// RVA: 0x44A710 Offset: 0x449910 VA: 0x18044A710
	public void Distance(LobbySearchDistance distance) { }
}

// Namespace: Discord
public class ResultException : Exception // TypeDefIndex: 10500
{
	// Fields
	public readonly Result Result; // 0x90

	// Methods

	// RVA: 0x450570 Offset: 0x44F770 VA: 0x180450570
	public void .ctor(Result result) { }
}

// Namespace: 
internal struct Discord.FFIEvents // TypeDefIndex: 10501
{}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class Discord.FFIMethods.DestroyHandler : MulticastDelegate // TypeDefIndex: 10502
{
	// Methods

	// RVA: 0x438120 Offset: 0x437320 VA: 0x180438120
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(IntPtr MethodsPtr) { }

	// RVA: 0x458A20 Offset: 0x457C20 VA: 0x180458A20 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr MethodsPtr, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class Discord.FFIMethods.RunCallbacksMethod : MulticastDelegate // TypeDefIndex: 10503
{
	// Methods

	// RVA: 0x459850 Offset: 0x458A50 VA: 0x180459850
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual Result Invoke(IntPtr methodsPtr) { }

	// RVA: 0x4683A0 Offset: 0x4675A0 VA: 0x1804683A0 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, AsyncCallback callback, object object) { }

	// RVA: 0x409CC0 Offset: 0x408EC0 VA: 0x180409CC0 Slot: 15
	public virtual Result EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class Discord.FFIMethods.SetLogHookCallback : MulticastDelegate // TypeDefIndex: 10504
{
	// Methods

	// RVA: 0x4496C0 Offset: 0x4488C0 VA: 0x1804496C0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x409CF0 Offset: 0x408EF0 VA: 0x180409CF0 Slot: 13
	public virtual void Invoke(IntPtr ptr, LogLevel level, string message) { }

	// RVA: 0x4695F0 Offset: 0x4687F0 VA: 0x1804695F0 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr ptr, LogLevel level, string message, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class Discord.FFIMethods.SetLogHookMethod : MulticastDelegate // TypeDefIndex: 10505
{
	// Methods

	// RVA: 0x43FD10 Offset: 0x43EF10 VA: 0x18043FD10
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x43DDD0 Offset: 0x43CFD0 VA: 0x18043DDD0 Slot: 13
	public virtual void Invoke(IntPtr methodsPtr, LogLevel minLevel, IntPtr callbackData, Discord.FFIMethods.SetLogHookCallback callback) { }

	// RVA: 0x469720 Offset: 0x468920 VA: 0x180469720 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, LogLevel minLevel, IntPtr callbackData, Discord.FFIMethods.SetLogHookCallback callback, AsyncCallback __callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class Discord.FFIMethods.GetApplicationManagerMethod : MulticastDelegate // TypeDefIndex: 10506
{
	// Methods

	// RVA: 0x449560 Offset: 0x448760 VA: 0x180449560
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual IntPtr Invoke(IntPtr discordPtr) { }

	// RVA: 0x459B00 Offset: 0x458D00 VA: 0x180459B00 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr discordPtr, AsyncCallback callback, object object) { }

	// RVA: 0x425AE0 Offset: 0x424CE0 VA: 0x180425AE0 Slot: 15
	public virtual IntPtr EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class Discord.FFIMethods.GetUserManagerMethod : MulticastDelegate // TypeDefIndex: 10507
{
	// Methods

	// RVA: 0x449560 Offset: 0x448760 VA: 0x180449560
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual IntPtr Invoke(IntPtr discordPtr) { }

	// RVA: 0x45B870 Offset: 0x45AA70 VA: 0x18045B870 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr discordPtr, AsyncCallback callback, object object) { }

	// RVA: 0x425AE0 Offset: 0x424CE0 VA: 0x180425AE0 Slot: 15
	public virtual IntPtr EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class Discord.FFIMethods.GetImageManagerMethod : MulticastDelegate // TypeDefIndex: 10508
{
	// Methods

	// RVA: 0x449560 Offset: 0x448760 VA: 0x180449560
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual IntPtr Invoke(IntPtr discordPtr) { }

	// RVA: 0x45A200 Offset: 0x459400 VA: 0x18045A200 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr discordPtr, AsyncCallback callback, object object) { }

	// RVA: 0x425AE0 Offset: 0x424CE0 VA: 0x180425AE0 Slot: 15
	public virtual IntPtr EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class Discord.FFIMethods.GetActivityManagerMethod : MulticastDelegate // TypeDefIndex: 10509
{
	// Methods

	// RVA: 0x449560 Offset: 0x448760 VA: 0x180449560
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual IntPtr Invoke(IntPtr discordPtr) { }

	// RVA: 0x459A80 Offset: 0x458C80 VA: 0x180459A80 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr discordPtr, AsyncCallback callback, object object) { }

	// RVA: 0x425AE0 Offset: 0x424CE0 VA: 0x180425AE0 Slot: 15
	public virtual IntPtr EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class Discord.FFIMethods.GetRelationshipManagerMethod : MulticastDelegate // TypeDefIndex: 10510
{
	// Methods

	// RVA: 0x449560 Offset: 0x448760 VA: 0x180449560
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual IntPtr Invoke(IntPtr discordPtr) { }

	// RVA: 0x45B310 Offset: 0x45A510 VA: 0x18045B310 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr discordPtr, AsyncCallback callback, object object) { }

	// RVA: 0x425AE0 Offset: 0x424CE0 VA: 0x180425AE0 Slot: 15
	public virtual IntPtr EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class Discord.FFIMethods.GetLobbyManagerMethod : MulticastDelegate // TypeDefIndex: 10511
{
	// Methods

	// RVA: 0x449560 Offset: 0x448760 VA: 0x180449560
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual IntPtr Invoke(IntPtr discordPtr) { }

	// RVA: 0x45A480 Offset: 0x459680 VA: 0x18045A480 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr discordPtr, AsyncCallback callback, object object) { }

	// RVA: 0x425AE0 Offset: 0x424CE0 VA: 0x180425AE0 Slot: 15
	public virtual IntPtr EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class Discord.FFIMethods.GetNetworkManagerMethod : MulticastDelegate // TypeDefIndex: 10512
{
	// Methods

	// RVA: 0x449560 Offset: 0x448760 VA: 0x180449560
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual IntPtr Invoke(IntPtr discordPtr) { }

	// RVA: 0x45AEE0 Offset: 0x45A0E0 VA: 0x18045AEE0 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr discordPtr, AsyncCallback callback, object object) { }

	// RVA: 0x425AE0 Offset: 0x424CE0 VA: 0x180425AE0 Slot: 15
	public virtual IntPtr EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class Discord.FFIMethods.GetOverlayManagerMethod : MulticastDelegate // TypeDefIndex: 10513
{
	// Methods

	// RVA: 0x449560 Offset: 0x448760 VA: 0x180449560
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual IntPtr Invoke(IntPtr discordPtr) { }

	// RVA: 0x45B160 Offset: 0x45A360 VA: 0x18045B160 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr discordPtr, AsyncCallback callback, object object) { }

	// RVA: 0x425AE0 Offset: 0x424CE0 VA: 0x180425AE0 Slot: 15
	public virtual IntPtr EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class Discord.FFIMethods.GetStorageManagerMethod : MulticastDelegate // TypeDefIndex: 10514
{
	// Methods

	// RVA: 0x449560 Offset: 0x448760 VA: 0x180449560
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual IntPtr Invoke(IntPtr discordPtr) { }

	// RVA: 0x45B430 Offset: 0x45A630 VA: 0x18045B430 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr discordPtr, AsyncCallback callback, object object) { }

	// RVA: 0x425AE0 Offset: 0x424CE0 VA: 0x180425AE0 Slot: 15
	public virtual IntPtr EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class Discord.FFIMethods.GetStoreManagerMethod : MulticastDelegate // TypeDefIndex: 10515
{
	// Methods

	// RVA: 0x449560 Offset: 0x448760 VA: 0x180449560
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual IntPtr Invoke(IntPtr discordPtr) { }

	// RVA: 0x45B4B0 Offset: 0x45A6B0 VA: 0x18045B4B0 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr discordPtr, AsyncCallback callback, object object) { }

	// RVA: 0x425AE0 Offset: 0x424CE0 VA: 0x180425AE0 Slot: 15
	public virtual IntPtr EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class Discord.FFIMethods.GetVoiceManagerMethod : MulticastDelegate // TypeDefIndex: 10516
{
	// Methods

	// RVA: 0x449560 Offset: 0x448760 VA: 0x180449560
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual IntPtr Invoke(IntPtr discordPtr) { }

	// RVA: 0x45B9B0 Offset: 0x45ABB0 VA: 0x18045B9B0 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr discordPtr, AsyncCallback callback, object object) { }

	// RVA: 0x425AE0 Offset: 0x424CE0 VA: 0x180425AE0 Slot: 15
	public virtual IntPtr EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class Discord.FFIMethods.GetAchievementManagerMethod : MulticastDelegate // TypeDefIndex: 10517
{
	// Methods

	// RVA: 0x449560 Offset: 0x448760 VA: 0x180449560
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual IntPtr Invoke(IntPtr discordPtr) { }

	// RVA: 0x459A00 Offset: 0x458C00 VA: 0x180459A00 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr discordPtr, AsyncCallback callback, object object) { }

	// RVA: 0x425AE0 Offset: 0x424CE0 VA: 0x180425AE0 Slot: 15
	public virtual IntPtr EndInvoke(IAsyncResult result) { }
}

// Namespace: 
internal struct Discord.FFIMethods // TypeDefIndex: 10518
{
	// Fields
	internal Discord.FFIMethods.DestroyHandler Destroy; // 0x0
	internal Discord.FFIMethods.RunCallbacksMethod RunCallbacks; // 0x8
	internal Discord.FFIMethods.SetLogHookMethod SetLogHook; // 0x10
	internal Discord.FFIMethods.GetApplicationManagerMethod GetApplicationManager; // 0x18
	internal Discord.FFIMethods.GetUserManagerMethod GetUserManager; // 0x20
	internal Discord.FFIMethods.GetImageManagerMethod GetImageManager; // 0x28
	internal Discord.FFIMethods.GetActivityManagerMethod GetActivityManager; // 0x30
	internal Discord.FFIMethods.GetRelationshipManagerMethod GetRelationshipManager; // 0x38
	internal Discord.FFIMethods.GetLobbyManagerMethod GetLobbyManager; // 0x40
	internal Discord.FFIMethods.GetNetworkManagerMethod GetNetworkManager; // 0x48
	internal Discord.FFIMethods.GetOverlayManagerMethod GetOverlayManager; // 0x50
	internal Discord.FFIMethods.GetStorageManagerMethod GetStorageManager; // 0x58
	internal Discord.FFIMethods.GetStoreManagerMethod GetStoreManager; // 0x60
	internal Discord.FFIMethods.GetVoiceManagerMethod GetVoiceManager; // 0x68
	internal Discord.FFIMethods.GetAchievementManagerMethod GetAchievementManager; // 0x70
}

// Namespace: 
internal struct Discord.FFICreateParams // TypeDefIndex: 10519
{
	// Fields
	internal long ClientId; // 0x0
	internal ulong Flags; // 0x8
	internal IntPtr Events; // 0x10
	internal IntPtr EventData; // 0x18
	internal IntPtr ApplicationEvents; // 0x20
	internal uint ApplicationVersion; // 0x28
	internal IntPtr UserEvents; // 0x30
	internal uint UserVersion; // 0x38
	internal IntPtr ImageEvents; // 0x40
	internal uint ImageVersion; // 0x48
	internal IntPtr ActivityEvents; // 0x50
	internal uint ActivityVersion; // 0x58
	internal IntPtr RelationshipEvents; // 0x60
	internal uint RelationshipVersion; // 0x68
	internal IntPtr LobbyEvents; // 0x70
	internal uint LobbyVersion; // 0x78
	internal IntPtr NetworkEvents; // 0x80
	internal uint NetworkVersion; // 0x88
	internal IntPtr OverlayEvents; // 0x90
	internal uint OverlayVersion; // 0x98
	internal IntPtr StorageEvents; // 0xA0
	internal uint StorageVersion; // 0xA8
	internal IntPtr StoreEvents; // 0xB0
	internal uint StoreVersion; // 0xB8
	internal IntPtr VoiceEvents; // 0xC0
	internal uint VoiceVersion; // 0xC8
	internal IntPtr AchievementEvents; // 0xD0
	internal uint AchievementVersion; // 0xD8
}

// Namespace: 
public sealed class Discord.SetLogHookHandler : MulticastDelegate // TypeDefIndex: 10520
{
	// Methods

	// RVA: 0x457BE0 Offset: 0x456DE0 VA: 0x180457BE0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(LogLevel level, string message) { }

	// RVA: 0x469690 Offset: 0x468890 VA: 0x180469690 Slot: 14
	public virtual IAsyncResult BeginInvoke(LogLevel level, string message, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: Discord
public class Discord : IDisposable // TypeDefIndex: 10521
{
	// Fields
	private GCHandle SelfHandle; // 0x10
	private IntPtr EventsPtr; // 0x18
	private Discord.FFIEvents Events; // 0x20
	private IntPtr ApplicationEventsPtr; // 0x28
	private ApplicationManager.FFIEvents ApplicationEvents; // 0x30
	internal ApplicationManager ApplicationManagerInstance; // 0x38
	private IntPtr UserEventsPtr; // 0x40
	private UserManager.FFIEvents UserEvents; // 0x48
	internal UserManager UserManagerInstance; // 0x50
	private IntPtr ImageEventsPtr; // 0x58
	private ImageManager.FFIEvents ImageEvents; // 0x60
	internal ImageManager ImageManagerInstance; // 0x68
	private IntPtr ActivityEventsPtr; // 0x70
	private ActivityManager.FFIEvents ActivityEvents; // 0x78
	internal ActivityManager ActivityManagerInstance; // 0x98
	private IntPtr RelationshipEventsPtr; // 0xA0
	private RelationshipManager.FFIEvents RelationshipEvents; // 0xA8
	internal RelationshipManager RelationshipManagerInstance; // 0xB8
	private IntPtr LobbyEventsPtr; // 0xC0
	private LobbyManager.FFIEvents LobbyEvents; // 0xC8
	internal LobbyManager LobbyManagerInstance; // 0x108
	private IntPtr NetworkEventsPtr; // 0x110
	private NetworkManager.FFIEvents NetworkEvents; // 0x118
	internal NetworkManager NetworkManagerInstance; // 0x128
	private IntPtr OverlayEventsPtr; // 0x130
	private OverlayManager.FFIEvents OverlayEvents; // 0x138
	internal OverlayManager OverlayManagerInstance; // 0x140
	private IntPtr StorageEventsPtr; // 0x148
	private StorageManager.FFIEvents StorageEvents; // 0x150
	internal StorageManager StorageManagerInstance; // 0x158
	private IntPtr StoreEventsPtr; // 0x160
	private StoreManager.FFIEvents StoreEvents; // 0x168
	internal StoreManager StoreManagerInstance; // 0x178
	private IntPtr VoiceEventsPtr; // 0x180
	private VoiceManager.FFIEvents VoiceEvents; // 0x188
	internal VoiceManager VoiceManagerInstance; // 0x190
	private IntPtr AchievementEventsPtr; // 0x198
	private AchievementManager.FFIEvents AchievementEvents; // 0x1A0
	internal AchievementManager AchievementManagerInstance; // 0x1A8
	private IntPtr MethodsPtr; // 0x1B0
	private object MethodsStructure; // 0x1B8
	private Nullable<GCHandle> setLogHook; // 0x1C0

	// Properties
	private Discord.FFIMethods Methods { get; }

	// Methods

	// RVA: 0x446400 Offset: 0x445600 VA: 0x180446400
	private static extern Result DiscordCreate(uint version, ref Discord.FFICreateParams createParams, out IntPtr manager) { }

	// RVA: 0x448660 Offset: 0x447860 VA: 0x180448660
	private Discord.FFIMethods get_Methods() { }

	// RVA: 0x447D30 Offset: 0x446F30 VA: 0x180447D30
	public void .ctor(long clientId, ulong flags) { }

	// RVA: 0x447520 Offset: 0x446720 VA: 0x180447520
	private void InitEvents(IntPtr eventsPtr, ref Discord.FFIEvents events) { }

	// RVA: 0x4464A0 Offset: 0x4456A0 VA: 0x1804464A0 Slot: 4
	public void Dispose() { }

	// RVA: 0x4478E0 Offset: 0x446AE0 VA: 0x1804478E0
	public void RunCallbacks() { }

	[MonoPInvokeCallback]
	// RVA: 0x447980 Offset: 0x446B80 VA: 0x180447980
	private static void SetLogHookCallbackImpl(IntPtr ptr, LogLevel level, string message) { }

	// RVA: 0x447A30 Offset: 0x446C30 VA: 0x180447A30
	public void SetLogHook(LogLevel minLevel, Discord.SetLogHookHandler callback) { }

	// RVA: 0x446BF0 Offset: 0x445DF0 VA: 0x180446BF0
	public ApplicationManager GetApplicationManager() { }

	// RVA: 0x447350 Offset: 0x446550 VA: 0x180447350
	public UserManager GetUserManager() { }

	// RVA: 0x446CD0 Offset: 0x445ED0 VA: 0x180446CD0
	public ImageManager GetImageManager() { }

	// RVA: 0x446A50 Offset: 0x445C50 VA: 0x180446A50
	public ActivityManager GetActivityManager() { }

	// RVA: 0x447080 Offset: 0x446280 VA: 0x180447080
	public RelationshipManager GetRelationshipManager() { }

	// RVA: 0x446DB0 Offset: 0x445FB0 VA: 0x180446DB0
	public LobbyManager GetLobbyManager() { }

	// RVA: 0x446EA0 Offset: 0x4460A0 VA: 0x180446EA0
	public NetworkManager GetNetworkManager() { }

	// RVA: 0x446F90 Offset: 0x446190 VA: 0x180446F90
	public OverlayManager GetOverlayManager() { }

	// RVA: 0x447170 Offset: 0x446370 VA: 0x180447170
	public StorageManager GetStorageManager() { }

	// RVA: 0x447260 Offset: 0x446460 VA: 0x180447260
	public StoreManager GetStoreManager() { }

	// RVA: 0x447430 Offset: 0x446630 VA: 0x180447430
	public VoiceManager GetVoiceManager() { }

	// RVA: 0x446940 Offset: 0x445B40 VA: 0x180446940
	public AchievementManager GetAchievementManager() { }
}

// Namespace: Discord
internal class MonoPInvokeCallbackAttribute : Attribute // TypeDefIndex: 10522
{
	// Methods

	// RVA: 0x3FD450 Offset: 0x3FC650 VA: 0x1803FD450
	public void .ctor() { }
}

// Namespace: 
internal struct ApplicationManager.FFIEvents // TypeDefIndex: 10523
{}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class ApplicationManager.FFIMethods.ValidateOrExitCallback : MulticastDelegate // TypeDefIndex: 10524
{
	// Methods

	// RVA: 0x43DB50 Offset: 0x43CD50 VA: 0x18043DB50
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(IntPtr ptr, Result result) { }

	// RVA: 0x46D640 Offset: 0x46C840 VA: 0x18046D640 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr ptr, Result result, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class ApplicationManager.FFIMethods.ValidateOrExitMethod : MulticastDelegate // TypeDefIndex: 10525
{
	// Methods

	// RVA: 0x441EC0 Offset: 0x4410C0 VA: 0x180441EC0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x409CF0 Offset: 0x408EF0 VA: 0x180409CF0 Slot: 13
	public virtual void Invoke(IntPtr methodsPtr, IntPtr callbackData, ApplicationManager.FFIMethods.ValidateOrExitCallback callback) { }

	// RVA: 0x46D760 Offset: 0x46C960 VA: 0x18046D760 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, IntPtr callbackData, ApplicationManager.FFIMethods.ValidateOrExitCallback callback, AsyncCallback __callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class ApplicationManager.FFIMethods.GetCurrentLocaleMethod : MulticastDelegate // TypeDefIndex: 10526
{
	// Methods

	// RVA: 0x43FEE0 Offset: 0x43F0E0 VA: 0x18043FEE0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(IntPtr methodsPtr, StringBuilder locale) { }

	// RVA: 0x459CD0 Offset: 0x458ED0 VA: 0x180459CD0 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, StringBuilder locale, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class ApplicationManager.FFIMethods.GetCurrentBranchMethod : MulticastDelegate // TypeDefIndex: 10527
{
	// Methods

	// RVA: 0x43FEE0 Offset: 0x43F0E0 VA: 0x18043FEE0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(IntPtr methodsPtr, StringBuilder branch) { }

	// RVA: 0x459C40 Offset: 0x458E40 VA: 0x180459C40 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, StringBuilder branch, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class ApplicationManager.FFIMethods.GetOAuth2TokenCallback : MulticastDelegate // TypeDefIndex: 10528
{
	// Methods

	// RVA: 0x4496C0 Offset: 0x4488C0 VA: 0x1804496C0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x409CF0 Offset: 0x408EF0 VA: 0x180409CF0 Slot: 13
	public virtual void Invoke(IntPtr ptr, Result result, ref OAuth2Token oauth2Token) { }

	// RVA: 0x45AF60 Offset: 0x45A160 VA: 0x18045AF60 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr ptr, Result result, ref OAuth2Token oauth2Token, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref OAuth2Token oauth2Token, IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class ApplicationManager.FFIMethods.GetOAuth2TokenMethod : MulticastDelegate // TypeDefIndex: 10529
{
	// Methods

	// RVA: 0x441EC0 Offset: 0x4410C0 VA: 0x180441EC0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x409CF0 Offset: 0x408EF0 VA: 0x180409CF0 Slot: 13
	public virtual void Invoke(IntPtr methodsPtr, IntPtr callbackData, ApplicationManager.FFIMethods.GetOAuth2TokenCallback callback) { }

	// RVA: 0x45B0C0 Offset: 0x45A2C0 VA: 0x18045B0C0 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, IntPtr callbackData, ApplicationManager.FFIMethods.GetOAuth2TokenCallback callback, AsyncCallback __callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class ApplicationManager.FFIMethods.GetTicketCallback : MulticastDelegate // TypeDefIndex: 10530
{
	// Methods

	// RVA: 0x4496C0 Offset: 0x4488C0 VA: 0x1804496C0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x409CF0 Offset: 0x408EF0 VA: 0x180409CF0 Slot: 13
	public virtual void Invoke(IntPtr ptr, Result result, ref string data) { }

	// RVA: 0x45B530 Offset: 0x45A730 VA: 0x18045B530 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr ptr, Result result, ref string data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref string data, IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class ApplicationManager.FFIMethods.GetTicketMethod : MulticastDelegate // TypeDefIndex: 10531
{
	// Methods

	// RVA: 0x441EC0 Offset: 0x4410C0 VA: 0x180441EC0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x409CF0 Offset: 0x408EF0 VA: 0x180409CF0 Slot: 13
	public virtual void Invoke(IntPtr methodsPtr, IntPtr callbackData, ApplicationManager.FFIMethods.GetTicketCallback callback) { }

	// RVA: 0x45B670 Offset: 0x45A870 VA: 0x18045B670 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, IntPtr callbackData, ApplicationManager.FFIMethods.GetTicketCallback callback, AsyncCallback __callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
internal struct ApplicationManager.FFIMethods // TypeDefIndex: 10532
{
	// Fields
	internal ApplicationManager.FFIMethods.ValidateOrExitMethod ValidateOrExit; // 0x0
	internal ApplicationManager.FFIMethods.GetCurrentLocaleMethod GetCurrentLocale; // 0x8
	internal ApplicationManager.FFIMethods.GetCurrentBranchMethod GetCurrentBranch; // 0x10
	internal ApplicationManager.FFIMethods.GetOAuth2TokenMethod GetOAuth2Token; // 0x18
	internal ApplicationManager.FFIMethods.GetTicketMethod GetTicket; // 0x20
}

// Namespace: 
public sealed class ApplicationManager.ValidateOrExitHandler : MulticastDelegate // TypeDefIndex: 10533
{
	// Methods

	// RVA: 0x43DC70 Offset: 0x43CE70 VA: 0x18043DC70
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(Result result) { }

	// RVA: 0x46D6E0 Offset: 0x46C8E0 VA: 0x18046D6E0 Slot: 14
	public virtual IAsyncResult BeginInvoke(Result result, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class ApplicationManager.GetOAuth2TokenHandler : MulticastDelegate // TypeDefIndex: 10534
{
	// Methods

	// RVA: 0x457BE0 Offset: 0x456DE0 VA: 0x180457BE0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(Result result, ref OAuth2Token oauth2Token) { }

	// RVA: 0x45B020 Offset: 0x45A220 VA: 0x18045B020 Slot: 14
	public virtual IAsyncResult BeginInvoke(Result result, ref OAuth2Token oauth2Token, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref OAuth2Token oauth2Token, IAsyncResult result) { }
}

// Namespace: 
public sealed class ApplicationManager.GetTicketHandler : MulticastDelegate // TypeDefIndex: 10535
{
	// Methods

	// RVA: 0x457BE0 Offset: 0x456DE0 VA: 0x180457BE0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(Result result, ref string data) { }

	// RVA: 0x45B5E0 Offset: 0x45A7E0 VA: 0x18045B5E0 Slot: 14
	public virtual IAsyncResult BeginInvoke(Result result, ref string data, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref string data, IAsyncResult result) { }
}

// Namespace: Discord
public class ApplicationManager // TypeDefIndex: 10536
{
	// Fields
	private IntPtr MethodsPtr; // 0x10
	private object MethodsStructure; // 0x18

	// Properties
	private ApplicationManager.FFIMethods Methods { get; }

	// Methods

	// RVA: 0x4576D0 Offset: 0x4568D0 VA: 0x1804576D0
	private ApplicationManager.FFIMethods get_Methods() { }

	// RVA: 0x4575A0 Offset: 0x4567A0 VA: 0x1804575A0
	internal void .ctor(IntPtr ptr, IntPtr eventsPtr, ref ApplicationManager.FFIEvents events) { }

	// RVA: 0x457340 Offset: 0x456540 VA: 0x180457340
	private void InitEvents(IntPtr eventsPtr, ref ApplicationManager.FFIEvents events) { }

	[MonoPInvokeCallback]
	// RVA: 0x4573B0 Offset: 0x4565B0 VA: 0x1804573B0
	private static void ValidateOrExitCallbackImpl(IntPtr ptr, Result result) { }

	// RVA: 0x457460 Offset: 0x456660 VA: 0x180457460
	public void ValidateOrExit(ApplicationManager.ValidateOrExitHandler callback) { }

	// RVA: 0x456E70 Offset: 0x456070 VA: 0x180456E70
	public string GetCurrentLocale() { }

	// RVA: 0x456DC0 Offset: 0x455FC0 VA: 0x180456DC0
	public string GetCurrentBranch() { }

	[MonoPInvokeCallback]
	// RVA: 0x456F20 Offset: 0x456120 VA: 0x180456F20
	private static void GetOAuth2TokenCallbackImpl(IntPtr ptr, Result result, ref OAuth2Token oauth2Token) { }

	// RVA: 0x456FE0 Offset: 0x4561E0 VA: 0x180456FE0
	public void GetOAuth2Token(ApplicationManager.GetOAuth2TokenHandler callback) { }

	[MonoPInvokeCallback]
	// RVA: 0x457130 Offset: 0x456330 VA: 0x180457130
	private static void GetTicketCallbackImpl(IntPtr ptr, Result result, ref string data) { }

	// RVA: 0x4571F0 Offset: 0x4563F0 VA: 0x1804571F0
	public void GetTicket(ApplicationManager.GetTicketHandler callback) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class UserManager.FFIEvents.CurrentUserUpdateHandler : MulticastDelegate // TypeDefIndex: 10537
{
	// Methods

	// RVA: 0x438120 Offset: 0x437320 VA: 0x180438120
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(IntPtr ptr) { }

	// RVA: 0x458690 Offset: 0x457890 VA: 0x180458690 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr ptr, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
internal struct UserManager.FFIEvents // TypeDefIndex: 10538
{
	// Fields
	internal UserManager.FFIEvents.CurrentUserUpdateHandler OnCurrentUserUpdate; // 0x0
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class UserManager.FFIMethods.GetCurrentUserMethod : MulticastDelegate // TypeDefIndex: 10539
{
	// Methods

	// RVA: 0x445BB0 Offset: 0x444DB0 VA: 0x180445BB0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual Result Invoke(IntPtr methodsPtr, ref User currentUser) { }

	// RVA: 0x459D60 Offset: 0x458F60 VA: 0x180459D60 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, ref User currentUser, AsyncCallback callback, object object) { }

	// RVA: 0x3FEA30 Offset: 0x3FDC30 VA: 0x1803FEA30 Slot: 15
	public virtual Result EndInvoke(ref User currentUser, IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class UserManager.FFIMethods.GetUserCallback : MulticastDelegate // TypeDefIndex: 10540
{
	// Methods

	// RVA: 0x4496C0 Offset: 0x4488C0 VA: 0x1804496C0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x409CF0 Offset: 0x408EF0 VA: 0x180409CF0 Slot: 13
	public virtual void Invoke(IntPtr ptr, Result result, ref User user) { }

	// RVA: 0x45B710 Offset: 0x45A910 VA: 0x18045B710 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr ptr, Result result, ref User user, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref User user, IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class UserManager.FFIMethods.GetUserMethod : MulticastDelegate // TypeDefIndex: 10541
{
	// Methods

	// RVA: 0x43DDF0 Offset: 0x43CFF0 VA: 0x18043DDF0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x43DDD0 Offset: 0x43CFD0 VA: 0x18043DDD0 Slot: 13
	public virtual void Invoke(IntPtr methodsPtr, long userId, IntPtr callbackData, UserManager.FFIMethods.GetUserCallback callback) { }

	// RVA: 0x45B8F0 Offset: 0x45AAF0 VA: 0x18045B8F0 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, long userId, IntPtr callbackData, UserManager.FFIMethods.GetUserCallback callback, AsyncCallback __callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class UserManager.FFIMethods.GetCurrentUserPremiumTypeMethod : MulticastDelegate // TypeDefIndex: 10542
{
	// Methods

	// RVA: 0x445BB0 Offset: 0x444DB0 VA: 0x180445BB0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual Result Invoke(IntPtr methodsPtr, ref PremiumType premiumType) { }

	// RVA: 0x459E00 Offset: 0x459000 VA: 0x180459E00 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, ref PremiumType premiumType, AsyncCallback callback, object object) { }

	// RVA: 0x3FEA30 Offset: 0x3FDC30 VA: 0x1803FEA30 Slot: 15
	public virtual Result EndInvoke(ref PremiumType premiumType, IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class UserManager.FFIMethods.CurrentUserHasFlagMethod : MulticastDelegate // TypeDefIndex: 10543
{
	// Methods

	// RVA: 0x4585F0 Offset: 0x4577F0 VA: 0x1804585F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x409CF0 Offset: 0x408EF0 VA: 0x180409CF0 Slot: 13
	public virtual Result Invoke(IntPtr methodsPtr, UserFlag flag, ref bool hasFlag) { }

	// RVA: 0x458530 Offset: 0x457730 VA: 0x180458530 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, UserFlag flag, ref bool hasFlag, AsyncCallback callback, object object) { }

	// RVA: 0x3FEA30 Offset: 0x3FDC30 VA: 0x1803FEA30 Slot: 15
	public virtual Result EndInvoke(ref bool hasFlag, IAsyncResult result) { }
}

// Namespace: 
internal struct UserManager.FFIMethods // TypeDefIndex: 10544
{
	// Fields
	internal UserManager.FFIMethods.GetCurrentUserMethod GetCurrentUser; // 0x0
	internal UserManager.FFIMethods.GetUserMethod GetUser; // 0x8
	internal UserManager.FFIMethods.GetCurrentUserPremiumTypeMethod GetCurrentUserPremiumType; // 0x10
	internal UserManager.FFIMethods.CurrentUserHasFlagMethod CurrentUserHasFlag; // 0x18
}

// Namespace: 
public sealed class UserManager.GetUserHandler : MulticastDelegate // TypeDefIndex: 10545
{
	// Methods

	// RVA: 0x457BE0 Offset: 0x456DE0 VA: 0x180457BE0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(Result result, ref User user) { }

	// RVA: 0x45B7D0 Offset: 0x45A9D0 VA: 0x18045B7D0 Slot: 14
	public virtual IAsyncResult BeginInvoke(Result result, ref User user, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref User user, IAsyncResult result) { }
}

// Namespace: 
public sealed class UserManager.CurrentUserUpdateHandler : MulticastDelegate // TypeDefIndex: 10546
{
	// Methods

	// RVA: 0x458710 Offset: 0x457910 VA: 0x180458710
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x4240E0 Offset: 0x4232E0 VA: 0x1804240E0 Slot: 13
	public virtual void Invoke() { }

	// RVA: 0x4240B0 Offset: 0x4232B0 VA: 0x1804240B0 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: Discord
public class UserManager // TypeDefIndex: 10547
{
	// Fields
	private IntPtr MethodsPtr; // 0x10
	private object MethodsStructure; // 0x18
	[CompilerGenerated]
	private UserManager.CurrentUserUpdateHandler OnCurrentUserUpdate; // 0x20

	// Properties
	private UserManager.FFIMethods Methods { get; }

	// Methods

	// RVA: 0x46D490 Offset: 0x46C690 VA: 0x18046D490
	private UserManager.FFIMethods get_Methods() { }

	[CompilerGenerated]
	// RVA: 0x46D3F0 Offset: 0x46C5F0 VA: 0x18046D3F0
	public void add_OnCurrentUserUpdate(UserManager.CurrentUserUpdateHandler value) { }

	[CompilerGenerated]
	// RVA: 0x46D5A0 Offset: 0x46C7A0 VA: 0x18046D5A0
	public void remove_OnCurrentUserUpdate(UserManager.CurrentUserUpdateHandler value) { }

	// RVA: 0x46D210 Offset: 0x46C410 VA: 0x18046D210
	internal void .ctor(IntPtr ptr, IntPtr eventsPtr, ref UserManager.FFIEvents events) { }

	// RVA: 0x46D020 Offset: 0x46C220 VA: 0x18046D020
	private void InitEvents(IntPtr eventsPtr, ref UserManager.FFIEvents events) { }

	// RVA: 0x46CD60 Offset: 0x46BF60 VA: 0x18046CD60
	public User GetCurrentUser() { }

	[MonoPInvokeCallback]
	// RVA: 0x46CE00 Offset: 0x46C000 VA: 0x18046CE00
	private static void GetUserCallbackImpl(IntPtr ptr, Result result, ref User user) { }

	// RVA: 0x46CEC0 Offset: 0x46C0C0 VA: 0x18046CEC0
	public void GetUser(long userId, UserManager.GetUserHandler callback) { }

	// RVA: 0x46CCC0 Offset: 0x46BEC0 VA: 0x18046CCC0
	public PremiumType GetCurrentUserPremiumType() { }

	// RVA: 0x46CC00 Offset: 0x46BE00 VA: 0x18046CC00
	public bool CurrentUserHasFlag(UserFlag flag) { }

	[MonoPInvokeCallback]
	// RVA: 0x46D140 Offset: 0x46C340 VA: 0x18046D140
	private static void OnCurrentUserUpdateImpl(IntPtr ptr) { }
}

// Namespace: 
internal struct ImageManager.FFIEvents // TypeDefIndex: 10548
{}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class ImageManager.FFIMethods.FetchCallback : MulticastDelegate // TypeDefIndex: 10549
{
	// Methods

	// RVA: 0x4590B0 Offset: 0x4582B0 VA: 0x1804590B0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x459070 Offset: 0x458270 VA: 0x180459070 Slot: 13
	public virtual void Invoke(IntPtr ptr, Result result, ImageHandle handleResult) { }

	// RVA: 0x458FB0 Offset: 0x4581B0 VA: 0x180458FB0 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr ptr, Result result, ImageHandle handleResult, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class ImageManager.FFIMethods.FetchMethod : MulticastDelegate // TypeDefIndex: 10550
{
	// Methods

	// RVA: 0x4593E0 Offset: 0x4585E0 VA: 0x1804593E0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x459380 Offset: 0x458580 VA: 0x180459380 Slot: 13
	public virtual void Invoke(IntPtr methodsPtr, ImageHandle handle, bool refresh, IntPtr callbackData, ImageManager.FFIMethods.FetchCallback callback) { }

	// RVA: 0x459290 Offset: 0x458490 VA: 0x180459290 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, ImageHandle handle, bool refresh, IntPtr callbackData, ImageManager.FFIMethods.FetchCallback callback, AsyncCallback __callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class ImageManager.FFIMethods.GetDimensionsMethod : MulticastDelegate // TypeDefIndex: 10551
{
	// Methods

	// RVA: 0x45A160 Offset: 0x459360 VA: 0x18045A160
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x45A120 Offset: 0x459320 VA: 0x18045A120 Slot: 13
	public virtual Result Invoke(IntPtr methodsPtr, ImageHandle handle, ref ImageDimensions dimensions) { }

	// RVA: 0x45A060 Offset: 0x459260 VA: 0x18045A060 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, ImageHandle handle, ref ImageDimensions dimensions, AsyncCallback callback, object object) { }

	// RVA: 0x3FEA30 Offset: 0x3FDC30 VA: 0x1803FEA30 Slot: 15
	public virtual Result EndInvoke(ref ImageDimensions dimensions, IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class ImageManager.FFIMethods.GetDataMethod : MulticastDelegate // TypeDefIndex: 10552
{
	// Methods

	// RVA: 0x459FC0 Offset: 0x4591C0 VA: 0x180459FC0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x459F70 Offset: 0x459170 VA: 0x180459F70 Slot: 13
	public virtual Result Invoke(IntPtr methodsPtr, ImageHandle handle, byte[] data, int dataLen) { }

	// RVA: 0x459EA0 Offset: 0x4590A0 VA: 0x180459EA0 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, ImageHandle handle, byte[] data, int dataLen, AsyncCallback callback, object object) { }

	// RVA: 0x409CC0 Offset: 0x408EC0 VA: 0x180409CC0 Slot: 15
	public virtual Result EndInvoke(IAsyncResult result) { }
}

// Namespace: 
internal struct ImageManager.FFIMethods // TypeDefIndex: 10553
{
	// Fields
	internal ImageManager.FFIMethods.FetchMethod Fetch; // 0x0
	internal ImageManager.FFIMethods.GetDimensionsMethod GetDimensions; // 0x8
	internal ImageManager.FFIMethods.GetDataMethod GetData; // 0x10
}

// Namespace: 
public sealed class ImageManager.FetchHandler : MulticastDelegate // TypeDefIndex: 10554
{
	// Methods

	// RVA: 0x4591F0 Offset: 0x4583F0 VA: 0x1804591F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x448B50 Offset: 0x447D50 VA: 0x180448B50 Slot: 13
	public virtual void Invoke(Result result, ImageHandle handleResult) { }

	// RVA: 0x459150 Offset: 0x458350 VA: 0x180459150 Slot: 14
	public virtual IAsyncResult BeginInvoke(Result result, ImageHandle handleResult, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: Discord
public class ImageManager // TypeDefIndex: 10555
{
	// Fields
	private IntPtr MethodsPtr; // 0x10
	private object MethodsStructure; // 0x18

	// Properties
	private ImageManager.FFIMethods Methods { get; }

	// Methods

	// RVA: 0x45C4C0 Offset: 0x45B6C0 VA: 0x18045C4C0
	private ImageManager.FFIMethods get_Methods() { }

	// RVA: 0x45C390 Offset: 0x45B590 VA: 0x18045C390
	internal void .ctor(IntPtr ptr, IntPtr eventsPtr, ref ImageManager.FFIEvents events) { }

	// RVA: 0x45C320 Offset: 0x45B520 VA: 0x18045C320
	private void InitEvents(IntPtr eventsPtr, ref ImageManager.FFIEvents events) { }

	[MonoPInvokeCallback]
	// RVA: 0x45BA30 Offset: 0x45AC30 VA: 0x18045BA30
	private static void FetchCallbackImpl(IntPtr ptr, Result result, ImageHandle handleResult) { }

	// RVA: 0x45BC90 Offset: 0x45AE90 VA: 0x18045BC90
	public void Fetch(ImageHandle handle, bool refresh, ImageManager.FetchHandler callback) { }

	// RVA: 0x45C050 Offset: 0x45B250 VA: 0x18045C050
	public ImageDimensions GetDimensions(ImageHandle handle) { }

	// RVA: 0x45BF60 Offset: 0x45B160 VA: 0x18045BF60
	public void GetData(ImageHandle handle, byte[] data) { }

	// RVA: 0x45BB00 Offset: 0x45AD00 VA: 0x18045BB00
	public void Fetch(ImageHandle handle, ImageManager.FetchHandler callback) { }

	// RVA: 0x45BE20 Offset: 0x45B020 VA: 0x18045BE20
	public byte[] GetData(ImageHandle handle) { }

	// RVA: 0x45C130 Offset: 0x45B330 VA: 0x18045C130
	public Texture2D GetTexture(ImageHandle handle) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class RelationshipManager.FFIEvents.RefreshHandler : MulticastDelegate // TypeDefIndex: 10556
{
	// Methods

	// RVA: 0x438120 Offset: 0x437320 VA: 0x180438120
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(IntPtr ptr) { }

	// RVA: 0x467390 Offset: 0x466590 VA: 0x180467390 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr ptr, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class RelationshipManager.FFIEvents.RelationshipUpdateHandler : MulticastDelegate // TypeDefIndex: 10557
{
	// Methods

	// RVA: 0x43FEE0 Offset: 0x43F0E0 VA: 0x18043FEE0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(IntPtr ptr, ref Relationship relationship) { }

	// RVA: 0x468270 Offset: 0x467470 VA: 0x180468270 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr ptr, ref Relationship relationship, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref Relationship relationship, IAsyncResult result) { }
}

// Namespace: 
internal struct RelationshipManager.FFIEvents // TypeDefIndex: 10558
{
	// Fields
	internal RelationshipManager.FFIEvents.RefreshHandler OnRefresh; // 0x0
	internal RelationshipManager.FFIEvents.RelationshipUpdateHandler OnRelationshipUpdate; // 0x8
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class RelationshipManager.FFIMethods.FilterCallback : MulticastDelegate // TypeDefIndex: 10559
{
	// Methods

	// RVA: 0x459560 Offset: 0x458760 VA: 0x180459560
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual bool Invoke(IntPtr ptr, ref Relationship relationship) { }

	// RVA: 0x459480 Offset: 0x458680 VA: 0x180459480 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr ptr, ref Relationship relationship, AsyncCallback callback, object object) { }

	// RVA: 0x459520 Offset: 0x458720 VA: 0x180459520 Slot: 15
	public virtual bool EndInvoke(ref Relationship relationship, IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class RelationshipManager.FFIMethods.FilterMethod : MulticastDelegate // TypeDefIndex: 10560
{
	// Methods

	// RVA: 0x441EC0 Offset: 0x4410C0 VA: 0x180441EC0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x409CF0 Offset: 0x408EF0 VA: 0x180409CF0 Slot: 13
	public virtual void Invoke(IntPtr methodsPtr, IntPtr callbackData, RelationshipManager.FFIMethods.FilterCallback callback) { }

	// RVA: 0x459730 Offset: 0x458930 VA: 0x180459730 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, IntPtr callbackData, RelationshipManager.FFIMethods.FilterCallback callback, AsyncCallback __callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class RelationshipManager.FFIMethods.CountMethod : MulticastDelegate // TypeDefIndex: 10561
{
	// Methods

	// RVA: 0x445BB0 Offset: 0x444DB0 VA: 0x180445BB0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual Result Invoke(IntPtr methodsPtr, ref int count) { }

	// RVA: 0x4581E0 Offset: 0x4573E0 VA: 0x1804581E0 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, ref int count, AsyncCallback callback, object object) { }

	// RVA: 0x3FEA30 Offset: 0x3FDC30 VA: 0x1803FEA30 Slot: 15
	public virtual Result EndInvoke(ref int count, IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class RelationshipManager.FFIMethods.GetMethod : MulticastDelegate // TypeDefIndex: 10562
{
	// Methods

	// RVA: 0x409D10 Offset: 0x408F10 VA: 0x180409D10
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x409CF0 Offset: 0x408EF0 VA: 0x180409CF0 Slot: 13
	public virtual Result Invoke(IntPtr methodsPtr, long userId, ref Relationship relationship) { }

	// RVA: 0x45AE20 Offset: 0x45A020 VA: 0x18045AE20 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, long userId, ref Relationship relationship, AsyncCallback callback, object object) { }

	// RVA: 0x3FEA30 Offset: 0x3FDC30 VA: 0x1803FEA30 Slot: 15
	public virtual Result EndInvoke(ref Relationship relationship, IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class RelationshipManager.FFIMethods.GetAtMethod : MulticastDelegate // TypeDefIndex: 10563
{
	// Methods

	// RVA: 0x4585F0 Offset: 0x4577F0 VA: 0x1804585F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x409CF0 Offset: 0x408EF0 VA: 0x180409CF0 Slot: 13
	public virtual Result Invoke(IntPtr methodsPtr, uint index, ref Relationship relationship) { }

	// RVA: 0x459B80 Offset: 0x458D80 VA: 0x180459B80 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, uint index, ref Relationship relationship, AsyncCallback callback, object object) { }

	// RVA: 0x3FEA30 Offset: 0x3FDC30 VA: 0x1803FEA30 Slot: 15
	public virtual Result EndInvoke(ref Relationship relationship, IAsyncResult result) { }
}

// Namespace: 
internal struct RelationshipManager.FFIMethods // TypeDefIndex: 10564
{
	// Fields
	internal RelationshipManager.FFIMethods.FilterMethod Filter; // 0x0
	internal RelationshipManager.FFIMethods.CountMethod Count; // 0x8
	internal RelationshipManager.FFIMethods.GetMethod Get; // 0x10
	internal RelationshipManager.FFIMethods.GetAtMethod GetAt; // 0x18
}

// Namespace: 
public sealed class RelationshipManager.FilterHandler : MulticastDelegate // TypeDefIndex: 10565
{
	// Methods

	// RVA: 0x459690 Offset: 0x458890 VA: 0x180459690
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual bool Invoke(ref Relationship relationship) { }

	// RVA: 0x459600 Offset: 0x458800 VA: 0x180459600 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref Relationship relationship, AsyncCallback callback, object object) { }

	// RVA: 0x459520 Offset: 0x458720 VA: 0x180459520 Slot: 15
	public virtual bool EndInvoke(ref Relationship relationship, IAsyncResult result) { }
}

// Namespace: 
public sealed class RelationshipManager.RefreshHandler : MulticastDelegate // TypeDefIndex: 10566
{
	// Methods

	// RVA: 0x458710 Offset: 0x457910 VA: 0x180458710
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x4240E0 Offset: 0x4232E0 VA: 0x1804240E0 Slot: 13
	public virtual void Invoke() { }

	// RVA: 0x4240B0 Offset: 0x4232B0 VA: 0x1804240B0 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class RelationshipManager.RelationshipUpdateHandler : MulticastDelegate // TypeDefIndex: 10567
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref Relationship relationship) { }

	// RVA: 0x4681E0 Offset: 0x4673E0 VA: 0x1804681E0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref Relationship relationship, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref Relationship relationship, IAsyncResult result) { }
}

// Namespace: Discord
public class RelationshipManager // TypeDefIndex: 10568
{
	// Fields
	private IntPtr MethodsPtr; // 0x10
	private object MethodsStructure; // 0x18
	[CompilerGenerated]
	private RelationshipManager.RefreshHandler OnRefresh; // 0x20
	[CompilerGenerated]
	private RelationshipManager.RelationshipUpdateHandler OnRelationshipUpdate; // 0x28

	// Properties
	private RelationshipManager.FFIMethods Methods { get; }

	// Methods

	// RVA: 0x467F90 Offset: 0x467190 VA: 0x180467F90
	private RelationshipManager.FFIMethods get_Methods() { }

	[CompilerGenerated]
	// RVA: 0x467E50 Offset: 0x467050 VA: 0x180467E50
	public void add_OnRefresh(RelationshipManager.RefreshHandler value) { }

	[CompilerGenerated]
	// RVA: 0x4680A0 Offset: 0x4672A0 VA: 0x1804680A0
	public void remove_OnRefresh(RelationshipManager.RefreshHandler value) { }

	[CompilerGenerated]
	// RVA: 0x467EF0 Offset: 0x4670F0 VA: 0x180467EF0
	public void add_OnRelationshipUpdate(RelationshipManager.RelationshipUpdateHandler value) { }

	[CompilerGenerated]
	// RVA: 0x468140 Offset: 0x467340 VA: 0x180468140
	public void remove_OnRelationshipUpdate(RelationshipManager.RelationshipUpdateHandler value) { }

	// RVA: 0x467BC0 Offset: 0x466DC0 VA: 0x180467BC0
	internal void .ctor(IntPtr ptr, IntPtr eventsPtr, ref RelationshipManager.FFIEvents events) { }

	// RVA: 0x467830 Offset: 0x466A30 VA: 0x180467830
	private void InitEvents(IntPtr eventsPtr, ref RelationshipManager.FFIEvents events) { }

	[MonoPInvokeCallback]
	// RVA: 0x4674B0 Offset: 0x4666B0 VA: 0x1804674B0
	private static bool FilterCallbackImpl(IntPtr ptr, ref Relationship relationship) { }

	// RVA: 0x467550 Offset: 0x466750 VA: 0x180467550
	public void Filter(RelationshipManager.FilterHandler callback) { }

	// RVA: 0x467410 Offset: 0x466610 VA: 0x180467410
	public int Count() { }

	// RVA: 0x467770 Offset: 0x466970 VA: 0x180467770
	public Relationship Get(long userId) { }

	// RVA: 0x4676B0 Offset: 0x4668B0 VA: 0x1804676B0
	public Relationship GetAt(uint index) { }

	[MonoPInvokeCallback]
	// RVA: 0x467A10 Offset: 0x466C10 VA: 0x180467A10
	private static void OnRefreshImpl(IntPtr ptr) { }

	[MonoPInvokeCallback]
	// RVA: 0x467AE0 Offset: 0x466CE0 VA: 0x180467AE0
	private static void OnRelationshipUpdateImpl(IntPtr ptr, ref Relationship relationship) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class LobbyManager.FFIEvents.LobbyUpdateHandler : MulticastDelegate // TypeDefIndex: 10569
{
	// Methods

	// RVA: 0x43FEE0 Offset: 0x43F0E0 VA: 0x18043FEE0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(IntPtr ptr, long lobbyId) { }

	// RVA: 0x462B50 Offset: 0x461D50 VA: 0x180462B50 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr ptr, long lobbyId, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class LobbyManager.FFIEvents.LobbyDeleteHandler : MulticastDelegate // TypeDefIndex: 10570
{
	// Methods

	// RVA: 0x45CF20 Offset: 0x45C120 VA: 0x18045CF20
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x409CF0 Offset: 0x408EF0 VA: 0x180409CF0 Slot: 13
	public virtual void Invoke(IntPtr ptr, long lobbyId, uint reason) { }

	// RVA: 0x45CDC0 Offset: 0x45BFC0 VA: 0x18045CDC0 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr ptr, long lobbyId, uint reason, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class LobbyManager.FFIEvents.MemberConnectHandler : MulticastDelegate // TypeDefIndex: 10571
{
	// Methods

	// RVA: 0x441EC0 Offset: 0x4410C0 VA: 0x180441EC0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x409CF0 Offset: 0x408EF0 VA: 0x180409CF0 Slot: 13
	public virtual void Invoke(IntPtr ptr, long lobbyId, long userId) { }

	// RVA: 0x462D00 Offset: 0x461F00 VA: 0x180462D00 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr ptr, long lobbyId, long userId, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class LobbyManager.FFIEvents.MemberUpdateHandler : MulticastDelegate // TypeDefIndex: 10572
{
	// Methods

	// RVA: 0x441EC0 Offset: 0x4410C0 VA: 0x180441EC0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x409CF0 Offset: 0x408EF0 VA: 0x180409CF0 Slot: 13
	public virtual void Invoke(IntPtr ptr, long lobbyId, long userId) { }

	// RVA: 0x463120 Offset: 0x462320 VA: 0x180463120 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr ptr, long lobbyId, long userId, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class LobbyManager.FFIEvents.MemberDisconnectHandler : MulticastDelegate // TypeDefIndex: 10573
{
	// Methods

	// RVA: 0x441EC0 Offset: 0x4410C0 VA: 0x180441EC0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x409CF0 Offset: 0x408EF0 VA: 0x180409CF0 Slot: 13
	public virtual void Invoke(IntPtr ptr, long lobbyId, long userId) { }

	// RVA: 0x462E70 Offset: 0x462070 VA: 0x180462E70 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr ptr, long lobbyId, long userId, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class LobbyManager.FFIEvents.LobbyMessageHandler : MulticastDelegate // TypeDefIndex: 10574
{
	// Methods

	// RVA: 0x4629F0 Offset: 0x461BF0 VA: 0x1804629F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x449250 Offset: 0x448450 VA: 0x180449250 Slot: 13
	public virtual void Invoke(IntPtr ptr, long lobbyId, long userId, IntPtr dataPtr, int dataLen) { }

	// RVA: 0x462860 Offset: 0x461A60 VA: 0x180462860 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr ptr, long lobbyId, long userId, IntPtr dataPtr, int dataLen, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class LobbyManager.FFIEvents.SpeakingHandler : MulticastDelegate // TypeDefIndex: 10575
{
	// Methods

	// RVA: 0x469A10 Offset: 0x468C10 VA: 0x180469A10
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x464E30 Offset: 0x464030 VA: 0x180464E30 Slot: 13
	public virtual void Invoke(IntPtr ptr, long lobbyId, long userId, bool speaking) { }

	// RVA: 0x469890 Offset: 0x468A90 VA: 0x180469890 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr ptr, long lobbyId, long userId, bool speaking, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class LobbyManager.FFIEvents.NetworkMessageHandler : MulticastDelegate // TypeDefIndex: 10576
{
	// Methods

	// RVA: 0x464A50 Offset: 0x463C50 VA: 0x180464A50
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x464990 Offset: 0x463B90 VA: 0x180464990 Slot: 13
	public virtual void Invoke(IntPtr ptr, long lobbyId, long userId, byte channelId, IntPtr dataPtr, int dataLen) { }

	// RVA: 0x464870 Offset: 0x463A70 VA: 0x180464870 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr ptr, long lobbyId, long userId, byte channelId, IntPtr dataPtr, int dataLen, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
internal struct LobbyManager.FFIEvents // TypeDefIndex: 10577
{
	// Fields
	internal LobbyManager.FFIEvents.LobbyUpdateHandler OnLobbyUpdate; // 0x0
	internal LobbyManager.FFIEvents.LobbyDeleteHandler OnLobbyDelete; // 0x8
	internal LobbyManager.FFIEvents.MemberConnectHandler OnMemberConnect; // 0x10
	internal LobbyManager.FFIEvents.MemberUpdateHandler OnMemberUpdate; // 0x18
	internal LobbyManager.FFIEvents.MemberDisconnectHandler OnMemberDisconnect; // 0x20
	internal LobbyManager.FFIEvents.LobbyMessageHandler OnLobbyMessage; // 0x28
	internal LobbyManager.FFIEvents.SpeakingHandler OnSpeaking; // 0x30
	internal LobbyManager.FFIEvents.NetworkMessageHandler OnNetworkMessage; // 0x38
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class LobbyManager.FFIMethods.GetLobbyCreateTransactionMethod : MulticastDelegate // TypeDefIndex: 10578
{
	// Methods

	// RVA: 0x445BB0 Offset: 0x444DB0 VA: 0x180445BB0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual Result Invoke(IntPtr methodsPtr, ref IntPtr transaction) { }

	// RVA: 0x45A320 Offset: 0x459520 VA: 0x18045A320 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, ref IntPtr transaction, AsyncCallback callback, object object) { }

	// RVA: 0x3FEA30 Offset: 0x3FDC30 VA: 0x1803FEA30 Slot: 15
	public virtual Result EndInvoke(ref IntPtr transaction, IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class LobbyManager.FFIMethods.GetLobbyUpdateTransactionMethod : MulticastDelegate // TypeDefIndex: 10579
{
	// Methods

	// RVA: 0x409D10 Offset: 0x408F10 VA: 0x180409D10
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x409CF0 Offset: 0x408EF0 VA: 0x180409CF0 Slot: 13
	public virtual Result Invoke(IntPtr methodsPtr, long lobbyId, ref IntPtr transaction) { }

	// RVA: 0x45A7F0 Offset: 0x4599F0 VA: 0x18045A7F0 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, long lobbyId, ref IntPtr transaction, AsyncCallback callback, object object) { }

	// RVA: 0x3FEA30 Offset: 0x3FDC30 VA: 0x1803FEA30 Slot: 15
	public virtual Result EndInvoke(ref IntPtr transaction, IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class LobbyManager.FFIMethods.GetMemberUpdateTransactionMethod : MulticastDelegate // TypeDefIndex: 10580
{
	// Methods

	// RVA: 0x45A690 Offset: 0x459890 VA: 0x18045A690
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x43DDD0 Offset: 0x43CFD0 VA: 0x18043DDD0 Slot: 13
	public virtual Result Invoke(IntPtr methodsPtr, long lobbyId, long userId, ref IntPtr transaction) { }

	// RVA: 0x45AB90 Offset: 0x459D90 VA: 0x18045AB90 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, long lobbyId, long userId, ref IntPtr transaction, AsyncCallback callback, object object) { }

	// RVA: 0x3FEA30 Offset: 0x3FDC30 VA: 0x1803FEA30 Slot: 15
	public virtual Result EndInvoke(ref IntPtr transaction, IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class LobbyManager.FFIMethods.CreateLobbyCallback : MulticastDelegate // TypeDefIndex: 10581
{
	// Methods

	// RVA: 0x4496C0 Offset: 0x4488C0 VA: 0x1804496C0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x409CF0 Offset: 0x408EF0 VA: 0x180409CF0 Slot: 13
	public virtual void Invoke(IntPtr ptr, Result result, ref Lobby lobby) { }

	// RVA: 0x458320 Offset: 0x457520 VA: 0x180458320 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr ptr, Result result, ref Lobby lobby, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref Lobby lobby, IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class LobbyManager.FFIMethods.CreateLobbyMethod : MulticastDelegate // TypeDefIndex: 10582
{
	// Methods

	// RVA: 0x43DDF0 Offset: 0x43CFF0 VA: 0x18043DDF0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x43DDD0 Offset: 0x43CFD0 VA: 0x18043DDD0 Slot: 13
	public virtual void Invoke(IntPtr methodsPtr, IntPtr transaction, IntPtr callbackData, LobbyManager.FFIMethods.CreateLobbyCallback callback) { }

	// RVA: 0x458480 Offset: 0x457680 VA: 0x180458480 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, IntPtr transaction, IntPtr callbackData, LobbyManager.FFIMethods.CreateLobbyCallback callback, AsyncCallback __callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class LobbyManager.FFIMethods.UpdateLobbyCallback : MulticastDelegate // TypeDefIndex: 10583
{
	// Methods

	// RVA: 0x43DB50 Offset: 0x43CD50 VA: 0x18043DB50
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(IntPtr ptr, Result result) { }

	// RVA: 0x46C740 Offset: 0x46B940 VA: 0x18046C740 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr ptr, Result result, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class LobbyManager.FFIMethods.UpdateLobbyMethod : MulticastDelegate // TypeDefIndex: 10584
{
	// Methods

	// RVA: 0x449270 Offset: 0x448470 VA: 0x180449270
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x449250 Offset: 0x448450 VA: 0x180449250 Slot: 13
	public virtual void Invoke(IntPtr methodsPtr, long lobbyId, IntPtr transaction, IntPtr callbackData, LobbyManager.FFIMethods.UpdateLobbyCallback callback) { }

	// RVA: 0x46C860 Offset: 0x46BA60 VA: 0x18046C860 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, long lobbyId, IntPtr transaction, IntPtr callbackData, LobbyManager.FFIMethods.UpdateLobbyCallback callback, AsyncCallback __callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class LobbyManager.FFIMethods.DeleteLobbyCallback : MulticastDelegate // TypeDefIndex: 10585
{
	// Methods

	// RVA: 0x43DB50 Offset: 0x43CD50 VA: 0x18043DB50
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(IntPtr ptr, Result result) { }

	// RVA: 0x4587B0 Offset: 0x4579B0 VA: 0x1804587B0 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr ptr, Result result, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class LobbyManager.FFIMethods.DeleteLobbyMethod : MulticastDelegate // TypeDefIndex: 10586
{
	// Methods

	// RVA: 0x43DDF0 Offset: 0x43CFF0 VA: 0x18043DDF0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x43DDD0 Offset: 0x43CFD0 VA: 0x18043DDD0 Slot: 13
	public virtual void Invoke(IntPtr methodsPtr, long lobbyId, IntPtr callbackData, LobbyManager.FFIMethods.DeleteLobbyCallback callback) { }

	// RVA: 0x4588D0 Offset: 0x457AD0 VA: 0x1804588D0 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, long lobbyId, IntPtr callbackData, LobbyManager.FFIMethods.DeleteLobbyCallback callback, AsyncCallback __callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class LobbyManager.FFIMethods.ConnectLobbyCallback : MulticastDelegate // TypeDefIndex: 10587
{
	// Methods

	// RVA: 0x4496C0 Offset: 0x4488C0 VA: 0x1804496C0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x409CF0 Offset: 0x408EF0 VA: 0x180409CF0 Slot: 13
	public virtual void Invoke(IntPtr ptr, Result result, ref Lobby lobby) { }

	// RVA: 0x457A80 Offset: 0x456C80 VA: 0x180457A80 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr ptr, Result result, ref Lobby lobby, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref Lobby lobby, IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class LobbyManager.FFIMethods.ConnectLobbyMethod : MulticastDelegate // TypeDefIndex: 10588
{
	// Methods

	// RVA: 0x449270 Offset: 0x448470 VA: 0x180449270
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x449250 Offset: 0x448450 VA: 0x180449250 Slot: 13
	public virtual void Invoke(IntPtr methodsPtr, long lobbyId, string secret, IntPtr callbackData, LobbyManager.FFIMethods.ConnectLobbyCallback callback) { }

	// RVA: 0x457C80 Offset: 0x456E80 VA: 0x180457C80 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, long lobbyId, string secret, IntPtr callbackData, LobbyManager.FFIMethods.ConnectLobbyCallback callback, AsyncCallback __callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class LobbyManager.FFIMethods.ConnectLobbyWithActivitySecretCallback : MulticastDelegate // TypeDefIndex: 10589
{
	// Methods

	// RVA: 0x4496C0 Offset: 0x4488C0 VA: 0x1804496C0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x409CF0 Offset: 0x408EF0 VA: 0x180409CF0 Slot: 13
	public virtual void Invoke(IntPtr ptr, Result result, ref Lobby lobby) { }

	// RVA: 0x457D50 Offset: 0x456F50 VA: 0x180457D50 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr ptr, Result result, ref Lobby lobby, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref Lobby lobby, IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class LobbyManager.FFIMethods.ConnectLobbyWithActivitySecretMethod : MulticastDelegate // TypeDefIndex: 10590
{
	// Methods

	// RVA: 0x43DDF0 Offset: 0x43CFF0 VA: 0x18043DDF0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x43DDD0 Offset: 0x43CFD0 VA: 0x18043DDD0 Slot: 13
	public virtual void Invoke(IntPtr methodsPtr, string activitySecret, IntPtr callbackData, LobbyManager.FFIMethods.ConnectLobbyWithActivitySecretCallback callback) { }

	// RVA: 0x457EB0 Offset: 0x4570B0 VA: 0x180457EB0 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, string activitySecret, IntPtr callbackData, LobbyManager.FFIMethods.ConnectLobbyWithActivitySecretCallback callback, AsyncCallback __callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class LobbyManager.FFIMethods.DisconnectLobbyCallback : MulticastDelegate // TypeDefIndex: 10591
{
	// Methods

	// RVA: 0x43DB50 Offset: 0x43CD50 VA: 0x18043DB50
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(IntPtr ptr, Result result) { }

	// RVA: 0x458AA0 Offset: 0x457CA0 VA: 0x180458AA0 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr ptr, Result result, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class LobbyManager.FFIMethods.DisconnectLobbyMethod : MulticastDelegate // TypeDefIndex: 10592
{
	// Methods

	// RVA: 0x43DDF0 Offset: 0x43CFF0 VA: 0x18043DDF0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x43DDD0 Offset: 0x43CFD0 VA: 0x18043DDD0 Slot: 13
	public virtual void Invoke(IntPtr methodsPtr, long lobbyId, IntPtr callbackData, LobbyManager.FFIMethods.DisconnectLobbyCallback callback) { }

	// RVA: 0x458BC0 Offset: 0x457DC0 VA: 0x180458BC0 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, long lobbyId, IntPtr callbackData, LobbyManager.FFIMethods.DisconnectLobbyCallback callback, AsyncCallback __callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class LobbyManager.FFIMethods.GetLobbyMethod : MulticastDelegate // TypeDefIndex: 10593
{
	// Methods

	// RVA: 0x409D10 Offset: 0x408F10 VA: 0x180409D10
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x409CF0 Offset: 0x408EF0 VA: 0x180409CF0 Slot: 13
	public virtual Result Invoke(IntPtr methodsPtr, long lobbyId, ref Lobby lobby) { }

	// RVA: 0x45A730 Offset: 0x459930 VA: 0x18045A730 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, long lobbyId, ref Lobby lobby, AsyncCallback callback, object object) { }

	// RVA: 0x3FEA30 Offset: 0x3FDC30 VA: 0x1803FEA30 Slot: 15
	public virtual Result EndInvoke(ref Lobby lobby, IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class LobbyManager.FFIMethods.GetLobbyActivitySecretMethod : MulticastDelegate // TypeDefIndex: 10594
{
	// Methods

	// RVA: 0x409D10 Offset: 0x408F10 VA: 0x180409D10
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x409CF0 Offset: 0x408EF0 VA: 0x180409CF0 Slot: 13
	public virtual Result Invoke(IntPtr methodsPtr, long lobbyId, StringBuilder secret) { }

	// RVA: 0x45A280 Offset: 0x459480 VA: 0x18045A280 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, long lobbyId, StringBuilder secret, AsyncCallback callback, object object) { }

	// RVA: 0x409CC0 Offset: 0x408EC0 VA: 0x180409CC0 Slot: 15
	public virtual Result EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class LobbyManager.FFIMethods.GetLobbyMetadataValueMethod : MulticastDelegate // TypeDefIndex: 10595
{
	// Methods

	// RVA: 0x45A690 Offset: 0x459890 VA: 0x18045A690
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x43DDD0 Offset: 0x43CFD0 VA: 0x18043DDD0 Slot: 13
	public virtual Result Invoke(IntPtr methodsPtr, long lobbyId, string key, StringBuilder value) { }

	// RVA: 0x45A5D0 Offset: 0x4597D0 VA: 0x18045A5D0 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, long lobbyId, string key, StringBuilder value, AsyncCallback callback, object object) { }

	// RVA: 0x409CC0 Offset: 0x408EC0 VA: 0x180409CC0 Slot: 15
	public virtual Result EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class LobbyManager.FFIMethods.GetLobbyMetadataKeyMethod : MulticastDelegate // TypeDefIndex: 10596
{
	// Methods

	// RVA: 0x451150 Offset: 0x450350 VA: 0x180451150
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x43DDD0 Offset: 0x43CFD0 VA: 0x18043DDD0 Slot: 13
	public virtual Result Invoke(IntPtr methodsPtr, long lobbyId, int index, StringBuilder key) { }

	// RVA: 0x45A500 Offset: 0x459700 VA: 0x18045A500 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, long lobbyId, int index, StringBuilder key, AsyncCallback callback, object object) { }

	// RVA: 0x409CC0 Offset: 0x408EC0 VA: 0x180409CC0 Slot: 15
	public virtual Result EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class LobbyManager.FFIMethods.LobbyMetadataCountMethod : MulticastDelegate // TypeDefIndex: 10597
{
	// Methods

	// RVA: 0x409D10 Offset: 0x408F10 VA: 0x180409D10
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x409CF0 Offset: 0x408EF0 VA: 0x180409CF0 Slot: 13
	public virtual Result Invoke(IntPtr methodsPtr, long lobbyId, ref int count) { }

	// RVA: 0x462A90 Offset: 0x461C90 VA: 0x180462A90 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, long lobbyId, ref int count, AsyncCallback callback, object object) { }

	// RVA: 0x3FEA30 Offset: 0x3FDC30 VA: 0x1803FEA30 Slot: 15
	public virtual Result EndInvoke(ref int count, IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class LobbyManager.FFIMethods.MemberCountMethod : MulticastDelegate // TypeDefIndex: 10598
{
	// Methods

	// RVA: 0x409D10 Offset: 0x408F10 VA: 0x180409D10
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x409CF0 Offset: 0x408EF0 VA: 0x180409CF0 Slot: 13
	public virtual Result Invoke(IntPtr methodsPtr, long lobbyId, ref int count) { }

	// RVA: 0x462DB0 Offset: 0x461FB0 VA: 0x180462DB0 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, long lobbyId, ref int count, AsyncCallback callback, object object) { }

	// RVA: 0x3FEA30 Offset: 0x3FDC30 VA: 0x1803FEA30 Slot: 15
	public virtual Result EndInvoke(ref int count, IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class LobbyManager.FFIMethods.GetMemberUserIdMethod : MulticastDelegate // TypeDefIndex: 10599
{
	// Methods

	// RVA: 0x451150 Offset: 0x450350 VA: 0x180451150
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x43DDD0 Offset: 0x43CFD0 VA: 0x18043DDD0 Slot: 13
	public virtual Result Invoke(IntPtr methodsPtr, long lobbyId, int index, ref long userId) { }

	// RVA: 0x45AC60 Offset: 0x459E60 VA: 0x18045AC60 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, long lobbyId, int index, ref long userId, AsyncCallback callback, object object) { }

	// RVA: 0x3FEA30 Offset: 0x3FDC30 VA: 0x1803FEA30 Slot: 15
	public virtual Result EndInvoke(ref long userId, IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class LobbyManager.FFIMethods.GetMemberUserMethod : MulticastDelegate // TypeDefIndex: 10600
{
	// Methods

	// RVA: 0x45A690 Offset: 0x459890 VA: 0x18045A690
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x43DDD0 Offset: 0x43CFD0 VA: 0x18043DDD0 Slot: 13
	public virtual Result Invoke(IntPtr methodsPtr, long lobbyId, long userId, ref User user) { }

	// RVA: 0x45AD40 Offset: 0x459F40 VA: 0x18045AD40 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, long lobbyId, long userId, ref User user, AsyncCallback callback, object object) { }

	// RVA: 0x3FEA30 Offset: 0x3FDC30 VA: 0x1803FEA30 Slot: 15
	public virtual Result EndInvoke(ref User user, IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class LobbyManager.FFIMethods.GetMemberMetadataValueMethod : MulticastDelegate // TypeDefIndex: 10601
{
	// Methods

	// RVA: 0x45AAF0 Offset: 0x459CF0 VA: 0x18045AAF0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x449250 Offset: 0x448450 VA: 0x180449250 Slot: 13
	public virtual Result Invoke(IntPtr methodsPtr, long lobbyId, long userId, string key, StringBuilder value) { }

	// RVA: 0x45AA20 Offset: 0x459C20 VA: 0x18045AA20 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, long lobbyId, long userId, string key, StringBuilder value, AsyncCallback callback, object object) { }

	// RVA: 0x409CC0 Offset: 0x408EC0 VA: 0x180409CC0 Slot: 15
	public virtual Result EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class LobbyManager.FFIMethods.GetMemberMetadataKeyMethod : MulticastDelegate // TypeDefIndex: 10602
{
	// Methods

	// RVA: 0x45A980 Offset: 0x459B80 VA: 0x18045A980
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x449250 Offset: 0x448450 VA: 0x180449250 Slot: 13
	public virtual Result Invoke(IntPtr methodsPtr, long lobbyId, long userId, int index, StringBuilder key) { }

	// RVA: 0x45A8A0 Offset: 0x459AA0 VA: 0x18045A8A0 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, long lobbyId, long userId, int index, StringBuilder key, AsyncCallback callback, object object) { }

	// RVA: 0x409CC0 Offset: 0x408EC0 VA: 0x180409CC0 Slot: 15
	public virtual Result EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class LobbyManager.FFIMethods.MemberMetadataCountMethod : MulticastDelegate // TypeDefIndex: 10603
{
	// Methods

	// RVA: 0x45A690 Offset: 0x459890 VA: 0x18045A690
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x43DDD0 Offset: 0x43CFD0 VA: 0x18043DDD0 Slot: 13
	public virtual Result Invoke(IntPtr methodsPtr, long lobbyId, long userId, ref int count) { }

	// RVA: 0x462FB0 Offset: 0x4621B0 VA: 0x180462FB0 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, long lobbyId, long userId, ref int count, AsyncCallback callback, object object) { }

	// RVA: 0x3FEA30 Offset: 0x3FDC30 VA: 0x1803FEA30 Slot: 15
	public virtual Result EndInvoke(ref int count, IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class LobbyManager.FFIMethods.UpdateMemberCallback : MulticastDelegate // TypeDefIndex: 10604
{
	// Methods

	// RVA: 0x43DB50 Offset: 0x43CD50 VA: 0x18043DB50
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(IntPtr ptr, Result result) { }

	// RVA: 0x46C940 Offset: 0x46BB40 VA: 0x18046C940 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr ptr, Result result, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class LobbyManager.FFIMethods.UpdateMemberMethod : MulticastDelegate // TypeDefIndex: 10605
{
	// Methods

	// RVA: 0x467210 Offset: 0x466410 VA: 0x180467210
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x4508F0 Offset: 0x44FAF0 VA: 0x1804508F0 Slot: 13
	public virtual void Invoke(IntPtr methodsPtr, long lobbyId, long userId, IntPtr transaction, IntPtr callbackData, LobbyManager.FFIMethods.UpdateMemberCallback callback) { }

	// RVA: 0x46CA60 Offset: 0x46BC60 VA: 0x18046CA60 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, long lobbyId, long userId, IntPtr transaction, IntPtr callbackData, LobbyManager.FFIMethods.UpdateMemberCallback callback, AsyncCallback __callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class LobbyManager.FFIMethods.SendLobbyMessageCallback : MulticastDelegate // TypeDefIndex: 10606
{
	// Methods

	// RVA: 0x43DB50 Offset: 0x43CD50 VA: 0x18043DB50
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(IntPtr ptr, Result result) { }

	// RVA: 0x4685F0 Offset: 0x4677F0 VA: 0x1804685F0 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr ptr, Result result, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class LobbyManager.FFIMethods.SendLobbyMessageMethod : MulticastDelegate // TypeDefIndex: 10607
{
	// Methods

	// RVA: 0x468810 Offset: 0x467A10 VA: 0x180468810
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x4508F0 Offset: 0x44FAF0 VA: 0x1804508F0 Slot: 13
	public virtual void Invoke(IntPtr methodsPtr, long lobbyId, byte[] data, int dataLen, IntPtr callbackData, LobbyManager.FFIMethods.SendLobbyMessageCallback callback) { }

	// RVA: 0x468710 Offset: 0x467910 VA: 0x180468710 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, long lobbyId, byte[] data, int dataLen, IntPtr callbackData, LobbyManager.FFIMethods.SendLobbyMessageCallback callback, AsyncCallback __callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class LobbyManager.FFIMethods.GetSearchQueryMethod : MulticastDelegate // TypeDefIndex: 10608
{
	// Methods

	// RVA: 0x445BB0 Offset: 0x444DB0 VA: 0x180445BB0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual Result Invoke(IntPtr methodsPtr, ref IntPtr query) { }

	// RVA: 0x45B390 Offset: 0x45A590 VA: 0x18045B390 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, ref IntPtr query, AsyncCallback callback, object object) { }

	// RVA: 0x3FEA30 Offset: 0x3FDC30 VA: 0x1803FEA30 Slot: 15
	public virtual Result EndInvoke(ref IntPtr query, IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class LobbyManager.FFIMethods.SearchCallback : MulticastDelegate // TypeDefIndex: 10609
{
	// Methods

	// RVA: 0x43DB50 Offset: 0x43CD50 VA: 0x18043DB50
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(IntPtr ptr, Result result) { }

	// RVA: 0x468420 Offset: 0x467620 VA: 0x180468420 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr ptr, Result result, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class LobbyManager.FFIMethods.SearchMethod : MulticastDelegate // TypeDefIndex: 10610
{
	// Methods

	// RVA: 0x43DDF0 Offset: 0x43CFF0 VA: 0x18043DDF0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x43DDD0 Offset: 0x43CFD0 VA: 0x18043DDD0 Slot: 13
	public virtual void Invoke(IntPtr methodsPtr, IntPtr query, IntPtr callbackData, LobbyManager.FFIMethods.SearchCallback callback) { }

	// RVA: 0x468540 Offset: 0x467740 VA: 0x180468540 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, IntPtr query, IntPtr callbackData, LobbyManager.FFIMethods.SearchCallback callback, AsyncCallback __callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class LobbyManager.FFIMethods.LobbyCountMethod : MulticastDelegate // TypeDefIndex: 10611
{
	// Methods

	// RVA: 0x43FEE0 Offset: 0x43F0E0 VA: 0x18043FEE0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(IntPtr methodsPtr, ref int count) { }

	// RVA: 0x45CD20 Offset: 0x45BF20 VA: 0x18045CD20 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, ref int count, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref int count, IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class LobbyManager.FFIMethods.GetLobbyIdMethod : MulticastDelegate // TypeDefIndex: 10612
{
	// Methods

	// RVA: 0x4585F0 Offset: 0x4577F0 VA: 0x1804585F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x409CF0 Offset: 0x408EF0 VA: 0x180409CF0 Slot: 13
	public virtual Result Invoke(IntPtr methodsPtr, int index, ref long lobbyId) { }

	// RVA: 0x45A3C0 Offset: 0x4595C0 VA: 0x18045A3C0 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, int index, ref long lobbyId, AsyncCallback callback, object object) { }

	// RVA: 0x3FEA30 Offset: 0x3FDC30 VA: 0x1803FEA30 Slot: 15
	public virtual Result EndInvoke(ref long lobbyId, IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class LobbyManager.FFIMethods.ConnectVoiceCallback : MulticastDelegate // TypeDefIndex: 10613
{
	// Methods

	// RVA: 0x43DB50 Offset: 0x43CD50 VA: 0x18043DB50
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(IntPtr ptr, Result result) { }

	// RVA: 0x458000 Offset: 0x457200 VA: 0x180458000 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr ptr, Result result, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class LobbyManager.FFIMethods.ConnectVoiceMethod : MulticastDelegate // TypeDefIndex: 10614
{
	// Methods

	// RVA: 0x43DDF0 Offset: 0x43CFF0 VA: 0x18043DDF0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x43DDD0 Offset: 0x43CFD0 VA: 0x18043DDD0 Slot: 13
	public virtual void Invoke(IntPtr methodsPtr, long lobbyId, IntPtr callbackData, LobbyManager.FFIMethods.ConnectVoiceCallback callback) { }

	// RVA: 0x458120 Offset: 0x457320 VA: 0x180458120 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, long lobbyId, IntPtr callbackData, LobbyManager.FFIMethods.ConnectVoiceCallback callback, AsyncCallback __callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class LobbyManager.FFIMethods.DisconnectVoiceCallback : MulticastDelegate // TypeDefIndex: 10615
{
	// Methods

	// RVA: 0x43DB50 Offset: 0x43CD50 VA: 0x18043DB50
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(IntPtr ptr, Result result) { }

	// RVA: 0x458D20 Offset: 0x457F20 VA: 0x180458D20 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr ptr, Result result, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class LobbyManager.FFIMethods.DisconnectVoiceMethod : MulticastDelegate // TypeDefIndex: 10616
{
	// Methods

	// RVA: 0x43DDF0 Offset: 0x43CFF0 VA: 0x18043DDF0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x43DDD0 Offset: 0x43CFD0 VA: 0x18043DDD0 Slot: 13
	public virtual void Invoke(IntPtr methodsPtr, long lobbyId, IntPtr callbackData, LobbyManager.FFIMethods.DisconnectVoiceCallback callback) { }

	// RVA: 0x458E40 Offset: 0x458040 VA: 0x180458E40 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, long lobbyId, IntPtr callbackData, LobbyManager.FFIMethods.DisconnectVoiceCallback callback, AsyncCallback __callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class LobbyManager.FFIMethods.ConnectNetworkMethod : MulticastDelegate // TypeDefIndex: 10617
{
	// Methods

	// RVA: 0x445BB0 Offset: 0x444DB0 VA: 0x180445BB0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual Result Invoke(IntPtr methodsPtr, long lobbyId) { }

	// RVA: 0x457F60 Offset: 0x457160 VA: 0x180457F60 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, long lobbyId, AsyncCallback callback, object object) { }

	// RVA: 0x409CC0 Offset: 0x408EC0 VA: 0x180409CC0 Slot: 15
	public virtual Result EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class LobbyManager.FFIMethods.DisconnectNetworkMethod : MulticastDelegate // TypeDefIndex: 10618
{
	// Methods

	// RVA: 0x445BB0 Offset: 0x444DB0 VA: 0x180445BB0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual Result Invoke(IntPtr methodsPtr, long lobbyId) { }

	// RVA: 0x458C80 Offset: 0x457E80 VA: 0x180458C80 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, long lobbyId, AsyncCallback callback, object object) { }

	// RVA: 0x409CC0 Offset: 0x408EC0 VA: 0x180409CC0 Slot: 15
	public virtual Result EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class LobbyManager.FFIMethods.FlushNetworkMethod : MulticastDelegate // TypeDefIndex: 10619
{
	// Methods

	// RVA: 0x459850 Offset: 0x458A50 VA: 0x180459850
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual Result Invoke(IntPtr methodsPtr) { }

	// RVA: 0x4598F0 Offset: 0x458AF0 VA: 0x1804598F0 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, AsyncCallback callback, object object) { }

	// RVA: 0x409CC0 Offset: 0x408EC0 VA: 0x180409CC0 Slot: 15
	public virtual Result EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class LobbyManager.FFIMethods.OpenNetworkChannelMethod : MulticastDelegate // TypeDefIndex: 10620
{
	// Methods

	// RVA: 0x464E50 Offset: 0x464050 VA: 0x180464E50
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x464E30 Offset: 0x464030 VA: 0x180464E30 Slot: 13
	public virtual Result Invoke(IntPtr methodsPtr, long lobbyId, byte channelId, bool reliable) { }

	// RVA: 0x4650C0 Offset: 0x4642C0 VA: 0x1804650C0 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, long lobbyId, byte channelId, bool reliable, AsyncCallback callback, object object) { }

	// RVA: 0x409CC0 Offset: 0x408EC0 VA: 0x180409CC0 Slot: 15
	public virtual Result EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class LobbyManager.FFIMethods.SendNetworkMessageMethod : MulticastDelegate // TypeDefIndex: 10621
{
	// Methods

	// RVA: 0x468B50 Offset: 0x467D50 VA: 0x180468B50
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x464990 Offset: 0x463B90 VA: 0x180464990 Slot: 13
	public virtual Result Invoke(IntPtr methodsPtr, long lobbyId, long userId, byte channelId, byte[] data, int dataLen) { }

	// RVA: 0x468A40 Offset: 0x467C40 VA: 0x180468A40 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, long lobbyId, long userId, byte channelId, byte[] data, int dataLen, AsyncCallback callback, object object) { }

	// RVA: 0x409CC0 Offset: 0x408EC0 VA: 0x180409CC0 Slot: 15
	public virtual Result EndInvoke(IAsyncResult result) { }
}

// Namespace: 
internal struct LobbyManager.FFIMethods // TypeDefIndex: 10622
{
	// Fields
	internal LobbyManager.FFIMethods.GetLobbyCreateTransactionMethod GetLobbyCreateTransaction; // 0x0
	internal LobbyManager.FFIMethods.GetLobbyUpdateTransactionMethod GetLobbyUpdateTransaction; // 0x8
	internal LobbyManager.FFIMethods.GetMemberUpdateTransactionMethod GetMemberUpdateTransaction; // 0x10
	internal LobbyManager.FFIMethods.CreateLobbyMethod CreateLobby; // 0x18
	internal LobbyManager.FFIMethods.UpdateLobbyMethod UpdateLobby; // 0x20
	internal LobbyManager.FFIMethods.DeleteLobbyMethod DeleteLobby; // 0x28
	internal LobbyManager.FFIMethods.ConnectLobbyMethod ConnectLobby; // 0x30
	internal LobbyManager.FFIMethods.ConnectLobbyWithActivitySecretMethod ConnectLobbyWithActivitySecret; // 0x38
	internal LobbyManager.FFIMethods.DisconnectLobbyMethod DisconnectLobby; // 0x40
	internal LobbyManager.FFIMethods.GetLobbyMethod GetLobby; // 0x48
	internal LobbyManager.FFIMethods.GetLobbyActivitySecretMethod GetLobbyActivitySecret; // 0x50
	internal LobbyManager.FFIMethods.GetLobbyMetadataValueMethod GetLobbyMetadataValue; // 0x58
	internal LobbyManager.FFIMethods.GetLobbyMetadataKeyMethod GetLobbyMetadataKey; // 0x60
	internal LobbyManager.FFIMethods.LobbyMetadataCountMethod LobbyMetadataCount; // 0x68
	internal LobbyManager.FFIMethods.MemberCountMethod MemberCount; // 0x70
	internal LobbyManager.FFIMethods.GetMemberUserIdMethod GetMemberUserId; // 0x78
	internal LobbyManager.FFIMethods.GetMemberUserMethod GetMemberUser; // 0x80
	internal LobbyManager.FFIMethods.GetMemberMetadataValueMethod GetMemberMetadataValue; // 0x88
	internal LobbyManager.FFIMethods.GetMemberMetadataKeyMethod GetMemberMetadataKey; // 0x90
	internal LobbyManager.FFIMethods.MemberMetadataCountMethod MemberMetadataCount; // 0x98
	internal LobbyManager.FFIMethods.UpdateMemberMethod UpdateMember; // 0xA0
	internal LobbyManager.FFIMethods.SendLobbyMessageMethod SendLobbyMessage; // 0xA8
	internal LobbyManager.FFIMethods.GetSearchQueryMethod GetSearchQuery; // 0xB0
	internal LobbyManager.FFIMethods.SearchMethod Search; // 0xB8
	internal LobbyManager.FFIMethods.LobbyCountMethod LobbyCount; // 0xC0
	internal LobbyManager.FFIMethods.GetLobbyIdMethod GetLobbyId; // 0xC8
	internal LobbyManager.FFIMethods.ConnectVoiceMethod ConnectVoice; // 0xD0
	internal LobbyManager.FFIMethods.DisconnectVoiceMethod DisconnectVoice; // 0xD8
	internal LobbyManager.FFIMethods.ConnectNetworkMethod ConnectNetwork; // 0xE0
	internal LobbyManager.FFIMethods.DisconnectNetworkMethod DisconnectNetwork; // 0xE8
	internal LobbyManager.FFIMethods.FlushNetworkMethod FlushNetwork; // 0xF0
	internal LobbyManager.FFIMethods.OpenNetworkChannelMethod OpenNetworkChannel; // 0xF8
	internal LobbyManager.FFIMethods.SendNetworkMessageMethod SendNetworkMessage; // 0x100
}

// Namespace: 
public sealed class LobbyManager.CreateLobbyHandler : MulticastDelegate // TypeDefIndex: 10623
{
	// Methods

	// RVA: 0x457BE0 Offset: 0x456DE0 VA: 0x180457BE0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(Result result, ref Lobby lobby) { }

	// RVA: 0x4583E0 Offset: 0x4575E0 VA: 0x1804583E0 Slot: 14
	public virtual IAsyncResult BeginInvoke(Result result, ref Lobby lobby, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref Lobby lobby, IAsyncResult result) { }
}

// Namespace: 
public sealed class LobbyManager.UpdateLobbyHandler : MulticastDelegate // TypeDefIndex: 10624
{
	// Methods

	// RVA: 0x43DC70 Offset: 0x43CE70 VA: 0x18043DC70
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(Result result) { }

	// RVA: 0x46C7E0 Offset: 0x46B9E0 VA: 0x18046C7E0 Slot: 14
	public virtual IAsyncResult BeginInvoke(Result result, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class LobbyManager.DeleteLobbyHandler : MulticastDelegate // TypeDefIndex: 10625
{
	// Methods

	// RVA: 0x43DC70 Offset: 0x43CE70 VA: 0x18043DC70
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(Result result) { }

	// RVA: 0x458850 Offset: 0x457A50 VA: 0x180458850 Slot: 14
	public virtual IAsyncResult BeginInvoke(Result result, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class LobbyManager.ConnectLobbyHandler : MulticastDelegate // TypeDefIndex: 10626
{
	// Methods

	// RVA: 0x457BE0 Offset: 0x456DE0 VA: 0x180457BE0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(Result result, ref Lobby lobby) { }

	// RVA: 0x457B40 Offset: 0x456D40 VA: 0x180457B40 Slot: 14
	public virtual IAsyncResult BeginInvoke(Result result, ref Lobby lobby, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref Lobby lobby, IAsyncResult result) { }
}

// Namespace: 
public sealed class LobbyManager.ConnectLobbyWithActivitySecretHandler : MulticastDelegate // TypeDefIndex: 10627
{
	// Methods

	// RVA: 0x457BE0 Offset: 0x456DE0 VA: 0x180457BE0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(Result result, ref Lobby lobby) { }

	// RVA: 0x457E10 Offset: 0x457010 VA: 0x180457E10 Slot: 14
	public virtual IAsyncResult BeginInvoke(Result result, ref Lobby lobby, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref Lobby lobby, IAsyncResult result) { }
}

// Namespace: 
public sealed class LobbyManager.DisconnectLobbyHandler : MulticastDelegate // TypeDefIndex: 10628
{
	// Methods

	// RVA: 0x43DC70 Offset: 0x43CE70 VA: 0x18043DC70
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(Result result) { }

	// RVA: 0x458B40 Offset: 0x457D40 VA: 0x180458B40 Slot: 14
	public virtual IAsyncResult BeginInvoke(Result result, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class LobbyManager.UpdateMemberHandler : MulticastDelegate // TypeDefIndex: 10629
{
	// Methods

	// RVA: 0x43DC70 Offset: 0x43CE70 VA: 0x18043DC70
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(Result result) { }

	// RVA: 0x46C9E0 Offset: 0x46BBE0 VA: 0x18046C9E0 Slot: 14
	public virtual IAsyncResult BeginInvoke(Result result, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class LobbyManager.SendLobbyMessageHandler : MulticastDelegate // TypeDefIndex: 10630
{
	// Methods

	// RVA: 0x43DC70 Offset: 0x43CE70 VA: 0x18043DC70
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(Result result) { }

	// RVA: 0x468690 Offset: 0x467890 VA: 0x180468690 Slot: 14
	public virtual IAsyncResult BeginInvoke(Result result, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class LobbyManager.SearchHandler : MulticastDelegate // TypeDefIndex: 10631
{
	// Methods

	// RVA: 0x43DC70 Offset: 0x43CE70 VA: 0x18043DC70
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(Result result) { }

	// RVA: 0x4684C0 Offset: 0x4676C0 VA: 0x1804684C0 Slot: 14
	public virtual IAsyncResult BeginInvoke(Result result, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class LobbyManager.ConnectVoiceHandler : MulticastDelegate // TypeDefIndex: 10632
{
	// Methods

	// RVA: 0x43DC70 Offset: 0x43CE70 VA: 0x18043DC70
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(Result result) { }

	// RVA: 0x4580A0 Offset: 0x4572A0 VA: 0x1804580A0 Slot: 14
	public virtual IAsyncResult BeginInvoke(Result result, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class LobbyManager.DisconnectVoiceHandler : MulticastDelegate // TypeDefIndex: 10633
{
	// Methods

	// RVA: 0x43DC70 Offset: 0x43CE70 VA: 0x18043DC70
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(Result result) { }

	// RVA: 0x458DC0 Offset: 0x457FC0 VA: 0x180458DC0 Slot: 14
	public virtual IAsyncResult BeginInvoke(Result result, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class LobbyManager.LobbyUpdateHandler : MulticastDelegate // TypeDefIndex: 10634
{
	// Methods

	// RVA: 0x438120 Offset: 0x437320 VA: 0x180438120
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(long lobbyId) { }

	// RVA: 0x462BF0 Offset: 0x461DF0 VA: 0x180462BF0 Slot: 14
	public virtual IAsyncResult BeginInvoke(long lobbyId, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class LobbyManager.LobbyDeleteHandler : MulticastDelegate // TypeDefIndex: 10635
{
	// Methods

	// RVA: 0x43DB50 Offset: 0x43CD50 VA: 0x18043DB50
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(long lobbyId, uint reason) { }

	// RVA: 0x45CE80 Offset: 0x45C080 VA: 0x18045CE80 Slot: 14
	public virtual IAsyncResult BeginInvoke(long lobbyId, uint reason, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class LobbyManager.MemberConnectHandler : MulticastDelegate // TypeDefIndex: 10636
{
	// Methods

	// RVA: 0x43FEE0 Offset: 0x43F0E0 VA: 0x18043FEE0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(long lobbyId, long userId) { }

	// RVA: 0x462C70 Offset: 0x461E70 VA: 0x180462C70 Slot: 14
	public virtual IAsyncResult BeginInvoke(long lobbyId, long userId, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class LobbyManager.MemberUpdateHandler : MulticastDelegate // TypeDefIndex: 10637
{
	// Methods

	// RVA: 0x43FEE0 Offset: 0x43F0E0 VA: 0x18043FEE0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(long lobbyId, long userId) { }

	// RVA: 0x463090 Offset: 0x462290 VA: 0x180463090 Slot: 14
	public virtual IAsyncResult BeginInvoke(long lobbyId, long userId, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class LobbyManager.MemberDisconnectHandler : MulticastDelegate // TypeDefIndex: 10638
{
	// Methods

	// RVA: 0x43FEE0 Offset: 0x43F0E0 VA: 0x18043FEE0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(long lobbyId, long userId) { }

	// RVA: 0x462F20 Offset: 0x462120 VA: 0x180462F20 Slot: 14
	public virtual IAsyncResult BeginInvoke(long lobbyId, long userId, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class LobbyManager.LobbyMessageHandler : MulticastDelegate // TypeDefIndex: 10639
{
	// Methods

	// RVA: 0x441EC0 Offset: 0x4410C0 VA: 0x180441EC0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x409CF0 Offset: 0x408EF0 VA: 0x180409CF0 Slot: 13
	public virtual void Invoke(long lobbyId, long userId, byte[] data) { }

	// RVA: 0x462950 Offset: 0x461B50 VA: 0x180462950 Slot: 14
	public virtual IAsyncResult BeginInvoke(long lobbyId, long userId, byte[] data, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class LobbyManager.SpeakingHandler : MulticastDelegate // TypeDefIndex: 10640
{
	// Methods

	// RVA: 0x469970 Offset: 0x468B70 VA: 0x180469970
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x409CF0 Offset: 0x408EF0 VA: 0x180409CF0 Slot: 13
	public virtual void Invoke(long lobbyId, long userId, bool speaking) { }

	// RVA: 0x4697E0 Offset: 0x4689E0 VA: 0x1804697E0 Slot: 14
	public virtual IAsyncResult BeginInvoke(long lobbyId, long userId, bool speaking, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class LobbyManager.NetworkMessageHandler : MulticastDelegate // TypeDefIndex: 10641
{
	// Methods

	// RVA: 0x4649B0 Offset: 0x463BB0 VA: 0x1804649B0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x43DDD0 Offset: 0x43CFD0 VA: 0x18043DDD0 Slot: 13
	public virtual void Invoke(long lobbyId, long userId, byte channelId, byte[] data) { }

	// RVA: 0x4647B0 Offset: 0x4639B0 VA: 0x1804647B0 Slot: 14
	public virtual IAsyncResult BeginInvoke(long lobbyId, long userId, byte channelId, byte[] data, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: Discord
public class LobbyManager // TypeDefIndex: 10642
{
	// Fields
	private IntPtr MethodsPtr; // 0x10
	private object MethodsStructure; // 0x18
	[CompilerGenerated]
	private LobbyManager.LobbyUpdateHandler OnLobbyUpdate; // 0x20
	[CompilerGenerated]
	private LobbyManager.LobbyDeleteHandler OnLobbyDelete; // 0x28
	[CompilerGenerated]
	private LobbyManager.MemberConnectHandler OnMemberConnect; // 0x30
	[CompilerGenerated]
	private LobbyManager.MemberUpdateHandler OnMemberUpdate; // 0x38
	[CompilerGenerated]
	private LobbyManager.MemberDisconnectHandler OnMemberDisconnect; // 0x40
	[CompilerGenerated]
	private LobbyManager.LobbyMessageHandler OnLobbyMessage; // 0x48
	[CompilerGenerated]
	private LobbyManager.SpeakingHandler OnSpeaking; // 0x50
	[CompilerGenerated]
	private LobbyManager.NetworkMessageHandler OnNetworkMessage; // 0x58

	// Properties
	private LobbyManager.FFIMethods Methods { get; }

	// Methods

	// RVA: 0x4621F0 Offset: 0x4613F0 VA: 0x1804621F0
	private LobbyManager.FFIMethods get_Methods() { }

	[CompilerGenerated]
	// RVA: 0x461E30 Offset: 0x461030 VA: 0x180461E30
	public void add_OnLobbyUpdate(LobbyManager.LobbyUpdateHandler value) { }

	[CompilerGenerated]
	// RVA: 0x4624A0 Offset: 0x4616A0 VA: 0x1804624A0
	public void remove_OnLobbyUpdate(LobbyManager.LobbyUpdateHandler value) { }

	[CompilerGenerated]
	// RVA: 0x461CF0 Offset: 0x460EF0 VA: 0x180461CF0
	public void add_OnLobbyDelete(LobbyManager.LobbyDeleteHandler value) { }

	[CompilerGenerated]
	// RVA: 0x462360 Offset: 0x461560 VA: 0x180462360
	public void remove_OnLobbyDelete(LobbyManager.LobbyDeleteHandler value) { }

	[CompilerGenerated]
	// RVA: 0x461ED0 Offset: 0x4610D0 VA: 0x180461ED0
	public void add_OnMemberConnect(LobbyManager.MemberConnectHandler value) { }

	[CompilerGenerated]
	// RVA: 0x462540 Offset: 0x461740 VA: 0x180462540
	public void remove_OnMemberConnect(LobbyManager.MemberConnectHandler value) { }

	[CompilerGenerated]
	// RVA: 0x462010 Offset: 0x461210 VA: 0x180462010
	public void add_OnMemberUpdate(LobbyManager.MemberUpdateHandler value) { }

	[CompilerGenerated]
	// RVA: 0x462680 Offset: 0x461880 VA: 0x180462680
	public void remove_OnMemberUpdate(LobbyManager.MemberUpdateHandler value) { }

	[CompilerGenerated]
	// RVA: 0x461F70 Offset: 0x461170 VA: 0x180461F70
	public void add_OnMemberDisconnect(LobbyManager.MemberDisconnectHandler value) { }

	[CompilerGenerated]
	// RVA: 0x4625E0 Offset: 0x4617E0 VA: 0x1804625E0
	public void remove_OnMemberDisconnect(LobbyManager.MemberDisconnectHandler value) { }

	[CompilerGenerated]
	// RVA: 0x461D90 Offset: 0x460F90 VA: 0x180461D90
	public void add_OnLobbyMessage(LobbyManager.LobbyMessageHandler value) { }

	[CompilerGenerated]
	// RVA: 0x462400 Offset: 0x461600 VA: 0x180462400
	public void remove_OnLobbyMessage(LobbyManager.LobbyMessageHandler value) { }

	[CompilerGenerated]
	// RVA: 0x462150 Offset: 0x461350 VA: 0x180462150
	public void add_OnSpeaking(LobbyManager.SpeakingHandler value) { }

	[CompilerGenerated]
	// RVA: 0x4627C0 Offset: 0x4619C0 VA: 0x1804627C0
	public void remove_OnSpeaking(LobbyManager.SpeakingHandler value) { }

	[CompilerGenerated]
	// RVA: 0x4620B0 Offset: 0x4612B0 VA: 0x1804620B0
	public void add_OnNetworkMessage(LobbyManager.NetworkMessageHandler value) { }

	[CompilerGenerated]
	// RVA: 0x462720 Offset: 0x461920 VA: 0x180462720
	public void remove_OnNetworkMessage(LobbyManager.NetworkMessageHandler value) { }

	// RVA: 0x461BF0 Offset: 0x460DF0 VA: 0x180461BF0
	internal void .ctor(IntPtr ptr, IntPtr eventsPtr, ref LobbyManager.FFIEvents events) { }

	// RVA: 0x45FA40 Offset: 0x45EC40 VA: 0x18045FA40
	private void InitEvents(IntPtr eventsPtr, ref LobbyManager.FFIEvents events) { }

	// RVA: 0x45E5A0 Offset: 0x45D7A0 VA: 0x18045E5A0
	public LobbyTransaction GetLobbyCreateTransaction() { }

	// RVA: 0x45EB20 Offset: 0x45DD20 VA: 0x18045EB20
	public LobbyTransaction GetLobbyUpdateTransaction(long lobbyId) { }

	// RVA: 0x45F0B0 Offset: 0x45E2B0 VA: 0x18045F0B0
	public LobbyMemberTransaction GetMemberUpdateTransaction(long lobbyId, long userId) { }

	[MonoPInvokeCallback]
	// RVA: 0x45D840 Offset: 0x45CA40 VA: 0x18045D840
	private static void CreateLobbyCallbackImpl(IntPtr ptr, Result result, ref Lobby lobby) { }

	// RVA: 0x45D900 Offset: 0x45CB00 VA: 0x18045D900
	public void CreateLobby(LobbyTransaction transaction, LobbyManager.CreateLobbyHandler callback) { }

	[MonoPInvokeCallback]
	// RVA: 0x4616F0 Offset: 0x4608F0 VA: 0x1804616F0
	private static void UpdateLobbyCallbackImpl(IntPtr ptr, Result result) { }

	// RVA: 0x4617A0 Offset: 0x4609A0 VA: 0x1804617A0
	public void UpdateLobby(long lobbyId, LobbyTransaction transaction, LobbyManager.UpdateLobbyHandler callback) { }

	[MonoPInvokeCallback]
	// RVA: 0x45DAC0 Offset: 0x45CCC0 VA: 0x18045DAC0
	private static void DeleteLobbyCallbackImpl(IntPtr ptr, Result result) { }

	// RVA: 0x45DB70 Offset: 0x45CD70 VA: 0x18045DB70
	public void DeleteLobby(long lobbyId, LobbyManager.DeleteLobbyHandler callback) { }

	[MonoPInvokeCallback]
	// RVA: 0x45CFC0 Offset: 0x45C1C0 VA: 0x18045CFC0
	private static void ConnectLobbyCallbackImpl(IntPtr ptr, Result result, ref Lobby lobby) { }

	// RVA: 0x45D300 Offset: 0x45C500 VA: 0x18045D300
	public void ConnectLobby(long lobbyId, string secret, LobbyManager.ConnectLobbyHandler callback) { }

	[MonoPInvokeCallback]
	// RVA: 0x45D080 Offset: 0x45C280 VA: 0x18045D080
	private static void ConnectLobbyWithActivitySecretCallbackImpl(IntPtr ptr, Result result, ref Lobby lobby) { }

	// RVA: 0x45D140 Offset: 0x45C340 VA: 0x18045D140
	public void ConnectLobbyWithActivitySecret(string activitySecret, LobbyManager.ConnectLobbyWithActivitySecretHandler callback) { }

	[MonoPInvokeCallback]
	// RVA: 0x45DD30 Offset: 0x45CF30 VA: 0x18045DD30
	private static void DisconnectLobbyCallbackImpl(IntPtr ptr, Result result) { }

	// RVA: 0x45DDE0 Offset: 0x45CFE0 VA: 0x18045DDE0
	public void DisconnectLobby(long lobbyId, LobbyManager.DisconnectLobbyHandler callback) { }

	// RVA: 0x45EC50 Offset: 0x45DE50 VA: 0x18045EC50
	public Lobby GetLobby(long lobbyId) { }

	// RVA: 0x45E430 Offset: 0x45D630 VA: 0x18045E430
	public string GetLobbyActivitySecret(long lobbyId) { }

	// RVA: 0x45E990 Offset: 0x45DB90 VA: 0x18045E990
	public string GetLobbyMetadataValue(long lobbyId, string key) { }

	// RVA: 0x45E800 Offset: 0x45DA00 VA: 0x18045E800
	public string GetLobbyMetadataKey(long lobbyId, int index) { }

	// RVA: 0x4600E0 Offset: 0x45F2E0 VA: 0x1804600E0
	public int LobbyMetadataCount(long lobbyId) { }

	// RVA: 0x460220 Offset: 0x45F420 VA: 0x180460220
	public int MemberCount(long lobbyId) { }

	// RVA: 0x45F200 Offset: 0x45E400 VA: 0x18045F200
	public long GetMemberUserId(long lobbyId, int index) { }

	// RVA: 0x45F340 Offset: 0x45E540 VA: 0x18045F340
	public User GetMemberUser(long lobbyId, long userId) { }

	// RVA: 0x45EF20 Offset: 0x45E120 VA: 0x18045EF20
	public string GetMemberMetadataValue(long lobbyId, long userId, string key) { }

	// RVA: 0x45ED90 Offset: 0x45DF90 VA: 0x18045ED90
	public string GetMemberMetadataKey(long lobbyId, long userId, int index) { }

	// RVA: 0x460360 Offset: 0x45F560 VA: 0x180460360
	public int MemberMetadataCount(long lobbyId, long userId) { }

	[MonoPInvokeCallback]
	// RVA: 0x461960 Offset: 0x460B60 VA: 0x180461960
	private static void UpdateMemberCallbackImpl(IntPtr ptr, Result result) { }

	// RVA: 0x461A10 Offset: 0x460C10 VA: 0x180461A10
	public void UpdateMember(long lobbyId, long userId, LobbyMemberTransaction transaction, LobbyManager.UpdateMemberHandler callback) { }

	[MonoPInvokeCallback]
	// RVA: 0x4610F0 Offset: 0x4602F0 VA: 0x1804610F0
	private static void SendLobbyMessageCallbackImpl(IntPtr ptr, Result result) { }

	// RVA: 0x4611A0 Offset: 0x4603A0 VA: 0x1804611A0
	public void SendLobbyMessage(long lobbyId, byte[] data, LobbyManager.SendLobbyMessageHandler callback) { }

	// RVA: 0x45F920 Offset: 0x45EB20 VA: 0x18045F920
	public LobbySearchQuery GetSearchQuery() { }

	[MonoPInvokeCallback]
	// RVA: 0x460E80 Offset: 0x460080 VA: 0x180460E80
	private static void SearchCallbackImpl(IntPtr ptr, Result result) { }

	// RVA: 0x460F30 Offset: 0x460130 VA: 0x180460F30
	public void Search(LobbySearchQuery query, LobbyManager.SearchHandler callback) { }

	// RVA: 0x460000 Offset: 0x45F200 VA: 0x180460000
	public int LobbyCount() { }

	// RVA: 0x45E6C0 Offset: 0x45D8C0 VA: 0x18045E6C0
	public long GetLobbyId(int index) { }

	[MonoPInvokeCallback]
	// RVA: 0x45D5D0 Offset: 0x45C7D0 VA: 0x18045D5D0
	private static void ConnectVoiceCallbackImpl(IntPtr ptr, Result result) { }

	// RVA: 0x45D680 Offset: 0x45C880 VA: 0x18045D680
	public void ConnectVoice(long lobbyId, LobbyManager.ConnectVoiceHandler callback) { }

	[MonoPInvokeCallback]
	// RVA: 0x45E0B0 Offset: 0x45D2B0 VA: 0x18045E0B0
	private static void DisconnectVoiceCallbackImpl(IntPtr ptr, Result result) { }

	// RVA: 0x45E160 Offset: 0x45D360 VA: 0x18045E160
	public void DisconnectVoice(long lobbyId, LobbyManager.DisconnectVoiceHandler callback) { }

	// RVA: 0x45D4C0 Offset: 0x45C6C0 VA: 0x18045D4C0
	public void ConnectNetwork(long lobbyId) { }

	// RVA: 0x45DFA0 Offset: 0x45D1A0 VA: 0x18045DFA0
	public void DisconnectNetwork(long lobbyId) { }

	// RVA: 0x45E320 Offset: 0x45D520 VA: 0x18045E320
	public void FlushNetwork() { }

	// RVA: 0x460D30 Offset: 0x45FF30 VA: 0x180460D30
	public void OpenNetworkChannel(long lobbyId, byte channelId, bool reliable) { }

	// RVA: 0x461590 Offset: 0x460790 VA: 0x180461590
	public void SendNetworkMessage(long lobbyId, long userId, byte channelId, byte[] data) { }

	[MonoPInvokeCallback]
	// RVA: 0x460700 Offset: 0x45F900 VA: 0x180460700
	private static void OnLobbyUpdateImpl(IntPtr ptr, long lobbyId) { }

	[MonoPInvokeCallback]
	// RVA: 0x4604A0 Offset: 0x45F6A0 VA: 0x1804604A0
	private static void OnLobbyDeleteImpl(IntPtr ptr, long lobbyId, uint reason) { }

	[MonoPInvokeCallback]
	// RVA: 0x4607E0 Offset: 0x45F9E0 VA: 0x1804607E0
	private static void OnMemberConnectImpl(IntPtr ptr, long lobbyId, long userId) { }

	[MonoPInvokeCallback]
	// RVA: 0x4609C0 Offset: 0x45FBC0 VA: 0x1804609C0
	private static void OnMemberUpdateImpl(IntPtr ptr, long lobbyId, long userId) { }

	[MonoPInvokeCallback]
	// RVA: 0x4608D0 Offset: 0x45FAD0 VA: 0x1804608D0
	private static void OnMemberDisconnectImpl(IntPtr ptr, long lobbyId, long userId) { }

	[MonoPInvokeCallback]
	// RVA: 0x460590 Offset: 0x45F790 VA: 0x180460590
	private static void OnLobbyMessageImpl(IntPtr ptr, long lobbyId, long userId, IntPtr dataPtr, int dataLen) { }

	[MonoPInvokeCallback]
	// RVA: 0x460C30 Offset: 0x45FE30 VA: 0x180460C30
	private static void OnSpeakingImpl(IntPtr ptr, long lobbyId, long userId, bool speaking) { }

	[MonoPInvokeCallback]
	// RVA: 0x460AB0 Offset: 0x45FCB0 VA: 0x180460AB0
	private static void OnNetworkMessageImpl(IntPtr ptr, long lobbyId, long userId, byte channelId, IntPtr dataPtr, int dataLen) { }

	// RVA: 0x45F480 Offset: 0x45E680 VA: 0x18045F480
	public IEnumerable<User> GetMemberUsers(long lobbyID) { }

	// RVA: 0x461380 Offset: 0x460580 VA: 0x180461380
	public void SendLobbyMessage(long lobbyID, string data, LobbyManager.SendLobbyMessageHandler handler) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class NetworkManager.FFIEvents.MessageHandler : MulticastDelegate // TypeDefIndex: 10643
{
	// Methods

	// RVA: 0x463370 Offset: 0x462570 VA: 0x180463370
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x449250 Offset: 0x448450 VA: 0x180449250 Slot: 13
	public virtual void Invoke(IntPtr ptr, ulong peerId, byte channelId, IntPtr dataPtr, int dataLen) { }

	// RVA: 0x4631D0 Offset: 0x4623D0 VA: 0x1804631D0 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr ptr, ulong peerId, byte channelId, IntPtr dataPtr, int dataLen, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class NetworkManager.FFIEvents.RouteUpdateHandler : MulticastDelegate // TypeDefIndex: 10644
{
	// Methods

	// RVA: 0x43FEE0 Offset: 0x43F0E0 VA: 0x18043FEE0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(IntPtr ptr, string routeData) { }

	// RVA: 0x468310 Offset: 0x467510 VA: 0x180468310 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr ptr, string routeData, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
internal struct NetworkManager.FFIEvents // TypeDefIndex: 10645
{
	// Fields
	internal NetworkManager.FFIEvents.MessageHandler OnMessage; // 0x0
	internal NetworkManager.FFIEvents.RouteUpdateHandler OnRouteUpdate; // 0x8
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class NetworkManager.FFIMethods.GetPeerIdMethod : MulticastDelegate // TypeDefIndex: 10646
{
	// Methods

	// RVA: 0x43FEE0 Offset: 0x43F0E0 VA: 0x18043FEE0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(IntPtr methodsPtr, ref ulong peerId) { }

	// RVA: 0x45B270 Offset: 0x45A470 VA: 0x18045B270 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, ref ulong peerId, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref ulong peerId, IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class NetworkManager.FFIMethods.FlushMethod : MulticastDelegate // TypeDefIndex: 10647
{
	// Methods

	// RVA: 0x459850 Offset: 0x458A50 VA: 0x180459850
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual Result Invoke(IntPtr methodsPtr) { }

	// RVA: 0x4597D0 Offset: 0x4589D0 VA: 0x1804597D0 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, AsyncCallback callback, object object) { }

	// RVA: 0x409CC0 Offset: 0x408EC0 VA: 0x180409CC0 Slot: 15
	public virtual Result EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class NetworkManager.FFIMethods.OpenPeerMethod : MulticastDelegate // TypeDefIndex: 10648
{
	// Methods

	// RVA: 0x409D10 Offset: 0x408F10 VA: 0x180409D10
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x409CF0 Offset: 0x408EF0 VA: 0x180409CF0 Slot: 13
	public virtual Result Invoke(IntPtr methodsPtr, ulong peerId, string routeData) { }

	// RVA: 0x4651A0 Offset: 0x4643A0 VA: 0x1804651A0 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, ulong peerId, string routeData, AsyncCallback callback, object object) { }

	// RVA: 0x409CC0 Offset: 0x408EC0 VA: 0x180409CC0 Slot: 15
	public virtual Result EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class NetworkManager.FFIMethods.UpdatePeerMethod : MulticastDelegate // TypeDefIndex: 10649
{
	// Methods

	// RVA: 0x409D10 Offset: 0x408F10 VA: 0x180409D10
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x409CF0 Offset: 0x408EF0 VA: 0x180409CF0 Slot: 13
	public virtual Result Invoke(IntPtr methodsPtr, ulong peerId, string routeData) { }

	// RVA: 0x46CB60 Offset: 0x46BD60 VA: 0x18046CB60 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, ulong peerId, string routeData, AsyncCallback callback, object object) { }

	// RVA: 0x409CC0 Offset: 0x408EC0 VA: 0x180409CC0 Slot: 15
	public virtual Result EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class NetworkManager.FFIMethods.ClosePeerMethod : MulticastDelegate // TypeDefIndex: 10650
{
	// Methods

	// RVA: 0x445BB0 Offset: 0x444DB0 VA: 0x180445BB0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual Result Invoke(IntPtr methodsPtr, ulong peerId) { }

	// RVA: 0x4579E0 Offset: 0x456BE0 VA: 0x1804579E0 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, ulong peerId, AsyncCallback callback, object object) { }

	// RVA: 0x409CC0 Offset: 0x408EC0 VA: 0x180409CC0 Slot: 15
	public virtual Result EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class NetworkManager.FFIMethods.OpenChannelMethod : MulticastDelegate // TypeDefIndex: 10651
{
	// Methods

	// RVA: 0x464E50 Offset: 0x464050 VA: 0x180464E50
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x464E30 Offset: 0x464030 VA: 0x180464E30 Slot: 13
	public virtual Result Invoke(IntPtr methodsPtr, ulong peerId, byte channelId, bool reliable) { }

	// RVA: 0x464D50 Offset: 0x463F50 VA: 0x180464D50 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, ulong peerId, byte channelId, bool reliable, AsyncCallback callback, object object) { }

	// RVA: 0x409CC0 Offset: 0x408EC0 VA: 0x180409CC0 Slot: 15
	public virtual Result EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class NetworkManager.FFIMethods.CloseChannelMethod : MulticastDelegate // TypeDefIndex: 10652
{
	// Methods

	// RVA: 0x457940 Offset: 0x456B40 VA: 0x180457940
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x409CF0 Offset: 0x408EF0 VA: 0x180409CF0 Slot: 13
	public virtual Result Invoke(IntPtr methodsPtr, ulong peerId, byte channelId) { }

	// RVA: 0x457880 Offset: 0x456A80 VA: 0x180457880 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, ulong peerId, byte channelId, AsyncCallback callback, object object) { }

	// RVA: 0x409CC0 Offset: 0x408EC0 VA: 0x180409CC0 Slot: 15
	public virtual Result EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class NetworkManager.FFIMethods.SendMessageMethod : MulticastDelegate // TypeDefIndex: 10653
{
	// Methods

	// RVA: 0x4689A0 Offset: 0x467BA0 VA: 0x1804689A0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x449250 Offset: 0x448450 VA: 0x180449250 Slot: 13
	public virtual Result Invoke(IntPtr methodsPtr, ulong peerId, byte channelId, byte[] data, int dataLen) { }

	// RVA: 0x4688B0 Offset: 0x467AB0 VA: 0x1804688B0 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, ulong peerId, byte channelId, byte[] data, int dataLen, AsyncCallback callback, object object) { }

	// RVA: 0x409CC0 Offset: 0x408EC0 VA: 0x180409CC0 Slot: 15
	public virtual Result EndInvoke(IAsyncResult result) { }
}

// Namespace: 
internal struct NetworkManager.FFIMethods // TypeDefIndex: 10654
{
	// Fields
	internal NetworkManager.FFIMethods.GetPeerIdMethod GetPeerId; // 0x0
	internal NetworkManager.FFIMethods.FlushMethod Flush; // 0x8
	internal NetworkManager.FFIMethods.OpenPeerMethod OpenPeer; // 0x10
	internal NetworkManager.FFIMethods.UpdatePeerMethod UpdatePeer; // 0x18
	internal NetworkManager.FFIMethods.ClosePeerMethod ClosePeer; // 0x20
	internal NetworkManager.FFIMethods.OpenChannelMethod OpenChannel; // 0x28
	internal NetworkManager.FFIMethods.CloseChannelMethod CloseChannel; // 0x30
	internal NetworkManager.FFIMethods.SendMessageMethod SendMessage; // 0x38
}

// Namespace: 
public sealed class NetworkManager.MessageHandler : MulticastDelegate // TypeDefIndex: 10655
{
	// Methods

	// RVA: 0x463410 Offset: 0x462610 VA: 0x180463410
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x409CF0 Offset: 0x408EF0 VA: 0x180409CF0 Slot: 13
	public virtual void Invoke(ulong peerId, byte channelId, byte[] data) { }

	// RVA: 0x4632D0 Offset: 0x4624D0 VA: 0x1804632D0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ulong peerId, byte channelId, byte[] data, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class NetworkManager.RouteUpdateHandler : MulticastDelegate // TypeDefIndex: 10656
{
	// Methods

	// RVA: 0x4047F0 Offset: 0x4039F0 VA: 0x1804047F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(string routeData) { }

	// RVA: 0x3FD210 Offset: 0x3FC410 VA: 0x1803FD210 Slot: 14
	public virtual IAsyncResult BeginInvoke(string routeData, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: Discord
public class NetworkManager // TypeDefIndex: 10657
{
	// Fields
	private IntPtr MethodsPtr; // 0x10
	private object MethodsStructure; // 0x18
	[CompilerGenerated]
	private NetworkManager.MessageHandler OnMessage; // 0x20
	[CompilerGenerated]
	private NetworkManager.RouteUpdateHandler OnRouteUpdate; // 0x28

	// Properties
	private NetworkManager.FFIMethods Methods { get; }

	// Methods

	// RVA: 0x464550 Offset: 0x463750 VA: 0x180464550
	private NetworkManager.FFIMethods get_Methods() { }

	[CompilerGenerated]
	// RVA: 0x464410 Offset: 0x463610 VA: 0x180464410
	public void add_OnMessage(NetworkManager.MessageHandler value) { }

	[CompilerGenerated]
	// RVA: 0x464670 Offset: 0x463870 VA: 0x180464670
	public void remove_OnMessage(NetworkManager.MessageHandler value) { }

	[CompilerGenerated]
	// RVA: 0x4644B0 Offset: 0x4636B0 VA: 0x1804644B0
	public void add_OnRouteUpdate(NetworkManager.RouteUpdateHandler value) { }

	[CompilerGenerated]
	// RVA: 0x464710 Offset: 0x463910 VA: 0x180464710
	public void remove_OnRouteUpdate(NetworkManager.RouteUpdateHandler value) { }

	// RVA: 0x464180 Offset: 0x463380 VA: 0x180464180
	internal void .ctor(IntPtr ptr, IntPtr eventsPtr, ref NetworkManager.FFIEvents events) { }

	// RVA: 0x463A30 Offset: 0x462C30 VA: 0x180463A30
	private void InitEvents(IntPtr eventsPtr, ref NetworkManager.FFIEvents events) { }

	// RVA: 0x4639C0 Offset: 0x462BC0 VA: 0x1804639C0
	public ulong GetPeerId() { }

	// RVA: 0x463920 Offset: 0x462B20 VA: 0x180463920
	public void Flush() { }

	// RVA: 0x463F40 Offset: 0x463140 VA: 0x180463F40
	public void OpenPeer(ulong peerId, string routeData) { }

	// RVA: 0x4640D0 Offset: 0x4632D0 VA: 0x1804640D0
	public void UpdatePeer(ulong peerId, string routeData) { }

	// RVA: 0x463880 Offset: 0x462A80 VA: 0x180463880
	public void ClosePeer(ulong peerId) { }

	// RVA: 0x463E70 Offset: 0x463070 VA: 0x180463E70
	public void OpenChannel(ulong peerId, byte channelId, bool reliable) { }

	// RVA: 0x4637C0 Offset: 0x4629C0 VA: 0x1804637C0
	public void CloseChannel(ulong peerId, byte channelId) { }

	// RVA: 0x463FF0 Offset: 0x4631F0 VA: 0x180463FF0
	public void SendMessage(ulong peerId, byte channelId, byte[] data) { }

	[MonoPInvokeCallback]
	// RVA: 0x463C10 Offset: 0x462E10 VA: 0x180463C10
	private static void OnMessageImpl(IntPtr ptr, ulong peerId, byte channelId, IntPtr dataPtr, int dataLen) { }

	[MonoPInvokeCallback]
	// RVA: 0x463D90 Offset: 0x462F90 VA: 0x180463D90
	private static void OnRouteUpdateImpl(IntPtr ptr, string routeData) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class OverlayManager.FFIEvents.ToggleHandler : MulticastDelegate // TypeDefIndex: 10658
{
	// Methods

	// RVA: 0x46C6A0 Offset: 0x46B8A0 VA: 0x18046C6A0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(IntPtr ptr, bool locked) { }

	// RVA: 0x46C560 Offset: 0x46B760 VA: 0x18046C560 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr ptr, bool locked, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
internal struct OverlayManager.FFIEvents // TypeDefIndex: 10659
{
	// Fields
	internal OverlayManager.FFIEvents.ToggleHandler OnToggle; // 0x0
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class OverlayManager.FFIMethods.IsEnabledMethod : MulticastDelegate // TypeDefIndex: 10660
{
	// Methods

	// RVA: 0x43FEE0 Offset: 0x43F0E0 VA: 0x18043FEE0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(IntPtr methodsPtr, ref bool enabled) { }

	// RVA: 0x45C920 Offset: 0x45BB20 VA: 0x18045C920 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, ref bool enabled, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref bool enabled, IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class OverlayManager.FFIMethods.IsLockedMethod : MulticastDelegate // TypeDefIndex: 10661
{
	// Methods

	// RVA: 0x43FEE0 Offset: 0x43F0E0 VA: 0x18043FEE0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(IntPtr methodsPtr, ref bool locked) { }

	// RVA: 0x45C9C0 Offset: 0x45BBC0 VA: 0x18045C9C0 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, ref bool locked, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref bool locked, IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class OverlayManager.FFIMethods.SetLockedCallback : MulticastDelegate // TypeDefIndex: 10662
{
	// Methods

	// RVA: 0x43DB50 Offset: 0x43CD50 VA: 0x18043DB50
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(IntPtr ptr, Result result) { }

	// RVA: 0x469370 Offset: 0x468570 VA: 0x180469370 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr ptr, Result result, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class OverlayManager.FFIMethods.SetLockedMethod : MulticastDelegate // TypeDefIndex: 10663
{
	// Methods

	// RVA: 0x469550 Offset: 0x468750 VA: 0x180469550
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x43DDD0 Offset: 0x43CFD0 VA: 0x18043DDD0 Slot: 13
	public virtual void Invoke(IntPtr methodsPtr, bool locked, IntPtr callbackData, OverlayManager.FFIMethods.SetLockedCallback callback) { }

	// RVA: 0x469490 Offset: 0x468690 VA: 0x180469490 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, bool locked, IntPtr callbackData, OverlayManager.FFIMethods.SetLockedCallback callback, AsyncCallback __callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class OverlayManager.FFIMethods.OpenActivityInviteCallback : MulticastDelegate // TypeDefIndex: 10664
{
	// Methods

	// RVA: 0x43DB50 Offset: 0x43CD50 VA: 0x18043DB50
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(IntPtr ptr, Result result) { }

	// RVA: 0x464B70 Offset: 0x463D70 VA: 0x180464B70 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr ptr, Result result, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class OverlayManager.FFIMethods.OpenActivityInviteMethod : MulticastDelegate // TypeDefIndex: 10665
{
	// Methods

	// RVA: 0x43FD10 Offset: 0x43EF10 VA: 0x18043FD10
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x43DDD0 Offset: 0x43CFD0 VA: 0x18043DDD0 Slot: 13
	public virtual void Invoke(IntPtr methodsPtr, ActivityActionType type, IntPtr callbackData, OverlayManager.FFIMethods.OpenActivityInviteCallback callback) { }

	// RVA: 0x464C90 Offset: 0x463E90 VA: 0x180464C90 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, ActivityActionType type, IntPtr callbackData, OverlayManager.FFIMethods.OpenActivityInviteCallback callback, AsyncCallback __callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class OverlayManager.FFIMethods.OpenGuildInviteCallback : MulticastDelegate // TypeDefIndex: 10666
{
	// Methods

	// RVA: 0x43DB50 Offset: 0x43CD50 VA: 0x18043DB50
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(IntPtr ptr, Result result) { }

	// RVA: 0x464EF0 Offset: 0x4640F0 VA: 0x180464EF0 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr ptr, Result result, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class OverlayManager.FFIMethods.OpenGuildInviteMethod : MulticastDelegate // TypeDefIndex: 10667
{
	// Methods

	// RVA: 0x43DDF0 Offset: 0x43CFF0 VA: 0x18043DDF0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x43DDD0 Offset: 0x43CFD0 VA: 0x18043DDD0 Slot: 13
	public virtual void Invoke(IntPtr methodsPtr, string code, IntPtr callbackData, OverlayManager.FFIMethods.OpenGuildInviteCallback callback) { }

	// RVA: 0x465010 Offset: 0x464210 VA: 0x180465010 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, string code, IntPtr callbackData, OverlayManager.FFIMethods.OpenGuildInviteCallback callback, AsyncCallback __callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class OverlayManager.FFIMethods.OpenVoiceSettingsCallback : MulticastDelegate // TypeDefIndex: 10668
{
	// Methods

	// RVA: 0x43DB50 Offset: 0x43CD50 VA: 0x18043DB50
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(IntPtr ptr, Result result) { }

	// RVA: 0x465240 Offset: 0x464440 VA: 0x180465240 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr ptr, Result result, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class OverlayManager.FFIMethods.OpenVoiceSettingsMethod : MulticastDelegate // TypeDefIndex: 10669
{
	// Methods

	// RVA: 0x441EC0 Offset: 0x4410C0 VA: 0x180441EC0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x409CF0 Offset: 0x408EF0 VA: 0x180409CF0 Slot: 13
	public virtual void Invoke(IntPtr methodsPtr, IntPtr callbackData, OverlayManager.FFIMethods.OpenVoiceSettingsCallback callback) { }

	// RVA: 0x465360 Offset: 0x464560 VA: 0x180465360 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, IntPtr callbackData, OverlayManager.FFIMethods.OpenVoiceSettingsCallback callback, AsyncCallback __callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class OverlayManager.FFIMethods.InitDrawingDxgiMethod : MulticastDelegate // TypeDefIndex: 10670
{
	// Methods

	// RVA: 0x457940 Offset: 0x456B40 VA: 0x180457940
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x409CF0 Offset: 0x408EF0 VA: 0x180409CF0 Slot: 13
	public virtual Result Invoke(IntPtr methodsPtr, IntPtr swapchain, bool useMessageForwarding) { }

	// RVA: 0x45C870 Offset: 0x45BA70 VA: 0x18045C870 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, IntPtr swapchain, bool useMessageForwarding, AsyncCallback callback, object object) { }

	// RVA: 0x409CC0 Offset: 0x408EC0 VA: 0x180409CC0 Slot: 15
	public virtual Result EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class OverlayManager.FFIMethods.OnPresentMethod : MulticastDelegate // TypeDefIndex: 10671
{
	// Methods

	// RVA: 0x438120 Offset: 0x437320 VA: 0x180438120
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(IntPtr methodsPtr) { }

	// RVA: 0x464AF0 Offset: 0x463CF0 VA: 0x180464AF0 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class OverlayManager.FFIMethods.ForwardMessageMethod : MulticastDelegate // TypeDefIndex: 10672
{
	// Methods

	// RVA: 0x43FEE0 Offset: 0x43F0E0 VA: 0x18043FEE0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(IntPtr methodsPtr, IntPtr message) { }

	// RVA: 0x459970 Offset: 0x458B70 VA: 0x180459970 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, IntPtr message, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class OverlayManager.FFIMethods.KeyEventMethod : MulticastDelegate // TypeDefIndex: 10673
{
	// Methods

	// RVA: 0x45CC80 Offset: 0x45BE80 VA: 0x18045CC80
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x43DDD0 Offset: 0x43CFD0 VA: 0x18043DDD0 Slot: 13
	public virtual void Invoke(IntPtr methodsPtr, bool down, string keyCode, KeyVariant variant) { }

	// RVA: 0x45CBB0 Offset: 0x45BDB0 VA: 0x18045CBB0 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, bool down, string keyCode, KeyVariant variant, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class OverlayManager.FFIMethods.CharEventMethod : MulticastDelegate // TypeDefIndex: 10674
{
	// Methods

	// RVA: 0x43FEE0 Offset: 0x43F0E0 VA: 0x18043FEE0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(IntPtr methodsPtr, string character) { }

	// RVA: 0x4577F0 Offset: 0x4569F0 VA: 0x1804577F0 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, string character, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class OverlayManager.FFIMethods.MouseButtonEventMethod : MulticastDelegate // TypeDefIndex: 10675
{
	// Methods

	// RVA: 0x4635D0 Offset: 0x4627D0 VA: 0x1804635D0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x4508F0 Offset: 0x44FAF0 VA: 0x1804508F0 Slot: 13
	public virtual void Invoke(IntPtr methodsPtr, byte down, int clickCount, MouseButton which, int x, int y) { }

	// RVA: 0x4634B0 Offset: 0x4626B0 VA: 0x1804634B0 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, byte down, int clickCount, MouseButton which, int x, int y, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class OverlayManager.FFIMethods.MouseMotionEventMethod : MulticastDelegate // TypeDefIndex: 10676
{
	// Methods

	// RVA: 0x463720 Offset: 0x462920 VA: 0x180463720
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x409CF0 Offset: 0x408EF0 VA: 0x180409CF0 Slot: 13
	public virtual void Invoke(IntPtr methodsPtr, int x, int y) { }

	// RVA: 0x463670 Offset: 0x462870 VA: 0x180463670 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, int x, int y, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class OverlayManager.FFIMethods.ImeCommitTextMethod : MulticastDelegate // TypeDefIndex: 10677
{
	// Methods

	// RVA: 0x43FEE0 Offset: 0x43F0E0 VA: 0x18043FEE0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(IntPtr methodsPtr, string text) { }

	// RVA: 0x45C650 Offset: 0x45B850 VA: 0x18045C650 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, string text, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class OverlayManager.FFIMethods.ImeSetCompositionMethod : MulticastDelegate // TypeDefIndex: 10678
{
	// Methods

	// RVA: 0x45C7D0 Offset: 0x45B9D0 VA: 0x18045C7D0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x449250 Offset: 0x448450 VA: 0x180449250 Slot: 13
	public virtual void Invoke(IntPtr methodsPtr, string text, ref ImeUnderline underlines, int from, int to) { }

	// RVA: 0x45C6E0 Offset: 0x45B8E0 VA: 0x18045C6E0 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, string text, ref ImeUnderline underlines, int from, int to, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref ImeUnderline underlines, IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class OverlayManager.FFIMethods.ImeCancelCompositionMethod : MulticastDelegate // TypeDefIndex: 10679
{
	// Methods

	// RVA: 0x438120 Offset: 0x437320 VA: 0x180438120
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(IntPtr methodsPtr) { }

	// RVA: 0x45C5D0 Offset: 0x45B7D0 VA: 0x18045C5D0 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class OverlayManager.FFIMethods.SetImeCompositionRangeCallbackCallback : MulticastDelegate // TypeDefIndex: 10680
{
	// Methods

	// RVA: 0x468CD0 Offset: 0x467ED0 VA: 0x180468CD0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x43DDD0 Offset: 0x43CFD0 VA: 0x18043DDD0 Slot: 13
	public virtual void Invoke(IntPtr ptr, int from, int to, ref Rect bounds) { }

	// RVA: 0x468BF0 Offset: 0x467DF0 VA: 0x180468BF0 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr ptr, int from, int to, ref Rect bounds, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref Rect bounds, IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class OverlayManager.FFIMethods.SetImeCompositionRangeCallbackMethod : MulticastDelegate // TypeDefIndex: 10681
{
	// Methods

	// RVA: 0x441EC0 Offset: 0x4410C0 VA: 0x180441EC0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x409CF0 Offset: 0x408EF0 VA: 0x180409CF0 Slot: 13
	public virtual void Invoke(IntPtr methodsPtr, IntPtr callbackData, OverlayManager.FFIMethods.SetImeCompositionRangeCallbackCallback callback) { }

	// RVA: 0x468EC0 Offset: 0x4680C0 VA: 0x180468EC0 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, IntPtr callbackData, OverlayManager.FFIMethods.SetImeCompositionRangeCallbackCallback callback, AsyncCallback __callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class OverlayManager.FFIMethods.SetImeSelectionBoundsCallbackCallback : MulticastDelegate // TypeDefIndex: 10682
{
	// Methods

	// RVA: 0x469090 Offset: 0x468290 VA: 0x180469090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x469040 Offset: 0x468240 VA: 0x180469040 Slot: 13
	public virtual void Invoke(IntPtr ptr, Rect anchor, Rect focus, bool isAnchorFirst) { }

	// RVA: 0x468F60 Offset: 0x468160 VA: 0x180468F60 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr ptr, Rect anchor, Rect focus, bool isAnchorFirst, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class OverlayManager.FFIMethods.SetImeSelectionBoundsCallbackMethod : MulticastDelegate // TypeDefIndex: 10683
{
	// Methods

	// RVA: 0x441EC0 Offset: 0x4410C0 VA: 0x180441EC0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x409CF0 Offset: 0x408EF0 VA: 0x180409CF0 Slot: 13
	public virtual void Invoke(IntPtr methodsPtr, IntPtr callbackData, OverlayManager.FFIMethods.SetImeSelectionBoundsCallbackCallback callback) { }

	// RVA: 0x4692D0 Offset: 0x4684D0 VA: 0x1804692D0 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, IntPtr callbackData, OverlayManager.FFIMethods.SetImeSelectionBoundsCallbackCallback callback, AsyncCallback __callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class OverlayManager.FFIMethods.IsPointInsideClickZoneMethod : MulticastDelegate // TypeDefIndex: 10684
{
	// Methods

	// RVA: 0x45CB10 Offset: 0x45BD10 VA: 0x18045CB10
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x409CF0 Offset: 0x408EF0 VA: 0x180409CF0 Slot: 13
	public virtual bool Invoke(IntPtr methodsPtr, int x, int y) { }

	// RVA: 0x45CA60 Offset: 0x45BC60 VA: 0x18045CA60 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, int x, int y, AsyncCallback callback, object object) { }

	// RVA: 0x409E60 Offset: 0x409060 VA: 0x180409E60 Slot: 15
	public virtual bool EndInvoke(IAsyncResult result) { }
}

// Namespace: 
internal struct OverlayManager.FFIMethods // TypeDefIndex: 10685
{
	// Fields
	internal OverlayManager.FFIMethods.IsEnabledMethod IsEnabled; // 0x0
	internal OverlayManager.FFIMethods.IsLockedMethod IsLocked; // 0x8
	internal OverlayManager.FFIMethods.SetLockedMethod SetLocked; // 0x10
	internal OverlayManager.FFIMethods.OpenActivityInviteMethod OpenActivityInvite; // 0x18
	internal OverlayManager.FFIMethods.OpenGuildInviteMethod OpenGuildInvite; // 0x20
	internal OverlayManager.FFIMethods.OpenVoiceSettingsMethod OpenVoiceSettings; // 0x28
	internal OverlayManager.FFIMethods.InitDrawingDxgiMethod InitDrawingDxgi; // 0x30
	internal OverlayManager.FFIMethods.OnPresentMethod OnPresent; // 0x38
	internal OverlayManager.FFIMethods.ForwardMessageMethod ForwardMessage; // 0x40
	internal OverlayManager.FFIMethods.KeyEventMethod KeyEvent; // 0x48
	internal OverlayManager.FFIMethods.CharEventMethod CharEvent; // 0x50
	internal OverlayManager.FFIMethods.MouseButtonEventMethod MouseButtonEvent; // 0x58
	internal OverlayManager.FFIMethods.MouseMotionEventMethod MouseMotionEvent; // 0x60
	internal OverlayManager.FFIMethods.ImeCommitTextMethod ImeCommitText; // 0x68
	internal OverlayManager.FFIMethods.ImeSetCompositionMethod ImeSetComposition; // 0x70
	internal OverlayManager.FFIMethods.ImeCancelCompositionMethod ImeCancelComposition; // 0x78
	internal OverlayManager.FFIMethods.SetImeCompositionRangeCallbackMethod SetImeCompositionRangeCallback; // 0x80
	internal OverlayManager.FFIMethods.SetImeSelectionBoundsCallbackMethod SetImeSelectionBoundsCallback; // 0x88
	internal OverlayManager.FFIMethods.IsPointInsideClickZoneMethod IsPointInsideClickZone; // 0x90
}

// Namespace: 
public sealed class OverlayManager.SetLockedHandler : MulticastDelegate // TypeDefIndex: 10686
{
	// Methods

	// RVA: 0x43DC70 Offset: 0x43CE70 VA: 0x18043DC70
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(Result result) { }

	// RVA: 0x469410 Offset: 0x468610 VA: 0x180469410 Slot: 14
	public virtual IAsyncResult BeginInvoke(Result result, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class OverlayManager.OpenActivityInviteHandler : MulticastDelegate // TypeDefIndex: 10687
{
	// Methods

	// RVA: 0x43DC70 Offset: 0x43CE70 VA: 0x18043DC70
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(Result result) { }

	// RVA: 0x464C10 Offset: 0x463E10 VA: 0x180464C10 Slot: 14
	public virtual IAsyncResult BeginInvoke(Result result, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class OverlayManager.OpenGuildInviteHandler : MulticastDelegate // TypeDefIndex: 10688
{
	// Methods

	// RVA: 0x43DC70 Offset: 0x43CE70 VA: 0x18043DC70
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(Result result) { }

	// RVA: 0x464F90 Offset: 0x464190 VA: 0x180464F90 Slot: 14
	public virtual IAsyncResult BeginInvoke(Result result, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class OverlayManager.OpenVoiceSettingsHandler : MulticastDelegate // TypeDefIndex: 10689
{
	// Methods

	// RVA: 0x43DC70 Offset: 0x43CE70 VA: 0x18043DC70
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(Result result) { }

	// RVA: 0x4652E0 Offset: 0x4644E0 VA: 0x1804652E0 Slot: 14
	public virtual IAsyncResult BeginInvoke(Result result, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class OverlayManager.SetImeCompositionRangeCallbackHandler : MulticastDelegate // TypeDefIndex: 10690
{
	// Methods

	// RVA: 0x468E20 Offset: 0x468020 VA: 0x180468E20
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x409CF0 Offset: 0x408EF0 VA: 0x180409CF0 Slot: 13
	public virtual void Invoke(int from, int to, ref Rect bounds) { }

	// RVA: 0x468D70 Offset: 0x467F70 VA: 0x180468D70 Slot: 14
	public virtual IAsyncResult BeginInvoke(int from, int to, ref Rect bounds, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref Rect bounds, IAsyncResult result) { }
}

// Namespace: 
public sealed class OverlayManager.SetImeSelectionBoundsCallbackHandler : MulticastDelegate // TypeDefIndex: 10691
{
	// Methods

	// RVA: 0x469230 Offset: 0x468430 VA: 0x180469230
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x4691F0 Offset: 0x4683F0 VA: 0x1804691F0 Slot: 13
	public virtual void Invoke(Rect anchor, Rect focus, bool isAnchorFirst) { }

	// RVA: 0x469130 Offset: 0x468330 VA: 0x180469130 Slot: 14
	public virtual IAsyncResult BeginInvoke(Rect anchor, Rect focus, bool isAnchorFirst, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class OverlayManager.ToggleHandler : MulticastDelegate // TypeDefIndex: 10692
{
	// Methods

	// RVA: 0x46C600 Offset: 0x46B800 VA: 0x18046C600
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(bool locked) { }

	// RVA: 0x46C4E0 Offset: 0x46B6E0 VA: 0x18046C4E0 Slot: 14
	public virtual IAsyncResult BeginInvoke(bool locked, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: Discord
public class OverlayManager // TypeDefIndex: 10693
{
	// Fields
	private IntPtr MethodsPtr; // 0x10
	private object MethodsStructure; // 0x18
	[CompilerGenerated]
	private OverlayManager.ToggleHandler OnToggle; // 0x20

	// Properties
	private OverlayManager.FFIMethods Methods { get; }

	// Methods

	// RVA: 0x466AF0 Offset: 0x465CF0 VA: 0x180466AF0
	private OverlayManager.FFIMethods get_Methods() { }

	[CompilerGenerated]
	// RVA: 0x466A50 Offset: 0x465C50 VA: 0x180466A50
	public void add_OnToggle(OverlayManager.ToggleHandler value) { }

	[CompilerGenerated]
	// RVA: 0x466C50 Offset: 0x465E50 VA: 0x180466C50
	public void remove_OnToggle(OverlayManager.ToggleHandler value) { }

	// RVA: 0x466870 Offset: 0x465A70 VA: 0x180466870
	internal void .ctor(IntPtr ptr, IntPtr eventsPtr, ref OverlayManager.FFIEvents events) { }

	// RVA: 0x4656C0 Offset: 0x4648C0 VA: 0x1804656C0
	private void InitEvents(IntPtr eventsPtr, ref OverlayManager.FFIEvents events) { }

	// RVA: 0x4657E0 Offset: 0x4649E0 VA: 0x1804657E0
	public bool IsEnabled() { }

	// RVA: 0x465840 Offset: 0x464A40 VA: 0x180465840
	public bool IsLocked() { }

	[MonoPInvokeCallback]
	// RVA: 0x466660 Offset: 0x465860 VA: 0x180466660
	private static void SetLockedCallbackImpl(IntPtr ptr, Result result) { }

	// RVA: 0x466710 Offset: 0x465910 VA: 0x180466710
	public void SetLocked(bool locked, OverlayManager.SetLockedHandler callback) { }

	[MonoPInvokeCallback]
	// RVA: 0x465BE0 Offset: 0x464DE0 VA: 0x180465BE0
	private static void OpenActivityInviteCallbackImpl(IntPtr ptr, Result result) { }

	// RVA: 0x465C90 Offset: 0x464E90 VA: 0x180465C90
	public void OpenActivityInvite(ActivityActionType type, OverlayManager.OpenActivityInviteHandler callback) { }

	[MonoPInvokeCallback]
	// RVA: 0x465DF0 Offset: 0x464FF0 VA: 0x180465DF0
	private static void OpenGuildInviteCallbackImpl(IntPtr ptr, Result result) { }

	// RVA: 0x465EA0 Offset: 0x4650A0 VA: 0x180465EA0
	public void OpenGuildInvite(string code, OverlayManager.OpenGuildInviteHandler callback) { }

	[MonoPInvokeCallback]
	// RVA: 0x466000 Offset: 0x465200 VA: 0x180466000
	private static void OpenVoiceSettingsCallbackImpl(IntPtr ptr, Result result) { }

	// RVA: 0x4660B0 Offset: 0x4652B0 VA: 0x1804660B0
	public void OpenVoiceSettings(OverlayManager.OpenVoiceSettingsHandler callback) { }

	// RVA: 0x465600 Offset: 0x464800 VA: 0x180465600
	public void InitDrawingDxgi(IntPtr swapchain, bool useMessageForwarding) { }

	// RVA: 0x465AB0 Offset: 0x464CB0 VA: 0x180465AB0
	public void OnPresent() { }

	// RVA: 0x465460 Offset: 0x464660 VA: 0x180465460
	public void ForwardMessage(IntPtr message) { }

	// RVA: 0x465920 Offset: 0x464B20 VA: 0x180465920
	public void KeyEvent(bool down, string keyCode, KeyVariant variant) { }

	// RVA: 0x465400 Offset: 0x464600 VA: 0x180465400
	public void CharEvent(string character) { }

	// RVA: 0x4659A0 Offset: 0x464BA0 VA: 0x1804659A0
	public void MouseButtonEvent(byte down, int clickCount, MouseButton which, int x, int y) { }

	// RVA: 0x465A40 Offset: 0x464C40 VA: 0x180465A40
	public void MouseMotionEvent(int x, int y) { }

	// RVA: 0x465510 Offset: 0x464710 VA: 0x180465510
	public void ImeCommitText(string text) { }

	// RVA: 0x465570 Offset: 0x464770 VA: 0x180465570
	public void ImeSetComposition(string text, ImeUnderline underlines, int from, int to) { }

	// RVA: 0x4654C0 Offset: 0x4646C0 VA: 0x1804654C0
	public void ImeCancelComposition() { }

	[MonoPInvokeCallback]
	// RVA: 0x466200 Offset: 0x465400 VA: 0x180466200
	private static void SetImeCompositionRangeCallbackCallbackImpl(IntPtr ptr, int from, int to, ref Rect bounds) { }

	// RVA: 0x4662D0 Offset: 0x4654D0 VA: 0x1804662D0
	public void SetImeCompositionRangeCallback(OverlayManager.SetImeCompositionRangeCallbackHandler callback) { }

	[MonoPInvokeCallback]
	// RVA: 0x466420 Offset: 0x465620 VA: 0x180466420
	private static void SetImeSelectionBoundsCallbackCallbackImpl(IntPtr ptr, Rect anchor, Rect focus, bool isAnchorFirst) { }

	// RVA: 0x466510 Offset: 0x465710 VA: 0x180466510
	public void SetImeSelectionBoundsCallback(OverlayManager.SetImeSelectionBoundsCallbackHandler callback) { }

	// RVA: 0x4658B0 Offset: 0x464AB0 VA: 0x1804658B0
	public bool IsPointInsideClickZone(int x, int y) { }

	[MonoPInvokeCallback]
	// RVA: 0x465B00 Offset: 0x464D00 VA: 0x180465B00
	private static void OnToggleImpl(IntPtr ptr, bool locked) { }
}

// Namespace: 
internal struct StorageManager.FFIEvents // TypeDefIndex: 10694
{}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class StorageManager.FFIMethods.ReadMethod : MulticastDelegate // TypeDefIndex: 10695
{
	// Methods

	// RVA: 0x45A980 Offset: 0x459B80 VA: 0x18045A980
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x449250 Offset: 0x448450 VA: 0x180449250 Slot: 13
	public virtual Result Invoke(IntPtr methodsPtr, string name, byte[] data, int dataLen, ref uint read) { }

	// RVA: 0x4672B0 Offset: 0x4664B0 VA: 0x1804672B0 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, string name, byte[] data, int dataLen, ref uint read, AsyncCallback callback, object object) { }

	// RVA: 0x3FEA30 Offset: 0x3FDC30 VA: 0x1803FEA30 Slot: 15
	public virtual Result EndInvoke(ref uint read, IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class StorageManager.FFIMethods.ReadAsyncCallback : MulticastDelegate // TypeDefIndex: 10696
{
	// Methods

	// RVA: 0x466DD0 Offset: 0x465FD0 VA: 0x180466DD0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x43DDD0 Offset: 0x43CFD0 VA: 0x18043DDD0 Slot: 13
	public virtual void Invoke(IntPtr ptr, Result result, IntPtr dataPtr, int dataLen) { }

	// RVA: 0x466CF0 Offset: 0x465EF0 VA: 0x180466CF0 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr ptr, Result result, IntPtr dataPtr, int dataLen, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class StorageManager.FFIMethods.ReadAsyncMethod : MulticastDelegate // TypeDefIndex: 10697
{
	// Methods

	// RVA: 0x43DDF0 Offset: 0x43CFF0 VA: 0x18043DDF0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x43DDD0 Offset: 0x43CFD0 VA: 0x18043DDD0 Slot: 13
	public virtual void Invoke(IntPtr methodsPtr, string name, IntPtr callbackData, StorageManager.FFIMethods.ReadAsyncCallback callback) { }

	// RVA: 0x466F00 Offset: 0x466100 VA: 0x180466F00 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, string name, IntPtr callbackData, StorageManager.FFIMethods.ReadAsyncCallback callback, AsyncCallback __callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class StorageManager.FFIMethods.ReadAsyncPartialCallback : MulticastDelegate // TypeDefIndex: 10698
{
	// Methods

	// RVA: 0x466DD0 Offset: 0x465FD0 VA: 0x180466DD0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x43DDD0 Offset: 0x43CFD0 VA: 0x18043DDD0 Slot: 13
	public virtual void Invoke(IntPtr ptr, Result result, IntPtr dataPtr, int dataLen) { }

	// RVA: 0x466FB0 Offset: 0x4661B0 VA: 0x180466FB0 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr ptr, Result result, IntPtr dataPtr, int dataLen, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class StorageManager.FFIMethods.ReadAsyncPartialMethod : MulticastDelegate // TypeDefIndex: 10699
{
	// Methods

	// RVA: 0x467210 Offset: 0x466410 VA: 0x180467210
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x4508F0 Offset: 0x44FAF0 VA: 0x1804508F0 Slot: 13
	public virtual void Invoke(IntPtr methodsPtr, string name, ulong offset, ulong length, IntPtr callbackData, StorageManager.FFIMethods.ReadAsyncPartialCallback callback) { }

	// RVA: 0x467120 Offset: 0x466320 VA: 0x180467120 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, string name, ulong offset, ulong length, IntPtr callbackData, StorageManager.FFIMethods.ReadAsyncPartialCallback callback, AsyncCallback __callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class StorageManager.FFIMethods.WriteMethod : MulticastDelegate // TypeDefIndex: 10700
{
	// Methods

	// RVA: 0x46DAC0 Offset: 0x46CCC0 VA: 0x18046DAC0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x43DDD0 Offset: 0x43CFD0 VA: 0x18043DDD0 Slot: 13
	public virtual Result Invoke(IntPtr methodsPtr, string name, byte[] data, int dataLen) { }

	// RVA: 0x46DA00 Offset: 0x46CC00 VA: 0x18046DA00 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, string name, byte[] data, int dataLen, AsyncCallback callback, object object) { }

	// RVA: 0x409CC0 Offset: 0x408EC0 VA: 0x180409CC0 Slot: 15
	public virtual Result EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class StorageManager.FFIMethods.WriteAsyncCallback : MulticastDelegate // TypeDefIndex: 10701
{
	// Methods

	// RVA: 0x43DB50 Offset: 0x43CD50 VA: 0x18043DB50
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(IntPtr ptr, Result result) { }

	// RVA: 0x46D800 Offset: 0x46CA00 VA: 0x18046D800 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr ptr, Result result, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class StorageManager.FFIMethods.WriteAsyncMethod : MulticastDelegate // TypeDefIndex: 10702
{
	// Methods

	// RVA: 0x468810 Offset: 0x467A10 VA: 0x180468810
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x4508F0 Offset: 0x44FAF0 VA: 0x1804508F0 Slot: 13
	public virtual void Invoke(IntPtr methodsPtr, string name, byte[] data, int dataLen, IntPtr callbackData, StorageManager.FFIMethods.WriteAsyncCallback callback) { }

	// RVA: 0x46D920 Offset: 0x46CB20 VA: 0x18046D920 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, string name, byte[] data, int dataLen, IntPtr callbackData, StorageManager.FFIMethods.WriteAsyncCallback callback, AsyncCallback __callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class StorageManager.FFIMethods.DeleteMethod : MulticastDelegate // TypeDefIndex: 10703
{
	// Methods

	// RVA: 0x445BB0 Offset: 0x444DB0 VA: 0x180445BB0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual Result Invoke(IntPtr methodsPtr, string name) { }

	// RVA: 0x458990 Offset: 0x457B90 VA: 0x180458990 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, string name, AsyncCallback callback, object object) { }

	// RVA: 0x409CC0 Offset: 0x408EC0 VA: 0x180409CC0 Slot: 15
	public virtual Result EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class StorageManager.FFIMethods.ExistsMethod : MulticastDelegate // TypeDefIndex: 10704
{
	// Methods

	// RVA: 0x409D10 Offset: 0x408F10 VA: 0x180409D10
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x409CF0 Offset: 0x408EF0 VA: 0x180409CF0 Slot: 13
	public virtual Result Invoke(IntPtr methodsPtr, string name, ref bool exists) { }

	// RVA: 0x458F00 Offset: 0x458100 VA: 0x180458F00 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, string name, ref bool exists, AsyncCallback callback, object object) { }

	// RVA: 0x3FEA30 Offset: 0x3FDC30 VA: 0x1803FEA30 Slot: 15
	public virtual Result EndInvoke(ref bool exists, IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class StorageManager.FFIMethods.CountMethod : MulticastDelegate // TypeDefIndex: 10705
{
	// Methods

	// RVA: 0x43FEE0 Offset: 0x43F0E0 VA: 0x18043FEE0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(IntPtr methodsPtr, ref int count) { }

	// RVA: 0x458280 Offset: 0x457480 VA: 0x180458280 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, ref int count, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref int count, IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class StorageManager.FFIMethods.StatMethod : MulticastDelegate // TypeDefIndex: 10706
{
	// Methods

	// RVA: 0x409D10 Offset: 0x408F10 VA: 0x180409D10
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x409CF0 Offset: 0x408EF0 VA: 0x180409CF0 Slot: 13
	public virtual Result Invoke(IntPtr methodsPtr, string name, ref FileStat stat) { }

	// RVA: 0x469B70 Offset: 0x468D70 VA: 0x180469B70 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, string name, ref FileStat stat, AsyncCallback callback, object object) { }

	// RVA: 0x3FEA30 Offset: 0x3FDC30 VA: 0x1803FEA30 Slot: 15
	public virtual Result EndInvoke(ref FileStat stat, IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class StorageManager.FFIMethods.StatAtMethod : MulticastDelegate // TypeDefIndex: 10707
{
	// Methods

	// RVA: 0x4585F0 Offset: 0x4577F0 VA: 0x1804585F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x409CF0 Offset: 0x408EF0 VA: 0x180409CF0 Slot: 13
	public virtual Result Invoke(IntPtr methodsPtr, int index, ref FileStat stat) { }

	// RVA: 0x469AB0 Offset: 0x468CB0 VA: 0x180469AB0 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, int index, ref FileStat stat, AsyncCallback callback, object object) { }

	// RVA: 0x3FEA30 Offset: 0x3FDC30 VA: 0x1803FEA30 Slot: 15
	public virtual Result EndInvoke(ref FileStat stat, IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class StorageManager.FFIMethods.GetPathMethod : MulticastDelegate // TypeDefIndex: 10708
{
	// Methods

	// RVA: 0x445BB0 Offset: 0x444DB0 VA: 0x180445BB0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual Result Invoke(IntPtr methodsPtr, StringBuilder path) { }

	// RVA: 0x45B1E0 Offset: 0x45A3E0 VA: 0x18045B1E0 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, StringBuilder path, AsyncCallback callback, object object) { }

	// RVA: 0x409CC0 Offset: 0x408EC0 VA: 0x180409CC0 Slot: 15
	public virtual Result EndInvoke(IAsyncResult result) { }
}

// Namespace: 
internal struct StorageManager.FFIMethods // TypeDefIndex: 10709
{
	// Fields
	internal StorageManager.FFIMethods.ReadMethod Read; // 0x0
	internal StorageManager.FFIMethods.ReadAsyncMethod ReadAsync; // 0x8
	internal StorageManager.FFIMethods.ReadAsyncPartialMethod ReadAsyncPartial; // 0x10
	internal StorageManager.FFIMethods.WriteMethod Write; // 0x18
	internal StorageManager.FFIMethods.WriteAsyncMethod WriteAsync; // 0x20
	internal StorageManager.FFIMethods.DeleteMethod Delete; // 0x28
	internal StorageManager.FFIMethods.ExistsMethod Exists; // 0x30
	internal StorageManager.FFIMethods.CountMethod Count; // 0x38
	internal StorageManager.FFIMethods.StatMethod Stat; // 0x40
	internal StorageManager.FFIMethods.StatAtMethod StatAt; // 0x48
	internal StorageManager.FFIMethods.GetPathMethod GetPath; // 0x50
}

// Namespace: 
public sealed class StorageManager.ReadAsyncHandler : MulticastDelegate // TypeDefIndex: 10710
{
	// Methods

	// RVA: 0x457BE0 Offset: 0x456DE0 VA: 0x180457BE0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(Result result, byte[] data) { }

	// RVA: 0x466E70 Offset: 0x466070 VA: 0x180466E70 Slot: 14
	public virtual IAsyncResult BeginInvoke(Result result, byte[] data, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class StorageManager.ReadAsyncPartialHandler : MulticastDelegate // TypeDefIndex: 10711
{
	// Methods

	// RVA: 0x457BE0 Offset: 0x456DE0 VA: 0x180457BE0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(Result result, byte[] data) { }

	// RVA: 0x467090 Offset: 0x466290 VA: 0x180467090 Slot: 14
	public virtual IAsyncResult BeginInvoke(Result result, byte[] data, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class StorageManager.WriteAsyncHandler : MulticastDelegate // TypeDefIndex: 10712
{
	// Methods

	// RVA: 0x43DC70 Offset: 0x43CE70 VA: 0x18043DC70
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(Result result) { }

	// RVA: 0x46D8A0 Offset: 0x46CAA0 VA: 0x18046D8A0 Slot: 14
	public virtual IAsyncResult BeginInvoke(Result result, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: Discord
public class StorageManager // TypeDefIndex: 10713
{
	// Fields
	private IntPtr MethodsPtr; // 0x10
	private object MethodsStructure; // 0x18

	// Properties
	private StorageManager.FFIMethods Methods { get; }

	// Methods

	// RVA: 0x46AD30 Offset: 0x469F30 VA: 0x18046AD30
	private StorageManager.FFIMethods get_Methods() { }

	// RVA: 0x46AC00 Offset: 0x469E00 VA: 0x18046AC00
	internal void .ctor(IntPtr ptr, IntPtr eventsPtr, ref StorageManager.FFIEvents events) { }

	// RVA: 0x46A110 Offset: 0x469310 VA: 0x18046A110
	private void InitEvents(IntPtr eventsPtr, ref StorageManager.FFIEvents events) { }

	// RVA: 0x46A6A0 Offset: 0x4698A0 VA: 0x18046A6A0
	public uint Read(string name, byte[] data) { }

	[MonoPInvokeCallback]
	// RVA: 0x46A180 Offset: 0x469380 VA: 0x18046A180
	private static void ReadAsyncCallbackImpl(IntPtr ptr, Result result, IntPtr dataPtr, int dataLen) { }

	// RVA: 0x46A540 Offset: 0x469740 VA: 0x18046A540
	public void ReadAsync(string name, StorageManager.ReadAsyncHandler callback) { }

	[MonoPInvokeCallback]
	// RVA: 0x46A2A0 Offset: 0x4694A0 VA: 0x18046A2A0
	private static void ReadAsyncPartialCallbackImpl(IntPtr ptr, Result result, IntPtr dataPtr, int dataLen) { }

	// RVA: 0x46A3C0 Offset: 0x4695C0 VA: 0x18046A3C0
	public void ReadAsyncPartial(string name, ulong offset, ulong length, StorageManager.ReadAsyncPartialHandler callback) { }

	// RVA: 0x46AB30 Offset: 0x469D30 VA: 0x18046AB30
	public void Write(string name, byte[] data) { }

	[MonoPInvokeCallback]
	// RVA: 0x46A900 Offset: 0x469B00 VA: 0x18046A900
	private static void WriteAsyncCallbackImpl(IntPtr ptr, Result result) { }

	// RVA: 0x46A9B0 Offset: 0x469BB0 VA: 0x18046A9B0
	public void WriteAsync(string name, byte[] data, StorageManager.WriteAsyncHandler callback) { }

	// RVA: 0x469C80 Offset: 0x468E80 VA: 0x180469C80
	public void Delete(string name) { }

	// RVA: 0x469D20 Offset: 0x468F20 VA: 0x180469D20
	public bool Exists(string name) { }

	// RVA: 0x469C20 Offset: 0x468E20 VA: 0x180469C20
	public int Count() { }

	// RVA: 0x46A840 Offset: 0x469A40 VA: 0x18046A840
	public FileStat Stat(string name) { }

	// RVA: 0x46A780 Offset: 0x469980 VA: 0x18046A780
	public FileStat StatAt(int index) { }

	// RVA: 0x46A010 Offset: 0x469210 VA: 0x18046A010
	public string GetPath() { }

	// RVA: 0x469DE0 Offset: 0x468FE0 VA: 0x180469DE0
	public IEnumerable<FileStat> Files() { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class StoreManager.FFIEvents.EntitlementCreateHandler : MulticastDelegate // TypeDefIndex: 10714
{
	// Methods

	// RVA: 0x43FEE0 Offset: 0x43F0E0 VA: 0x18043FEE0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(IntPtr ptr, ref Entitlement entitlement) { }

	// RVA: 0x46E980 Offset: 0x46DB80 VA: 0x18046E980 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr ptr, ref Entitlement entitlement, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref Entitlement entitlement, IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class StoreManager.FFIEvents.EntitlementDeleteHandler : MulticastDelegate // TypeDefIndex: 10715
{
	// Methods

	// RVA: 0x43FEE0 Offset: 0x43F0E0 VA: 0x18043FEE0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(IntPtr ptr, ref Entitlement entitlement) { }

	// RVA: 0x46EB40 Offset: 0x46DD40 VA: 0x18046EB40 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr ptr, ref Entitlement entitlement, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref Entitlement entitlement, IAsyncResult result) { }
}

// Namespace: 
internal struct StoreManager.FFIEvents // TypeDefIndex: 10716
{
	// Fields
	internal StoreManager.FFIEvents.EntitlementCreateHandler OnEntitlementCreate; // 0x0
	internal StoreManager.FFIEvents.EntitlementDeleteHandler OnEntitlementDelete; // 0x8
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class StoreManager.FFIMethods.FetchSkusCallback : MulticastDelegate // TypeDefIndex: 10717
{
	// Methods

	// RVA: 0x43DB50 Offset: 0x43CD50 VA: 0x18043DB50
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(IntPtr ptr, Result result) { }

	// RVA: 0x46EDA0 Offset: 0x46DFA0 VA: 0x18046EDA0 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr ptr, Result result, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class StoreManager.FFIMethods.FetchSkusMethod : MulticastDelegate // TypeDefIndex: 10718
{
	// Methods

	// RVA: 0x441EC0 Offset: 0x4410C0 VA: 0x180441EC0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x409CF0 Offset: 0x408EF0 VA: 0x180409CF0 Slot: 13
	public virtual void Invoke(IntPtr methodsPtr, IntPtr callbackData, StoreManager.FFIMethods.FetchSkusCallback callback) { }

	// RVA: 0x46EEC0 Offset: 0x46E0C0 VA: 0x18046EEC0 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, IntPtr callbackData, StoreManager.FFIMethods.FetchSkusCallback callback, AsyncCallback __callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class StoreManager.FFIMethods.CountSkusMethod : MulticastDelegate // TypeDefIndex: 10719
{
	// Methods

	// RVA: 0x43FEE0 Offset: 0x43F0E0 VA: 0x18043FEE0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(IntPtr methodsPtr, ref int count) { }

	// RVA: 0x46E840 Offset: 0x46DA40 VA: 0x18046E840 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, ref int count, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref int count, IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class StoreManager.FFIMethods.GetSkuMethod : MulticastDelegate // TypeDefIndex: 10720
{
	// Methods

	// RVA: 0x409D10 Offset: 0x408F10 VA: 0x180409D10
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x409CF0 Offset: 0x408EF0 VA: 0x180409CF0 Slot: 13
	public virtual Result Invoke(IntPtr methodsPtr, long skuId, ref Sku sku) { }

	// RVA: 0x46F4C0 Offset: 0x46E6C0 VA: 0x18046F4C0 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, long skuId, ref Sku sku, AsyncCallback callback, object object) { }

	// RVA: 0x3FEA30 Offset: 0x3FDC30 VA: 0x1803FEA30 Slot: 15
	public virtual Result EndInvoke(ref Sku sku, IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class StoreManager.FFIMethods.GetSkuAtMethod : MulticastDelegate // TypeDefIndex: 10721
{
	// Methods

	// RVA: 0x4585F0 Offset: 0x4577F0 VA: 0x1804585F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x409CF0 Offset: 0x408EF0 VA: 0x180409CF0 Slot: 13
	public virtual Result Invoke(IntPtr methodsPtr, int index, ref Sku sku) { }

	// RVA: 0x46F400 Offset: 0x46E600 VA: 0x18046F400 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, int index, ref Sku sku, AsyncCallback callback, object object) { }

	// RVA: 0x3FEA30 Offset: 0x3FDC30 VA: 0x1803FEA30 Slot: 15
	public virtual Result EndInvoke(ref Sku sku, IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class StoreManager.FFIMethods.FetchEntitlementsCallback : MulticastDelegate // TypeDefIndex: 10722
{
	// Methods

	// RVA: 0x43DB50 Offset: 0x43CD50 VA: 0x18043DB50
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(IntPtr ptr, Result result) { }

	// RVA: 0x46EBE0 Offset: 0x46DDE0 VA: 0x18046EBE0 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr ptr, Result result, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class StoreManager.FFIMethods.FetchEntitlementsMethod : MulticastDelegate // TypeDefIndex: 10723
{
	// Methods

	// RVA: 0x441EC0 Offset: 0x4410C0 VA: 0x180441EC0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x409CF0 Offset: 0x408EF0 VA: 0x180409CF0 Slot: 13
	public virtual void Invoke(IntPtr methodsPtr, IntPtr callbackData, StoreManager.FFIMethods.FetchEntitlementsCallback callback) { }

	// RVA: 0x46ED00 Offset: 0x46DF00 VA: 0x18046ED00 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, IntPtr callbackData, StoreManager.FFIMethods.FetchEntitlementsCallback callback, AsyncCallback __callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class StoreManager.FFIMethods.CountEntitlementsMethod : MulticastDelegate // TypeDefIndex: 10724
{
	// Methods

	// RVA: 0x43FEE0 Offset: 0x43F0E0 VA: 0x18043FEE0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(IntPtr methodsPtr, ref int count) { }

	// RVA: 0x46E7A0 Offset: 0x46D9A0 VA: 0x18046E7A0 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, ref int count, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref int count, IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class StoreManager.FFIMethods.GetEntitlementMethod : MulticastDelegate // TypeDefIndex: 10725
{
	// Methods

	// RVA: 0x409D10 Offset: 0x408F10 VA: 0x180409D10
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x409CF0 Offset: 0x408EF0 VA: 0x180409CF0 Slot: 13
	public virtual Result Invoke(IntPtr methodsPtr, long entitlementId, ref Entitlement entitlement) { }

	// RVA: 0x46F1E0 Offset: 0x46E3E0 VA: 0x18046F1E0 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, long entitlementId, ref Entitlement entitlement, AsyncCallback callback, object object) { }

	// RVA: 0x3FEA30 Offset: 0x3FDC30 VA: 0x1803FEA30 Slot: 15
	public virtual Result EndInvoke(ref Entitlement entitlement, IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class StoreManager.FFIMethods.GetEntitlementAtMethod : MulticastDelegate // TypeDefIndex: 10726
{
	// Methods

	// RVA: 0x4585F0 Offset: 0x4577F0 VA: 0x1804585F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x409CF0 Offset: 0x408EF0 VA: 0x180409CF0 Slot: 13
	public virtual Result Invoke(IntPtr methodsPtr, int index, ref Entitlement entitlement) { }

	// RVA: 0x46F120 Offset: 0x46E320 VA: 0x18046F120 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, int index, ref Entitlement entitlement, AsyncCallback callback, object object) { }

	// RVA: 0x3FEA30 Offset: 0x3FDC30 VA: 0x1803FEA30 Slot: 15
	public virtual Result EndInvoke(ref Entitlement entitlement, IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class StoreManager.FFIMethods.HasSkuEntitlementMethod : MulticastDelegate // TypeDefIndex: 10727
{
	// Methods

	// RVA: 0x409D10 Offset: 0x408F10 VA: 0x180409D10
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x409CF0 Offset: 0x408EF0 VA: 0x180409CF0 Slot: 13
	public virtual Result Invoke(IntPtr methodsPtr, long skuId, ref bool hasEntitlement) { }

	// RVA: 0x46F700 Offset: 0x46E900 VA: 0x18046F700 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, long skuId, ref bool hasEntitlement, AsyncCallback callback, object object) { }

	// RVA: 0x3FEA30 Offset: 0x3FDC30 VA: 0x1803FEA30 Slot: 15
	public virtual Result EndInvoke(ref bool hasEntitlement, IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class StoreManager.FFIMethods.StartPurchaseCallback : MulticastDelegate // TypeDefIndex: 10728
{
	// Methods

	// RVA: 0x43DB50 Offset: 0x43CD50 VA: 0x18043DB50
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(IntPtr ptr, Result result) { }

	// RVA: 0x470260 Offset: 0x46F460 VA: 0x180470260 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr ptr, Result result, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class StoreManager.FFIMethods.StartPurchaseMethod : MulticastDelegate // TypeDefIndex: 10729
{
	// Methods

	// RVA: 0x43DDF0 Offset: 0x43CFF0 VA: 0x18043DDF0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x43DDD0 Offset: 0x43CFD0 VA: 0x18043DDD0 Slot: 13
	public virtual void Invoke(IntPtr methodsPtr, long skuId, IntPtr callbackData, StoreManager.FFIMethods.StartPurchaseCallback callback) { }

	// RVA: 0x470380 Offset: 0x46F580 VA: 0x180470380 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, long skuId, IntPtr callbackData, StoreManager.FFIMethods.StartPurchaseCallback callback, AsyncCallback __callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
internal struct StoreManager.FFIMethods // TypeDefIndex: 10730
{
	// Fields
	internal StoreManager.FFIMethods.FetchSkusMethod FetchSkus; // 0x0
	internal StoreManager.FFIMethods.CountSkusMethod CountSkus; // 0x8
	internal StoreManager.FFIMethods.GetSkuMethod GetSku; // 0x10
	internal StoreManager.FFIMethods.GetSkuAtMethod GetSkuAt; // 0x18
	internal StoreManager.FFIMethods.FetchEntitlementsMethod FetchEntitlements; // 0x20
	internal StoreManager.FFIMethods.CountEntitlementsMethod CountEntitlements; // 0x28
	internal StoreManager.FFIMethods.GetEntitlementMethod GetEntitlement; // 0x30
	internal StoreManager.FFIMethods.GetEntitlementAtMethod GetEntitlementAt; // 0x38
	internal StoreManager.FFIMethods.HasSkuEntitlementMethod HasSkuEntitlement; // 0x40
	internal StoreManager.FFIMethods.StartPurchaseMethod StartPurchase; // 0x48
}

// Namespace: 
public sealed class StoreManager.FetchSkusHandler : MulticastDelegate // TypeDefIndex: 10731
{
	// Methods

	// RVA: 0x43DC70 Offset: 0x43CE70 VA: 0x18043DC70
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(Result result) { }

	// RVA: 0x46EE40 Offset: 0x46E040 VA: 0x18046EE40 Slot: 14
	public virtual IAsyncResult BeginInvoke(Result result, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class StoreManager.FetchEntitlementsHandler : MulticastDelegate // TypeDefIndex: 10732
{
	// Methods

	// RVA: 0x43DC70 Offset: 0x43CE70 VA: 0x18043DC70
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(Result result) { }

	// RVA: 0x46EC80 Offset: 0x46DE80 VA: 0x18046EC80 Slot: 14
	public virtual IAsyncResult BeginInvoke(Result result, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class StoreManager.StartPurchaseHandler : MulticastDelegate // TypeDefIndex: 10733
{
	// Methods

	// RVA: 0x43DC70 Offset: 0x43CE70 VA: 0x18043DC70
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(Result result) { }

	// RVA: 0x470300 Offset: 0x46F500 VA: 0x180470300 Slot: 14
	public virtual IAsyncResult BeginInvoke(Result result, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class StoreManager.EntitlementCreateHandler : MulticastDelegate // TypeDefIndex: 10734
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref Entitlement entitlement) { }

	// RVA: 0x46EA20 Offset: 0x46DC20 VA: 0x18046EA20 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref Entitlement entitlement, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref Entitlement entitlement, IAsyncResult result) { }
}

// Namespace: 
public sealed class StoreManager.EntitlementDeleteHandler : MulticastDelegate // TypeDefIndex: 10735
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref Entitlement entitlement) { }

	// RVA: 0x46EAB0 Offset: 0x46DCB0 VA: 0x18046EAB0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref Entitlement entitlement, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref Entitlement entitlement, IAsyncResult result) { }
}

// Namespace: Discord
public class StoreManager // TypeDefIndex: 10736
{
	// Fields
	private IntPtr MethodsPtr; // 0x10
	private object MethodsStructure; // 0x18
	[CompilerGenerated]
	private StoreManager.EntitlementCreateHandler OnEntitlementCreate; // 0x20
	[CompilerGenerated]
	private StoreManager.EntitlementDeleteHandler OnEntitlementDelete; // 0x28

	// Properties
	private StoreManager.FFIMethods Methods { get; }

	// Methods

	// RVA: 0x46C270 Offset: 0x46B470 VA: 0x18046C270
	private StoreManager.FFIMethods get_Methods() { }

	[CompilerGenerated]
	// RVA: 0x46C130 Offset: 0x46B330 VA: 0x18046C130
	public void add_OnEntitlementCreate(StoreManager.EntitlementCreateHandler value) { }

	[CompilerGenerated]
	// RVA: 0x46C3A0 Offset: 0x46B5A0 VA: 0x18046C3A0
	public void remove_OnEntitlementCreate(StoreManager.EntitlementCreateHandler value) { }

	[CompilerGenerated]
	// RVA: 0x46C1D0 Offset: 0x46B3D0 VA: 0x18046C1D0
	public void add_OnEntitlementDelete(StoreManager.EntitlementDeleteHandler value) { }

	[CompilerGenerated]
	// RVA: 0x46C440 Offset: 0x46B640 VA: 0x18046C440
	public void remove_OnEntitlementDelete(StoreManager.EntitlementDeleteHandler value) { }

	// RVA: 0x46BF50 Offset: 0x46B150 VA: 0x18046BF50
	internal void .ctor(IntPtr ptr, IntPtr eventsPtr, ref StoreManager.FFIEvents events) { }

	// RVA: 0x46BAD0 Offset: 0x46ACD0 VA: 0x18046BAD0
	private void InitEvents(IntPtr eventsPtr, ref StoreManager.FFIEvents events) { }

	[MonoPInvokeCallback]
	// RVA: 0x46B0B0 Offset: 0x46A2B0 VA: 0x18046B0B0
	private static void FetchSkusCallbackImpl(IntPtr ptr, Result result) { }

	// RVA: 0x46B160 Offset: 0x46A360 VA: 0x18046B160
	public void FetchSkus(StoreManager.FetchSkusHandler callback) { }

	// RVA: 0x46AEC0 Offset: 0x46A0C0 VA: 0x18046AEC0
	public int CountSkus() { }

	// RVA: 0x46B6C0 Offset: 0x46A8C0 VA: 0x18046B6C0
	public Sku GetSku(long skuId) { }

	// RVA: 0x46B5F0 Offset: 0x46A7F0 VA: 0x18046B5F0
	public Sku GetSkuAt(int index) { }

	[MonoPInvokeCallback]
	// RVA: 0x46AF20 Offset: 0x46A120 VA: 0x18046AF20
	private static void FetchEntitlementsCallbackImpl(IntPtr ptr, Result result) { }

	// RVA: 0x46AFD0 Offset: 0x46A1D0 VA: 0x18046AFD0
	public void FetchEntitlements(StoreManager.FetchEntitlementsHandler callback) { }

	// RVA: 0x46AE60 Offset: 0x46A060 VA: 0x18046AE60
	public int CountEntitlements() { }

	// RVA: 0x46B300 Offset: 0x46A500 VA: 0x18046B300
	public Entitlement GetEntitlement(long entitlementId) { }

	// RVA: 0x46B240 Offset: 0x46A440 VA: 0x18046B240
	public Entitlement GetEntitlementAt(int index) { }

	// RVA: 0x46BA10 Offset: 0x46AC10 VA: 0x18046BA10
	public bool HasSkuEntitlement(long skuId) { }

	[MonoPInvokeCallback]
	// RVA: 0x46BDA0 Offset: 0x46AFA0 VA: 0x18046BDA0
	private static void StartPurchaseCallbackImpl(IntPtr ptr, Result result) { }

	// RVA: 0x46BE50 Offset: 0x46B050 VA: 0x18046BE50
	public void StartPurchase(long skuId, StoreManager.StartPurchaseHandler callback) { }

	[MonoPInvokeCallback]
	// RVA: 0x46BBE0 Offset: 0x46ADE0 VA: 0x18046BBE0
	private static void OnEntitlementCreateImpl(IntPtr ptr, ref Entitlement entitlement) { }

	[MonoPInvokeCallback]
	// RVA: 0x46BCC0 Offset: 0x46AEC0 VA: 0x18046BCC0
	private static void OnEntitlementDeleteImpl(IntPtr ptr, ref Entitlement entitlement) { }

	// RVA: 0x46B3C0 Offset: 0x46A5C0 VA: 0x18046B3C0
	public IEnumerable<Entitlement> GetEntitlements() { }

	// RVA: 0x46B790 Offset: 0x46A990 VA: 0x18046B790
	public IEnumerable<Sku> GetSkus() { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class VoiceManager.FFIEvents.SettingsUpdateHandler : MulticastDelegate // TypeDefIndex: 10737
{
	// Methods

	// RVA: 0x438120 Offset: 0x437320 VA: 0x180438120
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(IntPtr ptr) { }

	// RVA: 0x4701E0 Offset: 0x46F3E0 VA: 0x1804701E0 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr ptr, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
internal struct VoiceManager.FFIEvents // TypeDefIndex: 10738
{
	// Fields
	internal VoiceManager.FFIEvents.SettingsUpdateHandler OnSettingsUpdate; // 0x0
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class VoiceManager.FFIMethods.GetInputModeMethod : MulticastDelegate // TypeDefIndex: 10739
{
	// Methods

	// RVA: 0x445BB0 Offset: 0x444DB0 VA: 0x180445BB0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual Result Invoke(IntPtr methodsPtr, ref InputMode inputMode) { }

	// RVA: 0x46F2A0 Offset: 0x46E4A0 VA: 0x18046F2A0 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, ref InputMode inputMode, AsyncCallback callback, object object) { }

	// RVA: 0x3FEA30 Offset: 0x3FDC30 VA: 0x1803FEA30 Slot: 15
	public virtual Result EndInvoke(ref InputMode inputMode, IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class VoiceManager.FFIMethods.SetInputModeCallback : MulticastDelegate // TypeDefIndex: 10740
{
	// Methods

	// RVA: 0x43DB50 Offset: 0x43CD50 VA: 0x18043DB50
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(IntPtr ptr, Result result) { }

	// RVA: 0x46F9C0 Offset: 0x46EBC0 VA: 0x18046F9C0 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr ptr, Result result, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class VoiceManager.FFIMethods.SetInputModeMethod : MulticastDelegate // TypeDefIndex: 10741
{
	// Methods

	// RVA: 0x46FBE0 Offset: 0x46EDE0 VA: 0x18046FBE0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x46FBA0 Offset: 0x46EDA0 VA: 0x18046FBA0 Slot: 13
	public virtual void Invoke(IntPtr methodsPtr, InputMode inputMode, IntPtr callbackData, VoiceManager.FFIMethods.SetInputModeCallback callback) { }

	// RVA: 0x46FAE0 Offset: 0x46ECE0 VA: 0x18046FAE0 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, InputMode inputMode, IntPtr callbackData, VoiceManager.FFIMethods.SetInputModeCallback callback, AsyncCallback __callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class VoiceManager.FFIMethods.IsSelfMuteMethod : MulticastDelegate // TypeDefIndex: 10742
{
	// Methods

	// RVA: 0x445BB0 Offset: 0x444DB0 VA: 0x180445BB0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual Result Invoke(IntPtr methodsPtr, ref bool mute) { }

	// RVA: 0x46F920 Offset: 0x46EB20 VA: 0x18046F920 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, ref bool mute, AsyncCallback callback, object object) { }

	// RVA: 0x3FEA30 Offset: 0x3FDC30 VA: 0x1803FEA30 Slot: 15
	public virtual Result EndInvoke(ref bool mute, IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class VoiceManager.FFIMethods.SetSelfMuteMethod : MulticastDelegate // TypeDefIndex: 10743
{
	// Methods

	// RVA: 0x450D90 Offset: 0x44FF90 VA: 0x180450D90
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual Result Invoke(IntPtr methodsPtr, bool mute) { }

	// RVA: 0x46FEA0 Offset: 0x46F0A0 VA: 0x18046FEA0 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, bool mute, AsyncCallback callback, object object) { }

	// RVA: 0x409CC0 Offset: 0x408EC0 VA: 0x180409CC0 Slot: 15
	public virtual Result EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class VoiceManager.FFIMethods.IsSelfDeafMethod : MulticastDelegate // TypeDefIndex: 10744
{
	// Methods

	// RVA: 0x445BB0 Offset: 0x444DB0 VA: 0x180445BB0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual Result Invoke(IntPtr methodsPtr, ref bool deaf) { }

	// RVA: 0x46F880 Offset: 0x46EA80 VA: 0x18046F880 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, ref bool deaf, AsyncCallback callback, object object) { }

	// RVA: 0x3FEA30 Offset: 0x3FDC30 VA: 0x1803FEA30 Slot: 15
	public virtual Result EndInvoke(ref bool deaf, IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class VoiceManager.FFIMethods.SetSelfDeafMethod : MulticastDelegate // TypeDefIndex: 10745
{
	// Methods

	// RVA: 0x450D90 Offset: 0x44FF90 VA: 0x180450D90
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual Result Invoke(IntPtr methodsPtr, bool deaf) { }

	// RVA: 0x46FE00 Offset: 0x46F000 VA: 0x18046FE00 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, bool deaf, AsyncCallback callback, object object) { }

	// RVA: 0x409CC0 Offset: 0x408EC0 VA: 0x180409CC0 Slot: 15
	public virtual Result EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class VoiceManager.FFIMethods.IsLocalMuteMethod : MulticastDelegate // TypeDefIndex: 10746
{
	// Methods

	// RVA: 0x409D10 Offset: 0x408F10 VA: 0x180409D10
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x409CF0 Offset: 0x408EF0 VA: 0x180409CF0 Slot: 13
	public virtual Result Invoke(IntPtr methodsPtr, long userId, ref bool mute) { }

	// RVA: 0x46F7C0 Offset: 0x46E9C0 VA: 0x18046F7C0 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, long userId, ref bool mute, AsyncCallback callback, object object) { }

	// RVA: 0x3FEA30 Offset: 0x3FDC30 VA: 0x1803FEA30 Slot: 15
	public virtual Result EndInvoke(ref bool mute, IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class VoiceManager.FFIMethods.SetLocalMuteMethod : MulticastDelegate // TypeDefIndex: 10747
{
	// Methods

	// RVA: 0x457940 Offset: 0x456B40 VA: 0x180457940
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x409CF0 Offset: 0x408EF0 VA: 0x180409CF0 Slot: 13
	public virtual Result Invoke(IntPtr methodsPtr, long userId, bool mute) { }

	// RVA: 0x46FC80 Offset: 0x46EE80 VA: 0x18046FC80 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, long userId, bool mute, AsyncCallback callback, object object) { }

	// RVA: 0x409CC0 Offset: 0x408EC0 VA: 0x180409CC0 Slot: 15
	public virtual Result EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class VoiceManager.FFIMethods.GetLocalVolumeMethod : MulticastDelegate // TypeDefIndex: 10748
{
	// Methods

	// RVA: 0x409D10 Offset: 0x408F10 VA: 0x180409D10
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x409CF0 Offset: 0x408EF0 VA: 0x180409CF0 Slot: 13
	public virtual Result Invoke(IntPtr methodsPtr, long userId, ref byte volume) { }

	// RVA: 0x46F340 Offset: 0x46E540 VA: 0x18046F340 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, long userId, ref byte volume, AsyncCallback callback, object object) { }

	// RVA: 0x3FEA30 Offset: 0x3FDC30 VA: 0x1803FEA30 Slot: 15
	public virtual Result EndInvoke(ref byte volume, IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class VoiceManager.FFIMethods.SetLocalVolumeMethod : MulticastDelegate // TypeDefIndex: 10749
{
	// Methods

	// RVA: 0x457940 Offset: 0x456B40 VA: 0x180457940
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x409CF0 Offset: 0x408EF0 VA: 0x180409CF0 Slot: 13
	public virtual Result Invoke(IntPtr methodsPtr, long userId, byte volume) { }

	// RVA: 0x46FD40 Offset: 0x46EF40 VA: 0x18046FD40 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, long userId, byte volume, AsyncCallback callback, object object) { }

	// RVA: 0x409CC0 Offset: 0x408EC0 VA: 0x180409CC0 Slot: 15
	public virtual Result EndInvoke(IAsyncResult result) { }
}

// Namespace: 
internal struct VoiceManager.FFIMethods // TypeDefIndex: 10750
{
	// Fields
	internal VoiceManager.FFIMethods.GetInputModeMethod GetInputMode; // 0x0
	internal VoiceManager.FFIMethods.SetInputModeMethod SetInputMode; // 0x8
	internal VoiceManager.FFIMethods.IsSelfMuteMethod IsSelfMute; // 0x10
	internal VoiceManager.FFIMethods.SetSelfMuteMethod SetSelfMute; // 0x18
	internal VoiceManager.FFIMethods.IsSelfDeafMethod IsSelfDeaf; // 0x20
	internal VoiceManager.FFIMethods.SetSelfDeafMethod SetSelfDeaf; // 0x28
	internal VoiceManager.FFIMethods.IsLocalMuteMethod IsLocalMute; // 0x30
	internal VoiceManager.FFIMethods.SetLocalMuteMethod SetLocalMute; // 0x38
	internal VoiceManager.FFIMethods.GetLocalVolumeMethod GetLocalVolume; // 0x40
	internal VoiceManager.FFIMethods.SetLocalVolumeMethod SetLocalVolume; // 0x48
}

// Namespace: 
public sealed class VoiceManager.SetInputModeHandler : MulticastDelegate // TypeDefIndex: 10751
{
	// Methods

	// RVA: 0x43DC70 Offset: 0x43CE70 VA: 0x18043DC70
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(Result result) { }

	// RVA: 0x46FA60 Offset: 0x46EC60 VA: 0x18046FA60 Slot: 14
	public virtual IAsyncResult BeginInvoke(Result result, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class VoiceManager.SettingsUpdateHandler : MulticastDelegate // TypeDefIndex: 10752
{
	// Methods

	// RVA: 0x458710 Offset: 0x457910 VA: 0x180458710
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x4240E0 Offset: 0x4232E0 VA: 0x1804240E0 Slot: 13
	public virtual void Invoke() { }

	// RVA: 0x4240B0 Offset: 0x4232B0 VA: 0x1804240B0 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: Discord
public class VoiceManager // TypeDefIndex: 10753
{
	// Fields
	private IntPtr MethodsPtr; // 0x10
	private object MethodsStructure; // 0x18
	[CompilerGenerated]
	private VoiceManager.SettingsUpdateHandler OnSettingsUpdate; // 0x20

	// Properties
	private VoiceManager.FFIMethods Methods { get; }

	// Methods

	// RVA: 0x471240 Offset: 0x470440 VA: 0x180471240
	private VoiceManager.FFIMethods get_Methods() { }

	[CompilerGenerated]
	// RVA: 0x4711A0 Offset: 0x4703A0 VA: 0x1804711A0
	public void add_OnSettingsUpdate(VoiceManager.SettingsUpdateHandler value) { }

	[CompilerGenerated]
	// RVA: 0x471370 Offset: 0x470570 VA: 0x180471370
	public void remove_OnSettingsUpdate(VoiceManager.SettingsUpdateHandler value) { }

	// RVA: 0x470FC0 Offset: 0x4701C0 VA: 0x180470FC0
	internal void .ctor(IntPtr ptr, IntPtr eventsPtr, ref VoiceManager.FFIEvents events) { }

	// RVA: 0x4706D0 Offset: 0x46F8D0 VA: 0x1804706D0
	private void InitEvents(IntPtr eventsPtr, ref VoiceManager.FFIEvents events) { }

	// RVA: 0x470570 Offset: 0x46F770 VA: 0x180470570
	public InputMode GetInputMode() { }

	[MonoPInvokeCallback]
	// RVA: 0x470AE0 Offset: 0x46FCE0 VA: 0x180470AE0
	private static void SetInputModeCallbackImpl(IntPtr ptr, Result result) { }

	// RVA: 0x470B90 Offset: 0x46FD90 VA: 0x180470B90
	public void SetInputMode(InputMode inputMode, VoiceManager.SetInputModeHandler callback) { }

	// RVA: 0x470960 Offset: 0x46FB60 VA: 0x180470960
	public bool IsSelfMute() { }

	// RVA: 0x470F20 Offset: 0x470120 VA: 0x180470F20
	public void SetSelfMute(bool mute) { }

	// RVA: 0x4708B0 Offset: 0x46FAB0 VA: 0x1804708B0
	public bool IsSelfDeaf() { }

	// RVA: 0x470E80 Offset: 0x470080 VA: 0x180470E80
	public void SetSelfDeaf(bool deaf) { }

	// RVA: 0x4707F0 Offset: 0x46F9F0 VA: 0x1804707F0
	public bool IsLocalMute(long userId) { }

	// RVA: 0x470D00 Offset: 0x46FF00 VA: 0x180470D00
	public void SetLocalMute(long userId, bool mute) { }

	// RVA: 0x470610 Offset: 0x46F810 VA: 0x180470610
	public byte GetLocalVolume(long userId) { }

	// RVA: 0x470DC0 Offset: 0x46FFC0 VA: 0x180470DC0
	public void SetLocalVolume(long userId, byte volume) { }

	[MonoPInvokeCallback]
	// RVA: 0x470A10 Offset: 0x46FC10 VA: 0x180470A10
	private static void OnSettingsUpdateImpl(IntPtr ptr) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class AchievementManager.FFIEvents.UserAchievementUpdateHandler : MulticastDelegate // TypeDefIndex: 10754
{
	// Methods

	// RVA: 0x43FEE0 Offset: 0x43F0E0 VA: 0x18043FEE0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(IntPtr ptr, ref UserAchievement userAchievement) { }

	// RVA: 0x4704D0 Offset: 0x46F6D0 VA: 0x1804704D0 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr ptr, ref UserAchievement userAchievement, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref UserAchievement userAchievement, IAsyncResult result) { }
}

// Namespace: 
internal struct AchievementManager.FFIEvents // TypeDefIndex: 10755
{
	// Fields
	internal AchievementManager.FFIEvents.UserAchievementUpdateHandler OnUserAchievementUpdate; // 0x0
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class AchievementManager.FFIMethods.SetUserAchievementCallback : MulticastDelegate // TypeDefIndex: 10756
{
	// Methods

	// RVA: 0x43DB50 Offset: 0x43CD50 VA: 0x18043DB50
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(IntPtr ptr, Result result) { }

	// RVA: 0x46FF40 Offset: 0x46F140 VA: 0x18046FF40 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr ptr, Result result, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class AchievementManager.FFIMethods.SetUserAchievementMethod : MulticastDelegate // TypeDefIndex: 10757
{
	// Methods

	// RVA: 0x470140 Offset: 0x46F340 VA: 0x180470140
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x449250 Offset: 0x448450 VA: 0x180449250 Slot: 13
	public virtual void Invoke(IntPtr methodsPtr, long achievementId, byte percentComplete, IntPtr callbackData, AchievementManager.FFIMethods.SetUserAchievementCallback callback) { }

	// RVA: 0x470060 Offset: 0x46F260 VA: 0x180470060 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, long achievementId, byte percentComplete, IntPtr callbackData, AchievementManager.FFIMethods.SetUserAchievementCallback callback, AsyncCallback __callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class AchievementManager.FFIMethods.FetchUserAchievementsCallback : MulticastDelegate // TypeDefIndex: 10758
{
	// Methods

	// RVA: 0x43DB50 Offset: 0x43CD50 VA: 0x18043DB50
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(IntPtr ptr, Result result) { }

	// RVA: 0x46EF60 Offset: 0x46E160 VA: 0x18046EF60 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr ptr, Result result, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class AchievementManager.FFIMethods.FetchUserAchievementsMethod : MulticastDelegate // TypeDefIndex: 10759
{
	// Methods

	// RVA: 0x441EC0 Offset: 0x4410C0 VA: 0x180441EC0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x409CF0 Offset: 0x408EF0 VA: 0x180409CF0 Slot: 13
	public virtual void Invoke(IntPtr methodsPtr, IntPtr callbackData, AchievementManager.FFIMethods.FetchUserAchievementsCallback callback) { }

	// RVA: 0x46F080 Offset: 0x46E280 VA: 0x18046F080 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, IntPtr callbackData, AchievementManager.FFIMethods.FetchUserAchievementsCallback callback, AsyncCallback __callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class AchievementManager.FFIMethods.CountUserAchievementsMethod : MulticastDelegate // TypeDefIndex: 10760
{
	// Methods

	// RVA: 0x43FEE0 Offset: 0x43F0E0 VA: 0x18043FEE0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x425B10 Offset: 0x424D10 VA: 0x180425B10 Slot: 13
	public virtual void Invoke(IntPtr methodsPtr, ref int count) { }

	// RVA: 0x46E8E0 Offset: 0x46DAE0 VA: 0x18046E8E0 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, ref int count, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref int count, IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class AchievementManager.FFIMethods.GetUserAchievementMethod : MulticastDelegate // TypeDefIndex: 10761
{
	// Methods

	// RVA: 0x409D10 Offset: 0x408F10 VA: 0x180409D10
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x409CF0 Offset: 0x408EF0 VA: 0x180409CF0 Slot: 13
	public virtual Result Invoke(IntPtr methodsPtr, long userAchievementId, ref UserAchievement userAchievement) { }

	// RVA: 0x46F640 Offset: 0x46E840 VA: 0x18046F640 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, long userAchievementId, ref UserAchievement userAchievement, AsyncCallback callback, object object) { }

	// RVA: 0x3FEA30 Offset: 0x3FDC30 VA: 0x1803FEA30 Slot: 15
	public virtual Result EndInvoke(ref UserAchievement userAchievement, IAsyncResult result) { }
}

// Namespace: 
[UnmanagedFunctionPointer(1)]
internal sealed class AchievementManager.FFIMethods.GetUserAchievementAtMethod : MulticastDelegate // TypeDefIndex: 10762
{
	// Methods

	// RVA: 0x4585F0 Offset: 0x4577F0 VA: 0x1804585F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x409CF0 Offset: 0x408EF0 VA: 0x180409CF0 Slot: 13
	public virtual Result Invoke(IntPtr methodsPtr, int index, ref UserAchievement userAchievement) { }

	// RVA: 0x46F580 Offset: 0x46E780 VA: 0x18046F580 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr methodsPtr, int index, ref UserAchievement userAchievement, AsyncCallback callback, object object) { }

	// RVA: 0x3FEA30 Offset: 0x3FDC30 VA: 0x1803FEA30 Slot: 15
	public virtual Result EndInvoke(ref UserAchievement userAchievement, IAsyncResult result) { }
}

// Namespace: 
internal struct AchievementManager.FFIMethods // TypeDefIndex: 10763
{
	// Fields
	internal AchievementManager.FFIMethods.SetUserAchievementMethod SetUserAchievement; // 0x0
	internal AchievementManager.FFIMethods.FetchUserAchievementsMethod FetchUserAchievements; // 0x8
	internal AchievementManager.FFIMethods.CountUserAchievementsMethod CountUserAchievements; // 0x10
	internal AchievementManager.FFIMethods.GetUserAchievementMethod GetUserAchievement; // 0x18
	internal AchievementManager.FFIMethods.GetUserAchievementAtMethod GetUserAchievementAt; // 0x20
}

// Namespace: 
public sealed class AchievementManager.SetUserAchievementHandler : MulticastDelegate // TypeDefIndex: 10764
{
	// Methods

	// RVA: 0x43DC70 Offset: 0x43CE70 VA: 0x18043DC70
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(Result result) { }

	// RVA: 0x46FFE0 Offset: 0x46F1E0 VA: 0x18046FFE0 Slot: 14
	public virtual IAsyncResult BeginInvoke(Result result, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class AchievementManager.FetchUserAchievementsHandler : MulticastDelegate // TypeDefIndex: 10765
{
	// Methods

	// RVA: 0x43DC70 Offset: 0x43CE70 VA: 0x18043DC70
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(Result result) { }

	// RVA: 0x46F000 Offset: 0x46E200 VA: 0x18046F000 Slot: 14
	public virtual IAsyncResult BeginInvoke(Result result, AsyncCallback callback, object object) { }

	// RVA: 0x3FD240 Offset: 0x3FC440 VA: 0x1803FD240 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class AchievementManager.UserAchievementUpdateHandler : MulticastDelegate // TypeDefIndex: 10766
{
	// Methods

	// RVA: 0x3FE090 Offset: 0x3FD290 VA: 0x1803FE090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3FD250 Offset: 0x3FC450 VA: 0x1803FD250 Slot: 13
	public virtual void Invoke(ref UserAchievement userAchievement) { }

	// RVA: 0x470440 Offset: 0x46F640 VA: 0x180470440 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref UserAchievement userAchievement, AsyncCallback callback, object object) { }

	// RVA: 0x3FE070 Offset: 0x3FD270 VA: 0x1803FE070 Slot: 15
	public virtual void EndInvoke(ref UserAchievement userAchievement, IAsyncResult result) { }
}

// Namespace: Discord
public class AchievementManager // TypeDefIndex: 10767
{
	// Fields
	private IntPtr MethodsPtr; // 0x10
	private object MethodsStructure; // 0x18
	[CompilerGenerated]
	private AchievementManager.UserAchievementUpdateHandler OnUserAchievementUpdate; // 0x20

	// Properties
	private AchievementManager.FFIMethods Methods { get; }

	// Methods

	// RVA: 0x46E5E0 Offset: 0x46D7E0 VA: 0x18046E5E0
	private AchievementManager.FFIMethods get_Methods() { }

	[CompilerGenerated]
	// RVA: 0x46E540 Offset: 0x46D740 VA: 0x18046E540
	public void add_OnUserAchievementUpdate(AchievementManager.UserAchievementUpdateHandler value) { }

	[CompilerGenerated]
	// RVA: 0x46E700 Offset: 0x46D900 VA: 0x18046E700
	public void remove_OnUserAchievementUpdate(AchievementManager.UserAchievementUpdateHandler value) { }

	// RVA: 0x46E360 Offset: 0x46D560 VA: 0x18046E360
	internal void .ctor(IntPtr ptr, IntPtr eventsPtr, ref AchievementManager.FFIEvents events) { }

	// RVA: 0x46DF50 Offset: 0x46D150 VA: 0x18046DF50
	private void InitEvents(IntPtr eventsPtr, ref AchievementManager.FFIEvents events) { }

	[MonoPInvokeCallback]
	// RVA: 0x46E150 Offset: 0x46D350 VA: 0x18046E150
	private static void SetUserAchievementCallbackImpl(IntPtr ptr, Result result) { }

	// RVA: 0x46E200 Offset: 0x46D400 VA: 0x18046E200
	public void SetUserAchievement(long achievementId, byte percentComplete, AchievementManager.SetUserAchievementHandler callback) { }

	[MonoPInvokeCallback]
	// RVA: 0x46DBC0 Offset: 0x46CDC0 VA: 0x18046DBC0
	private static void FetchUserAchievementsCallbackImpl(IntPtr ptr, Result result) { }

	// RVA: 0x46DC70 Offset: 0x46CE70 VA: 0x18046DC70
	public void FetchUserAchievements(AchievementManager.FetchUserAchievementsHandler callback) { }

	// RVA: 0x46DB60 Offset: 0x46CD60 VA: 0x18046DB60
	public int CountUserAchievements() { }

	// RVA: 0x46DE90 Offset: 0x46D090 VA: 0x18046DE90
	public UserAchievement GetUserAchievement(long userAchievementId) { }

	// RVA: 0x46DDC0 Offset: 0x46CFC0 VA: 0x18046DDC0
	public UserAchievement GetUserAchievementAt(int index) { }

	[MonoPInvokeCallback]
	// RVA: 0x46E070 Offset: 0x46D270 VA: 0x18046E070
	private static void OnUserAchievementUpdateImpl(IntPtr ptr, ref UserAchievement userAchievement) { }
}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=78274 // TypeDefIndex: 10768
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=120675 // TypeDefIndex: 10769
{}

// Namespace: 
[CompilerGenerated]
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 10770
{
	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=78274 03870B21017FA866011B71CD0411BB350BAC5D7307C9FB09250013B82A6985B2 /*Metadata offset 0x8AADA0*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=120675 B74F649BC38EABD79A3018A929B0AFCE1BE3C083BDCC5F33C37ADDBF92E75D0C /*Metadata offset 0x8BDF68*/; // 0x131C2
}

// Namespace: 
internal class <Module> // TypeDefIndex: 10771
{}

// Namespace: UnityEngine.Yoga
internal sealed class BaselineFunction : MulticastDelegate // TypeDefIndex: 10772
{
	// Methods

	// RVA: 0x2572DB0 Offset: 0x2571FB0 VA: 0x182572DB0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x2572D90 Offset: 0x2571F90 VA: 0x182572D90 Slot: 13
	public virtual float Invoke(YogaNode node, float width, float height) { }
}

// Namespace: UnityEngine.Yoga
internal sealed class Logger : MulticastDelegate // TypeDefIndex: 10773
{
	// Methods

	// RVA: 0x2578BC0 Offset: 0x2577DC0 VA: 0x182578BC0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x43DDD0 Offset: 0x43CFD0 VA: 0x18043DDD0 Slot: 13
	public virtual void Invoke(YogaConfig config, YogaNode node, YogaLogLevel level, string message) { }
}

// Namespace: UnityEngine.Yoga
internal sealed class MeasureFunction : MulticastDelegate // TypeDefIndex: 10774
{
	// Methods

	// RVA: 0x2578D00 Offset: 0x2577F00 VA: 0x182578D00
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x2578CE0 Offset: 0x2577EE0 VA: 0x182578CE0 Slot: 13
	public virtual YogaSize Invoke(YogaNode node, float width, YogaMeasureMode widthMode, float height, YogaMeasureMode heightMode) { }
}

// Namespace: UnityEngine.Yoga
internal class MeasureOutput // TypeDefIndex: 10775
{
	// Methods

	// RVA: 0x2578E20 Offset: 0x2578020 VA: 0x182578E20
	public static YogaSize Make(float width, float height) { }
}

// Namespace: UnityEngine.Yoga
internal enum YogaAlign // TypeDefIndex: 10776
{
	// Fields
	public int value__; // 0x0
	public const YogaAlign Auto = 0;
	public const YogaAlign FlexStart = 1;
	public const YogaAlign Center = 2;
	public const YogaAlign FlexEnd = 3;
	public const YogaAlign Stretch = 4;
	public const YogaAlign Baseline = 5;
	public const YogaAlign SpaceBetween = 6;
	public const YogaAlign SpaceAround = 7;
}

// Namespace: UnityEngine.Yoga
internal class YogaConfig // TypeDefIndex: 10777
{
	// Fields
	internal static readonly YogaConfig Default; // 0x0
	private IntPtr _ygConfig; // 0x10
	private Logger _logger; // 0x18

	// Properties
	internal IntPtr Handle { get; }
	public bool UseWebDefaults { get; set; }
	public float PointScaleFactor { set; }

	// Methods

	// RVA: 0x257F3B0 Offset: 0x257E5B0 VA: 0x18257F3B0
	private void .ctor(IntPtr ygConfig) { }

	// RVA: 0x257F370 Offset: 0x257E570 VA: 0x18257F370
	public void .ctor() { }

	// RVA: 0x257F1E0 Offset: 0x257E3E0 VA: 0x18257F1E0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1208660 Offset: 0x1207860 VA: 0x181208660
	internal IntPtr get_Handle() { }

	// RVA: 0x257F430 Offset: 0x257E630 VA: 0x18257F430
	public bool get_UseWebDefaults() { }

	// RVA: 0x257F4C0 Offset: 0x257E6C0 VA: 0x18257F4C0
	public void set_UseWebDefaults(bool value) { }

	// RVA: 0x257F470 Offset: 0x257E670 VA: 0x18257F470
	public void set_PointScaleFactor(float value) { }

	// RVA: 0x257F2E0 Offset: 0x257E4E0 VA: 0x18257F2E0
	private static void .cctor() { }
}

// Namespace: UnityEngine.Yoga
internal static class YogaConstants // TypeDefIndex: 10778
{
	// Methods

	// RVA: 0x257F510 Offset: 0x257E710 VA: 0x18257F510
	public static bool IsUndefined(float value) { }
}

// Namespace: UnityEngine.Yoga
internal enum YogaDirection // TypeDefIndex: 10779
{
	// Fields
	public int value__; // 0x0
	public const YogaDirection Inherit = 0;
	public const YogaDirection LTR = 1;
	public const YogaDirection RTL = 2;
}

// Namespace: UnityEngine.Yoga
internal enum YogaDisplay // TypeDefIndex: 10780
{
	// Fields
	public int value__; // 0x0
	public const YogaDisplay Flex = 0;
	public const YogaDisplay None = 1;
}

// Namespace: UnityEngine.Yoga
internal enum YogaEdge // TypeDefIndex: 10781
{
	// Fields
	public int value__; // 0x0
	public const YogaEdge Left = 0;
	public const YogaEdge Top = 1;
	public const YogaEdge Right = 2;
	public const YogaEdge Bottom = 3;
	public const YogaEdge Start = 4;
	public const YogaEdge End = 5;
	public const YogaEdge Horizontal = 6;
	public const YogaEdge Vertical = 7;
	public const YogaEdge All = 8;
}

// Namespace: UnityEngine.Yoga
internal enum YogaFlexDirection // TypeDefIndex: 10782
{
	// Fields
	public int value__; // 0x0
	public const YogaFlexDirection Column = 0;
	public const YogaFlexDirection ColumnReverse = 1;
	public const YogaFlexDirection Row = 2;
	public const YogaFlexDirection RowReverse = 3;
}

// Namespace: UnityEngine.Yoga
internal enum YogaJustify // TypeDefIndex: 10783
{
	// Fields
	public int value__; // 0x0
	public const YogaJustify FlexStart = 0;
	public const YogaJustify Center = 1;
	public const YogaJustify FlexEnd = 2;
	public const YogaJustify SpaceBetween = 3;
	public const YogaJustify SpaceAround = 4;
}

// Namespace: UnityEngine.Yoga
internal enum YogaLogLevel // TypeDefIndex: 10784
{
	// Fields
	public int value__; // 0x0
	public const YogaLogLevel Error = 0;
	public const YogaLogLevel Warn = 1;
	public const YogaLogLevel Info = 2;
	public const YogaLogLevel Debug = 3;
	public const YogaLogLevel Verbose = 4;
	public const YogaLogLevel Fatal = 5;
}

// Namespace: UnityEngine.Yoga
internal enum YogaMeasureMode // TypeDefIndex: 10785
{
	// Fields
	public int value__; // 0x0
	public const YogaMeasureMode Undefined = 0;
	public const YogaMeasureMode Exactly = 1;
	public const YogaMeasureMode AtMost = 2;
}

// Namespace: UnityEngine.Yoga
[NativeHeader("ModuleOverrides/com.unity.ui/Core/Native/YogaNative.bindings.h")]
internal static class Native // TypeDefIndex: 10786
{
	// Methods

	[FreeFunction]
	// RVA: 0x257A1C0 Offset: 0x25793C0 VA: 0x18257A1C0
	public static IntPtr YGNodeNewWithConfig(IntPtr config) { }

	// RVA: 0x2579D10 Offset: 0x2578F10 VA: 0x182579D10
	public static void YGNodeFree(IntPtr ygNode) { }

	[FreeFunction(Name = "YGNodeFree", IsThreadSafe = True)]
	// RVA: 0x2579CD0 Offset: 0x2578ED0 VA: 0x182579CD0
	private static void YGNodeFreeInternal(IntPtr ygNode) { }

	[FreeFunction]
	// RVA: 0x257AE70 Offset: 0x257A070 VA: 0x18257AE70
	public static void YGSetManagedObject(IntPtr ygNode, YogaNode node) { }

	[FreeFunction]
	// RVA: 0x257A290 Offset: 0x2579490 VA: 0x18257A290
	public static void YGNodeSetConfig(IntPtr ygNode, IntPtr config) { }

	[FreeFunction(IsThreadSafe = True)]
	// RVA: 0x2579A10 Offset: 0x2578C10 VA: 0x182579A10
	public static IntPtr YGConfigGetDefault() { }

	[FreeFunction]
	// RVA: 0x2579A80 Offset: 0x2578C80 VA: 0x182579A80
	public static IntPtr YGConfigNew() { }

	// RVA: 0x25799C0 Offset: 0x2578BC0 VA: 0x1825799C0
	public static void YGConfigFree(IntPtr config) { }

	[FreeFunction(Name = "YGConfigFree", IsThreadSafe = True)]
	// RVA: 0x2579980 Offset: 0x2578B80 VA: 0x182579980
	private static void YGConfigFreeInternal(IntPtr config) { }

	[FreeFunction]
	// RVA: 0x2579B00 Offset: 0x2578D00 VA: 0x182579B00
	public static void YGConfigSetUseWebDefaults(IntPtr config, bool useWebDefaults) { }

	[FreeFunction]
	// RVA: 0x2579A40 Offset: 0x2578C40 VA: 0x182579A40
	public static bool YGConfigGetUseWebDefaults(IntPtr config) { }

	[FreeFunction]
	// RVA: 0x2579AB0 Offset: 0x2578CB0 VA: 0x182579AB0
	public static void YGConfigSetPointScaleFactor(IntPtr config, float pixelsInPoint) { }

	[FreeFunction]
	// RVA: 0x2579DA0 Offset: 0x2578FA0 VA: 0x182579DA0
	public static void YGNodeInsertChild(IntPtr node, IntPtr child, uint index) { }

	[FreeFunction]
	// RVA: 0x257A200 Offset: 0x2579400 VA: 0x18257A200
	public static void YGNodeRemoveChild(IntPtr node, IntPtr child) { }

	[FreeFunction]
	// RVA: 0x2579C10 Offset: 0x2578E10 VA: 0x182579C10
	public static void YGNodeCalculateLayout(IntPtr node, float availableWidth, float availableHeight, YogaDirection parentDirection) { }

	[FreeFunction]
	// RVA: 0x257A080 Offset: 0x2579280 VA: 0x18257A080
	public static void YGNodeMarkDirty(IntPtr node) { }

	[FreeFunction]
	// RVA: 0x2579E00 Offset: 0x2579000 VA: 0x182579E00
	public static bool YGNodeIsDirty(IntPtr node) { }

	[FreeFunction]
	// RVA: 0x2579C80 Offset: 0x2578E80 VA: 0x182579C80
	public static void YGNodeCopyStyle(IntPtr dstNode, IntPtr srcNode) { }

	[FreeFunction(Name = "YogaCallback::SetMeasureFunc")]
	// RVA: 0x257A330 Offset: 0x2579530 VA: 0x18257A330
	public static void YGNodeSetMeasureFunc(IntPtr node) { }

	[FreeFunction(Name = "YogaCallback::RemoveMeasureFunc")]
	// RVA: 0x257A250 Offset: 0x2579450 VA: 0x18257A250
	public static void YGNodeRemoveMeasureFunc(IntPtr node) { }

	[RequiredByNativeCode]
	// RVA: 0x257A0C0 Offset: 0x25792C0 VA: 0x18257A0C0
	public static void YGNodeMeasureInvoke(YogaNode node, float width, YogaMeasureMode widthMode, float height, YogaMeasureMode heightMode, IntPtr returnValueAddress) { }

	[RequiredByNativeCode]
	// RVA: 0x2579B50 Offset: 0x2578D50 VA: 0x182579B50
	public static void YGNodeBaselineInvoke(YogaNode node, float width, float height, IntPtr returnValueAddress) { }

	[FreeFunction]
	// RVA: 0x257A2E0 Offset: 0x25794E0 VA: 0x18257A2E0
	public static void YGNodeSetHasNewLayout(IntPtr node, bool hasNewLayout) { }

	[FreeFunction]
	// RVA: 0x2579D60 Offset: 0x2578F60 VA: 0x182579D60
	public static bool YGNodeGetHasNewLayout(IntPtr node) { }

	[FreeFunction]
	// RVA: 0x257A370 Offset: 0x2579570 VA: 0x18257A370
	public static YogaDirection YGNodeStyleGetDirection(IntPtr node) { }

	[FreeFunction]
	// RVA: 0x257A5E0 Offset: 0x25797E0 VA: 0x18257A5E0
	public static void YGNodeStyleSetFlexDirection(IntPtr node, YogaFlexDirection flexDirection) { }

	[FreeFunction]
	// RVA: 0x257A830 Offset: 0x2579A30 VA: 0x18257A830
	public static void YGNodeStyleSetJustifyContent(IntPtr node, YogaJustify justifyContent) { }

	[FreeFunction]
	// RVA: 0x257A3B0 Offset: 0x25795B0 VA: 0x18257A3B0
	public static void YGNodeStyleSetAlignContent(IntPtr node, YogaAlign alignContent) { }

	[FreeFunction]
	// RVA: 0x257A3F0 Offset: 0x25795F0 VA: 0x18257A3F0
	public static void YGNodeStyleSetAlignItems(IntPtr node, YogaAlign alignItems) { }

	[FreeFunction]
	// RVA: 0x257A430 Offset: 0x2579630 VA: 0x18257A430
	public static void YGNodeStyleSetAlignSelf(IntPtr node, YogaAlign alignSelf) { }

	[FreeFunction]
	// RVA: 0x257AD00 Offset: 0x2579F00 VA: 0x18257AD00
	public static void YGNodeStyleSetPositionType(IntPtr node, YogaPositionType positionType) { }

	[FreeFunction]
	// RVA: 0x257A6C0 Offset: 0x25798C0 VA: 0x18257A6C0
	public static void YGNodeStyleSetFlexWrap(IntPtr node, YogaWrap flexWrap) { }

	[FreeFunction]
	// RVA: 0x257ABD0 Offset: 0x2579DD0 VA: 0x18257ABD0
	public static void YGNodeStyleSetOverflow(IntPtr node, YogaOverflow flexWrap) { }

	[FreeFunction]
	// RVA: 0x257A4C0 Offset: 0x25796C0 VA: 0x18257A4C0
	public static void YGNodeStyleSetDisplay(IntPtr node, YogaDisplay display) { }

	[FreeFunction]
	// RVA: 0x257A700 Offset: 0x2579900 VA: 0x18257A700
	public static void YGNodeStyleSetFlex(IntPtr node, float flex) { }

	[FreeFunction]
	// RVA: 0x257A620 Offset: 0x2579820 VA: 0x18257A620
	public static void YGNodeStyleSetFlexGrow(IntPtr node, float flexGrow) { }

	[FreeFunction]
	// RVA: 0x257A670 Offset: 0x2579870 VA: 0x18257A670
	public static void YGNodeStyleSetFlexShrink(IntPtr node, float flexShrink) { }

	[FreeFunction]
	// RVA: 0x257A590 Offset: 0x2579790 VA: 0x18257A590
	public static void YGNodeStyleSetFlexBasis(IntPtr node, float flexBasis) { }

	[FreeFunction]
	// RVA: 0x257A540 Offset: 0x2579740 VA: 0x18257A540
	public static void YGNodeStyleSetFlexBasisPercent(IntPtr node, float flexBasis) { }

	[FreeFunction]
	// RVA: 0x257A500 Offset: 0x2579700 VA: 0x18257A500
	public static void YGNodeStyleSetFlexBasisAuto(IntPtr node) { }

	[FreeFunction]
	// RVA: 0x257AE20 Offset: 0x257A020 VA: 0x18257AE20
	public static void YGNodeStyleSetWidth(IntPtr node, float width) { }

	[FreeFunction]
	// RVA: 0x257ADD0 Offset: 0x2579FD0 VA: 0x18257ADD0
	public static void YGNodeStyleSetWidthPercent(IntPtr node, float width) { }

	[FreeFunction]
	// RVA: 0x257AD90 Offset: 0x2579F90 VA: 0x18257AD90
	public static void YGNodeStyleSetWidthAuto(IntPtr node) { }

	[FreeFunction]
	// RVA: 0x257A7E0 Offset: 0x25799E0 VA: 0x18257A7E0
	public static void YGNodeStyleSetHeight(IntPtr node, float height) { }

	[FreeFunction]
	// RVA: 0x257A790 Offset: 0x2579990 VA: 0x18257A790
	public static void YGNodeStyleSetHeightPercent(IntPtr node, float height) { }

	[FreeFunction]
	// RVA: 0x257A750 Offset: 0x2579950 VA: 0x18257A750
	public static void YGNodeStyleSetHeightAuto(IntPtr node) { }

	[FreeFunction]
	// RVA: 0x257AB80 Offset: 0x2579D80 VA: 0x18257AB80
	public static void YGNodeStyleSetMinWidth(IntPtr node, float minWidth) { }

	[FreeFunction]
	// RVA: 0x257AB30 Offset: 0x2579D30 VA: 0x18257AB30
	public static void YGNodeStyleSetMinWidthPercent(IntPtr node, float minWidth) { }

	[FreeFunction]
	// RVA: 0x257AAE0 Offset: 0x2579CE0 VA: 0x18257AAE0
	public static void YGNodeStyleSetMinHeight(IntPtr node, float minHeight) { }

	[FreeFunction]
	// RVA: 0x257AA90 Offset: 0x2579C90 VA: 0x18257AA90
	public static void YGNodeStyleSetMinHeightPercent(IntPtr node, float minHeight) { }

	[FreeFunction]
	// RVA: 0x257AA40 Offset: 0x2579C40 VA: 0x18257AA40
	public static void YGNodeStyleSetMaxWidth(IntPtr node, float maxWidth) { }

	[FreeFunction]
	// RVA: 0x257A9F0 Offset: 0x2579BF0 VA: 0x18257A9F0
	public static void YGNodeStyleSetMaxWidthPercent(IntPtr node, float maxWidth) { }

	[FreeFunction]
	// RVA: 0x257A9A0 Offset: 0x2579BA0 VA: 0x18257A9A0
	public static void YGNodeStyleSetMaxHeight(IntPtr node, float maxHeight) { }

	[FreeFunction]
	// RVA: 0x257A950 Offset: 0x2579B50 VA: 0x18257A950
	public static void YGNodeStyleSetMaxHeightPercent(IntPtr node, float maxHeight) { }

	[FreeFunction]
	// RVA: 0x257AD40 Offset: 0x2579F40 VA: 0x18257AD40
	public static void YGNodeStyleSetPosition(IntPtr node, YogaEdge edge, float position) { }

	[FreeFunction]
	// RVA: 0x257ACB0 Offset: 0x2579EB0 VA: 0x18257ACB0
	public static void YGNodeStyleSetPositionPercent(IntPtr node, YogaEdge edge, float position) { }

	[FreeFunction]
	// RVA: 0x257A900 Offset: 0x2579B00 VA: 0x18257A900
	public static void YGNodeStyleSetMargin(IntPtr node, YogaEdge edge, float margin) { }

	[FreeFunction]
	// RVA: 0x257A8B0 Offset: 0x2579AB0 VA: 0x18257A8B0
	public static void YGNodeStyleSetMarginPercent(IntPtr node, YogaEdge edge, float margin) { }

	[FreeFunction]
	// RVA: 0x257A870 Offset: 0x2579A70 VA: 0x18257A870
	public static void YGNodeStyleSetMarginAuto(IntPtr node, YogaEdge edge) { }

	[FreeFunction]
	// RVA: 0x257AC60 Offset: 0x2579E60 VA: 0x18257AC60
	public static void YGNodeStyleSetPadding(IntPtr node, YogaEdge edge, float padding) { }

	[FreeFunction]
	// RVA: 0x257AC10 Offset: 0x2579E10 VA: 0x18257AC10
	public static void YGNodeStyleSetPaddingPercent(IntPtr node, YogaEdge edge, float padding) { }

	[FreeFunction]
	// RVA: 0x257A470 Offset: 0x2579670 VA: 0x18257A470
	public static void YGNodeStyleSetBorder(IntPtr node, YogaEdge edge, float border) { }

	[FreeFunction]
	// RVA: 0x2579F00 Offset: 0x2579100 VA: 0x182579F00
	public static float YGNodeLayoutGetLeft(IntPtr node) { }

	[FreeFunction]
	// RVA: 0x257A000 Offset: 0x2579200 VA: 0x18257A000
	public static float YGNodeLayoutGetTop(IntPtr node) { }

	[FreeFunction]
	// RVA: 0x2579FC0 Offset: 0x25791C0 VA: 0x182579FC0
	public static float YGNodeLayoutGetRight(IntPtr node) { }

	[FreeFunction]
	// RVA: 0x2579E80 Offset: 0x2579080 VA: 0x182579E80
	public static float YGNodeLayoutGetBottom(IntPtr node) { }

	[FreeFunction]
	// RVA: 0x257A040 Offset: 0x2579240 VA: 0x18257A040
	public static float YGNodeLayoutGetWidth(IntPtr node) { }

	[FreeFunction]
	// RVA: 0x2579EC0 Offset: 0x25790C0 VA: 0x182579EC0
	public static float YGNodeLayoutGetHeight(IntPtr node) { }

	[FreeFunction]
	// RVA: 0x2579F40 Offset: 0x2579140 VA: 0x182579F40
	public static float YGNodeLayoutGetMargin(IntPtr node, YogaEdge edge) { }

	[FreeFunction]
	// RVA: 0x2579F80 Offset: 0x2579180 VA: 0x182579F80
	public static float YGNodeLayoutGetPadding(IntPtr node, YogaEdge edge) { }

	[FreeFunction]
	// RVA: 0x2579E40 Offset: 0x2579040 VA: 0x182579E40
	public static float YGNodeLayoutGetBorder(IntPtr node, YogaEdge edge) { }
}

// Namespace: UnityEngine.Yoga
[DefaultMember("Item")]
internal class YogaNode : IEnumerable<YogaNode>, IEnumerable // TypeDefIndex: 10787
{
	// Fields
	internal IntPtr _ygNode; // 0x10
	private YogaConfig _config; // 0x18
	private WeakReference _parent; // 0x20
	private List<YogaNode> _children; // 0x28
	private MeasureFunction _measureFunction; // 0x30
	private BaselineFunction _baselineFunction; // 0x38
	private object _data; // 0x40

	// Properties
	internal YogaConfig Config { set; }
	public bool IsDirty { get; }
	public bool HasNewLayout { get; }
	public bool IsMeasureDefined { get; }
	public bool IsBaselineDefined { get; }
	public YogaFlexDirection FlexDirection { set; }
	public YogaJustify JustifyContent { set; }
	public YogaDisplay Display { set; }
	public YogaAlign AlignItems { set; }
	public YogaAlign AlignSelf { set; }
	public YogaAlign AlignContent { set; }
	public YogaPositionType PositionType { set; }
	public YogaWrap Wrap { set; }
	public float Flex { set; }
	public float FlexGrow { set; }
	public float FlexShrink { set; }
	public YogaValue FlexBasis { set; }
	public YogaValue Width { set; }
	public YogaValue Height { set; }
	public YogaValue MaxWidth { set; }
	public YogaValue MaxHeight { set; }
	public YogaValue MinWidth { set; }
